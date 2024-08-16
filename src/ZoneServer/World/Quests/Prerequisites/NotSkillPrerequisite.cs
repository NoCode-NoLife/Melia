using Melia.Shared.Game.Const;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.World.Quests.Prerequisites
{
	/// <summary>
	/// A prerequisite to not have a skill past a certain level.
	/// </summary>
	public class NotSkillPrerequisite : QuestPrerequisite
	{
		/// <summary>
		/// Returns the id of the skill which this prerequisite is about.
		/// </summary>
		public SkillId SkillId { get; }

		/// <summary>
		/// Returns the max level the skill may have.
		/// </summary>
		public int MaxLevel { get; }

		/// <summary>
		/// Create new instance.
		/// </summary>
		/// <param name="skillId"></param>
		/// <param name="maxLevel"></param>
		public NotSkillPrerequisite(SkillId skillId, int maxLevel)
		{
			this.SkillId = skillId;
			this.MaxLevel = maxLevel;
		}

		/// <summary>
		/// Returns true if the character's skill hasn't reached the max
		/// rank.
		/// </summary>
		/// <param name="character"></param>
		/// <returns></returns>
		public override bool Met(Character character)
		{
			return character.Skills.GetLevel(this.SkillId) < this.MaxLevel;
		}
	}
}
