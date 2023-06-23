//--- Melia Script -----------------------------------------------------------
// f_rokas_30
//
//--- Description -----------------------------------------------------------
// Sets up the f_rokas_30 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FRokas30MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_rokas_30", MonsterId.Hogma_Sorcerer, Properties("MHP", 53685, "MINPATK", 1191, "MAXPATK", 1366, "MINMATK", 1191, "MAXMATK", 1366, "DEF", 223, "MDEF", 223));
		AddPropertyOverrides("f_rokas_30", MonsterId.Hogma_Guard, Properties("MHP", 54060, "MINPATK", 1196, "MAXPATK", 1372, "MINMATK", 1196, "MAXMATK", 1372, "DEF", 229, "MDEF", 229));
		AddPropertyOverrides("f_rokas_30", MonsterId.Deadbornscab_Bow, Properties("MHP", 54467, "MINPATK", 1201, "MAXPATK", 1378, "MINMATK", 1201, "MAXMATK", 1378, "DEF", 235, "MDEF", 235));

		// Monster Populations
		AddMonsterPopulation("f_rokas_30", "population_hogma_sorcerer_1", 15);
		AddMonsterPopulation("f_rokas_30", "population_rootcrystal_05_2", 12);
		AddMonsterPopulation("f_rokas_30", "population_hogma_guard_3", 35);
		AddMonsterPopulation("f_rokas_30", "population_hogma_sorcerer_4", 12);
		AddMonsterPopulation("f_rokas_30", "population_hogma_guard_5", 15);
		AddMonsterPopulation("f_rokas_30", "population_deadbornscab_bow_6", 8);

		// RootCrystal Spawners
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_2", TimeSpan.FromMilliseconds(5000), "f_rokas_30", Spot(1329, -429, 30));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_2", TimeSpan.FromMilliseconds(5000), "f_rokas_30", Spot(602, 354, 30));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_2", TimeSpan.FromMilliseconds(5000), "f_rokas_30", Spot(-622, -314, 30));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_2", TimeSpan.FromMilliseconds(5000), "f_rokas_30", Spot(-501.57, 7.04, 30));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_2", TimeSpan.FromMilliseconds(5000), "f_rokas_30", Spot(-118.13, 639, 30));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_2", TimeSpan.FromMilliseconds(5000), "f_rokas_30", Spot(460.26, 975.82, 30));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_2", TimeSpan.FromMilliseconds(5000), "f_rokas_30", Spot(396.29, 310.8, 30));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_2", TimeSpan.FromMilliseconds(5000), "f_rokas_30", Spot(1277.84, 534.1, 30));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_2", TimeSpan.FromMilliseconds(5000), "f_rokas_30", Spot(1164.01, -117.04, 30));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_2", TimeSpan.FromMilliseconds(5000), "f_rokas_30", Spot(950.75, -756.94, 30));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_2", TimeSpan.FromMilliseconds(5000), "f_rokas_30", Spot(774.88, -952.11, 30));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_2", TimeSpan.FromMilliseconds(5000), "f_rokas_30", Spot(-1195.3, -905.35, 30));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_2", TimeSpan.FromMilliseconds(5000), "f_rokas_30", Spot(-1336.83, 65.31, 30));

		// Monster Spawners
		AddSpawner(MonsterId.Hogma_Sorcerer, "population_hogma_sorcerer_1", TimeSpan.FromMilliseconds(0), "f_rokas_30", Spot(386.1, 504.8, 9999));
		AddSpawner(MonsterId.Hogma_Guard, "population_hogma_guard_3", TimeSpan.FromMilliseconds(30000), "f_rokas_30", Spot(304, 433, 9999));
		AddSpawner(MonsterId.Hogma_Sorcerer, "population_hogma_sorcerer_4", TimeSpan.FromMilliseconds(0), "f_rokas_30", Spot(1337.2333, 322.29224, 50));
		AddSpawner(MonsterId.Hogma_Sorcerer, "population_hogma_sorcerer_4", TimeSpan.FromMilliseconds(0), "f_rokas_30", Spot(-121.14088, 457.78503, 50));
		AddSpawner(MonsterId.Hogma_Sorcerer, "population_hogma_sorcerer_4", TimeSpan.FromMilliseconds(0), "f_rokas_30", Spot(504.19022, 316.59692, 50));
		AddSpawner(MonsterId.Hogma_Sorcerer, "population_hogma_sorcerer_4", TimeSpan.FromMilliseconds(0), "f_rokas_30", Spot(455.27246, 535.0186, 50));
		AddSpawner(MonsterId.Hogma_Sorcerer, "population_hogma_sorcerer_4", TimeSpan.FromMilliseconds(0), "f_rokas_30", Spot(564.8063, 1118.2946, 50));
		AddSpawner(MonsterId.Hogma_Sorcerer, "population_hogma_sorcerer_4", TimeSpan.FromMilliseconds(0), "f_rokas_30", Spot(1371.2635, 470.9262, 50));
		AddSpawner(MonsterId.Hogma_Guard, "population_hogma_guard_5", TimeSpan.FromMilliseconds(0), "f_rokas_30", Spot(-139.21625, 413.23526, 40));
		AddSpawner(MonsterId.Hogma_Guard, "population_hogma_guard_5", TimeSpan.FromMilliseconds(0), "f_rokas_30", Spot(-283.17313, 435.34717, 40));
		AddSpawner(MonsterId.Hogma_Guard, "population_hogma_guard_5", TimeSpan.FromMilliseconds(0), "f_rokas_30", Spot(-206.77402, 596.2143, 40));
		AddSpawner(MonsterId.Hogma_Guard, "population_hogma_guard_5", TimeSpan.FromMilliseconds(0), "f_rokas_30", Spot(471.5789, 1097.657, 40));
		AddSpawner(MonsterId.Hogma_Guard, "population_hogma_guard_5", TimeSpan.FromMilliseconds(0), "f_rokas_30", Spot(548.57367, 970.8169, 40));
		AddSpawner(MonsterId.Hogma_Guard, "population_hogma_guard_5", TimeSpan.FromMilliseconds(0), "f_rokas_30", Spot(654.37054, 1129.749, 40));
		AddSpawner(MonsterId.Hogma_Guard, "population_hogma_guard_5", TimeSpan.FromMilliseconds(0), "f_rokas_30", Spot(554.26794, 505.32825, 40));
		AddSpawner(MonsterId.Hogma_Guard, "population_hogma_guard_5", TimeSpan.FromMilliseconds(0), "f_rokas_30", Spot(558.0981, 272.6226, 40));
		AddSpawner(MonsterId.Hogma_Guard, "population_hogma_guard_5", TimeSpan.FromMilliseconds(0), "f_rokas_30", Spot(1336.0193, 396.2895, 40));
		AddSpawner(MonsterId.Hogma_Guard, "population_hogma_guard_5", TimeSpan.FromMilliseconds(0), "f_rokas_30", Spot(1298.2888, 318.4502, 40));
		AddSpawner(MonsterId.Hogma_Guard, "population_hogma_guard_5", TimeSpan.FromMilliseconds(0), "f_rokas_30", Spot(1196.2377, -382.3637, 40));
		AddSpawner(MonsterId.Hogma_Guard, "population_hogma_guard_5", TimeSpan.FromMilliseconds(0), "f_rokas_30", Spot(1337.3138, -241.31873, 40));
		AddSpawner(MonsterId.Hogma_Guard, "population_hogma_guard_5", TimeSpan.FromMilliseconds(0), "f_rokas_30", Spot(414.93057, 429.54648, 40));
		AddSpawner(MonsterId.Deadbornscab_Bow, "population_deadbornscab_bow_6", TimeSpan.FromMilliseconds(0), "f_rokas_30", Spot(374.43402, 380.46857, 40));
		AddSpawner(MonsterId.Deadbornscab_Bow, "population_deadbornscab_bow_6", TimeSpan.FromMilliseconds(0), "f_rokas_30", Spot(503.82892, 548.7589, 40));
		AddSpawner(MonsterId.Deadbornscab_Bow, "population_deadbornscab_bow_6", TimeSpan.FromMilliseconds(0), "f_rokas_30", Spot(655.13727, 390.45117, 40));
		AddSpawner(MonsterId.Deadbornscab_Bow, "population_deadbornscab_bow_6", TimeSpan.FromMilliseconds(0), "f_rokas_30", Spot(-144.18596, 432.7845, 40));
		AddSpawner(MonsterId.Deadbornscab_Bow, "population_deadbornscab_bow_6", TimeSpan.FromMilliseconds(0), "f_rokas_30", Spot(-149.88814, 637.5887, 40));
		AddSpawner(MonsterId.Deadbornscab_Bow, "population_deadbornscab_bow_6", TimeSpan.FromMilliseconds(0), "f_rokas_30", Spot(462.42242, 998.3613, 40));
		AddSpawner(MonsterId.Deadbornscab_Bow, "population_deadbornscab_bow_6", TimeSpan.FromMilliseconds(0), "f_rokas_30", Spot(664.928, 1061.4113, 40));
		AddSpawner(MonsterId.Deadbornscab_Bow, "population_deadbornscab_bow_6", TimeSpan.FromMilliseconds(0), "f_rokas_30", Spot(-175.04079, -54.433807, 40));
		AddSpawner(MonsterId.Deadbornscab_Bow, "population_deadbornscab_bow_6", TimeSpan.FromMilliseconds(0), "f_rokas_30", Spot(-261.9177, -421.32758, 40));
		AddSpawner(MonsterId.Deadbornscab_Bow, "population_deadbornscab_bow_6", TimeSpan.FromMilliseconds(0), "f_rokas_30", Spot(-586.1222, -404.72864, 40));
		AddSpawner(MonsterId.Deadbornscab_Bow, "population_deadbornscab_bow_6", TimeSpan.FromMilliseconds(0), "f_rokas_30", Spot(-563.0482, -132.2731, 40));

	}
}
