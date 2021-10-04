using System;
using Melia.Shared.Const;
using Melia.Shared.Util;
using Melia.Shared.World.ObjectProperties;

namespace Melia.Channel.World.Entities
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
		public CharacterProperties(Character character)
		{
			this.Character = character;
			this.AddDefaultProperties();
			this.AddAutoUpdates();
		}

		/// <summary>
		/// Sets up properties that every character has by default.
		/// </summary>
		public void AddDefaultProperties()
		{
			// We only need to set up properties that are calculated or
			// have min/max or non-default values. All others will be
			// created with default values as needed on demand.

			this.Add(new FloatProperty(PropertyId.PC.Lv, 1, min: 1));

			this.Add(new CalculatedFloatProperty(PropertyId.PC.STR_ADD, this.GetSTR_ADD));
			this.Add(new CalculatedFloatProperty(PropertyId.PC.STR, this.GetSTR));

			this.Add(new CalculatedFloatProperty(PropertyId.PC.CON_ADD, this.GetCON_ADD));
			this.Add(new CalculatedFloatProperty(PropertyId.PC.CON, this.GetCON));

			this.Add(new CalculatedFloatProperty(PropertyId.PC.INT_ADD, this.GetINT_ADD));
			this.Add(new CalculatedFloatProperty(PropertyId.PC.INT, this.GetINT));

			this.Add(new CalculatedFloatProperty(PropertyId.PC.MNA_ADD, this.GetMNA_ADD));
			this.Add(new CalculatedFloatProperty(PropertyId.PC.MNA, this.GetMNA));

			this.Add(new CalculatedFloatProperty(PropertyId.PC.DEX_ADD, this.GetDEX_ADD));
			this.Add(new CalculatedFloatProperty(PropertyId.PC.DEX, this.GetDEX));

			this.Add(new CalculatedFloatProperty(PropertyId.PC.MHP, this.GetMHP));
			this.Add(new CalculatedFloatProperty(PropertyId.PC.MSP, this.GetMSP));
			this.Add(new CalculatedFloatProperty(PropertyId.PC.MaxSta, this.GetMaxSta));

			this.Add(new FloatProperty(PropertyId.PC.HP, this.GetMHP(), min: 0, max: this.GetMHP()));
			this.Add(new FloatProperty(PropertyId.PC.SP, this.GetMSP(), min: 0, max: this.GetMSP()));

			this.Add(new CalculatedFloatProperty(PropertyId.PC.RHP, this.GetRHP));
			this.Add(new CalculatedFloatProperty(PropertyId.PC.RSP, this.GetRSP));
			this.Add(new CalculatedFloatProperty(PropertyId.PC.RHPTIME, this.GetRHPTIME));
			this.Add(new CalculatedFloatProperty(PropertyId.PC.RSPTIME, this.GetRSPTIME));

			this.Add(new FloatProperty(PropertyId.PC.StatByLevel, min: 0));
			this.Add(new FloatProperty(PropertyId.PC.StatByBonus, min: 0));
			this.Add(new FloatProperty(PropertyId.PC.UsedStat, min: 0));
			this.Add(new CalculatedFloatProperty(PropertyId.PC.StatPoint, this.GetStatPoint));
			this.Add(new StringProperty(PropertyId.PC.AbilityPoint, "0")); // Why oh why did they make this a string >_>

			this.Add(new CalculatedFloatProperty(PropertyId.PC.MINPATK, this.GetMINPATK));
			this.Add(new CalculatedFloatProperty(PropertyId.PC.MAXPATK, this.GetMAXPATK));
			this.Add(new CalculatedFloatProperty(PropertyId.PC.MINMATK, this.GetMINMATK));
			this.Add(new CalculatedFloatProperty(PropertyId.PC.MAXMATK, this.GetMAXMATK));
			this.Add(new CalculatedFloatProperty(PropertyId.PC.MINPATK_SUB, this.GetMINPATK_SUB));
			this.Add(new CalculatedFloatProperty(PropertyId.PC.MAXPATK_SUB, this.GetMAXPATK_SUB));

			this.Add(new CalculatedFloatProperty(PropertyId.PC.DEF, this.GetDEF));
			this.Add(new CalculatedFloatProperty(PropertyId.PC.MDEF, this.GetMDEF));
			this.Add(new CalculatedFloatProperty(PropertyId.PC.CRTATK, this.GetCRTATK));
			this.Add(new CalculatedFloatProperty(PropertyId.PC.CRTHR, this.GetCRTHR));
			this.Add(new CalculatedFloatProperty(PropertyId.PC.CRTDR, this.GetCRTDR));
			this.Add(new CalculatedFloatProperty(PropertyId.PC.HR, this.GetHR));
			this.Add(new CalculatedFloatProperty(PropertyId.PC.DR, this.GetDR));
			this.Add(new CalculatedFloatProperty(PropertyId.PC.BLK, this.GetBLK));
			this.Add(new CalculatedFloatProperty(PropertyId.PC.BLK_BREAK, this.GetBLK_BREAK));
			this.Add(new CalculatedFloatProperty(PropertyId.PC.SR, this.GetSR));
			this.Add(new CalculatedFloatProperty(PropertyId.PC.SDR, this.GetSDR));

			this.Add(new CalculatedFloatProperty(PropertyId.PC.MaxWeight, this.GetMaxWeight));
			this.Add(new CalculatedFloatProperty(PropertyId.PC.NowWeight, this.GetNowWeight));

			this.Add(new CalculatedFloatProperty(PropertyId.PC.MSPD, this.GetMSPD));
			this.Add(new CalculatedFloatProperty(PropertyId.PC.JumpPower, this.GetJumpPower));
			this.Add(new CalculatedFloatProperty(PropertyId.PC.CastingSpeed, this.GetCastingSpeed));

			this.Add(new FloatProperty(PropertyId.PC.MovingShotable, 0));
			this.Add(new FloatProperty(PropertyId.PC.HPDrain, 2));
			this.Add(new FloatProperty(PropertyId.PC.BOOST, 1));
			this.Add(new FloatProperty(PropertyId.PC.Const, 1.909859f));
			this.Add(new FloatProperty(PropertyId.PC.CAST, 1));
			this.Add(new FloatProperty(PropertyId.PC.Sta_Jump, 1000));
		}

		/// <summary>
		/// Sets up auto updates for the default properties.
		/// </summary>
		private void AddAutoUpdates()
		{
			this.AutoUpdate(PropertyId.PC.MHP, new[] { PropertyId.PC.Lv, PropertyId.PC.CON, PropertyId.PC.MHP_BM, PropertyId.PC.MHP_Bonus });
			this.AutoUpdate(PropertyId.PC.MSP, new[] { PropertyId.PC.Lv, PropertyId.PC.MNA, PropertyId.PC.MSP_BM, PropertyId.PC.MSP_Bonus });
			this.AutoUpdate(PropertyId.PC.STR, new[] { PropertyId.PC.STR_ADD, PropertyId.PC.STR_STAT, PropertyId.PC.STR_JOB });
			this.AutoUpdate(PropertyId.PC.CON, new[] { PropertyId.PC.CON_ADD, PropertyId.PC.CON_STAT, PropertyId.PC.CON_JOB });
			this.AutoUpdate(PropertyId.PC.INT, new[] { PropertyId.PC.INT_ADD, PropertyId.PC.INT_STAT, PropertyId.PC.INT_JOB });
			this.AutoUpdate(PropertyId.PC.MNA, new[] { PropertyId.PC.MNA_ADD, PropertyId.PC.MNA_STAT, PropertyId.PC.MNA_JOB });
			this.AutoUpdate(PropertyId.PC.DEX, new[] { PropertyId.PC.DEX_ADD, PropertyId.PC.DEX_STAT, PropertyId.PC.DEX_JOB });
			this.AutoUpdate(PropertyId.PC.StatPoint, new[] { PropertyId.PC.StatByLevel, PropertyId.PC.StatByBonus, PropertyId.PC.UsedStat });
			this.AutoUpdate(PropertyId.PC.MSPD, new[] { PropertyId.PC.MSPD_BM, PropertyId.PC.MSPD_Bonus });
			this.AutoUpdate(PropertyId.PC.CastingSpeed, new[] { PropertyId.PC.CastingSpeed_BM });
			this.AutoUpdate(PropertyId.PC.DEF, new[] { PropertyId.PC.Lv, PropertyId.PC.DEF_BM, PropertyId.PC.DEF_RATE_BM });
			this.AutoUpdate(PropertyId.PC.MDEF, new[] { PropertyId.PC.Lv, PropertyId.PC.MDEF_BM, PropertyId.PC.MDEF_RATE_BM });
			this.AutoUpdate(PropertyId.PC.CRTATK, new[] { PropertyId.PC.CRTATK_BM });
			this.AutoUpdate(PropertyId.PC.CRTHR, new[] { PropertyId.PC.Lv, PropertyId.PC.CRTHR_BM });
			this.AutoUpdate(PropertyId.PC.CRTDR, new[] { PropertyId.PC.Lv, PropertyId.PC.CRTDR_BM });
			this.AutoUpdate(PropertyId.PC.HR, new[] { PropertyId.PC.Lv, PropertyId.PC.STR, PropertyId.PC.HR_BM, PropertyId.PC.HR_RATE_BM });
			this.AutoUpdate(PropertyId.PC.DR, new[] { PropertyId.PC.Lv, PropertyId.PC.DEX, PropertyId.PC.DR_BM, PropertyId.PC.DR_RATE_BM });
			this.AutoUpdate(PropertyId.PC.BLK, new[] { PropertyId.PC.Lv, PropertyId.PC.CON, PropertyId.PC.BLK_BM, PropertyId.PC.BLK_RATE_BM });
			this.AutoUpdate(PropertyId.PC.BLK_BREAK, new[] { PropertyId.PC.Lv, PropertyId.PC.DEX, PropertyId.PC.BLK_BREAK_BM, PropertyId.PC.BLK_BREAK_RATE_BM });
			this.AutoUpdate(PropertyId.PC.SR, new[] { PropertyId.PC.SR_BM });
			this.AutoUpdate(PropertyId.PC.SDR, new[] { PropertyId.PC.SDR_BM });

			this.AutoUpdateMax(PropertyId.PC.HP, PropertyId.PC.MHP);
			this.AutoUpdateMax(PropertyId.PC.SP, PropertyId.PC.MSP);
		}

		/// <summary>
		/// Returns the character's maximum HP.
		/// </summary>
		public float GetMHP()
		{
			var level = this.GetFloat(PropertyId.PC.Lv);
			var stat = this.GetFloat(PropertyId.PC.CON);
			var rateByJob = this.Character.Job?.Data.HpRate ?? 1;

			var byJob = Math.Floor(400 * rateByJob);
			var byLevel = Math.Floor(byJob + ((level - 1) * 80 * rateByJob));
			var byStat = Math.Floor(((stat * 0.005f) + (Math.Floor(stat / 10.0f) * 0.015f)) * byLevel);
			var byItem = 0; // TODO: "MHP"

			// Buffs: "MHP_BM"
			var byBuffs = 0;

			// "MHP_Bonus"
			var byBonus = 0;

			var value = byLevel + byStat + byItem + byBuffs + byBonus;

			return (int)value;
		}

		/// <summary>
		/// Returns the character's maximum SP.
		/// </summary>
		public float GetMSP()
		{
			var level = this.GetFloat(PropertyId.PC.Lv);
			var stat = this.GetFloat(PropertyId.PC.MNA);
			var rateByJob = this.Character.Job?.Data.SpRate ?? 1;

			var byJob = Math.Floor(200 * rateByJob);
			var byLevel = Math.Floor(byJob + ((level - 1) * 12 * rateByJob));
			var byStat = Math.Floor(((stat * 0.005f) + (Math.Floor(stat / 10.0f) * 0.015f)) * byLevel);
			var byItem = 0; // TODO: "MSP"

			// "MSP_Bonus"
			var byBonus = 0;

			// Buffs: "MSP_BM"
			var byBuffs = 0;

			var value = byLevel + byStat + byItem + byBuffs + byBonus;

			return (int)value;
		}

		/// <summary>
		/// Gets or set Stamina, clamped between 0 and MaxStamina.
		/// </summary>
		public int Stamina
		{
			get => _stamina;
			set => _stamina = (int)Math2.Clamp(0, this.GetMaxSta(), value);
		}
		private int _stamina;

		/// <summary>
		/// Returns the character's maximum stamina.
		/// </summary>
		public float GetMaxSta()
		{
			// TODO: Item and buff bonus.
			return this.Character.Job?.Data.Stamina ?? 1;
		}

		/// <summary>
		/// Returns HP recovery.
		/// </summary>
		public float GetRHP()
		{
			var level = this.GetFloat(PropertyId.PC.Lv);
			var stat = this.GetFloat(PropertyId.PC.CON);
			var rateByJob = this.Character.Job?.Data.HpRate ?? 1;

			var byLevel = level * rateByJob;
			var byStat = (stat * 2f) + ((float)Math.Floor(stat / 5f) * 3f);
			var byItem = 0f; // TODO

			var value = byLevel + byStat + byItem;

			// Buffs: "RHP_BM"
			var byBuffs = 0;

			// Rate buffs: 
			var rate = 0;
			var byRateBuffs = (float)Math.Floor(value * rate);

			value += byBuffs;

			return (int)value;
		}

		/// <summary>
		/// Returns HP recovery time.
		/// </summary>
		public float GetRHPTIME()
		{
			var baseValue = 20000;

			var byItem = 0f; // TODO

			// Buffs: "RHPTIME_BM"
			var byBuffs = 0;

			var value = baseValue - byItem - byBuffs;

			if (this.Character.IsSitting)
				value *= 0.5f;

			if (value < 1000)
				value = 1000;

			return (float)Math.Floor(value);
		}

		/// <summary>
		/// Returns SP recovery.
		/// </summary>
		public float GetRSP()
		{
			var level = this.GetFloat(PropertyId.PC.Lv);
			var stat = this.GetFloat(PropertyId.PC.MNA);
			var rateByJob = this.Character.Job?.Data.SpRate ?? 1;

			var byLevel = level * rateByJob;
			var byStat = (stat * 2f) + ((float)Math.Floor(stat / 5f) * 3f);
			var byItem = 0f; // TODO

			var value = byLevel + byStat + byItem;

			// Buffs: "RSP_BM"
			var byBuffs = 0;

			// Rate buffs: 
			var rate = 0;
			var byRateBuffs = (float)Math.Floor(value * rate);

			value += byBuffs;

			return (int)value;
		}

		/// <summary>
		/// Returns SP recovery time.
		/// </summary>
		public float GetRSPTIME()
		{
			var baseValue = 20000;

			var byItem = 0f; // TODO

			// Buffs: "RSPTIME_BM"
			var byBuffs = 0;

			var value = baseValue - byItem - byBuffs;

			if (this.Character.IsSitting)
				value *= 0.5f;

			if (value < 1000)
				value = 1000;

			return (float)Math.Floor(value);
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
			var byLevel = (int)this.GetFloat(PropertyId.PC.StatByLevel);
			var byBonus = (int)this.GetFloat(PropertyId.PC.StatByBonus);
			var usedStat = (int)this.GetFloat(PropertyId.PC.UsedStat);

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
			var defaultStat = 0;

			var byJob = this.GetFloat(PropertyId.PC.STR_JOB);
			var byStat = this.GetFloat(PropertyId.PC.STR_STAT);
			var byBonus = this.GetFloat(PropertyId.PC.STR_Bonus);
			var byAdd = this.GetFloat(PropertyId.PC.STR_ADD);
			var byTemp = 0; // this.GetFloat(PropertyId.PC.STR_TEMP);

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
			var defaultStat = 0;

			var byJob = this.GetFloat(PropertyId.PC.CON_JOB);
			var byStat = this.GetFloat(PropertyId.PC.CON_STAT);
			var byBonus = this.GetFloat(PropertyId.PC.CON_Bonus);
			var byAdd = this.GetFloat(PropertyId.PC.CON_ADD);
			var byTemp = 0; // this.GetFloat(PropertyId.PC.CON_TEMP);

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
			var defaultStat = 0;

			var byJob = this.GetFloat(PropertyId.PC.INT_JOB);
			var byStat = this.GetFloat(PropertyId.PC.INT_STAT);
			var byBonus = this.GetFloat(PropertyId.PC.INT_Bonus);
			var byAdd = this.GetFloat(PropertyId.PC.INT_ADD);
			var byTemp = 0; // this.GetFloat(PropertyId.PC.INT_TEMP);

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
			var defaultStat = 0;

			var byJob = this.GetFloat(PropertyId.PC.MNA_JOB);
			var byStat = this.GetFloat(PropertyId.PC.MNA_STAT);
			var byBonus = this.GetFloat(PropertyId.PC.MNA_Bonus);
			var byAdd = this.GetFloat(PropertyId.PC.MNA_ADD);
			var byTemp = 0; // this.GetFloat(PropertyId.PC.MNA_TEMP);

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
			var defaultStat = 0;

			var byJob = this.GetFloat(PropertyId.PC.DEX_JOB);
			var byStat = this.GetFloat(PropertyId.PC.DEX_STAT);
			var byBonus = this.GetFloat(PropertyId.PC.DEX_Bonus);
			var byAdd = this.GetFloat(PropertyId.PC.DEX_ADD);
			var byTemp = 0; // this.GetFloat(PropertyId.PC.DEX_TEMP);

			var rewardProperty = 0; // GET_REWARD_PROPERTY(self, statString);

			var result = defaultStat + byJob + byStat + byBonus + byAdd + byTemp + rewardProperty;
			return (float)Math.Floor(Math.Max(1, result));
		}

		/// <summary>
		/// Returns minimum physical ATK.
		/// </summary>
		public float GetMINPATK()
		{
			var baseValue = 20;
			var level = this.GetFloat(PropertyId.PC.Lv);
			var stat = this.GetFloat(PropertyId.PC.STR);

			var byLevel = level / 2f;
			var byStat = (stat * 2f) + ((float)Math.Floor(stat / 10f) * 5f);
			var byItem = 0; // TODO: Cached MinPAtk for inventory/equip ("MINATK", "PATK", "ADD_MINATK")

			var value = baseValue + byLevel + byStat + byItem;

			// Reducation for shields and stuff?
			//value -= leftHand.MinAtk;
			//if(hasBuff("Warrior_RH_VisibleObject"))
			//    value -= rightHand.MinAtk

			// Buffs: "PATK_BM", "MINPATK_BM"
			var byBuffs = 0;

			// Rate buffs: "PATK_RATE_BM", "MINPATK_RATE_BM"
			//if(hasBuff("Guardian"))
			//	rate -= SkillLevel
			var rate = 0;
			var byRateBuffs = (float)Math.Floor(value * rate);

			value += byBuffs + byRateBuffs;

			var maxPatk = this.GetMAXPATK();
			if (value > maxPatk)
				return maxPatk;

			return (int)value;
		}

		/// <summary>
		/// Returns maximum physical ATK.
		/// </summary>
		public float GetMAXPATK()
		{
			var baseValue = 20;
			var level = this.GetFloat(PropertyId.PC.Lv);
			var stat = this.GetFloat(PropertyId.PC.STR);

			var byLevel = level / 2f;
			var byStat = (stat * 2f) + ((float)Math.Floor(stat / 10f) * 5f);
			var byItem = 0; // TODO: Cached MinPAtk for inventory/equip ("MAXATK", "PATK", "ADD_MAXATK")

			var value = baseValue + byLevel + byStat + byItem;

			// Reducation for shields and stuff?
			//value -= leftHand.MaxAtk;
			//if(hasBuff("Warrior_RH_VisibleObject"))
			//    value -= rightHand.MaxAtk;

			// Buffs: "PATK_BM", "MAXPATK_BM"
			var byBuffs = 0;

			// Rate buffs: "PATK_RATE_BM", "MAXPATK_RATE_BM"
			//if(hasBuff("Guardian"))
			//	rate -= SkillLevel
			var rate = 0;
			var byRateBuffs = (float)Math.Floor(value * rate);

			value += byBuffs + byRateBuffs;

			return (int)value;
		}

		/// <summary>
		/// Returns minimum physical ATK (for sub-weapon?).
		/// </summary>
		public float GetMINPATK_SUB()
		{
			var baseValue = 20;
			var level = this.GetFloat(PropertyId.PC.Lv);
			var stat = this.GetFloat(PropertyId.PC.STR);

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
			var level = this.GetFloat(PropertyId.PC.Lv);
			var stat = this.GetFloat(PropertyId.PC.STR);

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
			var baseValue = 20;
			var level = this.GetFloat(PropertyId.PC.Lv);
			var stat = this.GetFloat(PropertyId.PC.INT);

			var byLevel = level / 2f;
			var byStat = (stat * 2f) + ((float)Math.Floor(stat / 10f) * 5f);
			var byItem = 0; // TODO: Cached MinPAtk for inventory/equip ("MATK", "ADD_MATK", "ADD_MINATK")

			var value = baseValue + byLevel + byStat + byItem;

			//if(hasBuff("Warrior_RH_VisibleObject"))
			//    value -= rightHand.MAtk

			// Buffs: "MATK_BM", "MINMATK_BM"
			var byBuffs = 0;

			// Rate buffs: "MATK_RATE_BM", "MINMATK_RATE_BM"
			var rate = 0;
			var byRateBuffs = (float)Math.Floor(value * rate);

			value += byBuffs + byRateBuffs;

			var max = this.GetMAXMATK();
			if (value > max)
				return max;

			return (int)value;
		}

		/// <summary>
		/// Returns maximum magic ATK.
		/// </summary>
		public float GetMAXMATK()
		{
			var baseValue = 20;
			var level = this.GetFloat(PropertyId.PC.Lv);
			var stat = this.GetFloat(PropertyId.PC.INT);

			var byLevel = level / 2f;
			var byStat = (stat * 2f) + ((float)Math.Floor(stat / 10f) * 5f);
			var byItem = 0; // TODO: Cached MinPAtk for inventory/equip ("MATK", "ADD_MATK", "ADD_MAXATK")

			var value = baseValue + byLevel + byStat + byItem;

			//if(hasBuff("Warrior_RH_VisibleObject"))
			//    value -= rightHand.MAtk

			// Buffs: "MATK_BM", "MAXMATK_BM"
			var byBuffs = 0;

			// Rate buffs: "MATK_RATE_BM", "MAXMATK_RATE_BM"
			var rate = 0;
			var byRateBuffs = (float)Math.Floor(value * rate);

			value += byBuffs + byRateBuffs;

			return (int)value;
		}

		/// <summary>
		/// Returns Physical Defense.
		/// </summary>
		public float GetDEF()
		{
			var baseValue = 20;
			var level = this.GetFloat(PropertyId.PC.Lv);

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
			var level = this.GetFloat(PropertyId.PC.Lv);

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
			var stat = this.GetFloat(PropertyId.PC.DEX);

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
			var level = this.GetFloat(PropertyId.PC.Lv);

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
			var level = this.GetFloat(PropertyId.PC.Lv);

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
			var level = this.GetFloat(PropertyId.PC.Lv);
			var stat = this.GetFloat(PropertyId.PC.STR);

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
			var level = this.GetFloat(PropertyId.PC.Lv);
			var stat = this.GetFloat(PropertyId.PC.DEX);

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

			var Level = this.GetFloat(PropertyId.PC.Lv);
			var stat = this.GetFloat(PropertyId.PC.CON);

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
			var level = this.GetFloat(PropertyId.PC.Lv);
			var stat = this.GetFloat(PropertyId.PC.DEX);

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
			var byBuff = this.GetFloat(PropertyId.PC.MSPD_BM);
			var byBonus = this.GetFloat(PropertyId.PC.MSPD_Bonus);

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
			var byBuff = this.GetFloat(PropertyId.PC.CastingSpeed_BM);

			var result = byDefault + byBuff;
			return (float)Math.Floor(Math2.Clamp(10, 200, result));
		}
	}
}
