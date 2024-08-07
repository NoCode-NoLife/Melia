using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.World;
using Melia.Shared.Game.Const;
using Yggdrasil.Util;

namespace Melia.Zone.World.Maps
{
	public class BasicPathfinder : IPathfinder
	{
		private readonly static int MaxNodeExpand = 500;
		private readonly static Dictionary<SizeType, float> EntitySizeRadius = new()
		{
			{ SizeType.None, 0 },
			{ SizeType.Hidden, 0 },
			{ SizeType.S, 12 },
			{ SizeType.M, 15 },
			{ SizeType.L, 20 },
			{ SizeType.XL, 40 },
			{ SizeType.XXL, 40 }
		};

		private Ground _ground;

		/// <summary>
		/// Loads pathfinding data given a map.
		/// </summary>
		/// <param name="map"></param>
		public void Load(Map map)
		{
			_ground = map.Ground;
		}

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
		public List<Position> FindPath(Position start, Position goal, SizeType entitySize = SizeType.M)
		{
			// Entity size not valid
			if (!Enum.IsDefined(typeof(SizeType), entitySize))
				return new List<Position>();

			// Initial dynamic grid size
			var distance = start.Get2DDistance(goal);
			var gridScale = this.GetGridScale(distance, entitySize);

			// Finds path
			var path = this.FindPathScale(start, goal, gridScale, entitySize);

			// Removes repeated positions
			var visited = new HashSet<Position>();
			var finalPath = new List<Position>();
			foreach (var pos in path)
			{
				// Adds only nonrepeating positions
				if (!visited.Contains(pos))
				{
					finalPath.Add(pos);
					visited.Add(pos);
				}
			}

			return finalPath;
		}

		/// <summary>
		/// Finds a path from start position to the goal position using
		/// A* algorithm and a path node scale.
		/// Returns empty list if no path can be found.
		/// </summary>
		/// <param name="start"></param>
		/// <param name="goal"></param>
		/// <param name="gridScale"></param>
		/// <param name="entitySize"></param>
		/// <returns></returns>
		private List<Position> FindPathScale(Position start, Position goal, int gridScale, SizeType entitySize = SizeType.M)
		{
			var path = new List<Position>();
			var openSet = new PriorityQueue<Position, float>();
			var cameFrom = new Dictionary<Position, Position>();
			var gScore = new Dictionary<Position, float> { [start] = 0 };
			var fScore = new Dictionary<Position, float> { [start] = this.Heuristic(start, goal) };
			var radius = EntitySizeRadius[entitySize];

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
					gridScale = this.GetGridScale(distance, entitySize);
					path.AddRange(this.FindPathScale(current, goal, gridScale, entitySize));
					return path;
				}

				// Adjacent neighbors
				var neighbors = this.GetNeighbors(current, entitySize, gridScale);

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
		/// <param name="entitySize"></param>
		/// <returns></returns>
		private int GetGridScale(double distance, SizeType entitySize)
		{
			var radius = EntitySizeRadius[entitySize];
			// radius * 2 is the maximum guaranteed value to not cause entities
			// to go through objects. The client cannot handle this, so it
			// displays as if entities are teleporting around. Values higher
			// may cause this visual issue but it may also be desirable due
			// to computational reasons.
			return (int)Math.Min(distance / 2, radius * 2);
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
			var heightPenalty = 10f;

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
		/// <param name="entitySize"></param>
		/// <param name="gridScale"></param>
		/// <returns>A list of neighboring positions.</returns>
		private List<Position> GetNeighbors(Position pos, SizeType entitySize, int gridScale, int angleSubdivisions = 1)
		{
			// Scale is too low
			if (gridScale <= 0)
				return new List<Position>();

			var radius = EntitySizeRadius[entitySize];
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
				return this.GetNeighbors(pos, entitySize, gridScale, angleSubdivisions * 2);
			}

			// If still no neighbors, try with lower scale
			if (neighbors.Count == 0)
			{
				return this.GetNeighbors(pos, entitySize, gridScale / 2);
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
