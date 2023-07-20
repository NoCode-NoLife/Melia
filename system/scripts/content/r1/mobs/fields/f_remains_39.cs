//--- Melia Script -----------------------------------------------------------
// Escanciu Village Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_remains_39'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FRemains39MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_remains_39", MonsterId.Gravegolem, Properties("MHP", 85709, "MINPATK", 1603, "MAXPATK", 1872, "MINMATK", 1603, "MAXMATK", 1872, "DEF", 713, "MDEF", 713));
		AddPropertyOverrides("f_remains_39", MonsterId.Zolem, Properties("MHP", 85916, "MINPATK", 1606, "MAXPATK", 1875, "MINMATK", 1606, "MAXMATK", 1875, "DEF", 720, "MDEF", 720));
		AddPropertyOverrides("f_remains_39", MonsterId.Flying_Flog, Properties("MHP", 86296, "MINPATK", 1611, "MAXPATK", 1881, "MINMATK", 1611, "MAXMATK", 1881, "DEF", 732, "MDEF", 732));
		AddPropertyOverrides("f_remains_39", MonsterId.Hook, Properties("MHP", 86787, "MINPATK", 1617, "MAXPATK", 1889, "MINMATK", 1617, "MAXMATK", 1889, "DEF", 748, "MDEF", 748));

		// Monster Spawners ---------------------------------

		AddSpawner("f_remains_39.Id1", MonsterId.Gravegolem, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_39.Id2", MonsterId.Zolem, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_39.Id3", MonsterId.Hook, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_39.Id4", MonsterId.Zolem, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_39.Id5", MonsterId.Hook, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_39.Id6", MonsterId.Flying_Flog, 10, 13, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_39.Id7", MonsterId.Zolem, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_39.Id8", MonsterId.Gravegolem, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_39.Id9", MonsterId.Rootcrystal_01, 13, 17, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Gravegolem' GenType 2 Spawn Points
		AddSpawnPoint("f_remains_39.Id1", "f_remains_39", Rectangle(979, 295, 25));
		AddSpawnPoint("f_remains_39.Id1", "f_remains_39", Rectangle(982, 80, 25));
		AddSpawnPoint("f_remains_39.Id1", "f_remains_39", Rectangle(869, 523, 25));
		AddSpawnPoint("f_remains_39.Id1", "f_remains_39", Rectangle(992, 571, 25));
		AddSpawnPoint("f_remains_39.Id1", "f_remains_39", Rectangle(1148, 499, 25));
		AddSpawnPoint("f_remains_39.Id1", "f_remains_39", Rectangle(1156, 269, 25));
		AddSpawnPoint("f_remains_39.Id1", "f_remains_39", Rectangle(1112, 67, 25));
		AddSpawnPoint("f_remains_39.Id1", "f_remains_39", Rectangle(973, -76, 25));
		AddSpawnPoint("f_remains_39.Id1", "f_remains_39", Rectangle(1149, -116, 25));
		AddSpawnPoint("f_remains_39.Id1", "f_remains_39", Rectangle(842, 377, 25));
		AddSpawnPoint("f_remains_39.Id1", "f_remains_39", Rectangle(933, 742, 25));

		// 'Zolem' GenType 3 Spawn Points
		AddSpawnPoint("f_remains_39.Id2", "f_remains_39", Rectangle(470, -404, 25));
		AddSpawnPoint("f_remains_39.Id2", "f_remains_39", Rectangle(297, -523, 25));
		AddSpawnPoint("f_remains_39.Id2", "f_remains_39", Rectangle(359, -426, 25));
		AddSpawnPoint("f_remains_39.Id2", "f_remains_39", Rectangle(508, -564, 25));
		AddSpawnPoint("f_remains_39.Id2", "f_remains_39", Rectangle(544, -362, 25));
		AddSpawnPoint("f_remains_39.Id2", "f_remains_39", Rectangle(646, -506, 25));
		AddSpawnPoint("f_remains_39.Id2", "f_remains_39", Rectangle(685, -375, 25));

		// 'Hook' GenType 7 Spawn Points
		AddSpawnPoint("f_remains_39.Id3", "f_remains_39", Rectangle(-356, 517, 9999));

		// 'Zolem' GenType 46 Spawn Points
		AddSpawnPoint("f_remains_39.Id4", "f_remains_39", Rectangle(1015, 1062, 9999));

		// 'Hook' GenType 47 Spawn Points
		AddSpawnPoint("f_remains_39.Id5", "f_remains_39", Rectangle(-569, -67, 25));
		AddSpawnPoint("f_remains_39.Id5", "f_remains_39", Rectangle(-623, -165, 25));
		AddSpawnPoint("f_remains_39.Id5", "f_remains_39", Rectangle(-797, 98, 25));
		AddSpawnPoint("f_remains_39.Id5", "f_remains_39", Rectangle(-538, 143, 25));
		AddSpawnPoint("f_remains_39.Id5", "f_remains_39", Rectangle(-682, 483, 25));
		AddSpawnPoint("f_remains_39.Id5", "f_remains_39", Rectangle(-714, 636, 25));
		AddSpawnPoint("f_remains_39.Id5", "f_remains_39", Rectangle(-393, 417, 25));
		AddSpawnPoint("f_remains_39.Id5", "f_remains_39", Rectangle(-796, -65, 25));
		AddSpawnPoint("f_remains_39.Id5", "f_remains_39", Rectangle(-391, -288, 25));
		AddSpawnPoint("f_remains_39.Id5", "f_remains_39", Rectangle(-511, -335, 25));
		AddSpawnPoint("f_remains_39.Id5", "f_remains_39", Rectangle(-767, -370, 25));

		// 'Flying_Flog' GenType 48 Spawn Points
		AddSpawnPoint("f_remains_39.Id6", "f_remains_39", Rectangle(-560, 558, 25));
		AddSpawnPoint("f_remains_39.Id6", "f_remains_39", Rectangle(-718, 605, 25));
		AddSpawnPoint("f_remains_39.Id6", "f_remains_39", Rectangle(-651, 748, 25));
		AddSpawnPoint("f_remains_39.Id6", "f_remains_39", Rectangle(-379, 619, 25));
		AddSpawnPoint("f_remains_39.Id6", "f_remains_39", Rectangle(-538, 268, 25));
		AddSpawnPoint("f_remains_39.Id6", "f_remains_39", Rectangle(-391, 384, 25));
		AddSpawnPoint("f_remains_39.Id6", "f_remains_39", Rectangle(-777, 398, 25));
		AddSpawnPoint("f_remains_39.Id6", "f_remains_39", Rectangle(251, -483, 25));
		AddSpawnPoint("f_remains_39.Id6", "f_remains_39", Rectangle(344, -358, 25));
		AddSpawnPoint("f_remains_39.Id6", "f_remains_39", Rectangle(474, -496, 25));
		AddSpawnPoint("f_remains_39.Id6", "f_remains_39", Rectangle(692, -240, 25));
		AddSpawnPoint("f_remains_39.Id6", "f_remains_39", Rectangle(66, -314, 25));
		AddSpawnPoint("f_remains_39.Id6", "f_remains_39", Rectangle(588, -405, 25));
		AddSpawnPoint("f_remains_39.Id6", "f_remains_39", Rectangle(676, -556, 25));

		// 'Zolem' GenType 50 Spawn Points
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(-1331, -416, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(-1222, -329, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(-993, -432, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(-921, -184, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(-542, -198, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(-403, -370, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(-531, -679, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(-1142, -79, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(-1048, -722, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(-901, -590, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(33, -225, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(134, -197, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(72, -357, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(169, -507, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(349, -168, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(345, -494, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(399, -579, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(568, -483, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(644, -303, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(626, -218, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(482, -344, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(733, -307, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(299, -395, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(942, 1179, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(971, 1033, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(1149, 1174, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(894, 1055, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(865, 1169, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(823, 1279, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(1067, 1083, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(1025, 1271, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(1151, 1380, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(1075, 1492, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(1026, 1377, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(902, 1444, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(896, 1577, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(962, 1588, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(1109, 1378, 30));

		// 'Gravegolem' GenType 51 Spawn Points
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(360, -408, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(546, -435, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(716, -423, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(665, -557, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(933, -116, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(485, -550, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(1014, -494, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(871, -409, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-1313, -314, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-1339, -75, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-1142, 49, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-1027, 84, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-937, -37, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-1181, -160, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-1228, -390, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-1409, -499, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-1261, -549, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-1040, -806, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-1132, -729, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-1010, -319, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-884, -377, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-690, -735, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-714, -664, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-696, -517, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-598, -447, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-467, -443, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-436, -533, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-471, -256, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-676, -238, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-430, -160, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-677, -62, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-736, -37, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-792, 12, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-682, 33, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-673, 194, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-478, 195, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-458, 83, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-423, 18, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-756, 322, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-750, 465, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-433, 281, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-421, 551, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-471, 693, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-597, 794, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-746, 744, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(1069, -311, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(1154, -317, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(1166, -249, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(1075, -85, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(897, 133, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(881, 283, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(797, 331, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(1030, 233, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(1171, 352, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(1155, 423, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(989, 511, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(916, 633, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(857, 586, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(1009, 682, 30));

		// 'Rootcrystal_01' GenType 54 Spawn Points
		AddSpawnPoint("f_remains_39.Id9", "f_remains_39", Rectangle(-1228, -364, 200));
		AddSpawnPoint("f_remains_39.Id9", "f_remains_39", Rectangle(-1233, -52, 200));
		AddSpawnPoint("f_remains_39.Id9", "f_remains_39", Rectangle(-997, -652, 200));
		AddSpawnPoint("f_remains_39.Id9", "f_remains_39", Rectangle(-884, -297, 200));
		AddSpawnPoint("f_remains_39.Id9", "f_remains_39", Rectangle(-536, -543, 200));
		AddSpawnPoint("f_remains_39.Id9", "f_remains_39", Rectangle(-504, -136, 200));
		AddSpawnPoint("f_remains_39.Id9", "f_remains_39", Rectangle(-566, 248, 200));
		AddSpawnPoint("f_remains_39.Id9", "f_remains_39", Rectangle(-593, 554, 200));
		AddSpawnPoint("f_remains_39.Id9", "f_remains_39", Rectangle(305, -300, 200));
		AddSpawnPoint("f_remains_39.Id9", "f_remains_39", Rectangle(591, -448, 200));
		AddSpawnPoint("f_remains_39.Id9", "f_remains_39", Rectangle(1078, -349, 200));
		AddSpawnPoint("f_remains_39.Id9", "f_remains_39", Rectangle(1025, -5, 200));
		AddSpawnPoint("f_remains_39.Id9", "f_remains_39", Rectangle(987, 364, 200));
		AddSpawnPoint("f_remains_39.Id9", "f_remains_39", Rectangle(934, 734, 200));
		AddSpawnPoint("f_remains_39.Id9", "f_remains_39", Rectangle(1010, 1079, 200));
		AddSpawnPoint("f_remains_39.Id9", "f_remains_39", Rectangle(996, 1415, 200));
	}
}
