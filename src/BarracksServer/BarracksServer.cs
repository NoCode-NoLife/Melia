using System;
using System.IO;
using System.Linq;
using Melia.Barracks.Database;
using Melia.Barracks.Network;
using Melia.Barracks.Util;
using Melia.Shared;
using Melia.Shared.Data.Database;
using Melia.Shared.IES;
using Yggdrasil.Logging;
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
			ConsoleUtil.WriteHeader(ConsoleHeader.ProjectName, "Barracks", ConsoleColor.Magenta, ConsoleHeader.Logo, ConsoleHeader.Credits);
			ConsoleUtil.LoadingTitle();

			this.NavigateToRoot();

			// Load data
			this.LoadConf();
			this.LoadLocalization(this.Conf);
			this.LoadData(ServerType.Barracks);
			this.LoadServerList(this.Data.ServerDb);
			this.InitDatabase(this.Database, this.Conf);
			this.CheckDatabaseUpdates();
			this.ClearLoginStates();

			// Get server data
			var serverId = this.GetServerId(args);
			var serverInfo = this.GetServerInfo(ServerType.Barracks, serverId);

			// Start listener
			_acceptor = new TcpConnectionAcceptor<BarracksConnection>(serverInfo.Port);
			_acceptor.ConnectionAccepted += this.OnConnectionAccepted;
			_acceptor.Listen();

			Log.Status("Server ready, listening on {0}.", _acceptor.Address);

			ConsoleUtil.RunningTitle();
			new BarracksConsoleCommands().Wait();
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
	}
}
