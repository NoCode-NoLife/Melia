// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System.Linq;
using System.Net;
using Melia.Login.Database;
using Melia.Login.Network.Helpers;
using Melia.Login.World;
using Melia.Shared.Const;
using Melia.Shared.Network;
using Melia.Shared.Util;
using Melia.Shared.World;
using Melia.Shared.Network.Helpers;
using System;

namespace Melia.Login.Network
{
	public static class Send
	{
		/// <summary>
		/// Sends notification that login packet was received.
		/// </summary>
		/// <param name="conn"></param>
		public static void BC_LOGIN_PACKET_RECEIVED(LoginConnection conn)
		{
			var packet = new Packet(Op.BC_LOGIN_PACKET_RECEIVED);
			conn.Send(packet);
		}

		/// <summary>
		/// Sends positive response to login attempt.
		/// </summary>
		/// <param name="conn"></param>
		public static void BC_LOGINOK(LoginConnection conn)
		{
			var packet = new Packet(Op.BC_LOGINOK);
			packet.PutShort(1001); // Server Group Id
			packet.PutLong(conn.Account.Id);
			packet.PutString(conn.Account.Name, 33);
			packet.PutEmptyBin(23);
			packet.PutInt(3); // accountPrivileges? <= 3 enables a kind of debug context menu
			packet.PutString(conn.SessionKey, 64);
			packet.PutInt(4475);
			packet.PutLong(0);

			conn.Send(packet);
		}

		/// <summary>
		/// Sends positive response to logout attempt.
		/// </summary>
		/// <param name="conn"></param>
		public static void BC_LOGOUTOK(LoginConnection conn)
		{
			var packet = new Packet(Op.BC_LOGOUTOK);
			conn.Send(packet);
		}

		/// <summary>
		/// Sends a list of characters to the client.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="layer">This is the number on the left side of the character list in the client.</param>
		public static void BC_SPLIT_COMMANDER_INFO_LIST(LoginConnection conn)
		{
			var characters = conn.Account.GetCharacters().Where(x => x.BarrackLayer == conn.Account.SelectedBarrackLayer).ToList();
			var packet = new Packet(Op.BC_SPLIT_COMMANDER_INFO_LIST);
			packet.PutInt(characters.Count());
			packet.PutLong(conn.Account.Id);
			if (characters != null && characters.Count == 0)
			{
				packet.PutByte(0);
				packet.PutByte(0);
				packet.PutByte(1);
			}
			else
			{
				packet.PutByte(0);
				packet.PutByte(1);
				packet.PutByte(1);
				foreach (var character in characters)
				{
					packet.AddBarrackPc(character);
				}
			}

			conn.Send(packet);
		}

		public static void BC_COMMANDER_LIST(LoginConnection conn)
		{
			var barrackCharacters = conn.Account.GetCharacters().Where(x => x.BarrackLayer == conn.Account.SelectedBarrackLayer).ToList();
			var characters = conn.Account.GetCharacters().ToList();
			var packet = new Packet(Op.BC_COMMANDER_LIST);
			packet.PutLong(conn.Account.Id);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutString(conn.Account.TeamName, 64);
			//packet.AddFullAccountProperties(conn.Account);
			packet.AddAccountProperties(conn.Account);

			packet.PutShort(1); // Additional Characters
			packet.PutInt(0x0B); // MapID
			packet.PutInt(barrackCharacters.Count); // Character Count on Current Lodge
			packet.PutInt(100); // Team Exp
			packet.PutShort(characters.Count); // Total Character Count
			conn.Send(packet);

			if (characters != null && characters.Count > 0)
			{
				Send.BC_SPLIT_COMMANDER_INFO_LIST(conn);
			}
		}

		/// <summary>
		/// Sends the new character's index.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="character"></param>
		public static void BC_COMMANDER_CREATE_SLOTID(LoginConnection conn, Character character)
		{
			var characterCount = conn.Account.CharacterCount;

			var packet = new Packet(Op.BC_COMMANDER_CREATE_SLOTID);
			packet.PutByte((byte)characterCount);

			conn.Send(packet);
		}

		/// <summary>
		/// Sends information about newly created character.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="character"></param>
		public static void BC_COMMANDER_CREATE(LoginConnection conn, Character character)
		{
			var packet = new Packet(Op.BC_COMMANDER_CREATE);
			packet.AddAppearanceBarrackPc(character);

			conn.Send(packet);
		}

