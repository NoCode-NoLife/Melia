using System;
using System.Collections.Generic;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Items;

namespace Melia.Zone.World.Storage
{
	/// <summary>
	/// Team storage of an account.
	/// </summary>
	public class TeamStorage : Storage
	{
		private int _silver;
		private readonly int _silverMax;
		private readonly Queue<StorageSilverTransaction> _silverTransactions;
		// This is necessary because the client identifies the
		// silver in storage by its objectId
		private readonly Item _silverDummyItem;
		private readonly int _maxSilverTransactions = 5; // Client limit
		private readonly object _silverLock = new(); // Lock for silver operations

		public const int DefaultSize = 5;
		public const int ExtensionSize = 1;

		/// <summary>
		/// Returns the silver transactions in this storage.
		/// Returns null if no transactions were made.
		/// </summary>
		/// <returns></returns>
		public StorageSilverTransaction[] GetSilverTransactions()
		{
			lock (_silverLock)
			{
				return _silverTransactions.ToArray();
			}
		}

		/// <summary>
		/// Character that owns this team storage.
		/// </summary>
		public Character Owner { get; private set; }

		/// <summary>
		/// Creates new team storage.
		/// </summary>
		/// <param name="owner"></param>
		public TeamStorage(Character owner) : base()
		{
			this.Owner = owner;
			this.SetStorageSize(DefaultSize);

			_silverDummyItem = new Item(ItemId.Silver);
			_silverMax = _silverDummyItem.Data.MaxStack;
			_silverTransactions = new Queue<StorageSilverTransaction>();
		}

		/// <summary>
		/// Opens storage.
		/// Updates client for owner.
		/// </summary>
		/// <returns></returns>
		public override StorageResult Open()
		{
			var minLevel = ZoneServer.Instance.Conf.World.TeamStorageMinimumLevelRequired;

			// Check if character meets the minimum level requirement
			if (this.Owner.Level < minLevel)
			{
				this.Owner.ServerMessage(Localization.Get("You must be at least level {0} to access team storage."), minLevel);
				return StorageResult.InvalidOperation;
			}

			this.IsBrowsing = true;
			this.Owner.CurrentStorage = this;

			Send.ZC_CUSTOM_DIALOG(this.Owner, "accountwarehouse", "");

			return StorageResult.Success;
		}

		/// <summary>
		/// Closes storage.
		/// Updates client for owner.
		/// </summary>
		/// <returns></returns>
		public override StorageResult Close()
		{
			this.IsBrowsing = false;
			this.Owner.CurrentStorage = null;

			Send.ZC_DIALOG_CLOSE(this.Owner.Connection);

			return StorageResult.Success;
		}

		/// <summary>
		/// Adds an item to storage.
		/// Updates client for owner.
		/// </summary>
		/// <param name="objectId"></param>
		/// <param name="amount"></param>
		/// <returns></returns>
		public override StorageResult StoreItem(long objectId, int amount)
		{
			return this.StoreItem(this.Owner, objectId, amount, InventoryType.TeamStorage);
		}

		/// <summary>
		/// Retrieves an item from storage.
		/// Updates client for owner.
		/// </summary>
		/// <param name="objectId"></param>
		/// <param name="amount"></param>
		/// <returns></returns>
		public override StorageResult RetrieveItem(long objectId, int amount)
		{
			return this.RetrieveItem(this.Owner, objectId, amount, InventoryType.TeamStorage);
		}

		/// <summary>
		/// Returns the silver item or null
		/// if no silver exists
		/// </summary>
		/// <returns></returns>
		public Item GetSilver()
		{
			lock (_silverLock)
			{
				if (_silver <= 0)
					return null;

				if (_silverDummyItem == null)
					return null;

				// Return the dummy item with updated amount
				// We lock to ensure thread safety when modifying Amount
				_silverDummyItem.Amount = _silver;
				return _silverDummyItem;
			}
		}

		/// <summary>
		/// Sets the silver in storage
		/// </summary>
		public void SetSilver(int amount)
		{
			lock (_silverLock)
			{
				_silver = Math.Min(_silverMax, amount);
			}
			this.AddSilverTransaction(StorageInteraction.Store, amount);
		}

