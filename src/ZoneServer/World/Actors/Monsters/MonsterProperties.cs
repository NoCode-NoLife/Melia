using System;
using Melia.Shared.Data.Database;
using Melia.Shared.ObjectProperties;
using Melia.Shared.Game.Const;
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

			this.Create(PropertyName.MHP, "SCR_Get_MON_MHP");
			this.Create(new FloatProperty(PropertyName.HP, min: 0));

			this.Create(PropertyName.MSP, "SCR_Get_MON_MSP");
			this.Create(new FloatProperty(PropertyName.SP, min: 0));

			this.Create(PropertyName.MINPATK, "SCR_Get_MON_MINPATK");
			this.Create(PropertyName.MAXPATK, "SCR_Get_MON_MAXPATK");
			this.Create(PropertyName.MINMATK, "SCR_Get_MON_MINMATK");
			this.Create(PropertyName.MAXMATK, "SCR_Get_MON_MAXMATK");
			this.Create(PropertyName.DEF, "SCR_Get_MON_DEF");
			this.Create(PropertyName.MDEF, "SCR_Get_MON_MDEF");
			this.Create(PropertyName.DR, "SCR_Get_MON_DR");
			this.Create(PropertyName.HR, "SCR_Get_MON_HR");
			this.Create(PropertyName.SR, "SCR_Get_MON_SR");
			this.Create(PropertyName.SDR, "SCR_Get_MON_SDR");
			this.Create(PropertyName.CRTHR, "SCR_Get_MON_CRTHR");
			this.Create(PropertyName.CRTDR, "SCR_Get_MON_CRTDR");
			this.Create(PropertyName.CRTATK, "SCR_Get_MON_CRTATK");
			this.Create(PropertyName.BLK, "SCR_Get_MON_BLK");
			this.Create(PropertyName.BLK_BREAK, "SCR_Get_MON_BLK_BREAK");

			this.Create(new FloatProperty(PropertyName.WlkMSPD, this.Monster.Data.WalkSpeed));
			this.Create(new FloatProperty(PropertyName.RunMSPD, this.Monster.Data.RunSpeed));
			this.Create(PropertyName.MSPD, "SCR_Get_MON_MSPD");

			this.Create(new RFloatProperty(PropertyName.Attribute, () => (int)this.Monster.Data.Attribute));
			this.Create(new RFloatProperty(PropertyName.ArmorMaterial, () => (int)this.Monster.Data.ArmorMaterial));
		}

		/// <summary>
		/// Initializes the auto-updates for the monster's properties.
		/// </summary>
		public void InitAutoUpdates()
		{
			this.AutoUpdate(PropertyName.MHP, [PropertyName.MHP_BM]);
			this.AutoUpdate(PropertyName.MSP, [PropertyName.MSP_BM]);
			this.AutoUpdate(PropertyName.MINPATK, [PropertyName.PATK_BM]);
			this.AutoUpdate(PropertyName.MAXPATK, [PropertyName.PATK_BM]);
			this.AutoUpdate(PropertyName.MINMATK, [PropertyName.MATK_BM]);
			this.AutoUpdate(PropertyName.MAXMATK, [PropertyName.MATK_BM]);
			this.AutoUpdate(PropertyName.DEF, [PropertyName.DEF_BM]);
			this.AutoUpdate(PropertyName.MDEF, [PropertyName.MDEF_BM]);
			this.AutoUpdate(PropertyName.MSPD, [PropertyName.FIXMSPD_BM, PropertyName.WlkMSPD, PropertyName.RunMSPD, PropertyName.MSPD_BM]);
			this.AutoUpdate(PropertyName.SR, [PropertyName.SR_BM]);
			this.AutoUpdate(PropertyName.SDR, [PropertyName.SDR_BM]);

			this.AutoUpdateMax(PropertyName.HP, PropertyName.MHP);
			this.AutoUpdateMax(PropertyName.SP, PropertyName.MSP);
		}

		/// <summary>
		/// Creates a new calculated float property that uses the given
		/// function.
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="calcFuncName"></param>
		private void Create(string propertyName, string calcFuncName)
		{
			this.Create(new CFloatProperty(propertyName, () => this.CalculateProperty(calcFuncName)));
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
