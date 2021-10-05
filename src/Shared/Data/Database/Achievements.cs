using System;
using Newtonsoft.Json.Linq;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class AchievementData
	{
		public int Id { get; set; }
		public string ClassName { get; set; }
	}

	/// <summary>
	/// Achievement database.
	/// </summary>
	public class AchievementDb : DatabaseJsonIndexed<int, AchievementData>
	{
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("id", "className");

			var data = new AchievementData();

			data.Id = entry.ReadInt("id");
			data.ClassName = entry.ReadString("className");

			this.Entries[data.Id] = data;
		}
	}
}
