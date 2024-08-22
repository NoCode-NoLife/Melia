using System;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Archers.Wugushi
{
	/// <summary>
	/// Handler for the Wugushi skill Wugong Gu.
	/// </summary>
	[SkillHandler(SkillId.Wugushi_WugongGu)]
	public class Wugushi_WugongGu : ITargetSkillHandler
	{
		/// <summary>
		/// Handles skill, damages targets and apply a debuff.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		public void Handle(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			if (target == null)
			{
				Send.ZC_NORMAL.Skill_42(caster, skill.Id, caster.Direction, ForceId.GetNew());
				Send.ZC_NORMAL.UpdateSkillEffect(caster, 0, caster.Position, caster.Direction, Position.Zero);
				Send.ZC_SKILL_FORCE_TARGET(caster, null, skill, null);
				Send.ZC_NORMAL.Skill_43(caster);
				return;
			}

			caster.TurnTowards(target.Position);

			var damageDelay = TimeSpan.FromMilliseconds(600);

			var damageMultiplier = 1f;

			if (caster.TryGetBuff(BuffId.Zhendu_Buff, out var buff))
				damageMultiplier = buff.NumArg1;

			var skillHitResult = SCR_SkillHit(caster, target, skill);
			skillHitResult.Damage *= damageMultiplier;
			target.TakeDamage(skillHitResult.Damage, caster);

			var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, TimeSpan.Zero);
			skillHit.ForceId = ForceId.GetNew();

			Send.ZC_SKILL_READY(caster, skill, caster.Position, caster.Position);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, target.Handle, caster.Position, caster.Direction, target.Position);
			Send.ZC_SKILL_FORCE_TARGET(caster, target, skill, skillHit);

			target.StartBuff(BuffId.Virus_Debuff, skill.Level, (int)skill.Id, TimeSpan.FromSeconds(10), caster);
		}
	}
}
