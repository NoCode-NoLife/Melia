using Melia.Shared.Game.Const;
using Melia.Zone.Scripting.ScriptableEvents;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Highlander
{
	/// <summary>
	/// Handler for the passive Highlander skill Defiance, which increases
	/// all damage against boss monsters.
	/// </summary>
	[SkillHandler(SkillId.Highlander_Defiance)]
	public class Highlander_Defiance : ISkillHandler
	{
		/// <summary>
		/// Applies the skill's effect before combat calculations.
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="attackerSkill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		[CombatCalcModifier(CombatCalcPhase.BeforeCalc, SkillId.Highlander_Defiance)]
		public void OnAttackBeforeCalc(ICombatEntity attacker, ICombatEntity target, Skill attackerSkill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			if (target.Rank != MonsterRank.Boss)
				return;

			if (!attacker.TryGetSkill(SkillId.Highlander_Defiance, out var skill))
				return;

			modifier.DamageMultiplier += skill.Level * 0.02f;
		}
	}
}
