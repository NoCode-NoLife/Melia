//--- Melia Script -----------------------------------------------------------
// Demonic Dwellings Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'ep15_2_d_nicopolis_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class Ep152DNicopolis2MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("ep15_2_d_nicopolis_2", MonsterId.Ep15_2_Papillon_Leader, Properties("MHP", 62078216, "MINPATK", 170000, "MAXPATK", 170000, "MINMATK", 170000, "MAXMATK", 170000, "DEF", 4500000, "MDEF", 4500000));
		AddPropertyOverrides("ep15_2_d_nicopolis_2", MonsterId.Ep15_2_Masma, Properties("MHP", 62078216, "MINPATK", 170000, "MAXPATK", 170000, "MINMATK", 170000, "MAXMATK", 170000, "DEF", 4500000, "MDEF", 4500000));
		AddPropertyOverrides("ep15_2_d_nicopolis_2", MonsterId.Ep15_2_Dark_Statue, Properties("MHP", 62078216, "MINPATK", 140000, "MAXPATK", 140000, "MINMATK", 140000, "MAXMATK", 140000, "DEF", 4500000, "MDEF", 4500000));
		AddPropertyOverrides("ep15_2_d_nicopolis_2", MonsterId.Boss_Slogutis_Q1, Properties("MHP", 216234656, "MINPATK", 180000, "MAXPATK", 180000, "MINMATK", 180000, "MAXMATK", 180000, "DEF", 4500000, "MDEF", 4500000));

		// Monster Spawners ---------------------------------

		AddSpawner("ep15_2_d_nicopolis_2.Id1", MonsterId.Ep15_2_Papillon_Leader, min: 8, max: 10, respawn: TimeSpan.FromMilliseconds(15000));
		AddSpawner("ep15_2_d_nicopolis_2.Id2", MonsterId.Ep15_2_Dark_Statue, min: 23, max: 30, respawn: TimeSpan.FromMilliseconds(15000));
		AddSpawner("ep15_2_d_nicopolis_2.Id3", MonsterId.Ep15_2_Masma, min: 8, max: 10, respawn: TimeSpan.FromMilliseconds(15000));

		// Monster Spawn Points -----------------------------

		// 'Ep15_2_Papillon_Leader' GenType 1 Spawn Points
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id1", "ep15_2_d_nicopolis_2", Rectangle(-126, -1049, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id1", "ep15_2_d_nicopolis_2", Rectangle(125, -904, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id1", "ep15_2_d_nicopolis_2", Rectangle(-227, -996, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id1", "ep15_2_d_nicopolis_2", Rectangle(187, -984, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id1", "ep15_2_d_nicopolis_2", Rectangle(-159, -985, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id1", "ep15_2_d_nicopolis_2", Rectangle(-179, -910, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id1", "ep15_2_d_nicopolis_2", Rectangle(233, -1006, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id1", "ep15_2_d_nicopolis_2", Rectangle(217, -912, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id1", "ep15_2_d_nicopolis_2", Rectangle(354, -955, 20));

		// 'Ep15_2_Dark_Statue' GenType 5 Spawn Points
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id2", "ep15_2_d_nicopolis_2", Rectangle(492, -936, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id2", "ep15_2_d_nicopolis_2", Rectangle(543, -1036, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id2", "ep15_2_d_nicopolis_2", Rectangle(691, -1042, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id2", "ep15_2_d_nicopolis_2", Rectangle(651, -943, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id2", "ep15_2_d_nicopolis_2", Rectangle(859, -987, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id2", "ep15_2_d_nicopolis_2", Rectangle(845, -1060, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id2", "ep15_2_d_nicopolis_2", Rectangle(787, -938, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id2", "ep15_2_d_nicopolis_2", Rectangle(950, -865, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id2", "ep15_2_d_nicopolis_2", Rectangle(979, -1026, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id2", "ep15_2_d_nicopolis_2", Rectangle(928, -761, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id2", "ep15_2_d_nicopolis_2", Rectangle(965, -600, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id2", "ep15_2_d_nicopolis_2", Rectangle(855, -452, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id2", "ep15_2_d_nicopolis_2", Rectangle(758, -220, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id2", "ep15_2_d_nicopolis_2", Rectangle(828, -87, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id2", "ep15_2_d_nicopolis_2", Rectangle(1075, -60, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id2", "ep15_2_d_nicopolis_2", Rectangle(1176, -215, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id2", "ep15_2_d_nicopolis_2", Rectangle(1153, -395, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id2", "ep15_2_d_nicopolis_2", Rectangle(1112, -519, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id2", "ep15_2_d_nicopolis_2", Rectangle(996, -499, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id2", "ep15_2_d_nicopolis_2", Rectangle(177, 664, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id2", "ep15_2_d_nicopolis_2", Rectangle(281, 770, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id2", "ep15_2_d_nicopolis_2", Rectangle(246, 864, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id2", "ep15_2_d_nicopolis_2", Rectangle(-46, 720, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id2", "ep15_2_d_nicopolis_2", Rectangle(-190, 913, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id2", "ep15_2_d_nicopolis_2", Rectangle(-60, 1139, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id2", "ep15_2_d_nicopolis_2", Rectangle(201, 1044, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id2", "ep15_2_d_nicopolis_2", Rectangle(129, 631, 20));

		// 'Ep15_2_Masma' GenType 6 Spawn Points
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id3", "ep15_2_d_nicopolis_2", Rectangle(-960, -955, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id3", "ep15_2_d_nicopolis_2", Rectangle(-291, -921, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id3", "ep15_2_d_nicopolis_2", Rectangle(-352, -996, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id3", "ep15_2_d_nicopolis_2", Rectangle(-403, -909, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id3", "ep15_2_d_nicopolis_2", Rectangle(-530, -944, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id3", "ep15_2_d_nicopolis_2", Rectangle(-457, -1013, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id3", "ep15_2_d_nicopolis_2", Rectangle(-670, -1000, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id3", "ep15_2_d_nicopolis_2", Rectangle(-608, -910, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id3", "ep15_2_d_nicopolis_2", Rectangle(-556, -1010, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id3", "ep15_2_d_nicopolis_2", Rectangle(-750, -1019, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id3", "ep15_2_d_nicopolis_2", Rectangle(-709, -925, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id3", "ep15_2_d_nicopolis_2", Rectangle(-821, -949, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id3", "ep15_2_d_nicopolis_2", Rectangle(-859, -1034, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id3", "ep15_2_d_nicopolis_2", Rectangle(-952, -856, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id3", "ep15_2_d_nicopolis_2", Rectangle(-964, -719, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id3", "ep15_2_d_nicopolis_2", Rectangle(-964, -568, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id3", "ep15_2_d_nicopolis_2", Rectangle(-1095, -487, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id3", "ep15_2_d_nicopolis_2", Rectangle(-897, -468, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id3", "ep15_2_d_nicopolis_2", Rectangle(-746, -497, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id3", "ep15_2_d_nicopolis_2", Rectangle(-720, -290, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id3", "ep15_2_d_nicopolis_2", Rectangle(-733, -132, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id3", "ep15_2_d_nicopolis_2", Rectangle(-910, -103, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id3", "ep15_2_d_nicopolis_2", Rectangle(-1102, -127, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id3", "ep15_2_d_nicopolis_2", Rectangle(-1120, -279, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id3", "ep15_2_d_nicopolis_2", Rectangle(-920, -287, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id3", "ep15_2_d_nicopolis_2", Rectangle(61, 1114, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id3", "ep15_2_d_nicopolis_2", Rectangle(-242, 1054, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id3", "ep15_2_d_nicopolis_2", Rectangle(245, 934, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id3", "ep15_2_d_nicopolis_2", Rectangle(-116, 795, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id3", "ep15_2_d_nicopolis_2", Rectangle(91, 701, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id3", "ep15_2_d_nicopolis_2", Rectangle(228, 735, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id3", "ep15_2_d_nicopolis_2", Rectangle(128, 837, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id3", "ep15_2_d_nicopolis_2", Rectangle(-42, 856, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id3", "ep15_2_d_nicopolis_2", Rectangle(73, 1020, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_2.Id3", "ep15_2_d_nicopolis_2", Rectangle(-77, 1003, 20));
	}
}
