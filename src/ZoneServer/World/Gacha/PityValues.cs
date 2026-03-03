namespace Melia.Zone.World.Gacha
{
	/// <summary>
	/// Contains the soft and hard pity values for a gacha machine.
	/// </summary>
	public class PityValues
	{
		/// <summary>
		/// Returns the soft pity threshold, after which the odds of
		/// getting certain items start to increase.
		/// </summary>
		public int SoftPity { get; }

		/// <summary>
		/// Returns the hard pity threshold, after which getting certain
		/// items is guaranteed.
		/// </summary>
		public int HardPity { get; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="softPity">Disabled if -1.</param>
		/// <param name="hardPity">Disabled if -1.</param>
		public PityValues(int softPity, int hardPity)
		{
			if (softPity == -1) softPity = int.MaxValue;
			if (hardPity == -1) hardPity = int.MaxValue;

			this.SoftPity = softPity;
			this.HardPity = hardPity;
		}

		/// <summary>
		/// Returns true if the given pity counter has reached the soft
		/// pity threshold.
		/// </summary>
		/// <param name="counter"></param>
		/// <returns></returns>
		public bool IsSoftPity(PityCounter counter)
		{
			return counter.PullsSince >= this.SoftPity;
		}

		/// <summary>
		/// Returns true if the given pity counter has reached the hard
		/// pity threshold.
		/// </summary>
		/// <param name="counter"></param>
		/// <returns></returns>
		public bool IsHardPity(PityCounter counter)
		{
			return counter.PullsSince >= this.HardPity;
		}
	}
}
