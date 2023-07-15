//--- Melia Script -----------------------------------------------------------
// ep13_f_siauliai_2
//
//--- Description -----------------------------------------------------------
// Sets up the ep13_f_siauliai_2 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class Ep13FSiauliai2MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("ep13_f_siauliai_2", MonsterId.Darbas_Miner, Properties("MHP", 921285, "MINPATK", 12347, "MAXPATK", 15078, "MINMATK", 12347, "MAXMATK", 15078, "DEF", 386086, "MDEF", 386086));
		AddPropertyOverrides("ep13_f_siauliai_2", MonsterId.Darbas_Carrier, Properties("MHP", 924645, "MINPATK", 12391, "MAXPATK", 15131, "MINMATK", 12391, "MAXMATK", 15131, "DEF", 389894, "MDEF", 389894));
		AddPropertyOverrides("ep13_f_siauliai_2", MonsterId.Darbas_Loader, Properties("MHP", 928298, "MINPATK", 12438, "MAXPATK", 15189, "MINMATK", 12438, "MAXMATK", 15189, "DEF", 394035, "MDEF", 394035));

		// Monster Spawners --------------------------------

		AddSpawner("ep13_f_siauliai_2.Id1", MonsterId.Rootcrystal_01, 22, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_2.Id2", MonsterId.Darbas_Miner, 40, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_2.Id3", MonsterId.Darbas_Carrier, 90, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_2.Id4", MonsterId.Darbas_Loader, 90, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_2.Id5", MonsterId.Darbas_Miner, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_2.Id6", MonsterId.Darbas_Miner, 2, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_2.Id7", MonsterId.Darbas_Miner, 2, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_2.Id8", MonsterId.Darbas_Miner, 2, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_2.Id9", MonsterId.Darbas_Miner, 2, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_2.Id10", MonsterId.Darbas_Miner, 2, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Spot(2794.962, -731.8422, 100));
		AddSpawnPoint( "ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Spot(2365.6511, -1216.4115, 100));
		AddSpawnPoint( "ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Spot(1879.7211, -704.17847, 100));
		AddSpawnPoint( "ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Spot(1387.8823, -1026.0297, 100));
		AddSpawnPoint( "ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Spot(1042.6975, -801.7676, 100));
		AddSpawnPoint( "ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Spot(1405.982, 133.7756, 100));
		AddSpawnPoint( "ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Spot(966.08905, 353.14807, 100));
		AddSpawnPoint( "ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Spot(1418.2528, 825.5219, 100));
		AddSpawnPoint( "ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Spot(965.9754, 1159.6167, 100));
		AddSpawnPoint( "ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Spot(568.1975, 1491.0067, 100));
		AddSpawnPoint( "ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Spot(107.07793, 1595.6724, 100));
		AddSpawnPoint( "ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Spot(-217.30365, 2005.2997, 100));
		AddSpawnPoint( "ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Spot(-427.66983, 1521.6234, 100));
		AddSpawnPoint( "ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Spot(-483.53244, 424.14548, 100));
		AddSpawnPoint( "ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Spot(-1001.5187, 463.969, 100));
		AddSpawnPoint( "ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Spot(82.00029, 184.8484, 100));
		AddSpawnPoint( "ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Spot(-1034.0455, -617.97034, 100));
		AddSpawnPoint( "ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Spot(-1518.9531, -570.179, 100));
		AddSpawnPoint( "ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Spot(-1369.4738, -1057.8624, 100));
		AddSpawnPoint( "ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Spot(-1972.5089, -1009.2802, 100));
		AddSpawnPoint( "ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Spot(-42.643726, -1454.2603, 100));
		AddSpawnPoint( "ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Spot(509.8534, -964.9967, 100));

		// Darbas_Miner Spawn Points
		AddSpawnPoint( "ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Spot(2859.8784, -664.68146, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Spot(1399.4944, -810.6732, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Spot(1291.8315, 193.37704, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Spot(1049.6074, 267.89734, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Spot(629.4764, 457.67508, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Spot(94.57822, 137.14145, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Spot(-509.3573, 485.8727, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Spot(-1027.4519, 427.06516, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Spot(-361.76807, 1464.9525, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Spot(504.13507, 1390.3499, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Spot(1497.199, 884.37756, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Spot(0.26785278, -1258.4031, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Spot(-1707.9314, -719.45996, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Spot(-1467.0444, -546.7075, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Spot(-2288.675, -828.7597, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Spot(1066.6171, -901.4491, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Spot(2123.8416, -733.7941, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Spot(497.49973, -1139.0784, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Spot(670.56464, -1057.359, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Spot(-49.249283, -828.2639, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Spot(-1031.1329, -485.23642, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Spot(-72.15077, 1646.8447, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Spot(-1963.1956, -936.063, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Spot(-39.062447, -1866.6765, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Spot(-1234.4485, -776.44904, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Spot(-1263.686, -1069.995, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Spot(475.79276, 1665.2781, 20));

		// Darbas_Carrier Spawn Points
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(2934.8787, -730.683, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(2149.1824, -856.4011, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(1315.6238, -1054.1248, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(1542.3804, -827.717, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(1249.6304, -866.4083, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(846.8432, -684.1388, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(1304.4056, 316.13513, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(1495.5798, -100.13468, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(1208.6353, -23.82954, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(991.351, 460.50024, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(488.1371, 402.32983, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(761.0062, 493.73514, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(-58.241016, 168.00446, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(142.79692, 258.02014, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(-474.21686, 351.53864, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(-418.07687, 592.229, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(-897.6308, 478.8164, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(-1177.5049, 435.5163, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(-533.942, 1588.733, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(-280.1836, 1470.205, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(-297.76117, 2019.5656, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(-73.44104, 1897.7699, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(344.99023, 1617.1624, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(702.61005, 1316.8145, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(1368.4738, 907.9902, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(1639.3009, 951.3814, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(86.12025, -1535.546, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(-14.765686, -1134.3915, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(-81.78574, -1780.5883, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(-2250.0342, -949.4517, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(-2109.028, -901.611, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(-1781.9104, -827.0719, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(-1755.1184, -554.44464, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(-1439.2211, -673.52026, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(-1421.1206, -453.03784, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(-1402.0914, -1013.027, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(-887.69104, -715.9657, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(-761.7731, -936.9157, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(813.25287, 1449.76, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(48.69342, -1341.2781, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(2455.647, -1321.1128, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(-1303.9965, -887.15436, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(-2157.5188, -1195.4319, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(3228.7095, -718.18164, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(3055.9766, -820.6359, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(1999.1632, -704.5836, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(2365.4985, -1191.6913, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(1379.9176, 724.5259, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(857.0171, 1619.3313, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(-401.9123, 850.9296, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(-994.5588, -247.2751, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(-1052.144, -630.01245, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(-2428.998, -1178.934, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(1399.6434, 499.01038, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(1906.8474, 1000.2763, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(-278.84113, 120.86132, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(-96.50902, -1.3293419, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(2770.4631, -875.9572, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(2850.7534, -777.04395, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(2307.0105, -699.2529, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(2427.292, -677.24884, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(2627.7217, -720.28925, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(1290.7113, -595.2654, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(1325.4072, -434.41415, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(376.49484, -355.27338, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(111.69835, -136.36613, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(609.8521, -1222.5193, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(354.00525, -1077.8517, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(545.88324, -1020.1241, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(715.3497, -917.2883, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(-33.723343, -960.1632, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(-552.2844, -859.04944, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(-862.7732, -856.6297, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(-989.5136, -35.08694, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(168.84985, 1676.6506, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(1082.5586, 875.8108, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(1389.9553, 1022.1274, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(1680.0212, 842.25934, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(-1609.1729, -546.3194, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(-1990.9341, -935.0529, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(-1915.3232, -1060.1724, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(-469.76855, 1457.2546, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(1407.002, 69.5188, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(2323.4473, -1302.5582, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(1623.8147, -718.9595, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(1533.3778, -966.23346, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(-2430.1404, -897.3333, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(261.33713, -921.2979, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(35.19913, -1594.2855, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(-1446.6316, -810.10315, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(884.75555, 1179.8159, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(933.31836, 937.2622, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(599.2286, 1333.8422, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(604.6723, 1495.3026, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Spot(1047.7074, -739.95966, 20));

		// Darbas_Loader Spawn Points
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(3202.3418, -809.2227, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(2161.3535, -646.92596, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(2232.807, -1328.365, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(1433.4763, -1125.6318, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(1171.8624, -1012.4012, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(1202.8629, -715.05786, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(26.02602, -1848.4023, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(-175.59659, -831.66174, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(355.09576, -955.272, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(114.3068, -1428.9757, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(-969.1714, -794.06134, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(-760.8254, -796.74677, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(-1559.1228, -447.11017, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(-1344.425, -589.6936, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(-1893.2092, -663.44794, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(-1621.4376, -869.09863, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(-2414.6545, -786.8303, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(-2184.4958, -768.28406, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(-1821.3828, -1052.7659, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(-1499.9349, -1063.5966, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(-960.61224, 119.29574, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(-1180.3435, -487.77118, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(174.26636, -253.4897, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(670.01624, 310.57703, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(610.6978, 635.7109, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(908.03503, 255.69453, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(1162.3646, 292.66132, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(1378.4915, -71.42648, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(1422.0432, 310.79486, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(1506.6327, 755.0784, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(1487.0322, 1023.3499, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(456.26852, 1491.8, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(578.3862, 1604.5258, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(724.6445, 1635.9108, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(41.254246, 1626.2456, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(-149.96323, 2046.5293, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(-389.1212, 1358.3564, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(-491.36765, 1734.4277, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(-402.42783, 1038.115, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(-654.1326, 499.4972, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(-319.1998, 383.18402, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(-952.7089, 303.5332, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(-1121.2124, 568.4414, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(-2270.64, -1263.1311, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(-344.48325, -841.1939, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(16.659508, -815.5063, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(1205.076, 687.5085, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(998.9344, 984.31384, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(229.9978, 1591.4355, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(-1684.0287, -1069.4318, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(-2285.7668, -1127.6786, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(1761.7732, -711.6873, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(1436.268, -358.3418, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(1805.8566, 972.48425, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(1225.139, 799.83417, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(-192.33598, -4.682247, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(961.8885, 1250.7885, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(169.457, 427.59195, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(323.98123, 243.31316, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(2285.8716, -1117.6704, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(2465.6912, -1207.9591, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(2533.825, -1091.0637, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(2249.2322, -939.6223, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(2225.3088, -775.3761, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(3029.617, -734.96606, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(2755.7583, -736.28955, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(3326.3677, -679.92413, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(1411.0005, -939.6669, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(723.6993, -1228.838, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(618.6425, -1125.751, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(734.2918, -779.2414, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(895.2767, -813.8662, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(618.0545, -895.31964, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(-386.75613, 1585.2098, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(1472.5347, 176.6578, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(1229.9873, 125.51886, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(1510.9225, -726.237, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(-363.951, 258.7339, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(-1364.1484, -1111.0515, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(-1186.2286, -1122.6843, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(-1573.9032, -743.8884, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(501.9328, 1313.4047, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(887.1701, 1473.96, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(927.5474, 1627.1241, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(777.0558, 1273.7545, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(-168.89505, 1919.1923, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(-300.07248, 1943.3448, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Spot(-402.27933, 739.88104, 20));

		// Darbas_Miner Spawn Points
		AddSpawnPoint( "ep13_f_siauliai_2.Id5", "ep13_f_siauliai_2", Spot(-1256.3351, 487.894, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id6", "ep13_f_siauliai_2", Spot(-551.3528, 1760.9244, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id7", "ep13_f_siauliai_2", Spot(1625.8811, 762.1877, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id8", "ep13_f_siauliai_2", Spot(1120.555, 80.972885, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id9", "ep13_f_siauliai_2", Spot(451.0514, -1015.0561, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id10", "ep13_f_siauliai_2", Spot(-1788.2191, -365.2442, 20));
		AddSpawnPoint( "ep13_f_siauliai_2.Id10", "ep13_f_siauliai_2", Spot(-2087.4556, -1066.514, 20));

	}
}
