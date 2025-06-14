using System;
using System.Globalization;
using Yggdrasil.Geometry;

namespace Melia.Shared.World
{
	public struct Position
	{
		/// <summary>
		/// X coordinate (left/right).
		/// </summary>
		public float X;

		/// <summary>
		/// Y coordinate (up/down).
		/// </summary>
		public float Y;

		/// <summary>
		/// Z coordinate (depth).
		/// </summary>
		public float Z;

		/// <summary>
		/// Returns new position with X, Y, and Z being 0.
		/// </summary>
		public static Position Zero => new(0, 0, 0);

		/// <summary>
		/// Returns a invalid position with X, Y, and Z being NaN.
		/// </summary>
		public static Position Invalid => new(float.NaN, float.NaN, float.NaN);

		/// <summary>
		/// Creates new position from coordinates.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		public Position(float x, float y, float z)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
		}

		/// <summary>
		/// Creates new position from position.
		/// </summary>
		/// <param name="pos"></param>
		public Position(Position pos)
		{
			this.X = pos.X;
			this.Y = pos.Y;
			this.Z = pos.Z;
		}

		/// <summary>
		/// Returns distance between this and another position in 2D space (X,Z).
		/// </summary>
		/// <param name="otherPos"></param>
		/// <returns></returns>
		public readonly double Get2DDistance(Position otherPos)
		{
			return Math.Sqrt(Math.Pow(X - otherPos.X, 2) + Math.Pow(Z - otherPos.Z, 2));
		}

		/// <summary>
		/// Returns distance between this and another position in 3D space.
		/// </summary>
		/// <param name="otherPos"></param>
		/// <returns></returns>
		public readonly double Get3DDistance(Position otherPos)
		{
			return Math.Sqrt(Math.Pow(X - otherPos.X, 2) + Math.Pow(Y - otherPos.Y, 2) + Math.Pow(Z - otherPos.Z, 2));
		}

		/// <summary>
		/// Returns true if other position is within given range in 2D space.
		/// </summary>
		/// <param name="otherPos"></param>
		/// <returns></returns>
		public readonly bool InRange2D(Position otherPos, float range)
		{
			return (Math.Pow(X - otherPos.X, 2) + Math.Pow(Z - otherPos.Z, 2) <= Math.Pow(range, 2));
		}

		/// <summary>
		/// Returns true if other position is within given range in 3D space.
		/// </summary>
		/// <param name="otherPos"></param>
		/// <returns></returns>
		public readonly bool InRange3D(Position otherPos, float range)
		{
			return (Math.Pow(X - otherPos.X, 2) + Math.Pow(Y - otherPos.Y, 2) + Math.Pow(Z - otherPos.Z, 2) <= Math.Pow(range, 2));
		}

		/// <summary>
		/// Returns true if the position is within in the 2D polygon
		/// defined by the given points.
		/// </summary>
		/// <param name="points"></param>
		/// <returns></returns>
		public readonly bool InPolygon2D(Position[] points)
		{
			var result = false;
			var x = this.X;
			var z = this.Z;

			for (int i = 0, j = points.Length - 1; i < points.Length; j = i++)
			{
				if (((points[i].Z > z) != (points[j].Z > z)) && (x < (points[j].X - points[i].X) * (z - points[i].Z) / (points[j].Z - points[i].Z) + points[i].X))
					result = !result;
			}

			return result;
		}

		/// <summary>
		/// Returns random position around this position,
		/// not nearer than min, and not further than max.
		/// </summary>
		/// <param name="distanceMax"></param>
		/// <param name="rnd"></param>
		/// <param name="distanceMin"></param>
		/// <returns></returns>
		public readonly Position GetRandomInRange2D(int distanceMin, int distanceMax, Random rnd)
		{
			return this.GetRandom(rnd.Next(distanceMin, distanceMax + 1), rnd);
		}

