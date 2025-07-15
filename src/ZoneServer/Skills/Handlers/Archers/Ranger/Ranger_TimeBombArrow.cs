using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using static Melia.Shared.Util.TaskHelper;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Archers.Ranger
{
	/// <summary>
	/// Handles the Ranger skill Time Bomb Arrow.
	/// </summary>
	[SkillHandler(SkillId.Ranger_TimeBombArrow)]
	public class Ranger_TimeBombArrow : ITargetSkillHandler
	{
		/// <summary>
		/// Handles the skill
		/// </summary>
		public void Handle(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.TurnTowards(target);
			caster.SetAttackState(true);

			if (target == null)
			{
				Send.ZC_SKILL_FORCE_TARGET(caster, null, skill, null);
				return;
			}

			if (!caster.InSkillUseRange(skill, target))
			{
				caster.ServerMessage(Localization.Get("Too far away."));
				Send.ZC_SKILL_FORCE_TARGET(caster, null, skill, null);
				return;
			}

			var damageDelay = TimeSpan.FromMilliseconds(45);
			var skillHitDelay = TimeSpan.Zero;

			var skillHitResult = SCR_SkillHit(caster, target, skill);
			target.TakeDamage(skillHitResult.Damage, caster);

			var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
			skillHit.ForceId = ForceId.GetNew();

			Send.ZC_SKILL_FORCE_TARGET(caster, target, skill, skillHit);

			if (!target.IsDead && skillHitResult.Result != HitResultType.Dodge)
				CallSafe(this.PlaceBomb(skill, caster, target, skillHitResult));
		}

		/// <summary>
		/// Places the bomb on the target, which will explode after a delay.
		/// </summary>
		public async Task PlaceBomb(Skill skill, ICombatEntity caster, ICombatEntity target, SkillHitResult skillHitResult)
		{
			// We delay the debuff to sync with the animation
			var bombDelay = TimeSpan.FromMilliseconds(500);

			await Task.Delay(bombDelay);

			var bombSize = 0.75f;
			var bombDamageMultiplier = 2f;
			var bombCountdown = TimeSpan.FromSeconds(2);

			// Ranger36 doubles the duration of the fuse for double damage
			if (caster.IsAbilityActive(AbilityId.Ranger36))
			{
				bombSize = 1f;
				bombDamageMultiplier *= 2;
				bombCountdown *= 2;
			}

			target.StartBuff(BuffId.TimeBombArrow_Debuff, bombSize, skillHitResult.Damage * bombDamageMultiplier, bombCountdown, caster);

			Ranger_CriticalShot.TryActivateDoubleTake(skill, caster, target);
			Ranger_CriticalShot.TryReduceCooldown(skill, caster, skillHitResult);
			Ranger_Strafe.TryApplyStrafeBuff(caster);
		}

		/// <summary>
		/// Handles the bomb explosion, hitting the target and nearby targets.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="damage"></param>
		/// <param name="damageMultiplier"></param>
		public static void ExplosionAttack(Skill skill, ICombatEntity attacker, ICombatEntity target, float damage, float damageMultiplier)
		{
			ExplosionTarget(skill, attacker, target, damage, damageMultiplier);
			ExplosionSplash(skill, attacker, target, damageMultiplier);
		}

		/// <summary>
		/// Handles the explosion on the arrow's primary target.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="damage"></param>
		/// <param name="damageMultiplier"></param>
		private static void ExplosionTarget(Skill skill, ICombatEntity attacker, ICombatEntity target, float damage, float damageMultiplier)
		{
			Send.ZC_NORMAL.PlayEffect(target, "F_archer_explosiontrap_hit_explosion", 1);

			// Note that this has to be a skill hit because it has knockdown
			// We do not do the usual calculation though as we already know
			// the damage and it can't miss or crit or anything.
			var skillHitResult = new SkillHitResult();
			skillHitResult.Damage = damage;
			skillHitResult.Result = HitResultType.Hit;
			skillHitResult.HitCount = 1;

			target.TakeDamage(skillHitResult.Damage, attacker);

			var skillHit = new SkillHitInfo(attacker, target, skill, skillHitResult, TimeSpan.FromMilliseconds(200), TimeSpan.Zero);

			if (!attacker.IsAbilityActive(AbilityId.Ranger35))
			{
				// Target gets blown backwards relative to their facing direction,
				// where the bomb was most likely placed. Alternative implementations
				// could be to use the attacker's position, or one relative to where
				// the bomb was placed. The latter would require storing the impact
				// point and could be a little confusing during gameplay. Though it
				// would also be interesting and realistic.
				var explosionPos = target.Position.GetRelative(target.Direction, 2f);

				skillHit.KnockBackInfo = new KnockBackInfo(explosionPos, target.Position, HitType.KnockDown, 150, 60);
				skillHit.ApplyKnockBack(target);
			}

			Send.ZC_SKILL_HIT_INFO(attacker, skillHit);
		}

		/// <summary>
		/// Handles the bomb explosion, hitting nearby targets.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		/// <param name="bombDamageMultiplier"></param>
		private static void ExplosionSplash(Skill skill, ICombatEntity caster, ICombatEntity target, float bombDamageMultiplier)
		{
			var splashArea = new Circle(target.Position, 45);

			var damageDelay = TimeSpan.FromMilliseconds(50);
			var skillHitDelay = TimeSpan.Zero;

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			// Exclude main target from potential splash targets
			targets.Remove(target);

			var results = new List<SkillHitResult>();
			var hits = new List<SkillHitInfo>();

			var blastTargets = targets.LimitRandom(5);

			var hitTargets = new List<ICombatEntity>();
			hitTargets.Add(target);

			foreach (var blastTarget in blastTargets)
			{
				var modifier = SkillModifier.Default;
				modifier.DamageMultiplier = bombDamageMultiplier;

				var skillHitResult = SCR_SkillHit(caster, blastTarget, skill);
				blastTarget.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, blastTarget, skill, skillHitResult, damageDelay, skillHitDelay);
				if (!caster.IsAbilityActive(AbilityId.Ranger35))
				{
					skillHit.KnockBackInfo = new KnockBackInfo(target.Position, blastTarget.Position, HitType.KnockDown, 150, 60);
					skillHit.ApplyKnockBack(blastTarget);
				}

				hitTargets.Add(blastTarget);
				results.Add(skillHitResult);
				hits.Add(skillHit);
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);

			Ranger_CriticalShot.TryActivateDoubleTake(skill, caster, hitTargets);
			Ranger_CriticalShot.TryReduceCooldown(skill, caster, results);
		}
	}
}
