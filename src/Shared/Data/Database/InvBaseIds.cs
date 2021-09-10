using System;
using Melia.Shared.Const;
using Newtonsoft.Json.Linq;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class InvBaseIdData
	{
		public int Id { get; set; }
		public int BaseId { get; set; }
		public InventoryCategory Type { get; set; }
	}

	/// <summary>
	/// Help database indexed by the help id.
	/// </summary>
	public class InvBaseIdDb : DatabaseJsonIndexed<InventoryCategory, InvBaseIdData>
	{
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("id", "baseId", "name");

			var data = new InvBaseIdData();

			data.Id = entry.ReadInt("id");
			data.BaseId = entry.ReadInt("baseId");
			data.Type = entry.ReadEnum<InventoryCategory>("name");

			this.Entries.Add(data.Type, data);
		}
	}
}
