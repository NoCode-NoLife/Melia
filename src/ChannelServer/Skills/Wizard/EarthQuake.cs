using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Channel.Network;
using Melia.Channel.Skills.Base;
using Melia.Channel.World.Entities;
using Melia.Shared.Const;
using Melia.Shared.World;

namespace Melia.Channel.Skills.Wizard
{
	/// <summary>
	/// Handler for the Wizard skill Earthquake.
	/// </summary>
	[SkillHandler(SkillId.Wizard_EarthQuake)]
	public class EarthQuake : IGroundSkillHandler
	{
		public void Handle(Skill skill, Character caster, Position castPosition, Position targetPosition)
		{
			skill.IncreaseOverheat();
			Send.ZC_SKILL_READY(caster, skill, caster.Position, targetPosition);

			if (skill.SpendSp > 0)
			{
				if (caster.Sp >= skill.SpendSp)
					return;
				caster.ModifySp(-skill.SpendSp);
			}

			Send.ZC_NORMAL_Skill_1D(caster, caster);

			var targets = caster.Map.GetAttackableEntitiesInRange(caster, targetPosition, skill.Data.SplashRange + skill.Data.SplashHeight);
			var damage = (int)(caster.GetRandomPAtk() * skill.Data.SkillFactor / 100f);

			Send.ZC_SKILL_MELEE_GROUND(caster, skill, targetPosition, targets, damage);

			foreach (var target in targets)
			{
				target.TakeDamage(damage, caster, DamageVisibilityModifier.Invisible, 0);
			}
		}
	}
}
