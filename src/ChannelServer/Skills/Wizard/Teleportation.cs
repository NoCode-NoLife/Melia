using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Channel.Network;
using Melia.Channel.Skills.Base;
using Melia.Channel.World.Entities;
using Melia.Shared.Const;
using Melia.Shared.World;

namespace Melia.Channel.Skills.Wizard
{
	/// <summary>
	/// Handler for the Wizard skill Teleportation.
	/// </summary>
	[SkillHandler(SkillId.Wizard_Teleportation)]
	public class Teleportation : IGroundSkillHandler
	{
		public void Handle(Skill skill, Character caster, Position castPosition, Position targetPosition)
		{
			skill.IncreaseOverheat();
			Send.ZC_SKILL_READY(caster, skill, caster.Position, targetPosition);

			if (skill.SpendSp > 0)
			{
				if (caster.Sp >= skill.SpendSp)
					return;
				caster.ModifySp(-skill.SpendSp);
			}

			Send.ZC_NORMAL_Skill_1D(caster, -27208, 987);
			var skillHandle = ChannelServer.Instance.World.CreateHandle();
			Send.ZC_SYNC_START(caster, skillHandle, 1);
			// Add Buff Id: Teleportation_Buff Duration: 1000
			// Add Buff Id: Skill_NoDamage_Buff Duration: 1000 Skill Id: 20008 i4: 10000
			Send.ZC_SYNC_END(caster, skillHandle, 0);
			Send.ZC_SYNC_EXEC_BY_SKILL_TIME(caster, skillHandle, 400);

			Send.ZC_SKILL_MELEE_GROUND(caster, skill, targetPosition);
			Send.ZC_ENTER_HOOK(caster, 20041);
		}
	}
}
