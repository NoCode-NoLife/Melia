//--- Melia Script -----------------------------------------------------------
// d_dcapital_108
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Pradzia Temple' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DDcapital108MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_dcapital_108", MonsterId.Raganosis_Ram, Properties("MHP", 862065, "MINPATK", 11586, "MAXPATK", 14142, "MINMATK", 11586, "MAXMATK", 14142, "DEF", 326330, "MDEF", 326330));
		AddPropertyOverrides("d_dcapital_108", MonsterId.Raganosis_Guardian, Properties("MHP", 872854, "MINPATK", 11725, "MAXPATK", 14313, "MINMATK", 11725, "MAXMATK", 14313, "DEF", 336922, "MDEF", 336922));
		AddPropertyOverrides("d_dcapital_108", MonsterId.Raganosis_Seeker, Properties("MHP", 884585, "MINPATK", 11876, "MAXPATK", 14498, "MINMATK", 11876, "MAXMATK", 14498, "DEF", 348437, "MDEF", 348437));
		AddPropertyOverrides("d_dcapital_108", MonsterId.Boss_RaganosisCommander, Properties("MHP", 4790971, "MINPATK", 31779, "MAXPATK", 38800, "MINMATK", 31779, "MAXMATK", 38800, "DEF", 952531, "MDEF", 952531));
		AddPropertyOverrides("d_dcapital_108", MonsterId.Legend_Boss_Giltine_Q1, Properties("MHP", 7913123, "MINPATK", 28409, "MAXPATK", 34688, "MINMATK", 28409, "MAXMATK", 34688, "DEF", 1305180, "MDEF", 1305180));

		// Monster Spawners ---------------------------------

		AddSpawner("d_dcapital_108.Id1", MonsterId.Raganosis_Ram, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_dcapital_108.Id2", MonsterId.Raganosis_Guardian, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_dcapital_108.Id3", MonsterId.Raganosis_Seeker, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_dcapital_108.Id4", MonsterId.Raganosis_Ram, 2, 2, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_dcapital_108.Id5", MonsterId.Raganosis_Ram, 7, 9, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_dcapital_108.Id6", MonsterId.Raganosis_Guardian, 18, 24, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_dcapital_108.Id7", MonsterId.Raganosis_Seeker, 20, 26, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_dcapital_108.Id8", MonsterId.Rootcrystal_02, 19, 25, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Raganosis_Ram' GenType 41 Spawn Points
		AddSpawnPoint("d_dcapital_108.Id1", "d_dcapital_108", Rectangle(2351.8965, 478.5188, 70));
		AddSpawnPoint("d_dcapital_108.Id1", "d_dcapital_108", Rectangle(2119.8198, 136.7554, 70));
		AddSpawnPoint("d_dcapital_108.Id1", "d_dcapital_108", Rectangle(1585.1422, -762.9775, 70));
		AddSpawnPoint("d_dcapital_108.Id1", "d_dcapital_108", Rectangle(-1515.8936, 190.70773, 70));
		AddSpawnPoint("d_dcapital_108.Id1", "d_dcapital_108", Rectangle(-1262.2233, 460.55, 70));
		AddSpawnPoint("d_dcapital_108.Id1", "d_dcapital_108", Rectangle(-353.46637, -923.0284, 70));
		AddSpawnPoint("d_dcapital_108.Id1", "d_dcapital_108", Rectangle(-645.3163, -491.90277, 70));
		AddSpawnPoint("d_dcapital_108.Id1", "d_dcapital_108", Rectangle(1653.9376, -358.35413, 70));
		AddSpawnPoint("d_dcapital_108.Id1", "d_dcapital_108", Rectangle(-465.8307, -671.5528, 70));

		// 'Raganosis_Guardian' GenType 42 Spawn Points
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(2384.426, 420.1546, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(2280.1497, 206.01773, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(2095.9788, 227.91971, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(1428.7308, -697.0071, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(1595.6252, -641.53436, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(1470.3568, -792.44745, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(-568.2544, -695.7127, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(-429.69318, -590.19885, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(-481.614, -750.70795, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(-381.76376, -665.8106, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(-1415.5085, 224.66605, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(-1185.5078, 467.15393, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(-1177.348, -42.833878, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(2086.006, 4.781807, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(-988.7815, -354.59897, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(-1278.78, 167.15442, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(-1184.5181, 274.69113, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(1913.1101, -357.8818, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(2395.3848, 307.64734, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(2120.453, -217.1689, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(1345.5647, -619.7691, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(-654.2561, -572.7916, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(-1157.3936, -319.4986, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(-1298.5332, 281.40784, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(-1357.1185, 455.9248, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(1544.2057, -589.54614, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(2202.9954, 271.22144, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(2255.7627, 377.05203, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(-390.43713, -833.00037, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(-327.53052, -774.0956, 25));
		AddSpawnPoint("d_dcapital_108.Id2", "d_dcapital_108", Rectangle(-482.51633, -515.3401, 25));

		// 'Raganosis_Seeker' GenType 43 Spawn Points
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(2286.0415, 435.8952, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(1572.674, -515.2741, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(1321.2157, -762.5934, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(-636.67554, -771.9603, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(-378.87506, -519.5603, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(-1194.5012, -377.32983, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(-1427.513, 329.7516, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(2155.4, 415.36627, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(-406.59448, -749.18146, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(-679.27484, -334.56668, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(-1298.608, 216.04599, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(1769.1913, -386.66037, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(2112.9705, -129.4248, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(-559.3819, -531.74164, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(-1353.5704, 458.2198, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(-1235.8287, 356.49127, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(2331.4756, 187.08893, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(2405.9924, 234.64423, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(2027.3557, -373.9967, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(1385.0643, -528.17957, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(1642.0437, -736.9049, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(1498.8535, -651.5994, 25));
		AddSpawnPoint("d_dcapital_108.Id3", "d_dcapital_108", Rectangle(-665.49713, -683.7485, 25));

		// 'Raganosis_Ram' GenType 44 Spawn Points
		AddSpawnPoint("d_dcapital_108.Id4", "d_dcapital_108", Rectangle(2113.4763, -351.6513, 40));
		AddSpawnPoint("d_dcapital_108.Id4", "d_dcapital_108", Rectangle(-1155.7175, -174.47638, 40));
		AddSpawnPoint("d_dcapital_108.Id4", "d_dcapital_108", Rectangle(-837.9865, -348.47385, 40));
		AddSpawnPoint("d_dcapital_108.Id4", "d_dcapital_108", Rectangle(1297.2229, -908.0183, 40));

		// 'Raganosis_Ram' GenType 61 Spawn Points
		AddSpawnPoint("d_dcapital_108.Id5", "d_dcapital_108", Rectangle(83.40954, 2282.9734, 70));
		AddSpawnPoint("d_dcapital_108.Id5", "d_dcapital_108", Rectangle(476.6885, 2268.7175, 70));
		AddSpawnPoint("d_dcapital_108.Id5", "d_dcapital_108", Rectangle(859.23114, 2278.5378, 70));
		AddSpawnPoint("d_dcapital_108.Id5", "d_dcapital_108", Rectangle(662.2323, 2091.889, 70));
		AddSpawnPoint("d_dcapital_108.Id5", "d_dcapital_108", Rectangle(303.10977, 2086.0952, 70));
		AddSpawnPoint("d_dcapital_108.Id5", "d_dcapital_108", Rectangle(241.36664, 2462.8943, 70));
		AddSpawnPoint("d_dcapital_108.Id5", "d_dcapital_108", Rectangle(682.54443, 2486.6763, 70));
		AddSpawnPoint("d_dcapital_108.Id5", "d_dcapital_108", Rectangle(306.41287, 2262.8228, 70));
		AddSpawnPoint("d_dcapital_108.Id5", "d_dcapital_108", Rectangle(664.6103, 2279.6636, 70));

		// 'Raganosis_Guardian' GenType 62 Spawn Points
		AddSpawnPoint("d_dcapital_108.Id6", "d_dcapital_108", Rectangle(356.8751, 2007.4326, 25));
		AddSpawnPoint("d_dcapital_108.Id6", "d_dcapital_108", Rectangle(363.1494, 2141.3618, 25));
		AddSpawnPoint("d_dcapital_108.Id6", "d_dcapital_108", Rectangle(231.25557, 2145.6587, 25));
		AddSpawnPoint("d_dcapital_108.Id6", "d_dcapital_108", Rectangle(236.57565, 2024.8469, 25));
		AddSpawnPoint("d_dcapital_108.Id6", "d_dcapital_108", Rectangle(774.63086, 2272.256, 25));
		AddSpawnPoint("d_dcapital_108.Id6", "d_dcapital_108", Rectangle(684.65955, 2402.76, 25));
		AddSpawnPoint("d_dcapital_108.Id6", "d_dcapital_108", Rectangle(599.0966, 2471.1687, 25));
		AddSpawnPoint("d_dcapital_108.Id6", "d_dcapital_108", Rectangle(764.69006, 2477.808, 25));
		AddSpawnPoint("d_dcapital_108.Id6", "d_dcapital_108", Rectangle(873.7584, 2372.2324, 25));
		AddSpawnPoint("d_dcapital_108.Id6", "d_dcapital_108", Rectangle(859.10065, 2189.3054, 25));
		AddSpawnPoint("d_dcapital_108.Id6", "d_dcapital_108", Rectangle(403.25336, 2317.976, 25));
		AddSpawnPoint("d_dcapital_108.Id6", "d_dcapital_108", Rectangle(541.89996, 2238.7168, 25));

		// 'Raganosis_Seeker' GenType 63 Spawn Points
		AddSpawnPoint("d_dcapital_108.Id7", "d_dcapital_108", Rectangle(568.13043, 2087.6907, 25));
		AddSpawnPoint("d_dcapital_108.Id7", "d_dcapital_108", Rectangle(655.07684, 2177.3442, 25));
		AddSpawnPoint("d_dcapital_108.Id7", "d_dcapital_108", Rectangle(746.0677, 2093.254, 25));
		AddSpawnPoint("d_dcapital_108.Id7", "d_dcapital_108", Rectangle(660.9871, 2001.343, 25));
		AddSpawnPoint("d_dcapital_108.Id7", "d_dcapital_108", Rectangle(254.10641, 2385.6865, 25));
		AddSpawnPoint("d_dcapital_108.Id7", "d_dcapital_108", Rectangle(326.36273, 2466.7295, 25));
		AddSpawnPoint("d_dcapital_108.Id7", "d_dcapital_108", Rectangle(161.79247, 2466.3296, 25));
		AddSpawnPoint("d_dcapital_108.Id7", "d_dcapital_108", Rectangle(233.42526, 2542.9353, 25));
		AddSpawnPoint("d_dcapital_108.Id7", "d_dcapital_108", Rectangle(166.88492, 2287.5613, 25));
		AddSpawnPoint("d_dcapital_108.Id7", "d_dcapital_108", Rectangle(78.79095, 2358.668, 25));
		AddSpawnPoint("d_dcapital_108.Id7", "d_dcapital_108", Rectangle(87.47407, 2208.1672, 25));
		AddSpawnPoint("d_dcapital_108.Id7", "d_dcapital_108", Rectangle(437.98547, 2204.2026, 25));
		AddSpawnPoint("d_dcapital_108.Id7", "d_dcapital_108", Rectangle(519.3591, 2341.3384, 25));

		// 'Rootcrystal_02' GenType 64 Spawn Points
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(172.02948, -1389.1107, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(-353.60083, -1362.0109, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(-361.4934, -965.154, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(-613.4162, -739.26654, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(-392.28522, -542.9612, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(-664.4396, -371.71344, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(-1173.9034, -360.82745, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(-1178.3148, 22.773163, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(-1224.1719, 208.21097, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(-1434.1661, 417.5508, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(-1183.322, -134.3175, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(-912.982, -359.11395, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(778.4039, -1387.5762, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(478.81784, -1326.0873, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(947.3043, -1355.4547, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(1322.1769, -1357.1517, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(1320.0022, -948.7933, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(1380.8788, -738.0185, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(1602.8612, -660.20514, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(1611.748, -381.32474, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(2104.7864, -362.967, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(2103.8655, 37.764526, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(2124.824, 205.82309, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(2383.7224, 231.90533, 200));
		AddSpawnPoint("d_dcapital_108.Id8", "d_dcapital_108", Rectangle(2373.012, 459.00192, 200));
	}
}
