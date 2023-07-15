//--- Melia Script -----------------------------------------------------------
// f_nicopolis_81_3
//
//--- Description -----------------------------------------------------------
// Sets up the f_nicopolis_81_3 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FNicopolis813MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("f_nicopolis_81_3.Id1", MonsterId.Slime_Witch, 34, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_nicopolis_81_3.Id2", MonsterId.Slime_Wizard, 32, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_nicopolis_81_3.Id3", MonsterId.Popup_Cat, 55, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_nicopolis_81_3.Id4", MonsterId.Slime_Gemini, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_nicopolis_81_3.Id5", MonsterId.Rootcrystal_02, 20, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Slime_Witch Spawn Points
		AddSpawnPoint( "f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Spot(-1971.1366, 598.0828, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Spot(-1519.8954, 397.73737, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Spot(-1578.5693, 549.7347, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Spot(-1263.756, 501.14697, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Spot(-831.1698, 817.66077, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Spot(-505.16092, 899.87744, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Spot(-608.974, 654.2, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Spot(-142.82465, 471.9355, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Spot(-359.47446, 778.81396, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Spot(-361.23944, 359.90918, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Spot(-392.42297, 25.29551, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Spot(-527.4012, -16.635447, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Spot(-353.47702, -196.33969, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Spot(-571.0819, -231.73575, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Spot(-411.2452, -305.09418, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Spot(-629.21045, -540.11304, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Spot(-338.98203, -1043.8906, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Spot(-579.0369, -994.3273, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Spot(-474.07803, -1266.1876, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Spot(-215.65308, -1287.3074, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Spot(-646.3183, -1280.101, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Spot(-88.92554, -1114.8358, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Spot(-11.920393, -893.13306, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Spot(226.31772, -927.3075, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Spot(222.3934, -1174.2888, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Spot(536.57153, -1022.203, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Spot(599.5048, -818.5172, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Spot(448.8814, -1455.0264, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Spot(723.3165, -1391.455, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Spot(867.1707, -1624.4955, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Spot(478.55292, -1770.1885, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Spot(654.873, -1628.7479, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Spot(385.76965, -1401.9711, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Spot(-448.69263, -532.1901, 25));

		// Slime_Wizard Spawn Points
		AddSpawnPoint( "f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Spot(553.015, -1635.266, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Spot(328.72647, -1530.868, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Spot(620.7595, -1390.018, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Spot(789.35376, -1534.6836, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Spot(334.58093, -1104.8439, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Spot(483.65765, -817.6413, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Spot(-487.3844, -1171.2911, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Spot(-632.82086, -1017.5621, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Spot(-451.35248, -1411.91, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Spot(506.64697, -963.09845, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Spot(867.9132, -721.8814, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Spot(1781.3679, -967.4514, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Spot(1872.6228, -1244.5896, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Spot(1699.4031, -1210.54, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Spot(1691.553, -1695.6808, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Spot(1746.735, -1416.5459, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Spot(1619.6063, -891.84485, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Spot(1364.0302, -69.68201, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Spot(1294.3031, 220.66998, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Spot(1483.1399, -126.6689, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Spot(1732.5338, 210.68694, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Spot(2070.3325, 192.9354, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Spot(2088.1626, -45.290775, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Spot(2346.4243, 60.465813, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Spot(2269.2742, 237.99008, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Spot(2417.5334, 383.7021, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Spot(1152.7173, -84.662155, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Spot(1240.0627, 328.24417, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Spot(1588.1218, 174.99876, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Spot(1318.799, 582.08435, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Spot(1529.3912, 843.54944, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Spot(1409.5962, 1194.2252, 25));

		// Popup_Cat Spawn Points
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(-1688.9067, 532.4652, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(-1362.0793, 456.52, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(-1060.511, 509.68073, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(-523.8449, 777.80994, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(-702.55145, 573.6605, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(-305.5766, 489.54303, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(-527.3069, 489.50024, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(-540.6993, 74.25781, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(-570.5127, -133.00803, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(-478.8203, -71.05736, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(-615.06104, -429.01068, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(-480.45462, -460.0083, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(-589.4595, -677.2023, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(8.1856, 359.23053, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(429.14713, 108.56638, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(270.98135, 253.08989, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(402.8482, 606.1901, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(699.07544, 446.3829, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(635.1129, 230.00487, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(350.12802, 474.30295, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(687.34106, 934.0188, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(632.6706, 1149.3999, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(655.38983, 1451.8124, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(775.0167, 1192.0366, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(1120.3622, 682.0867, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(1238.3027, 992.2297, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(842.2351, 582.19836, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(1443.4185, 732.55566, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(1600.4575, 1166.0369, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(1465.7999, 140.62178, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(1414.0144, 23.179195, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(1154.4537, -20.535576, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(1648.0085, 95.433304, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(1276.6438, -281.23022, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(1466.4658, -567.1587, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(1467.7921, -744.88324, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(1339.6138, -880.01306, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(1162.4657, -742.22736, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(1173.6257, -581.703, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(1411.582, -711.0338, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(1958.7784, 1013.345, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(1910.5642, 1193.6771, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(2145.6035, 1074.8395, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(2347.237, 986.5797, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(2324.297, 1256.0474, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(2467.3704, 1155.4146, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(2785.0928, 1156.9363, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(2403.187, 1417.9889, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(2347.2422, 1635.1292, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(2019.1526, 105.1386, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(2140.4749, -54.35486, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(2312.0234, 207.95905, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(2194.4773, 135.85709, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(2139.5115, 325.09222, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Spot(992.3275, -857.87146, 25));

		// Slime_Gemini Spawn Points
		AddSpawnPoint( "f_nicopolis_81_3.Id4", "f_nicopolis_81_3", Spot(1406.6669, 1064.1616, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id4", "f_nicopolis_81_3", Spot(1361.7664, 779.70026, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id4", "f_nicopolis_81_3", Spot(1300.1141, 82.191864, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id4", "f_nicopolis_81_3", Spot(1608.4401, 14.523333, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id4", "f_nicopolis_81_3", Spot(558.1, 584.49536, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id4", "f_nicopolis_81_3", Spot(471.13474, 232.1267, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id4", "f_nicopolis_81_3", Spot(-255.68057, 601.79803, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id4", "f_nicopolis_81_3", Spot(710.1473, -858.588, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id4", "f_nicopolis_81_3", Spot(1135.662, -749.6238, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id4", "f_nicopolis_81_3", Spot(276.84842, -1051.1342, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id4", "f_nicopolis_81_3", Spot(1300.2783, -465.7467, 25));
		AddSpawnPoint( "f_nicopolis_81_3.Id4", "f_nicopolis_81_3", Spot(2227.999, 78.08858, 25));

		// Rootcrystal_02 Spawn Points
		AddSpawnPoint( "f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Spot(2403.9417, 1239.491, 100));
		AddSpawnPoint( "f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Spot(2013.563, 1094.721, 100));
		AddSpawnPoint( "f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Spot(1405.8688, 852.66473, 100));
		AddSpawnPoint( "f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Spot(1458.8029, 47.444572, 100));
		AddSpawnPoint( "f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Spot(2193.9883, 137.82352, 100));
		AddSpawnPoint( "f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Spot(1478.3263, -569.8364, 100));
		AddSpawnPoint( "f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Spot(1120.2832, -751.3687, 100));
		AddSpawnPoint( "f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Spot(1785.908, -1017.3656, 100));
		AddSpawnPoint( "f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Spot(1787.8611, -1370.6143, 100));
		AddSpawnPoint( "f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Spot(668.20544, -855.7025, 100));
		AddSpawnPoint( "f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Spot(239.31427, -1062.3446, 100));
		AddSpawnPoint( "f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Spot(536.1868, -1596.7014, 100));
		AddSpawnPoint( "f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Spot(-401.4644, -1256.8359, 100));
		AddSpawnPoint( "f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Spot(-426.7605, -474.7342, 100));
		AddSpawnPoint( "f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Spot(-459.03058, 101.48407, 100));
		AddSpawnPoint( "f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Spot(-350.51782, 600.7607, 100));
		AddSpawnPoint( "f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Spot(340.1239, 262.0037, 100));
		AddSpawnPoint( "f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Spot(638.1099, 609.61194, 100));
		AddSpawnPoint( "f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Spot(-1050.5547, 521.2828, 100));
		AddSpawnPoint( "f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Spot(-1635.2936, 566.6762, 100));

	}
}
