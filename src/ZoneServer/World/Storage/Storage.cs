using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Game.Const;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Characters.Components;
using Melia.Zone.World.Items;

namespace Melia.Zone.World.Storage
{
	/// <summary>
	/// Abstraction of a storage. Provides basic storage management methods.
	/// Child classes are expected to implement how storage can be accessed.
	/// </summary>
	public abstract class Storage
	{
		private readonly object _syncLock = new();

		private readonly SortedList<int, Item> _storageItems = new();
		private int _storageSize = 0;

		/// <summary>
		/// Returns whether the storage is currently being browsed.
		/// </summary>
		public bool IsBrowsing { get; protected set; }

		/// <summary>
		/// Gets the first available position in storage.
		/// Returns -1 if not found.
		/// </summary>
		/// <returns></returns>
		private int GetFirstAvailablePosition()
		{
			lock (_syncLock)
			{

				var keys = _storageItems.Keys;
				var i = 0;

				for (; i < _storageItems.Keys.Count; i++)
				{
					if (keys[i] != i)
						return i;
				}

				if (i < _storageSize)
					return i;
			}
			return -1;
		}

		/// <summary>
		/// Removes amount from item stack.
		/// Deletes item if none are left.
		/// If item is not found in storage, returns 0.
		/// If item is not stackable, returns 0.
		/// </summary>
		/// <param name="item">Item to remove</param>
		/// <param name="amount">Amount of stack to remove from item</param>
		/// <param name="position">position of item in storage</param>
		/// <returns>Amount of stack removed</returns>
		private int RemoveItemStack(Item item, int amount, int position)
		{
			if (!item.IsStackable)
				return 0;

			if (amount <= 0)
				return 0;

			int amountRemoved;

			// Remove item completely
			if (item.Amount <= amount)
			{
				amountRemoved = item.Amount;
				_storageItems.Remove(position);

			}
			// Remove item stacks
			else
			{
				item.Amount -= amount;
				amountRemoved = amount;
			}

			return amountRemoved;
		}

		/// <summary>
		/// Adds amount to the item stack.
		/// If item is not found in storage, returns 0.
		/// If item is not stackable, returns 0.
		/// </summary>
		/// <param name="item">Item to add</param>
		/// <param name="amount">Amount to stack to item</param>
		/// <returns>Amount of stack added</returns>
		private int AddItemStack(Item item, int amount)
		{
			if (!item.IsStackable)
				return 0;

			if (amount <= 0)
				return 0;

			if ((item.Amount + amount) < item.Data.MaxStack)
			{
				item.Amount += amount;
				return amount;
			}
			else
			{
				var amountToAdd = item.Data.MaxStack - item.Amount;
				item.Amount += amountToAdd;

				return amountToAdd;
			}
		}

		/// <summary>
		/// Returns a list of item stacks that the given item can be added to.
		/// </summary>
		/// <param name="item">Item type look for</param>
		private SortedList<int, Item> GetStackableItems(Item item)
		{
			var result = new SortedList<int, Item>();

			// Stacks to existing items
			if (!item.IsStackable)
				return result;

			lock (_syncLock)
			{
				foreach (var storageItem in _storageItems)
				{
					var existingItem = storageItem.Value;
					var existingItemPosition = storageItem.Key;

					if (!existingItem.IsStackable)
						continue;

					if (existingItem.Data.ClassName != item.Data.ClassName)
						continue;

					result.Add(existingItemPosition, existingItem);
				}
			}

			return result;
		}

