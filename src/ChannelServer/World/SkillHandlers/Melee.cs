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
		override public SkillResult ProcessSkill(Actor target, Skill skill)
		{
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
				Monster targetMonster = (Monster)target;

				if (targetMonster.IsDead)
					return skillResult;

				float damage = ((IEntity)skill.owner).AdjustInfringedDamage(10);
				targetMonster.TakeDamage((int)damage, (Character)skill.owner);

				// Generate result reports
				skillResult = new SkillResult();
				skillResult.actor = target;
				skillResult.skillHandle = skill.Handle;
				skillResult.targetHandle = target.Handle;
				skillResult.value = damage;
				skillResult.type = 1;
			}

			return skillResult;
		}
	}
}
