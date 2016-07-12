using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Channel.World.SkillHandlers
{
	public class SkillDataComponent
	{
		public Skill skill;
		public SkillHandler skillHandler;
		public IEntity caster;
		public IEntity target;
	}
}
