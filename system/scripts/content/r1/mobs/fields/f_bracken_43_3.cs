//--- Melia Script -----------------------------------------------------------
// f_bracken_43_3
//
//--- Description -----------------------------------------------------------
// Sets up the f_bracken_43_3 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FBracken433MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("f_bracken_43_3.Id1", MonsterId.Rootcrystal_03, 15, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_3.Id2", MonsterId.Vilkas_Soldier, 29, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_3.Id3", MonsterId.Rompelnuka, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_3.Id4", MonsterId.Vilkas_Archer, 22, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_3.Id5", MonsterId.Vilkas_Archer, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_3.Id6", MonsterId.Vilkas_Soldier, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_3.Id7", MonsterId.Vilkas_Soldier, 3, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_3.Id8", MonsterId.Vilkas_Archer, 2, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_3.Id9", MonsterId.Rompelnuka, 10, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Rootcrystal_03 Spawn Points
		AddSpawnPoint( "f_bracken_43_3.Id1", "f_bracken_43_3", Spot(345.93658, 1454.5079, 10));
		AddSpawnPoint( "f_bracken_43_3.Id1", "f_bracken_43_3", Spot(427.95438, 602.8066, 10));
		AddSpawnPoint( "f_bracken_43_3.Id1", "f_bracken_43_3", Spot(-138.91867, 295.75467, 10));
		AddSpawnPoint( "f_bracken_43_3.Id1", "f_bracken_43_3", Spot(-1094.6407, 1206.5382, 10));
		AddSpawnPoint( "f_bracken_43_3.Id1", "f_bracken_43_3", Spot(-790.28076, 80.2583, 10));
		AddSpawnPoint( "f_bracken_43_3.Id1", "f_bracken_43_3", Spot(-1253.125, -767.896, 10));
		AddSpawnPoint( "f_bracken_43_3.Id1", "f_bracken_43_3", Spot(7.246296, -182.56474, 10));
		AddSpawnPoint( "f_bracken_43_3.Id1", "f_bracken_43_3", Spot(224.14871, -969.31683, 10));
		AddSpawnPoint( "f_bracken_43_3.Id1", "f_bracken_43_3", Spot(561.2699, -141.80106, 10));
		AddSpawnPoint( "f_bracken_43_3.Id1", "f_bracken_43_3", Spot(1157.3309, -195.60178, 10));
		AddSpawnPoint( "f_bracken_43_3.Id1", "f_bracken_43_3", Spot(2480.6064, -451.66537, 10));
		AddSpawnPoint( "f_bracken_43_3.Id1", "f_bracken_43_3", Spot(1588.3813, 1242.676, 10));
		AddSpawnPoint( "f_bracken_43_3.Id1", "f_bracken_43_3", Spot(2278.574, 1685.26, 10));
		AddSpawnPoint( "f_bracken_43_3.Id1", "f_bracken_43_3", Spot(1024.3014, 774.78705, 10));
		AddSpawnPoint( "f_bracken_43_3.Id1", "f_bracken_43_3", Spot(1674.568, -468.89752, 10));

		// Vilkas_Soldier Spawn Points
		AddSpawnPoint( "f_bracken_43_3.Id2", "f_bracken_43_3", Spot(-1500.984, -760.4247, 40));
		AddSpawnPoint( "f_bracken_43_3.Id2", "f_bracken_43_3", Spot(-1353.0442, -926.64197, 40));
		AddSpawnPoint( "f_bracken_43_3.Id2", "f_bracken_43_3", Spot(-1139.4294, 1312.338, 40));
		AddSpawnPoint( "f_bracken_43_3.Id2", "f_bracken_43_3", Spot(-79.08363, 507.7389, 40));
		AddSpawnPoint( "f_bracken_43_3.Id2", "f_bracken_43_3", Spot(-127.91523, 237.1161, 40));
		AddSpawnPoint( "f_bracken_43_3.Id2", "f_bracken_43_3", Spot(-132.87445, -50.86667, 40));
		AddSpawnPoint( "f_bracken_43_3.Id2", "f_bracken_43_3", Spot(-936.28284, 1456.3945, 40));
		AddSpawnPoint( "f_bracken_43_3.Id2", "f_bracken_43_3", Spot(-1295.6589, 1063.5599, 40));
		AddSpawnPoint( "f_bracken_43_3.Id2", "f_bracken_43_3", Spot(-1375.27, 1428.4183, 40));
		AddSpawnPoint( "f_bracken_43_3.Id2", "f_bracken_43_3", Spot(-962.0408, 988.96106, 40));
		AddSpawnPoint( "f_bracken_43_3.Id2", "f_bracken_43_3", Spot(-1027.9778, 1137.8701, 40));
		AddSpawnPoint( "f_bracken_43_3.Id2", "f_bracken_43_3", Spot(-929.847, 33.921764, 40));
		AddSpawnPoint( "f_bracken_43_3.Id2", "f_bracken_43_3", Spot(-680.70435, 108.96506, 40));
		AddSpawnPoint( "f_bracken_43_3.Id2", "f_bracken_43_3", Spot(219.17683, -1173.3275, 40));
		AddSpawnPoint( "f_bracken_43_3.Id2", "f_bracken_43_3", Spot(179.62975, -918.8893, 40));
		AddSpawnPoint( "f_bracken_43_3.Id2", "f_bracken_43_3", Spot(342.49353, -1045.9934, 40));
		AddSpawnPoint( "f_bracken_43_3.Id2", "f_bracken_43_3", Spot(199.81125, -251.31265, 40));
		AddSpawnPoint( "f_bracken_43_3.Id2", "f_bracken_43_3", Spot(536.25366, -205.87411, 40));
		AddSpawnPoint( "f_bracken_43_3.Id2", "f_bracken_43_3", Spot(716.80286, -11.639378, 40));
		AddSpawnPoint( "f_bracken_43_3.Id2", "f_bracken_43_3", Spot(617.7838, 366.4995, 40));
		AddSpawnPoint( "f_bracken_43_3.Id2", "f_bracken_43_3", Spot(359.43872, 672.9359, 40));
		AddSpawnPoint( "f_bracken_43_3.Id2", "f_bracken_43_3", Spot(1327.4552, -356.95123, 40));
		AddSpawnPoint( "f_bracken_43_3.Id2", "f_bracken_43_3", Spot(2318.2073, -496.21527, 40));
		AddSpawnPoint( "f_bracken_43_3.Id2", "f_bracken_43_3", Spot(1570.3762, 1257.6687, 40));
		AddSpawnPoint( "f_bracken_43_3.Id2", "f_bracken_43_3", Spot(2108.67, 1826.6284, 40));
		AddSpawnPoint( "f_bracken_43_3.Id2", "f_bracken_43_3", Spot(2298.7268, 1567.5446, 40));
		AddSpawnPoint( "f_bracken_43_3.Id2", "f_bracken_43_3", Spot(427.12576, 1435.2981, 40));
		AddSpawnPoint( "f_bracken_43_3.Id2", "f_bracken_43_3", Spot(312.65186, 1482.6167, 40));
		AddSpawnPoint( "f_bracken_43_3.Id2", "f_bracken_43_3", Spot(308.18112, 1326.2708, 40));
		AddSpawnPoint( "f_bracken_43_3.Id2", "f_bracken_43_3", Spot(1923.9761, -422.03192, 40));
		AddSpawnPoint( "f_bracken_43_3.Id2", "f_bracken_43_3", Spot(1098.8108, -109.55153, 40));
		AddSpawnPoint( "f_bracken_43_3.Id2", "f_bracken_43_3", Spot(1691.8086, 1326.7085, 40));
		AddSpawnPoint( "f_bracken_43_3.Id2", "f_bracken_43_3", Spot(1398.842, 1108.5156, 40));
		AddSpawnPoint( "f_bracken_43_3.Id2", "f_bracken_43_3", Spot(2214.5007, 1548.317, 40));
		AddSpawnPoint( "f_bracken_43_3.Id2", "f_bracken_43_3", Spot(2398.7656, 1791.7606, 40));
		AddSpawnPoint( "f_bracken_43_3.Id2", "f_bracken_43_3", Spot(2086.8691, 1632.43, 40));
		AddSpawnPoint( "f_bracken_43_3.Id2", "f_bracken_43_3", Spot(1961.0688, 1376.2218, 40));
		AddSpawnPoint( "f_bracken_43_3.Id2", "f_bracken_43_3", Spot(192.66074, 1556.5334, 40));

		// Rompelnuka Spawn Points
		AddSpawnPoint( "f_bracken_43_3.Id3", "f_bracken_43_3", Spot(-1014.3522, -19.98071, 40));
		AddSpawnPoint( "f_bracken_43_3.Id3", "f_bracken_43_3", Spot(-1013.9124, 157.91188, 40));
		AddSpawnPoint( "f_bracken_43_3.Id3", "f_bracken_43_3", Spot(-756.22284, 286.76706, 40));
		AddSpawnPoint( "f_bracken_43_3.Id3", "f_bracken_43_3", Spot(-636.3301, 193.99355, 40));
		AddSpawnPoint( "f_bracken_43_3.Id3", "f_bracken_43_3", Spot(-692.1882, -23.929428, 40));
		AddSpawnPoint( "f_bracken_43_3.Id3", "f_bracken_43_3", Spot(-791.26337, 81.22377, 40));
		AddSpawnPoint( "f_bracken_43_3.Id3", "f_bracken_43_3", Spot(-821.4815, 180.20728, 40));
		AddSpawnPoint( "f_bracken_43_3.Id3", "f_bracken_43_3", Spot(-942.32837, 15.893005, 40));
		AddSpawnPoint( "f_bracken_43_3.Id3", "f_bracken_43_3", Spot(-1100.8684, 0.907135, 40));
		AddSpawnPoint( "f_bracken_43_3.Id3", "f_bracken_43_3", Spot(-775.6436, -104.63115, 40));
		AddSpawnPoint( "f_bracken_43_3.Id3", "f_bracken_43_3", Spot(2057.057, 1640.9999, 40));
		AddSpawnPoint( "f_bracken_43_3.Id3", "f_bracken_43_3", Spot(2075.615, 1778.392, 40));
		AddSpawnPoint( "f_bracken_43_3.Id3", "f_bracken_43_3", Spot(2268.7766, 1831.2316, 40));
		AddSpawnPoint( "f_bracken_43_3.Id3", "f_bracken_43_3", Spot(2252.1992, 1712.4458, 40));
		AddSpawnPoint( "f_bracken_43_3.Id3", "f_bracken_43_3", Spot(2305.9631, 1582.8308, 40));
		AddSpawnPoint( "f_bracken_43_3.Id3", "f_bracken_43_3", Spot(224.827, 1395.2671, 40));
		AddSpawnPoint( "f_bracken_43_3.Id3", "f_bracken_43_3", Spot(220.90515, 1573.9917, 40));
		AddSpawnPoint( "f_bracken_43_3.Id3", "f_bracken_43_3", Spot(406.534, 1668.604, 40));
		AddSpawnPoint( "f_bracken_43_3.Id3", "f_bracken_43_3", Spot(447.1927, 1483.8386, 40));
		AddSpawnPoint( "f_bracken_43_3.Id3", "f_bracken_43_3", Spot(267.39627, 1008.2238, 40));
		AddSpawnPoint( "f_bracken_43_3.Id3", "f_bracken_43_3", Spot(148.77484, 1648.6964, 40));
		AddSpawnPoint( "f_bracken_43_3.Id3", "f_bracken_43_3", Spot(390.58157, 1467.3826, 40));
		AddSpawnPoint( "f_bracken_43_3.Id3", "f_bracken_43_3", Spot(-1595.9474, -833.3833, 40));
		AddSpawnPoint( "f_bracken_43_3.Id3", "f_bracken_43_3", Spot(-1428.7749, -987.3511, 40));
		AddSpawnPoint( "f_bracken_43_3.Id3", "f_bracken_43_3", Spot(-1267.5491, -750.8969, 40));
		AddSpawnPoint( "f_bracken_43_3.Id3", "f_bracken_43_3", Spot(-1369.4325, -627.76056, 40));
		AddSpawnPoint( "f_bracken_43_3.Id3", "f_bracken_43_3", Spot(-1530.4319, -674.2015, 40));
		AddSpawnPoint( "f_bracken_43_3.Id3", "f_bracken_43_3", Spot(-1287.0654, -906.32837, 40));

		// Vilkas_Archer Spawn Points
		AddSpawnPoint( "f_bracken_43_3.Id4", "f_bracken_43_3", Spot(246.71977, -1139.3782, 40));
		AddSpawnPoint( "f_bracken_43_3.Id4", "f_bracken_43_3", Spot(157.09491, -997.868, 40));
		AddSpawnPoint( "f_bracken_43_3.Id4", "f_bracken_43_3", Spot(-1384.6816, -799.27423, 40));
		AddSpawnPoint( "f_bracken_43_3.Id4", "f_bracken_43_3", Spot(-1554.5338, -716.1522, 40));
		AddSpawnPoint( "f_bracken_43_3.Id4", "f_bracken_43_3", Spot(-1375.8488, -558.35156, 40));
		AddSpawnPoint( "f_bracken_43_3.Id4", "f_bracken_43_3", Spot(80.03982, -213.75139, 40));
		AddSpawnPoint( "f_bracken_43_3.Id4", "f_bracken_43_3", Spot(471.80164, -184.08105, 40));
		AddSpawnPoint( "f_bracken_43_3.Id4", "f_bracken_43_3", Spot(787.07007, -10.543436, 40));
		AddSpawnPoint( "f_bracken_43_3.Id4", "f_bracken_43_3", Spot(641.9622, 66.7385, 40));
		AddSpawnPoint( "f_bracken_43_3.Id4", "f_bracken_43_3", Spot(1334.3472, -376.53036, 40));
		AddSpawnPoint( "f_bracken_43_3.Id4", "f_bracken_43_3", Spot(1515.5978, -450.85373, 40));
		AddSpawnPoint( "f_bracken_43_3.Id4", "f_bracken_43_3", Spot(-1448.3258, -947.5208, 40));
		AddSpawnPoint( "f_bracken_43_3.Id4", "f_bracken_43_3", Spot(2124.6145, -448.1626, 40));
		AddSpawnPoint( "f_bracken_43_3.Id4", "f_bracken_43_3", Spot(2433.7153, -456.64935, 40));
		AddSpawnPoint( "f_bracken_43_3.Id4", "f_bracken_43_3", Spot(660.46136, 510.6432, 40));
		AddSpawnPoint( "f_bracken_43_3.Id4", "f_bracken_43_3", Spot(794.2365, 295.33643, 40));
		AddSpawnPoint( "f_bracken_43_3.Id4", "f_bracken_43_3", Spot(1530.6266, 1305.4371, 40));
		AddSpawnPoint( "f_bracken_43_3.Id4", "f_bracken_43_3", Spot(1693.6678, 1267.0071, 40));
		AddSpawnPoint( "f_bracken_43_3.Id4", "f_bracken_43_3", Spot(2193.731, 1584.6069, 40));
		AddSpawnPoint( "f_bracken_43_3.Id4", "f_bracken_43_3", Spot(2396.1892, 1606.2883, 40));
		AddSpawnPoint( "f_bracken_43_3.Id4", "f_bracken_43_3", Spot(2075.5645, 1787.2463, 40));
		AddSpawnPoint( "f_bracken_43_3.Id4", "f_bracken_43_3", Spot(-191.21187, -49.313923, 40));
		AddSpawnPoint( "f_bracken_43_3.Id4", "f_bracken_43_3", Spot(288.40936, -913.2773, 40));
		AddSpawnPoint( "f_bracken_43_3.Id4", "f_bracken_43_3", Spot(248.57823, -807.7335, 40));
		AddSpawnPoint( "f_bracken_43_3.Id5", "f_bracken_43_3", Spot(-1315.1577, 1071.8909, 40));
		AddSpawnPoint( "f_bracken_43_3.Id5", "f_bracken_43_3", Spot(-1283.7767, 1279.6101, 40));
		AddSpawnPoint( "f_bracken_43_3.Id5", "f_bracken_43_3", Spot(-1026.1421, 1465.001, 40));
		AddSpawnPoint( "f_bracken_43_3.Id5", "f_bracken_43_3", Spot(-1047.4331, 1177.1709, 40));
		AddSpawnPoint( "f_bracken_43_3.Id5", "f_bracken_43_3", Spot(-1115.7853, 1015.8062, 40));
		AddSpawnPoint( "f_bracken_43_3.Id5", "f_bracken_43_3", Spot(-833.22736, 1247.6388, 40));
		AddSpawnPoint( "f_bracken_43_3.Id5", "f_bracken_43_3", Spot(-1405.4589, 1457.0045, 40));
		AddSpawnPoint( "f_bracken_43_3.Id5", "f_bracken_43_3", Spot(-934.1493, 926.515, 40));
		AddSpawnPoint( "f_bracken_43_3.Id5", "f_bracken_43_3", Spot(2420.5967, -383.16064, 40));
		AddSpawnPoint( "f_bracken_43_3.Id5", "f_bracken_43_3", Spot(2232.6926, -608.1252, 40));
		AddSpawnPoint( "f_bracken_43_3.Id5", "f_bracken_43_3", Spot(1979.5267, -471.84143, 40));
		AddSpawnPoint( "f_bracken_43_3.Id5", "f_bracken_43_3", Spot(1388.3691, -402.80164, 40));
		AddSpawnPoint( "f_bracken_43_3.Id5", "f_bracken_43_3", Spot(1101.6344, -192.4277, 40));
		AddSpawnPoint( "f_bracken_43_3.Id5", "f_bracken_43_3", Spot(250.67387, 895.3634, 40));
		AddSpawnPoint( "f_bracken_43_3.Id5", "f_bracken_43_3", Spot(257.06165, 1102.8623, 40));
		AddSpawnPoint( "f_bracken_43_3.Id5", "f_bracken_43_3", Spot(957.2342, 692.9821, 40));
		AddSpawnPoint( "f_bracken_43_3.Id5", "f_bracken_43_3", Spot(1155.5952, 908.4682, 40));
		AddSpawnPoint( "f_bracken_43_3.Id5", "f_bracken_43_3", Spot(1309.6282, 1059.3124, 40));
		AddSpawnPoint( "f_bracken_43_3.Id5", "f_bracken_43_3", Spot(1384.4901, 1059.6556, 40));

		// Vilkas_Soldier Spawn Points
		AddSpawnPoint( "f_bracken_43_3.Id6", "f_bracken_43_3", Spot(530.7562, -160.11998, 9999));
		AddSpawnPoint( "f_bracken_43_3.Id7", "f_bracken_43_3", Spot(-919.29144, 37.484814, 20));
		AddSpawnPoint( "f_bracken_43_3.Id7", "f_bracken_43_3", Spot(-739.2813, 66.07744, 20));
		AddSpawnPoint( "f_bracken_43_3.Id7", "f_bracken_43_3", Spot(-633.3879, 81.42477, 20));

		// Vilkas_Archer Spawn Points
		AddSpawnPoint( "f_bracken_43_3.Id8", "f_bracken_43_3", Spot(-668.66833, -51.911728, 20));
		AddSpawnPoint( "f_bracken_43_3.Id8", "f_bracken_43_3", Spot(-931.9867, 114.84276, 20));

		// Rompelnuka Spawn Points
		AddSpawnPoint( "f_bracken_43_3.Id9", "f_bracken_43_3", Spot(2232.5251, -480.01294, 20));
		AddSpawnPoint( "f_bracken_43_3.Id9", "f_bracken_43_3", Spot(2352.6174, -584.5909, 20));
		AddSpawnPoint( "f_bracken_43_3.Id9", "f_bracken_43_3", Spot(2450.2393, -357.24158, 20));
		AddSpawnPoint( "f_bracken_43_3.Id9", "f_bracken_43_3", Spot(2521.8335, -465.19055, 20));
		AddSpawnPoint( "f_bracken_43_3.Id9", "f_bracken_43_3", Spot(2077.7048, -484.62225, 20));
		AddSpawnPoint( "f_bracken_43_3.Id9", "f_bracken_43_3", Spot(2541.123, -216.57684, 20));
		AddSpawnPoint( "f_bracken_43_3.Id9", "f_bracken_43_3", Spot(2182.928, -578.24066, 20));
		AddSpawnPoint( "f_bracken_43_3.Id9", "f_bracken_43_3", Spot(2280.993, -426.54022, 20));
		AddSpawnPoint( "f_bracken_43_3.Id9", "f_bracken_43_3", Spot(2398.511, -531.5355, 20));
		AddSpawnPoint( "f_bracken_43_3.Id9", "f_bracken_43_3", Spot(2136.7896, -415.76074, 20));

	}
}
