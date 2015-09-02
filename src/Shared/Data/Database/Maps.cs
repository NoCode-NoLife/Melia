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
			entry.AssertNotMissing("mapId", "className");

			var info = new MapData();

			info.Id = entry.ReadInt("mapId");
			info.ClassName = entry.ReadString("className");

			this.Entries[info.Id] = info;
			_nameIndex[info.ClassName] = info;
		}
	}
}
