using Melia.Shared.L10N;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.World.Quests.Rewards
{
	/// <summary>
	/// A reward that gives experience.
	/// </summary>
	public class ExpReward : QuestReward
	{
		/// <summary>
		/// Returns the amount of EXP the player gets.
		/// </summary>
		public int ExpAmount { get; }

		/// <summary>
		/// Returns the amount of class EXP the player gets.
		/// </summary>
		public int ClassExpAmount { get; }

		/// <summary>
		/// Returns the icon to display for this reward.
		/// </summary>
		public override string Icon => "expup_img";

		/// <summary>
		/// Creates a quest reward for EXP.
		/// </summary>
		/// <param name="expAmount"></param>
		/// <param name="classExpAmount"></param>
		public ExpReward(int expAmount, int classExpAmount)
		{
			this.ExpAmount = expAmount;
			this.ClassExpAmount = classExpAmount;
		}

		/// <summary>
		/// Gives the EXP to the character.
		/// </summary>
		/// <param name="character"></param>
		public override void Give(Character character)
		{
			character.GiveExp(this.ExpAmount, this.ClassExpAmount, null);
		}

		/// <summary>
		/// Returns a string representation of the reward.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return string.Format(Localization.Get("{0} EXP, {1} Class EXP"), this.ExpAmount, this.ClassExpAmount);
		}
	}
}
