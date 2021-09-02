﻿// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Linq;
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
	/// achievement tree database.
	/// </summary>
	public class AchievementDb : DatabaseJson<AchievementData>
	{
		/// <summary>
		/// Returns data for the given achievement, or null if no
		/// data exists.
		/// </summary>
		/// <param name="achievementId"></param>
		/// <returns></returns>
		public AchievementData Find(int achievementId)
		{
			return this.Entries.FirstOrDefault(a => a.Id == achievementId);
		}

		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("achievementId", "className", "useDaily", "useWeekly");

			var data = new AchievementData();

			data.Id = entry.ReadInt("achievementId");
			data.ClassName = entry.ReadString("className");
			data.UseDaily = entry.ReadBool("useDaily");
			data.UseWeekly = entry.ReadBool("useWeekly");

			this.Entries.Add(data);
		}
	}
}
