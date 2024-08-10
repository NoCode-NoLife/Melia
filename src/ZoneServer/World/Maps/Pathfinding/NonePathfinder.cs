using System.Collections.Generic;
using Melia.Shared.World;

namespace Melia.Zone.World.Maps.Pathfinding
{
	/// <summary>
	/// A pathfinder that does not find paths, and instead returns a direct path
	/// to a destination.
	/// </summary>
	public class NonePathfinder : IPathfinder
	{
		/// <summary>
		/// Returns an unchecked path with only the start and destination positions.
		/// </summary>
		/// <param name="start"></param>
		/// <param name="destination"></param>
		/// <param name="actorRadius"></param>
		/// <param name="path"></param>
		/// <returns></returns>
		public bool TryFindPath(Position start, Position destination, float actorRadius, out List<Position> path)
		{
			path = [start, destination];
			return true;
		}
	}
}
