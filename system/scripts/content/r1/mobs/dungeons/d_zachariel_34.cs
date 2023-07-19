//--- Melia Script -----------------------------------------------------------
// d_zachariel_34
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Royal Mausoleum 3F' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DZachariel34MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_zachariel_34", MonsterId.Echad, Properties("MHP", 68268, "MINPATK", 1379, "MAXPATK", 1596, "MINMATK", 1379, "MAXMATK", 1596, "DEF", 446, "MDEF", 446));
		AddPropertyOverrides("d_zachariel_34", MonsterId.Wolf_Statue_Mage_Pollution, Properties("MHP", 69121, "MINPATK", 1390, "MAXPATK", 1610, "MINMATK", 1390, "MAXMATK", 1610, "DEF", 459, "MDEF", 459));
		AddPropertyOverrides("d_zachariel_34", MonsterId.Shtayim, Properties("MHP", 69988, "MINPATK", 1401, "MAXPATK", 1624, "MINMATK", 1401, "MAXMATK", 1624, "DEF", 473, "MDEF", 473));
		AddPropertyOverrides("d_zachariel_34", MonsterId.Echad_Bow, Properties("MHP", 70870, "MINPATK", 1412, "MAXPATK", 1637, "MINMATK", 1412, "MAXMATK", 1637, "DEF", 486, "MDEF", 486));
		AddPropertyOverrides("d_zachariel_34", MonsterId.Wolf_Statue_Mage, Properties("MHP", 71766, "MINPATK", 1424, "MAXPATK", 1652, "MINMATK", 1424, "MAXMATK", 1652, "DEF", 500, "MDEF", 500));
		AddPropertyOverrides("d_zachariel_34", MonsterId.Schlesien_Guard_NPC, Properties("MHP", 72677, "MINPATK", 1435, "MAXPATK", 1666, "MINMATK", 1435, "MAXMATK", 1666, "DEF", 514, "MDEF", 514));
		AddPropertyOverrides("d_zachariel_34", MonsterId.Boss_Denoptic_Q1, Properties("MHP", 357700, "MINPATK", 3126, "MAXPATK", 3630, "MINMATK", 3126, "MAXMATK", 3630, "DEF", 1140, "MDEF", 1140));

		// Monster Spawners ---------------------------------

		AddSpawner("d_zachariel_34.Id1", MonsterId.Echad, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_34.Id2", MonsterId.Wolf_Statue_Mage_Pollution, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_34.Id3", MonsterId.Rootcrystal_05, 6, 8, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);
		AddSpawner("d_zachariel_34.Id4", MonsterId.Shtayim, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_zachariel_34.Id5", MonsterId.Echad_Bow, 5, 6, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_34.Id6", MonsterId.Wolf_Statue_Mage, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_34.Id7", MonsterId.Wolf_Statue_Mage, 3, 4, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_34.Id8", MonsterId.Shtayim, 4, 5, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_34.Id9", MonsterId.Echad_Bow, 4, 5, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Echad' GenType 25 Spawn Points
		AddSpawnPoint("d_zachariel_34.Id1", "d_zachariel_34", Rectangle(-1410.19, 222.08, 9999));

		// 'Wolf_Statue_Mage_Pollution' GenType 27 Spawn Points
		AddSpawnPoint("d_zachariel_34.Id2", "d_zachariel_34", Rectangle(1731.4242, 13.216862, 40));
		AddSpawnPoint("d_zachariel_34.Id2", "d_zachariel_34", Rectangle(1584.2424, 234.63933, 40));
		AddSpawnPoint("d_zachariel_34.Id2", "d_zachariel_34", Rectangle(1888.5475, -199.0652, 40));
		AddSpawnPoint("d_zachariel_34.Id2", "d_zachariel_34", Rectangle(1551.9531, -245.45526, 40));
		AddSpawnPoint("d_zachariel_34.Id2", "d_zachariel_34", Rectangle(1873.7476, 242.83102, 40));

		// 'Rootcrystal_05' GenType 600 Spawn Points
		AddSpawnPoint("d_zachariel_34.Id3", "d_zachariel_34", Rectangle(-1313.72, 226.54, 9999));

		// 'Shtayim' GenType 603 Spawn Points
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(2410.06, -41.14, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1506.2277, -994.005, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1303.0852, -1002.7809, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1351.6958, -1160.6857, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1530.9678, -1166.0851, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1460.0854, -770.4467, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1437.3442, -515.7606, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1486.463, -211.00175, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1295.5459, 78.41142, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1502.6569, 194.36934, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1684.6388, 171.00551, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1633.0569, 374.0038, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1308.3997, 361.04623, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-2454.1536, 242.4562, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-2225.595, 50.454548, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1965.253, 39.794415, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-2427.3127, 60.09922, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1987.635, 234.6008, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1410.697, 642.699, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1316.0704, 770.7821, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1279.7472, 840.6088, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1149.1488, 1116.9481, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1297.9415, 1126.1055, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1122.7576, 1244.4468, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-973.07, 1160.559, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-743.99274, 1183.7483, 35));

		// 'Echad_Bow' GenType 3008 Spawn Points
		AddSpawnPoint("d_zachariel_34.Id5", "d_zachariel_34", Rectangle(-372.96, 222.46, 35));
		AddSpawnPoint("d_zachariel_34.Id5", "d_zachariel_34", Rectangle(-657.562, 221.8253, 35));
		AddSpawnPoint("d_zachariel_34.Id5", "d_zachariel_34", Rectangle(-408.58313, -34.15838, 35));
		AddSpawnPoint("d_zachariel_34.Id5", "d_zachariel_34", Rectangle(-356.41336, 82.1996, 35));
		AddSpawnPoint("d_zachariel_34.Id5", "d_zachariel_34", Rectangle(-69.434814, 266.17285, 35));
		AddSpawnPoint("d_zachariel_34.Id5", "d_zachariel_34", Rectangle(-303.67136, 420.74948, 35));
		AddSpawnPoint("d_zachariel_34.Id5", "d_zachariel_34", Rectangle(-361.3153, 595.7237, 35));
		AddSpawnPoint("d_zachariel_34.Id5", "d_zachariel_34", Rectangle(-387.39328, 891.8851, 35));
		AddSpawnPoint("d_zachariel_34.Id5", "d_zachariel_34", Rectangle(-275.10748, 1042.5756, 35));
		AddSpawnPoint("d_zachariel_34.Id5", "d_zachariel_34", Rectangle(-425.9195, 1170.9683, 35));
		AddSpawnPoint("d_zachariel_34.Id5", "d_zachariel_34", Rectangle(-230.18755, 1222.9934, 35));
		AddSpawnPoint("d_zachariel_34.Id5", "d_zachariel_34", Rectangle(298.0213, 204.39244, 35));
		AddSpawnPoint("d_zachariel_34.Id5", "d_zachariel_34", Rectangle(-864.5439, 215.70552, 35));
		AddSpawnPoint("d_zachariel_34.Id5", "d_zachariel_34", Rectangle(-499.33533, 195.19673, 35));
		AddSpawnPoint("d_zachariel_34.Id5", "d_zachariel_34", Rectangle(-374.20178, 377.49335, 35));
		AddSpawnPoint("d_zachariel_34.Id5", "d_zachariel_34", Rectangle(26.759571, 175.90543, 35));
		AddSpawnPoint("d_zachariel_34.Id5", "d_zachariel_34", Rectangle(-94.441216, 1163.4843, 35));

		// 'Wolf_Statue_Mage' GenType 3009 Spawn Points
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-1826.34, 165.55, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-1313.3239, 180.23712, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-1516.5739, 279.9598, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-1484.6267, 30.557932, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-480.72433, 183.22766, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-322.51392, 74.59456, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-336.40793, 327.54364, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-177.30446, 199.6129, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-350.09555, 1057.4681, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-473.5601, 1187.6069, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-942.2454, 1146.1304, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-1118.6967, 1079.2073, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-1033.2698, 1209.2463, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-2765.0903, -13.663048, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-2692.3901, 124.33405, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-2749.8135, 287.90463, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-3039.4497, -30.177109, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-2793.5574, 160.07823, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-2223.2002, 194.56624, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-2389.6304, 182.76007, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-1953.7859, 245.42006, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-1553.1372, -1067.7112, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-1472.7915, -1154.2532, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-1383.03, -1092.8989, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-1385.5522, -988.75934, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-1482.9738, -995.6325, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-1363.0239, -1185.3455, 30));

		// 'Wolf_Statue_Mage' GenType 3010 Spawn Points
		AddSpawnPoint("d_zachariel_34.Id7", "d_zachariel_34", Rectangle(1709.48, -3.39, 350));
		AddSpawnPoint("d_zachariel_34.Id7", "d_zachariel_34", Rectangle(1519.0261, -236.27713, 350));
		AddSpawnPoint("d_zachariel_34.Id7", "d_zachariel_34", Rectangle(1891.5151, -229.82474, 350));
		AddSpawnPoint("d_zachariel_34.Id7", "d_zachariel_34", Rectangle(1460.9353, 281.28485, 350));
		AddSpawnPoint("d_zachariel_34.Id7", "d_zachariel_34", Rectangle(1807.4204, 302.09665, 350));
		AddSpawnPoint("d_zachariel_34.Id7", "d_zachariel_34", Rectangle(1555.47, -15.196594, 350));

		// 'Shtayim' GenType 3023 Spawn Points
		AddSpawnPoint("d_zachariel_34.Id8", "d_zachariel_34", Rectangle(1504.36, 219.48, 30));
		AddSpawnPoint("d_zachariel_34.Id8", "d_zachariel_34", Rectangle(1734.43, 278.03, 30));
		AddSpawnPoint("d_zachariel_34.Id8", "d_zachariel_34", Rectangle(1662.16, -54.4, 30));
		AddSpawnPoint("d_zachariel_34.Id8", "d_zachariel_34", Rectangle(1554.56, -179.41, 30));
		AddSpawnPoint("d_zachariel_34.Id8", "d_zachariel_34", Rectangle(1963.81, 75.98, 30));
		AddSpawnPoint("d_zachariel_34.Id8", "d_zachariel_34", Rectangle(1901.17, -225.42, 30));
		AddSpawnPoint("d_zachariel_34.Id8", "d_zachariel_34", Rectangle(1811.9, 29.52, 30));

		// 'Echad_Bow' GenType 3024 Spawn Points
		AddSpawnPoint("d_zachariel_34.Id9", "d_zachariel_34", Rectangle(1252.1, 305.65, 30));
		AddSpawnPoint("d_zachariel_34.Id9", "d_zachariel_34", Rectangle(1584.04, 244.86, 30));
		AddSpawnPoint("d_zachariel_34.Id9", "d_zachariel_34", Rectangle(1823.27, 284.84, 30));
		AddSpawnPoint("d_zachariel_34.Id9", "d_zachariel_34", Rectangle(1610.29, 51.95, 30));
		AddSpawnPoint("d_zachariel_34.Id9", "d_zachariel_34", Rectangle(1954.29, 3.24, 30));
		AddSpawnPoint("d_zachariel_34.Id9", "d_zachariel_34", Rectangle(1787.18, 126.86, 30));
		AddSpawnPoint("d_zachariel_34.Id9", "d_zachariel_34", Rectangle(1620.31, -202.21, 30));
		AddSpawnPoint("d_zachariel_34.Id9", "d_zachariel_34", Rectangle(1912.4539, -227.7814, 30));
		AddSpawnPoint("d_zachariel_34.Id9", "d_zachariel_34", Rectangle(1742.18, 15.48, 30));
	}
}
