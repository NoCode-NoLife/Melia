using System.Diagnostics;
using System.Linq;
using g3;
using Melia.Shared.Data.Database;
using Melia.Shared.Util;
using Melia.Shared.World;

namespace Melia.Channel.World
{
	/// <summary>
	/// Represents a map's ground.
	/// </summary>
	public class Ground
	{
		private GroundData _data;
		private DMesh3 _mesh;
		private DMeshAABBTree3 _spatial;
		private Polygon2d[] _cells;

		/// <summary>
		/// Loads the ground data.
		/// </summary>
		/// <param name="data"></param>
		public void Load(GroundData data)
		{
			_data = data;

			this.LoadGroundMesh();
			this.LoadCells();
		}

		/// <summary>
		/// Generates a mesh for the ground that we can work with.
		/// </summary>
		private void LoadGroundMesh()
		{
			var vertices = _data.Vertices.Select(a => new Vector3f(a.X, a.Z, a.Y));
			var triangles = _data.Triangles.Select(a => new Index3i(a.Indices[0], a.Indices[1], a.Indices[2]));

			_mesh = DMesh3Builder.Build<Vector3f, Index3i, Vector3f>(vertices, triangles, null, null);

			_spatial = new DMeshAABBTree3(_mesh);
			_spatial.Build();
		}

		/// <summary>
		/// Generates cells from ground data.
		/// </summary>
		private void LoadCells()
		{
			_cells = new Polygon2d[_data.Cells.Length];

			for (var i = 0; i < _data.Cells.Length; ++i)
			{
				var vertices = _data.Cells[i].Vertices.Select(a => new Vector2d(a.X, a.Y)).ToArray();
				var polygon = new Polygon2d(vertices);

				_cells[i] = polygon;
			}
		}

		/// <summary>
		/// Returns whether the given 2D position is a valid position for
		/// an entity to stand on.
		/// </summary>
		/// <remarks>
		/// Only X and Z are used by this function.
		/// </remarks>
		/// <param name="pos"></param>
		/// <returns></returns>
		public bool IsValidPosition(Position pos)
		{
			return this.TryGetCellIndex(pos, out _);
		}

		/// <summary>
		/// Returns the height of the ground at the given 2D position.
		/// If there's not ground at the position, NaN is returned.
		/// </summary>
		/// <remarks>
		/// Only X and Z are used by this function.
		/// </remarks>
		/// <param name="pos"></param>
		/// <returns></returns>
		public float GetHeightAt(Position pos)
		{
			var origin = new Vector3f(pos.X, 1000, pos.Z);
			var ray = new Ray3f(origin, new Vector3f(0, -1, 0));

			var hitId = _spatial.FindNearestHitTriangle(ray);
			if (hitId == DMesh3.InvalidID)
				return float.NaN;

			var intersection = MeshQueries.TriangleIntersection(_mesh, hitId, ray);
			var hitDistance = origin.Distance(ray.PointAt((float)intersection.RayParameter));

			return (1000 - hitDistance);
		}

		/// <summary>
		/// Returns a copy of position, where Y is replaced with the cell
		/// index. If no cell could be found, Y is -1.
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		public Position GetCellPosition(Position pos)
		{
			this.TryGetCellIndex(pos, out var cellIndex);

			pos.Y = cellIndex;
			return pos;
		}

		/// <summary>
		/// Returns the cell index for the given position via out. Returns
		/// false if no cell exists at the position.
		/// </summary>
		/// <param name="pos"></param>
		/// <param name="cellIndex"></param>
		/// <returns></returns>
		public bool TryGetCellIndex(Position pos, out int cellIndex)
		{
			var vecPos = new Vector2d(pos.X, pos.Z);

			// TODO: Quadtree?

			for (var i = 0; i < _data.Cells.Length; ++i)
			{
				var cell = _cells[i];

				if (cell.Contains(vecPos))
				{
					cellIndex = i;
					return true;
				}
			}

			cellIndex = -1;
			return true;
		}
	}
}
