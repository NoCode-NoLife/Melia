//--- Melia Script -----------------------------------------------------------
// f_bracken_43_3
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Ziburynas Forest' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FBracken433MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("f_bracken_43_3.Id1", MonsterId.Vilkas_Soldier, 22, 29, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_3.Id2", MonsterId.Vilkas_Archer, 17, 22, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_3.Id3", MonsterId.Rootcrystal_03, 12, 15, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_3.Id4", MonsterId.Rompelnuka, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_3.Id5", MonsterId.Vilkas_Archer, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_3.Id6", MonsterId.Vilkas_Soldier, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_3.Id7", MonsterId.Vilkas_Soldier, 3, 3, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_3.Id8", MonsterId.Vilkas_Archer, 2, 2, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_3.Id9", MonsterId.Rompelnuka, 8, 10, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Vilkas_Soldier' GenType 20 Spawn Points
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(-1500.984, -760.4247, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(-1353.0442, -926.64197, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(-1139.4294, 1312.338, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(-79.08363, 507.7389, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(-127.91523, 237.1161, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(-132.87445, -50.86667, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(-936.28284, 1456.3945, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(-1295.6589, 1063.5599, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(-1375.27, 1428.4183, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(-962.0408, 988.96106, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(-1027.9778, 1137.8701, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(-929.847, 33.921764, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(-680.70435, 108.96506, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(219.17683, -1173.3275, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(179.62975, -918.8893, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(342.49353, -1045.9934, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(199.81125, -251.31265, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(536.25366, -205.87411, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(716.80286, -11.639378, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(617.7838, 366.4995, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(359.43872, 672.9359, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(1327.4552, -356.95123, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(2318.2073, -496.21527, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(1570.3762, 1257.6687, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(2108.67, 1826.6284, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(2298.7268, 1567.5446, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(427.12576, 1435.2981, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(312.65186, 1482.6167, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(308.18112, 1326.2708, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(1923.9761, -422.03192, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(1098.8108, -109.55153, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(1691.8086, 1326.7085, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(1398.842, 1108.5156, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(2214.5007, 1548.317, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(2398.7656, 1791.7606, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(2086.8691, 1632.43, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(1961.0688, 1376.2218, 40));
		AddSpawnPoint("f_bracken_43_3.Id1", "f_bracken_43_3", Rectangle(192.66074, 1556.5334, 40));

		// 'Vilkas_Archer' GenType 21 Spawn Points
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(246.71977, -1139.3782, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(157.09491, -997.868, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(-1384.6816, -799.27423, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(-1554.5338, -716.1522, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(-1375.8488, -558.35156, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(80.03982, -213.75139, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(471.80164, -184.08105, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(787.07007, -10.543436, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(641.9622, 66.7385, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(1334.3472, -376.53036, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(1515.5978, -450.85373, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(-1448.3258, -947.5208, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(2124.6145, -448.1626, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(2433.7153, -456.64935, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(660.46136, 510.6432, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(794.2365, 295.33643, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(1530.6266, 1305.4371, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(1693.6678, 1267.0071, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(2193.731, 1584.6069, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(2396.1892, 1606.2883, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(2075.5645, 1787.2463, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(-191.21187, -49.313923, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(288.40936, -913.2773, 40));
		AddSpawnPoint("f_bracken_43_3.Id2", "f_bracken_43_3", Rectangle(248.57823, -807.7335, 40));

		// 'Rootcrystal_03' GenType 22 Spawn Points
		AddSpawnPoint("f_bracken_43_3.Id3", "f_bracken_43_3", Rectangle(345.93658, 1454.5079, 10));
		AddSpawnPoint("f_bracken_43_3.Id3", "f_bracken_43_3", Rectangle(427.95438, 602.8066, 10));
		AddSpawnPoint("f_bracken_43_3.Id3", "f_bracken_43_3", Rectangle(-138.91867, 295.75467, 10));
		AddSpawnPoint("f_bracken_43_3.Id3", "f_bracken_43_3", Rectangle(-1094.6407, 1206.5382, 10));
		AddSpawnPoint("f_bracken_43_3.Id3", "f_bracken_43_3", Rectangle(-790.28076, 80.2583, 10));
		AddSpawnPoint("f_bracken_43_3.Id3", "f_bracken_43_3", Rectangle(-1253.125, -767.896, 10));
		AddSpawnPoint("f_bracken_43_3.Id3", "f_bracken_43_3", Rectangle(7.246296, -182.56474, 10));
		AddSpawnPoint("f_bracken_43_3.Id3", "f_bracken_43_3", Rectangle(224.14871, -969.31683, 10));
		AddSpawnPoint("f_bracken_43_3.Id3", "f_bracken_43_3", Rectangle(561.2699, -141.80106, 10));
		AddSpawnPoint("f_bracken_43_3.Id3", "f_bracken_43_3", Rectangle(1157.3309, -195.60178, 10));
		AddSpawnPoint("f_bracken_43_3.Id3", "f_bracken_43_3", Rectangle(2480.6064, -451.66537, 10));
		AddSpawnPoint("f_bracken_43_3.Id3", "f_bracken_43_3", Rectangle(1588.3813, 1242.676, 10));
		AddSpawnPoint("f_bracken_43_3.Id3", "f_bracken_43_3", Rectangle(2278.574, 1685.26, 10));
		AddSpawnPoint("f_bracken_43_3.Id3", "f_bracken_43_3", Rectangle(1024.3014, 774.78705, 10));
		AddSpawnPoint("f_bracken_43_3.Id3", "f_bracken_43_3", Rectangle(1674.568, -468.89752, 10));

		// 'Rompelnuka' GenType 23 Spawn Points
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(-1014.3522, -19.98071, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(-1013.9124, 157.91188, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(-756.22284, 286.76706, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(-636.3301, 193.99355, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(-692.1882, -23.929428, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(-791.26337, 81.22377, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(-821.4815, 180.20728, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(-942.32837, 15.893005, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(-1100.8684, 0.907135, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(-775.6436, -104.63115, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(2057.057, 1640.9999, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(2075.615, 1778.392, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(2268.7766, 1831.2316, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(2252.1992, 1712.4458, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(2305.9631, 1582.8308, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(224.827, 1395.2671, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(220.90515, 1573.9917, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(406.534, 1668.604, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(447.1927, 1483.8386, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(267.39627, 1008.2238, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(148.77484, 1648.6964, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(390.58157, 1467.3826, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(-1595.9474, -833.3833, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(-1428.7749, -987.3511, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(-1267.5491, -750.8969, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(-1369.4325, -627.76056, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(-1530.4319, -674.2015, 40));
		AddSpawnPoint("f_bracken_43_3.Id4", "f_bracken_43_3", Rectangle(-1287.0654, -906.32837, 40));

		// 'Vilkas_Archer' GenType 39 Spawn Points
		AddSpawnPoint("f_bracken_43_3.Id5", "f_bracken_43_3", Rectangle(-1315.1577, 1071.8909, 40));
		AddSpawnPoint("f_bracken_43_3.Id5", "f_bracken_43_3", Rectangle(-1283.7767, 1279.6101, 40));
		AddSpawnPoint("f_bracken_43_3.Id5", "f_bracken_43_3", Rectangle(-1026.1421, 1465.001, 40));
		AddSpawnPoint("f_bracken_43_3.Id5", "f_bracken_43_3", Rectangle(-1047.4331, 1177.1709, 40));
		AddSpawnPoint("f_bracken_43_3.Id5", "f_bracken_43_3", Rectangle(-1115.7853, 1015.8062, 40));
		AddSpawnPoint("f_bracken_43_3.Id5", "f_bracken_43_3", Rectangle(-833.22736, 1247.6388, 40));
		AddSpawnPoint("f_bracken_43_3.Id5", "f_bracken_43_3", Rectangle(-1405.4589, 1457.0045, 40));
		AddSpawnPoint("f_bracken_43_3.Id5", "f_bracken_43_3", Rectangle(-934.1493, 926.515, 40));
		AddSpawnPoint("f_bracken_43_3.Id5", "f_bracken_43_3", Rectangle(2420.5967, -383.16064, 40));
		AddSpawnPoint("f_bracken_43_3.Id5", "f_bracken_43_3", Rectangle(2232.6926, -608.1252, 40));
		AddSpawnPoint("f_bracken_43_3.Id5", "f_bracken_43_3", Rectangle(1979.5267, -471.84143, 40));
		AddSpawnPoint("f_bracken_43_3.Id5", "f_bracken_43_3", Rectangle(1388.3691, -402.80164, 40));
		AddSpawnPoint("f_bracken_43_3.Id5", "f_bracken_43_3", Rectangle(1101.6344, -192.4277, 40));
		AddSpawnPoint("f_bracken_43_3.Id5", "f_bracken_43_3", Rectangle(250.67387, 895.3634, 40));
		AddSpawnPoint("f_bracken_43_3.Id5", "f_bracken_43_3", Rectangle(257.06165, 1102.8623, 40));
		AddSpawnPoint("f_bracken_43_3.Id5", "f_bracken_43_3", Rectangle(957.2342, 692.9821, 40));
		AddSpawnPoint("f_bracken_43_3.Id5", "f_bracken_43_3", Rectangle(1155.5952, 908.4682, 40));
		AddSpawnPoint("f_bracken_43_3.Id5", "f_bracken_43_3", Rectangle(1309.6282, 1059.3124, 40));
		AddSpawnPoint("f_bracken_43_3.Id5", "f_bracken_43_3", Rectangle(1384.4901, 1059.6556, 40));

		// 'Vilkas_Soldier' GenType 40 Spawn Points
		AddSpawnPoint("f_bracken_43_3.Id6", "f_bracken_43_3", Rectangle(530.7562, -160.11998, 9999));

		// 'Vilkas_Soldier' GenType 41 Spawn Points
		AddSpawnPoint("f_bracken_43_3.Id7", "f_bracken_43_3", Rectangle(-919.29144, 37.484814, 20));
		AddSpawnPoint("f_bracken_43_3.Id7", "f_bracken_43_3", Rectangle(-739.2813, 66.07744, 20));
		AddSpawnPoint("f_bracken_43_3.Id7", "f_bracken_43_3", Rectangle(-633.3879, 81.42477, 20));

		// 'Vilkas_Archer' GenType 42 Spawn Points
		AddSpawnPoint("f_bracken_43_3.Id8", "f_bracken_43_3", Rectangle(-668.66833, -51.911728, 20));
		AddSpawnPoint("f_bracken_43_3.Id8", "f_bracken_43_3", Rectangle(-931.9867, 114.84276, 20));

		// 'Rompelnuka' GenType 43 Spawn Points
		AddSpawnPoint("f_bracken_43_3.Id9", "f_bracken_43_3", Rectangle(2232.5251, -480.01294, 20));
		AddSpawnPoint("f_bracken_43_3.Id9", "f_bracken_43_3", Rectangle(2352.6174, -584.5909, 20));
		AddSpawnPoint("f_bracken_43_3.Id9", "f_bracken_43_3", Rectangle(2450.2393, -357.24158, 20));
		AddSpawnPoint("f_bracken_43_3.Id9", "f_bracken_43_3", Rectangle(2521.8335, -465.19055, 20));
		AddSpawnPoint("f_bracken_43_3.Id9", "f_bracken_43_3", Rectangle(2077.7048, -484.62225, 20));
		AddSpawnPoint("f_bracken_43_3.Id9", "f_bracken_43_3", Rectangle(2541.123, -216.57684, 20));
		AddSpawnPoint("f_bracken_43_3.Id9", "f_bracken_43_3", Rectangle(2182.928, -578.24066, 20));
		AddSpawnPoint("f_bracken_43_3.Id9", "f_bracken_43_3", Rectangle(2280.993, -426.54022, 20));
		AddSpawnPoint("f_bracken_43_3.Id9", "f_bracken_43_3", Rectangle(2398.511, -531.5355, 20));
		AddSpawnPoint("f_bracken_43_3.Id9", "f_bracken_43_3", Rectangle(2136.7896, -415.76074, 20));
	}
}
