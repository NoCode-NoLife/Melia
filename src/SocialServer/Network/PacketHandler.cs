using System.Linq;
using Melia.Shared.Network;
using Melia.Shared.Tos.Const;
using Melia.Social.Database;
using Yggdrasil.Logging;
using Yggdrasil.Security.Hashing;
using Yggdrasil.Util.Commands;

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
			SocialServer.Instance.AccountManager.Add(conn);

			Send.SC_NORMAL.Unknown_00(conn);
			Send.SC_LOGIN_OK(conn);
			Send.SC_NORMAL.Unknown_02(conn);

			// Get Friend List
			foreach (var friend in conn.Account.GetFriends())
			{
				Send.SC_NORMAL.FriendInfo(conn, friend);
			}
		}

		/// <summary>
		/// Request to add a friend
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CS_REQ_ADD_FRIEND)]
		public void CS_REQ_ADD_FRIEND(ISocialConnection conn, Packet packet)
		{
			var teamName = packet.GetString();

			if (!SocialServer.Instance.Database.TeamNameExists(teamName))
			{
				// Send client message 101080 = TargetUserNotExist
				Send.SC_NORMAL.SystemMessage(conn, 101080, 1, 0);
				return;
			}
			var friendRequestConn = SocialServer.Instance.AccountManager.GetSocialConnection(teamName);
			var targetAccount = friendRequestConn?.Account ?? SocialServer.Instance.Database.GetAccountByTeamName(teamName);

			var friend = conn.Account.GetFriend(targetAccount.Id);
			if (friend == null)
			{
				friend = new Friend()
				{
					AccountId = targetAccount.Id,
					State = FriendState.Requested,
					TeamName = targetAccount.TeamName,
				};
				conn.Account.CreateFriend(friend);
			}

			// Send client message 122030 = AckReqAddFriend
			Send.SC_NORMAL.SystemMessage(conn, 122030, 1, 0);
			Send.SC_NORMAL.FriendRequested(conn, friend.AccountId);
			Send.SC_NORMAL.FriendInfo(conn, friend);
		}

		/// <summary>
		/// Request to block another account.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CS_REQ_BLOCK_FRIEND)]
		public void CS_REQ_BLOCK_FRIEND(ISocialConnection conn, Packet packet)
		{
			var teamName = packet.GetString();

			if (!SocialServer.Instance.Database.TeamNameExists(teamName))
			{
				// Send client message 101080 = TargetUserNotExist
				Send.SC_NORMAL.SystemMessage(conn, 101080, 1, 0);
				return;
			}

			var targetAccount = SocialServer.Instance.Database.GetAccountByTeamName(teamName);
			if (targetAccount == null)
			{
				Log.Warning("CS_REQ_BLOCK_FRIEND: Failed to find account by team name {0} for user {1}.", teamName, conn.Account.Name);
				return;
			}

			var friend = conn.Account.GetFriend(targetAccount.Id);
			if (friend == null)
			{
				friend = new Friend()
				{
					AccountId = targetAccount.Id,
					State = FriendState.Blocked,
					TeamName = targetAccount.TeamName,
				};
				conn.Account.CreateFriend(friend);
			}
			else
				friend.State = FriendState.Blocked;

			Send.SC_NORMAL.FriendBlocked(conn, targetAccount.Id);
			Send.SC_NORMAL.FriendInfo(conn, friend);
		}

		/// <summary>
		/// Friend commands (Block/Unblock) friends.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CS_FRIEND_CMD)]
		public void CS_FRIEND_CMD(ISocialConnection conn, Packet packet)
		{
			var i1 = packet.GetInt();
			var s1 = packet.GetShort();
			var accountId = packet.GetLong();
			var state = (FriendState)packet.GetByte();

			var friend = conn.Account.GetFriend(accountId);
			if (friend == null)
			{
				Log.Warning("CS_FRIEND_CMD: Failed to find account by id {0} for user {1}.", accountId, conn.Account.Name);
				return;
			}

			if (state == FriendState.Delete && !conn.Account.DeleteFriend(friend))
			{
				Log.Warning("CS_FRIEND_CMD: Deleting friend '{0}' from account '{1}' failed.", friend.Name, conn.Account.Name);
				Send.SC_NORMAL.FriendResponse(conn, friend);
				return;
			}
			// Is this the friend's state, that needs to be updated?
			friend.State = state;

			Send.SC_NORMAL.FriendResponse(conn, friend);
			Send.SC_NORMAL.FriendInfo(conn, friend);
		}

		/// <summary>
		/// Set friend "grouping" name
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CS_FRIEND_SET_ADDINFO)]
		public void CS_FRIEND_SET_ADDINFO(ISocialConnection conn, Packet packet)
		{
			var i1 = packet.GetInt();
			var s1 = packet.GetShort();
			var accountId = packet.GetLong();
			var groupName = packet.GetString(20); // Client side max, doesn't let you type any more characters

			var friend = conn.Account.GetFriend(accountId);
			if (friend == null)
			{
				Log.Warning("CS_FRIEND_SET_ADDINFO: Failed to find account by id {0} for user {1}.", accountId, conn.Account.Name);
				return;
			}

			friend.Group = groupName;

			Send.SC_NORMAL.FriendInfo(conn, friend);
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
			if (chatRoom.MemberCount() == 0)
			{
				chatRoom.Owner = null;
				SocialServer.Instance.ChatManager.RemoveChatRoom(chatId);
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
