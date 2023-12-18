using System.Collections.Generic;
using Yggdrasil.Configuration;

namespace Melia.Shared.Configuration.Files
{
	/// <summary>
	/// Represents world.conf
	/// </summary>
	public class WorldConfFile : ConfFile
	{
		// drops.conf
		public float SilverDropAmount { get; protected set; }
		public float SilverDropRate { get; protected set; }
		public float EquipmentDropRate { get; protected set; }
		public float BlueOrbDropRate { get; protected set; }
		public float RedOrbDropRate { get; protected set; }
		public float GemDropRate { get; protected set; }
		public float GeneralDropRate { get; protected set; }
		public int DropRadius { get; protected set; }
		public int PickUpRadius { get; protected set; }
		public int LootPrectionSeconds { get; protected set; }
		public int DropDisappearSeconds { get; protected set; }
		public bool Littering { get; protected set; }
		public bool TargetedLittering { get; protected set; }

		// exp.conf
		public float ExpRate { get; protected set; }
		public float ClassExpRate { get; protected set; }

		// game_time.conf
		public int TicksPerMinute { get; protected set; }
		public int MinutesPerHour { get; protected set; }
		public int HoursPerDay { get; protected set; }
		public int DaysPerMonth { get; protected set; }
		public int MonthsPerYear { get; protected set; }
		public bool EnableDayNightCycle { get; protected set; }

		// skills.conf
		public bool DisableSDR { get; protected set; }
		public int AbilityPointCost { get; protected set; }

		// summons.conf
		public bool BlueOrbFollowWarp { get; protected set; }
		public bool BlueOrbPetSystem { get; protected set; }

		// rare_monsters.conf
		public float BlueJackpotSpawnChance { get; protected set; }
		public float BlueJackpotExpRate { get; protected set; }
		public float SilverJackpotSpawnChance { get; protected set; }
		public int SilverJackpotRolls { get; protected set; }
		public float GoldJackpotSpawnChance { get; protected set; }
		public int GoldJackpotRolls { get; protected set; }
		public float EliteSpawnChance { get; protected set; }
		public float EliteHPSPRate { get; protected set; }
		public float EliteStatRate { get; protected set; }
		public float EliteExpRate { get; protected set; }
		public int EliteRolls { get; protected set; }
		public int EliteMinLevel { get; protected set; }
		public bool EliteAlwaysAggressive { get; protected set; }
		public float RedOrbJackpotRate { get; protected set; }
		public float RedOrbEliteRate { get; protected set; }

		/// <summary>
		/// Loads conf file and its options from the given path.
		/// </summary>
		/// <param name="filePath"></param>
		public void Load(string filePath)
		{
			this.Include(filePath);

			this.SilverDropAmount = this.GetFloat("silver_drop_amount", 100);
			this.SilverDropRate = this.GetFloat("silver_drop_rate", 100);
			this.EquipmentDropRate = this.GetFloat("equipment_drop_rate", 100);
			this.BlueOrbDropRate = this.GetFloat("blue_orb_drop_rate", 100);
			this.RedOrbDropRate = this.GetFloat("red_orb_drop_rate", 100);
			this.GemDropRate = this.GetFloat("gem_drop_rate", 100);
			this.GeneralDropRate = this.GetFloat("general_drop_rate", 100);
			this.DropRadius = this.GetInt("drop_radius", 25);
			this.PickUpRadius = this.GetInt("pick_up_radius", 100);
			this.LootPrectionSeconds = this.GetInt("loot_protection", 100);
			this.DropDisappearSeconds = this.GetInt("drop_disappear_time", 100);
			this.Littering = this.GetBool("littering", false);
			this.TargetedLittering = this.GetBool("targeted_littering", false);

			this.ExpRate = this.GetFloat("exp_rate", 100);
			this.ClassExpRate = this.GetFloat("class_exp_rate", 100);

			this.TicksPerMinute = this.GetInt("rt2gt_ms_per_minute", 1500) * 10000;
			this.MinutesPerHour = this.GetInt("gt_minutes_per_hour", 60);
			this.HoursPerDay = this.GetInt("gt_hours_per_day", 24);
			this.DaysPerMonth = this.GetInt("gt_days_per_month", 40);
			this.MonthsPerYear = this.GetInt("gt_months_per_year", 7);
			this.EnableDayNightCycle = this.GetBool("enable_day_night_cycle", true);

			this.DisableSDR = this.GetBool("disable_sdr", false);
			this.AbilityPointCost = this.GetInt("ability_point_cost", 1000);

			this.BlueOrbFollowWarp = this.GetBool("blue_orb_follow_warp", false);
			this.BlueOrbPetSystem = this.GetBool("blue_orb_pet_system", false);

			this.BlueJackpotSpawnChance = this.GetFloat("blue_jackpot_spawn_chance", 0.05f);
			this.BlueJackpotExpRate = this.GetFloat("blue_jackpot_exp_rate", 10000);
			this.SilverJackpotSpawnChance = this.GetFloat("silver_jackpot_spawn_chance", 0.05f);
			this.SilverJackpotRolls = this.GetInt("silver_jackpot_rolls", 100);
			this.GoldJackpotSpawnChance = this.GetFloat("gold_jackpot_spawn_chance", 0.01f);
			this.GoldJackpotRolls = this.GetInt("gold_jackpot_rolls", 1000);
			this.EliteSpawnChance = this.GetFloat("elite_spawn_chance", 2);
			this.EliteHPSPRate = this.GetFloat("elite_hpsp_rate", 150);
			this.EliteStatRate = this.GetFloat("elite_stat_rate", 150);
			this.EliteExpRate = this.GetFloat("elite_exp_rate", 2);
			this.EliteRolls = this.GetInt("elite_rolls", 2);
			this.EliteMinLevel = this.GetInt("elite_min_level", 100);
			this.EliteAlwaysAggressive = this.GetBool("elite_always_aggressive", true);
			this.RedOrbJackpotRate = this.GetFloat("red_orb_jackpot_rate", 10000);
			this.RedOrbEliteRate = this.GetFloat("red_orb_elite_rate", 1000);
		}

		public Dictionary<string, string> GetOptions()
		{
			return _options;
		}
	}
}
