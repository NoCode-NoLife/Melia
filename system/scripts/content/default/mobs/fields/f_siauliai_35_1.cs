//--- Melia Script -----------------------------------------------------------
// f_siauliai_35_1
//
//--- Description -----------------------------------------------------------
// Sets up the f_siauliai_35_1 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FSiauliai351MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_siauliai_35_1", MonsterId.Spion_Mage_Blue, Properties("MHP", 340701, "MINPATK", 4882, "MAXPATK", 5902, "MINMATK", 4882, "MAXMATK", 5902, "DEF", 29497, "MDEF", 29497));
		AddPropertyOverrides("f_siauliai_35_1", MonsterId.Spion_Blue, Properties("MHP", 344863, "MINPATK", 4935, "MAXPATK", 5968, "MINMATK", 4935, "MAXMATK", 5968, "DEF", 30526, "MDEF", 30526));
		AddPropertyOverrides("f_siauliai_35_1", MonsterId.Spion_Bow_Blue, Properties("MHP", 349465, "MINPATK", 4994, "MAXPATK", 6041, "MINMATK", 4994, "MAXMATK", 6041, "DEF", 31663, "MDEF", 31663));

		// Monster Spawners --------------------------------

		AddSpawner("f_siauliai_35_1.Id1", MonsterId.Spion_Mage_Blue, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_35_1.Id2", MonsterId.Spion_Blue, 110, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_35_1.Id3", MonsterId.Spion_Bow_Blue, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_35_1.Id4", MonsterId.Rootcrystal_01, 18, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Spion_Mage_Blue Spawn Points
		AddSpawnPoint( "f_siauliai_35_1.Id1", "f_siauliai_35_1", Spot(-260.4293, 703.6268, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id1", "f_siauliai_35_1", Spot(-162.70288, 819.02295, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id1", "f_siauliai_35_1", Spot(204.76495, 466.05908, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id1", "f_siauliai_35_1", Spot(884.24225, 281.20398, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id1", "f_siauliai_35_1", Spot(-26.382938, 1569.3912, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id1", "f_siauliai_35_1", Spot(240.63065, 1272.2548, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id1", "f_siauliai_35_1", Spot(655.2385, 1146.5082, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id1", "f_siauliai_35_1", Spot(892.5468, 380.47794, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id1", "f_siauliai_35_1", Spot(926.682, 84.336815, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id1", "f_siauliai_35_1", Spot(736.9104, -172.64865, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id1", "f_siauliai_35_1", Spot(556.7822, -402.27216, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id1", "f_siauliai_35_1", Spot(902.9714, -632.5661, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id1", "f_siauliai_35_1", Spot(888.5954, -306.83383, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id1", "f_siauliai_35_1", Spot(645.921, -587.19366, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id1", "f_siauliai_35_1", Spot(-1451.634, -370.78415, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id1", "f_siauliai_35_1", Spot(-1432.7053, -246.28131, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id1", "f_siauliai_35_1", Spot(-858.32776, 1.7713919, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id1", "f_siauliai_35_1", Spot(-736.0271, 138.19376, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id1", "f_siauliai_35_1", Spot(-1080.1166, 284.548, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id1", "f_siauliai_35_1", Spot(-1423.4937, 317.31366, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id1", "f_siauliai_35_1", Spot(-1445.7013, 889.3835, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id1", "f_siauliai_35_1", Spot(-1345.4481, 1146.6376, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id1", "f_siauliai_35_1", Spot(-1578.199, 1069.4487, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id1", "f_siauliai_35_1", Spot(-1370.8083, 1027.787, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id1", "f_siauliai_35_1", Spot(-710.02515, 512.9928, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id1", "f_siauliai_35_1", Spot(-892.5672, 720.0575, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id1", "f_siauliai_35_1", Spot(-57.532852, -226.20467, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id1", "f_siauliai_35_1", Spot(-357.3192, -85.448654, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id1", "f_siauliai_35_1", Spot(-34.2727, -493.19327, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id1", "f_siauliai_35_1", Spot(28.17841, -745.27136, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id1", "f_siauliai_35_1", Spot(139.34515, -551.7704, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id1", "f_siauliai_35_1", Spot(-128.39449, -531.3168, 30));

		// Spion_Blue Spawn Points
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-136.27089, 516.1911, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-97.16495, 1369.0361, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-413.0616, 690.14746, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(417.99615, 493.49225, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-34.28263, -140.39651, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-197.72478, -194.17358, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-67.52289, -388.68948, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(88.67889, -304.2253, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(25.96162, 64.350784, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(14.242869, 290.1912, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-465.40662, -85.160706, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-676.2564, 80.0185, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-892.9143, -121.64496, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-940.8791, 216.17162, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-1293.3768, 381.7388, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-897.20886, 69.24578, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-812.2871, 705.2318, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-809.0969, 493.66904, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-1372.2458, 1019.3151, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-1497.1661, 909.38086, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-1525.0032, 1112.8171, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-924.8065, 568.903, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-258.61392, 809.5074, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-506.63074, 646.6237, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(575.72565, 465.80286, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(893.598, 381.27762, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(1043.1455, 217.94273, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(891.1687, 9.923798, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(798.25433, -261.22473, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(613.3364, -322.89157, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(673.5673, -528.886, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(955.8542, -555.817, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(556.53265, -493.55066, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(900.6935, 145.43863, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(1149.7441, 381.09772, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(55.591385, -678.2935, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-100.08468, -860.739, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(719.852, -587.3709, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(824.8135, -595.0265, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(696.86597, -390.01602, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(668.1079, -209.40738, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(904.85266, -166.15215, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(825.59015, -79.1542, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(1003.8676, 109.86024, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(1010.8056, 358.62454, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(811.2272, 364.39938, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(816.9127, 476.1535, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(978.182, 390.9381, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(1092.3567, 275.6851, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(1048.0143, 138.54688, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(815.1176, 180.41281, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(839.1356, 121.07921, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(826.7649, 254.73705, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(753.8523, 408.75198, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-273.58698, 741.9261, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-216.80092, 770.8368, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-196.8526, 673.21106, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-172.20703, 607.06744, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-82.6799, 495.90134, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-53.538322, 430.86584, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(103.8517, 399.50668, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(142.14899, 447.373, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-33.74481, -638.40546, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(22.943747, -587.2998, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(72.88197, -536.6137, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(11.590878, -374.6881, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-100.91277, -295.95325, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-124.86229, -172.8369, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-84.54627, -86.060005, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-212.15076, -300.24603, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(12.568207, -231.53094, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(111.16936, -404.4008, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-604.61755, 28.195509, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-675.0275, -82.26131, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-795.9464, -84.08595, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-853.4061, 139.04208, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-933.8594, 126.53222, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-959.968, -90.08537, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-922.67773, -17.250866, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-858.3988, -67.75837, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-803.64844, 103.93918, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-750.6902, 42.488926, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-1226.7261, 312.088, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-1347.7653, 195.17082, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-1269.4119, 259.31073, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-1427.4109, 239.1821, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-1349.2367, 293.87408, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-866.0542, 589.0576, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-776.398, 550.8744, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-751.4701, 641.4207, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-741.04236, 713.3814, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-759.37384, 447.7626, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(24.208477, 1258.1581, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(111.62036, 1270.1194, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(44.453754, 1580.9629, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-118.37633, 1561.2974, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(142.2885, 1539.9973, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(131.60135, 1454.8799, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(75.69389, 1494.4894, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-3.133377, 1457.0856, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-57.333374, 1439.9497, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(62.03548, 1405.4485, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(679.624, 904.156, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(789.12683, 876.6412, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(860.82385, 920.86523, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(893.7342, 987.32086, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(895.2937, 1056.5453, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-1560.0713, -325.5498, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-1476.8203, -315.9155, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-1381.2231, -339.6621, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-1376.5552, -183.56792, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-1254.1018, -197.89813, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-1220.5723, -336.98846, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-1292.8997, -332.66257, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-1267.4551, -394.15396, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-1401.5645, -469.3648, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-1451.651, -444.24628, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-1440.5363, 1115.0059, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-1459.421, 1013.0551, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-1563.9744, 950.0269, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-1393.2167, 943.1497, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-1505.8588, 858.36334, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id2", "f_siauliai_35_1", Spot(-1408.8698, 861.21045, 30));

		// Spion_Bow_Blue Spawn Points
		AddSpawnPoint( "f_siauliai_35_1.Id3", "f_siauliai_35_1", Spot(-1458.4435, 307.43387, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id3", "f_siauliai_35_1", Spot(-1374.4163, 399.97705, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id3", "f_siauliai_35_1", Spot(-1310.7546, 296.27905, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id3", "f_siauliai_35_1", Spot(-822.3701, 636.96436, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id3", "f_siauliai_35_1", Spot(-837.35913, 527.92175, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id3", "f_siauliai_35_1", Spot(-690.9717, 605.06726, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id3", "f_siauliai_35_1", Spot(14.281992, 146.88026, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id3", "f_siauliai_35_1", Spot(42.507896, 382.05823, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id3", "f_siauliai_35_1", Spot(-17.65147, 402.03094, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id3", "f_siauliai_35_1", Spot(-20.699696, -310.42065, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id3", "f_siauliai_35_1", Spot(-205.99799, -423.71307, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id3", "f_siauliai_35_1", Spot(60.789066, -713.1709, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id3", "f_siauliai_35_1", Spot(631.8774, -450.71085, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id3", "f_siauliai_35_1", Spot(765.21466, -260.29666, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id3", "f_siauliai_35_1", Spot(906.81604, -464.83682, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id3", "f_siauliai_35_1", Spot(946.5447, 240.84404, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id3", "f_siauliai_35_1", Spot(776.63, 310.81506, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id3", "f_siauliai_35_1", Spot(926.0702, 494.5372, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id3", "f_siauliai_35_1", Spot(721.7764, 1130.1492, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id3", "f_siauliai_35_1", Spot(514.986, 1172.7906, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id3", "f_siauliai_35_1", Spot(169.1904, 1327.1952, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id3", "f_siauliai_35_1", Spot(-35.751453, 1311.028, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id3", "f_siauliai_35_1", Spot(-117.1681, 1502.8997, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id3", "f_siauliai_35_1", Spot(-26.250488, 1539.0325, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id3", "f_siauliai_35_1", Spot(723.4198, 892.10596, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id3", "f_siauliai_35_1", Spot(-1515.9565, -369.95996, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id3", "f_siauliai_35_1", Spot(-1512.9556, -234.34348, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id3", "f_siauliai_35_1", Spot(-1343.5831, -400.71478, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id3", "f_siauliai_35_1", Spot(-1322.0247, -243.54318, 30));
		AddSpawnPoint( "f_siauliai_35_1.Id3", "f_siauliai_35_1", Spot(-1216.2354, -271.24286, 30));

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "f_siauliai_35_1.Id4", "f_siauliai_35_1", Spot(-183.95877, 760.43054, 100));
		AddSpawnPoint( "f_siauliai_35_1.Id4", "f_siauliai_35_1", Spot(34.964485, 493.01083, 100));
		AddSpawnPoint( "f_siauliai_35_1.Id4", "f_siauliai_35_1", Spot(893.33655, 403.7431, 100));
		AddSpawnPoint( "f_siauliai_35_1.Id4", "f_siauliai_35_1", Spot(867.4971, 192.615, 100));
		AddSpawnPoint( "f_siauliai_35_1.Id4", "f_siauliai_35_1", Spot(278.9909, 552.0436, 100));
		AddSpawnPoint( "f_siauliai_35_1.Id4", "f_siauliai_35_1", Spot(829.35376, 870.4932, 100));
		AddSpawnPoint( "f_siauliai_35_1.Id4", "f_siauliai_35_1", Spot(806.19653, 1135.225, 100));
		AddSpawnPoint( "f_siauliai_35_1.Id4", "f_siauliai_35_1", Spot(18.532043, 1534.6038, 100));
		AddSpawnPoint( "f_siauliai_35_1.Id4", "f_siauliai_35_1", Spot(32.037117, 1325.6339, 100));
		AddSpawnPoint( "f_siauliai_35_1.Id4", "f_siauliai_35_1", Spot(-9.934395, -0.9981389, 100));
		AddSpawnPoint( "f_siauliai_35_1.Id4", "f_siauliai_35_1", Spot(-209.89026, -175.2483, 100));
		AddSpawnPoint( "f_siauliai_35_1.Id4", "f_siauliai_35_1", Spot(-113.10359, -613.9321, 100));
		AddSpawnPoint( "f_siauliai_35_1.Id4", "f_siauliai_35_1", Spot(180.57414, -553.98834, 100));
		AddSpawnPoint( "f_siauliai_35_1.Id4", "f_siauliai_35_1", Spot(-6.3308163, -874.03845, 100));
		AddSpawnPoint( "f_siauliai_35_1.Id4", "f_siauliai_35_1", Spot(-900.13715, -21.576187, 100));
		AddSpawnPoint( "f_siauliai_35_1.Id4", "f_siauliai_35_1", Spot(-636.84174, 1.8961496, 100));
		AddSpawnPoint( "f_siauliai_35_1.Id4", "f_siauliai_35_1", Spot(-873.0596, 190.61386, 100));
		AddSpawnPoint( "f_siauliai_35_1.Id4", "f_siauliai_35_1", Spot(-815.9997, 647.25104, 100));
		AddSpawnPoint( "f_siauliai_35_1.Id4", "f_siauliai_35_1", Spot(-723.7529, 485.67737, 100));
		AddSpawnPoint( "f_siauliai_35_1.Id4", "f_siauliai_35_1", Spot(-1346.7478, 1105.4409, 100));
		AddSpawnPoint( "f_siauliai_35_1.Id4", "f_siauliai_35_1", Spot(-1414.8314, 878.5668, 100));
		AddSpawnPoint( "f_siauliai_35_1.Id4", "f_siauliai_35_1", Spot(-1543.2853, -316.23816, 100));
		AddSpawnPoint( "f_siauliai_35_1.Id4", "f_siauliai_35_1", Spot(-1301.4335, -290.99014, 100));
		AddSpawnPoint( "f_siauliai_35_1.Id4", "f_siauliai_35_1", Spot(547.35345, -476.36374, 100));
		AddSpawnPoint( "f_siauliai_35_1.Id4", "f_siauliai_35_1", Spot(727.04144, -373.55737, 100));
		AddSpawnPoint( "f_siauliai_35_1.Id4", "f_siauliai_35_1", Spot(935.82544, -532.52185, 100));
		AddSpawnPoint( "f_siauliai_35_1.Id4", "f_siauliai_35_1", Spot(22.296906, -331.2677, 100));

	}
}
