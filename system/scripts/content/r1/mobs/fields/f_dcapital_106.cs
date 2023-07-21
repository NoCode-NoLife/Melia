//--- Melia Script -----------------------------------------------------------
// Gliehel Memorial Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_dcapital_106'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FDcapital106MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_dcapital_106", MonsterId.Wajak_Walker, Properties("MHP", 753453, "MINPATK", 10190, "MAXPATK", 12426, "MINMATK", 10190, "MAXMATK", 12426, "DEF", 230073, "MDEF", 230073));
		AddPropertyOverrides("f_dcapital_106", MonsterId.Horong_Walker, Properties("MHP", 754576, "MINPATK", 10204, "MAXPATK", 12444, "MINMATK", 10204, "MAXMATK", 12444, "DEF", 231019, "MDEF", 231019));
		AddPropertyOverrides("f_dcapital_106", MonsterId.Bishop_Hart, Properties("MHP", 755763, "MINPATK", 10219, "MAXPATK", 12462, "MINMATK", 10219, "MAXMATK", 12462, "DEF", 232018, "MDEF", 232018));
		AddPropertyOverrides("f_dcapital_106", MonsterId.Bishop_Point, Properties("MHP", 757011, "MINPATK", 10235, "MAXPATK", 12482, "MINMATK", 10235, "MAXMATK", 12482, "DEF", 233070, "MDEF", 233070));

		// Monster Spawners ---------------------------------

		AddSpawner("f_dcapital_106.Id1", MonsterId.Rootcrystal_01, 27, 35, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);
		AddSpawner("f_dcapital_106.Id2", MonsterId.Wajak_Walker, 24, 31, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_dcapital_106.Id3", MonsterId.Horong_Walker, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_dcapital_106.Id4", MonsterId.Bishop_Hart, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_dcapital_106.Id5", MonsterId.Bishop_Point, 27, 36, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_dcapital_106.Id6", MonsterId.Bishop_Point, 3, 4, TimeSpan.FromMilliseconds(10000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 4 Spawn Points
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(1981, 319, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(2000, 498, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(2079, 38, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(1526, 596, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(1299, 660, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(896, 640, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(429, 476, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(664, 825, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(734, 1139, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(1025, 1111, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(247, 698, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(-224, 863, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(-459, 783, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(-360, 317, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(40, 378, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(-295, 25, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(-405, -305, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(-580, -53, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(-924, -63, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(-1375, -83, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(-1178, -351, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(-1548, -352, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(-1187, -196, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(-1481, 1000, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(-1482, 1266, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(-1139, 1042, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(-772, 1421, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(-437, 1205, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(231, 1216, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(121, 1394, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(305, 1483, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(430, 1281, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(636, 1479, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(766, 1618, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(749, 1865, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(892, 962, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(1326, 1262, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(1677, 1243, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(1722, 1377, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(1949, 1242, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(2102, 1395, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(1957, 1449, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(703, 545, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(1737, 334, 100));
		AddSpawnPoint("f_dcapital_106.Id1", "f_dcapital_106", Rectangle(2198, 256, 100));

		// 'Wajak_Walker' GenType 14 Spawn Points
		AddSpawnPoint("f_dcapital_106.Id2", "f_dcapital_106", Rectangle(-1438, -56, 25));
		AddSpawnPoint("f_dcapital_106.Id2", "f_dcapital_106", Rectangle(-1515, -399, 25));
		AddSpawnPoint("f_dcapital_106.Id2", "f_dcapital_106", Rectangle(-944, -70, 25));
		AddSpawnPoint("f_dcapital_106.Id2", "f_dcapital_106", Rectangle(-380, -46, 25));
		AddSpawnPoint("f_dcapital_106.Id2", "f_dcapital_106", Rectangle(-423, 344, 25));
		AddSpawnPoint("f_dcapital_106.Id2", "f_dcapital_106", Rectangle(-478, -367, 25));
		AddSpawnPoint("f_dcapital_106.Id2", "f_dcapital_106", Rectangle(20, 395, 25));
		AddSpawnPoint("f_dcapital_106.Id2", "f_dcapital_106", Rectangle(-254, 676, 25));
		AddSpawnPoint("f_dcapital_106.Id2", "f_dcapital_106", Rectangle(-517, 722, 25));
		AddSpawnPoint("f_dcapital_106.Id2", "f_dcapital_106", Rectangle(-340, 954, 25));
		AddSpawnPoint("f_dcapital_106.Id2", "f_dcapital_106", Rectangle(-508, 1061, 25));
		AddSpawnPoint("f_dcapital_106.Id2", "f_dcapital_106", Rectangle(-577, 1271, 25));
		AddSpawnPoint("f_dcapital_106.Id2", "f_dcapital_106", Rectangle(-793, 1497, 25));
		AddSpawnPoint("f_dcapital_106.Id2", "f_dcapital_106", Rectangle(-1008, 1340, 25));
		AddSpawnPoint("f_dcapital_106.Id2", "f_dcapital_106", Rectangle(-1062, 1092, 25));
		AddSpawnPoint("f_dcapital_106.Id2", "f_dcapital_106", Rectangle(-1184, 898, 25));
		AddSpawnPoint("f_dcapital_106.Id2", "f_dcapital_106", Rectangle(-1275, 1181, 25));
		AddSpawnPoint("f_dcapital_106.Id2", "f_dcapital_106", Rectangle(-1594, 1023, 25));
		AddSpawnPoint("f_dcapital_106.Id2", "f_dcapital_106", Rectangle(-89, 879, 25));
		AddSpawnPoint("f_dcapital_106.Id2", "f_dcapital_106", Rectangle(-655, -37, 25));
		AddSpawnPoint("f_dcapital_106.Id2", "f_dcapital_106", Rectangle(-633, 145, 25));
		AddSpawnPoint("f_dcapital_106.Id2", "f_dcapital_106", Rectangle(-104, 28, 25));
		AddSpawnPoint("f_dcapital_106.Id2", "f_dcapital_106", Rectangle(-1239, -315, 25));
		AddSpawnPoint("f_dcapital_106.Id2", "f_dcapital_106", Rectangle(134, 611, 25));
		AddSpawnPoint("f_dcapital_106.Id2", "f_dcapital_106", Rectangle(156, 894, 25));
		AddSpawnPoint("f_dcapital_106.Id2", "f_dcapital_106", Rectangle(555, 396, 25));
		AddSpawnPoint("f_dcapital_106.Id2", "f_dcapital_106", Rectangle(529, 847, 25));
		AddSpawnPoint("f_dcapital_106.Id2", "f_dcapital_106", Rectangle(242, 504, 25));
		AddSpawnPoint("f_dcapital_106.Id2", "f_dcapital_106", Rectangle(-812, -161, 25));
		AddSpawnPoint("f_dcapital_106.Id2", "f_dcapital_106", Rectangle(87, 521, 25));
		AddSpawnPoint("f_dcapital_106.Id2", "f_dcapital_106", Rectangle(157, 1029, 25));
		AddSpawnPoint("f_dcapital_106.Id2", "f_dcapital_106", Rectangle(-241, 159, 25));

		// 'Horong_Walker' GenType 15 Spawn Points
		AddSpawnPoint("f_dcapital_106.Id3", "f_dcapital_106", Rectangle(-1336, -167, 25));
		AddSpawnPoint("f_dcapital_106.Id3", "f_dcapital_106", Rectangle(-1035, -208, 25));
		AddSpawnPoint("f_dcapital_106.Id3", "f_dcapital_106", Rectangle(-649, -204, 25));
		AddSpawnPoint("f_dcapital_106.Id3", "f_dcapital_106", Rectangle(-285, -235, 25));
		AddSpawnPoint("f_dcapital_106.Id3", "f_dcapital_106", Rectangle(-469, 126, 25));
		AddSpawnPoint("f_dcapital_106.Id3", "f_dcapital_106", Rectangle(-166, 295, 25));
		AddSpawnPoint("f_dcapital_106.Id3", "f_dcapital_106", Rectangle(-453, 541, 25));
		AddSpawnPoint("f_dcapital_106.Id3", "f_dcapital_106", Rectangle(-329, 861, 25));
		AddSpawnPoint("f_dcapital_106.Id3", "f_dcapital_106", Rectangle(-585, 995, 25));
		AddSpawnPoint("f_dcapital_106.Id3", "f_dcapital_106", Rectangle(-361, 1211, 25));
		AddSpawnPoint("f_dcapital_106.Id3", "f_dcapital_106", Rectangle(-761, 1355, 25));
		AddSpawnPoint("f_dcapital_106.Id3", "f_dcapital_106", Rectangle(-1135, 1279, 25));
		AddSpawnPoint("f_dcapital_106.Id3", "f_dcapital_106", Rectangle(-1468, 881, 25));
		AddSpawnPoint("f_dcapital_106.Id3", "f_dcapital_106", Rectangle(-1507, 1237, 25));
		AddSpawnPoint("f_dcapital_106.Id3", "f_dcapital_106", Rectangle(-1319, 1010, 25));
		AddSpawnPoint("f_dcapital_106.Id3", "f_dcapital_106", Rectangle(-1056, 1011, 25));
		AddSpawnPoint("f_dcapital_106.Id3", "f_dcapital_106", Rectangle(-555, 771, 25));
		AddSpawnPoint("f_dcapital_106.Id3", "f_dcapital_106", Rectangle(-170, 999, 25));
		AddSpawnPoint("f_dcapital_106.Id3", "f_dcapital_106", Rectangle(139, 752, 25));
		AddSpawnPoint("f_dcapital_106.Id3", "f_dcapital_106", Rectangle(13, 944, 25));
		AddSpawnPoint("f_dcapital_106.Id3", "f_dcapital_106", Rectangle(357, 428, 25));
		AddSpawnPoint("f_dcapital_106.Id3", "f_dcapital_106", Rectangle(-209, -61, 25));
		AddSpawnPoint("f_dcapital_106.Id3", "f_dcapital_106", Rectangle(-1473, 1086, 25));
		AddSpawnPoint("f_dcapital_106.Id3", "f_dcapital_106", Rectangle(343, 661, 25));
		AddSpawnPoint("f_dcapital_106.Id3", "f_dcapital_106", Rectangle(391, 903, 25));
		AddSpawnPoint("f_dcapital_106.Id3", "f_dcapital_106", Rectangle(-387, 701, 25));
		AddSpawnPoint("f_dcapital_106.Id3", "f_dcapital_106", Rectangle(-476, -187, 25));
		AddSpawnPoint("f_dcapital_106.Id3", "f_dcapital_106", Rectangle(-1171, -78, 25));
		AddSpawnPoint("f_dcapital_106.Id3", "f_dcapital_106", Rectangle(-892, 1421, 25));
		AddSpawnPoint("f_dcapital_106.Id3", "f_dcapital_106", Rectangle(-1569, -255, 25));

		// 'Bishop_Hart' GenType 16 Spawn Points
		AddSpawnPoint("f_dcapital_106.Id4", "f_dcapital_106", Rectangle(2129, 1434, 25));
		AddSpawnPoint("f_dcapital_106.Id4", "f_dcapital_106", Rectangle(1742, 1171, 25));
		AddSpawnPoint("f_dcapital_106.Id4", "f_dcapital_106", Rectangle(1308, 1237, 25));
		AddSpawnPoint("f_dcapital_106.Id4", "f_dcapital_106", Rectangle(1314, 666, 25));
		AddSpawnPoint("f_dcapital_106.Id4", "f_dcapital_106", Rectangle(1550, 750, 25));
		AddSpawnPoint("f_dcapital_106.Id4", "f_dcapital_106", Rectangle(1974, 333, 25));
		AddSpawnPoint("f_dcapital_106.Id4", "f_dcapital_106", Rectangle(2049, 57, 25));
		AddSpawnPoint("f_dcapital_106.Id4", "f_dcapital_106", Rectangle(997, 583, 25));
		AddSpawnPoint("f_dcapital_106.Id4", "f_dcapital_106", Rectangle(940, 1100, 25));
		AddSpawnPoint("f_dcapital_106.Id4", "f_dcapital_106", Rectangle(383, 496, 25));
		AddSpawnPoint("f_dcapital_106.Id4", "f_dcapital_106", Rectangle(464, 942, 25));
		AddSpawnPoint("f_dcapital_106.Id4", "f_dcapital_106", Rectangle(124, 1532, 25));
		AddSpawnPoint("f_dcapital_106.Id4", "f_dcapital_106", Rectangle(631, 1688, 25));
		AddSpawnPoint("f_dcapital_106.Id4", "f_dcapital_106", Rectangle(766, 1467, 25));
		AddSpawnPoint("f_dcapital_106.Id4", "f_dcapital_106", Rectangle(375, 1118, 25));

		// 'Bishop_Point' GenType 17 Spawn Points
		AddSpawnPoint("f_dcapital_106.Id5", "f_dcapital_106", Rectangle(643, 862, 25));
		AddSpawnPoint("f_dcapital_106.Id5", "f_dcapital_106", Rectangle(792, 547, 25));
		AddSpawnPoint("f_dcapital_106.Id5", "f_dcapital_106", Rectangle(805, 989, 25));
		AddSpawnPoint("f_dcapital_106.Id5", "f_dcapital_106", Rectangle(682, 1197, 25));
		AddSpawnPoint("f_dcapital_106.Id5", "f_dcapital_106", Rectangle(1015, 988, 25));
		AddSpawnPoint("f_dcapital_106.Id5", "f_dcapital_106", Rectangle(1241, 804, 25));
		AddSpawnPoint("f_dcapital_106.Id5", "f_dcapital_106", Rectangle(1256, 593, 25));
		AddSpawnPoint("f_dcapital_106.Id5", "f_dcapital_106", Rectangle(1472, 757, 25));
		AddSpawnPoint("f_dcapital_106.Id5", "f_dcapital_106", Rectangle(1772, 797, 25));
		AddSpawnPoint("f_dcapital_106.Id5", "f_dcapital_106", Rectangle(1648, 441, 25));
		AddSpawnPoint("f_dcapital_106.Id5", "f_dcapital_106", Rectangle(1968, 408, 25));
		AddSpawnPoint("f_dcapital_106.Id5", "f_dcapital_106", Rectangle(1931, 178, 25));
		AddSpawnPoint("f_dcapital_106.Id5", "f_dcapital_106", Rectangle(2161, 170, 25));
		AddSpawnPoint("f_dcapital_106.Id5", "f_dcapital_106", Rectangle(2134, 452, 25));
		AddSpawnPoint("f_dcapital_106.Id5", "f_dcapital_106", Rectangle(2007, 1493, 25));
		AddSpawnPoint("f_dcapital_106.Id5", "f_dcapital_106", Rectangle(1909, 1232, 25));
		AddSpawnPoint("f_dcapital_106.Id5", "f_dcapital_106", Rectangle(1660, 1352, 25));
		AddSpawnPoint("f_dcapital_106.Id5", "f_dcapital_106", Rectangle(1586, 1112, 25));
		AddSpawnPoint("f_dcapital_106.Id5", "f_dcapital_106", Rectangle(1464, 1175, 25));
		AddSpawnPoint("f_dcapital_106.Id5", "f_dcapital_106", Rectangle(1224, 1133, 25));
		AddSpawnPoint("f_dcapital_106.Id5", "f_dcapital_106", Rectangle(609, 1392, 25));
		AddSpawnPoint("f_dcapital_106.Id5", "f_dcapital_106", Rectangle(761, 1674, 25));
		AddSpawnPoint("f_dcapital_106.Id5", "f_dcapital_106", Rectangle(708, 1907, 25));
		AddSpawnPoint("f_dcapital_106.Id5", "f_dcapital_106", Rectangle(852, 1748, 25));
		AddSpawnPoint("f_dcapital_106.Id5", "f_dcapital_106", Rectangle(413, 1589, 25));
		AddSpawnPoint("f_dcapital_106.Id5", "f_dcapital_106", Rectangle(81, 1351, 25));
		AddSpawnPoint("f_dcapital_106.Id5", "f_dcapital_106", Rectangle(247, 1345, 25));
		AddSpawnPoint("f_dcapital_106.Id5", "f_dcapital_106", Rectangle(254, 1155, 25));
		AddSpawnPoint("f_dcapital_106.Id5", "f_dcapital_106", Rectangle(316, 1534, 25));
		AddSpawnPoint("f_dcapital_106.Id5", "f_dcapital_106", Rectangle(452, 566, 25));
		AddSpawnPoint("f_dcapital_106.Id5", "f_dcapital_106", Rectangle(290, 814, 25));
		AddSpawnPoint("f_dcapital_106.Id5", "f_dcapital_106", Rectangle(795, 700, 25));
		AddSpawnPoint("f_dcapital_106.Id5", "f_dcapital_106", Rectangle(156, 1433, 25));
		AddSpawnPoint("f_dcapital_106.Id5", "f_dcapital_106", Rectangle(1754, 1278, 25));
		AddSpawnPoint("f_dcapital_106.Id5", "f_dcapital_106", Rectangle(1854, 437, 25));
		AddSpawnPoint("f_dcapital_106.Id5", "f_dcapital_106", Rectangle(1463, 439, 25));

		// 'Bishop_Point' GenType 23 Spawn Points
		AddSpawnPoint("f_dcapital_106.Id6", "f_dcapital_106", Rectangle(-379, 334, 25));
		AddSpawnPoint("f_dcapital_106.Id6", "f_dcapital_106", Rectangle(-399, -259, 25));
		AddSpawnPoint("f_dcapital_106.Id6", "f_dcapital_106", Rectangle(-125, 29, 25));
		AddSpawnPoint("f_dcapital_106.Id6", "f_dcapital_106", Rectangle(-488, 34, 25));
	}
}
