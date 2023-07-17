//--- Melia Script -----------------------------------------------------------
// d_zachariel_34
//
//--- Description -----------------------------------------------------------
// Sets up the d_zachariel_34 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DZachariel34MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("d_zachariel_34", MonsterId.Echad, Properties("MHP", 68268, "MINPATK", 1379, "MAXPATK", 1596, "MINMATK", 1379, "MAXMATK", 1596, "DEF", 446, "MDEF", 446));
		AddPropertyOverrides("d_zachariel_34", MonsterId.Wolf_Statue_Mage_Pollution, Properties("MHP", 69121, "MINPATK", 1390, "MAXPATK", 1610, "MINMATK", 1390, "MAXMATK", 1610, "DEF", 459, "MDEF", 459));
		AddPropertyOverrides("d_zachariel_34", MonsterId.Shtayim, Properties("MHP", 69988, "MINPATK", 1401, "MAXPATK", 1624, "MINMATK", 1401, "MAXMATK", 1624, "DEF", 473, "MDEF", 473));
		AddPropertyOverrides("d_zachariel_34", MonsterId.Echad_Bow, Properties("MHP", 70870, "MINPATK", 1412, "MAXPATK", 1637, "MINMATK", 1412, "MAXMATK", 1637, "DEF", 486, "MDEF", 486));
		AddPropertyOverrides("d_zachariel_34", MonsterId.Wolf_Statue_Mage, Properties("MHP", 71766, "MINPATK", 1424, "MAXPATK", 1652, "MINMATK", 1424, "MAXMATK", 1652, "DEF", 500, "MDEF", 500));

		// Monster Spawners --------------------------------

		AddSpawner("d_zachariel_34.Id1", MonsterId.Echad, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_34.Id2", MonsterId.Wolf_Statue_Mage_Pollution, 8, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_34.Id3", MonsterId.Rootcrystal_05, 8, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);
		AddSpawner("d_zachariel_34.Id4", MonsterId.Shtayim, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_zachariel_34.Id5", MonsterId.Echad_Bow, 6, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_34.Id6", MonsterId.Wolf_Statue_Mage, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_34.Id7", MonsterId.Wolf_Statue_Mage, 4, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_34.Id8", MonsterId.Shtayim, 5, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_34.Id9", MonsterId.Echad_Bow, 5, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// Echad Spawn Points
		AddSpawnPoint( "d_zachariel_34.Id1", "d_zachariel_34", Spot(-1410.19, 222.08, 9999));

		// Wolf_Statue_Mage_Pollution Spawn Points
		AddSpawnPoint( "d_zachariel_34.Id2", "d_zachariel_34", Spot(1731.4242, 13.216862, 40));
		AddSpawnPoint( "d_zachariel_34.Id2", "d_zachariel_34", Spot(1584.2424, 234.63933, 40));
		AddSpawnPoint( "d_zachariel_34.Id2", "d_zachariel_34", Spot(1888.5475, -199.0652, 40));
		AddSpawnPoint( "d_zachariel_34.Id2", "d_zachariel_34", Spot(1551.9531, -245.45526, 40));
		AddSpawnPoint( "d_zachariel_34.Id2", "d_zachariel_34", Spot(1873.7476, 242.83102, 40));

		// Rootcrystal_05 Spawn Points
		AddSpawnPoint( "d_zachariel_34.Id3", "d_zachariel_34", Spot(-1313.72, 226.54, 9999));

		// Shtayim Spawn Points
		AddSpawnPoint( "d_zachariel_34.Id4", "d_zachariel_34", Spot(2410.06, -41.14, 35));
		AddSpawnPoint( "d_zachariel_34.Id4", "d_zachariel_34", Spot(-1506.2277, -994.005, 35));
		AddSpawnPoint( "d_zachariel_34.Id4", "d_zachariel_34", Spot(-1303.0852, -1002.7809, 35));
		AddSpawnPoint( "d_zachariel_34.Id4", "d_zachariel_34", Spot(-1351.6958, -1160.6857, 35));
		AddSpawnPoint( "d_zachariel_34.Id4", "d_zachariel_34", Spot(-1530.9678, -1166.0851, 35));
		AddSpawnPoint( "d_zachariel_34.Id4", "d_zachariel_34", Spot(-1460.0854, -770.4467, 35));
		AddSpawnPoint( "d_zachariel_34.Id4", "d_zachariel_34", Spot(-1437.3442, -515.7606, 35));
		AddSpawnPoint( "d_zachariel_34.Id4", "d_zachariel_34", Spot(-1486.463, -211.00175, 35));
		AddSpawnPoint( "d_zachariel_34.Id4", "d_zachariel_34", Spot(-1295.5459, 78.41142, 35));
		AddSpawnPoint( "d_zachariel_34.Id4", "d_zachariel_34", Spot(-1502.6569, 194.36934, 35));
		AddSpawnPoint( "d_zachariel_34.Id4", "d_zachariel_34", Spot(-1684.6388, 171.00551, 35));
		AddSpawnPoint( "d_zachariel_34.Id4", "d_zachariel_34", Spot(-1633.0569, 374.0038, 35));
		AddSpawnPoint( "d_zachariel_34.Id4", "d_zachariel_34", Spot(-1308.3997, 361.04623, 35));
		AddSpawnPoint( "d_zachariel_34.Id4", "d_zachariel_34", Spot(-2454.1536, 242.4562, 35));
		AddSpawnPoint( "d_zachariel_34.Id4", "d_zachariel_34", Spot(-2225.595, 50.454548, 35));
		AddSpawnPoint( "d_zachariel_34.Id4", "d_zachariel_34", Spot(-1965.253, 39.794415, 35));
		AddSpawnPoint( "d_zachariel_34.Id4", "d_zachariel_34", Spot(-2427.3127, 60.09922, 35));
		AddSpawnPoint( "d_zachariel_34.Id4", "d_zachariel_34", Spot(-1987.635, 234.6008, 35));
		AddSpawnPoint( "d_zachariel_34.Id4", "d_zachariel_34", Spot(-1410.697, 642.699, 35));
		AddSpawnPoint( "d_zachariel_34.Id4", "d_zachariel_34", Spot(-1316.0704, 770.7821, 35));
		AddSpawnPoint( "d_zachariel_34.Id4", "d_zachariel_34", Spot(-1279.7472, 840.6088, 35));
		AddSpawnPoint( "d_zachariel_34.Id4", "d_zachariel_34", Spot(-1149.1488, 1116.9481, 35));
		AddSpawnPoint( "d_zachariel_34.Id4", "d_zachariel_34", Spot(-1297.9415, 1126.1055, 35));
		AddSpawnPoint( "d_zachariel_34.Id4", "d_zachariel_34", Spot(-1122.7576, 1244.4468, 35));
		AddSpawnPoint( "d_zachariel_34.Id4", "d_zachariel_34", Spot(-973.07, 1160.559, 35));
		AddSpawnPoint( "d_zachariel_34.Id4", "d_zachariel_34", Spot(-743.99274, 1183.7483, 35));

		// Echad_Bow Spawn Points
		AddSpawnPoint( "d_zachariel_34.Id5", "d_zachariel_34", Spot(-372.96, 222.46, 35));
		AddSpawnPoint( "d_zachariel_34.Id5", "d_zachariel_34", Spot(-657.562, 221.8253, 35));
		AddSpawnPoint( "d_zachariel_34.Id5", "d_zachariel_34", Spot(-408.58313, -34.15838, 35));
		AddSpawnPoint( "d_zachariel_34.Id5", "d_zachariel_34", Spot(-356.41336, 82.1996, 35));
		AddSpawnPoint( "d_zachariel_34.Id5", "d_zachariel_34", Spot(-69.434814, 266.17285, 35));
		AddSpawnPoint( "d_zachariel_34.Id5", "d_zachariel_34", Spot(-303.67136, 420.74948, 35));
		AddSpawnPoint( "d_zachariel_34.Id5", "d_zachariel_34", Spot(-361.3153, 595.7237, 35));
		AddSpawnPoint( "d_zachariel_34.Id5", "d_zachariel_34", Spot(-387.39328, 891.8851, 35));
		AddSpawnPoint( "d_zachariel_34.Id5", "d_zachariel_34", Spot(-275.10748, 1042.5756, 35));
		AddSpawnPoint( "d_zachariel_34.Id5", "d_zachariel_34", Spot(-425.9195, 1170.9683, 35));
		AddSpawnPoint( "d_zachariel_34.Id5", "d_zachariel_34", Spot(-230.18755, 1222.9934, 35));
		AddSpawnPoint( "d_zachariel_34.Id5", "d_zachariel_34", Spot(298.0213, 204.39244, 35));
		AddSpawnPoint( "d_zachariel_34.Id5", "d_zachariel_34", Spot(-864.5439, 215.70552, 35));
		AddSpawnPoint( "d_zachariel_34.Id5", "d_zachariel_34", Spot(-499.33533, 195.19673, 35));
		AddSpawnPoint( "d_zachariel_34.Id5", "d_zachariel_34", Spot(-374.20178, 377.49335, 35));
		AddSpawnPoint( "d_zachariel_34.Id5", "d_zachariel_34", Spot(26.759571, 175.90543, 35));
		AddSpawnPoint( "d_zachariel_34.Id5", "d_zachariel_34", Spot(-94.441216, 1163.4843, 35));

		// Wolf_Statue_Mage Spawn Points
		AddSpawnPoint( "d_zachariel_34.Id6", "d_zachariel_34", Spot(-1826.34, 165.55, 30));
		AddSpawnPoint( "d_zachariel_34.Id6", "d_zachariel_34", Spot(-1313.3239, 180.23712, 30));
		AddSpawnPoint( "d_zachariel_34.Id6", "d_zachariel_34", Spot(-1516.5739, 279.9598, 30));
		AddSpawnPoint( "d_zachariel_34.Id6", "d_zachariel_34", Spot(-1484.6267, 30.557932, 30));
		AddSpawnPoint( "d_zachariel_34.Id6", "d_zachariel_34", Spot(-480.72433, 183.22766, 30));
		AddSpawnPoint( "d_zachariel_34.Id6", "d_zachariel_34", Spot(-322.51392, 74.59456, 30));
		AddSpawnPoint( "d_zachariel_34.Id6", "d_zachariel_34", Spot(-336.40793, 327.54364, 30));
		AddSpawnPoint( "d_zachariel_34.Id6", "d_zachariel_34", Spot(-177.30446, 199.6129, 30));
		AddSpawnPoint( "d_zachariel_34.Id6", "d_zachariel_34", Spot(-350.09555, 1057.4681, 30));
		AddSpawnPoint( "d_zachariel_34.Id6", "d_zachariel_34", Spot(-473.5601, 1187.6069, 30));
		AddSpawnPoint( "d_zachariel_34.Id6", "d_zachariel_34", Spot(-942.2454, 1146.1304, 30));
		AddSpawnPoint( "d_zachariel_34.Id6", "d_zachariel_34", Spot(-1118.6967, 1079.2073, 30));
		AddSpawnPoint( "d_zachariel_34.Id6", "d_zachariel_34", Spot(-1033.2698, 1209.2463, 30));
		AddSpawnPoint( "d_zachariel_34.Id6", "d_zachariel_34", Spot(-2765.0903, -13.663048, 30));
		AddSpawnPoint( "d_zachariel_34.Id6", "d_zachariel_34", Spot(-2692.3901, 124.33405, 30));
		AddSpawnPoint( "d_zachariel_34.Id6", "d_zachariel_34", Spot(-2749.8135, 287.90463, 30));
		AddSpawnPoint( "d_zachariel_34.Id6", "d_zachariel_34", Spot(-3039.4497, -30.177109, 30));
		AddSpawnPoint( "d_zachariel_34.Id6", "d_zachariel_34", Spot(-2793.5574, 160.07823, 30));
		AddSpawnPoint( "d_zachariel_34.Id6", "d_zachariel_34", Spot(-2223.2002, 194.56624, 30));
		AddSpawnPoint( "d_zachariel_34.Id6", "d_zachariel_34", Spot(-2389.6304, 182.76007, 30));
		AddSpawnPoint( "d_zachariel_34.Id6", "d_zachariel_34", Spot(-1953.7859, 245.42006, 30));
		AddSpawnPoint( "d_zachariel_34.Id6", "d_zachariel_34", Spot(-1553.1372, -1067.7112, 30));
		AddSpawnPoint( "d_zachariel_34.Id6", "d_zachariel_34", Spot(-1472.7915, -1154.2532, 30));
		AddSpawnPoint( "d_zachariel_34.Id6", "d_zachariel_34", Spot(-1383.03, -1092.8989, 30));
		AddSpawnPoint( "d_zachariel_34.Id6", "d_zachariel_34", Spot(-1385.5522, -988.75934, 30));
		AddSpawnPoint( "d_zachariel_34.Id6", "d_zachariel_34", Spot(-1482.9738, -995.6325, 30));
		AddSpawnPoint( "d_zachariel_34.Id6", "d_zachariel_34", Spot(-1363.0239, -1185.3455, 30));
		AddSpawnPoint( "d_zachariel_34.Id7", "d_zachariel_34", Spot(1709.48, -3.39, 350));
		AddSpawnPoint( "d_zachariel_34.Id7", "d_zachariel_34", Spot(1519.0261, -236.27713, 350));
		AddSpawnPoint( "d_zachariel_34.Id7", "d_zachariel_34", Spot(1891.5151, -229.82474, 350));
		AddSpawnPoint( "d_zachariel_34.Id7", "d_zachariel_34", Spot(1460.9353, 281.28485, 350));
		AddSpawnPoint( "d_zachariel_34.Id7", "d_zachariel_34", Spot(1807.4204, 302.09665, 350));
		AddSpawnPoint( "d_zachariel_34.Id7", "d_zachariel_34", Spot(1555.47, -15.196594, 350));

		// Shtayim Spawn Points
		AddSpawnPoint( "d_zachariel_34.Id8", "d_zachariel_34", Spot(1504.36, 219.48, 30));
		AddSpawnPoint( "d_zachariel_34.Id8", "d_zachariel_34", Spot(1734.43, 278.03, 30));
		AddSpawnPoint( "d_zachariel_34.Id8", "d_zachariel_34", Spot(1662.16, -54.4, 30));
		AddSpawnPoint( "d_zachariel_34.Id8", "d_zachariel_34", Spot(1554.56, -179.41, 30));
		AddSpawnPoint( "d_zachariel_34.Id8", "d_zachariel_34", Spot(1963.81, 75.98, 30));
		AddSpawnPoint( "d_zachariel_34.Id8", "d_zachariel_34", Spot(1901.17, -225.42, 30));
		AddSpawnPoint( "d_zachariel_34.Id8", "d_zachariel_34", Spot(1811.9, 29.52, 30));

		// Echad_Bow Spawn Points
		AddSpawnPoint( "d_zachariel_34.Id9", "d_zachariel_34", Spot(1252.1, 305.65, 30));
		AddSpawnPoint( "d_zachariel_34.Id9", "d_zachariel_34", Spot(1584.04, 244.86, 30));
		AddSpawnPoint( "d_zachariel_34.Id9", "d_zachariel_34", Spot(1823.27, 284.84, 30));
		AddSpawnPoint( "d_zachariel_34.Id9", "d_zachariel_34", Spot(1610.29, 51.95, 30));
		AddSpawnPoint( "d_zachariel_34.Id9", "d_zachariel_34", Spot(1954.29, 3.24, 30));
		AddSpawnPoint( "d_zachariel_34.Id9", "d_zachariel_34", Spot(1787.18, 126.86, 30));
		AddSpawnPoint( "d_zachariel_34.Id9", "d_zachariel_34", Spot(1620.31, -202.21, 30));
		AddSpawnPoint( "d_zachariel_34.Id9", "d_zachariel_34", Spot(1912.4539, -227.7814, 30));
		AddSpawnPoint( "d_zachariel_34.Id9", "d_zachariel_34", Spot(1742.18, 15.48, 30));

	}
}
