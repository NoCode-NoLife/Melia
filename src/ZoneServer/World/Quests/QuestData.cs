using System;
using System.Collections.Generic;

namespace Melia.Zone.World.Quests
{
	/// <summary>
	/// Represents a quest's data, as defined by a script.
	/// </summary>
	public class QuestData
	{
		/// <summary>
		/// Get or sets the quest's id.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Gets or sets the quest's name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the quest's description.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Gets or sets the recommended level for the quest.
		/// </summary>
		public int Level { get; set; } = 1;

		/// <summary>
		/// Gets or sets whether the quest can be cancelled.
		/// </summary>
		public bool Cancelable { get; set; } = false;

		/// <summary>
		/// Gets or sets whether the quest is automatically added to the list
		/// of tracked quests.
		/// </summary>
		public bool AutoTrack { get; set; } = false;

		/// <summary>
		/// Gets or sets the start delay between meeting the quests
		/// prerequisites and receiving it automatically. Applies only
		/// to quests that start automatically.
		/// </summary>
		public TimeSpan StartDelay { get; set; } = TimeSpan.Zero;

		/// <summary>
		/// Gets or sets how the the quest unlocks objectives.
		/// </summary>
		public QuestUnlockType UnlockType { get; set; } = QuestUnlockType.Sequential;

		/// <summary>
		/// Gets or sets how the quest is given to players.
		/// </summary>
		public QuestReceiveType ReceiveType { get; set; } = QuestReceiveType.Manual;

		/// <summary>
		/// Returns a list of the quest's objectives.
		/// </summary>
		public List<QuestObjective> Objectives { get; } = new List<QuestObjective>();

		/// <summary>
		/// Returns a list of the quest's rewards.
		/// </summary>
		public List<QuestReward> Rewards { get; } = new List<QuestReward>();

		/// <summary>
		/// Returns a list of the quest's prerequisites, that need to be
		/// met to receive the quest automatically.
		/// </summary>
		public List<QuestPrerequisite> Prerequisites { get; } = new List<QuestPrerequisite>();
	}

	/// <summary>
	/// Specifies how a quest unlocks its objectives.
	/// </summary>
	public enum QuestUnlockType
	{
		/// <summary>
		/// The objectives are unlocked one by one as they're completed.
		/// </summary>
		Sequential,

		/// <summary>
		/// The objectives are unlocked all at once and can be completed
		/// in any order.
		/// </summary>
		AllAtOnce,
	}

	/// <summary>
	/// Specifies how a quest gets to the player.
	/// </summary>
	public enum QuestReceiveType
	{
		/// <summary>
		/// The quest is started manually, by a script, via a dialog,
		/// or other methods.
		/// </summary>
		Manual,

		/// <summary>
		/// The quest is started automatically, as soon as the prerequisites
		/// have been met.
		/// </summary>
		Auto,
	}
}
