using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Melia.Zone.Skills.Handlers.Wizard
{
	/// <summary>
	/// Handles the Wizard skill Magic Missile.
	/// </summary>
	[SkillHandler(SkillId.Wizard_MagicMissile)]
	public class MagicMissile : IGroundSkillHandler
	{
		private const int BulletsPerUse = 3;
		private const int RichochetBulletsPerHit = 1;
		private const float SplashAreaSize = 100;
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
			caster.Components.Get<CombatComponent>().SetAttackState(true);

			var splashArea = new Square(originPos, caster.Direction, SplashAreaSize, SplashAreaSize / 2);
			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			var damageDelay = TimeSpan.FromMilliseconds(50);
			var skillHitDelay = TimeSpan.FromMilliseconds(350);

			Debug.ShowShape(caster.Map, splashArea, edgePoints: false);

			var skillHits = new List<SkillHitInfo>();
			var hits = new List<HitInfo>();

			if (targets.Any())
			{
				for (var i = 0; i < BulletsPerUse; ++i)
				{
					var target = targets.Random();
					var forceId = ForceId.GetNew();

					var damage = SCR_CalculateDamage(caster, target, skill);
					target.TakeDamage(damage, caster);

					var skillHit = new SkillHitInfo(caster, target, skill, damage, damageDelay, skillHitDelay);
					skillHit.ForceId = forceId;
					skillHits.Add(skillHit);

					//Log.Debug("character -> {0}", target.Handle);
				}
			}

			foreach (var skillHit in skillHits)
			{
				var target = skillHit.Target;

				// Not sure about this sub splash area, but... Well, I'm not
				// sure about the main splash area either... Anyway, this is
				// entirely guessed, but it feels alright. And while it
				// seems rather large, you can actually observe ricochet
				// bullets going pretty far, so it can't be off by too
				// much.
				var subSplashArea = Square.Centered(target.Position, caster.Direction, SubSplashAreaSize, SubSplashAreaSize / 2);
				var subTargets = caster.Map.GetAttackableEntitiesIn(caster, subSplashArea).Where(a => a != target);

				Debug.ShowShape(caster.Map, subSplashArea, edgePoints: false);

				if (!subTargets.Any())
					continue;

				for (var i = 0; i < RichochetBulletsPerHit; ++i)
				{
					var subTarget = subTargets.Random();
					var forceId = ForceId.GetNew();

					var damage = SCR_CalculateDamage(caster, subTarget, skill);
					subTarget.TakeDamage(damage, caster);

					var hit = new HitInfo(caster, subTarget, skill, damage, HitResultType.Hit);
					hit.ForceId = forceId;
					hits.Add(hit);

					//Log.Debug("{0} -> {1}", target.Handle, subTarget.Handle);

					Send.ZC_NORMAL.Skill_16(forceId, caster, target, subTarget, "I_force001_yellow", 1, "arrow_cast", "I_explosion004_yellow", 1, "arrow_blow", "SLOW", 150);
				}
			}

			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, skillHits);

			foreach (var hit in hits)
				Send.ZC_HIT_INFO(hit.Attacker, hit.Target, hit.Skill, hit);
		}

		// A shot into a bunch of monsters. The character hit 3 different
		// monsters once and each monster creates at least 3 bullets of
		// its own, hitting other nearby monsters. The numbers are
		// shortened handles.
		// Notably, each original target gets hit 3 times in total. What's
		// still unclear is what "5 Bullets" in the description means.
		// If it were a limit, you would expect more than 4 hits out
		// of 829, because as the first ricochet source it should be
		// able to go up to the max.
		// 
		// character -> 829
		// character -> 805
		// character -> 460
		// 829 -> 460
		// 829 -> 810
		// 829 -> 805
		// 829 -> 460
		// 805 -> 810
		// 805 -> 886
		// 805 -> 829
		// 460 -> 805
		// 460 -> 829
		// 460 -> 810

	}
}
