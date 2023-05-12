using System;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data.JSON;

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
		/// <summary>
		/// Reads given entry and adds it to the database.
		/// </summary>
		/// <param name="entry"></param>
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("mapId", "price", "characters");

			var data = new BarrackData();

			data.MapId = entry.ReadInt("mapId");
			data.Price = entry.ReadInt("price");
			data.Characters = entry.ReadInt("characters");

			this.AddOrReplace(data.MapId, data);
		}
	}
}
