using System;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;

namespace Melia.Zone.Skills.Handlers.Cleric
{
	/// <summary>
	/// Handler for the Cleric skill Cure.
	/// </summary>
	[SkillHandler(SkillId.Cleric_PatronSaint)]
	public class GuardianSaint : IGroundSkillHandler
	{
		/// <summary>
		/// Handles skill, damaging targets.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity target)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			var overloadDuration = TimeSpan.FromMinutes(30);
			caster.StartBuff(BuffId.PatronSaint_Buff, skill.Level, 0, overloadDuration, caster);

			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);
		}
	}
}
