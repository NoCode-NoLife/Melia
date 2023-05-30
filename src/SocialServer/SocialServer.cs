using System;
using System.Threading;
using Melia.Shared;
using Melia.Shared.Data.Database;
using Melia.Shared.Network;
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
		public PacketHandler PacketHandler { get; } = new PacketHandler();

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
		public UserManager AccountManager { get; } = new UserManager();

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
			ConsoleUtil.WriteHeader(ConsoleHeader.ProjectName, "Social", ConsoleColor.DarkGreen, ConsoleHeader.Logo, ConsoleHeader.Credits);
			ConsoleUtil.LoadingTitle();

			// Set up social server specific logging or we might run into
			// issues with multiple servers trying to write files at the
			// same time.
			if (args.Length != 0)
			{
				var serverId = this.GetServerId(args);
				Log.Init("SocialServer" + serverId);
			}

			this.NavigateToRoot();

			// Load data
			this.LoadConf();
			this.LoadLocalization(this.Conf);
			this.LoadData(ServerType.Social);
			this.LoadServerList(this.Data.ServerDb);
			this.InitDatabase(this.Database, this.Conf);

			// Get server data
			if (args.Length != 0)
			{
				var serverId = this.GetServerId(args);
				var serverInfo = this.GetServerInfo(ServerType.Social, serverId);

				// Start listener
				_acceptor = new TcpConnectionAcceptor<SocialConnection>(serverInfo.Ip, serverInfo.Port);
				_acceptor.ConnectionAccepted += this.OnConnectionAccepted;
				_acceptor.Listen();

				Log.Status("Server ready, listening on {0}.", _acceptor.Address);
			}
			else
			{
				foreach (var serverInfo in this.ServerList.GetSocialServers())
				{
					// Start listener
					_acceptor = new TcpConnectionAcceptor<SocialConnection>(serverInfo.Ip, serverInfo.Port);
					_acceptor.ConnectionAccepted += this.OnConnectionAccepted;
					_acceptor.Listen();

					Log.Status("Server ready, listening on {0}.", _acceptor.Address);
				}
			}

			ConsoleUtil.RunningTitle();
			new ConsoleCommands().Wait();
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
