//--- Melia Script -----------------------------------------------------------
// Apsimesti Crossroads Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_pilgrimroad_52'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FPilgrimroad52MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_pilgrimroad_52", MonsterId.Hook_Old, Properties("MHP", 138581, "MINPATK", 2283, "MAXPATK", 2708, "MINMATK", 2283, "MAXMATK", 2708, "DEF", 2775, "MDEF", 2775));
		AddPropertyOverrides("f_pilgrimroad_52", MonsterId.TreeAmbulo_Red, Properties("MHP", 140057, "MINPATK", 2302, "MAXPATK", 2731, "MINMATK", 2302, "MAXMATK", 2731, "DEF", 2860, "MDEF", 2860));
		AddPropertyOverrides("f_pilgrimroad_52", MonsterId.Lichenclops_Mage, Properties("MHP", 141583, "MINPATK", 2322, "MAXPATK", 2755, "MINMATK", 2322, "MAXMATK", 2755, "DEF", 2948, "MDEF", 2948));

		// Monster Spawners ---------------------------------

		AddSpawner("f_pilgrimroad_52.Id1", MonsterId.Hook_Old, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_52.Id2", MonsterId.TreeAmbulo_Red, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_52.Id3", MonsterId.Rootcrystal_01, 8, 10, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_52.Id4", MonsterId.TreeAmbulo_Red, 60, 80, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_52.Id5", MonsterId.Hook_Old, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_52.Id6", MonsterId.Lichenclops_Mage, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Hook_Old' GenType 6 Spawn Points
		AddSpawnPoint("f_pilgrimroad_52.Id1", "f_pilgrimroad_52", Rectangle(-10, 373, 9999));

		// 'TreeAmbulo_Red' GenType 7 Spawn Points
		AddSpawnPoint("f_pilgrimroad_52.Id2", "f_pilgrimroad_52", Rectangle(-193, 166, 9999));

		// 'Rootcrystal_01' GenType 19 Spawn Points
		AddSpawnPoint("f_pilgrimroad_52.Id3", "f_pilgrimroad_52", Rectangle(-606, -2750, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id3", "f_pilgrimroad_52", Rectangle(-1110, -1748, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id3", "f_pilgrimroad_52", Rectangle(48, -937, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id3", "f_pilgrimroad_52", Rectangle(367, 470, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id3", "f_pilgrimroad_52", Rectangle(-361, 454, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id3", "f_pilgrimroad_52", Rectangle(-1468, 169, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id3", "f_pilgrimroad_52", Rectangle(-355, 1215, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id3", "f_pilgrimroad_52", Rectangle(973, 1263, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id3", "f_pilgrimroad_52", Rectangle(1423, 2103, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id3", "f_pilgrimroad_52", Rectangle(722, -183, 30));

		// 'TreeAmbulo_Red' GenType 38 Spawn Points
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-803, -2121, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-786, -2325, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-187, 1237, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-360, 1042, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-442, 1271, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-715, 1381, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-643, 1418, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-179, 1426, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-253, 1570, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-493, 1551, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-621, 1173, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-292, 820, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(911, 2070, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(987, 2324, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(1272, 2522, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(1622, 2019, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(1326, 2158, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(1100, 2021, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(862, 2268, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(1404, 1944, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1180, -1617, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1262, -1607, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1245, -1533, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1054, -1540, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1320, -1782, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1232, -1890, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1073, -1957, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-876, -2001, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-715, -1924, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1001, -1828, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1104, -1722, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-931, -1620, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-836, -1769, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-642, -1774, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-592, -1446, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-664, -1642, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-628, -1537, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-761, -1812, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-896, -1890, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1417, -1612, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(1304, 1774, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(1116, 1759, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(810, 1943, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(734, 2100, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(854, 2419, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(1403, 2318, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(1554, 2424, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(1700, 2241, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(1281, 2029, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(1259, 1901, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1254, -388, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1441, -347, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1596, -243, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1650, -88, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1623, 65, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1530, 218, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1358, 261, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1071, 221, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-967, 90, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-978, -51, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-998, -275, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1207, -157, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1356, -166, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1432, 6, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1320, 135, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1127, 115, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-964, -15, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1089, -226, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1236, 69, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1406, -125, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(186, 611, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(188, 403, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(416, 287, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(664, 441, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(532, 612, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(446, 464, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(423, 587, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(233, 458, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(266, 222, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(122, 92, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-22, 147, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-194, 263, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-263, 189, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-98, 92, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-80, -27, 25));

		// 'Hook_Old' GenType 48 Spawn Points
		AddSpawnPoint("f_pilgrimroad_52.Id5", "f_pilgrimroad_52", Rectangle(493, 564, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id5", "f_pilgrimroad_52", Rectangle(-954, -1774, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id5", "f_pilgrimroad_52", Rectangle(-1371, -1584, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id5", "f_pilgrimroad_52", Rectangle(1251, 2145, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id5", "f_pilgrimroad_52", Rectangle(1260, 1964, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id5", "f_pilgrimroad_52", Rectangle(211, 231, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id5", "f_pilgrimroad_52", Rectangle(204, 610, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id5", "f_pilgrimroad_52", Rectangle(-1080, -99, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id5", "f_pilgrimroad_52", Rectangle(-1615, -28, 30));

		// 'Lichenclops_Mage' GenType 49 Spawn Points
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(966, 1207, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(1419, 2170, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(440, 392, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(897, 2007, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(1567, 1899, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(199, 424, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(797, 2150, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(1399, 2466, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(514, 642, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(1290, 1762, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(1175, 2394, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(742, 958, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(74, 136, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(-40, 340, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(-254, 41, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(-273, 756, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(-457, 1158, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(211, 237, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(-1249, -330, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(-1554, -82, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(-1351, 310, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(-907, -125, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(-617, 1268, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(-588, 1598, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(-221, 1586, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(-360, 1249, 30));
	}
}
