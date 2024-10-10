using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading;
using Melia.Shared.Configuration;
using Melia.Shared.Data;
using Melia.Shared.Data.Database;
using Melia.Shared.Database;
using Melia.Shared.Game.Properties;
using Melia.Shared.L10N;
using Melia.Shared.Network;
using Yggdrasil.Data;
using Yggdrasil.Extensions;
using Yggdrasil.Logging;
using Yggdrasil.Network.TCP;
using Yggdrasil.Scripting;
using Yggdrasil.Util;

namespace Melia.Shared
{
	/// <summary>
	/// Base class for server applications.
	/// </summary>
	public abstract class Server
	{
		/// <summary>
		/// Returns this server's server info.
		/// </summary>
		public ServerInfo ServerInfo { get; private set; }

		/// <summary>
		/// Returns a reference to all conf files.
		/// </summary>
		public ConfFiles Conf { get; } = new ConfFiles();

		/// <summary>
		/// Returns a reference to the server's loaded data.
		/// </summary>
		public MeliaData Data { get; } = new MeliaData();

		/// <summary>
		/// Returns a reference to the server's script loader.
		/// </summary>
		protected ScriptLoader ScriptLoader { get; private set; }

		/// <summary>
		/// Returns a reference to the server's string localizer manager.
		/// </summary>
		public MultiLocalizer MultiLocalization { get; } = new MultiLocalizer();

		/// <summary>
		/// Returns a reference to the server list.
		/// </summary>
		public ServerList ServerList { get; } = new ServerList();

		/// <summary>
		/// Starts the server.
		/// </summary>
		/// <param name="args"></param>
		public abstract void Run(string[] args);

		/// <summary>
		/// Changes current directory to the project's root folder.
		/// </summary>
		protected void NavigateToRoot()
		{
			// First go to the assemblies directory and then back from
			// there until we find the root folder.
			var appDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			Directory.SetCurrentDirectory(appDirectory);

			var folderNames = new[] { "bin", "user", "system" };
			var tries = 5;

			for (var i = 0; i < tries; ++i)
			{
				if (folderNames.All(a => Directory.Exists(a)))
					return;

				Directory.SetCurrentDirectory("../");
			}

			throw new DirectoryNotFoundException($"Failed to navigate to root folder. (Missing: {string.Join(", ", folderNames)})");
		}

		/// <summary>
		/// Loads all configuration files.
		/// </summary>
		/// <returns></returns>
		public ConfFiles LoadConf()
		{
			Log.Info("Loading configuration...");

			this.Conf.Load();
			Log.SetFilter(this.Conf.Log.Filter);

			if (this.Conf.Inter.Authentication == "change_me")
				Log.Warning("You're using the default password for inter-server communication. It is highly recommended that you change it in inter.conf.");

			return this.Conf;
		}

		/// <summary>
		/// Loads localization files and updates cultural settings.
		/// </summary>
		/// <returns></returns>
		protected void LoadLocalization(ConfFiles conf)
		{
			CultureInfo.DefaultThreadCurrentCulture = CultureInfo.GetCultureInfo(conf.Localization.Culture);
			CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.GetCultureInfo(conf.Localization.CultureUi);
			Thread.CurrentThread.CurrentCulture = CultureInfo.DefaultThreadCurrentCulture;
			Thread.CurrentThread.CurrentUICulture = CultureInfo.DefaultThreadCurrentUICulture;

			var serverLanguage = conf.Localization.Language;
			var relativeFolderPath = "localization";
			var systemFolderPath = Path.Combine("system", relativeFolderPath);
			var userFolderPath = Path.Combine("system", relativeFolderPath);

			Log.Info("Loading localization...");

			// Load everything from user first, then check system, without
			// overriding the ones loaded from user
			if (Directory.Exists(userFolderPath))
			{
				foreach (var filePath in Directory.EnumerateFiles(userFolderPath, "*.po", SearchOption.AllDirectories))
				{
					var languageName = Path.GetFileNameWithoutExtension(filePath);
					this.MultiLocalization.Load(languageName, filePath);

					Log.Info("  loaded {0}.", languageName);
				}
			}

			if (Directory.Exists(systemFolderPath))
			{
				foreach (var filePath in Directory.EnumerateFiles(systemFolderPath, "*.po", SearchOption.AllDirectories))
				{
					var languageName = Path.GetFileNameWithoutExtension(filePath);
					if (this.MultiLocalization.Contains(languageName))
						continue;

					this.MultiLocalization.Load(languageName, filePath);

					Log.Info("  loaded {0}.", languageName);
				}
			}

			Log.Info("  setting default language to {0}.", serverLanguage);

			// Try to set the default localizer, and warn the user about
			// missing localizers if the selected server language isn't
			// US english.
			if (!this.MultiLocalization.Contains(serverLanguage))
			{
				if (serverLanguage != "en-US")
					Log.Warning("Localization file '{0}.po' not found.", serverLanguage);
			}
			else
			{
				this.MultiLocalization.SetDefault(serverLanguage);
			}

			Melia.Shared.L10N.Localization.SetLocalizer(this.MultiLocalization.GetDefault());
		}

