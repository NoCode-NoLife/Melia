//--- Melia Script -----------------------------------------------------------
// Rukas Plateau Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_rokas_29'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FRokas29MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_rokas_29", MonsterId.Hogma_Warrior, Properties("MHP", 52495, "MINPATK", 1176, "MAXPATK", 1347, "MINMATK", 1176, "MAXMATK", 1347, "DEF", 205, "MDEF", 205));
		AddPropertyOverrides("f_rokas_29", MonsterId.Hogma_Combat, Properties("MHP", 52601, "MINPATK", 1177, "MAXPATK", 1349, "MINMATK", 1177, "MAXMATK", 1349, "DEF", 207, "MDEF", 207));
		AddPropertyOverrides("f_rokas_29", MonsterId.Woodfung, Properties("MHP", 52796, "MINPATK", 1180, "MAXPATK", 1352, "MINMATK", 1180, "MAXMATK", 1352, "DEF", 210, "MDEF", 210));
		AddPropertyOverrides("f_rokas_29", MonsterId.Zinute_Big, Properties("MHP", 53048, "MINPATK", 1183, "MAXPATK", 1356, "MINMATK", 1183, "MAXMATK", 1356, "DEF", 213, "MDEF", 213));
		AddPropertyOverrides("f_rokas_29", MonsterId.Zinutekas_Q1, Properties("MHP", 53347, "MINPATK", 1187, "MAXPATK", 1360, "MINMATK", 1187, "MAXMATK", 1360, "DEF", 218, "MDEF", 218));

		// Monster Spawners ---------------------------------

		AddSpawner("f_rokas_29.Id1", MonsterId.Hogma_Warrior, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_29.Id2", MonsterId.Rootcrystal_05, 12, 15, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_rokas_29.Id3", MonsterId.Hogma_Combat, 9, 12, TimeSpan.FromMilliseconds(35000), TendencyType.Peaceful);
		AddSpawner("f_rokas_29.Id4", MonsterId.Hogma_Combat, 25, 33, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);
		AddSpawner("f_rokas_29.Id5", MonsterId.Hogma_Combat, 18, 23, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_29.Id6", MonsterId.Hogma_Warrior, 19, 25, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);
		AddSpawner("f_rokas_29.Id7", MonsterId.Woodfung, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Hogma_Warrior' GenType 57 Spawn Points
		AddSpawnPoint("f_rokas_29.Id1", "f_rokas_29", Rectangle(227, 618, 9999));

		// 'Rootcrystal_05' GenType 600 Spawn Points
		AddSpawnPoint("f_rokas_29.Id2", "f_rokas_29", Rectangle(2292, 107, 30));
		AddSpawnPoint("f_rokas_29.Id2", "f_rokas_29", Rectangle(1089, 275, 30));
		AddSpawnPoint("f_rokas_29.Id2", "f_rokas_29", Rectangle(-725, 516, 30));
		AddSpawnPoint("f_rokas_29.Id2", "f_rokas_29", Rectangle(-652, -1930, 30));
		AddSpawnPoint("f_rokas_29.Id2", "f_rokas_29", Rectangle(-960, 1896, 30));
		AddSpawnPoint("f_rokas_29.Id2", "f_rokas_29", Rectangle(1098, -691, 30));
		AddSpawnPoint("f_rokas_29.Id2", "f_rokas_29", Rectangle(2539, 802, 30));
		AddSpawnPoint("f_rokas_29.Id2", "f_rokas_29", Rectangle(208, 718, 30));
		AddSpawnPoint("f_rokas_29.Id2", "f_rokas_29", Rectangle(-402, -335, 30));
		AddSpawnPoint("f_rokas_29.Id2", "f_rokas_29", Rectangle(37, -303, 30));
		AddSpawnPoint("f_rokas_29.Id2", "f_rokas_29", Rectangle(-697, -892, 30));
		AddSpawnPoint("f_rokas_29.Id2", "f_rokas_29", Rectangle(-767, -1614, 30));
		AddSpawnPoint("f_rokas_29.Id2", "f_rokas_29", Rectangle(596, 1987, 30));

		// 'Hogma_Combat' GenType 634 Spawn Points
		AddSpawnPoint("f_rokas_29.Id3", "f_rokas_29", Rectangle(-835, 645, 400));
		AddSpawnPoint("f_rokas_29.Id3", "f_rokas_29", Rectangle(-385, -1549, 400));

		// 'Hogma_Combat' GenType 635 Spawn Points
		AddSpawnPoint("f_rokas_29.Id4", "f_rokas_29", Rectangle(-110, -292, 9999));

		// 'Hogma_Combat' GenType 642 Spawn Points
		AddSpawnPoint("f_rokas_29.Id5", "f_rokas_29", Rectangle(2178, 29, 50));
		AddSpawnPoint("f_rokas_29.Id5", "f_rokas_29", Rectangle(1092, 369, 50));
		AddSpawnPoint("f_rokas_29.Id5", "f_rokas_29", Rectangle(2248, 245, 50));
		AddSpawnPoint("f_rokas_29.Id5", "f_rokas_29", Rectangle(2354, 428, 50));
		AddSpawnPoint("f_rokas_29.Id5", "f_rokas_29", Rectangle(2467, 297, 50));
		AddSpawnPoint("f_rokas_29.Id5", "f_rokas_29", Rectangle(2435, 88, 50));
		AddSpawnPoint("f_rokas_29.Id5", "f_rokas_29", Rectangle(2282, -220, 50));
		AddSpawnPoint("f_rokas_29.Id5", "f_rokas_29", Rectangle(1761, 386, 50));
		AddSpawnPoint("f_rokas_29.Id5", "f_rokas_29", Rectangle(2035, 214, 50));
		AddSpawnPoint("f_rokas_29.Id5", "f_rokas_29", Rectangle(1321, 425, 50));
		AddSpawnPoint("f_rokas_29.Id5", "f_rokas_29", Rectangle(1540, 529, 50));

		// 'Hogma_Warrior' GenType 643 Spawn Points
		AddSpawnPoint("f_rokas_29.Id6", "f_rokas_29", Rectangle(2268, 67, 40));
		AddSpawnPoint("f_rokas_29.Id6", "f_rokas_29", Rectangle(2248, 259, 40));
		AddSpawnPoint("f_rokas_29.Id6", "f_rokas_29", Rectangle(1834, 333, 40));
		AddSpawnPoint("f_rokas_29.Id6", "f_rokas_29", Rectangle(1572, 582, 40));
		AddSpawnPoint("f_rokas_29.Id6", "f_rokas_29", Rectangle(1315, 473, 40));
		AddSpawnPoint("f_rokas_29.Id6", "f_rokas_29", Rectangle(2484, 221, 40));
		AddSpawnPoint("f_rokas_29.Id6", "f_rokas_29", Rectangle(2251, -128, 40));
		AddSpawnPoint("f_rokas_29.Id6", "f_rokas_29", Rectangle(2170, 165, 40));
		AddSpawnPoint("f_rokas_29.Id6", "f_rokas_29", Rectangle(2301, 455, 40));

		// 'Woodfung' GenType 644 Spawn Points
		AddSpawnPoint("f_rokas_29.Id7", "f_rokas_29", Rectangle(-727, -427, 40));
		AddSpawnPoint("f_rokas_29.Id7", "f_rokas_29", Rectangle(-122, -292, 40));
		AddSpawnPoint("f_rokas_29.Id7", "f_rokas_29", Rectangle(-2, -121, 40));
		AddSpawnPoint("f_rokas_29.Id7", "f_rokas_29", Rectangle(-475, -382, 40));
		AddSpawnPoint("f_rokas_29.Id7", "f_rokas_29", Rectangle(-1063, 547, 40));
		AddSpawnPoint("f_rokas_29.Id7", "f_rokas_29", Rectangle(-931, 741, 40));
		AddSpawnPoint("f_rokas_29.Id7", "f_rokas_29", Rectangle(-719, 514, 40));
		AddSpawnPoint("f_rokas_29.Id7", "f_rokas_29", Rectangle(-1748, 837, 40));
		AddSpawnPoint("f_rokas_29.Id7", "f_rokas_29", Rectangle(-1788, 1230, 40));
		AddSpawnPoint("f_rokas_29.Id7", "f_rokas_29", Rectangle(-1660, 1037, 40));
		AddSpawnPoint("f_rokas_29.Id7", "f_rokas_29", Rectangle(-1071, 1902, 40));
		AddSpawnPoint("f_rokas_29.Id7", "f_rokas_29", Rectangle(-922, 1960, 40));
		AddSpawnPoint("f_rokas_29.Id7", "f_rokas_29", Rectangle(392, 1773, 40));
		AddSpawnPoint("f_rokas_29.Id7", "f_rokas_29", Rectangle(443, 2094, 40));
		AddSpawnPoint("f_rokas_29.Id7", "f_rokas_29", Rectangle(232, 1948, 40));
	}
}
