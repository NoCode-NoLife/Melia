using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Util;
using Melia.Shared.World;

namespace Melia.Channel.World.SkillHandlers
{
	public class Cure : SkillHandler
	{
		/// <summary>
		/// This function is the entry point for processing the skill.
		/// </summary>
		override public SkillResult ProcessSkill(Actor target, Skill skill, Actor originator)
		{
			SkillResult skillResult = null;

			// Avoid interaction with any other type
			if (!(target is Character) && !(target is Monster))
			{
				return skillResult;
			}

			if (target is Monster)
			{
				/// TODO
				/// make damage
			}

			if (target is Character)
			{
				// Heal character
				Character targetCharacter = (Character)target;

				int amount = targetCharacter.Heal(25, true);

				// Generate result reports
				if (amount > 0)
				{
					skillResult = new SkillResult();
					skillResult.actor = target;
					skillResult.skillHandle = skill.Handle;
					skillResult.targetHandle = target.Handle;
					skillResult.value = amount;
				}
			}
			return skillResult;
		}
	}
}
