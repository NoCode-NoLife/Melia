using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Melia.Zone.Buffs.Base;
using Melia.Shared.Tos.Const;

namespace Melia.Zone.Buffs
{
	/// <summary>
	/// Buff handler collection and manager.
	/// </summary>
	public class BuffHandlers
	{
		private readonly Dictionary<BuffId, IBuffHandler> _buffHandlers = new Dictionary<BuffId, IBuffHandler>();

		/// <summary>
		/// Creates a new buff handler manager.
		/// </summary>
		public BuffHandlers()
		{
			this.LoadHandlersFromAssembly();
		}

		/// <summary>
		/// Loads buff handlers marked with a buff handler attribute in
		/// the current assembly.
		/// </summary>
		private void LoadHandlersFromAssembly()
		{
			foreach (var type in Assembly.GetExecutingAssembly().GetTypes())
			{
				var attributes = type.GetCustomAttributes(typeof(BuffHandlerAttribute), false);
				if (attributes == null || attributes.Length == 0)
					continue;

				var handler = Activator.CreateInstance(type) as IBuffHandler;
				var buffIds = (attributes.First() as BuffHandlerAttribute).BuffIds;

				foreach (var buffId in buffIds)
					_buffHandlers[buffId] = handler;
			}
		}

		/// <summary>
		/// Returns the buff handler for the given buff. Returns null if
		/// no handler was found.
		/// </summary>
		/// <param name="buffId"></param>
		/// <returns></returns>
		public IBuffHandler GetHandler(BuffId buffId)
		{
			if (_buffHandlers.TryGetValue(buffId, out var handler))
				return handler;

			return null;
		}
	}
}
