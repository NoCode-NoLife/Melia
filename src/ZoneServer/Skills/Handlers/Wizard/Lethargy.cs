﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;

namespace Melia.Zone.Skills.Handlers.Wizard
{
	/// <summary>
	/// Handler for the Wizard skill Lethargy.
	/// </summary>
	[SkillHandler(SkillId.Wizard_Lethargy)]
	public class Lethargy : IGroundSkillHandler
	{
		/// <summary>
		/// Handles the skill, debuffing enemies in target area.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		/// <param name="target"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity designatedTarget)
		{
			if (!skill.Vars.TryGet<Position>("Melia.ToolGroundPos", out var targetPos))
			{
				caster.ServerMessage(Localization.Get("No target location specified."));
				return;
			}

			if (!caster.Position.InRange2D(targetPos, skill.Data.MaxRange))
			{
				caster.ServerMessage(Localization.Get("Too far away."));
				return;
			}

			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.Components.Get<CombatComponent>().SetAttackState(true);

			Send.ZC_SKILL_MELEE_GROUND(caster, skill, targetPos, null);

			var splashArea = new Circle(targetPos, skill.Data.SplashRange);
			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			foreach (var target in targets)
			{
				target.Components.Get<BuffComponent>().Start(BuffId.Lethargy_Debuff, skill.Level, 0, TimeSpan.FromSeconds(20), caster);
				target.Components.Get<BuffComponent>().Start(BuffId.Lethargy_Atk_Debuff, skill.Level, 0, TimeSpan.FromSeconds(20), caster);
			}
		}
	}
}
