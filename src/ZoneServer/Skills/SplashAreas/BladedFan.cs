using System;
using System.Linq;
using Melia.Shared.Data.Database;
using Melia.Shared.World;
using Yggdrasil.Extensions;
using Yggdrasil.Geometry;
using Yggdrasil.Geometry.Shapes;

namespace Melia.Zone.Skills.SplashAreas
{
	/// <summary>
	/// A splash area that consists of a number of blades arrangedevenly
	/// around a center position.
	/// </summary>
	public class BladedFan : ISplashArea, IRotatableF
	{
		private readonly PolygonF[] _blades;
		private Vector2F[] _edgePoints;
		private OutlineF[] _outlines;

		/// <summary>
		/// Returns the splash area's type.
		/// </summary>
		SplashType ISplashArea.SplashType => SplashType.Circle;

		/// <summary>
		/// Returns the center of the fan.
		/// </summary>
		Vector2F IShapeF.Center => this.Position;

		/// <summary>
		/// Returns the origin position, which is equivalent to the center
		/// of the fan.
		/// </summary>
		Position ISplashArea.OriginPos => this.Position;

		/// <summary>
		/// Returns zero, as circles don't have a direction.
		/// </summary>
		Direction ISplashArea.Direction => Direction.Zero;

		/// <summary>
		/// Returns the radius of the area the fan covers.
		/// </summary>
		public float Height { get; }

		/// <summary>
		/// Returns the radius of the area the fan covers.
		/// </summary>
		public float Width { get; }

		/// <summary>
		/// Returns the center of the fan where all blades meet.
		/// </summary>
		public Position Position { get; private set; }

		/// <summary>
		/// Creates a new bladed fan based on the given parameters.
		/// </summary>
		/// <param name="centerPos"></param>
		/// <param name="bladeCount"></param>
		/// <param name="bladeLength"></param>
		/// <param name="bladeWidth"></param>
		/// <exception cref="ArgumentException"></exception>
		public BladedFan(Position centerPos, int bladeCount, float bladeLength, float bladeWidth)
		{
			if (bladeCount < 1)
				throw new ArgumentException($"Blade count must be at least 1.");

			_blades = new PolygonF[bladeCount];

			var blade1Center = centerPos.GetRelative(Direction.North, bladeLength / 2);

			var size = new Vector2F(bladeWidth, bladeLength);

			for (var i = 0; i < bladeCount; ++i)
			{
				var blade = PolygonF.Rectangle(blade1Center, size, 0);
				blade.RotateAround(centerPos, 360f / bladeCount * i);

				_blades[i] = blade;
			}

			this.Position = centerPos;
			this.Height = bladeLength;
			this.Width = bladeLength;
		}

		/// <summary>
		/// Returns the edge points of the shapes the fan is composed of.
		/// </summary>
		/// <returns></returns>
		public Vector2F[] GetEdgePoints()
		{
			if (_edgePoints == null)
				_edgePoints = _blades.SelectMany(s => s.GetEdgePoints()).ToArray();

			return _edgePoints;
		}

		/// <summary>
		/// Returns the outlines of the shapes the fan is composed of.
		/// </summary>
		/// <returns></returns>
		public OutlineF[] GetOutlines()
		{
			if (_outlines == null)
				_outlines = _blades.SelectMany(s => s.GetOutlines()).ToArray();

			return _outlines;
		}

		/// <summary>
		/// Returns a random point inside the fan.
		/// </summary>
		/// <param name="rnd"></param>
		/// <returns></returns>
		public Vector2F GetRandomPoint(Random rnd)
		{
			var rndShape = _blades.Random();
			return rndShape.GetRandomPoint(rnd);
		}

		/// <summary>
		/// Returns true if the given position is inside any of the
		/// shapes the fan is composed of.
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		public bool IsInside(Vector2F pos)
			=> _blades.Any(s => s.IsInside(pos));

		/// <summary>
		/// Rotates the fan around its center point.
		/// </summary>
		/// <param name="degreeAngle"></param>
		public void Rotate(float degreeAngle)
			=> this.RotateAround(this.Position, degreeAngle);

		/// <summary>
		/// Rotates the fan around the given pivot point.
		/// </summary>
		/// <param name="pivot"></param>
		/// <param name="degreeAngle"></param>
		public void RotateAround(Vector2F pivot, float degreeAngle)
		{
			foreach (var shape in _blades)
				shape.RotateAround(pivot, degreeAngle);

			var pos = this.Position;
			var newCenterPoint = PointUtil.Rotate(pos, pivot, degreeAngle);
			var newPos = new Position(newCenterPoint.X, pos.Y, newCenterPoint.Y);

			this.Position = pos;

			_edgePoints = null;
			_outlines = null;
		}
	}
}
