using Melia.Channel.Network;
using Melia.Channel.Skills.Base;
using Melia.Channel.World.Entities;
using Melia.Shared.Const;
using Melia.Shared.Util;
using Melia.Shared.World;

namespace Melia.Channel.Skills.Wizard
{
	/// <summary>
	/// Handler for the Wizard skill Energy Bolt.
	/// </summary>
	[SkillHandler(SkillId.Wizard_EnergyBolt)]
	public class EnergyBolt : ITargetedSkillHandler
	{

		public void Handle(Skill skill, Character caster, ICombatEntity target)
		{
			if (target != null)
			{
				if (skill.SpendSp > 0)
				{
					if (caster.Sp >= skill.SpendSp)
						return;
					caster.ModifySp(-skill.SpendSp);
				}

				var castRange = caster.Position.Get3DDistance(target.Position);
				if (castRange > skill.Data.MaxRange)
				{
					Log.Warning("Energy Bolt: Player {0} cast skill farther than max range ({1} > {2}).", caster.Name, castRange, skill.Data.MaxRange);
					return;
				}

				skill.IncreaseOverheat();

				Send.ZC_SKILL_READY(caster, skill, caster.Position, target.Position);

				// The hitbox seems pretty small, there's presumably more going
				// into this. Double the splash range for the width for now.
				var radius = (int)skill.Data.SplashRange * 2;

				var targets = caster.Map.GetAttackableEntitiesInRangeSortedByDistance(caster, target.Position, radius);
				var damage = (int)(caster.GetRandomPAtk() * skill.Data.SkillFactor / 100f);

				Send.ZC_NORMAL_Skill_1D(caster, target);
				Send.ZC_SKILL_RANGE_CIRCLE(caster, target, skill);
				Send.ZC_SKILL_FORCE_TARGET(caster, target, skill, damage);
				target.TakeDamage(damage, caster, DamageVisibilityModifier.Invisible, 0);
			} else
			{
				Send.ZC_SKILL_FORCE_TARGET(caster, target, skill, 0);
			}
		}
	}
}
