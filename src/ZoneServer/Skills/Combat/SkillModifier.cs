namespace Melia.Zone.Skills.Combat
{
	/// <summary>
	/// A class for properties that can modify the damage calculation for a skill.
	/// </summary>
	public class SkillModifier
	{
		/// <summary>
		/// Gets or sets flat PATK bonus added to melee attack.
		/// </summary>
		public float BonusPAtk { get; set; }

		/// <summary>
		/// Gets or sets flat MATK bonus added to magic attack.
		/// </summary>
		public float BonusMAtk { get; set; }

		/// <summary>
		/// Gets or sets flat damage bonus added to skill damage.
		/// </summary>
		/// <remarks>
		/// This damage is added before any defense, crit, block, etc. calculations.
		/// </remarks>
		public float BonusDamage { get; set; }

		/// <summary>
		/// Gets or sets percentage-based defense penetration for DEF and MDEF.
		/// </summary>
		/// <remarks>
		/// Operates like a multiplier, so 0.1 = 10% defense ignored. If set to 1,
		/// defense is effectively nullified.
		/// </remarks>
		public float DefensePenetrationRate { get; set; }

		/// <summary>
		/// Gets or sets damage multiplier applied to skill damage.
		/// Multiplies the attack damage before enemy defense is applied
		/// This is a percentage with 1.00 as the base, so 1.02 adds 2% damage
		/// </summary>
		/// <remarks>
		/// This multiplier applies directly to damage, so a value of 1.02 will
		/// increase the damage by 2%. It's applied just before BonusDamage,
		/// and before defense, crits, etc. are calculated.
		/// </remarks>
		public float DamageMultiplier { get; set; } = 1;

		/// <summary>
		/// Gets or sets the number of times an attack hits.
		/// </summary>
		/// <remarks>
		/// The damage is multiplied by this amount and displays visually as
		/// multiple hits.
		/// </remarks>
		public int HitCount { get; set; } = 1;

		/// <summary>
		/// Returns a new skill modifier with default values.
		/// </summary>
		public static SkillModifier Default { get; } = new SkillModifier();

		/// <summary>
		/// Returns a new skill modifier with the given hit count.
		/// </summary>
		/// <param name="hitCount">Number of hits to set.</param>
		/// <returns></returns>
		public static SkillModifier MultiHit(int hitCount)
		{
			var result = new SkillModifier();
			result.HitCount = hitCount;

			return result;
		}

		/// <summary>
		/// Returns a new skill modifier with the given hit count if condition is true.
		/// </summary>
		/// <param name="hitCount">Number of hits to set.</param>
		/// <param name="condition">If false, hit count is set to the default of 1.</param>
		/// <returns></returns>
		public static SkillModifier MultiHitIf(int hitCount, bool condition)
		{
			var result = new SkillModifier();

			if (condition)
				result.HitCount = hitCount;

			return result;
		}
	}
}
