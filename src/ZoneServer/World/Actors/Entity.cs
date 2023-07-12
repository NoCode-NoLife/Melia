using System;
using System.Runtime.CompilerServices;
using Melia.Shared.ObjectProperties;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Buffs;
using Melia.Zone.Network;
using Melia.Zone.Skills;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Yggdrasil.Composition;

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
		/// Returns the entity's mode of movement.
		/// </summary>
		MoveType MoveType { get; }

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
		/// Makes the entity turn towards the other entity.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="otherEntity"></param>
		public static void TurnTowards(this ICombatEntity entity, ICombatEntity otherEntity)
		{
			if (otherEntity != null)
				TurnTowards(entity, otherEntity.Position);
		}

		/// <summary>
		/// Makes the entity turn towards the position.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="otherEntity"></param>
		public static void TurnTowards(this ICombatEntity entity, Position pos)
		{
			entity.Direction = entity.Position.GetDirection(pos);
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
			if (!(entity is Character character))
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
		/// <param name="otherActor"></param>
		/// <returns></returns>
		public static Direction GetDirection(this IActor actor, Position pos)
			=> actor.Position.GetDirection(pos);

		/// <summary>
		/// Sets the entity's attack state.
		/// </summary>
		/// <param name="state"></param>
		public static void SetAttackState(this ICombatEntity entity, bool inAttackState)
			=> entity.Components.Get<CombatComponent>()?.SetAttackState(inAttackState);

		/// <summary>
		/// Starts the buff with the given id. If the buff is already active,
		/// it gets overbuffed. Returns the created or modified buff.
		/// </summary>
		/// <param name="buffId"></param>
		/// <param name="duration"></param>
		/// <returns></returns>
		public static Buff StartBuff(this ICombatEntity entity, BuffId buffId, TimeSpan duration)
			=> entity.Components.Get<BuffComponent>()?.Start(buffId, 0, 0, duration, entity);

		/// <summary>
		/// Starts the buff with the given id. If the buff is already active,
		/// it gets overbuffed. Returns the created or modified buff.
		/// </summary>
		/// <param name="buffId"></param>
		/// <param name="numArg1"></param>
		/// <param name="numArg2"></param>
		/// <param name="duration"></param>
		/// <param name="caster"></param>
		/// <returns></returns>
		public static Buff StartBuff(this ICombatEntity entity, BuffId buffId, float numArg1, float numArg2, TimeSpan duration, ICombatEntity caster)
			=> entity.Components.Get<BuffComponent>()?.Start(buffId, numArg1, numArg2, duration, caster);

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
	}
}
