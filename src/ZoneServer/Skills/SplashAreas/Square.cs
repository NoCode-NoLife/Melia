using System;
using Melia.Shared.Data.Database;
using Melia.Shared.World;
using Yggdrasil.Geometry;
using Yggdrasil.Geometry.Shapes;

namespace Melia.Zone.Skills.SplashAreas
{
	/// <summary>
	/// A rectangular splash area.
	/// </summary>
	public class Square : IShapeF, ISplashArea
	{
		private readonly PolygonF _base;

		/// <summary>
		/// Returns the origin position, where one side of the square starts.
		/// </summary>
		public Position OriginPos { get; }

		/// <summary>
		/// Returns the position on the far side of the square, opposite
		/// the origin position.
		/// </summary>
		public Position FarSidePos { get; }

		/// <summary>
		/// Returns the height of the square, which is the distance between
		/// the origin and the far side.
		/// </summary>
		public float Height { get; }

		/// <summary>
		/// Returns the square's half-width, from its center to one of its
		/// sides.
		/// </summary>
		public float Width { get; }

		/// <summary>
		/// Returns the direction the far side position is in, relative
		/// to the origin.
		/// </summary>
		public Direction Direction { get; }

		/// <summary>
		/// Returns the center of the square.
		/// </summary>
		public Vector2F Center => _base.Center;

		/// <summary>
		/// Returns the splash area's type.
		/// </summary>
		SplashType ISplashArea.SplashType => SplashType.Square;

		/// <summary>
		/// Creates new square that starts at origin and extends in
		/// direction by the given height.
		/// </summary>
		/// <param name="originPos"></param>
		/// <param name="direction"></param>
		/// <param name="height"></param>
		/// <param name="width"></param>
		public Square(Position originPos, Direction direction, float height, float width)
		{
			this.OriginPos = originPos;
			this.Direction = direction;
			this.Height = height;
			this.Width = width;

			this.FarSidePos = originPos.GetRelative(direction, height);

			// Double the width, as the width defined by the game is
			// basically the "radius" of the square
			_base = PolygonF.RectangleBetween(originPos, this.FarSidePos, width * 2);
		}

		/// <summary>
		/// Returns a square centered around the given position.
		/// </summary>
		/// <param name="centerPos"></param>
		/// <param name="direction"></param>
		/// <param name="height"></param>
		/// <param name="width"></param>
		/// <returns></returns>
		public static Square Centered(Position centerPos, Direction direction, float height, float width)
		{
			var halfHeight = height / 2f;

			var originPos = centerPos.GetRelative(direction, -halfHeight);
			var farSidePos = centerPos.GetRelative(direction, halfHeight);

			return new Square(originPos, direction, height, width);
		}

		/// <summary>
		/// Returns the square's four corner points.
		/// </summary>
		/// <returns></returns>
		public Vector2F[] GetEdgePoints()
			=> _base.GetEdgePoints();

		/// <summary>
		/// Returns lines that make up the square's outline.
		/// </summary>
		/// <returns></returns>
		public OutlineF[] GetOutlines()
			=> _base.GetOutlines();

		/// <summary>
		/// Returns a random point inside the square.
		/// </summary>
		/// <param name="rnd"></param>
		/// <returns></returns>
		public Vector2F GetRandomPoint(Random rnd)
			=> _base.GetRandomPoint(rnd);

		/// <summary>
		/// Returns whether the given position is inside the square.
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		public bool IsInside(Vector2F pos)
			=> _base.IsInside(pos);
	}
}
