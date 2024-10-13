using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using static Melia.Shared.Util.TaskHelper;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Archers.Ranger
{
	/// <summary>
	/// Handles the Ranger skill Double Take.
	/// </summary>
	/// <remarks>
	/// This skill repurposes the skill id of an earlier skill called Critical Shot,
	/// though the effect is completely different.
	/// </remarks>
	[SkillHandler(SkillId.Ranger_CriticalShot)]
	public class Ranger_CriticalShot : ISkillHandler
	{
		/// <summary>
		/// Handles the skill, deal damage and knockback.
		/// </summary>
		public async static Task Activate(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			if (!caster.TrySpendSp(skill))
			{
				// No message here, the skill just doesn't activate.
				return;
			}

			if (target == null)
				return;

			if (!caster.InSkillUseRange(skill, target))
				return;

			// Note that cooldown is set in TryActivateDoubleTake
			//skill.IncreaseOverheat();
			caster.SetAttackState(true);

			var hitDelay = TimeSpan.FromMilliseconds(600);
			var skillHitDelay = TimeSpan.Zero;

			await Task.Delay(hitDelay);

			var skillHitResult = SCR_SkillHit(caster, target, skill);
			target.TakeDamage(skillHitResult.Damage, caster);

			var hit = new HitInfo(caster, target, skill, skillHitResult);
			hit.ForceId = ForceId.GetNew();
			hit.ResultType = HitResultType.Unk8;

			Send.ZC_NORMAL.PlayForceEffect(hit.ForceId, caster, caster, target, "I_arrow009_red", 0.7f, "arrow_cast", "F_hit_good", 1, "arrow_blow", "SLOW", 800);
			Send.ZC_HIT_INFO(caster, target, hit);

			// Can this skill reduce its own cooldown if it crits?
			TryReduceCooldown(skill, caster, skillHitResult);

			// Skill_Bytool suggests it applies this buff,
			// but it's probably from the previous incarnation
			// of the skill as it displays the old icon
			//caster.StartBuff(BuffId.CriticalShot_Buff, skill.Level, 0, TimeSpan.FromSeconds(30), caster);
		}

		/// <summary>
		/// Attempt to activate the skill.  Should be called from
		/// Ranger skills that can fire it.
		/// </summary>
		/// <param name="usedSkill"></param>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		public static void TryActivateDoubleTake(Skill usedSkill, ICombatEntity caster, ICombatEntity target)
		{
			if (!caster.TryGetSkill(SkillId.Ranger_CriticalShot, out var skill))
				return;

			if (skill.IsOnCooldown || target.IsDead)
				return;

			skill.IncreaseOverheat();
			CallSafe(Activate(skill, caster, target));
		}

		/// <summary>
		/// Attempt to activate the skill.  Should be called from
		/// Ranger skills that can fire it.
		/// </summary>
		/// <param name="usedSkill"></param>
		/// <param name="caster"></param>
		/// <param name="targets"></param>
		public static void TryActivateDoubleTake(Skill usedSkill, ICombatEntity caster, System.Collections.Generic.List<ICombatEntity> targets)
		{
			if (!caster.TryGetSkill(SkillId.Ranger_CriticalShot, out var skill))
				return;

			if (skill.IsOnCooldown)
				return;

			var anyTargetsAlive = targets.Any(static a => !a.IsDead);
			if (!anyTargetsAlive)
				return;

			skill.IncreaseOverheat();

			foreach (var target in targets)
			{
				if (!target.IsDead)
					CallSafe(Activate(skill, caster, target));
			}
		}

		/// <summary>
		/// Attempts to reduce the skill's cooldown.  It reduces by 5 seconds
		/// if the user scored a critical hit.
		/// </summary>
		/// <param name="usedSkill"></param>
		/// <param name="caster"></param>
		/// <param name="result"></param>
		public static void TryReduceCooldown(Skill usedSkill, ICombatEntity caster, SkillHitResult result)
		{
			if (!caster.TryGetSkill(SkillId.Ranger_CriticalShot, out var skill))
				return;

			if (!skill.IsOnCooldown)
				return;

			if (result.Result == HitResultType.Crit)
				skill.ReduceCooldown(TimeSpan.FromSeconds(5));
		}

		/// <summary>
		/// Attempts to reduce the skill's cooldown.  It reduces by 5 seconds
		/// if the user scored a critical hit.
		/// </summary>
		/// <param name="usedSkill"></param>
		/// <param name="caster"></param>
		/// <param name="results"></param>
		public static void TryReduceCooldown(Skill usedSkill, ICombatEntity caster, List<SkillHitResult> results)
		{
			if (!caster.TryGetSkill(SkillId.Ranger_CriticalShot, out var skill))
				return;

			if (!skill.IsOnCooldown)
				return;

			foreach (var result in results)
			{
				if (result.Result == HitResultType.Crit)
					skill.ReduceCooldown(TimeSpan.FromSeconds(5));
			}
		}
	}
}
