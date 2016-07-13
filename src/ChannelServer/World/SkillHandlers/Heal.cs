using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Util;
using Melia.Shared.World;

namespace Melia.Channel.World.SkillHandlers
{
	public class Heal : SkillHandler
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
				Monster targetMonster = (Monster)target;

				if (targetMonster.IsDead)
					return skillResult;

				targetMonster.TakeDamage(10, skill.owner);

				// Generate result reports
				skillResult = new SkillResult();
				skillResult.actor = target;
				skillResult.skillHandle = skill.Handle;
				skillResult.targetHandle = target.Handle;
				skillResult.value = 10;
				skillResult.type = 1;
			}

			if (target is Character)
			{
				// Heal character
				Character targetCharacter = (Character)target;

				if (targetCharacter.IsDead)
					return skillResult;

				int amount = targetCharacter.Heal(10, false);

				// Generate result reports
				if (amount > 0)
				{
					skillResult = new SkillResult();
					skillResult.actor = target;
					skillResult.skillHandle = skill.Handle;
					skillResult.targetHandle = target.Handle;
					skillResult.value = amount;
					skillResult.type = 0;
				}
			}
			return skillResult;
		}
	}
}
