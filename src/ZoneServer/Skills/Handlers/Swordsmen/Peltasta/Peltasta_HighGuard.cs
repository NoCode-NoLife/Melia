using System;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Peltasta
{
	/// <summary>
	/// Handler for the Peltasta skill High Guard.
	/// </summary>
	[SkillHandler(SkillId.Peltasta_HighGuard)]
	public class Peltasta_HighGuard : ISelfSkillHandler
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
			if (caster.IsBuffActive(BuffId.HighGuard_Buff))
			{
				caster.StopBuff(BuffId.HighGuard_Buff);
				caster.StopBuff(BuffId.HighGuard_Abil_Buff);
			}
			else
			{
				if (!caster.TrySpendSp(skill))
				{
					caster.ServerMessage(Localization.Get("Not enough SP."));
					return;
				}

				// If "High Guard: Iron Defense" is active, use the ability buff.
				// Otherwise use the normal one.
				if (caster.TryGetActiveAbilityLevel(AbilityId.Peltasta43, out var level))
					caster.StartBuff(BuffId.HighGuard_Abil_Buff, level, 0, TimeSpan.Zero, caster);
				else
					caster.StartBuff(BuffId.HighGuard_Buff, skill.Level, 0, TimeSpan.Zero, caster);
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			Send.ZC_SKILL_MELEE_TARGET(caster, skill, caster, null);
		}
	}
}
