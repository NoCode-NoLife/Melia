using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Melia.Barracks.Database;
using Melia.Barracks.Network;
using Melia.Barracks.Util;
using Melia.Shared;
using Melia.Shared.Data.Database;
using Melia.Shared.IES;
using Melia.Shared.Network;
using Melia.Shared.Network.Inter.Messages;
using Yggdrasil.Logging;
using Yggdrasil.Network.Communication;
using Yggdrasil.Network.TCP;
using Yggdrasil.Util;

namespace Melia.Barracks
{
	/// <summary>
	/// Represents the barracks server.
	/// </summary>
	public class BarracksServer : Server
	{
		/// <summary>
		/// Returns global instance of the barracks server.
		/// </summary>
		public readonly static BarracksServer Instance = new BarracksServer();

		private TcpConnectionAcceptor<BarracksConnection> _acceptor;
		private readonly Dictionary<string, int> _zoneServerNames = new Dictionary<string, int>();

		/// <summary>
		/// Returns the server's inter-server communicator.
		/// </summary>
		public Communicator Communicator { get; private set; }

		/// <summary>
		/// Returns a reference to the server's packet handlers.
		/// </summary>
		public PacketHandler PacketHandler { get; } = new PacketHandler();

		/// <summary>
		/// Returns reference to the server's database interface.
		/// </summary>
		public BarracksDb Database { get; } = new BarracksDb();

		/// <summary>
		/// Returns reference to the server's IES mods.
		/// </summary>
		public IesModList IesMods { get; } = new IesModList();

		/// <summary>
		/// Runs the server.
		/// </summary>
		/// <param name="args"></param>
		public override void Run(string[] args)
		{
			this.GetServerId(args, out var groupId, out var serverId);
			var title = string.Format("Barracks ({0}, {1})", groupId, serverId);

			ConsoleUtil.WriteHeader(ConsoleHeader.ProjectName, title, ConsoleColor.Magenta, ConsoleHeader.Logo, ConsoleHeader.Credits);
			ConsoleUtil.LoadingTitle();

			Log.Init("BarracksServer" + serverId);

			this.NavigateToRoot();

			this.LoadConf();
			this.LoadLocalization(this.Conf);
			this.LoadData(ServerType.Barracks);
			this.LoadServerList(this.Data.ServerDb, ServerType.Barracks, groupId, serverId);
			this.InitDatabase(this.Database, this.Conf);
			this.CheckDatabaseUpdates();
			this.ClearLoginStates();

			this.StartCommunicator();
			this.StartAcceptor();

			ConsoleUtil.RunningTitle();
			new BarracksConsoleCommands().Wait();
		}

		/// <summary>
		/// Starts accepting connections.
		/// </summary>
		private void StartAcceptor()
		{
			_acceptor = new TcpConnectionAcceptor<BarracksConnection>(this.ServerInfo.Port);
			_acceptor.ConnectionAccepted += this.OnConnectionAccepted;
			_acceptor.Listen();

			Log.Status("Server ready, listening on {0}.", _acceptor.Address);
		}

		/// <summary>
		/// Starts the communicator and waits for connections from other
		/// servers.
		/// </summary>
		private void StartCommunicator()
		{
			var commName = "" + this.ServerInfo.Type + this.ServerInfo.Id;

			this.Communicator = new Communicator(commName);
			this.Communicator.ClientConnected += this.Communicator_OnClientConnected;
			this.Communicator.ClientDisconnected += this.Communicator_OnClientDisconnected;
			this.Communicator.MessageReceived += this.Communicator_OnMessageReceived;

			this.Communicator.Listen(this.ServerInfo.InterPort);
		}

		/// <summary>
		/// Called when a server connected via the communicator.
		/// </summary>
		/// <param name="commName"></param>
		private void Communicator_OnClientConnected(string commName)
		{
			Log.Info("Accepted connection from server {0}.", commName);
		}

		/// <summary>
		/// Called when a server disconnected from the communicator.
		/// </summary>
		/// <param name="commName"></param>
		private void Communicator_OnClientDisconnected(string commName)
		{
			Log.Info("Lost connection from server {0}.", commName);

			if (_zoneServerNames.TryGetValue(commName, out var serverId))
			{
				var serverUpdateMessage = new ServerUpdateMessage(ServerType.Zone, serverId, 0, ServerStatus.Offline);

				this.ServerList.Update(serverUpdateMessage);
				this.Communicator.Broadcast("ServerUpdates", serverUpdateMessage);
			}
		}

		/// <summary>
		/// Called when a message is received from a server.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="message"></param>
		private void Communicator_OnMessageReceived(string sender, ICommMessage message)
		{
			//Log.Debug("Message received from '{0}': {1}", sender, message);

			if (message is ServerUpdateMessage serverUpdateMessage)
			{
				if (serverUpdateMessage.ServerType == ServerType.Zone)
					_zoneServerNames[sender] = serverUpdateMessage.ServerId;

				this.ServerList.Update(serverUpdateMessage);
				this.Communicator.Broadcast("ServerUpdates", serverUpdateMessage);

				Send.BC_NORMAL.ZoneTraffic();
			}
		}

		/// <summary>
		/// Called when a new connection is accepted.
		/// </summary>
		/// <param name="conn"></param>
		private void OnConnectionAccepted(BarracksConnection conn)
		{
			Log.Info("New connection accepted from '{0}'.", conn.Address);
		}

		/// <summary>
		/// Checks for potential updates for the database.
		/// </summary>
		private void CheckDatabaseUpdates()
		{
			Log.Info("Checking for updates...");

			var files = Directory.GetFiles("sql").OrderBy(a => a);
			foreach (var filePath in files.Where(file => Path.GetExtension(file).ToLower() == ".sql"))
				this.RunUpdate(Path.GetFileName(filePath));
		}

		/// <summary>
		/// Attempts to execute the given update file.
		/// </summary>
		/// <param name="updateFile"></param>
		private void RunUpdate(string updateFile)
		{
			if (BarracksServer.Instance.Database.CheckUpdate(updateFile))
				return;

			Log.Info("Update '{0}' found, executing...", updateFile);

			BarracksServer.Instance.Database.RunUpdate(updateFile);
		}

		/// <summary>
		/// Clears the login states of all accounts in the database.
		/// </summary>
		private void ClearLoginStates()
		{
			// Clearing the login states on barracks start means we'll
			// have a clean slate whenever we restart the server, though
			// it also leaves somewhat of a potential bypass, where the
			// login states may get reset because you restarted barracks,
			// even though people might still be logged in on a zone.
			// This should be pretty rare though, and we can improve
			// it once the servers talk to each other. TODO.
			this.Database.ClearLoginStates();
		}

		/// <summary>
		/// Returns a list of all active connections.
		/// </summary>
		/// <returns></returns>
		public BarracksConnection[] GetAllConnections()
			=> _acceptor.GetAllConnections();

		/// <summary>
		/// Broadcasts the packet to all logged in connections.
		/// </summary>
		/// <param name="packet"></param>
		public void Broadcast(Packet packet)
		{
			var connections = this.GetAllConnections();

			foreach (var conn in connections)
			{
				if (conn.LoggedIn)
					conn.Send(packet);
			}
		}
	}
}