		/// <summary>
		/// Sends response to team name change request.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="result"></param>
		public static void BC_BARRACKNAME_CHECK_RESULT(LoginConnection conn, TeamNameChangeResult result)
		{
			var response = new Packet(Op.BC_BARRACKNAME_CHECK_RESULT);
			response.PutInt((int)result);
			response.PutString("INPUT_TEAMNAME_EXEC_RESULT", 27);
			//EC -> 9B 7/21
			//13 -> 09 7/21
			//10 00 00 00 -> 0D 00 00 00
			//00 00
			response.PutByte(0x9B);
			response.PutByte(0x13);
			response.PutInt(0x0D);
			response.PutShort(0x00);
			//98 C9 43 00 00 00 00
			//09 A3 40 00 00 00 00
			response.PutByte(0x09); //Was 98
			response.PutByte(0xA3); //Was C9
			response.PutInt(0x40); //Was 43
			response.PutByte(0);
			//30 16 E1 3C 00 00 00 00
			//00 00 00 00 00 00 00 00 
			//F0 2E A6 52
			//00 00 00 00
			//00 00 00 00
			//00 00 00 00
			response.PutByte(0x30);
			response.PutByte(0x16);
			response.PutByte(0xE1);
			response.PutByte(0x3C);
			response.PutEmptyBin(12);
			//30 16 E1 3C 00 00 00 00
			//0F 00 00 00 00 00 00 00
			//F0 2E A6 52 00 00 00 00
			response.PutLong(0x0F);
			response.PutByte(0xF0);
			response.PutByte(0x2E);
			response.PutByte(0xA6);
			response.PutByte(0x52);
			response.PutInt(0);
			//CB 42 EA 48 FF 7F 00 00 00 00 00 00 00 00 00 00
			//CB 42 82 D3 FF 7F 00 00 00 00 00 00 00 00 00 00
			response.PutByte(0xCB);
			response.PutByte(0x42);
			response.PutByte(0x82);
			response.PutByte(0xD3);
			response.PutByte(0xFF);
			response.PutByte(0x7F);
			response.PutEmptyBin(10);
			//20 88 D3 1D 00 00 00 00
			response.PutByte(0x20);
			response.PutByte(0x88);
			response.PutByte(0xD3);
			response.PutByte(0x1D);
			response.PutInt(0);
			//F0 2E A6 52
			//00 00 00 00
			//01 00 00 00 00 00 00 00
			response.PutByte(0xF0);
			response.PutByte(0x2E);
			response.PutByte(0xA6);
			response.PutByte(0x52);
			response.PutInt(0);
			response.PutLong(0);
			//D8 B9 F0 FF 00 00 00 00
			response.PutByte(0xD8);
			response.PutByte(0xB9);
			response.PutByte(0xF0);
			response.PutByte(0xFF);
			response.PutInt(0);
			//2F 32 43 D2
			//FF 7F 00 00
			response.PutByte(0x2F);
			response.PutByte(0x32);
			response.PutByte(0x43);
			response.PutByte(0xD2);
			response.PutByte(0xFF);
			response.PutByte(0x7F);
			response.PutShort(0);
			//C8 9E 73 10
			//00 00 00 00
			//00 00 00 00
			//00 00 00 00
			response.PutByte(0xC8);
			response.PutByte(0x9E);
			response.PutByte(0x73);
			response.PutByte(0x10);
			response.PutEmptyBin(12);
			//FE FF FF FF FF FF FF FF
			response.PutByte(0xFE);
			response.PutByte(0xFF);
			response.PutInt(-1);
			response.PutShort(-1);
			//80 EB B7 40
			//01 00 00 00
			response.PutByte(0x80);
			response.PutByte(0xEB);
			response.PutByte(0xB7);
			response.PutByte(0x40);
			response.PutInt(1);
			//C8 9E 73 10
			//00 00 00 00
			response.PutByte(0xC8);
			response.PutByte(0x9E);
			response.PutByte(0x73);
			response.PutByte(0x10);
			response.PutInt(0);
			//C0 9E 73 10
			//00 00 00 00
			response.PutByte(0xC0);
			response.PutByte(0x9E);
			response.PutByte(0x73);
			response.PutByte(0x10);
			response.PutInt(0);
			//78 FA 13 00
			//00 00 00 00
			response.PutByte(0x78);
			response.PutByte(0xFA);
			response.PutByte(0x13);
			response.PutByte(0x00);
			response.PutInt(0);
			//DF 20 F8 DA
			//FF 7F 00 00
			response.PutByte(0xDF);
			response.PutByte(0x20);
			response.PutByte(0xF8);
			response.PutByte(0xDA);
			response.PutInt(0x7FFF);
			//C0 63 B7 40
			//01 00 00 00
			//C0 63 B7 40
			//01 00 00 00
			for (int i = 0; i < 2; i++)
			{
				response.PutByte(0xC0);
				response.PutByte(0x63);
				response.PutByte(0xB7);
				response.PutByte(0x40);
				response.PutInt(1);
			}
			//00 00 00 00 00 00 00 00
			response.PutLong(0);
			//D0 FB 13 00
			//00 00 00 00
			//01 00 00 00 00 00 00 00
			response.PutByte(0xD0);
			response.PutByte(0xFB);
			response.PutByte(0x13);
			response.PutByte(0x00);
			response.PutInt(0);
			response.PutLong(1);
			//A6 2D 18 40
			//01 00 00 00
			response.PutByte(0xA6);
			response.PutByte(0x2D);
			response.PutByte(0x18);
			response.PutByte(0x40);
			response.PutInt(1);
			//90 0F 2F 11
			//00 00 00 00
			response.PutByte(0x90);
			response.PutByte(0x0F);
			response.PutByte(0x2F);
			response.PutByte(0x11);
			response.PutInt(0);
			//30 34 AF 08 00 00
			response.PutByte(0x30);
			response.PutByte(0x34);
			response.PutByte(0xAF);
			response.PutByte(0x08);
			response.PutShort(0);
			//4D 65 6C 69 61 00 00 00 00 00
			response.PutString(conn.Account.TeamName, 10);
			//A3 D0 42 40
			//01 00 00 00 00 00 00 00
			//01 00 00 00
			response.PutByte(0xA3);
			response.PutByte(0xD0);
			response.PutByte(0x42);
			response.PutByte(0x40);
			response.PutLong(1);
			response.PutInt(1);
			//30 34 AF 08 00 00 00 00
			response.PutByte(0x30);
			response.PutByte(0x34);
			response.PutByte(0xAF);
			response.PutByte(0x08);
			response.PutInt(0);
			//B8 11 2F 11
			//00 00 00 00
			response.PutByte(0xB8);
			response.PutByte(0x11);
			response.PutByte(0x2F);
			response.PutByte(0x11);
			response.PutInt(0);
			//9B BD 45 D2
			//FF 7F 00 00
			response.PutByte(0x9B);
			response.PutByte(0xBD);
			response.PutByte(0x45);
			response.PutByte(0xD2);
			response.PutInt(0x7FFF);
			//FE FF
			//FF FF FF FF
			//FF FF
			response.PutByte(0xFE);
			response.PutByte(0xFF);
			response.PutInt(-1);
			response.PutShort(-1);
			//72 EF 0E 40
			//01 00
			response.PutByte(0x72);
			response.PutByte(0xEF);
			response.PutByte(0x0E);
			response.PutByte(0x40);
			response.PutShort(1);
			//response.PutString(conn.Account.TeamName, 64);

			conn.Send(response);
		}

