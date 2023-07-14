using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data.JSON;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class RecipeData
	{
		public int Id { get; set; }
		public string ClassName { get; set; }
		public string ProductClassName { get; set; }
		public int ProductAmount { get; set; }
		public List<RecipeIngredientData> Ingredients { get; set; }
	}

	[Serializable]
	public class RecipeIngredientData
	{
		public string ClassName { get; set; }
		public int Amount { get; set; }
	}

	/// <summary>
	/// Recipe database, indexed by their id.
	/// </summary>
	public class RecipeDb : DatabaseJsonIndexed<int, RecipeData>
	{
		/// <summary>
		/// Reads given entry and adds it to the database.
		/// </summary>
		/// <param name="entry"></param>
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("recipeId", "className", "productClassName", "productAmount", "ingredients");

			var data = new RecipeData();

			data.Id = entry.ReadInt("recipeId");
			data.ClassName = entry.ReadString("className");
			data.ProductClassName = entry.ReadString("productClassName");
			data.ProductAmount = entry.ReadInt("productAmount");
			data.Ingredients = new List<RecipeIngredientData>();

			var ingredientsEntry = (JArray)entry["ingredients"];
			foreach (JObject ingredientEntry in ingredientsEntry)
			{
				ingredientEntry.AssertNotMissing("className", "amount");

				var ingredientData = new RecipeIngredientData();

				ingredientData.ClassName = ingredientEntry.ReadString("className");
				ingredientData.Amount = ingredientEntry.ReadInt("amount");

				data.Ingredients.Add(ingredientData);
			}

			this.AddOrReplace(data.Id, data);
		}
	}
}
