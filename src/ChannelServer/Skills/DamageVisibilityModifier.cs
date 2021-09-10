namespace Melia.Channel.Skills
{
	/// <summary>
	/// Defines how to broadcast an entity taking damage.
	/// </summary>
	public enum DamageVisibilityModifier
	{
		/// <summary>
		/// Sends no damage information to clients.
		/// </summary>
		Invisible,

		/// <summary>
		/// Sends ZC_HIT_INFO to broadcast damage.
		/// </summary>
		Hit,

		/// <summary>
		/// Sends ZC_SKILL_HIT_INFO to broadcast damage.
		/// </summary>
		Skill,
	}
}
