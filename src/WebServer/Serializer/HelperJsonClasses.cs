using System.Collections.Generic;
using Newtonsoft.Json;

namespace Melia.Web.Serializer
{
	public class Config
	{
		[JsonProperty("barracks")]
		public Barracks Barracks { get; set; }

		[JsonProperty("database")]
		public Database Database { get; set; }

		[JsonProperty("commands")]
		public Commands Commands { get; set; }

		[JsonProperty("log")]
		public Logs Log { get; set; }

		[JsonProperty("web")]
		public Web Web { get; set; }

		[JsonProperty("world")]
		public World World { get; set; }

		[JsonProperty("localization")]
		public Localization Localization { get; set; }
	}

	public class Barracks
	{
		[JsonProperty("start_location")]
		public string StartLocation { get; set; }

		[JsonProperty("ipf_verifying")]
		public string IpfVerifying { get; set; }

		[JsonProperty("ipf_checksum")]
		public string IpfChecksum { get; set; }
	}

	public class Commands
	{
		[JsonProperty("prefix")]
		public string Prefix { get; set; }

		[JsonProperty("default")]
		public string Default { get; set; }

		[JsonProperty("requpdateequip")]
		public string Requpdateequip { get; set; }

		[JsonProperty("buyabilpoint")]
		public string Buyabilpoint { get; set; }

		[JsonProperty("learnpcabil")]
		public string Learnpcabil { get; set; }

		[JsonProperty("buyshop")]
		public string Buyshop { get; set; }

		[JsonProperty("updatemouse")]
		public string Updatemouse { get; set; }

		[JsonProperty("help")]
		public string Help { get; set; }

		[JsonProperty("where")]
		public string Where { get; set; }

		[JsonProperty("time")]
		public string Time { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("autoloot")]
		public string Autoloot { get; set; }

		[JsonProperty("jump")]
		public string Jump { get; set; }

		[JsonProperty("warp")]
		public string Warp { get; set; }

		[JsonProperty("item")]
		public string Item { get; set; }

		[JsonProperty("silver")]
		public string Silver { get; set; }

		[JsonProperty("spawn")]
		public string Spawn { get; set; }

		[JsonProperty("madhatter")]
		public string Madhatter { get; set; }

		[JsonProperty("levelup")]
		public string Levelup { get; set; }

		[JsonProperty("speed")]
		public string Speed { get; set; }

		[JsonProperty("iteminfo")]
		public string Iteminfo { get; set; }

		[JsonProperty("monsterinfo")]
		public string Monsterinfo { get; set; }

		[JsonProperty("whodrops")]
		public string Whodrops { get; set; }

		[JsonProperty("go")]
		public string Go { get; set; }

		[JsonProperty("goto")]
		public string Goto { get; set; }

		[JsonProperty("recall")]
		public string Recall { get; set; }

		[JsonProperty("recallmap")]
		public string Recallmap { get; set; }

		[JsonProperty("recallall")]
		public string Recallall { get; set; }

		[JsonProperty("heal")]
		public string Heal { get; set; }

		[JsonProperty("clearinv")]
		public string Clearinv { get; set; }

		[JsonProperty("addjob")]
		public string Addjob { get; set; }

		[JsonProperty("removejob")]
		public string Removejob { get; set; }

		[JsonProperty("skillpoints")]
		public string Skillpoints { get; set; }

		[JsonProperty("statpoints")]
		public string Statpoints { get; set; }

		[JsonProperty("broadcast")]
		public string Broadcast { get; set; }

		[JsonProperty("kick")]
		public string Kick { get; set; }

		[JsonProperty("reloadscripts")]
		public string Reloadscripts { get; set; }

		[JsonProperty("reloadconf")]
		public string Reloadconf { get; set; }

		[JsonProperty("reloaddata")]
		public string Reloaddata { get; set; }

		[JsonProperty("updatedata")]
		public string Updatedata { get; set; }

		[JsonProperty("updatedatacom")]
		public string Updatedatacom { get; set; }

		[JsonProperty("feature")]
		public string Feature { get; set; }

		[JsonProperty("test")]
		public string Test { get; set; }
	}

	public class Database
	{
		[JsonProperty("host")]
		public string Host { get; set; }

		[JsonProperty("user")]
		public string User { get; set; }

