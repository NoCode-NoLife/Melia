using System.Text.RegularExpressions;

namespace Melia.Shared.Game.Const
{
	/// <summary>
	/// Used to specify the type of a monster.
	/// </summary>
	public enum RelationType : byte
	{
		/// <summary>
		/// Party/Guild
		/// </summary>
		Friendly = 0,

		/// <summary>
		/// An aggressive monster.
		/// </summary>
		Enemy = 1,

		/// <summary>
		/// An NPC or item.
		/// </summary>
		Neutral = 2,

		/// <summary>
		/// A party member
		/// </summary>
		Party = 3,

		/// <summary>
		/// A guild member
		/// </summary>
		Guild = 4,

		/// <summary>
		/// Is a player
		/// </summary>
		Character = 5,

		/// <summary>
		/// Is a monster
		/// </summary>
		Monster = 6,

		/// <summary>
		/// All relations
		/// </summary>
		All = 127,
	}
}
