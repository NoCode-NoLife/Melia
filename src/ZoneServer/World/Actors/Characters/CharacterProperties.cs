using System;
using Melia.Shared.Tos.Const;
using Melia.Shared.ObjectProperties;
using Melia.Zone.Network;
using Yggdrasil.Util;
using Melia.Zone.Scripting;
using Melia.Zone.World.Items;
using Melia.Zone.Buffs;

namespace Melia.Zone.World.Actors.Characters
{
	/// <summary>
	/// A player character's properties.
	/// </summary>
	public class CharacterProperties : Properties
	{
		/// <summary>
		/// Returns the owner of the properties.
		/// </summary>
		public Character Character { get; }

		/// <summary>
		/// Gets or sets stamina, clamped between 0 and MaxStamina.
		/// </summary>
		public int Stamina
		{
			get => _stamina;
			set => _stamina = (int)Math2.Clamp(0, this.MaxStamina, value);
		}
		private int _stamina;

		/// <summary>
		/// Returns the character's maximum stamina (property MaxSta).
		/// </summary>
		public int MaxStamina => (int)this.GetFloat(PropertyName.MaxSta);

		/// <summary>
		/// Creates new instance for the character.
		/// </summary>
		/// <param name="character"></param>
		public CharacterProperties(Character character) : base("PC")
		{
			this.Character = character;
			this.AddDefaultProperties();
			this.InitEvents();
		}

		/// <summary>
		/// Sets up properties that every character has by default.
		/// </summary>
		public void AddDefaultProperties()
		{
			// We only need to set up properties that are calculated or
			// have min/max or non-default values. All others will be
			// created with default values as needed on demand.

			this.Create(new FloatProperty(PropertyName.Lv, 1, min: 1));

			this.Create(PropertyName.STR_JOB, "SCR_Get_Character_STR_JOB");
			this.Create(PropertyName.CON_JOB, "SCR_Get_Character_CON_JOB");
			this.Create(PropertyName.INT_JOB, "SCR_Get_Character_INT_JOB");
			this.Create(PropertyName.MNA_JOB, "SCR_Get_Character_MNA_JOB");
			this.Create(PropertyName.DEX_JOB, "SCR_Get_Character_DEX_JOB");

			this.Create(PropertyName.STR_ADD, "SCR_Get_Character_STR_ADD");
			this.Create(PropertyName.CON_ADD, "SCR_Get_Character_CON_ADD");
			this.Create(PropertyName.INT_ADD, "SCR_Get_Character_INT_ADD");
			this.Create(PropertyName.MNA_ADD, "SCR_Get_Character_MNA_ADD");
			this.Create(PropertyName.DEX_ADD, "SCR_Get_Character_DEX_ADD");

			this.Create(PropertyName.STR, "SCR_Get_Character_STR");
			this.Create(PropertyName.CON, "SCR_Get_Character_CON");
			this.Create(PropertyName.INT, "SCR_Get_Character_INT");
			this.Create(PropertyName.MNA, "SCR_Get_Character_MNA");
			this.Create(PropertyName.DEX, "SCR_Get_Character_DEX");

			this.Create(PropertyName.MaxSta, "SCR_Get_Character_MaxSta");
			this.Create(PropertyName.Sta_RunStart, "SCR_Get_Character_Sta_RunStart");
			this.Create(PropertyName.Sta_Run, "SCR_Get_Character_Sta_Run");
			this.Create(PropertyName.Sta_Recover, "SCR_Get_Character_Sta_Recover");
			this.Create(PropertyName.Sta_R_Delay, "SCR_Get_Character_Sta_R_Delay");
			this.Create(PropertyName.Sta_Runable, "SCR_Get_Character_Sta_Runable");
			this.Create(PropertyName.Sta_Jump, "SCR_Get_Character_Sta_Jump");
			this.Create(PropertyName.Sta_Step, "SCR_Get_Character_Sta_Step");

			// Don't set a max values for HP and SP initially, as that could cap the HP
			// during loading.
			this.Create(PropertyName.MHP, "SCR_Get_Character_MHP");
			this.Create(PropertyName.MSP, "SCR_Get_Character_MSP");
			this.Create(new FloatProperty(PropertyName.HP, min: 0));
			this.Create(new FloatProperty(PropertyName.SP, min: 0));

			this.Create(PropertyName.RHP, "SCR_Get_Character_RHP");
			this.Create(PropertyName.RSP, "SCR_Get_Character_RSP");
			this.Create(PropertyName.RHPTIME, "SCR_Get_Character_RHPTIME");
			this.Create(PropertyName.RSPTIME, "SCR_Get_Character_RSPTIME");

			this.Create(new FloatProperty(PropertyName.StatByLevel, min: 0));
			this.Create(new FloatProperty(PropertyName.StatByBonus, min: 0));
			this.Create(new FloatProperty(PropertyName.UsedStat, min: 0));
			this.Create(PropertyName.StatPoint, "SCR_Get_Character_StatPoint");
			this.Create(new StringProperty(PropertyName.AbilityPoint, "0")); // Why oh why did they make this a string >_>

			this.Create(PropertyName.MAXPATK, "SCR_Get_Character_MAXPATK");
			this.Create(PropertyName.MINPATK, "SCR_Get_Character_MINPATK");
			this.Create(PropertyName.MAXMATK, "SCR_Get_Character_MAXMATK");
			this.Create(PropertyName.MINMATK, "SCR_Get_Character_MINMATK");
			this.Create(PropertyName.MAXPATK_SUB, "SCR_Get_Character_MAXPATK_SUB");
			this.Create(PropertyName.MINPATK_SUB, "SCR_Get_Character_MINPATK_SUB");

			this.Create(PropertyName.DEF, "SCR_Get_Character_DEF");
			this.Create(PropertyName.MDEF, "SCR_Get_Character_MDEF");
			this.Create(PropertyName.CRTATK, "SCR_Get_Character_CRTATK");
			this.Create(PropertyName.CRTHR, "SCR_Get_Character_CRTHR");
			this.Create(PropertyName.CRTDR, "SCR_Get_Character_CRTDR");
			this.Create(PropertyName.HR, "SCR_Get_Character_HR");
			this.Create(PropertyName.DR, "SCR_Get_Character_DR");
			this.Create(PropertyName.BLK, "SCR_Get_Character_BLK");
			this.Create(PropertyName.BLK_BREAK, "SCR_Get_Character_BLK_BREAK");
			this.Create(PropertyName.SR, "SCR_Get_Character_SR");
			this.Create(PropertyName.SDR, "SCR_Get_Character_SDR");

			this.Create(PropertyName.MaxWeight, "SCR_Get_Character_MaxWeight");
			this.Create(PropertyName.NowWeight, "SCR_Get_Character_NowWeight");

			this.Create(PropertyName.MSPD, "SCR_Get_Character_MSPD");
			this.Create(PropertyName.JumpPower, "SCR_Get_Character_JumpPower");
			this.Create(PropertyName.CastingSpeed, "SCR_Get_Character_CastingSpeed");

			// TODO: These were probably added for testing purposes or to
			// reproduce logged packets. Can they be removed?
			this.Create(new FloatProperty(PropertyName.MovingShotable, 0));
			this.Create(new FloatProperty(PropertyName.HPDrain, 2));
			this.Create(new FloatProperty(PropertyName.BOOST, 1));
			this.Create(new FloatProperty(PropertyName.Const, 1.909859f));
			this.Create(new FloatProperty(PropertyName.CAST, 1));
		}

