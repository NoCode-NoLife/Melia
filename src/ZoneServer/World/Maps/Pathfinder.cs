using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.World;
using Melia.Shared.Game.Const;
using g3;

namespace Melia.Zone.World.Maps
{
	public class Pathfinder
	{
		private readonly int _maxGridWidth = 100;
		private readonly int _maxGridHeight = 100;

		private readonly Dictionary<SizeType, float> _entitySizeRadius = new Dictionary<SizeType, float>
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
		private int _gridWidth;
		private int _gridHeight;
		private int _gridScale;
		private bool[,] _grid;

		/// <summary>
		/// Initializes the pathfinding spatial grid based on given ground.
		/// </summary>
		public void Load(Ground ground)
		{
			_ground = ground;
			_ground.GetBoundingBox(out var w, out var h);
			var width = (int)w;
			var height = (int)h;

			_gridWidth = Math.Min(width, _maxGridWidth);
			_gridHeight = Math.Min(height, _maxGridHeight);
			_grid = new bool[_gridWidth, _gridHeight];
			_gridScale = Math.Max(1, Math.Max(width, height) / Math.Max(_maxGridWidth, _maxGridHeight));

			// Geometric projection of map vertices into grid scale
			// In essence, this is spatial hashing
			for (var x = 0; x < _gridWidth; x++)
			{
				for (var z = 0; z < _gridHeight; z++)
				{
					var pos = new Position((x - _gridWidth / 2) * _gridScale, 0, (z - _gridHeight / 2) * _gridScale);
					_grid[x, z] = _ground.IsValidPosition(pos);
				}
			}
		}

		/// <summary>
		/// Finds a path from start position to the goal position using
		/// A* algorithm. Returns List of valid positions to goal.
		/// Last element is always the goal.
		/// Returns null if no path can be found.
		/// </summary>
		/// <param name="start"></param>
		/// <param name="goal"></param>
		/// <param name="entitySize"></param>
		/// <returns></returns>
		public List<Position> FindPath(Position start, Position goal, SizeType entitySize = SizeType.M)
		{
			var path = new List<Position>();
			var openSet = new PriorityQueue<Position, float>();
			var cameFrom = new Dictionary<Position, Position>();
			var gScore = new Dictionary<Position, float> { [start] = 0 };
			var fScore = new Dictionary<Position, float> { [start] = this.Heuristic(start, goal) };
			var radius = _entitySizeRadius[entitySize];
			
			// Start A*
			openSet.Enqueue(start, fScore[start]);
			while (openSet.Count > 0)
			{
				var current = openSet.Dequeue();

				// Arbitrary constraint so we don't make too many
				// position checks if goal is too far away.
				if (current.Get3DDistance(goal) < 50)
				{
					// Attempts possible walkable path to goal
					var nearestToGoal = _ground.GetLastValidCirclePosition(current, radius, goal);
					var distX = Math.Abs(goal.X - nearestToGoal.X);
					var distY = Math.Abs(goal.Y - nearestToGoal.Y);
					var distZ = Math.Abs(goal.Z - nearestToGoal.Z);
					if ((distX <= _gridScale) && (distY <= 10) && (distZ <= _gridScale))
					{
						// 'nearestToGoal' is closer or equal in distance to
						// goal compared to 'current', so we exchange 'current'
						// for 'nearestToGoal'.
						cameFrom[nearestToGoal] = current;
						if (nearestToGoal == current)
							cameFrom.Remove(current);

						// Reconstruct
						path.AddRange(this.ReconstructPath(cameFrom, nearestToGoal, entitySize));
						return path;
					}
				}

				// Compute neighbors
				var neighbors = this.GetNeighbors(current, entitySize, _gridScale);
				foreach (var neighbor in neighbors)
				{
					var tentativeGScore = gScore[current] + _gridScale;

					if (!gScore.ContainsKey(neighbor) || tentativeGScore < gScore[neighbor])
					{
						cameFrom[neighbor] = current;
						gScore[neighbor] = tentativeGScore;
						fScore[neighbor] = gScore[neighbor] + this.Heuristic(neighbor, goal);

						if (!openSet.UnorderedItems.Any(item => item.Element.Equals(neighbor)))
						{
							openSet.Enqueue(neighbor, fScore[neighbor]);
						}
					}
				}
			}

			// No path found
			return null;
		}

