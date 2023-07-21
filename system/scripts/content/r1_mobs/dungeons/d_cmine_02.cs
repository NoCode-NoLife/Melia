//--- Melia Script -----------------------------------------------------------
// Crystal Mine 2F Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_cmine_02'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DCmine02MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_cmine_02", MonsterId.Yekubite, Properties("MHP", 7640, "MINPATK", 430, "MAXPATK", 465, "MINMATK", 430, "MAXMATK", 465, "DEF", 43, "MDEF", 43));
		AddPropertyOverrides("d_cmine_02", MonsterId.Shredded, Properties("MHP", 8104, "MINPATK", 451, "MAXPATK", 488, "MINMATK", 451, "MAXMATK", 488, "DEF", 45, "MDEF", 45));
		AddPropertyOverrides("d_cmine_02", MonsterId.Bubbe_Mage_Normal, Properties("MHP", 8581, "MINPATK", 473, "MAXPATK", 511, "MINMATK", 473, "MAXMATK", 511, "DEF", 47, "MDEF", 47));
		AddPropertyOverrides("d_cmine_02", MonsterId.Goblin_Archer, Properties("MHP", 9070, "MINPATK", 495, "MAXPATK", 535, "MINMATK", 495, "MAXMATK", 535, "DEF", 49, "MDEF", 49));
		AddPropertyOverrides("d_cmine_02", MonsterId.Boss_Carapace, Properties("MHP", 43066, "MINPATK", 933, "MAXPATK", 1008, "MINMATK", 933, "MAXMATK", 1008, "DEF", 93, "MDEF", 93));
		AddPropertyOverrides("d_cmine_02", MonsterId.Boss_Stone_Whale, Properties("MHP", 45372, "MINPATK", 975, "MAXPATK", 1053, "MINMATK", 975, "MAXMATK", 1053, "DEF", 98, "MDEF", 98));
		AddPropertyOverrides("d_cmine_02", MonsterId.Bat, Properties("MHP", 10607, "MINPATK", 565, "MAXPATK", 611, "MINMATK", 565, "MAXMATK", 611, "DEF", 57, "MDEF", 57));

		// Monster Spawners ---------------------------------

		AddSpawner("d_cmine_02.Id1", MonsterId.Rootcrystal_01, 23, 30, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_cmine_02.Id2", MonsterId.Yekubite, 4, 5, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cmine_02.Id3", MonsterId.Yekubite, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cmine_02.Id4", MonsterId.Shredded, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cmine_02.Id5", MonsterId.Bubbe_Mage_Normal, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cmine_02.Id6", MonsterId.Goblin_Archer, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 500 Spawn Points
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(-2426, -778, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(-1769, -31, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(-1894, -86, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(-1509, 155, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(-1240, 98, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(-1373, -185, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(-1241, -414, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(-1200, -701, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(-1347, -879, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(-694, -797, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(-1035, -1055, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(-958, -867, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(-1457, 229, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(-1504, 755, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(-1585, 1116, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(-1748, 997, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(-1592, 748, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(-1703, 762, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(-1375, 916, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(-1015, 123, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(-580, 341, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(-272, 8, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(-154, -275, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(69, -156, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(-220, 774, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(-139, 945, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(-335, 981, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(-772, 1174, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(-592, 854, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(650, 33, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(687, -258, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(685, -503, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(1097, -340, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(968, -765, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(1717, -567, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(1621, -728, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(1239, -1599, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(1963, -1420, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(2161, -1289, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(2060, -1508, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(491, 1406, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(477, 1107, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(997, 1124, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(984, 1242, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(947, 303, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(1503, 221, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(648, 631, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(1378, 444, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(1538, 661, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(1701, 833, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(2059, 1514, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(1743, 1516, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(1969, 1616, 10));
		AddSpawnPoint("d_cmine_02.Id1", "d_cmine_02", Rectangle(1679, 1380, 10));

		// 'Yekubite' GenType 515 Spawn Points
		AddSpawnPoint("d_cmine_02.Id2", "d_cmine_02", Rectangle(-1094, -1105, 30));
		AddSpawnPoint("d_cmine_02.Id2", "d_cmine_02", Rectangle(-1955, -137, 30));
		AddSpawnPoint("d_cmine_02.Id2", "d_cmine_02", Rectangle(-1059, 31, 30));
		AddSpawnPoint("d_cmine_02.Id2", "d_cmine_02", Rectangle(-235, -109, 30));
		AddSpawnPoint("d_cmine_02.Id2", "d_cmine_02", Rectangle(-146, 82, 30));
		AddSpawnPoint("d_cmine_02.Id2", "d_cmine_02", Rectangle(-1132, -736, 30));
		AddSpawnPoint("d_cmine_02.Id2", "d_cmine_02", Rectangle(0, -200, 30));
		AddSpawnPoint("d_cmine_02.Id2", "d_cmine_02", Rectangle(997, 1113, 30));
		AddSpawnPoint("d_cmine_02.Id2", "d_cmine_02", Rectangle(992, 1310, 30));
		AddSpawnPoint("d_cmine_02.Id2", "d_cmine_02", Rectangle(853, 1005, 30));
		AddSpawnPoint("d_cmine_02.Id2", "d_cmine_02", Rectangle(659, 1034, 30));

		// 'Yekubite' GenType 516 Spawn Points
		AddSpawnPoint("d_cmine_02.Id3", "d_cmine_02", Rectangle(-133, -27, 9999));

		// 'Shredded' GenType 531 Spawn Points
		AddSpawnPoint("d_cmine_02.Id4", "d_cmine_02", Rectangle(-1494, 895, 9999));

		// 'Bubbe_Mage_Normal' GenType 532 Spawn Points
		AddSpawnPoint("d_cmine_02.Id5", "d_cmine_02", Rectangle(-101, -336, 9999));

		// 'Goblin_Archer' GenType 535 Spawn Points
		AddSpawnPoint("d_cmine_02.Id6", "d_cmine_02", Rectangle(-587, 318, 9999));
	}
}
