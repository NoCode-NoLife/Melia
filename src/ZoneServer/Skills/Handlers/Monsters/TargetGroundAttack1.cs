using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Melia.Shared.Data.Database;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Monsters
{
	/// <summary>
	/// Handles default monster skills that target the ground around
	/// a target.
	/// </summary>
	[SkillHandler(SkillUseType.TargetGround, "^Mon_")]
	public class TargetGroundAttack1 : ITargetSkillHandler
	{
		// It's currently not clear whether we'll be able to handle all
		// target ground monster skills in one handler or whether we'll
		// need dedicated handlers, but chances are that most of them
		// will essentially be the same, so we'll start with one handler.

		/// <summary>
		/// Uses skill on target.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		public void Handle(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, target.Position, null);

			var originPos = caster.Position;
			var direction = caster.Position.GetDirection(target.Position);
			var splashArea = skill.GetSplashArea(originPos, direction);

			this.Attack(skill, caster, splashArea);
		}

		/// <summary>
		/// Executes the actual attack after a potential delay.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="splashArea"></param>
		private async void Attack(Skill skill, ICombatEntity caster, ISplashArea splashArea)
		{
			var hitTime = skill.Data.HitTime.First();
			var skillHitDelay = skill.Data.DefaultHitDelay;
			var damageDelay = hitTime + skillHitDelay;

			// It seems like some skills run on a timer, such as
			// Onion_Attack1. This skill gets initiated, but the
			// hit info is only sent after a second passed. Given
			// that you can move out of harms way with that particular
			// skill, I assume the target finding happens after the
			// delay, when the poison cloud animation appears.
			if (hitTime > TimeSpan.Zero)
				await Task.Delay(hitTime);

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
	}
}
