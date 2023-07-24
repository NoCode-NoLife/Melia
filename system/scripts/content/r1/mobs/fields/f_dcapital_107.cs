//--- Melia Script -----------------------------------------------------------
// Frienel Memorial Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_dcapital_107'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FDcapital107MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_dcapital_107", MonsterId.Kigle, Properties("MHP", 759679, "MINPATK", 10270, "MAXPATK", 12524, "MINMATK", 10270, "MAXMATK", 12524, "DEF", 235317, "MDEF", 235317));
		AddPropertyOverrides("f_dcapital_107", MonsterId.Kiglelops, Properties("MHP", 761094, "MINPATK", 10288, "MAXPATK", 12547, "MINMATK", 10288, "MAXMATK", 12547, "DEF", 236509, "MDEF", 236509));
		AddPropertyOverrides("f_dcapital_107", MonsterId.Bishop_Blanco, Properties("MHP", 762561, "MINPATK", 10307, "MAXPATK", 12570, "MINMATK", 10307, "MAXMATK", 12570, "DEF", 237744, "MDEF", 237744));
		AddPropertyOverrides("f_dcapital_107", MonsterId.Bishop_Gray, Properties("MHP", 764078, "MINPATK", 10326, "MAXPATK", 12594, "MINMATK", 10326, "MAXMATK", 12594, "DEF", 239021, "MDEF", 239021));

		// Monster Spawners ---------------------------------

		AddSpawner("f_dcapital_107.Id1", MonsterId.Rootcrystal_01, min: 27, max: 35, respawn: TimeSpan.FromMilliseconds(25000));
		AddSpawner("f_dcapital_107.Id2", MonsterId.Kigle, min: 44, max: 58);
		AddSpawner("f_dcapital_107.Id3", MonsterId.Kiglelops, min: 8, max: 10);
		AddSpawner("f_dcapital_107.Id4", MonsterId.Bishop_Blanco, min: 18, max: 24);
		AddSpawner("f_dcapital_107.Id5", MonsterId.Bishop_Gray, min: 18, max: 24);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 3 Spawn Points
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(384, -1096, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(772, -1134, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(1175, -1111, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(1351, -816, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(1397, -1026, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(373, -572, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(251, -379, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(550, -283, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(615, -509, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-81, -860, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-314, -927, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-424, -691, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-177, -623, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-769, -860, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-1040, -922, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-1341, -892, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-1514, -766, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-1340, -544, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-1276, -701, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-1101, -242, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-925, 155, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-924, 562, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-920, 827, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-719, 807, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-1130, 740, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-1496, 289, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-1465, 541, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-1297, 392, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-228, 5, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-208, 198, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(182, 255, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-15, 102, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(20, 250, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(138, -190, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(568, 26, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(412, 200, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(645, 170, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(1104, 138, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(1222, 14, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(1270, 375, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(1370, 218, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(1521, 404, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(1583, 217, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(1789, 421, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(1841, 248, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(1157, 664, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(1152, 913, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(838, 846, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(1014, 780, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(229, 821, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-39, 786, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(78, 651, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-280, 695, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(25, 1311, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-35, 1554, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(135, 1455, 100));

		// 'Kigle' GenType 15 Spawn Points
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(1256, -809, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(1393, -806, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(1420, -1092, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(1230, -1113, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(1018, -1058, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(950, -1269, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(739, -1129, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(439, -1157, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(477, -1016, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(208, -955, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(385, -892, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(346, -711, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-131, -855, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-349, -925, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-550, -885, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-498, -585, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-293, -726, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-203, -401, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-769, -869, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-1143, -890, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-1654, -744, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-1511, -957, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-1476, -620, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-1328, -887, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-1265, -531, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-1233, -724, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-1184, -256, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-940, -83, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-1094, 37, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-770, -12, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-743, 221, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-901, 222, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-913, 492, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-812, 697, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-829, 901, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-914, 814, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-1082, 917, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-1221, 733, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-1084, 670, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-1252, 349, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-1368, 554, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-1547, 223, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-1558, 407, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-1705, 476, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-1629, 657, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(247, -419, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(542, -600, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(548, -298, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(122, -130, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-199, 126, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(162, 250, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(668, 194, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-100, -562, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-64, -714, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-1481, -789, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-918, 53, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(578, -1067, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(1225, -977, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(322, -1058, 25));

		// 'Kiglelops' GenType 16 Spawn Points
		AddSpawnPoint("f_dcapital_107.Id3", "f_dcapital_107", Rectangle(1336, -874, 25));
		AddSpawnPoint("f_dcapital_107.Id3", "f_dcapital_107", Rectangle(1040, -1143, 25));
		AddSpawnPoint("f_dcapital_107.Id3", "f_dcapital_107", Rectangle(321, -1052, 25));
		AddSpawnPoint("f_dcapital_107.Id3", "f_dcapital_107", Rectangle(-161, -587, 25));
		AddSpawnPoint("f_dcapital_107.Id3", "f_dcapital_107", Rectangle(-443, -827, 25));
		AddSpawnPoint("f_dcapital_107.Id3", "f_dcapital_107", Rectangle(-906, -860, 25));
		AddSpawnPoint("f_dcapital_107.Id3", "f_dcapital_107", Rectangle(-1327, -888, 25));
		AddSpawnPoint("f_dcapital_107.Id3", "f_dcapital_107", Rectangle(-1475, -622, 25));
		AddSpawnPoint("f_dcapital_107.Id3", "f_dcapital_107", Rectangle(-1084, -86, 25));
		AddSpawnPoint("f_dcapital_107.Id3", "f_dcapital_107", Rectangle(-783, 187, 25));
		AddSpawnPoint("f_dcapital_107.Id3", "f_dcapital_107", Rectangle(-915, 820, 25));
		AddSpawnPoint("f_dcapital_107.Id3", "f_dcapital_107", Rectangle(-1427, 425, 25));
		AddSpawnPoint("f_dcapital_107.Id3", "f_dcapital_107", Rectangle(460, -529, 25));
		AddSpawnPoint("f_dcapital_107.Id3", "f_dcapital_107", Rectangle(559, 128, 25));

		// 'Bishop_Blanco' GenType 17 Spawn Points
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(578, 286, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(456, -462, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(-40, 266, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(545, -5, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(1166, 116, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(1237, 515, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(1542, 247, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(1754, 437, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(904, 920, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(443, 724, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(205, 962, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(127, 614, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(-217, 775, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(-18, 1166, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(-36, 1568, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(143, 1436, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(-20, 668, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(-124, 81, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(616, -276, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(174, -162, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(191, -510, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(944, 147, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(1410, 428, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(446, 908, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(326, -345, 25));

		// 'Bishop_Gray' GenType 18 Spawn Points
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(324, -579, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(189, -301, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(457, 164, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(39, 90, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(286, 790, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(-48, 851, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(649, 897, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(885, 694, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(1080, 840, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(1311, 299, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(1570, 421, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(1764, 292, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(-51, 1369, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(-259, -87, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(-295, 295, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(81, 427, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(1132, 344, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(485, -141, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(578, -647, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(119, 808, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(1175, 721, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(721, 93, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(-295, 130, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(231, 281, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(-309, 670, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(427, -675, 25));
	}
}
