//--- Melia Script -----------------------------------------------------------
// f_siauliai_50_1
//
//--- Description -----------------------------------------------------------
// Sets up the f_siauliai_50_1 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FSiauliai501MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_siauliai_50_1", MonsterId.Chupaluka_Pink, Properties("MHP", 169654, "MINPATK", 2683, "MAXPATK", 3199, "MINMATK", 2683, "MAXMATK", 3199, "DEF", 4567, "MDEF", 4567));
		AddPropertyOverrides("f_siauliai_50_1", MonsterId.Sakmoli_Orange, Properties("MHP", 169849, "MINPATK", 2686, "MAXPATK", 3202, "MINMATK", 2686, "MAXMATK", 3202, "DEF", 4585, "MDEF", 4585));
		AddPropertyOverrides("f_siauliai_50_1", MonsterId.Ridimed_Purple, Properties("MHP", 170206, "MINPATK", 2690, "MAXPATK", 3208, "MINMATK", 2690, "MAXMATK", 3208, "DEF", 4617, "MDEF", 4617));
		AddPropertyOverrides("f_siauliai_50_1", MonsterId.Repusbunny_Bow, Properties("MHP", 170667, "MINPATK", 2696, "MAXPATK", 3215, "MINMATK", 2696, "MAXMATK", 3215, "DEF", 4659, "MDEF", 4659));

		// Monster Spawners --------------------------------

		AddSpawner("f_siauliai_50_1.Id1", MonsterId.Chupaluka_Pink, 12, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_siauliai_50_1.Id2", MonsterId.Sakmoli_Orange, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_50_1.Id3", MonsterId.Chupaluka_Pink, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_50_1.Id4", MonsterId.Sakmoli_Orange, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_50_1.Id5", MonsterId.Ridimed_Purple, 65, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_50_1.Id6", MonsterId.RootCrystal_A, 14, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_siauliai_50_1.Id7", MonsterId.Repusbunny_Bow, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_50_1.Id8", MonsterId.Ridimed_Purple, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_50_1.Id9", MonsterId.Ridimed_Purple, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_50_1.Id10", MonsterId.Sakmoli_Orange, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Chupaluka_Pink Spawn Points
		AddSpawnPoint( "f_siauliai_50_1.Id1", "f_siauliai_50_1", Spot(-889.1417, -1503.3768, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id1", "f_siauliai_50_1", Spot(-54.87921, -1000.6483, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id1", "f_siauliai_50_1", Spot(-559.6093, -1461.4939, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id1", "f_siauliai_50_1", Spot(-210.0827, -1456.261, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id1", "f_siauliai_50_1", Spot(62.65081, -1861.956, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id1", "f_siauliai_50_1", Spot(532.0255, -1493.3284, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id1", "f_siauliai_50_1", Spot(417.13235, -1621.0109, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id1", "f_siauliai_50_1", Spot(196.33998, -1282.6556, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id1", "f_siauliai_50_1", Spot(-5.25465, -1295.974, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id1", "f_siauliai_50_1", Spot(379.58725, -1219.8994, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id1", "f_siauliai_50_1", Spot(61.701973, -1475.6985, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id1", "f_siauliai_50_1", Spot(-234.42781, -1658.9227, 30));

		// Sakmoli_Orange Spawn Points
		AddSpawnPoint( "f_siauliai_50_1.Id2", "f_siauliai_50_1", Spot(53.23785, 468.56165, 3000));

		// Chupaluka_Pink Spawn Points
		AddSpawnPoint( "f_siauliai_50_1.Id3", "f_siauliai_50_1", Spot(1421.2753, -365.5739, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id3", "f_siauliai_50_1", Spot(1398.4822, -609.8045, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id3", "f_siauliai_50_1", Spot(1302.9127, -494.20038, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id3", "f_siauliai_50_1", Spot(1242.0822, -318.63873, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id3", "f_siauliai_50_1", Spot(1329.8553, -157.78215, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id3", "f_siauliai_50_1", Spot(1595.0361, -545.3068, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id3", "f_siauliai_50_1", Spot(1604.3234, -382.2175, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id3", "f_siauliai_50_1", Spot(1723.0693, -452.47946, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id3", "f_siauliai_50_1", Spot(1780.2056, -341.39978, 30));

		// Sakmoli_Orange Spawn Points
		AddSpawnPoint( "f_siauliai_50_1.Id4", "f_siauliai_50_1", Spot(143.07669, -1456.4087, 230));
		AddSpawnPoint( "f_siauliai_50_1.Id4", "f_siauliai_50_1", Spot(-82.44122, 530.1582, 230));

		// Ridimed_Purple Spawn Points
		AddSpawnPoint( "f_siauliai_50_1.Id5", "f_siauliai_50_1", Spot(68.24359, -1402.3135, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id5", "f_siauliai_50_1", Spot(-47.812298, 354.1748, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id5", "f_siauliai_50_1", Spot(161.06541, -1674.6387, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id5", "f_siauliai_50_1", Spot(483.57407, -1322.31, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id5", "f_siauliai_50_1", Spot(160.75923, -1109.1604, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id5", "f_siauliai_50_1", Spot(-172.64847, -1247.0973, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id5", "f_siauliai_50_1", Spot(-267.98145, -1488.753, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id5", "f_siauliai_50_1", Spot(287.98303, -1336.4352, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id5", "f_siauliai_50_1", Spot(-467.0632, 560.51685, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id5", "f_siauliai_50_1", Spot(-220.01393, 551.9252, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id5", "f_siauliai_50_1", Spot(240.06241, 357.2536, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id5", "f_siauliai_50_1", Spot(-30.428774, 833.0676, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id5", "f_siauliai_50_1", Spot(-324.75668, 268.0795, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id5", "f_siauliai_50_1", Spot(132.03252, 561.2801, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id5", "f_siauliai_50_1", Spot(-5.04333, -1757.1895, 30));

		// RootCrystal_A Spawn Points
		AddSpawnPoint( "f_siauliai_50_1.Id6", "f_siauliai_50_1", Spot(1700.8667, 541.6705, 20));
		AddSpawnPoint( "f_siauliai_50_1.Id6", "f_siauliai_50_1", Spot(1378.0801, -398.08185, 20));
		AddSpawnPoint( "f_siauliai_50_1.Id6", "f_siauliai_50_1", Spot(1783.4387, -391.44827, 20));
		AddSpawnPoint( "f_siauliai_50_1.Id6", "f_siauliai_50_1", Spot(375.6839, 503.27698, 20));
		AddSpawnPoint( "f_siauliai_50_1.Id6", "f_siauliai_50_1", Spot(-189.89192, 528.3392, 20));
		AddSpawnPoint( "f_siauliai_50_1.Id6", "f_siauliai_50_1", Spot(-184.38382, 858.8467, 20));
		AddSpawnPoint( "f_siauliai_50_1.Id6", "f_siauliai_50_1", Spot(-520.6503, 380.10196, 20));
		AddSpawnPoint( "f_siauliai_50_1.Id6", "f_siauliai_50_1", Spot(-31.199749, 116.21054, 20));
		AddSpawnPoint( "f_siauliai_50_1.Id6", "f_siauliai_50_1", Spot(-118.64886, -752.0233, 20));
		AddSpawnPoint( "f_siauliai_50_1.Id6", "f_siauliai_50_1", Spot(119.62401, -1182.9574, 20));
		AddSpawnPoint( "f_siauliai_50_1.Id6", "f_siauliai_50_1", Spot(91.447495, -1754.5137, 20));
		AddSpawnPoint( "f_siauliai_50_1.Id6", "f_siauliai_50_1", Spot(768.8256, -1474.461, 20));
		AddSpawnPoint( "f_siauliai_50_1.Id6", "f_siauliai_50_1", Spot(-450.01337, -1454.7064, 20));
		AddSpawnPoint( "f_siauliai_50_1.Id6", "f_siauliai_50_1", Spot(-937.2481, -1541.6554, 20));

		// Repusbunny_Bow Spawn Points
		AddSpawnPoint( "f_siauliai_50_1.Id7", "f_siauliai_50_1", Spot(1262.2604, -185.84654, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id7", "f_siauliai_50_1", Spot(1416.9105, -472.65448, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id7", "f_siauliai_50_1", Spot(1730.5513, -390.06387, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id7", "f_siauliai_50_1", Spot(1253.4872, -397.55923, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id7", "f_siauliai_50_1", Spot(1557.8555, -369.7223, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id7", "f_siauliai_50_1", Spot(-363.55734, 1374.1107, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id7", "f_siauliai_50_1", Spot(-208.08907, 1501.0121, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id7", "f_siauliai_50_1", Spot(-191.79231, 1307.5471, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id7", "f_siauliai_50_1", Spot(47.81562, 1417.5353, 30));

		// Ridimed_Purple Spawn Points
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(1887.4292, 448.4273, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(1624.9575, 519.1795, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(1799.5143, 557.7618, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(1921.6117, 703.5348, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(2026.1989, 566.0745, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(1432.5419, 631.7433, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(1398.5963, 411.8494, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(1423.3309, 529.16205, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(2096.5896, 680.9961, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(1914.1982, 556.6024, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(2166.0913, 438.40298, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(2240.759, 472.5311, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(2202.1853, 533.36523, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(2130.0146, 515.07916, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(2112.6624, 595.8883, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(1529.2493, 441.4016, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(1529.2485, 534.6732, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(1532.1893, 651.6894, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(1634.061, 604.889, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(1324.7808, 480.93274, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(1527.6793, -469.1784, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(1492.5912, -552.2955, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(1355.9478, -281.70535, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(1173.1627, -218.6059, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(1635.0117, -471.01013, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(77.40663, -1703.8838, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(-23.470867, -1463.1633, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(131.82495, -1321.9736, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(131.65485, -1206.7755, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(-203.90129, -1352.231, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(-797.8089, -1444.2719, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(-885.45386, -1400.012, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(-963.0149, -1432.166, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(-978.0851, -1518.0905, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(-829.6722, -1569.8998, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(112.19519, 252.34294, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(-36.04422, 466.08875, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(-146.07721, 607.41046, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(122.67864, 649.8478, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(146.57959, 798.5938, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(336.6676, 670.8673, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(399.55954, 389.25214, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(201.78009, 633.7409, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(-10.609211, 642.3925, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(-50.927986, 723.74384, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(-104.97364, 1316.7906, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(-281.3434, 1300.1621, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(-284.9911, 1385.8364, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(-201.5682, 1409.1805, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(-311.26154, 1473.2933, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(-125.77728, 1463.9971, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(-84.79402, 1395.6575, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(-38.028866, 1462.9425, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(-76.28395, 1541.42, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(11.072206, 1301.765, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(103.28296, 1349.88, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(123.68147, 1429.8188, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(199.83133, 1448.2385, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(380.4862, 1469.2957, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id8", "f_siauliai_50_1", Spot(246.47096, 1535.801, 30));
		AddSpawnPoint( "f_siauliai_50_1.Id9", "f_siauliai_50_1", Spot(-1058.6692, 1569.9158, 50));
		AddSpawnPoint( "f_siauliai_50_1.Id9", "f_siauliai_50_1", Spot(-881.1377, 1615.2946, 50));
		AddSpawnPoint( "f_siauliai_50_1.Id9", "f_siauliai_50_1", Spot(-822.6483, 1524.6467, 50));
		AddSpawnPoint( "f_siauliai_50_1.Id9", "f_siauliai_50_1", Spot(-875.5963, 1437.7714, 50));
		AddSpawnPoint( "f_siauliai_50_1.Id9", "f_siauliai_50_1", Spot(-923.2391, 1370.582, 50));
		AddSpawnPoint( "f_siauliai_50_1.Id9", "f_siauliai_50_1", Spot(-944.3035, 1333.512, 50));
		AddSpawnPoint( "f_siauliai_50_1.Id9", "f_siauliai_50_1", Spot(-1033.6444, 1449.3961, 50));
		AddSpawnPoint( "f_siauliai_50_1.Id9", "f_siauliai_50_1", Spot(-1007.5068, 1556.945, 50));
		AddSpawnPoint( "f_siauliai_50_1.Id9", "f_siauliai_50_1", Spot(-910.088, 1509.0138, 50));
		AddSpawnPoint( "f_siauliai_50_1.Id9", "f_siauliai_50_1", Spot(-677.6499, 1406.6882, 50));
		AddSpawnPoint( "f_siauliai_50_1.Id9", "f_siauliai_50_1", Spot(-559.0539, 1419.3428, 50));
		AddSpawnPoint( "f_siauliai_50_1.Id9", "f_siauliai_50_1", Spot(961.4001, 1511.2961, 50));
		AddSpawnPoint( "f_siauliai_50_1.Id9", "f_siauliai_50_1", Spot(1042.602, 1435.6643, 50));
		AddSpawnPoint( "f_siauliai_50_1.Id9", "f_siauliai_50_1", Spot(1032.2867, 1382.8624, 50));
		AddSpawnPoint( "f_siauliai_50_1.Id9", "f_siauliai_50_1", Spot(1017.7886, 1282.5693, 50));
		AddSpawnPoint( "f_siauliai_50_1.Id9", "f_siauliai_50_1", Spot(876.1743, 1283.7936, 50));
		AddSpawnPoint( "f_siauliai_50_1.Id9", "f_siauliai_50_1", Spot(800.12177, 1362.2363, 50));
		AddSpawnPoint( "f_siauliai_50_1.Id9", "f_siauliai_50_1", Spot(866.5646, 1433.2952, 50));
		AddSpawnPoint( "f_siauliai_50_1.Id9", "f_siauliai_50_1", Spot(950.33997, 1367.3292, 50));
		AddSpawnPoint( "f_siauliai_50_1.Id9", "f_siauliai_50_1", Spot(1027.5964, 1337.3799, 50));
		AddSpawnPoint( "f_siauliai_50_1.Id9", "f_siauliai_50_1", Spot(1108.5885, 1284.9321, 50));

		// Sakmoli_Orange Spawn Points
		AddSpawnPoint( "f_siauliai_50_1.Id10", "f_siauliai_50_1", Spot(879.88025, 1519.8909, 50));
		AddSpawnPoint( "f_siauliai_50_1.Id10", "f_siauliai_50_1", Spot(988.79736, 1406.6702, 50));
		AddSpawnPoint( "f_siauliai_50_1.Id10", "f_siauliai_50_1", Spot(905.8489, 1319.2332, 50));
		AddSpawnPoint( "f_siauliai_50_1.Id10", "f_siauliai_50_1", Spot(967.4199, 1265.5259, 50));
		AddSpawnPoint( "f_siauliai_50_1.Id10", "f_siauliai_50_1", Spot(1107.5013, 1345.2046, 50));
		AddSpawnPoint( "f_siauliai_50_1.Id10", "f_siauliai_50_1", Spot(647.41156, 1437.8774, 50));
		AddSpawnPoint( "f_siauliai_50_1.Id10", "f_siauliai_50_1", Spot(454.30847, 1505.5585, 50));
		AddSpawnPoint( "f_siauliai_50_1.Id10", "f_siauliai_50_1", Spot(289.945, 1473.8766, 50));
		AddSpawnPoint( "f_siauliai_50_1.Id10", "f_siauliai_50_1", Spot(-1010.2133, 1600.9563, 50));
		AddSpawnPoint( "f_siauliai_50_1.Id10", "f_siauliai_50_1", Spot(-971.6491, 1445.2977, 50));
		AddSpawnPoint( "f_siauliai_50_1.Id10", "f_siauliai_50_1", Spot(-982.09314, 1293.7958, 50));
		AddSpawnPoint( "f_siauliai_50_1.Id10", "f_siauliai_50_1", Spot(-826.50854, 1440.2253, 50));

	}
}
