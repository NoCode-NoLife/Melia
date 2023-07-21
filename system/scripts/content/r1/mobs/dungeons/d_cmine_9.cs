//--- Melia Script -----------------------------------------------------------
// Crystal Mine Lot 2 - 2F Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_cmine_9'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DCmine9MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("d_cmine_9.Id1", MonsterId.Rootcrystal_01, 2, 2, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("d_cmine_9.Id2", MonsterId.FD_Bubbe_Fighter, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cmine_9.Id3", MonsterId.FD_Bubbe_Mage_Ice, 4, 5, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cmine_9.Id4", MonsterId.FD_Bubbe_Fighter, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cmine_9.Id5", MonsterId.FD_Stoulet_Mage, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_cmine_9.Id6", MonsterId.FD_Bubbe_Mage_Ice, 6, 7, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_cmine_9.Id7", MonsterId.FD_Bat_Big, 6, 7, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 514 Spawn Points
		AddSpawnPoint("d_cmine_9.Id1", "d_cmine_9", Rectangle(119, -1162, 30));
		AddSpawnPoint("d_cmine_9.Id1", "d_cmine_9", Rectangle(-538, -70, 30));
		AddSpawnPoint("d_cmine_9.Id1", "d_cmine_9", Rectangle(522, -24, 30));
		AddSpawnPoint("d_cmine_9.Id1", "d_cmine_9", Rectangle(-560, 521, 30));

		// 'FD_Bubbe_Fighter' GenType 1020 Spawn Points
		AddSpawnPoint("d_cmine_9.Id2", "d_cmine_9", Rectangle(-616, 443, 9999));

		// 'FD_Bubbe_Mage_Ice' GenType 1022 Spawn Points
		AddSpawnPoint("d_cmine_9.Id3", "d_cmine_9", Rectangle(172, -1077, 9999));

		// 'FD_Bubbe_Fighter' GenType 1023 Spawn Points
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-206, -508, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(1071, 766, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(917, 970, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(1106, 875, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(872, 1128, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(667, 1164, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(648, 845, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(594, 1040, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(703, -172, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(501, -258, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(509, 41, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(631, 51, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(741, 43, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(800, 91, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(855, 38, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(953, -71, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(478, 107, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(487, 184, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(589, 229, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(343, -1129, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(306, -1059, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(298, -991, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(360, -984, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(372, -1036, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(447, -998, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(433, -1067, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(421, -1134, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(519, -1082, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(495, -1152, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-320, -473, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-414, -544, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-321, -577, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-381, -421, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-259, -423, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-522, -496, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-471, -385, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-570, -531, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-470, -480, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-510, -168, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(62, 617, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(135, 628, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(127, 542, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(247, 586, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(446, 485, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(453, 422, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-183, 812, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-243, 846, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-247, 943, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-272, 908, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-507, 402, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-458, 269, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-583, 282, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-491, 192, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-582, 383, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-604, 150, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-636, 220, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-675, 421, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-766, 237, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-821, 349, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-688, 315, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-620, 508, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-697, 569, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-748, 631, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-808, 654, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-792, 508, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-776, 418, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-532, 483, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-1363, 756, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-1423, 843, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-1318, 894, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-1242, 952, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-1062, 865, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-994, 782, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-1029, 721, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-1781, 601, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-1717, 548, 20));
		AddSpawnPoint("d_cmine_9.Id4", "d_cmine_9", Rectangle(-1791, 553, 20));

		// 'FD_Stoulet_Mage' GenType 1050 Spawn Points
		AddSpawnPoint("d_cmine_9.Id5", "d_cmine_9", Rectangle(581, -53, 25));
		AddSpawnPoint("d_cmine_9.Id5", "d_cmine_9", Rectangle(712, 121, 25));
		AddSpawnPoint("d_cmine_9.Id5", "d_cmine_9", Rectangle(497, 252, 25));
		AddSpawnPoint("d_cmine_9.Id5", "d_cmine_9", Rectangle(667, 1049, 25));
		AddSpawnPoint("d_cmine_9.Id5", "d_cmine_9", Rectangle(953, 918, 25));
		AddSpawnPoint("d_cmine_9.Id5", "d_cmine_9", Rectangle(758, 1238, 25));
		AddSpawnPoint("d_cmine_9.Id5", "d_cmine_9", Rectangle(-460, 742, 25));
		AddSpawnPoint("d_cmine_9.Id5", "d_cmine_9", Rectangle(-661, 235, 25));
		AddSpawnPoint("d_cmine_9.Id5", "d_cmine_9", Rectangle(-591, 509, 25));
		AddSpawnPoint("d_cmine_9.Id5", "d_cmine_9", Rectangle(648, 882, 25));
		AddSpawnPoint("d_cmine_9.Id5", "d_cmine_9", Rectangle(557, -225, 25));
		AddSpawnPoint("d_cmine_9.Id5", "d_cmine_9", Rectangle(-793, 570, 25));
		AddSpawnPoint("d_cmine_9.Id5", "d_cmine_9", Rectangle(-516, 290, 25));

		// 'FD_Bubbe_Mage_Ice' GenType 1051 Spawn Points
		AddSpawnPoint("d_cmine_9.Id6", "d_cmine_9", Rectangle(203, -1106, 30));
		AddSpawnPoint("d_cmine_9.Id6", "d_cmine_9", Rectangle(556, -67, 30));
		AddSpawnPoint("d_cmine_9.Id6", "d_cmine_9", Rectangle(-646, -556, 30));
		AddSpawnPoint("d_cmine_9.Id6", "d_cmine_9", Rectangle(-817, -706, 30));
		AddSpawnPoint("d_cmine_9.Id6", "d_cmine_9", Rectangle(-568, -113, 30));
		AddSpawnPoint("d_cmine_9.Id6", "d_cmine_9", Rectangle(-224, -490, 30));
		AddSpawnPoint("d_cmine_9.Id6", "d_cmine_9", Rectangle(710, 1131, 30));
		AddSpawnPoint("d_cmine_9.Id6", "d_cmine_9", Rectangle(914, 740, 30));
		AddSpawnPoint("d_cmine_9.Id6", "d_cmine_9", Rectangle(-671, 382, 30));
		AddSpawnPoint("d_cmine_9.Id6", "d_cmine_9", Rectangle(-467, 417, 30));
		AddSpawnPoint("d_cmine_9.Id6", "d_cmine_9", Rectangle(-471, 724, 30));
		AddSpawnPoint("d_cmine_9.Id6", "d_cmine_9", Rectangle(-163, 849, 30));
		AddSpawnPoint("d_cmine_9.Id6", "d_cmine_9", Rectangle(217, 535, 30));
		AddSpawnPoint("d_cmine_9.Id6", "d_cmine_9", Rectangle(654, 178, 30));
		AddSpawnPoint("d_cmine_9.Id6", "d_cmine_9", Rectangle(-1137, 791, 30));
		AddSpawnPoint("d_cmine_9.Id6", "d_cmine_9", Rectangle(-1622, 649, 30));

		// 'FD_Bat_Big' GenType 1052 Spawn Points
		AddSpawnPoint("d_cmine_9.Id7", "d_cmine_9", Rectangle(556, 115, 9999));
	}
}
