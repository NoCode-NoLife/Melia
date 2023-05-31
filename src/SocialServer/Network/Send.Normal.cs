using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Network;
using Melia.Social.Database;

namespace Melia.Social.Network
{
	public static partial class Send
	{
		public static class SC_NORMAL
		{
			/// <summary>
			/// Enables chat functions, without this
			/// the client doesn't send chat packets to
			/// the server.
			/// </summary>
			/// <param name="conn"></param>
			public static void EnableChat(ISocialConnection conn)
			{
				var packet = new Packet(Op.SC_NORMAL);

				packet.PutInt(NormalOp.Social.Unknown_00);

				conn.Send(packet);
			}

			/// <summary>
			/// Unknown purpose
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
			/// Unknown purpose
			/// Sent after login.
			/// </summary>
			/// <remarks>
			/// Tried disabling and made no visible difference.
			/// </remarks>
			/// <param name="conn"></param>
			public static void Unknown_02(ISocialConnection conn)
			{
				var packet = new Packet(Op.SC_NORMAL);

				packet.PutInt(NormalOp.Social.Unknown_02);

				conn.Send(packet);
			}

			/// <summary>
			/// Show's chat in chat room?
			/// </summary>
			/// <param name="conn"></param>
			/// <param name="chatRoom"></param>
			/// <param name="chatMessage"></param>
			public static void Chat(ISocialConnection conn, ChatRoom chatRoom, ChatMessage chatMessage)
			{
				var packet = new Packet(Op.SC_NORMAL);

				packet.PutInt(NormalOp.Social.Chat);
				packet.PutLong(chatRoom.Id); // Chat Id
				packet.PutLong(1);
				packet.PutByte(1);
				packet.PutDate(chatMessage.TimeStamp);
				packet.PutLpString(chatMessage.Sender.TeamName);
				packet.PutShort(1001);
				packet.PutLpString(chatMessage.Message);
				packet.PutByte(0); // 0 or 1
				packet.PutInt(2);
				packet.PutShort(1);
				packet.PutByte(0);
				packet.PutLpString(chatMessage.Recipient?.TeamName ?? "");
				packet.PutLpString("GLOBAL");

				conn.Send(packet);
			}



			/// <summary>
			/// Create's a chat room message.
			/// </summary>
			/// <param name="conn"></param>
			/// <param name="chatRoom"></param>
			/// <param name="chatMessage"></param>
			public static void ChatRoomMessage(ISocialConnection conn, ChatRoom chatRoom, ChatMessage chatMessage)
			{
				var packet = new Packet(Op.SC_NORMAL);

				packet.PutInt(NormalOp.Social.ChatRoomMessage);
				packet.PutLong(chatRoom.Id);
				packet.PutInt(2);
				packet.PutLong(1);
				packet.PutDate(chatMessage.TimeStamp);
				packet.PutLpString(chatRoom.Owner.TeamName);
				packet.PutLpString(chatMessage.Message);
				packet.PutLong(1);
				packet.PutDate(chatMessage.TimeStamp);
				packet.PutLpString(chatRoom.Owner.TeamName);
				packet.PutLpString(chatMessage.Message);

				chatRoom.Broadcast(packet);
			}

			/// <summary>
			/// Chat Log
			/// </summary>
			/// <param name="conn"></param>
			/// <param name="chatRoom"></param>
			/// <param name="chatMessage"></param>
			public static void ChatLog(ISocialConnection conn, ChatRoom chatRoom, ChatMessage chatMessage)
			{
				var packet = new Packet(Op.SC_NORMAL);

				packet.PutInt(NormalOp.Social.ChatLog);
				packet.PutLong(chatRoom.Id);
				packet.PutInt((int)chatRoom.Type); // 0 or 3?
				packet.PutShort(1);
				packet.PutByte(0); // b1
				packet.PutLong(0);
				packet.PutLpString(chatRoom.Name);
				packet.PutInt(chatRoom.MemberCount());
				packet.PutInt(2);
				packet.PutByte(1); // b3
				packet.PutLong(chatMessage.Sender.Id);
				packet.PutLpString(chatMessage.Sender.TeamName);
				packet.PutInt(1);
				if (chatMessage.Recipient != null)
				{
					packet.PutLong(chatMessage.Recipient.Id);
					packet.PutLpString(chatMessage.Recipient.TeamName);
					packet.PutInt(1);
				}

				conn.Send(packet);
			}

