using System.Linq;
using g3;
using Melia.Shared.Data.Database;
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

		/// <summary>
		/// Loads the ground data.
		/// </summary>
		/// <param name="data"></param>
		public void Load(GroundData data)
		{
			_data = data;

			this.LoadGroundMesh();
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
			var cPos = this.GetCellPosition(pos);
			return (cPos.Y != -1);
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
			for (var i = 0; i < _data.Cells.Length; ++i)
			{
				var cell = _data.Cells[i];

				// TODO: Quadtree for better performance.

				if (pos.InPolygon2D(cell.Vertices.Select(a => new Position(a.X, a.Z, a.Y)).ToArray()))
				{
					pos.Y = i;
					return pos;
				}
			}

			pos.Y = -1;
			return pos;
		}
	}
}
