using System;
using System.Linq;
using Melia.Shared.Data;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Scouts.BulletMaker
{
	/// <summary>
	/// Handles the Bullet Maker's skill Mozambique Drill.
	/// </summary>
	[SkillHandler(SkillId.Bulletmarker_MozambiqueDrill)]
	public class Bulletmarker_MozambiqueDrill : ITargetSkillHandler
	{
		/// <summary>
		/// Handles the skill, shoots with the pistol at the target enemy.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		public void Handle(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			// Mozambique Drill: Ricochet
			if (caster.IsAbilityActive(AbilityId.Bulletmarker10))
			{
				// Increase SP Consumption by 30%
				var spendSp = skill.Properties.GetFloat(PropertyName.SpendSP) * 0.3f;
				if (!caster.TrySpendSp(spendSp))
					return;
			}

			// Mozambique Drill: Ignore Defense
			if (caster.IsAbilityActive(AbilityId.Bulletmarker9))
			{
				// Increase SP Consumption by 30%
				var spendSp = skill.Properties.GetFloat(PropertyName.SpendSP) * 0.3f;
				if (!caster.TrySpendSp(spendSp))
					return;
			}

			if (!caster.IsBuffActive(BuffId.DoubleGunStance_Buff))
				return;

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

			Send.ZC_SKILL_READY(caster, skill, caster.Position, target.Position);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, caster.Position, caster.Direction, Position.Zero);

			// Increase by one the stack count for Overheating buff
			if (!caster.IsBuffActive(BuffId.Outrage_Buff))
				caster.StartBuff(BuffId.Overheating_Buff, TimeSpan.FromSeconds(35));

			var skillHit = this.GetSkillHitInfo(caster, target, skill);
			Send.ZC_SKILL_FORCE_TARGET(caster, target, skill, skillHit);

			// Mozambique Drill: Ricochet
			if (caster.IsAbilityActive(AbilityId.Bulletmarker10))
			{
				if (this.TryGetRicochetTarget(caster, target, skill, out var ricochetTarget))
				{
					var skillHitResult = SCR_SkillHit(caster, ricochetTarget, skill);
					ricochetTarget.TakeDamage(skillHitResult.Damage, caster);

					var hit = new HitInfo(caster, target, skill, skillHitResult);
					hit.ForceId = ForceId.GetNew();
					hit.ResultType = HitResultType.Hit;

					Send.ZC_HIT_INFO(caster, ricochetTarget, hit);
				}
			}
		}

		/// <summary>
		/// Get a new HitInfo
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <returns></returns>
		private SkillHitInfo GetSkillHitInfo(ICombatEntity caster, ICombatEntity target, Skill skill)
		{
			var damageDelay = TimeSpan.FromMilliseconds(328);
			var skillHitDelay = TimeSpan.FromMilliseconds(100);
			var modifier = SkillModifier.Default;
			modifier.HitCount = 2;

			if (caster.IsAbilityActive(AbilityId.Bulletmarker9))
				modifier.DefensePenetrationRate = this.GetIgnoreDefenseRatio(caster);

			var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);

			if (caster.TryGetBuff(BuffId.Outrage_Buff, out var outrageBuff))
			{
				if (outrageBuff.OverbuffCounter > 0)
				{
					caster.Components.Get<BuffComponent>().Overbuff(outrageBuff, -1);
					// Increase the HitCount by one
					modifier.HitCount += 1;

					skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
					// Decreases the Damage by 22.5%
					skillHitResult.Damage *= 0.775f;
					target.TakeDamage(skillHitResult.Damage, caster);

					return new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
				}
			}

			target.TakeDamage(skillHitResult.Damage, caster);

			return new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
		}

		/// <summary>
		/// Returns the closest target to the main target to ricochet the attack off to.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="mainTarget"></param>
		/// <param name="skill"></param>
		/// <param name="ricochetTarget"></param>
		/// <returns></returns>
		private bool TryGetRicochetTarget(ICombatEntity caster, ICombatEntity mainTarget, Skill skill, out ICombatEntity ricochetTarget)
		{
			var splashPos = caster.Position;
			var splashRadius = 50;
			var splashArea = new Circle(mainTarget.Position, splashRadius);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			if (!targets.Any())
			{
				ricochetTarget = null;
				return false;
			}

			ricochetTarget = targets.GetClosest(mainTarget.Position, a => a != mainTarget);
			return ricochetTarget != null;
		}

		/// <summary>
		/// Returns the Ignore Defense Ratio once 'Mozambique Drill: Ignore Defense' is enabled
		/// </summary>
		/// <param name="caster"></param>
		/// <returns></returns>
		private float GetIgnoreDefenseRatio(ICombatEntity caster)
		{
			if (caster.TryGetAbility(AbilityId.Bulletmarker9, out var ability))
			{
				return (ability.Level * 2) / 2;
			}

			return 0;
		}
	}
}
