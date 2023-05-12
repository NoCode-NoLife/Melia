using System;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data.JSON;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class ItemMonsterData
	{
		public int ItemId { get; set; }
		public int MonsterId { get; set; }
	}

	/// <summary>
	/// Item monster database, indexed by item id.
	/// </summary>
	/// <remarks>
	/// This is a lookup database for item drops, since the items become
	/// "monsters" as drops. Officially, this data is auto-generated
	/// based on the client-data by iterating over the items and
	/// varous other databases.
	/// </remarks>
	public class ItemMonsterDb : DatabaseJsonIndexed<int, ItemMonsterData>
	{
		/// <summary>
		/// Reads given entry and adds it to the database.
		/// </summary>
		/// <param name="entry"></param>
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("itemId", "monsterId");

			var data = new ItemMonsterData();

			data.ItemId = entry.ReadInt("itemId");
			data.MonsterId = entry.ReadInt("monsterId");

			this.AddOrReplace(data.ItemId, data);
		}
	}
}
