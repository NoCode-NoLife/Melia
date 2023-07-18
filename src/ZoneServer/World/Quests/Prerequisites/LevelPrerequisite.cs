using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.World.Quests.Prerequisites
{
	/// <summary>
	/// A prerequisite to reach a certain level.
	/// </summary>
	public class LevelPrerequisite : QuestPrerequisite
	{
		/// <summary>
		/// Returns the minimum level to reach, to meet this prerequisite.
		/// </summary>
		public int MinLevel { get; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="minLevel"></param>
		public LevelPrerequisite(int minLevel)
		{
			this.MinLevel = minLevel;
		}

		/// <summary>
		/// Returns true if the character's level is equal or higher than
		/// this prerequisite's min level.
		/// </summary>
		/// <param name="character"></param>
		/// <returns></returns>
		public override bool Met(Character character)
		{
			return character.Level >= this.MinLevel;
		}
	}
}
