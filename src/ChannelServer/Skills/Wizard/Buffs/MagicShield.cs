using System;
using Melia.Channel.Network;
using Melia.Channel.Skills.Base;
using Melia.Channel.World;
using Melia.Channel.World.Entities;
using Melia.Shared.Const;
using Melia.Shared.World;

namespace Melia.Channel.Skills.Wizard
{
	[SkillHandler(SkillId.Wizard_ReflectShield)]
	public class MagicShield : ISelfSkillHandler
	{
		public void Handle(Skill skill, Character caster, Position castPosition)
		{
			//TODO :: Not sure this will cost SP
			if (skill.SpendSp > 0)
				caster.ModifySp(-skill.SpendSp);

			BuffId buffId = BuffId.ReflectShield_Buff;
			
			// TODO :: This i don't know skill range circle Buff team ?
			Send.ZC_SKILL_RANGE_CIRCLE(caster,castPosition,100);
			
			caster.Buffs.Start(buffId);
		}

	}
}
