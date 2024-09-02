﻿using System;
using System.Collections.Generic;
using Melia.Shared.Game.Const;
using Melia.Shared.ObjectProperties;
using Melia.Shared.World;
using Melia.Zone.Buffs;
using Melia.Zone.Network;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Characters.Components;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.World.Actors.Components;
using Melia.Zone.World.Actors.Monsters;
using Yggdrasil.Composition;
using Yggdrasil.Util;

namespace Melia.Zone.World.Actors
{
	/// <summary>
	/// Describes an entity that can actively participate in combat.
	/// </summary>
	public interface ICombatEntity : IActor, IPropertyHolder
	{
		/// <summary>
		/// Returns the entity's faction.
		/// </summary>
		FactionType Faction { get; }

		/// <summary>
		/// Returns the entity's race.
		/// </summary>
		RaceType Race { get; }

		/// <summary>
		/// Returns the entity's element/attribute.
		/// </summary>
		AttributeType Attribute { get; }

		/// <summary>
		/// Returns the entity's armor material.
		/// </summary>
		ArmorMaterialType ArmorMaterial => (ArmorMaterialType)(int)this.Properties.GetFloat(PropertyName.ArmorMaterial, (int)ArmorMaterialType.None);

		/// <summary>
		/// Returns the entity's mode of movement.
		/// </summary>
		MoveType MoveType { get; }

		/// <summary>
		/// Returns the entity's effective size.
		/// </summary>
		/// <remarks>
		/// The effective size is not necessarily the same as the entity's set
		/// size, as some are classified as a certain size for some purposes,
		/// but another size for others. For example, players have their own
		/// "size" property called "PC", but for bonus purposes they are
		/// considered "M" size.
		/// </remarks>
		SizeType EffectiveSize => (this is Mob mob ? mob.Data.Size : SizeType.M);

		/// <summary>
		/// Returns the entity's monster rank. Returns Normal if entity is
		/// not a mob.
		/// </summary>
		MonsterRank Rank => (this is Mob mob ? mob.Data.Rank : MonsterRank.Normal);

		/// <summary>
		/// Returns the entity's radius for pathfinding purposes.
		/// </summary>
		/// <remarks>
		/// Based on shape.ies.
		/// </remarks>
		float AgentRadius => this.EffectiveSize switch
		{
			SizeType.S => 12,
			SizeType.M => 15,
			SizeType.L => 20,
			SizeType.XL => 40,
			SizeType.XXL => 40,
			_ => 0,
		};

		/// <summary>
		/// Returns the entity's level.
		/// </summary>
		int Level { get; }

		/// <summary>
		/// Returns the entity's current HP.
		/// </summary>
		int Hp { get; }

		/// <summary>
		/// Holds the order of successive changes in entity's HP.
		/// A higher value indicates the latest HP amount.
		/// </summary>
		int HpChangeCounter { get; }

		/// <summary>
		/// Returns true if the entity is dead.
		/// </summary>
		bool IsDead { get; }

		/// <summary>
		/// Returns the entity's component collection.
		/// </summary>
		ComponentCollection Components { get; }

		/// <summary>
		/// Makes entity take damage and kills it if its HP reach 0.
		/// Returns whether the entity is dead.
		/// </summary>
		/// <param name="damage"></param>
		/// <param name="attacker"></param>
		/// <returns>Returns true if the entity died from the attack.</returns>
		bool TakeDamage(float damage, ICombatEntity attacker/*, DamageVisibilityModifier damageVisibility, int attackIndex*/);

		/// <summary>
		/// Returns true if this entity is able to attack others.
		/// </summary>
		/// <returns></returns>
		bool CanFight();

		/// <summary>
		/// Returns true if this entity can attack the given one.
		/// </summary>
		/// <param name="entity"></param>
		/// <returns></returns>
		bool CanAttack(ICombatEntity entity);

		/// <summary>
		/// Heals the entity's HP and SP by the given amounts.
		/// </summary>
		/// <param name="hpAmount"></param>
		/// <param name="spAmount"></param>
		void Heal(float hpAmount, float spAmount);
	}

	/// <summary>
	/// Extensions for working with combat entities.
	/// </summary>
	public static class ICombatEntityExtensions
	{
		// TODO: Should we create a "CombatEntity" parent class for Mobs
		//   and Characters? Probably. Maybe? Not sure yet.

		/// <summary>
		/// Returns true if the other entity is part of a hostile faction.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="otherEntity"></param>
		/// <returns></returns>
		public static bool IsHostileFaction(this ICombatEntity entity, ICombatEntity otherEntity)
		{
			var isHostileFaction = ZoneServer.Instance.Data.FactionDb.CheckHostility(entity.Faction, otherEntity.Faction);
			return isHostileFaction;
		}

