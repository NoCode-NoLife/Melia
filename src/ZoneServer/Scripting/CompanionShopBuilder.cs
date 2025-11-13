using System;
using Melia.Shared.Data.Database;

namespace Melia.Zone.Scripting
{
	/// <summary>
	/// A builder for creating companion shop data.
	/// </summary>
	public class CompanionShopBuilder
	{
		private readonly CompanionShopData _shopData;
		private int _productClassId = 200_001;

		/// <summary>
		/// Creates new instance for creating a companion shop with the given name.
		/// </summary>
		/// <param name="shopName"></param>
		public CompanionShopBuilder(string shopName)
		{
			_shopData = new CompanionShopData();
			_shopData.Name = shopName;
		}

		/// <summary>
		/// Returns the built companion shop data.
		/// </summary>
		/// <returns></returns>
		public CompanionShopData Build()
		{
			return _shopData;
		}

		/// <summary>
		/// Adds companion to the shop.
		/// </summary>
		/// <param name="companionClassName">Class name of the companion for sale.</param>
		/// <param name="price">The price for the companion.</param>
		public void AddCompanion(string companionClassName, int price = 1)
		{
			price = Math.Max(1, price);

			var productData = new CompanionProductData();

			productData.Id = _productClassId++;
			productData.CompanionClassName = companionClassName;
			productData.Price = price;
			productData.ShopName = _shopData.Name;

			_shopData.Products.Add(productData.Id, productData);
		}
	}
}
