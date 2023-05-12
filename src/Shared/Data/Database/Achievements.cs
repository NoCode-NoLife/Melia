using System;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data.JSON;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class AchievementData
	{
		public int Id { get; set; }
		public string ClassName { get; set; }
		public string Category { get; set; }
		public string Name { get; set; }
		public string PointName { get; set; }
		public int PointCount { get; set; }
		public bool IsRepeatable { get; set; }
		public bool IsAccountReward { get; set; }
	}

	/// <summary>
	/// Achievement database.
	/// </summary>
	public class AchievementDb : DatabaseJsonIndexed<int, AchievementData>
	{
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("id", "className", "category", "name", "point", "count", "repeatable", "account");

			var data = new AchievementData();

			data.Id = entry.ReadInt("id");
			data.ClassName = entry.ReadString("className");
			data.Category = entry.ReadString("category");
			data.Name = entry.ReadString("name");
			data.PointName = entry.ReadString("point");
			data.PointCount = entry.ReadInt("count");
			data.IsRepeatable = entry.ReadBool("repeatable");
			data.IsAccountReward = entry.ReadBool("account");

			this.Entries[data.Id] = data;
		}
	}
}