		/// <summary>
		/// Returns random position in radius around this position.
		/// </summary>
		/// <param name="radius"></param>
		/// <param name="rnd"></param>
		/// <returns></returns>
		public readonly Position GetRandomInRange2D(int radius, Random rnd)
		{
			return this.GetRandom(rnd.Next(radius + 1), rnd);
		}

		/// <summary>
		/// Returns random position in radius around this position.
		/// </summary>
		/// <param name="distance"></param>
		/// <param name="rnd"></param>
		/// <returns></returns>
		private readonly Position GetRandom(int distance, Random rnd)
		{
			var angle = rnd.NextDouble() * Math.PI * 2;
			var x = this.X + distance * Math.Cos(angle);
			var z = this.Z + distance * Math.Sin(angle);

			return new Position((int)x, this.Y, (int)z);
		}

		/// <summary>
		/// Returns position on the line between this position and the
		/// given one.
		/// </summary>
		/// <remarks>
		/// Example: When you knock someone back, they get pushed in the
		/// opposite direction. The other position would be the enemy,
		/// the distance the amount how far to push them away. A negative
		/// distance will return a position between you two.
		/// </remarks>
		/// <param name="other"></param>
		/// <param name="distance"></param>
		/// <returns></returns>
		[Obsolete("Use GetRelative3D instead.")]
		public readonly Position GetRelative(Position other, float distance)
			=> this.GetRelative3D(other, distance);

		/// <summary>
		/// Returns position in direction and distance.
		/// </summary>
		/// <param name="direction"></param>
		/// <param name="distance"></param>
		/// <returns></returns>
		[Obsolete("Use GetRelative2D instead.")]
		public readonly Position GetRelative(Direction direction, float distance)
			=> this.GetRelative2D(direction, distance);

