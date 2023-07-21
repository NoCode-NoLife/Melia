//--- Melia Script -----------------------------------------------------------
// Inner Enceinte District Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_flash_64'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FFlash64MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_flash_64", MonsterId.Repusbunny, Properties("MHP", 277296, "MINPATK", 4067, "MAXPATK", 4900, "MINMATK", 4067, "MAXMATK", 4900, "DEF", 17096, "MDEF", 17096));
		AddPropertyOverrides("f_flash_64", MonsterId.Lemuria, Properties("MHP", 278513, "MINPATK", 4083, "MAXPATK", 4919, "MINMATK", 4083, "MAXMATK", 4919, "DEF", 17322, "MDEF", 17322));
		AddPropertyOverrides("f_flash_64", MonsterId.Rubabos, Properties("MHP", 279820, "MINPATK", 4100, "MAXPATK", 4940, "MINMATK", 4100, "MAXMATK", 4940, "DEF", 17564, "MDEF", 17564));
		AddPropertyOverrides("f_flash_64", MonsterId.Saltisdaughter_Bow, Properties("MHP", 281211, "MINPATK", 4117, "MAXPATK", 4962, "MINMATK", 4117, "MAXMATK", 4962, "DEF", 17822, "MDEF", 17822));
		AddPropertyOverrides("f_flash_64", MonsterId.Boss_Gargoyle, Properties("MHP", 1441682, "MINPATK", 5708, "MAXPATK", 6880, "MINMATK", 5708, "MAXMATK", 6880, "DEF", 0, "MDEF", 0));

		// Monster Spawners ---------------------------------

		AddSpawner("f_flash_64.Id1", MonsterId.Repusbunny, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_64.Id2", MonsterId.Lemuria, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_64.Id3", MonsterId.Rubabos, 6, 7, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_64.Id4", MonsterId.Lemuria, 12, 16, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_64.Id5", MonsterId.Repusbunny, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_64.Id6", MonsterId.Lemuria, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_64.Id7", MonsterId.Saltisdaughter_Bow, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_64.Id8", MonsterId.Rootcrystal_01, 12, 15, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("f_flash_64.Id9", MonsterId.Lemuria, 57, 76, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_64.Id10", MonsterId.Wood_Carving, 3, 3, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Repusbunny' GenType 2 Spawn Points
		AddSpawnPoint("f_flash_64.Id1", "f_flash_64", Rectangle(2, -403, 9999));

		// 'Lemuria' GenType 3 Spawn Points
		AddSpawnPoint("f_flash_64.Id2", "f_flash_64", Rectangle(-1197, -135, 9999));

		// 'Rubabos' GenType 4 Spawn Points
		AddSpawnPoint("f_flash_64.Id3", "f_flash_64", Rectangle(1413, 730, 30));
		AddSpawnPoint("f_flash_64.Id3", "f_flash_64", Rectangle(1175, 1232, 30));
		AddSpawnPoint("f_flash_64.Id3", "f_flash_64", Rectangle(1384, 606, 30));
		AddSpawnPoint("f_flash_64.Id3", "f_flash_64", Rectangle(980, 535, 30));
		AddSpawnPoint("f_flash_64.Id3", "f_flash_64", Rectangle(1494, -155, 30));
		AddSpawnPoint("f_flash_64.Id3", "f_flash_64", Rectangle(1325, 136, 30));
		AddSpawnPoint("f_flash_64.Id3", "f_flash_64", Rectangle(1047, 62, 30));

		// 'Lemuria' GenType 5 Spawn Points
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(-1024, -213, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(-1352, -104, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(81, -615, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(-260, -531, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(-41, -776, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(-491, -632, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(-1195, -207, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(-1228, 321, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(-143, 1942, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(-177, 1106, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(-165, 1272, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(-537, 354, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(-1068, 561, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(-819, 714, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(-1053, 693, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(-431, 948, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(-559, 806, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(946, 621, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(1016, 393, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(1491, 444, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(1483, 630, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(1191, 1225, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(742, 997, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(1116, -83, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(1192, 88, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(1549, 21, 30));

		// 'Repusbunny' GenType 6 Spawn Points
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(-1323, -249, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(-325, -560, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(10, -599, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(-59, -1783, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(-1002, -303, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(-1260, 248, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(-580, 353, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(-149, 732, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(-199, 532, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(-287, 1597, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(-174, 1754, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(-117, 1637, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(-65, -374, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(326, -1240, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(1363, 50, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(1470, -49, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(1214, -127, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(1022, -23, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(1098, 433, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(926, 691, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(1463, 521, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(-70, 1555, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(-39, 1878, 30));

		// 'Lemuria' GenType 18 Spawn Points
		AddSpawnPoint("f_flash_64.Id6", "f_flash_64", Rectangle(1129, 351, 20));
		AddSpawnPoint("f_flash_64.Id6", "f_flash_64", Rectangle(916, 562, 20));
		AddSpawnPoint("f_flash_64.Id6", "f_flash_64", Rectangle(1342, 782, 20));
		AddSpawnPoint("f_flash_64.Id6", "f_flash_64", Rectangle(1560, 689, 20));
		AddSpawnPoint("f_flash_64.Id6", "f_flash_64", Rectangle(1384, 454, 20));
		AddSpawnPoint("f_flash_64.Id6", "f_flash_64", Rectangle(1164, 660, 20));

		// 'Saltisdaughter_Bow' GenType 22 Spawn Points
		AddSpawnPoint("f_flash_64.Id7", "f_flash_64", Rectangle(-165, 1070, 35));
		AddSpawnPoint("f_flash_64.Id7", "f_flash_64", Rectangle(-331, 1714, 35));
		AddSpawnPoint("f_flash_64.Id7", "f_flash_64", Rectangle(-4, 1774, 35));
		AddSpawnPoint("f_flash_64.Id7", "f_flash_64", Rectangle(-256, 1894, 35));
		AddSpawnPoint("f_flash_64.Id7", "f_flash_64", Rectangle(32, 1581, 35));
		AddSpawnPoint("f_flash_64.Id7", "f_flash_64", Rectangle(-164, 790, 35));
		AddSpawnPoint("f_flash_64.Id7", "f_flash_64", Rectangle(-375, 646, 35));
		AddSpawnPoint("f_flash_64.Id7", "f_flash_64", Rectangle(-1164, 199, 35));
		AddSpawnPoint("f_flash_64.Id7", "f_flash_64", Rectangle(-766, 358, 35));
		AddSpawnPoint("f_flash_64.Id7", "f_flash_64", Rectangle(-169, 1518, 35));
		AddSpawnPoint("f_flash_64.Id7", "f_flash_64", Rectangle(-389, 907, 35));
		AddSpawnPoint("f_flash_64.Id7", "f_flash_64", Rectangle(-251, 630, 35));
		AddSpawnPoint("f_flash_64.Id7", "f_flash_64", Rectangle(-1421, -132, 35));
		AddSpawnPoint("f_flash_64.Id7", "f_flash_64", Rectangle(-1124, -233, 35));
		AddSpawnPoint("f_flash_64.Id7", "f_flash_64", Rectangle(-1150, -356, 35));

		// 'Rootcrystal_01' GenType 29 Spawn Points
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(-130, -1794, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(-100, -2324, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(-365, -1609, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(50, -1493, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(-254, -575, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(-146, -431, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(3, -624, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(-200, 91, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(338, 477, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(-754, 374, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(-1117, 250, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(-1355, -64, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(-1134, -283, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(-1085, -530, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(-944, 632, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(-320, 725, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(-102, 754, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(-115, 1559, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(72, 1683, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(-107, 1925, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(-291, 1900, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(-165, 1062, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(1478, -12, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(1146, 17, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(1083, 376, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(1431, 654, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(846, 685, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(1184, 1155, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(627, 325, 100));

		// 'Lemuria' GenType 38 Spawn Points
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-442, -1663, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-394, -1416, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-131, -1726, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-46, -1426, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(35, -1479, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-62, -1641, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-149, -1384, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-88, -1860, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-47, -1947, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-72, -2045, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-256, -1796, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(45, -1599, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-333, -1639, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-187, -1831, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-205, -1696, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-189, -1498, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-93, -1528, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-294, -1717, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-328, -1527, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-280, -1353, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-192, -1608, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-45, -1730, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(52, -708, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(83, -486, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-16, -511, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-132, -299, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-192, -383, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-360, -652, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-444, -541, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-355, -473, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-273, -385, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-165, -502, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-87, -443, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-238, -667, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-159, -590, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-77, -598, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-71, -699, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-1381, -202, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-1231, -291, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-1076, -291, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-1052, -404, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-965, -353, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-923, -276, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-1293, -181, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-1272, -92, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-1128, -88, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-1064, -161, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-1008, 153, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-1114, 296, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-1118, 92, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-1254, 149, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-1019, 270, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-967, 616, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-1122, 647, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-938, 690, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-848, 640, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-880, 560, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-366, 745, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-262, 759, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-222, 688, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-102, 678, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-116, 601, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(1295, -6, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(1441, 87, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(1319, -165, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(1376, -101, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(1189, -28, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(846, 550, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(993, 676, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(1280, 737, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(1277, 631, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(1553, 555, 20));

		// 'Wood_Carving' GenType 1001 Spawn Points
		AddSpawnPoint("f_flash_64.Id10", "f_flash_64", Rectangle(-450, -1710, 20));
		AddSpawnPoint("f_flash_64.Id10", "f_flash_64", Rectangle(-491, -1635, 20));
		AddSpawnPoint("f_flash_64.Id10", "f_flash_64", Rectangle(-442, -1575, 20));
	}
}
