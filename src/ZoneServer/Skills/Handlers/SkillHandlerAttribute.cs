using System;
using Melia.Shared.Tos.Const;

namespace Melia.Zone.Skills.Handlers
{
	/// <summary>
	/// Used to mark skill handler classes, which are then automatically
	/// loaded by the skill handler manager.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class)]
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
