using System;
using Newtonsoft.Json.Linq;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class BarrackData
	{
		public int MapId { get; set; }
		public int Price { get; set; }
		public int Characters { get; set; }
	}

	/// <summary>
	/// Barrack database, indexed by map id.
	/// </summary>
	public class BarrackDb : DatabaseJsonIndexed<int, BarrackData>
	{
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("mapId", "price", "characters");

			var info = new BarrackData();

			info.MapId = entry.ReadInt("mapId");
			info.Price = entry.ReadInt("price");
			info.Characters = entry.ReadInt("characters");

			this.Entries[info.MapId] = info;
		}
	}
}