		/// <summary>
		/// Calculates the amount of given item that can be added to storage.
		/// </summary>
		/// <param name="item">Item and the amount to check</param>
		/// <returns></returns>
		private int GetItemAvailableAmount(Item item)
		{
			var availableAmount = 0;

			// Checks if stackable item can be placed in storage
			if (item.IsStackable)
			{
				var existingStorageItems = this.GetStackableItems(item);
				var stackAvailableAmount = existingStorageItems.Values.Sum(existingItem => existingItem.Data.MaxStack - existingItem.Amount);

				// No space in existing stacks and no new position available
				if (this.CheckStorageFull() && stackAvailableAmount <= 0)
					return 0;

				// Existing stacks can't stack and adding to new position is disabled
				if (!ZoneServer.Instance.Conf.World.StorageMultiStack && stackAvailableAmount <= 0)
					return 0;

				availableAmount = stackAvailableAmount;

				// We can also add the stack to empty spaces if multistack is enabled
				if (ZoneServer.Instance.Conf.World.StorageMultiStack && !this.CheckStorageFull())
					availableAmount = item.Data.MaxStack;
			}
			else
			{
				// Checks if non stackable item can be placed in storage
				if (this.CheckStorageFull())
					return 0;

				availableAmount = item.Amount;
			}

			return availableAmount;
		}

		/// <summary>
		/// Adds the item to any already existing stacks of same item type
		/// in storage and creates new stack if there are leftovers after
		/// reaching the maximum stack limit.
		/// Updates client.
		/// </summary>
		/// <param name="character">Character to update</param>
		/// <param name="itemToStore">Item to store</param>
		/// <param name="invType">Type of storage inventory</param>
		/// <returns></returns>
		private StorageResult AddItemStackWithResidue(Character character, Item itemToStore, InventoryType invType)
		{
			// For stackable items, add item to existing stacks.
			if (itemToStore.IsStackable)
			{
				var existingStorageItems = this.GetStackableItems(itemToStore);
				var addedAmount = 0;

				foreach (var existingStorageItem in existingStorageItems)
				{
					var stackedAmount = this.AddItemStack(existingStorageItem.Value, itemToStore.Amount - addedAmount);
					addedAmount += stackedAmount;

					if (stackedAmount > 0)
						Send.ZC_ITEM_ADD(character, existingStorageItem.Value, existingStorageItem.Key, stackedAmount, InventoryAddType.New, invType);
				}

				// If all items have been stored, return success
				if (addedAmount >= itemToStore.Amount)
					return StorageResult.Success;

				// Residue
				itemToStore.Amount -= addedAmount;
			}

			// Adds item to new position
			var storageResult = this.Add(itemToStore, out var addedPosition);
			if (storageResult == StorageResult.Success)
				Send.ZC_ITEM_ADD(character, itemToStore, addedPosition, itemToStore.Amount, InventoryAddType.New, invType);

			return storageResult;
		}

		/// <summary>
		/// Adds an item to storage and removes from given character.
		/// Updates client.
		/// </summary>
		/// <param name="character">Character that is performing interaction</param>
		/// <param name="objectId">ObjectId of item to store</param>
		/// <param name="amount">Amount of item to store</param>
		/// <param name="invType">Storage inventory type</param>
		/// <returns></returns>
		protected StorageResult StoreItem(Character character, long objectId, int amount, InventoryType invType)
		{
			var item = character.Inventory.GetItem(objectId);
			if (item == null)
				return StorageResult.ItemNotFound;

			var itemToStore = new Item(item);
			itemToStore.Amount = Math.Min(itemToStore.Amount, amount);

			// Checks amount that can be stored
			var availableAmount = this.GetItemAvailableAmount(itemToStore);
			if (availableAmount <= 0)
				return StorageResult.StorageFull;

			itemToStore.Amount = Math.Min(itemToStore.Amount, availableAmount);

			// Remove the amount from character
			var inventoryResult = character.Inventory.Remove(item, itemToStore.Amount, InventoryItemRemoveMsg.Given);
			if (inventoryResult != InventoryResult.Success)
				return StorageResult.InvalidOperation;

			// Add the amount to storage
			var addResult = this.AddItemStackWithResidue(character, itemToStore, invType);
			if (addResult != StorageResult.Success)
				return addResult;

			return StorageResult.Success;
		}

