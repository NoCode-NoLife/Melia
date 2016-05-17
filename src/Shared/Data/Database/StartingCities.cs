// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using Newtonsoft.Json.Linq;
using Melia.Shared.Const;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class StartingCityData
	{
		public StartingCity Id { get; set; }
		public string Map { get; set; }
		public int X { get; set; }
		public int Y { get; set; }
		public int Z { get; set; }
	}

	/// <summary>
	/// Starting Cities database, indexed by startingCity id.
	/// </summary>
	public class StartingCityDb : DatabaseJsonIndexed<StartingCity, StartingCityData>
	{
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("startingCityId", "map", "x", "y", "z");

			var info = new StartingCityData();

			info.Id = (StartingCity)entry.ReadInt("startingCityId");
			info.Map = entry.ReadString("map");
			info.X = entry.ReadInt("x");
			info.Y = entry.ReadInt("y");
			info.Z = entry.ReadInt("z");

			this.Entries[info.Id] = info;
		}
	}
}
