//--- Melia Script -----------------------------------------------------------
// Genar Field Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_pilgrimroad_49'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FPilgrimroad49MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_pilgrimroad_49.Id1", MonsterId.Rootcrystal_05, 12, 15, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_49.Id2", MonsterId.Sec_Beetle, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_49.Id3", MonsterId.Sec_Dandel_Orange, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_49.Id4", MonsterId.Sec_Kepari_Mage, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_49.Id5", MonsterId.Sec_Dandel_Orange, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_49.Id6", MonsterId.Sec_Beetle, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_49.Id7", MonsterId.Sec_Beetle, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_49.Id8", MonsterId.Sec_Kepari_Mage, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_05' GenType 4 Spawn Points
		AddSpawnPoint("f_pilgrimroad_49.Id1", "f_pilgrimroad_49", Rectangle(-1009, -2132, 10));
		AddSpawnPoint("f_pilgrimroad_49.Id1", "f_pilgrimroad_49", Rectangle(-379, -1661, 10));
		AddSpawnPoint("f_pilgrimroad_49.Id1", "f_pilgrimroad_49", Rectangle(-84, -789, 10));
		AddSpawnPoint("f_pilgrimroad_49.Id1", "f_pilgrimroad_49", Rectangle(-894, -136, 10));
		AddSpawnPoint("f_pilgrimroad_49.Id1", "f_pilgrimroad_49", Rectangle(-1798, -317, 10));
		AddSpawnPoint("f_pilgrimroad_49.Id1", "f_pilgrimroad_49", Rectangle(265, -364, 10));
		AddSpawnPoint("f_pilgrimroad_49.Id1", "f_pilgrimroad_49", Rectangle(-25, 990, 10));
		AddSpawnPoint("f_pilgrimroad_49.Id1", "f_pilgrimroad_49", Rectangle(-1218, 480, 10));
		AddSpawnPoint("f_pilgrimroad_49.Id1", "f_pilgrimroad_49", Rectangle(-1236, 901, 10));
		AddSpawnPoint("f_pilgrimroad_49.Id1", "f_pilgrimroad_49", Rectangle(983, 1409, 10));
		AddSpawnPoint("f_pilgrimroad_49.Id1", "f_pilgrimroad_49", Rectangle(1688, -50, 10));
		AddSpawnPoint("f_pilgrimroad_49.Id1", "f_pilgrimroad_49", Rectangle(2065, -1313, 10));
		AddSpawnPoint("f_pilgrimroad_49.Id1", "f_pilgrimroad_49", Rectangle(1193, 31, 10));

		// 'Sec_Beetle' GenType 10 Spawn Points
		AddSpawnPoint("f_pilgrimroad_49.Id2", "f_pilgrimroad_49", Rectangle(-1087, -2408, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id2", "f_pilgrimroad_49", Rectangle(-943, -2567, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id2", "f_pilgrimroad_49", Rectangle(-1024, -2577, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id2", "f_pilgrimroad_49", Rectangle(-879, -2684, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id2", "f_pilgrimroad_49", Rectangle(-777, -2567, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id2", "f_pilgrimroad_49", Rectangle(-639, -2514, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id2", "f_pilgrimroad_49", Rectangle(-952, -2309, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id2", "f_pilgrimroad_49", Rectangle(-967, -2170, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id2", "f_pilgrimroad_49", Rectangle(-881, -2094, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id2", "f_pilgrimroad_49", Rectangle(-744, -2420, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id2", "f_pilgrimroad_49", Rectangle(-715, -2114, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id2", "f_pilgrimroad_49", Rectangle(-783, -2309, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id2", "f_pilgrimroad_49", Rectangle(-564, -2314, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id2", "f_pilgrimroad_49", Rectangle(-652, -1978, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id2", "f_pilgrimroad_49", Rectangle(-646, -1758, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id2", "f_pilgrimroad_49", Rectangle(-377, -1725, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id2", "f_pilgrimroad_49", Rectangle(-415, -1576, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id2", "f_pilgrimroad_49", Rectangle(-237, -1570, 30));

		// 'Sec_Dandel_Orange' GenType 11 Spawn Points
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1341, -93, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1629, -296, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1810, -450, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1825, -273, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1579, -107, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1523, 107, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1818, 31, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1986, 52, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(2097, 42, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(2154, -296, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(2051, -506, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1537, -400, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1772, -94, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1700, 197, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1917, 238, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1236, 197, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(2191, -150, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1371, 25, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1520, -199, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1670, 131, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1229, 1781, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1024, 1644, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1112, 1802, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1248, 1415, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1107, 1385, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1007, 1493, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(977, 1365, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1057, 1201, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1134, 1122, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1313, 1270, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1219, 1219, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1172, 1627, 30));

		// 'Sec_Kepari_Mage' GenType 12 Spawn Points
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(-604, 865, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(-494, 915, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(-172, 856, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(-173, 537, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(212, 920, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(143, 729, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(26, 856, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(57, 620, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(30, 445, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(-79, 651, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(74, 1005, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(298, 984, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(-2069, -455, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(-2029, -264, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(-1874, -498, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(-1686, -584, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(-1709, -397, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(-1929, -126, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(-1507, -334, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(-1581, -446, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(-1888, -353, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(-1778, -182, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(-1853, -38, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(-1642, -302, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(-2164, -548, 30));

		// 'Sec_Dandel_Orange' GenType 13 Spawn Points
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(-1145, -219, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(-1072, -113, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(-985, -26, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(-960, -146, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(-995, -293, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(-1128, -360, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(-918, -416, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(-1246, -359, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(-791, -340, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(-204, -576, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(-253, -824, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(17, -925, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(-79, -714, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(80, -1111, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(293, -1065, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(565, -923, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(154, -610, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(516, -480, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(465, -588, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(345, -510, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(257, -882, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(-883, -239, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(-820, -143, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(-676, -316, 30));

		// 'Sec_Beetle' GenType 14 Spawn Points
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(-1830, 264, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(-1721, 424, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(-1469, 481, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(-1073, 632, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(-895, 691, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(-1019, 862, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(-1221, 917, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(-1511, 707, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(-1011, 832, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(-723, 875, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(-1244, 526, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(-256, -654, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(160, -490, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(-100, -1042, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(210, -1149, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(419, -971, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(652, -465, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(10, -468, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(225, -197, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(1569, -243, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(1783, -1393, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(1930, -1254, 30));

		// 'Sec_Beetle' GenType 15 Spawn Points
		AddSpawnPoint("f_pilgrimroad_49.Id7", "f_pilgrimroad_49", Rectangle(2031, -1527, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id7", "f_pilgrimroad_49", Rectangle(1740, -1315, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id7", "f_pilgrimroad_49", Rectangle(1908, -1501, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id7", "f_pilgrimroad_49", Rectangle(1971, -1233, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id7", "f_pilgrimroad_49", Rectangle(2137, -1083, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id7", "f_pilgrimroad_49", Rectangle(2180, -1274, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id7", "f_pilgrimroad_49", Rectangle(2160, -1475, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id7", "f_pilgrimroad_49", Rectangle(2238, -1552, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id7", "f_pilgrimroad_49", Rectangle(2408, -1255, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id7", "f_pilgrimroad_49", Rectangle(2255, -1164, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id7", "f_pilgrimroad_49", Rectangle(2447, -1136, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id7", "f_pilgrimroad_49", Rectangle(2410, -1535, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id7", "f_pilgrimroad_49", Rectangle(2489, -1373, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id7", "f_pilgrimroad_49", Rectangle(2088, -1336, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id7", "f_pilgrimroad_49", Rectangle(2047, -1086, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id7", "f_pilgrimroad_49", Rectangle(1859, -1201, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id7", "f_pilgrimroad_49", Rectangle(1879, -1359, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id7", "f_pilgrimroad_49", Rectangle(1735, -1457, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id7", "f_pilgrimroad_49", Rectangle(2012, -1630, 30));

		// 'Sec_Kepari_Mage' GenType 16 Spawn Points
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(-162, -843, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(-38, -595, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(39, -757, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(-32, -1196, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(171, -941, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(407, -1145, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(545, -716, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(371, -360, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(214, -373, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(-261, -493, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(428, -836, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(636, -313, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(1963, -1115, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(2250, -1178, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(2082, -1282, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(1782, -1376, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(2015, -1545, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(2048, -1384, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(2231, -1587, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(2316, -1327, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(2407, -1493, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(2441, -1194, 30));
	}
}
