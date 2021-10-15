using System;

namespace Melia.Channel.World.Entities.Components.AI.Events
{
	/// <summary>
	/// Describes an event that an AI can react to.
	/// </summary>
	public interface IAiEvent
	{
		/// <summary>
		/// Returns the name of the event.
		/// </summary>
		string EventName { get; }

		/// <summary>
		/// Pushes the event's arguments to the given state, returns the
		/// amount of arguments.
		/// </summary>
		/// <param name="L"></param>
		int PushArguments(IntPtr L);
	}
}
