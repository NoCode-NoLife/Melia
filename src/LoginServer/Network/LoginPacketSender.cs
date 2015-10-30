// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Login.Database;
using Melia.Login.Network.Helpers;
using Melia.Login.World;
using Melia.Shared.Const;
using Melia.Shared.Network;
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
		public static void BC_LOGINOK(LoginConnection conn)
		{
			var packet = new Packet(Op.BC_LOGINOK);
			packet.PutShort(0);
			packet.PutLong(conn.SessionId);
			packet.PutString(conn.Account.Name, 33);
			packet.PutInt(3); // accountPrivileges? <= 3 enables a kind of debug context menu
			packet.PutString("test string", 64); // sessionKey (*695ADFDD9FD07E69927F1F2F81BF415D966D344A)

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
			packet.PutLong(conn.SessionId);
			packet.PutByte(0);
			packet.PutByte((byte)characters.Length);
			packet.PutString(conn.Account.TeamName, 64);

			packet.PutShort(18); // Account properties size
			packet.PutShort(ObjectProperty.Account.Medal);
			packet.PutFloat(500);
			packet.PutShort(ObjectProperty.Account.ReceiveGiftMedal);
			packet.PutFloat(5);
			packet.PutShort(ObjectProperty.Account.GiftMedal);
			packet.PutFloat(10);

			foreach (var character in characters)
			{
				packet.AddCharacter(character);

				// Item properties, short->length
				packet.PutShort(0);
				packet.PutShort(0);
				packet.PutShort(0);
				packet.PutShort(0);
				packet.PutShort(0);
				packet.PutShort(0);
				packet.PutShort(0);
				packet.PutShort(0);
				packet.PutShort(0);
				packet.PutShort(0);
				packet.PutShort(0);
				packet.PutShort(0);
				packet.PutShort(0);
				packet.PutShort(0);
				packet.PutShort(0);
				packet.PutShort(0);
				packet.PutShort(0);
				packet.PutShort(0);
				packet.PutShort(0);
				packet.PutShort(0);

				packet.PutShort(0);
			}

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

		public static void BC_NORMAL_ZONE_TRAFFIC(LoginConnection conn)
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
			packet.PutByte(0); // Passed to a function if ^ is 0

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
	}
}
