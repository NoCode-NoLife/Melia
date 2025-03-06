using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.World.Quests.Prerequisites
{
	/// <summary>
	/// A prerequisite to complete a certain quest.
	/// </summary>
	public class CompletedPrerequisite : QuestPrerequisite
	{
		/// <summary>
		/// Returns the id of the quest that needs to be completed at
		/// least once to meet this prerequisite.
		/// </summary>
		public QuestId QuestId { get; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="questId"></param>
		public CompletedPrerequisite(string questNamespace, long id)
		{
			this.QuestId = new QuestId(questNamespace, id);
		}

		/// <summary>
		/// Returns true if the character has completed the quest at least
		/// once.
		/// </summary>
		/// <param name="character"></param>
		/// <returns></returns>
		public override bool Met(Character character)
		{
			return character.Quests.HasCompleted(this.QuestId);
		}
	}
}
