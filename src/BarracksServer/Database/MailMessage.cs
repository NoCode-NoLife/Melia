﻿using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Game.Const;

namespace Melia.Barracks.Database
{
	/// <summary>
	/// Represents a mail message
	/// </summary>
	public class MailMessage
	{
		private readonly List<MailItem> _items = new();

		/// <summary>
		/// Gets or sets the message's unique id.
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Gets or sets the message's state.
		/// </summary>
		public MailboxMessageState State { get; set; } = MailboxMessageState.Unread;

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
		public DateTime ExpirationDate { get; set; }

		/// <summary>
		/// Gets or sets the message creation date.
		/// </summary>
		public DateTime CreatedDate { get; set; }

		/// <summary>
		/// Returns whether the message was read.
		/// </summary>
		/// <remarks>
		/// All states but "Unread" are considered read.
		/// </remarks>
		public bool IsRead => this.State != MailboxMessageState.Unread;

		/// <summary>
		/// Returns if the message is expired.
		/// </summary>
		public bool IsExpired => DateTime.Now >= this.ExpirationDate;

		/// <summary>
		/// Returns true if any item is unreceived.
		/// </summary>
		public int ReceivableItemsCount { get { lock (_items) return _items.Count(item => !item.WasReceived); } }

		/// <summary>
		/// Allows the item to be selectable via checkbox in UI for receive all.
		/// </summary>
		/// <remarks>
		/// Controls check box for select all, only returns true if the message
		/// is "Unread".
		/// </remarks>
		public bool CanReceive => this.State == MailboxMessageState.Unread && this.ReceivableItemsCount > 0;

		/// <summary>
		/// Returns a copy list of mail items.
		/// </summary>
		/// <returns></returns>
		public List<MailItem> GetItems()
		{
			lock (_items)
				return _items.ToList();
		}

		/// <summary>
		/// Adds an item to the message.
		/// </summary>
		/// <param name="item"></param>
		public void AddItem(MailItem item)
		{
			lock (_items)
				_items.Add(item);
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
				item = _items.Find(a => a.DbId == mailItemId);

			return item != null;
		}
	}

	/// <summary>
	/// A class used to bridge mail item states to the item.
	/// </summary>
	public class MailItem
	{
		/// <summary>
		/// Gets or sets the mail items database id.
		/// </summary>
		public int DbId { get; set; }

		/// <summary>
		/// Gets or sets the mail item's database id.
		/// </summary>
		public long ItemDbId { get; set; }

		/// <summary>
		/// Gets or sets the mail item's class id.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Gets or sets the mail item's amount.
		/// </summary>
		public int Amount { get; set; }

		/// <summary>
		/// Gets or sets if the item was received or not.
		/// </summary>
		public bool WasReceived { get; set; }
	}
}
