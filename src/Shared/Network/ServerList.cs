using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Data.Database;
using Melia.Shared.Network.Inter.Messages;

namespace Melia.Shared.Network
{
	/// <summary>
	/// Server list manager.
	/// </summary>
	public class ServerList
	{
		private readonly List<ServerInfo> _servers = new List<ServerInfo>();

		/// <summary>
		/// Returns the data of the this server group.
		/// </summary>
		public ServerGroupData GroupData { get; private set; }

		/// <summary>
		/// Loads servers for given group from database.
		/// </summary>
		/// <param name="serverDb"></param>
		/// <param name="groupId"></param>
		public void Load(ServerDb serverDb, int groupId)
		{
			if (!serverDb.TryFind(groupId, out var groupData))
				throw new ArgumentException($"No server group with id {groupId} found.");

			this.GroupData = groupData;

			foreach (var serverData in groupData.Servers)
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
		/// <param name="serverId"></param>
		/// <param name="server"></param>
		/// <returns></returns>
		public bool TryGet(ServerType type, int serverId, out ServerInfo server)
		{
			server = _servers.FirstOrDefault(a => a.Type == type && a.Id == serverId);
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
			var mapServers = zoneServers.Where(a => a.Status == ServerStatus.Online && a.MapIds.Contains(mapId));

			return mapServers.ToArray();
		}

		/// <summary>
		/// Returns a list with the information of all servers of the
		/// given type.
		/// </summary>
		/// <param name="serverType"></param>
		/// <returns></returns>
		public ServerInfo[] GetAll(ServerType serverType)
			=> _servers.Where(a => a.Type == serverType).ToArray();

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

		/// <summary>
		/// Updates the server list with the given update information.
		/// </summary>
		/// <param name="serverUpdateMessage"></param>
		public void Update(ServerUpdateMessage serverUpdateMessage)
		{
			if (!this.TryGet(ServerType.Zone, serverUpdateMessage.ServerId, out var serverInfo))
				return;

			serverInfo.CurrentPlayers = serverUpdateMessage.PlayerCount;
			serverInfo.Status = serverUpdateMessage.ServerStatus;
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
		/// Returns the port the server is listening on publically.
		/// </summary>
		public int Port { get; }

		/// <summary>
		/// Returns the port the server is listening on internally.
		/// </summary>
		public int InterPort { get; }

		/// <summary>
		/// Returns the number of players currently connected to the server.
		/// </summary>
		public int CurrentPlayers { get; set; }

		/// <summary>
		/// Returns the mayimum number of players that can be connected to
		/// the server.
		/// </summary>
		public int MaxPlayers { get; set; } = 100;

		/// <summary>
		/// Returns the ids of the maps this server serves.
		/// </summary>
		public int[] MapIds { get; private set; }

		/// <summary>
		/// Gets or sets the server's status.
		/// </summary>
		public ServerStatus Status { get; set; }

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
			this.InterPort = data.InterPort;
			this.MapIds = data.MapIds;
		}
	}

	public enum ServerStatus
	{
		Offline,
		Online,
	}
}
