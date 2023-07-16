//--- Melia Script -----------------------------------------------------------
// f_rokas_30
//
//--- Description -----------------------------------------------------------
// Sets up the f_rokas_30 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FRokas30MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_rokas_30", MonsterId.Hogma_Sorcerer, Properties("MHP", 53685, "MINPATK", 1191, "MAXPATK", 1366, "MINMATK", 1191, "MAXMATK", 1366, "DEF", 223, "MDEF", 223));
		AddPropertyOverrides("f_rokas_30", MonsterId.Hogma_Guard, Properties("MHP", 54060, "MINPATK", 1196, "MAXPATK", 1372, "MINMATK", 1196, "MAXMATK", 1372, "DEF", 229, "MDEF", 229));
		AddPropertyOverrides("f_rokas_30", MonsterId.Deadbornscab_Bow, Properties("MHP", 54467, "MINPATK", 1201, "MAXPATK", 1378, "MINMATK", 1201, "MAXMATK", 1378, "DEF", 235, "MDEF", 235));

		// Monster Spawners --------------------------------

		AddSpawner("f_rokas_30.Id1", MonsterId.Hogma_Sorcerer, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_30.Id2", MonsterId.Rootcrystal_05, 12, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_rokas_30.Id3", MonsterId.Hogma_Guard, 35, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("f_rokas_30.Id4", MonsterId.Hogma_Sorcerer, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_30.Id5", MonsterId.Hogma_Guard, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_30.Id6", MonsterId.Deadbornscab_Bow, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Hogma_Sorcerer Spawn Points
		AddSpawnPoint( "f_rokas_30.Id1", "f_rokas_30", Spot(386.1, 504.8, 9999));

		// Rootcrystal_05 Spawn Points
		AddSpawnPoint( "f_rokas_30.Id2", "f_rokas_30", Spot(1329, -429, 30));
		AddSpawnPoint( "f_rokas_30.Id2", "f_rokas_30", Spot(602, 354, 30));
		AddSpawnPoint( "f_rokas_30.Id2", "f_rokas_30", Spot(-622, -314, 30));
		AddSpawnPoint( "f_rokas_30.Id2", "f_rokas_30", Spot(-501.57, 7.04, 30));
		AddSpawnPoint( "f_rokas_30.Id2", "f_rokas_30", Spot(-118.13, 639, 30));
		AddSpawnPoint( "f_rokas_30.Id2", "f_rokas_30", Spot(460.26, 975.82, 30));
		AddSpawnPoint( "f_rokas_30.Id2", "f_rokas_30", Spot(396.29, 310.8, 30));
		AddSpawnPoint( "f_rokas_30.Id2", "f_rokas_30", Spot(1277.84, 534.1, 30));
		AddSpawnPoint( "f_rokas_30.Id2", "f_rokas_30", Spot(1164.01, -117.04, 30));
		AddSpawnPoint( "f_rokas_30.Id2", "f_rokas_30", Spot(950.75, -756.94, 30));
		AddSpawnPoint( "f_rokas_30.Id2", "f_rokas_30", Spot(774.88, -952.11, 30));
		AddSpawnPoint( "f_rokas_30.Id2", "f_rokas_30", Spot(-1195.3, -905.35, 30));
		AddSpawnPoint( "f_rokas_30.Id2", "f_rokas_30", Spot(-1336.83, 65.31, 30));

		// Hogma_Guard Spawn Points
		AddSpawnPoint( "f_rokas_30.Id3", "f_rokas_30", Spot(304, 433, 9999));

		// Hogma_Sorcerer Spawn Points
		AddSpawnPoint( "f_rokas_30.Id4", "f_rokas_30", Spot(1337.2333, 322.29224, 50));
		AddSpawnPoint( "f_rokas_30.Id4", "f_rokas_30", Spot(-121.14088, 457.78503, 50));
		AddSpawnPoint( "f_rokas_30.Id4", "f_rokas_30", Spot(504.19022, 316.59692, 50));
		AddSpawnPoint( "f_rokas_30.Id4", "f_rokas_30", Spot(455.27246, 535.0186, 50));
		AddSpawnPoint( "f_rokas_30.Id4", "f_rokas_30", Spot(564.8063, 1118.2946, 50));
		AddSpawnPoint( "f_rokas_30.Id4", "f_rokas_30", Spot(1371.2635, 470.9262, 50));

		// Hogma_Guard Spawn Points
		AddSpawnPoint( "f_rokas_30.Id5", "f_rokas_30", Spot(-139.21625, 413.23526, 40));
		AddSpawnPoint( "f_rokas_30.Id5", "f_rokas_30", Spot(-283.17313, 435.34717, 40));
		AddSpawnPoint( "f_rokas_30.Id5", "f_rokas_30", Spot(-206.77402, 596.2143, 40));
		AddSpawnPoint( "f_rokas_30.Id5", "f_rokas_30", Spot(471.5789, 1097.657, 40));
		AddSpawnPoint( "f_rokas_30.Id5", "f_rokas_30", Spot(548.57367, 970.8169, 40));
		AddSpawnPoint( "f_rokas_30.Id5", "f_rokas_30", Spot(654.37054, 1129.749, 40));
		AddSpawnPoint( "f_rokas_30.Id5", "f_rokas_30", Spot(554.26794, 505.32825, 40));
		AddSpawnPoint( "f_rokas_30.Id5", "f_rokas_30", Spot(558.0981, 272.6226, 40));
		AddSpawnPoint( "f_rokas_30.Id5", "f_rokas_30", Spot(1336.0193, 396.2895, 40));
		AddSpawnPoint( "f_rokas_30.Id5", "f_rokas_30", Spot(1298.2888, 318.4502, 40));
		AddSpawnPoint( "f_rokas_30.Id5", "f_rokas_30", Spot(1196.2377, -382.3637, 40));
		AddSpawnPoint( "f_rokas_30.Id5", "f_rokas_30", Spot(1337.3138, -241.31873, 40));
		AddSpawnPoint( "f_rokas_30.Id5", "f_rokas_30", Spot(414.93057, 429.54648, 40));

		// Deadbornscab_Bow Spawn Points
		AddSpawnPoint( "f_rokas_30.Id6", "f_rokas_30", Spot(374.43402, 380.46857, 40));
		AddSpawnPoint( "f_rokas_30.Id6", "f_rokas_30", Spot(503.82892, 548.7589, 40));
		AddSpawnPoint( "f_rokas_30.Id6", "f_rokas_30", Spot(655.13727, 390.45117, 40));
		AddSpawnPoint( "f_rokas_30.Id6", "f_rokas_30", Spot(-144.18596, 432.7845, 40));
		AddSpawnPoint( "f_rokas_30.Id6", "f_rokas_30", Spot(-149.88814, 637.5887, 40));
		AddSpawnPoint( "f_rokas_30.Id6", "f_rokas_30", Spot(462.42242, 998.3613, 40));
		AddSpawnPoint( "f_rokas_30.Id6", "f_rokas_30", Spot(664.928, 1061.4113, 40));
		AddSpawnPoint( "f_rokas_30.Id6", "f_rokas_30", Spot(-175.04079, -54.433807, 40));
		AddSpawnPoint( "f_rokas_30.Id6", "f_rokas_30", Spot(-261.9177, -421.32758, 40));
		AddSpawnPoint( "f_rokas_30.Id6", "f_rokas_30", Spot(-586.1222, -404.72864, 40));
		AddSpawnPoint( "f_rokas_30.Id6", "f_rokas_30", Spot(-563.0482, -132.2731, 40));

	}
}
