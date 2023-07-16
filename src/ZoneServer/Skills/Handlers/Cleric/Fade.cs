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
	/// Handler for the Cleric skill Fade.
	/// </summary>
	[SkillHandler(SkillId.Cleric_Fade)]
	public class Fade : IGroundSkillHandler
	{
		/// <summary>
		/// Handles skill, applying buff to the caster.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		/// <param name="target"></param>
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

			var duration = this.GetBuffDuration(skill);
			target.StartBuff(BuffId.Fade_Buff, skill.Level, 0, duration, caster);

			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);
		}

		/// <summary>
		/// Returns buff duration based on the skill's level.
		/// </summary>
		/// <param name="skill"></param>
		/// <returns></returns>
		private TimeSpan GetBuffDuration(Skill skill)
		{
			var seconds = 18 + skill.Level * 2;
			return TimeSpan.FromSeconds(seconds);
		}
	}
}
