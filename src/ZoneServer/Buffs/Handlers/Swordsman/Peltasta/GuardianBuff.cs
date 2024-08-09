using System;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Swordsman
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

		public override void OnStart(Buff buff)
		{
			AddPropertyModifier(buff, buff.Target, PropertyName.SDR_BM, this.GetSDRBonus(buff));
		}

		public override void OnEnd(Buff buff)
		{
			var target = ;

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
		public async void OnDefenseAfterCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			var skillLevel = buff.NumArg1;
			var multiplierReduction = DamageReductionBase + skillLevel * DamageReductionPerLevel;

			var delayTime = TimeSpan.FromMilliseconds(100);

			// Peltasta39 turns this into a damage reflect instead,
			// though the damage taken isn't reduced.
			if (target.IsAbilityActive(AbilityId.Peltasta39))
			{
				var reflectedDamage = skillHitResult.Damage * multiplierReduction;

				// We delay the reflect hit so the animation looks better
				await Task.Delay(delayTime);

				attacker.TakeSimpleHit(reflectedDamage, target, SkillId.None);
			}
		}
	}
}
