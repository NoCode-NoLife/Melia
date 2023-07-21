//--- Melia Script -----------------------------------------------------------
// Ashaq Underground Prison Containment Area Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'ep13_2_d_prison_3'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class Ep132DPrison3MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("ep13_2_d_prison_3", MonsterId.Episode13_2_Wendigo_Dump, Properties("MHP", 1007073, "MINPATK", 13451, "MAXPATK", 16434, "MINMATK", 13451, "MAXMATK", 16434, "DEF", 485122, "MDEF", 485122));
		AddPropertyOverrides("ep13_2_d_prison_3", MonsterId.Episode13_2_Wendigo, Properties("MHP", 1013010, "MINPATK", 13527, "MAXPATK", 16528, "MINMATK", 13527, "MAXMATK", 16528, "DEF", 492826, "MDEF", 492826));
		AddPropertyOverrides("ep13_2_d_prison_3", MonsterId.Episode13_2_Dumaro, Properties("MHP", 1019744, "MINPATK", 13613, "MAXPATK", 16634, "MINMATK", 13613, "MAXMATK", 16634, "DEF", 501563, "MDEF", 501563));
		AddPropertyOverrides("ep13_2_d_prison_3", MonsterId.Boss_Insane_Marnoks, Properties("MHP", 5608458, "MINPATK", 37837, "MAXPATK", 46235, "MINMATK", 37837, "MAXMATK", 46235, "DEF", 1410981, "MDEF", 1410981));

		// Monster Spawners ---------------------------------

		AddSpawner("ep13_2_d_prison_3.Id1", MonsterId.Episode13_2_Wendigo_Dump, 100, 133, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("ep13_2_d_prison_3.Id2", MonsterId.Episode13_2_Wendigo, 16, 21, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("ep13_2_d_prison_3.Id3", MonsterId.Episode13_2_Dumaro, 12, 16, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("ep13_2_d_prison_3.Id4", MonsterId.Rootcrystal_01, 11, 14, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Episode13_2_Wendigo_Dump' GenType 1 Spawn Points
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(279, -1088, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(233, -729, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(415, -849, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(598, -718, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(564, -1084, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(546, 55, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(598, 259, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(752, -37, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(770, 281, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(907, 100, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(701, 736, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(705, 1040, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(652, 891, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(520, 746, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(524, 1003, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(309, 733, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(311, 998, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-258, 802, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-334, 595, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-469, 718, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-415, 416, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-574, 535, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-595, 823, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-615, -104, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-665, -365, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-864, -379, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-949, -111, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-949, -220, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-843, -1194, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-809, -975, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-677, -1074, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-638, -1248, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-478, -1216, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-461, -974, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-133, -227, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-143, -38, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-12, 46, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(50, -158, 60));

		// 'Episode13_2_Wendigo' GenType 2 Spawn Points
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(234, -1063, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(229, -731, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(551, -1055, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(553, -721, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(751, -30, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(548, 51, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(611, 255, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(771, 274, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(692, 732, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(677, 897, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(694, 1035, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(525, 1007, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(322, 742, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(508, 738, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(-131, -220, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(14, 36, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(-677, -1077, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(-488, -978, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(394, -855, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(910, 109, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(327, 988, 10));

		// 'Episode13_2_Dumaro' GenType 3 Spawn Points
		AddSpawnPoint("ep13_2_d_prison_3.Id3", "ep13_2_d_prison_3", Rectangle(-482, 715, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id3", "ep13_2_d_prison_3", Rectangle(-850, -1175, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id3", "ep13_2_d_prison_3", Rectangle(-814, -971, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id3", "ep13_2_d_prison_3", Rectangle(-501, -1218, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id3", "ep13_2_d_prison_3", Rectangle(-672, -375, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id3", "ep13_2_d_prison_3", Rectangle(-886, -377, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id3", "ep13_2_d_prison_3", Rectangle(-788, -121, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id3", "ep13_2_d_prison_3", Rectangle(-966, -203, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id3", "ep13_2_d_prison_3", Rectangle(-624, -106, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id3", "ep13_2_d_prison_3", Rectangle(-159, -30, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id3", "ep13_2_d_prison_3", Rectangle(33, -162, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id3", "ep13_2_d_prison_3", Rectangle(-429, 422, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id3", "ep13_2_d_prison_3", Rectangle(-341, 589, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id3", "ep13_2_d_prison_3", Rectangle(-607, 544, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id3", "ep13_2_d_prison_3", Rectangle(-300, 786, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id3", "ep13_2_d_prison_3", Rectangle(-613, 805, 10));

		// 'Rootcrystal_01' GenType 53 Spawn Points
		AddSpawnPoint("ep13_2_d_prison_3.Id4", "ep13_2_d_prison_3", Rectangle(381, -862, 100));
		AddSpawnPoint("ep13_2_d_prison_3.Id4", "ep13_2_d_prison_3", Rectangle(558, -332, 100));
		AddSpawnPoint("ep13_2_d_prison_3.Id4", "ep13_2_d_prison_3", Rectangle(670, 515, 100));
		AddSpawnPoint("ep13_2_d_prison_3.Id4", "ep13_2_d_prison_3", Rectangle(-148, -1040, 100));
		AddSpawnPoint("ep13_2_d_prison_3.Id4", "ep13_2_d_prison_3", Rectangle(-849, -1075, 100));
		AddSpawnPoint("ep13_2_d_prison_3.Id4", "ep13_2_d_prison_3", Rectangle(661, 876, 100));
		AddSpawnPoint("ep13_2_d_prison_3.Id4", "ep13_2_d_prison_3", Rectangle(34, 828, 100));
		AddSpawnPoint("ep13_2_d_prison_3.Id4", "ep13_2_d_prison_3", Rectangle(-808, -644, 100));
		AddSpawnPoint("ep13_2_d_prison_3.Id4", "ep13_2_d_prison_3", Rectangle(-670, 194, 100));
		AddSpawnPoint("ep13_2_d_prison_3.Id4", "ep13_2_d_prison_3", Rectangle(-377, 477, 100));
		AddSpawnPoint("ep13_2_d_prison_3.Id4", "ep13_2_d_prison_3", Rectangle(-498, 851, 100));
		AddSpawnPoint("ep13_2_d_prison_3.Id4", "ep13_2_d_prison_3", Rectangle(-229, -155, 100));
		AddSpawnPoint("ep13_2_d_prison_3.Id4", "ep13_2_d_prison_3", Rectangle(198, -365, 100));
		AddSpawnPoint("ep13_2_d_prison_3.Id4", "ep13_2_d_prison_3", Rectangle(-248, 196, 100));
	}
}
