using System;
using Melia.Shared.Data.Database;
using Melia.Shared.World;
using Yggdrasil.Geometry;
using Yggdrasil.Geometry.Shapes;

namespace Melia.Zone.Skills.SplashAreas
{
	/// <summary>
	/// A circular, donut-shaped splash area.
	/// </summary>
	public class Donut : IShapeF, ISplashArea
	{
		private readonly CircleF _baseOuter, _baseInner;

		/// <summary>
		/// Returns the center of the donut.
		/// </summary>
		public Position Center { get; }

		/// <summary>
		/// Returns the donut's outer radius.
		/// </summary>
		public float RadiusOuter { get; }

		/// <summary>
		/// Returns the donut's inner radius, definint the area of the
		/// circle that is not part of the donut.
		/// </summary>
		public float RadiusInner { get; }

		/// <summary>
		/// Returns the center of the donut.
		/// </summary>
		Vector2F IShapeF.Center => this.Center;

		/// <summary>
		/// Returns the splash area's type.
		/// </summary>
		SplashType ISplashArea.SplashType => SplashType.Circle;

		/// <summary>
		/// Returns the origin position, where the donut starts.
		/// </summary>
		Position ISplashArea.OriginPos => this.Center;

		/// <summary>
		/// Returns zero, as donuts don't have a direction.
		/// </summary>
		Direction ISplashArea.Direction => Direction.Zero;

		/// <summary>
		/// Returns the donut's radius.
		/// </summary>
		float ISplashArea.Height => this.RadiusOuter;

		/// <summary>
		/// Returns zero, as circles don't have a width.
		/// </summary>
		float ISplashArea.Width => 0;

		/// <summary>
		/// Creates new circle.
		/// </summary>
		/// <param name="originPos"></param>
		/// <param name="radiusOuter"></param>
		/// <param name="radiusInner"></param>
		public Donut(Position originPos, float radiusOuter, float radiusInner)
		{
			this.Center = originPos;
			this.RadiusOuter = radiusOuter;
			this.RadiusInner = radiusInner;

			_baseOuter = new CircleF(originPos, radiusOuter);
			_baseInner = new CircleF(originPos, radiusInner);
		}

		/// <summary>
		/// Returns edge points that approximate the donut's outer shape.
		/// </summary>
		/// <returns></returns>
		public Vector2F[] GetEdgePoints()
			=> [.. _baseOuter.GetEdgePoints(), .. _baseInner.GetEdgePoints()];

		/// <summary>
		/// Returns an outline based on the donut's approximated outer
		/// edge points.
		/// </summary>
		/// <returns></returns>
		public OutlineF[] GetOutlines()
			=> _baseOuter.GetOutlines();

		/// <summary>
		/// Returns a random point inside the circle.
		/// </summary>
		/// <param name="rnd"></param>
		/// <returns></returns>
		public Vector2F GetRandomPoint(Random rnd)
		{
			// Normal circle random point generation, but with the inner
			// radius as the minimum to get only points in the outer ring.
			var angle = rnd.NextDouble() * Math.PI * 2;
			var radiusDelta = this.RadiusOuter - this.RadiusInner;
			var radius = this.RadiusInner + Math.Sqrt(rnd.NextDouble()) * radiusDelta;
			var x = (float)(Math.Cos(angle) * radius);
			var y = (float)(Math.Sin(angle) * radius);

			return new Vector2F(this.Center.X + x, this.Center.Y + y);
		}

		/// <summary>
		/// Returns whether the given position is inside the circle.
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		public bool IsInside(Vector2F pos)
			=> _baseOuter.IsInside(pos) && !_baseInner.IsInside(pos);
	}
}
