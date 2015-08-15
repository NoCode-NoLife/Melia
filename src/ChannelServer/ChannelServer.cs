using Melia.Channel.Network;
using Melia.Shared;
using Melia.Shared.Database;
using Melia.Shared.Network;
using Melia.Shared.Util;
using Melia.Shared.Util.Commands;
using Melia.Shared.Util.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Channel
{
	public class ChannelServer : Server
	{
		public static readonly ChannelServer Instance = new ChannelServer();

		/// <summary>
		/// Channel's console commands.
		/// </summary>
		public ConsoleCommands ConsoleCommands { get; private set; }

		/// <summary>
		/// Starts the server.
		/// </summary>
		public override void Run()
		{
			base.Run();

			Cmd.WriteHeader("Channel", ConsoleColor.DarkGreen);
			Cmd.LoadingTitle();

			// Conf
			this.LoadConf();

			// Database
			this.InitDatabase();

			// Packet handlers
			ChannelPacketHandler.Instance.RegisterMethods();

			// Server
			var mgr = new ConnectionManager<ChannelConnection>(2001);
			mgr.Start();

			// Ready
			Cmd.RunningTitle();
			Log.Status("Server ready, listening on {0}.", mgr.Address);

			// Commands
			this.ConsoleCommands = new ConsoleCommands();
			this.ConsoleCommands.Wait();
		}
	}
}
