//--- Melia Script -----------------------------------------------------------
// d_cathedral_54
//
//--- Description -----------------------------------------------------------
// Sets up the d_cathedral_54 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DCathedral54MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("d_cathedral_54", MonsterId.Stoulet_Blue, Properties("MHP", 148160, "MINPATK", 2406, "MAXPATK", 2859, "MINMATK", 2406, "MAXMATK", 2859, "DEF", 3327, "MDEF", 3327));
		AddPropertyOverrides("d_cathedral_54", MonsterId.NightMaiden_Mage, Properties("MHP", 149915, "MINPATK", 2429, "MAXPATK", 2887, "MINMATK", 2429, "MAXMATK", 2887, "DEF", 3429, "MDEF", 3429));
		AddPropertyOverrides("d_cathedral_54", MonsterId.Velwriggler_Blue, Properties("MHP", 151713, "MINPATK", 2452, "MAXPATK", 2915, "MINMATK", 2452, "MAXMATK", 2915, "DEF", 3532, "MDEF", 3532));

		// Monster Spawners --------------------------------

		AddSpawner("d_cathedral_54.Id1", MonsterId.Stoulet_Blue, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cathedral_54.Id2", MonsterId.NightMaiden_Mage, 8, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cathedral_54.Id3", MonsterId.Rootcrystal_03, 21, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_cathedral_54.Id4", MonsterId.Velwriggler_Blue, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cathedral_54.Id5", MonsterId.Stoulet_Blue, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// Stoulet_Blue Spawn Points
		AddSpawnPoint( "d_cathedral_54.Id1", "d_cathedral_54", Spot(1000.0291, -164.0309, 9999));

		// NightMaiden_Mage Spawn Points
		AddSpawnPoint( "d_cathedral_54.Id2", "d_cathedral_54", Spot(563.2119, -585.3009, 30));
		AddSpawnPoint( "d_cathedral_54.Id2", "d_cathedral_54", Spot(277.7986, -734.8664, 30));
		AddSpawnPoint( "d_cathedral_54.Id2", "d_cathedral_54", Spot(269.80255, -1210.6946, 30));
		AddSpawnPoint( "d_cathedral_54.Id2", "d_cathedral_54", Spot(64.81576, -1316.7173, 30));
		AddSpawnPoint( "d_cathedral_54.Id2", "d_cathedral_54", Spot(688.96924, -961.7811, 30));
		AddSpawnPoint( "d_cathedral_54.Id2", "d_cathedral_54", Spot(-316.14276, -1276.3381, 30));
		AddSpawnPoint( "d_cathedral_54.Id2", "d_cathedral_54", Spot(-298.4986, -957.457, 30));
		AddSpawnPoint( "d_cathedral_54.Id2", "d_cathedral_54", Spot(761.10046, -1308.0985, 30));
		AddSpawnPoint( "d_cathedral_54.Id2", "d_cathedral_54", Spot(-333.16525, -625.9408, 30));

		// Rootcrystal_03 Spawn Points
		AddSpawnPoint( "d_cathedral_54.Id3", "d_cathedral_54", Spot(1029.4543, -311.1855, 10));
		AddSpawnPoint( "d_cathedral_54.Id3", "d_cathedral_54", Spot(1013.3968, 413.68018, 10));
		AddSpawnPoint( "d_cathedral_54.Id3", "d_cathedral_54", Spot(718.5945, -975.32935, 10));
		AddSpawnPoint( "d_cathedral_54.Id3", "d_cathedral_54", Spot(649.9871, 675.85114, 10));
		AddSpawnPoint( "d_cathedral_54.Id3", "d_cathedral_54", Spot(526.2761, -588.2191, 10));
		AddSpawnPoint( "d_cathedral_54.Id3", "d_cathedral_54", Spot(299.1901, -889.0731, 10));
		AddSpawnPoint( "d_cathedral_54.Id3", "d_cathedral_54", Spot(286.65073, -1268.0209, 10));
		AddSpawnPoint( "d_cathedral_54.Id3", "d_cathedral_54", Spot(-346.25867, 1070.5328, 10));
		AddSpawnPoint( "d_cathedral_54.Id3", "d_cathedral_54", Spot(250.61433, 1211.5968, 10));
		AddSpawnPoint( "d_cathedral_54.Id3", "d_cathedral_54", Spot(-152.69186, -1264.7301, 10));
		AddSpawnPoint( "d_cathedral_54.Id3", "d_cathedral_54", Spot(-319.97467, -662.05066, 10));
		AddSpawnPoint( "d_cathedral_54.Id3", "d_cathedral_54", Spot(-27.935545, 1322.1263, 10));
		AddSpawnPoint( "d_cathedral_54.Id3", "d_cathedral_54", Spot(-1012.5563, -533.5138, 10));
		AddSpawnPoint( "d_cathedral_54.Id3", "d_cathedral_54", Spot(-771.4344, -943.5578, 10));
		AddSpawnPoint( "d_cathedral_54.Id3", "d_cathedral_54", Spot(928.6235, 1262.5305, 10));
		AddSpawnPoint( "d_cathedral_54.Id3", "d_cathedral_54", Spot(-1583.2675, -795.70197, 10));
		AddSpawnPoint( "d_cathedral_54.Id3", "d_cathedral_54", Spot(-1446.7112, -555.02185, 10));
		AddSpawnPoint( "d_cathedral_54.Id3", "d_cathedral_54", Spot(-1599.1642, 628.0443, 10));
		AddSpawnPoint( "d_cathedral_54.Id3", "d_cathedral_54", Spot(-1411.7725, 928.1237, 10));
		AddSpawnPoint( "d_cathedral_54.Id3", "d_cathedral_54", Spot(-738.2438, 1011.6883, 10));
		AddSpawnPoint( "d_cathedral_54.Id3", "d_cathedral_54", Spot(-491.13525, 639.0825, 10));

		// Velwriggler_Blue Spawn Points
		AddSpawnPoint( "d_cathedral_54.Id4", "d_cathedral_54", Spot(-1529.4812, 655.2267, 30));
		AddSpawnPoint( "d_cathedral_54.Id4", "d_cathedral_54", Spot(-799.3173, 847.5835, 30));
		AddSpawnPoint( "d_cathedral_54.Id4", "d_cathedral_54", Spot(-352.5702, 1058.591, 30));
		AddSpawnPoint( "d_cathedral_54.Id4", "d_cathedral_54", Spot(288.35754, 1260.3934, 30));
		AddSpawnPoint( "d_cathedral_54.Id4", "d_cathedral_54", Spot(-1530.9432, 848.71686, 30));
		AddSpawnPoint( "d_cathedral_54.Id4", "d_cathedral_54", Spot(-933.0069, 581.1041, 30));
		AddSpawnPoint( "d_cathedral_54.Id4", "d_cathedral_54", Spot(-940.0408, 996.6568, 30));
		AddSpawnPoint( "d_cathedral_54.Id4", "d_cathedral_54", Spot(-747.01776, 1003.5394, 30));
		AddSpawnPoint( "d_cathedral_54.Id4", "d_cathedral_54", Spot(-1223.0422, 954.67554, 30));
		AddSpawnPoint( "d_cathedral_54.Id4", "d_cathedral_54", Spot(-434.2434, 625.32666, 30));
		AddSpawnPoint( "d_cathedral_54.Id4", "d_cathedral_54", Spot(-5.8280106, 1354.2778, 30));
		AddSpawnPoint( "d_cathedral_54.Id4", "d_cathedral_54", Spot(-366.93814, 1347.5853, 30));
		AddSpawnPoint( "d_cathedral_54.Id4", "d_cathedral_54", Spot(-1192.836, 675.5003, 30));
		AddSpawnPoint( "d_cathedral_54.Id4", "d_cathedral_54", Spot(-666.4023, 672.32404, 30));
		AddSpawnPoint( "d_cathedral_54.Id4", "d_cathedral_54", Spot(-302.8189, -699.58124, 30));
		AddSpawnPoint( "d_cathedral_54.Id4", "d_cathedral_54", Spot(-141.37308, -1266.2496, 30));
		AddSpawnPoint( "d_cathedral_54.Id4", "d_cathedral_54", Spot(323.28925, -875.0402, 30));
		AddSpawnPoint( "d_cathedral_54.Id4", "d_cathedral_54", Spot(709.89685, -592.71204, 30));
		AddSpawnPoint( "d_cathedral_54.Id4", "d_cathedral_54", Spot(710.2906, -846.16486, 30));
		AddSpawnPoint( "d_cathedral_54.Id4", "d_cathedral_54", Spot(917.69653, -1272.9869, 30));
		AddSpawnPoint( "d_cathedral_54.Id4", "d_cathedral_54", Spot(1051.5321, -317.6997, 30));
		AddSpawnPoint( "d_cathedral_54.Id4", "d_cathedral_54", Spot(1016.8699, 312.71173, 30));
		AddSpawnPoint( "d_cathedral_54.Id4", "d_cathedral_54", Spot(1018.2178, 725.7707, 30));
		AddSpawnPoint( "d_cathedral_54.Id4", "d_cathedral_54", Spot(729.00476, 734.843, 30));
		AddSpawnPoint( "d_cathedral_54.Id4", "d_cathedral_54", Spot(874.195, 1015.9189, 30));
		AddSpawnPoint( "d_cathedral_54.Id4", "d_cathedral_54", Spot(632.86194, 1201.4789, 30));
		AddSpawnPoint( "d_cathedral_54.Id4", "d_cathedral_54", Spot(891.7957, 1344.0886, 30));
		AddSpawnPoint( "d_cathedral_54.Id4", "d_cathedral_54", Spot(147.19858, 1390.7931, 30));
		AddSpawnPoint( "d_cathedral_54.Id4", "d_cathedral_54", Spot(321.86298, 1156.9822, 30));
		AddSpawnPoint( "d_cathedral_54.Id4", "d_cathedral_54", Spot(818.7853, 1184.5271, 30));
		AddSpawnPoint( "d_cathedral_54.Id4", "d_cathedral_54", Spot(773.5322, 1048.7299, 30));
		AddSpawnPoint( "d_cathedral_54.Id4", "d_cathedral_54", Spot(862.7672, 1266.2683, 30));

		// Stoulet_Blue Spawn Points
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(857.3383, 661.96716, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(1080.811, 357.55133, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(651.60846, 606.03455, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(913.22955, 1079.1198, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(709.9402, 1115.9312, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(926.2864, 1227.5076, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(700.1361, 1302.1622, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-1478.5142, 873.34216, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-1442.636, 834.7335, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-1417.7424, 913.01434, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-1525.7006, 1015.906, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-1443.363, 976.98785, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-1369.91, 1013.5228, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-1461.8981, 1072.4719, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-1537.4347, 912.54614, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-1461.394, 919.4338, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-1397.9148, 811.67694, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-1162.2114, 974.46155, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-1109.569, 972.45465, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-1224.4154, 993.4804, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-890.5405, 1082.4513, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-775.9328, 1018.8104, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-859.42554, 973.3812, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-777.34985, 918.28357, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-841.0101, 895.33795, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-859.6785, 834.6604, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-923.5116, 847.9423, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-992.0983, 820.0355, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-990.4091, 870.48865, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-883.6259, 893.5427, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-954.4811, 952.5535, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-949.28784, 879.02716, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-1501.1755, 694.69244, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-1493.8533, 638.59393, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-1571.5813, 671.453, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-1559.1198, 615.6749, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-1224.0952, 631.473, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-1237.4417, 683.80115, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-1138.1375, 685.23926, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-1140.1658, 623.51416, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-883.5615, 598.0782, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-904.63495, 644.4591, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-947.6659, 634.02905, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-985.6246, 598.12415, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-704.61694, 643.8711, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-630.93036, 633.3754, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-605.75806, 690.50543, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-725.1252, 693.83746, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-478.06094, 602.008, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-480.12988, 655.1146, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-396.81067, 673.7958, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-380.80072, 614.66614, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-324.63498, 1100.3812, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-329.88934, 1030.6669, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-384.32114, 1096.7875, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-378.33707, 1008.5648, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-343.33246, 1376.4346, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-343.65408, 1305.2773, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-391.90027, 1368.0707, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-384.44635, 1276.5927, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-49.322422, 1318.6675, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(27.36744, 1321.236, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(27.79665, 1386.6498, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-50.53733, 1389.054, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(270.26157, 1215.0817, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(333.3149, 1252.3, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(310.78363, 1303.4807, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(241.48935, 1284.6995, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(765.0826, 1135.9923, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(879.62805, 1124.7957, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(879.7599, 1231.062, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(768.45526, 1246.2528, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(647.0145, 662.07684, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(700.06323, 659.91376, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(699.19257, 605.1565, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(857.1431, 617.30927, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(910.2884, 612.82324, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(919.8708, 664.40216, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(1040.1537, 354.1656, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(1103.0278, 312.73825, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(1078.6235, 406.8464, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(1125.4575, 350.96472, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-280.03647, -900.8941, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-262.82657, -1018.299, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-337.91138, -1038.6488, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-351.65024, -934.36536, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-305.72382, -1232.0125, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-254.32495, -1287.8278, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-364.48087, -1240.9348, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(-340.85956, -1312.0726, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(20.35799, -1310.2366, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(29.932844, -1257.4954, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(97.61721, -1257.631, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(125.28162, -1322.8605, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(269.9411, -1265.9612, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(324.08417, -1214.0345, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(261.6316, -1160.6526, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(212.7002, -1239.4427, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(252.72363, -807.48785, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(309.34378, -768.2223, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(309.59106, -669.9683, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(240.82635, -652.5666, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(505.32535, -611.3337, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(558.41534, -531.8184, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(603.3475, -613.8654, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(610.9733, -550.972, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(676.05664, -909.4564, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(725.75397, -956.9277, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(675.31537, -1026.0657, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(723.97754, -1013.9479, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(716.5597, -1310.5502, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(762.73676, -1267.4238, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(813.4448, -1295.7526, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(799.9849, -1338.0938, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(1061.6221, -168.0525, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(1064.144, -229.40488, 30));
		AddSpawnPoint( "d_cathedral_54.Id5", "d_cathedral_54", Spot(1000.8125, -237.11955, 30));

	}
}
