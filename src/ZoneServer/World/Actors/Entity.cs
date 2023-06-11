using Melia.Shared.ObjectProperties;
using Melia.Shared.Tos.Const;
using Melia.Zone.Network;
using Melia.Zone.Skills;
using Melia.Zone.World.Actors.Characters;
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
		/// Returns the entity's current HP.
		/// </summary>
		int Hp { get; }

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
		/// Returns a random physical attack value based on the entity's
		/// physical attack.
		/// </summary>
		/// <returns></returns>
		float GetRandomPAtk();

		/// <summary>
		/// Returns a random magic attack value based on the entity's
		/// magic attack.
		/// </summary>
		/// <returns></returns>
		float GetRandomMAtk();

		/// <summary>
		/// Returns a random attack value based on the entity's attack and
		/// the skill's type.
		/// </summary>
		/// <returns></returns>
		float GetRandomAtk(Skill skill);

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
			entity.Direction = entity.Position.GetDirection(otherEntity.Position);
			Send.ZC_ROTATE(entity);
		}
	}
}
