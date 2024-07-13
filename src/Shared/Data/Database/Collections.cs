using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data;
using Yggdrasil.Data.JSON;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class CollectionData
	{
		public int Id { get; set; }
		public string ClassName { get; set; }
		public string Name { get; set; }
		public Dictionary<int, int> RequiredItems { get; set; } = new();
		public Dictionary<int, int> RewardItems { get; set; } = new();
		public Dictionary<string, int> RewardProperties { get; set; } = new();
		public Dictionary<string, int> RewardAccountProperties { get; set; } = new();
	}

	/// <summary>
	/// Collection database, indexed by collection class name.
	/// </summary>
	public class CollectionDb : DatabaseJsonIndexed<string, CollectionData>
	{
		private readonly PropertiesDb _propertiesDb;
		private readonly ItemDb _itemDb;

		public CollectionDb(PropertiesDb propertiesDb, ItemDb itemDb)
		{
			_propertiesDb = propertiesDb;
			_itemDb = itemDb;
		}

		public bool TryFindByClassId(int classId, out CollectionData data)
		{
			data = this.Entries.Values.FirstOrDefault(c => c.Id == classId);
			return data != null;
		}

		public bool TryFindByClassName(string className, out CollectionData data)
		{
			data = this.Entries.Values.FirstOrDefault(c => c.ClassName == className);
			return data != null;
		}

		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("classId", "className", "name", "requiredItems");

			var data = new CollectionData();

			data.Id = entry.ReadInt("classId");
			data.ClassName = entry.ReadString("className");
			data.Name = entry.ReadString("name");

			var requiredItems = entry["requiredItems"].ToObject<Dictionary<string, int>>();
			var rewardItems = entry.ContainsKey("rewardItems") ? entry["rewardItems"].ToObject<Dictionary<string, int>>() : null;

			if (entry.ContainsKey("rewardProperties")) data.RewardProperties = entry["rewardProperties"].ToObject<Dictionary<string, int>>();
			if (entry.ContainsKey("rewardAccountProperties")) data.RewardAccountProperties = entry["rewardAccountProperties"].ToObject<Dictionary<string, int>>();

			foreach (var propertyName in data.RewardProperties.Keys)
			{
				if (_propertiesDb.Find(a => a.Namespace == "PC" && a.Name == propertyName) == null)
					throw new DatabaseWarningException(null, $"Unknown reward property name '{propertyName}' in collection '{data.ClassName}'.");
			}

			foreach (var propertyName in data.RewardAccountProperties.Keys)
			{
				if (_propertiesDb.Find(a => a.Namespace == "Account" && a.Name == propertyName) == null)
					throw new DatabaseWarningException(null, $"Unknown account reward property name '{propertyName}' in collection '{data.ClassName}'.");
			}

			foreach (var requiredItem in requiredItems)
			{
				var className = requiredItem.Key;
				var amount = requiredItem.Value;

				var itemData = _itemDb.FindByClass(className);
				if (itemData == null)
					throw new DatabaseWarningException(null, $"Unknown required item '{className}' in collection '{data.ClassName}'.");

				data.RequiredItems[itemData.Id] = amount;
			}

			if (rewardItems != null)
			{
				foreach (var rewardItem in rewardItems)
				{
					var className = rewardItem.Key;
					var amount = rewardItem.Value;

					var itemData = _itemDb.FindByClass(className);
					if (itemData == null)
						throw new DatabaseWarningException(null, $"Unknown reward item '{className}' in collection '{data.ClassName}'.");

					data.RewardItems[itemData.Id] = amount;
				}
			}

			this.Entries[data.ClassName] = data;
		}
	}
}
