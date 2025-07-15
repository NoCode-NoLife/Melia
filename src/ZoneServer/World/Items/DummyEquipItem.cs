using Melia.Shared.Game.Const;

namespace Melia.Zone.World.Items
{
	/// <summary>
	/// A dummy item used in empty equipment slots.
	/// </summary>
	/// <remarks>
	/// Useful because equipment slots are never truly empty. Even if
	/// no item is equipped, a dummy item with a class id and a zeroed
	/// object id is still present.
	/// </remarks>
	public class DummyEquipItem : Item
	{
		/// <summary>
		/// Returns an empty object id.
		/// </summary>
		/// <remarks>
		/// Officials set the object id of dummy items to 0, though
		/// whether this is actually necessary is currently unknown.
		/// This does affect packet structures however.
		/// </remarks>
		public override long ObjectId => 0;

		/// <summary>
		/// Creates new dummy item.
		/// </summary>
		/// <param name="slot"></param>
		public DummyEquipItem(EquipSlot slot) : base(InventoryDefaults.EquipItems[(int)slot], 1)
		{
		}

		/// <summary>
		/// Called to load the item's default properties based on its data.
		/// </summary>
		protected override void LoadDataProperties()
		{
			// Don't load any data or properties for dummy items, as the client
			// tends to dislike it when dummy items have properties.
		}
	}
}
