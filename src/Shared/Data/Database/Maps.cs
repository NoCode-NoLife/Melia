using System;
using System.Collections.Generic;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data.JSON;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class MapData
	{
		public int Id { get; set; }
		public string ClassName { get; set; }
		public string Name { get; set; }
		public MapType Type { get; set; }
		public int Level { get; set; }
		public Position DefaultPosition { get; set; }
	}

	/// <summary>
	/// Map database, indexed by map id.
	/// </summary>
	public class MapDb : DatabaseJsonIndexed<int, MapData>
	{
		private readonly Dictionary<string, MapData> _nameIndex = new Dictionary<string, MapData>();

		/// <summary>
		/// Returns the map entry with given class name, or null if there was
		/// not matching entry.
		/// </summary>
		/// <param name="className"></param>
		/// <returns></returns>
		public MapData Find(string className)
		{
			_nameIndex.TryGetValue(className, out var result);
			return result;
		}

		/// <summary>
		/// Returns the map entry with given class name via out.
		/// Returns null if there was no matching entry.
		/// </summary>
		/// <param name="className"></param>
		/// <param name="result"></param>
		/// <returns></returns>
		public bool TryFind(string className, out MapData result)
			=> _nameIndex.TryGetValue(className, out result);

		/// <summary>
		/// Reads given entry and adds it to the database.
		/// </summary>
		/// <param name="entry"></param>
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("mapId", "className", "name", "type", "level", "defaultPosition");

			var data = new MapData();

			data.Id = entry.ReadInt("mapId");
			data.ClassName = entry.ReadString("className");
			data.Name = entry.ReadString("name");
			data.Type = entry.ReadEnum<MapType>("type");
			data.Level = entry.ReadInt("level");

			var defaultPosEntry = (JObject)entry["defaultPosition"];
			data.DefaultPosition = new Position(defaultPosEntry.ReadFloat("x"), defaultPosEntry.ReadFloat("y"), defaultPosEntry.ReadFloat("z"));

			_nameIndex[data.ClassName] = data;

			this.AddOrReplace(data.Id, data);
		}
	}
}
