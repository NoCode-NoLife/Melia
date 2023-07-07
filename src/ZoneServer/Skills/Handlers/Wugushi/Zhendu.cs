using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Scripting;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.CombatEntities.Components;

namespace Melia.Zone.Skills.Handlers.Wugushi
{
	/// <summary>
	/// Handler for the Wugushi skill Zhendu.
	/// </summary>
	[SkillHandler(SkillId.Wugushi_Zhendu)]
	public class Zhendu : ISelfSkillHandler
	{
		/// <summary>
		/// Handles skill, applying a buff to the caster.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="dir"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Direction dir)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.Components.Get<CombatComponent>().SetAttackState(true);

			var duration = TimeSpan.FromMinutes(30);
			caster.Components.Get<BuffComponent>().Start(BuffId.Zhendu_Buff, skill.Level, 0, duration, caster, skill);

			Send.ZC_NORMAL.Skill_59(caster as Character, "M_GTOWER_STAGE_15", skill.Id, caster.Position, caster.Position.GetDirection(caster.Position), true);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, caster.Position, caster.Position.GetDirection(caster.Position), Position.Zero);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, caster.Position, null);

			var casterCharacter = caster as Character;

			// Reduces the Poison property resistance of enemies within 150 by 10% per attribute level when [Zhendu] is used
			//if (casterCharacter != null && casterCharacter.Abilities.Has(AbilityId.Wugushi7))
			//{
			//	var SCR_Get_AbilityReinforceRate = ScriptableFunctions.Skill.Get("SCR_Get_AbilityReinforceRate");
			//	var abilityReinforceRate = SCR_Get_AbilityReinforceRate(skill);

			//	var radius = 150;
			//	var center = caster.Position.GetRelative(caster.Position, radius);
			//	var splashArea = new Circle(center, radius);

			//	// Attack targets
			//	var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			//	var hits = new List<SkillHitInfo>();

			//	foreach (var target in targets)
			//	{
			//		// TODO: Reduces the poison resistance of the target by 10%
			//	}
			//}
		}
	}
}
