namespace Melia.Zone.World.Quests
{
	/// <summary>
	/// Holds a player's progress on a certain quest objective.
	/// </summary>
	public class QuestProgress
	{
		/// <summary>
		/// Gets or sets the current progress.
		/// </summary>
		public int Count { get; set; }

		/// <summary>
		/// Gets or sets whether the objective was completed.
		/// </summary>
		public bool Done { get; set; }

		/// <summary>
		/// Gets or sets whether the objective is unlocked and can be
		/// worked on.
		/// </summary>
		public bool Unlocked { get; set; }

		/// <summary>
		/// Returns the objective that this instance is holding the
		/// progress for.
		/// </summary>
		public QuestObjective Objective { get; set; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="objective"></param>
		public QuestProgress(QuestObjective objective)
		{
			this.Objective = objective;
		}

		/// <summary>
		/// Sets progress to done and the count to the objective's
		/// target count if it's currently lower.
		/// </summary>
		public void SetDone()
		{
			this.Done = true;

			if (this.Count < this.Objective.TargetCount)
				this.Count = this.Objective.TargetCount;
		}
	}
}
