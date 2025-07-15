using System;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Events.Arguments
{
	/// <summary>
	/// Arguments for a combat event involging two entites.
	/// </summary>
	/// <param name="target"></param>
	/// <param name="attacker"></param>
	public class CombatEventArgs(ICombatEntity target, ICombatEntity attacker) : EventArgs
	{
		/// <summary>
		/// Returns the entity that was killed.
		/// </summary>
		public ICombatEntity Target { get; } = target;

		/// <summary>
		/// Returns the entity that killed the target.
		/// </summary>
		public ICombatEntity Attacker { get; } = attacker;
	}
}