		/// <summary>
		/// Sets up auto updates for the default properties.
		/// </summary>
		/// <remarks>
		/// Call after all properties were loaded, as to not trigger
		/// auto-updates before all properties are in place.
		/// </remarks>
		public void InitAutoUpdates()
		{
			this.AutoUpdate("STR", new[] { "Lv", "STR_ADD", "STR_STAT", "STR_JOB" });
			this.AutoUpdate("CON", new[] { "Lv", "CON_ADD", "CON_STAT", "CON_JOB" });
			this.AutoUpdate("INT", new[] { "Lv", "INT_ADD", "INT_STAT", "INT_JOB" });
			this.AutoUpdate("MNA", new[] { "Lv", "MNA_ADD", "MNA_STAT", "MNA_JOB" });
			this.AutoUpdate("DEX", new[] { "Lv", "DEX_ADD", "DEX_STAT", "DEX_JOB" });
			this.AutoUpdate("STR_JOB", new[] { "Lv" });
			this.AutoUpdate("CON_JOB", new[] { "Lv" });
			this.AutoUpdate("INT_JOB", new[] { "Lv" });
			this.AutoUpdate("MNA_JOB", new[] { "Lv" });
			this.AutoUpdate("DEX_JOB", new[] { "Lv" });
			this.AutoUpdate("MHP", new[] { "Lv", "CON", "MHP_BM", "MHP_Bonus" });
			this.AutoUpdate("MSP", new[] { "Lv", "MNA", "MSP_BM", "MSP_Bonus" });
			this.AutoUpdate("StatPoint", new[] { "StatByLevel", "StatByBonus", "UsedStat" });
			this.AutoUpdate("MSPD", new[] { "MSPD_BM", "MSPD_Bonus" });
			this.AutoUpdate("CastingSpeed", new[] { "CastingSpeed_BM" });
			this.AutoUpdate("DEF", new[] { "Lv", "DEF_BM", "DEF_RATE_BM" });
			this.AutoUpdate("MDEF", new[] { "Lv", "MDEF_BM", "MDEF_RATE_BM" });
			this.AutoUpdate("CRTATK", new[] { "CRTATK_BM" });
			this.AutoUpdate("CRTHR", new[] { "Lv", "CRTHR_BM" });
			this.AutoUpdate("CRTDR", new[] { "Lv", "CRTDR_BM" });
			this.AutoUpdate("HR", new[] { "Lv", "STR", "HR_BM", "HR_RATE_BM" });
			this.AutoUpdate("DR", new[] { "Lv", "DEX", "DR_BM", "DR_RATE_BM" });
			this.AutoUpdate("BLK", new[] { "Lv", "CON", "BLK_BM", "BLK_RATE_BM" });
			this.AutoUpdate("BLK_BREAK", new[] { "Lv", "DEX", "BLK_BREAK_BM", "BLK_BREAK_RATE_BM" });
			this.AutoUpdate("SR", new[] { "SR_BM" });
			this.AutoUpdate("SDR", new[] { "SDR_BM" });
			this.AutoUpdate("MaxSta", new[] { "CON", "MAXSTA_Bonus", "MaxSta_BM" });
			this.AutoUpdate("Sta_Run", new[] { "DashRun" });
			this.AutoUpdate("Sta_Recover", new[] { "REST_BM", "RSta_BM" });
			this.AutoUpdate("MINPATK", new[] { "Lv", "STR", "PATK_BM", "MINPATK_BM", "PATK_MAIN_BM", "MINPATK_MAIN_BM", "PATK_RATE_BM", "MINPATK_RATE_BM", "PATK_MAIN_RATE_BM", "MINPATK_MAIN_RATE_BM" });
			this.AutoUpdate("MAXPATK", new[] { "Lv", "STR", "PATK_BM", "MAXPATK_BM", "PATK_MAIN_BM", "MAXPATK_MAIN_BM", "PATK_RATE_BM", "MAXPATK_RATE_BM", "PATK_MAIN_RATE_BM", "MAXPATK_MAIN_RATE_BM" });
			this.AutoUpdate("MINMATK", new[] { "Lv", "INT", "MATK_BM", "MINMATK_BM", "MATK_RATE_BM", "MINMATK_RATE_BM" });
			this.AutoUpdate("MAXMATK", new[] { "Lv", "INT", "MATK_BM", "MAXMATK_BM", "MATK_RATE_BM", "MAXMATK_RATE_BM" });

			this.AutoUpdateMax("HP", "MHP");
			this.AutoUpdateMax("SP", "MSP");
		}

