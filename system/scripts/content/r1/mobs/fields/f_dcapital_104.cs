//--- Melia Script -----------------------------------------------------------
// Path of Desition Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_dcapital_104'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FDcapital104MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_dcapital_104", MonsterId.Orc_Cannon, Properties("MHP", 820054, "MINPATK", 11046, "MAXPATK", 13478, "MINMATK", 11046, "MAXMATK", 13478, "DEF", 286164, "MDEF", 286164));
		AddPropertyOverrides("f_dcapital_104", MonsterId.Orc_Flag, Properties("MHP", 822595, "MINPATK", 11079, "MAXPATK", 13518, "MINMATK", 11079, "MAXMATK", 13518, "DEF", 288304, "MDEF", 288304));
		AddPropertyOverrides("f_dcapital_104", MonsterId.Orc_Glaive, Properties("MHP", 825165, "MINPATK", 11112, "MAXPATK", 13559, "MINMATK", 11112, "MAXMATK", 13559, "DEF", 290468, "MDEF", 290468));
		AddPropertyOverrides("f_dcapital_104", MonsterId.Boss_Kabad_Q1, Properties("MHP", 7193260, "MINPATK", 25931, "MAXPATK", 31643, "MINMATK", 25931, "MAXMATK", 31643, "DEF", 1021369, "MDEF", 1021369));

		// Monster Spawners ---------------------------------

		AddSpawner("f_dcapital_104.Id1", MonsterId.Orc_Cannon, 38, 50, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_dcapital_104.Id2", MonsterId.Orc_Flag, 53, 70, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_dcapital_104.Id3", MonsterId.Orc_Glaive, 8, 10, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_dcapital_104.Id4", MonsterId.Rootcrystal_01, 23, 30, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Orc_Cannon' GenType 1 Spawn Points
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(1039, -2110, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(1099, -1837, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(980, -1805, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(859, -1974, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(841, -1741, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(896, -1531, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(1174, -1958, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(282, -1119, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(164, -1170, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(57, -1198, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(492, -302, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(445, -373, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(593, -354, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(795, -414, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(620, -521, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(236, -1019, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(536, -581, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(-50, -1743, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(23, -1603, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(154, -1765, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(-23, -1662, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(96, -1821, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(211, -1680, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(283, -1795, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(331, -1712, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(843, -1859, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(993, -1920, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(1206, -2157, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(1327, -1852, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(1374, -2060, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(916, -1612, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(645, -614, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(-701, 126, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(-711, 269, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(-511, 27, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(-487, 155, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(-583, 254, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(-397, 138, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(-59, 640, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(-47, 828, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(61, 817, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(96, 687, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(944, 104, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(1074, 232, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(1096, 69, 30));

		// 'Orc_Flag' GenType 2 Spawn Points
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(-1337, 43, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(-1563, 208, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(-1633, 141, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(-1426, 166, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(599, 1379, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(908, 199, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(1012, 264, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(1024, 51, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(429, -491, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(521, -430, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(727, -335, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(751, -526, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(645, -430, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(244, -1210, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(190, -1063, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(108, -1106, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(721, -1215, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(713, -1119, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(907, -1152, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(859, -1243, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(-32, -1830, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(-100, -1676, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(35, -1545, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(80, -1667, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(297, -1735, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(795, -2074, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(1009, -1624, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(969, -2076, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(1153, -1740, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(1234, -2075, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(1309, -1975, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(915, -1821, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(1073, -2018, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(711, -773, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(461, -1151, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(-699, 27, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(-775, 205, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(-461, 270, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(-594, 129, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(-1180, 177, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(39, 547, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(-113, 782, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(132, 866, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(32, 753, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(273, 1003, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(544, 1252, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(835, 137, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(1031, 157, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(769, -1067, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(814, -1173, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(807, -1043, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(-1555, 58, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(-1313, 222, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(-1245, 91, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(-1757, 119, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(1112, 133, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(698, 1285, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(1023, 1258, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(755, 1122, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(887, 1122, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(977, 1184, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(613, 1141, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(791, 1353, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(890, 1315, 35));

		// 'Orc_Glaive' GenType 3 Spawn Points
		AddSpawnPoint("f_dcapital_104.Id3", "f_dcapital_104", Rectangle(592, -452, 100));
		AddSpawnPoint("f_dcapital_104.Id3", "f_dcapital_104", Rectangle(214, -1106, 100));
		AddSpawnPoint("f_dcapital_104.Id3", "f_dcapital_104", Rectangle(795, -1149, 100));
		AddSpawnPoint("f_dcapital_104.Id3", "f_dcapital_104", Rectangle(899, -1760, 100));
		AddSpawnPoint("f_dcapital_104.Id3", "f_dcapital_104", Rectangle(1280, -2013, 100));
		AddSpawnPoint("f_dcapital_104.Id3", "f_dcapital_104", Rectangle(117, -1746, 100));
		AddSpawnPoint("f_dcapital_104.Id3", "f_dcapital_104", Rectangle(1024, 167, 100));
		AddSpawnPoint("f_dcapital_104.Id3", "f_dcapital_104", Rectangle(-1652, 56, 100));
		AddSpawnPoint("f_dcapital_104.Id3", "f_dcapital_104", Rectangle(-587, 120, 100));
		AddSpawnPoint("f_dcapital_104.Id3", "f_dcapital_104", Rectangle(-2, 735, 100));
		AddSpawnPoint("f_dcapital_104.Id3", "f_dcapital_104", Rectangle(835, 1235, 100));

		// 'Rootcrystal_01' GenType 5 Spawn Points
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(-45, -1579, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(37, -1803, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(238, -1724, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(69, -1262, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(269, -1119, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(600, -1184, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(813, -1030, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(850, -1238, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(846, -1510, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(831, -1927, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(1134, -2143, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(930, -1721, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(1086, -1893, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(1387, -1951, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(1347, -2119, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(703, -800, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(817, -427, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(424, -322, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(426, -550, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(625, -497, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(335, -111, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(68, 65, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(74, 293, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(288, 122, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(328, 352, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(502, 144, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(778, 159, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(997, 201, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(1190, 137, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(495, 1664, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(610, 1492, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(773, 1458, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(659, 1245, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(922, 1110, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(1092, 1219, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(413, 1164, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(262, 933, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(-99, 798, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(-244, 186, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(-708, 93, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(-746, 327, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(-443, 324, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(-518, 140, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(-1100, 163, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(-1495, 99, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(-1768, 211, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(-1312, 183, 100));
	}
}
