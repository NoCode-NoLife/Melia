using System;
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
	/// Handler for the Swordman skill Bear.
	/// </summary>
	[SkillHandler(SkillId.Swordman_Bear)]
	public class DoubleAttack : IGroundSkillHandler
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

			var duration = TimeSpan.FromMinutes(30);
			target.StartBuff(BuffId.Bear_Buff, skill.Level, 0, duration, caster);

			Send.ZC_SKILL_MELEE_GROUND(caster, skill, originPos, null);
		}
	}
}
