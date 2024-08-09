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

namespace Melia.Zone.Skills.Handlers.Swordsman.Rodelero
{
	/// <summary>
	/// Handler for the Rodelero skill Montano.
	/// </summary>
	[SkillHandler(SkillId.Rodelero_Montano)]
	public class Rodelero_Montano : IGroundSkillHandler
	{
		private readonly static TimeSpan DebuffDuration = TimeSpan.FromSeconds(5);

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

			var splashParam = skill.GetSplashParameters(caster, originPos, farPos, length: 50, width: 35, angle: 0);
			var splashArea = skill.GetSplashArea(SplashType.Square, splashParam);

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);

			this.Attack(skill, caster, splashArea);
		}

		/// <summary>
		/// Executes the actual attack after a delay.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="splashArea"></param>
		private async void Attack(Skill skill, ICombatEntity caster, ISplashArea splashArea)
		{
			var hitDelay = TimeSpan.FromMilliseconds(200);
			var damageDelay = TimeSpan.FromMilliseconds(50);
			var spinDuration = TimeSpan.FromMilliseconds(300);
			var skillHitDelay = TimeSpan.Zero;

			await Task.Delay(hitDelay);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			var hits = new List<SkillHitInfo>();

			var hitTargets = targets.LimitBySDR(caster, skill);

			foreach (var target in hitTargets)
			{
				var modifier = SkillModifier.MultiHit(2);
				modifier.BonusPAtk = Rodelero31.GetBonusPAtk(caster);

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
				skillHit.HitEffect = HitEffect.Impact;
				hits.Add(skillHit);

				//if (caster.Map.IsPvp)
				//	target.StartBuff(BuffId.Common_Slow, skill.Level, 0, DebuffDuration / 2, caster);
				//else
				target.StartBuff(BuffId.Common_Slow, skill.Level, 0, DebuffDuration, caster);
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);

			await Task.Delay(damageDelay);

			foreach (var target in hitTargets)
				Send.ZC_NORMAL.SpinObject(target, 0, 5, 0.2f, 1);

			await Task.Delay(spinDuration);

			// TODO: Is there any way to stop the spin without sending this packet?
			foreach (var target in hitTargets)
				Send.ZC_NORMAL.SpinObject(target, 0, 0, 0, 0);
		}
	}
}
