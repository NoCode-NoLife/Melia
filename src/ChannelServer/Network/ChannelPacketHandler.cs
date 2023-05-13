using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Melia.Channel.Scripting;
using Melia.Channel.Skills;
using Melia.Channel.World;
using Melia.Channel.World.Entities;
using Melia.Channel.World.Entities.Components;
using Melia.Shared.Tos.Const;
using Melia.Shared.Data.Database;
using Melia.Shared.Network;
using Melia.Shared.Network.Helpers;
using Melia.Shared.Util;
using Melia.Shared.World;

namespace Melia.Channel.Network
{
	public class ChannelPacketHandler : PacketHandler<ChannelConnection>
	{
		public static readonly ChannelPacketHandler Instance = new ChannelPacketHandler();

		/// <summary>
		/// Sent wrongfully if a channel wasn't available and the client
		/// tries to log in again afterwards.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CB_LOGIN)]
		public void CB_LOGIN(ChannelConnection conn, Packet packet)
		{
			// Close connection, which should then make the client try to
			// connect to login instead.
			conn.Close();
		}

		/// <summary>
		/// Sent after connecting to channel.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_CONNECT)]
		public void CZ_CONNECT(ChannelConnection conn, Packet packet)
		{
			var bin1 = packet.GetBin(1024);
			var sessionKey = packet.GetString(64);

			// When using passprt login, this is the account id as string,
			// and it's 18 (?) bytes long.	
			var accountName = packet.GetString(56);

			var mac = packet.GetString(48);
			var socialId = packet.GetLong();
			var l1 = packet.GetLong();
			var accountId = packet.GetLong();
			var characterId = packet.GetLong();
			var bin2 = packet.GetBin(12);
			var bin3 = packet.GetBin(10);
			var b1 = packet.GetByte(); // [i373230 (2023-05-10)] Might've been added before

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

			Send.ZC_STANCE_CHANGE(character);
			Send.ZC_CONNECT_OK(conn, character);
			Send.ZC_NORMAL_AdventureBook(conn);
			Send.ZC_SET_CHATBALLOON_SKIN(conn);
			Send.ZC_NORMAL_Unknown_1B4(character);
		}

		/// <summary>
		/// Sent mid-loading, after the player entered the world.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_GAME_READY)]
		public void CZ_GAME_READY(ChannelConnection conn, Packet packet)
		{
			var guildId = packet.GetShort();
			var character = conn.SelectedCharacter;

			Send.ZC_IES_MODIFY_LIST(conn);
			Send.ZC_ITEM_INVENTORY_DIVISION_LIST(character);
			Send.ZC_SESSION_OBJECTS(character);
			Send.ZC_OPTION_LIST(conn);
			Send.ZC_SKILLMAP_LIST(character);
			Send.ZC_ACHIEVE_POINT_LIST(character);
			Send.ZC_CHAT_MACRO_LIST(character);
			Send.ZC_MAP_REVEAL_LIST(conn);
			Send.ZC_NPC_STATE_LIST(character);
			Send.ZC_HELP_LIST(character);
			Send.ZC_MYPAGE_MAP(conn);
			Send.ZC_GUESTPAGE_MAP(conn);
			Send.ZC_NORMAL_UpdateSkillUI(character);
			// Official server sends Skintone Object Property around here
			Send.ZC_ITEM_EQUIP_LIST(character);
			Send.ZC_SKILL_LIST(character);
			Send.ZC_ABILITY_LIST(character);
			Send.ZC_COOLDOWN_LIST(character);
			Send.ZC_NORMAL_Unknown_DA(character);
			Send.ZC_NORMAL_Unknown_E4(character);
			Send.ZC_OBJECT_PROPERTY(conn, character);
			character.SendPCEtcProperties(); // Quick Hack to send required packets
			Send.ZC_START_GAME(conn);
			Send.ZC_UPDATE_ALL_STATUS(character);
			Send.ZC_MOVE_SPEED(character);
			Send.ZC_STAMINA(character, character.Stamina);
			Send.ZC_UPDATE_SP(character, character.Sp);
			Send.ZC_LOGIN_TIME(conn, DateTime.Now);
			Send.ZC_MYPC_ENTER(character);
			Send.ZC_NORMAL_Unknown_1B4(character);
			Send.ZC_CASTING_SPEED(character);
			Send.ZC_ANCIENT_CARD_RESET(conn);
			Send.ZC_QUICK_SLOT_LIST(character);
			Send.ZC_NORMAL_Unknown_EF(character);
			Send.ZC_UPDATED_PCAPPEARANCE(character);
			Send.ZC_ADDITIONAL_SKILL_POINT(character);
			Send.ZC_SET_DAYLIGHT_INFO(character);
			Send.ZC_DAYLIGHT_FIXED(character);
			character.OpenEyes();

			//ChannelServer.Instance.ScriptManager.SendClientScripts(conn);
		}

		/// <summary>
		/// Sent as response to ZC_MOVE_ZONE with a 0 byte.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
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
		[PacketHandler(Op.CZ_CAMPINFO)]
		public void CZ_CAMPINFO(ChannelConnection conn, Packet packet)
		{
			var accountId = packet.GetLong();

			//Send.ZC_CAMPINFO(conn);
		}

		/// <summary>
		/// Sent when chatting publically.
		/// </summary>
		/// <remarks>
		/// Sent together with CZ_CHAT_LOG.
		/// </remarks>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_CHAT)]
		public void CZ_CHAT(ChannelConnection conn, Packet packet)
		{
			var len = packet.GetShort(); // length of payload, without garbage
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
		[PacketHandler(Op.CZ_CHAT_LOG)]
		public void CZ_CHAT_LOG(ChannelConnection conn, Packet packet)
		{
			var len = packet.GetShort();
			var msg = packet.GetString();

			// ...
		}

		/// <summary>
		/// Sent when clicking [Select Character].
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_MOVE_BARRACK)]
		public void CZ_MOVE_BARRACK(ChannelConnection conn, Packet packet)
		{
			var unkByte = packet.GetByte();

			Log.Info("User '{0}' is leaving for character selection.", conn.Account.Name);

			Send.ZC_SAVE_INFO(conn);
			Send.ZC_MOVE_BARRACK(conn);
		}

