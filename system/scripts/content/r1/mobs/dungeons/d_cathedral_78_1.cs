//--- Melia Script -----------------------------------------------------------
// Neighport Church East Building Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_cathedral_78_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DCathedral781MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("d_cathedral_78_1.Id1", MonsterId.ERD_Pawndel, min: 12, max: 15, tendency: TendencyType.Aggressive);
		AddSpawner("d_cathedral_78_1.Id2", MonsterId.ERD_Pawnd, min: 19, max: 25, tendency: TendencyType.Aggressive);
		AddSpawner("d_cathedral_78_1.Id3", MonsterId.ERD_Zombiegirl2, min: 12, max: 15, tendency: TendencyType.Aggressive);
		AddSpawner("d_cathedral_78_1.Id4", MonsterId.ERD_Elet, min: 14, max: 18, tendency: TendencyType.Aggressive);
		AddSpawner("d_cathedral_78_1.Id5", MonsterId.ERD_Candlespider, min: 15, max: 20, tendency: TendencyType.Aggressive);
		AddSpawner("d_cathedral_78_1.Id6", MonsterId.ERD_Shredded, min: 14, max: 18, tendency: TendencyType.Aggressive);
		AddSpawner("d_cathedral_78_1.Id7", MonsterId.ERD_Fire_Dragon_Purple, min: 12, max: 15, tendency: TendencyType.Aggressive);
		AddSpawner("d_cathedral_78_1.Id8", MonsterId.ERD_Nuo, min: 9, max: 12, tendency: TendencyType.Aggressive);
		AddSpawner("d_cathedral_78_1.Id9", MonsterId.ERD_InfroRocktor, min: 15, max: 20, tendency: TendencyType.Aggressive);
		AddSpawner("d_cathedral_78_1.Id10", MonsterId.ERD_Egnome, min: 3, max: 4, tendency: TendencyType.Aggressive);
		AddSpawner("d_cathedral_78_1.Id11", MonsterId.ERD_Shtayim, min: 8, max: 10, tendency: TendencyType.Aggressive);
		AddSpawner("d_cathedral_78_1.Id12", MonsterId.ERD_Nuo, min: 6, max: 8, tendency: TendencyType.Aggressive);
		AddSpawner("d_cathedral_78_1.Id13", MonsterId.ERD_Elet, min: 6, max: 8, tendency: TendencyType.Aggressive);
		AddSpawner("d_cathedral_78_1.Id14", MonsterId.ERD_Glizardon, amount: 3, respawn: TimeSpan.FromMilliseconds(1200000), tendency: TendencyType.Aggressive);
		AddSpawner("d_cathedral_78_1.Id15", MonsterId.ERD_Galok, amount: 3, respawn: TimeSpan.FromMilliseconds(1200000), tendency: TendencyType.Aggressive);
		AddSpawner("d_cathedral_78_1.Id16", MonsterId.ERD_Malstatue, min: 30, max: 40, tendency: TendencyType.Aggressive);
		AddSpawner("d_cathedral_78_1.Id17", MonsterId.ERD_Malstatue, min: 11, max: 14, tendency: TendencyType.Aggressive);
		AddSpawner("d_cathedral_78_1.Id18", MonsterId.Rootcrystal_03, min: 19, max: 25, respawn: TimeSpan.FromMilliseconds(20000), tendency: TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'ERD_Pawndel' GenType 2 Spawn Points
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(749, 209, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(854, 139, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(931, 162, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(830, 281, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(869, 381, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(969, 388, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(972, 234, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(798, 648, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(804, 785, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(729, 738, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(864, 690, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(856, 828, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(850, 894, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(963, 823, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(890, 550, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(986, 617, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(1172, 766, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(1292, 846, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(1443, 877, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(1458, 774, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(1390, 709, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(1381, 612, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(1489, 643, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(1112, 725, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(1287, 701, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(1274, 629, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(857, 471, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(766, 365, 40));

		// 'ERD_Pawnd' GenType 3 Spawn Points
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(427, 787, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(387, 878, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(305, 826, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(311, 620, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(119, 608, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(138, 834, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(138, 926, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(329, 903, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(230, 806, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(200, 726, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(397, 612, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(-1, 867, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(-116, 693, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(-49, 629, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(-165, 624, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(-334, 629, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(-267, 766, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(-287, 928, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(-380, 690, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(-423, 607, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(-583, 616, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(-567, 741, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(-501, 940, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(-530, 845, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(-392, 846, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(-49, 507, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(616, -304, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(713, -320, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(669, -428, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(850, -418, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(858, -256, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(1022, -230, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(1089, -314, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(1032, -412, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(967, -333, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(597, -690, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(674, -757, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(703, -617, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(845, -647, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(875, -745, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(955, -619, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(848, -521, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(1078, -578, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(1028, -775, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(1009, -494, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(579, -527, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(581, -420, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(1030, -695, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(807, -154, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(897, -141, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(-123, 790, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(-79, 879, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(-39, 363, 40));

		// 'ERD_Zombiegirl2' GenType 4 Spawn Points
		AddSpawnPoint("d_cathedral_78_1.Id3", "d_cathedral_78_1", Rectangle(-269, 120, 40));
		AddSpawnPoint("d_cathedral_78_1.Id3", "d_cathedral_78_1", Rectangle(-173, 271, 40));
		AddSpawnPoint("d_cathedral_78_1.Id3", "d_cathedral_78_1", Rectangle(-151, 161, 40));
		AddSpawnPoint("d_cathedral_78_1.Id3", "d_cathedral_78_1", Rectangle(-293, 17, 40));
		AddSpawnPoint("d_cathedral_78_1.Id3", "d_cathedral_78_1", Rectangle(-114, -680, 40));
		AddSpawnPoint("d_cathedral_78_1.Id3", "d_cathedral_78_1", Rectangle(-179, -116, 40));
		AddSpawnPoint("d_cathedral_78_1.Id3", "d_cathedral_78_1", Rectangle(-18, -165, 40));
		AddSpawnPoint("d_cathedral_78_1.Id3", "d_cathedral_78_1", Rectangle(47, -97, 40));
		AddSpawnPoint("d_cathedral_78_1.Id3", "d_cathedral_78_1", Rectangle(-50, 200, 40));
		AddSpawnPoint("d_cathedral_78_1.Id3", "d_cathedral_78_1", Rectangle(130, 237, 40));
		AddSpawnPoint("d_cathedral_78_1.Id3", "d_cathedral_78_1", Rectangle(141, 92, 40));
		AddSpawnPoint("d_cathedral_78_1.Id3", "d_cathedral_78_1", Rectangle(197, -148, 40));
		AddSpawnPoint("d_cathedral_78_1.Id3", "d_cathedral_78_1", Rectangle(76, -270, 40));
		AddSpawnPoint("d_cathedral_78_1.Id3", "d_cathedral_78_1", Rectangle(143, -86, 40));
		AddSpawnPoint("d_cathedral_78_1.Id3", "d_cathedral_78_1", Rectangle(120, -190, 40));

		// 'ERD_Elet' GenType 5 Spawn Points
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(-165, -800, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(-49, -807, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(-148, -708, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(-169, -604, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(-135, -539, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(-73, -696, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(29, -553, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(12, -695, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(61, -790, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(-386, -1190, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(-428, -1421, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(-270, -1324, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(-239, -1197, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(-112, -1233, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(-377, -1296, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(-42, -1426, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(60, -1313, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(48, -1110, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(187, -1258, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(217, -1401, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(276, -1285, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(268, -1128, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(405, -1138, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(369, -1313, 40));

		// 'ERD_Candlespider' GenType 6 Spawn Points
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(-435, -1320, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(-488, -1183, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(-315, -1223, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(-188, -1408, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(-164, -1314, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(-20, -1154, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(-15, -1230, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(84, -1231, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(78, -1383, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(211, -1338, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(185, -1182, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(311, -1219, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(431, -1199, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(386, -1416, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(-219, -1136, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(-73, -1294, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(-149, -747, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(-77, -595, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(-16, -664, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(7, -780, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(52, -611, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(622, -1247, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(781, -1283, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(841, -1144, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(861, -1238, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(567, -1321, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(836, -1005, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(-517, -1262, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(-548, -1425, 40));

		// 'ERD_Shredded' GenType 7 Spawn Points
		AddSpawnPoint("d_cathedral_78_1.Id6", "d_cathedral_78_1", Rectangle(-1294, -747, 40));
		AddSpawnPoint("d_cathedral_78_1.Id6", "d_cathedral_78_1", Rectangle(-1059, -713, 40));
		AddSpawnPoint("d_cathedral_78_1.Id6", "d_cathedral_78_1", Rectangle(-1021, -610, 40));
		AddSpawnPoint("d_cathedral_78_1.Id6", "d_cathedral_78_1", Rectangle(-1308, -399, 40));
		AddSpawnPoint("d_cathedral_78_1.Id6", "d_cathedral_78_1", Rectangle(-1218, -287, 40));
		AddSpawnPoint("d_cathedral_78_1.Id6", "d_cathedral_78_1", Rectangle(-1100, -372, 40));
		AddSpawnPoint("d_cathedral_78_1.Id6", "d_cathedral_78_1", Rectangle(-1020, -305, 40));
		AddSpawnPoint("d_cathedral_78_1.Id6", "d_cathedral_78_1", Rectangle(-972, -522, 40));
		AddSpawnPoint("d_cathedral_78_1.Id6", "d_cathedral_78_1", Rectangle(-923, -649, 40));
		AddSpawnPoint("d_cathedral_78_1.Id6", "d_cathedral_78_1", Rectangle(-1106, -485, 40));
		AddSpawnPoint("d_cathedral_78_1.Id6", "d_cathedral_78_1", Rectangle(-801, -511, 40));
		AddSpawnPoint("d_cathedral_78_1.Id6", "d_cathedral_78_1", Rectangle(-916, -495, 40));
		AddSpawnPoint("d_cathedral_78_1.Id6", "d_cathedral_78_1", Rectangle(-859, -304, 40));
		AddSpawnPoint("d_cathedral_78_1.Id6", "d_cathedral_78_1", Rectangle(-1290, -615, 40));
		AddSpawnPoint("d_cathedral_78_1.Id6", "d_cathedral_78_1", Rectangle(-1090, -786, 40));
		AddSpawnPoint("d_cathedral_78_1.Id6", "d_cathedral_78_1", Rectangle(-1181, -663, 40));
		AddSpawnPoint("d_cathedral_78_1.Id6", "d_cathedral_78_1", Rectangle(-929, -752, 40));
		AddSpawnPoint("d_cathedral_78_1.Id6", "d_cathedral_78_1", Rectangle(-829, -637, 40));

		// 'ERD_Fire_Dragon_Purple' GenType 8 Spawn Points
		AddSpawnPoint("d_cathedral_78_1.Id7", "d_cathedral_78_1", Rectangle(-975, 97, 40));
		AddSpawnPoint("d_cathedral_78_1.Id7", "d_cathedral_78_1", Rectangle(-876, 136, 40));
		AddSpawnPoint("d_cathedral_78_1.Id7", "d_cathedral_78_1", Rectangle(-987, 210, 40));
		AddSpawnPoint("d_cathedral_78_1.Id7", "d_cathedral_78_1", Rectangle(-905, 327, 40));
		AddSpawnPoint("d_cathedral_78_1.Id7", "d_cathedral_78_1", Rectangle(-893, 214, 40));
		AddSpawnPoint("d_cathedral_78_1.Id7", "d_cathedral_78_1", Rectangle(-818, 95, 40));
		AddSpawnPoint("d_cathedral_78_1.Id7", "d_cathedral_78_1", Rectangle(-786, 187, 40));
		AddSpawnPoint("d_cathedral_78_1.Id7", "d_cathedral_78_1", Rectangle(-1138, 200, 40));
		AddSpawnPoint("d_cathedral_78_1.Id7", "d_cathedral_78_1", Rectangle(-1344, 81, 40));
		AddSpawnPoint("d_cathedral_78_1.Id7", "d_cathedral_78_1", Rectangle(-1496, 98, 40));
		AddSpawnPoint("d_cathedral_78_1.Id7", "d_cathedral_78_1", Rectangle(-1507, 314, 40));
		AddSpawnPoint("d_cathedral_78_1.Id7", "d_cathedral_78_1", Rectangle(-1271, 325, 40));
		AddSpawnPoint("d_cathedral_78_1.Id7", "d_cathedral_78_1", Rectangle(-1409, 155, 40));

		// 'ERD_Nuo' GenType 9 Spawn Points
		AddSpawnPoint("d_cathedral_78_1.Id8", "d_cathedral_78_1", Rectangle(-1516, 199, 40));
		AddSpawnPoint("d_cathedral_78_1.Id8", "d_cathedral_78_1", Rectangle(-1431, 73, 40));
		AddSpawnPoint("d_cathedral_78_1.Id8", "d_cathedral_78_1", Rectangle(-1385, 229, 40));
		AddSpawnPoint("d_cathedral_78_1.Id8", "d_cathedral_78_1", Rectangle(-1422, 336, 40));
		AddSpawnPoint("d_cathedral_78_1.Id8", "d_cathedral_78_1", Rectangle(-1326, 310, 40));
		AddSpawnPoint("d_cathedral_78_1.Id8", "d_cathedral_78_1", Rectangle(-1287, 144, 40));
		AddSpawnPoint("d_cathedral_78_1.Id8", "d_cathedral_78_1", Rectangle(-1222, 171, 40));
		AddSpawnPoint("d_cathedral_78_1.Id8", "d_cathedral_78_1", Rectangle(-1212, 228, 40));
		AddSpawnPoint("d_cathedral_78_1.Id8", "d_cathedral_78_1", Rectangle(-980, 151, 40));
		AddSpawnPoint("d_cathedral_78_1.Id8", "d_cathedral_78_1", Rectangle(-903, 72, 40));
		AddSpawnPoint("d_cathedral_78_1.Id8", "d_cathedral_78_1", Rectangle(-840, 272, 40));
		AddSpawnPoint("d_cathedral_78_1.Id8", "d_cathedral_78_1", Rectangle(-966, 275, 40));
		AddSpawnPoint("d_cathedral_78_1.Id8", "d_cathedral_78_1", Rectangle(-794, 278, 40));
		AddSpawnPoint("d_cathedral_78_1.Id8", "d_cathedral_78_1", Rectangle(-1036, 319, 40));
		AddSpawnPoint("d_cathedral_78_1.Id8", "d_cathedral_78_1", Rectangle(-1060, 814, 40));
		AddSpawnPoint("d_cathedral_78_1.Id8", "d_cathedral_78_1", Rectangle(-1429, 596, 40));
		AddSpawnPoint("d_cathedral_78_1.Id8", "d_cathedral_78_1", Rectangle(-1038, 681, 40));

		// 'ERD_InfroRocktor' GenType 10 Spawn Points
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(-169, -23, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(-288, -153, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(-26, -260, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(5, -105, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(-203, 175, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(110, 165, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(-66, 418, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(-26, 480, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(-531, 655, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(-395, 755, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(-404, 905, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(-287, 697, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(-54, 676, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(-65, 746, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(80, 756, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(56, 636, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(142, 699, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(215, 886, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(264, 699, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(205, 611, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(365, 714, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(388, 804, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(89, -7, 40));

		// 'ERD_Egnome' GenType 11 Spawn Points
		AddSpawnPoint("d_cathedral_78_1.Id10", "d_cathedral_78_1", Rectangle(711, -547, 40));
		AddSpawnPoint("d_cathedral_78_1.Id10", "d_cathedral_78_1", Rectangle(796, -723, 40));
		AddSpawnPoint("d_cathedral_78_1.Id10", "d_cathedral_78_1", Rectangle(1076, -515, 40));
		AddSpawnPoint("d_cathedral_78_1.Id10", "d_cathedral_78_1", Rectangle(871, -356, 40));
		AddSpawnPoint("d_cathedral_78_1.Id10", "d_cathedral_78_1", Rectangle(862, 187, 40));
		AddSpawnPoint("d_cathedral_78_1.Id10", "d_cathedral_78_1", Rectangle(738, 322, 40));
		AddSpawnPoint("d_cathedral_78_1.Id10", "d_cathedral_78_1", Rectangle(928, 289, 40));
		AddSpawnPoint("d_cathedral_78_1.Id10", "d_cathedral_78_1", Rectangle(861, -17, 40));
		AddSpawnPoint("d_cathedral_78_1.Id10", "d_cathedral_78_1", Rectangle(953, -717, 40));
		AddSpawnPoint("d_cathedral_78_1.Id10", "d_cathedral_78_1", Rectangle(939, -535, 40));
		AddSpawnPoint("d_cathedral_78_1.Id10", "d_cathedral_78_1", Rectangle(687, -363, 40));

		// 'ERD_Shtayim' GenType 12 Spawn Points
		AddSpawnPoint("d_cathedral_78_1.Id11", "d_cathedral_78_1", Rectangle(-1288, -375, 40));
		AddSpawnPoint("d_cathedral_78_1.Id11", "d_cathedral_78_1", Rectangle(-1130, -442, 40));
		AddSpawnPoint("d_cathedral_78_1.Id11", "d_cathedral_78_1", Rectangle(-1274, -613, 40));
		AddSpawnPoint("d_cathedral_78_1.Id11", "d_cathedral_78_1", Rectangle(-1311, -768, 40));
		AddSpawnPoint("d_cathedral_78_1.Id11", "d_cathedral_78_1", Rectangle(-1042, -706, 40));
		AddSpawnPoint("d_cathedral_78_1.Id11", "d_cathedral_78_1", Rectangle(-924, -780, 40));
		AddSpawnPoint("d_cathedral_78_1.Id11", "d_cathedral_78_1", Rectangle(-853, -630, 40));
		AddSpawnPoint("d_cathedral_78_1.Id11", "d_cathedral_78_1", Rectangle(-875, -459, 40));
		AddSpawnPoint("d_cathedral_78_1.Id11", "d_cathedral_78_1", Rectangle(-758, -389, 40));
		AddSpawnPoint("d_cathedral_78_1.Id11", "d_cathedral_78_1", Rectangle(-1078, -273, 40));
		AddSpawnPoint("d_cathedral_78_1.Id11", "d_cathedral_78_1", Rectangle(-911, -183, 40));
		AddSpawnPoint("d_cathedral_78_1.Id11", "d_cathedral_78_1", Rectangle(-890, 1, 40));
		AddSpawnPoint("d_cathedral_78_1.Id11", "d_cathedral_78_1", Rectangle(-1298, 195, 40));
		AddSpawnPoint("d_cathedral_78_1.Id11", "d_cathedral_78_1", Rectangle(-1536, 153, 40));
		AddSpawnPoint("d_cathedral_78_1.Id11", "d_cathedral_78_1", Rectangle(-881, 324, 40));
		AddSpawnPoint("d_cathedral_78_1.Id11", "d_cathedral_78_1", Rectangle(-868, 134, 40));

		// 'ERD_Nuo' GenType 13 Spawn Points
		AddSpawnPoint("d_cathedral_78_1.Id12", "d_cathedral_78_1", Rectangle(-1198, 787, 40));
		AddSpawnPoint("d_cathedral_78_1.Id12", "d_cathedral_78_1", Rectangle(-944, 692, 40));
		AddSpawnPoint("d_cathedral_78_1.Id12", "d_cathedral_78_1", Rectangle(-1409, 729, 40));
		AddSpawnPoint("d_cathedral_78_1.Id12", "d_cathedral_78_1", Rectangle(-952, 783, 40));
		AddSpawnPoint("d_cathedral_78_1.Id12", "d_cathedral_78_1", Rectangle(-1351, 809, 40));
		AddSpawnPoint("d_cathedral_78_1.Id12", "d_cathedral_78_1", Rectangle(-875, 909, 40));
		AddSpawnPoint("d_cathedral_78_1.Id12", "d_cathedral_78_1", Rectangle(-1029, 902, 40));
		AddSpawnPoint("d_cathedral_78_1.Id12", "d_cathedral_78_1", Rectangle(-885, 683, 40));

		// 'ERD_Elet' GenType 14 Spawn Points
		AddSpawnPoint("d_cathedral_78_1.Id13", "d_cathedral_78_1", Rectangle(-1064, 751, 40));
		AddSpawnPoint("d_cathedral_78_1.Id13", "d_cathedral_78_1", Rectangle(-979, 674, 40));
		AddSpawnPoint("d_cathedral_78_1.Id13", "d_cathedral_78_1", Rectangle(-918, 856, 40));
		AddSpawnPoint("d_cathedral_78_1.Id13", "d_cathedral_78_1", Rectangle(-1061, 909, 40));
		AddSpawnPoint("d_cathedral_78_1.Id13", "d_cathedral_78_1", Rectangle(-903, 722, 40));
		AddSpawnPoint("d_cathedral_78_1.Id13", "d_cathedral_78_1", Rectangle(-1181, 824, 40));
		AddSpawnPoint("d_cathedral_78_1.Id13", "d_cathedral_78_1", Rectangle(-1306, 758, 40));
		AddSpawnPoint("d_cathedral_78_1.Id13", "d_cathedral_78_1", Rectangle(-1403, 784, 40));
		AddSpawnPoint("d_cathedral_78_1.Id13", "d_cathedral_78_1", Rectangle(-1381, 644, 40));

		// 'ERD_Glizardon' GenType 15 Spawn Points
		AddSpawnPoint("d_cathedral_78_1.Id14", "d_cathedral_78_1", Rectangle(840, -405, 1200));

		// 'ERD_Galok' GenType 16 Spawn Points
		AddSpawnPoint("d_cathedral_78_1.Id15", "d_cathedral_78_1", Rectangle(-1045, -385, 1500));

		// 'ERD_Malstatue' GenType 18 Spawn Points
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(872, 91, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(805, 78, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(900, -209, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(788, -213, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(902, -798, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(791, -793, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(567, -502, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(1145, -558, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(1137, -460, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(107, -1398, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(101, -1139, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(270, -1144, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(269, -1405, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(-226, -1137, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(-219, -1405, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(-401, -1403, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(-400, -1137, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(-105, -721, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(4, -630, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(765, -565, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(938, -423, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(767, -414, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(941, -570, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(49, -73, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(-115, -60, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(-124, 77, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(46, 79, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(-294, -225, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(-260, 211, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(83, 208, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(102, -245, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(-119, -180, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(-273, 873, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(125, 866, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(383, 610, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(-1028, 731, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(-912, 833, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(-1019, 834, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(-918, 736, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(-526, 608, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(-1358, -441, 20));

		// 'ERD_Malstatue' GenType 19 Spawn Points
		AddSpawnPoint("d_cathedral_78_1.Id17", "d_cathedral_78_1", Rectangle(-785, 309, 20));
		AddSpawnPoint("d_cathedral_78_1.Id17", "d_cathedral_78_1", Rectangle(-786, 74, 20));
		AddSpawnPoint("d_cathedral_78_1.Id17", "d_cathedral_78_1", Rectangle(-993, 76, 20));
		AddSpawnPoint("d_cathedral_78_1.Id17", "d_cathedral_78_1", Rectangle(-995, 312, 20));
		AddSpawnPoint("d_cathedral_78_1.Id17", "d_cathedral_78_1", Rectangle(-1444, 152, 20));
		AddSpawnPoint("d_cathedral_78_1.Id17", "d_cathedral_78_1", Rectangle(-1444, 233, 20));
		AddSpawnPoint("d_cathedral_78_1.Id17", "d_cathedral_78_1", Rectangle(-1355, 233, 20));
		AddSpawnPoint("d_cathedral_78_1.Id17", "d_cathedral_78_1", Rectangle(-1354, 152, 20));
		AddSpawnPoint("d_cathedral_78_1.Id17", "d_cathedral_78_1", Rectangle(-946, -313, 20));
		AddSpawnPoint("d_cathedral_78_1.Id17", "d_cathedral_78_1", Rectangle(-1299, -324, 20));
		AddSpawnPoint("d_cathedral_78_1.Id17", "d_cathedral_78_1", Rectangle(-1152, -697, 20));
		AddSpawnPoint("d_cathedral_78_1.Id17", "d_cathedral_78_1", Rectangle(-831, -748, 20));
		AddSpawnPoint("d_cathedral_78_1.Id17", "d_cathedral_78_1", Rectangle(-1347, -553, 20));
		AddSpawnPoint("d_cathedral_78_1.Id17", "d_cathedral_78_1", Rectangle(-1345, -457, 20));

		// 'Rootcrystal_03' GenType 21 Spawn Points
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(1365, 741, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(863, -403, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(873, -744, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(892, 37, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(835, 753, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(159, 618, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(-292, 697, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(-868, 629, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(-1503, 85, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(-865, -26, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(-977, -671, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(-1253, -542, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(-1088, -988, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(-892, -1245, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(-36, -1288, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(-65, -940, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(-72, -716, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(642, -1281, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(-55, -105, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(-3, 230, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(-1044, 205, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(-1371, 732, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(304, 872, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(-511, 763, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(1235, 261, 200));
	}
}
