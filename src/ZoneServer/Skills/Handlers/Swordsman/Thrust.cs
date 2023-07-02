using System;
using System.Collections.Generic;
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
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Swordsman
{
	/// <summary>
	/// Handler for the Swordsman skill Thrust.
	/// </summary>
	[SkillHandler(SkillId.Swordman_Thrust)]
	public class Thrust : IGroundSkillHandler
	{
		/// <summary>
		/// Handles skill, damaging targets.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity target)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.Components.Get<CombatComponent>().SetAttackState(true);

			// Get splash area
			// It's currently unknown where exactly these values are coming
			// from. The width might be skill.SkillSR, but nothing matches
			// the presumed height of 60. WaveLength is 40, and there's
			// a client file that lists a length value of 50, but neither
			// seems quite right, so we'll hardcode it for now, making it
			// a bit higher than a normal attack a bit narrower.
			var splashAreaHeight = 60;
			var splashAreaWidth = 14;

			// We'll ignore the data sent by the client and get the
			// positions ourselves, because players are dirty cheaters
			// who can't be trusted.
			originPos = caster.Position;
			farPos = originPos.GetRelative(caster.Direction, splashAreaHeight);

			var splashArea = new Square(originPos, caster.Direction, splashAreaHeight, splashAreaWidth);

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);

			this.Attack(skill, caster, splashArea);
		}

		/// <summary>
		/// Executes the actual attack after a delay.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="splashArea"></param>
		private async void Attack(Skill skill, ICombatEntity caster, ISplashArea splashArea)
		{
			// For monster skills the delay until the attack occurs
			// appears to be be the hit delay, but while the hit delay
			// for Thrust is 200, the packets look more like a 50~100ms
			// delay. However, the hit comes too early with either value
			// on Melia. One value that appears to work well is 300ms,
			// so we'll use that for now.

			var hitTime = TimeSpan.FromMilliseconds(300);
			var skillHitDelay = TimeSpan.Zero;
			var damageDelay = TimeSpan.FromMilliseconds(270);

			await Task.Delay(hitTime);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			var hits = new List<SkillHitInfo>();

			foreach (var target in targets)
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