		/// <summary>
		/// Sends pre-defined message to client.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="msgType"></param>
		public static void BC_MESSAGE(LoginConnection conn, MsgType msgType)
		{
			var packet = new Packet(Op.BC_MESSAGE);
			packet.PutByte((byte)msgType);

			conn.Send(packet);
		}

		/// <summary>
		/// Sends custom message to client.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="msg"></param>
		public static void BC_MESSAGE(LoginConnection conn, string msg)
		{
			var packet = new Packet(Op.BC_MESSAGE);
			packet.PutByte((byte)MsgType.Text);
			packet.PutEmptyBin(40);
			packet.PutString(msg);

			conn.Send(packet);
		}

		/// <summary>
		/// Removes character from barrack.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="index"></param>
		public static void BC_COMMANDER_DESTROY(LoginConnection conn, byte index)
		{
			var packet = new Packet(Op.BC_COMMANDER_DESTROY);
			packet.PutByte(index);

			conn.Send(packet);
		}

		/// <summary>
		/// Sets the character for the barrack
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="id"></param>
		public static void BC_NORMAL_SetBarrackCharacter(LoginConnection conn, Character character)
		{
			var packet = new Packet(Op.BC_NORMAL);
			packet.PutInt(SubOp.Barrack.SetBarrackCharacter);
			packet.PutLong(conn.Account.Id);
			packet.PutLong(conn.Account.Id);
			packet.AddBarrackPc(character);

			conn.Send(packet);
		}

		/// <summary>
		/// Sets the barrack, but not working for some reason.
		/// Use the account property to do this.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="id"></param>
		public static void BC_NORMAL_SetBarrack(LoginConnection conn, int id = 0x0B)
		{
			var packet = new Packet(Op.BC_NORMAL);
			packet.PutInt(SubOp.Barrack.SetBarrack);
			packet.PutLong(conn.Account.Id);
			packet.PutInt(id);
			packet.PutInt(0);
			packet.PutByte(0);
			conn.Send(packet);
		}

