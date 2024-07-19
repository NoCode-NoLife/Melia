using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Melia.Zone.Pads.Handlers
{
	/// <summary>
	/// Pad handler collection and manager.
	/// </summary>
	public class PadHandlers
	{
		private readonly Dictionary<string, IPadHandler> _handlers = new();
		private readonly Dictionary<string, int> _priorities = new();

		/// <summary>
		/// Initializes the pad handlers, loading all it can find in
		/// the executing assembly.
		/// </summary>
		public PadHandlers()
		{
			this.LoadHandlersFromAssembly();
		}

		/// <summary>
		/// Loads pad handlers marked with a pad handler attribute in
		/// the current assembly.
		/// </summary>
		private void LoadHandlersFromAssembly()
		{
			foreach (var type in Assembly.GetExecutingAssembly().GetTypes().Where(a => typeof(IPadHandler).IsAssignableFrom(a) && !a.IsInterface))
			{
				foreach (var attr in type.GetCustomAttributes<PadHandlerAttribute>())
				{
					var handler = (IPadHandler)Activator.CreateInstance(type);
					var padNames = attr.PadNames;

					foreach (var padName in padNames)
					{
						if (_priorities.TryGetValue(padName, out var priority))
						{
							if (priority > attr.Priority)
								continue;
						}

						_handlers[padName] = handler;
						_priorities[padName] = attr.Priority;
					}
				}
			}
		}

		/// <summary>
		/// Returns the handler for the given pad. If no handlers was
		/// set up, null is returned.
		/// </summary>
		/// <param name="padName"></param>
		/// <returns></returns>
		public IPadHandler GetHandler(string padName)
		{
			if (!_handlers.TryGetValue(padName, out var handler))
				return null;

			return handler;
		}

		/// <summary>
		/// Returns the handler for the given pad via out. Returns false
		/// if no handler was set up for the pad.
		/// </summary>
		/// <param name="padName"></param>
		/// <param name="handler"></param>
		/// <returns></returns>
		public bool TryGetHandler(string padName, out IPadHandler handler)
		{
			handler = this.GetHandler(padName);
			return handler != null;
		}
	}
}
