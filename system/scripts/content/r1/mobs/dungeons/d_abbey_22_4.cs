//--- Melia Script -----------------------------------------------------------
// Narvas Temple Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_abbey_22_4'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DAbbey224MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("d_abbey_22_4.Id1", MonsterId.Rootcrystal_05, 14, 18, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_abbey_22_4.Id2", MonsterId.Hohen_Mage_Black, 72, 95, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_22_4.Id3", MonsterId.Nook, 18, 24, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_22_4.Id4", MonsterId.Boor, 20, 26, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_22_4.Id5", MonsterId.Mangosting, 26, 34, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_22_4.Id6", MonsterId.Half_Mangosting, 35, 46, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_22_4.Id7", MonsterId.Hohen_Mage_Black, 4, 5, TimeSpan.FromMilliseconds(40000), TendencyType.Peaceful);
		AddSpawner("d_abbey_22_4.Id8", MonsterId.Hohen_Mage_Black, 4, 5, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_abbey_22_4.Id9", MonsterId.Rootcrystal_01, 13, 17, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_05' GenType 43 Spawn Points
		AddSpawnPoint("d_abbey_22_4.Id1", "d_abbey_22_4", Rectangle(535, 1267, 20));
		AddSpawnPoint("d_abbey_22_4.Id1", "d_abbey_22_4", Rectangle(1518, 1284, 20));
		AddSpawnPoint("d_abbey_22_4.Id1", "d_abbey_22_4", Rectangle(-54, 1281, 20));
		AddSpawnPoint("d_abbey_22_4.Id1", "d_abbey_22_4", Rectangle(-669, 1252, 20));
		AddSpawnPoint("d_abbey_22_4.Id1", "d_abbey_22_4", Rectangle(-1475, 1271, 20));
		AddSpawnPoint("d_abbey_22_4.Id1", "d_abbey_22_4", Rectangle(-27, 666, 20));
		AddSpawnPoint("d_abbey_22_4.Id1", "d_abbey_22_4", Rectangle(526, 647, 20));
		AddSpawnPoint("d_abbey_22_4.Id1", "d_abbey_22_4", Rectangle(-658, 667, 20));
		AddSpawnPoint("d_abbey_22_4.Id1", "d_abbey_22_4", Rectangle(-1484, 610, 20));
		AddSpawnPoint("d_abbey_22_4.Id1", "d_abbey_22_4", Rectangle(-244, 137, 20));
		AddSpawnPoint("d_abbey_22_4.Id1", "d_abbey_22_4", Rectangle(541, 76, 20));
		AddSpawnPoint("d_abbey_22_4.Id1", "d_abbey_22_4", Rectangle(819, 45, 20));
		AddSpawnPoint("d_abbey_22_4.Id1", "d_abbey_22_4", Rectangle(-669, 48, 20));
		AddSpawnPoint("d_abbey_22_4.Id1", "d_abbey_22_4", Rectangle(-1534, 55, 20));
		AddSpawnPoint("d_abbey_22_4.Id1", "d_abbey_22_4", Rectangle(-1591, -606, 20));
		AddSpawnPoint("d_abbey_22_4.Id1", "d_abbey_22_4", Rectangle(-665, -500, 20));
		AddSpawnPoint("d_abbey_22_4.Id1", "d_abbey_22_4", Rectangle(-700, -1085, 20));
		AddSpawnPoint("d_abbey_22_4.Id1", "d_abbey_22_4", Rectangle(-176, -1085, 20));

		// 'Hohen_Mage_Black' GenType 50 Spawn Points
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(1471, 1199, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(1444, 1330, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(1271, 1328, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(1276, 1162, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(1592, 1175, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(797, 1325, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(786, 1226, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(365, 1346, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(366, 1209, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(551, 1327, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(36, 1348, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(30, 1229, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-138, 1222, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-150, 1350, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-528, 1179, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-543, 1399, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-683, 1402, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-688, 1178, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-807, 1409, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-834, 1177, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1119, 1338, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1125, 1263, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1324, 1357, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1328, 1220, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1343, 1083, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1546, 1376, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1655, 1269, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1540, 1152, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1443, 1273, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1530, 1035, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1742, 1052, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1739, 1225, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1748, 1377, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-47, 1117, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-53, 906, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(13, 906, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-721, 560, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-721, 709, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-554, 534, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-500, 707, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1287, 616, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1272, 710, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1405, 455, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1382, 586, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1558, 716, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1564, 594, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(349, 596, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(356, 708, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(448, 515, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(474, 794, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-68, 457, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-64, 294, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-384, 148, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-566, -39, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-546, 126, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-775, 147, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-776, -45, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-796, -358, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-810, -508, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-570, -573, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-579, -392, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(193, 177, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(482, 175, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(465, -64, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(682, -63, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(686, 126, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(854, -114, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(910, 111, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-763, -1182, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-592, -1123, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-469, -890, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-320, -912, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-517, -1119, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-462, -1236, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-303, -1000, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-436, -1136, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-214, -913, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-22, -1009, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-463, -1021, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-359, -1072, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-738, -587, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-613, -512, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-24, 793, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-33, 1016, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-254, 1318, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-842, 1278, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(36, 171, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-40, 346, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-108, 365, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-705, -189, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-933, 119, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1031, 139, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-131, 142, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-670, -718, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-772, -334, 40));

		// 'Nook' GenType 51 Spawn Points
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(1642, 1093, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(1562, 1392, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(1394, 1117, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(1361, 1399, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(1210, 1229, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(945, 1299, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(675, 1136, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(656, 1423, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(585, 1210, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(405, 1108, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(463, 1430, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(493, 1205, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(200, 1267, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(381, 1446, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(-338, 1302, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(-561, 1259, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(-643, 1326, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(-755, 1250, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(-859, 1320, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(-1677, 1140, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(-1453, 1098, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(-1413, 1345, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(-1664, 1445, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(-1714, 1310, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(263, 646, 40));

		// 'Boor' GenType 52 Spawn Points
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(577, 522, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(730, 528, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(739, 747, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(569, 777, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(39, 717, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-74, 597, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(140, 645, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-247, 634, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-854, 483, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-818, 554, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-623, 497, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-520, 466, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-491, 641, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-494, 785, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-586, 764, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-820, 671, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-601, 623, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-983, 669, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-1137, 664, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-1640, 475, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-1663, 633, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-1499, 516, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-1430, 687, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-1312, 490, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-1691, 754, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-1716, 519, 40));

		// 'Mangosting' GenType 53 Spawn Points
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(385, -98, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(432, 26, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(548, -127, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(601, -9, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(757, -120, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(798, -27, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(933, -108, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(936, 16, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(805, 105, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(886, 214, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(781, 207, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(625, 231, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(565, 107, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(327, 128, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(388, 187, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(715, 30, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(-108, 143, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(11, 152, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(-860, -55, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(-672, 69, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(-665, 205, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(-544, 44, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(-677, -79, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(-880, 175, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(-820, 48, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(-1133, 156, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(-1006, 149, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(-1334, 156, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(-1491, 126, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(-1393, 46, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(-1362, -109, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(-1513, -158, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(-1627, -179, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(-1691, 5, 40));

		// 'Half_Mangosting' GenType 54 Spawn Points
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-1627, -85, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-1617, 71, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-1500, 27, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-1505, -53, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-1435, -44, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-1665, -304, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-1607, -386, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-1708, -486, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-1596, -498, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-1639, -615, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-1664, -676, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-1557, -715, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-1511, -629, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-1473, -696, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-1451, -547, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-1543, -554, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-717, -188, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-667, -294, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-663, -406, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-756, -445, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-711, -531, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-605, -479, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-814, -588, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-661, -620, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-690, -766, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-822, -917, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-810, -1019, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-813, -1116, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-682, -1202, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-651, -975, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-659, -1080, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-524, -1190, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-544, -1045, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-447, -1109, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-535, -947, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-409, -975, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-638, -1181, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-282, -1054, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-258, -934, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-205, -1041, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-57, -1147, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-38, -1228, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-108, -1082, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(14, -1122, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-19, -922, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-138, -958, 40));

		// 'Hohen_Mage_Black' GenType 57 Spawn Points
		AddSpawnPoint("d_abbey_22_4.Id7", "d_abbey_22_4", Rectangle(1588, 1250, 20));
		AddSpawnPoint("d_abbey_22_4.Id7", "d_abbey_22_4", Rectangle(1348, 1444, 20));
		AddSpawnPoint("d_abbey_22_4.Id7", "d_abbey_22_4", Rectangle(1407, 1112, 20));
		AddSpawnPoint("d_abbey_22_4.Id7", "d_abbey_22_4", Rectangle(404, 1342, 20));
		AddSpawnPoint("d_abbey_22_4.Id7", "d_abbey_22_4", Rectangle(777, 1230, 20));

		// 'Hohen_Mage_Black' GenType 58 Spawn Points
		AddSpawnPoint("d_abbey_22_4.Id8", "d_abbey_22_4", Rectangle(-729, 29, 20));
		AddSpawnPoint("d_abbey_22_4.Id8", "d_abbey_22_4", Rectangle(-708, 130, 20));
		AddSpawnPoint("d_abbey_22_4.Id8", "d_abbey_22_4", Rectangle(-594, 45, 20));
		AddSpawnPoint("d_abbey_22_4.Id8", "d_abbey_22_4", Rectangle(-500, -107, 20));
		AddSpawnPoint("d_abbey_22_4.Id8", "d_abbey_22_4", Rectangle(-829, 215, 20));

		// 'Rootcrystal_01' GenType 59 Spawn Points
		AddSpawnPoint("d_abbey_22_4.Id9", "d_abbey_22_4", Rectangle(1609, 1235, 40));
		AddSpawnPoint("d_abbey_22_4.Id9", "d_abbey_22_4", Rectangle(453, 1322, 40));
		AddSpawnPoint("d_abbey_22_4.Id9", "d_abbey_22_4", Rectangle(-62, 1302, 40));
		AddSpawnPoint("d_abbey_22_4.Id9", "d_abbey_22_4", Rectangle(-679, 1289, 40));
		AddSpawnPoint("d_abbey_22_4.Id9", "d_abbey_22_4", Rectangle(-1471, 1264, 40));
		AddSpawnPoint("d_abbey_22_4.Id9", "d_abbey_22_4", Rectangle(-1488, 611, 40));
		AddSpawnPoint("d_abbey_22_4.Id9", "d_abbey_22_4", Rectangle(-562, 634, 40));
		AddSpawnPoint("d_abbey_22_4.Id9", "d_abbey_22_4", Rectangle(603, 540, 40));
		AddSpawnPoint("d_abbey_22_4.Id9", "d_abbey_22_4", Rectangle(708, -7, 40));
		AddSpawnPoint("d_abbey_22_4.Id9", "d_abbey_22_4", Rectangle(-83, 140, 40));
		AddSpawnPoint("d_abbey_22_4.Id9", "d_abbey_22_4", Rectangle(-714, 74, 40));
		AddSpawnPoint("d_abbey_22_4.Id9", "d_abbey_22_4", Rectangle(-1571, -22, 40));
		AddSpawnPoint("d_abbey_22_4.Id9", "d_abbey_22_4", Rectangle(-1550, -591, 40));
		AddSpawnPoint("d_abbey_22_4.Id9", "d_abbey_22_4", Rectangle(-667, -489, 40));
		AddSpawnPoint("d_abbey_22_4.Id9", "d_abbey_22_4", Rectangle(-585, -1060, 40));
		AddSpawnPoint("d_abbey_22_4.Id9", "d_abbey_22_4", Rectangle(-65, -1126, 40));
		AddSpawnPoint("d_abbey_22_4.Id9", "d_abbey_22_4", Rectangle(1245, 1286, 40));
	}
}
