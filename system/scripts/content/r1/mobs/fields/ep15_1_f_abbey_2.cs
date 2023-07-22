//--- Melia Script -----------------------------------------------------------
// Novaha Library Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'ep15_1_f_abbey_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class Ep151FAbbey2MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("ep15_1_f_abbey_2", MonsterId.Ep15_1_Goblin_Rider, Properties("MHP", 53625000, "MINPATK", 130000, "MAXPATK", 130000, "MINMATK", 130000, "MAXMATK", 130000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("ep15_1_f_abbey_2", MonsterId.Ep15_1_Goblin_Fighter, Properties("MHP", 53625000, "MINPATK", 130000, "MAXPATK", 130000, "MINMATK", 130000, "MAXMATK", 130000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("ep15_1_f_abbey_2", MonsterId.Ep15_1_Goblin_Saman, Properties("MHP", 53625000, "MINPATK", 130000, "MAXPATK", 130000, "MINMATK", 130000, "MAXMATK", 130000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("ep15_1_f_abbey_2", MonsterId.Boss_Blackdevilglove, Properties("MHP", 160875008, "MINPATK", 130000, "MAXPATK", 130000, "MINMATK", 130000, "MAXMATK", 130000, "DEF", 3000000, "MDEF", 3000000));

		// Monster Spawners ---------------------------------

		AddSpawner("ep15_1_f_abbey_2.Id1", MonsterId.Ep15_1_Goblin_Rider, min: 45, max: 60, respawn: TimeSpan.FromMilliseconds(15000));
		AddSpawner("ep15_1_f_abbey_2.Id2", MonsterId.Ep15_1_Goblin_Fighter, min: 45, max: 60, respawn: TimeSpan.FromMilliseconds(15000));
		AddSpawner("ep15_1_f_abbey_2.Id3", MonsterId.Ep15_1_Goblin_Saman, min: 45, max: 60, respawn: TimeSpan.FromMilliseconds(15000));

		// Monster Spawn Points -----------------------------

		// 'Ep15_1_Goblin_Rider' GenType 17 Spawn Points
		AddSpawnPoint("ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Rectangle(80, -142, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Rectangle(42, -34, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Rectangle(-179, -1167, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Rectangle(-45, -1108, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Rectangle(-202, -963, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Rectangle(-79, -708, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Rectangle(-195, -343, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Rectangle(-516, -158, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Rectangle(-285, -31, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Rectangle(-130, 108, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Rectangle(-79, 369, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Rectangle(119, 692, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Rectangle(-41, 845, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Rectangle(-316, 688, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Rectangle(-213, 858, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Rectangle(-335, 607, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Rectangle(473, -192, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Rectangle(365, -185, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Rectangle(70, -259, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Rectangle(-94, -358, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Rectangle(-366, -124, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Rectangle(-187, 77, 20));

		// 'Ep15_1_Goblin_Fighter' GenType 18 Spawn Points
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(-84, 352, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(188, 797, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(350, 738, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(95, 562, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(23, 782, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(-50, 124, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(-125, -525, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(-339, -263, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(-706, -126, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(-840, -157, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(-974, -177, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(-1019, -338, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(-1076, -97, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(-991, -21, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(-976, 50, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(-968, 111, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(-963, 279, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(-970, 463, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(144, -99, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(10, 30, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(-238, 29, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(1, -323, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(115, -1003, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(-271, -1072, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(-75, -949, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(67, -1135, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(-288, -384, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(-257, -143, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(-67, 481, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(-75, 626, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(-559, 639, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(-882, 755, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(-322, 922, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(-1213, 1548, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(-1304, 1801, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(-1273, 1665, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(567, 754, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(578, 971, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(567, 1070, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Rectangle(582, 885, 20));

		// 'Ep15_1_Goblin_Saman' GenType 19 Spawn Points
		AddSpawnPoint("ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Rectangle(-722, 632, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Rectangle(-663, 828, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Rectangle(-1164, 733, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Rectangle(-1197, 864, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Rectangle(-894, 863, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Rectangle(-986, 997, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Rectangle(-378, 800, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Rectangle(-180, 939, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Rectangle(-132, 688, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Rectangle(-528, 792, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Rectangle(-706, 745, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Rectangle(-898, 612, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Rectangle(-958, 467, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Rectangle(-966, 368, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Rectangle(-955, 279, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Rectangle(-1220, 631, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Rectangle(-1001, 1103, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Rectangle(-1038, 1290, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Rectangle(-1158, 1582, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Rectangle(-1203, 1707, 20));
		AddSpawnPoint("ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Rectangle(-1207, 1785, 20));
	}
}
