using System.Collections.Generic;
using Melia.Channel.Network;
using Melia.Channel.Skills.Base;
using Melia.Channel.World.Entities;
using Melia.Shared.World;

namespace Melia.Channel.Skills.General
{
	/// <summary>
	/// Targeted ground skill implementation when the client provides targets
	/// </summary>
	public class TargetedGroundSkillHandler : ITargetGroundSkillHandler
	{
		public void Handle(Skill skill, Character caster, Position castPosition, Position targetPosition, IEnumerable<ICombatEntity> targets)
		{
			if (skill.SpendSp > 0)
				caster.ModifySp(-skill.SpendSp);

			skill.IncreaseOverheat();

			var damage = caster.GetRandomPAtk() + 100;

			Send.ZC_SKILL_MELEE_GROUND(caster, skill, targetPosition, null, 0);

			foreach (var target in targets)
			{
				target.TakeDamage(damage, caster);
				Send.ZC_SKILL_HIT_INFO(caster, target, damage);

				if (target.IsDead)
					Send.ZC_SKILL_CAST_CANCEL(caster, target);
			}
		}
	}
}
