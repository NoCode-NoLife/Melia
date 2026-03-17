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
		/// Gets or sets the skill's hit multiplier.
		/// </summary>
		/// <remarks>
		/// The user's hit property is multiplied by this value. For example,
		/// a value of 1.3 would increase the attacker's hit by 30%.
		/// </remarks>
		public float HitRateMultiplier { get; set; } = 1;

		/// <summary>
		/// Gets or sets the skill's block pen multiplier.
		/// </summary>
		/// <remarks>
		/// The user's block penetration property is multiplied by this value.
		/// For example, a value of 1.3 would increase the attacker's block
		/// penetration by 30%.
		/// </remarks>
		public float BlockPenetrationMultiplier { get; set; } = 1;

		/// <summary>
		/// Gets or sets defense bonus for DEF and MDEF.
		/// </summary>
		/// <remarks>
		/// A flat amount of defense benefitting the target, directly
		/// reducing the incoming damage.
		/// </remarks>
		public float DefenseBonus { get; set; }

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
		/// This multiplier applies directly to damage, meaning that a
		/// value of 1.02 will increase the damage by 2%. It's applied
		/// just before BonusDamage, and before defense, crits, etc. are
		/// calculated. The default value is 1, meaning no change to damage.
		/// </remarks>
		public float DamageMultiplier { get; set; } = 1;

		/// <summary>
		/// Gets or sets the minimum critical chance.
		/// </summary>
		/// <remarks>
		/// If set, this value acts as the minimum possible chance for a
		/// crit to occur. It's in percent, so 20 = 20% crit rate
		/// minimum. The default is 0.
		/// </remarks>
		public float MinCritChance { get; set; } = 0;

		/// <summary>
		/// Gets or sets the maximum critical chance.
		/// </summary>
		/// <remarks>
		/// If set, this value acts as the maximum possible chance for a
		/// crit to occur. It's in percent, so 20 = 20% crit rate
		/// maximum. The default is 100.
		/// </remarks>
		public float MaxCritChance { get; set; } = 100;

		/// <summary>
		/// Gets or sets the crit chance multiplier.
		/// </summary>
		/// <remarks>
		/// The multiplier gets applied to the crit chance before other bonuses,
		/// such as BonusCritChance. For example, with a base crit chance of 10%,
		/// a multiplier of 1.5 and a bonus of 20%, the final crit chance would be:
		/// 10 * 1.5 + 20 = 35%.
		/// </remarks>
		public float CritChanceMultiplier { get; set; } = 1;

		/// <summary>
		/// Gets or sets the crit hit rate multiplier, affecting the
		/// property CRTHR.
		/// </summary>
		/// <remarks>
		/// The multiplier gets applied to the crit hit rate directly
		/// before it's used, and before other bonuses and multipliers
		/// are applied. It's 1 by default, meaning no change to the
		/// crit hit rate.
		/// </remarks>
		public float CritHitRateMultiplier { get; set; } = 1;

		/// <summary>
		/// Gets or sets the crit dodge rate multiplier, affecting the
		/// property CRTDR.
		/// </summary>
		/// <remarks>
		/// The multiplier gets applied to the crit dodge rate directly
		/// before it's used, and before other bonuses and multipliers
		/// are applied. It's 1 by default, meaning no change to the
		/// crit dodge rate.
		/// </remarks>
		public float CritDodgeRateMultiplier { get; set; } = 1;

		/// <summary>
		/// Gets or sets flat crit chance bonus.
		/// </summary>
		/// <remarks>
		/// The value is in percent. For example, setting it to 20 increases the
		/// crit chance by 20%.
		/// </remarks>
		public float BonusCritChance { get; set; }

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
		/// Gets or sets forced block status.
		/// </summary>
		/// <remarks>
		/// If this is true, the attack is always blocked
		/// unless it is unblockable.
		/// </remarks>
		public bool ForcedBlock { get; set; }

		/// <summary>
		/// Gets or sets forced hit status.
		/// </summary>
		/// <remarks>
		/// If this is true, the attack can't be evaded.
		/// </remarks>
		public bool ForcedHit { get; set; }

		/// <summary>
		/// Gets or sets forced evade status.
		/// </summary>
		/// <remarks>
		/// If this is true, the attack is always evaded
		/// unless it is unavoidable
		/// </remarks>
		public bool ForcedEvade { get; set; }

		/// <summary>
		/// Gets or sets forced critical status.
		/// </summary>
		/// <remarks>
		/// If this is true, the attack always deals a critical hit.
		/// </remarks>
		public bool ForcedCritical { get; set; }

		/// <summary>
		/// Gets or sets the type of the attack.
		/// </summary>
		/// <remarks>
		/// By default, this is set to the attack type of the skill at the
		/// beginning of the calculations, and certain skills may overwrite
		/// it with the main weapon's attack type.
		/// 
		/// This property should be used to check the attack type for
		/// buffs or other effects that depend on the type of attack.
		/// 
		/// A modification of this property may affect any number of
		/// effects and shouldn't be done lightly.
		/// </remarks>
		public SkillAttackType AttackType { get; set; } = SkillAttackType.None;

		/// <summary>
		/// Gets or sets the attack's attribute.
		/// </summary>
		/// <remarks>
		/// If this is set to None, the skill's attribute is used.
		/// </remarks>
		public AttributeType AttackAttribute { get; set; } = AttributeType.None;

		/// <summary>
		/// Gets or sets the target's attribute.
		/// </summary>
		/// <remarks>
		/// If this is set to None, the target's attribute is used.
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
