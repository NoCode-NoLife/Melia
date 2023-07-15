//--- Melia Script -----------------------------------------------------------
// f_3cmlake_27_3
//
//--- Description -----------------------------------------------------------
// Sets up the f_3cmlake_27_3 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class F3Cmlake273MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_3cmlake_27_3", MonsterId.Frocoli, Properties("MHP", 675994, "MINPATK", 9194, "MAXPATK", 11201, "MINMATK", 9194, "MAXMATK", 11201, "DEF", 173974, "MDEF", 173974));
		AddPropertyOverrides("f_3cmlake_27_3", MonsterId.Infro_Crabil, Properties("MHP", 677249, "MINPATK", 9210, "MAXPATK", 11221, "MINMATK", 9210, "MAXMATK", 11221, "DEF", 174871, "MDEF", 174871));

		// Monster Spawners --------------------------------

		AddSpawner("f_3cmlake_27_3.Id1", MonsterId.Frocoli, 65, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_27_3.Id2", MonsterId.Infro_Crabil, 82, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_27_3.Id3", MonsterId.Frocoli, 27, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_27_3.Id4", MonsterId.Rootcrystal_02, 20, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Frocoli Spawn Points
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(-1844.4475, -790.2263, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(-1649.0476, -863.90826, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(-1586.8889, -820.4971, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(-1476.4196, -667.98285, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(-1607.1871, -757.80365, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(-1534.1631, -585.7792, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(-1774.5444, -717.1628, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(-1835.8661, -627.5819, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(-1895.5339, -682.61865, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(-1719.5647, -807.21686, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(-1522.3359, -715.4428, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(-1797.2042, 21.190725, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(-1665.4385, 14.268101, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(-1696.0259, 155.87665, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(-1859.4714, 174.20755, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(-1930.3546, 115.91444, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(-1920.6665, 398.6521, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(-1689.689, 373.85452, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(-1673.0808, 499.50992, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(-1423.4355, 366.2087, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(-1520.9713, 76.30235, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(-1354.0642, 207.75864, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(-1505.9135, 278.6836, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(-1791.5927, 465.01315, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(-1817.837, 1129.676, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(-1662.1708, 1043.9164, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(-1450.3845, 1078.3085, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(-1451.6835, 1222.2852, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(-1582.3253, 1174.1418, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(-1730.8428, 1218.5636, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(-1845.4818, 1313.3441, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(-1695.4812, 1329.0621, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(-1559.9183, 1338.8346, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(-1424.8126, 1358.2328, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(-1321.8756, 1233.813, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(-64.27465, 1238.6763, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(18.47597, 1197.5715, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(177.88593, 1238.1387, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(76.168304, 1376.0814, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(31.042492, 1304.4799, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(-40.217728, 1336.9697, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(-176.3352, 1248.1454, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(24.195644, 1064.415, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(235.38182, 1283.5642, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(923.23346, -131.98593, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(850.3829, -141.72476, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(786.74976, -400.43237, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(944.57935, -266.16757, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(843.00397, -339.90347, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(949.6237, -355.74908, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(942.3541, -199.81741, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(695.75305, -287.7428, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(652.5585, -372.8163, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(709.35315, -210.93214, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(795.83856, -214.7952, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(1616.3578, 399.5203, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(1586.7059, 508.17334, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(1708.4762, 577.9223, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(1883.9188, 539.8385, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(1769.0157, 363.68872, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(1731.3123, 449.4147, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(1765.3837, 226.83612, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(2020.5398, 327.91983, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(1931.859, 427.40292, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Spot(1942.6228, 302.87164, 20));

		// Infro_Crabil Spawn Points
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(301.73853, -292.83487, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(137.80545, -364.25464, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(28.389072, -413.48666, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(233.94728, -335.38586, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(93.58179, -495.95676, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(191.69646, -200.71265, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(133.79594, -265.75616, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(207.20135, -505.66177, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(-84.45491, -350.7493, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(-52.88132, -458.82144, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(721.98755, 512.3717, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(791.1344, 632.13495, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(867.95526, 507.59897, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(1086.165, 614.2222, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(1025.8767, 474.33914, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(948.048, 656.25775, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(1105.9437, -242.7684, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(1120.4805, -311.13538, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(1121.1643, 486.10498, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(942.6107, -528.01227, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(978.12823, -507.8949, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(1603.6318, -935.2416, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(1643.3108, -847.4222, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(1667.3694, -331.9969, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(1740.5864, -595.4382, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(1801.9236, -807.41595, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(1853.9113, -857.29047, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(1914.3282, -508.62183, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(1817.6354, -571.185, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(1587.4756, -304.29578, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(1868.136, -430.92493, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(1995.026, -488.82635, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(2032.3479, -755.1956, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(2089.3372, -815.9779, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(2004.8267, -827.22534, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(1876.8549, -765.0934, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(1571.9546, -389.09497, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(-249.20047, 498.95404, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(-254.98004, 350.81628, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(-44.614334, 256.36148, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(-84.93833, 397.98117, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(-148.16083, 380.0293, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(-126.83675, 581.27106, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(-164.1752, 684.2895, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(36.542645, 699.5366, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(63.69342, 516.8196, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(365.54324, 606.23413, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(301.43, 488.56894, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(215.08427, 318.94037, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(221.56776, 609.8103, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(-921.09796, 310.25598, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(-893.6747, 168.57164, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(-776.74426, 160.93289, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(-669.02026, 204.54591, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(-655.8488, 340.85294, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(-768.91675, 351.6737, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(-822.9267, 425.76135, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(-986.75665, 291.24786, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(-907.308, -322.21597, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(-904.7646, -439.02408, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(-654.18726, -516.2141, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(-603.8285, -342.30798, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(-714.92883, -291.18115, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(-738.7892, -410.58627, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(-794.5977, -556.8344, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(-800.15326, -219.18552, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(-1006.3652, -349.56064, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(-1662.2358, -790.67, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(-1688.0309, -516.2284, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(1472.4423, -764.3751, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(1406.5992, -490.04852, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(1371.9274, -566.9088, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(1460.5306, -562.3, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(-1824.7456, -704.07086, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(1647.1826, -656.90106, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(1585.3336, -611.256, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(1446.552, -842.04376, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(1407.5544, -741.67084, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(1575.6235, -682.751, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(1054.9822, -295.4658, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(1741.9559, -522.1363, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(1689.4396, -935.7654, 25));
		AddSpawnPoint( "f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Spot(-1542.3175, -647.9652, 25));

		// Frocoli Spawn Points
		AddSpawnPoint( "f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Spot(-826.544, 265.03494, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Spot(-911.9954, 405.19287, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Spot(-969.6629, 390.90317, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Spot(-939.9022, 242.23117, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Spot(-722.82043, 259.51102, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Spot(-720.21783, 415.43173, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Spot(-773.1236, 476.3318, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Spot(-793.8822, -309.8236, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Spot(-801.2545, -448.1514, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Spot(-581.599, -452.3808, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Spot(-665.063, -405.78116, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Spot(-686.27686, -193.92548, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Spot(-916.4654, -212.52887, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Spot(-747.09863, -100.79762, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Spot(-520.7285, -388.88297, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Spot(-133.6417, 484.29495, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Spot(-52.587734, 509.07635, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Spot(112.02869, 446.14072, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Spot(103.5976, 294.49585, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Spot(209.4673, 403.03983, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Spot(97.479324, 605.7687, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Spot(-25.428904, 621.57574, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Spot(91.10797, 783.2154, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Spot(200.0664, 722.641, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Spot(-269.15674, 622.74023, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Spot(-344.3097, 455.9111, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Spot(-172.24846, 269.08942, 20));
		AddSpawnPoint( "f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Spot(357.94662, 419.92853, 20));

		// Rootcrystal_02 Spawn Points
		AddSpawnPoint( "f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Spot(33.742016, -1291.4866, 200));
		AddSpawnPoint( "f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Spot(49.508835, -861.2238, 200));
		AddSpawnPoint( "f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Spot(211.07779, -442.20325, 200));
		AddSpawnPoint( "f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Spot(850.1076, -263.70605, 200));
		AddSpawnPoint( "f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Spot(1391.6177, -809.008, 200));
		AddSpawnPoint( "f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Spot(1953.0383, -740.23975, 200));
		AddSpawnPoint( "f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Spot(874.38336, 294.56345, 200));
		AddSpawnPoint( "f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Spot(1204.4194, 555.6922, 200));
		AddSpawnPoint( "f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Spot(1732.8079, 455.68127, 200));
		AddSpawnPoint( "f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Spot(342.45157, 515.1167, 200));
		AddSpawnPoint( "f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Spot(-112.74881, 512.7635, 200));
		AddSpawnPoint( "f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Spot(29.55394, 1207.7118, 200));
		AddSpawnPoint( "f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Spot(-200.65277, -342.8705, 200));
		AddSpawnPoint( "f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Spot(-1431.3082, 396.4912, 200));
		AddSpawnPoint( "f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Spot(-1654.0594, -579.0088, 200));
		AddSpawnPoint( "f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Spot(-1593.3723, 1073.5626, 200));
		AddSpawnPoint( "f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Spot(-710.7064, -330.62003, 200));
		AddSpawnPoint( "f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Spot(-1682.335, 23.102018, 200));
		AddSpawnPoint( "f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Spot(-751.1718, 280.63077, 200));
		AddSpawnPoint( "f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Spot(1665.8066, -409.70593, 200));

	}
}
