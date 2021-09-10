using Melia.Channel.Network;
using Melia.Channel.Skills.Base;
using Melia.Channel.World;
using Melia.Channel.World.Entities;
using Melia.Shared.World;

namespace Melia.Channel.Skills.General
{
	/// <summary>
	/// Generic Buff Skill Handler
	/// </summary>
	public class BuffSkillHandler : IGroundSkillHandler
	{
		public void Handle(Skill skill, Character caster, Position castPosition, Position targetPosition)
		{
			if (skill.SpendSp > 0)
				caster.ModifySp(-skill.SpendSp);

			skill.IncreaseOverheat();
		}
	}
}
