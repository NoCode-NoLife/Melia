//--- Melia Script -----------------------------------------------------------
// Northern Parias Forest Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_maple_24_3'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FMaple243MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_maple_24_3", MonsterId.Gland_Red, Properties("MHP", 718057, "MINPATK", 9735, "MAXPATK", 11866, "MINMATK", 9735, "MAXMATK", 11866, "DEF", 204036, "MDEF", 204036));
		AddPropertyOverrides("f_maple_24_3", MonsterId.Pennamayo, Properties("MHP", 720547, "MINPATK", 9767, "MAXPATK", 11906, "MINMATK", 9767, "MAXMATK", 11906, "DEF", 205815, "MDEF", 205815));
		AddPropertyOverrides("f_maple_24_3", MonsterId.Blueberrin, Properties("MHP", 723078, "MINPATK", 9799, "MAXPATK", 11946, "MINMATK", 9799, "MAXMATK", 11946, "DEF", 207624, "MDEF", 207624));
		AddPropertyOverrides("f_maple_24_3", MonsterId.Uniq_Id_Boss_Tantaliser, Properties("MHP", 6182547, "MINPATK", 32643, "MAXPATK", 39795, "MINMATK", 32643, "MAXMATK", 39795, "DEF", 695416, "MDEF", 695416));
		AddPropertyOverrides("f_maple_24_3", MonsterId.Boss_Tantaliser_Q1, Properties("MHP", 6204811, "MINPATK", 32755, "MAXPATK", 39932, "MINMATK", 32755, "MAXMATK", 39932, "DEF", 701616, "MDEF", 701616));

		// Monster Spawners ---------------------------------

		AddSpawner("f_maple_24_3.Id1", MonsterId.Gland_Red, min: 19, max: 25);
		AddSpawner("f_maple_24_3.Id2", MonsterId.Pennamayo, min: 61, max: 81);
		AddSpawner("f_maple_24_3.Id3", MonsterId.Blueberrin, min: 44, max: 58);
		AddSpawner("f_maple_24_3.Id4", MonsterId.Rootcrystal_01, min: 23, max: 30, respawn: TimeSpan.FromMilliseconds(20000));

		// Monster Spawn Points -----------------------------

		// 'Gland_Red' GenType 1 Spawn Points
		AddSpawnPoint("f_maple_24_3.Id1", "f_maple_24_3", Rectangle(-1448, -884, 20));
		AddSpawnPoint("f_maple_24_3.Id1", "f_maple_24_3", Rectangle(-1747, -1146, 20));
		AddSpawnPoint("f_maple_24_3.Id1", "f_maple_24_3", Rectangle(-1546, -1164, 20));
		AddSpawnPoint("f_maple_24_3.Id1", "f_maple_24_3", Rectangle(-1782, -964, 20));
		AddSpawnPoint("f_maple_24_3.Id1", "f_maple_24_3", Rectangle(-1648, -1019, 20));
		AddSpawnPoint("f_maple_24_3.Id1", "f_maple_24_3", Rectangle(-1818, -1096, 20));
		AddSpawnPoint("f_maple_24_3.Id1", "f_maple_24_3", Rectangle(-1601, -1241, 20));
		AddSpawnPoint("f_maple_24_3.Id1", "f_maple_24_3", Rectangle(-1651, -1123, 20));
		AddSpawnPoint("f_maple_24_3.Id1", "f_maple_24_3", Rectangle(-1734, -1050, 20));
		AddSpawnPoint("f_maple_24_3.Id1", "f_maple_24_3", Rectangle(-1466, -819, 20));
		AddSpawnPoint("f_maple_24_3.Id1", "f_maple_24_3", Rectangle(-1538, -1025, 20));
		AddSpawnPoint("f_maple_24_3.Id1", "f_maple_24_3", Rectangle(-1473, -1008, 20));
		AddSpawnPoint("f_maple_24_3.Id1", "f_maple_24_3", Rectangle(-1224, -596, 20));
		AddSpawnPoint("f_maple_24_3.Id1", "f_maple_24_3", Rectangle(-1115, -539, 20));
		AddSpawnPoint("f_maple_24_3.Id1", "f_maple_24_3", Rectangle(-1073, -386, 20));
		AddSpawnPoint("f_maple_24_3.Id1", "f_maple_24_3", Rectangle(-1032, -467, 20));
		AddSpawnPoint("f_maple_24_3.Id1", "f_maple_24_3", Rectangle(-873, -484, 20));
		AddSpawnPoint("f_maple_24_3.Id1", "f_maple_24_3", Rectangle(-834, -386, 20));
		AddSpawnPoint("f_maple_24_3.Id1", "f_maple_24_3", Rectangle(-723, -313, 20));
		AddSpawnPoint("f_maple_24_3.Id1", "f_maple_24_3", Rectangle(-813, -214, 20));
		AddSpawnPoint("f_maple_24_3.Id1", "f_maple_24_3", Rectangle(-808, -81, 20));
		AddSpawnPoint("f_maple_24_3.Id1", "f_maple_24_3", Rectangle(-932, 12, 20));
		AddSpawnPoint("f_maple_24_3.Id1", "f_maple_24_3", Rectangle(-925, -92, 20));
		AddSpawnPoint("f_maple_24_3.Id1", "f_maple_24_3", Rectangle(-1024, -64, 20));
		AddSpawnPoint("f_maple_24_3.Id1", "f_maple_24_3", Rectangle(-1063, -193, 20));

		// 'Pennamayo' GenType 2 Spawn Points
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-887, 1167, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-1363, 546, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-1305, 357, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-1422, 493, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-1480, 307, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-1459, 236, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-1312, 270, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-1524, 262, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-1079, 1132, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-1176, 1078, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-1061, 1058, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-1028, 1261, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-1149, 1187, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-990, 1173, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-553, 698, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-580, 623, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-498, 679, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-622, 488, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-612, 419, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-331, 584, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-348, 543, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-451, 260, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-515, 243, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-307, 507, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(26, 1160, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-5, 954, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(136, 946, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(296, 1050, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(290, 1107, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(207, 985, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(133, 1196, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(73, 1223, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(104, 1142, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-8, 1024, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-951, -282, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-929, -336, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-819, -326, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-877, -268, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-1345, 432, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-1255, 390, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-1296, 476, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-1139, 1273, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-1403, 331, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-715, -389, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-408, 970, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-164, 83, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-297, 312, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-301, 385, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-480, 504, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-483, 711, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-527, 826, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-443, 862, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-416, 619, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(82, -417, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(86, -582, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(259, -639, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(110, -476, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(228, -436, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(325, -469, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(13, -796, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(3, -878, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(264, -897, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(191, -696, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(308, -810, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(397, -730, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(504, -680, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(495, -560, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(637, -509, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(639, -423, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-1095, 979, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-1077, 906, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-1294, 753, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-1339, 685, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-1399, 597, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(84, 911, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(225, 1132, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(211, 1199, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(0, 1102, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-65, 1195, 20));
		AddSpawnPoint("f_maple_24_3.Id2", "f_maple_24_3", Rectangle(-139, 1196, 20));

		// 'Blueberrin' GenType 3 Spawn Points
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(-732, -1155, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(-781, -1239, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(-766, -1310, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(-647, -1284, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(-606, -1157, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(-691, -1230, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(-539, -1194, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(7, -748, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(14, -869, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(59, -983, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(571, -1216, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(181, -921, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(224, -807, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(419, -733, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(737, -1340, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(504, -690, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(515, -578, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(389, -448, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(598, -438, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(298, -648, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(165, -608, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(770, -1241, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(348, -822, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(289, -452, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(464, -1371, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(381, -1355, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(495, -1425, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(638, -1381, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(649, -1274, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(581, -1474, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(-492, 473, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(-443, 158, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(-474, 548, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(-445, 487, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(-278, 359, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(-507, 173, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(-279, 303, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(379, -1285, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(524, -1219, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(486, -1258, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(-513, -1134, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(-654, -1093, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(-299, -1203, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(-212, -1171, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(-401, -1219, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(94, -791, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(183, -692, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(120, -436, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(858, -1147, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(859, -1044, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(-832, -1098, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(-877, -1056, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(-872, -1320, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(-844, -1285, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(161, -979, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(234, -939, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(628, -820, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(628, -820, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(843, -776, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(790, -772, 25));
		AddSpawnPoint("f_maple_24_3.Id3", "f_maple_24_3", Rectangle(826, -993, 25));

		// 'Rootcrystal_01' GenType 8 Spawn Points
		AddSpawnPoint("f_maple_24_3.Id4", "f_maple_24_3", Rectangle(-948, -421, 200));
		AddSpawnPoint("f_maple_24_3.Id4", "f_maple_24_3", Rectangle(-740, 177, 200));
		AddSpawnPoint("f_maple_24_3.Id4", "f_maple_24_3", Rectangle(-922, -84, 200));
		AddSpawnPoint("f_maple_24_3.Id4", "f_maple_24_3", Rectangle(-636, 413, 200));
		AddSpawnPoint("f_maple_24_3.Id4", "f_maple_24_3", Rectangle(-1255, 1192, 200));
		AddSpawnPoint("f_maple_24_3.Id4", "f_maple_24_3", Rectangle(-891, 1148, 200));
		AddSpawnPoint("f_maple_24_3.Id4", "f_maple_24_3", Rectangle(507, -1342, 200));
		AddSpawnPoint("f_maple_24_3.Id4", "f_maple_24_3", Rectangle(-585, 945, 200));
		AddSpawnPoint("f_maple_24_3.Id4", "f_maple_24_3", Rectangle(-1162, 790, 200));
		AddSpawnPoint("f_maple_24_3.Id4", "f_maple_24_3", Rectangle(-409, 673, 200));
		AddSpawnPoint("f_maple_24_3.Id4", "f_maple_24_3", Rectangle(-312, 283, 200));
		AddSpawnPoint("f_maple_24_3.Id4", "f_maple_24_3", Rectangle(-9, -6, 200));
		AddSpawnPoint("f_maple_24_3.Id4", "f_maple_24_3", Rectangle(82, -359, 200));
		AddSpawnPoint("f_maple_24_3.Id4", "f_maple_24_3", Rectangle(82, -703, 200));
		AddSpawnPoint("f_maple_24_3.Id4", "f_maple_24_3", Rectangle(-1, -1018, 200));
		AddSpawnPoint("f_maple_24_3.Id4", "f_maple_24_3", Rectangle(422, -767, 200));
		AddSpawnPoint("f_maple_24_3.Id4", "f_maple_24_3", Rectangle(798, -762, 200));
		AddSpawnPoint("f_maple_24_3.Id4", "f_maple_24_3", Rectangle(500, -465, 200));
		AddSpawnPoint("f_maple_24_3.Id4", "f_maple_24_3", Rectangle(724, -277, 200));
		AddSpawnPoint("f_maple_24_3.Id4", "f_maple_24_3", Rectangle(651, 54, 200));
		AddSpawnPoint("f_maple_24_3.Id4", "f_maple_24_3", Rectangle(886, -1127, 200));
		AddSpawnPoint("f_maple_24_3.Id4", "f_maple_24_3", Rectangle(679, -1372, 200));
		AddSpawnPoint("f_maple_24_3.Id4", "f_maple_24_3", Rectangle(-425, -1181, 200));
		AddSpawnPoint("f_maple_24_3.Id4", "f_maple_24_3", Rectangle(-764, -1219, 200));
		AddSpawnPoint("f_maple_24_3.Id4", "f_maple_24_3", Rectangle(-1292, -611, 200));
		AddSpawnPoint("f_maple_24_3.Id4", "f_maple_24_3", Rectangle(-1496, -930, 200));
		AddSpawnPoint("f_maple_24_3.Id4", "f_maple_24_3", Rectangle(-1787, -1167, 200));
		AddSpawnPoint("f_maple_24_3.Id4", "f_maple_24_3", Rectangle(-1410, 540, 200));
		AddSpawnPoint("f_maple_24_3.Id4", "f_maple_24_3", Rectangle(-1410, 263, 200));
		AddSpawnPoint("f_maple_24_3.Id4", "f_maple_24_3", Rectangle(-267, 1123, 200));
		AddSpawnPoint("f_maple_24_3.Id4", "f_maple_24_3", Rectangle(106, 1214, 200));
		AddSpawnPoint("f_maple_24_3.Id4", "f_maple_24_3", Rectangle(188, 944, 200));
	}
}
