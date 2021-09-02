// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Threading;
using Melia.Shared.Const;
using Melia.Shared.Data.Database;
using Melia.Shared.Util;
using Melia.Shared.World.ObjectProperties;

namespace Melia.Channel.World
{
	public class Item : IPropertyObject
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
		/// Item's unique object id.
		/// </summary>
		public long ObjectId { get; set; }

		/// <summary>
		/// Item's price.
		/// </summary>
		public int Price { get; private set; }

		/// <summary>
		/// Specifies whether the item is locked.
		/// </summary>
		/// <remarks>
		/// XXX: Should this be saved? If so, we have to figure out where
		///   that goes in the item data.
		/// </remarks>
		public bool IsLocked { get; set; }

		/// <summary>
		/// Item's properties.
		/// </summary>
		public Properties Properties { get; } = new Properties();

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

			this.ObjectId = Interlocked.Increment(ref _worldId);
			this.Amount = amount;

			//foreach (var property in this.Data.Properties)
			//	this.Properties.Add(new FloatProperty(property.Key, (float)property.Value));
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

		/// <summary>
		/// Returns the item's index in the inventory, using the given
		/// index as an offset for the category the item belongs to.
		/// </summary>
		/// <example>
		/// item = Drug_HP1
		/// item.GetInventoryIndex(5) => 265001 + 5 = 265006
		/// </example>
		/// <remarks>
		/// The client uses index ranges for categorizing the items.
		/// For example:
		/// 45000~109999:  Equipment/MainWeapon
		/// 265000~274999: Item/Consumable
		/// 
		/// The server needs to put the items indices into the correct
		/// ranges for them to appear where they belong, otherwise a
		/// potion might be put into the equip category.
		/// </remarks>
		/// <param name="index"></param>
		/// <returns></returns>
		public int GetInventoryIndex(int index)
		{
			// If the category is none, use the index. This will put
			// the item well below the first category at index 5000
			// and effectively hide it.
			if (this.Data.Category == InventoryCategory.None)
				return index;

			// Get the base id from the database, add the index and return it.
			if (!ChannelServer.Instance.Data.InvBaseIdDb.TryFind(this.Data.Category, out var invBaseData))
				throw new MissingFieldException($"Category '{this.Data.Category}' on item '{this.Id}' not found in base id database.");

			return invBaseData.BaseId + index;
		}
	}
}
