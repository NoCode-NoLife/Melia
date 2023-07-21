//--- Melia Script -----------------------------------------------------------
// Evacuation Residential District Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_underfortress_30_3'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DUnderfortress303MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("d_underfortress_30_3.Id1", MonsterId.Candlespider_Blue, min: 19, max: 25, tendency: TendencyType.Aggressive);
		AddSpawner("d_underfortress_30_3.Id2", MonsterId.Colimen_Brown, min: 45, max: 60, tendency: TendencyType.Aggressive);
		AddSpawner("d_underfortress_30_3.Id3", MonsterId.Colimen_Mage_Brown, min: 19, max: 25, tendency: TendencyType.Aggressive);
		AddSpawner("d_underfortress_30_3.Id4", MonsterId.Rootcrystal_04, min: 23, max: 30, respawn: TimeSpan.FromMilliseconds(30000), tendency: TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Candlespider_Blue' GenType 1 Spawn Points
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(266, 210, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(98, -63, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(-340, 222, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(40, 716, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(345, 941, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(-223, 863, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(-723, 176, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(-869, -16, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(-913, 590, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(-742, 937, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(-790, 1528, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(-768, 1236, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(83, 1155, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(24, 1723, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(172, 1578, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(28, -132, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(-119, -346, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(217, -271, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(60, -353, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(62, -705, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(-353, -803, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(-1141, -860, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(-824, -796, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(-772, -970, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(-473, -766, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(402, -780, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(644, -811, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(817, -679, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(773, -819, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(1021, -851, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(1121, -804, 30));

		// 'Colimen_Brown' GenType 2 Spawn Points
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(1060, 830, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(902, 723, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(1054, 523, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(1145, 395, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(1055, 199, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(915, 136, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(1096, 6, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(1073, 1351, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(1084, 1624, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(930, 1498, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(1550, 1453, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(1790, 1530, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(1856, 1422, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(1727, 1411, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(670, 838, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(508, 770, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(276, 654, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-16, 695, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(211, 835, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-65, 1008, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(134, 1107, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(69, 1372, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(125, 1738, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-109, 1715, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(139, 1510, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(14, 273, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(7, 156, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(337, 216, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(186, 267, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-133, 195, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(67, -180, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-56, -317, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(99, -402, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(268, -266, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(54, -25, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(107, -583, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(18, -743, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-822, -889, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-949, -782, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-685, -724, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-632, -842, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-338, -746, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(531, -801, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(814, -708, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(908, -828, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(1061, -791, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(1076, -714, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(1182, -924, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-391, 235, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-528, 211, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-742, -90, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-826, 158, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-629, 303, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-936, 286, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-901, 603, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-816, 434, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-758, 852, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-694, 1278, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-838, 1474, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-737, 1629, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-668, 1428, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-1738, 1442, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-1787, 1753, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-1584, 1615, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-1725, 1570, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-1506, 1426, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-1268, 1480, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-1127, 1443, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-801, 1658, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(922, 429, 30));

		// 'Colimen_Mage_Brown' GenType 3 Spawn Points
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-741, 424, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-796, 621, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-711, 907, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-731, 1310, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-665, 1584, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-892, 1529, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-1213, 1511, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-1665, 1733, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-1645, 1402, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-1782, 1647, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-793, 196, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-688, -85, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-828, -100, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-563, 81, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-79, 203, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(62, -81, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(16, -452, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-122, -359, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(83, -300, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(290, -288, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(207, -431, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(68, -747, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-171, -797, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-409, -752, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-983, -881, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-1033, -718, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-757, -743, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-768, -935, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-532, -747, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-443, 240, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-298, 265, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-876, 1707, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-675, 1459, 30));

		// 'Rootcrystal_04' GenType 6 Spawn Points
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(-986, -752, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(-158, -742, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(621, -807, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(1129, -809, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(1465, -806, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(34, -320, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(67, 154, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(419, 138, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(-542, 258, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(-978, 85, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(-710, 1154, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(-916, 682, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(-589, 1495, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(-898, 1619, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(-1198, 1453, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(12, 720, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(92, 1278, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(424, 853, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(-57, 1716, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(338, 1628, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(1213, -37, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(875, 326, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(1000, 735, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(1085, 1244, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(984, 1672, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(1455, 1445, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(2024, 1386, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(364, -305, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(-1648, 1739, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(-1653, 1332, 10));
	}
}
