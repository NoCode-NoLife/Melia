//--- Melia Script -----------------------------------------------------------
// f_pilgrimroad_51
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Forest of Prayer' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FPilgrimroad51MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_pilgrimroad_51", MonsterId.Prisonfighter, Properties("MHP", 134471, "MINPATK", 2230, "MAXPATK", 2643, "MINMATK", 2230, "MAXMATK", 2643, "DEF", 2538, "MDEF", 2538));
		AddPropertyOverrides("f_pilgrimroad_51", MonsterId.Kowak, Properties("MHP", 135786, "MINPATK", 2247, "MAXPATK", 2664, "MINMATK", 2247, "MAXMATK", 2664, "DEF", 2614, "MDEF", 2614));
		AddPropertyOverrides("f_pilgrimroad_51", MonsterId.Stoulet_Bow, Properties("MHP", 137156, "MINPATK", 2265, "MAXPATK", 2685, "MINMATK", 2265, "MAXMATK", 2685, "DEF", 2693, "MDEF", 2693));

		// Monster Spawners ---------------------------------

		AddSpawner("f_pilgrimroad_51.Id1", MonsterId.Prisonfighter, 15, 20, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_51.Id2", MonsterId.Kowak, 19, 25, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_51.Id3", MonsterId.Prisonfighter, 9, 12, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_51.Id4", MonsterId.Kowak, 8, 10, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_51.Id5", MonsterId.Rootcrystal_01, 11, 14, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_51.Id6", MonsterId.Stoulet_Bow, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_51.Id7", MonsterId.Stoulet_Bow, 6, 7, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_51.Id8", MonsterId.Stoulet_Bow, 4, 5, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_51.Id9", MonsterId.Kowak, 5, 6, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_51.Id10", MonsterId.Prisonfighter, 5, 6, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Prisonfighter' GenType 5 Spawn Points
		AddSpawnPoint("f_pilgrimroad_51.Id1", "f_pilgrimroad_51", Rectangle(-139.57848, 334.8774, 9999));

		// 'Kowak' GenType 6 Spawn Points
		AddSpawnPoint("f_pilgrimroad_51.Id2", "f_pilgrimroad_51", Rectangle(-765.21, 182.5, 9999));

		// 'Prisonfighter' GenType 8 Spawn Points
		AddSpawnPoint("f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Rectangle(-96.76, 210.84, 35));
		AddSpawnPoint("f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Rectangle(-787.7637, -309.54437, 35));
		AddSpawnPoint("f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Rectangle(-1227.9285, 134.15768, 35));
		AddSpawnPoint("f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Rectangle(-661.19714, 340.90366, 35));
		AddSpawnPoint("f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Rectangle(-937.3701, 116.07684, 35));
		AddSpawnPoint("f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Rectangle(-653.97577, 60.123657, 35));
		AddSpawnPoint("f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Rectangle(-350.95932, -429.02057, 35));
		AddSpawnPoint("f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Rectangle(-104.81825, 513.729, 35));
		AddSpawnPoint("f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Rectangle(38.102608, -93.891174, 35));
		AddSpawnPoint("f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Rectangle(-284.03537, 265.56714, 35));
		AddSpawnPoint("f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Rectangle(-170.04771, -196.208, 35));
		AddSpawnPoint("f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Rectangle(-618.0145, -551.0614, 35));
		AddSpawnPoint("f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Rectangle(-473.53586, -230.18149, 35));
		AddSpawnPoint("f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Rectangle(-268.2915, 529.8559, 35));

		// 'Kowak' GenType 9 Spawn Points
		AddSpawnPoint("f_pilgrimroad_51.Id4", "f_pilgrimroad_51", Rectangle(-1159.9204, -1838.6707, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id4", "f_pilgrimroad_51", Rectangle(-1349.7064, -1516.1234, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id4", "f_pilgrimroad_51", Rectangle(-1309.2599, -1931.4042, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id4", "f_pilgrimroad_51", Rectangle(-985.7542, -1798.7183, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id4", "f_pilgrimroad_51", Rectangle(-911.37585, -2007.8342, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id4", "f_pilgrimroad_51", Rectangle(-790.41376, -1842.3811, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id4", "f_pilgrimroad_51", Rectangle(-1157.8186, -1687.274, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id4", "f_pilgrimroad_51", Rectangle(-1371.2572, -1256.3945, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id4", "f_pilgrimroad_51", Rectangle(-1424.3411, -1706.326, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id4", "f_pilgrimroad_51", Rectangle(-1271.8881, -1032.4052, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id4", "f_pilgrimroad_51", Rectangle(-1497.2323, -1407.3293, 30));

		// 'Rootcrystal_01' GenType 24 Spawn Points
		AddSpawnPoint("f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Rectangle(-1444.94, -1440.59, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Rectangle(-116.61179, -1352.2183, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Rectangle(-803.5, -709.5, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Rectangle(-57.95, -211.89, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Rectangle(-1223.27, 128.43, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Rectangle(-1373.74, 1131.53, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Rectangle(-70.76, 566.26, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Rectangle(1035.49, 836.06, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Rectangle(1180.14, -10.11, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Rectangle(1673.21, -1067.58, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Rectangle(1957.62, -1649.37, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Rectangle(1557.45, 1210.28, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Rectangle(1274.06, 1994.08, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Rectangle(742.63, 1896.75, 30));

		// 'Stoulet_Bow' GenType 42 Spawn Points
		AddSpawnPoint("f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Rectangle(-1087.4353, -942.3745, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Rectangle(-733.7447, -860.1214, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Rectangle(-1617.0231, 358.75955, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Rectangle(-1340.5253, 309.70547, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Rectangle(-583.7911, -655.5847, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Rectangle(-534.41876, -47.383545, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Rectangle(-931.4337, -105.26987, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Rectangle(54.0767, -166.55577, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Rectangle(58.830544, 309.3152, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Rectangle(-11.74791, -1517.9341, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Rectangle(-1123.6069, -1693.9347, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Rectangle(-801.07715, -1730.7062, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Rectangle(-369.88364, -1567.3871, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Rectangle(4.234955, -1190.1465, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Rectangle(-328.2619, 478.64285, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Rectangle(-259.68637, 5.9961357, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Rectangle(-217.233, -499.6123, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Rectangle(-747.9317, 414.26248, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Rectangle(-725.00165, -1337.3387, 25));

		// 'Stoulet_Bow' GenType 50 Spawn Points
		AddSpawnPoint("f_pilgrimroad_51.Id7", "f_pilgrimroad_51", Rectangle(1679.4158, -1135.9667, 20));
		AddSpawnPoint("f_pilgrimroad_51.Id7", "f_pilgrimroad_51", Rectangle(1688.3218, -890.82495, 20));
		AddSpawnPoint("f_pilgrimroad_51.Id7", "f_pilgrimroad_51", Rectangle(1593.0757, -418.31412, 20));
		AddSpawnPoint("f_pilgrimroad_51.Id7", "f_pilgrimroad_51", Rectangle(1636.0865, -38.128563, 20));
		AddSpawnPoint("f_pilgrimroad_51.Id7", "f_pilgrimroad_51", Rectangle(1797.8583, -231.5441, 20));
		AddSpawnPoint("f_pilgrimroad_51.Id7", "f_pilgrimroad_51", Rectangle(1306.2927, -189.30807, 20));
		AddSpawnPoint("f_pilgrimroad_51.Id7", "f_pilgrimroad_51", Rectangle(1318.8568, 232.3281, 20));
		AddSpawnPoint("f_pilgrimroad_51.Id7", "f_pilgrimroad_51", Rectangle(1397.8153, 657.2178, 20));
		AddSpawnPoint("f_pilgrimroad_51.Id7", "f_pilgrimroad_51", Rectangle(1004.4618, 919.04694, 20));
		AddSpawnPoint("f_pilgrimroad_51.Id7", "f_pilgrimroad_51", Rectangle(1205.9818, 652.4649, 20));
		AddSpawnPoint("f_pilgrimroad_51.Id7", "f_pilgrimroad_51", Rectangle(1138.4135, -64.428604, 20));

		// 'Stoulet_Bow' GenType 51 Spawn Points
		AddSpawnPoint("f_pilgrimroad_51.Id8", "f_pilgrimroad_51", Rectangle(1742.2028, -1590.1146, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id8", "f_pilgrimroad_51", Rectangle(1679.594, -1745.5631, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id8", "f_pilgrimroad_51", Rectangle(1598.6583, -1637.4476, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id8", "f_pilgrimroad_51", Rectangle(1861.7771, -1606.7319, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id8", "f_pilgrimroad_51", Rectangle(1894.2802, -1748.1648, 25));

		// 'Kowak' GenType 58 Spawn Points
		AddSpawnPoint("f_pilgrimroad_51.Id9", "f_pilgrimroad_51", Rectangle(-123.01879, -1225.6494, 40));
		AddSpawnPoint("f_pilgrimroad_51.Id9", "f_pilgrimroad_51", Rectangle(-187.53903, -1292.9614, 40));
		AddSpawnPoint("f_pilgrimroad_51.Id9", "f_pilgrimroad_51", Rectangle(-173.01878, -1405.0359, 40));
		AddSpawnPoint("f_pilgrimroad_51.Id9", "f_pilgrimroad_51", Rectangle(-44.129616, -1278.3125, 40));
		AddSpawnPoint("f_pilgrimroad_51.Id9", "f_pilgrimroad_51", Rectangle(-24.168692, -1367.3712, 40));
		AddSpawnPoint("f_pilgrimroad_51.Id9", "f_pilgrimroad_51", Rectangle(-85.62773, -1420.6626, 40));

		// 'Prisonfighter' GenType 59 Spawn Points
		AddSpawnPoint("f_pilgrimroad_51.Id10", "f_pilgrimroad_51", Rectangle(-179.11942, -1232.3048, 40));
		AddSpawnPoint("f_pilgrimroad_51.Id10", "f_pilgrimroad_51", Rectangle(-202.01407, -1349.3105, 40));
		AddSpawnPoint("f_pilgrimroad_51.Id10", "f_pilgrimroad_51", Rectangle(-111.67949, -1297.8619, 40));
		AddSpawnPoint("f_pilgrimroad_51.Id10", "f_pilgrimroad_51", Rectangle(-78.22135, -1342.7521, 40));
		AddSpawnPoint("f_pilgrimroad_51.Id10", "f_pilgrimroad_51", Rectangle(-126.47256, -1397.1327, 40));
		AddSpawnPoint("f_pilgrimroad_51.Id10", "f_pilgrimroad_51", Rectangle(-143.72667, -1461.3499, 40));
	}
}
