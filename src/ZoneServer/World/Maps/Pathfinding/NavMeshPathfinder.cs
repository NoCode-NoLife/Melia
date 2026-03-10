using System;
using System.Collections.Generic;
using Melia.Shared.Data.Database;
using Melia.Shared.World;

namespace Melia.Zone.World.Maps.Pathfinding
{
	/// <summary>
	/// A pathfinder that operates on the mesh the ground is made up of,
	/// finding paths across its cells.
	/// </summary>
	/// <remarks>
	/// While the game uses nav mesh pathfinding as well, this
	/// implementation is custom and might not match the game's
	/// behavior in all cases.
	/// 
	/// The cells are polygons, defined by the game, that represent
	/// walkable areas of the ground. They're connected similarly to
	/// the ground's triangles, but are shaped from the maps corners
	/// and edges, creating natural and spacious paths and portals
	/// around the map.
	/// </remarks>
	public class NavMeshPathfinder : IPathfinder
	{
		private readonly Ground _ground;
		private readonly NavMesh _navMesh;

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="ground"></param>
		public NavMeshPathfinder(Ground ground)
		{
			_ground = ground;
			_navMesh = new NavMesh(_ground);
		}

		/// <summary>
		/// Attempts to find a path between the two positions and returns
		/// it via out. Returns false if no valid path could be found.
		/// </summary>
		/// <param name="start"></param>
		/// <param name="destination"></param>
		/// <param name="actorRadius"></param>
		/// <param name="path"></param>
		/// <returns></returns>
		public bool TryFindPath(Position start, Position destination, float actorRadius, out List<Position> path)
		{
			path = [];

			if (_ground == null)
				return false;

			if (!_ground.TryGetHeightAt(start, out var startHeight) || !_ground.TryGetHeightAt(destination, out var destinationHeight))
				return false;

			start.Y = startHeight;
			destination.Y = destinationHeight;

			if (!_ground.IsValidCirclePosition(start, actorRadius) || !_ground.IsValidCirclePosition(destination, actorRadius))
				return false;

			if (_ground.GetLastValidCirclePosition(start, actorRadius, destination) == destination)
			{
				path.Add(start);
				path.Add(destination);

				return true;
			}

			if (!_navMesh.TryGetCellIndex(start, out var startCellIndex) || !_navMesh.TryGetCellIndex(destination, out var destinationCellIndex))
				return false;

			if (startCellIndex == destinationCellIndex)
			{
				path.Add(start);
				path.Add(destination);
				return true;
			}

			if (!this.TryFindCellPath(startCellIndex, destinationCellIndex, actorRadius, out var cellPath))
				return false;

			var rawPath = this.BuildFunnelPath(start, destination, cellPath, actorRadius);
			path = this.ValidatePath(rawPath, actorRadius);

			return path.Count >= 2;
		}

		/// <summary>
		/// Attempts to find a path between the two cells, returning
		/// the path as a list of cell indices via out. Returns false
		/// if no path could be found.
		/// </summary>
		/// <param name="startCellIndex"></param>
		/// <param name="destinationCellIndex"></param>
		/// <param name="actorRadius"></param>
		/// <param name="cellPath"></param>
		/// <returns></returns>
		private bool TryFindCellPath(int startCellIndex, int destinationCellIndex, float actorRadius, out List<int> cellPath)
		{
			cellPath = [];

			var openSet = new PriorityQueue<int, float>();
			var cameFrom = new Dictionary<int, int>();
			var gScore = new Dictionary<int, float> { [startCellIndex] = 0f };
			var fScore = new Dictionary<int, float> { [startCellIndex] = this.Heuristic(startCellIndex, destinationCellIndex) };
			var closedSet = new HashSet<int>();

			openSet.Enqueue(startCellIndex, fScore[startCellIndex]);

			while (openSet.Count > 0)
			{
				var current = openSet.Dequeue();

				if (!closedSet.Add(current))
					continue;

				if (current == destinationCellIndex)
				{
					cellPath = this.ReconstructCellPath(cameFrom, current);
					return true;
				}

				foreach (var portal in _navMesh.GetPortals(current))
				{
					if (portal.Width < actorRadius * 2f)
						continue;

					var neighbor = portal.CellB;
					if (closedSet.Contains(neighbor))
						continue;

					var tentativeGScore = gScore[current] + this.GetTravelCost(current, neighbor);

					if (gScore.TryGetValue(neighbor, out var existingGScore) && tentativeGScore >= existingGScore)
						continue;

					cameFrom[neighbor] = current;
					gScore[neighbor] = tentativeGScore;
					fScore[neighbor] = tentativeGScore + this.Heuristic(neighbor, destinationCellIndex);

					openSet.Enqueue(neighbor, fScore[neighbor]);
				}
			}

			return false;
		}

