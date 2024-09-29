using Melia.Shared.Game.Const;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Skills.Handlers.Archers.Ranger
{
	/// <summary>
	/// Handler for the Ranger skill Full Throttle
	/// </summary>
	/// <remarks>
	/// This skill repurposes the skill id of an earlier skill
	/// called Steady Aim, though the effect is completely different.
	/// </remarks>
	[SkillHandler(SkillId.Ranger_SteadyAim)]
	public class Ranger_SteadyAim : ISkillHandler, ISkillCombatAttackAfterBonusesHandler
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
			var isRangerAttackSkill = attackerSkill.Id >= SkillId.Ranger_Barrage && attackerSkill.Id <= SkillId.Ranger_BlazingArrow;

			if (isCrit && isRangerAttackSkill)
			{
				var multiplierBonus = 0.18f + skill.Level * 0.03f;
				modifier.FinalDamageMultiplier += multiplierBonus;
			}
		}
	}
}
