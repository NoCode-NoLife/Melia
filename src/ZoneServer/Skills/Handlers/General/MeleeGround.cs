using System.Collections.Generic;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
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
