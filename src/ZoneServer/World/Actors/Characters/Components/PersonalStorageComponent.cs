using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.Database;
using Melia.Shared.Tos.Const;
using Melia.Zone.World.Items;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Characters.Components;
using Yggdrasil.Logging;
using Yggdrasil.Geometry.Shapes;

namespace Melia.Zone.World.Actors.Characters.Components
{
	/// <summary>
	/// Represents the storage component
	/// </summary>
	public class PersonalStorageComponent : CharacterComponent
	{
		private readonly object _syncLock = new object();

		// Items in storage, key is item's world Id
		private Dictionary<long, Item> _itemsWorldIndex = new Dictionary<long, Item>();

		/// <summary>
		/// Creates a new storage component
		/// </summary>
		/// <param name="account"></param>
		public PersonalStorageComponent(Character character) : base(character)
		{
			Item i1 = new Item(221111);
			Item i2 = new Item(221112);

			// Test
			_itemsWorldIndex.Add(i1.ObjectId, i1);
			_itemsWorldIndex.Add(i2.ObjectId, i2);
		}

		/// <summary>
		/// Stores an item to storage
		/// </summary>
		/// <param name="item"></param>
		public StorageResult StoreItem(long worldId)
		{
			Item item;
			lock (_syncLock)
			{
				// Checks item is in inventory
				item = this.Character.Inventory.GetItem(worldId);
				if (item == null || item is DummyEquipItem)
					return StorageResult.ItemNotFound;

				// Remove from player inventory
				// Note: Storages are like stores, so this is a sell transaction
				this.Character.Inventory.Remove(item.ObjectId);

				// Adds to storage
				_itemsWorldIndex.Add(item.ObjectId, item);
			}

			// Add item to storage in client
			Send.ZC_ITEM_ADD(this.Character, item, 1, 1, InventoryAddType.Sell, InventoryType.Warehouse);

			return StorageResult.Success;
		}

		/// <summary>
		/// Removes an item from storage and places in character's
		/// inventory. The item is identified by its worldId.
		/// </summary>
		/// <returns></returns>
		public StorageResult RetrieveItem(long worldId)
		{
			Item item;
			lock (_syncLock)
			{
				// Checks item is in storage
				item = this.GetItem(worldId);
				if (item == null || item is DummyEquipItem)
					return StorageResult.ItemNotFound;

				// Add to player inventory
				this.Character.Inventory.Add(item, InventoryAddType.New);

				// Remove from storage
				_itemsWorldIndex.Remove(worldId);
			}

			// Remove item from storage in client
			Send.ZC_ITEM_REMOVE(this.Character, worldId, 1, InventoryItemRemoveMsg.Sold, InventoryType.Warehouse);

			return StorageResult.Success;
		}

		/// <summary>
		/// Returns list of items in storage.
		/// </summary>
		/// <returns></returns>
		public List<Item> GetItems()
		{
			List<Item> items;
			lock (_syncLock)
				items = _itemsWorldIndex.Values.ToList();

			return items;
		}

		/// <summary>
		/// Returns item by world id, or null if it doesn't exist.
		/// </summary>
		/// <param name="worldId"></param>
		/// <returns></returns>
		public Item GetItem(long worldId)
		{
			Item item;
			lock (_syncLock)
				_itemsWorldIndex.TryGetValue(worldId, out item);

			return item;
		}
	}
}
