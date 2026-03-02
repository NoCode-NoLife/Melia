namespace Melia.Shared.Game.Const
{
	/// <summary>
	/// A skill's hit type, which determines certain skill hit values.
	/// </summary>
	/// <remarks>
	/// Based on the property CT_HitType. It's currently unknown whether
	/// this enum is used in packets.
	/// </remarks>
	public enum SkillHitType
	{
		Melee,
		Force,
		Magic,
		Pad,
		Installation,
		Companion,
		Companion_Flying,
		Fire,
	}

	/// <summary>
	/// A skill's knock back type, which determines how the target is
	/// knocked back by the skill.
	/// </summary>
	/// <remarks>
	/// Based on the numeric property CT_KnockDownHitType. The names are
	/// largely guessed based on how the values are used.
	/// </remarks>
	public enum KnockBackType : short
	{
		None = 0,
		Motion = 1,
		NoMotion = 2,
		KnockBack = 3,
		KnockDown = 4,
		Type18 = 18,
	}
}
