using System;
using System.Collections.Generic;
using Melia.Shared.Const;
using Newtonsoft.Json.Linq;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class FactionData
	{
		public FactionType Id { get; set; }
		public string Name { get; set; }
		public HashSet<FactionType> Hostile { get; set; } = new HashSet<FactionType>();
	}

	public class FactionDb : DatabaseJsonIndexed<FactionType, FactionData>
	{
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

			this.Entries[data.Id] = data;
		}
	}
}
