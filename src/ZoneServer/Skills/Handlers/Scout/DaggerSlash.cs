using System;
using System.Collections.Generic;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;
using static Melia.Zone.Skills.SkillUseFunctions;
using System.Threading.Tasks;
using Melia.Shared.Data.Database;

namespace Melia.Zone.Skills.Handlers.Scout
{
	/// <summary>
	/// Handler for the Scout skill Dagger Slash.
	/// </summary>
	[SkillHandler(SkillId.Scout_DaggerSlash)]
	public class DaggerSlash : IGroundSkillHandler
	{
		/// <summary>
		/// Handles skill, do a slash attack to the nearby enemies.
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
			caster.TurnTowards(designatedTarget);
			caster.SetAttackState(true);

			var splashParam = skill.GetSplashParameters(caster, originPos, farPos, length: 55, width: 30, angle: 0);
			var splashArea = skill.GetSplashArea(SplashType.Square, splashParam);

			var buffDuration = TimeSpan.FromSeconds(2);
			caster.StartBuff(BuffId.DaggerSlash_Buff, skill.Level, 0, buffDuration, caster);

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);

			this.Attack(skill, caster, splashArea, farPos);
		}

		/// <summary>
		/// Executes the actual attack after a delay.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="splashArea"></param>
		private async void Attack(Skill skill, ICombatEntity caster, ISplashArea splashArea, Position farPos)
		{
			var damageDelay = TimeSpan.FromMilliseconds(90);
			var skillHitDelay = TimeSpan.Zero;
			var hitDelay = TimeSpan.FromMilliseconds(100);

			var hits = new List<SkillHitInfo>();
			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var skillHitResult = SCR_SkillHit(caster, target, skill);
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
				hits.Add(skillHit);
			}

			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, hits);

			await Task.Delay(hitDelay);

			// Based on the packets this delay is more like 270, but that
			// just doesn't look right for unknown reasons, so we'll use
			// 370 for now.
			damageDelay = TimeSpan.FromMilliseconds(370);
			hits.Clear();

			foreach (var target in targets)
			{
				var skillHitResult = SCR_SkillHit(caster, target, skill);
				var damage = skillHitResult.Damage;

				target.TakeDamage(damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
				hits.Add(skillHit);
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);
		}
	}
}
