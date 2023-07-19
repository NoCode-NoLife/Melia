//--- Melia Script -----------------------------------------------------------
// f_flash_29_1
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Coastal Fortress' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FFlash291MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("f_flash_29_1.Id1", MonsterId.Rootcrystal_03, 15, 20, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_flash_29_1.Id2", MonsterId.Minos_Orange, 57, 75, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_29_1.Id3", MonsterId.Infroholder_Bow_Red, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_29_1.Id4", MonsterId.Minos_Mage_Green, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_03' GenType 3 Spawn Points
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(-1719.2058, -170.94014, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(-1435.9038, -356.3271, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(-1075.9147, -587.4148, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(-950.0256, -932.4839, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(-469.69064, -796.78174, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(-230.75697, -627.0405, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(-203.67694, -329.99814, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(-494.41574, -325.31866, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(-766.26434, -339.60394, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(178.49573, -709.1252, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(89.13603, -69.27498, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(133.43176, 245.91408, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(6.293297, 569.2041, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(1.6074448, 844.8618, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(61.577057, 1145.9548, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(568.9569, 173.15794, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(850.1738, -44.463512, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(816.87585, 362.71384, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(1212.4498, 348.5777, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(1331.5812, 560.75726, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(1596.0277, 423.53964, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(1235.1333, -34.8278, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(1147.0552, -503.9661, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(-457.60532, 157.38031, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(-737.49774, 99.842766, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(-1000.9803, 75.769875, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(-1178.1848, 302.19205, 10));
		AddSpawnPoint("f_flash_29_1.Id1", "f_flash_29_1", Rectangle(-1442.2615, 346.967, 10));

		// 'Minos_Orange' GenType 28 Spawn Points
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-1165.2585, -537.7939, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-1035.0239, -739.191, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-983.63995, -548.06934, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(1135.6487, 82.84541, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-908.71674, -640.5338, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(188.53053, 273.36603, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(20.255608, 358.68802, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-811.33746, -769.0712, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-70.007996, -132.28685, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-128.9977, -253.313, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(131.03839, -593.07935, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(116.54505, 146.88565, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(228.08862, 159.40082, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(230.72655, -639.78845, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(583.9337, 171.92487, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(744.96826, 125.808, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(938.7328, 26.475456, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(1137.4642, -62.83493, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(1319.9071, 140.85966, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(1406.6593, 55.590565, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(1094.0063, -488.203, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(952.65234, -504.90997, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(1080.4187, -292.8004, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(1070.0414, 393.40295, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(1309.246, 400.95407, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(779.87683, 360.35806, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(28.747992, 732.4143, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(34.281776, 524.85254, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-634.8257, 90.44767, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-1044.0237, 98.36771, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-1317.0219, 275.36884, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-1213.6653, 199.78079, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-868.1033, 131.251, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(853.92163, -83.3488, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-1083.218, -571.07166, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-1076.0201, -656.86865, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-1007.5989, -614.68665, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-53.736343, 961.26733, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(45.549107, 998.4474, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-936.43054, -798.2284, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(1426.4176, 467.81006, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-904.08356, -915.3063, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(33.761803, 812.9631, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(1378.7515, 546.1576, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-774.13086, -850.9512, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(839.2567, 66.31446, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-734.8743, -666.8937, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-622.3576, -693.28564, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-715.5444, -776.90295, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-627.4894, -860.53436, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-46.63774, 238.09169, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-578.39154, -739.6284, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-997.65515, -690.63635, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-530.8145, -847.08734, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(29.179419, -466.81287, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-479.8024, -678.30695, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-204.89151, -313.06583, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-120.16345, -337.87598, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-50.36224, -416.3277, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(868.47876, 179.92308, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(1023.5836, -17.722916, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-55.40509, -547.541, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(118.60263, -674.55615, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(168.77164, -736.7437, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(286.6506, -746.7438, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(358.9163, -776.99164, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(166.2467, -840.46924, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-2.8788195, -90.40437, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-151.6193, 141.89746, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(-53.574364, 67.02826, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(25.86187, 56.36847, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(26.196337, 645.1441, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(67.16676, -119.11368, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(179.40254, 37.740635, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(274.79248, 82.52945, 20));
		AddSpawnPoint("f_flash_29_1.Id2", "f_flash_29_1", Rectangle(181.74051, -87.47513, 20));

		// 'Infroholder_Bow_Red' GenType 29 Spawn Points
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(-1248.4374, 364.69574, 20));
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(-761.1614, 112.73956, 20));
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(-810.32513, 12.708405, 20));
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(-948.12964, -416.65833, 20));
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(-1277.1564, -464.857, 20));
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(-887.62634, -731.6586, 20));
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(900.9853, -160.19818, 20));
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(-180.31595, -348.5357, 20));
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(907.64417, 322.3815, 20));
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(1108.6547, 348.574, 20));
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(1330.1812, 559.3724, 20));
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(1248.7417, 347.378, 20));
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(1137.0743, 66.92579, 20));
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(1235.2711, -138.35649, 20));
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(1168.9012, -449.50613, 20));
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(1055.7107, -527.61017, 20));
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(976.6171, -407.2671, 20));
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(28.60678, 885.19586, 20));
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(68.30527, 581.0553, 20));
		AddSpawnPoint("f_flash_29_1.Id3", "f_flash_29_1", Rectangle(14.528622, 1011.1436, 20));

		// 'Minos_Mage_Green' GenType 30 Spawn Points
		AddSpawnPoint("f_flash_29_1.Id4", "f_flash_29_1", Rectangle(-670.44464, 181.83614, 20));
		AddSpawnPoint("f_flash_29_1.Id4", "f_flash_29_1", Rectangle(-946.17816, 73.69266, 20));
		AddSpawnPoint("f_flash_29_1.Id4", "f_flash_29_1", Rectangle(-1257.6046, 278.2685, 20));
		AddSpawnPoint("f_flash_29_1.Id4", "f_flash_29_1", Rectangle(-1082.1934, -446.8348, 20));
		AddSpawnPoint("f_flash_29_1.Id4", "f_flash_29_1", Rectangle(42.13014, -544.02997, 20));
		AddSpawnPoint("f_flash_29_1.Id4", "f_flash_29_1", Rectangle(110.23565, -777.20416, 20));
		AddSpawnPoint("f_flash_29_1.Id4", "f_flash_29_1", Rectangle(861.6648, 71.28769, 20));
		AddSpawnPoint("f_flash_29_1.Id4", "f_flash_29_1", Rectangle(1050.1927, -312.37958, 20));
		AddSpawnPoint("f_flash_29_1.Id4", "f_flash_29_1", Rectangle(1142.72, -503.0219, 20));
		AddSpawnPoint("f_flash_29_1.Id4", "f_flash_29_1", Rectangle(1238.3861, 52.886623, 20));
		AddSpawnPoint("f_flash_29_1.Id4", "f_flash_29_1", Rectangle(1570.5817, 430.46915, 20));
		AddSpawnPoint("f_flash_29_1.Id4", "f_flash_29_1", Rectangle(944.22504, 349.53992, 20));
		AddSpawnPoint("f_flash_29_1.Id4", "f_flash_29_1", Rectangle(67.027756, 593.473, 20));
		AddSpawnPoint("f_flash_29_1.Id4", "f_flash_29_1", Rectangle(-46.74527, 933.3694, 20));
		AddSpawnPoint("f_flash_29_1.Id4", "f_flash_29_1", Rectangle(176.94724, 909.95233, 20));
		AddSpawnPoint("f_flash_29_1.Id4", "f_flash_29_1", Rectangle(30.651478, 734.97345, 20));
	}
}
