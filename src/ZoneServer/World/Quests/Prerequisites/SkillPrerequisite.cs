using Melia.Shared.Game.Const;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.World.Quests.Prerequisites
{
	/// <summary>
	/// A prerequisite to reach a certain level on a skill.
	/// </summary>
	public class SkillPrerequisite : QuestPrerequisite
	{
		/// <summary>
		/// Returns the id of the skill which this prerequisite is about.
		/// </summary>
		public SkillId SkillId { get; }

		/// <summary>
		/// Returns the minimum level that needs to be reached.
		/// </summary>
		public int MinLevel { get; }

		/// <summary>
		/// Create new instance.
		/// </summary>
		/// <param name="skillId"></param>
		/// <param name="minLevel"></param>
		public SkillPrerequisite(SkillId skillId, int minLevel)
		{
			this.SkillId = skillId;
			this.MinLevel = minLevel;
		}

		/// <summary>
		/// Returns true if the character's skill has at least the min rank.
		/// </summary>
		/// <param name="character"></param>
		/// <returns></returns>
		public override bool Met(Character character)
		{
			return character.Skills.GetLevel(this.SkillId) >= this.MinLevel;
		}
	}
}
