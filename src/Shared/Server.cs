// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Shared.Data;
using Melia.Shared.Database;
using Melia.Shared.Util;
using Melia.Shared.Util.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Shared
{
	/// <summary>
	/// Base class for server applications.
	/// </summary>
	public abstract class Server
	{
		private bool _running;

		/// <summary>
		/// Configuration.
		/// </summary>
		public Conf Conf { get; private set; }

		/// <summary>
		/// File databases.
		/// </summary>
		public MeliaData Data { get; private set; }

		/// <summary>
		/// Initializes class.
		/// </summary>
		public Server()
		{
			this.Data = new MeliaData();
		}

		/// <summary>
		/// Starts the server.
		/// </summary>
		public virtual void Run()
		{
			if (_running)
				throw new Exception("Server is already running.");
			_running = true;

			this.NavigateToRoot();
		}

		/// <summary>
		/// Initializes database connection with data from Conf.
		/// </summary>
		protected void InitDatabase(MeliaDb db)
		{
			try
			{
				Log.Info("Initializing database...");
				db.Init(this.Conf.Database.Host, this.Conf.Database.User, this.Conf.Database.Pass, this.Conf.Database.Db);
			}
			catch (Exception ex)
			{
				Log.Error("Failed to initialize database: {0}", ex.Message);
				Cmd.Exit(1, true);
			}
		}

		/// <summary>
		/// Loads data from files.
		/// </summary>
		protected void LoadData(DataToLoad toLoad, bool reload)
		{
			Log.Info("Loading data...");

			try
			{
				if ((toLoad & DataToLoad.Items) != 0)
				{
					this.LoadDb(this.Data.ItemDb, "db/items.txt", reload);
				}
			}
			catch (DatabaseErrorException ex)
			{
				Log.Error(ex.ToString());
				Cmd.Exit(1);
			}
			catch (FileNotFoundException ex)
			{
				Log.Error(ex.Message);
				Cmd.Exit(1);
			}
			catch (Exception ex)
			{
				Log.Exception(ex, "Error while loading data.");
				Cmd.Exit(1);
			}
		}

		/// <summary>
		/// Loads db, first from system, then from user.
		/// Logs problems as warnings.
		/// </summary>
		private void LoadDb(IDatabase db, string path, bool reload, bool log = true)
		{
			var systemPath = Path.Combine("system", path).Replace('\\', '/');
			var userPath = Path.Combine("user", path).Replace('\\', '/');

			string cachePath = null;
			//var cachePath = Path.Combine("cache", path).Replace('\\', '/');
			//cachePath = Path.ChangeExtension(cachePath, "mpk");
			//var cacheDir = Path.GetDirectoryName(cachePath);
			//if (!Directory.Exists(cacheDir))
			//	Directory.CreateDirectory(cacheDir);

			if (!File.Exists(systemPath))
				throw new FileNotFoundException("Data file '" + systemPath + "' couldn't be found.", systemPath);

			db.Load(new string[] { systemPath, userPath }, cachePath, reload);

			foreach (var ex in db.Warnings)
				Log.Warning("{0}", ex.ToString());

			if (log)
				Log.Info("  done loading {0} entries from {1}", db.Count, Path.GetFileName(path));
		}

		/// <summary>
		/// Loads configuration.
		/// </summary>
		protected void LoadConf()
		{
			try
			{
				Log.Info("Loading configuration...");
				this.Conf = new Conf();
				this.Conf.LoadAll();
			}
			catch (Exception ex)
			{
				Log.Error("Failed to load configuration: {0}", ex.Message);
				Cmd.Exit(1, true);
			}
		}

		/// <summary>
		/// Tries to find aura root folder and changes the working directory to it.
		/// Exits if not successful.
		/// </summary>
		public void NavigateToRoot()
		{
			// Go back max 2 folders, the bins should be in [root]/bin/(Debug|Release)
			for (int i = 0; i < 3; ++i)
			{
				if (Directory.Exists("system") && Directory.Exists("user"))
				{
					//if (i != 0)
					//	Log.Info("Switched workign directory to '{0}'.", Directory.GetCurrentDirectory());
					return;
				}

				Directory.SetCurrentDirectory("..");
			}

			Log.Error("Unable to find root directory, that contains system and user folders.");
			Cmd.Exit(1);
		}
	}

	[Flags]
	public enum DataToLoad
	{
		Items = 0x01,

		All = 0x7FFFFFFF,
	}
}
