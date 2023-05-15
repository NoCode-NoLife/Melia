using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Melia.Barracks.Database;
using Melia.Barracks.Network.Helpers;
using Melia.Shared.Tos.Const;
using Melia.Shared.Network;
using Melia.Shared.Network.Helpers;
using Melia.Shared.Util;
using Melia.Shared.World;

namespace Melia.Barracks.Network
{
	public static class Send
	{
		/// <summary>
		/// Sends notification that login packet was received.
		/// </summary>
		/// <param name="conn"></param>
		public static void BC_LOGIN_PACKET_RECEIVED(IBarracksConnection conn)
		{
			var packet = new Packet(Op.BC_LOGIN_PACKET_RECEIVED);
			conn.Send(packet);
		}

		/// <summary>
		/// Sends positive response to login attempt.
		/// </summary>
		/// <param name="conn"></param>
		public static void BC_LOGINOK(IBarracksConnection conn)
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
		public static void BC_LOGOUTOK(IBarracksConnection conn)
		{
			var packet = new Packet(Op.BC_LOGOUTOK);
			conn.Send(packet);
		}

		/// <summary>
		/// Sends a list of characters to the client.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="characters"></param>
		public static void BC_SPLIT_COMMANDER_INFO_LIST(IBarracksConnection conn, IEnumerable<Character> characters)
		{
			var characterCount = characters.Count();

			var packet = new Packet(Op.BC_SPLIT_COMMANDER_INFO_LIST);
			packet.PutInt(characterCount);
			packet.PutLong(conn.Account.Id);

			packet.PutByte(0);
			packet.PutByte(characterCount != 0);
			packet.PutByte(1);

			foreach (var character in characters)
				packet.AddBarrackPc(character);

			conn.Send(packet);
		}

		/// <summary>
		/// Sends character list and account information to client.
		/// </summary>
		/// <param name="conn"></param>
		public static void BC_COMMANDER_LIST(IBarracksConnection conn)
		{
			var allCharacters = conn.Account.GetCharacters();
			var layerCharacters = allCharacters.Where(x => x.BarrackLayer == conn.Account.SelectedBarrackLayer);

			var totalCharacterCount = allCharacters.Length;
			var layerCharacterCount = layerCharacters.Count();

			var packet = new Packet(Op.BC_COMMANDER_LIST);

			packet.PutLong(conn.Account.Id);
			packet.PutByte(0);
			packet.PutByte(0); // 1 = 5/4 slots?
			packet.PutString(conn.Account.TeamName, 64);
			packet.AddAccountProperties(conn.Account);

			packet.PutShort(1); // 0 = 15 slots, 1 = 4, 2 = 8, 3+ = 4, only 1 shows correct max values?
			packet.PutInt(11);
			packet.PutShort(layerCharacterCount);
			packet.PutShort(conn.Account.AdditionalSlotCount);
			packet.PutInt(conn.Account.TeamExp);
			packet.PutShort(totalCharacterCount);

			conn.Send(packet);

			if (allCharacters.Length > 0)
				Send.BC_SPLIT_COMMANDER_INFO_LIST(conn, layerCharacters);
		}

		/// <summary>
		/// Sends the new character's index.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="character"></param>
		public static void BC_COMMANDER_CREATE_SLOTID(IBarracksConnection conn, Character character)
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
		public static void BC_COMMANDER_CREATE(IBarracksConnection conn, Character character)
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
		/// <param name="teamName"></param>
		/// <param name="message"></param>
		public static void BC_BARRACKNAME_CHECK_RESULT(IBarracksConnection conn, TeamNameChangeResult result, string teamName, string message)
		{
			var response = new Packet(Op.BC_BARRACKNAME_CHECK_RESULT);

			response.PutInt((int)result);
			response.PutString(message, 256);
			response.PutString(teamName, 64);

			conn.Send(response);
		}

		/// <summary>
		/// Sends response to team name change request.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="result"></param>
		/// <param name="teamName"></param>
		public static void BC_BARRACKNAME_CHANGE(IBarracksConnection conn, TeamNameChangeResult result, string teamName)
		{
			var packet = new Packet(Op.BC_BARRACKNAME_CHANGE);
			packet.PutInt(1);
			packet.PutByte((byte)result);
			packet.PutString(teamName, 64);

			conn.Send(packet);
		}

		/// <summary>
		/// Sends pre-defined message to client.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="msgType"></param>
		public static void BC_MESSAGE(IBarracksConnection conn, MsgType msgType)
			=> BC_MESSAGE(conn, msgType, null);

		/// <summary>
		/// Sends custom message to client.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="msg"></param>
		public static void BC_MESSAGE(IBarracksConnection conn, string msg)
			=> BC_MESSAGE(conn, MsgType.Text, msg);

