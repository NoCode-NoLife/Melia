using System;
using Melia.Shared.L10N;
using Melia.Social.Database;
using Yggdrasil.Logging;
using Yggdrasil.Util.Commands;

namespace Melia.Social.Commands
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
		/// <param name="account"></param>
		/// <param name="message"></param>
		/// <returns></returns>
		public bool TryExecute(Account account, string message)
		{
			if (!message.StartsWith(OfficialPrefix))
				return false;

			var args = new Arguments(message);
			var arg0 = args.Get(0);
			var commandName = arg0.Trim(OfficialPrefix[0]);

			// Check command
			var command = this.GetCommand(commandName);
			if (command == null)
			{
				Log.Warning(Localization.Get("Unknown command: {0}, message: {1}."), commandName, message);
				return true;
			}

			// Check target
			var sender = account;
			var target = account;

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
					Log.Warning(Localization.Get("Failed to execute command."));
					break;

				case CommandResult.InvalidArgument:
					Log.Warning(Localization.Get("Invalid argument, usage: {0}{1} {2}"), OfficialPrefix, command.Name, command.Usage);
					break;

				case CommandResult.Break:
					Log.Warning("Unsupported return 'Break' in command '{0}'.", command.Name);
					break;
			}

			return true;
		}
	}
}
