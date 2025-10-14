using System;
using Melia.Social.World;

namespace Melia.Social.Database
{
	/// <summary>
	/// Represents a message in a chat room.
	/// </summary>
	public class ChatMessage
	{
		/// <summary>
		/// Returns the account id of the message's sender.
		/// </summary>
		public long SenderAccountId { get; }

		/// <summary>
		/// Returns the team name of the message's sender.
		/// </summary>
		public string SenderTeamName { get; }

		/// <summary>
		/// Returns the team name of the message's target.
		/// </summary>
		public string TargetTeamName { get; } = string.Empty;

		/// <summary>
		/// Returns the message that was sent.
		/// </summary>
		public string Message { get; }

		/// <summary>
		/// Returns the message type.
		/// </summary>
		public ChatMessageType Type { get; }

		/// <summary>
		/// Returns the time the message was sent.
		/// </summary>
		public DateTime SentTime { get; } = DateTime.Now;

		/// <summary>
		/// Creates new chat message.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="message"></param>
		/// <param name="type"></param>
		public ChatMessage(SocialUser sender, string message, ChatMessageType type = ChatMessageType.Group)
		{
			this.SenderAccountId = sender.Id;
			this.SenderTeamName = sender.TeamName;
			this.Message = message;
			this.Type = type;
		}

		/// <summary>
		/// Creates new chat message.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="type"></param>
		public ChatMessage(SocialUser sender, SocialUser target, string message, ChatMessageType type = ChatMessageType.Group)
		{
			this.SenderAccountId = sender.Id;
			this.SenderTeamName = sender.TeamName;
			this.TargetTeamName = target.TeamName;
			this.Message = message;
			this.Type = type;
		}
	}

	public enum ChatMessageType
	{
		Party = 0,
		Guild = 1,
		Group = 2,
	}
}
