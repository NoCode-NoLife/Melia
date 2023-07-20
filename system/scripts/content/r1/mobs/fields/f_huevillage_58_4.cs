//--- Melia Script -----------------------------------------------------------
// Septyni Glen Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_huevillage_58_4'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FHuevillage584MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_huevillage_58_4", MonsterId.Beeteros, Properties("MHP", 33335, "MINPATK", 929, "MAXPATK", 1044, "MINMATK", 929, "MAXMATK", 1044, "DEF", 177, "MDEF", 177));
		AddPropertyOverrides("f_huevillage_58_4", MonsterId.Mentiwood, Properties("MHP", 33952, "MINPATK", 937, "MAXPATK", 1054, "MINMATK", 937, "MAXMATK", 1054, "DEF", 178, "MDEF", 178));
		AddPropertyOverrides("f_huevillage_58_4", MonsterId.Carcashu, Properties("MHP", 34589, "MINPATK", 946, "MAXPATK", 1064, "MINMATK", 946, "MAXMATK", 1064, "DEF", 178, "MDEF", 178));
		AddPropertyOverrides("f_huevillage_58_4", MonsterId.Tiny_Mage, Properties("MHP", 35243, "MINPATK", 954, "MAXPATK", 1075, "MINMATK", 954, "MAXMATK", 1075, "DEF", 179, "MDEF", 179));
		AddPropertyOverrides("f_huevillage_58_4", MonsterId.Boss_Harpeia, Properties("MHP", 170234, "MINPATK", 1964, "MAXPATK", 2214, "MINMATK", 1964, "MAXMATK", 2214, "DEF", 368, "MDEF", 368));
		AddPropertyOverrides("f_huevillage_58_4", MonsterId.Boss_Merge, Properties("MHP", 173497, "MINPATK", 1982, "MAXPATK", 2236, "MINMATK", 1982, "MAXMATK", 2236, "DEF", 370, "MDEF", 370));
		AddPropertyOverrides("f_huevillage_58_4", MonsterId.Boss_Mothstem, Properties("MHP", 176840, "MINPATK", 2000, "MAXPATK", 2259, "MINMATK", 2000, "MAXMATK", 2259, "DEF", 372, "MDEF", 372));
		AddPropertyOverrides("f_huevillage_58_4", MonsterId.Boss_Clymen, Properties("MHP", 180259, "MINPATK", 2019, "MAXPATK", 2282, "MINMATK", 2019, "MAXMATK", 2282, "DEF", 374, "MDEF", 374));

		// Monster Spawners ---------------------------------

		AddSpawner("f_huevillage_58_4.Id1", MonsterId.Beeteros, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_4.Id2", MonsterId.Mentiwood, 3, 3, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_4.Id3", MonsterId.Carcashu, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_4.Id4", MonsterId.Rootcrystal_01, 9, 11, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_4.Id5", MonsterId.Carcashu, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_4.Id6", MonsterId.Tiny_Mage, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_4.Id7", MonsterId.Tiny_Mage, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_4.Id8", MonsterId.Beeteros, 4, 5, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Beeteros' GenType 21 Spawn Points
		AddSpawnPoint("f_huevillage_58_4.Id1", "f_huevillage_58_4", Rectangle(70, -748, 9999));

		// 'Mentiwood' GenType 22 Spawn Points
		AddSpawnPoint("f_huevillage_58_4.Id2", "f_huevillage_58_4", Rectangle(538, -194, 9999));

		// 'Carcashu' GenType 23 Spawn Points
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-1074, -812, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-734, -671, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(1345, 696, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(1378, 759, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(1240, 549, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(1362, 514, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(1314, 393, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(1448, 337, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(1270, 230, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(1365, 111, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(1275, 27, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(1188, 30, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(858, 123, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(977, 162, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(1560, -171, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(1504, 190, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(1416, -19, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(1221, -175, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(1157, -201, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(1148, -333, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(1201, -375, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(1291, -429, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(1207, -531, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(1389, -326, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(901, -322, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(903, -238, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(895, -183, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(849, -285, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(822, -132, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(733, -137, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(729, -375, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(768, -335, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(578, -333, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(662, -146, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(699, -78, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(595, -75, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(529, -133, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(443, 858, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(521, 766, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(619, 736, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(584, 655, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(554, 575, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(462, 552, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(352, 708, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(260, 604, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(348, 457, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(204, 475, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(128, 422, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(181, 244, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(122, 131, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(97, 202, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(78, 292, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-24, 158, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-65, 366, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-247, 139, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-402, 170, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-238, 306, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-399, 355, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-598, 586, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-536, 551, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-529, 594, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-711, 471, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-702, 367, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-895, 281, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-930, 184, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(129, -603, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(11, -949, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(127, -991, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(179, -946, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(223, -904, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(119, -921, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-68, -838, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(204, -747, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-41, -653, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-28, -586, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-4, -541, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-325, -469, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-502, -561, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-728, -588, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-679, -787, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-765, -1063, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-844, -1063, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-728, -944, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-640, -897, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-820, -567, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-949, -408, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-951, -480, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-1025, -678, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-1147, -879, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-984, -949, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-994, -171, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-1024, -27, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-1127, -30, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-1210, -189, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-1184, -358, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-1413, -438, 25));
		AddSpawnPoint("f_huevillage_58_4.Id3", "f_huevillage_58_4", Rectangle(-1200, -450, 25));

		// 'Rootcrystal_01' GenType 31 Spawn Points
		AddSpawnPoint("f_huevillage_58_4.Id4", "f_huevillage_58_4", Rectangle(-951, -482, 200));
		AddSpawnPoint("f_huevillage_58_4.Id4", "f_huevillage_58_4", Rectangle(-310, 300, 200));
		AddSpawnPoint("f_huevillage_58_4.Id4", "f_huevillage_58_4", Rectangle(-217, -365, 200));
		AddSpawnPoint("f_huevillage_58_4.Id4", "f_huevillage_58_4", Rectangle(205, -745, 200));
		AddSpawnPoint("f_huevillage_58_4.Id4", "f_huevillage_58_4", Rectangle(330, -194, 200));
		AddSpawnPoint("f_huevillage_58_4.Id4", "f_huevillage_58_4", Rectangle(825, -128, 200));
		AddSpawnPoint("f_huevillage_58_4.Id4", "f_huevillage_58_4", Rectangle(1223, -479, 200));
		AddSpawnPoint("f_huevillage_58_4.Id4", "f_huevillage_58_4", Rectangle(1385, 689, 200));
		AddSpawnPoint("f_huevillage_58_4.Id4", "f_huevillage_58_4", Rectangle(915, 825, 200));
		AddSpawnPoint("f_huevillage_58_4.Id4", "f_huevillage_58_4", Rectangle(254, 680, 200));
		AddSpawnPoint("f_huevillage_58_4.Id4", "f_huevillage_58_4", Rectangle(-793, -945, 200));

		// 'Carcashu' GenType 35 Spawn Points
		AddSpawnPoint("f_huevillage_58_4.Id5", "f_huevillage_58_4", Rectangle(-498, 335, 25));
		AddSpawnPoint("f_huevillage_58_4.Id5", "f_huevillage_58_4", Rectangle(-886, 230, 25));
		AddSpawnPoint("f_huevillage_58_4.Id5", "f_huevillage_58_4", Rectangle(-255, 245, 25));
		AddSpawnPoint("f_huevillage_58_4.Id5", "f_huevillage_58_4", Rectangle(315, 575, 25));
		AddSpawnPoint("f_huevillage_58_4.Id5", "f_huevillage_58_4", Rectangle(482, 726, 25));
		AddSpawnPoint("f_huevillage_58_4.Id5", "f_huevillage_58_4", Rectangle(1254, 669, 25));
		AddSpawnPoint("f_huevillage_58_4.Id5", "f_huevillage_58_4", Rectangle(607, -381, 25));
		AddSpawnPoint("f_huevillage_58_4.Id5", "f_huevillage_58_4", Rectangle(994, 938, 25));
		AddSpawnPoint("f_huevillage_58_4.Id5", "f_huevillage_58_4", Rectangle(1629, -38, 25));
		AddSpawnPoint("f_huevillage_58_4.Id5", "f_huevillage_58_4", Rectangle(-722, 315, 25));
		AddSpawnPoint("f_huevillage_58_4.Id5", "f_huevillage_58_4", Rectangle(891, -124, 25));
		AddSpawnPoint("f_huevillage_58_4.Id5", "f_huevillage_58_4", Rectangle(906, -401, 25));
		AddSpawnPoint("f_huevillage_58_4.Id5", "f_huevillage_58_4", Rectangle(846, 774, 25));
		AddSpawnPoint("f_huevillage_58_4.Id5", "f_huevillage_58_4", Rectangle(1307, 822, 25));
		AddSpawnPoint("f_huevillage_58_4.Id5", "f_huevillage_58_4", Rectangle(375, 861, 25));
		AddSpawnPoint("f_huevillage_58_4.Id5", "f_huevillage_58_4", Rectangle(-673, 454, 25));
		AddSpawnPoint("f_huevillage_58_4.Id5", "f_huevillage_58_4", Rectangle(-560, 575, 25));
		AddSpawnPoint("f_huevillage_58_4.Id5", "f_huevillage_58_4", Rectangle(-647, 203, 25));
		AddSpawnPoint("f_huevillage_58_4.Id5", "f_huevillage_58_4", Rectangle(-434, -552, 25));
		AddSpawnPoint("f_huevillage_58_4.Id5", "f_huevillage_58_4", Rectangle(-500, -511, 25));
		AddSpawnPoint("f_huevillage_58_4.Id5", "f_huevillage_58_4", Rectangle(33, 214, 25));

		// 'Tiny_Mage' GenType 36 Spawn Points
		AddSpawnPoint("f_huevillage_58_4.Id6", "f_huevillage_58_4", Rectangle(-961, -594, 25));
		AddSpawnPoint("f_huevillage_58_4.Id6", "f_huevillage_58_4", Rectangle(-822, -782, 25));
		AddSpawnPoint("f_huevillage_58_4.Id6", "f_huevillage_58_4", Rectangle(-1026, -847, 25));
		AddSpawnPoint("f_huevillage_58_4.Id6", "f_huevillage_58_4", Rectangle(-1219, -378, 25));
		AddSpawnPoint("f_huevillage_58_4.Id6", "f_huevillage_58_4", Rectangle(-764, -526, 25));
		AddSpawnPoint("f_huevillage_58_4.Id6", "f_huevillage_58_4", Rectangle(-655, -643, 25));
		AddSpawnPoint("f_huevillage_58_4.Id6", "f_huevillage_58_4", Rectangle(-1074, -45, 25));
		AddSpawnPoint("f_huevillage_58_4.Id6", "f_huevillage_58_4", Rectangle(-1396, -363, 25));
		AddSpawnPoint("f_huevillage_58_4.Id6", "f_huevillage_58_4", Rectangle(-842, -983, 25));
		AddSpawnPoint("f_huevillage_58_4.Id6", "f_huevillage_58_4", Rectangle(-619, -827, 25));
		AddSpawnPoint("f_huevillage_58_4.Id6", "f_huevillage_58_4", Rectangle(-75, 168, 25));

		// 'Tiny_Mage' GenType 37 Spawn Points
		AddSpawnPoint("f_huevillage_58_4.Id7", "f_huevillage_58_4", Rectangle(807, -65, 25));
		AddSpawnPoint("f_huevillage_58_4.Id7", "f_huevillage_58_4", Rectangle(1329, 249, 25));
		AddSpawnPoint("f_huevillage_58_4.Id7", "f_huevillage_58_4", Rectangle(1199, 647, 25));
		AddSpawnPoint("f_huevillage_58_4.Id7", "f_huevillage_58_4", Rectangle(1015, 893, 25));
		AddSpawnPoint("f_huevillage_58_4.Id7", "f_huevillage_58_4", Rectangle(486, 624, 25));
		AddSpawnPoint("f_huevillage_58_4.Id7", "f_huevillage_58_4", Rectangle(506, 820, 25));
		AddSpawnPoint("f_huevillage_58_4.Id7", "f_huevillage_58_4", Rectangle(1270, -250, 25));
		AddSpawnPoint("f_huevillage_58_4.Id7", "f_huevillage_58_4", Rectangle(1309, 787, 25));
		AddSpawnPoint("f_huevillage_58_4.Id7", "f_huevillage_58_4", Rectangle(267, 665, 25));
		AddSpawnPoint("f_huevillage_58_4.Id7", "f_huevillage_58_4", Rectangle(-212, 205, 25));
		AddSpawnPoint("f_huevillage_58_4.Id7", "f_huevillage_58_4", Rectangle(170, 390, 25));
		AddSpawnPoint("f_huevillage_58_4.Id7", "f_huevillage_58_4", Rectangle(119, 276, 25));
		AddSpawnPoint("f_huevillage_58_4.Id7", "f_huevillage_58_4", Rectangle(-361, -515, 25));

		// 'Beeteros' GenType 47 Spawn Points
		AddSpawnPoint("f_huevillage_58_4.Id8", "f_huevillage_58_4", Rectangle(-560, -565, 25));
		AddSpawnPoint("f_huevillage_58_4.Id8", "f_huevillage_58_4", Rectangle(-144, 354, 25));
		AddSpawnPoint("f_huevillage_58_4.Id8", "f_huevillage_58_4", Rectangle(205, 517, 25));
		AddSpawnPoint("f_huevillage_58_4.Id8", "f_huevillage_58_4", Rectangle(-370, -409, 25));
		AddSpawnPoint("f_huevillage_58_4.Id8", "f_huevillage_58_4", Rectangle(-48, 294, 25));
		AddSpawnPoint("f_huevillage_58_4.Id8", "f_huevillage_58_4", Rectangle(158, 172, 25));
	}
}
