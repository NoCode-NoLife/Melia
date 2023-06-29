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
			skillHit.ForceId = ForceId.GetNew();

			Send.ZC_SKILL_READY(caster, skill, caster.Position, caster.Position);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, caster.Position, null);
			Send.ZC_SKILL_FORCE_TARGET(caster, designatedTarget, skill, skillHit);

			// It has 50% of being giving slow of 7 seconds to the target enemy			
			Random random = new Random();
			bool shouldExecute = random.Next(2) == 0;
						
			if (shouldExecute)
			{
				// TODO: make the enemy show the slow emoticon
				designatedTarget.Components.Get<BuffComponent>().Start(BuffId.Common_Slow, skill.Level, 0, TimeSpan.FromSeconds(7), designatedTarget);
			}

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

				Send.ZC_HIT_INFO(caster, nearestTarget, skill, hit);
			}
		}
	}
}
