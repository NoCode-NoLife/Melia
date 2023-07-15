using System;
using System.Threading;
using Melia.Shared;
using Melia.Shared.Data.Database;
using Melia.Shared.IES;
using Melia.Shared.Network;
using Melia.Shared.Network.Inter.Messages;
using Melia.Zone.Buffs;
using Melia.Zone.Commands;
using Melia.Zone.Database;
using Melia.Zone.Events;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers;
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
			ConsoleUtil.WriteHeader(ConsoleHeader.ProjectName, "Zone", ConsoleColor.DarkGreen, ConsoleHeader.Logo, ConsoleHeader.Credits);
			ConsoleUtil.LoadingTitle();

			// Set up zone server specific logging or we might run into
			// issues with multiple servers trying to write files at the
			// same time.
			this.GetServerId(args, out var groupId, out var serverId);
			Log.Init("ZoneServer" + serverId);

			this.NavigateToRoot();

			this.LoadConf();
			this.LoadLocalization(this.Conf);
			this.LoadData(ServerType.Zone);
			this.LoadServerList(this.Data.ServerDb, ServerType.Zone, groupId, serverId);
			this.InitDatabase(this.Database, this.Conf);
			this.InitSkills();
			this.InitWorld();
			this.LoadScripts("system/scripts/scripts_zone.txt");
			this.LoadIesMods();

			this.StartAcceptor();

			ConsoleUtil.RunningTitle();
			new ConsoleCommands().Wait();
		}

		/// <summary>
		/// Starts accepting connections.
		/// </summary>
		private void StartAcceptor()
		{
			_acceptor = new TcpConnectionAcceptor<ZoneConnection>(this.ServerInfo.Port);
			_acceptor.ConnectionAccepted += this.OnConnectionAccepted;
			_acceptor.Listen();

			Log.Status("Server ready, listening on {0}.", _acceptor.Address);
		}

		/// <summary>
		/// Loads skill handlers.
		/// </summary>
		private void InitSkills()
		{
			Log.Info("Initializing skills...");
			this.SkillHandlers.Init();
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
		/// Sets up IES mods.
		/// </summary>
		private void LoadIesMods()
		{
			// This method is temporary until we have a more proper way
			// way of handling IES mods.

			// Centurion was apparently disabled during the beta phase
			// in 2015 and replaced with Fencer, and while it was supposed
			// get added back in on a higher rank, that never happened (?).
			// To enable it, we need to adjust the job rank to make it
			// selectable and give the skills a max level.
			if (!Feature.IsEnabled("CenturionRemoved"))
			{
				this.IesMods.Add("Job", 1005, "Rank", 2);
				this.IesMods.Add("SkillTree", 10502, "MaxLevel", 5);
				this.IesMods.Add("SkillTree", 10503, "MaxLevel", 5);
				this.IesMods.Add("SkillTree", 10504, "MaxLevel", 5);
				this.IesMods.Add("SkillTree", 10505, "MaxLevel", 5);
				this.IesMods.Add("SkillTree", 10506, "MaxLevel", 5);
				this.IesMods.Add("SkillTree", 10507, "MaxLevel", 5);
				this.IesMods.Add("SkillTree", 10508, "MaxLevel", 5);
				this.IesMods.Add("SkillTree", 10509, "MaxLevel", 5);
			}
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
