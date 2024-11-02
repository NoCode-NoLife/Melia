using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Yggdrasil.Util;
using static Melia.Shared.Util.TaskHelper;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Scouts.OutLaw
{
	/// <summary>
	/// Handler for the Assassin skill Throw Sand
	/// </summary>
	[SkillHandler(SkillId.OutLaw_SprinkleSands)]
	public class OutLaw_SprinkleSands : IGroundSkillHandler
	{
		/// <summary>
		/// Handles skill
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		/// <param name="designatedTarget"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity designatedTarget)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			var splashParam = skill.GetSplashParameters(caster, originPos, farPos, length: 100, width: 40, angle: 0);
			var splashArea = skill.GetSplashArea(SplashType.Square, splashParam);

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);

			CallSafe(this.Attack(skill, caster, splashArea, farPos));
		}

		/// <summary>
		/// Executes the actual attack after a delay.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="splashArea"></param>
		private async Task Attack(Skill skill, ICombatEntity caster, ISplashArea splashArea, Position farPos)
		{
			var damageDelay = TimeSpan.FromMilliseconds(50);
			var skillHitDelay = TimeSpan.Zero;
			var hitDelay = TimeSpan.FromMilliseconds(250);

			await Task.Delay(hitDelay);

			var hits = new List<SkillHitInfo>();
			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			var hitTargets = targets.LimitBySDR(caster, skill);

			// Outlaw2 makes the max target count 17
			if (caster.IsAbilityActive(AbilityId.Outlaw2))
			{
				hitTargets = targets.LimitRandom(17);
			}

			foreach (var target in hitTargets)
			{
				var modifier = SkillModifier.MultiHit(4);

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
				skillHit.HitEffect = HitEffect.Impact;

				hits.Add(skillHit);

				target.StartBuff(BuffId.Common_Silence, skill.Level, 0, TimeSpan.FromMilliseconds(200 * skill.Level), caster);
				target.StartBuff(BuffId.SprinkleSands_Debuff, skill.Level, 0, TimeSpan.FromSeconds(10), caster);

				target.StartBuff(BuffId.DecreaseHeal_Debuff, skill.Level, this.GetHealingReduction(skill), TimeSpan.FromSeconds(5), caster);
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);
		}

		/// <summary>
		/// Return the Healing Reduction value
		/// </summary>
		/// <param name="skill"></param>
		/// <returns></returns>
		private float GetHealingReduction(Skill skill)
		{
			return (2.3f * skill.Level) * 1000;
		}
	}
}
