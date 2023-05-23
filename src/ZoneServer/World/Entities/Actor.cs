using System;
using Melia.Shared.World;

namespace Melia.Zone.World.Entities
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
		/// Returns the map the actor is currently on.
		/// </summary>
		Map Map { get; }

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
	/// An actor that has a name.
	/// </summary>
	public interface INamedActor : IActor
	{
		string Name { get; }
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
		/// Returns the map the actor is currently on.
		/// </summary>
		public Map Map
		{
			get => _map;
			set => _map = value ?? Map.Limbo;
		}
		private Map _map;

		/// <summary>
		/// Returns the actor's position on its current map.
		/// </summary>
		public Position Position { get; set; }

		/// <summary>
		/// Returns the direction the actor is facing.
		/// </summary>
		public Direction Direction { get; set; }

		/// <summary>
		/// Gets or sets the time the actor will be removed from the
		/// map it's on.
		/// </summary>
		public DateTime DisappearTime { get; set; } = DateTime.MaxValue;
	}
}
