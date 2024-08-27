using System;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;
using Yggdrasil.Logging;

namespace Melia.Zone.Buffs.Handlers.Swordsmen.Barbarian
{
	/// <summary>
	/// Handler for the Frenzy Buff, which increases attack speed
	/// damage dealt, and damage taken as long as you keep
	/// attacking the same target.
	/// </summary>
	/// <remarks>
	/// Note that this buff stores the character you have frenzy
	/// against as the caster, while the character having the
	/// frenzy is the target.
	/// </remarks>
	[BuffHandler(BuffId.Frenzy_Buff)]
	public class Frenzy_Buff : BuffHandler, IBuffCombatDefenseBeforeCalcHandler
	{
		private const float ASpdBonusBase = 150;
		private const float ASpdBonusPerStack = 10;

		public override void OnStart(Buff buff)
		{
			var bonus = this.GetASpdBonus(buff);

			AddPropertyModifier(buff, buff.Target, PropertyName.ASPD_BM, bonus);
		}

		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.ASPD_BM);
		}

		public override void OnOverbuff(Buff buff)
		{
			var maxStacks = 2;
			if (buff.Target.TryGetSkill(SkillId.Barbarian_Frenzy, out var frenzySkill))
				maxStacks = frenzySkill.Level * 2;

			// Barbarian22 halves the maximum stacks
			if (buff.Target.IsAbilityActive(AbilityId.Barbarian22))
				maxStacks /= 2;

			if (buff.OverbuffCounter > maxStacks)
			{
				// disallow the overbuff
				buff.OverbuffCounter = maxStacks;
			}
			else
			{
				// reset the aspd buff, because the buff handler will call start
				RemovePropertyModifier(buff, buff.Target, PropertyName.ASPD_BM);
			}
		}

		public override void WhileActive(Buff buff)
		{
			// decay 1 overbuff counter
			if (buff.OverbuffCounter > 1)
			{
				buff.OverbuffCounter--;
				Send.ZC_BUFF_UPDATE(buff.Caster, buff);
			}
			else
			{
				buff.Target.StopBuff(BuffId.Frenzy_Buff);
			}
		}

		public void OnDefenseBeforeCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			// 0.5% more damage taken per stack
			modifier.DamageMultiplier += 0.005f * buff.OverbuffCounter;
		}

		/// <summary>
		/// Returns the attack speed bonus
		/// </summary>
		/// <param name="buff"></param>
		private float GetASpdBonus(Buff buff)
		{
			return ASpdBonusBase + buff.OverbuffCounter * ASpdBonusPerStack;
		}
	}
}
