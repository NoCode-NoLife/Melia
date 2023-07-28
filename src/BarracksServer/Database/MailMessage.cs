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
		private readonly List<MailItem> _items = new List<MailItem>();

		/// <summary>
		/// Gets or sets the message's unique id.
		/// </summary>
		public long Id { get; set; } = 0;

		/// <summary>
		/// Gets or sets the message's state.
		/// </summary>
		public MailboxMessageState State { get; set; } = MailboxMessageState.None;

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
		/// Returns if the message is read.
		/// </summary>
		public bool IsRead => this.State == MailboxMessageState.Read;

		/// <summary>
		/// Returns if the message is read.
		/// </summary>
		public bool HasItems()
		{
			lock (_items)
				return this._items.Exists(item => !item.IsReceived);
		}

		public List<MailItem> GetItems()
		{
			lock (_items)
				return _items;
		}

		/// <summary>
		/// Adds an item to the message.
		/// </summary>
		/// <param name="item"></param>
		public void AddItem(MailItem item)
		{
			lock (_items)
				this._items.Add(item);
		}

		/// <summary>
		/// Returns the item with the given mail item id.
		/// Returns false if no item was found.
		/// </summary>
		/// <param name="mapId"></param>
		/// <returns></returns>
		public bool TryGetItem(int mailItemId, out MailItem item)
		{
			lock (_items)
			{
				item = this._items.Find(a => a.Id == mailItemId);
				return item != null;
			}
		}
	}

	public class MailItem
	{
		/// <summary>
		/// Gets or sets the mail items unique id.
		/// </summary>
		public int Id { get; set; } = 0;

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
