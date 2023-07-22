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
using Melia.Shared.World;
using g3;
using Melia.Shared.Data.Database;
using Melia.Zone.World.Maps;
using Yggdrasil.Logging;

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

		// How many different items are in storage
		private int _occupiedPositions = 0;

		// How many positions the storage has.
		private int _maxStorage = 60;

		/// <summary>
		/// Gets the first available position in storage.
		/// Returns -1 if not found.
		/// </summary>
		/// <returns></returns>
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
				_storageItems[position] = null;

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
		/// Creates a new storage component
		/// </summary>
		/// <param name="account"></param>
		public PersonalStorageComponent(Character character) : base(character)
		{
			_storageItems = new Item[_maxStorage];
		}

		/// <summary>
		/// Adds an item to storage and removes from character's
		/// inventory.
		/// </summary>
		/// <param name="worldId">Object id of the item</param>
		/// <param name="amount">Amount to remove</param>
		/// <returns></returns>
		public StorageResult StoreItem(long worldId, int amount = 1)
		{
			if (CheckStorageFull())
				return StorageResult.StorageFull;

			var item = this.Character.Inventory.GetItem(worldId);
			if (item == null)
				return StorageResult.ItemNotFound;

			Item itemToStore = new Item(item);
			itemToStore.Amount = Math.Min(itemToStore.Amount, amount);

			// Add item to storage and remove from character
			// Note: Changing order of packets in this condition causes
			// client to crash.
			if (this.Add(itemToStore, out var addedPosition, out var addedAmount) == StorageResult.Success)
			{
				// Show item in storage for client
				// Note: For unknown reasons, storing items is a "New" transaction
				Send.ZC_ITEM_ADD(this.Character, itemToStore, addedPosition, itemToStore.Amount, InventoryAddType.New, InventoryType.Warehouse);

				if (this.Character.Inventory.Remove(item, addedAmount, InventoryItemRemoveMsg.Given) != InventoryResult.Success)
					Log.Error($"PersonalStorage: Could not remove item '{item.ObjectId}' from character '{this.Character.Name}' inventory.");
					
			}

			return StorageResult.Success;
		}

		/// <summary>
		/// Removes an item from storage and places in character's
		/// inventory.
		/// </summary>
		/// <param name="worldId">Object id of the item</param>
		/// <param name="amount">Amount to remove</param>
		/// <returns></returns>
		public StorageResult RetrieveItem(long worldId, int amount = 1)
		{
			// Checks item is in storage
			var result = this.TryGetItem(worldId, out var item, out var removedPosition);
			if (result != StorageResult.Success)
				return result;

			Item itemToRetrieve = new Item(item);

			// Remove item from storage and add to character
			// Note: Changing order of packets in this condition causes
			// client to crash.
			if (this.Remove(item, amount, out removedPosition, out var removedAmount) == StorageResult.Success)
			{
				// Add to player inventory
				itemToRetrieve.Amount = removedAmount;
				this.Character.Inventory.Add(itemToRetrieve, InventoryAddType.New);

				// Show item removal in storage for client
				// Note: For unknown reasons, retrieving item is a "Sold" transaction
				Send.ZC_ITEM_REMOVE(this.Character, item.ObjectId, removedAmount, InventoryItemRemoveMsg.Sold, InventoryType.Warehouse);	
			}
			else
			{
				return StorageResult.InvalidOperation;
			}

			return StorageResult.Success;
		}

		/// <summary>
		/// Adds a new item to the storage.
		/// Does nothing if storage is full.
		/// Does not update client.
		/// </summary>
		/// <param name="item">Item to add</param>
		/// <param name="addedPosition">Position in storage it was added to. Defaults to -1</param>
		/// <param name="addedAmount">Amount that was added. Defaults to 0</param>
		/// <returns></returns>
		public StorageResult Add(Item item, out int addedPosition, out int addedAmount)
		{
			addedPosition = -1;
			addedAmount = 0;

			if (CheckStorageFull())
				return StorageResult.StorageFull;

			// Stacks to existing items
			if (item.IsStackable)
			{
				lock (_syncLock)
				{
					for (int i = 0; i < _maxStorage; i++)
					{
						if ((_storageItems[i] != null) && _storageItems[i].IsStackable && (_storageItems[i].Data.ClassName == item.Data.ClassName))
						{
							addedPosition = i;
							addedAmount += this.AddItemStack(_storageItems[i], item.Amount);
							if (addedAmount == item.Amount)
							{
								return StorageResult.Success;
							}
							else
							{
								// Update this item and continue stacking
								Send.ZC_ITEM_ADD(this.Character, _storageItems[i], addedPosition, _storageItems[i].Amount, InventoryAddType.New, InventoryType.Warehouse);
							}
						}
					}
				}

				// Residue
				item.Amount -= addedAmount;
			}

			// Add to new position
			if ((item.Amount - addedAmount) > 0)
			{
				var availablePosition = this.FindAvailablePosition();
				var result = this.Add(item, availablePosition, out var newAddedAmount);
				addedAmount += newAddedAmount;
				addedPosition = availablePosition;
				return result;
			}

			return StorageResult.InvalidOperation;
		}

		/// <summary>
		/// Adds a new item to the storage in specific position.
		/// Does not update client.
		/// </summary>
		/// <param name="item">Item to add</param>
		/// <param name="position">Position of item in storage.</param>
		/// <param name="addedAmount">Amount that was added. Defaults to 0</param>
		/// <returns></returns>
		public StorageResult Add(Item item, int position, out int addedAmount)
		{
			addedAmount = 0;

			if ((position < 0) || (position >= _maxStorage))
				return StorageResult.InvalidOperation;

			var existingItem = this.TryGetItemPosition(position);
			if (existingItem == null)
			{
				// Adds item
				lock (_syncLock)
				{
					_storageItems[position] = item;
					_occupiedPositions += 1;
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

			var result = this.TryGetItem(item.ObjectId, out item, out removedPosition);
			if (result != StorageResult.Success)
				return result;

			// If the item is stackable, handle the reduction of the stack
			if (item.IsStackable)
			{
				lock (_syncLock)
					removedAmount = RemoveItemStack(item, amount, removedPosition);
			}
			else
			{
				lock (_syncLock)
				{
					_storageItems[removedPosition] = null;
					_occupiedPositions -= 1;
					removedAmount = 1;
				}
			}
			return StorageResult.Success;
		}

		/// <summary>
		/// Returns true if storage is full.
		/// </summary>
		/// <returns></returns>
		public bool CheckStorageFull()
		{
			lock (_syncLock)
				return _occupiedPositions == _maxStorage;
		}

		/// <summary>
		/// Returns a dictionary of items in each position
		/// of storage.
		/// </summary>
		/// <returns></returns>
		public Dictionary<int, Item> GetStorage()
		{
			lock (_syncLock)
			{
				// Filter out null items and create a dictionary
				var storageDictionary = _storageItems
					.Select((item, index) => new { Item = item, Index = index })
					.Where(itemData => itemData.Item != null)
					.ToDictionary(itemData => itemData.Index, itemData => itemData.Item);

				return storageDictionary;
			}
		}

		/// <summary>
		/// Returns specific item, or null if it doesn't exist.
		/// </summary>
		/// <param name="worldId">Item object id</param>
		/// <param name="item">Item found</param>
		/// <param name="position">Position of item found in storage</param>
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
			}

			return StorageResult.ItemNotFound;
		}

		/// <summary>
		/// Returns specific item in position, or null
		/// if it doesn't exist.
		/// </summary>
		/// <param name="position"></param>
		/// <returns></returns>
		public Item TryGetItemPosition(int position)
		{
			lock (_syncLock)
				return _storageItems[position];
		}

		/// <summary>
		/// Swaps the two items with each other.
		/// </summary>
		/// <param name="worldId1">Item1 object id</param>
		/// <param name="worldId2">Item2 object id</param>
		/// <returns></returns>
		public StorageResult Swap(long worldId1, long worldId2)
		{
			var result1 = this.TryGetItem(worldId1, out var item1, out var position1);
			var result2 = this.TryGetItem(worldId1, out var item2, out var position2);

			if (result1 != StorageResult.Success)
				return result1;

			if (result2 != StorageResult.Success)
				return result2;

			if (item1.Data.Category != item2.Data.Category)
				return StorageResult.InvalidOperation;

			var category = item1.Data.Category;

			lock (_syncLock)
			{
				_storageItems[position1] = item2;
				_storageItems[position2] = item1;
			}

			return StorageResult.Success;
		}
	}
}
