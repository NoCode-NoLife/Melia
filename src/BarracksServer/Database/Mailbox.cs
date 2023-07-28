using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Tos.Const;

namespace Melia.Barracks.Database
{
	/// <summary>
	/// Mailbox
	/// </summary>
	public class Mailbox
	{
		private readonly object _syncLock = new object();
		private readonly List<MailMessage> _mail = new List<MailMessage>();

		/// <summary>
		/// Returns the mail messages
		/// </summary>
		public List<MailMessage> GetMail()
		{
			lock (_syncLock)
				return _mail;
		}

		/// <summary>
		/// Returns if the mail box has messages
		/// </summary>
		public bool HasMessages { get { lock (_syncLock) return this._mail.Count > 0; } }

		/// <summary>
		/// Returns the number of unread messages
		/// </summary>
		public int UnreadMesages
		{
			get
			{
				lock (_syncLock)
					return this._mail.Count(a => a.State == MailBoxMessageState.None);
			}
		}

		/// <summary>
		/// Returns the number of read messages
		/// </summary>
		public int ReadMessages
		{
			get
			{
				lock (_syncLock)
					return this._mail.Count(a => a.State == MailBoxMessageState.Read);
			}
		}

		/// <summary>
		/// Returns the numbers of messages
		/// </summary>
		public int MessageCount { get { lock (_syncLock) return this._mail.Count; } }

		/// <summary>
		/// Add a mail message
		/// </summary>
		/// <param name="mail"></param>
		public void AddMail(MailMessage mail)
		{
			lock (_syncLock)
				this._mail.Add(mail);
		}

		/// <summary>
		/// Try to get mail
		/// </summary>
		/// <param name="messageId"></param>
		/// <param name="mail"></param>
		/// <returns></returns>
		public bool TryGet(long messageId, out MailMessage message)
		{
			lock (_syncLock)
				message = this._mail.Find(m => m.Id == messageId);
			return message != null;
		}
	}
}
