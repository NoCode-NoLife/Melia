//--- Melia Script -----------------------------------------------------------
// Baltinel Memorial Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_dcapital_105'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FDcapital105MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_dcapital_105", MonsterId.Beetle_Green, Properties("MHP", 749696, "MINPATK", 10141, "MAXPATK", 12366, "MINMATK", 10141, "MAXMATK", 12366, "DEF", 226909, "MDEF", 226909));
		AddPropertyOverrides("f_dcapital_105", MonsterId.Bumble_Green, Properties("MHP", 750513, "MINPATK", 10152, "MAXPATK", 12379, "MINMATK", 10152, "MAXMATK", 12379, "DEF", 227597, "MDEF", 227597));
		AddPropertyOverrides("f_dcapital_105", MonsterId.Moltooth, Properties("MHP", 751416, "MINPATK", 10164, "MAXPATK", 12394, "MINMATK", 10164, "MAXMATK", 12394, "DEF", 228358, "MDEF", 228358));
		AddPropertyOverrides("f_dcapital_105", MonsterId.Bishopstar, Properties("MHP", 752398, "MINPATK", 10176, "MAXPATK", 12409, "MINMATK", 10176, "MAXMATK", 12409, "DEF", 229185, "MDEF", 229185));

		// Monster Spawners ---------------------------------

		AddSpawner("f_dcapital_105.Id1", MonsterId.Rootcrystal_01, min: 27, max: 35, respawn: TimeSpan.FromMilliseconds(25000));
		AddSpawner("f_dcapital_105.Id2", MonsterId.Beetle_Green, min: 27, max: 35);
		AddSpawner("f_dcapital_105.Id3", MonsterId.Bumble_Green, min: 20, max: 26);
		AddSpawner("f_dcapital_105.Id4", MonsterId.Moltooth, min: 30, max: 40);
		AddSpawner("f_dcapital_105.Id5", MonsterId.Bishopstar, min: 24, max: 32);
		AddSpawner("f_dcapital_105.Id6", MonsterId.Bishopstar, min: 6, max: 7, respawn: TimeSpan.FromMilliseconds(20000));
		AddSpawner("f_dcapital_105.Id7", MonsterId.Bishopstar, amount: 3, respawn: TimeSpan.FromMilliseconds(20000));

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 4 Spawn Points
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(1364, -1042, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(1467, -804, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(1311, -628, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(1115, -921, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(925, -65, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(1025, -236, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(696, -404, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(313, -505, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(340, -715, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(561, -609, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-260, -377, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-345, -581, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-160, -624, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-174, -970, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-1067, -1053, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-851, -1114, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-644, -915, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-1076, -462, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-1069, -152, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-847, -382, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-627, -28, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-1475, 105, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-1183, 109, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-810, 242, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-572, 400, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-1110, 603, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-1357, 996, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-1050, 792, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-1017, 995, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-799, 875, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-1861, 1447, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-1728, 1733, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-1420, 1551, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-1346, 1864, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-755, 1636, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-296, 1619, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-49, 1771, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(182, 1723, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(189, 1505, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-36, 1542, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(52, 1390, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(54, 1016, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-271, 818, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(53, 600, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(593, 807, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(593, 521, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(384, 253, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(22, 84, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-268, 222, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(149, 214, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(256, 36, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(701, 346, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(782, 512, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(967, 283, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(1097, 510, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(1276, 478, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(1312, 304, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(1146, 328, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(1255, 132, 100));

		// 'Beetle_Green' GenType 15 Spawn Points
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(-1054, -1021, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(-932, -1134, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(-793, -953, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(-586, -959, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(-211, -1005, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(-202, -736, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(-389, -708, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(-233, -626, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(-206, -289, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(159, -639, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(371, -403, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(465, -627, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(728, -452, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(917, -488, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(1069, -564, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(1059, -103, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(896, -214, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(1262, -642, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(1470, -790, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(1151, -836, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(1146, -1169, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(1374, -1005, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(-583, -449, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(-1194, -328, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(-891, -164, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(-990, -532, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(-607, -21, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(-992, -401, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(815, 259, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(735, 438, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(1156, 584, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(1250, 76, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(642, 530, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(304, 350, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(263, 123, 25));

		// 'Bumble_Green' GenType 16 Spawn Points
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(-408, -829, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(-115, -849, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(-336, -594, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(-389, -429, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(-223, -462, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(11, -643, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(650, -448, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(342, -587, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(416, -752, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(1061, -266, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(992, 8, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(1182, -1015, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(1440, -656, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(1408, -1172, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(995, -670, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(1048, 213, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(1316, 275, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(944, 584, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(727, 652, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(-1110, -416, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(-1073, -130, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(-840, -310, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(-739, -576, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(-1138, -591, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(-627, -144, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(656, -633, 25));

		// 'Moltooth' GenType 17 Spawn Points
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-108, 16, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-162, 243, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(89, 178, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(391, 259, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(65, 521, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-577, 403, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-987, 435, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-754, 266, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-1163, 14, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-1511, 94, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-1292, 202, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-1247, 606, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-1323, 1044, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-1259, 803, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-1091, 1012, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-1222, 1446, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-1904, 1438, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-1507, 1576, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-1645, 1708, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-1292, 1817, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-990, 1622, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-515, 1593, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-225, 1910, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(238, 1558, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-120, 1664, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(95, 1417, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(70, 1025, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-203, 787, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-394, 833, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-619, 778, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-890, 850, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(550, 800, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(49, 692, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-301, 1544, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(13, 783, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(69, 900, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(23, 1184, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(409, 793, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-951, 1162, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-284, 83, 25));

		// 'Bishopstar' GenType 18 Spawn Points
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-1356, 937, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-1375, 1183, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-1123, 1228, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-1154, 956, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-1009, 749, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-776, 413, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-1291, 321, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-1305, -21, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-1647, 104, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-1323, -226, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(42, 1215, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-57, 1433, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-275, 1678, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(58, 1733, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(6, 1537, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-858, 1593, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-1748, 1355, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-1883, 1572, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-1649, 1553, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-1429, 1710, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-1382, 1922, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(29, 393, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(149, 802, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(525, 481, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-20, 124, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-238, 322, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-533, 223, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(197, 321, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(277, 1, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-814, 1587, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-344, 71, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-226, -53, 25));

		// 'Bishopstar' GenType 24 Spawn Points
		AddSpawnPoint("f_dcapital_105.Id6", "f_dcapital_105", Rectangle(846, 378, 25));
		AddSpawnPoint("f_dcapital_105.Id6", "f_dcapital_105", Rectangle(1015, 536, 25));
		AddSpawnPoint("f_dcapital_105.Id6", "f_dcapital_105", Rectangle(969, 193, 25));
		AddSpawnPoint("f_dcapital_105.Id6", "f_dcapital_105", Rectangle(1258, 328, 25));
		AddSpawnPoint("f_dcapital_105.Id6", "f_dcapital_105", Rectangle(1046, 348, 25));
		AddSpawnPoint("f_dcapital_105.Id6", "f_dcapital_105", Rectangle(614, 383, 25));
		AddSpawnPoint("f_dcapital_105.Id6", "f_dcapital_105", Rectangle(780, 233, 25));

		// 'Bishopstar' GenType 25 Spawn Points
		AddSpawnPoint("f_dcapital_105.Id7", "f_dcapital_105", Rectangle(1058, -1144, 25));
		AddSpawnPoint("f_dcapital_105.Id7", "f_dcapital_105", Rectangle(1501, -964, 25));
		AddSpawnPoint("f_dcapital_105.Id7", "f_dcapital_105", Rectangle(1259, -989, 25));
	}
}
