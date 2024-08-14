using System;
using Melia.Shared.Game.Const;
using Melia.Shared.ObjectProperties;

namespace Melia.Barracks.Database
{
	/// <summary>
	/// Represents an equipped item.
	/// </summary>
	public class EquipItem
	{
		/// <summary>
		/// Returns the item's id.
		/// </summary>
		public int Id { get; }

		/// <summary>
		/// Returns the item's equip type.
		/// </summary>
		public EquipType Type { get; }

		/// <summary>
		/// Returns the equipment slot the item sits in.
		/// </summary>
		public EquipSlot Slot { get; }

		/// <summary>
		/// Returns the item's properties.
		/// </summary>
		public Properties Properties { get; } = new Properties("Item");

		/// <summary>
		/// Creates new instance.
		/// </summary>
		public EquipItem(int itemId, EquipSlot slot)
		{
			var data = BarracksServer.Instance.Data.ItemDb.Find(itemId) ?? throw new ArgumentException($"Unknown item '{itemId}'.");

			this.Id = itemId;
			this.Type = data.EquipType1;
			this.Slot = slot;
		}
	}
}
