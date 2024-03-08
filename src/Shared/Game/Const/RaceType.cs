namespace Melia.Shared.Tos.Const
{
	public enum RaceType
	{
		/// <summary>
		/// No special race.
		/// </summary>
		None = 0,

		/// <summary>
		/// Insect
		/// </summary>
		Klaida = 1,

		/// <summary>
		/// Mutant
		/// </summary>
		Paramune = 2,

		/// <summary>
		/// Plant
		/// </summary>
		Forester = 3,

		/// <summary>
		/// Demon
		/// </summary>
		Velnias = 4,

		/// <summary>
		/// Beast
		/// </summary>
		Widling = 5,

		/// <summary>
		/// Item
		/// </summary>
		Item = 6, // value guessed

		// The client has some demons as "Velnais" instead of "Velnias".
		// For Melia we corrected these typos and hence disabled this
		// value.
		//Velnais,
	}
}
