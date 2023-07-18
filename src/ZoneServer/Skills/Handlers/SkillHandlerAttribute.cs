using System;
using System.Linq;
using System.Text.RegularExpressions;
using Melia.Shared.Data.Database;
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
		/// Returns the priority of the handler. Handlers with higher
		/// priority are preferred over handlers with lower priority.
		/// </summary>
		public int Priority { get; }

		/// <summary>
		/// Creates new attribute for the skill ids.
		/// </summary>
		/// <param name="skillIds"></param>
		public SkillHandlerAttribute(params SkillId[] skillIds)
		{
			this.SkillIds = skillIds ?? new SkillId[0];
			this.Priority = 100;
		}

		/// <summary>
		/// Creates new attribute for all skills that have the given
		/// use type.
		/// </summary>
		/// <param name="type"></param>
		public SkillHandlerAttribute(SkillUseType type)
		{
			var matchingSkills = ZoneServer.Instance.Data.SkillDb.FindAll(a => a.UseType == type);

			this.SkillIds = matchingSkills.Select(a => a.Id).ToArray();
			this.Priority = 0;
		}

		/// <summary>
		/// Creates new attribute for all skills that have the given
		///	use type and match name pattern.
		/// </summary>
		/// <param name="type"></param>
		/// <param name="namePattern"></param>
		public SkillHandlerAttribute(SkillUseType type, string namePattern)
		{
			var regex = new Regex(namePattern, RegexOptions.Compiled);
			var matchingSkills = ZoneServer.Instance.Data.SkillDb.FindAll(a => a.UseType == type && regex.IsMatch(a.ClassName));

			this.SkillIds = matchingSkills.Select(a => a.Id).ToArray();
			this.Priority = 50;
		}
	}
}
