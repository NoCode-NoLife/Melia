//--- Melia Script -----------------------------------------------------------
// d_startower_88
//
//--- Description -----------------------------------------------------------
// Sets up the d_startower_88 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DStartower88MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("d_startower_88", MonsterId.NightPanto_Stellar, Properties("MHP", 611624, "MINPATK", 8366, "MAXPATK", 10184, "MINMATK", 8366, "MAXMATK", 10184, "DEF", 134770, "MDEF", 134770));
		AddPropertyOverrides("d_startower_88", MonsterId.NightPanto_Archer, Properties("MHP", 613028, "MINPATK", 8384, "MAXPATK", 10206, "MINMATK", 8384, "MAXMATK", 10206, "DEF", 135611, "MDEF", 135611));
		AddPropertyOverrides("d_startower_88", MonsterId.NightPanto_Mage, Properties("MHP", 614471, "MINPATK", 8402, "MAXPATK", 10229, "MINMATK", 8402, "MAXMATK", 10229, "DEF", 136475, "MDEF", 136475));
		AddPropertyOverrides("d_startower_88", MonsterId.Mushuta, Properties("MHP", 615952, "MINPATK", 8421, "MAXPATK", 10252, "MINMATK", 8421, "MAXMATK", 10252, "DEF", 137363, "MDEF", 137363));

		// Monster Spawners --------------------------------

		AddSpawner("d_startower_88.Id1", MonsterId.NightPanto_Stellar, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_startower_88.Id2", MonsterId.NightPanto_Archer, 22, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_startower_88.Id3", MonsterId.NightPanto_Mage, 11, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_startower_88.Id4", MonsterId.NightPanto_Mage, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_startower_88.Id5", MonsterId.Mushuta, 39, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_startower_88.Id6", MonsterId.Rootcrystal_02, 16, TimeSpan.FromMilliseconds(10000), TendencyType.Peaceful);
		AddSpawner("d_startower_88.Id7", MonsterId.Mushuta, 40, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// NightPanto_Stellar Spawn Points
		AddSpawnPoint( "d_startower_88.Id1", "d_startower_88", Spot(-96.14525, 60.615974, 25));
		AddSpawnPoint( "d_startower_88.Id1", "d_startower_88", Spot(-126.79164, -152.79955, 25));
		AddSpawnPoint( "d_startower_88.Id1", "d_startower_88", Spot(-116.52348, -435.31076, 25));
		AddSpawnPoint( "d_startower_88.Id1", "d_startower_88", Spot(367.38516, -479.8988, 25));
		AddSpawnPoint( "d_startower_88.Id1", "d_startower_88", Spot(389.64972, -286.4764, 25));
		AddSpawnPoint( "d_startower_88.Id1", "d_startower_88", Spot(400.02148, 30.169725, 25));
		AddSpawnPoint( "d_startower_88.Id1", "d_startower_88", Spot(250.17636, -375.04105, 25));
		AddSpawnPoint( "d_startower_88.Id1", "d_startower_88", Spot(60.103745, -55.15991, 25));
		AddSpawnPoint( "d_startower_88.Id1", "d_startower_88", Spot(145.72978, 251.94867, 25));
		AddSpawnPoint( "d_startower_88.Id1", "d_startower_88", Spot(-108.94498, 280.87482, 25));
		AddSpawnPoint( "d_startower_88.Id1", "d_startower_88", Spot(-188.43806, 653.81866, 25));
		AddSpawnPoint( "d_startower_88.Id1", "d_startower_88", Spot(150.05626, 641.2996, 25));
		AddSpawnPoint( "d_startower_88.Id1", "d_startower_88", Spot(-94.48326, 496.39713, 25));
		AddSpawnPoint( "d_startower_88.Id1", "d_startower_88", Spot(-174.10266, 895.04285, 25));
		AddSpawnPoint( "d_startower_88.Id1", "d_startower_88", Spot(154.58667, 114.89404, 25));

		// NightPanto_Archer Spawn Points
		AddSpawnPoint( "d_startower_88.Id2", "d_startower_88", Spot(-366.38232, 2511.1829, 25));
		AddSpawnPoint( "d_startower_88.Id2", "d_startower_88", Spot(-454.08112, 2698.3833, 25));
		AddSpawnPoint( "d_startower_88.Id2", "d_startower_88", Spot(-408.6827, 2889.9995, 25));
		AddSpawnPoint( "d_startower_88.Id2", "d_startower_88", Spot(-304.18854, 2671.159, 25));
		AddSpawnPoint( "d_startower_88.Id2", "d_startower_88", Spot(-125.97324, 2898.1646, 25));
		AddSpawnPoint( "d_startower_88.Id2", "d_startower_88", Spot(-31.657227, 2698.75, 25));
		AddSpawnPoint( "d_startower_88.Id2", "d_startower_88", Spot(-138.27818, 2598.7593, 25));
		AddSpawnPoint( "d_startower_88.Id2", "d_startower_88", Spot(109.17996, 2778.1436, 25));
		AddSpawnPoint( "d_startower_88.Id2", "d_startower_88", Spot(103.76443, 2553.2837, 25));
		AddSpawnPoint( "d_startower_88.Id2", "d_startower_88", Spot(-26.542671, 2358.5813, 25));
		AddSpawnPoint( "d_startower_88.Id2", "d_startower_88", Spot(-314.79504, 2295.7485, 25));
		AddSpawnPoint( "d_startower_88.Id2", "d_startower_88", Spot(-163.7809, 2128.7673, 25));
		AddSpawnPoint( "d_startower_88.Id2", "d_startower_88", Spot(-173.36356, 1881.3198, 25));
		AddSpawnPoint( "d_startower_88.Id2", "d_startower_88", Spot(-197.89389, 1648.9432, 25));
		AddSpawnPoint( "d_startower_88.Id2", "d_startower_88", Spot(247.58961, 2489.8896, 25));
		AddSpawnPoint( "d_startower_88.Id2", "d_startower_88", Spot(394.05054, 2700.4248, 25));
		AddSpawnPoint( "d_startower_88.Id2", "d_startower_88", Spot(489.99445, 2495.7253, 25));
		AddSpawnPoint( "d_startower_88.Id2", "d_startower_88", Spot(641.4476, 2617.124, 25));
		AddSpawnPoint( "d_startower_88.Id2", "d_startower_88", Spot(1021.6701, 2515.1914, 25));
		AddSpawnPoint( "d_startower_88.Id2", "d_startower_88", Spot(936.8468, 3051.2385, 25));
		AddSpawnPoint( "d_startower_88.Id2", "d_startower_88", Spot(1118.9237, 2824.7888, 25));
		AddSpawnPoint( "d_startower_88.Id2", "d_startower_88", Spot(1264.1318, 3120.399, 25));

		// NightPanto_Mage Spawn Points
		AddSpawnPoint( "d_startower_88.Id3", "d_startower_88", Spot(1640.2996, 1086.9344, 25));
		AddSpawnPoint( "d_startower_88.Id3", "d_startower_88", Spot(1515.7377, 1089.1443, 25));
		AddSpawnPoint( "d_startower_88.Id3", "d_startower_88", Spot(1335.8228, 1084.2657, 25));
		AddSpawnPoint( "d_startower_88.Id3", "d_startower_88", Spot(1373.4204, 1214.9336, 25));
		AddSpawnPoint( "d_startower_88.Id3", "d_startower_88", Spot(1498.3912, 1215.459, 25));
		AddSpawnPoint( "d_startower_88.Id3", "d_startower_88", Spot(1666.0194, 1234.8912, 25));
		AddSpawnPoint( "d_startower_88.Id3", "d_startower_88", Spot(1079.4904, 1233.671, 25));
		AddSpawnPoint( "d_startower_88.Id3", "d_startower_88", Spot(862.49634, 1258.077, 25));
		AddSpawnPoint( "d_startower_88.Id3", "d_startower_88", Spot(789.55115, 1088.9213, 25));
		AddSpawnPoint( "d_startower_88.Id3", "d_startower_88", Spot(686.2758, 1210.9753, 25));
		AddSpawnPoint( "d_startower_88.Id3", "d_startower_88", Spot(468.92462, 1230.2411, 25));
		AddSpawnPoint( "d_startower_88.Id4", "d_startower_88", Spot(983.4279, 3244.3252, 25));
		AddSpawnPoint( "d_startower_88.Id4", "d_startower_88", Spot(799.7583, 3010.8767, 25));
		AddSpawnPoint( "d_startower_88.Id4", "d_startower_88", Spot(1014.1159, 2782.26, 25));
		AddSpawnPoint( "d_startower_88.Id4", "d_startower_88", Spot(1013.6461, 2650.5527, 25));
		AddSpawnPoint( "d_startower_88.Id4", "d_startower_88", Spot(1331.5612, 2894.5505, 25));
		AddSpawnPoint( "d_startower_88.Id4", "d_startower_88", Spot(1080.1292, 3082.9055, 25));
		AddSpawnPoint( "d_startower_88.Id4", "d_startower_88", Spot(1432.7666, 3154.8433, 25));
		AddSpawnPoint( "d_startower_88.Id4", "d_startower_88", Spot(1332.6616, 2669.6057, 25));
		AddSpawnPoint( "d_startower_88.Id4", "d_startower_88", Spot(1479.4415, 2941.1492, 25));

		// Mushuta Spawn Points
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(1376.686, 1307.5383, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(1566.0044, 1330.4976, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(1585.0858, 1131.4309, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(898.33746, 1073.1864, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(776.6709, 1292.519, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(358.4065, 1243.1089, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(102.1097, 542.7587, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(49.756077, 238.75418, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(-181.22495, 771.8666, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(309.38632, 36.556732, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(250.02046, -261.1438, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(28.682945, -506.1531, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(-141.51633, -234.56049, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(-199.92139, 45.641834, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(258.40338, -537.0528, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(-176.97292, 1768.4114, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(-212.2281, 2197.8687, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(-144.1919, 2331.199, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(195.2515, 2346.747, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(43.74657, 2494.4949, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(86.864716, 2667.8018, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(-105.53955, 2795.7769, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(-391.24847, 2785.701, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(-352.84555, 2598.087, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(-113.52028, 2517.446, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(271.65225, 2615.6926, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(456.63718, 2574.4387, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(676.5979, 2690.476, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(1176.845, 2503.378, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(1605.1002, 3049.5466, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(1432.4713, 2805.6938, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(1175.01, 2627.8352, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(841.38617, 2889.0205, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(1251.5505, 2794.693, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(1343.2303, 2977.2205, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(914.9306, 3197.4963, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(1199.9418, 3277.8608, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(1456.5828, 2643.8958, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(1587.8918, 2891.2751, 25));
		AddSpawnPoint( "d_startower_88.Id5", "d_startower_88", Spot(542.699, 2668.6904, 25));

		// Rootcrystal_02 Spawn Points
		AddSpawnPoint( "d_startower_88.Id6", "d_startower_88", Spot(1923.1184, 1207.5311, 200));
		AddSpawnPoint( "d_startower_88.Id6", "d_startower_88", Spot(1422.2336, 1216.3304, 200));
		AddSpawnPoint( "d_startower_88.Id6", "d_startower_88", Spot(847.13434, 1231.5742, 200));
		AddSpawnPoint( "d_startower_88.Id6", "d_startower_88", Spot(417.6052, 1242.4221, 200));
		AddSpawnPoint( "d_startower_88.Id6", "d_startower_88", Spot(-124.02612, 769.36597, 200));
		AddSpawnPoint( "d_startower_88.Id6", "d_startower_88", Spot(31.612324, 335.5824, 200));
		AddSpawnPoint( "d_startower_88.Id6", "d_startower_88", Spot(8.191787, -348.32245, 200));
		AddSpawnPoint( "d_startower_88.Id6", "d_startower_88", Spot(344.25055, 5.384821, 200));
		AddSpawnPoint( "d_startower_88.Id6", "d_startower_88", Spot(174.29404, 176.3356, 200));
		AddSpawnPoint( "d_startower_88.Id6", "d_startower_88", Spot(-174.00145, 1705.6208, 200));
		AddSpawnPoint( "d_startower_88.Id6", "d_startower_88", Spot(-277.44666, 2259.9753, 200));
		AddSpawnPoint( "d_startower_88.Id6", "d_startower_88", Spot(255.31616, 2649.3743, 200));
		AddSpawnPoint( "d_startower_88.Id6", "d_startower_88", Spot(-249.20879, 2710.3528, 200));
		AddSpawnPoint( "d_startower_88.Id6", "d_startower_88", Spot(970.6349, 2559.2773, 200));
		AddSpawnPoint( "d_startower_88.Id6", "d_startower_88", Spot(1086.6354, 2731.9788, 200));
		AddSpawnPoint( "d_startower_88.Id6", "d_startower_88", Spot(1430.2511, 3208.24, 200));

		// Mushuta Spawn Points
		AddSpawnPoint( "d_startower_88.Id7", "d_startower_88", Spot(-231.47559, 2146.8093, 300));
		AddSpawnPoint( "d_startower_88.Id7", "d_startower_88", Spot(-221.83928, 2701.0798, 300));
		AddSpawnPoint( "d_startower_88.Id7", "d_startower_88", Spot(-186.71887, 1580.3701, 300));
		AddSpawnPoint( "d_startower_88.Id7", "d_startower_88", Spot(155.91045, 2441.149, 300));

	}
}
