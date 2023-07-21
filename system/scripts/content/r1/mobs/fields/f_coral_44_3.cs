//--- Melia Script -----------------------------------------------------------
// Epherotao Coast Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_coral_44_3'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FCoral443MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_coral_44_3.Id1", MonsterId.VarleAnchor, min: 38, max: 50, tendency: TendencyType.Aggressive);
		AddSpawner("f_coral_44_3.Id2", MonsterId.VarleSkipper, min: 27, max: 35, tendency: TendencyType.Aggressive);
		AddSpawner("f_coral_44_3.Id3", MonsterId.VarleHenchman, min: 6, max: 8, tendency: TendencyType.Aggressive);
		AddSpawner("f_coral_44_3.Id4", MonsterId.VarleHelmsman, min: 27, max: 35, tendency: TendencyType.Aggressive);
		AddSpawner("f_coral_44_3.Id5", MonsterId.NimrahPricker, min: 4, max: 5, tendency: TendencyType.Aggressive);
		AddSpawner("f_coral_44_3.Id6", MonsterId.Rootcrystal_03, min: 23, max: 30, respawn: TimeSpan.FromMilliseconds(30000), tendency: TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'VarleAnchor' GenType 23 Spawn Points
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-757, 484, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-632, 517, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-610, 205, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-603, 324, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-476, 430, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-375, 551, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-312, 476, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-89, 723, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-148, 839, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-2, 826, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-85, 955, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(76, 880, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(47, 1022, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(108, 1184, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(609, 384, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(545, 248, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(727, 304, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(582, 158, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(714, 108, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(859, 121, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-895, 221, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-972, 120, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-1026, -111, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-908, -94, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-568, -51, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(638, 260, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(64, 1274, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(74, 1402, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(124, 1058, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(1275, -617, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(1184, -526, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(1192, -414, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(1270, -337, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(804, -675, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(721, -592, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(914, -158, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-1536, -82, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-1546, 3, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-1342, -65, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-1044, 11, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-795, 2, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-719, 248, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-235, 660, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-464, -78, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-153, -271, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-54, 8, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(584, -531, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(1129, -466, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(843, -265, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(963, 60, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(901, -542, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(899, -23, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(4, -147, 40));

		// 'VarleSkipper' GenType 24 Spawn Points
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(-694, 378, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(-764, 244, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(-801, 92, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(-674, 110, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(-987, 18, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(791, -85, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(816, 6, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(925, -67, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(854, -237, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(931, -273, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(978, 43, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(1156, 140, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(1347, 166, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(1346, 263, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(1486, 165, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(1476, 390, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(1562, 309, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(-1109, 5, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(-1310, -74, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(-1447, -124, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(-1431, -6, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(-1532, 95, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(-1648, -42, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(-1719, 45, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(-485, -159, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(1275, -238, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(1366, -62, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(1306, -151, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(1302, -522, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(1360, -398, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(1483, -654, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(1584, -705, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(1059, -524, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(952, -508, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(-183, -215, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(-148, -62, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(-904, -502, 40));

		// 'VarleHenchman' GenType 25 Spawn Points
		AddSpawnPoint("f_coral_44_3.Id3", "f_coral_44_3", Rectangle(-697, 207, 40));
		AddSpawnPoint("f_coral_44_3.Id3", "f_coral_44_3", Rectangle(882, 46, 40));
		AddSpawnPoint("f_coral_44_3.Id3", "f_coral_44_3", Rectangle(1269, 199, 40));
		AddSpawnPoint("f_coral_44_3.Id3", "f_coral_44_3", Rectangle(3, -276, 40));
		AddSpawnPoint("f_coral_44_3.Id3", "f_coral_44_3", Rectangle(1236, -476, 40));
		AddSpawnPoint("f_coral_44_3.Id3", "f_coral_44_3", Rectangle(1370, -228, 40));
		AddSpawnPoint("f_coral_44_3.Id3", "f_coral_44_3", Rectangle(58, -726, 40));
		AddSpawnPoint("f_coral_44_3.Id3", "f_coral_44_3", Rectangle(-990, -516, 40));
		AddSpawnPoint("f_coral_44_3.Id3", "f_coral_44_3", Rectangle(-1621, 78, 40));
		AddSpawnPoint("f_coral_44_3.Id3", "f_coral_44_3", Rectangle(70, 1347, 40));

		// 'VarleHelmsman' GenType 26 Spawn Points
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(-41, -154, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(-119, -328, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(-2, -49, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(117, -6, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(174, -150, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(82, -185, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(161, -300, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(161, -411, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(324, -482, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(536, -545, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(618, -649, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(744, -729, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(853, -869, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(1375, -613, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(1663, -675, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(1882, -557, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(1550, -162, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(1804, -576, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(-175, -777, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(-72, -858, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(46, -824, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(-72, -706, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(-887, -571, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(-936, -429, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(-1076, -577, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(-1100, -463, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(-1196, -430, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(-1358, -477, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(58, -352, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(42, -913, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(967, -974, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(1685, -247, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(-209, -687, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(-178, -600, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(-246, -862, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(-58, 26, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(-1182, -516, 40));

		// 'NimrahPricker' GenType 27 Spawn Points
		AddSpawnPoint("f_coral_44_3.Id5", "f_coral_44_3", Rectangle(-9, 899, 40));
		AddSpawnPoint("f_coral_44_3.Id5", "f_coral_44_3", Rectangle(-16, -821, 40));
		AddSpawnPoint("f_coral_44_3.Id5", "f_coral_44_3", Rectangle(1259, 176, 40));
		AddSpawnPoint("f_coral_44_3.Id5", "f_coral_44_3", Rectangle(734, 202, 40));
		AddSpawnPoint("f_coral_44_3.Id5", "f_coral_44_3", Rectangle(699, -661, 40));

		// 'Rootcrystal_03' GenType 32 Spawn Points
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(-756, 446, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(-1030, 18, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(-653, 126, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(-591, 468, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(-268, 491, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(-129, 803, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(47, 1008, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(619, 320, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(712, 119, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(858, -176, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(938, 78, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(1224, 184, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(1554, 272, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(1361, -175, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(1603, -305, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(1459, -445, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(1327, -556, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(1622, -573, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(801, -633, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(612, -627, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(223, -427, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(237, -155, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(77, -285, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(-6, -158, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(-147, -713, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(30, -860, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(-1234, -469, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(-958, -468, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(-1538, 23, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(-1301, -22, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(-941, 142, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(-647, 176, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(-751, 492, 40));
	}
}
