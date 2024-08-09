using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.World;
using Yggdrasil.Util;

namespace Melia.Zone.World.Maps
{
	/// <summary>
	/// A pathfinder that uses a dynamic grid to find paths.
	/// </summary>
	public class DynamicGridPathfinder : IPathfinder
	{
		private readonly static int MaxNodeExpand = 500;

		private readonly Ground _ground;

		/// <summary>
		/// Creates a new instance for the given map.
		/// </summary>
		/// <param name="map"></param>
		public DynamicGridPathfinder(Map map)
		{
			_ground = map.Ground;
		}

		/// <summary>
		/// Finds a path that leads from the start position to the destination,
		/// returning it via out. Returns false if no path could be found.
		/// </summary>
		/// <remarks>
		/// Uses A* algorithm and a dynamic grid to find the path between the
		/// two positions. The first element is always the start and the last one
		/// is the position closest to the destination.
		/// </remarks>
		/// <param name="start"></param>
		/// <param name="goal"></param>
		/// <param name="entitySize"></param>
		/// <param name="path"></param>
		/// <returns></returns>
		public bool TryFindPath(Position start, Position goal, float actorRadius, out List<Position> path)
		{
			path = null;

			if (_ground == null)
				return false;

			// Initial dynamic grid size
			var distance = start.Get2DDistance(goal);
			var gridScale = this.GetGridScale(distance, actorRadius);

			// Finds path
			var roughPath = this.FindPathScale(start, goal, gridScale, actorRadius);

			// Removes repeated positions
			var visited = new HashSet<Position>();
			path = new List<Position>();

			foreach (var pos in roughPath)
			{
				// Adds only nonrepeating positions
				if (!visited.Contains(pos))
				{
					path.Add(pos);
					visited.Add(pos);
				}
			}

			// Positive result if path is not empty
			return path.Count != 0;
		}

		/// <summary>
		/// Finds a path from start position to the goal position using
		/// A* algorithm and a path node scale.
		/// Returns empty list if no path can be found.
		/// </summary>
		/// <param name="start"></param>
		/// <param name="goal"></param>
		/// <param name="gridScale"></param>
		/// <param name="actorRadius"></param>
		/// <returns></returns>
		private List<Position> FindPathScale(Position start, Position goal, int gridScale, float actorRadius)
		{
			var path = new List<Position>();
			var openSet = new PriorityQueue<Position, float>();
			var cameFrom = new Dictionary<Position, Position>();
			var gScore = new Dictionary<Position, float> { [start] = 0 };
			var fScore = new Dictionary<Position, float> { [start] = this.Heuristic(start, goal) };
			var radius = actorRadius;

			// Stopping condition
			if ((gridScale <= 10) || (start.Get2DDistance(goal) < radius))
			{
				if (_ground.IsValidCirclePosition(start, radius))
					path.Add(start);

				return path;
			}

			// Start A*
			openSet.Enqueue(start, fScore[start]);
			while ((openSet.Count > 0) && openSet.Count < MaxNodeExpand)
			{
				var current = openSet.Dequeue();
				var distance = current.Get2DDistance(goal);

				// Make our grid scale smaller as we approach target.
				if (distance < gridScale * 2)
				{
					path.AddRange(this.ReconstructPath(cameFrom, current));
					gridScale = this.GetGridScale(distance, actorRadius);
					path.AddRange(this.FindPathScale(current, goal, gridScale, actorRadius));
					return path;
				}

				// Adjacent neighbors
				var neighbors = this.GetNeighbors(current, actorRadius, gridScale);

				// Always add one neighbor in last valid position towards goal
				var direction = current.GetDirection(goal);
				var neighborTowardsGoal = current.GetRelative(direction, gridScale);
				neighbors.Add(_ground.GetLastValidCirclePosition(current, radius, neighborTowardsGoal));

				// Update scores
				foreach (var neighbor in neighbors)
				{
					var tentativeGScore = gScore[current] + gridScale;

					if (!gScore.ContainsKey(neighbor) || tentativeGScore < gScore[neighbor])
					{
						cameFrom[neighbor] = current;
						gScore[neighbor] = tentativeGScore;
						var randomFactor = RandomProvider.Get().Next(gridScale * 2);
						fScore[neighbor] = gScore[neighbor] + this.Heuristic(neighbor, goal) + randomFactor;

						if (!openSet.UnorderedItems.Any(item => item.Element.Equals(neighbor)))
						{
							openSet.Enqueue(neighbor, fScore[neighbor]);
						}
					}
				}
			}

			// No path found
			return path;
		}

