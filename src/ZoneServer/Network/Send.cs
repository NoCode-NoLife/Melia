using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Melia.Shared.Data.Database;
using Melia.Shared.Game;
using Melia.Shared.Game.Const;
using Melia.Shared.Game.Properties;
using Melia.Shared.Network;
using Melia.Shared.Network.Helpers;
using Melia.Shared.ObjectProperties;
using Melia.Shared.World;
using Melia.Zone.Buffs;
using Melia.Zone.Events;
using Melia.Zone.Network.Helpers;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Characters.Components;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Items;
using Melia.Zone.World.Maps;
using Yggdrasil.Extensions;
using Yggdrasil.Util;

namespace Melia.Zone.Network
{
	public static partial class Send
	{
		/// <summary>
		/// Sends ZC_CONNECT_OK to connection, verifying the connection and
		/// giving information about the character.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="character"></param>
		public static void ZC_CONNECT_OK(IZoneConnection conn, Character character)
		{
			var packet = new Packet(Op.ZC_CONNECT_OK);

			packet.PutByte(0); // gameMode 0 = NormalMode, 1 = SingleMode
			packet.PutInt(1281523659); // was 1281523659 now 1277746433
			packet.PutByte((byte)character.PermissionLevel);
			packet.PutEmptyBin(10);
			packet.PutInt(0);
			packet.PutShort(0);
			packet.PutInt(40588976); // 44266500
			packet.PutEmptyBin(10);

			// These bytes set the integrated and integrated dungeon server
			// settings.
			packet.PutByte(0);
			packet.PutByte(0);

			// [i348202, 2021-12-15]
			// Where exactly this bytes goes is currently unknown
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
		public static void ZC_START_GAME(IZoneConnection conn)
		{
			var packet = new Packet(Op.ZC_START_GAME);

			packet.PutFloat(1); // Affects the speed of everything happening in the client o.o
			packet.PutFloat(1); // serverAppTimeOffset
			packet.PutFloat(1); // globalAppTimeOffset
			packet.PutLong(DateTime.Now.ToFileTimeUtc());
			packet.PutByte(0); // [i344887, 2021-11-09]

			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_START_INFO to connection.
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_START_INFO(IZoneConnection conn)
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
		public static void ZC_ENTER_PC(IZoneConnection conn, Character character)
		{
			var packet = new Packet(Op.ZC_ENTER_PC);

			packet.PutInt(character.Handle);
			packet.PutFloat(character.Position.X);
			packet.PutFloat(character.Position.Y);
			packet.PutFloat(character.Position.Z);
			packet.PutFloat(character.Direction.Cos);
			packet.PutFloat(character.Direction.Sin);
			packet.PutShort(0);
			packet.PutLong(character.SocialUserId);
			packet.PutByte(0); // Pose
			packet.PutFloat(character.Properties.GetFloat(PropertyName.MSPD));
			packet.PutFloat(character.Properties.GetFloat(PropertyName.MovingShot));
			packet.PutInt(character.Hp);
			packet.PutInt(character.MaxHp);
			packet.PutShort(character.Sp);
			packet.PutShort(character.MaxSp);
			packet.PutInt(0); // [i11025 (2016-02-26)]
			packet.PutInt(0); // [i373230 (2023-05-10)]
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

			// [i381490 (2023-12-XX)]
			// The new byte should be either this or the previous one.
			packet.PutByte(0);

			conn.Send(packet);
		}

		/// <summary>
		/// Adds a session object and its properties.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="sessionObject"></param>
		public static void ZC_SESSION_OBJ_ADD(IZoneConnection conn, SessionObject sessionObject)
		{
			var propertyList = sessionObject.Properties.GetAll();
			var propertiesSize = propertyList.GetByteCount();

			var packet = new Packet(Op.ZC_SESSION_OBJ_ADD);
			packet.PutInt(sessionObject.Id);
			packet.PutInt(propertiesSize);
			packet.PutLong(sessionObject.ObjectId);
			packet.PutInt(0);
			packet.AddProperties(propertyList);
			packet.PutInt(sessionObject.Id);

			conn.Send(packet);
		}

		/// <summary>
		/// Resets ancient card?
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_ANCIENT_CARD_RESET(IZoneConnection conn)
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
		public static void ZC_ENTER_MONSTER(IMonster monster)
		{
			var packet = new Packet(Op.ZC_ENTER_MONSTER);
			packet.AddMonster(monster);

			monster.Map.Broadcast(packet, monster);
		}

		/// <summary>
		/// Exact purpose unknown, but it stops the animation of Multishot.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_SKILL_DISABLE(Character character)
		{
			var packet = new Packet(Op.ZC_SKILL_DISABLE);

			packet.PutInt(character.Handle);
			packet.PutByte(0);
			packet.PutInt(0); // very random number?

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sends ZC_ENTER_MONSTER to connection, making it appear.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="monster"></param>
		public static void ZC_ENTER_MONSTER(IZoneConnection conn, IMonster monster)
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
			var serialized = character.Variables.Perm.Get<string>("Melia.QuickSlotList", null);
			if (string.IsNullOrWhiteSpace(serialized))
				return;

			var packet = new Packet(Op.ZC_QUICK_SLOT_LIST);

			var compressedData = packet.CompressData(p =>
			{
				var quickSlotsStr = serialized.Split(new[] { '#' }, StringSplitOptions.RemoveEmptyEntries);

				p.PutByte(0);

				for (var i = 0; i < 50; ++i)
				{
					var split = quickSlotsStr[i].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

					var type = Enum.Parse(typeof(QuickSlotType), split[0]);
					var id = int.Parse(split[1]);
					var objectId = long.Parse(split[2]);

					p.PutByte((byte)type);
					p.PutInt(id);
					p.PutLong(objectId);
				}

				for (var i = 0; i < 4; ++i)
				{
					var split = quickSlotsStr[i].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

					var type = Enum.Parse(typeof(QuickSlotType), split[0]);
					var id = int.Parse(split[1]);
					var objectId = long.Parse(split[2]);

					p.PutByte((byte)type);
					p.PutInt(id);
					p.PutLong(objectId);
				}

				p.PutByte(0);
				p.PutByte(0);
			});

			packet.PutInt(compressedData.Length);
			packet.PutByte(0);
			packet.PutBin(compressedData);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sends ZC_SKILL_LIST to character, containing a list
		/// of all the character's skills.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_SKILL_LIST(Character character)
		{
			// [Note]
			// If you ever find yourself wondering why the client isn't
			// displaying any skills, make sure the NormalOp for the skill
			// UI update is correct (ZC_NORMAL_UpdateSkillUI).
			// Without that packet, the client won't display any skills
			// because it contains some job information that are used
			// to determin which skills to display.

			var skills = character.Skills.GetList();

			var packet = new Packet(Op.ZC_SKILL_LIST);
			packet.PutInt(character.Handle);
			packet.PutShort(skills.Length);
			packet.PutByte(0);

			packet.Zlib(true, zpacket =>
			{
				foreach (var skill in skills)
					zpacket.AddSkill(skill);
			});

			// This follows at the end of the packet after the skills,
			// but it's not clear what this is for. It honestly seems
			// like garbage data, with left over floats and properties,
			// but it's a bit long for that. A couple dozens updates
			// ago there were also only two bytes before the properties,
			// but one garbage byte at the end of the packet to pad it.
			// We'll just mimic the official packets for now.
			//
			// Alternative theory: It could also be a string that wasn't
			// zeroed, and maybe a few bytes or something.
			packet.PutByte(0x00);
			packet.PutByte(0x80);
			packet.PutByte(0x3F);
			packet.PutInt(PropertyTable.GetId("Skill", "SkillFactor"));
			packet.PutFloat(1);
			packet.PutInt(PropertyTable.GetId("Skill", "CaptionTime"));
			packet.PutFloat(0);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Adds skill for character, by sending ZC_SKILL_ADD to its connection.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="skill"></param>
		public static void ZC_SKILL_ADD(Character character, Skill skill)
		{
			// Passive skills aren't added to the quickbar
			var addToQuickbar = skill.Data.ActivationType == SkillActivationType.ActiveSkill;

			var packet = new Packet(Op.ZC_SKILL_ADD);

			packet.PutLong(character.ObjectId);
			packet.PutByte(addToQuickbar);
			packet.PutByte(0); // SKILL_LIST_GET ?
			packet.PutLong(0); // ?
			packet.AddSkill(skill);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Cancels a skill cast, usually sent when a monster has died.
		/// </summary>
		/// <param name="entity"></param>
		public static void ZC_SKILL_CAST_CANCEL(ICombatEntity entity)
		{
			var packet = new Packet(Op.ZC_SKILL_CAST_CANCEL);
			packet.PutInt(entity.Handle);

			entity.Map.Broadcast(packet, entity);
		}

		/// <summary>
		/// Shows skill use for character, by sending ZC_SKILL_FORCE_TARGET to its connection.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="hits"></param>
		public static void ZC_SKILL_FORCE_TARGET(ICombatEntity entity, ICombatEntity target, Skill skill, params SkillHitInfo[] hits)
			=> ZC_SKILL_FORCE_TARGET(entity, target, skill, (IEnumerable<SkillHitInfo>)hits);

		/// <summary>
		/// Shows skill use for character, by sending ZC_SKILL_FORCE_TARGET to its connection.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="hits"></param>
		public static void ZC_SKILL_FORCE_TARGET(ICombatEntity entity, ICombatEntity target, Skill skill, IEnumerable<SkillHitInfo> hits)
			=> ZC_SKILL_FORCE_TARGET(entity, target, skill, hits?.FirstOrDefault()?.ForceId ?? 0, hits);

		/// <summary>
		/// Shows skill use for character, by sending ZC_SKILL_FORCE_TARGET to its connection.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="forceId"></param>
		/// <param name="hits"></param>
		public static void ZC_SKILL_FORCE_TARGET(ICombatEntity entity, ICombatEntity target, Skill skill, int forceId, IEnumerable<SkillHitInfo> hits)
		{
			var shootTime = skill.Properties.GetFloat(PropertyName.ShootTime);
			var sklSpdRate = skill.Properties.GetFloat(PropertyName.SklSpdRate);

			var packet = new Packet(Op.ZC_SKILL_FORCE_TARGET);

			packet.PutInt((int)skill.Id);
			packet.PutInt(entity.Handle);
			packet.PutFloat(entity.Direction.Cos);
			packet.PutFloat(entity.Direction.Sin);
			packet.PutInt(1);
			packet.PutFloat(shootTime);
			packet.PutFloat(1);
			packet.PutInt(0);
			packet.PutInt(forceId);
			packet.PutFloat(sklSpdRate);

			packet.PutInt(0);
			packet.PutInt(target?.Handle ?? 0);
			packet.PutInt(0);
			packet.PutFloat(512f);
			packet.PutInt(0);

			packet.PutByte((byte)(hits?.Count() ?? 0));
			if (hits != null)
			{
				foreach (var hit in hits)
					packet.AddSkillHitInfo(hit);
			}

			entity.Map.Broadcast(packet, entity);
		}

		/// <summary>
		/// Shows entity using the skill.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="skill"></param>
		/// <param name="targetPos"></param>
		/// <param name="hits"></param>
		public static void ZC_SKILL_MELEE_GROUND(ICombatEntity entity, Skill skill, Position targetPos, IEnumerable<SkillHitInfo> hits)
			=> ZC_SKILL_MELEE_GROUND(entity, skill, targetPos, hits?.FirstOrDefault()?.ForceId ?? 0, hits);

		/// <summary>
		/// Shows entity using the skill.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="skill"></param>
		/// <param name="targetPos"></param>
		/// <param name="forceId"></param>
		/// <param name="hits"></param>
		public static void ZC_SKILL_MELEE_GROUND(ICombatEntity entity, Skill skill, Position targetPos, int forceId, IEnumerable<SkillHitInfo> hits)
		{
			var shootTime = skill.Properties.GetFloat(PropertyName.ShootTime);
			var sklSpdRate = skill.Properties.GetFloat(PropertyName.SklSpdRate);

			var skillId = skill.Id;

			// Mobs don't have animations for player skills. We can use a
			// workaround to instead show their normal attack animation in
			// this case. We might want to extend this in the future to do
			// the same for characters if they use a skill they shouldn't
			// be able to use.
			if (!skill.IsMonsterSkill && entity is Mob mob)
				skillId = mob.Data.Skills.First().SkillId;

			var packet = new Packet(Op.ZC_SKILL_MELEE_GROUND);

			packet.PutInt((int)skillId);
			packet.PutInt(entity.Handle);
			packet.PutFloat(entity.Direction.Cos);
			packet.PutFloat(entity.Direction.Sin);
			packet.PutInt(1);
			packet.PutFloat(shootTime);
			packet.PutFloat(1);
			packet.PutInt(0);
			packet.PutInt(forceId);
			packet.PutFloat(sklSpdRate);

			// This does _not_ look like a handle to me... And sending a
			// single target handle for an AoE skill packet doesn't make
			// sense either. Let's send 0 for now.
			//if (targets != null && targetCount == 1)
			//	packet.PutInt(targets.First().Handle);
			//else
			packet.PutInt(0);

			packet.PutPosition(targetPos);

			packet.PutShort((short)(hits?.Count() ?? 0));
			if (hits != null)
			{
				foreach (var hit in hits)
					packet.AddSkillHitInfo(hit);
			}

			entity.Map.Broadcast(packet, entity);
		}

		/// <summary>
		/// Shows entity using the skill on the target.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="skill"></param>
		/// <param name="target"></param>
		/// <param name="hits"></param>
		public static void ZC_SKILL_MELEE_TARGET(ICombatEntity entity, Skill skill, ICombatEntity target, IEnumerable<SkillHitInfo> hits)
		{
			var shootTime = skill.Properties.GetFloat(PropertyName.ShootTime);
			var sklSpdRate = skill.Properties.GetFloat(PropertyName.SklSpdRate);
			var forceId = hits?.FirstOrDefault()?.ForceId ?? 0;

			var packet = new Packet(Op.ZC_SKILL_MELEE_TARGET);

			packet.PutInt((int)skill.Id);
			packet.PutInt(entity.Handle);
			packet.PutFloat(entity.Direction.Cos);
			packet.PutFloat(entity.Direction.Sin);
			packet.PutInt(1);
			packet.PutFloat(shootTime);
			packet.PutFloat(1);
			packet.PutInt(0);
			packet.PutInt(forceId);
			packet.PutFloat(sklSpdRate);

			// This does _not_ look like a handle to me... And sending a
			// single target handle for an AoE skill packet doesn't make
			// sense either. Let's send 0 for now.
			//if (targets != null && targetCount == 1)
			//	packet.PutInt(targets.First().Handle);
			//else
			packet.PutInt(0);

			packet.PutInt(target.Handle);

			packet.PutByte((byte)(hits?.Count() ?? 0));
			if (hits != null)
			{
				foreach (var hit in hits)
					packet.AddSkillHitInfo(hit);
			}

			entity.Map.Broadcast(packet, entity);
		}

		/// <summary>
		/// Updates the skill's overheat counter.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="skill"></param>
		public static void ZC_OVERHEAT_CHANGED(Character character, Skill skill)
		{
			var resetTime = skill.OverheatData.OverheatResetTime.TotalMilliseconds;

			// The "overheat time" needs to be "one resetTime" more than
			// one would expect to display the correct amount of overheat
			// on the client.
			// For example, if the skill has a reset time of 10,000, and
			// has one overheat count, the client needs 20,000 to display
			// one bubble on the skill icon.
			var overheatCount = skill.OverheatCounter == 0 ? 0 : skill.OverheatCounter + 1;
			var overheatTime = overheatCount * resetTime;

			var packet = new Packet(Op.ZC_OVERHEAT_CHANGED);

			packet.PutLong(character.ObjectId);
			packet.PutInt((int)skill.Data.OverheatGroup);
			packet.PutInt((int)overheatTime);
			packet.PutInt(0);
			packet.PutInt((int)resetTime);
			packet.PutInt(4352);
			packet.PutLong(0);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Updates a cooldown on the character's client.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="cooldown"></param>
		public static void ZC_COOLDOWN_CHANGED(Character character, Cooldown cooldown)
		{
			var packet = new Packet(Op.ZC_COOLDOWN_CHANGED);

			packet.PutLong(character.ObjectId);
			packet.PutInt((int)cooldown.Id);
			packet.PutInt((int)cooldown.Remaining.TotalMilliseconds);
			packet.PutInt((int)cooldown.Duration.TotalMilliseconds);
			packet.PutByte(0);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Reduces a cooldown on the character's client.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="cooldown"></param>
		/// <param name="reductionInMilliseconds"></param>
		public static void ZC_COOLDOWN_CHANGED(Character character, Cooldown cooldown, double reductionInMilliseconds)
		{
			var packet = new Packet(Op.ZC_COOLDOWN_CHANGED);

			packet.PutLong(character.ObjectId);
			packet.PutInt((int)cooldown.Id);
			packet.PutInt((int)cooldown.Remaining.TotalMilliseconds);
			packet.PutInt(0);
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
		public static void ZC_OPTION_LIST(IZoneConnection conn)
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

			packet.PutInt(macros.Length);
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
		public static void ZC_SET_NPC_STATE(Npc npc)
		{
			var packet = new Packet(Op.ZC_SET_NPC_STATE);

			packet.PutInt(npc.Map.Id);
			packet.PutInt(npc.GenType);
			packet.PutShort((short)npc.State);
			packet.PutEmptyBin(2);

			npc.Map.Broadcast(packet, npc, false);
		}

		/// <summary>
		/// Sends a list of cooldowns to the client to update them.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="cooldowns"></param>
		public static void ZC_COOLDOWN_LIST(Character character, IEnumerable<Cooldown> cooldowns)
		{
			var packet = new Packet(Op.ZC_COOLDOWN_LIST);

			packet.PutLong(character.ObjectId);
			packet.PutInt(cooldowns?.Count() ?? 0);

			if (cooldowns != null)
			{
				foreach (var cooldown in cooldowns)
				{
					packet.PutInt((int)cooldown.Id);
					packet.PutInt((int)cooldown.Remaining.TotalMilliseconds);
					packet.PutInt((int)cooldown.Duration.TotalMilliseconds);
				}
			}

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

			packet.PutLong(character.ObjectId);
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
				//var propertyList = ability.Properties.GetAll();
				//var propertiesSize = propertyList.GetByteCount();

				packet.PutLong(ability.ObjectId);
				packet.PutInt((int)ability.Id);
				packet.PutShort(0); // propertiesSize
				packet.PutShort(0);

				// The ability properties are weird. Not only do they
				// seem to use a count instead of a size now and include
				// some byte, but they also don't appear unless one of
				// them has a non-default value? Without properties the
				// ability is displayed as level 1.

				//if (propertiesSize > 0)
				//	packet.AddProperties(propertyList);

				var sendProperties = ability.Level > 1 || !ability.Active;

				if (!sendProperties)
				{
					packet.PutInt(0);
				}
				else
				{
					var propertyList = ability.Properties.GetAll();

					packet.PutInt(propertyList.Count);
					foreach (var property in propertyList)
					{
						var propertyId = PropertyTable.GetId("Ability", property.Ident);

						packet.PutInt(propertyId);
						packet.PutByte(0);

						switch (property)
						{
							case FloatProperty floatProperty:
								packet.PutFloat(floatProperty.Value);
								break;

							case StringProperty stringProperty:
								packet.PutLpString(stringProperty.Value);
								break;

							default:
								throw new ArgumentException($"Unknown property type: {property.GetType().Name}");
						}
					}
				}
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
			packet.PutFloat(character.Properties.GetFloat(PropertyName.MSPD));
			packet.PutFloat(character.Properties.GetFloat(PropertyName.MovingShot));

			// [i11257 (2016-03-25)]
			{
				packet.PutByte(0);
			}
			packet.PutLong(character.ObjectId);

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
			packet.PutFloat(character.Properties.GetFloat(PropertyName.CastingSpeed));
			packet.PutLong(character.ObjectId);

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
					var propertyList = item.Value.Properties.GetAll();
					var propertiesSize = propertyList.GetByteCount();

					zpacket.PutInt(item.Value.Id);
					zpacket.PutShort(propertiesSize);
					zpacket.PutEmptyBin(2);
					zpacket.PutLong(item.Value.ObjectId);
					zpacket.PutInt(item.Value.Amount);
					zpacket.PutInt(item.Value.Price);
					zpacket.PutInt(item.Key);
					zpacket.PutInt(1);
					zpacket.AddProperties(propertyList);
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
					var propertyList = item.Value.Properties.GetAll();
					var propertiesSize = propertyList.GetByteCount();

					zpacket.PutInt(item.Value.Id);
					zpacket.PutShort(propertiesSize);
					zpacket.PutEmptyBin(2);
					zpacket.PutLong(item.Value.ObjectId);
					zpacket.PutInt(item.Value.Amount);
					zpacket.PutInt(item.Value.Price);
					zpacket.PutInt(0);
					zpacket.PutInt(item.Key);
					zpacket.AddProperties(propertyList);

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
			// Initially this packet simply contained all equipment,
			// but they changed this at some point and split it up
			// over several instances.

			var equip = character.Inventory.GetEquip();
			var packetCount = Math.Ceiling(equip.Count / 5f);

			//if (equip.Count != InventoryDefaults.EquipSlotCount)
			//	throw new InvalidOperationException("Incorrect amount of equipment (" + equip.Count + ").");

			for (var i = 0; i < packetCount; ++i)
			{
				var first = (i == 0);
				var minIndex = i * 5;
				var maxIndex = (i + 1) * 5;

				// Seems like the byte is always 1 on the first packet and
				// 0 on subsequent ones. Not quite sure what's up with the
				// rest. Kinda looks like paging, though that shouldn't
				// be necessary for this at all... w/e.

				var packet = new Packet(Op.ZC_ITEM_EQUIP_LIST);

				packet.PutByte(first);
				packet.PutInt(minIndex);
				packet.PutInt(maxIndex);

				for (var j = minIndex; j < maxIndex && j < InventoryDefaults.EquipSlotCount; ++j)
				{
					var equipSlot = (EquipSlot)j;
					var equipItem = equip[equipSlot];

					var propertyList = equipItem.Properties.GetAll();
					var propertiesSize = propertyList.GetByteCount();

					packet.PutInt(equipItem.Id);
					packet.PutShort(propertiesSize);
					packet.PutEmptyBin(2);
					packet.PutLong(equipItem.ObjectId);
					packet.PutByte((byte)equipSlot);
					packet.PutEmptyBin(3);
					packet.PutInt(0);
					packet.PutShort(0);
					packet.AddProperties(propertyList);

					if (equipItem.ObjectId != 0)
					{
						packet.PutShort(0);
						packet.PutLong(equipItem.ObjectId);
						packet.PutShort(0);
					}
				}

				character.Connection.Send(packet);
			}
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
		/// Broadcasts ZC_CHAT in range of actor.
		/// </summary>
		/// <param name="actor"></param>
		/// <param name="format"></param>
		/// <param name="args"></param>
		public static void ZC_CHAT(IActor actor, string format, params object[] args)
		{
			if (args.Length > 0)
				format = string.Format(format, args);

			var teamName = "";
			var name = actor.Name;
			var jobId = JobId.Swordsman;
			var gender = Gender.Male;
			var hair = 0;

			if (actor is Character character)
			{
				teamName = character.TeamName;
				jobId = character.JobId;
				gender = character.Gender;
				hair = character.Hair;
			}

			var packet = new Packet(Op.ZC_CHAT);

			packet.PutInt(actor.Handle);
			packet.PutString(teamName, 64);
			packet.PutString(actor.Name, 65);
			packet.PutByte(0); // -11, -60, -1, -19, 1
			packet.PutShort((short)jobId);
			packet.PutInt((int)jobId); // 1, 10, 11
			packet.PutByte((byte)gender);
			packet.PutByte((byte)hair);
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
			packet.PutString("GLOBAL", 64); // [i373230]
			packet.PutString(format);

			actor.Map.Broadcast(packet, actor);
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
			packet.PutInt(0);  // added i354444
			packet.PutByte(0); // added i373230
			packet.PutByte(1); // added i373230

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
			packet.PutFloat(character.Properties.GetFloat(PropertyName.JumpPower));
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
		public static void ZC_ITEM_ADD(Character character, Item item, int index, int amount, InventoryAddType addType, InventoryType invType)
		{
			// For some reason this packet requires properties on the item,
			// otherwise the client crashes. Let's catch this here for the
			// moment, as it seems to be an issue exclusive to this packet,
			// and maybe we'll figure out why exactly it happens.
			var propertyList = item.Properties.GetAll();
			if (propertyList.Count == 0)
				propertyList.Add(new FloatProperty(PropertyName.CoolDown, 0));

			var propertiesSize = propertyList.GetByteCount();
			var notificationDelay = TimeSpan.Zero;

			var packet = new Packet(Op.ZC_ITEM_ADD);

			packet.PutLong(item.ObjectId);
			packet.PutInt(amount);
			packet.PutInt(0);
			packet.PutInt(index);
			packet.PutInt(item.Id);
			packet.PutShort(propertiesSize);
			packet.PutByte((byte)addType);
			packet.PutFloat((float)notificationDelay.TotalSeconds);
			packet.PutByte((byte)invType);
			packet.PutByte(false);
			packet.PutByte(false);
			packet.AddProperties(propertyList);

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
		public static void ZC_MOVE_BARRACK(IZoneConnection conn)
		{
			var packet = new Packet(Op.ZC_MOVE_BARRACK);
			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_LOGOUT_OK to connection, informing client that it's
		/// save to disconnect?
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_LOGOUT_OK(IZoneConnection conn)
		{
			var packet = new Packet(Op.ZC_LOGOUT_OK);
			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_CAMPINFO to connection.
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_CAMPINFO(IZoneConnection conn)
		{
			var packet = new Packet(Op.ZC_CAMPINFO); // Size: 18 (12)
			packet.PutEmptyBin(12);
			conn.Send(packet);
		}

		/// <summary>
		/// Broadcasts ZC_SET_POS in range of actor, updating its position.
		/// </summary>
		/// <param name="actor"></param>
		public static void ZC_SET_POS(IActor actor)
			=> ZC_SET_POS(actor, actor.Position);

		/// <summary>
		/// Broadcasts ZC_SET_POS in range of actor, updating its position.
		/// </summary>
		/// <param name="actor"></param>
		public static void ZC_SET_POS(IActor actor, Position pos)
		{
			var packet = new Packet(Op.ZC_SET_POS);

			packet.PutInt(actor.Handle);
			packet.PutPosition(pos);
			packet.PutByte(0);

			actor.Map.Broadcast(packet, actor);
		}

		/// <summary>
		/// Sends ZC_MOVE_ZONE_OK to connection, telling the client where to
		/// connect to, and which map to load.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="channelId"></param>
		/// <param name="ip"></param>
		/// <param name="port"></param>
		/// <param name="mapId"></param>
		public static void ZC_MOVE_ZONE_OK(Character character, int channelId, string ip, int port, int mapId)
		{
			var packet = new Packet(Op.ZC_MOVE_ZONE_OK);

			packet.PutInt(210004);
			packet.PutInt(IPAddress.Parse(ip).ToInt32());
			packet.PutInt(port);
			packet.PutInt(mapId);
			packet.PutFloat(38);       // Camera X
			packet.PutFloat(45);       // Camera Y
			packet.PutFloat(200);      // Zoom Min
			packet.PutFloat(2200);     // Zoom Max
			packet.PutFloat(1000);     // Zoom Start
			packet.PutInt(26);         // Position?
			packet.PutInt(20);         // Position?
			packet.PutInt(59);         // Position?
			packet.PutShort(0);        // Direction?
			packet.PutByte((byte)channelId);
			packet.PutLong(character.ObjectId);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Instructs client to prepare for moving to a different map,
		/// and potentially a different zone server.
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_MOVE_ZONE(IZoneConnection conn)
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
		/// <param name="arg1"></param>
		/// <param name="arg2"></param>
		/// <param name="strArg1"></param>
		public static void ZC_PC(Character character, PcUpdateType updateType, int arg1, int arg2, string strArg1 = null)
		{
			var packet = new Packet(Op.ZC_PC);

			packet.PutInt((int)character.Handle);
			packet.PutInt((int)updateType);
			packet.PutInt(arg1);
			packet.PutInt(arg2);

			if (strArg1 != null)
				packet.PutLpString(strArg1);

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Updates all of character's  properties.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_OBJECT_PROPERTY(Character character)
		{
			ZC_OBJECT_PROPERTY(character.Connection, character);
		}

		/// <summary>
		/// Updates character's given properties.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="propertyNames"></param>
		public static void ZC_OBJECT_PROPERTY(Character character, params string[] propertyNames)
		{
			ZC_OBJECT_PROPERTY(character.Connection, character, propertyNames);
		}

		/// <summary>
		/// Updates object's given properties.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="obj"></param>
		public static void ZC_OBJECT_PROPERTY(IZoneConnection conn, IPropertyObject obj)
			=> ZC_OBJECT_PROPERTY(conn, obj.ObjectId, obj.Properties.GetAll());

		/// <summary>
		/// Updates object's given properties.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="obj"></param>
		/// <param name="properties"></param>
		public static void ZC_OBJECT_PROPERTY(IZoneConnection conn, IPropertyObject obj, Properties properties)
			=> ZC_OBJECT_PROPERTY(conn, obj.ObjectId, properties.GetAll());

		/// <summary>
		/// Updates object's given properties.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="obj"></param>
		/// <param name="propertyNames"></param>
		public static void ZC_OBJECT_PROPERTY(IZoneConnection conn, IPropertyObject obj, params string[] propertyNames)
			=> ZC_OBJECT_PROPERTY(conn, obj.ObjectId, obj.Properties.GetSelect(propertyNames));

		/// <summary>
		/// Updates object's given properties.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="objectId"></param>
		/// <param name="propertyList"></param>
		public static void ZC_OBJECT_PROPERTY(IZoneConnection conn, long objectId, PropertyList propertyList)
		{
			var packet = new Packet(Op.ZC_OBJECT_PROPERTY);

			packet.PutLong(objectId);
			packet.PutInt(0); // isTrickPacket
			packet.AddProperties(propertyList);

			conn.Send(packet);
		}

		/// <summary>
		/// Updates actor's rotation for characters in range of it.
		/// </summary>
		/// <param name="actor"></param>
		public static void ZC_ROTATE(IActor actor)
		{
			var packet = new Packet(Op.ZC_ROTATE);

			packet.PutInt(actor.Handle);
			packet.PutFloat(actor.Direction.Cos);
			packet.PutFloat(actor.Direction.Sin);
			packet.PutByte(1); // Seems to be 1
			packet.PutByte(1); // Seems to be 1
			packet.PutInt(0);

			actor.Map.Broadcast(packet, actor);
		}

		/// <summary>
		/// Updates actor's head rotation for characters in range of it.
		/// </summary>
		/// <param name="entity"></param>
		public static void ZC_HEAD_ROTATE(IActor entity)
		{
			var packet = new Packet(Op.ZC_HEAD_ROTATE);

			packet.PutInt(entity.Handle);
			packet.PutFloat(entity.Direction.Cos);
			packet.PutFloat(entity.Direction.Sin);

			entity.Map.Broadcast(packet, entity);
		}

		/// <summary>
		/// Broadcasts a Lua addon event on the client with the given name,
		/// prefixed with "OPEN_DLG_".
		/// </summary>
		/// <example>
		/// ZC_CUSTOM_DIALOG(character, "warehouse", "", 0);
		/// This call raises "OPEN_DLG_WAREHOUSE", which the client scripts
		/// subscribe to as such:
		/// addon:RegisterMsg("OPEN_DLG_WAREHOUSE", "ON_OPEN_WAREHOUSE");
		/// </example>
		/// <param name="character"></param>
		/// <param name="evName"></param>
		/// <param name="argStr"></param>
		/// <param name="argNum"></param>
		public static void ZC_CUSTOM_DIALOG(Character character, string evName, string argStr = "", int argNum = 0)
		{
			var packet = new Packet(Op.ZC_CUSTOM_DIALOG);

			packet.PutString(evName, 33);
			packet.PutString(argStr, 32);
			packet.PutInt(argNum);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sends ZC_DIALOG_OK to connection, containing a dialog message.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="msg"></param>
		public static void ZC_DIALOG_OK(IZoneConnection conn, string msg)
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
		public static void ZC_DIALOG_NEXT(IZoneConnection conn, string msg)
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
		public static void ZC_DIALOG_SELECT(IZoneConnection conn, params string[] arguments)
			=> ZC_DIALOG_SELECT(conn, (IEnumerable<string>)arguments);

		/// <summary>
		/// Sends ZC_DIALOG_SELECT to connection, containing a dialog message
		/// and a list of selectable options.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="arguments"></param>
		public static void ZC_DIALOG_SELECT(IZoneConnection conn, IEnumerable<string> arguments)
		{
			if (arguments == null || !arguments.Any())
				return;

			var packet = new Packet(Op.ZC_DIALOG_SELECT);

			packet.PutInt(0); // handle?
			packet.PutByte((byte)arguments.Count());

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
		public static void ZC_DIALOG_CLOSE(IZoneConnection conn)
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
		public static void ZC_DIALOG_STRINGINPUT(IZoneConnection conn, string msg)
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
		public static void ZC_DIALOG_NUMBERRANGE(IZoneConnection conn, string msg, int min = 0, int max = 255)
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
		/// Removes actor from all clients on the map it's on.
		/// </summary>
		/// <param name="actor"></param>
		public static void ZC_LEAVE(IActor actor)
		{
			var packet = new Packet(Op.ZC_LEAVE);

			packet.PutInt(actor.Handle);
			packet.PutShort(1); // 0 shows a blue effect when the entity disappears

			actor.Map.Broadcast(packet, actor);
		}

		/// <summary>
		/// Removes actor from map on connection's client.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="actor"></param>
		public static void ZC_LEAVE(IZoneConnection conn, IActor actor)
		{
			var s1 = 1;

			// Items don't seem to disappear with our default, 1, nor with
			// 2, which is used on officials. 4 does get rid of the items
			// though. However, if you use 4, the pick up animation doesn't
			// play. I'm guessing the item can't be removed if it's supposed
			// to get picked up for this very reason, so we'll check whether
			// it was picked up or not.
			if (actor is ItemMonster itemMonster)
				s1 = itemMonster.PickedUp ? 2 : 4;

			var packet = new Packet(Op.ZC_LEAVE);

			packet.PutInt(actor.Handle);
			packet.PutShort(s1); // 0 shows a blue effect when the entity disappears

			conn.Send(packet);
		}

		/// <summary>
		/// Makes actor appear dead on all clients in range of it.
		/// </summary>
		/// <param name="actor"></param>
		public static void ZC_DEAD(IActor actor)
		{
			var packet = new Packet(Op.ZC_DEAD);

			packet.PutInt(actor.Handle);
			packet.PutByte(0);
			packet.PutByte(0); // expInfoCount
			packet.PutByte(false); // isOverkill
			packet.PutByte(false); // specialDrop
			packet.PutPosition(actor.Position);
			packet.PutInt(0);

			//for expInfoCount:
			//{
			//	packet.PutInt(handle);
			//	packet.PutInt(0);
			//	packet.PutLong(exp);
			//	packet.PutLong(jobExp);
			//	packet.PutLong(exp);
			//}

			// The overkill amount is the percentage displayed on the
			// client. It needs to be at least 100 for the overkill
			// effect to appear.
			//if (isOverkill)
			//	packet.PutByte((byte)overkillAmount);

			actor.Map.Broadcast(packet, actor);
		}

		/// <summary>
		/// Opens resurrection dialog on character's client.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="options"></param>
		public static void ZC_RESURRECT_DIALOG(Character character, ResurrectOptions options)
		{
			var packet = new Packet(Op.ZC_RESURRECT_DIALOG);

			packet.PutInt((int)options);
			packet.PutString("", 512);
			packet.PutByte(0);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Acknowledges the character's resurrection request and toggles
		/// the dialog off.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_RESURRECT_SAVE_POINT_ACK(Character character)
		{
			var packet = new Packet(Op.ZC_RESURRECT_SAVE_POINT_ACK);
			packet.PutByte(0);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Acknowledges the character's resurrection request and toggles
		/// the dialog off.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_RESURRECT_HERE_ACK(Character character)
		{
			var packet = new Packet(Op.ZC_RESURRECT_HERE_ACK);
			packet.PutByte(0);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Resurrects the character for all clients in range.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_RESURRECT(Character character)
		{
			var hp = character.Properties.GetFloat(PropertyName.HP);
			var maxHp = character.Properties.GetFloat(PropertyName.MHP);

			var packet = new Packet(Op.ZC_RESURRECT);
			packet.PutInt(character.Handle);
			packet.PutInt((int)hp);
			packet.PutInt((int)maxHp);

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Informs players about a hit that occured, and about the target's
		/// new hp, after damage was applied.
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="hitInfo"></param>
		public static void ZC_HIT_INFO(ICombatEntity attacker, ICombatEntity target, HitInfo hitInfo)
		{
			var packet = new Packet(Op.ZC_HIT_INFO);

			packet.PutInt(target.Handle);
			packet.PutInt(attacker.Handle);
			packet.PutInt((int)hitInfo.SkillId);

			packet.AddHitInfo(hitInfo);

			packet.PutByte(0);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(hitInfo.ForceId);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutFloat(0);
			packet.PutFloat(0);
			packet.PutInt(hitInfo.HitCount);
			packet.PutByte(1);
			packet.PutFloat(0);
			packet.PutInt((int)hitInfo.DamageDelay.TotalMilliseconds);

			target.Map.Broadcast(packet, target);
		}

		/// <summary>
		/// Informs players about a hit that occured, and about the target's
		/// new hp, after damage was applied.
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="hits"></param>
		public static void ZC_SKILL_HIT_INFO(IActor attacker, params SkillHitInfo[] hits)
			=> ZC_SKILL_HIT_INFO(attacker, (IEnumerable<SkillHitInfo>)hits);

		/// <summary>
		/// Informs players about a hit that occured, and about the target's
		/// new hp, after damage was applied.
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="hits"></param>
		public static void ZC_SKILL_HIT_INFO(IActor attacker, IEnumerable<SkillHitInfo> hits)
		{
			var packet = new Packet(Op.ZC_SKILL_HIT_INFO);

			packet.PutInt(attacker.Handle);
			packet.PutByte((byte)hits.Count());

			foreach (var skillHit in hits)
				packet.AddSkillHitInfo(skillHit);

			attacker.Map.Broadcast(packet, attacker);
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
		/// Updates exp and max exp.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="exp"></param>
		public static void ZC_MAX_EXP_CHANGED(Character character, int exp)
		{
			var packet = new Packet(Op.ZC_MAX_EXP_CHANGED);

			packet.PutInt(exp);
			packet.PutLong(character.Exp);
			packet.PutLong(character.MaxExp);
			packet.PutLong(character.TotalExp);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Notification about acquired exp from killing a monster?
		/// </summary>
		/// <param name="character"></param>
		/// <param name="exp"></param>
		/// <param name="jobExp"></param>
		/// <param name="monster"></param>
		public static void ZC_EXP_UP_BY_MONSTER(Character character, long exp, long jobExp, IMonster monster)
		{
			var packet = new Packet(Op.ZC_EXP_UP_BY_MONSTER);

			packet.PutLong(exp);
			packet.PutLong(jobExp);
			packet.PutLong(exp);
			packet.PutInt(monster?.Handle ?? 0);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Adds exp.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="exp"></param>
		/// <param name="jobExp"></param>
		public static void ZC_EXP_UP(Character character, long exp, long jobExp)
		{
			var packet = new Packet(Op.ZC_EXP_UP);

			packet.PutLong(exp);
			packet.PutLong(jobExp);
			packet.PutLong(exp);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Adds job exp.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="exp"></param>
		public static void ZC_JOB_EXP_UP(Character character, long exp)
		{
			var packet = new Packet(Op.ZC_JOB_EXP_UP);

			packet.PutLong(character.ObjectId);
			packet.PutLong(exp);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Executes Lua addon function.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="msg"></param>
		/// <param name="argNum"></param>
		/// <param name="argStr"></param>
		public static void ZC_ADDON_MSG(Character character, string msg, int argNum, string argStr)
		{
			var packet = new Packet(Op.ZC_ADDON_MSG);

			var msgByteLength = packet.GetByteLength(msg);
			if (msgByteLength > byte.MaxValue)
				throw new ArgumentException($"Message is too long with {msgByteLength} bytes. The maximum length is {byte.MaxValue}.");

			packet.PutByte((byte)msgByteLength);
			packet.PutInt(argNum);
			packet.PutByte(0);
			packet.PutRawString(msg);

			if (argStr != null)
				packet.PutRawString(argStr);

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
		/// Shows emoticon for actor on nearby clients.
		/// </summary>
		/// <remarks>
		/// For some available emoticons, search the packet string data for
		/// entries with "_emo_" in their names, such as "I_emo_fear".
		/// </remarks>
		/// <param name="actor"></param>
		/// <param name="packetString"></param>
		/// <param name="duration">Time to show to the emoticon for.</param>
		public static void ZC_SHOW_EMOTICON(IActor actor, string packetString, TimeSpan duration)
		{
			if (!ZoneServer.Instance.Data.PacketStringDb.TryFind(packetString, out var packetStringData))
				throw new ArgumentException($"Packet string '{packetString}' not found.");

			var packet = new Packet(Op.ZC_SHOW_EMOTICON);

			packet.PutInt(actor.Handle);
			packet.PutInt(packetStringData.Id);
			packet.PutInt((int)duration.TotalMilliseconds);

			actor.Map.Broadcast(packet, actor);
		}

		/// <summary>
		/// Sends ZC_LOGIN_TIME to connection.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="now"></param>
		public static void ZC_LOGIN_TIME(IZoneConnection conn, DateTime now)
		{
			var packet = new Packet(Op.ZC_LOGIN_TIME);
			packet.PutLong(now.ToFileTime());

			conn.Send(packet);
		}

		/// <summary>
		/// Sends the visible areas of a map to a character.
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_MAP_REVEAL_LIST(IZoneConnection conn)
		{
			var packet = new Packet(Op.ZC_MAP_REVEAL_LIST);

			var revealedMaps = conn.Account.GetRevealedMaps();

			packet.PutInt(revealedMaps.Length);

			// Officials appear to compress the actual data nowadays, but it seems
			// like the client can still handle the raw data as well.
			foreach (var revealedMap in revealedMaps)
			{
				packet.PutInt(revealedMap.MapId);
				packet.PutBin(revealedMap.Explored);
				packet.PutFloat(revealedMap.Percentage);
				packet.PutFloat(revealedMap.Percentage);
			}

			conn.Send(packet);
		}

		/// <summary>
		/// Sends list of IES modifications to client.
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_IES_MODIFY_LIST(IZoneConnection conn)
		{
			var packet = new Packet(Op.ZC_IES_MODIFY_LIST);
			packet.AddIesModList(ZoneServer.Instance.IesMods);

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
		/// Updates "shield" (?) for actor on nearby clients.
		/// </summary>
		/// <param name="actor"></param>
		/// <param name="shield"></param>
		public static void ZC_UPDATE_SHIELD(IActor actor, int shield)
		{
			var packet = new Packet(Op.ZC_UPDATE_SHIELD);
			packet.PutInt(actor.Handle);
			packet.PutInt(shield);

			actor.Map.Broadcast(packet, actor);
		}

		/// <summary>
		/// Makes entity move in the given direction for clients in range.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="pos"></param>
		/// <param name="dir"></param>
		/// <param name="unkFloat"></param>
		public static void ZC_MOVE_DIR(ICombatEntity entity, Position pos, Direction dir, float unkFloat)
		{
			var packet = new Packet(Op.ZC_MOVE_DIR);

			packet.PutInt(entity.Handle);
			packet.PutPosition(pos);
			packet.PutDirection(dir);
			packet.PutByte(1); // 0 = reduced movement speed... walk mode?
			packet.PutFloat(entity.Properties.GetFloat(PropertyName.MSPD));
			packet.PutFloat(unkFloat);
			packet.PutEmptyBin(24);
			packet.PutInt(6);
			packet.PutInt(0);
			packet.PutByte(1);

			entity.Map.Broadcast(packet, entity);
		}

		/// <summary>
		/// Broadcasts ZC_MOVE_STOP in range of character, informing other
		/// characters about the movement stop.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="pos"></param>
		public static void ZC_MOVE_STOP(ICombatEntity entity, Position pos)
		{
			var packet = new Packet(Op.ZC_MOVE_STOP);

			packet.PutInt(entity.Handle);
			packet.PutPosition(pos);
			packet.PutByte(0);

			entity.Map.Broadcast(packet, entity);
		}

		/// <summary>
		/// Makes player character stop moving on clients in range of it.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="pos"></param>
		/// <param name="dir"></param>
		public static void ZC_PC_MOVE_STOP(ICombatEntity entity, Position pos, Direction dir)
		{
			var packet = new Packet(Op.ZC_PC_MOVE_STOP);

			packet.PutInt(entity.Handle);
			packet.PutPosition(pos);
			packet.PutByte(1);
			packet.PutDirection(dir);
			packet.PutFloat(228787.3f); // timestamp
			packet.PutEmptyBin(24);

			entity.Map.Broadcast(packet, entity);
		}

		/// <summary>
		/// Sends ZC_DIALOG_TRADE to connection, containing the name of the
		/// shop to open.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="shopName"></param>
		public static void ZC_DIALOG_TRADE(IZoneConnection conn, string shopName)
		{
			var packet = new Packet(Op.ZC_DIALOG_TRADE);
			packet.PutString(shopName, 33);

			conn.Send(packet);
		}

		/// <summary>
		/// Notifies the client that the skill is ready? Exact purpose
		/// currently unknown.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="skill"></param>
		/// <param name="position1"></param>
		/// <param name="position2"></param>
		public static void ZC_SKILL_READY(ICombatEntity entity, Skill skill, Position position1, Position position2)
		{
			var packet = new Packet(Op.ZC_SKILL_READY);

			packet.PutInt(entity.Handle);
			packet.PutInt((int)skill.Id);
			packet.PutFloat(1);
			packet.PutFloat(1);
			packet.PutInt(0);
			packet.PutPosition(position1);
			packet.PutPosition(position2);

			// Temporary solution until our skill handling system is
			// more streamlined
			if (entity is Character character)
				character.Connection.Send(packet);
		}

		/// <summary>
		/// Adjusts the time speed of the client.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="timeFactor"></param>
		public static void ZC_TIME_FACTOR(IZoneConnection conn, float timeFactor = 1)
		{
			var packet = new Packet(Op.ZC_TIME_FACTOR);
			packet.PutFloat(timeFactor);

			conn.Send(packet);
		}

		/// <summary>
		/// Updates actor's team id on the client.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="actor"></param>
		/// <param name="team">The team ID which is a value of either '0', '1', or '2'.</param>
		public static void ZC_TEAMID(IZoneConnection conn, IActor actor, byte team)
		{
			var packet = new Packet(Op.ZC_TEAMID);
			packet.PutInt(actor.Handle);
			packet.PutByte(team);

			conn.Send(packet);
		}

		/// <summary>
		/// Makes the character the owner of actor.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="actor"></param>
		public static void ZC_OWNER(Character character, IActor actor)
		{
			var packet = new Packet(Op.ZC_OWNER);
			packet.PutInt(actor.Handle);
			packet.PutInt(character.Handle);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Draws circle area on ground at position for characters in range
		/// of the caster.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="position"></param>
		/// <param name="radius"></param>
		public static void ZC_SKILL_RANGE_CIRCLE(IActor caster, Position position, float radius)
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
		/// of the caster.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="position"></param>
		/// <param name="direction"></param>
		/// <param name="radius"></param>
		/// <param name="radianHalfAngle"></param>
		public static void ZC_SKILL_RANGE_FAN(IActor caster, Position position, Direction direction, float radius, float radianHalfAngle)
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
		/// of the source caster.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="position"></param>
		/// <param name="targetPosition"></param>
		/// <param name="width"></param>
		public static void ZC_SKILL_RANGE_SQUARE(IActor caster, Position position, Position targetPosition, float width)
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
		/// Updates entity's attack state.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="inAttackState"></param>
		public static void ZC_PC_ATKSTATE(ICombatEntity entity, bool inAttackState)
		{
			var packet = new Packet(Op.ZC_PC_ATKSTATE);
			packet.PutInt(entity.Handle);
			packet.PutByte(inAttackState);

			entity.Map.Broadcast(packet, entity);
		}

		/// <summary>
		/// Updates creature's SP
		/// </summary>
		/// <param name="character"></param>
		/// <param name="currentSp"></param>
		/// <param name="displayGain">
		/// If true, the client displays the amount of SP gained
		/// above the character's head. Doesn't display anything
		/// if SP were lost.
		/// </param>
		public static void ZC_UPDATE_SP(Character character, float currentSp, bool displayGain)
		{
			var packet = new Packet(Op.ZC_UPDATE_SP);
			packet.PutInt(character.Handle);
			packet.PutInt((int)currentSp);
			packet.PutByte(displayGain);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Updates a characters HP for damage and healing.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="amount"></param>
		/// <param name="currentHp"></param>
		/// <param name="priority"></param>
		public static void ZC_ADD_HP(Character character, float amount, float currentHp, int priority)
		{
			// For some reason they send 1 for the amount if the expected
			// amount was negative, such as in the case of damage?
			// Or at least this appeared to be the case at some point in
			// time. We should probably double-check it, but then again,
			// the client doesn't really use that value. It simply
			// takes the new HP to update its UI.

			var isDamage = (amount < 0);
			var adjustedAmount = (isDamage ? 1 : amount);

			var packet = new Packet(Op.ZC_ADD_HP);
			packet.PutInt(character.Handle);
			packet.PutInt((int)adjustedAmount);
			packet.PutInt((int)currentHp);
			packet.PutInt(priority);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Updates creature's HP and SP stats.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="priority"></param>
		public static void ZC_UPDATE_ALL_STATUS(ICombatEntity entity, int priority)
		{
			var hp = (int)entity.Properties.GetFloat(PropertyName.HP);
			var maxHp = (int)entity.Properties.GetFloat(PropertyName.MHP);
			var sp = (int)entity.Properties.GetFloat(PropertyName.SP);
			var maxSp = (int)entity.Properties.GetFloat(PropertyName.MSP);

			var packet = new Packet(Op.ZC_UPDATE_ALL_STATUS);

			packet.PutInt(entity.Handle);
			packet.PutInt(hp);
			packet.PutInt(maxHp);
			packet.PutInt(sp);
			packet.PutInt(maxSp);
			packet.PutInt(priority);

			entity.Map.Broadcast(packet, entity);
		}

		/// <summary>
		/// Updates character's HP or SP and displays a floating text
		/// with the modifier, notifying the player of the change.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="amount"></param>
		/// <param name="maxHp"></param>
		/// <param name="type"></param>
		public static void ZC_HEAL_INFO(ICombatEntity entity, float amount, float maxHp, HealType type)
		{
			var packet = new Packet(Op.ZC_HEAL_INFO);

			packet.PutInt(entity.Handle);
			packet.PutInt((int)amount);
			packet.PutInt((int)maxHp);
			packet.PutInt(1);
			packet.PutInt(0);
			packet.PutInt((int)type); // !0 = blue text
			packet.PutInt(0);

			entity.Map.Broadcast(packet, entity);
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

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Updates the actor's faction on the client.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="actor"></param>
		/// <param name="faction"></param>
		public static void ZC_FACTION(IZoneConnection conn, IActor actor, FactionType faction)
		{
			var packet = new Packet(Op.ZC_FACTION);

			packet.PutInt(actor.Handle);
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

			var defaultList = ZoneServer.Instance.Data.HelpDb.Entries.Values.Where(a => a.BasicHelp);

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
		/// Opens help panel for the given topic on character's client.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="helpTopicId"></param>
		/// <param name="maybeSeen"></param>
		public static void ZC_HELP_ADD(Character character, int helpTopicId, byte maybeSeen)
		{
			var packet = new Packet(Op.ZC_HELP_LIST);
			packet.PutInt(helpTopicId);
			packet.PutByte(maybeSeen);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Requests the client to send information that needs to be saved
		/// before exiting?
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_SAVE_INFO(IZoneConnection conn)
		{
			var packet = new Packet(Op.ZC_SAVE_INFO);
			conn.Send(packet);
		}

		/// <summary>
		/// Acknowledges the client that the loading screen has completed.
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_LOAD_COMPLETE(IZoneConnection conn)
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

			packet.PutShort(sessionObjects.Length);
			packet.PutByte(false);
			packet.PutFloat(565831.1f);

			foreach (var sessionObject in sessionObjects)
			{
				var propertyList = sessionObject.Properties.GetAll();
				var propertiesSize = propertyList.GetByteCount();

				packet.PutInt(sessionObject.Id);
				packet.PutInt(0);
				packet.PutLong(sessionObject.ObjectId);
				packet.PutFloat(0);
				packet.PutShort(propertiesSize);
				packet.PutShort(0); // Alignment?

				packet.AddProperties(propertyList);
			}

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Updates premium state properties on client.
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_SEND_CASH_VALUE(IZoneConnection conn)
		{
			var packet = new Packet(Op.ZC_SEND_CASH_VALUE);

			// Normal
			packet.PutInt(4); // count?
			{
				packet.PutLpString("marketSellCom");
				packet.PutDouble(30);

				packet.PutLpString("marketUpMax");
				packet.PutDouble(1);

				packet.PutLpString("abilityMax");
				packet.PutDouble(1);

				packet.PutLpString("speedUp");
				packet.PutDouble(0);
			}

			// Premium Type 1
			packet.PutInt(4);
			{
				packet.PutLpString("marketSellCom");
				packet.PutDouble(10);

				packet.PutLpString("marketUpMax");
				packet.PutDouble(5);

				packet.PutLpString("abilityMax");
				packet.PutDouble(3);

				packet.PutLpString("speedUp");
				packet.PutDouble(3);
			}

			// Token
			packet.PutInt(4);
			{
				packet.PutLpString("marketSellCom");
				packet.PutDouble(10);

				packet.PutLpString("marketUpMax");
				packet.PutDouble(10);

				packet.PutLpString("abilityMax");
				packet.PutDouble(2);

				packet.PutLpString("speedUp");
				packet.PutDouble(3);
			}

			// ?
			packet.PutInt(4);
			{
				packet.PutInt(5);
				packet.PutFloat(1);

				packet.PutInt(14);
				packet.PutFloat(1);

				packet.PutInt(1);
				packet.PutFloat(0);

				packet.PutInt(3);
				packet.PutFloat(0);
			}

			packet.PutInt(33);

			conn.Send(packet);
		}

		/// <summary>
		/// Updates premium state on client.
		/// </summary>
		/// <remarks>
		/// May crash the client if a correct ZC_SEND_CASH_VALUE packet was not
		/// sent first.
		/// </remarks>
		/// <param name="conn"></param>
		/// <param name="state"></param>
		public static void ZC_SEND_PREMIUM_STATE(IZoneConnection conn, PremiumState state)
		{
			var packet = new Packet(Op.ZC_SEND_PREMIUM_STATE);

			packet.PutByte((byte)state.Type);
			packet.PutByte(state.Active);
			packet.PutInt(state.RemainingSeconds);
			packet.PutInt(state.NumArg);

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
			packet.PutLong(character.ObjectId);
			packet.PutShort(1003);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sends ZC_SET_CHATBALLOON_SKIN to client (dummy).
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_SET_CHATBALLOON_SKIN(IZoneConnection conn)
		{
			var packet = new Packet(Op.ZC_SET_CHATBALLOON_SKIN);
			packet.PutBinFromHex("71820100010000000000000000000100008000000000D86E");

			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_MYPAGE_MAP to client (dummy).
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_MYPAGE_MAP(IZoneConnection conn)
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
		public static void ZC_GUESTPAGE_MAP(IZoneConnection conn)
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
		public static void ZC_PCBANG_SHOP_RENTAL(IZoneConnection conn)
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
		public static void ZC_ATTENDANCE_REWARD_CHECK_UI_ON(IZoneConnection conn)
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
		/// Updates the daylight settings for the given character.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="enabled"></param>
		/// <param name="parameters"></param>
		public static void ZC_DAYLIGHT_FIXED(Character character, bool enabled, DaylightParameters parameters)
		{
			var packet = new Packet(Op.ZC_DAYLIGHT_FIXED);

			packet.PutInt(enabled ? 1 : 0);
			packet.PutByte(0);
			packet.PutFloat(parameters.FR);
			packet.PutFloat(parameters.FG);
			packet.PutFloat(parameters.FB);
			packet.PutFloat(parameters.MapLightStrength);
			packet.PutFloat(parameters.ModelLightStrength);

			// [i361296]
			{
				packet.PutByte(0);
			}

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Updates the daylight settings for all characters on all maps.
		/// </summary>
		/// <param name="enabled"></param>
		/// <param name="parameters"></param>
		public static void ZC_DAYLIGHT_FIXED(bool enabled, DaylightParameters parameters)
		{
			var packet = new Packet(Op.ZC_DAYLIGHT_FIXED);

			packet.PutInt(enabled ? 1 : 0);
			packet.PutByte(0);
			packet.PutFloat(parameters.FR);
			packet.PutFloat(parameters.FG);
			packet.PutFloat(parameters.FB);
			packet.PutFloat(parameters.MapLightStrength);
			packet.PutFloat(parameters.ModelLightStrength);

			// [i361296]
			{
				packet.PutByte(0);
			}

			ZoneServer.Instance.World.Broadcast(packet);
		}

		/// <summary>
		/// Plays sound for character.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="packetString"></param>
		public static void ZC_PLAY_SOUND(Character character, string packetString)
		{
			if (!ZoneServer.Instance.Data.PacketStringDb.TryFind(packetString, out var packetStringData))
				throw new ArgumentException($"Packet string '{packetString}' not found.");

			var packet = new Packet(Op.ZC_PLAY_SOUND);

			packet.PutInt(character.Handle);
			packet.PutInt(packetStringData.Id);
			packet.PutByte(0);
			packet.PutFloat(-1);
			packet.PutByte(0);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Plays sound for clients in range of the actor.
		/// </summary>
		/// <param name="actor"></param>
		/// <param name="packetString"></param>
		public static void ZC_PLAY_SOUND(IActor actor, string packetString)
		{
			if (!ZoneServer.Instance.Data.PacketStringDb.TryFind(packetString, out var packetStringData))
				throw new ArgumentException($"Packet string '{packetString}' not found.");

			var packet = new Packet(Op.ZC_PLAY_SOUND);

			packet.PutInt(actor.Handle);
			packet.PutInt(packetStringData.Id);
			packet.PutByte(0);
			packet.PutFloat(-1);
			packet.PutByte(0);

			actor.Map.Broadcast(packet, actor);
		}

		/// <summary>
		/// Stops the sound for all clients in range of the actor.
		/// </summary>
		/// <param name="actor"></param>
		/// <param name="packetString"></param>
		public static void ZC_STOP_SOUND(IActor actor, string packetString)
		{
			if (!ZoneServer.Instance.Data.PacketStringDb.TryFind(packetString, out var packetStringData))
				throw new ArgumentException($"Packet string '{packetString}' not found.");

			var packet = new Packet(Op.ZC_STOP_SOUND);

			packet.PutInt(actor.Handle);
			packet.PutInt(packetStringData.Id);

			actor.Map.Broadcast(packet, actor);
		}

		/// <summary>
		/// Plays sound for clients in range of the actor, sending the packet with
		/// either the male or female string, depending on the actor's gender.
		/// </summary>
		/// <param name="actor"></param>
		/// <param name="packetStringMale"></param>
		/// <param name="packetStringFemale"></param>
		public static void ZC_PLAY_SOUND_Gendered(IActor actor, string packetStringMale, string packetStringFemale)
		{
			var gender = (actor is Character character ? character.Gender : Gender.Male);
			var packetString = (gender == Gender.Male ? packetStringMale : packetStringFemale);

			ZC_PLAY_SOUND(actor, packetString);
		}

		/// <summary>
		/// Stops the sound for all clients in range of the actor, sending
		/// the packet with either the male or female string, depending on
		/// the actor's gender.
		/// </summary>
		/// <param name="actor"></param>
		/// <param name="packetStringMale"></param>
		/// <param name="packetStringFemale"></param>
		public static void ZC_STOP_SOUND_Gendered(IActor actor, string packetStringMale, string packetStringFemale)
		{
			var gender = (actor is Character character ? character.Gender : Gender.Male);
			var packetString = (gender == Gender.Male ? packetStringMale : packetStringFemale);

			ZC_STOP_SOUND(actor, packetString);
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
		public static void ZC_PCBANG_SHOP_COMMON(IConnection conn)
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
		public static void ZC_TRUST_INFO(IZoneConnection conn)
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
		/// Plays animation for actor on nearby clients.
		/// </summary>
		/// <param name="actor">Entity to animate.</param>
		/// <param name="animationName">Name of the animation to play (uses packet string database to retrieve the id of the string).</param>
		/// <param name="stopOnLastFrame">If true, the animation plays once and then stops on the last frame.</param>
		public static void ZC_PLAY_ANI(IActor actor, string animationName, bool stopOnLastFrame = false)
		{
			if (!ZoneServer.Instance.Data.PacketStringDb.TryFind(animationName, out var packetStringData))
				throw new ArgumentException($"Unknown packet string '{animationName}'.");

			ZC_PLAY_ANI(actor, packetStringData.Id, stopOnLastFrame);
		}

		/// <summary>
		/// Plays animation for actor on nearby clients.
		/// </summary>
		/// <param name="actor">Entity to animate.</param>
		/// <param name="packetStringId">Id of the string for the animation to play.</param>
		/// <param name="stopOnLastFrame">If true, the animation plays once and then stops on the last frame.</param>
		public static void ZC_PLAY_ANI(IActor actor, int packetStringId, bool stopOnLastFrame = false)
		{
			var packet = new Packet(Op.ZC_PLAY_ANI);

			packet.PutInt(actor.Handle);
			packet.PutInt(packetStringId);
			packet.PutByte(stopOnLastFrame);
			packet.PutByte(0);
			packet.PutFloat(0);
			packet.PutFloat(1);

			// [i373230] Maybe added earlier
			{
				packet.PutByte(0);
				packet.PutByte(0);
			}

			actor.Map.Broadcast(packet, actor);
		}

		/// <summary>
		/// Sends ZC_COMMON_SKILL_LIST to character (dummy).
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_COMMON_SKILL_LIST(IZoneConnection conn)
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
		public static void ZC_PCBANG_POINT(IZoneConnection conn)
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
		public static void ZC_MSPD(ICombatEntity entity)
		{
			var packet = new Packet(Op.ZC_MSPD);

			packet.PutInt(entity.Handle);
			packet.PutFloat(entity.Properties.GetFloat(PropertyName.MSPD));
			packet.PutLong(0);

			entity.Map.Broadcast(packet, entity);
		}

		/// <summary>
		/// Updates the given value on the character's client.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="type"></param>
		/// <param name="value"></param>
		public static void ZC_CUSTOM_COMMANDER_INFO(Character character, CommanderInfoType type, int value)
		{
			var packet = new Packet(Op.ZC_CUSTOM_COMMANDER_INFO);

			packet.PutLong(0);
			packet.PutInt(0);
			packet.PutShort((short)type);
			packet.PutInt(value);
			packet.PutInt(0);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Sends Lua script to client for execution.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="script"></param>
		public static void ZC_EXEC_CLIENT_SCP(IZoneConnection conn, string script)
		{
			var packet = new Packet(Op.ZC_EXEC_CLIENT_SCP);
			packet.PutString(script); // CHECK_APPLICATION_LIST("693014448046952")

			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_SOLO_DUNGEON_RANKING to character (dummy).
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_SOLO_DUNGEON_RANKING(IZoneConnection conn, List<Character> characters)
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
				packet.PutLong(character.ObjectId);
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
		public static void ZC_RESET_VIEW(IZoneConnection conn)
		{
			var packet = new Packet(Op.ZC_RESET_VIEW);
			conn.Send(packet);
		}

		/// <summary>
		/// Notifies nearby clients that the actor is leaving a trigger event.
		/// </summary>
		/// <param name="actor"></param>
		public static void ZC_LEAVE_HOOK(IActor actor)
		{
			var packet = new Packet(Op.ZC_LEAVE_HOOK);
			packet.PutInt(actor.Handle);

			// TODO: Does this actually need to be broadcasted?
			actor.Map.Broadcast(packet, actor);
		}

		/// <summary>
		/// Not too sure what this does, maybe for store purchases?
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_SET_WEBSERVICE_URL(IZoneConnection conn)
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
		public static void ZC_RESPONSE_FIELD_BOSS_EXIST(IZoneConnection conn)
		{
			var packet = new Packet(Op.ZC_RESPONSE_FIELD_BOSS_EXIST);
			packet.PutInt(0); // 0 usually

			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_WEEKLY_BOSS_NOW_WEEK_NUM to character (dummy).
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_WEEKLY_BOSS_NOW_WEEK_NUM(IZoneConnection conn)
		{
			var packet = new Packet(Op.ZC_WEEKLY_BOSS_NOW_WEEK_NUM);
			packet.PutInt(0x49);

			conn.Send(packet);
		}

		/// <summary>
		/// Sends ZC_RESPONSE_BORUTA_NOW_WEEK_NUM to character (dummy).
		/// </summary>
		/// <param name="conn"></param>
		public static void ZC_RESPONSE_BORUTA_NOW_WEEK_NUM(IZoneConnection conn)
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
		public static void ZC_ENABLE_CONTROL(IZoneConnection conn, bool enabled)
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
		public static void ZC_LOCK_KEY(IZoneConnection conn)
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
		public static void ZC_SHARED_MSG(IZoneConnection conn, int messageId)
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

			packet.PutLong(character.ObjectId);
			packet.PutInt(i1); // 1551 or 2255
			packet.PutInt(overheat);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Exact purpose unknown, presumed to be related to keeping
		/// skills, hits, animations, and/or effects in sync somehow.
		/// </summary>
		/// <remarks>
		/// The key identifies the sync-procedure across the different
		/// sync packets.
		/// </remarks>
		/// <param name="character"></param>
		/// <param name="key"></param>
		/// <param name="f1"></param>
		public static void ZC_SYNC_START(Character character, int key, float f1)
		{
			var packet = new Packet(Op.ZC_SYNC_START);

			packet.PutInt(key);
			packet.PutFloat(f1);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Exact purpose unknown, presumed to be related to keeping
		/// skills, hits, animations, and/or effects in sync somehow.
		/// </summary>
		/// <remarks>
		/// The key identifies the sync-procedure across the different
		/// sync packets.
		/// </remarks>
		/// <param name="character"></param>
		/// <param name="key"></param>
		/// <param name="f1"></param>
		public static void ZC_SYNC_END(Character character, int key, float f1)
		{
			var packet = new Packet(Op.ZC_SYNC_END);

			packet.PutInt(key);
			packet.PutFloat(f1);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Exact purpose unknown, presumed to be related to keeping
		/// skills, hits, animations, and/or effects in sync somehow.
		/// </summary>
		/// <remarks>
		/// The key identifies the sync-procedure across the different
		/// sync packets.
		/// </remarks>
		/// <param name="character"></param>
		/// <param name="key"></param>
		/// <param name="f1"></param>
		public static void ZC_SYNC_EXEC_BY_SKILL_TIME(Character character, int key, TimeSpan f1)
		{
			var packet = new Packet(Op.ZC_SYNC_EXEC_BY_SKILL_TIME);

			packet.PutInt(character.Handle);
			packet.PutInt(key);
			packet.PutInt((int)f1.TotalMilliseconds);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Exact purpose unknown, presumed to be related to keeping
		/// skills, hits, animations, and/or effects in sync somehow.
		/// </summary>
		/// <remarks>
		/// The key identifies the sync-procedure across the different
		/// sync packets.
		/// </remarks>
		/// <param name="character"></param>
		/// <param name="key"></param>
		public static void ZC_SYNC_EXEC(Character character, int key)
		{
			var packet = new Packet(Op.ZC_SYNC_EXEC);
			packet.PutInt(key);

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
		/// Updates the list of sold items in an NPC shop or the warehouse items.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="type"></param>
		/// <param name="items">List of items, with the key being the position/indices.</param>
		public static void ZC_SOLD_ITEM_DIVISION_LIST(Character character, StorageType type, Dictionary<int, Item> items)
		{
			var packet = new Packet(Op.ZC_SOLD_ITEM_DIVISION_LIST);

			packet.PutByte((byte)type);
			packet.PutInt(items.Count);
			packet.PutByte(true);
			packet.PutByte(true);
			packet.PutByte(true);

			if (items.Count != 0)
			{
				packet.Zlib(true, zpacket =>
				{
					foreach (var itemKV in items.OrderBy(a => a.Key))
					{
						var position = itemKV.Key;
						var item = itemKV.Value;

						var isSilver = item.Id == ItemId.Silver;
						var propertyList = item.Properties.GetAll();

						// Forces every item to have at least one property.
						// Client seems to crash in certain scenarios when
						// items with no properties are received.
						if (propertyList.Count == 0)
							propertyList.Add(new FloatProperty(PropertyName.CoolDown, 0));

						var propertiesSize = propertyList.GetByteCount();

						zpacket.PutInt(item.Id);
						zpacket.PutInt(propertiesSize);
						zpacket.PutLong(isSilver ? 0 : item.ObjectId);
						zpacket.PutInt(item.Amount);
						zpacket.PutInt(item.Price);
						zpacket.PutInt(1);
						zpacket.PutInt(position);
						zpacket.AddProperties(propertyList);

						if (!isSilver && item.ObjectId > 0)
						{
							zpacket.PutShort(0);
							zpacket.PutLong(item.ObjectId);
							zpacket.PutShort(0);
						}
					}
				});
			}
			else
			{
				// This is a compressed packet of 2 bytes length. We can't
				// store any meaningful data in that space, so it's probably
				// just a compressed empty packet.
				packet.PutBinFromHex("8DFA 02000000 0300");
			}

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Display's a character's information in a side-panel.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="character"></param>
		public static void ZC_PROPERTY_COMPARE(IZoneConnection conn, Character character)
		{
			var jobs = character.Jobs.GetList();
			var properties = character.Properties.GetAll();
			var propertiesSize = properties.GetByteCount();
			var equipItems = character.Inventory.GetEquip();

			var packet = new Packet(Op.ZC_PROPERTY_COMPARE);

			packet.PutInt(character.Handle);
			packet.PutString(character.Name, 65);
			packet.PutLong(character.ObjectId);
			packet.PutLong(character.AccountId);
			packet.PutInt(0);
			packet.PutByte(1); // needs to be 1 for the character info to display?
			packet.PutByte(0);
			packet.PutInt(-1); // adventurerIndex
			packet.PutInt(0); // adventurerRank
			packet.PutInt(0); // achievementCount
			packet.PutInt(0);

			packet.PutString(character.TeamName, 64);
			packet.PutString(character.Name, 65);
			packet.PutByte(0);
			packet.PutShort((short)character.JobId);
			packet.PutInt(0);
			packet.PutByte((byte)character.Gender);
			packet.PutShort(0);
			packet.PutEmptyBin(25);
			packet.PutShort(1001); // serverGroupId

			packet.PutShort(0);
			packet.PutInt(character.Level);
			packet.PutInt(0);

			for (var i = 0; i < 4; ++i)
			{
				if (i < jobs.Length)
					packet.PutShort((short)jobs[i].Id);
				else
					packet.PutShort(0);
			}

			packet.PutLong(0);
			packet.PutShort(propertiesSize);
			packet.PutShort(0); // etcPropertySize

			packet.AddAppearancePc(character);

			packet.AddProperties(properties);
			//packet.AddProperties(etcProperties);

			foreach (var equipItemKv in equipItems)
			{
				var equipSlot = equipItemKv.Key;
				var equipItem = equipItemKv.Value;

				var equipItemProperties = equipItem.Properties.GetAll();
				var equipItemPropertiesSize = equipItemProperties.GetByteCount();

				packet.PutInt(equipItem.Id);
				packet.PutShort(equipItemPropertiesSize);
				packet.PutShort(equipItem.Amount);
				packet.PutLong(equipItem.ObjectId);
				packet.PutInt((int)equipSlot);
				packet.PutInt(0);
				packet.PutShort(0);

				if (equipItemPropertiesSize > 0)
				{
					packet.AddProperties(equipItemProperties);

					packet.PutShort(0); // sealOptionSize
					packet.PutLong(equipItem.ObjectId);
					packet.PutShort(0); // gemCount
				}
			}

			packet.PutShort(jobs.Length);
			foreach (var job in jobs)
			{
				packet.PutShort((short)job.Id);
				packet.PutByte(0x00);
				packet.PutByte(0xB1);
				packet.PutInt(0);
				packet.PutInt(0);
				packet.PutInt(0);
				packet.PutInt(0);
				packet.PutInt(0);
				packet.PutInt(0);
				packet.PutInt(0);
				packet.PutInt(0);
				packet.PutInt(0);
			}

			conn.Send(packet);
		}

		/// <summary>
		/// Updates monster appearance on clients in range of the monster.
		/// </summary>
		/// <param name="monster"></param>
		public static void ZC_UPDATED_MONSTERAPPEARANCE(IMonster monster)
		{
			var packet = new Packet(Op.ZC_UPDATED_MONSTERAPPEARANCE);
			packet.PutInt(monster.Handle);
			packet.AddMonsterApperanceBase(monster);

			packet.PutInt(monster.GetByteCount());
			packet.AddMonsterApperance(monster);

			monster.Map.Broadcast(packet, monster);
		}

		/// <summary>
		/// Display a buff on client UI
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="buff"></param>
		public static void ZC_BUFF_ADD(ICombatEntity entity, Buff buff)
		{
			var packet = new Packet(Op.ZC_BUFF_ADD);
			packet.AddTargetedBuff(buff);

			entity.Map.Broadcast(packet, entity);
		}

		/// <summary>
		/// Update a buff after a buff has been added
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="buff"></param>
		public static void ZC_BUFF_UPDATE(ICombatEntity entity, Buff buff)
		{
			var packet = new Packet(Op.ZC_BUFF_UPDATE);
			packet.AddTargetedBuff(buff);

			entity.Map.Broadcast(packet, entity);
		}

		/// <summary>
		/// Remove buff from client UI
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="buff"></param>
		public static void ZC_BUFF_REMOVE(ICombatEntity entity, Buff buff)
		{
			var packet = new Packet(Op.ZC_BUFF_REMOVE);

			packet.PutInt(entity.Handle);
			packet.PutInt((int)buff.Id);
			packet.PutByte(0);
			packet.PutInt(buff.Handle);
			packet.PutByte(0);

			entity.Map.Broadcast(packet, entity);
		}

		/// <summary>
		/// Updates the entity's buffs on the client.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="entity"></param>
		public static void ZC_BUFF_LIST(IZoneConnection conn, ICombatEntity entity)
		{
			var buffs = entity.Components.Get<BuffComponent>();
			var buffCount = buffs?.Count ?? 0;

			var packet = new Packet(Op.ZC_BUFF_LIST);

			packet.PutInt(entity.Handle);
			packet.PutByte((byte)buffCount);
			if (buffCount > 0)
			{
				foreach (var buff in buffs.GetList())
					packet.AddBuff(buff);
			}

			conn.Send(packet);
		}

		/// <summary>
		/// Updates the entity's buffs on all clients in range.
		/// </summary>
		/// <param name="entity"></param>
		public static void ZC_BUFF_LIST(ICombatEntity entity)
		{
			var buffs = entity.Components.Get<BuffComponent>();
			var buffCount = buffs?.Count ?? 0;

			var packet = new Packet(Op.ZC_BUFF_LIST);

			packet.PutInt(entity.Handle);
			packet.PutByte((byte)buffCount);
			if (buffCount > 0)
			{
				foreach (var buff in buffs.GetList())
					packet.AddBuff(buff);
			}

			entity.Map.Broadcast(packet, entity);
		}

		/// <summary>
		/// Clear buff buff handle association? Sent on entity death and
		/// removal.
		/// </summary>
		/// <param name="entity"></param>
		public static void ZC_BUFF_CLEAR(ICombatEntity entity)
		{
			var packet = new Packet(Op.ZC_BUFF_CLEAR);

			packet.PutInt(entity.Handle);
			packet.PutByte(1);

			entity.Map.Broadcast(packet, entity);
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
		public static void ZC_BUFF_UPDATE_TIME(ICombatEntity entity, Buff buff)
		{
			var packet = new Packet(Op.ZC_BUFF_UPDATE_TIME);

			packet.PutLong(0);
			packet.PutInt(0);
			packet.PutInt(entity.Handle);
			packet.PutInt((int)buff.Id);
			packet.PutInt(0); // Increasing Value?

			entity.Map.Broadcast(packet, entity);
		}

		/// <summary>
		/// Plays item pick up animation for the character and item monster.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="itemMonster"></param>
		public static void ZC_ITEM_GET(IActor character, IActor itemMonster)
		{
			var packet = new Packet(Op.ZC_ITEM_GET);

			packet.PutInt(character.Handle);
			packet.PutInt(itemMonster.Handle);
			packet.PutInt(1);

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Makes actor move between the given positions.
		/// </summary>
		/// <remarks>
		/// The positions must use the cell for Y, instead of the height,
		/// otherwise the client is not able to handle the packet.
		/// </remarks>
		/// <param name="actor"></param>
		/// <param name="fromCellPos"></param>
		/// <param name="toCellPos"></param>
		/// <param name="speed"></param>
		public static void ZC_MOVE_PATH(IActor actor, Position fromCellPos, Position toCellPos, float speed)
		{
			var packet = new Packet(Op.ZC_MOVE_PATH);
			packet.AddCellMovement(actor, fromCellPos, toCellPos, speed);

			actor.Map.Broadcast(packet, actor);
		}

		/// <summary>
		/// Makes actor move between the given positions on the character's client.
		/// </summary>
		/// <remarks>
		/// The positions must use the cell for Y, instead of the height,
		/// otherwise the client is not able to handle the packet.
		/// </remarks>
		/// <param name="character"></param>
		/// <param name="actor"></param>
		/// <param name="fromCellPos"></param>
		/// <param name="toCellPos"></param>
		/// <param name="speed"></param>
		public static void ZC_MOVE_PATH(Character character, IActor actor, Position fromCellPos, Position toCellPos, float speed)
		{
			var packet = new Packet(Op.ZC_MOVE_PATH);
			packet.AddCellMovement(actor, fromCellPos, toCellPos, speed);

			character.Connection.Send(packet);
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

		/// <summary>
		/// Informs client that the item has been used, playing animations
		/// for some types.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="itemClassId"></param>
		public static void ZC_ITEM_USE(Character character, int itemClassId)
		{
			var packet = new Packet(Op.ZC_ITEM_USE);
			packet.PutInt(character.Handle);
			packet.PutInt(itemClassId);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Displays area of affect for skill.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="skillClassName"></param>
		/// <param name="duration"></param>
		/// <param name="area"></param>
		public static void ZC_START_RANGE_PREVIEW(ICombatEntity caster, string skillClassName, TimeSpan duration, ISplashArea area)
			=> ZC_START_RANGE_PREVIEW(caster, skillClassName, duration, area.SplashType, area.OriginPos, area.Direction, area.Height, area.Width);

		/// <summary>
		/// Displays area of affect for skill.
		/// </summary>
		/// <param name="map"></param>
		/// <param name="casterHandle"></param>
		/// <param name="skillClassName"></param>
		/// <param name="duration"></param>
		/// <param name="area"></param>
		public static void ZC_START_RANGE_PREVIEW(Map map, int casterHandle, string skillClassName, TimeSpan duration, ISplashArea area)
			=> ZC_START_RANGE_PREVIEW(map, casterHandle, skillClassName, duration, area.SplashType, area.OriginPos, area.Direction, area.Height, area.Width);

		/// <summary>
		/// Displays area of affect for skill.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="skillClassName"></param>
		/// <param name="duration"></param>
		/// <param name="splashType"></param>
		/// <param name="originPos"></param>
		/// <param name="direction"></param>
		/// <param name="height"></param>
		/// <param name="width"></param>
		public static void ZC_START_RANGE_PREVIEW(ICombatEntity caster, string skillClassName, TimeSpan duration, SplashType splashType, Position originPos, Direction direction, float height, float width)
			=> ZC_START_RANGE_PREVIEW(caster.Map, caster.Handle, skillClassName, duration, splashType, originPos, direction, height, width);

		/// <summary>
		/// Displays area of affect for skill.
		/// </summary>
		/// <param name="map"></param>
		/// <param name="casterHandle"></param>
		/// <param name="skillClassName"></param>
		/// <param name="duration"></param>
		/// <param name="splashType"></param>
		/// <param name="originPos"></param>
		/// <param name="direction"></param>
		/// <param name="height"></param>
		/// <param name="width"></param>
		public static void ZC_START_RANGE_PREVIEW(Map map, int casterHandle, string skillClassName, TimeSpan duration, SplashType splashType, Position originPos, Direction direction, float height, float width)
		{
			var packet = new Packet(Op.ZC_START_RANGE_PREVIEW);

			packet.PutInt(casterHandle);
			packet.PutString(skillClassName, 64);
			packet.PutString(splashType.ToString(), 10);
			packet.PutLong(0);
			packet.PutLong(0);
			packet.PutFloat(0);
			packet.PutShort(0);
			packet.PutFloat((float)duration.TotalSeconds);
			packet.PutFloat(0);
			packet.PutPosition(originPos);
			packet.PutDirection(direction);
			packet.PutFloat(0); // animation start distance, if > length, animation starts past the splash area and goes back towards it
			packet.PutFloat(height);
			packet.PutFloat(width);
			packet.PutByte(0);

			map.Broadcast(packet);
		}

		/// <summary>
		/// Updates certain skill properties, such as speed rate, hit
		/// delay, and max overheat count.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="skills"></param>
		public static void ZC_UPDATE_SKL_SPDRATE_LIST(Character character, IEnumerable<Skill> skills)
		{
			var packet = new Packet(Op.ZC_UPDATE_SKL_SPDRATE_LIST);

			packet.PutInt(skills.Count());

			foreach (var skill in skills)
			{
				packet.PutInt((int)skill.Id);
				packet.PutFloat(skill.Properties.GetFloat(PropertyName.SklSpdRate));
				packet.PutFloat(skill.Properties.GetFloat(PropertyName.HitDelay));
				packet.PutFloat(skill.Data.OverheatCount);
			}

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Toggles character's fluting stance.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="enabled"></param>
		public static void ZC_READY_FLUTING(Character character, bool enabled)
		{
			var packet = new Packet(Op.ZC_READY_FLUTING);

			packet.PutInt(character.Handle);
			packet.PutByte(enabled);

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Makes character play a note on their flute.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="note"></param>
		/// <param name="octave"></param>
		/// <param name="semitone"></param>
		/// <param name="animate"></param>
		public static void ZC_PLAY_FLUTING(Character character, int note, int octave, bool semitone, bool animate)
		{
			var packet = new Packet(Op.ZC_PLAY_FLUTING);

			packet.PutInt(character.Handle);
			packet.PutInt(note);
			packet.PutInt(octave);
			packet.PutByte(semitone);
			packet.PutByte(animate);

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Stops character playing the current note on their flute.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="note"></param>
		/// <param name="octave"></param>
		/// <param name="semitone"></param>
		public static void ZC_STOP_FLUTING(Character character, int note, int octave, bool semitone)
		{
			var packet = new Packet(Op.ZC_STOP_FLUTING);

			packet.PutInt(character.Handle);
			packet.PutInt(note);
			packet.PutInt(octave);
			packet.PutByte(semitone);

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Broadcasts text to all players in the world.
		/// </summary>
		/// <param name="type"></param>
		/// <param name="text"></param>
		public static void ZC_TEXT(NoticeTextType type, string text)
		{
			var packet = new Packet(Op.ZC_TEXT);

			packet.PutByte((byte)type);
			packet.PutByte(0);
			packet.PutString(text);

			ZoneServer.Instance.World.Broadcast(packet);
		}

		/// <summary>
		/// Updates the character's own HUD skin on the client.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="character"></param>
		public static void ZC_SEND_APPLY_HUD_SKIN_MYSELF(IZoneConnection conn, Character character)
		{
			var skinId = character.Variables.Perm.GetInt("Melia.HudSkin", 0);

			var packet = new Packet(Op.ZC_SEND_APPLY_HUD_SKIN_MYSELF);

			packet.PutInt(character.Handle);
			packet.PutInt(skinId);

			conn.Send(packet);
		}

		/// <summary>
		/// Updates the character's HUD skin for other clients (?).
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="character"></param>
		public static void ZC_SEND_APPLY_HUD_SKIN_OTHER(IZoneConnection conn, Character character)
		{
			var skinId = character.Variables.Perm.GetInt("Melia.HudSkin", 0);

			var packet = new Packet(Op.ZC_SEND_APPLY_HUD_SKIN_OTHER);

			packet.PutInt(character.Handle);
			packet.PutInt(skinId);

			conn.Send(packet);
		}

		/// <summary>
		/// Updates the character's HUD skin for clients in range (?).
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_SEND_APPLY_HUD_SKIN_OTHER(Character character)
		{
			var skinId = character.Variables.Perm.GetInt("Melia.HudSkin", 0);

			var packet = new Packet(Op.ZC_SEND_APPLY_HUD_SKIN_OTHER);

			packet.PutInt(character.Handle);
			packet.PutInt(skinId);

			ZoneServer.Instance.World.Broadcast(packet);
		}

		/// <summary>
		/// Updates the character's HUD mode (?) on the client.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="character"></param>
		public static void ZC_SEND_MODE_HUD_SKIN(IZoneConnection conn, Character character)
		{
			var packet = new Packet(Op.ZC_SEND_MODE_HUD_SKIN);

			packet.PutInt(character.Handle);
			packet.PutByte(0);

			conn.Send(packet);
		}

		/// <summary>
		/// Updates the character's damage font skin (?) on the client.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="character"></param>
		public static void ZC_RES_DAMAGEFONT_SKIN(IZoneConnection conn, Character character)
		{
			var skinId = character.Variables.Perm.GetInt("Melia.DamageFontSkin", 1);

			var packet = new Packet(Op.ZC_RES_DAMAGEFONT_SKIN);

			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(character.Handle);
			packet.PutInt(skinId);

			conn.Send(packet);
		}

		/// <summary>
		/// Updates the character's damage effect skin (?) on the client.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="character"></param>
		public static void ZC_RES_DAMAGEEFFECT_SKIN(IZoneConnection conn, Character character)
		{
			var skinId = character.Variables.Perm.GetInt("Melia.DamageEffectSkin", 1);

			var packet = new Packet(Op.ZC_RES_DAMAGEEFFECT_SKIN);

			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(character.Handle);
			packet.PutInt(skinId);

			conn.Send(packet);
		}

		/// <summary>
		/// Fixes the camera at the given position on the character's client.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="pos">Position to fix the camera at.</param>
		/// <param name="zoomLevel">Defines the zoom level for the fixed camera. Use 0 for no change.</param>
		public static void ZC_FIXCAMERA(Character character, Position pos, float zoomLevel)
		{
			var packet = new Packet(Op.ZC_FIXCAMERA);
			packet.PutPosition(pos);
			packet.PutFloat(zoomLevel);

			character.Connection.Send(packet);
		}

		/// <summary>
		/// Unfixes the camera on the character's client and makes it
		/// follow them again.
		/// </summary>
		/// <param name="character"></param>
		public static void ZC_CANCEL_FIXCAMERA(Character character)
		{
			var packet = new Packet(Op.ZC_CANCEL_FIXCAMERA);
			character.Connection.Send(packet);
		}

		/// <summary>
		/// Updates entity's guard state on clients in range.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="active"></param>
		/// <param name="dir"></param>
		public static void ZC_GUARD(ICombatEntity entity, bool active, Direction dir)
		{
			var packet = new Packet(Op.ZC_GUARD);

			packet.PutInt(entity.Handle);
			packet.PutByte(active);
			packet.PutDirection(dir);

			entity.Map.Broadcast(packet, entity);
		}

		/// <summary>
		/// Notifies clients around the character about the action taken.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="type"></param>
		/// <param name="argStr"></param>
		public static void ZC_CLIENT_DIRECT(Character character, int type, string argStr)
		{
			var packet = new Packet(Op.ZC_CLIENT_DIRECT);

			packet.PutInt(character.Handle);
			packet.PutInt(type);
			packet.PutString(argStr, 16);

			character.Map.Broadcast(packet, character);
		}

		/// <summary>
		/// Notifies nearby clients that an entity was knocked down/back.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="target"></param>
		/// <param name="knockBackInfo"></param>
		public static void ZC_KNOCKDOWN_INFO(ICombatEntity entity, ICombatEntity target, KnockBackInfo knockBackInfo)
		{
			var packet = new Packet(Op.ZC_KNOCKDOWN_INFO);

			packet.PutInt(target.Handle);
			packet.AddKnockbackInfo(knockBackInfo);
			packet.PutByte(0);

			entity.Map.Broadcast(packet, entity);
		}
	}
}
