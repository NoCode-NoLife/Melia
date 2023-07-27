using System;
using Yggdrasil.Network.Communication;

namespace Melia.Shared.Network.Inter.Messages
{
	/// <summary>
	/// Instruction to delete an item from player's inventory.
	/// </summary>
	[Serializable]
	public class ReqDeleteItemMessage : ICommMessage
	{
		/// <summary>
		/// Returns the unique item id to be deleted.
		/// a team or map name.
		/// </summary>
		public long ItemUniqueId { get; }

		/// <summary>
		/// Returns the amount of the item to be deleted.
		/// a team or map name.
		/// </summary>
		public int Amount { get; }

		/// <summary>
		/// Creates new delete item message.
		/// </summary>
		/// <param name="itemUniqueId"></param>
		public ReqDeleteItemMessage(long itemUniqueId, int amount)
		{
			this.ItemUniqueId = itemUniqueId;
			this.Amount = amount;
		}
	}
}
