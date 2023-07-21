//--- Melia Script -----------------------------------------------------------
// Pradzia Temple Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_dcapital_108'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DDcapital108MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_dcapital_108", MonsterId.Raganosis_Ram, Properties("MHP", 862065, "MINPATK", 11586, "MAXPATK", 14142, "MINMATK", 11586, "MAXMATK", 14142, "DEF", 326330, "MDEF", 326330));
		AddPropertyOverrides("d_dcapital_108", MonsterId.Raganosis_Guardian, Properties("MHP", 872854, "MINPATK", 11725, "MAXPATK", 14313, "MINMATK", 11725, "MAXMATK", 14313, "DEF", 336922, "MDEF", 336922));
		AddPropertyOverrides("d_dcapital_108", MonsterId.Raganosis_Seeker, Properties("MHP", 884585, "MINPATK", 11876, "MAXPATK", 14498, "MINMATK", 11876, "MAXMATK", 14498, "DEF", 348437, "MDEF", 348437));
		AddPropertyOverrides("d_dcapital_108", MonsterId.Boss_RaganosisCommander, Properties("MHP", 4790971, "MINPATK", 31779, "MAXPATK", 38800, "MINMATK", 31779, "MAXMATK", 38800, "DEF", 952531, "MDEF", 952531));
		AddPropertyOverrides("d_dcapital_108", MonsterId.Legend_Boss_Giltine_Q1, Properties("MHP", 7913123, "MINPATK", 28409, "MAXPATK", 34688, "MINMATK", 28409, "MAXMATK", 34688, "DEF", 1305180, "MDEF", 1305180));

		// Monster Spawners ---------------------------------

		AddSpawner("d_dcapital_108.Id1", MonsterId.Raganosis_Ram, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_dcapital_108.Id2", MonsterId.Raganosis_Guardian, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_dcapital_108.Id3", MonsterId.Raganosis_Seeker, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_dcapital_108.Id4", MonsterId.Raganosis_Ram, 2, 2, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_dcapital_108.Id5", MonsterId.Raganosis_Ram, 7, 9, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_dcapital_108.Id6", MonsterId.Raganosis_Guardian, 18, 24, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_dcapital_108.Id7", MonsterId.Raganosis_Seeker, 20, 26, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_dcapital_108.Id8", MonsterId.Rootcrystal_02, 19, 25, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Raganosis_Ram' GenType 41 Spawn Points
		AddSpawnPoint("d_dcapital_108.Id1", "d_dcapital_108", Rectangle(2351, 478, 70));
		AddSpawnPoint("d_dcapital_108.Id1", "d_dcapital_108", Rectangle(2119, 136, 70));
		AddSpawnPoint("d_dcapital_108.Id1", "d_dcapital_108", Rectangle(1585, -762, 70));
		AddSpawnPoint("d_dcapital_108.Id1", "d_dcapital_108", Rectangle(-1515, 190, 70));
		AddSpawnPoint("d_dcapital_108.Id1", "d_dcapital_108", Rectangle(-1262, 460, 70));
		AddSpawnPoint("d_dcapital_108.Id1", "d_dcapital_108", Rectangle(-353, -923, 70));
		AddSpawnPoint("d_dcapital_108.Id1", "d_dcapital_108", Rectangle(-645, -491, 70));
		AddSpawnPoint("d_dcapital_108.Id1", "d_dcapital_108", Rectangle(1653, -358, 70));
		AddSpawnPoint("d_dcapital_108.Id1", "d_dcapital_108", Rectangle(-465, -671, 70));

		// 'Raganosis_Guardian' GenType 42 Spawn Points
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(2384, 420, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(2280, 206, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(2095, 227, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(1428, -697, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(1595, -641, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(1470, -792, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(-568, -695, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(-429, -590, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(-481, -750, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(-381, -665, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(-1415, 224, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(-1185, 467, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(-1177, -42, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(2086, 4, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(-988, -354, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(-1278, 167, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(-1184, 274, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(1913, -357, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(2395, 307, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(2120, -217, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(1345, -619, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(-654, -572, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(-1157, -319, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(-1298, 281, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(-1357, 455, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(1544, -589, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(2202, 271, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(2255, 377, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(-390, -833, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(-327, -774, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(-482, -515, 25));

		// 'Raganosis_Seeker' GenType 43 Spawn Points
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(2286, 435, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(1572, -515, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(1321, -762, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(-636, -771, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(-378, -519, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(-1194, -377, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(-1427, 329, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(2155, 415, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(-406, -749, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(-679, -334, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(-1298, 216, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(1769, -386, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(2112, -129, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(-559, -531, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(-1353, 458, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(-1235, 356, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(2331, 187, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(2405, 234, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(2027, -373, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(1385, -528, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(1642, -736, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(1498, -651, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(-665, -683, 25));

		// 'Raganosis_Ram' GenType 44 Spawn Points
		AddSpawnPoint("d_dcapital_108.Id4", "d_dcapital_108", Rectangle(2113, -351, 40));
		AddSpawnPoint("d_dcapital_108.Id4", "d_dcapital_108", Rectangle(-1155, -174, 40));
		AddSpawnPoint("d_dcapital_108.Id4", "d_dcapital_108", Rectangle(-837, -348, 40));
		AddSpawnPoint("d_dcapital_108.Id4", "d_dcapital_108", Rectangle(1297, -908, 40));

		// 'Raganosis_Ram' GenType 61 Spawn Points
		AddSpawnPoint("d_dcapital_108.Id5", "d_dcapital_108", Rectangle(83, 2282, 70));
		AddSpawnPoint("d_dcapital_108.Id5", "d_dcapital_108", Rectangle(476, 2268, 70));
		AddSpawnPoint("d_dcapital_108.Id5", "d_dcapital_108", Rectangle(859, 2278, 70));
		AddSpawnPoint("d_dcapital_108.Id5", "d_dcapital_108", Rectangle(662, 2091, 70));
		AddSpawnPoint("d_dcapital_108.Id5", "d_dcapital_108", Rectangle(303, 2086, 70));
		AddSpawnPoint("d_dcapital_108.Id5", "d_dcapital_108", Rectangle(241, 2462, 70));
		AddSpawnPoint("d_dcapital_108.Id5", "d_dcapital_108", Rectangle(682, 2486, 70));
		AddSpawnPoint("d_dcapital_108.Id5", "d_dcapital_108", Rectangle(306, 2262, 70));
		AddSpawnPoint("d_dcapital_108.Id5", "d_dcapital_108", Rectangle(664, 2279, 70));

		// 'Raganosis_Guardian' GenType 62 Spawn Points
		AddSpawnPoint("d_dcapital_108.Id6", "d_dcapital_108", Rectangle(356, 2007, 25));
		AddSpawnPoint("d_dcapital_108.Id6", "d_dcapital_108", Rectangle(363, 2141, 25));
		AddSpawnPoint("d_dcapital_108.Id6", "d_dcapital_108", Rectangle(231, 2145, 25));
		AddSpawnPoint("d_dcapital_108.Id6", "d_dcapital_108", Rectangle(236, 2024, 25));
		AddSpawnPoint("d_dcapital_108.Id6", "d_dcapital_108", Rectangle(774, 2272, 25));
		AddSpawnPoint("d_dcapital_108.Id6", "d_dcapital_108", Rectangle(684, 2402, 25));
		AddSpawnPoint("d_dcapital_108.Id6", "d_dcapital_108", Rectangle(599, 2471, 25));
		AddSpawnPoint("d_dcapital_108.Id6", "d_dcapital_108", Rectangle(764, 2477, 25));
		AddSpawnPoint("d_dcapital_108.Id6", "d_dcapital_108", Rectangle(873, 2372, 25));
		AddSpawnPoint("d_dcapital_108.Id6", "d_dcapital_108", Rectangle(859, 2189, 25));
		AddSpawnPoint("d_dcapital_108.Id6", "d_dcapital_108", Rectangle(403, 2317, 25));
		AddSpawnPoint("d_dcapital_108.Id6", "d_dcapital_108", Rectangle(541, 2238, 25));

		// 'Raganosis_Seeker' GenType 63 Spawn Points
		AddSpawnPoint("d_dcapital_108.Id7", "d_dcapital_108", Rectangle(568, 2087, 25));
		AddSpawnPoint("d_dcapital_108.Id7", "d_dcapital_108", Rectangle(655, 2177, 25));
		AddSpawnPoint("d_dcapital_108.Id7", "d_dcapital_108", Rectangle(746, 2093, 25));
		AddSpawnPoint("d_dcapital_108.Id7", "d_dcapital_108", Rectangle(660, 2001, 25));
		AddSpawnPoint("d_dcapital_108.Id7", "d_dcapital_108", Rectangle(254, 2385, 25));
		AddSpawnPoint("d_dcapital_108.Id7", "d_dcapital_108", Rectangle(326, 2466, 25));
		AddSpawnPoint("d_dcapital_108.Id7", "d_dcapital_108", Rectangle(161, 2466, 25));
		AddSpawnPoint("d_dcapital_108.Id7", "d_dcapital_108", Rectangle(233, 2542, 25));
		AddSpawnPoint("d_dcapital_108.Id7", "d_dcapital_108", Rectangle(166, 2287, 25));
		AddSpawnPoint("d_dcapital_108.Id7", "d_dcapital_108", Rectangle(78, 2358, 25));
		AddSpawnPoint("d_dcapital_108.Id7", "d_dcapital_108", Rectangle(87, 2208, 25));
		AddSpawnPoint("d_dcapital_108.Id7", "d_dcapital_108", Rectangle(437, 2204, 25));
		AddSpawnPoint("d_dcapital_108.Id7", "d_dcapital_108", Rectangle(519, 2341, 25));

		// 'Rootcrystal_02' GenType 64 Spawn Points
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(172, -1389, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(-353, -1362, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(-361, -965, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(-613, -739, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(-392, -542, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(-664, -371, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(-1173, -360, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(-1178, 22, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(-1224, 208, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(-1434, 417, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(-1183, -134, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(-912, -359, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(778, -1387, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(478, -1326, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(947, -1355, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(1322, -1357, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(1320, -948, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(1380, -738, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(1602, -660, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(1611, -381, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(2104, -362, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(2103, 37, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(2124, 205, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(2383, 231, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(2373, 459, 200));
	}
}
