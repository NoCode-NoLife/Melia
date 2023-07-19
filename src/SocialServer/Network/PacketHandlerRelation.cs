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
