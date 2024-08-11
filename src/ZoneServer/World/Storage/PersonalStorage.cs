using System;
using Melia.Shared.Game.Const;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.World.Storage
{
	/// <summary>
	/// Personal storage of a single character.
	/// </summary>
	public class PersonalStorage : Storage
	{
		public const int DefaultSize = 60;
		public const int ExtensionSize = 10;

		/// <summary>
		/// Character that owns this personal storage.
		/// </summary>
		public Character Owner { get; private set; }

		/// <summary>
		/// Whether the owner is currently browsing this storage.
		/// </summary>
		public bool IsBrowsing { get; private set; }

		/// <summary>
		/// Creates new personal storage.
		/// </summary>
		/// <param name="owner"></param>
		public PersonalStorage(Character owner) : base()
		{
			this.Owner = owner;
			this.SetStorageSize(DefaultSize);
		}

		/// <summary>
		/// Opens storage.
		/// Updates client for owner.
		/// </summary>
		/// <returns></returns>
		public override StorageResult Open()
		{
			this.IsBrowsing = true;
			Send.ZC_CUSTOM_DIALOG(this.Owner, "warehouse", "");

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
			return this.StoreItem(this.Owner, objectId, amount, InventoryType.Warehouse);
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
			return this.RetrieveItem(this.Owner, objectId, amount, InventoryType.Warehouse);
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

			var curSize = this.GetStorageSize();
			var newSize = curSize + addSize;

			var extCost = this.GetExtensionCost(newSize);

			if (!account.Charge(extCost))
				return StorageResult.InvalidOperation;

			this.ModifySize(addSize);
			this.Owner.Etc.Properties.Modify(PropertyName.MaxWarehouseCount, addSize);

			Send.ZC_NORMAL.AccountProperties(character);
			Send.ZC_OBJECT_PROPERTY(character.Connection, character.Etc);

			Send.ZC_ADDON_MSG(character, "WAREHOUSE_ITEM_LIST", 0, null);
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
			// The price increases as the number of total rows increases
			var addSize = newSize - DefaultSize;
			var addRows = addSize / ExtensionSize;

			var baseCost = ZoneServer.Instance.Conf.World.StorageExtCost;
			var cost = (int)Math.Pow(baseCost / 10f, addRows) * 10;

			return cost;
		}
	}
}