		[JsonProperty("pass")]
		public string Pass { get; set; }

		[JsonProperty("database")]
		public string DatabaseName { get; set; }
	}

	public class Localization
	{
		[JsonProperty("language")]
		public string Language { get; set; }

		[JsonProperty("culture")]
		public string Culture { get; set; }

		[JsonProperty("culture_ui")]
		public string CultureUi { get; set; }
	}

	public class Logs
	{
		[JsonProperty("log_filter")]
		public string LogFilter { get; set; }
	}

	public class Root
	{
		[JsonProperty("barracks")]
		public Barracks Barracks { get; set; }

		[JsonProperty("database")]
		public Database Database { get; set; }

		[JsonProperty("commands")]
		public Commands Commands { get; set; }

		[JsonProperty("logs")]
		public Logs Logs { get; set; }

		[JsonProperty("web")]
		public Web Web { get; set; }

		[JsonProperty("world")]
		public World World { get; set; }

		[JsonProperty("localization")]
		public Localization Localization { get; set; }
	}

	public class Web
	{
		[JsonProperty("php_cgi_exe")]
		public string PhpCgiExe { get; set; }

		[JsonProperty("php_download")]
		public string PhpDownload { get; set; }
	}

	public class World
	{
		[JsonProperty("silver_drop_amount")]
		public string SilverDropAmount { get; set; }

		[JsonProperty("silver_drop_rate")]
		public string SilverDropRate { get; set; }

		[JsonProperty("equipment_drop_rate")]
		public string EquipmentDropRate { get; set; }

		[JsonProperty("blue_orb_drop_rate")]
		public string BlueOrbDropRate { get; set; }

		[JsonProperty("red_orb_drop_rate")]
		public string RedOrbDropRate { get; set; }

		[JsonProperty("gem_drop_rate")]
		public string GemDropRate { get; set; }

		[JsonProperty("general_drop_rate")]
		public string GeneralDropRate { get; set; }

		[JsonProperty("drop_radius")]
		public string DropRadius { get; set; }

		[JsonProperty("pick_up_radius")]
		public string PickUpRadius { get; set; }

		[JsonProperty("loot_protection")]
		public string LootProtection { get; set; }

		[JsonProperty("drop_disappear_time")]
		public string DropDisappearTime { get; set; }

		[JsonProperty("littering")]
		public string Littering { get; set; }

		[JsonProperty("targeted_littering")]
		public string TargetedLittering { get; set; }

		[JsonProperty("exp_rate")]
		public string ExpRate { get; set; }

		[JsonProperty("class_exp_rate")]
		public string ClassExpRate { get; set; }

		[JsonProperty("rt2gt_ms_per_minute")]
		public string Rt2gtMsPerMinute { get; set; }

		[JsonProperty("gt_minutes_per_hour")]
		public string GtMinutesPerHour { get; set; }

		[JsonProperty("gt_hours_per_day")]
		public string GtHoursPerDay { get; set; }

		[JsonProperty("gt_days_per_month")]
		public string GtDaysPerMonth { get; set; }

		[JsonProperty("gt_months_per_year")]
		public string GtMonthsPerYear { get; set; }

		[JsonProperty("enable_day_night_cycle")]
		public string EnableDayNightCycle { get; set; }

		[JsonProperty("disable_sdr")]
		public string DisableSdr { get; set; }

		[JsonProperty("ability_point_cost")]
		public string AbilityPointCost { get; set; }

		[JsonProperty("blue_orb_follow_warp")]
		public string BlueOrbFollowWarp { get; set; }
	}

	public class Message
	{
		[JsonProperty("message")]
		public string message { get; set; }
	}

	public class ProcessMessage
	{
		[JsonProperty("ProcessId")]
		public int processId { get; set; }
	}

	public class RootServer
	{
		[JsonProperty("groupId")]
		public int GroupId { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("servers")]
		public List<ServerSerialize> Servers { get; set; }
	}

	public class ServerSerialize
	{
		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("ip")]
		public string Ip { get; set; }

		[JsonProperty("port")]
		public int Port { get; set; }

		[JsonProperty("interPort")]
		public int InterPort { get; set; }

		[JsonProperty("maps")]
		public string Maps { get; set; }
	}
}
