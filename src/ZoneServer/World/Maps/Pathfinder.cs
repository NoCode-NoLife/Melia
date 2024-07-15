using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.World;
using System.Drawing;
using Yggdrasil.Geometry;
using Yggdrasil.Geometry.Shapes;

namespace Melia.Zone.World.Maps
{
	public class Pathfinder
	{
		private readonly int _maxGridWidth = 100;
		private readonly int _maxGridHeight = 100;
		
		private Ground _ground;
		private int _gridWidth;
		private int _gridHeight;
		private int _gridScale;
		public bool[,] _grid;

		/// <summary>
		/// Initializes the grid based on given ground.
		/// </summary>
		public void Load(Ground ground)
		{
			_ground = ground;
			_ground.GetBoundingBox(out var width, out var height);
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
		/// Gets via out the grid index of a given position in the ground.
		/// Returns -1, -1 if position is out of bounds.
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		public void GetGridIndex(Position pos, out int gridX, out int gridZ)
		{
			gridX = ((int)pos.X + (_gridWidth * _gridScale / 2)) / _gridScale;
			gridZ = ((int)pos.Z + (_gridHeight * _gridScale / 2)) / _gridScale;

			// Position is out of bounds
			if (gridX < 0 || gridX >= _gridWidth || gridZ < 0 || gridZ >= _gridHeight)
			{
				gridX = -1;
				gridZ = -1;
			}
		}

		/// <summary>
		/// Finds a path from the start position to the goal position using
		/// the A* algorithm. Returns List of valid positions to goal.
		/// The return list first element is always the start and the
		/// last element is always the goal.
		/// Returns null if no path can be found.
		/// </summary>
		/// <param name="start"></param>
		/// <param name="goal"></param>
		/// <returns></returns>
		public List<Position> FindPath(Position start, Position goal)
		{
			var openSet = new PriorityQueue<Position, float>();
			var cameFrom = new Dictionary<Position, Position>();
			var gScore = new Dictionary<Position, float> { [start] = 0 };
			var fScore = new Dictionary<Position, float> { [start] = this.Heuristic(start, goal) };

			openSet.Enqueue(start, fScore[start]);

			while (openSet.Count > 0)
			{
				var current = openSet.Dequeue();

				// Found path
				var distX = Math.Abs(goal.X - current.X);
				var distZ = Math.Abs(goal.Z - current.Z);
				if ( ((distX <= _gridScale) || (distZ <= _gridScale)) && (_ground.GetLastValidPosition(current, goal) == goal) )
				{
					var path = new List<Position>();
					path.AddRange(this.ReconstructPath(cameFrom, current));
					path.Add(goal);
					return path;
				}

				// Compute neighbors
				foreach (var neighbor in this.GetNeighbors(current))
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
		/// Reconstructs the path from the start position to the goal position.
		/// </summary>
		/// <param name="cameFrom"</param>
		/// <param name="current"></param>
		/// <returns>A list of positions representing the path.</returns>
		private List<Position> ReconstructPath(Dictionary<Position, Position> cameFrom, Position current)
		{
			var totalPath = new List<Position>();
			totalPath.Add(current);
			while (cameFrom.ContainsKey(current))
			{
				current = cameFrom[current];
				totalPath.Add(current);
			}
			totalPath.Reverse();
			return totalPath;
		}

		/// <summary>
		/// Calculates the heuristic cost from the current position to the
		/// goal position.
		/// </summary>
		/// <param name="a">The current position.</param>
		/// <param name="b">The goal position.</param>
		/// <returns>The heuristic cost.</returns>
		private float Heuristic(Position a, Position b)
		{
			// Euclidean Distance
			var dx = Math.Abs(a.X - b.X);
			var dz = Math.Abs(a.Z - b.Z);
			return (float)Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dz, 2));
		}

		/// <summary>
		/// Gets the neighboring positions for a given position.
		/// </summary>
		/// <param name="pos"></param>
		/// <returns>A list of neighboring positions.</returns>
		private List<Position> GetNeighbors(Position pos)
		{
			var neighbors = new List<Position>();
			var d = _gridScale;
			var directions = new (int X, int Z)[] { (-d, 0), (d, 0), (0, -d), (0, d), (-d, d), (-d, -d), (d, -d), (d, d) };

			foreach (var dir in directions)
			{
				var neighbor = new Position(pos.X + dir.X, 0, pos.Z + dir.Z);
				this.GetGridIndex(neighbor, out var gridX, out var gridZ);

				// Neighbour is valid in grid
				if (this.IsValidGridPosition(gridX, gridZ) && _grid[gridX, gridZ])
				{
					// Neighbour is valid walkable position
					if (_ground.TryGetHeightAt(neighbor, out var y))
					{
						// Clear path to neighbour
						if (_ground.GetLastValidPosition(pos, neighbor) == neighbor)
						{
						
							neighbors.Add(new Position(neighbor.X, y, neighbor.Z));
						}
					}
				}
			}

			return neighbors;
		}

		/// <summary>
		/// Checks if the given grid coordinates are within the bounds of the
		/// grid.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="z"></param>
		/// <returns>True if the coordinates are within the bounds of the grid,
		/// otherwise false.</returns>
		private bool IsValidGridPosition(int x, int z)
		{
			return x >= 0 && x < _gridWidth && z >= 0 && z < _gridHeight;
		}
	}
}
