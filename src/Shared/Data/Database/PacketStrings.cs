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
		/// Returns the packet string data for the given id via out.
		/// Returns false if no entry with the given id was found.
		/// </summary>
		/// <param name="id"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public bool TryFind(int id, out PacketStringData data)
		{
			foreach (var entry in this.Entries)
			{
				if (entry.Value.Id == id)
				{
					data = entry.Value;
					return true;
				}
			}

			data = null;
			return false;
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
