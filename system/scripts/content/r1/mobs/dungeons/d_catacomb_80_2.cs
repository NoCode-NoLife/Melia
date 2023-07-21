//--- Melia Script -----------------------------------------------------------
// Balaam Camp Site Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_catacomb_80_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DCatacomb802MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("d_catacomb_80_2.Id1", MonsterId.ERD_Yognome_Yellow, min: 9, max: 12, tendency: TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_2.Id2", MonsterId.ERD_Moya, min: 14, max: 18, tendency: TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_2.Id3", MonsterId.ERD_Mushroom_Boy_Green, min: 14, max: 18, tendency: TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_2.Id4", MonsterId.ERD_Mirtislampa, min: 30, max: 40, tendency: TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_2.Id5", MonsterId.ERD_Infroholder_Mage_Green, min: 12, max: 16, tendency: TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_2.Id6", MonsterId.ERD_NightMaiden_Bow_Red, min: 12, max: 16, tendency: TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_2.Id7", MonsterId.ERD_Gazing_Golem_Yellow, min: 9, max: 12, tendency: TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_2.Id8", MonsterId.ERD_Egnome_Yellow, min: 4, max: 5, tendency: TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_2.Id9", MonsterId.ERD_Wendigo_Archer_Blue, min: 15, max: 20, tendency: TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_2.Id10", MonsterId.ERD_Wendigo_Magician_Blue, min: 15, max: 20, tendency: TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_2.Id11", MonsterId.ERD_Kepari_Mage, min: 12, max: 16, tendency: TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_2.Id12", MonsterId.ERD_Mushroom_Ent_Green, min: 4, max: 5, tendency: TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_2.Id13", MonsterId.Rootcrystal_05, min: 15, max: 20, respawn: TimeSpan.FromMilliseconds(20000), tendency: TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'ERD_Yognome_Yellow' GenType 8 Spawn Points
		AddSpawnPoint("d_catacomb_80_2.Id1", "d_catacomb_80_2", Rectangle(-63, -1630, 25));
		AddSpawnPoint("d_catacomb_80_2.Id1", "d_catacomb_80_2", Rectangle(91, -1796, 25));
		AddSpawnPoint("d_catacomb_80_2.Id1", "d_catacomb_80_2", Rectangle(76, -1600, 25));
		AddSpawnPoint("d_catacomb_80_2.Id1", "d_catacomb_80_2", Rectangle(-135, -774, 25));
		AddSpawnPoint("d_catacomb_80_2.Id1", "d_catacomb_80_2", Rectangle(-119, -1062, 25));
		AddSpawnPoint("d_catacomb_80_2.Id1", "d_catacomb_80_2", Rectangle(224, -1102, 25));
		AddSpawnPoint("d_catacomb_80_2.Id1", "d_catacomb_80_2", Rectangle(191, -739, 25));
		AddSpawnPoint("d_catacomb_80_2.Id1", "d_catacomb_80_2", Rectangle(175, -914, 25));
		AddSpawnPoint("d_catacomb_80_2.Id1", "d_catacomb_80_2", Rectangle(-1655, -734, 25));
		AddSpawnPoint("d_catacomb_80_2.Id1", "d_catacomb_80_2", Rectangle(-1655, -1105, 25));
		AddSpawnPoint("d_catacomb_80_2.Id1", "d_catacomb_80_2", Rectangle(1560, -704, 25));
		AddSpawnPoint("d_catacomb_80_2.Id1", "d_catacomb_80_2", Rectangle(1729, -1095, 25));
		AddSpawnPoint("d_catacomb_80_2.Id1", "d_catacomb_80_2", Rectangle(-1866, -1037, 25));
		AddSpawnPoint("d_catacomb_80_2.Id1", "d_catacomb_80_2", Rectangle(-1470, -846, 25));
		AddSpawnPoint("d_catacomb_80_2.Id1", "d_catacomb_80_2", Rectangle(1445, -1013, 25));
		AddSpawnPoint("d_catacomb_80_2.Id1", "d_catacomb_80_2", Rectangle(1745, -822, 25));
		AddSpawnPoint("d_catacomb_80_2.Id1", "d_catacomb_80_2", Rectangle(-820, -985, 25));
		AddSpawnPoint("d_catacomb_80_2.Id1", "d_catacomb_80_2", Rectangle(-673, -880, 25));
		AddSpawnPoint("d_catacomb_80_2.Id1", "d_catacomb_80_2", Rectangle(733, -978, 25));
		AddSpawnPoint("d_catacomb_80_2.Id1", "d_catacomb_80_2", Rectangle(897, -836, 25));
		AddSpawnPoint("d_catacomb_80_2.Id1", "d_catacomb_80_2", Rectangle(-1462, -1094, 25));

		// 'ERD_Moya' GenType 9 Spawn Points
		AddSpawnPoint("d_catacomb_80_2.Id2", "d_catacomb_80_2", Rectangle(-50, -1760, 30));
		AddSpawnPoint("d_catacomb_80_2.Id2", "d_catacomb_80_2", Rectangle(3, -1526, 30));
		AddSpawnPoint("d_catacomb_80_2.Id2", "d_catacomb_80_2", Rectangle(-203, -934, 30));
		AddSpawnPoint("d_catacomb_80_2.Id2", "d_catacomb_80_2", Rectangle(74, -1127, 30));
		AddSpawnPoint("d_catacomb_80_2.Id2", "d_catacomb_80_2", Rectangle(-411, -938, 30));
		AddSpawnPoint("d_catacomb_80_2.Id2", "d_catacomb_80_2", Rectangle(473, -902, 30));
		AddSpawnPoint("d_catacomb_80_2.Id2", "d_catacomb_80_2", Rectangle(19, -769, 30));
		AddSpawnPoint("d_catacomb_80_2.Id2", "d_catacomb_80_2", Rectangle(1, -1016, 30));
		AddSpawnPoint("d_catacomb_80_2.Id2", "d_catacomb_80_2", Rectangle(-1456, -765, 30));
		AddSpawnPoint("d_catacomb_80_2.Id2", "d_catacomb_80_2", Rectangle(1510, -954, 30));
		AddSpawnPoint("d_catacomb_80_2.Id2", "d_catacomb_80_2", Rectangle(230, -1047, 30));
		AddSpawnPoint("d_catacomb_80_2.Id2", "d_catacomb_80_2", Rectangle(235, -744, 30));
		AddSpawnPoint("d_catacomb_80_2.Id2", "d_catacomb_80_2", Rectangle(127, -1715, 30));
		AddSpawnPoint("d_catacomb_80_2.Id2", "d_catacomb_80_2", Rectangle(687, -913, 30));
		AddSpawnPoint("d_catacomb_80_2.Id2", "d_catacomb_80_2", Rectangle(-618, -923, 30));
		AddSpawnPoint("d_catacomb_80_2.Id2", "d_catacomb_80_2", Rectangle(-1434, -1010, 30));
		AddSpawnPoint("d_catacomb_80_2.Id2", "d_catacomb_80_2", Rectangle(1414, -728, 30));
		AddSpawnPoint("d_catacomb_80_2.Id2", "d_catacomb_80_2", Rectangle(1766, -945, 30));
		AddSpawnPoint("d_catacomb_80_2.Id2", "d_catacomb_80_2", Rectangle(-1753, -972, 30));

		// 'ERD_Mushroom_Boy_Green' GenType 10 Spawn Points
		AddSpawnPoint("d_catacomb_80_2.Id3", "d_catacomb_80_2", Rectangle(9, -906, 25));
		AddSpawnPoint("d_catacomb_80_2.Id3", "d_catacomb_80_2", Rectangle(165, -1690, 25));
		AddSpawnPoint("d_catacomb_80_2.Id3", "d_catacomb_80_2", Rectangle(-831, -802, 25));
		AddSpawnPoint("d_catacomb_80_2.Id3", "d_catacomb_80_2", Rectangle(-780, -1033, 25));
		AddSpawnPoint("d_catacomb_80_2.Id3", "d_catacomb_80_2", Rectangle(806, -783, 25));
		AddSpawnPoint("d_catacomb_80_2.Id3", "d_catacomb_80_2", Rectangle(835, -1046, 25));
		AddSpawnPoint("d_catacomb_80_2.Id3", "d_catacomb_80_2", Rectangle(-1200, -906, 25));
		AddSpawnPoint("d_catacomb_80_2.Id3", "d_catacomb_80_2", Rectangle(1128, -909, 25));
		AddSpawnPoint("d_catacomb_80_2.Id3", "d_catacomb_80_2", Rectangle(1389, -897, 25));
		AddSpawnPoint("d_catacomb_80_2.Id3", "d_catacomb_80_2", Rectangle(1577, -1117, 25));
		AddSpawnPoint("d_catacomb_80_2.Id3", "d_catacomb_80_2", Rectangle(-1481, -920, 25));
		AddSpawnPoint("d_catacomb_80_2.Id3", "d_catacomb_80_2", Rectangle(-1849, -919, 25));
		AddSpawnPoint("d_catacomb_80_2.Id3", "d_catacomb_80_2", Rectangle(1667, -779, 25));
		AddSpawnPoint("d_catacomb_80_2.Id3", "d_catacomb_80_2", Rectangle(1803, -1013, 25));
		AddSpawnPoint("d_catacomb_80_2.Id3", "d_catacomb_80_2", Rectangle(-1703, -1069, 25));
		AddSpawnPoint("d_catacomb_80_2.Id3", "d_catacomb_80_2", Rectangle(-1565, -765, 25));
		AddSpawnPoint("d_catacomb_80_2.Id3", "d_catacomb_80_2", Rectangle(707, -891, 25));
		AddSpawnPoint("d_catacomb_80_2.Id3", "d_catacomb_80_2", Rectangle(956, -993, 25));
		AddSpawnPoint("d_catacomb_80_2.Id3", "d_catacomb_80_2", Rectangle(1314, -889, 25));
		AddSpawnPoint("d_catacomb_80_2.Id3", "d_catacomb_80_2", Rectangle(1537, -813, 25));
		AddSpawnPoint("d_catacomb_80_2.Id3", "d_catacomb_80_2", Rectangle(1427, -1086, 25));
		AddSpawnPoint("d_catacomb_80_2.Id3", "d_catacomb_80_2", Rectangle(1815, -872, 25));
		AddSpawnPoint("d_catacomb_80_2.Id3", "d_catacomb_80_2", Rectangle(-631, -877, 25));
		AddSpawnPoint("d_catacomb_80_2.Id3", "d_catacomb_80_2", Rectangle(-880, -1016, 25));
		AddSpawnPoint("d_catacomb_80_2.Id3", "d_catacomb_80_2", Rectangle(-1424, -859, 25));
		AddSpawnPoint("d_catacomb_80_2.Id3", "d_catacomb_80_2", Rectangle(-1570, -1048, 25));
		AddSpawnPoint("d_catacomb_80_2.Id3", "d_catacomb_80_2", Rectangle(-1743, -720, 25));
		AddSpawnPoint("d_catacomb_80_2.Id3", "d_catacomb_80_2", Rectangle(-61, -1701, 25));
		AddSpawnPoint("d_catacomb_80_2.Id3", "d_catacomb_80_2", Rectangle(163, -862, 25));

		// 'ERD_Mirtislampa' GenType 11 Spawn Points
		AddSpawnPoint("d_catacomb_80_2.Id4", "d_catacomb_80_2", Rectangle(-739, -942, 200));
		AddSpawnPoint("d_catacomb_80_2.Id4", "d_catacomb_80_2", Rectangle(-1638, -929, 200));
		AddSpawnPoint("d_catacomb_80_2.Id4", "d_catacomb_80_2", Rectangle(859, -910, 200));
		AddSpawnPoint("d_catacomb_80_2.Id4", "d_catacomb_80_2", Rectangle(1599, -922, 200));
		AddSpawnPoint("d_catacomb_80_2.Id4", "d_catacomb_80_2", Rectangle(1670, 154, 200));
		AddSpawnPoint("d_catacomb_80_2.Id4", "d_catacomb_80_2", Rectangle(-1612, 140, 200));
		AddSpawnPoint("d_catacomb_80_2.Id4", "d_catacomb_80_2", Rectangle(-1614, 999, 200));
		AddSpawnPoint("d_catacomb_80_2.Id4", "d_catacomb_80_2", Rectangle(1643, 985, 200));
		AddSpawnPoint("d_catacomb_80_2.Id4", "d_catacomb_80_2", Rectangle(849, 1017, 200));
		AddSpawnPoint("d_catacomb_80_2.Id4", "d_catacomb_80_2", Rectangle(-898, 1015, 200));
		AddSpawnPoint("d_catacomb_80_2.Id4", "d_catacomb_80_2", Rectangle(39, -931, 200));
		AddSpawnPoint("d_catacomb_80_2.Id4", "d_catacomb_80_2", Rectangle(-102, 1790, 200));

		// 'ERD_Infroholder_Mage_Green' GenType 12 Spawn Points
		AddSpawnPoint("d_catacomb_80_2.Id5", "d_catacomb_80_2", Rectangle(-1504, -1137, 30));
		AddSpawnPoint("d_catacomb_80_2.Id5", "d_catacomb_80_2", Rectangle(-1787, -784, 30));
		AddSpawnPoint("d_catacomb_80_2.Id5", "d_catacomb_80_2", Rectangle(1427, -1093, 30));
		AddSpawnPoint("d_catacomb_80_2.Id5", "d_catacomb_80_2", Rectangle(1760, -750, 30));
		AddSpawnPoint("d_catacomb_80_2.Id5", "d_catacomb_80_2", Rectangle(1616, -566, 30));
		AddSpawnPoint("d_catacomb_80_2.Id5", "d_catacomb_80_2", Rectangle(-1682, -561, 30));
		AddSpawnPoint("d_catacomb_80_2.Id5", "d_catacomb_80_2", Rectangle(-1788, -1040, 30));
		AddSpawnPoint("d_catacomb_80_2.Id5", "d_catacomb_80_2", Rectangle(1400, -798, 30));
		AddSpawnPoint("d_catacomb_80_2.Id5", "d_catacomb_80_2", Rectangle(1628, -985, 30));
		AddSpawnPoint("d_catacomb_80_2.Id5", "d_catacomb_80_2", Rectangle(-1370, -882, 30));
		AddSpawnPoint("d_catacomb_80_2.Id5", "d_catacomb_80_2", Rectangle(-1553, -834, 30));
		AddSpawnPoint("d_catacomb_80_2.Id5", "d_catacomb_80_2", Rectangle(1665, -875, 30));
		AddSpawnPoint("d_catacomb_80_2.Id5", "d_catacomb_80_2", Rectangle(1363, -929, 30));
		AddSpawnPoint("d_catacomb_80_2.Id5", "d_catacomb_80_2", Rectangle(-1791, -897, 30));
		AddSpawnPoint("d_catacomb_80_2.Id5", "d_catacomb_80_2", Rectangle(-1511, -683, 30));
		AddSpawnPoint("d_catacomb_80_2.Id5", "d_catacomb_80_2", Rectangle(1469, -861, 30));

		// 'ERD_NightMaiden_Bow_Red' GenType 13 Spawn Points
		AddSpawnPoint("d_catacomb_80_2.Id6", "d_catacomb_80_2", Rectangle(-870, -993, 40));
		AddSpawnPoint("d_catacomb_80_2.Id6", "d_catacomb_80_2", Rectangle(969, -806, 40));
		AddSpawnPoint("d_catacomb_80_2.Id6", "d_catacomb_80_2", Rectangle(-1764, 5, 40));
		AddSpawnPoint("d_catacomb_80_2.Id6", "d_catacomb_80_2", Rectangle(-1472, 288, 40));
		AddSpawnPoint("d_catacomb_80_2.Id6", "d_catacomb_80_2", Rectangle(1491, -49, 40));
		AddSpawnPoint("d_catacomb_80_2.Id6", "d_catacomb_80_2", Rectangle(1435, 279, 40));
		AddSpawnPoint("d_catacomb_80_2.Id6", "d_catacomb_80_2", Rectangle(-1691, -404, 40));
		AddSpawnPoint("d_catacomb_80_2.Id6", "d_catacomb_80_2", Rectangle(1613, -417, 40));
		AddSpawnPoint("d_catacomb_80_2.Id6", "d_catacomb_80_2", Rectangle(1835, 127, 40));
		AddSpawnPoint("d_catacomb_80_2.Id6", "d_catacomb_80_2", Rectangle(-1754, 243, 40));
		AddSpawnPoint("d_catacomb_80_2.Id6", "d_catacomb_80_2", Rectangle(1265, 317, 40));
		AddSpawnPoint("d_catacomb_80_2.Id6", "d_catacomb_80_2", Rectangle(1237, 64, 40));
		AddSpawnPoint("d_catacomb_80_2.Id6", "d_catacomb_80_2", Rectangle(1398, -79, 40));
		AddSpawnPoint("d_catacomb_80_2.Id6", "d_catacomb_80_2", Rectangle(1910, 306, 40));
		AddSpawnPoint("d_catacomb_80_2.Id6", "d_catacomb_80_2", Rectangle(1836, 1, 40));
		AddSpawnPoint("d_catacomb_80_2.Id6", "d_catacomb_80_2", Rectangle(-1310, 289, 40));
		AddSpawnPoint("d_catacomb_80_2.Id6", "d_catacomb_80_2", Rectangle(-1410, -35, 40));
		AddSpawnPoint("d_catacomb_80_2.Id6", "d_catacomb_80_2", Rectangle(-1930, 324, 40));
		AddSpawnPoint("d_catacomb_80_2.Id6", "d_catacomb_80_2", Rectangle(-1935, 39, 40));
		AddSpawnPoint("d_catacomb_80_2.Id6", "d_catacomb_80_2", Rectangle(-1519, 77, 40));

		// 'ERD_Gazing_Golem_Yellow' GenType 14 Spawn Points
		AddSpawnPoint("d_catacomb_80_2.Id7", "d_catacomb_80_2", Rectangle(-1434, -28, 20));
		AddSpawnPoint("d_catacomb_80_2.Id7", "d_catacomb_80_2", Rectangle(-1331, 61, 20));
		AddSpawnPoint("d_catacomb_80_2.Id7", "d_catacomb_80_2", Rectangle(-1900, 191, 20));
		AddSpawnPoint("d_catacomb_80_2.Id7", "d_catacomb_80_2", Rectangle(1413, 107, 20));
		AddSpawnPoint("d_catacomb_80_2.Id7", "d_catacomb_80_2", Rectangle(1767, -30, 20));
		AddSpawnPoint("d_catacomb_80_2.Id7", "d_catacomb_80_2", Rectangle(1774, 281, 20));
		AddSpawnPoint("d_catacomb_80_2.Id7", "d_catacomb_80_2", Rectangle(1623, 507, 20));
		AddSpawnPoint("d_catacomb_80_2.Id7", "d_catacomb_80_2", Rectangle(-1636, 498, 20));
		AddSpawnPoint("d_catacomb_80_2.Id7", "d_catacomb_80_2", Rectangle(1302, -38, 20));
		AddSpawnPoint("d_catacomb_80_2.Id7", "d_catacomb_80_2", Rectangle(1328, 199, 20));
		AddSpawnPoint("d_catacomb_80_2.Id7", "d_catacomb_80_2", Rectangle(-1783, 322, 20));
		AddSpawnPoint("d_catacomb_80_2.Id7", "d_catacomb_80_2", Rectangle(-1873, 75, 20));
		AddSpawnPoint("d_catacomb_80_2.Id7", "d_catacomb_80_2", Rectangle(-1642, 144, 20));
		AddSpawnPoint("d_catacomb_80_2.Id7", "d_catacomb_80_2", Rectangle(1625, 179, 20));

		// 'ERD_Egnome_Yellow' GenType 15 Spawn Points
		AddSpawnPoint("d_catacomb_80_2.Id8", "d_catacomb_80_2", Rectangle(-1205, 142, 40));
		AddSpawnPoint("d_catacomb_80_2.Id8", "d_catacomb_80_2", Rectangle(1174, 141, 40));
		AddSpawnPoint("d_catacomb_80_2.Id8", "d_catacomb_80_2", Rectangle(619, 1039, 40));
		AddSpawnPoint("d_catacomb_80_2.Id8", "d_catacomb_80_2", Rectangle(-694, 990, 40));
		AddSpawnPoint("d_catacomb_80_2.Id8", "d_catacomb_80_2", Rectangle(-152, 1737, 40));
		AddSpawnPoint("d_catacomb_80_2.Id8", "d_catacomb_80_2", Rectangle(-1539, -840, 40));
		AddSpawnPoint("d_catacomb_80_2.Id8", "d_catacomb_80_2", Rectangle(1666, -1064, 40));

		// 'ERD_Wendigo_Archer_Blue' GenType 16 Spawn Points
		AddSpawnPoint("d_catacomb_80_2.Id9", "d_catacomb_80_2", Rectangle(-1681, 888, 20));
		AddSpawnPoint("d_catacomb_80_2.Id9", "d_catacomb_80_2", Rectangle(-1718, 1100, 20));
		AddSpawnPoint("d_catacomb_80_2.Id9", "d_catacomb_80_2", Rectangle(1643, 1106, 20));
		AddSpawnPoint("d_catacomb_80_2.Id9", "d_catacomb_80_2", Rectangle(1607, 859, 20));
		AddSpawnPoint("d_catacomb_80_2.Id9", "d_catacomb_80_2", Rectangle(1693, 268, 20));
		AddSpawnPoint("d_catacomb_80_2.Id9", "d_catacomb_80_2", Rectangle(1633, 39, 20));
		AddSpawnPoint("d_catacomb_80_2.Id9", "d_catacomb_80_2", Rectangle(-1631, 31, 20));
		AddSpawnPoint("d_catacomb_80_2.Id9", "d_catacomb_80_2", Rectangle(-1383, 243, 20));
		AddSpawnPoint("d_catacomb_80_2.Id9", "d_catacomb_80_2", Rectangle(-1525, 1002, 20));
		AddSpawnPoint("d_catacomb_80_2.Id9", "d_catacomb_80_2", Rectangle(1493, 1024, 20));
		AddSpawnPoint("d_catacomb_80_2.Id9", "d_catacomb_80_2", Rectangle(687, 1142, 20));
		AddSpawnPoint("d_catacomb_80_2.Id9", "d_catacomb_80_2", Rectangle(-784, 894, 20));
		AddSpawnPoint("d_catacomb_80_2.Id9", "d_catacomb_80_2", Rectangle(-322, 1759, 20));
		AddSpawnPoint("d_catacomb_80_2.Id9", "d_catacomb_80_2", Rectangle(1426, 182, 20));
		AddSpawnPoint("d_catacomb_80_2.Id9", "d_catacomb_80_2", Rectangle(1472, 27, 20));
		AddSpawnPoint("d_catacomb_80_2.Id9", "d_catacomb_80_2", Rectangle(1493, 924, 20));
		AddSpawnPoint("d_catacomb_80_2.Id9", "d_catacomb_80_2", Rectangle(1754, 1000, 20));
		AddSpawnPoint("d_catacomb_80_2.Id9", "d_catacomb_80_2", Rectangle(717, 910, 20));
		AddSpawnPoint("d_catacomb_80_2.Id9", "d_catacomb_80_2", Rectangle(931, 1123, 20));
		AddSpawnPoint("d_catacomb_80_2.Id9", "d_catacomb_80_2", Rectangle(954, 960, 20));
		AddSpawnPoint("d_catacomb_80_2.Id9", "d_catacomb_80_2", Rectangle(-966, 927, 20));
		AddSpawnPoint("d_catacomb_80_2.Id9", "d_catacomb_80_2", Rectangle(-964, 1106, 20));
		AddSpawnPoint("d_catacomb_80_2.Id9", "d_catacomb_80_2", Rectangle(-766, 1159, 20));
		AddSpawnPoint("d_catacomb_80_2.Id9", "d_catacomb_80_2", Rectangle(-1577, 1134, 20));
		AddSpawnPoint("d_catacomb_80_2.Id9", "d_catacomb_80_2", Rectangle(-1756, 976, 20));
		AddSpawnPoint("d_catacomb_80_2.Id9", "d_catacomb_80_2", Rectangle(-1506, 921, 20));
		AddSpawnPoint("d_catacomb_80_2.Id9", "d_catacomb_80_2", Rectangle(-1844, 297, 20));
		AddSpawnPoint("d_catacomb_80_2.Id9", "d_catacomb_80_2", Rectangle(-1665, 218, 20));
		AddSpawnPoint("d_catacomb_80_2.Id9", "d_catacomb_80_2", Rectangle(-231, 2000, 20));
		AddSpawnPoint("d_catacomb_80_2.Id9", "d_catacomb_80_2", Rectangle(66, 1772, 20));
		AddSpawnPoint("d_catacomb_80_2.Id9", "d_catacomb_80_2", Rectangle(171, 1984, 20));

		// 'ERD_Wendigo_Magician_Blue' GenType 17 Spawn Points
		AddSpawnPoint("d_catacomb_80_2.Id10", "d_catacomb_80_2", Rectangle(1752, 929, 30));
		AddSpawnPoint("d_catacomb_80_2.Id10", "d_catacomb_80_2", Rectangle(-1540, 880, 30));
		AddSpawnPoint("d_catacomb_80_2.Id10", "d_catacomb_80_2", Rectangle(-1014, 1151, 30));
		AddSpawnPoint("d_catacomb_80_2.Id10", "d_catacomb_80_2", Rectangle(-911, 819, 30));
		AddSpawnPoint("d_catacomb_80_2.Id10", "d_catacomb_80_2", Rectangle(-810, 1125, 30));
		AddSpawnPoint("d_catacomb_80_2.Id10", "d_catacomb_80_2", Rectangle(971, 1152, 30));
		AddSpawnPoint("d_catacomb_80_2.Id10", "d_catacomb_80_2", Rectangle(774, 910, 30));
		AddSpawnPoint("d_catacomb_80_2.Id10", "d_catacomb_80_2", Rectangle(989, 887, 30));
		AddSpawnPoint("d_catacomb_80_2.Id10", "d_catacomb_80_2", Rectangle(-217, 1876, 30));
		AddSpawnPoint("d_catacomb_80_2.Id10", "d_catacomb_80_2", Rectangle(-46, 2016, 30));
		AddSpawnPoint("d_catacomb_80_2.Id10", "d_catacomb_80_2", Rectangle(-1865, 350, 30));
		AddSpawnPoint("d_catacomb_80_2.Id10", "d_catacomb_80_2", Rectangle(1878, -6, 30));
		AddSpawnPoint("d_catacomb_80_2.Id10", "d_catacomb_80_2", Rectangle(244, 1849, 30));
		AddSpawnPoint("d_catacomb_80_2.Id10", "d_catacomb_80_2", Rectangle(-258, 1699, 30));
		AddSpawnPoint("d_catacomb_80_2.Id10", "d_catacomb_80_2", Rectangle(70, 1549, 30));
		AddSpawnPoint("d_catacomb_80_2.Id10", "d_catacomb_80_2", Rectangle(180, 2134, 30));
		AddSpawnPoint("d_catacomb_80_2.Id10", "d_catacomb_80_2", Rectangle(-1693, 1039, 30));
		AddSpawnPoint("d_catacomb_80_2.Id10", "d_catacomb_80_2", Rectangle(-1048, 872, 30));
		AddSpawnPoint("d_catacomb_80_2.Id10", "d_catacomb_80_2", Rectangle(692, 1143, 30));
		AddSpawnPoint("d_catacomb_80_2.Id10", "d_catacomb_80_2", Rectangle(1526, 1074, 30));
		AddSpawnPoint("d_catacomb_80_2.Id10", "d_catacomb_80_2", Rectangle(-1893, -64, 30));
		AddSpawnPoint("d_catacomb_80_2.Id10", "d_catacomb_80_2", Rectangle(-1418, 326, 30));
		AddSpawnPoint("d_catacomb_80_2.Id10", "d_catacomb_80_2", Rectangle(1358, 293, 30));
		AddSpawnPoint("d_catacomb_80_2.Id10", "d_catacomb_80_2", Rectangle(1398, -6, 30));

		// 'ERD_Kepari_Mage' GenType 18 Spawn Points
		AddSpawnPoint("d_catacomb_80_2.Id11", "d_catacomb_80_2", Rectangle(55, 1707, 30));
		AddSpawnPoint("d_catacomb_80_2.Id11", "d_catacomb_80_2", Rectangle(171, 1979, 30));
		AddSpawnPoint("d_catacomb_80_2.Id11", "d_catacomb_80_2", Rectangle(-217, 1628, 30));
		AddSpawnPoint("d_catacomb_80_2.Id11", "d_catacomb_80_2", Rectangle(-254, 2087, 30));
		AddSpawnPoint("d_catacomb_80_2.Id11", "d_catacomb_80_2", Rectangle(215, 1712, 30));
		AddSpawnPoint("d_catacomb_80_2.Id11", "d_catacomb_80_2", Rectangle(-135, 1083, 30));
		AddSpawnPoint("d_catacomb_80_2.Id11", "d_catacomb_80_2", Rectangle(-12, 1016, 30));
		AddSpawnPoint("d_catacomb_80_2.Id11", "d_catacomb_80_2", Rectangle(38, 1865, 30));
		AddSpawnPoint("d_catacomb_80_2.Id11", "d_catacomb_80_2", Rectangle(-908, 1011, 30));
		AddSpawnPoint("d_catacomb_80_2.Id11", "d_catacomb_80_2", Rectangle(836, 1032, 30));
		AddSpawnPoint("d_catacomb_80_2.Id11", "d_catacomb_80_2", Rectangle(-299, 1807, 30));
		AddSpawnPoint("d_catacomb_80_2.Id11", "d_catacomb_80_2", Rectangle(91, 2147, 30));
		AddSpawnPoint("d_catacomb_80_2.Id11", "d_catacomb_80_2", Rectangle(-709, 862, 30));
		AddSpawnPoint("d_catacomb_80_2.Id11", "d_catacomb_80_2", Rectangle(-711, 1082, 30));
		AddSpawnPoint("d_catacomb_80_2.Id11", "d_catacomb_80_2", Rectangle(-866, 1199, 30));
		AddSpawnPoint("d_catacomb_80_2.Id11", "d_catacomb_80_2", Rectangle(696, 1212, 30));
		AddSpawnPoint("d_catacomb_80_2.Id11", "d_catacomb_80_2", Rectangle(726, 950, 30));
		AddSpawnPoint("d_catacomb_80_2.Id11", "d_catacomb_80_2", Rectangle(923, 852, 30));
		AddSpawnPoint("d_catacomb_80_2.Id11", "d_catacomb_80_2", Rectangle(-1523, -1005, 30));

		// 'ERD_Mushroom_Ent_Green' GenType 19 Spawn Points
		AddSpawnPoint("d_catacomb_80_2.Id12", "d_catacomb_80_2", Rectangle(77, 2065, 40));
		AddSpawnPoint("d_catacomb_80_2.Id12", "d_catacomb_80_2", Rectangle(-89, 971, 40));
		AddSpawnPoint("d_catacomb_80_2.Id12", "d_catacomb_80_2", Rectangle(-1027, 945, 40));
		AddSpawnPoint("d_catacomb_80_2.Id12", "d_catacomb_80_2", Rectangle(848, 1136, 40));
		AddSpawnPoint("d_catacomb_80_2.Id12", "d_catacomb_80_2", Rectangle(1709, 1006, 40));
		AddSpawnPoint("d_catacomb_80_2.Id12", "d_catacomb_80_2", Rectangle(-1599, 1057, 40));
		AddSpawnPoint("d_catacomb_80_2.Id12", "d_catacomb_80_2", Rectangle(-79, 1606, 40));

		// 'Rootcrystal_05' GenType 20 Spawn Points
		AddSpawnPoint("d_catacomb_80_2.Id13", "d_catacomb_80_2", Rectangle(23, -1090, 100));
		AddSpawnPoint("d_catacomb_80_2.Id13", "d_catacomb_80_2", Rectangle(51, -733, 100));
		AddSpawnPoint("d_catacomb_80_2.Id13", "d_catacomb_80_2", Rectangle(-1684, -1105, 100));
		AddSpawnPoint("d_catacomb_80_2.Id13", "d_catacomb_80_2", Rectangle(-1644, -717, 100));
		AddSpawnPoint("d_catacomb_80_2.Id13", "d_catacomb_80_2", Rectangle(-1854, -49, 100));
		AddSpawnPoint("d_catacomb_80_2.Id13", "d_catacomb_80_2", Rectangle(-1647, 294, 100));
		AddSpawnPoint("d_catacomb_80_2.Id13", "d_catacomb_80_2", Rectangle(-1326, 109, 100));
		AddSpawnPoint("d_catacomb_80_2.Id13", "d_catacomb_80_2", Rectangle(-1792, 1054, 100));
		AddSpawnPoint("d_catacomb_80_2.Id13", "d_catacomb_80_2", Rectangle(-860, -1037, 100));
		AddSpawnPoint("d_catacomb_80_2.Id13", "d_catacomb_80_2", Rectangle(-1080, 1057, 100));
		AddSpawnPoint("d_catacomb_80_2.Id13", "d_catacomb_80_2", Rectangle(-766, 975, 100));
		AddSpawnPoint("d_catacomb_80_2.Id13", "d_catacomb_80_2", Rectangle(-166, 1658, 100));
		AddSpawnPoint("d_catacomb_80_2.Id13", "d_catacomb_80_2", Rectangle(-281, 2009, 100));
		AddSpawnPoint("d_catacomb_80_2.Id13", "d_catacomb_80_2", Rectangle(125, 2125, 100));
		AddSpawnPoint("d_catacomb_80_2.Id13", "d_catacomb_80_2", Rectangle(195, 1756, 100));
		AddSpawnPoint("d_catacomb_80_2.Id13", "d_catacomb_80_2", Rectangle(-29, 1038, 100));
		AddSpawnPoint("d_catacomb_80_2.Id13", "d_catacomb_80_2", Rectangle(650, 1069, 100));
		AddSpawnPoint("d_catacomb_80_2.Id13", "d_catacomb_80_2", Rectangle(1023, 867, 100));
		AddSpawnPoint("d_catacomb_80_2.Id13", "d_catacomb_80_2", Rectangle(1525, 913, 100));
		AddSpawnPoint("d_catacomb_80_2.Id13", "d_catacomb_80_2", Rectangle(1335, -25, 100));
		AddSpawnPoint("d_catacomb_80_2.Id13", "d_catacomb_80_2", Rectangle(1797, 156, 100));
		AddSpawnPoint("d_catacomb_80_2.Id13", "d_catacomb_80_2", Rectangle(1396, -917, 100));
		AddSpawnPoint("d_catacomb_80_2.Id13", "d_catacomb_80_2", Rectangle(1375, 344, 100));
		AddSpawnPoint("d_catacomb_80_2.Id13", "d_catacomb_80_2", Rectangle(1775, -911, 100));
		AddSpawnPoint("d_catacomb_80_2.Id13", "d_catacomb_80_2", Rectangle(797, -765, 100));
		AddSpawnPoint("d_catacomb_80_2.Id13", "d_catacomb_80_2", Rectangle(117, -1617, 100));
	}
}
