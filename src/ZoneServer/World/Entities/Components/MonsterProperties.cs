using Melia.Shared.World.ObjectProperties;

namespace Melia.Zone.World.Entities.Components
{
	/// <summary>
	/// Represents a monster's properties.
	/// </summary>
	public class MonsterProperties : Properties
	{
		/// <summary>
		/// Returns the monster the properties belong to.
		/// </summary>
		public MonsterLegacy Monster { get; }

		/// <summary>
		/// Creates new instance for monster.
		/// </summary>
		/// <param name="monster"></param>
		public MonsterProperties(MonsterLegacy monster) : base("Monster")
		{
			this.Monster = monster;
			this.AddDefaultProperties();
		}

		/// <summary>
		/// Adds the monster's default properties.
		/// </summary>
		private void AddDefaultProperties()
		{
			this.Create(new FloatProperty("WlkMSPD", this.Monster.Data.WalkSpeed));
			this.Create(new FloatProperty("RunMSPD", this.Monster.Data.RunSpeed));
			this.Create(new CFloatProperty("MSPD", this.GetMSPD));

			this.RecalculateAll();
		}

		/// <summary>
		/// Returns the monster's movement speed.
		/// </summary>
		/// <returns></returns>
		private float GetMSPD()
		{
			return this.GetFloat("WlkMSPD");
		}
	}
}
