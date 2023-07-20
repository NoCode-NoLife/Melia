//--- Melia Script -----------------------------------------------------------
// Miners' Village Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_siauliai_out'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FSiauliaiOutMobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_siauliai_out", MonsterId.Goblin_Miners_Q2, Properties("MHP", 3079, "MINPATK", 222, "MAXPATK", 240, "MINMATK", 222, "MAXMATK", 240, "DEF", 21, "MDEF", 21));
		AddPropertyOverrides("f_siauliai_out", MonsterId.Jukopus, Properties("MHP", 3383, "MINPATK", 236, "MAXPATK", 255, "MINMATK", 236, "MAXMATK", 255, "DEF", 23, "MDEF", 23));
		AddPropertyOverrides("f_siauliai_out", MonsterId.Onion_Red, Properties("MHP", 3702, "MINPATK", 251, "MAXPATK", 270, "MINMATK", 251, "MAXMATK", 270, "DEF", 24, "MDEF", 24));
		AddPropertyOverrides("f_siauliai_out", MonsterId.Goblin_Spear, Properties("MHP", 4035, "MINPATK", 266, "MAXPATK", 287, "MINMATK", 266, "MAXMATK", 287, "DEF", 26, "MDEF", 26));
		AddPropertyOverrides("f_siauliai_out", MonsterId.Onion_Red_Elite, Properties("MHP", 19722, "MINPATK", 507, "MAXPATK", 547, "MINMATK", 507, "MAXMATK", 547, "DEF", 50, "MDEF", 50));

		// Monster Spawners ---------------------------------

		AddSpawner("f_siauliai_out.Id1", MonsterId.Jukopus, 5, 6, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_out.Id2", MonsterId.Goblin_Spear, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_out.Id3", MonsterId.Rootcrystal_01, 23, 30, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("f_siauliai_out.Id4", MonsterId.Onion_Red, 5, 6, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_out.Id5", MonsterId.Jukopus, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_out.Id6", MonsterId.Goblin_Spear, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_out.Id7", MonsterId.Onion_Red, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_out.Id8", MonsterId.Onion_Red, 14, 18, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_out.Id9", MonsterId.Jukopus, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_out.Id10", MonsterId.Onion_Red, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_out.Id11", MonsterId.Jukopus, 5, 6, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_out.Id12", MonsterId.Onion_Red_Elite, 2, 2, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Jukopus' GenType 325 Spawn Points
		AddSpawnPoint("f_siauliai_out.Id1", "f_siauliai_out", Rectangle(-1531, -1307, 30));
		AddSpawnPoint("f_siauliai_out.Id1", "f_siauliai_out", Rectangle(-1241, -1161, 30));
		AddSpawnPoint("f_siauliai_out.Id1", "f_siauliai_out", Rectangle(-1226, -963, 30));
		AddSpawnPoint("f_siauliai_out.Id1", "f_siauliai_out", Rectangle(-1504, -960, 30));
		AddSpawnPoint("f_siauliai_out.Id1", "f_siauliai_out", Rectangle(-1779, -1872, 30));
		AddSpawnPoint("f_siauliai_out.Id1", "f_siauliai_out", Rectangle(-2002, -1727, 30));
		AddSpawnPoint("f_siauliai_out.Id1", "f_siauliai_out", Rectangle(-2215, -1731, 30));
		AddSpawnPoint("f_siauliai_out.Id1", "f_siauliai_out", Rectangle(-1803, -2039, 30));
		AddSpawnPoint("f_siauliai_out.Id1", "f_siauliai_out", Rectangle(-1258, -1591, 30));

		// 'Goblin_Spear' GenType 326 Spawn Points
		AddSpawnPoint("f_siauliai_out.Id2", "f_siauliai_out", Rectangle(1772, 390, 40));
		AddSpawnPoint("f_siauliai_out.Id2", "f_siauliai_out", Rectangle(1465, 110, 40));
		AddSpawnPoint("f_siauliai_out.Id2", "f_siauliai_out", Rectangle(1544, 308, 40));
		AddSpawnPoint("f_siauliai_out.Id2", "f_siauliai_out", Rectangle(1334, 154, 40));
		AddSpawnPoint("f_siauliai_out.Id2", "f_siauliai_out", Rectangle(1411, 390, 40));
		AddSpawnPoint("f_siauliai_out.Id2", "f_siauliai_out", Rectangle(1590, 530, 40));
		AddSpawnPoint("f_siauliai_out.Id2", "f_siauliai_out", Rectangle(1997, 527, 40));
		AddSpawnPoint("f_siauliai_out.Id2", "f_siauliai_out", Rectangle(1840, 206, 40));
		AddSpawnPoint("f_siauliai_out.Id2", "f_siauliai_out", Rectangle(2123, 304, 40));
		AddSpawnPoint("f_siauliai_out.Id2", "f_siauliai_out", Rectangle(106, -51, 40));
		AddSpawnPoint("f_siauliai_out.Id2", "f_siauliai_out", Rectangle(-97, -120, 40));
		AddSpawnPoint("f_siauliai_out.Id2", "f_siauliai_out", Rectangle(16, -146, 40));

		// 'Rootcrystal_01' GenType 328 Spawn Points
		AddSpawnPoint("f_siauliai_out.Id3", "f_siauliai_out", Rectangle(1256, -955, 10));
		AddSpawnPoint("f_siauliai_out.Id3", "f_siauliai_out", Rectangle(1957, -47, 10));
		AddSpawnPoint("f_siauliai_out.Id3", "f_siauliai_out", Rectangle(1767, 388, 10));
		AddSpawnPoint("f_siauliai_out.Id3", "f_siauliai_out", Rectangle(-464, -1451, 10));
		AddSpawnPoint("f_siauliai_out.Id3", "f_siauliai_out", Rectangle(-1283, -1639, 10));
		AddSpawnPoint("f_siauliai_out.Id3", "f_siauliai_out", Rectangle(-1504, -1178, 10));
		AddSpawnPoint("f_siauliai_out.Id3", "f_siauliai_out", Rectangle(-1772, -1685, 10));
		AddSpawnPoint("f_siauliai_out.Id3", "f_siauliai_out", Rectangle(-1632, -878, 10));
		AddSpawnPoint("f_siauliai_out.Id3", "f_siauliai_out", Rectangle(-1199, -1103, 10));
		AddSpawnPoint("f_siauliai_out.Id3", "f_siauliai_out", Rectangle(-2124, -1766, 10));
		AddSpawnPoint("f_siauliai_out.Id3", "f_siauliai_out", Rectangle(-1756, -1536, 10));
		AddSpawnPoint("f_siauliai_out.Id3", "f_siauliai_out", Rectangle(-1119, -1493, 10));
		AddSpawnPoint("f_siauliai_out.Id3", "f_siauliai_out", Rectangle(-796, -1660, 10));
		AddSpawnPoint("f_siauliai_out.Id3", "f_siauliai_out", Rectangle(-619, -1567, 10));
		AddSpawnPoint("f_siauliai_out.Id3", "f_siauliai_out", Rectangle(12, -1429, 10));
		AddSpawnPoint("f_siauliai_out.Id3", "f_siauliai_out", Rectangle(264, -1316, 10));
		AddSpawnPoint("f_siauliai_out.Id3", "f_siauliai_out", Rectangle(533, -1103, 10));
		AddSpawnPoint("f_siauliai_out.Id3", "f_siauliai_out", Rectangle(-16, -1044, 10));
		AddSpawnPoint("f_siauliai_out.Id3", "f_siauliai_out", Rectangle(-80, -387, 10));
		AddSpawnPoint("f_siauliai_out.Id3", "f_siauliai_out", Rectangle(-89, -138, 10));
		AddSpawnPoint("f_siauliai_out.Id3", "f_siauliai_out", Rectangle(69, -170, 10));
		AddSpawnPoint("f_siauliai_out.Id3", "f_siauliai_out", Rectangle(720, -955, 10));
		AddSpawnPoint("f_siauliai_out.Id3", "f_siauliai_out", Rectangle(1024, -991, 10));
		AddSpawnPoint("f_siauliai_out.Id3", "f_siauliai_out", Rectangle(1512, -537, 10));
		AddSpawnPoint("f_siauliai_out.Id3", "f_siauliai_out", Rectangle(1290, 199, 10));
		AddSpawnPoint("f_siauliai_out.Id3", "f_siauliai_out", Rectangle(450, -1551, 10));
		AddSpawnPoint("f_siauliai_out.Id3", "f_siauliai_out", Rectangle(537, -1799, 10));
		AddSpawnPoint("f_siauliai_out.Id3", "f_siauliai_out", Rectangle(1677, -61, 10));
		AddSpawnPoint("f_siauliai_out.Id3", "f_siauliai_out", Rectangle(1990, 408, 10));
		AddSpawnPoint("f_siauliai_out.Id3", "f_siauliai_out", Rectangle(2186, 368, 10));
		AddSpawnPoint("f_siauliai_out.Id3", "f_siauliai_out", Rectangle(1753, -536, 10));
		AddSpawnPoint("f_siauliai_out.Id3", "f_siauliai_out", Rectangle(-1959, -2100, 10));
		AddSpawnPoint("f_siauliai_out.Id3", "f_siauliai_out", Rectangle(1367, -144, 10));

		// 'Onion_Red' GenType 341 Spawn Points
		AddSpawnPoint("f_siauliai_out.Id4", "f_siauliai_out", Rectangle(-1877, -2146, 30));
		AddSpawnPoint("f_siauliai_out.Id4", "f_siauliai_out", Rectangle(-1595, -1274, 30));
		AddSpawnPoint("f_siauliai_out.Id4", "f_siauliai_out", Rectangle(-1432, -1177, 30));
		AddSpawnPoint("f_siauliai_out.Id4", "f_siauliai_out", Rectangle(-1366, -997, 30));
		AddSpawnPoint("f_siauliai_out.Id4", "f_siauliai_out", Rectangle(-1770, -1242, 30));
		AddSpawnPoint("f_siauliai_out.Id4", "f_siauliai_out", Rectangle(-2158, -1760, 30));
		AddSpawnPoint("f_siauliai_out.Id4", "f_siauliai_out", Rectangle(-1779, -1801, 30));

		// 'Jukopus' GenType 701 Spawn Points
		AddSpawnPoint("f_siauliai_out.Id5", "f_siauliai_out", Rectangle(-1966, -1791, 600));

		// 'Goblin_Spear' GenType 702 Spawn Points
		AddSpawnPoint("f_siauliai_out.Id6", "f_siauliai_out", Rectangle(-1889, -1782, 350));

		// 'Onion_Red' GenType 10011 Spawn Points
		AddSpawnPoint("f_siauliai_out.Id7", "f_siauliai_out", Rectangle(-1202, -1041, 9999));

		// 'Onion_Red' GenType 10022 Spawn Points
		AddSpawnPoint("f_siauliai_out.Id8", "f_siauliai_out", Rectangle(-228, -1471, 40));
		AddSpawnPoint("f_siauliai_out.Id8", "f_siauliai_out", Rectangle(991, -981, 40));
		AddSpawnPoint("f_siauliai_out.Id8", "f_siauliai_out", Rectangle(1271, -996, 40));
		AddSpawnPoint("f_siauliai_out.Id8", "f_siauliai_out", Rectangle(1368, -745, 40));
		AddSpawnPoint("f_siauliai_out.Id8", "f_siauliai_out", Rectangle(1364, -452, 40));
		AddSpawnPoint("f_siauliai_out.Id8", "f_siauliai_out", Rectangle(763, -888, 40));

		// 'Jukopus' GenType 10023 Spawn Points
		AddSpawnPoint("f_siauliai_out.Id9", "f_siauliai_out", Rectangle(797, -992, 40));
		AddSpawnPoint("f_siauliai_out.Id9", "f_siauliai_out", Rectangle(524, -1070, 40));
		AddSpawnPoint("f_siauliai_out.Id9", "f_siauliai_out", Rectangle(1566, -86, 40));
		AddSpawnPoint("f_siauliai_out.Id9", "f_siauliai_out", Rectangle(1209, -875, 40));

		// 'Onion_Red' GenType 10024 Spawn Points
		AddSpawnPoint("f_siauliai_out.Id10", "f_siauliai_out", Rectangle(-982, -1586, 40));
		AddSpawnPoint("f_siauliai_out.Id10", "f_siauliai_out", Rectangle(-621, -1512, 40));
		AddSpawnPoint("f_siauliai_out.Id10", "f_siauliai_out", Rectangle(-730, -1669, 40));

		// 'Jukopus' GenType 10025 Spawn Points
		AddSpawnPoint("f_siauliai_out.Id11", "f_siauliai_out", Rectangle(-468, -1511, 40));
		AddSpawnPoint("f_siauliai_out.Id11", "f_siauliai_out", Rectangle(-777, -1479, 40));
		AddSpawnPoint("f_siauliai_out.Id11", "f_siauliai_out", Rectangle(-690, -1775, 40));

		// 'Onion_Red_Elite' GenType 10042 Spawn Points
		AddSpawnPoint("f_siauliai_out.Id12", "f_siauliai_out", Rectangle(1151, -937, 9999));
		AddSpawnPoint("f_siauliai_out.Id12", "f_siauliai_out", Rectangle(-824, -1566, 9999));
	}
}
