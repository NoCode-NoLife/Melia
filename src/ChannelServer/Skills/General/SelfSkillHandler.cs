using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Channel.Network;
using Melia.Channel.Skills.Base;
using Melia.Channel.World.Entities;
using Melia.Shared.World;

namespace Melia.Channel.Skills.General
{
	/// <summary>
	/// Targeted ground skill implementation when the client provides targets
	/// </summary>
	public class SelfSkillHandler : ISelfSkillHandler
	{
		public void Handle(Skill skill, Character caster, Position castPosition, Direction direction)
		{
			if (skill.SpendSp > 0)
			{
				if (caster.Sp >= skill.SpendSp)
					return;
				caster.ModifySp(-skill.SpendSp);
			}
			skill.IncreaseOverheat();

			Send.ZC_SKILL_READY(caster, skill, caster.Position, caster.Position);
			Send.ZC_NORMAL_Skill_1D(caster);

			var skillHandle = ChannelServer.Instance.World.CreateHandle();
			Send.ZC_SYNC_START(caster, skillHandle, 1);
			Send.ZC_SYNC_END(caster, skillHandle, 0);
			Send.ZC_SYNC_EXEC_BY_SKILL_TIME(caster, skillHandle, 200);
			Send.ZC_SKILL_MELEE_TARGET(caster, skill, caster);
		}
	}
}
