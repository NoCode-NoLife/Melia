// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using Melia.Shared.World;

namespace Melia.Channel.World
{
	public interface IEntity
	{
		int Handle { get; }
		int Hp { get; }
		Map Map { get; }
		Position Position { get; }
	}

	public interface IAttackableEntity : IEntity
	{
		/// <summary>
		/// Makes monster take damage and kills it if the HP reach 0.
		/// </summary>
		/// <param name="damage"></param>
		/// <param name="from"></param>
		/// <param name="type"></param>
		/// <returns>If damage is fatal returns true</returns>
		bool TakeDamage(int damage, Character from, DamageVisibilityModifier damageVisibility, int attackIndex = 0);
	}

	/// <summary>
	/// Damage Visibility
	/// Invisible: Sends no damage packet
	/// Hit: Sends ZC_HIT_INFO
	/// Skill: Sends ZC_SKILL_HIT_INFO
	/// </summary>
	public enum DamageVisibilityModifier
	{
		Invisible,
		Hit,
		Skill,
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
