using System;
using Newtonsoft.Json.Linq;

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
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("name", "id");

			var data = new PacketStringData();

			data.Name = entry.ReadString("name");
			data.Id = entry.ReadInt("id");

			this.Entries[data.Name] = data;
		}
	}
}