		/// <summary>
		/// Adds a list of items to storage and removes from given character.
		/// Updates client.
		/// </summary>
		/// <param name="character">Character that is performing interaction</param>
		/// <param name="objectIds">ObjectId of items to store</param>
		/// <param name="invType">Storage inventory type</param>
		/// <returns></returns>
		protected StorageResult StoreItems(Character character, List<long> objectIds, List<int> amounts, InventoryType invType)
		{
			if (objectIds.Count != amounts.Count)
				return StorageResult.InvalidOperation;

			for (var i = 0; i < objectIds.Count; i++)
			{
				var item = character.Inventory.GetItem(objectIds[i]);
				if (item == null)
					return StorageResult.ItemNotFound;

				var result = this.StoreItem(character, objectIds[i], amounts[i], invType);
				if (result != StorageResult.Success)
					return result;
			}

			return StorageResult.Success;
		}

		/// <summary>
		/// Removes an item from storage and gives to a character.
		/// Updates client.
		/// </summary>
		/// <param name="character">Character that is performing interaction</param>
		/// <param name="objectId">ObjectId of item to retrieve</param>
		/// <param name="amount">Amount of item to retrieve</param>
		/// <param name="invType">Storage inventory type</param>
		/// <returns></returns>
		protected StorageResult RetrieveItem(Character character, long objectId, int amount, InventoryType invType)
		{
			// Checks item is in storage
			var result = this.GetItem(objectId, out var item, out var itemPosition);
			if (result != StorageResult.Success)
				return result;

			var itemToRetrieve = new Item(item);

			// Remove item from storage
			var storageResult = this.Remove(item, amount, out itemPosition, out var removedAmount);
			if (storageResult != StorageResult.Success)
				return storageResult;

			Send.ZC_ITEM_REMOVE(character, item.ObjectId, removedAmount, InventoryItemRemoveMsg.Given, invType);

			// Add to player inventory
			itemToRetrieve.Amount = removedAmount;
			character.Inventory.Add(itemToRetrieve, InventoryAddType.New);

			return StorageResult.Success;
		}

		/// <summary>
		/// Removes a list of items from storage and gives to a character.
		/// Updates client.
		/// </summary>
		/// <param name="character">Character that is performing interaction</param>
		/// <param name="objectIds">ObjectId of items to retrieve</param>
		/// <param name="amounts">Amount of items to retrieve</param>
		/// <param name="invType">Storage inventory type</param>
		/// <returns></returns>
		protected StorageResult RetrieveItems(Character character, List<long> objectIds, List<int> amounts, InventoryType invType)
		{
			if (objectIds.Count != amounts.Count)
				return StorageResult.InvalidOperation;

			for (var i = 0; i < objectIds.Count; i++)
			{
				var result = this.GetItem(objectIds[i], out var item, out var itemPosition);
				if (result != StorageResult.Success)
					return result;

				result = this.RetrieveItem(character, objectIds[i], amounts[i], invType);
				if (result != StorageResult.Success)
					return result;
			}
			return StorageResult.Success;
		}

		/// <summary>
		/// Opens storage.
		/// Child class is expected to open it for client.
		/// </summary>
		/// <returns></returns>
		public abstract StorageResult Open();

		/// <summary>
		/// Closes storage.
		/// Child class is expected to close it for client.
		/// </summary>
		/// <returns></returns>
		public abstract StorageResult Close();

		/// <summary>
		/// Adds an item to storage.
		/// Child class is expected to define the interacting character.
		/// </summary>
		/// <param name="objectId"></param>
		/// <param name="amount"></param>
		/// <returns></returns>
		public abstract StorageResult StoreItem(long objectId, int amount);

		/// <summary>
		/// Retrieves an item from storage.
		/// Child class is expected to define the interacting character.
		/// </summary>
		/// <param name="objectId"></param>
		/// <param name="amount"></param>
		/// <returns></returns>
		public abstract StorageResult RetrieveItem(long objectId, int amount);

		/// <summary>
		/// Adds a new item to the storage in first empty position.
		/// Does nothing if storage is full.
		/// </summary>
		/// <param name="item">Item to add</param>
		/// <param name="addedPosition">Position we added the item to. Defaults to -1</param>
		/// <returns></returns>
		public StorageResult Add(Item item, out int addedPosition)
		{
			addedPosition = -1;

			if (this.CheckStorageFull())
				return StorageResult.StorageFull;

			// Add to new position
			// Note: we ignore addedAmount because adding to an empty position
			// can never add more than stack maximum.
			var availablePosition = this.GetFirstAvailablePosition();

			if (this.AddAtPosition(item, availablePosition, out var addedAmount) != StorageResult.Success)
				return StorageResult.InvalidOperation;

			addedPosition = availablePosition;
			return StorageResult.Success;
		}

