//--- Melia Script -----------------------------------------------------------
// Royal Mausoleum 3F Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_zachariel_34'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DZachariel34MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_zachariel_34", MonsterId.Echad, Properties("MHP", 68268, "MINPATK", 1379, "MAXPATK", 1596, "MINMATK", 1379, "MAXMATK", 1596, "DEF", 446, "MDEF", 446));
		AddPropertyOverrides("d_zachariel_34", MonsterId.Wolf_Statue_Mage_Pollution, Properties("MHP", 69121, "MINPATK", 1390, "MAXPATK", 1610, "MINMATK", 1390, "MAXMATK", 1610, "DEF", 459, "MDEF", 459));
		AddPropertyOverrides("d_zachariel_34", MonsterId.Shtayim, Properties("MHP", 69988, "MINPATK", 1401, "MAXPATK", 1624, "MINMATK", 1401, "MAXMATK", 1624, "DEF", 473, "MDEF", 473));
		AddPropertyOverrides("d_zachariel_34", MonsterId.Echad_Bow, Properties("MHP", 70870, "MINPATK", 1412, "MAXPATK", 1637, "MINMATK", 1412, "MAXMATK", 1637, "DEF", 486, "MDEF", 486));
		AddPropertyOverrides("d_zachariel_34", MonsterId.Wolf_Statue_Mage, Properties("MHP", 71766, "MINPATK", 1424, "MAXPATK", 1652, "MINMATK", 1424, "MAXMATK", 1652, "DEF", 500, "MDEF", 500));
		AddPropertyOverrides("d_zachariel_34", MonsterId.Schlesien_Guard_NPC, Properties("MHP", 72677, "MINPATK", 1435, "MAXPATK", 1666, "MINMATK", 1435, "MAXMATK", 1666, "DEF", 514, "MDEF", 514));
		AddPropertyOverrides("d_zachariel_34", MonsterId.Boss_Denoptic_Q1, Properties("MHP", 357700, "MINPATK", 3126, "MAXPATK", 3630, "MINMATK", 3126, "MAXMATK", 3630, "DEF", 1140, "MDEF", 1140));

		// Monster Spawners ---------------------------------

		AddSpawner("d_zachariel_34.Id1", MonsterId.Echad, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_34.Id2", MonsterId.Wolf_Statue_Mage_Pollution, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_34.Id3", MonsterId.Rootcrystal_05, 6, 8, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);
		AddSpawner("d_zachariel_34.Id4", MonsterId.Shtayim, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_zachariel_34.Id5", MonsterId.Echad_Bow, 5, 6, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_34.Id6", MonsterId.Wolf_Statue_Mage, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_34.Id7", MonsterId.Wolf_Statue_Mage, 3, 4, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_34.Id8", MonsterId.Shtayim, 4, 5, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_34.Id9", MonsterId.Echad_Bow, 4, 5, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Echad' GenType 25 Spawn Points
		AddSpawnPoint("d_zachariel_34.Id1", "d_zachariel_34", Rectangle(-1410, 222, 9999));

		// 'Wolf_Statue_Mage_Pollution' GenType 27 Spawn Points
		AddSpawnPoint("d_zachariel_34.Id2", "d_zachariel_34", Rectangle(1731, 13, 40));
		AddSpawnPoint("d_zachariel_34.Id2", "d_zachariel_34", Rectangle(1584, 234, 40));
		AddSpawnPoint("d_zachariel_34.Id2", "d_zachariel_34", Rectangle(1888, -199, 40));
		AddSpawnPoint("d_zachariel_34.Id2", "d_zachariel_34", Rectangle(1551, -245, 40));
		AddSpawnPoint("d_zachariel_34.Id2", "d_zachariel_34", Rectangle(1873, 242, 40));

		// 'Rootcrystal_05' GenType 600 Spawn Points
		AddSpawnPoint("d_zachariel_34.Id3", "d_zachariel_34", Rectangle(-1313, 226, 9999));

		// 'Shtayim' GenType 603 Spawn Points
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(2410, -41, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1506, -994, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1303, -1002, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1351, -1160, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1530, -1166, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1460, -770, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1437, -515, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1486, -211, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1295, 78, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1502, 194, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1684, 171, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1633, 374, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1308, 361, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-2454, 242, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-2225, 50, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1965, 39, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-2427, 60, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1987, 234, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1410, 642, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1316, 770, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1279, 840, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1149, 1116, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1297, 1126, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-1122, 1244, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-973, 1160, 35));
		AddSpawnPoint("d_zachariel_34.Id4", "d_zachariel_34", Rectangle(-743, 1183, 35));

		// 'Echad_Bow' GenType 3008 Spawn Points
		AddSpawnPoint("d_zachariel_34.Id5", "d_zachariel_34", Rectangle(-372, 222, 35));
		AddSpawnPoint("d_zachariel_34.Id5", "d_zachariel_34", Rectangle(-657, 221, 35));
		AddSpawnPoint("d_zachariel_34.Id5", "d_zachariel_34", Rectangle(-408, -34, 35));
		AddSpawnPoint("d_zachariel_34.Id5", "d_zachariel_34", Rectangle(-356, 82, 35));
		AddSpawnPoint("d_zachariel_34.Id5", "d_zachariel_34", Rectangle(-69, 266, 35));
		AddSpawnPoint("d_zachariel_34.Id5", "d_zachariel_34", Rectangle(-303, 420, 35));
		AddSpawnPoint("d_zachariel_34.Id5", "d_zachariel_34", Rectangle(-361, 595, 35));
		AddSpawnPoint("d_zachariel_34.Id5", "d_zachariel_34", Rectangle(-387, 891, 35));
		AddSpawnPoint("d_zachariel_34.Id5", "d_zachariel_34", Rectangle(-275, 1042, 35));
		AddSpawnPoint("d_zachariel_34.Id5", "d_zachariel_34", Rectangle(-425, 1170, 35));
		AddSpawnPoint("d_zachariel_34.Id5", "d_zachariel_34", Rectangle(-230, 1222, 35));
		AddSpawnPoint("d_zachariel_34.Id5", "d_zachariel_34", Rectangle(298, 204, 35));
		AddSpawnPoint("d_zachariel_34.Id5", "d_zachariel_34", Rectangle(-864, 215, 35));
		AddSpawnPoint("d_zachariel_34.Id5", "d_zachariel_34", Rectangle(-499, 195, 35));
		AddSpawnPoint("d_zachariel_34.Id5", "d_zachariel_34", Rectangle(-374, 377, 35));
		AddSpawnPoint("d_zachariel_34.Id5", "d_zachariel_34", Rectangle(26, 175, 35));
		AddSpawnPoint("d_zachariel_34.Id5", "d_zachariel_34", Rectangle(-94, 1163, 35));

		// 'Wolf_Statue_Mage' GenType 3009 Spawn Points
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-1826, 165, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-1313, 180, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-1516, 279, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-1484, 30, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-480, 183, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-322, 74, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-336, 327, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-177, 199, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-350, 1057, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-473, 1187, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-942, 1146, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-1118, 1079, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-1033, 1209, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-2765, -13, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-2692, 124, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-2749, 287, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-3039, -30, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-2793, 160, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-2223, 194, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-2389, 182, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-1953, 245, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-1553, -1067, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-1472, -1154, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-1383, -1092, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-1385, -988, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-1482, -995, 30));
		AddSpawnPoint("d_zachariel_34.Id6", "d_zachariel_34", Rectangle(-1363, -1185, 30));

		// 'Wolf_Statue_Mage' GenType 3010 Spawn Points
		AddSpawnPoint("d_zachariel_34.Id7", "d_zachariel_34", Rectangle(1709, -3, 350));
		AddSpawnPoint("d_zachariel_34.Id7", "d_zachariel_34", Rectangle(1519, -236, 350));
		AddSpawnPoint("d_zachariel_34.Id7", "d_zachariel_34", Rectangle(1891, -229, 350));
		AddSpawnPoint("d_zachariel_34.Id7", "d_zachariel_34", Rectangle(1460, 281, 350));
		AddSpawnPoint("d_zachariel_34.Id7", "d_zachariel_34", Rectangle(1807, 302, 350));
		AddSpawnPoint("d_zachariel_34.Id7", "d_zachariel_34", Rectangle(1555, -15, 350));

		// 'Shtayim' GenType 3023 Spawn Points
		AddSpawnPoint("d_zachariel_34.Id8", "d_zachariel_34", Rectangle(1504, 219, 30));
		AddSpawnPoint("d_zachariel_34.Id8", "d_zachariel_34", Rectangle(1734, 278, 30));
		AddSpawnPoint("d_zachariel_34.Id8", "d_zachariel_34", Rectangle(1662, -54, 30));
		AddSpawnPoint("d_zachariel_34.Id8", "d_zachariel_34", Rectangle(1554, -179, 30));
		AddSpawnPoint("d_zachariel_34.Id8", "d_zachariel_34", Rectangle(1963, 75, 30));
		AddSpawnPoint("d_zachariel_34.Id8", "d_zachariel_34", Rectangle(1901, -225, 30));
		AddSpawnPoint("d_zachariel_34.Id8", "d_zachariel_34", Rectangle(1811, 29, 30));

		// 'Echad_Bow' GenType 3024 Spawn Points
		AddSpawnPoint("d_zachariel_34.Id9", "d_zachariel_34", Rectangle(1252, 305, 30));
		AddSpawnPoint("d_zachariel_34.Id9", "d_zachariel_34", Rectangle(1584, 244, 30));
		AddSpawnPoint("d_zachariel_34.Id9", "d_zachariel_34", Rectangle(1823, 284, 30));
		AddSpawnPoint("d_zachariel_34.Id9", "d_zachariel_34", Rectangle(1610, 51, 30));
		AddSpawnPoint("d_zachariel_34.Id9", "d_zachariel_34", Rectangle(1954, 3, 30));
		AddSpawnPoint("d_zachariel_34.Id9", "d_zachariel_34", Rectangle(1787, 126, 30));
		AddSpawnPoint("d_zachariel_34.Id9", "d_zachariel_34", Rectangle(1620, -202, 30));
		AddSpawnPoint("d_zachariel_34.Id9", "d_zachariel_34", Rectangle(1912, -227, 30));
		AddSpawnPoint("d_zachariel_34.Id9", "d_zachariel_34", Rectangle(1742, 15, 30));
	}
}
