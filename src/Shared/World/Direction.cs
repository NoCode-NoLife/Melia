// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;

namespace Melia.Shared.World
{
	/// <summary>
	/// Describes the direction an entity is looking at.
	/// </summary>
	public struct Direction
	{
		public readonly float Cos;
		public readonly float Sin;

		/// <summary>
		/// Creates new direction from values.
		/// </summary>
		/// <param name="cos"></param>
		/// <param name="sin"></param>
		public Direction(float cos, float sin)
		{
			this.Cos = cos;
			this.Sin = sin;
		}

		/// <summary>
		/// Creates new direction from direction.
		/// </summary>
		/// <param name="dir"></param>
		public Direction(Direction dir)
		{
			this.Cos = dir.Cos;
			this.Sin = dir.Sin;
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

			this.Cos = (float)Math.Cos(degree);
			this.Sin = (float)Math.Sin(degree);
		}

		/// <summary>
		/// Returns true if the directions have the same cos and sin
		/// values.
		/// </summary>
		/// <param name="dir1"></param>
		/// <param name="dir2"></param>
		/// <returns></returns>
		public static bool operator ==(Direction dir1, Direction dir2)
		{
			return (dir1.Cos == dir2.Cos && dir1.Sin == dir2.Sin);
		}

		/// <summary>
		/// Returns true if the directions don't have the same cos and
		/// sin values.
		/// </summary>
		/// <param name="dir1"></param>
		/// <param name="dir2"></param>
		/// <returns></returns>
		public static bool operator !=(Direction dir1, Direction dir2)
		{
			return !(dir1 == dir2);
		}

		/// <summary>
		/// Returns true if the given object is a direction with the same
		/// values as this instance's.
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public override bool Equals(object obj)
		{
			return (obj is Direction direction && this == direction);
		}

		/// <summary>
		/// Returns a hash code for this direction's values.
		/// </summary>
		/// <returns></returns>
		public override int GetHashCode()
		{
			var hashCode = -1221995383;
			hashCode = hashCode * -1521134295 + this.Cos.GetHashCode();
			hashCode = hashCode * -1521134295 + this.Sin.GetHashCode();
			return hashCode;
		}
	}
}
