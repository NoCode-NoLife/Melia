//--- Melia Script -----------------------------------------------------------
// Ouaas Memorial Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_pilgrimroad_41_5'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FPilgrimroad415MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_pilgrimroad_41_5.Id1", MonsterId.Rootcrystal_05, min: 12, max: 16, respawn: TimeSpan.FromMilliseconds(5000));
		AddSpawner("f_pilgrimroad_41_5.Id2", MonsterId.Nuka_Brown, min: 38, max: 50);
		AddSpawner("f_pilgrimroad_41_5.Id3", MonsterId.Lapasape_Bow_Brown, min: 23, max: 30);
		AddSpawner("f_pilgrimroad_41_5.Id4", MonsterId.Elma_Red, min: 8, max: 10);
		AddSpawner("f_pilgrimroad_41_5.Id5", MonsterId.Lapasape_Bow_Brown, min: 23, max: 30);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_05' GenType 2 Spawn Points
		AddSpawnPoint("f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Rectangle(-1709, 472, 50));
		AddSpawnPoint("f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Rectangle(-1449, 488, 50));
		AddSpawnPoint("f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Rectangle(-1018, 382, 50));
		AddSpawnPoint("f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Rectangle(-834, 134, 50));
		AddSpawnPoint("f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Rectangle(-689, 409, 50));
		AddSpawnPoint("f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Rectangle(-445, 864, 50));
		AddSpawnPoint("f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Rectangle(-186, 875, 50));
		AddSpawnPoint("f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Rectangle(-852, -266, 50));
		AddSpawnPoint("f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Rectangle(-817, -564, 50));
		AddSpawnPoint("f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Rectangle(-1051, -951, 50));
		AddSpawnPoint("f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Rectangle(-174, 100, 50));
		AddSpawnPoint("f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Rectangle(-56, -210, 50));
		AddSpawnPoint("f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Rectangle(179, 74, 50));
		AddSpawnPoint("f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Rectangle(-62, -673, 50));
		AddSpawnPoint("f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Rectangle(101, -947, 50));
		AddSpawnPoint("f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Rectangle(588, 380, 50));
		AddSpawnPoint("f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Rectangle(707, -405, 50));
		AddSpawnPoint("f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Rectangle(1000, -367, 50));
		AddSpawnPoint("f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Rectangle(1145, 80, 50));
		AddSpawnPoint("f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Rectangle(1229, 412, 50));
		AddSpawnPoint("f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Rectangle(1540, 155, 50));
		AddSpawnPoint("f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Rectangle(1868, 294, 50));
		AddSpawnPoint("f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Rectangle(1119, -905, 50));
		AddSpawnPoint("f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Rectangle(1400, -1058, 50));

		// 'Nuka_Brown' GenType 100 Spawn Points
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-205, -211, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-214, 8, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(253, -186, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(58, -279, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(300, 198, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(508, 371, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(630, 503, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(765, 396, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(695, 343, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(1112, 92, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(1048, 275, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(1253, 556, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(1308, 258, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(1572, 39, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(1475, 240, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(448, -303, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(645, -336, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(863, -281, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(961, -444, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(874, -515, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(822, -458, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(741, -515, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(5, -626, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-88, -945, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(119, -965, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(1119, -884, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(1178, -1122, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(1388, -1083, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(1358, -875, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(1274, -1008, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(1090, -961, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-725, 101, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-1124, 382, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-970, 560, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-691, 555, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-600, 250, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-471, 207, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(223, 29, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-502, 798, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-494, 996, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-187, 1030, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-296, 747, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-325, 827, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-1099, -282, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-688, -217, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-838, -397, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-963, -537, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-833, -652, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-928, -737, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-1190, -949, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(1059, 441, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(1237, 394, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(1364, 123, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-669, -546, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-122, 157, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(56, 110, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(39, -1005, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-1044, -1219, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(1209, 246, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-961, -1029, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-901, -308, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-955, 450, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-1065, -1086, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-297, 119, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-806, -242, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-999, -376, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(1644, 206, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(55, -25, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-161, -764, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-659, -378, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-1177, -860, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-963, -215, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(1613, 308, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-953, -931, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-1030, -850, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-976, -855, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(1400, 443, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(149, -81, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(1366, -824, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-272, 191, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-765, 239, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(760, -360, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-66, -640, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-895, -939, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(1272, -891, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(1355, -44, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-155, -878, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-847, 115, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-836, 431, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(1126, -1082, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-298, -140, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Rectangle(-1166, -1223, 25));

		// 'Lapasape_Bow_Brown' GenType 101 Spawn Points
		AddSpawnPoint("f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Rectangle(686, -422, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Rectangle(806, -277, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Rectangle(942, -331, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Rectangle(841, -414, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Rectangle(815, -535, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Rectangle(940, -540, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Rectangle(517, 383, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Rectangle(588, 514, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Rectangle(695, 552, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Rectangle(697, 369, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Rectangle(678, 245, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Rectangle(1341, 126, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Rectangle(1241, 291, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Rectangle(1117, 237, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Rectangle(1201, 89, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Rectangle(1388, 338, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Rectangle(1160, 485, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Rectangle(1120, -947, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Rectangle(1240, -887, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Rectangle(1358, -883, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Rectangle(1377, -1047, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Rectangle(1259, -1049, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Rectangle(1173, -1093, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Rectangle(1266, -1210, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Rectangle(263, 233, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Rectangle(453, -246, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Rectangle(535, -272, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Rectangle(1541, 115, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Rectangle(1580, 232, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Rectangle(1442, 199, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Rectangle(1060, 375, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Rectangle(1004, 170, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Rectangle(731, -344, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Rectangle(1037, -409, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Rectangle(1092, -849, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Rectangle(983, -717, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Rectangle(1069, -1040, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Rectangle(1421, -956, 25));

		// 'Elma_Red' GenType 102 Spawn Points
		AddSpawnPoint("f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Rectangle(-1172, -1072, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Rectangle(-1133, -952, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Rectangle(-1029, -973, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Rectangle(139, -918, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Rectangle(-899, -596, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Rectangle(-851, -402, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Rectangle(-1012, -350, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Rectangle(-834, -188, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Rectangle(-729, -391, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Rectangle(-890, -261, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Rectangle(-511, 902, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Rectangle(-331, 980, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Rectangle(-161, 881, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Rectangle(-281, 749, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Rectangle(-259, 667, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Rectangle(-492, 813, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Rectangle(-142, 1019, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Rectangle(655, 440, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Rectangle(517, 476, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Rectangle(627, 310, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Rectangle(747, 305, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Rectangle(814, 401, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Rectangle(740, 493, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Rectangle(544, 292, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Rectangle(-182, 108, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Rectangle(-181, -43, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Rectangle(-76, -187, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Rectangle(-117, -786, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Rectangle(46, -752, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Rectangle(35, -850, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Rectangle(-39, -964, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Rectangle(71, -1030, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Rectangle(185, -997, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Rectangle(-55, -620, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Rectangle(-229, -158, 25));
		AddSpawnPoint("f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Rectangle(-16, -2, 25));

		// 'Lapasape_Bow_Brown' GenType 103 Spawn Points
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(-1140, -1031, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(-1178, -905, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(-1046, -1032, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(-914, -828, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(-938, -665, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(-766, -559, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(-904, -402, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(-1003, -474, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(-738, -379, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(-873, -278, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(-834, -189, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(-872, 18, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(-626, 113, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(-594, 381, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(-757, 30, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(-1098, 469, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(-1077, 257, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(-803, 545, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(-499, 748, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(-566, 1013, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(-464, 1082, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(-353, 970, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(-433, 854, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(-222, 733, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(-161, 923, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(-36, -936, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(220, -886, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(99, -1004, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(16, -859, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(-164, -823, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(-61, -721, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(-65, -587, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(-67, -388, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(-104, -358, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(39, -153, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(-193, -119, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(-176, -245, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(-206, 63, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(-142, 233, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(5, 70, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(107, 162, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(134, -30, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(228, -212, 30));
		AddSpawnPoint("f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Rectangle(329, -206, 30));
	}
}