		/// <summary>
		/// Adds a new item to the storage in a specific position.
		/// If existing stackable item of same class exists in the position
		/// this method will stack to it. If item cannot be added to position and
		/// cannot be stacked, we will add to first valid position instead.
		/// </summary>
		/// <param name="item">Item to add</param>
		/// <param name="position">Position of item in storage to add to.</param>
		/// <param name="addedAmount">Amount of item that was added.</param>
		/// <returns></returns>
		public StorageResult AddAtPosition(Item item, int position, out int addedAmount)
		{
			addedAmount = 0;

			if (position < 0 || position >= _storageSize)
				return StorageResult.InvalidOperation;

			var existingItem = this.GetItemAtPosition(position);
			if (existingItem == null)
			{
				// Adds item
				lock (_syncLock)
					_storageItems.Add(position, item);

				addedAmount = item.Amount;

				return StorageResult.Success;
			}
			else
			{
				var canBeStacked = existingItem.IsStackable && item.IsStackable && existingItem.Data.ClassName == item.Data.ClassName;

				// Cannot stack item, add to any available position
				if (!canBeStacked)
					return this.Add(item, out var addedPosition);

				// Stacks same item
				lock (_syncLock)
					addedAmount = this.AddItemStack(existingItem, item.Amount);

				return StorageResult.Success;
			}
		}

		/// <summary>
		/// Removes an item from storage.
		/// </summary>
		/// <param name="item">Item to remove</param>
		/// <param name="amount">Amount of the item</param>
		/// <param name="removedPosition">Position where item was removed. Defaults to -1</param>
		/// <param name="removedAmount">Amount that was removed. Defaults to 0</param>
		/// <returns></returns>
		public StorageResult Remove(Item item, int amount, out int removedPosition, out int removedAmount)
		{
			removedAmount = 0;
			removedPosition = -1;

			if (amount <= 0)
				return StorageResult.InvalidOperation;

			var result = this.GetItem(item.ObjectId, out item, out var position);
			if (result != StorageResult.Success)
				return result;

			// If the item is stackable, handle the reduction of the stack
			if (item.IsStackable)
			{
				lock (_syncLock)
					removedAmount = this.RemoveItemStack(item, amount, position);
			}
			else
			{
				lock (_syncLock)
				{
					_storageItems.Remove(position);
					removedAmount = item.Amount;
				}
			}
			return StorageResult.Success;
		}

		/// <summary>
		/// Removes an item from storage in a specific position.
		/// </summary>
		/// <param name="item">Item to remove</param>
		/// <param name="amount">Amount of the item</param>
		/// <param name="removedAmount">Amount that was removed. Defaults to 0</param>
		/// <returns></returns>
		public StorageResult RemoveAtPosition(int position, int amount, out int removedAmount)
		{
			removedAmount = 0;

			if (amount <= 0)
				return StorageResult.InvalidOperation;

			var result = _storageItems.TryGetValue(position, out var item);
			if (!result)
				return StorageResult.ItemNotFound;

			return this.Remove(item, amount, out var removedPosition, out removedAmount);
		}

		/// <summary>
		/// Returns true if storage is full.
		/// </summary>
		/// <returns></returns>
		public bool CheckStorageFull()
		{
			lock (_syncLock)
				return _storageItems.Count >= _storageSize;
		}

		/// <summary>
		/// Returns a dictionary of items in each position
		/// of storage.
		/// </summary>
		/// <returns></returns>
		public virtual Dictionary<int, Item> GetItems()
		{
			lock (_syncLock)
				return _storageItems.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
		}

