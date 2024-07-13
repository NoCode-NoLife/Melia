using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data.JSON;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class CollectionData
	{
		public int Id { get; set; }
		public string ClassName { get; set; }
		public string Name { get; set; }
		public List<string> RequiredItems { get; set; }
		public string RewardProperties { get; internal set; }
		public string RewardAccountProperties { get; internal set; }
		public string RewardItems { get; internal set; }
	}

	/// <summary>
	/// Collection database, indexed by collection class name.
	/// </summary>
	public class CollectionDb : DatabaseJsonIndexed<string, CollectionData>
	{


		public bool TryFind(int collectionId, out CollectionData collection)
		{
			collection = this.Entries.Values.FirstOrDefault(c => c.Id == collectionId);

			return collection != default;
		}


		public bool Lookup(string className, out CollectionData collection)
		{
			collection = this.Entries.Values.FirstOrDefault(c => c.ClassName == className);

			return collection != default;
		}

		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("classId", "className", "name", "requiredItems");

			var collection = new CollectionData();

			collection.Id = entry.ReadInt("classId");
			collection.ClassName = entry.ReadString("className");
			collection.Name = entry.ReadString("name");
			collection.RequiredItems = entry.ReadList<string>("requiredItems");
			collection.RewardProperties = entry.ReadString("rewardProperties");
			collection.RewardAccountProperties = entry.ReadString("rewardAccountProperties");
			collection.RewardItems = entry.ReadString("rewardItems");

			this.Entries[collection.ClassName] = collection;
		}
	}
}
