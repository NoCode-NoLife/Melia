//--- Melia Script -----------------------------------------------------------
// Outer Wall District 13 Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_castle_95'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FCastle95MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_castle_95", MonsterId.Ghoscandle, Properties("MHP", 679998, "MINPATK", 9245, "MAXPATK", 11265, "MINMATK", 9245, "MAXMATK", 11265, "DEF", 176835, "MDEF", 176835));
		AddPropertyOverrides("f_castle_95", MonsterId.Infrogremlin, Properties("MHP", 681483, "MINPATK", 9264, "MAXPATK", 11288, "MINMATK", 9264, "MAXMATK", 11288, "DEF", 177897, "MDEF", 177897));
		AddPropertyOverrides("f_castle_95", MonsterId.Velsoarer, Properties("MHP", 683037, "MINPATK", 9284, "MAXPATK", 11313, "MINMATK", 9284, "MAXMATK", 11313, "DEF", 179008, "MDEF", 179008));
		AddPropertyOverrides("f_castle_95", MonsterId.Boss_Moringponia_Q1, Properties("MHP", 3573912, "MINPATK", 23449, "MAXPATK", 28573, "MINMATK", 23449, "MAXMATK", 28573, "DEF", 454017, "MDEF", 454017));

		// Monster Spawners ---------------------------------

		AddSpawner("f_castle_95.Id1", MonsterId.Ghoscandle, 90, 120, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_castle_95.Id2", MonsterId.Infrogremlin, 38, 50, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_castle_95.Id3", MonsterId.Velsoarer, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Ghoscandle' GenType 1 Spawn Points
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-1180, -583, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-1255, -614, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-1282, -789, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-1228, -434, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-1105, -661, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-1138, -513, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-974, -584, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-985, -730, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-868, -608, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-663, -582, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-362, -758, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-296, -789, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-11, -786, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-145, -933, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-172, -1006, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-154, -1189, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-160, -1505, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-248, -1568, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-123, -1619, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(0, -1572, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(2, -610, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-320, -545, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-226, -397, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-302, -401, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-162, -154, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-159, 36, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-383, 343, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-63, 257, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-231, 150, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(12, 316, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(7, 184, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(341, 435, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(238, 368, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(30, 997, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(134, 1260, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(211, 1050, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(580, 968, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(652, 1173, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(521, 1140, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(727, 960, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(759, 1119, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1161, 1087, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1346, 1096, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1289, 1284, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1458, 1278, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1659, -1383, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1611, 1177, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1704, 977, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1534, 932, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1814, 1151, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1623, 981, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1326, 897, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1341, 744, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(197, 348, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1875, 890, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1802, 754, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1880, 1129, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1585, -1311, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1684, -808, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1699, 763, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1800, -659, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1405, 350, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1656, -610, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1448, -430, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1453, -790, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1011, 362, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1611, -268, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(814, 362, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(538, 421, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(608, 491, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(567, 261, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(496, 221, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(685, 148, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(571, 107, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(351, 267, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(226, -636, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1601, -1410, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(562, -523, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(516, -448, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(540, -750, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(917, -656, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(717, -679, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(900, -495, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(923, -769, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1645, 106, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1628, -9, 20));

		// 'Infrogremlin' GenType 2 Spawn Points
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(1646, 670, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(-1217, -661, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(-1079, -545, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(-791, -614, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(-528, -589, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(-189, -1657, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(-77, -1505, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(-140, -1258, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(-147, -801, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(19, -470, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(-259, -538, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(-177, 223, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(-237, 414, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(-332, 348, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(187, 207, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(300, 351, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(143, 431, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(509, 283, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(597, 440, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(604, 148, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(885, 368, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(998, 418, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(1839, -703, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(1295, 379, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(1631, -210, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(1629, 213, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(1761, -729, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(1569, -779, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(1757, -421, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(1536, -436, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(1625, -1177, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(1524, -1472, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(1626, -1479, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(1533, 1027, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(1734, 1147, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(1542, 1255, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(1768, 791, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(1443, 765, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(1324, 1234, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(871, 1080, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(576, 1101, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(117, 1060, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(212, 1235, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(44, 1237, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(1434, -610, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(799, -622, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(823, -828, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(282, -593, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(699, -393, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(543, -672, 20));

		// 'Velsoarer' GenType 3 Spawn Points
		AddSpawnPoint("f_castle_95.Id3", "f_castle_95", Rectangle(1591, -662, 40));
		AddSpawnPoint("f_castle_95.Id3", "f_castle_95", Rectangle(1639, 1089, 40));
		AddSpawnPoint("f_castle_95.Id3", "f_castle_95", Rectangle(1618, 747, 40));
		AddSpawnPoint("f_castle_95.Id3", "f_castle_95", Rectangle(1263, 1085, 40));
		AddSpawnPoint("f_castle_95.Id3", "f_castle_95", Rectangle(685, 1057, 40));
		AddSpawnPoint("f_castle_95.Id3", "f_castle_95", Rectangle(141, 1155, 40));
		AddSpawnPoint("f_castle_95.Id3", "f_castle_95", Rectangle(-139, 397, 40));
		AddSpawnPoint("f_castle_95.Id3", "f_castle_95", Rectangle(181, 297, 40));
		AddSpawnPoint("f_castle_95.Id3", "f_castle_95", Rectangle(602, 348, 40));
		AddSpawnPoint("f_castle_95.Id3", "f_castle_95", Rectangle(773, -749, 40));
		AddSpawnPoint("f_castle_95.Id3", "f_castle_95", Rectangle(629, -472, 40));
		AddSpawnPoint("f_castle_95.Id3", "f_castle_95", Rectangle(-149, -477, 40));
		AddSpawnPoint("f_castle_95.Id3", "f_castle_95", Rectangle(-1121, -708, 40));
		AddSpawnPoint("f_castle_95.Id3", "f_castle_95", Rectangle(1629, -377, 40));
		AddSpawnPoint("f_castle_95.Id3", "f_castle_95", Rectangle(-340, 207, 40));
	}
}
