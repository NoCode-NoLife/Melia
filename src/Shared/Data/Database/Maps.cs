// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using Melia.Shared.Const;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class MapData
	{
		public int Id { get; set; }
		public string ClassName { get; set; }
		public string EngName { get; set; }
		public string LocalKey { get; set; }
	}

	/// <summary>
	/// Map database, indexed by map id.
	/// </summary>
	public class MapDb : DatabaseJsonIndexed<int, MapData>
	{
		private Dictionary<string, MapData> _nameIndex = new Dictionary<string, MapData>();

		public MapData Find(string className)
		{
			MapData result;
			_nameIndex.TryGetValue(className, out result);
			return result;
		}

		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("mapId", "className", "engName", "localKey");

			var info = new MapData();

			info.Id = entry.ReadInt("mapId");
			info.ClassName = entry.ReadString("className");
			info.EngName = entry.ReadString("engName");
			info.LocalKey = entry.ReadString("localKey");

			this.Entries[info.Id] = info;
			_nameIndex[info.ClassName] = info;
		}
	}

	[Serializable]
	public class StartingCityData
	{
		public int Id { get; set; }
		public string Map { get; set; }
		public int X { get; set; }
		public int Y { get; set; }
		public int Z { get; set; }
	}

	/// <summary>
	/// Starting Cities database, indexed by startingCity id.
	/// </summary>
	public class StartingCityDb : DatabaseJsonIndexed<int, StartingCityData>
	{

		public StartingCityData Find(StartingCity startingCity)
		{
			return this.Find((int)startingCity);
		}

		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("startingCityId", "Map", "X", "Y", "Z");

			var info = new StartingCityData();

			info.Id = entry.ReadInt("startingCityId");
			info.Map = entry.ReadString("Map");
			info.X = entry.ReadInt("X");
			info.Y = entry.ReadInt("Y");
			info.Z = entry.ReadInt("Z");

			this.Entries[info.Id] = info;
		}
	}
}
