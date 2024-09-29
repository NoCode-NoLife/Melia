using System;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Yggdrasil.Logging;
using static Melia.Shared.Util.TaskHelper;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Archers.Ranger
{
	/// <summary>
	/// Handles the Ranger skill Double Take
	/// </summary>
	/// <remarks>
	/// This skill repurposes the skill id of an earlier skill
	/// called Critical Shot, though the effect is completely different.
	/// </remarks>
	[SkillHandler(SkillId.Ranger_CriticalShot)]
	public class Ranger_CriticalShot : ITargetSkillHandler, ISkillCombatAttackAfterCalcHandler
	{
		/// <summary>
		/// Default skill handler
		/// </summary>
		public void Handle(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			// This skill shouldn't be called this way, since it's actually a passive.
		}

		/// <summary>
		/// Handles the skill, deal damage and knockback.
		/// </summary>
		public async Task Activate(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			if (!caster.TrySpendSp(skill))
			{
				// no message here, the skill just doesn't activate
				return;
			}			

			if (target == null)
			{
				return;
			}

			if (!caster.InSkillUseRange(skill, target))
			{				
				return;
			}

			caster.SetAttackState(true);

			var hitDelay = TimeSpan.FromMilliseconds(500);
			var skillHitDelay = TimeSpan.Zero;
			var cooldownDelay = TimeSpan.FromMilliseconds(100);

			// The reason we delay the cooldown is so it will attack every target
			// if this skill is triggered by an AOE.
			await Task.Delay(cooldownDelay);
			if (!skill.IsOnCooldown)
				skill.IncreaseOverheat();

			await Task.Delay(hitDelay);

			var skillHitResult = SCR_SkillHit(caster, target, skill);
			target.TakeDamage(skillHitResult.Damage, caster);

			var hit = new HitInfo(caster, target, skill, skillHitResult);
			hit.ForceId = ForceId.GetNew();
			hit.ResultType = HitResultType.Unk8;

			Send.ZC_NORMAL.PlayForceEffect(hit.ForceId, caster, caster, target, "I_arrow009_red", 0.7f, "arrow_cast", "F_hit_good", 1, "arrow_blow", "SLOW", 800);
			Send.ZC_HIT_INFO(caster, target, hit);


			// Skill_Bytool suggests it applies this buff,
			// but it's probably from the previous incarnation
			// of the skill as it displays the old icon
			//caster.StartBuff(BuffId.CriticalShot_Buff, skill.Level, 0, TimeSpan.FromSeconds(30), caster);
		}


		/// <summary>
		/// Applies the skill's effect during combat calculations.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="attackerSkill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		public void OnAttackAfterCalc(Skill skill, ICombatEntity attacker, ICombatEntity target, Skill attackerSkill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			// TODO: Change this to be a static method that takes a list of hit targets
			var isRangerAttackSkill = attackerSkill.Id >= SkillId.Ranger_Barrage && attackerSkill.Id <= SkillId.Ranger_BlazingArrow && attackerSkill.Id != SkillId.Ranger_CriticalShot;

			if (isRangerAttackSkill && !skill.IsOnCooldown)
			{
				CallSafe(this.Activate(skill, attacker, target));
			}
		}
	}
}
