using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Abilities
{
	/// <summary>
	/// Ability handler collection and manager.
	/// </summary>
	public class AbilityHandlers
	{
		private readonly Dictionary<AbilityId, IAbilityHandler> _handlers = new();

		/// <summary>
		/// Creates a new ability handler manager and loads all handlers
		/// found in the current assembly.
		/// </summary>
		public AbilityHandlers()
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
			foreach (var type in assembly.GetTypes().Where(a => typeof(IAbilityHandler).IsAssignableFrom(a) && !a.IsInterface))
			{
				foreach (var attr in type.GetCustomAttributes<AbilityHandlerAttribute>())
				{
					var handler = (IAbilityHandler)Activator.CreateInstance(type);
					var abilityIds = attr.Ids;

					foreach (var abilityId in abilityIds)
						this.Register(abilityId, handler);
				}
			}
		}

		/// <summary>
		/// Registers a ability handler for the given ability id.
		/// </summary>
		/// <param name="abilityId"></param>
		/// <param name="handler"></param>
		public void Register(AbilityId abilityId, IAbilityHandler handler)
		{
			lock (_handlers)
				_handlers[abilityId] = handler;

			ScriptableFunctions.Load(handler);
		}

		/// <summary>
		/// Returns true if a handler was registered for the given ability.
		/// </summary>
		/// <param name="abilityId"></param>
		/// <returns></returns>
		public bool Has(AbilityId abilityId)
		{
			lock (_handlers)
				return _handlers.ContainsKey(abilityId);
		}

		/// <summary>
		/// Returns the ability handler for the given ability. Returns null if
		/// no handler was found.
		/// </summary>
		/// <param name="abilityId"></param>
		/// <returns></returns>
		public IAbilityHandler GetHandler(AbilityId abilityId)
		{
			lock (_handlers)
			{
				if (_handlers.TryGetValue(abilityId, out var handler))
					return handler;
			}

			return null;
		}

		/// <summary>
		/// Returns handler for the given ability via out. Returns false if
		/// no handler was found.
		/// </summary>
		/// <param name="abilityId"></param>
		/// <param name="handler"></param>
		/// <returns></returns>
		public bool TryGetHandler(AbilityId abilityId, out IAbilityHandler handler)
		{
			lock (_handlers)
				return _handlers.TryGetValue(abilityId, out handler);
		}
	}
}
