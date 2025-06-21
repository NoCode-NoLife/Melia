using Melia.Shared.World;

namespace Melia.Zone.Skills
{
	/// <summary>
	/// Holds parameters for splash areas.
	/// </summary>
	public struct SplashParameters
	{
		/// <summary>
		/// The length of the splash area. Typically synonymous with
		/// the distance between the caster and the farthest point
		/// of the splash area.
		/// </summary>
		public float Length;

		/// <summary>
		/// The width of a rectangular splash area or the radius of
		/// a circular one.
		/// </summary>
		public float Width;

		/// <summary>
		/// The angle of a fan-shaped splash area.
		/// </summary>
		public float Angle;

		/// <summary>
		/// The direction in which the splash area is facing from
		/// the caster.
		/// </summary>
		public Direction Direction;

		/// <summary>
		/// The position of the caster.
		/// </summary>
		public Position OriginPos;

		/// <summary>
		/// The farthest position of the splash area.
		/// </summary>
		public Position FarPos;
	}
}
