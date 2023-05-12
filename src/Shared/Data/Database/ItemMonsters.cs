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

	public class ItemMonsterDb : DatabaseJsonIndexed<int, ItemMonsterData>
	{
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
