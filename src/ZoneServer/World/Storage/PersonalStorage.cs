using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
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
		private int _defaultStorageSize = 60;

		/// <summary>
		/// Character that owns this personal storage.
		/// </summary>
		public Character Owner { get; private set; }

		/// <summary>
		/// Whether the owner is currently browsing this storage.
		/// </summary>
		public bool IsBrowsing { get; private set; }

		/// <summary>
		/// Attempts to remove the extend storage cost from character.
		/// </summary>
		/// <param name="character">Character to check</param>
		/// <param name="size">Size to expand</param>
		/// <returns>True if successful</returns>
		private bool TryRemoveExtendStorageCost(Character character, int size)
		{
			var accountProperties = character.Connection.Account.Properties;
			var medals = accountProperties.GetFloat(PropertyName.Medal);
			var medalCost = 20;

			if (medals < medalCost)
				return false;

			accountProperties.Modify(PropertyName.Medal, -medalCost);
			return true;
		}

		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="owner"></param>
		public PersonalStorage(Character owner) : base()
		{
			this.Owner = owner;
			this.AddSize(_defaultStorageSize);
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
		public override StorageResult StoreItem(long objectId, int amount = 1)
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
		public override StorageResult RetrieveItem(long objectId, int amount = 1)
		{
			return this.RetrieveItem(this.Owner, objectId, amount, InventoryType.Warehouse);
		}

		/// <summary>
		/// Checks if owner can extend storage by given size
		/// and removes TP from owner.
		/// Updates client for owner.
		/// </summary>
		/// <param name="size"></param>
		/// <returns></returns>
		public StorageResult TryExtendStorage(int size)
		{
			var character = this.Owner.Connection.SelectedCharacter;
			if (TryRemoveExtendStorageCost(character, size))
			{
				this.AddSize(size);
				this.Owner.Properties.Modify(PropertyName.MaxWarehouseCount, size);
				Send.ZC_NORMAL.AccountProperties(character);
				Send.ZC_ADDON_MSG(character, "WAREHOUSE_ITEM_LIST", 0, null);
				Send.ZC_ADDON_MSG(character, "ACCOUNT_UPDATE", 0, null);
				return StorageResult.Success;
			}

			return StorageResult.InvalidOperation;
		}
	}
}
