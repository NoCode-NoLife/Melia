namespace Melia.Channel.World.Entities.Components.AI.Events
{
	/// <summary>
	/// Information about an event callback.
	/// </summary>
	public class AiEventCallback
	{
		/// <summary>
		/// Returns the name of the state during which the event should be
		/// handled.
		/// </summary>
		public string StateName { get; }

		/// <summary>
		/// Returns the name of the event to react to.
		/// </summary>
		public string EventName { get; }

		/// <summary>
		/// Returns the name of the function to call when the event happens.
		/// </summary>
		public string CallbackName { get; }

		/// <summary>
		/// Creates new callback.
		/// </summary>
		/// <param name="stateName"></param>
		/// <param name="eventName"></param>
		/// <param name="callbackName"></param>
		public AiEventCallback(string stateName, string eventName, string callbackName)
		{
			this.StateName = stateName;
			this.EventName = eventName;
			this.CallbackName = callbackName;
		}
	}
}
