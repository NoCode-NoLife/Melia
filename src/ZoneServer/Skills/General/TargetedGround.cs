using System.Collections.Generic;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Skills.General
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

			var damage = caster.GetRandomAtk(skill);

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