		/// <summary>
		/// Moves a character in the barrack.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="index"></param>
		/// <param name="position"></param>
		public static void BC_NORMAL_SetPosition(LoginConnection conn, byte index, Position position)
		{
			var packet = new Packet(Op.BC_NORMAL);
			packet.PutInt(SubOp.Barrack.SetPosition);
			packet.PutLong(conn.Account.Id);
			packet.PutByte(index);
			packet.PutFloat(position.X);
			packet.PutFloat(position.Y);
			packet.PutFloat(position.Z);

			conn.Send(packet);
		}

		/// <summary>
		/// Sends information related to the team to be displayed in the barrack.
		/// </summary>
		/// <param name="conn"></param>
		public static void BC_NORMAL_TeamUI(LoginConnection conn)
		{
			var characters = conn.Account.GetCharacters();

			var packet = new Packet(Op.BC_NORMAL);
			packet.PutInt(SubOp.Barrack.TeamUI);
			packet.PutLong(conn.Account.Id);
			packet.PutShort(0); // Number of additional character slots
			packet.PutInt(0); // Team experience. Displayed under "Team Info"
			packet.PutShort(0); // Sum of characters and pets.

			conn.Send(packet);
		}

		/// <summary>
		/// Sends unknown packet in the barrack.
		/// </summary>
		/// <param name="conn"></param>
		public static void BC_NORMAL_UpdateTeamUI(LoginConnection conn)
		{
			var packet = new Packet(Op.BC_NORMAL);
			packet.PutInt(SubOp.Barrack.Unknown_0C);
			packet.PutLong(conn.Account.Id);
			packet.PutShort(0); // Number of additional character slots
			packet.PutInt(0); // Team experience. Displayed under "Team Info"
			packet.PutShort(conn.Account.CharacterCount); // Sum of characters and pets.

			conn.Send(packet);
		}

		/// <summary>
		/// Sends zone traffic list.
		/// </summary>
		/// <param name="conn"></param>
		public static void BC_NORMAL_ZoneTraffic(LoginConnection conn)
		{
			var characters = conn.Account.GetCharacters();
			var mapAvailableCount = characters.Length;
			var zoneServerCount = 1;
			var zoneMaxPcCount = 100;

			var packet = new Packet(Op.BC_NORMAL);
			packet.PutInt(SubOp.Barrack.ZoneTraffic);

			packet.Zlib(true, zpacket =>
			{
				if (mapAvailableCount == 0)
				{
					zpacket.PutShort(0);
					zpacket.PutInt(100);
				}
				else
				{
					zpacket.PutShort(zoneMaxPcCount);
					zpacket.PutShort(mapAvailableCount);
					for (var i = 0; i < mapAvailableCount; ++i)
					{
						zpacket.PutShort(characters[i].MapId);
						zpacket.PutShort(zoneServerCount);
						for (var zone = 0; zone < zoneServerCount; ++zone)
						{
							zpacket.PutShort(zone);
							zpacket.PutShort(1); // currentPlayersCount
							zpacket.PutShort(zoneMaxPcCount);
						}
					}
				}
			});

			conn.Send(packet);
		}

		/// <summary>
		/// Sends positive response to game start request.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="character"></param>
		/// <param name="ip"></param>
		/// <param name="port"></param>
		public static void BC_START_GAMEOK(LoginConnection conn, Character character, string ip, int port)
		{
			var packet = new Packet(Op.BC_START_GAMEOK);

			packet.PutInt(0); // Zone ID.
			packet.PutInt(IPAddress.Parse(ip).ToInt32());
			packet.PutInt(port);
			packet.PutInt(character.MapId);
			packet.PutByte(1); // Channel ID.
			packet.PutLong(character.Id);
			packet.PutByte(0); // Only connects if 0
			packet.PutByte(1); // Passed to a function if ^ is 0

			conn.Send(packet);
		}

		/// <summary>
		/// Sends social server connection information?
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="ip1"></param>
		/// <param name="port1"></param>
		/// <param name="ip2"></param>
		/// <param name="port2"></param>
		public static void BC_SERVER_ENTRY(LoginConnection conn, string ip1, int port1, string ip2, int port2)
		{
			var packet = new Packet(Op.BC_SERVER_ENTRY);

			packet.PutInt(IPAddress.Parse(ip1).ToInt32());
			packet.PutInt(IPAddress.Parse(ip2).ToInt32());
			packet.PutShort(port1);
			packet.PutShort(port2);

			conn.Send(packet);
		}

