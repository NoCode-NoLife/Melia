using System;

namespace Melia.Shared.World
{
	/// <summary>
	/// Describes the direction an entity is looking at.
	/// </summary>
	public readonly struct Direction
	{
		public readonly float Cos;
		public readonly float Sin;

		/// <summary>
		/// Returns the direction as an angle in degree, where 0° is south.
		/// </summary>
		public float DegreeAngle
		{
			get
			{
				var result = this.RadianAngle * (180.0 / Math.PI) + 90;

				// Normalize
				result %= 360.0;
				result = (result > 0 ? result : result + 360);

				if (Math.Abs(result - 360) < 0.00001)
					result = 0;

				return (float)result;
			}
		}

		/// <summary>
		/// Returns the direction as an angle in degree, where 0° is east.
		/// </summary>
		public float NormalDegreeAngle
		{
			get
			{
				var result = this.RadianAngle * (180.0 / Math.PI);

				// Normalize
				result %= 360.0;
				result = (result > 0 ? result : result + 360);

				if (Math.Abs(result - 360) < 0.00001)
					result = 0;

				return (float)result;
			}
		}

		/// <summary>
		/// Returns the direction as an angle in radians.
		/// </summary>
		public float RadianAngle => (float)Math.Atan2(this.Sin, this.Cos);

		/// <summary>
		/// Returns a new direction with zero values.
		/// </summary>
		public static Direction Zero => new Direction(0, 0);

		/// <summary>
		/// Returns a direction that points north.
		/// </summary>
		public static Direction North => new Direction(0, 1);

		/// <summary>
		/// Returns a direction that points west.
		/// </summary>
		public static Direction NorthWest => new Direction(-0.7071068f, 0.7071068f);

		/// <summary>
		/// Returns a direction that points east.
		/// </summary>
		public static Direction NorthEast => new Direction(0.7071068f, 0.7071068f);

		/// <summary>
		/// Returns a direction that points south.
		/// </summary>
		public static Direction South => new Direction(0, -1);

		/// <summary>
		/// Returns a direction that points south west.
		/// </summary>
		public static Direction SouthWest => new Direction(-0.7071068f, -0.7071068f);

		/// <summary>
		/// Returns a direction that points south east.
		/// </summary>
		public static Direction SouthEast => new Direction(0.7071068f, -0.7071068f);

		/// <summary>
		/// Returns a direction that points east.
		/// </summary>
		public static Direction East => new Direction(1, 0);

		/// <summary>
		/// Returns a direction that points west.
		/// </summary>
		public static Direction West => new Direction(-1, 0);

		/// <summary>
		/// Returns a direction that, relative to this direction,
		/// points right.
		/// </summary>
		public Direction Right => new Direction(this.DegreeAngle - 90);

		/// <summary>
		/// Returns a direction that, relative to this direction,
		/// points left.
		/// </summary>
		public Direction Left => new Direction(this.DegreeAngle + 90);

		/// <summary>
		/// Returns a direction that points in the opposite direction from
		/// this direction.
		/// </summary>
		public Direction Backwards => new Direction(this.DegreeAngle + 180);

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
			// 0° means south in ToS, so we need to offset the degree by -90.
			degree -= 90;

			var radian = degree * (Math.PI / 180.0);

			this.Cos = (float)Math.Cos(radian);
			this.Sin = (float)Math.Sin(radian);
		}

		/// <summary>
		/// Returns a new direction, with the given angle added to it.
		/// </summary>
		/// <param name="degreeAngle"></param>
		/// <returns></returns>
		public Direction AddDegreeAngle(float degreeAngle)
		{
			var degree = this.DegreeAngle;
			degree += degreeAngle;

			return new Direction(degree);
		}

		/// <summary>
		/// Returns a new direction, with an adjusted angle, where 0° is east.
		/// </summary>
		/// <returns></returns>
		public Direction GetNormal()
			=> new Direction(this.NormalDegreeAngle);

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
