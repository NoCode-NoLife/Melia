//--- Melia Script -----------------------------------------------------------
// f_farm_49_3
//
//--- Description -----------------------------------------------------------
// Sets up the f_farm_49_3 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FFarm493MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner(MonsterId.Melatanun, 50, TimeSpan.FromMilliseconds(20000), "Spawner1.f_farm_49_3");
		AddSpawner(MonsterId.Tree_Root_Mole_Pink, 15, TimeSpan.FromMilliseconds(30000), "Spawner2.f_farm_49_3");
		AddSpawner(MonsterId.Melatanun, 25, TimeSpan.FromMilliseconds(30000), "Spawner3.f_farm_49_3");
		AddSpawner(MonsterId.Carcashu_Green, 50, TimeSpan.FromMilliseconds(20000), "Spawner4.f_farm_49_3");
		AddSpawner(MonsterId.Tree_Root_Mole_Pink, 15, TimeSpan.FromMilliseconds(35000), "Spawner5.f_farm_49_3");
		AddSpawner(MonsterId.Rootcrystal_01, 10, TimeSpan.FromMilliseconds(5000), "Spawner6.f_farm_49_3");

		// Monster Spawn Points -----------------------------

		// Melatanun Spawn Points
		AddSpawnPoint("f_farm_49_3", Spot(868.5493, -744.3278, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(800.66345, -540.50684, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-62.638935, -635.06445, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(36.49669, -520.6962, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(187.49017, -637.11975, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-53.00553, -218.9955, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(42.312317, -11.97554, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-176.6194, -124.14294, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(1509.4955, -99.28087, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(1599.8749, 40.26117, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(1429.9888, 51.251945, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(84.112366, -644.73816, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(116.61652, -188.18794, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-61.14225, -84.484604, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(18.889957, -778.8098, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(1509.9587, -244.33603, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(1501.7706, 172.94807, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(1646.3354, -161.49164, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(783.3768, -130.06747, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(812.96954, -229.58781, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(1083.7805, -55.23967, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(695.12494, -205.81284, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(613.0544, -182.94373, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(612.021, -245.86305, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(612.675, -68.23521, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(718.1216, 12.895114, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(770.9828, 93.944984, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(856.9391, 144.45633, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(986.1197, 2.0368133, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(986.78644, -138.90593, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(798.4517, -37.23223, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(891.44336, -145.00659, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(1093.6218, -741.5536, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(970.7865, -772.84705, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(832.0755, -899.5571, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(789.1109, -834.82245, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(826.5706, -649.65936, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(1027.5884, -608.7699, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(966.2467, -574.1127, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(995.56146, -510.92615, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(1040.9353, -509.92343, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(997.31976, -457.85345, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(898.4051, -434.93604, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(732.61444, -444.50726, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(718.2734, -637.799, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(824.7396, -445.19598, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(922.1135, -675.4964, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-127.00588, -533.9758, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(136.15916, -54.549812, 25), "Spawner1.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-93.3528, 36.48818, 25), "Spawner1.f_farm_49_3");

		// Tree_Root_Mole_Pink Spawn Points
		AddSpawnPoint("f_farm_49_3", Spot(-1430.3269, 1029.314, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1474.8667, 1225.5886, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1328.4296, 1400.6984, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1257.975, 1187.0062, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-469.93307, 1706.4221, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-371.29047, 1947.53, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(68.63141, 1785.7169, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-189.63248, 1699.2937, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-185.41335, 1870.79, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1155.7706, -1058.4893, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1432.7114, -1292.873, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1322.7822, -1451.4612, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1770.279, -201.87846, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1629.7418, 42.119347, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1452.9235, -235.86792, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1365.7358, 2.879776, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1167.9628, -869.5546, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1563.0973, -102.56399, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1863.3942, -57.44673, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1583.0249, 1414.2844, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(71.01681, 1950.9747, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(92.00206, 1851.1895, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(119.31152, 1906.9404, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(142.4773, 1812.9579, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(139.95285, 1757.3444, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(87.49413, 1701.8876, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(46.893158, 1655.075, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-18.56672, 1666.7443, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-80.69653, 1685.0829, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-47.48211, 1720.1978, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(15.928913, 1707.3849, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(60.188972, 1734.605, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(12.072477, 1835.628, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-9.876255, 1764.8353, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-60.664974, 1845.0753, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(25.082645, 1918.4032, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-39.22394, 1916.8599, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-10.595022, 2000.1793, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-29.827667, 2086.247, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-100.46519, 2073.9087, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-91.811485, 2013.6272, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-116.79268, 1957.9165, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-149.0794, 1895.1761, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-114.29561, 1775.5426, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-209.21916, 1728.9542, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-174.6856, 1778.8461, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-130.54944, 1844.9928, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-166.60933, 2066.4204, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-161.81352, 2004.0128, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-251.38623, 1997.1243, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-285.4287, 1945.0969, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-285.06592, 1875.5282, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-317.8921, 1798.2539, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-287.6007, 1698.1604, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-229.00133, 1637.3795, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-173.6938, 1638.1752, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-235.44147, 1553.3094, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-318.66336, 1596.6387, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-369.74692, 1692.4794, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-417.0445, 1628.2343, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-419.72778, 1769.8802, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-362.38943, 1866.8116, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-458.97574, 1854.7526, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-431.70267, 1914.0643, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-532.93024, 1879.7666, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-549.54144, 1824.3241, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-518.0359, 1796.1017, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-575.75433, 1709.9233, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-506.80338, 1738.3992, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-540.61444, 1682.3798, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-422.62073, 1709.352, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1359.6367, 1526.3546, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1343.3138, 1472.8641, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1411.1445, 1575.6016, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1470.8448, 1559.7197, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1524.9551, 1520.7607, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1548.8766, 1458.141, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1566.363, 1346.1835, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1637.1046, 1330.7043, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1622.4481, 1380.4806, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1515.9968, 1212.1815, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1479.7987, 1336.817, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1387.7655, 1355.9128, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1286.484, 1281.9025, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1346.9696, 1179.832, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1223.7994, 1123.6814, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1147.8573, 1154.0765, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1273.6464, 1049.7682, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1349.1559, 964.93744, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1414.216, 919.5393, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1484.7112, 920.90186, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1510.815, 1021.0734, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1512.6151, 1177.7402, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1378.3014, 1150.6815, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1328.5483, 1088.726, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1349.3735, 1032.2103, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1291.979, 1158.544, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1420.8403, 1102.0819, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1516.9287, 1091.046, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1467.1597, 1147.8499, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1586.0161, 1166.48, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1554.3407, 1283.795, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1490.0988, 1295.0016, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1429.0269, 1312.5364, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1375.2751, 1304.6965, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1295.092, 1357.961, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1238.7726, 1327.6477, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1248.2443, 1261.2302, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1172.9688, 1264.2096, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1335.1494, 1326.1895, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1452.796, 1407.7872, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1531.5547, 1401.286, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1578.959, 1246.8635, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1552.3745, 1147.4042, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1478.7134, 1080.5935, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1218.0696, 1073.707, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1407.7988, 42.53912, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1446.7748, 113.90021, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1536.2881, 116.32658, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1539.9349, 31.982193, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1465.3981, 14.388815, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1326.2058, -46.337082, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1234.6184, -80.037254, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1276.8573, -117.36765, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1320.4233, -211.10881, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1381.1667, -298.67734, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1420.8389, -360.85434, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1487.1324, -363.10498, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1494.609, -290.73593, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1500.2008, -184.74258, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1418.3735, -137.57526, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1402.2445, -201.1207, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1351.5264, -104.78333, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1436.1028, -47.579758, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1528.1963, -36.155514, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1505.3883, -111.33539, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1596.3258, -174.12311, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1677.7423, -121.43221, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1759.1265, -111.83462, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1842.4335, -234.23854, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1895.6567, -321.6614, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1942.1046, -242.51295, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1940.5349, -116.14709, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1903.1375, -156.08531, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1837.1494, -146.42947, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1790.3481, -45.5521, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1825.7173, 9.227371, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1721.0723, 19.619053, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1630.8547, -0.28038216, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1688.9608, -46.941177, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1610.7001, -37.656723, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1076.6815, -904.15735, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1217.3174, -822.7773, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1232.4362, -886.25104, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1159.3448, -926.40295, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1079.4673, -974.1906, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1084.221, -799.6141, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-981.00525, -834.30145, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-970.92615, -900.4666, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-976.30505, -943.00146, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-961.22003, -1022.9429, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1015.4661, -1099.5991, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1072.4519, -1137.9591, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1101.9152, -1211.3425, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1105.5452, -1292.0135, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1156.1392, -1399.7506, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1241.801, -1497.3672, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1386.0778, -1488.4984, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1499.9015, -1420.3344, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1564.9349, -1329.5878, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1595.2833, -1206.5507, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1487.1892, -1145.4408, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1394.7336, -1135.7377, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1318.2336, -1214.8243, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1263.4779, -1288.2634, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1248.7847, -1371.8804, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1211.0496, -1323.191, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1203.4451, -1214.9841, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1293.5435, -1150.3987, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1269.5142, -1058.0874, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1218.5725, -947.86926, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1289.4792, -923.63727, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1177.32, -990.95233, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1222.2091, -1035.2455, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1068.426, -1048.2399, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1018.9867, -948.14716, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1134.9097, -1139.6952, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1339.0043, -1337.4204, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1430.2588, -1396.1367, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1533.8489, -1281.3263, 30), "Spawner2.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1445.5133, -1203.7074, 30), "Spawner2.f_farm_49_3");

		// Melatanun Spawn Points
		AddSpawnPoint("f_farm_49_3", Spot(705.61584, -83.579926, 9999), "Spawner3.f_farm_49_3");

		// Carcashu_Green Spawn Points
		AddSpawnPoint("f_farm_49_3", Spot(307.18872, -443.0504, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-183.02461, -233.98622, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-81.06759, 27.235092, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(1438.3138, 60.933037, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(1627.6907, 231.78685, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(1572.3595, 122.73882, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(1665.9839, 117.0952, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(1641.0366, 37.74089, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(1652.6, -77.33302, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(1676.5245, -196.146, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(1561.2499, -213.37375, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(1460.0385, -143.9271, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(1565.605, -118.33787, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(1497.1123, 162.52028, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(1421.1626, 176.05899, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(1351.0883, 60.288734, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(1338.9094, -42.585827, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(1392.7096, -129.53261, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(1413.5088, -18.659227, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(1479.9725, -70.24813, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(1538.1996, 30.65694, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(252.63695, -746.601, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(172.3895, -798.68604, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(84.37046, -844.1334, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(174.22197, -708.3961, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(224.21635, -621.66547, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(350.69852, -509.7641, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(197.413, -485.10565, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(78.28235, -614.58716, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(116.48598, -493.70947, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-19.452509, -465.5467, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-27.892513, -786.3679, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-25.039799, -646.89935, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-141.20601, -733.2186, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-82.981445, -590.87384, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-62.210796, -518.19574, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-151.25092, -517.5444, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-195.30888, -596.6166, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(36.416035, -114.26156, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(78.94322, -5.9762955, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(140.55551, -146.43877, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(120.04182, -244.68048, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(38.046227, -292.7051, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-109.65241, -301.4759, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-173.91911, -231.06952, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-85.617195, -223.05411, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-74.20501, -130.65862, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(27.270731, 44.41002, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-11.106396, -42.417137, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-15.732037, 62.263702, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-172.88931, -84.207016, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-148.3942, 21.639837, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-187.61922, -15.363792, 25), "Spawner4.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-240.62772, -125.60087, 25), "Spawner4.f_farm_49_3");

		// Tree_Root_Mole_Pink Spawn Points
		AddSpawnPoint("f_farm_49_3", Spot(-1210.3956, -1135.5359, 9999), "Spawner5.f_farm_49_3");

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint("f_farm_49_3", Spot(879.04285, -626.6889, 50), "Spawner6.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(38.94488, -652.96906, 50), "Spawner6.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-11.888283, -242.6333, 50), "Spawner6.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(1480.822, -52.05752, 50), "Spawner6.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1107.5421, -1103.0582, 50), "Spawner6.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1373.7367, -1370.3438, 50), "Spawner6.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1817.3854, -845.6986, 50), "Spawner6.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1843.5507, -126.7513, 50), "Spawner6.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1403.2922, -189.20029, 50), "Spawner6.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-1426.276, 1148.1459, 50), "Spawner6.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-852.87964, 804.2398, 50), "Spawner6.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-346.91766, 1871.8212, 50), "Spawner6.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(-13.240391, 1837.104, 50), "Spawner6.f_farm_49_3");
		AddSpawnPoint("f_farm_49_3", Spot(968.3168, 1254.5433, 50), "Spawner6.f_farm_49_3");

	}
}