		/// <summary>
		/// Reconstructs the cell path produced by the A* algorithm,
		/// starting from the given cell index and working backwards
		/// until the start cell is reached. The returned path is in
		/// the correct order from start to destination.
		/// </summary>
		/// <param name="cameFrom"></param>
		/// <param name="current"></param>
		/// <returns></returns>
		private List<int> ReconstructCellPath(Dictionary<int, int> cameFrom, int current)
		{
			var path = new List<int> { current };

			while (cameFrom.TryGetValue(current, out var previous))
			{
				current = previous;
				path.Add(current);
			}

			path.Reverse();
			return path;
		}

		/// <summary>
		/// Heuristic function for A* that estimates the cost to reach the
		/// goal cell from the given cell. Uses the 2D distance
		/// between the centers.
		/// </summary>
		/// <param name="cellIndex"></param>
		/// <param name="goalCellIndex"></param>
		/// <returns></returns>
		private float Heuristic(int cellIndex, int goalCellIndex)
		{
			if (!_navMesh.TryGetCell(cellIndex, out var cell) || !_navMesh.TryGetCell(goalCellIndex, out var goalCell))
				return float.MaxValue;

			return (float)cell.Center.Get2DDistance(goalCell.Center);
		}

		/// <summary>
		/// Cost function for A* that returns the cost to travel from one
		/// cell to a neighboring cell. Uses the 2D distance
		/// between the centers as the cost.
		/// </summary>
		/// <param name="fromCellIndex"></param>
		/// <param name="toCellIndex"></param>
		/// <returns></returns>
		private float GetTravelCost(int fromCellIndex, int toCellIndex)
		{
			if (!_navMesh.TryGetCell(fromCellIndex, out var fromCell) || !_navMesh.TryGetCell(toCellIndex, out var toCell))
				return float.MaxValue;

			return (float)fromCell.Center.Get2DDistance(toCell.Center);
		}

		/// <summary>
		/// Builds a path across the given cell path using the funnel
		/// algorithm, returning a list of positions representing the
		/// path.
		/// </summary>
		/// <param name="start"></param>
		/// <param name="destination"></param>
		/// <param name="cellPath"></param>
		/// <param name="actorRadius"></param>
		/// <returns></returns>
		private List<Position> BuildFunnelPath(Position start, Position destination, List<int> cellPath, float actorRadius)
		{
			var portals = new List<(Position Left, Position Right)>
			{
				(start, start)
			};

			for (var i = 0; i < cellPath.Count - 1; ++i)
			{
				if (!this.TryGetPortal(cellPath[i], cellPath[i + 1], out var portal))
					continue;

				portals.Add((portal.Left, portal.Right));
			}

			portals.Add((destination, destination));

			return this.StringPull(portals, actorRadius);
		}

		/// <summary>
		/// Calculates the tangent point on a circle,representing a portal
		/// corner, from the current apex, ensuring the path routes around
		/// the corner with the given radius.
		/// </summary>
		private Position GetTangentPoint(Position apex, Position center, float radius, bool isLeftCircle)
		{
			if (radius <= 0.001f)
				return center;

			var dx = center.X - apex.X;
			var dz = center.Z - apex.Z;
			var dist = Math.Sqrt(dx * dx + dz * dz);

			if (dist <= radius)
				return center;

			var theta = (float)Math.Atan2(dz, dx);
			var alpha = (float)Math.Asin(radius / dist);

			var gamma = isLeftCircle ? theta + alpha + (float)Math.PI / 2f : theta - alpha - (float)Math.PI / 2f;

			var pointX = center.X + radius * (float)Math.Cos(gamma);
			var pointZ = center.Z + radius * (float)Math.Sin(gamma);

			var pt = new Position(pointX, center.Y, pointZ);

			if (_ground.TryGetHeightAt(pt, out var h))
				pt.Y = h;

			return pt;
		}

