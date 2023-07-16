//--- Melia Script -----------------------------------------------------------
// f_coral_35_2
//
//--- Description -----------------------------------------------------------
// Sets up the f_coral_35_2 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FCoral352MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("f_coral_35_2.Id1", MonsterId.Rootcrystal_01, 15, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_coral_35_2.Id2", MonsterId.Siaulav_Bow_Orange, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_coral_35_2.Id3", MonsterId.Jukotail, 45, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_coral_35_2.Id4", MonsterId.Siaulav_Orange, 45, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_coral_35_2.Id5", MonsterId.Jukotail, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_coral_35_2.Id6", MonsterId.Siaulav_Orange, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_coral_35_2.Id7", MonsterId.Siaulav_Bow_Orange, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_coral_35_2.Id8", MonsterId.Jukotail, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "f_coral_35_2.Id1", "f_coral_35_2", Spot(-991.12024, 1252.2522, 100));
		AddSpawnPoint( "f_coral_35_2.Id1", "f_coral_35_2", Spot(-634.45325, 957.9657, 100));
		AddSpawnPoint( "f_coral_35_2.Id1", "f_coral_35_2", Spot(290.71036, -69.780945, 100));
		AddSpawnPoint( "f_coral_35_2.Id1", "f_coral_35_2", Spot(241.90465, -299.59155, 100));
		AddSpawnPoint( "f_coral_35_2.Id1", "f_coral_35_2", Spot(-178.38452, -798.2742, 100));
		AddSpawnPoint( "f_coral_35_2.Id1", "f_coral_35_2", Spot(-315.3986, -1017.2359, 100));
		AddSpawnPoint( "f_coral_35_2.Id1", "f_coral_35_2", Spot(-902.3393, -606.25543, 100));
		AddSpawnPoint( "f_coral_35_2.Id1", "f_coral_35_2", Spot(-808.4085, -418.0321, 100));
		AddSpawnPoint( "f_coral_35_2.Id1", "f_coral_35_2", Spot(-447.5074, -168.34203, 100));
		AddSpawnPoint( "f_coral_35_2.Id1", "f_coral_35_2", Spot(-278.32034, 2068.703, 100));
		AddSpawnPoint( "f_coral_35_2.Id1", "f_coral_35_2", Spot(308.27066, 2175.8809, 100));
		AddSpawnPoint( "f_coral_35_2.Id1", "f_coral_35_2", Spot(1807.3408, 324.9667, 100));
		AddSpawnPoint( "f_coral_35_2.Id1", "f_coral_35_2", Spot(1858.7532, 552.90753, 100));
		AddSpawnPoint( "f_coral_35_2.Id1", "f_coral_35_2", Spot(1511.7555, 1268.4235, 100));
		AddSpawnPoint( "f_coral_35_2.Id1", "f_coral_35_2", Spot(1331.7119, 1026.3391, 100));
		AddSpawnPoint( "f_coral_35_2.Id1", "f_coral_35_2", Spot(932.9914, 245.5253, 100));
		AddSpawnPoint( "f_coral_35_2.Id1", "f_coral_35_2", Spot(1192.1072, 823.6266, 100));
		AddSpawnPoint( "f_coral_35_2.Id1", "f_coral_35_2", Spot(705.84784, 391.23624, 100));
		AddSpawnPoint( "f_coral_35_2.Id1", "f_coral_35_2", Spot(-670.6996, -210.08653, 100));
		AddSpawnPoint( "f_coral_35_2.Id1", "f_coral_35_2", Spot(-87.5145, 214.94806, 100));
		AddSpawnPoint( "f_coral_35_2.Id1", "f_coral_35_2", Spot(-374.9357, 1201.54, 100));
		AddSpawnPoint( "f_coral_35_2.Id1", "f_coral_35_2", Spot(-205.31071, 778.9869, 100));
		AddSpawnPoint( "f_coral_35_2.Id1", "f_coral_35_2", Spot(-459.0009, 1775.0168, 100));

		// Siaulav_Bow_Orange Spawn Points
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(1667.7207, 819.97815, 30));
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(-493.56274, 1841.057, 30));
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(875.8337, 250.79349, 30));
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(398.60944, 2120.8752, 30));
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(1781.6611, 255.38223, 30));
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(-349.82617, 1213.9618, 30));
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(-455.5454, 1681.4492, 30));
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(1214.2448, 850.1638, 30));
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(-289.53662, 906.6354, 30));
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(1418.2805, 1231.6685, 30));
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(1338.3102, 1092.0767, 30));
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(1562.0308, 1251.8916, 30));
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(322.22345, 1963.6709, 30));
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(262.71307, 2159.81, 30));
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(-685.7861, 911.42224, 30));
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(1048.0205, 424.56964, 30));
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(1094.4918, 584.13995, 30));
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(708.1292, 492.0678, 30));
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(1847.9625, 50.03545, 30));
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(-615.8267, 1798.5022, 30));
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(1909.9406, 473.09088, 30));
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(-341.24503, 2082.8286, 30));
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(1911.7946, 174.92734, 30));
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(1795.655, 539.1129, 30));
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(1301.0782, 1203.7288, 30));
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(860.3987, 459.55963, 30));
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(-421.32736, -1001.1688, 30));
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(-260.31534, -875.55725, 30));
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(-261.27716, -967.97577, 30));
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(-278.75238, -1138.1826, 30));
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(-79.295715, -904.6419, 30));
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(304.3061, -174.99348, 30));
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(299.067, -291.61273, 30));
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(129.69008, -315.96262, 30));
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(-13.636078, -637.0681, 30));
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(77.70694, -443.3589, 30));
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(-472.4227, -772.563, 30));
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(-640.9495, -770.7464, 30));
		AddSpawnPoint( "f_coral_35_2.Id2", "f_coral_35_2", Spot(546.593, 2080.7063, 30));

		// Jukotail Spawn Points
		AddSpawnPoint( "f_coral_35_2.Id3", "f_coral_35_2", Spot(387.58017, 464.58258, 9999));
		AddSpawnPoint( "f_coral_35_2.Id3", "f_coral_35_2", Spot(199.88362, -190.60391, 9999));

		// Siaulav_Orange Spawn Points
		AddSpawnPoint( "f_coral_35_2.Id4", "f_coral_35_2", Spot(881.20483, 391.02487, 9999));

		// Jukotail Spawn Points
		AddSpawnPoint( "f_coral_35_2.Id5", "f_coral_35_2", Spot(-309.14966, 1858.5017, 35));
		AddSpawnPoint( "f_coral_35_2.Id5", "f_coral_35_2", Spot(-642.45856, 1922.8209, 35));
		AddSpawnPoint( "f_coral_35_2.Id5", "f_coral_35_2", Spot(-437.92197, 1776.7029, 35));
		AddSpawnPoint( "f_coral_35_2.Id5", "f_coral_35_2", Spot(-285.5793, 2082.43, 35));
		AddSpawnPoint( "f_coral_35_2.Id5", "f_coral_35_2", Spot(-415.31876, 1997.6111, 35));
		AddSpawnPoint( "f_coral_35_2.Id5", "f_coral_35_2", Spot(-714.83435, -250.5938, 35));
		AddSpawnPoint( "f_coral_35_2.Id5", "f_coral_35_2", Spot(-853.5265, -464.74234, 35));
		AddSpawnPoint( "f_coral_35_2.Id5", "f_coral_35_2", Spot(-413.91785, -82.77681, 35));
		AddSpawnPoint( "f_coral_35_2.Id5", "f_coral_35_2", Spot(-397.49994, 61.996716, 35));
		AddSpawnPoint( "f_coral_35_2.Id5", "f_coral_35_2", Spot(-575.90405, -227.78644, 35));
		AddSpawnPoint( "f_coral_35_2.Id5", "f_coral_35_2", Spot(-940.14795, -600.0514, 35));
		AddSpawnPoint( "f_coral_35_2.Id5", "f_coral_35_2", Spot(-949.2954, -416.18564, 35));
		AddSpawnPoint( "f_coral_35_2.Id5", "f_coral_35_2", Spot(-820.7066, -602.4941, 35));

		// Siaulav_Orange Spawn Points
		AddSpawnPoint( "f_coral_35_2.Id6", "f_coral_35_2", Spot(-701.6819, 1869.855, 35));
		AddSpawnPoint( "f_coral_35_2.Id6", "f_coral_35_2", Spot(-500.7184, 1763.4384, 35));
		AddSpawnPoint( "f_coral_35_2.Id6", "f_coral_35_2", Spot(-473.0567, 1927.0713, 35));
		AddSpawnPoint( "f_coral_35_2.Id6", "f_coral_35_2", Spot(-309.46634, 2009.202, 35));
		AddSpawnPoint( "f_coral_35_2.Id6", "f_coral_35_2", Spot(-562.5803, -98.11463, 35));
		AddSpawnPoint( "f_coral_35_2.Id6", "f_coral_35_2", Spot(-928.9509, -624.3027, 35));
		AddSpawnPoint( "f_coral_35_2.Id6", "f_coral_35_2", Spot(-473.32568, -225.85553, 35));
		AddSpawnPoint( "f_coral_35_2.Id6", "f_coral_35_2", Spot(-833.4148, -481.299, 35));
		AddSpawnPoint( "f_coral_35_2.Id6", "f_coral_35_2", Spot(-376.35648, -23.783749, 35));
		AddSpawnPoint( "f_coral_35_2.Id6", "f_coral_35_2", Spot(-337.7809, 1860.6608, 35));
		AddSpawnPoint( "f_coral_35_2.Id6", "f_coral_35_2", Spot(-225.4452, 2152.994, 35));
		AddSpawnPoint( "f_coral_35_2.Id6", "f_coral_35_2", Spot(-64.20517, 2290.7605, 35));

		// Siaulav_Bow_Orange Spawn Points
		AddSpawnPoint( "f_coral_35_2.Id7", "f_coral_35_2", Spot(-658.43243, -225.50636, 35));
		AddSpawnPoint( "f_coral_35_2.Id7", "f_coral_35_2", Spot(-791.16406, -446.73987, 35));
		AddSpawnPoint( "f_coral_35_2.Id7", "f_coral_35_2", Spot(-745.44684, -113.98285, 35));
		AddSpawnPoint( "f_coral_35_2.Id7", "f_coral_35_2", Spot(-419.13782, -90.604355, 35));
		AddSpawnPoint( "f_coral_35_2.Id7", "f_coral_35_2", Spot(-539.5184, -141.43123, 35));
		AddSpawnPoint( "f_coral_35_2.Id7", "f_coral_35_2", Spot(-933.4364, -553.01385, 35));
		AddSpawnPoint( "f_coral_35_2.Id7", "f_coral_35_2", Spot(-878.6919, -698.7657, 35));
		AddSpawnPoint( "f_coral_35_2.Id7", "f_coral_35_2", Spot(-585.7371, -786.0554, 35));

		// Jukotail Spawn Points
		AddSpawnPoint( "f_coral_35_2.Id8", "f_coral_35_2", Spot(-784.76025, 919.73047, 30));
		AddSpawnPoint( "f_coral_35_2.Id8", "f_coral_35_2", Spot(-581.34863, 875.424, 30));
		AddSpawnPoint( "f_coral_35_2.Id8", "f_coral_35_2", Spot(-689.97144, 1237.0425, 30));
		AddSpawnPoint( "f_coral_35_2.Id8", "f_coral_35_2", Spot(-678.83636, 1090.9951, 30));
		AddSpawnPoint( "f_coral_35_2.Id8", "f_coral_35_2", Spot(-502.51486, 1003.8917, 30));
		AddSpawnPoint( "f_coral_35_2.Id8", "f_coral_35_2", Spot(-365.685, 808.89075, 30));
		AddSpawnPoint( "f_coral_35_2.Id8", "f_coral_35_2", Spot(-328.55597, 1073.4232, 30));
		AddSpawnPoint( "f_coral_35_2.Id8", "f_coral_35_2", Spot(-289.5087, 892.73553, 30));
		AddSpawnPoint( "f_coral_35_2.Id8", "f_coral_35_2", Spot(-175.08116, 769.2602, 30));
		AddSpawnPoint( "f_coral_35_2.Id8", "f_coral_35_2", Spot(-142.51883, 905.34875, 30));
		AddSpawnPoint( "f_coral_35_2.Id8", "f_coral_35_2", Spot(-391.68042, 1316.6926, 30));
		AddSpawnPoint( "f_coral_35_2.Id8", "f_coral_35_2", Spot(-895.6649, 1139.3464, 30));
		AddSpawnPoint( "f_coral_35_2.Id8", "f_coral_35_2", Spot(-284.77127, 1427.4712, 30));
		AddSpawnPoint( "f_coral_35_2.Id8", "f_coral_35_2", Spot(-327.04803, 1558.4136, 30));
		AddSpawnPoint( "f_coral_35_2.Id8", "f_coral_35_2", Spot(-445.85248, 1667.7494, 30));

	}
}
