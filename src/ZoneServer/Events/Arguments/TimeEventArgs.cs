using System;

namespace Melia.Zone.Events.Arguments
{
	/// <summary>
	/// Arguments for events that are raised when the time changes.
	/// </summary>
	/// <param name="now"></param>
	public class TimeEventArgs(DateTime now) : EventArgs
	{
		/// <summary>
		/// Returns the current time as of the event.
		/// </summary>
		public DateTime Now { get; } = now;
	}
}
