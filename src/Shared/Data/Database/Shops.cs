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
	public class ShopData
	{
		public string Name { get; set; }
		public Dictionary<int, ProductData> Products { get; set; }

		public ShopData()
		{
			this.Products = new Dictionary<int, ProductData>();
		}

		public ProductData GetProduct(int id)
		{
			ProductData product;
			this.Products.TryGetValue(id, out product);
			return product;
		}
	}

	[Serializable]
	public class ProductData
	{
		public int Id { get; set; }
		public int ItemId { get; set; }
		public string ShopName { get; set; }
	}

	/// <summary>
	/// Shop database, indexed by shop name.
	/// </summary>
	public class ShopDb : DatabaseJsonIndexed<string, ShopData>
	{
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("shopName", "productId", "itemId");

			var data = new ProductData();

			data.Id = entry.ReadInt("productId");
			data.ItemId = entry.ReadInt("itemId");
			data.ShopName = entry.ReadString("shopName");

			if (!this.Entries.ContainsKey(data.ShopName))
				this.Entries[data.ShopName] = new ShopData();

			this.Entries[data.ShopName].Products[data.Id] = data;
		}
	}
}
