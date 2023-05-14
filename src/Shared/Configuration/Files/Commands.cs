using System.Collections.Generic;
using Yggdrasil.Configuration;
using Yggdrasil.Logging;

namespace Melia.Shared.Configuration.Files
{
	/// <summary>
	/// Represents commands.conf.
	/// </summary>
	public class CommandsConfFile : ConfFile
	{
		/// <summary>
		/// Prefix for using commands on yourself.
		/// </summary>
		public string SelfPrefix { get; protected set; }

		/// <summary>
		/// Prefix for using commands on someone else.
		/// </summary>
		public string TargetPrefix { get; protected set; }

		/// <summary>
		/// List of commands and their authority levels.
		/// </summary>
		public Dictionary<string, CommandAuthLevels> CommandLevels { get; protected set; }

		/// <summary>
		/// Loads conf file and its options from the given path.
		/// </summary>
		/// <param name="filePath"></param>
		public void Load(string filePath)
		{
			this.Include(filePath);

			// Prefix
			this.SelfPrefix = this.GetString("prefix", "/").Substring(0, 1);
			this.TargetPrefix = this.SelfPrefix + this.SelfPrefix;

			// Commands
			this.CommandLevels = new Dictionary<string, CommandAuthLevels>();

			foreach (var option in _options)
			{
				if (option.Key == "prefix")
					continue;

				var sAuth = option.Value.Split(',');
				if (sAuth.Length < 2)
				{
					Log.Error("CommandsConfFile.Load: Commands need 2 auth settings, '{0}' has less.", option.Key);
					continue;
				}

				if (!int.TryParse(sAuth[0], out var auth1) || !int.TryParse(sAuth[1], out var auth2))
				{
					Log.Error("CommandsConfFile.Load: Unable to parse auth for '{0}'.", option.Key);
					continue;
				}

				this.CommandLevels[option.Key.Trim()] = new CommandAuthLevels(auth1, auth2);
			}
		}

		/// <summary>
		/// Returns auth for command, or a new auth with auth levels being 99
		/// if the command wasn't found in the config.
		/// </summary>
		/// <param name="command"></param>
		/// <returns></returns>
		public CommandAuthLevels GetLevels(string command)
		{
			this.CommandLevels.TryGetValue(command, out var result);
			if (result == null)
				result = new CommandAuthLevels(99, 99);

			return result;
		}
	}

	/// <summary>
	/// Represents the authority levels for a command.
	/// </summary>
	public class CommandAuthLevels
	{
		/// <summary>
		/// Returns the authority level required to use the command on
		/// yourself.
		/// </summary>
		public int Self;

		/// <summary>
		/// Returns the authority level required to use the command on
		/// someone else.
		/// </summary>
		public int Target;

		/// <summary>
		/// Creates a new instance.
		/// </summary>
		/// <param name="self"></param>
		/// <param name="target"></param>
		public CommandAuthLevels(int self, int target)
		{
			this.Self = self;
			this.Target = target;
		}
	}
}
