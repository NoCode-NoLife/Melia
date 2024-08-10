using System.Collections.Generic;
using Melia.Shared.World;

namespace Melia.Zone.World.Maps.Pathfinding
{
	/// <summary>
	/// Describes a path finder.
	/// </summary>
	public interface IPathfinder
	{
		/// <summary>
		/// Finds a path that leads from the start position to the destination,
		/// returning it via out. Returns false if no path could be found.
		/// </summary>
		/// <remarks>
		/// The first element is always the start and the last one is the position
		/// closest to the destination.
		/// </remarks>
		/// <param name="start"></param>
		/// <param name="destination"></param>
		/// <param name="actorRadius"></param>
		/// <param name="path"></param>
		/// <returns></returns>
		bool TryFindPath(Position start, Position destination, float actorRadius, out List<Position> path);
	}
}
