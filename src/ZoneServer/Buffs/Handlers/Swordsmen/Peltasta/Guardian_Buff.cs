using System;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;
using static Melia.Shared.Util.TaskHelper;

namespace Melia.Zone.Buffs.Handlers.Swordsmen.Peltasta
{
	/// <summary>
	/// Handler for the Guardian buff.
	/// </summary>
	[BuffHandler(BuffId.Guardian_Buff)]
	public class Guardian_Buff : BuffHandler, IBuffCombatDefenseBeforeCalcHandler, IBuffCombatDefenseAfterCalcHandler
	{
		public const float DamageReductionBase = 0.2f;
		public const float DamageReductionPerLevel = 0.025f;
		public const float SDRBonusBase = 6f;
		public const float SDRBonusPerLevel = 1f;

		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			AddPropertyModifier(buff, buff.Target, PropertyName.SDR_BM, this.GetSDRBonus(buff));
		}

		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.SDR_BM);
		}

		/// <summary>
		/// Returns the SDR bonus for the buff.
		/// </summary>
		/// <param name="buff"></param>
		/// <returns></returns>
		private float GetSDRBonus(Buff buff)
		{
			return SDRBonusBase + buff.NumArg1 * SDRBonusPerLevel;
		}

		/// <summary>
		/// Applies the buff's effect during the combat calculations.
		/// </summary>
		/// <param name="buff"></param>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		public void OnDefenseBeforeCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			var skillLevel = buff.NumArg1;
			var multiplierReduction = DamageReductionBase + skillLevel * DamageReductionPerLevel;

			if (!target.IsAbilityActive(AbilityId.Peltasta39))
				modifier.DamageMultiplier -= multiplierReduction;
		}

		/// <summary>
		/// Applies the buff's effect during the combat calculations.
		/// </summary>
		/// <param name="buff"></param>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		public void OnDefenseAfterCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			var skillLevel = buff.NumArg1;
			var multiplierReduction = DamageReductionBase + skillLevel * DamageReductionPerLevel;

			var reflectedDamage = skillHitResult.Damage * multiplierReduction;

			// Peltasta39 turns this into a damage reflect instead,
			// though the damage taken isn't reduced.
			if (target.IsAbilityActive(AbilityId.Peltasta39))
				CallSafe(this.ReflectDamage(attacker, target, reflectedDamage));
		}

		/// <summary>
		/// Hits target with a reflected hit.
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skillHitResult"></param>
		/// <param name="damage"></param>
		/// <returns></returns>
		private async Task ReflectDamage(ICombatEntity attacker, ICombatEntity target, float damage)
		{
			// We delay the reflect hit so the animation looks better
			await Task.Delay(100);

			attacker.TakeSimpleHit(damage, target, SkillId.None);
		}
	}
}
