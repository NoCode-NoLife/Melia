//--- Melia Script -----------------------------------------------------------
// Ziburynas Forest Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_bracken_43_3'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FBracken433MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_bracken_43_3.Id1", MonsterId.Vilkas_Soldier, min: 22, max: 29);
		AddSpawner("f_bracken_43_3.Id2", MonsterId.Vilkas_Archer, min: 17, max: 22);
		AddSpawner("f_bracken_43_3.Id3", MonsterId.Rootcrystal_03, min: 12, max: 15, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("f_bracken_43_3.Id4", MonsterId.Rompelnuka, min: 12, max: 15);
		AddSpawner("f_bracken_43_3.Id5", MonsterId.Vilkas_Archer, min: 8, max: 10);
		AddSpawner("f_bracken_43_3.Id6", MonsterId.Vilkas_Soldier, min: 15, max: 20);
		AddSpawner("f_bracken_43_3.Id7", MonsterId.Vilkas_Soldier, amount: 3, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("f_bracken_43_3.Id8", MonsterId.Vilkas_Archer, amount: 2, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("f_bracken_43_3.Id9", MonsterId.Rompelnuka, min: 8, max: 10, respawn: TimeSpan.FromMilliseconds(60000));

		// Monster Spawn Points -----------------------------

		// 'Vilkas_Soldier' GenType 20 Spawn Points
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(-1500, -760, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(-1353, -926, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(-1139, 1312, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(-79, 507, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(-127, 237, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(-132, -50, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(-936, 1456, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(-1295, 1063, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(-1375, 1428, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(-962, 988, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(-1027, 1137, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(-929, 33, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(-680, 108, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(219, -1173, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(179, -918, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(342, -1045, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(199, -251, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(536, -205, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(716, -11, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(617, 366, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(359, 672, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(1327, -356, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(2318, -496, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(1570, 1257, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(2108, 1826, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(2298, 1567, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(427, 1435, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(312, 1482, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(308, 1326, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(1923, -422, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(1098, -109, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(1691, 1326, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(1398, 1108, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(2214, 1548, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(2398, 1791, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(2086, 1632, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(1961, 1376, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(192, 1556, 40));

		// 'Vilkas_Archer' GenType 21 Spawn Points
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(246, -1139, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(157, -997, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(-1384, -799, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(-1554, -716, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(-1375, -558, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(80, -213, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(471, -184, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(787, -10, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(641, 66, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(1334, -376, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(1515, -450, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(-1448, -947, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(2124, -448, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(2433, -456, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(660, 510, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(794, 295, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(1530, 1305, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(1693, 1267, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(2193, 1584, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(2396, 1606, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(2075, 1787, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(-191, -49, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(288, -913, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(248, -807, 40));

		// 'Rootcrystal_03' GenType 22 Spawn Points
		AddSpawnPoint("f_bracken_43_3.Id3", "f_bracken_43_3", Rectangle(345, 1454, 10));
		AddSpawnPoint("f_bracken_43_3.Id3", "f_bracken_43_3", Rectangle(427, 602, 10));
		AddSpawnPoint("f_bracken_43_3.Id3", "f_bracken_43_3", Rectangle(-138, 295, 10));
		AddSpawnPoint("f_bracken_43_3.Id3", "f_bracken_43_3", Rectangle(-1094, 1206, 10));
		AddSpawnPoint("f_bracken_43_3.Id3", "f_bracken_43_3", Rectangle(-790, 80, 10));
		AddSpawnPoint("f_bracken_43_3.Id3", "f_bracken_43_3", Rectangle(-1253, -767, 10));
		AddSpawnPoint("f_bracken_43_3.Id3", "f_bracken_43_3", Rectangle(7, -182, 10));
		AddSpawnPoint("f_bracken_43_3.Id3", "f_bracken_43_3", Rectangle(224, -969, 10));
		AddSpawnPoint("f_bracken_43_3.Id3", "f_bracken_43_3", Rectangle(561, -141, 10));
		AddSpawnPoint("f_bracken_43_3.Id3", "f_bracken_43_3", Rectangle(1157, -195, 10));
		AddSpawnPoint("f_bracken_43_3.Id3", "f_bracken_43_3", Rectangle(2480, -451, 10));
		AddSpawnPoint("f_bracken_43_3.Id3", "f_bracken_43_3", Rectangle(1588, 1242, 10));
		AddSpawnPoint("f_bracken_43_3.Id3", "f_bracken_43_3", Rectangle(2278, 1685, 10));
		AddSpawnPoint("f_bracken_43_3.Id3", "f_bracken_43_3", Rectangle(1024, 774, 10));
		AddSpawnPoint("f_bracken_43_3.Id3", "f_bracken_43_3", Rectangle(1674, -468, 10));

		// 'Rompelnuka' GenType 23 Spawn Points
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(-1014, -19, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(-1013, 157, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(-756, 286, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(-636, 193, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(-692, -23, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(-791, 81, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(-821, 180, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(-942, 15, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(-1100, 0, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(-775, -104, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(2057, 1640, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(2075, 1778, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(2268, 1831, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(2252, 1712, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(2305, 1582, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(224, 1395, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(220, 1573, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(406, 1668, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(447, 1483, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(267, 1008, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(148, 1648, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(390, 1467, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(-1595, -833, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(-1428, -987, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(-1267, -750, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(-1369, -627, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(-1530, -674, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(-1287, -906, 40));

		// 'Vilkas_Archer' GenType 39 Spawn Points
		AddSpawnPoint("f_bracken_43_3.Id5", "f_bracken_43_3", Rectangle(-1315, 1071, 40));
		AddSpawnPoint("f_bracken_43_3.Id5", "f_bracken_43_3", Rectangle(-1283, 1279, 40));
		AddSpawnPoint("f_bracken_43_3.Id5", "f_bracken_43_3", Rectangle(-1026, 1465, 40));
		AddSpawnPoint("f_bracken_43_3.Id5", "f_bracken_43_3", Rectangle(-1047, 1177, 40));
		AddSpawnPoint("f_bracken_43_3.Id5", "f_bracken_43_3", Rectangle(-1115, 1015, 40));
		AddSpawnPoint("f_bracken_43_3.Id5", "f_bracken_43_3", Rectangle(-833, 1247, 40));
		AddSpawnPoint("f_bracken_43_3.Id5", "f_bracken_43_3", Rectangle(-1405, 1457, 40));
		AddSpawnPoint("f_bracken_43_3.Id5", "f_bracken_43_3", Rectangle(-934, 926, 40));
		AddSpawnPoint("f_bracken_43_3.Id5", "f_bracken_43_3", Rectangle(2420, -383, 40));
		AddSpawnPoint("f_bracken_43_3.Id5", "f_bracken_43_3", Rectangle(2232, -608, 40));
		AddSpawnPoint("f_bracken_43_3.Id5", "f_bracken_43_3", Rectangle(1979, -471, 40));
		AddSpawnPoint("f_bracken_43_3.Id5", "f_bracken_43_3", Rectangle(1388, -402, 40));
		AddSpawnPoint("f_bracken_43_3.Id5", "f_bracken_43_3", Rectangle(1101, -192, 40));
		AddSpawnPoint("f_bracken_43_3.Id5", "f_bracken_43_3", Rectangle(250, 895, 40));
		AddSpawnPoint("f_bracken_43_3.Id5", "f_bracken_43_3", Rectangle(257, 1102, 40));
		AddSpawnPoint("f_bracken_43_3.Id5", "f_bracken_43_3", Rectangle(957, 692, 40));
		AddSpawnPoint("f_bracken_43_3.Id5", "f_bracken_43_3", Rectangle(1155, 908, 40));
		AddSpawnPoint("f_bracken_43_3.Id5", "f_bracken_43_3", Rectangle(1309, 1059, 40));
		AddSpawnPoint("f_bracken_43_3.Id5", "f_bracken_43_3", Rectangle(1384, 1059, 40));

		// 'Vilkas_Soldier' GenType 40 Spawn Points
		AddSpawnPoint("f_bracken_43_3.Id6", "f_bracken_43_3", Rectangle(530, -160, 9999));

		// 'Vilkas_Soldier' GenType 41 Spawn Points
		AddSpawnPoint("f_bracken_43_3.Id7", "f_bracken_43_3", Rectangle(-919, 37, 20));
		AddSpawnPoint("f_bracken_43_3.Id7", "f_bracken_43_3", Rectangle(-739, 66, 20));
		AddSpawnPoint("f_bracken_43_3.Id7", "f_bracken_43_3", Rectangle(-633, 81, 20));

		// 'Vilkas_Archer' GenType 42 Spawn Points
		AddSpawnPoint("f_bracken_43_3.Id8", "f_bracken_43_3", Rectangle(-668, -51, 20));
		AddSpawnPoint("f_bracken_43_3.Id8", "f_bracken_43_3", Rectangle(-931, 114, 20));

		// 'Rompelnuka' GenType 43 Spawn Points
		AddSpawnPoint("f_bracken_43_3.Id9", "f_bracken_43_3", Rectangle(2232, -480, 20));
		AddSpawnPoint("f_bracken_43_3.Id9", "f_bracken_43_3", Rectangle(2352, -584, 20));
		AddSpawnPoint("f_bracken_43_3.Id9", "f_bracken_43_3", Rectangle(2450, -357, 20));
		AddSpawnPoint("f_bracken_43_3.Id9", "f_bracken_43_3", Rectangle(2521, -465, 20));
		AddSpawnPoint("f_bracken_43_3.Id9", "f_bracken_43_3", Rectangle(2077, -484, 20));
		AddSpawnPoint("f_bracken_43_3.Id9", "f_bracken_43_3", Rectangle(2541, -216, 20));
		AddSpawnPoint("f_bracken_43_3.Id9", "f_bracken_43_3", Rectangle(2182, -578, 20));
		AddSpawnPoint("f_bracken_43_3.Id9", "f_bracken_43_3", Rectangle(2280, -426, 20));
		AddSpawnPoint("f_bracken_43_3.Id9", "f_bracken_43_3", Rectangle(2398, -531, 20));
		AddSpawnPoint("f_bracken_43_3.Id9", "f_bracken_43_3", Rectangle(2136, -415, 20));
	}
}
