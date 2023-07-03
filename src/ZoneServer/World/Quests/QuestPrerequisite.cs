using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.World.Quests
{
	/// <summary>
	/// A prerequisite to receive a quest automatically.
	/// </summary>
	public abstract class QuestPrerequisite
	{
		/// <summary>
		/// Returns true if the character meets this preresquisite.
		/// </summary>
		/// <param name="character"></param>
		/// <returns></returns>
		public abstract bool Met(Character character);
	}
}
