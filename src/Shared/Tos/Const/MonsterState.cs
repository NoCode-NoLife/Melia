namespace Melia.Shared.Tos.Const
{
	/// <summary>
	/// Defines a monster's state.
	/// </summary>
	public enum MonsterState
	{
		/// <summary>
		/// Presumed default state.
		/// </summary>
		Normal = 0,

		/// <summary>
		/// Unknown state used for certain monsters.
		/// </summary>
		Unknown1 = 1,

		/// <summary>
		/// Used for opened chests, when they disappear.
		/// </summary>
		Invisible = -1,
	}
}
