using Melia.Zone.Scripting.Dialogues;

namespace Melia.Zone.Scripting.Extensions.LivelyDialog
{
	/// <summary>
	/// Rates the current relationship between an NPC and a player.
	/// </summary>
	public readonly struct RelationshipStatus
	{
		/// <summary>
		/// Returns the current memory value, describing how well the NPC
		/// remembers the player.
		/// </summary>
		public readonly int Memory;

		/// <summary>
		/// Returns the current favor value, describing how much the NPC
		/// likes the the player.
		/// </summary>
		public readonly int Favor;

		/// <summary>
		/// Returns the current stress value, describing how stressed the
		/// NPC is by the current conversation.
		/// </summary>
		public readonly int Stress;

		/// <summary>
		/// Returns the current relation level based on the memory and
		/// favor values, indicating the general relationship between the
		/// NPC and the player.
		/// </summary>
		public readonly RelationshipLevel Level;

		/// <summary>
		/// Returns a simplified stress level based on the current
		/// stress value.
		/// </summary>
		public readonly StressLevel StressLevel;

		/// <summary>
		/// Returns a simplified recall level based on the current
		/// memory value.
		/// </summary>
		public readonly RecallLevel RecallLevel;

		/// <summary>
		/// Creates a new relationship status based on the given dialog.
		/// </summary>
		/// <param name="dialog"></param>
		public RelationshipStatus(Dialog dialog)
		{
			this.Memory = dialog.GetMemory();
			this.Favor = dialog.GetFavor();
			this.Stress = dialog.GetStress();

			this.Level = GetRelationshipLevel(this.Memory, this.Favor);
			this.RecallLevel = GetRecallLevel(this.Memory);
			this.StressLevel = GetStressLevel(this.Stress);
		}

		/// <summary>
		/// Returns the current relationship level based on the given
		/// values.
		/// </summary>
		/// <param name="memory"></param>
		/// <param name="favor"></param>
		/// <returns></returns>
		public static RelationshipLevel GetRelationshipLevel(int memory, int favor)
		{
			if (memory >= 15 && favor >= 50)
				return RelationshipLevel.CloseFriends;
			else if (memory >= 15 && favor >= 30)
				return RelationshipLevel.Friends;
			else if (favor >= 10)
				return RelationshipLevel.Acquaintances;
			else if (favor > -10)
				return RelationshipLevel.Neutral;
			else if (favor > -30)
				return RelationshipLevel.Strained;
			else
				return RelationshipLevel.Antagonistic;
		}

		/// <summary>
		/// Returns the current recall level based on the given memory
		/// value.
		/// </summary>
		/// <param name="memory"></param>
		/// <returns></returns>
		public static RecallLevel GetRecallLevel(int memory)
		{
			if (memory == 0)
				return RecallLevel.FirstMeeting;
			else if (memory == 1)
				return RecallLevel.Recognition;
			else if (memory == 2)
				return RecallLevel.Familiarity;
			else if (memory <= 6)
				return RecallLevel.Acquaintance;
			else
				return RecallLevel.Remembrance;
		}

		/// <summary>
		/// Returns the current stress level based on the given stress
		/// value.
		/// </summary>
		/// <param name="stress"></param>
		/// <returns></returns>
		public static StressLevel GetStressLevel(int stress)
		{
			if (stress < 5)
				return StressLevel.Low;
			else if (stress < 10)
				return StressLevel.Moderate;
			else
				return StressLevel.High;
		}
	}

	/// <summary>
	/// Describes the current relationship level between an NPC and a
	/// player.
	/// </summary>
	public enum RelationshipLevel
	{
		/// <summary>
		/// A very negative relationship.
		/// </summary>
		/// <remarks>
		/// The most negative level, reached when favor is -30 or lower.
		/// </remarks>
		Antagonistic,

		/// <summary>
		/// A somewhat negative relationship.
		/// </summary>
		/// <remarks>
		/// Caused by favor being between -10 and -30.
		/// </remarks>
		Strained,

		/// <summary>
		/// A neutral relationship that's neither positive nor negative.
		/// </summary>
		/// <remarks>
		/// Applies regardless of memory when favor is between -10 and 10.
		/// </remarks>
		Neutral,

		/// <summary>
		/// A moderate level, indicating an almost neutral relationship.
		/// </summary>
		/// <remarks>
		/// Independent of memory, this level is reached when favor >= 10.
		/// </remarks>
		Acquaintances,

		/// <summary>
		/// A highly positive relationship.
		/// </summary>
		/// <remarks>
		/// Reached when memory >= 15 and favor >= 30.
		/// </remarks>
		Friends,

		/// <summary>
		/// The most positive relationship.
		/// </summary>
		/// <remarks>
		/// Reached when memory >= 15 and favor >= 50.
		/// </remarks>
		CloseFriends,
	}

	/// <summary>
	/// Describes the current stress level of an NPC.
	/// </summary>
	public enum StressLevel
	{
		/// <summary>
		/// The lowest level, indicating no or very little stress.
		/// </summary>
		/// <remarks>
		/// Applies below 5 stress.
		/// </remarks>
		Low,

		/// <summary>
		/// A moderate amount of stress.
		/// </summary>
		/// <remarks>
		/// Applies between 5 and 10 stress.
		/// </remarks>
		Moderate,

		/// <summary>
		/// A high amount of stress, where NPCs might stop responding
		/// altogether.
		/// </summary>
		/// <remarks>
		/// Reached at 10 stress or higher.
		/// </remarks>
		High,
	}

	/// <summary>
	/// Describes how well an NPC remembers a player.
	/// </summary>
	public enum RecallLevel
	{
		/// <summary>
		/// The lowest level, that only applies if the NPC never met
		///	a player or forgot about them completely.
		/// </summary>
		/// <remarks>
		/// Memory = 0
		/// </remarks>
		FirstMeeting,

		/// <summary>
		/// The NPC has met the player before.
		/// </summary>
		/// <remarks>
		/// Memory = 1
		/// </remarks>
		Recognition,

		/// <summary>
		/// The NPC and the player have met repeatedly and/or talked
		/// to each other.
		/// </summary>
		/// <remarks>
		/// Memory = 2
		/// </remarks>
		Familiarity,

		/// <summary>
		/// The NPC and the player have met or talked several times.
		/// </summary>
		/// <remarks>
		/// Memory <= 6
		/// </remarks>
		Acquaintance,

		/// <summary>
		/// The NPC remembers the player very well.
		/// </summary>
		/// <remarks>
		/// Memory > 6
		/// </remarks>
		Remembrance,
	}
}
