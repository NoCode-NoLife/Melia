using System;
using Melia.Shared.Game.Const;
using Melia.Shared.ObjectProperties;
using Melia.Zone.Network;
using Yggdrasil.Util;
using Melia.Zone.Scripting;
using Melia.Zone.World.Items;
using Melia.Zone.Buffs;
using Melia.Shared.Data.Database;
using Yggdrasil.Logging;

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
		/// Returns the character's ability points based on the string
		/// property "AbilityPoint".
		/// </summary>
		public int AbilityPoints => int.Parse(this.GetString(PropertyName.AbilityPoint, "0"));

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

			this.Create(PropertyName.MovingShotable, "SCR_Get_Character_MovingShotable");
			this.Create(PropertyName.MovingShot, "SCR_Get_Character_MovingShot");

			this.Create(PropertyName.SkillRange, "SCR_Get_SkillRange");
			this.Create(PropertyName.Guardable, "SCR_Get_Character_Guardable");
			this.Create(PropertyName.LootingChance, "SCR_Get_Character_LootingChance");

			// TODO: Update damage bonus properties based on equipment and
			//   other potential factors.
			this.Create(new RFloatProperty(PropertyName.Attribute, () => (int)SkillAttribute.None));
			this.Create(new RFloatProperty(PropertyName.ArmorMaterial, () => (int)ArmorMaterialType.None));

			// TODO: These were probably added for testing purposes or to
			// reproduce logged packets. Can they be removed?
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
			this.AutoUpdate(PropertyName.STR, [PropertyName.Lv, PropertyName.STR_ADD, PropertyName.STR_STAT, PropertyName.STR_JOB]);
			this.AutoUpdate(PropertyName.CON, [PropertyName.Lv, PropertyName.CON_ADD, PropertyName.CON_STAT, PropertyName.CON_JOB]);
			this.AutoUpdate(PropertyName.INT, [PropertyName.Lv, PropertyName.INT_ADD, PropertyName.INT_STAT, PropertyName.INT_JOB]);
			this.AutoUpdate(PropertyName.MNA, [PropertyName.Lv, PropertyName.MNA_ADD, PropertyName.MNA_STAT, PropertyName.MNA_JOB]);
			this.AutoUpdate(PropertyName.DEX, [PropertyName.Lv, PropertyName.DEX_ADD, PropertyName.DEX_STAT, PropertyName.DEX_JOB]);
			this.AutoUpdate(PropertyName.STR_JOB, [PropertyName.Lv]);
			this.AutoUpdate(PropertyName.CON_JOB, [PropertyName.Lv]);
			this.AutoUpdate(PropertyName.INT_JOB, [PropertyName.Lv]);
			this.AutoUpdate(PropertyName.MNA_JOB, [PropertyName.Lv]);
			this.AutoUpdate(PropertyName.DEX_JOB, [PropertyName.Lv]);
			this.AutoUpdate(PropertyName.MHP, [PropertyName.Lv, PropertyName.CON, PropertyName.MHP_BM, PropertyName.MHP_Bonus]);
			this.AutoUpdate(PropertyName.MSP, [PropertyName.Lv, PropertyName.MNA, PropertyName.MSP_BM, PropertyName.MSP_Bonus]);
			this.AutoUpdate(PropertyName.StatPoint, [PropertyName.StatByLevel, PropertyName.StatByBonus, PropertyName.UsedStat]);
			this.AutoUpdate(PropertyName.MSPD, [PropertyName.FIXMSPD_BM, PropertyName.MSPD_BM, PropertyName.MSPD_Bonus]);
			this.AutoUpdate(PropertyName.CastingSpeed, [PropertyName.CastingSpeed_BM]);
			this.AutoUpdate(PropertyName.DEF, [PropertyName.Lv, PropertyName.DEF_BM, PropertyName.DEF_RATE_BM]);
			this.AutoUpdate(PropertyName.MDEF, [PropertyName.Lv, PropertyName.MDEF_BM, PropertyName.MDEF_RATE_BM]);
			this.AutoUpdate(PropertyName.CRTATK, [PropertyName.CRTATK_BM]);
			this.AutoUpdate(PropertyName.CRTHR, [PropertyName.Lv, PropertyName.CRTHR_BM]);
			this.AutoUpdate(PropertyName.CRTDR, [PropertyName.Lv, PropertyName.CRTDR_BM]);
			this.AutoUpdate(PropertyName.HR, [PropertyName.Lv, PropertyName.STR, PropertyName.HR_BM, PropertyName.HR_RATE_BM]);
			this.AutoUpdate(PropertyName.DR, [PropertyName.Lv, PropertyName.DEX, PropertyName.DR_BM, PropertyName.DR_RATE_BM]);
			this.AutoUpdate(PropertyName.BLK, [PropertyName.Lv, PropertyName.CON, PropertyName.BLK_BM, PropertyName.BLK_RATE_BM]);
			this.AutoUpdate(PropertyName.BLK_BREAK, [PropertyName.Lv, PropertyName.DEX, PropertyName.BLK_BREAK_BM, PropertyName.BLK_BREAK_RATE_BM]);
			this.AutoUpdate(PropertyName.SR, [PropertyName.SR_BM]);
			this.AutoUpdate(PropertyName.SDR, [PropertyName.FixedMinSDR_BM, PropertyName.SDR_BM]);
			this.AutoUpdate(PropertyName.MaxSta, [PropertyName.CON, PropertyName.MAXSTA_Bonus, PropertyName.MaxSta_BM]);
			this.AutoUpdate(PropertyName.Sta_Run, [PropertyName.DashRun]);
			this.AutoUpdate(PropertyName.Sta_Recover, [PropertyName.REST_BM, PropertyName.RSta_BM]);
			this.AutoUpdate(PropertyName.MINPATK, [PropertyName.Lv, PropertyName.STR, PropertyName.PATK_BM, PropertyName.MINPATK_BM, PropertyName.PATK_MAIN_BM, PropertyName.MINPATK_MAIN_BM, PropertyName.PATK_RATE_BM, PropertyName.MINPATK_RATE_BM, PropertyName.PATK_MAIN_RATE_BM, PropertyName.MINPATK_MAIN_RATE_BM]);
			this.AutoUpdate(PropertyName.MAXPATK, [PropertyName.Lv, PropertyName.STR, PropertyName.PATK_BM, PropertyName.MAXPATK_BM, PropertyName.PATK_MAIN_BM, PropertyName.MAXPATK_MAIN_BM, PropertyName.PATK_RATE_BM, PropertyName.MAXPATK_RATE_BM, PropertyName.PATK_MAIN_RATE_BM, PropertyName.MAXPATK_MAIN_RATE_BM]);
			this.AutoUpdate(PropertyName.MINMATK, [PropertyName.Lv, PropertyName.INT, PropertyName.MATK_BM, PropertyName.MINMATK_BM, PropertyName.MATK_RATE_BM, PropertyName.MINMATK_RATE_BM]);
			this.AutoUpdate(PropertyName.MAXMATK, [PropertyName.Lv, PropertyName.INT, PropertyName.MATK_BM, PropertyName.MAXMATK_BM, PropertyName.MATK_RATE_BM, PropertyName.MAXMATK_RATE_BM]);
			this.AutoUpdate(PropertyName.MaxWeight, [PropertyName.CON, PropertyName.STR, PropertyName.MaxWeight_BM, PropertyName.MaxWeight_Bonus]);
			this.AutoUpdate(PropertyName.MovingShot, [PropertyName.MovingShot_BM, PropertyName.MovingShotable]);
			this.AutoUpdate(PropertyName.LootingChance, [PropertyName.LootingChance_BM]);

			this.AutoUpdateMax(PropertyName.HP, PropertyName.MHP);
			this.AutoUpdateMax(PropertyName.SP, PropertyName.MSP);
		}

		/// <summary>
		/// Sets up event subscriptions, to react to actions of the
		/// character with property updates.
		/// </summary>
		private void InitEvents()
		{
			// Update recovery times when the character sits down,
			// as those properties are affected by the sitting status.
			this.Character.SitStatusChanged += this.SitStatusChanged;

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
		private void SitStatusChanged(Character character)
		{
			this.Invalidate(PropertyName.RHPTIME, PropertyName.RSPTIME);
			Send.ZC_OBJECT_PROPERTY(this.Character, PropertyName.RHPTIME, PropertyName.RSPTIME);

			if (character.IsSitting)
			{
				character.StartBuff(BuffId.Rest);
			}
			else
			{
				character.Buffs.Stop(BuffId.Rest);
				character.Buffs.Stop(BuffId.campfire_Buff);
			}
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
