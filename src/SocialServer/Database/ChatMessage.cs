using System;

namespace Melia.Social.Database
{
	/// <summary>
	/// Represents a message in a chat room
	/// </summary>
	public class ChatMessage
	{
		/// <summary>
		/// Returns the account of the chat message's sender.
		/// </summary>
		public Account Sender { get; }

		/// <summary>
		/// Returns the account of the chat message's recipient.
		/// </summary>
		public Account Recipient { get; }

		/// <summary>
		/// Returns the message that was sent.
		/// </summary>
		public string Message { get; }

		/// <summary>
		/// Returns the time the message was sent.
		/// </summary>
		public DateTime SentTime { get; } = DateTime.Now;

		/// <summary>
		/// Creates new chat message.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="message"></param>
		public ChatMessage(Account sender, string message)
			: this(sender, null, message)
		{
		}

		/// <summary>
		/// Creates new chat message.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="recipient"></param>
		/// <param name="message"></param>
		public ChatMessage(Account sender, Account recipient, string message)
		{
			this.Sender = sender;
			this.Recipient = recipient;
			this.Message = message;
		}
	}
}
