using System;
using System.Threading.Tasks;
using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Components;
using static Melia.Shared.Util.TaskHelper;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Archers.Ranger
{
	/// <summary>
	/// Handles the Ranger skill Blazing Shot
	/// </summary>
	[SkillHandler(SkillId.Ranger_BlazingArrow)]
	public class Ranger_BlazingArrow : ITargetSkillHandler
	{
		public const float JumpDistance = 24.914738f;

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
			
			CallSafe(this.Attack(skill, caster, target));
		}

		/// <summary>
		/// Performs the actual attack
		/// </summary>
		public async Task Attack(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			var animationDelay = TimeSpan.FromMilliseconds(250);
			var skillHitDelay = TimeSpan.Zero;

			var modifier = SkillModifier.MultiHit(4);

			var isIceVariant = false;
			var animationName = "I_archer_dividedarrow_force_fire";

			if (caster.IsAbilityActive(AbilityId.Ranger38))
			{
				isIceVariant = true;
				modifier.OverrideAttribute = SkillAttribute.Ice;
				modifier.DamageMultiplier -= 0.3f;
				animationName = "I_arrow003_blue";
			}

			Send.ZC_SKILL_MELEE_GROUND(caster, skill, target.Position, null);

			await Task.Delay(animationDelay);

			var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
			target.TakeDamage(skillHitResult.Damage, caster);

			var hit = new HitInfo(caster, target, skill, skillHitResult);
			hit.ForceId = ForceId.GetNew();
			hit.ResultType = HitResultType.Unk8;

			Send.ZC_NORMAL.PlayForceEffect(hit.ForceId, caster, caster, target, animationName, 0.7f, "arrow_cast", "F_hit_good", 1, "arrow_blow", "SLOW", 800);
			Send.ZC_HIT_INFO(caster, target, hit);

			// If the target has Scan, it is removed, but the cooldown is cut
			// by 15 seconds
			if (target.IsBuffActive(BuffId.Ranger_Scan_Debuff))
			{
				target.StopBuff(BuffId.Ranger_Scan_Debuff);
				skill.ReduceCooldown(TimeSpan.FromSeconds(15));
			}

			if (isIceVariant)
			{
				var duration = TimeSpan.FromSeconds(3);
				target.StartBuff(BuffId.Freeze, skill.Level, 0, duration, caster);
			}

			var jumpDelay = TimeSpan.FromMilliseconds(100);
			await Task.Delay(jumpDelay);

			var targetPos = caster.Position.GetRelative(caster.Direction.Backwards, JumpDistance);
			targetPos = caster.Map.Ground.GetLastValidPosition(caster.Position, targetPos);

			caster.Position = targetPos;
			Send.ZC_NORMAL.LeapJump(caster, targetPos, 0.1f, 0.1f, 1f, 0.2f, 1f, 5);

			Ranger_CriticalShot.TryActivateDoubleTake(skill, caster, target);
			Ranger_CriticalShot.TryReduceCooldown(skill, caster, skillHitResult);

			caster.StartBuff(BuffId.Ranger_StrapingShot, skill.Level, 0, TimeSpan.FromSeconds(3), caster);
		}
	}
}
