namespace Melia.Shared.Game.Const
{
	/// <summary>
	/// Size type of an actor.
	/// </summary>
	/// <remarks>
	/// Derived from shape.ies.
	/// </remarks>
	public enum SizeType
	{
		None,

		/// <summary>
		/// Hidden actor? Difference to Hidden unknown.
		/// </summary>
		Hide,

		/// <summary>
		/// Hidden actor? Difference to Hide unknown.
		/// </summary>
		Hidden,

		/// <summary>
		/// Very small actor?
		/// </summary>
		VS,

		/// <summary>
		/// Super small actor?
		/// </summary>
		SS,

		/// <summary>
		/// Small actor.
		/// </summary>
		S,

		/// <summary>
		/// Medium. The default that also applies to characters by default.
		/// </summary>
		M,

		/// <summary>
		/// Large actor.
		/// </summary>
		L,

		/// <summary>
		/// Extra large actor.
		/// </summary>
		XL,

		/// <summary>
		/// Extra, extra large actor.
		/// </summary>
		XXL,

		/// <summary>
		/// Extra, extra, extra large actor.
		/// </summary>
		XXXL,

		/// <summary>
		/// ?
		/// </summary>
		OBS,

		/// <summary>
		/// ?
		/// </summary>
		Item,

		/// <summary>
		/// Small items?
		/// </summary>
		ItemS,

		/// <summary>
		/// Medium-sized items?
		/// </summary>
		ItemM,

		/// <summary>
		/// ?
		/// </summary>
		Icewall,

		/// <summary>
		/// ?
		/// </summary>
		XL_Hit,

		/// <summary>
		/// ?
		/// </summary>
		XL_LHit,

		/// <summary>
		/// Player character sized. For most purposes, this is the same as Medium.
		/// </summary>
		PC,

		/// <summary>
		/// ?
		/// </summary>
		/// <remarks>
		/// First seen in i402363.
		/// </remarks>
		EX,
	}
}
