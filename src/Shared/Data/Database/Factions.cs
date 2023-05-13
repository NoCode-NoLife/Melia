using System;
using System.Collections.Generic;
using Melia.Shared.Tos.Const;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data.JSON;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class FactionData
	{
		public FactionType Id { get; set; }
		public string Name { get; set; }
		public HashSet<FactionType> Hostile { get; set; } = new HashSet<FactionType>();
	}

	/// <summary>
	/// Faction database, indexed by their types.
	/// </summary>
	public class FactionDb : DatabaseJsonIndexed<FactionType, FactionData>
	{
		/// <summary>
		/// Returns true if faction 1 is hostile towards faction 2.
		/// </summary>
		/// <param name="faction1"></param>
		/// <param name="faction2"></param>
		/// <returns></returns>
		public bool CheckHostility(FactionType faction1, FactionType faction2)
		{
			if (!this.TryFind(faction1, out var data))
				return false;

			return data.Hostile.Contains(faction2);
		}

		/// <summary>
		/// Reads given entry and adds it to the database.
		/// </summary>
		/// <param name="entry"></param>
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("id", "name");

			var data = new FactionData();

			data.Id = entry.ReadEnum<FactionType>("id");
			data.Name = entry.ReadString("name");

			if (entry.ContainsKey("hostile"))
			{
				foreach (string factionName in entry["hostile"])
					data.Hostile.Add((FactionType)Enum.Parse(typeof(FactionType), factionName));
			}

			this.AddOrReplace(data.Id, data);
		}
	}
}
