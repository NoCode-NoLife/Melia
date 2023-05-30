using System;
using Melia.Social.Database;
using Melia.Social.Network;
using Yggdrasil.Geometry.Shapes;
using Yggdrasil.Logging;
using Yggdrasil.Util.Commands;
using static System.Net.Mime.MediaTypeNames;

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
		}

		/// <summary>
		/// Official whisper command
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleWhisper(Account sender, Account target, string message, string command, Arguments args)
		{
			if (args.Count < 2)
			{
				Log.Debug("HandleWhisper: Invalid call by user '{0}': {1}", sender.Connection.Account.Name, command);
				return CommandResult.Okay;
			}

			var teamName = args.Get(0);
			if (!SocialServer.Instance.Database.TeamNameExists(teamName))
			{
				// Send client message 101080 = TargetUserNotExist
				Send.SC_NORMAL.SystemMessage(sender.Connection, 101080, 1, 0);
				return CommandResult.Okay;
			}

			var whisperTarget = SocialServer.Instance.Database.GetAccountByTeamName(teamName);
			if (whisperTarget == null)
			{
				Log.Warning("HandleWhisper: Unable to find account by team name {0}", teamName);
				return CommandResult.Okay;
			}

			// TODO: Find previous chat room
			var chatRoom = SocialServer.Instance.ChatManager.GetChatRoom(sender.Connection.Account.Id, whisperTarget.Id);
			if (chatRoom == null)
			{
				chatRoom = new ChatRoom()
				{
					Id = SocialServer.Instance.ChatManager.GetNewChatId,
					Owner = sender,
					Type = ChatRoomType.OneToOne
				};
				SocialServer.Instance.ChatManager.AddChatRoom(chatRoom);
				// sender.ChatRooms.Add(chatRoom.Id, chatRoom);
			}
			chatRoom.AddMember(sender);
			chatRoom.AddMember(whisperTarget);

			var whisperText = message.Substring(message.IndexOf(args.Get(0)) + args.Get(0).Length + 1);
			var chatMessage = new ChatMessage()
			{
				Sender = sender,
				Message = whisperText,
				Recipient = whisperTarget,
				TimeStamp = DateTime.Now
			};
			chatRoom.AddMessage(chatMessage);

			Send.SC_NORMAL.ChatLog(sender.Connection, chatRoom, chatMessage);
			Send.SC_NORMAL.Chat(sender.Connection, chatRoom, chatMessage);

			return CommandResult.Okay;
		}

		/// <summary>
		/// Official chatroom chat command
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleChatRoomChat(Account sender, Account target, string message, string command, Arguments args)
		{
			if (args.Count < 2)
			{
				Log.Debug("HandleChatRoomChat: Invalid call by user '{0}': {1}", sender.Connection.Account.Name, command);
				return CommandResult.Okay;
			}

			if (!long.TryParse(args.Get(0), out var chatId))
			{
				// Send client message 101080 = TargetUserNotExist
				Send.SC_NORMAL.SystemMessage(sender.Connection, 101080, 1, 0);
				return CommandResult.Okay;
			}

			if (!SocialServer.Instance.ChatManager.TryGetChatRoom(chatId, out var chatRoom))
			{
				Log.Warning("HandleChatRoomChat: Unable to find chat room by id {0}", chatId);
				return CommandResult.Okay;
			}

			var text = message.Substring(message.IndexOf(args.Get(0)) + args.Get(0).Length + 1);
			var chatMessage = new ChatMessage()
			{
				Sender = sender,
				Message = text,
				TimeStamp = DateTime.Now
			};
			chatRoom.AddMessage(chatMessage);

			Send.SC_NORMAL.ChatLog(sender.Connection, chatRoom, chatMessage);
			Send.SC_NORMAL.Chat(sender.Connection, chatRoom, chatMessage);

			return CommandResult.Okay;
		}
	}
}
