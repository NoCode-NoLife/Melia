//--- Melia Script -----------------------------------------------------------
// Starving Demon's Way Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_pilgrimroad_46'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FPilgrimroad46MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_pilgrimroad_46", MonsterId.Kepari, Properties("MHP", 125041, "MINPATK", 2109, "MAXPATK", 2494, "MINMATK", 2109, "MAXMATK", 2494, "DEF", 1994, "MDEF", 1994));
		AddPropertyOverrides("f_pilgrimroad_46", MonsterId.Kepo_Seed, Properties("MHP", 125299, "MINPATK", 2112, "MAXPATK", 2498, "MINMATK", 2112, "MAXMATK", 2498, "DEF", 2009, "MDEF", 2009));
		AddPropertyOverrides("f_pilgrimroad_46", MonsterId.Wood_Goblin_Red, Properties("MHP", 125772, "MINPATK", 2118, "MAXPATK", 2506, "MINMATK", 2118, "MAXMATK", 2506, "DEF", 2036, "MDEF", 2036));
		AddPropertyOverrides("f_pilgrimroad_46", MonsterId.Kepo, Properties("MHP", 126384, "MINPATK", 2126, "MAXPATK", 2515, "MINMATK", 2126, "MAXMATK", 2515, "DEF", 2071, "MDEF", 2071));

		// Monster Spawners ---------------------------------

		AddSpawner("f_pilgrimroad_46.Id1", MonsterId.Kepari, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_46.Id2", MonsterId.Rootcrystal_01, 11, 14, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_46.Id3", MonsterId.Kepari, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_46.Id4", MonsterId.Kepo_Seed, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_46.Id5", MonsterId.Kepo_Seed, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_46.Id6", MonsterId.Kepari, 6, 7, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_46.Id7", MonsterId.Kepo, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_46.Id8", MonsterId.Kepo, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_46.Id9", MonsterId.Kepo, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_46.Id10", MonsterId.Wood_Goblin_Red, 38, 50, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Kepari' GenType 16 Spawn Points
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(58, -70, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(364, -355, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(714, -130, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(568, 101, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(640, 1347, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(844, 1365, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(1410, 887, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(273, -258, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(55, 42, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(573, -66, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(480, -237, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(5, -283, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(332, 191, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(611, -202, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(754, 150, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(1899, 671, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(398, -463, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(557, -346, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(1809, 1011, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(134, 142, 30));

		// 'Rootcrystal_01' GenType 30 Spawn Points
		AddSpawnPoint("f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Rectangle(-1816, -1913, 40));
		AddSpawnPoint("f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Rectangle(-1933, -1051, 40));
		AddSpawnPoint("f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Rectangle(-1040, -749, 40));
		AddSpawnPoint("f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Rectangle(-1311, -172, 40));
		AddSpawnPoint("f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Rectangle(-365, -1148, 40));
		AddSpawnPoint("f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Rectangle(241, -1041, 40));
		AddSpawnPoint("f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Rectangle(448, -342, 40));
		AddSpawnPoint("f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Rectangle(554, 176, 40));
		AddSpawnPoint("f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Rectangle(338, 717, 40));
		AddSpawnPoint("f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Rectangle(1344, 88, 40));
		AddSpawnPoint("f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Rectangle(1889, 189, 40));
		AddSpawnPoint("f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Rectangle(1812, 1019, 40));
		AddSpawnPoint("f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Rectangle(1285, 825, 40));
		AddSpawnPoint("f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Rectangle(618, 1387, 40));

		// 'Kepari' GenType 36 Spawn Points
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(540, 336, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(301, 594, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(16, 771, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(83, 551, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(148, 678, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(181, 808, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(1537, -329, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(1772, -376, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(1995, -317, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(2067, -77, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(1721, -193, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(1877, 36, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(1644, 13, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(1864, 208, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(1376, 21, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(1793, -109, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(1982, -96, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(1435, -202, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(1668, 202, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(507, 622, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(287, 719, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(227, 532, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(513, 447, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(1215, 58, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(1314, 162, 25));

		// 'Kepo_Seed' GenType 44 Spawn Points
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(-1840, -1789, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(-1380, -1848, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(-1528, -2022, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(-1604, -1683, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(-2093, -1255, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(-1913, -1021, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(-1696, -1171, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(-881, -872, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(-199, -1251, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(253, -961, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(61, -1204, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(-1162, -801, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(-827, -532, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(-1859, -1375, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(-2190, -971, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(-1102, -617, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(-1230, -985, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(-284, -965, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(-39, -955, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(199, -655, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(57, -682, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(16, -1428, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(283, -1187, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(-318, -1350, 50));

		// 'Kepo_Seed' GenType 45 Spawn Points
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(1300, 913, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(1931, 772, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(1804, 648, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(1321, 1158, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(1581, 901, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(861, 163, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(1975, 1006, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(1822, 1044, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(126, 648, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(424, 594, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(118, 838, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(329, 182, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(1470, 1018, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(685, 182, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(1635, 1097, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(2087, 1138, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(347, -278, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(91, -49, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(584, -144, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(1591, 715, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(1448, 645, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(1712, 717, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(1886, 945, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(2112, 876, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(1883, 515, 30));

		// 'Kepari' GenType 46 Spawn Points
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(-13, -1255, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(237, -926, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(-273, -1144, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(-303, -1305, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(-26, -1417, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(263, -1108, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(276, -1299, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(-157, -1449, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(-115, -1269, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(27, -1108, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(146, -1263, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(180, -1382, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(215, -1169, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(169, -1040, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(143, -741, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(-71, -855, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(-186, -933, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(-326, -943, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(-414, -1203, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(-473, -1078, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(-801, -955, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(-119, -1169, 25));

		// 'Kepo' GenType 49 Spawn Points
		AddSpawnPoint("f_pilgrimroad_46.Id7", "f_pilgrimroad_46", Rectangle(267, -260, 9999));

		// 'Kepo' GenType 50 Spawn Points
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-2106, -1237, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-1925, -980, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-1216, -711, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-1850, -1290, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-1061, -898, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-1956, -1090, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-2082, -1055, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-1732, -1215, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-1691, -1116, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-1230, -837, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-1041, -638, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-931, -720, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-761, -401, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-818, -298, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-1062, -317, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-969, -807, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-1115, -539, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-775, -624, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-918, -551, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-753, -506, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-1248, -962, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-850, -915, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-740, -806, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-1082, -760, 25));

		// 'Kepo' GenType 51 Spawn Points
		AddSpawnPoint("f_pilgrimroad_46.Id9", "f_pilgrimroad_46", Rectangle(425, -335, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id9", "f_pilgrimroad_46", Rectangle(17, -81, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id9", "f_pilgrimroad_46", Rectangle(76, 105, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id9", "f_pilgrimroad_46", Rectangle(556, 122, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id9", "f_pilgrimroad_46", Rectangle(635, -91, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id9", "f_pilgrimroad_46", Rectangle(229, -289, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id9", "f_pilgrimroad_46", Rectangle(567, -220, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id9", "f_pilgrimroad_46", Rectangle(248, 155, 30));

		// 'Wood_Goblin_Red' GenType 58 Spawn Points
		AddSpawnPoint("f_pilgrimroad_46.Id10", "f_pilgrimroad_46", Rectangle(322, 125, 2000));
	}
}