		/// <summary>
		/// Attempts to find the portal connecting the two given
		/// cells, returning it via out. Returns false if no portal
		/// exists between the cells.
		/// </summary>
		/// <param name="fromCellIndex"></param>
		/// <param name="toCellIndex"></param>
		/// <param name="portal"></param>
		/// <returns></returns>
		private bool TryGetPortal(int fromCellIndex, int toCellIndex, out NavMeshPortal portal)
		{
			foreach (var candidate in _navMesh.GetPortals(fromCellIndex))
			{
				if (candidate.CellB == toCellIndex)
				{
					portal = candidate;
					return true;
				}
			}

			portal = default;
			return false;
		}

		/// <summary>
		/// Implements the funnel algorithm to pull a path through the
		/// given portals, returning a list of positions representing the
		/// path.
		/// </summary>
		/// <param name="portals"></param>
		/// <returns></returns>
		private List<Position> StringPull(List<(Position Left, Position Right)> portals, float actorRadius)
		{
			var path = new List<Position>();

			if (portals.Count == 0)
				return path;

			var portalApex = portals[0].Left;
			var portalLeft = portals[0].Left;
			var portalRight = portals[0].Right;
			var apexIndex = 0;
			var leftIndex = 0;
			var rightIndex = 0;

			path.Add(portalApex);

			for (var i = 1; i < portals.Count; ++i)
			{
				// Use larger radius to account for tight corners where the
				// path might overwise clip into the wall.
				var radius = (i == portals.Count - 1) ? 0f : actorRadius * 1.5f;

				var leftCenter = portals[i].Left;
				var rightCenter = portals[i].Right;

				var left = this.GetTangentPoint(portalApex, leftCenter, radius, true);
				var right = this.GetTangentPoint(portalApex, rightCenter, radius, false);

				if (this.TriArea2(portalApex, left, right) <= 0.001f && left != right)
				{
					var mid = new Position((leftCenter.X + rightCenter.X) / 2f, (leftCenter.Y + rightCenter.Y) / 2f, (leftCenter.Z + rightCenter.Z) / 2f);
					if (_ground.TryGetHeightAt(mid, out var h)) mid.Y = h;
					left = right = mid;
				}

				if (this.TriArea2(portalApex, portalRight, right) <= 0f)
				{
					if (portalApex == portalRight || this.TriArea2(portalApex, portalLeft, right) > 0f)
					{
						portalRight = right;
						rightIndex = i;
					}
					else
					{
						path.Add(portalLeft);
						portalApex = portalLeft;
						apexIndex = leftIndex;
						portalLeft = portalApex;
						portalRight = portalApex;
						leftIndex = apexIndex;
						rightIndex = apexIndex;
						i = apexIndex;
						continue;
					}
				}

				if (this.TriArea2(portalApex, portalLeft, left) >= 0f)
				{
					if (portalApex == portalLeft || this.TriArea2(portalApex, portalRight, left) < 0f)
					{
						portalLeft = left;
						leftIndex = i;
					}
					else
					{
						path.Add(portalRight);
						portalApex = portalRight;
						apexIndex = rightIndex;
						portalLeft = portalApex;
						portalRight = portalApex;
						leftIndex = apexIndex;
						rightIndex = apexIndex;
						i = apexIndex;
						continue;
					}
				}
			}

			if (path[^1] != portals[^1].Left)
				path.Add(portals[^1].Left);

			return path;
		}

		/// <summary>
		/// Returns twice the signed area of the triangle formed by the
		/// three given points, treating them as 2D points (ignoring Y).
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="c"></param>
		/// <returns></returns>
		private float TriArea2(Position a, Position b, Position c)
		{
			var abX = b.X - a.X;
			var abZ = b.Z - a.Z;
			var acX = c.X - a.X;
			var acZ = c.Z - a.Z;

			return abX * acZ - acX * abZ;
		}

