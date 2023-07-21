//--- Melia Script -----------------------------------------------------------
// Kirtimas Forest Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'ep13_f_siauliai_5'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class Ep13FSiauliai5MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("ep13_f_siauliai_5", MonsterId.Elgesys_Guard, Properties("MHP", 977580, "MINPATK", 13071, "MAXPATK", 15968, "MINMATK", 13071, "MAXMATK", 15968, "DEF", 449889, "MDEF", 449889));
		AddPropertyOverrides("ep13_f_siauliai_5", MonsterId.Elgesys_Malkos, Properties("MHP", 983576, "MINPATK", 13148, "MAXPATK", 16063, "MINMATK", 13148, "MAXMATK", 16063, "DEF", 456685, "MDEF", 456685));
		AddPropertyOverrides("ep13_f_siauliai_5", MonsterId.Elgesys_Collecter, Properties("MHP", 989741, "MINPATK", 13228, "MAXPATK", 16160, "MINMATK", 13228, "MAXMATK", 16160, "DEF", 463672, "MDEF", 463672));
		AddPropertyOverrides("ep13_f_siauliai_5", MonsterId.Darbas_Smuggler, Properties("MHP", 996070, "MINPATK", 13309, "MAXPATK", 16260, "MINMATK", 13309, "MAXMATK", 16260, "DEF", 470846, "MDEF", 470846));

		// Monster Spawners ---------------------------------

		AddSpawner("ep13_f_siauliai_5.Id1", MonsterId.Rootcrystal_01, 19, 25, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id2", MonsterId.Elgesys_Guard, 3, 4, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id3", MonsterId.Elgesys_Guard, 3, 4, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id4", MonsterId.Elgesys_Guard, 3, 4, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id5", MonsterId.Elgesys_Guard, 3, 4, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id6", MonsterId.Elgesys_Guard, 3, 4, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id7", MonsterId.Elgesys_Guard, 3, 4, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id8", MonsterId.Elgesys_Malkos, 8, 10, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id9", MonsterId.Elgesys_Malkos, 8, 10, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id10", MonsterId.Elgesys_Malkos, 4, 5, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id11", MonsterId.Elgesys_Malkos, 15, 20, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id12", MonsterId.Elgesys_Collecter, 38, 50, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id13", MonsterId.Darbas_Smuggler, 6, 7, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id14", MonsterId.Darbas_Smuggler, 3, 3, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id15", MonsterId.Darbas_Smuggler, 4, 5, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id16", MonsterId.Darbas_Smuggler, 4, 5, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id17", MonsterId.Darbas_Smuggler, 3, 3, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id18", MonsterId.Darbas_Smuggler, 3, 4, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id19", MonsterId.Darbas_Smuggler, 4, 5, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id20", MonsterId.Darbas_Smuggler, 3, 3, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id21", MonsterId.Elgesys_Malkos, 3, 4, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 2 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(49, -851, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(-205, -813, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(-454, -743, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(-811, -688, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(-735, -486, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(-1019, -511, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(-711, -261, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(-736, -29, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(-815, 188, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(-631, 221, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(-769, 434, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(-706, 717, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(-426, 681, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(-115, 754, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(131, 858, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(100, 609, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(307, 680, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(521, 462, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(717, 269, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(980, 124, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(112, 2, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(63, -301, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(868, -63, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(338, -750, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(446, -17, 200));

		// 'Elgesys_Guard' GenType 1000 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id2", "ep13_f_siauliai_5", Rectangle(-64, -847, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id2", "ep13_f_siauliai_5", Rectangle(156, -888, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id2", "ep13_f_siauliai_5", Rectangle(53, -609, 20));

		// 'Elgesys_Guard' GenType 1001 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id3", "ep13_f_siauliai_5", Rectangle(-974, -619, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id3", "ep13_f_siauliai_5", Rectangle(-642, -723, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id3", "ep13_f_siauliai_5", Rectangle(-733, -444, 20));

		// 'Elgesys_Guard' GenType 1002 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id4", "ep13_f_siauliai_5", Rectangle(-764, 54, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id4", "ep13_f_siauliai_5", Rectangle(-735, 295, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id4", "ep13_f_siauliai_5", Rectangle(-442, 24, 20));

		// 'Elgesys_Guard' GenType 1003 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id5", "ep13_f_siauliai_5", Rectangle(-59, -135, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id5", "ep13_f_siauliai_5", Rectangle(279, -64, 20));

		// 'Elgesys_Guard' GenType 1004 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id6", "ep13_f_siauliai_5", Rectangle(762, 62, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id6", "ep13_f_siauliai_5", Rectangle(923, 82, 20));

		// 'Elgesys_Guard' GenType 1005 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id7", "ep13_f_siauliai_5", Rectangle(173, 735, 20));

		// 'Elgesys_Malkos' GenType 1006 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id8", "ep13_f_siauliai_5", Rectangle(-904, -715, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id8", "ep13_f_siauliai_5", Rectangle(-831, -384, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id8", "ep13_f_siauliai_5", Rectangle(-563, -635, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id8", "ep13_f_siauliai_5", Rectangle(-729, -763, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id8", "ep13_f_siauliai_5", Rectangle(-842, -579, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id8", "ep13_f_siauliai_5", Rectangle(-15, -1136, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id8", "ep13_f_siauliai_5", Rectangle(-719, -348, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id8", "ep13_f_siauliai_5", Rectangle(-734, -150, 20));

		// 'Elgesys_Malkos' GenType 1007 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id9", "ep13_f_siauliai_5", Rectangle(-20, -935, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id9", "ep13_f_siauliai_5", Rectangle(260, -875, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id9", "ep13_f_siauliai_5", Rectangle(60, -716, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id9", "ep13_f_siauliai_5", Rectangle(-709, -616, 20));

		// 'Elgesys_Malkos' GenType 1008 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id10", "ep13_f_siauliai_5", Rectangle(47, -170, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id10", "ep13_f_siauliai_5", Rectangle(218, 56, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id10", "ep13_f_siauliai_5", Rectangle(99, 165, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id10", "ep13_f_siauliai_5", Rectangle(161, -142, 20));

		// 'Elgesys_Malkos' GenType 1009 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Rectangle(-552, -39, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Rectangle(-574, 226, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Rectangle(-836, 334, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Rectangle(-1228, -439, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Rectangle(134, -1003, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Rectangle(110, -345, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Rectangle(-647, 89, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Rectangle(-206, -845, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Rectangle(-365, -742, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Rectangle(-688, -45, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Rectangle(-771, 194, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Rectangle(-780, -253, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Rectangle(-1098, -535, 20));

		// 'Elgesys_Collecter' GenType 1010 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(-114, -24, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(-3, 40, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(286, -169, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(357, -7, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(149, -3, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(926, -32, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(820, 6, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(704, 194, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(831, 141, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(728, 358, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(844, 247, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(634, 363, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(508, 427, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(370, 568, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(36, 649, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(177, 652, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(242, 784, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(62, 777, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(171, 956, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(-484, 783, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(-321, 678, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(122, -246, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(2, -319, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(97, 312, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(1173, 179, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(-626, 760, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(488, 575, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(975, -166, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(936, -288, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(-330, 23, 20));

		// 'Darbas_Smuggler' GenType 1011 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id13", "ep13_f_siauliai_5", Rectangle(196, -689, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id13", "ep13_f_siauliai_5", Rectangle(278, -757, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id13", "ep13_f_siauliai_5", Rectangle(-258, -700, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id13", "ep13_f_siauliai_5", Rectangle(-160, -633, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id13", "ep13_f_siauliai_5", Rectangle(330, -858, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id13", "ep13_f_siauliai_5", Rectangle(197, -783, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id13", "ep13_f_siauliai_5", Rectangle(-163, -734, 20));

		// 'Darbas_Smuggler' GenType 1012 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id14", "ep13_f_siauliai_5", Rectangle(-110, -1020, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id14", "ep13_f_siauliai_5", Rectangle(-144, -929, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id14", "ep13_f_siauliai_5", Rectangle(-43, -1016, 20));

		// 'Darbas_Smuggler' GenType 1013 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id15", "ep13_f_siauliai_5", Rectangle(-663, -443, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id15", "ep13_f_siauliai_5", Rectangle(-631, -548, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id15", "ep13_f_siauliai_5", Rectangle(-980, -390, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id15", "ep13_f_siauliai_5", Rectangle(-1050, -434, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id15", "ep13_f_siauliai_5", Rectangle(-928, -475, 20));

		// 'Darbas_Smuggler' GenType 1014 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id16", "ep13_f_siauliai_5", Rectangle(-566, 320, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id16", "ep13_f_siauliai_5", Rectangle(-597, 435, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id16", "ep13_f_siauliai_5", Rectangle(-860, -123, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id16", "ep13_f_siauliai_5", Rectangle(-819, -69, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id16", "ep13_f_siauliai_5", Rectangle(-691, 410, 20));

		// 'Darbas_Smuggler' GenType 1015 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id17", "ep13_f_siauliai_5", Rectangle(-906, 58, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id17", "ep13_f_siauliai_5", Rectangle(-851, 93, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id17", "ep13_f_siauliai_5", Rectangle(-865, 198, 20));

		// 'Darbas_Smuggler' GenType 1016 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id18", "ep13_f_siauliai_5", Rectangle(-780, 764, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id18", "ep13_f_siauliai_5", Rectangle(-845, 775, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id18", "ep13_f_siauliai_5", Rectangle(-723, 807, 20));

		// 'Darbas_Smuggler' GenType 1017 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id19", "ep13_f_siauliai_5", Rectangle(39, 881, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id19", "ep13_f_siauliai_5", Rectangle(-58, 829, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id19", "ep13_f_siauliai_5", Rectangle(316, 772, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id19", "ep13_f_siauliai_5", Rectangle(360, 695, 20));

		// 'Darbas_Smuggler' GenType 1018 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id20", "ep13_f_siauliai_5", Rectangle(1021, 93, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id20", "ep13_f_siauliai_5", Rectangle(1013, -13, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id20", "ep13_f_siauliai_5", Rectangle(1069, 161, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id20", "ep13_f_siauliai_5", Rectangle(-780, 437, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id20", "ep13_f_siauliai_5", Rectangle(-743, 542, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id20", "ep13_f_siauliai_5", Rectangle(-725, 664, 20));

		// 'Elgesys_Malkos' GenType 1019 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id21", "ep13_f_siauliai_5", Rectangle(645, -657, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id21", "ep13_f_siauliai_5", Rectangle(882, -401, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id21", "ep13_f_siauliai_5", Rectangle(519, -687, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id21", "ep13_f_siauliai_5", Rectangle(840, -521, 20));
	}
}
