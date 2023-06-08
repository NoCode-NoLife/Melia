using System;
using System.Collections.Generic;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Skills.Handlers.General
{
	/// <summary>
	/// Generic handler for melee ground skills.
	/// </summary>
	[SkillHandler(SkillId.Normal_Attack)]
	public class MeleeGroundSkillHandler : IMeleeGroundSkillHandler
	{
		public void Handle(Skill skill, ICombatEntity caster, Position castPosition, Position targetPosition, IList<ICombatEntity> targets)
		{
			if (skill.SpendSp > 0)
				caster.Properties.Modify(PropertyName.SP, -skill.SpendSp);

			skill.IncreaseOverheat();

			var hits = new List<SkillHitInfo>();
			var anyDead = false;

			var damage = caster.GetRandomAtk(skill);

			foreach (var target in targets)
			{
				if (target.TakeDamage(damage, caster))
					anyDead = true;

				var skillHitInfo = new SkillHitInfo(caster, target, skill, damage, TimeSpan.FromMilliseconds(306), TimeSpan.FromMilliseconds(50));
				hits.Add(skillHitInfo);
			}

			Send.ZC_SKILL_MELEE_GROUND(caster, skill, targetPosition, null);
			Send.ZC_SKILL_HIT_INFO(caster, hits);

			if (anyDead)
				Send.ZC_SKILL_CAST_CANCEL(caster);
		}
	}
}
