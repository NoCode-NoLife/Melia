//--- Melia Script -----------------------------------------------------------
// Tiltas Valley Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_rokas_28'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FRokas28MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_rokas_28.Id1", MonsterId.Hogma_Archer, min: 8, max: 10);
		AddSpawner("f_rokas_28.Id2", MonsterId.Rootcrystal_05, min: 8, max: 10, respawn: TimeSpan.FromMilliseconds(5000));
		AddSpawner("f_rokas_28.Id3", MonsterId.Hogma_Archer, min: 8, max: 10);
		AddSpawner("f_rokas_28.Id4", MonsterId.Lauzinute, min: 23, max: 30);
		AddSpawner("f_rokas_28.Id5", MonsterId.Hogma_Archer, min: 8, max: 10);
		AddSpawner("f_rokas_28.Id6", MonsterId.Templeslave_Mage, min: 8, max: 10);

		// Monster Spawn Points -----------------------------

		// 'Hogma_Archer' GenType 56 Spawn Points
		AddSpawnPoint("f_rokas_28.Id1", "f_rokas_28", Rectangle(-1390, -639, 30));
		AddSpawnPoint("f_rokas_28.Id1", "f_rokas_28", Rectangle(-730, 155, 30));
		AddSpawnPoint("f_rokas_28.Id1", "f_rokas_28", Rectangle(-1626, -674, 30));
		AddSpawnPoint("f_rokas_28.Id1", "f_rokas_28", Rectangle(-1504, -353, 30));
		AddSpawnPoint("f_rokas_28.Id1", "f_rokas_28", Rectangle(-1770, -486, 30));
		AddSpawnPoint("f_rokas_28.Id1", "f_rokas_28", Rectangle(-375, -162, 30));
		AddSpawnPoint("f_rokas_28.Id1", "f_rokas_28", Rectangle(-536, 121, 30));
		AddSpawnPoint("f_rokas_28.Id1", "f_rokas_28", Rectangle(-297, 34, 30));
		AddSpawnPoint("f_rokas_28.Id1", "f_rokas_28", Rectangle(-171, -1650, 30));
		AddSpawnPoint("f_rokas_28.Id1", "f_rokas_28", Rectangle(-53, -1464, 30));
		AddSpawnPoint("f_rokas_28.Id1", "f_rokas_28", Rectangle(-161, -1320, 30));
		AddSpawnPoint("f_rokas_28.Id1", "f_rokas_28", Rectangle(-166, -1114, 30));
		AddSpawnPoint("f_rokas_28.Id1", "f_rokas_28", Rectangle(-97, -1253, 30));

		// 'Rootcrystal_05' GenType 600 Spawn Points
		AddSpawnPoint("f_rokas_28.Id2", "f_rokas_28", Rectangle(-715, -768, 30));
		AddSpawnPoint("f_rokas_28.Id2", "f_rokas_28", Rectangle(-289, 101, 30));
		AddSpawnPoint("f_rokas_28.Id2", "f_rokas_28", Rectangle(1201, 708, 30));
		AddSpawnPoint("f_rokas_28.Id2", "f_rokas_28", Rectangle(-834, 170, 30));
		AddSpawnPoint("f_rokas_28.Id2", "f_rokas_28", Rectangle(-71, -1273, 30));
		AddSpawnPoint("f_rokas_28.Id2", "f_rokas_28", Rectangle(-218, -1535, 30));
		AddSpawnPoint("f_rokas_28.Id2", "f_rokas_28", Rectangle(-1289, -390, 30));
		AddSpawnPoint("f_rokas_28.Id2", "f_rokas_28", Rectangle(-1857, -593, 30));
		AddSpawnPoint("f_rokas_28.Id2", "f_rokas_28", Rectangle(377, 805, 30));
		AddSpawnPoint("f_rokas_28.Id2", "f_rokas_28", Rectangle(1192, 1050, 30));
		AddSpawnPoint("f_rokas_28.Id2", "f_rokas_28", Rectangle(1251, 2108, 30));
		AddSpawnPoint("f_rokas_28.Id2", "f_rokas_28", Rectangle(1638, 1597, 30));
		AddSpawnPoint("f_rokas_28.Id2", "f_rokas_28", Rectangle(177, -337, 30));
		AddSpawnPoint("f_rokas_28.Id2", "f_rokas_28", Rectangle(849, -481, 30));

		// 'Hogma_Archer' GenType 1024 Spawn Points
		AddSpawnPoint("f_rokas_28.Id3", "f_rokas_28", Rectangle(887, 566, 9999));

		// 'Lauzinute' GenType 1027 Spawn Points
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(318, 743, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(588, 384, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-572, -1817, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-697, -1702, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-367, -1671, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-208, -1471, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-205, -1660, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-173, -1750, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-256, -1356, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-292, -1770, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-506, -1506, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-62, -1519, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-69, -1366, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-200, -1131, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-117, -1163, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-319, -1030, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-403, -1161, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-347, -1275, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-564, -1639, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-322, -1548, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-667, -1899, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-422, -1835, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-706, -699, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-648, -826, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-759, -831, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-685, -796, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-599, -793, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-632, -633, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-532, -682, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-588, -635, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-1835, -582, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-1775, -699, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-1611, -726, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-1639, -617, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-1572, -449, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-1530, -399, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-1436, -467, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-1480, -561, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-1463, -666, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-1346, -662, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-1262, -598, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-1311, -467, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-1466, -311, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-1406, -258, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-1228, -398, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-1219, -512, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-1337, -367, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-777, -97, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-828, -11, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-847, 93, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-659, 305, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-567, 269, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-646, 173, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-523, 175, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-530, 58, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-660, -49, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-597, -98, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-334, -248, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-331, -193, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-430, -252, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-499, -198, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-258, 97, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-310, 0, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-307, 207, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(-300, 179, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(481, 800, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(532, 803, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(527, 681, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(412, 691, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(266, 654, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(238, 530, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(508, 465, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(549, 431, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(610, 437, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(604, 580, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(729, 695, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(704, 583, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(698, 457, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(926, 504, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(998, 536, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(1302, 725, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(1379, 717, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(1289, 981, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(1113, 902, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(1132, 965, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(1150, 1168, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(1467, 920, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(1459, 1093, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(1161, 757, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(1311, 1268, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(1412, 1343, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(1632, 1572, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(1561, 1624, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(1565, 1672, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(1633, 1711, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(1686, 1639, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(1287, 1709, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(1137, 1724, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(1243, 1886, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(1095, 2020, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(1378, 1956, 40));
		AddSpawnPoint("f_rokas_28.Id4", "f_rokas_28", Rectangle(1426, 1823, 40));

		// 'Hogma_Archer' GenType 1028 Spawn Points
		AddSpawnPoint("f_rokas_28.Id5", "f_rokas_28", Rectangle(573, 357, 20));
		AddSpawnPoint("f_rokas_28.Id5", "f_rokas_28", Rectangle(655, 565, 20));
		AddSpawnPoint("f_rokas_28.Id5", "f_rokas_28", Rectangle(456, 454, 20));
		AddSpawnPoint("f_rokas_28.Id5", "f_rokas_28", Rectangle(1187, 858, 20));
		AddSpawnPoint("f_rokas_28.Id5", "f_rokas_28", Rectangle(1339, 917, 20));

		// 'Templeslave_Mage' GenType 1031 Spawn Points
		AddSpawnPoint("f_rokas_28.Id6", "f_rokas_28", Rectangle(612, 405, 30));
		AddSpawnPoint("f_rokas_28.Id6", "f_rokas_28", Rectangle(1256, 769, 30));
		AddSpawnPoint("f_rokas_28.Id6", "f_rokas_28", Rectangle(1178, 1029, 30));
		AddSpawnPoint("f_rokas_28.Id6", "f_rokas_28", Rectangle(1612, 1629, 30));
		AddSpawnPoint("f_rokas_28.Id6", "f_rokas_28", Rectangle(1142, 1777, 30));
		AddSpawnPoint("f_rokas_28.Id6", "f_rokas_28", Rectangle(1420, 1375, 30));
	}
}
