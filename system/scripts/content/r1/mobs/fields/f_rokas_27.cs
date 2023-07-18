//--- Melia Script -----------------------------------------------------------
// f_rokas_27
//
//--- Description -----------------------------------------------------------
// Sets up the f_rokas_27 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FRokas27MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("f_rokas_27.Id1", MonsterId.Rootcrystal_05, 16, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("f_rokas_27.Id2", MonsterId.Sauga_S, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_27.Id3", MonsterId.Tucen, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_27.Id4", MonsterId.Loftlem, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_27.Id5", MonsterId.Sauga_S, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_27.Id6", MonsterId.Ticen, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_27.Id7", MonsterId.Tucen, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Rootcrystal_05 Spawn Points
		AddSpawnPoint( "f_rokas_27.Id1", "f_rokas_27", Spot(328, -2523, 30));
		AddSpawnPoint( "f_rokas_27.Id1", "f_rokas_27", Spot(782, -2293, 30));
		AddSpawnPoint( "f_rokas_27.Id1", "f_rokas_27", Spot(1110, -1049, 30));
		AddSpawnPoint( "f_rokas_27.Id1", "f_rokas_27", Spot(1364.6642, 108.33385, 30));
		AddSpawnPoint( "f_rokas_27.Id1", "f_rokas_27", Spot(1948.02, -134.35, 30));
		AddSpawnPoint( "f_rokas_27.Id1", "f_rokas_27", Spot(317.64, -2173.41, 30));
		AddSpawnPoint( "f_rokas_27.Id1", "f_rokas_27", Spot(-550.75, -1778.84, 30));
		AddSpawnPoint( "f_rokas_27.Id1", "f_rokas_27", Spot(-86.95, -1210.4, 30));
		AddSpawnPoint( "f_rokas_27.Id1", "f_rokas_27", Spot(-639.87, -2216.33, 30));
		AddSpawnPoint( "f_rokas_27.Id1", "f_rokas_27", Spot(1165.2616, 706.2403, 30));
		AddSpawnPoint( "f_rokas_27.Id1", "f_rokas_27", Spot(1725.6, -298.22, 30));
		AddSpawnPoint( "f_rokas_27.Id1", "f_rokas_27", Spot(-470.68, -3090.14, 30));

		// Sauga_S Spawn Points
		AddSpawnPoint( "f_rokas_27.Id2", "f_rokas_27", Spot(1635.5342, 467.2836, 9999));

		// Tucen Spawn Points
		AddSpawnPoint( "f_rokas_27.Id3", "f_rokas_27", Spot(949.23, -618.61, 9999));

		// Loftlem Spawn Points
		AddSpawnPoint( "f_rokas_27.Id4", "f_rokas_27", Spot(1434.7971, 403.01044, 20));
		AddSpawnPoint( "f_rokas_27.Id4", "f_rokas_27", Spot(1413.3478, 129.5271, 20));
		AddSpawnPoint( "f_rokas_27.Id4", "f_rokas_27", Spot(1713.8154, 338.36288, 20));
		AddSpawnPoint( "f_rokas_27.Id4", "f_rokas_27", Spot(1485.9858, 626.20605, 20));
		AddSpawnPoint( "f_rokas_27.Id4", "f_rokas_27", Spot(1551.5634, 227.95628, 20));
		AddSpawnPoint( "f_rokas_27.Id4", "f_rokas_27", Spot(1294.4209, 540.64966, 20));
		AddSpawnPoint( "f_rokas_27.Id4", "f_rokas_27", Spot(1270.1223, 270.26315, 20));
		AddSpawnPoint( "f_rokas_27.Id4", "f_rokas_27", Spot(1586.4889, 431.34946, 20));
		AddSpawnPoint( "f_rokas_27.Id4", "f_rokas_27", Spot(1683.4937, 588.01495, 20));

		// Sauga_S Spawn Points
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(-801.5141, -2072.702, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(747.8618, -2526.8928, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(658.5545, -2387.161, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(329.46234, -2339.3213, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(792.86475, -749.3666, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(1088.2175, -467.3039, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(-997.2922, -2246.3782, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(-916.6093, -2160.6257, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(-852.77423, -2097.8828, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(-739.98627, -2003.8934, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(-610.0318, -2155.1707, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(-790.7947, -2419.3958, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(-823.86957, -2356.6892, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(-822.9346, -2233.8755, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(-806.69366, -2156.3533, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(-647.80756, -2213.8032, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(-689.9903, -2307.2043, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(-918.5701, -2378.8906, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(-658.27136, -1953.8844, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(215.47513, -2596.152, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(229.25871, -2662.8955, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(209.96202, -2467.3958, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(139.85446, -2425.5027, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(162.02353, -2353.2065, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(277.14926, -2201.694, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(365.0553, -2164.736, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(399.773, -2231.6914, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(653.5874, -2163.6228, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(613.2049, -2264.3767, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(522.1092, -2364.407, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(338.3326, -2479.2405, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(384.92236, -2651.1152, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(501.29425, -2711.0676, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(525.97955, -2646.0686, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(644.2108, -2585.911, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(689.67926, -2692.2183, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(761.4891, -2643.5918, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(808.97144, -2435.806, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(721.1027, -2337.0193, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(786.5608, -637.8147, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(1048.708, -722.50397, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(992.04584, -817.45105, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(1159.7188, -664.5815, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(1178.147, -716.85065, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(1114.0328, -562.55304, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(980.8965, -437.45294, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(1013.2494, -392.92203, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(885.8001, -418.62793, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(830.5833, -474.85278, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(751.88074, -531.1158, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(962.3665, -508.24188, 30));
		AddSpawnPoint( "f_rokas_27.Id5", "f_rokas_27", Spot(949.315, -626.0939, 30));

		// Ticen Spawn Points
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(396.16, -2549.66, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(612.68, -2341.16, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(549.17, -2688.01, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(464.25, -2224.34, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(707.98, -2269.83, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(802.92, -2499.13, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(357.13, -2289.07, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(565.9983, -2471.749, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(-128.94, -2695.73, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(92.87, -2781.71, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(191.01, -2521.6, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(1533.701, 655.68866, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(1575.4379, 391.0933, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(-872.79364, -2292.4966, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(-697.49585, -2140.5193, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(-720.93414, -2256.005, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(844.4044, -712.4251, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(1108.3069, -632.2553, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(938.91565, -628.10803, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(1073.9742, -459.33783, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(1482.0844, 522.4045, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(1598.5575, 598.85223, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(1706.313, 460.9836, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(1692.2363, 225.38495, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(1533.6555, 166.25726, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(1418.835, 184.55469, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(1271.5526, 114.2884, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(1037.925, 102.69547, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(1098.3102, -13.820672, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(849.08307, 115.0351, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(922.1003, 559.05273, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(815.19727, 389.53412, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(963.21344, 417.29068, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(817.82855, 277.72363, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(849.2444, 491.5371, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(1015.9677, 605.0515, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(1273.6576, 445.02252, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(1141.0835, 696.4455, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(1277.4517, 316.70023, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(1075.2556, 524.2581, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(1023.5646, 292.77133, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(1151.2465, 351.7547, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(1222.8909, 185.03462, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(1323.3147, 220.99911, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(1424.6716, 348.6914, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(1418.6067, 466.67, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(1290.3457, 1.7155466, 30));
		AddSpawnPoint( "f_rokas_27.Id6", "f_rokas_27", Spot(1002.4108, 31.778648, 30));

		// Tucen Spawn Points
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(837.103, -734.17474, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(1104.3984, -699.80316, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(-873.8727, -2305.1523, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(-715.70624, -2155.5881, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(29.631134, -1783.8368, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(-52.792023, -1825.5043, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(32.92913, -1661.565, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(-63.863613, -1606.9639, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(-170.9747, -1729.0255, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(-56.5672, -1511.5165, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(34.301872, -1462.787, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(126.83319, -1445.458, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(218.49164, -1719.4567, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(231.11298, -1876.208, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(221.53418, -1564.5474, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(-52.057564, -2654.277, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(37.38272, -2660.3452, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(77.184, -2724.5557, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(917.55444, -1926.4634, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(1017.2947, -1809.1918, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(1102.0787, -1790.537, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(1119.7334, -1902.677, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(999.77423, -2097.2222, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(901.23035, -2187.6948, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(874.9333, -2072.9778, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(962.4969, -1275.3378, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(1010.2187, -1377.3035, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(999.33167, -1324.4227, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(1894.9485, -419.56567, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(1818.9932, -443.8356, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(1706.1901, -306.25, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(1718.6088, -219.41455, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(1774.7345, -204.7629, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(2221.5276, -121.08163, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(1765.6228, -142.59602, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(1847.569, -74.92113, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(1892.9296, -17.784805, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(2003.592, 62.31846, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(2066.8772, 80.2912, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(2119.8486, 77.40632, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(2242.1443, 66.34759, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(2292.395, -24.457054, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(2118.7314, -76.96188, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(1964.4036, -223.86136, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(2068.4211, -321.3407, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(2170.4683, -344.3009, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(2100.988, -179.60414, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(2390.681, -235.18121, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(2343.4553, -220.27817, 20));
		AddSpawnPoint( "f_rokas_27.Id7", "f_rokas_27", Spot(1992.355, -416.7383, 20));

	}
}