		/// <summary>
		/// Makes the entity turn towards the actor if it's not null.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="actor"></param>
		public static void TurnTowards(this ICombatEntity entity, IActor actor)
		{
			if (actor != null)
				TurnTowards(entity, actor.Position);
		}

		/// <summary>
		/// Makes the entity turn towards the position.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="pos"></param>
		public static void TurnTowards(this ICombatEntity entity, Position pos)
		{
			var dir = entity.Position.GetDirection(pos);
			TurnTowards(entity, dir);
		}

		/// <summary>
		/// Makes the entity turn towards the given direction
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="dir"></param>
		public static void TurnTowards(this ICombatEntity entity, Direction dir)
		{
			entity.Direction = dir;
			Send.ZC_ROTATE(entity);
		}

		/// <summary>
		/// Attempts to reduce the entity's SP by the amount necessary
		/// to use the skill. Returns false if it didn't have enough SP.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="skill"></param>
		/// <returns></returns>
		public static bool TrySpendSp(this ICombatEntity entity, Skill skill)
		{
			var spendSp = skill.Properties.GetFloat(PropertyName.SpendSP);
			return entity.TrySpendSp(spendSp);
		}

		/// <summary>
		/// Attempts to reduce the entity's SP by the given amount.
		/// Returns false if it didn't have enough SP.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="amount"></param>
		/// <returns></returns>
		public static bool TrySpendSp(this ICombatEntity entity, float amount)
		{
			if (entity is not Character character)
				return true;

			if (amount == 0)
				return true;

			var sp = entity.Properties.GetFloat(PropertyName.SP);
			if (sp < amount)
				return false;

			character.ModifySp(-amount);
			return true;
		}

		/// <summary>
		/// Displays server message for entity if it's able to receive
		/// server messages.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="format"></param>
		/// <param name="args"></param>
		public static void ServerMessage(this ICombatEntity entity, string format, params object[] args)
		{
			if (entity is Character character)
				character.ServerMessage(format, args);
		}

		/// <summary>
		/// Returns the direction from the actor to the other actor.
		/// </summary>
		/// <param name="actor"></param>
		/// <param name="otherActor"></param>
		/// <returns></returns>
		public static Direction GetDirection(this IActor actor, IActor otherActor)
			=> actor.Position.GetDirection(otherActor.Position);

		/// <summary>
		/// Returns the direction from the actor to the given position.
		/// </summary>
		/// <param name="actor"></param>
		/// <param name="pos"></param>
		/// <returns></returns>
		public static Direction GetDirection(this IActor actor, Position pos)
			=> actor.Position.GetDirection(pos);

		/// <summary>
		/// Sets the entity's attack state.
		/// </summary>
		/// <param name="inAttackState"></param>
		public static void SetAttackState(this ICombatEntity entity, bool inAttackState)
			=> entity.Components.Get<CombatComponent>()?.SetAttackState(inAttackState);

		/// <summary>
		/// Sets the entity's casting state.
		/// </summary>
		/// <param name="inCastingState"></param>
		public static void SetCastingState(this ICombatEntity entity, bool inCastingState)
			=> entity.Components.Get<CombatComponent>().CastingState = inCastingState;

		/// <summary>
		/// Gets the entity's casting state.
		/// </summary>
		public static bool IsCasting(this ICombatEntity entity)
			=> entity.Components.Get<CombatComponent>().CastingState;

		/// <summary>
		/// Starts the buff with the given id. If the buff is already active,
		/// it gets overbuffed. Returns the created or modified buff.
		/// </summary>
		/// <param name="buffId"></param>
		/// <returns></returns>
		public static Buff StartBuff(this ICombatEntity entity, BuffId buffId)
			=> entity.Components.Get<BuffComponent>()?.Start(buffId, 0, 0, Buff.DefaultDuration, entity, SkillId.None);

		/// <summary>
		/// Starts the buff with the given id. If the buff is already active,
		/// it gets overbuffed. Returns the created or modified buff.
		/// </summary>
		/// <param name="buffId"></param>
		/// <param name="duration"></param>
		/// <returns></returns>
		public static Buff StartBuff(this ICombatEntity entity, BuffId buffId, TimeSpan duration)
			=> entity.Components.Get<BuffComponent>()?.Start(buffId, 0, 0, duration, entity, SkillId.None);

		/// <summary>
		/// Starts the buff with the given id. If the buff is already active,
		/// it gets overbuffed. Returns the created or modified buff.
		/// </summary>
		/// <param name="buffId"></param>
		/// <param name="numArg1"></param>
		/// <param name="numArg2"></param>
		/// <param name="duration"></param>
		/// <param name="caster"></param>
		/// <param name="skillId"></param>
		/// <returns></returns>
		public static Buff StartBuff(this ICombatEntity entity, BuffId buffId, float numArg1, float numArg2, TimeSpan duration, ICombatEntity caster, SkillId skillId = SkillId.None)
			=> entity.Components.Get<BuffComponent>()?.Start(buffId, numArg1, numArg2, duration, caster, skillId);

