namespace Melia.Shared.Game.Const
{
	/// <summary>
	/// Specifies a monster's behavioral tendency.
	/// </summary>
	public enum TendencyType
	{
		/// <summary>
		/// The entity doesn't typically initiate combat unless provoked.
		/// </summary>
		Peaceful,

		/// <summary>
		/// The entity is aggressive and will attack perceived threats.
		/// </summary>
		Aggressive,
	}
}
