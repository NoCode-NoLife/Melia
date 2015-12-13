// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Channel.Network.Helpers;
using Melia.Channel.World;
using Melia.Shared.Const;
using Melia.Shared.Network;
using Melia.Shared.Network.Helpers;
using Melia.Shared.Util;
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
			packet.PutInt(1292150020);
			packet.PutByte(3); // isGM (< 3)?
			packet.PutEmptyBin(10);

			packet.PutLpString(conn.SessionKey);

			// [i10911? (2015-12-01)]
			// Not sure when exactly this was added, skipped a few updates.
			{
				packet.PutShort(0xFB31); // ?
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

			packet.PutInt(1); // count
			{
				packet.PutShort((short)conn.SelectedCharacter.Job);
				packet.PutInt(0); // 1270153646, 2003304878
				packet.PutInt(0);
				packet.PutShort(1);
			}

			conn.Send(packet);
		}

		public static void ZC_MYPC_ENTER(Character character)
		{
			var packet = new Packet(Op.ZC_MYPC_ENTER);

			packet.PutFloat(character.Position.X);
			packet.PutFloat(character.Position.Y);
			packet.PutFloat(character.Position.Z);

			character.Connection.Send(packet);
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
				packet.PutLong(character.Connection.Account.Id);
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

		/// <summary>
		/// Broadcasts ZC_ENTER_MONSTER on monster's map.
		/// </summary>
		/// <param name="monster"></param>
		public static void ZC_ENTER_MONSTER(Monster monster)
		{
			var packet = new Packet(Op.ZC_ENTER_MONSTER);
			packet.AddMonster(monster);

			monster.Map.Broadcast(packet);
		}

		/// <summary>
		/// Sends ZC_ENTER_MONSTER to connection.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="monster"></param>
		public static void ZC_ENTER_MONSTER(ChannelConnection conn, Monster monster)
		{
			var packet = new Packet(Op.ZC_ENTER_MONSTER);
			packet.AddMonster(monster);

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

		public static void ZC_OPTION_LIST(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_OPTION_LIST);

			packet.PutString(conn.Account.Settings.ToString());

			conn.Send(packet);
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
			packet.PutFloat(0); // Display time in seconds, min cap 5s
			packet.PutString(message);

			character.Map.Broadcast(packet);
		}

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
			packet.AddCommander(character);

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
				ObjectProperty.PC.NowWeight, ObjectProperty.PC.MaxWeight,
				ObjectProperty.PC.StatByLevel, ObjectProperty.PC.StatByBonus, ObjectProperty.PC.UsedStat
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

					case ObjectProperty.PC.StatByLevel: packet.PutFloat(character.StatByLevel); break;
					case ObjectProperty.PC.StatByBonus: packet.PutFloat(character.StatByBonus); break;
					case ObjectProperty.PC.UsedStat: packet.PutFloat(character.UsedStat); break;

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

		public static void ZC_DIALOG_OK(ChannelConnection conn, string msg)
		{
			var packet = new Packet(Op.ZC_DIALOG_OK);

			packet.PutInt(0); // handle?
			packet.PutString(msg);

			conn.Send(packet);
		}

		public static void ZC_DIALOG_NEXT(ChannelConnection conn, string msg)
		{
			var packet = new Packet(Op.ZC_DIALOG_OK);

			packet.PutInt(0); // handle?
			packet.PutString(msg);

			conn.Send(packet);
		}

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

		public static void ZC_DIALOG_CLOSE(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_DIALOG_CLOSE);
			conn.Send(packet);
		}

		public static void ZC_DIALOG_STRINGINPUT(ChannelConnection conn, string msg)
		{
			var packet = new Packet(Op.ZC_DIALOG_STRINGINPUT);

			packet.PutInt(0); // handle?
			packet.PutString(msg);

			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_DIALOG_NUMBERRANGE over connection.
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

		// TODO: We could use an interface for entities, characters probably
		//   use this packet as well.
		public static void ZC_LEAVE(Monster monster)
		{
			var packet = new Packet(Op.ZC_LEAVE);

			packet.PutInt(monster.Handle);
			packet.PutShort(0);

			monster.Map.Broadcast(packet);
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
		/// Broadcasts ZC_DEAD on map, which kills the given entities visually.
		/// </summary>
		/// <remarks>
		/// I think this is wrong... it's probably not a list.
		/// </remarks>
		/// <param name="entities">List of entities to kill visually.</param>
		public static void ZC_DEAD(Map map, params IEntity[] entities)
		{
			if (entities == null || entities.Length == 0)
				throw new ArgumentException("Monster list is empty.");

			var packet = new Packet(Op.ZC_DEAD);
			foreach (var entity in entities)
				packet.PutInt(entity.Handle);
			packet.PutInt(0);

			map.Broadcast(packet);
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
		public static void ZC_SKILL_HIT_INFO(IEntity attacker, IEntity target, int damage)
		{
			var packet = new Packet(Op.ZC_SKILL_HIT_INFO);
			packet.PutInt(attacker.Handle);
			packet.PutByte(1); // Count?
			packet.PutShort(26057);
			packet.PutShort(5236);
			packet.PutInt(target.Handle);
			packet.PutInt(damage);
			packet.PutInt(target.Hp);
			packet.PutInt(2);
			packet.PutBinFromHex("00 00 01 E3 A0 D0 03 00 00 A0 60 FC 4A 01 00 00 64 00 02 01 00 00 01 5C 00 00 00 00 00 00 00 03 00 00 00 60");

			target.Map.Broadcast(packet);
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

			character.Map.Broadcast(packet);
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

			character.Map.Broadcast(packet);
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

			character.Map.Broadcast(packet);
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

			character.Map.Broadcast(packet);
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

			character.Map.Broadcast(packet);
		}

		/// <summary>
		/// Adds exp.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="exp"></param>
		public static void ZC_EXP_UP(Character character, int exp)
		{
			var packet = new Packet(Op.ZC_EXP_UP);
			packet.PutInt(exp);
			packet.PutInt(0); // jobExp?

			character.Map.Broadcast(packet);
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

			character.Map.Broadcast(packet);
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
			packet.PutFloat(0);
			packet.PutByte(1);
			packet.PutString(msg);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// ?
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

			entity.Map.Broadcast(packet);
		}

		public static void ZC_LOGIN_TIME(Character character)
		{
			var packet = new Packet(Op.ZC_LOGIN_TIME);
			packet.PutLong(DateTime.Now.ToUnixTimeSeconds() * 1000);

			character.Connection.Send(packet);
		}

		public static void ZC_IES_MODIFY_LIST(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_IES_MODIFY_LIST);

			packet.PutShort(1); // count
			{
				packet.PutLpString("SharedConst");
				packet.PutShort(2); // row count
				{
					packet.PutInt(250);
					packet.PutShort(1); // col count
					{
						packet.PutLpString("Value");
						packet.PutShort(1); // patch count
						{
							packet.PutInt(10);
							packet.PutLpString("1");
							packet.PutLpString("8.00");
							packet.PutLpString("YEJI");
							packet.PutLpString("2015-11-2");
							packet.PutLpString("Change By Tool");
						}
					}

					packet.PutInt(251);
					packet.PutShort(1); // col count
					{
						packet.PutLpString("Value");
						packet.PutShort(1); // patch count
						{
							packet.PutInt(9);
							packet.PutLpString("1");
							packet.PutLpString("8.00");
							packet.PutLpString("YEJI");
							packet.PutLpString("2015-11-2");
							packet.PutLpString("Change By Tool");
						}
					}
				}
			}

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
