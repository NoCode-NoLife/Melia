//--- Melia Script -----------------------------------------------------------
// Ibre Plateau Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_tableland_70'.
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
		AddSpawnPoint("f_tableland_70.Id1", "f_tableland_70", Rectangle(2179, -2786, 25));
		AddSpawnPoint("f_tableland_70.Id1", "f_tableland_70", Rectangle(2252, -2714, 25));
		AddSpawnPoint("f_tableland_70.Id1", "f_tableland_70", Rectangle(1991, -3028, 25));
		AddSpawnPoint("f_tableland_70.Id1", "f_tableland_70", Rectangle(2664, -3468, 25));
		AddSpawnPoint("f_tableland_70.Id1", "f_tableland_70", Rectangle(2764, -3282, 25));
		AddSpawnPoint("f_tableland_70.Id1", "f_tableland_70", Rectangle(1271, -3142, 25));
		AddSpawnPoint("f_tableland_70.Id1", "f_tableland_70", Rectangle(1245, -2963, 25));
		AddSpawnPoint("f_tableland_70.Id1", "f_tableland_70", Rectangle(2343, -2041, 25));
		AddSpawnPoint("f_tableland_70.Id1", "f_tableland_70", Rectangle(1722, -3032, 25));
		AddSpawnPoint("f_tableland_70.Id1", "f_tableland_70", Rectangle(2206, -1871, 25));
		AddSpawnPoint("f_tableland_70.Id1", "f_tableland_70", Rectangle(2568, -2124, 25));
		AddSpawnPoint("f_tableland_70.Id1", "f_tableland_70", Rectangle(2561, -2273, 25));
		AddSpawnPoint("f_tableland_70.Id1", "f_tableland_70", Rectangle(3898, -4347, 25));
		AddSpawnPoint("f_tableland_70.Id1", "f_tableland_70", Rectangle(3938, -2976, 25));

		// 'Hohen_Mage_Blue' GenType 2 Spawn Points
		AddSpawnPoint("f_tableland_70.Id2", "f_tableland_70", Rectangle(2465, -2824, 25));
		AddSpawnPoint("f_tableland_70.Id2", "f_tableland_70", Rectangle(1156, -3042, 25));
		AddSpawnPoint("f_tableland_70.Id2", "f_tableland_70", Rectangle(1294, -3067, 25));
		AddSpawnPoint("f_tableland_70.Id2", "f_tableland_70", Rectangle(1585, -3009, 25));
		AddSpawnPoint("f_tableland_70.Id2", "f_tableland_70", Rectangle(2513, -2170, 25));
		AddSpawnPoint("f_tableland_70.Id2", "f_tableland_70", Rectangle(2651, -2321, 25));
		AddSpawnPoint("f_tableland_70.Id2", "f_tableland_70", Rectangle(2222, -2579, 25));
		AddSpawnPoint("f_tableland_70.Id2", "f_tableland_70", Rectangle(4423, -2879, 25));
		AddSpawnPoint("f_tableland_70.Id2", "f_tableland_70", Rectangle(4096, -2560, 25));
		AddSpawnPoint("f_tableland_70.Id2", "f_tableland_70", Rectangle(4245, -2707, 25));
		AddSpawnPoint("f_tableland_70.Id2", "f_tableland_70", Rectangle(4526, -2534, 25));
		AddSpawnPoint("f_tableland_70.Id2", "f_tableland_70", Rectangle(4105, -2707, 25));
		AddSpawnPoint("f_tableland_70.Id2", "f_tableland_70", Rectangle(2143, -2996, 25));
		AddSpawnPoint("f_tableland_70.Id2", "f_tableland_70", Rectangle(2730, -3347, 25));
		AddSpawnPoint("f_tableland_70.Id2", "f_tableland_70", Rectangle(3984, -3970, 25));
		AddSpawnPoint("f_tableland_70.Id2", "f_tableland_70", Rectangle(2673, -3562, 25));
		AddSpawnPoint("f_tableland_70.Id2", "f_tableland_70", Rectangle(3929, -4220, 25));

		// 'Cronewt_Blue' GenType 3 Spawn Points
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2035, -2893, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2663, -3388, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2173, -1936, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3960, -2109, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4126, -1912, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4294, -2919, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4183, -2438, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3610, -3245, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(1082, -3150, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(1077, -2950, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3355, -3643, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4075, -4358, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3857, -4295, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4014, -4117, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4168, -4266, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4152, -4095, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4148, -3913, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3946, -4398, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4063, -3829, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4032, -3909, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3805, -3946, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3649, -3892, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3499, -3733, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3445, -3769, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3613, -3808, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3149, -3550, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3693, -3416, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3471, -3437, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3263, -3321, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3293, -3476, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3253, -3244, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3831, -3349, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3514, -3591, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3580, -3537, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3785, -3530, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3550, -3337, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3722, -3207, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3707, -3267, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3407, -3323, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3513, -3166, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4108, -2970, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4000, -2933, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3981, -2824, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3983, -2752, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4070, -2655, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4169, -2599, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4038, -2579, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4091, -2456, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4271, -2449, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4375, -2621, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4531, -2627, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4421, -2748, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4362, -3001, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4464, -2953, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4519, -2825, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4487, -2484, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4235, -2699, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4230, -1997, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4424, -2033, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4249, -2114, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4036, -1991, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4094, -2156, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4035, -2214, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3982, -2239, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3744, -2080, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3772, -1922, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3845, -1897, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4027, -1701, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3842, -2040, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4116, -1671, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4283, -1722, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4370, -1960, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4207, -1832, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3993, -1907, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(4058, -1796, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3361, -2986, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3357, -2882, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3392, -2935, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3377, -3042, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2879, -3741, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2954, -3688, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(3016, -3468, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2850, -3401, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2868, -3496, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2758, -3558, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2641, -3742, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2754, -3767, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2548, -3569, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2540, -3262, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2819, -3265, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2953, -3317, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2974, -3153, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2540, -3325, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(888, -3039, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(928, -2980, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(1066, -3036, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(1183, -3153, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(998, -3244, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(1231, -3280, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(1387, -3103, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(1203, -3021, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(1194, -2918, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(1233, -2789, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(1332, -3252, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(1298, -2908, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(923, -3098, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2047, -3065, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2127, -3103, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2236, -3077, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2309, -3169, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2403, -3022, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2248, -2717, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2106, -2717, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2344, -2859, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2209, -2930, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2519, -2880, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2381, -2690, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2258, -2575, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2417, -2599, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2598, -2692, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2678, -2724, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2647, -2623, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2579, -2549, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2605, -2481, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2701, -2586, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2422, -2123, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2402, -2033, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2254, -1947, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2330, -1863, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2546, -1759, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2590, -2031, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2637, -2086, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2490, -2095, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2683, -1937, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2638, -1860, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2633, -1780, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2729, -1751, 25));
		AddSpawnPoint("f_tableland_70.Id3", "f_tableland_70", Rectangle(2704, -1815, 25));

		// 'Lapasape_Bow_Blue' GenType 4 Spawn Points
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(3917, -1871, 25));
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(2336, -2568, 25));
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(4110, -3828, 25));
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(3247, -3494, 25));
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(3596, -3300, 25));
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(4283, -2823, 25));
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(4399, -2582, 25));
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(3977, -1974, 25));
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(2138, -2939, 25));
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(2302, -2699, 25));
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(2563, -2875, 25));
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(2369, -2889, 25));
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(2712, -3362, 25));
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(2687, -3543, 25));
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(2929, -3458, 25));
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(3516, -3540, 25));
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(4224, -2581, 25));
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(3986, -1814, 25));
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(2232, -2821, 25));
		AddSpawnPoint("f_tableland_70.Id4", "f_tableland_70", Rectangle(2559, -2175, 25));

		// 'Rootcrystal_03' GenType 7 Spawn Points
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(4362, -4438, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(4051, -4192, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(3719, -3880, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(3450, -3635, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(3699, -3309, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(3302, -3252, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(3490, -2612, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(3139, -2331, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(3489, -2048, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(3793, -2010, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(4250, -1995, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(4195, -1657, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(4160, -2537, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(4070, -2880, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(4503, -2784, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(2382, -2625, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(2139, -2828, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(2243, -3110, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(2576, -3556, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(2935, -3576, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(2798, -3249, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(2516, -2111, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(2338, -1778, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(1339, -3068, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(1043, -3205, 40));
		AddSpawnPoint("f_tableland_70.Id5", "f_tableland_70", Rectangle(938, -2932, 40));

		// 'Lapasape_Bow_Blue' GenType 12 Spawn Points
		AddSpawnPoint("f_tableland_70.Id6", "f_tableland_70", Rectangle(3215, -3293, 9999));
	}
}
