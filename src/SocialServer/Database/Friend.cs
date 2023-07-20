using System;

namespace Melia.Social.Database
{
	/// <summary>
	/// Represents a user's friend.
	/// </summary>
	public class Friend
	{
		/// <summary>
		/// Gets or sets the friend's globally unique id.
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Gets or sets the users's account id.
		/// </summary>
		public long AccountId { get; set; }

		/// <summary>
		/// Gets or sets the user's team name.
		/// </summary>
		public string TeamName { get; set; }

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
		/// Gets or sets the users's last login date.
		/// </summary>
		public DateTime LastLogin { get; set; }

		/// <summary>
		/// Gets or sets the character the user is currently playing.
		/// </summary>
		public Character Character { get; } = new Character();

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
		/// A friend request was sent to a user.
		/// </summary>
		SentRequest,

		/// <summary>
		/// A friend request was received from a user.
		/// </summary>
		ReceivedRequest,

		/// <summary>
		/// The friend request was accepted.
		/// </summary>
		Accepted,

		/// <summary>
		/// The friend request was declined.
		/// </summary>
		Declined,

		/// <summary>
		/// The user was blocked.
		/// </summary>
		Blocked,
	}

	/// <summary>
	/// Specifies the action requested to take on a friend.
	/// </summary>
	public enum FriendCmd : int
	{
		/// <summary>
		/// Accept friend request.
		/// </summary>
		Accept,

		/// <summary>
		/// Decline a friend request.
		/// </summary>
		Decline,

		/// <summary>
		/// Delete or unblock a friend.
		/// </summary>
		Delete,
	}
}
