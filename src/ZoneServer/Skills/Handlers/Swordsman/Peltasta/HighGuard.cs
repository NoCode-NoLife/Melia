using System;
using Melia.Shared.L10N;
using Melia.Shared.Game.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.World.Actors.Characters.Components;

namespace Melia.Zone.Skills.Handlers.Swordsman.Peltasta
{
	/// <summary>
	/// Handler for the Peltasta skill High Guard
	/// </summary>
	[SkillHandler(SkillId.Peltasta_HighGuard)]
	public class HighGuard : ISelfSkillHandler
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

				// Removing the stance doesn't cost SP
				caster.StopBuff(BuffId.HighGuard_Buff);
				caster.StopBuff(BuffId.HighGuard_Abil_Buff);

			} else { 

				if (!caster.TrySpendSp(skill))
				{
					caster.ServerMessage(Localization.Get("Not enough SP."));
					return;
				}

				// This is a stance, it lasts indefinitely until removed
				caster.StartBuff(BuffId.HighGuard_Buff, skill.Level, 0, TimeSpan.Zero, caster);

				// This skill triggers a second buff if you have the correct ability
				if (caster.Components.TryGet<AbilityComponent>(out var abilities) && abilities.TryGetActive(AbilityId.Peltasta43, out var ability))
				{					
					caster.StartBuff(BuffId.HighGuard_Abil_Buff, ability.Level, 0, TimeSpan.Zero, caster);
				}
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			Send.ZC_SKILL_MELEE_TARGET(caster, skill, caster, null);
		}
	}
}