		/// <summary>
		/// Sends message to client.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="msgType"></param>
		/// <param name="msg"></param>
		public static void BC_MESSAGE(IBarracksConnection conn, MsgType msgType, string msg)
		{
			var packet = new Packet(Op.BC_MESSAGE);
			packet.PutByte((byte)msgType);

			if (msg != null)
			{
				packet.PutEmptyBin(40);
				packet.PutString(msg);
			}

			conn.Send(packet);
		}

		/// <summary>
		/// Removes character from barrack.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="index"></param>
		public static void BC_COMMANDER_DESTROY(IBarracksConnection conn, byte index)
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
		public static void BC_NORMAL_SetBarrackCharacter(IBarracksConnection conn, Character character)
		{
			var packet = new Packet(Op.BC_NORMAL);
			packet.PutInt(NormalOp.Barrack.SetBarrackCharacter);

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
		public static void BC_NORMAL_SetBarrack(IBarracksConnection conn, int id = 0x0B)
		{
			var packet = new Packet(Op.BC_NORMAL);
			packet.PutInt(NormalOp.Barrack.SetBarrack);
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
		public static void BC_NORMAL_SetPosition(IBarracksConnection conn, byte index, Position position)
		{
			var packet = new Packet(Op.BC_NORMAL);
			packet.PutInt(NormalOp.Barrack.SetPosition);
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
		public static void BC_NORMAL_TeamUI(IBarracksConnection conn)
		{
			var characters = conn.Account.GetCharacters();

			var packet = new Packet(Op.BC_NORMAL);
			packet.PutInt(NormalOp.Barrack.TeamUI);
			packet.PutLong(conn.Account.Id);
			packet.PutShort(conn.Account.AdditionalSlotCount);
			packet.PutInt(conn.Account.TeamExp);
			packet.PutShort(conn.Account.CharacterCount);

			conn.Send(packet);
		}

		/// <summary>
		/// Sends zone traffic list.
		/// </summary>
		/// <param name="conn"></param>
		public static void BC_NORMAL_ZoneTraffic(IBarracksConnection conn)
		{
			var characters = conn.Account.GetCharacters();
			var mapIds = characters.Select(a => a.MapId).Distinct();
			var mapCount = mapIds.Count();
			var maxPlayersPerMap = 100;

			var packet = new Packet(Op.BC_NORMAL);
			packet.PutInt(NormalOp.Barrack.ZoneTraffic);

			// The response is a list of maps and the zone servers they
			// are available on, with the maps corresponding to the maps
			// the characters are on. For example, if you have 2 characters,
			// one on map 1021 and one on 5001, you'll get information for
			// those two maps and all zone servers that are hosting that map.

			packet.Zlib(true, zpacket =>
			{
				// [i373239 (2023-05-10)] Might've been added before
				{
					zpacket.PutShort(0);
					zpacket.PutShort(0);
				}

				if (mapCount == 0)
				{
					zpacket.PutShort(0);
					zpacket.PutInt(100);
				}
				else
				{
					zpacket.PutShort(maxPlayersPerMap);
					zpacket.PutShort(mapCount);

					foreach (var mapId in mapIds)
					{
						var availableZoneServers = BarracksServer.Instance.ServerList.GetZoneServers(mapId);

						zpacket.PutShort(mapId);
						zpacket.PutShort(availableZoneServers.Length);

						for (var channelId = 0; channelId < availableZoneServers.Length; ++channelId)
						{
							var zoneServerInfo = availableZoneServers[(int)channelId];

							// The client uses the "channelId" as part of the
							// channel name. For example, id 0 becomes "Ch 1",
							// id 1 becomes "Ch 2", etc. Because of this we
							// can't just send anything here, it needs to be
							// a sequential number starting from 0 to match
							// official behavior.

							zpacket.PutShort((int)channelId);
							zpacket.PutShort(zoneServerInfo.CurrentPlayers);
							zpacket.PutShort(zoneServerInfo.MaxPlayers);
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
		public static void BC_START_GAMEOK(IBarracksConnection conn, Character character, string ip, int port)
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
		public static void BC_SERVER_ENTRY(IBarracksConnection conn, string ip1, int port1, string ip2, int port2)
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
		public static void BC_ACCOUNT_PROP(IBarracksConnection conn, Account account)
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
		public static void BC_NORMAL_UpdatePostBoxState(IBarracksConnection conn, long messageId, PostBoxMessageState state)
		{
			var packet = new Packet(Op.BC_NORMAL);
			packet.PutInt(NormalOp.Barrack.PostBoxState);
			packet.PutLong(messageId);
			packet.PutByte((byte)state);

			conn.Send(packet);
		}

		/// <summary>
		/// Invokes a lua function.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="str"></param>
		public static void BC_NORMAL_Run(IBarracksConnection conn, string str)
		{
			var packet = new Packet(Op.BC_NORMAL);
			packet.PutInt(NormalOp.Barrack.Run);
			packet.PutLpString(str);

			conn.Send(packet);
		}

		/// <summary>
		/// Sends the session key to the client.
		/// </summary>
		/// <param name="conn"></param>
		public static void BC_NORMAL_SetSessionKey(IBarracksConnection conn)
		{
			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(NormalOp.Barrack.SetSessionKey);
			packet.PutLpString(conn.SessionKey);

			conn.Send(packet);
		}

		/// <summary>
		/// Notifies the client that it has failed the integrity check of its files.
		/// </summary>
		/// <param name="conn"></param>
		public static void BC_NORMAL_ClientIntegrityFailure(IBarracksConnection conn)
		{
			var packet = new Packet(Op.BC_NORMAL);
			packet.PutInt(NormalOp.Barrack.ClientIntegrityFailure);

			conn.Send(packet);
		}

		/// <summary>
		/// Updates the number of purchased character slots.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="count"></param>
		public static void BC_NORMAL_BarrackSlotCount(IBarracksConnection conn, int count)
		{
			var packet = new Packet(Op.BC_NORMAL);
			packet.PutInt(NormalOp.Barrack.BarrackSlotCount);
			packet.PutInt(count);

			conn.Send(packet);
		}

		/// <summary>
		/// Unknown purpose, maybe logs packets on disconnect?
		/// </summary>
		/// <param name="conn"></param>
		public static void BC_DISCONNECT_PACKET_LOG_COUNT(IBarracksConnection conn)
		{
			var packet = new Packet(Op.BC_DISCONNECT_PACKET_LOG_COUNT);
			packet.PutInt(0x1E);

			conn.Send(packet);
		}

		/// <summary>
		/// Mailbox
		/// </summary>
		/// <param name="conn"></param>
		public static void BC_NORMAL_MESSAGE_MAIL(IBarracksConnection conn)
		{
			var packet = new Packet(Op.BC_NORMAL);
			packet.PutInt(NormalOp.Barrack.Message);

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

		/// <summary>
		/// Updates the number of purchased character slots.
		/// </summary>
		/// <param name="conn"></param>
		public static void BC_NORMAL_CharacterInfo(IBarracksConnection conn)
		{
			var characters = conn.Account.GetCharacters();

			var packet = new Packet(Op.BC_NORMAL);
			packet.PutInt(NormalOp.Barrack.CharacterInfo);

			packet.PutLong(conn.Account.Id);
			packet.PutInt(characters.Length);
			foreach (var character in characters)
			{
				packet.PutLong(character.Id);
				packet.PutString(character.Name, 64);
				packet.PutEmptyBin(24);
			}

			conn.Send(packet);
		}

		/// <summary>
		/// Updates character barrack layer
		/// </summary>
		/// <param name="conn"></param>
		public static void BC_LAYER_CHANGE_SYSTEM_MESSAGE(IBarracksConnection conn, int targetLayer, string script = "MoveBarrackLayer{target}")
		{
			var packet = new Packet(Op.BC_LAYER_CHANGE_SYSTEM_MESSAGE);
			packet.PutInt(targetLayer);
			packet.PutString(script, 64);

			conn.Send(packet);
		}

		/// <summary>
		/// Updates the number of purchased character slots.
		/// </summary>
		/// <param name="conn"></param>
		public static void BC_RETURN_PC_MARKET_REGISTERED(IBarracksConnection conn, long characterId, bool hasMarketItems = false)
		{
			var packet = new Packet(Op.BC_RETURN_PC_MARKET_REGISTERED);
			packet.PutLong(characterId);
			packet.PutShort(hasMarketItems ? 1 : 0); // Has Items in Registered in Market

			conn.Send(packet);
		}

		/// <summary>
		/// Sends positive response to slot swap request.
		/// </summary>
		/// <param name="conn"></param>
		public static void BC_CHARACTER_SLOT_SWAP_SUCCESS(IBarracksConnection conn)
		{
			var packet = new Packet(Op.BC_CHARACTER_SLOT_SWAP_SUCCESS);
			conn.Send(packet);
		}

		/// <summary>
		/// Sends negative response to slot swap request.
		/// </summary>
		/// <param name="conn"></param>
		public static void BC_CHARACTER_SLOT_SWAP_FAIL(IBarracksConnection conn)
		{
			var packet = new Packet(Op.BC_CHARACTER_SLOT_SWAP_FAIL);
			conn.Send(packet);
		}
	}
}