		/// <summary>
		/// Stops the buff with the given id.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="buffId"></param>
		public static void StopBuff(this ICombatEntity entity, BuffId buffId)
			=> entity.Components.Get<BuffComponent>()?.Stop(buffId);

		/// <summary>
		/// Returns true if the buff with the given id is active.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="buffId"></param>
		/// <returns></returns>
		public static bool IsBuffActive(this ICombatEntity entity, BuffId buffId)
			=> entity.Components.Get<BuffComponent>()?.Has(buffId) ?? false;

		/// <summary>
		/// Returns the buff with the given id via out if it's active. Returns
		/// false if the buff is not active.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="buffId"></param>
		/// <param name="buff"></param>
		/// <returns></returns>
		public static bool TryGetBuff(this ICombatEntity entity, BuffId buffId, out Buff buff)
		{
			buff = null;
			return entity.Components.Get<BuffComponent>()?.TryGet(buffId, out buff) ?? false;
		}

		/// <summary>
		/// Returns the skill with the given ID if the entity knows that skill.
		/// Returns false if the entity doesn't know that skill.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="skillId"></param>
		/// <param name="skill"></param>
		/// <returns></returns>
		public static bool TryGetSkill(this ICombatEntity entity, SkillId skillId, out Skill skill)
		{
			skill = null;
			return entity.Components.Get<SkillComponent>()?.TryGet(skillId, out skill) ?? false;
		}

		/// <summary>
		/// Returns true if the entity has the given ability and it's toggled on.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="abilityId"></param>
		/// <returns></returns>
		public static bool IsAbilityActive(this ICombatEntity entity, AbilityId abilityId)
			=> entity.Components.Get<AbilityComponent>()?.IsActive(abilityId) ?? false;

		/// <summary>
		/// Returns the ability with the given id via out if the entity has it.
		/// Returns false if the entity doesn't have the ability.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="abilityId"></param>
		/// <param name="ability"></param>
		/// <returns></returns>
		public static bool TryGetAbility(this ICombatEntity entity, AbilityId abilityId, out Ability ability)
		{
			ability = null;
			return entity.Components.Get<AbilityComponent>()?.TryGet(abilityId, out ability) ?? false;
		}

		/// <summary>
		/// Returns true if the entity has the given ability and it's toggled on.
		/// Returns the ability's level via out if it's active.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="abilityId"></param>
		/// <param name="level"></param>
		/// <returns></returns>
		public static bool TryGetActiveAbilityLevel(this ICombatEntity entity, AbilityId abilityId, out int level)
		{
			level = 0;

			if (!entity.Components.TryGet<AbilityComponent>(out var abilities))
				return false;

			if (!abilities.TryGetActive(abilityId, out var ability))
				return false;

			level = ability.Level;
			return ability.Active;
		}

		/// <summary>
		/// Returns true if the distance between the caster and the target
		/// doesn't exceed the skill's max range.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="skill"></param>
		/// <param name="target"></param>
		/// <returns></returns>
		public static bool InSkillUseRange(this ICombatEntity caster, Skill skill, ICombatEntity target)
			=> InSkillUseRange(caster, skill, target.Position);

		/// <summary>
		/// Returns true if the distance between the caster and the position
		/// doesn't exceed the skill's max range.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="skill"></param>
		/// <param name="pos"></param>
		/// <returns></returns>
		public static bool InSkillUseRange(this ICombatEntity caster, Skill skill, Position pos)
		{
			var maxRange = skill.Properties.GetFloat(PropertyName.MaxR);

			// There are somewhat frequent situations where the client is
			// convinced it's in range, but the server disagrees. It's good
			// that we have these checks, but we also want the experience
			// to be smooth, so we'll allow a little extra range.
			maxRange *= 1.25f;

			return caster.Position.InRange2D(pos, maxRange);
		}

		/// <summary>
		/// Returns true if the entity has the skill at at least the given level.
		/// </summary>
		/// <remarks>
		/// Currently only works for characters, as monsters don't have a skill
		/// component yet. It will always return false for monsters.
		/// </remarks>
		/// <param name="entity"></param>
		/// <param name="skillId"></param>
		/// <param name="minLevel"></param>
		/// <returns></returns>
		public static bool HasSkill(this ICombatEntity entity, SkillId skillId, int minLevel = 1)
			=> entity.Components.Get<SkillComponent>()?.GetLevel(skillId) >= minLevel;

