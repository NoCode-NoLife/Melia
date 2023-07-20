//--- Melia Script -----------------------------------------------------------
// Unknown Sanctuary 1F Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'id_Unknownsanctuary_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class IdUnknownsanctuary1MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("id_Unknownsanctuary_1.Id1", MonsterId.Boss_FD_Durahan, 1, 1, TimeSpan.FromMilliseconds(10000), TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_1.Id2", MonsterId.Boss_FD_NetherBovine, 1, 1, TimeSpan.FromMilliseconds(10000), TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_1.Id3", MonsterId.Boss_FD_Riteris, 1, 1, TimeSpan.FromMilliseconds(10000), TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_1.Id4", MonsterId.Boss_FD_Marionette, 1, 1, TimeSpan.FromMilliseconds(10000), TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_1.Id5", MonsterId.Boss_FD_Succubus, 1, 1, TimeSpan.FromMilliseconds(10000), TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_1.Id6", MonsterId.Boss_FD_Deathweaver, 1, 1, TimeSpan.FromMilliseconds(10000), TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_1.Id7", MonsterId.Boss_FD_SwordBallista, 1, 1, TimeSpan.FromMilliseconds(10000), TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_1.Id8", MonsterId.Boss_FD_Ginklas, 1, 1, TimeSpan.FromMilliseconds(10000), TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_1.Id9", MonsterId.FD_Poncer, 57, 76, TimeSpan.FromMilliseconds(5000), TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_1.Id10", MonsterId.FD_Yishoneer, 42, 56, TimeSpan.FromMilliseconds(5000), TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_1.Id11", MonsterId.FD_Yishontorcher, 22, 29, TimeSpan.FromMilliseconds(5000), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Boss_FD_Durahan' GenType 1 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_1.Id1", "id_Unknownsanctuary_1", Rectangle(536, -107, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id1", "id_Unknownsanctuary_1", Rectangle(-1282, -527, 20));

		// 'Boss_FD_NetherBovine' GenType 2 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_1.Id2", "id_Unknownsanctuary_1", Rectangle(-643, -63, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id2", "id_Unknownsanctuary_1", Rectangle(-358, -587, 20));

		// 'Boss_FD_Riteris' GenType 3 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_1.Id3", "id_Unknownsanctuary_1", Rectangle(-418, -1056, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id3", "id_Unknownsanctuary_1", Rectangle(-197, 929, 20));

		// 'Boss_FD_Marionette' GenType 4 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_1.Id4", "id_Unknownsanctuary_1", Rectangle(-113, 531, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id4", "id_Unknownsanctuary_1", Rectangle(-1604, -71, 20));

		// 'Boss_FD_Succubus' GenType 5 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_1.Id5", "id_Unknownsanctuary_1", Rectangle(-1265, 601, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id5", "id_Unknownsanctuary_1", Rectangle(528, 442, 20));

		// 'Boss_FD_Deathweaver' GenType 6 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_1.Id6", "id_Unknownsanctuary_1", Rectangle(-741, -724, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id6", "id_Unknownsanctuary_1", Rectangle(-786, 946, 20));

		// 'Boss_FD_SwordBallista' GenType 7 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_1.Id7", "id_Unknownsanctuary_1", Rectangle(-1072, 55, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id7", "id_Unknownsanctuary_1", Rectangle(-29, -51, 20));

		// 'Boss_FD_Ginklas' GenType 8 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_1.Id8", "id_Unknownsanctuary_1", Rectangle(-734, 390, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id8", "id_Unknownsanctuary_1", Rectangle(140, -564, 20));

		// 'FD_Poncer' GenType 9 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(444, 557, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(558, 7, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(448, 387, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(628, -89, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(545, 365, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(649, -38, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(615, 461, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(593, 547, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(435, -37, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(611, 321, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(265, -580, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(287, -664, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(187, -699, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(191, -457, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(124, -479, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(70, -447, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(50, -640, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-315, -1025, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-472, -993, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-316, -1109, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-445, -1147, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-785, -836, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-713, -828, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-822, -657, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-846, -773, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-633, -722, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-706, -618, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-382, -714, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-430, -502, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-284, -480, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-214, -541, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-236, -648, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-430, -663, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(6, 20, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(55, -106, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-23, -162, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-142, 589, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-111, 416, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-180, 480, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-41, 503, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-208, 850, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-106, 928, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-110, 968, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-818, 856, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-811, 1059, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-743, 523, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-586, 344, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-698, 513, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-846, 395, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-631, -141, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-694, 61, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-604, 63, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-755, -77, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-568, -221, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-536, -120, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-428, -12, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-1259, -618, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-1386, -537, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-1246, -469, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-1140, -533, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-1171, -445, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-1709, -159, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-1718, -22, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-1663, 36, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-1563, -139, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-1513, -29, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-1634, 79, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-1146, 105, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-1062, 187, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-982, 100, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-1026, 0, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-1113, -37, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-1322, 703, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-1231, 688, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-1192, 653, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Rectangle(-1209, 615, 20));

		// 'FD_Yishoneer' GenType 10 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(469, -159, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(504, -7, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(539, -229, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(113, -489, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(134, -694, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(237, -678, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(266, -505, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-382, -1164, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-478, -1090, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-329, -1066, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-779, -827, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-843, -727, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-796, -661, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-634, -645, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-287, -681, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-352, -506, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(68, -3, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-125, -59, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-81, 2, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-453, -172, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-678, -204, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-727, 2, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-482, 50, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(1, 404, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-239, 463, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-203, 527, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-15, 593, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-140, 868, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-274, 1004, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-161, 1022, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-721, 866, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-895, 891, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-755, 1050, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-682, 969, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-800, 471, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-739, 279, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-562, 400, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-628, 448, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-1301, 519, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-1320, 667, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-1235, 665, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-1129, 580, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-1205, 96, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-1132, 161, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-1634, -185, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-1672, -109, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-1558, 25, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-1508, -93, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-1183, -581, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-1378, -444, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-1304, -433, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-1225, -428, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(-1346, -633, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(505, 557, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(435, 563, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Rectangle(411, 474, 20));

		// 'FD_Yishontorcher' GenType 11 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Rectangle(537, 373, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Rectangle(428, 317, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Rectangle(-167, 411, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Rectangle(-215, 577, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Rectangle(-264, 870, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Rectangle(-218, 1011, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Rectangle(-896, 969, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Rectangle(-699, 1057, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Rectangle(-798, 337, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Rectangle(-635, 325, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Rectangle(-1200, 649, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Rectangle(-1307, 593, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Rectangle(-1745, -88, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Rectangle(-1178, 1, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Rectangle(-1207, -663, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Rectangle(-724, -143, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Rectangle(-537, -42, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Rectangle(-687, -681, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Rectangle(-640, -806, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Rectangle(-421, -549, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Rectangle(-262, -588, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Rectangle(-429, -968, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Rectangle(-355, -999, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Rectangle(55, -565, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Rectangle(50, -482, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Rectangle(-65, -134, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Rectangle(-54, 90, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Rectangle(679, -104, 20));
		AddSpawnPoint("id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Rectangle(612, -219, 20));
	}
}
