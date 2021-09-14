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
			var castRange = castPosition.Get3DDistance(targetPosition);
			if (castRange > skill.Data.MaxRange)
			{
				Log.Warning("Magic Missile: Player {0} cast skill farther than max range ({1} > {2}).", caster.Name, castRange, skill.Data.MaxRange);
				return;
			}

			// TODO: Cancel if not enough SP?

			if (skill.SpendSp > 0)
				caster.ModifySp(-skill.SpendSp);

			skill.IncreaseOverheat();

			Send.ZC_SKILL_READY(caster, skill, caster.Position, targetPosition);

			// The hitbox seems pretty small, there's presumably more going
			// into this. Double the splash range for the width for now.
			var radius = (int)skill.Data.SplashRange * 2;

			var targets = caster.Map.GetAttackableEntitiesInRangeSortedByDistance(caster, target.Position, radius);
			var damage = (int)(caster.GetRandomPAtk() * skill.Data.SkillFactor / 100f);

			Send.ZC_SKILL_FORCE_TARGET(caster, target, skill, damage);

			foreach (var target in targets)
			{
				if (target.TakeDamage(damage, caster, DamageVisibilityModifier.Skill, 0))
					Send.ZC_SKILL_CAST_CANCEL(caster, target);
			}
		}
	}
}
