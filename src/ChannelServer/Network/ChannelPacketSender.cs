// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Channel.World;
using Melia.Shared.Const;
using Melia.Shared.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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

		public static void ZC_CONNECT_OK(ChannelConnection conn, Character character)
		{
			var packet = new Packet(Op.ZC_CONNECT_OK);

			packet.PutByte(0); // gameMode 0 = NormalMode, 1 = SingleMode
			packet.PutInt(0);
			packet.PutByte(3); // isGM (< 3)?
			packet.PutEmptyBin(10);

			packet.PutShort(0); // count v ?
			//packet.PutEmptyBin(0);

			packet.PutInt(character.Handle);
			packet.PutInt(0);

			// Commander
			{
				packet.PutString(character.Name, 65);
				packet.PutString(character.TeamName, 64);
				packet.PutEmptyBin(7);
				packet.PutLong(0); // Account ID
				packet.PutShort(character.Stance);
				packet.PutShort(0);
				packet.PutShort((short)character.Job);
				packet.PutByte((byte)character.Gender);
				packet.PutByte(0);
				packet.PutInt(character.Level);

				// Equipment
				foreach (var id in character.Inventory.GetEquipIds())
					packet.PutInt(id);

				packet.PutShort(character.Hair);
				packet.PutShort(0); // Pose
			}

			packet.PutFloat(character.Position.X);
			packet.PutFloat(character.Position.Y);
			packet.PutFloat(character.Position.Z);
			packet.PutInt(character.Exp);
			packet.PutInt(character.MaxExp);
			packet.PutInt(character.Handle);

			packet.PutLong(character.Id);
			packet.PutLong(0); // PCEtc GUID? socialInfoId

			packet.PutInt(character.Hp);
			packet.PutInt(character.MaxHp);
			packet.PutShort(character.Sp);
			packet.PutShort(character.MaxSp);
			packet.PutInt(character.Stamina);
			packet.PutInt(character.Stamina); // MaxStamina
			packet.PutShort(0); // Shield
			packet.PutShort(0); // MaxShield

			packet.PutByte(0);
			packet.PutEmptyBin(3);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(0);

			conn.Send(packet);
		}

		public static void ZC_START_GAME(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_START_GAME);

			packet.PutFloat(1); // Affects the speed of everything happening in the client o.o
			packet.PutFloat(1); // serverAppTimeOffset
			packet.PutFloat(1); // globalAppTimeOffset
			packet.PutLong(DateTime.Now.Add(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now)).ToFileTime());

			conn.Send(packet);
		}

		public static void ZC_START_INFO(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_START_INFO);

			packet.PutInt(1); // ?
			packet.PutShort((short)conn.SelectedCharacter.Job);
			packet.PutInt(0); // ?
			packet.PutInt(0); // ?
			packet.PutShort(1); // ?

			conn.Send(packet);
		}

		public static void ZC_MYPC_ENTER(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_MYPC_ENTER);

			packet.PutFloat(0); // X
			packet.PutFloat(0); // Y
			packet.PutFloat(0); // Z

			conn.Send(packet);
		}

		public static void ZC_ENTER_PC(Character character)
		{
			var packet = new Packet(Op.ZC_ENTER_PC);

			packet.PutInt(character.Handle);
			packet.PutFloat(character.Position.X);
			packet.PutFloat(character.Position.Y);
			packet.PutFloat(character.Position.Z);
			packet.PutFloat(1);
			packet.PutInt(0);
			packet.PutShort(0);
			packet.PutLong(character.Id + 1); // PCEtc GUID? socialInfoId
			packet.PutByte(0); // Pose
			packet.PutFloat(31); // Move speed
			packet.PutInt(0);
			packet.PutInt(character.Hp);
			packet.PutInt(character.MaxHp);
			packet.PutShort(character.Sp);
			packet.PutShort(character.MaxSp);
			packet.PutInt(character.Stamina);
			packet.PutInt(character.Stamina); // MaxStamina
			packet.PutByte(0);
			packet.PutShort(0);
			packet.PutInt(-1); // titleAchievmentId
			packet.PutInt(0);
			packet.PutByte(0);
			// Commander
			{
				packet.PutString(character.Name, 65);
				packet.PutString(character.TeamName, 64);
				packet.PutEmptyBin(7);
				packet.PutLong(character.Connection.SessionId); // Account ID
				packet.PutShort(character.Stance);
				packet.PutShort(0);
				packet.PutShort((short)character.Job);
				packet.PutByte((byte)character.Gender);
				packet.PutByte(0);
				packet.PutInt(character.Level);

				// Equipment
				foreach (var id in character.Inventory.GetEquipIds())
					packet.PutInt(id);

				packet.PutShort(character.Hair);
				packet.PutShort(0); // Pose
			}
			packet.PutString("None", 49); // Party name

			character.Connection.Send(packet);
		}

		public static void ZC_ENTER_MONSTER(ChannelConnection conn, Monster monster)
		{
			var packet = new Packet(Op.ZC_ENTER_MONSTER);

			packet.PutInt(monster.Handle);
			packet.PutFloat(monster.Position.X);
			packet.PutFloat(monster.Position.Y);
			packet.PutFloat(monster.Position.Z);
			packet.PutFloat(monster.Direction.X);
			packet.PutFloat(monster.Direction.Y);
			packet.PutByte((byte)monster.NpcType); // 0~2,  0: friendly?, 1: monster, 2: NPC
			packet.PutByte(0); // bool ?
			packet.PutInt(monster.Hp);
			packet.PutInt(monster.MaxHp);
			packet.PutShort(0);
			packet.PutFloat(0);
			// MONSTER
			{
				packet.PutInt(monster.Id);
				packet.PutInt(0);
				packet.PutInt(monster.MaxHp);
				packet.PutShort(0); // MaxShield?
				packet.PutEmptyBin(2);
				packet.PutInt(monster.Level);
				packet.PutInt(monster.SDR);
				packet.PutByte(0);
				packet.PutEmptyBin(3);
			}
			packet.PutInt(0); // GenType
			packet.PutInt(0);
			//packet.PutShort(0); // parameters size
			// it was, like this in IDA o.o
			packet.PutByte(0); // parameters size
			packet.PutByte(0); // ??

			packet.PutStringWithLength(monster.Name);
			packet.PutStringWithLength(""); // UniqueName
			packet.PutStringWithLength(monster.DialogName); // if string is set - HP isn't shown, and talking activated
			packet.PutStringWithLength(""); // str2
			packet.PutStringWithLength(""); // str3

			packet.PutEmptyBin(0); // parameters

			conn.Send(packet);
		}

		public static void ZC_QUICK_SLOT_LIST(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_QUICK_SLOT_LIST);

			packet.PutInt(0);
			packet.PutShort(0);
			//...

			conn.Send(packet);
		}

		private static void AddSkill(this Packet packet, int skillId)
		{
			packet.PutLong(0); // skill object id (can be used to change skill properties with ZC_OBJECT_PROPERTY)
			packet.PutInt(skillId);
			packet.PutShort(6 * 1); // properties size
			packet.PutEmptyBin(2); // alignment
			packet.PutInt(0); // ?
			packet.PutShort(0); // ?
			packet.PutEmptyBin(2); // alignment
			// Properties
			packet.PutShort(4031); // Level
			packet.PutFloat(1);
			/*
			packet.PutShort(4020); // 
			packet.PutFloat(0);
			packet.PutShort(4024); // 
			packet.PutFloat(0);
			packet.PutShort(4023); // 
			packet.PutFloat(100);
			packet.PutShort(4021); // 
			packet.PutFloat(40);
			packet.PutShort(4030); // 
			packet.PutFloat(24);
			packet.PutShort(4105); // 
			packet.PutFloat(0);
			packet.PutShort(4147); // 
			packet.PutFloat(0);
			packet.PutShort(4157); // 
			packet.PutFloat(3);
			packet.PutShort(4068); // 
			packet.PutFloat(0);
			packet.PutShort(4062); // 
			packet.PutFloat(1);
			packet.PutShort(4161); // 
			packet.PutFloat(0);
			packet.PutShort(4118); // 
			packet.PutFloat(0);
			packet.PutShort(4102); // 
			packet.PutFloat(100);
			packet.PutShort(4184); // 
			packet.PutFloat(0);
			packet.PutShort(4043); // 
			packet.PutFloat(25);
			packet.PutShort(4183); // 
			packet.PutFloat(0);
			packet.PutShort(4058); // 
			packet.PutFloat(0);
			packet.PutShort(4185); // 
			packet.PutFloat(0);
			packet.PutShort(4186); // 
			packet.PutFloat(1);
			 * */
		}

		public static void ZC_SKILL_LIST(Character character)
		{
			var packet = new Packet(Op.ZC_SKILL_LIST);
			var skills = new[] { 1, 101, 105, 108, 20, 3, 100, 10002, 10003 };

			packet.PutInt(character.Handle);
			packet.PutShort(skills.Length); // count

			packet.PutShort(0); // No compression
			//var zlibPct = new Packet(Op.ZC_SKILL_LIST);
			foreach (var skill in skills)
			{
				packet.AddSkill(skill);
			}
			//var buffer = new byte[zlibPct.Length];
			//zlibPct.Build(ref buffer, 0);
			//packet.PutZlib(buffer);

			character.Connection.Send(packet);
		}

		public static void ZC_SKILL_ADD(Character character, int skillId)
		{
			var packet = new Packet(Op.ZC_SKILL_ADD);

			packet.PutByte(0); // REGISTER_QUICK_SKILL ?
			packet.PutByte(0); // SKILL_LIST_GET ?
			packet.PutLong(0); // ?
			packet.AddSkill(skillId);

			character.Connection.Send(packet);
		}

		public static void ZC_SKILLMAP_LIST(Character character)
		{
			var packet = new Packet(Op.ZC_SKILLMAP_LIST);

			packet.PutInt(0); // ?

			character.Connection.Send(packet);
		}

		public static void ZC_OPTION_LIST(Character character)
		{
			var packet = new Packet(Op.ZC_OPTION_LIST);

			packet.PutByte(0); // ?

			character.Connection.Send(packet);
		}

		public static void ZC_ACHIEVE_POINT_LIST(Character character)
		{
			var packet = new Packet(Op.ZC_ACHIEVE_POINT_LIST);

			packet.PutInt(0); // ?

			character.Connection.Send(packet);
		}

		public static void ZC_CHAT_MACRO_LIST(Character character)
		{
			var packet = new Packet(Op.ZC_CHAT_MACRO_LIST);

			packet.PutInt(0); // ?

			character.Connection.Send(packet);
		}

		public static void ZC_UI_INFO_LIST(Character character)
		{
			var packet = new Packet(Op.ZC_UI_INFO_LIST);

			packet.PutInt(0); // ?
			packet.PutInt(0); // ?

			character.Connection.Send(packet);
		}

		public static void ZC_NPC_STATE_LIST(Character character)
		{
			var packet = new Packet(Op.ZC_NPC_STATE_LIST);

			packet.PutInt(0); // ?

			character.Connection.Send(packet);
		}

		public static void ZC_COOLDOWN_LIST(Character character)
		{
			var packet = new Packet(Op.ZC_COOLDOWN_LIST);

			packet.PutLong(0); // socialInfoId ?
			packet.PutInt(0); // ?

			character.Connection.Send(packet);
		}

		public static void ZC_JOB_PTS(Character character)
		{
			var packet = new Packet(Op.ZC_JOB_PTS);

			packet.PutShort((short)character.Job);
			packet.PutShort(1);

			character.Connection.Send(packet);
		}

		public static void ZC_ABILITY_LIST(Character character)
		{
			var packet = new Packet(Op.ZC_ABILITY_LIST);

			var abilities = new[] { 10001, 10003, 10009, 10012, 10013, 10014, 101001 };

			packet.PutInt(character.Handle);
			packet.PutShort(abilities.Length); // count
			packet.PutShort(0); // No compression (client handler tests this short for compression marker, comment this line if using compression)
			//var zlibPct = new Packet(Op.ZC_ABILITY_LIST);
			foreach (var ability in abilities)
			{
				packet.PutLong(0); // Some kind of GUID? o.O
				packet.PutInt(ability);
				packet.PutShort(6); // properties size (some abilities doesn't have properties, like weapon wielding)
				packet.PutShort(255); // ?
				packet.PutShort(25); //Level
				packet.PutFloat(10);
			}
			//var buffer = new byte[zlibPct.Length];
			//zlibPct.Build(ref buffer, 0);
			//packet.PutZlib(buffer);
			character.Connection.Send(packet);
		}


		public static void ZC_MOVE_SPEED(Character character)
		{
			var packet = new Packet(Op.ZC_MOVE_SPEED);

			packet.PutInt(character.Handle);
			packet.PutFloat(character.GetSpeed());
			packet.PutFloat(0);

			character.Connection.Send(packet); // Broadcast?
		}

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

		public static void ZC_ITEM_EQUIP_LIST(Character character)
		{
			var equip = character.Inventory.GetEquip();

			var packet = new Packet(Op.ZC_ITEM_EQUIP_LIST);

			foreach (var equipItem in equip)
			{
				packet.PutInt(equipItem.Value.Id);
				packet.PutShort(0); // Object size
				packet.PutEmptyBin(2);
				packet.PutLong(equipItem.Value.WorldId);
				packet.PutInt((int)equipItem.Key);
				packet.PutInt(0);
				//packet.PutEmptyBin(0); // Object
			}

			character.Connection.Send(packet);
		}

		public static void ZC_CHAT(Character character, string format, params object[] args)
		{
			ZC_CHAT(character, string.Format(format, args));
		}

		public static void ZC_CHAT(Character character, string message)
		{
			//char field_0[64];
			//char field_1[65];
			//char gap;
			//__int16 field_2;
			//int field_3;
			//char field_4;
			//char field_5;
			//char gap2[2];
			//int some_id;

			var packet = new Packet(Op.ZC_CHAT);

			packet.PutInt(character.Handle);
			packet.PutString("test team name", 64); // ?
			packet.PutString("test name", 65); // ?
			packet.PutByte(0);
			packet.PutShort((short)character.Job);
			packet.PutInt(0);
			packet.PutByte((byte)character.Gender);
			packet.PutByte((byte)character.Hair);
			packet.PutEmptyBin(2);
			packet.PutInt(0);
			packet.PutFloat(10); // Display time in seconds
			packet.PutString(message);

			character.Connection.Send(packet); // broadcast
		}

		public static void ZC_SYSTEM_MSG(Character character, int clientMessage, params MsgParameter[] parameters)
		{
			var packet = new Packet(Op.ZC_SYSTEM_MSG);

			packet.PutInt(clientMessage);
			packet.PutByte((byte)parameters.Length);
			packet.PutByte(1); // type? 0 = also show in red letters on the screen
			foreach (var parameter in parameters)
			{
				packet.PutStringWithLength(parameter.Key);
				packet.PutStringWithLength(parameter.Value);
			}

			character.Connection.Send(packet);
		}

		public static void ZC_JUMP(Character character)
		{
			var packet = new Packet(Op.ZC_JUMP);

			packet.PutInt(character.Handle);
			packet.PutFloat(character.GetJumpStrength());
			packet.PutInt(character.GetJumpType());
			packet.PutByte(1);  // 1 or 0

			character.Connection.Send(packet); // Broadcast
		}

		public static void ZC_REST_SIT(Character character)
		{
			var packet = new Packet(Op.ZC_REST_SIT);

			packet.PutInt(character.Handle);
			packet.PutByte(0);

			character.Connection.Send(packet); // broadcast
		}

		public static void ZC_ITEM_REMOVE(Character character, long worldId, int amount, InventoryItemRemoveMsg msg, InventoryType invType)
		{
			var packet = new Packet(Op.ZC_ITEM_REMOVE);

			packet.PutLong(worldId);
			packet.PutInt(amount);
			packet.PutByte((byte)msg);
			packet.PutByte((byte)invType);

			character.Connection.Send(packet);
		}

		public static void ZC_ITEM_INVENTORY_INDEX_LIST(Character character)
		{
			ZC_ITEM_INVENTORY_INDEX_LIST(character, character.Inventory.GetIndices());
		}

		public static void ZC_ITEM_INVENTORY_INDEX_LIST(Character character, InventoryCategory category)
		{
			ZC_ITEM_INVENTORY_INDEX_LIST(character, character.Inventory.GetIndices(category));
		}

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

		public static void ZC_UPDATED_PCAPPEARANCE(Character character)
		{
			var equip = character.Inventory.GetEquip();

			var packet = new Packet(Op.ZC_UPDATED_PCAPPEARANCE);

			packet.PutShort(character.Handle);
			packet.PutEmptyBin(2);
			packet.PutString(character.Name, 65);
			packet.PutString(character.TeamName, 64);
			packet.PutEmptyBin(7);
			packet.PutLong(0);
			packet.PutShort(character.Stance);
			packet.PutShort(0);
			packet.PutShort((short)character.Job);
			packet.PutByte((byte)character.Gender);
			packet.PutByte(0);
			packet.PutInt(character.Level);
			foreach (var equipItem in equip)
				packet.PutInt(equipItem.Value.Id);
			packet.PutByte(character.Hair);

			character.Connection.Send(packet); // Broadcast
		}

		public static void ZC_ITEM_ADD(Character character, Item item, int index, InventoryAddType addType)
		{
			var packet = new Packet(Op.ZC_ITEM_ADD);

			packet.PutLong(item.WorldId);
			packet.PutInt(item.Amount);
			packet.PutInt(index);
			packet.PutInt(item.Id);
			packet.PutShort(0); // Size of the object at the end
			packet.PutByte((byte)addType);
			packet.PutFloat(0); // Notification delay
			packet.PutByte(0); // InvType
			packet.PutByte(0);
			//packet.PutEmptyBin(0);

			character.Connection.Send(packet);
		}

		public static void ZC_MOVE_BARRACK(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_MOVE_BARRACK);
			conn.Send(packet);
		}

		public static void ZC_LOGOUT_OK(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_LOGOUT_OK);
			conn.Send(packet);
		}

		public static void ZC_CAMPINFO(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_CAMPINFO); // Size: 18 (12)
			packet.PutEmptyBin(12);
			conn.Send(packet);
		}

		public static void ZC_SET_POS(Character character)
		{
			var packet = new Packet(Op.ZC_SET_POS);

			packet.PutInt(character.Handle);
			packet.PutFloat(character.Position.X);
			packet.PutFloat(character.Position.Y);
			packet.PutFloat(character.Position.Z);

			character.Connection.Send(packet); // Broadcast
		}

		public static void ZC_MOVE_ZONE_OK(ChannelConnection conn, string ip, int port, int mapId)
		{
			//_BYTE gap0[6];
			//_DWORD dword6;
			//_DWORD dwordA;
			//_DWORD dwordE;
			//_DWORD dword12;
			//float float16;
			//float float1A;
			//_BYTE gap1E[26];
			//_BYTE byte38;

			var packet = new Packet(Op.ZC_MOVE_ZONE_OK); // Size: 57 (51)

			packet.PutInt(0);
			packet.PutInt(BitConverter.ToInt32(IPAddress.Parse(ip).GetAddressBytes(), 0));
			packet.PutInt(port);
			packet.PutInt(mapId);
			packet.PutFloat(38); // Camera X angle
			packet.PutFloat(45); // Camera Y angle
			packet.PutEmptyBin(26);
			packet.PutByte(0);

			conn.Send(packet);
		}

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
				packet.PutInt(0);
			}

			character.Connection.Send(packet); // Broadcast
		}

		public static void ZC_OBJECT_PROPERTY_Init(Character character)
		{
			ZC_OBJECT_PROPERTY(character,
				ObjectProperty.PC.HP, ObjectProperty.PC.MHP,
				ObjectProperty.PC.SP, ObjectProperty.PC.MSP,
				ObjectProperty.PC.STR, ObjectProperty.PC.CON, ObjectProperty.PC.INT, ObjectProperty.PC.MNA, ObjectProperty.PC.DEX,
				ObjectProperty.PC.NowWeight, ObjectProperty.PC.MaxWeight
			);
		}

		public static void ZC_OBJECT_PROPERTY(Character character, params short[] properties)
		{
			ZC_OBJECT_PROPERTY(character.Connection, character, properties);
		}

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

					case ObjectProperty.PC.STR: packet.PutFloat(character.Str); break;
					case ObjectProperty.PC.CON: packet.PutFloat(character.Con); break;
					case ObjectProperty.PC.INT: packet.PutFloat(character.Int); break;
					case ObjectProperty.PC.MNA: packet.PutFloat(character.Spr); break;
					case ObjectProperty.PC.DEX: packet.PutFloat(character.Dex); break;

					case ObjectProperty.PC.NowWeight: packet.PutFloat(character.NowWeight); break;
					case ObjectProperty.PC.MaxWeight: packet.PutFloat(character.MaxWeight); break;

					default: throw new ArgumentException("Unknown property '" + property + "'.");
				}
			}

			conn.Send(packet);
		}

		public static void ZC_ROTATE(Character character)
		{
			var packet = new Packet(Op.ZC_ROTATE);

			packet.PutInt(character.Handle);
			packet.PutFloat(character.Direction.X);
			packet.PutFloat(character.Direction.Y);
			packet.PutByte(0);
			packet.PutByte(0);

			character.Connection.Send(packet); // Broadcast
		}


		//var strings = new string[]
		//{
		//	"SIAUL_WEST_WEST_FOREST_dlg1",
		//	// SIAUL_WEST_WEST_FOREST_dlg1_Caption, QUEST_20150317_000047, Knight Titas
		//	// SIAUL_WEST_WEST_FOREST_dlg1_Caption_Text_2, QUEST_LV_0100_20150428_006701, )} {nl} If you have time, Please tell our troops to assemble.{nl}If you don't want to, you may just go ahead to Klaipeda.

		//	"SIAUL_WEST_WEST_FOREST",
		//	// SIAUL_WEST_KNIGHT_Name_QuestGroup, QUEST_20150317_001236, Talk To Knight Titas
		//	// SIAUL_WEST_WEST_FOREST_Name_0, QUEST_LV_0100_20150717_007623, To Knight Titas (2)

		//	"@dicID_^*$QUEST_LV_0100_20150428_006795$*^", // Alright, I will tell the troops to assemble
		//	"@dicID_^*$QUEST_LV_0100_20150317_002369$*^", // Reject











		public static void ZC_DIALOG_OK(ChannelConnection conn, string msg)
		{
			var packet = new Packet(Op.ZC_DIALOG_OK);

			packet.PutInt(0); // handle?
			packet.PutString(msg);

			conn.Send(packet);
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
