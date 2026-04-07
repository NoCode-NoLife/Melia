using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Melia.Shared.Game.Const;
using Melia.Zone.Abilities;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Scripting;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs
{
	/// <summary>
	/// Buff handler collection and manager.
	/// </summary>
	public class BuffHandlers
	{
		private readonly Dictionary<BuffId, IBuffHandler> _buffHandlers = new();

		/// <summary>
		/// Creates a new buff handler manager.
		/// </summary>
		public BuffHandlers()
		{
			this.LoadHandlersFromAssembly(Assembly.GetExecutingAssembly());
		}

		/// <summary>
		/// Loads ability handlers marked with an ability handler
		/// attribute in the given assembly.
		/// </summary>
		/// <remarks>
		/// Searches the given assembly for classes implementing the <see
		/// cref="IAbilityHandler"/> interface and marked with the <see
		/// cref="AbilityHandlerAttribute"/>. The handlers are then
		/// registered for the ability ids specified in the attribute.
		/// </remarks>
		/// <param name="assembly">Assembly to search for handlers.</param>
		public void LoadHandlersFromAssembly(Assembly assembly)
		{
			foreach (var type in assembly.GetTypes().Where(a => typeof(IBuffHandler).IsAssignableFrom(a) && !a.IsInterface))
			{
				foreach (var attr in type.GetCustomAttributes<BuffHandlerAttribute>())
				{
					var handler = (IBuffHandler)Activator.CreateInstance(type);
					var buffIds = attr.BuffIds;

					foreach (var buffId in buffIds)
						this.Register(buffId, handler);
				}
			}
		}

		/// <summary>
		/// Registers a buff handler for the given buff id.
		/// </summary>
		/// <param name="buffId"></param>
		/// <param name="handler"></param>
		public void Register(BuffId buffId, IBuffHandler handler)
		{
			lock (_buffHandlers)
				_buffHandlers[buffId] = handler;

			ScriptableFunctions.Load(handler);
		}

		/// <summary>
		/// Returns true if a handler was registered for the given buff.
		/// </summary>
		/// <param name="buffId"></param>
		/// <returns></returns>
		public bool Has(BuffId buffId)
		{
			lock (_buffHandlers)
				return _buffHandlers.ContainsKey(buffId);
		}

		/// <summary>
		/// Returns the buff handler for the given buff. Returns null if
		/// no handler was found.
		/// </summary>
		/// <param name="buffId"></param>
		/// <returns></returns>
		public IBuffHandler GetHandler(BuffId buffId)
		{
			lock (_buffHandlers)
			{
				if (_buffHandlers.TryGetValue(buffId, out var handler))
					return handler;
			}

			return null;
		}

		/// <summary>
		/// Returns handler for the given buff via out. Returns false if
		/// no handler was found.
		/// </summary>
		/// <param name="buffId"></param>
		/// <param name="handler"></param>
		/// <returns></returns>
		public bool TryGetHandler(BuffId buffId, out IBuffHandler handler)
		{
			lock (_buffHandlers)
				return _buffHandlers.TryGetValue(buffId, out handler);
		}
	}
}
