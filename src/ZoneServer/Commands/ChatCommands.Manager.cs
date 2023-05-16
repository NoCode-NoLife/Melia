using System;
using Melia.Shared.L10N;
using Melia.Zone.World.Entities;
using Yggdrasil.Logging;
using Yggdrasil.Util.Commands;

namespace Melia.Zone.Commands
{
	/// <summary>
	/// The chat command manager, holding the commands and executing them.
	/// </summary>
	public partial class ChatCommands : CommandManager<ChatCommand, ChatCommandFunc>
	{
		private const string OfficialPrefix = "/";

		/// <summary>
		/// Adds command with the given parameters.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="usage"></param>
		/// <param name="description"></param>
		/// <param name="func"></param>
		public void Add(string name, string usage, string description, ChatCommandFunc func)
		{
			this.Add(new ChatCommand(name, usage, description, func));
		}

		/// <summary>
		/// Adds alias for command by which it can be used as well.
		/// </summary>
		/// <param name="commandName"></param>
		/// <param name="alias"></param>
		public void AddAlias(string commandName, string alias)
		{
			var command = this.GetCommand(commandName) ?? throw new ArgumentException($"Command '{commandName}' doesn't exist.");
			_commands[alias] = command;
		}

		/// <summary>
		/// Removes all commands.
		/// </summary>
		public void Clear()
		{
			_commands.Clear();
		}

		/// <summary>
		/// Parses message, interprets potential commands, and returns true
		/// if message was a command.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="message"></param>
		/// <returns></returns>
		public bool TryExecute(Character character, string message)
		{
			var prefix = ZoneServer.Instance.Conf.Commands.SelfPrefix;

			if (!message.StartsWith(prefix) && !message.StartsWith(OfficialPrefix))
				return false;

			var args = new Arguments(message);
			var arg0 = args.Get(0);
			var isDoublePrefix = arg0.StartsWith(prefix + prefix);
			var commandName = arg0.Trim(prefix[0], OfficialPrefix[0]);

			// Check command
			var command = this.GetCommand(commandName);
			if (command == null)
			{
				character.ServerMessage(Localization.Get("Unknown command."));
				return true;
			}

			// Check levels
			var levels = ZoneServer.Instance.Conf.Commands.GetLevels(command.Name);
			if (levels == null)
			{
				levels = ZoneServer.Instance.Conf.Commands.GetLevels("default");
				if (levels == null)
				{
					character.ServerMessage(Localization.Get("No authority levels were set for this command and no default levels could be found."));
					return true;
				}

				Log.Debug("Commands: No authority levels set for command '{0}'.", commandName);
			}

			var authority = character.Connection.Account.Authority;

			if ((!isDoublePrefix && authority < levels.Self) || (isDoublePrefix && authority < levels.Target))
			{
				character.ServerMessage(Localization.Get("You're not authorized to use this command."));
				return true;
			}

			// Check target
			var sender = character;
			var target = character;

			if (isDoublePrefix)
			{
				if (args.Count < 2)
				{
					character.ServerMessage(Localization.Get("No target specified."));
					return true;
				}

				var targetName = args.Get(1);
				if (!ZoneServer.Instance.World.TryGetCharacterByTeamName(targetName, out target))
				{
					character.ServerMessage(Localization.Get("Target character not found."));
					return true;
				}

				// Remove target name argument, so the argument handling
				// can be generalized.
				args.Remove(1);
			}

			// Remove command name from arguments, to leave only the actual
			// arguments
			args.Remove(0);

			// Execute command
			CommandResult result;
			try
			{
				result = command.Func(sender, target, message, commandName, args);
			}
			catch (Exception ex)
			{
				result = CommandResult.Fail;
				Log.Error("Commands: " + ex);
			}

			switch (result)
			{
				case CommandResult.Okay:
					break;

				case CommandResult.Fail:
					character.ServerMessage(Localization.Get("Failed to execute command."));
					break;

				case CommandResult.InvalidArgument:
					character.ServerMessage(Localization.Get("Invalid argument, usage: {0}{1} {2}"), prefix, command.Name, command.Usage);
					break;

				case CommandResult.Break:
					Log.Warning("Unsupported return 'Break' in command '{0}'.", command.Name);
					break;
			}

			return true;
		}
	}
}
