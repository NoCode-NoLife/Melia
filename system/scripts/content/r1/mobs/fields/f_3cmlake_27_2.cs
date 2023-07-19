//--- Melia Script -----------------------------------------------------------
// f_3cmlake_27_2
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Maven 31 Waters' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class F3Cmlake272MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_3cmlake_27_2", MonsterId.Velpod, Properties("MHP", 671922, "MINPATK", 9141, "MAXPATK", 11137, "MINMATK", 9141, "MAXMATK", 11137, "DEF", 171064, "MDEF", 171064));
		AddPropertyOverrides("f_3cmlake_27_2", MonsterId.Tooter, Properties("MHP", 672779, "MINPATK", 9152, "MAXPATK", 11151, "MINMATK", 9152, "MAXMATK", 11151, "DEF", 171676, "MDEF", 171676));
		AddPropertyOverrides("f_3cmlake_27_2", MonsterId.Monitor_Lizard, Properties("MHP", 673751, "MINPATK", 9165, "MAXPATK", 11166, "MINMATK", 9165, "MAXMATK", 11166, "DEF", 172371, "MDEF", 172371));
		AddPropertyOverrides("f_3cmlake_27_2", MonsterId.Boss_Moldyhorn_3cmlake_27_2, Properties("MHP", 3522587, "MINPATK", 23130, "MAXPATK", 28181, "MINMATK", 23130, "MAXMATK", 28181, "DEF", 436310, "MDEF", 436310));

		// Monster Spawners ---------------------------------

		AddSpawner("f_3cmlake_27_2.Id1", MonsterId.Velpod, 49, 65, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_27_2.Id2", MonsterId.Tooter, 11, 14, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_27_2.Id3", MonsterId.Rootcrystal_02, 16, 21, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_27_2.Id4", MonsterId.Monitor_Lizard, 60, 80, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Velpod' GenType 1 Spawn Points
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-1245.6503, -143.58812, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1475.563, -376.8401, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1665.8591, -334.20236, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1078.572, -362.9635, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(759.7965, -314.5192, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(949.76984, -437.60532, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(877.5564, -505.0962, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(728.1289, -465.4909, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(823.16327, -572.46313, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1794.4806, -349.74878, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1697.8613, -390.0677, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1735.241, -296.20035, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1834.1073, -374.62628, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1709.4944, -497.26495, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1660.3552, -576.4105, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1760.1604, -606.04285, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1693.0165, -654.75836, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1949.3987, -529.9975, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1952.6671, -365.29858, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1983.409, -289.34985, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(2168.5996, -392.80615, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(2064.7922, -494.1013, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(2019.8008, -407.3655, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1804.5038, -704.5732, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(892.8579, -267.99542, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1005.2775, -276.54816, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1500.0187, -441.89896, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1058.3601, -531.70514, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(885.19794, -339.15778, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-1000.8185, 360.78085, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-462.12424, -467.38824, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-724.03046, -231.46803, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-834.3281, -828.3288, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-521.04224, -439.73996, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-1041.1919, 325.04047, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-740.34, 965.9089, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-627.23865, 464.38235, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-573.6372, 424.87347, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-710.8293, -66.229065, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-350.98785, 441.09195, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-614.47815, 1106.91, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-723.34314, 1213.4823, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-565.55194, 1214.3793, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-407.68686, 1099.4644, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-593.78735, 956.7186, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-485.52283, 1145.1195, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-626.78796, 276.69528, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-794.0717, 185.1711, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-756.5171, 27.399641, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-642.21326, 110.97002, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-547.1744, 219.8027, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-1504.8851, -192.63992, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-1462.2418, -238.02066, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-1251.7102, -417.89816, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-1315.7247, -431.31662, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-1445.0958, -187.9945, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-746.21265, -463.75888, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-854.52496, -517.7655, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-822.697, -599.8612, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-768.1207, -555.7117, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-919.41504, -1044.3059, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-653.53644, -1074.3121, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-430.6685, 948.2917, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-430.6685, 948.2917, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1431.7344, -396.74026, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1891.4181, -304.8084, 25));

		// 'Tooter' GenType 2 Spawn Points
		AddSpawnPoint("f_3cmlake_27_2.Id2", "f_3cmlake_27_2", Rectangle(-559.542, 1054.7362, 20));
		AddSpawnPoint("f_3cmlake_27_2.Id2", "f_3cmlake_27_2", Rectangle(-749.4865, -36.137726, 20));
		AddSpawnPoint("f_3cmlake_27_2.Id2", "f_3cmlake_27_2", Rectangle(-1337.3658, -288.56262, 20));
		AddSpawnPoint("f_3cmlake_27_2.Id2", "f_3cmlake_27_2", Rectangle(-838.8779, -576.31696, 20));
		AddSpawnPoint("f_3cmlake_27_2.Id2", "f_3cmlake_27_2", Rectangle(-692.1568, -1165.3441, 20));
		AddSpawnPoint("f_3cmlake_27_2.Id2", "f_3cmlake_27_2", Rectangle(661.9254, -1654.6736, 20));
		AddSpawnPoint("f_3cmlake_27_2.Id2", "f_3cmlake_27_2", Rectangle(519.46045, -1016.9199, 20));
		AddSpawnPoint("f_3cmlake_27_2.Id2", "f_3cmlake_27_2", Rectangle(1736.755, -337.6999, 20));
		AddSpawnPoint("f_3cmlake_27_2.Id2", "f_3cmlake_27_2", Rectangle(-452.04462, -1823.9469, 20));
		AddSpawnPoint("f_3cmlake_27_2.Id2", "f_3cmlake_27_2", Rectangle(-693.3639, -359.75897, 20));
		AddSpawnPoint("f_3cmlake_27_2.Id2", "f_3cmlake_27_2", Rectangle(-554.5462, 319.6358, 20));
		AddSpawnPoint("f_3cmlake_27_2.Id2", "f_3cmlake_27_2", Rectangle(-877.9347, 279.42395, 20));
		AddSpawnPoint("f_3cmlake_27_2.Id2", "f_3cmlake_27_2", Rectangle(-836.8625, -870.3416, 20));
		AddSpawnPoint("f_3cmlake_27_2.Id2", "f_3cmlake_27_2", Rectangle(2111.2292, -512.4658, 20));

		// 'Rootcrystal_02' GenType 27 Spawn Points
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(1703.2449, -492.06134, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(823.3747, -432.35812, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(649.9132, -978.807, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(679.6771, -1526.3613, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(47.867836, -1669.5458, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(-438.79108, -1800.9907, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(-784.2288, -643.2259, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(-794.24493, -1068.4838, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(-1265.0328, -245.05945, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(-484.63913, 432.0565, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(-591.8827, 1024.2434, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(138.2244, 396.59573, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(345.52435, -429.49393, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(-33.6333, -452.8314, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(2082.316, -448.97357, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(-696.59735, 137.9801, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(475.9602, -1625.6448, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(1159.0582, -417.72385, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(270.18616, 51.926773, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(46.677086, -1995.018, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(297.02948, -958.2561, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(-748.57404, -250.42719, 200));

		// 'Monitor_Lizard' GenType 28 Spawn Points
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(539.7595, -1551.7269, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(441.41208, -1678.2593, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(502.62122, -969.2843, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(498.62924, -893.9153, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(605.1616, -797.1211, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(688.79315, -890.6815, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(757.5904, -1014.6578, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(779.4487, -850.7333, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(606.61304, -1483.5812, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(773.43115, -1522.1847, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(640.2129, -1400.5839, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(565.1762, -1729.0892, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(739.9785, -1569.3213, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(572.57, -1664.3677, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(753.5915, -1676.05, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(419.62253, -1635.4, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(151.47235, -1629.6799, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(62.15967, -1590.0701, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(11.436355, -1619.354, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-494.47537, -1953.2405, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-463.65347, -1893.3569, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-579.2639, -1792.0432, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-571.7156, -1730.6924, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-384.04736, -1977.9723, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-332.32693, -1948.6462, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-356.3458, -1764.8141, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(690.6847, -1074.2205, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(64.37537, -1118.4294, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(45.695415, -997.2025, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(636.82574, -1091.7869, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-731.0602, -951.0351, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-333.40903, -1825.2416, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(3.2710776, -1082.7661, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-450.69714, -1829.0758, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-807.82166, -628.0893, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-895.70886, -499.0602, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-694.7355, -458.02948, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-859.02185, -665.8243, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-684.2719, -273.46875, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-475.8864, -1661.5854, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-417.8965, -1638.631, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-789.9826, -449.93335, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-1159.646, -227.59961, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-1436.5564, -343.56107, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-1171.1764, -300.015, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-1239.7335, -340.82855, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-1141.5684, -98.162994, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-1449.5483, -403.34366, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-1341.4543, -172.5876, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-681.8704, -217.95584, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-769.34625, -1.8945879, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-663.9066, 112.81522, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-858.22675, 281.7092, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-649.84595, 340.97638, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-714.7391, 249.99661, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-448.5309, 486.11697, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-555.1412, 502.98737, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-664.4489, 1048.4796, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-433.51727, 1235.3195, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-391.79898, 1134.6248, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-479.03912, 1012.0972, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-642.2866, 1239.6372, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-518.6792, 1142.3654, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-586.5059, 745.29285, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-589.33636, 645.097, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-581.75024, 944.04205, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(610.45374, -892.46936, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(707.4768, -952.5915, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(373.96313, -986.9828, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(148.93701, -957.53046, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-795.7032, -1148.9392, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-853.0466, -1062.9286, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-802.59247, -961.5773, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-679.28436, -986.30475, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-733.2093, -1044.9353, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-989.45276, -289.79083, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-830.8693, -284.53848, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-630.23096, 5.057373, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-880.06146, -994.7898, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-471.37393, 169.97803, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-407.25385, 369.6247, 30));
	}
}
