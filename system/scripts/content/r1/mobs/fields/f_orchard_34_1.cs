//--- Melia Script -----------------------------------------------------------
// f_orchard_34_1
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Alemeth Forest' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FOrchard341MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("f_orchard_34_1.Id1", MonsterId.Eldigo_Green, 45, 60, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_orchard_34_1.Id2", MonsterId.Eldigo_Green, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_orchard_34_1.Id3", MonsterId.Truffle_Red, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_orchard_34_1.Id4", MonsterId.Corpse_Flower_Green, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_orchard_34_1.Id5", MonsterId.Rootcrystal_01, 9, 12, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Eldigo_Green' GenType 8 Spawn Points
		AddSpawnPoint("f_orchard_34_1.Id1", "f_orchard_34_1", Rectangle(-133.98895, -699.7984, 9999));

		// 'Eldigo_Green' GenType 9 Spawn Points
		AddSpawnPoint("f_orchard_34_1.Id2", "f_orchard_34_1", Rectangle(167.1511, -1347.3872, 30));
		AddSpawnPoint("f_orchard_34_1.Id2", "f_orchard_34_1", Rectangle(266.3452, -1239.6967, 30));
		AddSpawnPoint("f_orchard_34_1.Id2", "f_orchard_34_1", Rectangle(84.50171, -1281.2404, 30));
		AddSpawnPoint("f_orchard_34_1.Id2", "f_orchard_34_1", Rectangle(376.74835, -1140.6145, 30));
		AddSpawnPoint("f_orchard_34_1.Id2", "f_orchard_34_1", Rectangle(552.902, -972.91003, 30));
		AddSpawnPoint("f_orchard_34_1.Id2", "f_orchard_34_1", Rectangle(824.7409, -885.83466, 30));
		AddSpawnPoint("f_orchard_34_1.Id2", "f_orchard_34_1", Rectangle(732.05286, -983.47705, 30));
		AddSpawnPoint("f_orchard_34_1.Id2", "f_orchard_34_1", Rectangle(680.7895, -844.73315, 30));
		AddSpawnPoint("f_orchard_34_1.Id2", "f_orchard_34_1", Rectangle(-1376.5635, -1530.4257, 30));
		AddSpawnPoint("f_orchard_34_1.Id2", "f_orchard_34_1", Rectangle(-1312.7544, -1385.1052, 30));
		AddSpawnPoint("f_orchard_34_1.Id2", "f_orchard_34_1", Rectangle(-1378.1869, -1132.7216, 30));
		AddSpawnPoint("f_orchard_34_1.Id2", "f_orchard_34_1", Rectangle(-1164.3641, -1530.4648, 30));
		AddSpawnPoint("f_orchard_34_1.Id2", "f_orchard_34_1", Rectangle(-1066.9584, -1342.4598, 30));
		AddSpawnPoint("f_orchard_34_1.Id2", "f_orchard_34_1", Rectangle(-1262.0215, -1604.3618, 30));
		AddSpawnPoint("f_orchard_34_1.Id2", "f_orchard_34_1", Rectangle(-1189.5505, -1321.5652, 30));
		AddSpawnPoint("f_orchard_34_1.Id2", "f_orchard_34_1", Rectangle(-319.3915, -1025.4254, 30));
		AddSpawnPoint("f_orchard_34_1.Id2", "f_orchard_34_1", Rectangle(-256.1246, -1185.5132, 30));
		AddSpawnPoint("f_orchard_34_1.Id2", "f_orchard_34_1", Rectangle(-1487.6012, -1263.8116, 30));

		// 'Truffle_Red' GenType 10 Spawn Points
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-1510.1844, 358.28564, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-1446.59, 474.96545, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-1187.8718, 220.12549, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-909.56256, 346.83447, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-656.9434, 587.67413, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-1179.8386, 1003.3104, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-1224.1995, 821.90814, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-1072.0853, 850.6206, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-720.9249, 658.2001, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-541.55, 800.6361, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-271.2696, 1296.0889, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-430.29395, 1387.4677, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-223.6778, 321.01117, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-374.6387, 370.2892, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-424.46, 502.39047, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-231.1935, 474.82782, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-1253.893, -56.462296, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-1055.202, 82.06411, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-1550.115, 482.9727, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-1391.6514, 323.31012, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-1496.8134, -662.6179, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-1360.1409, -435.31833, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-1413.5096, -608.99786, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-1247.0483, -587.17896, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-1314.449, -329.34442, 30));

		// 'Corpse_Flower_Green' GenType 11 Spawn Points
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-1236.7545, -1650.6248, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-1458.7163, -1398.9626, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-994.87494, -1176.478, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-1118.782, -1610.32, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-1228.4347, -1263.3025, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-1393.2688, -961.22577, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-1414.4065, -519.218, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-1298.6118, -415.53387, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-1300.9294, -197.20102, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-1233.7876, -185.9319, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-933.55554, 327.33328, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-831.29425, 484.81415, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-718.4379, 392.49197, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(226.07043, -144.95155, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(712.84796, 297.6577, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(372.83072, -254.39725, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(552.54846, 33.24813, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(459.55978, 70.81754, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(572.48553, 250.54634, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(681.13275, 20.866386, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(411.10706, -166.24063, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(785.2664, 419.0099, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(175.12901, -223.42267, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(255.62805, -429.7197, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-8.64246, -516.8602, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(47.78625, -669.626, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-340.2379, -912.26636, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-182.81113, -992.7444, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-334.07855, -1142.7023, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-862.3939, -1725.7767, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-1370.8983, -1556.763, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-194.74411, -1289.4426, 30));

		// 'Rootcrystal_01' GenType 12 Spawn Points
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(892.4873, -898.758, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(639.83716, -965.51526, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(358.32675, -1299.1729, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(166.4323, -1419.228, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-184.83191, -1246.2924, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-237.78403, -992.7417, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-23.729868, -714.1313, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(267.99063, -243.49155, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(353.44904, -10.497005, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(709.8595, 150.27014, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(795.58594, 315.83698, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(185.59076, 264.2452, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-639.5355, -1473.2628, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-373.2318, 419.35324, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-959.4625, -1688.9441, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-755.96094, -1318.9613, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-1281.5039, -1558.0807, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-1386.7269, -1284.3839, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-1366.9073, -669.6035, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-1370.1278, -485.77148, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-1256.9801, -125.27935, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-1121.8712, 196.88632, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-774.0204, 513.21094, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-643.1598, 693.25635, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-291.0571, 1075.7535, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-386.66327, 1237.4333, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-1512.2943, 288.70758, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-1382.1974, 421.44604, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-1211.82, 879.3068, 100));
	}
}
