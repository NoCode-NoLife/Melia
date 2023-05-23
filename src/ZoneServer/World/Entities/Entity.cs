using Yggdrasil.Composition;

namespace Melia.Zone.World.Entities
{
	/// <summary>
	/// Describes an entity that can actively participate in combat.
	/// </summary>
	public interface ICombatEntity : INamedActor, IPropertyHolder
	{
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
		/// <param name="from"></param>
		/// <param name="type"></param>
		/// <returns>If damage is fatal returns true</returns>
		bool TakeDamage(int damage, Character from/*, DamageVisibilityModifier damageVisibility, int attackIndex*/);

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
}
