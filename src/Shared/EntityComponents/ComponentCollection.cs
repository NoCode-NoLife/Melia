using System;
using System.Collections.Generic;

namespace Melia.Shared.EntityComponents
{
	/// <summary>
	/// A collection of components for an entity.
	/// </summary>
	/// <remarks>
	/// Components are addressed by their type, and there can only be
	/// one component per type. For example, only one inventory, one
	/// skill collection, etc.
	/// </remarks>
	public class ComponentCollection
	{
		private readonly Dictionary<Type, IComponent> _components = new Dictionary<Type, IComponent>();
		private readonly HashSet<IUpdatableComponent> _updateables = new HashSet<IUpdatableComponent>();
		private readonly object _syncLock = new object();

		/// <summary>
		/// Adds a component.
		/// </summary>
		/// <typeparam name="TComponent"></typeparam>
		/// <param name="component"></param>
		public void Add<TComponent>(TComponent component) where TComponent : IComponent
		{
			var type = component.GetType();
			lock (_syncLock)
			{
				_components[type] = component;

				if (component is IUpdatableComponent updatableComponent)
					_updateables.Add(updatableComponent);
			}
		}

		/// <summary>
		/// Removes the given component.
		/// </summary>
		/// <param name="component"></param>
		public void Remove(IComponent component)
		{
			var type = component.GetType();
			lock (_syncLock)
			{
				_components.Remove(type);

				if (component is IUpdatableComponent updatableComponent)
					_updateables.Remove(updatableComponent);
			}
		}

		/// <summary>
		/// Removes all components of the given type, returns false if the
		/// component didn't exist.
		/// </summary>
		/// <typeparam name="TComponent"></typeparam>
		/// <returns></returns>
		public bool Remove<TComponent>()
		{
			lock (_syncLock)
			{
				var type = typeof(TComponent);

				if (!_components.TryGetValue(typeof(TComponent), out var component))
					return false;

				_components.Remove(type);

				if (component is IUpdatableComponent updatableComponent)
					_updateables.Remove(updatableComponent);

				return true;
			}
		}

		/// <summary>
		/// Returns the component of the given type, or the type's default
		/// value if the component wasn't found.
		/// </summary>
		/// <typeparam name="TComponent"></typeparam>
		/// <returns></returns>
		public TComponent Get<TComponent>()
		{
			var type = typeof(TComponent);

			lock (_syncLock)
			{
				if (_components.TryGetValue(type, out var component))
					return (TComponent)component;
			}

			return default(TComponent);
		}

		/// <summary>
		/// Returns the component of the given type via out, returns false
		/// if the component wasn't found.
		/// </summary>
		/// <typeparam name="TComponent"></typeparam>
		/// <param name="component"></param>
		/// <returns></returns>
		public bool TryGet<TComponent>(out TComponent component)
		{
			component = this.Get<TComponent>();
			return component != null;
		}

		/// <summary>
		/// Returns true if the a component with the given type exists.
		/// </summary>
		/// <typeparam name="TComponent"></typeparam>
		/// <returns></returns>
		public bool Has<TComponent>()
		{
			lock (_syncLock)
				return _components.ContainsKey(typeof(TComponent));
		}

		/// <summary>
		/// Updates updatable components.
		/// </summary>
		/// <param name="elapsed"></param>
		public void Update(TimeSpan elapsed)
		{
			lock (_syncLock)
			{
				foreach (var component in _updateables)
					component.Update(elapsed);
			}
		}
	}
}
