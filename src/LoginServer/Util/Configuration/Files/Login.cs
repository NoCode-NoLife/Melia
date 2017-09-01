// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using Melia.Shared.Util;
using Melia.Shared.Util.Configuration;
using Melia.Shared.World;

namespace Melia.Login.Util.Configuration.Files
{
	/// <summary>
	/// Represents login.conf
	/// </summary>
	public class LoginConfFile : ConfFile
	{
		public void Load()
		{
			this.Require("system/conf/login.conf");
		}
	}
}