		/// <summary>
		/// Validates the given raw path by ensuring all points are on the
		/// ground and removing any redundant points. Also attempts to
		/// merge consecutive points where possible to create a more
		/// natural path.
		/// </summary>
		/// <param name="rawPath"></param>
		/// <param name="actorRadius"></param>
		/// <returns></returns>
		private List<Position> ValidatePath(List<Position> rawPath, float actorRadius)
		{
			var path = new List<Position>();
			if (rawPath.Count == 0)
				return path;

			foreach (var waypoint in rawPath)
			{
				var point = waypoint;

				if (!_ground.TryGetHeightAt(point, out var height))
					continue;

				point.Y = height;

				if (path.Count > 0 && path[^1] == point)
					continue;

				path.Add(point);
			}

			if (path.Count <= 2)
				return path;

			var simplified = new List<Position> { path[0] };

			for (var i = 1; i < path.Count - 1; ++i)
			{
				if (_ground.GetLastValidCirclePosition(simplified[^1], actorRadius, path[i + 1]) == path[i + 1])
					continue;

				simplified.Add(path[i]);
			}

			simplified.Add(path[^1]);
			return simplified;
		}

		private readonly record struct NavMeshCell(int Index, Position[] Vertices, Position Center);
		private readonly record struct NavMeshPortal(int CellA, int CellB, Position Left, Position Right, float Width);

		/// <summary>
		/// Holds the nav mesh cells and portals for a ground,
		/// providing methods to query them.
		/// </summary>
		private class NavMesh
		{
			private readonly Ground _ground;
			private readonly GroundData _data;

			private NavMeshCell[] _cells;
			private List<NavMeshPortal>[] _portalsByCell;

			/// <summary>
			/// Creates new instance.
			/// </summary>
			/// <param name="ground"></param>
			public NavMesh(Ground ground)
			{
				_ground = ground;
				_data = _ground.Data;

				this.Load();
			}

			/// <summary>
			/// Returns the nav mesh cell containing the given position.
			/// </summary>
			public bool TryGetCellIndex(Position pos, out int cellIndex)
			{
				if (_cells == null)
				{
					cellIndex = -1;
					return false;
				}

				cellIndex = -1;
				var closestHeightDelta = float.MaxValue;

				for (var i = 0; i < _cells.Length; ++i)
				{
					if (Contains2D(_cells[i], pos))
					{
						var heightDelta = Math.Abs(_cells[i].Center.Y - pos.Y);

						if (heightDelta < closestHeightDelta)
						{
							closestHeightDelta = heightDelta;
							cellIndex = i;
						}
					}
				}

				return cellIndex != -1;
			}

			/// <summary>
			/// Returns the nav mesh cell with the given index.
			/// </summary>
			/// <param name="cellIndex"></param>
			/// <param name="cell"></param>
			/// <returns></returns>
			public bool TryGetCell(int cellIndex, out NavMeshCell cell)
			{
				if (_cells == null || cellIndex < 0 || cellIndex >= _cells.Length)
				{
					cell = default;
					return false;
				}

				cell = _cells[cellIndex];
				return true;
			}

			/// <summary>
			/// Returns the portals connected to the given nav mesh cell.
			/// </summary>
			/// <param name="cellIndex"></param>
			/// <returns></returns>
			public IReadOnlyList<NavMeshPortal> GetPortals(int cellIndex)
			{
				if (_portalsByCell == null || cellIndex < 0 || cellIndex >= _portalsByCell.Length)
					return [];

				return _portalsByCell[cellIndex];
			}

