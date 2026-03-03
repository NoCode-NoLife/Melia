namespace Melia.Zone.World.Gacha
{
	/// <summary>
	/// Defines the rarity of a gacha entry, affecting the look of the
	/// pull animation and UI.
	/// </summary>
	public enum GachaRarity
	{
		/// <summary>
		/// Grade C. No special styling, brown background.
		/// </summary>
		Common = 0,

		/// <summary>
		/// Grade B. Blue shine and background.
		/// </summary>
		Rare = 2,

		/// <summary>
		/// Grade A. Golden shine and background.
		/// </summary>
		SuperRare = 1,
	}
}
