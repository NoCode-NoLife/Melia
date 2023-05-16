using System;
using Melia.Shared.Data.Database;

namespace Melia.Zone.Scripting
{
	/// <summary>
	/// A builder for creating shop data.
	/// </summary>
	public class ShopBuilder
	{
		private readonly ShopData _shopData;
		private int _productClassId = 100_001;

		/// <summary>
		/// Creates new instance for creating a shop with the given name.
		/// </summary>
		/// <param name="shopName"></param>
		public ShopBuilder(string shopName)
		{
			_shopData = new ShopData();
			_shopData.Name = shopName;
			_shopData.IsCustom = true;
		}

		/// <summary>
		/// Returns the built shop data.
		/// </summary>
		/// <returns></returns>
		public ShopData Build()
		{
			return _shopData;
		}

		/// <summary>
		/// Adds item to the shop.
		/// </summary>
		/// <param name="itemId">Id of the item for sale.</param>
		/// <param name="amount">Number of items that are sold at once.</param>
		/// <param name="price">The price per 1 unit.</param>
		public void AddItem(int itemId, int amount, int price)
		{
			amount = Math.Max(1, amount);
			price = Math.Max(1, price);

			var productData = new ProductData();

			productData.Id = _productClassId++;
			productData.ItemId = itemId;
			productData.Amount = amount;
			productData.PriceMultiplier = price;

			_shopData.Products.Add(productData.Id, productData);
		}
	}
}
