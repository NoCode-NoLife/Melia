using System;
using Melia.Shared;
using Melia.Shared.Data.Database;
using Melia.Social.Commands;
using Melia.Social.Database;
using Melia.Social.Network;
using Melia.Social.World;
using Yggdrasil.Logging;
using Yggdrasil.Network.TCP;
using Yggdrasil.Util;
using Yggdrasil.Util.Commands;

namespace Melia.Social
{
	/// <summary>
	/// Represents a social server.
	/// </summary>
	public class SocialServer : Server
	{
		public readonly static SocialServer Instance = new SocialServer();

		private TcpConnectionAcceptor<SocialConnection> _acceptor;

		/// <summary>
		/// Returns a reference to the server's packet handlers.
		/// </summary>
		public PacketHandler PacketHandler { get; private set; }

		/// <summary>
		/// Returns reference to the server's database interface.
		/// </summary>
		public SocialDb Database { get; } = new SocialDb();

		/// <summary>
		/// Returns reference to the server's chat command handlers.
		/// </summary>
		public ChatCommands ChatCommands { get; } = new ChatCommands();

		/// <summary>
		/// Returns reference to the server's account manager.
		/// </summary>
		public UserManager UserManager { get; } = new UserManager();

		/// <summary>
		/// Returns reference to the server's chat manager.
		/// </summary>
		public ChatManager ChatManager { get; } = new ChatManager();

		/// <summary>
		/// Runs the server.
		/// </summary>
		/// <param name="args"></param>
		public override void Run(string[] args)
		{
			this.GetServerId(args, out var groupId, out var serverId);
			var title = string.Format("Social ({0}, {1})", groupId, serverId);

			ConsoleUtil.WriteHeader(ConsoleHeader.ProjectName, title, ConsoleColor.DarkCyan, ConsoleHeader.Logo, ConsoleHeader.Credits);
			ConsoleUtil.LoadingTitle();

			Log.Init($"SocialServer_{groupId}_{serverId}");

			this.NavigateToRoot();

			this.LoadConf();
			this.LoadLocalization(this.Conf);
			this.LoadData(ServerType.Social);
			this.LoadServerList(this.Data.ServerDb, ServerType.Social, groupId, serverId);
			this.InitDatabase(this.Database, this.Conf);
			this.LoadPacketHandler();
			this.LoadManagers();

			this.StartAcceptors();

			ConsoleUtil.RunningTitle();
			new ConsoleCommands().Wait();
		}

		/// <summary>
		/// Loads and initializes the server's managers.
		/// </summary>
		private void LoadManagers()
		{
			Log.Info("Loading information from the database...");

			this.UserManager.LoadUsers();
		}

		/// <summary>
		/// Initializes packet handler based on the server type.
		/// </summary>
		private void LoadPacketHandler()
		{
			if (this.ServerInfo.Id == 1)
				this.PacketHandler = new PacketHandlerChat();
			else
				this.PacketHandler = new PacketHandlerRelation();
		}

		/// <summary>
		/// Starts the server's TCP connection acceptors.
		/// </summary>
		private void StartAcceptors()
		{
			_acceptor = new TcpConnectionAcceptor<SocialConnection>(this.ServerInfo.Port);
			_acceptor.ConnectionAccepted += this.OnConnectionAccepted;
			_acceptor.Listen();

			Log.Status("Server ready, listening on {0}.", _acceptor.Address);
		}

		/// <summary>
		/// Called when a new connection is accepted.
		/// </summary>
		/// <param name="conn"></param>
		private void OnConnectionAccepted(SocialConnection conn)
		{
			Log.Info("New connection accepted from '{0}'.", conn.Address);
		}
	}
}
