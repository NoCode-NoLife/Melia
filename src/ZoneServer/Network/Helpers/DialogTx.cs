using Melia.Shared.Network;

namespace Melia.Zone.Network.Helpers
{
	/// <summary>
	/// Helper class for reading CZ_DIALOG_TX.
	/// </summary>
	public static class DialogTxHelper
	{
		/// <summary>
		/// Reads an item from the packet and returns it.
		/// </summary>
		/// <param name="packet"></param>
		/// <returns></returns>
		public static DialogTxItem GetDialogTxItem(this Packet packet)
		{
			var result = new DialogTxItem();

			result.ItemObjectId = packet.GetLong();
			result.Amount = packet.GetInt();
			result.ItemClassId = packet.GetInt();

			return result;
		}
	}

	public class DialogTxItem
	{
		public long ItemObjectId;
		public int ItemClassId;
		public int Amount;
	}
}
