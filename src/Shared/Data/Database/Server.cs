using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data;
using Yggdrasil.Data.JSON;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class ServerGroupData
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public List<ServerData> Servers { get; set; }
	}

	[Serializable]
	public class ServerData
	{
		public ServerType Type { get; set; }
		public int Id { get; set; }
		public string Ip { get; set; }
		public int Port { get; set; }
		public int InterPort { get; set; }
		public int[] MapIds { get; set; }

		public bool ServesAllMaps => this.MapIds.Length == 1 && this.MapIds[0] == -1;
	}

	/// <summary>
	/// Server database.
	/// </summary>
	public class ServerDb : DatabaseJsonIndexed<int, ServerGroupData>
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
		/// Reads given entry and adds it to the database.
		/// </summary>
		/// <param name="entry"></param>
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("groupId", "name", "servers");

			var groupData = new ServerGroupData();

			groupData.Id = entry.ReadInt("groupId");
			groupData.Name = entry.ReadString("name");

			groupData.Servers = new List<ServerData>();
			foreach (var serverEntry in entry.ReadArray<JObject>("servers"))
			{
				serverEntry.AssertNotMissing("type", "id", "ip", "port");

				var serverData = new ServerData();

				serverData.Type = serverEntry.ReadEnum<ServerType>("type");
				serverData.Id = serverEntry.ReadInt("id");
				serverData.Ip = serverEntry.ReadString("ip");
				serverData.Port = serverEntry.ReadInt("port");
				serverData.InterPort = serverEntry.ReadInt("interPort", 0);

				if (serverData.Type == ServerType.Zone)
				{
					serverEntry.AssertNotMissing("maps");

					if (serverEntry["maps"].Type == JTokenType.Array)
					{
						serverData.MapIds = serverEntry.ReadArray<int>("maps");
					}
					else if ((string)serverEntry["maps"] == "all")
					{
						serverData.MapIds = _mapDb.Entries.Values.Select(a => a.Id).ToArray();
					}
					else
					{
						throw new DatabaseErrorException($"Invalid maps list found on {serverData.Type}:{serverData.Id}. Expected 'all' or an array of ids.");
					}
				}
				else
				{
					serverData.MapIds = [];
				}

				groupData.Servers.Add(serverData);
			}

			this.AddOrReplace(groupData.Id, groupData);
		}
	}

	public enum ServerType
	{
		Barracks,
		Zone,
		Web,
		Social,
	}
}
