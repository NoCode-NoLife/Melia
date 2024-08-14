using System;
using Melia.Shared.Data.Database;
using Melia.Shared.World;
using Yggdrasil.Geometry;
using Yggdrasil.Geometry.Shapes;

namespace Melia.Zone.Skills.SplashAreas
{
	/// <summary>
	/// A circular splash area.
	/// </summary>
	public class Circle : IShapeF, ISplashArea
	{
		private readonly CircleF _base;

		/// <summary>
		/// Returns the center of the circle.
		/// </summary>
		public Position Center { get; }

		/// <summary>
		/// Returns the circle's radius.
		/// </summary>
		public float Radius { get; }

		/// <summary>
		/// Returns the center of the circle.
		/// </summary>
		Vector2F IShapeF.Center => this.Center;

		/// <summary>
		/// Returns the splash area's type.
		/// </summary>
		SplashType ISplashArea.SplashType => SplashType.Circle;

		/// <summary>
		/// Returns the origin position, where the circle starts.
		/// </summary>
		Position ISplashArea.OriginPos => this.Center;

		/// <summary>
		/// Returns zero, as circles don't have a direction.
		/// </summary>
		Direction ISplashArea.Direction => Direction.Zero;

		/// <summary>
		/// Returns the circle's radius.
		/// </summary>
		float ISplashArea.Height => this.Radius;

		/// <summary>
		/// Returns zero, as circles don't have a width.
		/// </summary>
		float ISplashArea.Width => 0;

		/// <summary>
		/// Creates new circle.
		/// </summary>
		/// <param name="originPos"></param>
		/// <param name="radius"></param>
		public Circle(Position originPos, float radius)
		{
			this.Center = originPos;
			this.Radius = radius;

			_base = new CircleF(originPos, radius);
		}

		/// <summary>
		/// Returns edge points that approximate the circle's shape.
		/// </summary>
		/// <returns></returns>
		public Vector2F[] GetEdgePoints()
			=> _base.GetEdgePoints();

		/// <summary>
		/// Returns an outline based on the circle's approximated edge
		/// points.
		/// </summary>
		/// <returns></returns>
		public OutlineF[] GetOutlines()
			=> _base.GetOutlines();

		/// <summary>
		/// Returns a random point inside the circle.
		/// </summary>
		/// <param name="rnd"></param>
		/// <returns></returns>
		public Vector2F GetRandomPoint(Random rnd)
			=> _base.GetRandomPoint(rnd);

		/// <summary>
		/// Returns whether the given position is inside the circle.
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
