using System;
using Melia.Shared.Data.Database;
using Melia.Shared.World;
using Yggdrasil.Geometry;
using Yggdrasil.Geometry.Shapes;

namespace Melia.Zone.Skills.SplashAreas
{
	/// <summary>
	/// A fan-shaped splash area.
	/// </summary>
	public class Fan : IShapeF, ISplashArea
	{
		private readonly ConeF _base;

		/// <summary>
		/// Returns the fan's origin position, which is its tip.
		/// </summary>
		public Position OriginPos { get; }

		/// <summary>
		/// Returns the direction the fan is opening up in.
		/// </summary>
		public Direction Direction { get; }

		/// <summary>
		/// Returns the height of the fan, which is the distance between
		/// the origin and the rounded point that is farthest away from it.
		/// </summary>
		public float Height { get; }

		/// <summary>
		/// Returns the angle of the fan's sides. For example, the sides of
		/// a 90° fan will run in 45° angles from the origin.
		/// </summary>
		public float Angle { get; }

		/// <summary>
		/// Returns the center of the fan.
		/// </summary>
		public Vector2F Center => _base.Center;

		/// <summary>
		/// Returns the splash area's type.
		/// </summary>
		SplashType ISplashArea.SplashType => SplashType.Fan;

		/// <summary>
		/// Returns the fan's height.
		/// </summary>
		float ISplashArea.Height => this.Height;

		/// <summary>
		/// Returns the fan's angle.
		/// </summary>
		float ISplashArea.Width => this.Angle;

		/// <summary>
		/// Creates new fan.
		/// </summary>
		/// <param name="originPos"></param>
		/// <param name="direction"></param>
		/// <param name="height"></param>
		/// <param name="angle"></param>
		public Fan(Position originPos, Direction direction, float height, float angle)
		{
			this.OriginPos = originPos;
			this.Direction = direction;
			this.Height = height;
			this.Angle = angle;

			_base = new ConeF(originPos, direction.NormalDegreeAngle, height, angle);
		}

		/// <summary>
		/// Returns edge points that approximate the fan's shape.
		/// </summary>
		/// <returns></returns>
		public Vector2F[] GetEdgePoints()
			=> _base.GetEdgePoints();

		/// <summary>
		/// Returns an outlines that runs along the fan's approximated
		/// edge points.
		/// </summary>
		/// <returns></returns>
		public OutlineF[] GetOutlines()
			=> _base.GetOutlines();

		/// <summary>
		/// Returns a random point inside the fan.
		/// </summary>
		/// <param name="rnd"></param>
		/// <returns></returns>
		public Vector2F GetRandomPoint(Random rnd)
			=> _base.GetRandomPoint(rnd);

		/// <summary>
		/// Returns whether the given position is inside the fan.
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