		/// <summary>
		/// Returns position on the line between this position and the
		/// given one in 3D space.
		/// </summary>
		/// <remarks>
		/// All coordinates are used and the new position will be on the
		/// exact line between the two positions. Any potential elevation
		/// is not taken into account.
		/// </remarks>
		/// <example>
		/// When you knock someone back, they get pushed in the opposite
		/// direction. The other position would be the enemy, the distance
		/// the amount how far to push them away. A negative distance will
		/// return a position between you two.
		/// 
		/// Push the target away 100 units. For example, knock back.
		/// -> attacker.Position.GetRelative2D(target.Position, 100);
		/// 
		/// Get a position 50 units from the target. For example, getting
		/// into attack range.
		/// -> attacker.Position.GetRelative2D(target.Position, -50);
		/// 
		/// Get a position 50 units towards the target. For example,
		/// walking closer.
		/// -> target.Position.GetRelative2D(attacker.Position, -50);
		/// </example>
		/// <param name="other"></param>
		/// <param name="distance"></param>
		/// <returns></returns>
		public readonly Position GetRelative3D(Position other, float distance)
		{
			if (this == other)
				return this;

			var deltaX = (double)other.X - this.X;
			var deltaY = (double)other.Y - this.Y;
			var deltaZ = (double)other.Z - this.Z;

			var deltaXYZ = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2) + Math.Pow(deltaZ, 2));

			var newX = other.X + (distance / deltaXYZ) * (deltaX);
			var newY = other.Y + (distance / deltaXYZ) * (deltaY);
			var newZ = other.Z + (distance / deltaXYZ) * (deltaZ);

			return new Position((float)newX, (float)newY, (float)newZ);
		}

		/// <summary>
		/// Returns position in direction and distance in 2D space.
		/// </summary>
		/// <param name="direction"></param>
		/// <param name="distance"></param>
		/// <returns></returns>
		public readonly Position GetRelative2D(Direction direction, float distance)
		{
			var deltaX = direction.Cos;
			var deltaZ = direction.Sin;

			var deltaXZ = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaZ, 2));

			var newX = this.X + (distance / deltaXZ) * (deltaX);
			var newZ = this.Z + (distance / deltaXZ) * (deltaZ);

			return new Position((float)newX, this.Y, (float)newZ);
		}

		/// <summary>
		/// Returns position on the line between this position and the
		/// given one in 2D space.
		/// </summary>
		/// <remarks>
		/// Only the X and Z coordinates are used, with the Y coordinate
		/// retaining its original value.
		/// </remarks>
		/// <example>
		/// When you knock someone back, they get pushed in the opposite
		/// direction. The other position would be the enemy, the distance
		/// the amount how far to push them away. A negative distance will
		/// return a position between you two.
		/// 
		/// Push the target away 100 units. For example, knock back.
		/// -> attacker.Position.GetRelative2D(target.Position, 100);
		/// 
		/// Get a position 50 units from the target. For example, getting
		/// into attack range.
		/// -> attacker.Position.GetRelative2D(target.Position, -50);
		/// 
		/// Get a position 50 units towards the target. For example,
		/// walking closer.
		/// -> target.Position.GetRelative2D(attacker.Position, -50);
		/// </example>
		/// <param name="other"></param>
		/// <param name="distance"></param>
		/// <returns></returns>
		public readonly Position GetRelative2D(Position other, float distance)
		{
			if (this == other)
				return this;

			var deltaX = (double)other.X - this.X;
			var deltaZ = (double)other.Z - this.Z;

			var deltaXZ = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaZ, 2));

			var newX = this.X + (distance / deltaXZ) * (deltaX);
			var newZ = this.Z + (distance / deltaXZ) * (deltaZ);

			return new Position((float)newX, this.Y, (float)newZ);
		}

		/// <summary>
		/// Returns direction the other position is in as radian.
		/// </summary>
		/// <param name="otherPos"></param>
		/// <returns></returns>
		public readonly Direction GetDirection(Position otherPos)
		{
			var radianAngle = Math.Atan2(otherPos.Z - Z, otherPos.X - X);

			var cos = Math.Cos(radianAngle);
			var sin = Math.Sin(radianAngle);

			return new Direction((float)cos, (float)sin);
		}

		/// <summary>
		/// Implicitly converts the position to a vector.
		/// </summary>
		/// <param name="pos"></param>
		public static implicit operator Vector2(Position pos)
		{
			return new Vector2((int)pos.X, (int)pos.Z);
		}

		/// <summary>
		/// Implicitly converts the position to a vector.
		/// </summary>
		/// <param name="pos"></param>
		public static implicit operator Vector2F(Position pos)
		{
			return new Vector2F(pos.X, pos.Z);
		}

		/// <summary>
		/// Returns true if both positions represent the same position.
		/// </summary>
		/// <param name="pos1"></param>
		/// <param name="pos2"></param>
		/// <returns></returns>
		public static bool operator ==(Position pos1, Position pos2)
		{
			return (pos1.X == pos2.X && pos1.Y == pos2.Y && pos1.Z == pos2.Z);
		}

		/// <summary>
		/// Returns true if positions aren't representing the same position.
		/// </summary>
		/// <param name="pos1"></param>
		/// <param name="pos2"></param>
		/// <returns></returns>
		public static bool operator !=(Position pos1, Position pos2)
		{
			return !(pos1 == pos2);
		}

		/// <summary>
		/// Returns hash code for this position, calculated out of the coorindates.
		/// </summary>
		/// <returns></returns>
		public override readonly int GetHashCode()
		{
			return HashCode.Combine(X, Y, Z);
		}

		/// <summary>
		/// Returns true if the given object is the same instance.
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public override readonly bool Equals(object obj)
		{
			return obj is Position position && this == position;
		}

		/// <summary>
		/// Returns string representation of position.
		/// </summary>
		/// <returns></returns>
		public override readonly string ToString()
		{
			return string.Format(CultureInfo.InvariantCulture, "X: {0}, Y: {1}, Z: {2}", X, Y, Z);
		}
	}
}
