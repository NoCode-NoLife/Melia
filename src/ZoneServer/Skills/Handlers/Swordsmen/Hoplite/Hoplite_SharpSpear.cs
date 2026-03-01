using Melia.Shared.Game.Const;
using Melia.Zone.Scripting.ScriptableEvents;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Hoplite
{
	/// <summary>
	/// Handler for the passive Hoplite skill Sharp Spear, which increases
	/// the damage of critical hits with Hoplite attack skills.
	/// </summary>
	[SkillHandler(SkillId.Hoplite_SharpSpear)]
	public class Hoplite_SharpSpear : ISkillHandler
	{
		/// <summary>
		/// Applies the skill's effect during combat calculations.
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="attackerSkill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		[CombatCalcModifier(CombatCalcPhase.BeforeCalc, SkillId.Hoplite_SharpSpear)]
		public void OnAttackAfterBonuses(ICombatEntity attacker, ICombatEntity target, Skill attackerSkill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			if (!attacker.TryGetSkill(attackerSkill.Id, out var skill))
				return;

			var isCrit = skillHitResult.Result == HitResultType.Crit;
			var isHopliteAttackSkill = attackerSkill.Id >= SkillId.Hoplite_Stabbing && attackerSkill.Id <= SkillId.Hoplite_SharpSpear;

			if (isCrit && isHopliteAttackSkill)
			{
				var multiplierBonus = 0.1f + skill.Level * 0.02f;
				modifier.FinalDamageMultiplier += multiplierBonus;
			}
		}
	}
}
