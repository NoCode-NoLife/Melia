//--- Melia Script -----------------------------------------------------------
// Tevhrin Stalactite Cave Section 4 Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_limestonecave_52_4'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DLimestonecave524MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_limestonecave_52_4", MonsterId.Zolem_Green, Properties("MHP", 496851, "MINPATK", 6890, "MAXPATK", 8370, "MINMATK", 6890, "MAXMATK", 8370, "DEF", 78968, "MDEF", 78968));
		AddPropertyOverrides("d_limestonecave_52_4", MonsterId.Flamag_Green, Properties("MHP", 499404, "MINPATK", 6923, "MAXPATK", 8410, "MINMATK", 6923, "MAXMATK", 8410, "DEF", 79992, "MDEF", 79992));
		AddPropertyOverrides("d_limestonecave_52_4", MonsterId.Flamme_Archer_Green, Properties("MHP", 502009, "MINPATK", 6956, "MAXPATK", 8451, "MINMATK", 6956, "MAXMATK", 8451, "DEF", 81037, "MDEF", 81037));
		AddPropertyOverrides("d_limestonecave_52_4", MonsterId.Boss_Riteris_Q2, Properties("MHP", 1513994, "MINPATK", 9869, "MAXPATK", 11991, "MINMATK", 9869, "MAXMATK", 11991, "DEF", 115910, "MDEF", 115910));
		AddPropertyOverrides("d_limestonecave_52_4", MonsterId.Boss_Flammidus_Q1, Properties("MHP", 1522108, "MINPATK", 9918, "MAXPATK", 12051, "MINMATK", 9918, "MAXMATK", 12051, "DEF", 117442, "MDEF", 117442));

		// Monster Spawners ---------------------------------

		AddSpawner("d_limestonecave_52_4.Id1", MonsterId.Zolem_Green, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_4.Id2", MonsterId.Flamag_Green, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_4.Id3", MonsterId.Flamme_Archer_Green, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_4.Id4", MonsterId.Zolem_Green, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_4.Id5", MonsterId.Rootcrystal_04, 19, 25, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Zolem_Green' GenType 12 Spawn Points
		AddSpawnPoint("d_limestonecave_52_4.Id1", "d_limestonecave_52_4", Rectangle(2279, -1013, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id1", "d_limestonecave_52_4", Rectangle(1631, -315, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id1", "d_limestonecave_52_4", Rectangle(1501, -1025, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id1", "d_limestonecave_52_4", Rectangle(1233, -1153, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id1", "d_limestonecave_52_4", Rectangle(1224, -921, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id1", "d_limestonecave_52_4", Rectangle(735, -1892, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id1", "d_limestonecave_52_4", Rectangle(113, -1394, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id1", "d_limestonecave_52_4", Rectangle(-67, -887, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id1", "d_limestonecave_52_4", Rectangle(-447, -72, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id1", "d_limestonecave_52_4", Rectangle(-907, -241, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id1", "d_limestonecave_52_4", Rectangle(-1545, -806, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id1", "d_limestonecave_52_4", Rectangle(-46, 367, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id1", "d_limestonecave_52_4", Rectangle(2268, -948, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id1", "d_limestonecave_52_4", Rectangle(873, -1916, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id1", "d_limestonecave_52_4", Rectangle(1037, -1767, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id1", "d_limestonecave_52_4", Rectangle(793, -1621, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id1", "d_limestonecave_52_4", Rectangle(770, -1471, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id1", "d_limestonecave_52_4", Rectangle(1055, -1674, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id1", "d_limestonecave_52_4", Rectangle(-144, -984, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id1", "d_limestonecave_52_4", Rectangle(-341, -846, 45));

		// 'Flamag_Green' GenType 13 Spawn Points
		AddSpawnPoint("d_limestonecave_52_4.Id2", "d_limestonecave_52_4", Rectangle(-25, 379, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id2", "d_limestonecave_52_4", Rectangle(-513, 75, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id2", "d_limestonecave_52_4", Rectangle(-614, -434, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id2", "d_limestonecave_52_4", Rectangle(-1695, -883, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id2", "d_limestonecave_52_4", Rectangle(101, -1315, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id2", "d_limestonecave_52_4", Rectangle(927, -1700, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id2", "d_limestonecave_52_4", Rectangle(1248, -1025, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id2", "d_limestonecave_52_4", Rectangle(1104, -925, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id2", "d_limestonecave_52_4", Rectangle(1492, -874, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id2", "d_limestonecave_52_4", Rectangle(1640, -158, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id2", "d_limestonecave_52_4", Rectangle(2157, -993, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id2", "d_limestonecave_52_4", Rectangle(1760, -362, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id2", "d_limestonecave_52_4", Rectangle(1723, -53, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id2", "d_limestonecave_52_4", Rectangle(2085, -1188, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id2", "d_limestonecave_52_4", Rectangle(2248, -885, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id2", "d_limestonecave_52_4", Rectangle(607, -1690, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id2", "d_limestonecave_52_4", Rectangle(461, -1692, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id2", "d_limestonecave_52_4", Rectangle(-165, -739, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id2", "d_limestonecave_52_4", Rectangle(-273, -797, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id2", "d_limestonecave_52_4", Rectangle(-291, -961, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id2", "d_limestonecave_52_4", Rectangle(-155, -869, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id2", "d_limestonecave_52_4", Rectangle(-185, -1041, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id2", "d_limestonecave_52_4", Rectangle(-226, -890, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id2", "d_limestonecave_52_4", Rectangle(-430, -354, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id2", "d_limestonecave_52_4", Rectangle(-1559, -896, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id2", "d_limestonecave_52_4", Rectangle(-1512, -526, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id2", "d_limestonecave_52_4", Rectangle(-1775, -683, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id2", "d_limestonecave_52_4", Rectangle(-1548, -694, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id2", "d_limestonecave_52_4", Rectangle(-1633, -628, 45));

		// 'Flamme_Archer_Green' GenType 14 Spawn Points
		AddSpawnPoint("d_limestonecave_52_4.Id3", "d_limestonecave_52_4", Rectangle(2201, -1071, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id3", "d_limestonecave_52_4", Rectangle(1872, -149, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id3", "d_limestonecave_52_4", Rectangle(1397, -802, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id3", "d_limestonecave_52_4", Rectangle(1317, -1123, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id3", "d_limestonecave_52_4", Rectangle(1420, -955, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id3", "d_limestonecave_52_4", Rectangle(926, -1607, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id3", "d_limestonecave_52_4", Rectangle(420, -1609, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id3", "d_limestonecave_52_4", Rectangle(101, -1434, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id3", "d_limestonecave_52_4", Rectangle(-63, -1270, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id3", "d_limestonecave_52_4", Rectangle(-383, -672, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id3", "d_limestonecave_52_4", Rectangle(-923, -260, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id3", "d_limestonecave_52_4", Rectangle(-980, 122, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id3", "d_limestonecave_52_4", Rectangle(-18, 408, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id3", "d_limestonecave_52_4", Rectangle(-1670, -710, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id3", "d_limestonecave_52_4", Rectangle(1756, -219, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id3", "d_limestonecave_52_4", Rectangle(2108, -1043, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id3", "d_limestonecave_52_4", Rectangle(2058, -1531, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id3", "d_limestonecave_52_4", Rectangle(2089, -1414, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id3", "d_limestonecave_52_4", Rectangle(2003, -1670, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id3", "d_limestonecave_52_4", Rectangle(1963, -1757, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id3", "d_limestonecave_52_4", Rectangle(2117, -1753, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id3", "d_limestonecave_52_4", Rectangle(2133, -1665, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id3", "d_limestonecave_52_4", Rectangle(2079, -1700, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id3", "d_limestonecave_52_4", Rectangle(902, -1847, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id3", "d_limestonecave_52_4", Rectangle(698, -1769, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id3", "d_limestonecave_52_4", Rectangle(763, -1718, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id3", "d_limestonecave_52_4", Rectangle(-1, -1180, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id3", "d_limestonecave_52_4", Rectangle(255, -1239, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id3", "d_limestonecave_52_4", Rectangle(236, -1337, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id3", "d_limestonecave_52_4", Rectangle(-68, -1348, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id3", "d_limestonecave_52_4", Rectangle(-444, -526, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id3", "d_limestonecave_52_4", Rectangle(-766, -405, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id3", "d_limestonecave_52_4", Rectangle(-448, -62, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id3", "d_limestonecave_52_4", Rectangle(-471, 195, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id3", "d_limestonecave_52_4", Rectangle(-638, 167, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id3", "d_limestonecave_52_4", Rectangle(-728, 65, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id3", "d_limestonecave_52_4", Rectangle(-815, -28, 45));
		AddSpawnPoint("d_limestonecave_52_4.Id3", "d_limestonecave_52_4", Rectangle(-1642, -874, 45));

		// 'Zolem_Green' GenType 15 Spawn Points
		AddSpawnPoint("d_limestonecave_52_4.Id4", "d_limestonecave_52_4", Rectangle(1093, -1292, 9999));

		// 'Rootcrystal_04' GenType 16 Spawn Points
		AddSpawnPoint("d_limestonecave_52_4.Id5", "d_limestonecave_52_4", Rectangle(2087, -1874, 15));
		AddSpawnPoint("d_limestonecave_52_4.Id5", "d_limestonecave_52_4", Rectangle(2159, -1137, 15));
		AddSpawnPoint("d_limestonecave_52_4.Id5", "d_limestonecave_52_4", Rectangle(2184, -894, 15));
		AddSpawnPoint("d_limestonecave_52_4.Id5", "d_limestonecave_52_4", Rectangle(2374, -533, 15));
		AddSpawnPoint("d_limestonecave_52_4.Id5", "d_limestonecave_52_4", Rectangle(2537, -371, 15));
		AddSpawnPoint("d_limestonecave_52_4.Id5", "d_limestonecave_52_4", Rectangle(2177, -233, 15));
		AddSpawnPoint("d_limestonecave_52_4.Id5", "d_limestonecave_52_4", Rectangle(1797, -141, 15));
		AddSpawnPoint("d_limestonecave_52_4.Id5", "d_limestonecave_52_4", Rectangle(1431, -699, 15));
		AddSpawnPoint("d_limestonecave_52_4.Id5", "d_limestonecave_52_4", Rectangle(1296, -1189, 15));
		AddSpawnPoint("d_limestonecave_52_4.Id5", "d_limestonecave_52_4", Rectangle(999, -1669, 15));
		AddSpawnPoint("d_limestonecave_52_4.Id5", "d_limestonecave_52_4", Rectangle(724, -1808, 15));
		AddSpawnPoint("d_limestonecave_52_4.Id5", "d_limestonecave_52_4", Rectangle(362, -1488, 15));
		AddSpawnPoint("d_limestonecave_52_4.Id5", "d_limestonecave_52_4", Rectangle(142, -1206, 15));
		AddSpawnPoint("d_limestonecave_52_4.Id5", "d_limestonecave_52_4", Rectangle(-107, -1099, 15));
		AddSpawnPoint("d_limestonecave_52_4.Id5", "d_limestonecave_52_4", Rectangle(-208, -966, 15));
		AddSpawnPoint("d_limestonecave_52_4.Id5", "d_limestonecave_52_4", Rectangle(-366, -621, 15));
		AddSpawnPoint("d_limestonecave_52_4.Id5", "d_limestonecave_52_4", Rectangle(-534, -356, 15));
		AddSpawnPoint("d_limestonecave_52_4.Id5", "d_limestonecave_52_4", Rectangle(-875, -175, 15));
		AddSpawnPoint("d_limestonecave_52_4.Id5", "d_limestonecave_52_4", Rectangle(-729, 210, 15));
		AddSpawnPoint("d_limestonecave_52_4.Id5", "d_limestonecave_52_4", Rectangle(-314, -114, 15));
		AddSpawnPoint("d_limestonecave_52_4.Id5", "d_limestonecave_52_4", Rectangle(-184, 284, 15));
		AddSpawnPoint("d_limestonecave_52_4.Id5", "d_limestonecave_52_4", Rectangle(157, 358, 15));
		AddSpawnPoint("d_limestonecave_52_4.Id5", "d_limestonecave_52_4", Rectangle(-1678, -668, 15));
		AddSpawnPoint("d_limestonecave_52_4.Id5", "d_limestonecave_52_4", Rectangle(-1401, 631, 15));
		AddSpawnPoint("d_limestonecave_52_4.Id5", "d_limestonecave_52_4", Rectangle(-1225, 300, 15));
	}
}
