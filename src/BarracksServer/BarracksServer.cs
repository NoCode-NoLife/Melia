using System;
using Melia.Barracks.Database;
using Melia.Barracks.Network;
using Melia.Barracks.Util;
using Melia.Shared;
using Melia.Shared.Data.Database;
using Yggdrasil.Logging;
using Yggdrasil.Network.TCP;
using Yggdrasil.Util;
using Yggdrasil.Util.Commands;

namespace Melia.Barracks
{
	/// <summary>
	/// Represents the barracks server.
	/// </summary>
	public class BarracksServer : Server2
	{
		/// <summary>
		/// Returns global instance of the barracks server.
		/// </summary>
		public static BarracksServer Instance = new BarracksServer();

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
			this.LoadData();
			this.LoadServerList(this.Data.ServerDb);
			this.InitDatabase(this.Database, this.Conf);

			// Get server data
			var serverInfo = this.GetServerInfo(ServerType.Barracks, args);

			// Start listener
			_acceptor = new TcpConnectionAcceptor<BarracksConnection>(serverInfo.Ip, serverInfo.Port);
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
	}
}
