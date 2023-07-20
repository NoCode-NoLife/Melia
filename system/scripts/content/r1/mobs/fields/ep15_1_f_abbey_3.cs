//--- Melia Script -----------------------------------------------------------
// The Confessional Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'ep15_1_f_abbey_3'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class Ep151FAbbey3MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("ep15_1_f_abbey_3", MonsterId.Ep15_1_Goblin_Fighter, Properties("MHP", 58987500, "MINPATK", 140000, "MAXPATK", 140000, "MINMATK", 140000, "MAXMATK", 140000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("ep15_1_f_abbey_3", MonsterId.Ep15_1_Goblin_Saman, Properties("MHP", 58987500, "MINPATK", 140000, "MAXPATK", 140000, "MINMATK", 140000, "MAXMATK", 140000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("ep15_1_f_abbey_3", MonsterId.Ep15_1_Goblin_Elite, Properties("MHP", 58987500, "MINPATK", 140000, "MAXPATK", 140000, "MINMATK", 140000, "MAXMATK", 140000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("ep15_1_f_abbey_3", MonsterId.Boss_Roze_Q1, Properties("MHP", 176962496, "MINPATK", 140000, "MAXPATK", 140000, "MINMATK", 140000, "MAXMATK", 140000, "DEF", 3000000, "MDEF", 3000000));

		// Monster Spawners ---------------------------------

		AddSpawner("ep15_1_f_abbey_3.Id1", MonsterId.Ep15_1_Goblin_Saman, 17, 22, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("ep15_1_f_abbey_3.Id2", MonsterId.Ep15_1_Goblin_Fighter, 18, 24, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("ep15_1_f_abbey_3.Id3", MonsterId.Ep15_1_Goblin_Elite, 15, 20, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Ep15_1_Goblin_Saman' GenType 3 Spawn Points
		AddSpawnPoint("ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Rectangle(34, -956, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Rectangle(78, -860, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Rectangle(-34, -871, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Rectangle(-108, -968, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Rectangle(105, -691, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Rectangle(-111, -718, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Rectangle(-16, -552, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Rectangle(5, -433, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Rectangle(251, -846, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Rectangle(-212, -956, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Rectangle(25, -350, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Rectangle(-184, -646, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Rectangle(195, -587, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Rectangle(-179, -815, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Rectangle(232, -731, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Rectangle(-4, 50, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Rectangle(114, 218, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Rectangle(616, 169, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Rectangle(-244, 1293, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Rectangle(-123, 1260, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Rectangle(240, 1370, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Rectangle(738, -162, 20));

		// 'Ep15_1_Goblin_Fighter' GenType 4 Spawn Points
		AddSpawnPoint("ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Rectangle(-182, 271, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Rectangle(-192, -65, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Rectangle(0, -52, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Rectangle(124, -70, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Rectangle(60, 127, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Rectangle(-166, 89, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Rectangle(139, 117, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Rectangle(8, -462, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Rectangle(-391, 195, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Rectangle(-711, 134, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Rectangle(-831, -135, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Rectangle(-845, -385, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Rectangle(401, 149, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Rectangle(623, 150, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Rectangle(751, 132, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Rectangle(746, -122, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Rectangle(5, 532, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Rectangle(-13, 923, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Rectangle(-37, 1093, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Rectangle(72, -726, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Rectangle(15, -1024, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Rectangle(-24, 1207, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Rectangle(141, 1198, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Rectangle(-160, 1151, 20));

		// 'Ep15_1_Goblin_Elite' GenType 5 Spawn Points
		AddSpawnPoint("ep15_1_f_abbey_3.Id3", "ep15_1_f_abbey_3", Rectangle(-139, 1103, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id3", "ep15_1_f_abbey_3", Rectangle(6, 692, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id3", "ep15_1_f_abbey_3", Rectangle(-78, 275, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id3", "ep15_1_f_abbey_3", Rectangle(-68, 19, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id3", "ep15_1_f_abbey_3", Rectangle(9, -383, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id3", "ep15_1_f_abbey_3", Rectangle(-404, 162, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id3", "ep15_1_f_abbey_3", Rectangle(-766, 75, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id3", "ep15_1_f_abbey_3", Rectangle(-845, -409, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id3", "ep15_1_f_abbey_3", Rectangle(391, 167, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id3", "ep15_1_f_abbey_3", Rectangle(702, 186, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id3", "ep15_1_f_abbey_3", Rectangle(745, -166, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id3", "ep15_1_f_abbey_3", Rectangle(596, -436, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id3", "ep15_1_f_abbey_3", Rectangle(869, -427, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id3", "ep15_1_f_abbey_3", Rectangle(726, -320, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id3", "ep15_1_f_abbey_3", Rectangle(163, -777, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id3", "ep15_1_f_abbey_3", Rectangle(-110, -688, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id3", "ep15_1_f_abbey_3", Rectangle(-911, -581, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id3", "ep15_1_f_abbey_3", Rectangle(104, 112, 20));
		AddSpawnPoint("ep15_1_f_abbey_3.Id3", "ep15_1_f_abbey_3", Rectangle(39, 1282, 20));
	}
}
