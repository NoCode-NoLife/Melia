//--- Melia Script -----------------------------------------------------------
// Sunset Flag Forest Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_thorn_23'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DThorn23MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("d_thorn_23.Id1", MonsterId.Rootcrystal_01, 8, 10, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("d_thorn_23.Id2", MonsterId.Raider, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_23.Id3", MonsterId.Infroholder, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_23.Id4", MonsterId.Raider, 4, 5, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_23.Id5", MonsterId.Infroholder, 5, 6, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_23.Id6", MonsterId.Duckey, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_23.Id7", MonsterId.InfroHoglan, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_23.Id8", MonsterId.Cronewt, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_23.Id9", MonsterId.InfroHoglan, 4, 5, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_23.Id10", MonsterId.Cronewt, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_23.Id11", MonsterId.Duckey, 4, 5, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_23.Id12", MonsterId.Infroholder, 38, 50, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_23.Id13", MonsterId.Duckey, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_23.Id14", MonsterId.Raider, 6, 7, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 600 Spawn Points
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(-1824, -2731, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(-1910, -2511, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(-1595, -2641, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(-1346, -1098, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(-2031, -436, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(-1870, 253, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(-846, 204, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(-338, 310, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(-816, -664, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(-552, -950, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(608, 688, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(1305, 129, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(1130, -143, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(1821, 562, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(1795, 829, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(2155, 569, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(2415, 1948, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(2117, 1754, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(2554, 1444, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(-1619, -1437, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(-1921, -167, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(384, 372, 50));

		// 'Raider' GenType 605 Spawn Points
		AddSpawnPoint("d_thorn_23.Id2", "d_thorn_23", Rectangle(-1373, -2289, 9999));

		// 'Infroholder' GenType 606 Spawn Points
		AddSpawnPoint("d_thorn_23.Id3", "d_thorn_23", Rectangle(-1343, -1035, 9999));

		// 'Raider' GenType 607 Spawn Points
		AddSpawnPoint("d_thorn_23.Id4", "d_thorn_23", Rectangle(-1760, -2740, 30));
		AddSpawnPoint("d_thorn_23.Id4", "d_thorn_23", Rectangle(-1819, -2144, 30));
		AddSpawnPoint("d_thorn_23.Id4", "d_thorn_23", Rectangle(-1453, -887, 30));
		AddSpawnPoint("d_thorn_23.Id4", "d_thorn_23", Rectangle(-1954, -94, 30));
		AddSpawnPoint("d_thorn_23.Id4", "d_thorn_23", Rectangle(-1813, 316, 30));
		AddSpawnPoint("d_thorn_23.Id4", "d_thorn_23", Rectangle(-902, -1378, 30));
		AddSpawnPoint("d_thorn_23.Id4", "d_thorn_23", Rectangle(-1565, -1392, 30));

		// 'Infroholder' GenType 616 Spawn Points
		AddSpawnPoint("d_thorn_23.Id5", "d_thorn_23", Rectangle(-1804, -2585, 30));
		AddSpawnPoint("d_thorn_23.Id5", "d_thorn_23", Rectangle(-1994, -2603, 30));
		AddSpawnPoint("d_thorn_23.Id5", "d_thorn_23", Rectangle(-1729, -2865, 30));
		AddSpawnPoint("d_thorn_23.Id5", "d_thorn_23", Rectangle(-1552, -2723, 30));
		AddSpawnPoint("d_thorn_23.Id5", "d_thorn_23", Rectangle(-2019, -2864, 30));
		AddSpawnPoint("d_thorn_23.Id5", "d_thorn_23", Rectangle(-1946, -2194, 30));
		AddSpawnPoint("d_thorn_23.Id5", "d_thorn_23", Rectangle(-1506, -2395, 30));
		AddSpawnPoint("d_thorn_23.Id5", "d_thorn_23", Rectangle(-1642, -2527, 30));

		// 'Duckey' GenType 619 Spawn Points
		AddSpawnPoint("d_thorn_23.Id6", "d_thorn_23", Rectangle(-1616, -1503, 9999));

		// 'InfroHoglan' GenType 620 Spawn Points
		AddSpawnPoint("d_thorn_23.Id7", "d_thorn_23", Rectangle(-339, -1219, 9999));

		// 'Cronewt' GenType 621 Spawn Points
		AddSpawnPoint("d_thorn_23.Id8", "d_thorn_23", Rectangle(-625, -241, 9999));

		// 'InfroHoglan' GenType 622 Spawn Points
		AddSpawnPoint("d_thorn_23.Id9", "d_thorn_23", Rectangle(-355, 341, 30));
		AddSpawnPoint("d_thorn_23.Id9", "d_thorn_23", Rectangle(-843, 250, 30));
		AddSpawnPoint("d_thorn_23.Id9", "d_thorn_23", Rectangle(-369, 594, 30));
		AddSpawnPoint("d_thorn_23.Id9", "d_thorn_23", Rectangle(-679, -59, 30));
		AddSpawnPoint("d_thorn_23.Id9", "d_thorn_23", Rectangle(-92, 548, 30));
		AddSpawnPoint("d_thorn_23.Id9", "d_thorn_23", Rectangle(244, 639, 30));
		AddSpawnPoint("d_thorn_23.Id9", "d_thorn_23", Rectangle(397, 377, 30));
		AddSpawnPoint("d_thorn_23.Id9", "d_thorn_23", Rectangle(-1350, 362, 30));

		// 'Cronewt' GenType 623 Spawn Points
		AddSpawnPoint("d_thorn_23.Id10", "d_thorn_23", Rectangle(-2137, -46, 30));
		AddSpawnPoint("d_thorn_23.Id10", "d_thorn_23", Rectangle(-1876, -702, 30));
		AddSpawnPoint("d_thorn_23.Id10", "d_thorn_23", Rectangle(-1717, -701, 30));
		AddSpawnPoint("d_thorn_23.Id10", "d_thorn_23", Rectangle(-2159, -270, 30));
		AddSpawnPoint("d_thorn_23.Id10", "d_thorn_23", Rectangle(-1728, 250, 30));
		AddSpawnPoint("d_thorn_23.Id10", "d_thorn_23", Rectangle(-1776, 37, 30));
		AddSpawnPoint("d_thorn_23.Id10", "d_thorn_23", Rectangle(-1991, 199, 30));
		AddSpawnPoint("d_thorn_23.Id10", "d_thorn_23", Rectangle(-1901, -116, 30));

		// 'Duckey' GenType 624 Spawn Points
		AddSpawnPoint("d_thorn_23.Id11", "d_thorn_23", Rectangle(-1099, -1206, 30));
		AddSpawnPoint("d_thorn_23.Id11", "d_thorn_23", Rectangle(-1593, -1321, 30));
		AddSpawnPoint("d_thorn_23.Id11", "d_thorn_23", Rectangle(-1598, -786, 30));
		AddSpawnPoint("d_thorn_23.Id11", "d_thorn_23", Rectangle(-803, -1345, 30));
		AddSpawnPoint("d_thorn_23.Id11", "d_thorn_23", Rectangle(-847, -1494, 30));
		AddSpawnPoint("d_thorn_23.Id11", "d_thorn_23", Rectangle(-1012, -1251, 30));
		AddSpawnPoint("d_thorn_23.Id11", "d_thorn_23", Rectangle(-1910, -558, 30));

		// 'Infroholder' GenType 625 Spawn Points
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-712, -129, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1911, -45, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(296, 632, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(580, 819, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1288, -2172, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-2024, -428, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(568, 587, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(867, 429, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(819, 323, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(728, 434, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-2091, -2380, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-632, -230, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-2143, -278, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1603, -1275, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(660, 725, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-471, -1078, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1668, -1419, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1658, 145, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1904, -609, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1858, 214, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(544, 369, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-548, -911, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(608, 463, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-2080, -128, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-440, -903, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(388, 303, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1535, -2553, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1702, -2259, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-671, 1, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(467, 447, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(451, 340, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1978, -2669, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-440, 561, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1495, -1241, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(566, 700, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1793, -709, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-667, 277, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1397, -1954, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(763, 717, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-959, -1274, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1135, -1166, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1999, -263, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1345, -1076, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-729, 492, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1972, -2354, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1244, -1201, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-479, 188, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1576, -868, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(799, 813, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1589, -1360, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(345, 624, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-769, 107, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1646, -2747, 30));

		// 'Duckey' GenType 627 Spawn Points
		AddSpawnPoint("d_thorn_23.Id13", "d_thorn_23", Rectangle(-1131, 326, 30));
		AddSpawnPoint("d_thorn_23.Id13", "d_thorn_23", Rectangle(-1023, 195, 30));
		AddSpawnPoint("d_thorn_23.Id13", "d_thorn_23", Rectangle(-783, -18, 30));
		AddSpawnPoint("d_thorn_23.Id13", "d_thorn_23", Rectangle(-632, -189, 30));
		AddSpawnPoint("d_thorn_23.Id13", "d_thorn_23", Rectangle(-708, -288, 30));
		AddSpawnPoint("d_thorn_23.Id13", "d_thorn_23", Rectangle(-693, 117, 30));
		AddSpawnPoint("d_thorn_23.Id13", "d_thorn_23", Rectangle(-694, 347, 30));
		AddSpawnPoint("d_thorn_23.Id13", "d_thorn_23", Rectangle(-617, 579, 30));
		AddSpawnPoint("d_thorn_23.Id13", "d_thorn_23", Rectangle(-250, 424, 30));
		AddSpawnPoint("d_thorn_23.Id13", "d_thorn_23", Rectangle(-417, 541, 30));
		AddSpawnPoint("d_thorn_23.Id13", "d_thorn_23", Rectangle(-396, 283, 30));

		// 'Raider' GenType 628 Spawn Points
		AddSpawnPoint("d_thorn_23.Id14", "d_thorn_23", Rectangle(-1512, -884, 30));
		AddSpawnPoint("d_thorn_23.Id14", "d_thorn_23", Rectangle(-1631, -1329, 30));
		AddSpawnPoint("d_thorn_23.Id14", "d_thorn_23", Rectangle(-982, -1292, 30));
		AddSpawnPoint("d_thorn_23.Id14", "d_thorn_23", Rectangle(-659, 208, 30));
		AddSpawnPoint("d_thorn_23.Id14", "d_thorn_23", Rectangle(-1224, -1208, 30));
		AddSpawnPoint("d_thorn_23.Id14", "d_thorn_23", Rectangle(-1282, -1047, 30));
		AddSpawnPoint("d_thorn_23.Id14", "d_thorn_23", Rectangle(-511, 646, 30));
		AddSpawnPoint("d_thorn_23.Id14", "d_thorn_23", Rectangle(-774, 8, 30));
		AddSpawnPoint("d_thorn_23.Id14", "d_thorn_23", Rectangle(-762, 346, 30));
		AddSpawnPoint("d_thorn_23.Id14", "d_thorn_23", Rectangle(-996, 250, 30));
		AddSpawnPoint("d_thorn_23.Id14", "d_thorn_23", Rectangle(-328, 337, 30));
		AddSpawnPoint("d_thorn_23.Id14", "d_thorn_23", Rectangle(-85, 559, 30));
	}
}
