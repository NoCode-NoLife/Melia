//--- Melia Script -----------------------------------------------------------
// Jonael Commemorative Orb Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_dcapital_20_6'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FDcapital206MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_dcapital_20_6.Id1", MonsterId.Wood_Lwa_Green, 45, 60, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_dcapital_20_6.Id2", MonsterId.Ellomago_Green, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_dcapital_20_6.Id3", MonsterId.Ragged_Bird, 38, 50, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_dcapital_20_6.Id4", MonsterId.Ragged_Butcher, 27, 35, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_dcapital_20_6.Id5", MonsterId.Rootcrystal_04, 15, 20, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Wood_Lwa_Green' GenType 12 Spawn Points
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-335, -33, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-345, 129, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-315, 271, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-441, 420, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-519, 253, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-628, 396, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-712, 255, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-843, 326, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-1062, 328, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-1110, 470, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-1111, 601, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-1127, 796, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-1092, 1001, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-1093, 1157, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-915, 1233, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-915, 1395, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-1000, 1440, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-930, 1545, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-1020, 1609, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-715, 1304, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-643, 1138, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-724, 1523, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-744, 1708, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-889, 777, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-661, 683, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-642, 820, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-420, 776, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-159, 795, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-430, 681, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-118, 345, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-198, 293, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-2, 50, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-96, -141, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-29, -376, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-139, -472, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(299, 339, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(200, 470, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(322, 917, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(413, 887, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(420, 1061, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(448, 1251, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(292, 1369, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(363, 1425, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-15, 1390, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-111, 1475, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-29, 1585, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(506, -413, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(694, -447, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(733, -306, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(448, -267, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(218, -93, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(385, -9, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(618, 26, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(361, 158, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(202, 546, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-89, 492, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-145, -268, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-451, 338, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-700, 451, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-610, 275, 35));

		// 'Ellomago_Green' GenType 16 Spawn Points
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-723, 292, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-602, 383, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-384, 322, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-64, 304, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-146, 580, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-217, 801, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(146, 744, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(351, 442, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(105, 332, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(287, 270, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(413, 805, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(425, 1067, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(339, 1193, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(466, 1338, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(288, 1315, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-96, 1335, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-163, 1442, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-180, 1398, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-646, 442, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-846, 321, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-1026, 322, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-1094, 735, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-1131, 576, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-1167, 890, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-1076, 891, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-1063, 1000, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-994, 1175, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-843, 1227, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-777, 1492, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-702, 1227, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-805, 830, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-810, 721, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-724, 760, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-611, 877, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-755, 924, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-646, 569, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-712, 457, 40));

		// 'Ragged_Bird' GenType 17 Spawn Points
		AddSpawnPoint("f_dcapital_20_6.Id3", "f_dcapital_20_6", Rectangle(-702, 829, 9999));

		// 'Ragged_Butcher' GenType 18 Spawn Points
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(-164, 405, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(-25, 374, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(-201, 688, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(-236, 581, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(-211, 901, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(203, 350, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(384, 362, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(174, 613, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(465, 725, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(78, 853, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(339, 548, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(401, 963, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(-184, -174, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(-37, -292, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(-46, -409, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(-654, 330, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(-412, 353, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(-895, 876, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(-683, 772, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(-820, 721, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(-767, 1387, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(-770, 1201, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(192, 1424, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(178, 1337, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(320, 725, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(536, -534, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(846, -302, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(449, -256, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(506, -23, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(622, -370, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(-20, 102, 40));

		// 'Rootcrystal_04' GenType 22 Spawn Points
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(-356, -140, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(-476, 292, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(-771, 304, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(-982, 291, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(-1103, 513, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(-1071, 962, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(-1055, 1484, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(-790, 1175, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(-789, 1512, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(-173, 496, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(-142, 865, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(-102, -333, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(218, 415, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(425, 643, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(162, 842, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(483, 1011, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(297, 1445, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(-4, 1298, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(566, -10, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(478, -289, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(829, -328, 15));
	}
}
