using System;
using Melia.Shared.L10N;
using Melia.Shared.Game.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Shared.Data.Database;
using Melia.Zone.Scripting.AI;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Peltasta
{
	/// <summary>
	/// Handler for the Peltasta skill Swash Buckling.
	/// </summary>
	[SkillHandler(SkillId.Peltasta_SwashBuckling)]
	public class Peltasta_SwashBuckling : IGroundSkillHandler
	{
		/// <summary>
		/// Handles the skill, giving the caster a buff and debuffing enemies
		/// in the target area.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		/// <param name="target"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity designatedTarget)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			Send.ZC_SKILL_MELEE_GROUND(caster, skill, caster.Position, null);

			var duration = TimeSpan.FromSeconds(5 + 2 * skill.Level);

			// This buff is mentioned in the skill file, but it seems like it was tied to abilities that have been removed
			//caster.StartBuff(BuffId.SwashBucklingReduceDamage_Buff, skill.Level, 0, duration, caster);
			//caster.StartBuff(BuffId.SwashBuckling_Buff, skill.Level, 0, duration, caster);

			var splashParam = skill.GetSplashParameters(caster, caster.Position, caster.Position, length: 0, width: 400, angle: 0);
			var splashArea = skill.GetSplashArea(SplashType.Circle, splashParam);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			var maxTargets = Math.Min(targets.Count, 6 + 3 * skill.Level);

			for (var i = 0; i < maxTargets; i++)
			{
				var target = targets[i];
				if (target.IsBuffActive(BuffId.ProvocationImmunity_Debuff))
					continue;

				target.StartBuff(BuffId.SwashBuckling_Debuff, skill.Level, 0, duration, caster);
				target.StartBuff(BuffId.ProvocationImmunity_Debuff, skill.Level, 0, duration, caster);

				if (target.Components.TryGet<AiComponent>(out var component))
				{
					// Reset hate and simulate a hit to build a small amount
					// of threat
					component.Script.QueueEventAlert(new HateResetAlert(caster));
					component.Script.QueueEventAlert(new HitEventAlert(target, caster, 0));
				}
			}
		}
	}
}
