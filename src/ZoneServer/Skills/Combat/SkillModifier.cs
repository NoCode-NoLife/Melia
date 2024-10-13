using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;

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
		/// Gets or sets the skill's hit multiplier.  Base is 1.0.
		/// </summary>
		/// <remarks>
		/// This multiplies the user's hit by the listed amount.  A value of 1.3
		/// would increase the attacker's hit by 30%.
		/// </remarks>
		public float HitRateMultiplier { get; set; } = 1;

		/// <summary>
		/// Gets or sets the skill's block pen multiplier.  Base is 1.0.
		/// </summary>
		/// <remarks>
		/// This multiplies the user's block pen by the listed amount. 
		/// A value of 1.3 would increase the attacker's block pen by 30%.
		/// </remarks>
		public float BlockPenetrationMultiplier { get; set; } = 1;

		/// <summary>
		/// Gets or sets flat crit rate bonus.
		/// </summary>
		/// <remarks>
		/// The value is in percent. For example, setting it to 20 increases the
		/// crit chance by 20%.
		/// </remarks>
		public float BonusCritChance { get; set; }

		/// <summary>
		/// Gets or sets percentage-based defense penetration for DEF and MDEF.
		/// </summary>
		/// <remarks>
		/// Operates like a multiplier, so 0.1 = 10% defense ignored. If set to 1,
		/// defense is effectively nullified.
		/// </remarks>
		public float DefensePenetrationRate { get; set; }

		/// <summary>
		/// Gets or sets damage multiplier applied to skill damage before
		/// defense, crit, and other modifiers are applied.
		/// </summary>
		/// <remarks>
		/// This multiplier applies directly to damage, so a value of 1.02 will
		/// increase the damage by 2%. It's applied just before BonusDamage,
		/// and before defense, crits, etc. are calculated.
		/// </remarks>
		public float DamageMultiplier { get; set; } = 1;

		/// <summary>
		/// Gets or sets the minimum critical chance.
		/// </summary>
		/// <remarks>
		/// If set, this value acts as the minimum possible chance for a crit
		/// to occur.  It's in percent, so 20 = 20% crit rate minimum.
		/// </remarks>
		public float MinCritChance { get; set; } = 0;

		/// <summary>
		/// Gets or sets damage multiplier applied to skill damage after
		/// defense, crit, and other modifiers were applied.
		/// </summary>
		/// <remarks>
		/// This multiplier applies directly to damage, so a value of 1.02 will
		/// increase the damage by 2%. It's applied after all other calculations
		/// are finished.
		/// </remarks>
		public float FinalDamageMultiplier { get; set; } = 1;

		/// <summary>
		/// Gets or sets the number of times an attack hits.
		/// </summary>
		/// <remarks>
		/// The damage is multiplied by this amount and displays visually as
		/// multiple hits.
		/// </remarks>
		public int HitCount { get; set; } = 1;

		/// <summary>
		/// Gets or sets whether the attack can be blocked. Beats out ForcedBlock.
		/// </summary>
		public bool Unblockable { get; set; }

		/// <summary>
		/// Gets or sets forced hit status.
		/// </summary>
		/// <remarks>
		/// If this is true, the attack can't be evaded.
		/// </remarks>
		public bool ForcedHit { get; set; }

		/// <summary>
		/// Gets or sets forced block status.
		/// </summary>
		/// <remarks>
		/// If this is true, the attack is always blocked.
		/// </remarks>
		public bool ForcedBlock { get; set; }

		/// <summary>
		/// Gets or sets forced critical status.
		/// </summary>
		/// <remarks>
		/// If this is true, the attack always deals a critical hit.
		/// </remarks>
		public bool ForcedCritical { get; set; }

		/// <summary>
		/// Gets or sets overidden attack attribute status
		/// </summary>
		/// <remarks>
		/// If not set to Attribute.None, the skill will use the indicated
		/// attribute instead of its own attribute.
		/// </remarks>
		public SkillAttribute AttackAttribute { get; set; } = SkillAttribute.None;


		/// <summary>
		/// Gets or sets overidden defense attribute status
		/// </summary>
		/// <remarks>
		/// If not set to Attribute.None, the defender will use the indicated
		/// attribute instead of its natural attribute
		/// </remarks>
		public AttributeType DefenseAttribute { get; set; } = AttributeType.None;

		/// <summary>
		/// Returns a new skill modifier with default values.
		/// </summary>
		public static SkillModifier Default => new();

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
