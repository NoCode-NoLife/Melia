//--- Melia Script -----------------------------------------------------------
// Phamer Forest Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_bracken_43_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FBracken432MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_bracken_43_2.Id1", MonsterId.Dorong, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_2.Id2", MonsterId.Darong, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_2.Id3", MonsterId.Rootcrystal_03, 12, 15, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_2.Id4", MonsterId.Nukarong, 4, 5, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_2.Id5", MonsterId.Dorong, 3, 3, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_2.Id6", MonsterId.Darong, 3, 4, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_2.Id7", MonsterId.Dorong, 6, 8, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Dorong' GenType 21 Spawn Points
		AddSpawnPoint("f_bracken_43_2.Id1", "f_bracken_43_2", Rectangle(-654, -805, 50));
		AddSpawnPoint("f_bracken_43_2.Id1", "f_bracken_43_2", Rectangle(-484, -1227, 50));
		AddSpawnPoint("f_bracken_43_2.Id1", "f_bracken_43_2", Rectangle(-1855, -187, 50));
		AddSpawnPoint("f_bracken_43_2.Id1", "f_bracken_43_2", Rectangle(-2059, -157, 50));
		AddSpawnPoint("f_bracken_43_2.Id1", "f_bracken_43_2", Rectangle(-1984, 614, 50));
		AddSpawnPoint("f_bracken_43_2.Id1", "f_bracken_43_2", Rectangle(-1773, 258, 50));
		AddSpawnPoint("f_bracken_43_2.Id1", "f_bracken_43_2", Rectangle(-1943, 316, 50));
		AddSpawnPoint("f_bracken_43_2.Id1", "f_bracken_43_2", Rectangle(-1721, 763, 50));
		AddSpawnPoint("f_bracken_43_2.Id1", "f_bracken_43_2", Rectangle(-1229, 788, 50));
		AddSpawnPoint("f_bracken_43_2.Id1", "f_bracken_43_2", Rectangle(-1239, 976, 50));
		AddSpawnPoint("f_bracken_43_2.Id1", "f_bracken_43_2", Rectangle(-839, 1034, 50));
		AddSpawnPoint("f_bracken_43_2.Id1", "f_bracken_43_2", Rectangle(42, 751, 50));
		AddSpawnPoint("f_bracken_43_2.Id1", "f_bracken_43_2", Rectangle(305, 835, 50));
		AddSpawnPoint("f_bracken_43_2.Id1", "f_bracken_43_2", Rectangle(-20, 916, 50));
		AddSpawnPoint("f_bracken_43_2.Id1", "f_bracken_43_2", Rectangle(386, 1013, 50));
		AddSpawnPoint("f_bracken_43_2.Id1", "f_bracken_43_2", Rectangle(1102, 794, 50));
		AddSpawnPoint("f_bracken_43_2.Id1", "f_bracken_43_2", Rectangle(1326, 792, 50));
		AddSpawnPoint("f_bracken_43_2.Id1", "f_bracken_43_2", Rectangle(1362, 942, 50));
		AddSpawnPoint("f_bracken_43_2.Id1", "f_bracken_43_2", Rectangle(1281, 416, 50));
		AddSpawnPoint("f_bracken_43_2.Id1", "f_bracken_43_2", Rectangle(1440, 218, 50));
		AddSpawnPoint("f_bracken_43_2.Id1", "f_bracken_43_2", Rectangle(844, -560, 50));
		AddSpawnPoint("f_bracken_43_2.Id1", "f_bracken_43_2", Rectangle(1089, -648, 50));
		AddSpawnPoint("f_bracken_43_2.Id1", "f_bracken_43_2", Rectangle(1017, -415, 50));
		AddSpawnPoint("f_bracken_43_2.Id1", "f_bracken_43_2", Rectangle(484, 245, 50));
		AddSpawnPoint("f_bracken_43_2.Id1", "f_bracken_43_2", Rectangle(420, 397, 50));
		AddSpawnPoint("f_bracken_43_2.Id1", "f_bracken_43_2", Rectangle(139, 40, 50));
		AddSpawnPoint("f_bracken_43_2.Id1", "f_bracken_43_2", Rectangle(-110, 83, 50));
		AddSpawnPoint("f_bracken_43_2.Id1", "f_bracken_43_2", Rectangle(-92, 377, 50));
		AddSpawnPoint("f_bracken_43_2.Id1", "f_bracken_43_2", Rectangle(-480, -1044, 50));
		AddSpawnPoint("f_bracken_43_2.Id1", "f_bracken_43_2", Rectangle(-328, -952, 50));
		AddSpawnPoint("f_bracken_43_2.Id1", "f_bracken_43_2", Rectangle(1332, -478, 50));
		AddSpawnPoint("f_bracken_43_2.Id1", "f_bracken_43_2", Rectangle(1368, -116, 50));
		AddSpawnPoint("f_bracken_43_2.Id1", "f_bracken_43_2", Rectangle(-1899, 44, 50));
		AddSpawnPoint("f_bracken_43_2.Id1", "f_bracken_43_2", Rectangle(109, 173, 50));

		// 'Darong' GenType 22 Spawn Points
		AddSpawnPoint("f_bracken_43_2.Id2", "f_bracken_43_2", Rectangle(115, 514, 50));
		AddSpawnPoint("f_bracken_43_2.Id2", "f_bracken_43_2", Rectangle(-964, -486, 50));
		AddSpawnPoint("f_bracken_43_2.Id2", "f_bracken_43_2", Rectangle(-1566, -417, 50));
		AddSpawnPoint("f_bracken_43_2.Id2", "f_bracken_43_2", Rectangle(-2117, -166, 50));
		AddSpawnPoint("f_bracken_43_2.Id2", "f_bracken_43_2", Rectangle(-710, -921, 50));
		AddSpawnPoint("f_bracken_43_2.Id2", "f_bracken_43_2", Rectangle(-2078, 33, 50));
		AddSpawnPoint("f_bracken_43_2.Id2", "f_bracken_43_2", Rectangle(-1886, 418, 50));
		AddSpawnPoint("f_bracken_43_2.Id2", "f_bracken_43_2", Rectangle(-1775, 520, 50));
		AddSpawnPoint("f_bracken_43_2.Id2", "f_bracken_43_2", Rectangle(-1032, 889, 50));
		AddSpawnPoint("f_bracken_43_2.Id2", "f_bracken_43_2", Rectangle(-750, 718, 50));
		AddSpawnPoint("f_bracken_43_2.Id2", "f_bracken_43_2", Rectangle(-605, 811, 50));
		AddSpawnPoint("f_bracken_43_2.Id2", "f_bracken_43_2", Rectangle(-104, 873, 50));
		AddSpawnPoint("f_bracken_43_2.Id2", "f_bracken_43_2", Rectangle(168, 885, 50));
		AddSpawnPoint("f_bracken_43_2.Id2", "f_bracken_43_2", Rectangle(1281, 675, 50));
		AddSpawnPoint("f_bracken_43_2.Id2", "f_bracken_43_2", Rectangle(1434, 772, 50));
		AddSpawnPoint("f_bracken_43_2.Id2", "f_bracken_43_2", Rectangle(1438, 293, 50));
		AddSpawnPoint("f_bracken_43_2.Id2", "f_bracken_43_2", Rectangle(1020, -527, 50));
		AddSpawnPoint("f_bracken_43_2.Id2", "f_bracken_43_2", Rectangle(-1304, -493, 50));
		AddSpawnPoint("f_bracken_43_2.Id2", "f_bracken_43_2", Rectangle(-429, -836, 50));
		AddSpawnPoint("f_bracken_43_2.Id2", "f_bracken_43_2", Rectangle(127, 340, 50));
		AddSpawnPoint("f_bracken_43_2.Id2", "f_bracken_43_2", Rectangle(-1905, -98, 50));
		AddSpawnPoint("f_bracken_43_2.Id2", "f_bracken_43_2", Rectangle(-1949, 255, 50));
		AddSpawnPoint("f_bracken_43_2.Id2", "f_bracken_43_2", Rectangle(-1998, 667, 50));
		AddSpawnPoint("f_bracken_43_2.Id2", "f_bracken_43_2", Rectangle(-1849, 849, 50));
		AddSpawnPoint("f_bracken_43_2.Id2", "f_bracken_43_2", Rectangle(-1700, 710, 50));
		AddSpawnPoint("f_bracken_43_2.Id2", "f_bracken_43_2", Rectangle(-1254, 868, 50));
		AddSpawnPoint("f_bracken_43_2.Id2", "f_bracken_43_2", Rectangle(-1029, 1142, 50));
		AddSpawnPoint("f_bracken_43_2.Id2", "f_bracken_43_2", Rectangle(-770, 552, 50));
		AddSpawnPoint("f_bracken_43_2.Id2", "f_bracken_43_2", Rectangle(-754, 990, 50));
		AddSpawnPoint("f_bracken_43_2.Id2", "f_bracken_43_2", Rectangle(-423, 842, 50));
		AddSpawnPoint("f_bracken_43_2.Id2", "f_bracken_43_2", Rectangle(209, 1092, 50));
		AddSpawnPoint("f_bracken_43_2.Id2", "f_bracken_43_2", Rectangle(61, 1102, 50));
		AddSpawnPoint("f_bracken_43_2.Id2", "f_bracken_43_2", Rectangle(196, 779, 50));
		AddSpawnPoint("f_bracken_43_2.Id2", "f_bracken_43_2", Rectangle(1287, 966, 50));
		AddSpawnPoint("f_bracken_43_2.Id2", "f_bracken_43_2", Rectangle(1330, 18, 50));
		AddSpawnPoint("f_bracken_43_2.Id2", "f_bracken_43_2", Rectangle(1125, 422, 50));
		AddSpawnPoint("f_bracken_43_2.Id2", "f_bracken_43_2", Rectangle(686, 331, 50));
		AddSpawnPoint("f_bracken_43_2.Id2", "f_bracken_43_2", Rectangle(426, 303, 50));

		// 'Rootcrystal_03' GenType 28 Spawn Points
		AddSpawnPoint("f_bracken_43_2.Id3", "f_bracken_43_2", Rectangle(-1792, 711, 10));
		AddSpawnPoint("f_bracken_43_2.Id3", "f_bracken_43_2", Rectangle(-1915, -70, 10));
		AddSpawnPoint("f_bracken_43_2.Id3", "f_bracken_43_2", Rectangle(-1030, -467, 10));
		AddSpawnPoint("f_bracken_43_2.Id3", "f_bracken_43_2", Rectangle(-563, -985, 10));
		AddSpawnPoint("f_bracken_43_2.Id3", "f_bracken_43_2", Rectangle(-578, -80, 10));
		AddSpawnPoint("f_bracken_43_2.Id3", "f_bracken_43_2", Rectangle(632, 338, 10));
		AddSpawnPoint("f_bracken_43_2.Id3", "f_bracken_43_2", Rectangle(1376, 272, 10));
		AddSpawnPoint("f_bracken_43_2.Id3", "f_bracken_43_2", Rectangle(1159, -550, 10));
		AddSpawnPoint("f_bracken_43_2.Id3", "f_bracken_43_2", Rectangle(1345, 864, 10));
		AddSpawnPoint("f_bracken_43_2.Id3", "f_bracken_43_2", Rectangle(-111, 868, 10));
		AddSpawnPoint("f_bracken_43_2.Id3", "f_bracken_43_2", Rectangle(386, 920, 10));
		AddSpawnPoint("f_bracken_43_2.Id3", "f_bracken_43_2", Rectangle(-24, 232, 10));
		AddSpawnPoint("f_bracken_43_2.Id3", "f_bracken_43_2", Rectangle(-2021, 223, 10));
		AddSpawnPoint("f_bracken_43_2.Id3", "f_bracken_43_2", Rectangle(-808, 780, 10));
		AddSpawnPoint("f_bracken_43_2.Id3", "f_bracken_43_2", Rectangle(-1266, 918, 10));

		// 'Nukarong' GenType 30 Spawn Points
		AddSpawnPoint("f_bracken_43_2.Id4", "f_bracken_43_2", Rectangle(1265, 851, 100));
		AddSpawnPoint("f_bracken_43_2.Id4", "f_bracken_43_2", Rectangle(-146, 863, 100));
		AddSpawnPoint("f_bracken_43_2.Id4", "f_bracken_43_2", Rectangle(-1046, 745, 100));
		AddSpawnPoint("f_bracken_43_2.Id4", "f_bracken_43_2", Rectangle(-1863, 573, 100));
		AddSpawnPoint("f_bracken_43_2.Id4", "f_bracken_43_2", Rectangle(-1955, -70, 100));
		AddSpawnPoint("f_bracken_43_2.Id4", "f_bracken_43_2", Rectangle(-521, -958, 100));
		AddSpawnPoint("f_bracken_43_2.Id4", "f_bracken_43_2", Rectangle(970, -506, 100));

		// 'Dorong' GenType 31 Spawn Points
		AddSpawnPoint("f_bracken_43_2.Id5", "f_bracken_43_2", Rectangle(119, 45, 20));
		AddSpawnPoint("f_bracken_43_2.Id5", "f_bracken_43_2", Rectangle(109, 409, 20));
		AddSpawnPoint("f_bracken_43_2.Id5", "f_bracken_43_2", Rectangle(352, 197, 20));

		// 'Darong' GenType 32 Spawn Points
		AddSpawnPoint("f_bracken_43_2.Id6", "f_bracken_43_2", Rectangle(24, 316, 20));
		AddSpawnPoint("f_bracken_43_2.Id6", "f_bracken_43_2", Rectangle(226, 78, 20));
		AddSpawnPoint("f_bracken_43_2.Id6", "f_bracken_43_2", Rectangle(279, 389, 20));
		AddSpawnPoint("f_bracken_43_2.Id6", "f_bracken_43_2", Rectangle(50, 153, 20));

		// 'Dorong' GenType 33 Spawn Points
		AddSpawnPoint("f_bracken_43_2.Id7", "f_bracken_43_2", Rectangle(-1034, -567, 20));
		AddSpawnPoint("f_bracken_43_2.Id7", "f_bracken_43_2", Rectangle(-848, -433, 20));
		AddSpawnPoint("f_bracken_43_2.Id7", "f_bracken_43_2", Rectangle(-978, -284, 20));
		AddSpawnPoint("f_bracken_43_2.Id7", "f_bracken_43_2", Rectangle(-1208, -461, 20));
		AddSpawnPoint("f_bracken_43_2.Id7", "f_bracken_43_2", Rectangle(-1003, -431, 20));
		AddSpawnPoint("f_bracken_43_2.Id7", "f_bracken_43_2", Rectangle(-1109, -339, 20));
		AddSpawnPoint("f_bracken_43_2.Id7", "f_bracken_43_2", Rectangle(-1169, -562, 20));
		AddSpawnPoint("f_bracken_43_2.Id7", "f_bracken_43_2", Rectangle(-928, -567, 20));
	}
}
