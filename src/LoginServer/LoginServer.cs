// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Login.Database;
using Melia.Login.Network;
using Melia.Login.Util;
using Melia.Shared;
using Melia.Shared.Database;
using Melia.Shared.Network;
using Melia.Shared.Util;
using Melia.Shared.Util.Commands;
using Melia.Shared.Util.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Login.Util.Configuration;

namespace Melia.Login
{
	public class LoginServer : Server
	{
		public static readonly LoginServer Instance = new LoginServer();

		/// <summary>
		/// Configuration.
		/// </summary>
		public LoginConf Conf { get; private set; }

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

			CliUtil.WriteHeader("Login", ConsoleColor.Magenta);
			CliUtil.LoadingTitle();

			// Data
			this.LoadData(DataToLoad.Jobs | DataToLoad.Maps | DataToLoad.Barracks | DataToLoad.Servers, true);

			// Conf
			this.LoadConf(this.Conf = new LoginConf());

			// Database
			this.InitDatabase(this.Database = new LoginDb(), this.Conf);

			// Check if there are any updates
			this.CheckDatabaseUpdates();

			// Packet handlers
			LoginPacketHandler.Instance.RegisterMethods();

			// Get server data
			var serverId = 1;
			var serverData = this.Data.ServerDb.FindLogin(serverId);
			if (serverData == null)
			{
				Log.Error("Server data not found. ({0})", serverId);
				CliUtil.Exit(1);
			}

			// Server
			var mgr = new ConnectionManager<LoginConnection>(serverData.Port);
			mgr.Start();

			// Ready
			CliUtil.RunningTitle();
			Log.Status("Server ready, listening on {0}.", mgr.Address);

			// Commands
			this.ConsoleCommands = new LoginConsoleCommands();
			this.ConsoleCommands.Wait();
		}

		private void CheckDatabaseUpdates()
		{
			Log.Info("Checking for updates...");

			var files = Directory.GetFiles("sql");
			foreach (var filePath in files.Where(file => Path.GetExtension(file).ToLower() == ".sql"))
				this.RunUpdate(Path.GetFileName(filePath));
		}

		private void RunUpdate(string updateFile)
		{
			if (LoginServer.Instance.Database.CheckUpdate(updateFile))
				return;

			Log.Info("Update '{0}' found, executing...", updateFile);

			LoginServer.Instance.Database.RunUpdate(updateFile);
		}
	}
}
