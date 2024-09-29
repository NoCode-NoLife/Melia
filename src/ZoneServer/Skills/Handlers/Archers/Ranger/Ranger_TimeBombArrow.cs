using System;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
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

			CallSafe(this.PlaceBomb(skill, caster, target, skillHitResult.Damage));
		}


		public async Task PlaceBomb(Skill skill, ICombatEntity caster, ICombatEntity target, float damage)
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

			target.StartBuff(BuffId.TimeBombArrow_Debuff, bombSize, damage * bombDamageMultiplier, bombDuration, caster);
		}
	}
}
