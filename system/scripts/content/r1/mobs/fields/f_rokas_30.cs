//--- Melia Script -----------------------------------------------------------
// King's Plateau Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_rokas_30'.
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

		AddSpawner("f_rokas_30.Id1", MonsterId.Hogma_Sorcerer, min: 12, max: 15);
		AddSpawner("f_rokas_30.Id2", MonsterId.Rootcrystal_05, min: 9, max: 12, respawn: TimeSpan.FromMilliseconds(5000));
		AddSpawner("f_rokas_30.Id3", MonsterId.Hogma_Guard, min: 27, max: 35, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("f_rokas_30.Id4", MonsterId.Hogma_Sorcerer, min: 9, max: 12);
		AddSpawner("f_rokas_30.Id5", MonsterId.Hogma_Guard, min: 12, max: 15);
		AddSpawner("f_rokas_30.Id6", MonsterId.Deadbornscab_Bow, min: 6, max: 8);

		// Monster Spawn Points -----------------------------

		// 'Hogma_Sorcerer' GenType 71 Spawn Points
		AddSpawnPoint("f_rokas_30.Id1", "f_rokas_30", Rectangle(386, 504, 9999));

		// 'Rootcrystal_05' GenType 600 Spawn Points
		AddSpawnPoint("f_rokas_30.Id2", "f_rokas_30", Rectangle(1329, -429, 30));
		AddSpawnPoint("f_rokas_30.Id2", "f_rokas_30", Rectangle(602, 354, 30));
		AddSpawnPoint("f_rokas_30.Id2", "f_rokas_30", Rectangle(-622, -314, 30));
		AddSpawnPoint("f_rokas_30.Id2", "f_rokas_30", Rectangle(-501, 7, 30));
		AddSpawnPoint("f_rokas_30.Id2", "f_rokas_30", Rectangle(-118, 639, 30));
		AddSpawnPoint("f_rokas_30.Id2", "f_rokas_30", Rectangle(460, 975, 30));
		AddSpawnPoint("f_rokas_30.Id2", "f_rokas_30", Rectangle(396, 310, 30));
		AddSpawnPoint("f_rokas_30.Id2", "f_rokas_30", Rectangle(1277, 534, 30));
		AddSpawnPoint("f_rokas_30.Id2", "f_rokas_30", Rectangle(1164, -117, 30));
		AddSpawnPoint("f_rokas_30.Id2", "f_rokas_30", Rectangle(950, -756, 30));
		AddSpawnPoint("f_rokas_30.Id2", "f_rokas_30", Rectangle(774, -952, 30));
		AddSpawnPoint("f_rokas_30.Id2", "f_rokas_30", Rectangle(-1195, -905, 30));
		AddSpawnPoint("f_rokas_30.Id2", "f_rokas_30", Rectangle(-1336, 65, 30));

		// 'Hogma_Guard' GenType 616 Spawn Points
		AddSpawnPoint("f_rokas_30.Id3", "f_rokas_30", Rectangle(304, 433, 9999));

		// 'Hogma_Sorcerer' GenType 658 Spawn Points
		AddSpawnPoint("f_rokas_30.Id4", "f_rokas_30", Rectangle(1337, 322, 50));
		AddSpawnPoint("f_rokas_30.Id4", "f_rokas_30", Rectangle(-121, 457, 50));
		AddSpawnPoint("f_rokas_30.Id4", "f_rokas_30", Rectangle(504, 316, 50));
		AddSpawnPoint("f_rokas_30.Id4", "f_rokas_30", Rectangle(455, 535, 50));
		AddSpawnPoint("f_rokas_30.Id4", "f_rokas_30", Rectangle(564, 1118, 50));
		AddSpawnPoint("f_rokas_30.Id4", "f_rokas_30", Rectangle(1371, 470, 50));

		// 'Hogma_Guard' GenType 659 Spawn Points
		AddSpawnPoint("f_rokas_30.Id5", "f_rokas_30", Rectangle(-139, 413, 40));
		AddSpawnPoint("f_rokas_30.Id5", "f_rokas_30", Rectangle(-283, 435, 40));
		AddSpawnPoint("f_rokas_30.Id5", "f_rokas_30", Rectangle(-206, 596, 40));
		AddSpawnPoint("f_rokas_30.Id5", "f_rokas_30", Rectangle(471, 1097, 40));
		AddSpawnPoint("f_rokas_30.Id5", "f_rokas_30", Rectangle(548, 970, 40));
		AddSpawnPoint("f_rokas_30.Id5", "f_rokas_30", Rectangle(654, 1129, 40));
		AddSpawnPoint("f_rokas_30.Id5", "f_rokas_30", Rectangle(554, 505, 40));
		AddSpawnPoint("f_rokas_30.Id5", "f_rokas_30", Rectangle(558, 272, 40));
		AddSpawnPoint("f_rokas_30.Id5", "f_rokas_30", Rectangle(1336, 396, 40));
		AddSpawnPoint("f_rokas_30.Id5", "f_rokas_30", Rectangle(1298, 318, 40));
		AddSpawnPoint("f_rokas_30.Id5", "f_rokas_30", Rectangle(1196, -382, 40));
		AddSpawnPoint("f_rokas_30.Id5", "f_rokas_30", Rectangle(1337, -241, 40));
		AddSpawnPoint("f_rokas_30.Id5", "f_rokas_30", Rectangle(414, 429, 40));

		// 'Deadbornscab_Bow' GenType 664 Spawn Points
		AddSpawnPoint("f_rokas_30.Id6", "f_rokas_30", Rectangle(374, 380, 40));
		AddSpawnPoint("f_rokas_30.Id6", "f_rokas_30", Rectangle(503, 548, 40));
		AddSpawnPoint("f_rokas_30.Id6", "f_rokas_30", Rectangle(655, 390, 40));
		AddSpawnPoint("f_rokas_30.Id6", "f_rokas_30", Rectangle(-144, 432, 40));
		AddSpawnPoint("f_rokas_30.Id6", "f_rokas_30", Rectangle(-149, 637, 40));
		AddSpawnPoint("f_rokas_30.Id6", "f_rokas_30", Rectangle(462, 998, 40));
		AddSpawnPoint("f_rokas_30.Id6", "f_rokas_30", Rectangle(664, 1061, 40));
		AddSpawnPoint("f_rokas_30.Id6", "f_rokas_30", Rectangle(-175, -54, 40));
		AddSpawnPoint("f_rokas_30.Id6", "f_rokas_30", Rectangle(-261, -421, 40));
		AddSpawnPoint("f_rokas_30.Id6", "f_rokas_30", Rectangle(-586, -404, 40));
		AddSpawnPoint("f_rokas_30.Id6", "f_rokas_30", Rectangle(-563, -132, 40));
	}
}