		/// <summary>
		/// Adds a silver transaction to this storage.
		/// If number of transactions exceed the max, deletes older transactions.
		/// Does not update client.
		/// </summary>
		/// <param name="interaction">Retrieve or Store interaction</param>
		/// <param name="silverTransacted">Amount of silver</param>
		/// <param name="silverTotal">If not provided will automatically update total</param>
		/// <param name="fileTime">If not provided will be set to current time</param>
		/// <returns></returns>
		public StorageResult AddSilverTransaction(StorageInteraction interaction, int silverTransacted, int silverTotal = -1, long fileTime = -1)
		{
			if ((silverTotal < -1) || (fileTime < -1))
				return StorageResult.InvalidOperation;

			if ((interaction != StorageInteraction.Store) && (interaction != StorageInteraction.Retrieve))
				return StorageResult.InvalidOperation;

			lock (_silverLock)
			{
				// Adds transaction
				var transaction = new StorageSilverTransaction();
				transaction.Interaction = interaction;
				transaction.SilverTransacted = silverTransacted;
				transaction.SilverTotal = silverTotal != -1 ? silverTotal : _silver;
				_silverTransactions.Enqueue(transaction);

				if (_silverTransactions.Count > _maxSilverTransactions)
				{
					_silverTransactions.Dequeue();
				}
			}

			return StorageResult.Success;
		}

		/// <summary>
		/// Stores silver to storage.
		/// Updates client for owner.
		/// </summary>
		/// <param name="amount"></param>
		/// <returns></returns>
		public StorageResult StoreSilver(int amount)
		{
			return this.StoreSilver(this.Owner.Connection.SelectedCharacter, amount, InventoryType.TeamStorage);
		}

		/// <summary>
		/// Retrieves silver from storage.
		/// Updates client for owner.
		/// </summary>
		/// <param name="amount"></param>
		/// <returns></returns>
		public StorageResult RetrieveSilver(int amount)
		{
			return this.RetrieveSilver(this.Owner.Connection.SelectedCharacter, amount, InventoryType.TeamStorage);
		}

		/// <summary>
		/// Extends the storage by the given size. The operation may fail if
		/// the owner does not have enough TP.
		/// </summary>
		/// <param name="addSize"></param>
		/// <returns></returns>
		public StorageResult TryExtendStorage(int addSize)
		{
			var account = this.Owner.Connection.Account;
			var character = this.Owner.Connection.SelectedCharacter;

			// Check if player has reached the maximum number of silver expansions
			var currentExtensions = (int)account.Properties.GetFloat(PropertyName.AccountWareHouseExtend, 0);
			var maxSilverExpands = ZoneServer.Instance.Conf.World.TeamStorageMaxSilverExpands;

			if (currentExtensions >= maxSilverExpands)
			{
				character.ServerMessage(Localization.Get("You have reached the maximum number of silver expansions ({0}). Use other methods to expand further."), maxSilverExpands);
				return StorageResult.InvalidOperation;
			}

			var curSize = this.GetStorageSize();
			var newSize = curSize + addSize;

			var extCost = this.GetExtensionCost(newSize);

			if (!character.HasSilver(extCost, silently: false))
				return StorageResult.InvalidOperation;

			if (curSize >= ZoneServer.Instance.Conf.World.TeamStorageMaxSize)
				return StorageResult.InvalidOperation;

			character.Inventory.Remove(ItemId.Silver, extCost, InventoryItemRemoveMsg.Given);
			this.ModifySize(addSize);
			account.Properties.Modify(PropertyName.AccountWareHouseExtend, addSize);

			// Send updated properties to client
			Send.ZC_NORMAL.AccountProperties(character, PropertyName.AccountWareHouseExtend, PropertyName.BasicAccountWarehouseSlotCount);

			Send.ZC_ADDON_MSG(character, "ACCOUNT_WAREHOUSE_ITEM_LIST", 0, null);
			Send.ZC_ADDON_MSG(character, "ACCOUNT_UPDATE", 0, null);

			return StorageResult.Success;
		}

