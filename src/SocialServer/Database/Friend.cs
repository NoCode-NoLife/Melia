namespace Melia.Social.Database
{
	/// <summary>
	/// Represent's a friend
	/// </summary>
	public class Friend : Character
	{
		/// <summary>
		/// Associated Online Character Id
		/// </summary>
		public long CharacterId { get; set; }

		/// <summary>
		/// Get or set the friend's state.
		/// </summary>
		public FriendState State { get; set; }

		/// <summary>
		/// Get or set the friend's group name.
		/// </summary>
		public string Group { get; set; }

		/// <summary>
		/// Get or set the friend's note.
		/// </summary>
		public string Note { get; set; }
	}

	/// <summary>
	/// Specifies the state of a friend.
	/// </summary>
	public enum FriendState : byte
	{
		/// <summary>
		/// A friend request was sent.
		/// </summary>
		Requested,

		/// <summary>
		/// The friend request was accepted.
		/// </summary>
		Accepted,

		/// <summary>
		/// The friend was deleted.
		/// </summary>
		Delete,

		/// <summary>
		/// The friend request was rejected.
		/// </summary>
		Rejected,

		/// <summary>
		/// The user was blocked.
		/// </summary>
		Blocked,
	}
}
