//--- Melia Script -----------------------------------------------------------
// Fasika Plateau Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_pilgrimroad_36_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FPilgrimroad362MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_pilgrimroad_36_2.Id1", MonsterId.Rootcrystal_01, 12, 15, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_36_2.Id2", MonsterId.Sec_Ticen, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_36_2.Id3", MonsterId.Sec_Tucen, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_36_2.Id4", MonsterId.Sec_Gravegolem, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_36_2.Id5", MonsterId.Sec_Hogma_Sorcerer, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 6 Spawn Points
		AddSpawnPoint("f_pilgrimroad_36_2.Id1", "f_pilgrimroad_36_2", Rectangle(1388, -581, 20));
		AddSpawnPoint("f_pilgrimroad_36_2.Id1", "f_pilgrimroad_36_2", Rectangle(722, -237, 20));
		AddSpawnPoint("f_pilgrimroad_36_2.Id1", "f_pilgrimroad_36_2", Rectangle(1085, 610, 20));
		AddSpawnPoint("f_pilgrimroad_36_2.Id1", "f_pilgrimroad_36_2", Rectangle(466, 1221, 20));
		AddSpawnPoint("f_pilgrimroad_36_2.Id1", "f_pilgrimroad_36_2", Rectangle(-271, 601, 20));
		AddSpawnPoint("f_pilgrimroad_36_2.Id1", "f_pilgrimroad_36_2", Rectangle(-346, 42, 20));
		AddSpawnPoint("f_pilgrimroad_36_2.Id1", "f_pilgrimroad_36_2", Rectangle(-807, -463, 20));
		AddSpawnPoint("f_pilgrimroad_36_2.Id1", "f_pilgrimroad_36_2", Rectangle(-1262, -948, 20));
		AddSpawnPoint("f_pilgrimroad_36_2.Id1", "f_pilgrimroad_36_2", Rectangle(-982, 321, 20));
		AddSpawnPoint("f_pilgrimroad_36_2.Id1", "f_pilgrimroad_36_2", Rectangle(-324, 1016, 20));
		AddSpawnPoint("f_pilgrimroad_36_2.Id1", "f_pilgrimroad_36_2", Rectangle(-1124, 1163, 20));

		// 'Sec_Ticen' GenType 24 Spawn Points
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(-212, 53, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(-30, 19, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(39, 580, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(-17, 212, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(229, 377, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(203, 527, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(295, 162, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(-361, 172, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(-326, 521, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(-183, 650, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(-141, 456, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(218, 681, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(48, 726, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(-207, 224, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(79, 332, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(156, 158, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(-366, 339, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(388, 959, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(486, 1157, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(575, 992, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(746, 1222, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(549, 1331, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(354, 1194, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(719, 1095, 30));

		// 'Sec_Tucen' GenType 27 Spawn Points
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(1223, -528, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(479, -36, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(580, -148, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(456, -185, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(727, -289, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(1172, -399, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(619, -46, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(782, -187, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(953, -193, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(827, -87, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(610, 81, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(732, 86, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(711, 216, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(1068, -321, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(814, -322, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(560, -333, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(381, -235, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(106, -691, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(10, -599, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(189, -557, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(29, -450, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(-74, -331, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(161, -308, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(203, -409, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(310, -287, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(444, 1037, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(490, 1285, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(621, 1128, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(705, 1341, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(806, 1108, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(736, 973, 30));

		// 'Sec_Gravegolem' GenType 28 Spawn Points
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-1062, -370, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-877, -200, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-905, -321, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-948, -477, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-874, -557, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-641, -359, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-695, -232, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-771, -482, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-1036, -152, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-828, -58, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-1112, -506, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-229, 344, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-78, 139, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-36, 362, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-30, 577, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(69, 438, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(171, 497, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(183, 251, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(63, 123, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-565, 1072, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-366, 1220, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-443, 949, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-501, 887, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-274, 1124, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-888, 452, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-1097, 374, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-1048, 200, 30));

		// 'Sec_Hogma_Sorcerer' GenType 29 Spawn Points
		AddSpawnPoint("f_pilgrimroad_36_2.Id5", "f_pilgrimroad_36_2", Rectangle(-463, 1016, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id5", "f_pilgrimroad_36_2", Rectangle(-390, 1099, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id5", "f_pilgrimroad_36_2", Rectangle(-1018, 371, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id5", "f_pilgrimroad_36_2", Rectangle(-1031, 472, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id5", "f_pilgrimroad_36_2", Rectangle(-1042, 298, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id5", "f_pilgrimroad_36_2", Rectangle(-1015, -290, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id5", "f_pilgrimroad_36_2", Rectangle(-944, -594, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id5", "f_pilgrimroad_36_2", Rectangle(-804, -380, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id5", "f_pilgrimroad_36_2", Rectangle(-788, -216, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id5", "f_pilgrimroad_36_2", Rectangle(-863, 314, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id5", "f_pilgrimroad_36_2", Rectangle(-507, 1166, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id5", "f_pilgrimroad_36_2", Rectangle(-337, 924, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id5", "f_pilgrimroad_36_2", Rectangle(-875, 542, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id5", "f_pilgrimroad_36_2", Rectangle(-1083, 996, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id5", "f_pilgrimroad_36_2", Rectangle(-1234, 989, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id5", "f_pilgrimroad_36_2", Rectangle(-1378, 1013, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id5", "f_pilgrimroad_36_2", Rectangle(-1292, 1180, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id5", "f_pilgrimroad_36_2", Rectangle(-1191, 1078, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id5", "f_pilgrimroad_36_2", Rectangle(-1129, 1161, 30));
	}
}
