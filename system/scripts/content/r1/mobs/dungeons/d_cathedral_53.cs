//--- Melia Script -----------------------------------------------------------
// d_cathedral_53
//
//--- Description -----------------------------------------------------------
// Sets up the d_cathedral_53 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DCathedral53MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("d_cathedral_53", MonsterId.Loftlem_Blue, Properties("MHP", 143158, "MINPATK", 2342, "MAXPATK", 2780, "MINMATK", 2342, "MAXMATK", 2780, "DEF", 3039, "MDEF", 3039));
		AddPropertyOverrides("d_cathedral_53", MonsterId.Colifly, Properties("MHP", 146448, "MINPATK", 2384, "MAXPATK", 2832, "MINMATK", 2384, "MAXMATK", 2832, "DEF", 3229, "MDEF", 3229));
		AddPropertyOverrides("d_cathedral_53", MonsterId.Anchor_Mage, Properties("MHP", 144780, "MINPATK", 2363, "MAXPATK", 2806, "MINMATK", 2363, "MAXMATK", 2806, "DEF", 3132, "MDEF", 3132));

		// Monster Spawners --------------------------------

		AddSpawner("d_cathedral_53.Id1", MonsterId.Loftlem_Blue, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cathedral_53.Id2", MonsterId.Rootcrystal_03, 25, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("d_cathedral_53.Id3", MonsterId.Loftlem_Blue, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cathedral_53.Id4", MonsterId.Colifly, 45, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_cathedral_53.Id5", MonsterId.Loftlem_Blue, 6, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_cathedral_53.Id6", MonsterId.Anchor_Mage, 7, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cathedral_53.Id7", MonsterId.Anchor_Mage, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Loftlem_Blue Spawn Points
		AddSpawnPoint( "d_cathedral_53.Id1", "d_cathedral_53", Spot(359.64587, 67.58885, 9999));

		// Rootcrystal_03 Spawn Points
		AddSpawnPoint( "d_cathedral_53.Id2", "d_cathedral_53", Spot(-8.044773, -868.9194, 10));
		AddSpawnPoint( "d_cathedral_53.Id2", "d_cathedral_53", Spot(-121.26051, -626.1921, 10));
		AddSpawnPoint( "d_cathedral_53.Id2", "d_cathedral_53", Spot(-358.24295, -334.3209, 10));
		AddSpawnPoint( "d_cathedral_53.Id2", "d_cathedral_53", Spot(-583.50525, -126.38942, 10));
		AddSpawnPoint( "d_cathedral_53.Id2", "d_cathedral_53", Spot(-883.4436, -307.95367, 10));
		AddSpawnPoint( "d_cathedral_53.Id2", "d_cathedral_53", Spot(-928.25323, 178.62646, 10));
		AddSpawnPoint( "d_cathedral_53.Id2", "d_cathedral_53", Spot(-1055.4783, -41.763878, 10));
		AddSpawnPoint( "d_cathedral_53.Id2", "d_cathedral_53", Spot(-1383.6198, -72.72446, 10));
		AddSpawnPoint( "d_cathedral_53.Id2", "d_cathedral_53", Spot(-1426.6116, -260.12433, 10));
		AddSpawnPoint( "d_cathedral_53.Id2", "d_cathedral_53", Spot(-1441.9531, 226.6972, 10));
		AddSpawnPoint( "d_cathedral_53.Id2", "d_cathedral_53", Spot(-1736.5172, 37.116783, 10));
		AddSpawnPoint( "d_cathedral_53.Id2", "d_cathedral_53", Spot(-1738.3351, -322.87888, 10));
		AddSpawnPoint( "d_cathedral_53.Id2", "d_cathedral_53", Spot(-1983.71, 66.15611, 10));
		AddSpawnPoint( "d_cathedral_53.Id2", "d_cathedral_53", Spot(-320.33395, 345.16797, 10));
		AddSpawnPoint( "d_cathedral_53.Id2", "d_cathedral_53", Spot(82.060394, 120.97569, 10));
		AddSpawnPoint( "d_cathedral_53.Id2", "d_cathedral_53", Spot(360.7935, 55.700294, 10));
		AddSpawnPoint( "d_cathedral_53.Id2", "d_cathedral_53", Spot(16.272102, 699.2527, 10));
		AddSpawnPoint( "d_cathedral_53.Id2", "d_cathedral_53", Spot(309.31845, 820.5166, 10));
		AddSpawnPoint( "d_cathedral_53.Id2", "d_cathedral_53", Spot(710.20703, 273.5132, 10));
		AddSpawnPoint( "d_cathedral_53.Id2", "d_cathedral_53", Spot(853.2727, -34.975266, 10));
		AddSpawnPoint( "d_cathedral_53.Id2", "d_cathedral_53", Spot(1067.243, 264.6704, 10));
		AddSpawnPoint( "d_cathedral_53.Id2", "d_cathedral_53", Spot(895.86426, -360.20947, 10));
		AddSpawnPoint( "d_cathedral_53.Id2", "d_cathedral_53", Spot(925.5143, -804.12854, 10));
		AddSpawnPoint( "d_cathedral_53.Id2", "d_cathedral_53", Spot(936.9588, -1063.6349, 10));
		AddSpawnPoint( "d_cathedral_53.Id2", "d_cathedral_53", Spot(867.8737, -1290.0908, 10));

		// Loftlem_Blue Spawn Points
		AddSpawnPoint( "d_cathedral_53.Id3", "d_cathedral_53", Spot(-12.927487, 332.93353, 30));
		AddSpawnPoint( "d_cathedral_53.Id3", "d_cathedral_53", Spot(-31.736786, 49.2414, 30));
		AddSpawnPoint( "d_cathedral_53.Id3", "d_cathedral_53", Spot(-338.72003, 479.65387, 30));
		AddSpawnPoint( "d_cathedral_53.Id3", "d_cathedral_53", Spot(-270.3811, 729.96484, 30));
		AddSpawnPoint( "d_cathedral_53.Id3", "d_cathedral_53", Spot(18.423737, 824.3663, 30));
		AddSpawnPoint( "d_cathedral_53.Id3", "d_cathedral_53", Spot(342.85727, 663.60376, 30));
		AddSpawnPoint( "d_cathedral_53.Id3", "d_cathedral_53", Spot(328.79504, 345.81122, 30));
		AddSpawnPoint( "d_cathedral_53.Id3", "d_cathedral_53", Spot(-164.13245, 1014.5641, 30));

		// Colifly Spawn Points
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(1035.591, -336.30505, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(766.27203, -280.79712, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(641.0522, 108.20294, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(978.8307, 122.09496, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(834.94543, 42.033577, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(1063.298, -118.74729, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(919.6846, -483.5288, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-2071.5957, -164.94785, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-2083.2957, 42.125305, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-2034.8965, 187.93091, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-1668.8705, -250.86865, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-1584.3472, -2.0722504, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-1387.4976, 11.720074, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-1348.8923, -91.09865, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-1576.2638, -340.5022, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-1265.1793, -276.69385, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-1189.0994, -273.33398, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-836.6142, -301.5771, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-558.4281, -292.80017, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-624.8991, 9.151649, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-781.3214, -68.16122, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-901.12665, -49.4429, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-1076.9268, -11.148834, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-990.00287, 16.917248, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-551.6171, 194.6063, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-877.5681, 197.95181, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-1090.47, 217.04137, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-1338.1691, 209.1388, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-1434.4866, 212.33813, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-1601.9569, 186.72836, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-1750.2552, 170.28009, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-676.13715, -96.00459, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-586.54974, -76.65111, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-1003.7957, -78.2059, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-1252.2168, 9.501732, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-1317.4534, -15.858795, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-1426.5541, -90.95056, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-1119.1298, -114.20445, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-1391.8292, -342.33127, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-1467.9131, 20.675201, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-1740.915, 31.74049, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-1803.0963, -88.34032, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-1890.5065, -198.8652, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-1453.6592, 177.16278, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-1312.0463, 166.33209, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-1209.6323, 164.73302, 30));
		AddSpawnPoint( "d_cathedral_53.Id4", "d_cathedral_53", Spot(-984.2449, 226.26346, 30));

		// Loftlem_Blue Spawn Points
		AddSpawnPoint( "d_cathedral_53.Id5", "d_cathedral_53", Spot(964.0258, -713.58215, 25));
		AddSpawnPoint( "d_cathedral_53.Id5", "d_cathedral_53", Spot(927.6622, -1062.083, 25));
		AddSpawnPoint( "d_cathedral_53.Id5", "d_cathedral_53", Spot(950.8153, -895.9247, 25));
		AddSpawnPoint( "d_cathedral_53.Id5", "d_cathedral_53", Spot(902.8201, -542.40857, 25));

		// Anchor_Mage Spawn Points
		AddSpawnPoint( "d_cathedral_53.Id6", "d_cathedral_53", Spot(-1938.8533, -26.356268, 30));
		AddSpawnPoint( "d_cathedral_53.Id6", "d_cathedral_53", Spot(-1566.3683, -251.1831, 30));
		AddSpawnPoint( "d_cathedral_53.Id6", "d_cathedral_53", Spot(-1624.4564, -88.89702, 30));
		AddSpawnPoint( "d_cathedral_53.Id6", "d_cathedral_53", Spot(-1514.7196, 197.44348, 30));
		AddSpawnPoint( "d_cathedral_53.Id6", "d_cathedral_53", Spot(-842.48346, 22.128288, 30));
		AddSpawnPoint( "d_cathedral_53.Id6", "d_cathedral_53", Spot(-1244.8439, -119.18305, 30));
		AddSpawnPoint( "d_cathedral_53.Id6", "d_cathedral_53", Spot(-963.36786, -310.04498, 30));
		AddSpawnPoint( "d_cathedral_53.Id6", "d_cathedral_53", Spot(-687.0296, 206.18001, 30));
		AddSpawnPoint( "d_cathedral_53.Id6", "d_cathedral_53", Spot(-1954.9039, -335.9588, 30));
		AddSpawnPoint( "d_cathedral_53.Id6", "d_cathedral_53", Spot(-1802.8348, 204.3086, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(-1432.6034, -304.95572, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(-1081.8484, -289.51413, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(-1173.6555, 12.406124, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(-2191.425, -44.54057, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(-1664.4725, 214.8404, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(-1378.7924, 260.73087, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(-1724.8882, -369.41687, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(-683.11224, -305.6372, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(-731.8292, 7.8896027, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(974.4514, -1041.3617, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(991.53143, -1094.6028, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(925.9446, -1174.7462, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(852.7486, -1136.5825, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(946.4971, -929.9377, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(994.3152, -897.0436, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(903.4839, -870.3653, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(888.5477, -912.28613, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(1011.7701, -721.3975, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(971.87164, -677.07336, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(923.13477, -707.8487, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(962.22, -752.961, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(955.2303, -530.3817, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(916.4735, -595.1513, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(879.5615, -513.2088, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(934.146, -440.43964, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(893.47705, -462.15408, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(870.30225, -569.66693, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(897.4927, -328.15115, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(1042.0746, -279.03955, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(977.1457, -253.51755, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(887.4229, -235.37093, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(727.92413, -337.18472, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(824.7322, -290.91144, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(719.8669, -254.66162, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(674.4623, -323.90103, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(1037.9216, -135.64006, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(1028.2333, 36.55374, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(810.2657, -114.11517, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(924.57556, -143.26193, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(826.75055, -31.342361, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(898.0448, 20.352325, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(837.8236, 130.30801, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(768.1482, -24.288471, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(651.9148, 55.78991, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(691.9276, 127.98209, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(733.31976, 58.73652, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(623.2087, 134.99292, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(943.57416, 126.86328, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(961.7865, 67.94854, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(978.00195, 151.76712, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(934.1038, 88.119965, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(333.90613, 284.9333, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(375.4267, 333.02255, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(336.0061, 395.06638, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(288.3794, 314.1719, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(379.52615, -74.72397, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(215.16553, 73.19294, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(59.512173, 78.61398, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(-22.91848, 137.32668, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(-9.635586, 234.67514, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(151.90453, 7.6381035, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(279.5003, 0.3102293, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(231.66258, -86.29147, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(87.51358, 487.96692, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(52.667656, 577.16656, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(-95.65375, 491.61047, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(-18.2257, 439.95245, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(373.60312, 598.98627, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(431.90863, 690.1298, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(300.11383, 720.9881, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(258.2771, 677.20374, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(104.52961, 793.1887, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(76.21626, 889.1241, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(120.38153, 669.67566, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(4.983471, 712.9623, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(-102.72016, 945.43024, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(45.369316, 1020.7194, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(-31.508587, 1030.859, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(-262.97162, 1009.5036, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(-222.31488, 725.9614, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(-260.98364, 766.2519, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(-313.54523, 733.2522, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(-269.91635, 674.96954, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(-261.04614, 339.56027, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(-247.02031, 508.7925, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(-288.57407, 559.30225, 30));
		AddSpawnPoint( "d_cathedral_53.Id7", "d_cathedral_53", Spot(-374.46313, 340.6249, 30));

	}
}
