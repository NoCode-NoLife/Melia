//--- Melia Script -----------------------------------------------------------
// f_castle_20_4
//
//--- Description -----------------------------------------------------------
// Sets up the f_castle_20_4 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FCastle204MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("f_castle_20_4.Id1", MonsterId.Rootcrystal_01, 15, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_castle_20_4.Id2", MonsterId.Shardstatue_Black, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_castle_20_4.Id3", MonsterId.Templeslave_Black, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_castle_20_4.Id4", MonsterId.Templeslave_Sword_Black, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_castle_20_4.Id5", MonsterId.Templeslave_Sword_Black, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "f_castle_20_4.Id1", "f_castle_20_4", Spot(34.78516, -868.313, 100));
		AddSpawnPoint( "f_castle_20_4.Id1", "f_castle_20_4", Spot(-1445.2787, -263.44592, 100));
		AddSpawnPoint( "f_castle_20_4.Id1", "f_castle_20_4", Spot(-1175.2864, -115.76887, 100));
		AddSpawnPoint( "f_castle_20_4.Id1", "f_castle_20_4", Spot(-410.94626, -374.60388, 100));
		AddSpawnPoint( "f_castle_20_4.Id1", "f_castle_20_4", Spot(-763.08936, 81.99354, 100));
		AddSpawnPoint( "f_castle_20_4.Id1", "f_castle_20_4", Spot(-743.1521, 761.9249, 100));
		AddSpawnPoint( "f_castle_20_4.Id1", "f_castle_20_4", Spot(-1150.9636, 1097.0609, 100));
		AddSpawnPoint( "f_castle_20_4.Id1", "f_castle_20_4", Spot(-1437.508, 904.25116, 100));
		AddSpawnPoint( "f_castle_20_4.Id1", "f_castle_20_4", Spot(4.5423756, 395.73505, 100));
		AddSpawnPoint( "f_castle_20_4.Id1", "f_castle_20_4", Spot(-551.29846, 704.0625, 100));
		AddSpawnPoint( "f_castle_20_4.Id1", "f_castle_20_4", Spot(797.8819, 546.19214, 100));
		AddSpawnPoint( "f_castle_20_4.Id1", "f_castle_20_4", Spot(438.82678, 67.1905, 100));
		AddSpawnPoint( "f_castle_20_4.Id1", "f_castle_20_4", Spot(1247.4951, -384.1472, 100));
		AddSpawnPoint( "f_castle_20_4.Id1", "f_castle_20_4", Spot(1241.5668, 1055.1947, 100));
		AddSpawnPoint( "f_castle_20_4.Id1", "f_castle_20_4", Spot(73.42426, 1097.6423, 100));

		// Shardstatue_Black Spawn Points
		AddSpawnPoint( "f_castle_20_4.Id2", "f_castle_20_4", Spot(-702.44525, -380.59302, 35));
		AddSpawnPoint( "f_castle_20_4.Id2", "f_castle_20_4", Spot(-207.55742, -387.0962, 35));
		AddSpawnPoint( "f_castle_20_4.Id2", "f_castle_20_4", Spot(25.293987, -304.84842, 35));
		AddSpawnPoint( "f_castle_20_4.Id2", "f_castle_20_4", Spot(-10.118077, 281.13248, 35));
		AddSpawnPoint( "f_castle_20_4.Id2", "f_castle_20_4", Spot(77.90299, 661.171, 35));
		AddSpawnPoint( "f_castle_20_4.Id2", "f_castle_20_4", Spot(-224.094, 676.82104, 35));
		AddSpawnPoint( "f_castle_20_4.Id2", "f_castle_20_4", Spot(-407.7395, 841.5025, 35));
		AddSpawnPoint( "f_castle_20_4.Id2", "f_castle_20_4", Spot(-555.5136, 719.55084, 35));
		AddSpawnPoint( "f_castle_20_4.Id2", "f_castle_20_4", Spot(-310.61328, 551.77716, 35));
		AddSpawnPoint( "f_castle_20_4.Id2", "f_castle_20_4", Spot(-380.23657, 681.7813, 35));
		AddSpawnPoint( "f_castle_20_4.Id2", "f_castle_20_4", Spot(-302.8039, 82.72845, 35));
		AddSpawnPoint( "f_castle_20_4.Id2", "f_castle_20_4", Spot(-395.4975, 253.5716, 35));
		AddSpawnPoint( "f_castle_20_4.Id2", "f_castle_20_4", Spot(-553.2185, 112.99907, 35));
		AddSpawnPoint( "f_castle_20_4.Id2", "f_castle_20_4", Spot(-490.73505, -76.17637, 35));
		AddSpawnPoint( "f_castle_20_4.Id2", "f_castle_20_4", Spot(-291.14264, -55.75553, 35));
		AddSpawnPoint( "f_castle_20_4.Id2", "f_castle_20_4", Spot(-431.78168, 116.49784, 35));
		AddSpawnPoint( "f_castle_20_4.Id2", "f_castle_20_4", Spot(47.44703, 107.11325, 35));
		AddSpawnPoint( "f_castle_20_4.Id2", "f_castle_20_4", Spot(-7.6866875, -92.71161, 35));
		AddSpawnPoint( "f_castle_20_4.Id2", "f_castle_20_4", Spot(4.524597, 815.2708, 35));
		AddSpawnPoint( "f_castle_20_4.Id2", "f_castle_20_4", Spot(35.03936, 443.241, 35));
		AddSpawnPoint( "f_castle_20_4.Id2", "f_castle_20_4", Spot(-494.36597, -352.63257, 35));
		AddSpawnPoint( "f_castle_20_4.Id2", "f_castle_20_4", Spot(-2.07484, 1023.0231, 35));

		// Templeslave_Black Spawn Points
		AddSpawnPoint( "f_castle_20_4.Id3", "f_castle_20_4", Spot(-805.9517, -298.67627, 35));
		AddSpawnPoint( "f_castle_20_4.Id3", "f_castle_20_4", Spot(-702.9707, -118.97207, 35));
		AddSpawnPoint( "f_castle_20_4.Id3", "f_castle_20_4", Spot(-771.21515, 69.369095, 35));
		AddSpawnPoint( "f_castle_20_4.Id3", "f_castle_20_4", Spot(-683.58594, 199.21494, 35));
		AddSpawnPoint( "f_castle_20_4.Id3", "f_castle_20_4", Spot(-757.178, 490.8129, 35));
		AddSpawnPoint( "f_castle_20_4.Id3", "f_castle_20_4", Spot(-721.75586, 655.118, 35));
		AddSpawnPoint( "f_castle_20_4.Id3", "f_castle_20_4", Spot(-782.0645, 909.0437, 35));
		AddSpawnPoint( "f_castle_20_4.Id3", "f_castle_20_4", Spot(-744.2903, 1121.8137, 35));
		AddSpawnPoint( "f_castle_20_4.Id3", "f_castle_20_4", Spot(-1034.7623, 1026.4534, 35));
		AddSpawnPoint( "f_castle_20_4.Id3", "f_castle_20_4", Spot(-1273.8335, 1134.9602, 35));
		AddSpawnPoint( "f_castle_20_4.Id3", "f_castle_20_4", Spot(-1425.8967, 994.7538, 35));
		AddSpawnPoint( "f_castle_20_4.Id3", "f_castle_20_4", Spot(-1276.7059, 878.2533, 35));
		AddSpawnPoint( "f_castle_20_4.Id3", "f_castle_20_4", Spot(-1363.294, 476.8423, 35));
		AddSpawnPoint( "f_castle_20_4.Id3", "f_castle_20_4", Spot(-1466.7708, 367.5376, 35));
		AddSpawnPoint( "f_castle_20_4.Id3", "f_castle_20_4", Spot(-1389.9878, 264.98816, 35));
		AddSpawnPoint( "f_castle_20_4.Id3", "f_castle_20_4", Spot(-1288.4446, -361.80344, 35));
		AddSpawnPoint( "f_castle_20_4.Id3", "f_castle_20_4", Spot(-1428.7306, -243.95105, 35));
		AddSpawnPoint( "f_castle_20_4.Id3", "f_castle_20_4", Spot(-1307.751, -92.98715, 35));
		AddSpawnPoint( "f_castle_20_4.Id3", "f_castle_20_4", Spot(-1184.3546, -241.62326, 35));
		AddSpawnPoint( "f_castle_20_4.Id3", "f_castle_20_4", Spot(-1339.3163, 377.09003, 35));
		AddSpawnPoint( "f_castle_20_4.Id3", "f_castle_20_4", Spot(-1219.2534, 978.3968, 35));
		AddSpawnPoint( "f_castle_20_4.Id3", "f_castle_20_4", Spot(-800.9186, -84.13498, 35));
		AddSpawnPoint( "f_castle_20_4.Id3", "f_castle_20_4", Spot(-776.33014, 284.6501, 35));
		AddSpawnPoint( "f_castle_20_4.Id3", "f_castle_20_4", Spot(-976.6567, 1041.6532, 35));
		AddSpawnPoint( "f_castle_20_4.Id3", "f_castle_20_4", Spot(-1285.0746, 456.8678, 35));

		// Templeslave_Sword_Black Spawn Points
		AddSpawnPoint( "f_castle_20_4.Id4", "f_castle_20_4", Spot(190.35892, -420.2785, 35));
		AddSpawnPoint( "f_castle_20_4.Id4", "f_castle_20_4", Spot(359.4801, -346.97714, 35));
		AddSpawnPoint( "f_castle_20_4.Id4", "f_castle_20_4", Spot(613.26685, -414.9624, 35));
		AddSpawnPoint( "f_castle_20_4.Id4", "f_castle_20_4", Spot(917.0539, -405.76068, 35));
		AddSpawnPoint( "f_castle_20_4.Id4", "f_castle_20_4", Spot(1297.3788, -283.95645, 35));
		AddSpawnPoint( "f_castle_20_4.Id4", "f_castle_20_4", Spot(1241.8547, 9.829712, 35));
		AddSpawnPoint( "f_castle_20_4.Id4", "f_castle_20_4", Spot(1313.3219, 191.34329, 35));
		AddSpawnPoint( "f_castle_20_4.Id4", "f_castle_20_4", Spot(1203.3325, 273.10446, 35));
		AddSpawnPoint( "f_castle_20_4.Id4", "f_castle_20_4", Spot(1239.599, 586.18176, 35));
		AddSpawnPoint( "f_castle_20_4.Id4", "f_castle_20_4", Spot(1282.2728, 774.8138, 35));
		AddSpawnPoint( "f_castle_20_4.Id4", "f_castle_20_4", Spot(1208.2478, 870.75574, 35));
		AddSpawnPoint( "f_castle_20_4.Id4", "f_castle_20_4", Spot(1249.0225, 993.6112, 35));
		AddSpawnPoint( "f_castle_20_4.Id4", "f_castle_20_4", Spot(1113.0449, 1076.464, 35));
		AddSpawnPoint( "f_castle_20_4.Id4", "f_castle_20_4", Spot(1293.5985, 1187.7205, 35));
		AddSpawnPoint( "f_castle_20_4.Id4", "f_castle_20_4", Spot(1382.2795, 1014.0515, 35));
		AddSpawnPoint( "f_castle_20_4.Id4", "f_castle_20_4", Spot(-47.682972, -399.64505, 35));
		AddSpawnPoint( "f_castle_20_4.Id4", "f_castle_20_4", Spot(40.1885, 27.892996, 35));
		AddSpawnPoint( "f_castle_20_4.Id4", "f_castle_20_4", Spot(-26.42879, 188.75655, 35));
		AddSpawnPoint( "f_castle_20_4.Id4", "f_castle_20_4", Spot(-12.563477, 636.57825, 35));
		AddSpawnPoint( "f_castle_20_4.Id4", "f_castle_20_4", Spot(35.30894, 934.7871, 35));
		AddSpawnPoint( "f_castle_20_4.Id4", "f_castle_20_4", Spot(394.44653, 1194.6964, 35));
		AddSpawnPoint( "f_castle_20_4.Id4", "f_castle_20_4", Spot(-532.8445, 1155.6777, 35));
		AddSpawnPoint( "f_castle_20_4.Id4", "f_castle_20_4", Spot(-423.15805, 1216.5969, 35));
		AddSpawnPoint( "f_castle_20_4.Id4", "f_castle_20_4", Spot(-282.0456, 1141.896, 35));
		AddSpawnPoint( "f_castle_20_4.Id4", "f_castle_20_4", Spot(-178.05545, 1213.7482, 35));
		AddSpawnPoint( "f_castle_20_4.Id4", "f_castle_20_4", Spot(-132.39995, 1121.6509, 35));
		AddSpawnPoint( "f_castle_20_4.Id4", "f_castle_20_4", Spot(53.834747, 1212.5104, 35));
		AddSpawnPoint( "f_castle_20_4.Id4", "f_castle_20_4", Spot(150.12018, 1137.1055, 35));
		AddSpawnPoint( "f_castle_20_4.Id4", "f_castle_20_4", Spot(341.6074, 1169.2446, 35));
		AddSpawnPoint( "f_castle_20_4.Id5", "f_castle_20_4", Spot(16.189812, -248.99294, 9999));

	}
}
