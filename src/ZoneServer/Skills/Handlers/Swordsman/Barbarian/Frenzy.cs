using System;
using Melia.Shared.Game.Const;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Yggdrasil.Logging;

namespace Melia.Zone.Skills.Handlers.Swordsman.Barbarian
{
	/// <summary>
	/// Handler for the passive Barbarian skill Frenzy
	/// </summary>

	[SkillHandler(SkillId.Barbarian_Frenzy)]
	public class Frenzy : ISkillHandler, ISkillCombatAttackBeforeCalcHandler
	{
		/// <summary>
		/// Applies the skill's effect before combat calculations.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="attackerSkill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		public void OnAttackBeforeCalc(Skill skill, ICombatEntity attacker, ICombatEntity target, Skill attackerSkill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			// You lose Frenzy if you attack a different target
			// unless you have Barbarian22
			if (attacker.TryGetBuff(BuffId.Frenzy_Buff, out var frenzyBuff))
			{
				if (frenzyBuff.Caster != target && !attacker.IsAbilityActive(AbilityId.Barbarian22))
					attacker.StopBuff(BuffId.Frenzy_Buff);
			}

			// You build Frenzy when normal attacking
			if (attackerSkill.IsNormalAttack)
			{
				attacker.StartBuff(BuffId.Frenzy_Buff, 1, 0, TimeSpan.Zero, target);
			}

			// You do 2% more damage for every stack of Frenzy
			// We don't do this in the buff handler because
			// then it would matter which one was applied first
			if (attacker.TryGetBuff(BuffId.Frenzy_Buff, out var buff))
			{
				modifier.DamageMultiplier += buff.OverbuffCounter * 0.02f;
			}
		}
	}
}
