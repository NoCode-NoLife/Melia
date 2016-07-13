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
		override public SkillResult ProcessSkill(Actor target, Skill skill, Actor originator)
		{
			Log.Debug("ProcessHealSkill: {0} {1}", target, typeof(Character));
			SkillResult skillResult = null;

			// Avoid interaction with any other type
			if (target.GetType() != typeof(Character) && target.GetType() != typeof(Monster))
			{
				return skillResult;
			}

			if (target.GetType() == typeof(Monster))
			{
				/// TODO
				/// make damage
			}

			if (target.GetType() == typeof(Character))
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
