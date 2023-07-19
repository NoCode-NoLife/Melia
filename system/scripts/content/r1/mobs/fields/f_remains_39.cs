//--- Melia Script -----------------------------------------------------------
// f_remains_39
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Escanciu Village' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FRemains39MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_remains_39", MonsterId.Gravegolem, Properties("MHP", 85709, "MINPATK", 1603, "MAXPATK", 1872, "MINMATK", 1603, "MAXMATK", 1872, "DEF", 713, "MDEF", 713));
		AddPropertyOverrides("f_remains_39", MonsterId.Zolem, Properties("MHP", 85916, "MINPATK", 1606, "MAXPATK", 1875, "MINMATK", 1606, "MAXMATK", 1875, "DEF", 720, "MDEF", 720));
		AddPropertyOverrides("f_remains_39", MonsterId.Flying_Flog, Properties("MHP", 86296, "MINPATK", 1611, "MAXPATK", 1881, "MINMATK", 1611, "MAXMATK", 1881, "DEF", 732, "MDEF", 732));
		AddPropertyOverrides("f_remains_39", MonsterId.Hook, Properties("MHP", 86787, "MINPATK", 1617, "MAXPATK", 1889, "MINMATK", 1617, "MAXMATK", 1889, "DEF", 748, "MDEF", 748));

		// Monster Spawners ---------------------------------

		AddSpawner("f_remains_39.Id1", MonsterId.Gravegolem, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_39.Id2", MonsterId.Zolem, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_39.Id3", MonsterId.Hook, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_39.Id4", MonsterId.Zolem, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_39.Id5", MonsterId.Hook, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_39.Id6", MonsterId.Flying_Flog, 10, 13, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_39.Id7", MonsterId.Zolem, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_39.Id8", MonsterId.Gravegolem, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_39.Id9", MonsterId.Rootcrystal_01, 13, 17, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Gravegolem' GenType 2 Spawn Points
		AddSpawnPoint("f_remains_39.Id1", "f_remains_39", Rectangle(979.49, 295.05, 25));
		AddSpawnPoint("f_remains_39.Id1", "f_remains_39", Rectangle(982.10803, 80.06974, 25));
		AddSpawnPoint("f_remains_39.Id1", "f_remains_39", Rectangle(869.5153, 523.50574, 25));
		AddSpawnPoint("f_remains_39.Id1", "f_remains_39", Rectangle(992.1184, 571.9906, 25));
		AddSpawnPoint("f_remains_39.Id1", "f_remains_39", Rectangle(1148.0114, 499.5058, 25));
		AddSpawnPoint("f_remains_39.Id1", "f_remains_39", Rectangle(1156.6945, 269.68744, 25));
		AddSpawnPoint("f_remains_39.Id1", "f_remains_39", Rectangle(1112.125, 67.97649, 25));
		AddSpawnPoint("f_remains_39.Id1", "f_remains_39", Rectangle(973.8489, -76.47476, 25));
		AddSpawnPoint("f_remains_39.Id1", "f_remains_39", Rectangle(1149.4037, -116.78101, 25));
		AddSpawnPoint("f_remains_39.Id1", "f_remains_39", Rectangle(842.2224, 377.45227, 25));
		AddSpawnPoint("f_remains_39.Id1", "f_remains_39", Rectangle(933.9291, 742.1825, 25));

		// 'Zolem' GenType 3 Spawn Points
		AddSpawnPoint("f_remains_39.Id2", "f_remains_39", Rectangle(470.49753, -404.8022, 25));
		AddSpawnPoint("f_remains_39.Id2", "f_remains_39", Rectangle(297.06744, -523.1442, 25));
		AddSpawnPoint("f_remains_39.Id2", "f_remains_39", Rectangle(359.53494, -426.29715, 25));
		AddSpawnPoint("f_remains_39.Id2", "f_remains_39", Rectangle(508.69473, -564.8934, 25));
		AddSpawnPoint("f_remains_39.Id2", "f_remains_39", Rectangle(544.5396, -362.7436, 25));
		AddSpawnPoint("f_remains_39.Id2", "f_remains_39", Rectangle(646.1158, -506.68292, 25));
		AddSpawnPoint("f_remains_39.Id2", "f_remains_39", Rectangle(685.6399, -375.42706, 25));

		// 'Hook' GenType 7 Spawn Points
		AddSpawnPoint("f_remains_39.Id3", "f_remains_39", Rectangle(-356, 517, 9999));

		// 'Zolem' GenType 46 Spawn Points
		AddSpawnPoint("f_remains_39.Id4", "f_remains_39", Rectangle(1015.88, 1062.2, 9999));

		// 'Hook' GenType 47 Spawn Points
		AddSpawnPoint("f_remains_39.Id5", "f_remains_39", Rectangle(-569.13, -67.26, 25));
		AddSpawnPoint("f_remains_39.Id5", "f_remains_39", Rectangle(-623.6254, -165.5577, 25));
		AddSpawnPoint("f_remains_39.Id5", "f_remains_39", Rectangle(-797.749, 98.39174, 25));
		AddSpawnPoint("f_remains_39.Id5", "f_remains_39", Rectangle(-538.6195, 143.87885, 25));
		AddSpawnPoint("f_remains_39.Id5", "f_remains_39", Rectangle(-682.87714, 483.71082, 25));
		AddSpawnPoint("f_remains_39.Id5", "f_remains_39", Rectangle(-714.7291, 636.1156, 25));
		AddSpawnPoint("f_remains_39.Id5", "f_remains_39", Rectangle(-393.1209, 417.40393, 25));
		AddSpawnPoint("f_remains_39.Id5", "f_remains_39", Rectangle(-796.6606, -65.4286, 25));
		AddSpawnPoint("f_remains_39.Id5", "f_remains_39", Rectangle(-391.37198, -288.7061, 25));
		AddSpawnPoint("f_remains_39.Id5", "f_remains_39", Rectangle(-511.47006, -335.3751, 25));
		AddSpawnPoint("f_remains_39.Id5", "f_remains_39", Rectangle(-767.306, -370.44562, 25));

		// 'Flying_Flog' GenType 48 Spawn Points
		AddSpawnPoint("f_remains_39.Id6", "f_remains_39", Rectangle(-560.0713, 558.1887, 25));
		AddSpawnPoint("f_remains_39.Id6", "f_remains_39", Rectangle(-718.12274, 605.61383, 25));
		AddSpawnPoint("f_remains_39.Id6", "f_remains_39", Rectangle(-651.60077, 748.52795, 25));
		AddSpawnPoint("f_remains_39.Id6", "f_remains_39", Rectangle(-379.64673, 619.24866, 25));
		AddSpawnPoint("f_remains_39.Id6", "f_remains_39", Rectangle(-538.9483, 268.2995, 25));
		AddSpawnPoint("f_remains_39.Id6", "f_remains_39", Rectangle(-391.38626, 384.25278, 25));
		AddSpawnPoint("f_remains_39.Id6", "f_remains_39", Rectangle(-777.267, 398.17194, 25));
		AddSpawnPoint("f_remains_39.Id6", "f_remains_39", Rectangle(251.20483, -483.88577, 25));
		AddSpawnPoint("f_remains_39.Id6", "f_remains_39", Rectangle(344.36392, -358.90253, 25));
		AddSpawnPoint("f_remains_39.Id6", "f_remains_39", Rectangle(474.74786, -496.07224, 25));
		AddSpawnPoint("f_remains_39.Id6", "f_remains_39", Rectangle(692.0622, -240.72818, 25));
		AddSpawnPoint("f_remains_39.Id6", "f_remains_39", Rectangle(66.60441, -314.35007, 25));
		AddSpawnPoint("f_remains_39.Id6", "f_remains_39", Rectangle(588.8451, -405.44476, 25));
		AddSpawnPoint("f_remains_39.Id6", "f_remains_39", Rectangle(676.8437, -556.2236, 25));

		// 'Zolem' GenType 50 Spawn Points
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(-1331.5692, -416.90387, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(-1222.1074, -329.1595, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(-993.98663, -432.42987, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(-921.53784, -184.95477, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(-542.01294, -198.76392, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(-403.24442, -370.48416, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(-531.26337, -679.88904, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(-1142.7701, -79.15982, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(-1048.2003, -722.2287, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(-901.0685, -590.18494, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(33.389626, -225.45877, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(134.97217, -197.34589, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(72.08918, -357.05844, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(169.76593, -507.8878, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(349.76944, -168.66286, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(345.87546, -494.3805, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(399.575, -579.925, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(568.9871, -483.7489, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(644.2752, -303.65408, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(626.54065, -218.56657, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(482.9316, -344.9525, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(733.6474, -307.08887, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(299.06757, -395.60345, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(942.65765, 1179.1792, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(971.08325, 1033.702, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(1149.3187, 1174.8123, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(894.9346, 1055.8811, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(865.71234, 1169.9884, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(823.96173, 1279.8112, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(1067.4304, 1083.4623, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(1025.4855, 1271.4358, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(1151.5525, 1380.8735, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(1075.5122, 1492.996, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(1026.4235, 1377.6821, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(902.43915, 1444.9657, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(896.7489, 1577.4281, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(962.2955, 1588.8018, 30));
		AddSpawnPoint("f_remains_39.Id7", "f_remains_39", Rectangle(1109.1215, 1378.2554, 30));

		// 'Gravegolem' GenType 51 Spawn Points
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(360.88892, -408.43646, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(546.1072, -435.46237, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(716.03937, -423.0482, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(665.425, -557.5505, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(933.54926, -116.07328, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(485.2228, -550.9971, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(1014.2253, -494.5187, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(871.94586, -409.28668, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-1313.8873, -314.67123, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-1339.4059, -75.35178, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-1142.2855, 49.513214, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-1027.0325, 84.61935, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-937.35913, -37.918022, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-1181.6552, -160.44312, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-1228.6067, -390.34885, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-1409.1052, -499.01984, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-1261.1427, -549.1282, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-1040.914, -806.2362, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-1132.5627, -729.15625, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-1010.2055, -319.35043, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-884.9307, -377.4626, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-690.6052, -735.2225, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-714.1011, -664.99786, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-696.70197, -517.14105, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-598.0578, -447.26315, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-467.52026, -443.28223, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-436.40628, -533.7204, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-471.7512, -256.0322, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-676.6626, -238.3283, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-430.2173, -160.05309, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-677.56665, -62.293175, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-736.41205, -37.087852, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-792.48975, 12.918118, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-682.0462, 33.916954, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-673.59656, 194.82611, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-478.2641, 195.49628, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-458.64682, 83.03755, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-423.68015, 18.028328, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-756.8033, 322.42572, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-750.1284, 465.58057, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-433.3955, 281.58487, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-421.21643, 551.69275, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-471.31668, 693.1474, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-597.91907, 794.52734, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(-746.5719, 744.56885, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(1069.6, -311.7248, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(1154.7897, -317.02097, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(1166.2831, -249.29419, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(1075.754, -85.7403, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(897.7751, 133.74658, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(881.12854, 283.4272, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(797.55725, 331.99026, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(1030.198, 233.3704, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(1171.1909, 352.00037, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(1155.2798, 423.32776, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(989.45935, 511.5763, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(916.2117, 633.42065, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(857.61084, 586.96173, 30));
		AddSpawnPoint("f_remains_39.Id8", "f_remains_39", Rectangle(1009.1936, 682.2646, 30));

		// 'Rootcrystal_01' GenType 54 Spawn Points
		AddSpawnPoint("f_remains_39.Id9", "f_remains_39", Rectangle(-1228.0762, -364.91287, 200));
		AddSpawnPoint("f_remains_39.Id9", "f_remains_39", Rectangle(-1233.333, -52.12926, 200));
		AddSpawnPoint("f_remains_39.Id9", "f_remains_39", Rectangle(-997.29364, -652.33374, 200));
		AddSpawnPoint("f_remains_39.Id9", "f_remains_39", Rectangle(-884.46844, -297.12048, 200));
		AddSpawnPoint("f_remains_39.Id9", "f_remains_39", Rectangle(-536.83716, -543.74854, 200));
		AddSpawnPoint("f_remains_39.Id9", "f_remains_39", Rectangle(-504.86328, -136.94818, 200));
		AddSpawnPoint("f_remains_39.Id9", "f_remains_39", Rectangle(-566.94977, 248.27347, 200));
		AddSpawnPoint("f_remains_39.Id9", "f_remains_39", Rectangle(-593.46985, 554.3878, 200));
		AddSpawnPoint("f_remains_39.Id9", "f_remains_39", Rectangle(305.55548, -300.80585, 200));
		AddSpawnPoint("f_remains_39.Id9", "f_remains_39", Rectangle(591.86365, -448.6558, 200));
		AddSpawnPoint("f_remains_39.Id9", "f_remains_39", Rectangle(1078.1501, -349.7512, 200));
		AddSpawnPoint("f_remains_39.Id9", "f_remains_39", Rectangle(1025.9962, -5.725052, 200));
		AddSpawnPoint("f_remains_39.Id9", "f_remains_39", Rectangle(987.96625, 364.78552, 200));
		AddSpawnPoint("f_remains_39.Id9", "f_remains_39", Rectangle(934.4758, 734.47363, 200));
		AddSpawnPoint("f_remains_39.Id9", "f_remains_39", Rectangle(1010.257, 1079.4291, 200));
		AddSpawnPoint("f_remains_39.Id9", "f_remains_39", Rectangle(996.9733, 1415.082, 200));
	}
}
