//--- Melia Script -----------------------------------------------------------
// Lhadar Forest Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_maple_25_3'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FMaple253MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_maple_25_3.Id1", MonsterId.Nacorngfly, 42, 55, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_25_3.Id2", MonsterId.Nacorngbug, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_25_3.Id3", MonsterId.Rodeyokel, 27, 35, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_25_3.Id4", MonsterId.Nacorngbug, 27, 35, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_25_3.Id5", MonsterId.Rodevassal, 1, 1, TimeSpan.FromMilliseconds(1800000), TendencyType.Peaceful);
		AddSpawner("f_maple_25_3.Id6", MonsterId.Rootcrystal_05, 19, 25, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Nacorngfly' GenType 22 Spawn Points
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-1397, 589, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-1693, 528, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-1594, 442, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-1472, 436, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-1538, 650, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-1474, 795, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-1396, 688, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-1308, 618, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-1324, 513, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-1522, 583, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-1283, 240, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-1094, 109, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-1042, -114, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-797, -229, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-595, -214, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-379, -63, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-556, 176, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-85, 614, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(197, 632, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(47, 774, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(278, 833, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(431, 653, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(464, 842, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(625, 724, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(869, 720, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(1098, 682, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(1287, 633, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(1525, 600, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(1340, 540, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(1240, 697, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-157, 964, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-68, 865, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-346, 1114, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-521, 1065, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-606, 1277, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-645, 1172, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(447, -350, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(585, -244, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(429, -243, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(475, -76, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(317, -158, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(192, -197, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(11, -122, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(791, -155, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(1051, -184, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(1219, -235, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(1375, -365, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(1299, -83, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(1470, 44, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-1310, -1071, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-1452, -1091, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-1330, -1199, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-1279, -937, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-1345, -792, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-955, -805, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-815, -1018, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-776, -752, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-648, -911, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-639, -1352, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-722, -1483, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-532, -1460, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-436, -792, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-257, -909, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-83, -688, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(18, -942, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(69, -752, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-90, -550, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(275, -920, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(485, -955, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(364, -726, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(344, -1233, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(209, -1478, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(397, -1427, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(341, -1587, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(548, -1609, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(1068, -883, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(1248, -893, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(1211, -664, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(1447, -579, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(1414, -814, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(1061, -648, 30));

		// 'Nacorngbug' GenType 23 Spawn Points
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(280, -281, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(138, -185, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(291, -139, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(412, -250, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(582, -126, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(926, -126, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(1065, -101, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(1124, -298, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(1212, -75, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(1219, -182, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(1349, -381, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(1374, -394, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(1409, -195, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(1347, -257, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(1234, -292, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(1294, -435, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-71, -86, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-948, -287, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-1071, -76, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-881, -106, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-675, -281, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-541, -184, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-503, 64, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-1010, -35, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-1027, 85, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-479, 244, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-378, 428, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-344, -65, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-412, -130, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-651, -89, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(1332, -76, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(1526, 0, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(1600, -39, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(1401, 35, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(1406, -25, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(692, -207, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-1305, 237, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-1613, 441, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-1495, 710, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-1442, 494, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-1560, 554, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-1654, 525, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-1670, 374, 40));

		// 'Rodeyokel' GenType 24 Spawn Points
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(-39, 866, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(-576, 1012, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(-621, 1084, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(-575, 1246, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(-426, 1047, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(-188, 987, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(-82, 700, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(149, 856, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(55, 740, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(172, 657, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(392, 861, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(358, 734, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(492, 760, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(490, 638, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(685, 755, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(646, 655, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(848, 758, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(1053, 659, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(1170, 666, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(1205, 528, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(1328, 478, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(1395, 604, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(1428, 495, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(1392, 769, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(-421, 1182, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(-707, 1211, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(-539, 1129, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(32, 591, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(560, 878, 40));

		// 'Nacorngbug' GenType 25 Spawn Points
		AddSpawnPoint("f_maple_25_3.Id4", "f_maple_25_3", Rectangle(-576, -11, 9999));

		// 'Rodevassal' GenType 31 Spawn Points
		AddSpawnPoint("f_maple_25_3.Id5", "f_maple_25_3", Rectangle(-1536, -1273, 20));

		// 'Rootcrystal_05' GenType 32 Spawn Points
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(1567, 645, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(1331, 709, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(957, 698, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(696, 705, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(329, 826, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(65, 605, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(-120, 936, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(-469, 1141, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(-426, 296, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(-486, -83, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(-923, 132, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(-873, -296, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(-1315, 266, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(-1326, 571, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(-1792, 537, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(-880, -653, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(-1378, -1134, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(-866, -922, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(-1636, -1288, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(-686, -1589, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(-638, -1248, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(-350, -887, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(-11, -644, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(119, -894, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(413, -1029, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(464, -1629, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(141, -1571, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(1141, -843, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(1403, -927, 15));
	}
}
