//--- Melia Script -----------------------------------------------------------
// Crystal Mine Lot 2 - 1F Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_cmine_8'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DCmine8MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("d_cmine_8.Id1", MonsterId.Rootcrystal_01, 8, 10, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("d_cmine_8.Id2", MonsterId.FD_Bubbe_Chaser, 27, 35, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cmine_8.Id3", MonsterId.FD_Bubbe_Mage_Fire, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cmine_8.Id4", MonsterId.Crystal_Lump, 4, 5, TimeSpan.FromMilliseconds(10000), TendencyType.Peaceful);
		AddSpawner("d_cmine_8.Id5", MonsterId.Crystal_Lump, 4, 5, TimeSpan.FromMilliseconds(10000), TendencyType.Peaceful);
		AddSpawner("d_cmine_8.Id6", MonsterId.Crystal_Lump, 4, 5, TimeSpan.FromMilliseconds(10000), TendencyType.Peaceful);
		AddSpawner("d_cmine_8.Id7", MonsterId.Crystal_Lump, 4, 5, TimeSpan.FromMilliseconds(10000), TendencyType.Peaceful);
		AddSpawner("d_cmine_8.Id8", MonsterId.Crystal_Lump, 4, 5, TimeSpan.FromMilliseconds(10000), TendencyType.Peaceful);
		AddSpawner("d_cmine_8.Id9", MonsterId.Crystal_Lump, 4, 5, TimeSpan.FromMilliseconds(10000), TendencyType.Peaceful);
		AddSpawner("d_cmine_8.Id10", MonsterId.FD_Minos_Mage, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_cmine_8.Id11", MonsterId.FD_Goblin_Archer_Red, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 514 Spawn Points
		AddSpawnPoint("d_cmine_8.Id1", "d_cmine_8", Rectangle(-1560, -11, 30));
		AddSpawnPoint("d_cmine_8.Id1", "d_cmine_8", Rectangle(-1052, -1160, 30));
		AddSpawnPoint("d_cmine_8.Id1", "d_cmine_8", Rectangle(36, -194, 30));
		AddSpawnPoint("d_cmine_8.Id1", "d_cmine_8", Rectangle(517, 1114, 30));
		AddSpawnPoint("d_cmine_8.Id1", "d_cmine_8", Rectangle(1410, 471, 30));
		AddSpawnPoint("d_cmine_8.Id1", "d_cmine_8", Rectangle(2079, 1603, 30));

		// 'FD_Bubbe_Chaser' GenType 1073 Spawn Points
		AddSpawnPoint("d_cmine_8.Id2", "d_cmine_8", Rectangle(-1165, 110, 9999));

		// 'FD_Bubbe_Mage_Fire' GenType 1075 Spawn Points
		AddSpawnPoint("d_cmine_8.Id3", "d_cmine_8", Rectangle(-292, 775, 9999));

		// 'Crystal_Lump' GenType 1089 Spawn Points
		AddSpawnPoint("d_cmine_8.Id4", "d_cmine_8", Rectangle(-2881, -254, 50));
		AddSpawnPoint("d_cmine_8.Id4", "d_cmine_8", Rectangle(1068, 527, 50));
		AddSpawnPoint("d_cmine_8.Id4", "d_cmine_8", Rectangle(112, 1318, 50));
		AddSpawnPoint("d_cmine_8.Id4", "d_cmine_8", Rectangle(-2391, -399, 50));
		AddSpawnPoint("d_cmine_8.Id4", "d_cmine_8", Rectangle(-46, -295, 50));

		// 'Crystal_Lump' GenType 1090 Spawn Points
		AddSpawnPoint("d_cmine_8.Id5", "d_cmine_8", Rectangle(-1777, -37, 50));
		AddSpawnPoint("d_cmine_8.Id5", "d_cmine_8", Rectangle(-1357, -180, 50));
		AddSpawnPoint("d_cmine_8.Id5", "d_cmine_8", Rectangle(-1353, 951, 50));
		AddSpawnPoint("d_cmine_8.Id5", "d_cmine_8", Rectangle(-1661, 794, 50));
		AddSpawnPoint("d_cmine_8.Id5", "d_cmine_8", Rectangle(-1050, 104, 50));

		// 'Crystal_Lump' GenType 1091 Spawn Points
		AddSpawnPoint("d_cmine_8.Id6", "d_cmine_8", Rectangle(-1073, -1059, 50));
		AddSpawnPoint("d_cmine_8.Id6", "d_cmine_8", Rectangle(-1328, -856, 50));
		AddSpawnPoint("d_cmine_8.Id6", "d_cmine_8", Rectangle(-830, -867, 50));
		AddSpawnPoint("d_cmine_8.Id6", "d_cmine_8", Rectangle(-1112, -672, 50));
		AddSpawnPoint("d_cmine_8.Id6", "d_cmine_8", Rectangle(-796, -618, 50));

		// 'Crystal_Lump' GenType 1092 Spawn Points
		AddSpawnPoint("d_cmine_8.Id7", "d_cmine_8", Rectangle(215, 43, 50));
		AddSpawnPoint("d_cmine_8.Id7", "d_cmine_8", Rectangle(-139, 63, 50));
		AddSpawnPoint("d_cmine_8.Id7", "d_cmine_8", Rectangle(-489, 740, 50));
		AddSpawnPoint("d_cmine_8.Id7", "d_cmine_8", Rectangle(-450, 1148, 50));
		AddSpawnPoint("d_cmine_8.Id7", "d_cmine_8", Rectangle(545, 1557, 50));

		// 'Crystal_Lump' GenType 1093 Spawn Points
		AddSpawnPoint("d_cmine_8.Id8", "d_cmine_8", Rectangle(1011, 1199, 50));
		AddSpawnPoint("d_cmine_8.Id8", "d_cmine_8", Rectangle(490, 1100, 50));
		AddSpawnPoint("d_cmine_8.Id8", "d_cmine_8", Rectangle(636, 406, 50));
		AddSpawnPoint("d_cmine_8.Id8", "d_cmine_8", Rectangle(1040, 34, 50));
		AddSpawnPoint("d_cmine_8.Id8", "d_cmine_8", Rectangle(1386, 446, 50));

		// 'Crystal_Lump' GenType 1094 Spawn Points
		AddSpawnPoint("d_cmine_8.Id9", "d_cmine_8", Rectangle(1528, 956, 50));
		AddSpawnPoint("d_cmine_8.Id9", "d_cmine_8", Rectangle(1790, 1360, 50));
		AddSpawnPoint("d_cmine_8.Id9", "d_cmine_8", Rectangle(1885, 1877, 50));
		AddSpawnPoint("d_cmine_8.Id9", "d_cmine_8", Rectangle(2791, 1818, 50));
		AddSpawnPoint("d_cmine_8.Id9", "d_cmine_8", Rectangle(2661, 2092, 50));

		// 'FD_Minos_Mage' GenType 1102 Spawn Points
		AddSpawnPoint("d_cmine_8.Id10", "d_cmine_8", Rectangle(-57, -229, 35));
		AddSpawnPoint("d_cmine_8.Id10", "d_cmine_8", Rectangle(156, -98, 35));
		AddSpawnPoint("d_cmine_8.Id10", "d_cmine_8", Rectangle(-213, -49, 35));
		AddSpawnPoint("d_cmine_8.Id10", "d_cmine_8", Rectangle(-137, -313, 35));
		AddSpawnPoint("d_cmine_8.Id10", "d_cmine_8", Rectangle(-550, 717, 35));
		AddSpawnPoint("d_cmine_8.Id10", "d_cmine_8", Rectangle(-176, 1008, 35));
		AddSpawnPoint("d_cmine_8.Id10", "d_cmine_8", Rectangle(-279, 785, 35));
		AddSpawnPoint("d_cmine_8.Id10", "d_cmine_8", Rectangle(-590, 1022, 35));
		AddSpawnPoint("d_cmine_8.Id10", "d_cmine_8", Rectangle(1771, 1721, 35));
		AddSpawnPoint("d_cmine_8.Id10", "d_cmine_8", Rectangle(1903, 1849, 35));
		AddSpawnPoint("d_cmine_8.Id10", "d_cmine_8", Rectangle(1825, 1279, 35));
		AddSpawnPoint("d_cmine_8.Id10", "d_cmine_8", Rectangle(1503, 926, 35));
		AddSpawnPoint("d_cmine_8.Id10", "d_cmine_8", Rectangle(1344, 424, 35));
		AddSpawnPoint("d_cmine_8.Id10", "d_cmine_8", Rectangle(1368, 585, 35));
		AddSpawnPoint("d_cmine_8.Id10", "d_cmine_8", Rectangle(1056, 264, 35));
		AddSpawnPoint("d_cmine_8.Id10", "d_cmine_8", Rectangle(659, 292, 35));
		AddSpawnPoint("d_cmine_8.Id10", "d_cmine_8", Rectangle(513, 954, 35));
		AddSpawnPoint("d_cmine_8.Id10", "d_cmine_8", Rectangle(975, 1239, 35));
		AddSpawnPoint("d_cmine_8.Id10", "d_cmine_8", Rectangle(844, 1016, 35));
		AddSpawnPoint("d_cmine_8.Id10", "d_cmine_8", Rectangle(493, 1372, 35));
		AddSpawnPoint("d_cmine_8.Id10", "d_cmine_8", Rectangle(1059, 1101, 35));
		AddSpawnPoint("d_cmine_8.Id10", "d_cmine_8", Rectangle(391, 1159, 35));

		// 'FD_Goblin_Archer_Red' GenType 1108 Spawn Points
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(542, 1021, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(106, 1260, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(471, 1375, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(-515, 901, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(-443, 1072, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(-246, -129, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(-171, -288, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(200, -44, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(-1676, 794, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(-1442, 904, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(-1550, 791, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(-1625, -2, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(-1370, 225, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(-1052, 63, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(-1297, -146, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(-1131, -739, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(-881, -626, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(-1063, -988, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(-796, -781, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(-1023, -1135, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(-1343, -778, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(-1378, -886, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(-1393, 36, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(-1579, 991, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(-716, 978, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(-107, 969, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(-205, 727, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(962, 1103, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(1085, 1244, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(923, 1289, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(2091, 1595, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(1865, 1775, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(1766, 1701, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(1843, 1398, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(1791, 1290, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(1487, 907, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(1589, 966, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(1649, 879, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(1412, 571, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(1267, 397, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(987, 45, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(1120, 433, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(426, 989, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(621, 469, 25));
		AddSpawnPoint("d_cmine_8.Id11", "d_cmine_8", Rectangle(636, 693, 25));
	}
}
