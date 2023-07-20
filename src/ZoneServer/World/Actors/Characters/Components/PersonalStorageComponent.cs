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

namespace Melia.Zone.World.Actors.Characters.Components
{
	/// <summary>
	/// Represents the storage component
	/// </summary>
	public class PersonalStorageComponent : CharacterComponent
	{
		private readonly object _syncLock = new object();

		// Items in storage
		// Index is its storage position.
		private Item[] _storageItems;

		// How many positions the storage has.
		private int _maxStorage = 60;

		/// <summary>
		/// Gets the first available position in storage.
		/// Returns -1 if not found.
		/// </summary>
		/// <returns></returns>
		/// <exception cref="Exception"></exception>
		private int FindAvailablePosition()
		{
			for (var i = 0; i < _maxStorage; i++)
			{
				if (_storageItems[i] == null)
				{
					return i;
				}
			}
			return -1;
		}

		/// <summary>
		/// Creates a new storage component
		/// </summary>
		/// <param name="account"></param>
		public PersonalStorageComponent(Character character) : base(character)
		{
			_storageItems = new Item[_maxStorage];
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
			if (_storageItems.Count() > _maxStorage)
				return StorageResult.StorageFull;

			// Checks item is in inventory
			var charItem = this.Character.Inventory.GetItem(worldId);
			if (charItem == null)
				return StorageResult.ItemNotFound;

			var itemToStore = new Item(charItem);
			itemToStore.Amount = Math.Min(amount, charItem.Amount);

			lock (_syncLock)
			{
				if (this.Character.Inventory.Remove(charItem.ObjectId, itemToStore.Amount) == InventoryResult.Success)
				{
					// Adds to storage
					this.Add(itemToStore, out var position);

					// Show item in storage for client
					// Note: Storages are like stores, so this is a sell transaction
					Send.ZC_ITEM_ADD(this.Character, itemToStore, position, itemToStore.Amount, InventoryAddType.Sell, InventoryType.Warehouse);
				}
				else
				{
					return StorageResult.InvalidOperation;
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
			var result = this.TryGetItem(worldId, out var storedItem, out var position);
			if (result != StorageResult.Success)
				return result;

			var itemToRetrieve = new Item(storedItem);
			itemToRetrieve.Amount = Math.Min(amount, storedItem.Amount);

			lock (_syncLock)
			{
				if (this.Remove(storedItem) == StorageResult.Success)
				{
					// Add to player inventory
					this.Character.Inventory.Add(itemToRetrieve, InventoryAddType.New);

					// Remove item in storage for client
					Send.ZC_ITEM_REMOVE(this.Character, worldId, storedItem.Amount, InventoryItemRemoveMsg.Sold, InventoryType.Warehouse);
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
		/// Returns via out position it was stored in.
		/// Does nothing if storage is full and position will be -1.
		/// Does not update client.
		/// </summary>
		/// <param name="item"></param>
		public StorageResult Add(Item item, out int position)
		{
			position = -1;

			if (_storageItems.Count() > _maxStorage)
				return StorageResult.StorageFull;

			// Looks for stackable items
			if (item.IsStackable && item.Amount > 1)
			{
				for (int i = 0; i < _maxStorage; i++)
				{
					if ((_storageItems[i] != null) && (_storageItems[i].Data.ClassName == item.Data.ClassName))
					{
						position = i;
						return this.AddItemStack(item, item.Amount);
					}
				}
			}
			
			// Add to new position
			var availablePosition = this.FindAvailablePosition();
			if (availablePosition != -1)
			{
				return this.Add(item, availablePosition);
			}
			else
			{
				return StorageResult.StorageFull;
			}
		}

		/// <summary>
		/// Adds a new item to the storage in specific position.
		/// Does not update client.
		/// </summary>
		/// <param name="item"></param>
		public StorageResult Add(Item item, int position)
		{
			var existingItem = this.TryGetItemPosition(position);
			if (existingItem == null)
			{
				lock (_syncLock)
				{
					// Adds item
					_storageItems[position] = item;
					return StorageResult.Success;
				}
			}
			else
			{
				if (item.IsStackable && item.Amount > 1)
				{
					if (existingItem.Data.ClassName == item.Data.ClassName)
					{
						return this.AddItemStack(existingItem, item.Amount);
					}
				}
			}

			return StorageResult.InvalidOperation;
		}

		/// <summary>
		/// Removes an item from storage.
		/// Does not update client.
		/// </summary>
		/// <param name="item"></param>
		/// <exception cref="ArgumentException"></exception>
		public StorageResult Remove(Item item)
		{
			var result = this.TryGetItem(item.ObjectId, out item, out var position);
			if (result != StorageResult.Success)
				return result;

			lock (_syncLock)
			{
				// If the item is stackable, handle the reduction of the stack
				if (item.IsStackable && item.Amount > 1)
				{
					int removedAmount = RemoveItemStack(item, item.Amount);
					if (removedAmount == item.Amount)
					{
						// Successfully removed the specified amount from the stack
						return StorageResult.Success;
					}
					else
					{
						// There was an issue reducing the stack (e.g., trying to remove more than available)
						return StorageResult.InvalidOperation;
					}
				}
				else
				{
					_storageItems[position] = null;
				}
			}
			return StorageResult.Success;
		}
		/*
		/// <summary>
		/// Removes item from storage in specific position.
		/// Does not update client.
		/// </summary>
		/// <param name="item"></param>
		/// <param name="position"></param>
		/// <returns></returns>
		public StorageResult Remove(Item item, int position)
		{
			var Item = TryGetStorageItem(position);
			if (Item == null)
				return StorageResult.ItemNotFound;

			if (Item.Item.ObjectId != item.ObjectId)
				return StorageResult.InvalidOperation;

			lock (_syncLock)
			{
				// If the item is stackable, handle the reduction of the stack
				if (item.IsStackable && item.Amount > 1)
				{
					int removedAmount = RemoveItemStack(Item, item.Amount);
					if (removedAmount == item.Amount)
					{
						// Successfully removed the specified amount from the stack
						return StorageResult.Success;
					}
					else
					{
						// There was an issue reducing the stack (e.g., trying to remove more than available)
						return StorageResult.InvalidOperation;
					}
				}
				else
				{
					// If the item is not stackable or there is only one left, remove the item from storage completely
					_storageItemsPositions[position] = -1;
					_storageItems.Remove(item.ObjectId);
				}
			}

			return StorageResult.Success;
		}
		*/

		/// <summary>
		/// Returns a dictionary of items in each position
		/// of storage.
		/// </summary>
		/// <returns></returns>
		public Dictionary<int, Item> GetStorage()
		{
			// Filter out null items and create a dictionary
			var storageDictionary = _storageItems
				.Select((item, index) => new { Item = item, Index = index })
				.Where(itemData => itemData.Item != null)
				.ToDictionary(itemData => itemData.Index, itemData => itemData.Item);

			return storageDictionary;
		}

		/// <summary>
		/// Returns specific item, or null if it doesn't exist.
		/// </summary>
		/// <param name="worldId"></param>
		/// <returns></returns>
		public StorageResult TryGetItem(long worldId, out Item item, out int position)
		{
			item = null;
			position = -1;

			lock (_syncLock)
			{
				for (var i = 0; i < _maxStorage; i++)
				{
					if ((_storageItems[i] != null) && (_storageItems[i].ObjectId == worldId))
					{
						item = _storageItems[i];
						position = i;
						return StorageResult.Success;
					}
				}

				return StorageResult.ItemNotFound;
			}
		}

		/// <summary>
		/// Returns specific item in position, or null
		/// if it doesn't exist.
		/// </summary>
		/// <param name="position"></param>
		/// <returns></returns>
		public Item TryGetItemPosition(int position)
		{
			return _storageItems[position];
		}

		/// <summary>
		/// Adds amount to the item stack. The item must
		/// be stackable.
		/// </summary>
		/// <param name="item"></param>
		/// <returns></returns>
		public StorageResult AddItemStack(Item item, int amount)
		{
			if (!item.IsStackable)
				return StorageResult.InvalidOperation;

			if ((item.Amount + amount) < item.Data.MaxStack)
			{
				item.Amount += amount;
				return StorageResult.Success;
			}
			else
			{
				return StorageResult.InvalidOperation;
			}
		}

		/// <summary>
		/// Removes amount from item stack.
		/// Deletes item if none are left.
		/// If item is not found in storage, returns -1.
		/// </summary>
		/// <param name="item"></param>
		/// <param name="amount"></param>
		/// <returns>Amount of pieces removed</returns>
		public int RemoveItemStack(Item item, int amount)
		{ 
			var reduce = Math.Min(amount, item.Amount);

			item.Amount -= reduce;

			// Remove item completely
			if (item.Amount <= 0)
			{
				lock (_syncLock)
				{
					var result = TryGetItem(item.ObjectId, out item, out var position);
					if (result != StorageResult.Success)
					{
						return -1;
					}

					_storageItems[position] = null;
				}
			}
			return reduce;
		}
	}
}
