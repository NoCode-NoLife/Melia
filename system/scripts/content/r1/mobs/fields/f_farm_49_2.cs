//--- Melia Script -----------------------------------------------------------
// Shaton Farm Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_farm_49_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FFarm492MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_farm_49_2", MonsterId.Stub_Tree_Orange, Properties("MHP", 220391, "MINPATK", 3335, "MAXPATK", 4000, "MINMATK", 3335, "MAXMATK", 4000, "DEF", 9252, "MDEF", 9252));
		AddPropertyOverrides("f_farm_49_2", MonsterId.Cyst, Properties("MHP", 221149, "MINPATK", 3345, "MAXPATK", 4012, "MINMATK", 3345, "MAXMATK", 4012, "DEF", 9353, "MDEF", 9353));
		AddPropertyOverrides("f_farm_49_2", MonsterId.Flying_Flog_Green, Properties("MHP", 222010, "MINPATK", 3356, "MAXPATK", 4026, "MINMATK", 3356, "MAXMATK", 4026, "DEF", 9468, "MDEF", 9468));
		AddPropertyOverrides("f_farm_49_2", MonsterId.Pendinmire_Paviesa, Properties("MHP", 222961, "MINPATK", 3368, "MAXPATK", 4041, "MINMATK", 3368, "MAXMATK", 4041, "DEF", 9595, "MDEF", 9595));

		// Monster Spawners ---------------------------------

		AddSpawner("f_farm_49_2.Id1", MonsterId.Stub_Tree_Orange, 19, 25, TimeSpan.FromMilliseconds(25000), TendencyType.Aggressive);
		AddSpawner("f_farm_49_2.Id2", MonsterId.Cyst, 22, 29, TimeSpan.FromMilliseconds(25000), TendencyType.Aggressive);
		AddSpawner("f_farm_49_2.Id3", MonsterId.Flying_Flog_Green, 8, 10, TimeSpan.FromMilliseconds(25000), TendencyType.Aggressive);
		AddSpawner("f_farm_49_2.Id4", MonsterId.Flying_Flog_Green, 60, 80, TimeSpan.FromMilliseconds(25000), TendencyType.Aggressive);
		AddSpawner("f_farm_49_2.Id5", MonsterId.Rootcrystal_01, 9, 12, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_farm_49_2.Id6", MonsterId.Pendinmire_Paviesa, 1, 1, TimeSpan.FromMilliseconds(1800000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Stub_Tree_Orange' GenType 3 Spawn Points
		AddSpawnPoint("f_farm_49_2.Id1", "f_farm_49_2", Rectangle(1601, -1158, 25));
		AddSpawnPoint("f_farm_49_2.Id1", "f_farm_49_2", Rectangle(1464, -1332, 25));
		AddSpawnPoint("f_farm_49_2.Id1", "f_farm_49_2", Rectangle(1415, -1472, 25));
		AddSpawnPoint("f_farm_49_2.Id1", "f_farm_49_2", Rectangle(1638, -1444, 25));
		AddSpawnPoint("f_farm_49_2.Id1", "f_farm_49_2", Rectangle(1299, -1343, 25));
		AddSpawnPoint("f_farm_49_2.Id1", "f_farm_49_2", Rectangle(1437, -1190, 25));
		AddSpawnPoint("f_farm_49_2.Id1", "f_farm_49_2", Rectangle(1712, -1322, 25));
		AddSpawnPoint("f_farm_49_2.Id1", "f_farm_49_2", Rectangle(1599, -1286, 25));
		AddSpawnPoint("f_farm_49_2.Id1", "f_farm_49_2", Rectangle(379, -568, 25));
		AddSpawnPoint("f_farm_49_2.Id1", "f_farm_49_2", Rectangle(435, -359, 25));
		AddSpawnPoint("f_farm_49_2.Id1", "f_farm_49_2", Rectangle(583, -447, 25));
		AddSpawnPoint("f_farm_49_2.Id1", "f_farm_49_2", Rectangle(567, -563, 25));
		AddSpawnPoint("f_farm_49_2.Id1", "f_farm_49_2", Rectangle(521, -706, 25));
		AddSpawnPoint("f_farm_49_2.Id1", "f_farm_49_2", Rectangle(799, -588, 25));
		AddSpawnPoint("f_farm_49_2.Id1", "f_farm_49_2", Rectangle(828, -432, 25));
		AddSpawnPoint("f_farm_49_2.Id1", "f_farm_49_2", Rectangle(475, 278, 25));
		AddSpawnPoint("f_farm_49_2.Id1", "f_farm_49_2", Rectangle(407, 466, 25));
		AddSpawnPoint("f_farm_49_2.Id1", "f_farm_49_2", Rectangle(558, 392, 25));
		AddSpawnPoint("f_farm_49_2.Id1", "f_farm_49_2", Rectangle(612, 565, 25));
		AddSpawnPoint("f_farm_49_2.Id1", "f_farm_49_2", Rectangle(654, 260, 25));
		AddSpawnPoint("f_farm_49_2.Id1", "f_farm_49_2", Rectangle(812, 333, 25));
		AddSpawnPoint("f_farm_49_2.Id1", "f_farm_49_2", Rectangle(737, 611, 25));

		// 'Cyst' GenType 6 Spawn Points
		AddSpawnPoint("f_farm_49_2.Id2", "f_farm_49_2", Rectangle(970, 1103, 30));
		AddSpawnPoint("f_farm_49_2.Id2", "f_farm_49_2", Rectangle(548, 1095, 30));
		AddSpawnPoint("f_farm_49_2.Id2", "f_farm_49_2", Rectangle(604, 1253, 30));
		AddSpawnPoint("f_farm_49_2.Id2", "f_farm_49_2", Rectangle(953, 1316, 30));
		AddSpawnPoint("f_farm_49_2.Id2", "f_farm_49_2", Rectangle(-1411, -1611, 30));
		AddSpawnPoint("f_farm_49_2.Id2", "f_farm_49_2", Rectangle(-1343, -1430, 30));
		AddSpawnPoint("f_farm_49_2.Id2", "f_farm_49_2", Rectangle(-74, -1294, 30));
		AddSpawnPoint("f_farm_49_2.Id2", "f_farm_49_2", Rectangle(-191, -1139, 30));
		AddSpawnPoint("f_farm_49_2.Id2", "f_farm_49_2", Rectangle(-1108, -1393, 30));
		AddSpawnPoint("f_farm_49_2.Id2", "f_farm_49_2", Rectangle(-1202, -1471, 30));
		AddSpawnPoint("f_farm_49_2.Id2", "f_farm_49_2", Rectangle(-1289, -1260, 30));
		AddSpawnPoint("f_farm_49_2.Id2", "f_farm_49_2", Rectangle(-1299, -1619, 30));
		AddSpawnPoint("f_farm_49_2.Id2", "f_farm_49_2", Rectangle(-270, -1352, 30));
		AddSpawnPoint("f_farm_49_2.Id2", "f_farm_49_2", Rectangle(90, -1239, 30));
		AddSpawnPoint("f_farm_49_2.Id2", "f_farm_49_2", Rectangle(62, -969, 30));
		AddSpawnPoint("f_farm_49_2.Id2", "f_farm_49_2", Rectangle(-200, -984, 30));
		AddSpawnPoint("f_farm_49_2.Id2", "f_farm_49_2", Rectangle(13, -1096, 30));
		AddSpawnPoint("f_farm_49_2.Id2", "f_farm_49_2", Rectangle(748, 1046, 30));
		AddSpawnPoint("f_farm_49_2.Id2", "f_farm_49_2", Rectangle(607, 1394, 30));
		AddSpawnPoint("f_farm_49_2.Id2", "f_farm_49_2", Rectangle(806, 1426, 30));
		AddSpawnPoint("f_farm_49_2.Id2", "f_farm_49_2", Rectangle(1606, 1202, 30));
		AddSpawnPoint("f_farm_49_2.Id2", "f_farm_49_2", Rectangle(1687, 1406, 30));
		AddSpawnPoint("f_farm_49_2.Id2", "f_farm_49_2", Rectangle(1806, 1221, 30));
		AddSpawnPoint("f_farm_49_2.Id2", "f_farm_49_2", Rectangle(1933, 1316, 30));
		AddSpawnPoint("f_farm_49_2.Id2", "f_farm_49_2", Rectangle(2043, 1264, 30));
		AddSpawnPoint("f_farm_49_2.Id2", "f_farm_49_2", Rectangle(2061, 1385, 30));
		AddSpawnPoint("f_farm_49_2.Id2", "f_farm_49_2", Rectangle(-1541, -1416, 30));

		// 'Flying_Flog_Green' GenType 8 Spawn Points
		AddSpawnPoint("f_farm_49_2.Id3", "f_farm_49_2", Rectangle(-529, -375, 25));
		AddSpawnPoint("f_farm_49_2.Id3", "f_farm_49_2", Rectangle(-308, -481, 25));
		AddSpawnPoint("f_farm_49_2.Id3", "f_farm_49_2", Rectangle(-128, -388, 25));
		AddSpawnPoint("f_farm_49_2.Id3", "f_farm_49_2", Rectangle(11, -216, 25));
		AddSpawnPoint("f_farm_49_2.Id3", "f_farm_49_2", Rectangle(-132, -25, 25));
		AddSpawnPoint("f_farm_49_2.Id3", "f_farm_49_2", Rectangle(-418, -108, 25));
		AddSpawnPoint("f_farm_49_2.Id3", "f_farm_49_2", Rectangle(-584, -114, 25));
		AddSpawnPoint("f_farm_49_2.Id3", "f_farm_49_2", Rectangle(-318, 77, 25));
		AddSpawnPoint("f_farm_49_2.Id3", "f_farm_49_2", Rectangle(1656, 1269, 25));
		AddSpawnPoint("f_farm_49_2.Id3", "f_farm_49_2", Rectangle(504, 1182, 25));
		AddSpawnPoint("f_farm_49_2.Id3", "f_farm_49_2", Rectangle(756, 1070, 25));
		AddSpawnPoint("f_farm_49_2.Id3", "f_farm_49_2", Rectangle(-1392, -1479, 25));
		AddSpawnPoint("f_farm_49_2.Id3", "f_farm_49_2", Rectangle(-1331, -1328, 25));
		AddSpawnPoint("f_farm_49_2.Id3", "f_farm_49_2", Rectangle(-1152, -1529, 25));
		AddSpawnPoint("f_farm_49_2.Id3", "f_farm_49_2", Rectangle(-354, -293, 25));

		// 'Flying_Flog_Green' GenType 10 Spawn Points
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-1245, 674, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-1326, 801, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-1527, 772, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-1983, 642, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-778, 434, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-973, 395, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(2095, 1280, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(1959, 1443, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(2083, 1411, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(1924, 1181, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(1906, 1338, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(1489, 1277, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(1626, 1147, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(1791, 1244, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(1620, 1248, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(1758, 1370, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(1139, 1267, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(715, 1027, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(923, 1084, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(988, 988, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(985, 1199, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(749, 905, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(864, 1234, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(771, 1170, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(957, 1363, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(856, 1452, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(420, 1329, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(577, 1001, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(640, 1295, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(556, 1203, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(405, 1180, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(697, 1431, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(794, 1351, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(684, 573, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(763, 492, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(454, 387, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(667, 237, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(865, 299, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(728, 327, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(365, 272, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(489, 281, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(558, 197, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(582, 451, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(451, 512, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(824, -482, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(718, -536, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(609, -424, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(646, -307, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(567, -516, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(292, -657, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(263, -449, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(435, -281, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(553, -233, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(493, -376, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(554, -600, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(646, -712, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(435, -598, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(373, -747, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(390, -465, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(1566, -1584, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(1728, -1334, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(1707, -1431, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(1583, -1500, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(1413, -1575, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(1428, -1500, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(1370, -1402, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(1492, -1409, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(1385, -1289, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(1479, -1313, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(1611, -1328, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(1663, -1229, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(1422, -1172, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(154, -1085, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(122, -1263, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-119, -1279, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-11, -973, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-17, -1086, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-167, -1028, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-104, -1189, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-105, -1118, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-250, -1309, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-232, -1166, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-1, -1369, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-4, -1243, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-291, -1108, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-98, 75, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-261, 139, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-373, 19, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-586, -406, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-521, -75, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-384, -227, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-426, -494, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(32, -356, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(100, -234, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(15, -147, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-6, -279, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-74, -477, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-207, -415, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-381, -346, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-578, -536, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-384, -599, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-80, -174, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-135, -89, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-240, 23, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-260, -144, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-686, -165, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-545, -265, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-694, -319, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-864, 493, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-847, 597, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-999, 488, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-840, 330, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-1004, -168, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-1073, -280, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-1173, -227, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-1111, -115, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-1461, -1457, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-1495, -1561, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-1240, -1539, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-1355, -1628, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-1217, -1420, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-1072, -1552, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-914, -1421, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-1038, -1431, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-1381, -1284, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-1492, -1341, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-1206, -1296, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-1323, -1456, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-1416, 469, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-1937, 420, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-1631, 454, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-1741, 594, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-1539, 645, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-1395, 598, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-1490, 848, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-1640, 797, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-1863, 469, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-1755, 388, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-1881, 895, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-1743, 723, 25));
		AddSpawnPoint("f_farm_49_2.Id4", "f_farm_49_2", Rectangle(-2002, 758, 25));

		// 'Rootcrystal_01' GenType 40 Spawn Points
		AddSpawnPoint("f_farm_49_2.Id5", "f_farm_49_2", Rectangle(1544, -1310, 50));
		AddSpawnPoint("f_farm_49_2.Id5", "f_farm_49_2", Rectangle(507, -705, 50));
		AddSpawnPoint("f_farm_49_2.Id5", "f_farm_49_2", Rectangle(624, -409, 50));
		AddSpawnPoint("f_farm_49_2.Id5", "f_farm_49_2", Rectangle(695, 275, 50));
		AddSpawnPoint("f_farm_49_2.Id5", "f_farm_49_2", Rectangle(701, 608, 50));
		AddSpawnPoint("f_farm_49_2.Id5", "f_farm_49_2", Rectangle(698, 1041, 50));
		AddSpawnPoint("f_farm_49_2.Id5", "f_farm_49_2", Rectangle(982, 1313, 50));
		AddSpawnPoint("f_farm_49_2.Id5", "f_farm_49_2", Rectangle(1653, 1168, 50));
		AddSpawnPoint("f_farm_49_2.Id5", "f_farm_49_2", Rectangle(1921, 1313, 50));
		AddSpawnPoint("f_farm_49_2.Id5", "f_farm_49_2", Rectangle(-796, 548, 50));
		AddSpawnPoint("f_farm_49_2.Id5", "f_farm_49_2", Rectangle(-1415, 591, 50));
		AddSpawnPoint("f_farm_49_2.Id5", "f_farm_49_2", Rectangle(-1807, 751, 50));
		AddSpawnPoint("f_farm_49_2.Id5", "f_farm_49_2", Rectangle(-544, -237, 50));
		AddSpawnPoint("f_farm_49_2.Id5", "f_farm_49_2", Rectangle(-139, -228, 50));
		AddSpawnPoint("f_farm_49_2.Id5", "f_farm_49_2", Rectangle(-170, -1059, 50));
		AddSpawnPoint("f_farm_49_2.Id5", "f_farm_49_2", Rectangle(-637, -1230, 50));
		AddSpawnPoint("f_farm_49_2.Id5", "f_farm_49_2", Rectangle(-1141, -1423, 50));
		AddSpawnPoint("f_farm_49_2.Id5", "f_farm_49_2", Rectangle(-1456, -1519, 50));

		// 'Pendinmire_Paviesa' GenType 50 Spawn Points
		AddSpawnPoint("f_farm_49_2.Id6", "f_farm_49_2", Rectangle(1554, -1325, 250));
	}
}
