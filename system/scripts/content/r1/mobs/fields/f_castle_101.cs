//--- Melia Script -----------------------------------------------------------
// Sacred Atspalvis  Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_castle_101'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FCastle101MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_castle_101", MonsterId.Bower_Guillotine, Properties("MHP", 827763, "MINPATK", 11145, "MAXPATK", 13600, "MINMATK", 11145, "MAXMATK", 13600, "DEF", 292656, "MDEF", 292656));
		AddPropertyOverrides("f_castle_101", MonsterId.Bower_Oblivion, Properties("MHP", 830831, "MINPATK", 11184, "MAXPATK", 13648, "MINMATK", 11184, "MAXMATK", 13648, "DEF", 295668, "MDEF", 295668));
		AddPropertyOverrides("f_castle_101", MonsterId.Bower_Interfere, Properties("MHP", 836441, "MINPATK", 11257, "MAXPATK", 13737, "MINMATK", 11257, "MAXMATK", 13737, "DEF", 301175, "MDEF", 301175));
		AddPropertyOverrides("f_castle_101", MonsterId.Bower_Obstructer, Properties("MHP", 843705, "MINPATK", 11350, "MAXPATK", 13852, "MINMATK", 11350, "MAXMATK", 13852, "DEF", 308306, "MDEF", 308306));
		AddPropertyOverrides("f_castle_101", MonsterId.Boss_BowerKeeper, Properties("MHP", 4551323, "MINPATK", 30256, "MAXPATK", 36928, "MINMATK", 30256, "MAXMATK", 36928, "DEF", 836223, "MDEF", 836223));

		// Monster Spawners ---------------------------------

		AddSpawner("f_castle_101.Id1", MonsterId.Bower_Guillotine, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_castle_101.Id2", MonsterId.Bower_Oblivion, 64, 85, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_castle_101.Id3", MonsterId.Bower_Interfere, 49, 65, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_castle_101.Id4", MonsterId.Bower_Obstructer, 38, 50, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_castle_101.Id5", MonsterId.Rootcrystal_01, 23, 30, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Bower_Guillotine' GenType 52 Spawn Points
		AddSpawnPoint("f_castle_101.Id1", "f_castle_101", Rectangle(-1380, -283, 20));
		AddSpawnPoint("f_castle_101.Id1", "f_castle_101", Rectangle(891, -527, 20));
		AddSpawnPoint("f_castle_101.Id1", "f_castle_101", Rectangle(947, -97, 20));
		AddSpawnPoint("f_castle_101.Id1", "f_castle_101", Rectangle(-575, -472, 20));
		AddSpawnPoint("f_castle_101.Id1", "f_castle_101", Rectangle(-419, -28, 20));
		AddSpawnPoint("f_castle_101.Id1", "f_castle_101", Rectangle(390, 309, 20));
		AddSpawnPoint("f_castle_101.Id1", "f_castle_101", Rectangle(72, 373, 20));
		AddSpawnPoint("f_castle_101.Id1", "f_castle_101", Rectangle(-177, 381, 20));
		AddSpawnPoint("f_castle_101.Id1", "f_castle_101", Rectangle(-856, 290, 20));
		AddSpawnPoint("f_castle_101.Id1", "f_castle_101", Rectangle(-86, -488, 20));
		AddSpawnPoint("f_castle_101.Id1", "f_castle_101", Rectangle(129, -145, 20));
		AddSpawnPoint("f_castle_101.Id1", "f_castle_101", Rectangle(228, -589, 20));
		AddSpawnPoint("f_castle_101.Id1", "f_castle_101", Rectangle(-944, -112, 20));
		AddSpawnPoint("f_castle_101.Id1", "f_castle_101", Rectangle(-1255, -66, 20));
		AddSpawnPoint("f_castle_101.Id1", "f_castle_101", Rectangle(-1151, -246, 20));
		AddSpawnPoint("f_castle_101.Id1", "f_castle_101", Rectangle(-545, 235, 20));
		AddSpawnPoint("f_castle_101.Id1", "f_castle_101", Rectangle(607, -400, 20));
		AddSpawnPoint("f_castle_101.Id1", "f_castle_101", Rectangle(363, -363, 20));

		// 'Bower_Oblivion' GenType 53 Spawn Points
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(-1123, -1531, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(-1254, -1465, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(-887, -1570, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(-810, -1492, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(-559, -1590, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(294, -1440, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(830, -1588, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(985, -1443, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(1593, -1547, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(1697, -1385, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(1818, -1568, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(1683, -1208, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(1804, -1080, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(1783, -656, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(1692, -813, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(1825, -459, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(1723, -525, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(1779, -125, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(1709, 100, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(-1485, -175, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(-1254, -270, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(-1430, -380, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(-861, -79, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(-1350, -57, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(-902, 390, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(-728, 228, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(-19, 452, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(216, 459, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(-124, 260, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(362, 220, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(619, -161, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(747, -234, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(797, 12, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(766, -536, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(1025, -516, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(-138, -612, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(-153, -358, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(-13, -180, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(272, -178, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(338, -946, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(331, -507, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(-298, -73, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(-549, -574, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(848, -395, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(1093, -59, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(1455, -1590, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(1, -621, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(-1032, -264, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(-1071, 23, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(-1138, -134, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(-1256, 194, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(-912, 227, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(439, -743, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(241, -707, 35));
		AddSpawnPoint("f_castle_101.Id2", "f_castle_101", Rectangle(122, -485, 35));

		// 'Bower_Interfere' GenType 55 Spawn Points
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(-1214, -1586, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(-715, -1577, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(-925, -1468, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(978, -1588, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(1502, -1486, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(1806, -1222, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(1817, -802, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(1816, -15, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(1821, -347, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(955, -426, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(1000, -15, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(1201, -119, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(818, -106, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(377, 394, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(94, 509, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(-257, 275, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(-966, 315, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(-1375, -170, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(-1490, -286, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(-979, -13, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(-375, -145, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(-643, -363, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(14, -428, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(90, -296, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(85, -24, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(-117, -747, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(810, -637, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(333, -795, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(128, -678, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(-570, 349, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(-503, -381, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(1808, -1424, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(1219, -1522, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(831, -1469, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(-1299, 47, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(705, -1572, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(452, -555, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(644, -528, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(-635, -149, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(-1125, 272, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(-775, 318, 30));
		AddSpawnPoint("f_castle_101.Id3", "f_castle_101", Rectangle(483, -359, 30));

		// 'Bower_Obstructer' GenType 56 Spawn Points
		AddSpawnPoint("f_castle_101.Id4", "f_castle_101", Rectangle(-1296, -353, 30));
		AddSpawnPoint("f_castle_101.Id4", "f_castle_101", Rectangle(-923, -203, 30));
		AddSpawnPoint("f_castle_101.Id4", "f_castle_101", Rectangle(-815, 423, 30));
		AddSpawnPoint("f_castle_101.Id4", "f_castle_101", Rectangle(-60, 320, 30));
		AddSpawnPoint("f_castle_101.Id4", "f_castle_101", Rectangle(203, 296, 30));
		AddSpawnPoint("f_castle_101.Id4", "f_castle_101", Rectangle(512, 290, 30));
		AddSpawnPoint("f_castle_101.Id4", "f_castle_101", Rectangle(625, -265, 30));
		AddSpawnPoint("f_castle_101.Id4", "f_castle_101", Rectangle(1073, -203, 30));
		AddSpawnPoint("f_castle_101.Id4", "f_castle_101", Rectangle(725, -432, 30));
		AddSpawnPoint("f_castle_101.Id4", "f_castle_101", Rectangle(-434, -508, 30));
		AddSpawnPoint("f_castle_101.Id4", "f_castle_101", Rectangle(-471, -86, 30));
		AddSpawnPoint("f_castle_101.Id4", "f_castle_101", Rectangle(196, -417, 30));
		AddSpawnPoint("f_castle_101.Id4", "f_castle_101", Rectangle(354, -661, 30));
		AddSpawnPoint("f_castle_101.Id4", "f_castle_101", Rectangle(220, -288, 30));
		AddSpawnPoint("f_castle_101.Id4", "f_castle_101", Rectangle(697, -87, 30));
		AddSpawnPoint("f_castle_101.Id4", "f_castle_101", Rectangle(-633, 263, 30));
		AddSpawnPoint("f_castle_101.Id4", "f_castle_101", Rectangle(-403, 297, 30));
		AddSpawnPoint("f_castle_101.Id4", "f_castle_101", Rectangle(-488, -200, 30));
		AddSpawnPoint("f_castle_101.Id4", "f_castle_101", Rectangle(113, 195, 30));
		AddSpawnPoint("f_castle_101.Id4", "f_castle_101", Rectangle(-1035, -151, 30));
		AddSpawnPoint("f_castle_101.Id4", "f_castle_101", Rectangle(-1237, -155, 30));
		AddSpawnPoint("f_castle_101.Id4", "f_castle_101", Rectangle(-1188, 13, 30));
		AddSpawnPoint("f_castle_101.Id4", "f_castle_101", Rectangle(-1550, -350, 30));
		AddSpawnPoint("f_castle_101.Id4", "f_castle_101", Rectangle(-1596, -138, 30));
		AddSpawnPoint("f_castle_101.Id4", "f_castle_101", Rectangle(-685, 357, 30));
		AddSpawnPoint("f_castle_101.Id4", "f_castle_101", Rectangle(537, -489, 30));

		// 'Rootcrystal_01' GenType 57 Spawn Points
		AddSpawnPoint("f_castle_101.Id5", "f_castle_101", Rectangle(293, -1468, 100));
		AddSpawnPoint("f_castle_101.Id5", "f_castle_101", Rectangle(-57, -1542, 100));
		AddSpawnPoint("f_castle_101.Id5", "f_castle_101", Rectangle(-353, -1545, 100));
		AddSpawnPoint("f_castle_101.Id5", "f_castle_101", Rectangle(-716, -1515, 100));
		AddSpawnPoint("f_castle_101.Id5", "f_castle_101", Rectangle(-1129, -1539, 100));
		AddSpawnPoint("f_castle_101.Id5", "f_castle_101", Rectangle(827, -1526, 100));
		AddSpawnPoint("f_castle_101.Id5", "f_castle_101", Rectangle(1237, -1531, 100));
		AddSpawnPoint("f_castle_101.Id5", "f_castle_101", Rectangle(1641, -1517, 100));
		AddSpawnPoint("f_castle_101.Id5", "f_castle_101", Rectangle(1798, -1070, 100));
		AddSpawnPoint("f_castle_101.Id5", "f_castle_101", Rectangle(1767, -566, 100));
		AddSpawnPoint("f_castle_101.Id5", "f_castle_101", Rectangle(1770, -144, 100));
		AddSpawnPoint("f_castle_101.Id5", "f_castle_101", Rectangle(758, -350, 100));
		AddSpawnPoint("f_castle_101.Id5", "f_castle_101", Rectangle(637, -601, 100));
		AddSpawnPoint("f_castle_101.Id5", "f_castle_101", Rectangle(90, -695, 100));
		AddSpawnPoint("f_castle_101.Id5", "f_castle_101", Rectangle(407, -358, 100));
		AddSpawnPoint("f_castle_101.Id5", "f_castle_101", Rectangle(107, 82, 100));
		AddSpawnPoint("f_castle_101.Id5", "f_castle_101", Rectangle(381, 368, 100));
		AddSpawnPoint("f_castle_101.Id5", "f_castle_101", Rectangle(685, 380, 100));
		AddSpawnPoint("f_castle_101.Id5", "f_castle_101", Rectangle(-175, 306, 100));
		AddSpawnPoint("f_castle_101.Id5", "f_castle_101", Rectangle(-495, -386, 100));
		AddSpawnPoint("f_castle_101.Id5", "f_castle_101", Rectangle(-619, 292, 100));
		AddSpawnPoint("f_castle_101.Id5", "f_castle_101", Rectangle(-1101, 285, 100));
		AddSpawnPoint("f_castle_101.Id5", "f_castle_101", Rectangle(-1294, -56, 100));
		AddSpawnPoint("f_castle_101.Id5", "f_castle_101", Rectangle(-1386, -290, 100));
		AddSpawnPoint("f_castle_101.Id5", "f_castle_101", Rectangle(-890, -234, 100));
		AddSpawnPoint("f_castle_101.Id5", "f_castle_101", Rectangle(-1064, -872, 100));
		AddSpawnPoint("f_castle_101.Id5", "f_castle_101", Rectangle(-655, -961, 100));
		AddSpawnPoint("f_castle_101.Id5", "f_castle_101", Rectangle(-238, -765, 100));
		AddSpawnPoint("f_castle_101.Id5", "f_castle_101", Rectangle(697, -80, 100));
		AddSpawnPoint("f_castle_101.Id5", "f_castle_101", Rectangle(1003, -616, 100));
	}
}
