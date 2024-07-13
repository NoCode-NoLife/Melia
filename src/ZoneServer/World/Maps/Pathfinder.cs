using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.World;

namespace Melia.Zone.World.Maps
{
	public class Pathfinder
	{
		private readonly int _maxGridWidth = 80;
		private readonly int _maxGridHeight = 80;
		private readonly int _gridUnitMultiplier = 3;
		
		private Ground _ground;
		private int _gridWidth;
		private int _gridHeight;
		private int _gridScale;
		private int _gridUnit;
		private bool[,] _grid;

		/// <summary>
		/// Initializes the grid based on given ground.
		/// </summary>
		public void Load(Ground ground, int width, int height)
		{
			_ground = ground;
			_gridWidth = Math.Min(width, _maxGridWidth);
			_gridHeight = Math.Min(height, _maxGridHeight);
			_grid = new bool[_gridWidth, _gridHeight];
			_gridScale = Math.Max(1, Math.Max(width, height) / Math.Max(_maxGridWidth, _maxGridHeight));
			_gridUnit = _gridScale * _gridUnitMultiplier;

			// Geometric projection of map vertices into grid scale
			for (var x = 0; x < _gridWidth; x++)
			{
				for (var z = 0; z < _gridHeight; z++)
				{
					var pos = new Position((x - _gridWidth / 2) * _gridScale, 0, (z - _gridHeight / 2) * _gridScale);
					if (_ground.GetHeightAt(pos) == float.NaN)
						_grid[x, z] = false;
					else
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
		/// Returns null if no path can be found.
		/// </summary>
		/// <param name="start"></param>
		/// <param name="goal"></param>
		/// <returns></returns>
		public List<Position> FindPath(Position start, Position goal)
		{
			var openSet = new SortedSet<(float F, Position Pos)>(new PositionComparer());
			var cameFrom = new Dictionary<Position, Position>();
			var gScore = new Dictionary<Position, float> { [start] = 0 };
			var fScore = new Dictionary<Position, float> { [start] = this.Heuristic(start, goal) };

			openSet.Add((fScore[start], start));

			while (openSet.Count > 0)
			{
				var current = openSet.First().Pos;
				openSet.Remove(openSet.First());

				if (current.Get2DDistance(goal) <= _gridUnit)
					return this.ReconstructPath(cameFrom, current);

				foreach (var neighbor in this.GetNeighbors(current))
				{
					var tentativeGScore = gScore[current] + 1;

					if (!gScore.ContainsKey(neighbor) || tentativeGScore < gScore[neighbor])
					{
						cameFrom[neighbor] = current;
						gScore[neighbor] = tentativeGScore;
						fScore[neighbor] = gScore[neighbor] + this.Heuristic(neighbor, goal);
						if (!openSet.Any(n => n.Pos.Equals(neighbor)))
						{
							openSet.Add((fScore[neighbor], neighbor));
						}
					}
				}
			}

			// Path not found
			return null;
		}

		/// <summary>
		/// Compares two float and position tuples.
		/// </summary>
		private class PositionComparer : IComparer<(float F, Position Pos)>
		{
			public int Compare((float F, Position Pos) x, (float F, Position Pos) y)
			{
				var result = x.F.CompareTo(y.F);
				if (result == 0)
				{
					if (x.Pos == y.Pos)
					{
						return 0;
					}
					// Define a consistent way to compare positions
					result = x.Pos.X.CompareTo(y.Pos.X);
					if (result == 0)
					{
						result = x.Pos.Y.CompareTo(y.Pos.Y);
						if (result == 0)
						{
							result = x.Pos.Z.CompareTo(y.Pos.Z);
						}
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
			var totalPath = new List<Position> { current };
			while (cameFrom.ContainsKey(current))
			{
				current = cameFrom[current];
				var y = _ground.GetHeightAt(current);
				current.Y = y;
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
			return Math.Abs(a.X - b.X) + Math.Abs(a.Z - b.Z);
		}

		/// <summary>
		/// Gets the neighboring positions for a given position.
		/// </summary>
		/// <param name="pos"></param>
		/// <returns>A list of neighboring positions.</returns>
		private List<Position> GetNeighbors(Position pos)
		{
			var neighbors = new List<Position>();
			var d = _gridUnit;
			var directions = new (int X, int Z)[] { (-d, 0), (d, 0), (0, -d), (0, d), (-d, d), (-d, -d), (d, -d), (d, d) };

			foreach (var dir in directions)
			{
				var neighbor = new Position(pos.X + dir.X, 0, pos.Z + dir.Z);
				this.GetGridIndex(neighbor, out var gridX, out var gridZ);

				if (this.IsValidGridPosition(gridX, gridZ) && _grid[gridX, gridZ])
				{
					neighbors.Add(neighbor);
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
