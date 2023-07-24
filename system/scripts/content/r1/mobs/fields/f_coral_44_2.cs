//--- Melia Script -----------------------------------------------------------
// Iotheo Coast Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_coral_44_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FCoral442MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_coral_44_2.Id1", MonsterId.VarleGunner, min: 42, max: 55, tendency: TendencyType.Peaceful);
		AddSpawner("f_coral_44_2.Id2", MonsterId.VarleHench, min: 37, max: 49, tendency: TendencyType.Peaceful);
		AddSpawner("f_coral_44_2.Id3", MonsterId.NimrahLancer, min: 33, max: 43, tendency: TendencyType.Aggressive);
		AddSpawner("f_coral_44_2.Id4", MonsterId.Nimrahsoldier, min: 21, max: 28, tendency: TendencyType.Aggressive);
		AddSpawner("f_coral_44_2.Id5", MonsterId.NimrahDuke, min: 4, max: 5, tendency: TendencyType.Aggressive);
		AddSpawner("f_coral_44_2.Id6", MonsterId.Rootcrystal_03, min: 23, max: 30, respawn: TimeSpan.FromMilliseconds(30000), tendency: TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'VarleGunner' GenType 20 Spawn Points
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(169, 1452, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(99, 1210, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(95, 997, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(23, 1045, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(98, 1086, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(395, 972, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(472, 1053, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(460, 1142, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(-81, 689, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(66, 586, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(-215, 610, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(53, 244, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(124, 279, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(-465, 359, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(-529, -53, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(-344, 113, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(-843, -32, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(-734, -120, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(-573, 203, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(-755, 198, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(474, 471, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(665, 560, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(547, 245, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(751, 207, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(1097, 1702, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(930, 333, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(1047, 393, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(799, 789, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(766, 689, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(1149, 1228, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(986, 652, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(937, 1217, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(1009, 791, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(1669, 327, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(1545, 456, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(1465, 489, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(1406, 277, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(1457, 223, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(1525, 208, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(-1491, -47, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(-1404, -20, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(-304, -685, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(-261, -480, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(264, -392, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(264, -477, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(290, -555, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(106, -231, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(-114, -272, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(466, -1153, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(515, -877, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(743, -444, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(1010, -367, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(1009, -530, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(1073, -1236, 20));
		AddSpawnPoint("f_coral_44_2.Id1", "f_coral_44_2", Rectangle(1191, -1241, 20));

		// 'VarleHench' GenType 21 Spawn Points
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(504, 1603, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(430, 1511, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(531, 1506, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(397, 1424, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(112, 1306, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(137, 1366, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(274, 1149, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(232, 1287, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(359, 1221, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(338, 1322, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(523, 1276, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(246, 1030, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(-31, 594, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(37, 468, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(-194, 503, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(-339, 465, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(-315, 325, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(-462, 139, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(-461, 11, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(-620, -86, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(-247, 931, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(-132, 982, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(-429, 971, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(1451, 344, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(1563, 374, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(1558, 285, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(-690, 9, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(-294, 215, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(-172, -386, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(-11, -453, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(61, -381, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(-235, -587, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(195, -443, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(251, -273, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(-477, 305, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(-72, 348, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(121, 1156, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(424, 1062, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(-546, 220, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(-678, 104, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(31, -230, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(23, -576, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(203, -563, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(274, 341, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(498, 367, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(-1001, -34, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(-67, -726, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(85, 1039, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(-179, 1150, 40));
		AddSpawnPoint("f_coral_44_2.Id2", "f_coral_44_2", Rectangle(-158, 416, 40));

		// 'NimrahLancer' GenType 22 Spawn Points
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(620, 474, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(671, 347, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(830, 454, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(938, 436, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(961, 527, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(912, 647, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(926, 747, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(756, 553, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(905, 1268, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(1061, 1405, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(938, 1360, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(1065, 1544, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(956, 1563, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(1208, 1539, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(874, 1542, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(1178, 1321, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(72, 383, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(4, 312, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(-101, 294, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(-183, 404, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(-53, 400, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(-183, 207, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(-628, 76, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(-751, 69, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(-1012, -42, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(-923, 291, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(-1373, 304, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(-1228, 350, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(-1250, 473, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(-1434, 397, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(-1430, -285, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(-1487, -169, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(-1590, -42, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(-1556, -271, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(-1381, -135, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(-1262, -133, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(-1254, -47, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(-71, 56, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(-52, -111, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(-129, -541, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(-176, -688, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(180, -558, 40));
		AddSpawnPoint("f_coral_44_2.Id3", "f_coral_44_2", Rectangle(-23, -340, 40));

		// 'Nimrahsoldier' GenType 23 Spawn Points
		AddSpawnPoint("f_coral_44_2.Id4", "f_coral_44_2", Rectangle(21, -744, 40));
		AddSpawnPoint("f_coral_44_2.Id4", "f_coral_44_2", Rectangle(38, -584, 40));
		AddSpawnPoint("f_coral_44_2.Id4", "f_coral_44_2", Rectangle(257, -628, 40));
		AddSpawnPoint("f_coral_44_2.Id4", "f_coral_44_2", Rectangle(-66, -662, 40));
		AddSpawnPoint("f_coral_44_2.Id4", "f_coral_44_2", Rectangle(522, -1057, 40));
		AddSpawnPoint("f_coral_44_2.Id4", "f_coral_44_2", Rectangle(560, -954, 40));
		AddSpawnPoint("f_coral_44_2.Id4", "f_coral_44_2", Rectangle(690, -940, 40));
		AddSpawnPoint("f_coral_44_2.Id4", "f_coral_44_2", Rectangle(662, -1090, 40));
		AddSpawnPoint("f_coral_44_2.Id4", "f_coral_44_2", Rectangle(1114, -1140, 40));
		AddSpawnPoint("f_coral_44_2.Id4", "f_coral_44_2", Rectangle(1261, -1303, 40));
		AddSpawnPoint("f_coral_44_2.Id4", "f_coral_44_2", Rectangle(1347, -1255, 40));
		AddSpawnPoint("f_coral_44_2.Id4", "f_coral_44_2", Rectangle(1273, -1154, 40));
		AddSpawnPoint("f_coral_44_2.Id4", "f_coral_44_2", Rectangle(1259, -1061, 40));
		AddSpawnPoint("f_coral_44_2.Id4", "f_coral_44_2", Rectangle(1193, -1010, 40));
		AddSpawnPoint("f_coral_44_2.Id4", "f_coral_44_2", Rectangle(1038, -1076, 40));
		AddSpawnPoint("f_coral_44_2.Id4", "f_coral_44_2", Rectangle(1031, -878, 40));
		AddSpawnPoint("f_coral_44_2.Id4", "f_coral_44_2", Rectangle(902, -656, 40));
		AddSpawnPoint("f_coral_44_2.Id4", "f_coral_44_2", Rectangle(975, -441, 40));
		AddSpawnPoint("f_coral_44_2.Id4", "f_coral_44_2", Rectangle(911, -493, 40));
		AddSpawnPoint("f_coral_44_2.Id4", "f_coral_44_2", Rectangle(880, -388, 40));
		AddSpawnPoint("f_coral_44_2.Id4", "f_coral_44_2", Rectangle(943, -290, 40));
		AddSpawnPoint("f_coral_44_2.Id4", "f_coral_44_2", Rectangle(826, -236, 40));
		AddSpawnPoint("f_coral_44_2.Id4", "f_coral_44_2", Rectangle(919, -180, 40));
		AddSpawnPoint("f_coral_44_2.Id4", "f_coral_44_2", Rectangle(-931, -619, 40));
		AddSpawnPoint("f_coral_44_2.Id4", "f_coral_44_2", Rectangle(-870, -698, 40));
		AddSpawnPoint("f_coral_44_2.Id4", "f_coral_44_2", Rectangle(-784, -649, 40));
		AddSpawnPoint("f_coral_44_2.Id4", "f_coral_44_2", Rectangle(155, -764, 40));
		AddSpawnPoint("f_coral_44_2.Id4", "f_coral_44_2", Rectangle(625, -1009, 40));

		// 'NimrahDuke' GenType 24 Spawn Points
		AddSpawnPoint("f_coral_44_2.Id5", "f_coral_44_2", Rectangle(-696, -616, 40));
		AddSpawnPoint("f_coral_44_2.Id5", "f_coral_44_2", Rectangle(-41, -570, 40));
		AddSpawnPoint("f_coral_44_2.Id5", "f_coral_44_2", Rectangle(149, -490, 40));
		AddSpawnPoint("f_coral_44_2.Id5", "f_coral_44_2", Rectangle(1079, -975, 40));
		AddSpawnPoint("f_coral_44_2.Id5", "f_coral_44_2", Rectangle(790, -361, 40));
		AddSpawnPoint("f_coral_44_2.Id5", "f_coral_44_2", Rectangle(-1606, -145, 40));
		AddSpawnPoint("f_coral_44_2.Id5", "f_coral_44_2", Rectangle(-1321, 385, 40));
		AddSpawnPoint("f_coral_44_2.Id5", "f_coral_44_2", Rectangle(-195, 305, 40));
		AddSpawnPoint("f_coral_44_2.Id5", "f_coral_44_2", Rectangle(1086, 465, 40));
		AddSpawnPoint("f_coral_44_2.Id5", "f_coral_44_2", Rectangle(867, 1417, 40));

		// 'Rootcrystal_03' GenType 25 Spawn Points
		AddSpawnPoint("f_coral_44_2.Id6", "f_coral_44_2", Rectangle(-774, -638, 40));
		AddSpawnPoint("f_coral_44_2.Id6", "f_coral_44_2", Rectangle(1116, -1064, 40));
		AddSpawnPoint("f_coral_44_2.Id6", "f_coral_44_2", Rectangle(884, -501, 40));
		AddSpawnPoint("f_coral_44_2.Id6", "f_coral_44_2", Rectangle(862, -273, 40));
		AddSpawnPoint("f_coral_44_2.Id6", "f_coral_44_2", Rectangle(655, -1047, 40));
		AddSpawnPoint("f_coral_44_2.Id6", "f_coral_44_2", Rectangle(424, -913, 40));
		AddSpawnPoint("f_coral_44_2.Id6", "f_coral_44_2", Rectangle(-185, -653, 40));
		AddSpawnPoint("f_coral_44_2.Id6", "f_coral_44_2", Rectangle(226, -626, 40));
		AddSpawnPoint("f_coral_44_2.Id6", "f_coral_44_2", Rectangle(-83, -351, 40));
		AddSpawnPoint("f_coral_44_2.Id6", "f_coral_44_2", Rectangle(221, -330, 40));
		AddSpawnPoint("f_coral_44_2.Id6", "f_coral_44_2", Rectangle(-743, -513, 40));
		AddSpawnPoint("f_coral_44_2.Id6", "f_coral_44_2", Rectangle(-946, -751, 40));
		AddSpawnPoint("f_coral_44_2.Id6", "f_coral_44_2", Rectangle(-1555, -139, 40));
		AddSpawnPoint("f_coral_44_2.Id6", "f_coral_44_2", Rectangle(-1274, -78, 40));
		AddSpawnPoint("f_coral_44_2.Id6", "f_coral_44_2", Rectangle(-1447, 300, 40));
		AddSpawnPoint("f_coral_44_2.Id6", "f_coral_44_2", Rectangle(-1268, 462, 40));
		AddSpawnPoint("f_coral_44_2.Id6", "f_coral_44_2", Rectangle(-735, 55, 40));
		AddSpawnPoint("f_coral_44_2.Id6", "f_coral_44_2", Rectangle(-436, 250, 40));
		AddSpawnPoint("f_coral_44_2.Id6", "f_coral_44_2", Rectangle(-154, 380, 40));
		AddSpawnPoint("f_coral_44_2.Id6", "f_coral_44_2", Rectangle(-176, 613, 40));
		AddSpawnPoint("f_coral_44_2.Id6", "f_coral_44_2", Rectangle(60, 427, 40));
		AddSpawnPoint("f_coral_44_2.Id6", "f_coral_44_2", Rectangle(-486, 1015, 40));
		AddSpawnPoint("f_coral_44_2.Id6", "f_coral_44_2", Rectangle(-239, 1078, 40));
		AddSpawnPoint("f_coral_44_2.Id6", "f_coral_44_2", Rectangle(207, 1090, 40));
		AddSpawnPoint("f_coral_44_2.Id6", "f_coral_44_2", Rectangle(309, 1440, 40));
		AddSpawnPoint("f_coral_44_2.Id6", "f_coral_44_2", Rectangle(466, 1155, 40));
		AddSpawnPoint("f_coral_44_2.Id6", "f_coral_44_2", Rectangle(1030, 1451, 40));
		AddSpawnPoint("f_coral_44_2.Id6", "f_coral_44_2", Rectangle(1134, 1513, 40));
		AddSpawnPoint("f_coral_44_2.Id6", "f_coral_44_2", Rectangle(977, 781, 40));
		AddSpawnPoint("f_coral_44_2.Id6", "f_coral_44_2", Rectangle(896, 501, 40));
		AddSpawnPoint("f_coral_44_2.Id6", "f_coral_44_2", Rectangle(668, 424, 40));
		AddSpawnPoint("f_coral_44_2.Id6", "f_coral_44_2", Rectangle(1502, 282, 40));
		AddSpawnPoint("f_coral_44_2.Id6", "f_coral_44_2", Rectangle(1445, 469, 40));
		AddSpawnPoint("f_coral_44_2.Id6", "f_coral_44_2", Rectangle(1627, 413, 40));
	}
}
