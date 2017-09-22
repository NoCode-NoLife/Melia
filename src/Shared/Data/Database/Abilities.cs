// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using Newtonsoft.Json.Linq;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class AbilityData
	{
		public int Id { get; set; }
		public string ClassName { get; set; }
		public string EngName { get; set; }
		public int Level { get; set; }
	}

	/// <summary>
	/// Ability database, indexed by ability id.
	/// </summary>
	public class AbilityDb : DatabaseJsonIndexed<int, AbilityData>
	{
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("id", "className", "engName", "level");

			var data = new AbilityData();

			data.Id = entry.ReadInt("id");
			data.ClassName = entry.ReadString("className");
			data.EngName = entry.ReadString("engName");
			data.Level = entry.ReadInt("level");

			this.Entries[data.Id] = data;
		}
	}
}
