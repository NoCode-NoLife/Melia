namespace Melia.Shared.Game.Const
{
	public enum TeamNameChangeResult : int
	{
		TeamNameAlreadyExist = -1,
		Okay = 0,
		TeamChangeFailed = 1,
	}

	/// <summary>
	/// Represents the state of a mailbox message.
	/// </summary>
	/// <remarks>
	/// These Mailbox states were previously defined,
	/// I've only seen 0 - 3 (Akinue)
	/// </remarks>
	public enum MailboxMessageState : byte
	{
		/// <summary>
		/// The message has not been read yet.
		/// </summary>
		Unread = 0,

		/// <summary>
		/// The message has been read.
		/// </summary>
		Read = 1,

		/// <summary>
		/// The message is stored.
		/// </summary>
		Store = 2,

		/// <summary>
		/// The message is marked for deletion or has been deleted.
		/// </summary>
		Delete = 3,

		/// <summary>
		/// Unknown purpose
		/// </summary>
		RequestLoad = 4,

		/// <summary>
		/// Unknown purpose
		/// </summary>
		Count = 5,
	}
}
