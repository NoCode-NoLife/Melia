using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Network;
using Melia.Social.Database;
using Melia.Social.Network.Helpers;
using Melia.Social.World;

namespace Melia.Social.Network
{
	public static partial class Send
	{
		public static class SC_NORMAL
		{
			/// <summary>
			/// Notifies client that the login was successful.
			/// </summary>
			/// <remarks>
			/// It's unknown why this is necessary, since SC_LOGIN_OK exists
			/// as well, but without it you can't chat and the client won't
			/// request like numbers.
			/// </remarks>
			/// <param name="conn"></param>
			public static void LoginSuccess(ISocialConnection conn)
			{
				var packet = new Packet(Op.SC_NORMAL);
				packet.PutInt(NormalOp.Social.LoginSuccess);

				conn.Send(packet);
			}

			/// <summary>
			/// Unknown purpose.
			/// </summary>
			/// <remarks>
			/// Might be a response to CS_ADD_RELATION_SCORE.
			/// </remarks>
			/// <param name="conn"></param>
			public static void Unknown_01(ISocialConnection conn)
			{
				var packet = new Packet(Op.SC_NORMAL);
				packet.PutInt(NormalOp.Social.Unknown_01);
				packet.PutInt(3);

				conn.Send(packet);
			}

			/// <summary>
			/// Sent after login, purpose unknonwn.
			/// </summary>
			/// <remarks>
			/// Not sending this packet doesn't appear to have a noticable
			/// effect.
			/// </remarks>
			/// <param name="conn"></param>
			public static void Unknown_02(ISocialConnection conn)
			{
				var packet = new Packet(Op.SC_NORMAL);
				packet.PutInt(NormalOp.Social.Unknown_02);

				conn.Send(packet);
			}

			/// <summary>
			/// Adds message to chat room.
			/// </summary>
			/// <param name="conn"></param>
			/// <param name="chatRoom"></param>
			/// <param name="chatMessage"></param>
			public static void AddMessage(ISocialConnection conn, ChatRoom chatRoom, ChatMessage chatMessage)
			{
				var packet = new Packet(Op.SC_NORMAL);
				packet.PutInt(NormalOp.Social.AddMessage);

				packet.PutLong(chatRoom.Id); // Chat Id
				packet.PutLong((long)chatRoom.Type); // msg id?
				packet.PutByte(1);
				packet.PutDate(chatMessage.SentTime);
				packet.PutLpString(chatMessage.SenderTeamName);
				packet.PutShort(1001); // server group?
				packet.PutLpString(chatMessage.Message);
				packet.PutByte(0); // 0 or 1
				packet.PutInt((int)chatMessage.Type);
				packet.PutShort(1);
				packet.PutByte(0);
				packet.PutLpString(chatMessage.TargetTeamName);
				packet.PutLpString("GLOBAL");

				chatRoom.Broadcast(packet);
			}

			/// <summary>
			/// Updates a chat room's messages on the client.
			/// </summary>
			/// <param name="conn"></param>
			/// <param name="chatRoom"></param>
			/// <param name="chatMessages"></param>
			public static void MessageList(ISocialConnection conn, ChatRoom chatRoom, IEnumerable<ChatMessage> chatMessages)
			{
				var packet = new Packet(Op.SC_NORMAL);
				packet.PutInt(NormalOp.Social.MessageList);

				packet.PutLong(chatRoom.Id);
				packet.PutInt(chatMessages.Count());

				foreach (var chatMessage in chatMessages)
				{
					packet.PutLong(1); // msg id?
					packet.PutDate(chatMessage.SentTime);
					packet.PutLpString(chatMessage.SenderTeamName);
					packet.PutLpString(chatMessage.Message);
				}

				conn.Send(packet);
			}

			/// <summary>
			/// Creates/updates chat room on the client.
			/// </summary>
			/// <param name="conn"></param>
			/// <param name="chatRoom"></param>
			public static void CreateRoom(ISocialConnection conn, ChatRoom chatRoom)
			{
				var packet = new Packet(Op.SC_NORMAL);
				packet.PutInt(NormalOp.Social.CreateRoom);

				packet.PutLong(chatRoom.Id);
				packet.PutInt((int)chatRoom.Type);
				packet.PutLpString("");
				packet.PutLong(0);
				packet.PutLpString(chatRoom.Name);
				packet.PutInt(chatRoom.MemberCount);
				packet.PutInt(2);
				packet.PutByte(1);

				foreach (var member in chatRoom.GetMembers())
				{
					packet.PutLong(member.AccountId);
					packet.PutLpString(member.TeamName);
					packet.PutByte(member.IsOnline);
					packet.PutGap(3);
				}

				conn.Send(packet);
			}

