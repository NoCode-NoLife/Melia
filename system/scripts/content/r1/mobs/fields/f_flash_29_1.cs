//--- Melia Script -----------------------------------------------------------
// f_flash_29_1
//
//--- Description -----------------------------------------------------------
// Sets up the f_flash_29_1 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FFlash291MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("f_flash_29_1.Id1", MonsterId.Rootcrystal_03, 20, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_flash_29_1.Id2", MonsterId.Minos_Orange, 75, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_29_1.Id3", MonsterId.Infroholder_Bow_Red, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_29_1.Id4", MonsterId.Minos_Mage_Green, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Rootcrystal_03 Spawn Points
		AddSpawnPoint( "f_flash_29_1.Id1", "f_flash_29_1", Spot(-1719.2058, -170.94014, 10));
		AddSpawnPoint( "f_flash_29_1.Id1", "f_flash_29_1", Spot(-1435.9038, -356.3271, 10));
		AddSpawnPoint( "f_flash_29_1.Id1", "f_flash_29_1", Spot(-1075.9147, -587.4148, 10));
		AddSpawnPoint( "f_flash_29_1.Id1", "f_flash_29_1", Spot(-950.0256, -932.4839, 10));
		AddSpawnPoint( "f_flash_29_1.Id1", "f_flash_29_1", Spot(-469.69064, -796.78174, 10));
		AddSpawnPoint( "f_flash_29_1.Id1", "f_flash_29_1", Spot(-230.75697, -627.0405, 10));
		AddSpawnPoint( "f_flash_29_1.Id1", "f_flash_29_1", Spot(-203.67694, -329.99814, 10));
		AddSpawnPoint( "f_flash_29_1.Id1", "f_flash_29_1", Spot(-494.41574, -325.31866, 10));
		AddSpawnPoint( "f_flash_29_1.Id1", "f_flash_29_1", Spot(-766.26434, -339.60394, 10));
		AddSpawnPoint( "f_flash_29_1.Id1", "f_flash_29_1", Spot(178.49573, -709.1252, 10));
		AddSpawnPoint( "f_flash_29_1.Id1", "f_flash_29_1", Spot(89.13603, -69.27498, 10));
		AddSpawnPoint( "f_flash_29_1.Id1", "f_flash_29_1", Spot(133.43176, 245.91408, 10));
		AddSpawnPoint( "f_flash_29_1.Id1", "f_flash_29_1", Spot(6.293297, 569.2041, 10));
		AddSpawnPoint( "f_flash_29_1.Id1", "f_flash_29_1", Spot(1.6074448, 844.8618, 10));
		AddSpawnPoint( "f_flash_29_1.Id1", "f_flash_29_1", Spot(61.577057, 1145.9548, 10));
		AddSpawnPoint( "f_flash_29_1.Id1", "f_flash_29_1", Spot(568.9569, 173.15794, 10));
		AddSpawnPoint( "f_flash_29_1.Id1", "f_flash_29_1", Spot(850.1738, -44.463512, 10));
		AddSpawnPoint( "f_flash_29_1.Id1", "f_flash_29_1", Spot(816.87585, 362.71384, 10));
		AddSpawnPoint( "f_flash_29_1.Id1", "f_flash_29_1", Spot(1212.4498, 348.5777, 10));
		AddSpawnPoint( "f_flash_29_1.Id1", "f_flash_29_1", Spot(1331.5812, 560.75726, 10));
		AddSpawnPoint( "f_flash_29_1.Id1", "f_flash_29_1", Spot(1596.0277, 423.53964, 10));
		AddSpawnPoint( "f_flash_29_1.Id1", "f_flash_29_1", Spot(1235.1333, -34.8278, 10));
		AddSpawnPoint( "f_flash_29_1.Id1", "f_flash_29_1", Spot(1147.0552, -503.9661, 10));
		AddSpawnPoint( "f_flash_29_1.Id1", "f_flash_29_1", Spot(-457.60532, 157.38031, 10));
		AddSpawnPoint( "f_flash_29_1.Id1", "f_flash_29_1", Spot(-737.49774, 99.842766, 10));
		AddSpawnPoint( "f_flash_29_1.Id1", "f_flash_29_1", Spot(-1000.9803, 75.769875, 10));
		AddSpawnPoint( "f_flash_29_1.Id1", "f_flash_29_1", Spot(-1178.1848, 302.19205, 10));
		AddSpawnPoint( "f_flash_29_1.Id1", "f_flash_29_1", Spot(-1442.2615, 346.967, 10));

		// Minos_Orange Spawn Points
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(-1165.2585, -537.7939, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(-1035.0239, -739.191, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(-983.63995, -548.06934, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(1135.6487, 82.84541, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(-908.71674, -640.5338, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(188.53053, 273.36603, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(20.255608, 358.68802, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(-811.33746, -769.0712, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(-70.007996, -132.28685, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(-128.9977, -253.313, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(131.03839, -593.07935, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(116.54505, 146.88565, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(228.08862, 159.40082, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(230.72655, -639.78845, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(583.9337, 171.92487, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(744.96826, 125.808, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(938.7328, 26.475456, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(1137.4642, -62.83493, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(1319.9071, 140.85966, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(1406.6593, 55.590565, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(1094.0063, -488.203, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(952.65234, -504.90997, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(1080.4187, -292.8004, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(1070.0414, 393.40295, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(1309.246, 400.95407, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(779.87683, 360.35806, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(28.747992, 732.4143, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(34.281776, 524.85254, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(-634.8257, 90.44767, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(-1044.0237, 98.36771, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(-1317.0219, 275.36884, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(-1213.6653, 199.78079, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(-868.1033, 131.251, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(853.92163, -83.3488, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(-1083.218, -571.07166, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(-1076.0201, -656.86865, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(-1007.5989, -614.68665, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(-53.736343, 961.26733, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(45.549107, 998.4474, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(-936.43054, -798.2284, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(1426.4176, 467.81006, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(-904.08356, -915.3063, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(33.761803, 812.9631, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(1378.7515, 546.1576, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(-774.13086, -850.9512, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(839.2567, 66.31446, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(-734.8743, -666.8937, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(-622.3576, -693.28564, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(-715.5444, -776.90295, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(-627.4894, -860.53436, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(-46.63774, 238.09169, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(-578.39154, -739.6284, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(-997.65515, -690.63635, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(-530.8145, -847.08734, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(29.179419, -466.81287, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(-479.8024, -678.30695, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(-204.89151, -313.06583, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(-120.16345, -337.87598, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(-50.36224, -416.3277, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(868.47876, 179.92308, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(1023.5836, -17.722916, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(-55.40509, -547.541, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(118.60263, -674.55615, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(168.77164, -736.7437, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(286.6506, -746.7438, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(358.9163, -776.99164, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(166.2467, -840.46924, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(-2.8788195, -90.40437, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(-151.6193, 141.89746, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(-53.574364, 67.02826, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(25.86187, 56.36847, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(26.196337, 645.1441, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(67.16676, -119.11368, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(179.40254, 37.740635, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(274.79248, 82.52945, 20));
		AddSpawnPoint( "f_flash_29_1.Id2", "f_flash_29_1", Spot(181.74051, -87.47513, 20));

		// Infroholder_Bow_Red Spawn Points
		AddSpawnPoint( "f_flash_29_1.Id3", "f_flash_29_1", Spot(-1248.4374, 364.69574, 20));
		AddSpawnPoint( "f_flash_29_1.Id3", "f_flash_29_1", Spot(-761.1614, 112.73956, 20));
		AddSpawnPoint( "f_flash_29_1.Id3", "f_flash_29_1", Spot(-810.32513, 12.708405, 20));
		AddSpawnPoint( "f_flash_29_1.Id3", "f_flash_29_1", Spot(-948.12964, -416.65833, 20));
		AddSpawnPoint( "f_flash_29_1.Id3", "f_flash_29_1", Spot(-1277.1564, -464.857, 20));
		AddSpawnPoint( "f_flash_29_1.Id3", "f_flash_29_1", Spot(-887.62634, -731.6586, 20));
		AddSpawnPoint( "f_flash_29_1.Id3", "f_flash_29_1", Spot(900.9853, -160.19818, 20));
		AddSpawnPoint( "f_flash_29_1.Id3", "f_flash_29_1", Spot(-180.31595, -348.5357, 20));
		AddSpawnPoint( "f_flash_29_1.Id3", "f_flash_29_1", Spot(907.64417, 322.3815, 20));
		AddSpawnPoint( "f_flash_29_1.Id3", "f_flash_29_1", Spot(1108.6547, 348.574, 20));
		AddSpawnPoint( "f_flash_29_1.Id3", "f_flash_29_1", Spot(1330.1812, 559.3724, 20));
		AddSpawnPoint( "f_flash_29_1.Id3", "f_flash_29_1", Spot(1248.7417, 347.378, 20));
		AddSpawnPoint( "f_flash_29_1.Id3", "f_flash_29_1", Spot(1137.0743, 66.92579, 20));
		AddSpawnPoint( "f_flash_29_1.Id3", "f_flash_29_1", Spot(1235.2711, -138.35649, 20));
		AddSpawnPoint( "f_flash_29_1.Id3", "f_flash_29_1", Spot(1168.9012, -449.50613, 20));
		AddSpawnPoint( "f_flash_29_1.Id3", "f_flash_29_1", Spot(1055.7107, -527.61017, 20));
		AddSpawnPoint( "f_flash_29_1.Id3", "f_flash_29_1", Spot(976.6171, -407.2671, 20));
		AddSpawnPoint( "f_flash_29_1.Id3", "f_flash_29_1", Spot(28.60678, 885.19586, 20));
		AddSpawnPoint( "f_flash_29_1.Id3", "f_flash_29_1", Spot(68.30527, 581.0553, 20));
		AddSpawnPoint( "f_flash_29_1.Id3", "f_flash_29_1", Spot(14.528622, 1011.1436, 20));

		// Minos_Mage_Green Spawn Points
		AddSpawnPoint( "f_flash_29_1.Id4", "f_flash_29_1", Spot(-670.44464, 181.83614, 20));
		AddSpawnPoint( "f_flash_29_1.Id4", "f_flash_29_1", Spot(-946.17816, 73.69266, 20));
		AddSpawnPoint( "f_flash_29_1.Id4", "f_flash_29_1", Spot(-1257.6046, 278.2685, 20));
		AddSpawnPoint( "f_flash_29_1.Id4", "f_flash_29_1", Spot(-1082.1934, -446.8348, 20));
		AddSpawnPoint( "f_flash_29_1.Id4", "f_flash_29_1", Spot(42.13014, -544.02997, 20));
		AddSpawnPoint( "f_flash_29_1.Id4", "f_flash_29_1", Spot(110.23565, -777.20416, 20));
		AddSpawnPoint( "f_flash_29_1.Id4", "f_flash_29_1", Spot(861.6648, 71.28769, 20));
		AddSpawnPoint( "f_flash_29_1.Id4", "f_flash_29_1", Spot(1050.1927, -312.37958, 20));
		AddSpawnPoint( "f_flash_29_1.Id4", "f_flash_29_1", Spot(1142.72, -503.0219, 20));
		AddSpawnPoint( "f_flash_29_1.Id4", "f_flash_29_1", Spot(1238.3861, 52.886623, 20));
		AddSpawnPoint( "f_flash_29_1.Id4", "f_flash_29_1", Spot(1570.5817, 430.46915, 20));
		AddSpawnPoint( "f_flash_29_1.Id4", "f_flash_29_1", Spot(944.22504, 349.53992, 20));
		AddSpawnPoint( "f_flash_29_1.Id4", "f_flash_29_1", Spot(67.027756, 593.473, 20));
		AddSpawnPoint( "f_flash_29_1.Id4", "f_flash_29_1", Spot(-46.74527, 933.3694, 20));
		AddSpawnPoint( "f_flash_29_1.Id4", "f_flash_29_1", Spot(176.94724, 909.95233, 20));
		AddSpawnPoint( "f_flash_29_1.Id4", "f_flash_29_1", Spot(30.651478, 734.97345, 20));

	}
}
