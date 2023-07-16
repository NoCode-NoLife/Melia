//--- Melia Script -----------------------------------------------------------
// d_velniasprison_51_3
//
//--- Description -----------------------------------------------------------
// Sets up the d_velniasprison_51_3 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DVelniasprison513MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("d_velniasprison_51_3", MonsterId.Hohen_Ritter, Properties("MHP", 206620, "MINPATK", 3158, "MAXPATK", 3783, "MINMATK", 3158, "MAXMATK", 3783, "DEF", 7937, "MDEF", 7937));
		AddPropertyOverrides("d_velniasprison_51_3", MonsterId.Hohen_Barkle, Properties("MHP", 208313, "MINPATK", 3180, "MAXPATK", 3809, "MINMATK", 3180, "MAXMATK", 3809, "DEF", 8091, "MDEF", 8091));
		AddPropertyOverrides("d_velniasprison_51_3", MonsterId.Hohen_Orben, Properties("MHP", 210031, "MINPATK", 3202, "MAXPATK", 3837, "MINMATK", 3202, "MAXMATK", 3837, "DEF", 8248, "MDEF", 8248));
		AddPropertyOverrides("d_velniasprison_51_3", MonsterId.Hohen_Mane, Properties("MHP", 211774, "MINPATK", 3224, "MAXPATK", 3864, "MINMATK", 3224, "MAXMATK", 3864, "DEF", 8407, "MDEF", 8407));

		// Monster Spawners --------------------------------

		AddSpawner("d_velniasprison_51_3.Id1", MonsterId.Hohen_Ritter, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_3.Id2", MonsterId.Hohen_Barkle, 40, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_3.Id3", MonsterId.Rootcrystal_05, 18, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("d_velniasprison_51_3.Id4", MonsterId.Hohen_Orben, 8, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_3.Id5", MonsterId.Hohen_Mane, 40, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_3.Id6", MonsterId.Hohen_Ritter, 40, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// Hohen_Ritter Spawn Points
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(-2470.3342, -1210.0923, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(-2437.2158, -368.78738, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(-2544.2769, -214.55579, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(-2639.053, -313.62933, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(-2548.772, -1051.1705, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(-2654.4346, -1206.3047, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(-2862.0781, -1182.4062, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(-2320.7095, -1148.2617, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(-2514.8267, 534.1712, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(-2608.7031, 300.7229, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(-2139.6277, 908.04694, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(-1487.2595, 929.08356, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(-1324.3301, 931.4311, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(-256.18387, 899.0167, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(40.92189, 903.8863, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(301.07504, 879.38934, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(423.67255, 797.97845, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(474.9992, 484.6626, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(536.2272, 442.68375, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(1120.9374, 345.04617, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(1065.329, 292.13593, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(929.4621, 461.7149, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(1710.2848, 745.6142, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(1731.8285, -47.66804, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(1692.8413, -831.0047, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(1583.824, -672.27435, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(1783.4093, -624.02734, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(1906.3411, -1122.1436, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(1790.1732, -1117.4097, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(2293.5605, -1012.4233, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(2285.861, -269.72357, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(2175.3547, -299.1369, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(2136.4236, -89.62607, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(2179.0215, 396.06888, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(2186.5503, 372.26926, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(1996.2855, 326.88345, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(2308.1045, 874.9022, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(2147.9155, 910.613, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(2540.2937, -630.21155, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Spot(2306.9187, -650.1522, 40));

		// Hohen_Barkle Spawn Points
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(1664.551, -659.76013, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(2261.1614, -175.71332, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(2286.386, -331.22375, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(1862.4763, -1142.9563, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(2137.8557, -1135.6852, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(2375.4395, -1002.5434, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(1713.4551, -32.817654, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(1701.3098, 201.6229, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(2503.4207, 905.42065, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(2792.6047, 900.96466, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(2113.6694, 526.6793, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(2113.5398, 352.7535, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(2335.1946, 369.53488, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(-717.42584, 907.0461, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(1198.4296, 338.3175, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(1012.4084, 367.1623, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(-798.91284, 540.52576, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(-1455.0752, 359.9615, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(559.8366, 937.81665, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(458.74002, 898.4102, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(11.862038, 869.7475, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(551.67596, 476.0669, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(315.14062, 510.16492, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(-1938.9901, 939.3286, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(-1658.4961, 419.72147, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(-573.23206, 591.6898, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(-729.15094, 296.47458, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(-2497.782, 874.1619, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(-2452.0955, 540.9465, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(-2619.133, 344.19925, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(-2420.6506, 221.58601, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(-1910.6266, -226.93643, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(-1910.6266, -226.93643, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(-1936.9641, 256.6394, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(-1910.0774, -16.841217, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(-1938.3794, 585.1249, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(-1272.375, 885.7685, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(1707.3881, -261.99402, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(1773.792, 441.74954, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(1692.8269, 773.5558, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(2277.5593, 506.40366, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(2118.682, -310.0515, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(2060.8545, -162.43854, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(1679.6348, -857.86774, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(1947.2888, -665.7292, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(2259.2793, -596.2693, 40));
		AddSpawnPoint( "d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Spot(2153.0696, -907.12744, 40));

		// Rootcrystal_05 Spawn Points
		AddSpawnPoint( "d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Spot(-2533.1567, -1134.2784, 200));
		AddSpawnPoint( "d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Spot(-2692.1978, -703.6826, 200));
		AddSpawnPoint( "d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Spot(-2442.1257, -288.61057, 200));
		AddSpawnPoint( "d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Spot(-1906.8152, -710.2344, 200));
		AddSpawnPoint( "d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Spot(-1907.2908, -162.75703, 200));
		AddSpawnPoint( "d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Spot(-1904.7931, 442.89288, 200));
		AddSpawnPoint( "d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Spot(-1932.762, 952.07294, 200));
		AddSpawnPoint( "d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Spot(-2519.0867, 894.44305, 200));
		AddSpawnPoint( "d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Spot(-2662.2253, 303.70023, 200));
		AddSpawnPoint( "d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Spot(-1391.968, 921.84863, 200));
		AddSpawnPoint( "d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Spot(-1313.006, 365.11197, 200));
		AddSpawnPoint( "d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Spot(-674.7086, 910.07495, 200));
		AddSpawnPoint( "d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Spot(-660.3102, 450.54532, 200));
		AddSpawnPoint( "d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Spot(37.81358, 967.3977, 200));
		AddSpawnPoint( "d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Spot(755.2533, 923.0126, 200));
		AddSpawnPoint( "d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Spot(1657.2114, 951.24036, 200));
		AddSpawnPoint( "d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Spot(484.4997, 501.33957, 200));
		AddSpawnPoint( "d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Spot(2046.1987, 331.4843, 200));
		AddSpawnPoint( "d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Spot(2257.907, 534.50696, 200));
		AddSpawnPoint( "d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Spot(2123.567, -207.10606, 200));
		AddSpawnPoint( "d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Spot(2222.1233, -637.60803, 200));
		AddSpawnPoint( "d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Spot(2280.8596, -1005.0701, 200));
		AddSpawnPoint( "d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Spot(1868.7448, -1102.0007, 200));
		AddSpawnPoint( "d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Spot(2903.6914, -699.07196, 200));
		AddSpawnPoint( "d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Spot(1735.9777, -740.2688, 200));
		AddSpawnPoint( "d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Spot(952.84485, 421.66254, 200));
		AddSpawnPoint( "d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Spot(1190.5834, 299.0619, 200));

		// Hohen_Orben Spawn Points
		AddSpawnPoint( "d_velniasprison_51_3.Id4", "d_velniasprison_51_3", Spot(-2513.0547, -652.55066, 50));
		AddSpawnPoint( "d_velniasprison_51_3.Id4", "d_velniasprison_51_3", Spot(-2550.472, -1144.2368, 50));
		AddSpawnPoint( "d_velniasprison_51_3.Id4", "d_velniasprison_51_3", Spot(-2936.8994, -1176.5537, 50));
		AddSpawnPoint( "d_velniasprison_51_3.Id4", "d_velniasprison_51_3", Spot(-2515.66, -335.29276, 50));
		AddSpawnPoint( "d_velniasprison_51_3.Id4", "d_velniasprison_51_3", Spot(-3206.034, -698.25244, 50));
		AddSpawnPoint( "d_velniasprison_51_3.Id4", "d_velniasprison_51_3", Spot(-1925.1147, -710.37286, 50));
		AddSpawnPoint( "d_velniasprison_51_3.Id4", "d_velniasprison_51_3", Spot(-2617.7554, 250.81961, 50));
		AddSpawnPoint( "d_velniasprison_51_3.Id4", "d_velniasprison_51_3", Spot(-1550.3696, 315.41016, 50));
		AddSpawnPoint( "d_velniasprison_51_3.Id4", "d_velniasprison_51_3", Spot(-1449.1896, 474.48682, 50));
		AddSpawnPoint( "d_velniasprison_51_3.Id4", "d_velniasprison_51_3", Spot(-2435.787, 323.77283, 50));
		AddSpawnPoint( "d_velniasprison_51_3.Id4", "d_velniasprison_51_3", Spot(-2495.3489, 790.6006, 50));
		AddSpawnPoint( "d_velniasprison_51_3.Id4", "d_velniasprison_51_3", Spot(-2715.5796, 235.01956, 50));

		// Hohen_Mane Spawn Points
		AddSpawnPoint( "d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Spot(-3230.0894, -736.9279, 35));
		AddSpawnPoint( "d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Spot(-2568.2498, -368.9029, 35));
		AddSpawnPoint( "d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Spot(-2477.7815, 569.0283, 35));
		AddSpawnPoint( "d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Spot(-2537.2168, 323.0225, 35));
		AddSpawnPoint( "d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Spot(-1902.8265, -19.252098, 35));
		AddSpawnPoint( "d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Spot(998.2435, 284.14307, 35));
		AddSpawnPoint( "d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Spot(2150.5083, 409.0015, 35));
		AddSpawnPoint( "d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Spot(1043.2866, 566.83044, 35));
		AddSpawnPoint( "d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Spot(498.84113, 538.4292, 35));
		AddSpawnPoint( "d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Spot(-1540.0272, 495.85254, 35));
		AddSpawnPoint( "d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Spot(-1923.9152, 547.5173, 35));
		AddSpawnPoint( "d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Spot(-2546.8726, -1169.2158, 35));
		AddSpawnPoint( "d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Spot(-2408.6313, -254.26288, 35));
		AddSpawnPoint( "d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Spot(-1551.8019, 270.71704, 35));
		AddSpawnPoint( "d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Spot(2096.528, -229.18272, 35));
		AddSpawnPoint( "d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Spot(2310.6672, -228.52261, 35));
		AddSpawnPoint( "d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Spot(2218.663, -371.26358, 35));
		AddSpawnPoint( "d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Spot(1637.2903, -793.53516, 35));
		AddSpawnPoint( "d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Spot(1723.9126, -618.2066, 35));
		AddSpawnPoint( "d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Spot(-2564.1226, -1046.5305, 35));
		AddSpawnPoint( "d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Spot(-2370.6458, -1076.0253, 35));
		AddSpawnPoint( "d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Spot(-2664.0496, -220.71303, 35));
		AddSpawnPoint( "d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Spot(-2539.158, -625.8404, 35));
		AddSpawnPoint( "d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Spot(-2231.852, -679.78784, 35));
		AddSpawnPoint( "d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Spot(-1957.9171, -748.8471, 35));
		AddSpawnPoint( "d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Spot(-1901.4371, -844.36163, 35));
		AddSpawnPoint( "d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Spot(-1785.4829, -733.90936, 35));
		AddSpawnPoint( "d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Spot(-1961.3015, -470.995, 35));
		AddSpawnPoint( "d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Spot(-1929.5472, 341.13593, 35));
		AddSpawnPoint( "d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Spot(-2446.5435, 764.54346, 35));
		AddSpawnPoint( "d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Spot(-2633.2144, 437.40195, 35));
		AddSpawnPoint( "d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Spot(-2210.424, 875.418, 35));
		AddSpawnPoint( "d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Spot(-1566.1954, 914.362, 35));
		AddSpawnPoint( "d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Spot(-1398.214, 407.35724, 35));
		AddSpawnPoint( "d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Spot(-1352.7137, 269.09937, 35));
		AddSpawnPoint( "d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Spot(-749.44073, 921.5053, 35));
		AddSpawnPoint( "d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Spot(-643.3584, 696.3387, 35));
		AddSpawnPoint( "d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Spot(-772.0067, 414.45508, 35));

		// Hohen_Ritter Spawn Points
		AddSpawnPoint( "d_velniasprison_51_3.Id6", "d_velniasprison_51_3", Spot(1696.8136, 293.6232, 9999));

	}
}
