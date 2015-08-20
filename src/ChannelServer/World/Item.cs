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

		/// <summary>
		/// Returns the item's id.
		/// </summary>
		public int Id { get; private set; }

		/// <summary>
		/// Data from data files.
		/// </summary>
		public ItemData Data { get; private set; }

		/// <summary>
		/// Returns the amount of the item.
		/// </summary>
		public int Amount { get; set; }

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
			this.Id = itemId;
			this.Amount = Math.Max(1, amount);
			this.WorldId = Interlocked.Increment(ref _worldId);
			this.Price = 1;

			this.LoadData();
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
