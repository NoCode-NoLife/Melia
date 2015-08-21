// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Login.Database;
using Melia.Login.Network;
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

namespace Melia.Login
{
	public class LoginServer : Server
	{
		public static readonly LoginServer Instance = new LoginServer();

		/// <summary>
		/// Login server's database.
		/// </summary>
		public LoginDb Database { get; private set; }

		/// <summary>
		/// Login's console commands.
		/// </summary>
		public ConsoleCommands ConsoleCommands { get; private set; }

		/// <summary>
		/// Starts the server.
		/// </summary>
		public override void Run()
		{
			base.Run();

			Cmd.WriteHeader("Login", ConsoleColor.Magenta);
			Cmd.LoadingTitle();

			// Conf
			this.LoadConf();

			// Database
			this.Database = new LoginDb();
			this.InitDatabase(this.Database);

			// Packet handlers
			LoginPacketHandler.Instance.RegisterMethods();

			// Server
			var mgr = new ConnectionManager<LoginConnection>(2000);
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
