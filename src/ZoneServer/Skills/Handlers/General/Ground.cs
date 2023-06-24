using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Yggdrasil.Logging;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.General
{
	/// <summary>
	/// Generic handler for ground skills.
	/// </summary>
	public class GroundSkillHandler : IGroundSkillHandler
	{
		public void Handle(Skill skill, ICombatEntity caster, Position castPosition, Position targetPosition, ICombatEntity designatedTarget)
		{
			var castedRange = castPosition.Get3DDistance(targetPosition);
			if (castedRange > skill.Data.MaxRange)
			{
				Log.Warning("GroundSkillHandler: Player {0} cast skill with id {1} farther than max range ({2} > {3}).", caster.Name, skill.Id, castedRange, skill.Data.MaxRange);
				return;
			}

			if (skill.SpendSp > 0)
				caster.Properties.Modify(PropertyName.SP, -skill.SpendSp);

			skill.IncreaseOverheat();

			Send.ZC_SKILL_READY(caster, skill, caster.Position, targetPosition);

			switch (skill.Id)
			{
				default:
				{
					var hits = new List<SkillHitInfo>();
					var anyDead = false;

					var targets = caster.Map.GetAttackableEntitiesInRange(caster, targetPosition, (int)skill.Data.SplashRange);
					var damage = SCR_GetRandomAtk(caster, null, skill);

					foreach (var target in targets)
					{
						if (target.TakeDamage(damage, caster))
							anyDead = true;

						var skillHitInfo = new SkillHitInfo(caster, target, skill, damage, TimeSpan.FromMilliseconds(306), TimeSpan.FromMilliseconds(50));
						hits.Add(skillHitInfo);
					}

					Send.ZC_SKILL_MELEE_GROUND(caster, skill, targetPosition, hits);

					if (anyDead)
						Send.ZC_SKILL_CAST_CANCEL(caster);
					break;
				}
			}
		}
	}
}
