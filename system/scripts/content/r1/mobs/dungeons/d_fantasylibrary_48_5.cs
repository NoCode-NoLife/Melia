//--- Melia Script -----------------------------------------------------------
// d_fantasylibrary_48_5
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Valandis Room 91' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DFantasylibrary485MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_fantasylibrary_48_5", MonsterId.Cretobiang, Properties("MHP", 573536, "MINPATK", 7876, "MAXPATK", 9582, "MINMATK", 7876, "MAXMATK", 9582, "DEF", 114300, "MDEF", 114300));
		AddPropertyOverrides("d_fantasylibrary_48_5", MonsterId.Creto, Properties("MHP", 577074, "MINPATK", 7921, "MAXPATK", 9638, "MINMATK", 7921, "MAXMATK", 9638, "DEF", 116050, "MDEF", 116050));
		AddPropertyOverrides("d_fantasylibrary_48_5", MonsterId.Lapindion, Properties("MHP", 580692, "MINPATK", 7968, "MAXPATK", 9695, "MINMATK", 7968, "MAXMATK", 9695, "DEF", 117839, "MDEF", 117839));
		AddPropertyOverrides("d_fantasylibrary_48_5", MonsterId.Llapindal_Ribbon, Properties("MHP", 584390, "MINPATK", 8015, "MAXPATK", 9753, "MINMATK", 8015, "MAXMATK", 9753, "DEF", 119667, "MDEF", 119667));
		AddPropertyOverrides("d_fantasylibrary_48_5", MonsterId.Wis, Properties("MHP", 588166, "MINPATK", 8064, "MAXPATK", 9813, "MINMATK", 8064, "MAXMATK", 9813, "DEF", 121534, "MDEF", 121534));
		AddPropertyOverrides("d_fantasylibrary_48_5", MonsterId.Flamel, Properties("MHP", 592018, "MINPATK", 8114, "MAXPATK", 9874, "MINMATK", 8114, "MAXMATK", 9874, "DEF", 123439, "MDEF", 123439));
		AddPropertyOverrides("d_fantasylibrary_48_5", MonsterId.Boss_Warpulis_Q1, Properties("MHP", 4976141, "MINPATK", 25717, "MAXPATK", 31298, "MINMATK", 25717, "MAXMATK", 31298, "DEF", 394950, "MDEF", 394950));

		// Monster Spawners ---------------------------------

		AddSpawner("d_fantasylibrary_48_5.Id1", MonsterId.Rootcrystal_03, 12, 15, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_fantasylibrary_48_5.Id2", MonsterId.Cretobiang, 4, 5, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_fantasylibrary_48_5.Id3", MonsterId.Creto, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_fantasylibrary_48_5.Id4", MonsterId.Lapindion, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_fantasylibrary_48_5.Id5", MonsterId.Llapindal_Ribbon, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_fantasylibrary_48_5.Id6", MonsterId.Wis, 57, 75, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_fantasylibrary_48_5.Id7", MonsterId.Flamel, 4, 5, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_03' GenType 5 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-2040.5541, -862.7679, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-2118.135, -682.93304, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-1862.1036, -634.0119, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-1968.7677, -732.81256, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-1509.7205, -897.46185, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-1312.3508, -880.3666, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-1537.0419, -739.3789, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-1435.7375, -779.6097, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-1330.389, -625.2581, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-1498.5135, -593.3636, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-1699.6616, -684.78015, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-1430.6666, -436.9268, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-1436.1981, -250.4535, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-1546.9526, -24.969524, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-1612.7987, 127.32033, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-1638.2543, -53.35759, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-1400.7002, -18.10271, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-1336.0996, -156.56494, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-993.4456, -94.60935, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-729.30145, -126.68138, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-612.899, 169.22035, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-380.09988, 222.00427, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-459.7416, -52.92485, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-517.0675, -169.96378, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-169.84125, 77.43787, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-207.01428, 74.226074, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-77.13764, 220.02544, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(189.264, 111.63547, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-740.2243, -742.38666, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-629.2318, -540.175, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-480.85413, -649.7854, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-117.09636, -691.3582, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(8.565752, -565.564, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-201.23277, -607.182, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-501.64633, -428.64825, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(839.3347, -708.501, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(773.4715, -443.44196, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(974.01117, -632.1836, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(1049.824, -421.28946, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(922.1739, -484.1099, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(791.2308, -89.26023, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(833.1295, 167.6002, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(1107.7545, -25.662292, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(1581.822, 157.57973, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(1725.5884, 302.06613, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(1713.8224, 9.075275, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(1472.6505, 25.595345, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(1643.0189, 675.21735, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(1423.7786, 734.8835, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(1549.6388, 904.6862, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(1593.3114, 660.2129, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(1018.7273, 377.10373, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(751.1952, 493.46036, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(888.4796, 731.8691, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(1147.2815, 590.63885, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(1047.0643, 600.13007, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(917.16907, 1086.8759, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(745.7804, 1265.6431, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(788.0237, 1527.6692, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(1201.8455, 1517.7711, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(1200.6858, 1191.6542, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-608.32886, 726.7296, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-481.56717, 851.50995, 100));

		// 'Cretobiang' GenType 17 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_5.Id2", "d_fantasylibrary_48_5", Rectangle(1655.7007, 84.54757, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id2", "d_fantasylibrary_48_5", Rectangle(908.58563, -529.7151, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id2", "d_fantasylibrary_48_5", Rectangle(788.17255, 114.76385, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id2", "d_fantasylibrary_48_5", Rectangle(1158.97, 1410.8195, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id2", "d_fantasylibrary_48_5", Rectangle(777.48193, 1415.3451, 40));

		// 'Creto' GenType 18 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(-110.75199, 325.65332, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(-56.53294, 402.86325, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(81.502914, 397.2384, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(1.7919979, 270.6527, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(-175.58221, 102.93576, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(4.4536843, 166.3398, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(29.495571, -0.5722637, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(126.98671, 181.4246, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(240.05896, 93.49811, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(188.02396, 434.59344, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(290.3077, 285.06613, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(841.99225, -696.166, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(738.6009, -594.5555, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(846.2971, -481.43784, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(981.9179, -577.0399, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(941.2147, -712.22437, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(916.79346, -401.8012, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(760.2807, -488.215, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(1029.9983, -366.93634, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(1499.9487, 5.01459, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(1591.5942, 252.93224, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(1477.938, 193.18196, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(1739.1449, 71.48567, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(1759.8628, 285.9405, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(1608.3832, 134.93002, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(783.028, -112.49083, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(928.9464, -153.2482, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(1034.2759, -15.533215, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(886.04425, 54.34909, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(783.48474, 251.31834, 40));

		// 'Lapindion' GenType 19 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-1485.8705, -260.5768, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-1537.3345, -199.59322, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-1319.7925, -186.3153, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-1337.5175, -89.443436, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-1470.6565, -73.97952, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-1387.9131, -14.780281, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-1524.134, -7.9285564, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-1609.7128, 83.71829, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-1540.0344, 163.00856, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-1376.6375, 95.21954, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-621.50684, 205.14337, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-522.1622, 222.80142, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-812.94385, 109.51405, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-803.3686, 232.66199, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-621.3804, 78.29288, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-496.47424, 61.555668, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-623.8936, -1.4030068, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-554.6179, -100.92776, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-643.173, -170.84157, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-734.9369, -181.69284, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-672.1294, -245.4095, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-672.1294, -245.4095, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-430.16418, -166.22215, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-291.9043, 162.74269, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-562.80994, 383.11694, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(953.6613, 186.20996, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(1093.057, 81.36451, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(835.65326, 321.57635, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(1048.6191, 410.96368, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(938.5261, 485.1018, 40));

		// 'Llapindal_Ribbon' GenType 20 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-2091.8118, -812.2216, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-2051.0608, -760.6741, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-2038.9291, -630.4269, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-1956.9385, -653.2664, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-1907.6041, -767.9739, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-1658.7819, -790.3313, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-1610.797, -631.2547, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-1526.3162, -684.8821, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-1573.3558, -899.68005, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-1503.1393, -834.4161, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-1413.6499, -852.0373, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-1357.7427, -798.851, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-1300.3607, -766.2697, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-1412.7332, -719.4189, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-1397.3478, -607.7824, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-731.95874, 643.3182, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-739.4551, 731.80194, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-601.66095, 652.68884, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-578.43933, 790.67334, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-726.3929, 811.08844, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-734.52716, 881.55585, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-567.00366, 864.3127, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-515.5073, 686.17505, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-412.007, 804.7863, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-417.88828, 759.6994, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(958.87836, 599.0691, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(851.9978, 661.82385, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(769.2574, 597.2632, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(1120.5242, 629.9244, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(971.0678, 389.45413, 40));

		// 'Wis' GenType 21 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-2141.2292, -754.1717, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-1985.1085, -818.6576, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-2020.9358, -698.757, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-1618.9636, -712.3659, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-1577.682, -828.8236, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-1480.1757, -658.95514, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-1338.5316, -682.60443, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-1302.4362, -835.4049, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-1437.6127, -924.48315, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-1448.7473, -536.1695, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-1489.7296, -424.5009, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-1439.6351, -344.09158, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-1529.2878, -117.812, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-1608.5935, -13.281261, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-1467.3727, 94.405304, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-1309.3744, 41.902813, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-1412.973, -139.5835, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-1256.2922, -95.273445, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-1162.5623, -68.21299, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-1027.2144, -84.55408, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-858.93066, -124.50708, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-700.0417, 180.55061, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-752.317, 116.55002, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-680.8698, -54.37601, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-493.52234, 154.24503, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-401.34735, 109.45195, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-523.56696, -42.96296, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-48.244102, 75.74079, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-124.03154, 199.21077, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-36.960243, 338.94846, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(126.31331, 83.9277, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(215.5819, 199.03506, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(180.09377, 342.09958, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-703.37384, 676.413, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-675.2682, 837.2301, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-511.93518, 793.4395, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(382.40546, 210.8778, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(475.7803, 228.8828, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(571.82135, 185.08064, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(857.8276, -311.69882, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(775.8123, -362.81042, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(994.1325, -483.96927, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(841.1913, -583.2969, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(736.1716, -676.41113, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(1024.1155, -678.60046, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(882.9985, -51.66799, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(811.4829, 19.181932, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(975.4434, 87.78636, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(880.30585, 233.57892, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(987.7769, 299.75586, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(874.9404, 412.14514, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(846.1201, 570.3287, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(1048.7695, 485.71704, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(986.66187, 671.10156, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(1484.5076, 106.06631, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(1596.7168, 32.5715, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(1676.7637, 171.21802, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(1492.5442, 635.9184, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(1544.3745, 822.0757, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(1722.6366, 714.569, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(815.2011, 1198.2483, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(711.54407, 1352.374, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(819.08875, 1416.1766, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(1089.3899, 1401.6803, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(1020.7903, 1288.216, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(1103.0116, 1173.9531, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(1641.7365, 598.9771, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(1449.1768, 734.93805, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(1552.5116, 895.8567, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(1690.2917, 822.1358, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(1589.835, 711.61237, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(1439.468, 845.1163, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(1514.0807, 521.7094, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(972.76263, 1500.1295, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(933.5483, 1195.042, 40));

		// 'Flamel' GenType 22 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_5.Id7", "d_fantasylibrary_48_5", Rectangle(1040.5834, 227.32278, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id7", "d_fantasylibrary_48_5", Rectangle(815.24036, 468.51355, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id7", "d_fantasylibrary_48_5", Rectangle(1581.5822, 709.26044, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id7", "d_fantasylibrary_48_5", Rectangle(720.04016, 1249.6447, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id7", "d_fantasylibrary_48_5", Rectangle(1136.3184, 1177.593, 40));
	}
}
