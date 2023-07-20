//--- Melia Script -----------------------------------------------------------
// Hidden Passage Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'ep14_2_d_castle_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class Ep142DCastle2MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("ep14_2_d_castle_2", MonsterId.Episode14_2_Bleakferret_Lancer, Properties("MHP", 48750000, "MINPATK", 110000, "MAXPATK", 110000, "MINMATK", 110000, "MAXMATK", 110000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("ep14_2_d_castle_2", MonsterId.Episode14_2_Bleakferret_Scout, Properties("MHP", 48750000, "MINPATK", 110000, "MAXPATK", 110000, "MINMATK", 110000, "MAXMATK", 110000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("ep14_2_d_castle_2", MonsterId.Episode14_2_Bleakferret_Strange, Properties("MHP", 48750000, "MINPATK", 110000, "MAXPATK", 110000, "MINMATK", 110000, "MAXMATK", 110000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("ep14_2_d_castle_2", MonsterId.Episode14_2_GresmeBird, Properties("MHP", 48750000, "MINPATK", 110000, "MAXPATK", 110000, "MINMATK", 110000, "MAXMATK", 110000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("ep14_2_d_castle_2", MonsterId.Episode14_2_GresmeCrow, Properties("MHP", 48750000, "MINPATK", 110000, "MAXPATK", 110000, "MINMATK", 110000, "MAXMATK", 110000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("ep14_2_d_castle_2", MonsterId.Boss_Bleakferret_Prey, Properties("MHP", 126000000, "MINPATK", 110000, "MAXPATK", 110000, "MINMATK", 110000, "MAXMATK", 110000, "DEF", 2500000, "MDEF", 2500000));

		// Monster Spawners ---------------------------------

		AddSpawner("ep14_2_d_castle_2.Id1", MonsterId.Rootcrystal_05, 15, 19, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("ep14_2_d_castle_2.Id2", MonsterId.Episode14_2_Bleakferret_Lancer, 23, 30, TimeSpan.FromMilliseconds(10000), TendencyType.Peaceful);
		AddSpawner("ep14_2_d_castle_2.Id3", MonsterId.Episode14_2_Bleakferret_Scout, 23, 30, TimeSpan.FromMilliseconds(10000), TendencyType.Peaceful);
		AddSpawner("ep14_2_d_castle_2.Id4", MonsterId.Episode14_2_Bleakferret_Strange, 12, 15, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("ep14_2_d_castle_2.Id5", MonsterId.Episode14_2_GresmeBird, 19, 25, TimeSpan.FromMilliseconds(10000), TendencyType.Peaceful);
		AddSpawner("ep14_2_d_castle_2.Id6", MonsterId.Episode14_2_GresmeCrow, 19, 25, TimeSpan.FromMilliseconds(10000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_05' GenType 15 Spawn Points
		AddSpawnPoint("ep14_2_d_castle_2.Id1", "ep14_2_d_castle_2", Rectangle(940, -587, 200));
		AddSpawnPoint("ep14_2_d_castle_2.Id1", "ep14_2_d_castle_2", Rectangle(910, 638, 200));
		AddSpawnPoint("ep14_2_d_castle_2.Id1", "ep14_2_d_castle_2", Rectangle(311, 637, 200));
		AddSpawnPoint("ep14_2_d_castle_2.Id1", "ep14_2_d_castle_2", Rectangle(-585, 663, 200));
		AddSpawnPoint("ep14_2_d_castle_2.Id1", "ep14_2_d_castle_2", Rectangle(-835, 688, 200));
		AddSpawnPoint("ep14_2_d_castle_2.Id1", "ep14_2_d_castle_2", Rectangle(-783, -906, 200));
		AddSpawnPoint("ep14_2_d_castle_2.Id1", "ep14_2_d_castle_2", Rectangle(942, 37, 200));
		AddSpawnPoint("ep14_2_d_castle_2.Id1", "ep14_2_d_castle_2", Rectangle(-793, -216, 200));
		AddSpawnPoint("ep14_2_d_castle_2.Id1", "ep14_2_d_castle_2", Rectangle(-152, 635, 200));

		// 'Episode14_2_Bleakferret_Lancer' GenType 16 Spawn Points
		AddSpawnPoint("ep14_2_d_castle_2.Id2", "ep14_2_d_castle_2", Rectangle(843, -860, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id2", "ep14_2_d_castle_2", Rectangle(840, -662, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id2", "ep14_2_d_castle_2", Rectangle(1026, -569, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id2", "ep14_2_d_castle_2", Rectangle(863, -424, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id2", "ep14_2_d_castle_2", Rectangle(1019, -370, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id2", "ep14_2_d_castle_2", Rectangle(659, -728, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id2", "ep14_2_d_castle_2", Rectangle(1235, -576, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id2", "ep14_2_d_castle_2", Rectangle(94, 350, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id2", "ep14_2_d_castle_2", Rectangle(-189, 810, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id2", "ep14_2_d_castle_2", Rectangle(15, 892, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id2", "ep14_2_d_castle_2", Rectangle(-949, 567, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id2", "ep14_2_d_castle_2", Rectangle(1558, 711, 20));

		// 'Episode14_2_Bleakferret_Scout' GenType 17 Spawn Points
		AddSpawnPoint("ep14_2_d_castle_2.Id3", "ep14_2_d_castle_2", Rectangle(1404, 535, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id3", "ep14_2_d_castle_2", Rectangle(-49, 824, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id3", "ep14_2_d_castle_2", Rectangle(-180, 492, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id3", "ep14_2_d_castle_2", Rectangle(259, 386, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id3", "ep14_2_d_castle_2", Rectangle(-790, 552, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id3", "ep14_2_d_castle_2", Rectangle(342, 820, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id3", "ep14_2_d_castle_2", Rectangle(-1284, 742, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id3", "ep14_2_d_castle_2", Rectangle(-808, 947, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id3", "ep14_2_d_castle_2", Rectangle(-850, -359, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id3", "ep14_2_d_castle_2", Rectangle(-720, 187, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id3", "ep14_2_d_castle_2", Rectangle(-711, -896, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id3", "ep14_2_d_castle_2", Rectangle(-866, -1156, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id3", "ep14_2_d_castle_2", Rectangle(-1423, -861, 20));

		// 'Episode14_2_Bleakferret_Strange' GenType 18 Spawn Points
		AddSpawnPoint("ep14_2_d_castle_2.Id4", "ep14_2_d_castle_2", Rectangle(783, -1155, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id4", "ep14_2_d_castle_2", Rectangle(907, -1031, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id4", "ep14_2_d_castle_2", Rectangle(1469, -495, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id4", "ep14_2_d_castle_2", Rectangle(1299, -644, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id4", "ep14_2_d_castle_2", Rectangle(413, -1146, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id4", "ep14_2_d_castle_2", Rectangle(520, -573, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id4", "ep14_2_d_castle_2", Rectangle(870, -135, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id4", "ep14_2_d_castle_2", Rectangle(1032, 246, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id4", "ep14_2_d_castle_2", Rectangle(1566, 557, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id4", "ep14_2_d_castle_2", Rectangle(1408, 719, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id4", "ep14_2_d_castle_2", Rectangle(-146, 372, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id4", "ep14_2_d_castle_2", Rectangle(345, 362, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id4", "ep14_2_d_castle_2", Rectangle(319, 893, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id4", "ep14_2_d_castle_2", Rectangle(-127, 904, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id4", "ep14_2_d_castle_2", Rectangle(-947, 667, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id4", "ep14_2_d_castle_2", Rectangle(-654, 678, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id4", "ep14_2_d_castle_2", Rectangle(-804, -19, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id4", "ep14_2_d_castle_2", Rectangle(-803, -684, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id4", "ep14_2_d_castle_2", Rectangle(-1353, -750, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id4", "ep14_2_d_castle_2", Rectangle(-1458, 572, 20));

		// 'Episode14_2_GresmeBird' GenType 19 Spawn Points
		AddSpawnPoint("ep14_2_d_castle_2.Id5", "ep14_2_d_castle_2", Rectangle(388, -571, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id5", "ep14_2_d_castle_2", Rectangle(748, -1007, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id5", "ep14_2_d_castle_2", Rectangle(862, -255, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id5", "ep14_2_d_castle_2", Rectangle(972, -684, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id5", "ep14_2_d_castle_2", Rectangle(1312, -459, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id5", "ep14_2_d_castle_2", Rectangle(868, 81, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id5", "ep14_2_d_castle_2", Rectangle(845, 554, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id5", "ep14_2_d_castle_2", Rectangle(1033, 724, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id5", "ep14_2_d_castle_2", Rectangle(943, 966, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id5", "ep14_2_d_castle_2", Rectangle(-71, 413, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id5", "ep14_2_d_castle_2", Rectangle(247, 407, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id5", "ep14_2_d_castle_2", Rectangle(229, 859, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id5", "ep14_2_d_castle_2", Rectangle(-27, 810, 20));

		// 'Episode14_2_GresmeCrow' GenType 20 Spawn Points
		AddSpawnPoint("ep14_2_d_castle_2.Id6", "ep14_2_d_castle_2", Rectangle(447, -1029, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id6", "ep14_2_d_castle_2", Rectangle(532, -743, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id6", "ep14_2_d_castle_2", Rectangle(922, -1151, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id6", "ep14_2_d_castle_2", Rectangle(759, -602, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id6", "ep14_2_d_castle_2", Rectangle(1016, -175, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id6", "ep14_2_d_castle_2", Rectangle(876, 260, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id6", "ep14_2_d_castle_2", Rectangle(946, 431, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id6", "ep14_2_d_castle_2", Rectangle(836, 723, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id6", "ep14_2_d_castle_2", Rectangle(1113, 587, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id6", "ep14_2_d_castle_2", Rectangle(353, 470, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id6", "ep14_2_d_castle_2", Rectangle(81, 934, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id6", "ep14_2_d_castle_2", Rectangle(-239, 415, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id6", "ep14_2_d_castle_2", Rectangle(-1280, 569, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id6", "ep14_2_d_castle_2", Rectangle(-731, 687, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id6", "ep14_2_d_castle_2", Rectangle(-867, 380, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id6", "ep14_2_d_castle_2", Rectangle(-738, -504, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id6", "ep14_2_d_castle_2", Rectangle(-734, -1142, 20));
		AddSpawnPoint("ep14_2_d_castle_2.Id6", "ep14_2_d_castle_2", Rectangle(-1256, -845, 20));
	}
}
