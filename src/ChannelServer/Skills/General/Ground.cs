using System.Threading.Tasks;
using Melia.Channel.Network;
using Melia.Channel.Skills.Base;
using Melia.Channel.World.Entities;
using Melia.Shared.Const;
using Melia.Shared.Util;
using Melia.Shared.World;

namespace Melia.Channel.Skills.General
{
	/// <summary>
	/// Generic Ground Skill Handler
	/// </summary>
	public class GroundSkillHandler : IGroundSkillHandler
	{
		public void Handle(Skill skill, Character caster, Position castPosition, Position targetPosition)
		{
			var castedRange = castPosition.Get3DDistance(targetPosition);
			if (castedRange > skill.Data.MaxRange)
			{
				Log.Warning("GroundSkillHandler: Player {0} cast skill with id {1} farther than max range ({2} > {3}).", caster.Name, skill.Id, castedRange, skill.Data.MaxRange);
				return;
			}

			// TODO: Cancel if not enough SP?
			if (skill.SpendSp > 0)
				caster.ModifySp(-skill.SpendSp);

			skill.IncreaseOverheat();

			Send.ZC_SKILL_READY(caster, skill, caster.Position, targetPosition);

			switch (skill.Id)
			{
				default:
				{
					var targets = caster.Map.GetAttackableEntitiesInRange(caster, targetPosition, (int)skill.Data.SplashRange);
					var damage = caster.GetRandomPAtk() + 100;

					Send.ZC_SKILL_MELEE_GROUND(caster, skill, targetPosition, targets, damage);

					foreach (var target in targets)
					{
						if (target.TakeDamage(damage, caster))
							Send.ZC_SKILL_CAST_CANCEL(caster, target);
					}
					break;
				}
			}
		}
	}
}
