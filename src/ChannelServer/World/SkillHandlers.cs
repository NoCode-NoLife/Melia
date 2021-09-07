using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Channel.World
{
	public class SkillHandlers
	{
		public TargetedSkillHandler TargetedSkillHandler { get; set; }
		public GroundSkillHandler GroundSkillHandler { get; set; }
		public TargetedGroundSkillHandler TargetedGroundSkillHandler { get; set; }

		public SkillHandlers()
		{
			this.TargetedSkillHandler = new TargetedSkillHandler();
			this.GroundSkillHandler = new GroundSkillHandler();
			this.TargetedGroundSkillHandler = new TargetedGroundSkillHandler();
		}
	}
}
