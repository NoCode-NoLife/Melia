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
			this.AddReferenceProperties();
		}

		/// <summary>
		/// Adds default reference properties.
		/// </summary>
		public void AddReferenceProperties()
		{
			// Beautiful. No duplication of any data, and we can use our
			// normal C# properties. XXX: We could technically use reflection
			// to add these automatically.

			this.Add(new RefFloatProperty(PropertyId.PC.Lv, () => this.Level));
			this.Add(new RefFloatProperty(PropertyId.PC.BeforeLv, () => this.Level));

			this.Add(new RefFloatProperty(PropertyId.PC.HP, () => this.Hp));
			this.Add(new RefFloatProperty(PropertyId.PC.MHP, () => this.MaxHp));
			this.Add(new RefFloatProperty(PropertyId.PC.SP, () => this.Sp));
			this.Add(new RefFloatProperty(PropertyId.PC.MSP, () => this.MaxSp));
			this.Add(new RefFloatProperty(PropertyId.PC.RHP, () => this.HPRecovery));
			this.Add(new RefFloatProperty(PropertyId.PC.RSP, () => this.SPRecovery));
			this.Add(new RefFloatProperty(PropertyId.PC.RHPTIME, () => this.HPRecoveryTime));
			this.Add(new RefFloatProperty(PropertyId.PC.RSPTIME, () => this.SPRecoveryTime));
			this.Add(new RefFloatProperty(PropertyId.PC.MaxSta, () => this.MaxStamina));

			this.Add(new RefFloatProperty(PropertyId.PC.STR, () => this.Str));
			this.Add(new RefFloatProperty(PropertyId.PC.STR_JOB, () => this.StrByJob));
			this.Add(new RefFloatProperty(PropertyId.PC.STR_STAT, () => this.StrInvested));
			this.Add(new RefFloatProperty(PropertyId.PC.STR_ADD, () => this.StrBonus));
			this.Add(new RefFloatProperty(PropertyId.PC.CON, () => this.Con));
			this.Add(new RefFloatProperty(PropertyId.PC.CON_JOB, () => this.ConByJob));
			this.Add(new RefFloatProperty(PropertyId.PC.CON_STAT, () => this.ConInvested));
			this.Add(new RefFloatProperty(PropertyId.PC.CON_ADD, () => this.ConBonus));
			this.Add(new RefFloatProperty(PropertyId.PC.INT, () => this.Int));
			this.Add(new RefFloatProperty(PropertyId.PC.INT_JOB, () => this.IntByJob));
			this.Add(new RefFloatProperty(PropertyId.PC.INT_STAT, () => this.IntInvested));
			this.Add(new RefFloatProperty(PropertyId.PC.INT_ADD, () => this.IntBonus));
			this.Add(new RefFloatProperty(PropertyId.PC.MNA, () => this.Spr));
			this.Add(new RefFloatProperty(PropertyId.PC.MNA_JOB, () => this.SprByJob));
			this.Add(new RefFloatProperty(PropertyId.PC.MNA_STAT, () => this.SprInvested));
			this.Add(new RefFloatProperty(PropertyId.PC.MNA_ADD, () => this.SprBonus));
			this.Add(new RefFloatProperty(PropertyId.PC.DEX, () => this.Dex));
			this.Add(new RefFloatProperty(PropertyId.PC.DEX_JOB, () => this.DexByJob));
			this.Add(new RefFloatProperty(PropertyId.PC.DEX_STAT, () => this.DexInvested));
			this.Add(new RefFloatProperty(PropertyId.PC.DEX_ADD, () => this.DexBonus));

			this.Add(new RefFloatProperty(PropertyId.PC.NowWeight, () => this.NowWeight));
			this.Add(new RefFloatProperty(PropertyId.PC.MaxWeight, () => this.MaxWeight));

			// When they removed manual stat allocation, they disabled the
			// code that added StatByLevel and StatByBonus together, that
			// would return the full stat point amount. Now, StatByLevel
			// is basically useless. Since we aren't auto-statting yet,
			// and we probably want an option to use either anyway, we're
			// going to combine both in StatByBonus and set StatByLevel to
			// 0. This way we're able to use our StatByLevel points and
			// manage the points in separate properties on the server,
			// while the client simply displays the full amount.
			this.Add(new RefFloatProperty(PropertyId.PC.StatByLevel, () => 0));
			this.Add(new RefFloatProperty(PropertyId.PC.StatByBonus, () => this.StatByLevel + this.StatByBonus));

			//this.Add(new RefFloatProperty(PropertyId.PC.StatPoint, () => this.StatPoints));
			this.Add(new RefFloatProperty(PropertyId.PC.UsedStat, () => this.UsedStat));
			this.Add(new RefStringProperty(PropertyId.PC.AbilityPoint, () => this.AbilityPoints.ToString()));

			this.Add(new RefFloatProperty(PropertyId.PC.SR, () => this.SplashRate));

			this.Add(new RefFloatProperty(PropertyId.PC.MINPATK, () => this.MinPAtk));
			this.Add(new RefFloatProperty(PropertyId.PC.MAXPATK, () => this.MaxPAtk));
			this.Add(new RefFloatProperty(PropertyId.PC.MINMATK, () => this.MinMAtk));
			this.Add(new RefFloatProperty(PropertyId.PC.MAXMATK, () => this.MaxMAtk));
			this.Add(new RefFloatProperty(PropertyId.PC.MINPATK_SUB, () => this.MinPAtk_Sub));
			this.Add(new RefFloatProperty(PropertyId.PC.MAXPATK_SUB, () => this.MaxPAtk_Sub));

			this.Add(new RefFloatProperty(PropertyId.PC.CRTATK, () => this.CritATK));
			this.Add(new RefFloatProperty(PropertyId.PC.CRTHR, () => this.CritRate));
			this.Add(new RefFloatProperty(PropertyId.PC.HR, () => this.Accuracy));
			this.Add(new RefFloatProperty(PropertyId.PC.DR, () => this.Evasion));
			this.Add(new RefFloatProperty(PropertyId.PC.BLK, () => this.Block));
			this.Add(new RefFloatProperty(PropertyId.PC.BLK_BREAK, () => this.BlockPenetration));

			this.Add(new RefFloatProperty(PropertyId.PC.DEF, () => this.Defense));
			this.Add(new RefFloatProperty(PropertyId.PC.MDEF, () => this.MagicDefense));
			this.Add(new RefFloatProperty(PropertyId.PC.CRTDR, () => this.CritResistance));
			this.Add(new RefFloatProperty(PropertyId.PC.SDR, () => this.AoeRatioDefense));

			this.Add(new RefFloatProperty(PropertyId.PC.MSPD, () => this.Character.GetSpeed()));

			this.Add(new RefFloatProperty(PropertyId.PC.MHR, () => this.MagicAmplification));

			// Element Property Attack
			this.Add(new RefFloatProperty(PropertyId.PC.Fire_Atk, () => this.FireAtk));
			this.Add(new RefFloatProperty(PropertyId.PC.Ice_Atk, () => this.IceAtk));
			this.Add(new RefFloatProperty(PropertyId.PC.Lightning_Atk, () => this.LightningAtk));
			this.Add(new RefFloatProperty(PropertyId.PC.Soul_Atk, () => this.SoulAtk));
			this.Add(new RefFloatProperty(PropertyId.PC.Earth_Atk, () => this.EarthAtk));
			this.Add(new RefFloatProperty(PropertyId.PC.Poison_Atk, () => this.PoisonAtk));
			this.Add(new RefFloatProperty(PropertyId.PC.Holy_Atk, () => this.HolyAtk));
			this.Add(new RefFloatProperty(PropertyId.PC.Dark_Atk, () => this.DarkAtk));

			// Size type Attack
			this.Add(new RefFloatProperty(PropertyId.PC.SmallSize_Atk, () => this.SmallSizeAtk));
			this.Add(new RefFloatProperty(PropertyId.PC.MiddleSize_Atk, () => this.MediumSizeAtk));
			this.Add(new RefFloatProperty(PropertyId.PC.LargeSize_Atk, () => this.LargeSizeAtk));

			// Armor type attack
			this.Add(new RefFloatProperty(PropertyId.PC.Cloth_Atk, () => this.ClothAtk));
			this.Add(new RefFloatProperty(PropertyId.PC.Leather_Atk, () => this.LeatherAtk));
			this.Add(new RefFloatProperty(PropertyId.PC.Iron_Atk, () => this.IronAtk));
			this.Add(new RefFloatProperty(PropertyId.PC.Ghost_Atk, () => this.GhostAtk));
			//this.Add(new RefFloatProperty(PropertyId.PC.Chain_Atk, () => 5));	// Not implemented?

			// Race type Attack
			this.Add(new RefFloatProperty(PropertyId.PC.Forester_Atk, () => this.PlantAtk));
			this.Add(new RefFloatProperty(PropertyId.PC.Widling_Atk, () => this.BeastAtk));
			this.Add(new RefFloatProperty(PropertyId.PC.Klaida_Atk, () => this.InsectAtk));
			this.Add(new RefFloatProperty(PropertyId.PC.Paramune_Atk, () => this.MutantAtk));
			this.Add(new RefFloatProperty(PropertyId.PC.Velnias_Atk, () => this.DevilAtk));

			// Armor typ Defense
			this.Add(new RefFloatProperty(PropertyId.PC.DefAries, () => this.PierceDefense));
			this.Add(new RefFloatProperty(PropertyId.PC.DefSlash, () => this.SlashDefense));
			this.Add(new RefFloatProperty(PropertyId.PC.DefStrike, () => this.StrikeDefense));

			// Element Resistance
			this.Add(new RefFloatProperty(PropertyId.PC.ResFire, () => this.FireResistance));
			this.Add(new RefFloatProperty(PropertyId.PC.ResIce, () => this.IceResistance));
			this.Add(new RefFloatProperty(PropertyId.PC.ResLightning, () => this.LightningResistance));
			this.Add(new RefFloatProperty(PropertyId.PC.ResEarth, () => this.EarthResistance));
			this.Add(new RefFloatProperty(PropertyId.PC.ResSoul, () => this.SoulResistance));
			this.Add(new RefFloatProperty(PropertyId.PC.ResPoison, () => this.PoisonResistance));
			this.Add(new RefFloatProperty(PropertyId.PC.ResHoly, () => this.HolyResistance));
			this.Add(new RefFloatProperty(PropertyId.PC.ResDark, () => this.DarkResistance));

			// Attack Factor
			this.Add(new RefFloatProperty(PropertyId.PC.AriesAtkFactor_PC, () => this.PierceAtkFactor));
			this.Add(new RefFloatProperty(PropertyId.PC.SlashAtkFactor_PC, () => this.SlashAtkFactor));
			this.Add(new RefFloatProperty(PropertyId.PC.StrikeAtkFactor_PC, () => this.StrikeAtkFactor));
			this.Add(new RefFloatProperty(PropertyId.PC.MissileAtkFactor_PC, () => this.MissileAtkFactor));
			this.Add(new RefFloatProperty(PropertyId.PC.FireAtkFactor_PC, () => this.FireAtkFactor));
			this.Add(new RefFloatProperty(PropertyId.PC.IceAtkFactor_PC, () => this.IceAtkFactor));
			this.Add(new RefFloatProperty(PropertyId.PC.LightningAtkFactor_PC, () => this.LightningAtkFactor));
			this.Add(new RefFloatProperty(PropertyId.PC.EarthAtkFactor_PC, () => this.EarthAtkFactor));
			this.Add(new RefFloatProperty(PropertyId.PC.SoulAtkFactor_PC, () => this.SoulAtkFactor));
			this.Add(new RefFloatProperty(PropertyId.PC.PoisonAtkFactor_PC, () => this.PoisonAtkFactor));
			this.Add(new RefFloatProperty(PropertyId.PC.HolyAtkFactor_PC, () => this.HolyAtkFactor));
			this.Add(new RefFloatProperty(PropertyId.PC.DarkAtkFactor_PC, () => this.DarkAtkFactor));

			// Defense Factor
			this.Add(new RefFloatProperty(PropertyId.PC.AriesAtkFactor_PC, () => this.PierceAtkFactor));
			this.Add(new RefFloatProperty(PropertyId.PC.SlashAtkFactor_PC, () => this.SlashAtkFactor));
			this.Add(new RefFloatProperty(PropertyId.PC.StrikeAtkFactor_PC, () => this.StrikeAtkFactor));
			this.Add(new RefFloatProperty(PropertyId.PC.MissileAtkFactor_PC, () => this.MissileAtkFactor));
			this.Add(new RefFloatProperty(PropertyId.PC.FireAtkFactor_PC, () => this.FireAtkFactor));
			this.Add(new RefFloatProperty(PropertyId.PC.IceAtkFactor_PC, () => this.IceAtkFactor));
			this.Add(new RefFloatProperty(PropertyId.PC.LightningAtkFactor_PC, () => this.LightningAtkFactor));
			this.Add(new RefFloatProperty(PropertyId.PC.EarthAtkFactor_PC, () => this.EarthAtkFactor));
			this.Add(new RefFloatProperty(PropertyId.PC.SoulAtkFactor_PC, () => this.SoulAtkFactor));
			this.Add(new RefFloatProperty(PropertyId.PC.PoisonAtkFactor_PC, () => this.PoisonAtkFactor));
			this.Add(new RefFloatProperty(PropertyId.PC.HolyAtkFactor_PC, () => this.HolyAtkFactor));
			this.Add(new RefFloatProperty(PropertyId.PC.DarkAtkFactor_PC, () => this.DarkAtkFactor));

			this.Add(new RefFloatProperty(PropertyId.PC.MovingShotable, () => 0f));
			this.Add(new RefFloatProperty(PropertyId.PC.CastingSpeed, () => 100f));
			this.Add(new RefFloatProperty(PropertyId.PC.HPDrain, () => 2f));
			this.Add(new RefFloatProperty(PropertyId.PC.JumpPower, () => this.Character.GetJumpStrength()));
			this.Add(new RefFloatProperty(PropertyId.PC.BOOST, () => 1f));
			this.Add(new RefFloatProperty(PropertyId.PC.Const, () => 1.909859f));
			this.Add(new RefFloatProperty(PropertyId.PC.CAST, () => 1f));
			this.Add(new RefFloatProperty(PropertyId.PC.Sta_Jump, () => 1000f));

			//this.Add(new CalculatedFloatProperty(PropertyId.PC.STR, this.GetSTR));
			//this.Add(new FloatProperty(PropertyId.PC.STR_JOB));
			//this.Add(new FloatProperty(PropertyId.PC.STR_STAT));
			//this.Add(new FloatProperty(PropertyId.PC.STR_Bonus));
			//this.Add(new FloatProperty(PropertyId.PC.STR_ADD));

			//this.AutoUpdate(
			//	PropertyId.PC.STR, new[]
			//	{
			//		PropertyId.PC.STR_JOB,
			//		PropertyId.PC.STR_STAT,
			//		PropertyId.PC.STR_Bonus,
			//		PropertyId.PC.STR_ADD,
			//		//PropertyId.PC.ALLSTAT_STAT,
			//		//PropertyId.PC.ALLSTAT_ADD,
			//		//PropertyId.PC.ALLSTAT_BM,
			//		//PropertyId.PC.ALLSTAT_ITEM_BM,
			//	}
			//);
		}

		//public float GetSTR()
		//{
		//	var defaultStat = 0;
		//	//var defaultStat = SCR_GET_JOB_DEFAULT_STAT(self, statString);

		//	//var byJob = SCR_GET_JOB_STR(self);
		//	//if byJob == nil then
		//	//	byJob = 0;
		//	//end

		//	var byJob = this.GetFloat(PropertyId.PC.STR_JOB);
		//	var byStat = this.GetFloat(PropertyId.PC.STR_STAT);
		//	var byBonus = this.GetFloat(PropertyId.PC.STR_Bonus);
		//	var byAdd = this.GetFloat(PropertyId.PC.STR_ADD);
		//	var byTemp = 0; // this.GetFloat(PropertyId.PC.STR_TEMP);

		//	var rewardProperty = 0; // GET_REWARD_PROPERTY(self, statString);

		//	var result = defaultStat + byJob + byStat + byBonus + byAdd + byTemp + rewardProperty;
		//	return (float)Math.Floor(Math.Max(1, result));
		//}

		/// <summary>
		/// Character's level.
		/// </summary>
		public int Level { get; set; } = 1;

		/// <summary>
		/// Hp multiplicator from the basic job.
		/// </summary>
		public float HpRateByJob { get; set; }

		/// <summary>
		/// Gets or set HP, clamped between 0 and MaxHp.
		/// </summary>
		public int Hp
		{
			get { return _hp; }
			set { _hp = Math2.Clamp(0, this.MaxHp, value); }
		}
		private int _hp;

		/// <summary>
		/// Maximum HP.
		/// </summary>
		public int MaxHp
		{
			get
			{
				var level = this.Level;
				var rateByJob = this.HpRateByJob;
				var stat = this.Con;

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
		}

		/// <summary>
		/// Returns true if the character has run out of HP and died.
		/// </summary>
		public bool IsDead => this.Hp == 0;

		/// <summary>
		/// Sp multiplicator from the basic job.
		/// </summary>
		public float SpRateByJob { get; set; }

		/// <summary>
		/// Gets or sets SP, clamped between 0 and MaxSp.
		/// </summary>
		public int Sp
		{
			get { return _sp; }
			set { _sp = Math2.Clamp(0, this.MaxSp, value); }
		}
		private int _sp;

		/// <summary>
		/// Maximum SP.
		/// </summary>
		public int MaxSp
		{
			get
			{
				var level = this.Level;
				var rateByJob = this.SpRateByJob;
				var stat = this.Spr;

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
		}

		/// <summary>
		/// Default value from the basic Job.
		/// </summary>
		public int StaminaByJob { get; set; }

		/// <summary>
		/// Gets or set Stamina, clamped between 0 and MaxStamina.
		/// </summary>
		public int Stamina
		{
			get { return _stamina; }
			set { _stamina = Math2.Clamp(0, this.MaxStamina, value); }
		}
		private int _stamina;

		/// <summary>
		/// Maximum stamina. TODO: Item and buff bonus.
		/// </summary>
		public int MaxStamina => this.StaminaByJob;

		/// <summary>
		/// Returns maximum weight the character can carry.
		/// </summary>
		/// <remarks>
		/// At release: Base 5000, plus 5 for each Str/Con.
		/// Now: Base 8000 plus bonuses?
		/// </remarks>
		public int MaxWeight => 8000;

		/// <summary>
		/// Returns combined weight of all items the character is currently carrying.
		/// </summary>
		public float NowWeight => this.Character.Inventory.GetNowWeight();

		/// <summary>
		/// Returns ratio between NowWeight and MaxWeight.
		/// </summary>
		public float WeightRatio => (100f / this.MaxWeight * this.NowWeight);

		/// <summary>
		/// Stat points.
		/// </summary>
		public int StatPoints { get { return (this.StatByLevel + this.StatByBonus - this.UsedStat); } }

		/// <summary>
		/// Stat points acquired by leveling.
		/// </summary>
		public int StatByLevel
		{
			get { return _statByLevel; }
			set { _statByLevel = Math2.Clamp(0, short.MaxValue, value); }
		}
		private int _statByLevel;

		/// <summary>
		/// Stat points acquired by other means than leveling.
		/// </summary>
		public int StatByBonus
		{
			get { return _statByBonus; }
			set { _statByBonus = Math2.Clamp(0, short.MaxValue, value); }
		}
		private int _statByBonus;

		/// <summary>
		/// Amount of stat points spent.
		/// </summary>
		/// <remarks>
		/// Clamped between 0 and total amount of character's stat points.
		/// </remarks>
		public int UsedStat
		{
			get { return _usedStat; }
			set { _usedStat = Math2.Clamp(0, this.StatByLevel + this.StatByBonus, value); }
		}
		private int _usedStat;

		/// <summary>
		/// Gets or set the character's ability points.
		/// </summary>
		/// <remarks>
		/// Clamped between 0 and short.Max.
		/// </remarks>
		public int AbilityPoints
		{
			get { return _abilityPoints; }
			set { _abilityPoints = Math2.Clamp(0, short.MaxValue, value); }
		}
		private int _abilityPoints;

		/// <summary>
		/// Gets or sets character's Job strength (STR).
		/// </summary>
		public int StrByJob { get; set; }

		/// <summary>
		/// Gets or sets character's Invested strength (STR).
		/// </summary>
		public int StrInvested { get; set; }

		/// <summary>
		/// Gets or sets character's Item and Buff Bonus strength (STR).
		/// </summary>
		public int StrBonus
		{
			get
			{
				var byItem = 0; // TODO: "STR"

				// Buffs: "STR_BM"
				var byBuffs = 0;

				// "STR_ITEM_BM" Item Awakening/Enchantment ?
				var byItemBuff = 0;

				var value = byItem + byBuffs + byItemBuff;

				return (int)value;
			}
		}

		/// <summary>
		/// Gets character's strength (STR).
		/// </summary>
		public int Str { get { return this.StrByJob + this.StrInvested + this.StrBonus; } }

		/// <summary>
		/// Gets or sets character's Job vitality (CON).
		/// </summary>
		public int ConByJob { get; set; }

		/// <summary>
		/// Gets or sets character's Invested vitality (CON).
		/// </summary>
		public int ConInvested { get; set; }

		/// <summary>
		/// Gets or sets character's Item and Buff Bonus vitality (CON).
		/// </summary>
		public int ConBonus
		{
			get
			{
				var byItem = 0; // TODO: "CON"

				// Buffs: "CON_BM"
				var byBuffs = 0;

				// "CON_ITEM_BM" Item Awakening/Enchantment ?
				var byItemBuff = 0;

				var value = byItem + byBuffs + byItemBuff;

				return (int)value;
			}
		}

		/// <summary>
		/// Gets character's vitality (CON).
		/// </summary>
		public int Con { get { return this.ConByJob + this.ConInvested + this.ConBonus; } }

		/// <summary>
		/// Gets or sets character's Job intelligence (INT).
		/// </summary>
		public int IntByJob { get; set; }

		/// <summary>
		/// Gets or sets character's Invested intelligence (INT).
		/// </summary>
		public int IntInvested { get; set; }

		/// <summary>
		/// Gets or sets character's Item and Buff Bonus intelligence (INT).
		/// </summary>
		public int IntBonus
		{
			get
			{
				var byItem = 0; // TODO: "INT"

				// Buffs: "INT_BM"
				var byBuffs = 0;

				// "INT_ITEM_BM" Item Awakening/Enchantment ?
				var byItemBuff = 0;

				var value = byItem + byBuffs + byItemBuff;

				return (int)value;
			}
		}

		/// <summary>
		/// Gets character's intelligence (INT).
		/// </summary>
		public int Int { get { return this.IntByJob + this.IntInvested + this.IntBonus; } }

		/// <summary>
		/// Gets or sets character's Job spirit (SPR/MNA).
		/// </summary>
		public int SprByJob { get; set; }

		/// <summary>
		/// Gets or sets character's Invested spirit (SPR/MNA).
		/// </summary>
		public int SprInvested { get; set; }

		/// <summary>
		/// Gets or sets character's Item and Buff Bonus spirit (SPR/MNA).
		/// </summary>
		public int SprBonus
		{
			get
			{
				var byItem = 0; // TODO: "SPR"

				// Buffs: "SPR_BM"
				var byBuffs = 0;

				// "SPR_ITEM_BM" Item Awakening/Enchantment ?
				var byItemBuff = 0;

				var value = byItem + byBuffs + byItemBuff;

				return (int)value;
			}
		}

		/// <summary>
		/// Gets character's spirit (SPR/MNA).
		/// </summary>
		public int Spr { get { return this.SprByJob + this.SprInvested + this.SprBonus; } }

		/// <summary>
		/// Gets or sets character's Job agility (DEX).
		/// </summary>
		public int DexByJob { get; set; }

		/// <summary>
		/// Gets or sets character's Invested agility (DEX).
		/// </summary>
		public int DexInvested { get; set; }

		/// <summary>
		/// Gets or sets character's Item and Buff Bonus agility (DEX).
		/// </summary>
		public int DexBonus
		{
			get
			{
				var byItem = 0; // TODO: "DEX"

				// Buffs: "DEX_BM"
				var byBuffs = 0;

				// "DEX_ITEM_BM" Item Awakening/Enchantment ?
				var byItemBuff = 0;

				var value = byItem + byBuffs + byItemBuff;

				return (int)value;
			}
		}

		/// <summary>
		/// Gets character's agility (DEX).
		/// </summary>
		public int Dex { get { return this.DexByJob + this.DexInvested + this.DexBonus; } }

		/// <summary>
		/// Returns minimum physical ATK.
		/// </summary>
		public int MinPAtk
		{
			get
			{
				var baseValue = 20;
				var level = this.Level;
				var stat = this.Str;

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

				var maxPatk = this.MaxPAtk;
				if (value > maxPatk)
					return maxPatk;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns maximum physical ATK.
		/// </summary>
		public int MaxPAtk
		{
			get
			{
				var baseValue = 20;
				var level = this.Level;
				var stat = this.Str;

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
		}

		/// <summary>
		/// Returns minimum physical ATK.
		/// </summary>
		public int MinPAtk_Sub
		{
			get
			{
				var baseValue = 20;
				var level = this.Level;
				var stat = this.Str;

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

				var maxPatk_sub = this.MaxPAtk_Sub;
				if (value > maxPatk_sub)
					return maxPatk_sub;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns maximum physical ATK.
		/// </summary>
		public int MaxPAtk_Sub
		{
			get
			{
				var baseValue = 20;
				var level = this.Level;
				var stat = this.Str;

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
		}

		/// <summary>
		/// Returns minimum magic ATK.
		/// </summary>
		public int MinMAtk
		{
			get
			{
				var baseValue = 20;
				var level = this.Level;
				var stat = this.Int;

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

				var max = this.MaxMAtk;
				if (value > max)
					return max;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns maximum magic ATK.
		/// </summary>
		public int MaxMAtk
		{
			get
			{
				var baseValue = 20;
				var level = this.Level;
				var stat = this.Int;

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
		}

		/// <summary>
		/// Returns Physical Defense.
		/// </summary>
		public int Defense
		{
			get
			{
				var baseValue = 20;
				var level = this.Level;

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
		}

		/// <summary>
		/// Returns Magic Defense.
		/// </summary>
		public int MagicDefense
		{
			get
			{
				var baseValue = 20;
				var level = this.Level;

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
		}

		/// <summary>
		/// Returns Critical Attack.
		/// </summary>
		public int CritATK
		{
			get
			{
				var stat = this.Dex;

				var byStat = (stat * 4f) + ((float)Math.Floor(stat / 10f) * 10f);
				var byItem = 0; // TODO: Cached Crit ATK for inventory/equip

				var value = byStat + byItem;

				// Buffs: "CRTATK_BM"
				var byBuffs = 0;

				// Rate buffs: Does Tos have something like CritATK +x%?
				var rate = 0;
				var byRateBuffs = (float)Math.Floor(value * rate);

				value += byBuffs + byRateBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns Critical Rate.
		/// </summary>
		public int CritRate
		{
			get
			{
				var Level = this.Level;

				var byLevel = Level / 2f;
				var byItem = 0; // TODO: CRTHR

				var value = byLevel + byItem;

				// Buffs: "CRTHR_BM"
				var byBuffs = 0;

				// Rate buffs:
				var rate = 0;
				var byRateBuffs = (float)Math.Floor(value * rate);

				value += byBuffs + byRateBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns Critical Resistance.
		/// </summary>
		public int CritResistance
		{
			get
			{
				var Level = this.Level;

				var byLevel = Level / 2f;
				var byItem = 0; // TODO: CRTDR

				var value = byLevel + byItem;

				// Buffs: "CRTDR_BM"
				var byBuffs = 0;

				// Rate buffs:
				var rate = 0;
				var byRateBuffs = (float)Math.Floor(value * rate);

				value += byBuffs + byRateBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns Accuracy.
		/// </summary>
		public int Accuracy
		{
			get
			{
				var Level = this.Level;
				var stat = this.Str;

				var byLevel = Level / 4f;
				var byStat = (stat / 2f) + ((float)Math.Floor(stat / 15f) * 3f);
				var byItem = 0; // TODO: "HR" "ADD_HR"

				var value = byLevel + byStat + byItem;

				// Buffs: "HR_BM"
				var byBuffs = 0;

				// Rate buffs: ADD_HR
				var rate = 0;
				var byRateBuffs = (float)Math.Floor(value * rate);

				value += byBuffs + byRateBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns Evasion.
		/// </summary>
		public int Evasion
		{
			get
			{
				var Level = this.Level;
				var stat = this.Dex;

				var byLevel = Level / 4f;
				var byStat = (stat / 2f) + ((float)Math.Floor(stat / 15f) * 3f);
				var byItem = 0; // TODO: "DR" "ADD_DR"

				var value = byLevel + byStat + byItem;

				// Buffs: "DR_BM"
				var byBuffs = 0;

				// Rate buffs: "ADD_DR"
				var rate = 0;
				var byRateBuffs = (float)Math.Floor(value * rate);

				value += byBuffs + byRateBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns Block.
		/// </summary>
		public int Block
		{
			get
			{
				// TODO: Update it after equipment change.
				// Shield/Dagger = Right hand.
				if (this.Character.Inventory.GetItem(EquipSlot.LeftHand).Data.EquipType1 != EquipType.Shield)
					return 0;

				var Level = this.Level;
				var stat = this.Con;

				var byLevel = Level / 4f;
				var byStat = (stat / 2f) + ((float)Math.Floor(stat / 15f) * 3f);
				var byItem = 0f; // TODO: "BLK" "BlockRate"

				var value = byLevel + byStat + byItem;

				// Buffs: "BLK_BM"
				var byBuffs = 0;

				// Rate buffs: BlockRate
				var rate = 0;
				var byRateBuffs = (float)Math.Floor(value * rate);

				value += byBuffs + byRateBuffs;

				return (int)value;

			}
		}

		/// <summary>
		/// Returns Block Penetration.
		/// </summary>
		public int BlockPenetration
		{
			get
			{
				var Level = this.Level;
				var stat = this.Dex;

				var byLevel = Level / 4f;
				var byStat = (stat / 2f) + ((float)Math.Floor(stat / 15f) * 3f);
				var byItem = 0; // TODO: "BLK_BREAK"

				var value = byLevel + byStat + byItem;

				// Buffs: "BLK_BREAK_BM"
				var byBuffs = 0;

				// Rate buffs: 
				var rate = 0;
				var byRateBuffs = (float)Math.Floor(value * rate);

				value += byBuffs + byRateBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// The character's splash rate?
		/// </summary>
		/// <remarks>
		/// Used together with skill's splash rates.
		/// TODO: Figure out where it comes from (official name: SR).
		/// TODO: Check if it changes with jobs, items, stances, etc.
		/// </remarks>
		public float SplashRate { get; } = 4;

		/// <summary>
		/// Returns Aoe Attack Ratio.
		/// </summary>
		public int AoeRatio
		{
			get
			{
				var baseValue = 3;
				if (this.Character.Jobs.Has(JobId.Swordsman, Circle.First))
				{
					baseValue = 4;
				}
				if (this.Character.Jobs.Has(JobId.Archer, Circle.First))
				{
					baseValue = 0;
				}
				var byItem = 0f; // TODO: "SR"

				var value = baseValue + byItem;

				// Buffs: "SR_BM"
				var byBuffs = 0;

				value += byBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns Aoe Defence Ratio.
		/// </summary>
		public int AoeRatioDefense
		{
			get
			{
				var baseValue = 1;
				var byItem = 0f; // TODO: "SDR"

				var value = baseValue + byItem;

				// Buffs: "SDR_BM"
				var byBuffs = 0;

				value += byBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns HP Recovery amount.
		/// </summary>
		public int HPRecovery
		{
			get
			{
				var level = this.Level;
				var stat = this.Con;
				var rateByJob = this.HpRateByJob;

				var byLevel = level * rateByJob;
				var byStat = (stat * 2f) + ((float)Math.Floor(stat / 5f) * 3f);
				var byItem = 0f; // TODO: "RHP"

				var value = byLevel + byStat + byItem;

				// Buffs: "RHP_BM"
				var byBuffs = 0;

				// Rate buffs: 
				var rate = 0;
				var byRateBuffs = (float)Math.Floor(value * rate);

				value += byBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns HP Recovery time.
		/// </summary>
		public float HPRecoveryTime
		{
			get
			{
				var baseValue = 20000;

				var byItem = 0f; // TODO: "RHPTIME"

				// Buffs: "RHPTIME_BM"
				var byBuffs = 0;

				var value = baseValue - byItem - byBuffs;

				if (this.Character.IsSitting)
					value *= 0.5f;

				if (value < 1000)
					value = 1000;

				return (float)Math.Floor(value);
			}
		}

		/// <summary>
		/// Returns SP Recovery amount.
		/// </summary>
		public int SPRecovery
		{
			get
			{
				var level = this.Level;
				var stat = this.Spr;
				var rateByJob = this.SpRateByJob;

				var byLevel = level * rateByJob;
				var byStat = (stat * 2f) + ((float)Math.Floor(stat / 5f) * 3f);
				var byItem = 0f; // TODO: "RSP"

				var value = byLevel + byStat + byItem;

				// Buffs: "RSP_BM"
				var byBuffs = 0;

				// Rate buffs: 
				var rate = 0;
				var byRateBuffs = (float)Math.Floor(value * rate);

				value += byBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns SP Recovery time.
		/// </summary>
		public float SPRecoveryTime
		{
			get
			{
				var baseValue = 20000;

				var byItem = 0f; // TODO: "RSPTIME"

				// Buffs: "RSPTIME_BM"
				var byBuffs = 0;

				var value = baseValue - byItem - byBuffs;

				if (this.Character.IsSitting)
					value *= 0.5f;

				if (value < 1000)
					value = 1000;

				return (float)Math.Floor(value);
			}
		}

		/// <summary>
		/// Returns Magic Amplification.
		/// </summary>
		public int MagicAmplification
		{
			get
			{
				// TODO: Add this to MATK
				var byItem = 0; // TODO: "MHR" "ADD_MHR"

				var value = byItem;

				// Buffs: "MHR_BM"
				var byBuffs = 0;

				value += byBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns Fire Property Attack.
		/// </summary>
		public int FireAtk
		{
			get
			{
				var byItem = 0f; // TODO: "ADD_FIRE"
				var value = byItem;

				// Buffs: "Fire_Atk_BM"
				var byBuffs = 0;

				value += byBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns Ice Property Attack.
		/// </summary>
		public int IceAtk
		{
			get
			{
				var byItem = 0f; // TODO: "ADD_ICE"
				var value = byItem;

				// Buffs: "Ice_Atk_BM"
				var byBuffs = 0;

				value += byBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns Lightning Property Attack.
		/// </summary>
		public int LightningAtk
		{
			get
			{
				var byItem = 0f; // TODO: "ADD_LIGHTNING"
				var value = byItem;

				// Buffs: "Lightning_Atk_BM"
				var byBuffs = 0;

				value += byBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns Psychokinesis Property Attack.
		/// </summary>
		public int SoulAtk
		{
			get
			{
				var byItem = 0f; // TODO: "ADD_SOUL"
				var value = byItem;

				// Buffs: "Soul_Atk_BM"
				var byBuffs = 0;

				value += byBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns Earth Property Attack.
		/// </summary>
		public int EarthAtk
		{
			get
			{
				var byItem = 0f; // TODO: "Earth_Atk"
				var value = byItem;

				// Buffs: "Earth_Atk_BM"
				var byBuffs = 0;

				value += byBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns Poison Property Attack.
		/// </summary>
		public int PoisonAtk
		{
			get
			{
				var byItem = 0f; // TODO: "ADD_POISON"
				var value = byItem;

				// Buffs: "Poison_Atk_BM"
				var byBuffs = 0;

				value += byBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns Holy Property Attack.
		/// </summary>
		public int HolyAtk
		{
			get
			{
				var byItem = 0f; // TODO: "ADD_HOLY"
				var value = byItem;

				// Buffs: "Holy_Atk_BM"
				var byBuffs = 0;

				value += byBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns Dark Property Attack.
		/// </summary>
		public int DarkAtk
		{
			get
			{
				var byItem = 0f; // TODO: "ADD_DARK"
				var value = byItem;

				// Buffs: "Dark_Atk_BM"
				var byBuffs = 0;

				value += byBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns Small size Attack.
		/// </summary>
		public int SmallSizeAtk
		{
			get
			{
				var byItem = 0f; // TODO: "ADD_SMALLSIZE"
				var value = byItem;

				// Buffs: "SmallSize_Atk_BM"
				var byBuffs = 0;

				value += byBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns Medium size Attack.
		/// </summary>
		public int MediumSizeAtk
		{
			get
			{
				var byItem = 0f; // TODO: "ADD_MIDDLESIZE"
				var value = byItem;

				// Buffs: "MiddleSize_Atk_BM"
				var byBuffs = 0;

				value += byBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns Large size Attack.
		/// </summary>
		public int LargeSizeAtk
		{
			get
			{
				var byItem = 0f; // TODO: "ADD_LARGESIZE"
				var value = byItem;

				// Buffs: "LargeSize_Atk_BM"
				var byBuffs = 0;

				value += byBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns Cloth type Attack.
		/// </summary>
		public int ClothAtk
		{
			get
			{
				var byItem = 0f; // TODO: "ADD_CLOTH"
				var value = byItem;

				// Buffs: "Cloth_Atk_BM"
				var byBuffs = 0;

				value += byBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns Leather type Attack.
		/// </summary>
		public int LeatherAtk
		{
			get
			{
				var byItem = 0f; // TODO: "ADD_LEATHER"
				var value = byItem;

				// Buffs: "Leather_Atk_BM"
				var byBuffs = 0;

				value += byBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns Plate type Attack.
		/// </summary>
		public int IronAtk
		{
			get
			{
				var byItem = 0f; // TODO: "ADD_IRON"
				var value = byItem;

				// Buffs: "Iron_Atk_BM"
				var byBuffs = 0;

				value += byBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns Ghost type Attack.
		/// </summary>
		public int GhostAtk
		{
			get
			{
				var byItem = 0f; // TODO: "ADD_GHOST"
				var value = byItem;

				// Buffs: "Ghost_Atk_BM"
				var byBuffs = 0;

				value += byBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns Plant type Attack.
		/// </summary>
		public int PlantAtk
		{
			get
			{
				var byItem = 0f; // TODO: "ADD_FORESTER"
				var value = byItem;

				// Buffs: "Forester_Atk_BM"
				var byBuffs = 0;

				value += byBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns Beast type Attack.
		/// </summary>
		public int BeastAtk
		{
			get
			{
				var byItem = 0f; // TODO: "ADD_WIDLING"
				var value = byItem;

				// Buffs: "Widling_Atk_BM"
				var byBuffs = 0;

				value += byBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns Insect type Attack.
		/// </summary>
		public int InsectAtk
		{
			get
			{
				var byItem = 0f; // TODO: "ADD_KLAIDA"
				var value = byItem;

				// Buffs: "Klaida_Atk_BM"
				var byBuffs = 0;

				value += byBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns Mutant type Attack.
		/// </summary>
		public int MutantAtk
		{
			get
			{
				var byItem = 0f; // TODO: "ADD_PARAMUNE"
				var value = byItem;

				// Buffs: "Paramune_Atk_BM"
				var byBuffs = 0;

				value += byBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns Devil type Attack.
		/// </summary>
		public int DevilAtk
		{
			get
			{
				var byItem = 0f; // TODO: "ADD_VELIAS"
				var value = byItem;

				// Buffs: "Velnias_Atk_BM"
				var byBuffs = 0;

				value += byBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns Pierce type Defense.
		/// </summary>
		public int PierceDefense
		{
			get
			{
				var byItem = 0f; // TODO: "AriesDEF"
				var value = byItem;

				// Buffs: "DefAries_BM"
				var byBuffs = 0;

				value += byBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns Slash type Defense.
		/// </summary>
		public int SlashDefense
		{
			get
			{
				var byItem = 0f; // TODO: "SlashDEF"
				var value = byItem;

				// Buffs: "DefSlash_BM"
				var byBuffs = 0;

				value += byBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns Strike type Defense.
		/// </summary>
		public int StrikeDefense
		{
			get
			{
				var byItem = 0f; // TODO: "StrikeDEF"
				var value = byItem;

				// Buffs: "DefStrike_BM"
				var byBuffs = 0;

				value += byBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns Fire Resistance.
		/// </summary>
		public int FireResistance
		{
			get
			{
				var byItem = 0f; // TODO: "RES_FIRE"
				var value = byItem;

				// Buffs: "ResFire_BM"
				var byBuffs = 0;

				value += byBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns Ice Resistance.
		/// </summary>
		public int IceResistance
		{
			get
			{
				var byItem = 0f; // TODO: "RES_ICE"
				var value = byItem;

				// Buffs: "ResIce_BM"
				var byBuffs = 0;

				value += byBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns Lightning Resistance.
		/// </summary>
		public int LightningResistance
		{
			get
			{
				var byItem = 0f; // TODO: "RES_LIGHTNING"
				var value = byItem;

				// Buffs: "ResLightning_BM"
				var byBuffs = 0;

				value += byBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns Psychokinesis Resistance.
		/// </summary>
		public int SoulResistance
		{
			get
			{
				var byItem = 0f; // TODO: "RES_SOUL"
				var value = byItem;

				// Buffs: "ResSoul_BM"
				var byBuffs = 0;

				value += byBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns Earth Resistance.
		/// </summary>
		public int EarthResistance
		{
			get
			{
				var byItem = 0f; // TODO: "RES_EARTH"
				var value = byItem;

				// Buffs: "ResEarth_BM"
				var byBuffs = 0;

				value += byBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns Poison Resistance.
		/// </summary>
		public int PoisonResistance
		{
			get
			{
				var byItem = 0f; // TODO: "RES_POISON"
				var value = byItem;

				// Buffs: "ResPoison_BM"
				var byBuffs = 0;

				value += byBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns Holy Resistance.
		/// </summary>
		public int HolyResistance
		{
			get
			{
				var byItem = 0f; // TODO: "RES_HOLY"
				var value = byItem;

				// Buffs: "ResHoly_BM"
				var byBuffs = 0;

				value += byBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns Dark Resistance.
		/// </summary>
		public int DarkResistance
		{
			get
			{
				var byItem = 0f; // TODO: "RES_DARK"
				var value = byItem;

				// Buffs: "ResDark_BM"
				var byBuffs = 0;

				value += byBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns Pierce Attack Factor.
		/// </summary>
		public int PierceAtkFactor
		{
			get
			{
				// Buffs: "AriesAtkFactor_PC_BM"
				var byBuffs = 0;

				return (int)byBuffs;
			}
		}

		/// <summary>
		/// Returns Slash Attack Factor.
		/// </summary>
		public int SlashAtkFactor
		{
			get
			{
				// Buffs: "SlashAtkFactor_PC_BM"
				var byBuffs = 0;

				return (int)byBuffs;
			}
		}

		/// <summary>
		/// Returns Strike Attack Factor.
		/// </summary>
		public int StrikeAtkFactor
		{
			get
			{
				// Buffs: "StrikeAtkFactor_PC_BM"
				var byBuffs = 0;

				return (int)byBuffs;
			}
		}

		/// <summary>
		/// Returns Missile Attack Factor.
		/// </summary>
		public int MissileAtkFactor
		{
			get
			{
				// Buffs: "MissileAtkFactor_PC_BM"
				var byBuffs = 0;

				return (int)byBuffs;
			}
		}

		/// <summary>
		/// Returns Fire Property Attack Factor.
		/// </summary>
		public int FireAtkFactor
		{
			get
			{
				// Buffs: "FireAtkFactor_PC_BM"
				var byBuffs = 0;

				return (int)byBuffs;
			}
		}

		/// <summary>
		/// Returns Ice Property Attack Factor.
		/// </summary>
		public int IceAtkFactor
		{
			get
			{
				// Buffs: "IceAtkFactor_PC_BM"
				var byBuffs = 0;

				return (int)byBuffs;
			}
		}

		/// <summary>
		/// Returns Lightning Property Attack Factor.
		/// </summary>
		public int LightningAtkFactor
		{
			get
			{
				// Buffs: "LightningAtkFactor_PC_BM"
				var byBuffs = 0;

				return (int)byBuffs;
			}
		}

		/// <summary>
		/// Returns Psychokinesis Property Attack Factor.
		/// </summary>
		public int SoulAtkFactor
		{
			get
			{
				// Buffs: "SoulAtkFactor_PC_BM"
				var byBuffs = 0;

				return (int)byBuffs;
			}
		}

		/// <summary>
		/// Returns Poison Property Attack Factor.
		/// </summary>
		public int PoisonAtkFactor
		{
			get
			{
				// Buffs: "PoisonAtkFactor_PC_BM"
				var byBuffs = 0;

				return (int)byBuffs;
			}
		}

		/// <summary>
		/// Returns Earth Property Attack Factor.
		/// </summary>
		public int EarthAtkFactor
		{
			get
			{
				// Buffs: "EarthAtkFactor_PC_BM"
				var byBuffs = 0;

				return (int)byBuffs;
			}
		}

		/// <summary>
		/// Returns Holy Property Attack Factor.
		/// </summary>
		public int HolyAtkFactor
		{
			get
			{
				// Buffs: "HolyAtkFactor_PC_BM"
				var byBuffs = 0;

				return (int)byBuffs;
			}
		}

		/// <summary>
		/// Returns Dark Property Attack Factor.
		/// </summary>
		public int DarkAtkFactor
		{
			get
			{
				// Buffs: "DarkAtkFactor_PC_BM"
				var byBuffs = 0;

				return (int)byBuffs;
			}
		}

		/// <summary>
		/// Returns Pierce Property Defense Factor.
		/// </summary>
		public int PierceDefenseFactor
		{
			get
			{
				// Buffs: "AriesDefFactor_PC_BM"
				var byBuffs = 0;

				return (int)byBuffs;
			}
		}

		/// <summary>
		/// Returns Slash Property Defense Factor.
		/// </summary>
		public int SlashDefenseFactor
		{
			get
			{
				// Buffs: "SlashDefFactor_PC_BM"
				var byBuffs = 0;

				return (int)byBuffs;
			}
		}

		/// <summary>
		/// Returns Strike Property Defense Factor.
		/// </summary>
		public int StrikeDefenseFactor
		{
			get
			{
				// Buffs: "StrikeDefFactor_PC_BM"
				var byBuffs = 0;

				return (int)byBuffs;
			}
		}

		/// <summary>
		/// Returns Missile Property Defense Factor.
		/// </summary>
		public int MissileDefenseFactor
		{
			get
			{
				// Buffs: "MissileDefFactor_PC_BM"
				var byBuffs = 0;

				return (int)byBuffs;
			}
		}

		/// <summary>
		/// Returns Fire Property Defense Factor.
		/// </summary>
		public int FireDefenseFactor
		{
			get
			{
				// Buffs: "FireDefFactor_PC_BM"
				var byBuffs = 0;

				return (int)byBuffs;
			}
		}

		/// <summary>
		/// Returns Ice Property Defense Factor.
		/// </summary>
		public int IceDefenseFactor
		{
			get
			{
				// Buffs: "IceDefFactor_PC_BM"
				var byBuffs = 0;

				return (int)byBuffs;
			}
		}

		/// <summary>
		/// Returns Lightning Property Defense Factor.
		/// </summary>
		public int LightningDefenseFactor
		{
			get
			{
				// Buffs: "LightningDefFactor_PC_BM"
				var byBuffs = 0;

				return (int)byBuffs;
			}
		}

		/// <summary>
		/// Returns Psychokinesis Property Defense Factor.
		/// </summary>
		public int SoulDefenseFactor
		{
			get
			{
				// Buffs: "SoulDefFactor_PC_BM"
				var byBuffs = 0;

				return (int)byBuffs;
			}
		}

		/// <summary>
		/// Returns Poison Property Defense Factor.
		/// </summary>
		public int PoisonDefenseFactor
		{
			get
			{
				// Buffs: "PoisonDefFactor_PC_BM"
				var byBuffs = 0;

				return (int)byBuffs;
			}
		}

		/// <summary>
		/// Returns Earth Property Defense Factor.
		/// </summary>
		public int EarthDefenseFactor
		{
			get
			{
				// Buffs: "EarthDefFactor_PC_BM"
				var byBuffs = 0;

				return (int)byBuffs;
			}
		}

		/// <summary>
		/// Returns Holy Property Defense Factor.
		/// </summary>
		public int HolyDefenseFactor
		{
			get
			{
				// Buffs: "HolyDefFactor_PC_BM"
				var byBuffs = 0;

				return (int)byBuffs;
			}
		}

		/// <summary>
		/// Returns Dark Property Defense Factor.
		/// </summary>
		public int DarkDefenseFactor
		{
			get
			{
				// Buffs: "DarkDefFactor_PC_BM"
				var byBuffs = 0;

				return (int)byBuffs;
			}
		}
	}
}
