using System;
using System.Linq;
using System.Threading.Tasks;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Yggdrasil.Util;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Archer
{
	/// <summary>
	/// Handles the Archer skill Oblique Shot.
	/// </summary>
	[SkillHandler(SkillId.Archer_ObliqueShot)]
	public class ObliqueFire : ITargetSkillHandler
	{
		/// <summary>
		/// Handles the skill, shoot missile at enemy that spreads to another target.
		/// </summary>
		public void Handle(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.TurnTowards(target);
			caster.SetAttackState(true);

			if (target == null)
			{
				Send.ZC_SKILL_FORCE_TARGET(caster, null, skill, null);
				return;
			}

			if (!caster.InSkillUseRange(skill, target))
			{
				caster.ServerMessage(Localization.Get("Too far away."));
				Send.ZC_SKILL_FORCE_TARGET(caster, null, skill, null);
				return;
			}

			var damageDelay = TimeSpan.FromMilliseconds(45);
			var skillHitDelay = TimeSpan.Zero;

			var skillHitResult = SCR_SkillHit(caster, target, skill);
			target.TakeDamage(skillHitResult.Damage, caster);

			var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
			skillHit.ForceId = ForceId.GetNew();

			Send.ZC_SKILL_FORCE_TARGET(caster, target, skill, skillHit);

			// Random chance to apply Slow debuff	
			if (RandomProvider.Next(100) < 50)
			{
				var duration = TimeSpan.FromSeconds(7);
				target.StartBuff(BuffId.Common_Slow, skill.Level, 0, duration, caster);
			}

			// Bounce shot
			if (this.TryGetBounceTarget(caster, target, skill, out var bounceTarget))
			{
				skillHitResult = SCR_SkillHit(caster, bounceTarget, skill);
				bounceTarget.TakeDamage(skillHitResult.Damage, caster);

				var hit = new HitInfo(caster, target, skill, skillHitResult);
				Send.ZC_HIT_INFO(caster, bounceTarget, skill, hit);
			}
		}

		/// <summary>
		/// Returns the closest target to the main target to bounce the
		/// attack off to.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="mainTarget"></param>
		/// <param name="skill"></param>
		/// <param name="bounceTarget"></param>
		/// <returns></returns>
		private bool TryGetBounceTarget(ICombatEntity caster, ICombatEntity mainTarget, Skill skill, out ICombatEntity bounceTarget)
		{
			var splashPos = caster.Position;
			var splashRadius = 50; // SplashHeight * 2?
			var splashArea = new Circle(mainTarget.Position, splashRadius);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			if (!targets.Any())
			{
				bounceTarget = null;
				return false;
			}

			bounceTarget = targets.Where(a => a != mainTarget).OrderBy(a => a.Position.Get2DDistance(mainTarget.Position)).FirstOrDefault();
			return bounceTarget != null;
		}
	}
}
