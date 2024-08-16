using Melia.Shared.L10N;
using Melia.Shared.Game.Const;

namespace Melia.Zone.World.Quests.Rewards
{
	/// <summary>
	/// A reward that gives silver to the player.
	/// </summary>
	public class SilverReward : ItemReward
	{
		/// <summary>
		/// Creates a quest reward for silver.
		/// </summary>
		/// <param name="amount"></param>
		public SilverReward(int amount)
			: base(ItemId.Silver, amount)
		{
		}

		/// <summary>
		/// Returns a string representation of the reward.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return string.Format(Localization.Get("{0} Silver"), this.Amount);
		}
	}
}
