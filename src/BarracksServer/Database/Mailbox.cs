using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Tos.Const;

namespace Melia.Barracks.Database
{
	/// <summary>
	/// Mailbox
	/// </summary>
	public class Mailbox
	{
		private readonly List<MailMessage> _mail = new List<MailMessage>();

		/// <summary>
		/// Returns the mail messages
		/// </summary>
		public List<MailMessage> GetMail()
		{
			lock (_mail)
				return _mail;
		}

		/// <summary>
		/// Returns if the mail box has messages
		/// </summary>
		public bool HasMessages { get { lock (_mail) return this._mail.Count > 0; } }

		/// <summary>
		/// Returns the number of unread messages
		/// </summary>
		public int UnreadMessageCount
		{
			get
			{
				lock (_mail)
					return this._mail.Count(a => a.State == MailboxMessageState.None);
			}
		}

		/// <summary>
		/// Returns the number of read messages
		/// </summary>
		public int ReadMessageCount
		{
			get
			{
				lock (_mail)
					return this._mail.Count(a => a.State == MailboxMessageState.Read);
			}
		}

		/// <summary>
		/// Returns the numbers of messages
		/// </summary>
		public int MessageCount { get { lock (_mail) return this._mail.Count; } }

		/// <summary>
		/// Add a mail message
		/// </summary>
		/// <param name="mail"></param>
		public void AddMail(MailMessage mail)
		{
			lock (_mail)
				this._mail.Add(mail);
		}

		/// <summary>
		/// Try to get mail
		/// </summary>
		/// <param name="messageId"></param>
		/// <param name="message"></param>
		/// <returns></returns>
		public bool TryGetMail(long messageId, out MailMessage message)
		{
			lock (_mail)
				message = this._mail.Find(m => m.Id == messageId);
			return message != null;
		}
	}
}