		/// <summary>
		/// Sent when clicking [Logout].
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_LOGOUT)]
		public void CZ_LOGOUT(ChannelConnection conn, Packet packet)
		{
			var unkByte = packet.GetByte();

			Log.Info("User '{0}' is logging out.", conn.Account.Name);

			Send.ZC_SAVE_INFO(conn);
			Send.ZC_LOGOUT_OK(conn);
		}

		/// <summary>
		/// Sent when character jumps.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_JUMP)]
		public void CZ_JUMP(ChannelConnection conn, Packet packet)
		{
			var unkByte1 = packet.GetByte();
			var position = packet.GetPosition();
			var direction = packet.GetDirection();
			var unkFloat = packet.GetFloat(); // timestamp?
			var bin = packet.GetBin(13);
			var unkByte2 = packet.GetByte();

			var character = conn.SelectedCharacter;

			character.Jump(position, direction, unkFloat, unkByte2);
		}

		/// <summary>
		/// Sent repeatedly while moving.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_KEYBOARD_MOVE)]
		public void CZ_KEYBOARD_MOVE(ChannelConnection conn, Packet packet)
		{
			//var unkByte = packet.GetByte(); // [i354444] Removed
			var position = packet.GetPosition();
			var direction = packet.GetDirection();
			var f1 = packet.GetFloat(); // timestamp?
			var bin1 = packet.GetBin(31);

			var character = conn.SelectedCharacter;

			// TODO: Sanity checks.

			character.Move(position, direction, f1);
		}

		/// <summary>
		/// Sent when stopping movement.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_MOVE_STOP)]
		public void CZ_MOVE_STOP(ChannelConnection conn, Packet packet)
		{
			var unkByte = packet.GetByte();
			var position = packet.GetPosition();
			var direction = packet.GetDirection();
			var unkFloat = packet.GetFloat(); // timestamp?

			var character = conn.SelectedCharacter;

			// TODO: Sanity checks.

			character.StopMove(position, direction);

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
		[PacketHandler(Op.CZ_MOVEMENT_INFO)]
		public void CZ_MOVEMENT_INFO(ChannelConnection conn, Packet packet)
		{
			var unkByte = packet.GetByte();
			var position = packet.GetPosition();

			// TODO: Sanity checks.

			conn.SelectedCharacter.SetPosition(position);

			// Is there a broadcast for this?
		}

		/// <summary>
		/// Sent when trying to sit down.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_REST_SIT)]
		public void CZ_REST_SIT(ChannelConnection conn, Packet packet)
		{
			var character = conn.SelectedCharacter;
			character.ToggleSitting();
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
		[PacketHandler(Op.CZ_ITEM_DELETE)]
		public void CZ_ITEM_DELETE(ChannelConnection conn, Packet packet)
		{
			var worldId = packet.GetLong();
			var amount = packet.GetInt();

			var character = conn.SelectedCharacter;
			var item = character.Inventory.GetItem(worldId);

			if (item == null)
			{
				Log.Warning("CZ_ITEM_DELETE: User '{0}' tried to delete non-existent item.", conn.Account.Name);
				return;
			}
			else if (item.IsLocked)
			{
				// The client should stop the player from attempting to do this.
				Log.Warning("CZ_ITEM_DELETE: User '{0}' tried to delete locked item.", conn.Account.Name);
				return;
			}

			var fullStack = (amount >= item.Amount);

			var result = character.Inventory.Remove(item, amount, InventoryItemRemoveMsg.Destroyed);
			if (result != InventoryResult.Success)
			{
				Log.Warning("CZ_ITEM_DELETE: Removing an item for '{0}' failed despite checks.", conn.Account.Name);
				return;
			}

			// Drop item
			if (ChannelServer.Instance.Conf.World.Littering)
			{
				var dropDir = character.Direction;

				if (ChannelServer.Instance.Conf.World.TargetedLittering && character.Variables.Temp.Defined("MouseX"))
				{
					var mouseX = character.Variables.Temp.Get("MouseX", 0f);
					var mouseY = character.Variables.Temp.Get("MouseY", 0f);
					var centerX = character.Variables.Temp.Get("ScreenWidth", 0f) / 2;
					var centerY = character.Variables.Temp.Get("ScreenHeight", 0f) / 2;

					dropDir = new Direction(mouseY - centerY, mouseX - centerX).AddDegreeAngle(-45);
				}

				// If the entire stack was discarded, we can simply drop
				// the item. If only a part of the stack was discarded,
				// we need to create a new stack, with the selected amount.
				// TODO: We might need to copy values and properties from
				//   the original stack to the new stack.
				var dropItem = (fullStack ? item : new Item(item.Id, amount));
				dropItem.SetRePickUpProtection(character);
				dropItem.Drop(character.Map, character.Position, dropDir, 30);
			}
		}

		/// <summary>
		/// Request to save a chat macro.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_CHAT_MACRO)]
		public void CZ_CHAT_MACRO(ChannelConnection conn, Packet packet)
		{
			var index = packet.GetInt();
			var message = packet.GetString(128);
			var pose = packet.GetInt();

			if ((index > 10) || (index < 0))
			{
				Log.Warning("CZ_CHAT_MACRO: User '{0}' tried to save a chat macro for an invalid index ({1}).", conn.Account.Name, index);
				return;
			}

			// The client sends the entire list of chat macros each as a single packet.
			// Empty macros are also sent, but there's no reason to persist them.
			if (string.IsNullOrEmpty(message) && pose == 0)
				return;

			var macro = new ChatMacro(index, message, pose);
			conn.Account.AddChatMacro(macro);
		}

		/// <summary>
		/// Sent when dragging an item on top of another one in the same
		/// category to switch their positions.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
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
		[PacketHandler(Op.CZ_SORT_INV)]
		public void CZ_SORT_INV(ChannelConnection conn, Packet packet)
		{
			var unkByte = packet.GetByte();
			var order = (InventoryOrder)packet.GetByte(); // [i10622 (2015-10-22)] Added

			var character = conn.SelectedCharacter;

			// TODO: Add cooldown?

			character.Inventory.Sort(order);
		}

		/// <summary>
		/// Sent on logout to save hotkeys.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_QUICKSLOT_LIST)]
		public void CZ_QUICKSLOT_LIST(ChannelConnection conn, Packet packet)
		{
			var packetSize = packet.GetShort();
			var compressedSize = packet.GetInt();
			var buffer = packet.GetCompressedBin(compressedSize);

			// The buffer is always 705 bytes long and seems to contain
			// 54 entries of the following format:
			// 
			//  byte b1;
			//  byte type;
			//  int id;
			//  byte bin1[7];
			// 
			// That leaves 3 bytes of unknown value at the end of the buffer.
			// We could parse this and do something with the hotkeys...
			// or we could just throw them into the database for now.
			// Though we presumably need them, to modify them from the
			// server.

			var character = conn.SelectedCharacter;

			var serialized = Convert.ToBase64String(buffer);
			character.Variables.Perm["_QuickSlotList"] = serialized;
		}

		/// <summary>
		/// Sent when clicking a pose.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_POSE)]
		public void CZ_POSE(ChannelConnection conn, Packet packet)
		{
			var pose = packet.GetInt();
			var x = packet.GetFloat();
			var y = packet.GetFloat();
			var z = packet.GetFloat();
			var unkFloat = packet.GetFloat();
			var unkShort = packet.GetShort();
			var unkByte1 = packet.GetByte();
			var unkByte2 = packet.GetByte();

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
			var i1 = packet.GetInt();
			var direction = packet.GetDirection();

			conn.SelectedCharacter.Rotate(direction);
		}

		/// <summary>
		/// Sent to rotate the character's head. 
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_HEAD_ROTATE)]
		public void CZ_HEAD_ROTATE(ChannelConnection conn, Packet packet)
		{
			var i1 = packet.GetInt();
			var direction = packet.GetDirection();

			conn.SelectedCharacter.RotateHead(direction);
		}

		/// <summary>
		/// Sent when the character requests to use an item.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_ITEM_USE)]
		public void CZ_ITEM_USE(ChannelConnection conn, Packet packet)
		{
			var worldId = packet.GetLong();
			var handle = packet.GetInt();

			var character = conn.SelectedCharacter;

			// Get item.
			var item = character.Inventory.GetItem(worldId);
			if (item == null)
			{
				Log.Warning("CZ_ITEM_USE: User '{0}' tried to use a non-existent item.", conn.Account.Name);
				return;
			}

			// Do not allow use of locked items.
			if (item.IsLocked)
			{
				Log.Warning("CZ_ITEM_USE: User '{0}' tried to use a locked item.", conn.Account.Name);
				return;
			}

			// Nothing to do if the item doesn't have a script.
			if (!item.Data.HasScript)
			{
				Log.Warning("CZ_ITEM_USE: User '{0}' tried to use an item without script.", conn.Account.Name);
				return;
			}

			// Try to execute script
			var script = item.Data.Script;
			Log.Debug("Execute: " + script.Function);

			//var result = ChannelServer.Instance.ScriptManager.Call(conn, script.Function, script.StrArg, script.NumArg1, script.NumArg2);

			//if (result.Type == ScriptCallResultType.NotFound)
			//{
			//	Log.Debug("CZ_ITEM_USE: Missing script function: {0}(\"{1}\", {2}, {3})", script.Function, script.StrArg, script.NumArg1, script.NumArg2);
			//	character.ServerMessage("This item hasn't been implemented yet.");
			//}
			//else if (result.Type == ScriptCallResultType.Error)
			//{
			//	Log.Debug("CZ_ITEM_USE: An error occurred. {0}", result.ErrorMessage);
			//	character.ServerMessage("An error occurred.");
			//}

			// Success
			// TODO: Consume items
		}

		/// <summary>
		/// Sent when "clicking" an NPC.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
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

			if (monster.NpcType == NpcType.Monster)
			{
				Log.Warning("CZ_CLICK_TRIGGER: User '{0}' tried to talk to an actual monster.", conn.Account.Name);
				return;
			}

			if (string.IsNullOrWhiteSpace(monster.DialogName))
			{
				Log.Warning("CZ_CLICK_TRIGGER: User '{0}' tried to talk to a monster without dialog.", conn.Account.Name);
				return;
			}

			conn.ScriptState.CurrentNpc = monster;

			// I don't know what this does, or why this was put here,
			// but it makes the client lag for a second before starting
			// the dialog.
			//Send.ZC_SHARED_MSG(conn, 108);

			//ChannelServer.Instance.ScriptManager.CallDialog(conn, monster.DialogName);
		}

		/// <summary>
		/// Sent when selecting a dialog option or entering a number into a
		/// number range dialog.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
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

			//ChannelServer.Instance.ScriptManager.ResumeDialog(conn, option);
		}

		/// <summary>
		/// Sent to continue dialog?
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
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
				//ChannelServer.Instance.ScriptManager.ResumeDialog(conn);
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
		[PacketHandler(Op.CZ_DIALOG_STRINGINPUT)]
		public void CZ_DIALOG_STRINGINPUT(ChannelConnection conn, Packet packet)
		{
			var input = packet.GetString(128);

			// Check state
			if (conn.ScriptState.CurrentNpc == null)
			{
				Log.Debug("CZ_DIALOG_STRINGINPUT: Null NPC.");
				return;
			}

			//ChannelServer.Instance.ScriptManager.ResumeDialog(conn, input);
		}

		/// <summary>
		/// Sent when changing an option in the settings.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_CHANGE_CONFIG)]
		public void CZ_CHANGE_CONFIG(ChannelConnection conn, Packet packet)
		{
			var option = (Option)packet.GetInt();
			var value = packet.GetInt();

			if (!Enum.IsDefined(typeof(Option), option))
			{
				Log.Debug("CZ_CHANGE_CONFIG: Unknown option '{0}'.", option);
				return;
			}

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
		[PacketHandler(Op.CZ_CLIENT_HIT_LIST)]
		public void CZ_CLIENT_HIT_LIST(ChannelConnection conn, Packet packet)
		{
			var size = packet.GetShort();
			var i1 = packet.GetInt();
			var handleCount = packet.GetInt();
			var castPosition = packet.GetPosition();
			var targetPosition = packet.GetPosition();
			var direction = packet.GetDirection();
			var skillId = (SkillId)packet.GetInt();
			var bin1 = packet.GetBin(5); // 01 00 00 00 00 00 00 00 00
			var f1 = packet.GetFloat();

			var handles = new int[handleCount];
			if (handleCount > 0)
			{
				var f2 = packet.GetFloat();

				for (var i = 0; i < handleCount; ++i)
					handles[i] = packet.GetInt();
			}

			var character = conn.SelectedCharacter;

			if (!character.Skills.TryGet(skillId, out var skill))
			{
				Log.Warning("CZ_CLIENT_HIT_LIST: User '{0}' tried to use a skill they don't have ({1}).", conn.Account.Name, skillId);
				return;
			}

			// Should check state of the character
			Send.ZC_OVERHEAT_CHANGED(character, skill);
			Send.ZC_PC_ATKSTATE(character, true);

			if (handleCount == 0)
			{
				switch (skill.Data.UseType)
				{
					case SkillUseType.MELEE_GROUND:
					{
						var handler = ChannelServer.Instance.SkillHandlers.GetGround(skill.Id);
						handler.Handle(skill, character, castPosition, targetPosition);
						break;
					}
					case SkillUseType.FORCE:
					{
						var handler = ChannelServer.Instance.SkillHandlers.GetTargeted(skill.Id);
						handler.Handle(skill, character, null);
						break;
					}
					default:
					{
						Log.Warning("CZ_CLIENT_HIT_LIST: User '{0}' used unknown skill use type '{1}'.", conn.Account.Name, skill.Data.UseType);
						break;
					}
				}
			}
			else
			{
				var targets = new List<ICombatEntity>();
				foreach (var handle in handles)
				{
					var target = character.Map.GetCombatEntity(handle);
					if (target == null || !character.CanAttack(target))
					{
						Log.Warning("CZ_CLIENT_HIT_LIST: User '{0}' attacked invalid target '{1}'.", conn.Account.Name, handle);
						continue;
					}

					targets.Add(target);
				}

				switch (skill.Data.UseType)
				{
					case SkillUseType.MELEE_GROUND:
						var handler = ChannelServer.Instance.SkillHandlers.GetTargetedGround(skill.Id);
						handler.Handle(skill, character, castPosition, targetPosition, targets);
						break;

					default:
						Log.Warning("CZ_CLIENT_HIT_LIST: User '{0}' used unknown skill use type '{1}'.", conn.Account.Name, skill.Data.UseType);
						break;
				}
			}
		}

		/// <summary>
		/// Sent when attacking a target with a skill, incl. the default
		/// magic attack and bows.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_SKILL_TARGET)]
		public void CZ_SKILL_TARGET(ChannelConnection conn, Packet packet)
		{
			var b1 = packet.GetByte();
			var skillId = (SkillId)packet.GetInt();
			var targetHandle = packet.GetInt();

			var character = conn.SelectedCharacter;

			if (!character.Skills.TryGet(skillId, out var skill))
			{
				Log.Warning("CZ_SKILL_TARGET: User '{0}' tried to use a skill they don't have ({1}).", conn.Account.Name, skillId);
				return;
			}

			// TODO: Should the target be checked properly? Is it possible
			//   to use this handler without target? We should document
			//   such things.

			var target = character.Map.GetCombatEntity(targetHandle);
			//if (!character.Map.TryGetCombatEntity(targetHandle, out var target))
			//{
			//	Log.Warning("CZ_SKILL_TARGET: User '{0}' tried to use a skill on a non-existing target.", conn.Account.Name);
			//	return;
			//}

			var handler = ChannelServer.Instance.SkillHandlers.GetTargeted(skill.Id);
			handler.Handle(skill, character, target);
		}

		/// <summary>
		/// Sent when attacking a target with a skill, incl. the default
		/// magic attack and bows.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_SKILL_TARGET_ANI)]
		public void CZ_SKILL_TARGET_ANI(ChannelConnection conn, Packet packet)
		{
			var b1 = packet.GetByte();
			var skillId = (SkillId)packet.GetInt();
			var direction = packet.GetDirection();

			var character = conn.SelectedCharacter;

			// The packet is sent after the attack animation of the default
			// magic attack when there's no target. In this case skillId is
			// 0. It's currently unknown what exactly is supposed to happen
			// in that case, but we probably don't want to execute the skill
			// handler.
			if (skillId == 0)
			{
				return;
			}

			if (!character.Skills.TryGet(skillId, out var skill))
			{
				Log.Warning("CZ_SKILL_TARGET_ANI: User '{0}' tried to use a skill they don't have ({1}).", conn.Account.Name, skillId);
				return;
			}

			var handler = ChannelServer.Instance.SkillHandlers.GetTargeted(skillId);
			handler.Handle(skill, character, null);
		}

		/// <summary>
		/// This packet is used to cast skills in the ground.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_SKILL_GROUND)]
		public void CZ_SKILL_GROUND(ChannelConnection conn, Packet packet)
		{
			var unk1 = packet.GetByte();
			var skillId = (SkillId)packet.GetInt();
			var targetHandle = packet.GetInt();
			var castPosition = packet.GetPosition();
			var targetPosition = packet.GetPosition();
			var direction = packet.GetDirection();
			var handle = packet.GetInt(); // This seems to be "target actorId"
			var unk6 = packet.GetByte();
			var unk7 = packet.GetByte();

			var character = conn.SelectedCharacter;

			if (!character.Skills.TryGet(skillId, out var skill))
			{
				Log.Warning("CZ_SKILL_GROUND: User '{0}' tried to use a skill they don't have ({1}).", conn.Account.Name, skillId);
				return;
			}

			var handler = ChannelServer.Instance.SkillHandlers.GetGround(skill.Id);
			handler.Handle(skill, character, castPosition, targetPosition);

			// The following code is what has been observed from GROUND SKILL
			// packet responses.

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
		/// Sent when character starts casting a hold to cast skill
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_DYNAMIC_CASTING_START)]
		public void CZ_DYNAMIC_CASTING_START(ChannelConnection conn, Packet packet)
		{
			var skillId = packet.GetInt();
			var f1 = packet.GetFloat();

			var character = conn.SelectedCharacter;

			//character.ServerMessage("Skill attacks haven't been implemented yet.");
		}

		/// <summary>
		/// Sent when character casting ends after holding to cast skill
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_DYNAMIC_CASTING_END)]
		public void CZ_DYNAMIC_CASTING_END(ChannelConnection conn, Packet packet)
		{
			var skillId = packet.GetInt();
			var f1 = packet.GetFloat(); // Max Cast Hold Time?

			var character = conn.SelectedCharacter;
		}

		/// <summary>
		/// Sent when character is using the ground position selection tool starts
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_SELECT_GROUND_POS_START)]
		public void CZ_SELECT_GROUND_POS_START(ChannelConnection conn, Packet packet)
		{
			var character = conn.SelectedCharacter;

			// TODO: keep track of state?
		}

		/// <summary>
		/// Sent when character is using the ground position selection tool ends
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_SELECT_GROUND_POS_END)]
		public void CZ_SELECT_GROUND_POS_END(ChannelConnection conn, Packet packet)
		{
			var character = conn.SelectedCharacter;

			// TODO: keep track of state?
		}

		/// <summary>
		/// Sent when character is using the ground position selection tool ends
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_SKILL_TOOL_GROUND_POS)]
		public void CZ_SKILL_TOOL_GROUND_POS(ChannelConnection conn, Packet packet)
		{
			var position = packet.GetPosition();
			var skillId = packet.GetInt();

			var character = conn.SelectedCharacter;

			// TODO: keep track of state?
		}

		/// <summary>
		/// Sent when distributing stat points.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_REQ_NORMAL_TX_NUMARG)]
		public void CZ_REQ_NORMAL_TX_NUMARG(ChannelConnection conn, Packet packet)
		{
			var size = packet.GetShort();
			var txType = (TxType)packet.GetShort();
			var count = packet.GetInt();

			var character = conn.SelectedCharacter;

			if (txType == TxType.StatUp)
			{
				if (count != 5)
				{
					Log.Warning("CZ_REQ_NORMAL_TX_NUMARG: User '{0}' sent an unexpected number of stat changes ({1}).", conn.Account.Name, count);
					return;
				}

				for (var i = 0; i < count; ++i)
				{
					var stat = packet.GetInt();
					if (stat <= 0)
						continue;

					if (character.Properties.GetFloat(PropertyId.PC.StatPoint) < stat)
					{
						Log.Warning("CZ_REQ_NORMAL_TX_NUMARG: User '{0}' tried to spent more stat points than they have.", conn.Account.Name);
						break;
					}

					//characterProperties.UsedStat += stat;
					character.Properties.Modify(PropertyId.PC.UsedStat, stat);

					switch (i)
					{
						case 0: character.Properties.Modify(PropertyId.PC.STR_STAT, stat); break;
						case 1: character.Properties.Modify(PropertyId.PC.CON_STAT, stat); break;
						case 2: character.Properties.Modify(PropertyId.PC.INT_STAT, stat); break;
						case 3: character.Properties.Modify(PropertyId.PC.MNA_STAT, stat); break;
						case 4: character.Properties.Modify(PropertyId.PC.DEX_STAT, stat); break;
					}
				}

				Send.ZC_ADDON_MSG(character, AddonMessage.RESET_STAT_UP);

				// Official doesn't update UsedStat with this packet,
				// but presumably the PROP_UPDATE below. Why send more
				// packets than necessary though?
				Send.ZC_OBJECT_PROPERTY(character,
					PropertyId.PC.STR, PropertyId.PC.STR_STAT, PropertyId.PC.CON, PropertyId.PC.CON_STAT, PropertyId.PC.INT,
					PropertyId.PC.INT_STAT, PropertyId.PC.MNA, PropertyId.PC.MNA_STAT, PropertyId.PC.DEX, PropertyId.PC.DEX_STAT,
					PropertyId.PC.UsedStat, PropertyId.PC.MINPATK, PropertyId.PC.MAXPATK, PropertyId.PC.MINMATK,
					PropertyId.PC.MAXMATK, PropertyId.PC.MINPATK_SUB, PropertyId.PC.MAXPATK_SUB, PropertyId.PC.CRTATK,
					PropertyId.PC.HR, PropertyId.PC.DR, PropertyId.PC.BLK_BREAK, PropertyId.PC.RHP, PropertyId.PC.RSP,
					PropertyId.PC.MHP, PropertyId.PC.MSP
				);

				//Send.ZC_PC_PROP_UPDATE(character, ObjectProperty.PC.STR_STAT, 0);
				//Send.ZC_PC_PROP_UPDATE(character, ObjectProperty.PC.UsedStat, 0);
			}
			else if (txType == TxType.SkillUp)
			{
				var jobId = (JobId)packet.GetInt();

				// Check job
				var job = character.Jobs.Get(jobId);
				if (job == null)
				{
					Log.Warning("CZ_REQ_NORMAL_TX_NUMARG: User '{0}' tried to learn skills of a job they don't have.", conn.Account.Name);
					return;
				}

				// Check skill data
				// The clients sends the number of points to add to every
				// skill, incl. the skills the player shouldn't be able to
				// put points into yet, so we need to use the job's MaxLevel
				// for getting all available skills.
				var skillTreeData = ChannelServer.Instance.Data.SkillTreeDb.FindSkills(job.Id, job.MaxLevel);
				if (count - 1 != skillTreeData.Length)
				{
					Log.Warning("CZ_REQ_NORMAL_TX_NUMARG: User '{0}' sent an unexpected number of skill level changes ({1}).", conn.Account.Name, count);
					return;
				}

				// The count-1 is the number of skills available to the
				// given job. Similar to the stats no ids are sent,
				// just the number of levels to raise the skill at the
				// given index.
				for (var i = 0; i < count - 1; ++i)
				{
					var add = packet.GetInt();
					if (add <= 0)
						continue;

					// Check skill points
					if (job.SkillPoints < add)
					{
						Log.Warning("CZ_REQ_NORMAL_TX_NUMARG: User '{0}' tried to use more skill points than they have.", conn.Account.Name);
						break;
					}

					var data = skillTreeData[i];
					var skillId = data.SkillId;

					// Check max level
					var maxLevel = character.Skills.GetMaxLevel(skillId);
					var currentLevel = character.Skills.GetLevel(skillId);
					var newLevel = (currentLevel + add);

					if (newLevel > maxLevel)
					{
						// Don't warn about this, since the client doesn't
						// check the max level for skill's with unlock levels.
						// The player can try, but nothing should happen.
						//Log.Warning("CZ_REQ_NORMAL_TX_NUMARG: User '{0}' tried to level '{1}' past the max level ({2} > {3}).", conn.Account.Name, skillId, newLevel, maxLevel);
						continue;
					}

					// Create skill or update its level
					var skill = character.Skills.Get(skillId);
					if (skill == null)
					{
						skill = new Skill(character, skillId, newLevel);
						character.Skills.Add(skill);
					}
					else
					{
						skill.Level = newLevel;
						Send.ZC_OBJECT_PROPERTY(conn, skill);
					}

					job.SkillPoints -= add;
				}

				Send.ZC_ADDON_MSG(character, AddonMessage.RESET_SKL_UP);
				Send.ZC_JOB_PTS(character, job);
				//Send.ZC_ADDITIONAL_SKILL_POINT(character, job);
			}
			else
			{
				Log.Warning("CZ_REQ_NORMAL_TX_NUMARG: txType {0} not handled.", txType);
			}
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
			for (var i = 0; i < count; ++i)
			{
				var productId = packet.GetInt();
				var amount = packet.GetInt();

				purchases[productId] = amount;
			}

			var character = conn.SelectedCharacter;

			// Check amount
			if (count > 10)
			{
				Log.Warning("CZ_ITEM_BUY: User '{0}' tried to buy more than 10 items at once.", conn.Account.Name);
				return;
			}

			// Check open shop
			if (conn.ScriptState.CurrentNpc == null || conn.ScriptState.CurrentShop == null)
			{
				Log.Warning("CZ_ITEM_BUY: User '{0}' tried to buy something with no shop open.", conn.Account.Name);
				return;
			}

			// Get shop
			var shopData = conn.ScriptState.CurrentShop;
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

				if (!shopData.IsCustom)
				{
					var singlePrice = (int)(itemData.Price * productData.PriceMultiplier);
					totalCost += singlePrice * amount;
				}
				else
				{
					totalCost += (int)productData.PriceMultiplier * productData.Amount;
				}

				purchaseList.Add(new Tuple<ItemData, int>(itemData, amount));
			}

			// Check and reduce money
			if (character.Inventory.CountItem(ItemId.Silver) < totalCost)
			{
				Log.Warning("CZ_ITEM_BUY: User '{0}' tried to buy items without having enough money.", conn.Account.Name);
				return;
			}

			character.Inventory.Remove(ItemId.Silver, totalCost, InventoryItemRemoveMsg.Given);

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
			// 08-29-21 Update, Item Database is updated but equipment for the most part are still priced at 0
			Send.ZC_ADDON_MSG(character, AddonMessage.FAIL_SHOP_BUY);
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
			for (var i = 0; i < count; ++i)
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
			var itemsSold = new List<Item>();
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
				{
					totalMoney += item.Data.SellPrice * amount;
					itemsSold.Add(item);
				}
				else
					Log.Warning("CZ_ITEM_SELL: Failed to sell an item from user '{0}' .", conn.Account.Name);
			}

			// Give money
			if (totalMoney > 0)
				character.Inventory.Add(ItemId.Silver, totalMoney, InventoryAddType.Sell);


			// Need to keep track of items sold, server sends this list to the client
			Send.ZC_SOLD_ITEM_DIVISION_LIST(character, 3, itemsSold);
		}

		/// <summary>
		/// Information sent to be saved?
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_SAVE_INFO)]
		public void CZ_SAVE_INFO(ChannelConnection conn, Packet packet)
		{
			// TODO: Research what information needs to be saved here and implement it.
		}

		/// <summary>
		/// Sent when attempting to logout or switch characters.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_RUN_GAMEEXIT_TIMER)]
		public void CZ_RUN_GAMEEXIT_TIMER(ChannelConnection conn, Packet packet)
		{
			var destination = packet.GetString();

			switch (destination)
			{
				case "Logout":
				case "Barrack":
				case "Exit":
					//Send.ZC_ADDON_MSG(conn.SelectedCharacter, AddonMessage.EXPIREDITEM_ALERT_OPEN, destination);

					// What we sent here caused the client to send this
					// packet in an infinite loop in i218535. The following
					// seems to be correct for now.

					Send.ZC_ADDON_MSG(conn.SelectedCharacter, "GAMEEXIT_TIMER_END", "None");
					break;
				default:
					Log.Warning("CZ_RUN_GAMEEXIT_TIMER: User '{0}' tried to transfer to '{1}' which is an unknown state.", conn.Account.Name, destination);
					return;
			}

			Log.Info("User '{0}' is transferring to '{1}' state.", conn.Account.Name, destination);
		}

		/// <summary>
		/// Contains newly uncovered areas of a map.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_MAP_REVEAL_INFO)]
		public void CZ_MAP_REVEAL_INFO(ChannelConnection conn, Packet packet)
		{
			var mapId = packet.GetInt();
			var visible = packet.GetBin(128);

			// Check if the map exists
			var mapData = ChannelServer.Instance.Data.MapDb.Find(mapId);
			if (mapData == null)
			{
				Log.Warning("CZ_MAP_REVEAL_INFO: User '{0}' tried to send an update for map '{1}', which doesn't exist.", conn.Account.Name, mapId);
				return;
			}

			// Check if character is actually on the map
			// The existence check prevents flooding, and this one ensures
			// players can only reveal maps they are actually on.
			// Eventually we might want to improve this further,
			// checking the character's position.
			if (conn.SelectedCharacter.MapId != mapId)
			{
				Log.Warning("CZ_MAP_REVEAL_INFO: User '{0}' tried to send an update for a different map than they're on.", conn.Account.Name);
				return;
			}

			var revealedMap = new RevealedMap(mapId, visible, 0);
			conn.Account.AddRevealedMap(revealedMap);
		}

		/// <summary>
		/// Reports to the server a percentage of the map that has been explored.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_MAP_SEARCH_INFO)]
		public void CZ_MAP_SEARCH_INFO(ChannelConnection conn, Packet packet)
		{
			var map = packet.GetString(41);
			var percentage = packet.GetFloat();

			var mapData = ChannelServer.Instance.Data.MapDb.Find(map);
			if (mapData == null)
			{
				Log.Warning("CZ_MAP_SEARCH_INFO: User '{0}' tried to update the map '{1}' which doesn't exist.", conn.Account.Name, map);
				return;
			}

			if (percentage < 0 || percentage > 100)
			{
				Log.Warning("CZ_MAP_SEARCH_INFO: User '{0}' tried to update the visibility for map '{1}' beyond an acceptable percentage.", conn.Account.Name, map);
				return;
			}

			// Originally null was passed as "explored", but then the server
			// would try to save the null to the database if the map data
			// didn't exist yet.

			var revealedMap = new RevealedMap(mapData.Id, new byte[0], percentage);
			conn.Account.AddRevealedMap(revealedMap);
		}

		/// <summary>
		/// Indicates a request from the client to trade with another character.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_EXCHANGE_REQUEST)]
		public void CZ_EXCHANGE_REQUEST(ChannelConnection conn, Packet packet)
		{
			var targetHandle = packet.GetInt();
		}

		/// <summary>
		/// Specifies various commands found in 'customcommand.ies'.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_CUSTOM_COMMAND)]
		public void CZ_CUSTOM_COMMAND(ChannelConnection conn, Packet packet)
		{
			var commandId = packet.GetInt();
			var classId = packet.GetInt();
			var cmdArg = packet.GetInt();
			var i1 = packet.GetInt();

			// The command id references an entry in the custom command db,
			// which we can use to get the class name of the command, giving
			// us more information about what it does. The data also comes
			// with script function names, though it will be easier to
			// handle these here for now.

			if (!ChannelServer.Instance.Data.CustomCommandDb.TryFind(commandId, out var commandData))
			{
				Log.Warning("CZ_CUSTOM_COMMAND: User '{0}' sent an unknown command id ({1}).", conn.Account.Name, commandId);
				return;
			}

			switch (commandData.Name)
			{
				case "HAT_VISIBLE_STATE":
				{
					// classId = 0~2 (hats 1~3)
					goto default;
				}

				default:
				{
					Log.Debug("CZ_CUSTOM_COMMAND: Unhandled command '{0}', {1}({2}, {3}, {4}).", commandData.Name, commandData.Script, classId, cmdArg, i1);
					break;
				}

				// At some point, this was the command "JANSORI_COUNT",
				// but it doesn't seem to exist anymore.
				//case 0x0C:
				//{
				//	// Disable "You can buy items" tooltip, sent after
				//	// opening a shop.
				//	if (classId == 5 && cmdArg == 1)
				//	{
				//		// The property is on the session object "Jansori".
				//		var jansori = conn.SelectedCharacter.SessionObjects.Get(SessionObjectId.Jansori);
				//		jansori.Properties.Set(PropertyId.SessionObject.Shop_Able_Clicked, 1);
				//		Send.ZC_OBJECT_PROPERTY(conn, jansori, PropertyId.SessionObject.Shop_Able_Clicked);
				//		break;
				//	}
				//	goto default;
				//}

				// I don't know why we were ever referencing 0x71, because
				// there never was a command with that id.
				//case 0x71:
				//{
				//	Send.ZC_CUSTOM_COMMANDER_INFO(conn);
				//	break;
				//}
			}
		}

		/// <summary>
		/// Sent after a loading screen is completed.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_LOAD_COMPLETE)]
		public void CZ_LOAD_COMPLETE(ChannelConnection conn, Packet packet)
		{
			Send.ZC_LOAD_COMPLETE(conn);
		}

		/// <summary>
		/// Sent when (un)locking an item.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_INV_ITEM_LOCK)]
		public void CZ_INV_ITEM_LOCK(ChannelConnection conn, Packet packet)
		{
			var worldId = packet.GetLong();
			var lockItem = packet.GetBool();

			var character = conn.SelectedCharacter;
			var item = character.Inventory.GetItem(worldId);
			if (item == null)
			{
				Log.Warning("CZ_INV_ITEM_LOCK: User '{0}' tried to lock non-existent item.", conn.Account.Name);
				return;
			}

			item.IsLocked = lockItem;

			// Officials send the dict key as the item name, we might want
			// to add those to the item data.
			// <Item> item locked.
			// <Item> item unlocked.
			Send.ZC_SYSTEM_MSG(character, lockItem ? 4138 : 4139, new MsgParameter("Item", item.Data.Name));
		}

		/// <summary>
		/// Sent upon login. (Dummy handler)
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_FIXED_NOTICE_SHOW)]
		public void CZ_FIXED_NOTICE_SHOW(ChannelConnection conn, Packet packet)
		{
			// No parameters
		}

		/// <summary>
		/// Sent upon logout. Presumably cancels "dungeon matching"?
		/// (Dummy handler)
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_CANCEL_INDUN_MATCHING)]
		public void CZ_CANCEL_INDUN_MATCHING(ChannelConnection conn, Packet packet)
		{
			// No parameters
		}

		/// <summary>
		/// Sent upon logout. Presumably cancels "dungeon registration"?
		/// (Dummy handler)
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_CLEAR_INDUN_REG)]
		public void CZ_CLEAR_INDUN_REG(ChannelConnection conn, Packet packet)
		{
			// No parameters
		}

		/// <summary>
		/// Attempts to sync the character position with the server and other entities on the map.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_SYNC_POS)]
		public void CZ_SYNC_POS(ChannelConnection conn, Packet packet)
		{
			var handle = packet.GetInt();
			var position = packet.GetPosition();

			// Sanity checks...
			// Sync position for the character with the handle? ...
		}

		/// <summary>
		/// Sent upon login. (Dummy handler)
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_REQ_ADVENTURE_BOOK_RANK)]
		public void CZ_REQ_ADVENTURE_BOOK_RANK(ChannelConnection conn, Packet packet)
		{
			var str = packet.GetString(128);
			var i1 = packet.GetInt();

			// TODO: Send.ZC_ADVENTURE_BOOK_INFO
		}

		/// <summary>
		/// Presumably multiple functions, one of them being toggling
		/// ability states.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_REQ_NORMAL_TX)]
		public void CZ_REQ_NORMAL_TX(ChannelConnection conn, Packet packet)
		{
			var type = packet.GetShort();

			var character = conn.SelectedCharacter;

			switch (type)
			{
				// Toggle ability state
				case 0x0D:
				{
					var className = packet.GetString(33);
					if (!character.Abilities.Toggle(className))
						Log.Warning("CZ_REQ_NORMAL_TX: User '{0}' tried to toggle ability '{1}', which they either don't have or is passive.", conn.Account.Name, className);
					break;
				}
				default:
				{
					Log.Debug("CZ_REQ_NORMAL_TX: Unhandled type '{0}'.", type);
					break;
				}
			}
		}

		/// <summary>
		/// ? (Dummy)
		/// </summary>
		/// <remarks>
		/// The client sends this packet repeatedly until it gets an
		/// appropriate response.
		/// </remarks>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_REQUEST_GUILD_INDEX)]
		public void CZ_REQUEST_GUILD_INDEX(ChannelConnection conn, Packet packet)
		{
			var l1 = packet.GetLong();
			var guildId = (ushort)packet.GetShort();

			var character = conn.SelectedCharacter;

			// ...

			Send.ZC_RESPONSE_GUILD_INDEX(character);
		}

		/// <summary>
		/// Sent during login after an unexpected disconnect.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_DISCONNECT_REASON_FOR_LOG)]
		public void CZ_DISCONNECT_REASON_FOR_LOG(ChannelConnection conn, Packet packet)
		{
			var size = packet.GetShort();
			var valueCount = packet.GetInt();
			var i2 = packet.GetInt();
			var i3 = packet.GetInt();

			Log.Debug("CZ_DISCONNECT_REASON_FOR_LOG:");

			for (var i = 0; i < valueCount; ++i)
			{
				var name = packet.GetLpString();
				var value = packet.GetLpString();

				Log.Debug("  {0}: {1}", name, value);
			}
		}

		/// <summary>
		/// Sent regularly from the client (every 10 seconds).
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_HEARTBEAT)]
		public void CZ_HEARTBEAT(ChannelConnection conn, Packet packet)
		{
			var secondsSinceStart = packet.GetFloat();
		}

		/// <summary>
		/// Sent when dashing.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_DASHRUN)]
		public void CZ_DASHRUN(ChannelConnection conn, Packet packet)
		{
			var b1 = packet.GetByte();
			var b2 = packet.GetByte(); // 1 = run, 0 = ?

			var character = conn.SelectedCharacter;
			if (character == null)
				return;

			// For some reason this packet is sent multiple times while
			// the character is dashing, which is a potential problem if
			// DashRun gets stacked and started again, but the buff manager
			// should handle it. Alternatively, we could also add a check
			// here, to see if DashRun is already active. What's better
			// is TBD.
			character.Buffs.Start(BuffId.DashRun);
		}

		/// <summary>
		/// Sent during loading screen.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_MYTHIC_DUNGEON_REQUEST_CURRENT_SEASON)]
		public void CZ_MYTHIC_DUNGEON_REQUEST_CURRENT_SEASON(ChannelConnection conn, Packet packet)
		{
		}

		/// <summary>
		/// Sent on game loaded.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_REQ_QUICKSLOT_LIST)]
		public void CZ_REQ_QUICKSLOT_LIST(ChannelConnection conn, Packet packet)
		{
			var character = conn.SelectedCharacter;
			Send.ZC_QUICK_SLOT_LIST(character);
		}

		/// <summary>
		/// Sent on game loaded.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_DO_CLIENT_MOVE_CHECK)]
		public void CZ_DO_CLIENT_MOVE_CHECK(ChannelConnection conn, Packet packet)
		{
		}

		/// <summary>
		/// Sent on Popo Shop Opening
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_REQ_PCBANG_SHOP_UI)]
		public void CZ_REQ_PCBANG_SHOP_UI(ChannelConnection conn, Packet packet)
		{
			Send.ZC_PCBANG_SHOP_COMMON(conn);
		}

		/// <summary>
		/// Sent on Opening Skill Window
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_REQ_COMMON_SKILL_LIST)]
		public void CZ_REQ_COMMON_SKILL_LIST(ChannelConnection conn, Packet packet)
		{
			Send.ZC_COMMON_SKILL_LIST(conn);
		}

		[PacketHandler(Op.CZ_STOP_TIMEACTION)]
		public void CZ_STOP_TIMEACTION(ChannelConnection conn, Packet packet)
		{
		}

		/// <summary>
		/// Sent on Opening Commander/Inventory Window
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_REQ_COMMANDER_INFO)]
		public void CZ_REQ_COMMANDER_INFO(ChannelConnection conn, Packet packet)
		{
			Send.ZC_TRUST_INFO(conn);
		}

		/// <summary>
		/// Sent on Opening Map from Quest Log
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_REQ_FIELD_BOSS_EXIST)]
		public void CZ_REQ_FIELD_BOSS_EXIST(ChannelConnection conn, Packet packet)
		{
			Send.ZC_RESPONSE_FIELD_BOSS_EXIST(conn);
		}

		/// <summary>
		/// Sent when setting Custom Greeting Message
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_PC_COMMENT_CHANGE)]
		public void CZ_PC_COMMENT_CHANGE(ChannelConnection conn, Packet packet)
		{
			var type = packet.GetInt(); // 0?
			var message = packet.GetLpString();

			var character = conn.SelectedCharacter;

			if (character != null)
			{
				character.GreetingMessage = message;
				Send.ZC_NORMAL_SetGreetingMessage(character);
			}
		}

		/// <summary>
		/// Sent to continue dialog?
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_REQ_LEARN_ABILITY)]
		public void CZ_REQ_LEARN_ABILITY(ChannelConnection conn, Packet packet)
		{
			var type = packet.GetString(32);
		}

		/// <summary>
		/// ToS Hero Emblems?
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_REQUEST_DRAW_TOSHERO_EMBLEM)]
		public void CZ_REQUEST_DRAW_TOSHERO_EMBLEM(ChannelConnection conn, Packet packet)
		{
			Send.ZC_ADDON_MSG(conn.SelectedCharacter, "TOSHERO_ZONE_ENTER");
		}

		/// <summary>
		/// ?
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_PROPERTY_COMPARE)]
		public void CZ_PROPERTY_COMPARE(ChannelConnection conn, Packet packet)
		{
			var handle = packet.GetInt();
			var b1 = packet.GetByte();
			var b2 = packet.GetByte();

			var character = conn.SelectedCharacter.Map.GetCharacter(handle);
			if (character == null)
			{
				Log.Warning("Attempted to compare an unknown character '{0}'.", handle);
				return;
			}

			Send.ZC_PROPERTY_COMPARE(conn, character);
		}

		/// <summary>
		/// Sent when selecting a new language.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_SELECTED_LANGUAGE)]
		public void CZ_SELECTED_LANGUAGE(ChannelConnection conn, Packet packet)
		{
			var language = packet.GetShort();

			// 0 = English, 1 = German, 2 = Portugese,
			// 4 = Indonesian, 5 = Russian, 6 = Thai
		}

		/// <summary>
		/// Request to create an auto seller shop.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_REGISTER_AUTOSELLER)]
		public void CZ_REGISTER_AUTOSELLER(ChannelConnection conn, Packet packet)
		{
			var shopName = packet.GetString(64);
			var itemCount = packet.GetInt();
			var group = packet.GetInt();
			var i1 = packet.GetInt();

			// for itemCount
			//   int itemId
			//   int amount
			//   int price
			//   byte unk1[264]

			var character = conn.SelectedCharacter;
			character.MsgBox("This feature has not been implemented yet.");

			Log.Debug("CZ_REGISTER_AUTOSELLER: {0}, {1} item(s)", shopName, itemCount);
		}

		/// <summary>
		/// Request to pick up an item.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_REQ_ITEM_GET)]
		public void CZ_REQ_ITEM_GET(ChannelConnection conn, Packet packet)
		{
			var handle = packet.GetInt();

			var character = conn.SelectedCharacter;
			var monster = character.Map.GetMonster(handle);

			// Check for monster validity
			if (monster == null)
			{
				Log.Warning("CZ_REQ_ITEM_GET: User '{0}' tried to pick up an item that doesn't exist.", conn.Account.Name);
				return;
			}

			if (!(monster is ItemMonster itemMonster))
			{
				Log.Warning("CZ_REQ_ITEM_GET: User '{0}' tried to pick up a monster that is not an item.", conn.Account.Name);
				return;
			}

			// Accept pick ups only once the character is close enough.
			var pickUpRadius = ChannelServer.Instance.Conf.World.PickUpRadius;
			if (!monster.Position.InRange2D(character.Position, pickUpRadius))
				return;

			// Check if character is allowed to pick up the item.
			if (!itemMonster.CanBePickedUpBy(character))
				return;

			character.PickUp(itemMonster);
		}
	}
}
