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

		/// <summary>
		/// Creates a new, blank friend.
		/// </summary>
		public Friend()
		{
		}

		/// <summary>
		/// Creates a new friend from the given information.
		/// </summary>
		/// <param name="friendAccount"></param>
		/// <param name="state"></param>
		public Friend(Account friendAccount, FriendState state)
		{
			this.AccountId = friendAccount.Id;
			this.TeamName = friendAccount.TeamName;
			this.State = state;
		}
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