		/// <summary>
		/// Initializes database connection with data from Conf.
		/// </summary>
		protected void InitDatabase(MeliaDb db, ConfFiles conf)
		{
			try
			{
				Log.Info("Initializing database...");
				db.Init(conf.Database.Host, conf.Database.User, conf.Database.Pass, conf.Database.Db);
			}
			catch (Exception ex)
			{
				Log.Error("Failed to initialize database: {0}", ex.Message);
				ConsoleUtil.Exit(1, true);
			}
		}

		/// <summary>
		/// Loads data from files.
		/// </summary>
		public void LoadData(ServerType serverType)
		{
			Log.Info("Loading data...");

			try
			{
				// Originally we were using a bitmask to specify which dbs
				// to load, but that's not very scalable, because even with
				// 64 bits, we'd run out of bits eventually. We could use a
				// list of enums, but that's kind of annoying to manage.
				// So we'll be lazy for now and just if/else it.
				// We could also move it to the servers to clean it up a
				// bit. TBD.

				if (serverType == ServerType.Barracks)
				{
					this.LoadDb(this.Data.BarrackDb, "db/barracks.txt");
					this.LoadDb(this.Data.ExpDb, "db/exp.txt");
					this.LoadDb(this.Data.FeatureDb, "db/features.txt");
					this.LoadDb(this.Data.InvBaseIdDb, "db/invbaseids.txt");
					this.LoadDb(this.Data.ItemDb, "db/items.txt");
					this.LoadDb(this.Data.JobDb, "db/jobs.txt");
					this.LoadDb(this.Data.MapDb, "db/maps.txt");
					this.LoadDb(this.Data.PropertiesDb, "db/properties.txt");
					this.LoadDb(this.Data.ServerDb, "db/servers.txt");
					this.LoadDb(this.Data.SkinToneDb, "db/skin_tones.txt");
					this.LoadDb(this.Data.StanceConditionDb, "db/stanceconditions.txt");

					PropertyTable.Load(this.Data.PropertiesDb);
				}
				else if (serverType == ServerType.Zone)
				{
					this.LoadDb(this.Data.AbilityDb, "db/abilities.txt");
					this.LoadDb(this.Data.AbilityTreeDb, "db/abilitytree.txt");
					this.LoadDb(this.Data.AccountOptionDb, "db/account_options.txt");
					this.LoadDb(this.Data.AchievementDb, "db/achievements.txt");
					this.LoadDb(this.Data.AchievementPointDb, "db/achievement_points.txt");
					this.LoadDb(this.Data.BarrackDb, "db/barracks.txt");
					this.LoadDb(this.Data.BuffDb, "db/buffs.txt");
					this.LoadDb(this.Data.ChatMacroDb, "db/chatmacros.txt");
					this.LoadDb(this.Data.CooldownDb, "db/cooldowns.txt");
					this.LoadDb(this.Data.CustomCommandDb, "db/customcommands.txt");
					this.LoadDb(this.Data.DialogDb, "db/dialogues.txt");
					this.LoadDb(this.Data.DialogTxDb, "db/dialog_tx_scripts.txt");
					this.LoadDb(this.Data.ExpDb, "db/exp.txt");
					this.LoadDb(this.Data.FactionDb, "db/factions.txt");
					this.LoadDb(this.Data.FeatureDb, "db/features.txt");
					this.LoadDb(this.Data.GroundDb, "db/ground.dat");
					this.LoadDb(this.Data.HairTypeDb, "db/hair_types.txt");
					this.LoadDb(this.Data.HelpDb, "db/help.txt");
					this.LoadDb(this.Data.InvBaseIdDb, "db/invbaseids.txt");
					this.LoadDb(this.Data.ItemDb, "db/items.txt");
					this.LoadDb(this.Data.ItemExpDb, "db/item_exp.txt");
					this.LoadDb(this.Data.ItemMonsterDb, "db/itemmonsters.txt");
					this.LoadDb(this.Data.JobDb, "db/jobs.txt");
					this.LoadDb(this.Data.MapDb, "db/maps.txt");
					this.LoadDb(this.Data.MonsterDb, "db/monsters.txt");
					this.LoadDb(this.Data.NormalTxDb, "db/normal_tx_scripts.txt");
					this.LoadDb(this.Data.PacketStringDb, "db/packetstrings.txt");
					this.LoadDb(this.Data.PropertiesDb, "db/properties.txt");
					this.LoadDb(this.Data.RecipeDb, "db/recipes.txt");
					this.LoadDb(this.Data.ResurrectionPointDb, "db/resurrection_points.txt");
					this.LoadDb(this.Data.ServerDb, "db/servers.txt");
					this.LoadDb(this.Data.SessionObjectDb, "db/sessionobjects.txt");
					this.LoadDb(this.Data.ShopDb, "db/shops.txt");
					this.LoadDb(this.Data.SkillDb, "db/skills.txt");
					this.LoadDb(this.Data.SkillTreeDb, "db/skilltree.txt");
					this.LoadDb(this.Data.SkinToneDb, "db/skin_tones.txt");
					this.LoadDb(this.Data.StanceConditionDb, "db/stanceconditions.txt");
					this.LoadDb(this.Data.SystemMessageDb, "db/system_messages.txt");

					// Load collections after properties and items, to enable
					// data checks
					this.LoadDb(this.Data.CollectionDb, "db/collections.txt");

					PropertyTable.Load(this.Data.PropertiesDb);
				}
				else if (serverType == ServerType.Social)
				{
					this.LoadDb(this.Data.PropertiesDb, "db/properties.txt");
					this.LoadDb(this.Data.ServerDb, "db/servers.txt");
					this.LoadDb(this.Data.SystemMessageDb, "db/system_messages.txt");
				}
				else if (serverType == ServerType.Web)
				{
					this.LoadDb(this.Data.ServerDb, "db/servers.txt");
				}

			}
			catch (DatabaseErrorException ex)
			{
				Log.Error(ex.ToString());
				ConsoleUtil.Exit(1);
			}
			catch (FileNotFoundException ex)
			{
				Log.Error(ex.Message);
				ConsoleUtil.Exit(1);
			}
			catch (Exception ex)
			{
				Log.Error("Error while loading data: " + ex);
				ConsoleUtil.Exit(1);
			}
		}

