using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Yggdrasil.Extensions;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Wizards.Wizard
{
	/// <summary>
	/// Handles the Wizard skill Magic Missile.
	/// </summary>
	[SkillHandler(SkillId.Wizard_MagicMissile)]
	public class Wizard_MagicMissile : IGroundSkillHandler
	{
		private const int BulletsPerUse = 3;
		private const float SubSplashAreaSize = 200;

		/// <summary>
		/// Handles the skill, shooting missiles at enemies.
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

			var splashParam = skill.GetSplashParameters(caster, originPos, farPos, length: 130, width: 60, angle: 0);
			var splashArea = skill.GetSplashArea(SplashType.Square, splashParam);
			var mainTargets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			var aniTime = TimeSpan.FromMilliseconds(50);
			var hitDelay = skill.Properties.HitDelay;

			var mainHits = new List<SkillHitInfo>();
			var subHits = new List<HitInfo>();

			if (mainTargets.Any())
			{
				for (var i = 0; i < BulletsPerUse; ++i)
				{
					var target = mainTargets.Random();

					var skillHitResult = SCR_SkillHit(caster, target, skill);
					var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, aniTime, hitDelay);

					skillHit.ApplyDamage();
					skillHit.ApplyKnockBack();

					mainHits.Add(skillHit);
				}
			}

			foreach (var mainHit in mainHits)
			{
				var sourceTarget = mainHit.Target;

				// Not sure about this sub splash area, but it feels alright.
				// And while it seems rather large, you can actually observe
				// ricochet bullets going pretty far, so it can't be off by
				// too much.
				var subSplashArea = Square.Centered(sourceTarget.Position, caster.Direction, SubSplashAreaSize, SubSplashAreaSize / 2);
				var subTargets = caster.Map.GetAttackableEntitiesIn(caster, subSplashArea).Where(a => a != sourceTarget);

				if (!subTargets.Any())
					continue;

				var richochetBulletsPerHit = mainTargets.Count - 1;

				for (var i = 0; i < richochetBulletsPerHit; ++i)
				{
					var subTarget = subTargets.Random();

					var skillHitResult = SCR_SkillHit(caster, subTarget, skill);
					var subHit = new SkillHitInfo(caster, subTarget, skill, skillHitResult, TimeSpan.Zero, TimeSpan.Zero);

					subHit.ApplyDamage();
					subHit.ApplyKnockBack();

					subHits.Add(subHit.HitInfo);

					Send.ZC_NORMAL.PlayForceEffect(subHit.ForceId, caster, sourceTarget, subTarget, "I_force001_yellow", 1, "arrow_cast", "I_explosion004_yellow", 1, "arrow_blow", "SLOW", 150);
				}
			}

			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, mainHits);

			foreach (var hit in subHits)
				Send.ZC_HIT_INFO(hit);
		}
	}
}
