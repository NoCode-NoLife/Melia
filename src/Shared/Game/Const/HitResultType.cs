namespace Melia.Shared.Game.Const
{
	public enum HitResultType : short
	{
		/// <summary>
		/// Displays no hit at all.
		/// </summary>
		None = 0,

		/// <summary>
		/// Displays "Dodge" text banner instead of any potential damage.
		Dodge = 1,

		/// <summary>
		/// Displays damage in blue.
		/// </summary>
		Block = 2,

		/// <summary>
		/// Normal hit.
		/// </summary>
		Hit = 3,

		/// <summary>
		/// A critical hit, indicated by a yellow damage text that's
		/// accompanied by a high-pitched sound.
		/// </summary>
		Crit = 4,

		/// <summary>
		/// Displays damage and "Dodge" text banner.
		/// </summary>
		DodgeDamage = 5,

		/// <summary>
		/// Displays "Miss" text banner.
		/// </summary>
		Miss = 6,

		/// <summary>
		/// Hit with damage and a metallic sound.
		/// </summary>
		Unk7 = 7,

		/// <summary>
		/// Normal hit, but without hit sound.
		/// </summary>
		Unk8 = 8,

		/// <summary>
		/// Same as Unk4? Seen with Magic Missile.
		/// </summary>
		MagicMissile = 9,
	}
}
