namespace Melia.Shared.Const
{
	/// <summary>
	/// Ids for playable animations.
	/// </summary>
	public static class AnimationId
	{
		// Uses xml/packeteffect.xml for the ids, which we'll probably want
		// to database-ify, because that file works like an enum, that could
		// change at any time >_>

		/// <summary>
		/// Player kicks something. Used for opening chests.
		/// </summary>
		public const int Kick = 256_2117;

		/// <summary>
		/// Chest opens its lid.
		/// </summary>
		public const int ChestOpening = 256_2118;
	}
}
