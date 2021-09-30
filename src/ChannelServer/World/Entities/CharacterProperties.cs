using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Const;
using Melia.Shared.Util;
using Melia.Shared.World.ObjectProperties;

namespace Melia.Channel.World.Entities
{
	public class CharacterProperties : Properties
	{
		public Character Character { get; }

		public CharacterProperties(Character character)
		{
			this.Character = character;
			this.AddDefaultProperties();
			this.AddAutoUpdates();
		}

		/// <summary>
		/// Adds default reference properties.
		/// </summary>
		public void AddDefaultProperties()
		{
			this.Add(new FloatProperty(PropertyId.PC.Lv, 1, min: 1));

			this.Add(new FloatProperty(PropertyId.PC.STR_JOB));
			this.Add(new FloatProperty(PropertyId.PC.STR_STAT));
			this.Add(new CalculatedFloatProperty(PropertyId.PC.STR_ADD, this.GetSTR_ADD));
			this.Add(new CalculatedFloatProperty(PropertyId.PC.STR, this.GetSTR));

			this.Add(new FloatProperty(PropertyId.PC.CON_JOB));
			this.Add(new FloatProperty(PropertyId.PC.CON_STAT));
			this.Add(new CalculatedFloatProperty(PropertyId.PC.CON_ADD, this.GetCON_ADD));
			this.Add(new CalculatedFloatProperty(PropertyId.PC.CON, this.GetCON));

			this.Add(new FloatProperty(PropertyId.PC.INT_JOB));
			this.Add(new FloatProperty(PropertyId.PC.INT_STAT));
			this.Add(new CalculatedFloatProperty(PropertyId.PC.INT_ADD, this.GetINT_ADD));
			this.Add(new CalculatedFloatProperty(PropertyId.PC.INT, this.GetINT));

			this.Add(new FloatProperty(PropertyId.PC.MNA_JOB));
			this.Add(new FloatProperty(PropertyId.PC.MNA_STAT));
			this.Add(new CalculatedFloatProperty(PropertyId.PC.MNA_ADD, this.GetMNA_ADD));
			this.Add(new CalculatedFloatProperty(PropertyId.PC.MNA, this.GetMNA));

			this.Add(new FloatProperty(PropertyId.PC.DEX_JOB));
			this.Add(new FloatProperty(PropertyId.PC.DEX_STAT));
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

			//// Element Property Attack
			//this.Add(new RefFloatProperty(PropertyId.PC.Fire_Atk, () => this.FireAtk));
			//this.Add(new RefFloatProperty(PropertyId.PC.Ice_Atk, () => this.IceAtk));
			//this.Add(new RefFloatProperty(PropertyId.PC.Lightning_Atk, () => this.LightningAtk));
			//this.Add(new RefFloatProperty(PropertyId.PC.Soul_Atk, () => this.SoulAtk));
			//this.Add(new RefFloatProperty(PropertyId.PC.Earth_Atk, () => this.EarthAtk));
			//this.Add(new RefFloatProperty(PropertyId.PC.Poison_Atk, () => this.PoisonAtk));
			//this.Add(new RefFloatProperty(PropertyId.PC.Holy_Atk, () => this.HolyAtk));
			//this.Add(new RefFloatProperty(PropertyId.PC.Dark_Atk, () => this.DarkAtk));

			//// Size type Attack
			//this.Add(new RefFloatProperty(PropertyId.PC.SmallSize_Atk, () => this.SmallSizeAtk));
			//this.Add(new RefFloatProperty(PropertyId.PC.MiddleSize_Atk, () => this.MediumSizeAtk));
			//this.Add(new RefFloatProperty(PropertyId.PC.LargeSize_Atk, () => this.LargeSizeAtk));

			//// Armor type attack
			//this.Add(new RefFloatProperty(PropertyId.PC.Cloth_Atk, () => this.ClothAtk));
			//this.Add(new RefFloatProperty(PropertyId.PC.Leather_Atk, () => this.LeatherAtk));
			//this.Add(new RefFloatProperty(PropertyId.PC.Iron_Atk, () => this.IronAtk));
			//this.Add(new RefFloatProperty(PropertyId.PC.Ghost_Atk, () => this.GhostAtk));
			////this.Add(new RefFloatProperty(PropertyId.PC.Chain_Atk, () => 5));	// Not implemented?

			//// Race type Attack
			//this.Add(new RefFloatProperty(PropertyId.PC.Forester_Atk, () => this.PlantAtk));
			//this.Add(new RefFloatProperty(PropertyId.PC.Widling_Atk, () => this.BeastAtk));
			//this.Add(new RefFloatProperty(PropertyId.PC.Klaida_Atk, () => this.InsectAtk));
			//this.Add(new RefFloatProperty(PropertyId.PC.Paramune_Atk, () => this.MutantAtk));
			//this.Add(new RefFloatProperty(PropertyId.PC.Velnias_Atk, () => this.DevilAtk));

			//// Armor typ Defense
			//this.Add(new RefFloatProperty(PropertyId.PC.DefAries, () => this.PierceDefense));
			//this.Add(new RefFloatProperty(PropertyId.PC.DefSlash, () => this.SlashDefense));
			//this.Add(new RefFloatProperty(PropertyId.PC.DefStrike, () => this.StrikeDefense));

			//// Element Resistance
			//this.Add(new RefFloatProperty(PropertyId.PC.ResFire, () => this.FireResistance));
			//this.Add(new RefFloatProperty(PropertyId.PC.ResIce, () => this.IceResistance));
			//this.Add(new RefFloatProperty(PropertyId.PC.ResLightning, () => this.LightningResistance));
			//this.Add(new RefFloatProperty(PropertyId.PC.ResEarth, () => this.EarthResistance));
			//this.Add(new RefFloatProperty(PropertyId.PC.ResSoul, () => this.SoulResistance));
			//this.Add(new RefFloatProperty(PropertyId.PC.ResPoison, () => this.PoisonResistance));
			//this.Add(new RefFloatProperty(PropertyId.PC.ResHoly, () => this.HolyResistance));
			//this.Add(new RefFloatProperty(PropertyId.PC.ResDark, () => this.DarkResistance));

			//// Attack Factor
			//this.Add(new RefFloatProperty(PropertyId.PC.AriesAtkFactor_PC, () => this.PierceAtkFactor));
			//this.Add(new RefFloatProperty(PropertyId.PC.SlashAtkFactor_PC, () => this.SlashAtkFactor));
			//this.Add(new RefFloatProperty(PropertyId.PC.StrikeAtkFactor_PC, () => this.StrikeAtkFactor));
			//this.Add(new RefFloatProperty(PropertyId.PC.MissileAtkFactor_PC, () => this.MissileAtkFactor));
			//this.Add(new RefFloatProperty(PropertyId.PC.FireAtkFactor_PC, () => this.FireAtkFactor));
			//this.Add(new RefFloatProperty(PropertyId.PC.IceAtkFactor_PC, () => this.IceAtkFactor));
			//this.Add(new RefFloatProperty(PropertyId.PC.LightningAtkFactor_PC, () => this.LightningAtkFactor));
			//this.Add(new RefFloatProperty(PropertyId.PC.EarthAtkFactor_PC, () => this.EarthAtkFactor));
			//this.Add(new RefFloatProperty(PropertyId.PC.SoulAtkFactor_PC, () => this.SoulAtkFactor));
			//this.Add(new RefFloatProperty(PropertyId.PC.PoisonAtkFactor_PC, () => this.PoisonAtkFactor));
			//this.Add(new RefFloatProperty(PropertyId.PC.HolyAtkFactor_PC, () => this.HolyAtkFactor));
			//this.Add(new RefFloatProperty(PropertyId.PC.DarkAtkFactor_PC, () => this.DarkAtkFactor));

			//// Defense Factor
			//this.Add(new RefFloatProperty(PropertyId.PC.AriesAtkFactor_PC, () => this.PierceAtkFactor));
			//this.Add(new RefFloatProperty(PropertyId.PC.SlashAtkFactor_PC, () => this.SlashAtkFactor));
			//this.Add(new RefFloatProperty(PropertyId.PC.StrikeAtkFactor_PC, () => this.StrikeAtkFactor));
			//this.Add(new RefFloatProperty(PropertyId.PC.MissileAtkFactor_PC, () => this.MissileAtkFactor));
			//this.Add(new RefFloatProperty(PropertyId.PC.FireAtkFactor_PC, () => this.FireAtkFactor));
			//this.Add(new RefFloatProperty(PropertyId.PC.IceAtkFactor_PC, () => this.IceAtkFactor));
			//this.Add(new RefFloatProperty(PropertyId.PC.LightningAtkFactor_PC, () => this.LightningAtkFactor));
			//this.Add(new RefFloatProperty(PropertyId.PC.EarthAtkFactor_PC, () => this.EarthAtkFactor));
			//this.Add(new RefFloatProperty(PropertyId.PC.SoulAtkFactor_PC, () => this.SoulAtkFactor));
			//this.Add(new RefFloatProperty(PropertyId.PC.PoisonAtkFactor_PC, () => this.PoisonAtkFactor));
			//this.Add(new RefFloatProperty(PropertyId.PC.HolyAtkFactor_PC, () => this.HolyAtkFactor));
			//this.Add(new RefFloatProperty(PropertyId.PC.DarkAtkFactor_PC, () => this.DarkAtkFactor));
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

		///// <summary>
		///// Gets or sets the character's Lv property.
		///// </summary>
		//public int Level
		//{
		//	get => (int)this.GetFloat(PropertyId.PC.Lv);
		//	//set => this.Set(PropertyId.PC.Lv, value);
		//}

		///// <summary>
		///// Gets or set HP, clamped between 0 and MaxHp.
		///// </summary>
		//public int Hp
		//{
		//	get => (int)this.GetFloat(PropertyId.PC.HP);
		//	//set => this.Set(PropertyId.PC.HP, value);
		//}

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

		///// <summary>
		///// Gets or sets SP, clamped between 0 and MSP.
		///// </summary>
		//public int Sp
		//{
		//	get => (int)this.GetFloat(PropertyId.PC.SP);
		//	//set => this.Set(PropertyId.PC.SP, value);
		//}

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

		///// <summary>
		///// Stat points acquired by leveling.
		///// </summary>
		//public int StatByLevel
		//{
		//	get { return _statByLevel; }
		//	//set { _statByLevel = Math2.Clamp(0, short.MaxValue, value); }
		//}
		//private int _statByLevel;

		///// <summary>
		///// Stat points acquired by other means than leveling.
		///// </summary>
		//public int StatByBonus
		//{
		//	get { return _statByBonus; }
		//	//set { _statByBonus = Math2.Clamp(0, short.MaxValue, value); }
		//}
		//private int _statByBonus;

		///// <summary>
		///// Amount of stat points spent.
		///// </summary>
		///// <remarks>
		///// Clamped between 0 and total amount of character's stat points.
		///// </remarks>
		//public int UsedStat
		//{
		//	get { return _usedStat; }
		//	//set { _usedStat = Math2.Clamp(0, this.StatByLevel + this.StatByBonus, value); }
		//}
		//private int _usedStat;

		/// <summary>
		/// Gets or set the character's ability points.
		/// </summary>
		/// <remarks>
		/// Clamped between 0 and short.Max.
		/// </remarks>
		//public int AbilityPoints
		//{
		//	get { return _abilityPoints; }
		//	set { _abilityPoints = Math2.Clamp(0, short.MaxValue, value); }
		//}
		//private int _abilityPoints;

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

			var byJob = this.GetFloat(PropertyId.PC.MNA);
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

			var byJob = this.GetFloat(PropertyId.PC.DEX);
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

		///// <summary>
		///// Returns Fire Property Attack.
		///// </summary>
		//public int FireAtk
		//{
		//	get
		//	{
		//		var byItem = 0f; // TODO: "ADD_FIRE"
		//		var value = byItem;

		//		// Buffs: "Fire_Atk_BM"
		//		var byBuffs = 0;

		//		value += byBuffs;

		//		return (int)value;
		//	}
		//}

		///// <summary>
		///// Returns Ice Property Attack.
		///// </summary>
		//public int IceAtk
		//{
		//	get
		//	{
		//		var byItem = 0f; // TODO: "ADD_ICE"
		//		var value = byItem;

		//		// Buffs: "Ice_Atk_BM"
		//		var byBuffs = 0;

		//		value += byBuffs;

		//		return (int)value;
		//	}
		//}

		///// <summary>
		///// Returns Lightning Property Attack.
		///// </summary>
		//public int LightningAtk
		//{
		//	get
		//	{
		//		var byItem = 0f; // TODO: "ADD_LIGHTNING"
		//		var value = byItem;

		//		// Buffs: "Lightning_Atk_BM"
		//		var byBuffs = 0;

		//		value += byBuffs;

		//		return (int)value;
		//	}
		//}

		///// <summary>
		///// Returns Psychokinesis Property Attack.
		///// </summary>
		//public int SoulAtk
		//{
		//	get
		//	{
		//		var byItem = 0f; // TODO: "ADD_SOUL"
		//		var value = byItem;

		//		// Buffs: "Soul_Atk_BM"
		//		var byBuffs = 0;

		//		value += byBuffs;

		//		return (int)value;
		//	}
		//}

		///// <summary>
		///// Returns Earth Property Attack.
		///// </summary>
		//public int EarthAtk
		//{
		//	get
		//	{
		//		var byItem = 0f; // TODO: "Earth_Atk"
		//		var value = byItem;

		//		// Buffs: "Earth_Atk_BM"
		//		var byBuffs = 0;

		//		value += byBuffs;

		//		return (int)value;
		//	}
		//}

		///// <summary>
		///// Returns Poison Property Attack.
		///// </summary>
		//public int PoisonAtk
		//{
		//	get
		//	{
		//		var byItem = 0f; // TODO: "ADD_POISON"
		//		var value = byItem;

		//		// Buffs: "Poison_Atk_BM"
		//		var byBuffs = 0;

		//		value += byBuffs;

		//		return (int)value;
		//	}
		//}

		///// <summary>
		///// Returns Holy Property Attack.
		///// </summary>
		//public int HolyAtk
		//{
		//	get
		//	{
		//		var byItem = 0f; // TODO: "ADD_HOLY"
		//		var value = byItem;

		//		// Buffs: "Holy_Atk_BM"
		//		var byBuffs = 0;

		//		value += byBuffs;

		//		return (int)value;
		//	}
		//}

		///// <summary>
		///// Returns Dark Property Attack.
		///// </summary>
		//public int DarkAtk
		//{
		//	get
		//	{
		//		var byItem = 0f; // TODO: "ADD_DARK"
		//		var value = byItem;

		//		// Buffs: "Dark_Atk_BM"
		//		var byBuffs = 0;

		//		value += byBuffs;

		//		return (int)value;
		//	}
		//}

		///// <summary>
		///// Returns Small size Attack.
		///// </summary>
		//public int SmallSizeAtk
		//{
		//	get
		//	{
		//		var byItem = 0f; // TODO: "ADD_SMALLSIZE"
		//		var value = byItem;

		//		// Buffs: "SmallSize_Atk_BM"
		//		var byBuffs = 0;

		//		value += byBuffs;

		//		return (int)value;
		//	}
		//}

		///// <summary>
		///// Returns Medium size Attack.
		///// </summary>
		//public int MediumSizeAtk
		//{
		//	get
		//	{
		//		var byItem = 0f; // TODO: "ADD_MIDDLESIZE"
		//		var value = byItem;

		//		// Buffs: "MiddleSize_Atk_BM"
		//		var byBuffs = 0;

		//		value += byBuffs;

		//		return (int)value;
		//	}
		//}

		///// <summary>
		///// Returns Large size Attack.
		///// </summary>
		//public int LargeSizeAtk
		//{
		//	get
		//	{
		//		var byItem = 0f; // TODO: "ADD_LARGESIZE"
		//		var value = byItem;

		//		// Buffs: "LargeSize_Atk_BM"
		//		var byBuffs = 0;

		//		value += byBuffs;

		//		return (int)value;
		//	}
		//}

		///// <summary>
		///// Returns Cloth type Attack.
		///// </summary>
		//public int ClothAtk
		//{
		//	get
		//	{
		//		var byItem = 0f; // TODO: "ADD_CLOTH"
		//		var value = byItem;

		//		// Buffs: "Cloth_Atk_BM"
		//		var byBuffs = 0;

		//		value += byBuffs;

		//		return (int)value;
		//	}
		//}

		///// <summary>
		///// Returns Leather type Attack.
		///// </summary>
		//public int LeatherAtk
		//{
		//	get
		//	{
		//		var byItem = 0f; // TODO: "ADD_LEATHER"
		//		var value = byItem;

		//		// Buffs: "Leather_Atk_BM"
		//		var byBuffs = 0;

		//		value += byBuffs;

		//		return (int)value;
		//	}
		//}

		///// <summary>
		///// Returns Plate type Attack.
		///// </summary>
		//public int IronAtk
		//{
		//	get
		//	{
		//		var byItem = 0f; // TODO: "ADD_IRON"
		//		var value = byItem;

		//		// Buffs: "Iron_Atk_BM"
		//		var byBuffs = 0;

		//		value += byBuffs;

		//		return (int)value;
		//	}
		//}

		///// <summary>
		///// Returns Ghost type Attack.
		///// </summary>
		//public int GhostAtk
		//{
		//	get
		//	{
		//		var byItem = 0f; // TODO: "ADD_GHOST"
		//		var value = byItem;

		//		// Buffs: "Ghost_Atk_BM"
		//		var byBuffs = 0;

		//		value += byBuffs;

		//		return (int)value;
		//	}
		//}

		///// <summary>
		///// Returns Plant type Attack.
		///// </summary>
		//public int PlantAtk
		//{
		//	get
		//	{
		//		var byItem = 0f; // TODO: "ADD_FORESTER"
		//		var value = byItem;

		//		// Buffs: "Forester_Atk_BM"
		//		var byBuffs = 0;

		//		value += byBuffs;

		//		return (int)value;
		//	}
		//}

		///// <summary>
		///// Returns Beast type Attack.
		///// </summary>
		//public int BeastAtk
		//{
		//	get
		//	{
		//		var byItem = 0f; // TODO: "ADD_WIDLING"
		//		var value = byItem;

		//		// Buffs: "Widling_Atk_BM"
		//		var byBuffs = 0;

		//		value += byBuffs;

		//		return (int)value;
		//	}
		//}

		///// <summary>
		///// Returns Insect type Attack.
		///// </summary>
		//public int InsectAtk
		//{
		//	get
		//	{
		//		var byItem = 0f; // TODO: "ADD_KLAIDA"
		//		var value = byItem;

		//		// Buffs: "Klaida_Atk_BM"
		//		var byBuffs = 0;

		//		value += byBuffs;

		//		return (int)value;
		//	}
		//}

		///// <summary>
		///// Returns Mutant type Attack.
		///// </summary>
		//public int MutantAtk
		//{
		//	get
		//	{
		//		var byItem = 0f; // TODO: "ADD_PARAMUNE"
		//		var value = byItem;

		//		// Buffs: "Paramune_Atk_BM"
		//		var byBuffs = 0;

		//		value += byBuffs;

		//		return (int)value;
		//	}
		//}

		///// <summary>
		///// Returns Devil type Attack.
		///// </summary>
		//public int DevilAtk
		//{
		//	get
		//	{
		//		var byItem = 0f; // TODO: "ADD_VELIAS"
		//		var value = byItem;

		//		// Buffs: "Velnias_Atk_BM"
		//		var byBuffs = 0;

		//		value += byBuffs;

		//		return (int)value;
		//	}
		//}

		///// <summary>
		///// Returns Pierce type Defense.
		///// </summary>
		//public int PierceDefense
		//{
		//	get
		//	{
		//		var byItem = 0f; // TODO: "AriesDEF"
		//		var value = byItem;

		//		// Buffs: "DefAries_BM"
		//		var byBuffs = 0;

		//		value += byBuffs;

		//		return (int)value;
		//	}
		//}

		///// <summary>
		///// Returns Slash type Defense.
		///// </summary>
		//public int SlashDefense
		//{
		//	get
		//	{
		//		var byItem = 0f; // TODO: "SlashDEF"
		//		var value = byItem;

		//		// Buffs: "DefSlash_BM"
		//		var byBuffs = 0;

		//		value += byBuffs;

		//		return (int)value;
		//	}
		//}

		///// <summary>
		///// Returns Strike type Defense.
		///// </summary>
		//public int StrikeDefense
		//{
		//	get
		//	{
		//		var byItem = 0f; // TODO: "StrikeDEF"
		//		var value = byItem;

		//		// Buffs: "DefStrike_BM"
		//		var byBuffs = 0;

		//		value += byBuffs;

		//		return (int)value;
		//	}
		//}

		///// <summary>
		///// Returns Fire Resistance.
		///// </summary>
		//public int FireResistance
		//{
		//	get
		//	{
		//		var byItem = 0f; // TODO: "RES_FIRE"
		//		var value = byItem;

		//		// Buffs: "ResFire_BM"
		//		var byBuffs = 0;

		//		value += byBuffs;

		//		return (int)value;
		//	}
		//}

		///// <summary>
		///// Returns Ice Resistance.
		///// </summary>
		//public int IceResistance
		//{
		//	get
		//	{
		//		var byItem = 0f; // TODO: "RES_ICE"
		//		var value = byItem;

		//		// Buffs: "ResIce_BM"
		//		var byBuffs = 0;

		//		value += byBuffs;

		//		return (int)value;
		//	}
		//}

		///// <summary>
		///// Returns Lightning Resistance.
		///// </summary>
		//public int LightningResistance
		//{
		//	get
		//	{
		//		var byItem = 0f; // TODO: "RES_LIGHTNING"
		//		var value = byItem;

		//		// Buffs: "ResLightning_BM"
		//		var byBuffs = 0;

		//		value += byBuffs;

		//		return (int)value;
		//	}
		//}

		///// <summary>
		///// Returns Psychokinesis Resistance.
		///// </summary>
		//public int SoulResistance
		//{
		//	get
		//	{
		//		var byItem = 0f; // TODO: "RES_SOUL"
		//		var value = byItem;

		//		// Buffs: "ResSoul_BM"
		//		var byBuffs = 0;

		//		value += byBuffs;

		//		return (int)value;
		//	}
		//}

		///// <summary>
		///// Returns Earth Resistance.
		///// </summary>
		//public int EarthResistance
		//{
		//	get
		//	{
		//		var byItem = 0f; // TODO: "RES_EARTH"
		//		var value = byItem;

		//		// Buffs: "ResEarth_BM"
		//		var byBuffs = 0;

		//		value += byBuffs;

		//		return (int)value;
		//	}
		//}

		///// <summary>
		///// Returns Poison Resistance.
		///// </summary>
		//public int PoisonResistance
		//{
		//	get
		//	{
		//		var byItem = 0f; // TODO: "RES_POISON"
		//		var value = byItem;

		//		// Buffs: "ResPoison_BM"
		//		var byBuffs = 0;

		//		value += byBuffs;

		//		return (int)value;
		//	}
		//}

		///// <summary>
		///// Returns Holy Resistance.
		///// </summary>
		//public int HolyResistance
		//{
		//	get
		//	{
		//		var byItem = 0f; // TODO: "RES_HOLY"
		//		var value = byItem;

		//		// Buffs: "ResHoly_BM"
		//		var byBuffs = 0;

		//		value += byBuffs;

		//		return (int)value;
		//	}
		//}

		///// <summary>
		///// Returns Dark Resistance.
		///// </summary>
		//public int DarkResistance
		//{
		//	get
		//	{
		//		var byItem = 0f; // TODO: "RES_DARK"
		//		var value = byItem;

		//		// Buffs: "ResDark_BM"
		//		var byBuffs = 0;

		//		value += byBuffs;

		//		return (int)value;
		//	}
		//}

		///// <summary>
		///// Returns Pierce Attack Factor.
		///// </summary>
		//public int PierceAtkFactor
		//{
		//	get
		//	{
		//		// Buffs: "AriesAtkFactor_PC_BM"
		//		var byBuffs = 0;

		//		return (int)byBuffs;
		//	}
		//}

		///// <summary>
		///// Returns Slash Attack Factor.
		///// </summary>
		//public int SlashAtkFactor
		//{
		//	get
		//	{
		//		// Buffs: "SlashAtkFactor_PC_BM"
		//		var byBuffs = 0;

		//		return (int)byBuffs;
		//	}
		//}

		///// <summary>
		///// Returns Strike Attack Factor.
		///// </summary>
		//public int StrikeAtkFactor
		//{
		//	get
		//	{
		//		// Buffs: "StrikeAtkFactor_PC_BM"
		//		var byBuffs = 0;

		//		return (int)byBuffs;
		//	}
		//}

		///// <summary>
		///// Returns Missile Attack Factor.
		///// </summary>
		//public int MissileAtkFactor
		//{
		//	get
		//	{
		//		// Buffs: "MissileAtkFactor_PC_BM"
		//		var byBuffs = 0;

		//		return (int)byBuffs;
		//	}
		//}

		///// <summary>
		///// Returns Fire Property Attack Factor.
		///// </summary>
		//public int FireAtkFactor
		//{
		//	get
		//	{
		//		// Buffs: "FireAtkFactor_PC_BM"
		//		var byBuffs = 0;

		//		return (int)byBuffs;
		//	}
		//}

		///// <summary>
		///// Returns Ice Property Attack Factor.
		///// </summary>
		//public int IceAtkFactor
		//{
		//	get
		//	{
		//		// Buffs: "IceAtkFactor_PC_BM"
		//		var byBuffs = 0;

		//		return (int)byBuffs;
		//	}
		//}

		///// <summary>
		///// Returns Lightning Property Attack Factor.
		///// </summary>
		//public int LightningAtkFactor
		//{
		//	get
		//	{
		//		// Buffs: "LightningAtkFactor_PC_BM"
		//		var byBuffs = 0;

		//		return (int)byBuffs;
		//	}
		//}

		///// <summary>
		///// Returns Psychokinesis Property Attack Factor.
		///// </summary>
		//public int SoulAtkFactor
		//{
		//	get
		//	{
		//		// Buffs: "SoulAtkFactor_PC_BM"
		//		var byBuffs = 0;

		//		return (int)byBuffs;
		//	}
		//}

		///// <summary>
		///// Returns Poison Property Attack Factor.
		///// </summary>
		//public int PoisonAtkFactor
		//{
		//	get
		//	{
		//		// Buffs: "PoisonAtkFactor_PC_BM"
		//		var byBuffs = 0;

		//		return (int)byBuffs;
		//	}
		//}

		///// <summary>
		///// Returns Earth Property Attack Factor.
		///// </summary>
		//public int EarthAtkFactor
		//{
		//	get
		//	{
		//		// Buffs: "EarthAtkFactor_PC_BM"
		//		var byBuffs = 0;

		//		return (int)byBuffs;
		//	}
		//}

		///// <summary>
		///// Returns Holy Property Attack Factor.
		///// </summary>
		//public int HolyAtkFactor
		//{
		//	get
		//	{
		//		// Buffs: "HolyAtkFactor_PC_BM"
		//		var byBuffs = 0;

		//		return (int)byBuffs;
		//	}
		//}

		///// <summary>
		///// Returns Dark Property Attack Factor.
		///// </summary>
		//public int DarkAtkFactor
		//{
		//	get
		//	{
		//		// Buffs: "DarkAtkFactor_PC_BM"
		//		var byBuffs = 0;

		//		return (int)byBuffs;
		//	}
		//}

		///// <summary>
		///// Returns Pierce Property Defense Factor.
		///// </summary>
		//public int PierceDefenseFactor
		//{
		//	get
		//	{
		//		// Buffs: "AriesDefFactor_PC_BM"
		//		var byBuffs = 0;

		//		return (int)byBuffs;
		//	}
		//}

		///// <summary>
		///// Returns Slash Property Defense Factor.
		///// </summary>
		//public int SlashDefenseFactor
		//{
		//	get
		//	{
		//		// Buffs: "SlashDefFactor_PC_BM"
		//		var byBuffs = 0;

		//		return (int)byBuffs;
		//	}
		//}

		///// <summary>
		///// Returns Strike Property Defense Factor.
		///// </summary>
		//public int StrikeDefenseFactor
		//{
		//	get
		//	{
		//		// Buffs: "StrikeDefFactor_PC_BM"
		//		var byBuffs = 0;

		//		return (int)byBuffs;
		//	}
		//}

		///// <summary>
		///// Returns Missile Property Defense Factor.
		///// </summary>
		//public int MissileDefenseFactor
		//{
		//	get
		//	{
		//		// Buffs: "MissileDefFactor_PC_BM"
		//		var byBuffs = 0;

		//		return (int)byBuffs;
		//	}
		//}

		///// <summary>
		///// Returns Fire Property Defense Factor.
		///// </summary>
		//public int FireDefenseFactor
		//{
		//	get
		//	{
		//		// Buffs: "FireDefFactor_PC_BM"
		//		var byBuffs = 0;

		//		return (int)byBuffs;
		//	}
		//}

		///// <summary>
		///// Returns Ice Property Defense Factor.
		///// </summary>
		//public int IceDefenseFactor
		//{
		//	get
		//	{
		//		// Buffs: "IceDefFactor_PC_BM"
		//		var byBuffs = 0;

		//		return (int)byBuffs;
		//	}
		//}

		///// <summary>
		///// Returns Lightning Property Defense Factor.
		///// </summary>
		//public int LightningDefenseFactor
		//{
		//	get
		//	{
		//		// Buffs: "LightningDefFactor_PC_BM"
		//		var byBuffs = 0;

		//		return (int)byBuffs;
		//	}
		//}

		///// <summary>
		///// Returns Psychokinesis Property Defense Factor.
		///// </summary>
		//public int SoulDefenseFactor
		//{
		//	get
		//	{
		//		// Buffs: "SoulDefFactor_PC_BM"
		//		var byBuffs = 0;

		//		return (int)byBuffs;
		//	}
		//}

		///// <summary>
		///// Returns Poison Property Defense Factor.
		///// </summary>
		//public int PoisonDefenseFactor
		//{
		//	get
		//	{
		//		// Buffs: "PoisonDefFactor_PC_BM"
		//		var byBuffs = 0;

		//		return (int)byBuffs;
		//	}
		//}

		///// <summary>
		///// Returns Earth Property Defense Factor.
		///// </summary>
		//public int EarthDefenseFactor
		//{
		//	get
		//	{
		//		// Buffs: "EarthDefFactor_PC_BM"
		//		var byBuffs = 0;

		//		return (int)byBuffs;
		//	}
		//}

		///// <summary>
		///// Returns Holy Property Defense Factor.
		///// </summary>
		//public int HolyDefenseFactor
		//{
		//	get
		//	{
		//		// Buffs: "HolyDefFactor_PC_BM"
		//		var byBuffs = 0;

		//		return (int)byBuffs;
		//	}
		//}

		///// <summary>
		///// Returns Dark Property Defense Factor.
		///// </summary>
		//public int DarkDefenseFactor
		//{
		//	get
		//	{
		//		// Buffs: "DarkDefFactor_PC_BM"
		//		var byBuffs = 0;

		//		return (int)byBuffs;
		//	}
		//}
	}
}
