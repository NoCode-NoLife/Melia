using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.World;

namespace Melia.Channel.World.SkillHandlers
{
	/// <summary>
	/// This class acts as a container component to share information between classes.
	/// </summary>
	public class SkillDataComponent
	{
		/// <summary>
		/// Skill 
		/// </summary>
		public Skill skill;

		/// <summary>
		/// Skill Handler ID
		/// </summary>
		public SkillHandler skillHandler;

		/// <summary>
		/// Skill caster
		/// </summary>
		public IEntity caster;

		/// <summary>
		/// Skill target
		/// </summary>
		public IEntity target;

		/// <summary>
		/// Skill originator
		/// </summary>
		public Actor originator;
	}
}
