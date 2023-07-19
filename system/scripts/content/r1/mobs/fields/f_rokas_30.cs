//--- Melia Script -----------------------------------------------------------
// f_rokas_30
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'King's Plateau' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FRokas30MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_rokas_30", MonsterId.Hogma_Sorcerer, Properties("MHP", 53685, "MINPATK", 1191, "MAXPATK", 1366, "MINMATK", 1191, "MAXMATK", 1366, "DEF", 223, "MDEF", 223));
		AddPropertyOverrides("f_rokas_30", MonsterId.Hogma_Guard, Properties("MHP", 54060, "MINPATK", 1196, "MAXPATK", 1372, "MINMATK", 1196, "MAXMATK", 1372, "DEF", 229, "MDEF", 229));
		AddPropertyOverrides("f_rokas_30", MonsterId.Deadbornscab_Bow, Properties("MHP", 54467, "MINPATK", 1201, "MAXPATK", 1378, "MINMATK", 1201, "MAXMATK", 1378, "DEF", 235, "MDEF", 235));
		AddPropertyOverrides("f_rokas_30", MonsterId.Hogma_Warrior, Properties("MHP", 54904, "MINPATK", 1207, "MAXPATK", 1385, "MINMATK", 1207, "MAXMATK", 1385, "DEF", 242, "MDEF", 242));
		AddPropertyOverrides("f_rokas_30", MonsterId.Hogma_Combat, Properties("MHP", 55369, "MINPATK", 1213, "MAXPATK", 1392, "MINMATK", 1213, "MAXMATK", 1392, "DEF", 249, "MDEF", 249));
		AddPropertyOverrides("f_rokas_30", MonsterId.Hogma_Archer, Properties("MHP", 55862, "MINPATK", 1219, "MAXPATK", 1400, "MINMATK", 1219, "MAXMATK", 1400, "DEF", 256, "MDEF", 256));

		// Monster Spawners ---------------------------------

		AddSpawner("f_rokas_30.Id1", MonsterId.Hogma_Sorcerer, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_30.Id2", MonsterId.Rootcrystal_05, 9, 12, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_rokas_30.Id3", MonsterId.Hogma_Guard, 27, 35, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("f_rokas_30.Id4", MonsterId.Hogma_Sorcerer, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_30.Id5", MonsterId.Hogma_Guard, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_30.Id6", MonsterId.Deadbornscab_Bow, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Hogma_Sorcerer' GenType 71 Spawn Points
		AddSpawnPoint("f_rokas_30.Id1", "f_rokas_30", Rectangle(386.1, 504.8, 9999));

		// 'Rootcrystal_05' GenType 600 Spawn Points
		AddSpawnPoint("f_rokas_30.Id2", "f_rokas_30", Rectangle(1329, -429, 30));
		AddSpawnPoint("f_rokas_30.Id2", "f_rokas_30", Rectangle(602, 354, 30));
		AddSpawnPoint("f_rokas_30.Id2", "f_rokas_30", Rectangle(-622, -314, 30));
		AddSpawnPoint("f_rokas_30.Id2", "f_rokas_30", Rectangle(-501.57, 7.04, 30));
		AddSpawnPoint("f_rokas_30.Id2", "f_rokas_30", Rectangle(-118.13, 639, 30));
		AddSpawnPoint("f_rokas_30.Id2", "f_rokas_30", Rectangle(460.26, 975.82, 30));
		AddSpawnPoint("f_rokas_30.Id2", "f_rokas_30", Rectangle(396.29, 310.8, 30));
		AddSpawnPoint("f_rokas_30.Id2", "f_rokas_30", Rectangle(1277.84, 534.1, 30));
		AddSpawnPoint("f_rokas_30.Id2", "f_rokas_30", Rectangle(1164.01, -117.04, 30));
		AddSpawnPoint("f_rokas_30.Id2", "f_rokas_30", Rectangle(950.75, -756.94, 30));
		AddSpawnPoint("f_rokas_30.Id2", "f_rokas_30", Rectangle(774.88, -952.11, 30));
		AddSpawnPoint("f_rokas_30.Id2", "f_rokas_30", Rectangle(-1195.3, -905.35, 30));
		AddSpawnPoint("f_rokas_30.Id2", "f_rokas_30", Rectangle(-1336.83, 65.31, 30));

		// 'Hogma_Guard' GenType 616 Spawn Points
		AddSpawnPoint("f_rokas_30.Id3", "f_rokas_30", Rectangle(304, 433, 9999));

		// 'Hogma_Sorcerer' GenType 658 Spawn Points
		AddSpawnPoint("f_rokas_30.Id4", "f_rokas_30", Rectangle(1337.2333, 322.29224, 50));
		AddSpawnPoint("f_rokas_30.Id4", "f_rokas_30", Rectangle(-121.14088, 457.78503, 50));
		AddSpawnPoint("f_rokas_30.Id4", "f_rokas_30", Rectangle(504.19022, 316.59692, 50));
		AddSpawnPoint("f_rokas_30.Id4", "f_rokas_30", Rectangle(455.27246, 535.0186, 50));
		AddSpawnPoint("f_rokas_30.Id4", "f_rokas_30", Rectangle(564.8063, 1118.2946, 50));
		AddSpawnPoint("f_rokas_30.Id4", "f_rokas_30", Rectangle(1371.2635, 470.9262, 50));

		// 'Hogma_Guard' GenType 659 Spawn Points
		AddSpawnPoint("f_rokas_30.Id5", "f_rokas_30", Rectangle(-139.21625, 413.23526, 40));
		AddSpawnPoint("f_rokas_30.Id5", "f_rokas_30", Rectangle(-283.17313, 435.34717, 40));
		AddSpawnPoint("f_rokas_30.Id5", "f_rokas_30", Rectangle(-206.77402, 596.2143, 40));
		AddSpawnPoint("f_rokas_30.Id5", "f_rokas_30", Rectangle(471.5789, 1097.657, 40));
		AddSpawnPoint("f_rokas_30.Id5", "f_rokas_30", Rectangle(548.57367, 970.8169, 40));
		AddSpawnPoint("f_rokas_30.Id5", "f_rokas_30", Rectangle(654.37054, 1129.749, 40));
		AddSpawnPoint("f_rokas_30.Id5", "f_rokas_30", Rectangle(554.26794, 505.32825, 40));
		AddSpawnPoint("f_rokas_30.Id5", "f_rokas_30", Rectangle(558.0981, 272.6226, 40));
		AddSpawnPoint("f_rokas_30.Id5", "f_rokas_30", Rectangle(1336.0193, 396.2895, 40));
		AddSpawnPoint("f_rokas_30.Id5", "f_rokas_30", Rectangle(1298.2888, 318.4502, 40));
		AddSpawnPoint("f_rokas_30.Id5", "f_rokas_30", Rectangle(1196.2377, -382.3637, 40));
		AddSpawnPoint("f_rokas_30.Id5", "f_rokas_30", Rectangle(1337.3138, -241.31873, 40));
		AddSpawnPoint("f_rokas_30.Id5", "f_rokas_30", Rectangle(414.93057, 429.54648, 40));

		// 'Deadbornscab_Bow' GenType 664 Spawn Points
		AddSpawnPoint("f_rokas_30.Id6", "f_rokas_30", Rectangle(374.43402, 380.46857, 40));
		AddSpawnPoint("f_rokas_30.Id6", "f_rokas_30", Rectangle(503.82892, 548.7589, 40));
		AddSpawnPoint("f_rokas_30.Id6", "f_rokas_30", Rectangle(655.13727, 390.45117, 40));
		AddSpawnPoint("f_rokas_30.Id6", "f_rokas_30", Rectangle(-144.18596, 432.7845, 40));
		AddSpawnPoint("f_rokas_30.Id6", "f_rokas_30", Rectangle(-149.88814, 637.5887, 40));
		AddSpawnPoint("f_rokas_30.Id6", "f_rokas_30", Rectangle(462.42242, 998.3613, 40));
		AddSpawnPoint("f_rokas_30.Id6", "f_rokas_30", Rectangle(664.928, 1061.4113, 40));
		AddSpawnPoint("f_rokas_30.Id6", "f_rokas_30", Rectangle(-175.04079, -54.433807, 40));
		AddSpawnPoint("f_rokas_30.Id6", "f_rokas_30", Rectangle(-261.9177, -421.32758, 40));
		AddSpawnPoint("f_rokas_30.Id6", "f_rokas_30", Rectangle(-586.1222, -404.72864, 40));
		AddSpawnPoint("f_rokas_30.Id6", "f_rokas_30", Rectangle(-563.0482, -132.2731, 40));
	}
}
