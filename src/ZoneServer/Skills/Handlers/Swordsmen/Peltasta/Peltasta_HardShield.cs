﻿using System;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Peltasta
{
	/// <summary>
	/// Handler for the Peltasta Skill Hard Shield
	/// </summary>
	/// <remarks>
	/// </remarks>
	[SkillHandler(SkillId.Peltasta_HardShield)]
	public class Peltasta_HardShield : IGroundSkillHandler
	{
		/// <summary>
		/// Handles skill, applying a buff to the caster.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="dir"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity target)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			target = caster;

			/// TODO: This needs to be immediately removed if your shield
			///   is removed, probably need an equipment change hook.

			var duration = TimeSpan.FromMinutes(30);
			target.StartBuff(BuffId.HardShield_Buff, skill.Level, 0, duration, caster);

			Send.ZC_SKILL_MELEE_GROUND(caster, skill, originPos, null);
		}
	}
}
