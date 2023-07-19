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
using g3;
using Mysqlx.Datatypes;
using Mysqlx.Expr;
using Melia.Shared.World;
using Yggdrasil.Extensions;
using static Mysqlx.Expect.Open.Types.Condition.Types;

namespace Melia.Zone.World.Actors.Characters.Components
{
	/// <summary>
	/// Represents the storage component
	/// </summary>
	public class PersonalStorageComponent : CharacterComponent
	{
		private readonly object _syncLock = new object();

		// Items in storage
		// Key: Item's world id
		// Value: Item Storage object
		private Dictionary<long, StorageItem> _storageItems = new Dictionary<long, StorageItem>();

		// Storage occupied positions.
		// Index: Item's position
		// Value: Item's world id
		private long[] _storageItemsPositions;

		// How many positions the storage has.
		private int _maxStorage = 60;

		/// <summary>
		/// Gets the first available position in storage
		/// </summary>
		/// <returns></returns>
		/// <exception cref="Exception"></exception>
		private int FindAvailablePosition()
		{
			for (int i = 0; i < _storageItemsPositions.Length; i++)
			{
				if (_storageItemsPositions[i] != -1)
				{
					return i;
				}
			}

			throw new Exception("PersonalStorageComponent.FindAvailablePosition: Storage data structures mismatch expected storage size");
		}

		/// <summary>
		/// Creates a new storage component
		/// </summary>
		/// <param name="account"></param>
		public PersonalStorageComponent(Character character) : base(character)
		{
			_storageItemsPositions = new long[_maxStorage];
			_storageItemsPositions = Enumerable.Repeat(-1L, _maxStorage).ToArray();
		}

		/// <summary>
		/// Stores an item to storage. The item is identified by its
		/// world id.
		/// </summary>
		/// <param name="worldId"></param>
		/// <param name="amount"></param>
		/// <returns></returns>
		public StorageResult StoreItem(long worldId, int amount = 1)
		{
			if (_storageItems.Count() >= _maxStorage)
				return StorageResult.StorageFull;

			// Checks item is in inventory
			var charItem = this.Character.Inventory.GetItem(worldId);
			if (charItem == null)
				return StorageResult.ItemNotFound;

			var storeItem = charItem;
			storeItem.Amount = Math.Min(amount, charItem.Amount);

			lock (_syncLock)
			{
				if (this.Character.Inventory.Remove(charItem.ObjectId, storeItem.Amount) == InventoryResult.Success)
				{
					// Adds to storage
					this.Add(storeItem);

					// Show item in storage for client
					// Note: Storages are like stores, so this is a sell transaction
					Send.ZC_ITEM_ADD(this.Character, storeItem, 0, storeItem.Amount, InventoryAddType.Sell, InventoryType.Warehouse);
				}
				else
				{
					return StorageResult.ItemNotFound;
				}
			}

			return StorageResult.Success;
		}

		/// <summary>
		/// Removes an item from storage and places in character's
		/// inventory. The item is identified by its world id.
		/// </summary>
		/// <param name="worldId"></param>
		/// <param name="amount"></param>
		/// <returns></returns>
		public StorageResult RetrieveItem(long worldId, int amount = 1)
		{
			// Checks item is in storage
			var storedItem = this.TryGetStorageItem(worldId).Item;
			if (storedItem == null)
				return StorageResult.ItemNotFound;

			var retrieveItem = storedItem;
			retrieveItem.Amount = Math.Min(amount, storedItem.Amount);

			lock (_syncLock)
			{
				storedItem.Amount -= retrieveItem.Amount;

				if (this.Remove(storedItem) == StorageResult.Success)
				{
					// Remove item in storage for client
					Send.ZC_ITEM_REMOVE(this.Character, worldId, storedItem.Amount, InventoryItemRemoveMsg.Sold, InventoryType.Warehouse);

					// Add to player inventory
					this.Character.Inventory.Add(retrieveItem, InventoryAddType.New);
				}
				else
				{
					return StorageResult.InvalidOperation;
				}
			}

			return StorageResult.Success;
		}

