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
		/// <remarks>
		/// This constructor and <see cref="Square.Centered"/> create a
		/// square that extends from a certain position, with the width
		/// acting like a radius, extending side by side, while the height
		/// is the actual height of the square.
		///
		/// For example, using the character as the origin, with their
		/// view direction, a width of 50, and a height of 100, the
		/// resulting rectangle would extend 50 units to either side of
		/// the character, for a total of 100, and the other end of the
		/// rectangle would be found 100 units in the direction they're
		/// facing, creating a 100x100 square directly in front of the
		/// character.
		///
		/// This is the way the square splash area typically works in this
		/// game and allows to directly use known parameters for this
		/// class.
		///
		/// For a more traditional interpretation of a square around an
		/// origin, use <see cref="Square.Simple"/>.
		/// </remarks>
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

			this.FarSidePos = originPos.GetRelative2D(direction, height);

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

			var originPos = centerPos.GetRelative2D(direction, -halfHeight);
			var farSidePos = centerPos.GetRelative2D(direction, halfHeight);

			return new Square(originPos, direction, height, width);
		}

		/// <summary>
		/// Returns a square centered around the given position and
		/// extending by the actual amounts of height and width, unlike
		/// <see cref="Square.Centered"/>.
		/// </summary>
		/// <param name="centerPos"></param>
		/// <param name="direction"></param>
		/// <param name="height"></param>
		/// <param name="width"></param>
		/// <returns></returns>
		public static Square Simple(Position centerPos, Direction direction, float height, float width)
		{
			var halfHeight = height / 2f;
			var halfWidth = width / 2f;

			var originPos = centerPos.GetRelative2D(direction, -halfHeight);
			var farSidePos = centerPos.GetRelative2D(direction, halfHeight);

			return new Square(originPos, direction, height, halfWidth);
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
		/// Returns the axis-aligned bounding box that contains the shape.
		/// </summary>
		/// <returns></returns>
		public BoundingBoxF GetBounds()
			=> _base.GetBounds();

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

		/// <summary>
		/// Moves area to the given position and recalculates its properties.
		/// </summary>
		/// <param name="position"></param>
		public void UpdatePosition(Vector2F position)
			=> _base.UpdatePosition(position);
	}
}
