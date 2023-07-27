namespace Melia.Social.Database
{
	/// <summary>
	/// Represents a member of a chat room.
	/// </summary>
	public class ChatMember
	{
		/// <summary>
		/// Returns the chat room's globally unique id.
		/// </summary>
		public long ChatRoomId { get; }

		/// <summary>
		/// Returns the member's account id.
		/// </summary>
		public long AccountId { get; }

		/// <summary>
		/// Returns the member's team name.
		/// </summary>
		public string TeamName { get; }

		/// <summary>
		/// Creates new chat room member.
		/// </summary>
		/// <param name="chatRoomId"></param>
		/// <param name="accountId"></param>
		/// <param name="teamName"></param>
		public ChatMember(long chatRoomId, long accountId, string teamName)
		{
			this.ChatRoomId = chatRoomId;
			this.AccountId = accountId;
			this.TeamName = teamName;
		}
	}
}
