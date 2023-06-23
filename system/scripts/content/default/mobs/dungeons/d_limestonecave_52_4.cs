//--- Melia Script -----------------------------------------------------------
// d_limestonecave_52_4
//
//--- Description -----------------------------------------------------------
// Sets up the d_limestonecave_52_4 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class DLimestonecave524MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("d_limestonecave_52_4", MonsterId.Zolem_Green, Properties("MHP", 496851, "MINPATK", 6890, "MAXPATK", 8370, "MINMATK", 6890, "MAXMATK", 8370, "DEF", 78968, "MDEF", 78968));
		AddPropertyOverrides("d_limestonecave_52_4", MonsterId.Flamag_Green, Properties("MHP", 499404, "MINPATK", 6923, "MAXPATK", 8410, "MINMATK", 6923, "MAXMATK", 8410, "DEF", 79992, "MDEF", 79992));
		AddPropertyOverrides("d_limestonecave_52_4", MonsterId.Flamme_Archer_Green, Properties("MHP", 502009, "MINPATK", 6956, "MAXPATK", 8451, "MINMATK", 6956, "MAXMATK", 8451, "DEF", 81037, "MDEF", 81037));

		// Monster Populations
		AddMonsterPopulation("d_limestonecave_52_4", "population_zolem_green_1", 20);
		AddMonsterPopulation("d_limestonecave_52_4", "population_flamag_green_2", 25);
		AddMonsterPopulation("d_limestonecave_52_4", "population_flamme_archer_green_3", 25);
		AddMonsterPopulation("d_limestonecave_52_4", "population_zolem_green_4", 25);
		AddMonsterPopulation("d_limestonecave_52_4", "population_rootcrystal_04_5", 25);

		// RootCrystal Spawners
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(30000), "d_limestonecave_52_4", Spot(2087.68, -1874.26, 15));
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(30000), "d_limestonecave_52_4", Spot(2159.94, -1137.33, 15));
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(30000), "d_limestonecave_52_4", Spot(2184.98, -894.24, 15));
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(30000), "d_limestonecave_52_4", Spot(2374.01, -533.53, 15));
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(30000), "d_limestonecave_52_4", Spot(2537.8, -371.6, 15));
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(30000), "d_limestonecave_52_4", Spot(2177.78, -233.07, 15));
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(30000), "d_limestonecave_52_4", Spot(1797.16, -141.17, 15));
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(30000), "d_limestonecave_52_4", Spot(1431.85, -699.31, 15));
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(30000), "d_limestonecave_52_4", Spot(1296.36, -1189.37, 15));
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(30000), "d_limestonecave_52_4", Spot(999.4, -1669.67, 15));
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(30000), "d_limestonecave_52_4", Spot(724.62, -1808.25, 15));
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(30000), "d_limestonecave_52_4", Spot(362.74, -1488.3, 15));
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(30000), "d_limestonecave_52_4", Spot(142.38, -1206.85, 15));
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(30000), "d_limestonecave_52_4", Spot(-107.48, -1099.38, 15));
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(30000), "d_limestonecave_52_4", Spot(-208.14, -966.63, 15));
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(30000), "d_limestonecave_52_4", Spot(-366.28, -621.27, 15));
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(30000), "d_limestonecave_52_4", Spot(-534.89, -356.17, 15));
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(30000), "d_limestonecave_52_4", Spot(-875.92, -175.16, 15));
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(30000), "d_limestonecave_52_4", Spot(-729.59, 210.94, 15));
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(30000), "d_limestonecave_52_4", Spot(-314.94, -114.32, 15));
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(30000), "d_limestonecave_52_4", Spot(-184.1, 284.93, 15));
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(30000), "d_limestonecave_52_4", Spot(157.05, 358.9, 15));
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(30000), "d_limestonecave_52_4", Spot(-1678.28, -668.74, 15));
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(30000), "d_limestonecave_52_4", Spot(-1401.92, 631.33, 15));
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(30000), "d_limestonecave_52_4", Spot(-1225.24, 300.11, 15));

		// Monster Spawners
		AddSpawner(MonsterId.Zolem_Green, "population_zolem_green_1", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(2279.4678, -1013.1711, 45));
		AddSpawner(MonsterId.Zolem_Green, "population_zolem_green_1", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(1631.7692, -315.32782, 45));
		AddSpawner(MonsterId.Zolem_Green, "population_zolem_green_1", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(1501.7703, -1025.2203, 45));
		AddSpawner(MonsterId.Zolem_Green, "population_zolem_green_1", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(1233.9161, -1153.01, 45));
		AddSpawner(MonsterId.Zolem_Green, "population_zolem_green_1", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(1224.8242, -921.25696, 45));
		AddSpawner(MonsterId.Zolem_Green, "population_zolem_green_1", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(735.94586, -1892.4015, 45));
		AddSpawner(MonsterId.Zolem_Green, "population_zolem_green_1", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(113.70205, -1394.5054, 45));
		AddSpawner(MonsterId.Zolem_Green, "population_zolem_green_1", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-67.10196, -887.8268, 45));
		AddSpawner(MonsterId.Zolem_Green, "population_zolem_green_1", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-447.0223, -72.71815, 45));
		AddSpawner(MonsterId.Zolem_Green, "population_zolem_green_1", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-907.43604, -241.3328, 45));
		AddSpawner(MonsterId.Zolem_Green, "population_zolem_green_1", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-1545.9224, -806.3809, 45));
		AddSpawner(MonsterId.Zolem_Green, "population_zolem_green_1", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-46.83775, 367.52478, 45));
		AddSpawner(MonsterId.Zolem_Green, "population_zolem_green_1", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(2268.8625, -948.72925, 45));
		AddSpawner(MonsterId.Zolem_Green, "population_zolem_green_1", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(873.3945, -1916.3132, 45));
		AddSpawner(MonsterId.Zolem_Green, "population_zolem_green_1", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(1037.4172, -1767.0223, 45));
		AddSpawner(MonsterId.Zolem_Green, "population_zolem_green_1", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(793.7337, -1621.4656, 45));
		AddSpawner(MonsterId.Zolem_Green, "population_zolem_green_1", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(770.36273, -1471.242, 45));
		AddSpawner(MonsterId.Zolem_Green, "population_zolem_green_1", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(1055.4905, -1674.4175, 45));
		AddSpawner(MonsterId.Zolem_Green, "population_zolem_green_1", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-144.6793, -984.39655, 45));
		AddSpawner(MonsterId.Zolem_Green, "population_zolem_green_1", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-341.41476, -846.5325, 45));
		AddSpawner(MonsterId.Flamag_Green, "population_flamag_green_2", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-25.287655, 379.77542, 45));
		AddSpawner(MonsterId.Flamag_Green, "population_flamag_green_2", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-513.0322, 75.80184, 45));
		AddSpawner(MonsterId.Flamag_Green, "population_flamag_green_2", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-614.76904, -434.1506, 45));
		AddSpawner(MonsterId.Flamag_Green, "population_flamag_green_2", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-1695.2705, -883.48, 45));
		AddSpawner(MonsterId.Flamag_Green, "population_flamag_green_2", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(101.66732, -1315.6512, 45));
		AddSpawner(MonsterId.Flamag_Green, "population_flamag_green_2", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(927.14087, -1700.2672, 45));
		AddSpawner(MonsterId.Flamag_Green, "population_flamag_green_2", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(1248.2192, -1025.757, 45));
		AddSpawner(MonsterId.Flamag_Green, "population_flamag_green_2", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(1104.9739, -925.9262, 45));
		AddSpawner(MonsterId.Flamag_Green, "population_flamag_green_2", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(1492.0354, -874.7647, 45));
		AddSpawner(MonsterId.Flamag_Green, "population_flamag_green_2", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(1640.4371, -158.73412, 45));
		AddSpawner(MonsterId.Flamag_Green, "population_flamag_green_2", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(2157.1587, -993.9519, 45));
		AddSpawner(MonsterId.Flamag_Green, "population_flamag_green_2", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(1760.2542, -362.48535, 45));
		AddSpawner(MonsterId.Flamag_Green, "population_flamag_green_2", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(1723.2819, -53.98112, 45));
		AddSpawner(MonsterId.Flamag_Green, "population_flamag_green_2", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(2085.2185, -1188.7705, 45));
		AddSpawner(MonsterId.Flamag_Green, "population_flamag_green_2", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(2248.1167, -885.5199, 45));
		AddSpawner(MonsterId.Flamag_Green, "population_flamag_green_2", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(607.2293, -1690.5684, 45));
		AddSpawner(MonsterId.Flamag_Green, "population_flamag_green_2", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(461.88736, -1692.0881, 45));
		AddSpawner(MonsterId.Flamag_Green, "population_flamag_green_2", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-165.5759, -739.5062, 45));
		AddSpawner(MonsterId.Flamag_Green, "population_flamag_green_2", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-273.86972, -797.9275, 45));
		AddSpawner(MonsterId.Flamag_Green, "population_flamag_green_2", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-291.47028, -961.21716, 45));
		AddSpawner(MonsterId.Flamag_Green, "population_flamag_green_2", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-155.46698, -869.28754, 45));
		AddSpawner(MonsterId.Flamag_Green, "population_flamag_green_2", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-185.23047, -1041.3333, 45));
		AddSpawner(MonsterId.Flamag_Green, "population_flamag_green_2", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-226.15503, -890.08167, 45));
		AddSpawner(MonsterId.Flamag_Green, "population_flamag_green_2", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-430.3452, -354.1605, 45));
		AddSpawner(MonsterId.Flamag_Green, "population_flamag_green_2", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-1559.6001, -896.7326, 45));
		AddSpawner(MonsterId.Flamag_Green, "population_flamag_green_2", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-1512.0458, -526.2992, 45));
		AddSpawner(MonsterId.Flamag_Green, "population_flamag_green_2", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-1775.0099, -683.47284, 45));
		AddSpawner(MonsterId.Flamag_Green, "population_flamag_green_2", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-1548.5247, -694.8876, 45));
		AddSpawner(MonsterId.Flamag_Green, "population_flamag_green_2", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-1633.2804, -628.1064, 45));
		AddSpawner(MonsterId.Flamme_Archer_Green, "population_flamme_archer_green_3", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(2201.485, -1071.418, 45));
		AddSpawner(MonsterId.Flamme_Archer_Green, "population_flamme_archer_green_3", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(1872.5594, -149.8516, 45));
		AddSpawner(MonsterId.Flamme_Archer_Green, "population_flamme_archer_green_3", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(1397.5205, -802.67706, 45));
		AddSpawner(MonsterId.Flamme_Archer_Green, "population_flamme_archer_green_3", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(1317.6488, -1123.231, 45));
		AddSpawner(MonsterId.Flamme_Archer_Green, "population_flamme_archer_green_3", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(1420.9974, -955.2497, 45));
		AddSpawner(MonsterId.Flamme_Archer_Green, "population_flamme_archer_green_3", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(926.71674, -1607.5188, 45));
		AddSpawner(MonsterId.Flamme_Archer_Green, "population_flamme_archer_green_3", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(420.78088, -1609.3058, 45));
		AddSpawner(MonsterId.Flamme_Archer_Green, "population_flamme_archer_green_3", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(101.29082, -1434.7999, 45));
		AddSpawner(MonsterId.Flamme_Archer_Green, "population_flamme_archer_green_3", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-63.391434, -1270.3402, 45));
		AddSpawner(MonsterId.Flamme_Archer_Green, "population_flamme_archer_green_3", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-383.65265, -672.96295, 45));
		AddSpawner(MonsterId.Flamme_Archer_Green, "population_flamme_archer_green_3", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-923.7198, -260.63995, 45));
		AddSpawner(MonsterId.Flamme_Archer_Green, "population_flamme_archer_green_3", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-980.68317, 122.07312, 45));
		AddSpawner(MonsterId.Flamme_Archer_Green, "population_flamme_archer_green_3", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-18.00848, 408.54086, 45));
		AddSpawner(MonsterId.Flamme_Archer_Green, "population_flamme_archer_green_3", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-1670.4072, -710.4915, 45));
		AddSpawner(MonsterId.Flamme_Archer_Green, "population_flamme_archer_green_3", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(1756.5957, -219.28545, 45));
		AddSpawner(MonsterId.Flamme_Archer_Green, "population_flamme_archer_green_3", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(2108.2844, -1043.816, 45));
		AddSpawner(MonsterId.Flamme_Archer_Green, "population_flamme_archer_green_3", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(2058.4395, -1531.9835, 45));
		AddSpawner(MonsterId.Flamme_Archer_Green, "population_flamme_archer_green_3", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(2089.085, -1414.8473, 45));
		AddSpawner(MonsterId.Flamme_Archer_Green, "population_flamme_archer_green_3", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(2003.5347, -1670.5272, 45));
		AddSpawner(MonsterId.Flamme_Archer_Green, "population_flamme_archer_green_3", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(1963.064, -1757.623, 45));
		AddSpawner(MonsterId.Flamme_Archer_Green, "population_flamme_archer_green_3", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(2117.3757, -1753.4122, 45));
		AddSpawner(MonsterId.Flamme_Archer_Green, "population_flamme_archer_green_3", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(2133.182, -1665.8932, 45));
		AddSpawner(MonsterId.Flamme_Archer_Green, "population_flamme_archer_green_3", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(2079.705, -1700.6436, 45));
		AddSpawner(MonsterId.Flamme_Archer_Green, "population_flamme_archer_green_3", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(902.50037, -1847.8699, 45));
		AddSpawner(MonsterId.Flamme_Archer_Green, "population_flamme_archer_green_3", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(698.0756, -1769.5436, 45));
		AddSpawner(MonsterId.Flamme_Archer_Green, "population_flamme_archer_green_3", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(763.7326, -1718.6488, 45));
		AddSpawner(MonsterId.Flamme_Archer_Green, "population_flamme_archer_green_3", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-1.3127127, -1180.364, 45));
		AddSpawner(MonsterId.Flamme_Archer_Green, "population_flamme_archer_green_3", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(255.14378, -1239.2711, 45));
		AddSpawner(MonsterId.Flamme_Archer_Green, "population_flamme_archer_green_3", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(236.22498, -1337.3767, 45));
		AddSpawner(MonsterId.Flamme_Archer_Green, "population_flamme_archer_green_3", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-68.351906, -1348.8163, 45));
		AddSpawner(MonsterId.Flamme_Archer_Green, "population_flamme_archer_green_3", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-444.78094, -526.1901, 45));
		AddSpawner(MonsterId.Flamme_Archer_Green, "population_flamme_archer_green_3", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-766.62396, -405.39346, 45));
		AddSpawner(MonsterId.Flamme_Archer_Green, "population_flamme_archer_green_3", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-448.7345, -62.25855, 45));
		AddSpawner(MonsterId.Flamme_Archer_Green, "population_flamme_archer_green_3", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-471.93747, 195.21877, 45));
		AddSpawner(MonsterId.Flamme_Archer_Green, "population_flamme_archer_green_3", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-638.0221, 167.04036, 45));
		AddSpawner(MonsterId.Flamme_Archer_Green, "population_flamme_archer_green_3", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-728.5089, 65.22606, 45));
		AddSpawner(MonsterId.Flamme_Archer_Green, "population_flamme_archer_green_3", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-815.05444, -28.957968, 45));
		AddSpawner(MonsterId.Flamme_Archer_Green, "population_flamme_archer_green_3", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(-1642.8783, -874.6179, 45));
		AddSpawner(MonsterId.Zolem_Green, "population_zolem_green_4", TimeSpan.FromMilliseconds(0), "d_limestonecave_52_4", Spot(1093.0426, -1292.658, 9999));

	}
}