		/// <summary>
		/// Gets via out the grid index of a given position in the ground.
		/// Returns -1, -1 if position is out of bounds.
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		private void GetGridIndex(Position pos, out int gridX, out int gridZ)
		{
			gridX = ((int)pos.X + (_gridWidth * _gridScale / 2)) / _gridScale;
			gridZ = ((int)pos.Z + (_gridHeight * _gridScale / 2)) / _gridScale;

			// Position is out of bounds
			if (!this.IsWithinGrid(gridX, gridZ))
			{
				gridX = -1;
				gridZ = -1;
			}
		}

		/// <summary>
		/// Compares two float and position tuples.
		/// </summary>
		private class PositionComparer : IComparer<(float F, Position Pos)>
		{
			public int Compare((float F, Position Pos) p1, (float F, Position Pos) p2)
			{
				var result = p1.F.CompareTo(p2.F);
				if (result == 0)
				{
					// Ignore Y coord
					result = p1.Pos.X.CompareTo(p2.Pos.X);
					if (result == 0)
					{
						result = p1.Pos.Z.CompareTo(p2.Pos.Z);
					}
				}
				return result;
			}
		}

		/// <summary>
		/// Reconstructs the path from the given position,
		/// merging nodes together if there are no obstacles between them
		/// considering the entity size.
		/// </summary>
		/// <param name="cameFrom"></param>
		/// <param name="position"></param>
		/// <param name="entitySize"></param>
		/// <returns></returns>
		private List<Position> ReconstructPath(Dictionary<Position, Position> cameFrom, Position position, SizeType entitySize)
		{
			var radius = _entitySizeRadius[entitySize];
			var totalPath = new List<Position>();
			totalPath.Add(position);

			while (cameFrom.ContainsKey(position))
			{
				var nextNode = cameFrom[position];

				// Check if we can skip intermediate nodes
				var lastValidPos = _ground.GetLastValidCirclePosition(nextNode, radius, position);
				while (cameFrom.ContainsKey(nextNode) && lastValidPos.Equals(position))
				{
					nextNode = cameFrom[nextNode];
					lastValidPos = _ground.GetLastValidCirclePosition(nextNode, radius, position);
				}

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
			// Euclidean Distance
			var dx = Math.Abs(a.X - b.X);
			var dz = Math.Abs(a.Z - b.Z);
			return (float)Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dz, 2));
		}

		/// <summary>
		/// Gets the neighboring positions for a given position under a given
		/// grid scale.
		/// </summary>
		/// <param name="pos"></param>
		/// <param name="entitySize"></param>
		/// <param name="gridScale"></param>
		/// <returns>A list of neighboring positions.</returns>
		private List<Position> GetNeighbors(Position pos, SizeType entitySize, int gridScale)
		{
			// Scale is too low
			if (gridScale <= 0)
				return new List<Position>();

			var radius = _entitySizeRadius[entitySize];
			var neighbors = new List<Position>();
			var d = gridScale;
			var directions = new (int X, int Z)[] { (-d, 0), (d, 0), (0, -d), (0, d), (-d, d), (-d, -d), (d, -d), (d, d) };

			// Search in all adjacent directions
			foreach (var dir in directions)
			{
				var neighbor = new Position(pos.X + dir.X, 0, pos.Z + dir.Z);
				this.GetGridIndex(neighbor, out var gridX, out var gridZ);

				// Neighbor is within grid and is a valid position
				if (this.IsWithinGrid(gridX, gridZ) && _grid[gridX, gridZ])
				{
					// Entity can walk to neighbor
					var isWalkable = _ground.GetLastValidCirclePosition(pos, radius, neighbor) == neighbor;
					if (_ground.TryGetHeightAt(neighbor, out var height) && isWalkable)
					{
						neighbor.Y = height;
						neighbors.Add(neighbor);
					}
				}
			}

			// No adjacent neighbors found
			if (neighbors.Count == 0)
			{
				// Try again recursively with lower scale
				return this.GetNeighbors(pos, entitySize, gridScale/2);
			}

			return neighbors;
		}

		/// <summary>
		/// Checks if the given grid coordinates are within the bounds of the
		/// grid.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="z"></param>
		/// <returns></returns>
		private bool IsWithinGrid(int x, int z)
		{
			return x >= 0 && x < _gridWidth && z >= 0 && z < _gridHeight;
		}
	}
}
