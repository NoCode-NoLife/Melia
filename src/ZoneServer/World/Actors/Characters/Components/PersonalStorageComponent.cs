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

namespace Melia.Zone.World.Actors.Characters.Components
{
	/// <summary>
	/// Represents the storage component
	/// </summary>
	public class PersonalStorageComponent : CharacterComponent
	{
		private readonly object _syncLock = new object();

		// Items in storage
		// Key: Item's object ID
		// Value: Item Storage object
		private Dictionary<long, StorageItem> _storageItems = new Dictionary<long, StorageItem>();

		// Storage occupied positions.
		// True if position is occupied
		private bool[] _occupiedPositions = new bool[60];

		// How many positions the storage has.
		private int _maxStorage = 60;

		/// <summary>
		/// Gets the first available position in storage
		/// </summary>
		private int FindAvailablePosition()
		{
			for (int i = 0; i < _occupiedPositions.Length; i++)
			{
				if (!_occupiedPositions[i])
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

		}

		/// <summary>
		/// Stores an item to storage. The item is identified by its
		/// object id.
		/// </summary>
		/// <param name="objectId"></param>
		/// <returns></returns>
		public StorageResult StoreItem(long objectId)
		{
			if (_storageItems.Count() < _maxStorage)
			{
				lock (_syncLock)
				{
					// Checks item is in inventory
					var item = this.Character.Inventory.GetItem(objectId);
					if (item == null || item is DummyEquipItem)
						return StorageResult.ItemNotFound;

					// Remove from player inventory
					// Note: Storages are like stores, so this is a sell transaction
					this.Character.Inventory.Remove(item.ObjectId);

					// Adds to storage
					var availablePosition = this.FindAvailablePosition();
					this.Add(item, availablePosition);

					// Add item to storage in client
					Send.ZC_ITEM_ADD(this.Character, item, availablePosition, item.Amount, InventoryAddType.Sell, InventoryType.Warehouse);
				}

				return StorageResult.Success;
			}
			else
			{
				// Storage is full
				return StorageResult.InvalidOperation;
			}
		}

		/// <summary>
		/// Removes an item from storage and places in character's
		/// inventory. The item is identified by its object id.
		/// </summary>
		/// <returns></returns>
		public StorageResult RetrieveItem(long objectId)
		{
			Item item;
			lock (_syncLock)
			{
				// Checks item is in storage
				item = this.GetItem(objectId).Item;
				if (item == null || item is DummyEquipItem)
					return StorageResult.ItemNotFound;

				// Add to player inventory
				this.Character.Inventory.Add(item, InventoryAddType.New);

				// Remove from storage
				this.Remove(item);
				
				// Remove item from storage in client
				Send.ZC_ITEM_REMOVE(this.Character, objectId, item.Amount, InventoryItemRemoveMsg.Sold, InventoryType.Warehouse);
			}

			return StorageResult.Success;
		}

		/// <summary>
		/// Adds a new item to the storage.
		/// </summary>
		/// <param name="item"></param>
		/// <param name="position"></param>
		public void Add(Item item, int position)
		{
			// Handles item stacking
			if (_storageItems.TryGetValue(item.ObjectId, out var storageItem))
			{
				if ((storageItem.Item.Amount + item.Amount) < storageItem.Item.Data.MaxStack)
					storageItem.Item.Amount += item.Amount;

				return;
			}

			_occupiedPositions[position] = true;
			_storageItems.Add(item.ObjectId, new StorageItem(item, position));
		}

		/// <summary>
		/// Removes an item from storage.
		/// </summary>
		/// <param name="item"></param>
		/// <exception cref="ArgumentException"></exception>
		public void Remove(Item item)
		{
			if (!_storageItems.TryGetValue(item.ObjectId, out var storageItem))
				throw new ArgumentException($"PersonalStorageComponent.Remove: Item {item.ObjectId} not found in storage items.");
			_occupiedPositions[storageItem.Position] = false;
			_storageItems.Remove(item.ObjectId);
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
		/// <param name="objectId"></param>
		/// <returns></returns>
		public StorageItem GetItem(long objectId)
		{
			lock (_syncLock)
			{
				if (_storageItems.TryGetValue(objectId, out var item))
				{
					return item;
				}
				else
				{
					return null;
				}
			}
		}
	}
}
