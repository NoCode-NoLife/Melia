using System;
using Newtonsoft.Json.Linq;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class AchievementData
	{
		public int Id { get; set; }
		public string ClassName { get; set; }
		public bool UseDaily { get; set; }
		public bool UseWeekly { get; set; }
	}

	/// <summary>
	/// Achievement database.
	/// </summary>
	public class AchievementDb : DatabaseJsonIndexed<int, AchievementData>
	{
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("id", "className", "useDaily", "useWeekly");

			var data = new AchievementData();

			data.Id = entry.ReadInt("id");
			data.ClassName = entry.ReadString("className");
			data.UseDaily = entry.ReadBool("useDaily");
			data.UseWeekly = entry.ReadBool("useWeekly");

			this.Entries[data.Id] = data;
		}
	}
}
