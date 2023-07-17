//--- Melia Script -----------------------------------------------------------
// d_dcapital_108
//
//--- Description -----------------------------------------------------------
// Sets up the d_dcapital_108 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DDcapital108MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("d_dcapital_108", MonsterId.Raganosis_Ram, Properties("MHP", 862065, "MINPATK", 11586, "MAXPATK", 14142, "MINMATK", 11586, "MAXMATK", 14142, "DEF", 326330, "MDEF", 326330));
		AddPropertyOverrides("d_dcapital_108", MonsterId.Raganosis_Guardian, Properties("MHP", 872854, "MINPATK", 11725, "MAXPATK", 14313, "MINMATK", 11725, "MAXMATK", 14313, "DEF", 336922, "MDEF", 336922));
		AddPropertyOverrides("d_dcapital_108", MonsterId.Raganosis_Seeker, Properties("MHP", 884585, "MINPATK", 11876, "MAXPATK", 14498, "MINMATK", 11876, "MAXMATK", 14498, "DEF", 348437, "MDEF", 348437));

		// Monster Spawners --------------------------------

		AddSpawner("d_dcapital_108.Id1", MonsterId.Raganosis_Ram, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_dcapital_108.Id2", MonsterId.Raganosis_Guardian, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_dcapital_108.Id3", MonsterId.Raganosis_Seeker, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_dcapital_108.Id4", MonsterId.Raganosis_Ram, 2, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_dcapital_108.Id5", MonsterId.Raganosis_Ram, 9, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_dcapital_108.Id6", MonsterId.Raganosis_Guardian, 24, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_dcapital_108.Id7", MonsterId.Raganosis_Seeker, 26, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_dcapital_108.Id8", MonsterId.Rootcrystal_02, 25, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Raganosis_Ram Spawn Points
		AddSpawnPoint( "d_dcapital_108.Id1", "d_dcapital_108", Spot(2351.8965, 478.5188, 70));
		AddSpawnPoint( "d_dcapital_108.Id1", "d_dcapital_108", Spot(2119.8198, 136.7554, 70));
		AddSpawnPoint( "d_dcapital_108.Id1", "d_dcapital_108", Spot(1585.1422, -762.9775, 70));
		AddSpawnPoint( "d_dcapital_108.Id1", "d_dcapital_108", Spot(-1515.8936, 190.70773, 70));
		AddSpawnPoint( "d_dcapital_108.Id1", "d_dcapital_108", Spot(-1262.2233, 460.55, 70));
		AddSpawnPoint( "d_dcapital_108.Id1", "d_dcapital_108", Spot(-353.46637, -923.0284, 70));
		AddSpawnPoint( "d_dcapital_108.Id1", "d_dcapital_108", Spot(-645.3163, -491.90277, 70));
		AddSpawnPoint( "d_dcapital_108.Id1", "d_dcapital_108", Spot(1653.9376, -358.35413, 70));
		AddSpawnPoint( "d_dcapital_108.Id1", "d_dcapital_108", Spot(-465.8307, -671.5528, 70));

		// Raganosis_Guardian Spawn Points
		AddSpawnPoint( "d_dcapital_108.Id2", "d_dcapital_108", Spot(2384.426, 420.1546, 25));
		AddSpawnPoint( "d_dcapital_108.Id2", "d_dcapital_108", Spot(2280.1497, 206.01773, 25));
		AddSpawnPoint( "d_dcapital_108.Id2", "d_dcapital_108", Spot(2095.9788, 227.91971, 25));
		AddSpawnPoint( "d_dcapital_108.Id2", "d_dcapital_108", Spot(1428.7308, -697.0071, 25));
		AddSpawnPoint( "d_dcapital_108.Id2", "d_dcapital_108", Spot(1595.6252, -641.53436, 25));
		AddSpawnPoint( "d_dcapital_108.Id2", "d_dcapital_108", Spot(1470.3568, -792.44745, 25));
		AddSpawnPoint( "d_dcapital_108.Id2", "d_dcapital_108", Spot(-568.2544, -695.7127, 25));
		AddSpawnPoint( "d_dcapital_108.Id2", "d_dcapital_108", Spot(-429.69318, -590.19885, 25));
		AddSpawnPoint( "d_dcapital_108.Id2", "d_dcapital_108", Spot(-481.614, -750.70795, 25));
		AddSpawnPoint( "d_dcapital_108.Id2", "d_dcapital_108", Spot(-381.76376, -665.8106, 25));
		AddSpawnPoint( "d_dcapital_108.Id2", "d_dcapital_108", Spot(-1415.5085, 224.66605, 25));
		AddSpawnPoint( "d_dcapital_108.Id2", "d_dcapital_108", Spot(-1185.5078, 467.15393, 25));
		AddSpawnPoint( "d_dcapital_108.Id2", "d_dcapital_108", Spot(-1177.348, -42.833878, 25));
		AddSpawnPoint( "d_dcapital_108.Id2", "d_dcapital_108", Spot(2086.006, 4.781807, 25));
		AddSpawnPoint( "d_dcapital_108.Id2", "d_dcapital_108", Spot(-988.7815, -354.59897, 25));
		AddSpawnPoint( "d_dcapital_108.Id2", "d_dcapital_108", Spot(-1278.78, 167.15442, 25));
		AddSpawnPoint( "d_dcapital_108.Id2", "d_dcapital_108", Spot(-1184.5181, 274.69113, 25));
		AddSpawnPoint( "d_dcapital_108.Id2", "d_dcapital_108", Spot(1913.1101, -357.8818, 25));
		AddSpawnPoint( "d_dcapital_108.Id2", "d_dcapital_108", Spot(2395.3848, 307.64734, 25));
		AddSpawnPoint( "d_dcapital_108.Id2", "d_dcapital_108", Spot(2120.453, -217.1689, 25));
		AddSpawnPoint( "d_dcapital_108.Id2", "d_dcapital_108", Spot(1345.5647, -619.7691, 25));
		AddSpawnPoint( "d_dcapital_108.Id2", "d_dcapital_108", Spot(-654.2561, -572.7916, 25));
		AddSpawnPoint( "d_dcapital_108.Id2", "d_dcapital_108", Spot(-1157.3936, -319.4986, 25));
		AddSpawnPoint( "d_dcapital_108.Id2", "d_dcapital_108", Spot(-1298.5332, 281.40784, 25));
		AddSpawnPoint( "d_dcapital_108.Id2", "d_dcapital_108", Spot(-1357.1185, 455.9248, 25));
		AddSpawnPoint( "d_dcapital_108.Id2", "d_dcapital_108", Spot(1544.2057, -589.54614, 25));
		AddSpawnPoint( "d_dcapital_108.Id2", "d_dcapital_108", Spot(2202.9954, 271.22144, 25));
		AddSpawnPoint( "d_dcapital_108.Id2", "d_dcapital_108", Spot(2255.7627, 377.05203, 25));
		AddSpawnPoint( "d_dcapital_108.Id2", "d_dcapital_108", Spot(-390.43713, -833.00037, 25));
		AddSpawnPoint( "d_dcapital_108.Id2", "d_dcapital_108", Spot(-327.53052, -774.0956, 25));
		AddSpawnPoint( "d_dcapital_108.Id2", "d_dcapital_108", Spot(-482.51633, -515.3401, 25));

		// Raganosis_Seeker Spawn Points
		AddSpawnPoint( "d_dcapital_108.Id3", "d_dcapital_108", Spot(2286.0415, 435.8952, 25));
		AddSpawnPoint( "d_dcapital_108.Id3", "d_dcapital_108", Spot(1572.674, -515.2741, 25));
		AddSpawnPoint( "d_dcapital_108.Id3", "d_dcapital_108", Spot(1321.2157, -762.5934, 25));
		AddSpawnPoint( "d_dcapital_108.Id3", "d_dcapital_108", Spot(-636.67554, -771.9603, 25));
		AddSpawnPoint( "d_dcapital_108.Id3", "d_dcapital_108", Spot(-378.87506, -519.5603, 25));
		AddSpawnPoint( "d_dcapital_108.Id3", "d_dcapital_108", Spot(-1194.5012, -377.32983, 25));
		AddSpawnPoint( "d_dcapital_108.Id3", "d_dcapital_108", Spot(-1427.513, 329.7516, 25));
		AddSpawnPoint( "d_dcapital_108.Id3", "d_dcapital_108", Spot(2155.4, 415.36627, 25));
		AddSpawnPoint( "d_dcapital_108.Id3", "d_dcapital_108", Spot(-406.59448, -749.18146, 25));
		AddSpawnPoint( "d_dcapital_108.Id3", "d_dcapital_108", Spot(-679.27484, -334.56668, 25));
		AddSpawnPoint( "d_dcapital_108.Id3", "d_dcapital_108", Spot(-1298.608, 216.04599, 25));
		AddSpawnPoint( "d_dcapital_108.Id3", "d_dcapital_108", Spot(1769.1913, -386.66037, 25));
		AddSpawnPoint( "d_dcapital_108.Id3", "d_dcapital_108", Spot(2112.9705, -129.4248, 25));
		AddSpawnPoint( "d_dcapital_108.Id3", "d_dcapital_108", Spot(-559.3819, -531.74164, 25));
		AddSpawnPoint( "d_dcapital_108.Id3", "d_dcapital_108", Spot(-1353.5704, 458.2198, 25));
		AddSpawnPoint( "d_dcapital_108.Id3", "d_dcapital_108", Spot(-1235.8287, 356.49127, 25));
		AddSpawnPoint( "d_dcapital_108.Id3", "d_dcapital_108", Spot(2331.4756, 187.08893, 25));
		AddSpawnPoint( "d_dcapital_108.Id3", "d_dcapital_108", Spot(2405.9924, 234.64423, 25));
		AddSpawnPoint( "d_dcapital_108.Id3", "d_dcapital_108", Spot(2027.3557, -373.9967, 25));
		AddSpawnPoint( "d_dcapital_108.Id3", "d_dcapital_108", Spot(1385.0643, -528.17957, 25));
		AddSpawnPoint( "d_dcapital_108.Id3", "d_dcapital_108", Spot(1642.0437, -736.9049, 25));
		AddSpawnPoint( "d_dcapital_108.Id3", "d_dcapital_108", Spot(1498.8535, -651.5994, 25));
		AddSpawnPoint( "d_dcapital_108.Id3", "d_dcapital_108", Spot(-665.49713, -683.7485, 25));

		// Raganosis_Ram Spawn Points
		AddSpawnPoint( "d_dcapital_108.Id4", "d_dcapital_108", Spot(2113.4763, -351.6513, 40));
		AddSpawnPoint( "d_dcapital_108.Id4", "d_dcapital_108", Spot(-1155.7175, -174.47638, 40));
		AddSpawnPoint( "d_dcapital_108.Id4", "d_dcapital_108", Spot(-837.9865, -348.47385, 40));
		AddSpawnPoint( "d_dcapital_108.Id4", "d_dcapital_108", Spot(1297.2229, -908.0183, 40));
		AddSpawnPoint( "d_dcapital_108.Id5", "d_dcapital_108", Spot(83.40954, 2282.9734, 70));
		AddSpawnPoint( "d_dcapital_108.Id5", "d_dcapital_108", Spot(476.6885, 2268.7175, 70));
		AddSpawnPoint( "d_dcapital_108.Id5", "d_dcapital_108", Spot(859.23114, 2278.5378, 70));
		AddSpawnPoint( "d_dcapital_108.Id5", "d_dcapital_108", Spot(662.2323, 2091.889, 70));
		AddSpawnPoint( "d_dcapital_108.Id5", "d_dcapital_108", Spot(303.10977, 2086.0952, 70));
		AddSpawnPoint( "d_dcapital_108.Id5", "d_dcapital_108", Spot(241.36664, 2462.8943, 70));
		AddSpawnPoint( "d_dcapital_108.Id5", "d_dcapital_108", Spot(682.54443, 2486.6763, 70));
		AddSpawnPoint( "d_dcapital_108.Id5", "d_dcapital_108", Spot(306.41287, 2262.8228, 70));
		AddSpawnPoint( "d_dcapital_108.Id5", "d_dcapital_108", Spot(664.6103, 2279.6636, 70));

		// Raganosis_Guardian Spawn Points
		AddSpawnPoint( "d_dcapital_108.Id6", "d_dcapital_108", Spot(356.8751, 2007.4326, 25));
		AddSpawnPoint( "d_dcapital_108.Id6", "d_dcapital_108", Spot(363.1494, 2141.3618, 25));
		AddSpawnPoint( "d_dcapital_108.Id6", "d_dcapital_108", Spot(231.25557, 2145.6587, 25));
		AddSpawnPoint( "d_dcapital_108.Id6", "d_dcapital_108", Spot(236.57565, 2024.8469, 25));
		AddSpawnPoint( "d_dcapital_108.Id6", "d_dcapital_108", Spot(774.63086, 2272.256, 25));
		AddSpawnPoint( "d_dcapital_108.Id6", "d_dcapital_108", Spot(684.65955, 2402.76, 25));
		AddSpawnPoint( "d_dcapital_108.Id6", "d_dcapital_108", Spot(599.0966, 2471.1687, 25));
		AddSpawnPoint( "d_dcapital_108.Id6", "d_dcapital_108", Spot(764.69006, 2477.808, 25));
		AddSpawnPoint( "d_dcapital_108.Id6", "d_dcapital_108", Spot(873.7584, 2372.2324, 25));
		AddSpawnPoint( "d_dcapital_108.Id6", "d_dcapital_108", Spot(859.10065, 2189.3054, 25));
		AddSpawnPoint( "d_dcapital_108.Id6", "d_dcapital_108", Spot(403.25336, 2317.976, 25));
		AddSpawnPoint( "d_dcapital_108.Id6", "d_dcapital_108", Spot(541.89996, 2238.7168, 25));

		// Raganosis_Seeker Spawn Points
		AddSpawnPoint( "d_dcapital_108.Id7", "d_dcapital_108", Spot(568.13043, 2087.6907, 25));
		AddSpawnPoint( "d_dcapital_108.Id7", "d_dcapital_108", Spot(655.07684, 2177.3442, 25));
		AddSpawnPoint( "d_dcapital_108.Id7", "d_dcapital_108", Spot(746.0677, 2093.254, 25));
		AddSpawnPoint( "d_dcapital_108.Id7", "d_dcapital_108", Spot(660.9871, 2001.343, 25));
		AddSpawnPoint( "d_dcapital_108.Id7", "d_dcapital_108", Spot(254.10641, 2385.6865, 25));
		AddSpawnPoint( "d_dcapital_108.Id7", "d_dcapital_108", Spot(326.36273, 2466.7295, 25));
		AddSpawnPoint( "d_dcapital_108.Id7", "d_dcapital_108", Spot(161.79247, 2466.3296, 25));
		AddSpawnPoint( "d_dcapital_108.Id7", "d_dcapital_108", Spot(233.42526, 2542.9353, 25));
		AddSpawnPoint( "d_dcapital_108.Id7", "d_dcapital_108", Spot(166.88492, 2287.5613, 25));
		AddSpawnPoint( "d_dcapital_108.Id7", "d_dcapital_108", Spot(78.79095, 2358.668, 25));
		AddSpawnPoint( "d_dcapital_108.Id7", "d_dcapital_108", Spot(87.47407, 2208.1672, 25));
		AddSpawnPoint( "d_dcapital_108.Id7", "d_dcapital_108", Spot(437.98547, 2204.2026, 25));
		AddSpawnPoint( "d_dcapital_108.Id7", "d_dcapital_108", Spot(519.3591, 2341.3384, 25));

		// Rootcrystal_02 Spawn Points
		AddSpawnPoint( "d_dcapital_108.Id8", "d_dcapital_108", Spot(172.02948, -1389.1107, 200));
		AddSpawnPoint( "d_dcapital_108.Id8", "d_dcapital_108", Spot(-353.60083, -1362.0109, 200));
		AddSpawnPoint( "d_dcapital_108.Id8", "d_dcapital_108", Spot(-361.4934, -965.154, 200));
		AddSpawnPoint( "d_dcapital_108.Id8", "d_dcapital_108", Spot(-613.4162, -739.26654, 200));
		AddSpawnPoint( "d_dcapital_108.Id8", "d_dcapital_108", Spot(-392.28522, -542.9612, 200));
		AddSpawnPoint( "d_dcapital_108.Id8", "d_dcapital_108", Spot(-664.4396, -371.71344, 200));
		AddSpawnPoint( "d_dcapital_108.Id8", "d_dcapital_108", Spot(-1173.9034, -360.82745, 200));
		AddSpawnPoint( "d_dcapital_108.Id8", "d_dcapital_108", Spot(-1178.3148, 22.773163, 200));
		AddSpawnPoint( "d_dcapital_108.Id8", "d_dcapital_108", Spot(-1224.1719, 208.21097, 200));
		AddSpawnPoint( "d_dcapital_108.Id8", "d_dcapital_108", Spot(-1434.1661, 417.5508, 200));
		AddSpawnPoint( "d_dcapital_108.Id8", "d_dcapital_108", Spot(-1183.322, -134.3175, 200));
		AddSpawnPoint( "d_dcapital_108.Id8", "d_dcapital_108", Spot(-912.982, -359.11395, 200));
		AddSpawnPoint( "d_dcapital_108.Id8", "d_dcapital_108", Spot(778.4039, -1387.5762, 200));
		AddSpawnPoint( "d_dcapital_108.Id8", "d_dcapital_108", Spot(478.81784, -1326.0873, 200));
		AddSpawnPoint( "d_dcapital_108.Id8", "d_dcapital_108", Spot(947.3043, -1355.4547, 200));
		AddSpawnPoint( "d_dcapital_108.Id8", "d_dcapital_108", Spot(1322.1769, -1357.1517, 200));
		AddSpawnPoint( "d_dcapital_108.Id8", "d_dcapital_108", Spot(1320.0022, -948.7933, 200));
		AddSpawnPoint( "d_dcapital_108.Id8", "d_dcapital_108", Spot(1380.8788, -738.0185, 200));
		AddSpawnPoint( "d_dcapital_108.Id8", "d_dcapital_108", Spot(1602.8612, -660.20514, 200));
		AddSpawnPoint( "d_dcapital_108.Id8", "d_dcapital_108", Spot(1611.748, -381.32474, 200));
		AddSpawnPoint( "d_dcapital_108.Id8", "d_dcapital_108", Spot(2104.7864, -362.967, 200));
		AddSpawnPoint( "d_dcapital_108.Id8", "d_dcapital_108", Spot(2103.8655, 37.764526, 200));
		AddSpawnPoint( "d_dcapital_108.Id8", "d_dcapital_108", Spot(2124.824, 205.82309, 200));
		AddSpawnPoint( "d_dcapital_108.Id8", "d_dcapital_108", Spot(2383.7224, 231.90533, 200));
		AddSpawnPoint( "d_dcapital_108.Id8", "d_dcapital_108", Spot(2373.012, 459.00192, 200));

	}
}
