// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Channel.World;
using Melia.Shared.Const;
using Melia.Shared.Database;
using Melia.Shared.Network;
using Melia.Shared.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Melia.Channel.Network
{
	public class ChannelPacketHandler : PacketHandler<ChannelConnection>
	{
		public static readonly ChannelPacketHandler Instance = new ChannelPacketHandler();

		/// <summary>
		/// Sent after connecting to channel.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// [B9 0B] [00 00 00 00] [E4 66 00 00] 23 04 00 00 02 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 66 6F 6F 62 61 72 00 00 CC 0C 50 01 CC 0C 23 74 ...
		/// </example>
		[PacketHandler(Op.CZ_CONNECT)]
		public void CZ_CONNECT(ChannelConnection conn, Packet packet)
		{
			var len = packet.GetShort(); // ? 1059
			var unkShort1 = packet.GetShort();
			var sessionId = packet.GetLong();
			var characterId = packet.GetLong();
			var accountName = packet.GetString(); // ?
			var unkByte1 = packet.GetByte();
			var unkShort2 = packet.GetShort(); // 3276
			var unkShort3 = packet.GetShort(); // 336
			var unkShort4 = packet.GetShort(); // 3276
			var unkShort5 = packet.GetShort(); // 8972
			// ...

			// TODO: Check session id or something.

			// Get account
			conn.Account = ChannelServer.Instance.Database.GetAccount(accountName);
			if (conn.Account == null)
			{
				Log.Warning("Stopped attempt to login with invalid account '{0}'. Closing connection.", accountName);
				conn.Close();
				return;
			}

			// Get character
			var character = ChannelServer.Instance.Database.GetCharacter(conn.Account.Id, characterId);
			if (character == null)
			{
				// Don't punish, could be used to auto-ban other people.
				Log.Warning("User '{0}' tried to use a non-existing character, '{1}'. Closing connection.", accountName, characterId);
				conn.Close();
				return;
			}

			character.Connection = conn;
			conn.SelectedCharacter = character;
			conn.LoggedIn = true;

			Send.ZC_CONNECT_OK(conn, character);
		}

		/// <summary>
		/// Sent mid-loading, after pc's enter world.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// [FE 0B] [01 00 00 00] [08 01 00 00] | F3 C0 A9 C2 72 F2
		/// </example>
		[PacketHandler(Op.CZ_GAME_READY)]
		public void CZ_GAME_READY(ChannelConnection conn, Packet packet)
		{
			var character = conn.SelectedCharacter;

			Send.ZC_START_GAME(conn);
			Send.ZC_MYPC_ENTER(conn);
			Send.ZC_QUICK_SLOT_LIST(conn);
			Send.ZC_MOVE_SPEED(character);
			Send.ZC_ITEM_INVENTORY_LIST(character);
			Send.ZC_ITEM_EQUIP_LIST(character);
		}

		/// <summary>
		/// Sent as response to ZC_MOVE_ZONE with a 0 byte.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// [BC 0B] [03 00 00 00] [C4 00 00 00] | FC 11 D0 A5 72 F2
		/// </example>
		[PacketHandler(Op.CZ_MOVE_ZONE_OK)]
		public void CZ_MOVE_ZONE_OK(ChannelConnection conn, Packet packet)
		{
			// Makes the client connect to the given zone server
			//packet = new Packet(Op.ZC_MOVE_ZONE_OK); // Size: 57 (51)
			//   _BYTE gap0[6];
			//   _DWORD dword6;
			//   _DWORD dwordA;
			//   _DWORD dwordE;
			//   _DWORD dword12;
			//   float float16;
			//   float float1A;
			//   _BYTE gap1E[26];
			//   _BYTE byte38;
			//packet.PutInt(0);
			//packet.PutInt(0x0100007F); // 127.0.0.1
			//packet.PutInt(2001); // Port
			//packet.PutInt(2088); // Zone id
			//packet.PutFloat(30); // Camera X angle
			//packet.PutFloat(0); // Camera Y angle
			//packet.PutByte(0);
			//packet.PutByte(0);
			//conn.Send(packet);
		}

		/// <summary>
		/// Sent at the end of the loading screen.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// [59 0C] [02 00 00 00] [65 00 00 00] 02 00 00 00 00 00 00 00 | E7 B1 5E C8 25 CB	
		/// </example>
		[PacketHandler(Op.CZ_CAMPINFO)]
		public void CZ_CAMPINFO(ChannelConnection conn, Packet packet)
		{
			var sessionId = packet.GetLong();

			Send.ZC_CAMPINFO(conn);
		}

		/// <summary>
		/// Sent when chatting publically.
		/// </summary>
		/// <remarks>
		/// Sent together with CZ_CHAT_LOG.
		/// </remarks>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// [1E 0C] [08 00 00 00] [98 01 00 00] 14 00 74 65 73 74 31 32 33 00 |? 32 B8 E6 39
		/// </example>
		[PacketHandler(Op.CZ_CHAT)]
		public void CZ_CHAT(ChannelConnection conn, Packet packet)
		{
			var len = packet.GetShort(); // length of dynamic packet without length from header
			var msg = packet.GetString();

			var character = conn.SelectedCharacter;

			if (!ChannelServer.Instance.GmCommands.Process(conn, character, msg))
				Send.ZC_CHAT(character, msg);
		}

		/// <summary>
		/// Sent when chatting.
		/// </summary>
		/// <remarks>
		/// Sent together with CZ_CHAT.
		/// When whispering only this one is sent?
		/// </remarks>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// [1F 0C] [09 00 00 00] [98 01 00 00] 14 00 74 65 73 74 31 32 33 00 |? 53 82 83 79
		/// </example>
		[PacketHandler(Op.CZ_CHAT_LOG)]
		public void CZ_CHAT_LOG(ChannelConnection conn, Packet packet)
		{
			var len = packet.GetShort();
			var msg = packet.GetString();
		}

		/// <summary>
		/// Sent when choosing Select Character.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// [01 0C] [1F 00 00 00] [12 00 00 00] 00 | 63 D6 14 F1 60
		/// </example>
		[PacketHandler(Op.CZ_MOVE_BARRACK)]
		public void CZ_MOVE_BARRACK(ChannelConnection conn, Packet packet)
		{
			var unkByte = packet.GetByte();

			Log.Info("User '{0}' is leaving for character selection.", conn.Account.Name);

			Send.ZC_MOVE_BARRACK(conn);
		}

		/// <summary>
		/// Sent when choosing Logout.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// [00 0C] [0A 00 00 00] [06 00 00 00] 00 | 63 D6 14 F1 60
		/// </example>
		[PacketHandler(Op.CZ_LOGOUT)]
		public void CZ_LOGOUT(ChannelConnection conn, Packet packet)
		{
			var unkByte = packet.GetByte();

			Log.Info("User '{0}' is logging out.", conn.Account.Name);

			Send.ZC_LOGOUT_OK(conn);
		}

		/// <summary>
		/// Sent when character jumps.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// [0B 0C] [33 4A 00 00] [6E 00 00 00] 00 | 7B 0D 5C 04 70
		/// </example>
		[PacketHandler(Op.CZ_JUMP)]
		public void CZ_JUMP(ChannelConnection conn, Packet packet)
		{
			var unkByte = packet.GetByte();

			var character = conn.SelectedCharacter;

			Send.ZC_JUMP(character);
		}

		/// <summary>
		/// Sent repeatedly while moving.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// [09 0C] [1F 00 00 00] [59 07 00 00] 00 3A E4 9C 42 99 EB 14 43 D2 A4 B4 41 00 00 80 BF 1F 5A 67 33 01 00 00 00 00 00 5D 3C DE 45 | C1 D1 C0 D9 8C C0 0F
		/// </example>
		[PacketHandler(Op.CZ_KEYBOARD_MOVE)]
		public void CZ_KEYBOARD_MOVE(ChannelConnection conn, Packet packet)
		{
			var unkByte = packet.GetByte(); // 0
			var x = packet.GetFloat();
			var y = packet.GetFloat();
			var z = packet.GetFloat();
			var vectorX = packet.GetFloat(); // 0.7071068
			var vectorY = packet.GetFloat(); // 0.7071068
			var unkBin = packet.GetBin(6); // 01 00 00 00 00 00
			var unkFloat = packet.GetFloat(); // 7111.545

			// TODO: Sanity checks.

			Log.Debug("CZ_KEYBOARD_MOVE: {0}; {1}; {2}", x, y, z);

			var character = conn.SelectedCharacter;

			character.X = x;
			character.Y = y;
			character.Z = z;
			character.IsMoving = true;

			// Broadcast
		}

		/// <summary>
		/// Sent repeatedly while moving.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// [0F 0C] [24 00 00 00] [3F 06 00 00] 00 EF C4 79 42 D4 EC 14 43 EF 0A 29 42 F3 04 35 3F F3 04 35 3F 18 46 DE 45 | 7D 34 0C CF 24
		/// </example>
		[PacketHandler(Op.CZ_MOVE_STOP)]
		public void CZ_MOVE_STOP(ChannelConnection conn, Packet packet)
		{
			var unkByte = packet.GetByte(); // 0
			var x = packet.GetFloat();
			var y = packet.GetFloat();
			var z = packet.GetFloat();
			var vectorX = packet.GetFloat(); // 0.7071068
			var vectorY = packet.GetFloat(); // 0.7071068
			var unkFloat = packet.GetFloat(); // 7112.762

			// TODO: Sanity checks.

			Log.Debug("CZ_MOVE_STOP: {0}; {1}; {2}", x, y, z);

			var character = conn.SelectedCharacter;

			character.X = x;
			character.Y = y;
			character.Z = z;
			character.IsMoving = false;

			// Broadcast
		}

		/// <summary>
		/// Sent when trying to sit down.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// [10 0C] [08 00 00 00] [14 00 00 00] | D5 47 39 10 2B 7F
		/// </example>
		[PacketHandler(Op.CZ_REST_SIT)]
		public void CZ_REST_SIT(ChannelConnection conn, Packet packet)
		{
			var character = conn.SelectedCharacter;

			character.IsSitting = !character.IsSitting;

			Send.ZC_REST_SIT(character);
		}

		/// <summary>
		/// Sent when equipping an item.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_ITEM_EQUIP)]
		public void CZ_ITEM_EQUIP(ChannelConnection conn, Packet packet)
		{
			var worldId = packet.GetLong();
			var slot = (EquipSlot)packet.GetByte();

			var character = conn.SelectedCharacter;
			var result = character.Inventory.Equip(slot, worldId);

			if (result == InventoryResult.ItemNotFound)
			{
				Log.Warning("User '{0}' tried to equip item he doesn't have ({1}).", conn.Account.Name, worldId);
				return;
			}

			if (result == InventoryResult.InvalidSlot)
			{
				Log.Warning("User '{0}' tried to equip item in invalid slot ({1}).", conn.Account.Name, worldId);
				return;
			}
		}

		/// <summary>
		/// Sent when uequipping an item.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// [29 0C] [0A 00 00 00] [2E 00 00 00] 11 | A9 D6 37 E5 55
		/// </example>
		[PacketHandler(Op.CZ_ITEM_UNEQUIP)]
		public void CZ_ITEM_UNEQUIP(ChannelConnection conn, Packet packet)
		{
			var slot = (EquipSlot)packet.GetByte();

			var character = conn.SelectedCharacter;
			var result = character.Inventory.Unquip(slot);

			if (result == InventoryResult.ItemNotFound)
			{
				Log.Warning("User '{0}' tried to unequip non-existent item from {1}.", conn.Account.Name, slot);
				return;
			}

			if (result == InventoryResult.InvalidSlot)
			{
				Log.Warning("User '{0}' tried to unequip item from invalid slot ({1}).", conn.Account.Name, slot);
				return;
			}
		}

		/// <summary>
		/// Sent when uequipping an item.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// [22 0C] [4C 00 00 00] [58 00 00 00] 20 00 01 00 00 00  1A 00 00 00 00 00 50 00  01 00 00 00 00 00 50 00
		/// [22 0C] [09 00 00 00] [34 00 00 00] 20 00 01 00 00 00  33 00 00 00 00 00 50 00  01 00 00 00 00 00 50 00
		/// [22 0C] [0A 00 00 00] [30 00 00 00] 20 00 01 00 00 00  34 00 00 00 00 00 50 00  01 00 00 00 00 00 50 00
		/// </example>
		[PacketHandler(Op.CZ_ITEM_DELETE)]
		public void CZ_ITEM_DELETE(ChannelConnection conn, Packet packet)
		{
			var unkShort = packet.GetShort();
			var unkInt = packet.GetInt();
			var worldId = packet.GetLong();
			var unkLong = packet.GetLong();

			var character = conn.SelectedCharacter;
			var result = character.Inventory.Delete(worldId);

			if (result == InventoryResult.ItemNotFound)
			{
				Log.Warning("User '{0}' tried to delete non-existent item ({1}).", conn.Account.Name, worldId);
				return;
			}
		}

		/// <summary>
		/// Sent when dragging an item on top of another one in the same category.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// [E2 0C] [08 00 00 00] [F6 01 00 00] 00 04 00 00 00 00 00 50 00 11 27 00 00 04 00 00 00 00 00 50 00 11 27 00 00 | BA A6 FE 2C 3D
		/// </example>
		[PacketHandler(Op.CZ_SWAP_ETC_INV_CHANGE_INDEX)]
		public void CZ_SWAP_ETC_INV_CHANGE_INDEX(ChannelConnection conn, Packet packet)
		{
			var invType = (InventoryType)packet.GetByte();
			var worldId1 = packet.GetLong();
			var index1 = packet.GetInt();
			var worldId2 = packet.GetLong();
			var index2 = packet.GetInt();

			var character = conn.SelectedCharacter;
			var result = character.Inventory.Swap(worldId1, worldId2);

			if (result == InventoryResult.ItemNotFound)
			{
				Log.Warning("User '{0}' tried to delete non-existent item ({1}, {2}).", conn.Account.Name, worldId1, worldId2);
				return;
			}

			if (result == InventoryResult.InvalidOperation)
			{
				Log.Warning("User '{0}' tried to swap two items from different categories ({1}, {2}).", conn.Account.Name, worldId1, worldId2);
				return;
			}
		}

		/// <summary>
		/// Sent when clicken the Arrange Inventory button.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// [E4 0C] [08 00 00 00] [F8 00 00 00] 00 | 58 EA 0F 1E 8B
		/// </example>
		[PacketHandler(Op.CZ_SORT_INV_CHANGE_INDEX)]
		public void CZ_SORT_INV_CHANGE_INDEX(ChannelConnection conn, Packet packet)
		{
			var unkByte = packet.GetByte();

			var character = conn.SelectedCharacter;

			// TODO: Add cooldown?

			character.Inventory.Sort();
		}

		/// <summary>
		/// Sent when clicken the Arrange Inventory button.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// [12 0C] [06 00 00 00] [18 00 00 00] | 7B 90 AC BC 3B 98
		/// </example>
		[PacketHandler(Op.CZ_ON_AIR)]
		public void CZ_ON_AIR(ChannelConnection conn, Packet packet)
		{
			// TODO: Sanity checks.

			conn.SelectedCharacter.IsGrounded = false;
		}

		/// <summary>
		/// Sent when clicken the Arrange Inventory button.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// [12 0C] [06 00 00 00] [18 00 00 00] | 7B 90 AC BC 3B 98
		/// </example>
		[PacketHandler(Op.CZ_ON_GROUND)]
		public void CZ_ON_GROUND(ChannelConnection conn, Packet packet)
		{
			// TODO: Sanity checks.

			conn.SelectedCharacter.IsGrounded = true;
		}

		/// <summary>
		/// Sent when clicken the Arrange Inventory button.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// [13 0C] [0A 00 00 00] [78 03 00 00] 00 00 80 C3 C3 BC AD 6B 43 00 00 95 C3 | D8
		/// </example>
		[PacketHandler(Op.CZ_MOVEMENT_INFO)]
		public void CZ_MOVEMENT_INFO(ChannelConnection conn, Packet packet)
		{
			var unkByte = packet.GetByte();
			var x = packet.GetFloat();
			var y = packet.GetFloat();
			var z = packet.GetFloat();

			// TODO: Sanity checks.

			Log.Debug("CZ_MOVEMENT_INFO: {0}; {1}; {2}", x, y, z);

			conn.SelectedCharacter.X = x;
			conn.SelectedCharacter.Y = y;
			conn.SelectedCharacter.Z = z;

			// Broadcast?
		}
	}
}
