using System;
using Melia.Shared.Game.Const;
using Melia.Zone.Scripting.ScriptableEvents;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Barbarian
{
	/// <summary>
	/// Handler for the passive Barbarian skill Frenzy.
	/// </summary>
	[SkillHandler(SkillId.Barbarian_Frenzy)]
	public class Frenzy : ISkillHandler
	{
		/// <summary>
		/// Applies the skill's effect before combat calculations.
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="attackerSkill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		[CombatCalcModifier(CombatCalcPhase.BeforeCalc, SkillId.Barbarian_Frenzy)]
		public void OnAttackBeforeCalc(ICombatEntity attacker, ICombatEntity target, Skill attackerSkill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			// You lose Frenzy if you attack a different target, unless Barbarian22
			// is active.
			if (attacker.TryGetBuff(BuffId.Frenzy_Buff, out var frenzyBuff))
			{
				if (frenzyBuff.Caster != target && !attacker.IsAbilityActive(AbilityId.Barbarian22))
					attacker.StopBuff(BuffId.Frenzy_Buff);
			}

			// You build Frenzy when normal attacking
			if (attackerSkill.IsNormalAttack)
				attacker.StartBuff(BuffId.Frenzy_Buff, 0, 0, TimeSpan.Zero, target);

			// You do 2% more damage for every stack of Frenzy. This is done here
			// to get the immediate effect on the first hit, in case the Frenzy_Buff
			// combat event comes in after this one.
			if (attacker.TryGetBuff(BuffId.Frenzy_Buff, out var buff))
				modifier.DamageMultiplier += buff.OverbuffCounter * 0.02f;
		}
	}
}
