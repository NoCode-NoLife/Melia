using System;
using Melia.Shared.L10N;
using Melia.Shared.Game.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Shared.Data.Database;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Actors.Characters.Components;
using Melia.Zone.Scripting.AI;
using Melia.Zone.Skills.Combat;

namespace Melia.Zone.Skills.Handlers.Swordsman.Peltasta
{
	/// <summary>
	/// Handler for the Wizard skill Lethargy.
	/// </summary>
	[SkillHandler(SkillId.Peltasta_SwashBuckling)]
	public class SwashBuckling : IGroundSkillHandler
	{
		/// <summary>
		/// Handles the skill, giving the caster a buff and debuffing enemies in target area.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		/// <param name="target"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity designatedTarget)
		{
			var duration = TimeSpan.FromSeconds(5 + 2 * skill.Level);

			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}
			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			Send.ZC_SKILL_MELEE_GROUND(caster, skill, caster.Position, null);

			// This buff is mentioned in the skill file, but seems to be tied to attributes that are not present in the current version
			//caster.StartBuff(BuffId.SwashBucklingReduceDamage_Buff, skill.Level, 0, duration, caster);
			//caster.StartBuff(BuffId.SwashBuckling_Buff, skill.Level, 0, duration, caster);

			var splashParam = skill.GetSplashParameters(caster, caster.Position, caster.Position, length: 0, width: 400, angle: 0);
			var splashArea = skill.GetSplashArea(SplashType.Circle, splashParam);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			// targets.LimitBySDR gets the wrong value for this skill, so we need to limit the targets manually
			var maxTargets = 6 + 3 * skill.Level;

			for (int i = 0; i < Math.Min(targets.Count, maxTargets); i++)
			{
				var target = targets[i];
				if (!target.IsBuffActive(BuffId.ProvocationImmunity_Debuff)) { 
					target.StartBuff(BuffId.SwashBuckling_Debuff, skill.Level, 0, duration, caster);
					target.StartBuff(BuffId.ProvocationImmunity_Debuff, skill.Level, 0, duration, caster);

					if (target.Components.TryGet<AiComponent>(out var component))
					{						
						component.Script.QueueEventAlert(new HateResetAlert(caster));
						// it triggers a "hit" to build a small amount of threat
						component.Script.QueueEventAlert(new HitEventAlert(target, caster, 0));
					}
				}
			}
		}
	}
}
