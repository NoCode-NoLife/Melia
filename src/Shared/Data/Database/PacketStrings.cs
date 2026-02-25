using System;
using System.Linq;
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
		/// Tries to find a Packet string data for a given id.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public bool TryFind(int id, out PacketStringData data)
		{
			data = this.Entries.Values.FirstOrDefault(a => a.Id == id);
			return data != null;
		}

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
