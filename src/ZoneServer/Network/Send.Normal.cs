using System;
using Melia.Shared.Data.Database;
using Melia.Shared.Network;
using Melia.Shared.Network.Helpers;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Skills;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Monsters;

namespace Melia.Zone.Network
{
	public static partial class Send
	{
		public static class ZC_NORMAL
		{
			/// <summary>
			/// Updates the number of purchased character slots.
			/// </summary>
			/// <param name="conn"></param>
			/// <param name="count"></param>
			public static void BarrackSlotCount(IZoneConnection conn, int count)
			{
				var packet = new Packet(Op.BC_NORMAL);
				packet.PutInt(NormalOp.Zone.BarrackSlotCount);
				packet.PutInt(count);

				conn.Send(packet);
			}

			/// <summary>
			/// Attaches effect to actor.
			/// </summary>
			/// <param name="actor"></param>
			public static void AttachEffect(IActor actor, string packetString, float scale = 1)
			{
				if (!ZoneServer.Instance.Data.PacketStringDb.TryFind(packetString, out var packetStringData))
					throw new ArgumentException($"Packet string '{packetString}' not found.");

				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.AttachEffect);

				packet.PutInt(actor.Handle);
				packet.PutInt(packetStringData.Id);
				packet.PutFloat(scale);
				packet.PutInt(3);
				packet.PutFloat(0);
				packet.PutFloat(0);
				packet.PutFloat(0);
				packet.PutFloat(0);

				actor.Map.Broadcast(packet, actor);
			}

			/// <summary>
			/// Removes all effects from actor.
			/// </summary>
			/// <param name="actor"></param>
			public static void ClearEffects(IActor actor)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.ClearEffects);
				packet.PutInt(actor.Handle);

