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

	public enum FriendState : byte
	{
		Requested,
		Accepted,
		Delete,
		Rejected,
		Blocked,
	}
}
