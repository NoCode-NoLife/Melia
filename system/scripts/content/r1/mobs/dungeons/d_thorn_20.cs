//--- Melia Script -----------------------------------------------------------
// d_thorn_20
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Sirdgela Forest' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DThorn20MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_thorn_20", MonsterId.Flower_Blue, Properties("MHP", 42680, "MINPATK", 1050, "MAXPATK", 1192, "MINMATK", 1050, "MAXMATK", 1192, "DEF", 190, "MDEF", 190));
		AddPropertyOverrides("d_thorn_20", MonsterId.Groll, Properties("MHP", 43506, "MINPATK", 1060, "MAXPATK", 1205, "MINMATK", 1060, "MAXMATK", 1205, "DEF", 192, "MDEF", 192));
		AddPropertyOverrides("d_thorn_20", MonsterId.Merog_Wogu, Properties("MHP", 44345, "MINPATK", 1071, "MAXPATK", 1218, "MINMATK", 1071, "MAXMATK", 1218, "DEF", 193, "MDEF", 193));
		AddPropertyOverrides("d_thorn_20", MonsterId.Merog_Wizzard, Properties("MHP", 45199, "MINPATK", 1082, "MAXPATK", 1232, "MINMATK", 1082, "MAXMATK", 1232, "DEF", 194, "MDEF", 194));
		AddPropertyOverrides("d_thorn_20", MonsterId.Bagworm, Properties("MHP", 46066, "MINPATK", 1093, "MAXPATK", 1245, "MINMATK", 1093, "MAXMATK", 1245, "DEF", 195, "MDEF", 195));

		// Monster Spawners ---------------------------------

		AddSpawner("d_thorn_20.Id1", MonsterId.Flower_Blue, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_20.Id2", MonsterId.Groll, 57, 75, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_20.Id3", MonsterId.Rootcrystal_01, 12, 15, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("d_thorn_20.Id4", MonsterId.Groll, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_20.Id5", MonsterId.Merog_Wizzard, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_20.Id6", MonsterId.Bagworm, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_20.Id7", MonsterId.Flower_Blue, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_20.Id8", MonsterId.Merog_Wogu, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Flower_Blue' GenType 301 Spawn Points
		AddSpawnPoint("d_thorn_20.Id1", "d_thorn_20", Rectangle(-979, -1948, 9999));

		// 'Groll' GenType 308 Spawn Points
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-365.951, -1128.9451, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-438.41342, -981.0689, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-939.9221, -1966.1826, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-836.6593, -1847.0023, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-738.26117, -1958.4185, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-261.41113, -1649.2504, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-344.75616, -1825.2999, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-331.55627, -2125.4023, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-435.185, -1699.9497, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-571.5452, -1831.7488, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-447.747, -2024.0635, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-199.42294, -1808.5078, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-69.861595, -2078.7065, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-380.33682, -1954.744, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-64.82248, -2230.0156, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-465.69727, -2203.7708, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-198.91882, -2228.6614, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-154.21487, -1945.2433, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(115.65089, -2073.0095, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(358.34366, -1990.6415, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(314.4367, -1920.4839, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(143.89157, -1950.8182, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(5.3926687, -1824.28, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-172.80798, -1594.028, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-262.474, -1066.05, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-222.48312, -954.07513, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-340.88947, -859.39044, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-495.97153, -784.15155, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-364.4119, -688.3349, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-118.97442, -715.20557, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-64.71941, -969.04126, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-246.0107, -791.2531, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-46.056404, -1066.8547, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(70.502625, -922.1572, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-206.65445, -1210.8986, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-721.41486, -527.32104, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-868.07837, -583.55695, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-1366.049, 323.48502, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-1072.6383, -331.31714, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-1160.0739, -386.10364, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-1521.0449, 383.7018, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-1347.6609, -144.02788, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-1115.8517, -87.40848, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-1460.3275, 224.43613, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-1200.6086, -284.5172, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-1332.1019, 173.62982, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-1145.8474, 131.88452, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-1223.6532, 186.61855, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-1289.0504, 411.79333, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-1040.9529, 976.8547, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-1186.9229, 935.2289, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-722.1028, 946.1219, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-1123.4192, 1165.4146, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-1035.849, 1362.287, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-880.1264, 1429.3387, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-908.2287, 1295.2058, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-782.07196, 1253.4344, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-607.2231, 899.62, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-677.2632, 788.86426, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-806.3117, 758.1957, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-612.29675, 1058.2383, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-896.0811, 925.89795, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-941.0445, 1163.3234, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-185.29382, 472.5714, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-827.67633, 1070.0402, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-1048.1354, 815.5504, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-230.29124, 273.90604, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(11.534321, 326.45236, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-406.7145, 310.6942, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-429.66534, 100.034, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(176.30202, 51.551632, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(212.66882, -81.95696, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-74.115585, -111.55692, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(1460.2054, -1174.5192, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(1854.0641, -1192.9341, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(1671.0215, -1214.1444, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(1896.3816, -1338.6539, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(1751.4916, -1329.0564, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(1543.324, -1340.7701, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(1598.2336, -1480.5885, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(1859.6215, -1449.1023, 25));

		// 'Rootcrystal_01' GenType 514 Spawn Points
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-242, -1817, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-431, -1927, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-403, -2133, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-200, -2212, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-6, -2023, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-218, -2043, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-249, -1113, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-384, -1019, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-193, -860, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-321, -796, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-898, -511, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-1105, -372, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-1363, 203, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-1427, 255, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-886, 1130, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-931, 960, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-683.27295, 867.7399, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-251, 381, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-278, 220, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-22, 18, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(141.54984, 169.76071, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(710, -909, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(1679, -1271, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(1798, -1362, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(1656, -1459, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(2778, -1306, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(2650, -1213, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(2640, -1309, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(2637, -1070, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(2046, -173, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(2213, -445, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(2623, 656, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(2851, 605, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(2848, 408, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(2577.1274, 411.0153, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(2856, -1189, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(1055, -1074, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(5, -967, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-1291, -1825, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-1214, -298, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-160, -27, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(1572, -1317, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(636, -930, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-773, 1022, 200));

		// 'Groll' GenType 821 Spawn Points
		AddSpawnPoint("d_thorn_20.Id4", "d_thorn_20", Rectangle(-240.86589, -560.1803, 9999));

		// 'Merog_Wizzard' GenType 842 Spawn Points
		AddSpawnPoint("d_thorn_20.Id5", "d_thorn_20", Rectangle(-1026.8577, -469.76624, 25));
		AddSpawnPoint("d_thorn_20.Id5", "d_thorn_20", Rectangle(-886.05566, 1167.2539, 25));
		AddSpawnPoint("d_thorn_20.Id5", "d_thorn_20", Rectangle(-800.0285, 836.09216, 25));
		AddSpawnPoint("d_thorn_20.Id5", "d_thorn_20", Rectangle(-684.4464, 1043.612, 25));
		AddSpawnPoint("d_thorn_20.Id5", "d_thorn_20", Rectangle(-1154.3866, -223.1337, 25));
		AddSpawnPoint("d_thorn_20.Id5", "d_thorn_20", Rectangle(-296.3811, 430.92963, 25));
		AddSpawnPoint("d_thorn_20.Id5", "d_thorn_20", Rectangle(148.8252, 37.499092, 25));
		AddSpawnPoint("d_thorn_20.Id5", "d_thorn_20", Rectangle(-132.39743, 58.478962, 25));
		AddSpawnPoint("d_thorn_20.Id5", "d_thorn_20", Rectangle(-1281.1378, -332.48297, 25));
		AddSpawnPoint("d_thorn_20.Id5", "d_thorn_20", Rectangle(-1306.1577, -188.25827, 25));
		AddSpawnPoint("d_thorn_20.Id5", "d_thorn_20", Rectangle(-858.9387, 1014.0543, 25));
		AddSpawnPoint("d_thorn_20.Id5", "d_thorn_20", Rectangle(-397.04193, 215.40244, 25));
		AddSpawnPoint("d_thorn_20.Id5", "d_thorn_20", Rectangle(-79.37619, 365.2069, 25));
		AddSpawnPoint("d_thorn_20.Id5", "d_thorn_20", Rectangle(-245.89067, -74.62857, 25));
		AddSpawnPoint("d_thorn_20.Id5", "d_thorn_20", Rectangle(-987.39417, -336.50885, 25));
		AddSpawnPoint("d_thorn_20.Id5", "d_thorn_20", Rectangle(-9.220268, -106.17214, 25));

		// 'Bagworm' GenType 843 Spawn Points
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(42.253654, -901.32635, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(1448.5906, -1466.4081, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(1503.8695, -1209.5327, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(1237.608, -1062.9756, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(1174.7831, -1123.8297, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(1127.1875, -1032.0615, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(1101.3873, -1112.9727, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(1288.8704, -1154.5287, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(1261.219, -1180.3867, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(-1041.8137, -298.75113, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(-878.7924, 883.7706, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(-154.95773, 215.71078, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(-439.72342, -1004.3073, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(0.26290703, -1090.9482, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(-235.69112, -712.2116, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(-824.64, -522.2519, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(-1393.2865, -110.72148, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(-1401.3538, 319.94763, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(-1018.234, 1190.0647, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(-702.91595, 1053.3591, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(-265.98734, 179.02951, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(-426.14474, 68.426346, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(-139.3451, 422.0606, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(94.16034, -65.96461, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(-269.82034, -1206.632, 30));

		// 'Flower_Blue' GenType 846 Spawn Points
		AddSpawnPoint("d_thorn_20.Id7", "d_thorn_20", Rectangle(-182.27774, -1890.3215, 30));
		AddSpawnPoint("d_thorn_20.Id7", "d_thorn_20", Rectangle(-434.86047, -2102.3577, 30));
		AddSpawnPoint("d_thorn_20.Id7", "d_thorn_20", Rectangle(-201.94759, -1459.5665, 30));
		AddSpawnPoint("d_thorn_20.Id7", "d_thorn_20", Rectangle(-120.64085, -2201.631, 30));
		AddSpawnPoint("d_thorn_20.Id7", "d_thorn_20", Rectangle(-4.2262325, -2011.579, 30));
		AddSpawnPoint("d_thorn_20.Id7", "d_thorn_20", Rectangle(213.22035, -1984.4396, 30));
		AddSpawnPoint("d_thorn_20.Id7", "d_thorn_20", Rectangle(267.07175, -1896.7009, 30));
		AddSpawnPoint("d_thorn_20.Id7", "d_thorn_20", Rectangle(284.7085, -2008.9711, 30));
		AddSpawnPoint("d_thorn_20.Id7", "d_thorn_20", Rectangle(262.76816, -1962.7517, 30));
		AddSpawnPoint("d_thorn_20.Id7", "d_thorn_20", Rectangle(-212.49712, -1512.8048, 30));
		AddSpawnPoint("d_thorn_20.Id7", "d_thorn_20", Rectangle(-64.29135, -1547.5613, 30));
		AddSpawnPoint("d_thorn_20.Id7", "d_thorn_20", Rectangle(-142.42245, -1518.574, 30));

		// 'Merog_Wogu' GenType 850 Spawn Points
		AddSpawnPoint("d_thorn_20.Id8", "d_thorn_20", Rectangle(-208.67189, -1690.5369, 25));
		AddSpawnPoint("d_thorn_20.Id8", "d_thorn_20", Rectangle(-190.83783, -2164.1843, 25));
		AddSpawnPoint("d_thorn_20.Id8", "d_thorn_20", Rectangle(-195.33116, -1144.1515, 25));
		AddSpawnPoint("d_thorn_20.Id8", "d_thorn_20", Rectangle(-386.72482, -865.4883, 25));
		AddSpawnPoint("d_thorn_20.Id8", "d_thorn_20", Rectangle(-153.498, -651.6607, 25));
		AddSpawnPoint("d_thorn_20.Id8", "d_thorn_20", Rectangle(-10.196129, -862.2836, 25));
		AddSpawnPoint("d_thorn_20.Id8", "d_thorn_20", Rectangle(-468.89957, -1950.7638, 25));
		AddSpawnPoint("d_thorn_20.Id8", "d_thorn_20", Rectangle(86.35812, -1973.7078, 25));
		AddSpawnPoint("d_thorn_20.Id8", "d_thorn_20", Rectangle(-524.14087, -2221.6243, 25));
		AddSpawnPoint("d_thorn_20.Id8", "d_thorn_20", Rectangle(-177.7014, -894.01483, 25));
		AddSpawnPoint("d_thorn_20.Id8", "d_thorn_20", Rectangle(-799.9732, -633.8509, 25));
		AddSpawnPoint("d_thorn_20.Id8", "d_thorn_20", Rectangle(-671.59283, -619.0674, 25));
		AddSpawnPoint("d_thorn_20.Id8", "d_thorn_20", Rectangle(-183.9338, -414.18048, 25));
		AddSpawnPoint("d_thorn_20.Id8", "d_thorn_20", Rectangle(-120.92466, -313.5189, 25));
	}
}
