//--- Melia Script -----------------------------------------------------------
// f_castle_93
//
//--- Description -----------------------------------------------------------
// Sets up the f_castle_93 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FCastle93MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_castle_93", MonsterId.Banterer, Properties("MHP", 697667, "MINPATK", 9472, "MAXPATK", 11544, "MINMATK", 9472, "MAXMATK", 11544, "DEF", 189463, "MDEF", 189463));
		AddPropertyOverrides("f_castle_93", MonsterId.Spider, Properties("MHP", 693671, "MINPATK", 9421, "MAXPATK", 11481, "MINMATK", 9421, "MAXMATK", 11481, "DEF", 186607, "MDEF", 186607));
		AddPropertyOverrides("f_castle_93", MonsterId.Hooter, Properties("MHP", 695642, "MINPATK", 9446, "MAXPATK", 11512, "MINMATK", 9446, "MAXMATK", 11512, "DEF", 188016, "MDEF", 188016));

		// Monster Spawners --------------------------------

		AddSpawner("f_castle_93.Id1", MonsterId.Banterer, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_castle_93.Id2", MonsterId.Spider, 50, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_castle_93.Id3", MonsterId.Hooter, 100, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// Banterer Spawn Points
		AddSpawnPoint( "f_castle_93.Id1", "f_castle_93", Spot(-2168.9238, -1571.2385, 60));
		AddSpawnPoint( "f_castle_93.Id1", "f_castle_93", Spot(-1983.0244, -1711.2645, 60));
		AddSpawnPoint( "f_castle_93.Id1", "f_castle_93", Spot(-1944.8834, -1418.8828, 60));
		AddSpawnPoint( "f_castle_93.Id1", "f_castle_93", Spot(-1494.0156, -1697.9514, 60));
		AddSpawnPoint( "f_castle_93.Id1", "f_castle_93", Spot(-1260.6718, -1471.0087, 60));
		AddSpawnPoint( "f_castle_93.Id1", "f_castle_93", Spot(-722.61285, -1072.8448, 60));
		AddSpawnPoint( "f_castle_93.Id1", "f_castle_93", Spot(-1486.5676, -228.57703, 60));
		AddSpawnPoint( "f_castle_93.Id1", "f_castle_93", Spot(-1214.3989, -478.57245, 60));
		AddSpawnPoint( "f_castle_93.Id1", "f_castle_93", Spot(-2126.556, -426.1159, 60));
		AddSpawnPoint( "f_castle_93.Id1", "f_castle_93", Spot(-2400.8655, -225.8224, 60));
		AddSpawnPoint( "f_castle_93.Id1", "f_castle_93", Spot(-2761.0195, -284.71222, 60));
		AddSpawnPoint( "f_castle_93.Id1", "f_castle_93", Spot(-2232.0002, 112.38893, 60));
		AddSpawnPoint( "f_castle_93.Id1", "f_castle_93", Spot(-1225.254, 841.4055, 60));
		AddSpawnPoint( "f_castle_93.Id1", "f_castle_93", Spot(-1052.1602, 937.97845, 60));
		AddSpawnPoint( "f_castle_93.Id1", "f_castle_93", Spot(-1378.4731, 1070.6383, 60));
		AddSpawnPoint( "f_castle_93.Id1", "f_castle_93", Spot(-1768.6056, 1270.3301, 60));
		AddSpawnPoint( "f_castle_93.Id1", "f_castle_93", Spot(-1548.8761, 1040.4279, 60));
		AddSpawnPoint( "f_castle_93.Id1", "f_castle_93", Spot(-781.8887, 392.044, 60));
		AddSpawnPoint( "f_castle_93.Id1", "f_castle_93", Spot(-1771.3123, 929.88416, 60));
		AddSpawnPoint( "f_castle_93.Id1", "f_castle_93", Spot(-1054.2988, 118.22012, 60));

		// Spider Spawn Points
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-702.5753, 423.32202, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-745.97345, 469.68573, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-567.0557, 598.4505, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-235.35301, 837.6184, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-179.08942, 817.6138, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-21.315918, 815.39606, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-1477.5446, -361.99448, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-1590.981, -172.36769, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-1453.3905, -126.92783, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-1360.023, -311.1108, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-1399.7373, -504.4792, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-1140.8972, -338.4548, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-1087.5555, -509.4938, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-1097.2977, -39.44257, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-1005.3003, -273.95697, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-1076.6747, -1123.9122, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-1108.7559, -944.127, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-1035.8231, -765.56885, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-799.3798, -290.05493, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-520.94934, -299.58408, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-34.178608, -446.724, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-175.32944, -375.84207, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-73.76561, -205.17627, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-30.208164, -1284.0289, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-177.42307, -1165.7283, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(6.444537, -1162.9814, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-349.52588, -1065.3539, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-640.1264, -1132.399, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-671.6316, -970.4311, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-778.85205, -1147.4011, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-1038.5963, 353.73547, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-1097.1356, 539.08746, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-386.6252, 726.54755, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-1084.9016, -1676.5765, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-1288.5632, -1732.0613, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-1085.2218, -1471.5051, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-1208.6412, -1587.9924, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-1462.5852, -1450.1112, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-1857.831, -1359.9706, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-1811.5624, -1544.8672, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-1941.5126, -1565.9196, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-1784.467, -1679.3104, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-1416.56, -1669.5739, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-1093.3748, 768.50726, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-1043.2637, 647.4555, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(59.458126, -1204.1238, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-87.78617, -1105.4678, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(22.01464, -402.5009, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(13.295532, -182.78682, 20));
		AddSpawnPoint( "f_castle_93.Id2", "f_castle_93", Spot(-156.20589, -275.7878, 20));

		// Hooter Spawn Points
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-2167.9543, -1626.706, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-2178.2495, -1514.6648, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-2143.9785, -1768.1853, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-2048.7217, -1806.7034, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-2026.9135, -1579.3517, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-2101.8604, -1446.4203, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-2005.4686, -1316.3903, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-2128.4717, -1340.5592, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1775.2635, -1785.4978, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1885.4513, -1680.4779, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1706.3295, -1594.7893, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1748.0919, -1379.2167, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1572.6536, -1469.075, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1564.2935, -1557.8049, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1561.7235, -1801.8953, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1350.5266, -1788.492, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1089.7, -1797.7848, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1203.5465, -1823.2366, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1222.6595, -1623.6967, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1067.6759, -1559.3174, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1237.7793, -1339.5803, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1375.9543, -1361.5359, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(77.044075, -1287.4077, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-100.43918, -1246.4696, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-239.05603, -1084.9686, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-62.66726, -1161.8424, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-610.0485, -1059.9163, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-751.20355, -987.4589, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1064.7896, -1267.1929, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1262.1292, -212.5623, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-25.980549, -507.77405, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-129.36371, -499.5843, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-72.3979, -322.1423, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-163.53656, -205.7181, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-278.8304, -283.223, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-426.7243, -286.13626, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-876.54395, -298.5097, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1030.4738, 293.41415, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1126.1473, 496.06366, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1015.7523, 598.4193, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1885.1772, -260.07715, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1952.8771, -471.36295, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-2078.1946, -279.053, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-2066.486, -489.11304, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-2196.7236, -330.27716, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-2275.7688, -519.65216, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-2318.3276, -415.67868, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-2504.7954, -385.15323, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-2484.4495, -514.2243, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-2570.3677, -524.6906, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-2580.3403, -204.76299, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-2484.5012, -108.98826, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-2155.227, -55.828922, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1950.4578, -187.08304, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1962.0546, -34.14676, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1886.8947, -33.565876, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-2246.5083, -196.3002, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-2002.1344, 80.249664, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-2322.0186, -297.77063, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-2140.1626, 128.48698, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-2340.533, 74.76847, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-2425.3936, -291.1514, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-2499.7483, 150.65399, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-2689.8804, 104.21789, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-2775.381, -15.324036, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-2739.6382, -168.45071, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-2515.4426, -20.721642, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-2775.2173, -467.25488, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-2723.6912, -397.84314, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1044.9436, 1023.7717, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1099.8662, 996.2801, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1258.2803, 746.0633, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1198.8995, 754.13794, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1225.1716, 1119.924, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1145.458, 1254.4089, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1416.9412, 1250.8535, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1370.013, 1220.8645, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1401.655, 976.01587, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1503.6487, 821.2849, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1447.9207, 793.89777, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1722.9244, 835.6921, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1874.9216, 838.5481, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1865.1022, 958.9088, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1824.6807, 918.91797, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1649.9105, 936.51666, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1606.4005, 914.26465, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1665.2997, 1180.6213, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1612.9515, 1153.9191, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1685.3734, 1280.624, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1729.8049, 1219.9343, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1859.3085, 1246.5131, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1761.3615, 1154.1549, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1854.9849, 1314.6411, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1804.7576, 1082.4604, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1510.6282, 1263.2268, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1123.9087, -164.26855, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-704.6303, 370.07474, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-808.83276, 483.35028, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1198.8861, 1002.9008, 20));
		AddSpawnPoint( "f_castle_93.Id3", "f_castle_93", Spot(-1346.967, 946.7094, 20));

	}
}
