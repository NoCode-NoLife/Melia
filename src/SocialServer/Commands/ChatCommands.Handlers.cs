using System.Text.RegularExpressions;
using Melia.Shared.ObjectProperties;
using Melia.Social.Database;
using Melia.Social.Network;
using Melia.Social.World;
using Yggdrasil.Logging;
using Yggdrasil.Util.Commands;

namespace Melia.Social.Commands
{
	/// <summary>
	/// The chat command manager, holding the commands and executing them.
	/// </summary>
	public partial class ChatCommands : CommandManager<ChatCommand, ChatCommandFunc>
	{
		/// <summary>
		/// Creates new manager and initializes it.
		/// </summary>
		public ChatCommands()
		{
			// Official
			this.Add("w", "<teamName> <message>", "", this.HandleWhisper);
			this.Add("f", "<chatId> <message>", "", this.HandleChatRoomChat);
			this.Add("p", "<message>", "", this.HandlePartyChat);
		}

		/// <summary>
		/// Request to send a whisper message to another user.
		/// </summary>
		/// <param name="user"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleWhisper(SocialUser user, string message, string command, Arguments args)
		{
			if (args.Count < 2)
			{
				Log.Debug("HandleWhisper: Invalid call by user '{0}' ('{1}').", user.Name, message);
				return CommandResult.Okay;
			}

			var teamName = args.Get(0);

			if (!SocialServer.Instance.Database.TeamNameExists(teamName))
			{
				Send.SC_NORMAL.SystemMessage(user.Connection, SystemMessageId.TargetUserNotExist);
				return CommandResult.Okay;
			}

			var targetUser = SocialServer.Instance.UserManager.GetOrCreateUser(teamName);

			if (!SocialServer.Instance.ChatManager.TryGetChatRoom(user.Id, targetUser.Id, out var chatRoom))
			{
				chatRoom = new ChatRoom("", ChatRoomType.OneToOne);
				SocialServer.Instance.ChatManager.AddChatRoom(chatRoom);

				chatRoom.AddMember(user);
				chatRoom.AddMember(targetUser);
			}

			var text = Regex.Replace(message, @"^(?<command>.*?)\s+(?<target>[^\s]+)(\s+|$)", "");

			var chatMessage = new ChatMessage(user, text);
			chatRoom.AddMessage(chatMessage);

			return CommandResult.Okay;
		}

		/// <summary>
		/// Request to send a message in a chat room.
		/// </summary>
		/// <param name="user"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleChatRoomChat(SocialUser user, string message, string command, Arguments args)
		{
			if (args.Count < 2)
			{
				Log.Debug("HandleChatRoomChat: Invalid call by user '{0}' ('{1}').", user.Name, message);
				return CommandResult.Okay;
			}

			if (!long.TryParse(args.Get(0), out var chatId))
			{
				Send.SC_NORMAL.SystemMessage(user.Connection, SystemMessageId.TargetUserNotExist);
				return CommandResult.Okay;
			}

			if (!SocialServer.Instance.ChatManager.TryGetChatRoom(chatId, out var chatRoom))
			{
				Log.Warning("HandleChatRoomChat: Chat room requested by {0} via id '{1}' not found.", user.TeamName, chatId);
				return CommandResult.Okay;
			}

			var text = Regex.Replace(message, @"^(?<command>.*?)\s+(?<target>[^\s]+)(\s+|$)", "");

			var chatMessage = new ChatMessage(user, text);
			chatRoom.AddMessage(chatMessage);

			return CommandResult.Okay;
		}

		/// <summary>
		/// Request to send a message in a party chat.
		/// </summary>
		/// <param name="user"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandlePartyChat(SocialUser user, string message, string command, Arguments args)
		{
			if (args.Count < 1)
				return CommandResult.Okay;

			var text = message.Substring(message.IndexOf(" "));

			if (string.IsNullOrEmpty(text))
				return CommandResult.Okay;

			if (user.Character.PartyId == ObjectIdRanges.Party)
				return CommandResult.Okay;

			if (!SocialServer.Instance.ChatManager.TryGetChatRoom(user.Character.PartyId, out var chatRoom))
				chatRoom = SocialServer.Instance.ChatManager.CreateChatRoom(user, user.Character.PartyId, ChatRoomType.Friends);
			var chatMessage = new ChatMessage(user, text, ChatMessageType.Party);
			chatRoom.AddMessage(chatMessage);

			return CommandResult.Okay;
		}
	}
}
