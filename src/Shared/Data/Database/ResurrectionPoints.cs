using System;
using System.Linq;
using Melia.Shared.World;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data.JSON;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class ResurrectionPointData
	{
		public string MapClassName { get; set; }
		public Position Position { get; set; }
	}

	/// <summary>
	/// Resurrection location database..
	/// </summary>
	public class ResurrectionPointDb : DatabaseJson<ResurrectionPointData>
	{
		/// <summary>
		/// Returns all entries for given map.
		/// </summary>
		/// <param name="mapClassName"></param>
		/// <returns></returns>
		public ResurrectionPointData[] Find(string mapClassName)
			=> this.Entries.Where(x => x.MapClassName == mapClassName).ToArray();

		/// <summary>
		/// Reads given entry and adds it to the database.
		/// </summary>
		/// <param name="entry"></param>
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("map", "x", "y", "z");

			var data = new ResurrectionPointData();

			data.MapClassName = entry.ReadString("map");
			var x = entry.ReadFloat("x");
			var y = entry.ReadFloat("y");
			var z = entry.ReadFloat("z");
			data.Position = new Position(x, y, z);

			this.Add(data);
		}
	}
}
