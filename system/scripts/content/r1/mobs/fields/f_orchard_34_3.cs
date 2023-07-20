//--- Melia Script -----------------------------------------------------------
// Barha Forest Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_orchard_34_3'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FOrchard343MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_orchard_34_3", MonsterId.Mushroom_Ent_Red, Properties("MHP", 330232, "MINPATK", 4747, "MAXPATK", 5737, "MINMATK", 4747, "MAXMATK", 5737, "DEF", 26911, "MDEF", 26911));
		AddPropertyOverrides("f_orchard_34_3", MonsterId.Rafflesia_Green, Properties("MHP", 331541, "MINPATK", 4764, "MAXPATK", 5758, "MINMATK", 4764, "MAXMATK", 5758, "DEF", 27234, "MDEF", 27234));
		AddPropertyOverrides("f_orchard_34_3", MonsterId.Big_Cockatries_Red, Properties("MHP", 333933, "MINPATK", 4795, "MAXPATK", 5795, "MINMATK", 4795, "MAXMATK", 5795, "DEF", 27825, "MDEF", 27825));
		AddPropertyOverrides("f_orchard_34_3", MonsterId.Flying_Flog_White, Properties("MHP", 337032, "MINPATK", 4834, "MAXPATK", 5844, "MINMATK", 4834, "MAXMATK", 5844, "DEF", 28591, "MDEF", 28591));

		// Monster Spawners ---------------------------------

		AddSpawner("f_orchard_34_3.Id1", MonsterId.Mushroom_Ent_Red, 3, 4, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_orchard_34_3.Id2", MonsterId.Rafflesia_Green, 11, 14, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_orchard_34_3.Id3", MonsterId.Big_Cockatries_Red, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_orchard_34_3.Id4", MonsterId.Flying_Flog_White, 60, 80, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_orchard_34_3.Id5", MonsterId.Rafflesia_Green, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_orchard_34_3.Id6", MonsterId.Flying_Flog_White, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_orchard_34_3.Id7", MonsterId.Rootcrystal_01, 15, 19, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Mushroom_Ent_Red' GenType 26 Spawn Points
		AddSpawnPoint("f_orchard_34_3.Id1", "f_orchard_34_3", Rectangle(58, 566, 50));
		AddSpawnPoint("f_orchard_34_3.Id1", "f_orchard_34_3", Rectangle(-88, 353, 50));
		AddSpawnPoint("f_orchard_34_3.Id1", "f_orchard_34_3", Rectangle(-80, 559, 50));
		AddSpawnPoint("f_orchard_34_3.Id1", "f_orchard_34_3", Rectangle(-300, 564, 50));
		AddSpawnPoint("f_orchard_34_3.Id1", "f_orchard_34_3", Rectangle(-465, 453, 50));
		AddSpawnPoint("f_orchard_34_3.Id1", "f_orchard_34_3", Rectangle(-514, 635, 50));
		AddSpawnPoint("f_orchard_34_3.Id1", "f_orchard_34_3", Rectangle(63, 748, 50));
		AddSpawnPoint("f_orchard_34_3.Id1", "f_orchard_34_3", Rectangle(192, 442, 50));
		AddSpawnPoint("f_orchard_34_3.Id1", "f_orchard_34_3", Rectangle(217, 613, 50));
		AddSpawnPoint("f_orchard_34_3.Id1", "f_orchard_34_3", Rectangle(357, 527, 50));
		AddSpawnPoint("f_orchard_34_3.Id1", "f_orchard_34_3", Rectangle(549, 627, 50));
		AddSpawnPoint("f_orchard_34_3.Id1", "f_orchard_34_3", Rectangle(-498, 835, 50));
		AddSpawnPoint("f_orchard_34_3.Id1", "f_orchard_34_3", Rectangle(-599, 1158, 50));
		AddSpawnPoint("f_orchard_34_3.Id1", "f_orchard_34_3", Rectangle(524, 453, 50));

		// 'Rafflesia_Green' GenType 27 Spawn Points
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(1103, -281, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(884, -424, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(789, -214, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(948, -230, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(958, -99, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(919, 30, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(1169, -129, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(1349, -142, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(1225, -355, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(1230, -501, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(1065, -431, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(1007, -621, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(851, -657, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(1131, -606, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(1053, -479, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(1300, -539, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(1447, -402, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(1355, -392, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(1155, -1, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(1212, -173, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(1327, -243, 30));

		// 'Big_Cockatries_Red' GenType 28 Spawn Points
		AddSpawnPoint("f_orchard_34_3.Id3", "f_orchard_34_3", Rectangle(-357, -184, 9999));

		// 'Flying_Flog_White' GenType 29 Spawn Points
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-981, -344, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1468, -203, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1039, -265, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1443, -677, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1593, -846, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1404, -1003, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1509, -1150, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1283, -1170, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1195, -1056, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1339, -1121, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1499, -892, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(941, -781, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(822, -973, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1217, -992, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1172, -927, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1439, 670, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1419, 541, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1220, 477, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1333, 564, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(987, 610, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(889, 41, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(789, 126, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(539, 695, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-283, -371, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-217, 600, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-785, 587, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-618, 470, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-496, 1045, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-609, 1152, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-531, 1165, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-470, 784, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(844, 587, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1117, -537, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(922, -343, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1075, -2, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1600, -78, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1686, -102, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1644, -477, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1797, -255, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1657, -348, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1865, -356, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1760, -418, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1221, -418, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1836, -108, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1769, -109, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1553, -91, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1757, -325, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1728, -233, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1548, -176, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1081, -439, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1858, -229, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-932, -133, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1115, -369, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1539, -408, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1562, -294, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1649, -256, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1478, -729, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1494, -792, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1512, -680, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1537, -732, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1511, -944, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1274, -1061, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1204, -1099, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1237, -1130, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1269, -1105, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1324, -1066, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1484, -973, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1421, -944, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1185, -139, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1095, -87, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1089, -138, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1121, -212, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1144, -173, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1187, -237, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-911, -387, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-877, -451, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-849, -351, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-882, -261, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-771, -203, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-815, -286, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-790, -425, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-734, -398, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-310, -343, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-287, -281, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-289, -233, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-335, -271, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-368, -232, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-379, -333, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-349, -384, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-363, -319, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-399, -271, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-411, -374, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-785, 525, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-649, 645, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-722, 567, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-569, 486, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-510, 559, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-428, 724, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-373, 674, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-310, 649, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-363, 570, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-347, 474, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-381, 525, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-394, 433, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-290, 550, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-304, 486, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-216, 527, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-198, 444, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-286, 440, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-131, 506, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-149, 597, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-76, 645, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-15, 682, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(77, 676, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(63, 469, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(35, 519, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(116, 502, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(113, 457, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(118, 553, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(74, 609, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(131, 624, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(185, 568, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(179, 480, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(247, 501, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(268, 575, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-566, 1075, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-491, 1185, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-553, 1225, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-602, 1260, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-664, 1230, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-636, 1199, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-686, 1135, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-653, 1083, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-557, 1120, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(335, 492, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(382, 455, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(473, 621, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(504, 573, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(562, 431, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(476, 393, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(553, 537, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(594, 449, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(632, 475, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(703, 535, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(771, 553, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(766, 594, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(830, 632, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(889, 595, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(931, 623, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1015, 579, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1052, 637, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1276, 588, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1360, 633, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1390, 583, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1372, 512, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1436, 609, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1386, 671, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1419, 714, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1409, 772, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1352, 732, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1272, 731, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1309, 673, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1283, 634, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1239, -61, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1281, -121, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1303, -195, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1214, -111, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1238, -233, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1167, -238, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(968, -36, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1099, -127, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1030, -238, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(957, -173, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(870, -201, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(837, -271, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1018, -375, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(856, -416, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(965, -469, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(943, -588, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1069, -628, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1128, -351, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1133, -477, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1194, -417, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1179, -553, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1260, -434, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1253, -376, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1389, -435, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1188, -572, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1516, -154, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1862, -123, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1723, -216, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1742, -146, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1816, -341, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1123, -812, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1036, -785, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1065, -861, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1083, -950, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(901, -1021, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1253, -885, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1039, -1050, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(906, -923, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(922, -1099, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1007, -996, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(987, -907, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(799, -835, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(853, -788, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1004, -500, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(559, -755, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(496, -765, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(377, -823, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(284, -765, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(351, -703, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(372, -549, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(460, -588, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(512, -639, 30));

		// 'Rafflesia_Green' GenType 30 Spawn Points
		AddSpawnPoint("f_orchard_34_3.Id5", "f_orchard_34_3", Rectangle(-365, -145, 9999));

		// 'Flying_Flog_White' GenType 31 Spawn Points
		AddSpawnPoint("f_orchard_34_3.Id6", "f_orchard_34_3", Rectangle(444, -693, 200));

		// 'Rootcrystal_01' GenType 38 Spawn Points
		AddSpawnPoint("f_orchard_34_3.Id7", "f_orchard_34_3", Rectangle(-1459, -979, 100));
		AddSpawnPoint("f_orchard_34_3.Id7", "f_orchard_34_3", Rectangle(-1671, -304, 100));
		AddSpawnPoint("f_orchard_34_3.Id7", "f_orchard_34_3", Rectangle(-1147, -248, 100));
		AddSpawnPoint("f_orchard_34_3.Id7", "f_orchard_34_3", Rectangle(-797, -271, 100));
		AddSpawnPoint("f_orchard_34_3.Id7", "f_orchard_34_3", Rectangle(-378, -254, 100));
		AddSpawnPoint("f_orchard_34_3.Id7", "f_orchard_34_3", Rectangle(-262, -855, 100));
		AddSpawnPoint("f_orchard_34_3.Id7", "f_orchard_34_3", Rectangle(381, -680, 100));
		AddSpawnPoint("f_orchard_34_3.Id7", "f_orchard_34_3", Rectangle(1007, -911, 100));
		AddSpawnPoint("f_orchard_34_3.Id7", "f_orchard_34_3", Rectangle(1305, -331, 100));
		AddSpawnPoint("f_orchard_34_3.Id7", "f_orchard_34_3", Rectangle(965, -419, 100));
		AddSpawnPoint("f_orchard_34_3.Id7", "f_orchard_34_3", Rectangle(1758, -288, 100));
		AddSpawnPoint("f_orchard_34_3.Id7", "f_orchard_34_3", Rectangle(815, 175, 100));
		AddSpawnPoint("f_orchard_34_3.Id7", "f_orchard_34_3", Rectangle(1155, 662, 100));
		AddSpawnPoint("f_orchard_34_3.Id7", "f_orchard_34_3", Rectangle(655, 582, 100));
		AddSpawnPoint("f_orchard_34_3.Id7", "f_orchard_34_3", Rectangle(0, 504, 100));
		AddSpawnPoint("f_orchard_34_3.Id7", "f_orchard_34_3", Rectangle(-77, 128, 100));
		AddSpawnPoint("f_orchard_34_3.Id7", "f_orchard_34_3", Rectangle(-598, 1238, 100));
		AddSpawnPoint("f_orchard_34_3.Id7", "f_orchard_34_3", Rectangle(-647, 620, 100));
		AddSpawnPoint("f_orchard_34_3.Id7", "f_orchard_34_3", Rectangle(-1366, 500, 100));
	}
}
