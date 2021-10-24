using System;
using Melia.Channel.Network;
using Melia.Channel.Skills.Base;
using Melia.Channel.World;
using Melia.Channel.World.Entities;
using Melia.Shared.Const;
using Melia.Shared.World;

namespace Melia.Channel.Skills.Cleric
{
	[SkillHandler(SkillId.Cleric_PatronSaint)]
	public class GuardianSaint : ISelfSkillHandler
	{
		public void Handle(Skill skill, Character caster, Position castPosition)
		{
			//TODO :: Not sure this will cost SP
			if (skill.SpendSp > 0)
				caster.ModifySp(-skill.SpendSp);
			BuffId buffId = BuffId.PatronSaint_Buff;
			
			caster.Buffs.Start(buffId);
		}

	}
}
