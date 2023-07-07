using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Melia.Shared.Data.Database;
using Melia.Shared.Tos.Const;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Base
{
	/// <summary>
	/// Base class for simple monster attack skills.
	/// </summary>
	public class SimpleMonsterAttackSkill : ITargetSkillHandler
	{
		/// <summary>
		/// Uses skill on target.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		public void Handle(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			this.Attack(skill, caster, target);
		}

		/// <summary>
		/// Executes the actual attack after a potential delay.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		private async void Attack(Skill skill, ICombatEntity caster, ICombatEntity designatedTarget)
		{
			var splashArea = this.GetSplashArea(skill, caster, designatedTarget);
			var damageDelay = this.GetDamageDelay(skill);
			var hitDelay = this.GetHitDelay(skill);
			var skillHitDelay = skill.Properties.HitDelay;

			Send.ZC_SKILL_MELEE_GROUND(caster, skill, designatedTarget.Position, null);

			// Some skills are running on a timer, such as Onion_Attack1.
			// These skills get initiated, but the hit info is only sent
			// after a certain amount of time passed. This allows the
			// target to move out of harms way before the skill hits,
			// such as with the poison cloud in the Kepa attack skill.

			if (hitDelay > TimeSpan.Zero)
				await Task.Delay(hitDelay);

			// Check if attacker is still able to fight after the delay
			if (!caster.CanFight())
				return;

			Debug.ShowShape(caster.Map, splashArea, edgePoints: false);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			var hits = new List<SkillHitInfo>();

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var skillHitResult = SCR_SkillHit(caster, target, skill);
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
				hits.Add(skillHit);
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);
		}

		/// <summary>
		/// Returns the hit delay, defining the time until the hit
		/// is executed. This adds an actual wait time in the skill
		/// processing.
		/// </summary>
		/// <param name="skill"></param>
		/// <returns></returns>
		protected virtual TimeSpan GetHitDelay(Skill skill)
		{
			return skill.Data.DefaultHitDelay;
		}

		/// <summary>
		/// Returns the delay until the damage is dealt visually.
		/// </summary>
		/// <param name="skill"></param>
		/// <returns></returns>
		protected virtual TimeSpan GetDamageDelay(Skill skill)
		{
			var hitTime = skill.Data.HitTime.First();
			var skillHitDelay = skill.Data.DefaultHitDelay;
			var damageDelay = hitTime + skillHitDelay;

			return damageDelay;
		}

		/// <summary>
		/// Returns the splash area to use to find targets.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		/// <returns></returns>
		protected virtual ISplashArea GetSplashArea(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			var originPos = caster.Position;
			var direction = caster.Position.GetDirection(target.Position);

			ISplashArea splashArea;
			switch (skill.Data.SplashType)
			{
				default:
				case SplashType.Square:
				{
					var height = skill.Properties.GetFloat(PropertyName.SplHeight);
					var width = skill.Properties.GetFloat(PropertyName.SplRange);

					splashArea = new Square(originPos, direction, height, width);
					break;
				}
				case SplashType.Circle:
				{
					var radius = skill.Data.SplashHeight;

					splashArea = new Circle(originPos, radius);
					break;
				}
				case SplashType.Fan:
				{
					var height = skill.Properties.GetFloat(PropertyName.SplHeight);
					var angle = skill.Properties.GetFloat(PropertyName.SplAngle);

					splashArea = new Fan(originPos, direction, height, angle);
					break;
				}
			}

			return splashArea;
		}
	}
}