			/// <summary>
			/// Sends a message to client using client message ids.
			/// </summary>
			/// <param name="conn"></param>
			/// <param name="clientMessageId"></param>
			/// <param name="s1"></param>
			/// <param name="b1"></param>
			public static void SystemMessage(ISocialConnection conn, int clientMessageId, short s1, byte b1)
			{
				var packet = new Packet(Op.SC_NORMAL);

				packet.PutInt(NormalOp.Social.SystemMessage);
				packet.PutInt(clientMessageId);
				packet.PutShort(s1);
				packet.PutByte(b1);

				conn.Send(packet);
			}

			/// <summary>
			/// Sends the friend list and block list.
			/// Type (2 = Friend, 3 = Declined, 4 = Blocked)
			/// </summary>
			/// <param name="conn"></param>
			public static void FriendInfo(ISocialConnection conn, Friend friend)
			{
				var packet = new Packet(Op.SC_NORMAL);

				packet.PutInt(NormalOp.Social.FriendInfo);
				packet.PutByte((byte)friend.State);
				packet.PutLong(friend.AccountId);
				packet.PutLong(1);
				packet.PutInt(0);
				packet.PutLong(friend.AccountId);
				packet.PutString(friend.TeamName, 128);
				packet.PutInt(friend.Level);
				packet.PutString(friend.Name, 128);
				packet.PutShort((short)friend.Gender);
				packet.PutInt((int)friend.JobId);
				packet.PutShort(0);
				packet.PutInt(0);
				packet.PutShort(1);
				packet.PutInt(friend.Hair);
				packet.PutEmptyBin(26);
				packet.PutByte(0x80); //128
				packet.PutByte(0x80); //128
				packet.PutByte(0x80); //128
				packet.PutByte(0xFF); //255
				packet.PutEmptyBin(18);
				packet.PutShortDate(friend.LastLoginDate);
				packet.PutEmptyBin(36);
				packet.PutByte(0);
				packet.PutLpString(friend.Group);
				packet.PutLpString(friend.Note);

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
				packet.PutLong(friend.AccountId);

				conn.Send(packet);
			}

			/// <summary>
			/// Sends buff data or position data for party/guild.
			/// </summary>
			/// <param name="conn"></param>
			public static void Unknown_0C(ISocialConnection conn)
			{
				var packet = new Packet(Op.SC_NORMAL);

				packet.PutInt(NormalOp.Social.Buff_0C);
				packet.PutByte(0);
				packet.PutLong(554643486671500);
				packet.PutByte(1);
				packet.PutLong(conn.Account.Id);
				packet.PutInt(4723);
				packet.PutInt(1);
				packet.PutInt(0);
				packet.PutByte(0);

				conn.Send(packet);
			}

			/// <summary>
			/// Sends account id of friend request.
			/// </summary>
			/// <remarks>
			/// Response to CS_REQ_ADD_FRIEND
			/// </remarks>
			public static void FriendRequested(ISocialConnection conn, long accountId)
			{
				var packet = new Packet(Op.SC_NORMAL);

				packet.PutInt(NormalOp.Social.FriendRequested);
				packet.PutLong(accountId);

				conn.Send(packet);
			}

			/// <summary>
			/// Sends account id of player blocked.
			/// </summary>
			/// <remarks>
			/// Response to CS_REQ_BLOCK_FRIEND
			/// </remarks>
			public static void FriendBlocked(ISocialConnection conn, long accountId)
			{
				var packet = new Packet(Op.SC_NORMAL);

				packet.PutInt(NormalOp.Social.FriendBlocked);
				packet.PutLong(accountId);

				conn.Send(packet);
			}

			/// <summary>
			/// Unknown purpose
			/// </summary>
			public static void Unknown_19(ISocialConnection conn)
			{
				var packet = new Packet(Op.SC_NORMAL);

				packet.PutInt(NormalOp.Social.Unknown_19);
				packet.PutLong(conn.Account.Id);
				packet.PutLong(conn.Account.Id);
				packet.PutEmptyBin(16);
				packet.PutLpString("WEEK");
				packet.PutLong(1);

				conn.Send(packet);
			}
		}
	}

}
