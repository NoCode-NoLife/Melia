//--- Melia Script -----------------------------------------------------------
// d_prison_79
//
//--- Description -----------------------------------------------------------
// Sets up the d_prison_79 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DPrison79MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("d_prison_79", MonsterId.Nuo_Purple, Properties("MHP", 416997, "MINPATK", 5863, "MAXPATK", 7108, "MINMATK", 5863, "MAXMATK", 7108, "DEF", 50173, "MDEF", 50173));
		AddPropertyOverrides("d_prison_79", MonsterId.Socket_Bow_Red, Properties("MHP", 419582, "MINPATK", 5896, "MAXPATK", 7149, "MINMATK", 5896, "MAXMATK", 7149, "DEF", 50997, "MDEF", 50997));
		AddPropertyOverrides("d_prison_79", MonsterId.TerraNymph_Mage_Blue, Properties("MHP", 422248, "MINPATK", 5931, "MAXPATK", 7191, "MINMATK", 5931, "MAXMATK", 7191, "DEF", 51848, "MDEF", 51848));

		// Monster Spawners --------------------------------

		AddSpawner("d_prison_79.Id1", MonsterId.Nuo_Purple, 50, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_prison_79.Id2", MonsterId.Socket_Bow_Red, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_prison_79.Id3", MonsterId.TerraNymph_Mage_Blue, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_prison_79.Id4", MonsterId.Rootcrystal_05, 20, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_prison_79.Id5", MonsterId.Socket_Bow_Red, 45, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// Nuo_Purple Spawn Points
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(30.635063, 982.65393, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(159.28838, -1046.945, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(-181.73933, -246.10263, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(-123.33641, 59.530266, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(-431.70853, -1065.6669, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(-215.94408, -166.69438, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(-207.59369, 164.12492, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(73.09249, -639.99396, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(-92.03273, -230.55862, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(-567.33685, -1067.2422, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(-944.75885, -1040.6733, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(437.3772, -1026.3193, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(841.5481, -1054.9259, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(1063.0182, -885.5761, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(805.8358, -931.40344, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(975.9825, -1450.3398, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(1021.5406, -1996.6372, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(1434.602, -1936.1782, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(1791.2692, -2071.8699, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(1863.6665, -1715.2095, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(2063.0327, -1893.213, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(2325.0957, -1801.748, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(2252.348, -1688.3646, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(2096.1497, -2104.164, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(2456.2244, -1730.6714, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(2068.1797, -1680.4355, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(-671.2884, -1245.2837, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(-762.23816, -944.4588, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(-801.92365, -1541.8522, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(-966.87177, -1949.4353, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(-1532.9701, -2006.4147, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(-1694.746, -2091.608, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(-1737.8239, -2282.578, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(-1993.5835, -2251.4868, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(-2103.8945, -1931.3219, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(-1888.6968, -1960.3218, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(-2133.1853, -1694.8121, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(-1853.0706, -1633.2207, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(-1696.7527, -1541.481, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(25.25652, -755.45325, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(63.7477, 607.0643, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(588.61414, -24.017452, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(810.03406, -20.255314, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(706.0661, -24.787724, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(915.1969, -20.546467, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(-1698.7749, 2339.3335, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(-365.08282, 992.8901, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(-1869.5107, 2350.751, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(-1913.5497, 2244.559, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(-1467.1035, 2048.1162, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(-1437.2836, 1863.4172, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(-935.1476, 1962.6694, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(-747.48425, 1875.5658, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(-723.074, 1525.6538, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(-716.2954, 1244.1881, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(-132.18674, -87.31787, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(125.62849, 1062.3926, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(79.03424, 754.47424, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(457.42108, 1044.5096, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(736.6988, 1086.4049, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(880.15576, 1470.6039, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(885.1957, 1534.4404, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(1672.9143, 2257.3206, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(1759.8103, 2175.5037, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(1449.5831, 2153.218, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(1701.264, 2119.7344, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(1693.4132, 2407.8535, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(1842.008, 2513.1028, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(2067.0254, 2478.8577, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(1998.1714, 2315.0647, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(2188.9736, 2093.6995, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(2390.771, 2185.1123, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(2378.912, 2458.8147, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(-117.57565, 168.75847, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(-204.31348, 7.569913, 25));
		AddSpawnPoint( "d_prison_79.Id1", "d_prison_79", Spot(-118.172, -1040.0934, 25));

		// Socket_Bow_Red Spawn Points
		AddSpawnPoint( "d_prison_79.Id2", "d_prison_79", Spot(-1850.199, -2188.6763, 25));
		AddSpawnPoint( "d_prison_79.Id2", "d_prison_79", Spot(-1952.5569, -1671.2837, 25));
		AddSpawnPoint( "d_prison_79.Id2", "d_prison_79", Spot(-1679.4878, -1618.4685, 25));
		AddSpawnPoint( "d_prison_79.Id2", "d_prison_79", Spot(-1852.5376, -1891.459, 25));
		AddSpawnPoint( "d_prison_79.Id2", "d_prison_79", Spot(-1300.3477, -1951.8765, 25));
		AddSpawnPoint( "d_prison_79.Id2", "d_prison_79", Spot(-923.54565, -1904.5063, 25));
		AddSpawnPoint( "d_prison_79.Id2", "d_prison_79", Spot(-876.0574, -1564.569, 25));
		AddSpawnPoint( "d_prison_79.Id2", "d_prison_79", Spot(-849.7549, -1197.9236, 25));
		AddSpawnPoint( "d_prison_79.Id2", "d_prison_79", Spot(-1028.5535, -1081.9227, 25));
		AddSpawnPoint( "d_prison_79.Id2", "d_prison_79", Spot(-274.80533, -282.02988, 25));
		AddSpawnPoint( "d_prison_79.Id2", "d_prison_79", Spot(-1024.763, -967.12506, 25));
		AddSpawnPoint( "d_prison_79.Id2", "d_prison_79", Spot(858.1982, -1090.5613, 25));
		AddSpawnPoint( "d_prison_79.Id2", "d_prison_79", Spot(944.54785, -897.81335, 25));
		AddSpawnPoint( "d_prison_79.Id2", "d_prison_79", Spot(1074.4653, -1186.5238, 25));
		AddSpawnPoint( "d_prison_79.Id2", "d_prison_79", Spot(927.91565, -1388.7244, 25));
		AddSpawnPoint( "d_prison_79.Id2", "d_prison_79", Spot(1035.7395, -1596.7887, 25));
		AddSpawnPoint( "d_prison_79.Id2", "d_prison_79", Spot(1110.1122, -1936.2168, 25));
		AddSpawnPoint( "d_prison_79.Id2", "d_prison_79", Spot(1476.7543, -1983.2322, 25));
		AddSpawnPoint( "d_prison_79.Id2", "d_prison_79", Spot(1903.8167, -2054.5286, 25));
		AddSpawnPoint( "d_prison_79.Id2", "d_prison_79", Spot(1917.6731, -1812.6395, 25));
		AddSpawnPoint( "d_prison_79.Id2", "d_prison_79", Spot(2201.49, -1679.3583, 25));
		AddSpawnPoint( "d_prison_79.Id2", "d_prison_79", Spot(-157.62979, 153.76314, 25));
		AddSpawnPoint( "d_prison_79.Id2", "d_prison_79", Spot(-202.82886, 224.36697, 25));
		AddSpawnPoint( "d_prison_79.Id2", "d_prison_79", Spot(-189.84111, 89.609856, 25));
		AddSpawnPoint( "d_prison_79.Id2", "d_prison_79", Spot(-231.32263, -159.98781, 25));
		AddSpawnPoint( "d_prison_79.Id2", "d_prison_79", Spot(1824.2704, -2043.3293, 25));
		AddSpawnPoint( "d_prison_79.Id2", "d_prison_79", Spot(1787.2358, -1842.3744, 25));
		AddSpawnPoint( "d_prison_79.Id2", "d_prison_79", Spot(754.8822, -1055.8582, 25));
		AddSpawnPoint( "d_prison_79.Id2", "d_prison_79", Spot(-1662.3495, -1994.5907, 25));
		AddSpawnPoint( "d_prison_79.Id2", "d_prison_79", Spot(-1672.7184, -2254.36, 25));
		AddSpawnPoint( "d_prison_79.Id2", "d_prison_79", Spot(-1957.3658, -2301.9795, 25));
		AddSpawnPoint( "d_prison_79.Id2", "d_prison_79", Spot(-2134.7627, -1853.1172, 25));
		AddSpawnPoint( "d_prison_79.Id2", "d_prison_79", Spot(-1990.0005, -2012.5483, 25));

		// TerraNymph_Mage_Blue Spawn Points
		AddSpawnPoint( "d_prison_79.Id3", "d_prison_79", Spot(-276.02563, -14.228014, 25));
		AddSpawnPoint( "d_prison_79.Id3", "d_prison_79", Spot(-1228.495, 1957.7968, 25));
		AddSpawnPoint( "d_prison_79.Id3", "d_prison_79", Spot(-264.59897, 261.71637, 25));
		AddSpawnPoint( "d_prison_79.Id3", "d_prison_79", Spot(-1494.825, 1782.4132, 25));
		AddSpawnPoint( "d_prison_79.Id3", "d_prison_79", Spot(-1326.2505, 1946.2754, 25));
		AddSpawnPoint( "d_prison_79.Id3", "d_prison_79", Spot(-1502.3473, 2346.173, 25));
		AddSpawnPoint( "d_prison_79.Id3", "d_prison_79", Spot(-89.62491, -305.88052, 25));
		AddSpawnPoint( "d_prison_79.Id3", "d_prison_79", Spot(-1512.9178, 1952.3596, 25));
		AddSpawnPoint( "d_prison_79.Id3", "d_prison_79", Spot(-1564.0646, 2254.3533, 25));
		AddSpawnPoint( "d_prison_79.Id3", "d_prison_79", Spot(-1770.299, 2235.9001, 25));
		AddSpawnPoint( "d_prison_79.Id3", "d_prison_79", Spot(-1126.1399, 1957.2295, 25));
		AddSpawnPoint( "d_prison_79.Id3", "d_prison_79", Spot(-862.163, 1937.1462, 25));
		AddSpawnPoint( "d_prison_79.Id3", "d_prison_79", Spot(-719.0001, 1975.9346, 25));
		AddSpawnPoint( "d_prison_79.Id3", "d_prison_79", Spot(-695.25574, 1584.3794, 25));
		AddSpawnPoint( "d_prison_79.Id3", "d_prison_79", Spot(-682.94147, 1339.0962, 25));
		AddSpawnPoint( "d_prison_79.Id3", "d_prison_79", Spot(-677.895, 1133.5626, 25));
		AddSpawnPoint( "d_prison_79.Id3", "d_prison_79", Spot(-217.79231, -272.3589, 25));
		AddSpawnPoint( "d_prison_79.Id3", "d_prison_79", Spot(899.12256, 1185.7803, 25));
		AddSpawnPoint( "d_prison_79.Id3", "d_prison_79", Spot(932.8799, 1407.9567, 25));
		AddSpawnPoint( "d_prison_79.Id3", "d_prison_79", Spot(1672.4489, 2182.215, 25));
		AddSpawnPoint( "d_prison_79.Id3", "d_prison_79", Spot(952.3232, 1518.8237, 25));
		AddSpawnPoint( "d_prison_79.Id3", "d_prison_79", Spot(871.7771, 1596.1523, 25));
		AddSpawnPoint( "d_prison_79.Id3", "d_prison_79", Spot(1477.6422, 2111.0962, 25));
		AddSpawnPoint( "d_prison_79.Id3", "d_prison_79", Spot(1818.5692, 2129.5369, 25));
		AddSpawnPoint( "d_prison_79.Id3", "d_prison_79", Spot(1664.5306, 2044.5942, 25));
		AddSpawnPoint( "d_prison_79.Id3", "d_prison_79", Spot(1389.1139, 2046.958, 25));
		AddSpawnPoint( "d_prison_79.Id3", "d_prison_79", Spot(1421.3368, 2225.5315, 25));
		AddSpawnPoint( "d_prison_79.Id3", "d_prison_79", Spot(1758.8193, 2036.6416, 25));
		AddSpawnPoint( "d_prison_79.Id3", "d_prison_79", Spot(1713.2092, 2348.9944, 25));
		AddSpawnPoint( "d_prison_79.Id3", "d_prison_79", Spot(1799.1956, 2228.589, 25));
		AddSpawnPoint( "d_prison_79.Id3", "d_prison_79", Spot(1819.0095, 2397.41, 25));
		AddSpawnPoint( "d_prison_79.Id3", "d_prison_79", Spot(2025.8344, 2527.5073, 25));
		AddSpawnPoint( "d_prison_79.Id3", "d_prison_79", Spot(2166.633, 2484.7441, 25));
		AddSpawnPoint( "d_prison_79.Id3", "d_prison_79", Spot(2005.9204, 2323.9634, 25));
		AddSpawnPoint( "d_prison_79.Id3", "d_prison_79", Spot(2087.2131, 2039.3684, 25));
		AddSpawnPoint( "d_prison_79.Id3", "d_prison_79", Spot(2321.3652, 2058.7744, 25));
		AddSpawnPoint( "d_prison_79.Id3", "d_prison_79", Spot(2363.966, 2280.0908, 25));
		AddSpawnPoint( "d_prison_79.Id3", "d_prison_79", Spot(2344.2861, 2469.745, 25));

		// Rootcrystal_05 Spawn Points
		AddSpawnPoint( "d_prison_79.Id4", "d_prison_79", Spot(2102.6853, 2322.9392, 100));
		AddSpawnPoint( "d_prison_79.Id4", "d_prison_79", Spot(2268.453, 2029.1888, 100));
		AddSpawnPoint( "d_prison_79.Id4", "d_prison_79", Spot(1707.7467, 2080.9258, 100));
		AddSpawnPoint( "d_prison_79.Id4", "d_prison_79", Spot(1349.191, 2129.703, 100));
		AddSpawnPoint( "d_prison_79.Id4", "d_prison_79", Spot(845.89526, 1422.968, 100));
		AddSpawnPoint( "d_prison_79.Id4", "d_prison_79", Spot(748.20746, 1007.7925, 100));
		AddSpawnPoint( "d_prison_79.Id4", "d_prison_79", Spot(50.53399, 1014.8885, 100));
		AddSpawnPoint( "d_prison_79.Id4", "d_prison_79", Spot(210.82608, 124.18916, 100));
		AddSpawnPoint( "d_prison_79.Id4", "d_prison_79", Spot(-66.072945, 92.41937, 100));
		AddSpawnPoint( "d_prison_79.Id4", "d_prison_79", Spot(-105.23352, -212.69084, 100));
		AddSpawnPoint( "d_prison_79.Id4", "d_prison_79", Spot(1393.502, -148.05814, 100));
		AddSpawnPoint( "d_prison_79.Id4", "d_prison_79", Spot(69.30063, -743.67444, 100));
		AddSpawnPoint( "d_prison_79.Id4", "d_prison_79", Spot(1004.7333, -1006.9559, 100));
		AddSpawnPoint( "d_prison_79.Id4", "d_prison_79", Spot(986.6625, -1219.9199, 100));
		AddSpawnPoint( "d_prison_79.Id4", "d_prison_79", Spot(1720.43, -1973.6962, 100));
		AddSpawnPoint( "d_prison_79.Id4", "d_prison_79", Spot(2287.3586, -1682.2347, 100));
		AddSpawnPoint( "d_prison_79.Id4", "d_prison_79", Spot(2227.7444, -2139.7058, 100));
		AddSpawnPoint( "d_prison_79.Id4", "d_prison_79", Spot(-763.1824, -1163.25, 100));
		AddSpawnPoint( "d_prison_79.Id4", "d_prison_79", Spot(-921.6552, -920.4278, 100));
		AddSpawnPoint( "d_prison_79.Id4", "d_prison_79", Spot(-821.8413, -1946.4424, 100));
		AddSpawnPoint( "d_prison_79.Id4", "d_prison_79", Spot(-1668.1831, -2208.6423, 100));
		AddSpawnPoint( "d_prison_79.Id4", "d_prison_79", Spot(-1890.8756, -2248.295, 100));
		AddSpawnPoint( "d_prison_79.Id4", "d_prison_79", Spot(-1959.3279, -1951.1887, 100));
		AddSpawnPoint( "d_prison_79.Id4", "d_prison_79", Spot(-2035.3099, -1627.3046, 100));
		AddSpawnPoint( "d_prison_79.Id4", "d_prison_79", Spot(-1745.0819, -1649.3434, 100));
		AddSpawnPoint( "d_prison_79.Id4", "d_prison_79", Spot(-637.4578, 1035.8538, 100));
		AddSpawnPoint( "d_prison_79.Id4", "d_prison_79", Spot(-670.17285, 1914.2798, 100));
		AddSpawnPoint( "d_prison_79.Id4", "d_prison_79", Spot(-1271.3727, 1943.8049, 100));
		AddSpawnPoint( "d_prison_79.Id4", "d_prison_79", Spot(-1491.8241, 1671.2976, 100));
		AddSpawnPoint( "d_prison_79.Id4", "d_prison_79", Spot(-1873.522, 1651.0299, 100));
		AddSpawnPoint( "d_prison_79.Id4", "d_prison_79", Spot(-1946.0029, 1858.8192, 100));
		AddSpawnPoint( "d_prison_79.Id4", "d_prison_79", Spot(-1879.2955, 2294.4153, 100));

		// Socket_Bow_Red Spawn Points
		AddSpawnPoint( "d_prison_79.Id5", "d_prison_79", Spot(45.108185, 938.6509, 9999));

	}
}
