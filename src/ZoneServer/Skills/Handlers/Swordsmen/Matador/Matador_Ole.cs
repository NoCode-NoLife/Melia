using System;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Scripting;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Matador
{
	/// <summary>
	/// Handler for the Matador skill Ole.
	/// </summary>
	[SkillHandler(SkillId.Matador_Ole)]
	public class Matador_Ole : IGroundSkillHandler, ISkillCombatAttackBeforeCalcHandler
	{
		private const int MaxTargets = 10;

		/// <summary>
		/// Handles skill, increase nearby monsters treat (aggro them)
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		/// <param name="target"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity target)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(false);

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, caster.Position, caster.Direction, Position.Zero);
			
			var splashArea = new Circle(caster.Position, 90);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			foreach (var aggroTarget in targets.LimitRandom(MaxTargets))
			{
				aggroTarget.StartBuff(BuffId.Ole_Debuff, 0, 0, TimeSpan.FromMilliseconds(500), caster);
			}

			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);
		}

		/// <summary>
		/// Applies the skill's effect before combat attack calculations.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="attackerSkill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		public void OnAttackBeforeCalc(Skill skill, ICombatEntity attacker, ICombatEntity target, Skill attackerSkill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			modifier.MinCritChance += this.GetIncreaseMinimalCritChance(skill);
		}

		/// <summary>
		/// Return the value of the increased minimal critical chance
		/// </summary>
		/// <param name="skill"></param>
		/// <returns></returns>
		private float GetIncreaseMinimalCritChance(Skill skill)
		{
			var SCR_Get_AbilityReinforceRate = ScriptableFunctions.Skill.Get("SCR_Get_AbilityReinforceRate");
			return (15 + (2.5f * skill.Level)) * SCR_Get_AbilityReinforceRate(skill);
		}
	}
}
