using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;

namespace Melia.Zone.Skills.Handlers.Swordsman
{
	/// <summary>
	/// Handler for the Swordman skill Pain Barrier.
	/// </summary>
	[SkillHandler(SkillId.Swordman_PainBarrier)]
	public class PainBarrier : ISelfSkillHandler
	{
		/// <summary>
		/// Handles skill, applying the buffs to the caster.
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
			caster.SetAttackState(true);

			var target = caster;

			// Guru lists this skill with 5 levels that slowly increased
			// the duration from 10s to 30s. This now appears to be the
			// default though and the skill is set to max level 1.
			var mainDuration = TimeSpan.FromSeconds(30);
			var immunityDuration = TimeSpan.FromSeconds(3);

			target.StartBuff(BuffId.PainBarrier_Buff, skill.Level, 0, mainDuration, caster);
			target.StartBuff(BuffId.PainBarrierImmune_Buff, skill.Level, 0, immunityDuration, caster);

			Send.ZC_SKILL_MELEE_TARGET(caster, skill, target, null);
		}
	}
}
