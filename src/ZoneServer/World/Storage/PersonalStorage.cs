using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Tos.Const;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Items;
using Melia.Zone.Network;
using Melia.Zone.Database;
using Melia.Zone.World.Actors.Characters.Components;

namespace Melia.Zone.World.Storage
{
	/// <summary>
	/// Personal storage of a single character.
	/// </summary>
	public class PersonalStorage : Storage
	{
		public Character Owner { get; private set; }

		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="owner"></param>
		public PersonalStorage(Character owner) : base()
		{
			this.Owner = owner;
		}

		/// <summary>
		/// Adds an item to storage and removes from owner.
		/// </summary>
		/// <param name="objectId">Object id of the item</param>
		/// <param name="amount">Amount to remove</param>
		/// <returns></returns>
		public override StorageResult StoreItem(long objectId, int amount = 1)
		{
			var item = this.Owner.Inventory.GetItem(objectId);
			if (item == null)
				return StorageResult.ItemNotFound;

			Item itemToStore = new Item(item);
			itemToStore.Amount = Math.Min(itemToStore.Amount, amount);

			// For stackable items, finds existing storage items.
			var existingStorageItems = new SortedList<int, Item>();
			if (itemToStore.IsStackable)
			{
				this.TryFindStackableItems(itemToStore, out existingStorageItems);

				// No existing items to stack to and no free positions
				if ((existingStorageItems.Count == 0) && this.CheckStorageFull())
					return StorageResult.StorageFull;

				if (existingStorageItems.Count > 0)
				{
					var stackAvailableAmount = existingStorageItems.Values.Sum(existingItem => existingItem.Data.MaxStack - existingItem.Amount);

					if (this.CheckStorageFull())
					{
						// Storage has no free positions and existing items can no longer stack
						if (stackAvailableAmount == 0)
							return StorageResult.StorageFull;

						itemToStore.Amount = Math.Min(itemToStore.Amount, stackAvailableAmount);
					}
					if (!Feature.IsEnabled("StorageMultiStack"))
					{
						// Multistacking is not enabled, we can only store to already existing stacks
						if (stackAvailableAmount == 0)
							return StorageResult.StorageFull;

						itemToStore.Amount = Math.Min(itemToStore.Amount, stackAvailableAmount);
					}
				}
			}

			// We checked storage full for stackable items earlier,
			// now we check for non-stackable items.
			if (CheckStorageFull() && !item.IsStackable)
			{
				return StorageResult.StorageFull;
			}

			// Remove the amount from character
			var inventoryResult = this.Owner.Inventory.Remove(item, itemToStore.Amount, InventoryItemRemoveMsg.Given);
			if (inventoryResult != InventoryResult.Success)
				return StorageResult.InvalidOperation;

			// For stackable items, add item to existing stacks.
			if (itemToStore.IsStackable)
			{
				var addedAmount = 0;
				foreach (var existingStorageItem in existingStorageItems)
				{
					var stackedAmount = this.AddItemStack(existingStorageItem.Value, itemToStore.Amount - addedAmount);
					addedAmount += stackedAmount;
					if (stackedAmount > 0)
					{
						Send.ZC_ITEM_ADD(this.Owner, existingStorageItem.Value, existingStorageItem.Key, stackedAmount, InventoryAddType.New, InventoryType.Warehouse);
					}
				}
				if ((itemToStore.Amount - addedAmount) == 0)
				{
					return StorageResult.Success;
				}

				// Residue
				itemToStore.Amount -= addedAmount;
			}

			// Adds item to new position
			var storageResult = this.Add(itemToStore, out var addedPosition);
			if (storageResult != StorageResult.Success)
				return storageResult;
			Send.ZC_ITEM_ADD(this.Owner, itemToStore, addedPosition, itemToStore.Amount, InventoryAddType.New, InventoryType.Warehouse);

			return StorageResult.Success;
		}

		/// <summary>
		/// Removes an item from storage and gives to owner.
		/// </summary>
		/// <param name="objectId">Object id of the item</param>
		/// <param name="amount">Amount to remove</param>
		/// <returns></returns>
		public override StorageResult RetrieveItem(long objectId, int amount = 1)
		{
			// Checks item is in storage
			var result = this.TryGetItem(objectId, out var item, out var removedPosition);
			if (result != StorageResult.Success)
				return result;

			Item itemToRetrieve = new Item(item);

			// Remove item from storage
			var storageResult = this.Remove(item, amount, out removedPosition, out var removedAmount);
			if (storageResult != StorageResult.Success)
				return storageResult;

			// Add to player inventory
			itemToRetrieve.Amount = removedAmount;
			this.Owner.Inventory.Add(itemToRetrieve, InventoryAddType.New);
			Send.ZC_ITEM_REMOVE(this.Owner, item.ObjectId, removedAmount, InventoryItemRemoveMsg.Sold, InventoryType.Warehouse);

			return StorageResult.Success;
		}
	}
}
