using System;
using Melia.Shared.Tos.Const;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.General
{
	/// <summary>
	/// Targeted skill handler implmentation when the client provides a target
	/// </summary>
	public class TargetSkillHandler : ITargetSkillHandler
	{
		public void Handle(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			if (skill.SpendSp > 0)
				caster.Properties.Modify(PropertyName.SP, -skill.SpendSp);

			skill.IncreaseOverheat();

			if (target == null)
			{
				Send.ZC_SKILL_FORCE_TARGET(caster, null, skill, 0, null);
				return;
			}

			var damage = SCR_GetRandomAtk(caster, null, skill);
			target.TakeDamage(damage, caster);

			var skillHitInfo = new SkillHitInfo(caster, target, skill, damage, TimeSpan.FromMilliseconds(500), TimeSpan.FromMilliseconds(100));
			Send.ZC_SKILL_FORCE_TARGET(caster, target, skill, 0, new[] { skillHitInfo });

			if (target.IsDead)
				Send.ZC_SKILL_CAST_CANCEL(caster);
		}
	}
}
