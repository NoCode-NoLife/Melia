//--- Melia Script -----------------------------------------------------------
// Michmas Temple Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_catacomb_80_3'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DCatacomb803MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("d_catacomb_80_3.Id1", MonsterId.ERD_Cronewt_Blue, min: 11, max: 14, tendency: TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_3.Id2", MonsterId.ERD_Infroholder_Red, min: 11, max: 14, tendency: TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_3.Id3", MonsterId.ERD_Cronewt_Bow_Blue, min: 11, max: 14, tendency: TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_3.Id4", MonsterId.ERD_Cronewt_Mage_Blue, min: 11, max: 14, tendency: TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_3.Id5", MonsterId.ERD_Hohen_Gulak, min: 5, max: 6, tendency: TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_3.Id6", MonsterId.ERD_Socket_Green, min: 11, max: 14, tendency: TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_3.Id7", MonsterId.ERD_Socket_Mage_Green, min: 11, max: 14, tendency: TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_3.Id8", MonsterId.ERD_Siaulav_Bow_Blue, min: 14, max: 18, tendency: TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_3.Id9", MonsterId.ERD_Siaulav_Blue, min: 14, max: 18, tendency: TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_3.Id10", MonsterId.ERD_Siaulav_Mage_Blue, min: 14, max: 18, tendency: TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_3.Id11", MonsterId.ERD_Nuka, min: 18, max: 24, tendency: TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_3.Id12", MonsterId.ERD_Elma, min: 18, max: 24, tendency: TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_3.Id13", MonsterId.Rootcrystal_05, min: 23, max: 30, respawn: TimeSpan.FromMilliseconds(20000), tendency: TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'ERD_Cronewt_Blue' GenType 8 Spawn Points
		AddSpawnPoint("d_catacomb_80_3.Id1", "d_catacomb_80_3", Rectangle(-699, -2544, 25));
		AddSpawnPoint("d_catacomb_80_3.Id1", "d_catacomb_80_3", Rectangle(-597, -2690, 25));
		AddSpawnPoint("d_catacomb_80_3.Id1", "d_catacomb_80_3", Rectangle(-566, -2383, 25));
		AddSpawnPoint("d_catacomb_80_3.Id1", "d_catacomb_80_3", Rectangle(-431, -2345, 25));
		AddSpawnPoint("d_catacomb_80_3.Id1", "d_catacomb_80_3", Rectangle(-284, -2301, 25));
		AddSpawnPoint("d_catacomb_80_3.Id1", "d_catacomb_80_3", Rectangle(-198, -2136, 25));
		AddSpawnPoint("d_catacomb_80_3.Id1", "d_catacomb_80_3", Rectangle(-158, -1751, 25));
		AddSpawnPoint("d_catacomb_80_3.Id1", "d_catacomb_80_3", Rectangle(-24, -2072, 25));
		AddSpawnPoint("d_catacomb_80_3.Id1", "d_catacomb_80_3", Rectangle(155, -2085, 25));
		AddSpawnPoint("d_catacomb_80_3.Id1", "d_catacomb_80_3", Rectangle(190, -1821, 25));
		AddSpawnPoint("d_catacomb_80_3.Id1", "d_catacomb_80_3", Rectangle(270, -1705, 25));
		AddSpawnPoint("d_catacomb_80_3.Id1", "d_catacomb_80_3", Rectangle(4, -1592, 25));
		AddSpawnPoint("d_catacomb_80_3.Id1", "d_catacomb_80_3", Rectangle(-162, -1172, 25));
		AddSpawnPoint("d_catacomb_80_3.Id1", "d_catacomb_80_3", Rectangle(144, -1116, 25));
		AddSpawnPoint("d_catacomb_80_3.Id1", "d_catacomb_80_3", Rectangle(-131, -963, 25));
		AddSpawnPoint("d_catacomb_80_3.Id1", "d_catacomb_80_3", Rectangle(171, -980, 25));
		AddSpawnPoint("d_catacomb_80_3.Id1", "d_catacomb_80_3", Rectangle(-478, -2606, 25));
		AddSpawnPoint("d_catacomb_80_3.Id1", "d_catacomb_80_3", Rectangle(-124, -1863, 25));
		AddSpawnPoint("d_catacomb_80_3.Id1", "d_catacomb_80_3", Rectangle(-120, -790, 25));

		// 'ERD_Infroholder_Red' GenType 9 Spawn Points
		AddSpawnPoint("d_catacomb_80_3.Id2", "d_catacomb_80_3", Rectangle(-534, -2511, 25));
		AddSpawnPoint("d_catacomb_80_3.Id2", "d_catacomb_80_3", Rectangle(-644, -2613, 25));
		AddSpawnPoint("d_catacomb_80_3.Id2", "d_catacomb_80_3", Rectangle(-353, -2260, 25));
		AddSpawnPoint("d_catacomb_80_3.Id2", "d_catacomb_80_3", Rectangle(22, -1769, 25));
		AddSpawnPoint("d_catacomb_80_3.Id2", "d_catacomb_80_3", Rectangle(121, -1972, 25));
		AddSpawnPoint("d_catacomb_80_3.Id2", "d_catacomb_80_3", Rectangle(-98, -1968, 25));
		AddSpawnPoint("d_catacomb_80_3.Id2", "d_catacomb_80_3", Rectangle(70, -2099, 25));
		AddSpawnPoint("d_catacomb_80_3.Id2", "d_catacomb_80_3", Rectangle(213, -1909, 25));
		AddSpawnPoint("d_catacomb_80_3.Id2", "d_catacomb_80_3", Rectangle(-4, -1331, 25));
		AddSpawnPoint("d_catacomb_80_3.Id2", "d_catacomb_80_3", Rectangle(-239, -1037, 25));
		AddSpawnPoint("d_catacomb_80_3.Id2", "d_catacomb_80_3", Rectangle(148, -740, 25));
		AddSpawnPoint("d_catacomb_80_3.Id2", "d_catacomb_80_3", Rectangle(-206, -812, 25));
		AddSpawnPoint("d_catacomb_80_3.Id2", "d_catacomb_80_3", Rectangle(29, -1131, 25));
		AddSpawnPoint("d_catacomb_80_3.Id2", "d_catacomb_80_3", Rectangle(264, -1101, 25));
		AddSpawnPoint("d_catacomb_80_3.Id2", "d_catacomb_80_3", Rectangle(137, -840, 25));
		AddSpawnPoint("d_catacomb_80_3.Id2", "d_catacomb_80_3", Rectangle(771, -907, 25));
		AddSpawnPoint("d_catacomb_80_3.Id2", "d_catacomb_80_3", Rectangle(-691, -959, 25));

		// 'ERD_Cronewt_Bow_Blue' GenType 10 Spawn Points
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(-718, -1151, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(-815, -998, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(-836, -808, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(-707, -733, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(-930, -1169, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(-1013, -1000, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(-1033, -821, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(-938, -716, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(812, -1162, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(943, -1061, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(988, -829, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(867, -700, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(1171, -700, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(1223, -862, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(1221, -1025, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(1119, -1112, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(58, -757, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(-242, -906, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(-63, -1108, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(98, -1028, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(303, -793, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(319, -970, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(-1121, -938, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(1114, -963, 25));

		// 'ERD_Cronewt_Mage_Blue' GenType 11 Spawn Points
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(-1268, -190, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(-1273, 106, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(-877, -235, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(-847, 70, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(-1068, -259, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(-1067, 118, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(909, -217, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(1065, -205, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(1227, -199, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(941, 86, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(1085, 94, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(1221, 79, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(1370, -1157, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(1463, -1130, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(1305, -752, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(1401, -692, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(-1413, -1179, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(-1286, -1139, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(-1440, -740, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(-1308, -776, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(-77, -704, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(104, -650, 25));

		// 'ERD_Hohen_Gulak' GenType 12 Spawn Points
		AddSpawnPoint("d_catacomb_80_3.Id5", "d_catacomb_80_3", Rectangle(19, -934, 40));
		AddSpawnPoint("d_catacomb_80_3.Id5", "d_catacomb_80_3", Rectangle(-1338, -978, 40));
		AddSpawnPoint("d_catacomb_80_3.Id5", "d_catacomb_80_3", Rectangle(1465, -907, 40));
		AddSpawnPoint("d_catacomb_80_3.Id5", "d_catacomb_80_3", Rectangle(794, 965, 40));
		AddSpawnPoint("d_catacomb_80_3.Id5", "d_catacomb_80_3", Rectangle(-694, 952, 40));
		AddSpawnPoint("d_catacomb_80_3.Id5", "d_catacomb_80_3", Rectangle(34, 2330, 40));
		AddSpawnPoint("d_catacomb_80_3.Id5", "d_catacomb_80_3", Rectangle(46, -1990, 40));
		AddSpawnPoint("d_catacomb_80_3.Id5", "d_catacomb_80_3", Rectangle(1436, 1030, 40));
		AddSpawnPoint("d_catacomb_80_3.Id5", "d_catacomb_80_3", Rectangle(99, 822, 40));
		AddSpawnPoint("d_catacomb_80_3.Id5", "d_catacomb_80_3", Rectangle(-1416, 938, 40));

		// 'ERD_Socket_Green' GenType 13 Spawn Points
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(-1132, -762, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(-1119, -1114, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(1345, -1064, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(1199, -793, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(905, -42, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(1002, -138, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(1167, -20, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(1237, -97, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(-1260, 13, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(-1128, -125, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(-1016, -28, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(-918, -148, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(-925, 466, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(-1211, 486, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(-1430, 669, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(-1292, 748, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(-1068, 629, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(970, 342, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(874, 644, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(985, 736, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(1148, 699, 25));

		// 'ERD_Socket_Mage_Green' GenType 14 Spawn Points
		AddSpawnPoint("d_catacomb_80_3.Id7", "d_catacomb_80_3", Rectangle(-749, 686, 25));
		AddSpawnPoint("d_catacomb_80_3.Id7", "d_catacomb_80_3", Rectangle(-888, 842, 25));
		AddSpawnPoint("d_catacomb_80_3.Id7", "d_catacomb_80_3", Rectangle(-910, 1089, 25));
		AddSpawnPoint("d_catacomb_80_3.Id7", "d_catacomb_80_3", Rectangle(-774, 1187, 25));
		AddSpawnPoint("d_catacomb_80_3.Id7", "d_catacomb_80_3", Rectangle(1412, 751, 25));
		AddSpawnPoint("d_catacomb_80_3.Id7", "d_catacomb_80_3", Rectangle(1257, 940, 25));
		AddSpawnPoint("d_catacomb_80_3.Id7", "d_catacomb_80_3", Rectangle(1293, 1090, 25));
		AddSpawnPoint("d_catacomb_80_3.Id7", "d_catacomb_80_3", Rectangle(1433, 1180, 25));
		AddSpawnPoint("d_catacomb_80_3.Id7", "d_catacomb_80_3", Rectangle(935, 1142, 25));
		AddSpawnPoint("d_catacomb_80_3.Id7", "d_catacomb_80_3", Rectangle(1138, 1132, 25));
		AddSpawnPoint("d_catacomb_80_3.Id7", "d_catacomb_80_3", Rectangle(-1298, 1133, 25));
		AddSpawnPoint("d_catacomb_80_3.Id7", "d_catacomb_80_3", Rectangle(-1147, 1130, 25));
		AddSpawnPoint("d_catacomb_80_3.Id7", "d_catacomb_80_3", Rectangle(-1020, -125, 25));
		AddSpawnPoint("d_catacomb_80_3.Id7", "d_catacomb_80_3", Rectangle(-928, 28, 25));
		AddSpawnPoint("d_catacomb_80_3.Id7", "d_catacomb_80_3", Rectangle(-1153, 124, 25));
		AddSpawnPoint("d_catacomb_80_3.Id7", "d_catacomb_80_3", Rectangle(1025, 25, 25));
		AddSpawnPoint("d_catacomb_80_3.Id7", "d_catacomb_80_3", Rectangle(1153, -162, 25));
		AddSpawnPoint("d_catacomb_80_3.Id7", "d_catacomb_80_3", Rectangle(1090, -338, 25));

		// 'ERD_Siaulav_Bow_Blue' GenType 15 Spawn Points
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(1315, 682, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(1208, 797, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(1047, 866, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(791, 708, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(910, 798, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(-1299, 643, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(-1172, 810, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(-1032, 728, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(-909, 611, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(-829, 752, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(-281, 791, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(-244, 1096, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(-156, 825, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(-145, 1012, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(319, 1071, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(327, 817, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(240, 1071, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(214, 808, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(-79, 1271, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(100, 1243, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(-1267, -93, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(-901, -70, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(921, -128, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(1273, -13, 30));

		// 'ERD_Siaulav_Blue' GenType 16 Spawn Points
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(-1249, 943, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(-1013, 914, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(1074, 974, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(1245, 1016, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(-134, 668, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(-1, 599, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(116, 619, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(178, 675, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(-103, 1126, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(72, 1116, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(185, 1015, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(89, 755, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(-117, 1661, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(0, 1733, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(112, 1719, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(227, 1671, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(81, 963, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(341, 927, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(-312, 952, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(-891, -867, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(-878, -1046, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(-1172, -834, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(-1177, -1051, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(1038, -1016, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(1066, -798, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(1288, -1139, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(1279, -961, 30));

		// 'ERD_Siaulav_Mage_Blue' GenType 17 Spawn Points
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(-211, 1723, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(-131, 1860, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(25, 1883, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(178, 1836, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(263, 1752, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(-197, 2345, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(-73, 2202, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(104, 2150, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(245, 2196, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(250, 2334, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(120, 847, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(-40, 784, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(-73, 944, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(202, 1135, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(-218, 891, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(-1154, 999, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(-904, 953, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(-1317, 835, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(969, 1014, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(1343, 808, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(1457, 873, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(1258, 1186, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(1086, 761, 25));

		// 'ERD_Nuka' GenType 18 Spawn Points
		AddSpawnPoint("d_catacomb_80_3.Id11", "d_catacomb_80_3", Rectangle(4, 2036, 300));
		AddSpawnPoint("d_catacomb_80_3.Id11", "d_catacomb_80_3", Rectangle(1166, 942, 300));
		AddSpawnPoint("d_catacomb_80_3.Id11", "d_catacomb_80_3", Rectangle(29, 941, 300));
		AddSpawnPoint("d_catacomb_80_3.Id11", "d_catacomb_80_3", Rectangle(-1108, 918, 300));
		AddSpawnPoint("d_catacomb_80_3.Id11", "d_catacomb_80_3", Rectangle(-1068, -47, 300));
		AddSpawnPoint("d_catacomb_80_3.Id11", "d_catacomb_80_3", Rectangle(1096, -35, 300));

		// 'ERD_Elma' GenType 19 Spawn Points
		AddSpawnPoint("d_catacomb_80_3.Id12", "d_catacomb_80_3", Rectangle(-1005, -906, 250));
		AddSpawnPoint("d_catacomb_80_3.Id12", "d_catacomb_80_3", Rectangle(36, -923, 250));
		AddSpawnPoint("d_catacomb_80_3.Id12", "d_catacomb_80_3", Rectangle(1174, -887, 250));
		AddSpawnPoint("d_catacomb_80_3.Id12", "d_catacomb_80_3", Rectangle(47, -1905, 250));
		AddSpawnPoint("d_catacomb_80_3.Id12", "d_catacomb_80_3", Rectangle(-580, -2542, 250));

		// 'Rootcrystal_05' GenType 20 Spawn Points
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(-647, -2519, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(-67, -2004, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(199, -1752, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(-174, -1140, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(-153, -726, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(166, -1091, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(154, -793, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(-1291, -1145, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(-1063, -778, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(-795, -1139, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(-1221, -120, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(-838, 60, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(-1381, 747, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(-1218, 1149, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(-838, 745, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(-154, 1077, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(-165, 689, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(123, 1132, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(163, 736, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(-168, 1727, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(227, 1776, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(14, 1995, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(-178, 2293, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(225, 2271, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(880, 1125, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(939, 748, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(1377, 805, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(1402, 1178, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(982, 45, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(1225, -178, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(911, -742, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(1080, -1082, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(1368, -744, 100));
	}
}
