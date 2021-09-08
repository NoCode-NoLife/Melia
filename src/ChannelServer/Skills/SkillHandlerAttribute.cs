using System;
using Melia.Shared.Const;

namespace Melia.Channel.Skills
{
	/// <summary>
	/// Used to mark skill handler classes, which are then automatically
	/// loaded by the skill handler manager.
	/// </summary>
	public class SkillHandlerAttribute : Attribute
	{
		/// <summary>
		/// Returns the ids of the skills this handler is supposed to
		/// be used for.
		/// </summary>
		public SkillId[] SkillIds { get; }

		/// <summary>
		/// Creates new attribute for the skill ids.
		/// </summary>
		/// <param name="skillIds"></param>
		public SkillHandlerAttribute(params SkillId[] skillIds)
		{
			this.SkillIds = skillIds;
		}
	}
}
