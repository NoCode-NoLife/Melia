//--- Melia Script -----------------------------------------------------------
// d_prison_82
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Investigation Room' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DPrison82MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_prison_82", MonsterId.Templeslave_Sword_Blue, Properties("MHP", 446280, "MINPATK", 6240, "MAXPATK", 7571, "MINMATK", 6240, "MAXMATK", 7571, "DEF", 59511, "MDEF", 59511));
		AddPropertyOverrides("d_prison_82", MonsterId.Wendigo_Bow_White, Properties("MHP", 449596, "MINPATK", 6282, "MAXPATK", 7623, "MINMATK", 6282, "MAXMATK", 7623, "DEF", 60568, "MDEF", 60568));
		AddPropertyOverrides("d_prison_82", MonsterId.Templeslave_Mage_Blue, Properties("MHP", 452975, "MINPATK", 6326, "MAXPATK", 7677, "MINMATK", 6326, "MAXMATK", 7677, "DEF", 61646, "MDEF", 61646));
		AddPropertyOverrides("d_prison_82", MonsterId.Boss_ChiefGuard, Properties("MHP", 3811090, "MINPATK", 10033, "MAXPATK", 12177, "MINMATK", 10033, "MAXMATK", 12177, "DEF", 197644, "MDEF", 197644));

		// Monster Spawners ---------------------------------

		AddSpawner("d_prison_82.Id1", MonsterId.Templeslave_Sword_Blue, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_prison_82.Id2", MonsterId.Wendigo_Bow_White, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_prison_82.Id3", MonsterId.Templeslave_Mage_Blue, 10, 13, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_prison_82.Id4", MonsterId.Rootcrystal_05, 12, 15, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_prison_82.Id5", MonsterId.Wendigo_Bow_White, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Templeslave_Sword_Blue' GenType 1 Spawn Points
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(2124.5642, 890.6991, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(2225.455, 788.1305, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(2282.8176, 943.9242, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(2135.848, 959.97516, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(2257.2336, 1083.9233, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(1954.9128, 1069.1282, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(2117.0984, 1283.4916, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(2268.3835, 1293.2352, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(1782.589, 1155.2184, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(1611.9922, 1172.149, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(1275.549, 1169.3494, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(1259.284, 927.4502, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(1256.4277, 717.54205, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(1272.3312, 594.3033, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(774.1947, 1310.2804, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(753.2022, 1013.0015, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(627.1696, 1097.1182, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(867.90424, 1142.7324, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(1046.4471, 1195.3873, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(543.733, 1292.1572, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(217.40253, 1440.5449, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-206.59834, 1398.4009, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-381.90436, 1117.2401, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-178.92224, 1229.8134, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-201.61473, 745.1913, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-968.7181, 1286.2456, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-1035.0293, 1794.0956, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-880.42145, 2155.5303, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-726.2454, 2114.3135, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-230.52318, 490.0914, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(12.924536, 385.61993, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-189.87573, 276.94052, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-307.2763, -142.91505, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-513.57416, -128.35437, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-87.053406, -192.56763, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-582.25665, -395.17447, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-604.9321, -800.0978, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-416.0825, -542.3392, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-109.74205, -342.63193, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-277.00278, -813.80286, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-578.7562, -1021.541, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-1431.65, -271.93643, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-1727.4587, -261.16162, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-1555.5005, -99.08423, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-1536.0264, -432.28284, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-1448.151, -532.71906, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-719.33765, -1464.9609, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-675.5118, -1791.0983, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-388.26758, -1580.4474, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-349.03482, -1353.1534, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-362.65247, -1887.7125, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(857.9567, 205.31601, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(1310.4094, 161.32063, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(1105.9081, 238.14336, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(1039.8933, -154.6717, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(757.36536, -666.88434, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(590.6059, -2114.3179, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(801.0036, -1367.695, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(838.74835, -1460.6936, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(832.12396, -1547.3301, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(918.053, -1579.5164, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(928.3322, -2136.0989, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(724.07385, -1563.3773, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(856.3473, -1761.7065, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(899.09845, -1849.8121, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(928.6271, -2012.4321, 25));

		// 'Wendigo_Bow_White' GenType 2 Spawn Points
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(922.4281, -1474.1017, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(900.8074, -1393.7142, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(771.8059, -1256.1055, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(774.7084, -862.115, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(938.4143, -109.51646, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(995.6391, 296.1692, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(834.4154, 173.89426, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(1200.7065, 117.09252, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(1321.0682, -171.8243, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(1240.2627, 389.22952, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(1272.5459, 987.0523, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(695.7037, 1167.8112, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(807.60333, 1374.8202, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(543.5307, 1364.2255, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(1392.469, 1183.1565, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(1786.646, 1155.1521, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(2129.495, 1182.071, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(2114.2734, 914.3052, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(1982.5048, 1012.175, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(866.16925, -1941.7285, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(937.5675, -1757.2391, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(840.762, -2087.425, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(687.642, -2116.6116, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(478.4075, -2116.3982, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(1098.5831, 62.839577, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-1392.4518, -20.481594, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-598.8248, -138.88284, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-579.68176, -48.36554, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-267.1125, -11.662416, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-229.26431, 616.58026, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-255.50992, 278.03668, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-396.7585, -556.7653, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-595.2321, -622.4914, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-470.0957, -415.26236, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-601.5488, -393.71573, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-88.27269, -502.06796, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-294.70984, -887.38293, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-561.829, -854.7334, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-305.41296, -1420.5435, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-614.0514, -1623.9327, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-801.1384, -1410.9504, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-430.5204, -1427.221, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-763.9787, -1781.2554, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-263.53244, -1891.3707, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-268.96075, -2078.8054, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(707.1077, -1394.3955, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(761.2871, -1482.1061, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-359.79507, -158.02177, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-248.72119, 450.73053, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-262.42474, 959.0953, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-192.04402, 1219.3484, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-501.1373, 1275.4442, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-862.6199, 2054.5945, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-658.1464, 2067.5654, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-278.42282, 1301.7906, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-52.48284, 1274.3424, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(372.5332, 1402.1024, 25));

		// 'Templeslave_Mage_Blue' GenType 3 Spawn Points
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-883.45844, 2148.6846, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-1002.1992, 1996.6794, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-330.54276, 1348.8176, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-270.7655, 1023.2367, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-196.4275, 632.74615, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-156.8723, 452.10117, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-126.59798, 258.2738, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-599.91113, -225.4528, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-1456.8755, -97.14791, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-1682.5873, -383.46564, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-1501.5499, -439.16382, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-698.4039, -107.09901, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-217.1648, -505.61444, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-505.5648, -593.76776, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-457.06918, -905.0829, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-188.3092, -810.6651, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-808.2578, -1568.6973, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-733.6769, -1896.9324, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-379.63727, -1704.5677, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-389.33447, -1424.7263, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-781.5454, -1312.3984, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-504.18393, -1474.6636, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-323.44482, -1940.624, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-453.01917, -245.58904, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-627.02106, -489.41962, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-316.19818, 282.16183, 25));

		// 'Rootcrystal_05' GenType 5 Spawn Points
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(742.40466, -2122.7341, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(919.45734, -1929.8949, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(905.0165, -1761.6914, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(471.05685, -2127.9866, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(912.7709, -1415.8596, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(743.8798, -1292.4359, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(794.0592, -1510.6608, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(708.8107, -1086.5013, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(813.59656, -191.7508, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(1029.0796, -39.329803, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(1051.6147, 145.50894, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(1281.2582, -162.61871, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(1351.6385, 287.9226, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(849.55835, 310.2953, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(1301.8756, 803.6086, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(1281.4276, 1176.9844, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(1702.7477, 1187.9113, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(2073.8408, 949.17255, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(875.98254, 1026.1047, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(876.2249, 1283.9819, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(649.25903, 1305.2153, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(691.5687, 1093.1133, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-95.90485, 1068.0144, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-261.2185, 1162.0986, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-390.8672, 1329.2411, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-64.148605, 1319.7014, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-863.301, 1255.8774, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-955.7964, 1862.2642, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-730.312, 1845.733, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-675.1956, 1992.5466, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-925.33234, 2075.9084, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-754.79614, 2160.0369, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-230.93616, 666.0298, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-520.76843, -186.55344, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-567.36945, -598.7641, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-410.0624, -826.18823, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-117.9623, -585.0156, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-120.79512, -839.693, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-241.14601, -1387.7191, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-442.28058, -1531.2266, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-294.48795, -1811.8251, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-782.4813, -1378.6444, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-1394.0665, -130.46043, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-1397.3383, -395.03967, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-1518.8885, -511.04703, 90));

		// 'Wendigo_Bow_White' GenType 11 Spawn Points
		AddSpawnPoint("d_prison_82.Id5", "d_prison_82", Rectangle(700.95197, 1182.6182, 9999));
	}
}
