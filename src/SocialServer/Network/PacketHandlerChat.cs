using Melia.Shared.Network;
using Melia.Social.Database;
using Yggdrasil.Logging;
using Yggdrasil.Security.Hashing;

namespace Melia.Social.Network
{
	public class PacketHandlerChat : PacketHandler
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
			SocialServer.Instance.AccountManager.Add(conn);

			Send.SC_NORMAL.EnableChat(conn);
			Send.SC_LOGIN_OK(conn);
			Send.SC_NORMAL.Unknown_02(conn);

			// Get Friend List
			foreach (var friend in conn.Account.GetFriends())
			{
				Send.SC_NORMAL.FriendInfo(conn, friend);
			}
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
			var msg = packet.GetString();

			if (!SocialServer.Instance.ChatCommands.TryExecute(conn.Account, msg))
				Log.Warning("CS_CHAT: Failed to execute chat command {0} for {1}", msg, conn.Account.Name);
		}

		/// <summary>
		/// Invite someone to a group chat
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CS_GROUP_CHAT_INVITE)]
		public void CS_GROUP_CHAT_INVITE(ISocialConnection conn, Packet packet)
		{
			var teamName = packet.GetString(64);
		}

		/// <summary>
		/// Refresh Group Chat
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CS_REFRESH_GROUP_CHAT)]
		public void CS_REFRESH_GROUP_CHAT(ISocialConnection conn, Packet packet)
		{
			var account = conn.Account;
			foreach (var room in account.GetChatRooms())
			{
				foreach (var message in room.GetMessages())
					Send.SC_NORMAL.ChatLog(conn, room, message);
			}
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
			SocialServer.Instance.ChatManager.CreateChatRoom(conn.Account);
		}

		/// <summary>
		/// Request chat room's message history.
		/// Dummy Handler
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CS_REQ_CHAT_HISTORY)]
		public void CS_REQ_CHAT_HISTORY(ISocialConnection conn, Packet packet)
		{
			var chatId = packet.GetLong();

			if (!SocialServer.Instance.ChatManager.TryGetChatRoom(chatId, out var chatRoom))
			{
				Log.Warning("CS_CREATE_GROUP_CHAT: Failed to find chat room by id {0}", chatId);
				return;
			}

			foreach (var message in chatRoom.GetMessages())
			{
				Send.SC_NORMAL.ChatRoomMessage(conn, chatRoom, message);
			}
		}

		/// <summary>
		/// Leaves a chat room.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CS_REQ_OUT_ROOM)]
		public void CS_REQ_OUT_ROOM(ISocialConnection conn, Packet packet)
		{
			var chatId = packet.GetLong();

			if (!SocialServer.Instance.ChatManager.TryGetChatRoom(chatId, out var chatRoom))
			{
				Log.Warning("CS_REQ_OUT_ROOM: Failed to find chat room by id {0}", chatId);
				return;
			}

			conn.Account.RemoveChatRoom(chatId);

			chatRoom.RemoveMember(conn.Account);
			if (chatRoom.MemberCount == 0)
			{
				chatRoom.Owner = null;
				SocialServer.Instance.ChatManager.RemoveChatRoom(chatId);
			}
		}

		/// <summary>
		/// Unnknown purpose
		/// </summary>
		/// <remarks>
		/// Sent when you open Skill Tree (F3).
		/// </remarks>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CS_REDIS_SKILLPOINT)]
		public void CS_REDIS_SKILLPOINT(ISocialConnection conn, Packet packet)
		{
			var jobName = packet.GetString(16);
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

		///// <summary>
		///// ?
		///// </summary>
		///// <param name="conn"></param>
		///// <param name="packet"></param>
		//[PacketHandler(Op.CS_ADD_RELATION_SCORE)]
		//public void CS_ADD_RELATION_SCORE(ISocialConnection conn, Packet packet)
		//{
		//	var extra = packet.GetBin(14);
		//	var teamName = packet.GetString(64);
		//	var l1 = packet.GetLong();

		//	Send.SC_NORMAL.Unknown_01(conn);
		//}
	}
}
