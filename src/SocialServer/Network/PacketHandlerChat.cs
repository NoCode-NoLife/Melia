using Melia.Shared.Network;
using Melia.Social.Database;
using Melia.Social.World;
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

			if (!SocialServer.Instance.Database.TryGetAccount(accountName, out var account))
			{
				conn.Close();
				return;
			}

			if (!BCrypt.CheckPassword(password, account.Password))
			{
				conn.Close();
				return;
			}

			var user = new SocialUser(conn, account);
			user.Friends.LoadFromDb();

			conn.User = user;
			conn.LoggedIn = true;

			SocialServer.Instance.UserManager.Add(user);

			Log.Info("User '{0}' logged in.", user.Account.Name);

			Send.SC_NORMAL.EnableChat(conn);
			Send.SC_LOGIN_OK(conn);
			Send.SC_NORMAL.Unknown_02(conn);

			foreach (var friend in user.Friends.GetFriends())
				Send.SC_NORMAL.FriendInfo(conn, friend);
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

		/// <summary>
		/// Request to add a friend.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CS_REQ_ADD_FRIEND)]
		public void CS_REQ_ADD_FRIEND(ISocialConnection conn, Packet packet)
		{
			var teamName = packet.GetString();

			var userManager = SocialServer.Instance.UserManager;
			var user = conn.User;
			var account = user.Account;

			if (!userManager.TryGetAccount(teamName, out var otherAccount))
			{
				Send.SC_NORMAL.SystemMessage(conn, "TargetUserNotExist", 1, 0);
				return;
			}

			if (!user.Friends.TryGetFriend(otherAccount.Id, out var friend))
			{
				friend = new Friend(otherAccount, FriendState.SentRequest);
				var otherFriend = new Friend(account, FriendState.ReceivedRequest);

				SocialServer.Instance.Database.CreateFriend(account.Id, friend);
				SocialServer.Instance.Database.CreateFriend(otherAccount.Id, otherFriend);

				user.Friends.AddFriend(friend);

				if (userManager.TryGet(otherAccount.Id, out var otherUser))
					otherUser.Friends.AddFriend(otherFriend);
			}

			Send.SC_NORMAL.SystemMessage(conn, "AckReqAddFriend", 1, 0);
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

			var userManager = SocialServer.Instance.UserManager;
			var user = conn.User;

			if (!userManager.TryGetAccount(teamName, out var otherAccount))
			{
				Send.SC_NORMAL.SystemMessage(conn, "TargetUserNotExist", 1, 0);
				return;
			}

			if (!conn.User.Friends.TryGetFriend(otherAccount.Id, out var friend))
			{
				friend = new Friend(otherAccount, FriendState.Blocked);

				user.Friends.AddFriend(friend);
				SocialServer.Instance.Database.CreateFriend(user.Account.Id, friend);
			}
			else
			{
				friend.State = FriendState.Blocked;
			}

			Send.SC_NORMAL.FriendBlocked(conn, otherAccount.Id);
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
			var cmd = (FriendCmd)packet.GetInt();
			var i2 = packet.GetInt();

			if (!conn.User.Friends.TryGetFriend(accountId, out var friend))
			{
				Log.Warning("CS_FRIEND_CMD: User '{0}' tried to modify a friend without having them in their friends list.", conn.User.Name);
				return;
			}

			switch (cmd)
			{
				case FriendCmd.Accept:
				{
					friend.State = FriendState.Accepted;
					break;
				}
				case FriendCmd.Decline:
				{
					friend.State = FriendState.Declined;
					break;
				}
				case FriendCmd.Delete:
				{
					if (!conn.User.Friends.DeleteFriend(friend))
						Log.Warning("CS_FRIEND_CMD: Deleting friend '{0}' from account '{1}' failed.", friend.TeamName, conn.User.Name);

					Send.SC_NORMAL.FriendResponse(conn, friend);
					return;
				}
			}

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

			if (!conn.User.Friends.TryGetFriend(accountId, out var friend))
			{
				Log.Warning("CS_FRIEND_SET_ADDINFO: Failed to find account by id {0} for user {1}.", accountId, conn.User.Name);
				return;
			}

			friend.Group = groupName;

			Send.SC_NORMAL.FriendInfo(conn, friend);
		}

		/// <summary>
		/// Chat message, used to send commands.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CS_CHAT)]
		public void CS_CHAT(ISocialConnection conn, Packet packet)
		{
			var size = packet.GetShort();
			var msg = packet.GetString();

			if (!SocialServer.Instance.ChatCommands.TryExecute(conn.User, msg))
				Log.Warning("CS_CHAT: Failed to execute chat command {0} for {1}", msg, conn.User.Name);
		}

		/// <summary>
		/// Invite for someone to join a group chat.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CS_GROUP_CHAT_INVITE)]
		public void CS_GROUP_CHAT_INVITE(ISocialConnection conn, Packet packet)
		{
			var teamName = packet.GetString(64);

			// ...
		}

		/// <summary>
		/// Request to refresh all chat rooms and their messages.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CS_REFRESH_GROUP_CHAT)]
		public void CS_REFRESH_GROUP_CHAT(ISocialConnection conn, Packet packet)
		{
			var user = conn.User;

			foreach (var room in user.Account.GetChatRooms())
			{
				foreach (var message in room.GetMessages())
					Send.SC_NORMAL.ChatLog(conn, room, message);
			}
		}

		/// <summary>
		/// Request to create a chat room.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CS_CREATE_GROUP_CHAT)]
		public void CS_CREATE_GROUP_CHAT(ISocialConnection conn, Packet packet)
		{
			SocialServer.Instance.ChatManager.CreateChatRoom(conn.User.Account);
		}

		/// <summary>
		/// Request to receive a chat room's message history.
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
				Send.SC_NORMAL.ChatRoomMessage(conn, chatRoom, message);
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

			conn.User.Account.RemoveChatRoom(chatId);
			chatRoom.RemoveMember(conn.User.Account);

			if (chatRoom.MemberCount == 0)
			{
				chatRoom.Owner = null;
				SocialServer.Instance.ChatManager.RemoveChatRoom(chatId);
			}
		}

		/// <summary>
		/// Sent upon opening the Skill window/panel, purpose currently
		/// unknown.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CS_REDIS_SKILLPOINT)]
		public void CS_REDIS_SKILLPOINT(ISocialConnection conn, Packet packet)
		{
			var jobName = packet.GetString(16);

			// What to do with this? Perhaps it's a job update of some sort?
		}
	}
}
