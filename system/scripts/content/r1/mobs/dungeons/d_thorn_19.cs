//--- Melia Script -----------------------------------------------------------
// d_thorn_19
//
//--- Description -----------------------------------------------------------
// Sets up the d_thorn_19 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DThorn19MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("d_thorn_19", MonsterId.Thornball, Properties("MHP", 38767, "MINPATK", 999, "MAXPATK", 1130, "MINMATK", 999, "MAXMATK", 1130, "DEF", 185, "MDEF", 185));
		AddPropertyOverrides("d_thorn_19", MonsterId.Whip_Vine, Properties("MHP", 39519, "MINPATK", 1009, "MAXPATK", 1142, "MINMATK", 1009, "MAXMATK", 1142, "DEF", 186, "MDEF", 186));
		AddPropertyOverrides("d_thorn_19", MonsterId.Operor, Properties("MHP", 40287, "MINPATK", 1019, "MAXPATK", 1154, "MINMATK", 1019, "MAXMATK", 1154, "DEF", 187, "MDEF", 187));
		AddPropertyOverrides("d_thorn_19", MonsterId.Truffle, Properties("MHP", 41070, "MINPATK", 1029, "MAXPATK", 1167, "MINMATK", 1029, "MAXMATK", 1167, "DEF", 188, "MDEF", 188));
		AddPropertyOverrides("d_thorn_19", MonsterId.Velwriggler, Properties("MHP", 41868, "MINPATK", 1039, "MAXPATK", 1179, "MINMATK", 1039, "MAXMATK", 1179, "DEF", 189, "MDEF", 189));

		// Monster Spawners --------------------------------

		AddSpawner("d_thorn_19.Id1", MonsterId.Rootcrystal_01, 23, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("d_thorn_19.Id2", MonsterId.Thornball, 22, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_19.Id3", MonsterId.Whip_Vine, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_19.Id4", MonsterId.Operor, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_19.Id5", MonsterId.Operor, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_19.Id6", MonsterId.Whip_Vine, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_19.Id7", MonsterId.Truffle, 55, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_19.Id8", MonsterId.Velwriggler, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_19.Id9", MonsterId.Operor, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_19.Id10", MonsterId.Velwriggler, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_19.Id11", MonsterId.Thornball, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_19.Id12", MonsterId.Whip_Vine, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(7, -3309, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(-156, -3328, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(-140, -3163, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(704, -3313, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(834, -3272, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(-973.5, -3090.4, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(-917.73, -3343.49, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(-173, -2241, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(-278, -2072, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(-341, -2387, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(-168, -2111, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(-1065, -2404, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(-1208, -2424, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(282, -1342, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(191, -1184, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(35, -1170, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(9, -1301, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(139, -1010, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(-580, -757, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(-820, -1313, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(-720, -1461, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(-778, -721, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(339, -23, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(277, 309, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(-44, 255, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(-615, 221, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(120, 1111, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(1011, 948, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(1226, 899, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(749, 2334, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(671, 2660, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(557, 2830, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(851, 2439, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(1716, 2622, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(1974, 1722, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(2128, 1677, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(2085, 1514, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(2040, 751, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(2226, 648, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(1979.8, -669.72, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(2436.71, -521.63, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(2014, 1607, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(1549, 2568, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(502, 2576, 200));
		AddSpawnPoint( "d_thorn_19.Id1", "d_thorn_19", Spot(209, 868, 200));

		// Thornball Spawn Points
		AddSpawnPoint( "d_thorn_19.Id2", "d_thorn_19", Spot(625.86, 2674.12, 9999));
		AddSpawnPoint( "d_thorn_19.Id2", "d_thorn_19", Spot(705.363, 2756.9622, 9999));
		AddSpawnPoint( "d_thorn_19.Id2", "d_thorn_19", Spot(593.2873, 2739.8062, 9999));
		AddSpawnPoint( "d_thorn_19.Id2", "d_thorn_19", Spot(547.6222, 2607.3857, 9999));
		AddSpawnPoint( "d_thorn_19.Id2", "d_thorn_19", Spot(610.07825, 2559.1177, 9999));
		AddSpawnPoint( "d_thorn_19.Id2", "d_thorn_19", Spot(758.4143, 2607.0928, 9999));
		AddSpawnPoint( "d_thorn_19.Id2", "d_thorn_19", Spot(-0.26996803, -3455.7874, 9999));
		AddSpawnPoint( "d_thorn_19.Id2", "d_thorn_19", Spot(-182.0214, -3311.262, 9999));
		AddSpawnPoint( "d_thorn_19.Id2", "d_thorn_19", Spot(-315.9939, -3323.4792, 9999));
		AddSpawnPoint( "d_thorn_19.Id2", "d_thorn_19", Spot(-116.40758, -3166.3743, 9999));
		AddSpawnPoint( "d_thorn_19.Id2", "d_thorn_19", Spot(4.840996, -3353.6772, 9999));

		// Whip_Vine Spawn Points
		AddSpawnPoint( "d_thorn_19.Id3", "d_thorn_19", Spot(1098.81, 957.08, 9999));

		// Operor Spawn Points
		AddSpawnPoint( "d_thorn_19.Id4", "d_thorn_19", Spot(54.27, -1141.97, 9999));
		AddSpawnPoint( "d_thorn_19.Id5", "d_thorn_19", Spot(-244.07, -2174.57, 35));
		AddSpawnPoint( "d_thorn_19.Id5", "d_thorn_19", Spot(-742.06, -1379.91, 35));
		AddSpawnPoint( "d_thorn_19.Id5", "d_thorn_19", Spot(153.29, -1204.56, 35));
		AddSpawnPoint( "d_thorn_19.Id5", "d_thorn_19", Spot(-389.33948, -2398.3306, 35));
		AddSpawnPoint( "d_thorn_19.Id5", "d_thorn_19", Spot(-425.72403, -2217.6736, 35));
		AddSpawnPoint( "d_thorn_19.Id5", "d_thorn_19", Spot(-169.9382, -2017.4631, 35));
		AddSpawnPoint( "d_thorn_19.Id5", "d_thorn_19", Spot(-42.995285, -2215.8296, 35));
		AddSpawnPoint( "d_thorn_19.Id5", "d_thorn_19", Spot(-159.73878, -2361.9932, 35));
		AddSpawnPoint( "d_thorn_19.Id5", "d_thorn_19", Spot(-383.49716, -2019.7106, 35));
		AddSpawnPoint( "d_thorn_19.Id5", "d_thorn_19", Spot(-915.1706, -1373.2583, 35));
		AddSpawnPoint( "d_thorn_19.Id5", "d_thorn_19", Spot(-759.0877, -1219.2446, 35));
		AddSpawnPoint( "d_thorn_19.Id5", "d_thorn_19", Spot(-816.4433, -700.5906, 35));
		AddSpawnPoint( "d_thorn_19.Id5", "d_thorn_19", Spot(-587.9877, -699.45337, 35));
		AddSpawnPoint( "d_thorn_19.Id5", "d_thorn_19", Spot(-640.73096, -826.7517, 35));
		AddSpawnPoint( "d_thorn_19.Id5", "d_thorn_19", Spot(-624.904, -1528.9884, 35));
		AddSpawnPoint( "d_thorn_19.Id5", "d_thorn_19", Spot(-4.334385, -1075.3212, 35));
		AddSpawnPoint( "d_thorn_19.Id5", "d_thorn_19", Spot(185.3392, -996.6654, 35));
		AddSpawnPoint( "d_thorn_19.Id5", "d_thorn_19", Spot(15.368589, -1285.2125, 35));
		AddSpawnPoint( "d_thorn_19.Id5", "d_thorn_19", Spot(181.1179, -1420.2231, 35));
		AddSpawnPoint( "d_thorn_19.Id5", "d_thorn_19", Spot(373.49728, -1278.2023, 35));

		// Whip_Vine Spawn Points
		AddSpawnPoint( "d_thorn_19.Id6", "d_thorn_19", Spot(-765.97, -1366.2, 25));
		AddSpawnPoint( "d_thorn_19.Id6", "d_thorn_19", Spot(195.99, -31.05, 25));
		AddSpawnPoint( "d_thorn_19.Id6", "d_thorn_19", Spot(-650.53, -801.63, 25));
		AddSpawnPoint( "d_thorn_19.Id6", "d_thorn_19", Spot(-1131.04, -2401.94, 25));
		AddSpawnPoint( "d_thorn_19.Id6", "d_thorn_19", Spot(-1250.0166, -2479.555, 25));
		AddSpawnPoint( "d_thorn_19.Id6", "d_thorn_19", Spot(-1131.7104, -2246.3633, 25));
		AddSpawnPoint( "d_thorn_19.Id6", "d_thorn_19", Spot(-1340.8723, -2348.8599, 25));
		AddSpawnPoint( "d_thorn_19.Id6", "d_thorn_19", Spot(-945.25476, -2428.139, 25));
		AddSpawnPoint( "d_thorn_19.Id6", "d_thorn_19", Spot(-923.9556, -1431.2599, 25));
		AddSpawnPoint( "d_thorn_19.Id6", "d_thorn_19", Spot(-732.6844, -1193.1901, 25));
		AddSpawnPoint( "d_thorn_19.Id6", "d_thorn_19", Spot(-736.0745, -1493.0305, 25));
		AddSpawnPoint( "d_thorn_19.Id6", "d_thorn_19", Spot(-481.60358, -1416.2626, 25));
		AddSpawnPoint( "d_thorn_19.Id6", "d_thorn_19", Spot(-447.70416, -1374.1199, 25));
		AddSpawnPoint( "d_thorn_19.Id6", "d_thorn_19", Spot(-415.9294, -1408.4124, 25));
		AddSpawnPoint( "d_thorn_19.Id6", "d_thorn_19", Spot(-387.21863, -1376.4923, 25));
		AddSpawnPoint( "d_thorn_19.Id6", "d_thorn_19", Spot(-587.83044, -644.1202, 25));
		AddSpawnPoint( "d_thorn_19.Id6", "d_thorn_19", Spot(-827.07916, -694.807, 25));
		AddSpawnPoint( "d_thorn_19.Id6", "d_thorn_19", Spot(-828.2747, -872.73346, 25));
		AddSpawnPoint( "d_thorn_19.Id6", "d_thorn_19", Spot(-493.16745, -1383.1842, 25));
		AddSpawnPoint( "d_thorn_19.Id6", "d_thorn_19", Spot(-808.8824, -2377.7505, 25));
		AddSpawnPoint( "d_thorn_19.Id6", "d_thorn_19", Spot(-812.42004, -2325.7876, 25));
		AddSpawnPoint( "d_thorn_19.Id6", "d_thorn_19", Spot(-775.9139, -2323.4856, 25));
		AddSpawnPoint( "d_thorn_19.Id6", "d_thorn_19", Spot(-778.71436, -2353.1108, 25));
		AddSpawnPoint( "d_thorn_19.Id6", "d_thorn_19", Spot(-757.7221, -2367.5344, 25));

		// Truffle Spawn Points
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(1090.15, 967.63, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(2124.34, 636.58, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(896.922, 806.87994, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(874.07227, 984.3921, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(1123.265, 1115.7177, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(1328.5697, 986.494, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(1279.0974, 853.0962, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(1084.9094, 783.7246, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(972.7847, 1125.9738, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(1961.1929, 732.7646, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(2152.674, 894.4854, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(2340.999, 708.8717, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(2094.6848, 772.65607, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(1947.8993, 606.6924, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(73.42799, -3177.4363, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(16.262268, -3358.3242, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(-68.96349, -3243.4875, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(72.969734, -3448.3318, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(-90.76881, -3482.504, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(-200.07736, -3274.4832, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(873.70593, -3305.6782, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(770.7329, -3321.637, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(740.9391, -3229.6172, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(984.6085, -3234.854, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(640.2802, -3337.8838, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(-335.9962, -2139.6147, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(-285.44443, -1963.3956, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(-117.23212, -2143.2947, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(-157.32593, -2228.0552, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(-456.15686, -2338.87, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(63.10528, -1434.7233, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(-55.62503, -1235.0024, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(311.01566, -1158.5029, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(227.03166, -1332.4866, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(113.43088, -996.3331, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(-812.20404, -787.5698, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(-718.3193, -725.77057, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(-649.9351, -628.3492, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(-535.41754, -788.44836, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(-866.7217, -705.0731, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(-506.5897, 190.41866, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(-634.7118, 145.00764, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(-764.4742, 192.92746, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(-734.2927, 296.97458, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(-484.90854, 319.1134, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(208.7208, -99.1525, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(115.4332, -34.506065, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(300.8455, -14.377932, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(372.55487, 35.73336, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(169.86627, -182.7142, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(1005.659, 909.4215, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(1013.8374, 1007.66, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(1136.9797, 1041.5024, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(1236.1095, 985.27203, 35));
		AddSpawnPoint( "d_thorn_19.Id7", "d_thorn_19", Spot(1116.7516, 862.0753, 35));

		// Velwriggler Spawn Points
		AddSpawnPoint( "d_thorn_19.Id8", "d_thorn_19", Spot(-640.29, 231.66, 9999));

		// Operor Spawn Points
		AddSpawnPoint( "d_thorn_19.Id9", "d_thorn_19", Spot(1659.8623, 2629.5647, 30));
		AddSpawnPoint( "d_thorn_19.Id9", "d_thorn_19", Spot(1487.9377, 2504.1301, 30));
		AddSpawnPoint( "d_thorn_19.Id9", "d_thorn_19", Spot(1488.3577, 2648.821, 30));
		AddSpawnPoint( "d_thorn_19.Id9", "d_thorn_19", Spot(1639.49, 2501.67, 30));
		AddSpawnPoint( "d_thorn_19.Id9", "d_thorn_19", Spot(1767.5109, 2714.5422, 30));
		AddSpawnPoint( "d_thorn_19.Id9", "d_thorn_19", Spot(1837.6666, 2563.0588, 30));
		AddSpawnPoint( "d_thorn_19.Id9", "d_thorn_19", Spot(1881.526, 2632.33, 30));
		AddSpawnPoint( "d_thorn_19.Id9", "d_thorn_19", Spot(1769.5431, 2457.3489, 30));
		AddSpawnPoint( "d_thorn_19.Id9", "d_thorn_19", Spot(1935.8546, 2383.894, 30));
		AddSpawnPoint( "d_thorn_19.Id9", "d_thorn_19", Spot(1318.5092, 2460.0247, 30));

		// Velwriggler Spawn Points
		AddSpawnPoint( "d_thorn_19.Id10", "d_thorn_19", Spot(-725.75, -808.72, 30));
		AddSpawnPoint( "d_thorn_19.Id10", "d_thorn_19", Spot(-555.55, -695.24, 30));
		AddSpawnPoint( "d_thorn_19.Id10", "d_thorn_19", Spot(-682.87, -1517.89, 30));
		AddSpawnPoint( "d_thorn_19.Id10", "d_thorn_19", Spot(-381.47, -1410.73, 30));
		AddSpawnPoint( "d_thorn_19.Id10", "d_thorn_19", Spot(-103.7, -1392.68, 30));
		AddSpawnPoint( "d_thorn_19.Id10", "d_thorn_19", Spot(-14.93, -1171.65, 30));
		AddSpawnPoint( "d_thorn_19.Id10", "d_thorn_19", Spot(208.62, -1020.65, 30));
		AddSpawnPoint( "d_thorn_19.Id10", "d_thorn_19", Spot(331.46112, -1272.5803, 30));
		AddSpawnPoint( "d_thorn_19.Id10", "d_thorn_19", Spot(164.28, -1424.87, 30));
		AddSpawnPoint( "d_thorn_19.Id10", "d_thorn_19", Spot(-933.33, -1349.65, 30));
		AddSpawnPoint( "d_thorn_19.Id10", "d_thorn_19", Spot(-190.77, -895.1, 30));
		AddSpawnPoint( "d_thorn_19.Id10", "d_thorn_19", Spot(-715.97, -1217.1, 30));
		AddSpawnPoint( "d_thorn_19.Id10", "d_thorn_19", Spot(159.71, -1207.66, 30));

		// Thornball Spawn Points
		AddSpawnPoint( "d_thorn_19.Id11", "d_thorn_19", Spot(77.95, -3487.9, 25));
		AddSpawnPoint( "d_thorn_19.Id11", "d_thorn_19", Spot(-110.22, -3415.88, 25));
		AddSpawnPoint( "d_thorn_19.Id11", "d_thorn_19", Spot(-204.09248, -3081.0413, 25));
		AddSpawnPoint( "d_thorn_19.Id11", "d_thorn_19", Spot(64.79, -3308.32, 25));
		AddSpawnPoint( "d_thorn_19.Id11", "d_thorn_19", Spot(-72.18, -3054.03, 25));
		AddSpawnPoint( "d_thorn_19.Id11", "d_thorn_19", Spot(586.03796, -3362.4517, 25));
		AddSpawnPoint( "d_thorn_19.Id11", "d_thorn_19", Spot(695.4383, -3252.3284, 25));
		AddSpawnPoint( "d_thorn_19.Id11", "d_thorn_19", Spot(794.78894, -3343.3992, 25));
		AddSpawnPoint( "d_thorn_19.Id11", "d_thorn_19", Spot(812.10406, -3172.4854, 25));
		AddSpawnPoint( "d_thorn_19.Id11", "d_thorn_19", Spot(901.3883, -3262.7783, 25));
		AddSpawnPoint( "d_thorn_19.Id11", "d_thorn_19", Spot(-85.02385, -3276.9644, 25));

		// Whip_Vine Spawn Points
		AddSpawnPoint( "d_thorn_19.Id12", "d_thorn_19", Spot(-38.96623, -3430.5603, 20));
		AddSpawnPoint( "d_thorn_19.Id12", "d_thorn_19", Spot(-205.15486, -3121.6902, 20));
		AddSpawnPoint( "d_thorn_19.Id12", "d_thorn_19", Spot(-243.76686, -3340.58, 20));
		AddSpawnPoint( "d_thorn_19.Id12", "d_thorn_19", Spot(-73.95137, -3277.5017, 20));
		AddSpawnPoint( "d_thorn_19.Id12", "d_thorn_19", Spot(-87.825584, -3045.6045, 20));
		AddSpawnPoint( "d_thorn_19.Id12", "d_thorn_19", Spot(150.48, -3447.13, 20));
		AddSpawnPoint( "d_thorn_19.Id12", "d_thorn_19", Spot(-377.3848, -2313.1633, 20));
		AddSpawnPoint( "d_thorn_19.Id12", "d_thorn_19", Spot(-275.73972, -2152.4043, 20));
		AddSpawnPoint( "d_thorn_19.Id12", "d_thorn_19", Spot(-142.44463, -2303.968, 20));
		AddSpawnPoint( "d_thorn_19.Id12", "d_thorn_19", Spot(-386.55634, -2030.44, 20));
		AddSpawnPoint( "d_thorn_19.Id12", "d_thorn_19", Spot(-261.05087, -1854.5465, 20));
		AddSpawnPoint( "d_thorn_19.Id12", "d_thorn_19", Spot(-519.9419, -2145.0254, 20));
		AddSpawnPoint( "d_thorn_19.Id12", "d_thorn_19", Spot(-560.7696, -2238.4016, 20));
		AddSpawnPoint( "d_thorn_19.Id12", "d_thorn_19", Spot(-576.9147, -2302.619, 20));
		AddSpawnPoint( "d_thorn_19.Id12", "d_thorn_19", Spot(-531.3616, -2266.5178, 20));

	}
}