		/// <summary>
		/// Gets the dynamic grid scale.
		/// </summary>
		/// <param name="distance"></param>
		/// <param name="actorRadius"></param>
		/// <returns></returns>
		private int GetGridScale(double distance, float actorRadius)
		{
			// radius * 2 is the maximum guaranteed value to not cause entities
			// to go through objects. The client cannot handle this, so it
			// displays as if entities are teleporting around. Values higher
			// may cause this visual issue but it may also be desirable due
			// to computational reasons.

			return (int)Math.Min(distance / 2, actorRadius * 2);
		}

		/// <summary>
		/// Reconstructs the path from the given position.
		/// </summary>
		/// <param name="cameFrom"></param>
		/// <param name="position"></param>
		/// <returns></returns>
		private List<Position> ReconstructPath(Dictionary<Position, Position> cameFrom, Position position)
		{
			var totalPath = new List<Position>();
			totalPath.Add(position);

			while (cameFrom.ContainsKey(position))
			{
				var nextNode = cameFrom[position];

				position = nextNode;
				totalPath.Add(position);
			}

			totalPath.Reverse();
			return totalPath;
		}

		/// <summary>
		/// Calculates the heuristic cost from position a to position b.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		private float Heuristic(Position a, Position b)
		{
			// Applying a height penalty makes the algorithm attempt to
			// equalize the height distance first (i.e. go up a ladder).
			var heightPenalty = 3f;

			// Euclidean Distance
			var dx = Math.Abs(a.X - b.X);
			var dy = Math.Abs(a.Y - b.Y) * heightPenalty;
			var dz = Math.Abs(a.Z - b.Z);

			return (float)Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2) + Math.Pow(dz, 2));
		}

		/// <summary>
		/// Gets the neighboring positions for a given position under a given
		/// grid scale.
		/// </summary>
		/// <param name="pos"></param>
		/// <param name="actorRadius"></param>
		/// <param name="gridScale"></param>
		/// <returns>A list of neighboring positions.</returns>
		private List<Position> GetNeighbors(Position pos, float actorRadius, int gridScale, int angleSubdivisions = 1)
		{
			// Scale is too low
			if (gridScale <= 0)
				return new List<Position>();

			var radius = actorRadius;
			var neighbors = new List<Position>();
			var d = gridScale;

			// Generate directions based on angle subdivisions
			var directions = this.GenerateDirections(d, angleSubdivisions);

			// Search in all generated directions
			foreach (var dir in directions)
			{
				var neighbor = new Position(pos.X + dir.X, 0, pos.Z + dir.Z);

				// Position at neighbor is valid
				if (_ground.TryGetHeightAt(neighbor, out var height))
				{
					// Our entity can stand there
					if (_ground.IsValidCirclePosition(neighbor, radius))
					{
						neighbor.Y = height;
						neighbors.Add(neighbor);
					}
				}
			}

			// Too little neighbors found, try again with
			// more angle subdivisions
			if (neighbors.Count <= 3 && angleSubdivisions < 8)
			{
				return this.GetNeighbors(pos, actorRadius, gridScale, angleSubdivisions * 2);
			}

			// If still no neighbors, try with lower scale
			if (neighbors.Count == 0)
			{
				return this.GetNeighbors(pos, actorRadius, gridScale / 2);
			}

			return neighbors;
		}

		/// <summary>
		/// Generates a list of directions based on a specified distance
		/// and number of subdivisions.
		/// </summary>
		/// <param name="distance"></param>
		/// <param name="subdivisions"></param>
		/// <returns></returns>
		private List<(int X, int Z)> GenerateDirections(int distance, int subdivisions)
		{
			var directions = new List<(int X, int Z)>();
			var angleStep = 2 * Math.PI / (8 * subdivisions);

			for (var i = 0; i < 8 * subdivisions; i++)
			{
				var angle = i * angleStep;
				var x = (int)Math.Round(distance * Math.Cos(angle));
				var z = (int)Math.Round(distance * Math.Sin(angle));
				directions.Add((x, z));
			}

			return directions;
		}
	}
}
