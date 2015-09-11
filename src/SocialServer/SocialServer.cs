// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Shared;
using Melia.Shared.Database;
using Melia.Shared.Network;
using Melia.Shared.Util;
using Melia.Shared.Util.Commands;
using Melia.Shared.Util.Configuration;
using Melia.Social.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Social
{
	public class SocialServer : Server
	{
		public static readonly SocialServer Instance = new SocialServer();

		/// <summary>
		/// Social server's database.
		/// </summary>
		//public SocialDb Database { get; private set; }

		/// <summary>
		/// Social's console commands.
		/// </summary>
		public ConsoleCommands ConsoleCommands { get; private set; }

		/// <summary>
		/// Starts the server.
		/// </summary>
		public override void Run()
		{
			base.Run();

			Cmd.WriteHeader("Social", ConsoleColor.DarkCyan);
			Cmd.LoadingTitle();

			// Conf
			this.LoadConf();

			// Database
			//this.Database = new SocialDb();
			//this.InitDatabase(this.Database);

			// Data
			this.LoadData(DataToLoad.All, true);

			// Packet handlers
			SocialPacketHandler.Instance.RegisterMethods();

			// Server
			var mgr = new ConnectionManager<SocialConnection>(2002);
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
