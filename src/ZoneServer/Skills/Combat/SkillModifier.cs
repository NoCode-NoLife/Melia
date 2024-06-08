using System;
using Melia.Shared.Game.Const;

namespace Melia.Zone.Skills.Combat
{
	/// <summary>
	/// A class for properties that can modify the damage calculation for a skill
	/// </summary>
	public class SkillModifier
	{
		/// <summary>
		/// Adds extra PAtk to the damage calculation
		/// </summary>
		public float BonusPAtk { get; set; }

		/// <summary>
		/// Adds extra MAtk to the damage calculation
		/// </summary>
		public float BonusMAtk { get; set; }

		/// <summary>
		/// Adds extra (flat) damage to the damage calculation
		/// </summary>
		public float BonusDamage { get; set; }

		/// <summary>
		/// Multiplies the attack damage before enemy defense is applied
		/// This is a percentage with 1.00 as the base, so 1.02 adds 2% damage
		/// </summary>
		public float DamageMultiplier { get; set; }

		/// <summary>
		/// The number of hits the skill does
		/// This also multiplies the damage by this amount
		/// </summary>
		public int HitCount { get; set; }

		/// <summary>
		/// Creates new skill modifier.
		/// </summary>
		public SkillModifier()
		{
			this.DamageMultiplier = 1.0f;
			this.HitCount = 1;
		}
	}
}