				actor.Map.Broadcast(packet, actor);
			}

			/// <summary>
			/// Plays given effect on actor.
			/// </summary>
			/// <param name="actor"></param>
			/// <param name="packetString"></param>
			/// <param name="scale"></param>
			public static void PlayEffect(IActor actor, string packetString, float scale = 1)
			{
				if (!ZoneServer.Instance.Data.PacketStringDb.TryFind(packetString, out var packetStringData))
					throw new ArgumentException($"Packet string '{packetString}' not found.");

				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.PlayEffect);

				packet.PutInt(actor.Handle);
				packet.PutByte(1);
				packet.PutInt(2);
				packet.PutByte(0);
				packet.PutFloat(scale);
				packet.PutInt(packetStringData.Id);
				packet.PutInt(0);

				actor.Map.Broadcast(packet, actor);
			}

			/// <summary>
			/// Plays effect on actor.
			/// </summary>
			/// <param name="actor"></param>
			/// <param name="caster"></param>
			/// <param name="packetString"></param>
			/// <param name="argNum"></param>
			/// <param name="argStr"></param>
			public static void PlayTextEffect(IActor actor, IActor caster, string packetString, float argNum, string argStr)
			{
				if (!ZoneServer.Instance.Data.PacketStringDb.TryFind(packetString, out var packetStringData))
					throw new ArgumentException($"Packet string '{packetString}' not found.");

				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.PlayTextEffect);

				packet.PutInt(actor.Handle);
				packet.PutInt(caster.Handle);
				packet.PutInt(packetStringData.Id);
				packet.PutFloat(argNum);

				if (argStr == null)
					packet.PutShort(-1);
				else
					packet.PutLpString(argStr);

				packet.PutInt(0);
				packet.PutInt(0);

				actor.Map.Broadcast(packet, actor);
			}

			/// <summary>
			/// Plays an animation of an effect getting thrown from the
			/// entity to the position, where a second effect is played
			/// for the impact.
			/// </summary>
			/// <param name="entity"></param>
			/// <param name="packetString1"></param>
			/// <param name="duration1"></param>
			/// <param name="packetString2"></param>
			/// <param name="duration2"></param>
			/// <param name="position"></param>
			public static void SkillProjectile(ICombatEntity entity, string packetString1, TimeSpan duration1, string packetString2, TimeSpan duration2, Position position)
			{
				if (!ZoneServer.Instance.Data.PacketStringDb.TryFind(packetString1, out var packetStringData1))
					throw new ArgumentException($"Packet string '{packetString1}' not found.");

				if (!ZoneServer.Instance.Data.PacketStringDb.TryFind(packetString2, out var packetStringData2))
					throw new ArgumentException($"Packet string '{packetString2}' not found.");

				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.SkillProjectile);

				packet.PutInt(entity.Handle);
				packet.PutInt(packetStringData1.Id);
				packet.PutFloat((float)duration1.TotalSeconds);
				packet.PutInt(packetStringData2.Id);
				packet.PutFloat((float)duration1.TotalSeconds);
				packet.PutPosition(position);
				packet.PutFloat(30);
				packet.PutFloat(0.2f);
				packet.PutFloat(0);
				packet.PutFloat(0);
				packet.PutFloat(1);
				packet.PutLong(0);
				packet.PutLpString("None");

				entity.Map.Broadcast(packet, entity);
			}

			/// <summary>
			/// Controls a skill's visual effects.
			/// </summary>
			/// <param name="forceId"></param>
			/// <param name="caster"></param>
			/// <param name="source"></param>
			/// <param name="target"></param>
			/// <param name="effect1PacketString"></param>
			/// <param name="effect1Scale"></param>
			/// <param name="effect2PacketString"></param>
			/// <param name="effect3PacketString"></param>
			/// <param name="effect3Scale"></param>
			/// <param name="effect4PacketString"></param>
			/// <param name="effect5PacketString"></param>
			/// <param name="speed"></param>
			/// <exception cref="ArgumentException">
			/// Thrown if any of the packet strings are not found.
			/// </exception>
			public static void PlayForceEffect(int forceId, IActor caster, IActor source, IActor target, string effect1PacketString, float effect1Scale, string effect2PacketString, string effect3PacketString, float effect3Scale, string effect4PacketString, string effect5PacketString, float speed)
			{
				if (!ZoneServer.Instance.Data.PacketStringDb.TryFind(effect1PacketString, out var packetStringData1))
					throw new ArgumentException($"Packet string '{effect1PacketString}' not found.");

				if (!ZoneServer.Instance.Data.PacketStringDb.TryFind(effect2PacketString, out var packetStringData2))
					throw new ArgumentException($"Packet string '{effect2PacketString}' not found.");

				if (!ZoneServer.Instance.Data.PacketStringDb.TryFind(effect3PacketString, out var packetStringData3))
					throw new ArgumentException($"Packet string '{effect3PacketString}' not found.");

				if (!ZoneServer.Instance.Data.PacketStringDb.TryFind(effect4PacketString, out var packetStringData4))
					throw new ArgumentException($"Packet string '{effect4PacketString}' not found.");

				if (!ZoneServer.Instance.Data.PacketStringDb.TryFind(effect5PacketString, out var packetStringData5))
					throw new ArgumentException($"Packet string '{effect5PacketString}' not found.");

				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.PlayForceEffect);

				packet.PutInt(forceId);

				packet.PutInt(caster.Handle);
				packet.PutInt(source.Handle);
				packet.PutInt(target.Handle);

				packet.PutInt(packetStringData1.Id);
				packet.PutFloat(effect1Scale);
				packet.PutInt(packetStringData2.Id);
				packet.PutInt(packetStringData3.Id);
				packet.PutFloat(effect3Scale);
				packet.PutInt(packetStringData4.Id);
				packet.PutInt(packetStringData5.Id);

				packet.PutFloat(speed);
				packet.PutFloat(0);
				packet.PutFloat(0);
				packet.PutFloat(0);
				packet.PutInt(0);
				packet.PutFloat(5);
				packet.PutFloat(5);
				packet.PutFloat(2);
				packet.PutInt(0);

				source.Map.Broadcast(packet, target);
			}

			/// <summary>
			/// Attack broadcast?
			/// </summary>
			/// <param name="character"></param>
			public static void AttackCancel(Character character)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.AttackCancel);
				packet.PutInt(character.Handle);

				character.Map.Broadcast(packet);
			}

			/// <summary>
			/// Packet with unknown purpose that's sent during dynamic
			/// casting.
			/// </summary>
			/// <param name="character"></param>
			/// <param name="skillId"></param>
			public static void UnkDynamicCastStart(Character character, SkillId skillId)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.UnkDynamicCastStart);

				packet.PutInt(character.Handle);
				packet.PutInt((int)skillId);

				character.Connection.Send(packet);
			}

			/// <summary>
			/// Packet with unknown purpose that's sent during dynamic
			/// casting.
			/// </summary>
			/// <param name="character"></param>
			/// <param name="skillId"></param>
			/// <param name="value"></param>
			public static void UnkDynamicCastEnd(Character character, SkillId skillId, float value)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.UnkDynamicCastEnd);

				packet.PutInt(character.Handle);
				packet.PutInt((int)skillId);
				packet.PutFloat(value);
				packet.PutByte(0);

				character.Connection.Send(packet);
			}

			/// <summary>
			/// Unknown skill related
			/// </summary>
			/// <param name="entity"></param>
			/// <param name="skillActorId"></param>
			public static void SkillParticleEffect(ICombatEntity entity, int skillActorId)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.SkillParticleEffect);

				packet.PutInt(entity.Handle);
				packet.PutInt(skillActorId);
				packet.PutInt(entity.Hp);
				packet.PutShort(6904);
				packet.PutShort(39);
				packet.PutFloat(25);
				packet.PutLpString("Melee");
				packet.PutLong(0);

				entity.Map.Broadcast(packet, entity);
			}

			/// <summary>
			/// Adjusts the skill speed for a skill.
			/// </summary>
			/// <param name="character"></param>
			/// <param name="skillId"></param>
			/// <param name="value"></param>
			public static void SetSkillSpeed(Character character, int skillId, float value)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.SetSkillSpeed);

				packet.PutInt(skillId);
				packet.PutFloat(value);

				character.Connection.Send(packet);
			}

			/// <summary>
			/// Adjusts the hit delay for a skill.
			/// </summary>
			/// <param name="character"></param>
			/// <param name="skillId"></param>
			public static void SetHitDelay(Character character, int skillId, float value)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.SetHitDelay);

				packet.PutInt(skillId);
				packet.PutFloat(value);

				character.Connection.Send(packet);
			}

			/// <summary>
			/// Sends the session key to the client.
			/// </summary>
			/// <param name="conn"></param>
			public static void AdventureBook(IZoneConnection conn)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.AdventureBook);

				packet.PutLpString("AdventureBook");
				packet.PutLpString("Initialization_point");

				// [i354444] Added
				{
					packet.PutInt(-1);
					packet.PutInt(0);
					packet.PutInt(0);
					packet.PutByte(1);
				}

				conn.Send(packet);
			}

			/// <summary>
			/// Sends the session key to the client.
			/// </summary>
			/// <param name="conn"></param>
			public static void SetSessionKey(IZoneConnection conn)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.SetSessionKey);
				packet.PutLpString(conn.SessionKey);

				conn.Send(packet);
			}

			/// <summary>
			/// Updates which headgears are visible for the character on
			/// clients in range.
			/// </summary>
			/// <param name="character"></param>
			public static void HeadgearVisibilityUpdate(Character character)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.HeadgearVisibilityUpdate);

				packet.PutInt(character.Handle);
				packet.PutByte((character.VisibleEquip & VisibleEquip.Headgear1) != 0);
				packet.PutByte((character.VisibleEquip & VisibleEquip.Headgear2) != 0);
				packet.PutByte((character.VisibleEquip & VisibleEquip.Headgear3) != 0);
				packet.PutByte((character.VisibleEquip & VisibleEquip.Wig) != 0);

				character.Map.Broadcast(packet, character);
			}

			/// <summary>
			/// Updates weather wig eequipment is visible for the character
			/// on clients in range.
			/// </summary>
			/// <param name="character"></param>
			public static void WigVisibilityUpdate(Character character)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.WigVisibilityUpdate);

				packet.PutInt(character.Handle);
				packet.PutByte((character.VisibleEquip & VisibleEquip.Wig) != 0);

				character.Map.Broadcast(packet, character);
			}

			/// <summary>
			/// Updates weather wig eequipment is visible for the character
			/// on clients in range.
			/// </summary>
			/// <param name="character"></param>
			public static void SubWeaponVisibilityUpdate(Character character)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.SubWeaponVisibilityUpdate);

				packet.PutInt(character.Handle);
				packet.PutByte((character.VisibleEquip & VisibleEquip.SubWeapon) != 0);

				character.Map.Broadcast(packet, character);
			}

			/// <summary>
			/// Creates a particle effect (or set desired animation)
			/// </summary>
			/// <param name="character"></param>
			/// <param name="actorId"></param>
			/// <param name="enable"></param>
			public static void ParticleEffect(Character character, int actorId, int enable)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.ParticleEffect);
				packet.PutInt(actorId);
				packet.PutInt(enable);

				character.Map.Broadcast(packet);
			}

			/// <summary>
			/// Appears to update information about a skill effect on the
			/// clients in range of entity.
			/// </summary>
			/// <remarks>
			/// Observed updating the origin position of the Earthquake
			/// effect. Once the packet was sent once, the dust cloud
			/// effect would always appear at the same location, even
			/// when the packet was no longer sent. Only if it was
			/// sent did the location update and the effect appeared
			/// in the right place.
			/// </remarks>
			/// <param name="entity"></param>
			/// <param name="targetHandle"></param>
			/// <param name="originPos"></param>
			/// <param name="direction"></param>
			/// <param name="farPos"></param>
			public static void UpdateSkillEffect(ICombatEntity entity, int targetHandle, Position originPos, Direction direction, Position farPos)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.UpdateSkillEffect);

				packet.PutInt(entity.Handle);
				packet.PutInt(0);
				packet.PutInt(0);
				packet.PutInt(targetHandle);
				packet.PutPosition(originPos);
				packet.PutDirection(direction);
				packet.PutPosition(farPos);

				entity.Map.Broadcast(packet, entity);
			}

			/// <summary>
			/// Purpose currently unknown.
			/// </summary>
			/// <param name="character"></param>
			/// <param name="i1"></param>
			public static void Skill_45(IActor source, int i1)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.Skill_45);
				packet.PutInt(i1);

				source.Map.Broadcast(packet, source);
			}

			/// <summary>
			/// Unknown purpose yet.
			/// </summary>
			/// <param name="character"></param>
			public static void Unknown_A1(Character character)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.Unknown_A1);
				packet.PutLong(4);

				character.Connection.Send(packet);
			}

			/// <summary>
			/// Sent during login for unknown purpose
			/// </summary>
			/// <param name="character"></param>
			public static void Unknown_DA(Character character)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.Unknown_DA);
				packet.Zlib(true, zpacket =>
				{
					zpacket.PutLong(character.ObjectId);
					zpacket.PutInt(0);
				});

				character.Connection.Send(packet);
			}

			/// <summary>
			/// Sent during login for unknown purpose
			/// </summary>
			/// <param name="character"></param>
			public static void Unknown_E4(Character character)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.Unknown_E4);
				packet.PutInt(0);

				character.Connection.Send(packet);
			}

			/// <summary>
			/// Sends account properties.
			/// </summary>
			/// <param name="character"></param>
			public static void SetGreetingMessage(Character character)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.AccountUpdate);
				packet.PutLong(character.ObjectId);
				packet.PutInt(0);
				packet.PutLpString(character.GreetingMessage);

				character.Connection.Send(packet);
			}

			/// <summary>
			/// Unknown purpose yet.
			/// </summary>
			/// <param name="character"></param>
			public static void Unknown_1B4(Character character)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.Unknown_1B4);
				packet.PutInt(0);

				character.Connection.Send(packet);
			}

			/// <summary>
			/// Sends account properties.
			/// </summary>
			/// <param name="character"></param>
			public static void AccountUpdate(Character character)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.AccountUpdate);
				packet.PutLong(character.AccountId);
				packet.AddAccountProperties(character.Connection.Account);

				character.Connection.Send(packet);
			}

			/// <summary>
			/// Makes monster fade out over the given amount of time.
			/// </summary>
			/// <param name="monster"></param>
			/// <param name="duration"></param>
			public static void FadeOut(IMonster monster, TimeSpan duration)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.FadeOut);

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
			public static void ItemDrop(IMonster monster, Direction direction, float distance)
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
				packet.PutInt(NormalOp.Zone.ItemDrop);

				packet.PutInt(monster.Handle);
				packet.PutInt((int)direction.NormalDegreeAngle);
				packet.PutFloat(distance);

				monster.Map.Broadcast(packet, monster, false);
			}

			/// <summary>
			/// Unknown purpose yet.
			/// </summary>
			/// <param name="character"></param>
			public static void Unknown_EF(Character character)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.Unknown_EF);

				packet.PutLong(character.ObjectId);
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
			public static void Unknown_19B(Character character)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.Unknown_19B);
				packet.PutLong(1);
				packet.PutByte(0);
			}

			/// <summary>
			/// Unknown purpose yet.
			/// </summary>
			/// <param name="character"></param>
			public static void ChannelTraffic(Character character)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.ChannelTraffic);

				packet.Zlib(true, zpacket =>
				{
					var availableZoneServers = ZoneServer.Instance.ServerList.GetZoneServers(character.MapId);

					zpacket.PutShort(character.MapId);
					zpacket.PutShort(availableZoneServers.Length);

					for (var channelId = 0; channelId < availableZoneServers.Length; ++channelId)
					{
						var zoneServerInfo = availableZoneServers[channelId];

						// The client uses the "channelId" as part of the
						// channel name. For example, id 0 becomes "Ch 1",
						// id 1 becomes "Ch 2", etc. Because of this we
						// can't just send anything here, it needs to be
						// a sequential number starting from 0 to match
						// official behavior.

						zpacket.PutShort(channelId);
						zpacket.PutShort(zoneServerInfo.CurrentPlayers);
						zpacket.PutShort(zoneServerInfo.MaxPlayers);
					}
				});
			}

			/// <summary>
			/// Updates the skill UI with character job data.
			/// </summary>
			/// <param name="character"></param>
			public static void UpdateSkillUI(Character character)
			{
				// While the client will apparently gladly accept any combination
				// of jobs, the skill UI will only appear correctly if job
				// data for the character's current "display job" is sent.
				// For example, if the display job is Archer, data for *that*
				// job must be sent. Other base classes or higher jobs in the
				// same class do not work. Same thing for when the display
				// job is a higher job.
				// If data for the base job is sent though, other jobs will
				// appears as well. So it seems like you can create a Wizard/
				// Archer hybrid for example.

				var jobs = character.Jobs.GetList();

				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.UpdateSkillUI);
				packet.PutLong(character.ObjectId);

				packet.PutInt(jobs.Length);
				foreach (var job in jobs)
				{
					packet.PutShort((short)job.Id);
					packet.PutShort((short)job.Level);
					packet.PutInt(0);
					packet.PutLong(job.TotalExp);
					packet.PutByte((byte)job.SkillPoints);
					packet.PutShort(41857);
					packet.PutEmptyBin(5);
					packet.PutLong(132735996030000000);
					packet.PutLong(0);
				}

				character.Connection.Send(packet);
			}

			/// <summary>
			/// Changes character behavior for a curscene.
			/// </summary>
			/// <param name="character"></param>
			/// <param name="active">Whether the cutscene is active.</param>
			/// <param name="movable">Whether the client can still move the character. If not, the server can control it.</param>
			/// <param name="hideUi">Whether to hide the UI while active.</param>
			public static void Cutscene(Character character, bool active, bool movable, bool hideUi)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.Cutscene);

				packet.PutByte(active);
				packet.PutByte(movable);
				packet.PutByte(hideUi);

				character.Connection.Send(packet);
			}

			/// <summary>
			/// Purpose unknown, related to skills.
			/// </summary>
			/// <param name="character"></param>
			/// <param name="casterHandle"></param>
			/// <param name="packetString"></param>
			/// <param name="skillId"></param>
			/// <param name="targetPos"></param>
			/// <param name="targetDir"></param>
			/// <exception cref="ArgumentException"></exception>
			public static void Skill_59(Character character, int casterHandle, string packetString, SkillId skillId, Position targetPos, Direction targetDir)
			{
				if (!ZoneServer.Instance.Data.PacketStringDb.TryFind(packetString, out var packetStringData))
					throw new ArgumentException($"Unknown packet string '{packetString}'.");

				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.Skill_59);

				packet.PutInt(casterHandle);
				packet.PutInt(packetStringData.Id);
				packet.PutInt((int)skillId);
				packet.PutInt(1);
				packet.PutPosition(targetPos);
				packet.PutDirection(targetDir);
				packet.PutFloat(-0.78f);
				packet.PutFloat(0);
				packet.PutInt(0);
				packet.PutInt(1);
				packet.PutEmptyBin(13);
				packet.PutFloat(150);
				packet.PutEmptyBin(16);

				character.Connection.Send(packet);
			}

			/// <summary>
			/// Makes the entity jump to the target position.
			/// </summary>
			/// <param name="entity"></param>
			/// <param name="targetPos"></param>
			/// <param name="jumpHeight"></param>
			public static void LeapJump(ICombatEntity entity, Position targetPos, float jumpHeight = 20)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.LeapJump);

				packet.PutInt(entity.Handle);
				packet.PutPosition(targetPos);
				packet.PutFloat(jumpHeight);
				packet.PutFloat(0.1f); // jump speed?
				packet.PutFloat(0.1f);
				packet.PutFloat(1);
				packet.PutFloat(0.2f);
				packet.PutFloat(1);

				entity.Map.Broadcast(packet, entity);
			}
		}
	}
}
