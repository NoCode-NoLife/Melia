using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Network;
using Melia.Shared.Tos.Const;
using Melia.Social.Database;
using Yggdrasil.Logging;
using Yggdrasil.Security.Hashing;
using static System.Net.Mime.MediaTypeNames;

namespace Melia.Social.Network
{
	public class PacketHandler : PacketHandler<ISocialConnection>
	{
		/// <summary>
		/// Sent when entering the game.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CS_LOGIN)]
		public void CS_LOGIN(ISocialConnection conn, Packet packet)
		{
			var accountName = packet.GetString(56);
			var password = packet.GetBinAsHex(16);
			var b1 = packet.GetByte();
			var accountId = packet.GetLong();
			var sessionKey = packet.GetString(256);

			// Check account
			if (!SocialServer.Instance.Database.AccountExists(accountName))
			{
				conn.Close(100);
				return;
			}

			// Check password
			var account = Account.LoadFromDb(accountName);
			if (!BCrypt.CheckPassword(password, account.Password))
			{
				conn.Close(100);
				return;
			}

			// Logged in
			conn.Account = account;
			conn.LoggedIn = true;

			Log.Info("User '{0}' logged in.", conn.Account.Name);

			Send.SC_NORMAL_Unknown_00(conn);
			Send.SC_LOGIN_OK(conn);
			Send.SC_NORMAL_Unknown_02(conn);
		}

		/// <summary>
		/// Chat
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CS_CHAT)]
		public void CS_CHAT(ISocialConnection conn, Packet packet)
		{
			var size = packet.GetShort();
			var chat = packet.GetString();
			var account = conn.Account;

			Log.Debug("CS_CHAT: {0}", chat);
			// TODO: Save chat and send it after saving it?
			// TODO: Decide to use ChatCommands?
			var splitChat = chat.Split(' ');
			if (splitChat.Length < 3)
				return;
			var command = splitChat[0];
			var targetTeamName = splitChat[1];
			var text = string.Join(" ", splitChat.Skip(2));
			if (!SocialServer.Instance.Database.TeamNameExists(targetTeamName))
			{
				Send.SC_NORMAL_SystemMessage(conn, 101080, 1, 0);
				return;
			}
			var target = SocialServer.Instance.Database.GetAccountByTeamName(targetTeamName);
			var chatGroup = conn.Account.ChatGroups.Values.FirstOrDefault(a => a.ReceiverId == target.Id);
			if (chatGroup == null)
			{
				chatGroup = new ChatGroup()
				{
					ChatId = SocialServer.Instance.GetNewChatId(),
					SenderId = account.Id,
					SenderName = account.TeamName,
					ReceiverId = target.Id,
					ReceiverName = target.TeamName,
				};
				conn.Account.ChatGroups.Add(chatGroup.ChatId, chatGroup);
			}
			chatGroup.Messages.Add(text);
			Send.SC_NORMAL_Chat(conn, account, chatGroup.ChatId, 2, targetTeamName, text, 0);
		}

		/// <summary>
		/// Create a group chat
		/// Dummy Handler
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CS_CREATE_GROUP_CHAT)]
		public void CS_CREATE_GROUP_CHAT(ISocialConnection conn, Packet packet)
		{
			var account = conn.Account;

			var chatId = SocialServer.Instance.GetNewChatId();
			Send.SC_NORMAL_CreateChatRoom(conn, account, chatId, "!@#$NewRoomHasBeenCreated#@!");
			Send.SC_NORMAL_ChatLog(conn, account, chatId, account);
			Send.SC_NORMAL_Chat(conn, account, chatId, 1, "", "!@#$NewRoomHasBeenCreated#@!", 1);
		}

		/// <summary>
		/// Invite someone to a group chat
		/// Dummy Handler
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CS_GROUP_CHAT_INVITE)]
		public void CS_GROUP_CHAT_INVITE(ISocialConnection conn, Packet packet)
		{

		}

		/// <summary>
		/// Refresh Group Chat
		/// Dummy Handler
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CS_REFRESH_GROUP_CHAT)]
		public void CS_REFRESH_GROUP_CHAT(ISocialConnection conn, Packet packet)
		{
			var account = conn.Account;
			foreach (var group in account.ChatGroups.Values)
			{
				Send.SC_NORMAL_ChatLog(conn, account, group.ChatId, group.ReceiverId, group.ReceiverName);
			}
		}

		/// <summary>
		/// Social Game Start?
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CS_NORMAL_GAME_START)]
		public void CS_NORMAL_GAME_START(ISocialConnection conn, Packet packet)
		{
			Send.SC_FROM_INTEGRATE(conn, 1);
		}
	}
}
