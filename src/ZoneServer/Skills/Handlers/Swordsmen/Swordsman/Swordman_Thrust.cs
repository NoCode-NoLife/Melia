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
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Swordsman
{
	/// <summary>
	/// Handler for the Swordsman skill Thrust.
	/// </summary>
	[SkillHandler(SkillId.Swordman_Thrust)]
	public class Swordman_Thrust : IGroundSkillHandler
	{
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
			caster.TurnTowards(farPos);
			caster.SetAttackState(true);

			var splashParam = skill.GetSplashParameters(caster, originPos, farPos, length: 75, width: 20, angle: 0);
			var splashArea = skill.GetSplashArea(SplashType.Square, splashParam);

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);

			// TODO: Log and implement ability "[Arts] Thrust: Charge"

			skill.Run(this.Attack(skill, caster, splashArea));
		}

		/// <summary>
		/// Executes the actual attack after a delay.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="splashArea"></param>
		private async Task Attack(Skill skill, ICombatEntity caster, ISplashArea splashArea)
		{
			// For monster skills the delay until the attack occurs
			// appears to be be the hit delay, but while the hit delay
			// for Thrust is 200, the packets look more like a 50~100ms
			// delay. However, the hit comes too early with either value
			// on Melia. One value that appears to work well is 300ms,
			// so we'll use that for now.
			// 
			// Update: I don't know what changed, but testing this again
			// a while later, the Time value found in the ByTool data,
			// 70ms, now seems to work perfectly. It also fits the packet
			// logs, so we'll switch to that.

			var attackTime = TimeSpan.FromMilliseconds(70);
			var aniTime = TimeSpan.FromMilliseconds(270);
			var hitDelay = skill.Properties.HitDelay;

			await skill.Wait(attackTime);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			var hits = new List<SkillHitInfo>();

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var skillHitResult = SCR_SkillHit(caster, target, skill);
				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, aniTime, hitDelay);

				skillHit.ApplyDamage();
				skillHit.ApplyKnockBack();

				hits.Add(skillHit);
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);
		}
	}
}
