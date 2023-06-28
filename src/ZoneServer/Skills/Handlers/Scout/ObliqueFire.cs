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
		public void Handle(Skill skill, ICombatEntity caster, ICombatEntity designatedTarget)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.TurnTowards(designatedTarget);

			if (designatedTarget == null)
			{
				return;
			}

			if (!caster.Position.InRange2D(designatedTarget.Position, skill.Data.MaxRange))
			{
				caster.ServerMessage(Localization.Get("Too far away."));
				return;
			}

			this.Attack(skill, caster, designatedTarget);
		}

		/// <summary>
		/// Executes the actual attack.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="designatedTarget"></param>
		private async void Attack(Skill skill, ICombatEntity caster, ICombatEntity designatedTarget)
		{
			var damageDelay = TimeSpan.Zero;
			var skillHitDelay = TimeSpan.Zero;			
			var secondHitTime = TimeSpan.FromMilliseconds(100);

			var skillHitResult = SCR_SkillHit(caster, designatedTarget, skill);
			designatedTarget.TakeDamage(skillHitResult.Damage, caster);

			var skillHit = new SkillHitInfo(caster, designatedTarget, skill, skillHitResult, damageDelay, skillHitDelay);

			designatedTarget.Components.Get<BuffComponent>().Start(BuffId.ObliqueFire_Buff, skill.Level, 0, TimeSpan.FromSeconds(10), designatedTarget);

			Send.ZC_SKILL_FORCE_TARGET(caster, designatedTarget, skill, skillHit);

			await Task.Delay(secondHitTime);

			var originPos = caster.Position;
			var splashArea = new Circle(designatedTarget.Position, skill.Data.SplashHeight * 2);
			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			var nearestTarget = targets.Where(a => a != designatedTarget).OrderBy(a => a.Position.Get2DDistance(designatedTarget.Position)).FirstOrDefault();

			if (nearestTarget != null)
			{
				var skillHitResultPost = SCR_SkillHit(caster, nearestTarget, skill);
				nearestTarget.TakeDamage(skillHitResultPost.Damage, caster);

				var skillHitPost = new SkillHitInfo(caster, nearestTarget, skill, skillHitResultPost, damageDelay, skillHitDelay);
				var hit = new HitInfo(caster, nearestTarget, skill, skillHitResult.Damage, skillHitResult.Result);

				nearestTarget.Components.Get<BuffComponent>().Start(BuffId.ObliqueFire_Buff, skill.Level, 0, TimeSpan.FromSeconds(10), nearestTarget);

				Send.ZC_HIT_INFO(caster, nearestTarget, skill, hit);
			}
		}

		private static double GetDistance(Position initialPosition, Position mobPosition)
		{
			return Math.Sqrt(Math.Pow((mobPosition.X - initialPosition.X), 2) + Math.Pow((mobPosition.Y - initialPosition.Y), 2));
		}
	}
}
