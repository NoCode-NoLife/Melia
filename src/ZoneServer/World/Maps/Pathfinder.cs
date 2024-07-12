using System;
using System.Collections.Generic;
using System.Linq;
using g3;
using Melia.Shared.World;
using Melia.Zone.World.Maps;

namespace Melia.Zone.World.Maps
{
	public class Pathfinder
	{
		private readonly Ground _ground;
		private readonly int _gridWidth;
		private readonly int _gridHeight;
        private bool[,] _grid;

        /// <summary>
        /// Initializes a new instance of the Pathfinder class.
        /// </summary>
        /// <param name="ground"></param>
        /// <param name="gridWidth"></param>
        /// <param name="gridHeight"></param>
        public Pathfinder(Ground ground, int gridWidth, int gridHeight)
		{
			_ground = ground;
			_gridWidth = gridWidth;
			_gridHeight = gridHeight;
			this.InitializeGrid();
		}

		/// <summary>
		/// Initializes the grid based on the ground data.
		/// </summary>
		private void InitializeGrid()
		{
			_grid = new bool[_gridWidth, _gridHeight];

			for (var x = 0; x < _gridWidth; x++)
			{
				for (var z = 0; z < _gridHeight; z++)
				{
					var pos = new Position(x, 0, z);
					_grid[x, z] = _ground.IsValidPosition(pos);
				}
			}
		}

		/// <summary>
		/// Finds a path from the start position to the goal position using
		/// the A* algorithm.
		/// </summary>
		/// <param name="start"></param>
		/// <param name="goal"></param>
		/// <returns>List of valid positions to goal</returns>
		public List<Position> FindPath(Position start, Position goal)
		{
			var openSet = new SortedSet<(float F, Position Pos)>();
			var cameFrom = new Dictionary<Position, Position>();
			var gScore = new Dictionary<Position, float> { [start] = 0 };
			var fScore = new Dictionary<Position, float> { [start] = this.Heuristic(start, goal) };

			openSet.Add((fScore[start], start));

			while (openSet.Count > 0)
			{
				var current = openSet.First().Pos;
				openSet.Remove(openSet.First());

				if (current.Equals(goal))
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

			return null; // Path not found
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
			var directions = new (int X, int Z)[] { (-1, 0), (1, 0), (0, -1), (0, 1) };

			foreach (var dir in directions)
			{
				var neighbor = new Position(pos.X + dir.X, 0, pos.Z + dir.Z);
				var gridX = (int)Math.Floor(neighbor.X);
				var gridZ = (int)Math.Floor(neighbor.Z);

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
