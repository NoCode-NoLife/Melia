using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Util;
using Melia.Shared.World;
using Melia.Channel.World.SkillEffects;

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

			if (target == null)
				return skillResult;

			// Avoid interaction with any other type
			if (!(target is Character) && !(target is Monster))
			{
				return skillResult;
			}

			/// make damage
			var entityTarget = (IEntity)target;

			if (entityTarget.IsDead)
				return skillResult;

			SkillDataComponent skillComp = new SkillDataComponent();
			skillComp.skill = skill;
			skillComp.skillHandler = this;
			skillComp.caster = skill.owner;
			skillComp.target = (IEntity)target;
			skillComp.originator = originator;

			foreach (var effectData in skill.GetData().effects)
			{
				SkillEffect newEffect = SkillEffect.GetSkillEffect(effectData.EffectType, effectData, skillComp);
				skillResult = newEffect.Instant();
			}


			return skillResult;
		}
	}
}
