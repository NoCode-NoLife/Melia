// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Channel.Network.Helpers;
using Melia.Channel.World;
using Melia.Shared.Const;
using Melia.Shared.Network;
using Melia.Shared.Network.Helpers;
using Melia.Shared.Util;
using Melia.Shared.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Melia.Channel.World.SkillEffects;

namespace Melia.Channel.Network
{
	public static class Send
	{
		// Triggers CZ_MOVE_ZONE_OK response from client, doesn't unstuck.
		//packet = new Packet(Op.ZC_MOVE_ZONE);
		//packet.PutByte(0);
		//conn.Send(packet);

		//packet = new Packet(Op.ZC_JOB_EXP_UP);
		//packet.PutInt(30);
		//conn.Send(packet);

		//var packet = new Packet(Op.ZC_UPDATE_ALL_STATUS);
		//packet.PutInt(character.WorldId);
		//packet.PutInt(character.Hp );
		//packet.PutInt(character.MaxHp );
		//packet.PutShort(character.Sp);
		//packet.PutShort(character.MaxSp);
		//packet.PutInt(X);
		//conn.Send(packet);

		//var p = new Packet(Op.ZC_PARTY_INFO);
		//p.PutByte(0); // party type - 0: normal party, 1: guild info
		//p.PutByte(0);
		//// PARTY_INFO
		//{
		//	p.PutLong(conn.SelectedCharacter.Id);  //?
		//	p.PutLong(666);  // partyID
		//	p.PutString("Mah Party", 56);
		//	p.PutLong(conn.SelectedCharacter.Id);
		//	p.PutString("John Connor", 56);
		//	p.PutInt(1);
		//}
		//// properties
		//p.PutShort(0); //size
		//conn.Send(p);

		/// <summary>
		/// Sends ZC_CONNECT_OK to connection, verifying the connection and
		/// giving information about the character.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="character"></param>
		public static void ZC_CONNECT_OK(ChannelConnection conn, Character character)
		{
			var packet = new Packet(Op.ZC_CONNECT_OK);

			packet.PutByte(0); // gameMode 0 = NormalMode, 1 = SingleMode
			packet.PutInt(1292150020);
			packet.PutByte(3); // isGM (< 3)?
			packet.PutEmptyBin(10);

			// [i11257 (2016-03-25)] ?
			{
				packet.PutByte(0);
			}

			packet.PutLpString(conn.SessionKey);

			// [i109XX (2015-12-01)]
			// [i11025 (2016-02-26)] Removed?
			{
				//packet.PutShort(0xFB31); // ?
			}

			packet.PutInt(character.Handle);
			packet.PutInt(0);

			packet.AddCommander(character);

			packet.PutFloat(character.Position.X);
			packet.PutFloat(character.Position.Y);
			packet.PutFloat(character.Position.Z);
			packet.PutInt(character.Exp);
			packet.PutInt(character.MaxExp);
			packet.PutInt(0);

			packet.PutLong(character.Id);
			packet.PutLong(character.Id + 1); // PCEtc GUID? socialInfoId

			packet.PutInt(character.Hp);
			packet.PutInt(character.MaxHp);
			packet.PutShort(character.Sp);
			packet.PutShort(character.MaxSp);
			packet.PutInt(character.Stamina);
			packet.PutInt(character.MaxStamina);
			packet.PutShort(0); // Shield
			packet.PutShort(0); // MaxShield

			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_START_GAME to connection, which assumingly is the signal
		/// for the client to switch from load to map screen.
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_START_GAME(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_START_GAME);

			packet.PutFloat(1); // Affects the speed of everything happening in the client o.o
			packet.PutFloat(1); // serverAppTimeOffset
			packet.PutFloat(1); // globalAppTimeOffset
			packet.PutLong(DateTime.Now.Add(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now)).ToFileTime());

			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_START_INFO to connection.
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_START_INFO(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_START_INFO);

			var character = conn.SelectedCharacter;


