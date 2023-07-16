//--- Melia Script -----------------------------------------------------------
// f_gele_57_3
//
//--- Description -----------------------------------------------------------
// Sets up the f_gele_57_3 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FGele573MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_gele_57_3", MonsterId.Banshee, Properties("MHP", 14960, "MINPATK", 693, "MAXPATK", 754, "MINMATK", 693, "MAXMATK", 754, "DEF", 69, "MDEF", 69));
		AddPropertyOverrides("f_gele_57_3", MonsterId.Firent, Properties("MHP", 15234, "MINPATK", 697, "MAXPATK", 758, "MINMATK", 697, "MAXMATK", 758, "DEF", 69, "MDEF", 69));
		AddPropertyOverrides("f_gele_57_3", MonsterId.Zigri_Brown, Properties("MHP", 14698, "MINPATK", 690, "MAXPATK", 750, "MINMATK", 690, "MAXMATK", 750, "DEF", 68, "MDEF", 68));
		AddPropertyOverrides("f_gele_57_3", MonsterId.Puragi_Green, Properties("MHP", 15518, "MINPATK", 701, "MAXPATK", 763, "MINMATK", 701, "MAXMATK", 763, "DEF", 69, "MDEF", 69));
		AddPropertyOverrides("f_gele_57_3", MonsterId.Humming_Bud, Properties("MHP", 15812, "MINPATK", 704, "MAXPATK", 767, "MINMATK", 704, "MAXMATK", 767, "DEF", 69, "MDEF", 69));
		AddPropertyOverrides("f_gele_57_3", MonsterId.Deadbornscab_Mage, Properties("MHP", 16116, "MINPATK", 708, "MAXPATK", 772, "MINMATK", 708, "MAXMATK", 772, "DEF", 69, "MDEF", 69));

		// Monster Spawners --------------------------------

		AddSpawner("f_gele_57_3.Id1", MonsterId.Banshee, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_3.Id2", MonsterId.Firent, 3, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_3.Id3", MonsterId.Zigri_Brown, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_3.Id4", MonsterId.Puragi_Green, 13, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_3.Id5", MonsterId.Rootcrystal_01, 13, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_gele_57_3.Id6", MonsterId.Banshee, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_3.Id7", MonsterId.Humming_Bud, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_3.Id8", MonsterId.Deadbornscab_Mage, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_3.Id9", MonsterId.Puragi_Green, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Banshee Spawn Points
		AddSpawnPoint( "f_gele_57_3.Id1", "f_gele_57_3", Spot(97.93388, 275.2663, 9999));

		// Firent Spawn Points
		AddSpawnPoint( "f_gele_57_3.Id2", "f_gele_57_3", Spot(-92.8939, 155.10188, 9999));

		// Zigri_Brown Spawn Points
		AddSpawnPoint( "f_gele_57_3.Id3", "f_gele_57_3", Spot(945.35046, -510.53992, 20));
		AddSpawnPoint( "f_gele_57_3.Id3", "f_gele_57_3", Spot(923.4265, 32.970127, 20));
		AddSpawnPoint( "f_gele_57_3.Id3", "f_gele_57_3", Spot(810.81165, 14.814886, 20));
		AddSpawnPoint( "f_gele_57_3.Id3", "f_gele_57_3", Spot(847.265, 189.64316, 20));
		AddSpawnPoint( "f_gele_57_3.Id3", "f_gele_57_3", Spot(955.2863, 143.63905, 20));
		AddSpawnPoint( "f_gele_57_3.Id3", "f_gele_57_3", Spot(782.8428, 110.72581, 20));
		AddSpawnPoint( "f_gele_57_3.Id3", "f_gele_57_3", Spot(815.3682, -454.38907, 20));
		AddSpawnPoint( "f_gele_57_3.Id3", "f_gele_57_3", Spot(708.3237, -565.48883, 20));
		AddSpawnPoint( "f_gele_57_3.Id3", "f_gele_57_3", Spot(767.923, -721.46277, 20));
		AddSpawnPoint( "f_gele_57_3.Id3", "f_gele_57_3", Spot(1014.269, -658.4771, 20));
		AddSpawnPoint( "f_gele_57_3.Id3", "f_gele_57_3", Spot(1056.9432, -314.02985, 20));

		// Puragi_Green Spawn Points
		AddSpawnPoint( "f_gele_57_3.Id4", "f_gele_57_3", Spot(855.4215, -6.323166, 20));
		AddSpawnPoint( "f_gele_57_3.Id4", "f_gele_57_3", Spot(803.1849, 183.8949, 20));
		AddSpawnPoint( "f_gele_57_3.Id4", "f_gele_57_3", Spot(436.99646, 851.85693, 20));
		AddSpawnPoint( "f_gele_57_3.Id4", "f_gele_57_3", Spot(-332.70197, 551.6548, 20));
		AddSpawnPoint( "f_gele_57_3.Id4", "f_gele_57_3", Spot(907.8342, 491.68985, 20));
		AddSpawnPoint( "f_gele_57_3.Id4", "f_gele_57_3", Spot(890.8494, 663.1876, 20));
		AddSpawnPoint( "f_gele_57_3.Id4", "f_gele_57_3", Spot(1020.4608, 769.7107, 20));
		AddSpawnPoint( "f_gele_57_3.Id4", "f_gele_57_3", Spot(984.882, 134.24406, 20));
		AddSpawnPoint( "f_gele_57_3.Id4", "f_gele_57_3", Spot(246.97739, 1057.9926, 20));
		AddSpawnPoint( "f_gele_57_3.Id4", "f_gele_57_3", Spot(173.30724, 869.21515, 20));
		AddSpawnPoint( "f_gele_57_3.Id4", "f_gele_57_3", Spot(959.19824, 20.801338, 20));
		AddSpawnPoint( "f_gele_57_3.Id4", "f_gele_57_3", Spot(741.32605, 74.66455, 20));
		AddSpawnPoint( "f_gele_57_3.Id4", "f_gele_57_3", Spot(821.6318, 411.90152, 20));
		AddSpawnPoint( "f_gele_57_3.Id4", "f_gele_57_3", Spot(1066.0676, 360.7637, 20));
		AddSpawnPoint( "f_gele_57_3.Id4", "f_gele_57_3", Spot(961.2891, 375.57993, 20));
		AddSpawnPoint( "f_gele_57_3.Id4", "f_gele_57_3", Spot(849.0156, 94.25653, 20));

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "f_gele_57_3.Id5", "f_gele_57_3", Spot(269.68457, 944.6449, 10));
		AddSpawnPoint( "f_gele_57_3.Id5", "f_gele_57_3", Spot(-464.0639, -1399.0347, 10));
		AddSpawnPoint( "f_gele_57_3.Id5", "f_gele_57_3", Spot(-568.28906, -1034.2045, 10));
		AddSpawnPoint( "f_gele_57_3.Id5", "f_gele_57_3", Spot(-513.89026, -566.6652, 10));
		AddSpawnPoint( "f_gele_57_3.Id5", "f_gele_57_3", Spot(-23.775776, -764.11774, 10));
		AddSpawnPoint( "f_gele_57_3.Id5", "f_gele_57_3", Spot(363.24854, -693.6242, 10));
		AddSpawnPoint( "f_gele_57_3.Id5", "f_gele_57_3", Spot(768.4182, -667.321, 10));
		AddSpawnPoint( "f_gele_57_3.Id5", "f_gele_57_3", Spot(966.817, -437.42178, 10));
		AddSpawnPoint( "f_gele_57_3.Id5", "f_gele_57_3", Spot(899.96094, 49.76368, 10));
		AddSpawnPoint( "f_gele_57_3.Id5", "f_gele_57_3", Spot(898.4176, 208.27757, 10));
		AddSpawnPoint( "f_gele_57_3.Id5", "f_gele_57_3", Spot(833.3311, 436.12292, 10));
		AddSpawnPoint( "f_gele_57_3.Id5", "f_gele_57_3", Spot(970.07336, 918.42554, 10));
		AddSpawnPoint( "f_gele_57_3.Id5", "f_gele_57_3", Spot(345.22784, 519.9368, 10));
		AddSpawnPoint( "f_gele_57_3.Id5", "f_gele_57_3", Spot(157.97476, 422.47205, 10));
		AddSpawnPoint( "f_gele_57_3.Id5", "f_gele_57_3", Spot(-354.08762, 574.3903, 10));
		AddSpawnPoint( "f_gele_57_3.Id5", "f_gele_57_3", Spot(-183.17493, 765.9966, 10));
		AddSpawnPoint( "f_gele_57_3.Id5", "f_gele_57_3", Spot(69.83436, 299.68756, 10));
		AddSpawnPoint( "f_gele_57_3.Id5", "f_gele_57_3", Spot(-16.12073, -259.53146, 10));
		AddSpawnPoint( "f_gele_57_3.Id5", "f_gele_57_3", Spot(318.54916, -94.76161, 10));
		AddSpawnPoint( "f_gele_57_3.Id5", "f_gele_57_3", Spot(-516.47235, -137.47993, 10));
		AddSpawnPoint( "f_gele_57_3.Id5", "f_gele_57_3", Spot(-850.5611, -299.8474, 10));
		AddSpawnPoint( "f_gele_57_3.Id5", "f_gele_57_3", Spot(-1214.3169, -206.92355, 10));

		// Banshee Spawn Points
		AddSpawnPoint( "f_gele_57_3.Id6", "f_gele_57_3", Spot(294.59808, -756.02405, 20));
		AddSpawnPoint( "f_gele_57_3.Id6", "f_gele_57_3", Spot(844.4744, -750.50024, 20));
		AddSpawnPoint( "f_gele_57_3.Id6", "f_gele_57_3", Spot(40.09449, -767.59827, 20));
		AddSpawnPoint( "f_gele_57_3.Id6", "f_gele_57_3", Spot(716.864, -502.54126, 20));
		AddSpawnPoint( "f_gele_57_3.Id6", "f_gele_57_3", Spot(966.01935, -483.07666, 20));
		AddSpawnPoint( "f_gele_57_3.Id6", "f_gele_57_3", Spot(184.42062, -627.6002, 20));
		AddSpawnPoint( "f_gele_57_3.Id6", "f_gele_57_3", Spot(85.49888, -808.8986, 20));
		AddSpawnPoint( "f_gele_57_3.Id6", "f_gele_57_3", Spot(234.91554, -662.69354, 20));
		AddSpawnPoint( "f_gele_57_3.Id6", "f_gele_57_3", Spot(159.53601, -859.22455, 20));
		AddSpawnPoint( "f_gele_57_3.Id6", "f_gele_57_3", Spot(115.26143, -637.6167, 20));
		AddSpawnPoint( "f_gele_57_3.Id6", "f_gele_57_3", Spot(259.30685, -815.4386, 20));
		AddSpawnPoint( "f_gele_57_3.Id6", "f_gele_57_3", Spot(96.3116, -721.383, 20));
		AddSpawnPoint( "f_gele_57_3.Id6", "f_gele_57_3", Spot(60.354485, -851.17236, 20));

		// Humming_Bud Spawn Points
		AddSpawnPoint( "f_gele_57_3.Id7", "f_gele_57_3", Spot(-471.72415, -851.42786, 35));
		AddSpawnPoint( "f_gele_57_3.Id7", "f_gele_57_3", Spot(-691.1405, -633.83044, 35));
		AddSpawnPoint( "f_gele_57_3.Id7", "f_gele_57_3", Spot(698.5465, -740.91736, 35));
		AddSpawnPoint( "f_gele_57_3.Id7", "f_gele_57_3", Spot(-654.4773, -830.4235, 35));
		AddSpawnPoint( "f_gele_57_3.Id7", "f_gele_57_3", Spot(731.7009, -322.50214, 35));
		AddSpawnPoint( "f_gele_57_3.Id7", "f_gele_57_3", Spot(935.85046, -473.76407, 35));
		AddSpawnPoint( "f_gele_57_3.Id7", "f_gele_57_3", Spot(-543.48895, -689.2668, 35));
		AddSpawnPoint( "f_gele_57_3.Id7", "f_gele_57_3", Spot(-302.4118, -520.4585, 35));
		AddSpawnPoint( "f_gele_57_3.Id7", "f_gele_57_3", Spot(871.6276, 100.85352, 35));
		AddSpawnPoint( "f_gele_57_3.Id7", "f_gele_57_3", Spot(-491.44977, -536.60895, 35));
		AddSpawnPoint( "f_gele_57_3.Id7", "f_gele_57_3", Spot(-579.5465, -739.63306, 35));

		// Deadbornscab_Mage Spawn Points
		AddSpawnPoint( "f_gele_57_3.Id8", "f_gele_57_3", Spot(947.92737, 860.47894, 30));
		AddSpawnPoint( "f_gele_57_3.Id8", "f_gele_57_3", Spot(784.9745, -301.093, 30));
		AddSpawnPoint( "f_gele_57_3.Id8", "f_gele_57_3", Spot(858.26654, -644.07104, 30));
		AddSpawnPoint( "f_gele_57_3.Id8", "f_gele_57_3", Spot(874.0635, 699.2066, 30));
		AddSpawnPoint( "f_gele_57_3.Id8", "f_gele_57_3", Spot(925.8063, 641.0878, 30));
		AddSpawnPoint( "f_gele_57_3.Id8", "f_gele_57_3", Spot(299.32834, 949.0466, 30));
		AddSpawnPoint( "f_gele_57_3.Id8", "f_gele_57_3", Spot(975.95996, -340.04202, 30));
		AddSpawnPoint( "f_gele_57_3.Id8", "f_gele_57_3", Spot(662.235, -590.9638, 30));

		// Puragi_Green Spawn Points
		AddSpawnPoint( "f_gele_57_3.Id9", "f_gele_57_3", Spot(777.6085, 65.169174, 20));
		AddSpawnPoint( "f_gele_57_3.Id9", "f_gele_57_3", Spot(887.9352, -34.373978, 20));
		AddSpawnPoint( "f_gele_57_3.Id9", "f_gele_57_3", Spot(994.61694, 65.163895, 20));
		AddSpawnPoint( "f_gele_57_3.Id9", "f_gele_57_3", Spot(983.3693, 151.6226, 20));
		AddSpawnPoint( "f_gele_57_3.Id9", "f_gele_57_3", Spot(915.85846, 86.624084, 20));
		AddSpawnPoint( "f_gele_57_3.Id9", "f_gele_57_3", Spot(840.126, -28.891043, 20));
		AddSpawnPoint( "f_gele_57_3.Id9", "f_gele_57_3", Spot(853.36456, 209.1354, 20));

	}
}