		/// <summary>
		/// Loads db, first from system, then from user.
		/// Logs problems as warnings.
		/// </summary>
		private void LoadDb(IDatabase db, string fileName)
		{
			var systemPath = Path.Combine("system", fileName).Replace('\\', '/');
			var userPath = Path.Combine("user", fileName).Replace('\\', '/');

			if (!File.Exists(systemPath))
			{
				Log.Error("LoadDataFile: File '{0}' not found.", systemPath);
				ConsoleUtil.Exit(1);
				return;
			}

			db.Clear();
			db.LoadFile(systemPath);
			foreach (var ex in db.GetWarnings())
				Log.Warning(ex);

			if (File.Exists(userPath))
			{
				db.LoadFile(userPath);
				foreach (var ex in db.GetWarnings())
					Log.Warning(ex);
			}

			if (db.Count == 1)
				Log.Info("  done loading {0} entry from {1}.", db.Count, fileName);
			else
				Log.Info("  done loading {0} entries from {1}.", db.Count, fileName);
		}

		/// <summary>
		/// Loads given conf class and stops start up when an error
		/// occurs.
		/// </summary>
		/// <param name="conf"></param>
		protected void LoadConf(ConfFiles conf)
		{
			try
			{
				Log.Info("Loading configuration...");
				conf.Load();
			}
			catch (Exception ex)
			{
				Log.Error("Failed to load configuration: {0}", ex.Message);
				ConsoleUtil.Exit(1, true);
			}
		}

