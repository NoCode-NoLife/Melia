//--- Melia Script -----------------------------------------------------------
// Valandis Room 3 Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_fantasylibrary_48_4'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DFantasylibrary484MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_fantasylibrary_48_4", MonsterId.Lapinel, Properties("MHP", 557143, "MINPATK", 7665, "MAXPATK", 9323, "MINMATK", 7665, "MAXMATK", 9323, "DEF", 106194, "MDEF", 106194));
		AddPropertyOverrides("d_fantasylibrary_48_4", MonsterId.Lapindal, Properties("MHP", 560242, "MINPATK", 7705, "MAXPATK", 9372, "MINMATK", 7705, "MAXMATK", 9372, "DEF", 107727, "MDEF", 107727));
		AddPropertyOverrides("d_fantasylibrary_48_4", MonsterId.Wisnol, Properties("MHP", 563433, "MINPATK", 7746, "MAXPATK", 9422, "MINMATK", 7746, "MAXMATK", 9422, "DEF", 109305, "MDEF", 109305));
		AddPropertyOverrides("d_fantasylibrary_48_4", MonsterId.Lampal, Properties("MHP", 566714, "MINPATK", 7788, "MAXPATK", 9474, "MINMATK", 7788, "MAXMATK", 9474, "DEF", 110927, "MDEF", 110927));
		AddPropertyOverrides("d_fantasylibrary_48_4", MonsterId.Boss_Lucy_Q1, Properties("MHP", 2907421, "MINPATK", 18796, "MAXPATK", 22865, "MINMATK", 18796, "MAXMATK", 22865, "DEF", 270222, "MDEF", 270222));

		// Monster Spawners ---------------------------------

		AddSpawner("d_fantasylibrary_48_4.Id1", MonsterId.Rootcrystal_03, 12, 15, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_fantasylibrary_48_4.Id2", MonsterId.Lapinel, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_fantasylibrary_48_4.Id3", MonsterId.Lapindal, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_fantasylibrary_48_4.Id4", MonsterId.Wisnol, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_fantasylibrary_48_4.Id5", MonsterId.Lampal, 49, 65, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_03' GenType 6 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-1134, -1379, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-989, -1231, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-969, -1476, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-1166, -1525, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-465, -1483, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-397, -1148, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-271, -1343, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-1146, -518, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-1125, -305, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-994, -434, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-687, 5, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-690, 244, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-391, 342, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-545, 151, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-360, 3, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(54, 290, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(294, 514, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(106, 516, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(264, 332, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(479, 14, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(458, -358, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(658, -301, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(823, 296, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(795, 543, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(973, 567, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(1091, 414, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(1076, 265, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(943, 368, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(941, 997, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(988, 1112, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(1326, 879, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(1621, 786, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(1561, 1008, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(1789, 1033, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(1849, 812, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(1671, 895, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-158, 609, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-305, 749, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-557, 883, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-787, 928, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-677, 1151, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-416, 1110, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-578, 993, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-245, 1135, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-1085, 825, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-1029, 978, 100));

		// 'Lapinel' GenType 18 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-1163, -245, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-1098, -293, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-1204, -386, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-1118, -399, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-1242, -558, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-1128, -482, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-1036, -525, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-979, -369, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-1015, -250, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-989, -608, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-1033, -1134, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-962, -1213, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-1138, -1229, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-1090, -1327, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-1242, -1369, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-1105, -1413, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-1193, -1538, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-965, -1547, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-1024, -1391, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-904, -1369, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-607, -1360, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-515, -1356, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-460, -1490, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-399, -1323, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-280, -1367, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-325, -1491, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-213, -1213, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-384, -1126, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-423, -1246, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-568, -1170, 40));

		// 'Lapindal' GenType 19 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-1120, 955, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-983, 1001, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-1043, 910, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-1107, 783, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-1191, 863, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-644, 953, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-620, 1053, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-488, 1014, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-556, 897, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-455, 904, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-301, 1179, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-352, 921, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-229, 1108, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-361, 756, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-549, 670, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-742, 349, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-567, 397, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-637, 192, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-479, 333, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-378, 145, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-559, 121, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-713, 55, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-701, -49, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-463, 17, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-348, 357, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(68, 513, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(96, 213, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-40, 357, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(386, 355, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(241, 602, 40));

		// 'Wisnol' GenType 20 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(752, 447, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(866, 590, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(882, 405, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(1025, 559, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(1053, 280, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(937, 1035, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(947, 1147, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(1086, 1089, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(1268, 1031, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(1445, 835, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(1641, 1115, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(1565, 959, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(1707, 1023, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(1665, 852, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(1799, 880, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(1846, 1106, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(1644, 680, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(1928, 884, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(1487, 1113, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(999, 355, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(823, 228, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(353, 168, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(500, 61, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(127, 376, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(278, 378, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(550, -95, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(935, 677, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(194, 456, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(485, 382, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(604, 382, 40));

		// 'Lampal' GenType 21 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-1111, 874, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-1047, 1018, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-1021, 824, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-913, 973, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-949, 878, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-744, 1028, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-725, 914, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-531, 1083, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-589, 830, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-411, 1059, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-427, 792, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-289, 793, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-313, 688, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-163, 556, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-82, 635, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-17, 472, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(114, 579, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(60, 311, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(270, 291, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(277, 477, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(502, -312, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(489, -438, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(658, -344, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(653, -473, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(587, -213, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(758, 536, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(785, 362, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(933, 569, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(1052, 445, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(914, 249, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(872, 1064, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(943, 968, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(1090, 1028, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(993, 1058, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(1023, 1176, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(1203, 1004, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(1211, 883, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(1328, 899, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(1510, 895, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(1536, 1044, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(1610, 793, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(1752, 765, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(1790, 988, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(425, 129, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(510, -39, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-628, 312, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-707, 168, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-604, 1, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-398, 64, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-452, 210, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-1197, -309, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-1202, -445, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-1158, -553, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-1032, -451, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-944, -270, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-1163, -1289, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-1245, -1447, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-1005, -1307, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-1071, -1530, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-955, -1434, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-566, -1285, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-487, -1211, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-536, -1423, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-387, -1401, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-318, -1214, 40));
	}
}
