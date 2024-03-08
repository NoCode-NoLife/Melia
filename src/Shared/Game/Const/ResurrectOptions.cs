using System;

namespace Melia.Shared.Tos.Const
{
	/// <summary>
	/// A bitmask used to specify the options for resurrecting a character.
	/// </summary>
	[Flags]
	public enum ResurrectOptions : int
	{
		None = 0x00,
		Empty = 0x01,
		NearestRevivalPoint = 0x02,
		SoulCrystal = 0x04,
		ReturnToField = 0x08,
		AbandonQuestTryAgain = 0x10,
		TryAgain = 0x20,
	}
}
