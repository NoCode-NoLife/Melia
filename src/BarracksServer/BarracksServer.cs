using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Melia.Barracks.Database;
using Melia.Barracks.Events;
using Melia.Barracks.Network;
using Melia.Barracks.Util;
using Melia.Shared;
using Melia.Shared.Data.Database;
using Melia.Shared.IES;
using Melia.Shared.Network;
using Melia.Shared.Network.Inter.Messages;
using Yggdrasil.Logging;
using Yggdrasil.Network.Communication;
using Yggdrasil.Network.Communication.Messages;
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
		public readonly static BarracksServer Instance = new();

		private TcpConnectionAcceptor<BarracksConnection> _acceptor;
		private readonly Dictionary<string, int> _zoneServerNames = new();

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
		/// Returns a reference to the server's event manager.
		/// </summary>
		public ServerEvents ServerEvents { get; } = new ServerEvents();

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
			this.LoadIesMods();
			this.LoadScripts("barracks");

			this.StartCommunicator();
			this.StartAcceptor();

			ConsoleUtil.RunningTitle();
			new BarracksConsoleCommands().Wait();
		}

		/// <summary>
		/// Sets up IES mods.
		/// </summary>
		private void LoadIesMods()
		{
			// This method is temporary until we have a more proper way
			// way of handling IES mods.

			// Add IES mods to apply the server-side skin tone data changes
			// on the client. This, in combination with our custom data,
			// enables three additional skin tones during character creation
			// that match the skin tone images displayed.
			var skinTonesData = this.Data.SkinToneDb.Entries;
			foreach (var data in skinTonesData)
			{
				this.IesMods.Add("SkinTone", data.ClassId, "UseableBarrack", data.Creation ? "YES" : "NO");
				this.IesMods.Add("SkinTone", data.ClassId, "Red", ((data.Color & 0x00FF0000) >> 16).ToString());
				this.IesMods.Add("SkinTone", data.ClassId, "Green", ((data.Color & 0x0000FF00) >> 08).ToString());
				this.IesMods.Add("SkinTone", data.ClassId, "Blue", ((data.Color & 0x000000FF) >> 00).ToString());
			}
		}

		/// <summary>
		/// Starts accepting connections.
		/// </summary>
		private void StartAcceptor()
		{
			_acceptor = new TcpConnectionAcceptor<BarracksConnection>(this.ServerInfo.Port);
			_acceptor.ConnectionChecker = (conn) => this.CheckConnection(conn, this.Database);
			_acceptor.ConnectionAccepted += this.OnConnectionAccepted;
			_acceptor.ConnectionRejected += this.OnConnectionRejected;
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
			var authentication = this.Conf.Inter.Authentication;

			this.Communicator = new Communicator(commName, authentication);
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

			switch (message)
			{
				case ServerUpdateMessage serverUpdateMessage:
				{
					if (serverUpdateMessage.ServerType == ServerType.Zone)
						_zoneServerNames[sender] = serverUpdateMessage.ServerId;

					this.ServerList.Update(serverUpdateMessage);
					this.Communicator.Broadcast("ServerUpdates", serverUpdateMessage);

					Send.BC_NORMAL.ZoneTraffic();
					break;
				}
				case RequestMessage requestMessage:
				{
					this.Communicator_OnRequestReceived(sender, requestMessage);
					break;
				}
				case ForceLogOutMessage logoutMessage:
				{
					var connection = this.GetAllConnections().FirstOrDefault(a => a?.Account?.Id == logoutMessage.AccountId);
					connection?.Close();
					break;
				}
			}
		}

		/// <summary>
		/// Called when a request message was received.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="requestMessage"></param>
		private void Communicator_OnRequestReceived(string sender, RequestMessage requestMessage)
		{
			switch (requestMessage.Message)
			{
				case ReqPlayerCountMessage reqPlayerCountMessage:
				{
					var playerCount = this.ServerList.GetAll(ServerType.Zone).Sum(server => server.CurrentPlayers);

					var message = new ResPlayerCountMessage(playerCount);
					var responseMessage = new ResponseMessage(requestMessage.Id, message);

					this.Communicator.Send(sender, responseMessage);
					break;
				}

				case ReqServerListMessage reqMessage:
				{
					var servers = this.ServerList.GetAll();

					var message = new ResServerListMessage(servers);
					var responseMessage = new ResponseMessage(requestMessage.Id, message);

						this.Communicator.Send(sender, responseMessage);
						break;
					}
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
		/// Called when a new connection was rejected.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="reason"></param>
		private void OnConnectionRejected(BarracksConnection conn, string reason)
		{
			Log.Info("Connection rejected from '{0}'. Reason: {1}", conn.Address, reason);
		}

		/// <summary>
		/// Checks for potential updates for the database.
		/// </summary>
		private void CheckDatabaseUpdates()
		{
			Log.Info("Checking for updates...");

			// We had an issue with our update names, and to ensure that we
			// don't break everyone's update history, we'll temporarily fix
			// the update names on the fly. This should be removed at some
			// point in the future.
			this.Database.NormalizeUpdateNames();

			var enumOptions = new EnumerationOptions { RecurseSubdirectories = true, MatchCasing = MatchCasing.CaseInsensitive };
			var filePaths = Directory.GetFiles("sql/updates/", "*.sql", enumOptions).OrderBy(a => a);

			var updateFiles = new Dictionary<string, string>();
			foreach (var filePath in filePaths)
			{
				var updateName = Path.GetFileName(filePath);
				var normalizedName = updateName.ToLower().Replace("update-", "update_");

				if (this.Database.CheckUpdate(normalizedName))
					continue;

				Log.Info("Update '{0}' found, executing...", updateName);
				this.Database.RunUpdate(normalizedName, File.ReadAllText(filePath));
			}
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
