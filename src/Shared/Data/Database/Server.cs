using System;
using System.Linq;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data;
using Yggdrasil.Data.JSON;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class ServerData
	{
		public ServerType Type { get; set; }
		public int Id { get; set; }
		public string Ip { get; set; }
		public int Port { get; set; }
		public string Maps { get; set; }
	}

	/// <summary>
	/// Server database.
	/// </summary>
	public class ServerDb : DatabaseJson<ServerData>
	{
		/// <summary>
		/// Returns the server data for the given type and id via out.
		/// Returns null if no matching entry was found.
		/// </summary>
		/// <param name="type"></param>
		/// <param name="id"></param>
		/// <returns></returns>
		public bool TryFind(ServerType type, int id, out ServerData data)
		{
			data = this.Entries.FirstOrDefault(a => a.Type == type && a.Id == id);
			return data != null;
		}

		/// <summary>
		/// Reads given entry and adds it to the database.
		/// </summary>
		/// <param name="entry"></param>
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("type", "id", "ip", "port");

			var data = new ServerData();

			data.Type = entry.ReadEnum<ServerType>("type");
			data.Id = entry.ReadInt("id");
			data.Ip = entry.ReadString("ip");
			data.Port = entry.ReadInt("port");

			if (data.Type == ServerType.Zone)
			{
				entry.AssertNotMissing("maps");
				data.Maps = entry.ReadString("maps");
			}

			if (this.Entries.Any(a => a.Type == data.Type && a.Id == data.Id))
				throw new DatabaseErrorException($"Duplicate: {data.Type}, {data.Id}");

			this.Add(data);
		}
	}

	public enum ServerType
	{
		Barracks,
		Zone,
	}
}
