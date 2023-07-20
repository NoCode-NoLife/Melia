//--- Melia Script -----------------------------------------------------------
// Akmens Ridge Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_rokas_27'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FRokas27MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_rokas_27.Id1", MonsterId.Rootcrystal_05, 12, 16, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("f_rokas_27.Id2", MonsterId.Sauga_S, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_27.Id3", MonsterId.Tucen, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_27.Id4", MonsterId.Tucen, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_27.Id5", MonsterId.Loftlem, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_27.Id6", MonsterId.Sauga_S, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_27.Id7", MonsterId.Ticen, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_05' GenType 600 Spawn Points
		AddSpawnPoint("f_rokas_27.Id1", "f_rokas_27", Rectangle(328, -2523, 30));
		AddSpawnPoint("f_rokas_27.Id1", "f_rokas_27", Rectangle(782, -2293, 30));
		AddSpawnPoint("f_rokas_27.Id1", "f_rokas_27", Rectangle(1110, -1049, 30));
		AddSpawnPoint("f_rokas_27.Id1", "f_rokas_27", Rectangle(1364, 108, 30));
		AddSpawnPoint("f_rokas_27.Id1", "f_rokas_27", Rectangle(1948, -134, 30));
		AddSpawnPoint("f_rokas_27.Id1", "f_rokas_27", Rectangle(317, -2173, 30));
		AddSpawnPoint("f_rokas_27.Id1", "f_rokas_27", Rectangle(-550, -1778, 30));
		AddSpawnPoint("f_rokas_27.Id1", "f_rokas_27", Rectangle(-86, -1210, 30));
		AddSpawnPoint("f_rokas_27.Id1", "f_rokas_27", Rectangle(-639, -2216, 30));
		AddSpawnPoint("f_rokas_27.Id1", "f_rokas_27", Rectangle(1165, 706, 30));
		AddSpawnPoint("f_rokas_27.Id1", "f_rokas_27", Rectangle(1725, -298, 30));
		AddSpawnPoint("f_rokas_27.Id1", "f_rokas_27", Rectangle(-470, -3090, 30));

		// 'Sauga_S' GenType 621 Spawn Points
		AddSpawnPoint("f_rokas_27.Id2", "f_rokas_27", Rectangle(1635, 467, 9999));

		// 'Tucen' GenType 624 Spawn Points
		AddSpawnPoint("f_rokas_27.Id3", "f_rokas_27", Rectangle(949, -618, 9999));

		// 'Tucen' GenType 627 Spawn Points
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(837, -734, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(1104, -699, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(-873, -2305, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(-715, -2155, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(29, -1783, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(-52, -1825, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(32, -1661, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(-63, -1606, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(-170, -1729, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(-56, -1511, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(34, -1462, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(126, -1445, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(218, -1719, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(231, -1876, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(221, -1564, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(-52, -2654, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(37, -2660, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(77, -2724, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(917, -1926, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(1017, -1809, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(1102, -1790, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(1119, -1902, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(999, -2097, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(901, -2187, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(874, -2072, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(962, -1275, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(1010, -1377, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(999, -1324, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(1894, -419, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(1818, -443, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(1706, -306, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(1718, -219, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(1774, -204, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(2221, -121, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(1765, -142, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(1847, -74, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(1892, -17, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(2003, 62, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(2066, 80, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(2119, 77, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(2242, 66, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(2292, -24, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(2118, -76, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(1964, -223, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(2068, -321, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(2170, -344, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(2100, -179, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(2390, -235, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(2343, -220, 20));
		AddSpawnPoint("f_rokas_27.Id4", "f_rokas_27", Rectangle(1992, -416, 20));

		// 'Loftlem' GenType 629 Spawn Points
		AddSpawnPoint("f_rokas_27.Id5", "f_rokas_27", Rectangle(1434, 403, 20));
		AddSpawnPoint("f_rokas_27.Id5", "f_rokas_27", Rectangle(1413, 129, 20));
		AddSpawnPoint("f_rokas_27.Id5", "f_rokas_27", Rectangle(1713, 338, 20));
		AddSpawnPoint("f_rokas_27.Id5", "f_rokas_27", Rectangle(1485, 626, 20));
		AddSpawnPoint("f_rokas_27.Id5", "f_rokas_27", Rectangle(1551, 227, 20));
		AddSpawnPoint("f_rokas_27.Id5", "f_rokas_27", Rectangle(1294, 540, 20));
		AddSpawnPoint("f_rokas_27.Id5", "f_rokas_27", Rectangle(1270, 270, 20));
		AddSpawnPoint("f_rokas_27.Id5", "f_rokas_27", Rectangle(1586, 431, 20));
		AddSpawnPoint("f_rokas_27.Id5", "f_rokas_27", Rectangle(1683, 588, 20));

		// 'Sauga_S' GenType 701 Spawn Points
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(-801, -2072, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(747, -2526, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(658, -2387, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(329, -2339, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(792, -749, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(1088, -467, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(-997, -2246, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(-916, -2160, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(-852, -2097, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(-739, -2003, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(-610, -2155, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(-790, -2419, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(-823, -2356, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(-822, -2233, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(-806, -2156, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(-647, -2213, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(-689, -2307, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(-918, -2378, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(-658, -1953, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(215, -2596, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(229, -2662, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(209, -2467, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(139, -2425, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(162, -2353, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(277, -2201, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(365, -2164, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(399, -2231, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(653, -2163, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(613, -2264, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(522, -2364, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(338, -2479, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(384, -2651, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(501, -2711, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(525, -2646, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(644, -2585, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(689, -2692, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(761, -2643, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(808, -2435, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(721, -2337, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(786, -637, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(1048, -722, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(992, -817, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(1159, -664, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(1178, -716, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(1114, -562, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(980, -437, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(1013, -392, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(885, -418, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(830, -474, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(751, -531, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(962, -508, 30));
		AddSpawnPoint("f_rokas_27.Id6", "f_rokas_27", Rectangle(949, -626, 30));

		// 'Ticen' GenType 704 Spawn Points
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(396, -2549, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(612, -2341, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(549, -2688, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(464, -2224, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(707, -2269, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(802, -2499, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(357, -2289, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(565, -2471, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(-128, -2695, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(92, -2781, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(191, -2521, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(1533, 655, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(1575, 391, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(-872, -2292, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(-697, -2140, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(-720, -2256, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(844, -712, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(1108, -632, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(938, -628, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(1073, -459, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(1482, 522, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(1598, 598, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(1706, 460, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(1692, 225, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(1533, 166, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(1418, 184, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(1271, 114, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(1037, 102, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(1098, -13, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(849, 115, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(922, 559, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(815, 389, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(963, 417, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(817, 277, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(849, 491, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(1015, 605, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(1273, 445, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(1141, 696, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(1277, 316, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(1075, 524, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(1023, 292, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(1151, 351, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(1222, 185, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(1323, 220, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(1424, 348, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(1418, 466, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(1290, 1, 30));
		AddSpawnPoint("f_rokas_27.Id7", "f_rokas_27", Rectangle(1002, 31, 30));
	}
}
