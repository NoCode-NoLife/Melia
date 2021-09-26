using System;
using System.Linq;
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

		/// <summary>
		/// Loads the ground data.
		/// </summary>
		/// <param name="data"></param>
		public void Load(GroundData data)
		{
			_data = data;
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
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns the height of the ground at the given 2D position.
		/// </summary>
		/// <remarks>
		/// Only X and Z are used by this function.
		/// </remarks>
		/// <param name="pos"></param>
		/// <returns></returns>
		public float GetHeightAt(Position pos)
		{
			throw new NotImplementedException();
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
