using System;
using Melia.Shared.Game.Const;

namespace Melia.Zone.World.Storage
{
	/// <summary>
	/// This class represents a silver transaction for a storage.
	/// </summary>
	public class StorageSilverTransaction
	{
		/// Storing or retrieving silver
		public StorageInteraction Interaction { get; set; }

		// Amount of silver exchanged in transaction
		public int SilverTransacted { get; set; }

		// Total amount of silver in storage
		public int SilverTotal { get; set; }

		// Time of transaction as Filetime
		public long TransactionTime { get; set; }

		/// <summary>
		/// Sets Filetime to current time
		/// </summary>
		public StorageSilverTransaction()
		{
			this.TransactionTime = DateTime.Now.Add(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now)).ToFileTime();
		}
	}
}
