using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Yggdrasil.Logging;
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
		/// Places the bomb on the target
		/// </summary>
		public async Task PlaceBomb(Skill skill, ICombatEntity caster, ICombatEntity target, SkillHitResult skillHitResult)
		{
			// We delay the debuff to sync with the animation
			var bombDelay = TimeSpan.FromMilliseconds(500);
			await Task.Delay(bombDelay);

			// need to calculate the bomb damage and fuse ahead of time
			var bombSize = 0.75f;
			var bombDamageMultiplier = 2f;
			var bombDuration = TimeSpan.FromSeconds(2);

			// Ranger36 doubles the duration of the fuse for double damage
			if (caster.IsAbilityActive(AbilityId.Ranger36))
			{
				bombSize = 1f;
				bombDamageMultiplier = 4f;
				bombDuration = TimeSpan.FromSeconds(4);
			}

			target.StartBuff(BuffId.TimeBombArrow_Debuff, bombSize, skillHitResult.Damage * bombDamageMultiplier, bombDuration, caster);

			Ranger_CriticalShot.TryActivateDoubleTake(skill, caster, target);
			Ranger_CriticalShot.TryReduceCooldown(skill, caster, skillHitResult);
			Ranger_Strafe.TryApplyStrafeBuff(caster);
		}


		/// <summary>
		/// Handles the bomb explosion
		/// </summary>
		public static void BombBlast(Skill skill, ICombatEntity caster, ICombatEntity target, float bombDamageMultiplier)
		{
			var splashArea = new Circle(target.Position, 45);

			var damageDelay = TimeSpan.FromMilliseconds(50);
			var skillHitDelay = TimeSpan.Zero;

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			
			// Cannot hit the target that had the bomb
			if (targets.Contains(target))
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
