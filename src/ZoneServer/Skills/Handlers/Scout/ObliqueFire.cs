using System;
using System.Collections.Generic;
using System.Drawing;
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
		public void Handle(Skill skill, ICombatEntity caster, ICombatEntity designatedTarget)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.TurnTowards(designatedTarget);
			caster.Components.Get<CombatComponent>().SetAttackState(true);

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

			var damageDelay = TimeSpan.FromMilliseconds(200);
			var skillHitDelay = skill.Properties.HitDelay;

			var skillHits = new List<SkillHitInfo>();

			var skillHitResult = SCR_SkillHit(caster, designatedTarget, skill);
			designatedTarget.TakeDamage(skillHitResult.Damage, caster);

			var skillHit = new SkillHitInfo(caster, designatedTarget, skill, skillHitResult, damageDelay, skillHitDelay);
			skillHit.ForceId = ForceId.GetNew();

			skillHits.Add(skillHit);

			var originPos = caster.Position;
			var hits = new List<HitInfo>();
			var splashArea = new Circle(designatedTarget.Position, skill.Data.SplashHeight * 2);
			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			if (targets.Any())
			{
				var targetDistanceDic = new Dictionary<Position, ICombatEntity>();
				var distancesList = new List<Position>();

				foreach (var target in targets)
				{
					if (target != designatedTarget)
					{
						if (!targetDistanceDic.ContainsKey(target.Position))
						{
							targetDistanceDic.Add(target.Position, target);
						}
						
						distancesList.Add(target.Position);
					}
				}

				var nearstTargetDistance = distancesList.OrderByDescending(v2 => GetDistance(designatedTarget.Position, v2)).LastOrDefault();

				var nearstTarget = targetDistanceDic[nearstTargetDistance];

				if (nearstTarget != null)
				{
					var skillHitResultPost = SCR_SkillHit(caster, nearstTarget, skill);
					nearstTarget.TakeDamage(skillHitResultPost.Damage, caster);

					var skillHitPost = new SkillHitInfo(caster, nearstTarget, skill, skillHitResultPost, damageDelay, skillHitDelay);
					skillHitPost.ForceId = ForceId.GetNew();

					skillHits.Add(skillHitPost);
				}
			}

			Send.ZC_SKILL_FORCE_TARGET(caster, designatedTarget, skill, skillHits);
		}

		private static double GetDistance(Position initialPosition, Position mobPosition)
		{
			return Math.Sqrt(Math.Pow((mobPosition.X - initialPosition.X), 2) + Math.Pow((mobPosition.Y - initialPosition.Y), 2));
		}
	}
}
