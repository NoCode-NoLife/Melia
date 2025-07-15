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
using static Melia.Shared.Util.TaskHelper;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Highlander
{
	/// <summary>
	/// Handler for the Highlander skill Cartar Stroke.
	/// </summary>
	[SkillHandler(SkillId.Highlander_CartarStroke)]
	public class Highlander_CartarStroke : IGroundSkillHandler, IDynamicCasted
	{
		/// <summary>
		/// Called when the user starts casting the skill.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		public void StartDynamicCast(Skill skill, ICombatEntity caster)
		{
			Send.ZC_PLAY_SOUND(caster, "voice_war_atk_long_cast");
		}

		/// <summary>
		/// Called when the user stops casting the skill.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		public void EndDynamicCast(Skill skill, ICombatEntity caster)
		{
			Send.ZC_STOP_SOUND(caster, "voice_war_atk_long_cast");
		}

		/// <summary>
		/// Handles skill, damaging targets.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity target)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			var splashParam = skill.GetSplashParameters(caster, originPos, farPos, length: 45, width: 45, angle: 0);
			var splashArea = skill.GetSplashArea(SplashType.Circle, splashParam);

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);

			CallSafe(this.Attack(skill, caster, splashArea));
		}

		/// <summary>
		/// Executes the actual attack after a delay.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="splashArea"></param>
		private async Task Attack(Skill skill, ICombatEntity caster, ISplashArea splashArea)
		{
			var hitDelay = TimeSpan.FromMilliseconds(300);
			var damageDelay = TimeSpan.FromMilliseconds(50);
			var skillHitDelay = TimeSpan.Zero;
			var delayBetweenHits = TimeSpan.FromMilliseconds(50);

			await Task.Delay(hitDelay);

			List<ICombatEntity> targets;
			var hits = new List<SkillHitInfo>();

			for (var i = 0; i < 3; i++)
			{
				targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

				foreach (var target in targets.LimitBySDR(caster, skill))
				{
					var skillHitResult = SCR_SkillHit(caster, target, skill);
					target.TakeDamage(skillHitResult.Damage, caster);

					var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
					skillHit.HitEffect = HitEffect.Impact;

					hits.Add(skillHit);
				}

				Send.ZC_SKILL_HIT_INFO(caster, hits);

				hits.Clear();
				await Task.Delay(delayBetweenHits);
			}

			targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var skillHitResult = SCR_SkillHit(caster, target, skill);
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);

				skillHit.KnockBackInfo = new KnockBackInfo(caster.Position, target.Position, skill);
				skillHit.ApplyKnockBack(target);

				// At one point, this skill was not a knockdown, but instead
				// did more damage to knocked down targets, similar to
				// Doppelsoldner's Punish.

				hits.Add(skillHit);
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);
		}
	}
}