			/// <summary>
			/// Builds nav mesh cells and portals from the loaded
			/// ground data.
			/// </summary>
			private void Load()
			{
				if (_data?.Cells == null)
				{
					_cells = [];
					_portalsByCell = [];
					return;
				}

				_cells = new NavMeshCell[_data.Cells.Length];
				_portalsByCell = new List<NavMeshPortal>[_data.Cells.Length];

				for (var i = 0; i < _portalsByCell.Length; ++i)
					_portalsByCell[i] = [];

				var edgeOwners = new Dictionary<(int, int), int>();

				for (var i = 0; i < _data.Cells.Length; ++i)
				{
					var cell = _data.Cells[i];
					var vertices = new Position[cell.Indices.Length];
					var center = new Position();

					for (var j = 0; j < cell.Indices.Length; ++j)
					{
						vertices[j] = this.GetPosition(cell.Indices[j]);

						center.X += vertices[j].X;
						center.Y += vertices[j].Y;
						center.Z += vertices[j].Z;
					}

					center.X /= cell.Indices.Length;
					center.Y /= cell.Indices.Length;
					center.Z /= cell.Indices.Length;

					_cells[i] = new NavMeshCell(i, vertices, center);

					for (var edgeIndex = 0; edgeIndex < cell.Indices.Length; ++edgeIndex)
					{
						var edge = GetCellEdge(cell.Indices, edgeIndex);
						var key = edge.Item1 < edge.Item2 ? edge : (edge.Item2, edge.Item1);

						if (edgeOwners.TryGetValue(key, out var otherCellIndex))
						{
							var v1 = this.GetPosition(key.Item1);
							var v2 = this.GetPosition(key.Item2);
							var portal = this.CreatePortal(otherCellIndex, i, v1, v2);

							_portalsByCell[otherCellIndex].Add(portal);
							_portalsByCell[i].Add(new NavMeshPortal(i, otherCellIndex, portal.Right, portal.Left, portal.Width));
						}
						else
						{
							edgeOwners[key] = i;
						}
					}
				}
			}

			/// <summary>
			/// Returns the position of the vertex with the given index in
			/// the ground data.
			/// </summary>
			/// <param name="vertexIndex"></param>
			/// <returns></returns>
			private Position GetPosition(int vertexIndex)
			{
				var vertex = _data.Vertices[vertexIndex];
				return new Position(vertex.X, vertex.Z, vertex.Y);
			}

			/// <summary>
			/// Creates a portal connecting the two given cells along
			/// the edge defined by the two given vertices.
			/// </summary>
			/// <param name="fromCellIndex"></param>
			/// <param name="toCellIndex"></param>
			/// <param name="firstVertex"></param>
			/// <param name="secondVertex"></param>
			/// <returns></returns>
			private NavMeshPortal CreatePortal(int fromCellIndex, int toCellIndex, Position firstVertex, Position secondVertex)
			{
				var fromCenter = _cells[fromCellIndex].Center;
				var toCenter = _cells[toCellIndex].Center;
				var travelX = toCenter.X - fromCenter.X;
				var travelZ = toCenter.Z - fromCenter.Z;
				var edgeX = secondVertex.X - firstVertex.X;
				var edgeZ = secondVertex.Z - firstVertex.Z;
				var cross = travelX * edgeZ - travelZ * edgeX;

				var left = cross >= 0 ? firstVertex : secondVertex;
				var right = cross >= 0 ? secondVertex : firstVertex;
				var width = (float)left.Get2DDistance(right);

				return new NavMeshPortal(fromCellIndex, toCellIndex, left, right, width);
			}

			/// <summary>
			/// Returns the two vertex indices that form the edge with the
			/// given index in the cell defined by the vertex indices.
			/// </summary>
			/// <param name="indices"></param>
			/// <param name="edgeIndex"></param>
			/// <returns></returns>
			private static (int, int) GetCellEdge(int[] indices, int edgeIndex)
			{
				return (indices[edgeIndex], indices[(edgeIndex + 1) % indices.Length]);
			}

			/// <summary>
			/// Returns true if the given point is within the 2D bounds of
			/// the cell.
			/// </summary>
			/// <param name="cell"></param>
			/// <param name="point"></param>
			/// <returns></returns>
			private static bool Contains2D(NavMeshCell cell, Position point)
			{
				var isInside = false;

				for (int i = 0, j = cell.Vertices.Length - 1; i < cell.Vertices.Length; j = i++)
				{
					if (((cell.Vertices[i].Z > point.Z) != (cell.Vertices[j].Z > point.Z)) && (point.X < (cell.Vertices[j].X - cell.Vertices[i].X) * (point.Z - cell.Vertices[i].Z) / (cell.Vertices[j].Z - cell.Vertices[i].Z) + cell.Vertices[i].X))
						isInside = !isInside;
				}

				return isInside;
			}
		}
	}
}
