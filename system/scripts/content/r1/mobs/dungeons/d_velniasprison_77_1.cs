//--- Melia Script -----------------------------------------------------------
// Tatenye Prison Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_velniasprison_77_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DVelniasprison771MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("d_velniasprison_77_1.Id1", MonsterId.ERD_NightMaiden, min: 15, max: 20, tendency: TendencyType.Aggressive);
		AddSpawner("d_velniasprison_77_1.Id2", MonsterId.ERD_NightMaiden_Mage, min: 15, max: 20, tendency: TendencyType.Aggressive);
		AddSpawner("d_velniasprison_77_1.Id3", MonsterId.ERD_NightMaiden_Bow, min: 15, max: 20, tendency: TendencyType.Aggressive);
		AddSpawner("d_velniasprison_77_1.Id4", MonsterId.ERD_Wizards_Marmotte, min: 15, max: 20, tendency: TendencyType.Aggressive);
		AddSpawner("d_velniasprison_77_1.Id5", MonsterId.ERD_Charog, min: 23, max: 30, tendency: TendencyType.Aggressive);
		AddSpawner("d_velniasprison_77_1.Id6", MonsterId.ERD_Charcoal_Walker, min: 23, max: 30, tendency: TendencyType.Aggressive);
		AddSpawner("d_velniasprison_77_1.Id7", MonsterId.ERD_Harugal, min: 8, max: 10, tendency: TendencyType.Aggressive);
		AddSpawner("d_velniasprison_77_1.Id8", MonsterId.ERD_Tower_Of_Firepuppet_Black, min: 15, max: 20, tendency: TendencyType.Aggressive);
		AddSpawner("d_velniasprison_77_1.Id9", MonsterId.ERD_Hallowventor, min: 15, max: 20, tendency: TendencyType.Aggressive);
		AddSpawner("d_velniasprison_77_1.Id10", MonsterId.ERD_Geppetto, min: 15, max: 20, tendency: TendencyType.Aggressive);
		AddSpawner("d_velniasprison_77_1.Id11", MonsterId.ERD_Shardstatue, min: 23, max: 30, tendency: TendencyType.Aggressive);
		AddSpawner("d_velniasprison_77_1.Id12", MonsterId.ERD_GoblinWarrior_Red, min: 8, max: 10, tendency: TendencyType.Aggressive);
		AddSpawner("d_velniasprison_77_1.Id13", MonsterId.Rootcrystal_05, min: 19, max: 25, respawn: TimeSpan.FromMilliseconds(25000), tendency: TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'ERD_NightMaiden' GenType 2 Spawn Points
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2531, -1027, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2760, -1237, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2660, -1347, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2501, -1300, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2674, -1148, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2584, -1192, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2456, -1200, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2424, -1079, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2729, -1037, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2533, -911, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2905, -505, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2707, -456, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2563, -428, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2471, -522, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2473, -631, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2539, -743, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2490, -836, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2422, -748, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2223, -540, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2297, -468, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2095, -474, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2373, -497, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2119, -524, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2840, -468, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2658, -1278, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2382, -1279, 40));

		// 'ERD_NightMaiden_Mage' GenType 3 Spawn Points
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1624, -1312, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1674, -1203, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1639, -1056, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1580, -1186, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1459, -1327, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1364, -1189, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1358, -1263, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1399, -597, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1460, -1014, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1405, -898, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1414, -781, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1375, -665, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1499, -1058, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1484, -513, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1275, -467, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1353, -546, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1543, -476, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1722, -509, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1878, -436, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1909, -578, 40));

		// 'ERD_NightMaiden_Bow' GenType 4 Spawn Points
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-789, -1034, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-768, -869, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-870, -933, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-570, -831, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-711, -792, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-760, -939, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-669, -976, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-705, -623, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-636, -866, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-570, -926, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-472, -853, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-689, -697, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-691, -477, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-849, -503, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-1422, -486, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-1232, -460, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-1234, -507, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-1033, -521, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-1076, -463, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-772, -465, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-665, -563, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-707, -906, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-825, -1097, 40));

		// 'ERD_Wizards_Marmotte' GenType 5 Spawn Points
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(-279, -509, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(-161, -472, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(-145, -544, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(-27, -431, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(-25, -531, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(4, -632, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(-51, -714, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(111, -471, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(226, -447, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(228, -502, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(361, -459, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(409, -547, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(631, -429, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(601, -492, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(788, -476, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(942, -425, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(961, -485, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(829, -493, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(1189, -453, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(1078, -475, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(1136, -540, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(552, -477, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(412, -625, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(411, -718, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(704, -494, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(227, -896, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(438, -852, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(407, -968, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(506, -1088, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(565, -1021, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(468, -933, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(351, -873, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(542, -837, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(504, -863, 40));

		// 'ERD_Charog' GenType 6 Spawn Points
		AddSpawnPoint("d_velniasprison_77_1.Id5", "d_velniasprison_77_1", Rectangle(920, 368, 9999));

		// 'ERD_Charcoal_Walker' GenType 7 Spawn Points
		AddSpawnPoint("d_velniasprison_77_1.Id6", "d_velniasprison_77_1", Rectangle(431, -3, 9999));

		// 'ERD_Harugal' GenType 8 Spawn Points
		AddSpawnPoint("d_velniasprison_77_1.Id7", "d_velniasprison_77_1", Rectangle(1616, -451, 9999));

		// 'ERD_Tower_Of_Firepuppet_Black' GenType 9 Spawn Points
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1652, -626, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(969, -1075, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(946, -1199, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1144, -1235, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1035, -1314, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(874, -1101, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1205, -961, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1081, -1109, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1288, -1155, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1286, -1237, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1186, -1125, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1055, -990, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1085, -852, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1148, -767, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1132, -680, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1161, -668, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1146, -561, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(961, -1325, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1045, -1406, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1040, -1163, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1405, -527, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1298, -490, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1609, -414, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1533, -452, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1687, -539, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1642, -1157, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1711, -1137, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1675, -1029, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1713, -932, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1693, -754, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1727, -429, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1444, -472, 40));

		// 'ERD_Hallowventor' GenType 10 Spawn Points
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(-184, 24, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(-74, 166, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(3, -47, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(-121, -163, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(51, -213, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(212, -78, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(286, 33, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(-438, -7, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(-671, 11, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(-779, -49, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(-879, 145, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(-317, 71, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(-79, -31, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(62, 217, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(139, -2, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(425, -5, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(531, 102, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(579, -9, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(590, 179, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(727, 2, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(722, 84, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(-36, -142, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(-132, 79, 40));

		// 'ERD_Geppetto' GenType 11 Spawn Points
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(729, 696, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(681, 869, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(700, 1079, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(772, 862, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(901, 894, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(907, 806, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(1124, 810, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(1224, 823, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(1182, 687, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(963, 679, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(913, 583, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(844, 273, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(976, 202, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(821, 127, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(882, 43, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(997, 95, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(628, 217, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(663, 25, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-994, -13, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-828, -59, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-701, 40, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-889, 35, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-943, 193, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-892, 272, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-809, 126, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-557, 24, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-558, -36, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-456, 47, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-899, 413, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-880, 590, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-1163, 704, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-1040, 825, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-1002, 718, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-846, 830, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-852, 690, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-1044, 647, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-745, 662, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-1122, 822, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-819, 926, 40));

		// 'ERD_Shardstatue' GenType 12 Spawn Points
		AddSpawnPoint("d_velniasprison_77_1.Id11", "d_velniasprison_77_1", Rectangle(-885, 659, 9999));

		// 'ERD_GoblinWarrior_Red' GenType 13 Spawn Points
		AddSpawnPoint("d_velniasprison_77_1.Id12", "d_velniasprison_77_1", Rectangle(-930, 637, 9999));

		// 'Rootcrystal_05' GenType 14 Spawn Points
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(186, -449, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(-383, -451, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(-138, 36, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(-1583, -1118, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(-1394, -1027, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(-1412, -670, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(-1817, -497, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(-2264, -445, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(-2928, -515, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(-2562, -1135, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(-2445, -787, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(-2649, -1350, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(-2449, -1350, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(-761, -491, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(1088, -829, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(1168, -502, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(1747, -481, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(1650, -1272, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(2216, -1178, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(2241, -598, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(2690, -525, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(852, 92, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(53, -41, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(-828, 193, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(-706, 962, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(35, 577, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(77, 1061, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(-633, 1445, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(166, 1467, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(312, 1516, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(777, 983, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(-1096, 722, 200));
	}
}
