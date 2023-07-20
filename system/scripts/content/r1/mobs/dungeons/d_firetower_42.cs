//--- Melia Script -----------------------------------------------------------
// Mage Tower 2F Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_firetower_42'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DFiretower42MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_firetower_42", MonsterId.Tower_Of_Firepuppet, Properties("MHP", 95434, "MINPATK", 1728, "MAXPATK", 2026, "MINMATK", 1728, "MAXMATK", 2026, "DEF", 1030, "MDEF", 1030));
		AddPropertyOverrides("d_firetower_42", MonsterId.Slime_Elite, Properties("MHP", 96577, "MINPATK", 1743, "MAXPATK", 2044, "MINMATK", 1743, "MAXMATK", 2044, "DEF", 1067, "MDEF", 1067));
		AddPropertyOverrides("d_firetower_42", MonsterId.Blindlem, Properties("MHP", 97762, "MINPATK", 1758, "MAXPATK", 2063, "MINMATK", 1758, "MAXMATK", 2063, "DEF", 1106, "MDEF", 1106));
		AddPropertyOverrides("d_firetower_42", MonsterId.Belegg, Properties("MHP", 98988, "MINPATK", 1774, "MAXPATK", 2082, "MINMATK", 1774, "MAXMATK", 2082, "DEF", 1145, "MDEF", 1145));
		AddPropertyOverrides("d_firetower_42", MonsterId.Chromadog, Properties("MHP", 100252, "MINPATK", 1790, "MAXPATK", 2102, "MINMATK", 1790, "MAXMATK", 2102, "DEF", 1187, "MDEF", 1187));
		AddPropertyOverrides("d_firetower_42", MonsterId.Slime_Elite_Big, Properties("MHP", 101554, "MINPATK", 1807, "MAXPATK", 2123, "MINMATK", 1807, "MAXMATK", 2123, "DEF", 1229, "MDEF", 1229));
		AddPropertyOverrides("d_firetower_42", MonsterId.Boss_Archon_Q2, Properties("MHP", 512403, "MINPATK", 4159, "MAXPATK", 4888, "MINMATK", 4159, "MAXMATK", 4888, "DEF", 2902, "MDEF", 2902));

		// Monster Spawners ---------------------------------

		AddSpawner("d_firetower_42.Id1", MonsterId.Rootcrystal_01, 8, 10, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("d_firetower_42.Id2", MonsterId.Tower_Of_Firepuppet, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_42.Id3", MonsterId.Slime_Elite, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_42.Id4", MonsterId.Blindlem, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_42.Id5", MonsterId.Belegg, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_42.Id6", MonsterId.Chromadog, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_42.Id7", MonsterId.Slime_Elite_Big, 3, 3, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 1 Spawn Points
		AddSpawnPoint("d_firetower_42.Id1", "d_firetower_42", Rectangle(-1233, -1565, 100));
		AddSpawnPoint("d_firetower_42.Id1", "d_firetower_42", Rectangle(-1297, -1163, 100));
		AddSpawnPoint("d_firetower_42.Id1", "d_firetower_42", Rectangle(-601, -928, 100));
		AddSpawnPoint("d_firetower_42.Id1", "d_firetower_42", Rectangle(-75, -549, 100));
		AddSpawnPoint("d_firetower_42.Id1", "d_firetower_42", Rectangle(1018, -563, 100));
		AddSpawnPoint("d_firetower_42.Id1", "d_firetower_42", Rectangle(1019, -1276, 100));
		AddSpawnPoint("d_firetower_42.Id1", "d_firetower_42", Rectangle(344, 226, 100));
		AddSpawnPoint("d_firetower_42.Id1", "d_firetower_42", Rectangle(1000, -32, 100));
		AddSpawnPoint("d_firetower_42.Id1", "d_firetower_42", Rectangle(1877, -1247, 100));
		AddSpawnPoint("d_firetower_42.Id1", "d_firetower_42", Rectangle(2036, -97, 100));

		// 'Tower_Of_Firepuppet' GenType 7 Spawn Points
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(-1317, -1290, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(1907, -9, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(-147, -661, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(1889, -1414, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(995, 85, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(-1509, -1342, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(-1639, -1163, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(-1341, -1115, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(-343, -710, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(-425, -546, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(-297, -544, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(-236, -430, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(856, 114, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(1004, 261, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(1133, 97, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(1009, -72, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(1841, -219, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(2051, -90, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(1894, -1238, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(1745, -1362, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(2031, -1364, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(1784, -1523, 25));

		// 'Slime_Elite' GenType 206 Spawn Points
		AddSpawnPoint("d_firetower_42.Id3", "d_firetower_42", Rectangle(303, 29, 35));
		AddSpawnPoint("d_firetower_42.Id3", "d_firetower_42", Rectangle(297, 255, 35));
		AddSpawnPoint("d_firetower_42.Id3", "d_firetower_42", Rectangle(1001, -187, 35));
		AddSpawnPoint("d_firetower_42.Id3", "d_firetower_42", Rectangle(1820, -164, 35));
		AddSpawnPoint("d_firetower_42.Id3", "d_firetower_42", Rectangle(2023, -158, 35));
		AddSpawnPoint("d_firetower_42.Id3", "d_firetower_42", Rectangle(985, -1267, 35));
		AddSpawnPoint("d_firetower_42.Id3", "d_firetower_42", Rectangle(995, -1450, 35));
		AddSpawnPoint("d_firetower_42.Id3", "d_firetower_42", Rectangle(1952, -1294, 35));
		AddSpawnPoint("d_firetower_42.Id3", "d_firetower_42", Rectangle(1748, -1464, 35));
		AddSpawnPoint("d_firetower_42.Id3", "d_firetower_42", Rectangle(1004, -343, 35));
		AddSpawnPoint("d_firetower_42.Id3", "d_firetower_42", Rectangle(237, -564, 35));
		AddSpawnPoint("d_firetower_42.Id3", "d_firetower_42", Rectangle(-1192, -684, 35));
		AddSpawnPoint("d_firetower_42.Id3", "d_firetower_42", Rectangle(-746, -985, 35));
		AddSpawnPoint("d_firetower_42.Id3", "d_firetower_42", Rectangle(-503, -833, 35));
		AddSpawnPoint("d_firetower_42.Id3", "d_firetower_42", Rectangle(-1499, -1023, 35));
		AddSpawnPoint("d_firetower_42.Id3", "d_firetower_42", Rectangle(-1563, -1373, 35));
		AddSpawnPoint("d_firetower_42.Id3", "d_firetower_42", Rectangle(-1003, -1379, 35));
		AddSpawnPoint("d_firetower_42.Id3", "d_firetower_42", Rectangle(1902, -433, 35));
		AddSpawnPoint("d_firetower_42.Id3", "d_firetower_42", Rectangle(1910, -627, 35));

		// 'Blindlem' GenType 210 Spawn Points
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(1025, -1356, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(1901, -1407, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(1979, -91, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(-911, -827, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(214, 134, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(265, -51, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(410, 311, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(565, 97, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(1783, -195, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(1842, -45, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(1901, -332, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(1729, -1385, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(1770, -1287, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(1939, -1260, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(2028, -1497, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(1824, -1533, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(1070, -1467, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(936, -1501, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(855, -1402, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(1034, -1206, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(924, -1254, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(1353, -1373, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(1537, -1377, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(-1021, -875, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(-1168, -830, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(-1148, -670, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(-960, -651, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(-1015, -537, 25));

		// 'Belegg' GenType 211 Spawn Points
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(-375, -448, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(-1001, -542, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(-1491, -1213, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(-1344, -1158, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(-1149, -792, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(-257, -706, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(376, -546, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(787, -561, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(-685, -1037, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(849, 124, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(334, -276, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(480, 104, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(-859, -1207, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(-416, -630, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(167, -594, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(460, -518, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(1047, -499, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(1184, -570, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(1011, 21, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(235, 26, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(-501, -865, 30));

		// 'Chromadog' GenType 220 Spawn Points
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(1890, -276, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(1806, -88, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(2056, -99, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(1920, -1225, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(1745, -1386, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(1042, -1268, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(1034, -1475, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(898, -1327, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(993, -33, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(518, 120, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(-104, -569, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(338, -558, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(1154, -564, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(1002, 215, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(-434, -634, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(890, -543, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(903, 128, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(1955, -40, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(1903, -1505, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(1941, -1409, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(1167, -1380, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(-285, -500, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(-271, -751, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(158, -553, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(342, -133, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(254, 25, 30));

		// 'Slime_Elite_Big' GenType 221 Spawn Points
		AddSpawnPoint("d_firetower_42.Id7", "d_firetower_42", Rectangle(973, 81, 9999));
	}
}
