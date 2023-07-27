using System.Linq;
using Melia.Shared.Network;
using Melia.Social.Database;
using Melia.Social.World;
using Mysqlx.Crud;
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

			var user = SocialServer.Instance.UserManager.GetOrCreateUser(account);
			user.Connection = conn;

			conn.User = user;
			conn.LoggedIn = true;

			SocialServer.Instance.Database.UpdateLastSocialLogin(user.Id);

			Log.Info("User '{0}' logged in.", user.Name);

			Send.SC_NORMAL.EnableChat(conn);
			Send.SC_LOGIN_OK(conn);
			Send.SC_NORMAL.Unknown_02(conn);

			foreach (var friend in user.Friends.GetAll())
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

			var user = conn.User;

			if (!SocialServer.Instance.UserManager.TryGet(teamName, out var otherUser))
			{
				Send.SC_NORMAL.SystemMessage(conn, "TargetUserNotExist", 1, 0);
				return;
			}

			if (user.Friends.TryGet(otherUser.Id, out var friend))
			{
				if (friend.State == FriendState.SentRequest)
					Send.SC_NORMAL.SystemMessage(conn, "AlreadyRequestFriend", 1, 0);
				else
					Send.SC_NORMAL.SystemMessage(conn, "AlreadyInFriendList", 1, 0);
				return;
			}

			friend = new Friend(otherUser, FriendState.SentRequest);
			user.Friends.Add(friend);
			SocialServer.Instance.Database.CreateFriend(user.Id, friend);

			Send.SC_NORMAL.SystemMessage(conn, "AckReqAddFriend", 1, 0);
			Send.SC_NORMAL.FriendRequested(conn, friend.User.Id);
			Send.SC_NORMAL.FriendInfo(conn, friend);

			var otherFriend = new Friend(user, FriendState.ReceivedRequest);
			otherUser.Friends.Add(otherFriend);
			SocialServer.Instance.Database.CreateFriend(otherUser.Id, otherFriend);

			if (otherUser.TryGetConnection(out var otherConn))
				Send.SC_NORMAL.FriendInfo(otherUser.Connection, otherFriend);
		}

		/// <summary>
		/// Request to block someone's account.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CS_REQ_BLOCK_FRIEND)]
		public void CS_REQ_BLOCK_FRIEND(ISocialConnection conn, Packet packet)
		{
			var teamName = packet.GetString();

			var user = conn.User;

			if (!SocialServer.Instance.UserManager.TryGet(teamName, out var otherUser))
			{
				Send.SC_NORMAL.SystemMessage(conn, "TargetUserNotExist", 1, 0);
				return;
			}

			user.Friends.BlockUser(otherUser, out var friend);

			Send.SC_NORMAL.FriendBlocked(conn, otherUser.Id);
			Send.SC_NORMAL.FriendInfo(conn, friend);
		}

		/// <summary>
		/// Friend management commands (accept, decline, delete).
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CS_FRIEND_CMD)]
		public void CS_FRIEND_CMD(ISocialConnection conn, Packet packet)
		{
			var i1 = packet.GetInt();
			var s1 = packet.GetShort();
			var friendAccountId = packet.GetLong();
			var cmd = (FriendCmd)packet.GetInt();
			var i2 = packet.GetInt();

			var user = conn.User;

			if (!user.Friends.TryGet(friendAccountId, out var friend))
			{
				Log.Warning("CS_FRIEND_CMD: User '{0}' tried to modify a friend without having them in their friends list.", user.Name);
				return;
			}

			if (cmd == FriendCmd.Delete)
			{
				user.Friends.Remove(friend);
				SocialServer.Instance.Database.DeleteFriend(friend.Id);

				Send.SC_NORMAL.FriendResponse(conn, friend);
			}
			else if (cmd == FriendCmd.Accept)
			{
				if (friend.State != FriendState.ReceivedRequest)
				{
					Log.Warning("CS_FRIEND_CMD: User '{0}' tried to accept a friend request with the friend's state being '{1}'.", user.Name, friend.State);
					return;
				}

				user.Friends.UpdateFriend(friend, FriendState.Accepted);

				Send.SC_NORMAL.FriendResponse(conn, friend);
				Send.SC_NORMAL.FriendInfo(conn, friend);

				if (friend.User.Friends.TryGet(user.Id, out var otherFriend))
				{
					friend.User.Friends.UpdateFriend(friend, FriendState.Accepted);

					if (friend.User.TryGetConnection(out var friendConn))
						Send.SC_NORMAL.FriendInfo(friendConn, otherFriend);
				}
			}
			else if (cmd == FriendCmd.Decline)
			{
				friend.User.Friends.UpdateFriend(friend, FriendState.Declined);

				Send.SC_NORMAL.FriendResponse(conn, friend);
				Send.SC_NORMAL.FriendInfo(conn, friend);
			}
		}

		/// <summary>
		/// Assigns a friend to a group.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CS_FRIEND_SET_ADDINFO)]
		public void CS_FRIEND_SET_ADDINFO(ISocialConnection conn, Packet packet)
		{
			var i1 = packet.GetInt();
			var s1 = packet.GetShort();
			var accountId = packet.GetLong();
			var groupName = packet.GetString(20);

			if (!conn.User.Friends.TryGet(accountId, out var friend))
			{
				Log.Warning("CS_FRIEND_SET_ADDINFO: User '{0}' tried to modify a friend without having them in their friends list.", conn.User.Name);
				return;
			}

			friend.Group = groupName;
			SocialServer.Instance.Database.SaveFriend(friend);

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
		/// Request to refresh all chat rooms?
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CS_REFRESH_GROUP_CHAT)]
		public void CS_REFRESH_GROUP_CHAT(ISocialConnection conn, Packet packet)
		{
			var user = conn.User;

			//foreach (var chatRoom in user.Account.GetChatRooms())
			//	Send.SC_NORMAL.MessageList(conn, chatRoom, chatRoom.GetMessages());
		}

		/// <summary>
		/// Request to create a chat room.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CS_CREATE_GROUP_CHAT)]
		public void CS_CREATE_GROUP_CHAT(ISocialConnection conn, Packet packet)
		{
			SocialServer.Instance.ChatManager.CreateChatRoom(conn.User);
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

			Send.SC_NORMAL.MessageList(conn, chatRoom, chatRoom.GetMessages());
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

			//conn.User.Account.RemoveChatRoom(chatId);
			//chatRoom.RemoveMember(conn.User.Id);

			//if (chatRoom.MemberCount == 0)
			//	SocialServer.Instance.ChatManager.RemoveChatRoom(chatId);
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
