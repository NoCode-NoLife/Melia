using Melia.Social.Database;
using Yggdrasil.Util.Commands;

namespace Melia.Social.Commands
{
	/// <summary>
	/// Represents a chat command.
	/// </summary>
	public class ChatCommand : Command<ChatCommandFunc>
	{
		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="usage"></param>
		/// <param name="description"></param>
		/// <param name="func"></param>
		public ChatCommand(string name, string usage, string description, ChatCommandFunc func)
			: base(name, usage, description, func)
		{
		}
	}

	/// <summary>
	/// The handler function for a chat command.
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="target"></param>
	/// <param name="message"></param>
	/// <param name="commandName"></param>
	/// <param name="args"></param>
	/// <returns></returns>
	public delegate CommandResult ChatCommandFunc(Account sender, Account target, string message, string commandName, Arguments args);
}
