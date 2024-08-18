using System;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Skills.Handlers.Scouts.BulletMaker
{
	/// <summary>
	/// Handler for the Bullet Maker's skill Outrage.
	/// </summary>
	[SkillHandler(SkillId.Bulletmarker_Outrage)]
	public class Outrage : IGroundSkillHandler
	{
		/// <summary>
		/// Handles skill, applies buff.
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

			// Cast re-cast if we already have Outrage Buff
			if (caster.IsBuffActive(BuffId.Outrage_Buff))
				return;

			if (!caster.TryGetBuff(BuffId.Overheating_Buff, out var overheatingBuff) || overheatingBuff.OverbuffCounter < 4)			
				return;

			var overBuffCounter = 0;

			if (overheatingBuff.OverbuffCounter == 40)
				overBuffCounter = 30;
			else
				overBuffCounter = (int)Math.Truncate((float)(overheatingBuff.OverbuffCounter / 2));

			overheatingBuff.Stop();
			caster.StartBuff(BuffId.Outrage_Buff, TimeSpan.Zero, overBuffCounter);

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, originPos, caster.Direction, Position.Zero);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);
		}
	}
}
