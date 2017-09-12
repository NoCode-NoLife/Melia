// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System.Collections.Generic;

namespace Melia.Shared.Util.Configuration.Files
{
	public class CommandsConfFile : ConfFile
	{
		/// <summary>
		/// Prefix for normal commands.
		/// </summary>
		public string Prefix { get; protected set; }

		/// <summary>
		/// Prefix for character commands.
		/// </summary>
		public string Prefix2 { get; protected set; }

		/// <summary>
		/// List of commands and their authority levels.
		/// </summary>
		public Dictionary<string, CommandAuthConf> Auth { get; protected set; }

		public void Load()
		{
			this.Require("system/conf/commands.conf");

			// Prefix
			this.Prefix = this.GetString("prefix", "/").Substring(0, 1);
			this.Prefix2 = this.Prefix + this.Prefix;

			// Commands
			this.Auth = new Dictionary<string, CommandAuthConf>();

			foreach (var option in _options)
			{
				if (option.Key == "prefix")
					continue;

				var sAuth = option.Value.Split(',');
				if (sAuth.Length < 2)
				{
					Log.Error("CommandsConfFile.Load: Commands need 2 auth settings, '{0}' has less.", option.Key);
					continue;
				}

				if (!int.TryParse(sAuth[0], out var auth1) || !int.TryParse(sAuth[1], out var auth2))
				{
					Log.Error("CommandsConfFile.Load: Unable to parse auth for '{0}'.", option.Key);
					continue;
				}

				this.Auth[option.Key.Trim()] = new CommandAuthConf(auth1, auth2);
			}
		}

		/// <summary>
		/// Returns auth for command, or a new auth with auth levels being 99
		/// if the command wasn't found in the config.
		/// </summary>
		/// <param name="command"></param>
		/// <param name="defaultAuth"></param>
		/// <param name="defaultCharAuth"></param>
		/// <returns></returns>
		public CommandAuthConf GetAuth(string command)
		{
			this.Auth.TryGetValue(command, out var result);
			if (result == null)
				result = new CommandAuthConf(99, 99);

			return result;
		}
	}

	public class CommandAuthConf
	{
		public int Auth, CharAuth;

		public CommandAuthConf(int auth, int charAuth)
		{
			this.Auth = auth;
			this.CharAuth = charAuth;
		}
	}
}
