//--- Melia Script -----------------------------------------------------------
// Ruklys Street Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_flash_61'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FFlash61MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_flash_61.Id1", MonsterId.Denden, min: 12, max: 15);
		AddSpawner("f_flash_61.Id2", MonsterId.Moyabu, min: 12, max: 15);
		AddSpawner("f_flash_61.Id3", MonsterId.Moyabu, min: 15, max: 20);
		AddSpawner("f_flash_61.Id4", MonsterId.Goblin2_Sword, min: 75, max: 100);
		AddSpawner("f_flash_61.Id5", MonsterId.Rootcrystal_01, min: 12, max: 15, respawn: TimeSpan.FromMilliseconds(20000));
		AddSpawner("f_flash_61.Id6", MonsterId.Denden, min: 12, max: 15);

		// Monster Spawn Points -----------------------------

		// 'Denden' GenType 4 Spawn Points
		AddSpawnPoint("f_flash_61.Id1", "f_flash_61", Rectangle(680, 506, 9999));

		// 'Moyabu' GenType 14 Spawn Points
		AddSpawnPoint("f_flash_61.Id2", "f_flash_61", Rectangle(707, 562, 9999));

		// 'Moyabu' GenType 15 Spawn Points
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(-26, 144, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(-873, 521, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(80, 33, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(-708, 686, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(-59, 306, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(-167, 231, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(-277, 59, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(-98, 552, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(758, 286, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(986, 503, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(997, 65, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(910, 346, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(1163, 373, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(1011, 263, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(776, 90, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(728, 520, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(-776, 973, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(-861, 611, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(-626, 530, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(-669, 864, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(-141, 23, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(-180, 373, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(232, 92, 30));

		// 'Goblin2_Sword' GenType 28 Spawn Points
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(865, 72, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(740, 498, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(922, 1115, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-680, 686, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(931, 354, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1110, 419, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-749, 944, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(737, 292, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-866, 527, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(800, 975, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(782, 1295, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1289, 1275, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1111, 1080, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1345, 1078, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1286, 946, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1012, 943, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1145, 1196, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(732, 1126, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-190, 132, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(65, 94, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-102, 475, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-212, 954, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(200, 992, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-79, 682, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-456, 1187, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-550, 1419, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-630, 1215, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-552, 1031, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-38, 1055, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(340, 1003, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-822, 566, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-908, 556, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-915, 596, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-773, 587, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-780, 517, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-712, 491, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-656, 549, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-609, 606, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-678, 618, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-732, 639, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-622, 648, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-618, 731, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-700, 747, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-721, 784, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-600, 779, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-680, 936, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-754, 1014, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-793, 1025, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-669, 987, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-604, 1014, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-542, 954, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-487, 1003, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-452, 941, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-430, 1052, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-525, 1040, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-502, 1220, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-551, 1326, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-619, 1412, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-642, 1331, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-599, 1348, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-631, 1270, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-721, 1305, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-729, 1348, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-712, 1476, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-484, 1336, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-480, 1278, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-413, 1340, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-332, 1344, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-347, 1244, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-386, 1180, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-298, 1291, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-262, 1342, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-455, 1235, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-797, 621, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-916, 656, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-213, 67, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-183, -79, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-116, -91, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-56, -88, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1, -77, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-96, 5, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-131, 87, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-113, 165, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-51, 79, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(2, 20, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(17, 84, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(122, 76, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(210, 2, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(178, 121, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-59, 216, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-127, 263, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-130, 336, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-75, 364, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(24, 346, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-37, 441, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-120, 409, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-63, 522, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-40, 581, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-103, 620, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-167, 631, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-103, 728, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-168, 763, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-149, 566, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-174, 912, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-175, 1009, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-242, 1011, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-121, 955, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-25, 925, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(43, 945, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-61, 1012, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-122, 1141, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-105, 1214, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-106, 1286, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-136, 1209, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-54, 1275, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(135, 957, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(126, 1025, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(59, 1032, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(94, 932, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(184, 1047, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(278, 1036, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(319, 944, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(414, 994, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(429, 1068, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(496, 1029, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(804, 1056, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(925, 1024, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(846, 1110, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(772, 1209, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(860, 1290, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(930, 1334, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(912, 1166, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1010, 1175, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1009, 1097, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1026, 1017, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1096, 975, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1194, 1013, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1323, 999, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1275, 1068, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1311, 1119, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1343, 1177, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1251, 1167, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1362, 1290, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1296, 1324, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1197, 1303, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1105, 1298, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1086, 1171, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1077, 1097, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1002, 1304, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(834, 1353, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(931, 74, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1024, 2, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1061, 52, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1053, 114, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1055, 165, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(980, 120, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(912, 126, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(861, 94, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(784, 158, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(792, 217, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(806, 287, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(771, 367, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(700, 385, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(712, 456, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(811, 470, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(764, 576, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(688, 579, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(833, 576, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(888, 472, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(830, 370, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(955, 431, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(895, 389, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1043, 456, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1044, 373, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1198, 474, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1219, 410, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1128, 469, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1013, 411, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(827, 523, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(645, 548, 25));

		// 'Rootcrystal_01' GenType 32 Spawn Points
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(-879, -198, 100));
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(-706, -37, 100));
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(-227, 51, 100));
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(39, 41, 100));
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(-86, 343, 100));
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(-83, 610, 100));
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(-910, 591, 100));
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(-696, 559, 100));
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(-670, 799, 100));
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(-608, 996, 100));
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(-452, 1310, 100));
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(-85, 1131, 100));
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(-34, 991, 100));
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(363, 974, 100));
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(817, 1040, 100));
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(1209, 1124, 100));
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(850, 463, 100));
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(914, 74, 100));
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(1133, 109, 100));
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(680, 448, 100));

		// 'Denden' GenType 33 Spawn Points
		AddSpawnPoint("f_flash_61.Id6", "f_flash_61", Rectangle(-571, 1250, 25));
		AddSpawnPoint("f_flash_61.Id6", "f_flash_61", Rectangle(-626, 1466, 25));
		AddSpawnPoint("f_flash_61.Id6", "f_flash_61", Rectangle(-575, 993, 25));
		AddSpawnPoint("f_flash_61.Id6", "f_flash_61", Rectangle(-409, 1263, 25));
		AddSpawnPoint("f_flash_61.Id6", "f_flash_61", Rectangle(-480, 1387, 25));
		AddSpawnPoint("f_flash_61.Id6", "f_flash_61", Rectangle(247, 966, 25));
		AddSpawnPoint("f_flash_61.Id6", "f_flash_61", Rectangle(-235, 1301, 25));
		AddSpawnPoint("f_flash_61.Id6", "f_flash_61", Rectangle(-262, 906, 25));
		AddSpawnPoint("f_flash_61.Id6", "f_flash_61", Rectangle(43, 828, 25));
		AddSpawnPoint("f_flash_61.Id6", "f_flash_61", Rectangle(-74, 1135, 25));
		AddSpawnPoint("f_flash_61.Id6", "f_flash_61", Rectangle(-148, 720, 25));
		AddSpawnPoint("f_flash_61.Id6", "f_flash_61", Rectangle(-703, 571, 25));
		AddSpawnPoint("f_flash_61.Id6", "f_flash_61", Rectangle(-782, 957, 25));
		AddSpawnPoint("f_flash_61.Id6", "f_flash_61", Rectangle(-428, 1077, 25));
		AddSpawnPoint("f_flash_61.Id6", "f_flash_61", Rectangle(-663, 773, 25));
	}
}
