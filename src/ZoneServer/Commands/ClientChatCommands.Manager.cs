using System;
using Melia.Zone.World.Actors.Characters;
using Yggdrasil.Logging;
using Yggdrasil.Util.Commands;

namespace Melia.Zone.Commands
{
	/// <summary>
	/// The dedicated chat command manager for chat commands sent by clients
	/// (usually from from behind the scenes).
	/// </summary>
	public partial class ClientChatCommands : CommandManager<ClientChatCommand, ClientChatCommandFunc>
	{
		private const string Prefix = "/";

		/// <summary>
		/// Adds command with the given parameters.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="usage"></param>
		/// <param name="description"></param>
		/// <param name="func"></param>
		public void Add(string name, string usage, string description, ClientChatCommandFunc func)
		{
			this.Add(new ClientChatCommand(name, usage, description, func));
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
			if (!message.StartsWith(Prefix))
				return false;

			var args = new Arguments(message);
			var arg0 = args.Get(0);
			var commandName = arg0.Trim(Prefix[0]);

			var command = this.GetCommand(commandName);
			if (command == null)
			{
				Log.Warning("Unknown client command '{0}'. Message: '{1}'.", commandName, message);
				return true;
			}

			args.Remove(0);

			CommandResult result;
			try
			{
				result = command.Func(character, message, commandName, args);
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
					Log.Warning("Failed to execute client command '{0}' for character '{1}'. Message: '{2}'.", command.Name, character.TeamName, message);
					break;

				case CommandResult.InvalidArgument:
					Log.Warning("Encountered an invalid argument in command '{0}' for character '{1}'. Message: '{2}'.", command.Name, character.TeamName, message);
					break;

				case CommandResult.Break:
					Log.Warning("Unsupported return 'Break' in command '{0}'.", command.Name);
					break;
			}

			return true;
		}
	}
}
