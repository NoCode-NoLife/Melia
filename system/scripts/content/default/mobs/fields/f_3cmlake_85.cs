//--- Melia Script -----------------------------------------------------------
// f_3cmlake_85
//
//--- Description -----------------------------------------------------------
// Sets up the f_3cmlake_85 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class F3Cmlake85MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_3cmlake_85", MonsterId.Lotuscat, Properties("MHP", 595945, "MINPATK", 8164, "MAXPATK", 9936, "MINMATK", 8164, "MAXMATK", 9936, "DEF", 125381, "MDEF", 125381));
		AddPropertyOverrides("f_3cmlake_85", MonsterId.Pate, Properties("MHP", 596169, "MINPATK", 8167, "MAXPATK", 9940, "MINMATK", 8167, "MAXMATK", 9940, "DEF", 125515, "MDEF", 125515));
		AddPropertyOverrides("f_3cmlake_85", MonsterId.KindronLeader, Properties("MHP", 596578, "MINPATK", 8172, "MAXPATK", 9946, "MINMATK", 8172, "MAXMATK", 9946, "DEF", 125760, "MDEF", 125760));
		AddPropertyOverrides("f_3cmlake_85", MonsterId.Coterie, Properties("MHP", 597107, "MINPATK", 8179, "MAXPATK", 9954, "MINMATK", 8179, "MAXMATK", 9954, "DEF", 126077, "MDEF", 126077));
		AddPropertyOverrides("f_3cmlake_85", MonsterId.Tripy, Properties("MHP", 597735, "MINPATK", 8187, "MAXPATK", 9964, "MINMATK", 8187, "MAXMATK", 9964, "DEF", 126453, "MDEF", 126453));

		// Monster Spawners --------------------------------

		AddSpawner("f_3cmlake_85.Id1", MonsterId.Lotuscat, 18, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_85.Id2", MonsterId.Pate, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_85.Id3", MonsterId.Pate, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_85.Id4", MonsterId.KindronLeader, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_85.Id5", MonsterId.Coterie, 22, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_85.Id6", MonsterId.Coterie, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_85.Id7", MonsterId.Tripy, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_85.Id8", MonsterId.Tripy, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_85.Id9", MonsterId.Rootcrystal_02, 30, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Lotuscat Spawn Points
		AddSpawnPoint( "f_3cmlake_85.Id1", "f_3cmlake_85", Spot(-470.38556, -236.78467, 50));
		AddSpawnPoint( "f_3cmlake_85.Id1", "f_3cmlake_85", Spot(-406.57803, -71.00879, 50));
		AddSpawnPoint( "f_3cmlake_85.Id1", "f_3cmlake_85", Spot(-262.80673, 71.48472, 50));
		AddSpawnPoint( "f_3cmlake_85.Id1", "f_3cmlake_85", Spot(2.323114, -41.654404, 50));
		AddSpawnPoint( "f_3cmlake_85.Id1", "f_3cmlake_85", Spot(-258.2879, -277.91254, 50));
		AddSpawnPoint( "f_3cmlake_85.Id1", "f_3cmlake_85", Spot(-19.16446, -238.02222, 50));
		AddSpawnPoint( "f_3cmlake_85.Id1", "f_3cmlake_85", Spot(-138.53766, 355.98505, 50));
		AddSpawnPoint( "f_3cmlake_85.Id1", "f_3cmlake_85", Spot(-257.91364, 647.47485, 50));
		AddSpawnPoint( "f_3cmlake_85.Id1", "f_3cmlake_85", Spot(48.955296, 425.4673, 50));
		AddSpawnPoint( "f_3cmlake_85.Id1", "f_3cmlake_85", Spot(82.76862, 621.19684, 50));
		AddSpawnPoint( "f_3cmlake_85.Id1", "f_3cmlake_85", Spot(-392.3173, 1322.3688, 50));
		AddSpawnPoint( "f_3cmlake_85.Id1", "f_3cmlake_85", Spot(-202.62057, 1148.3834, 50));
		AddSpawnPoint( "f_3cmlake_85.Id1", "f_3cmlake_85", Spot(-135.22093, 1463.2944, 50));
		AddSpawnPoint( "f_3cmlake_85.Id1", "f_3cmlake_85", Spot(125.30125, 1255.9059, 50));
		AddSpawnPoint( "f_3cmlake_85.Id1", "f_3cmlake_85", Spot(523.8848, 1206.6245, 50));
		AddSpawnPoint( "f_3cmlake_85.Id1", "f_3cmlake_85", Spot(632.9626, 1424.5948, 50));
		AddSpawnPoint( "f_3cmlake_85.Id1", "f_3cmlake_85", Spot(766.6627, 1241.9518, 50));
		AddSpawnPoint( "f_3cmlake_85.Id1", "f_3cmlake_85", Spot(-335.0357, 501.55298, 50));

		// Pate Spawn Points
		AddSpawnPoint( "f_3cmlake_85.Id2", "f_3cmlake_85", Spot(-166.59474, -122.56562, 9999));
		AddSpawnPoint( "f_3cmlake_85.Id3", "f_3cmlake_85", Spot(-1158.2598, -685.17084, 40));
		AddSpawnPoint( "f_3cmlake_85.Id3", "f_3cmlake_85", Spot(-1943.3047, -27.256767, 40));
		AddSpawnPoint( "f_3cmlake_85.Id3", "f_3cmlake_85", Spot(-1278.566, -92.43706, 40));
		AddSpawnPoint( "f_3cmlake_85.Id3", "f_3cmlake_85", Spot(-231.56277, -128.78288, 40));
		AddSpawnPoint( "f_3cmlake_85.Id3", "f_3cmlake_85", Spot(-246.39146, 515.29126, 40));
		AddSpawnPoint( "f_3cmlake_85.Id3", "f_3cmlake_85", Spot(-197.22348, 1322.5962, 40));
		AddSpawnPoint( "f_3cmlake_85.Id3", "f_3cmlake_85", Spot(659.75073, 1331.17, 40));
		AddSpawnPoint( "f_3cmlake_85.Id3", "f_3cmlake_85", Spot(716.68823, 784.48737, 40));
		AddSpawnPoint( "f_3cmlake_85.Id3", "f_3cmlake_85", Spot(687.29926, 148.63849, 40));
		AddSpawnPoint( "f_3cmlake_85.Id3", "f_3cmlake_85", Spot(628.4879, -735.2074, 40));
		AddSpawnPoint( "f_3cmlake_85.Id3", "f_3cmlake_85", Spot(1365.8662, 65.717926, 40));
		AddSpawnPoint( "f_3cmlake_85.Id3", "f_3cmlake_85", Spot(1662.4623, -868.78674, 40));
		AddSpawnPoint( "f_3cmlake_85.Id3", "f_3cmlake_85", Spot(644.35803, -364.5149, 40));
		AddSpawnPoint( "f_3cmlake_85.Id3", "f_3cmlake_85", Spot(1048.7617, -768.51324, 40));
		AddSpawnPoint( "f_3cmlake_85.Id3", "f_3cmlake_85", Spot(-664.0073, -134.11362, 40));
		AddSpawnPoint( "f_3cmlake_85.Id3", "f_3cmlake_85", Spot(270.4075, 1274.5189, 40));
		AddSpawnPoint( "f_3cmlake_85.Id3", "f_3cmlake_85", Spot(1391.3287, -714.8591, 40));
		AddSpawnPoint( "f_3cmlake_85.Id3", "f_3cmlake_85", Spot(1042.9883, 71.71958, 40));
		AddSpawnPoint( "f_3cmlake_85.Id3", "f_3cmlake_85", Spot(-237.67455, 970.0807, 40));
		AddSpawnPoint( "f_3cmlake_85.Id3", "f_3cmlake_85", Spot(-1289.3505, -376.2108, 40));

		// KindronLeader Spawn Points
		AddSpawnPoint( "f_3cmlake_85.Id4", "f_3cmlake_85", Spot(615.42474, 897.2623, 100));
		AddSpawnPoint( "f_3cmlake_85.Id4", "f_3cmlake_85", Spot(757.52167, 713.8188, 100));
		AddSpawnPoint( "f_3cmlake_85.Id4", "f_3cmlake_85", Spot(750.7289, 44.255737, 100));
		AddSpawnPoint( "f_3cmlake_85.Id4", "f_3cmlake_85", Spot(676.9105, 370.04932, 100));
		AddSpawnPoint( "f_3cmlake_85.Id4", "f_3cmlake_85", Spot(1485.0001, -67.764404, 100));
		AddSpawnPoint( "f_3cmlake_85.Id4", "f_3cmlake_85", Spot(1336.3118, 134.84357, 100));
		AddSpawnPoint( "f_3cmlake_85.Id4", "f_3cmlake_85", Spot(660.9928, -668.1783, 100));
		AddSpawnPoint( "f_3cmlake_85.Id4", "f_3cmlake_85", Spot(1720.167, -838.1869, 100));
		AddSpawnPoint( "f_3cmlake_85.Id4", "f_3cmlake_85", Spot(1512.1407, -773.47363, 100));
		AddSpawnPoint( "f_3cmlake_85.Id4", "f_3cmlake_85", Spot(439.58908, 68.661644, 100));
		AddSpawnPoint( "f_3cmlake_85.Id4", "f_3cmlake_85", Spot(1112.5944, -784.41095, 100));
		AddSpawnPoint( "f_3cmlake_85.Id4", "f_3cmlake_85", Spot(1038.51, 53.0393, 100));
		AddSpawnPoint( "f_3cmlake_85.Id4", "f_3cmlake_85", Spot(633.723, -331.90027, 100));
		AddSpawnPoint( "f_3cmlake_85.Id4", "f_3cmlake_85", Spot(1827.1592, -773.74536, 100));

		// Coterie Spawn Points
		AddSpawnPoint( "f_3cmlake_85.Id5", "f_3cmlake_85", Spot(-1408.7848, -614.32697, 50));
		AddSpawnPoint( "f_3cmlake_85.Id5", "f_3cmlake_85", Spot(-1238.1699, -874.0343, 50));
		AddSpawnPoint( "f_3cmlake_85.Id5", "f_3cmlake_85", Spot(-1015.2053, -855.33734, 50));
		AddSpawnPoint( "f_3cmlake_85.Id5", "f_3cmlake_85", Spot(-1007.6255, -545.8783, 50));
		AddSpawnPoint( "f_3cmlake_85.Id5", "f_3cmlake_85", Spot(-1270.2792, -525.79944, 50));
		AddSpawnPoint( "f_3cmlake_85.Id5", "f_3cmlake_85", Spot(-2106.16, -158.30447, 50));
		AddSpawnPoint( "f_3cmlake_85.Id5", "f_3cmlake_85", Spot(-1856.9088, -146.12834, 50));
		AddSpawnPoint( "f_3cmlake_85.Id5", "f_3cmlake_85", Spot(-1788.9795, 89.495605, 50));
		AddSpawnPoint( "f_3cmlake_85.Id5", "f_3cmlake_85", Spot(-2066.7107, 75.32944, 50));
		AddSpawnPoint( "f_3cmlake_85.Id5", "f_3cmlake_85", Spot(-1430.5895, -183.27545, 50));
		AddSpawnPoint( "f_3cmlake_85.Id5", "f_3cmlake_85", Spot(-1351.7333, 38.176285, 50));
		AddSpawnPoint( "f_3cmlake_85.Id5", "f_3cmlake_85", Spot(-1237.1721, -109.95042, 50));
		AddSpawnPoint( "f_3cmlake_85.Id5", "f_3cmlake_85", Spot(-846.68414, -115.33392, 50));
		AddSpawnPoint( "f_3cmlake_85.Id5", "f_3cmlake_85", Spot(-555.8623, -122.62561, 50));
		AddSpawnPoint( "f_3cmlake_85.Id5", "f_3cmlake_85", Spot(-409.7173, -283.78162, 50));
		AddSpawnPoint( "f_3cmlake_85.Id5", "f_3cmlake_85", Spot(-90.11754, -296.97366, 50));
		AddSpawnPoint( "f_3cmlake_85.Id5", "f_3cmlake_85", Spot(114.37604, -127.1473, 50));
		AddSpawnPoint( "f_3cmlake_85.Id5", "f_3cmlake_85", Spot(-19.089134, 27.018833, 50));
		AddSpawnPoint( "f_3cmlake_85.Id5", "f_3cmlake_85", Spot(-299.6538, 24.311918, 50));
		AddSpawnPoint( "f_3cmlake_85.Id5", "f_3cmlake_85", Spot(-214.59355, -144.097, 50));
		AddSpawnPoint( "f_3cmlake_85.Id5", "f_3cmlake_85", Spot(-255.50287, 371.39758, 50));
		AddSpawnPoint( "f_3cmlake_85.Id5", "f_3cmlake_85", Spot(114.16158, 466.75092, 50));
		AddSpawnPoint( "f_3cmlake_85.Id5", "f_3cmlake_85", Spot(-227.30164, 626.86163, 50));
		AddSpawnPoint( "f_3cmlake_85.Id6", "f_3cmlake_85", Spot(-1193.4597, -707.37427, 275));
		AddSpawnPoint( "f_3cmlake_85.Id6", "f_3cmlake_85", Spot(-231.53914, -156.84047, 275));
		AddSpawnPoint( "f_3cmlake_85.Id6", "f_3cmlake_85", Spot(-160.71698, 496.55627, 275));
		AddSpawnPoint( "f_3cmlake_85.Id6", "f_3cmlake_85", Spot(-1937.8707, -18.066805, 275));

		// Tripy Spawn Points
		AddSpawnPoint( "f_3cmlake_85.Id7", "f_3cmlake_85", Spot(791.296, -778.07153, 50));
		AddSpawnPoint( "f_3cmlake_85.Id7", "f_3cmlake_85", Spot(576.1433, -739.11224, 50));
		AddSpawnPoint( "f_3cmlake_85.Id7", "f_3cmlake_85", Spot(673.9995, -588.81024, 50));
		AddSpawnPoint( "f_3cmlake_85.Id7", "f_3cmlake_85", Spot(666.46954, -111.72495, 50));
		AddSpawnPoint( "f_3cmlake_85.Id7", "f_3cmlake_85", Spot(429.88504, 43.262657, 50));
		AddSpawnPoint( "f_3cmlake_85.Id7", "f_3cmlake_85", Spot(457.20792, 212.07521, 50));
		AddSpawnPoint( "f_3cmlake_85.Id7", "f_3cmlake_85", Spot(642.2276, 369.75797, 50));
		AddSpawnPoint( "f_3cmlake_85.Id7", "f_3cmlake_85", Spot(777.0735, 54.865467, 50));
		AddSpawnPoint( "f_3cmlake_85.Id7", "f_3cmlake_85", Spot(1251.5734, -29.965263, 50));
		AddSpawnPoint( "f_3cmlake_85.Id7", "f_3cmlake_85", Spot(1481.2026, -94.42349, 50));
		AddSpawnPoint( "f_3cmlake_85.Id7", "f_3cmlake_85", Spot(1269.8302, 222.82208, 50));
		AddSpawnPoint( "f_3cmlake_85.Id7", "f_3cmlake_85", Spot(1506.6102, 230.57933, 50));
		AddSpawnPoint( "f_3cmlake_85.Id7", "f_3cmlake_85", Spot(719.40857, 609.33673, 50));
		AddSpawnPoint( "f_3cmlake_85.Id7", "f_3cmlake_85", Spot(570.1295, 874.0737, 50));
		AddSpawnPoint( "f_3cmlake_85.Id7", "f_3cmlake_85", Spot(778.3211, 919.4911, 50));
		AddSpawnPoint( "f_3cmlake_85.Id7", "f_3cmlake_85", Spot(1508.0533, -758.01843, 50));
		AddSpawnPoint( "f_3cmlake_85.Id7", "f_3cmlake_85", Spot(1661.0422, -946.7566, 50));
		AddSpawnPoint( "f_3cmlake_85.Id7", "f_3cmlake_85", Spot(1742.907, -753.3992, 50));
		AddSpawnPoint( "f_3cmlake_85.Id7", "f_3cmlake_85", Spot(1154.9445, -770.9183, 50));
		AddSpawnPoint( "f_3cmlake_85.Id7", "f_3cmlake_85", Spot(1039.1882, 83.953865, 50));
		AddSpawnPoint( "f_3cmlake_85.Id8", "f_3cmlake_85", Spot(690.361, -680.2315, 275));
		AddSpawnPoint( "f_3cmlake_85.Id8", "f_3cmlake_85", Spot(1608.9637, -834.9872, 275));
		AddSpawnPoint( "f_3cmlake_85.Id8", "f_3cmlake_85", Spot(690.3903, 91.048706, 275));
		AddSpawnPoint( "f_3cmlake_85.Id8", "f_3cmlake_85", Spot(687.34937, 844.5408, 275));
		AddSpawnPoint( "f_3cmlake_85.Id8", "f_3cmlake_85", Spot(1382.3491, 86.19701, 275));
		AddSpawnPoint( "f_3cmlake_85.Id8", "f_3cmlake_85", Spot(471.89746, 890.6711, 275));

		// Rootcrystal_02 Spawn Points
		AddSpawnPoint( "f_3cmlake_85.Id9", "f_3cmlake_85", Spot(719.2313, -608.44885, 200));
		AddSpawnPoint( "f_3cmlake_85.Id9", "f_3cmlake_85", Spot(625.6678, -816.2901, 200));
		AddSpawnPoint( "f_3cmlake_85.Id9", "f_3cmlake_85", Spot(1091.0596, -762.35675, 200));
		AddSpawnPoint( "f_3cmlake_85.Id9", "f_3cmlake_85", Spot(1424.2634, -684.9422, 200));
		AddSpawnPoint( "f_3cmlake_85.Id9", "f_3cmlake_85", Spot(1601.73, -957.93256, 200));
		AddSpawnPoint( "f_3cmlake_85.Id9", "f_3cmlake_85", Spot(1778.6534, -735.8066, 200));
		AddSpawnPoint( "f_3cmlake_85.Id9", "f_3cmlake_85", Spot(298.5704, -695.29297, 200));
		AddSpawnPoint( "f_3cmlake_85.Id9", "f_3cmlake_85", Spot(-293.59424, -588.4336, 200));
		AddSpawnPoint( "f_3cmlake_85.Id9", "f_3cmlake_85", Spot(-27.832935, -675.6995, 200));
		AddSpawnPoint( "f_3cmlake_85.Id9", "f_3cmlake_85", Spot(-435.81372, -62.748596, 200));
		AddSpawnPoint( "f_3cmlake_85.Id9", "f_3cmlake_85", Spot(784.2384, 1221.8298, 200));
		AddSpawnPoint( "f_3cmlake_85.Id9", "f_3cmlake_85", Spot(-128.56929, -199.68304, 200));
		AddSpawnPoint( "f_3cmlake_85.Id9", "f_3cmlake_85", Spot(-237.51291, 311.22488, 200));
		AddSpawnPoint( "f_3cmlake_85.Id9", "f_3cmlake_85", Spot(-352.05994, 621.7538, 200));
		AddSpawnPoint( "f_3cmlake_85.Id9", "f_3cmlake_85", Spot(91.22865, 523.91693, 200));
		AddSpawnPoint( "f_3cmlake_85.Id9", "f_3cmlake_85", Spot(-187.96335, 1157.283, 200));
		AddSpawnPoint( "f_3cmlake_85.Id9", "f_3cmlake_85", Spot(-311.4985, 1452.4368, 200));
		AddSpawnPoint( "f_3cmlake_85.Id9", "f_3cmlake_85", Spot(114.46273, 1249.1492, 200));
		AddSpawnPoint( "f_3cmlake_85.Id9", "f_3cmlake_85", Spot(493.44037, 1399.8405, 200));
		AddSpawnPoint( "f_3cmlake_85.Id9", "f_3cmlake_85", Spot(-1010.9663, -106.05719, 200));
		AddSpawnPoint( "f_3cmlake_85.Id9", "f_3cmlake_85", Spot(-1465.9745, -55.591778, 200));
		AddSpawnPoint( "f_3cmlake_85.Id9", "f_3cmlake_85", Spot(-1281.1346, 183.73859, 200));
		AddSpawnPoint( "f_3cmlake_85.Id9", "f_3cmlake_85", Spot(-1319.9022, 691.2199, 200));
		AddSpawnPoint( "f_3cmlake_85.Id9", "f_3cmlake_85", Spot(-1015.0074, 448.323, 200));
		AddSpawnPoint( "f_3cmlake_85.Id9", "f_3cmlake_85", Spot(-1313.5287, -512.8408, 200));
		AddSpawnPoint( "f_3cmlake_85.Id9", "f_3cmlake_85", Spot(-1114.8011, -782.00946, 200));
		AddSpawnPoint( "f_3cmlake_85.Id9", "f_3cmlake_85", Spot(-1819.4528, -28.325453, 200));
		AddSpawnPoint( "f_3cmlake_85.Id9", "f_3cmlake_85", Spot(636.96497, -163.09006, 200));
		AddSpawnPoint( "f_3cmlake_85.Id9", "f_3cmlake_85", Spot(497.36307, 308.2948, 200));
		AddSpawnPoint( "f_3cmlake_85.Id9", "f_3cmlake_85", Spot(1112.3519, 69.244286, 200));
		AddSpawnPoint( "f_3cmlake_85.Id9", "f_3cmlake_85", Spot(712.2841, 807.03296, 200));
		AddSpawnPoint( "f_3cmlake_85.Id9", "f_3cmlake_85", Spot(1487.574, 44.57343, 200));

	}
}