		/// <summary>
		/// Returns specific item, or null if it doesn't exist.
		/// </summary>
		/// <param name="objectId">Item object id</param>
		/// <param name="item">Item found</param>
		/// <param name="position">Position of item found in storage</param>
		/// <returns></returns>
		public StorageResult GetItem(long objectId, out Item item, out int position)
		{
			item = null;
			position = -1;

			lock (_syncLock)
			{
				var storageItem = _storageItems.FirstOrDefault(v => v.Value.ObjectId == objectId);
				if (storageItem.Value == null)
					return StorageResult.ItemNotFound;

				item = storageItem.Value;
				position = storageItem.Key;

				return StorageResult.Success;
			}
		}

		/// <summary>
		/// Returns specific item in position, or null
		/// if it doesn't exist.
		/// </summary>
		/// <param name="position"></param>
		/// <returns></returns>
		public Item GetItemAtPosition(int position)
		{
			lock (_syncLock)
			{
				if (_storageItems.TryGetValue(position, out var item))
					return item;
			}

			return null;
		}

		/// <summary>
		/// Returns how many items exist in storage
		/// </summary>
		/// <returns></returns>
		public int GetItemCount()
		{
			lock (_syncLock)
				return _storageItems.Count;
		}

		/// <summary>
		/// Returns the max size of this storage
		/// </summary>
		/// <returns></returns>
		public int GetStorageSize()
		{
			return _storageSize;
		}

		/// <summary>
		/// Changes max storage size to the given number.
		/// </summary>
		/// <param name="newSize"></param>
		/// <returns></returns>
		public StorageResult SetStorageSize(int newSize)
		{
			var diff = newSize - _storageSize;
			return this.ModifySize(diff);
		}

		/// <summary>
		/// Changes max storage size by the given number.
		/// </summary>
		/// <param name="addSize"></param>
		public StorageResult ModifySize(int addSize)
		{
			var newSize = _storageSize + addSize;
			if (newSize <= 0)
				return StorageResult.InvalidOperation;

			_storageSize += addSize;

			// Decrease in storage size may result in items being lost
			if (addSize < 0)
			{
				for (var i = _storageItems.Count - 1; i >= _storageSize; i--)
					_storageItems.RemoveAt(i);
			}

			return StorageResult.Success;
		}

		/// <summary>
		/// Swaps items in two positions.
		/// Moves item into position2 if empty.
		/// </summary>
		/// <param name="position1">Item1 object id</param>
		/// <param name="position2">Item2 object id</param>
		/// <returns></returns>
		public StorageResult Swap(int position1, int position2)
		{
			var item1 = this.GetItemAtPosition(position1);
			var item2 = this.GetItemAtPosition(position2);

			if ((item1 == null && item2 == null) || position1 == position2)
				return StorageResult.InvalidOperation;

			lock (_syncLock)
			{
				if (item1 != null && item2 != null)
				{
					_storageItems.Remove(position1);
					_storageItems.Remove(position2);
					_storageItems.Add(position1, item2);
					_storageItems.Add(position2, item1);
				}
				else if (item1 != null)
				{
					_storageItems.Remove(position1);
					_storageItems.Add(position2, item1);
				}
				else if (item2 != null)
				{
					_storageItems.Remove(position2);
					_storageItems.Add(position1, item2);
				}
			}

			return StorageResult.Success;
		}

		/// <summary>
		/// Swaps two existing items with each other.
		/// </summary>
		/// <param name="objectId1">Item1 object id</param>
		/// <param name="objectId2">Item2 object id</param>
		/// <returns></returns>
		public StorageResult Swap(long objectId1, long objectId2)
		{
			var result1 = this.GetItem(objectId1, out var item1, out var position1);
			var result2 = this.GetItem(objectId2, out var item2, out var position2);

			if (result1 != StorageResult.Success)
				return result1;

			if (result2 != StorageResult.Success)
				return result2;

			lock (_syncLock)
			{
				_storageItems.Remove(position1);
				_storageItems.Remove(position2);
				_storageItems.Add(position1, item2);
				_storageItems.Add(position2, item1);
			}

			return StorageResult.Success;
		}
	}
}
