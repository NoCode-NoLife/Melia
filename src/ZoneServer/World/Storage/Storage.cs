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
using System.Threading;
using System.Collections;

namespace Melia.Zone.World.Storage
{
	/// <summary>
	/// Abstraction of a storage. The storage contains an owner
	/// which can be a character, an account, a guild, etc.
	/// </summary>
	public abstract class Storage
	{
		private static long Ids;
		private readonly object _syncLock = new object();

		private SortedList<int, Item> _storageItems;
		private int _maxStorage = 60;

		/// <summary>
		/// Storage's unique Id
		/// </summary>
		public long Id { get; private set; }

		/// <summary>
		/// Gets the first available position in storage.
		/// Returns -1 if not found.
		/// </summary>
		/// <returns></returns>
		protected int TryFindFirstAvailablePosition()
		{
			lock (_syncLock)
			{

				var keys = _storageItems.Keys;
				int i;
				for (i = 0; i < _storageItems.Keys.Count; i++)
				{
					if (keys[i] != i)
					{
						return i;
					}
				}

				if (i < _maxStorage)
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
		protected int RemoveItemStack(Item item, int amount, int position)
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
		protected int AddItemStack(Item item, int amount)
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
		/// Looks in storage for items that the given item
		/// can stack to. Does nothing if given item is not stackable.
		/// </summary>
		/// <param name="item">Item type look for</param>
		/// <param name="foundStorageItems">Position and Item object of found items</param>
		protected void TryFindStackableItems(Item item, out SortedList<int, Item> foundStorageItems)
		{
			foundStorageItems = new SortedList<int, Item>();

			// Stacks to existing items
			if (item.IsStackable)
			{
				lock (_syncLock)
				{
					foreach (var storageItem in _storageItems)
					{
						var existingItem = storageItem.Value;
						var existingItemPosition = storageItem.Key;
						if (existingItem.IsStackable && (existingItem.Data.ClassName == item.Data.ClassName))
						{
							foundStorageItems.Add(existingItemPosition, existingItem);
						}
					}
				}
			}
		}

		/// <summary>
		/// Creates a new storage.
		/// </summary>
		/// <param name="account"></param>
		public Storage()
		{
			this.Id = Interlocked.Increment(ref Ids);
			_storageItems = new SortedList<int, Item>();
		}

		/// <summary>
		/// Adds an item to storage.
		/// Child class is expected to update client.
		/// </summary>
		/// <param name="objectId">Object id of the item</param>
		/// <param name="amount">Amount to remove</param>
		/// <returns></returns>
		public abstract StorageResult StoreItem(long objectId, int amount = 1);

		/// <summary>
		/// Removes an item from storage.
		/// Child class is expected to update client.
		/// </summary>
		/// <param name="objectId">Object id of the item</param>
		/// <param name="amount">Amount to remove</param>
		/// <returns></returns>
		public abstract StorageResult RetrieveItem(long objectId, int amount = 1);

		/// <summary>
		/// Adds a new item to the storage in first empty position.
		/// Does nothing if storage is full.
		/// Does not update client.
		/// </summary>
		/// <param name="item">Item to add</param>
		/// <param name="addedPosition">Position we added the item to. Defaults to -1</param>
		/// <returns></returns>
		public StorageResult Add(Item item, out int addedPosition)
		{
			addedPosition = -1;

			if (CheckStorageFull())
				return StorageResult.StorageFull;

			// Add to new position
			// Note: we ignore addedAmount because adding to an empty position
			// can never add more than stack maximum.
			var availablePosition = this.TryFindFirstAvailablePosition();
			if (this.AddAtPosition(item, availablePosition, out var addedAmount) == StorageResult.Success)
			{
				addedPosition = availablePosition;
				return StorageResult.Success;
			}

			return StorageResult.InvalidOperation;
		}

		/// <summary>
		/// Adds a new item to the storage in a specific position.
		/// If existing stackable item of same class exists in the position
		/// this method will stack to it.
		/// Does not update client.
		/// </summary>
		/// <param name="item">Item to add</param>
		/// <param name="position">Position of item in storage to add to.</param>
		/// <param name="addedAmount">Amount of item that was added.</param>
		/// <returns></returns>
		public StorageResult AddAtPosition(Item item, int position, out int addedAmount)
		{
			addedAmount = 0;

			if ((position < 0) || (position >= _maxStorage))
				return StorageResult.InvalidOperation;

			var existingItem = this.TryGetItemAtPosition(position);
			if (existingItem == null)
			{
				// Adds item
				lock (_syncLock)
				{
					_storageItems.Add(position, item);
				}
				addedAmount = item.Amount;
				return StorageResult.Success;
			}
			else
			{
				// Stacks item
				if (existingItem.IsStackable && item.IsStackable)
				{
					if (existingItem.Data.ClassName == item.Data.ClassName)
					{
						lock (_syncLock)
							addedAmount = AddItemStack(existingItem, item.Amount);
						return StorageResult.Success;
					}
				}
			}

			return StorageResult.InvalidOperation;
		}

		/// <summary>
		/// Removes an item from storage.
		/// Does not update client.
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

			var result = this.TryGetItem(item.ObjectId, out item, out var position);
			if (result != StorageResult.Success)
				return result;

			// If the item is stackable, handle the reduction of the stack
			if (item.IsStackable)
			{
				lock (_syncLock)
					removedAmount = RemoveItemStack(item, amount, position);
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
		/// Does not update client.
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

			return Remove(item, amount, out var removedPosition, out removedAmount);
		}

		/// <summary>
		/// Returns true if storage is full.
		/// </summary>
		/// <returns></returns>
		public bool CheckStorageFull()
		{
			lock (_syncLock)
				return _storageItems.Count() >= _maxStorage;
		}

		/// <summary>
		/// Returns a dictionary of items in each position
		/// of storage.
		/// </summary>
		/// <returns></returns>
		public Dictionary<int, Item> GetStorage()
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
		public StorageResult TryGetItem(long objectId, out Item item, out int position)
		{
			item = null;
			position = -1;

			lock (_syncLock)
			{
				var storageItem = _storageItems.FirstOrDefault(v => v.Value.ObjectId == objectId);
				if (storageItem.Value != null)
				{
					item = storageItem.Value;
					position = storageItem.Key;
					return StorageResult.Success;
				}
			}

			return StorageResult.ItemNotFound;
		}

		/// <summary>
		/// Returns specific item in position, or null
		/// if it doesn't exist.
		/// </summary>
		/// <param name="position"></param>
		/// <returns></returns>
		public Item TryGetItemAtPosition(int position)
		{
			lock (_syncLock)
				if (_storageItems.TryGetValue(position, out var item))
					return item;

			return null;
		}

		/// <summary>
		/// Returns how many items exist in storage
		/// </summary>
		/// <returns></returns>
		public int GetItemCount()
		{
			lock (_syncLock)
				return _storageItems.Count();
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
			var item1 = this.TryGetItemAtPosition(position1);
			var item2 = this.TryGetItemAtPosition(position2);

			if (item1 == null && item2 == null)
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
			var result1 = this.TryGetItem(objectId1, out var item1, out var position1);
			var result2 = this.TryGetItem(objectId2, out var item2, out var position2);

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
