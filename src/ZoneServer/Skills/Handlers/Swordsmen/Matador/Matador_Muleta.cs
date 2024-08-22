using System;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Matador
{
	/// <summary>
	/// Handler for the Matador skill Muleta
	/// </summary>
	[SkillHandler(SkillId.Matador_Muleta)]
	public class Matador_Muleta : IDynamicCasted
	{
		/// <summary>
		/// Called when the user starts casting the skill.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		public void StartDynamicCast(Skill skill, ICombatEntity caster)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			// TODO: Increase cooldown by 20 seconds.
			if (caster.IsAbilityActive(AbilityId.Matador26))
			{
				// ...
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			caster.StartBuff(BuffId.Muleta_Cast_Buff);
			caster.StartBuff(BuffId.IS_Channeling_Buff, TimeSpan.FromSeconds(2));

			if (caster is Character character)
				Send.ZC_NORMAL.UnkDynamicCastStart(character, skill.Id);

			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, caster.Position, caster.Direction, caster.Position);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, caster.Position, ForceId.GetNew(), null);
		}

		/// <summary>
		/// Called when the user stops casting the skill.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		public void EndDynamicCast(Skill skill, ICombatEntity caster)
		{
			caster.StopBuff(BuffId.Muleta_Cast_Buff);
			caster.StopBuff(BuffId.IS_Channeling_Buff);
			caster.StartBuff(BuffId.Muleta_Cast_End_Buff, TimeSpan.FromSeconds(1));

			if (caster is Character casterCharacter)
				Send.ZC_NORMAL.UnkDynamicCastEnd(casterCharacter, skill.Id, 1.544922f);
		}
	}
}