		/// <summary>
		/// Returns the cost of extending the storage to the given size.
		/// </summary>
		/// <param name="newSize"></param>
		/// <returns></returns>
		private int GetExtensionCost(int newSize)
		{
			var account = this.Owner.Connection.Account;
			var baseCost = ZoneServer.Instance.Conf.World.TeamStorageExtCost;

			// Get the number of extensions already purchased
			var currentExtensions = (int)account.Properties.GetFloat(PropertyName.AccountWareHouseExtend, 0);

			// Cost doubles with each expansion
			// 1st expansion (currentExtensions = 0): baseCost * 2^0 = 200k
			// 2nd expansion (currentExtensions = 1): baseCost * 2^1 = 400k
			// 3rd expansion (currentExtensions = 2): baseCost * 2^2 = 800k
			// 4th expansion (currentExtensions = 3): baseCost * 2^3 = 1.6m
			// 5th+ expansion: capped at 2m
			var cost = baseCost * (int)Math.Pow(2, currentExtensions);

			return Math.Min(cost, 2000000);
		}

		/// <summary>
		/// Adds an amount of silver to storage.
		/// Updates client.
		/// </summary>
		/// <param name="character">Character that is performing interaction</param>
		/// <param name="amount">Amount of silver to store</param>
		/// <param name="invType">Storage inventory type</param>
		/// <returns></returns>
		private StorageResult StoreSilver(Character character, int amount, InventoryType invType)
		{
			if (amount <= 0)
				return StorageResult.InvalidOperation;

			var inventory = character.Inventory;
			int actualAmount;
			Item silverItem;

			lock (_silverLock)
			{
				// Transaction limit
				actualAmount = Math.Min(inventory.CountItem(ItemId.Silver), amount);
				actualAmount = Math.Min(_silverMax - _silver, actualAmount);

				// Storing
				inventory.Remove(ItemId.Silver, actualAmount, InventoryItemRemoveMsg.Given);
				_silver += actualAmount;

				// Use the dummy item for packet (it has the correct ObjectId)
				// We just need to ensure its Amount is updated
				_silverDummyItem.Amount = _silver;
				silverItem = _silverDummyItem;
			}

			// This packet updates how much silver client knows there is in storage,
			// even if it is not visible in UI
			Send.ZC_ITEM_ADD(character, silverItem, 0, actualAmount, InventoryAddType.New, invType);

			// Updates transaction list
			this.AddSilverTransaction(StorageInteraction.Store, actualAmount);
			Send.ZC_NORMAL.AccountProperties(character);
			Send.ZC_NORMAL.StorageSilverTransaction(character, this.GetSilverTransactions(), false);

			return StorageResult.Success;
		}

		/// <summary>
		/// Removes an amount of silver from storage.
		/// Updates client. Thread-safe.
		/// </summary>
		/// <param name="character">Character that is performing interaction</param>
		/// <param name="amount">Amount of silver to retrieve</param>
		/// <param name="invType">Storage inventory type</param>
		/// <returns></returns>
		private StorageResult RetrieveSilver(Character character, int amount, InventoryType invType)
		{
			if (amount <= 0)
				return StorageResult.InvalidOperation;

			var inventory = character.Inventory;
			int actualAmount;
			long silverObjectId;

			lock (_silverLock)
			{
				if (_silver <= 0)
					return StorageResult.InvalidOperation;

				// Transaction limit
				actualAmount = Math.Min(_silver, amount);
				actualAmount = Math.Min(_silverMax, actualAmount);

				// Retrieving
				inventory.Add(ItemId.Silver, actualAmount, InventoryAddType.New);
				_silver -= actualAmount;

				// Get the object ID for the packet
				silverObjectId = _silverDummyItem.ObjectId;
			}

			// This packet updates how much silver client knows there is in storage,
			// even if it is not visible in UI
			Send.ZC_ITEM_REMOVE(character, silverObjectId, actualAmount, InventoryItemRemoveMsg.Given, invType);

			// Updates transaction list
			this.AddSilverTransaction(StorageInteraction.Retrieve, actualAmount);
			Send.ZC_NORMAL.AccountProperties(character);
			Send.ZC_NORMAL.StorageSilverTransaction(character, this.GetSilverTransactions(), false);

			return StorageResult.Success;
		}

