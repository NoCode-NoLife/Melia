//--- Melia Script -----------------------------------------------------------
// d_thorn_20
//
//--- Description -----------------------------------------------------------
// Sets up the d_thorn_20 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DThorn20MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("d_thorn_20", MonsterId.Flower_Blue, Properties("MHP", 42680, "MINPATK", 1050, "MAXPATK", 1192, "MINMATK", 1050, "MAXMATK", 1192, "DEF", 190, "MDEF", 190));
		AddPropertyOverrides("d_thorn_20", MonsterId.Groll, Properties("MHP", 43506, "MINPATK", 1060, "MAXPATK", 1205, "MINMATK", 1060, "MAXMATK", 1205, "DEF", 192, "MDEF", 192));
		AddPropertyOverrides("d_thorn_20", MonsterId.Merog_Wizzard, Properties("MHP", 45199, "MINPATK", 1082, "MAXPATK", 1232, "MINMATK", 1082, "MAXMATK", 1232, "DEF", 194, "MDEF", 194));
		AddPropertyOverrides("d_thorn_20", MonsterId.Bagworm, Properties("MHP", 46066, "MINPATK", 1093, "MAXPATK", 1245, "MINMATK", 1093, "MAXMATK", 1245, "DEF", 195, "MDEF", 195));
		AddPropertyOverrides("d_thorn_20", MonsterId.Merog_Wogu, Properties("MHP", 44345, "MINPATK", 1071, "MAXPATK", 1218, "MINMATK", 1071, "MAXMATK", 1218, "DEF", 193, "MDEF", 193));

		// Monster Spawners --------------------------------

		AddSpawner("d_thorn_20.Id1", MonsterId.Rootcrystal_01, 15, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("d_thorn_20.Id2", MonsterId.Flower_Blue, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_20.Id3", MonsterId.Groll, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_20.Id4", MonsterId.Merog_Wizzard, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_20.Id5", MonsterId.Bagworm, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_20.Id6", MonsterId.Flower_Blue, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_20.Id7", MonsterId.Merog_Wogu, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_20.Id8", MonsterId.Groll, 75, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(-242, -1817, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(-431, -1927, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(-403, -2133, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(-200, -2212, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(-6, -2023, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(-218, -2043, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(-249, -1113, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(-384, -1019, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(-193, -860, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(-321, -796, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(-898, -511, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(-1105, -372, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(-1363, 203, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(-1427, 255, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(-886, 1130, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(-931, 960, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(-683.27295, 867.7399, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(-251, 381, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(-278, 220, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(-22, 18, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(141.54984, 169.76071, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(710, -909, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(1679, -1271, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(1798, -1362, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(1656, -1459, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(2778, -1306, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(2650, -1213, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(2640, -1309, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(2637, -1070, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(2046, -173, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(2213, -445, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(2623, 656, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(2851, 605, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(2848, 408, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(2577.1274, 411.0153, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(2856, -1189, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(1055, -1074, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(5, -967, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(-1291, -1825, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(-1214, -298, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(-160, -27, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(1572, -1317, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(636, -930, 200));
		AddSpawnPoint( "d_thorn_20.Id1", "d_thorn_20", Spot(-773, 1022, 200));

		// Flower_Blue Spawn Points
		AddSpawnPoint( "d_thorn_20.Id2", "d_thorn_20", Spot(-979, -1948, 9999));

		// Groll Spawn Points
		AddSpawnPoint( "d_thorn_20.Id3", "d_thorn_20", Spot(-240.86589, -560.1803, 9999));

		// Merog_Wizzard Spawn Points
		AddSpawnPoint( "d_thorn_20.Id4", "d_thorn_20", Spot(-1026.8577, -469.76624, 25));
		AddSpawnPoint( "d_thorn_20.Id4", "d_thorn_20", Spot(-886.05566, 1167.2539, 25));
		AddSpawnPoint( "d_thorn_20.Id4", "d_thorn_20", Spot(-800.0285, 836.09216, 25));
		AddSpawnPoint( "d_thorn_20.Id4", "d_thorn_20", Spot(-684.4464, 1043.612, 25));
		AddSpawnPoint( "d_thorn_20.Id4", "d_thorn_20", Spot(-1154.3866, -223.1337, 25));
		AddSpawnPoint( "d_thorn_20.Id4", "d_thorn_20", Spot(-296.3811, 430.92963, 25));
		AddSpawnPoint( "d_thorn_20.Id4", "d_thorn_20", Spot(148.8252, 37.499092, 25));
		AddSpawnPoint( "d_thorn_20.Id4", "d_thorn_20", Spot(-132.39743, 58.478962, 25));
		AddSpawnPoint( "d_thorn_20.Id4", "d_thorn_20", Spot(-1281.1378, -332.48297, 25));
		AddSpawnPoint( "d_thorn_20.Id4", "d_thorn_20", Spot(-1306.1577, -188.25827, 25));
		AddSpawnPoint( "d_thorn_20.Id4", "d_thorn_20", Spot(-858.9387, 1014.0543, 25));
		AddSpawnPoint( "d_thorn_20.Id4", "d_thorn_20", Spot(-397.04193, 215.40244, 25));
		AddSpawnPoint( "d_thorn_20.Id4", "d_thorn_20", Spot(-79.37619, 365.2069, 25));
		AddSpawnPoint( "d_thorn_20.Id4", "d_thorn_20", Spot(-245.89067, -74.62857, 25));
		AddSpawnPoint( "d_thorn_20.Id4", "d_thorn_20", Spot(-987.39417, -336.50885, 25));
		AddSpawnPoint( "d_thorn_20.Id4", "d_thorn_20", Spot(-9.220268, -106.17214, 25));

		// Bagworm Spawn Points
		AddSpawnPoint( "d_thorn_20.Id5", "d_thorn_20", Spot(42.253654, -901.32635, 30));
		AddSpawnPoint( "d_thorn_20.Id5", "d_thorn_20", Spot(1448.5906, -1466.4081, 30));
		AddSpawnPoint( "d_thorn_20.Id5", "d_thorn_20", Spot(1503.8695, -1209.5327, 30));
		AddSpawnPoint( "d_thorn_20.Id5", "d_thorn_20", Spot(1237.608, -1062.9756, 30));
		AddSpawnPoint( "d_thorn_20.Id5", "d_thorn_20", Spot(1174.7831, -1123.8297, 30));
		AddSpawnPoint( "d_thorn_20.Id5", "d_thorn_20", Spot(1127.1875, -1032.0615, 30));
		AddSpawnPoint( "d_thorn_20.Id5", "d_thorn_20", Spot(1101.3873, -1112.9727, 30));
		AddSpawnPoint( "d_thorn_20.Id5", "d_thorn_20", Spot(1288.8704, -1154.5287, 30));
		AddSpawnPoint( "d_thorn_20.Id5", "d_thorn_20", Spot(1261.219, -1180.3867, 30));
		AddSpawnPoint( "d_thorn_20.Id5", "d_thorn_20", Spot(-1041.8137, -298.75113, 30));
		AddSpawnPoint( "d_thorn_20.Id5", "d_thorn_20", Spot(-878.7924, 883.7706, 30));
		AddSpawnPoint( "d_thorn_20.Id5", "d_thorn_20", Spot(-154.95773, 215.71078, 30));
		AddSpawnPoint( "d_thorn_20.Id5", "d_thorn_20", Spot(-439.72342, -1004.3073, 30));
		AddSpawnPoint( "d_thorn_20.Id5", "d_thorn_20", Spot(0.26290703, -1090.9482, 30));
		AddSpawnPoint( "d_thorn_20.Id5", "d_thorn_20", Spot(-235.69112, -712.2116, 30));
		AddSpawnPoint( "d_thorn_20.Id5", "d_thorn_20", Spot(-824.64, -522.2519, 30));
		AddSpawnPoint( "d_thorn_20.Id5", "d_thorn_20", Spot(-1393.2865, -110.72148, 30));
		AddSpawnPoint( "d_thorn_20.Id5", "d_thorn_20", Spot(-1401.3538, 319.94763, 30));
		AddSpawnPoint( "d_thorn_20.Id5", "d_thorn_20", Spot(-1018.234, 1190.0647, 30));
		AddSpawnPoint( "d_thorn_20.Id5", "d_thorn_20", Spot(-702.91595, 1053.3591, 30));
		AddSpawnPoint( "d_thorn_20.Id5", "d_thorn_20", Spot(-265.98734, 179.02951, 30));
		AddSpawnPoint( "d_thorn_20.Id5", "d_thorn_20", Spot(-426.14474, 68.426346, 30));
		AddSpawnPoint( "d_thorn_20.Id5", "d_thorn_20", Spot(-139.3451, 422.0606, 30));
		AddSpawnPoint( "d_thorn_20.Id5", "d_thorn_20", Spot(94.16034, -65.96461, 30));
		AddSpawnPoint( "d_thorn_20.Id5", "d_thorn_20", Spot(-269.82034, -1206.632, 30));

		// Flower_Blue Spawn Points
		AddSpawnPoint( "d_thorn_20.Id6", "d_thorn_20", Spot(-182.27774, -1890.3215, 30));
		AddSpawnPoint( "d_thorn_20.Id6", "d_thorn_20", Spot(-434.86047, -2102.3577, 30));
		AddSpawnPoint( "d_thorn_20.Id6", "d_thorn_20", Spot(-201.94759, -1459.5665, 30));
		AddSpawnPoint( "d_thorn_20.Id6", "d_thorn_20", Spot(-120.64085, -2201.631, 30));
		AddSpawnPoint( "d_thorn_20.Id6", "d_thorn_20", Spot(-4.2262325, -2011.579, 30));
		AddSpawnPoint( "d_thorn_20.Id6", "d_thorn_20", Spot(213.22035, -1984.4396, 30));
		AddSpawnPoint( "d_thorn_20.Id6", "d_thorn_20", Spot(267.07175, -1896.7009, 30));
		AddSpawnPoint( "d_thorn_20.Id6", "d_thorn_20", Spot(284.7085, -2008.9711, 30));
		AddSpawnPoint( "d_thorn_20.Id6", "d_thorn_20", Spot(262.76816, -1962.7517, 30));
		AddSpawnPoint( "d_thorn_20.Id6", "d_thorn_20", Spot(-212.49712, -1512.8048, 30));
		AddSpawnPoint( "d_thorn_20.Id6", "d_thorn_20", Spot(-64.29135, -1547.5613, 30));
		AddSpawnPoint( "d_thorn_20.Id6", "d_thorn_20", Spot(-142.42245, -1518.574, 30));

		// Merog_Wogu Spawn Points
		AddSpawnPoint( "d_thorn_20.Id7", "d_thorn_20", Spot(-208.67189, -1690.5369, 25));
		AddSpawnPoint( "d_thorn_20.Id7", "d_thorn_20", Spot(-190.83783, -2164.1843, 25));
		AddSpawnPoint( "d_thorn_20.Id7", "d_thorn_20", Spot(-195.33116, -1144.1515, 25));
		AddSpawnPoint( "d_thorn_20.Id7", "d_thorn_20", Spot(-386.72482, -865.4883, 25));
		AddSpawnPoint( "d_thorn_20.Id7", "d_thorn_20", Spot(-153.498, -651.6607, 25));
		AddSpawnPoint( "d_thorn_20.Id7", "d_thorn_20", Spot(-10.196129, -862.2836, 25));
		AddSpawnPoint( "d_thorn_20.Id7", "d_thorn_20", Spot(-468.89957, -1950.7638, 25));
		AddSpawnPoint( "d_thorn_20.Id7", "d_thorn_20", Spot(86.35812, -1973.7078, 25));
		AddSpawnPoint( "d_thorn_20.Id7", "d_thorn_20", Spot(-524.14087, -2221.6243, 25));
		AddSpawnPoint( "d_thorn_20.Id7", "d_thorn_20", Spot(-177.7014, -894.01483, 25));
		AddSpawnPoint( "d_thorn_20.Id7", "d_thorn_20", Spot(-799.9732, -633.8509, 25));
		AddSpawnPoint( "d_thorn_20.Id7", "d_thorn_20", Spot(-671.59283, -619.0674, 25));
		AddSpawnPoint( "d_thorn_20.Id7", "d_thorn_20", Spot(-183.9338, -414.18048, 25));
		AddSpawnPoint( "d_thorn_20.Id7", "d_thorn_20", Spot(-120.92466, -313.5189, 25));

		// Groll Spawn Points
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-365.951, -1128.9451, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-438.41342, -981.0689, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-939.9221, -1966.1826, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-836.6593, -1847.0023, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-738.26117, -1958.4185, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-261.41113, -1649.2504, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-344.75616, -1825.2999, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-331.55627, -2125.4023, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-435.185, -1699.9497, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-571.5452, -1831.7488, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-447.747, -2024.0635, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-199.42294, -1808.5078, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-69.861595, -2078.7065, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-380.33682, -1954.744, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-64.82248, -2230.0156, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-465.69727, -2203.7708, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-198.91882, -2228.6614, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-154.21487, -1945.2433, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(115.65089, -2073.0095, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(358.34366, -1990.6415, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(314.4367, -1920.4839, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(143.89157, -1950.8182, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(5.3926687, -1824.28, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-172.80798, -1594.028, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-262.474, -1066.05, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-222.48312, -954.07513, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-340.88947, -859.39044, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-495.97153, -784.15155, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-364.4119, -688.3349, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-118.97442, -715.20557, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-64.71941, -969.04126, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-246.0107, -791.2531, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-46.056404, -1066.8547, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(70.502625, -922.1572, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-206.65445, -1210.8986, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-721.41486, -527.32104, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-868.07837, -583.55695, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-1366.049, 323.48502, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-1072.6383, -331.31714, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-1160.0739, -386.10364, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-1521.0449, 383.7018, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-1347.6609, -144.02788, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-1115.8517, -87.40848, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-1460.3275, 224.43613, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-1200.6086, -284.5172, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-1332.1019, 173.62982, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-1145.8474, 131.88452, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-1223.6532, 186.61855, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-1289.0504, 411.79333, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-1040.9529, 976.8547, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-1186.9229, 935.2289, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-722.1028, 946.1219, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-1123.4192, 1165.4146, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-1035.849, 1362.287, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-880.1264, 1429.3387, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-908.2287, 1295.2058, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-782.07196, 1253.4344, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-607.2231, 899.62, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-677.2632, 788.86426, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-806.3117, 758.1957, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-612.29675, 1058.2383, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-896.0811, 925.89795, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-941.0445, 1163.3234, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-185.29382, 472.5714, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-827.67633, 1070.0402, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-1048.1354, 815.5504, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-230.29124, 273.90604, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(11.534321, 326.45236, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-406.7145, 310.6942, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-429.66534, 100.034, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(176.30202, 51.551632, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(212.66882, -81.95696, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(-74.115585, -111.55692, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(1460.2054, -1174.5192, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(1854.0641, -1192.9341, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(1671.0215, -1214.1444, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(1896.3816, -1338.6539, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(1751.4916, -1329.0564, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(1543.324, -1340.7701, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(1598.2336, -1480.5885, 25));
		AddSpawnPoint( "d_thorn_20.Id8", "d_thorn_20", Spot(1859.6215, -1449.1023, 25));

	}
}
