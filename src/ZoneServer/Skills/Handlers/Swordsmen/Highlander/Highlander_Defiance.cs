using Melia.Shared.Game.Const;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Highlander
{
	/// <summary>
	/// Handler for the passive Highlander skill Defiance.
	/// </summary>
	[SkillHandler(SkillId.Highlander_Defiance)]
	public class Highlander_Defiance : ISkillHandler, ISkillCombatAttackBeforeCalcHandler
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
			if (target.Rank != MonsterRank.Boss)
				return;

			modifier.DamageMultiplier += skill.Level * 0.02f;
		}
	}
}
