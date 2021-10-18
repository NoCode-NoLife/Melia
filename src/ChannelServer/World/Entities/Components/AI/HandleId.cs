namespace Melia.Channel.World.Entities.Components.AI
{
	/// <summary>
	/// Handles ids used by the AI scripts, to inform the core which
	/// entity to address without needing the actual handle in the
	/// script.
	/// </summary>
	public static class HandleId
	{
		/// <summary>
		/// Use handle of the AI's entity.
		/// </summary>
		public const int Me = -1;

		/// <summary>
		/// Use handle of the entity's master.
		/// </summary>
		public const int Master = -2;

		/// <summary>
		/// Use handle of the current target.
		/// </summary>
		public const int Target = -3;
	}
}
