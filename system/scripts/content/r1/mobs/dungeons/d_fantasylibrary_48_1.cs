//--- Melia Script -----------------------------------------------------------
// Sausis Room 9 Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_fantasylibrary_48_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DFantasylibrary481MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_fantasylibrary_48_1", MonsterId.Page_Mimic, Properties("MHP", 527238, "MINPATK", 7281, "MAXPATK", 8850, "MINMATK", 7281, "MAXMATK", 8850, "DEF", 91407, "MDEF", 91407));
		AddPropertyOverrides("d_fantasylibrary_48_1", MonsterId.Bookmark_Mimic, Properties("MHP", 528664, "MINPATK", 7299, "MAXPATK", 8872, "MINMATK", 7299, "MAXMATK", 8872, "DEF", 92112, "MDEF", 92112));
		AddPropertyOverrides("d_fantasylibrary_48_1", MonsterId.Oscuro, Properties("MHP", 530281, "MINPATK", 7320, "MAXPATK", 8898, "MINMATK", 7320, "MAXMATK", 8898, "DEF", 92912, "MDEF", 92912));
		AddPropertyOverrides("d_fantasylibrary_48_1", MonsterId.Claro, Properties("MHP", 532069, "MINPATK", 7343, "MAXPATK", 8926, "MINMATK", 7343, "MAXMATK", 8926, "DEF", 93796, "MDEF", 93796));

		// Monster Spawners ---------------------------------

		AddSpawner("d_fantasylibrary_48_1.Id1", MonsterId.Rootcrystal_03, min: 23, max: 30, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("d_fantasylibrary_48_1.Id2", MonsterId.Page_Mimic, min: 68, max: 90);
		AddSpawner("d_fantasylibrary_48_1.Id3", MonsterId.Bookmark_Mimic, min: 30, max: 40);
		AddSpawner("d_fantasylibrary_48_1.Id4", MonsterId.Oscuro, min: 14, max: 18);
		AddSpawner("d_fantasylibrary_48_1.Id5", MonsterId.Claro, min: 30, max: 40);
		AddSpawner("d_fantasylibrary_48_1.Id6", MonsterId.Oscuro, min: 17, max: 22);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_03' GenType 10 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(-1185, -1341, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(-1232, -1128, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(-994, -1233, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(-1357, -797, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(-1483, -575, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(-1326, -599, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(-694, -1072, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(-688, -760, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(-687, -601, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(-465, -732, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(-407, -442, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(-485, -349, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(-838, -492, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(-1069, -473, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(-1230, -268, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(-1291, -95, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(-1141, -169, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(-976, 305, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(-1072, 369, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(-1022, 545, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(-946, 461, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(-490, 535, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(-417, 736, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(-136, 732, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(135, 751, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(-5, 811, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(-9, 191, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(-55, 394, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(145, 333, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(162, 156, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(921, 168, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(663, 139, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(888, -29, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(783, 137, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(695, -90, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(208, -579, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(101, -407, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(274, -432, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(1365, -476, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(1296, -371, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(1466, -409, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(1458, 59, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(1320, 91, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(1332, 286, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(1554, 287, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(1528, 144, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(1472, 806, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(1291, 908, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(1333, 1061, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(1551, 1006, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(1625, 1111, 100));
		AddSpawnPoint("d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Rectangle(1451, 958, 100));

		// 'Page_Mimic' GenType 15 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-1075, 363, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-947, 366, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-956, 477, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-1136, 498, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-979, 547, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-1104, 194, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-1082, 33, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-1185, 57, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-1328, 34, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-1301, -141, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-1221, -47, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-1128, -201, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-1372, -486, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-1315, -609, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-1455, -628, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-1478, -849, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-1318, -709, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-1340, -827, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-1244, -1124, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-1243, -1281, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-1062, -1164, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-1129, -1358, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-995, -1290, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-1194, -890, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-811, -488, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-751, -673, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-606, -542, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-506, -729, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-389, -461, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-521, -352, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-718, -1280, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-654, -1199, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-752, -1133, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-732, -1023, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-565, -1082, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-1039, -490, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(96, -391, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(67, -553, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(169, -676, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(317, -623, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(427, -419, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(283, -440, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-588, 760, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-604, 631, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-430, 786, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-538, 534, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-399, 567, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-75, 820, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-100, 728, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-17, 645, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(124, 811, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(98, 710, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(2, 912, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-67, 127, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(61, 326, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(58, 195, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(90, 48, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(233, 233, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(633, -104, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(785, 51, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(914, 219, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(773, 231, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(619, 40, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(874, -63, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(1317, -421, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(1428, -501, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(1513, -381, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(1396, -153, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(504, -280, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(772, -156, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(1285, 248, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(1408, 323, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(1549, 271, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(1536, 88, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(1412, 103, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(1293, -9, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(1445, 659, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(1568, 791, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(1370, 811, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(1432, 1035, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(1238, 945, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(1649, 1111, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-745, -356, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-641, -262, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(597, 192, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-1433, 7, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(1055, 226, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Rectangle(-390, -620, 40));

		// 'Bookmark_Mimic' GenType 16 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(-1296, -1164, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(-1314, -1251, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(-1269, -1343, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(-1174, -1299, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(-1178, -1172, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(-1112, -1278, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(-979, -1205, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(-1144, -1060, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(-1035, -1085, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(-1212, -1436, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(-855, -536, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(-837, -630, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(-700, -529, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(-681, -761, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(-596, -635, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(-498, -604, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(-596, -806, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(-511, -463, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(-274, -539, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(-284, -404, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(-661, -1104, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(-768, -1203, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(-621, -1228, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(-821, -416, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(-699, -835, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(-145, -472, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(-421, -356, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(1222, 1047, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(1324, 1155, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(1247, 803, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(1323, 985, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(1397, 907, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(1472, 732, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(1611, 645, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(1621, 880, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(1486, 871, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(1505, 967, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(1660, 994, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(1508, 1103, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Rectangle(1657, 1185, 40));

		// 'Oscuro' GenType 17 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_1.Id4", "d_fantasylibrary_48_1", Rectangle(-1294, -47, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id4", "d_fantasylibrary_48_1", Rectangle(-1302, -213, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id4", "d_fantasylibrary_48_1", Rectangle(-1225, -283, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id4", "d_fantasylibrary_48_1", Rectangle(-1214, -179, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id4", "d_fantasylibrary_48_1", Rectangle(-1061, -143, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id4", "d_fantasylibrary_48_1", Rectangle(-1104, -84, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id4", "d_fantasylibrary_48_1", Rectangle(-1176, -114, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id4", "d_fantasylibrary_48_1", Rectangle(-1257, 98, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id4", "d_fantasylibrary_48_1", Rectangle(-1138, 388, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id4", "d_fantasylibrary_48_1", Rectangle(-1053, 269, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id4", "d_fantasylibrary_48_1", Rectangle(-1016, 321, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id4", "d_fantasylibrary_48_1", Rectangle(-928, 297, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id4", "d_fantasylibrary_48_1", Rectangle(-1018, 432, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id4", "d_fantasylibrary_48_1", Rectangle(-890, 450, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id4", "d_fantasylibrary_48_1", Rectangle(-1072, 559, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id4", "d_fantasylibrary_48_1", Rectangle(-1216, 465, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id4", "d_fantasylibrary_48_1", Rectangle(-898, 536, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id4", "d_fantasylibrary_48_1", Rectangle(-1042, 496, 40));

		// 'Claro' GenType 18 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(-1494, -512, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(-1423, -546, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(-1515, -683, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(-1473, -751, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(-1403, -688, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(-1263, -780, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(-1253, -493, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(-1305, -432, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(108, -468, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(214, -354, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(172, -596, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(230, -526, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(365, -525, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(363, -332, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(67, -654, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(6, -359, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(562, -34, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(701, -1, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(762, -53, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(879, -157, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(957, -35, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(902, 84, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(709, 142, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(660, 272, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(1324, -516, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(1413, -410, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(1527, -481, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(599, -173, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(840, 163, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(480, 225, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(1248, 356, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(1511, 359, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(1247, 72, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(1244, 172, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(1324, 147, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(1421, 229, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(1399, 9, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(1581, 6, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(1508, 182, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Rectangle(1604, 139, 40));

		// 'Oscuro' GenType 19 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Rectangle(-508, 706, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Rectangle(-412, 651, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Rectangle(-325, 692, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Rectangle(-600, 497, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Rectangle(-662, 692, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Rectangle(-392, 504, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Rectangle(-517, 607, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Rectangle(16, 749, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Rectangle(-87, 658, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Rectangle(58, 658, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Rectangle(-110, 866, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Rectangle(31, 825, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Rectangle(66, 762, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Rectangle(-290, 758, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Rectangle(48, 424, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Rectangle(-153, 238, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Rectangle(-11, 291, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Rectangle(-99, 181, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Rectangle(114, 258, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Rectangle(-26, 33, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Rectangle(180, 87, 40));
		AddSpawnPoint("d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Rectangle(94, 152, 40));
	}
}
