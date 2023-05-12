using System;
using Melia.Shared.Const;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data.JSON;

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
	/// Inventory category database, indexed by the category type.
	/// </summary>
	public class InvBaseIdDb : DatabaseJsonIndexed<InventoryCategory, InvBaseIdData>
	{
		/// <summary>
		/// Reads given entry and adds it to the database.
		/// </summary>
		/// <param name="entry"></param>
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("id", "baseId", "name");

			var data = new InvBaseIdData();

			data.Id = entry.ReadInt("id");
			data.BaseId = entry.ReadInt("baseId");
			data.Type = entry.ReadEnum<InventoryCategory>("name");

			this.AddOrReplace(data.Type, data);
		}
	}
}
