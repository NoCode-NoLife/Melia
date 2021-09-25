using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Melia.Channel.Buffs.Base;
using Melia.Channel.Buffs.Generic;
using Melia.Channel.World.Entities;
using Melia.Shared.Const;

namespace Melia.Channel.Buffs
{
	/// <summary>
	/// Buff handler collection and manager.
	/// </summary>
	public class BuffHandlers
	{
		private IBuffHandler _defaultBuffHandler = new BuffHandler();

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

				var handler = Activator.CreateInstance(type);
				var buffIds = (attributes.First() as BuffHandlerAttribute).BuffIds;

				switch (handler)
				{
					case IBuffHandler h:
					{
						foreach (var buffId in buffIds)
							_buffHandlers[buffId] = h;
						break;
					}
				}
			}
		}

		/// <summary>
		/// Returns the buff handler for the given buff. If no specific
		/// handler was found, the default handler is returned.
		/// </summary>
		/// <param name="buffId"></param>
		/// <returns></returns>
		public IBuffHandler GetBuff(BuffId buffId)
		{
			if (_buffHandlers.TryGetValue(buffId, out var handler))
				return handler;

			return _defaultBuffHandler;
		}

		public void Handle(ICombatEntity target, params BuffId[] buffIds)
		{
			foreach (var buffId in buffIds)
			{
				var handler = GetBuff(buffId);
				handler.OnStart(buffId, target);
				handler.WhileActive(buffId, target);
				handler.OnEnd(buffId, target);
			}
		}
	}
}
