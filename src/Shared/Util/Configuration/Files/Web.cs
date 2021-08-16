// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

namespace Melia.Shared.Util.Configuration.Files
{
	/// <summary>
	/// Represents web.conf
	/// </summary>
	public class WebConfFile : ConfFile
	{
		public string Ip { get; protected set; }
		public int Port { get; protected set; }

		public void Load()
		{
			this.Require("system/conf/web.conf");

			this.Ip = this.GetString("ip", "127.0.0.1");
			this.Port = this.GetInt("port", 80);
		}
	}
}
