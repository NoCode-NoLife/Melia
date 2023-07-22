//--- Melia Script -----------------------------------------------------------
// Overlong Bridge Valley Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_rokas_26'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FRokas26MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_rokas_26.Id1", MonsterId.Rootcrystal_05, min: 12, max: 16, respawn: TimeSpan.FromMilliseconds(5000));
		AddSpawner("f_rokas_26.Id2", MonsterId.Wendigo, min: 19, max: 25);
		AddSpawner("f_rokas_26.Id3", MonsterId.Dumaro, min: 49, max: 65);
		AddSpawner("f_rokas_26.Id4", MonsterId.Dumaro, min: 9, max: 12);
		AddSpawner("f_rokas_26.Id5", MonsterId.Wendigo_Bow, min: 12, max: 15);
		AddSpawner("f_rokas_26.Id6", MonsterId.Wendigo_Mage, min: 8, max: 10);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_05' GenType 500 Spawn Points
		AddSpawnPoint("f_rokas_26.Id1", "f_rokas_26", Rectangle(2000, -26, 30));
		AddSpawnPoint("f_rokas_26.Id1", "f_rokas_26", Rectangle(1636, -97, 30));
		AddSpawnPoint("f_rokas_26.Id1", "f_rokas_26", Rectangle(1198, -556, 30));
		AddSpawnPoint("f_rokas_26.Id1", "f_rokas_26", Rectangle(1183, -1271, 30));
		AddSpawnPoint("f_rokas_26.Id1", "f_rokas_26", Rectangle(821, -962, 30));
		AddSpawnPoint("f_rokas_26.Id1", "f_rokas_26", Rectangle(1350, -1846, 30));
		AddSpawnPoint("f_rokas_26.Id1", "f_rokas_26", Rectangle(261, -1448, 30));
		AddSpawnPoint("f_rokas_26.Id1", "f_rokas_26", Rectangle(-362, -1716, 30));
		AddSpawnPoint("f_rokas_26.Id1", "f_rokas_26", Rectangle(-630, -774, 30));
		AddSpawnPoint("f_rokas_26.Id1", "f_rokas_26", Rectangle(76, -331, 30));
		AddSpawnPoint("f_rokas_26.Id1", "f_rokas_26", Rectangle(167, 527, 30));
		AddSpawnPoint("f_rokas_26.Id1", "f_rokas_26", Rectangle(-578, 499, 30));
		AddSpawnPoint("f_rokas_26.Id1", "f_rokas_26", Rectangle(-1004, 319, 30));
		AddSpawnPoint("f_rokas_26.Id1", "f_rokas_26", Rectangle(-1210, 844, 30));
		AddSpawnPoint("f_rokas_26.Id1", "f_rokas_26", Rectangle(-1078, 1765, 30));
		AddSpawnPoint("f_rokas_26.Id1", "f_rokas_26", Rectangle(10, 1774, 30));
		AddSpawnPoint("f_rokas_26.Id1", "f_rokas_26", Rectangle(508, -1930, 30));

		// 'Wendigo' GenType 513 Spawn Points
		AddSpawnPoint("f_rokas_26.Id2", "f_rokas_26", Rectangle(885, -1011, 20));
		AddSpawnPoint("f_rokas_26.Id2", "f_rokas_26", Rectangle(-602, -670, 20));
		AddSpawnPoint("f_rokas_26.Id2", "f_rokas_26", Rectangle(-239, -347, 20));
		AddSpawnPoint("f_rokas_26.Id2", "f_rokas_26", Rectangle(-477, -1029, 20));
		AddSpawnPoint("f_rokas_26.Id2", "f_rokas_26", Rectangle(36, -129, 20));
		AddSpawnPoint("f_rokas_26.Id2", "f_rokas_26", Rectangle(995, -1240, 20));
		AddSpawnPoint("f_rokas_26.Id2", "f_rokas_26", Rectangle(-71, 577, 20));
		AddSpawnPoint("f_rokas_26.Id2", "f_rokas_26", Rectangle(-521, 387, 20));
		AddSpawnPoint("f_rokas_26.Id2", "f_rokas_26", Rectangle(-650, 352, 20));
		AddSpawnPoint("f_rokas_26.Id2", "f_rokas_26", Rectangle(-1244, 237, 20));
		AddSpawnPoint("f_rokas_26.Id2", "f_rokas_26", Rectangle(-1197, 423, 20));
		AddSpawnPoint("f_rokas_26.Id2", "f_rokas_26", Rectangle(-1063, 245, 20));
		AddSpawnPoint("f_rokas_26.Id2", "f_rokas_26", Rectangle(-1256, 779, 20));
		AddSpawnPoint("f_rokas_26.Id2", "f_rokas_26", Rectangle(-1172, 868, 20));
		AddSpawnPoint("f_rokas_26.Id2", "f_rokas_26", Rectangle(-1282, 1304, 20));
		AddSpawnPoint("f_rokas_26.Id2", "f_rokas_26", Rectangle(-1087, 1623, 20));
		AddSpawnPoint("f_rokas_26.Id2", "f_rokas_26", Rectangle(-1098, 1370, 20));
		AddSpawnPoint("f_rokas_26.Id2", "f_rokas_26", Rectangle(-100, 1630, 20));
		AddSpawnPoint("f_rokas_26.Id2", "f_rokas_26", Rectangle(111, 1699, 20));
		AddSpawnPoint("f_rokas_26.Id2", "f_rokas_26", Rectangle(61, 1548, 20));
		AddSpawnPoint("f_rokas_26.Id2", "f_rokas_26", Rectangle(46, 643, 20));
		AddSpawnPoint("f_rokas_26.Id2", "f_rokas_26", Rectangle(-56, 681, 20));
		AddSpawnPoint("f_rokas_26.Id2", "f_rokas_26", Rectangle(-7, -378, 20));
		AddSpawnPoint("f_rokas_26.Id2", "f_rokas_26", Rectangle(-588, -891, 20));
		AddSpawnPoint("f_rokas_26.Id2", "f_rokas_26", Rectangle(-395, -474, 20));
		AddSpawnPoint("f_rokas_26.Id2", "f_rokas_26", Rectangle(-108, -230, 20));
		AddSpawnPoint("f_rokas_26.Id2", "f_rokas_26", Rectangle(-26, 499, 20));
		AddSpawnPoint("f_rokas_26.Id2", "f_rokas_26", Rectangle(-1356, 157, 20));
		AddSpawnPoint("f_rokas_26.Id2", "f_rokas_26", Rectangle(-1373, 300, 20));

		// 'Dumaro' GenType 516 Spawn Points
		AddSpawnPoint("f_rokas_26.Id3", "f_rokas_26", Rectangle(1337, -590, 9999));

		// 'Dumaro' GenType 518 Spawn Points
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-1197, 1448, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-205, -415, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-229, -253, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-108, -148, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-105, -319, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-21, -433, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(41, -234, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-1458, 1306, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-1294, 1238, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-1361, 1523, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-1084, 1755, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-1192, 1636, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-985, 1562, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-1031, 1348, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(1192, -626, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(1090, -737, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(977, -954, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(1047, -1062, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(1129, -1212, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(1261, -1925, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(1110, -2037, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(1062, -1956, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(972, -1824, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(1093, -1772, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(1178, -1873, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(1300, -1824, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(1127, -1665, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(1071, -1329, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(903, -1096, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-540, -956, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-526, -588, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(3, -320, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(106, -135, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(59, -49, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-30, -183, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-116, -404, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-292, -376, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(94, -311, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(21, 581, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(97, 675, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-166, 488, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-61, 628, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-609, 483, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-586, 281, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-1044, 334, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-1266, 316, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-1285, 438, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-1431, 232, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-1248, 82, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-1331, 233, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-1132, 240, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-1013, 436, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-1194, 478, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-1047, 204, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-1058, 1491, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-1078, 1670, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-1239, 1548, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-1404, 1399, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-1133, 1272, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-1201, 1361, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-25, 1808, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(191, 1729, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(-12, 1636, 20));
		AddSpawnPoint("f_rokas_26.Id4", "f_rokas_26", Rectangle(142, 1800, 20));

		// 'Wendigo_Bow' GenType 525 Spawn Points
		AddSpawnPoint("f_rokas_26.Id5", "f_rokas_26", Rectangle(874, -1013, 30));
		AddSpawnPoint("f_rokas_26.Id5", "f_rokas_26", Rectangle(990, -869, 30));
		AddSpawnPoint("f_rokas_26.Id5", "f_rokas_26", Rectangle(1004, -1156, 30));
		AddSpawnPoint("f_rokas_26.Id5", "f_rokas_26", Rectangle(-1168, 154, 30));
		AddSpawnPoint("f_rokas_26.Id5", "f_rokas_26", Rectangle(-1166, 313, 30));
		AddSpawnPoint("f_rokas_26.Id5", "f_rokas_26", Rectangle(-1353, 320, 30));
		AddSpawnPoint("f_rokas_26.Id5", "f_rokas_26", Rectangle(-1349, 1310, 30));
		AddSpawnPoint("f_rokas_26.Id5", "f_rokas_26", Rectangle(-1160, 1624, 30));
		AddSpawnPoint("f_rokas_26.Id5", "f_rokas_26", Rectangle(-954, 1440, 30));
		AddSpawnPoint("f_rokas_26.Id5", "f_rokas_26", Rectangle(-62, 1537, 30));
		AddSpawnPoint("f_rokas_26.Id5", "f_rokas_26", Rectangle(72, 1753, 30));
		AddSpawnPoint("f_rokas_26.Id5", "f_rokas_26", Rectangle(-1098, 490, 30));
		AddSpawnPoint("f_rokas_26.Id5", "f_rokas_26", Rectangle(-1323, 870, 30));
		AddSpawnPoint("f_rokas_26.Id5", "f_rokas_26", Rectangle(-1209, 884, 30));
		AddSpawnPoint("f_rokas_26.Id5", "f_rokas_26", Rectangle(-1136, 1435, 30));
		AddSpawnPoint("f_rokas_26.Id5", "f_rokas_26", Rectangle(-970, 1731, 30));
		AddSpawnPoint("f_rokas_26.Id5", "f_rokas_26", Rectangle(-141, 1700, 30));
		AddSpawnPoint("f_rokas_26.Id5", "f_rokas_26", Rectangle(163, 1628, 30));
		AddSpawnPoint("f_rokas_26.Id5", "f_rokas_26", Rectangle(82, 1509, 30));

		// 'Wendigo_Mage' GenType 526 Spawn Points
		AddSpawnPoint("f_rokas_26.Id6", "f_rokas_26", Rectangle(894, -994, 30));
		AddSpawnPoint("f_rokas_26.Id6", "f_rokas_26", Rectangle(-1342, 131, 30));
		AddSpawnPoint("f_rokas_26.Id6", "f_rokas_26", Rectangle(-1094, 475, 30));
		AddSpawnPoint("f_rokas_26.Id6", "f_rokas_26", Rectangle(-948, 1600, 30));
		AddSpawnPoint("f_rokas_26.Id6", "f_rokas_26", Rectangle(-1276, 1439, 30));
		AddSpawnPoint("f_rokas_26.Id6", "f_rokas_26", Rectangle(-36, 1707, 30));
		AddSpawnPoint("f_rokas_26.Id6", "f_rokas_26", Rectangle(71, 1597, 30));
		AddSpawnPoint("f_rokas_26.Id6", "f_rokas_26", Rectangle(1001, -1160, 30));
		AddSpawnPoint("f_rokas_26.Id6", "f_rokas_26", Rectangle(1008, -835, 30));
		AddSpawnPoint("f_rokas_26.Id6", "f_rokas_26", Rectangle(988, -1917, 30));
		AddSpawnPoint("f_rokas_26.Id6", "f_rokas_26", Rectangle(1235, -2035, 30));
		AddSpawnPoint("f_rokas_26.Id6", "f_rokas_26", Rectangle(1203, -1768, 30));
		AddSpawnPoint("f_rokas_26.Id6", "f_rokas_26", Rectangle(1092, -1873, 30));
		AddSpawnPoint("f_rokas_26.Id6", "f_rokas_26", Rectangle(-70, 1573, 30));
	}
}
