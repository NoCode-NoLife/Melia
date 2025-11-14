using System;
using Yggdrasil.Configuration;

namespace Melia.Shared.Configuration.Files
{
	/// <summary>
	/// Represents world.conf
	/// </summary>
	public class WorldConfFile : ConfFile
	{
		// ai.conf
		public bool MonstersUsePathfinding { get; protected set; }

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
		public float JobExpRate { get; protected set; }

		// game_time.conf
		public int TicksPerMinute { get; protected set; }
		public int MinutesPerHour { get; protected set; }
		public int HoursPerDay { get; protected set; }
		public int DaysPerMonth { get; protected set; }
		public int MonthsPerYear { get; protected set; }
		public bool EnableDayNightCycle { get; protected set; }

		// items.conf
		public float ItemCooldownRate { get; protected set; }

		// jobs.conf
		public int JobMaxRank { get; protected set; }
		public bool NoAdvancement { get; protected set; }

		// misc.conf
		public bool ResurrectCityOption { get; protected set; }

		// quests.conf
		public bool DisplayQuestObjectives { get; protected set; }

		// skills.conf
		public bool DisableSDR { get; protected set; }
		public int AbilityPointCost { get; protected set; }
		public float NormalAttackSkillFactorRate { get; protected set; }
		public float PlayerSkillFactorRate { get; protected set; }
		public float MonsterSkillFactorRate { get; protected set; }
		public float MonsterSkillSpeedRate { get; protected set; }
		public float MonsterSkillDelayRate { get; protected set; }
		public bool FreezeAffectsElement { get; protected set; }

		// storage.conf
		public int StorageFee { get; protected set; }
		public int StorageExtCost { get; protected set; }
		public int StorageDefaultSize { get; protected set; }
		public int StorageMaxSize { get; protected set; }
		public int StorageMaxExtensions { get; protected set; }
		public bool StorageMultiStack { get; protected set; }
		public int TeamStorageFee { get; protected set; }
		public int TeamStorageDefaultSize { get; protected set; }
		public int TeamStorageExtCost { get; protected set; }
		public int TeamStorageMaxSize { get; protected set; }
		public int TeamStorageMinimumLevelRequired { get; protected set; }

		// summons.conf
		public bool BlueOrbFollowWarp { get; protected set; }
		public bool BlueOrbPetSystem { get; protected set; }

		// rare_monsters.conf
		public float BlueJackpotSpawnChance { get; protected set; }
		public float BlueJackpotExpRate { get; protected set; }
		public float SilverJackpotSpawnChance { get; protected set; }
		public int SilverJackpotRolls { get; protected set; }
		public float SilverJackpotGuaranteedItemThreshold { get; protected set; }
		public float GoldJackpotSpawnChance { get; protected set; }
		public int GoldJackpotRolls { get; protected set; }
		public float GoldJackpotGuaranteedItemThreshold { get; protected set; }
		public float EliteSpawnChance { get; protected set; }
		public float EliteHPSPRate { get; protected set; }
		public float EliteStatRate { get; protected set; }
		public float EliteExpRate { get; protected set; }
		public int EliteRolls { get; protected set; }
		public float EliteGuaranteedItemThreshold { get; protected set; }
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

			this.MonstersUsePathfinding = this.GetBool("monsters_use_pathfinding", true);

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

			this.StorageFee = this.GetInt("storage_fee", 20);
			this.StorageExtCost = this.GetInt("storage_ext_cost", 20);
			this.StorageDefaultSize = this.GetInt("storage_default_size", 60);
			this.StorageMaxSize = this.GetInt("storage_max_size", 110);
			this.StorageMultiStack = this.GetBool("storage_multi_stack", true);

			this.TeamStorageFee = this.GetInt("team_storage_fee", 0);
			this.TeamStorageDefaultSize = this.GetInt("team_storage_default_size", 5);
			this.TeamStorageExtCost = this.GetInt("team_storage_ext_cost", 200000);
			this.TeamStorageMaxSize = this.GetInt("team_storage_max_size", 70);
			this.TeamStorageMinimumLevelRequired = this.GetInt("team_storage_min_level_req", 15);

			this.ExpRate = this.GetFloat("exp_rate", 100);
			this.JobExpRate = this.GetFloat("job_exp_rate", 100);

