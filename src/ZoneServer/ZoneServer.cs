using System;
using Melia.Shared;
using Melia.Shared.Data.Database;
using Melia.Zone.Buffs;
using Melia.Zone.Commands;
using Melia.Zone.Database;
using Melia.Zone.Network;
using Melia.Zone.Skills;
using Melia.Zone.Util;
using Melia.Zone.World;
using Yggdrasil.Logging;
using Yggdrasil.Network.TCP;
using Yggdrasil.Util;
using Yggdrasil.Util.Commands;

namespace Melia.Zone
{
	/// <summary>
	/// Represents a zone server.
	/// </summary>
	public class ZoneServer : Server
	{
		public readonly static ZoneServer Instance = new ZoneServer();

		private TcpConnectionAcceptor<ZoneConnection> _acceptor;

		/// <summary>
		/// Returns a reference to the server's packet handlers.
		/// </summary>
		public PacketHandler PacketHandler { get; } = new PacketHandler();

		/// <summary>
		/// Returns reference to the server's database interface.
		/// </summary>
		public ZoneDb Database { get; } = new ZoneDb();

		/// <summary>
		/// Returns reference to the server's world manager.
		/// </summary>
		public WorldManager World { get; } = new WorldManager();

		/// <summary>
		/// Returns reference to the server's skill handlers.
		/// </summary>
		public SkillHandlers SkillHandlers { get; } = new SkillHandlers();

		/// <summary>
		/// Returns reference to the server's buff handlers.
		/// </summary>
		public BuffHandlers BuffHandlers { get; } = new BuffHandlers();

		/// <summary>
		/// Returns reference to the server's buff handlers.
		/// </summary>
		public ChatCommands ChatCommands { get; } = new ChatCommands();

		/// <summary>
		/// Runs the server.
		/// </summary>
		/// <param name="args"></param>
		public override void Run(string[] args)
		{
			ConsoleUtil.WriteHeader(ConsoleHeader.ProjectName, "Zone", ConsoleColor.DarkGreen, ConsoleHeader.Logo, ConsoleHeader.Credits);
			ConsoleUtil.LoadingTitle();

			this.NavigateToRoot();

			// Load data
			this.LoadConf();
			this.LoadLocalization(this.Conf);
			this.LoadData();
			this.LoadServerList(this.Data.ServerDb);
			this.InitDatabase(this.Database, this.Conf);
			this.InitWorld();
			this.LoadScripts("system/scripts/scripts_zone.txt");

			// Get server data
			var serverInfo = this.GetServerInfo(ServerType.Zone, args);

			// Start listener
			_acceptor = new TcpConnectionAcceptor<ZoneConnection>(serverInfo.Ip, serverInfo.Port);
			_acceptor.ConnectionAccepted += this.OnConnectionAccepted;
			_acceptor.Listen();

			Log.Status("Server ready, listening on {0}.", _acceptor.Address);

			ConsoleUtil.RunningTitle();
			new ConsoleCommands().Wait();
		}

		/// <summary>
		/// Loads maps ad initializes them.
		/// </summary>
		private void InitWorld()
		{
			Log.Info("Initializing world...");
			this.World.Initialize();
			Log.Info("  done loading {0} maps.", this.World.Count);
		}

		/// <summary>
		/// Called when a new connection is accepted.
		/// </summary>
		/// <param name="conn"></param>
		private void OnConnectionAccepted(ZoneConnection conn)
		{
			Log.Info("New connection accepted from '{0}'.", conn.Address);
		}
	}
}
