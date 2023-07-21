//--- Melia Script -----------------------------------------------------------
// Vienibe Shelter Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_castle_97'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FCastle97MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_castle_97", MonsterId.Pawnta, Properties("MHP", 774142, "MINPATK", 10456, "MAXPATK", 12753, "MINMATK", 10456, "MAXMATK", 12753, "DEF", 247497, "MDEF", 247497));
		AddPropertyOverrides("f_castle_97", MonsterId.Poevita, Properties("MHP", 775969, "MINPATK", 10479, "MAXPATK", 12782, "MINMATK", 10479, "MAXMATK", 12782, "DEF", 249036, "MDEF", 249036));
		AddPropertyOverrides("f_castle_97", MonsterId.Poana, Properties("MHP", 777836, "MINPATK", 10503, "MAXPATK", 12811, "MINMATK", 10503, "MAXMATK", 12811, "DEF", 250608, "MDEF", 250608));
		AddPropertyOverrides("f_castle_97", MonsterId.Castle_Beetle, Properties("MHP", 779743, "MINPATK", 10528, "MAXPATK", 12841, "MINMATK", 10528, "MAXMATK", 12841, "DEF", 252214, "MDEF", 252214));
		AddPropertyOverrides("f_castle_97", MonsterId.Boss_Velnipper_Q1, Properties("MHP", 4174215, "MINPATK", 27859, "MAXPATK", 33982, "MINMATK", 27859, "MAXMATK", 33982, "DEF", 670170, "MDEF", 670170));

		// Monster Spawners ---------------------------------

		AddSpawner("f_castle_97.Id1", MonsterId.Pawnta, 42, 55, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_castle_97.Id2", MonsterId.Poevita, 42, 55, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_castle_97.Id3", MonsterId.Poevita, 27, 35, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_castle_97.Id4", MonsterId.Pawnta, 23, 30, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_castle_97.Id5", MonsterId.Poana, 23, 30, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_castle_97.Id6", MonsterId.Poana, 19, 25, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_castle_97.Id7", MonsterId.Castle_Beetle, 12, 15, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_castle_97.Id8", MonsterId.Rootcrystal_02, 27, 35, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Pawnta' GenType 1 Spawn Points
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(-60, -12, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(-110, 217, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(-320, 393, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(-12, 419, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(-194, 691, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(10, 660, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(756, 76, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(927, -19, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1016, 201, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1667, -97, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1879, 52, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1803, 275, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1822, 109, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1833, -44, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(2012, 65, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(2046, 1008, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(2012, 868, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1727, 993, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1547, 880, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1290, 848, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1092, 1043, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1459, 862, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1895, 828, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1904, 1027, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1842, 510, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(-258, -100, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(-118, -386, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(-109, -656, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(-256, -752, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(-127, -944, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(69, -794, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(47, -899, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(532, -839, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(751, -799, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1115, -917, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1298, -1012, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1477, -814, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1279, -689, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1125, -647, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1383, 137, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1682, 242, 30));

		// 'Poevita' GenType 2 Spawn Points
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(-457, 113, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1638, 273, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1810, 399, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1804, 619, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1681, 857, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1330, 945, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1193, 1092, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1105, 926, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1627, 1044, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1811, 1098, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(2001, 1135, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(2149, 1005, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(2126, 867, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1803, 896, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1981, -69, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(2086, 109, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1667, 70, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1499, 90, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1328, 67, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1121, 122, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1114, -48, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(914, 97, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(810, -77, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(884, 234, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1118, 282, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(608, 121, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(431, 65, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(237, 136, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(15, -152, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(-131, -149, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(-248, 15, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(39, 82, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(28, 281, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(-272, 220, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(-178, 439, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(-126, 337, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(-82, 551, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(-246, 575, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(-148, 792, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(66, 840, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(109, 472, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(-334, 805, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(-341, -219, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(-101, -531, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(-181, -690, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(-369, -776, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(-325, -975, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(-226, -880, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(-94, -796, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1, -957, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(28, -710, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(150, -922, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(303, -850, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(452, -837, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(595, -790, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(846, -852, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(956, -798, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1099, -771, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1406, -665, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1280, -902, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1165, -1049, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1476, -1078, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1558, -958, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1435, -952, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1550, -643, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1329, -803, 35));

		// 'Poevita' GenType 3 Spawn Points
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-691, 128, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-923, 60, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-1117, 173, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-1303, 45, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-1492, 53, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-1488, 276, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-1360, 412, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-1358, 644, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-1333, 821, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-1497, 1081, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-1365, 1199, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-1219, 1140, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-1114, 988, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-1090, 1167, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-1571, 944, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-1990, 1105, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-2078, 1236, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-1653, 233, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-1769, 185, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-1810, 248, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-2049, 124, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-2299, 120, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-2269, 255, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-2182, 394, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-2312, 404, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-2069, 414, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-2173, -136, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-2197, -335, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-2359, -426, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-2398, -638, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-2112, -677, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-2050, -516, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-2115, -785, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-1994, -392, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-1176, 81, 35));

		// 'Pawnta' GenType 4 Spawn Points
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1266, 148, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1203, 277, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1486, 143, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1426, 381, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1892, 234, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-2109, 281, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-2376, 254, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-2195, -41, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-2180, -206, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-2116, -402, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-2372, -511, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-2370, -704, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-2239, -635, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1973, -572, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-2181, -540, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-2008, -677, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1509, 312, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1102, 260, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1378, 553, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1352, 741, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1377, 940, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1529, 1017, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1521, 1207, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1357, 1102, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1184, 1245, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1033, 1281, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1031, 1022, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1230, 979, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1797, 993, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1705, 1034, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1950, 954, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-2149, 996, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-2188, 1142, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1934, 1254, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-2074, 1333, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1886, 1047, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1345, 216, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1393, 124, 25));

		// 'Poana' GenType 5 Spawn Points
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(1145, 840, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(1624, 980, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(1840, 992, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(2039, 944, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(2012, 138, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(1883, -110, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(1636, 131, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(1040, 80, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(854, 64, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(-123, 106, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(-332, -40, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(-235, 334, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(-322, 500, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(-63, 672, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(38, 546, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(117, 672, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(97, 133, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(-392, -884, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(-66, -858, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(124, -739, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(152, -860, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(1204, -857, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(727, -865, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(864, -789, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(1416, -748, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(1378, -991, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(1072, -1025, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(1559, -760, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(1519, -1052, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(-42, 322, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(-92, -83, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(-361, -682, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(-160, -995, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(-59, -430, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(-802, 76, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(-581, 131, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(-885, 135, 30));

		// 'Poana' GenType 6 Spawn Points
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-2098, -593, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-2238, -744, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-2386, -585, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-2211, -403, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-2187, 99, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-2402, 113, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-2209, 322, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-2020, 251, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-1713, 252, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-1502, 386, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-1217, 183, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-1221, 417, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-1449, 943, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-1607, 1123, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-1450, 1153, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-1272, 1048, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-1244, 1222, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-1115, 1074, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-1096, 1273, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-1019, 1121, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-2051, 938, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-2046, 1017, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-2131, 1217, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-1962, 1198, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-1974, 1312, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-2217, -166, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-2144, -75, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-1843, 199, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-1533, 175, 30));

		// 'Castle_Beetle' GenType 9 Spawn Points
		AddSpawnPoint("f_castle_97.Id7", "f_castle_97", Rectangle(-2230, 214, 100));
		AddSpawnPoint("f_castle_97.Id7", "f_castle_97", Rectangle(-1469, 302, 100));
		AddSpawnPoint("f_castle_97.Id7", "f_castle_97", Rectangle(-1233, 90, 100));
		AddSpawnPoint("f_castle_97.Id7", "f_castle_97", Rectangle(-1167, 1131, 100));
		AddSpawnPoint("f_castle_97.Id7", "f_castle_97", Rectangle(-1418, 1087, 100));
		AddSpawnPoint("f_castle_97.Id7", "f_castle_97", Rectangle(-1995, 1051, 100));
		AddSpawnPoint("f_castle_97.Id7", "f_castle_97", Rectangle(1219, 922, 100));
		AddSpawnPoint("f_castle_97.Id7", "f_castle_97", Rectangle(1691, 908, 100));
		AddSpawnPoint("f_castle_97.Id7", "f_castle_97", Rectangle(2044, 940, 100));
		AddSpawnPoint("f_castle_97.Id7", "f_castle_97", Rectangle(1721, 201, 100));
		AddSpawnPoint("f_castle_97.Id7", "f_castle_97", Rectangle(1983, -16, 100));
		AddSpawnPoint("f_castle_97.Id7", "f_castle_97", Rectangle(964, 100, 100));
		AddSpawnPoint("f_castle_97.Id7", "f_castle_97", Rectangle(-147, 676, 100));
		AddSpawnPoint("f_castle_97.Id7", "f_castle_97", Rectangle(-114, 73, 100));
		AddSpawnPoint("f_castle_97.Id7", "f_castle_97", Rectangle(-145, -830, 100));
		AddSpawnPoint("f_castle_97.Id7", "f_castle_97", Rectangle(1117, -838, 100));
		AddSpawnPoint("f_castle_97.Id7", "f_castle_97", Rectangle(1504, -865, 100));
		AddSpawnPoint("f_castle_97.Id7", "f_castle_97", Rectangle(-2138, -636, 100));
		AddSpawnPoint("f_castle_97.Id7", "f_castle_97", Rectangle(-2199, -350, 100));

		// 'Rootcrystal_02' GenType 22 Spawn Points
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-98, 1303, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-29, 826, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-248, 564, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-6, 307, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-269, 104, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(8, -126, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-90, -446, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-287, -791, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(24, -895, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(429, -829, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(817, -837, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(1195, -762, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(1449, -948, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-582, 81, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-951, 87, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-1242, 100, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-1344, 566, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-1651, 195, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-1947, 1007, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-2297, 222, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-2039, 239, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-2147, -107, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-2086, -707, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-2178, -419, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-1252, 958, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-1128, 1270, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-1490, 1273, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-1577, 1001, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-1969, 1271, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(390, 81, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(1091, 17, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(1463, 73, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(1760, 222, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(2009, -66, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(1823, 529, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(1314, 861, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(1933, 853, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(1156, 1114, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(1654, 1017, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(819, 116, 200));
	}
}
