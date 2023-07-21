using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Tos.Const;
using Yggdrasil.Configuration;
using Yggdrasil.Logging;

namespace Melia.Shared.Configuration.Files
{
	/// <summary>
	/// Represents commands.conf.
	/// </summary>
	public class CommandsConfFile : ConfFile
	{
		private readonly string[] _nonCommands = new[] { "prefix" };

		/// <summary>
		/// Prefix for using commands on yourself.
		/// </summary>
		public string SelfPrefix { get; protected set; }

		/// <summary>
		/// Prefix for using commands on someone else.
		/// </summary>
		public string TargetPrefix { get; protected set; }

		/// <summary>
		/// Returns the default authority levels for commands that
		/// have no levels defined.
		/// </summary>
		public CommandAuthLevels DefaultLevels { get; protected set; }

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

			this.SelfPrefix = this.GetString("prefix", "/").Substring(0, 1);
			this.TargetPrefix = this.SelfPrefix + this.SelfPrefix;

			// Get levels by iterating of the remaining options
			this.CommandLevels = new Dictionary<string, CommandAuthLevels>();

			foreach (var option in _options)
			{
				if (_nonCommands.Contains(option.Key))
					continue;

				var command = option.Key;
				var levels = ParseAuthLevels(command, option.Value);

				this.CommandLevels[command] = levels;
			}
		}

		/// <summary>
		/// Parses comma separated string as auth levels and returns it.
		/// </summary>
		/// <param name="command"></param>
		/// <param name="levelsStr"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException">
		/// Thrown if the levels are formatted properly or contain invalid
		/// integer values.
		/// </exception>
		private static CommandAuthLevels ParseAuthLevels(string command, string levelsStr)
		{
			var sAuth = levelsStr.Split(',');
			if (sAuth.Length < 2)
				throw new ArgumentException($"Invalid format for command auth levels. ({command}: {levelsStr})");

			if (!int.TryParse(sAuth[0], out var selfAuth) || !int.TryParse(sAuth[1], out var targetAuth))
				throw new ArgumentException($"Invalid values for command auth levels. ({command}: {levelsStr})");

			return new CommandAuthLevels(selfAuth, targetAuth);
		}

		/// <summary>
		/// Returns auth levels for the given command, or null if no levels
		/// were defined for this specific command.
		/// </summary>
		/// <param name="command"></param>
		/// <returns></returns>
		public CommandAuthLevels GetLevels(string command)
		{
			if (!this.CommandLevels.TryGetValue(command, out var result))
				return null;

			return result;
		}

		/// <summary>
		/// Returns auth levels for the given command. Returns default
		/// levels if no levels were defined for this specific command.
		/// </summary>
		/// <param name="command"></param>
		/// <returns></returns>
		public CommandAuthLevels GetLevelsOrDefault(string command)
		{
			if (!this.CommandLevels.TryGetValue(command, out var result))
			{
				if (!this.CommandLevels.TryGetValue("default", out result))
					throw new ArgumentException("No levels or defaults found for the given command.");
			}

			return result;
		}

		public Dictionary<string, string> GetOptions()
		{
			return _options;
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
