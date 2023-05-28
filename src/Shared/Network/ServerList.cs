using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Data.Database;

namespace Melia.Shared.Network
{
	/// <summary>
	/// Server list manager.
	/// </summary>
	public class ServerList
	{
		private readonly List<ServerInfo> _servers = new List<ServerInfo>();

		/// <summary>
		/// Loads servers from database.
		/// </summary>
		/// <param name="serverDb"></param>
		public void Load(ServerDb serverDb)
		{
			foreach (var serverData in serverDb.Entries)
			{
				var serverInfo = new ServerInfo(serverData);
				_servers.Add(serverInfo);
			}
		}

		/// <summary>
		/// Returns the server with the given type and id via out.
		/// Returns false if no matching server was found.
		/// </summary>
		/// <param name="type"></param>
		/// <param name="id"></param>
		/// <param name="server"></param>
		/// <returns></returns>
		public bool TryGet(ServerType type, int id, out ServerInfo server)
		{
			server = _servers.FirstOrDefault(a => a.Type == type && a.Id == id);
			return server != null;
		}

		/// <summary>
		/// Returns a list of zone servers that serve the given map.
		/// </summary>
		/// <param name="mapId"></param>
		/// <returns></returns>
		public ServerInfo[] GetZoneServers(int mapId)
		{
			var zoneServers = _servers.Where(a => a.Type == ServerType.Zone);
			var mapServers = zoneServers.Where(a => a.MapIds.Contains(mapId));

			return mapServers.ToArray();
		}

		/// <summary>
		/// Returns a list of social servers.
		/// </summary>
		/// <returns></returns>
		public ServerInfo[] GetSocialServers()
		{
			var socialServers = _servers.Where(a => a.Type == ServerType.Social);

			return socialServers.ToArray();
		}

		/// <summary>
		/// Returns the zone server with the given index that serves the
		/// given map via out. Returns false if no matching server was found.
		/// </summary>
		/// <param name="mapId"></param>
		/// <returns></returns>
		public bool TryGetZoneServer(int mapId, int index, out ServerInfo serverInfo)
		{
			serverInfo = null;

			var zoneServers = _servers.Where(a => a.Type == ServerType.Zone);
			var mapServers = zoneServers.Where(a => a.MapIds.Contains(mapId));

			if (index < 0 || index > _servers.Count - 1)
				return false;

			serverInfo = mapServers.ElementAt(index);
			return true;
		}
	}

	/// <summary>
	/// Information about a server.
	/// </summary>
	public class ServerInfo
	{
		/// <summary>
		/// Returns the server's type.
		/// </summary>
		public ServerType Type { get; }

		/// <summary>
		/// Returns the server's id.
		/// </summary>
		public int Id { get; }

		/// <summary>
		/// Returns the server's IP address.
		/// </summary>
		public string Ip { get; }

		/// <summary>
		/// Returns the server's port.
		/// </summary>
		public int Port { get; }

		/// <summary>
		/// Returns the number of players currently connected to the server.
		/// </summary>
		public int CurrentPlayers { get; }

		/// <summary>
		/// Returns the mayimum number of players that can be connected to
		/// the server.
		/// </summary>
		public int MaxPlayers { get; } = 100;

		/// <summary>
		/// Returns the ids of the maps this server serves.
		/// </summary>
		public int[] MapIds { get; private set; }

		/// <summary>
		/// Creates new server info.
		/// </summary>
		/// <param name="data"></param>
		public ServerInfo(ServerData data)
		{
			this.Type = data.Type;
			this.Id = data.Id;
			this.Ip = data.Ip;
			this.Port = data.Port;
			this.MapIds = data.MapIds;
		}
	}
}
