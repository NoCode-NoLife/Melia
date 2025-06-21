﻿using Melia.Zone.World.Actors;

namespace Melia.Zone.Scripting.AI
{
	/// <summary>
	/// An alert about an event that happend to or around an AI's entity.
	/// </summary>
	public interface IAiEventAlert
	{
	}

	/// <summary>
	/// Information for the AI that the entity was hit.
	/// </summary>
	public class HitEventAlert : IAiEventAlert
	{
		/// <summary>
		/// Returns the target.
		/// </summary>
		public ICombatEntity Target { get; }

		/// <summary>
		/// Returns the attacker.
		/// </summary>
		public ICombatEntity Attacker { get; }

		/// <summary>
		/// Returns the damage dealt.
		/// </summary>
		public float Damage { get; }

		/// <summary>
		/// Creates new event.
		/// </summary>
		/// <param name="target"></param>
		/// <param name="attacker"></param>
		/// <param name="damage"></param>
		public HitEventAlert(ICombatEntity target, ICombatEntity attacker, float damage)
		{
			this.Target = target;
			this.Attacker = attacker;
			this.Damage = damage;
		}
	}

	public class HateResetAlert : IAiEventAlert
	{
		/// <summary>
		/// Returns the entity for which the hate was reset.
		/// </summary>
		public ICombatEntity Target { get; }

		/// <summary>
		/// Creates new event.
		/// </summary>
		/// <param name="target"></param>
		public HateResetAlert(ICombatEntity target)
		{
			this.Target = target;
		}
	}

	public class HateIncreaseAlert : IAiEventAlert
	{
		/// <summary>
		/// Returns the entity for which the hate should increase
		/// </summary>
		public ICombatEntity Target { get; }

		/// <summary>
		/// Returns the amount of hate to gain.
		/// </summary>
		public float Amount { get; }

		/// <summary>
		/// Creates new event.
		/// </summary>
		/// <param name="target"></param>
		public HateIncreaseAlert(ICombatEntity target, float amount)
		{
			this.Target = target;
			this.Amount = amount;
		}
	}
}
