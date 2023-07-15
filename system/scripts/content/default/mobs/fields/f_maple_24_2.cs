//--- Melia Script -----------------------------------------------------------
// f_maple_24_2
//
//--- Description -----------------------------------------------------------
// Sets up the f_maple_24_2 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FMaple242MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_maple_24_2", MonsterId.Banterer_Red, Properties("MHP", 741917, "MINPATK", 10041, "MAXPATK", 12244, "MINMATK", 10041, "MAXMATK", 12244, "DEF", 221087, "MDEF", 221087));
		AddPropertyOverrides("f_maple_24_2", MonsterId.Fragolin, Properties("MHP", 744761, "MINPATK", 10078, "MAXPATK", 12288, "MINMATK", 10078, "MAXMATK", 12288, "DEF", 223120, "MDEF", 223120));
		AddPropertyOverrides("f_maple_24_2", MonsterId.Rafflet, Properties("MHP", 747642, "MINPATK", 10115, "MAXPATK", 12334, "MINMATK", 10115, "MAXMATK", 12334, "DEF", 225179, "MDEF", 225179));

		// Monster Spawners --------------------------------

		AddSpawner("f_maple_24_2.Id1", MonsterId.Banterer_Red, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_24_2.Id2", MonsterId.Fragolin, 63, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_24_2.Id3", MonsterId.Rafflet, 61, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_24_2.Id4", MonsterId.Rootcrystal_01, 25, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Banterer_Red Spawn Points
		AddSpawnPoint( "f_maple_24_2.Id1", "f_maple_24_2", Spot(-1311.8519, -604.7043, 20));
		AddSpawnPoint( "f_maple_24_2.Id1", "f_maple_24_2", Spot(-1172.3433, -455.3393, 20));
		AddSpawnPoint( "f_maple_24_2.Id1", "f_maple_24_2", Spot(-1033.9703, -520.4022, 20));
		AddSpawnPoint( "f_maple_24_2.Id1", "f_maple_24_2", Spot(-1258.6681, -683.04663, 20));
		AddSpawnPoint( "f_maple_24_2.Id1", "f_maple_24_2", Spot(-1128.466, -751.3775, 20));
		AddSpawnPoint( "f_maple_24_2.Id1", "f_maple_24_2", Spot(-1033.7189, -385.72195, 20));
		AddSpawnPoint( "f_maple_24_2.Id1", "f_maple_24_2", Spot(-1098.203, -660.9934, 20));
		AddSpawnPoint( "f_maple_24_2.Id1", "f_maple_24_2", Spot(-488.34833, 740.30615, 20));
		AddSpawnPoint( "f_maple_24_2.Id1", "f_maple_24_2", Spot(-605.105, 687.68427, 20));
		AddSpawnPoint( "f_maple_24_2.Id1", "f_maple_24_2", Spot(-1197.9812, -599.7309, 20));
		AddSpawnPoint( "f_maple_24_2.Id1", "f_maple_24_2", Spot(-735.26636, 580.7025, 20));
		AddSpawnPoint( "f_maple_24_2.Id1", "f_maple_24_2", Spot(-762.48315, 744.5281, 20));
		AddSpawnPoint( "f_maple_24_2.Id1", "f_maple_24_2", Spot(-595.0213, 798.2501, 20));
		AddSpawnPoint( "f_maple_24_2.Id1", "f_maple_24_2", Spot(-546.37335, 547.15985, 20));
		AddSpawnPoint( "f_maple_24_2.Id1", "f_maple_24_2", Spot(-296.60846, 516.826, 20));
		AddSpawnPoint( "f_maple_24_2.Id1", "f_maple_24_2", Spot(852.2642, 148.70364, 20));
		AddSpawnPoint( "f_maple_24_2.Id1", "f_maple_24_2", Spot(930.2193, 1.3881302, 20));
		AddSpawnPoint( "f_maple_24_2.Id1", "f_maple_24_2", Spot(1031.3729, 50.803856, 20));
		AddSpawnPoint( "f_maple_24_2.Id1", "f_maple_24_2", Spot(893.9032, 70.365685, 20));
		AddSpawnPoint( "f_maple_24_2.Id1", "f_maple_24_2", Spot(1247.6566, -20.249443, 20));
		AddSpawnPoint( "f_maple_24_2.Id1", "f_maple_24_2", Spot(1279.8574, -73.82186, 20));
		AddSpawnPoint( "f_maple_24_2.Id1", "f_maple_24_2", Spot(1389.6271, 2.3235168, 20));
		AddSpawnPoint( "f_maple_24_2.Id1", "f_maple_24_2", Spot(1282.9113, 53.104206, 20));
		AddSpawnPoint( "f_maple_24_2.Id1", "f_maple_24_2", Spot(1356.4198, -51.76607, 20));
		AddSpawnPoint( "f_maple_24_2.Id1", "f_maple_24_2", Spot(1358.8054, -136.0525, 20));
		AddSpawnPoint( "f_maple_24_2.Id1", "f_maple_24_2", Spot(749.5421, 160.84158, 20));
		AddSpawnPoint( "f_maple_24_2.Id1", "f_maple_24_2", Spot(833.8569, 40.89791, 20));
		AddSpawnPoint( "f_maple_24_2.Id1", "f_maple_24_2", Spot(2.2841244, 338.29776, 20));
		AddSpawnPoint( "f_maple_24_2.Id1", "f_maple_24_2", Spot(-43.762936, 374.13638, 20));
		AddSpawnPoint( "f_maple_24_2.Id1", "f_maple_24_2", Spot(-233.90039, 349.3111, 20));
		AddSpawnPoint( "f_maple_24_2.Id1", "f_maple_24_2", Spot(-1105.0121, -558.762, 20));

		// Fragolin Spawn Points
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-454.5814, -712.86707, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-428.6585, -543.06714, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-660.7199, -1218.3391, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-617.8937, -1148.7844, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-700.37225, -1099.6052, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-558.8886, -1103.4622, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-687.4985, -996.3567, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-561.43726, -1035.2063, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-558.7021, -920.89374, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-530.2837, -874.63226, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-127.0519, -558.91156, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-120.55074, -494.42953, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-244.28998, -325.5061, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-297.76422, -470.06058, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-353.078, -366.96817, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-6.619302, -180.91734, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-27.743565, -30.282316, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(39.9232, -262.94437, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(125.36388, -120.70267, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-701.32574, 166.48831, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-748.13074, 99.83436, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-710.74316, 28.374132, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-762.77734, 180.86826, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-630.5783, 29.823307, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-561.94946, 17.154964, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-546.71094, 100.96535, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-524.7343, 210.12514, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(43.207245, -364.89505, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(308.05453, 272.7758, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-785.0062, 658.43835, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-623.10236, 706.0377, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-663.92554, 640.7249, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-502.87122, 618.4452, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-636.7272, 790.4163, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-572.62354, 617.791, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(270.15686, 30.75036, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(315.13834, 138.54245, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(352.87872, 285.7373, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(206.54962, 252.18388, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(431.2288, 380.20428, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(506.0219, 263.0915, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(125.59403, 701.08295, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(68.9147, 733.4372, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(206.10649, 748.6488, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(208.16724, 819.6845, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(283.2365, 767.05457, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(152.92189, 907.9003, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(109.47688, 825.05164, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(77.850624, 902.4076, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-319.72073, 548.70074, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-276.31445, 473.8888, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-113.73526, 358.86365, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-13.955542, 349.29263, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-875.216, -398.53345, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-842.9264, -366.6169, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-639.0239, -415.11853, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-620.1499, -385.38974, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-376.43802, 133.92392, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-325.10883, 135.90854, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-159.7612, 71.49199, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(-132.5802, 32.802933, 20));
		AddSpawnPoint( "f_maple_24_2.Id2", "f_maple_24_2", Spot(521.7761, 117.75137, 20));

		// Rafflet Spawn Points
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(953.5677, 660.20465, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(935.4066, 772.3773, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(1033.4613, 793.8222, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(865.8473, 685.3317, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(794.7419, 629.9081, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(1123.4658, 830.3436, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(1182.9521, 881.6256, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(1107.6399, 964.36957, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(1200.4011, 943.2817, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(1043.1676, 833.44794, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(386.89655, -1487.709, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(-68.37912, -626.66174, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(444.67767, -1411.3125, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(352.6458, -1266.9851, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(485.13702, -1301.4584, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(399.55365, -1204.8864, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(343.62634, -1347.5635, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(250.03133, -1275.4762, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(279.60452, -1180.9692, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(86.17734, -913.94824, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(174.28459, -1113.5887, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(100.90375, -1022.3088, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(43.77997, -1076.5319, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(282.947, -991.2814, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(23.031708, -794.0475, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(-15.776642, -725.41797, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(165.92528, -917.3155, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(-108.10435, -192.44946, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(-101.0706, -82.83334, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(-91.5796, -416.8248, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(-227.17744, -424.6594, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(120.38548, -253.31409, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(333.64294, -353.585, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(392.45148, -470.5354, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(551.80695, -451.59717, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(449.9234, -382.75482, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(756.33154, -420.612, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(498.6639, -291.4665, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(503.9968, -532.1094, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(642.73676, -561.2325, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(673.5922, -489.4274, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(657.9175, -367.92462, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(1103.6838, -597.72546, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(1136.8527, -639.7197, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(1176.2306, -597.8297, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(1134.5332, -536.7494, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(1095.9332, -702.7611, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(1034.693, -756.6255, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(1175.2314, -688.0843, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(1158.4242, -762.6951, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(1237.7225, -712.59863, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(1198.7688, -797.3417, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(1008.743, -586.05096, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(-190.43274, -241.75044, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(174.09781, -329.7792, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(41.531372, -73.08949, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(119.47517, 1.7617531, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(220.69289, -158.29659, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(233.61073, -45.497505, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(358.03296, -16.639734, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(405.21048, 165.84296, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(424.11542, 262.5457, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(516.2009, 310.854, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(537.89844, 202.54385, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(549.5144, 371.005, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(571.5525, 262.27448, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(369.74686, 383.72238, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(630.2137, 367.44348, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(808.1689, 472.51898, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(682.85315, 512.8183, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(624.4213, 524.25024, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(892.859, 415.09567, 20));
		AddSpawnPoint( "f_maple_24_2.Id3", "f_maple_24_2", Spot(1255.8274, 900.9964, 20));

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "f_maple_24_2.Id4", "f_maple_24_2", Spot(995.6225, 778.7293, 200));
		AddSpawnPoint( "f_maple_24_2.Id4", "f_maple_24_2", Spot(716.76746, 509.79764, 200));
		AddSpawnPoint( "f_maple_24_2.Id4", "f_maple_24_2", Spot(431.5144, 233.99731, 200));
		AddSpawnPoint( "f_maple_24_2.Id4", "f_maple_24_2", Spot(379.3085, 594.7606, 200));
		AddSpawnPoint( "f_maple_24_2.Id4", "f_maple_24_2", Spot(174.34624, 791.37085, 200));
		AddSpawnPoint( "f_maple_24_2.Id4", "f_maple_24_2", Spot(843.5195, 122.25549, 200));
		AddSpawnPoint( "f_maple_24_2.Id4", "f_maple_24_2", Spot(1268.7025, -9.703491, 200));
		AddSpawnPoint( "f_maple_24_2.Id4", "f_maple_24_2", Spot(101.5918, 310.6417, 200));
		AddSpawnPoint( "f_maple_24_2.Id4", "f_maple_24_2", Spot(-263.46054, 449.65292, 200));
		AddSpawnPoint( "f_maple_24_2.Id4", "f_maple_24_2", Spot(-537.05804, 668.77344, 200));
		AddSpawnPoint( "f_maple_24_2.Id4", "f_maple_24_2", Spot(-829.4817, 630.78674, 200));
		AddSpawnPoint( "f_maple_24_2.Id4", "f_maple_24_2", Spot(-1137.2891, 655.73425, 200));
		AddSpawnPoint( "f_maple_24_2.Id4", "f_maple_24_2", Spot(-628.0915, 123.01971, 200));
		AddSpawnPoint( "f_maple_24_2.Id4", "f_maple_24_2", Spot(-225.3967, 100.88547, 200));
		AddSpawnPoint( "f_maple_24_2.Id4", "f_maple_24_2", Spot(105.53237, -104.19194, 200));
		AddSpawnPoint( "f_maple_24_2.Id4", "f_maple_24_2", Spot(-188.73209, -393.15292, 200));
		AddSpawnPoint( "f_maple_24_2.Id4", "f_maple_24_2", Spot(-668.83997, -413.8394, 200));
		AddSpawnPoint( "f_maple_24_2.Id4", "f_maple_24_2", Spot(-1015.6309, -436.79617, 200));
		AddSpawnPoint( "f_maple_24_2.Id4", "f_maple_24_2", Spot(-1184.9812, -659.10706, 200));
		AddSpawnPoint( "f_maple_24_2.Id4", "f_maple_24_2", Spot(385.32605, -357.7749, 200));
		AddSpawnPoint( "f_maple_24_2.Id4", "f_maple_24_2", Spot(731.1067, -444.40198, 200));
		AddSpawnPoint( "f_maple_24_2.Id4", "f_maple_24_2", Spot(1080.4769, -616.71497, 200));
		AddSpawnPoint( "f_maple_24_2.Id4", "f_maple_24_2", Spot(-29.79784, -693.42816, 200));
		AddSpawnPoint( "f_maple_24_2.Id4", "f_maple_24_2", Spot(160.68723, -981.791, 200));
		AddSpawnPoint( "f_maple_24_2.Id4", "f_maple_24_2", Spot(366.3343, -1283.1211, 200));

	}
}
