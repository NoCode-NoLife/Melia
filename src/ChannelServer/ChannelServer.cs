// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Channel.Database;
using Melia.Channel.Network;
using Melia.Channel.Scripting;
using Melia.Channel.Util;
using Melia.Channel.World;
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
using Melia.Channel.World.SkillHandlers;

namespace Melia.Channel
{
	public class ChannelServer : Server
	{
		public static readonly ChannelServer Instance = new ChannelServer();

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
		public WorldManager World { get; private set; }

		/// <summary>
		/// Channel's script manager.
		/// </summary>
		public ScriptManager ScriptManager { get; private set; }

		/// <summary>
		/// Connection acceptor and manager.
		/// </summary>
		public ConnectionManager<ChannelConnection> ConnectionManager { get; private set; }

		public Dictionary<int, SkillHandler> SkillHandlers { get; private set; }

		public Random rnd { get; set; }

		/// <summary>
		/// Creates new channel server.
		/// </summary>
		private ChannelServer()
		{
			this.World = new WorldManager();
			this.ScriptManager = new ScriptManager();
			this.SkillHandlers = new Dictionary<int, SkillHandler>();

			this.LoadSkillEffects();

			rnd = new Random();
		}

		private void LoadSkillEffects()
		{
			SkillHandler skillHandler;
			skillHandler = new Heal();
			this.SkillHandlers.Add(40001, skillHandler);
			skillHandler = new Cure();
			this.SkillHandlers.Add(40002, skillHandler);
			skillHandler = new BuffSkill();
			this.SkillHandlers.Add(40003, skillHandler);
			skillHandler = new BuffSkill();
			this.SkillHandlers.Add(40004, skillHandler);
			skillHandler = new Melee();
			this.SkillHandlers.Add(100, skillHandler);

		}

		/// <summary>
		/// Starts the server.
		/// </summary>
		public override void Run()
		{
			base.Run();

			CliUtil.WriteHeader("Channel", ConsoleColor.DarkGreen);
			CliUtil.LoadingTitle();

			// Conf
			this.LoadConf();

			// Database
			this.Database = new ChannelDb();
			this.InitDatabase(this.Database);

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
			this.ConnectionManager = new ConnectionManager<ChannelConnection>(serverData.Port);
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
