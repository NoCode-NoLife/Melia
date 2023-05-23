using System;

namespace Melia.Zone.World.Actors.Components.AI.Events
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
	}
}
