using System.Collections.Generic;
using Melia.Channel.Network;
using Melia.Channel.Skills.Base;
using Melia.Channel.World;
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

			if (skill.Data.Overheat != 0)
				skill.OverheatCounter++;

			Send.ZC_OVERHEAT_CHANGED(caster, skill);

			if (!skill.CanOverheat || skill.IsOverheated)
			{
				Send.ZC_COOLDOWN_CHANGED(caster, skill);
				skill.ResetOverheat();
			}

			var damage = caster.GetRandomPAtk() + 100;

			Send.ZC_SKILL_MELEE_GROUND(caster, skill, targetPosition, null, 0);

			foreach (var target in targets)
			{
				var monster = (Monster)target;
				if (monster.TakeDamage(damage, caster, DamageVisibilityModifier.Skill, 0))
					Send.ZC_SKILL_CAST_CANCEL(caster, target);
			}
		}
	}
}
