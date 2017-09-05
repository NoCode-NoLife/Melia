// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Const;
using Newtonsoft.Json.Linq;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class ItemData
	{
		public int Id { get; set; }
		public string ClassName { get; set; }
		public string Name { get; set; }
		public InventoryCategory Category { get; set; }
		public int Weight { get; set; }
		public int MaxStack { get; set; }
		public int Price { get; set; }
		public int SellPrice { get; set; }
	}

	/// <summary>
	/// Item database, indexed by item id.
	/// </summary>
	public class ItemDb : DatabaseJsonIndexed<int, ItemData>
	{
		public ItemData Find(string name)
		{
			name = name.ToLower();
			return this.Entries.FirstOrDefault(a => a.Value.Name.ToLower() == name).Value;
		}

		public List<ItemData> FindAll(string name)
		{
			name = name.ToLower();
			return this.Entries.FindAll(a => a.Value.Name.ToLower().Contains(name));
		}

		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("itemId", "className", "name", "category", "weight", "maxStack", "price", "sellPrice");

			var info = new ItemData();

			info.Id = entry.ReadInt("itemId");
			info.ClassName = entry.ReadString("className");
			info.Name = entry.ReadString("name");
			info.Category = (InventoryCategory)entry.ReadInt("category");
			info.Weight = entry.ReadInt("weight");
			info.MaxStack = entry.ReadInt("maxStack");
			info.Price = entry.ReadInt("price");
			info.SellPrice = entry.ReadInt("sellPrice");

			this.Entries[info.Id] = info;
		}
	}
}