		/// <summary>
		/// Loads all scripts from the scripts lists in the given scripts
		/// sub-folder.
		/// </summary>
		/// <param name="scriptFolderName"></param>
		public void LoadScripts(string scriptFolderName)
		{
			if (this.ScriptLoader != null)
			{
				Log.Error("The script loader has been created already.");
				return;
			}

			Log.Info("Loading scripts...");

			// Originally we passed the full path into this method, but
			// after moving the servers' scripts to their own sub-folders,
			// it was easier to build the path inside here. Perhaps there's
			// a better solution, to keep it more flexible?
			var listFilePath = Path.Combine("system", "scripts", scriptFolderName, "scripts.txt");

			if (!File.Exists(listFilePath))
			{
				Log.Error("Script list not found: " + listFilePath);
				return;
			}

			var timer = Stopwatch.StartNew();

			try
			{
				var cachePath = (string)null;
				if (this.Conf.Scripts.CacheScripts)
					cachePath = Path.Combine("user", "cache", "scripts", scriptFolderName + ".dll");

				var userPath = Path.Combine("user", "scripts", scriptFolderName);
				var systemPath = Path.Combine("system", "scripts", scriptFolderName);

				this.ScriptLoader = new ScriptLoader(cachePath);

				// Required for HTTP stuff that might be used in scripts.
				// To make this more flexible, we could potentially add
				// a way for scripts to specify their own references.
				this.ScriptLoader.References.Add(typeof(JsonSerializer).Assembly.Location);
				this.ScriptLoader.References.Add(typeof(HttpClient).Assembly.Location);
				this.ScriptLoader.References.Add(typeof(Uri).Assembly.Location);

				this.ScriptLoader.LoadFromListFile(listFilePath, userPath, systemPath);

				foreach (var ex in this.ScriptLoader.ReferenceExceptions)
					Log.Warning(ex);

				foreach (var ex in this.ScriptLoader.LoadingExceptions)
				{
					if (ex.InnerException is MissingMethodException)
						Log.Error("It appears like a script tried to use a method that does (no longer) exist, which may be a caching issue. Try deleting the user/cache/ folder and run the server again.");

					Log.Error(ex);
				}
			}
			catch (CompilerErrorException ex)
			{
				this.DisplayScriptErrors(ex);
			}
			catch (Exception ex)
			{
				Log.Error(ex);
			}

			Log.Info("  loaded {0} scripts from {3} files in {2:n2}s ({1} init fails).", this.ScriptLoader.LoadedCount, this.ScriptLoader.FailCount, timer.Elapsed.TotalSeconds, this.ScriptLoader.FileCount);
		}

