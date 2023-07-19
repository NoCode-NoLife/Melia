using Melia.Shared.Network;
using Melia.Social.Database;
using Melia.Social.World;
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

			Send.SC_LOGIN_OK(conn);
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

			if (!SocialServer.Instance.UserManager.TryGet(accountId, out var otherUser))
			{
				Log.Warning("CS_GET_LIKE_COUNT: User '{0}' requested a like count for a user who isn't online.", conn.User.Name);
				return;
			}

			var characterId = otherUser.Account.CharacterId;
			var likeCount = otherUser.Account.GetLikes(characterId);

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

			if (!SocialServer.Instance.UserManager.TryGet(accountId, out var otherUser))
			{
				Log.Warning("CS_LIKE_IT: User '{0}' requested to like a user who isn't online.", conn.User.Name);
				return;
			}

			var account = otherUser.Account;
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

			if (!SocialServer.Instance.UserManager.TryGet(accountId, out var otherUser))
			{
				Log.Warning("CS_UNLIKE_IT: User '{0}' requested to unlike a user who isn't online.", conn.User.Name);
				return;
			}

			var account = otherUser.Account;
			account.RemoveLike(characterId);

			Send.SC_NORMAL.UnlikeSuccess(conn, account.Id, account.TeamName);
		}
	}
}
