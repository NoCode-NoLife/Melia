using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Social.Database
{
	/// <summary>
	/// Represents a chat group.
	/// </summary>
	public class ChatGroup
	{
		/// <summary>
		/// Unique chat id
		/// </summary>
		public long ChatId { get; set; }

		/// <summary>
		/// Chat owner's id
		/// </summary>
		public long SenderId { get; set; }

		/// <summary>
		/// Chat owner's name
		/// </summary>
		public string SenderName { get; set; }

		/// <summary>
		/// Chat receiver's id
		/// </summary>
		public long ReceiverId { get; set; }

		/// <summary>
		/// Chat receiver's name
		/// </summary>
		public string ReceiverName { get; set; }

		/// <summary>
		/// A list of messages sent in the chat.
		/// </summary>
		public List<string> Messages { get; } = new List<string>();
	}
}
