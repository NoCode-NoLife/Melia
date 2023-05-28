using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Network;
using Melia.Social.Database;

namespace Melia.Social.Network
{
	public static class Send
	{
		/// <summary>
		/// Login succeeded
		/// </summary>
		/// <param name="conn"></param>
		public static void SC_LOGIN_OK(ISocialConnection conn)
		{
			var packet = new Packet(Op.SC_LOGIN_OK);

			conn.Send(packet);
		}

		/// <summary>
		/// Dummy
		/// </summary>
		public static void SC_FROM_INTEGRATE(ISocialConnection conn, int type)
		{
			var packet = new Packet(Op.SC_FROM_INTEGRATE);

			switch (type)
			{
				case 0x01:
					packet.PutLong(conn.Account.Id);
					packet.PutInt(0);
					break;
				case 0x14:
					packet.PutLong(conn.Account.Id);
					packet.PutInt(0); // 728
					break;
			}
			conn.Send(packet);
		}

		/// <summary>
		/// Login related
		/// </summary>
		/// <param name="conn"></param>
		public static void SC_NORMAL_Unknown_00(ISocialConnection conn)
		{
			var packet = new Packet(Op.SC_NORMAL);
			packet.PutInt(NormalOp.Social.Unknown_00);

			conn.Send(packet);
		}

		/// <summary>
		/// Login related
		/// </summary>
		/// <param name="conn"></param>
		public static void SC_NORMAL_Unknown_02(ISocialConnection conn)
		{
			var packet = new Packet(Op.SC_NORMAL);
			packet.PutInt(NormalOp.Social.Unknown_02);

			conn.Send(packet);
		}

		public static void SC_NORMAL_Unknown_0C(ISocialConnection conn)
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
		/// Dummy
		/// </summary>
		public static void SC_NORMAL_Unknown_19(ISocialConnection conn)
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

		/// <summary>
		/// Dummy
		/// </summary>
		public static void SC_NORMAL_Chat(ISocialConnection conn, Account account, long chatId, long l1, string targetTeamName, string message, byte b2)
		{
			var packet = new Packet(Op.SC_NORMAL);

			packet.PutInt(NormalOp.Social.Chat);
			packet.PutLong(chatId); // Chat Id
			packet.PutLong(l1); // Chat Index?
			packet.PutByte(1);
			packet.PutDate(DateTime.Now);
			packet.PutLpString(account.TeamName);
			packet.PutShort(1001);
			packet.PutLpString(message);
			packet.PutByte(b2);
			packet.PutInt(2);
			packet.PutShort(1);
			packet.PutByte(0);
			packet.PutLpString(targetTeamName);
			packet.PutLpString("GLOBAL");

			conn.Send(packet);
		}

		/// <summary>
		/// Dummy
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="account"></param>
		/// <param name="message"></param>
		public static void SC_NORMAL_CreateChatRoom(ISocialConnection conn, Account account, long chatId, string message = "!@#$NewRoomHasBeenCreated#@!")
		{
			var packet = new Packet(Op.SC_NORMAL);

			packet.PutInt(NormalOp.Social.CreateChatRoom);
			packet.PutLong(chatId); // Chat Room Id
			packet.PutInt(2);
			packet.PutLong(1);
			packet.PutDate(DateTime.Now);
			packet.PutLpString(account.TeamName);
			packet.PutLpString(message);
			packet.PutLong(1);
			packet.PutDate(DateTime.Now);
			packet.PutLpString(account.TeamName);
			packet.PutLpString(message);

			conn.Send(packet);
		}

		/// <summary>
		/// Dummy
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="account"></param>
		public static void SC_NORMAL_ChatLog(ISocialConnection conn, Account account, long chatId, Account target)
		{
			var packet = new Packet(Op.SC_NORMAL);

			packet.PutInt(NormalOp.Social.ChatLog);
			packet.PutLong(chatId);
			packet.PutInt(0);
			packet.PutShort(1);
			packet.PutByte(0); // b1
			packet.PutLong(1);
			packet.PutShort(1);
			packet.PutShort(0);
			packet.PutByte(0); // b2
			packet.PutInt(2);
			packet.PutInt(2);
			packet.PutByte(1); // b3
			packet.PutLong(account.Id);
			packet.PutLpString(account.TeamName);
			packet.PutInt(1);
			packet.PutLong(target.Id);
			packet.PutLpString(target.TeamName);

			conn.Send(packet);
		}

		/// <summary>
		/// Dummy
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="account"></param>
		public static void SC_NORMAL_ChatLog(ISocialConnection conn, Account account, long chatId, long targetId, string targetName)
		{
			var packet = new Packet(Op.SC_NORMAL);

			packet.PutInt(NormalOp.Social.ChatLog);
			packet.PutLong(chatId);
			packet.PutInt(0);
			packet.PutShort(1);
			packet.PutByte(0); // b1
			packet.PutLong(1);
			packet.PutShort(1);
			packet.PutShort(0);
			packet.PutByte(0); // b2
			packet.PutInt(2);
			packet.PutInt(2);
			packet.PutByte(1); // b3
			packet.PutLong(account.Id);
			packet.PutLpString(account.TeamName);
			packet.PutInt(1);
			packet.PutLong(targetId);
			packet.PutLpString(targetName);

			conn.Send(packet);
		}

		public static void SC_NORMAL_SystemMessage(ISocialConnection conn, int clientMessageId, short s1, byte b1)
		{
			var packet = new Packet(Op.SC_NORMAL);

			packet.PutInt(NormalOp.Social.SystemMessage);
			packet.PutInt(clientMessageId);
			packet.PutShort(s1);
			packet.PutByte(b1);

			conn.Send(packet);
		}
	}
}
