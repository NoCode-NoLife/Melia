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
using Melia.Zone.Skills.SplashAreas;

namespace Melia.Zone.Skills.Handlers.Scouts.OutLaw
{
	/// <summary>
	/// Handler for the Outlaw skill Aggress.
	/// </summary>
	[SkillHandler(SkillId.OutLaw_Aggress)]
	public class OutLaw_Aggress : IGroundSkillHandler
	{
		/// <summary>
		/// Handles the skill, debuffing enemies in the target area.
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

			var duration = TimeSpan.FromSeconds(10);

			// Splash area is a square of length 300, width 100, starting 100
			// units behind the caster
			var splashArea = new Square(caster.Position.GetRelative(caster.Direction, -100f), caster.Direction, 200f, 100f);
			Debug.ShowShape(caster.Map, splashArea);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			var maxTargets = Math.Min(targets.Count, 3 * skill.Level);

			var unhingeLevel = 0f;

			if (caster.TryGetActiveAbilityLevel(AbilityId.Outlaw13, out var level))
				unhingeLevel = level;

			for (var i = 0; i < maxTargets; i++)
			{
				var target = targets[i];
				if (target.IsBuffActive(BuffId.ProvocationImmunity_Debuff))
					continue;

				target.StartBuff(BuffId.Aggress_Debuff, skill.Level, unhingeLevel, duration, caster);
				target.StartBuff(BuffId.ProvocationImmunity_Debuff, skill.Level, 0, duration, caster);

				if (target.Components.TryGet<AiComponent>(out var component))
				{
					// Reset hate and simulate a hit to build a small amount
					// of threat
					component.Script.QueueEventAlert(new HateResetAlert(caster));
					component.Script.QueueEventAlert(new HitEventAlert(target, caster, 0));
				}
			}

			// Outlaw14 adds a massive speed buff
			if (caster.TryGetActiveAbilityLevel(AbilityId.Outlaw14, out var getawayLevel))
			{
				caster.StartBuff(BuffId.Aggress_Buff, skill.Level, 0, TimeSpan.FromSeconds(getawayLevel), caster);
			}
		}
	}
}
