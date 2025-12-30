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
		/// Creates new personal storage.
		/// </summary>
		/// <param name="owner"></param>
		public PersonalStorage(Character owner) : base()
		{
			this.Owner = owner;
			this.SetStorageSize(ZoneServer.Instance.Conf.World.StorageDefaultSize);
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

			// Here we would have refresh the storage window's slots,
			// to adjust them to the size of the current storage.
			// See InitSize below for more information.

			Send.ZC_CUSTOM_DIALOG(this.Owner, "warehouse");

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
			return this.StoreItem(this.Owner, objectId, amount, InventoryType.PersonalStorage);
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
			return this.RetrieveItem(this.Owner, objectId, amount, InventoryType.PersonalStorage);
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

			// Sanity check, the client shouldn't let us get to this point
			if (newSize > ZoneServer.Instance.Conf.World.StorageMaxSize)
				return StorageResult.InvalidOperation;

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
			var cost = ZoneServer.Instance.Conf.World.StorageExtCost;
			var addSize = newSize - DefaultSize;

			// The price increases as the number of total rows increases,
			// but the client hardcodes a default size of 60. This means
			// we might get a negative add size if one were to configure
			// a storage size < 60. In that case the client will show
			// the default cost as the price, and we'll match that.
			if (addSize > 0)
			{
				var addRows = addSize / ExtensionSize;
				cost = (int)Math.Pow(cost / 10f, addRows) * 10;
			}

			return cost;
		}

		/// <summary>
		/// Initializes the size of the storage.
		/// </summary>
		public virtual void InitSize()
		{
			// My hope was that we would be able to adjust the size of the
			// storage dynamically, so we could have arbitrary storages of
			// various sizes that we can access through the personal storage
			// system. You might have a guild storage, or chests, etc. However,
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
			var size = (int)this.Owner.Etc.Properties.GetFloat(PropertyName.MaxWarehouseCount, this.GetStorageSize());

			// Upgrade sizes of storages that were created/extended when there
			// was a lower default.
			if (size < ZoneServer.Instance.Conf.World.StorageDefaultSize)
			{
				size = ZoneServer.Instance.Conf.World.StorageDefaultSize;
				this.SetSavedSize(size);
			}

			return size;
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
