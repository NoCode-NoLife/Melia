// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Login.Database;
using Melia.Login.Network.Helpers;
using Melia.Login.World;
using Melia.Shared.Const;
using Melia.Shared.Network;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
			packet.PutInt(0); // accountPrivileges?
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
			packet.PutShort(3732); // Medal
			packet.PutFloat(500);
			packet.PutShort(3733); // ReceiveGiftMedal
			packet.PutFloat(5);
			packet.PutShort(3735); // GiftMedal
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
			var packet = new Packet(Op.BC_NORMAL);
			packet.PutInt(0xB); //SubOp

			var subPct = new Packet(Op.BC_NORMAL);
			var characters = conn.Account.GetCharacters();
			var mapAvailableCount = characters.Length;
			subPct.PutShort(150); // zoneMaxPcCount
			subPct.PutShort(mapAvailableCount);
			for (var i = 0; i < mapAvailableCount; ++i)
			{
				var zoneServerCount = 2;
				subPct.PutShort(characters[i].ZoneId);
				subPct.PutShort(zoneServerCount); // zoneServerCount
				for (var zone = 0; zone < zoneServerCount; ++zone)
				{
					subPct.PutShort(zone);
					subPct.PutShort(100); // currentPlayersCount
				}
			}
			var buffer = new byte[subPct.Length];
			subPct.Build(ref buffer, 0);
			packet.PutZlib(buffer);
			conn.Send(packet);
		}
	}
}
