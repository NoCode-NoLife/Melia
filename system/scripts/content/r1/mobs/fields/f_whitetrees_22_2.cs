//--- Melia Script -----------------------------------------------------------
// Tekel Shelter Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_whitetrees_22_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FWhitetrees222MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_whitetrees_22_2.Id1", MonsterId.Rootcrystal_01, min: 12, max: 15, respawn: TimeSpan.FromMilliseconds(60000), tendency: TendencyType.Peaceful);
		AddSpawner("f_whitetrees_22_2.Id2", MonsterId.Yakyak, min: 18, max: 24, tendency: TendencyType.Peaceful);
		AddSpawner("f_whitetrees_22_2.Id3", MonsterId.Yak_Magician, min: 18, max: 24, tendency: TendencyType.Peaceful);
		AddSpawner("f_whitetrees_22_2.Id4", MonsterId.Yak_Warrior, min: 27, max: 35, tendency: TendencyType.Aggressive);
		AddSpawner("f_whitetrees_22_2.Id5", MonsterId.Yak_Druid, min: 6, max: 7, tendency: TendencyType.Peaceful);
		AddSpawner("f_whitetrees_22_2.Id6", MonsterId.Hohen_Barkle_Black, min: 27, max: 35, tendency: TendencyType.Aggressive);
		AddSpawner("f_whitetrees_22_2.Id7", MonsterId.Hohen_Ritter_Black, min: 27, max: 35, tendency: TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 14 Spawn Points
		AddSpawnPoint("f_whitetrees_22_2.Id1", "f_whitetrees_22_2", Rectangle(23, -486, 10));
		AddSpawnPoint("f_whitetrees_22_2.Id1", "f_whitetrees_22_2", Rectangle(-559, -1104, 10));
		AddSpawnPoint("f_whitetrees_22_2.Id1", "f_whitetrees_22_2", Rectangle(-86, -1021, 10));
		AddSpawnPoint("f_whitetrees_22_2.Id1", "f_whitetrees_22_2", Rectangle(-243, -1515, 10));
		AddSpawnPoint("f_whitetrees_22_2.Id1", "f_whitetrees_22_2", Rectangle(289, -1041, 10));
		AddSpawnPoint("f_whitetrees_22_2.Id1", "f_whitetrees_22_2", Rectangle(400, -1525, 10));
		AddSpawnPoint("f_whitetrees_22_2.Id1", "f_whitetrees_22_2", Rectangle(1056, -1093, 10));
		AddSpawnPoint("f_whitetrees_22_2.Id1", "f_whitetrees_22_2", Rectangle(1361, -876, 10));
		AddSpawnPoint("f_whitetrees_22_2.Id1", "f_whitetrees_22_2", Rectangle(139, -82, 10));
		AddSpawnPoint("f_whitetrees_22_2.Id1", "f_whitetrees_22_2", Rectangle(77, 466, 10));
		AddSpawnPoint("f_whitetrees_22_2.Id1", "f_whitetrees_22_2", Rectangle(-384, 544, 10));
		AddSpawnPoint("f_whitetrees_22_2.Id1", "f_whitetrees_22_2", Rectangle(-490, 1059, 10));
		AddSpawnPoint("f_whitetrees_22_2.Id1", "f_whitetrees_22_2", Rectangle(391, 1288, 10));
		AddSpawnPoint("f_whitetrees_22_2.Id1", "f_whitetrees_22_2", Rectangle(880, 620, 10));
		AddSpawnPoint("f_whitetrees_22_2.Id1", "f_whitetrees_22_2", Rectangle(1080, 169, 10));

		// 'Yakyak' GenType 42 Spawn Points
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(265, 1425, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(407, 1509, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(384, 1396, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(522, 1374, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(561, 1258, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(433, 1191, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(294, 1202, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(238, 1295, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(-387, 1126, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(-339, 1046, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(-779, 1061, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(-670, 1050, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(-807, 948, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(-706, 862, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(-576, 808, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(-705, 1165, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(-471, 619, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(-454, 467, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(-292, 459, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(-289, 608, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(997, 582, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(1019, 466, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(1122, 576, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(1053, 758, 40));

		// 'Yak_Magician' GenType 43 Spawn Points
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(16, 1297, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(119, 1236, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(46, 1132, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(185, 1105, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(156, 1378, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(270, 1534, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(359, 1626, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(361, 1093, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(-595, 928, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(-518, 855, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(-489, 964, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(-377, 915, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(-567, 1172, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(-241, 1181, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(-272, 973, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(-133, 1035, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(-187, 575, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(-110, 679, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(116, -483, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(35, 540, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(-219, -432, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(-90, -478, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(274, -481, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(397, -397, 40));

		// 'Yak_Warrior' GenType 44 Spawn Points
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(139, 586, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(-44, 318, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(45, 250, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(234, 518, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(139, 307, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(122, -231, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(401, 612, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(235, -186, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(16, -176, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(548, 615, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(644, 727, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(629, 521, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(734, 810, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(804, 710, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(923, 734, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(720, 453, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(765, 529, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(899, 532, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(906, 444, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(695, 626, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(-177, -314, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(48, -364, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(154, -368, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(364, -297, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(31, 516, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(876, 628, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(99, -71, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(120, 171, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(199, 410, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(-183, 570, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(-287, 498, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(-275, 602, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(157, 467, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(1023, 676, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(1068, 570, 40));

		// 'Yak_Druid' GenType 45 Spawn Points
		AddSpawnPoint("f_whitetrees_22_2.Id5", "f_whitetrees_22_2", Rectangle(722, 711, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id5", "f_whitetrees_22_2", Rectangle(1059, 659, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id5", "f_whitetrees_22_2", Rectangle(99, 423, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id5", "f_whitetrees_22_2", Rectangle(-361, 533, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id5", "f_whitetrees_22_2", Rectangle(-547, 1026, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id5", "f_whitetrees_22_2", Rectangle(-45, -309, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id5", "f_whitetrees_22_2", Rectangle(249, -307, 40));

		// 'Hohen_Barkle_Black' GenType 46 Spawn Points
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(814, 195, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(1211, 363, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(931, 54, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(1351, 178, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(897, 134, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(971, 242, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(1128, 293, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(1208, 232, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(961, -650, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(1151, -694, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(1066, -865, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(1279, -794, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(1209, -965, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(1352, -1050, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(1429, -912, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(779, -1240, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(979, -1230, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(268, -991, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(381, -957, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(444, -1067, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(245, -1215, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(-6, -1448, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(201, -1616, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(-159, -1559, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(1089, -992, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(1060, -1141, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(362, -1496, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(114, -1561, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(40, -1644, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(1181, 139, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(847, 88, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(1128, 190, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(1247, -851, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(273, -1460, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(43, -1538, 40));

		// 'Hohen_Ritter_Black' GenType 47 Spawn Points
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(-189, -689, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(-53, -881, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(-206, -991, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(-193, -1122, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(-587, -1010, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(-650, -1144, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(-537, -1239, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(-451, -1031, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(-332, -1085, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(-357, -1440, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(-86, -1460, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(-27, -1588, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(88, -1544, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(278, -1520, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(123, -1392, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(576, -1406, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(880, -1301, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(1096, -984, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(1211, -865, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(1062, -758, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(1217, 136, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(998, 174, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(1074, 99, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(273, -1100, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(-42, -1021, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(-176, -1534, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(215, -1593, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(229, -1287, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(390, -958, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(283, -896, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(767, -1246, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(1004, -1126, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(1004, -930, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(1048, -635, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(1299, -793, 40));
	}
}
