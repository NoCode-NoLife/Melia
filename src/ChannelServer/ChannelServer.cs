using System;
using Melia.Channel.Database;
using Melia.Channel.Network;
using Melia.Channel.Scripting;
using Melia.Channel.Skills;
using Melia.Channel.Util;
using Melia.Channel.World;
using Melia.Shared;
using Melia.Shared.Network;
using Melia.Shared.Util;
using Melia.Shared.Util.Commands;
using Melia.Shared.Util.Configuration;

namespace Melia.Channel
{
	public class ChannelServer : Server
	{
		public static readonly ChannelServer Instance = new ChannelServer();

		/// <summary>
		/// Configuration.
		/// </summary>
		public Conf Conf { get; private set; }

		/// <summary>
		/// Login server's database.
		/// </summary>
		public ChannelDb Database { get; private set; }

		/// <summary>
		/// Channel's console commands.
		/// </summary>
		public ConsoleCommands ConsoleCommands { get; private set; }

		/// <summary>
		/// GM commands.
		/// </summary>
		public GmCommands GmCommands { get; private set; }

		/// <summary>
		/// The world~
		/// </summary>
		public WorldManager World { get; } = new WorldManager();

		/// <summary>
		/// Channel's script manager.
		/// </summary>
		public ScriptManager ScriptManager { get; } = new ScriptManager();

		/// <summary>
		/// Connection acceptor and manager.
		/// </summary>
		public ConnectionManager<ChannelConnection> ConnectionManager { get; private set; }

		/// <summary>
		/// Skill handler manager.
		/// </summary>
		public SkillHandlers SkillHandlers { get; } = new SkillHandlers();

		/// <summary>
		/// Starts the server.
		/// </summary>
		public override void Run()
		{
			base.Run();

			CliUtil.WriteHeader("Channel", ConsoleColor.DarkGreen);
			CliUtil.LoadingTitle();

			// Conf
			this.LoadConf(this.Conf = new Conf());

			// Database
			this.InitDatabase(this.Database = new ChannelDb(), this.Conf);

			// Data
			this.LoadData(DataToLoad.All, true);

			// GM Commands
			this.GmCommands = new GmCommands();

			// Packet handlers
			ChannelPacketHandler.Instance.RegisterMethods();

			// World
			Log.Info("Initializing world...");
			this.World.Initialize();
			Log.Info("  done loading {0} maps.", this.World.Count);

			// Script manager
			this.ScriptManager.Initialize();
			this.ScriptManager.Load();

			// Get channel data
			var serverId = 1;
			var serverData = this.Data.ServerDb.FindChannel(serverId);
			if (serverData == null)
			{
				Log.Error("Server data not found. ({0})", serverId);
				CliUtil.Exit(1);
			}

			// Server
			this.ConnectionManager = new ConnectionManager<ChannelConnection>(serverData.Ip, serverData.Port);
			this.ConnectionManager.Start();

			// Ready
			CliUtil.RunningTitle();
			Log.Status("Server ready, listening on {0}.", this.ConnectionManager.Address);

			// Commands
			this.ConsoleCommands = new ConsoleCommands();
			this.ConsoleCommands.Wait();
		}
	}
}
