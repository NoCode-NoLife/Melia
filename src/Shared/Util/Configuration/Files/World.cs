namespace Melia.Shared.Util.Configuration.Files
{
	/// <summary>
	/// Represents world.conf
	/// </summary>
	public class WorldConfFile : ConfFile
	{
		public float DropRate { get; protected set; }
		public int DropRadius { get; protected set; }
		public int PickUpRadius { get; protected set; }
		public int LootPrectionSeconds { get; protected set; }
		public int DropDisappearSeconds { get; protected set; }
		public bool Littering { get; protected set; }

		public float ExpRate { get; protected set; }
		public float ClassExpRate { get; protected set; }

		public void Load()
		{
			this.Require("system/conf/world.conf");

			this.DropRate = this.GetFloat("drop_rate", 100);
			this.DropRadius = this.GetInt("drop_radius", 25);
			this.PickUpRadius = this.GetInt("pick_up_radius", 100);
			this.LootPrectionSeconds = this.GetInt("loot_protection", 100);
			this.DropDisappearSeconds = this.GetInt("drop_disappear_time", 100);
			this.Littering = this.GetBool("littering", false);

			this.ExpRate = this.GetFloat("exp_rate", 100);
			this.ClassExpRate = this.GetFloat("class_exp_rate", 100);
		}
	}
}
