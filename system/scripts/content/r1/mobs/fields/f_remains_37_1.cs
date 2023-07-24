//--- Melia Script -----------------------------------------------------------
// Nuoridin Falls Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_remains_37_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FRemains371MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_remains_37_1.Id1", MonsterId.Rootcrystal_04, min: 38, max: 50, respawn: TimeSpan.FromMilliseconds(60000), tendency: TendencyType.Peaceful);
		AddSpawner("f_remains_37_1.Id2", MonsterId.Wendigo_Magician, min: 19, max: 25, tendency: TendencyType.Aggressive);
		AddSpawner("f_remains_37_1.Id3", MonsterId.Wendigo_Archer, min: 23, max: 30, tendency: TendencyType.Aggressive);
		AddSpawner("f_remains_37_1.Id4", MonsterId.Templeslave_Sword, min: 38, max: 50, tendency: TendencyType.Aggressive);
		AddSpawner("f_remains_37_1.Id5", MonsterId.Wendigo_Archer, min: 8, max: 10, tendency: TendencyType.Aggressive);
		AddSpawner("f_remains_37_1.Id6", MonsterId.Wendigo_Magician, min: 19, max: 25, respawn: TimeSpan.FromMilliseconds(35000), tendency: TendencyType.Aggressive);
		AddSpawner("f_remains_37_1.Id7", MonsterId.Templeslave_Sword, min: 30, max: 40, respawn: TimeSpan.FromMilliseconds(35000), tendency: TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_04' GenType 4 Spawn Points
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-121, -2210, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-371, -2019, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-466, -1761, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-415, -1540, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-101, -1365, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(144, -1447, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(43, -1095, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-233, -1105, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-435, -1261, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-601, -1012, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-931, -1181, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-1220, -1018, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-1385, -1096, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(27, -864, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(332, -1243, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(629, -1164, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(858, -1214, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(955, -1012, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(1211, -1142, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(1489, -1203, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(853, -758, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(804, -570, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(589, -354, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(997, -215, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(827, 162, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(1065, 421, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(1368, -47, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(1449, 220, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(1414, -223, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(1574, -12, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(1623, -260, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(1686, -483, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-62, -137, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-394, -219, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-352, -508, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-194, 135, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-954, 36, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-1312, -148, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-1068, 339, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-672, 785, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-238, 785, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(503, 833, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(278, 766, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(621, 1093, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(771, 589, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-556, 1425, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-318, 1541, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-1705, 1610, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-1923, 1302, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-2249, 1254, 40));

		// 'Wendigo_Magician' GenType 17 Spawn Points
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(788, -600, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(868, -221, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(1004, 343, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(401, 689, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(792, 950, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(-215, -337, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(-266, 252, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(-29, -1037, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(1014, -1064, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(6, -1373, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(1289, -1162, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(1572, -1089, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(-222, -1345, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(-395, -1308, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(-1139, -1096, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(-1248, -988, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(-369, -306, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(-95, -41, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(739, -108, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(822, 128, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(569, -139, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(637, 400, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(588, 951, 25));

		// 'Wendigo_Archer' GenType 18 Spawn Points
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(-265, -1270, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(247, -1245, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(929, -1097, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(677, 23, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(571, -279, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(977, 80, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(566, 474, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(434, 974, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(679, 773, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(-140, -613, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(1, -126, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(-173, -72, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(-465, -33, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(-408, -383, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(1484, -1151, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(-1193, -1098, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(-1192, -1253, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(-1050, -969, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(-368, -1465, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(-450, -1280, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(-71, -1392, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(256, -1367, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(-56, -408, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(-360, -255, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(-178, 225, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(769, -205, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(616, -96, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(914, 298, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(512, 650, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(312, 793, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(730, 1016, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(1305, -1138, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(1483, -1019, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(917, -946, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(1109, -1197, 25));

		// 'Templeslave_Sword' GenType 19 Spawn Points
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-1250, -180, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-1039, -49, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-670, 720, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-459, 818, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-712, 1413, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-444, 1582, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-1707, 1417, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-1974, 1245, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-473, -1961, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-493, -1732, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(113, -1202, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-1782, 1211, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-487, 1361, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-258, 1504, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-112, -1392, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(1420, -1171, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-183, -503, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-249, -292, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-183, -650, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-70, 65, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(701, -93, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(824, -432, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(949, -101, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(878, -1094, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(478, -1286, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(296, -1269, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(141, -1359, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(868, -840, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(757, -1189, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(635, -322, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(768, 119, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-230, -53, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-771, 796, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-1184, -63, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(933, 83, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(528, -158, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(849, -214, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-407, -201, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-398, 239, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-489, -1, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-362, -521, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-1045, -241, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-505, 922, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-528, 1513, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-853, 1339, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-748, 1252, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-1973, 1417, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-315, 1445, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-416, -1342, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-135, -1215, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-360, -1226, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-106, -1053, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-258, -1422, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-78, -213, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(42, -91, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-80, 277, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(70, 60, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-214, 199, 25));

		// 'Wendigo_Archer' GenType 20 Spawn Points
		AddSpawnPoint("f_remains_37_1.Id5", "f_remains_37_1", Rectangle(-631, 673, 9999));

		// 'Wendigo_Magician' GenType 29 Spawn Points
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(446, 536, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(593, 569, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(442, 705, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(634, 756, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(444, 899, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(732, 991, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(800, 690, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(653, 347, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(488, 391, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(240, 689, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(582, 1044, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(-2032, 1200, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(-1954, 1298, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(-1982, 1420, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(-1784, 1511, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(-1828, 1395, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(-1698, 1244, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(-1614, 1424, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(-1592, 1625, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(-1698, 1587, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(-1540, 1518, 30));

		// 'Templeslave_Sword' GenType 30 Spawn Points
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(573, 343, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(722, 449, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(497, 505, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(324, 632, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(493, 715, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(281, 881, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(629, 870, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(456, 858, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(496, 1009, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(841, 1059, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(796, 825, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(789, 674, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(659, 602, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-1306, -1169, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-1305, -1020, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-1220, -923, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-1142, -1041, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-1176, -1161, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-1133, -1283, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-978, -1243, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-1064, -1165, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-980, -1086, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-863, -983, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-871, -1179, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-1045, -1363, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-1378, -898, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-1433, -1029, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-1081, -961, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(686, 1076, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-1978, 1217, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-1920, 1383, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-1948, 1495, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-1765, 1295, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-1644, 1537, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-1699, 1440, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-1593, 1321, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-1697, 1640, 25));
	}
}
