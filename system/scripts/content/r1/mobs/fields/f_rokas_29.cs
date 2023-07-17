//--- Melia Script -----------------------------------------------------------
// f_rokas_29
//
//--- Description -----------------------------------------------------------
// Sets up the f_rokas_29 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FRokas29MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_rokas_29", MonsterId.Hogma_Warrior, Properties("MHP", 52495, "MINPATK", 1176, "MAXPATK", 1347, "MINMATK", 1176, "MAXMATK", 1347, "DEF", 205, "MDEF", 205));
		AddPropertyOverrides("f_rokas_29", MonsterId.Hogma_Combat, Properties("MHP", 52601, "MINPATK", 1177, "MAXPATK", 1349, "MINMATK", 1177, "MAXMATK", 1349, "DEF", 207, "MDEF", 207));
		AddPropertyOverrides("f_rokas_29", MonsterId.Woodfung, Properties("MHP", 52796, "MINPATK", 1180, "MAXPATK", 1352, "MINMATK", 1180, "MAXMATK", 1352, "DEF", 210, "MDEF", 210));

		// Monster Spawners --------------------------------

		AddSpawner("f_rokas_29.Id1", MonsterId.Hogma_Warrior, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_29.Id2", MonsterId.Rootcrystal_05, 15, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_rokas_29.Id3", MonsterId.Hogma_Combat, 33, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);
		AddSpawner("f_rokas_29.Id4", MonsterId.Hogma_Combat, 12, TimeSpan.FromMilliseconds(35000), TendencyType.Peaceful);
		AddSpawner("f_rokas_29.Id5", MonsterId.Hogma_Combat, 23, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_29.Id6", MonsterId.Hogma_Warrior, 25, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);
		AddSpawner("f_rokas_29.Id7", MonsterId.Woodfung, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Hogma_Warrior Spawn Points
		AddSpawnPoint( "f_rokas_29.Id1", "f_rokas_29", Spot(227.32288, 618.179, 9999));

		// Rootcrystal_05 Spawn Points
		AddSpawnPoint( "f_rokas_29.Id2", "f_rokas_29", Spot(2292, 107, 30));
		AddSpawnPoint( "f_rokas_29.Id2", "f_rokas_29", Spot(1089, 275, 30));
		AddSpawnPoint( "f_rokas_29.Id2", "f_rokas_29", Spot(-725, 516, 30));
		AddSpawnPoint( "f_rokas_29.Id2", "f_rokas_29", Spot(-652, -1930, 30));
		AddSpawnPoint( "f_rokas_29.Id2", "f_rokas_29", Spot(-960, 1896, 30));
		AddSpawnPoint( "f_rokas_29.Id2", "f_rokas_29", Spot(1098.3511, -691.6019, 30));
		AddSpawnPoint( "f_rokas_29.Id2", "f_rokas_29", Spot(2539.8015, 802.6813, 30));
		AddSpawnPoint( "f_rokas_29.Id2", "f_rokas_29", Spot(208.00127, 718.98773, 30));
		AddSpawnPoint( "f_rokas_29.Id2", "f_rokas_29", Spot(-402.60623, -335.22116, 30));
		AddSpawnPoint( "f_rokas_29.Id2", "f_rokas_29", Spot(37.079285, -303.66275, 30));
		AddSpawnPoint( "f_rokas_29.Id2", "f_rokas_29", Spot(-697.48376, -892.997, 30));
		AddSpawnPoint( "f_rokas_29.Id2", "f_rokas_29", Spot(-767.6952, -1614.4249, 30));
		AddSpawnPoint( "f_rokas_29.Id2", "f_rokas_29", Spot(596.10266, 1987.5883, 30));

		// Hogma_Combat Spawn Points
		AddSpawnPoint( "f_rokas_29.Id3", "f_rokas_29", Spot(-110.80126, -292.5369, 9999));
		AddSpawnPoint( "f_rokas_29.Id4", "f_rokas_29", Spot(-835.5469, 645.29535, 400));
		AddSpawnPoint( "f_rokas_29.Id4", "f_rokas_29", Spot(-385.5133, -1549.6647, 400));
		AddSpawnPoint( "f_rokas_29.Id5", "f_rokas_29", Spot(2178.7722, 29.716274, 50));
		AddSpawnPoint( "f_rokas_29.Id5", "f_rokas_29", Spot(1092.5144, 369.93494, 50));
		AddSpawnPoint( "f_rokas_29.Id5", "f_rokas_29", Spot(2248.3198, 245.99948, 50));
		AddSpawnPoint( "f_rokas_29.Id5", "f_rokas_29", Spot(2354.8064, 428.85965, 50));
		AddSpawnPoint( "f_rokas_29.Id5", "f_rokas_29", Spot(2467.6157, 297.40793, 50));
		AddSpawnPoint( "f_rokas_29.Id5", "f_rokas_29", Spot(2435.5544, 88.26015, 50));
		AddSpawnPoint( "f_rokas_29.Id5", "f_rokas_29", Spot(2282.5461, -220.58818, 50));
		AddSpawnPoint( "f_rokas_29.Id5", "f_rokas_29", Spot(1761.014, 386.96375, 50));
		AddSpawnPoint( "f_rokas_29.Id5", "f_rokas_29", Spot(2035.4368, 214.27518, 50));
		AddSpawnPoint( "f_rokas_29.Id5", "f_rokas_29", Spot(1321.95, 425.34375, 50));
		AddSpawnPoint( "f_rokas_29.Id5", "f_rokas_29", Spot(1540.9897, 529.1337, 50));

		// Hogma_Warrior Spawn Points
		AddSpawnPoint( "f_rokas_29.Id6", "f_rokas_29", Spot(2268.0356, 67.30578, 40));
		AddSpawnPoint( "f_rokas_29.Id6", "f_rokas_29", Spot(2248.1443, 259.61353, 40));
		AddSpawnPoint( "f_rokas_29.Id6", "f_rokas_29", Spot(1834.2396, 333.25098, 40));
		AddSpawnPoint( "f_rokas_29.Id6", "f_rokas_29", Spot(1572.5554, 582.34705, 40));
		AddSpawnPoint( "f_rokas_29.Id6", "f_rokas_29", Spot(1315.8768, 473.26196, 40));
		AddSpawnPoint( "f_rokas_29.Id6", "f_rokas_29", Spot(2484.4402, 221.90414, 40));
		AddSpawnPoint( "f_rokas_29.Id6", "f_rokas_29", Spot(2251.55, -128.29688, 40));
		AddSpawnPoint( "f_rokas_29.Id6", "f_rokas_29", Spot(2170.3179, 165.87776, 40));
		AddSpawnPoint( "f_rokas_29.Id6", "f_rokas_29", Spot(2301.623, 455.32068, 40));

		// Woodfung Spawn Points
		AddSpawnPoint( "f_rokas_29.Id7", "f_rokas_29", Spot(-727.4918, -427.67938, 40));
		AddSpawnPoint( "f_rokas_29.Id7", "f_rokas_29", Spot(-122.58921, -292.28265, 40));
		AddSpawnPoint( "f_rokas_29.Id7", "f_rokas_29", Spot(-2.7469215, -121.86684, 40));
		AddSpawnPoint( "f_rokas_29.Id7", "f_rokas_29", Spot(-475.6107, -382.2738, 40));
		AddSpawnPoint( "f_rokas_29.Id7", "f_rokas_29", Spot(-1063.9336, 547.18317, 40));
		AddSpawnPoint( "f_rokas_29.Id7", "f_rokas_29", Spot(-931.914, 741.94604, 40));
		AddSpawnPoint( "f_rokas_29.Id7", "f_rokas_29", Spot(-719.4576, 514.1516, 40));
		AddSpawnPoint( "f_rokas_29.Id7", "f_rokas_29", Spot(-1748.9033, 837.63635, 40));
		AddSpawnPoint( "f_rokas_29.Id7", "f_rokas_29", Spot(-1788.6688, 1230.7772, 40));
		AddSpawnPoint( "f_rokas_29.Id7", "f_rokas_29", Spot(-1660.7017, 1037.3086, 40));
		AddSpawnPoint( "f_rokas_29.Id7", "f_rokas_29", Spot(-1071.3586, 1902.7052, 40));
		AddSpawnPoint( "f_rokas_29.Id7", "f_rokas_29", Spot(-922.7552, 1960.91, 40));
		AddSpawnPoint( "f_rokas_29.Id7", "f_rokas_29", Spot(392.18918, 1773.7471, 40));
		AddSpawnPoint( "f_rokas_29.Id7", "f_rokas_29", Spot(443.63425, 2094.929, 40));
		AddSpawnPoint( "f_rokas_29.Id7", "f_rokas_29", Spot(232.2284, 1948.4266, 40));

	}
}
