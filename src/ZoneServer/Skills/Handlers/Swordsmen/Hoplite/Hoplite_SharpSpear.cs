using Melia.Shared.Game.Const;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Matador
{
	/// <summary>
	/// Handler for the Hoplite skill Sharp Spear.
	/// </summary>
	[SkillHandler(SkillId.Hoplite_SharpSpear)]
	public class Hoplite_SharpSpear : ISkillHandler, ISkillCombatAttackAfterBonusesHandler
	{
		/// <summary>
		/// Applies the skill's effect during combat calculations.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="attackerSkill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		public void OnAttackAfterBonuses(Skill skill, ICombatEntity attacker, ICombatEntity target, Skill attackerSkill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
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
