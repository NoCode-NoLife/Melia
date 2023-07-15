using System;
using Melia.Shared.ObjectProperties;
using Melia.Shared.Tos.Const;
using Melia.Zone.Scripting;

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
		/// Returns the monster's override properties.
		/// </summary>
		/// <remarks>
		/// Can be used to override calculated properties that, under the
		/// condition that the property calculation function in question
		/// checks for available overrides.
		/// </remarks>
		public Properties Overrides { get; } = new Properties("Monster");

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
			this.Create(new RFloatProperty(PropertyName.Level, () => this.Monster.Data.Level));

			this.Create(new CFloatProperty(PropertyName.MHP, () => this.CalculateProperty("SCR_Get_MON_MHP")));
			this.Create(new FloatProperty(PropertyName.HP, min: 0));

			this.Create(new CFloatProperty(PropertyName.MSP, () => this.CalculateProperty("SCR_Get_MON_MSP")));
			this.Create(new FloatProperty(PropertyName.SP, min: 0));

			this.Create(new CFloatProperty(PropertyName.MINPATK, () => this.CalculateProperty("SCR_Get_MON_MINPATK")));
			this.Create(new CFloatProperty(PropertyName.MAXPATK, () => this.CalculateProperty("SCR_Get_MON_MAXPATK")));
			this.Create(new CFloatProperty(PropertyName.MINMATK, () => this.CalculateProperty("SCR_Get_MON_MINMATK")));
			this.Create(new CFloatProperty(PropertyName.MAXMATK, () => this.CalculateProperty("SCR_Get_MON_MAXMATK")));
			this.Create(new CFloatProperty(PropertyName.DEF, () => this.CalculateProperty("SCR_Get_MON_DEF")));
			this.Create(new CFloatProperty(PropertyName.MDEF, () => this.CalculateProperty("SCR_Get_MON_MDEF")));
			this.Create(new CFloatProperty(PropertyName.DR, () => this.CalculateProperty("SCR_Get_MON_DR")));
			this.Create(new CFloatProperty(PropertyName.HR, () => this.CalculateProperty("SCR_Get_MON_HR")));
			this.Create(new CFloatProperty(PropertyName.SR, () => this.CalculateProperty("SCR_Get_MON_SR")));
			this.Create(new CFloatProperty(PropertyName.SDR, () => this.CalculateProperty("SCR_Get_MON_SDR")));

			this.Create(new FloatProperty(PropertyName.WlkMSPD, this.Monster.Data.WalkSpeed));
			this.Create(new FloatProperty(PropertyName.RunMSPD, this.Monster.Data.RunSpeed));
			this.Create(new CFloatProperty(PropertyName.MSPD, () => this.CalculateProperty("SCR_Get_MON_MSPD")));
		}

		/// <summary>
		/// Initializes the auto-updates for the monster's properties.
		/// </summary>
		public void InitAutoUpdates()
		{
			this.AutoUpdate(PropertyName.MHP, new[] { PropertyName.MHP_BM });
			this.AutoUpdate(PropertyName.MSP, new[] { PropertyName.MSP_BM });
			this.AutoUpdate(PropertyName.MINPATK, new[] { PropertyName.PATK_BM });
			this.AutoUpdate(PropertyName.MAXPATK, new[] { PropertyName.PATK_BM });
			this.AutoUpdate(PropertyName.MINMATK, new[] { PropertyName.MATK_BM });
			this.AutoUpdate(PropertyName.MAXMATK, new[] { PropertyName.MATK_BM });
			this.AutoUpdate(PropertyName.DEF, new[] { PropertyName.DEF_BM });
			this.AutoUpdate(PropertyName.MDEF, new[] { PropertyName.MDEF_BM });
			this.AutoUpdate(PropertyName.MSPD, new[] { PropertyName.FIXMSPD_BM, PropertyName.WlkMSPD, PropertyName.RunMSPD, PropertyName.MSPD_BM });
			this.AutoUpdate(PropertyName.SR, new[] { PropertyName.SR_BM });
			this.AutoUpdate(PropertyName.SDR, new[] { PropertyName.SDR_BM });

			this.AutoUpdateMax(PropertyName.HP, PropertyName.MHP);
			this.AutoUpdateMax(PropertyName.SP, PropertyName.MSP);
		}

		/// <summary>
		/// Calls the calculation function with the given name and returns
		/// the result.
		/// </summary>
		/// <param name="calcFuncName"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException">
		/// Thrown if the function doesn't exist.
		/// </exception>
		private float CalculateProperty(string calcFuncName)
		{
			// Custom calculation methods can be defined for monsters by
			// creating functions that are suffixed with the monster class
			// name. Note sure if we really need this for monsters... but
			// why not, right?
			// We could cache the functions to not have to look them up
			// every time, but it's almost certainly fine. Especially since
			// we already cache the properties.
			if (!ScriptableFunctions.Monster.TryGet(calcFuncName + "_" + this.Monster.Data.ClassName, out var func))
			{
				if (!ScriptableFunctions.Monster.TryGet(calcFuncName, out func))
					throw new ArgumentException($"Scriptable skill function '{calcFuncName}' not found.");
			}

			return func(this.Monster);
		}
	}
}
