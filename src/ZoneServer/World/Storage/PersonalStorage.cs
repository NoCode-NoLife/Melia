using System;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Shared.ObjectProperties;
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
			this.Owner.CurrentStorage = this;

			Send.ZC_CUSTOM_DIALOG(this.Owner, "warehouse", "");

			// Send a property update for the storage size and redraw the slots,
			// so the client shows the correct number for this potentially custom
			// storage.
			var properties = new Properties("PCEtc");
			properties.SetFloat(PropertyName.MaxWarehouseCount, this.GetStorageSize());
			Send.ZC_OBJECT_PROPERTY(this.Owner.Connection, this.Owner.SocialUserId, properties.GetAll());

			Task.Delay(100).ContinueWith(_ =>
			{
				Send.ZC_EXEC_CLIENT_SCP(this.Owner.Connection, @"
					local frame = ui.GetFrame('warehouse')
					local gbox = frame:GetChild('gbox')
					local slotset = gbox:GetChild('slotset')
					AUTO_CAST(slotset)

					slotset:AutoAdjustRow()
				");
			});

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
			this.SetSavedSize(newSize);

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

		/// <summary>
		/// Initializes the size of the storage.
		/// </summary>
		public virtual void InitSize()
		{
			this.SetStorageSize(this.GetSavedSize());
		}

		/// <summary>
		/// Returns the saved size of the storage.
		/// </summary>
		/// <returns></returns>
		protected virtual int GetSavedSize()
		{
			return (int)this.Owner.Etc.Properties.GetFloat(PropertyName.MaxWarehouseCount, this.GetStorageSize());
		}

		/// <summary>
		/// Sets the saved size of the storage.
		/// </summary>
		/// <param name="size"></param>
		protected virtual void SetSavedSize(int size)
		{
			this.Owner.Etc.Properties.SetFloat(PropertyName.MaxWarehouseCount, size);
		}
	}
}
