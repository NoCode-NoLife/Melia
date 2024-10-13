using System;
using Melia.Shared.L10N;
using Melia.Shared.Game.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;

namespace Melia.Zone.Skills.Handlers.Archers.Ranger
{
	/// <summary>
	/// Handler for the Ranger skill Scan.
	/// </summary>
	[SkillHandler(SkillId.Ranger_Scan)]
	public class Ranger_Scan : IGroundSkillHandler
	{
		/// <summary>
		/// Handles skill, applying a debuff to the target
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="dir"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity target)
		{
			if (target == null)
			{
				caster.ServerMessage(Localization.Get("No target specified."));
				return;
			}

			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			var duration = TimeSpan.FromSeconds(20);
			target.StartBuff(BuffId.Ranger_Scan_Debuff, skill.Level, 0, duration, caster);

			// This buff is used to process the cooldown reduction if you dash
			caster.StartBuff(BuffId.Ranger_Scan_DashTrigger, skill.Level, 0, TimeSpan.FromSeconds(60), caster);

			Send.ZC_SKILL_MELEE_GROUND(caster, skill, originPos, null);
		}
	}
}
