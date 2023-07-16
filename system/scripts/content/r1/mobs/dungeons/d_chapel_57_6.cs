//--- Melia Script -----------------------------------------------------------
// d_chapel_57_6
//
//--- Description -----------------------------------------------------------
// Sets up the d_chapel_57_6 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DChapel576MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("d_chapel_57_6", MonsterId.Corylus, Properties("MHP", 22147, "MINPATK", 786, "MAXPATK", 868, "MINMATK", 786, "MAXMATK", 868, "DEF", 74, "MDEF", 74));
		AddPropertyOverrides("d_chapel_57_6", MonsterId.Pawndel, Properties("MHP", 22588, "MINPATK", 791, "MAXPATK", 875, "MINMATK", 791, "MAXMATK", 875, "DEF", 74, "MDEF", 74));
		AddPropertyOverrides("d_chapel_57_6", MonsterId.Pawnd, Properties("MHP", 23035, "MINPATK", 797, "MAXPATK", 882, "MINMATK", 797, "MAXMATK", 882, "DEF", 74, "MDEF", 74));
		AddPropertyOverrides("d_chapel_57_6", MonsterId.Galok, Properties("MHP", 23489, "MINPATK", 803, "MAXPATK", 889, "MINMATK", 803, "MAXMATK", 889, "DEF", 75, "MDEF", 75));

		// Monster Spawners --------------------------------

		AddSpawner("d_chapel_57_6.Id1", MonsterId.Rootcrystal_01, 20, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("d_chapel_57_6.Id2", MonsterId.Corylus, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_chapel_57_6.Id3", MonsterId.Corylus, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_chapel_57_6.Id4", MonsterId.Pawndel, 12, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_chapel_57_6.Id5", MonsterId.Pawndel, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_chapel_57_6.Id6", MonsterId.Pawnd, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_chapel_57_6.Id7", MonsterId.Pawnd, 8, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_chapel_57_6.Id8", MonsterId.Galok, 3, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_chapel_57_6.Id9", MonsterId.Pawndel, 6, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "d_chapel_57_6.Id1", "d_chapel_57_6", Spot(850.59283, -174.46948, 200));
		AddSpawnPoint( "d_chapel_57_6.Id1", "d_chapel_57_6", Spot(288.54807, -194.00253, 200));
		AddSpawnPoint( "d_chapel_57_6.Id1", "d_chapel_57_6", Spot(320.74188, -39.397774, 200));
		AddSpawnPoint( "d_chapel_57_6.Id1", "d_chapel_57_6", Spot(286.17725, 465.45325, 200));
		AddSpawnPoint( "d_chapel_57_6.Id1", "d_chapel_57_6", Spot(1317.6093, 445.18845, 200));
		AddSpawnPoint( "d_chapel_57_6.Id1", "d_chapel_57_6", Spot(967.5309, 421.23456, 200));
		AddSpawnPoint( "d_chapel_57_6.Id1", "d_chapel_57_6", Spot(-671.6261, 570.8069, 200));
		AddSpawnPoint( "d_chapel_57_6.Id1", "d_chapel_57_6", Spot(-366.60974, 278.43387, 200));
		AddSpawnPoint( "d_chapel_57_6.Id1", "d_chapel_57_6", Spot(-624.2141, 1834.8982, 200));
		AddSpawnPoint( "d_chapel_57_6.Id1", "d_chapel_57_6", Spot(-525.3821, 1623.0668, 200));
		AddSpawnPoint( "d_chapel_57_6.Id1", "d_chapel_57_6", Spot(-561.37585, 1287.8185, 200));
		AddSpawnPoint( "d_chapel_57_6.Id1", "d_chapel_57_6", Spot(-1187.4695, 457.67618, 200));
		AddSpawnPoint( "d_chapel_57_6.Id1", "d_chapel_57_6", Spot(-1407.875, 545.0262, 200));
		AddSpawnPoint( "d_chapel_57_6.Id1", "d_chapel_57_6", Spot(-546.6549, -71.953415, 200));
		AddSpawnPoint( "d_chapel_57_6.Id1", "d_chapel_57_6", Spot(-533.6863, -397.31805, 200));
		AddSpawnPoint( "d_chapel_57_6.Id1", "d_chapel_57_6", Spot(-540.71844, -851.37024, 200));
		AddSpawnPoint( "d_chapel_57_6.Id1", "d_chapel_57_6", Spot(-528.14343, -1256.985, 200));

		// Corylus Spawn Points
		AddSpawnPoint( "d_chapel_57_6.Id2", "d_chapel_57_6", Spot(161.6102, -254.4061, 30));
		AddSpawnPoint( "d_chapel_57_6.Id2", "d_chapel_57_6", Spot(267.83005, -74.28504, 30));
		AddSpawnPoint( "d_chapel_57_6.Id2", "d_chapel_57_6", Spot(371.3962, 45.26278, 30));
		AddSpawnPoint( "d_chapel_57_6.Id2", "d_chapel_57_6", Spot(410.6073, -245.38405, 30));
		AddSpawnPoint( "d_chapel_57_6.Id2", "d_chapel_57_6", Spot(118.23106, 374.43683, 30));
		AddSpawnPoint( "d_chapel_57_6.Id2", "d_chapel_57_6", Spot(296.06128, 482.72202, 30));
		AddSpawnPoint( "d_chapel_57_6.Id2", "d_chapel_57_6", Spot(607.59296, 429.7723, 30));
		AddSpawnPoint( "d_chapel_57_6.Id2", "d_chapel_57_6", Spot(-412.73828, 566.371, 30));
		AddSpawnPoint( "d_chapel_57_6.Id2", "d_chapel_57_6", Spot(127.57207, -106.74422, 30));
		AddSpawnPoint( "d_chapel_57_6.Id2", "d_chapel_57_6", Spot(125.29609, 78.70725, 30));
		AddSpawnPoint( "d_chapel_57_6.Id2", "d_chapel_57_6", Spot(305.73224, 279.55994, 30));
		AddSpawnPoint( "d_chapel_57_6.Id2", "d_chapel_57_6", Spot(-687.2047, 430.95087, 30));
		AddSpawnPoint( "d_chapel_57_6.Id2", "d_chapel_57_6", Spot(-558.08325, 270.49707, 30));
		AddSpawnPoint( "d_chapel_57_6.Id2", "d_chapel_57_6", Spot(-346.0636, 393.4251, 30));
		AddSpawnPoint( "d_chapel_57_6.Id2", "d_chapel_57_6", Spot(-537.74426, 589.99866, 30));
		AddSpawnPoint( "d_chapel_57_6.Id3", "d_chapel_57_6", Spot(-427.22223, 514.1994, 50));
		AddSpawnPoint( "d_chapel_57_6.Id3", "d_chapel_57_6", Spot(-383.108, -1064.7899, 50));
		AddSpawnPoint( "d_chapel_57_6.Id3", "d_chapel_57_6", Spot(-548.9752, 1285.5707, 50));
		AddSpawnPoint( "d_chapel_57_6.Id3", "d_chapel_57_6", Spot(-658.0915, 609.82574, 50));
		AddSpawnPoint( "d_chapel_57_6.Id3", "d_chapel_57_6", Spot(-725.06354, 329.91385, 50));
		AddSpawnPoint( "d_chapel_57_6.Id3", "d_chapel_57_6", Spot(-1108.0793, 450.7363, 50));
		AddSpawnPoint( "d_chapel_57_6.Id3", "d_chapel_57_6", Spot(-654.6321, -339.08206, 50));
		AddSpawnPoint( "d_chapel_57_6.Id3", "d_chapel_57_6", Spot(-659.7844, -1073.9526, 50));
		AddSpawnPoint( "d_chapel_57_6.Id3", "d_chapel_57_6", Spot(-439.53317, 1364.2928, 50));
		AddSpawnPoint( "d_chapel_57_6.Id3", "d_chapel_57_6", Spot(-559.23315, 867.1979, 50));

		// Pawndel Spawn Points
		AddSpawnPoint( "d_chapel_57_6.Id4", "d_chapel_57_6", Spot(-581.4121, 1194.2582, 9999));
		AddSpawnPoint( "d_chapel_57_6.Id5", "d_chapel_57_6", Spot(-585.83813, -286.03513, 20));
		AddSpawnPoint( "d_chapel_57_6.Id5", "d_chapel_57_6", Spot(-516.018, -975.9483, 20));
		AddSpawnPoint( "d_chapel_57_6.Id5", "d_chapel_57_6", Spot(-607.35065, 582.35315, 20));
		AddSpawnPoint( "d_chapel_57_6.Id5", "d_chapel_57_6", Spot(-571.0361, 1168.1211, 20));
		AddSpawnPoint( "d_chapel_57_6.Id5", "d_chapel_57_6", Spot(-381.29755, 478.40375, 20));
		AddSpawnPoint( "d_chapel_57_6.Id5", "d_chapel_57_6", Spot(-522.8922, 1955.2909, 20));
		AddSpawnPoint( "d_chapel_57_6.Id5", "d_chapel_57_6", Spot(223.42441, 366.09064, 20));
		AddSpawnPoint( "d_chapel_57_6.Id5", "d_chapel_57_6", Spot(462.98157, 496.0558, 20));
		AddSpawnPoint( "d_chapel_57_6.Id5", "d_chapel_57_6", Spot(-614.72754, -455.18768, 20));
		AddSpawnPoint( "d_chapel_57_6.Id5", "d_chapel_57_6", Spot(-432.25922, -409.20242, 20));
		AddSpawnPoint( "d_chapel_57_6.Id5", "d_chapel_57_6", Spot(160.32443, 433.59192, 20));
		AddSpawnPoint( "d_chapel_57_6.Id5", "d_chapel_57_6", Spot(359.23895, 577.70593, 20));
		AddSpawnPoint( "d_chapel_57_6.Id5", "d_chapel_57_6", Spot(-667.2746, 292.33878, 20));
		AddSpawnPoint( "d_chapel_57_6.Id5", "d_chapel_57_6", Spot(-547.54504, 192.75323, 20));
		AddSpawnPoint( "d_chapel_57_6.Id5", "d_chapel_57_6", Spot(-382.48627, 309.88782, 20));
		AddSpawnPoint( "d_chapel_57_6.Id5", "d_chapel_57_6", Spot(-305.5154, 186.91061, 20));
		AddSpawnPoint( "d_chapel_57_6.Id5", "d_chapel_57_6", Spot(-285.8636, 629.1796, 20));
		AddSpawnPoint( "d_chapel_57_6.Id5", "d_chapel_57_6", Spot(-659.66235, 706.4414, 20));
		AddSpawnPoint( "d_chapel_57_6.Id5", "d_chapel_57_6", Spot(-746.4234, 405.51385, 20));
		AddSpawnPoint( "d_chapel_57_6.Id5", "d_chapel_57_6", Spot(-448.7114, 648.15265, 20));
		AddSpawnPoint( "d_chapel_57_6.Id5", "d_chapel_57_6", Spot(-456.40723, 1236.1089, 20));
		AddSpawnPoint( "d_chapel_57_6.Id5", "d_chapel_57_6", Spot(-579.9322, 1384.5444, 20));
		AddSpawnPoint( "d_chapel_57_6.Id5", "d_chapel_57_6", Spot(-466.0016, 1371.5858, 20));
		AddSpawnPoint( "d_chapel_57_6.Id5", "d_chapel_57_6", Spot(-637.8546, 1228.3706, 20));
		AddSpawnPoint( "d_chapel_57_6.Id5", "d_chapel_57_6", Spot(-578.5163, 1849.5365, 20));
		AddSpawnPoint( "d_chapel_57_6.Id5", "d_chapel_57_6", Spot(-403.39706, 1872.3666, 20));
		AddSpawnPoint( "d_chapel_57_6.Id5", "d_chapel_57_6", Spot(-490.51724, 2070.9148, 20));
		AddSpawnPoint( "d_chapel_57_6.Id5", "d_chapel_57_6", Spot(-676.1732, 2061.2231, 20));
		AddSpawnPoint( "d_chapel_57_6.Id5", "d_chapel_57_6", Spot(-681.6344, 1891.2694, 20));
		AddSpawnPoint( "d_chapel_57_6.Id5", "d_chapel_57_6", Spot(-365.63678, 1996.9546, 20));
		AddSpawnPoint( "d_chapel_57_6.Id5", "d_chapel_57_6", Spot(-523.47943, -1283.4556, 20));
		AddSpawnPoint( "d_chapel_57_6.Id5", "d_chapel_57_6", Spot(-375.51022, -1274.969, 20));
		AddSpawnPoint( "d_chapel_57_6.Id5", "d_chapel_57_6", Spot(-369.54285, -999.62067, 20));
		AddSpawnPoint( "d_chapel_57_6.Id5", "d_chapel_57_6", Spot(-720.6694, -1138.4327, 20));
		AddSpawnPoint( "d_chapel_57_6.Id5", "d_chapel_57_6", Spot(-325.45535, -1160.011, 20));
		AddSpawnPoint( "d_chapel_57_6.Id5", "d_chapel_57_6", Spot(-629.0824, -882.67755, 20));

		// Pawnd Spawn Points
		AddSpawnPoint( "d_chapel_57_6.Id6", "d_chapel_57_6", Spot(-509.1892, 1938.8633, 30));
		AddSpawnPoint( "d_chapel_57_6.Id6", "d_chapel_57_6", Spot(-513.9192, 1657.3975, 30));
		AddSpawnPoint( "d_chapel_57_6.Id6", "d_chapel_57_6", Spot(-618.69824, 1250.9843, 30));
		AddSpawnPoint( "d_chapel_57_6.Id6", "d_chapel_57_6", Spot(-475.32825, 314.49954, 30));
		AddSpawnPoint( "d_chapel_57_6.Id6", "d_chapel_57_6", Spot(-420.56985, 614.1078, 30));
		AddSpawnPoint( "d_chapel_57_6.Id6", "d_chapel_57_6", Spot(-718.9117, 242.45593, 30));
		AddSpawnPoint( "d_chapel_57_6.Id6", "d_chapel_57_6", Spot(-532.24506, -368.27557, 30));
		AddSpawnPoint( "d_chapel_57_6.Id6", "d_chapel_57_6", Spot(-573.59247, -1163.7906, 30));
		AddSpawnPoint( "d_chapel_57_6.Id6", "d_chapel_57_6", Spot(-451.1591, -989.3579, 30));
		AddSpawnPoint( "d_chapel_57_6.Id6", "d_chapel_57_6", Spot(276.31757, 444.0364, 30));
		AddSpawnPoint( "d_chapel_57_6.Id6", "d_chapel_57_6", Spot(-740.6834, 583.0947, 30));
		AddSpawnPoint( "d_chapel_57_6.Id6", "d_chapel_57_6", Spot(-427.2494, 1285.6549, 30));
		AddSpawnPoint( "d_chapel_57_6.Id6", "d_chapel_57_6", Spot(-654.5829, 441.85498, 30));
		AddSpawnPoint( "d_chapel_57_6.Id6", "d_chapel_57_6", Spot(-278.96237, 479.5981, 30));
		AddSpawnPoint( "d_chapel_57_6.Id6", "d_chapel_57_6", Spot(216.21883, 303.6188, 30));
		AddSpawnPoint( "d_chapel_57_6.Id6", "d_chapel_57_6", Spot(273.20724, 570.626, 30));
		AddSpawnPoint( "d_chapel_57_6.Id6", "d_chapel_57_6", Spot(-633.54236, -320.7896, 30));
		AddSpawnPoint( "d_chapel_57_6.Id6", "d_chapel_57_6", Spot(-596.67737, -505.48856, 30));
		AddSpawnPoint( "d_chapel_57_6.Id6", "d_chapel_57_6", Spot(-613.0231, -1004.3244, 30));
		AddSpawnPoint( "d_chapel_57_6.Id6", "d_chapel_57_6", Spot(-651.41125, -1255.3185, 30));
		AddSpawnPoint( "d_chapel_57_6.Id6", "d_chapel_57_6", Spot(-308.53012, -1209.9208, 30));
		AddSpawnPoint( "d_chapel_57_6.Id6", "d_chapel_57_6", Spot(-306.96713, -972.59485, 30));
		AddSpawnPoint( "d_chapel_57_6.Id6", "d_chapel_57_6", Spot(-381.7078, 1997.013, 30));
		AddSpawnPoint( "d_chapel_57_6.Id6", "d_chapel_57_6", Spot(-654.5943, 1932.5632, 30));
		AddSpawnPoint( "d_chapel_57_6.Id6", "d_chapel_57_6", Spot(-533.10205, 1329.1111, 30));
		AddSpawnPoint( "d_chapel_57_6.Id6", "d_chapel_57_6", Spot(-532.78705, 1102.4279, 30));
		AddSpawnPoint( "d_chapel_57_6.Id6", "d_chapel_57_6", Spot(-531.5471, 653.8039, 30));
		AddSpawnPoint( "d_chapel_57_6.Id7", "d_chapel_57_6", Spot(-375.04474, 636.9003, 9999));

		// Galok Spawn Points
		AddSpawnPoint( "d_chapel_57_6.Id8", "d_chapel_57_6", Spot(55.35481, 423.5047, 9999));

		// Pawndel Spawn Points
		AddSpawnPoint( "d_chapel_57_6.Id9", "d_chapel_57_6", Spot(-429.5994, 1879.0007, 20));
		AddSpawnPoint( "d_chapel_57_6.Id9", "d_chapel_57_6", Spot(-623.3361, 1357.8162, 20));
		AddSpawnPoint( "d_chapel_57_6.Id9", "d_chapel_57_6", Spot(-554.2665, 2143.13, 20));
		AddSpawnPoint( "d_chapel_57_6.Id9", "d_chapel_57_6", Spot(-573.5683, 2052.5935, 20));
		AddSpawnPoint( "d_chapel_57_6.Id9", "d_chapel_57_6", Spot(-667.53894, 1286.0679, 20));
		AddSpawnPoint( "d_chapel_57_6.Id9", "d_chapel_57_6", Spot(-365.96906, 1989.9988, 20));
		AddSpawnPoint( "d_chapel_57_6.Id9", "d_chapel_57_6", Spot(-473.32407, 1790.5237, 20));
		AddSpawnPoint( "d_chapel_57_6.Id9", "d_chapel_57_6", Spot(-693.12885, 1896.4249, 20));
		AddSpawnPoint( "d_chapel_57_6.Id9", "d_chapel_57_6", Spot(-472.29443, 1324.219, 20));

	}
}
