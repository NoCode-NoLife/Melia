using Melia.Shared.Tos.Const;
using Melia.Shared.ObjectProperties;
using Melia.Shared.Data.Database;

namespace Melia.Zone.World.Actors.Monsters
{
	/// <summary>
	/// Represents a monster's properties.
	/// </summary>
	public class MonsterProperties : Properties
	{
		/// <summary>
		/// Returns the monster the properties belong to.
		/// </summary>
		public Mob Monster { get; }

		/// <summary>
		/// Creates new instance for monster.
		/// </summary>
		/// <param name="monster"></param>
		public MonsterProperties(Mob monster) : base("Monster")
		{
			this.Monster = monster;
			this.AddDefaultProperties();
		}

		/// <summary>
		/// Adds the monster's default properties.
		/// </summary>
		private void AddDefaultProperties()
		{
			this.Create(new FloatProperty(PropertyName.WlkMSPD, this.Monster.Data.WalkSpeed));
			this.Create(new FloatProperty(PropertyName.RunMSPD, this.Monster.Data.RunSpeed));
			this.Create(new CFloatProperty(PropertyName.MSPD, this.GetMSPD));

			this.InvalidateAll();
		}

		/// <summary>
		/// Returns the monster's movement speed.
		/// </summary>
		/// <returns></returns>
		private float GetMSPD()
		{
			var fixMspd = this.GetFloat(PropertyName.FIXMSPD_BM);
			if (fixMspd != 0)
				return fixMspd;

			return this.GetFloat(PropertyName.WlkMSPD);
		}
	}
}
