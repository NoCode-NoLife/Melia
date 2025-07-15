using System;

namespace Melia.Zone.Scripting
{
	public static partial class Shortcuts
	{
		/// <summary>
		/// Subscribes handler to the given event.
		/// </summary>
		/// <remarks>
		/// Unlike events pre-defined in the server events manager, dynamic events
		/// are subscribed to and raised dynamically per name, making it possible
		/// for scripts to define and raise their own global events.
		/// </remarks>
		/// <param name="eventName"></param>
		/// <param name="handler"></param>
		public static void OnDynamicEvent(string eventName, EventHandler handler)
			=> ZoneServer.Instance.ServerEvents.Dynamic.Subscribe(eventName, handler);

		/// <summary>
		/// Raises the dynamic event with the given name.
		/// </summary>
		/// <param name="eventName">The name of the event to raise.</param>
		public static void RaiseDynamicEvent(string eventName)
			=> RaiseDynamicEvent(eventName, null, null);

		/// <summary>
		/// Raises the dynamic event with the given name.
		/// </summary>
		/// <param name="eventName">The name of the event to raise.</param>
		/// <param name="args">The arguments to pass to the event.</param>
		public static void RaiseDynamicEvent(string eventName, EventArgs args)
			=> RaiseDynamicEvent(eventName, null, args);

		/// <summary>
		/// Raises the dynamic event with the given name.
		/// </summary>
		/// <param name="eventName">The name of the event to raise.</param>
		/// <param name="sender">The object assigned as the raiser of the event.</param>
		/// <param name="args">The arguments to pass to the event.</param>
		public static void RaiseDynamicEvent(string eventName, object sender, EventArgs args)
			=> ZoneServer.Instance.ServerEvents.Dynamic.Raise(eventName, sender, args);
	}
}
