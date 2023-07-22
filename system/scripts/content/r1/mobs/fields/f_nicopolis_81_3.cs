//--- Melia Script -----------------------------------------------------------
// Spell Tome Town Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_nicopolis_81_3'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FNicopolis813MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_nicopolis_81_3.Id1", MonsterId.Slime_Witch, min: 26, max: 34);
		AddSpawner("f_nicopolis_81_3.Id2", MonsterId.Slime_Wizard, min: 24, max: 32);
		AddSpawner("f_nicopolis_81_3.Id3", MonsterId.Popup_Cat, min: 42, max: 55);
		AddSpawner("f_nicopolis_81_3.Id4", MonsterId.Slime_Gemini, min: 6, max: 8);
		AddSpawner("f_nicopolis_81_3.Id5", MonsterId.Rootcrystal_02, min: 15, max: 20, respawn: TimeSpan.FromMilliseconds(30000));

		// Monster Spawn Points -----------------------------

		// 'Slime_Witch' GenType 1 Spawn Points
		AddSpawnPoint("f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Rectangle(-1971, 598, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Rectangle(-1519, 397, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Rectangle(-1578, 549, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Rectangle(-1263, 501, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Rectangle(-831, 817, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Rectangle(-505, 899, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Rectangle(-608, 654, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Rectangle(-142, 471, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Rectangle(-359, 778, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Rectangle(-361, 359, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Rectangle(-392, 25, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Rectangle(-527, -16, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Rectangle(-353, -196, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Rectangle(-571, -231, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Rectangle(-411, -305, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Rectangle(-629, -540, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Rectangle(-338, -1043, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Rectangle(-579, -994, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Rectangle(-474, -1266, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Rectangle(-215, -1287, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Rectangle(-646, -1280, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Rectangle(-88, -1114, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Rectangle(-11, -893, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Rectangle(226, -927, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Rectangle(222, -1174, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Rectangle(536, -1022, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Rectangle(599, -818, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Rectangle(448, -1455, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Rectangle(723, -1391, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Rectangle(867, -1624, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Rectangle(478, -1770, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Rectangle(654, -1628, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Rectangle(385, -1401, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id1", "f_nicopolis_81_3", Rectangle(-448, -532, 25));

		// 'Slime_Wizard' GenType 3 Spawn Points
		AddSpawnPoint("f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Rectangle(553, -1635, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Rectangle(328, -1530, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Rectangle(620, -1390, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Rectangle(789, -1534, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Rectangle(334, -1104, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Rectangle(483, -817, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Rectangle(-487, -1171, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Rectangle(-632, -1017, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Rectangle(-451, -1411, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Rectangle(506, -963, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Rectangle(867, -721, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Rectangle(1781, -967, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Rectangle(1872, -1244, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Rectangle(1699, -1210, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Rectangle(1691, -1695, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Rectangle(1746, -1416, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Rectangle(1619, -891, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Rectangle(1364, -69, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Rectangle(1294, 220, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Rectangle(1483, -126, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Rectangle(1732, 210, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Rectangle(2070, 192, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Rectangle(2088, -45, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Rectangle(2346, 60, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Rectangle(2269, 237, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Rectangle(2417, 383, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Rectangle(1152, -84, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Rectangle(1240, 328, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Rectangle(1588, 174, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Rectangle(1318, 582, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Rectangle(1529, 843, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id2", "f_nicopolis_81_3", Rectangle(1409, 1194, 25));

		// 'Popup_Cat' GenType 5 Spawn Points
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(-1688, 532, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(-1362, 456, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(-1060, 509, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(-523, 777, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(-702, 573, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(-305, 489, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(-527, 489, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(-540, 74, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(-570, -133, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(-478, -71, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(-615, -429, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(-480, -460, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(-589, -677, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(8, 359, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(429, 108, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(270, 253, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(402, 606, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(699, 446, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(635, 230, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(350, 474, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(687, 934, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(632, 1149, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(655, 1451, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(775, 1192, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(1120, 682, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(1238, 992, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(842, 582, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(1443, 732, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(1600, 1166, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(1465, 140, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(1414, 23, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(1154, -20, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(1648, 95, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(1276, -281, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(1466, -567, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(1467, -744, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(1339, -880, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(1162, -742, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(1173, -581, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(1411, -711, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(1958, 1013, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(1910, 1193, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(2145, 1074, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(2347, 986, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(2324, 1256, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(2467, 1155, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(2785, 1156, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(2403, 1417, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(2347, 1635, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(2019, 105, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(2140, -54, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(2312, 207, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(2194, 135, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(2139, 325, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id3", "f_nicopolis_81_3", Rectangle(992, -857, 25));

		// 'Slime_Gemini' GenType 7 Spawn Points
		AddSpawnPoint("f_nicopolis_81_3.Id4", "f_nicopolis_81_3", Rectangle(1406, 1064, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id4", "f_nicopolis_81_3", Rectangle(1361, 779, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id4", "f_nicopolis_81_3", Rectangle(1300, 82, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id4", "f_nicopolis_81_3", Rectangle(1608, 14, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id4", "f_nicopolis_81_3", Rectangle(558, 584, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id4", "f_nicopolis_81_3", Rectangle(471, 232, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id4", "f_nicopolis_81_3", Rectangle(-255, 601, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id4", "f_nicopolis_81_3", Rectangle(710, -858, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id4", "f_nicopolis_81_3", Rectangle(1135, -749, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id4", "f_nicopolis_81_3", Rectangle(276, -1051, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id4", "f_nicopolis_81_3", Rectangle(1300, -465, 25));
		AddSpawnPoint("f_nicopolis_81_3.Id4", "f_nicopolis_81_3", Rectangle(2227, 78, 25));

		// 'Rootcrystal_02' GenType 41 Spawn Points
		AddSpawnPoint("f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Rectangle(2403, 1239, 100));
		AddSpawnPoint("f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Rectangle(2013, 1094, 100));
		AddSpawnPoint("f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Rectangle(1405, 852, 100));
		AddSpawnPoint("f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Rectangle(1458, 47, 100));
		AddSpawnPoint("f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Rectangle(2193, 137, 100));
		AddSpawnPoint("f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Rectangle(1478, -569, 100));
		AddSpawnPoint("f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Rectangle(1120, -751, 100));
		AddSpawnPoint("f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Rectangle(1785, -1017, 100));
		AddSpawnPoint("f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Rectangle(1787, -1370, 100));
		AddSpawnPoint("f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Rectangle(668, -855, 100));
		AddSpawnPoint("f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Rectangle(239, -1062, 100));
		AddSpawnPoint("f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Rectangle(536, -1596, 100));
		AddSpawnPoint("f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Rectangle(-401, -1256, 100));
		AddSpawnPoint("f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Rectangle(-426, -474, 100));
		AddSpawnPoint("f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Rectangle(-459, 101, 100));
		AddSpawnPoint("f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Rectangle(-350, 600, 100));
		AddSpawnPoint("f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Rectangle(340, 262, 100));
		AddSpawnPoint("f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Rectangle(638, 609, 100));
		AddSpawnPoint("f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Rectangle(-1050, 521, 100));
		AddSpawnPoint("f_nicopolis_81_3.Id5", "f_nicopolis_81_3", Rectangle(-1635, 566, 100));
	}
}
