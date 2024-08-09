using System;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Monsters;

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
			var target = buff.Target;

			var sdrBonus = GetSDRBonus(buff);

			AddPropertyModifier(buff, target, PropertyName.SDR_BM, sdrBonus);
		}

		public override void OnEnd(Buff buff)
		{
			var target = buff.Target;

			RemovePropertyModifier(buff, target, PropertyName.SDR_BM);
		}


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
		/// <exception cref="NotImplementedException"></exception>
		public void OnDefenseBeforeCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			var skillLevel = buff.NumArg1;
			var multiplierReduction = DamageReductionBase + skillLevel * DamageReductionPerLevel;

			if (!target.IsAbilityActive(AbilityId.Peltasta39))
			{
				modifier.DamageMultiplier -= multiplierReduction;
			}
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
		/// <exception cref="NotImplementedException"></exception>
		public async void OnDefenseAfterCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			var skillLevel = buff.NumArg1;
			var multiplierReduction = DamageReductionBase + skillLevel * DamageReductionPerLevel;

			var delayTime = TimeSpan.FromMilliseconds(100);


			// Peltasta39 turns this into a damage reflect instead
			// though the damage taken isn't reduced
			if (target.IsAbilityActive(AbilityId.Peltasta39))
			{
			var reflectedDamage = skillHitResult.Damage * multiplierReduction;
				// we delay this so the reflect animation looks better
				await Task.Delay(delayTime);
				attacker.TakeSimpleHit(reflectedDamage, target, SkillId.None);
			}
		}
	}
}
