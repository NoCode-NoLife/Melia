//--- Melia Script -----------------------------------------------------------
// f_pilgrimroad_52
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Apsimesti Crossroads' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FPilgrimroad52MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_pilgrimroad_52", MonsterId.Hook_Old, Properties("MHP", 138581, "MINPATK", 2283, "MAXPATK", 2708, "MINMATK", 2283, "MAXMATK", 2708, "DEF", 2775, "MDEF", 2775));
		AddPropertyOverrides("f_pilgrimroad_52", MonsterId.TreeAmbulo_Red, Properties("MHP", 140057, "MINPATK", 2302, "MAXPATK", 2731, "MINMATK", 2302, "MAXMATK", 2731, "DEF", 2860, "MDEF", 2860));
		AddPropertyOverrides("f_pilgrimroad_52", MonsterId.Lichenclops_Mage, Properties("MHP", 141583, "MINPATK", 2322, "MAXPATK", 2755, "MINMATK", 2322, "MAXMATK", 2755, "DEF", 2948, "MDEF", 2948));

		// Monster Spawners ---------------------------------

		AddSpawner("f_pilgrimroad_52.Id1", MonsterId.Hook_Old, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_52.Id2", MonsterId.TreeAmbulo_Red, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_52.Id3", MonsterId.Rootcrystal_01, 8, 10, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_52.Id4", MonsterId.TreeAmbulo_Red, 60, 80, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_52.Id5", MonsterId.Hook_Old, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_52.Id6", MonsterId.Lichenclops_Mage, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Hook_Old' GenType 6 Spawn Points
		AddSpawnPoint("f_pilgrimroad_52.Id1", "f_pilgrimroad_52", Rectangle(-10.035753, 373.63446, 9999));

		// 'TreeAmbulo_Red' GenType 7 Spawn Points
		AddSpawnPoint("f_pilgrimroad_52.Id2", "f_pilgrimroad_52", Rectangle(-193.14432, 166.65239, 9999));

		// 'Rootcrystal_01' GenType 19 Spawn Points
		AddSpawnPoint("f_pilgrimroad_52.Id3", "f_pilgrimroad_52", Rectangle(-606.50726, -2750.5972, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id3", "f_pilgrimroad_52", Rectangle(-1110.2416, -1748.8292, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id3", "f_pilgrimroad_52", Rectangle(48.517456, -937.11664, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id3", "f_pilgrimroad_52", Rectangle(367.91678, 470.17404, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id3", "f_pilgrimroad_52", Rectangle(-361.27777, 454.1906, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id3", "f_pilgrimroad_52", Rectangle(-1468.925, 169.05789, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id3", "f_pilgrimroad_52", Rectangle(-355.64966, 1215.0492, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id3", "f_pilgrimroad_52", Rectangle(973.97363, 1263.8043, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id3", "f_pilgrimroad_52", Rectangle(1423.6609, 2103.0225, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id3", "f_pilgrimroad_52", Rectangle(722.1556, -183.86896, 30));

		// 'TreeAmbulo_Red' GenType 38 Spawn Points
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-803.5752, -2121.579, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-786.4732, -2325.7256, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-187.63193, 1237.4369, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-360.0088, 1042.2727, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-442.87402, 1271.6074, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-715.8862, 1381.8943, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-643.0099, 1418.9633, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-179.96667, 1426.5568, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-253.51959, 1570.7662, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-493.15735, 1551.8905, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-621.27435, 1173.89, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-292.55664, 820.50165, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(911.5561, 2070.7947, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(987.02997, 2324.6758, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(1272.8236, 2522.429, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(1622.95, 2019.7886, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(1326.0377, 2158.1233, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(1100.1497, 2021.9526, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(862.0343, 2268.7573, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(1404.831, 1944.2703, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1180.4388, -1617.0913, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1262.8351, -1607.2079, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1245.7505, -1533.1797, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1054.7938, -1540.4658, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1320.6099, -1782.6906, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1232.3004, -1890.0826, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1073.1456, -1957.6478, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-876.91785, -2001.874, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-715.12573, -1924.6444, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1001.843, -1828.9518, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1104.8837, -1722.8965, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-931.5322, -1620.3527, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-836.1931, -1769.2236, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-642.8781, -1774.1179, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-592.6437, -1446.615, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-664.6371, -1642.884, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-628.6759, -1537.4645, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-761.8255, -1812.8885, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-896.7378, -1890.3663, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1417.7592, -1612.219, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(1304.9512, 1774.4081, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(1116.934, 1759.4412, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(810.57104, 1943.034, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(734.0143, 2100.0337, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(854.3732, 2419.8699, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(1403.621, 2318.3792, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(1554.6182, 2424.7756, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(1700.1779, 2241.0974, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(1281.0817, 2029.992, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(1259.6681, 1901.8213, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1254.1724, -388.47504, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1441.5088, -347.45682, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1596.4326, -243.32062, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1650.0546, -88.03465, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1623.8152, 65.08467, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1530.622, 218.32857, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1358.6204, 261.07153, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1071.282, 221.54366, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-967.323, 90.34912, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-978.10645, -51.667866, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-998.58405, -275.10373, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1207.5806, -157.1149, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1356.9634, -166.36539, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1432.2875, 6.05199, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1320.3947, 135.00095, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1127.766, 115.43472, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-964.2339, -15.001556, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1089.5052, -226.71684, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1236.4451, 69.366554, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-1406.2203, -125.00205, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(186.7812, 611.76746, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(188.14458, 403.09058, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(416.8909, 287.4617, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(664.11896, 441.4756, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(532.1515, 612.5845, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(446.95276, 464.55762, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(423.09235, 587.51013, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(233.72397, 458.59326, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(266.93723, 222.77306, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(122.34587, 92.85448, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-22.953901, 147.60522, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-194.28029, 263.19583, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-263.23022, 189.16597, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-98.6616, 92.02035, 25));
		AddSpawnPoint("f_pilgrimroad_52.Id4", "f_pilgrimroad_52", Rectangle(-80.52794, -27.689222, 25));

		// 'Hook_Old' GenType 48 Spawn Points
		AddSpawnPoint("f_pilgrimroad_52.Id5", "f_pilgrimroad_52", Rectangle(493.0897, 564.00867, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id5", "f_pilgrimroad_52", Rectangle(-954.68805, -1774.1771, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id5", "f_pilgrimroad_52", Rectangle(-1371.1903, -1584.2021, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id5", "f_pilgrimroad_52", Rectangle(1251.0522, 2145.57, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id5", "f_pilgrimroad_52", Rectangle(1260.579, 1964.9429, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id5", "f_pilgrimroad_52", Rectangle(211.44754, 231.82227, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id5", "f_pilgrimroad_52", Rectangle(204.44911, 610.10516, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id5", "f_pilgrimroad_52", Rectangle(-1080.7545, -99.568756, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id5", "f_pilgrimroad_52", Rectangle(-1615.4857, -28.328192, 30));

		// 'Lichenclops_Mage' GenType 49 Spawn Points
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(966.6733, 1207.4315, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(1419.4817, 2170.1174, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(440.0471, 392.13458, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(897.6338, 2007.9287, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(1567.2501, 1899.9186, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(199.43396, 424.0587, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(797.45245, 2150.9258, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(1399.3594, 2466.3687, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(514.5416, 642.293, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(1290.0048, 1762.2777, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(1175.4807, 2394.8848, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(742.18256, 958.8576, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(74.246185, 136.50499, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(-40.5022, 340.9024, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(-254.83337, 41.728653, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(-273.79816, 756.6264, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(-457.74805, 1158.7572, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(211.77258, 237.2173, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(-1249.9677, -330.38382, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(-1554.3654, -82.77347, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(-1351.5647, 310.30862, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(-907.28845, -125.51344, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(-617.1827, 1268.0348, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(-588.6919, 1598.6636, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(-221.02817, 1586.5112, 30));
		AddSpawnPoint("f_pilgrimroad_52.Id6", "f_pilgrimroad_52", Rectangle(-360.044, 1249.1285, 30));
	}
}
