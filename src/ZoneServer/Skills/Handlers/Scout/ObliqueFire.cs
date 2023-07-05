using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Yggdrasil.Extensions;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Scout
{
	/// <summary>
	/// Handles the Scout skill Oblique Fire.
	/// </summary>
	[SkillHandler(SkillId.Scout_ObliqueFire)]
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
			caster.Components.Get<CombatComponent>().SetAttackState(true);

			if (target == null)
			{
				Send.ZC_SKILL_FORCE_TARGET(caster, null, skill, null);
				return;
			}

			if (!caster.Position.InRange2D(target.Position, skill.Data.MaxRange))
			{
				caster.ServerMessage(Localization.Get("Too far away."));
				Send.ZC_SKILL_FORCE_TARGET(caster, null, skill, null);
				return;
			}

			caster.Components.Get<BuffComponent>().Start(BuffId.ObliqueFire_Buff, skill.Level, 0, TimeSpan.FromSeconds(10), caster);

			this.Attack(skill, caster, target);
		}

		/// <summary>
		/// Executes the actual attack.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		private async void Attack(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			var damageDelay = TimeSpan.FromMilliseconds(270);
			var skillHitDelay = TimeSpan.Zero;
			var hitDelay = TimeSpan.FromMilliseconds(120);

			var forceId = ForceId.GetNew();
			Send.ZC_SKILL_FORCE_TARGET(caster, target, skill, forceId, null);

			await Task.Delay(hitDelay);

			var applyDebuff = caster.Components.Get<BuffComponent>().GetOverbuffCount(BuffId.ObliqueFire_Buff) > 3;
			if (applyDebuff)
				target.Components.Get<BuffComponent>().Start(BuffId.ObliqueFire_Debuff, skill.Level, 0, TimeSpan.FromSeconds(10), caster);

			var skillHitResult = SCR_SkillHit(caster, target, skill);
			target.TakeDamage(skillHitResult.Damage, caster);

			var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
			skillHit.ForceId = forceId;

			Send.ZC_SKILL_HIT_INFO(caster, skillHit);

			if (this.TryGetBounceTarget(caster, target, skill, out var bounceTarget))
			{
				var skillHitResultPost = SCR_SkillHit(caster, bounceTarget, skill);
				bounceTarget.TakeDamage(skillHitResultPost.Damage, caster);

				var skillHitPost = new SkillHitInfo(caster, bounceTarget, skill, skillHitResultPost, damageDelay, skillHitDelay);
				var hit = new HitInfo(caster, bounceTarget, skill, skillHitResult.Damage, skillHitResult.Result);

				Send.ZC_HIT_INFO(caster, bounceTarget, skill, hit);

				if (applyDebuff)
					bounceTarget.Components.Get<BuffComponent>().Start(BuffId.ObliqueFire_Debuff, skill.Level, 0, TimeSpan.FromSeconds(10), caster);
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
