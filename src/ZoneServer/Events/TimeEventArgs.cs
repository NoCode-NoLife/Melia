using System;

namespace Melia.Zone.Events
{
	/// <summary>
	/// Arguments for events that are raised when the time changes.
	/// </summary>
	public class TimeEventArgs : EventArgs
	{
		/// <summary>
		/// Returns the current time as of the event.
		/// </summary>
		public DateTime Now { get; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="now"></param>
		public TimeEventArgs(DateTime now)
		{
			this.Now = now;
		}
	}
}