		/// <summary>
		/// Updates account's properties on the client.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="account"></param>
		public static void BC_ACCOUNT_PROP(LoginConnection conn, Account account)
		{
			var packet = new Packet(Op.BC_ACCOUNT_PROP);

			packet.PutLong(account.Id);
			packet.AddAccountProperties(account);

			conn.Send(packet);
		}

		/// <summary>
		/// Updates the state of a postbox message.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="messageId"></param>
		/// <param name="state"></param>
		public static void BC_NORMAL_UpdatePostBoxState(LoginConnection conn, long messageId, PostBoxMessageState state)
		{
			var packet = new Packet(Op.BC_NORMAL);
			packet.PutInt(SubOp.Barrack.PostBoxState);
			packet.PutLong(messageId);
			packet.PutByte((byte)state);

			conn.Send(packet);
		}

		/// <summary>
		/// Invokes a lua function.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="str"></param>
		public static void BC_NORMAL_Run(LoginConnection conn, string str)
		{
			var packet = new Packet(Op.BC_NORMAL);
			packet.PutInt(SubOp.Barrack.Run);
			packet.PutLpString(str);

			conn.Send(packet);
		}

		/// <summary>
		/// Sends the session key to the client.
		/// </summary>
		/// <param name="conn"></param>
		public static void BC_NORMAL_SetSessionKey(LoginConnection conn)
		{
			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(SubOp.Barrack.SetSessionKey);
			packet.PutLpString(conn.SessionKey);
			conn.Send(packet);
		}

		/// <summary>
		/// Notifies the client that it has failed the integrity check of its files.
		/// </summary>
		/// <param name="conn"></param>
		public static void BC_NORMAL_ClientIntegrityFailure(LoginConnection conn)
		{
			var packet = new Packet(Op.BC_NORMAL);
			packet.PutInt(SubOp.Barrack.ClientIntegrityFailure);

			conn.Send(packet);
		}

		/// <summary>
		/// Updates the number of purchased character slots.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="count"></param>
		public static void BC_NORMAL_BarrackSlotCount(LoginConnection conn, int count)
		{
			var packet = new Packet(Op.BC_NORMAL);
			packet.PutInt(SubOp.Barrack.BarrackSlotCount);
			packet.PutInt(count);

			conn.Send(packet);
		}

		public static void BC_DISCONNECT_PACKET_LOG_COUNT(LoginConnection conn)
		{
			var packet = new Packet(Op.BC_DISCONNECT_PACKET_LOG_COUNT);
			packet.PutInt(0x1E);
			conn.Send(packet);
		}

		public static void BC_NORMAL_MESSAGE_MAIL(LoginConnection conn)
		{

			var packet = new Packet(Op.BC_NORMAL);
			packet.PutInt(SubOp.Barrack.Message);
			packet.Zlib(true, zpacket =>
			{
				zpacket.PutByte(1);
				zpacket.PutInt(0);
				zpacket.PutInt(1); //Message Count?
				var sender = "GM.";
				var title = "Compensation on for Temporary Maintenance";
				var message = "";
				zpacket.PutLpString(sender);
				zpacket.PutLpString(title);
				zpacket.PutLpString(message);
				zpacket.PutDate(DateTime.Now); // Date Sent?
				zpacket.PutDate(DateTime.Now); // Expiration
				zpacket.PutDate(DateTime.Now);
				zpacket.PutLong(1); // Message Id
				zpacket.PutByte(0);
				zpacket.PutShort(3);
				zpacket.PutShort(0);
				zpacket.PutShort(1);
				zpacket.PutByte(0);
				zpacket.PutInt(0); // Message Item Count
			});

			conn.Send(packet);
		}

		public static void BC_NORMAL_CharacterInfo(LoginConnection conn)
		{
			var characters = conn.Account.GetCharacters().ToList();
			var packet = new Packet(Op.BC_NORMAL);
			packet.PutInt(SubOp.Barrack.CharacterInfo);
			packet.PutLong(conn.Account.Id);
			packet.PutInt(characters.Count);
			foreach(var character in characters)
			{
				packet.PutLong(character.Id);
				packet.PutString(character.Name, 64);
				packet.PutEmptyBin(24);
			}

			conn.Send(packet);
		}

		public static void BC_LAYER_CHANGE_SYSTEM_MESSAGE(LoginConnection conn, int targetLayer, string script = "MoveBarrackLayer{target}")
		{
			var packet = new Packet(Op.BC_LAYER_CHANGE_SYSTEM_MESSAGE);
			packet.PutInt(targetLayer);
			packet.PutString(script, 64);

			conn.Send(packet);
		}
	}
}
