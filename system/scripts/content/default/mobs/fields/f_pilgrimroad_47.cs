//--- Melia Script -----------------------------------------------------------
// f_pilgrimroad_47
//
//--- Description -----------------------------------------------------------
// Sets up the f_pilgrimroad_47 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FPilgrimroad47MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_pilgrimroad_47", MonsterId.Triffid, Properties("MHP", 127109, "MINPATK", 2136, "MAXPATK", 2527, "MINMATK", 2136, "MAXMATK", 2527, "DEF", 2113, "MDEF", 2113));
		AddPropertyOverrides("f_pilgrimroad_47", MonsterId.Rondo_Red, Properties("MHP", 127931, "MINPATK", 2146, "MAXPATK", 2540, "MINMATK", 2146, "MAXMATK", 2540, "DEF", 2161, "MDEF", 2161));
		AddPropertyOverrides("f_pilgrimroad_47", MonsterId.Rubabos_Red, Properties("MHP", 128840, "MINPATK", 2158, "MAXPATK", 2554, "MINMATK", 2158, "MAXMATK", 2554, "DEF", 2213, "MDEF", 2213));

		// Monster Spawners --------------------------------

		AddSpawner("f_pilgrimroad_47.Id1", MonsterId.Triffid, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_47.Id2", MonsterId.Rondo_Red, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_47.Id3", MonsterId.Rubabos_Red, 4, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_47.Id4", MonsterId.Rondo_Red, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_47.Id5", MonsterId.Rootcrystal_01, 5, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_47.Id6", MonsterId.Spell_Crystal_Red, 11, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_47.Id7", MonsterId.Triffid, 80, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Triffid Spawn Points
		AddSpawnPoint( "f_pilgrimroad_47.Id1", "f_pilgrimroad_47", Spot(-993.22205, 797.5809, 25));
		AddSpawnPoint( "f_pilgrimroad_47.Id1", "f_pilgrimroad_47", Spot(-1335.8525, 819.8556, 25));
		AddSpawnPoint( "f_pilgrimroad_47.Id1", "f_pilgrimroad_47", Spot(-1297.5165, 1080.1176, 25));
		AddSpawnPoint( "f_pilgrimroad_47.Id1", "f_pilgrimroad_47", Spot(-1309.4578, 1277.4132, 25));
		AddSpawnPoint( "f_pilgrimroad_47.Id1", "f_pilgrimroad_47", Spot(-906.7752, 643.5886, 25));
		AddSpawnPoint( "f_pilgrimroad_47.Id1", "f_pilgrimroad_47", Spot(-663.1742, 991.91956, 25));
		AddSpawnPoint( "f_pilgrimroad_47.Id1", "f_pilgrimroad_47", Spot(-803.4108, 1261.2639, 25));

		// Rondo_Red Spawn Points
		AddSpawnPoint( "f_pilgrimroad_47.Id2", "f_pilgrimroad_47", Spot(95.46165, 54.307987, 9999));

		// Rubabos_Red Spawn Points
		AddSpawnPoint( "f_pilgrimroad_47.Id3", "f_pilgrimroad_47", Spot(1569.9491, 620.31085, 9999));

		// Rondo_Red Spawn Points
		AddSpawnPoint( "f_pilgrimroad_47.Id4", "f_pilgrimroad_47", Spot(-929.8583, -1038.2302, 30));
		AddSpawnPoint( "f_pilgrimroad_47.Id4", "f_pilgrimroad_47", Spot(-1136.2964, -1135.5636, 30));
		AddSpawnPoint( "f_pilgrimroad_47.Id4", "f_pilgrimroad_47", Spot(-1184.5596, -1333.0535, 30));
		AddSpawnPoint( "f_pilgrimroad_47.Id4", "f_pilgrimroad_47", Spot(-904.50073, -1387.0244, 30));
		AddSpawnPoint( "f_pilgrimroad_47.Id4", "f_pilgrimroad_47", Spot(-880.82715, -1209.2832, 30));
		AddSpawnPoint( "f_pilgrimroad_47.Id4", "f_pilgrimroad_47", Spot(-689.5831, -1323.8121, 30));
		AddSpawnPoint( "f_pilgrimroad_47.Id4", "f_pilgrimroad_47", Spot(-704.29034, -1103.3995, 30));
		AddSpawnPoint( "f_pilgrimroad_47.Id4", "f_pilgrimroad_47", Spot(-518.8737, -1162.603, 30));
		AddSpawnPoint( "f_pilgrimroad_47.Id4", "f_pilgrimroad_47", Spot(-793.6922, -866.6572, 30));
		AddSpawnPoint( "f_pilgrimroad_47.Id4", "f_pilgrimroad_47", Spot(-1159.8259, -857.16046, 30));

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "f_pilgrimroad_47.Id5", "f_pilgrimroad_47", Spot(-923.9958, -1081.3728, 30));
		AddSpawnPoint( "f_pilgrimroad_47.Id5", "f_pilgrimroad_47", Spot(-1025.2979, 831.3281, 30));
		AddSpawnPoint( "f_pilgrimroad_47.Id5", "f_pilgrimroad_47", Spot(1179.419, -351.31213, 30));
		AddSpawnPoint( "f_pilgrimroad_47.Id5", "f_pilgrimroad_47", Spot(1055.3466, 735.7617, 30));

		// Spell_Crystal_Red Spawn Points
		AddSpawnPoint( "f_pilgrimroad_47.Id6", "f_pilgrimroad_47", Spot(-81.73174, -353.93387, 100));
		AddSpawnPoint( "f_pilgrimroad_47.Id6", "f_pilgrimroad_47", Spot(150.66302, -459.1197, 100));
		AddSpawnPoint( "f_pilgrimroad_47.Id6", "f_pilgrimroad_47", Spot(392.18652, -388.74722, 100));
		AddSpawnPoint( "f_pilgrimroad_47.Id6", "f_pilgrimroad_47", Spot(142.34164, -142.55185, 100));
		AddSpawnPoint( "f_pilgrimroad_47.Id6", "f_pilgrimroad_47", Spot(40.967354, 134.16083, 100));
		AddSpawnPoint( "f_pilgrimroad_47.Id6", "f_pilgrimroad_47", Spot(526.1345, -31.353481, 100));
		AddSpawnPoint( "f_pilgrimroad_47.Id6", "f_pilgrimroad_47", Spot(-534.3976, -1107.3347, 100));
		AddSpawnPoint( "f_pilgrimroad_47.Id6", "f_pilgrimroad_47", Spot(-732.2151, -1343.1632, 100));
		AddSpawnPoint( "f_pilgrimroad_47.Id6", "f_pilgrimroad_47", Spot(-1085.7466, -1330.1377, 100));
		AddSpawnPoint( "f_pilgrimroad_47.Id6", "f_pilgrimroad_47", Spot(-1110.0631, -955.3534, 100));
		AddSpawnPoint( "f_pilgrimroad_47.Id6", "f_pilgrimroad_47", Spot(-913.0569, -1482.1694, 100));
		AddSpawnPoint( "f_pilgrimroad_47.Id6", "f_pilgrimroad_47", Spot(-809.6678, -1053.415, 100));

		// Triffid Spawn Points
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1453.9553, -523.38, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-2235.0815, -1915.6633, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-2267.7786, -1681.9446, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-1718.4299, -1852.5532, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-1596.7614, -1641.3052, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1681.4183, -892.22363, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1775.2803, -835.8659, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1571.4395, -752.6495, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1473.3514, -746.72833, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1368.8231, -365.68106, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1490.6685, -373.50327, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1577.9142, -414.52484, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(2004.1879, -648.4358, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1734.6858, -538.41425, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1556.4521, -644.9351, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1303.7917, -642.4044, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1666.9929, -279.78247, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1758.2136, -333.5231, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1836.4061, -462.57193, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1515.1239, -889.9115, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1764.6787, -678.2335, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1641.443, -524.1389, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1525.2827, -1023.995, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1385.6388, -930.43646, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1277.4797, -817.1956, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1102.3652, -590.0458, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1040.2336, -725.37317, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1003.1176, -444.0992, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1339.814, -422.7393, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1608.6256, 261.68408, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1801.7301, 358.29013, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1269.8627, 753.78906, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1306.0223, 549.3754, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1534.3146, 518.7446, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1473.9459, 341.42783, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1100.5146, 551.8766, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1082.6997, 739.5625, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1718.4812, 472.82016, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1711.935, 643.70776, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1673.3695, 717.1651, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1130.0354, 880.31726, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1392.6692, 980.1902, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1848.4027, 1014.0248, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1931.464, 761.5128, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(1916.8647, 571.80035, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-102.06326, -241.55438, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(391.2242, -168.00502, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(278.54135, -361.86038, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(359.3034, -384.05597, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(427.98126, -281.81958, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(524.36615, -86.01566, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(448.73032, 44.013115, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(296.32425, -10.106264, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(189.16576, 133.05753, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(41.51322, 111.23775, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-14.935679, -38.244072, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-233.46278, -467.84082, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-58.22924, -448.2109, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-239.74335, -186.05109, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-241.91753, -97.09184, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(268.0868, -275.4146, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(173.99889, -388.44025, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-135.48036, 104.04691, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-532.96295, -1217.1277, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-609.6405, -1284.997, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-819.444, -1422.3438, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-749.272, -1111.2755, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-808.54065, -1215.0474, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-1064.2756, -1228.3334, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-1232.6819, -1179.1086, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-948.9469, -1000.9554, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-1031.5996, -1425.2803, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-1123.8745, -1384.68, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-970.15674, -1114.7965, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-1312.407, -1077.383, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-872.037, -1270.5242, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-755.5957, -961.4767, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-835.1573, -1053.987, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-724.0934, -1267.4055, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-585.4649, -1153.1342, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-655.7479, -1173.3427, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-960.72644, -1313.9242, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-820.7061, -854.9645, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-856.23584, -942.85925, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-1196.3419, -947.90985, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-1168.9131, -889.3779, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-1041.5204, -905.20526, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-1054.4185, -836.2489, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-703.7789, -1385.1595, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-2099.9995, -1960.5972, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-2235.3276, -2081.9177, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-2340.9172, -1870.8628, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-1990.8551, -1766.4154, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-1906.3159, -1911.9639, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-1985.3236, -1955.4492, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-1724.9695, -1749.4087, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-2055.4656, -1673.225, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-2017.3901, -1460.3307, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-1949.7174, -1504.5996, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-1899.684, -1609.6233, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-2125.2073, -1822.1622, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-1837.3915, -1714.5065, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-1641.9154, -1785.7079, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-1676.2975, -1658.2692, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-1719.4645, -1521.9219, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-2182.6382, -1558.9598, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-1310.9452, 1222.383, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-1103.4064, 1351.8605, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-954.40326, 1251.0399, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-833.7744, 1231.1017, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-817.8532, 1107.8226, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-1236.3179, 1197.997, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-1138.1986, 1074.1315, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-1301.6648, 725.80566, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-1380.0868, 792.1632, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-1402.0759, 900.7865, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-1403.5078, 1044.448, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-595.42377, 868.96313, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-833.54205, 962.63727, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-746.2355, 1013.0491, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-951.11896, 688.6968, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-867.60815, 613.3172, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-983.75134, 599.40656, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-1089.7936, 595.9544, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-1086.7845, 874.12646, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-1129.8475, 719.35895, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-646.57666, 770.6949, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-734.57733, 650.3282, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-935.1351, 835.57574, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-1087.1298, 1259.0302, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-973.2561, 1045.5287, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-999.00275, 964.5369, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-985.0917, 1142.1908, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-851.94867, 1367.7195, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-744.1483, 1327.005, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-673.59357, 1252.9037, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-674.7269, 1100.3584, 20));
		AddSpawnPoint( "f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Spot(-792.8947, 835.8843, 20));

	}
}
