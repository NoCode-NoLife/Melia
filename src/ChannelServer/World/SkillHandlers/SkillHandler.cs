using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.World;

namespace Melia.Channel.World.SkillHandlers
{
	/// <summary>
	/// Abstract class for SkillHandler.
	/// SkillHandler represents the logic of a skill when processed. 
	/// SkillHandler is a one-time thing. The skill gets processed, makes what it have to do, and finishes.
	/// The skill got decoupled between Handler and Effects, and can be seen like the action that happens when the skill gets processed/fired (SkillHandler) and the effect that lasts (SkillEffect)
	/// </summary>
	public abstract class SkillHandler
	{
		/// <summary>
		/// This function is the entry point for processing the skill.
		/// </summary>
		abstract public SkillResult ProcessSkill(Actor target, Skill skill, Actor originator);
	}
}
