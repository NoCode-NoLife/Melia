//--- Melia Script -----------------------------------------------------------
// Kalejimas Visiting Room Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_prison_78'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DPrison78MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_prison_78", MonsterId.TerraNymph_Brown, Properties("MHP", 407538, "MINPATK", 5741, "MAXPATK", 6958, "MINMATK", 5741, "MAXMATK", 6958, "DEF", 47157, "MDEF", 47157));
		AddPropertyOverrides("d_prison_78", MonsterId.NightMaiden_Mage_Red, Properties("MHP", 409764, "MINPATK", 5770, "MAXPATK", 6994, "MINMATK", 5770, "MAXMATK", 6994, "DEF", 47867, "MDEF", 47867));
		AddPropertyOverrides("d_prison_78", MonsterId.Elet_Blue, Properties("MHP", 412085, "MINPATK", 5800, "MAXPATK", 7030, "MINMATK", 5800, "MAXMATK", 7030, "DEF", 48607, "MDEF", 48607));
		AddPropertyOverrides("d_prison_78", MonsterId.Boss_Mandara_Q1, Properties("MHP", 2113936, "MINPATK", 13994, "MAXPATK", 16964, "MINMATK", 13994, "MAXMATK", 16964, "DEF", 118503, "MDEF", 118503));

		// Monster Spawners ---------------------------------

		AddSpawner("d_prison_78.Id1", MonsterId.TerraNymph_Brown, min: 34, max: 45, tendency: TendencyType.Aggressive);
		AddSpawner("d_prison_78.Id2", MonsterId.NightMaiden_Mage_Red, min: 8, max: 10, tendency: TendencyType.Aggressive);
		AddSpawner("d_prison_78.Id3", MonsterId.Elet_Blue, min: 8, max: 10, tendency: TendencyType.Aggressive);
		AddSpawner("d_prison_78.Id4", MonsterId.Rootcrystal_05, min: 12, max: 15, respawn: TimeSpan.FromMilliseconds(60000), tendency: TendencyType.Peaceful);
		AddSpawner("d_prison_78.Id5", MonsterId.TerraNymph_Brown, min: 27, max: 35, tendency: TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'TerraNymph_Brown' GenType 1 Spawn Points
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(446, -864, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(364, -646, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(525, -751, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(626, -930, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(763, -681, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(620, -636, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(809, -923, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(711, -828, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(761, -610, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(575, 1025, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(571, 1481, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(584, 352, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(771, 255, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(529, 323, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(585, 538, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(183, 797, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(479, 812, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(597, 1099, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(614, 1335, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(407, 1594, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(502, 1982, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(800, 1885, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(659, 1738, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(876, 1550, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(752, 1467, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(-174, 2048, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(-122, 2240, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(-241, 2215, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(125, 1964, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(383, 1885, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(-164, 772, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(-150, 486, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(-367, 884, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(-538, 733, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(-540, 404, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(-725, 225, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(-610, 478, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(-1016, 242, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(-1274, 352, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(-1324, 73, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(-1433, -200, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(-1302, -208, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(-1199, -577, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(-1295, -544, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(-786, -875, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(-815, -1056, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(-589, -897, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(-1692, -1336, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(-1575, -1102, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(-1791, -1248, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(-1263, -1241, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(-854, -1285, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(-224, -971, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(36, -959, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(17, -1120, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(66, -1332, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(35, -1473, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(-20, -1844, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(-32, -1014, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(133, -991, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(374, -969, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(-58, -1588, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(-67, -1739, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(61, -1796, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(149, -1628, 30));
		AddSpawnPoint("d_prison_78.Id1", "d_prison_78", Rectangle(67, -1680, 30));

		// 'NightMaiden_Mage_Red' GenType 2 Spawn Points
		AddSpawnPoint("d_prison_78.Id2", "d_prison_78", Rectangle(432, -829, 30));
		AddSpawnPoint("d_prison_78.Id2", "d_prison_78", Rectangle(608, -913, 30));
		AddSpawnPoint("d_prison_78.Id2", "d_prison_78", Rectangle(646, -624, 30));
		AddSpawnPoint("d_prison_78.Id2", "d_prison_78", Rectangle(430, -680, 30));
		AddSpawnPoint("d_prison_78.Id2", "d_prison_78", Rectangle(735, -802, 30));
		AddSpawnPoint("d_prison_78.Id2", "d_prison_78", Rectangle(766, -969, 30));
		AddSpawnPoint("d_prison_78.Id2", "d_prison_78", Rectangle(829, -725, 30));
		AddSpawnPoint("d_prison_78.Id2", "d_prison_78", Rectangle(559, 274, 30));
		AddSpawnPoint("d_prison_78.Id2", "d_prison_78", Rectangle(710, 454, 30));
		AddSpawnPoint("d_prison_78.Id2", "d_prison_78", Rectangle(509, 410, 30));
		AddSpawnPoint("d_prison_78.Id2", "d_prison_78", Rectangle(677, 274, 30));
		AddSpawnPoint("d_prison_78.Id2", "d_prison_78", Rectangle(813, 438, 30));
		AddSpawnPoint("d_prison_78.Id2", "d_prison_78", Rectangle(-883, -1093, 30));
		AddSpawnPoint("d_prison_78.Id2", "d_prison_78", Rectangle(-823, -875, 30));
		AddSpawnPoint("d_prison_78.Id2", "d_prison_78", Rectangle(-764, -989, 30));
		AddSpawnPoint("d_prison_78.Id2", "d_prison_78", Rectangle(-600, -888, 30));
		AddSpawnPoint("d_prison_78.Id2", "d_prison_78", Rectangle(-556, -992, 30));
		AddSpawnPoint("d_prison_78.Id2", "d_prison_78", Rectangle(-470, -863, 30));
		AddSpawnPoint("d_prison_78.Id2", "d_prison_78", Rectangle(414, -957, 30));
		AddSpawnPoint("d_prison_78.Id2", "d_prison_78", Rectangle(86, -1387, 30));
		AddSpawnPoint("d_prison_78.Id2", "d_prison_78", Rectangle(-46, -1355, 30));
		AddSpawnPoint("d_prison_78.Id2", "d_prison_78", Rectangle(-79, -1454, 30));
		AddSpawnPoint("d_prison_78.Id2", "d_prison_78", Rectangle(7, -1440, 30));
		AddSpawnPoint("d_prison_78.Id2", "d_prison_78", Rectangle(28, -1298, 30));
		AddSpawnPoint("d_prison_78.Id2", "d_prison_78", Rectangle(10, -1673, 30));
		AddSpawnPoint("d_prison_78.Id2", "d_prison_78", Rectangle(135, -1657, 30));
		AddSpawnPoint("d_prison_78.Id2", "d_prison_78", Rectangle(61, -1855, 30));
		AddSpawnPoint("d_prison_78.Id2", "d_prison_78", Rectangle(-51, -1784, 30));
		AddSpawnPoint("d_prison_78.Id2", "d_prison_78", Rectangle(-72, -1657, 30));
		AddSpawnPoint("d_prison_78.Id2", "d_prison_78", Rectangle(-70, -1533, 30));

		// 'Elet_Blue' GenType 3 Spawn Points
		AddSpawnPoint("d_prison_78.Id3", "d_prison_78", Rectangle(402, 1589, 30));
		AddSpawnPoint("d_prison_78.Id3", "d_prison_78", Rectangle(380, 1854, 30));
		AddSpawnPoint("d_prison_78.Id3", "d_prison_78", Rectangle(714, 1971, 30));
		AddSpawnPoint("d_prison_78.Id3", "d_prison_78", Rectangle(604, 1752, 30));
		AddSpawnPoint("d_prison_78.Id3", "d_prison_78", Rectangle(650, 1565, 30));
		AddSpawnPoint("d_prison_78.Id3", "d_prison_78", Rectangle(806, 1505, 30));
		AddSpawnPoint("d_prison_78.Id3", "d_prison_78", Rectangle(896, 1792, 30));
		AddSpawnPoint("d_prison_78.Id3", "d_prison_78", Rectangle(-186, 2062, 30));
		AddSpawnPoint("d_prison_78.Id3", "d_prison_78", Rectangle(-121, 2323, 30));
		AddSpawnPoint("d_prison_78.Id3", "d_prison_78", Rectangle(-274, 2231, 30));
		AddSpawnPoint("d_prison_78.Id3", "d_prison_78", Rectangle(-136, 2168, 30));
		AddSpawnPoint("d_prison_78.Id3", "d_prison_78", Rectangle(81, 1950, 30));
		AddSpawnPoint("d_prison_78.Id3", "d_prison_78", Rectangle(90, 815, 30));
		AddSpawnPoint("d_prison_78.Id3", "d_prison_78", Rectangle(437, 848, 30));
		AddSpawnPoint("d_prison_78.Id3", "d_prison_78", Rectangle(576, 770, 30));
		AddSpawnPoint("d_prison_78.Id3", "d_prison_78", Rectangle(621, 1134, 30));
		AddSpawnPoint("d_prison_78.Id3", "d_prison_78", Rectangle(605, 1360, 30));
		AddSpawnPoint("d_prison_78.Id3", "d_prison_78", Rectangle(620, 846, 30));
		AddSpawnPoint("d_prison_78.Id3", "d_prison_78", Rectangle(570, 496, 30));
		AddSpawnPoint("d_prison_78.Id3", "d_prison_78", Rectangle(507, 327, 30));
		AddSpawnPoint("d_prison_78.Id3", "d_prison_78", Rectangle(682, 246, 30));
		AddSpawnPoint("d_prison_78.Id3", "d_prison_78", Rectangle(778, 546, 30));
		AddSpawnPoint("d_prison_78.Id3", "d_prison_78", Rectangle(798, 341, 30));
		AddSpawnPoint("d_prison_78.Id3", "d_prison_78", Rectangle(-697, 266, 30));
		AddSpawnPoint("d_prison_78.Id3", "d_prison_78", Rectangle(-637, 395, 30));
		AddSpawnPoint("d_prison_78.Id3", "d_prison_78", Rectangle(-598, 286, 30));
		AddSpawnPoint("d_prison_78.Id3", "d_prison_78", Rectangle(-550, 655, 30));
		AddSpawnPoint("d_prison_78.Id3", "d_prison_78", Rectangle(-486, 851, 30));
		AddSpawnPoint("d_prison_78.Id3", "d_prison_78", Rectangle(-211, 864, 30));
		AddSpawnPoint("d_prison_78.Id3", "d_prison_78", Rectangle(319, 805, 30));
		AddSpawnPoint("d_prison_78.Id3", "d_prison_78", Rectangle(-192, 553, 30));
		AddSpawnPoint("d_prison_78.Id3", "d_prison_78", Rectangle(289, 826, 30));

		// 'Rootcrystal_05' GenType 7 Spawn Points
		AddSpawnPoint("d_prison_78.Id4", "d_prison_78", Rectangle(493, -861, 90));
		AddSpawnPoint("d_prison_78.Id4", "d_prison_78", Rectangle(693, -669, 90));
		AddSpawnPoint("d_prison_78.Id4", "d_prison_78", Rectangle(1084, -960, 90));
		AddSpawnPoint("d_prison_78.Id4", "d_prison_78", Rectangle(757, 231, 90));
		AddSpawnPoint("d_prison_78.Id4", "d_prison_78", Rectangle(572, 268, 90));
		AddSpawnPoint("d_prison_78.Id4", "d_prison_78", Rectangle(632, 461, 90));
		AddSpawnPoint("d_prison_78.Id4", "d_prison_78", Rectangle(573, 831, 90));
		AddSpawnPoint("d_prison_78.Id4", "d_prison_78", Rectangle(69, 816, 90));
		AddSpawnPoint("d_prison_78.Id4", "d_prison_78", Rectangle(418, 1566, 90));
		AddSpawnPoint("d_prison_78.Id4", "d_prison_78", Rectangle(403, 1864, 90));
		AddSpawnPoint("d_prison_78.Id4", "d_prison_78", Rectangle(824, 1684, 90));
		AddSpawnPoint("d_prison_78.Id4", "d_prison_78", Rectangle(802, 1870, 90));
		AddSpawnPoint("d_prison_78.Id4", "d_prison_78", Rectangle(-216, 2034, 90));
		AddSpawnPoint("d_prison_78.Id4", "d_prison_78", Rectangle(-955, 2372, 90));
		AddSpawnPoint("d_prison_78.Id4", "d_prison_78", Rectangle(-1179, 2363, 90));
		AddSpawnPoint("d_prison_78.Id4", "d_prison_78", Rectangle(-225, 584, 90));
		AddSpawnPoint("d_prison_78.Id4", "d_prison_78", Rectangle(-560, 428, 90));
		AddSpawnPoint("d_prison_78.Id4", "d_prison_78", Rectangle(-1009, 237, 90));
		AddSpawnPoint("d_prison_78.Id4", "d_prison_78", Rectangle(-1418, -189, 90));
		AddSpawnPoint("d_prison_78.Id4", "d_prison_78", Rectangle(-1300, -9, 90));
		AddSpawnPoint("d_prison_78.Id4", "d_prison_78", Rectangle(-1165, -609, 90));
		AddSpawnPoint("d_prison_78.Id4", "d_prison_78", Rectangle(-717, -953, 90));
		AddSpawnPoint("d_prison_78.Id4", "d_prison_78", Rectangle(-526, -849, 90));
		AddSpawnPoint("d_prison_78.Id4", "d_prison_78", Rectangle(-1202, -1248, 90));
		AddSpawnPoint("d_prison_78.Id4", "d_prison_78", Rectangle(-1543, -1361, 90));
		AddSpawnPoint("d_prison_78.Id4", "d_prison_78", Rectangle(-1555, -1114, 90));
		AddSpawnPoint("d_prison_78.Id4", "d_prison_78", Rectangle(293, -1361, 90));
		AddSpawnPoint("d_prison_78.Id4", "d_prison_78", Rectangle(72, -1408, 90));
		AddSpawnPoint("d_prison_78.Id4", "d_prison_78", Rectangle(122, -1705, 90));
		AddSpawnPoint("d_prison_78.Id4", "d_prison_78", Rectangle(-272, 2276, 90));

		// 'TerraNymph_Brown' GenType 13 Spawn Points
		AddSpawnPoint("d_prison_78.Id5", "d_prison_78", Rectangle(637, 215, 9999));
	}
}
