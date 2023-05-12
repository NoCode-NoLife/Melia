using System;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data.JSON;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class PacketStringData
	{
		public string Name { get; set; }
		public int Id { get; set; }
	}

	/// <summary>
	/// Packet string database, for lookup of ids based on their name.
	/// </summary>
	public class PacketStringDb : DatabaseJsonIndexed<string, PacketStringData>
	{
		/// <summary>
		/// Reads given entry and adds it to the database.
		/// </summary>
		/// <param name="entry"></param>
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("name", "id");

			var data = new PacketStringData();

			data.Name = entry.ReadString("name");
			data.Id = entry.ReadInt("id");

			this.AddOrReplace(data.Name, data);
		}
	}
}
