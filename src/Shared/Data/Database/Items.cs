// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using Melia.Shared.Const;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class ItemData
	{
		public int Id { get; set; }
		public string ClassName { get; set; }
		public InventoryCategory Category { get; set; }
		public int Weight { get; set; }
		public int MaxStack { get; set; }
	}

	/// <summary>
	/// Item database, indexed by item id.
	/// </summary>
	public class ItemDb : DatabaseJsonIndexed<int, ItemData>
	{
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("itemId", "className", "category", "weight", "maxStack");

			var info = new ItemData();

			info.Id = entry.ReadInt("itemId");
			info.ClassName = entry.ReadString("className");
			info.Category = (InventoryCategory)entry.ReadInt("category");
			info.Weight = entry.ReadInt("weight");
			info.MaxStack = entry.ReadInt("maxStack");

			this.Entries[info.Id] = info;
		}
	}
}
