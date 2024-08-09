using System.Collections.Generic;
using Melia.Shared.World;
using Melia.Shared.Game.Const;

namespace Melia.Zone.World.Maps
{
	public interface IPathfinder
	{
		/// <summary>
		/// Loads pathfinding data given a map.
		/// </summary>
		/// <param name="map"></param>
		void Load(Map map);

		/// <summary>
		/// Finds a path from start position to the goal position using
		/// A* algorithm. Returns List of valid positions to goal.
		/// First element is always start.
		/// Last element is always the closest position to goal.
		/// Returns empty list if no path can be found.
		/// </summary>
		/// <param name="start"></param>
		/// <param name="goal"></param>
		/// <param name="entitySize"></param>
		/// <returns></returns>
		List<Position> FindPath(Position start, Position goal, SizeType entitySize = SizeType.M);
	}
}
