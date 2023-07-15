//--- Melia Script -----------------------------------------------------------
// d_cmine_8
//
//--- Description -----------------------------------------------------------
// Sets up the d_cmine_8 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DCmine8MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("d_cmine_8.Id1", MonsterId.Rootcrystal_01, 10, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("d_cmine_8.Id2", MonsterId.FD_Bubbe_Chaser, 35, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cmine_8.Id3", MonsterId.FD_Bubbe_Mage_Fire, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cmine_8.Id4", MonsterId.Crystal_Lump, 5, TimeSpan.FromMilliseconds(10000), TendencyType.Peaceful);
		AddSpawner("d_cmine_8.Id5", MonsterId.Crystal_Lump, 5, TimeSpan.FromMilliseconds(10000), TendencyType.Peaceful);
		AddSpawner("d_cmine_8.Id6", MonsterId.Crystal_Lump, 5, TimeSpan.FromMilliseconds(10000), TendencyType.Peaceful);
		AddSpawner("d_cmine_8.Id7", MonsterId.Crystal_Lump, 5, TimeSpan.FromMilliseconds(10000), TendencyType.Peaceful);
		AddSpawner("d_cmine_8.Id8", MonsterId.Crystal_Lump, 5, TimeSpan.FromMilliseconds(10000), TendencyType.Peaceful);
		AddSpawner("d_cmine_8.Id9", MonsterId.Crystal_Lump, 5, TimeSpan.FromMilliseconds(10000), TendencyType.Peaceful);
		AddSpawner("d_cmine_8.Id10", MonsterId.FD_Minos_Mage, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_cmine_8.Id11", MonsterId.FD_Goblin_Archer_Red, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "d_cmine_8.Id1", "d_cmine_8", Spot(-1560, -11, 30));
		AddSpawnPoint( "d_cmine_8.Id1", "d_cmine_8", Spot(-1052, -1160, 30));
		AddSpawnPoint( "d_cmine_8.Id1", "d_cmine_8", Spot(36, -194, 30));
		AddSpawnPoint( "d_cmine_8.Id1", "d_cmine_8", Spot(517, 1114, 30));
		AddSpawnPoint( "d_cmine_8.Id1", "d_cmine_8", Spot(1410, 471, 30));
		AddSpawnPoint( "d_cmine_8.Id1", "d_cmine_8", Spot(2079, 1603, 30));

		// FD_Bubbe_Chaser Spawn Points
		AddSpawnPoint( "d_cmine_8.Id2", "d_cmine_8", Spot(-1165.0415, 110.54614, 9999));

		// FD_Bubbe_Mage_Fire Spawn Points
		AddSpawnPoint( "d_cmine_8.Id3", "d_cmine_8", Spot(-292.8929, 775.06476, 9999));

		// Crystal_Lump Spawn Points
		AddSpawnPoint( "d_cmine_8.Id4", "d_cmine_8", Spot(-2881.1797, -254.06818, 50));
		AddSpawnPoint( "d_cmine_8.Id4", "d_cmine_8", Spot(1068.8997, 527.67957, 50));
		AddSpawnPoint( "d_cmine_8.Id4", "d_cmine_8", Spot(112.36192, 1318.0205, 50));
		AddSpawnPoint( "d_cmine_8.Id4", "d_cmine_8", Spot(-2391.3777, -399.54645, 50));
		AddSpawnPoint( "d_cmine_8.Id4", "d_cmine_8", Spot(-46.914337, -295.97, 50));
		AddSpawnPoint( "d_cmine_8.Id5", "d_cmine_8", Spot(-1777.5858, -37.57565, 50));
		AddSpawnPoint( "d_cmine_8.Id5", "d_cmine_8", Spot(-1357.5295, -180.11514, 50));
		AddSpawnPoint( "d_cmine_8.Id5", "d_cmine_8", Spot(-1353.3118, 951.8195, 50));
		AddSpawnPoint( "d_cmine_8.Id5", "d_cmine_8", Spot(-1661.7032, 794.8086, 50));
		AddSpawnPoint( "d_cmine_8.Id5", "d_cmine_8", Spot(-1050.3002, 104.04987, 50));
		AddSpawnPoint( "d_cmine_8.Id6", "d_cmine_8", Spot(-1073.3826, -1059.5544, 50));
		AddSpawnPoint( "d_cmine_8.Id6", "d_cmine_8", Spot(-1328.2343, -856.15106, 50));
		AddSpawnPoint( "d_cmine_8.Id6", "d_cmine_8", Spot(-830.7654, -867.0439, 50));
		AddSpawnPoint( "d_cmine_8.Id6", "d_cmine_8", Spot(-1112.9185, -672.8813, 50));
		AddSpawnPoint( "d_cmine_8.Id6", "d_cmine_8", Spot(-796.5462, -618.7629, 50));
		AddSpawnPoint( "d_cmine_8.Id7", "d_cmine_8", Spot(215.01837, 43.623894, 50));
		AddSpawnPoint( "d_cmine_8.Id7", "d_cmine_8", Spot(-139.16132, 63.272705, 50));
		AddSpawnPoint( "d_cmine_8.Id7", "d_cmine_8", Spot(-489.80093, 740.43896, 50));
		AddSpawnPoint( "d_cmine_8.Id7", "d_cmine_8", Spot(-450.09335, 1148.6313, 50));
		AddSpawnPoint( "d_cmine_8.Id7", "d_cmine_8", Spot(545.62616, 1557.3551, 50));
		AddSpawnPoint( "d_cmine_8.Id8", "d_cmine_8", Spot(1011.365, 1199.003, 50));
		AddSpawnPoint( "d_cmine_8.Id8", "d_cmine_8", Spot(490.2672, 1100.0627, 50));
		AddSpawnPoint( "d_cmine_8.Id8", "d_cmine_8", Spot(636.43256, 406.70428, 50));
		AddSpawnPoint( "d_cmine_8.Id8", "d_cmine_8", Spot(1040.3163, 34.840317, 50));
		AddSpawnPoint( "d_cmine_8.Id8", "d_cmine_8", Spot(1386.4735, 446.2796, 50));
		AddSpawnPoint( "d_cmine_8.Id9", "d_cmine_8", Spot(1528.2429, 956.65576, 50));
		AddSpawnPoint( "d_cmine_8.Id9", "d_cmine_8", Spot(1790.861, 1360.1935, 50));
		AddSpawnPoint( "d_cmine_8.Id9", "d_cmine_8", Spot(1885.1018, 1877.293, 50));
		AddSpawnPoint( "d_cmine_8.Id9", "d_cmine_8", Spot(2791.5767, 1818.9807, 50));
		AddSpawnPoint( "d_cmine_8.Id9", "d_cmine_8", Spot(2661.2842, 2092.9602, 50));

		// FD_Minos_Mage Spawn Points
		AddSpawnPoint( "d_cmine_8.Id10", "d_cmine_8", Spot(-57.9033, -229.1789, 35));
		AddSpawnPoint( "d_cmine_8.Id10", "d_cmine_8", Spot(156.88048, -98.13895, 35));
		AddSpawnPoint( "d_cmine_8.Id10", "d_cmine_8", Spot(-213.10173, -49.81977, 35));
		AddSpawnPoint( "d_cmine_8.Id10", "d_cmine_8", Spot(-137.63998, -313.59937, 35));
		AddSpawnPoint( "d_cmine_8.Id10", "d_cmine_8", Spot(-550.52014, 717.6094, 35));
		AddSpawnPoint( "d_cmine_8.Id10", "d_cmine_8", Spot(-176.23914, 1008.0814, 35));
		AddSpawnPoint( "d_cmine_8.Id10", "d_cmine_8", Spot(-279.92258, 785.41724, 35));
		AddSpawnPoint( "d_cmine_8.Id10", "d_cmine_8", Spot(-590.88837, 1022.4633, 35));
		AddSpawnPoint( "d_cmine_8.Id10", "d_cmine_8", Spot(1771.2086, 1721.4812, 35));
		AddSpawnPoint( "d_cmine_8.Id10", "d_cmine_8", Spot(1903.4873, 1849.806, 35));
		AddSpawnPoint( "d_cmine_8.Id10", "d_cmine_8", Spot(1825.2021, 1279.0964, 35));
		AddSpawnPoint( "d_cmine_8.Id10", "d_cmine_8", Spot(1503.5311, 926.72205, 35));
		AddSpawnPoint( "d_cmine_8.Id10", "d_cmine_8", Spot(1344.4734, 424.31067, 35));
		AddSpawnPoint( "d_cmine_8.Id10", "d_cmine_8", Spot(1368.7836, 585.5425, 35));
		AddSpawnPoint( "d_cmine_8.Id10", "d_cmine_8", Spot(1056.7622, 264.21475, 35));
		AddSpawnPoint( "d_cmine_8.Id10", "d_cmine_8", Spot(659.3227, 292.93542, 35));
		AddSpawnPoint( "d_cmine_8.Id10", "d_cmine_8", Spot(513.6858, 954.546, 35));
		AddSpawnPoint( "d_cmine_8.Id10", "d_cmine_8", Spot(975.1419, 1239.7661, 35));
		AddSpawnPoint( "d_cmine_8.Id10", "d_cmine_8", Spot(844.8342, 1016.7222, 35));
		AddSpawnPoint( "d_cmine_8.Id10", "d_cmine_8", Spot(493.42096, 1372.5052, 35));
		AddSpawnPoint( "d_cmine_8.Id10", "d_cmine_8", Spot(1059.9288, 1101.8811, 35));
		AddSpawnPoint( "d_cmine_8.Id10", "d_cmine_8", Spot(391.95654, 1159.3745, 35));

		// FD_Goblin_Archer_Red Spawn Points
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(542.79047, 1021.3508, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(106.34069, 1260.7706, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(471.01205, 1375.7585, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(-515.8017, 901.56604, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(-443.2308, 1072.1567, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(-246.67549, -129.141, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(-171.58879, -288.95108, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(200.55548, -44.075375, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(-1676.3381, 794.1245, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(-1442.5216, 904.6005, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(-1550.9677, 791.6068, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(-1625.4375, -2.0595703, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(-1370.1881, 225.3512, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(-1052.0981, 63.720097, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(-1297.4869, -146.22969, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(-1131.0072, -739.42084, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(-881.5156, -626.7854, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(-1063.436, -988.88464, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(-796.5477, -781.5021, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(-1023.9518, -1135.0225, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(-1343.9814, -778.1223, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(-1378.5486, -886.7538, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(-1393.5311, 36.91642, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(-1579.3844, 991.3881, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(-716.13245, 978.5999, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(-107.60402, 969.7013, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(-205.48857, 727.15643, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(962.21783, 1103.9874, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(1085.7666, 1244.2865, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(923.5246, 1289.3579, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(2091.8335, 1595.6685, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(1865.6028, 1775.0146, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(1766.9421, 1701.0676, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(1843.8016, 1398.113, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(1791.2521, 1290.7379, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(1487.6581, 907.54095, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(1589.2848, 966.43756, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(1649.0443, 879.4878, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(1412.831, 571.32214, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(1267.2617, 397.4555, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(987.05035, 45.38874, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(1120.5825, 433.71017, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(426.24976, 989.888, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(621.29346, 469.58566, 25));
		AddSpawnPoint( "d_cmine_8.Id11", "d_cmine_8", Spot(636.77673, 693.98755, 25));

	}
}
