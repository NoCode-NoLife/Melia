// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Channel.World;
using Melia.Shared.Const;
using Melia.Shared.Data.Database;
using Melia.Shared.Database;
using Melia.Shared.Network;
using Melia.Shared.Util;
using Melia.Shared.World;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
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
		/// ([B9 0B] [00 00 00 00] [E4 66 00 00]) 23 04 00 00 02 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 66 6F 6F 62 61 72 00 00 CC 0C 50 01 CC 0C 23 74 ...
		/// </example>
		[PacketHandler(Op.CZ_CONNECT)]
		public void CZ_CONNECT(ChannelConnection conn, Packet packet)
		{
			var s1 = packet.GetShort();
			var s2 = packet.GetShort();
			var accountId = packet.GetLong();
			var characterId = packet.GetLong();

			// When using passprt login, this is the account id as string,
			// and it's 18 (?) bytes long.
			var accountName = packet.GetString(33); // ?

			var unk = packet.GetBin(1037);
			var sessionKey = packet.GetString(64);

			// TODO: Check session key or something.

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

			// Get map
			var map = ChannelServer.Instance.World.GetMap(character.MapId);
			if (map == null)
			{
				Log.Warning("CZ_GAME_READY: User '{0}' logged on with invalid map '{1}'.", conn.Account.Name, character.MapId);
				conn.Close();
				return;
			}

			character.Connection = conn;
			conn.SelectedCharacter = character;

			map.AddCharacter(character);
			conn.LoggedIn = true;

			Send.ZC_CONNECT_OK(conn, character);
		}

		/// <summary>
		/// Sent mid-loading, after the player entered the world.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// ([FE 0B] [01 00 00 00] [08 01 00 00]) | F3 C0 A9 C2 72 F2
		/// </example>
		[PacketHandler(Op.CZ_GAME_READY)]
		public void CZ_GAME_READY(ChannelConnection conn, Packet packet)
		{
			var character = conn.SelectedCharacter;

			Send.ZC_IES_MODIFY_LIST(conn);
			Send.ZC_ITEM_INVENTORY_LIST(character);
			// ZC_NORMAL
			Send.ZC_OPTION_LIST(conn);
			Send.ZC_SKILLMAP_LIST(character);
			Send.ZC_ACHIEVE_POINT_LIST(character);
			Send.ZC_CHAT_MACRO_LIST(character);
			Send.ZC_NPC_STATE_LIST(character);
			// ZC_HELP_LIST
			// ZC_MYPAGE_MAP
			// ZC_GUESTPAGE_MAP
			Send.ZC_START_INFO(conn);
			Send.ZC_ITEM_EQUIP_LIST(character);
			Send.ZC_SKILL_LIST(character);
			Send.ZC_ABILITY_LIST(character);
			Send.ZC_COOLDOWN_LIST(character);
			Send.ZC_QUICK_SLOT_LIST(conn);
			// ZC_NORMAL...
			Send.ZC_START_GAME(conn);
			Send.ZC_OBJECT_PROPERTY_Init(character);
			Send.ZC_LOGIN_TIME(conn, DateTime.Now);
			Send.ZC_MYPC_ENTER(character);
			// ZC_NORMAL...
			// ZC_OBJECT_PROPERTY...
			// ZC_SKILL_ADD...
			Send.ZC_JOB_PTS(character);
			Send.ZC_MOVE_SPEED(character);

			character.OpenEyes();
		}

		/// <summary>
		/// Sent as response to ZC_MOVE_ZONE with a 0 byte.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// ([BC 0B] [03 00 00 00] [C4 00 00 00]) | FC 11 D0 A5 72 F2
		/// </example>
		[PacketHandler(Op.CZ_MOVE_ZONE_OK)]
		public void CZ_MOVE_ZONE_OK(ChannelConnection conn, Packet packet)
		{
			var character = conn.SelectedCharacter;

			character.FinalizeWarp();
		}

		/// <summary>
		/// Sent at the end of the loading screen.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// ([59 0C] [02 00 00 00] [65 00 00 00]) 02 00 00 00 00 00 00 00 | E7 B1 5E C8 25 CB	
		/// </example>
		[PacketHandler(Op.CZ_CAMPINFO)]
		public void CZ_CAMPINFO(ChannelConnection conn, Packet packet)
		{
			var accountId = packet.GetLong();

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
		/// ([1E 0C] [08 00 00 00] [98 01 00 00]) 14 00 74 65 73 74 31 32 33 00 |? 32 B8 E6 39
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
		/// ([1F 0C] [09 00 00 00] [98 01 00 00]) 14 00 74 65 73 74 31 32 33 00 |? 53 82 83 79
		/// </example>
		[PacketHandler(Op.CZ_CHAT_LOG)]
		public void CZ_CHAT_LOG(ChannelConnection conn, Packet packet)
		{
			var len = packet.GetShort();
			var msg = packet.GetString();
		}

		/// <summary>
		/// Sent when clicking [Select Character].
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// ([01 0C] [1F 00 00 00] [12 00 00 00]) 00 | 63 D6 14 F1 60
		/// </example>
		[PacketHandler(Op.CZ_MOVE_BARRACK)]
		public void CZ_MOVE_BARRACK(ChannelConnection conn, Packet packet)
		{
			var unkByte = packet.GetByte();

			Log.Info("User '{0}' is leaving for character selection.", conn.Account.Name);

			Send.ZC_MOVE_BARRACK(conn);
		}

		/// <summary>
		/// Sent when clicking [Logout].
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// ([00 0C] [0A 00 00 00] [06 00 00 00]) 00 | 63 D6 14 F1 60
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
		/// ([0B 0C] [33 4A 00 00] [6E 00 00 00]) 00 | 7B 0D 5C 04 70
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
		/// ([09 0C] [1F 00 00 00] [59 07 00 00]) 00 3A E4 9C 42 99 EB 14 43 D2 A4 B4 41 00 00 80 BF 1F 5A 67 33 01 00 00 00 00 00 5D 3C DE 45 | C1 D1 C0 D9 8C C0 0F
		/// </example>
		[PacketHandler(Op.CZ_KEYBOARD_MOVE)]
		public void CZ_KEYBOARD_MOVE(ChannelConnection conn, Packet packet)
		{
			var unkByte = packet.GetByte(); // 0
			var x = packet.GetFloat();
			var y = packet.GetFloat();
			var z = packet.GetFloat();
			var dx = packet.GetFloat();
			var dy = packet.GetFloat();
			var unkBin = packet.GetBin(6);
			var unkFloat = packet.GetFloat(); // timestamp?

			var character = conn.SelectedCharacter;

			// TODO: Sanity checks.

			character.Move(x, y, z, dx, dy, unkFloat);
		}

		/// <summary>
		/// Sent when stopping movement.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// ([0F 0C] [24 00 00 00] [3F 06 00 00]) 00 EF C4 79 42 D4 EC 14 43 EF 0A 29 42 F3 04 35 3F F3 04 35 3F 18 46 DE 45 | 7D 34 0C CF 24
		/// </example>
		[PacketHandler(Op.CZ_MOVE_STOP)]
		public void CZ_MOVE_STOP(ChannelConnection conn, Packet packet)
		{
			var unkByte = packet.GetByte();
			var x = packet.GetFloat();
			var y = packet.GetFloat();
			var z = packet.GetFloat();
			var dx = packet.GetFloat();
			var dy = packet.GetFloat();
			var unkFloat = packet.GetFloat(); // timestamp?

			var character = conn.SelectedCharacter;

			// TODO: Sanity checks.

			character.StopMove(x, y, z, dx, dy);

			// In the packets I don't see any indication for a client-side trigger,
			// so I guess the server has to check for warps and initiate it all
			// on its own. Seems a little weird... but oh well.
			// If this is a thing, we probably should have some kind of "trigger"
			// system. -- exec
			var warpNpc = character.Map.GetNearbyWarp(character.Position);
			if (warpNpc != null)
			{
				// Wait 1s to see if the character actually wants to warp
				// (indicated by him not moving). Official behavior unknown,
				// as I have never played the game =<
				var pos = character.Position;
				Task.Delay(1000).ContinueWith(t =>
				{
					// Cancel if character moved in that time
					if (character.Position != pos)
						return;

					//Log.Debug("warp to " + warp.WarpLocation);
					character.Warp(warpNpc.WarpLocation);
				});
			}

			// Could ZC_ENTER_HOOK be a notification to the client that it's
			// in a "trigger area" now?
		}

		/// <summary>
		/// Sent when the character is in the air (jumping/falling).
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// ([12 0C] [06 00 00 00] [18 00 00 00]) | 7B 90 AC BC 3B 98
		/// </example>
		[PacketHandler(Op.CZ_ON_AIR)]
		public void CZ_ON_AIR(ChannelConnection conn, Packet packet)
		{
			// TODO: Sanity checks.

			conn.SelectedCharacter.IsGrounded = false;
		}

		/// <summary>
		/// Sent when landing on the ground, after being in the air.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// ([12 0C] [06 00 00 00] [18 00 00 00]) | 7B 90 AC BC 3B 98
		/// </example>
		[PacketHandler(Op.CZ_ON_GROUND)]
		public void CZ_ON_GROUND(ChannelConnection conn, Packet packet)
		{
			// TODO: Sanity checks.

			conn.SelectedCharacter.IsGrounded = true;
		}

		/// <summary>
		/// Sent repeatedly during jumping.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// ([13 0C] [0A 00 00 00] [78 03 00 00]) 00 00 80 C3 C3 BC AD 6B 43 00 00 95 C3 | D8
		/// </example>
		[PacketHandler(Op.CZ_MOVEMENT_INFO)]
		public void CZ_MOVEMENT_INFO(ChannelConnection conn, Packet packet)
		{
			var unkByte = packet.GetByte();
			var x = packet.GetFloat();
			var y = packet.GetFloat();
			var z = packet.GetFloat();

			// TODO: Sanity checks.

			conn.SelectedCharacter.SetPosition(x, y, z);

			// Is there a broadcast for this?
		}

		/// <summary>
		/// Sent when trying to sit down.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// ([10 0C] [08 00 00 00] [14 00 00 00]) | D5 47 39 10 2B 7F
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
				Log.Warning("CZ_ITEM_EQUIP: User '{0}' tried to equip item he doesn't have ({1}).", conn.Account.Name, worldId);
			else if (result == InventoryResult.InvalidSlot)
				Log.Warning("CZ_ITEM_EQUIP: User '{0}' tried to equip item in invalid slot ({1}).", conn.Account.Name, worldId);
		}

		/// <summary>
		/// Sent when uequipping an item.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// ([29 0C] [0A 00 00 00] [2E 00 00 00]) 11 | A9 D6 37 E5 55
		/// </example>
		[PacketHandler(Op.CZ_ITEM_UNEQUIP)]
		public void CZ_ITEM_UNEQUIP(ChannelConnection conn, Packet packet)
		{
			var slot = (EquipSlot)packet.GetByte();

			var character = conn.SelectedCharacter;
			var result = character.Inventory.Unequip(slot);

			if (result == InventoryResult.ItemNotFound)
				Log.Warning("CZ_ITEM_UNEQUIP: User '{0}' tried to unequip non-existent item from {1}.", conn.Account.Name, slot);
			else if (result == InventoryResult.InvalidSlot)
				Log.Warning("CZ_ITEM_UNEQUIP: User '{0}' tried to unequip item from invalid slot ({1}).", conn.Account.Name, slot);
		}

		/// <summary>
		/// Sent when removing an item from the inventory.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// ([22 0C] [4C 00 00 00] [58 00 00 00]) 20 00 01 00 00 00  1A 00 00 00 00 00 50 00  01 00 00 00 00 00 50 00
		/// ([22 0C] [09 00 00 00] [34 00 00 00]) 20 00 01 00 00 00  33 00 00 00 00 00 50 00  01 00 00 00 00 00 50 00
		/// ([22 0C] [0A 00 00 00] [30 00 00 00]) 20 00 01 00 00 00  34 00 00 00 00 00 50 00  01 00 00 00 00 00 50 00
		/// </example>
		[PacketHandler(Op.CZ_ITEM_DELETE)]
		public void CZ_ITEM_DELETE(ChannelConnection conn, Packet packet)
		{
			var unkShort = packet.GetShort();
			var unkInt = packet.GetInt();
			var worldId = packet.GetLong();
			var unkLong = packet.GetLong();

			var character = conn.SelectedCharacter;
			var result = character.Inventory.Remove(worldId);

			if (result == InventoryResult.ItemNotFound)
				Log.Warning("CZ_ITEM_DELETE: User '{0}' tried to delete non-existent item ({1}).", conn.Account.Name, worldId);
		}

		/// <summary>
		/// Sent when dragging an item on top of another one in the same
		/// category to switch their positions.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// ([E2 0C] [08 00 00 00] [F6 01 00 00]) 00 04 00 00 00 00 00 50 00 11 27 00 00 04 00 00 00 00 00 50 00 11 27 00 00 | BA A6 FE 2C 3D
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
				Log.Warning("CZ_SWAP_ETC_INV_CHANGE_INDEX: User '{0}' tried to swap non-existent item(s) ({1}, {2}).", conn.Account.Name, worldId1, worldId2);
			else if (result == InventoryResult.InvalidOperation)
				Log.Warning("CZ_SWAP_ETC_INV_CHANGE_INDEX: User '{0}' tried to swap two items from different categories ({1}, {2}).", conn.Account.Name, worldId1, worldId2);
		}

		/// <summary>
		/// Sent when clicken the Arrange Inventory button.
		/// </summary>
		/// <remarks>
		/// Named "CZ_SORT_INV_CHANGE_INDEX" (0xCE4) in iCBT1, size 11.
		/// Name changed to "CZ_SORT_INV" in iCBT2 (pre-launch),
		/// one byte added, presumedly for the order.
		/// </remarks>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// ([E4 0C] [08 00 00 00] [F8 00 00 00]) 00 | 58 EA 0F 1E 8B
		/// </example>
		[PacketHandler(Op.CZ_SORT_INV)]
		public void CZ_SORT_INV(ChannelConnection conn, Packet packet)
		{
			var order = InventoryOrder.Id;

			var unkByte = packet.GetByte();

			// [i10622 (2015-10-22)]
			{
				order = (InventoryOrder)packet.GetByte();
			}

			var character = conn.SelectedCharacter;

			// TODO: Add cooldown?

			character.Inventory.Sort(order);
		}

		/// <summary>
		/// Sent on logout to save hotkeys.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// ([CB 0C] [0C 00 00 00] [FD 07 00 00]) 31 00  21 00 00 00  5B C0 30 E0 80 D9 7B 2A 27 83 38 D8 19 01 03 EE 98 51 07 0C 92 10 60 44 76 07 13 32 87 19 99 03 00 2B 60 F3 A0 4C AE E4
		/// ([CB 0C] [0A 00 00 00] [8A 04 00 00]) 31 00  21 00 00 00  5B C0 30 E0 80 39 68 2A 27 43 12 D8 19 01 03 EE 98 51 07 0C 92 10 60 44 76 07 13 32 87 19 99 03 00 9E 2D E1 C7 E1 6E 46
		/// ([CB 0C] [0A 00 00 00] [89 05 00 00]) 31 00  21 00 00 00  5B C0 30 E0 80 39 70 2A 27 C3 4A B0 33 02 06 DC 31 A3 0E 18 24 21 C0 88 EC 0E 26 64 0E 33 32 07 00 6C 53 FB F5 76 21 C1
		/// ([CB 0C] [0A 00 00 00] [53 06 00 00]) 31 00  21 00 00 00  5B C0 30 B8 00 73 F4 54 4E 86 9F 60 37 05 0C 2E 97 8D BA 86 AE 21 C0 88 6C 1B 13 32 87 19 99 03 00 5A 4B F4 1C 0E 39 EC
		/// </example>
		[PacketHandler(Op.CZ_QUICKSLOT_LIST)]
		public void CZ_QUICKSLOT_LIST(ChannelConnection conn, Packet packet)
		{
			// packed?
		}

		/// <summary>
		/// Sent when clicking a pose.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// ([1D 0C] [0F 00 00 00] [92 03 00 00]) 01 00 00 00 00 00 C9 C3 23 14 67 43 00 80 9A C3 01 00 80 3F 01 00 40 | B4 00 D4 DB 42 E4 8E
		/// ([1D 0C] [10 00 00 00] [9D 03 00 00]) 11 00 00 00 00 00 C9 C3 23 14 67 43 00 80 9A C3 01 00 80 3F 01 00 40 | B4 BA 12 97 70 4C 98
		/// ([1D 0C] [11 00 00 00] [C2 03 00 00]) 0F 00 00 00 00 00 C9 C3 23 14 67 43 00 80 9A C3 01 00 80 3F 01 00 40 | B4 E2 CE 60 30 BF F4
		/// </example>
		[PacketHandler(Op.CZ_POSE)]
		public void CZ_POSE(ChannelConnection conn, Packet packet)
		{
			var pose = packet.GetInt();
			var x = packet.GetFloat();
			var y = packet.GetFloat();
			var z = packet.GetFloat();
			var unkByte = packet.GetByte();
			var unkShort = packet.GetShort();

			var character = conn.SelectedCharacter;

			// TODO: Sanity checks.

			Log.Debug("CZ_POSE: {0}; {1}; {2}; {3}", pose, x, y, z);

			Send.ZC_POSE(character, pose);
		}

		/// <summary>
		/// Sent to rotate the character's body. 
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_ROTATE)]
		public void CZ_ROTATE(ChannelConnection conn, Packet packet)
		{
			var d1 = packet.GetFloat();
			var d2 = packet.GetFloat();

			conn.SelectedCharacter.Rotate(d1, d2);
		}

		/// <summary>
		/// Sent to rotate the character's head. 
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_HEAD_ROTATE)]
		public void CZ_HEAD_ROTATE(ChannelConnection conn, Packet packet)
		{
			var d1 = packet.GetFloat();
			var d2 = packet.GetFloat();

			conn.SelectedCharacter.RotateHead(d1, d2);
		}

		/// <summary>
		/// Sent when "clicking" an NPC.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// ([08 0C] [53 00 00 00] [49 00 00 00]) 01 00 0F 00 00 | 65
		/// </example>
		[PacketHandler(Op.CZ_CLICK_TRIGGER)]
		public void CZ_CLICK_TRIGGER(ChannelConnection conn, Packet packet)
		{
			var handle = packet.GetInt();
			var unkByte = packet.GetByte();

			var monster = conn.SelectedCharacter.Map.GetMonster(handle);
			if (monster == null)
			{
				Log.Warning("CZ_CLICK_TRIGGER: User '{0}' tried to talk to unknown monster.", conn.Account.Name);
				return;
			}

			if (string.IsNullOrWhiteSpace(monster.DialogName))
			{
				Log.Warning("CZ_CLICK_TRIGGER: User '{0}' tried to talk to a monster without dialog.", conn.Account.Name);
				return;
			}

			conn.ScriptState.CurrentNpc = monster;

			ChannelServer.Instance.ScriptManager.Call(conn, monster.DialogName);
		}

		/// <summary>
		/// Sent when selecting a dialog option or entering a number into a
		/// number range dialog.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// ([44 0C] [13 00 00 00] [41 00 00 00]) 02 | E8 E0 26 3A 29
		/// </example>
		[PacketHandler(Op.CZ_DIALOG_SELECT)]
		public void CZ_DIALOG_SELECT(ChannelConnection conn, Packet packet)
		{
			var option = packet.GetByte();

			// Check state
			if (conn.ScriptState.CurrentNpc == null)
			{
				Log.Debug("CZ_DIALOG_SELECT: Null NPC.");
				return;
			}

			ChannelServer.Instance.ScriptManager.Resume(conn, option);
		}

		/// <summary>
		/// Sent to continue dialog?
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// ([43 0C] [0B 00 00 00] [45 00 00 00]) 01 00 00 00 | F0 14
		/// </example>
		[PacketHandler(Op.CZ_DIALOG_ACK)]
		public void CZ_DIALOG_ACK(ChannelConnection conn, Packet packet)
		{
			var type = packet.GetInt();

			// Check state
			if (conn.ScriptState.CurrentNpc == null)
			{
				// Don't log, can happen due to key spamming at the end
				// of a dialog.
				//Log.Debug("CZ_DIALOG_ACK: Null NPC.");
				return;
			}

			// The type seems to indicate what the client wants to do,
			// 1 being sent when continuing normally and 0 or -1 when
			// escape is pressed, to cancel the dialog.
			if (type == 1)
			{
				ChannelServer.Instance.ScriptManager.Resume(conn);
			}
			else
			{
				conn.ScriptState.Reset();
				Send.ZC_DIALOG_CLOSE(conn);
			}
		}

		/// <summary>
		/// Sent after entering a string in an input dialog.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// ([45 0C] [0B 00 00 00] [C4 0D 00 00]) 74 68 61 74 27 73 20 72 69 67 68 00 00 00 00 00 04 CF E5 33 05 01 FF 07 00 00 00 00 80 0B D0 2A 00 60 57 2A 00 70 57 2A 20 C8 8B 35 04 00 00 00 20 3C 84 43 07 0A C3 43 A0 B2 49 0F C0 A9 49 0F 08 00 00 00 FC 68 1D 43 00 CA 8B 35 00 60 EF 43 40 3C 84 43 07 0A 53 43 A0 B2 49 0F C0 A9 49 0F 08 00 00 00 00 00 00 00 A0 CA 8B 35 00 00 00 00 60 3C 84 43 07 0A 00 00 A0 B2 49 0F C0 A9 49 0F F0 90 A8 77 0D 4C
		/// </example>
		[PacketHandler(Op.CZ_DIALOG_STRINGINPUT)]
		public void CZ_DIALOG_STRINGINPUT(ChannelConnection conn, Packet packet)
		{
			var input = packet.GetString(16);
			//var unkBin = packet.GetBin(138 - 16 - 10);

			// Check state
			if (conn.ScriptState.CurrentNpc == null)
			{
				Log.Debug("CZ_DIALOG_STRINGINPUT: Null NPC.");
				return;
			}

			ChannelServer.Instance.ScriptManager.Resume(conn, input);
		}

		/// <summary>
		/// Sent when changing an option in the settings.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// ([BD 0C] [08 00 00 00] [E8 00 00 00]) 2B 00 00 00 02 00 00 00 | 3C BE 92 68 C2 09
		/// </example>
		[PacketHandler(Op.CZ_CHANGE_CONFIG)]
		public void CZ_CHANGE_CONFIG(ChannelConnection conn, Packet packet)
		{
			var option = (Option)packet.GetInt();
			var value = packet.GetInt();

			conn.Account.Settings.Set(option, value);
		}

		/// <summary>
		/// ?
		/// </summary>
		/// <remarks>
		/// This packet is spammed near the warp from Siauliai to Kaipeda,
		/// purpose unknown. I guess it expects some kind of response,
		/// more research required.
		/// </remarks>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// ([96 0D] [0D 00 00 00] [B2 00 00 00]) 1C 00 00 00 | D1 E0
		/// </example>
		[PacketHandler(Op.CZ_REVEAL_NPC_STATE)]
		public void CZ_REVEAL_NPC_STATE(ChannelConnection conn, Packet packet)
		{
			var unkInt = packet.GetInt();
		}

		/// <summary>
		/// Sent when attacking enemies.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// ([49 0D] [3C 00 00 00] [1F 0D 00 00] [45 00]) 00 00 00 00 01 00 00 00 65 EB 54 C4 E5 56 A1 43 4E 9B 9A 43 34 D9 4D C4 E5 56 A1 43 B1 BF A8 43 F3 04 35 3F F2 04 35 3F 01 00 00 00 00 00 00 00 00 00 00 00 00 04 00 00 00 | 91 27 2D
		/// </example>
		[PacketHandler(Op.CZ_CLIENT_HIT_LIST)]
		public void CZ_CLIENT_HIT_LIST(ChannelConnection conn, Packet packet)
		{
			var size = packet.GetShort();
			var unkInt = packet.GetInt();
			var count = packet.GetInt(); // ?
			var attackerX = packet.GetFloat();
			var attackerY = packet.GetFloat();
			var attackerZ = packet.GetFloat();
			var targetX = packet.GetFloat();
			var targetY = packet.GetFloat();
			var targetZ = packet.GetFloat();
			var targetDx = packet.GetFloat();
			var targetDy = packet.GetFloat();
			var unkBin = packet.GetBin(13); // 01 00 00 00 00 00 00 00 00 00 00 00 00

			var character = conn.SelectedCharacter;

			for (int i = 0; i < count; ++i)
			{
				var targetHandle = packet.GetInt();

				// Get target
				var target = character.Map.GetMonster(targetHandle);
				if (target == null)
				{
					Log.Warning("User '{0}' attacked invalid target '{1}'.", conn.Account.Name, targetHandle);
					continue;
				}

				target.TakeDamage(target.MaxHp / 4, character);
			}
		}

		/// <summary>
		/// Sent when distributing stat points.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// ([94 0C] [42 01 00 00] [C0 00 00 00] [26 00]) 01 00 05 00 00 00 00 00 00 00 00 00 00 00 01 00 00 00 00 00 00 00 00 00 00 00
		/// </example>
		[PacketHandler(Op.CZ_REQ_NORMAL_TX_NUMARG)]
		public void CZ_REQ_NORMAL_TX_NUMARG(ChannelConnection conn, Packet packet)
		{
			var size = packet.GetShort();
			var txType = (TxType)packet.GetShort();

			var character = conn.SelectedCharacter;

			switch (txType)
			{
				case TxType.Stats:
					var count = packet.GetInt();
					if (count != 5)
						throw new Exception("Unknown CZ_REQ_NORMAL_TX_NUMARG format, expected 5 stats.");

					for (int i = 0; i < count; ++i)
					{
						var stat = packet.GetInt();

						if (stat == 0)
							continue;

						if (character.StatPoints < stat)
						{
							Log.Warning("User '{0}' tried to spent more stat points than he has.", conn.Account.Name);
							break;
						}

						character.UsedStat += stat;

						switch (i)
						{
							case 0: character.Str += stat; break;
							case 1: character.Con += stat; break;
							case 2: character.Int += stat; break;
							case 3: character.Spr += stat; break;
							case 4: character.Dex += stat; break;
						}
					}

					Send.ZC_ADDON_MSG(character, "RESET_STAT_UP");

					// Official doesn't update UsedStat with this packet =<
					Send.ZC_OBJECT_PROPERTY(character,
						ObjectProperty.PC.STR, ObjectProperty.PC.CON, ObjectProperty.PC.INT, ObjectProperty.PC.MNA, ObjectProperty.PC.DEX,
						ObjectProperty.PC.UsedStat
					);

					//Send.ZC_PC_PROP_UPDATE(character, ObjectProperty.PC.STR_STAT, 0);
					//Send.ZC_PC_PROP_UPDATE(character, ObjectProperty.PC.UsedStat, 0);
					break;

				case TxType.Skills:
					// TODO: Handle skill learning
					var jobId = packet.GetInt();
					Send.ZC_CHAT(conn, character, "Skills can't be learned yet.");
					break;

				default:
					Log.Warning("CZ_REQ_NORMAL_TX_NUMARG txType {0} not handled.", txType);
					break;
			}
		}

		/// <summary>
		/// Sent once a minute to check ping?
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_CHECK_PING)]
		public void CZ_CHECK_PING(ChannelConnection conn, Packet packet)
		{
			// No parameters, no response.
		}

		/// <summary>
		/// This packet is used to cast skills in the ground
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// 
		/// </example>
		[PacketHandler(Op.CZ_SKILL_GROUND)]
		public void CZ_SKILL_GROUND(ChannelConnection conn, Packet packet)
		{
			var unk1 = packet.GetByte();
			var skillId = packet.GetInt();
			var unk2 = packet.GetInt();
			var x1 = packet.GetFloat();
			var y1 = packet.GetFloat();
			var z1 = packet.GetFloat();
			var x2 = packet.GetFloat();
			var y2 = packet.GetFloat();
			var z2 = packet.GetFloat();
			var cos = packet.GetFloat();
			var sin = packet.GetFloat();
			var unk3 = packet.GetInt(); // This seems to be "target actorId"
			var unk6 = packet.GetByte();
			var unk7 = packet.GetByte();

			var character = conn.SelectedCharacter;

			// The following code was (currently commented out) is what has been observed from GROUND SKILL packet responses.

			/*
			var packetPosition1 = new Position(x1, y1, z1);
			var packetPosition2 = new Position(x2, y2, z2);
			var skillPosition = new Position(x1, y1, z1 - 20);
			var packetDirection = new Direction(cos, sin);

			var skillDirection = new Direction(0.707f, 0.707f);

			// Player in Attack state (if not already)
			Send.ZC_PC_ATKSTATE(character, true);

			// Update caster's SP 
			short consumedSp = 10;
			Send.ZC_UPDATE_SP(character, consumedSp);

			// Skill is ready to be casted ?
			Send.ZC_SKILL_READY(character, skillId, packetPosition1, packetPosition2);

			// Create skill in client
			Send.ZC_NORMAL_Skill(character, skillId, skillPosition, skillDirection, true);

			// Unkown Normal
			Send.ZC_NORMAL_Unkown_1c(character, skillId, packetPosition1, skillDirection);

			// Set range of effect
			Send.ZC_SKILL_RANGE_FAN(character, skillId, packetPosition1, skillDirection);

			// Broadcast action to all?
			Send.ZC_SKILL_MELEE_GROUND(character, skillId, packetPosition1, packetDirection);
			*/
		}

		/// <summary>
		/// Sent when clicking Confirm in a shop, with items in the "Bought" list.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_ITEM_BUY)]
		public void CZ_ITEM_BUY(ChannelConnection conn, Packet packet)
		{
			var purchases = new Dictionary<int, int>();

			var size = packet.GetShort();
			var count = packet.GetInt();
			for (int i = 0; i < count; ++i)
			{
				var productId = packet.GetInt();
				var amount = packet.GetInt();

				purchases[productId] = amount;
			}

			var character = conn.SelectedCharacter;

			// Check amount
			if (count > 10)
			{
				Log.Warning("CZ_ITEM_BUY: User '{0}' tried buy more than 10 items at once.", conn.Account.Name);
				return;
			}

			// Check open shop
			if (conn.ScriptState.CurrentNpc == null || conn.ScriptState.CurrentShop == null)
			{
				Log.Warning("CZ_ITEM_BUY: User '{0}' tried buy something with no shop open.", conn.Account.Name);
				return;
			}

			// Get shop
			var shopData = ChannelServer.Instance.Data.ShopDb.Find(conn.ScriptState.CurrentShop);
			if (shopData == null)
			{
				Log.Warning("CZ_ITEM_BUY: User '{0}' tried to buy from a shop that is not in the db.", conn.Account.Name);
				return;
			}

			// Prepare items and get cost
			var totalCost = 0;
			var purchaseList = new List<Tuple<ItemData, int>>();
			foreach (var purchase in purchases)
			{
				var productId = purchase.Key;
				var amount = purchase.Value;

				// Get product
				var productData = shopData.GetProduct(productId);
				if (productData == null)
				{
					Log.Warning("CZ_ITEM_BUY: User '{0}' tried to buy product that's not in the shop ({1}, {2}).", conn.Account.Name, shopData.Name, productId);
					return;
				}

				// Get item
				var itemData = ChannelServer.Instance.Data.ItemDb.Find(productData.ItemId);
				if (itemData == null)
				{
					Log.Warning("CZ_ITEM_BUY: User '{0}' tried to buy item that's not in the db ({1}, {2}).", conn.Account.Name, shopData.Name, productData.ItemId);
					return;
				}

				var singlePrice = (int)(itemData.Price * productData.PriceMultiplier);

				totalCost += singlePrice * amount;
				purchaseList.Add(new Tuple<ItemData, int>(itemData, amount));
			}

			// Check and reduce money
			if (character.Inventory.CountItem(ItemId.Silver) < totalCost)
			{
				Log.Warning("CZ_ITEM_BUY: User '{0}' tried to buy items without having enough money.", conn.Account.Name);
				return;
			}

			character.Inventory.Remove(ItemId.Silver, totalCost, InventoryItemRemoveMsg.PaidWith);

			// Give items
			foreach (var purchase in purchaseList)
			{
				var itemData = purchase.Item1;
				var amount = purchase.Item2;

				character.Inventory.Add(itemData.Id, amount, InventoryAddType.Buy);
			}

			// Temporary fix for differences in prices between client and
			// server. Equip prices are being calculated somehow, with their
			// price in the db usually being 0. This msg will reset the shop
			// panel, to display the proper balance after confirming the
			// transaction.
			Send.ZC_ADDON_MSG(character, "FAIL_SHOP_BUY");
		}

		/// <summary>
		/// Sent when clicking Confirm in a shop, with items in the "Sold" list.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_ITEM_SELL)]
		public void CZ_ITEM_SELL(ChannelConnection conn, Packet packet)
		{
			var itemsToSell = new Dictionary<long, int>();

			var size = packet.GetShort();
			var count = packet.GetInt();
			for (int i = 0; i < count; ++i)
			{
				var worldId = packet.GetLong();
				var amount = packet.GetInt();
				var unkInt = packet.GetInt();

				itemsToSell[worldId] = amount;
			}

			var character = conn.SelectedCharacter;

			// Check amount
			if (count > 10)
			{
				Log.Warning("CZ_ITEM_SELL: User '{0}' tried sell more than 10 items at once.", conn.Account.Name);
				return;
			}

			// Remove items and count revenue
			var totalMoney = 0;
			foreach (var itemToSell in itemsToSell)
			{
				var worldId = itemToSell.Key;
				var amount = itemToSell.Value;

				// Get item
				var item = character.Inventory.GetItem(worldId);
				if (item == null)
				{
					Log.Warning("CZ_ITEM_SELL: User '{0}' tried to sell a non-existent item.", conn.Account.Name);
					return;
				}

				// Check amount
				if (item.Amount < amount)
				{
					Log.Warning("CZ_ITEM_SELL: User '{0}' tried to sell more of an item than they own.", conn.Account.Name);
					return;
				}

				// Try to remove item
				if (character.Inventory.Remove(item, amount, InventoryItemRemoveMsg.Sold) == InventoryResult.Success)
					totalMoney += item.Data.SellPrice * amount;
				else
					Log.Warning("CZ_ITEM_SELL: Failed to sell an item from user '{0}' .", conn.Account.Name);
			}

			// Give money
			if (totalMoney > 0)
				character.Inventory.Add(ItemId.Silver, totalMoney, InventoryAddType.Sell);

			// Temporary fix for differences in prices between client and
			// server. Equip prices are being calculated somehow, with their
			// price in the db usually being 0. This msg will reset the shop
			// panel, to display the proper balance after confirming the
			// transaction.
			Send.ZC_ADDON_MSG(character, "FAIL_SHOP_BUY");
		}
	}

	public enum TxType : short
	{
		Stats = 1,
		Skills = 2,
	}
}
