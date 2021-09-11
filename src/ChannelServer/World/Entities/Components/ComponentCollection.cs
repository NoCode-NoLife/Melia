using System;
using System.Collections.Generic;

namespace Melia.Channel.World.Entities.Components
{
	/// <summary>
	/// A collection of components for an entity.
	/// </summary>
	/// <remarks>
	/// Components are addressed by their type, and there can only be
	/// one component per type. For example, only one inventory, one
	/// skill collection, etc.
	/// </remarks>
	public class ComponentCollection : IUpdateable
	{
		private readonly Dictionary<Type, IComponent> _components = new Dictionary<Type, IComponent>();
		private readonly HashSet<IUpdateable> _updateables = new HashSet<IUpdateable>();
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

				if (component is IUpdateable updatableComponent)
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

				if (component is IUpdateable updatableComponent)
					_updateables.Remove(updatableComponent);
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

			return default;
		}

		/// <summary>
		/// Returns the component of the given type via out, returns false
		/// if the component wasn't found.
		/// </summary>
		/// <typeparam name="TComponent"></typeparam>
		/// <param name="component"></param>
		/// <returns></returns>
		public bool Get<TComponent>(out TComponent component)
		{
			component = this.Get<TComponent>();
			return component != null;
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
