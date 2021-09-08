// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using Melia.Channel.Skills;
using Melia.Shared.World;

namespace Melia.Channel.World
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
		/// Returns the entity's current HP.
		/// </summary>
		int Hp { get; }

		/// <summary>
		/// Returns the map the entity is currently on.
		/// </summary>
		Map Map { get; }

		/// <summary>
		/// Returns the entity's position on its current map.
		/// </summary>
		Position Position { get; }
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
		bool TakeDamage(int damage, Character from, DamageVisibilityModifier damageVisibility, int attackIndex = 0);

		/// <summary>
		/// Returns true if this entity can attack the given one.
		/// </summary>
		/// <param name="entity"></param>
		/// <returns></returns>
		bool CanAttack(ICombatEntity entity);
	}

	public interface IEntityEvent
	{
		/// <summary>
		/// Event thrown on death
		/// </summary>
		event EventHandler<EntityEventArgs> Died;
	}

	public class EntityEventArgs : EventArgs
	{
		public int Handle { get; set; }

		public EntityEventArgs(int handle)
		{
			this.Handle = handle;
		}
	}
}
