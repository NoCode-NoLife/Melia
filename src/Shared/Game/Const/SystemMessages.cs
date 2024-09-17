namespace Melia.Shared.Game.Const
{
	/// <summary>
	/// Used to specify how a system message is displayed.
	/// </summary>
	public enum SystemMessageDisplayType : byte
	{
		/// <summary>
		/// Message is displayed in chat and as a red notice.
		/// </summary>
		ChatAndNotice = 0,

		/// <summary>
		/// Message is displayed in chat only.
		/// </summary>
		ChatOnly = 1,
	}
}
