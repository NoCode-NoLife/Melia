using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.World.Quests.Prerequisites
{
	/// <summary>
	/// A prerequisite that's met if at least one of its prerequisites
	/// was met.
	/// </summary>
	public class OrPrerequisite : QuestPrerequisite
	{
		/// <summary>
		/// Returns a list of prerequisites of which one must be met.
		/// </summary>
		public QuestPrerequisite[] Prerequisites { get; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="prerequisites"></param>
		public OrPrerequisite(params QuestPrerequisite[] prerequisites)
		{
			this.Prerequisites = prerequisites;
		}

		/// <summary>
		/// Returns true if the character meets at least one of the
		/// prerequisites.
		/// </summary>
		/// <param name="character"></param>
		/// <returns></returns>
		public override bool Met(Character character)
		{
			for (var i = 0; i < this.Prerequisites.Length; i++)
			{
				var prerequisite = this.Prerequisites[i];
				if (prerequisite.Met(character))
					return true;
			}

			return false;
		}
	}
}
