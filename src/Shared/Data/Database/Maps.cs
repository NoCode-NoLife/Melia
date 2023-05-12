using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data.JSON;

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
		private readonly Dictionary<string, MapData> _nameIndex = new Dictionary<string, MapData>();

		public MapData Find(string className)
		{
			_nameIndex.TryGetValue(className, out var result);
			return result;
		}

		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("mapId", "className", "engName", "localKey");

			var data = new MapData();

			data.Id = entry.ReadInt("mapId");
			data.ClassName = entry.ReadString("className");
			data.EngName = entry.ReadString("engName");
			data.LocalKey = entry.ReadString("localKey");

			_nameIndex[data.ClassName] = data;

			this.AddOrReplace(data.Id, data);
		}
	}
}