		/// <summary>
		/// Sets up event subscriptions, to react to actions of the
		/// character with property updates.
		/// </summary>
		private void InitEvents()
		{
			// Update recovery times when the character sits down,
			// as those properties are affected by the sitting status.
			this.Character.SitStatusChanged += this.UpdateRecoveryTimes;

			// Subscribe to equipment changes, as any number of properties
			// might make use of equipment stats
			this.Character.Inventory.Equipped += this.OnEquipmentChanged;
			this.Character.Inventory.Unequipped += this.OnEquipmentChanged;

			// Subscribe to buff changes
			this.Character.Buffs.BuffStarted += this.OnBuffsChanged;
			this.Character.Buffs.BuffEnded += this.OnBuffsChanged;
		}

		/// <summary>
		/// Called when an item was equipped or equipped.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="item"></param>
		private void OnEquipmentChanged(Character character, Item item)
		{
			// We could possibly limit this to only update equip-related
			// properties, such as MINATK and MAXATK, but we don't want
			// to accidentally miss something, and users might do god
			// knows what with custom property calculations.

			this.InvalidateAll();
			Send.ZC_OBJECT_PROPERTY(this.Character);
		}

		/// <summary>
		/// Called when a buff was started or ended.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="buff"></param>
		private void OnBuffsChanged(ICombatEntity entity, Buff buff)
		{
			// Buffs come with a list of properties they affect,
			// but since we have no control over user customaization,
			// and because like 80% of them invalidate all properties
			// anyway, we'll just always refresh everything.

			this.InvalidateAll();
			Send.ZC_OBJECT_PROPERTY(this.Character);
		}

		/// <summary>
		/// Recalculates and updates HP and SP recovery time properties.
		/// </summary>
		/// <param name="character"></param>
		private void UpdateRecoveryTimes(Character character)
		{
			this.Invalidate(PropertyName.RHPTIME, PropertyName.RSPTIME);
			Send.ZC_OBJECT_PROPERTY(this.Character, PropertyName.RHPTIME, PropertyName.RSPTIME);
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
			if (!ScriptableFunctions.Character.TryGet(calcFuncName, out var func))
				throw new ArgumentException($"Scriptable character function '{calcFuncName}' not found.");

			return func(this.Character);
		}
	}
}