		/// <summary>
		/// Adds a new item to the storage.
		/// Does nothing if storage is full.
		/// Does not update client.
		/// </summary>
		/// <param name="item"></param>
		public StorageResult Add(Item item)
		{
			if (_storageItems.Count() >= _maxStorage)
				return StorageResult.StorageFull;

			// Looks for stackable items
			foreach (var storageItem in _storageItems.Values)
			{
				if (storageItem.Item.Data.ClassName == item.Data.ClassName)
				{
					return this.AddItemStack(storageItem, item.Amount);
				}
			}

			// Add to new position
			var availablePosition = this.FindAvailablePosition();
			return this.Add(item, availablePosition);
		}

		/// <summary>
		/// Adds a new item to the storage in specific position.
		/// Does not update client.
		/// </summary>
		/// <param name="item"></param>
		public StorageResult Add(Item item, int position)
		{
			var storageItem = this.TryGetStorageItem(position);
			if (storageItem == null)
			{
				lock (_syncLock)
				{
					// Creates new item
					_storageItemsPositions[position] = item.ObjectId;
					_storageItems.Add(item.ObjectId, new StorageItem(item, position));
					return StorageResult.Success;
				}
			}
			else
			{
				return this.AddItemStack(storageItem, item.Amount);
			}
		}

		/// <summary>
		/// Removes an item from storage.
		/// Does not update client.
		/// </summary>
		/// <param name="item"></param>
		/// <exception cref="ArgumentException"></exception>
		public StorageResult Remove(Item item)
		{
			var storageItem = this.TryGetStorageItem(item.ObjectId);
			if (storageItem == null)
				return StorageResult.ItemNotFound;

			
			

			// ZoneServer.Instance.ServerEvents.OnPlayerRemovedStorageItem(this.Character, item.Id, amountRemoved);
		}

		/// <summary>
		/// Returns all storage items.
		/// </summary>
		/// <returns></returns>
		public Dictionary<long, StorageItem> GetItems()
		{
			return _storageItems;
		}

		/// <summary>
		/// Returns specific storage item, or null if it doesn't exist.
		/// </summary>
		/// <param name="worldId"></param>
		/// <returns></returns>
		public StorageItem TryGetStorageItem(long worldId)
		{
			lock (_syncLock)
			{
				if (_storageItems.TryGetValue(worldId, out var storageItem))
				{
					if (storageItem.Item is DummyEquipItem)
						return null;

					return storageItem;
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Returns specific storage item in position, or null
		/// if it doesn't exist.
		/// </summary>
		/// <param name="position"></param>
		/// <returns></returns>
		public StorageItem TryGetStorageItem(int position)
		{
			return TryGetStorageItem(_storageItemsPositions[position]);
		}

		/// <summary>
		/// Adds amount to the storage item stack. The item must
		/// be stackable.
		/// </summary>
		/// <param name="storageItem"></param>
		/// <returns></returns>
		public StorageResult AddItemStack(StorageItem storageItem, int amount)
		{
			if (!storageItem.Item.IsStackable)
				return StorageResult.InvalidOperation;

			if ((storageItem.Item.Amount + amount) < storageItem.Item.Data.MaxStack)
			{
				storageItem.Item.Amount += amount;
				return StorageResult.Success;
			}
			else
			{
				return StorageResult.InvalidOperation;
			}
		}

		/// <summary>
		/// Removes amount to the storage item stack. The item must
		/// be stackable. Deletes item if none are left.
		/// </summary>
		/// <param name="storageItem"></param>
		/// <param name="amount"></param>
		/// <returns>Amount of pieces removed</returns>
		public int RemoveItemStack(StorageItem storageItem, int amount)
		{
			int amountRemoved = 0;
			var reduce = Math.Min(amount, storageItem.Item.Amount);

			// Remove or reduce
			if (storageItem.Item.Amount <= amount)
			{
				lock (_syncLock)
				{
					_storageItemsPositions[storageItem.Position] = -1;
					_storageItems.Remove(storageItem.Item.ObjectId);
				}
			}
			else
			{
				storageItem.Item.Amount -= amount;
			}
		}
	}
}
