// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

namespace Melia.Shared.Util.Configuration.Files
{
	/// <summary>
	/// Represents world.conf
	/// </summary>
	public class WorldConfFile : ConfFile
	{
		public float ExpRate { get; protected set; }
		public float ClassExpRate { get; protected set; }

		public void Load()
		{
			this.Require("system/conf/world.conf");

			this.ExpRate = this.GetFloat("exp_rate", 100);
			this.ClassExpRate = this.GetFloat("class_exp_rate", 100);
		}
	}
}
