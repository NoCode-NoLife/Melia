// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Globalization;

namespace Melia.Shared.World
{
	public struct Position
	{
		/// <summary>
		/// X coordinate (left/right).
		/// </summary>
		public readonly float X;

		/// <summary>
		/// Y coordinate (up/down).
		/// </summary>
		public readonly float Y;

		/// <summary>
		/// Z coordinate (depth).
		/// </summary>
		public readonly float Z;

		/// <summary>
		/// Returns new position with X, Y, and Z being 0.
		/// </summary>
		public static Position Zero { get { return new Position(0, 0, 0); } }

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
		public double Get2DDistance(Position otherPos)
		{
			return Math.Sqrt(Math.Pow(X - otherPos.X, 2) + Math.Pow(Z - otherPos.Z, 2));
		}

		/// <summary>
		/// Returns distance between this and another position in 3D space.
		/// </summary>
		/// <param name="otherPos"></param>
		/// <returns></returns>
		public double Get3DDistance(Position otherPos)
		{
			return Math.Sqrt(Math.Pow(X - otherPos.X, 2) + Math.Pow(Y - otherPos.Y, 2) + Math.Pow(Z - otherPos.Z, 2));
		}

		/// <summary>
		/// Returns true if other position is within given range in 2D space.
		/// </summary>
		/// <param name="otherPos"></param>
		/// <returns></returns>
		public bool InRange2D(Position otherPos, int range)
		{
			return (Math.Pow(X - otherPos.X, 2) + Math.Pow(Z - otherPos.Z, 2) <= Math.Pow(range, 2));
		}

		/// <summary>
		/// Returns true if other position is within given range in 3D space.
		/// </summary>
		/// <param name="otherPos"></param>
		/// <returns></returns>
		public bool InRange3D(Position otherPos, int range)
		{
			return (Math.Pow(X - otherPos.X, 2) + Math.Pow(Y - otherPos.Y, 2) + Math.Pow(Z - otherPos.Z, 2) <= Math.Pow(range, 2));
		}

		/// <summary>
		/// Returns random position around this position,
		/// not nearer than min, and not further than max.
		/// </summary>
		/// <param name="distanceMax"></param>
		/// <param name="rnd"></param>
		/// <param name="distanceMin"></param>
		/// <returns></returns>
		public Position GetRandomInRange2D(int distanceMin, int distanceMax, Random rnd)
		{
			return this.GetRandom(rnd.Next(distanceMin, distanceMax + 1), rnd);
		}

		/// <summary>
		/// Returns random position in radius around this position.
		/// </summary>
		/// <param name="radius"></param>
		/// <param name="rnd"></param>
		/// <returns></returns>
		public Position GetRandomInRange2D(int radius, Random rnd)
		{
			return this.GetRandom(rnd.Next(radius + 1), rnd);
		}

		/// <summary>
		/// Returns random position in radius around this position.
		/// </summary>
		/// <param name="distance"></param>
		/// <param name="rnd"></param>
		/// <returns></returns>
		private Position GetRandom(int distance, Random rnd)
		{
			var angle = rnd.NextDouble() * Math.PI * 2;
			var x = this.X + distance * Math.Cos(angle);
			var z = this.Z + distance * Math.Sin(angle);

			return new Position((int)x, this.Y, (int)z);
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
		public override int GetHashCode()
		{
			return this.X.GetHashCode() ^ this.Y.GetHashCode() ^ this.Z.GetHashCode();
		}

		/// <summary>
		/// Returns true if the given object is the same instance.
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public override bool Equals(object obj)
		{
			return obj is Position && this == (Position)obj;
		}

		/// <summary>
		/// Returns string representation of position.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return string.Format(CultureInfo.InvariantCulture, "X: {0}, Y: {1}, Z: {2}", X, Y, Z);
		}
	}
}
