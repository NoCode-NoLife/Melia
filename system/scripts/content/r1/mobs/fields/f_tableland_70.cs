//--- Melia Script -----------------------------------------------------------
// f_tableland_70
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Ibre Plateau' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FTableland70MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("f_tableland_70.Id1", MonsterId.Hohen_Mane_Purple, 8, 10, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);
		AddSpawner("f_tableland_70.Id2", MonsterId.Hohen_Mage_Blue, 9, 12, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);
		AddSpawner("f_tableland_70.Id3", MonsterId.Cronewt_Blue, 60, 80, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);
		AddSpawner("f_tableland_70.Id4", MonsterId.Lapasape_Bow_Blue, 15, 20, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);
		AddSpawner("f_tableland_70.Id5", MonsterId.Rootcrystal_03, 20, 26, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("f_tableland_70.Id6", MonsterId.Lapasape_Bow_Blue, 15, 20, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Hohen_Mane_Purple' GenType 1 Spawn Points
		AddSpawnPoint("f_tableland_70.Id1", "f_tableland_70", Rectangle(2179.591, -2786.0144, 25));
		AddSpawnPoint("f_tableland_70.Id1", "f_tableland_70", Rectangle(2252.6277, -2714.1401, 25));
		AddSpawnPoint("f_tableland_70.Id1", "f_tableland_70", Rectangle(1991.2391, -3028.1436, 25));
		AddSpawnPoint("f_tableland_70.Id1", "f_tableland_70", Rectangle(2664.9966, -3468.9873, 25));
		AddSpawnPoint("f_tableland_70.Id1", "f_tableland_70", Rectangle(2764.9368, -3282.2322, 25));
		AddSpawnPoint("f_tableland_70.Id1", "f_tableland_70", Rectangle(1271.4666, -3142.5605, 25));
		AddSpawnPoint("f_tableland_70.Id1", "f_tableland_70", Rectangle(1245.9897, -2963.627, 25));
		AddSpawnPoint("f_tableland_70.Id1", "f_tableland_70", Rectangle(2343.3938, -2041.9487, 25));
		AddSpawnPoint("f_tableland_70.Id1", "f_tableland_70", Rectangle(1722.4199, -3032.47, 25));
		AddSpawnPoint("f_tableland_70.Id1", "f_tableland_70", Rectangle(2206.186, -1871.1316, 25));
		AddSpawnPoint("f_tableland_70.Id1", "f_tableland_70", Rectangle(2568.4016, -2124.287, 25));
		AddSpawnPoint("f_tableland_70.Id1", "f_tableland_70", Rectangle(2561.6255, -2273.936, 25));
		AddSpawnPoint("f_tableland_70.Id1", "f_tableland_70", Rectangle(3898.365, -4347.2764, 25));
		AddSpawnPoint("f_tableland_70.Id1", "f_tableland_70", Rectangle(3938.1655, -2976.9592, 25));

		// 'Hohen_Mage_Blue' GenType 2 Spawn Points
		AddSpawnPoint("f_tableland_70.Id2", "f_tableland_70", Rectangle(2465.0522, -2824.302, 25));
		AddSpawnPoint("f_tableland_70.Id2", "f_tableland_70", Rectangle(1156.4247, -3042.4475, 25));
		AddSpawnPoint("f_tableland_70.Id2", "f_tableland_70", Rectangle(1294.6381, -3067.8628, 25));
		AddSpawnPoint("f_tableland_70.Id2", "f_tableland_70", Rectangle(1585.2744, -3009.037, 25));
		AddSpawnPoint("f_tableland_70.Id2", "f_tableland_70", Rectangle(2513.4094, -2170.85, 25));
		AddSpawnPoint("f_tableland_70.Id2", "f_tableland_70", Rectangle(2651.052, -2321.7852, 25));
		AddSpawnPoint("f_tableland_70.Id2", "f_tableland_70", Rectangle(2222.2712, -2579.7104, 25));
		AddSpawnPoint("f_tableland_70.Id2", "f_tableland_70", Rectangle(4423.0737, -2879.987, 25));
		AddSpawnPoint("f_tableland_70.Id2", "f_tableland_70", Rectangle(4096.1113, -2560.9888, 25));
		AddSpawnPoint("f_tableland_70.Id2", "f_tableland_70", Rectangle(4245.204, -2707.027, 25));
		AddSpawnPoint("f_tableland_70.Id2", "f_tableland_70", Rectangle(4526.419, -2534.066, 25));
		AddSpawnPoint("f_tableland_70.Id2", "f_tableland_70", Rectangle(4105.162, -2707.1458, 25));
		AddSpawnPoint("f_tableland_70.Id2", "f_tableland_70", Rectangle(2143.7595, -2996.0654, 25));
		AddSpawnPoint("f_tableland_70.Id2", "f_tableland_70", Rectangle(2730.1802, -3347.7483, 25));
		AddSpawnPoint("f_tableland_70.Id2", "f_tableland_70", Rectangle(3984.9878, -3970.3726, 25));
		AddSpawnPoint("f_tableland_70.Id2", "f_tableland_70", Rectangle(2673.5781, -3562.3242, 25));
		AddSpawnPoint("f_tableland_70.Id2", "f_tableland_70", Rectangle(3929.6155, -4220.1274, 25));

		// 'Cronewt_Blue' GenType 3 Spawn Points
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2035.4763, -2893.7927, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2663.7346, -3388.4546, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2173.2537, -1936.7401, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3960.4343, -2109.6975, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4126.5083, -1912.9341, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4294.3403, -2919.201, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4183.1216, -2438.5366, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3610.029, -3245.5415, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(1082.7303, -3150.194, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(1077.871, -2950.317, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3355.8433, -3643.1733, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4075.5654, -4358.3057, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3857.4204, -4295.129, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4014.7163, -4117.2554, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4168.4355, -4266.5444, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4152.3374, -4095.6794, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4148.0874, -3913.933, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3946.5989, -4398.139, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4063.6033, -3829.0894, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4032.357, -3909.804, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3805.4622, -3946.9663, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3649.322, -3892.5605, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3499.601, -3733.3328, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3445.5078, -3769.7854, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3613.529, -3808.1106, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3149.148, -3550.6772, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3693.037, -3416.781, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3471.4934, -3437.4097, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3263.0747, -3321.1729, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3293.3196, -3476.1455, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3253.7708, -3244.5679, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3831.6213, -3349.8025, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3514.2004, -3591.7695, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3580.762, -3537.9219, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3785.1797, -3530.2363, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3550.1523, -3337.7957, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3722.3235, -3207.4268, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3707.1016, -3267.4844, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3407.5417, -3323.1514, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3513.7517, -3166.1514, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4108.931, -2970.304, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4000.5527, -2933.9666, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3981.7507, -2824.8916, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3983.9094, -2752.5933, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4070.296, -2655.009, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4169.5396, -2599.8462, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4038.781, -2579.1143, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4091.664, -2456.662, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4271.995, -2449.057, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4375.83, -2621.6853, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4531.093, -2627.105, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4421.96, -2748.5327, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4362.2905, -3001.2825, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4464.322, -2953.9673, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4519.165, -2825.283, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4487.087, -2484.3857, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4235.6763, -2699.2334, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4230.2256, -1997.236, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4424.104, -2033.1608, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4249.0166, -2114.533, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4036.9915, -1991.6578, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4094.0227, -2156.5637, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4035.19, -2214.6587, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3982.8008, -2239.2969, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3744.1475, -2080.517, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3772.9822, -1922.7268, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3845.0122, -1897.1187, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4027.4932, -1701.4307, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3842.6345, -2040.8446, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4116.117, -1671.3074, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4283.2754, -1722.6064, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4370.818, -1960.1234, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4207.0874, -1832.6554, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3993.522, -1907.9575, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4058.386, -1796.466, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3361.91, -2986.7239, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3357.025, -2882.5566, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3392.3088, -2935.025, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3377.4424, -3042.222, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2879.6958, -3741.5112, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2954.2258, -3688.122, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3016.2761, -3468.0073, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2850.4111, -3401.195, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2868.9827, -3496.3818, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2758.2095, -3558.0168, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2641.8794, -3742.9155, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2754.571, -3767.7336, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2548.4856, -3569.1438, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2540.4133, -3262.744, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2819.1394, -3265.271, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2953.9783, -3317.0942, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2974.4697, -3153.2139, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2540.305, -3325.927, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(888.9416, -3039.7913, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(928.55975, -2980.7646, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(1066.3411, -3036.5444, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(1183.3125, -3153.6907, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(998.8666, -3244.6895, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(1231.296, -3280.3042, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(1387.8722, -3103.4363, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(1203.6876, -3021.0295, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(1194.842, -2918.297, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(1233.8551, -2789.4875, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(1332.0134, -3252.392, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(1298.2323, -2908.175, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(923.3838, -3098.3425, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2047.8536, -3065.4216, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2127.9036, -3103.339, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2236.7554, -3077.6648, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2309.6467, -3169.76, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2403.5107, -3022.8013, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2248.4287, -2717.9426, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2106.594, -2717.7227, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2344.918, -2859.8777, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2209.803, -2930.6755, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2519.6965, -2880.4739, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2381.717, -2690.1047, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2258.8472, -2575.476, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2417.1763, -2599.4124, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2598.912, -2692.4287, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2678.073, -2724.4624, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2647.1245, -2623.173, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2579.0747, -2549.0327, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2605.2183, -2481.6338, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2701.6755, -2586.1333, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2422.3735, -2123.4717, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2402.9043, -2033.1559, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2254.6934, -1947.5742, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2330.7017, -1863.497, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2546.2551, -1759.8948, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2590.5178, -2031.485, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2637.7385, -2086.03, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2490.5776, -2095.841, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2683.6775, -1937.7976, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2638.2815, -1860.1656, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2633.665, -1780.6672, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2729.8162, -1751.5494, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2704.1194, -1815.6571, 25));

		// 'Lapasape_Bow_Blue' GenType 4 Spawn Points
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(3917.4124, -1871.8882, 25));
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(2336.4011, -2568.388, 25));
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(4110.5464, -3828.6643, 25));
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(3247.5862, -3494.2253, 25));
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(3596.045, -3300.9917, 25));
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(4283.465, -2823.2363, 25));
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(4399.608, -2582.5085, 25));
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(3977.0664, -1974.4478, 25));
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(2138.0496, -2939.8376, 25));
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(2302.2537, -2699.6277, 25));
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(2563.7898, -2875.6245, 25));
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(2369.2473, -2889.317, 25));
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(2712.5276, -3362.5452, 25));
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(2687.427, -3543.466, 25));
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(2929.9575, -3458.432, 25));
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(3516.019, -3540.2637, 25));
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(4224.957, -2581.6665, 25));
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(3986.764, -1814.4375, 25));
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(2232.5034, -2821.9094, 25));
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(2559.29, -2175.9194, 25));

		// 'Rootcrystal_03' GenType 7 Spawn Points
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(4362.1743, -4438.419, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(4051.047, -4192.611, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(3719.3818, -3880.9126, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(3450.9316, -3635.3066, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(3699.6233, -3309.9375, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(3302.0828, -3252.2468, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(3490.6821, -2612.8806, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(3139.392, -2331.612, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(3489.7388, -2048.7964, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(3793.5574, -2010.3497, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(4250.7046, -1995.9786, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(4195.8804, -1657.5896, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(4160.7896, -2537.4849, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(4070.327, -2880.5112, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(4503.568, -2784.8833, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(2382.4734, -2625.4604, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(2139.1218, -2828.1572, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(2243.6843, -3110.7686, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(2576.2903, -3556.4238, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(2935.109, -3576.8606, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(2798.2734, -3249.9883, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(2516.164, -2111.2183, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(2338.7615, -1778.0349, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(1339.2736, -3068.3877, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(1043.8628, -3205.0813, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(938.665, -2932.9102, 40));

		// 'Lapasape_Bow_Blue' GenType 12 Spawn Points
		AddSpawnPoint("f_tableland_70.Id6", "f_tableland_70", Rectangle(3215.2393, -3293.0947, 9999));
	}
}
