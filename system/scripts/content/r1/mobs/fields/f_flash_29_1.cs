//--- Melia Script -----------------------------------------------------------
// Coastal Fortress Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_flash_29_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FFlash291MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_flash_29_1.Id1", MonsterId.Rootcrystal_03, 15, 20, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_flash_29_1.Id2", MonsterId.Minos_Orange, 57, 75, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_29_1.Id3", MonsterId.Infroholder_Bow_Red, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_29_1.Id4", MonsterId.Minos_Mage_Green, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_03' GenType 3 Spawn Points
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(-1719, -170, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(-1435, -356, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(-1075, -587, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(-950, -932, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(-469, -796, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(-230, -627, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(-203, -329, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(-494, -325, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(-766, -339, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(178, -709, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(89, -69, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(133, 245, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(6, 569, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(1, 844, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(61, 1145, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(568, 173, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(850, -44, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(816, 362, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(1212, 348, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(1331, 560, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(1596, 423, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(1235, -34, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(1147, -503, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(-457, 157, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(-737, 99, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(-1000, 75, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(-1178, 302, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(-1442, 346, 10));

		// 'Minos_Orange' GenType 28 Spawn Points
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-1165, -537, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-1035, -739, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-983, -548, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(1135, 82, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-908, -640, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(188, 273, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(20, 358, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-811, -769, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-70, -132, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-128, -253, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(131, -593, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(116, 146, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(228, 159, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(230, -639, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(583, 171, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(744, 125, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(938, 26, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(1137, -62, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(1319, 140, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(1406, 55, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(1094, -488, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(952, -504, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(1080, -292, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(1070, 393, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(1309, 400, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(779, 360, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(28, 732, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(34, 524, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-634, 90, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-1044, 98, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-1317, 275, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-1213, 199, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-868, 131, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(853, -83, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-1083, -571, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-1076, -656, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-1007, -614, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-53, 961, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(45, 998, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-936, -798, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(1426, 467, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-904, -915, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(33, 812, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(1378, 546, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-774, -850, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(839, 66, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-734, -666, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-622, -693, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-715, -776, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-627, -860, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-46, 238, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-578, -739, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-997, -690, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-530, -847, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(29, -466, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-479, -678, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-204, -313, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-120, -337, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-50, -416, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(868, 179, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(1023, -17, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-55, -547, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(118, -674, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(168, -736, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(286, -746, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(358, -776, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(166, -840, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-2, -90, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-151, 141, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-53, 67, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(25, 56, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(26, 645, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(67, -119, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(179, 37, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(274, 82, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(181, -87, 20));

		// 'Infroholder_Bow_Red' GenType 29 Spawn Points
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(-1248, 364, 20));
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(-761, 112, 20));
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(-810, 12, 20));
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(-948, -416, 20));
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(-1277, -464, 20));
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(-887, -731, 20));
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(900, -160, 20));
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(-180, -348, 20));
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(907, 322, 20));
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(1108, 348, 20));
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(1330, 559, 20));
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(1248, 347, 20));
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(1137, 66, 20));
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(1235, -138, 20));
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(1168, -449, 20));
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(1055, -527, 20));
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(976, -407, 20));
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(28, 885, 20));
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(68, 581, 20));
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(14, 1011, 20));

		// 'Minos_Mage_Green' GenType 30 Spawn Points
		AddSpawnPoint("f_flash_29_1.Id4", "f_flash_29_1", Rectangle(-670, 181, 20));
		AddSpawnPoint("f_flash_29_1.Id4", "f_flash_29_1", Rectangle(-946, 73, 20));
		AddSpawnPoint("f_flash_29_1.Id4", "f_flash_29_1", Rectangle(-1257, 278, 20));
		AddSpawnPoint("f_flash_29_1.Id4", "f_flash_29_1", Rectangle(-1082, -446, 20));
		AddSpawnPoint("f_flash_29_1.Id4", "f_flash_29_1", Rectangle(42, -544, 20));
		AddSpawnPoint("f_flash_29_1.Id4", "f_flash_29_1", Rectangle(110, -777, 20));
		AddSpawnPoint("f_flash_29_1.Id4", "f_flash_29_1", Rectangle(861, 71, 20));
		AddSpawnPoint("f_flash_29_1.Id4", "f_flash_29_1", Rectangle(1050, -312, 20));
		AddSpawnPoint("f_flash_29_1.Id4", "f_flash_29_1", Rectangle(1142, -503, 20));
		AddSpawnPoint("f_flash_29_1.Id4", "f_flash_29_1", Rectangle(1238, 52, 20));
		AddSpawnPoint("f_flash_29_1.Id4", "f_flash_29_1", Rectangle(1570, 430, 20));
		AddSpawnPoint("f_flash_29_1.Id4", "f_flash_29_1", Rectangle(944, 349, 20));
		AddSpawnPoint("f_flash_29_1.Id4", "f_flash_29_1", Rectangle(67, 593, 20));
		AddSpawnPoint("f_flash_29_1.Id4", "f_flash_29_1", Rectangle(-46, 933, 20));
		AddSpawnPoint("f_flash_29_1.Id4", "f_flash_29_1", Rectangle(176, 909, 20));
		AddSpawnPoint("f_flash_29_1.Id4", "f_flash_29_1", Rectangle(30, 734, 20));
	}
}