		/// <summary>
		/// Returns the entity from the collection that is closest to the
		/// given position.
		/// </summary>
		/// <param name="entities"></param>
		/// <param name="pos"></param>
		/// <returns></returns>
		public static ICombatEntity GetClosest(this IEnumerable<ICombatEntity> entities, Position pos)
		{
			var closest = (ICombatEntity)null;
			var closestDist = float.MaxValue;

			foreach (var entity in entities)
			{
				var dist = (float)entity.Position.Get2DDistance(pos);
				if (dist < closestDist)
				{
					closest = entity;
					closestDist = dist;
				}
			}

			return closest;
		}

		/// <summary>
		/// Returns the entity from the collection that is closest to the
		/// given position and matches the predicate.
		/// </summary>
		/// <param name="entities"></param>
		/// <param name="pos"></param>
		/// <param name="predicate"></param>
		/// <returns></returns>
		public static ICombatEntity GetClosest(this IEnumerable<ICombatEntity> entities, Position pos, Func<ICombatEntity, bool> predicate)
		{
			var closest = (ICombatEntity)null;
			var closestDist = float.MaxValue;

			foreach (var entity in entities)
			{
				if (!predicate(entity))
					continue;

				var dist = (float)entity.Position.Get2DDistance(pos);
				if (dist < closestDist)
				{
					closest = entity;
					closestDist = dist;
				}
			}

			return closest;
		}

		/// <summary>
		/// Applies a combat hit to the target, making it take damage.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="attacker"></param>
		/// <param name="skillId"></param>
		/// <param name="damage"></param>
		public static void TakeSimpleHit(this ICombatEntity entity, float damage, ICombatEntity attacker, SkillId skillId)
		{
			entity.TakeDamage(damage, attacker);

			var hit = new HitInfo(attacker, entity, skillId, damage, HitResultType.Hit);
			Send.ZC_HIT_INFO(attacker, entity, hit);
		}

		/// <summary>
		/// Removes a random buff from the entity with the given chance in percent.
		/// </summary>
		/// <remarks>
		/// If chance is 100 or above, a random buff will always be removed,
		/// assuming there is one to remove.
		/// </remarks>
		/// <param name="entity"></param>
		/// <param name="chance"></param>
		public static void RemoveRandomBuff(this ICombatEntity entity, float chance = 100)
		{
			var rnd = RandomProvider.Get();

			if (rnd.Next(100) < chance && entity.Components.TryGet<BuffComponent>(out var buffs))
				buffs.RemoveRandomBuff();
		}

		/// <summary>
		/// Removes a random debuff from the entity with the given chance in percent.
		/// </summary>
		/// <remarks>
		/// If chance is 100 or above, a random debuff will always be removed,
		/// assuming there is one to remove.
		/// </remarks>
		/// <param name="entity"></param>
		/// <param name="chance"></param>
		public static void RemoveRandomDebuff(this ICombatEntity entity, float chance = 100)
		{
			var rnd = RandomProvider.Get();

			if (rnd.Next(100) < chance && entity.Components.TryGet<BuffComponent>(out var buffs))
				buffs.RemoveRandomDebuff();
		}

		/// <summary>
		/// Returns true if the entity is behind the target.
		/// </summary>
		/// <remarks>
		/// Uses the target's current direction and the given max angle to
		/// determine if the entity is behind it.
		/// </remarks>
		/// <param name="entity"></param>
		/// <param name="target"></param>
		/// <param name="maxAngle"></param>
		/// <returns></returns>
		public static bool IsBehind(this ICombatEntity entity, ICombatEntity target, float maxAngle = 90)
		{
			var casterAngle = entity.Direction.DegreeAngle;
			var targetAngle = target.Direction.DegreeAngle;

			return Math.Abs(casterAngle - targetAngle) < maxAngle || Math.Abs(casterAngle + 360f - targetAngle) < maxAngle || Math.Abs(casterAngle - targetAngle + 360f) < maxAngle;
		}

		/// <summary>
		/// Returns true if a lock of the given type is active, indicating
		/// that they should not be able to take the action.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="lockType"></param>
		/// <returns></returns>
		public static bool IsLocked(this ICombatEntity entity, string lockType)
		{
			if (!entity.Components.TryGet<StateLockComponent>(out var stateLocks))
				return false;

			return stateLocks.IsLocked(lockType);
		}

		/// <summary>
		/// Sets the entity's state.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="stateType"></param>
		public static void SetState(this ICombatEntity entity, string stateType)
		{
			if (!entity.Components.TryGet<StateLockComponent>(out var stateLocks))
				return;

			stateLocks.SetState(stateType);
		}

		/// <summary>
		/// Sets the entity's state for the given duration.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="stateType"></param>
		/// <param name="duration"></param>
		public static void SetState(this ICombatEntity entity, string stateType, TimeSpan duration)
		{
			if (!entity.Components.TryGet<StateLockComponent>(out var stateLocks))
				return;

			stateLocks.SetState(stateType, duration);
		}
	}
}
