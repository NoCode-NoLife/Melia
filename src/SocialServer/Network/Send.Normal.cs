﻿using System;
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
				packet.PutDate(chatMessage.SentTime);
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
				packet.PutDate(chatMessage.SentTime);
				packet.PutLpString(chatRoom.Owner.TeamName);
				packet.PutLpString(chatMessage.Message);
				packet.PutLong(1);
				packet.PutDate(chatMessage.SentTime);
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
				packet.PutInt((int)chatRoom.Type);
				packet.PutShort(1);
				packet.PutByte(0); // b1
				packet.PutLong(0);
				packet.PutLpString(chatRoom.Name);
				packet.PutInt(chatRoom.MemberCount);
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
			/// <param name="systemMessageIdent"></param>
			/// <param name="s1"></param>
			/// <param name="b1"></param>
			public static void SystemMessage(ISocialConnection conn, string systemMessageIdent, short s1, byte b1)
			{
				if (!SocialServer.Instance.Data.SystemMessageDb.TryFind(systemMessageIdent, out var systemMessageId))
					throw new ArgumentException($"Client message '{systemMessageIdent}' not found.");

				var packet = new Packet(Op.SC_NORMAL);
				packet.PutInt(NormalOp.Social.SystemMessage);

				packet.PutInt(systemMessageId.ClassId);
				packet.PutShort(s1);
				packet.PutByte(b1);

				conn.Send(packet);
			}

			/// <summary>
			/// Sends the friend list and block list.
			/// </summary>
			/// <param name="conn"></param>
			public static void FriendInfo(ISocialConnection conn, Friend friend)
			{
				var packet = new Packet(Op.SC_NORMAL);
				packet.PutInt(NormalOp.Social.FriendInfo);

				packet.PutByte((byte)friend.State);
				packet.PutLong(friend.AccountId);

				packet.PutInt(1); // count
				{
					packet.PutLong(0);
					packet.PutLong(friend.AccountId);
					packet.PutString(friend.TeamName, 64);
					packet.PutString("", 56);
					packet.PutLong(0);
					packet.PutInt(friend.Character.Level);
					packet.PutString(friend.Character.Name, 128);
					packet.PutShort((short)friend.Character.Gender);
					packet.PutInt((int)friend.Character.JobId);
					packet.PutShort(0);
					packet.PutInt(0);
					packet.PutShort(1);
					packet.PutInt(friend.Character.Hair);
					packet.PutEmptyBin(26);
					packet.PutByte(0x80);
					packet.PutByte(0x80);
					packet.PutByte(0x80);
					packet.PutByte(0xFF);
					packet.PutEmptyBin(18);
					packet.PutShortDate(friend.LastLogin);
					packet.PutEmptyBin(36);
					packet.PutByte(0);
					packet.PutLpString(friend.Group);
					packet.PutLpString(friend.Note);
				}

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
				packet.PutLong(conn.User.Id);
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
			/// Comfirmation to a block request.
			/// </summary>
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
		}
	}
}