// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Login.Database;
using Melia.Login.Network.Helpers;
using Melia.Login.World;
using Melia.Shared.Const;
using Melia.Shared.Network;
using Melia.Shared.Network.Helpers;
using Melia.Shared.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Login.Network
{
	public static class Send
	{
		public static void BC_LOGIN_PACKET_RECEIVED(LoginConnection conn)
		{
			var packet = new Packet(Op.BC_LOGIN_PACKET_RECEIVED);
			conn.Send(packet);
		}

		public static void BC_LOGINOK(LoginConnection conn)
		{
			var packet = new Packet(Op.BC_LOGINOK);
			packet.PutShort(0);
			packet.PutLong(conn.Account.Id);
			packet.PutString(conn.Account.Name, 33);
			packet.PutInt(3); // accountPrivileges? <= 3 enables a kind of debug context menu
			packet.PutString(conn.SessionKey, 64);
			packet.PutInt(4475); // [i10725 (2015-11-03)] ?

			conn.Send(packet);
		}

		public static void BC_LOGOUTOK(LoginConnection conn)
		{
			var packet = new Packet(Op.BC_LOGOUTOK);

			conn.Send(packet);
		}

		public static void BC_COMMANDER_LIST(LoginConnection conn)
		{
			var characters = conn.Account.GetCharacters();

			var packet = new Packet(Op.BC_COMMANDER_LIST);
			packet.PutLong(conn.Account.Id);
			packet.PutByte(0);
			packet.PutByte((byte)characters.Length);
			packet.PutString(conn.Account.TeamName, 64);

			packet.AddAccountProperties(conn.Account);

			foreach (var character in characters)
			{
				packet.AddCharacter(character);

				// Equip properties, short->length
				for (int i = 0; i < CommanderHelper.EquipSlotCount; ++i)
					packet.PutShort(0);

				// Job history?
				// While this short existed in iCBT1, it might not have
				// been used, couldn't find a log.
				// Example: A Mage that switched to Pyromancer has two
				//   elements in this list, 2001 and 2002.
				packet.PutShort(0); // count
				// loop
				//   short jobId
			}

			// Null terminated list of some kind?
			// Example of != 0: 02 00 | 0B 00 00 00 01 00, 0C 00 00 00 00 00
			packet.PutShort(0); // count?

			conn.Send(packet);
		}

		public static void BC_COMMANDER_CREATE(LoginConnection conn, Character character)
		{
			var packet = new Packet(Op.BC_COMMANDER_CREATE);
			packet.AddCharacter(character);

			conn.Send(packet);
		}

		public static void BC_BARRACKNAME_CHANGE(LoginConnection conn, TeamNameChangeResult result)
		{
			var response = new Packet(Op.BC_BARRACKNAME_CHANGE);
			response.PutByte(result == TeamNameChangeResult.Okay);
			response.PutInt((int)result);
			response.PutString(conn.Account.TeamName, 64);

			conn.Send(response);
		}

		public static void BC_MESSAGE(LoginConnection conn, MsgType msgType)
		{
			var packet = new Packet(Op.BC_MESSAGE);
			packet.PutByte((byte)msgType);

			conn.Send(packet);
		}

		public static void BC_MESSAGE(LoginConnection conn, string msg)
		{
			var packet = new Packet(Op.BC_MESSAGE);
			packet.PutByte((byte)MsgType.Text);
			packet.PutEmptyBin(40);
			packet.PutString(msg);

			conn.Send(packet);
		}

		public static void BC_COMMANDER_DESTROY(LoginConnection conn, byte index)
		{
			var packet = new Packet(Op.BC_COMMANDER_DESTROY);
			packet.PutByte(index);

			conn.Send(packet);
		}

		public static void BC_NORMAL_ZoneTraffic(LoginConnection conn)
		{
			var characters = conn.Account.GetCharacters();
			var mapAvailableCount = characters.Length;
			var zoneServerCount = 2;
			var zoneMaxPcCount = 150;

			var packet = new Packet(Op.BC_NORMAL);
			packet.PutInt(0x0B); //SubOp

			packet.BeginZlib();
			packet.PutShort(zoneMaxPcCount);
			packet.PutShort(mapAvailableCount);
			for (var i = 0; i < mapAvailableCount; ++i)
			{
				packet.PutShort(characters[i].MapId);
				packet.PutShort(zoneServerCount);
				for (var zone = 0; zone < zoneServerCount; ++zone)
				{
					packet.PutShort(zone);
					packet.PutShort(1); // currentPlayersCount
				}
			}
			packet.EndZlib();

			conn.Send(packet);
		}

		public static void BC_START_GAMEOK(LoginConnection conn, Character character, string ip, int port)
		{
			var packet = new Packet(Op.BC_START_GAMEOK);

			packet.PutInt(0);
			packet.PutInt(IPAddress.Parse(ip).ToInt32());
			packet.PutInt(port);
			packet.PutInt(character.MapId);
			packet.PutByte(0);
			packet.PutLong(character.Id);
			packet.PutByte(0); // Only connects if 0
			packet.PutByte(1); // Passed to a function if ^ is 0

			conn.Send(packet);
		}

		public static void BC_SERVER_ENTRY(LoginConnection conn, string ip1, int port1, string ip2, int port2)
		{
			var packet = new Packet(Op.BC_SERVER_ENTRY);

			packet.PutInt(IPAddress.Parse(ip1).ToInt32());
			packet.PutInt(IPAddress.Parse(ip2).ToInt32());
			packet.PutShort(port1);
			packet.PutShort(port2);

			conn.Send(packet);
		}

		public static void BC_ACCOUNT_PROP(LoginConnection conn, Account account)
		{
			var packet = new Packet(Op.BC_ACCOUNT_PROP);

			packet.PutLong(account.Id);
			packet.AddAccountProperties(account);

			conn.Send(packet);
		}

		public static void BC_NORMAL_Run(LoginConnection conn, string str)
		{
			// Probably runs a lua function? Example string: THEMA_BUY_SUCCESS

			var packet = new Packet(Op.BC_NORMAL);

			packet.PutInt(0x0E);
			packet.PutLpString(str);

			conn.Send(packet);
		}
	}
}
