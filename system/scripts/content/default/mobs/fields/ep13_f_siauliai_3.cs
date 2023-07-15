//--- Melia Script -----------------------------------------------------------
// ep13_f_siauliai_3
//
//--- Description -----------------------------------------------------------
// Sets up the ep13_f_siauliai_3 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class Ep13FSiauliai3MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("ep13_f_siauliai_3", MonsterId.Biblioteka_Keeper, Properties("MHP", 936401, "MINPATK", 12542, "MAXPATK", 15317, "MINMATK", 12542, "MAXMATK", 15317, "DEF", 403219, "MDEF", 403219));
		AddPropertyOverrides("ep13_f_siauliai_3", MonsterId.Vynmedis, Properties("MHP", 940819, "MINPATK", 12599, "MAXPATK", 15387, "MINMATK", 12599, "MAXMATK", 15387, "DEF", 408225, "MDEF", 408225));
		AddPropertyOverrides("ep13_f_siauliai_3", MonsterId.Darbas_Leader, Properties("MHP", 945463, "MINPATK", 12658, "MAXPATK", 15460, "MINMATK", 12658, "MAXMATK", 15460, "DEF", 413489, "MDEF", 413489));
		AddPropertyOverrides("ep13_f_siauliai_3", MonsterId.Darbas_Cleaner, Properties("MHP", 950323, "MINPATK", 12721, "MAXPATK", 15537, "MINMATK", 12721, "MAXMATK", 15537, "DEF", 418998, "MDEF", 418998));

		// Monster Spawners --------------------------------

		AddSpawner(MonsterId.Rootcrystal_01, 17, "SpawnPointCollection1.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Biblioteka_Keeper, 50, "SpawnPointCollection2.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection3.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection4.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection5.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection6.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection7.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection8.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection9.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection10.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection11.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection12.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection13.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection14.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection15.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection16.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection17.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection18.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection19.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection20.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection21.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection22.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection23.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection24.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection25.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection26.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection27.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection28.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection29.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection30.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection31.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection32.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection33.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection34.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection35.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection36.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection37.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection38.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection39.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection40.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection41.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection42.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Biblioteka_Keeper, 1, "SpawnPointCollection43.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Biblioteka_Keeper, 1, "SpawnPointCollection44.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Biblioteka_Keeper, 1, "SpawnPointCollection45.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Biblioteka_Keeper, 1, "SpawnPointCollection46.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Biblioteka_Keeper, 1, "SpawnPointCollection47.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Biblioteka_Keeper, 1, "SpawnPointCollection48.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Biblioteka_Keeper, 1, "SpawnPointCollection49.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection50.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection51.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection52.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection53.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Darbas_Leader, 30, "SpawnPointCollection54.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Darbas_Cleaner, 60, "SpawnPointCollection55.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Biblioteka_Keeper, 15, "SpawnPointCollection56.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection57.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection58.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection59.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection60.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection61.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection62.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection63.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection64.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection65.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection66.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection67.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection68.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection69.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection70.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection71.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection72.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection73.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection74.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection75.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection76.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection77.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection78.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection79.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection80.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection81.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection82.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection83.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection84.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection85.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection86.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Vynmedis, 1, "SpawnPointCollection87.ep13_f_siauliai_3", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3", Spot(2380.5151, -606.1635, 100), "SpawnPointCollection1.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(2198.2502, -265.53247, 100), "SpawnPointCollection1.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(2102.2207, -689.11694, 100), "SpawnPointCollection1.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1804.1339, -221.97179, 100), "SpawnPointCollection1.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1358.5233, -59.836945, 100), "SpawnPointCollection1.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1322.0546, 348.49243, 100), "SpawnPointCollection1.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1696.5446, 421.49335, 100), "SpawnPointCollection1.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(927.1197, 737.4825, 100), "SpawnPointCollection1.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(954.064, 1588.8258, 100), "SpawnPointCollection1.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(288.7393, 1470.7156, 100), "SpawnPointCollection1.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(707.7839, 328.3694, 100), "SpawnPointCollection1.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(709.82367, -593.56964, 100), "SpawnPointCollection1.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1252.5723, -542.3002, 100), "SpawnPointCollection1.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-337.20367, 144.50546, 100), "SpawnPointCollection1.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-484.84857, 699.91437, 100), "SpawnPointCollection1.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-985.82666, 191.86584, 100), "SpawnPointCollection1.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-977.6133, 834.6913, 100), "SpawnPointCollection1.ep13_f_siauliai_3");

		// Biblioteka_Keeper Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3", Spot(2054.589, -939.9258, 20), "SpawnPointCollection2.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(2109.4885, -1039.1143, 20), "SpawnPointCollection2.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(2173.53, -958.0306, 20), "SpawnPointCollection2.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(2163.7676, -847.82, 20), "SpawnPointCollection2.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(2068.2485, -684.5132, 20), "SpawnPointCollection2.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(2191.2944, -695.71924, 20), "SpawnPointCollection2.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1939.0054, -562.52655, 20), "SpawnPointCollection2.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(2069.6348, -563.3418, 20), "SpawnPointCollection2.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(2200.489, -600.5331, 20), "SpawnPointCollection2.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1867.7875, -414.18893, 20), "SpawnPointCollection2.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1840.1624, -303.93228, 20), "SpawnPointCollection2.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(2011.6174, -430.8581, 20), "SpawnPointCollection2.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1985.8531, -286.51093, 20), "SpawnPointCollection2.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(2142.648, -557.6906, 20), "SpawnPointCollection2.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(2097.8225, -252.59715, 20), "SpawnPointCollection2.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(2321.9827, -360.77515, 20), "SpawnPointCollection2.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(2348.5027, -235.96526, 20), "SpawnPointCollection2.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(2104.5203, -2.6408374, 20), "SpawnPointCollection2.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(2207.3572, -79.99488, 20), "SpawnPointCollection2.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(2297.6333, -45.24394, 20), "SpawnPointCollection2.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(2410.2485, -139.19061, 20), "SpawnPointCollection2.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(2457.5728, -34.57655, 20), "SpawnPointCollection2.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(2229.6135, -267.20413, 20), "SpawnPointCollection2.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(2158.417, -761.55853, 20), "SpawnPointCollection2.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(2254.9924, -441.81665, 20), "SpawnPointCollection2.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(2171.0737, -164.98769, 20), "SpawnPointCollection2.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1142.6023, 1398.9297, 20), "SpawnPointCollection2.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1254.0277, 1446.8142, 20), "SpawnPointCollection2.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(809.4246, 1315.2456, 20), "SpawnPointCollection2.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-350.86554, 216.67743, 20), "SpawnPointCollection2.ep13_f_siauliai_3");

		// Vynmedis Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1636.7205, -69.359985, 20), "SpawnPointCollection3.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1595.3389, -128.46216, 20), "SpawnPointCollection4.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1603.2219, -285.90076, 20), "SpawnPointCollection5.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1537.1847, -286.97852, 20), "SpawnPointCollection6.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1466.0264, -227.24905, 20), "SpawnPointCollection7.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1523.1394, -52.604, 20), "SpawnPointCollection8.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1399.1562, -169.54, 20), "SpawnPointCollection9.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1453.7036, -58.63729, 20), "SpawnPointCollection10.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1314.8778, 24.760002, 20), "SpawnPointCollection11.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1291.147, -58.097336, 20), "SpawnPointCollection12.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1294.9845, 177.35422, 20), "SpawnPointCollection13.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1181.6171, 223.84935, 20), "SpawnPointCollection14.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1221.5503, 302.9491, 20), "SpawnPointCollection15.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1449.4, 139.53609, 20), "SpawnPointCollection16.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1563.0637, 98.54182, 20), "SpawnPointCollection17.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1507.7485, 302.8721, 20), "SpawnPointCollection18.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1564.7849, 240.95366, 20), "SpawnPointCollection19.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1259.9702, 367.63074, 20), "SpawnPointCollection20.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1406.2926, 285.18277, 20), "SpawnPointCollection21.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1660.4358, 187.1632, 20), "SpawnPointCollection22.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1543.5847, 421.19928, 20), "SpawnPointCollection23.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1779.4202, 235.42148, 20), "SpawnPointCollection24.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1703.7181, 357.4636, 20), "SpawnPointCollection25.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1774.7528, 394.69522, 20), "SpawnPointCollection26.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1496.2759, 528.2328, 20), "SpawnPointCollection27.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1589.6254, 555.15173, 20), "SpawnPointCollection28.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1721.3619, 604.6577, 20), "SpawnPointCollection29.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1731.353, 490.01202, 20), "SpawnPointCollection30.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1353.2151, 452.69714, 20), "SpawnPointCollection31.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1395.9167, 467.17743, 20), "SpawnPointCollection31.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1198.2056, 450.4531, 20), "SpawnPointCollection32.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1294.9421, 495.87384, 20), "SpawnPointCollection33.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1144.8625, 509.25473, 20), "SpawnPointCollection34.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1110.8611, 624.614, 20), "SpawnPointCollection35.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1245.281, 515.8319, 20), "SpawnPointCollection36.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1209.3792, -15.5562, 20), "SpawnPointCollection37.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1559.5612, -202.50021, 20), "SpawnPointCollection38.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1200.4443, 160.14583, 20), "SpawnPointCollection39.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1840.3223, 327.52313, 20), "SpawnPointCollection40.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1571.5928, 317.70398, 20), "SpawnPointCollection41.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1384.9014, 179.61179, 20), "SpawnPointCollection42.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1819.2308, 277.0783, 20), "SpawnPointCollection42.ep13_f_siauliai_3");

		// Biblioteka_Keeper Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1248.2122, 223.60074, 20), "SpawnPointCollection43.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1489.9562, 197.89796, 20), "SpawnPointCollection44.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1283.9136, 445.46384, 20), "SpawnPointCollection45.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1483.2736, 463.0604, 20), "SpawnPointCollection45.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1664.3586, 531.5182, 20), "SpawnPointCollection46.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1659.8279, 319.78934, 20), "SpawnPointCollection47.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1365.0596, -63.33947, 20), "SpawnPointCollection47.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1504.8673, -136.86014, 20), "SpawnPointCollection48.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1429.2761, 348.507, 20), "SpawnPointCollection49.ep13_f_siauliai_3");

		// Vynmedis Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1842.9736, -204.0642, 20), "SpawnPointCollection50.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1783.8727, -263.40396, 20), "SpawnPointCollection51.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1912.7755, -259.46066, 20), "SpawnPointCollection52.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1827.232, -384.87436, 20), "SpawnPointCollection53.ep13_f_siauliai_3");

		// Darbas_Leader Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3", Spot(768.36285, 375.94888, 20), "SpawnPointCollection54.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(873.1764, 632.72797, 20), "SpawnPointCollection54.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1470.3999, -650.7165, 20), "SpawnPointCollection54.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(681.3138, -467.08878, 20), "SpawnPointCollection54.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-425.2916, 41.271626, 20), "SpawnPointCollection54.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-891.8596, 103.40538, 20), "SpawnPointCollection54.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-1146.5707, 984.5691, 20), "SpawnPointCollection54.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-276.52005, 799.45966, 20), "SpawnPointCollection54.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(859.8239, 1367.2076, 20), "SpawnPointCollection54.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1075.6677, 1058.7676, 20), "SpawnPointCollection54.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-233.06636, 320.36194, 20), "SpawnPointCollection54.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-695.4048, 571.08093, 20), "SpawnPointCollection54.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(860.25665, -445.1302, 20), "SpawnPointCollection54.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(624.9453, -53.578247, 20), "SpawnPointCollection54.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1223.5332, 1360.1826, 20), "SpawnPointCollection54.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-449.82062, 842.5057, 20), "SpawnPointCollection54.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-911.21844, 706.72687, 20), "SpawnPointCollection54.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(869.12354, -11.652604, 20), "SpawnPointCollection54.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(674.5705, 587.35205, 20), "SpawnPointCollection54.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-334.94604, 534.1091, 20), "SpawnPointCollection54.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-200.1902, 1100.2234, 20), "SpawnPointCollection54.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(347.21912, 1475.552, 20), "SpawnPointCollection54.ep13_f_siauliai_3");

		// Darbas_Cleaner Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1548.5712, -734.7028, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1564.5946, -595.4219, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1368.6793, -478.15356, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(632.15375, -568.9576, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(586.48114, -416.20502, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(813.7704, 279.6105, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(715.94727, 498.9317, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(682.4941, 762.3016, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(998.41425, 619.41376, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(976.78094, 1045.488, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1117.165, 948.6794, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(916.9089, 1263.1125, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1216.0604, 1270.1124, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(942.5245, 1407.6078, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(226.34158, 1541.8925, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(407.45975, 1549.1516, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-361.72473, 912.75146, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-172.52347, 814.7958, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-444.08994, 174.75778, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-297.94983, 88.42929, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-334.3536, 358.9394, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-115.23779, 199.70775, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-1045.3606, 173.90091, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-817.17535, 151.75566, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-563.6681, 436.20767, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-782.9525, 675.07336, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-1093.6708, 1039.6831, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-1104.0469, 879.9976, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1043.4335, -753.17554, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(762.70703, -654.58624, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1184.493, -530.6065, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1183.5809, -370.0234, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(733.651, -4.9160366, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(336.81482, 18.655838, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-517.0565, 739.4593, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-89.15468, 1259.0356, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(684.2173, 321.4666, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-1016.2294, 765.48364, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-1.0823784, 777.62427, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(326.12308, 779.7271, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1359.3616, -735.7539, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1360.0425, -612.3659, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(899.288, -136.17444, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(128.07321, 10.527216, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(945.96906, 504.97922, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(687.5511, 1415.7799, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-931.62726, 196.34517, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-655.57153, 325.90997, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-1282.3586, 908.88293, 20), "SpawnPointCollection55.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-1277.1707, 999.5028, 20), "SpawnPointCollection55.ep13_f_siauliai_3");

		// Biblioteka_Keeper Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-228.19456, 170.82399, 20), "SpawnPointCollection56.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-441.8573, 402.90564, 20), "SpawnPointCollection56.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-587.5778, 646.71124, 20), "SpawnPointCollection56.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-1006.2681, 274.01123, 20), "SpawnPointCollection56.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-1034.7478, 946.14575, 20), "SpawnPointCollection56.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-288.1825, 937.7226, 20), "SpawnPointCollection56.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(263.24698, 1444.0159, 20), "SpawnPointCollection56.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(847.35913, 796.67896, 20), "SpawnPointCollection56.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(997.0339, 908.18835, 20), "SpawnPointCollection56.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(794.0654, 482.86676, 20), "SpawnPointCollection56.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1260.916, -660.25977, 20), "SpawnPointCollection56.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1254.4651, -479.55646, 20), "SpawnPointCollection56.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(942.14246, -533.64813, 20), "SpawnPointCollection56.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(764.8345, -337.85254, 20), "SpawnPointCollection56.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-416.85956, 668.086, 20), "SpawnPointCollection56.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1140.5995, -242.16776, 20), "SpawnPointCollection56.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(993.7819, -145.88614, 20), "SpawnPointCollection56.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-78.22551, 1144.4551, 20), "SpawnPointCollection56.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(11.331591, 1296.4348, 20), "SpawnPointCollection56.ep13_f_siauliai_3");

		// Vynmedis Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3", Spot(597.76416, -684.9973, 20), "SpawnPointCollection57.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-559.12866, 17.144793, 20), "SpawnPointCollection58.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(863.6123, -640.8794, 20), "SpawnPointCollection59.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(546.48004, 56.315052, 20), "SpawnPointCollection60.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(624.8023, -314.62387, 20), "SpawnPointCollection61.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(879.77374, -334.5664, 20), "SpawnPointCollection62.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1231.1334, -729.6672, 20), "SpawnPointCollection63.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1460.8312, -568.8017, 20), "SpawnPointCollection64.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-152.90865, 313.09866, 20), "SpawnPointCollection65.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1437.0684, -776.548, 20), "SpawnPointCollection65.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1301.3987, -371.09732, 20), "SpawnPointCollection66.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(436.48694, 1320.8922, 20), "SpawnPointCollection67.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-927.0478, 878.66895, 20), "SpawnPointCollection68.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1002.6783, -60.91156, 20), "SpawnPointCollection69.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(771.07935, -76.78141, 20), "SpawnPointCollection70.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(362.34088, 78.59825, 20), "SpawnPointCollection71.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(635.76086, 272.00616, 20), "SpawnPointCollection72.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(685.0558, 420.27734, 20), "SpawnPointCollection73.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(539.5667, 633.27435, 20), "SpawnPointCollection74.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(527.77747, 438.81714, 20), "SpawnPointCollection75.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(800.70026, 888.3606, 20), "SpawnPointCollection76.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(869.36835, 1022.1696, 20), "SpawnPointCollection77.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(973.0868, 735.16614, 20), "SpawnPointCollection78.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1115.6829, 1135.1676, 20), "SpawnPointCollection79.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(1026.0623, 1362.0841, 20), "SpawnPointCollection80.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(867.84753, 1195.1194, 20), "SpawnPointCollection81.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-930.512, 3.3752747, 20), "SpawnPointCollection82.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-484.4574, 270.95242, 20), "SpawnPointCollection83.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(815.4492, 1495.7961, 20), "SpawnPointCollection83.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-162.25671, 1202.8055, 20), "SpawnPointCollection84.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-229.8618, 967.30176, 20), "SpawnPointCollection85.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-289.04617, 645.5267, 20), "SpawnPointCollection86.ep13_f_siauliai_3");
		AddSpawnPoint("ep13_f_siauliai_3", Spot(-699.52795, 451.68866, 20), "SpawnPointCollection87.ep13_f_siauliai_3");

	}
}
