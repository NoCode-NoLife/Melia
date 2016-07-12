using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.World;

namespace Melia.Channel.World.SkillHandlers
{
	public abstract class SkillHandler
	{
		abstract public SkillResult ProcessSkill(Actor target, Skill skill);
	}
}
