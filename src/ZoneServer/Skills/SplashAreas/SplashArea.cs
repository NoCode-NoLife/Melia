using Melia.Shared.Data.Database;
using Melia.Shared.World;
using Yggdrasil.Geometry;

namespace Melia.Zone.Skills.SplashAreas
{
	/// <summary>
	/// Represents the area of effect for a skill.
	/// </summary>
	public interface ISplashArea : IShapeF
	{
		/// <summary>
		/// Returns the splash area's type, defining its shape.
		/// </summary>
		SplashType SplashType { get; }

		/// <summary>
		/// Returns the origin position, which varies depending on the
		/// shape.
		/// </summary>
		Position OriginPos { get; }

		/// <summary>
		/// Returns the direction the area is extending	in.
		/// </summary>
		Direction Direction { get; }

		/// <summary>
		/// Returns the area's height.
		/// </summary>
		float Height { get; }

		/// <summary>
		/// Returns the area's width.
		/// </summary>
		float Width { get; }
	}
}
