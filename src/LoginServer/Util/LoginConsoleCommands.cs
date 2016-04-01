// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Shared.Util;
using Melia.Shared.Util.Commands;
using System.Collections.Generic;

namespace Melia.Login.Util
{
	public class LoginConsoleCommands : ConsoleCommands
	{
		public LoginConsoleCommands()
		{
			this.Add("auth", "<account> <level>", "Changes authority level of account", HandleAuth);
			this.Add("passwd", "<account> <password>", "Changes password of account", HandlePasswd);
		}

		private CommandResult HandleAuth(string command, IList<string> args)
		{
			if (args.Count < 3)
				return CommandResult.InvalidArgument;

			var accountName = args[1];

			int level;
			if (!int.TryParse(args[2], out level))
				return CommandResult.InvalidArgument;

			if (!LoginServer.Instance.Database.AccountExists(accountName))
			{
				Log.Error("Please specify an existing account.");
				return CommandResult.Okay;
			}

			if (!LoginServer.Instance.Database.ChangeAuth(accountName, level))
			{
				Log.Error("Failed to change auth.");
				return CommandResult.Okay;
			}

			Log.Info("Changed auth successfully.");

			return CommandResult.Okay;
		}

		private CommandResult HandlePasswd(string command, IList<string> args)
		{
			if (args.Count < 3)
			{
				return CommandResult.InvalidArgument;
			}

			var accountName = args[1];
			var password = args[2];

			if (!LoginServer.Instance.Database.AccountExists(accountName))
			{
				Log.Error("Please specify an existing account.");
				return CommandResult.Okay;
			}

			LoginServer.Instance.Database.SetAccountPassword(accountName, password);

			Log.Info("Password change for {0} complete.", accountName);

			return CommandResult.Okay;
		}
	}
}
