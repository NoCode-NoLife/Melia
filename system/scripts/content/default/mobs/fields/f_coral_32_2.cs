//--- Melia Script -----------------------------------------------------------
// f_coral_32_2
//
//--- Description -----------------------------------------------------------
// Sets up the f_coral_32_2 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FCoral322MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("f_coral_32_2.Id1", MonsterId.Colimen_Blue, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_coral_32_2.Id2", MonsterId.Repusbunny_Red, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_coral_32_2.Id3", MonsterId.Repusbunny_Bow_Red, 5, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_coral_32_2.Id4", MonsterId.Colimen_Blue, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_coral_32_2.Id5", MonsterId.Repusbunny_Red, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_coral_32_2.Id6", MonsterId.Rootcrystal_01, 20, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Colimen_Blue Spawn Points
		AddSpawnPoint( "f_coral_32_2.Id1", "f_coral_32_2", Spot(-901.19183, 101.52144, 30));
		AddSpawnPoint( "f_coral_32_2.Id1", "f_coral_32_2", Spot(-634.86127, -78.88909, 30));
		AddSpawnPoint( "f_coral_32_2.Id1", "f_coral_32_2", Spot(-491.85947, -244.17793, 30));
		AddSpawnPoint( "f_coral_32_2.Id1", "f_coral_32_2", Spot(-1115.5428, -475.88538, 30));
		AddSpawnPoint( "f_coral_32_2.Id1", "f_coral_32_2", Spot(-17.464594, 412.49854, 30));
		AddSpawnPoint( "f_coral_32_2.Id1", "f_coral_32_2", Spot(44.681755, 606.3757, 30));
		AddSpawnPoint( "f_coral_32_2.Id1", "f_coral_32_2", Spot(-106.20581, 614.13837, 30));
		AddSpawnPoint( "f_coral_32_2.Id1", "f_coral_32_2", Spot(-21.727152, 43.89516, 30));
		AddSpawnPoint( "f_coral_32_2.Id1", "f_coral_32_2", Spot(-36.663223, -186.91174, 30));
		AddSpawnPoint( "f_coral_32_2.Id1", "f_coral_32_2", Spot(-825.7704, 657.5292, 30));
		AddSpawnPoint( "f_coral_32_2.Id1", "f_coral_32_2", Spot(-672.4448, 824.75134, 30));
		AddSpawnPoint( "f_coral_32_2.Id1", "f_coral_32_2", Spot(-869.39056, 832.3472, 30));
		AddSpawnPoint( "f_coral_32_2.Id1", "f_coral_32_2", Spot(-1412.6537, 661.32587, 30));
		AddSpawnPoint( "f_coral_32_2.Id1", "f_coral_32_2", Spot(1142.8182, -491.1721, 30));
		AddSpawnPoint( "f_coral_32_2.Id1", "f_coral_32_2", Spot(1280.3414, -788.56055, 30));
		AddSpawnPoint( "f_coral_32_2.Id1", "f_coral_32_2", Spot(-270.17154, 783.7119, 30));
		AddSpawnPoint( "f_coral_32_2.Id1", "f_coral_32_2", Spot(525.144, 1090.6245, 30));
		AddSpawnPoint( "f_coral_32_2.Id1", "f_coral_32_2", Spot(1119.0026, -762.58496, 30));
		AddSpawnPoint( "f_coral_32_2.Id1", "f_coral_32_2", Spot(901.9194, 983.425, 30));
		AddSpawnPoint( "f_coral_32_2.Id1", "f_coral_32_2", Spot(1009.3216, 1200.5776, 30));
		AddSpawnPoint( "f_coral_32_2.Id1", "f_coral_32_2", Spot(920.26166, 1473.9749, 30));
		AddSpawnPoint( "f_coral_32_2.Id1", "f_coral_32_2", Spot(1214.8444, 823.66174, 30));
		AddSpawnPoint( "f_coral_32_2.Id1", "f_coral_32_2", Spot(1042.9672, 950.67126, 30));
		AddSpawnPoint( "f_coral_32_2.Id1", "f_coral_32_2", Spot(1482.9471, 1019.7353, 30));
		AddSpawnPoint( "f_coral_32_2.Id1", "f_coral_32_2", Spot(1346.168, 498.85272, 30));
		AddSpawnPoint( "f_coral_32_2.Id1", "f_coral_32_2", Spot(896.8286, 424.74997, 30));
		AddSpawnPoint( "f_coral_32_2.Id1", "f_coral_32_2", Spot(877.4791, 33.352837, 30));
		AddSpawnPoint( "f_coral_32_2.Id1", "f_coral_32_2", Spot(790.70325, -186.60368, 30));
		AddSpawnPoint( "f_coral_32_2.Id1", "f_coral_32_2", Spot(639.2765, -302.6023, 30));
		AddSpawnPoint( "f_coral_32_2.Id1", "f_coral_32_2", Spot(231.08919, -401.8789, 30));
		AddSpawnPoint( "f_coral_32_2.Id1", "f_coral_32_2", Spot(-203.86319, -538.0442, 30));
		AddSpawnPoint( "f_coral_32_2.Id1", "f_coral_32_2", Spot(-67.64223, -876.9888, 30));
		AddSpawnPoint( "f_coral_32_2.Id1", "f_coral_32_2", Spot(102.20348, -721.2697, 30));
		AddSpawnPoint( "f_coral_32_2.Id1", "f_coral_32_2", Spot(-1088.5646, 292.4016, 30));
		AddSpawnPoint( "f_coral_32_2.Id1", "f_coral_32_2", Spot(-1282.878, 485.2695, 30));
		AddSpawnPoint( "f_coral_32_2.Id1", "f_coral_32_2", Spot(790.49585, 179.14966, 30));

		// Repusbunny_Red Spawn Points
		AddSpawnPoint( "f_coral_32_2.Id2", "f_coral_32_2", Spot(-1529.7478, 674.2455, 30));
		AddSpawnPoint( "f_coral_32_2.Id2", "f_coral_32_2", Spot(-1544.3466, 843.3505, 30));
		AddSpawnPoint( "f_coral_32_2.Id2", "f_coral_32_2", Spot(-1309.7615, 735.8104, 30));
		AddSpawnPoint( "f_coral_32_2.Id2", "f_coral_32_2", Spot(1217.8492, 978.1937, 30));
		AddSpawnPoint( "f_coral_32_2.Id2", "f_coral_32_2", Spot(1355.5896, 1143.5657, 30));
		AddSpawnPoint( "f_coral_32_2.Id2", "f_coral_32_2", Spot(1495.825, 874.9305, 30));
		AddSpawnPoint( "f_coral_32_2.Id2", "f_coral_32_2", Spot(753.67065, 1441.1467, 30));
		AddSpawnPoint( "f_coral_32_2.Id2", "f_coral_32_2", Spot(171.85365, -526.5951, 30));
		AddSpawnPoint( "f_coral_32_2.Id2", "f_coral_32_2", Spot(-29.979374, 38.82912, 30));
		AddSpawnPoint( "f_coral_32_2.Id2", "f_coral_32_2", Spot(-18.605528, -148.84705, 30));
		AddSpawnPoint( "f_coral_32_2.Id2", "f_coral_32_2", Spot(-20.851206, -237.19028, 30));
		AddSpawnPoint( "f_coral_32_2.Id2", "f_coral_32_2", Spot(-26.30931, 684.23346, 30));
		AddSpawnPoint( "f_coral_32_2.Id2", "f_coral_32_2", Spot(-491.94736, 925.7809, 30));
		AddSpawnPoint( "f_coral_32_2.Id2", "f_coral_32_2", Spot(-105.82044, 364.2583, 30));
		AddSpawnPoint( "f_coral_32_2.Id2", "f_coral_32_2", Spot(-97.37552, 513.19556, 30));
		AddSpawnPoint( "f_coral_32_2.Id2", "f_coral_32_2", Spot(745.0737, 323.83362, 30));
		AddSpawnPoint( "f_coral_32_2.Id2", "f_coral_32_2", Spot(730.0442, 8.86322, 30));
		AddSpawnPoint( "f_coral_32_2.Id2", "f_coral_32_2", Spot(730.3767, 103.1389, 30));
		AddSpawnPoint( "f_coral_32_2.Id2", "f_coral_32_2", Spot(1031.7518, 514.4126, 30));
		AddSpawnPoint( "f_coral_32_2.Id2", "f_coral_32_2", Spot(-797.24457, 941.73016, 30));
		AddSpawnPoint( "f_coral_32_2.Id2", "f_coral_32_2", Spot(1070.372, -879.43896, 30));
		AddSpawnPoint( "f_coral_32_2.Id2", "f_coral_32_2", Spot(-1101.8544, 434.7329, 30));
		AddSpawnPoint( "f_coral_32_2.Id2", "f_coral_32_2", Spot(-1578.3711, 1052.9418, 30));
		AddSpawnPoint( "f_coral_32_2.Id2", "f_coral_32_2", Spot(-1191.4098, 272.68344, 30));
		AddSpawnPoint( "f_coral_32_2.Id2", "f_coral_32_2", Spot(-654.8469, -260.71753, 30));
		AddSpawnPoint( "f_coral_32_2.Id2", "f_coral_32_2", Spot(-754.70764, -80.49388, 30));
		AddSpawnPoint( "f_coral_32_2.Id2", "f_coral_32_2", Spot(-531.5215, -105.49068, 30));

		// Repusbunny_Bow_Red Spawn Points
		AddSpawnPoint( "f_coral_32_2.Id3", "f_coral_32_2", Spot(1044.2761, -741.6384, 30));
		AddSpawnPoint( "f_coral_32_2.Id3", "f_coral_32_2", Spot(1286.4705, -662.6881, 30));
		AddSpawnPoint( "f_coral_32_2.Id3", "f_coral_32_2", Spot(1374.4572, -687.42035, 30));
		AddSpawnPoint( "f_coral_32_2.Id3", "f_coral_32_2", Spot(1275.9685, -804.5056, 30));
		AddSpawnPoint( "f_coral_32_2.Id3", "f_coral_32_2", Spot(1106.0428, -563.8598, 30));

		// Colimen_Blue Spawn Points
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-106.17651, 91.48285, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-38.415222, 293.4485, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-55.855335, 384.2516, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(37.783195, -98.45178, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-21.521551, -254.48575, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-87.22088, -20.159786, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-1459.7998, -678.16, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-1479.1147, -583.7677, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-1405.862, -516.3299, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-1408.534, -452.5352, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-1208.4912, -601.9921, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-1286.8168, -704.4149, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-1343.213, -755.8898, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-1373.5773, -633.3212, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-1263.1488, -782.481, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-1158.0718, -607.4721, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-1180.7955, -694.3969, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-1296.0962, -465.59915, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-1219.7224, -493.36514, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-1103.5806, -516.7538, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-1064.0614, -576.11786, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-684.458, -45.692383, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-547.595, -29.052998, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-864.8626, 158.04073, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-947.68115, 88.103485, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-933.24023, 20.464664, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-933.6464, -39.059376, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-872.2186, -87.51489, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-904.3573, 62.596455, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-742.622, 105.92368, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-711.23987, -154.88799, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-669.25867, -224.74998, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-550.9471, -265.6634, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-439.51486, -260.51312, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-298.39407, -694.22876, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-270.01392, -623.5922, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-212.71916, -590.7606, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-156.4108, -514.3866, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-108.95334, -470.37024, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-185.35544, -642.7152, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-150.55038, -702.1677, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-54.879105, -818.5797, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(15.958763, -797.5457, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(44.097023, -722.555, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-93.137184, -569.4059, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(77.51734, -467.26675, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(64.77353, -549.29816, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(4.6734996, -592.7768, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(165.53256, -585.92065, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(228.5543, -501.88934, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(201.61635, -444.57663, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-10.973865, -320.10846, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(23.776575, -455.34262, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-67.850174, -458.2819, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-74.287025, 176.68686, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-3.24255, 272.22354, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(66.88061, 126.80762, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(101.53746, 71.32039, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-83.39177, 22.360611, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-152.07816, 18.172058, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(-143.42923, 60.45266, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(1104.0542, -735.40875, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(1070.6393, -594.6871, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(1165.9991, -586.31445, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(1396.047, -825.4328, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(1335.787, -836.31433, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(1236.0289, -771.215, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(1215.8761, -859.3664, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(1192.5197, -931.1278, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(1017.3333, -827.82825, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(1080.7257, -782.932, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(552.4403, -122.9014, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(442.29953, -47.09709, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(588.14166, 49.071327, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(636.9968, -73.659775, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(661.64056, -238.83575, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(742.93176, -200.62936, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(744.11444, -130.20366, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(820.03564, -13.470497, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(759.7714, -42.153183, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(783.6347, 20.966068, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(753.34076, 248.40808, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(780.66565, 367.48535, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(735.31134, 425.04724, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(805.2539, 433.93158, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(823.9716, 283.9864, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(974.649, 424.93005, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(1024.4036, 360.98566, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(964.2446, 350.77032, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(877.53955, 349.56204, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(803.8122, 108.37106, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(868.14124, 128.17488, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(1128.5273, 301.22302, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(1093.3027, 401.77017, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(1030.7404, 421.41125, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(976.1464, 523.19745, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(917.32324, 516.7908, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(1378.5149, 480.7282, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(1399.6743, 523.49194, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(1438.8376, 555.53564, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(1436.1617, 500.49414, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(1314.4136, 477.19412, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(1235.5933, 765.9699, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(1180.3549, 831.15814, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(1173.7178, 919.77386, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(1252.9745, 941.7274, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(1393.3794, 1142.7476, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(1462.1024, 1056.9387, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(1525.0618, 977.8823, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(1520.2104, 857.8743, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(1439.1277, 803.9283, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(1353.4127, 868.1315, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(1330.9387, 993.2316, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(996.9388, 961.02765, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(940.09546, 955.8937, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(1002.4999, 1232.1156, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(987.7259, 1266.249, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(952.6917, 1255.9271, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(908.0792, 1344.5565, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(741.6436, 1393.9458, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(804.94464, 1539.186, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(818.1671, 1472.6508, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(871.4396, 1485.1982, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(917.39764, 1666.699, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(891.3073, 1730.833, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(913.7418, 1625.4642, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(987.8549, 1695.0884, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(951.5771, 1522.662, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(982.92706, 1388.7472, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(1022.8821, 1533.8611, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(1085.9073, 1543.2666, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(1127.1069, 1508.3975, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(1120.3792, 1457.8787, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(1076.0591, 1387.3832, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(339.233, 1288.7365, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(382.6665, 1292.3586, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(577.7323, 1143.9401, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(662.7624, 1033.7198, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(628.18787, 1002.4224, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(598.93134, 1030.8428, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(563.71643, 1085.9167, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(334.36688, 1225.0049, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(291.57974, 1270.0101, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(382.0844, 1159.4851, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(575.2215, 1211.1573, 30));
		AddSpawnPoint( "f_coral_32_2.Id4", "f_coral_32_2", Spot(705.34644, 962.1108, 30));

		// Repusbunny_Red Spawn Points
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-792.0519, 683.3976, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-689.5757, 542.58545, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-825.581, 851.367, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-1500.1813, 1022.2164, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-1590.4028, 958.4071, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-1336.2891, 997.00195, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-1240.7076, 954.5042, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-1270.4042, 893.8548, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-1226.6721, 754.71216, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-1425.7413, 562.58234, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-1461.3468, 687.5138, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-1550.9277, 794.7909, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-1620.7712, 763.1212, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-1655.6226, 695.209, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-1626.2546, 620.4788, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-1738.4368, 872.93207, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-1453.0082, 910.13916, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-1210.6461, 652.8557, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-1150.62, 664.6561, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-1133.7832, 608.8563, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-1328.9631, 601.16113, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-1399.8151, 507.48383, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-1284.3708, 425.37195, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-1254.2745, 378.9741, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-1070.8384, 387.2316, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-1112.8732, 449.05234, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-1163.0144, 281.78107, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-1003.7972, 272.56195, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(42.401802, 494.05185, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(50.200165, 669.9077, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(10.60788, 721.8547, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-63.790142, 670.558, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-106.14724, 824.8264, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-197.7655, 803.80646, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-211.31638, 686.6716, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-181.51825, 609.9555, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-166.52675, 534.7384, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-180.95538, 374.64102, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-118.90683, 468.86365, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-7.0817103, 336.5873, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-617.2394, 536.0243, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-612.1893, 658.0124, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-816.92487, 929.01166, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-694.6515, 788.1451, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-556.763, 899.5528, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-540.4595, 814.9703, 20));
		AddSpawnPoint( "f_coral_32_2.Id5", "f_coral_32_2", Spot(-427.18137, 898.43805, 20));

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "f_coral_32_2.Id6", "f_coral_32_2", Spot(-148.299, -601.0885, 100));
		AddSpawnPoint( "f_coral_32_2.Id6", "f_coral_32_2", Spot(675.4402, -134.28331, 100));
		AddSpawnPoint( "f_coral_32_2.Id6", "f_coral_32_2", Spot(1184.9175, -718.5732, 100));
		AddSpawnPoint( "f_coral_32_2.Id6", "f_coral_32_2", Spot(910.2928, 280.6727, 100));
		AddSpawnPoint( "f_coral_32_2.Id6", "f_coral_32_2", Spot(1383.9127, 953.105, 100));
		AddSpawnPoint( "f_coral_32_2.Id6", "f_coral_32_2", Spot(881.6523, 965.89026, 100));
		AddSpawnPoint( "f_coral_32_2.Id6", "f_coral_32_2", Spot(407.2434, 1211.8699, 100));
		AddSpawnPoint( "f_coral_32_2.Id6", "f_coral_32_2", Spot(109.679, 1563.5278, 100));
		AddSpawnPoint( "f_coral_32_2.Id6", "f_coral_32_2", Spot(-33.05883, 473.60764, 100));
		AddSpawnPoint( "f_coral_32_2.Id6", "f_coral_32_2", Spot(-0.47803164, -65.1526, 100));
		AddSpawnPoint( "f_coral_32_2.Id6", "f_coral_32_2", Spot(-827.0446, -56.68098, 100));
		AddSpawnPoint( "f_coral_32_2.Id6", "f_coral_32_2", Spot(-1434.6465, 724.6088, 100));
		AddSpawnPoint( "f_coral_32_2.Id6", "f_coral_32_2", Spot(-700.5162, 788.0335, 100));
		AddSpawnPoint( "f_coral_32_2.Id6", "f_coral_32_2", Spot(-1383.8616, -454.37082, 100));
		AddSpawnPoint( "f_coral_32_2.Id6", "f_coral_32_2", Spot(-974.97876, -827.5457, 100));
		AddSpawnPoint( "f_coral_32_2.Id6", "f_coral_32_2", Spot(-472.6439, -232.62415, 100));
		AddSpawnPoint( "f_coral_32_2.Id6", "f_coral_32_2", Spot(957.2631, 1568.86, 100));
		AddSpawnPoint( "f_coral_32_2.Id6", "f_coral_32_2", Spot(-1122.7201, 346.91663, 100));
		AddSpawnPoint( "f_coral_32_2.Id6", "f_coral_32_2", Spot(-1644.9044, 1048.7014, 100));
		AddSpawnPoint( "f_coral_32_2.Id6", "f_coral_32_2", Spot(-44.868565, 945.6539, 100));

	}
}
