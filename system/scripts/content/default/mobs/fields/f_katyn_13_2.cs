//--- Melia Script -----------------------------------------------------------
// f_katyn_13_2
//
//--- Description -----------------------------------------------------------
// Sets up the f_katyn_13_2 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FKatyn132MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Populations
		var Swordmaster_1_1 = AddMonsterGenerator(MonsterId.Swordmaster, "f_katyn_13_2", 1);
		var Archermaster_2_1 = AddMonsterGenerator(MonsterId.Archermaster, "f_katyn_13_2", 1);
		var Wizardmaster_3_1 = AddMonsterGenerator(MonsterId.Wizardmaster, "f_katyn_13_2", 1);
		var NpcHealer_4_1 = AddMonsterGenerator(MonsterId.Npc_Healer, "f_katyn_13_2", 1);
		var MushroomBoyRed_5_40 = AddMonsterGenerator(MonsterId.Mushroom_Boy_Red, "f_katyn_13_2", 40);
		var MushroomEnt_6_20 = AddMonsterGenerator(MonsterId.Mushroom_Ent, "f_katyn_13_2", 20);
		var MushroomBoyRed_7_3 = AddMonsterGenerator(MonsterId.Mushroom_Boy_Red, "f_katyn_13_2", 3);
		var MushroomBoyRed_8_25 = AddMonsterGenerator(MonsterId.Mushroom_Boy_Red, "f_katyn_13_2", 25);

		// Monster Spawners
		AddSpawnPoint(Swordmaster_1_1, TimeSpan.FromMilliseconds(60000), "f_katyn_13_2", Spot(-403, -1878.91, 20));
		AddSpawnPoint(Archermaster_2_1, TimeSpan.FromMilliseconds(60000), "f_katyn_13_2", Spot(-313.73, -2113.53, 20));
		AddSpawnPoint(Wizardmaster_3_1, TimeSpan.FromMilliseconds(60000), "f_katyn_13_2", Spot(-312.74, -1747.03, 20));
		AddSpawnPoint(NpcHealer_4_1, TimeSpan.FromMilliseconds(60000), "f_katyn_13_2", Spot(-192.13, -2135.66, 20));
		AddSpawnPoint(MushroomBoyRed_5_40, TimeSpan.FromMilliseconds(15000), "f_katyn_13_2", Spot(-162.46576, -1998.9631, 9999));
		AddSpawnPoint(MushroomEnt_6_20, TimeSpan.FromMilliseconds(15000), "f_katyn_13_2", Spot(-1293.4271, 1492.9653, 9999));
		AddSpawnPoint(MushroomBoyRed_7_3, TimeSpan.FromMilliseconds(20000), "f_katyn_13_2", Spot(-227.26, -1965.17, 300));
		AddSpawnPoint(MushroomBoyRed_8_25, TimeSpan.FromMilliseconds(5000), "f_katyn_13_2", Spot(-216.52788, -1713.0366, 30));
		AddSpawnPoint(MushroomBoyRed_8_25, TimeSpan.FromMilliseconds(5000), "f_katyn_13_2", Spot(-327.94702, -1848.8572, 30));
		AddSpawnPoint(MushroomBoyRed_8_25, TimeSpan.FromMilliseconds(5000), "f_katyn_13_2", Spot(-232.98715, -2046.5466, 30));
		AddSpawnPoint(MushroomBoyRed_8_25, TimeSpan.FromMilliseconds(5000), "f_katyn_13_2", Spot(-70.585236, -2023.15, 30));
		AddSpawnPoint(MushroomBoyRed_8_25, TimeSpan.FromMilliseconds(5000), "f_katyn_13_2", Spot(-110.33405, -1855.1942, 30));
		AddSpawnPoint(MushroomBoyRed_8_25, TimeSpan.FromMilliseconds(5000), "f_katyn_13_2", Spot(-19.71203, -1690.4005, 30));
		AddSpawnPoint(MushroomBoyRed_8_25, TimeSpan.FromMilliseconds(5000), "f_katyn_13_2", Spot(55.91324, -1930.4796, 30));
		AddSpawnPoint(MushroomBoyRed_8_25, TimeSpan.FromMilliseconds(5000), "f_katyn_13_2", Spot(-360.7234, -2090.9502, 30));
		AddSpawnPoint(MushroomBoyRed_8_25, TimeSpan.FromMilliseconds(5000), "f_katyn_13_2", Spot(-595.2442, -2054.4976, 30));
		AddSpawnPoint(MushroomBoyRed_8_25, TimeSpan.FromMilliseconds(5000), "f_katyn_13_2", Spot(-54.833138, -1476.0273, 30));
		AddSpawnPoint(MushroomBoyRed_8_25, TimeSpan.FromMilliseconds(5000), "f_katyn_13_2", Spot(-40.26753, -1268.6481, 30));

	}
}
