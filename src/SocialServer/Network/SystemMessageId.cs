namespace Melia.Social.Network
{
	public static class SystemMessageId
	{
		/// <summary>
		/// "This user does not exist."
		/// </summary>
		public const string TargetUserNotExist = "TargetUserNotExist";

		/// <summary>
		/// "Already sent friend request."
		/// </summary>
		public const string AlreadyRequestFriend = "AlreadyRequestFriend";

		/// <summary>
		/// "Already in your Friends List."
		/// </summary>
		public const string AlreadyInFriendList = "AlreadyInFriendList";

		/// <summary>
		/// "Your friend request has been sent."
		/// </summary>
		public const string AckReqAddFriend = "AckReqAddFriend";

		/// <summary>
		/// "You are already in the chat room."
		/// </summary>
		public const string AlreadyEnteredRoom = "AlreadyEnteredRoom";
	}
}
