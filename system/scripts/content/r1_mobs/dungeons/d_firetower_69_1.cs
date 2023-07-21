//--- Melia Script -----------------------------------------------------------
// Zima Suecourt Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_firetower_69_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DFiretower691MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("d_firetower_69_1.Id1", MonsterId.Firetower_GateOpen_Q, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_firetower_69_1.Id2", MonsterId.Slime_Red, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_69_1.Id3", MonsterId.Slime_Red, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_69_1.Id4", MonsterId.Arma_Yellow, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_69_1.Id5", MonsterId.Pyran_Yellow, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_69_1.Id6", MonsterId.Wizards_Marmotte_Red, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_69_1.Id7", MonsterId.Wizards_Marmotte_Red, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_69_1.Id8", MonsterId.Pyran_Yellow, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_69_1.Id9", MonsterId.Rootcrystal_05, 12, 15, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Firetower_GateOpen_Q' GenType 5 Spawn Points
		AddSpawnPoint("d_firetower_69_1.Id1", "d_firetower_69_1", Rectangle(-705, 748, 40));
		AddSpawnPoint("d_firetower_69_1.Id1", "d_firetower_69_1", Rectangle(-606, 239, 40));
		AddSpawnPoint("d_firetower_69_1.Id1", "d_firetower_69_1", Rectangle(-507, 526, 40));
		AddSpawnPoint("d_firetower_69_1.Id1", "d_firetower_69_1", Rectangle(2, 230, 40));
		AddSpawnPoint("d_firetower_69_1.Id1", "d_firetower_69_1", Rectangle(431, 692, 40));
		AddSpawnPoint("d_firetower_69_1.Id1", "d_firetower_69_1", Rectangle(481, 80, 40));
		AddSpawnPoint("d_firetower_69_1.Id1", "d_firetower_69_1", Rectangle(-162, 732, 40));
		AddSpawnPoint("d_firetower_69_1.Id1", "d_firetower_69_1", Rectangle(229, 537, 40));
		AddSpawnPoint("d_firetower_69_1.Id1", "d_firetower_69_1", Rectangle(-375, 761, 40));
		AddSpawnPoint("d_firetower_69_1.Id1", "d_firetower_69_1", Rectangle(108, 742, 40));
		AddSpawnPoint("d_firetower_69_1.Id1", "d_firetower_69_1", Rectangle(139, 23, 40));
		AddSpawnPoint("d_firetower_69_1.Id1", "d_firetower_69_1", Rectangle(460, 417, 40));
		AddSpawnPoint("d_firetower_69_1.Id1", "d_firetower_69_1", Rectangle(-35, 439, 40));
		AddSpawnPoint("d_firetower_69_1.Id1", "d_firetower_69_1", Rectangle(-395, 310, 40));
		AddSpawnPoint("d_firetower_69_1.Id1", "d_firetower_69_1", Rectangle(281, 753, 40));
		AddSpawnPoint("d_firetower_69_1.Id1", "d_firetower_69_1", Rectangle(258, 240, 40));

		// 'Slime_Red' GenType 9 Spawn Points
		AddSpawnPoint("d_firetower_69_1.Id2", "d_firetower_69_1", Rectangle(1692, 274, 40));
		AddSpawnPoint("d_firetower_69_1.Id2", "d_firetower_69_1", Rectangle(1571, 513, 40));
		AddSpawnPoint("d_firetower_69_1.Id2", "d_firetower_69_1", Rectangle(1744, 646, 40));
		AddSpawnPoint("d_firetower_69_1.Id2", "d_firetower_69_1", Rectangle(1902, 501, 40));
		AddSpawnPoint("d_firetower_69_1.Id2", "d_firetower_69_1", Rectangle(1528, 167, 40));
		AddSpawnPoint("d_firetower_69_1.Id2", "d_firetower_69_1", Rectangle(1869, 219, 40));
		AddSpawnPoint("d_firetower_69_1.Id2", "d_firetower_69_1", Rectangle(2225, 250, 40));
		AddSpawnPoint("d_firetower_69_1.Id2", "d_firetower_69_1", Rectangle(2377, 175, 40));
		AddSpawnPoint("d_firetower_69_1.Id2", "d_firetower_69_1", Rectangle(2614, 137, 40));
		AddSpawnPoint("d_firetower_69_1.Id2", "d_firetower_69_1", Rectangle(2639, 358, 40));
		AddSpawnPoint("d_firetower_69_1.Id2", "d_firetower_69_1", Rectangle(2648, 621, 40));
		AddSpawnPoint("d_firetower_69_1.Id2", "d_firetower_69_1", Rectangle(2346, 625, 40));
		AddSpawnPoint("d_firetower_69_1.Id2", "d_firetower_69_1", Rectangle(2226, 581, 40));
		AddSpawnPoint("d_firetower_69_1.Id2", "d_firetower_69_1", Rectangle(2434, 523, 40));
		AddSpawnPoint("d_firetower_69_1.Id2", "d_firetower_69_1", Rectangle(2317, 340, 40));
		AddSpawnPoint("d_firetower_69_1.Id2", "d_firetower_69_1", Rectangle(2226, 88, 40));
		AddSpawnPoint("d_firetower_69_1.Id2", "d_firetower_69_1", Rectangle(1908, 414, 40));
		AddSpawnPoint("d_firetower_69_1.Id2", "d_firetower_69_1", Rectangle(1549, 345, 40));
		AddSpawnPoint("d_firetower_69_1.Id2", "d_firetower_69_1", Rectangle(1721, 518, 40));
		AddSpawnPoint("d_firetower_69_1.Id2", "d_firetower_69_1", Rectangle(1732, 120, 40));
		AddSpawnPoint("d_firetower_69_1.Id2", "d_firetower_69_1", Rectangle(2523, 267, 40));
		AddSpawnPoint("d_firetower_69_1.Id2", "d_firetower_69_1", Rectangle(2449, 85, 40));
		AddSpawnPoint("d_firetower_69_1.Id2", "d_firetower_69_1", Rectangle(2709, 495, 40));
		AddSpawnPoint("d_firetower_69_1.Id2", "d_firetower_69_1", Rectangle(2470, 661, 40));

		// 'Slime_Red' GenType 19 Spawn Points
		AddSpawnPoint("d_firetower_69_1.Id3", "d_firetower_69_1", Rectangle(-1655, -235, 9999));

		// 'Arma_Yellow' GenType 20 Spawn Points
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(-1950, -362, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(-1818, -142, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(-1685, -390, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(-1592, -132, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(-1455, -380, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(-1722, -1287, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(-1493, -1539, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(-1438, -1769, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(-1168, -1675, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(-1293, -1459, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(-1895, -1616, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(-1794, -1728, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(-1173, -1792, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(-558, -980, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(-548, -689, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(-277, -796, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(-330, -1036, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(-496, -884, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(-491, -851, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(-534, -497, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(-406, -206, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(-369, -77, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(-698, -286, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(-534, -377, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(-277, -475, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(-768, -756, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(-671, -911, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(-538, -1278, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(-714, -1572, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(174, -954, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(466, -966, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(436, -1069, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(539, -1203, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(265, -1228, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(338, -1415, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(616, -1353, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(591, -1503, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(161, -1368, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(-187, -265, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(-595, 394, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(-480, 659, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(-143, 721, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(12, 319, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(179, 298, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(398, 656, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(406, 284, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(85, 550, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(1168, -367, 40));
		AddSpawnPoint("d_firetower_69_1.Id4", "d_firetower_69_1", Rectangle(1133, -331, 40));

		// 'Pyran_Yellow' GenType 21 Spawn Points
		AddSpawnPoint("d_firetower_69_1.Id5", "d_firetower_69_1", Rectangle(-1585, -336, 9999));

		// 'Wizards_Marmotte_Red' GenType 23 Spawn Points
		AddSpawnPoint("d_firetower_69_1.Id6", "d_firetower_69_1", Rectangle(1162, 376, 40));
		AddSpawnPoint("d_firetower_69_1.Id6", "d_firetower_69_1", Rectangle(1014, 182, 40));
		AddSpawnPoint("d_firetower_69_1.Id6", "d_firetower_69_1", Rectangle(829, 232, 40));
		AddSpawnPoint("d_firetower_69_1.Id6", "d_firetower_69_1", Rectangle(780, 431, 40));
		AddSpawnPoint("d_firetower_69_1.Id6", "d_firetower_69_1", Rectangle(874, 471, 40));
		AddSpawnPoint("d_firetower_69_1.Id6", "d_firetower_69_1", Rectangle(1084, 526, 40));
		AddSpawnPoint("d_firetower_69_1.Id6", "d_firetower_69_1", Rectangle(1163, 192, 40));
		AddSpawnPoint("d_firetower_69_1.Id6", "d_firetower_69_1", Rectangle(740, 323, 40));
		AddSpawnPoint("d_firetower_69_1.Id6", "d_firetower_69_1", Rectangle(931, 353, 40));
		AddSpawnPoint("d_firetower_69_1.Id6", "d_firetower_69_1", Rectangle(1049, 359, 40));

		// 'Wizards_Marmotte_Red' GenType 24 Spawn Points
		AddSpawnPoint("d_firetower_69_1.Id7", "d_firetower_69_1", Rectangle(496, -1029, 40));
		AddSpawnPoint("d_firetower_69_1.Id7", "d_firetower_69_1", Rectangle(244, -924, 40));
		AddSpawnPoint("d_firetower_69_1.Id7", "d_firetower_69_1", Rectangle(152, -1065, 40));
		AddSpawnPoint("d_firetower_69_1.Id7", "d_firetower_69_1", Rectangle(346, -986, 40));
		AddSpawnPoint("d_firetower_69_1.Id7", "d_firetower_69_1", Rectangle(338, -1269, 40));
		AddSpawnPoint("d_firetower_69_1.Id7", "d_firetower_69_1", Rectangle(1202, -1170, 40));
		AddSpawnPoint("d_firetower_69_1.Id7", "d_firetower_69_1", Rectangle(1192, -1344, 40));
		AddSpawnPoint("d_firetower_69_1.Id7", "d_firetower_69_1", Rectangle(1255, -1438, 40));
		AddSpawnPoint("d_firetower_69_1.Id7", "d_firetower_69_1", Rectangle(1058, -1230, 40));
		AddSpawnPoint("d_firetower_69_1.Id7", "d_firetower_69_1", Rectangle(1423, -1295, 40));
		AddSpawnPoint("d_firetower_69_1.Id7", "d_firetower_69_1", Rectangle(1395, -1142, 40));
		AddSpawnPoint("d_firetower_69_1.Id7", "d_firetower_69_1", Rectangle(915, -675, 40));
		AddSpawnPoint("d_firetower_69_1.Id7", "d_firetower_69_1", Rectangle(1104, -702, 40));
		AddSpawnPoint("d_firetower_69_1.Id7", "d_firetower_69_1", Rectangle(892, -462, 40));
		AddSpawnPoint("d_firetower_69_1.Id7", "d_firetower_69_1", Rectangle(1195, -576, 40));
		AddSpawnPoint("d_firetower_69_1.Id7", "d_firetower_69_1", Rectangle(1338, -700, 40));
		AddSpawnPoint("d_firetower_69_1.Id7", "d_firetower_69_1", Rectangle(1285, -430, 40));
		AddSpawnPoint("d_firetower_69_1.Id7", "d_firetower_69_1", Rectangle(1238, -177, 40));
		AddSpawnPoint("d_firetower_69_1.Id7", "d_firetower_69_1", Rectangle(908, -188, 40));
		AddSpawnPoint("d_firetower_69_1.Id7", "d_firetower_69_1", Rectangle(1139, -425, 40));
		AddSpawnPoint("d_firetower_69_1.Id7", "d_firetower_69_1", Rectangle(2098, -435, 40));
		AddSpawnPoint("d_firetower_69_1.Id7", "d_firetower_69_1", Rectangle(2182, -331, 40));
		AddSpawnPoint("d_firetower_69_1.Id7", "d_firetower_69_1", Rectangle(2093, -205, 40));
		AddSpawnPoint("d_firetower_69_1.Id7", "d_firetower_69_1", Rectangle(2230, -517, 40));
		AddSpawnPoint("d_firetower_69_1.Id7", "d_firetower_69_1", Rectangle(2333, -213, 40));
		AddSpawnPoint("d_firetower_69_1.Id7", "d_firetower_69_1", Rectangle(2397, -480, 40));
		AddSpawnPoint("d_firetower_69_1.Id7", "d_firetower_69_1", Rectangle(2433, -212, 40));
		AddSpawnPoint("d_firetower_69_1.Id7", "d_firetower_69_1", Rectangle(2346, -342, 40));
		AddSpawnPoint("d_firetower_69_1.Id7", "d_firetower_69_1", Rectangle(509, -1281, 40));
		AddSpawnPoint("d_firetower_69_1.Id7", "d_firetower_69_1", Rectangle(583, -1153, 40));
		AddSpawnPoint("d_firetower_69_1.Id7", "d_firetower_69_1", Rectangle(1041, -453, 40));
		AddSpawnPoint("d_firetower_69_1.Id7", "d_firetower_69_1", Rectangle(1121, -222, 40));

		// 'Pyran_Yellow' GenType 25 Spawn Points
		AddSpawnPoint("d_firetower_69_1.Id8", "d_firetower_69_1", Rectangle(984, -560, 40));
		AddSpawnPoint("d_firetower_69_1.Id8", "d_firetower_69_1", Rectangle(1121, -259, 40));
		AddSpawnPoint("d_firetower_69_1.Id8", "d_firetower_69_1", Rectangle(1199, -415, 40));
		AddSpawnPoint("d_firetower_69_1.Id8", "d_firetower_69_1", Rectangle(1304, -639, 40));
		AddSpawnPoint("d_firetower_69_1.Id8", "d_firetower_69_1", Rectangle(1353, -272, 40));
		AddSpawnPoint("d_firetower_69_1.Id8", "d_firetower_69_1", Rectangle(978, 168, 40));
		AddSpawnPoint("d_firetower_69_1.Id8", "d_firetower_69_1", Rectangle(990, 434, 40));
		AddSpawnPoint("d_firetower_69_1.Id8", "d_firetower_69_1", Rectangle(798, 406, 40));
		AddSpawnPoint("d_firetower_69_1.Id8", "d_firetower_69_1", Rectangle(433, 402, 40));
		AddSpawnPoint("d_firetower_69_1.Id8", "d_firetower_69_1", Rectangle(160, 643, 40));
		AddSpawnPoint("d_firetower_69_1.Id8", "d_firetower_69_1", Rectangle(86, 426, 40));
		AddSpawnPoint("d_firetower_69_1.Id8", "d_firetower_69_1", Rectangle(-300, 753, 40));
		AddSpawnPoint("d_firetower_69_1.Id8", "d_firetower_69_1", Rectangle(-585, 650, 40));
		AddSpawnPoint("d_firetower_69_1.Id8", "d_firetower_69_1", Rectangle(-554, 301, 40));
		AddSpawnPoint("d_firetower_69_1.Id8", "d_firetower_69_1", Rectangle(-306, 282, 40));
		AddSpawnPoint("d_firetower_69_1.Id8", "d_firetower_69_1", Rectangle(-193, -116, 40));
		AddSpawnPoint("d_firetower_69_1.Id8", "d_firetower_69_1", Rectangle(312, -184, 40));
		AddSpawnPoint("d_firetower_69_1.Id8", "d_firetower_69_1", Rectangle(950, -138, 40));
		AddSpawnPoint("d_firetower_69_1.Id8", "d_firetower_69_1", Rectangle(1297, -152, 40));
		AddSpawnPoint("d_firetower_69_1.Id8", "d_firetower_69_1", Rectangle(1712, -198, 40));
		AddSpawnPoint("d_firetower_69_1.Id8", "d_firetower_69_1", Rectangle(1892, -161, 40));
		AddSpawnPoint("d_firetower_69_1.Id8", "d_firetower_69_1", Rectangle(2066, -152, 40));
		AddSpawnPoint("d_firetower_69_1.Id8", "d_firetower_69_1", Rectangle(2183, -339, 40));
		AddSpawnPoint("d_firetower_69_1.Id8", "d_firetower_69_1", Rectangle(2444, -119, 40));
		AddSpawnPoint("d_firetower_69_1.Id8", "d_firetower_69_1", Rectangle(2406, -377, 40));
		AddSpawnPoint("d_firetower_69_1.Id8", "d_firetower_69_1", Rectangle(2160, -497, 40));
		AddSpawnPoint("d_firetower_69_1.Id8", "d_firetower_69_1", Rectangle(2025, -437, 40));
		AddSpawnPoint("d_firetower_69_1.Id8", "d_firetower_69_1", Rectangle(2389, -495, 40));

		// 'Rootcrystal_05' GenType 28 Spawn Points
		AddSpawnPoint("d_firetower_69_1.Id9", "d_firetower_69_1", Rectangle(-1802, -285, 150));
		AddSpawnPoint("d_firetower_69_1.Id9", "d_firetower_69_1", Rectangle(-1497, -130, 150));
		AddSpawnPoint("d_firetower_69_1.Id9", "d_firetower_69_1", Rectangle(-1436, -436, 150));
		AddSpawnPoint("d_firetower_69_1.Id9", "d_firetower_69_1", Rectangle(-1705, 472, 150));
		AddSpawnPoint("d_firetower_69_1.Id9", "d_firetower_69_1", Rectangle(-1257, 645, 150));
		AddSpawnPoint("d_firetower_69_1.Id9", "d_firetower_69_1", Rectangle(-1931, 898, 150));
		AddSpawnPoint("d_firetower_69_1.Id9", "d_firetower_69_1", Rectangle(-1916, 1235, 150));
		AddSpawnPoint("d_firetower_69_1.Id9", "d_firetower_69_1", Rectangle(-578, 356, 150));
		AddSpawnPoint("d_firetower_69_1.Id9", "d_firetower_69_1", Rectangle(-245, 703, 150));
		AddSpawnPoint("d_firetower_69_1.Id9", "d_firetower_69_1", Rectangle(295, 653, 150));
		AddSpawnPoint("d_firetower_69_1.Id9", "d_firetower_69_1", Rectangle(455, 171, 150));
		AddSpawnPoint("d_firetower_69_1.Id9", "d_firetower_69_1", Rectangle(67, 179, 150));
		AddSpawnPoint("d_firetower_69_1.Id9", "d_firetower_69_1", Rectangle(896, 364, 150));
		AddSpawnPoint("d_firetower_69_1.Id9", "d_firetower_69_1", Rectangle(1614, 236, 150));
		AddSpawnPoint("d_firetower_69_1.Id9", "d_firetower_69_1", Rectangle(1821, 511, 150));
		AddSpawnPoint("d_firetower_69_1.Id9", "d_firetower_69_1", Rectangle(2343, 190, 150));
		AddSpawnPoint("d_firetower_69_1.Id9", "d_firetower_69_1", Rectangle(2525, 566, 150));
		AddSpawnPoint("d_firetower_69_1.Id9", "d_firetower_69_1", Rectangle(2634, 232, 150));
		AddSpawnPoint("d_firetower_69_1.Id9", "d_firetower_69_1", Rectangle(2437, -202, 150));
		AddSpawnPoint("d_firetower_69_1.Id9", "d_firetower_69_1", Rectangle(2201, -444, 150));
		AddSpawnPoint("d_firetower_69_1.Id9", "d_firetower_69_1", Rectangle(1797, -199, 150));
		AddSpawnPoint("d_firetower_69_1.Id9", "d_firetower_69_1", Rectangle(1242, -296, 150));
		AddSpawnPoint("d_firetower_69_1.Id9", "d_firetower_69_1", Rectangle(1080, -590, 150));
		AddSpawnPoint("d_firetower_69_1.Id9", "d_firetower_69_1", Rectangle(1172, -1271, 150));
		AddSpawnPoint("d_firetower_69_1.Id9", "d_firetower_69_1", Rectangle(1398, -1433, 150));
		AddSpawnPoint("d_firetower_69_1.Id9", "d_firetower_69_1", Rectangle(610, -955, 150));
		AddSpawnPoint("d_firetower_69_1.Id9", "d_firetower_69_1", Rectangle(320, -1334, 150));
		AddSpawnPoint("d_firetower_69_1.Id9", "d_firetower_69_1", Rectangle(-491, -286, 150));
		AddSpawnPoint("d_firetower_69_1.Id9", "d_firetower_69_1", Rectangle(-638, -760, 150));
		AddSpawnPoint("d_firetower_69_1.Id9", "d_firetower_69_1", Rectangle(-216, -949, 150));
		AddSpawnPoint("d_firetower_69_1.Id9", "d_firetower_69_1", Rectangle(-1211, -1706, 150));
		AddSpawnPoint("d_firetower_69_1.Id9", "d_firetower_69_1", Rectangle(-1503, -1433, 150));
		AddSpawnPoint("d_firetower_69_1.Id9", "d_firetower_69_1", Rectangle(-1818, -1647, 150));
	}
}
