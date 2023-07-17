namespace Melia.Shared.Tos.Const
{
	/// <summary>
	/// Defines the style of a notice text.
	/// </summary>
	public enum NoticeTextType : byte
	{
		/// <summary>
		/// Displays text in gold at the top and as a red system message.
		/// </summary>
		GoldRed = 0,

		/// <summary>
		/// Displays text in gold at the top.
		/// </summary>
		Gold = 1,

		/// <summary>
		/// Displays text in red at the top and as a yellow system message.
		/// </summary>
		RedYellow = 2,

		/// <summary>
		/// Displays text in gold at the top with the format "World User
		/// Count: Text". Because that required an entirely separate
		/// type. Yes, it was not possible to prefix type 1 with that
		/// text. No way.
		/// </summary>
		WorldUserCount = 5,
	}
}
