//--- Melia Script -----------------------------------------------------------
// f_tableland_70
//
//--- Description -----------------------------------------------------------
// Sets up the f_tableland_70 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FTableland70MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("f_tableland_70.Id1", MonsterId.Hohen_Mane_Purple, 10, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);
		AddSpawner("f_tableland_70.Id2", MonsterId.Hohen_Mage_Blue, 12, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);
		AddSpawner("f_tableland_70.Id3", MonsterId.Cronewt_Blue, 80, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);
		AddSpawner("f_tableland_70.Id4", MonsterId.Lapasape_Bow_Blue, 20, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);
		AddSpawner("f_tableland_70.Id5", MonsterId.Rootcrystal_03, 26, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("f_tableland_70.Id6", MonsterId.Lapasape_Bow_Blue, 20, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Hohen_Mane_Purple Spawn Points
		AddSpawnPoint( "f_tableland_70.Id1", "f_tableland_70", Spot(2179.591, -2786.0144, 25));
		AddSpawnPoint( "f_tableland_70.Id1", "f_tableland_70", Spot(2252.6277, -2714.1401, 25));
		AddSpawnPoint( "f_tableland_70.Id1", "f_tableland_70", Spot(1991.2391, -3028.1436, 25));
		AddSpawnPoint( "f_tableland_70.Id1", "f_tableland_70", Spot(2664.9966, -3468.9873, 25));
		AddSpawnPoint( "f_tableland_70.Id1", "f_tableland_70", Spot(2764.9368, -3282.2322, 25));
		AddSpawnPoint( "f_tableland_70.Id1", "f_tableland_70", Spot(1271.4666, -3142.5605, 25));
		AddSpawnPoint( "f_tableland_70.Id1", "f_tableland_70", Spot(1245.9897, -2963.627, 25));
		AddSpawnPoint( "f_tableland_70.Id1", "f_tableland_70", Spot(2343.3938, -2041.9487, 25));
		AddSpawnPoint( "f_tableland_70.Id1", "f_tableland_70", Spot(1722.4199, -3032.47, 25));
		AddSpawnPoint( "f_tableland_70.Id1", "f_tableland_70", Spot(2206.186, -1871.1316, 25));
		AddSpawnPoint( "f_tableland_70.Id1", "f_tableland_70", Spot(2568.4016, -2124.287, 25));
		AddSpawnPoint( "f_tableland_70.Id1", "f_tableland_70", Spot(2561.6255, -2273.936, 25));
		AddSpawnPoint( "f_tableland_70.Id1", "f_tableland_70", Spot(3898.365, -4347.2764, 25));
		AddSpawnPoint( "f_tableland_70.Id1", "f_tableland_70", Spot(3938.1655, -2976.9592, 25));

		// Hohen_Mage_Blue Spawn Points
		AddSpawnPoint( "f_tableland_70.Id2", "f_tableland_70", Spot(2465.0522, -2824.302, 25));
		AddSpawnPoint( "f_tableland_70.Id2", "f_tableland_70", Spot(1156.4247, -3042.4475, 25));
		AddSpawnPoint( "f_tableland_70.Id2", "f_tableland_70", Spot(1294.6381, -3067.8628, 25));
		AddSpawnPoint( "f_tableland_70.Id2", "f_tableland_70", Spot(1585.2744, -3009.037, 25));
		AddSpawnPoint( "f_tableland_70.Id2", "f_tableland_70", Spot(2513.4094, -2170.85, 25));
		AddSpawnPoint( "f_tableland_70.Id2", "f_tableland_70", Spot(2651.052, -2321.7852, 25));
		AddSpawnPoint( "f_tableland_70.Id2", "f_tableland_70", Spot(2222.2712, -2579.7104, 25));
		AddSpawnPoint( "f_tableland_70.Id2", "f_tableland_70", Spot(4423.0737, -2879.987, 25));
		AddSpawnPoint( "f_tableland_70.Id2", "f_tableland_70", Spot(4096.1113, -2560.9888, 25));
		AddSpawnPoint( "f_tableland_70.Id2", "f_tableland_70", Spot(4245.204, -2707.027, 25));
		AddSpawnPoint( "f_tableland_70.Id2", "f_tableland_70", Spot(4526.419, -2534.066, 25));
		AddSpawnPoint( "f_tableland_70.Id2", "f_tableland_70", Spot(4105.162, -2707.1458, 25));
		AddSpawnPoint( "f_tableland_70.Id2", "f_tableland_70", Spot(2143.7595, -2996.0654, 25));
		AddSpawnPoint( "f_tableland_70.Id2", "f_tableland_70", Spot(2730.1802, -3347.7483, 25));
		AddSpawnPoint( "f_tableland_70.Id2", "f_tableland_70", Spot(3984.9878, -3970.3726, 25));
		AddSpawnPoint( "f_tableland_70.Id2", "f_tableland_70", Spot(2673.5781, -3562.3242, 25));
		AddSpawnPoint( "f_tableland_70.Id2", "f_tableland_70", Spot(3929.6155, -4220.1274, 25));

		// Cronewt_Blue Spawn Points
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2035.4763, -2893.7927, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2663.7346, -3388.4546, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2173.2537, -1936.7401, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(3960.4343, -2109.6975, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(4126.5083, -1912.9341, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(4294.3403, -2919.201, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(4183.1216, -2438.5366, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(3610.029, -3245.5415, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(1082.7303, -3150.194, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(1077.871, -2950.317, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(3355.8433, -3643.1733, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(4075.5654, -4358.3057, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(3857.4204, -4295.129, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(4014.7163, -4117.2554, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(4168.4355, -4266.5444, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(4152.3374, -4095.6794, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(4148.0874, -3913.933, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(3946.5989, -4398.139, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(4063.6033, -3829.0894, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(4032.357, -3909.804, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(3805.4622, -3946.9663, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(3649.322, -3892.5605, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(3499.601, -3733.3328, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(3445.5078, -3769.7854, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(3613.529, -3808.1106, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(3149.148, -3550.6772, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(3693.037, -3416.781, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(3471.4934, -3437.4097, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(3263.0747, -3321.1729, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(3293.3196, -3476.1455, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(3253.7708, -3244.5679, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(3831.6213, -3349.8025, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(3514.2004, -3591.7695, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(3580.762, -3537.9219, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(3785.1797, -3530.2363, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(3550.1523, -3337.7957, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(3722.3235, -3207.4268, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(3707.1016, -3267.4844, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(3407.5417, -3323.1514, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(3513.7517, -3166.1514, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(4108.931, -2970.304, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(4000.5527, -2933.9666, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(3981.7507, -2824.8916, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(3983.9094, -2752.5933, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(4070.296, -2655.009, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(4169.5396, -2599.8462, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(4038.781, -2579.1143, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(4091.664, -2456.662, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(4271.995, -2449.057, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(4375.83, -2621.6853, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(4531.093, -2627.105, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(4421.96, -2748.5327, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(4362.2905, -3001.2825, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(4464.322, -2953.9673, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(4519.165, -2825.283, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(4487.087, -2484.3857, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(4235.6763, -2699.2334, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(4230.2256, -1997.236, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(4424.104, -2033.1608, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(4249.0166, -2114.533, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(4036.9915, -1991.6578, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(4094.0227, -2156.5637, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(4035.19, -2214.6587, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(3982.8008, -2239.2969, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(3744.1475, -2080.517, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(3772.9822, -1922.7268, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(3845.0122, -1897.1187, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(4027.4932, -1701.4307, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(3842.6345, -2040.8446, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(4116.117, -1671.3074, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(4283.2754, -1722.6064, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(4370.818, -1960.1234, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(4207.0874, -1832.6554, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(3993.522, -1907.9575, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(4058.386, -1796.466, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(3361.91, -2986.7239, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(3357.025, -2882.5566, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(3392.3088, -2935.025, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(3377.4424, -3042.222, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2879.6958, -3741.5112, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2954.2258, -3688.122, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(3016.2761, -3468.0073, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2850.4111, -3401.195, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2868.9827, -3496.3818, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2758.2095, -3558.0168, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2641.8794, -3742.9155, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2754.571, -3767.7336, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2548.4856, -3569.1438, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2540.4133, -3262.744, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2819.1394, -3265.271, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2953.9783, -3317.0942, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2974.4697, -3153.2139, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2540.305, -3325.927, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(888.9416, -3039.7913, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(928.55975, -2980.7646, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(1066.3411, -3036.5444, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(1183.3125, -3153.6907, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(998.8666, -3244.6895, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(1231.296, -3280.3042, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(1387.8722, -3103.4363, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(1203.6876, -3021.0295, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(1194.842, -2918.297, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(1233.8551, -2789.4875, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(1332.0134, -3252.392, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(1298.2323, -2908.175, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(923.3838, -3098.3425, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2047.8536, -3065.4216, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2127.9036, -3103.339, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2236.7554, -3077.6648, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2309.6467, -3169.76, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2403.5107, -3022.8013, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2248.4287, -2717.9426, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2106.594, -2717.7227, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2344.918, -2859.8777, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2209.803, -2930.6755, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2519.6965, -2880.4739, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2381.717, -2690.1047, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2258.8472, -2575.476, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2417.1763, -2599.4124, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2598.912, -2692.4287, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2678.073, -2724.4624, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2647.1245, -2623.173, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2579.0747, -2549.0327, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2605.2183, -2481.6338, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2701.6755, -2586.1333, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2422.3735, -2123.4717, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2402.9043, -2033.1559, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2254.6934, -1947.5742, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2330.7017, -1863.497, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2546.2551, -1759.8948, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2590.5178, -2031.485, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2637.7385, -2086.03, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2490.5776, -2095.841, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2683.6775, -1937.7976, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2638.2815, -1860.1656, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2633.665, -1780.6672, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2729.8162, -1751.5494, 25));
		AddSpawnPoint( "f_tableland_70.Id3", "f_tableland_70", Spot(2704.1194, -1815.6571, 25));

		// Lapasape_Bow_Blue Spawn Points
		AddSpawnPoint( "f_tableland_70.Id4", "f_tableland_70", Spot(3917.4124, -1871.8882, 25));
		AddSpawnPoint( "f_tableland_70.Id4", "f_tableland_70", Spot(2336.4011, -2568.388, 25));
		AddSpawnPoint( "f_tableland_70.Id4", "f_tableland_70", Spot(4110.5464, -3828.6643, 25));
		AddSpawnPoint( "f_tableland_70.Id4", "f_tableland_70", Spot(3247.5862, -3494.2253, 25));
		AddSpawnPoint( "f_tableland_70.Id4", "f_tableland_70", Spot(3596.045, -3300.9917, 25));
		AddSpawnPoint( "f_tableland_70.Id4", "f_tableland_70", Spot(4283.465, -2823.2363, 25));
		AddSpawnPoint( "f_tableland_70.Id4", "f_tableland_70", Spot(4399.608, -2582.5085, 25));
		AddSpawnPoint( "f_tableland_70.Id4", "f_tableland_70", Spot(3977.0664, -1974.4478, 25));
		AddSpawnPoint( "f_tableland_70.Id4", "f_tableland_70", Spot(2138.0496, -2939.8376, 25));
		AddSpawnPoint( "f_tableland_70.Id4", "f_tableland_70", Spot(2302.2537, -2699.6277, 25));
		AddSpawnPoint( "f_tableland_70.Id4", "f_tableland_70", Spot(2563.7898, -2875.6245, 25));
		AddSpawnPoint( "f_tableland_70.Id4", "f_tableland_70", Spot(2369.2473, -2889.317, 25));
		AddSpawnPoint( "f_tableland_70.Id4", "f_tableland_70", Spot(2712.5276, -3362.5452, 25));
		AddSpawnPoint( "f_tableland_70.Id4", "f_tableland_70", Spot(2687.427, -3543.466, 25));
		AddSpawnPoint( "f_tableland_70.Id4", "f_tableland_70", Spot(2929.9575, -3458.432, 25));
		AddSpawnPoint( "f_tableland_70.Id4", "f_tableland_70", Spot(3516.019, -3540.2637, 25));
		AddSpawnPoint( "f_tableland_70.Id4", "f_tableland_70", Spot(4224.957, -2581.6665, 25));
		AddSpawnPoint( "f_tableland_70.Id4", "f_tableland_70", Spot(3986.764, -1814.4375, 25));
		AddSpawnPoint( "f_tableland_70.Id4", "f_tableland_70", Spot(2232.5034, -2821.9094, 25));
		AddSpawnPoint( "f_tableland_70.Id4", "f_tableland_70", Spot(2559.29, -2175.9194, 25));

		// Rootcrystal_03 Spawn Points
		AddSpawnPoint( "f_tableland_70.Id5", "f_tableland_70", Spot(4362.1743, -4438.419, 40));
		AddSpawnPoint( "f_tableland_70.Id5", "f_tableland_70", Spot(4051.047, -4192.611, 40));
		AddSpawnPoint( "f_tableland_70.Id5", "f_tableland_70", Spot(3719.3818, -3880.9126, 40));
		AddSpawnPoint( "f_tableland_70.Id5", "f_tableland_70", Spot(3450.9316, -3635.3066, 40));
		AddSpawnPoint( "f_tableland_70.Id5", "f_tableland_70", Spot(3699.6233, -3309.9375, 40));
		AddSpawnPoint( "f_tableland_70.Id5", "f_tableland_70", Spot(3302.0828, -3252.2468, 40));
		AddSpawnPoint( "f_tableland_70.Id5", "f_tableland_70", Spot(3490.6821, -2612.8806, 40));
		AddSpawnPoint( "f_tableland_70.Id5", "f_tableland_70", Spot(3139.392, -2331.612, 40));
		AddSpawnPoint( "f_tableland_70.Id5", "f_tableland_70", Spot(3489.7388, -2048.7964, 40));
		AddSpawnPoint( "f_tableland_70.Id5", "f_tableland_70", Spot(3793.5574, -2010.3497, 40));
		AddSpawnPoint( "f_tableland_70.Id5", "f_tableland_70", Spot(4250.7046, -1995.9786, 40));
		AddSpawnPoint( "f_tableland_70.Id5", "f_tableland_70", Spot(4195.8804, -1657.5896, 40));
		AddSpawnPoint( "f_tableland_70.Id5", "f_tableland_70", Spot(4160.7896, -2537.4849, 40));
		AddSpawnPoint( "f_tableland_70.Id5", "f_tableland_70", Spot(4070.327, -2880.5112, 40));
		AddSpawnPoint( "f_tableland_70.Id5", "f_tableland_70", Spot(4503.568, -2784.8833, 40));
		AddSpawnPoint( "f_tableland_70.Id5", "f_tableland_70", Spot(2382.4734, -2625.4604, 40));
		AddSpawnPoint( "f_tableland_70.Id5", "f_tableland_70", Spot(2139.1218, -2828.1572, 40));
		AddSpawnPoint( "f_tableland_70.Id5", "f_tableland_70", Spot(2243.6843, -3110.7686, 40));
		AddSpawnPoint( "f_tableland_70.Id5", "f_tableland_70", Spot(2576.2903, -3556.4238, 40));
		AddSpawnPoint( "f_tableland_70.Id5", "f_tableland_70", Spot(2935.109, -3576.8606, 40));
		AddSpawnPoint( "f_tableland_70.Id5", "f_tableland_70", Spot(2798.2734, -3249.9883, 40));
		AddSpawnPoint( "f_tableland_70.Id5", "f_tableland_70", Spot(2516.164, -2111.2183, 40));
		AddSpawnPoint( "f_tableland_70.Id5", "f_tableland_70", Spot(2338.7615, -1778.0349, 40));
		AddSpawnPoint( "f_tableland_70.Id5", "f_tableland_70", Spot(1339.2736, -3068.3877, 40));
		AddSpawnPoint( "f_tableland_70.Id5", "f_tableland_70", Spot(1043.8628, -3205.0813, 40));
		AddSpawnPoint( "f_tableland_70.Id5", "f_tableland_70", Spot(938.665, -2932.9102, 40));

		// Lapasape_Bow_Blue Spawn Points
		AddSpawnPoint( "f_tableland_70.Id6", "f_tableland_70", Spot(3215.2393, -3293.0947, 9999));

	}
}