			/// <summary>
			/// Sends a message to client using system message ids.
			/// </summary>
			/// <param name="conn"></param>
			/// <param name="clientMessage">String identifier for the client message.</param>
			/// <param name="parameter">Optional parameter that gets inserted into the client message.</param>
			public static void SystemMessage(ISocialConnection conn, string clientMessage, string parameter = null)
			{
				if (!SocialServer.Instance.Data.SystemMessageDb.TryFind(clientMessage, out var systemMessageId))
					throw new ArgumentException($"System message '{clientMessage}' not found.");

				var packet = new Packet(Op.SC_NORMAL);
				packet.PutInt(NormalOp.Social.SystemMessage);

				packet.PutInt(systemMessageId.ClassId);
				packet.PutString(parameter);

				conn.Send(packet);
			}

			/// <summary>
			/// Updates friend on client.
			/// </summary>
			/// <param name="conn"></param>
			/// <param name="friend"></param>
			public static void FriendInfo(ISocialConnection conn, Friend friend)
			{
				var packet = new Packet(Op.SC_NORMAL);
				packet.PutInt(NormalOp.Social.FriendInfo);

				packet.PutByte((byte)friend.State);
				packet.PutLong(friend.User.Id);
				packet.PutInt(1); // count
				packet.AddFriend(friend);

				conn.Send(packet);
			}

			/// <summary>
			/// Updates list of friends of the given type on client.
			/// </summary>
			/// <remarks>
			/// The client is capable of taking an entire list of friends
			/// of a given type at once, but the packet handling seems
			/// sketchy. You need to send multiple lists, one for each
			/// state, and they need to be sent on a delay because the
			/// client will ignore them if they come in all bunched up
			/// together.
			/// </remarks>
			/// <param name="conn"></param>
			/// <param name="state"></param>
			/// <param name="friends"></param>
			public static void FriendInfo(ISocialConnection conn, FriendState state, IEnumerable<Friend> friends)
			{
				var packet = new Packet(Op.SC_NORMAL);
				packet.PutInt(NormalOp.Social.FriendInfo);

				packet.PutByte((byte)state);
				packet.PutLong(0);
				packet.PutInt(friends.Count());

				foreach (var friend in friends)
					packet.AddFriend(friend);

				conn.Send(packet);
			}

			/// <summary>
			/// Responses to friend requests
			/// </summary>
			/// <param name="conn"></param>
			/// <param name="friend"></param>
			public static void FriendResponse(ISocialConnection conn, Friend friend)
			{
				var packet = new Packet(Op.SC_NORMAL);
				packet.PutInt(NormalOp.Social.FriendResponse);

				packet.PutByte((byte)friend.State);
				packet.PutLong(friend.User.Id);

				conn.Send(packet);
			}

			/// <summary>
			/// Sends buff data or position data for party/guild.
			/// </summary>
			/// <param name="conn"></param>
			public static void PartyMemberUpdate(ISocialConnection conn)
			{
				var packet = new Packet(Op.SC_NORMAL);
				packet.PutInt(NormalOp.Social.PartyMemberUpdate);

				// Dummy data for a buff update, check SC_NORMAL template
				// for more information and other update types.

				packet.PutByte(0);
				packet.PutLong(554643486671500);
				packet.PutByte(1);
				packet.PutLong(conn.User.Id);
				packet.PutInt(4723);
				packet.PutInt(1);
				packet.PutInt(0);
				packet.PutByte(0);

				conn.Send(packet);
			}

			/// <summary>
			/// Positive response to a friend request.
			/// </summary>
			/// <param name="conn"></param>
			/// <param name="accountId"></param>
			public static void FriendRequested(ISocialConnection conn, long accountId)
			{
				var packet = new Packet(Op.SC_NORMAL);
				packet.PutInt(NormalOp.Social.FriendRequested);
				packet.PutLong(accountId);

				conn.Send(packet);
			}

