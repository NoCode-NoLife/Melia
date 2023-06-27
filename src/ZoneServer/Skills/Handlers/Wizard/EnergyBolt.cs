using System;
using System.Collections.Generic;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Wizard
{
	/// <summary>
	/// Handler for the Wizard skill Energy Bolt.
	/// </summary>
	[SkillHandler(SkillId.Wizard_EnergyBolt)]
	public class EnergyBolt : ITargetSkillHandler
	{
		/// <summary>
		/// Handles the skill, attacking the targets.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		public void Handle(Skill skill, ICombatEntity caster, ICombatEntity designatedTarget)
		{
			if (designatedTarget == null)
			{
				Send.ZC_SKILL_FORCE_TARGET(caster, null, skill, null);
				return;
			}

			if (!caster.Position.InRange2D(designatedTarget.Position, skill.Data.MaxRange))
			{
				caster.ServerMessage(Localization.Get("Too far away."));
				return;
			}

			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.Components.Get<CombatComponent>().SetAttackState(true);

			var damageDelay = TimeSpan.FromMilliseconds(550);
			var skillHitDelay = TimeSpan.FromMilliseconds(100);

			var splashArea = new Circle(designatedTarget.Position, skill.Data.SplashRange);
			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			var skillHits = new List<SkillHitInfo>();

			foreach (var target in targets)
			{
				var skillHitResult = SCR_SkillHit(caster, target, skill);
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
				skillHit.ForceId = ForceId.GetNew();

				skillHit.KnockBackInfo = new KnockBackInfo(caster.Position, target.Position, 150);
				skillHit.HitInfo.Type = HitType.KnockBack;
				target.Position = skillHit.KnockBackInfo.ToPosition;

				skillHits.Add(skillHit);
			}

			Send.ZC_SKILL_FORCE_TARGET(caster, designatedTarget, skill, skillHits);
		}
	}
}
