namespace Melia.Shared.Game.Const
{
	/// <summary>
	/// Defines the relation type between actors.
	/// </summary>
	public enum RelationType : byte
	{
		/// <summary>
		/// Friendly actors, such as party members.
		/// </summary>
		Friend = 0,

		/// <summary>
		/// Enemy actors, such as mobs.
		/// </summary>
		Enemy = 1,

		/// <summary>
		/// Neutral actors, such as NPCs.
		/// </summary>
		Neutral = 2,
	}
}
