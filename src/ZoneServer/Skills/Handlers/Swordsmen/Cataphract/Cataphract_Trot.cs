using System;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Cataphract
{
	/// <summary>
	/// Handler for the Cataphract skill Trot.
	/// </summary>
	[SkillHandler(SkillId.Cataphract_Trot)]
	public class Cataphract_Trot : ISelfSkillHandler
	{
		/// <summary>
		/// Handles skill, applying the buff to the caster.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="dir"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Direction dir)
		{
			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			var target = caster;

			// This functions like a stance, it's removed if you cast it again

			if (target.IsBuffActive(BuffId.Trot_Buff))
			{
				target.StopBuff(BuffId.Trot_Buff);
			}
			else
			{
				// It's not clear if this consumes SP on cast, but it probably
				// should so you can't just keep reapplying it when out of SP.
				if (!caster.TrySpendSp(20))
				{
					caster.ServerMessage(Localization.Get("Not enough SP."));
					return;
				}
				target.StartBuff(BuffId.Trot_Buff, skill.Level, 0, TimeSpan.Zero, caster);
			}

			Send.ZC_SKILL_MELEE_TARGET(caster, skill, target, null);
		}
	}
}
