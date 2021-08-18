// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Melia.Channel.Network.Helpers;
using Melia.Channel.World;
using Melia.Shared.Const;
using Melia.Shared.Network;
using Melia.Shared.Network.Helpers;
using Melia.Shared.Util;
using Melia.Shared.World;
using Melia.Shared.World.ObjectProperties;

namespace Melia.Channel.Network
{
	public static class Send
	{
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
			packet.PutInt(1281523659); // was 1281523659 now 1277746433
			packet.PutByte(3); // isGM (< 3)?
			packet.PutEmptyBin(10);
			packet.PutInt(0);
			packet.PutShort(0);
			packet.PutInt(40588976); // 44266500
			packet.PutEmptyBin(10);

			// These bytes set the integrated and integrated dungeon server settings.
			packet.PutByte(0);
			packet.PutByte(0);

			packet.PutLpString(conn.SessionKey);
			packet.AddCommander(character);

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

			packet.PutInt(1); // count
			{
				packet.PutShort((short)conn.SelectedCharacter.JobId);
				packet.PutInt(0); // 1270153646, 2003304878
				packet.PutInt(0);
				packet.PutShort(1);
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
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutInt(0);

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
			packet.AddAppearancePc(character);
			packet.PutInt(0);
			packet.PutFloat(405494.3f);
			packet.PutByte(0);

			conn.Send(packet);
		}

		public static void ZC_SESSION_OBJ_ADD(ChannelConnection conn, SessionObject sessionObject)
		{
			var properties = sessionObject.Properties.GetAll();
			var propertiesSize = sessionObject.Properties.Size;

			var packet = new Packet(Op.ZC_SESSION_OBJ_ADD);
			packet.PutInt(sessionObject.Id);
			packet.PutInt(propertiesSize);
			packet.PutLong(sessionObject.ObjectId);
			packet.PutInt(0);
			packet.AddProperties(properties);
			packet.PutInt(sessionObject.Id);

			conn.Send(packet);
		}

		internal static void ZC_ANCIENT_CARD_RESET(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_ANCIENT_CARD_RESET);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(0);

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

			packet.PutInt(48);
			//packet.PutLong(conn.Account.Id);
			//packet.PutShort(0);
			packet.PutBinFromHex("63 60 52 F7 63 60 D0 33 62 60 38 13 C1 C8 30 20 80 39 FA 08 27 C3 77 43 88 0B 98 E3 80 9C 1F 30 4E 22 90 F3 13 C6 91 79 CD C9 F0 0B C6 79 2A C6 C5 F0 1B CA 19 10 57 8F 5A 4A DB 10 60 44 36 9E 09 99 C3 8C CC 61 00 00");
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
			var skills = character.Skills.GetList();

			var packet = new Packet(Op.ZC_SKILL_LIST);
			packet.PutInt(character.Handle);
			packet.PutShort(skills.Count());
			packet.PutByte(0);

