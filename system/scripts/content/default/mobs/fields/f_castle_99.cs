//--- Melia Script -----------------------------------------------------------
// f_castle_99
//
//--- Description -----------------------------------------------------------
// Sets up the f_castle_99 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FCastle99MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_castle_99", MonsterId.Nuo_Twinsword, Properties("MHP", 783671, "MINPATK", 10578, "MAXPATK", 12903, "MINMATK", 10578, "MAXMATK", 12903, "DEF", 255522, "MDEF", 255522));
		AddPropertyOverrides("f_castle_99", MonsterId.Living_Armor, Properties("MHP", 785691, "MINPATK", 10604, "MAXPATK", 12935, "MINMATK", 10604, "MAXMATK", 12935, "DEF", 257224, "MDEF", 257224));
		AddPropertyOverrides("f_castle_99", MonsterId.Nuka_Shield, Properties("MHP", 787748, "MINPATK", 10631, "MAXPATK", 12968, "MINMATK", 10631, "MAXMATK", 12968, "DEF", 258956, "MDEF", 258956));
		AddPropertyOverrides("f_castle_99", MonsterId.Aklaspetal_Sword, Properties("MHP", 789840, "MINPATK", 10657, "MAXPATK", 13001, "MINMATK", 10657, "MAXMATK", 13001, "DEF", 260718, "MDEF", 260718));
		AddPropertyOverrides("f_castle_99", MonsterId.Castle_Troll, Properties("MHP", 791967, "MINPATK", 10685, "MAXPATK", 13034, "MINMATK", 10685, "MAXMATK", 13034, "DEF", 262509, "MDEF", 262509));

		// Monster Spawners --------------------------------

		AddSpawner("f_castle_99.Id1", MonsterId.Nuo_Twinsword, 50, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_castle_99.Id2", MonsterId.Living_Armor, 40, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_castle_99.Id3", MonsterId.Nuka_Shield, 55, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_castle_99.Id4", MonsterId.Aklaspetal_Sword, 45, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_castle_99.Id5", MonsterId.Castle_Troll, 15, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_castle_99.Id6", MonsterId.Rootcrystal_02, 45, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Nuo_Twinsword Spawn Points
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-1856.3452, -318.7012, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-1559.6996, -64.86715, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-1871.9122, 45.185314, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-1608.1058, 64.91803, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-1633.6387, -317.84088, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-1761.2161, -431.00616, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-1940.3406, -535.7362, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-1906.3284, -153.28589, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-1412.2792, 233.17155, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-689.44666, -819.77527, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-687.0809, -1099.9669, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-698.7549, -964.1749, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-465.53342, -1101.1257, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-482.98987, -935.1828, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-498.88495, -816.63965, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-567.0557, -928.07104, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-553.37164, -616.6672, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-523.56744, -365.6095, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-588.55035, -395.57202, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-532.3561, -461.59753, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-602.3973, 535.2753, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-547.80396, 677.0021, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-593.17126, 768.4852, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-436.59305, 1033.1622, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-622.12256, 1206.1959, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-663.1838, 1033.3878, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-566.0208, 1067.162, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-885.16376, 1084.6555, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-1223.2319, 1097.1257, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-1571.0178, 1293.0072, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-1573.8425, 1011.1113, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-1594.4005, 754.5251, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-1972.5259, 951.6544, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-1701.4342, 1198.6912, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-1678.6498, 1026.1351, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-1881.1819, 1127.9026, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-1750.503, 742.518, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-1929.8353, -1150.5901, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-1508.2352, -1240.143, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-1799.6499, -1236.9696, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-1888.1266, -605.4374, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-1587.8108, -536.87537, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-1545.5226, -899.8991, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-1884.1228, -747.577, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-1478.9753, -1007.0121, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-1671.697, -1031.8928, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-1506.8025, -742.1798, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-1658.4192, 330.56015, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-1881.5654, 577.1821, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-1621.2922, 577.3419, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-983.3459, 1105.9642, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-433.5936, 1189.4784, 35));
		AddSpawnPoint( "f_castle_99.Id1", "f_castle_99", Spot(-1853.2665, 265.2571, 35));

		// Living_Armor Spawn Points
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(-1463.7281, 46.357857, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(-1553.0319, -198.47743, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(-582.50104, -51.053543, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(-777.57306, 45.32333, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(-561.6945, 196.86488, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(-453.57126, -2.1000402, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(-329.4554, 99.91885, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(-227.70915, 166.31664, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(-64.353714, 187.52005, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(-86.13747, 59.213737, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(74.91917, 178.32518, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(209.11699, 60.260345, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(227.90515, 240.62009, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(-1105.4857, 1054.7164, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(-932.10004, 1125.6168, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(-662.0556, 1060.5317, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(-529.0077, 1202.7606, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(-435.07602, 1042.6304, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(-510.5098, 913.21985, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(-551.36865, 751.0267, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(-612.30133, 662.7575, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(-543.3055, -507.46964, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(-540.0683, -1101.2701, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(-559.0029, -867.6656, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(-407.86667, -876.2303, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(-600.3082, -1022.6511, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(-1429.2336, -915.2738, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(-1545.5162, -1095.9071, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(-1717.524, -1130.7339, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(-1899.5619, -1033.5653, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(-1869.8933, -874.65045, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(-1698.4314, -642.0808, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(-1656.3378, -923.23914, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(-1726.9958, 849.59607, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(-1741.0613, 1185.0615, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(-1580.4475, 1288.0317, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(-1409.2986, 1056.8739, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(-1498.1735, 920.7066, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(-1639.2308, 981.9854, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(-1915.3898, 885.0471, 25));
		AddSpawnPoint( "f_castle_99.Id2", "f_castle_99", Spot(-1642.1239, 565.17957, 25));

		// Nuka_Shield Spawn Points
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(642.3705, -69.803955, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(587.7623, 374.32623, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(1053.807, 137.97261, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(524.2817, 126.09061, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(627.3103, -643.0443, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(455.6799, -1032.7611, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(795.35767, -1098.9266, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(695.57104, -800.6601, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(1199.7043, -936.6265, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(1633.5872, -893.78156, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(1811.5782, -805.2332, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(1769.1803, -1101.1554, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(1995.41, -1102.3441, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(1836.7991, -974.01, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(1422.8344, -963.292, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(743.325, -1010.1088, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(913.35376, -5.963521, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(369.6297, 1121.3273, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(641.29065, 1339.3154, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(580.8273, 1167.6013, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(724.1794, 1071.9761, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(989.6596, 1241.0669, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(1391.8147, 155.97531, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(1702.6249, 37.368973, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(1819.2448, -184.13516, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(2040.6727, -33.423813, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(1837.5625, 206.23528, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(1887.372, 399.18167, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(1860.8174, 667.6039, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(1821.0574, 955.6397, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(1725.74, 1261.9923, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(1876.6112, 1286.469, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(1783.1609, 1076.9875, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(2023.5479, 868.19, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(2204.6118, 1228.6232, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(2059.8901, 1098.3911, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(2201.5237, 1038.1956, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(2089.6758, 1167.6288, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(1904.303, -7.4043837, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(949.45667, 157.8426, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(619.65094, 231.9822, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(277.0934, 224.23026, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(604.9365, -236.04956, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(620.7846, -405.65973, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(518.98096, -865.96185, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(883.7362, -946.73755, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(1768.4767, -979.7708, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(1893.7035, -868.6265, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(730.9024, 1191.2592, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(637.3724, 839.43634, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(581.4547, 539.52234, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(458.40344, 325.62567, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(24.197268, 144.33658, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(-354.225, 44.849888, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(-547.6182, 218.53781, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(-182.10915, 138.59453, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(49.346104, 260.6982, 30));
		AddSpawnPoint( "f_castle_99.Id3", "f_castle_99", Spot(369.08008, 50.049995, 30));

		// Aklaspetal_Sword Spawn Points
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(1702.3855, 990.6158, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(2114.5076, 997.1112, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(1885.9299, 839.8279, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(1953.3922, 1026.3093, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(1830.6067, 1166.0243, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(1962.1046, 1199.4149, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(2179.222, 894.1394, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(1890.6564, 614.9335, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(1852.3998, 252.77603, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(1758.8181, 91.43795, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(1786.7946, -79.33342, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(1867.8696, -34.15219, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(1934.1227, 88.15352, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(1264.5188, 125.28268, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(1108.5839, -17.523666, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(949.2612, 76.3226, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(1044.2109, 274.60303, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(728.4231, 261.16562, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(499.78082, 213.92406, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(381.96408, 101.49612, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(615.7905, -167.36636, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(886.79614, -87.78967, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(776.4818, -29.105307, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(842.8256, 193.07523, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(670.39606, 103.65969, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(686.2244, -283.95398, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(618.3781, -490.91318, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(606.31085, -908.308, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(780.92224, -754.86536, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(759.8652, -916.0634, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(935.5776, -942.31244, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(1044.074, -951.0407, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(908.1999, -1069.6078, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(1368.2628, -994.24316, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(1471.7556, -926.88715, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(1694.0857, -992.864, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(1794.5934, -866.01105, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(1925.1769, -857.8008, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(1868.623, -1100.8286, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(2016.5074, -1000.0485, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(1906.0557, -939.53815, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(1900.3407, -1014.9888, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(204.4953, 148.29585, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(558.89453, 569.27637, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(610.2386, 643.8483, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(602.8501, 799.9086, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(651.49414, 909.88385, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(540.14856, 1078.0397, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(495.00146, 1221.3784, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(811.5447, 1114.9437, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(854.1386, 1242.8262, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(911.96515, 1111.7224, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(358.01505, 221.1716, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(11.912308, 265.3174, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(-17.570324, 119.85757, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(-209.90176, 41.99981, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(-291.18332, -70.01939, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(-421.69595, 187.66322, 25));
		AddSpawnPoint( "f_castle_99.Id4", "f_castle_99", Spot(-522.09143, 116.88649, 25));

		// Castle_Troll Spawn Points
		AddSpawnPoint( "f_castle_99.Id5", "f_castle_99", Spot(-665.4137, 122.12141, 100));
		AddSpawnPoint( "f_castle_99.Id5", "f_castle_99", Spot(-605.99805, -880.6671, 100));
		AddSpawnPoint( "f_castle_99.Id5", "f_castle_99", Spot(66.13067, 139.01717, 100));
		AddSpawnPoint( "f_castle_99.Id5", "f_castle_99", Spot(701.6222, 1224.5653, 100));
		AddSpawnPoint( "f_castle_99.Id5", "f_castle_99", Spot(605.60364, 137.10281, 100));
		AddSpawnPoint( "f_castle_99.Id5", "f_castle_99", Spot(1088.9296, 31.742392, 100));
		AddSpawnPoint( "f_castle_99.Id5", "f_castle_99", Spot(681.5621, -849.6744, 100));
		AddSpawnPoint( "f_castle_99.Id5", "f_castle_99", Spot(1808.7295, 144.1483, 100));
		AddSpawnPoint( "f_castle_99.Id5", "f_castle_99", Spot(1823.9678, -953.0451, 100));
		AddSpawnPoint( "f_castle_99.Id5", "f_castle_99", Spot(1922.3119, 1079.8713, 100));
		AddSpawnPoint( "f_castle_99.Id5", "f_castle_99", Spot(-1725.7252, -873.8338, 100));
		AddSpawnPoint( "f_castle_99.Id5", "f_castle_99", Spot(-1747.1271, -204.00592, 100));
		AddSpawnPoint( "f_castle_99.Id5", "f_castle_99", Spot(-1601.3052, 952.54614, 100));
		AddSpawnPoint( "f_castle_99.Id5", "f_castle_99", Spot(-589.46826, 1090.344, 100));
		AddSpawnPoint( "f_castle_99.Id5", "f_castle_99", Spot(-1090.5703, -943.88135, 100));

		// Rootcrystal_02 Spawn Points
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(1844.2891, -923.16125, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(1515.8413, -949.18256, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(1184.4595, -942.8843, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(946.16113, -1055.1216, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(786.15216, -880.8424, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(560.35675, -826.6992, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(626.53064, -510.17172, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(672.68085, -148.66254, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(974.6087, 57.96029, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(730.1268, 214.6961, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(444.8403, 87.53957, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(239.06311, 221.41824, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(-5.966568, 112.16762, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(-319.07214, 19.45827, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(-662.0144, -35.299347, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(-557.74756, -435.0159, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(-693.86383, -838.7452, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(-493.47104, -1042.1604, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(-1078.8478, -945.3718, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(-1511.3838, -1162.9197, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(-1477.5582, -806.7644, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(-1888.5895, -1109.2817, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(-1856.2802, -779.68146, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(-1862.4385, -296.444, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(-1547.4708, -309.04984, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(-1831.2703, 73.116806, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(-1487.5977, 70.10751, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(-1822.3431, 487.3597, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(-1522.3035, 386.98596, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(-1916.5615, 866.5697, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(-1587.5548, 791.36554, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(-1787.8848, 1209.976, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(-1534.5309, 1131.7543, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(-1240.1256, 1080.5663, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(-902.01154, 1115.7562, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(-649.95447, 1183.7705, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(-432.00296, 1015.0014, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(-555.0323, 704.9823, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(-541.336, 338.72168, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(571.36774, 545.6824, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(645.4524, 877.0762, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(416.39774, 1189.6987, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(782.8123, 1168.9668, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(1181.4984, 112.53447, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(1542.9468, 147.15623, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(1897.0852, -4.894329, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(1862.3275, 377.09018, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(1898.9128, 725.62976, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(1753.1146, 1048.9482, 200));
		AddSpawnPoint( "f_castle_99.Id6", "f_castle_99", Spot(2082.869, 1161.5492, 200));

	}
}
