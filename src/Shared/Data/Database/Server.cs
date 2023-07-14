using System;
using System.Collections.Generic;
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
		public int[] MapIds { get; set; }

		public bool ServesAllMaps => this.MapIds.Length == 1 && this.MapIds[0] == -1;
	}

	/// <summary>
	/// Server database.
	/// </summary>
	public class ServerDb : DatabaseJson<ServerData>
	{
		private readonly MapDb _mapDb;

		/// <summary>
		/// Creates new server db.
		/// </summary>
		/// <param name="mapDb"></param>
		public ServerDb(MapDb mapDb)
		{
			_mapDb = mapDb;
		}

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
		/// Returns all servers that match the given type.
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		public ServerData[] FindAll(ServerType type)
			=> this.Entries.Where(a => a.Type == type).ToArray();

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

				if (entry["maps"].Type == JTokenType.Array)
				{
					data.MapIds = entry.ReadArray<int>("maps");
				}
				else if ((string)entry["maps"] == "all")
				{
					data.MapIds = _mapDb.Entries.Values.Select(a => a.Id).ToArray();
				}
				else
				{
					throw new DatabaseErrorException($"Invalid maps list found on {data.Type}:{data.Id}. Expected 'all' or an array of ids.");
				}
			}
			else
			{
				data.MapIds = new int[0];
			}

			this.Entries.RemoveAll(a => a.Type == data.Type && a.Id == data.Id);

			this.Add(data);
		}
	}

	public enum ServerType
	{
		Barracks,
		Zone,
		Web,
	}
}
