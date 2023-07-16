//--- Melia Script -----------------------------------------------------------
// id_catacomb_38_2
//
//--- Description -----------------------------------------------------------
// Sets up the id_catacomb_38_2 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class IdCatacomb382MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("id_catacomb_38_2.Id1", MonsterId.Rootcrystal_01, 11, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("id_catacomb_38_2.Id2", MonsterId.Rambear_Mage, 40, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("id_catacomb_38_2.Id3", MonsterId.Ticen_Bow, 40, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("id_catacomb_38_2.Id4", MonsterId.Hepatica_Purple, 28, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "id_catacomb_38_2.Id1", "id_catacomb_38_2", Spot(1038.4447, -869.0204, 150));
		AddSpawnPoint( "id_catacomb_38_2.Id1", "id_catacomb_38_2", Spot(1456.1808, -627.47235, 150));
		AddSpawnPoint( "id_catacomb_38_2.Id1", "id_catacomb_38_2", Spot(2224.788, -85.97009, 150));
		AddSpawnPoint( "id_catacomb_38_2.Id1", "id_catacomb_38_2", Spot(-176.25201, -1712.8828, 150));
		AddSpawnPoint( "id_catacomb_38_2.Id1", "id_catacomb_38_2", Spot(257.00616, -783.6602, 150));
		AddSpawnPoint( "id_catacomb_38_2.Id1", "id_catacomb_38_2", Spot(-346.4471, -536.81433, 150));
		AddSpawnPoint( "id_catacomb_38_2.Id1", "id_catacomb_38_2", Spot(7.3429813, 441.49146, 150));
		AddSpawnPoint( "id_catacomb_38_2.Id1", "id_catacomb_38_2", Spot(-178.19945, 1160.0819, 150));
		AddSpawnPoint( "id_catacomb_38_2.Id1", "id_catacomb_38_2", Spot(243.94269, 1550.7245, 150));
		AddSpawnPoint( "id_catacomb_38_2.Id1", "id_catacomb_38_2", Spot(-2163.1858, -444.8596, 150));
		AddSpawnPoint( "id_catacomb_38_2.Id1", "id_catacomb_38_2", Spot(-1078.553, -756.8302, 150));

		// Rambear_Mage Spawn Points
		AddSpawnPoint( "id_catacomb_38_2.Id2", "id_catacomb_38_2", Spot(-118.05281, -1390.4384, 25));
		AddSpawnPoint( "id_catacomb_38_2.Id2", "id_catacomb_38_2", Spot(-245.87344, -1445.793, 25));
		AddSpawnPoint( "id_catacomb_38_2.Id2", "id_catacomb_38_2", Spot(-273.70383, -1751.2189, 25));
		AddSpawnPoint( "id_catacomb_38_2.Id2", "id_catacomb_38_2", Spot(70.9867, -1747.9972, 25));
		AddSpawnPoint( "id_catacomb_38_2.Id2", "id_catacomb_38_2", Spot(74.2525, -1494.0846, 25));
		AddSpawnPoint( "id_catacomb_38_2.Id2", "id_catacomb_38_2", Spot(-113.97938, -1804.7257, 25));
		AddSpawnPoint( "id_catacomb_38_2.Id2", "id_catacomb_38_2", Spot(-1351.323, -602.64844, 25));
		AddSpawnPoint( "id_catacomb_38_2.Id2", "id_catacomb_38_2", Spot(-1091.3256, -565.61176, 25));
		AddSpawnPoint( "id_catacomb_38_2.Id2", "id_catacomb_38_2", Spot(-1219.8624, -671.40826, 25));
		AddSpawnPoint( "id_catacomb_38_2.Id2", "id_catacomb_38_2", Spot(-1025.5775, -785.69794, 25));
		AddSpawnPoint( "id_catacomb_38_2.Id2", "id_catacomb_38_2", Spot(-2222.4905, -677.8168, 25));
		AddSpawnPoint( "id_catacomb_38_2.Id2", "id_catacomb_38_2", Spot(-2219.745, -419.4235, 25));
		AddSpawnPoint( "id_catacomb_38_2.Id2", "id_catacomb_38_2", Spot(-2012.6447, -695.7763, 25));
		AddSpawnPoint( "id_catacomb_38_2.Id2", "id_catacomb_38_2", Spot(-160.41158, -764.2425, 25));
		AddSpawnPoint( "id_catacomb_38_2.Id2", "id_catacomb_38_2", Spot(230.00815, -371.97858, 25));
		AddSpawnPoint( "id_catacomb_38_2.Id2", "id_catacomb_38_2", Spot(207.17813, -952.1529, 25));
		AddSpawnPoint( "id_catacomb_38_2.Id2", "id_catacomb_38_2", Spot(-43.879723, -736.10767, 25));
		AddSpawnPoint( "id_catacomb_38_2.Id2", "id_catacomb_38_2", Spot(-245.08974, -340.7095, 25));
		AddSpawnPoint( "id_catacomb_38_2.Id2", "id_catacomb_38_2", Spot(-41.989758, -558.3901, 25));
		AddSpawnPoint( "id_catacomb_38_2.Id2", "id_catacomb_38_2", Spot(1088.8591, -688.6919, 25));
		AddSpawnPoint( "id_catacomb_38_2.Id2", "id_catacomb_38_2", Spot(1274.2833, -578.65247, 25));
		AddSpawnPoint( "id_catacomb_38_2.Id2", "id_catacomb_38_2", Spot(1239.9271, -860.66595, 25));
		AddSpawnPoint( "id_catacomb_38_2.Id2", "id_catacomb_38_2", Spot(1953.9606, -66.02288, 25));
		AddSpawnPoint( "id_catacomb_38_2.Id2", "id_catacomb_38_2", Spot(2120.274, 252.1193, 25));
		AddSpawnPoint( "id_catacomb_38_2.Id2", "id_catacomb_38_2", Spot(2214.438, 32.424084, 25));
		AddSpawnPoint( "id_catacomb_38_2.Id2", "id_catacomb_38_2", Spot(852.1458, -701.66833, 25));
		AddSpawnPoint( "id_catacomb_38_2.Id2", "id_catacomb_38_2", Spot(39.018692, 422.51685, 25));
		AddSpawnPoint( "id_catacomb_38_2.Id2", "id_catacomb_38_2", Spot(-160.28929, 362.9021, 25));
		AddSpawnPoint( "id_catacomb_38_2.Id2", "id_catacomb_38_2", Spot(-2080.033, -525.6931, 25));

		// Ticen_Bow Spawn Points
		AddSpawnPoint( "id_catacomb_38_2.Id3", "id_catacomb_38_2", Spot(1045.2893, -753.3009, 30));
		AddSpawnPoint( "id_catacomb_38_2.Id3", "id_catacomb_38_2", Spot(1174.4882, -496.79382, 30));
		AddSpawnPoint( "id_catacomb_38_2.Id3", "id_catacomb_38_2", Spot(1390.7676, -837.79156, 30));
		AddSpawnPoint( "id_catacomb_38_2.Id3", "id_catacomb_38_2", Spot(1871.1885, -273.03723, 30));
		AddSpawnPoint( "id_catacomb_38_2.Id3", "id_catacomb_38_2", Spot(2004.4623, 105.7921, 30));
		AddSpawnPoint( "id_catacomb_38_2.Id3", "id_catacomb_38_2", Spot(2186.864, -213.36534, 30));
		AddSpawnPoint( "id_catacomb_38_2.Id3", "id_catacomb_38_2", Spot(2216.609, -1.2738743, 30));
		AddSpawnPoint( "id_catacomb_38_2.Id3", "id_catacomb_38_2", Spot(2380.5815, 204.5822, 30));
		AddSpawnPoint( "id_catacomb_38_2.Id3", "id_catacomb_38_2", Spot(-42.63749, -417.47345, 30));
		AddSpawnPoint( "id_catacomb_38_2.Id3", "id_catacomb_38_2", Spot(-14.688599, -923.0343, 30));
		AddSpawnPoint( "id_catacomb_38_2.Id3", "id_catacomb_38_2", Spot(-283.08237, -685.00574, 30));
		AddSpawnPoint( "id_catacomb_38_2.Id3", "id_catacomb_38_2", Spot(177.42516, -669.4186, 30));
		AddSpawnPoint( "id_catacomb_38_2.Id3", "id_catacomb_38_2", Spot(2172.168, 360.27435, 30));
		AddSpawnPoint( "id_catacomb_38_2.Id3", "id_catacomb_38_2", Spot(-87.93143, 327.44666, 30));
		AddSpawnPoint( "id_catacomb_38_2.Id3", "id_catacomb_38_2", Spot(-227.27228, 450.62204, 30));
		AddSpawnPoint( "id_catacomb_38_2.Id3", "id_catacomb_38_2", Spot(4.047104, 527.6722, 30));
		AddSpawnPoint( "id_catacomb_38_2.Id3", "id_catacomb_38_2", Spot(27.973713, 366.1639, 30));
		AddSpawnPoint( "id_catacomb_38_2.Id3", "id_catacomb_38_2", Spot(167.5859, 250.51712, 30));
		AddSpawnPoint( "id_catacomb_38_2.Id3", "id_catacomb_38_2", Spot(-67.67928, -682.8457, 30));
		AddSpawnPoint( "id_catacomb_38_2.Id3", "id_catacomb_38_2", Spot(-275.46945, -941.23267, 30));
		AddSpawnPoint( "id_catacomb_38_2.Id3", "id_catacomb_38_2", Spot(236.80655, -937.9459, 30));
		AddSpawnPoint( "id_catacomb_38_2.Id3", "id_catacomb_38_2", Spot(225.0235, -376.11517, 30));
		AddSpawnPoint( "id_catacomb_38_2.Id3", "id_catacomb_38_2", Spot(-279.489, -341.33676, 30));
		AddSpawnPoint( "id_catacomb_38_2.Id3", "id_catacomb_38_2", Spot(1298.7537, -703.53424, 30));
		AddSpawnPoint( "id_catacomb_38_2.Id3", "id_catacomb_38_2", Spot(1434.5475, -534.8554, 30));
		AddSpawnPoint( "id_catacomb_38_2.Id3", "id_catacomb_38_2", Spot(2056.2952, -105.63734, 30));
		AddSpawnPoint( "id_catacomb_38_2.Id3", "id_catacomb_38_2", Spot(2007.2125, 343.61798, 30));

		// Hepatica_Purple Spawn Points
		AddSpawnPoint( "id_catacomb_38_2.Id4", "id_catacomb_38_2", Spot(-329.60535, 1078.8682, 20));
		AddSpawnPoint( "id_catacomb_38_2.Id4", "id_catacomb_38_2", Spot(-308.7466, 377.40564, 20));
		AddSpawnPoint( "id_catacomb_38_2.Id4", "id_catacomb_38_2", Spot(-328.07837, 192.62926, 20));
		AddSpawnPoint( "id_catacomb_38_2.Id4", "id_catacomb_38_2", Spot(253.09079, 193.69646, 20));
		AddSpawnPoint( "id_catacomb_38_2.Id4", "id_catacomb_38_2", Spot(264.2824, 509.75858, 20));
		AddSpawnPoint( "id_catacomb_38_2.Id4", "id_catacomb_38_2", Spot(-97.62709, -200.65956, 20));
		AddSpawnPoint( "id_catacomb_38_2.Id4", "id_catacomb_38_2", Spot(106.24934, -214.48444, 20));
		AddSpawnPoint( "id_catacomb_38_2.Id4", "id_catacomb_38_2", Spot(-431.33508, -626.6346, 20));
		AddSpawnPoint( "id_catacomb_38_2.Id4", "id_catacomb_38_2", Spot(-431.83356, -874.1563, 20));
		AddSpawnPoint( "id_catacomb_38_2.Id4", "id_catacomb_38_2", Spot(468.97992, -772.0942, 20));
		AddSpawnPoint( "id_catacomb_38_2.Id4", "id_catacomb_38_2", Spot(852.60944, -769.4435, 20));
		AddSpawnPoint( "id_catacomb_38_2.Id4", "id_catacomb_38_2", Spot(1346.212, -377.87582, 20));
		AddSpawnPoint( "id_catacomb_38_2.Id4", "id_catacomb_38_2", Spot(1413.8716, -380.0241, 20));
		AddSpawnPoint( "id_catacomb_38_2.Id4", "id_catacomb_38_2", Spot(2359.825, -326.35495, 20));
		AddSpawnPoint( "id_catacomb_38_2.Id4", "id_catacomb_38_2", Spot(2431.8289, -170.68819, 20));
		AddSpawnPoint( "id_catacomb_38_2.Id4", "id_catacomb_38_2", Spot(-1361.5903, -957.20325, 20));
		AddSpawnPoint( "id_catacomb_38_2.Id4", "id_catacomb_38_2", Spot(-857.81946, -791.7964, 20));
		AddSpawnPoint( "id_catacomb_38_2.Id4", "id_catacomb_38_2", Spot(-1312.1742, -477.2975, 20));
		AddSpawnPoint( "id_catacomb_38_2.Id4", "id_catacomb_38_2", Spot(-1226.0865, -464.1556, 20));
		AddSpawnPoint( "id_catacomb_38_2.Id4", "id_catacomb_38_2", Spot(-1379.0067, -480.7328, 20));
		AddSpawnPoint( "id_catacomb_38_2.Id4", "id_catacomb_38_2", Spot(-2370.4565, -314.3873, 20));
		AddSpawnPoint( "id_catacomb_38_2.Id4", "id_catacomb_38_2", Spot(-2467.9338, -689.7424, 20));
		AddSpawnPoint( "id_catacomb_38_2.Id4", "id_catacomb_38_2", Spot(-1834.992, -797.8966, 20));
		AddSpawnPoint( "id_catacomb_38_2.Id4", "id_catacomb_38_2", Spot(-549.46204, -1371.9012, 20));
		AddSpawnPoint( "id_catacomb_38_2.Id4", "id_catacomb_38_2", Spot(-472.4284, -1502.9434, 20));
		AddSpawnPoint( "id_catacomb_38_2.Id4", "id_catacomb_38_2", Spot(-330.70157, -1326.0488, 20));
		AddSpawnPoint( "id_catacomb_38_2.Id4", "id_catacomb_38_2", Spot(62.798283, -1339.7988, 20));
		AddSpawnPoint( "id_catacomb_38_2.Id4", "id_catacomb_38_2", Spot(1621.3169, -94.56652, 20));
		AddSpawnPoint( "id_catacomb_38_2.Id4", "id_catacomb_38_2", Spot(1831.4241, 484.23706, 20));
		AddSpawnPoint( "id_catacomb_38_2.Id4", "id_catacomb_38_2", Spot(1944.4004, 494.93292, 20));
		AddSpawnPoint( "id_catacomb_38_2.Id4", "id_catacomb_38_2", Spot(2154.1975, 505.22043, 20));
		AddSpawnPoint( "id_catacomb_38_2.Id4", "id_catacomb_38_2", Spot(2419.708, 405.08487, 20));
		AddSpawnPoint( "id_catacomb_38_2.Id4", "id_catacomb_38_2", Spot(962.54895, -539.1046, 20));
		AddSpawnPoint( "id_catacomb_38_2.Id4", "id_catacomb_38_2", Spot(944.7414, -483.02875, 20));
		AddSpawnPoint( "id_catacomb_38_2.Id4", "id_catacomb_38_2", Spot(178.85268, -411.3343, 20));
		AddSpawnPoint( "id_catacomb_38_2.Id4", "id_catacomb_38_2", Spot(-251.59735, -411.6587, 20));
		AddSpawnPoint( "id_catacomb_38_2.Id4", "id_catacomb_38_2", Spot(-249.73967, -878.41656, 20));

	}
}
