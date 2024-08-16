namespace Melia.Shared.Game.Const
{
	public enum PremiumType : byte
	{
		/// <summary>
		/// No premium?
		/// </summary>
		Normal = 0,

		/// <summary>
		/// Unknown type that was possibly used by Nexon or in internet cafes.
		/// </summary>
		PC = 1,

		/// <summary>
		/// Premium state gained from a token item.
		/// </summary>
		Token = 2,
	}
}
