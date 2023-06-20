namespace Melia.Shared.Tos.Const
{
	public enum RaceType
	{
		/// <summary>
		/// No special race.
		/// </summary>
		None,

		/// <summary>
		/// Mutant
		/// </summary>
		Paramune,

		/// <summary>
		/// Beast
		/// </summary>
		Widling,

		/// <summary>
		/// Demon
		/// </summary>
		Velnias,

		/// <summary>
		/// Item
		/// </summary>
		Item,

		/// <summary>
		/// Plant
		/// </summary>
		Forester,

		/// <summary>
		/// Insect
		/// </summary>
		Klaida,

		// The client has some demons as "Velnais" instead of "Velnias".
		// For Melia we corrected these typos and hence disabled this
		// value.
		//Velnais,
	}
}
