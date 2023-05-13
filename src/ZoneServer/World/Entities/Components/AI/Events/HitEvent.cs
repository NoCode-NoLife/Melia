using System;

namespace Melia.Zone.World.Entities.Components.AI.Events
{
	/// <summary>
	/// Hit event, that occurs when the AI entity gets hit.
	/// </summary>
	public class HitEvent : IAiEvent
	{
		/// <summary>
		/// Returns the event's name.
		/// </summary>
		public string EventName => "hit";

		/// <summary>
		/// Returns the handle of the attacker.
		/// </summary>
		public int AttackerHandle { get; }

		/// <summary>
		/// Creates new event.
		/// </summary>
		/// <param name="attackerHandle"></param>
		public HitEvent(int attackerHandle)
		{
			this.AttackerHandle = attackerHandle;
		}
	}
}
