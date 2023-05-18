using System;
using System.Reflection;
using Yggdrasil.Logging;

namespace Melia.Shared.Scripting
{
	/// <summary>
	/// Attribute for methods in scripts, to mark them as subscribers
	/// for events in the EventManager.
	/// </summary>
	public class OnAttribute : Attribute
	{
		/// <summary>
		/// Event to subscribe to (without "On" prefix).
		/// </summary>
		public string Event { get; protected set; }

		/// <summary>
		/// Creates new attribute.
		/// </summary>
		/// <param name="eventName"></param>
		public OnAttribute(string eventName)
		{
			this.Event = eventName;
		}

		/// <summary>
		/// Loads and subscribes all methods with the On attribute in the
		/// given object to the respective events in the event manager.
		/// </summary>
		/// <param name="obj"></param>
		/// <param name="eventManager"></param>
		public static void Load(object obj, object eventManager)
		{
			var type = obj.GetType();
			var events = eventManager;

			var methods = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
			foreach (var method in methods)
			{
				var attrs = method.GetCustomAttributes(typeof(OnAttribute), false);
				if (attrs.Length == 0)
					continue;

				var attr = attrs[0] as OnAttribute;

				var eventHandlerInfo = events.GetType().GetEvent(attr.Event);
				if (eventHandlerInfo == null)
				{
					Log.Error("OnAttribute.Load: Unknown event '{0}' on '{1}.{2}'.", attr.Event, type.Name, method.Name);
					continue;
				}

				try
				{
					eventHandlerInfo.AddEventHandler(events, Delegate.CreateDelegate(eventHandlerInfo.EventHandlerType, obj, method));
				}
				catch (Exception ex)
				{
					Log.Error("OnAttribute.Load: Failed to subscribe '{0}.{1}' to '{2}': {3}", type.Name, method.Name, attr.Event, ex);
				}
			}
		}

		/// <summary>
		/// Unsubscribes all methods with the On attribute in the
		/// given object from the respective methods in the event manager.
		/// </summary>
		/// <param name="obj"></param>
		/// <param name="eventManager"></param>
		public static void Unload(object obj, object eventManager)
		{
			var type = obj.GetType();
			var events = eventManager;

			var methods = type.GetMethods();
			foreach (var method in methods)
			{
				var attrs = method.GetCustomAttributes(typeof(OnAttribute), false);
				if (attrs.Length == 0)
					continue;

				var attr = attrs[0] as OnAttribute;

				var eventHandlerInfo = events.GetType().GetEvent(attr.Event);
				if (eventHandlerInfo == null)
				{
					// Erroring on load should be enough.
					//Log.Error("OnAttribute.Unload: Unknown event '{0}' on '{1}.{2}'.", attr.Event, type.Name, method.Name);
					continue;
				}

				try
				{
					eventHandlerInfo.RemoveEventHandler(events, Delegate.CreateDelegate(eventHandlerInfo.EventHandlerType, obj, method));
				}
				catch (Exception ex)
				{
					Log.Error("OnAttribute.Unload: Failed to unsubscribe '{0}.{1}' from '{2}': {3}", type.Name, method.Name, attr.Event, ex);
				}
			}
		}
	}
}
