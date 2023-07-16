//--- Melia Script -----------------------------------------------------------
// f_pilgrimroad_51
//
//--- Description -----------------------------------------------------------
// Sets up the f_pilgrimroad_51 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FPilgrimroad51MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_pilgrimroad_51", MonsterId.Prisonfighter, Properties("MHP", 134471, "MINPATK", 2230, "MAXPATK", 2643, "MINMATK", 2230, "MAXMATK", 2643, "DEF", 2538, "MDEF", 2538));
		AddPropertyOverrides("f_pilgrimroad_51", MonsterId.Kowak, Properties("MHP", 135786, "MINPATK", 2247, "MAXPATK", 2664, "MINMATK", 2247, "MAXMATK", 2664, "DEF", 2614, "MDEF", 2614));
		AddPropertyOverrides("f_pilgrimroad_51", MonsterId.Stoulet_Bow, Properties("MHP", 137156, "MINPATK", 2265, "MAXPATK", 2685, "MINMATK", 2265, "MAXMATK", 2685, "DEF", 2693, "MDEF", 2693));

		// Monster Spawners --------------------------------

		AddSpawner("f_pilgrimroad_51.Id1", MonsterId.Prisonfighter, 20, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_51.Id2", MonsterId.Kowak, 25, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_51.Id3", MonsterId.Prisonfighter, 12, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_51.Id4", MonsterId.Kowak, 10, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_51.Id5", MonsterId.Rootcrystal_01, 14, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_51.Id6", MonsterId.Stoulet_Bow, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_51.Id7", MonsterId.Stoulet_Bow, 5, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_51.Id8", MonsterId.Stoulet_Bow, 7, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_51.Id9", MonsterId.Kowak, 6, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_51.Id10", MonsterId.Prisonfighter, 6, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Prisonfighter Spawn Points
		AddSpawnPoint( "f_pilgrimroad_51.Id1", "f_pilgrimroad_51", Spot(-139.57848, 334.8774, 9999));

		// Kowak Spawn Points
		AddSpawnPoint( "f_pilgrimroad_51.Id2", "f_pilgrimroad_51", Spot(-765.21, 182.5, 9999));

		// Prisonfighter Spawn Points
		AddSpawnPoint( "f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Spot(-96.76, 210.84, 35));
		AddSpawnPoint( "f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Spot(-787.7637, -309.54437, 35));
		AddSpawnPoint( "f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Spot(-1227.9285, 134.15768, 35));
		AddSpawnPoint( "f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Spot(-661.19714, 340.90366, 35));
		AddSpawnPoint( "f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Spot(-937.3701, 116.07684, 35));
		AddSpawnPoint( "f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Spot(-653.97577, 60.123657, 35));
		AddSpawnPoint( "f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Spot(-350.95932, -429.02057, 35));
		AddSpawnPoint( "f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Spot(-104.81825, 513.729, 35));
		AddSpawnPoint( "f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Spot(38.102608, -93.891174, 35));
		AddSpawnPoint( "f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Spot(-284.03537, 265.56714, 35));
		AddSpawnPoint( "f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Spot(-170.04771, -196.208, 35));
		AddSpawnPoint( "f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Spot(-618.0145, -551.0614, 35));
		AddSpawnPoint( "f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Spot(-473.53586, -230.18149, 35));
		AddSpawnPoint( "f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Spot(-268.2915, 529.8559, 35));

		// Kowak Spawn Points
		AddSpawnPoint( "f_pilgrimroad_51.Id4", "f_pilgrimroad_51", Spot(-1159.9204, -1838.6707, 30));
		AddSpawnPoint( "f_pilgrimroad_51.Id4", "f_pilgrimroad_51", Spot(-1349.7064, -1516.1234, 30));
		AddSpawnPoint( "f_pilgrimroad_51.Id4", "f_pilgrimroad_51", Spot(-1309.2599, -1931.4042, 30));
		AddSpawnPoint( "f_pilgrimroad_51.Id4", "f_pilgrimroad_51", Spot(-985.7542, -1798.7183, 30));
		AddSpawnPoint( "f_pilgrimroad_51.Id4", "f_pilgrimroad_51", Spot(-911.37585, -2007.8342, 30));
		AddSpawnPoint( "f_pilgrimroad_51.Id4", "f_pilgrimroad_51", Spot(-790.41376, -1842.3811, 30));
		AddSpawnPoint( "f_pilgrimroad_51.Id4", "f_pilgrimroad_51", Spot(-1157.8186, -1687.274, 30));
		AddSpawnPoint( "f_pilgrimroad_51.Id4", "f_pilgrimroad_51", Spot(-1371.2572, -1256.3945, 30));
		AddSpawnPoint( "f_pilgrimroad_51.Id4", "f_pilgrimroad_51", Spot(-1424.3411, -1706.326, 30));
		AddSpawnPoint( "f_pilgrimroad_51.Id4", "f_pilgrimroad_51", Spot(-1271.8881, -1032.4052, 30));
		AddSpawnPoint( "f_pilgrimroad_51.Id4", "f_pilgrimroad_51", Spot(-1497.2323, -1407.3293, 30));

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Spot(-1444.94, -1440.59, 30));
		AddSpawnPoint( "f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Spot(-116.61179, -1352.2183, 30));
		AddSpawnPoint( "f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Spot(-803.5, -709.5, 30));
		AddSpawnPoint( "f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Spot(-57.95, -211.89, 30));
		AddSpawnPoint( "f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Spot(-1223.27, 128.43, 30));
		AddSpawnPoint( "f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Spot(-1373.74, 1131.53, 30));
		AddSpawnPoint( "f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Spot(-70.76, 566.26, 30));
		AddSpawnPoint( "f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Spot(1035.49, 836.06, 30));
		AddSpawnPoint( "f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Spot(1180.14, -10.11, 30));
		AddSpawnPoint( "f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Spot(1673.21, -1067.58, 30));
		AddSpawnPoint( "f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Spot(1957.62, -1649.37, 30));
		AddSpawnPoint( "f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Spot(1557.45, 1210.28, 30));
		AddSpawnPoint( "f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Spot(1274.06, 1994.08, 30));
		AddSpawnPoint( "f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Spot(742.63, 1896.75, 30));

		// Stoulet_Bow Spawn Points
		AddSpawnPoint( "f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Spot(-1087.4353, -942.3745, 25));
		AddSpawnPoint( "f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Spot(-733.7447, -860.1214, 25));
		AddSpawnPoint( "f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Spot(-1617.0231, 358.75955, 25));
		AddSpawnPoint( "f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Spot(-1340.5253, 309.70547, 25));
		AddSpawnPoint( "f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Spot(-583.7911, -655.5847, 25));
		AddSpawnPoint( "f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Spot(-534.41876, -47.383545, 25));
		AddSpawnPoint( "f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Spot(-931.4337, -105.26987, 25));
		AddSpawnPoint( "f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Spot(54.0767, -166.55577, 25));
		AddSpawnPoint( "f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Spot(58.830544, 309.3152, 25));
		AddSpawnPoint( "f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Spot(-11.74791, -1517.9341, 25));
		AddSpawnPoint( "f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Spot(-1123.6069, -1693.9347, 25));
		AddSpawnPoint( "f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Spot(-801.07715, -1730.7062, 25));
		AddSpawnPoint( "f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Spot(-369.88364, -1567.3871, 25));
		AddSpawnPoint( "f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Spot(4.234955, -1190.1465, 25));
		AddSpawnPoint( "f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Spot(-328.2619, 478.64285, 25));
		AddSpawnPoint( "f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Spot(-259.68637, 5.9961357, 25));
		AddSpawnPoint( "f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Spot(-217.233, -499.6123, 25));
		AddSpawnPoint( "f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Spot(-747.9317, 414.26248, 25));
		AddSpawnPoint( "f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Spot(-725.00165, -1337.3387, 25));
		AddSpawnPoint( "f_pilgrimroad_51.Id7", "f_pilgrimroad_51", Spot(1742.2028, -1590.1146, 25));
		AddSpawnPoint( "f_pilgrimroad_51.Id7", "f_pilgrimroad_51", Spot(1679.594, -1745.5631, 25));
		AddSpawnPoint( "f_pilgrimroad_51.Id7", "f_pilgrimroad_51", Spot(1598.6583, -1637.4476, 25));
		AddSpawnPoint( "f_pilgrimroad_51.Id7", "f_pilgrimroad_51", Spot(1861.7771, -1606.7319, 25));
		AddSpawnPoint( "f_pilgrimroad_51.Id7", "f_pilgrimroad_51", Spot(1894.2802, -1748.1648, 25));
		AddSpawnPoint( "f_pilgrimroad_51.Id8", "f_pilgrimroad_51", Spot(1679.4158, -1135.9667, 20));
		AddSpawnPoint( "f_pilgrimroad_51.Id8", "f_pilgrimroad_51", Spot(1688.3218, -890.82495, 20));
		AddSpawnPoint( "f_pilgrimroad_51.Id8", "f_pilgrimroad_51", Spot(1593.0757, -418.31412, 20));
		AddSpawnPoint( "f_pilgrimroad_51.Id8", "f_pilgrimroad_51", Spot(1636.0865, -38.128563, 20));
		AddSpawnPoint( "f_pilgrimroad_51.Id8", "f_pilgrimroad_51", Spot(1797.8583, -231.5441, 20));
		AddSpawnPoint( "f_pilgrimroad_51.Id8", "f_pilgrimroad_51", Spot(1306.2927, -189.30807, 20));
		AddSpawnPoint( "f_pilgrimroad_51.Id8", "f_pilgrimroad_51", Spot(1318.8568, 232.3281, 20));
		AddSpawnPoint( "f_pilgrimroad_51.Id8", "f_pilgrimroad_51", Spot(1397.8153, 657.2178, 20));
		AddSpawnPoint( "f_pilgrimroad_51.Id8", "f_pilgrimroad_51", Spot(1004.4618, 919.04694, 20));
		AddSpawnPoint( "f_pilgrimroad_51.Id8", "f_pilgrimroad_51", Spot(1205.9818, 652.4649, 20));
		AddSpawnPoint( "f_pilgrimroad_51.Id8", "f_pilgrimroad_51", Spot(1138.4135, -64.428604, 20));

		// Kowak Spawn Points
		AddSpawnPoint( "f_pilgrimroad_51.Id9", "f_pilgrimroad_51", Spot(-123.01879, -1225.6494, 40));
		AddSpawnPoint( "f_pilgrimroad_51.Id9", "f_pilgrimroad_51", Spot(-187.53903, -1292.9614, 40));
		AddSpawnPoint( "f_pilgrimroad_51.Id9", "f_pilgrimroad_51", Spot(-173.01878, -1405.0359, 40));
		AddSpawnPoint( "f_pilgrimroad_51.Id9", "f_pilgrimroad_51", Spot(-44.129616, -1278.3125, 40));
		AddSpawnPoint( "f_pilgrimroad_51.Id9", "f_pilgrimroad_51", Spot(-24.168692, -1367.3712, 40));
		AddSpawnPoint( "f_pilgrimroad_51.Id9", "f_pilgrimroad_51", Spot(-85.62773, -1420.6626, 40));

		// Prisonfighter Spawn Points
		AddSpawnPoint( "f_pilgrimroad_51.Id10", "f_pilgrimroad_51", Spot(-179.11942, -1232.3048, 40));
		AddSpawnPoint( "f_pilgrimroad_51.Id10", "f_pilgrimroad_51", Spot(-202.01407, -1349.3105, 40));
		AddSpawnPoint( "f_pilgrimroad_51.Id10", "f_pilgrimroad_51", Spot(-111.67949, -1297.8619, 40));
		AddSpawnPoint( "f_pilgrimroad_51.Id10", "f_pilgrimroad_51", Spot(-78.22135, -1342.7521, 40));
		AddSpawnPoint( "f_pilgrimroad_51.Id10", "f_pilgrimroad_51", Spot(-126.47256, -1397.1327, 40));
		AddSpawnPoint( "f_pilgrimroad_51.Id10", "f_pilgrimroad_51", Spot(-143.72667, -1461.3499, 40));

	}
}
