using Melia.Shared.World;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.World.Quests
{
	/// <summary>
	/// Represents an objective of a quest.
	/// </summary>
	public abstract class QuestObjective
	{
		/// <summary>
		/// Gets or sets the objective's description.
		/// </summary>
		public string Text { get; internal set; }

		/// <summary>
		/// Get or sets the location at which this objective may be worked
		/// on, such as an area where a monster spawns, or the location of
		/// a target NPC.
		/// </summary>
		public Location Location { get; internal set; }

		/// <summary>
		/// Returns the objective's identifier, which is unique on a per
		/// quest basis.
		/// </summary>
		public string Ident { get; internal set; }

		/// <summary>
		/// Returns the amount of goals to reach for this objective,
		/// like the number of monsters to kill or items to collect.
		/// </summary>
		public int TargetCount { get; internal set; } = 1;

		/// <summary>
		/// Called when a quest that uses this objective is initially loaded.
		/// The objective should set up its progress tracking here, such as
		/// subscribing to events.
		/// </summary>
		/// <remarks>
		/// Every quest objective is loaded only once, to keep track of
		/// the progress of all objectives that use this type.
		/// </remarks>
		public virtual void Load()
		{
		}

		/// <summary>
		/// Called when the quests that used this objective were unloaded.
		/// The objective should clean up its progress tracking measures
		/// here, such as unsubscribing from events.
		/// </summary>
		public virtual void Unload()
		{
		}

		/// <summary>
		/// Called when a quest with this objective is added to a character's
		/// quest log. This callback can be used for initial checks,
		/// such as for initial amounts of collection objectives.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="quest"></param>
		public virtual void OnStart(Character character, Quest quest)
		{
		}
	}
}
