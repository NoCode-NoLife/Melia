using Melia.Zone.World.Actors.Characters;
using Yggdrasil.Util.Commands;

namespace Melia.Zone.Commands
{
	/// <summary>
	/// Represents a client chat command.
	/// </summary>
	public class ClientChatCommand : Command<ClientChatCommandFunc>
	{
		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="usage"></param>
		/// <param name="description"></param>
		/// <param name="func"></param>
		public ClientChatCommand(string name, string usage, string description, ClientChatCommandFunc func)
			: base(name, usage, description, func)
		{
		}
	}

	/// <summary>
	/// The handler function for a chat command.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="message"></param>
	/// <param name="commandName"></param>
	/// <param name="args"></param>
	/// <returns></returns>
	public delegate CommandResult ClientChatCommandFunc(Character character, string message, string commandName, Arguments args);
}