			this.TicksPerMinute = this.GetInt("rt2gt_ms_per_minute", 1500) * 10000;
			this.MinutesPerHour = this.GetInt("gt_minutes_per_hour", 60);
			this.HoursPerDay = this.GetInt("gt_hours_per_day", 24);
			this.DaysPerMonth = this.GetInt("gt_days_per_month", 40);
			this.MonthsPerYear = this.GetInt("gt_months_per_year", 7);
			this.EnableDayNightCycle = this.GetBool("enable_day_night_cycle", true);

			this.ItemCooldownRate = this.GetFloat("item_cooldown_rate", 1);

			this.JobMaxRank = this.GetInt("job_max_rank", 4);
			this.NoAdvancement = this.GetBool("no_advancement", false);

			this.ResurrectCityOption = this.GetBool("resurrect_city_option", true);

			this.DisplayQuestObjectives = this.GetBool("display_quest_objectives", true);

			this.DisableSDR = this.GetBool("disable_sdr", false);
			this.AbilityPointCost = this.GetInt("ability_point_cost", 1000);
			this.NormalAttackSkillFactorRate = this.GetFloat("normal_attack_skill_factor_rate", 1);
			this.PlayerSkillFactorRate = this.GetFloat("player_skill_factor_rate", 1);
			this.MonsterSkillFactorRate = this.GetFloat("monster_skill_factor_rate", 1);
			this.MonsterSkillSpeedRate = this.GetFloat("monster_skill_speed_rate", 1);
			this.MonsterSkillDelayRate = this.GetFloat("monster_skill_delay_rate", 1);
			this.FreezeAffectsElement = this.GetBool("freeze_affects_element", false);

			this.BlueOrbFollowWarp = this.GetBool("blue_orb_follow_warp", false);
			this.BlueOrbPetSystem = this.GetBool("blue_orb_pet_system", false);

			this.BlueJackpotSpawnChance = this.GetFloat("blue_jackpot_spawn_chance", 0.05f);
			this.BlueJackpotExpRate = this.GetFloat("blue_jackpot_exp_rate", 10000);
			this.SilverJackpotSpawnChance = this.GetFloat("silver_jackpot_spawn_chance", 0.05f);
			this.SilverJackpotRolls = this.GetInt("silver_jackpot_rolls", 100);
			this.SilverJackpotGuaranteedItemThreshold = this.GetFloat("silver_guaranteed_item_threshold", 0.5f);
			this.GoldJackpotSpawnChance = this.GetFloat("gold_jackpot_spawn_chance", 0.01f);
			this.GoldJackpotRolls = this.GetInt("gold_jackpot_rolls", 1000);
			this.GoldJackpotGuaranteedItemThreshold = this.GetFloat("gold_guaranteed_item_threshold", 0.5f);
			this.EliteSpawnChance = this.GetFloat("elite_spawn_chance", 2);
			this.EliteHPSPRate = this.GetFloat("elite_hpsp_rate", 150);
			this.EliteStatRate = this.GetFloat("elite_stat_rate", 150);
			this.EliteExpRate = this.GetFloat("elite_exp_rate", 2);
			this.EliteRolls = this.GetInt("elite_rolls", 2);
			this.EliteGuaranteedItemThreshold = this.GetFloat("elite_guaranteed_item_threshold", 0.5f);
			this.EliteMinLevel = this.GetInt("elite_min_level", 100);
			this.EliteAlwaysAggressive = this.GetBool("elite_always_aggressive", true);
			this.RedOrbJackpotRate = this.GetFloat("red_orb_jackpot_rate", 10000);
			this.RedOrbEliteRate = this.GetFloat("red_orb_elite_rate", 1000);

			this.ManualAdjustments();
		}

		private void ManualAdjustments()
		{
			// Round storage size to next full 10, since the client only extends
			// in multiples of 10.
			this.StorageDefaultSize = (int)Math.Ceiling(this.StorageDefaultSize / 10f) * 10;
			this.StorageMaxSize = (int)Math.Ceiling(this.StorageMaxSize / 10f) * 10;

			// Get the max number of storage extensions relative to the client's
			// default (60), as that's the value the client works with.
			this.StorageMaxExtensions = Math.Max(0, this.StorageMaxSize - 60) / 10;
		}
	}
}
