// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Shared.Data.Database;
using Melia.Shared.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Melia.Channel.World
{
	public class Item
	{
		private static long _worldId = 0x0050000000000000;

		private int _amount;

		/// <summary>
		/// Returns the item's id.
		/// </summary>
		public int Id { get; private set; }

		/// <summary>
		/// Data from data files.
		/// </summary>
		public ItemData Data { get; private set; }

		/// <summary>
		/// Gets or sets the item's amount (clamped to 1~max),
		/// does not update the client.
		/// </summary>
		public int Amount
		{
			get { return _amount; }
			set
			{
				var max = (this.Data != null ? this.Data.MaxStack : 1);
				_amount = Math2.Clamp(1, max, value);
			}
		}

		/// <summary>
		/// Returns true if item's MaxStack is higher than 1.
		/// </summary>
		public bool IsStackable { get { return this.Data.MaxStack > 1; } }

		/// <summary>
		/// Item's world id...?
		/// </summary>
		/// <remarks>
		/// Is there an entity id like system?
		/// </remarks>
		public long WorldId { get; private set; }

		/// <summary>
		/// Item's price.
		/// </summary>
		public int Price { get; private set; }

		/// <summary>
		/// Creates new item.
		/// </summary>
		/// <param name="itemId"></param>
		/// <param name="amount"></param>
		public Item(int itemId, int amount = 1)
		{
			// Set id and load data, so we have data to work with.
			this.Id = itemId;
			this.LoadData();

			this.WorldId = Interlocked.Increment(ref _worldId);
			this.Amount = amount;
		}

		/// <summary>
		/// Loads item data from data files.
		/// </summary>
		private void LoadData()
		{
			if (this.Id == 0)
				throw new InvalidOperationException("Item id wasn't set before calling LoadData.");

			this.Data = ChannelServer.Instance.Data.ItemDb.Find(this.Id);
			if (this.Data == null)
				throw new NullReferenceException("No item data found for '" + this.Id + "'.");
		}
	}
}
