//--- Melia Script -----------------------------------------------------------
// f_tableland_73
//
//--- Description -----------------------------------------------------------
// Sets up the f_tableland_73 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FTableland73MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_tableland_73", MonsterId.Wendigo_Archer_Gray, Properties("MHP", 395071, "MINPATK", 5581, "MAXPATK", 6761, "MINMATK", 5581, "MAXMATK", 6761, "DEF", 43182, "MDEF", 43182));
		AddPropertyOverrides("f_tableland_73", MonsterId.Tiny_Bow_Blue, Properties("MHP", 396463, "MINPATK", 5599, "MAXPATK", 6783, "MINMATK", 5599, "MAXMATK", 6783, "DEF", 43625, "MDEF", 43625));
		AddPropertyOverrides("f_tableland_73", MonsterId.Hohen_Gulak_Blue, Properties("MHP", 398003, "MINPATK", 5619, "MAXPATK", 6808, "MINMATK", 5619, "MAXMATK", 6808, "DEF", 44116, "MDEF", 44116));

		// Monster Spawners --------------------------------

		AddSpawner("f_tableland_73.Id1", MonsterId.Wendigo_Archer_Gray, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_tableland_73.Id2", MonsterId.Tiny_Bow_Blue, 60, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_tableland_73.Id3", MonsterId.Hohen_Gulak_Blue, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_tableland_73.Id4", MonsterId.Rootcrystal_03, 25, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_tableland_73.Id5", MonsterId.Tiny_Bow_Blue, 5, TimeSpan.FromMilliseconds(40000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Wendigo_Archer_Gray Spawn Points
		AddSpawnPoint( "f_tableland_73.Id1", "f_tableland_73", Spot(1163.4784, -182.88493, 30));
		AddSpawnPoint( "f_tableland_73.Id1", "f_tableland_73", Spot(928.6006, -243.35081, 30));
		AddSpawnPoint( "f_tableland_73.Id1", "f_tableland_73", Spot(342.18597, 13.519333, 30));
		AddSpawnPoint( "f_tableland_73.Id1", "f_tableland_73", Spot(-123.74695, 153.67111, 30));
		AddSpawnPoint( "f_tableland_73.Id1", "f_tableland_73", Spot(-358.56937, 578.68823, 30));
		AddSpawnPoint( "f_tableland_73.Id1", "f_tableland_73", Spot(-1407.4718, -388.0772, 30));
		AddSpawnPoint( "f_tableland_73.Id1", "f_tableland_73", Spot(-1155.983, -288.20752, 30));
		AddSpawnPoint( "f_tableland_73.Id1", "f_tableland_73", Spot(-845.28436, -208.10414, 30));
		AddSpawnPoint( "f_tableland_73.Id1", "f_tableland_73", Spot(-735.8999, -664.49066, 30));
		AddSpawnPoint( "f_tableland_73.Id1", "f_tableland_73", Spot(-842.95135, -987.0322, 30));
		AddSpawnPoint( "f_tableland_73.Id1", "f_tableland_73", Spot(-852.0322, -1228.0957, 30));
		AddSpawnPoint( "f_tableland_73.Id1", "f_tableland_73", Spot(320.11462, -1360.9601, 30));
		AddSpawnPoint( "f_tableland_73.Id1", "f_tableland_73", Spot(392.13074, -1162.2239, 30));
		AddSpawnPoint( "f_tableland_73.Id1", "f_tableland_73", Spot(115.39487, -1147.7969, 30));
		AddSpawnPoint( "f_tableland_73.Id1", "f_tableland_73", Spot(116.15191, -731.9041, 30));
		AddSpawnPoint( "f_tableland_73.Id1", "f_tableland_73", Spot(41.65725, -461.88965, 30));
		AddSpawnPoint( "f_tableland_73.Id1", "f_tableland_73", Spot(1445.792, 196.88799, 30));
		AddSpawnPoint( "f_tableland_73.Id1", "f_tableland_73", Spot(1277.6085, 758.2844, 30));
		AddSpawnPoint( "f_tableland_73.Id1", "f_tableland_73", Spot(1005.0402, 507.35504, 30));
		AddSpawnPoint( "f_tableland_73.Id1", "f_tableland_73", Spot(897.1247, 783.9432, 30));
		AddSpawnPoint( "f_tableland_73.Id1", "f_tableland_73", Spot(738.3719, 512.37286, 30));
		AddSpawnPoint( "f_tableland_73.Id1", "f_tableland_73", Spot(238.1584, 706.6896, 30));
		AddSpawnPoint( "f_tableland_73.Id1", "f_tableland_73", Spot(327.38937, 975.2203, 30));
		AddSpawnPoint( "f_tableland_73.Id1", "f_tableland_73", Spot(514.5646, 946.92993, 30));
		AddSpawnPoint( "f_tableland_73.Id1", "f_tableland_73", Spot(150.72432, 846.2317, 30));
		AddSpawnPoint( "f_tableland_73.Id1", "f_tableland_73", Spot(-606.05194, 670.39685, 30));
		AddSpawnPoint( "f_tableland_73.Id1", "f_tableland_73", Spot(540.0649, 251.62274, 30));
		AddSpawnPoint( "f_tableland_73.Id1", "f_tableland_73", Spot(243.61453, 178.42168, 30));
		AddSpawnPoint( "f_tableland_73.Id1", "f_tableland_73", Spot(848.8988, -90.6376, 30));
		AddSpawnPoint( "f_tableland_73.Id1", "f_tableland_73", Spot(1079.4073, 53.64847, 30));
		AddSpawnPoint( "f_tableland_73.Id1", "f_tableland_73", Spot(1376.2535, 495.07367, 30));

		// Tiny_Bow_Blue Spawn Points
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(-93.8185, -616.8168, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(395.53577, -158.56929, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(-83.050446, 168.8258, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(-370.2242, 462.78644, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(-296.45804, 690.9464, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(-603.13434, 643.4405, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(-948.6117, -202.84702, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(-815.28033, -490.60233, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(-700.8174, -803.1997, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(-983.5505, -1055.0701, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(-779.56976, -1261.7667, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(-788.01227, -871.9064, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(-1473.8568, -461.7625, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(-1581.1962, -216.88553, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(-1099.941, -312.58844, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(371.01773, 156.65945, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(1143.7173, 38.528328, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(1392.123, 192.46638, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(1265.8118, 770.9482, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(738.3198, 626.93097, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(738.3198, 626.93097, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(867.9205, 1106.2473, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(496.05017, 926.829, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(324.86896, 1046.3729, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(204.44301, 729.84753, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(72.74461, -420.32312, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(239.46613, -363.23282, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(-39.078266, -168.79593, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(256.18237, -47.93696, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(1203.5034, 522.3592, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(1057.262, 814.36914, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(1248.0502, 1046.3259, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(1074.405, 1081.2909, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(1179.2024, 1275.1313, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(1337.7429, 1264.6107, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(1222.5603, 1165.9438, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(1404.4727, 1063.3693, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(873.3629, 461.6254, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(974.2046, 662.562, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(1002.7637, -220.99193, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(1340.3027, -185.56343, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(1320.813, -36.97234, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(830.5028, -172.75891, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(1168.7888, -264.36703, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(1089.8843, -113.29924, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(-738.3482, -315.44138, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(-229.51923, 367.1068, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(-488.5821, -295.0084, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(82.6364, -600.4984, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(153.41081, -1018.5123, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(151.23474, -1197.4962, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(187.03049, -1314.5503, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(396.79855, -1321.8971, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(315.24872, -1192.1868, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(244.25813, -1054.4012, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(-956.1859, -1261.2274, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(-833.93036, -1180.6764, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(-1643.5795, -384.11212, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(-1369.0258, -323.46103, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(-1461.6086, -320.64273, 30));
		AddSpawnPoint( "f_tableland_73.Id2", "f_tableland_73", Spot(-851.85187, -337.9791, 30));

		// Hohen_Gulak_Blue Spawn Points
		AddSpawnPoint( "f_tableland_73.Id3", "f_tableland_73", Spot(250.82367, -1192.5671, 30));
		AddSpawnPoint( "f_tableland_73.Id3", "f_tableland_73", Spot(143.32529, -459.65582, 30));
		AddSpawnPoint( "f_tableland_73.Id3", "f_tableland_73", Spot(-1500.2622, -357.2382, 30));
		AddSpawnPoint( "f_tableland_73.Id3", "f_tableland_73", Spot(-886.8115, -1163.4266, 30));
		AddSpawnPoint( "f_tableland_73.Id3", "f_tableland_73", Spot(-744.3014, -328.9267, 30));
		AddSpawnPoint( "f_tableland_73.Id3", "f_tableland_73", Spot(-354.9857, 567.95953, 30));
		AddSpawnPoint( "f_tableland_73.Id3", "f_tableland_73", Spot(1052.9849, -233.98682, 30));
		AddSpawnPoint( "f_tableland_73.Id3", "f_tableland_73", Spot(1207.7087, 618.1361, 30));
		AddSpawnPoint( "f_tableland_73.Id3", "f_tableland_73", Spot(293.5898, 61.041237, 30));
		AddSpawnPoint( "f_tableland_73.Id3", "f_tableland_73", Spot(-804.09094, -890.1731, 30));
		AddSpawnPoint( "f_tableland_73.Id3", "f_tableland_73", Spot(-823.9658, -874.8289, 30));
		AddSpawnPoint( "f_tableland_73.Id3", "f_tableland_73", Spot(-180.99243, 299.05786, 30));
		AddSpawnPoint( "f_tableland_73.Id3", "f_tableland_73", Spot(297.08636, 890.16254, 30));

		// Rootcrystal_03 Spawn Points
		AddSpawnPoint( "f_tableland_73.Id4", "f_tableland_73", Spot(1235.0723, -1296.2388, 40));
		AddSpawnPoint( "f_tableland_73.Id4", "f_tableland_73", Spot(926.5205, -1280.2971, 40));
		AddSpawnPoint( "f_tableland_73.Id4", "f_tableland_73", Spot(600.3348, -1315.2461, 40));
		AddSpawnPoint( "f_tableland_73.Id4", "f_tableland_73", Spot(262.4656, -1227.0198, 40));
		AddSpawnPoint( "f_tableland_73.Id4", "f_tableland_73", Spot(146.74762, -782.0784, 40));
		AddSpawnPoint( "f_tableland_73.Id4", "f_tableland_73", Spot(168.88066, -399.19882, 40));
		AddSpawnPoint( "f_tableland_73.Id4", "f_tableland_73", Spot(-151.30313, -139.95921, 40));
		AddSpawnPoint( "f_tableland_73.Id4", "f_tableland_73", Spot(441.63892, -176.19316, 40));
		AddSpawnPoint( "f_tableland_73.Id4", "f_tableland_73", Spot(307.12592, 181.50967, 40));
		AddSpawnPoint( "f_tableland_73.Id4", "f_tableland_73", Spot(-496.28326, -365.66583, 40));
		AddSpawnPoint( "f_tableland_73.Id4", "f_tableland_73", Spot(-896.1836, -1191.1588, 40));
		AddSpawnPoint( "f_tableland_73.Id4", "f_tableland_73", Spot(-754.3007, -928.5487, 40));
		AddSpawnPoint( "f_tableland_73.Id4", "f_tableland_73", Spot(-803.3622, -457.11026, 40));
		AddSpawnPoint( "f_tableland_73.Id4", "f_tableland_73", Spot(-1065.789, -214.73181, 40));
		AddSpawnPoint( "f_tableland_73.Id4", "f_tableland_73", Spot(-1494.3949, -301.6688, 40));
		AddSpawnPoint( "f_tableland_73.Id4", "f_tableland_73", Spot(-1515.3748, -525.1985, 40));
		AddSpawnPoint( "f_tableland_73.Id4", "f_tableland_73", Spot(-124.32533, 301.26617, 40));
		AddSpawnPoint( "f_tableland_73.Id4", "f_tableland_73", Spot(-357.93146, 506.05655, 40));
		AddSpawnPoint( "f_tableland_73.Id4", "f_tableland_73", Spot(-533.2109, 743.6689, 40));
		AddSpawnPoint( "f_tableland_73.Id4", "f_tableland_73", Spot(-98.95297, 759.8958, 40));
		AddSpawnPoint( "f_tableland_73.Id4", "f_tableland_73", Spot(241.71632, 711.0537, 40));
		AddSpawnPoint( "f_tableland_73.Id4", "f_tableland_73", Spot(417.11356, 933.5137, 40));
		AddSpawnPoint( "f_tableland_73.Id4", "f_tableland_73", Spot(721.5085, 982.0627, 40));
		AddSpawnPoint( "f_tableland_73.Id4", "f_tableland_73", Spot(1052.4088, 1124.7577, 40));
		AddSpawnPoint( "f_tableland_73.Id4", "f_tableland_73", Spot(1358.4172, 1423.2029, 40));
		AddSpawnPoint( "f_tableland_73.Id4", "f_tableland_73", Spot(1313.617, 1059.3925, 40));
		AddSpawnPoint( "f_tableland_73.Id4", "f_tableland_73", Spot(884.02026, 480.51288, 40));
		AddSpawnPoint( "f_tableland_73.Id4", "f_tableland_73", Spot(915.3694, -240.15167, 40));
		AddSpawnPoint( "f_tableland_73.Id4", "f_tableland_73", Spot(1278.1122, -195.1915, 40));
		AddSpawnPoint( "f_tableland_73.Id4", "f_tableland_73", Spot(1320.5112, 88.68729, 40));
		AddSpawnPoint( "f_tableland_73.Id4", "f_tableland_73", Spot(1399.6953, 537.6924, 40));
		AddSpawnPoint( "f_tableland_73.Id4", "f_tableland_73", Spot(1204.531, 700.62146, 40));

		// Tiny_Bow_Blue Spawn Points
		AddSpawnPoint( "f_tableland_73.Id5", "f_tableland_73", Spot(-683.771, -1131.1244, 40));
		AddSpawnPoint( "f_tableland_73.Id5", "f_tableland_73", Spot(-911.2254, -895.73596, 40));
		AddSpawnPoint( "f_tableland_73.Id5", "f_tableland_73", Spot(-794.8904, -1302.6974, 40));
		AddSpawnPoint( "f_tableland_73.Id5", "f_tableland_73", Spot(-970.8607, -1302.9135, 40));
		AddSpawnPoint( "f_tableland_73.Id5", "f_tableland_73", Spot(-1004.7429, -1104.2147, 40));

	}
}
