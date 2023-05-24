using System;
using Melia.Shared.Tos.Const;
using Melia.Shared.ObjectProperties;
using Melia.Zone.Network;
using Yggdrasil.Util;

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

			this.Create(new CFloatProperty(PropertyName.STR_ADD, this.GetSTR_ADD));
			this.Create(new CFloatProperty(PropertyName.STR, this.GetSTR));

			this.Create(new CFloatProperty(PropertyName.CON_ADD, this.GetCON_ADD));
			this.Create(new CFloatProperty(PropertyName.CON, this.GetCON));

			this.Create(new CFloatProperty(PropertyName.INT_ADD, this.GetINT_ADD));
			this.Create(new CFloatProperty(PropertyName.INT, this.GetINT));

			this.Create(new CFloatProperty(PropertyName.MNA_ADD, this.GetMNA_ADD));
			this.Create(new CFloatProperty(PropertyName.MNA, this.GetMNA));

			this.Create(new CFloatProperty(PropertyName.DEX_ADD, this.GetDEX_ADD));
			this.Create(new CFloatProperty(PropertyName.DEX, this.GetDEX));

			this.Create(new CFloatProperty(PropertyName.MHP, this.GetMHP));
			this.Create(new CFloatProperty(PropertyName.MSP, this.GetMSP));

			this.Create(new CFloatProperty(PropertyName.MaxSta, this.Get_MSTA));
			this.Create(new CFloatProperty(PropertyName.Sta_RunStart, this.Get_Sta_RunStart));
			this.Create(new CFloatProperty(PropertyName.Sta_Run, this.Get_Sta_Run));
			this.Create(new CFloatProperty(PropertyName.Sta_Recover, this.Get_Sta_Recover));
			this.Create(new CFloatProperty(PropertyName.Sta_R_Delay, this.Get_Sta_R_Delay));
			this.Create(new CFloatProperty(PropertyName.Sta_Runable, this.Get_Sta_Runable));
			this.Create(new CFloatProperty(PropertyName.Sta_Jump, this.Get_Sta_Jump));
			this.Create(new CFloatProperty(PropertyName.Sta_Step, this.Get_Sta_Step));

			// Don't set a max value initially, as that could cap the HP
			// during loading.
			this.Create(new FloatProperty(PropertyName.HP, this.GetMHP(), min: 0));
			this.Create(new FloatProperty(PropertyName.SP, this.GetMSP(), min: 0));

			this.Create(new CFloatProperty(PropertyName.RHP, this.GetRHP));
			this.Create(new CFloatProperty(PropertyName.RSP, this.GetRSP));
			this.Create(new CFloatProperty(PropertyName.RHPTIME, this.GetRHPTIME));
			this.Create(new CFloatProperty(PropertyName.RSPTIME, this.GetRSPTIME));

			this.Create(new FloatProperty(PropertyName.StatByLevel, min: 0));
			this.Create(new FloatProperty(PropertyName.StatByBonus, min: 0));
			this.Create(new FloatProperty(PropertyName.UsedStat, min: 0));
			this.Create(new CFloatProperty(PropertyName.StatPoint, this.GetStatPoint));
			this.Create(new StringProperty(PropertyName.AbilityPoint, "0")); // Why oh why did they make this a string >_>

			this.Create(new CFloatProperty(PropertyName.MAXPATK, this.GetMAXPATK));
			this.Create(new CFloatProperty(PropertyName.MINPATK, this.GetMINPATK));
			this.Create(new CFloatProperty(PropertyName.MAXMATK, this.GetMAXMATK));
			this.Create(new CFloatProperty(PropertyName.MINMATK, this.GetMINMATK));
			this.Create(new CFloatProperty(PropertyName.MAXPATK_SUB, this.GetMAXPATK_SUB));
			this.Create(new CFloatProperty(PropertyName.MINPATK_SUB, this.GetMINPATK_SUB));

			this.Create(new CFloatProperty(PropertyName.DEF, this.GetDEF));
			this.Create(new CFloatProperty(PropertyName.MDEF, this.GetMDEF));
			this.Create(new CFloatProperty(PropertyName.CRTATK, this.GetCRTATK));
			this.Create(new CFloatProperty(PropertyName.CRTHR, this.GetCRTHR));
			this.Create(new CFloatProperty(PropertyName.CRTDR, this.GetCRTDR));
			this.Create(new CFloatProperty(PropertyName.HR, this.GetHR));
			this.Create(new CFloatProperty(PropertyName.DR, this.GetDR));
			this.Create(new CFloatProperty(PropertyName.BLK, this.GetBLK));
			this.Create(new CFloatProperty(PropertyName.BLK_BREAK, this.GetBLK_BREAK));
			this.Create(new CFloatProperty(PropertyName.SR, this.GetSR));
			this.Create(new CFloatProperty(PropertyName.SDR, this.GetSDR));

			this.Create(new CFloatProperty(PropertyName.MaxWeight, this.GetMaxWeight));
			this.Create(new CFloatProperty(PropertyName.NowWeight, this.GetNowWeight));

			this.Create(new CFloatProperty(PropertyName.MSPD, this.GetMSPD));
			this.Create(new CFloatProperty(PropertyName.JumpPower, this.GetJumpPower));
			this.Create(new CFloatProperty(PropertyName.CastingSpeed, this.GetCastingSpeed));

			this.Create(new FloatProperty(PropertyName.MovingShotable, 0));
			this.Create(new FloatProperty(PropertyName.HPDrain, 2));
			this.Create(new FloatProperty(PropertyName.BOOST, 1));
			this.Create(new FloatProperty(PropertyName.Const, 1.909859f));
			this.Create(new FloatProperty(PropertyName.CAST, 1));
			this.Create(new FloatProperty(PropertyName.Sta_Jump, 1000));
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
		}

		/// <summary>
		/// Recalculates and updates HP and SP recovery time properties.
		/// </summary>
		/// <param name="character"></param>
		private void UpdateRecoveryTimes(Character character)
		{
			this.CFloat("RHPTIME").Recalculate();
			this.CFloat("RSPTIME").Recalculate();

			Send.ZC_OBJECT_PROPERTY(this.Character, "RHPTIME", "RSPTIME");
		}

		/// <summary>
		/// Returns the character's maximum HP.
		/// </summary>
		public float GetMHP()
		{
			var level = this.GetFloat(PropertyName.Lv, 1);
			var stat = this.GetFloat(PropertyName.CON, 1);

			var rateByJob = this.Character.Job?.Data.HpRate ?? 1;
			var byJob = Math.Floor(400 * rateByJob);

			var byLevel = Math.Floor(byJob + ((level - 1) * 80 * rateByJob));
			var byStat = Math.Floor(((stat * 0.003f) + (Math.Floor(stat / 10.0f) * 0.01f)) * byLevel);
			var byItem = this.Character.Inventory.GetEquipProperties("MHP");
			var byItemRatio = (byLevel + byStat) * (this.Character.Inventory.GetEquipProperties("MHPRatio") / 100f);
			var byBonus = this.GetFloat(PropertyName.MHP_Bonus);

			var value = byLevel + byStat + byItem + byItemRatio + byBonus;

			var byBuffs = this.GetFloat(PropertyName.MHP_BM);
			var byBuffRate = Math.Floor(value * this.GetFloat(PropertyName.MHP_RATE_BM));

			value += byBuffs + byBuffRate;

			return (int)Math.Max(1, value);
		}

		/// <summary>
		/// Returns the character's maximum SP.
		/// </summary>
		public float GetMSP()
		{
			var level = this.GetFloat(PropertyName.Lv, 1);
			var stat = this.GetFloat(PropertyName.MNA, 1);

			var rateByJob = this.Character.Job?.Data.SpRate ?? 1;
			var byJob = Math.Floor(200 * rateByJob);

			var byLevel = Math.Floor(byJob + ((level - 1) * 18 * rateByJob));
			var byStat = Math.Floor(((stat * 0.005f) + (Math.Floor(stat / 10.0f) * 0.015f)) * byLevel);
			var byItem = this.Character.Inventory.GetEquipProperties("MSP");
			var byBonus = this.GetFloat(PropertyName.MSP_Bonus);

			var value = byLevel + byStat + byItem + byBonus;

			var byBuffs = this.GetFloat(PropertyName.MSP_BM);
			var byBuffRate = Math.Floor(value * this.GetFloat(PropertyName.MSP_RATE_BM));

			value += byBuffs + byBuffRate;

			return (int)Math.Max(0, value);
		}

		/// <summary>
		/// Gets or set Stamina, clamped between 0 and MaxStamina.
		/// </summary>
		public int Stamina
		{
			get => _stamina;
			set => _stamina = (int)Math2.Clamp(0, this.Get_MSTA(), value);
		}
		private int _stamina;

		/// <summary>
		/// Returns the character's maximum stamina (PC.MaxSta).
		/// </summary>
		public int MaxStamina => (int)this.GetFloat(PropertyName.MaxSta);

		/// <summary>
		/// Returns the character's maximum stamina.
		/// </summary>
		public float Get_MSTA()
		{
			var defaultValue = 25;
			var stat = this.GetFloat(PropertyName.CON, 1);

			var byStat = Math.Floor(stat / 20f);
			var byItem = this.Character.Inventory.GetEquipProperties(PropertyName.MSTA);
			var byBonus = this.GetFloat(PropertyName.MAXSTA_Bonus, 0);
			var byBuff = this.GetFloat(PropertyName.MaxSta_BM, 0);
			//var byReward = GetReward(PropertyName.MSTA);

			var value = defaultValue + byStat + byItem + byBonus + byBuff;

			return (int)(value * 1000);
		}

		/// <summary>
		/// Returns the amount of stamina used when starting to run.
		/// </summary>
		/// <returns></returns>
		public float Get_Sta_RunStart()
		{
			return 0;
		}

		/// <summary>
		/// Returns the amount of stamina used while moving.
		/// </summary>
		/// <returns></returns>
		public float Get_Sta_Run()
		{
			var defaultValue = 50f;

			var isDashRun = this.GetFloat("DashRun", 0);
			if (isDashRun > 0)
			{
				var dashAmount = 500f;
				if (isDashRun == 2)
					dashAmount *= 0.9f;

				defaultValue += dashAmount;
			}

			var value = 250f * defaultValue / 100f;

			return (int)value;
		}

		/// <summary>
		/// Returns the amount of stamina recovered per second.
		/// </summary>
		/// <returns></returns>
		public float Get_Sta_Recover()
		{
			//if (buffCursed?)
			//	return 0;

			var defaultValue = 400;

			var byBuff = this.GetFloat(PropertyName.REST_BM, 0) + this.GetFloat(PropertyName.RSta_BM, 0);
			var value = defaultValue + byBuff;

			if (this.Character.Buffs.Has(BuffId.SitRest))
				value *= 2;

			return (int)value;
		}

		/// <summary>
		/// Returns the amount of time between stamina recovery ticks?
		/// </summary>
		/// <returns></returns>
		public float Get_Sta_R_Delay()
		{
			return 1000;
		}

		/// <summary>
		/// Returns the amount of stamina necessary to start dashing.
		/// </summary>
		/// <returns></returns>
		public float Get_Sta_Runable()
		{
			return 250;
		}

		/// <summary>
		/// Returns the amount of stamina used when jumping.
		/// </summary>
		/// <returns></returns>
		public float Get_Sta_Jump()
		{
			return 0;
		}

		/// <summary>
		/// Returns the amount of stamina for ...?
		/// </summary>
		/// <returns></returns>
		public float Get_Sta_Step()
		{
			return 2500;
		}

		/// <summary>
		/// Returns HP recovery.
		/// </summary>
		public float GetRHP()
		{
			var mhp = this.GetFloat(PropertyName.MHP, 1);
			var jobHpRate = this.Character.Job?.Data.RHpRate ?? 1;

			var byDefault = Math.Floor(mhp / 100f * jobHpRate);
			var byItems = this.Character.Inventory.GetEquipProperties("RHP");
			var byBuffs = this.GetFloat(PropertyName.RHP_BM);

			var value = (byDefault + byItems + byBuffs);
			return (float)Math.Max(0, value);
		}

		/// <summary>
		/// Returns HP recovery time.
		/// </summary>
		public float GetRHPTIME()
		{
			// The recovery time is presumably the number of milliseconds
			// between regen ticks, with the default being 20 seconds,
			// which is reduced by items, buffs, sitting, etc.

			var defaultTime = 20000;

			// Item.RHPTIME doesn't exist?
			var byItems = 0; ; // TimeSpan.FromMilliseconds(this.Character.Inventory.GetEquipProperties("RHPTIME"));
			var byBuffs = this.GetFloat(PropertyName.RHPTIME_BM);

			var value = defaultTime - byItems - byBuffs;

			if (this.Character.IsSitting)
				value /= 2;

			return (int)Math.Max(1000, value);
		}

		/// <summary>
		/// Returns SP recovery.
		/// </summary>
		public float GetRSP()
		{
			var mhp = this.GetFloat(PropertyName.MSP, 1);
			var jobSpRate = this.Character.Job?.Data.RSpRate ?? 1;

			var byDefault = Math.Floor(mhp * 0.03f * jobSpRate);
			var byItems = this.Character.Inventory.GetEquipProperties("RSP");
			var byBuffs = this.GetFloat(PropertyName.RSP_BM);

			var value = (byDefault + byItems + byBuffs);
			return (float)Math.Max(0, value);
		}

		/// <summary>
		/// Returns SP recovery time.
		/// </summary>
		public float GetRSPTIME()
		{
			var defaultTime = 20000;

			var byItems = 0; ; // TimeSpan.FromMilliseconds(this.Character.Inventory.GetEquipProperties("RSPTIME"));
			var byBuffs = this.GetFloat(PropertyName.RSPTIME_BM);

			var value = defaultTime - byItems - byBuffs;

			if (this.Character.IsSitting)
				value /= 2;

			return (int)Math.Max(1000, value);
		}

		/// <summary>
		/// Returns maximum weight the character can carry.
		/// </summary>
		/// <remarks>
		/// At release: Base 5000, plus 5 for each Str/Con.
		/// Now: Base 8000 plus bonuses?
		/// </remarks>
		public float GetMaxWeight()
			=> 8000;

		/// <summary>
		/// Returns combined weight of all items the character is currently carrying.
		/// </summary>
		public float GetNowWeight()
			=> this.Character.Inventory.GetNowWeight();

		/// <summary>
		/// Stat points.
		/// </summary>
		public float GetStatPoint()
		{
			var byLevel = (int)this.GetFloat(PropertyName.StatByLevel);
			var byBonus = (int)this.GetFloat(PropertyName.StatByBonus);
			var usedStat = (int)this.GetFloat(PropertyName.UsedStat);

			return (byLevel + byBonus - usedStat);
		}

		/// <summary>
		/// Returns character's STR bonus from items and buffs.
		/// </summary>
		public float GetSTR_ADD()
		{
			var byItem = 0; // TODO

			// Buffs: "STR_BM"
			var byBuffs = 0;

			// "STR_ITEM_BM" Item Awakening/Enchantment ?
			var byItemBuff = 0;

			var value = byItem + byBuffs + byItemBuff;

			return value;
		}

		/// <summary>
		/// Returns character's total strength.
		/// </summary>
		/// <returns></returns>
		public float GetSTR()
		{
			var defaultStat = this.GetFloat(PropertyName.STR_JOB);

			var byJob = 0f;
			var jobs = this.Character.Jobs.GetList();
			foreach (var job in jobs)
				byJob += job.Data.StrRatio;
			byJob = (float)Math.Floor((this.GetFloat(PropertyName.Lv) - 1) * (byJob / jobs.Length / 100f));

			var byStat = this.GetFloat(PropertyName.STR_STAT);
			var byBonus = this.GetFloat(PropertyName.STR_Bonus);
			var byAdd = this.GetFloat(PropertyName.STR_ADD);
			var byTemp = 0; // this.GetFloat(PropertyName.STR_TEMP);

			var rewardProperty = 0; // GET_REWARD_PROPERTY(self, statString);

			var result = defaultStat + byJob + byStat + byBonus + byAdd + byTemp + rewardProperty;
			return (float)Math.Floor(Math.Max(1, result));
		}

		/// <summary>
		/// Returns character's CON bonus from items and buffs.
		/// </summary>
		public float GetCON_ADD()
		{
			var byItem = 0; // TODO

			// Buffs: "CON_BM"
			var byBuffs = 0;

			// "CON_ITEM_BM" Item Awakening/Enchantment ?
			var byItemBuff = 0;

			var value = byItem + byBuffs + byItemBuff;

			return value;
		}

		/// <summary>
		/// Returns character's total constitution.
		/// </summary>
		public float GetCON()
		{
			var defaultStat = this.GetFloat(PropertyName.CON_JOB);

			var byJob = 0f;
			var jobs = this.Character.Jobs.GetList();
			foreach (var job in jobs)
				byJob += job.Data.ConRatio;
			byJob = (float)Math.Floor((this.GetFloat(PropertyName.Lv) - 1) * (byJob / jobs.Length / 100f));

			var byStat = this.GetFloat(PropertyName.CON_STAT);
			var byBonus = this.GetFloat(PropertyName.CON_Bonus);
			var byAdd = this.GetFloat(PropertyName.CON_ADD);
			var byTemp = 0; // this.GetFloat(PropertyName.CON_TEMP);

			var rewardProperty = 0; // GET_REWARD_PROPERTY(self, statString);

			var result = defaultStat + byJob + byStat + byBonus + byAdd + byTemp + rewardProperty;
			return (float)Math.Floor(Math.Max(1, result));
		}

		/// <summary>
		/// Returns character's INT bonus from items and buffs.
		/// </summary>
		public float GetINT_ADD()
		{
			var byItem = 0; // TODO

			// Buffs: "INT_BM"
			var byBuffs = 0;

			// "INT_ITEM_BM" Item Awakening/Enchantment ?
			var byItemBuff = 0;

			var value = byItem + byBuffs + byItemBuff;

			return value;
		}

		/// <summary>
		/// Returns character's total intelligence.
		/// </summary>
		public float GetINT()
		{
			var defaultStat = this.GetFloat(PropertyName.INT_JOB);

			var byJob = 0f;
			var jobs = this.Character.Jobs.GetList();
			foreach (var job in jobs)
				byJob += job.Data.IntRatio;
			byJob = (float)Math.Floor((this.GetFloat(PropertyName.Lv) - 1) * (byJob / jobs.Length / 100f));

			var byStat = this.GetFloat(PropertyName.INT_STAT);
			var byBonus = this.GetFloat(PropertyName.INT_Bonus);
			var byAdd = this.GetFloat(PropertyName.INT_ADD);
			var byTemp = 0; // this.GetFloat(PropertyName.INT_TEMP);

			var rewardProperty = 0; // GET_REWARD_PROPERTY(self, statString);

			var result = defaultStat + byJob + byStat + byBonus + byAdd + byTemp + rewardProperty;
			return (float)Math.Floor(Math.Max(1, result));
		}

		/// <summary>
		/// Returns character's MNA (SPR) bonus from items and buffs.
		/// </summary>
		public float GetMNA_ADD()
		{
			var byItem = 0; // TODO

			// Buffs: "SPR_BM"
			var byBuffs = 0;

			// "SPR_ITEM_BM" Item Awakening/Enchantment ?
			var byItemBuff = 0;

			var value = byItem + byBuffs + byItemBuff;

			return value;
		}

		/// <summary>
		/// Returns character's total spirit.
		/// </summary>
		public float GetMNA()
		{
			var defaultStat = this.GetFloat(PropertyName.MNA_JOB);

			var byJob = 0f;
			var jobs = this.Character.Jobs.GetList();
			foreach (var job in jobs)
				byJob += job.Data.SprRatio;
			byJob = (float)Math.Floor((this.GetFloat(PropertyName.Lv) - 1) * (byJob / jobs.Length / 100f));

			var byStat = this.GetFloat(PropertyName.MNA_STAT);
			var byBonus = this.GetFloat(PropertyName.MNA_Bonus);
			var byAdd = this.GetFloat(PropertyName.MNA_ADD);
			var byTemp = 0; // this.GetFloat(PropertyName.MNA_TEMP);

			var rewardProperty = 0; // GET_REWARD_PROPERTY(self, statString);

			var result = defaultStat + byJob + byStat + byBonus + byAdd + byTemp + rewardProperty;
			return (float)Math.Floor(Math.Max(1, result));
		}

		/// <summary>
		/// Returns character's DEX bonus from items and buffs.
		/// </summary>
		public float GetDEX_ADD()
		{
			var byItem = 0; // TODO

			// Buffs: "DEX_BM"
			var byBuffs = 0;

			// "DEX_ITEM_BM" Item Awakening/Enchantment ?
			var byItemBuff = 0;

			var value = byItem + byBuffs + byItemBuff;

			return value;
		}

		/// <summary>
		/// Returns character's total dexterity.
		/// </summary>
		public float GetDEX()
		{
			var defaultStat = this.GetFloat(PropertyName.DEX_JOB);

			var byJob = 0f;
			var jobs = this.Character.Jobs.GetList();
			foreach (var job in jobs)
				byJob += job.Data.DexRatio;
			byJob = (float)Math.Floor((this.GetFloat(PropertyName.Lv) - 1) * (byJob / jobs.Length / 100f));

			var byStat = this.GetFloat(PropertyName.DEX_STAT);
			var byBonus = this.GetFloat(PropertyName.DEX_Bonus);
			var byAdd = this.GetFloat(PropertyName.DEX_ADD);
			var byTemp = 0; // this.GetFloat(PropertyName.DEX_TEMP);

			var rewardProperty = 0; // GET_REWARD_PROPERTY(self, statString);

			var result = defaultStat + byJob + byStat + byBonus + byAdd + byTemp + rewardProperty;
			return (float)Math.Floor(Math.Max(1, result));
		}

		/// <summary>
		/// Returns minimum physical ATK.
		/// </summary>
		public float GetMINPATK()
		{
			var level = this.GetFloat(PropertyName.Lv, 1);
			var stat = this.GetFloat(PropertyName.STR, 1);

			var baseValue = 20;
			var byLevel = level;

			var byStat = (stat * 2f) + ((float)Math.Floor(stat / 10f) * (byLevel * 0.05f));

			var byItem = 0f;
			byItem += this.Character.Inventory.GetEquipProperties("MINATK");
			byItem += this.Character.Inventory.GetEquipProperties("PATK");
			byItem += this.Character.Inventory.GetEquipProperties("ADD_MINATK");

			var value = (baseValue + byLevel + byStat + byItem);

			var byBuffs = 0f;
			byBuffs += this.GetFloat(PropertyName.PATK_BM);
			byBuffs += this.GetFloat(PropertyName.MINPATK_BM);
			byBuffs += this.GetFloat(PropertyName.PATK_MAIN_BM);
			byBuffs += this.GetFloat(PropertyName.MINPATK_MAIN_BM);

			var byRateBuffs = 0f;
			byRateBuffs += this.GetFloat(PropertyName.PATK_RATE_BM);
			byRateBuffs += this.GetFloat(PropertyName.MINPATK_RATE_BM);
			byRateBuffs += this.GetFloat(PropertyName.PATK_MAIN_RATE_BM);
			byRateBuffs += this.GetFloat(PropertyName.MINPATK_MAIN_RATE_BM);
			byRateBuffs = (value * byRateBuffs);

			value += byBuffs + byRateBuffs;

			var max = this.GetMAXPATK();
			return (float)Math2.Clamp(1, max, value);
		}

		/// <summary>
		/// Returns maximum physical ATK.
		/// </summary>
		public float GetMAXPATK()
		{
			var level = this.GetFloat(PropertyName.Lv, 1);
			var stat = this.GetFloat(PropertyName.STR, 1);

			var baseValue = 20;
			var byLevel = level;

			var byStat = (stat * 2f) + ((float)Math.Floor(stat / 10f) * (byLevel * 0.05f));

			var byItem = 0f;
			byItem += this.Character.Inventory.GetEquipProperties("MAXATK");
			byItem += this.Character.Inventory.GetEquipProperties("PATK");
			byItem += this.Character.Inventory.GetEquipProperties("ADD_MAXATK");

			var value = (baseValue + byLevel + byStat + byItem);

			var byBuffs = 0f;
			byBuffs += this.GetFloat(PropertyName.PATK_BM);
			byBuffs += this.GetFloat(PropertyName.MAXPATK_BM);
			byBuffs += this.GetFloat(PropertyName.PATK_MAIN_BM);
			byBuffs += this.GetFloat(PropertyName.MAXPATK_MAIN_BM);

			var byRateBuffs = 0f;
			byRateBuffs += this.GetFloat(PropertyName.PATK_RATE_BM);
			byRateBuffs += this.GetFloat(PropertyName.MAXPATK_RATE_BM);
			byRateBuffs += this.GetFloat(PropertyName.PATK_MAIN_RATE_BM);
			byRateBuffs += this.GetFloat(PropertyName.MAXPATK_MAIN_RATE_BM);
			byRateBuffs = (value * byRateBuffs);

			value += byBuffs + byRateBuffs;

			return (float)Math.Max(1, value);
		}

		/// <summary>
		/// Returns minimum physical ATK (for sub-weapon?).
		/// </summary>
		public float GetMINPATK_SUB()
		{
			var baseValue = 20;
			var level = this.GetFloat(PropertyName.Lv);
			var stat = this.GetFloat(PropertyName.STR);

			var byLevel = level / 2f;
			var byStat = (stat * 2f) + ((float)Math.Floor(stat / 10f) * 5f);
			var byItem = 0; // TODO: "MINATK" "PATK" "ADD_MINATK"

			var value = baseValue + byLevel + byStat + byItem;

			// Reducation for shields and stuff?
			//value -= leftHand.MinAtk;
			//if(hasBuff("Warrior_RH_VisibleObject"))
			//	value -= rightHand.MinAtk

			// Buffs: "PATK_BM", "MINPATK_SUB_BM"
			var byBuffs = 0;

			// Rate buffs: "PATK_RATE_BM", "MINPATK_SUB_RATE_BM"
			//if(hasBuff("Guardian"))
			//	rate -= SkillLevel
			var rate = 0;
			var byRateBuffs = (float)Math.Floor(value * rate);

			value += byBuffs + byRateBuffs;

			var maxPatk_sub = this.GetMAXPATK_SUB();
			if (value > maxPatk_sub)
				return maxPatk_sub;

			return (int)value;
		}

		/// <summary>
		/// Returns maximum physical ATK (for sub-weapon?).
		/// </summary>
		public float GetMAXPATK_SUB()
		{
			var baseValue = 20;
			var level = this.GetFloat(PropertyName.Lv);
			var stat = this.GetFloat(PropertyName.STR);

			var byLevel = level / 2f;
			var byStat = (stat * 2f) + ((float)Math.Floor(stat / 10f) * 5f);
			var byItem = 0; // TODO: "MAXATK" "PATK" "ADD_MAXATK"

			var value = baseValue + byLevel + byStat + byItem;

			// Reducation for shields and stuff?
			//value -= leftHand.MaxAtk;
			//if(hasBuff("Warrior_RH_VisibleObject"))
			//	value -= rightHand.MaxAtk;

			// Buffs: "PATK_BM", "MAXPATK_SUB_BM"
			var byBuffs = 0;

			// Rate buffs: "PATK_RATE_BM", "MAXPATK_SUB_RATE_BM"
			//if(hasBuff("Guardian"))
			//	rate -= SkillLevel
			var rate = 0;
			var byRateBuffs = (float)Math.Floor(value * rate);

			value += byBuffs + byRateBuffs;

			return (int)value;
		}

		/// <summary>
		/// Returns minimum magic ATK.
		/// </summary>
		public float GetMINMATK()
		{
			var level = this.GetFloat(PropertyName.Lv, 1);
			var stat = this.GetFloat(PropertyName.INT, 1);

			var baseValue = 20;
			var byLevel = level;

			var byStat = (stat * 2f) + ((float)Math.Floor(stat / 10f) * (byLevel * 0.05f));

			var byItem = 0f;
			byItem += this.Character.Inventory.GetEquipProperties("MATK");
			byItem += this.Character.Inventory.GetEquipProperties("ADD_MATK");
			byItem += this.Character.Inventory.GetEquipProperties("ADD_MINATK");

			var value = (baseValue + byLevel + byStat + byItem);

			var byBuffs = 0f;
			byBuffs += this.GetFloat(PropertyName.MATK_BM);
			byBuffs += this.GetFloat(PropertyName.MINMATK_BM);

			var byRateBuffs = 0f;
			byRateBuffs += this.GetFloat(PropertyName.MATK_RATE_BM);
			byRateBuffs += this.GetFloat(PropertyName.MINMATK_RATE_BM);
			byRateBuffs = (value * byRateBuffs);

			value += byBuffs + byRateBuffs;

			var max = this.GetMAXMATK();
			return (float)Math2.Clamp(1, max, value);
		}

		/// <summary>
		/// Returns maximum magic ATK.
		/// </summary>
		public float GetMAXMATK()
		{
			var level = this.GetFloat(PropertyName.Lv, 1);
			var stat = this.GetFloat(PropertyName.INT, 1);

			var baseValue = 20;
			var byLevel = level;

			var byStat = (stat * 2f) + ((float)Math.Floor(stat / 10f) * (byLevel * 0.05f));

			var byItem = 0f;
			byItem += this.Character.Inventory.GetEquipProperties("MATK");
			byItem += this.Character.Inventory.GetEquipProperties("ADD_MATK");
			byItem += this.Character.Inventory.GetEquipProperties("ADD_MAXATK");

			var value = (baseValue + byLevel + byStat + byItem);

			var byBuffs = 0f;
			byBuffs += this.GetFloat(PropertyName.MATK_BM);
			byBuffs += this.GetFloat(PropertyName.MINMATK_BM);

			var byRateBuffs = 0f;
			byRateBuffs += this.GetFloat(PropertyName.MATK_RATE_BM);
			byRateBuffs += this.GetFloat(PropertyName.MINMATK_RATE_BM);
			byRateBuffs = (value * byRateBuffs);

			value += byBuffs + byRateBuffs;

			return (float)Math.Max(1, value);
		}

		/// <summary>
		/// Returns Physical Defense.
		/// </summary>
		public float GetDEF()
		{
			var baseValue = 20;
			var level = this.GetFloat(PropertyName.Lv);

			var byLevel = level;
			var byItem = 0f; // TODO: "DEF" "DEF_Rate"

			var value = baseValue + byLevel + byItem;

			// Buffs: "DEF_BM"
			var byBuffs = 0;

			// Rate buffs: "DEF_RATE_BM"
			var rate = 0;
			var byRateBuffs = (float)Math.Floor(value * rate);

			value += byBuffs + byRateBuffs;

			return (int)value;
		}

		/// <summary>
		/// Returns Magic Defense.
		/// </summary>
		public float GetMDEF()
		{
			var baseValue = 20;
			var level = this.GetFloat(PropertyName.Lv);

			var byLevel = level;
			var byItem = 0f; // TODO: "MDEF" "MDEF_Rate"

			var value = baseValue + byLevel + byItem;

			// Buffs: "MDEF_BM"
			var byBuffs = 0;

			// Rate buffs: "MDEF_RATE_BM"
			var rate = 0;
			var byRateBuffs = (float)Math.Floor(value * rate);

			value += byBuffs + byRateBuffs;

			return (int)value;
		}

		/// <summary>
		/// Returns critical attack.
		/// </summary>
		public float GetCRTATK()
		{
			var stat = this.GetFloat(PropertyName.DEX);

			var byStat = (stat * 4f) + ((float)Math.Floor(stat / 10f) * 10f);
			var byItem = 0; // TODO

			var value = byStat + byItem;

			// Buffs: "CRTATK_BM"
			var byBuffs = 0;

			// Rate buffs: Does Tos have something like CritATK +x%?
			var rate = 0;
			var byRateBuffs = (float)Math.Floor(value * rate);

			value += byBuffs + byRateBuffs;

			return (int)value;
		}

		/// <summary>
		/// Returns critical hit rate (crit chance).
		/// </summary>
		public float GetCRTHR()
		{
			var level = this.GetFloat(PropertyName.Lv);

			var byLevel = level / 2f;
			var byItem = 0; // TODO

			var value = byLevel + byItem;

			// Buffs: "CRTHR_BM"
			var byBuffs = 0;

			// Rate buffs:
			var rate = 0;
			var byRateBuffs = (float)Math.Floor(value * rate);

			value += byBuffs + byRateBuffs;

			return (int)value;
		}

		/// <summary>
		/// Returns critical dodge rate.
		/// </summary>
		public float GetCRTDR()
		{
			var level = this.GetFloat(PropertyName.Lv);

			var byLevel = level / 2f;
			var byItem = 0; // TODO

			var value = byLevel + byItem;

			// Buffs: "CRTDR_BM"
			var byBuffs = 0;

			// Rate buffs:
			var rate = 0;
			var byRateBuffs = (float)Math.Floor(value * rate);

			value += byBuffs + byRateBuffs;

			return (int)value;
		}

		/// <summary>
		/// Returns hit rate.
		/// </summary>
		public float GetHR()
		{
			var level = this.GetFloat(PropertyName.Lv);
			var stat = this.GetFloat(PropertyName.STR);

			var byLevel = level / 4f;
			var byStat = (stat / 2f) + ((float)Math.Floor(stat / 15f) * 3f);
			var byItem = 0; // HR, ADD_HR

			var value = byLevel + byStat + byItem;

			// Buffs: "HR_BM"
			var byBuffs = 0;

			// Rate buffs: HR_RATE_BM
			var rate = 0;
			var byRateBuffs = (float)Math.Floor(value * rate);

			value += byBuffs + byRateBuffs;

			return (int)value;
		}

		/// <summary>
		/// Returns dodge rate.
		/// </summary>
		public float GetDR()
		{
			var level = this.GetFloat(PropertyName.Lv);
			var stat = this.GetFloat(PropertyName.DEX);

			var byLevel = level / 4f;
			var byStat = (stat / 2f) + ((float)Math.Floor(stat / 15f) * 3f);
			var byItem = 0; // TODO

			var value = byLevel + byStat + byItem;

			// Buffs: "DR_BM"
			var byBuffs = 0;

			// Rate buffs: "ADD_DR"
			var rate = 0;
			var byRateBuffs = (float)Math.Floor(value * rate);

			value += byBuffs + byRateBuffs;

			return (int)value;
		}

		/// <summary>
		/// Returns block.
		/// </summary>
		public float GetBLK()
		{
			// TODO: Update it after equipment change.
			// Shield/Dagger = Right hand.
			if (this.Character.Inventory.GetItem(EquipSlot.LeftHand).Data.EquipType1 != EquipType.Shield)
				return 0;

			var Level = this.GetFloat(PropertyName.Lv);
			var stat = this.GetFloat(PropertyName.CON);

			var byLevel = Level / 4f;
			var byStat = (stat / 2f) + ((float)Math.Floor(stat / 15f) * 3f);
			var byItem = 0f; // TODO

			var value = byLevel + byStat + byItem;

			// Buffs: "BLK_BM"
			var byBuffs = 0;

			// Rate buffs: BlockRate
			var rate = 0;
			var byRateBuffs = (float)Math.Floor(value * rate);

			value += byBuffs + byRateBuffs;

			return (int)value;
		}

		/// <summary>
		/// Returns block break (penetration).
		/// </summary>
		public float GetBLK_BREAK()
		{
			var level = this.GetFloat(PropertyName.Lv);
			var stat = this.GetFloat(PropertyName.DEX);

			var byLevel = level / 4f;
			var byStat = (stat / 2f) + ((float)Math.Floor(stat / 15f) * 3f);
			var byItem = 0; // TODO

			var value = byLevel + byStat + byItem;

			// Buffs: "BLK_BREAK_BM"
			var byBuffs = 0;

			// Rate buffs: 
			var rate = 0;
			var byRateBuffs = (float)Math.Floor(value * rate);

			value += byBuffs + byRateBuffs;

			return (int)value;
		}

		/// <summary>
		/// Returns the character's splash rate?
		/// </summary>
		public float GetSR()
		{
			var baseValue = 3;

			if (this.Character.Jobs.Has(JobId.Swordsman, Circle.First))
				baseValue = 4;
			else if (this.Character.Jobs.Has(JobId.Archer, Circle.First))
				baseValue = 0;

			var byItem = 0f; // TODO

			var value = baseValue + byItem;

			// Buffs: "SR_BM"
			var byBuffs = 0;

			value += byBuffs;

			return (int)value;
		}

		/// <summary>
		/// Returns splash dodge rate.
		/// </summary>
		public float GetSDR()
		{
			var baseValue = 1;
			var byItem = 0f; // TODO

			var value = baseValue + byItem;

			// Buffs: "SDR_BM"
			var byBuffs = 0;

			value += byBuffs;

			return (int)value;
		}

		/// <summary>
		/// Returns character's movement speed.
		/// </summary>
		/// <returns></returns>
		private float GetMSPD()
		{
			var byDefault = 30;
			var byBuff = this.GetFloat(PropertyName.MSPD_BM);
			var byBonus = this.GetFloat(PropertyName.MSPD_Bonus);

			return (byDefault + byBuff + byBonus);
		}

		/// <summary>
		/// Returns character's current jump power, which dictates how
		/// high they can jump.
		/// </summary>
		/// <returns></returns>
		public float GetJumpPower()
		{
			return 350;
		}

		/// <summary>
		/// Returns character's current casting speed.
		/// </summary>
		/// <returns></returns>
		public float GetCastingSpeed()
		{
			var byDefault = 100;
			var byBuff = this.GetFloat(PropertyName.CastingSpeed_BM);

			var result = byDefault + byBuff;
			return (float)Math.Floor(Math2.Clamp(10, 200, result));
		}
	}
}
