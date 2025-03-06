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
			conn.LoggedIn = true;

			Log.Info("User '{0}' logged in.", user.Name);

			Send.SC_NORMAL.LoginSuccess(conn);
			Send.SC_NORMAL.LikedList(conn);
			Send.SC_NORMAL.LikedMeList(conn);
			Send.SC_LOGIN_OK(conn);
		}

		/// <summary>
		/// Sent after the client loaded the game world.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CS_NORMAL_GAME_START)]
		public void CS_NORMAL_GAME_START(ISocialConnection conn, Packet packet)
		{
			Send.SC_FROM_INTEGRATE.Unknown_01(conn.User);
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
		/// Request to receive a player's number of likes.
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
				Log.Warning("CS_GET_LIKE_COUNT: User '{0}' requested a like count for a user who couldn't be found.", conn.User.Name);
				return;
			}

			Send.SC_NORMAL.LikeCount(conn, otherUser.Id, otherUser.ReceivedLikes.Count);
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

			var user = conn.User;

			if (!SocialServer.Instance.UserManager.TryGet(accountId, out var otherUser))
			{
				Log.Warning("CS_LIKE_IT: User '{0}' requested to like a user who doesn't appear to exist.", user.Name);
				return;
			}

			if (otherUser.ReceivedLikes.Exists(otherUser.Id, user.Id))
			{
				Log.Warning("CS_LIKE_IT: User '{0}' requested to like a user who they've already liked.", user.Name);
				return;
			}

			var like = new Like(otherUser, user);

			// Saving the like on both users is a bit redundant, but it
			// makes it easier to get the list of likes for each user.
			// What's better? Not sure.
			user.SentLikes.Add(like);
			otherUser.ReceivedLikes.Add(like);
			SocialServer.Instance.Database.AddLike(like);

			Send.SC_NORMAL.LikeSuccess(conn, otherUser.Id, otherUser.TeamName);
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

			var user = conn.User;

			if (!SocialServer.Instance.UserManager.TryGet(accountId, out var otherUser))
			{
				Log.Warning("CS_UNLIKE_IT: User '{0}' requested to unlike a user who doesn't appear to exist.", user.Name);
				return;
			}

			if (!otherUser.ReceivedLikes.Exists(otherUser.Id, user.Id))
			{
				Log.Warning("CS_UNLIKE_IT: User '{0}' requested to unlike a user who they haven't liked.", user.Name);
				return;
			}

			user.SentLikes.Remove(otherUser.Id, user.Id);
			otherUser.ReceivedLikes.Remove(otherUser.Id, user.Id);
			SocialServer.Instance.Database.RemoveLike(otherUser.Id, user.Id);

			Send.SC_NORMAL.UnlikeSuccess(conn, otherUser.Id, otherUser.TeamName);
		}
	}
}
