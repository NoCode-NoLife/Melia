using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

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
			this.Products.TryGetValue(id, out var product);
			return product;
		}
	}

	[Serializable]
	public class ProductData
	{
		public string ShopName { get; set; }
		public int Id { get; set; }
		public int ItemId { get; set; }
		public int Amount { get; set; }
		public float PriceMultiplier { get; set; }
	}

	/// <summary>
	/// Shop database, indexed by shop name.
	/// </summary>
	public class ShopDb : DatabaseJsonIndexed<string, ShopData>
	{
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("shopName", "productId", "itemId", "amount", "priceMultiplier");

			var data = new ProductData();

			data.ShopName = entry.ReadString("shopName");
			data.Id = entry.ReadInt("productId");
			data.ItemId = entry.ReadInt("itemId");
			data.Amount = entry.ReadInt("amount");
			data.PriceMultiplier = entry.ReadFloat("priceMultiplier");

			if (!this.Entries.TryGetValue(data.ShopName, out var shopData))
			{
				shopData = new ShopData();
				shopData.Name = data.ShopName;

				this.Entries[data.ShopName] = shopData;
			}

			shopData.Products[data.Id] = data;
		}
	}
}
