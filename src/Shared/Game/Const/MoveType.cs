namespace Melia.Shared.Game.Const
{
	public enum MoveType
	{
		Normal,

		// Note sure if there's a difference between these. Pets use "Fly"
		// and monsters use "Flying". We'll keep both for now.
		Flying,
		Fly,

		Holding,
		Link,
	}

	/// <summary>
	/// A value found in cell movement packets, which appears to have an
	/// effect on the movement.
	/// </summary>
	public enum CellMoveType : byte
	{
		/// <summary>
		/// Normal movement?
		/// </summary>
		Normal = 0,

		/// <summary>
		/// Normal movement, but actor doesn't turn in movement direction.
		/// </summary>
		NoTurning = 2,
	}
}
