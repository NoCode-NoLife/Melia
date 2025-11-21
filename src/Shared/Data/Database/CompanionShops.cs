using System;
using System.Collections.Generic;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class CompanionShopData
	{
		public string Name { get; set; }
		public Dictionary<int, CompanionProductData> Products { get; set; } = new Dictionary<int, CompanionProductData>();

		public CompanionProductData GetProduct(int id)
		{
			this.Products.TryGetValue(id, out var product);
			return product;
		}
	}

	[Serializable]
	public class CompanionProductData
	{
		public string ShopName { get; set; }
		public int Id { get; set; }
		public string CompanionClassName { get; set; }
		public int Price { get; set; }
	}

	/// <summary>
	/// Companion shop database, indexed by shop name.
	/// </summary>
	public class CompanionShopDb
	{
		private readonly Dictionary<string, CompanionShopData> _entries = new Dictionary<string, CompanionShopData>();

		/// <summary>
		/// Adds or replaces a companion shop in the database.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="data"></param>
		public void AddOrReplace(string name, CompanionShopData data)
		{
			_entries[name] = data;
		}

		/// <summary>
		/// Tries to find a companion shop by name.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public bool TryFind(string name, out CompanionShopData data)
		{
			return _entries.TryGetValue(name, out data);
		}

		/// <summary>
		/// Returns true if a companion shop with the given name exists.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public bool Exists(string name)
		{
			return _entries.ContainsKey(name);
		}
	}
}
