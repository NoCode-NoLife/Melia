using Melia.Shared.Tos.Const;
using Melia.Shared.EntityComponents;
using Melia.Shared.World;
using Melia.Shared.World.ObjectProperties;

namespace Melia.Channel.World.Entities
{
	/// <summary>
	/// Describes a living entity that can exist on a map.
	/// </summary>
	public interface IEntity
	{
		/// <summary>
		/// Returns the entity's globally unique, session limited, id.
		/// </summary>
		int Handle { get; }

		/// <summary>
		/// Returns the entity's type.
		/// </summary>
		EntityType Type { get; }

		/// <summary>
		/// Returns the entity's faction.
		/// </summary>
		FactionType Faction { get; }

		/// <summary>
		/// Returns the entity's name.
		/// </summary>
		string Name { get; }

		/// <summary>
		/// Returns the entity's current HP.
		/// </summary>
		int Hp { get; }

		/// <summary>
		/// Returns true if the entity is dead.
		/// </summary>
		bool IsDead { get; }

		/// <summary>
		/// Returns the map the entity is currently on.
		/// </summary>
		Map Map { get; }

		/// <summary>
		/// Returns the entity's position on its current map.
		/// </summary>
		Position Position { get; set; }

		/// <summary>
		/// Returns the entity's direction on its current map.
		/// </summary>
		Direction Direction { get; set; }

		/// Returns the entity's property collection.
		/// </summary>
		Properties Properties { get; }

		/// <summary>
		/// Returns the entity's component collection.
		/// </summary>
		ComponentCollection Components { get; }
	}

	/// <summary>
	/// Describes an entity that can actively participate in combat.
	/// </summary>
	public interface ICombatEntity : IEntity
	{
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

	/// <summary>
	/// Defines an entity's type.
	/// </summary>
	public enum EntityType
	{
		/// <summary>
		/// Entity is a player character.
		/// </summary>
		Character,

		/// <summary>
		/// Entity is an actual monster.
		/// </summary>
		Mob,

		/// <summary>
		/// Entity is an item "monster".
		/// </summary>
		Item,
	}
}
