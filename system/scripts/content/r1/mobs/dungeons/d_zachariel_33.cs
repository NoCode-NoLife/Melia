//--- Melia Script -----------------------------------------------------------
// Royal Mausoleum 2F Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_zachariel_33'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DZachariel33MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_zachariel_33", MonsterId.Beetle, Properties("MHP", 64238, "MINPATK", 1327, "MAXPATK", 1533, "MINMATK", 1327, "MAXMATK", 1533, "DEF", 385, "MDEF", 385));
		AddPropertyOverrides("d_zachariel_33", MonsterId.Vesper, Properties("MHP", 65012, "MINPATK", 1337, "MAXPATK", 1545, "MINMATK", 1337, "MAXMATK", 1545, "DEF", 396, "MDEF", 396));
		AddPropertyOverrides("d_zachariel_33", MonsterId.Wolf_Statue, Properties("MHP", 65802, "MINPATK", 1347, "MAXPATK", 1557, "MINMATK", 1347, "MAXMATK", 1557, "DEF", 409, "MDEF", 409));
		AddPropertyOverrides("d_zachariel_33", MonsterId.Tombsinker, Properties("MHP", 66609, "MINPATK", 1357, "MAXPATK", 1570, "MINMATK", 1357, "MAXMATK", 1570, "DEF", 421, "MDEF", 421));
		AddPropertyOverrides("d_zachariel_33", MonsterId.Echad, Properties("MHP", 67431, "MINPATK", 1368, "MAXPATK", 1583, "MINMATK", 1368, "MAXMATK", 1583, "DEF", 433, "MDEF", 433));

		// Monster Spawners ---------------------------------

		AddSpawner("d_zachariel_33.Id1", MonsterId.Beetle, min: 4, max: 5, tendency: TendencyType.Aggressive);
		AddSpawner("d_zachariel_33.Id2", MonsterId.Vesper, min: 6, max: 7, tendency: TendencyType.Aggressive);
		AddSpawner("d_zachariel_33.Id3", MonsterId.Rootcrystal_05, min: 18, max: 24, respawn: TimeSpan.FromMilliseconds(15000), tendency: TendencyType.Peaceful);
		AddSpawner("d_zachariel_33.Id4", MonsterId.Wolf_Statue, min: 15, max: 20, tendency: TendencyType.Aggressive);
		AddSpawner("d_zachariel_33.Id5", MonsterId.Beetle, min: 15, max: 20, tendency: TendencyType.Aggressive);
		AddSpawner("d_zachariel_33.Id6", MonsterId.Vesper, min: 15, max: 20, tendency: TendencyType.Aggressive);
		AddSpawner("d_zachariel_33.Id7", MonsterId.Wolf_Statue, min: 5, max: 6, tendency: TendencyType.Aggressive);
		AddSpawner("d_zachariel_33.Id8", MonsterId.Tombsinker, min: 12, max: 15, tendency: TendencyType.Aggressive);
		AddSpawner("d_zachariel_33.Id9", MonsterId.Wolf_Statue, min: 4, max: 5, tendency: TendencyType.Peaceful);
		AddSpawner("d_zachariel_33.Id10", MonsterId.Beetle_Elite, amount: 3, tendency: TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Beetle' GenType 17 Spawn Points
		AddSpawnPoint("d_zachariel_33.Id1", "d_zachariel_33", Rectangle(-607, 97, 35));
		AddSpawnPoint("d_zachariel_33.Id1", "d_zachariel_33", Rectangle(-87, 206, 35));
		AddSpawnPoint("d_zachariel_33.Id1", "d_zachariel_33", Rectangle(325, -667, 35));
		AddSpawnPoint("d_zachariel_33.Id1", "d_zachariel_33", Rectangle(-889, 154, 35));
		AddSpawnPoint("d_zachariel_33.Id1", "d_zachariel_33", Rectangle(121, 294, 35));
		AddSpawnPoint("d_zachariel_33.Id1", "d_zachariel_33", Rectangle(-174, 97, 35));
		AddSpawnPoint("d_zachariel_33.Id1", "d_zachariel_33", Rectangle(59, 514, 35));
		AddSpawnPoint("d_zachariel_33.Id1", "d_zachariel_33", Rectangle(-390, 186, 35));
		AddSpawnPoint("d_zachariel_33.Id1", "d_zachariel_33", Rectangle(-1565, 194, 35));
		AddSpawnPoint("d_zachariel_33.Id1", "d_zachariel_33", Rectangle(33, 191, 35));
		AddSpawnPoint("d_zachariel_33.Id1", "d_zachariel_33", Rectangle(91, 68, 35));
		AddSpawnPoint("d_zachariel_33.Id1", "d_zachariel_33", Rectangle(22, 696, 35));
		AddSpawnPoint("d_zachariel_33.Id1", "d_zachariel_33", Rectangle(345, 241, 35));
		AddSpawnPoint("d_zachariel_33.Id1", "d_zachariel_33", Rectangle(-264, 294, 35));

		// 'Vesper' GenType 18 Spawn Points
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-199, -585, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-76, -1936, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-217, -1961, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-99, -2343, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(16, -1969, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-256, -849, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-769, -725, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-200, -270, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-29, -740, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-126, -1302, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-1419, -818, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-1652, -792, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-1377, -667, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-1496, -734, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-1639, 154, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-1507, 342, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-1729, 301, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-1390, 252, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-671, 279, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-1033, 263, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-11, 799, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-98, 39, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(64, 176, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(47, 375, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(22, 1000, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-106, -2189, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-66, -2253, 30));

		// 'Rootcrystal_05' GenType 600 Spawn Points
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(-192, -551, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(-133, -1213, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(-95, -2356, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(-143, -1979, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(188, -675, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(-494, -754, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(-183, 42, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(-397, 302, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(119, 215, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(-734, 123, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(-1121, 256, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(-1548, 248, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(-1542, 12, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(-1575, -563, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(-1354, -853, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(-1902, -791, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(1187, 252, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(1952, 243, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(2025, -337, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(2282, -36, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(2243, 448, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(38, 844, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(219, 1539, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(-41, 1403, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(30, 1848, 30));

		// 'Wolf_Statue' GenType 3012 Spawn Points
		AddSpawnPoint("d_zachariel_33.Id4", "d_zachariel_33", Rectangle(89, 231, 9999));

		// 'Beetle' GenType 3013 Spawn Points
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-348, -802, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-132, -889, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(34, -779, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(0, -652, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-185, -744, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(37, -891, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-313, -881, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-122, -1232, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-142, -1449, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-234, -2028, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-16, -1950, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-189, -1897, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-108, -2132, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-1601, 163, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-1598, 298, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-1514, 206, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-1367, 266, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-903, 252, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-699, 265, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-758, 136, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-888, 78, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-433, 287, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-390, 117, 30));

		// 'Vesper' GenType 3014 Spawn Points
		AddSpawnPoint("d_zachariel_33.Id6", "d_zachariel_33", Rectangle(76, 1433, 9999));

		// 'Wolf_Statue' GenType 3015 Spawn Points
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(-75, -1878, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(-69, 225, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(-245, -1962, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(-90, -2053, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(-140, -1967, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(-194, -2052, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(-263, 162, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(-76, 83, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(68, 324, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(-563, 256, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(30, 535, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(277, 274, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(81, 88, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(-169, -118, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(-187, -1879, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(-609, -753, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(-411, -594, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(-285, -890, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(70, -926, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(55, -614, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(-32, -798, 30));

		// 'Tombsinker' GenType 3018 Spawn Points
		AddSpawnPoint("d_zachariel_33.Id8", "d_zachariel_33", Rectangle(26, 274, 9999));

		// 'Wolf_Statue' GenType 3019 Spawn Points
		AddSpawnPoint("d_zachariel_33.Id9", "d_zachariel_33", Rectangle(341, -665, 35));
		AddSpawnPoint("d_zachariel_33.Id9", "d_zachariel_33", Rectangle(582, -648, 35));
		AddSpawnPoint("d_zachariel_33.Id9", "d_zachariel_33", Rectangle(823, -626, 35));
		AddSpawnPoint("d_zachariel_33.Id9", "d_zachariel_33", Rectangle(1008, -705, 35));
		AddSpawnPoint("d_zachariel_33.Id9", "d_zachariel_33", Rectangle(1070, -567, 35));
		AddSpawnPoint("d_zachariel_33.Id9", "d_zachariel_33", Rectangle(689, -545, 35));
		AddSpawnPoint("d_zachariel_33.Id9", "d_zachariel_33", Rectangle(786, -762, 35));

		// 'Beetle_Elite' GenType 3022 Spawn Points
		AddSpawnPoint("d_zachariel_33.Id10", "d_zachariel_33", Rectangle(-22, -713, 9999));
	}
}
