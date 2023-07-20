//--- Melia Script -----------------------------------------------------------
// Nahash Forest Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_siauliai_35_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FSiauliai351MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_siauliai_35_1", MonsterId.Spion_Mage_Blue, Properties("MHP", 340701, "MINPATK", 4882, "MAXPATK", 5902, "MINMATK", 4882, "MAXMATK", 5902, "DEF", 29497, "MDEF", 29497));
		AddPropertyOverrides("f_siauliai_35_1", MonsterId.Spion_Blue, Properties("MHP", 344863, "MINPATK", 4935, "MAXPATK", 5968, "MINMATK", 4935, "MAXMATK", 5968, "DEF", 30526, "MDEF", 30526));
		AddPropertyOverrides("f_siauliai_35_1", MonsterId.Spion_Bow_Blue, Properties("MHP", 349465, "MINPATK", 4994, "MAXPATK", 6041, "MINMATK", 4994, "MAXMATK", 6041, "DEF", 31663, "MDEF", 31663));

		// Monster Spawners ---------------------------------

		AddSpawner("f_siauliai_35_1.Id1", MonsterId.Spion_Mage_Blue, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_35_1.Id2", MonsterId.Spion_Blue, 83, 110, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_35_1.Id3", MonsterId.Spion_Bow_Blue, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_35_1.Id4", MonsterId.Rootcrystal_01, 14, 18, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Spion_Mage_Blue' GenType 2 Spawn Points
		AddSpawnPoint("f_siauliai_35_1.Id1", "f_siauliai_35_1", Rectangle(-260, 703, 30));
		AddSpawnPoint("f_siauliai_35_1.Id1", "f_siauliai_35_1", Rectangle(-162, 819, 30));
		AddSpawnPoint("f_siauliai_35_1.Id1", "f_siauliai_35_1", Rectangle(204, 466, 30));
		AddSpawnPoint("f_siauliai_35_1.Id1", "f_siauliai_35_1", Rectangle(884, 281, 30));
		AddSpawnPoint("f_siauliai_35_1.Id1", "f_siauliai_35_1", Rectangle(-26, 1569, 30));
		AddSpawnPoint("f_siauliai_35_1.Id1", "f_siauliai_35_1", Rectangle(240, 1272, 30));
		AddSpawnPoint("f_siauliai_35_1.Id1", "f_siauliai_35_1", Rectangle(655, 1146, 30));
		AddSpawnPoint("f_siauliai_35_1.Id1", "f_siauliai_35_1", Rectangle(892, 380, 30));
		AddSpawnPoint("f_siauliai_35_1.Id1", "f_siauliai_35_1", Rectangle(926, 84, 30));
		AddSpawnPoint("f_siauliai_35_1.Id1", "f_siauliai_35_1", Rectangle(736, -172, 30));
		AddSpawnPoint("f_siauliai_35_1.Id1", "f_siauliai_35_1", Rectangle(556, -402, 30));
		AddSpawnPoint("f_siauliai_35_1.Id1", "f_siauliai_35_1", Rectangle(902, -632, 30));
		AddSpawnPoint("f_siauliai_35_1.Id1", "f_siauliai_35_1", Rectangle(888, -306, 30));
		AddSpawnPoint("f_siauliai_35_1.Id1", "f_siauliai_35_1", Rectangle(645, -587, 30));
		AddSpawnPoint("f_siauliai_35_1.Id1", "f_siauliai_35_1", Rectangle(-1451, -370, 30));
		AddSpawnPoint("f_siauliai_35_1.Id1", "f_siauliai_35_1", Rectangle(-1432, -246, 30));
		AddSpawnPoint("f_siauliai_35_1.Id1", "f_siauliai_35_1", Rectangle(-858, 1, 30));
		AddSpawnPoint("f_siauliai_35_1.Id1", "f_siauliai_35_1", Rectangle(-736, 138, 30));
		AddSpawnPoint("f_siauliai_35_1.Id1", "f_siauliai_35_1", Rectangle(-1080, 284, 30));
		AddSpawnPoint("f_siauliai_35_1.Id1", "f_siauliai_35_1", Rectangle(-1423, 317, 30));
		AddSpawnPoint("f_siauliai_35_1.Id1", "f_siauliai_35_1", Rectangle(-1445, 889, 30));
		AddSpawnPoint("f_siauliai_35_1.Id1", "f_siauliai_35_1", Rectangle(-1345, 1146, 30));
		AddSpawnPoint("f_siauliai_35_1.Id1", "f_siauliai_35_1", Rectangle(-1578, 1069, 30));
		AddSpawnPoint("f_siauliai_35_1.Id1", "f_siauliai_35_1", Rectangle(-1370, 1027, 30));
		AddSpawnPoint("f_siauliai_35_1.Id1", "f_siauliai_35_1", Rectangle(-710, 512, 30));
		AddSpawnPoint("f_siauliai_35_1.Id1", "f_siauliai_35_1", Rectangle(-892, 720, 30));
		AddSpawnPoint("f_siauliai_35_1.Id1", "f_siauliai_35_1", Rectangle(-57, -226, 30));
		AddSpawnPoint("f_siauliai_35_1.Id1", "f_siauliai_35_1", Rectangle(-357, -85, 30));
		AddSpawnPoint("f_siauliai_35_1.Id1", "f_siauliai_35_1", Rectangle(-34, -493, 30));
		AddSpawnPoint("f_siauliai_35_1.Id1", "f_siauliai_35_1", Rectangle(28, -745, 30));
		AddSpawnPoint("f_siauliai_35_1.Id1", "f_siauliai_35_1", Rectangle(139, -551, 30));
		AddSpawnPoint("f_siauliai_35_1.Id1", "f_siauliai_35_1", Rectangle(-128, -531, 30));

		// 'Spion_Blue' GenType 3 Spawn Points
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-136, 516, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-97, 1369, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-413, 690, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(417, 493, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-34, -140, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-197, -194, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-67, -388, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(88, -304, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(25, 64, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(14, 290, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-465, -85, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-676, 80, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-892, -121, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-940, 216, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-1293, 381, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-897, 69, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-812, 705, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-809, 493, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-1372, 1019, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-1497, 909, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-1525, 1112, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-924, 568, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-258, 809, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-506, 646, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(575, 465, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(893, 381, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(1043, 217, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(891, 9, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(798, -261, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(613, -322, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(673, -528, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(955, -555, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(556, -493, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(900, 145, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(1149, 381, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(55, -678, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-100, -860, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(719, -587, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(824, -595, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(696, -390, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(668, -209, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(904, -166, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(825, -79, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(1003, 109, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(1010, 358, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(811, 364, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(816, 476, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(978, 390, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(1092, 275, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(1048, 138, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(815, 180, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(839, 121, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(826, 254, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(753, 408, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-273, 741, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-216, 770, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-196, 673, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-172, 607, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-82, 495, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-53, 430, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(103, 399, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(142, 447, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-33, -638, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(22, -587, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(72, -536, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(11, -374, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-100, -295, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-124, -172, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-84, -86, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-212, -300, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(12, -231, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(111, -404, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-604, 28, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-675, -82, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-795, -84, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-853, 139, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-933, 126, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-959, -90, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-922, -17, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-858, -67, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-803, 103, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-750, 42, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-1226, 312, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-1347, 195, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-1269, 259, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-1427, 239, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-1349, 293, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-866, 589, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-776, 550, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-751, 641, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-741, 713, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-759, 447, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(24, 1258, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(111, 1270, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(44, 1580, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-118, 1561, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(142, 1539, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(131, 1454, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(75, 1494, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-3, 1457, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-57, 1439, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(62, 1405, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(679, 904, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(789, 876, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(860, 920, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(893, 987, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(895, 1056, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-1560, -325, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-1476, -315, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-1381, -339, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-1376, -183, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-1254, -197, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-1220, -336, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-1292, -332, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-1267, -394, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-1401, -469, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-1451, -444, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-1440, 1115, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-1459, 1013, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-1563, 950, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-1393, 943, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-1505, 858, 30));
		AddSpawnPoint("f_siauliai_35_1.Id2", "f_siauliai_35_1", Rectangle(-1408, 861, 30));

		// 'Spion_Bow_Blue' GenType 4 Spawn Points
		AddSpawnPoint("f_siauliai_35_1.Id3", "f_siauliai_35_1", Rectangle(-1458, 307, 30));
		AddSpawnPoint("f_siauliai_35_1.Id3", "f_siauliai_35_1", Rectangle(-1374, 399, 30));
		AddSpawnPoint("f_siauliai_35_1.Id3", "f_siauliai_35_1", Rectangle(-1310, 296, 30));
		AddSpawnPoint("f_siauliai_35_1.Id3", "f_siauliai_35_1", Rectangle(-822, 636, 30));
		AddSpawnPoint("f_siauliai_35_1.Id3", "f_siauliai_35_1", Rectangle(-837, 527, 30));
		AddSpawnPoint("f_siauliai_35_1.Id3", "f_siauliai_35_1", Rectangle(-690, 605, 30));
		AddSpawnPoint("f_siauliai_35_1.Id3", "f_siauliai_35_1", Rectangle(14, 146, 30));
		AddSpawnPoint("f_siauliai_35_1.Id3", "f_siauliai_35_1", Rectangle(42, 382, 30));
		AddSpawnPoint("f_siauliai_35_1.Id3", "f_siauliai_35_1", Rectangle(-17, 402, 30));
		AddSpawnPoint("f_siauliai_35_1.Id3", "f_siauliai_35_1", Rectangle(-20, -310, 30));
		AddSpawnPoint("f_siauliai_35_1.Id3", "f_siauliai_35_1", Rectangle(-205, -423, 30));
		AddSpawnPoint("f_siauliai_35_1.Id3", "f_siauliai_35_1", Rectangle(60, -713, 30));
		AddSpawnPoint("f_siauliai_35_1.Id3", "f_siauliai_35_1", Rectangle(631, -450, 30));
		AddSpawnPoint("f_siauliai_35_1.Id3", "f_siauliai_35_1", Rectangle(765, -260, 30));
		AddSpawnPoint("f_siauliai_35_1.Id3", "f_siauliai_35_1", Rectangle(906, -464, 30));
		AddSpawnPoint("f_siauliai_35_1.Id3", "f_siauliai_35_1", Rectangle(946, 240, 30));
		AddSpawnPoint("f_siauliai_35_1.Id3", "f_siauliai_35_1", Rectangle(776, 310, 30));
		AddSpawnPoint("f_siauliai_35_1.Id3", "f_siauliai_35_1", Rectangle(926, 494, 30));
		AddSpawnPoint("f_siauliai_35_1.Id3", "f_siauliai_35_1", Rectangle(721, 1130, 30));
		AddSpawnPoint("f_siauliai_35_1.Id3", "f_siauliai_35_1", Rectangle(514, 1172, 30));
		AddSpawnPoint("f_siauliai_35_1.Id3", "f_siauliai_35_1", Rectangle(169, 1327, 30));
		AddSpawnPoint("f_siauliai_35_1.Id3", "f_siauliai_35_1", Rectangle(-35, 1311, 30));
		AddSpawnPoint("f_siauliai_35_1.Id3", "f_siauliai_35_1", Rectangle(-117, 1502, 30));
		AddSpawnPoint("f_siauliai_35_1.Id3", "f_siauliai_35_1", Rectangle(-26, 1539, 30));
		AddSpawnPoint("f_siauliai_35_1.Id3", "f_siauliai_35_1", Rectangle(723, 892, 30));
		AddSpawnPoint("f_siauliai_35_1.Id3", "f_siauliai_35_1", Rectangle(-1515, -369, 30));
		AddSpawnPoint("f_siauliai_35_1.Id3", "f_siauliai_35_1", Rectangle(-1512, -234, 30));
		AddSpawnPoint("f_siauliai_35_1.Id3", "f_siauliai_35_1", Rectangle(-1343, -400, 30));
		AddSpawnPoint("f_siauliai_35_1.Id3", "f_siauliai_35_1", Rectangle(-1322, -243, 30));
		AddSpawnPoint("f_siauliai_35_1.Id3", "f_siauliai_35_1", Rectangle(-1216, -271, 30));

		// 'Rootcrystal_01' GenType 16 Spawn Points
		AddSpawnPoint("f_siauliai_35_1.Id4", "f_siauliai_35_1", Rectangle(-183, 760, 100));
		AddSpawnPoint("f_siauliai_35_1.Id4", "f_siauliai_35_1", Rectangle(34, 493, 100));
		AddSpawnPoint("f_siauliai_35_1.Id4", "f_siauliai_35_1", Rectangle(893, 403, 100));
		AddSpawnPoint("f_siauliai_35_1.Id4", "f_siauliai_35_1", Rectangle(867, 192, 100));
		AddSpawnPoint("f_siauliai_35_1.Id4", "f_siauliai_35_1", Rectangle(278, 552, 100));
		AddSpawnPoint("f_siauliai_35_1.Id4", "f_siauliai_35_1", Rectangle(829, 870, 100));
		AddSpawnPoint("f_siauliai_35_1.Id4", "f_siauliai_35_1", Rectangle(806, 1135, 100));
		AddSpawnPoint("f_siauliai_35_1.Id4", "f_siauliai_35_1", Rectangle(18, 1534, 100));
		AddSpawnPoint("f_siauliai_35_1.Id4", "f_siauliai_35_1", Rectangle(32, 1325, 100));
		AddSpawnPoint("f_siauliai_35_1.Id4", "f_siauliai_35_1", Rectangle(-9, 0, 100));
		AddSpawnPoint("f_siauliai_35_1.Id4", "f_siauliai_35_1", Rectangle(-209, -175, 100));
		AddSpawnPoint("f_siauliai_35_1.Id4", "f_siauliai_35_1", Rectangle(-113, -613, 100));
		AddSpawnPoint("f_siauliai_35_1.Id4", "f_siauliai_35_1", Rectangle(180, -553, 100));
		AddSpawnPoint("f_siauliai_35_1.Id4", "f_siauliai_35_1", Rectangle(-6, -874, 100));
		AddSpawnPoint("f_siauliai_35_1.Id4", "f_siauliai_35_1", Rectangle(-900, -21, 100));
		AddSpawnPoint("f_siauliai_35_1.Id4", "f_siauliai_35_1", Rectangle(-636, 1, 100));
		AddSpawnPoint("f_siauliai_35_1.Id4", "f_siauliai_35_1", Rectangle(-873, 190, 100));
		AddSpawnPoint("f_siauliai_35_1.Id4", "f_siauliai_35_1", Rectangle(-815, 647, 100));
		AddSpawnPoint("f_siauliai_35_1.Id4", "f_siauliai_35_1", Rectangle(-723, 485, 100));
		AddSpawnPoint("f_siauliai_35_1.Id4", "f_siauliai_35_1", Rectangle(-1346, 1105, 100));
		AddSpawnPoint("f_siauliai_35_1.Id4", "f_siauliai_35_1", Rectangle(-1414, 878, 100));
		AddSpawnPoint("f_siauliai_35_1.Id4", "f_siauliai_35_1", Rectangle(-1543, -316, 100));
		AddSpawnPoint("f_siauliai_35_1.Id4", "f_siauliai_35_1", Rectangle(-1301, -290, 100));
		AddSpawnPoint("f_siauliai_35_1.Id4", "f_siauliai_35_1", Rectangle(547, -476, 100));
		AddSpawnPoint("f_siauliai_35_1.Id4", "f_siauliai_35_1", Rectangle(727, -373, 100));
		AddSpawnPoint("f_siauliai_35_1.Id4", "f_siauliai_35_1", Rectangle(935, -532, 100));
		AddSpawnPoint("f_siauliai_35_1.Id4", "f_siauliai_35_1", Rectangle(22, -331, 100));
	}
}
