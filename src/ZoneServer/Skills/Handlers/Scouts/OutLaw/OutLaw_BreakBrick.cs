using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Yggdrasil.Util;
using static Melia.Shared.Util.TaskHelper;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Scouts.OutLaw
{
	/// <summary>
	/// Handler for the Assassin skill Brick Smash
	/// </summary>
	[SkillHandler(SkillId.OutLaw_BreakBrick)]
	public class OutLaw_BreakBrick : IGroundSkillHandler
	{
		public const float JumpDistance = 60f;

		/// <summary>
		/// Handles skill
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

			var splashParam = skill.GetSplashParameters(caster, originPos, farPos, length: 90, width: 30, angle: 0);
			var splashArea = skill.GetSplashArea(SplashType.Square, splashParam);

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);

			// Outlaw26 is a totally different attack
			if (caster.IsAbilityActive(AbilityId.Outlaw26))
			{
				// This should set the overheat max to 1

				CallSafe(this.ShatterAttack(skill, caster, farPos));
			}
			else
			{
				CallSafe(this.Attack(skill, caster, splashArea, farPos));
			}
		}

		/// <summary>
		/// Executes the actual attack after a delay.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="splashArea"></param>
		private async Task Attack(Skill skill, ICombatEntity caster, ISplashArea splashArea, Position farPos)
		{
			var rnd = RandomProvider.Get();

			var damageDelay = TimeSpan.FromMilliseconds(50);
			var skillHitDelay = TimeSpan.Zero;
			var hitDelay = TimeSpan.FromMilliseconds(400);

			// First perform the jump
			var targetPos = caster.Position.GetRelative2D(caster.Direction, JumpDistance);
			targetPos = caster.Map.Ground.GetLastValidPosition(caster.Position, targetPos);

			caster.Position = targetPos;
			Send.ZC_NORMAL.LeapJump(caster, targetPos, 0.15f, 0.1f, 1f, 0.2f, 1f, 3);

			// Outlaw4 has a 20% chance to activate.  If it does, it guarantees
			// the stun and makes the attack a forced critical
			var outlaw4Activates = caster.IsAbilityActive(AbilityId.Outlaw4) && rnd.Next(5) == 1;

			await Task.Delay(hitDelay);

			var hits = new List<SkillHitInfo>();
			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var modifier = SkillModifier.MultiHit(6);

				// 30% chance to Stun as base, 100% when behind target
				var stunChance = 3;

				if (caster.IsBehind(target))
					stunChance = 10;

				if (outlaw4Activates)
				{
					stunChance = 10;
					modifier.ForcedCritical = true;
				}

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
				skillHit.HitEffect = HitEffect.Impact;

				hits.Add(skillHit);

				if (rnd.Next(10) <= stunChance)
					target.StartBuff(BuffId.Stun, skill.Level, 0, TimeSpan.FromSeconds(3), caster);

				target.StartBuff(BuffId.BreakBrick_Debuff, skill.Level, 0, TimeSpan.FromSeconds(20), caster);
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);
		}

		/// <summary>
		/// Executes the alternate attack for Outlaw26
		/// It doesn't inflict status but has a bigger range
		/// and does 3 times as many hits
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="splashArea"></param>
		private async Task ShatterAttack(Skill skill, ICombatEntity caster, Position farPos)
		{
			var rnd = RandomProvider.Get();

			var damageDelay = TimeSpan.FromMilliseconds(50);
			var skillHitDelay = TimeSpan.Zero;
			var hitDelay = TimeSpan.FromMilliseconds(250);

			// This version has no jump

			// Outlaw4 has a 20% chance to activate.  If it does, it inflicts
			// stun and forces a critical
			var outlaw4Activates = caster.IsAbilityActive(AbilityId.Outlaw4) && rnd.Next(5) == 1;

			await Task.Delay(hitDelay);

			// This attack uses 3 hitboxes of different shapes, which all hit simultaneously

			var splashParam = skill.GetSplashParameters(caster, caster.Position, farPos, length: 135, width: 30, angle: 0);
			var splashArea = skill.GetSplashArea(SplashType.Square, splashParam);

			var hits = new List<SkillHitInfo>();
			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var modifier = SkillModifier.MultiHit(6);

				// Outlaw4 has a 20% chance to activate.  If it does, it causes
				// a stun and makes the attack a forced critical
				if (outlaw4Activates)
				{
					target.StartBuff(BuffId.Stun, skill.Level, 0, TimeSpan.FromSeconds(3), caster);
					modifier.ForcedCritical = true;
				}

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
				skillHit.HitEffect = HitEffect.Impact;

				hits.Add(skillHit);
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);
			hits.Clear();

			// The second hitbox is identical to the first			

			targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var modifier = SkillModifier.MultiHit(6);

				if (outlaw4Activates)
				{
					modifier.ForcedCritical = true;
				}

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
				skillHit.HitEffect = HitEffect.Impact;

				hits.Add(skillHit);
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);
			hits.Clear();

			// The third hitbox is a fan

			splashParam = skill.GetSplashParameters(caster, caster.Position, farPos, length: 150, width: 100, angle: 78);
			splashArea = skill.GetSplashArea(SplashType.Fan, splashParam);

			targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var modifier = SkillModifier.MultiHit(6);

				if (outlaw4Activates)
				{
					modifier.ForcedCritical = true;
				}

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
				skillHit.HitEffect = HitEffect.Impact;

				hits.Add(skillHit);
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);
		}
	}
}