			packet.PutInt(character.jobs.Count); 
			foreach (var thisJob in character.jobs)
			{
				packet.PutShort((short) thisJob.Key);
				packet.PutInt(0); // 1270153646, 2003304878
				packet.PutInt(0);
				packet.PutShort(thisJob.Value);
			}

			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_MYPC_ENTER to character.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_MYPC_ENTER(Character character)
		{
			var packet = new Packet(Op.ZC_MYPC_ENTER);

			packet.PutFloat(character.Position.X);
			packet.PutFloat(character.Position.Y);
			packet.PutFloat(character.Position.Z);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Makes character appear on connection's client, by sending ZC_ENTER_PC.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="character"></param>
		public static void ZC_ENTER_PC(ChannelConnection conn, Character character)
		{
			var packet = new Packet(Op.ZC_ENTER_PC);

			packet.PutInt(character.Handle);
			packet.PutFloat(character.Position.X);
			packet.PutFloat(character.Position.Y);
			packet.PutFloat(character.Position.Z);
			packet.PutFloat(character.Direction.Cos);
			packet.PutFloat(character.Direction.Sin);
			packet.PutShort(0);
			packet.PutLong(character.Id + 1); // PCEtc GUID? socialInfoId
			packet.PutByte(0); // Pose
			packet.PutFloat(character.GetSpeed());
			packet.PutInt(0);
			packet.PutInt(character.Hp);
			packet.PutInt(character.MaxHp);
			packet.PutShort(character.Sp);
			packet.PutShort(character.MaxSp);
			packet.PutInt(0); // [i11025 (2016-02-26)]
			packet.PutInt(character.Stamina);
			packet.PutInt(character.MaxStamina);
			packet.PutByte(0);
			packet.PutShort(0);
			packet.PutInt(-1); // titleAchievmentId
			packet.PutInt(0);
			packet.PutByte(0);
			packet.AddCommander(character);

			// [i11025 (2016-02-26)] Removed?
			//packet.PutString("None", 49); // Party name

			// [i10622 (2015-10-22)] ?
			// [i11025 (2016-02-26)] Removed?
			{
				//packet.PutShort(0);
				//packet.PutInt(0);
				//packet.PutInt(0);
				//packet.PutInt(0);
				//packet.PutInt(0);
				//packet.PutInt(0);
				//packet.PutInt(0);
				//packet.PutInt(0);
			}

			conn.Send(packet);
		}

		/// <summary>
		/// Broadcasts ZC_ENTER_MONSTER on monster's map, making it appear.
		/// </summary>
		/// <param name="monster"></param>
		public static void ZC_ENTER_MONSTER(Monster monster)
		{
			var packet = new Packet(Op.ZC_ENTER_MONSTER);
			packet.AddMonster(monster);

			monster.Map.Broadcast(packet);
		}

		/// <summary>
		/// Sends ZC_ENTER_MONSTER to connection, making it appear.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="monster"></param>
		public static void ZC_ENTER_MONSTER(ChannelConnection conn, Monster monster)
		{
			var packet = new Packet(Op.ZC_ENTER_MONSTER);
			packet.AddMonster(monster);

			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_QUICK_SLOT_LIST to connection, containing the
		/// list of hotkeys?
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_QUICK_SLOT_LIST(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_QUICK_SLOT_LIST);

			packet.PutInt(0);
			packet.PutShort(0);
			//...

			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_SKILL_LIST to character, containing a list
		/// of all the character's skills.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_SKILL_LIST(Character character)
		{
			var packet = new Packet(Op.ZC_SKILL_LIST);
			
			packet.PutInt(character.Handle);
			List<Skill> skillsList = character.skillManager.GetAllSkillsFromSkillList();
			packet.PutShort(skillsList.Count); // count

			packet.PutShort(0); // No compression

			//packet.BeginZlib();
			foreach (var skill in skillsList)
			{
				packet.AddSkill(skill);
			}
			//packet.EndZlib();

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Adds skill for character, by sending ZC_SKILL_ADD to its connection.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="skillId"></param>
		public static void ZC_SKILL_ADD(Character character, Skill skill, bool registerShortcut, bool isFromSkillLiest, long unk1)
		{
			var packet = new Packet(Op.ZC_SKILL_ADD);

			packet.PutByte(registerShortcut);
			packet.PutByte(isFromSkillLiest);
			packet.PutLong(unk1); // ? I belive this could be a reference to an item that gives this skill. When item is removed, the skill aswell.
			packet.AddSkill(skill);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sends ZC_SKILLMAP_LIST to character.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_SKILLMAP_LIST(Character character)
		{
			var packet = new Packet(Op.ZC_SKILLMAP_LIST);

			packet.PutInt(0); // ?

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sends ZC_OPTION_LIST to connection, containing the saved
		/// account options, like "Show Exp Aquired".
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_OPTION_LIST(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_OPTION_LIST);

			packet.PutString(conn.Account.Settings.ToString());

			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_ACHIEVE_POINT_LIST to character.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_ACHIEVE_POINT_LIST(Character character)
		{
			var packet = new Packet(Op.ZC_ACHIEVE_POINT_LIST);

			packet.PutInt(0); // ?

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sends ZC_CHAT_MACRO_LIST to character.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_CHAT_MACRO_LIST(Character character)
		{
			var packet = new Packet(Op.ZC_CHAT_MACRO_LIST);

			packet.PutInt(0); // ?

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sends ZC_UI_INFO_LIST to character.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_UI_INFO_LIST(Character character)
		{
			var packet = new Packet(Op.ZC_UI_INFO_LIST);

			packet.PutInt(0); // ?
			packet.PutInt(0); // ?

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sends ZC_NPC_STATE_LIST to character.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_NPC_STATE_LIST(Character character)
		{
			var packet = new Packet(Op.ZC_NPC_STATE_LIST);

			packet.PutInt(0); // ?

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sends ZC_COOLDOWN_LIST to character, containing list of all
		/// cooldowns?
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_COOLDOWN_LIST(Character character)
		{
			var packet = new Packet(Op.ZC_COOLDOWN_LIST);

			packet.PutLong(0); // socialInfoId ?
			packet.PutInt(0); // ?

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sends ZC_JOB_PTS to character, updating their job points.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_JOB_PTS(Character character, Job jobId, int points)
		{
			var packet = new Packet(Op.ZC_JOB_PTS);

			packet.PutShort((short)jobId);
			packet.PutShort((short)points);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sends ZC_ABILITY_LIST to character, containing a list of all
		/// their abilities.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_ABILITY_LIST(Character character)
		{
			var packet = new Packet(Op.ZC_ABILITY_LIST);

			var abilities = new[] { 10001, 10003, 10009, 10012, 10013, 10014, 101001 };

			packet.PutInt(character.Handle);
			packet.PutShort(abilities.Length); // count

			packet.PutShort(0); // No compression (client handler tests this short for compression marker, comment this line if using compression)
			//packet.BeginZlib();
			foreach (var ability in abilities)
			{
				packet.PutLong(0); // Some kind of GUID? o.O
				packet.PutInt(ability);
				packet.PutShort(6); // properties size (some abilities doesn't have properties, like weapon wielding)
				packet.PutShort(255); // ?
				packet.PutShort(25); //Level
				packet.PutFloat(10);
			}
			//packet.EndZlib();

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Broadcasts ZC_MOVE_SPEED in range of character, updating their move speed.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_MOVE_SPEED(Character character)
		{
			var packet = new Packet(Op.ZC_MOVE_SPEED);
			packet.PutInt(character.Handle);
			packet.PutFloat(character.GetSpeed());
			packet.PutFloat(0);

			// [i11257 (2016-03-25)]
			{
				packet.PutByte(0);
			}

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Sends ZC_ITEM_INVENTORY_LIST to character, containing a list of
		/// all items in their inventory.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_ITEM_INVENTORY_LIST(Character character)
		{
			var items = character.Inventory.GetItems();

			var packet = new Packet(Op.ZC_ITEM_INVENTORY_LIST);

			packet.PutInt(items.Count);
			packet.PutShort(0); // Compression
			foreach (var item in items)
			{
				packet.PutInt(item.Value.Id);
				packet.PutShort(0); // Size of the object at the end
				packet.PutEmptyBin(2);
				packet.PutLong(item.Value.WorldId);
				packet.PutInt(item.Value.Amount);
				packet.PutInt(item.Value.Price);
				packet.PutInt(item.Key);
				packet.PutInt(1); // ?
				//packet.PutEmptyBin(0);
			}

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sends ZC_ITEM_INVENTORY_LIST to character, containing a list of
		/// all their equipment.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_ITEM_EQUIP_LIST(Character character)
		{
			var equip = character.Inventory.GetEquip();
			if (equip.Count != Items.EquipSlotCount)
				throw new InvalidOperationException("Incorrect amount of equipment (" + equip.Count + ").");

			var packet = new Packet(Op.ZC_ITEM_EQUIP_LIST);

			foreach (var equipItem in equip)
			{
				packet.PutInt(equipItem.Value.Id);
				packet.PutShort(0); // Object size
				packet.PutEmptyBin(2);
				packet.PutLong(equipItem.Value.WorldId);
				packet.PutByte((byte)equipItem.Key);
				packet.PutEmptyBin(3);
				packet.PutInt(0);
				//packet.PutEmptyBin(0); // Object
			}

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Broadcasts ZC_CHAT in range of character.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="format"></param>
		/// <param name="args"></param>
		public static void ZC_CHAT(Character character, string format, params object[] args)
		{
			ZC_CHAT(character, string.Format(format, args));
		}

		/// <summary>
		/// Broadcasts ZC_CHAT in range of character.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="message"></param>
		public static void ZC_CHAT(Character character, string message)
		{
			var packet = new Packet(Op.ZC_CHAT);

			packet.PutInt(character.Handle);
			packet.PutString(character.TeamName, 64);
			packet.PutString(character.Name, 65);
			packet.PutByte(0); // -11, -60, -1, -19, 1
			packet.PutShort((short)character.Job);
			packet.PutInt(0); // 1, 10, 11
			packet.PutByte((byte)character.Gender);
			packet.PutByte((byte)character.Hair);
			packet.PutEmptyBin(2);
			packet.PutInt(0); // 628051

			// [i11257 (2016-03-25)] ?
			{
				packet.PutInt(1004);
			}

			packet.PutFloat(0); // Display time in seconds, min cap 5s
			packet.PutString(message);

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Sends ZC_CHAT to connection.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="message"></param>
		public static void ZC_CHAT(ChannelConnection conn, Character character, string message)
		{
			var packet = new Packet(Op.ZC_CHAT);

			packet.PutInt(character.Handle);
			packet.PutString(character.TeamName, 64);
			packet.PutString(character.Name, 65);
			packet.PutByte(0); // -11, -60, -1, -19, 1
			packet.PutShort((short)character.Job);
			packet.PutInt(0); // 1, 10, 11
			packet.PutByte((byte)character.Gender);
			packet.PutByte((byte)character.Hair);
			packet.PutEmptyBin(2);
			packet.PutInt(0); // 628051

			// [i11257 (2016-03-25)] ?
			{
				packet.PutInt(1004);
			}

			packet.PutFloat(0); // Display time in seconds, min cap 5s
			packet.PutString(message);

			conn.Send(packet);
		}

		/// <summary>
		/// Send ZC_SYSTEM_MSG to character.
		/// </summary>
		/// <param name="character">Character to send packet to.</param>
		/// <param name="clientMessage">Id of the message to use.</param>
		/// <param name="parameters">Optional list of message parameters.</param>
		public static void ZC_SYSTEM_MSG(Character character, int clientMessage, params MsgParameter[] parameters)
		{
			var packet = new Packet(Op.ZC_SYSTEM_MSG);

			packet.PutInt(clientMessage);
			packet.PutByte((byte)parameters.Length);
			packet.PutByte(1); // type? 0 = also show in red letters on the screen
			foreach (var parameter in parameters)
			{
				packet.PutLpString(parameter.Key);
				packet.PutLpString(parameter.Value);
			}

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Broadcasts ZC_JUMP in range of character, making them jump.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_JUMP(Character character)
		{
			var packet = new Packet(Op.ZC_JUMP);

			packet.PutInt(character.Handle);
			packet.PutFloat(character.GetJumpStrength());
			packet.PutInt(character.GetJumpType());
			packet.PutByte(1);  // 1 or 0

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Broadcasts ZC_REST_SIT in range of character, making them sit down.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_REST_SIT(Character character)
		{
			var packet = new Packet(Op.ZC_REST_SIT);

			packet.PutInt(character.Handle);
			packet.PutByte(0);

			// [i11257 (2016-03-25)]
			// If this is set incorrectly, the character "freezes" and
			// doesn't animate while running around anymore.
			{
				packet.PutByte(character.IsSitting);
			}

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Sends ZC_ITEM_REMOVE to character, which removes the given item
		/// or amount from the inventory.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="worldId"></param>
		/// <param name="amount"></param>
		/// <param name="msg"></param>
		/// <param name="invType"></param>
		public static void ZC_ITEM_REMOVE(Character character, long worldId, int amount, InventoryItemRemoveMsg msg, InventoryType invType)
		{
			var packet = new Packet(Op.ZC_ITEM_REMOVE);

			packet.PutLong(worldId);
			packet.PutInt(amount);
			packet.PutByte((byte)msg);
			packet.PutByte((byte)invType);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sends ZC_ITEM_INVENTORY_INDEX_LIST to character, containing a list
		/// of indices for all items in the inventory. This updates their order.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_ITEM_INVENTORY_INDEX_LIST(Character character)
		{
			ZC_ITEM_INVENTORY_INDEX_LIST(character, character.Inventory.GetIndices());
		}

		/// <summary>
		/// Sends ZC_ITEM_INVENTORY_INDEX_LIST to character, containing a list
		/// of indices for all items in the given category of the inventory.
		/// This updates their order.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="category"></param>
		public static void ZC_ITEM_INVENTORY_INDEX_LIST(Character character, InventoryCategory category)
		{
			ZC_ITEM_INVENTORY_INDEX_LIST(character, character.Inventory.GetIndices(category));
		}

		/// <summary>
		/// Sends ZC_ITEM_INVENTORY_INDEX_LIST to character, containing a list
		/// of indices for items in an inventory. This updates their order.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="indices"></param>
		public static void ZC_ITEM_INVENTORY_INDEX_LIST(Character character, IDictionary<int, long> indices)
		{
			var packet = new Packet(Op.ZC_ITEM_INVENTORY_INDEX_LIST);

			packet.PutInt(indices.Count);
			foreach (var index in indices)
			{
				packet.PutLong(index.Value);
				packet.PutInt(index.Key);
			}

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Broadcasts ZC_UPDATED_PCAPPEARANCE in range of character, updating
		/// their appearance.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_UPDATED_PCAPPEARANCE(Character character)
		{
			var packet = new Packet(Op.ZC_UPDATED_PCAPPEARANCE);

			packet.PutInt(character.Handle);
			packet.AddCommander(character);

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Sends ZC_ITEM_ADD to character, adding the item to the inventory.
		/// </summary>
		/// <remarks>
		/// "Updating" stack by *adding* items to it is an ADD as well.
		/// </remarks>
		/// <param name="character">Character to send packet to.</param>
		/// <param name="item">Item added or updated.</param>
		/// <param name="index">Index of the item in the inventory.</param>
		/// <param name="amount">Amount to add.</param>
		/// <param name="addType">The way the add is displayed?</param>
		public static void ZC_ITEM_ADD(Character character, Item item, int index, int amount, InventoryAddType addType)
		{
			var packet = new Packet(Op.ZC_ITEM_ADD);

			packet.PutLong(item.WorldId);
			packet.PutInt(amount);
			packet.PutInt(index);
			packet.PutInt(item.Id);
			packet.PutShort(0); // Size of the object at the end
			packet.PutByte((byte)addType);
			packet.PutFloat(0); // Notification delay
			packet.PutByte(0); // InvType
			packet.PutEmptyBin(2);
			//packet.PutEmptyBin(0); // properties

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sends ZC_MOVE_BARRACK to connection, informing client that it's
		/// save to disconnect?
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_MOVE_BARRACK(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_MOVE_BARRACK);
			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_LOGOUT_OK to connection, informing client that it's
		/// save to disconnect?
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_LOGOUT_OK(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_LOGOUT_OK);
			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_CAMPINFO to connection.
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_CAMPINFO(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_CAMPINFO); // Size: 18 (12)
			packet.PutEmptyBin(12);
			conn.Send(packet);
		}

		/// <summary>
		/// Broadcasts ZC_SET_POS in range of character, updating its position.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_SET_POS(Character character)
		{
			var packet = new Packet(Op.ZC_SET_POS);

			packet.PutInt(character.Handle);
			packet.PutFloat(character.Position.X);
			packet.PutFloat(character.Position.Y);
			packet.PutFloat(character.Position.Z);
			packet.PutByte(0);

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Sends ZC_MOVE_ZONE_OK to connection, telling the client where to
		/// connect to, and which map to load.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="ip"></param>
		/// <param name="port"></param>
		/// <param name="mapId"></param>
		public static void ZC_MOVE_ZONE_OK(ChannelConnection conn, string ip, int port, int mapId)
		{
			var packet = new Packet(Op.ZC_MOVE_ZONE_OK);

			packet.PutInt(210004);
			packet.PutInt(IPAddress.Parse(ip).ToInt32());
			packet.PutInt(port);
			packet.PutInt(mapId);
			packet.PutFloat(38); // Camera X angle
			packet.PutFloat(45); // Camera Y angle
			packet.PutFloat(200);
			packet.PutFloat(2200);
			packet.PutFloat(1000);
			packet.PutInt(26);
			packet.PutInt(20);
			packet.PutInt(59);
			packet.PutShort(0);
			packet.PutByte(0);

			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_MOVE_ZONE to connection, telling client to prepare for
		/// a warp.
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_MOVE_ZONE(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_MOVE_ZONE);
			packet.PutByte(0);

			conn.Send(packet);
		}

		/// <summary>
		/// Broadcasts ZC_PC in range of character, updating certain information.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="updateType"></param>
		/// <param name="newValue"></param>
		public static void ZC_PC(Character character, PcUpdateType updateType, object newValue)
		{
			var packet = new Packet(Op.ZC_PC);
			packet.PutInt((int)character.Handle);
			packet.PutInt((int)updateType);

			if (updateType == PcUpdateType.Name)
			{
				packet.PutShort(0);
				packet.PutEmptyBin(2);
				packet.PutInt(0);
				packet.PutShort(65);
				packet.PutString((string)newValue, 65);
			}
			else if (updateType == PcUpdateType.Job)
			{
				packet.PutShort((short)newValue);
				packet.PutEmptyBin(2);
				packet.PutInt(3); // Job Grade (stars/Circle)
			}

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Sends ZC_OBJECT_PROPERTY to character, containing a list of some
		/// default properties always needed after connecting.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_OBJECT_PROPERTY_Init(Character character)
		{
			ZC_OBJECT_PROPERTY(character,
				ObjectProperty.PC.HP, ObjectProperty.PC.MHP,
				ObjectProperty.PC.SP, ObjectProperty.PC.MSP,
				//ObjectProperty.PC.STR, ObjectProperty.PC.CON, ObjectProperty.PC.INT, ObjectProperty.PC.MNA, ObjectProperty.PC.DEX,
				ObjectProperty.PC.NowWeight, ObjectProperty.PC.MaxWeight,
				ObjectProperty.PC.StatByLevel, ObjectProperty.PC.StatByBonus, ObjectProperty.PC.UsedStat
			);
		}

		/// <summary>
		/// Sends ZC_OBJECT_PROPERTY to character, containing a list of the
		/// given properties.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="properties"></param>
		public static void ZC_OBJECT_PROPERTY(Character character, params short[] properties)
		{
			ZC_OBJECT_PROPERTY(character.Connection, character, properties);
		}

		/// <summary>
		/// Sends ZC_OBJECT_PROPERTY to connection, containing a list of the
		/// given properties, using values from character.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="character"></param>
		/// <param name="properties"></param>
		public static void ZC_OBJECT_PROPERTY(ChannelConnection conn, Character character, params short[] properties)
		{
			if (properties == null || properties.Length == 0)
				return;


			var packet = new Packet(Op.ZC_OBJECT_PROPERTY);
			packet.PutLong(character.Id);
			foreach (var property in properties)
			{
				packet.PutShort(property);
				switch (property)
				{
					case ObjectProperty.PC.HP: packet.PutFloat(character.Hp); break;
					case ObjectProperty.PC.MHP: packet.PutFloat(character.MaxHp); break;
					case ObjectProperty.PC.SP: packet.PutFloat(character.Sp); break;
					case ObjectProperty.PC.MSP: packet.PutFloat(character.MaxSp); break;

					case ObjectProperty.PC.STR: packet.PutFloat(character.statsManager.stats[(int)Stat.STR]); break;
					case ObjectProperty.PC.CON: packet.PutFloat(character.statsManager.stats[(int)Stat.CON]); break;
					case ObjectProperty.PC.INT: packet.PutFloat(character.statsManager.stats[(int)Stat.INT]); break;
					case ObjectProperty.PC.MNA: packet.PutFloat(character.statsManager.stats[(int)Stat.SPR]); break;
					case ObjectProperty.PC.DEX: packet.PutFloat(character.statsManager.stats[(int)Stat.DEX]); break;

					case ObjectProperty.PC.NowWeight: packet.PutFloat(character.NowWeight); break;
					case ObjectProperty.PC.MaxWeight: packet.PutFloat(character.MaxWeight); break;

					case ObjectProperty.PC.StatByLevel: packet.PutFloat(character.StatByLevel); break;
					case ObjectProperty.PC.StatByBonus: packet.PutFloat(character.StatByBonus); break;
					case ObjectProperty.PC.UsedStat: packet.PutFloat(character.UsedStat); break;

					case ObjectProperty.PC.JobChanging: packet.PutShort((short)character.Job); break;
					case ObjectProperty.PC.BeforeJobLv: packet.PutShort((short)character.jobLevel); break;

					case ObjectProperty.PC.DR: packet.PutFloat(character.statsManager.stats[(int)Stat.Evasion]); break;
					case ObjectProperty.PC.DR_BM: packet.PutFloat(character.statsManager.stats[(int)Stat.DR_BM]); break;

					case ObjectProperty.PC.MSPD: packet.PutFloat(character.statsManager.stats[(int)Stat.MovSpeed]); break;
					case ObjectProperty.PC.RHP: packet.PutFloat(character.statsManager.stats[(int)Stat.RecoveryHP]); break;
					case ObjectProperty.PC.RSP: packet.PutFloat(character.statsManager.stats[(int)Stat.RecoverySP]); break;

					case ObjectProperty.PC.MINPATK: packet.PutFloat(character.statsManager.stats[(int)Stat.MINPATK]); break;
					case ObjectProperty.PC.MAXPATK: packet.PutFloat(character.statsManager.stats[(int)Stat.MAXPATK]); break;
					case ObjectProperty.PC.MINPATK_SUB: packet.PutFloat(character.statsManager.stats[(int)Stat.MINPATK_SUB]); break;
					case ObjectProperty.PC.MAXPATK_SUB: packet.PutFloat(character.statsManager.stats[(int)Stat.MAXPATK_SUB]); break;
					case ObjectProperty.PC.MINMATK: packet.PutFloat(character.statsManager.stats[(int)Stat.MINMATK]); break;
					case ObjectProperty.PC.MAXMATK: packet.PutFloat(character.statsManager.stats[(int)Stat.MAXMATK]); break;
					case ObjectProperty.PC.DEF: packet.PutFloat(character.statsManager.stats[(int)Stat.PDEF]); break;
					case ObjectProperty.PC.MDEF: packet.PutFloat(character.statsManager.stats[(int)Stat.MDEF]); break;

					default: throw new ArgumentException("Unknown property '" + property + "'.");
				}
			}

			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_OBJECT_PROPERTY to connection, containing a list of the
		/// given properties, using values from character.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="character"></param>
		/// <param name="properties"></param>
		public static void ZC_OBJECT_PROPERTY(ChannelConnection conn, Skill skill, params short[] properties)
		{
			if (properties == null || properties.Length == 0)
				return;

			var packet = new Packet(Op.ZC_OBJECT_PROPERTY);
			packet.PutLong(skill.WorldId);
			foreach (var property in properties)
			{
				packet.PutShort(property);
				switch (property)
				{
					// Level up existing skill
					case ObjectProperty.Skill.Level: packet.PutFloat((float)skill.level); break;
					case ObjectProperty.Skill.LevelByDB: packet.PutFloat((short)skill.level); break;
					case ObjectProperty.Skill.SpendSP: packet.PutFloat((float)skill.Data.SpendSP); break;
					case ObjectProperty.Skill.SkillAtkAdd: packet.PutFloat((float)skill.Data.AttackAdd); break;

					case ObjectProperty.Skill.CoolDown: packet.PutFloat((float)skill.Data.CoolDown); break;
					case ObjectProperty.Skill.BasicCoolDown: packet.PutFloat((float)skill.Data.CoolDown); break;
					case ObjectProperty.Skill.SpendItemCount: packet.PutFloat(0.0f); break; // SpendItemBaseCount
					case ObjectProperty.Skill.SplAngle: packet.PutFloat((float)skill.Data.SplashAngle); break;
					case ObjectProperty.Skill.SR: packet.PutFloat(1.0f); break;
					case ObjectProperty.Skill.SplRange: packet.PutFloat((float)skill.Data.SplashRange); break; //
					case ObjectProperty.Skill.MaxR: packet.PutFloat(100.0f); break; //
					
					case ObjectProperty.Skill.WaveLength: packet.PutFloat(0.0f); break;
					case ObjectProperty.Skill.BackHitRange: packet.PutFloat(0.0f); break;
					case ObjectProperty.Skill.UseOverHeat: packet.PutFloat(0.0f); break; // UseOverHit
					case ObjectProperty.Skill.SkillASPD: packet.PutFloat(1.0f); break;
					case ObjectProperty.Skill.SkillSR: packet.PutFloat(4.0f); break;
					case ObjectProperty.Skill.SklSpdRate: packet.PutFloat(1.0f); break;
					case ObjectProperty.Skill.SpendPoison: packet.PutFloat(0.0f); break;
					case ObjectProperty.Skill.SpendSta: packet.PutFloat(0.0f); break; // BasicSta
					case ObjectProperty.Skill.Skill_Delay:	packet.PutFloat(0.0f); break; // DelayTime ?
					case ObjectProperty.Skill.ReadyTime: packet.PutFloat(250.0f); break; // ReadyFix ? Seems to.
					case ObjectProperty.Skill.EnableShootMove: packet.PutFloat(skill.Data.EnableShootMove ? 1f : 0f); break; // EnableShootMove
					case ObjectProperty.Skill.AbleShootRotate: packet.PutFloat(skill.Data.EnableShootRotate ? 1f : 0f); break; // EnableShootRotate
					case ObjectProperty.Skill.SkillFactor: packet.PutFloat((float)skill.Data.SkillFactor); break; // SkillFactor + SkillFactorByLv

					default: throw new ArgumentException("Unknown property '" + property + "'.");
				}
			}

			conn.Send(packet);
		}

		/// <summary>
		/// Broadcasts ZC_ROTATE in range of character.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_ROTATE(IEntity entity)
		{
			var packet = new Packet(Op.ZC_ROTATE);

			packet.PutInt(entity.Handle);
			packet.PutFloat(entity.Direction.Cos);
			packet.PutFloat(entity.Direction.Sin);
			packet.PutByte(0);
			packet.PutByte(0);

			entity.Map.Broadcast(packet, entity);
		}

		/// <summary>
		/// Broadcasts ZC_HEAD_ROTATE in range of character.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_HEAD_ROTATE(Character character)
		{
			var packet = new Packet(Op.ZC_HEAD_ROTATE);

			packet.PutInt(character.Handle);
			packet.PutFloat(character.HeadDirection.Cos);
			packet.PutFloat(character.HeadDirection.Sin);

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Sends ZC_DIALOG_OK to connection, containing a dialog message.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="msg"></param>
		public static void ZC_DIALOG_OK(ChannelConnection conn, string msg)
		{
			var packet = new Packet(Op.ZC_DIALOG_OK);

			packet.PutInt(0); // handle?
			packet.PutString(msg);

			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_DIALOG_NEXT to connection, containing a dialog message.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="msg"></param>
		public static void ZC_DIALOG_NEXT(ChannelConnection conn, string msg)
		{
			var packet = new Packet(Op.ZC_DIALOG_OK);

			packet.PutInt(0); // handle?
			packet.PutString(msg);

			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_DIALOG_SELECT to connection, containing a dialog message
		/// and a list of selectable options.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="arguments"></param>
		public static void ZC_DIALOG_SELECT(ChannelConnection conn, params string[] arguments)
		{
			if (arguments == null || arguments.Length == 0)
				return;

			var packet = new Packet(Op.ZC_DIALOG_SELECT);

			packet.PutInt(0); // handle?
			packet.PutShort(arguments.Length);
			foreach (var arg in arguments)
				packet.PutLpString(arg);

			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_DIALOG_CLOSE to connection, which closes the currently
		/// open dialog.
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_DIALOG_CLOSE(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_DIALOG_CLOSE);
			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_DIALOG_STRINGINPUT to connection, containing a dialog
		/// message, and requesting putting in a string.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="msg"></param>
		public static void ZC_DIALOG_STRINGINPUT(ChannelConnection conn, string msg)
		{
			var packet = new Packet(Op.ZC_DIALOG_STRINGINPUT);

			packet.PutInt(0); // handle?
			packet.PutString(msg);

			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_DIALOG_NUMBERRANGE over connection, containing a dialog
		/// message, and requesting putting in a number.
		/// </summary>
		/// <remarks>
		/// Due to number range using CZ_DIALOG_SELECT for its response,
		/// the max range is 0~255, since that packet only holds a
		/// byte. The dialog window for this packet seems a little
		/// unfinished, and I didn't see any packets for it yet,
		/// it can be assumed that this feature, albeit working,
		/// isn't 100% done yet.
		/// </remarks>
		/// <param name="conn"></param>
		/// <param name="msg"></param>
		/// <param name="min"></param>
		/// <param name="max"></param>
		public static void ZC_DIALOG_NUMBERRANGE(ChannelConnection conn, string msg, int min = 0, int max = 255)
		{
			min = Math2.Clamp(0, 255, min);
			max = Math2.Clamp(0, 255, max);
			if (max < min)
				max = min;

			var packet = new Packet(Op.ZC_DIALOG_NUMBERRANGE);

			packet.PutInt(0); // handle?
			packet.PutString(msg, 128);
			packet.PutInt(min);
			packet.PutInt(max);

			conn.Send(packet);
		}

		/// <summary>
		/// Broadcasts ZC_LEAVE on monster's map, making it disappear.
		/// </summary>
		/// <param name="entity"></param>
		public static void ZC_LEAVE(IEntity entity)
		{
			var packet = new Packet(Op.ZC_LEAVE);

			packet.PutInt(entity.Handle);
			packet.PutShort(1); // 0 shows a blue effect when the entity disappears

			entity.Map.Broadcast(packet);
		}

		/// <summary>
		/// Sends ZC_LEAVE to conn, making it disappear.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="entity"></param>
		public static void ZC_LEAVE(ChannelConnection conn, IEntity entity)
		{
			var packet = new Packet(Op.ZC_LEAVE);

			packet.PutInt(entity.Handle);
			packet.PutShort(1); // 0 shows a blue effect when the entity disappears

			conn.Send(packet);
		}

		/// <summary>
		/// Enables/disables control over character.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="enabled"></param>
		public static void ZC_ENABLE_CONTROL(ChannelConnection conn, bool enabled)
		{
			var packet = new Packet(Op.ZC_ENABLE_CONTROL);
			packet.PutInt(0);
			packet.PutByte(enabled);

			conn.Send(packet);
		}

		/// <summary>
		/// Broadcasts ZC_DEAD in range of entity, which kills it visually.
		/// </summary>
		/// <param name="entity">Entity to kill visually.</param>
		public static void ZC_DEAD(IEntity entity)
		{
			var packet = new Packet(Op.ZC_DEAD);
			packet.PutInt(entity.Handle);
			packet.PutInt(0);

			entity.Map.Broadcast(packet, entity);
		}

		/// <summary>
		/// Informs players about a hit that occured, and about the target's
		/// new hp, after damage was applied.
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="damage"></param>
		public static void ZC_HIT_INFO(IEntity attacker, IEntity target, int damage)
		{
			var packet = new Packet(Op.ZC_HIT_INFO);
			packet.PutInt(target.Handle);
			packet.PutInt(attacker.Handle);
			packet.PutInt(100);
			packet.PutInt(damage);
			packet.PutInt(target.Hp);
			packet.PutInt(2);
			packet.PutBinFromHex("01 00 00 60 06 68 03 00   18 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00");

			target.Map.Broadcast(packet);
		}

		/// <summary>
		/// Informs players about a hit that occured, and about the target's
		/// new hp, after damage was applied.
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="damage"></param>
		public static void ZC_SKILL_HIT_INFO(IEntity attacker, List<SkillResult> targets)
		{
			int countValidTargets = 0;
			foreach (SkillResult target in targets)
			{
				if (target.type == 0)
					continue;
				countValidTargets++;
			}
			if (countValidTargets == 0) return;
			var packet = new Packet(Op.ZC_SKILL_HIT_INFO);
			packet.PutInt(attacker.Handle);
			packet.PutByte((Byte)countValidTargets); // Count
			foreach (SkillResult target in targets)
			{
				if (target.type == 0)
					continue;

				packet.PutShort(26057);
				packet.PutShort(5236);
				packet.PutInt(target.targetHandle);
				packet.PutInt((int)target.value);
				packet.PutInt(target.actor.Hp);
				packet.PutInt(1); // Hit count
				packet.PutBinFromHex("01 00 FF 18 F8 18 03 00 00 71 00 08 54 01 00 00 64 00 02 01 00 00 93 00 00 00 00 00 F6 06 41 6A 00 00 00 64");

			}

			attacker.Map.Broadcast(packet);
		}

		public static void ZC_SKILL_FORCE_TARGET(IEntity attacker, Skill skill, SkillResult result)
		{
			var packet = new Packet(Op.ZC_SKILL_FORCE_TARGET);

			var testValue = ((Character)attacker).test;

			packet.PutInt(skill.Id);
			packet.PutInt(attacker.Handle);
			packet.PutFloat(attacker.Direction.Cos);
			packet.PutFloat(attacker.Direction.Sin);
			packet.PutInt(1);
			// Skill time (like cooldown or effect time. The player will not be able to cast another of this skill, until this time passed. 
			// The HIT EFFECT will appear in the monster, passed this time or when the skill hits something in the client. What happens first.
			packet.PutFloat(700f);
			packet.PutFloat(1f);
			packet.PutInt(1);
			packet.PutBinFromHex("00 00 03 00");
			packet.PutFloat(1f);
			packet.PutInt(result.actor.Handle);
			packet.PutInt(0);
			packet.PutFloat(512f);
			packet.PutInt(0);
			packet.PutByte(1);
			packet.PutBinFromHex("00 00 00 00");
			packet.PutInt(result.actor.Handle);
			packet.PutInt((int)result.value); // Hit value
			packet.PutInt(result.actor.Hp); // Remaining HP
			packet.PutInt(1); // Accumulated hits?
			packet.PutBinFromHex("00 00 00 01");
			packet.PutBinFromHex("30 00");
			packet.PutByte(3);  // 1 = Dodge, 2 = Block, 3 = Normal hit, 4 = Golden Hit, 5 = Hit and Dodge, 6 = Miss, 
			packet.PutBinFromHex("00 00 00 00 00 40 02 00 00 C8 00 02 01 00 00 00 00 22 BD 03 00 00 00 00 00 00 00 00 00");

			attacker.Map.Broadcast(packet);
		}

		/// <summary>
		/// Updates character's level.
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_PC_LEVELUP(Character character)
		{
			var packet = new Packet(Op.ZC_PC_LEVELUP);
			packet.PutInt(character.Handle);
			packet.PutInt(character.Level);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Plays level up effect.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_NORMAL_LevelUp(Character character)
		{
			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(0x11);
			packet.PutInt(character.Handle);
			packet.PutShort(8351);
			packet.PutShort(39);
			packet.PutFloat(6); // Effect size
			packet.PutInt(2);
			packet.PutEmptyBin(4);
			packet.PutFloat(1);
			packet.PutEmptyBin(4);

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Plays class level up effect.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_NORMAL_ClassLevelUp(Character character)
		{
			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(0x14);
			packet.PutInt(character.Handle);
			packet.PutByte(1);
			packet.PutInt(2);
			packet.PutByte(1);
			packet.PutFloat(6); // Effect size
			packet.PutEmptyBin(8);

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Updates exp and max exp.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="exp"></param>
		public static void ZC_MAX_EXP_CHANGED(Character character, int exp)
		{
			var packet = new Packet(Op.ZC_MAX_EXP_CHANGED);
			packet.PutInt(exp);
			packet.PutInt(character.Exp);
			packet.PutInt(character.MaxExp);

			// [i11037 (2016-03-0X)] ?
			// acq 43, exp 36, max 462, ? 316
			{
				packet.PutInt(0);
			}

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Notification about acquired exp from killing a monster?
		/// </summary>
		/// <param name="character"></param>
		/// <param name="exp"></param>
		/// <param name="jobExp"></param>
		/// <param name="monster"></param>
		public static void ZC_EXP_UP_BY_MONSTER(Character character, int exp, int jobExp, Monster monster)
		{
			var packet = new Packet(Op.ZC_EXP_UP_BY_MONSTER);
			packet.PutInt(exp);
			packet.PutInt(jobExp);
			packet.PutInt(monster.Handle);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Adds exp.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="exp"></param>
		/// <param name="jobExperience"></param>
		public static void ZC_EXP_UP(Character character, int exp, int jobExperience)
		{
			var packet = new Packet(Op.ZC_EXP_UP);
			packet.PutInt(exp);
			packet.PutInt(jobExperience); // jobExp?

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Adds job exp.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="exp"></param>
		public static void ZC_JOB_EXP_UP(Character character, int exp)
		{
			var packet = new Packet(Op.ZC_JOB_EXP_UP);
			packet.PutInt(exp);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Executes Lua addon function.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="msg"></param>
		public static void ZC_ADDON_MSG(Character character, string msg)
		{
			var packet = new Packet(Op.ZC_ADDON_MSG);
			packet.PutByte((byte)(msg.Length + 1));
			packet.PutInt(0);
			packet.PutByte(1);
			packet.PutString(msg);
			// + parameters?

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sends ZC_PC_PROP_UPDATE to character, updating a property.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="property"></param>
		/// <param name="value"></param>
		public static void ZC_PC_PROP_UPDATE(Character character, short property, byte value)
		{
			var packet = new Packet(Op.ZC_PC_PROP_UPDATE);
			packet.PutShort(property);
			packet.PutByte(value); // ?

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Shows emoticon for entity.
		/// </summary>
		/// <remarks>
		/// Couldn't find a list in the client data yet.
		/// Known emoticons:
		/// - 60008: Explamation mark bubble
		/// - 60009: Hearts
		/// </remarks>
		/// <param name="entity"></param>
		/// <param name="emoticons"></param>
		/// <param name="duration"></param>
		public static void ZC_SHOW_EMOTICON(IEntity entity, int emoticons, int duration)
		{
			var packet = new Packet(Op.ZC_SHOW_EMOTICON);
			packet.PutInt(entity.Handle);
			packet.PutInt(emoticons);
			packet.PutInt(duration);

			entity.Map.Broadcast(packet, entity);
		}

		/// <summary>
		/// Sends ZC_LOGIN_TIME to connection.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="now"></param>
		public static void ZC_LOGIN_TIME(ChannelConnection conn, DateTime now)
		{
			var packet = new Packet(Op.ZC_LOGIN_TIME);
			packet.PutLong(now.ToUnixTimeSeconds() * 1000);

			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_IES_MODIFY_LIST to connection, containing a list of
		/// modifications for IES files.
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_IES_MODIFY_LIST(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_IES_MODIFY_LIST);

			packet.PutShort(1); // count
			{
				packet.PutLpString("SharedConst");
				packet.PutShort(2); // row count
				{
					packet.PutInt(251);
					packet.PutShort(1); // col count
					{
						packet.PutLpString("Value");
						packet.PutShort(5); // patch count
						{
							packet.PutInt(6);
							packet.PutLpString("0");
							packet.PutLpString("0.00");
							packet.PutLpString("YEJI");
							packet.PutLpString("2016-3-30 3:15");
							packet.PutLpString("Change By Tool");

							packet.PutInt(5);
							packet.PutLpString("0");
							packet.PutLpString("0.00");
							packet.PutLpString("YEJI");
							packet.PutLpString("2016-3-30 3:15");
							packet.PutLpString("Change By Tool");

							packet.PutInt(4);
							packet.PutLpString("0");
							packet.PutLpString("0.00");
							packet.PutLpString("YEJI");
							packet.PutLpString("2016-3-30 3:15");
							packet.PutLpString("Change By Tool");

							packet.PutInt(3);
							packet.PutLpString("0");
							packet.PutLpString("0.00");
							packet.PutLpString("YEJI");
							packet.PutLpString("2016-3-30 3:15");
							packet.PutLpString("Change By Tool");

							packet.PutInt(2);
							packet.PutLpString("0");
							packet.PutLpString("0.00");
							packet.PutLpString("YEJI");
							packet.PutLpString("2016-3-30 3:15");
							packet.PutLpString("Change By Tool");
						}
					}
				}
			}

			conn.Send(packet);
		}

		/// <summary>
		/// Broadcasts ZC_POSE in range of character, putting them into the
		/// given pose.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="pose"></param>
		public static void ZC_POSE(Character character, int pose)
		{
			var pos = character.Position;
			var dir = character.Direction;

			var packet = new Packet(Op.ZC_POSE);

			packet.PutInt(character.Handle);
			packet.PutInt(pose);
			packet.PutFloat(pos.X);
			packet.PutFloat(pos.Y);
			packet.PutFloat(pos.Z);
			packet.PutFloat(dir.Cos);
			packet.PutFloat(dir.Sin);

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Broadcasts ZC_MOVE_DIR in range of character, informing other
		/// characters about the movement.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		/// <param name="dx"></param>
		/// <param name="dy"></param>
		/// <param name="unkFloat"></param>
		public static void ZC_MOVE_DIR(IEntity entity, float x, float y, float z, float dx, float dy, float unkFloat)
		{
			var packet = new Packet(Op.ZC_MOVE_DIR);

			packet.PutInt(entity.Handle);
			packet.PutFloat(x);
			packet.PutFloat(y);
			packet.PutFloat(z);
			packet.PutFloat(dx);
			packet.PutFloat(dy);
			packet.PutByte(1); // 0 = reduced movement speed... walk mode?
			packet.PutFloat(entity.GetSpeed());
			packet.PutByte(1);
			packet.PutFloat(unkFloat);

			entity.Map.Broadcast(packet, entity);
		}

		/// <summary>
		/// Broadcasts ZC_MOVE_STOP in range of character, informing other
		/// characters about the movement stop.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		public static void ZC_MOVE_STOP(IEntity entity, float x, float y, float z)
		{
			var packet = new Packet(Op.ZC_MOVE_STOP);

			packet.PutInt(entity.Handle);
			packet.PutFloat(x);
			packet.PutFloat(y);
			packet.PutFloat(z);
			packet.PutByte(0);

			entity.Map.Broadcast(packet, entity);
		}

		/// <summary>
		/// Broadcasts ZC_PC_MOVE_STOP in range of character, informing other
		/// characters about the movement stop.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		public static void ZC_PC_MOVE_STOP(IEntity entity, Position position, Direction direction)
		{
			var packet = new Packet(Op.ZC_PC_MOVE_STOP);

			packet.PutInt(entity.Handle);
			packet.PutFloat(position.X);
			packet.PutFloat(position.Y);
			packet.PutFloat(position.Z);
			packet.PutByte(1);
			packet.PutFloat(direction.Cos);
			packet.PutFloat(direction.Sin);
			packet.PutFloat(4238.274f); // ?

			entity.Map.Broadcast(packet, entity);
		}

		/// <summary>
		/// Sends ZC_DIALOG_TRADE to connection, containing the name of the
		/// shop to open.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="shopName"></param>
		public static void ZC_DIALOG_TRADE(ChannelConnection conn, string shopName)
		{
			var packet = new Packet(Op.ZC_DIALOG_TRADE);

			packet.PutString(shopName, 33);

			conn.Send(packet);
		}

		/// Inform client that the skill is ready
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="id"></param>
		/// <param name="position1"></param>
		/// <param name="position2"></param>
		public static void ZC_SKILL_READY(IEntity entity, int id, Position position1, Position position2)
		{
			if (!(entity is Character))
				return;

			var packet = new Packet(Op.ZC_SKILL_READY);
			packet.PutInt(entity.Handle);
			packet.PutInt(id);
			packet.PutFloat(1);
			packet.PutBinFromHex("01 39 EC C0");
			packet.PutFloat(1);
			packet.PutFloat(position1.X);
			packet.PutFloat(position1.Y);
			packet.PutFloat(position1.Z);
			packet.PutFloat(position2.X);
			packet.PutFloat(position2.Y);
			packet.PutFloat(position2.Z);

			((Character)entity).Connection.Send(packet);

		}

		/// <summary>
		/// Creates a skill in client
		/// </summary>
		/// <param name="character"></param>
		/// <param name="id"></param>
		/// <param name="position"></param>
		/// <param name="direction"></param>
		/// <param name="create"></param>
		public static void ZC_NORMAL_Skill(IEntity entity, Skill skill, Position position, Direction direction, bool create, int actorId)
		{
			//var actorId = 1234; // ActorId (entity unique id for this skill)
			//var distance = 20.0f; // Distance to caster? Not sure. Observed values (20, 40, 80)
			var skillState = 0; // skillState seems to be an ENUM of animation states (0 = initial animation, 1 = touched animation)
			if (!create)
				skillState = 1;

			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(0x57);
			packet.PutInt(entity.Handle);
			packet.PutInt(skill.GetData().EffectId);
			packet.PutInt(skill.Id); // SkillId
			packet.PutInt(2); // Skill Level ?
			packet.PutFloat(position.X);
			packet.PutFloat(position.Y);
			packet.PutFloat(position.Z);
			packet.PutFloat(direction.Cos);
			packet.PutFloat(direction.Sin);
			packet.PutBinFromHex("D40F49BF"); // Angle? 
			packet.PutFloat(0); // Height?
			packet.PutInt(actorId);
			packet.PutByte(create);
			packet.PutInt(skillState);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutBinFromHex("C80E27BA");
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(0);

			entity.Map.Broadcast(packet, entity);
		}

		/// <summary>
		/// Creates a particle effect (or set desired animation)
		/// </summary>
		/// <param name="character"></param>
		/// <param name="actorId"></param>
		/// <param name="enable"></param>
		public static void ZC_NORMAL_ParticleEffect(IEntity entity, int actorId, int enable)
		{
			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(0x61);
			packet.PutInt(actorId);
			packet.PutInt(enable);

			entity.Map.Broadcast(packet);
		}

		/// <summary>
		/// Unkown purpose yet. It could be a "target" packet. (this actor is targeting "id" actor
		/// </summary>
		/// <param name="character"></param>
		/// <param name="id"></param>
		/// <param name="position"></param>
		/// <param name="direction"></param>
		public static void ZC_NORMAL_Unkown_1c(IEntity entity, int id, Position position, Direction direction, Position position2)
		{
			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(0x1c);
			packet.PutInt(entity.Handle); // This is not a fixed value, check more packets
			packet.PutByte(0);
			packet.PutBinFromHex("44 D7 76 10"); // Effect? BuffID?
			packet.PutInt(id); // Target ActorId (seems to be)
			packet.PutFloat(position.X);
			packet.PutFloat(position.Y);
			packet.PutFloat(position.Z);
			packet.PutFloat(direction.Cos);
			packet.PutFloat(direction.Sin);
			packet.PutFloat(position2.X);
			packet.PutFloat(position2.Y);
			packet.PutFloat(position2.Z);

			entity.Map.Broadcast(packet, entity);
		}

		/// <summary>
		/// Seems to be a SKILLS end with "_ANI" , which I guess is just a "skill animation" but with no real calculation in server side. (doesnt hit anything)
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_NORMAL_Unkown_3f(IEntity entity, Skill skill, Direction dir)
		{
			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(0x3f);
			packet.PutInt(entity.Handle);
			packet.PutInt(skill.Id);
			packet.PutInt(entity.Handle);
			packet.PutFloat(dir.Cos);
			packet.PutFloat(dir.Sin);
			packet.PutInt(1);
			packet.PutFloat(700.0f);
			packet.PutFloat(1.0f);
			packet.PutInt(1);
			packet.PutBinFromHex("02 01 00 00"); // This is not a fixed value, check more packets
			packet.PutFloat(1.0f);
			packet.PutFloat(0.0f);
			packet.PutFloat(512.0f);
			packet.PutFloat(0.0f);
			entity.Map.Broadcast(packet, entity);
		}

		/// <summary>
		/// Unkown purpose yet.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_NORMAL_Unkown_40(Character character)
		{
			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(0x40);
			packet.PutInt(character.Handle);
			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Popup message in top of character
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_NORMAL_Unkown_3a(IEntity entity, string msg1, string msg2)
		{
			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(0x3a);
			packet.PutInt(entity.Handle);
			packet.PutShort((short)(msg1.Length + 1));
			packet.PutString(msg1);
			packet.PutShort((short)(msg2.Length + 1));
			packet.PutString(msg2);
			entity.Map.Broadcast(packet, entity);
		}

		/// <summary>
		/// Unkown purpose yet. Something about charging a skill ?
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_NORMAL_Unkown_4d(Character character, int skillId)
		{
			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(0x4d);
			packet.PutInt(character.Handle);
			packet.PutInt(skillId);
			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Set a Range type "FAN" shape in a given position
		/// </summary>
		/// <param name="character"></param>
		/// <param name="id"></param>
		/// <param name="position"></param>
		/// <param name="direction"></param>
		public static void ZC_SKILL_RANGE_FAN(IEntity entity, Position position, Direction direction, float range, float angle)
		{
			var packet = new Packet(Op.ZC_SKILL_RANGE_FAN);
			packet.PutInt(entity.Handle);
			packet.PutByte(1); // Flag
			packet.PutByte(1); // Flag
			packet.PutFloat(position.X);
			packet.PutFloat(position.Y);
			packet.PutFloat(position.Z);
			packet.PutFloat(direction.Cos);
			packet.PutFloat(direction.Sin);
			packet.PutFloat(30f); // Angle or Range?  Probably RANGE. (30 units?)
			packet.PutFloat(0.174533f); // Degree angle to Radian angle (30 degrees = 0.174533f)

			entity.Map.Broadcast(packet, entity);
		}

		/// <summary>
		/// Set a Range type "SQUARE" shape in a given position
		/// </summary>
		/// <param name="character"></param>
		/// <param name="id"></param>
		/// <param name="position"></param>
		/// <param name="direction"></param>
		public static void ZC_SKILL_RANGE_SQUARE(IEntity entity, Position position, Position position2) 
		{
			var packet = new Packet(Op.ZC_SKILL_RANGE_SQUARE);
			packet.PutInt(entity.Handle);
			packet.PutShort(0);
			packet.PutFloat(position.X);
			packet.PutFloat(position.Y);
			packet.PutFloat(position.Z);
			packet.PutFloat(position2.X);
			packet.PutFloat(position2.Y);
			packet.PutFloat(position2.Z);
			packet.PutFloat(14.0f);

			entity.Map.Broadcast(packet, entity);
		}

		/// <summary>
		/// Set a Range type "CIRCLE" shape in a given position
		/// </summary>
		/// <param name="character"></param>
		/// <param name="id"></param>
		/// <param name="position"></param>
		/// <param name="direction"></param>
		public static void ZC_SKILL_RANGE_CIRCLE(IEntity entity, Position position, float radius)
		{
			var packet = new Packet(Op.ZC_SKILL_RANGE_CIRCLE);
			packet.PutInt(entity.Handle);
			packet.PutFloat(position.X);
			packet.PutFloat(position.Y);
			packet.PutFloat(position.Z);
			packet.PutFloat(radius);

			entity.Map.Broadcast(packet, entity);
		}

		

		/// <summary>
		/// Enables/disables creature attack state
		/// </summary>
		/// <param name="character"></param>
		/// <param name="attacking"></param>
		public static void ZC_PC_ATKSTATE(IEntity entity, bool attacking)
		{
			var packet = new Packet(Op.ZC_PC_ATKSTATE);
			packet.PutInt(entity.Handle);
			packet.PutByte(attacking);

			entity.Map.Broadcast(packet);
		}

		/// <summary>
		/// Updates creature's SP
		/// </summary>
		/// <param name="character"></param>
		/// <param name="spValue"></param>
		public static void ZC_UPDATE_SP(Character character, short spValue)
		{
			var packet = new Packet(Op.ZC_UPDATE_SP);
			packet.PutInt(character.Handle);
			packet.PutShort(spValue);
			packet.PutShort(0);
			packet.PutByte(0);

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Update creature basic stats (hp, mp)
		/// </summary>
		/// <param name="character"></param>
		/// <param name="currentHP"></param>
		/// <param name="maxHP"></param>
		/// <param name="currentSP"></param>
		/// <param name="maxSP"></param>
		public static void ZC_UPDATE_ALL_STATUS(Character character, int currentHP, int maxHP, short currentSP, short maxSP)
		{
			var packet = new Packet(Op.ZC_UPDATE_ALL_STATUS);
			packet.PutInt(character.Handle);
			packet.PutInt(currentHP);
			packet.PutInt(maxHP);
			packet.PutShort(currentSP);
			packet.PutShort(maxSP);
			packet.PutShort(0);
			packet.PutShort(0);

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Increases player experience by killing monsters
		/// </summary>
		/// <param name="character"></param>
		/// <param name="experience"></param>
		/// <param name="jobExperience"></param>
		/// <param name="monsterActorId"></param>
		public static void ZC_EXP_UP_BY_MONSTER(Character character, int experience, int jobExperience, int monsterActorId)
		{
			var packet = new Packet(Op.ZC_EXP_UP_BY_MONSTER);
			packet.PutInt(experience);
			packet.PutInt(jobExperience);
			packet.PutInt(monsterActorId);

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Heals creature's HP
		/// </summary>
		/// <param name="character"></param>
		/// <param name="amountHealed"></param>
		/// <param name="maxHP"></param>
		public static void ZC_HEAL_INFO(Character character, int amountHealed, int currentHP)
		{
			var packet = new Packet(Op.ZC_HEAL_INFO);
			packet.PutInt(character.Handle);
			packet.PutInt(amountHealed);
			packet.PutInt(currentHP);
			packet.PutInt(1); // It increments.. 1 by 1.. in every HEAL during the entire session. Check if it starts in 1 every time player logins.
			packet.PutInt(0); // 00007411 observed
			packet.PutInt(0);  // 000138BC observed

			character.Map.Broadcast(packet);
		}

		/// <summary>
		/// Adds HP to character
		/// </summary>
		/// <param name="character"></param>
		/// <param name="amountHealed"></param>
		/// <param name="maxHP"></param>
		public static void ZC_ADD_HP(Character character, int amountAdded)
		{
			var packet = new Packet(Op.ZC_ADD_HP);
			packet.PutInt(character.Handle);
			packet.PutInt(amountAdded);
			packet.PutInt(character.Hp);
			packet.PutInt(1); // It increments.. 1 by 1.. in every HEAL during the entire session. Check if it starts in 1 every time player logins.

			character.Map.Broadcast(packet);
		}

		/// <summary>
		/// Reply packet when skill melee ground is placed
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_SKILL_MELEE_GROUND(IEntity entity, Skill skill)
		{
			var packet = new Packet(Op.ZC_SKILL_MELEE_GROUND);
			packet.PutInt(skill.Id);
			packet.PutInt(entity.Handle);
			packet.PutFloat(skill.Direction.Cos);
			packet.PutFloat(skill.Direction.Sin);
			packet.PutInt(2);
			packet.PutFloat(skill.GetData().ShootTime); // Shoot time? (if this is too low, the skill animation doesnt show up)
			packet.PutFloat(1);
			packet.PutInt(1);
			packet.PutBinFromHex("47 21 3E 00");
			packet.PutFloat(1);
			packet.PutFloat(skill.Position.X);
			packet.PutFloat(skill.Position.Y);
			packet.PutFloat(skill.Position.Z);
			packet.PutShort(0); // Some sort of Size for something else. Since this is a "variable size" packet.

			entity.Map.Broadcast(packet, entity);
		}

		/// <summary>
		/// Reply packet when skill melee target is casted. Character makes animation of skill (to broadcast to other players the actionprobably!)
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_SKILL_MELEE_TARGET(Character character, int skillId, Position position, Direction direction)
		{
			var packet = new Packet(Op.ZC_SKILL_MELEE_GROUND);
			packet.PutInt(skillId);
			packet.PutInt(character.Handle);
			packet.PutFloat(direction.Cos);
			packet.PutFloat(direction.Sin);
			packet.PutBinFromHex("01 B1 43 68");
			packet.PutFloat(1000);
			packet.PutFloat(1);
			packet.PutBinFromHex("01 3A D9 01");
			packet.PutFloat(0);
			packet.PutFloat(1);
			packet.PutInt(3015); // C7 0B 00 00
			packet.PutByte(0);

			character.Map.Broadcast(packet, character);


		}

		/// <summary>
		/// removes buff icon in buffs bar 
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_BUFF_REMOVE(IEntity entity, SkillEffect effect)
		{
			var packet = new Packet(Op.ZC_BUFF_REMOVE);
			packet.PutInt(entity.Handle);
			packet.PutInt(effect.Data.EffectId); // 43 00 00 00
			packet.PutByte(0);
			packet.PutInt(effect.Handle); // Buff handle.  (but not related to the buff skill itself)

			entity.Map.Broadcast(packet, entity);

		}

		/// <summary>
		/// Add/Updates buff information in buffs bar 
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_BUFF_ADD(IEntity entity, SkillEffect effect, bool update)
		{

			var packet = (update) ? new Packet(Op.ZC_BUFF_UPDATE) : new Packet(Op.ZC_BUFF_ADD);

			packet.PutInt(entity.Handle);
			packet.PutInt(effect.Data.EffectId);
			packet.PutInt(effect.skillComp.skill.level);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(effect.stackLevel);
			int lifeMilis = 0;
			if (effect.Data.LifeTime > 0) {
				TimeSpan milisDiff = effect.expireTime - DateTime.Now;
				lifeMilis = (int)milisDiff.TotalMilliseconds;
			}
			packet.PutInt(lifeMilis);
			if (entity is Character)
			{
				packet.PutShort((short)(((Character)entity).Name.Length + 1));
				packet.PutString(((Character)entity).Name);
			} else
			{
				string entityName = "Test";
				packet.PutShort((short)(entityName.Length + 1));
				packet.PutString(entityName);
			}
			//packet.PutInt(character.Handle); // For some reason, I found this packet when logging packet from official... but doesnt work if commented out
			packet.PutInt(effect.Handle); // Buff Handle. (but not related to the buff skill itself)

			entity.Map.Broadcast(packet, entity);

		}



		/// <summary>
		/// Set effect in player
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_NORMAL_11(Character character)
		{
			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(0x11);
			packet.PutInt(character.Handle);
			packet.PutShort(8476); // Skill 20004 (permanent effect aura)
			packet.PutShort(39);
			packet.PutFloat(3); // Effect size
			packet.PutInt(2);
			packet.PutEmptyBin(4);
			packet.PutFloat(0);
			packet.PutEmptyBin(4);

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// xxxx
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_NORMAL_14(Character character)
		{
			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(0x14);
			packet.PutInt(character.Handle);
			packet.PutByte(1);
			packet.PutInt(2);
			packet.PutByte(0);
			packet.PutFloat(1); // Effect size
			packet.PutBinFromHex("BE 8F 06 00");
			packet.PutEmptyBin(4);

			character.Map.Broadcast(packet, character);
		}

		public static void ZC_NORMAL_19(Character character)
		{
			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(0x19);
			packet.PutInt(character.Handle);
			packet.PutByte(1);
			packet.PutBinFromHex("1C 21 27 00");

			character.Map.Broadcast(packet, character);
		}

		public static void DUMMY(ChannelConnection conn)
		{
		}
	}

	public class MsgParameter
	{
		public string Key { get; protected set; }
		public string Value { get; protected set; }

		public MsgParameter(string key, string value)
		{
			this.Key = key;
			this.Value = value;
		}
	}
}