			/// <summary>
			/// Positive response to a block request.
			/// </summary>
			/// <param name="conn"></param>
			/// <param name="accountId"></param>
			public static void FriendBlocked(ISocialConnection conn, long accountId)
			{
				var packet = new Packet(Op.SC_NORMAL);
				packet.PutInt(NormalOp.Social.FriendBlocked);
				packet.PutLong(accountId);

				conn.Send(packet);
			}

			/// <summary>
			/// Unknown purpose.
			/// </summary>
			/// <param name="conn"></param>
			public static void Unknown_19(ISocialConnection conn)
			{
				var packet = new Packet(Op.SC_NORMAL);
				packet.PutInt(NormalOp.Social.Unknown_19);

				packet.PutLong(conn.User.Id);
				packet.PutLong(conn.User.Id);
				packet.PutEmptyBin(16);
				packet.PutLpString("WEEK");
				packet.PutLong(1);

				conn.Send(packet);
			}

			/// <summary>
			/// Response to a like count request from the client.
			/// </summary>
			/// <param name="conn"></param>
			/// <param name="accountId"></param>
			/// <param name="count"></param>
			public static void LikeCount(ISocialConnection conn, long accountId, int count)
			{
				var packet = new Packet(Op.SC_NORMAL);
				packet.PutInt(NormalOp.Social.LikeCount);

				packet.PutLong(accountId);
				packet.PutInt(count);

				conn.Send(packet);
			}

			/// <summary>
			/// Notification that a like request succeeded.
			/// </summary>
			/// <param name="conn"></param>
			/// <param name="accountId"></param>
			/// <param name="teamName"></param>
			public static void LikeSuccess(ISocialConnection conn, long accountId, string teamName)
			{
				var packet = new Packet(Op.SC_NORMAL);
				packet.PutInt(NormalOp.Social.LikeSuccess);

				packet.PutLong(accountId);
				packet.PutLpString(teamName);

				conn.Send(packet);
			}

			/// <summary>
			/// Notification that an unlike request succeeded.
			/// </summary>
			/// <param name="conn"></param>
			/// <param name="accountId"></param>
			/// <param name="teamName"></param>
			public static void UnlikeSuccess(ISocialConnection conn, long accountId, string teamName)
			{
				var packet = new Packet(Op.SC_NORMAL);
				packet.PutInt(NormalOp.Social.UnlikeSuccess);

				packet.PutLong(accountId);
				packet.PutLpString(teamName);

				conn.Send(packet);
			}

			/// <summary>
			/// Notification that a like request failed.
			/// </summary>
			/// <param name="conn"></param>
			public static void LikeFailed(ISocialConnection conn)
			{
				var packet = new Packet(Op.SC_NORMAL);
				packet.PutInt(NormalOp.Social.LikeFailed);

				conn.Send(packet);
			}

			/// <summary>
			/// Updates client's list of likes the player sent.
			/// </summary>
			/// <param name="conn"></param>
			public static void LikedList(ISocialConnection conn)
			{
				var likes = conn.User.SentLikes;

				var packet = new Packet(Op.SC_NORMAL);
				packet.PutInt(NormalOp.Social.LikedList);

				packet.PutInt(likes.Count);

				foreach (var like in likes.GetAll())
					packet.PutLpString(like.ReceiverName);

				conn.Send(packet);
			}

			/// <summary>
			/// Updates client's list of likes the player received.
			/// </summary>
			/// <param name="conn"></param>
			public static void LikedMeList(ISocialConnection conn)
			{
				var likes = conn.User.ReceivedLikes;

				var packet = new Packet(Op.SC_NORMAL);
				packet.PutInt(NormalOp.Social.LikedMeList);

				packet.PutInt(likes.Count);

				foreach (var like in likes.GetAll())
				{
					packet.PutLpString(like.SenderName);
					packet.PutDate(like.Time);
					packet.PutByte(1);
				}

				conn.Send(packet);
			}

			/// <summary>
			/// Broadcasts shout to all active users.
			/// </summary>
			/// <param name="sender"></param>
			/// <param name="messageText"></param>
			public static void Shout(SocialUser sender, string messageText)
			{
				var packet = new Packet(Op.SC_NORMAL);
				packet.PutInt(NormalOp.Social.Shout);

				packet.PutLpString(sender.TeamName);
				packet.PutLong(sender.AccountId);
				packet.PutLpString(messageText);
				packet.PutLpString("GLOBAL");

				SocialServer.Instance.UserManager.Broadcast(packet);
			}
		}
	}
}