		/// <summary>
		/// Gets items in this storage.
		/// Client expects silver to be in item list of team storage.
		/// </summary>
		/// <returns></returns>
		public override Dictionary<int, Item> GetItems()
		{
			var items = new Dictionary<int, Item>();

			// Get normal items at their actual positions (0 to size-1)
			var normalItems = base.GetItems();
			foreach (var kvp in normalItems)
			{
				items[kvp.Key] = kvp.Value;
			}

			// Add silver item AFTER the last storage position so it never
			// conflicts with regular items. Silver does NOT count towards
			// storage capacity.
			var silverItem = this.GetSilver();
			if (silverItem != null)
			{
				var storageSize = this.GetStorageSize();
				items[storageSize] = silverItem;
			}

			return items;
		}

		/// <summary>
		/// Initializes the size of the storage.
		/// </summary>
		public virtual void InitSize()
		{
			// My hope was that we would be able to adjust the size of the
			// storage dynamically, so we could have arbitrary storages of
			// various sizes that we can access through the personal storage
			// system. You might have a guid storage, or chests, etc. However,
			// it seems like the client is not a big fan of trying to resize
			// the storage up and down on the fly. It's inherently designed
			// for extension only, and in my attempts to force it to shrink
			// the storage, I experienced some odd behavior, such as the
			// client locking up, trying to connect to barrack servers that
			// don't exist, and refusing to launch afterwards. As such, I'm
			// going to put a pin in this for now and we'll live with all
			// storages, including custom ones, having the same size.
			// I recommend not messing with the sizing too much unless you
			// want to try to get this working.
			// -- exec

			this.SetStorageSize(this.GetSavedSize());
		}

		/// <summary>
		/// Returns the saved size of the storage.
		/// </summary>
		/// <returns></returns>
		protected virtual int GetSavedSize()
		{
			var account = this.Owner.Connection.Account;
			var defaultSize = ZoneServer.Instance.Conf.World.TeamStorageDefaultSize;

			// NOTE: The client's GetAccountWarehouseSlotCount() function adds +1 to the slot count
			// it displays (formula: BasicAccountWarehouseSlotCount + AccountWareHouseExtend + 1).
			// To make the client display the correct number of slots as configured, we need to
			// subtract 1 from the default size when setting BasicAccountWarehouseSlotCount.
			//
			// Example with team_storage_default_size = 5:
			//   Server internal storage: 5 slots (can store 5 items)
			//   BasicAccountWarehouseSlotCount: 4 (what we tell the client)
			//   Client displays: 4 + 0 + 1 = 5 slots ✓ Correct!

			// The client property needs to be defaultSize - 1
			var clientBaseSlots = Math.Max(0, defaultSize - 1);

			// Get the current BasicAccountWarehouseSlotCount property
			var currentClientSlots = (int)account.Properties.GetFloat(PropertyName.BasicAccountWarehouseSlotCount, 0);

			// If BasicAccountWarehouseSlotCount hasn't been set yet, initialize it
			if (currentClientSlots == 0)
			{
				currentClientSlots = clientBaseSlots;
				account.Properties.SetFloat(PropertyName.BasicAccountWarehouseSlotCount, clientBaseSlots);
			}

			// Get the number of extensions purchased
			var extensions = (int)account.Properties.GetFloat(PropertyName.AccountWareHouseExtend, 0);

			// Server's actual storage size = what the client WOULD show (before the +1)
			// This gives us the correct number of usable slots
			var totalSize = currentClientSlots + extensions + 1;

			// Upgrade base slots if config default has increased
			if (currentClientSlots < clientBaseSlots)
			{
				account.Properties.SetFloat(PropertyName.BasicAccountWarehouseSlotCount, clientBaseSlots);
				totalSize = clientBaseSlots + extensions + 1;
			}

			return totalSize;
		}
	}
}
