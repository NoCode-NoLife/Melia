//--- Melia Script -----------------------------------------------------------
// Roxona Reconstruction Agency East Building Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_firetower_61_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DFiretower612MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("d_firetower_61_2.Id1", MonsterId.Velffigy, min: 8, max: 10, tendency: TendencyType.Aggressive);
		AddSpawner("d_firetower_61_2.Id2", MonsterId.Glyquare, min: 12, max: 15, tendency: TendencyType.Aggressive);
		AddSpawner("d_firetower_61_2.Id3", MonsterId.Colifly_Black, min: 38, max: 50, tendency: TendencyType.Aggressive);
		AddSpawner("d_firetower_61_2.Id4", MonsterId.Glyquare, min: 6, max: 7, tendency: TendencyType.Aggressive);
		AddSpawner("d_firetower_61_2.Id5", MonsterId.Altarcrystal_R1, amount: 1, respawn: TimeSpan.FromMilliseconds(120000), tendency: TendencyType.Peaceful);
		AddSpawner("d_firetower_61_2.Id6", MonsterId.Altarcrystal_R1, amount: 2, respawn: TimeSpan.FromMilliseconds(120000), tendency: TendencyType.Peaceful);
		AddSpawner("d_firetower_61_2.Id7", MonsterId.Altarcrystal_R1, amount: 2, respawn: TimeSpan.FromMilliseconds(180000), tendency: TendencyType.Peaceful);
		AddSpawner("d_firetower_61_2.Id8", MonsterId.Rootcrystal_04, min: 19, max: 25, respawn: TimeSpan.FromMilliseconds(30000), tendency: TendencyType.Peaceful);
		AddSpawner("d_firetower_61_2.Id9", MonsterId.Colifly_Black, min: 15, max: 20, tendency: TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Velffigy' GenType 1 Spawn Points
		AddSpawnPoint("d_firetower_61_2.Id1", "d_firetower_61_2", Rectangle(-1431, -373, 25));
		AddSpawnPoint("d_firetower_61_2.Id1", "d_firetower_61_2", Rectangle(-1197, -313, 25));
		AddSpawnPoint("d_firetower_61_2.Id1", "d_firetower_61_2", Rectangle(-1091, -407, 25));
		AddSpawnPoint("d_firetower_61_2.Id1", "d_firetower_61_2", Rectangle(-1112, -192, 25));
		AddSpawnPoint("d_firetower_61_2.Id1", "d_firetower_61_2", Rectangle(-1115, -945, 25));
		AddSpawnPoint("d_firetower_61_2.Id1", "d_firetower_61_2", Rectangle(-1057, -1090, 25));
		AddSpawnPoint("d_firetower_61_2.Id1", "d_firetower_61_2", Rectangle(-990, -895, 25));
		AddSpawnPoint("d_firetower_61_2.Id1", "d_firetower_61_2", Rectangle(-1021, -338, 25));
		AddSpawnPoint("d_firetower_61_2.Id1", "d_firetower_61_2", Rectangle(-25, -329, 25));
		AddSpawnPoint("d_firetower_61_2.Id1", "d_firetower_61_2", Rectangle(-20, -103, 25));
		AddSpawnPoint("d_firetower_61_2.Id1", "d_firetower_61_2", Rectangle(95, -365, 25));
		AddSpawnPoint("d_firetower_61_2.Id1", "d_firetower_61_2", Rectangle(-1158, -830, 25));
		AddSpawnPoint("d_firetower_61_2.Id1", "d_firetower_61_2", Rectangle(-1171, -1055, 25));
		AddSpawnPoint("d_firetower_61_2.Id1", "d_firetower_61_2", Rectangle(-204, -416, 25));

		// 'Glyquare' GenType 5 Spawn Points
		AddSpawnPoint("d_firetower_61_2.Id2", "d_firetower_61_2", Rectangle(-80, -553, 20));
		AddSpawnPoint("d_firetower_61_2.Id2", "d_firetower_61_2", Rectangle(-373, -218, 20));
		AddSpawnPoint("d_firetower_61_2.Id2", "d_firetower_61_2", Rectangle(315, -289, 20));
		AddSpawnPoint("d_firetower_61_2.Id2", "d_firetower_61_2", Rectangle(-95, 310, 20));
		AddSpawnPoint("d_firetower_61_2.Id2", "d_firetower_61_2", Rectangle(-264, -1636, 20));
		AddSpawnPoint("d_firetower_61_2.Id2", "d_firetower_61_2", Rectangle(-1156, -96, 20));
		AddSpawnPoint("d_firetower_61_2.Id2", "d_firetower_61_2", Rectangle(-1298, -380, 20));
		AddSpawnPoint("d_firetower_61_2.Id2", "d_firetower_61_2", Rectangle(-988, -387, 20));
		AddSpawnPoint("d_firetower_61_2.Id2", "d_firetower_61_2", Rectangle(-1830, -789, 20));
		AddSpawnPoint("d_firetower_61_2.Id2", "d_firetower_61_2", Rectangle(-1930, -761, 20));
		AddSpawnPoint("d_firetower_61_2.Id2", "d_firetower_61_2", Rectangle(-1761, -1094, 20));
		AddSpawnPoint("d_firetower_61_2.Id2", "d_firetower_61_2", Rectangle(-877, 414, 20));
		AddSpawnPoint("d_firetower_61_2.Id2", "d_firetower_61_2", Rectangle(-1127, 391, 20));
		AddSpawnPoint("d_firetower_61_2.Id2", "d_firetower_61_2", Rectangle(13, 391, 20));
		AddSpawnPoint("d_firetower_61_2.Id2", "d_firetower_61_2", Rectangle(72, 442, 20));
		AddSpawnPoint("d_firetower_61_2.Id2", "d_firetower_61_2", Rectangle(-111, 420, 20));

		// 'Colifly_Black' GenType 6 Spawn Points
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-263, -1387, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(52, -1500, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-168, -1681, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(18, -1726, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(130, -1365, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-68, -1553, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-203, 457, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-89, 622, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(5, 321, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(148, 535, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-152, -306, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-102, -489, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(135, -198, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(30, 514, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1747, -1138, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1951, -1102, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1877, -1075, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-2021, -1051, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1895, -930, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1979, -927, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1906, -843, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1811, -862, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1822, -967, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1770, -915, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1991, -896, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-2052, -977, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1948, -1005, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-2033, -1140, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1889, -1245, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1828, -1366, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1919, -1309, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1809, -1217, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1757, -1302, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1820, -1285, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1959, -1174, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1870, -1154, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1819, -1168, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1957, -1359, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-2018, -1249, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1373, -330, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1344, -302, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1357, -385, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1163, -348, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1132, -316, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1148, -186, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1111, -137, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1119, -382, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1140, -437, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1032, -390, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-941, -429, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-927, -180, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1004, -142, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1085, -505, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1174, -468, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1187, -429, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1039, -220, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-898, -340, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-944, -270, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1091, -834, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1028, -822, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-942, -973, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-902, -1095, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-975, -1149, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1018, -1055, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1059, -935, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1119, -880, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1196, -968, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1153, -915, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1105, -1015, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1070, -1144, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1003, -947, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-912, -942, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-889, -1013, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-174, -1378, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-82, -1319, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(3, -1347, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(30, -1432, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-54, -1421, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-216, -1477, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-144, -1500, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-341, -1544, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-224, -1568, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-98, -1730, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-27, -1638, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-32, -1729, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(34, -1583, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(78, -1689, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(153, -1617, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(155, -1536, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(124, -1442, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(267, -1534, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(82, -1553, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-113, -1430, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-335, -1638, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-47, -762, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-208, -147, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-84, -118, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(51, -109, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(78, -236, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-31, -205, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(24, -219, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-140, -203, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-91, -265, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-248, -213, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-236, -323, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-121, -395, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-40, -417, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-18, -492, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(80, -504, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(118, -436, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(176, -334, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(251, -311, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(37, -360, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(71, -288, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-88, -350, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-216, 382, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-162, 335, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-49, 377, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-238, 537, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-183, 607, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-153, 546, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-32, 651, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-57, 565, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(73, 625, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(86, 531, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(142, 439, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(72, 375, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-73, 425, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-97, 471, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(11, 599, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(850, -1018, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(868, -934, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(948, -863, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(999, -813, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1120, -848, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1171, -935, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1048, -948, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1122, -1027, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1070, -1094, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(940, -1130, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(822, -1053, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(923, -978, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(934, -926, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1118, -951, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1012, -1085, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(867, -1107, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(929, -1037, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(827, -974, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(883, -980, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1028, -864, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(814, -356, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(908, -475, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1065, -504, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1157, -447, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(870, -275, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(912, -178, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1008, -160, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1141, -211, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1165, -304, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1210, -379, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(988, -341, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(933, -223, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1061, -208, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1113, -269, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1036, -411, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(864, -420, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(876, -340, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(926, -297, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(983, -276, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(936, -399, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1014, 405, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(983, 465, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1026, 461, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1005, 527, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1020, 497, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(690, 775, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(604, 942, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(680, 937, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(722, 872, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(776, 729, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(701, 582, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(683, 708, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(608, 778, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(625, 846, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(666, 1003, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(734, 976, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(788, 964, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(821, 884, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(798, 811, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(805, 661, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(597, 560, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(786, 563, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(724, 638, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(849, 723, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(622, 650, 30));

		// 'Glyquare' GenType 7 Spawn Points
		AddSpawnPoint("d_firetower_61_2.Id4", "d_firetower_61_2", Rectangle(844, -217, 20));
		AddSpawnPoint("d_firetower_61_2.Id4", "d_firetower_61_2", Rectangle(807, -398, 20));
		AddSpawnPoint("d_firetower_61_2.Id4", "d_firetower_61_2", Rectangle(1096, -388, 20));
		AddSpawnPoint("d_firetower_61_2.Id4", "d_firetower_61_2", Rectangle(1125, -507, 20));
		AddSpawnPoint("d_firetower_61_2.Id4", "d_firetower_61_2", Rectangle(1057, 287, 20));
		AddSpawnPoint("d_firetower_61_2.Id4", "d_firetower_61_2", Rectangle(984, 363, 20));
		AddSpawnPoint("d_firetower_61_2.Id4", "d_firetower_61_2", Rectangle(1022, -1164, 20));
		AddSpawnPoint("d_firetower_61_2.Id4", "d_firetower_61_2", Rectangle(956, -522, 20));

		// 'Altarcrystal_R1' GenType 10 Spawn Points
		AddSpawnPoint("d_firetower_61_2.Id5", "d_firetower_61_2", Rectangle(-1012, 664, 300));
		AddSpawnPoint("d_firetower_61_2.Id5", "d_firetower_61_2", Rectangle(-1072, -309, 300));
		AddSpawnPoint("d_firetower_61_2.Id5", "d_firetower_61_2", Rectangle(-1056, -993, 300));
		AddSpawnPoint("d_firetower_61_2.Id5", "d_firetower_61_2", Rectangle(-40, -292, 300));
		AddSpawnPoint("d_firetower_61_2.Id5", "d_firetower_61_2", Rectangle(-57, 507, 300));
		AddSpawnPoint("d_firetower_61_2.Id5", "d_firetower_61_2", Rectangle(737, 843, 300));
		AddSpawnPoint("d_firetower_61_2.Id5", "d_firetower_61_2", Rectangle(1048, -327, 300));
		AddSpawnPoint("d_firetower_61_2.Id5", "d_firetower_61_2", Rectangle(979, -960, 300));
		AddSpawnPoint("d_firetower_61_2.Id5", "d_firetower_61_2", Rectangle(-19, -1491, 300));
		AddSpawnPoint("d_firetower_61_2.Id5", "d_firetower_61_2", Rectangle(-1848, -1009, 300));

		// 'Altarcrystal_R1' GenType 11 Spawn Points
		AddSpawnPoint("d_firetower_61_2.Id6", "d_firetower_61_2", Rectangle(-1005, 569, 300));
		AddSpawnPoint("d_firetower_61_2.Id6", "d_firetower_61_2", Rectangle(-1056, -287, 300));
		AddSpawnPoint("d_firetower_61_2.Id6", "d_firetower_61_2", Rectangle(-1882, -1012, 300));
		AddSpawnPoint("d_firetower_61_2.Id6", "d_firetower_61_2", Rectangle(6, -313, 300));
		AddSpawnPoint("d_firetower_61_2.Id6", "d_firetower_61_2", Rectangle(1043, -326, 300));
		AddSpawnPoint("d_firetower_61_2.Id6", "d_firetower_61_2", Rectangle(-4, 460, 300));
		AddSpawnPoint("d_firetower_61_2.Id6", "d_firetower_61_2", Rectangle(-84, -1530, 300));
		AddSpawnPoint("d_firetower_61_2.Id6", "d_firetower_61_2", Rectangle(993, -1007, 300));
		AddSpawnPoint("d_firetower_61_2.Id6", "d_firetower_61_2", Rectangle(735, 770, 300));

		// 'Altarcrystal_R1' GenType 12 Spawn Points
		AddSpawnPoint("d_firetower_61_2.Id7", "d_firetower_61_2", Rectangle(-906, 644, 300));
		AddSpawnPoint("d_firetower_61_2.Id7", "d_firetower_61_2", Rectangle(-1831, -1013, 300));
		AddSpawnPoint("d_firetower_61_2.Id7", "d_firetower_61_2", Rectangle(-1073, -321, 300));
		AddSpawnPoint("d_firetower_61_2.Id7", "d_firetower_61_2", Rectangle(-25, -283, 300));
		AddSpawnPoint("d_firetower_61_2.Id7", "d_firetower_61_2", Rectangle(1052, -319, 300));

		// 'Rootcrystal_04' GenType 21 Spawn Points
		AddSpawnPoint("d_firetower_61_2.Id8", "d_firetower_61_2", Rectangle(-1873, -1277, 100));
		AddSpawnPoint("d_firetower_61_2.Id8", "d_firetower_61_2", Rectangle(-1889, -892, 100));
		AddSpawnPoint("d_firetower_61_2.Id8", "d_firetower_61_2", Rectangle(-1826, -795, 100));
		AddSpawnPoint("d_firetower_61_2.Id8", "d_firetower_61_2", Rectangle(-1173, -400, 100));
		AddSpawnPoint("d_firetower_61_2.Id8", "d_firetower_61_2", Rectangle(-1074, -210, 100));
		AddSpawnPoint("d_firetower_61_2.Id8", "d_firetower_61_2", Rectangle(-1052, -948, 100));
		AddSpawnPoint("d_firetower_61_2.Id8", "d_firetower_61_2", Rectangle(-197, -262, 100));
		AddSpawnPoint("d_firetower_61_2.Id8", "d_firetower_61_2", Rectangle(76, -293, 100));
		AddSpawnPoint("d_firetower_61_2.Id8", "d_firetower_61_2", Rectangle(-205, -1448, 100));
		AddSpawnPoint("d_firetower_61_2.Id8", "d_firetower_61_2", Rectangle(131, -1497, 100));
		AddSpawnPoint("d_firetower_61_2.Id8", "d_firetower_61_2", Rectangle(934, -1043, 100));
		AddSpawnPoint("d_firetower_61_2.Id8", "d_firetower_61_2", Rectangle(1015, -250, 100));
		AddSpawnPoint("d_firetower_61_2.Id8", "d_firetower_61_2", Rectangle(741, 474, 100));
		AddSpawnPoint("d_firetower_61_2.Id8", "d_firetower_61_2", Rectangle(702, 783, 100));
		AddSpawnPoint("d_firetower_61_2.Id8", "d_firetower_61_2", Rectangle(-144, 435, 100));
		AddSpawnPoint("d_firetower_61_2.Id8", "d_firetower_61_2", Rectangle(-981, 744, 100));
		AddSpawnPoint("d_firetower_61_2.Id8", "d_firetower_61_2", Rectangle(-1099, 540, 100));
		AddSpawnPoint("d_firetower_61_2.Id8", "d_firetower_61_2", Rectangle(-2019, 1533, 100));
		AddSpawnPoint("d_firetower_61_2.Id8", "d_firetower_61_2", Rectangle(-2059, 1090, 100));
		AddSpawnPoint("d_firetower_61_2.Id8", "d_firetower_61_2", Rectangle(1575, -1660, 100));
		AddSpawnPoint("d_firetower_61_2.Id8", "d_firetower_61_2", Rectangle(1795, -1404, 100));

		// 'Colifly_Black' GenType 24 Spawn Points
		AddSpawnPoint("d_firetower_61_2.Id9", "d_firetower_61_2", Rectangle(-1080, -276, 9999));
	}
}
