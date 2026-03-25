using System;

namespace Melia.Zone.World.Actors.Pads
{
	/// <summary>
	/// Defines options for creating a pad.
	/// </summary>
	public class PadOptions
	{
		/// <summary>
		/// Returns the default pad options, with all properties set to
		/// null.
		/// </summary>
		public static PadOptions Default => new();

		/// <summary>
		/// Gets or sets the pad's first numeric argument, which is
		/// typically used for the pad's "angle".
		/// </summary>
		/// <remarks>
		/// See <see cref="Pad.NumArg1"/> for more details.
		/// </remarks>
		public float NumArg1 { get; set; } = 0;

		/// <summary>
		/// Gets or sets the pad's second numeric argument, which is
		/// typically used as "distance".
		/// </summary>
		/// <remarks>
		/// See <see cref="Pad.NumArg2 "/> for more details.
		/// </remarks>
		public float NumArg2 { get; set; } = 0;

		/// <summary>
		/// Gets or sets the pad's third numeric argument.
		/// </summary>
		/// <remarks>
		/// See <see cref="Pad.NumArg3"/> for more details.
		/// </remarks>
		public float NumArg3 { get; set; } = 0;

		/// <summary>
		/// Gets or sets the pad's lifetime, after which it will be
		/// automatically destroyed.
		/// </summary>
		/// <remarks>
		/// This property is part of the trigger component, but is included
		/// here for convenience. Its value is typically found in the pad
		/// data, as a parameter of "PAD_ADD_LIFE".
		/// </remarks>
		public TimeSpan LifeTime { get; set; } = TimeSpan.MaxValue;

		/// <summary>
		/// Gets or sets the pad's update interval, which is the time
		/// between update events.
		/// </summary>
		public TimeSpan UpdateInterval { get; set; } = TimeSpan.FromSeconds(1);

		/// <summary>
		/// Gets or sets the maximum number of actors that can trigger the
		/// pad.
		/// </summary>
		/// <remarks>
		/// This property is part of the trigger component, but is
		/// included here for convenience. Its value is typically found in
		/// the pad data, as a parameter of "PAD_CONCURRENT_USE_COUNT".
		/// </remarks>
		public int MaxActorCount { get; set; } = short.MaxValue;

		/// <summary>
		/// Gets or sets the maximum number of times the pad can be used,
		/// which is an custom limit for each pad-type.
		/// </summary>
		public int MaxUseCount { get; set; } = short.MaxValue;
	}
}
