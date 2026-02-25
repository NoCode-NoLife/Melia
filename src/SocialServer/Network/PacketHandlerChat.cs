using System;
using System.Collections.Generic;
using Melia.Shared.L10N;
using Melia.Shared.Network;
using Melia.Shared.Game.Const;
using Melia.Shared.ObjectProperties;
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
			// We're getting both a password and a session key in this packet,
			// and we could use either for the authentication, but using the
			// password will allow us to log in without a session key, enabling
			// a potential use case where we log into the social server with a
			// messenger app, to allow players to chat while offline.

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
			if (user.TryGetConnection(out var existingConn))
			{
				existingConn.Close();
				existingConn = null;
			}

			conn.User = user;
			conn.User.Connection = conn;
			conn.User.LastLogin = DateTime.Now;
			conn.LoggedIn = true;

			SocialServer.Instance.Database.UpdateLastSocialLogin(user);
			SocialServer.Instance.Database.LoadCharacterInfo(user);

			Log.Info("User '{0}' logged in.", user.Name);

			Send.SC_NORMAL.LoginSuccess(conn);
			Send.SC_LOGIN_OK(conn);
			Send.SC_NORMAL.Unknown_02(conn);

			user.Friends.RefreshList();
			user.Friends.RefreshStatus();
		}

		/// <summary>
		/// Sent after the client loaded the game world.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CS_NORMAL_GAME_START)]
		public void CS_NORMAL_GAME_START(ISocialConnection conn, Packet packet)
		{
			var user = conn.User;

			SocialServer.Instance.Database.LoadCharacterInfo(user);
			user.Friends.RefreshList();
			user.Friends.RefreshStatus();

			// Clean up stale party chat room memberships
			// This handles the case where a player left a party while offline
			// or the SocialServer wasn't notified of the change
			var currentRooms = SocialServer.Instance.ChatManager.FindChatRooms(user);
			foreach (var room in currentRooms)
			{
				// Check if this is a party chat room (ID has party range prefix)
				if ((room.Id & unchecked((long)0xFF00000000000000)) == ObjectIdRanges.Party)
				{
					// If user is no longer in this party, remove them from the chat room
					if (room.Id != user.Character.PartyId)
						room.RemoveMember(user.AccountId);
				}
			}

			// Only add to party chat room if user actually has a party
			// (PartyId equals just ObjectIdRanges.Party when partyId is 0 in database)
			if (conn.User.Character.PartyId != ObjectIdRanges.Party)
			{
				if (!SocialServer.Instance.ChatManager.TryGetChatRoom(user.Character.PartyId, out var chatRoom))
					chatRoom = SocialServer.Instance.ChatManager.CreateChatRoom(user, user.Character.PartyId, ChatRoomType.Friends);
				chatRoom.AddMember(user);
				Send.SC_NORMAL.MessageList(conn, chatRoom, chatRoom.GetMessages());
			}

			Send.SC_FROM_INTEGRATE.Unknown_01(conn.User);
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

			if (teamName == user.TeamName)
			{
				Log.Warning("CS_REQ_ADD_FRIEND: User '{0}' tried to add themselves as a friend.", user.Name);
				return;
			}

			if (!SocialServer.Instance.UserManager.TryGet(teamName, out var otherUser))
			{
				Send.SC_NORMAL.SystemMessage(conn, SystemMessageId.TargetUserNotExist);
				return;
			}

			if (user.Friends.TryGet(otherUser.Id, out var friend))
			{
				if (friend.State == FriendState.SentRequest)
					Send.SC_NORMAL.SystemMessage(conn, SystemMessageId.AlreadyRequestFriend);
				else
					Send.SC_NORMAL.SystemMessage(conn, SystemMessageId.AlreadyInFriendList);
				return;
			}

			user.Friends.AddFriendRequest(otherUser, out var newFriend, out var newOtherFriend);

			Send.SC_NORMAL.SystemMessage(conn, SystemMessageId.AckReqAddFriend);
			Send.SC_NORMAL.FriendRequested(conn, newFriend.User.Id);
			Send.SC_NORMAL.FriendInfo(conn, newFriend);

			if (otherUser.TryGetConnection(out var otherConn))
				Send.SC_NORMAL.FriendInfo(otherUser.Connection, newOtherFriend);
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
				Send.SC_NORMAL.SystemMessage(conn, SystemMessageId.TargetUserNotExist);
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
					friend.User.Friends.UpdateFriend(otherFriend, FriendState.Accepted);

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
		/// Changes a friend's note or group.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CS_FRIEND_SET_ADDINFO)]
		public void CS_FRIEND_SET_ADDINFO(ISocialConnection conn, Packet packet)
		{
			var i1 = packet.GetInt();
			var s1 = packet.GetShort();
			var accountId = packet.GetLong();
			var text = packet.GetString(140);
			var type = (FriendInfoType)packet.GetInt();

			if (!conn.User.Friends.TryGet(accountId, out var friend))
			{
				Log.Warning("CS_FRIEND_SET_ADDINFO: User '{0}' tried to modify a friend without having them in their friends list.", conn.User.Name);
				return;
			}

			switch (type)
			{
				case FriendInfoType.Group: friend.Group = text; break;
				case FriendInfoType.Note: friend.Note = text; break;
			}

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
				Log.Warning("CS_CHAT: Failed to execute chat command '{0}' for '{1}'.", msg, conn.User.Name);
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
		/// Invites someone to join a group chat.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CS_GROUP_CHAT_INVITE)]
		public void CS_GROUP_CHAT_INVITE(ISocialConnection conn, Packet packet)
		{
			var roomId = packet.GetLong();
			var teamName = packet.GetString(64);
			var roomName = packet.GetString(32);

			if (!SocialServer.Instance.UserManager.TryGet(teamName, out var invitedUser))
			{
				Send.SC_NORMAL.SystemMessage(conn, SystemMessageId.TargetUserNotExist);
				return;
			}

			if (!SocialServer.Instance.ChatManager.TryGetChatRoom(roomId, out var room))
			{
				Log.Warning("CS_GROUP_CHAT_INVITE: User '{0}' tried to invite someone to a non-existant group chat.", conn.User.Name);
				return;
			}

			if (room.Type != ChatRoomType.Group)
			{
				Log.Warning("CS_GROUP_CHAT_INVITE: User '{0}' tried to invite someone to '{1}', a non-group chat.", conn.User.Name, roomName);
				return;
			}

			if (room.IsMember(teamName))
			{
				Send.SC_NORMAL.SystemMessage(conn, SystemMessageId.AlreadyEnteredRoom);
				return;
			}

			if (room.MaxMembersReached)
			{
				Send.SC_NORMAL.SystemMessage(conn, SystemMessageId.LimitGroupChatMaxUserCnt);
				return;
			}

			// I don't remember any restrictions on inviting people to group
			// chats, but perhaps that should be an option? For example, we
			// could send a tag invite via whisper.

			room.AddMember(invitedUser);
			room.AddMessage(new ChatMessage(invitedUser, string.Format(Localization.Get("{0} has joined."), invitedUser.TeamName)));
		}

		/// <summary>
		/// Request to create an invite for a group chat.
		/// </summary>
		/// <remarks>
		/// This packet presumably only serves as a notification for the
		/// server to accept join requests, as client doesn't seem to wait
		/// for a response. The invite tag is added to the chat input either
		/// way. The tag takes the following form in a whisper message:
		///
		/// /w Name {a SLC 1@@@557516819791874}{#0000FF}{img link_whisper 24 24}New Chat1{/}{/}{/}
		/// </remarks>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CS_ALLOW_GROUP_CHAT_TAG_INVITE)]
		public void CS_ALLOW_GROUP_CHAT_TAG_INVITE(ISocialConnection conn, Packet packet)
		{
			var roomId = packet.GetLong();
			var roomName = packet.GetString(32);

			if (!SocialServer.Instance.ChatManager.TryGetChatRoom(roomId, out var room))
			{
				Log.Warning("CS_ALLOW_GROUP_CHAT_TAG_INVITE: User '{0}' tried to invite someone to a non-existant group chat.", conn.User.Name);
				return;
			}

			if (room.Type != ChatRoomType.Group)
			{
				Log.Warning("CS_ALLOW_GROUP_CHAT_TAG_INVITE: User '{0}' tried to create an invite for '{1}', a non-group chat.", conn.User.Name, roomName);
				return;
			}

			room.CreateInvite(conn.User.Id);
		}

		/// <summary>
		/// Request to create an invite for a group chat.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CS_GROUP_CHAT_INVITE_BY_TAG)]
		public void CS_GROUP_CHAT_INVITE_BY_TAG(ISocialConnection conn, Packet packet)
		{
			var roomId = packet.GetLong();
			var inviterId = packet.GetLong();

			var user = conn.User;

			if (!SocialServer.Instance.ChatManager.TryGetChatRoom(roomId, out var room))
			{
				Send.SC_NORMAL.SystemMessage(conn, SystemMessageId.InviteRejected);
				return;
			}

			if (room.Type != ChatRoomType.Group)
			{
				Log.Warning("CS_GROUP_CHAT_INVITE_BY_TAG: User '{0}' tried join '{1}', a non-group chat.", user.Name, roomId);
				return;
			}

			if (room.IsMember(user.TeamName))
			{
				Send.SC_NORMAL.SystemMessage(conn, SystemMessageId.AlreadyEnteredRoom);
				return;
			}

			if (!room.HasInvites(inviterId))
			{
				Log.Warning("CS_GROUP_CHAT_INVITE_BY_TAG: User '{0}' tried to join a group chat without an invite.", user.Name);
				return;
			}

			if (room.MaxMembersReached)
			{
				Send.SC_NORMAL.SystemMessage(conn, SystemMessageId.LimitGroupChatMaxUserCnt);
				return;
			}

			room.AddMember(user);
			room.AddMessage(new ChatMessage(user, string.Format(Localization.Get("{0} has joined."), user.TeamName)));
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

			var rooms = SocialServer.Instance.ChatManager.FindChatRooms(conn.User);
			foreach (var room in rooms)
			{
				Send.SC_NORMAL.CreateRoom(conn, room);
			}
		}

		/// <summary>
		/// Request to receive a chat room's message history?
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CS_REQ_CHAT_HISTORY)]
		public void CS_REQ_CHAT_HISTORY(ISocialConnection conn, Packet packet)
		{
			var roomId = packet.GetLong();

			var user = conn.User;

			if (!SocialServer.Instance.ChatManager.TryGetChatRoom(roomId, out var room))
			{
				Log.Warning("CS_REQ_CHAT_HISTORY: User '{0}' tried to get chat history for a non-existant room '{1}'.", user.Name, roomId);
				return;
			}

			if (!room.IsMember(user.TeamName))
			{
				Log.Warning("CS_REQ_CHAT_HISTORY: User '{0}' tried to get chat history for a room '{1}', that they're not a member of.", user.Name, roomId);
				return;
			}

			Send.SC_NORMAL.MessageList(conn, room, room.GetMessages());
		}

		/// <summary>
		/// Notification that a user has left a chat room.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CS_REQ_OUT_ROOM)]
		public void CS_REQ_OUT_ROOM(ISocialConnection conn, Packet packet)
		{
			var roomId = packet.GetLong();

			var user = conn.User;

			if (!SocialServer.Instance.ChatManager.TryGetChatRoom(roomId, out var room))
			{
				Log.Warning("CS_REQ_OUT_ROOM: User '{0}' tried to leave non-existant room '{1}'.", user.Name, roomId);
				return;
			}

			room.RemoveMember(user.AccountId);
			room.AddMessage(new ChatMessage(user, string.Format(Localization.Get("{0} has left."), user.TeamName)));
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

		[PacketHandler(Op.CS_PARTY_CLIENT_INFO_SEND)]
		public void CS_PARTY_CLIENT_INFO_SEND(ISocialConnection conn, Packet packet)
		{
			var partyType = (GroupType)packet.GetByte();
			var partyId = packet.GetLong();
			var b1 = packet.GetByte();
			var accountId = packet.GetLong();
			var l1 = packet.GetLong();
			var sessionObjectId = packet.GetInt(); // Main Session Object (90000)
			var propertySize = packet.GetInt();

			switch (b1)
			{
				// Silver Gained by Party Member?
				case 1:
					break;
				// Session Object Update?
				case 2:
					for (var i = 0; i < propertySize; i++)
					{
						var propId = packet.GetInt();
						var propValue = packet.GetInt();
					}
					break;
				// Some other party related update?
				case 3:
					break;
			}
		}
	}
}
