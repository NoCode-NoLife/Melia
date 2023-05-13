using System.Collections.Generic;
using Melia.Zone.World;
using Melia.Zone.World.Entities;
using Melia.Shared.World;

namespace Melia.Zone.Skills.Base
{
	/// <summary>
	/// Targeted skill handler interface when the client provides a target
	/// </summary>
	public interface ITargetedSkillHandler
	{
		void Handle(Skill skill, Character caster, ICombatEntity target);
	}

	/// <summary>
	/// Ground skill handler when the client provides target cast 
	/// location, it be the same cast position as when a buff is casted
	/// like heal or double attack
	/// </summary>
	public interface IGroundSkillHandler
	{
		void Handle(Skill skill, Character caster, Position castPosition, Position targetPosition);
	}

	/// <summary>
	/// Targeted ground skill handler when the client provides targets
	/// </summary>
	public interface ITargetGroundSkillHandler
	{
		void Handle(Skill skill, Character caster, Position castPosition, Position targetPosition, IEnumerable<ICombatEntity> targets);
	}
}