			packet.Zlib(true, zpacket =>
			{
				foreach (var skill in skills)
					zpacket.AddSkill(skill);
			});
			packet.PutInt(PropertyId.Skill.ReadyTime);
			packet.PutFloat(0);
			packet.PutInt(PropertyId.Skill.SR);
			packet.PutFloat(0);
			packet.PutShort(PropertyId.Skill.BackHitRange);
			packet.PutByte(0);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Adds skill for character, by sending ZC_SKILL_ADD to its connection.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="skill"></param>
		public static void ZC_SKILL_ADD(Character character, Skill skill)
		{
			var packet = new Packet(Op.ZC_SKILL_ADD);

			packet.PutLong(character.Id);
			packet.PutByte(1); // REGISTER_QUICK_SKILL ?
			packet.PutByte(0); // SKILL_LIST_GET ?
			packet.PutLong(0); // ?
			packet.AddSkill(skill);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Allow character to use a skill again for character, by sending ZC_SKILL_READY to its connection.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="skillId"></param>
		public static void ZC_SKILL_READY(Character character, int skillId)
		{
			var packet = new Packet(Op.ZC_SKILL_READY);

			packet.PutInt(character.Handle);
			packet.PutInt(skillId);
			packet.PutFloat(1);
			packet.PutFloat(1.054772f);
			packet.PutInt(49920);
			packet.PutFloat(character.Position.X);
			packet.PutFloat(character.Position.Y);
			packet.PutFloat(character.Position.Z);
			packet.PutEmptyBin(12);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Cancel a skill cast, usually when a monster has died.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_SKILL_CAST_CANCEL(Character character)
		{
			var packet = new Packet(Op.ZC_SKILL_CAST_CANCEL);

			packet.PutInt(character.Handle);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Shows skill use for character, by sending ZC_SKILL_FORCE_TARGET to its connection.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="skillId"></param>
		public static void ZC_SKILL_FORCE_TARGET(Character character, IEntity target = null, int skillId = 1, int damage = -1)
		{
			var packet = new Packet(Op.ZC_SKILL_FORCE_TARGET);
			packet.PutInt(skillId);
			packet.PutInt(character.Handle);
			packet.PutFloat(character.Direction.Cos);
			packet.PutFloat(character.Direction.Sin);
			packet.PutInt(1);
			packet.PutFloat(521.4396f); // Skill Particle Distance?
			packet.PutFloat(1);
			packet.PutInt(0);
			packet.PutInt(character.Handle); // Attacker Handle?
			packet.PutFloat(1.054772f);
			packet.PutInt(0);
			if (target != null)
			{
				packet.PutInt(target.Handle);
			} else
			{
				packet.PutInt(0);
			}
			packet.PutFloat(0);
			packet.PutInt(1140850688);
			packet.PutInt(0);
			if (target != null && damage > 0)
			{
				packet.PutByte(1);
				packet.PutBinFromHex("00 09 00 00");
				packet.PutInt(target.Handle);
				packet.PutInt(damage);
				packet.PutInt(target.Hp);
				packet.PutInt(1); //attackCount?
				packet.PutFloat(0);
				packet.PutShort(0);
				packet.PutShort(3);
				packet.PutInt(1);
				packet.PutInt(0);
				packet.PutInt(549);
				packet.PutShort(0x63);
				packet.PutByte(2);
				packet.PutByte(1);
				packet.PutInt(0);
				packet.PutInt(character.Handle); // Attacker Handle?
				packet.PutInt(0);
				packet.PutShort(0);
				packet.PutShort(1);
				packet.PutByte(3);
				packet.PutFloat(-1845);
			} else
			{
				packet.PutByte(0);
			}

			character.Map.Broadcast(packet);
		}

		/// <summary>
		/// Shows skill use for character, by sending ZC_SKILL_MELEE_GROUND to its connection.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="skillId"></param>
		public static void ZC_SKILL_MELEE_GROUND(Character character, Skill skill, float targetX, float targetY, float targetZ, IEntity target = null, int damage = 0)
		{
			var packet = new Packet(Op.ZC_SKILL_MELEE_GROUND);
			packet.PutInt(skill.Id);
			packet.PutInt(character.Handle);
			packet.PutFloat(character.Direction.Cos);
			packet.PutFloat(character.Direction.Sin);
			packet.PutInt(1);
			packet.PutFloat(600f); // Range?
			packet.PutFloat(1);
			packet.PutInt(0);
			packet.PutInt((int)skill.ObjectId); // Attacker Handle?
			packet.PutFloat(1.083666f);
			if (target != null)
			{
				packet.PutInt(target.Handle);
			}
			else
			{
				packet.PutInt(0);
			}
			packet.PutFloat(targetX);
			packet.PutFloat(targetY);
			packet.PutFloat(targetZ);

			if (target != null && damage > 0)
			{
				packet.PutShort(1);

				packet.PutInt(0x900);
				packet.PutInt(target.Handle);
				packet.PutInt(damage);
				packet.PutInt(target.Hp);
				packet.PutLong(2);
				packet.PutShort(0);
				packet.PutShort(3);
				packet.PutLong(1);
				packet.PutLong(72622047229902898);
				packet.PutByte(0);
				packet.PutByte(0); // Attack Index
				packet.PutShort(0);
				packet.PutInt((int)skill.ObjectId); // Skill Handle
				packet.PutInt(0);
				packet.PutShort(0);
				packet.PutShort(1);
			} else
			{
				packet.PutShort(0);
			}

			character.Map.Broadcast(packet);
		}

		/// <summary>
		/// Sends overheat data for a character, by sending ZC_OVERHEAT_CHANGED.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="skillId"></param>
		public static void ZC_OVERHEAT_CHANGED(Character character, Skill skill)
		{
			var packet = new Packet(Op.ZC_OVERHEAT_CHANGED);

			packet.PutLong(character.Id);
			packet.PutInt(2255);
			packet.PutInt(100000);
			packet.PutInt(0);
			packet.PutInt(25000);
			packet.PutByte(0);
			packet.PutByte(0xFF);
			packet.PutByte(0xFF);
			packet.PutByte(0xFF);
			packet.PutLong(0);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sends skill to cooldown for a character, by sending ZC_COOLDOWN_CHANGED.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="skillId"></param>
		public static void ZC_COOLDOWN_CHANGED(Character character, Skill skill)
		{
			var packet = new Packet(Op.ZC_COOLDOWN_CHANGED);

			packet.PutLong(character.Id);
			packet.PutInt(skill.Id);
			packet.PutInt(500); // Cooldown value
			packet.PutInt(500); // Cooldown value
			packet.PutByte(0);

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

			packet.PutByte(0);
			//packet.PutString(conn.Account.Settings.ToString());

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
		/// Sends chat macros to the character.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_CHAT_MACRO_LIST(Character character)
		{
			var packet = new Packet(Op.ZC_CHAT_MACRO_LIST);

			var macros = character.Connection.Account.GetChatMacros();

			packet.PutInt(macros.Count());
			foreach (var macro in macros)
			{
				packet.PutInt(macro.Index);
				packet.PutString(macro.Message, 128);
				packet.PutInt(macro.Pose);
			}

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sends ZC_NPC_STATE_LIST to character.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_NPC_STATE_LIST(Character character)
		{
			var packet = new Packet(Op.ZC_NPC_STATE_LIST);

			if (character.MapId == 1021)
			{
				var npcIDs = new int[] { 4, 28, 2019, 2031, 2032 };
				packet.PutInt(npcIDs.Length); // count
				packet.Zlib(true, zpacket =>
				{
					for (int i = 0; i < npcIDs.Length; i++)
					{
						zpacket.PutInt(character.MapId);
						zpacket.PutInt(npcIDs[i]);
						zpacket.PutInt(1);
					}
				});
			}
			else
			{
				packet.PutInt(0); // count
				packet.PutShort(0);
			}

			// loop
			//   int mapId;
			//   int i1;
			//   int i2;

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

			packet.PutLong(character.Id); // socialInfoId ?
			packet.PutInt(0); // ?

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sends ZC_JOB_PTS to character, updating their job points.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="job"></param>
		public static void ZC_JOB_PTS(Character character, Job job)
		{
			var packet = new Packet(Op.ZC_JOB_PTS);

			packet.PutLong(character.Id);
			packet.PutShort((short)job.Id);
			packet.PutShort((short)job.SkillPoints);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sends ZC_ABILITY_LIST to character, containing a list of all
		/// their abilities.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_ABILITY_LIST(Character character)
		{
			// The abilities need a unique object id to appear properly,
			// otherwise their tooltip is the same for all of them.

			//var abilities = new[] { 10001, 10007, 10009, 10012, 10013, 10014 };
			//var abilityNames = ChannelServer.Instance.Data.JobDb.Find(character.Job).DefaultAbilities;
			//var abilities = ChannelServer.Instance.Data.AbilityDb.Where(a => abilityNames.Contains(a.ClassName)).Select(a => a.Id);
			//var objectId = 0xE1A9001690B2;
			var abilities = character.Abilities.GetList();

			var packet = new Packet(Op.ZC_ABILITY_LIST);
			packet.PutShort(0);
			packet.PutInt(1);
			packet.PutByte(0);
			/**
				packet.PutInt(character.Handle);
			packet.PutShort(abilities.Length);

			packet.Zlib(true, zpacket =>
			{
				foreach (var ability in abilities)
				{
					var properties = ability.Properties.GetAll();
					var propertiesSize = ability.Properties.Size;

					zpacket.PutLong(ability.ObjectId);
					zpacket.PutInt(ability.Id);
					zpacket.PutShort((short)propertiesSize);
					zpacket.PutShort(0);
					zpacket.AddProperties(properties);
				}
			});
			**/


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
			packet.PutLong(character.Id);

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Broadcasts ZC_CASTING_SPEED in range of character, updating their casting speed.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_CASTING_SPEED(Character character)
		{
			var packet = new Packet(Op.ZC_CASTING_SPEED);

			packet.PutInt(character.Handle);
			packet.PutFloat(character.GetCastingSpeed());
			packet.PutLong(character.Id);

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
			packet.Zlib(true, zpacket =>
			{
				foreach (var item in items)
				{
					var properties = item.Value.Properties.GetAll();
					var propertiesSize = item.Value.Properties.Size;

					zpacket.PutInt(item.Value.Id);
					zpacket.PutShort(propertiesSize);
					zpacket.PutEmptyBin(2);
					zpacket.PutLong(item.Value.ObjectId);
					zpacket.PutInt(item.Value.Amount);
					zpacket.PutInt(item.Value.Price);
					zpacket.PutInt(item.Key);
					zpacket.PutInt(1);
					zpacket.AddProperties(properties);
				}
			});

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sends ZC_ITEM_INVENTORY_DIVISION_LIST to character, containing a list of
		/// all items in their inventory.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_ITEM_INVENTORY_DIVISION_LIST(Character character)
		{
			var items = character.Inventory.GetItems();

			var packet = new Packet(Op.ZC_ITEM_INVENTORY_DIVISION_LIST);

			packet.PutInt(items.Count);
			packet.PutByte(1);
			packet.PutByte(1);
			if (items.Count != 0)
			{
				packet.Zlib(true, zpacket =>
				{
					foreach (var item in items)
					{
						var properties = item.Value.Properties.GetAll();
						var propertiesSize = item.Value.Properties.Size;

						zpacket.PutInt(item.Value.Id);
						zpacket.PutShort(propertiesSize);
						zpacket.PutEmptyBin(2);
						zpacket.PutLong(item.Value.ObjectId);
						zpacket.PutInt(item.Value.Amount);
						zpacket.PutInt(item.Value.Price);
						zpacket.PutInt(item.Key);
						zpacket.PutInt(1);
						zpacket.AddProperties(properties);
						zpacket.PutShort(0);
						zpacket.PutLong(item.Value.ObjectId);
						zpacket.PutShort(0);
					}
				});
			} else
			{
				packet.PutBinFromHex("8DFA020000000300");
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
				if (equipItem.Value.Id == 521101)
				{
					equipItem.Value.Properties.Add(new FloatProperty(PropertyId.Item.Dur, 3963f));
					equipItem.Value.Properties.Add(new FloatProperty(PropertyId.Item.MDEF, 19f));
					equipItem.Value.Properties.Add(new FloatProperty(PropertyId.Item.DEF, 19f));
					equipItem.Value.Properties.Add(new FloatProperty(PropertyId.Item.CoolDown, 0f));
					equipItem.Value.Properties.Add(new FloatProperty(PropertyId.Item.MaxSocket, 1f));
				}
				else if (equipItem.Value.Id == 101101)
				{
					equipItem.Value.Properties.Add(new FloatProperty(PropertyId.Item.Dur, 3331f));
					equipItem.Value.Properties.Add(new FloatProperty(PropertyId.Item.MINATK, 36f));
					equipItem.Value.Properties.Add(new FloatProperty(PropertyId.Item.MAXATK, 38f));
					equipItem.Value.Properties.Add(new FloatProperty(PropertyId.Item.CoolDown, 0f));
					equipItem.Value.Properties.Add(new FloatProperty(PropertyId.Item.MaxSocket, 0f));
				}
				else if (equipItem.Value.Id == 141101)
				{
					equipItem.Value.Properties.Add(new FloatProperty(PropertyId.Item.Dur, 3331f));
					equipItem.Value.Properties.Add(new FloatProperty(PropertyId.Item.MATK, 37f));
					equipItem.Value.Properties.Add(new FloatProperty(PropertyId.Item.CoolDown, 0f));
					equipItem.Value.Properties.Add(new FloatProperty(PropertyId.Item.MaxSocket, 0f));
				}
				else if (equipItem.Value.Id == 531101)
				{
					equipItem.Value.Properties.Add(new FloatProperty(PropertyId.Item.Dur, 3963f));
					equipItem.Value.Properties.Add(new FloatProperty(PropertyId.Item.MDEF, 19f));
					equipItem.Value.Properties.Add(new FloatProperty(PropertyId.Item.DEF, 19f));
					equipItem.Value.Properties.Add(new FloatProperty(PropertyId.Item.CoolDown, 0f));
					equipItem.Value.Properties.Add(new FloatProperty(PropertyId.Item.MaxSocket, 1f));
				}
				else if (equipItem.Value.Id == 521101)
				{
					equipItem.Value.Properties.Add(new FloatProperty(PropertyId.Item.Dur, 3963f));
					equipItem.Value.Properties.Add(new FloatProperty(PropertyId.Item.MDEF, 19f));
					equipItem.Value.Properties.Add(new FloatProperty(PropertyId.Item.DEF, 19f));
					equipItem.Value.Properties.Add(new FloatProperty(PropertyId.Item.CoolDown, 0f));
					equipItem.Value.Properties.Add(new FloatProperty(PropertyId.Item.MaxSocket, 1f));
				}
				var properties = equipItem.Value.Properties.GetAll();
				var propertiesSize = equipItem.Value.Properties.Size;

				packet.PutInt(equipItem.Value.Id);
				packet.PutInt(propertiesSize);
				if (equipItem.Value.Id >= 2 && equipItem.Value.Id <= 10 || equipItem.Value.Id == 10000 || equipItem.Value.Id == 11000 || equipItem.Value.Id == 9999996)
					packet.PutLong(0);
				else
					packet.PutLong(equipItem.Value.ObjectId);
				packet.PutInt((int)equipItem.Key);
				packet.PutInt(0);
				packet.PutShort(0);
				packet.AddProperties(properties);
				if (propertiesSize > 0)
				{
					packet.PutShort(0);
					packet.PutLong(equipItem.Value.ObjectId);
					packet.PutShort(0);
				}
			}

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Unequips an item and optionally shows a UI message.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="item"></param>
		/// <param name="message"></param>
		public static void ZC_EQUIP_ITEM_REMOVE(Character character, Item item, int message)
		{
			var packet = new Packet(Op.ZC_EQUIP_ITEM_REMOVE);
			packet.PutLong(item.ObjectId);

			// TODO: Make message an enumeration.
			packet.PutInt(message);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Updates the durability of an item in an equipment slot.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="slot"></param>
		/// <param name="durability">Value in thousandths that the item has remaining.</param>
		public static void ZC_CHANGE_EQUIP_DURABILITY(Character character, EquipSlot slot, int durability)
		{
			var packet = new Packet(Op.ZC_CHANGE_EQUIP_DURABILITY);
			packet.PutByte((byte)slot);
			packet.PutInt(durability);

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
			packet.PutShort((short)character.JobId);
			packet.PutInt((int)character.JobId); // 1, 10, 11
			packet.PutByte((byte)character.Gender);
			packet.PutByte((byte)character.Hair);
			packet.PutEmptyBin(2);
			packet.PutInt(0); // 628051

			// [i11257 (2016-03-25)] ?
			{
				packet.PutInt(1004);
			}
			packet.PutInt(0); //i3
			packet.PutInt(0); //i4
			packet.PutInt(0); //i5

			packet.PutFloat(0); // Display time in seconds, min cap 5s
			packet.PutEmptyBin(16); // [i170175] ?
			packet.PutByte(1);
			packet.PutString(message);

			character.Map.Broadcast(packet, character);
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
			packet.PutShort(1); // type? 0 = also show in red letters on the screen
			packet.PutByte(0); // ?

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
		public static void ZC_JUMP(Character character, float x, float y, float z, float dx, float dy, float unkFloat, byte unkByte)
		{
			var packet = new Packet(Op.ZC_JUMP);

			packet.PutInt(character.Handle);
			packet.PutFloat(character.GetJumpStrength());
			packet.PutInt(character.GetJumpType());
			packet.PutByte(0);  // 1 or 0
			packet.PutFloat(x);
			packet.PutFloat(y);
			packet.PutFloat(z);
			packet.PutFloat(dx);
			packet.PutFloat(dy);
			packet.PutFloat(unkFloat);
			packet.PutEmptyBin(13);
			packet.PutLong(unkByte);
			packet.PutShort(0);
			packet.PutByte(0);

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
			packet.PutInt(0);
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
			packet.AddAppearancePc(character);

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
			packet.PutLong(item.ObjectId);
			packet.PutInt(amount);
			packet.PutInt(0);
			packet.PutInt(index);
			packet.PutInt(item.Id);
			packet.PutShort(8); // Size of the object at the end
			packet.PutByte((byte)addType);
			packet.PutFloat(0f); // Notification delay
			packet.PutByte(0); // InvType
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutInt(7266); // Prop 1
			packet.PutFloat(0); // Prop 1 value
			packet.PutShort(0);
			packet.PutLong(item.ObjectId);
			packet.PutShort(0);
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
				packet.PutInt(0);
			}

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Updates all of character's  properties.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="properties"></param>
		public static void ZC_OBJECT_PROPERTY(Character character)
		{
			ZC_OBJECT_PROPERTY(character.Connection, character);
		}

		/// <summary>
		/// Updates character's given properties.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="properties"></param>
		public static void ZC_OBJECT_PROPERTY(Character character, params int[] properties)
		{
			ZC_OBJECT_PROPERTY(character.Connection, character, properties);
		}

		/// <summary>
		/// Updates object's given properties.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="obj"></param>
		public static void ZC_OBJECT_PROPERTY(ChannelConnection conn, IPropertyObject obj)
		{
			var properties = obj.Properties.GetAll();
			var propertiesSize = properties.Sum(a => a.Size);

			var packet = new Packet(Op.ZC_OBJECT_PROPERTY);

			packet.PutLong(obj.ObjectId);
			packet.PutInt(0); // isTrickPacket
			packet.AddProperties(properties);

			conn.Send(packet);
		}

		/// <summary>
		/// Updates object's given properties.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="obj"></param>
		public static void ZC_OBJECT_PROPERTY(ChannelConnection conn, IPropertyObject obj, Properties properties)
		{
			var props = properties.GetAll();
			var propertiesSize = props.Sum(a => a.Size);
			var packet = new Packet(Op.ZC_OBJECT_PROPERTY);

			packet.PutLong(obj.ObjectId);
			packet.PutInt(0); // isTrickPacket
			packet.AddProperties(props);

			conn.Send(packet);
		}

		/// <summary>
		/// Updates object's given properties.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="obj"></param>
		/// <param name="propertyIds"></param>
		public static void ZC_OBJECT_PROPERTY(ChannelConnection conn, IPropertyObject obj, params int[] propertyIds)
		{
			var properties = obj.Properties.GetAll(propertyIds);
			var propertiesSize = properties.Sum(a => a.Size);

			var packet = new Packet(Op.ZC_OBJECT_PROPERTY);

			packet.PutLong(obj.ObjectId);
			packet.PutInt(0); // isTrickPacket
			packet.AddProperties(properties);

			conn.Send(packet);
		}

		/// <summary>
		/// Broadcasts ZC_ROTATE in range of character.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_ROTATE(Character character)
		{
			var packet = new Packet(Op.ZC_ROTATE);

			packet.PutInt(character.Handle);
			packet.PutFloat(character.Direction.Cos);
			packet.PutFloat(character.Direction.Sin);
			packet.PutByte(1); // Seems to be 1
			packet.PutByte(1); // Seems to be 1

			character.Map.Broadcast(packet, character);
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
			packet.PutByte(0); // [i171032] ?
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

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Updates the number of purchased character slots.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="count"></param>
		public static void ZC_NORMAL_BarrackSlotCount(ChannelConnection conn, int count)
		{
			var packet = new Packet(Op.BC_NORMAL);
			packet.PutInt(SubOp.Zone.BarrackSlotCount);
			packet.PutInt(count);

			conn.Send(packet);
		}

		/// <summary>
		/// Plays level up effect.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_NORMAL_LevelUp(Character character)
		{
			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(SubOp.Zone.LevelUp);
			packet.PutInt(character.Handle);
			packet.PutShort(8351);
			packet.PutShort(39);
			packet.PutFloat(6); // Effect size
			packet.PutInt(2);
			packet.PutEmptyBin(4);
			packet.PutFloat(1);
			packet.PutEmptyBin(4);
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
			packet.PutInt(SubOp.Zone.ClassLevelUp);
			packet.PutInt(character.Handle);
			packet.PutByte(1);
			packet.PutInt(2);
			packet.PutByte(1);
			packet.PutFloat(6); // Effect size
			packet.PutBinFromHex("9E 20 27 00 00 00 00 00"); // Necessary for it to play

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Attack broadcast?
		/// </summary>
		/// <param name="character"></param>
		/// <param name="skillId"></param>
		/// <param name="value"></param>
		public static void ZC_NORMAL_AttackCancel(Character character)
		{
			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(SubOp.Zone.AttackCancel);
			packet.PutInt(character.Handle);

			character.Map.Broadcast(packet);
		}

		/// <summary>
		/// Adjusts the skill speed for a skill.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="skillId"></param>
		/// <param name="value"></param>
		public static void ZC_NORMAL_SetSkillSpeed(Character character, int skillId, float value)
		{
			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(SubOp.Zone.SetSkillSpeed);
			packet.PutInt(skillId);
			packet.PutFloat(value);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Adjusts the hit delay for a skill.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="skillId"></param>
		public static void ZC_NORMAL_SetHitDelay(Character character, int skillId, float value)
		{
			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(SubOp.Zone.SetHitDelay);
			packet.PutInt(skillId);
			packet.PutFloat(value);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sends the session key to the client.
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_NORMAL_AdventureBook(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(SubOp.Zone.AdventureBook);
			packet.PutLpString("AdventureBook");
			packet.PutLpString("Initialization_point");
			conn.Send(packet);
		}

		/// <summary>
		/// Sends the session key to the client.
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_NORMAL_SetSessionKey(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(SubOp.Zone.SetSessionKey);
			packet.PutLpString(conn.SessionKey);
			conn.Send(packet);
		}

		/// <summary>
		/// Sets the state of whether a hat is visible or not.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_NORMAL_HatVisibleState(Character character)
		{
			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(SubOp.Zone.HatVisibleState);

			packet.PutInt(character.Handle);
			packet.PutByte((character.VisibleHats & HatVisibleStates.Hat1) != 0);
			packet.PutByte((character.VisibleHats & HatVisibleStates.Hat2) != 0);
			packet.PutByte((character.VisibleHats & HatVisibleStates.Hat3) != 0);

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
			packet.PutInt(0);
			packet.PutInt(character.MaxExp);
			packet.PutInt(0);
			packet.PutInt(character.TotalExp);
			packet.PutInt(0);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Notification about acquired exp from killing a monster?
		/// </summary>
		/// <param name="character"></param>
		/// <param name="exp"></param>
		/// <param name="classExp"></param>
		/// <param name="monster"></param>
		public static void ZC_EXP_UP_BY_MONSTER(Character character, int exp, int classExp, Monster monster)
		{
			var packet = new Packet(Op.ZC_EXP_UP_BY_MONSTER);
			packet.PutLong(exp);
			packet.PutLong(classExp);
			packet.PutLong(exp);
			packet.PutInt(monster.Handle);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Adds exp.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="exp"></param>
		/// <param name="classExp"></param>
		public static void ZC_EXP_UP(Character character, int exp, int classExp)
		{
			var packet = new Packet(Op.ZC_EXP_UP);
			packet.PutLong(exp);
			packet.PutLong(classExp);
			packet.PutLong(exp);

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
			packet.PutLong(character.Id);
			packet.PutInt(exp);
			packet.PutInt(0);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Executes Lua addon function.
		/// </summary>
		/// <remarks>Strings are placed without terminating bytes.</remarks>
		/// <param name="character"></param>
		/// <param name="msg"></param>
		/// <param name="parameter"></param>
		public static void ZC_ADDON_MSG(Character character, string msg, string parameter = null)
		{
			ZC_ADDON_MSG(character, 0, msg, parameter);
		}

		/// <summary>
		/// Executes Lua addon function.
		/// </summary>
		/// <remarks>Strings are placed without terminating bytes.</remarks>
		/// <param name="character"></param>
		/// <param name="duration">Duration in seconds messages are displayed?</param>
		/// <param name="msg"></param>
		/// <param name="parameter"></param>
		public static void ZC_ADDON_MSG(Character character, int duration, string msg, string parameter = null)
		{
			var packet = new Packet(Op.ZC_ADDON_MSG);
			packet.PutByte((byte)(msg.Length));
			packet.PutInt(duration);
			packet.PutByte(0);
			packet.PutString(msg, msg.Length);

			if (parameter != null)
				packet.PutString(parameter, parameter.Length);

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
		/// Sends the visible areas of a map to a character.
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_MAP_REVEAL_LIST(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_MAP_REVEAL_LIST);

			var revealedMaps = conn.Account.GetRevealedMaps();

			packet.PutInt(revealedMaps.Count());
			foreach (var revealedMap in revealedMaps)
			{
				packet.PutInt(revealedMap.MapId);
				packet.PutBin(revealedMap.Explored);
			}
			packet.PutLong(0);
			packet.PutFloat(56.45161f);

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

			var iesModified = false;
			if (!iesModified)
			{
				packet.PutShort(0); //
			} else {
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
			packet.PutByte(1);

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Sends an updated value for the shield to an entity.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="shield"></param>
		public static void ZC_UPDATE_SHIELD(Character character, IEntity entity, int shield)
		{
			var packet = new Packet(Op.ZC_UPDATE_SHIELD);
			packet.PutInt(entity.Handle);
			packet.PutInt(shield);

			character.Map.Broadcast(packet, entity);
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
		public static void ZC_MOVE_DIR(Character character, float x, float y, float z, float dx, float dy, float unkFloat)
		{
			var packet = new Packet(Op.ZC_MOVE_DIR);

			packet.PutInt(character.Handle);
			packet.PutFloat(x);
			packet.PutFloat(y);
			packet.PutFloat(z);
			packet.PutFloat(dx);
			packet.PutFloat(dy);
			packet.PutByte(1); // 0 = reduced movement speed... walk mode?
			packet.PutFloat(character.GetSpeed());
			packet.PutByte(1);
			packet.PutFloat(unkFloat);
			packet.PutEmptyBin(23);
			packet.PutInt(1);
			packet.PutInt(0);
			packet.PutByte(1);

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Broadcasts ZC_MOVE_STOP in range of character, informing other
		/// characters about the movement stop.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		public static void ZC_MOVE_STOP(Character character, float x, float y, float z)
		{
			var packet = new Packet(Op.ZC_MOVE_STOP);

			packet.PutInt(character.Handle);
			packet.PutFloat(x);
			packet.PutFloat(y);
			packet.PutFloat(z);
			packet.PutByte(0);

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Broadcasts ZC_PC_MOVE_STOP in range of character, informing other
		/// characters about the movement stop.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		public static void ZC_PC_MOVE_STOP(Character character, Position position, Direction direction)
		{
			var packet = new Packet(Op.ZC_PC_MOVE_STOP);

			packet.PutInt(character.Handle);
			packet.PutFloat(position.X);
			packet.PutFloat(position.Y);
			packet.PutFloat(position.Z);
			packet.PutByte(1);
			packet.PutFloat(direction.Cos);
			packet.PutFloat(direction.Sin);
			packet.PutFloat(228787.3f); // ?
			packet.PutEmptyBin(24);

			character.Map.Broadcast(packet, character);
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
		public static void ZC_SKILL_READY(Character character, int id, Position position1, Position position2)
		{
			var packet = new Packet(Op.ZC_SKILL_READY);
			packet.PutInt(character.Handle);
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


			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Adjusts the time speed of the client.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="timeFactor"></param>
		public static void ZC_TIME_FACTOR(ChannelConnection conn, float timeFactor = 1)
		{
			var packet = new Packet(Op.ZC_TIME_FACTOR);
			packet.PutFloat(timeFactor);

			conn.Send(packet);
		}

		/// <summary>
		/// Sets the team ID for an entity.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="entity"></param>
		/// <param name="team">The team ID which is a value of either '0', '1', or '2'.</param>
		public static void ZC_TEAMID(ChannelConnection conn, IEntity entity, byte team)
		{
			var packet = new Packet(Op.ZC_TEAMID);
			packet.PutInt(entity.Handle);
			packet.PutByte(team);

			conn.Send(packet);
		}

		/// <summary>
		/// Sets the entity's owner to the specified character handle.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="monster"></param>
		public static void ZC_OWNER(Character character, IEntity entity)
		{
			var packet = new Packet(Op.ZC_OWNER);
			packet.PutInt(entity.Handle);
			packet.PutInt(character.Handle);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Creates a skill in client
		/// </summary>
		/// <param name="character"></param>
		/// <param name="id"></param>
		/// <param name="position"></param>
		/// <param name="direction"></param>
		/// <param name="create"></param>
		public static void ZC_NORMAL_Skill(Character character, int id, Position position, Direction direction, bool create)
		{
			var actorId = 1234; // ActorId (entity unique id for this skill)
			var distance = 20.0f; // Distance to caster? Not sure. Observed values (20, 40, 80)

			var skillState = 0; // skillState seems to be an ENUM of animation states (0 = initial animation, 1 = touched animation)
			if (!create)
				skillState = 1;

			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(SubOp.Zone.Skill);
			packet.PutInt(character.Handle);
			packet.PutBinFromHex("11 18 27 00"); // Heal skill effect
			packet.PutInt(id); // SkillId
			packet.PutInt(1); // Skill Level ?
			packet.PutFloat(position.X);
			packet.PutFloat(position.Y);
			packet.PutFloat(position.Z);
			packet.PutFloat(direction.Cos); // Direction (commented out for now)
			packet.PutFloat(direction.Sin); // Direction (commented out for now)
			packet.PutInt(0);
			packet.PutFloat(distance);
			packet.PutInt(actorId);
			packet.PutByte(create);
			packet.PutInt(skillState);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(0);

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Creates a particle effect (or set desired animation)
		/// </summary>
		/// <param name="character"></param>
		/// <param name="actorId"></param>
		/// <param name="enable"></param>
		public static void ZC_NORMAL_ParticleEffect(Character character, int actorId, int enable)
		{
			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(SubOp.Zone.ParticleEffect);
			packet.PutInt(actorId);
			packet.PutInt(enable);

			character.Map.Broadcast(packet);
		}

		/// <summary>
		/// Unkown purpose yet. It could be a "target" packet. (this actor is targeting "id" actor
		/// </summary>
		/// <param name="character"></param>
		/// <param name="handle"></param>
		/// <param name="position"></param>
		/// <param name="direction"></param>
		public static void ZC_NORMAL_Unkown_1c(Character character, int handle, Position position, Direction direction)
		{
			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(SubOp.Zone.Unkown_1D);
			packet.PutInt(character.Handle);
			packet.PutBinFromHex("00 D9 DB 30 09"); // This is not a fixed value, check more packets
			packet.PutInt(handle); // Target ActorId (seems to be)
			packet.PutFloat(position.X);
			packet.PutFloat(position.Y);
			packet.PutFloat(position.Z);
			packet.PutFloat(direction.Cos);
			packet.PutFloat(direction.Sin);
			packet.PutFloat(0);
			packet.PutFloat(0);
			packet.PutFloat(0);

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Unknown purpose yet.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_NORMAL_Unknown_A1(Character character)
		{
			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(SubOp.Zone.Unknown_A1);
			packet.PutLong(4);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sent during login for unknown purpose
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_NORMAL_Unknown_DA(Character character)
		{
			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(SubOp.Zone.Unknown_DA);
			packet.Zlib(true, zpacket =>
			{
				zpacket.PutLong(character.Id);
				zpacket.PutInt(0);
			});

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sent during login for unknown purpose
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_NORMAL_Unknown_E4(Character character)
		{
			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(SubOp.Zone.Unknown_E4);
			packet.PutInt(0);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sends account properties.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_NORMAL_SetGreetingMessage(Character character)
		{
			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(SubOp.Zone.AccountUpdate);
			packet.PutLong(character.Id);
			packet.PutInt(0);
			packet.PutLpString(character.GreetingMessage);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Unknown purpose yet.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_NORMAL_Unknown_1B4(Character character)
		{
			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(SubOp.Zone.Unknown_1B4);
			packet.PutInt(0);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sends account properties.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_NORMAL_AccountUpdate(Character character)
		{
			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(SubOp.Zone.AccountUpdate);
			packet.PutLong(character.AccountId);
			packet.AddAccountProperties(character.Connection.Account);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Unknown purpose yet.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_NORMAL_Unknown_EF(Character character)
		{
			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(SubOp.Zone.Unknown_EF);
			packet.PutLong(character.Id);
			packet.PutInt(98); // count
			packet.PutLpString("Char3_4");
			packet.PutInt(108213);
			packet.PutLpString("Char4_2");
			packet.PutInt(91582);
			packet.PutLpString("Char2_2");
			packet.PutInt(87664);
			packet.PutLpString("Char1_2");
			packet.PutInt(72125);
			packet.PutLpString("Char2_1");
			packet.PutInt(65701);
			packet.PutLpString("Char2_3");
			packet.PutInt(62257);
			packet.PutLpString("Char1_3");
			packet.PutInt(59394);
			packet.PutLpString("Char1_1");
			packet.PutInt(59326);
			packet.PutLpString("Char3_1");
			packet.PutInt(55356);
			packet.PutLpString("Char3_3");
			packet.PutInt(52974);
			packet.PutLpString("Char4_1");
			packet.PutInt(48879);
			packet.PutLpString("Char1_6");
			packet.PutInt(43388);
			packet.PutLpString("Char4_3");
			packet.PutInt(42821);
			packet.PutLpString("Char1_4");
			packet.PutInt(39746);
			packet.PutLpString("Char2_11");
			packet.PutInt(37070);
			packet.PutLpString("Char2_7");
			packet.PutInt(36189);
			packet.PutLpString("Char2_6");
			packet.PutInt(25420);
			packet.PutLpString("Char2_10");
			packet.PutInt(22025);
			packet.PutLpString("Char2_9");
			packet.PutInt(19903);
			packet.PutLpString("Char2_4");
			packet.PutInt(18620);
			packet.PutLpString("Char4_11");
			packet.PutInt(17977);
			packet.PutLpString("Char1_9");
			packet.PutInt(17797);
			packet.PutLpString("Char4_7");
			packet.PutInt(17423);
			packet.PutLpString("Char3_14");
			packet.PutInt(16096);
			packet.PutLpString("Char1_7");
			packet.PutInt(15377);
			packet.PutLpString("Char4_4");
			packet.PutInt(15097);
			packet.PutLpString("Char2_8");
			packet.PutInt(14413);
			packet.PutLpString("Char3_5");
			packet.PutInt(13485);
			packet.PutLpString("Char4_14");
			packet.PutInt(13288);
			packet.PutLpString("Char4_5");
			packet.PutInt(13265);
			packet.PutLpString("Char4_9");
			packet.PutInt(12484);
			packet.PutLpString("Char1_15");
			packet.PutInt(12448);
			packet.PutLpString("Char2_15");
			packet.PutInt(12387);
			packet.PutLpString("Char3_6");
			packet.PutInt(11803);
			packet.PutLpString("Char3_11");
			packet.PutInt(11666);
			packet.PutLpString("Char1_8");
			packet.PutInt(10493);
			packet.PutLpString("Char3_10");
			packet.PutInt(10420);
			packet.PutLpString("Char5_12");
			packet.PutInt(10043);
			packet.PutLpString("Char3_17");
			packet.PutInt(9334);
			packet.PutLpString("Char4_6");
			packet.PutInt(9327);
			packet.PutLpString("Char2_5");
			packet.PutInt(9088);
			packet.PutLpString("Char2_16");
			packet.PutInt(9036);
			packet.PutLpString("Char2_20");
			packet.PutInt(8883);
			packet.PutLpString("Char1_14");
			packet.PutInt(8851);
			packet.PutLpString("Char5_2");
			packet.PutInt(8739);
			packet.PutLpString("Char3_2");
			packet.PutInt(8667);
			packet.PutLpString("Char3_16");
			packet.PutInt(8256);
			packet.PutLpString("Char4_16");
			packet.PutInt(8138);
			packet.PutLpString("Char1_10");
			packet.PutInt(7980);
			packet.PutLpString("Char3_8");
			packet.PutInt(7662);
			packet.PutLpString("Char4_20");
			packet.PutInt(7097);
			packet.PutLpString("Char3_9");
			packet.PutInt(7025);
			packet.PutLpString("Char4_12");
			packet.PutInt(6932);
			packet.PutLpString("Char4_15");
			packet.PutInt(6616);
			packet.PutLpString("Char2_19");
			packet.PutInt(6610);
			packet.PutLpString("Char2_14");
			packet.PutInt(6378);
			packet.PutLpString("Char4_19");
			packet.PutInt(6357);
			packet.PutLpString("Char1_11");
			packet.PutInt(6293);
			packet.PutLpString("Char4_8");
			packet.PutInt(6212);
			packet.PutLpString("Char3_15");
			packet.PutInt(5508);
			packet.PutLpString("Char2_18");
			packet.PutInt(5332);
			packet.PutLpString("Char3_18");
			packet.PutInt(5286);
			packet.PutLpString("Char4_10");
			packet.PutInt(5122);
			packet.PutLpString("Char5_5");
			packet.PutInt(4875);
			packet.PutLpString("Char5_11");
			packet.PutInt(4704);
			packet.PutLpString("Char5_8");
			packet.PutInt(4383);
			packet.PutLpString("Char1_12");
			packet.PutInt(3968);
			packet.PutLpString("Char1_17");
			packet.PutInt(3783);
			packet.PutLpString("Char3_13");
			packet.PutInt(3740);
			packet.PutLpString("Char5_7");
			packet.PutInt(3675);
			packet.PutLpString("Char1_22");
			packet.PutInt(3675);
			packet.PutLpString("Char2_17");
			packet.PutInt(3333);
			packet.PutLpString("Char2_21");
			packet.PutInt(3233);
			packet.PutLpString("Char4_18");
			packet.PutInt(3021);
			packet.PutLpString("Char5_9");
			packet.PutInt(2965);
			packet.PutLpString("Char1_16");
			packet.PutInt(2906);
			packet.PutLpString("Char5_3");
			packet.PutInt(2737);
			packet.PutLpString("Char1_19");
			packet.PutInt(2736);
			packet.PutLpString("Char4_21");
			packet.PutInt(2634);
			packet.PutLpString("Char1_13");
			packet.PutInt(2617);
			packet.PutLpString("Char5_10");
			packet.PutInt(2569);
			packet.PutLpString("Char3_12");
			packet.PutInt(2498);
			packet.PutLpString("Char4_17");
			packet.PutInt(2488);
			packet.PutLpString("Char2_22");
			packet.PutInt(2451);
			packet.PutLpString("Char1_18");
			packet.PutInt(2426);
			packet.PutLpString("Char3_20");
			packet.PutInt(1813);
			packet.PutLpString("Char5_14");
			packet.PutInt(1744);
			packet.PutLpString("Char5_13");
			packet.PutInt(1612);
			packet.PutLpString("Char5_4");
			packet.PutInt(1582);
			packet.PutLpString("Char3_7");
			packet.PutInt(1326);
			packet.PutLpString("Char2_23");
			packet.PutInt(1116);
			packet.PutLpString("Char1_21");
			packet.PutInt(970);
			packet.PutLpString("Char3_19");
			packet.PutInt(852);
			packet.PutLpString("Char5_15");
			packet.PutInt(837);
			packet.PutLpString("Char1_20");
			packet.PutInt(641);
			packet.PutLpString("Char5_16");
			packet.PutInt(628);
			packet.PutLpString("Char5_6");
			packet.PutInt(596);
			packet.PutLpString("Char3_21");
			packet.PutInt(311);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Unknown purpose yet.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_NORMAL_Unknown_19B(Character character)
		{
			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(SubOp.Zone.Unknown_19B);
			packet.PutLong(1);
			packet.PutByte(0);
		}

		/// <summary>
		/// Unknown purpose yet.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_NORMAL_Unknown_Map_12A(Character character)
		{
			if (character.MapId == 1021)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(SubOp.Zone.Unknown_Map_12A);
				packet.Zlib(true, zpacket =>
				{
					zpacket.PutShort(character.MapId);
					zpacket.PutShort(2); // Count?
					zpacket.PutShort(0); //First Channel?
					zpacket.PutShort(1); //Available? Online? User Count?
					zpacket.PutShort(100); //User Limit?
					zpacket.PutShort(0); //Second Channel?
					zpacket.PutShort(1); //Available? Online? User Count?
					zpacket.PutShort(100); //User Limit?
				});
			}
		}

		/// <summary>
		/// Updates the skill UI with character job data.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_NORMAL_UpdateSkillUI(Character character)
		{
			// While the client will apparently gladly accept any combination
			// of jobs, the skill UI will only appear correctly if job
			// data for the character's current "display job" is sent.
			// For example, if the display job is Archer, data for *that*
			// job must be sent. Other base classes or higher jobs in the
			// same class do not work. Same thing for when the display
			// job is a higher job.

			var jobs = character.Jobs.GetList();

			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(SubOp.Zone.UpdateSkillUI);
			packet.PutLong(character.Id);

			packet.PutInt(jobs.Length);
			foreach (var job in jobs)
			{
				packet.PutShort((short)job.Id);
				packet.PutShort(1); // 174
				packet.PutInt(0);
				packet.PutInt(job.TotalExp);
				packet.PutInt(0);
				packet.PutByte((byte)job.SkillPoints);
				packet.PutShort(41857);
				packet.PutEmptyBin(5);
				packet.PutLong(132735996030000000);
				packet.PutLong(0);
			}

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Set a Range type "CIRCLE" shape in a given position
		/// </summary>
		/// <param name="character"></param>
		/// <param name="id"></param>
		/// <param name="position"></param>
		/// <param name="direction"></param>
		public static void ZC_SKILL_RANGE_CIRCLE(Character character, IEntity entity, Skill skill, Position position, Direction direction)
		{
			var packet = new Packet(Op.ZC_SKILL_RANGE_CIRCLE);
			packet.PutInt(character.Handle);
			if (entity == null)
				packet.PutInt(0);
			else
				packet.PutInt(entity.Handle);
			packet.PutShort(skill.Id);
			packet.PutFloat(position.X);
			packet.PutFloat(position.Y);
			packet.PutFloat(position.Z);
			packet.PutFloat(direction.Cos);
			packet.PutFloat(direction.Sin);

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Set a Range type "FAN" shape in a given position
		/// </summary>
		/// <param name="character"></param>
		/// <param name="id"></param>
		/// <param name="position"></param>
		/// <param name="direction"></param>
		public static void ZC_SKILL_RANGE_FAN(Character character, int id, Position position, Direction direction)
		{
			var packet = new Packet(Op.ZC_SKILL_RANGE_FAN);
			packet.PutInt(character.Handle);
			packet.PutByte(1);
			packet.PutByte(1);
			packet.PutFloat(position.X);
			packet.PutFloat(position.Y);
			packet.PutFloat(position.Z);
			packet.PutFloat(direction.Cos);
			packet.PutFloat(direction.Sin);
			packet.PutFloat(0); // Height min ?
			packet.PutFloat(0.174533f); // Height max ?

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Enables/disables creature attack state
		/// </summary>
		/// <param name="character"></param>
		/// <param name="attacking"></param>
		public static void ZC_PC_ATKSTATE(Character character, bool attacking)
		{
			var packet = new Packet(Op.ZC_PC_ATKSTATE);
			packet.PutInt(character.Handle);
			packet.PutByte(attacking);

			character.Map.Broadcast(packet);
		}

		/// <summary>
		/// Updates creature's SP
		/// </summary>
		/// <param name="character"></param>
		/// <param name="spValue"></param>
		public static void ZC_UPDATE_SP(Character character, int spValue)
		{
			var packet = new Packet(Op.ZC_UPDATE_SP);
			packet.PutInt(character.Handle);
			packet.PutInt(spValue);
			packet.PutByte(0);

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Updates a characters HP for damage and healing.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="amount"></param>
		/// <param name="isDamage"></param>
		/// <param name="currentHp"></param>
		/// <param name="priority"></param>
		public static void ZC_ADD_HP(Character character, int amount, bool isDamage, int maxHp, int priority)
		{
			// For some reason this is '1' for damage.
			var healing = (isDamage ? 1 : amount);

			var packet = new Packet(Op.ZC_ADD_HP);
			packet.PutInt(character.Handle);
			packet.PutInt(healing);
			packet.PutInt(maxHp);
			packet.PutInt(priority);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Update creature basic stats (hp, mp)
		/// </summary>
		/// <param name="character"></param>
		/// <param name="currentHP"></param>
		/// <param name="maxHP"></param>
		/// <param name="currentSP"></param>
		/// <param name="maxSP"></param>
		public static void ZC_UPDATE_ALL_STATUS(Character character, int currentHP = -1, int maxHP = -1, int currentSP = -1, int maxSP = -1)
		{
			var packet = new Packet(Op.ZC_UPDATE_ALL_STATUS);
			packet.PutInt(character.Handle);
			packet.PutInt(currentHP == -1 ? character.Hp : currentHP);
			packet.PutInt(maxHP == -1 ? character.MaxHp : maxHP);
			packet.PutInt(currentSP == -1 ? character.Sp : currentSP);
			packet.PutInt(maxSP == -1 ? character.MaxSp : maxSP);
			packet.PutInt(0);

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
		public static void ZC_HEAL_INFO(Character character, int amountHealed, int maxHP)
		{
			var packet = new Packet(Op.ZC_HEAL_INFO);
			packet.PutInt(character.Handle);
			packet.PutInt(amountHealed);
			packet.PutInt(maxHP);
			packet.PutInt(1);
			packet.PutInt(0);
			packet.PutInt(0);

			character.Map.Broadcast(packet);
		}

		/// <summary>
		/// Updates the stance of a character.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_STANCE_CHANGE(Character character)
		{
			var packet = new Packet(Op.ZC_STANCE_CHANGE);
			packet.PutInt(character.Handle);
			packet.PutInt(character.Stance);

			character.Map.Broadcast(packet);
		}

		/// <summary>
		/// Reply packet when skill melee ground is placed
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_SKILL_MELEE_GROUND(Character character, int id, Position position, Direction direction)
		{
			var packet = new Packet(Op.ZC_SKILL_MELEE_GROUND);
			packet.PutInt(id);
			packet.PutInt(character.Handle);
			packet.PutFloat(direction.Cos);
			packet.PutFloat(direction.Sin);
			packet.PutInt(1);
			packet.PutFloat(600);
			packet.PutFloat(1);
			packet.PutFloat(-1);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutFloat(position.X);
			packet.PutFloat(position.Y);
			packet.PutFloat(position.Z);
			packet.PutShort(0); // Some sort of Size for something else. Since this is a "variable size" packet.

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Sends the faction for the handle.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="monster"></param>
		public static void ZC_FACTION(ChannelConnection conn, Monster monster, FactionType faction)
		{
			var packet = new Packet(Op.ZC_FACTION);
			packet.PutInt(monster.Handle);
			packet.PutInt((int)faction);

			conn.Send(packet);
		}

		/// <summary>
		/// Sends a list of help topics to the client.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_HELP_LIST(Character character)
		{
			// Get only the basic help topics for now. We probably need
			// a character or account based list of help topics the
			// player can see, potentially incl. the information of
			// whether they've read a specific topic yet.

			var defaultList = ChannelServer.Instance.Data.HelpDb.Entries.Values.Where(a => a.BasicHelp).ToList();

			var packet = new Packet(Op.ZC_HELP_LIST);
			packet.PutInt(defaultList.Count());
			foreach (var data in defaultList)
			{
				packet.PutInt(data.Id);
				packet.PutByte(0); // Unknown, maybe "has seen" toggle?
			}

			character.Connection.Send(packet);
		}

		/// Request the client to send information that needs to be saved before exiting?
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_SAVE_INFO(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_SAVE_INFO);
			conn.Send(packet);
		}

		/// <summary>
		/// Acknowledges the client that the loading screen has completed.
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_LOAD_COMPLETE(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_LOAD_COMPLETE);
			conn.Send(packet);
		}

		/// <summary>
		/// Sends session objects to character's client.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_SESSION_OBJECTS(Character character)
		{
			var sessionObjects = character.SessionObjects.GetList();

			var packet = new Packet(Op.ZC_SESSION_OBJECTS);

			{
				packet.PutShort(sessionObjects.Length);
				packet.PutByte(0);
				if (sessionObjects.Length == 0)
				{
					packet.PutFloat(565831.1f);
				}
				else
				{
					foreach (var obj in sessionObjects)
					{
						var properties = obj.Properties.GetAll();
						var propertiesSize = obj.Properties.Size;

						packet.PutInt(obj.Id);
						packet.PutInt(-926557701);
						packet.PutLong(obj.ObjectId);
						packet.PutInt(0);

						packet.PutShort(propertiesSize);
						packet.PutShort(0);
						packet.AddProperties(properties);
					}
				}
			}
			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sends premium state properties to client.
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_SEND_CASH_VALUE(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_SEND_CASH_VALUE);

			// Premium state 0?
			packet.PutInt(4); // count?
			{
				packet.PutLpString("speedUp");
				packet.PutFloat(0);

				packet.PutLpString("marketUpMax");
				packet.PutFloat(1);

				packet.PutLpString("marketSellCom");
				packet.PutFloat(30);

				packet.PutLpString("abilityMax");
				packet.PutFloat(1);
			}

			// Premium state 1?
			packet.PutInt(4);
			{
				packet.PutLpString("speedUp");
				packet.PutFloat(3);

				packet.PutLpString("marketUpMax");
				packet.PutFloat(5);

				packet.PutLpString("marketSellCom");
				packet.PutFloat(10);

				packet.PutLpString("abilityMax");
				packet.PutFloat(3);
			}

			// Premium state 2?
			packet.PutInt(4);
			{
				packet.PutLpString("speedUp");
				packet.PutFloat(3);

				packet.PutLpString("marketUpMax");
				packet.PutFloat(10);

				packet.PutLpString("marketSellCom");
				packet.PutFloat(10);

				packet.PutLpString("abilityMax");
				packet.PutFloat(2);
			}

			// ?
			packet.PutInt(4);
			{
				packet.PutInt(7);
				packet.PutFloat(2.5f);

				packet.PutInt(5);
				packet.PutFloat(2);

				packet.PutInt(3);
				packet.PutFloat(1.5f);

				packet.PutInt(1);
				packet.PutFloat(1);
			}

			conn.Send(packet);
		}

		/// <summary>
		/// Sends premium state properties to client.
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_SEND_PREMIUM_STATE(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_SEND_PREMIUM_STATE);
			packet.PutShort(2); // Count?
			packet.PutShort(0x4E6C);
			packet.PutShort(0xE8EF);
			packet.PutInt(0);
			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_RESPONSE_GUILD_INDEX to client (dummy).
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_RESPONSE_GUILD_INDEX(Character character)
		{
			var packet = new Packet(Op.ZC_RESPONSE_GUILD_INDEX);
			packet.PutInt(character.Handle);
			packet.PutLong(character.Id);
			packet.PutShort(1003);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sends ZC_SET_CHATBALLOON_SKIN to client (dummy).
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_SET_CHATBALLOON_SKIN(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_SET_CHATBALLOON_SKIN);
			packet.PutBinFromHex("00 00 01 00 00 00 00 00 00 00 00 00 01 00 00 80 00 00 00 00 98 4B");
			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_MYPAGE_MAP to client (dummy).
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_MYPAGE_MAP(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_MYPAGE_MAP);
			packet.PutInt(1);
			packet.PutByte(0);
			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_GUESTPAGE_MAP to client (dummy).
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_GUESTPAGE_MAP(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_GUESTPAGE_MAP);
			packet.PutInt(1);
			packet.PutByte(0);
			conn.Send(packet);
		}

		public static void ZC_PCBANG_SHOP_RENTAL(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_PCBANG_SHOP_RENTAL);
			packet.PutString("PC_SWD01_137", 64);
			packet.PutInt(0);
			packet.PutInt(11);
			packet.PutInt(10);
			packet.PutInt(1);

			packet.PutString("PC_TSW01_129", 64);
			packet.PutInt(0);
			packet.PutInt(11);
			packet.PutInt(10);
			packet.PutInt(1);

			packet.PutString("PC_STF01_137", 64);
			packet.PutInt(0);
			packet.PutInt(11);
			packet.PutInt(10);
			packet.PutInt(1);

			packet.PutString("PC_TBW01_137", 64);
			packet.PutInt(0);
			packet.PutInt(11);
			packet.PutInt(10);
			packet.PutInt(1);

			packet.PutString("PC_BOW01_130", 64);
			packet.PutInt(0);
			packet.PutInt(11);
			packet.PutInt(10);
			packet.PutInt(1);

			packet.PutString("PC_MAC01_136", 64);
			packet.PutInt(0);
			packet.PutInt(11);
			packet.PutInt(10);
			packet.PutInt(1);

			packet.PutString("PC_SPR01_119", 64);
			packet.PutInt(0);
			packet.PutInt(11);
			packet.PutInt(10);
			packet.PutInt(1);

			packet.PutString("PC_TSP01_111", 64);
			packet.PutInt(0);
			packet.PutInt(11);
			packet.PutInt(10);
			packet.PutInt(1);

			packet.PutString("PC_TSF01_129", 64);
			packet.PutInt(0);
			packet.PutInt(11);
			packet.PutInt(10);
			packet.PutInt(1);

			packet.PutString("PC_RAP01_103", 64);
			packet.PutInt(0);
			packet.PutInt(11);
			packet.PutInt(10);
			packet.PutInt(1);

			packet.PutString("PC_TOP01_139", 64);
			packet.PutInt(0);
			packet.PutInt(11);
			packet.PutInt(10);
			packet.PutInt(1);

			packet.PutString("PC_LEG01_139", 64);
			packet.PutInt(0);
			packet.PutInt(11);
			packet.PutInt(10);
			packet.PutInt(1);

			packet.PutString("PC_FOOT01_139", 64);
			packet.PutInt(0);
			packet.PutInt(11);
			packet.PutInt(10);
			packet.PutInt(1);

			packet.PutString("PC_HAND01_139", 64);
			packet.PutInt(0);
			packet.PutInt(11);
			packet.PutInt(10);
			packet.PutInt(1);

			packet.PutString("PC_TOP01_140", 64);
			packet.PutInt(0);
			packet.PutInt(11);
			packet.PutInt(10);
			packet.PutInt(1);

			packet.PutString("PC_LEG01_140", 64);
			packet.PutInt(0);
			packet.PutInt(11);
			packet.PutInt(10);
			packet.PutInt(1);

			packet.PutString("PC_FOOT01_140", 64);
			packet.PutInt(0);
			packet.PutInt(11);
			packet.PutInt(10);
			packet.PutInt(1);

			packet.PutString("PC_HAND01_140", 64);
			packet.PutInt(0);
			packet.PutInt(11);
			packet.PutInt(10);
			packet.PutInt(1);

			packet.PutString("PC_TOP01_141", 64);
			packet.PutInt(0);
			packet.PutInt(11);
			packet.PutInt(10);
			packet.PutInt(1);

			packet.PutString("PC_LEG01_141", 64);
			packet.PutInt(0);
			packet.PutInt(11);
			packet.PutInt(10);
			packet.PutInt(1);

			packet.PutString("PC_FOOT01_141", 64);
			packet.PutInt(0);
			packet.PutInt(11);
			packet.PutInt(10);
			packet.PutInt(1);

			packet.PutString("PC_HAND01_141", 64);
			packet.PutInt(0);
			packet.PutInt(11);
			packet.PutInt(10);
			packet.PutInt(1);

			packet.PutString("PC_SHD100_101", 64);
			packet.PutInt(0);
			packet.PutInt(11);
			packet.PutInt(10);
			packet.PutInt(1);

			packet.PutString("PC_DAG100_101", 64);
			packet.PutInt(0);
			packet.PutInt(11);
			packet.PutInt(10);
			packet.PutInt(1);

			packet.PutString("PC_CAN100_101", 64);
			packet.PutInt(0);
			packet.PutInt(11);
			packet.PutInt(10);
			packet.PutInt(1);

			packet.PutString("PC_PST100_101", 64);
			packet.PutInt(0);
			packet.PutInt(11);
			packet.PutInt(10);
			packet.PutInt(1);

			packet.PutString("PC_MUS100_101", 64);
			packet.PutInt(0);
			packet.PutInt(11);
			packet.PutInt(10);
			packet.PutInt(1);

			packet.PutString("PC_TMAC02_103", 64);
			packet.PutInt(0);
			packet.PutInt(11);
			packet.PutInt(10);
			packet.PutInt(1);

			packet.PutString("PC_TRK02_101", 64);
			packet.PutInt(0);
			packet.PutInt(11);
			packet.PutInt(10);
			packet.PutInt(1);

			conn.Send(packet);
		}

		public static void ZC_ATTENDANCE_REWARD_CHECK_UI_ON(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_ATTENDANCE_REWARD_CHECK_UI_ON);
			packet.PutShort(0);

			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_ADDITIONAL_SKILL_POINT to character, something about additional skill points?
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_ADDITIONAL_SKILL_POINT(Character character)
		{
			var packet = new Packet(Op.ZC_ADDITIONAL_SKILL_POINT);
			packet.PutInt(0);
			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sends ZC_SET_DAYLIGHT_INFO to character, something about daylight info?
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_SET_DAYLIGHT_INFO(Character character)
		{
			var packet = new Packet(Op.ZC_SET_DAYLIGHT_INFO);
			packet.PutInt(292);
			packet.PutLong(1);
			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sends ZC_SET_DAYLIGHT_INFO to character, something about daylight info?
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_DAYLIGHT_FIXED(Character character)
		{
			var packet = new Packet(Op.ZC_DAYLIGHT_FIXED);
			packet.PutInt(0);
			packet.PutByte(0);
			for (int i = 0; i < 5; i++)
				packet.PutFloat(1f);
			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sends ZC_STAMINA to character, something about daylight info?
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_STAMINA(Character character, int stamina)
		{
			var packet = new Packet(Op.ZC_STAMINA);
			packet.PutInt(stamina);
			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sends ZC_WEEKLY_BOSS_ACCUMULATED_DAMAGE to character, seems to increase each time it's sent
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_WEEKLY_BOSS_ACCUMULATED_DAMAGE(Character character)
		{
			var packet = new Packet(Op.ZC_WEEKLY_BOSS_ACCUMULATED_DAMAGE);
			packet.PutLong(42); // Subsequent packets increase this value
			packet.PutInt(0);
			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sends ZC_PCBANG_SHOP_COMMON to character, something related to PCBANG_SHOP?
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_PCBANG_SHOP_COMMON(Connection conn)
		{
			var packet = new Packet(Op.ZC_PCBANG_SHOP_COMMON);
			packet.PutInt(0x1DF); // 479
			packet.PutInt(0xCB); // 203
			packet.PutInt(0x1DF); // 479
			packet.PutInt(0x1DF); // 479
			packet.PutLong(0); // 0

			packet.PutShort(2021);
			packet.PutShort(7);
			packet.PutShort(3);
			packet.PutShort(28);
			packet.PutLong(0);

			packet.PutShort(2021);
			packet.PutShort(10);
			packet.PutShort(5);
			packet.PutShort(1);
			packet.PutLong(0);
			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_TRUST_INFO to character, something related to Trust Info?
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_TRUST_INFO(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_TRUST_INFO);
			packet.PutEmptyBin(20);
			packet.PutLong(1000000); //
			packet.PutLong(30000000); // 
			packet.PutLong(15000000);
			packet.PutLong(0);
			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_PLAY_ANI to character, Play Animation?
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_PLAY_ANI(Character character, int animationId)
		{
			var packet = new Packet(Op.ZC_PLAY_ANI);
			packet.PutInt(character.Handle);
			packet.PutShort(animationId);
			packet.PutInt(39);
			packet.PutInt(0);
			packet.PutFloat(1f);
			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Sends ZC_COMMON_SKILL_LIST to character, Send Common Skill List
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_COMMON_SKILL_LIST(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_COMMON_SKILL_LIST);
			packet.Zlib(true, zpacket =>
			{
				zpacket.PutEmptyBin(18);
			});
			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_PCBANG_POINT to character
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_PCBANG_POINT(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_COMMON_SKILL_LIST);
			packet.PutInt(-1);
			packet.PutInt(980); //Increasing Value each time this packet is sent
			packet.PutInt(1620); //Max?
			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_MSPD to character
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_MSPD(Character character)
		{
			var packet = new Packet(Op.ZC_MSPD);
			packet.PutInt(character.Handle);
			packet.PutFloat(32f);
			packet.PutLong(0);
			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sends ZC_CUSTOM_COMMANDER_INFO to character
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_CUSTOM_COMMANDER_INFO(Character character)
		{
			var packet = new Packet(Op.ZC_CUSTOM_COMMANDER_INFO);
			packet.PutLong(0);
			packet.PutInt(0);
			packet.PutShort(3);
			packet.PutLong(0);
			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sends ZC_EXEC_CLIENT_SCP to character
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_EXEC_CLIENT_SCP(ChannelConnection conn, string script)
		{
			var packet = new Packet(Op.ZC_EXEC_CLIENT_SCP);
			//CHECK_APPLICATION_LIST("693014448046952")
			packet.PutString(script);
			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_UPDATE_SP to character, regarding SP updates visually?
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_UPDATE_SP(Character character)
		{
			var packet = new Packet(Op.ZC_UPDATE_SP);
			packet.PutInt(character.Handle);
			packet.PutInt(character.Sp);
			packet.PutByte(0);

			character.Map.Broadcast(packet);
		}

		/// <summary>
		/// Sends ZC_SOLO_DUNGEON_RANKING to character
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_SOLO_DUNGEON_RANKING(ChannelConnection conn, List<Character> characters)
		{
			var packet = new Packet(Op.ZC_SOLO_DUNGEON_RANKING);
			packet.PutLong(1);
			packet.PutInt(characters.Count); // Ranker Count
			foreach(var character in characters)
			{
				packet.PutLong(character.AccountId);
				packet.PutLpString(character.Name);
				packet.PutInt(character.Level);
				packet.PutLong(0); // Guild ID? Party ID? Team ID?
				packet.PutLpString(character.TeamName);
				packet.PutLong(character.Id);
				packet.PutInt(character.Level);
				packet.PutInt(17);
				var jobs = character.Jobs.GetList().ToList();
				packet.PutInt(jobs.Count);
				foreach(var job in jobs)
				{
					packet.PutInt((int)job.Id);
				}
				conn.Send(packet);
			}
		}

		/// <summary>
		/// Sends ZC_RESET_VIEW to connection
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_RESET_VIEW(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_RESET_VIEW);
			conn.Send(packet);
		}

		/// <summary>
		/// Notifies the client that the entity is leaving a trigger event.
		/// </summary>
		/// <param name="entity"></param>
		public static void ZC_LEAVE_HOOK(IEntity entity)
		{
			var packet = new Packet(Op.ZC_LEAVE_HOOK);
			packet.PutInt(entity.Handle);
			entity.Map.Broadcast(packet);
		}

		/// <summary>
		/// Not too sure what this does, maybe for store purchases?
		/// </summary>
		/// <param name="entity"></param>
		public static void ZC_SET_WEBSERVICE_URL(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_SET_WEBSERVICE_URL);
			packet.PutString("https://52.58.92.141:9004", 128);
			packet.PutString("https://52.29.227.229:9005", 128);
			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_RESPONSE_FIELD_BOSS_EXIST to character, something related to Map
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_RESPONSE_FIELD_BOSS_EXIST(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_RESPONSE_FIELD_BOSS_EXIST);
			packet.PutInt(1); // 0 usually
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

	public enum FactionType : int
	{
		Player = 1,
		Monster = 2,
		Npc = 3,
	}
}
