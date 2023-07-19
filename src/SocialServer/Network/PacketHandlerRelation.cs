using Melia.Shared.Network;
using Melia.Social.Database;
using Yggdrasil.Logging;
using Yggdrasil.Security.Hashing;

namespace Melia.Social.Network
{
	public class PacketHandlerRelation : PacketHandler
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

			if (state == FriendState.Delete)
			{
				if (!conn.Account.DeleteFriend(friend))
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
		/// ?
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CS_ADD_RELATION_SCORE)]
		public void CS_ADD_RELATION_SCORE(ISocialConnection conn, Packet packet)
		{
			var extra = packet.GetBin(14);
			var teamName = packet.GetString(64);
			var l1 = packet.GetLong();

			Send.SC_NORMAL.Unknown_01(conn);
		}

		/// <summary>
		/// Request to receive a character's number of likes.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CS_GET_LIKE_COUNT)]
		public void CS_GET_LIKE_COUNT(ISocialConnection conn, Packet packet)
		{
			var i1 = packet.GetInt();
			var s1 = packet.GetShort();
			var accountId = packet.GetLong();

			if (!SocialServer.Instance.AccountManager.TryGetSocialConnection(accountId, out var otherConn))
			{
				Log.Warning("CS_GET_LIKE_COUNT: User '{0}' requested a like count for a user who isn't online.", conn.Account.Name);
				return;
			}

			var characterId = otherConn.Account.CharacterId;
			var likeCount = otherConn.Account.GetLikes(characterId);

			Send.SC_NORMAL.LikeCount(conn, accountId, likeCount);
		}

		/// <summary>
		/// Request to like a character.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CS_LIKE_IT)]
		public void CS_LIKE_IT(ISocialConnection conn, Packet packet)
		{
			var i1 = packet.GetInt();
			var s1 = packet.GetShort();
			var accountId = packet.GetLong();
			var characterId = packet.GetLong();
			var str1 = packet.GetString(64);

			if (!SocialServer.Instance.AccountManager.TryGetSocialConnection(accountId, out var otherConn))
			{
				Log.Warning("CS_LIKE_IT: User '{0}' requested to like a user who isn't online.", conn.Account.Name);
				return;
			}

			var account = otherConn.Account;
			account.AddLike(characterId);

			Send.SC_NORMAL.LikeSuccess(conn, account.Id, account.TeamName);
		}

		/// <summary>
		/// Request to rescind a like from a character.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CS_UNLIKE_IT)]
		public void CS_UNLIKE_IT(ISocialConnection conn, Packet packet)
		{
			var i1 = packet.GetInt();
			var s1 = packet.GetShort();
			var accountId = packet.GetLong();
			var characterId = packet.GetLong();

			if (!SocialServer.Instance.AccountManager.TryGetSocialConnection(accountId, out var otherConn))
			{
				Log.Warning("CS_UNLIKE_IT: User '{0}' requested to unlike a user who isn't online.", conn.Account.Name);
				return;
			}

			var account = otherConn.Account;
			account.RemoveLike(characterId);

			Send.SC_NORMAL.UnlikeSuccess(conn, account.Id, account.TeamName);
		}
	}
}
