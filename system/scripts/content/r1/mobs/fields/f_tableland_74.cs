//--- Melia Script -----------------------------------------------------------
// Steel Heights Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_tableland_74'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FTableland74MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_tableland_74", MonsterId.Tiny_Mage_Brown, Properties("MHP", 399676, "MINPATK", 5640, "MAXPATK", 6834, "MINMATK", 5640, "MAXMATK", 6834, "DEF", 44650, "MDEF", 44650));
		AddPropertyOverrides("f_tableland_74", MonsterId.Spion_Mage_White, Properties("MHP", 401474, "MINPATK", 5663, "MAXPATK", 6863, "MINMATK", 5663, "MAXMATK", 6863, "DEF", 45223, "MDEF", 45223));
		AddPropertyOverrides("f_tableland_74", MonsterId.Harugal_Blue, Properties("MHP", 403387, "MINPATK", 5688, "MAXPATK", 6893, "MINMATK", 5688, "MAXMATK", 6893, "DEF", 45833, "MDEF", 45833));
		AddPropertyOverrides("f_tableland_74", MonsterId.Kepari_Purple, Properties("MHP", 405411, "MINPATK", 5714, "MAXPATK", 6925, "MINMATK", 5714, "MAXMATK", 6925, "DEF", 46479, "MDEF", 46479));

		// Monster Spawners ---------------------------------

		AddSpawner("f_tableland_74.Id1", MonsterId.Tiny_Mage_Brown, min: 27, max: 35);
		AddSpawner("f_tableland_74.Id2", MonsterId.Spion_Mage_White, min: 12, max: 15);
		AddSpawner("f_tableland_74.Id3", MonsterId.Harugal_Blue, min: 4, max: 5);
		AddSpawner("f_tableland_74.Id4", MonsterId.Kepari_Purple, min: 42, max: 55);
		AddSpawner("f_tableland_74.Id5", MonsterId.Rootcrystal_01, min: 23, max: 30, respawn: TimeSpan.FromMilliseconds(60000));

		// Monster Spawn Points -----------------------------

		// 'Tiny_Mage_Brown' GenType 1 Spawn Points
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-963, -259, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-744, -74, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-620, -231, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-724, -312, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(75, 909, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-40, -1161, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(846, -189, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-20, -1040, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(188, -1235, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(226, -961, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(143, -1078, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-761, -1087, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-621, -956, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-562, -1116, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-753, -931, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-1709, -439, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-1826, -277, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-1667, -162, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-1502, -503, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-2048, -169, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-1431, -246, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-1786, -1067, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-1728, -1202, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-1502, -1101, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-1624, -930, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(366, 814, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(316, 1179, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(594, 984, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(395, 1058, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(213, 543, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(88, 464, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(59, 615, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(422, 1301, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(1193, 385, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(1281, 469, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(1458, 520, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(1484, 278, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(977, -154, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(1086, -55, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(1343, 216, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-739, -1206, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-860, -123, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(281, 997, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(486, 817, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(1068, 355, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(56, -1206, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-76, -921, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(127, -1277, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(33, -1297, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(321, -1153, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-1638, -821, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-1599, -744, 25));

		// 'Spion_Mage_White' GenType 2 Spawn Points
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(1281, 615, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(1475, 741, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(1183, 1282, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(1412, 1308, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(1300, 1160, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(1272, 1393, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(1087, 1190, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(1017, 1863, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(942, 2041, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(1172, 2237, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(1062, 1994, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(535, 1538, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(655, 1743, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(520, 964, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(132, 1004, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(1026, 416, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(1278, 239, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(1251, -15, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(991, -190, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(719, -211, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(762, 1804, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(179, -693, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(323, 1381, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(-7, -930, 25));

		// 'Harugal_Blue' GenType 3 Spawn Points
		AddSpawnPoint("f_tableland_74.Id3", "f_tableland_74", Rectangle(1300, 374, 25));
		AddSpawnPoint("f_tableland_74.Id3", "f_tableland_74", Rectangle(386, 930, 25));
		AddSpawnPoint("f_tableland_74.Id3", "f_tableland_74", Rectangle(1287, 1277, 25));
		AddSpawnPoint("f_tableland_74.Id3", "f_tableland_74", Rectangle(1059, 2067, 25));
		AddSpawnPoint("f_tableland_74.Id3", "f_tableland_74", Rectangle(932, 2175, 25));
		AddSpawnPoint("f_tableland_74.Id3", "f_tableland_74", Rectangle(-638, -1023, 25));
		AddSpawnPoint("f_tableland_74.Id3", "f_tableland_74", Rectangle(153, -1060, 25));
		AddSpawnPoint("f_tableland_74.Id3", "f_tableland_74", Rectangle(-746, -185, 25));
		AddSpawnPoint("f_tableland_74.Id3", "f_tableland_74", Rectangle(-1741, -340, 25));
		AddSpawnPoint("f_tableland_74.Id3", "f_tableland_74", Rectangle(-1742, -1085, 25));
		AddSpawnPoint("f_tableland_74.Id3", "f_tableland_74", Rectangle(243, 1001, 25));
		AddSpawnPoint("f_tableland_74.Id3", "f_tableland_74", Rectangle(601, 1634, 25));
		AddSpawnPoint("f_tableland_74.Id3", "f_tableland_74", Rectangle(1006, -130, 25));

		// 'Kepari_Purple' GenType 4 Spawn Points
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-726, -218, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-636, -13, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(10, 833, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(310, -1138, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-889, -969, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-1792, -465, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(190, -811, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-33, -1094, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(239, -1267, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(161, -1013, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(196, 902, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(423, 1237, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(172, 980, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(73, 692, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(597, 1055, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(1260, 324, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(1484, 459, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(1375, 423, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(1341, 117, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(1089, 361, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(1045, -124, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-855, -189, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-703, -1209, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-831, -1092, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-618, -947, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-585, -1122, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-306, -1102, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(109, 503, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(464, 907, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-1674, -368, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-1643, -265, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-1506, -230, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-1480, -381, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-1527, -513, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-1601, -1088, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-1590, -1183, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-1685, -1012, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-1843, -1174, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-1799, -972, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-1577, -334, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-1559, -143, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-1450, -158, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-1370, -369, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-1306, -264, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-517, -991, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-742, -1001, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-476, -1071, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-531, -1207, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-559, -881, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(270, -1050, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(102, -939, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(199, -1132, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(62, -1130, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(315, -968, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(1447, 1142, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(1489, 1241, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(1468, 1381, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(1201, 1188, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(1075, 1296, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(490, 1098, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(528, 1199, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(673, 1166, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(295, 1101, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(171, 1109, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(929, 1884, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(834, 2035, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(1056, 2169, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(1199, 2124, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(1232, 1899, 30));

		// 'Rootcrystal_01' GenType 9 Spawn Points
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(1911, 2185, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(1289, 2155, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(880, 1866, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(542, 1409, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(555, 962, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(114, 973, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(1056, 1271, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(1406, 1273, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(1489, 744, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(1488, 371, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(1165, 348, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(1100, -107, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(582, -225, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(304, -140, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(-32, -210, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(220, -459, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(126, 319, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(156, -873, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(313, -1203, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(-56, -1146, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(-473, -1036, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(-765, -1054, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(-454, -138, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(-878, -180, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(-1375, -280, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(-1812, -253, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(-1626, -514, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(-1579, -1020, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(-1862, -1181, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(-2260, -1285, 40));
	}
}
