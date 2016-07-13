using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Util;
using Melia.Shared.World;

namespace Melia.Channel.World.SkillHandlers
{
	public class Melee : SkillHandler
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

			/// make damage
			var entityTarget = (IEntity)target;

			if (entityTarget.IsDead)
				return skillResult;

			float damage = (skill.owner).AdjustInfringedDamage(10);
			entityTarget.TakeDamage((int)damage, skill.owner);

			// Generate result reports
			skillResult = new SkillResult();
			skillResult.actor = target;
			skillResult.skillHandle = skill.Handle;
			skillResult.targetHandle = target.Handle;
			skillResult.value = damage;
			skillResult.type = 1;

			return skillResult;
		}
	}
}
