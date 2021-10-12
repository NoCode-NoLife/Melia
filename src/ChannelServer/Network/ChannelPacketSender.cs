using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Melia.Channel.Network.Helpers;
using Melia.Channel.Skills;
using Melia.Channel.World;
using Melia.Channel.World.Entities;
using Melia.Channel.World.Entities.Components;
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
			packet.PutFloat(character.MoveSpeed);
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

		/// <summary>
		/// Adds a session object and its properties.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="sessionObject"></param>
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

		/// <summary>
		/// Resets ancient card?
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_ANCIENT_CARD_RESET(ChannelConnection conn)
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
		/// Disables a skill?
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_SKILL_DISABLE(Character character)
		{
			var packet = new Packet(Op.ZC_SKILL_DISABLE);
			packet.PutInt(character.Handle);
			packet.PutByte(0);
			packet.PutInt(1482022400);

			character.Connection.Send(packet);
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
		/// Sends the player's saved hotkeys to the client.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_QUICK_SLOT_LIST(Character character)
		{
			// If no hotkeys were saved yet, we don't need to send anything.
			var serialized = character.Variables.Perm.Get<string>("_QuickSlotList", null);
			if (string.IsNullOrWhiteSpace(serialized))
				return;

			var bin = Convert.FromBase64String(serialized);

			var packet = new Packet(Op.ZC_QUICK_SLOT_LIST);
			packet.PutCompressedBin(bin, bin.Length);

			character.Connection.Send(packet);
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
		/// Cancel a skill cast, usually when a monster has died.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="target"></param>
		public static void ZC_SKILL_CAST_CANCEL(Character character, IEntity target)
		{
			var packet = new Packet(Op.ZC_SKILL_CAST_CANCEL);
			packet.PutInt(target.Handle);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Shows skill use for character, by sending ZC_SKILL_FORCE_TARGET to its connection.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="damage"></param>
		public static void ZC_SKILL_FORCE_TARGET(Character character, IEntity target, Skill skill, int damage)
		{
			var validHit = (target != null && damage > 0);

			var packet = new Packet(Op.ZC_SKILL_FORCE_TARGET);

			packet.PutInt((int)skill.Id);
			packet.PutInt(character.Handle);
			packet.PutFloat(character.Direction.Cos);
			packet.PutFloat(character.Direction.Sin);
			packet.PutInt(1);
			packet.PutFloat(550.7403f); // Skill Particle Distance?
			packet.PutFloat(1);
			packet.PutInt(0);
			packet.PutInt(character.Handle); // Attacker Handle?
			packet.PutFloat(1.089443f); // Bow Attack: 1.089443f Wand: 1.054772
			packet.PutInt(0);
			packet.PutInt(target?.Handle ?? 0);
			packet.PutInt(0);
			packet.PutFloat(512f);
			packet.PutInt(0);

			packet.PutByte(validHit);
			if (validHit)
			{
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
			}

			character.Map.Broadcast(packet);
		}

		/// <summary>
		/// Shows skill use for character, by sending ZC_SKILL_MELEE_GROUND to its connection.
		/// </summary>
		/// <remarks>
		/// i339415, looks hit info is being used instead of this for showing damage on a target
		/// </remarks>
		/// <param name="character"></param>
		/// <param name="skill"></param>
		/// <param name="targetPosition"></param>
		/// <param name="targets"></param>
		/// <param name="damage"></param>
		public static void ZC_SKILL_MELEE_GROUND(Character character, Skill skill, Position targetPosition, IEnumerable<IEntity> targets = null, int damage = 0)
		{
			var targetCount = targets?.Count() ?? 0;

			var packet = new Packet(Op.ZC_SKILL_MELEE_GROUND);

			packet.PutInt((int)skill.Id);
			packet.PutInt(character.Handle);
			packet.PutFloat(character.Direction.Cos);
			packet.PutFloat(character.Direction.Sin);
			packet.PutInt(1);
			packet.PutFloat(skill.Data.ShootTime);
			packet.PutFloat(1);
			packet.PutInt(0);
			packet.PutInt((int)skill.ObjectId); // Attacker Handle?
			packet.PutFloat(1.083666f);

			if (targets != null && targetCount == 1)
				packet.PutInt(targets.First().Handle);
			else
				packet.PutInt(0);

			packet.PutFloat(targetPosition.X);
			packet.PutFloat(targetPosition.Y);
			packet.PutFloat(targetPosition.Z);
			packet.PutShort(targetCount);

			if (targetCount > 0)
			{
				foreach (var target in targets)
				{
					if (target != null && damage > 0)
					{
						packet.PutInt(0x900);
						packet.PutInt(target.Handle);
						packet.PutInt(damage);
						packet.PutInt(target.Hp);
						packet.PutLong(2);
						packet.PutShort(0);
						packet.PutShort(3);
						packet.PutLong(1);
						packet.PutInt(50);
						packet.PutShort(skill.Data.HitDelay);
						packet.PutByte(0);
						packet.PutByte(0); // Attack Index
						packet.PutShort(0);
						packet.PutInt((int)skill.ObjectId); // Skill Handle
						packet.PutInt(0);
						packet.PutShort(0);
						packet.PutShort(1);
					}
				}
			}

			character.Map.Broadcast(packet);
		}

		/// <summary>
		/// Sends overheat data for a character, by sending ZC_OVERHEAT_CHANGED.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="skill"></param>
		public static void ZC_OVERHEAT_CHANGED(Character character, Skill skill)
		{
			var packet = new Packet(Op.ZC_OVERHEAT_CHANGED);

			packet.PutLong(character.Id);
			packet.PutInt(skill.OverheatData.Id);
			packet.PutInt(skill.OverheatCounter * skill.Data.OverHeatDelay); // Increasing OverHeatValue
			packet.PutInt(0);
			packet.PutInt(skill.Data.OverHeatDelay);
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
		/// <param name="skill"></param>
		public static void ZC_COOLDOWN_CHANGED(Character character, Skill skill)
		{
			var packet = new Packet(Op.ZC_COOLDOWN_CHANGED);

			packet.PutLong(character.Id);
			packet.PutInt(skill.CooldownData.Id);
			packet.PutInt(skill.Data.Cooldown);
			packet.PutInt(skill.Data.Cooldown);
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
		/// Sends ZC_OPTION_LIST to client, containing the saved
		/// account options, like "Show Exp Aquired".
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_OPTION_LIST(ChannelConnection conn)
		{
			// Officials don't always send all options, but only the ones
			// that were changed from their default values, resulting in
			// an empty string in this packet if no options were changed
			// yet. We could technically do that as well, but we'd need
			// an options db, for the defaults. And it's one packet with
			// 500 bytes, that's sent once on login. Who cares?

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
				var npcIds = new int[] { 4, 28, 2019, 2031, 2032 };

				packet.PutInt(npcIds.Length);
				// TODO: Isn't this packet missing a short here?

				packet.Zlib(true, zpacket =>
				{
					for (var i = 0; i < npcIds.Length; i++)
					{
						zpacket.PutInt(character.MapId);
						zpacket.PutInt(npcIds[i]);
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
		/// Updates an NPC's state on all clients in range of it.
		/// </summary>
		/// <param name="npc"></param>
		public static void ZC_SET_NPC_STATE(Monster npc)
		{
			var packet = new Packet(Op.ZC_SET_NPC_STATE);

			packet.PutInt(npc.Map.Id);
			packet.PutInt(npc.GenType);
			packet.PutShort((short)npc.State);
			packet.PutEmptyBin(2);

			npc.Map.Broadcast(packet, npc, false);
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
			var abilities = character.Abilities.GetList();

			var packet = new Packet(Op.ZC_ABILITY_LIST);
			packet.PutShort(0);
			packet.PutByte(1);
			packet.PutInt(abilities.Length);

			foreach (var ability in abilities)
			{
				var properties = ability.Properties.GetAll();
				var propertiesSize = ability.Properties.Size;

				packet.PutLong(ability.ObjectId);
				packet.PutInt(ability.Id);
				packet.PutShort(propertiesSize);
				packet.PutShort(0);

				if (propertiesSize > 0)
					packet.AddProperties(properties);
				else
					packet.PutInt(0);
			}

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
			packet.PutFloat(character.MoveSpeed);
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
			packet.PutFloat(character.Properties.GetFloat(PropertyId.PC.CastingSpeed));
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
		/// Sends ZC_ITEM_INVENTORY_DIVISION_LIST to character, containing
		/// a list of all items in their inventory.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_ITEM_INVENTORY_DIVISION_LIST(Character character)
		{
			var items = character.Inventory.GetItems();

			var packet = new Packet(Op.ZC_ITEM_INVENTORY_DIVISION_LIST);

			packet.PutInt(items.Count);
			packet.PutByte(1);
			packet.PutByte(1);

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
					zpacket.PutInt(0);
					zpacket.PutInt(item.Key);
					zpacket.AddProperties(properties);

					if (item.Value.ObjectId != 0)
					{
						zpacket.PutShort(0);
						zpacket.PutLong(item.Value.ObjectId);
						zpacket.PutShort(0);
					}
				}
			});

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
				var properties = equipItem.Value.Properties.GetAll();
				var propertiesSize = equipItem.Value.Properties.Size;

				packet.PutInt(equipItem.Value.Id);
				packet.PutShort(propertiesSize);
				packet.PutEmptyBin(2);
				packet.PutLong(equipItem.Value.ObjectId);
				packet.PutByte((byte)equipItem.Key);
				packet.PutEmptyBin(3);
				packet.PutInt(0);
				packet.PutShort(0);
				packet.AddProperties(properties);

				if (equipItem.Value.ObjectId != 0)
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
		/// Unequips an item and optionally shows a UI message.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="item"></param>
		public static void ZC_EQUIP_GEM_INFO(Character character, Item item)
		{
			var packet = new Packet(Op.ZC_EQUIP_GEM_INFO);
			packet.PutInt(1); // Gem Count?
			packet.Zlib(true, zpacket =>
			{
				zpacket.PutLong(item.ObjectId);
				zpacket.PutShort(0); // Gem Data? Property Size?
			});

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
			packet.PutEmptyBin(16); // [i339415] ?
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
			packet.PutByte(1); // type? 0 = also show in red letters on the screen
			packet.PutLong(0); // added i219527
			packet.PutByte(0); // added i336041
			packet.PutByte(0); // added i339415

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
		/// <param name="pos"></param>
		/// <param name="dir"></param>
		/// <param name="unkFloat"></param>
		/// <param name="unkByte"></param>
		public static void ZC_JUMP(Character character, Position pos, Direction dir, float unkFloat, byte unkByte)
		{
			var packet = new Packet(Op.ZC_JUMP);

			packet.PutInt(character.Handle);
			packet.PutFloat(character.Properties.GetFloat(PropertyId.PC.JumpPower));
			packet.PutInt(character.GetJumpType());
			packet.PutByte(0);  // 1 or 0
			packet.PutPosition(pos);
			packet.PutDirection(dir);
			packet.PutFloat(unkFloat);
			packet.PutEmptyBin(13);
			packet.PutLong(unkByte);
			packet.PutShort(0);
			packet.PutByte(0);

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Update's the character's sitting status, either making them
		/// sit down or stand up.
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
			// For some reason this packet requires properties on the item,
			// otherwise the client crashes. Let's catch this here for the
			// moment, as it seems to be an issue exclusive to this packet,
			// and maybe we'll figure out why exactly it happens.
			var properties = item.Properties.GetAll();
			if (properties.Length == 0)
				properties = new[] { new FloatProperty(PropertyId.Item.CoolDown, 0) };

			var propertiesSize = properties.Sum(a => a.Size);

			var packet = new Packet(Op.ZC_ITEM_ADD);

			packet.PutLong(item.ObjectId);
			packet.PutInt(amount);
			packet.PutInt(0);
			packet.PutInt(index);
			packet.PutInt(item.Id);
			packet.PutShort(propertiesSize);
			packet.PutByte((byte)addType);
			packet.PutFloat(0f); // Notification delay
			packet.PutByte(0); // InvType
			packet.PutByte(0);
			packet.PutByte(0);
			packet.AddProperties(properties);

			if (item.ObjectId != 0)
			{
				packet.PutShort(0);
				packet.PutLong(item.ObjectId);
				packet.PutShort(0);
			}

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
		/// <param name="character"></param>
		/// <param name="ip"></param>
		/// <param name="port"></param>
		/// <param name="mapId"></param>
		public static void ZC_MOVE_ZONE_OK(Character character, string ip, int port, int mapId)
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
			packet.PutLong(character.Id);

			character.Connection.Send(packet);
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
			=> ZC_OBJECT_PROPERTY(conn, obj.ObjectId, obj.Properties.GetAll());

		/// <summary>
		/// Updates object's given properties.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="obj"></param>
		/// <param name="properties"></param>
		public static void ZC_OBJECT_PROPERTY(ChannelConnection conn, IPropertyObject obj, Properties properties)
			=> ZC_OBJECT_PROPERTY(conn, obj.ObjectId, properties.GetAll());

		/// <summary>
		/// Updates object's given properties.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="obj"></param>
		/// <param name="propertyIds"></param>
		public static void ZC_OBJECT_PROPERTY(ChannelConnection conn, IPropertyObject obj, params int[] propertyIds)
			=> ZC_OBJECT_PROPERTY(conn, obj.ObjectId, obj.Properties.GetAll(propertyIds));

		/// <summary>
		/// Updates object's given properties.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="objectId"></param>
		/// <param name="properties"></param>
		public static void ZC_OBJECT_PROPERTY(ChannelConnection conn, long objectId, IEnumerable<IProperty> properties)
		{
			var packet = new Packet(Op.ZC_OBJECT_PROPERTY);

			packet.PutLong(objectId);
			packet.PutInt(0); // isTrickPacket
			packet.AddProperties(properties);

			conn.Send(packet);
		}

		/// <summary>
		/// Updates character's rotation for characters in range of it.
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
			packet.PutInt(0);

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Updates character's head rotation for characters in range of it.
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
			packet.PutByte((byte)arguments.Length);

			// If both bytes are 0, the message before the selection is
			// displayed as expected. First the message, then the options
			// pop up. If only the first byte is 1, the options and the
			// message both immediately appear together, and if only the
			// second byte is set, only the NPC portrait appears. If both
			// are 1, only the options appear, without message.
			// This might be useful for selection boxes without dialog.
			packet.PutByte(0); // [i171032] ?
			packet.PutByte(0); // [i337645] ?

			packet.PutShort(0); // [i337645] ?

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
			var s1 = 1;

			// Items don't seem to disappear with our default, 1, nor with
			// 2, which is used on officials. 4 does get rid of the items
			// though. However, if you use 4, the pick up animation doesn't
			// play. I'm guessing the item can't be removed if it's supposed
			// to get picked up for this very reason, so we'll check whether
			// it was picked up or not.
			if (entity is ItemMonster itemMonster)
				s1 = itemMonster.PickedUp ? 2 : 4;

			var packet = new Packet(Op.ZC_LEAVE);

			packet.PutInt(entity.Handle);
			packet.PutShort(s1); // 0 shows a blue effect when the entity disappears

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
		public static void ZC_HIT_INFO(IEntity attacker, IEntity target, int damage, int attackIndex = 0)
		{
			var packet = new Packet(Op.ZC_HIT_INFO);

			packet.PutInt(target.Handle);
			packet.PutInt(attacker.Handle);
			packet.PutInt(100);
			packet.PutInt(damage);
			packet.PutInt(target.Hp);
			packet.PutInt(attackIndex);
			packet.PutInt(0);
			packet.PutByte(0);
			packet.PutByte(104);
			packet.PutShort(3);
			packet.PutByte(1);
			packet.PutByte(64);
			packet.PutLong(1);
			packet.PutLong(0);
			packet.PutByte(0);
			packet.PutFloat(0);
			packet.PutLong(0);
			packet.PutLong(1);
			packet.PutByte(0);

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
			var validHit = (target != null && damage > 0);

			var packet = new Packet(Op.ZC_SKILL_HIT_INFO);

			packet.PutInt(attacker.Handle);
			packet.PutByte(validHit);

			if (validHit)
			{
				packet.PutBinFromHex("00 09 00 00");
				packet.PutInt(target.Handle);
				packet.PutInt(damage);
				packet.PutInt(target.Hp);
				packet.PutInt(3); //attackCount?
				packet.PutInt(1);
				packet.PutShort(0);
				packet.PutShort(3);
				packet.PutInt(1);
				packet.PutInt(0);
				packet.PutInt(306);
				packet.PutShort(0x63);
				packet.PutByte(3);
				packet.PutByte(1);
				packet.PutInt(0);
				packet.PutInt(attacker.Handle); // Attacker Handle?
				packet.PutInt(0);
				packet.PutShort(0);
				packet.PutShort(1);
				packet.PutByte(3);
				packet.PutFloat(-1845);
			}

			target.Map.Broadcast(packet);
		}

		/// <summary>
		/// Updates character's level.
		/// </summary>
		/// <param name="character"></param>
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
		/// Skill Related ZC_Normal Packet
		/// </summary>
		/// <param name="character"></param>
		/// <param name="position"></param>
		public static void ZC_NORMAL_Unknown_06(Character character, Position position)
		{
			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(SubOp.Zone.Unknown_06);

			packet.PutInt(character.Handle);
			packet.PutInt(280015);
			packet.PutFloat(0.6f);
			packet.PutInt(1150041);
			packet.PutFloat(0.6f);
			packet.PutFloat(position.X);
			packet.PutFloat(position.Y);
			packet.PutFloat(position.Z);
			packet.PutFloat(30);
			packet.PutFloat(0.2f);
			packet.PutFloat(0);
			packet.PutFloat(0);
			packet.PutFloat(1);
			packet.PutLong(0);
			packet.PutLpString("None");

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Adjusts the skill speed for a skill.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="target"></param>
		/// <param name="position"></param>
		public static void ZC_NORMAL_Skill_16(Character character, IEntity target, Position position)
		{
			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(SubOp.Zone.Skill_16);

			packet.PutInt(target.Handle);
			packet.PutInt(character.Handle);
			packet.PutInt(character.Handle);
			packet.PutInt(target.Handle);
			packet.PutInt(2220111);
			packet.PutFloat(1);
			packet.PutInt(2561933);
			packet.PutInt(190068);
			packet.PutFloat(1);
			packet.PutInt(2561934);
			packet.PutInt(2561931);
			packet.PutFloat(150);
			packet.PutEmptyBin(16);
			packet.PutFloat(5);
			packet.PutFloat(5);
			packet.PutFloat(2);
			packet.PutInt(0);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Attack broadcast?
		/// </summary>
		/// <param name="character"></param>
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
		public static void ZC_NORMAL_Skill_4E(Character character, SkillId skillId, float value)
		{
			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(SubOp.Zone.Skill_4E);

			packet.PutInt((int)skillId);
			packet.PutFloat(value);
			packet.PutByte(0);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Unknown skill related
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_NORMAL_SkillParticleEffect(Character character, int skillActorId)
		{
			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(SubOp.Zone.SkillParticleEffect);

			packet.PutInt(character.Handle);
			packet.PutInt(skillActorId);
			packet.PutInt(character.Hp);
			packet.PutShort(6904);
			packet.PutShort(39);
			packet.PutFloat(25);
			packet.PutLpString("Melee");
			packet.PutLong(0);

			character.Connection.Send(packet);
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
			packet.PutUInt((uint)Math2.Clamp(0, uint.MaxValue, character.TotalExp));
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
		/// <param name="duration">Duration that messages are displayed in seconds?</param>
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
		/// For available emoticons, search the packet string data for
		/// entries with "_emo_" in the name.
		/// </remarks>
		/// <param name="entity"></param>
		/// <param name="emoticonName">Name of the emoticon, uses packet string data to look up the id of the string.</param>
		/// <param name="duration"></param>
		public static void ZC_SHOW_EMOTICON(IEntity entity, string emoticonName, int duration)
		{
			if (!ChannelServer.Instance.Data.PacketStringDb.TryFind(emoticonName, out var packetStringData))
				throw new ArgumentException($"Unknown packet string '{emoticonName}'.");

			ZC_SHOW_EMOTICON(entity, packetStringData.Id, duration);
		}

		/// <summary>
		/// Shows emoticon for entity.
		/// </summary>
		/// <remarks>
		/// For available emoticons, search the packet string data for
		/// entries with "_emo_" in the name.
		/// </remarks>
		/// <param name="entity"></param>
		/// <param name="packetStringId">Id of the string for the emoticon from the packet string data.</param>
		/// <param name="duration"></param>
		public static void ZC_SHOW_EMOTICON(IEntity entity, int packetStringId, int duration)
		{
			var packet = new Packet(Op.ZC_SHOW_EMOTICON);

			packet.PutInt(entity.Handle);
			packet.PutInt(packetStringId);
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
				packet.PutShort(0);
			}
			else
			{
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
		/// <param name="entity"></param>
		/// <param name="shield"></param>
		public static void ZC_UPDATE_SHIELD(IEntity entity, int shield)
		{
			var packet = new Packet(Op.ZC_UPDATE_SHIELD);
			packet.PutInt(entity.Handle);
			packet.PutInt(shield);

			entity.Map.Broadcast(packet, entity);
		}

		/// <summary>
		/// Broadcasts ZC_MOVE_DIR in range of character, informing other
		/// characters about the movement.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="pos"></param>
		/// <param name="dir"></param>
		/// <param name="unkFloat"></param>
		public static void ZC_MOVE_DIR(Character character, Position pos, Direction dir, float unkFloat)
		{
			var packet = new Packet(Op.ZC_MOVE_DIR);

			packet.PutInt(character.Handle);
			packet.PutPosition(pos);
			packet.PutDirection(dir);
			packet.PutByte(1); // 0 = reduced movement speed... walk mode?
			packet.PutFloat(character.MoveSpeed);
			packet.PutFloat(unkFloat);
			packet.PutEmptyBin(24);
			packet.PutInt(6);
			packet.PutInt(0);
			packet.PutByte(1);

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Broadcasts ZC_MOVE_STOP in range of character, informing other
		/// characters about the movement stop.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="pos"></param>
		public static void ZC_MOVE_STOP(Character character, Position pos)
		{
			var packet = new Packet(Op.ZC_MOVE_STOP);

			packet.PutInt(character.Handle);
			packet.PutPosition(pos);
			packet.PutByte(0);

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Broadcasts ZC_PC_MOVE_STOP in range of character, informing other
		/// characters about the movement stop.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="pos"></param>
		/// <param name="dir"></param>
		public static void ZC_PC_MOVE_STOP(Character character, Position pos, Direction dir)
		{
			var packet = new Packet(Op.ZC_PC_MOVE_STOP);

			packet.PutInt(character.Handle);
			packet.PutPosition(pos);
			packet.PutByte(1);
			packet.PutDirection(dir);
			packet.PutFloat(228787.3f); // timestamp
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

		/// <summary>
		/// Inform client that the skill is ready
		/// </summary>
		/// <param name="character"></param>
		/// <param name="id"></param>
		/// <param name="position1"></param>
		/// <param name="position2"></param>
		public static void ZC_SKILL_READY(Character character, Skill skill, Position position1, Position position2)
		{
			var packet = new Packet(Op.ZC_SKILL_READY);

			packet.PutInt(character.Handle);
			packet.PutInt((int)skill.Id);
			packet.PutFloat(1);
			packet.PutFloat(1);
			packet.PutInt(character.Handle);
			packet.PutFloat(position1.X);
			packet.PutFloat(position1.Y);
			packet.PutFloat(position1.Z);
			packet.PutFloat(position2.X);
			packet.PutFloat(position2.Y);
			packet.PutFloat(position2.Z);

			character.Connection.Send(packet);
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
		/// <param name="entity"></param>
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
		/// <param name="skill"></param>
		/// <param name="position"></param>
		/// <param name="direction"></param>
		/// <param name="create"></param>
		public static void ZC_NORMAL_Skill(Character character, Skill skill, Position position, Direction direction, bool create)
		{
			var actorId = 1234; // ActorId (entity unique id for this skill)
			var distance = 20.0f; // Distance to caster? Not sure. Observed values (20, 40, 80)

			var skillState = 0; // skillState seems to be an ENUM of animation states (0 = initial animation, 1 = touched animation)
			if (!create)
				skillState = 1;

			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(SubOp.Zone.Skill);
			packet.PutInt(character.Handle);
			//packet.PutBinFromHex("11 18 27 00"); // Heal skill effect
			packet.PutInt(0);
			packet.PutInt((int)skill.Id);
			packet.PutInt(skill.Level); // Skill Level ?
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
			packet.PutFloat(10); // Count
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
		/// Makes monster fade out over the given amount of time.
		/// </summary>
		/// <param name="monster"></param>
		/// <param name="duration"></param>
		public static void ZC_NORMAL_FadeOut(Monster monster, TimeSpan duration)
		{
			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(SubOp.Zone.FadeOut);

			packet.PutInt(monster.Map.Id);
			packet.PutInt(monster.GenType);
			packet.PutFloat((float)duration.TotalSeconds);

			monster.Map.Broadcast(packet, monster, false);
		}

		/// <summary>
		/// Makes item monster appear to drop, by "throwing" it a certain
		/// distance from its current position.
		/// </summary>
		/// <param name="monster"></param>
		/// <param name="direction"></param>
		/// <param name="distance"></param>
		public static void ZC_NORMAL_ItemDrop(Monster monster, Direction direction, float distance)
		{
			// The distance might be more like a force, since items fly
			// farther than they should with high distances. Whether this
			// is a problem, depends on the used distance and the pick up
			// range. With a very small pick up range, like 10, and a high
			// distance, like 110, there will be a slight desync, and you
			// might not get the item, even if you're right on top of it.
			// But since we won't usually use such small and high values,
			// it will probably be fine.

			var packet = new Packet(Op.ZC_NORMAL);
			packet.PutInt(SubOp.Zone.ItemDrop);

			packet.PutInt(monster.Handle);
			packet.PutInt((int)direction.NormalDegreeAngle);
			packet.PutFloat(distance);

			monster.Map.Broadcast(packet, monster, false);
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
		/// Draws circle area on ground at position for characters in range
		/// of the source entity.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="position"></param>
		/// <param name="radius"></param>
		public static void ZC_SKILL_RANGE_CIRCLE(IEntity caster, Position position, float radius)
		{
			var packet = new Packet(Op.ZC_SKILL_RANGE_CIRCLE);

			packet.PutInt(caster.Handle);
			packet.PutEmptyBin(2);
			packet.PutFloat(position.X);
			packet.PutFloat(position.Y);
			packet.PutFloat(position.Z);
			packet.PutFloat(radius);
			packet.PutInt(1); // 0 = not drawn
			packet.PutInt(0); // 1 = drawn weaker?

			caster.Map.Broadcast(packet, caster);
		}

		/// <summary>
		/// Draws fan area on ground at position for characters in range
		/// of the source entity.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="position"></param>
		/// <param name="direction"></param>
		/// <param name="radius"></param>
		/// <param name="radianHalfAngle"></param>
		public static void ZC_SKILL_RANGE_FAN(IEntity caster, Position position, Direction direction, float radius, float radianHalfAngle)
		{
			var packet = new Packet(Op.ZC_SKILL_RANGE_FAN);

			packet.PutInt(caster.Handle);
			packet.PutFloat(position.X);
			packet.PutFloat(position.Y);
			packet.PutFloat(position.Z);
			packet.PutFloat(direction.Cos);
			packet.PutFloat(direction.Sin);
			packet.PutFloat(radius);
			packet.PutFloat(radianHalfAngle);
			packet.PutInt(1); // 0 = not drawn
			packet.PutInt(0);

			caster.Map.Broadcast(packet, caster);
		}

		/// <summary>
		/// Draws square area on ground at position for characters in range
		/// of the source entity.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="position"></param>
		/// <param name="targetPosition"></param>
		/// <param name="width"></param>
		public static void ZC_SKILL_RANGE_SQUARE(IEntity caster, Position position, Position targetPosition, float width)
		{
			var packet = new Packet(Op.ZC_SKILL_RANGE_SQUARE);

			packet.PutInt(caster.Handle);
			packet.PutEmptyBin(2);
			packet.PutFloat(position.X);
			packet.PutFloat(position.Y);
			packet.PutFloat(position.Z);
			packet.PutFloat(targetPosition.X);
			packet.PutFloat(targetPosition.Y);
			packet.PutFloat(targetPosition.Z);
			packet.PutFloat(width);
			packet.PutInt(1); // 0 = not drawn
			packet.PutInt(0);

			caster.Map.Broadcast(packet, caster);
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
		/// <param name="maxHp"></param>
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
		/// Updates creature's HP and SP stats.
		/// </summary>
		/// <param name="entity"></param>
		public static void ZC_UPDATE_ALL_STATUS(IEntity entity)
		{
			var hp = entity.Properties.GetInt(PropertyId.PC.HP);
			var maxHp = entity.Properties.GetInt(PropertyId.PC.MHP);
			var sp = entity.Properties.GetInt(PropertyId.PC.SP);
			var maxSp = entity.Properties.GetInt(PropertyId.PC.MSP);

			var packet = new Packet(Op.ZC_UPDATE_ALL_STATUS);

			packet.PutInt(entity.Handle);
			packet.PutInt(hp);
			packet.PutInt(maxHp);
			packet.PutInt(sp);
			packet.PutInt(maxSp);
			packet.PutInt(0);

			entity.Map.Broadcast(packet, entity);
		}

		/// <summary>
		/// Updates character's HP or SP and displays a floating text
		/// with the modifier, notifying the player of the change.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="amount"></param>
		/// <param name="max"></param>
		/// <param name="type"></param>
		public static void ZC_HEAL_INFO(Character character, int amount, int max, HealType type)
		{
			var packet = new Packet(Op.ZC_HEAL_INFO);

			packet.PutInt(character.Handle);
			packet.PutInt(amount);
			packet.PutInt(max);
			packet.PutInt(1);
			packet.PutInt(0);
			packet.PutInt((int)type); // !0 = blue text
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
		/// Sets the faction of the entity.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="entity"></param>
		/// <param name="faction"></param>
		public static void ZC_FACTION(ChannelConnection conn, IEntity entity, FactionType faction)
		{
			var packet = new Packet(Op.ZC_FACTION);

			packet.PutInt(entity.Handle);
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

			var defaultList = ChannelServer.Instance.Data.HelpDb.Entries.Values.Where(a => a.BasicHelp);

			var packet = new Packet(Op.ZC_HELP_LIST);

			packet.PutInt(defaultList.Count());
			foreach (var data in defaultList)
			{
				packet.PutInt(data.Id);
				packet.PutByte(0); // Unknown, maybe "has seen" toggle?
			}

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Requests the client to send information that needs to be saved
		/// before exiting?
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

			packet.PutBinFromHex("090000ED4D104918730100000000007C2C060027CE01000000000000000000A0860100000000007E2C060027CE01000000000000000000905F0100000000007A2C060027CE01000000000018010000300500000B0053746172744C696E653100E48F01008035394808930100803539480E8F0100803539487A8D01008035394866A2010080473948C3A2010080473948A6A2010080473948B6A201008047394880A2010080473948C48F0100803539487EA2010080473948B1A201008047394875A201008047394876270000002239486AA2010080473948429301000000803F8EA20100804739487D8D0100803539480C9301000900323032313038313600108F0100803539486999010000D8F645788D01008035394890A201008047394868A2010080473948B2A2010080473948AD0700008023394895A2010080473948AAA20100804739480793010080353948850A0000000096436F8D0100803539488CA201008047394860EA000000000000812C060027CE010000000000000000000077010000000000802C060027CE01000000000000000000A03A000000000000822C060027CE0100000000000000000003000000000000007F2C060027CE0100000000000000000081380100000000007D2C060027CE0100000000001900000079290000F0120A497A2900000B002D3537332F2D313235380080380100000000007B2C060027CE01000000000000000000");
			/**
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
			**/

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
			packet.PutBinFromHex("71820100010000000000000000000100008000000000D86E");

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

		/// <summary>
		/// Sends PC Bang rental item list to client (dummy)..
		/// </summary>
		/// <param name="conn"></param>
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

		/// <summary>
		/// Sends ZC_ATTENDANCE_REWARD_CHECK_UI_ON to client (dummy).
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_ATTENDANCE_REWARD_CHECK_UI_ON(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_ATTENDANCE_REWARD_CHECK_UI_ON);
			packet.PutShort(0);

			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_ADDITIONAL_SKILL_POINT to character (dummy).
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_ADDITIONAL_SKILL_POINT(Character character)
		{
			var packet = new Packet(Op.ZC_ADDITIONAL_SKILL_POINT);
			packet.PutInt(0);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sends ZC_SET_DAYLIGHT_INFO to character (dummy).
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
		/// Sends ZC_SET_DAYLIGHT_INFO to character (dummy).
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_DAYLIGHT_FIXED(Character character)
		{
			var packet = new Packet(Op.ZC_DAYLIGHT_FIXED);

			packet.PutInt(0);
			packet.PutByte(0);
			for (var i = 0; i < 5; i++)
				packet.PutFloat(1);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Updates character's stamina.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="stamina"></param>
		public static void ZC_STAMINA(Character character, int stamina)
		{
			var packet = new Packet(Op.ZC_STAMINA);
			packet.PutInt(stamina);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sends ZC_WEEKLY_BOSS_ACCUMULATED_DAMAGE to character (dummy).
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
		/// Sends ZC_PCBANG_SHOP_COMMON to character (dummy).
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
		/// Sends ZC_TRUST_INFO to character (dummy).
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_TRUST_INFO(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_TRUST_INFO);

			packet.PutEmptyBin(20);
			packet.PutLong(1000000);
			packet.PutLong(30000000);
			packet.PutLong(15000000);
			packet.PutLong(0);

			conn.Send(packet);
		}

		/// <summary>
		/// Plays animation on entity.
		/// </summary>
		/// <param name="entity">Entity to animate.</param>
		/// <param name="animationName">Name of the animation to play (uses packet string database to retrieve the id of the string).</param>
		/// <param name="stopOnLastFrame">If true, the animation plays once and then stops on the last frame.</param>
		public static void ZC_PLAY_ANI(IEntity entity, string animationName, bool stopOnLastFrame = false)
		{
			if (!ChannelServer.Instance.Data.PacketStringDb.TryFind(animationName, out var packetStringData))
				throw new ArgumentException($"Unknown packet string '{animationName}'.");

			ZC_PLAY_ANI(entity, packetStringData.Id, stopOnLastFrame);
		}

		/// <summary>
		/// Plays animation on entity.
		/// </summary>
		/// <param name="entity">Entity to animate.</param>
		/// <param name="packetStringId">Id of the string for the animation to play.</param>
		/// <param name="stopOnLastFrame">If true, the animation plays once and then stops on the last frame.</param>
		public static void ZC_PLAY_ANI(IEntity entity, int packetStringId, bool stopOnLastFrame = false)
		{
			var packet = new Packet(Op.ZC_PLAY_ANI);

			packet.PutInt(entity.Handle);
			packet.PutInt(packetStringId);
			packet.PutByte(stopOnLastFrame);
			packet.PutByte(0);
			packet.PutFloat(0);
			packet.PutFloat(1);

			entity.Map.Broadcast(packet, entity);
		}

		/// <summary>
		/// Sends ZC_COMMON_SKILL_LIST to character (dummy).
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_COMMON_SKILL_LIST(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_COMMON_SKILL_LIST);

			// TODO: Update compressed section. Seems like the packet
			//   is shorter now by default?

			//packet.Zlib(true, zpacket => { zpacket.PutEmptyBin(18); });
			packet.PutBinFromHex("000000008DFA02000000030000000000000000000000000000000000");

			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_PCBANG_POINT to character (dummy).
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_PCBANG_POINT(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_COMMON_SKILL_LIST);

			packet.PutInt(-1);
			packet.PutInt(980); //Increasing Value each time this packet is sent
			packet.PutInt(1620); //Max?

			conn.Send(packet);
		}

		/// <summary>
		/// Updates character's movement speed.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_MSPD(Character character)
		{
			var packet = new Packet(Op.ZC_MSPD);

			packet.PutInt(character.Handle);
			packet.PutFloat(character.MoveSpeed);
			packet.PutLong(0);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sends ZC_CUSTOM_COMMANDER_INFO to character (dummy).
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="type"></param>
		/// <param name="amount"></param>
		public static void ZC_CUSTOM_COMMANDER_INFO(ChannelConnection conn, int type = 3, int amount = 0)
		{
			var packet = new Packet(Op.ZC_CUSTOM_COMMANDER_INFO);

			packet.PutLong(0);
			packet.PutInt(0);
			packet.PutShort(type); // Attribute Points = 3
			packet.PutInt(amount);
			packet.PutInt(0);

			conn.Send(packet);
		}

		/// <summary>
		/// Sends Lua script to client for execution.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="script"></param>
		public static void ZC_EXEC_CLIENT_SCP(ChannelConnection conn, string script)
		{
			var packet = new Packet(Op.ZC_EXEC_CLIENT_SCP);
			packet.PutString(script); // CHECK_APPLICATION_LIST("693014448046952")

			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_SOLO_DUNGEON_RANKING to character (dummy).
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_SOLO_DUNGEON_RANKING(ChannelConnection conn, List<Character> characters)
		{
			var packet = new Packet(Op.ZC_SOLO_DUNGEON_RANKING);

			packet.PutLong(1);
			packet.PutInt(characters.Count); // Ranker Count
			foreach (var character in characters)
			{
				var jobs = character.Jobs.GetList().ToList();

				packet.PutLong(character.AccountId);
				packet.PutLpString(character.Name);
				packet.PutInt(character.Level);
				packet.PutLong(0); // Guild ID? Party ID? Team ID?
				packet.PutLpString(character.TeamName);
				packet.PutLong(character.Id);
				packet.PutInt(character.Level);
				packet.PutInt(17);

				packet.PutInt(jobs.Count);
				foreach (var job in jobs)
					packet.PutInt((int)job.Id);
			}

			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_RESET_VIEW to connection (dummy).
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
		/// <param name="conn"></param>
		public static void ZC_SET_WEBSERVICE_URL(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_SET_WEBSERVICE_URL);

			packet.PutString("https://52.58.92.141:9004", 128);
			packet.PutString("https://52.29.227.229:9005", 128);

			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_RESPONSE_FIELD_BOSS_EXIST to character (dummy).
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_RESPONSE_FIELD_BOSS_EXIST(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_RESPONSE_FIELD_BOSS_EXIST);
			packet.PutInt(1); // 0 usually

			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_WEEKLY_BOSS_NOW_WEEK_NUM to character (dummy).
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_WEEKLY_BOSS_NOW_WEEK_NUM(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_WEEKLY_BOSS_NOW_WEEK_NUM);
			packet.PutInt(0x49);

			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_RESPONSE_BORUTA_NOW_WEEK_NUM to character (dummy).
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_RESPONSE_BORUTA_NOW_WEEK_NUM(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_RESPONSE_BORUTA_NOW_WEEK_NUM);
			packet.PutInt(0x38);

			conn.Send(packet);
		}

		/// <summary>
		/// Unknown purpose, sent when changing map and tutorial related?
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="enabled"></param>
		public static void ZC_ENABLE_CONTROL(ChannelConnection conn, bool enabled)
		{
			//	var packet = new Packet(Op.ZC_ENABLE_CONTROL);
			//	packet.PutInt(0);
			//	packet.PutByte(enabled);
			//	conn.Send(packet);

			var packet = new Packet(Op.ZC_ENABLE_CONTROL);

			packet.PutInt(0);
			packet.PutString("TUTORIAL_DIRECT");
			packet.PutShort(0);
			packet.PutLong(0x48); // 72
			packet.PutInt(0);

			if (enabled)
			{
				packet.PutInt(0); // 32760 or 0
				packet.PutInt(17314416);
				packet.PutInt(0);
				packet.PutInt(1075545872);
				packet.PutInt(1);
			}
			else
			{
				packet.PutInt(32760); // 32760 or 0
				packet.PutInt(0);
				packet.PutInt(0);
				packet.PutInt(0);
				packet.PutInt(0);
			}

			packet.PutLong(3037879632);
			packet.PutInt(15);
			packet.PutShort(0);
			packet.PutByte(enabled); // 0 or 1

			conn.Send(packet);
		}

		/// <summary>
		/// Unknown purpose, sent when changing map and tutorial related?
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_LOCK_KEY(ChannelConnection conn)
		{
			var packet = new Packet(Op.ZC_LOCK_KEY);

			packet.PutString("TUTORIAL_DIRECT");
			packet.PutLong(0);
			packet.PutInt(0xAA); // 170
			packet.PutShort(0);
			packet.PutInt(-1);
			packet.PutInt(0);
			packet.PutFloat(3.387241f);
			packet.PutInt(1);
			packet.PutFloat(-414.8486f);
			packet.PutInt(0);
			packet.PutByte(0x89);
			packet.PutByte(0xE5);
			packet.PutShort(32001);
			packet.PutShort(728);
			packet.PutByte(0);

			conn.Send(packet);
		}

		/// <summary>
		/// Shifts in-game camera to create cinematic effect, isn't removed
		/// automatically.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_CREATE_SCROLLLOCKBOX(Character character)
		{
			var packet = new Packet(Op.ZC_CREATE_SCROLLLOCKBOX);

			packet.PutInt(character.Handle); // 26717
			packet.PutFloat(-1352);
			packet.PutFloat(0);
			packet.PutFloat(-784);
			packet.PutFloat(-878);
			packet.PutFloat(0);
			packet.PutFloat(-310);
			packet.PutFloat(474);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Remove scroll lock box.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_REMOVE_SCROLLLOCKBOX(Character character)
		{
			var packet = new Packet(Op.ZC_REMOVE_SCROLLLOCKBOX);
			packet.PutInt(character.Handle);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Unknown Purpose.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="messageId"></param>
		public static void ZC_SHARED_MSG(ChannelConnection conn, int messageId)
		{
			var packet = new Packet(Op.ZC_SHARED_MSG);
			packet.PutInt(messageId);

			conn.Send(packet);
		}

		/// <summary>
		/// Resets overheat?
		/// </summary>
		/// <param name="character"></param>
		/// <param name="i1"></param>
		/// <param name="overheat"></param>
		public static void ZC_OVERHEAT_RESET_TIME(Character character, int i1, int overheat)
		{
			var packet = new Packet(Op.ZC_OVERHEAT_RESET_TIME);

			packet.PutLong(character.Id);
			packet.PutInt(i1); // 1551 or 2255
			packet.PutInt(overheat);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Unknown Purpose.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="skillActorId"></param>
		/// <param name="f1"></param>
		public static void ZC_SYNC_START(Character character, int skillActorId, float f1)
		{
			var packet = new Packet(Op.ZC_SYNC_START);

			packet.PutInt(skillActorId);
			packet.PutFloat(f1);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Unknown Purpose.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="skillActorId"></param>
		/// <param name="f1"></param>
		public static void ZC_SYNC_END(Character character, int skillActorId, float f1)
		{
			var packet = new Packet(Op.ZC_SYNC_END);

			packet.PutInt(skillActorId);
			packet.PutFloat(f1);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Unknown Purpose.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="skillActorId"></param>
		/// <param name="f1"></param>
		public static void ZC_SYNC_EXEC_BY_SKILL_TIME(Character character, int skillActorId, float f1)
		{
			var packet = new Packet(Op.ZC_SYNC_EXEC_BY_SKILL_TIME);

			packet.PutInt(character.Handle);
			packet.PutInt(skillActorId);
			packet.PutFloat(f1);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Unknown Purpose.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="skillActorId"></param>
		public static void ZC_SYNC_EXEC(Character character, int skillActorId)
		{
			var packet = new Packet(Op.ZC_SYNC_EXEC);
			packet.PutInt(skillActorId);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Unknown Purpose.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_EQUIP_CARD_INFO(Character character)
		{
			var packet = new Packet(Op.ZC_EQUIP_CARD_INFO);
			packet.PutShort(0); // Count?

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Updates the list of sold items in an NPC shop.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="type"></param>
		/// <param name="items"></param>
		public static void ZC_SOLD_ITEM_DIVISION_LIST(Character character, byte type, List<Item> items)
		{
			var packet = new Packet(Op.ZC_SOLD_ITEM_DIVISION_LIST);

			packet.PutByte(type);
			packet.PutInt(items.Count);
			packet.PutByte(1);
			packet.PutByte(1);
			packet.PutByte(1);

			if (items.Count != 0)
			{
				packet.Zlib(true, zpacket =>
				{
					for (var i = 0; i < items.Count; i++)
					{
						var properties = items[i].Properties.GetAll();
						var propertiesSize = properties.Sum(a => a.Size);

						zpacket.PutInt(items[i].Id);
						zpacket.PutInt(propertiesSize);
						if (items[i].Id != 900011)
							zpacket.PutLong(items[i].ObjectId);
						else
							zpacket.PutLong(0);
						zpacket.PutInt(items[i].Amount);
						zpacket.PutInt(items[i].Price);
						zpacket.PutInt(1);
						zpacket.PutInt(items.Count - i - 1);
						zpacket.AddProperties(properties);
						if (propertiesSize > 0)
						{
							if (items[i].Id != 900011 && items[i].ObjectId > 0)
							{
								zpacket.PutShort(0);
								zpacket.PutLong(items[i].ObjectId);
								zpacket.PutShort(0);
							}
						}
					}
				});
			}
			else
			{
				packet.PutBinFromHex("8DFA020000000300");
			}

			character.Connection.Send(packet);
		}

		/// <summary>
		/// When view another player's character view the submenu
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="character"></param>
		public static void ZC_PROPERTY_COMPARE(ChannelConnection conn, Character character)
		{
			var packet = new Packet(Op.ZC_PROPERTY_COMPARE);

			var properties = character.Properties.GetAll();
			var propertiesSize = properties.Sum(a => a.Size);
			var equip = character.Inventory.GetEquip();

			packet.PutInt(character.Handle);
			packet.PutString(character.Name, 65);
			packet.PutLong(character.Id);
			packet.PutLong(character.AccountId);
			packet.PutEmptyBin(5);
			packet.PutByte(1);
			packet.PutInt(1624);
			packet.PutLong(1624);
			packet.PutString(character.TeamName, 64);

			packet.PutString(character.Name, 64);
			packet.PutShort(0);
			packet.PutShort((short)character.JobId);
			packet.PutInt((int)character.JobId);
			packet.PutInt(11);
			packet.PutShort(1);
			packet.PutLong(11);
			packet.PutLong(0);
			packet.PutEmptyBin(6);
			packet.PutInt(1003);
			packet.PutInt(10); // ?
			packet.PutByte(0x80);
			packet.PutByte(0x80);
			packet.PutByte(0x80);
			packet.PutByte(0xFF);
			packet.PutLong((long)character.JobId);
			packet.PutLong(0);
			packet.PutShort(1490);
			packet.PutShort(215);

			packet.AddAppearancePc(character);
			//packet.AddProperties(properties);
			packet.PutBinFromHex("F39A010000000000FB1B000000000000981B000000001041F49A010000000000041B00000000AF43271C0000000020417E1B000000000000FB9A0100000000008A92010000000000F12C0000000000006F1B000000000000CF1B000000000000F092010000000000751B000000000000059B010000000000DE2C000000000000891B000000000000B91B0000000000004D1B0000000000000A9B010000000000031B0000000000408D1B000000000000FA1B000000000842E32C000000000000F89A0100000000009B1B000000000000DC2C000000000000F21B00000000803F8E92010000000000A398010000000000701B000000002041AD1B000000000000831B0000000000009D1B00000000803FCE8D010000000000D01B00000000803F191C000000007A44CD1B00000000803FFC9B0100000000001F1B00000000803F771B000000000000DD2C00000000000091920100000000009392010000000000E82C000000000000201B0000000000005D1B000000000000E02C000000000000DB1B0000000000009492010000000000141C000000000000051C000000005C43A21B000000000000261B0000EBC99840ED1A00000000F041089B010000000000CE1B0000080043686172325F31008892010000000000DE1A000034B33A437D1B000000000000431B00004AA40A48021C000000000842541B00000000803F8D92010000000000DC1A000000008041E792010000002842DF1A000000000040761B0000000030412F87000000000000121C00000000803F861B000000002842A51B000000000000EA2C000000000000B21B000000000000481B000000000000101C000000000000D08D0100000000009E1B000000000000E42C000000000000E12C000000000000931B00000000B643581B000000007A44991B000000009041DC1B000000000000EE2C0000000000008F92010000000000EF9201000000C842F02C0000000000001A1C0000000000008B1B000000000000F81A00000000C0406C1B00000000000092920100000000007C1B000000004040D31A0000000040403F7F00000600313034343900DF2C000000000000E71A000000008040ED92010000000000A298010000000000AC1B000000000000EB2C000000000000371B000000000842E72C000000000000A81B000000000000721B000000000000971B000000000000BB1B000000000000F01B000000007842E6920100000000003387000000000000B61B000000000000291B000000000000871B000000000000F192010000000000F41A00000050C346B01B000000000000921B000000000000A0980100000000001F8D0100000000009092010000000000D41A000000002041311C00000000803FE62C000000000000E92C000000000000B81B000000000000FD9B010000000000E01B000000000000E51B000000000000B11B0000000000009692010000000000FA1A000000008041049B010000000000A31B000000002041E52C0000000000008C920100000000009A1B0000004072446D1B00000000803F1E8D010000000000951B000000008042A198010000000000C51B00000000FA431B1B000000000842711B000000000000F51B000000007842E22C000000000000781B000000000000F51A00000000FA45EC2C000000000000A71B0000000000007B1B000000000000201C000000000000F91A000000409C46E499010000000000FA9A010000000000821B0000000000008B920100000000009F98010000000000AB1B000000002041CC8D010000000000F59A010000000000A61B000000007041D61B00000000FA43ED2C0000000000000F1C0000000030419C98010000000000A91B000000000000FD9A0100000000003087000000000000E98F010000008442251C000000401C45811B000000004041EF2C000000000000FC1B00000000000032870000000000009C1B00000000803FB51B000000000041531B000000000000959201000000000089920100000000008792010000000000A41B000000000000F81B000000000243231C000000000000069B0100000000000D2000000000803FE30F000000409D46A392010005003230303100052000000000803F459701000A00736B696E746F6E653200480F000046329A4B092000000000803F112000000000803F6F0F000000007B44262700000700526567656E7400F69201000000803F21A801000000803F6B9601000000803FA50F000000C07D44FF9201000000803F570F00004900635F4B6C616970652F2D39352E3737343430363433333130352F3134392E32303334363036393333362F3137352E35373734393933383936352F6974656D6275666672657061697200");

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
				else if ((equipItem.Value.Id >= 2 && equipItem.Value.Id <= 10) || equipItem.Value.Id == 10000 || equipItem.Value.Id == 11000 || equipItem.Value.Id == 12101 || equipItem.Value.Id == 9999996)
				{

				}
				else
				{
					equipItem.Value.Properties.Add(new FloatProperty(PropertyId.Item.CoolDown, 0f));
				}

				properties = equipItem.Value.Properties.GetAll();
				propertiesSize = equipItem.Value.Properties.Size;

				packet.PutInt(equipItem.Value.Id);
				packet.PutInt(propertiesSize);
				if ((equipItem.Value.Id >= 2 && equipItem.Value.Id <= 10) || equipItem.Value.Id == 10000 || equipItem.Value.Id == 11000 || equipItem.Value.Id == 12101 || equipItem.Value.Id == 9999996)
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

			conn.Send(packet);
		}

		/// <summary>
		/// Updates monster appearance on clients in range of the monster.
		/// </summary>
		/// <param name="monster"></param>
		public static void ZC_UPDATED_MONSTERAPPEARANCE(Monster monster)
		{
			// 5 strings, 5 short length prefixes, 5 null terminators
			// There must be a better way to get the length. Also,
			// we aren't doing this in AddMonster... does the client
			// even use it?
			var namesLength = 5 * sizeof(short) + 5;
			namesLength += monster.Name.Length;
			//namesLength += monster.UniqueName.Length;
			namesLength += monster.DialogName.Length;
			namesLength += monster.WarpName.Length;
			//namesLength += monster.Str3Name.Length;

			var packet = new Packet(Op.ZC_UPDATED_MONSTERAPPEARANCE);
			packet.PutInt(monster.Handle);
			packet.AddMonsterBase(monster);

			packet.PutInt(namesLength);
			packet.PutLpString(monster.Name);
			packet.PutLpString(""); // uniqueName
			packet.PutLpString(monster.DialogName);
			packet.PutLpString(monster.WarpName);
			packet.PutLpString(""); // str3

			monster.Map.Broadcast(packet, monster);
		}

		/// <summary>
		/// Display a buff on client UI
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="buff"></param>
		public static void ZC_BUFF_ADD(IEntity entity, Buff buff)
		{
			var packet = new Packet(Op.ZC_BUFF_ADD);
			packet.AddTargetedBuff(buff);

			entity.Map.Broadcast(packet);
		}

		/// <summary>
		/// Update a buff after a buff has been added
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="buff"></param>
		public static void ZC_BUFF_UPDATE(IEntity entity, Buff buff)
		{
			var packet = new Packet(Op.ZC_BUFF_UPDATE);
			packet.AddTargetedBuff(buff);

			entity.Map.Broadcast(packet);
		}

		/// <summary>
		/// Remove buff from client UI
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="buff"></param>
		public static void ZC_BUFF_REMOVE(IEntity entity, Buff buff)
		{
			var packet = new Packet(Op.ZC_BUFF_REMOVE);

			packet.PutInt(entity.Handle);
			packet.PutInt((int)buff.Id);
			packet.PutByte(0);
			packet.PutInt(buff.Handle);
			packet.PutByte(0);

			entity.Map.Broadcast(packet);
		}

		/// <summary>
		/// Buff list, sent when a entity spawns?
		/// </summary>
		/// <param name="entity"></param>
		public static void ZC_BUFF_LIST(IEntity entity)
		{
			var buffs = entity.Components.Get<BuffCollection>();
			var buffCount = buffs?.Count ?? 0;

			var packet = new Packet(Op.ZC_BUFF_LIST);

			packet.PutInt(entity.Handle);
			packet.PutByte((byte)buffCount);
			if (buffCount > 0)
			{
				foreach (var buff in buffs.GetList())
					packet.AddBuff(buff);
			}

			entity.Map.Broadcast(packet);
		}

		/// <summary>
		/// Clear buff buff handle association? Sent on entity death and
		/// removal.
		/// </summary>
		/// <param name="entity"></param>
		public static void ZC_BUFF_CLEAR(IEntity entity)
		{
			var packet = new Packet(Op.ZC_BUFF_CLEAR);

			packet.PutInt(entity.Handle);
			packet.PutByte(1);

			entity.Map.Broadcast(packet);
		}

		/// <summary>
		/// ?
		/// </summary>
		/// <param name="character"></param>
		/// <param name="hookId"></param>
		public static void ZC_ENTER_HOOK(Character character, int hookId)
		{
			var packet = new Packet(Op.ZC_ENTER_HOOK);
			packet.PutInt(hookId);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Updates buff's time?
		/// </summary>
		/// <remarks>
		/// Used in long duration buffs that might require
		/// a resync with the server?
		/// </remarks>
		/// <param name="character"></param>
		/// <param name="buff"></param>
		public static void ZC_BUFF_UPDATE_TIME(IEntity entity, Buff buff)
		{
			var packet = new Packet(Op.ZC_BUFF_UPDATE_TIME);

			packet.PutLong(0);
			packet.PutInt(0);
			packet.PutInt(entity.Handle);
			packet.PutInt((int)buff.Id);
			packet.PutInt(0); // Increasing Value?

			entity.Map.Broadcast(packet);
		}

		/// <summary>
		/// Plays item pick up animation for the character and item monster.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="itemMonster"></param>
		public static void ZC_ITEM_GET(IEntity character, IEntity itemMonster)
		{
			var packet = new Packet(Op.ZC_ITEM_GET);

			packet.PutInt(character.Handle);
			packet.PutInt(itemMonster.Handle);
			packet.PutInt(1);

			character.Map.Broadcast(packet);
		}

		/// <summary>
		/// Makes entity move between the given positions.
		/// </summary>
		/// <remarks>
		/// The positions must use the cell for Y, instead of the height,
		/// otherwise the client is not able to handle the packet.
		/// </remarks>
		/// <param name="entity"></param>
		/// <param name="fromCellPos"></param>
		/// <param name="toCellPos"></param>
		/// <param name="speed"></param>
		public static void ZC_MOVE_PATH(IEntity entity, Position fromCellPos, Position toCellPos, float speed)
		{
			var packet = new Packet(Op.ZC_MOVE_PATH);

			packet.PutInt(entity.Handle);
			packet.PutInt((int)fromCellPos.X);
			packet.PutInt((int)fromCellPos.Z);
			packet.PutInt((int)fromCellPos.Y);
			packet.PutInt((int)toCellPos.X);
			packet.PutInt((int)toCellPos.Z);
			packet.PutInt((int)toCellPos.Y);
			packet.PutFloat(speed);
			packet.PutFloat(0);

			entity.Map.Broadcast(packet);
		}

		/// <summary>
		/// Removes the skill for the character.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="skillId"></param>
		public static void ZC_SKILL_REMOVE(Character character, SkillId skillId)
		{
			var packet = new Packet(Op.ZC_SKILL_REMOVE);
			packet.PutInt(character.Handle);
			packet.PutInt((int)skillId);

			character.Connection.Send(packet);
		}

		public static void DUMMY(ChannelConnection conn)
		{
		}
	}
}
