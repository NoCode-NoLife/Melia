using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Tos.Const;

namespace Melia.Barracks.Database
{
	/// <summary>
	/// Represents a mail message
	/// </summary>
	public class MailMessage
	{
		private readonly object _syncLock = new object();

		/// <summary>
		/// Gets or sets the message's unique id.
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Gets or sets the message's state.
		/// </summary>
		public MailBoxMessageState State { get; set; } = MailBoxMessageState.None;

		/// <summary>
		/// Gets or sets the message's sender.
		/// </summary>
		public string Sender { get; set; }

		/// <summary>
		/// Gets or sets the message's subject.
		/// </summary>
		public string Subject { get; set; }

		/// <summary>
		/// Gets or sets the message.
		/// </summary>
		public string Message { get; set; }

		/// <summary>
		/// Gets or sets the message start date.
		/// </summary>
		public DateTime StartDate { get; set; }

		/// <summary>
		/// Gets or sets the message expiration date.
		/// </summary>
		public DateTime ExpirationDate { get; set; } = DateTime.MaxValue;

		/// <summary>
		/// Gets or sets the message creation date.
		/// </summary>
		public DateTime CreatedDate { get; set; } = DateTime.MaxValue;

		/// <summary>
		/// Gets or sets the message items.
		/// </summary>
		public List<MailItem> Items { get; set; }

		/// <summary>
		/// Returns if the message is read.
		/// </summary>
		public bool IsRead => this.State == MailBoxMessageState.Read;

		public void AddItem(MailItem item)
		{
			lock (_syncLock)
				this.Items.Add(item);
		}

		public bool TryGetItem(int mailItemId, out MailItem item)
		{
			lock (_syncLock)
			{
				item = this.Items.FirstOrDefault(a => a.Id == mailItemId);
				return item != null;
			}
		}
	}

	public class MailItem
	{
		/// <summary>
		/// Gets or sets the mail items index.
		/// </summary>
		public int Index { get; set; }

		/// <summary>
		/// Gets or sets the mail items unique id.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Gets or sets the mail item's item id.
		/// </summary>
		public int ItemId { get; set; }

		/// <summary>
		/// Gets or sets the mail item's amount.
		/// </summary>
		public int Amount { get; set; }

		/// <summary>
		/// Gets or sets if the item is received or not.
		/// </summary>
		public bool IsReceived { get; set; }
	}
}
