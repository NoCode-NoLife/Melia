using Melia.Shared.Tos.Const;
using Melia.Shared.World.ObjectProperties;

namespace Melia.Channel.World.Entities.Components
{
	/// <summary>
	/// Represents a monster's properties.
	/// </summary>
	public class MonsterProperties : Properties
	{
		/// <summary>
		/// Returns the monster the properties belong to.
		/// </summary>
		public Monster Monster { get; }

		/// <summary>
		/// Creates new instance for monster.
		/// </summary>
		/// <param name="monster"></param>
		public MonsterProperties(Monster monster)
		{
			this.Monster = monster;
			this.AddDefaultProperties();
		}

		/// <summary>
		/// Adds the monster's default properties.
		/// </summary>
		private void AddDefaultProperties()
		{
			this.Add(new FloatProperty(PropertyId.Monster.WlkMSPD, this.Monster.Data.WalkSpeed));
			this.Add(new FloatProperty(PropertyId.Monster.RunMSPD, this.Monster.Data.RunSpeed));
			this.Add(new CalculatedFloatProperty(PropertyId.Monster.MSPD, this.GetMSPD));

			this.UpdateCalculated();
		}

		/// <summary>
		/// Returns the monster's movement speed.
		/// </summary>
		/// <returns></returns>
		private float GetMSPD()
		{
			return this.GetFloat(PropertyId.Monster.WlkMSPD);
		}
	}
}
