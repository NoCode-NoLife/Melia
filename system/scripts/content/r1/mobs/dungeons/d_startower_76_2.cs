//--- Melia Script -----------------------------------------------------------
// Nazarene Tower Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_startower_76_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DStartower762MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("d_startower_76_2.Id1", MonsterId.ERD_Tiny, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_2.Id2", MonsterId.ERD_Hook_Remain, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_2.Id3", MonsterId.ERD_Operor, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_2.Id4", MonsterId.ERD_Rafflesia_Green, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_2.Id5", MonsterId.ERD_TerraNymph, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_2.Id6", MonsterId.ERD_Hohen_Orben_Green, 4, 5, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_2.Id7", MonsterId.ERD_Ragged_Bird, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_2.Id8", MonsterId.ERD_Truffle, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_2.Id9", MonsterId.ERD_Hohen_Orben_Red, 4, 5, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_2.Id10", MonsterId.ERD_Big_Cockatries_Red, 4, 5, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_2.Id11", MonsterId.ERD_Nuo_Purple, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_2.Id12", MonsterId.ERD_Quartz_Weaver, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_2.Id13", MonsterId.ERD_Jukotail, 60, 80, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_2.Id14", MonsterId.ERD_Jukotail, 3, 3, TimeSpan.FromMilliseconds(30000), TendencyType.Aggressive);
		AddSpawner("d_startower_76_2.Id15", MonsterId.Rootcrystal_02, 23, 30, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'ERD_Tiny' GenType 19 Spawn Points
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-760, 855, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-649, 878, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-549, 810, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-668, 763, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-577, 742, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-572, 891, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-658, 681, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-690, 814, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-617, 808, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-531, 1048, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-471, 961, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-411, 868, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-356, 772, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-581, 595, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-503, 541, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-481, 642, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-376, 620, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-292, 687, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-1230, -411, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-1246, -218, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-1285, 7, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-934, 58, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-875, -356, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-541, -293, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-584, -100, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-600, 110, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(1281, -822, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(1256, -624, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(1214, -405, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(1577, -356, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(1624, -773, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(1954, -720, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(1930, -533, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(1911, -306, 40));

		// 'ERD_Hook_Remain' GenType 20 Spawn Points
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-960, -946, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-834, -940, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-903, -861, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-752, -802, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-771, -704, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-638, -697, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-943, -784, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-849, -1121, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-751, -1049, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-681, -1145, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-649, -996, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-481, -954, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-575, -896, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-609, -759, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-668, -887, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-473, -1701, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-357, -1700, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-374, -1843, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-215, -1721, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-267, -1594, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-285, -1757, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(218, -1525, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(358, -1581, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(244, -1478, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(414, -1510, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(247, -1390, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(277, -1246, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(377, -1286, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(474, -1273, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(477, -1409, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(373, -1227, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(302, -1145, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(239, -1311, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-349, -1541, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-339, -887, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-224, -903, 40));

		// 'ERD_Operor' GenType 21 Spawn Points
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-2086, -460, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-2067, -320, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1991, -417, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1830, -298, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1975, -198, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1867, -68, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-2048, -72, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1785, -128, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1695, -355, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1791, -505, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1971, -547, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1855, -452, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1894, -351, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1784, -353, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1742, -10, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1630, -129, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1576, -309, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1714, -647, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1807, -782, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1607, -668, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1677, -808, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1444, -756, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1819, -923, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1743, -1034, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1658, -951, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1606, -1071, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1458, -1073, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1498, -969, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1380, -999, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1318, -906, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1480, -866, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1137, -858, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1566, -789, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1685, -1143, 40));

		// 'ERD_Rafflesia_Green' GenType 22 Spawn Points
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-219, -1418, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-109, -1320, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(20, -1326, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(123, -1312, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-137, -1146, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-68, -1072, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-112, -982, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-54, -763, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-105, -706, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-50, -551, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(66, -510, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(126, -538, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-120, -458, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-86, -314, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-171, -270, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-138, -71, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-224, 56, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-132, 152, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-30, 103, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-296, 265, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-312, 439, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-466, -371, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-409, -288, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-482, -268, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-416, -209, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-566, -383, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-337, -327, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(644, 354, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(725, 369, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(682, 272, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(763, 271, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(809, 385, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(835, 228, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(908, 198, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(873, 445, 40));

		// 'ERD_TerraNymph' GenType 23 Spawn Points
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(280, -350, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(298, -512, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(369, -477, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(450, -410, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(435, -494, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(570, -350, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(490, -556, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(390, -567, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(308, -770, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(416, -686, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(520, -622, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(554, -777, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(426, -786, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(576, -563, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(225, -51, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(245, 36, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(193, 95, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(180, 233, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(260, 349, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(349, 313, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(372, 404, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(417, 250, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(434, 146, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(338, 58, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(370, -13, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(462, 45, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(161, 362, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(69, 172, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(-92, 633, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(59, 691, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(-57, 748, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(-92, 906, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(163, 777, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(41, 1025, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(241, 1053, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(312, 873, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(-60, 1075, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(92, 1148, 40));

		// 'ERD_Hohen_Orben_Green' GenType 24 Spawn Points
		AddSpawnPoint("d_startower_76_2.Id6", "d_startower_76_2", Rectangle(-1124, -274, 40));
		AddSpawnPoint("d_startower_76_2.Id6", "d_startower_76_2", Rectangle(-1146, -89, 40));
		AddSpawnPoint("d_startower_76_2.Id6", "d_startower_76_2", Rectangle(-735, -211, 40));
		AddSpawnPoint("d_startower_76_2.Id6", "d_startower_76_2", Rectangle(-751, -46, 40));
		AddSpawnPoint("d_startower_76_2.Id6", "d_startower_76_2", Rectangle(-1583, -892, 40));
		AddSpawnPoint("d_startower_76_2.Id6", "d_startower_76_2", Rectangle(-734, -971, 40));
		AddSpawnPoint("d_startower_76_2.Id6", "d_startower_76_2", Rectangle(-1977, -316, 40));

		// 'ERD_Ragged_Bird' GenType 25 Spawn Points
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-1296, -375, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-1277, -276, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-1130, -385, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-1113, -177, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-1349, -168, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-1330, -103, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-1172, 0, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-1054, 33, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-1028, -337, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-921, -267, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-775, -330, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-808, -151, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-837, -37, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-996, -105, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-663, -306, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-570, -186, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-675, -135, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-616, -16, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-472, -51, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-487, 68, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-716, 94, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-816, 79, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-928, -43, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-1382, -3, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-1334, -448, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-998, -203, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-495, 177, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-164, 837, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-123, 1001, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-35, 864, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-9, 988, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(127, 1093, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(3, 1184, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(2, 766, 40));

		// 'ERD_Truffle' GenType 26 Spawn Points
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(75, 837, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(168, 873, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(168, 999, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(247, 951, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(261, 1139, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(344, 1021, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(242, 817, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(193, 685, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1140, -892, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1182, -746, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1329, -720, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1167, -620, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1225, -525, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1374, -537, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1112, -402, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1399, -395, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1578, -506, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1511, -684, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1437, -817, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1670, -579, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1510, -581, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1659, -454, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1854, -678, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1758, -779, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1831, -490, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1753, -324, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1971, -396, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(2026, -232, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(2091, -571, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(2084, -740, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1696, -686, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1488, -466, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1310, -422, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1303, -280, 40));

		// 'ERD_Hohen_Orben_Red' GenType 27 Spawn Points
		AddSpawnPoint("d_startower_76_2.Id9", "d_startower_76_2", Rectangle(1434, -675, 40));
		AddSpawnPoint("d_startower_76_2.Id9", "d_startower_76_2", Rectangle(1400, -474, 40));
		AddSpawnPoint("d_startower_76_2.Id9", "d_startower_76_2", Rectangle(1802, -621, 40));
		AddSpawnPoint("d_startower_76_2.Id9", "d_startower_76_2", Rectangle(1781, -438, 40));
		AddSpawnPoint("d_startower_76_2.Id9", "d_startower_76_2", Rectangle(1054, 230, 40));
		AddSpawnPoint("d_startower_76_2.Id9", "d_startower_76_2", Rectangle(1038, 392, 40));
		AddSpawnPoint("d_startower_76_2.Id9", "d_startower_76_2", Rectangle(1272, 318, 40));
		AddSpawnPoint("d_startower_76_2.Id9", "d_startower_76_2", Rectangle(1299, 551, 40));

		// 'ERD_Big_Cockatries_Red' GenType 28 Spawn Points
		AddSpawnPoint("d_startower_76_2.Id10", "d_startower_76_2", Rectangle(818, -1696, 40));
		AddSpawnPoint("d_startower_76_2.Id10", "d_startower_76_2", Rectangle(782, -1455, 40));
		AddSpawnPoint("d_startower_76_2.Id10", "d_startower_76_2", Rectangle(1088, -1684, 40));
		AddSpawnPoint("d_startower_76_2.Id10", "d_startower_76_2", Rectangle(1121, -1439, 40));
		AddSpawnPoint("d_startower_76_2.Id10", "d_startower_76_2", Rectangle(927, -1183, 40));

		// 'ERD_Nuo_Purple' GenType 29 Spawn Points
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1006, 547, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1137, 684, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1146, 525, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1141, 817, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1333, 644, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1245, 471, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1382, 461, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1362, 311, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1476, 401, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1180, 360, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1181, 191, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1344, 241, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1297, 122, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1134, 75, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1014, 106, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(955, 327, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(968, 454, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1113, 457, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1217, 617, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1023, 637, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(916, 545, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1425, 200, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1253, -65, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1291, -179, 40));

		// 'ERD_Quartz_Weaver' GenType 30 Spawn Points
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(848, -1332, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(1014, -1380, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(695, -1417, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(671, -1565, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(767, -1560, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(729, -1683, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(804, -1787, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(896, -1693, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(1030, -1824, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(1011, -1639, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(1123, -1588, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(1220, -1562, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(1058, -1517, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(970, -1451, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(881, -1603, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(906, -1409, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(1076, -1236, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(1137, -1153, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(1238, -1165, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(1363, -1083, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(1443, -992, 40));

		// 'ERD_Jukotail' GenType 31 Spawn Points
		AddSpawnPoint("d_startower_76_2.Id13", "d_startower_76_2", Rectangle(-76, -458, 9999));

		// 'ERD_Jukotail' GenType 33 Spawn Points
		AddSpawnPoint("d_startower_76_2.Id14", "d_startower_76_2", Rectangle(-103, -506, 9999));

		// 'Rootcrystal_02' GenType 34 Spawn Points
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-442, -1701, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-217, -1707, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-124, -1272, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(359, -1540, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(336, -1237, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-86, -759, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-586, -900, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-974, -909, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-1448, -983, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-1724, -832, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-1580, -269, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-1870, -110, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-2158, -259, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-1887, -435, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-1257, -64, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-852, -303, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-561, 35, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-144, -262, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-322, 344, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-649, 892, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-354, 751, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(130, 1060, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(5, 714, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-8, 114, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(354, 197, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(833, 306, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(1283, 253, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(1270, -164, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(1244, -564, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(1956, -423, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(1250, -1163, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(1110, -1538, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(777, -1551, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(1639, -718, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(1169, 681, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(429, -571, 200));
	}
}
