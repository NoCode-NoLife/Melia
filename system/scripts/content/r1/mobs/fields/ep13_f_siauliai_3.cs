//--- Melia Script -----------------------------------------------------------
// ep13_f_siauliai_3
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Paupys Crossing' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class Ep13FSiauliai3MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("ep13_f_siauliai_3", MonsterId.Biblioteka_Keeper, Properties("MHP", 936401, "MINPATK", 12542, "MAXPATK", 15317, "MINMATK", 12542, "MAXMATK", 15317, "DEF", 403219, "MDEF", 403219));
		AddPropertyOverrides("ep13_f_siauliai_3", MonsterId.Vynmedis, Properties("MHP", 940819, "MINPATK", 12599, "MAXPATK", 15387, "MINMATK", 12599, "MAXMATK", 15387, "DEF", 408225, "MDEF", 408225));
		AddPropertyOverrides("ep13_f_siauliai_3", MonsterId.Darbas_Leader, Properties("MHP", 945463, "MINPATK", 12658, "MAXPATK", 15460, "MINMATK", 12658, "MAXMATK", 15460, "DEF", 413489, "MDEF", 413489));
		AddPropertyOverrides("ep13_f_siauliai_3", MonsterId.Darbas_Cleaner, Properties("MHP", 950323, "MINPATK", 12721, "MAXPATK", 15537, "MINMATK", 12721, "MAXMATK", 15537, "DEF", 418998, "MDEF", 418998));

		// Monster Spawners ---------------------------------

		AddSpawner("ep13_f_siauliai_3.Id1", MonsterId.Rootcrystal_01, 13, 17, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id2", MonsterId.Biblioteka_Keeper, 38, 50, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id3", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id4", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id5", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id6", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id7", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id8", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id9", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id10", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id11", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id12", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id13", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id14", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id15", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id16", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id17", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id18", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id19", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id20", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id21", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id22", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id23", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id24", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id25", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id26", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id27", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id28", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id29", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id30", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id31", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id32", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id33", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id34", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id35", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id36", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id37", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id38", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id39", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id40", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id41", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id42", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id43", MonsterId.Biblioteka_Keeper, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id44", MonsterId.Biblioteka_Keeper, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id45", MonsterId.Biblioteka_Keeper, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id46", MonsterId.Biblioteka_Keeper, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id47", MonsterId.Biblioteka_Keeper, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id48", MonsterId.Biblioteka_Keeper, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id49", MonsterId.Biblioteka_Keeper, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id50", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id51", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id52", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id53", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id54", MonsterId.Darbas_Leader, 23, 30, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id55", MonsterId.Darbas_Cleaner, 45, 60, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id56", MonsterId.Biblioteka_Keeper, 12, 15, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id57", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id58", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id59", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id60", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id61", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id62", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id63", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id64", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id65", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id66", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id67", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id68", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id69", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id70", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id71", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id72", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id73", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id74", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id75", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id76", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id77", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id78", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id79", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id80", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id81", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id82", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id83", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id84", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id85", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id86", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id87", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 4 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id1", "ep13_f_siauliai_3", Rectangle(2380.5151, -606.1635, 100));
		AddSpawnPoint("ep13_f_siauliai_3.Id1", "ep13_f_siauliai_3", Rectangle(2198.2502, -265.53247, 100));
		AddSpawnPoint("ep13_f_siauliai_3.Id1", "ep13_f_siauliai_3", Rectangle(2102.2207, -689.11694, 100));
		AddSpawnPoint("ep13_f_siauliai_3.Id1", "ep13_f_siauliai_3", Rectangle(1804.1339, -221.97179, 100));
		AddSpawnPoint("ep13_f_siauliai_3.Id1", "ep13_f_siauliai_3", Rectangle(1358.5233, -59.836945, 100));
		AddSpawnPoint("ep13_f_siauliai_3.Id1", "ep13_f_siauliai_3", Rectangle(1322.0546, 348.49243, 100));
		AddSpawnPoint("ep13_f_siauliai_3.Id1", "ep13_f_siauliai_3", Rectangle(1696.5446, 421.49335, 100));
		AddSpawnPoint("ep13_f_siauliai_3.Id1", "ep13_f_siauliai_3", Rectangle(927.1197, 737.4825, 100));
		AddSpawnPoint("ep13_f_siauliai_3.Id1", "ep13_f_siauliai_3", Rectangle(954.064, 1588.8258, 100));
		AddSpawnPoint("ep13_f_siauliai_3.Id1", "ep13_f_siauliai_3", Rectangle(288.7393, 1470.7156, 100));
		AddSpawnPoint("ep13_f_siauliai_3.Id1", "ep13_f_siauliai_3", Rectangle(707.7839, 328.3694, 100));
		AddSpawnPoint("ep13_f_siauliai_3.Id1", "ep13_f_siauliai_3", Rectangle(709.82367, -593.56964, 100));
		AddSpawnPoint("ep13_f_siauliai_3.Id1", "ep13_f_siauliai_3", Rectangle(1252.5723, -542.3002, 100));
		AddSpawnPoint("ep13_f_siauliai_3.Id1", "ep13_f_siauliai_3", Rectangle(-337.20367, 144.50546, 100));
		AddSpawnPoint("ep13_f_siauliai_3.Id1", "ep13_f_siauliai_3", Rectangle(-484.84857, 699.91437, 100));
		AddSpawnPoint("ep13_f_siauliai_3.Id1", "ep13_f_siauliai_3", Rectangle(-985.82666, 191.86584, 100));
		AddSpawnPoint("ep13_f_siauliai_3.Id1", "ep13_f_siauliai_3", Rectangle(-977.6133, 834.6913, 100));

		// 'Biblioteka_Keeper' GenType 1005 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2054.589, -939.9258, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2109.4885, -1039.1143, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2173.53, -958.0306, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2163.7676, -847.82, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2068.2485, -684.5132, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2191.2944, -695.71924, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(1939.0054, -562.52655, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2069.6348, -563.3418, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2200.489, -600.5331, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(1867.7875, -414.18893, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(1840.1624, -303.93228, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2011.6174, -430.8581, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(1985.8531, -286.51093, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2142.648, -557.6906, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2097.8225, -252.59715, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2321.9827, -360.77515, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2348.5027, -235.96526, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2104.5203, -2.6408374, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2207.3572, -79.99488, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2297.6333, -45.24394, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2410.2485, -139.19061, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2457.5728, -34.57655, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2229.6135, -267.20413, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2158.417, -761.55853, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2254.9924, -441.81665, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2171.0737, -164.98769, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(1142.6023, 1398.9297, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(1254.0277, 1446.8142, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(809.4246, 1315.2456, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(-350.86554, 216.67743, 20));

		// 'Vynmedis' GenType 1006 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id3", "ep13_f_siauliai_3", Rectangle(1636.7205, -69.359985, 20));

		// 'Vynmedis' GenType 1007 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id4", "ep13_f_siauliai_3", Rectangle(1595.3389, -128.46216, 20));

		// 'Vynmedis' GenType 1008 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id5", "ep13_f_siauliai_3", Rectangle(1603.2219, -285.90076, 20));

		// 'Vynmedis' GenType 1009 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id6", "ep13_f_siauliai_3", Rectangle(1537.1847, -286.97852, 20));

		// 'Vynmedis' GenType 1010 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id7", "ep13_f_siauliai_3", Rectangle(1466.0264, -227.24905, 20));

		// 'Vynmedis' GenType 1011 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id8", "ep13_f_siauliai_3", Rectangle(1523.1394, -52.604, 20));

		// 'Vynmedis' GenType 1012 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id9", "ep13_f_siauliai_3", Rectangle(1399.1562, -169.54, 20));

		// 'Vynmedis' GenType 1013 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id10", "ep13_f_siauliai_3", Rectangle(1453.7036, -58.63729, 20));

		// 'Vynmedis' GenType 1014 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id11", "ep13_f_siauliai_3", Rectangle(1314.8778, 24.760002, 20));

		// 'Vynmedis' GenType 1015 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id12", "ep13_f_siauliai_3", Rectangle(1291.147, -58.097336, 20));

		// 'Vynmedis' GenType 1016 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id13", "ep13_f_siauliai_3", Rectangle(1294.9845, 177.35422, 20));

		// 'Vynmedis' GenType 1017 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id14", "ep13_f_siauliai_3", Rectangle(1181.6171, 223.84935, 20));

		// 'Vynmedis' GenType 1018 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id15", "ep13_f_siauliai_3", Rectangle(1221.5503, 302.9491, 20));

		// 'Vynmedis' GenType 1019 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id16", "ep13_f_siauliai_3", Rectangle(1449.4, 139.53609, 20));

		// 'Vynmedis' GenType 1020 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id17", "ep13_f_siauliai_3", Rectangle(1563.0637, 98.54182, 20));

		// 'Vynmedis' GenType 1021 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id18", "ep13_f_siauliai_3", Rectangle(1507.7485, 302.8721, 20));

		// 'Vynmedis' GenType 1022 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id19", "ep13_f_siauliai_3", Rectangle(1564.7849, 240.95366, 20));

		// 'Vynmedis' GenType 1023 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id20", "ep13_f_siauliai_3", Rectangle(1259.9702, 367.63074, 20));

		// 'Vynmedis' GenType 1024 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id21", "ep13_f_siauliai_3", Rectangle(1406.2926, 285.18277, 20));

		// 'Vynmedis' GenType 1025 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id22", "ep13_f_siauliai_3", Rectangle(1660.4358, 187.1632, 20));

		// 'Vynmedis' GenType 1026 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id23", "ep13_f_siauliai_3", Rectangle(1543.5847, 421.19928, 20));

		// 'Vynmedis' GenType 1027 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id24", "ep13_f_siauliai_3", Rectangle(1779.4202, 235.42148, 20));

		// 'Vynmedis' GenType 1028 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id25", "ep13_f_siauliai_3", Rectangle(1703.7181, 357.4636, 20));

		// 'Vynmedis' GenType 1029 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id26", "ep13_f_siauliai_3", Rectangle(1774.7528, 394.69522, 20));

		// 'Vynmedis' GenType 1030 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id27", "ep13_f_siauliai_3", Rectangle(1496.2759, 528.2328, 20));

		// 'Vynmedis' GenType 1031 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id28", "ep13_f_siauliai_3", Rectangle(1589.6254, 555.15173, 20));

		// 'Vynmedis' GenType 1032 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id29", "ep13_f_siauliai_3", Rectangle(1721.3619, 604.6577, 20));

		// 'Vynmedis' GenType 1033 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id30", "ep13_f_siauliai_3", Rectangle(1731.353, 490.01202, 20));

		// 'Vynmedis' GenType 1034 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id31", "ep13_f_siauliai_3", Rectangle(1353.2151, 452.69714, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id31", "ep13_f_siauliai_3", Rectangle(1395.9167, 467.17743, 20));

		// 'Vynmedis' GenType 1035 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id32", "ep13_f_siauliai_3", Rectangle(1198.2056, 450.4531, 20));

		// 'Vynmedis' GenType 1036 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id33", "ep13_f_siauliai_3", Rectangle(1294.9421, 495.87384, 20));

		// 'Vynmedis' GenType 1037 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id34", "ep13_f_siauliai_3", Rectangle(1144.8625, 509.25473, 20));

		// 'Vynmedis' GenType 1038 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id35", "ep13_f_siauliai_3", Rectangle(1110.8611, 624.614, 20));

		// 'Vynmedis' GenType 1039 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id36", "ep13_f_siauliai_3", Rectangle(1245.281, 515.8319, 20));

		// 'Vynmedis' GenType 1040 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id37", "ep13_f_siauliai_3", Rectangle(1209.3792, -15.5562, 20));

		// 'Vynmedis' GenType 1041 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id38", "ep13_f_siauliai_3", Rectangle(1559.5612, -202.50021, 20));

		// 'Vynmedis' GenType 1042 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id39", "ep13_f_siauliai_3", Rectangle(1200.4443, 160.14583, 20));

		// 'Vynmedis' GenType 1043 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id40", "ep13_f_siauliai_3", Rectangle(1840.3223, 327.52313, 20));

		// 'Vynmedis' GenType 1044 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id41", "ep13_f_siauliai_3", Rectangle(1571.5928, 317.70398, 20));

		// 'Vynmedis' GenType 1045 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id42", "ep13_f_siauliai_3", Rectangle(1384.9014, 179.61179, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id42", "ep13_f_siauliai_3", Rectangle(1819.2308, 277.0783, 20));

		// 'Biblioteka_Keeper' GenType 1046 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id43", "ep13_f_siauliai_3", Rectangle(1248.2122, 223.60074, 20));

		// 'Biblioteka_Keeper' GenType 1047 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id44", "ep13_f_siauliai_3", Rectangle(1489.9562, 197.89796, 20));

		// 'Biblioteka_Keeper' GenType 1048 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id45", "ep13_f_siauliai_3", Rectangle(1283.9136, 445.46384, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id45", "ep13_f_siauliai_3", Rectangle(1483.2736, 463.0604, 20));

		// 'Biblioteka_Keeper' GenType 1049 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id46", "ep13_f_siauliai_3", Rectangle(1664.3586, 531.5182, 20));

		// 'Biblioteka_Keeper' GenType 1050 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id47", "ep13_f_siauliai_3", Rectangle(1659.8279, 319.78934, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id47", "ep13_f_siauliai_3", Rectangle(1365.0596, -63.33947, 20));

		// 'Biblioteka_Keeper' GenType 1051 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id48", "ep13_f_siauliai_3", Rectangle(1504.8673, -136.86014, 20));

		// 'Biblioteka_Keeper' GenType 1052 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id49", "ep13_f_siauliai_3", Rectangle(1429.2761, 348.507, 20));

		// 'Vynmedis' GenType 1053 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id50", "ep13_f_siauliai_3", Rectangle(1842.9736, -204.0642, 20));

		// 'Vynmedis' GenType 1054 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id51", "ep13_f_siauliai_3", Rectangle(1783.8727, -263.40396, 20));

		// 'Vynmedis' GenType 1055 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id52", "ep13_f_siauliai_3", Rectangle(1912.7755, -259.46066, 20));

		// 'Vynmedis' GenType 1056 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id53", "ep13_f_siauliai_3", Rectangle(1827.232, -384.87436, 20));

		// 'Darbas_Leader' GenType 1058 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(768.36285, 375.94888, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(873.1764, 632.72797, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(1470.3999, -650.7165, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(681.3138, -467.08878, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(-425.2916, 41.271626, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(-891.8596, 103.40538, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(-1146.5707, 984.5691, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(-276.52005, 799.45966, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(859.8239, 1367.2076, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(1075.6677, 1058.7676, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(-233.06636, 320.36194, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(-695.4048, 571.08093, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(860.25665, -445.1302, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(624.9453, -53.578247, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(1223.5332, 1360.1826, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(-449.82062, 842.5057, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(-911.21844, 706.72687, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(869.12354, -11.652604, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(674.5705, 587.35205, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(-334.94604, 534.1091, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(-200.1902, 1100.2234, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(347.21912, 1475.552, 20));

		// 'Darbas_Cleaner' GenType 1059 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(1548.5712, -734.7028, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(1564.5946, -595.4219, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(1368.6793, -478.15356, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(632.15375, -568.9576, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(586.48114, -416.20502, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(813.7704, 279.6105, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(715.94727, 498.9317, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(682.4941, 762.3016, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(998.41425, 619.41376, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(976.78094, 1045.488, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(1117.165, 948.6794, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(916.9089, 1263.1125, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(1216.0604, 1270.1124, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(942.5245, 1407.6078, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(226.34158, 1541.8925, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(407.45975, 1549.1516, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-361.72473, 912.75146, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-172.52347, 814.7958, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-444.08994, 174.75778, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-297.94983, 88.42929, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-334.3536, 358.9394, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-115.23779, 199.70775, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-1045.3606, 173.90091, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-817.17535, 151.75566, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-563.6681, 436.20767, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-782.9525, 675.07336, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-1093.6708, 1039.6831, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-1104.0469, 879.9976, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(1043.4335, -753.17554, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(762.70703, -654.58624, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(1184.493, -530.6065, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(1183.5809, -370.0234, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(733.651, -4.9160366, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(336.81482, 18.655838, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-517.0565, 739.4593, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-89.15468, 1259.0356, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(684.2173, 321.4666, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-1016.2294, 765.48364, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-1.0823784, 777.62427, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(326.12308, 779.7271, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(1359.3616, -735.7539, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(1360.0425, -612.3659, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(899.288, -136.17444, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(128.07321, 10.527216, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(945.96906, 504.97922, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(687.5511, 1415.7799, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-931.62726, 196.34517, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-655.57153, 325.90997, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-1282.3586, 908.88293, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-1277.1707, 999.5028, 20));

		// 'Biblioteka_Keeper' GenType 1060 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id56", "ep13_f_siauliai_3", Rectangle(-228.19456, 170.82399, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id56", "ep13_f_siauliai_3", Rectangle(-441.8573, 402.90564, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id56", "ep13_f_siauliai_3", Rectangle(-587.5778, 646.71124, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id56", "ep13_f_siauliai_3", Rectangle(-1006.2681, 274.01123, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id56", "ep13_f_siauliai_3", Rectangle(-1034.7478, 946.14575, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id56", "ep13_f_siauliai_3", Rectangle(-288.1825, 937.7226, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id56", "ep13_f_siauliai_3", Rectangle(263.24698, 1444.0159, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id56", "ep13_f_siauliai_3", Rectangle(847.35913, 796.67896, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id56", "ep13_f_siauliai_3", Rectangle(997.0339, 908.18835, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id56", "ep13_f_siauliai_3", Rectangle(794.0654, 482.86676, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id56", "ep13_f_siauliai_3", Rectangle(1260.916, -660.25977, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id56", "ep13_f_siauliai_3", Rectangle(1254.4651, -479.55646, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id56", "ep13_f_siauliai_3", Rectangle(942.14246, -533.64813, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id56", "ep13_f_siauliai_3", Rectangle(764.8345, -337.85254, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id56", "ep13_f_siauliai_3", Rectangle(-416.85956, 668.086, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id56", "ep13_f_siauliai_3", Rectangle(1140.5995, -242.16776, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id56", "ep13_f_siauliai_3", Rectangle(993.7819, -145.88614, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id56", "ep13_f_siauliai_3", Rectangle(-78.22551, 1144.4551, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id56", "ep13_f_siauliai_3", Rectangle(11.331591, 1296.4348, 20));

		// 'Vynmedis' GenType 1061 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id57", "ep13_f_siauliai_3", Rectangle(597.76416, -684.9973, 20));

		// 'Vynmedis' GenType 1062 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id58", "ep13_f_siauliai_3", Rectangle(-559.12866, 17.144793, 20));

		// 'Vynmedis' GenType 1063 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id59", "ep13_f_siauliai_3", Rectangle(863.6123, -640.8794, 20));

		// 'Vynmedis' GenType 1064 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id60", "ep13_f_siauliai_3", Rectangle(546.48004, 56.315052, 20));

		// 'Vynmedis' GenType 1065 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id61", "ep13_f_siauliai_3", Rectangle(624.8023, -314.62387, 20));

		// 'Vynmedis' GenType 1066 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id62", "ep13_f_siauliai_3", Rectangle(879.77374, -334.5664, 20));

		// 'Vynmedis' GenType 1067 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id63", "ep13_f_siauliai_3", Rectangle(1231.1334, -729.6672, 20));

		// 'Vynmedis' GenType 1068 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id64", "ep13_f_siauliai_3", Rectangle(1460.8312, -568.8017, 20));

		// 'Vynmedis' GenType 1069 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id65", "ep13_f_siauliai_3", Rectangle(-152.90865, 313.09866, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id65", "ep13_f_siauliai_3", Rectangle(1437.0684, -776.548, 20));

		// 'Vynmedis' GenType 1070 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id66", "ep13_f_siauliai_3", Rectangle(1301.3987, -371.09732, 20));

		// 'Vynmedis' GenType 1071 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id67", "ep13_f_siauliai_3", Rectangle(436.48694, 1320.8922, 20));

		// 'Vynmedis' GenType 1072 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id68", "ep13_f_siauliai_3", Rectangle(-927.0478, 878.66895, 20));

		// 'Vynmedis' GenType 1073 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id69", "ep13_f_siauliai_3", Rectangle(1002.6783, -60.91156, 20));

		// 'Vynmedis' GenType 1074 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id70", "ep13_f_siauliai_3", Rectangle(771.07935, -76.78141, 20));

		// 'Vynmedis' GenType 1075 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id71", "ep13_f_siauliai_3", Rectangle(362.34088, 78.59825, 20));

		// 'Vynmedis' GenType 1076 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id72", "ep13_f_siauliai_3", Rectangle(635.76086, 272.00616, 20));

		// 'Vynmedis' GenType 1077 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id73", "ep13_f_siauliai_3", Rectangle(685.0558, 420.27734, 20));

		// 'Vynmedis' GenType 1078 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id74", "ep13_f_siauliai_3", Rectangle(539.5667, 633.27435, 20));

		// 'Vynmedis' GenType 1079 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id75", "ep13_f_siauliai_3", Rectangle(527.77747, 438.81714, 20));

		// 'Vynmedis' GenType 1080 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id76", "ep13_f_siauliai_3", Rectangle(800.70026, 888.3606, 20));

		// 'Vynmedis' GenType 1081 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id77", "ep13_f_siauliai_3", Rectangle(869.36835, 1022.1696, 20));

		// 'Vynmedis' GenType 1082 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id78", "ep13_f_siauliai_3", Rectangle(973.0868, 735.16614, 20));

		// 'Vynmedis' GenType 1083 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id79", "ep13_f_siauliai_3", Rectangle(1115.6829, 1135.1676, 20));

		// 'Vynmedis' GenType 1084 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id80", "ep13_f_siauliai_3", Rectangle(1026.0623, 1362.0841, 20));

		// 'Vynmedis' GenType 1085 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id81", "ep13_f_siauliai_3", Rectangle(867.84753, 1195.1194, 20));

		// 'Vynmedis' GenType 1086 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id82", "ep13_f_siauliai_3", Rectangle(-930.512, 3.3752747, 20));

		// 'Vynmedis' GenType 1087 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id83", "ep13_f_siauliai_3", Rectangle(-484.4574, 270.95242, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id83", "ep13_f_siauliai_3", Rectangle(815.4492, 1495.7961, 20));

		// 'Vynmedis' GenType 1088 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id84", "ep13_f_siauliai_3", Rectangle(-162.25671, 1202.8055, 20));

		// 'Vynmedis' GenType 1089 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id85", "ep13_f_siauliai_3", Rectangle(-229.8618, 967.30176, 20));

		// 'Vynmedis' GenType 1090 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id86", "ep13_f_siauliai_3", Rectangle(-289.04617, 645.5267, 20));

		// 'Vynmedis' GenType 1091 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id87", "ep13_f_siauliai_3", Rectangle(-699.52795, 451.68866, 20));
	}
}
