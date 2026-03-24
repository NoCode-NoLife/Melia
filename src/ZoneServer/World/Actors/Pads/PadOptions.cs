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
		/// Gets or sets the pad's "angle".
		/// </summary>
		/// <remarks>
		/// See Pad.Angle for more details.
		/// </remarks>
		public float Angle { get; set; } = 0;

		/// <summary>
		/// Gets or sets the pad's "distance".
		/// </summary>
		/// <remarks>
		/// See Pad.Distance for more details.
		/// </remarks>
		public float Distance { get; set; } = 0;

		/// <summary>
		/// Gets or sets the pad's "f3" value.
		/// </summary>
		/// <remarks>
		/// See Pad.UnkF3 for more details.
		/// </remarks>
		public float UnkF3 { get; set; } = 0;

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
