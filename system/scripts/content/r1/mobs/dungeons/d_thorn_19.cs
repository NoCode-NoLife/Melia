//--- Melia Script -----------------------------------------------------------
// Gate Route Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_thorn_19'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DThorn19MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_thorn_19", MonsterId.Thornball, Properties("MHP", 38767, "MINPATK", 999, "MAXPATK", 1130, "MINMATK", 999, "MAXMATK", 1130, "DEF", 185, "MDEF", 185));
		AddPropertyOverrides("d_thorn_19", MonsterId.Whip_Vine, Properties("MHP", 39519, "MINPATK", 1009, "MAXPATK", 1142, "MINMATK", 1009, "MAXMATK", 1142, "DEF", 186, "MDEF", 186));
		AddPropertyOverrides("d_thorn_19", MonsterId.Operor, Properties("MHP", 40287, "MINPATK", 1019, "MAXPATK", 1154, "MINMATK", 1019, "MAXMATK", 1154, "DEF", 187, "MDEF", 187));
		AddPropertyOverrides("d_thorn_19", MonsterId.Truffle, Properties("MHP", 41070, "MINPATK", 1029, "MAXPATK", 1167, "MINMATK", 1029, "MAXMATK", 1167, "DEF", 188, "MDEF", 188));
		AddPropertyOverrides("d_thorn_19", MonsterId.Velwriggler, Properties("MHP", 41868, "MINPATK", 1039, "MAXPATK", 1179, "MINMATK", 1039, "MAXMATK", 1179, "DEF", 189, "MDEF", 189));

		// Monster Spawners ---------------------------------

		AddSpawner("d_thorn_19.Id1", MonsterId.Rootcrystal_01, 18, 23, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("d_thorn_19.Id2", MonsterId.Thornball, 17, 22, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_19.Id3", MonsterId.Whip_Vine, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_19.Id4", MonsterId.Operor, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_19.Id5", MonsterId.Operor, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_19.Id6", MonsterId.Whip_Vine, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_19.Id7", MonsterId.Truffle, 42, 55, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_19.Id8", MonsterId.Velwriggler, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_19.Id9", MonsterId.Operor, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_19.Id10", MonsterId.Velwriggler, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_19.Id11", MonsterId.Thornball, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_19.Id12", MonsterId.Whip_Vine, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 514 Spawn Points
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(7, -3309, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(-156, -3328, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(-140, -3163, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(704, -3313, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(834, -3272, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(-973, -3090, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(-917, -3343, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(-173, -2241, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(-278, -2072, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(-341, -2387, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(-168, -2111, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(-1065, -2404, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(-1208, -2424, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(282, -1342, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(191, -1184, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(35, -1170, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(9, -1301, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(139, -1010, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(-580, -757, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(-820, -1313, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(-720, -1461, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(-778, -721, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(339, -23, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(277, 309, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(-44, 255, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(-615, 221, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(120, 1111, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(1011, 948, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(1226, 899, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(749, 2334, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(671, 2660, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(557, 2830, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(851, 2439, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(1716, 2622, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(1974, 1722, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(2128, 1677, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(2085, 1514, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(2040, 751, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(2226, 648, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(1979, -669, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(2436, -521, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(2014, 1607, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(1549, 2568, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(502, 2576, 200));
		AddSpawnPoint("d_thorn_19.Id1", "d_thorn_19", Rectangle(209, 868, 200));

		// 'Thornball' GenType 653 Spawn Points
		AddSpawnPoint("d_thorn_19.Id2", "d_thorn_19", Rectangle(625, 2674, 9999));
		AddSpawnPoint("d_thorn_19.Id2", "d_thorn_19", Rectangle(705, 2756, 9999));
		AddSpawnPoint("d_thorn_19.Id2", "d_thorn_19", Rectangle(593, 2739, 9999));
		AddSpawnPoint("d_thorn_19.Id2", "d_thorn_19", Rectangle(547, 2607, 9999));
		AddSpawnPoint("d_thorn_19.Id2", "d_thorn_19", Rectangle(610, 2559, 9999));
		AddSpawnPoint("d_thorn_19.Id2", "d_thorn_19", Rectangle(758, 2607, 9999));
		AddSpawnPoint("d_thorn_19.Id2", "d_thorn_19", Rectangle(0, -3455, 9999));
		AddSpawnPoint("d_thorn_19.Id2", "d_thorn_19", Rectangle(-182, -3311, 9999));
		AddSpawnPoint("d_thorn_19.Id2", "d_thorn_19", Rectangle(-315, -3323, 9999));
		AddSpawnPoint("d_thorn_19.Id2", "d_thorn_19", Rectangle(-116, -3166, 9999));
		AddSpawnPoint("d_thorn_19.Id2", "d_thorn_19", Rectangle(4, -3353, 9999));

		// 'Whip_Vine' GenType 654 Spawn Points
		AddSpawnPoint("d_thorn_19.Id3", "d_thorn_19", Rectangle(1098, 957, 9999));

		// 'Operor' GenType 655 Spawn Points
		AddSpawnPoint("d_thorn_19.Id4", "d_thorn_19", Rectangle(54, -1141, 9999));

		// 'Operor' GenType 658 Spawn Points
		AddSpawnPoint("d_thorn_19.Id5", "d_thorn_19", Rectangle(-244, -2174, 35));
		AddSpawnPoint("d_thorn_19.Id5", "d_thorn_19", Rectangle(-742, -1379, 35));
		AddSpawnPoint("d_thorn_19.Id5", "d_thorn_19", Rectangle(153, -1204, 35));
		AddSpawnPoint("d_thorn_19.Id5", "d_thorn_19", Rectangle(-389, -2398, 35));
		AddSpawnPoint("d_thorn_19.Id5", "d_thorn_19", Rectangle(-425, -2217, 35));
		AddSpawnPoint("d_thorn_19.Id5", "d_thorn_19", Rectangle(-169, -2017, 35));
		AddSpawnPoint("d_thorn_19.Id5", "d_thorn_19", Rectangle(-42, -2215, 35));
		AddSpawnPoint("d_thorn_19.Id5", "d_thorn_19", Rectangle(-159, -2361, 35));
		AddSpawnPoint("d_thorn_19.Id5", "d_thorn_19", Rectangle(-383, -2019, 35));
		AddSpawnPoint("d_thorn_19.Id5", "d_thorn_19", Rectangle(-915, -1373, 35));
		AddSpawnPoint("d_thorn_19.Id5", "d_thorn_19", Rectangle(-759, -1219, 35));
		AddSpawnPoint("d_thorn_19.Id5", "d_thorn_19", Rectangle(-816, -700, 35));
		AddSpawnPoint("d_thorn_19.Id5", "d_thorn_19", Rectangle(-587, -699, 35));
		AddSpawnPoint("d_thorn_19.Id5", "d_thorn_19", Rectangle(-640, -826, 35));
		AddSpawnPoint("d_thorn_19.Id5", "d_thorn_19", Rectangle(-624, -1528, 35));
		AddSpawnPoint("d_thorn_19.Id5", "d_thorn_19", Rectangle(-4, -1075, 35));
		AddSpawnPoint("d_thorn_19.Id5", "d_thorn_19", Rectangle(185, -996, 35));
		AddSpawnPoint("d_thorn_19.Id5", "d_thorn_19", Rectangle(15, -1285, 35));
		AddSpawnPoint("d_thorn_19.Id5", "d_thorn_19", Rectangle(181, -1420, 35));
		AddSpawnPoint("d_thorn_19.Id5", "d_thorn_19", Rectangle(373, -1278, 35));

		// 'Whip_Vine' GenType 659 Spawn Points
		AddSpawnPoint("d_thorn_19.Id6", "d_thorn_19", Rectangle(-765, -1366, 25));
		AddSpawnPoint("d_thorn_19.Id6", "d_thorn_19", Rectangle(195, -31, 25));
		AddSpawnPoint("d_thorn_19.Id6", "d_thorn_19", Rectangle(-650, -801, 25));
		AddSpawnPoint("d_thorn_19.Id6", "d_thorn_19", Rectangle(-1131, -2401, 25));
		AddSpawnPoint("d_thorn_19.Id6", "d_thorn_19", Rectangle(-1250, -2479, 25));
		AddSpawnPoint("d_thorn_19.Id6", "d_thorn_19", Rectangle(-1131, -2246, 25));
		AddSpawnPoint("d_thorn_19.Id6", "d_thorn_19", Rectangle(-1340, -2348, 25));
		AddSpawnPoint("d_thorn_19.Id6", "d_thorn_19", Rectangle(-945, -2428, 25));
		AddSpawnPoint("d_thorn_19.Id6", "d_thorn_19", Rectangle(-923, -1431, 25));
		AddSpawnPoint("d_thorn_19.Id6", "d_thorn_19", Rectangle(-732, -1193, 25));
		AddSpawnPoint("d_thorn_19.Id6", "d_thorn_19", Rectangle(-736, -1493, 25));
		AddSpawnPoint("d_thorn_19.Id6", "d_thorn_19", Rectangle(-481, -1416, 25));
		AddSpawnPoint("d_thorn_19.Id6", "d_thorn_19", Rectangle(-447, -1374, 25));
		AddSpawnPoint("d_thorn_19.Id6", "d_thorn_19", Rectangle(-415, -1408, 25));
		AddSpawnPoint("d_thorn_19.Id6", "d_thorn_19", Rectangle(-387, -1376, 25));
		AddSpawnPoint("d_thorn_19.Id6", "d_thorn_19", Rectangle(-587, -644, 25));
		AddSpawnPoint("d_thorn_19.Id6", "d_thorn_19", Rectangle(-827, -694, 25));
		AddSpawnPoint("d_thorn_19.Id6", "d_thorn_19", Rectangle(-828, -872, 25));
		AddSpawnPoint("d_thorn_19.Id6", "d_thorn_19", Rectangle(-493, -1383, 25));
		AddSpawnPoint("d_thorn_19.Id6", "d_thorn_19", Rectangle(-808, -2377, 25));
		AddSpawnPoint("d_thorn_19.Id6", "d_thorn_19", Rectangle(-812, -2325, 25));
		AddSpawnPoint("d_thorn_19.Id6", "d_thorn_19", Rectangle(-775, -2323, 25));
		AddSpawnPoint("d_thorn_19.Id6", "d_thorn_19", Rectangle(-778, -2353, 25));
		AddSpawnPoint("d_thorn_19.Id6", "d_thorn_19", Rectangle(-757, -2367, 25));

		// 'Truffle' GenType 662 Spawn Points
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(1090, 967, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(2124, 636, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(896, 806, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(874, 984, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(1123, 1115, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(1328, 986, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(1279, 853, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(1084, 783, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(972, 1125, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(1961, 732, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(2152, 894, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(2340, 708, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(2094, 772, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(1947, 606, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(73, -3177, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(16, -3358, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(-68, -3243, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(72, -3448, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(-90, -3482, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(-200, -3274, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(873, -3305, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(770, -3321, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(740, -3229, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(984, -3234, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(640, -3337, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(-335, -2139, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(-285, -1963, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(-117, -2143, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(-157, -2228, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(-456, -2338, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(63, -1434, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(-55, -1235, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(311, -1158, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(227, -1332, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(113, -996, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(-812, -787, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(-718, -725, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(-649, -628, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(-535, -788, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(-866, -705, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(-506, 190, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(-634, 145, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(-764, 192, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(-734, 296, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(-484, 319, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(208, -99, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(115, -34, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(300, -14, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(372, 35, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(169, -182, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(1005, 909, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(1013, 1007, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(1136, 1041, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(1236, 985, 35));
		AddSpawnPoint("d_thorn_19.Id7", "d_thorn_19", Rectangle(1116, 862, 35));

		// 'Velwriggler' GenType 665 Spawn Points
		AddSpawnPoint("d_thorn_19.Id8", "d_thorn_19", Rectangle(-640, 231, 9999));

		// 'Operor' GenType 669 Spawn Points
		AddSpawnPoint("d_thorn_19.Id9", "d_thorn_19", Rectangle(1659, 2629, 30));
		AddSpawnPoint("d_thorn_19.Id9", "d_thorn_19", Rectangle(1487, 2504, 30));
		AddSpawnPoint("d_thorn_19.Id9", "d_thorn_19", Rectangle(1488, 2648, 30));
		AddSpawnPoint("d_thorn_19.Id9", "d_thorn_19", Rectangle(1639, 2501, 30));
		AddSpawnPoint("d_thorn_19.Id9", "d_thorn_19", Rectangle(1767, 2714, 30));
		AddSpawnPoint("d_thorn_19.Id9", "d_thorn_19", Rectangle(1837, 2563, 30));
		AddSpawnPoint("d_thorn_19.Id9", "d_thorn_19", Rectangle(1881, 2632, 30));
		AddSpawnPoint("d_thorn_19.Id9", "d_thorn_19", Rectangle(1769, 2457, 30));
		AddSpawnPoint("d_thorn_19.Id9", "d_thorn_19", Rectangle(1935, 2383, 30));
		AddSpawnPoint("d_thorn_19.Id9", "d_thorn_19", Rectangle(1318, 2460, 30));

		// 'Velwriggler' GenType 671 Spawn Points
		AddSpawnPoint("d_thorn_19.Id10", "d_thorn_19", Rectangle(-725, -808, 30));
		AddSpawnPoint("d_thorn_19.Id10", "d_thorn_19", Rectangle(-555, -695, 30));
		AddSpawnPoint("d_thorn_19.Id10", "d_thorn_19", Rectangle(-682, -1517, 30));
		AddSpawnPoint("d_thorn_19.Id10", "d_thorn_19", Rectangle(-381, -1410, 30));
		AddSpawnPoint("d_thorn_19.Id10", "d_thorn_19", Rectangle(-103, -1392, 30));
		AddSpawnPoint("d_thorn_19.Id10", "d_thorn_19", Rectangle(-14, -1171, 30));
		AddSpawnPoint("d_thorn_19.Id10", "d_thorn_19", Rectangle(208, -1020, 30));
		AddSpawnPoint("d_thorn_19.Id10", "d_thorn_19", Rectangle(331, -1272, 30));
		AddSpawnPoint("d_thorn_19.Id10", "d_thorn_19", Rectangle(164, -1424, 30));
		AddSpawnPoint("d_thorn_19.Id10", "d_thorn_19", Rectangle(-933, -1349, 30));
		AddSpawnPoint("d_thorn_19.Id10", "d_thorn_19", Rectangle(-190, -895, 30));
		AddSpawnPoint("d_thorn_19.Id10", "d_thorn_19", Rectangle(-715, -1217, 30));
		AddSpawnPoint("d_thorn_19.Id10", "d_thorn_19", Rectangle(159, -1207, 30));

		// 'Thornball' GenType 673 Spawn Points
		AddSpawnPoint("d_thorn_19.Id11", "d_thorn_19", Rectangle(77, -3487, 25));
		AddSpawnPoint("d_thorn_19.Id11", "d_thorn_19", Rectangle(-110, -3415, 25));
		AddSpawnPoint("d_thorn_19.Id11", "d_thorn_19", Rectangle(-204, -3081, 25));
		AddSpawnPoint("d_thorn_19.Id11", "d_thorn_19", Rectangle(64, -3308, 25));
		AddSpawnPoint("d_thorn_19.Id11", "d_thorn_19", Rectangle(-72, -3054, 25));
		AddSpawnPoint("d_thorn_19.Id11", "d_thorn_19", Rectangle(586, -3362, 25));
		AddSpawnPoint("d_thorn_19.Id11", "d_thorn_19", Rectangle(695, -3252, 25));
		AddSpawnPoint("d_thorn_19.Id11", "d_thorn_19", Rectangle(794, -3343, 25));
		AddSpawnPoint("d_thorn_19.Id11", "d_thorn_19", Rectangle(812, -3172, 25));
		AddSpawnPoint("d_thorn_19.Id11", "d_thorn_19", Rectangle(901, -3262, 25));
		AddSpawnPoint("d_thorn_19.Id11", "d_thorn_19", Rectangle(-85, -3276, 25));

		// 'Whip_Vine' GenType 674 Spawn Points
		AddSpawnPoint("d_thorn_19.Id12", "d_thorn_19", Rectangle(-38, -3430, 20));
		AddSpawnPoint("d_thorn_19.Id12", "d_thorn_19", Rectangle(-205, -3121, 20));
		AddSpawnPoint("d_thorn_19.Id12", "d_thorn_19", Rectangle(-243, -3340, 20));
		AddSpawnPoint("d_thorn_19.Id12", "d_thorn_19", Rectangle(-73, -3277, 20));
		AddSpawnPoint("d_thorn_19.Id12", "d_thorn_19", Rectangle(-87, -3045, 20));
		AddSpawnPoint("d_thorn_19.Id12", "d_thorn_19", Rectangle(150, -3447, 20));
		AddSpawnPoint("d_thorn_19.Id12", "d_thorn_19", Rectangle(-377, -2313, 20));
		AddSpawnPoint("d_thorn_19.Id12", "d_thorn_19", Rectangle(-275, -2152, 20));
		AddSpawnPoint("d_thorn_19.Id12", "d_thorn_19", Rectangle(-142, -2303, 20));
		AddSpawnPoint("d_thorn_19.Id12", "d_thorn_19", Rectangle(-386, -2030, 20));
		AddSpawnPoint("d_thorn_19.Id12", "d_thorn_19", Rectangle(-261, -1854, 20));
		AddSpawnPoint("d_thorn_19.Id12", "d_thorn_19", Rectangle(-519, -2145, 20));
		AddSpawnPoint("d_thorn_19.Id12", "d_thorn_19", Rectangle(-560, -2238, 20));
		AddSpawnPoint("d_thorn_19.Id12", "d_thorn_19", Rectangle(-576, -2302, 20));
		AddSpawnPoint("d_thorn_19.Id12", "d_thorn_19", Rectangle(-531, -2266, 20));
	}
}
