//--- Melia Script -----------------------------------------------------------
// d_catacomb_80_2
//
//--- Description -----------------------------------------------------------
// Sets up the d_catacomb_80_2 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DCatacomb802MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("d_catacomb_80_2.Id1", MonsterId.ERD_Yognome_Yellow, 12, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_2.Id2", MonsterId.ERD_Moya, 18, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_2.Id3", MonsterId.ERD_Mushroom_Boy_Green, 18, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_2.Id4", MonsterId.ERD_Mirtislampa, 40, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_2.Id5", MonsterId.ERD_Infroholder_Mage_Green, 16, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_2.Id6", MonsterId.ERD_NightMaiden_Bow_Red, 16, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_2.Id7", MonsterId.ERD_Gazing_Golem_Yellow, 12, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_2.Id8", MonsterId.ERD_Egnome_Yellow, 5, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_2.Id9", MonsterId.ERD_Wendigo_Archer_Blue, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_2.Id10", MonsterId.ERD_Wendigo_Magician_Blue, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_2.Id11", MonsterId.ERD_Kepari_Mage, 16, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_2.Id12", MonsterId.ERD_Mushroom_Ent_Green, 5, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_2.Id13", MonsterId.Rootcrystal_05, 20, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// ERD_Yognome_Yellow Spawn Points
		AddSpawnPoint( "d_catacomb_80_2.Id1", "d_catacomb_80_2", Spot(-63.741257, -1630.7179, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id1", "d_catacomb_80_2", Spot(91.730835, -1796.3597, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id1", "d_catacomb_80_2", Spot(76.31028, -1600.0492, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id1", "d_catacomb_80_2", Spot(-135.80748, -774.6698, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id1", "d_catacomb_80_2", Spot(-119.99933, -1062.8583, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id1", "d_catacomb_80_2", Spot(224.47083, -1102.2687, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id1", "d_catacomb_80_2", Spot(191.47421, -739.4491, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id1", "d_catacomb_80_2", Spot(175.5225, -914.1261, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id1", "d_catacomb_80_2", Spot(-1655.9683, -734.038, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id1", "d_catacomb_80_2", Spot(-1655.7982, -1105.1868, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id1", "d_catacomb_80_2", Spot(1560.2675, -704.8221, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id1", "d_catacomb_80_2", Spot(1729.6727, -1095.869, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id1", "d_catacomb_80_2", Spot(-1866.5416, -1037.3451, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id1", "d_catacomb_80_2", Spot(-1470.8112, -846.6353, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id1", "d_catacomb_80_2", Spot(1445.1315, -1013.5563, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id1", "d_catacomb_80_2", Spot(1745.491, -822.3428, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id1", "d_catacomb_80_2", Spot(-820.7963, -985.35266, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id1", "d_catacomb_80_2", Spot(-673.08624, -880.92505, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id1", "d_catacomb_80_2", Spot(733.70825, -978.7074, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id1", "d_catacomb_80_2", Spot(897.9604, -836.86224, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id1", "d_catacomb_80_2", Spot(-1462.4949, -1094.7897, 25));

		// ERD_Moya Spawn Points
		AddSpawnPoint( "d_catacomb_80_2.Id2", "d_catacomb_80_2", Spot(-50.282295, -1760.616, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id2", "d_catacomb_80_2", Spot(3.9994555, -1526.3561, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id2", "d_catacomb_80_2", Spot(-203.83331, -934.1942, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id2", "d_catacomb_80_2", Spot(74.019325, -1127.0215, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id2", "d_catacomb_80_2", Spot(-411.37268, -938.89557, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id2", "d_catacomb_80_2", Spot(473.64874, -902.70874, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id2", "d_catacomb_80_2", Spot(19.390686, -769.48083, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id2", "d_catacomb_80_2", Spot(1.5944252, -1016.2523, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id2", "d_catacomb_80_2", Spot(-1456.5908, -765.25024, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id2", "d_catacomb_80_2", Spot(1510.2401, -954.14465, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id2", "d_catacomb_80_2", Spot(230.86456, -1047.9441, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id2", "d_catacomb_80_2", Spot(235.5204, -744.50366, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id2", "d_catacomb_80_2", Spot(127.90727, -1715.156, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id2", "d_catacomb_80_2", Spot(687.06116, -913.1459, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id2", "d_catacomb_80_2", Spot(-618.5435, -923.46704, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id2", "d_catacomb_80_2", Spot(-1434.9808, -1010.6813, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id2", "d_catacomb_80_2", Spot(1414.8005, -728.3993, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id2", "d_catacomb_80_2", Spot(1766.5531, -945.5393, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id2", "d_catacomb_80_2", Spot(-1753.8469, -972.7568, 30));

		// ERD_Mushroom_Boy_Green Spawn Points
		AddSpawnPoint( "d_catacomb_80_2.Id3", "d_catacomb_80_2", Spot(9.87384, -906.54614, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id3", "d_catacomb_80_2", Spot(165.35852, -1690.9812, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id3", "d_catacomb_80_2", Spot(-831.40247, -802.5989, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id3", "d_catacomb_80_2", Spot(-780.4683, -1033.5623, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id3", "d_catacomb_80_2", Spot(806.03735, -783.1816, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id3", "d_catacomb_80_2", Spot(835.12537, -1046.2764, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id3", "d_catacomb_80_2", Spot(-1200.5297, -906.76776, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id3", "d_catacomb_80_2", Spot(1128.7788, -909.2737, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id3", "d_catacomb_80_2", Spot(1389.839, -897.42175, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id3", "d_catacomb_80_2", Spot(1577.6266, -1117.8513, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id3", "d_catacomb_80_2", Spot(-1481.4248, -920.4762, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id3", "d_catacomb_80_2", Spot(-1849.8314, -919.0986, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id3", "d_catacomb_80_2", Spot(1667.7305, -779.77356, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id3", "d_catacomb_80_2", Spot(1803.6337, -1013.2425, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id3", "d_catacomb_80_2", Spot(-1703.1635, -1069.0605, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id3", "d_catacomb_80_2", Spot(-1565.7528, -765.7043, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id3", "d_catacomb_80_2", Spot(707.34515, -891.3243, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id3", "d_catacomb_80_2", Spot(956.7876, -993.6237, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id3", "d_catacomb_80_2", Spot(1314.7983, -889.8048, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id3", "d_catacomb_80_2", Spot(1537.267, -813.4511, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id3", "d_catacomb_80_2", Spot(1427.1785, -1086.764, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id3", "d_catacomb_80_2", Spot(1815.643, -872.86786, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id3", "d_catacomb_80_2", Spot(-631.80664, -877.1041, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id3", "d_catacomb_80_2", Spot(-880.5221, -1016.719, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id3", "d_catacomb_80_2", Spot(-1424.2043, -859.13995, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id3", "d_catacomb_80_2", Spot(-1570.8444, -1048.709, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id3", "d_catacomb_80_2", Spot(-1743.061, -720.39795, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id3", "d_catacomb_80_2", Spot(-61.348553, -1701.778, 25));
		AddSpawnPoint( "d_catacomb_80_2.Id3", "d_catacomb_80_2", Spot(163.06735, -862.6217, 25));

		// ERD_Mirtislampa Spawn Points
		AddSpawnPoint( "d_catacomb_80_2.Id4", "d_catacomb_80_2", Spot(-739.3391, -942.5011, 200));
		AddSpawnPoint( "d_catacomb_80_2.Id4", "d_catacomb_80_2", Spot(-1638.0422, -929.03577, 200));
		AddSpawnPoint( "d_catacomb_80_2.Id4", "d_catacomb_80_2", Spot(859.8543, -910.81885, 200));
		AddSpawnPoint( "d_catacomb_80_2.Id4", "d_catacomb_80_2", Spot(1599.5038, -922.93115, 200));
		AddSpawnPoint( "d_catacomb_80_2.Id4", "d_catacomb_80_2", Spot(1670.364, 154.82703, 200));
		AddSpawnPoint( "d_catacomb_80_2.Id4", "d_catacomb_80_2", Spot(-1612.7437, 140.45277, 200));
		AddSpawnPoint( "d_catacomb_80_2.Id4", "d_catacomb_80_2", Spot(-1614.1367, 999.089, 200));
		AddSpawnPoint( "d_catacomb_80_2.Id4", "d_catacomb_80_2", Spot(1643.3763, 985.2324, 200));
		AddSpawnPoint( "d_catacomb_80_2.Id4", "d_catacomb_80_2", Spot(849.38086, 1017.8656, 200));
		AddSpawnPoint( "d_catacomb_80_2.Id4", "d_catacomb_80_2", Spot(-898.94275, 1015.3091, 200));
		AddSpawnPoint( "d_catacomb_80_2.Id4", "d_catacomb_80_2", Spot(39.75731, -931.31934, 200));
		AddSpawnPoint( "d_catacomb_80_2.Id4", "d_catacomb_80_2", Spot(-102.49207, 1790.9171, 200));

		// ERD_Infroholder_Mage_Green Spawn Points
		AddSpawnPoint( "d_catacomb_80_2.Id5", "d_catacomb_80_2", Spot(-1504.7263, -1137.3618, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id5", "d_catacomb_80_2", Spot(-1787.456, -784.0251, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id5", "d_catacomb_80_2", Spot(1427.117, -1093.4026, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id5", "d_catacomb_80_2", Spot(1760.2223, -750.03564, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id5", "d_catacomb_80_2", Spot(1616.6542, -566.55884, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id5", "d_catacomb_80_2", Spot(-1682.2245, -561.1425, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id5", "d_catacomb_80_2", Spot(-1788.6783, -1040.2083, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id5", "d_catacomb_80_2", Spot(1400.1682, -798.6804, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id5", "d_catacomb_80_2", Spot(1628.6782, -985.3526, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id5", "d_catacomb_80_2", Spot(-1370.7875, -882.88184, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id5", "d_catacomb_80_2", Spot(-1553.1945, -834.1661, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id5", "d_catacomb_80_2", Spot(1665.4117, -875.0202, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id5", "d_catacomb_80_2", Spot(1363.3855, -929.222, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id5", "d_catacomb_80_2", Spot(-1791.3838, -897.3383, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id5", "d_catacomb_80_2", Spot(-1511.0886, -683.4199, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id5", "d_catacomb_80_2", Spot(1469.969, -861.7478, 30));

		// ERD_NightMaiden_Bow_Red Spawn Points
		AddSpawnPoint( "d_catacomb_80_2.Id6", "d_catacomb_80_2", Spot(-870.1937, -993.049, 40));
		AddSpawnPoint( "d_catacomb_80_2.Id6", "d_catacomb_80_2", Spot(969.1751, -806.6488, 40));
		AddSpawnPoint( "d_catacomb_80_2.Id6", "d_catacomb_80_2", Spot(-1764.3716, 5.1226463, 40));
		AddSpawnPoint( "d_catacomb_80_2.Id6", "d_catacomb_80_2", Spot(-1472.8014, 288.99368, 40));
		AddSpawnPoint( "d_catacomb_80_2.Id6", "d_catacomb_80_2", Spot(1491.5824, -49.44232, 40));
		AddSpawnPoint( "d_catacomb_80_2.Id6", "d_catacomb_80_2", Spot(1435.6692, 279.52673, 40));
		AddSpawnPoint( "d_catacomb_80_2.Id6", "d_catacomb_80_2", Spot(-1691.6482, -404.2335, 40));
		AddSpawnPoint( "d_catacomb_80_2.Id6", "d_catacomb_80_2", Spot(1613.2706, -417.017, 40));
		AddSpawnPoint( "d_catacomb_80_2.Id6", "d_catacomb_80_2", Spot(1835.1123, 127.69302, 40));
		AddSpawnPoint( "d_catacomb_80_2.Id6", "d_catacomb_80_2", Spot(-1754.4427, 243.60191, 40));
		AddSpawnPoint( "d_catacomb_80_2.Id6", "d_catacomb_80_2", Spot(1265.5137, 317.69214, 40));
		AddSpawnPoint( "d_catacomb_80_2.Id6", "d_catacomb_80_2", Spot(1237.4359, 64.41708, 40));
		AddSpawnPoint( "d_catacomb_80_2.Id6", "d_catacomb_80_2", Spot(1398.1548, -79.02388, 40));
		AddSpawnPoint( "d_catacomb_80_2.Id6", "d_catacomb_80_2", Spot(1910.4257, 306.08478, 40));
		AddSpawnPoint( "d_catacomb_80_2.Id6", "d_catacomb_80_2", Spot(1836.7676, 1.3093865, 40));
		AddSpawnPoint( "d_catacomb_80_2.Id6", "d_catacomb_80_2", Spot(-1310.9857, 289.9728, 40));
		AddSpawnPoint( "d_catacomb_80_2.Id6", "d_catacomb_80_2", Spot(-1410.5442, -35.48369, 40));
		AddSpawnPoint( "d_catacomb_80_2.Id6", "d_catacomb_80_2", Spot(-1930.9418, 324.72513, 40));
		AddSpawnPoint( "d_catacomb_80_2.Id6", "d_catacomb_80_2", Spot(-1935.4373, 39.51799, 40));
		AddSpawnPoint( "d_catacomb_80_2.Id6", "d_catacomb_80_2", Spot(-1519.7308, 77.40529, 40));

		// ERD_Gazing_Golem_Yellow Spawn Points
		AddSpawnPoint( "d_catacomb_80_2.Id7", "d_catacomb_80_2", Spot(-1434.3102, -28.698341, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id7", "d_catacomb_80_2", Spot(-1331.8342, 61.33535, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id7", "d_catacomb_80_2", Spot(-1900.769, 191.4067, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id7", "d_catacomb_80_2", Spot(1413.4838, 107.51007, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id7", "d_catacomb_80_2", Spot(1767.4198, -30.540295, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id7", "d_catacomb_80_2", Spot(1774.5339, 281.37622, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id7", "d_catacomb_80_2", Spot(1623.1652, 507.56848, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id7", "d_catacomb_80_2", Spot(-1636.8173, 498.22397, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id7", "d_catacomb_80_2", Spot(1302.1464, -38.23788, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id7", "d_catacomb_80_2", Spot(1328.0497, 199.58456, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id7", "d_catacomb_80_2", Spot(-1783.866, 322.76895, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id7", "d_catacomb_80_2", Spot(-1873.5234, 75.13403, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id7", "d_catacomb_80_2", Spot(-1642.223, 144.87872, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id7", "d_catacomb_80_2", Spot(1625.6741, 179.28683, 20));

		// ERD_Egnome_Yellow Spawn Points
		AddSpawnPoint( "d_catacomb_80_2.Id8", "d_catacomb_80_2", Spot(-1205.1449, 142.89322, 40));
		AddSpawnPoint( "d_catacomb_80_2.Id8", "d_catacomb_80_2", Spot(1174.8855, 141.88042, 40));
		AddSpawnPoint( "d_catacomb_80_2.Id8", "d_catacomb_80_2", Spot(619.58716, 1039.1908, 40));
		AddSpawnPoint( "d_catacomb_80_2.Id8", "d_catacomb_80_2", Spot(-694.6677, 990.3886, 40));
		AddSpawnPoint( "d_catacomb_80_2.Id8", "d_catacomb_80_2", Spot(-152.24905, 1737.7898, 40));
		AddSpawnPoint( "d_catacomb_80_2.Id8", "d_catacomb_80_2", Spot(-1539.6963, -840.72504, 40));
		AddSpawnPoint( "d_catacomb_80_2.Id8", "d_catacomb_80_2", Spot(1666.6561, -1064.5115, 40));

		// ERD_Wendigo_Archer_Blue Spawn Points
		AddSpawnPoint( "d_catacomb_80_2.Id9", "d_catacomb_80_2", Spot(-1681.369, 888.15894, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id9", "d_catacomb_80_2", Spot(-1718.6267, 1100.0027, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id9", "d_catacomb_80_2", Spot(1643.7496, 1106.828, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id9", "d_catacomb_80_2", Spot(1607.1958, 859.03546, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id9", "d_catacomb_80_2", Spot(1693.1282, 268.98337, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id9", "d_catacomb_80_2", Spot(1633.0908, 39.809013, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id9", "d_catacomb_80_2", Spot(-1631.5464, 31.714462, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id9", "d_catacomb_80_2", Spot(-1383.0195, 243.0486, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id9", "d_catacomb_80_2", Spot(-1525.7775, 1002.1132, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id9", "d_catacomb_80_2", Spot(1493.8553, 1024.1687, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id9", "d_catacomb_80_2", Spot(687.3, 1142.1125, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id9", "d_catacomb_80_2", Spot(-784.1, 894.3238, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id9", "d_catacomb_80_2", Spot(-322.7187, 1759.2985, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id9", "d_catacomb_80_2", Spot(1426.9967, 182.09749, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id9", "d_catacomb_80_2", Spot(1472.4606, 27.48197, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id9", "d_catacomb_80_2", Spot(1493.6587, 924.9156, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id9", "d_catacomb_80_2", Spot(1754.1094, 1000.087, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id9", "d_catacomb_80_2", Spot(717.73193, 910.48145, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id9", "d_catacomb_80_2", Spot(931.5562, 1123.9705, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id9", "d_catacomb_80_2", Spot(954.99084, 960.22144, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id9", "d_catacomb_80_2", Spot(-966.722, 927.2994, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id9", "d_catacomb_80_2", Spot(-964.59235, 1106.5237, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id9", "d_catacomb_80_2", Spot(-766.50995, 1159.8467, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id9", "d_catacomb_80_2", Spot(-1577.8044, 1134.8976, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id9", "d_catacomb_80_2", Spot(-1756.4019, 976.7318, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id9", "d_catacomb_80_2", Spot(-1506.8677, 921.88605, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id9", "d_catacomb_80_2", Spot(-1844.076, 297.2771, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id9", "d_catacomb_80_2", Spot(-1665.8282, 218.83179, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id9", "d_catacomb_80_2", Spot(-231.85457, 2000.6986, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id9", "d_catacomb_80_2", Spot(66.8177, 1772.4716, 20));
		AddSpawnPoint( "d_catacomb_80_2.Id9", "d_catacomb_80_2", Spot(171.9674, 1984.0984, 20));

		// ERD_Wendigo_Magician_Blue Spawn Points
		AddSpawnPoint( "d_catacomb_80_2.Id10", "d_catacomb_80_2", Spot(1752.0177, 929.4244, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id10", "d_catacomb_80_2", Spot(-1540.427, 880.3342, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id10", "d_catacomb_80_2", Spot(-1014.7958, 1151.0123, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id10", "d_catacomb_80_2", Spot(-911.5264, 819.11005, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id10", "d_catacomb_80_2", Spot(-810.6069, 1125.4393, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id10", "d_catacomb_80_2", Spot(971.7822, 1152.6377, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id10", "d_catacomb_80_2", Spot(774.87726, 910.7259, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id10", "d_catacomb_80_2", Spot(989.6866, 887.3579, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id10", "d_catacomb_80_2", Spot(-217.30746, 1876.3597, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id10", "d_catacomb_80_2", Spot(-46.20167, 2016.4275, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id10", "d_catacomb_80_2", Spot(-1865.083, 350.7063, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id10", "d_catacomb_80_2", Spot(1878.3584, -6.6033683, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id10", "d_catacomb_80_2", Spot(244.80888, 1849.5215, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id10", "d_catacomb_80_2", Spot(-258.92603, 1699.8353, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id10", "d_catacomb_80_2", Spot(70.60205, 1549.1262, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id10", "d_catacomb_80_2", Spot(180.01263, 2134.9263, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id10", "d_catacomb_80_2", Spot(-1693.546, 1039.5083, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id10", "d_catacomb_80_2", Spot(-1048.5404, 872.473, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id10", "d_catacomb_80_2", Spot(692.9407, 1143.5879, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id10", "d_catacomb_80_2", Spot(1526.1626, 1074.1287, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id10", "d_catacomb_80_2", Spot(-1893.41, -64.58767, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id10", "d_catacomb_80_2", Spot(-1418.2015, 326.57773, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id10", "d_catacomb_80_2", Spot(1358.8138, 293.87982, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id10", "d_catacomb_80_2", Spot(1398.6575, -6.93462, 30));

		// ERD_Kepari_Mage Spawn Points
		AddSpawnPoint( "d_catacomb_80_2.Id11", "d_catacomb_80_2", Spot(55.44724, 1707.2211, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id11", "d_catacomb_80_2", Spot(171.55292, 1979.7174, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id11", "d_catacomb_80_2", Spot(-217.2587, 1628.4844, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id11", "d_catacomb_80_2", Spot(-254.67764, 2087.7102, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id11", "d_catacomb_80_2", Spot(215.63852, 1712.1481, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id11", "d_catacomb_80_2", Spot(-135.79738, 1083.6084, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id11", "d_catacomb_80_2", Spot(-12.137896, 1016.2465, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id11", "d_catacomb_80_2", Spot(38.558987, 1865.6678, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id11", "d_catacomb_80_2", Spot(-908.3048, 1011.5554, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id11", "d_catacomb_80_2", Spot(836.66754, 1032.8639, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id11", "d_catacomb_80_2", Spot(-299.6147, 1807.6786, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id11", "d_catacomb_80_2", Spot(91.590515, 2147.3447, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id11", "d_catacomb_80_2", Spot(-709.82874, 862.1098, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id11", "d_catacomb_80_2", Spot(-711.5678, 1082.2098, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id11", "d_catacomb_80_2", Spot(-866.48334, 1199.2859, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id11", "d_catacomb_80_2", Spot(696.1728, 1212.6423, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id11", "d_catacomb_80_2", Spot(726.38074, 950.0046, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id11", "d_catacomb_80_2", Spot(923.2049, 852.76544, 30));
		AddSpawnPoint( "d_catacomb_80_2.Id11", "d_catacomb_80_2", Spot(-1523.8083, -1005.6925, 30));

		// ERD_Mushroom_Ent_Green Spawn Points
		AddSpawnPoint( "d_catacomb_80_2.Id12", "d_catacomb_80_2", Spot(77.61401, 2065.4219, 40));
		AddSpawnPoint( "d_catacomb_80_2.Id12", "d_catacomb_80_2", Spot(-89.19737, 971.5339, 40));
		AddSpawnPoint( "d_catacomb_80_2.Id12", "d_catacomb_80_2", Spot(-1027.779, 945.4403, 40));
		AddSpawnPoint( "d_catacomb_80_2.Id12", "d_catacomb_80_2", Spot(848.0111, 1136.5311, 40));
		AddSpawnPoint( "d_catacomb_80_2.Id12", "d_catacomb_80_2", Spot(1709.558, 1006.2823, 40));
		AddSpawnPoint( "d_catacomb_80_2.Id12", "d_catacomb_80_2", Spot(-1599.2129, 1057.5555, 40));
		AddSpawnPoint( "d_catacomb_80_2.Id12", "d_catacomb_80_2", Spot(-79.2593, 1606.8542, 40));

		// Rootcrystal_05 Spawn Points
		AddSpawnPoint( "d_catacomb_80_2.Id13", "d_catacomb_80_2", Spot(23.241192, -1090.4701, 100));
		AddSpawnPoint( "d_catacomb_80_2.Id13", "d_catacomb_80_2", Spot(51.60795, -733.72375, 100));
		AddSpawnPoint( "d_catacomb_80_2.Id13", "d_catacomb_80_2", Spot(-1684.6792, -1105.8508, 100));
		AddSpawnPoint( "d_catacomb_80_2.Id13", "d_catacomb_80_2", Spot(-1644.7377, -717.0428, 100));
		AddSpawnPoint( "d_catacomb_80_2.Id13", "d_catacomb_80_2", Spot(-1854.0713, -49.27469, 100));
		AddSpawnPoint( "d_catacomb_80_2.Id13", "d_catacomb_80_2", Spot(-1647.0688, 294.40875, 100));
		AddSpawnPoint( "d_catacomb_80_2.Id13", "d_catacomb_80_2", Spot(-1326.0061, 109.04869, 100));
		AddSpawnPoint( "d_catacomb_80_2.Id13", "d_catacomb_80_2", Spot(-1792.833, 1054.397, 100));
		AddSpawnPoint( "d_catacomb_80_2.Id13", "d_catacomb_80_2", Spot(-860.8018, -1037.6508, 100));
		AddSpawnPoint( "d_catacomb_80_2.Id13", "d_catacomb_80_2", Spot(-1080.0688, 1057.0364, 100));
		AddSpawnPoint( "d_catacomb_80_2.Id13", "d_catacomb_80_2", Spot(-766.72296, 975.15295, 100));
		AddSpawnPoint( "d_catacomb_80_2.Id13", "d_catacomb_80_2", Spot(-166.60924, 1658.4795, 100));
		AddSpawnPoint( "d_catacomb_80_2.Id13", "d_catacomb_80_2", Spot(-281.2525, 2009.7089, 100));
		AddSpawnPoint( "d_catacomb_80_2.Id13", "d_catacomb_80_2", Spot(125.60239, 2125.3167, 100));
		AddSpawnPoint( "d_catacomb_80_2.Id13", "d_catacomb_80_2", Spot(195.86546, 1756.4005, 100));
		AddSpawnPoint( "d_catacomb_80_2.Id13", "d_catacomb_80_2", Spot(-29.643713, 1038.3792, 100));
		AddSpawnPoint( "d_catacomb_80_2.Id13", "d_catacomb_80_2", Spot(650.23346, 1069.0452, 100));
		AddSpawnPoint( "d_catacomb_80_2.Id13", "d_catacomb_80_2", Spot(1023.3911, 867.2363, 100));
		AddSpawnPoint( "d_catacomb_80_2.Id13", "d_catacomb_80_2", Spot(1525.9866, 913.14417, 100));
		AddSpawnPoint( "d_catacomb_80_2.Id13", "d_catacomb_80_2", Spot(1335.1466, -25.90183, 100));
		AddSpawnPoint( "d_catacomb_80_2.Id13", "d_catacomb_80_2", Spot(1797.8472, 156.1257, 100));
		AddSpawnPoint( "d_catacomb_80_2.Id13", "d_catacomb_80_2", Spot(1396.535, -917.8579, 100));
		AddSpawnPoint( "d_catacomb_80_2.Id13", "d_catacomb_80_2", Spot(1375.5037, 344.87146, 100));
		AddSpawnPoint( "d_catacomb_80_2.Id13", "d_catacomb_80_2", Spot(1775.5922, -911.0337, 100));
		AddSpawnPoint( "d_catacomb_80_2.Id13", "d_catacomb_80_2", Spot(797.64197, -765.38416, 100));
		AddSpawnPoint( "d_catacomb_80_2.Id13", "d_catacomb_80_2", Spot(117.22751, -1617.1943, 100));

	}
}
