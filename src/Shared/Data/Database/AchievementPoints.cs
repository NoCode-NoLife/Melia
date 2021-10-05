using System;
using Newtonsoft.Json.Linq;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class AchievementPointData
	{
		public int Id { get; set; }
		public string ClassName { get; set; }
		public bool UseDaily { get; set; }
		public bool UseWeekly { get; set; }
	}

	/// <summary>
	/// Achievement point database.
	/// </summary>
	public class AchievementPointDb : DatabaseJsonIndexed<int, AchievementPointData>
	{
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("id", "className", "useDaily", "useWeekly");

			var data = new AchievementPointData();

			data.Id = entry.ReadInt("id");
			data.ClassName = entry.ReadString("className");
			data.UseDaily = entry.ReadBool("useDaily");
			data.UseWeekly = entry.ReadBool("useWeekly");

			this.Entries[data.Id] = data;
		}
	}
}
