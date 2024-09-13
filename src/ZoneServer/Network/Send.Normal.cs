using System;
using Melia.Shared.Game.Const;
using Melia.Shared.Network;
using Melia.Shared.Network.Helpers;
using Melia.Shared.World;
using Melia.Zone.Network.Helpers;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Characters.Components;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Actors.Pads;

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
			/// Attaches effect to actor on clients in range.
			/// </summary>
			/// <param name="actor"></param>
			/// <param name="effectName"></param>
			/// <param name="scale"></param>
			public static void AttachEffect(IActor actor, string effectName, float scale = 1)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.AttachEffect);

				packet.PutInt(actor.Handle);
				packet.AddStringId(effectName);
				packet.PutFloat(scale);
				packet.PutInt(3);
				packet.PutFloat(0);
				packet.PutFloat(0);
				packet.PutFloat(0);
				packet.PutFloat(0);

				actor.Map.Broadcast(packet, actor);
			}

			/// <summary>
			/// Attaches effect to actor on client.
			/// </summary>
			/// <param name="conn"></param>
			/// <param name="actor"></param>
			/// <param name="effectName"></param>
			/// <param name="scale"></param>
			public static void AttachEffect(IZoneConnection conn, IActor actor, string effectName, float scale = 1)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.AttachEffect);

				packet.PutInt(actor.Handle);
				packet.AddStringId(effectName);
				packet.PutFloat(scale);
				packet.PutInt(3);
				packet.PutFloat(0);
				packet.PutFloat(0);
				packet.PutFloat(0);
				packet.PutFloat(0);

				conn.Send(packet);
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
			/// <param name="effectName"></param>
			/// <param name="scale"></param>
			public static void PlayEffect(IActor actor, string effectName, float scale = 1, EffectLocation location = EffectLocation.Bottom)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.PlayEffect);

				packet.PutInt(actor.Handle);
				packet.PutByte(1);
				packet.PutInt((int)location);
				packet.PutByte(0);
				packet.PutFloat(scale);
				packet.AddStringId(effectName);
				packet.PutInt(0);

				actor.Map.Broadcast(packet, actor);
			}

			/// <summary>
			/// Plays text effect on actor.
			/// </summary>
			/// <remarks>
			/// The text effect is a small floating text that appears above the
			/// given actor. The actual string displayed is dictated by the
			/// Lua function given as the "funcName" argument, which is
			/// looked up in the packet string database, to send a reference
			/// to that name in form of an integer. This means that you can
			/// only use functions found inside that database by default.
			/// The known functions used for this can also be found in the
			/// script file "script_client.ipf\reaction\spcitem_text.lua".
			/// 
			/// The num and str arguments are then passed to the Lua function,
			/// and using this data, it returns a string that the client will
			/// then use for the floating text effect.
			/// 
			/// The look of the effect meanwhile is determined by the idSpace
			/// and classId. Consider the idSpace a kind of category that
			/// affects what the text looks like. For example, "Ability" will
			/// produce a red text, while "Collection" will be green.
			/// 
			/// Known idSpaces:
			/// - None: Orange text floating up
			/// - Ability: Red text floating up
			/// - Collection: Green text floating up
			/// - Skill: Yellow text, emphasized in place
			/// - Item: Yellow text floating up
			/// - Card (Item+CardItemId): White text floating up + sound effect
			/// 
			/// The only known idSpace value that makes use of the classId is
			/// "Item", which displays a different effect if the classId is
			/// that of a card item.
			/// 
			/// For custom texts, we added a fake packet string called
			/// "SHOW_CUSTOM_TEXT", which you can use to send custom
			/// strings via the argStr argument. Unfortunately, the
			/// client does not appear to support style formatting
			/// for these effects.
			/// </remarks>
			/// <example>
			/// PlayTextEffect(actor, caster, "SHOW_DMG_BLOCK");
			/// PlayTextEffect(actor, caster, "SHOW_BUFF_TEXT", (float)BuffId.Link, null, "Skill");
			/// PlayTextEffect(actor, caster, "SHOW_CUSTOM_TEXT", 0, "Hello, world!");
			/// </example>
			/// <param name="actor"></param>
			/// <param name="caster"></param>
			/// <param name="funcName"></param>
			/// <param name="argNum"></param>
			/// <param name="argStr"></param>
			/// <param name="idSpace"></param>
			/// <param name="classId"></param>
			public static void PlayTextEffect(IActor actor, IActor caster, string funcName, float argNum = 0, string argStr = null, string idSpace = "None", int classId = 0)
			{
				// Replace SHOW_CUSTOM_TEXT with SHOW_BUFF_TEXT, to use that function,
				// which we hijack
				if (funcName == "SHOW_CUSTOM_TEXT")
				{
					funcName = "SHOW_BUFF_TEXT";
					argStr = "CUSTOM:" + argStr;
				}

				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.PlayTextEffect);

				packet.PutInt(actor.Handle);
				packet.PutInt(caster.Handle);
				packet.AddStringId(funcName);
				packet.PutFloat(argNum);

				if (argStr == null)
					packet.PutShort(-1);
				else
					packet.PutLpString(argStr);

				packet.AddStringId(idSpace);
				packet.PutInt(classId);

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
			/// <param name="f1"></param>
			/// <param name="f2"></param>
			/// <param name="f3"></param>
			/// <param name="f4"></param>
			public static void SkillProjectile(ICombatEntity entity, string packetString1, float scale1, string packetString2, float scale2, Position position, float f1, float f2, float f3, float f4)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.SkillProjectile);

				packet.PutInt(entity.Handle);
				packet.AddStringId(packetString1);
				packet.PutFloat(scale1);
				packet.AddStringId(packetString2);
				packet.PutFloat(scale2);
				packet.PutPosition(position);
				packet.PutFloat(f1);
				packet.PutFloat(f2);
				packet.PutFloat(f3);
				packet.PutFloat(f4);
				packet.PutFloat(1);
				packet.PutLong(0);
				packet.PutLpString("None");

				entity.Map.Broadcast(packet, entity);
			}

			/// <summary>
			/// Plays an animation of a character throwing one of their items
			/// </summary>
			/// <param name="character"></param>
			/// <param name="str"></param>
			/// <param name="str2"></param>
			/// <param name="position"></param>
			/// <param name="effectName"></param>
			/// <param name="scale"></param>
			/// <param name="tossScale"></param>
			/// <param name="hangScale"></param>
			/// <param name="speed"></param>
			/// <param name="startAngle"></param>
			/// <param name="endAngle"></param>
			/// <param name="f7"></param>
			/// <param name="itemScale"></param>
			/// <param name="itemStayTime"></param>
			public static void SkillItemToss(IActor character, string str, string str2, Position position, string effectName, float scale, float tossScale, float hangScale, float speed, float startAngle, float endAngle, float f7, float itemScale, TimeSpan itemStayTime)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.SkillItemToss);

				packet.PutInt(character.Handle);
				packet.PutLpString(str);
				packet.PutLpString(str2);
				packet.PutPosition(position);
				packet.AddStringId(effectName);
				packet.PutFloat(scale);
				packet.PutFloat(tossScale);
				packet.PutFloat(hangScale);
				packet.PutFloat(speed);
				packet.PutFloat(startAngle);
				packet.PutFloat(endAngle);
				packet.PutFloat(f7);
				packet.PutFloat(itemScale);
				packet.PutFloat(itemStayTime.Seconds);

				character.Map.Broadcast(packet, character);
			}

			/// <summary>
			/// Controls a skill's visual effects.
			/// </summary>
			/// <param name="forceId"></param>
			/// <param name="caster"></param>
			/// <param name="source"></param>
			/// <param name="target"></param>
			/// <param name="effect1"></param>
			/// <param name="effect1Scale"></param>
			/// <param name="effect2"></param>
			/// <param name="effect3"></param>
			/// <param name="effect3Scale"></param>
			/// <param name="effect4"></param>
			/// <param name="effect5"></param>
			/// <param name="speed"></param>
			/// <exception cref="ArgumentException">
			/// Thrown if any of the packet strings are not found.
			/// </exception>
			public static void PlayForceEffect(int forceId, IActor caster, IActor source, IActor target, string effect1, float effect1Scale, string effect2, string effect3, float effect3Scale, string effect4, string effect5, float speed)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.PlayForceEffect);

				packet.PutInt(forceId);

				packet.PutInt(caster.Handle);
				packet.PutInt(source.Handle);
				packet.PutInt(target.Handle);

				packet.AddStringId(effect1);
				packet.PutFloat(effect1Scale);
				packet.AddStringId(effect2);
				packet.AddStringId(effect3);
				packet.PutFloat(effect3Scale);
				packet.AddStringId(effect4);
				packet.AddStringId(effect5);

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
				=> UnkDynamicCastStart(character, character.Handle, skillId);

			/// <summary>
			/// Packet with unknown purpose that's sent during dynamic
			/// casting.
			/// </summary>
			/// <param name="character"></param>
			/// <param name="skillId"></param>
			/// <param name="targetHandle"></param>
			public static void UnkDynamicCastStart(Character character, int targetHandle, SkillId skillId)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.UnkDynamicCastStart);

				packet.PutInt(targetHandle);
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

			/// <Summary>
			/// Used to show complex visual effects related to skills, called Pads.
			/// </summary>
			/// <param name="caster"></param>
			/// <param name="pad"></param>
			/// <param name="padName"></param>
			/// <param name="f1"></param>
			/// <param name="f2"></param>
			/// <param name="f3"></param>
			/// <param name="isVisible"></param>
			public static void PadUpdate(ICombatEntity caster, Pad pad, string padName, float f1, float f2, float f3, bool isVisible)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.PadUpdate);

				packet.PutInt(caster.Handle);
				packet.AddStringId(padName);
				packet.PutInt((int)pad.Skill.Id);
				packet.PutInt(pad.Skill.Level);
				packet.PutPosition(pad.Position);
				packet.PutDirection(pad.Direction);
				packet.PutFloat(f1);
				packet.PutFloat(f2);
				packet.PutInt(pad.Handle);
				packet.PutInt(isVisible ? 1 : 0); // Possibly a bool with a 3 byte gap
				packet.PutEmptyBin(13);
				packet.PutFloat(f3);
				packet.PutEmptyBin(16);

				caster.Map.Broadcast(packet, caster);
			}

			/// <summary>
			/// Sets the altitude of an actor associated with a pad.
			/// </summary>
			/// <remarks>
			/// Used in skills like Shield Lob to make the shield hover in the air.
			/// </remarks>
			/// <param name="pad"></param>
			/// <param name="actor"></param>
			/// <param name="altitude"></param>
			public static void PadSetMonsterAltitude(Pad pad, IActor actor, float altitude)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.PadSetMonsterAltitude);

				packet.PutInt(pad.Handle);
				packet.PutInt(actor.Handle);
				packet.PutFloat(altitude);
				packet.PutByte(1);

				pad.Map.Broadcast(packet);
			}

			/// <summary>
			/// Moves pad to the position on clients around it.
			/// </summary>
			/// <param name="caster"></param>
			/// <param name="pad"></param>
			/// <param name="dest"></param>
			/// <param name="movementSpeed"></param>
			public static void PadMoveTo(Pad pad, Position dest, float movementSpeed)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.PadMoveTo);

				packet.PutInt(pad.Handle);
				packet.PutPosition(dest);
				packet.PutByte(1);
				packet.PutFloat(movementSpeed);
				packet.PutFloat(1);

				pad.Map.Broadcast(packet, pad);
			}

			/// <summary>
			/// Rotates an actor on the given axes.
			/// </summary>
			/// <remarks>
			/// One usage example is Shield Lob where this is used to rotate the
			/// shield onto its side.
			/// </remarks>
			/// <param name="actor"></param>
			/// <param name="angleX"></param>
			/// <param name="angleY"></param>
			/// <param name="angleZ"></param>
			public static void ActorRotate(IActor actor, float angleX, float angleY, float angleZ)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.ActorRotate);

				packet.PutInt(actor.Handle);
				packet.PutFloat(angleX);
				packet.PutFloat(angleY);
				packet.PutFloat(angleZ);

				actor.Map.Broadcast(packet);
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
			/// Cancels certain repeating skill animations, like Barbarian_GiantSwing
			/// and Cataphract_Rush
			/// </summary>
			/// <param name="actor"></param>
			/// <param name="skillId"></param>
			public static void SkillCancelCancel(IActor actor, SkillId skillId)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.SkillCancelCancel);

				packet.PutInt(actor.Handle);
				packet.PutInt((int)skillId);

				actor.Map.Broadcast(packet, actor);
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
			public static void HeadgearVisibilityUpdate(Character character) => HeadgearVisibilityUpdate(character, character);

			/// <summary>
			/// Updates which headgears are visible for the character on
			/// clients in range.
			/// </summary>
			/// <param name="character"></param>
			/// <param name="targetCharacter"></param>
			public static void HeadgearVisibilityUpdate(Character character, Character targetCharacter)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.HeadgearVisibilityUpdate);

				packet.PutInt(targetCharacter.Handle);
				packet.PutByte((targetCharacter.VisibleEquip & VisibleEquip.Headgear1) != 0);
				packet.PutByte((targetCharacter.VisibleEquip & VisibleEquip.Headgear2) != 0);
				packet.PutByte((targetCharacter.VisibleEquip & VisibleEquip.Headgear3) != 0);
				packet.PutByte((targetCharacter.VisibleEquip & VisibleEquip.Wig) != 0);

				character.Map.Broadcast(packet, character);
			}

			/// <summary>
			/// Sets the model for a pad to a certain item.
			/// </summary>
			/// <remarks>
			/// Used in skills like Throw Spear and Shield Lob.
			/// </remarks>
			/// <param name="actor"></param>
			/// <param name="str"></param>
			/// <param name="itemId"></param>
			public static void PadSetModel(IActor actor, string str, int itemId)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.PadSetModel);

				packet.PutInt(actor.Handle);
				packet.PutLpString(str);
				packet.PutInt(itemId);

				actor.Map.Broadcast(packet);
			}

			/// <summary>
			/// Updates weather wig equipment is visible for the character
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
			/// Updates weather sub weapons are visible for the character
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
			/// <param name="entity"></param>
			/// <param name="targetHandle"></param>
			/// <param name="originPos"></param>
			/// <param name="direction"></param>
			/// <param name="farPos"></param>
			public static void UpdateSkillEffect(ICombatEntity entity, int targetHandle, Position originPos, Direction direction, Position farPos)
					=> UpdateSkillEffect(entity, targetHandle, originPos, direction, farPos, 0);

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
			/// <param name="unknowInt"></param>
			public static void UpdateSkillEffect(ICombatEntity entity, int targetHandle, Position originPos, Direction direction, Position farPos, int unknowInt)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.UpdateSkillEffect);

				packet.PutInt(entity.Handle);
				packet.PutInt(unknowInt);
				packet.PutInt(0);
				packet.PutInt(targetHandle);
				packet.PutPosition(originPos);
				packet.PutDirection(direction);
				packet.PutPosition(farPos);

				entity.Map.Broadcast(packet, entity);
			}

			/// <summary>
			/// Makes actor spin on clients near it.
			/// </summary>
			/// <param name="actor"></param>
			/// <param name="spinDelay"></param>
			/// <param name="spinCount"></param>
			/// <param name="rotationsPerSecond"></param>
			/// <param name="velocityChangeTerm"></param>
			public static void SpinObject(IActor actor, float spinDelay, float spinCount, float rotationsPerSecond, float velocityChangeTerm)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.SpinObject);

				packet.PutInt(actor.Handle);
				packet.PutFloat(spinDelay);
				packet.PutFloat(spinCount);
				packet.PutFloat(rotationsPerSecond);
				packet.PutFloat(velocityChangeTerm);

				actor.Map.Broadcast(packet);
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
			/// Sets the character's greeting message.
			/// </summary>
			/// <param name="character"></param>
			public static void SetGreetingMessage(Character character)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.SetGreetingMessage);

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
			/// Sends account properties to character's client.
			/// </summary>
			/// <param name="character"></param>
			public static void AccountProperties(Character character)
			{
				var account = character.Connection.Account;
				var properties = account.Properties.GetAll();
				var propertySize = properties.GetByteCount();

				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.AccountProperties);

				packet.PutLong(account.Id);
				packet.PutShort(propertySize);
				packet.AddProperties(properties);

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
					packet.PutLong(job.SelectionDate.ToFileTime());
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
			/// Makes the entity jump to the target position.
			/// </summary>
			/// <param name="entity"></param>
			/// <param name="targetPos"></param>
			/// <param name="f1"></param>
			/// <param name="f2"></param>
			/// <param name="f3"></param>
			/// <param name="f4"></param>
			/// <param name="f5"></param>
			/// <param name="jumpHeight"></param>
			public static void LeapJump(ICombatEntity entity, Position targetPos, float f1, float f2, float f3, float f4, float f5, float jumpHeight)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.LeapJump);

				packet.PutInt(entity.Handle);
				packet.PutPosition(targetPos);
				packet.PutFloat(jumpHeight);
				packet.PutFloat(f1); // jump speed?
				packet.PutFloat(f2);
				packet.PutFloat(f3);
				packet.PutFloat(f4);
				packet.PutFloat(f5);

				entity.Map.Broadcast(packet, entity);
			}

			/// <summary>
			/// Purpose unknown. Added for testing purposes, but turned
			/// out to not be necessary.
			/// </summary>
			/// <param name="entity"></param>
			/// <param name="b1"></param>
			public static void Unk13E(ICombatEntity entity, bool b1)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.Unk13E);

				packet.PutInt(entity.Handle);
				packet.PutByte(b1);

				entity.Map.Broadcast(packet, entity);
			}

			/// <summary>
			/// Starts a time action, displaying a progress bar and
			/// potentially putting the character in an animation.
			/// </summary>
			/// <param name="entity"></param>
			/// <param name="timeAction"></param>
			public static void TimeActionStart(Character character, TimeAction timeAction)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.TimeActionStart);

				packet.PutInt(character.Handle);
				packet.PutLpString(timeAction.DisplayText);
				packet.PutLpString(timeAction.AnimationName);
				packet.PutFloat((float)timeAction.Duration.TotalSeconds);
				packet.PutByte(1);
				packet.PutLpString(timeAction.ButtonText);

				character.Connection.Send(packet);
			}

			/// <summary>
			/// Stops a time action, hiding the progress bar and reverting
			/// to the default animation.
			/// </summary>
			/// <param name="character"></param>
			public static void TimeActionEnd(Character character)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.TimeActionEnd);

				packet.PutInt(character.Handle);
				packet.PutByte(0);

				character.Connection.Send(packet);
			}


			/// <summary>
			/// Updated the player's collection list.
			/// </summary>
			/// <param name="character"></param>
			public static void ItemCollectionList(Character character)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.ItemCollectionList);

				packet.Zlib(true, zpacket =>
				{
					zpacket.PutLong(character.ObjectId);
					zpacket.PutInt(character.Collections.Count);

					foreach (var collection in character.Collections.GetList())
					{
						var registeredItems = collection.GetRegisteredItems();

						zpacket.PutShort(collection.Id);
						zpacket.PutInt(registeredItems.Count);

						foreach (var itemId in registeredItems)
						{
							zpacket.PutInt(itemId);
							zpacket.PutLong(itemId);
							zpacket.PutShort(0);
						}
					}
				});

				character.Connection.Send(packet);
			}

			/// <summary>
			/// Unlocks a collection for the player.
			/// </summary>
			/// <param name="character"></param>
			public static void UnlockCollection(Character character, int collectionId)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.UnlockCollection);

				packet.PutLong(character.ObjectId);
				packet.PutInt(collectionId);

				character.Connection.Send(packet);
			}


			/// <summary>
			/// Updates the collection for the player.
			/// </summary>
			/// <param name="character"></param>
			public static void UpdateCollection(Character character, int collectionId, int itemId)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.UpdateCollection);

				packet.PutLong(character.ObjectId);
				packet.PutInt(collectionId);
				packet.PutLong(itemId);

				character.Connection.Send(packet);
			}

			/// <summary>
			/// Updates the entity model color
			/// </summary>
			/// <param name="character"></param>
			/// <param name="red"></param>
			/// <param name="green"></param>
			/// <param name="blue"></param>
			/// <param name="alpha"></param>
			/// <param name="f1"></param>
			public static void UpdateModelColor(Character character, int red, int green, int blue, int alpha, float f1)
				=> UpdateModelColor(character, character.Handle, red, green, blue, alpha, f1);

			/// <summary>
			/// Updates the entity model color
			/// </summary>
			/// <param name="character"></param>
			/// <param name="targetHandle"></param>
			/// <param name="red"></param>
			/// <param name="green"></param>
			/// <param name="blue"></param>
			/// <param name="alpha"></param>
			/// <param name="f1"></param>
			public static void UpdateModelColor(Character character, int targetHandle, int red, int green, int blue, int alpha, float f1)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.UpdateModelColor);

				packet.PutInt(targetHandle);
				packet.PutByte((byte)red);
				packet.PutByte((byte)green);
				packet.PutByte((byte)blue);
				packet.PutByte((byte)alpha);				
				packet.PutByte(1);
				packet.PutFloat(f1);
				packet.PutByte(1);

				character.Map.Broadcast(packet);
			}

			/// <summary>
			/// Enable to use a skill while being out of body (Sadhu).
			/// </summary>
			/// <param name="character"></param>
			/// <param name="buffId"></param>
			/// <param name="skillId"></param>
			public static void EnableUseSkillWhileOutOfBody(Character character, BuffId buffId, int skillId)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.EnableUseSkillWhileOutOfBody);

				packet.PutInt(character.Handle);
				packet.PutLpString(buffId.ToString());
				packet.PutInt(skillId);
				packet.PutByte(1);

				character.Connection.Send(packet);
			}

			/// <summary>
			/// Set the buff that will be used while out of body (Sadhu).
			/// </summary>
			/// <param name="character"></param>
			/// <param name="buffId"></param>
			public static void EndOutOfBodyBuff(Character character, BuffId buffId)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.EndOutOfBodyBuff);

				packet.PutInt(character.Handle);
				packet.PutLpString(buffId.ToString());

				character.Connection.Send(packet);
			}

			/// <summary>
			/// Exact purpose unknown, used in some skills when there's no target.
			/// </summary>
			/// <param name="actor"></param>
			/// <param name="skillId"></param>
			/// <param name="direction"></param>
			/// <param name="skillHandle"></param>
			public static void Skill_42(IActor actor, SkillId skillId, Direction direction, int skillHandle)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.Skill_42);

				packet.PutInt(actor.Handle);
				packet.PutInt((int)skillId);
				packet.PutInt(actor.Handle);
				packet.PutDirection(direction);
				packet.PutInt(1);
				packet.PutFloat(600f);
				packet.PutFloat(1f);
				packet.PutInt(1);
				packet.PutInt(skillHandle);
				packet.PutFloat(1f);
				packet.PutInt(0);
				packet.PutInt(0);
				packet.PutFloat(512f);
				packet.PutFloat(55f);

				actor.Map.Broadcast(packet);
			}

			/// <summary>
			/// Exact purpose unknown, used in some skills when there's no target.
			/// </summary>
			/// <param name="actor"></param>
			public static void Skill_43(IActor actor)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.Skill_43);

				packet.PutInt(actor.Handle);

				actor.Map.Broadcast(packet);
			}

			/// <summary>
			/// Opens book for the player.
			/// </summary>
			/// <param name="character"></param>
			/// <param name="bookName"></param>
			public static void OpenBook(Character character, string bookName)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Zone.OpenBook);

				packet.PutInt(character.Handle);
				packet.PutLpString(bookName);

				character.Connection.Send(packet);
			}
		}
	}
}
