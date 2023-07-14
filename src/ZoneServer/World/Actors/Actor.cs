using System;
using Melia.Shared.World;
using Melia.Zone.World.Maps;

namespace Melia.Zone.World.Actors
{
	/// <summary>
	/// An object that can be placed on a map.
	/// </summary>
	public interface IActor
	{
		/// <summary>
		/// Returns the actor's unique handle.
		/// </summary>
		int Handle { get; }

		/// <summary>
		/// Returns the actor's display name.
		/// </summary>
		string Name { get; }

		/// <summary>
		/// Returns the map the actor is currently on.
		/// </summary>
		Map Map { get; set; }

		/// <summary>
		/// Returns the actor's position on its current map.
		/// </summary>
		Position Position { get; set; }

		/// <summary>
		/// Returns the direction the actor is facing.
		/// </summary>
		Direction Direction { get; set; }
	}

	/// <summary>
	/// An object that can be placed on a map.
	/// </summary>
	public abstract class Actor : IActor
	{
		/// <summary>
		/// Returns the actor's unique handle.
		/// </summary>
		public int Handle { get; } = ZoneServer.Instance.World.CreateHandle();

		/// <summary>
		/// Returns the actor's display name.
		/// </summary>
		public abstract string Name { get; set; }

		/// <summary>
		/// Returns the map the actor is currently on.
		/// </summary>
		public Map Map
		{
			get => _map;
			set => _map = value ?? Map.Limbo;
		}
		private Map _map = Map.Limbo;

		/// <summary>
		/// Returns the actor's position on its current map.
		/// </summary>
		public Position Position { get; set; }

		/// <summary>
		/// Returns the direction the actor is facing.
		/// </summary>
		public Direction Direction { get; set; }
	}
}
