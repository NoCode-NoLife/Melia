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
		public DummyEquipItem(EquipSlot slot) : base(Melia.Shared.Game.Const.InventoryDefaults.EquipItems[(int)slot], 1)
		{
		}
	}
}
