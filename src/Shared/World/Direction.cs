using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Shared.World
{
	/// <summary>
	/// Describes the direction an entity is looking at.
	/// </summary>
	public struct Direction
	{
		public readonly float X;
		public readonly float Y;

		/// <summary>
		/// Creates new direction from values.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		public Direction(float x, float y)
		{
			this.X = x;
			this.Y = y;
		}

		/// <summary>
		/// Creates new direction from direction.
		/// </summary>
		/// <param name="dir"></param>
		public Direction(Direction dir)
		{
			this.X = dir.X;
			this.Y = dir.Y;
		}

		/// <summary>
		/// Creates direction from degree, e.g. 0~360,
		/// going anti-clockwise, 0 being down.
		/// </summary>
		/// <param name="degree"></param>
		public Direction(double degree)
		{
			degree -= 45;
			degree *= Math.PI / 180.0;

			this.X = (float)Math.Cos(degree);
			this.Y = (float)Math.Sin(degree);
		}
	}
}
