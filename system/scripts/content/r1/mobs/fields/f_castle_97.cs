//--- Melia Script -----------------------------------------------------------
// f_castle_97
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Vienibe Shelter' map.
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
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(-60.564327, -12.558523, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(-110.00838, 217.19107, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(-320.1108, 393.54163, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(-12.245018, 419.63248, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(-194.5026, 691.992, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(10.14617, 660.7292, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(756.5179, 76.44591, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(927.46985, -19.745476, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1016.2389, 201.64395, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1667.1233, -97.91653, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1879.9348, 52.08098, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1803.8881, 275.4929, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1822.6019, 109.70666, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1833.9799, -44.35753, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(2012.9575, 65.699585, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(2046.402, 1008.2736, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(2012.882, 868.23627, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1727.2831, 993.39136, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1547.1211, 880.5731, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1290.6097, 848.6745, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1092.219, 1043.1029, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1459.1052, 862.17395, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1895.8601, 828.83044, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1904.2391, 1027.2195, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1842.9673, 510.58075, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(-258.9264, -100.64423, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(-118.6535, -386.09213, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(-109.8171, -656.2202, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(-256.3149, -752.9908, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(-127.60447, -944.8582, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(69.81088, -794.16534, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(47.294285, -899.5718, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(532.8872, -839.0636, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(751.4967, -799.92865, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1115.1714, -917.2467, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1298.1746, -1012.853, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1477.0414, -814.93286, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1279.2687, -689.0279, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1125.8247, -647.7712, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1383.096, 137.90735, 30));
		AddSpawnPoint("f_castle_97.Id1", "f_castle_97", Rectangle(1682.892, 242.24985, 30));

		// 'Poevita' GenType 2 Spawn Points
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(-457.63504, 113.65475, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1638.2512, 273.7015, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1810.4685, 399.7776, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1804.2335, 619.3992, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1681.9144, 857.3107, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1330.3279, 945.76746, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1193.2056, 1092.0833, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1105.4779, 926.0394, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1627.978, 1044.3505, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1811.0927, 1098.4719, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(2001.2745, 1135.2667, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(2149.993, 1005.7, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(2126.7258, 867.72076, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1803.7753, 896.529, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1981.978, -69.33157, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(2086.572, 109.39362, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1667.7518, 70.086365, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1499.8124, 90.73804, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1328.9834, 67.892136, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1121.1682, 122.1887, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1114.8557, -48.217358, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(914.3018, 97.86073, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(810.3491, -77.86499, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(884.2726, 234.90984, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1118.6772, 282.28952, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(608.864, 121.03883, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(431.16547, 65.03757, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(237.4219, 136.49414, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(15.522171, -152.67574, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(-131.40103, -149.12787, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(-248.67679, 15.694069, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(39.06408, 82.14019, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(28.985216, 281.01572, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(-272.5089, 220.44017, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(-178.78288, 439.54523, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(-126.54008, 337.63626, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(-82.79603, 551.81494, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(-246.68144, 575.4024, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(-148.49478, 792.54156, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(66.18928, 840.52594, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(109.65958, 472.9611, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(-334.39584, 805.2709, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(-341.04703, -219.84814, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(-101.42159, -531.66174, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(-181.4537, -690.8069, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(-369.30972, -776.1655, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(-325.4043, -975.11475, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(-226.89622, -880.71735, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(-94.82706, -796.31805, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1.0699005, -957.0807, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(28.50436, -710.16895, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(150.67535, -922.58514, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(303.2274, -850.64276, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(452.70294, -837.58344, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(595.84686, -790.5322, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(846.3287, -852.71155, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(956.2585, -798.05945, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1099.8296, -771.7391, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1406.6442, -665.3722, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1280.1569, -902.54913, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1165.829, -1049.6951, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1476.4388, -1078.7822, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1558.7826, -958.4002, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1435.7212, -952.092, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1550.4749, -643.4851, 35));
		AddSpawnPoint("f_castle_97.Id2", "f_castle_97", Rectangle(1329.6915, -803.76495, 35));

		// 'Poevita' GenType 3 Spawn Points
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-691.636, 128.03848, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-923.7648, 60.178764, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-1117.9829, 173.59949, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-1303.3013, 45.355545, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-1492.6566, 53.041542, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-1488.2631, 276.8935, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-1360.7897, 412.91345, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-1358.8552, 644.3522, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-1333.6986, 821.0248, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-1497.694, 1081.7131, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-1365.2386, 1199.7765, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-1219.118, 1140.4524, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-1114.682, 988.64496, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-1090.7095, 1167.7336, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-1571.8008, 944.21906, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-1990.4587, 1105.967, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-2078.1, 1236.9049, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-1653.4651, 233.54791, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-1769.992, 185.68237, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-1810.0953, 248.31993, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-2049.9885, 124.94305, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-2299.491, 120.46921, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-2269.719, 255.17612, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-2182.4343, 394.13498, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-2312.3442, 404.78757, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-2069.4468, 414.56726, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-2173.445, -136.45702, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-2197.253, -335.2556, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-2359.1697, -426.95865, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-2398.642, -638.20874, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-2112.2292, -677.18274, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-2050.3623, -516.7331, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-2115.847, -785.3628, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-1994.3253, -392.88327, 35));
		AddSpawnPoint("f_castle_97.Id3", "f_castle_97", Rectangle(-1176.4222, 81.40005, 35));

		// 'Pawnta' GenType 4 Spawn Points
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1266.5215, 148.66544, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1203.7638, 277.3203, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1486.9014, 143.45457, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1426.5963, 381.60303, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1892.341, 234.72725, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-2109.1575, 281.17572, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-2376.9402, 254.10556, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-2195.121, -41.715027, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-2180.5166, -206.17854, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-2116.8079, -402.7599, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-2372.4058, -511.97437, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-2370.829, -704.6087, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-2239.2832, -635.62366, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1973.9313, -572.89886, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-2181.824, -540.61554, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-2008.1722, -677.6646, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1509.0146, 312.29327, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1102.2847, 260.18292, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1378.971, 553.5045, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1352.2954, 741.62946, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1377.9915, 940.6292, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1529.2151, 1017.6074, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1521.3804, 1207.4825, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1357.0133, 1102.6957, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1184.4126, 1245.2848, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1033.4237, 1281.2247, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1031.5974, 1022.0457, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1230.6556, 979.8826, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1797.5875, 993.8787, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1705.0974, 1034.2124, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1950.7264, 954.53516, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-2149.766, 996.8225, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-2188.4563, 1142.8752, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1934.1215, 1254.7562, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-2074.3955, 1333.1729, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1886.1073, 1047.8401, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1345.0819, 216.58511, 25));
		AddSpawnPoint("f_castle_97.Id4", "f_castle_97", Rectangle(-1393.6818, 124.75556, 25));

		// 'Poana' GenType 5 Spawn Points
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(1145.7473, 840.1759, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(1624.3901, 980.06555, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(1840.0756, 992.4156, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(2039.2635, 944.41693, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(2012.3134, 138.50703, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(1883.9421, -110.39725, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(1636.2107, 131.20851, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(1040.216, 80.010956, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(854.22327, 64.93249, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(-123.68154, 106.03776, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(-332.40854, -40.16468, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(-235.88219, 334.84094, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(-322.25275, 500.11713, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(-63.320953, 672.4699, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(38.66045, 546.99817, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(117.33532, 672.41614, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(97.47527, 133.72096, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(-392.76672, -884.0629, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(-66.69182, -858.7275, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(124.93007, -739.35974, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(152.07683, -860.30585, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(1204.3177, -857.0476, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(727.1626, -865.41516, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(864.3192, -789.3541, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(1416.8689, -748.6978, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(1378.1174, -991.9884, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(1072.5497, -1025.8098, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(1559.3022, -760.6374, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(1519.3683, -1052.1821, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(-42.038555, 322.73038, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(-92.41502, -83.73856, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(-361.96445, -682.7927, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(-160.17122, -995.4318, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(-59.439148, -430.16074, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(-802.0598, 76.09308, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(-581.93604, 131.30936, 30));
		AddSpawnPoint("f_castle_97.Id5", "f_castle_97", Rectangle(-885.6134, 135.40567, 30));

		// 'Poana' GenType 6 Spawn Points
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-2098.1135, -593.33307, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-2238.6865, -744.2395, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-2386.2815, -585.31476, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-2211.7817, -403.99728, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-2187.3816, 99.79607, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-2402.9797, 113.15082, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-2209.4785, 322.84473, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-2020.6318, 251.9422, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-1713.8915, 252.92322, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-1502.7217, 386.1838, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-1217.8159, 183.8202, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-1221.376, 417.7125, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-1449.1501, 943.586, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-1607.374, 1123.2838, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-1450.7756, 1153.3319, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-1272.6693, 1048.8774, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-1244.908, 1222.5782, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-1115.3914, 1074.8201, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-1096.3284, 1273.6696, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-1019.7842, 1121.1179, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-2051.8145, 938.2521, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-2046.4694, 1017.4959, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-2131.3362, 1217.113, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-1962.22, 1198.1124, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-1974.2567, 1312.3895, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-2217.6265, -166.94337, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-2144.2266, -75.86507, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-1843.7872, 199.42995, 30));
		AddSpawnPoint("f_castle_97.Id6", "f_castle_97", Rectangle(-1533.6935, 175.13904, 30));

		// 'Castle_Beetle' GenType 9 Spawn Points
		AddSpawnPoint("f_castle_97.Id7", "f_castle_97", Rectangle(-2230.0798, 214.25339, 100));
		AddSpawnPoint("f_castle_97.Id7", "f_castle_97", Rectangle(-1469.3181, 302.4644, 100));
		AddSpawnPoint("f_castle_97.Id7", "f_castle_97", Rectangle(-1233.0132, 90.96463, 100));
		AddSpawnPoint("f_castle_97.Id7", "f_castle_97", Rectangle(-1167.5736, 1131.7646, 100));
		AddSpawnPoint("f_castle_97.Id7", "f_castle_97", Rectangle(-1418.0854, 1087.0491, 100));
		AddSpawnPoint("f_castle_97.Id7", "f_castle_97", Rectangle(-1995.2167, 1051.2507, 100));
		AddSpawnPoint("f_castle_97.Id7", "f_castle_97", Rectangle(1219.5785, 922.5473, 100));
		AddSpawnPoint("f_castle_97.Id7", "f_castle_97", Rectangle(1691.5867, 908.69006, 100));
		AddSpawnPoint("f_castle_97.Id7", "f_castle_97", Rectangle(2044.2268, 940.8645, 100));
		AddSpawnPoint("f_castle_97.Id7", "f_castle_97", Rectangle(1721.2488, 201.0293, 100));
		AddSpawnPoint("f_castle_97.Id7", "f_castle_97", Rectangle(1983.8038, -16.156689, 100));
		AddSpawnPoint("f_castle_97.Id7", "f_castle_97", Rectangle(964.2106, 100.42186, 100));
		AddSpawnPoint("f_castle_97.Id7", "f_castle_97", Rectangle(-147.83191, 676.0783, 100));
		AddSpawnPoint("f_castle_97.Id7", "f_castle_97", Rectangle(-114.07954, 73.8513, 100));
		AddSpawnPoint("f_castle_97.Id7", "f_castle_97", Rectangle(-145.44452, -830.504, 100));
		AddSpawnPoint("f_castle_97.Id7", "f_castle_97", Rectangle(1117.0952, -838.0117, 100));
		AddSpawnPoint("f_castle_97.Id7", "f_castle_97", Rectangle(1504.5735, -865.4163, 100));
		AddSpawnPoint("f_castle_97.Id7", "f_castle_97", Rectangle(-2138.0576, -636.425, 100));
		AddSpawnPoint("f_castle_97.Id7", "f_castle_97", Rectangle(-2199.3508, -350.0141, 100));

		// 'Rootcrystal_02' GenType 22 Spawn Points
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-98.12755, 1303.4967, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-29.607904, 826.50635, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-248.0641, 564.03784, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-6.115388, 307.30634, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-269.66467, 104.98952, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(8.352013, -126.73085, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-90.19784, -446.36014, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-287.5396, -791.78674, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(24.155365, -895.89484, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(429.53152, -829.49396, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(817.77325, -837.55634, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(1195.8582, -762.428, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(1449.8285, -948.72076, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-582.8119, 81.94779, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-951.9861, 87.40872, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-1242.0663, 100.11732, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-1344.8577, 566.7179, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-1651.4232, 195.7323, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-1947.3649, 1007.049, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-2297.0757, 222.4099, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-2039.2305, 239.19917, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-2147.9043, -107.03087, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-2086.1965, -707.5186, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-2178.726, -419.40427, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-1252.0248, 958.40265, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-1128.4146, 1270.8334, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-1490.4608, 1273.3666, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-1577.7493, 1001.0618, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(-1969.1956, 1271.1627, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(390.56656, 81.25586, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(1091.675, 17.700882, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(1463.5482, 73.09193, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(1760.1788, 222.58817, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(2009.8292, -66.64629, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(1823.9761, 529.14636, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(1314.6418, 861.635, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(1933.964, 853.9103, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(1156.6827, 1114.1969, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(1654.7532, 1017.3254, 200));
		AddSpawnPoint("f_castle_97.Id8", "f_castle_97", Rectangle(819.1239, 116.40909, 200));
	}
}
