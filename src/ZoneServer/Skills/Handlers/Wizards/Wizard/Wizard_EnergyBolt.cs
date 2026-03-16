using System;
using System.Collections.Generic;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Wizards.Wizard
{
	/// <summary>
	/// Handler for the Wizard skill Energy Bolt.
	/// </summary>
	[SkillHandler(SkillId.Wizard_EnergyBolt)]
	public class Wizard_EnergyBolt : ITargetSkillHandler
	{
		/// <summary>
		/// Handles the skill, attacking the targets.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		public void Handle(Skill skill, ICombatEntity caster, ICombatEntity designatedTarget)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.TurnTowards(designatedTarget);
			caster.SetAttackState(true);

			if (designatedTarget == null)
			{
				Send.ZC_SKILL_FORCE_TARGET(caster, null, skill, null);
				return;
			}

			if (!caster.InSkillUseRange(skill, designatedTarget))
			{
				caster.ServerMessage(Localization.Get("Too far away."));
				return;
			}

			var aniTime = TimeSpan.FromMilliseconds(50);
			var hitDelay = skill.Properties.HitDelay;

			var splashArea = new Circle(designatedTarget.Position, skill.Properties.GetFloat(PropertyName.SplRange));
			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			var skillHits = new List<SkillHitInfo>();

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var skillHitResult = SCR_SkillHit(caster, target, skill, SkillModifier.MultiHit(2));

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, aniTime, hitDelay);
				skillHit.HitEffect = HitEffect.ImpactHard;

				skillHit.ApplyDamage();
				skillHit.ApplyKnockBack();

				skillHits.Add(skillHit);
			}

			Send.ZC_SKILL_FORCE_TARGET(caster, designatedTarget, skill, skillHits);
		}
	}
}
