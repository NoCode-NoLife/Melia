//--- Melia Script -----------------------------------------------------------
// f_castle_94
//
//--- Description -----------------------------------------------------------
// Sets up the f_castle_94 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FCastle94MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_castle_94", MonsterId.Gland, Properties("MHP", 686342, "MINPATK", 9327, "MAXPATK", 11365, "MINMATK", 9327, "MAXMATK", 11365, "DEF", 181369, "MDEF", 181369));
		AddPropertyOverrides("f_castle_94", MonsterId.Grievous_Wheel, Properties("MHP", 688087, "MINPATK", 9349, "MAXPATK", 11393, "MINMATK", 9349, "MAXMATK", 11393, "DEF", 182617, "MDEF", 182617));
		AddPropertyOverrides("f_castle_94", MonsterId.Ghosnatus, Properties("MHP", 689892, "MINPATK", 9372, "MAXPATK", 11421, "MINMATK", 9372, "MAXMATK", 11421, "DEF", 183906, "MDEF", 183906));

		// Monster Spawners --------------------------------

		AddSpawner("f_castle_94.Id1", MonsterId.Gland, 53, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_castle_94.Id2", MonsterId.Grievous_Wheel, 42, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_castle_94.Id3", MonsterId.Ghosnatus, 35, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_castle_94.Id4", MonsterId.Gland, 25, TimeSpan.FromMilliseconds(40000), TendencyType.Peaceful);
		AddSpawner("f_castle_94.Id5", MonsterId.Grievous_Wheel, 20, TimeSpan.FromMilliseconds(40000), TendencyType.Peaceful);
		AddSpawner("f_castle_94.Id6", MonsterId.Ghosnatus, 15, TimeSpan.FromMilliseconds(40000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Gland Spawn Points
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(-756.7136, -696.8375, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(-626.16656, -664.19763, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(-721.6639, -505.94226, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(-632.4442, -485.92767, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(-639.8686, -364.95255, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(-700.44574, -243.75542, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(-525.09607, -238.77953, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(-378.10205, -178.35689, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(-213.88257, -223.3941, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(-15.90152, -192.45453, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(444.5255, -195.728, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(594.88855, -251.5751, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(829.04395, -194.59418, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(918.84467, -243.39621, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(1152.3289, -249.25847, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(1298.6643, -315.4868, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(1400.0461, -187.144, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(1370.034, 1.2718029, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(1223.8665, -19.391897, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(1084.8086, 15.401512, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(1086.8292, -330.3832, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(1212.9185, -436.96075, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(467.13513, 50.379944, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(426.63397, 74.498184, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(468.69232, 559.0392, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(418.1335, 655.95416, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(488.7333, 688.2615, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(1045.4979, 1025.5703, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(1131.0336, 983.8223, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(1304.2379, 877.05743, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(1339.8405, 832.0681, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(1397.5228, 931.55695, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(1235.8634, 1260.1146, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(1341.6951, 1191.2225, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(650.6312, 971.2026, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(590.7726, 1002.3188, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(121.85019, 1161.761, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(67.818115, 1193.7659, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(118.29106, 1224.5801, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(3.1906834, 864.44885, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(-223.88425, 890.0769, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(-260.03473, 962.8242, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(-504.2083, 853.2283, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(-509.87817, 1093.3561, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(-788.65125, 832.99066, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(-870.3264, 1074.4526, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(-709.2493, 1058.6926, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(-582.5873, 1347.9214, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(-464.0986, 1294.3933, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(-495.77545, 1561.2946, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(-436.2162, 2789.4995, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(-617.0055, 2855.3225, 20));
		AddSpawnPoint( "f_castle_94.Id1", "f_castle_94", Spot(-421.76157, 3015.1614, 20));

		// Grievous_Wheel Spawn Points
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(-737.06256, -355.0167, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(-808.7508, -249.35652, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(-848.7445, -499.65558, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(-590.00525, -159.69162, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(104.91605, -252.3108, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(569.1957, -174.29617, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(295.9886, 47.772583, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(445.38538, 304.61484, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(291.54724, 537.5315, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(420.3519, 763.00696, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(1022.8262, -433.3228, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(1393.2745, -426.0356, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(1250.2065, -139.66379, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(1028.245, -159.51004, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(1414.0668, -83.879105, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(756.1983, 1025.3157, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(930.29895, 917.31775, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(1030.2347, 1222.5658, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(1260.9381, 1101.5488, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(1440.1387, 731.85486, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(1460.4683, 1181.3644, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(204.16364, 1208.95, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(87.656555, 973.8297, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(5.44156, 1076.0756, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(-76.19493, 1249.0358, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(-117.08448, 821.77203, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(-122.41727, 1007.8487, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(-261.3645, 1236.1401, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(-395.07, 824.8166, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(-657.55597, 820.0344, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(-922.54834, 855.701, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(-810.90106, 983.5874, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(-888.93744, 1272.1263, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(-719.90826, 1233.8428, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(-500.8314, 2445.6697, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(-644.67847, 3031.0186, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(-484.11667, 2964.443, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(-364.0332, 1118.2638, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(-528.3513, 991.4868, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(283.14145, 729.54315, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(404.95108, 362.44897, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(952.14435, 1085.2355, 20));
		AddSpawnPoint( "f_castle_94.Id2", "f_castle_94", Spot(403.36874, 302.67554, 20));

		// Ghosnatus Spawn Points
		AddSpawnPoint( "f_castle_94.Id3", "f_castle_94", Spot(-795.4381, 1822.804, 20));
		AddSpawnPoint( "f_castle_94.Id3", "f_castle_94", Spot(-638.4582, 2044.4642, 20));
		AddSpawnPoint( "f_castle_94.Id3", "f_castle_94", Spot(-781.4064, 2198.2798, 20));
		AddSpawnPoint( "f_castle_94.Id3", "f_castle_94", Spot(-508.50732, 1856.2866, 20));
		AddSpawnPoint( "f_castle_94.Id3", "f_castle_94", Spot(-393.43286, 1997.0552, 20));
		AddSpawnPoint( "f_castle_94.Id3", "f_castle_94", Spot(-47.910545, 1943.9053, 20));
		AddSpawnPoint( "f_castle_94.Id3", "f_castle_94", Spot(-218.54764, 2065.5596, 20));
		AddSpawnPoint( "f_castle_94.Id3", "f_castle_94", Spot(230.60901, 2355.8176, 20));
		AddSpawnPoint( "f_castle_94.Id3", "f_castle_94", Spot(198.81364, 2683.3809, 20));
		AddSpawnPoint( "f_castle_94.Id3", "f_castle_94", Spot(271.44162, 2883.6787, 20));
		AddSpawnPoint( "f_castle_94.Id3", "f_castle_94", Spot(591.9662, 2583.1184, 20));
		AddSpawnPoint( "f_castle_94.Id3", "f_castle_94", Spot(431.54144, 2901.351, 20));
		AddSpawnPoint( "f_castle_94.Id3", "f_castle_94", Spot(-555.87524, 2776.4136, 20));
		AddSpawnPoint( "f_castle_94.Id3", "f_castle_94", Spot(-707.9133, 2776.816, 20));
		AddSpawnPoint( "f_castle_94.Id3", "f_castle_94", Spot(-725.9954, 2956.4116, 20));
		AddSpawnPoint( "f_castle_94.Id3", "f_castle_94", Spot(-582.67737, 2951.1218, 20));
		AddSpawnPoint( "f_castle_94.Id3", "f_castle_94", Spot(-477.75604, 3161.5603, 20));
		AddSpawnPoint( "f_castle_94.Id3", "f_castle_94", Spot(-679.20935, 3141.7563, 20));
		AddSpawnPoint( "f_castle_94.Id3", "f_castle_94", Spot(-265.04593, 3081.8901, 20));
		AddSpawnPoint( "f_castle_94.Id3", "f_castle_94", Spot(-292.96585, 2905.0977, 20));
		AddSpawnPoint( "f_castle_94.Id3", "f_castle_94", Spot(-309.518, 2729.5205, 20));
		AddSpawnPoint( "f_castle_94.Id3", "f_castle_94", Spot(-451.29178, 2340.6162, 20));
		AddSpawnPoint( "f_castle_94.Id3", "f_castle_94", Spot(-513.36285, 2630.4038, 20));
		AddSpawnPoint( "f_castle_94.Id3", "f_castle_94", Spot(-1173.8573, 933.5686, 20));
		AddSpawnPoint( "f_castle_94.Id3", "f_castle_94", Spot(-1224.7931, 1029.951, 20));
		AddSpawnPoint( "f_castle_94.Id3", "f_castle_94", Spot(-1137.4714, 1179.3082, 20));
		AddSpawnPoint( "f_castle_94.Id3", "f_castle_94", Spot(-1247.1938, 1234.4983, 20));
		AddSpawnPoint( "f_castle_94.Id3", "f_castle_94", Spot(-1337.1252, 824.7087, 20));
		AddSpawnPoint( "f_castle_94.Id3", "f_castle_94", Spot(-1315.7246, 1131.8029, 20));
		AddSpawnPoint( "f_castle_94.Id3", "f_castle_94", Spot(-410.02832, 990.9095, 20));
		AddSpawnPoint( "f_castle_94.Id3", "f_castle_94", Spot(77.28842, 1956.6721, 20));
		AddSpawnPoint( "f_castle_94.Id3", "f_castle_94", Spot(603.2569, 2766.1572, 20));
		AddSpawnPoint( "f_castle_94.Id3", "f_castle_94", Spot(-775.32794, 3099.0142, 20));
		AddSpawnPoint( "f_castle_94.Id3", "f_castle_94", Spot(-541.37537, 2201.612, 20));

		// Gland Spawn Points
		AddSpawnPoint( "f_castle_94.Id4", "f_castle_94", Spot(566.1798, 2836.488, 20));
		AddSpawnPoint( "f_castle_94.Id4", "f_castle_94", Spot(363.6056, 2911.3098, 20));
		AddSpawnPoint( "f_castle_94.Id4", "f_castle_94", Spot(260.51578, 2823.2354, 20));
		AddSpawnPoint( "f_castle_94.Id4", "f_castle_94", Spot(398.94177, 2616.906, 20));
		AddSpawnPoint( "f_castle_94.Id4", "f_castle_94", Spot(499.5294, 2601.225, 20));
		AddSpawnPoint( "f_castle_94.Id4", "f_castle_94", Spot(573.96246, 2522.0706, 20));
		AddSpawnPoint( "f_castle_94.Id4", "f_castle_94", Spot(193.43425, 2610.0625, 20));
		AddSpawnPoint( "f_castle_94.Id4", "f_castle_94", Spot(205.19028, 2502.0664, 20));
		AddSpawnPoint( "f_castle_94.Id4", "f_castle_94", Spot(174.88214, 2342.4705, 20));
		AddSpawnPoint( "f_castle_94.Id4", "f_castle_94", Spot(149.7088, 2230.2017, 20));
		AddSpawnPoint( "f_castle_94.Id4", "f_castle_94", Spot(198.5412, 1975.4572, 20));
		AddSpawnPoint( "f_castle_94.Id4", "f_castle_94", Spot(571.1806, 2912.751, 20));
		AddSpawnPoint( "f_castle_94.Id4", "f_castle_94", Spot(148.52194, 2041.8788, 20));
		AddSpawnPoint( "f_castle_94.Id4", "f_castle_94", Spot(141.88849, 2125.6367, 20));
		AddSpawnPoint( "f_castle_94.Id4", "f_castle_94", Spot(52.11673, 2104.6946, 20));
		AddSpawnPoint( "f_castle_94.Id4", "f_castle_94", Spot(364.119, 2498.8174, 20));
		AddSpawnPoint( "f_castle_94.Id4", "f_castle_94", Spot(348.80347, 2578.668, 20));
		AddSpawnPoint( "f_castle_94.Id4", "f_castle_94", Spot(183.64406, 2797.5361, 20));
		AddSpawnPoint( "f_castle_94.Id4", "f_castle_94", Spot(-10.113647, 2169.4573, 20));
		AddSpawnPoint( "f_castle_94.Id4", "f_castle_94", Spot(-87.7896, 2207.5044, 20));
		AddSpawnPoint( "f_castle_94.Id4", "f_castle_94", Spot(-133.19507, 1995.9059, 20));
		AddSpawnPoint( "f_castle_94.Id4", "f_castle_94", Spot(-258.96228, 1842.7101, 20));
		AddSpawnPoint( "f_castle_94.Id4", "f_castle_94", Spot(278.44107, 2563.8782, 20));
		AddSpawnPoint( "f_castle_94.Id4", "f_castle_94", Spot(449.32632, 2812.683, 20));
		AddSpawnPoint( "f_castle_94.Id4", "f_castle_94", Spot(-511.53763, 2013.9238, 20));

		// Grievous_Wheel Spawn Points
		AddSpawnPoint( "f_castle_94.Id5", "f_castle_94", Spot(-113.99162, 1907.2262, 20));
		AddSpawnPoint( "f_castle_94.Id5", "f_castle_94", Spot(-64.87933, 2039.6056, 20));
		AddSpawnPoint( "f_castle_94.Id5", "f_castle_94", Spot(-195.84135, 1834.3282, 20));
		AddSpawnPoint( "f_castle_94.Id5", "f_castle_94", Spot(-254.57167, 1959.8756, 20));
		AddSpawnPoint( "f_castle_94.Id5", "f_castle_94", Spot(-159.14046, 2138.218, 20));
		AddSpawnPoint( "f_castle_94.Id5", "f_castle_94", Spot(-203.70935, 2226.8218, 20));
		AddSpawnPoint( "f_castle_94.Id5", "f_castle_94", Spot(-322.03247, 2217.5728, 20));
		AddSpawnPoint( "f_castle_94.Id5", "f_castle_94", Spot(-299.30408, 2112.957, 20));
		AddSpawnPoint( "f_castle_94.Id5", "f_castle_94", Spot(-417.7089, 2055.5781, 20));
		AddSpawnPoint( "f_castle_94.Id5", "f_castle_94", Spot(-373.43283, 1872.511, 20));
		AddSpawnPoint( "f_castle_94.Id5", "f_castle_94", Spot(8.992741, 1898.7863, 20));
		AddSpawnPoint( "f_castle_94.Id5", "f_castle_94", Spot(-694.69495, 1992.554, 20));
		AddSpawnPoint( "f_castle_94.Id5", "f_castle_94", Spot(-842.84937, 1907.3289, 20));
		AddSpawnPoint( "f_castle_94.Id5", "f_castle_94", Spot(-849.2843, 1995.6091, 20));
		AddSpawnPoint( "f_castle_94.Id5", "f_castle_94", Spot(-682.49414, 2226.2878, 20));
		AddSpawnPoint( "f_castle_94.Id5", "f_castle_94", Spot(-965.93085, 1841.7426, 20));
		AddSpawnPoint( "f_castle_94.Id5", "f_castle_94", Spot(-916.8502, 1995.9316, 20));
		AddSpawnPoint( "f_castle_94.Id5", "f_castle_94", Spot(-991.352, 2072.7578, 20));
		AddSpawnPoint( "f_castle_94.Id5", "f_castle_94", Spot(-732.2525, 2084.7153, 20));
		AddSpawnPoint( "f_castle_94.Id5", "f_castle_94", Spot(-757.9725, 1912.0885, 20));

		// Ghosnatus Spawn Points
		AddSpawnPoint( "f_castle_94.Id6", "f_castle_94", Spot(-904.16705, 1816.9695, 20));
		AddSpawnPoint( "f_castle_94.Id6", "f_castle_94", Spot(-911.035, 2057.0767, 20));
		AddSpawnPoint( "f_castle_94.Id6", "f_castle_94", Spot(-686.9317, 1803.616, 20));
		AddSpawnPoint( "f_castle_94.Id6", "f_castle_94", Spot(-758.71313, 1979.947, 20));
		AddSpawnPoint( "f_castle_94.Id6", "f_castle_94", Spot(-703.77246, 2131.7217, 20));
		AddSpawnPoint( "f_castle_94.Id6", "f_castle_94", Spot(-826.44495, 2097.7056, 20));
		AddSpawnPoint( "f_castle_94.Id6", "f_castle_94", Spot(-845.8745, 2226.8252, 20));
		AddSpawnPoint( "f_castle_94.Id6", "f_castle_94", Spot(-952.6613, 2239.4336, 20));
		AddSpawnPoint( "f_castle_94.Id6", "f_castle_94", Spot(-633.14307, 1962.4219, 20));
		AddSpawnPoint( "f_castle_94.Id6", "f_castle_94", Spot(-711.1554, 1895.6276, 20));
		AddSpawnPoint( "f_castle_94.Id6", "f_castle_94", Spot(407.51813, 2710.753, 20));
		AddSpawnPoint( "f_castle_94.Id6", "f_castle_94", Spot(297.94946, 2652.644, 20));
		AddSpawnPoint( "f_castle_94.Id6", "f_castle_94", Spot(314.9901, 2756.5647, 20));
		AddSpawnPoint( "f_castle_94.Id6", "f_castle_94", Spot(527.79913, 2784.8, 20));
		AddSpawnPoint( "f_castle_94.Id6", "f_castle_94", Spot(457.35944, 2514.2302, 20));

	}
}
