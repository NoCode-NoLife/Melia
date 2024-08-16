namespace Melia.Shared.Game.Const
{
	/// <summary>
	/// Used to specify the type of a monster.
	/// </summary>
	public enum MonsterType : byte
	{
		/// <summary>
		/// ?
		/// </summary>
		Friendly = 0,

		/// <summary>
		/// An aggressive monster.
		/// </summary>
		Mob = 1,

		/// <summary>
		/// An NPC or item.
		/// </summary>
		NPC = 2,
	}
}
