using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Swordsman.Hoplite
{
	/// <summary>
	/// Handler for the Hoplite skill Long Stride
	/// </summary>
	[SkillHandler(SkillId.Hoplite_LongStride)]
	public class Hoplite_LongStride : IGroundSkillHandler, IDynamicCasted
	{
		public const int MaxDistance = 100;

		/// <summary>
		/// Called when the user starts casting the skill.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		public void StartDynamicCast(Skill skill, ICombatEntity caster)
		{
		}

		/// <summary>
		/// Called when the user stops casting the skill.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		public void EndDynamicCast(Skill skill, ICombatEntity caster)
		{
		}

		/// <summary>
		/// Handles skill, damaging targets.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity target)
		{
			if (!skill.Vars.TryGet<Position>("Melia.ToolGroundPos", out var targetPos))
			{
				caster.ServerMessage(Localization.Get("No target location specified."));
				Send.ZC_SKILL_CAST_CANCEL(caster);
				return;
			}

			if (!caster.Map.Ground.IsValidPosition(targetPos))
			{
				caster.ServerMessage(Localization.Get("Invalid target location."));
				Send.ZC_SKILL_CAST_CANCEL(caster);
				return;
			}

			if ((int)originPos.Get2DDistance(targetPos) > MaxDistance)
			{
				caster.ServerMessage(Localization.Get("Too far."));
				Send.ZC_SKILL_CAST_CANCEL(caster);
				return;
			}

			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			Send.ZC_SKILL_READY(caster, skill, originPos, targetPos);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, targetPos, null);

			Send.ZC_NORMAL.LeapJump(caster, targetPos, 0, 0, 0.5f, 0.7f, 0.7f, 90);
			caster.Position = targetPos;

			this.Attack(skill, caster, new Circle(targetPos.GetRelative(caster.Direction, 15f), 30));
		}

		/// <summary>
		/// Executes the actual attack after a delay.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="splashArea"></param>
		private async void Attack(Skill skill, ICombatEntity caster, ISplashArea splashArea)
		{
			var hitDelay = TimeSpan.FromMilliseconds(800);
			var damageDelay = TimeSpan.FromMilliseconds(50);
			var skillHitDelay = TimeSpan.Zero;
			var afterLandingDelay = TimeSpan.FromMilliseconds(400);

			await Task.Delay(hitDelay);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			var hits = new List<SkillHitInfo>();

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var skillHitResult = SCR_SkillHit(caster, target, skill);
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);

				skillHit.KnockBackInfo = new KnockBackInfo(caster.Position, target.Position, skill);
				skillHit.HitInfo.Type = skill.Data.KnockDownHitType;
				target.Position = skillHit.KnockBackInfo.ToPosition;

				hits.Add(skillHit);

				if (caster.IsAbilityActive(AbilityId.Hoplite30))
					target.StartBuff(BuffId.Stun, skill.Level, 0, TimeSpan.FromSeconds(2), caster);
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);

			// This skill leaves you immobile for significant time after the
			// animation ends, seems to require an extra cast cancel
			await Task.Delay(afterLandingDelay);
			Send.ZC_SKILL_CAST_CANCEL(caster);
		}
	}
}