		/// <summary>
		/// Reloads previously loaded scripts.
		/// </summary>
		public void ReloadScripts()
		{
			Log.Info("Reloading scripts...");

			var timer = Stopwatch.StartNew();

			try
			{
				this.ScriptLoader.Reload();
			}
			catch (CompilerErrorException ex)
			{
				this.DisplayScriptErrors(ex);
			}
			catch (Exception ex)
			{
				Log.Error(ex.ToString());
			}

			Log.Info("  reloaded {0} scripts from {3} files in {2:n2}s ({1} init fails).", this.ScriptLoader.LoadedCount, this.ScriptLoader.FailCount, timer.Elapsed.TotalSeconds, this.ScriptLoader.FileCount);
		}

		/// <summary>
		/// Displays the script errors in the console.
		/// </summary>
		/// <param name="ex"></param>
		private void DisplayScriptErrors(CompilerErrorException ex)
		{
			foreach (var err in ex.Errors)
			{
				if (string.IsNullOrWhiteSpace(err.FileName))
				{
					Log.Error("While loading scripts: " + err.ErrorText);
				}
				else
				{
					var relativefileName = err.FileName;
					var cwd = Directory.GetCurrentDirectory();
					if (relativefileName.StartsWith(cwd, StringComparison.InvariantCultureIgnoreCase))
						relativefileName = relativefileName.Substring(cwd.Length + 1);

					var lines = File.ReadAllLines(err.FileName);
					var sb = new StringBuilder();

					// Error msg
					sb.AppendLine("In {0} on line {1}, column {2}", relativefileName, err.Line, err.Column);
					sb.AppendLine("          {0}", err.ErrorText);

					// Display lines around the error
					var startLine = Math.Max(1, err.Line - 1);
					var endLine = Math.Min(lines.Length, startLine + 2);
					for (var i = startLine; i <= endLine; ++i)
					{
						// Make sure we don't get out of range.
						// (ReadAllLines "trims" the input)
						var line = (i <= lines.Length) ? lines[i - 1] : "";

						sb.AppendLine("  {2} {0:0000}: {1}", i, line, (err.Line == i ? '*' : ' '));
					}

					if (err.IsWarning)
						Log.Warning(sb.ToString());
					else
						Log.Error(sb.ToString());
				}
			}
		}

		/// <summary>
		/// Loads the server list from the database.
		/// </summary>
		/// <param name="serverDb"></param>
		/// <param name="serverType"></param>
		/// <param name="groupId"></param>
		/// <param name="serverId"></param>
		protected void LoadServerList(ServerDb serverDb, ServerType serverType, int groupId, int serverId)
		{
			Log.Info("Loading server list...");

			this.ServerList.Load(serverDb, groupId);
			this.ServerInfo = this.GetServerInfo(serverType, serverId);
		}

		/// <summary>
		/// Reads the server id from the arguments and returns it.
		/// </summary>
		/// <param name="args"></param>
		/// <param name="groupId"></param>
		/// <param name="serverId"></param>
		/// <returns></returns>
		protected void GetServerId(string[] args, out int groupId, out int serverId)
		{
			groupId = 1001;
			serverId = 1;

			if (args.Length > 0 && int.TryParse(args[0], out var gid))
				groupId = gid;

			if (args.Length > 1 && int.TryParse(args[1], out var sid))
				serverId = sid;
		}

		/// <summary>
		/// Returns the server info for given type and id.
		/// </summary>
		/// <param name="type"></param>
		/// <param name="serverId"></param>
		/// <returns></returns>
		protected ServerInfo GetServerInfo(ServerType type, int serverId)
		{
			if (!this.ServerList.TryGet(type, serverId, out var serverData))
			{
				Log.Error("No server data for '{0}:{1}' found in 'db/servers.txt'.", type, serverId);
				ConsoleUtil.Exit(1);
			}

			return serverData;
		}

		/// <summary>
		/// Checks whether the given connection is valid and should be accepted.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="database"></param>
		/// <returns></returns>
		protected ConnectionCheck CheckConnection(TcpConnection conn, MeliaDb database)
		{
			if (database.CheckIpBan(conn.Address))
				return new ConnectionCheck(ConnectionCheckResult.Reject, "IP banned");

			return new ConnectionCheck(ConnectionCheckResult.Accept, "Accepted");
		}
	}
}
