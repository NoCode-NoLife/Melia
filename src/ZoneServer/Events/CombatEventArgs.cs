using System;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Events
{
	/// <summary>
	/// Arguments for a combat event involging two entites.
	/// </summary>
	public class CombatEventArgs : EventArgs
	{
		/// <summary>
		/// Returns the entity that was killed.
		/// </summary>
		public ICombatEntity Target { get; }

		/// <summary>
		/// Returns the entity that killed the target.
		/// </summary>
		public ICombatEntity Attacker { get; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="target"></param>
		/// <param name="attacker"></param>
		public CombatEventArgs(ICombatEntity target, ICombatEntity attacker)
		{
			this.Target = target;
			this.Attacker = attacker;
		}
	}
}
