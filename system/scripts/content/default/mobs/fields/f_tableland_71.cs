//--- Melia Script -----------------------------------------------------------
// f_tableland_71
//
//--- Description -----------------------------------------------------------
// Sets up the f_tableland_71 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FTableland71MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("f_tableland_71.Id1", MonsterId.Hohen_Ritter_Purple, 30, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);
		AddSpawner("f_tableland_71.Id2", MonsterId.Cronewt_Bow_Blue, 10, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);
		AddSpawner("f_tableland_71.Id3", MonsterId.Hohen_Barkle_Blue, 10, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);
		AddSpawner("f_tableland_71.Id4", MonsterId.Tiny_Blue, 10, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);
		AddSpawner("f_tableland_71.Id5", MonsterId.Rootcrystal_03, 35, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("f_tableland_71.Id6", MonsterId.Hohen_Ritter_Purple, 3, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);
		AddSpawner("f_tableland_71.Id7", MonsterId.Hohen_Barkle_Blue, 2, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);
		AddSpawner("f_tableland_71.Id8", MonsterId.Tiny_Blue, 1, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);
		AddSpawner("f_tableland_71.Id9", MonsterId.Cronewt_Bow_Blue, 1, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);
		AddSpawner("f_tableland_71.Id10", MonsterId.Tiny_Blue, 100, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);
		AddSpawner("f_tableland_71.Id11", MonsterId.Cronewt_Bow_Blue, 4, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_tableland_71.Id12", MonsterId.Hohen_Ritter_Purple, 10, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Hohen_Ritter_Purple Spawn Points
		AddSpawnPoint( "f_tableland_71.Id1", "f_tableland_71", Spot(486.5867, -193.05617, 25));
		AddSpawnPoint( "f_tableland_71.Id1", "f_tableland_71", Spot(543.6804, 34.99519, 25));
		AddSpawnPoint( "f_tableland_71.Id1", "f_tableland_71", Spot(271.50314, -169.22864, 25));
		AddSpawnPoint( "f_tableland_71.Id1", "f_tableland_71", Spot(-858.5497, -160.28857, 25));
		AddSpawnPoint( "f_tableland_71.Id1", "f_tableland_71", Spot(-649.2382, -100.18603, 25));
		AddSpawnPoint( "f_tableland_71.Id1", "f_tableland_71", Spot(-787.3096, 67.92552, 25));
		AddSpawnPoint( "f_tableland_71.Id1", "f_tableland_71", Spot(-465.50134, 124.58864, 25));
		AddSpawnPoint( "f_tableland_71.Id1", "f_tableland_71", Spot(-238.21713, -557.00696, 25));
		AddSpawnPoint( "f_tableland_71.Id1", "f_tableland_71", Spot(29.601654, -579.05457, 25));
		AddSpawnPoint( "f_tableland_71.Id1", "f_tableland_71", Spot(-121.79101, -684.8212, 25));
		AddSpawnPoint( "f_tableland_71.Id1", "f_tableland_71", Spot(-252.7248, -366.75305, 25));
		AddSpawnPoint( "f_tableland_71.Id1", "f_tableland_71", Spot(-1219.0106, 25.776241, 25));
		AddSpawnPoint( "f_tableland_71.Id1", "f_tableland_71", Spot(-1407.6075, -138.8998, 25));
		AddSpawnPoint( "f_tableland_71.Id1", "f_tableland_71", Spot(-1540.7507, 83.568695, 25));
		AddSpawnPoint( "f_tableland_71.Id1", "f_tableland_71", Spot(-1401.448, 85.93085, 25));
		AddSpawnPoint( "f_tableland_71.Id1", "f_tableland_71", Spot(-291.6463, 752.4351, 25));
		AddSpawnPoint( "f_tableland_71.Id1", "f_tableland_71", Spot(-236.62039, -70.9395, 25));
		AddSpawnPoint( "f_tableland_71.Id1", "f_tableland_71", Spot(-199.51344, 288.49033, 25));
		AddSpawnPoint( "f_tableland_71.Id1", "f_tableland_71", Spot(-332.39575, 586.3931, 25));
		AddSpawnPoint( "f_tableland_71.Id1", "f_tableland_71", Spot(-264.6505, 488.9493, 25));
		AddSpawnPoint( "f_tableland_71.Id1", "f_tableland_71", Spot(-640.2105, 1057.1427, 25));
		AddSpawnPoint( "f_tableland_71.Id1", "f_tableland_71", Spot(-858.41986, 1305.6135, 25));
		AddSpawnPoint( "f_tableland_71.Id1", "f_tableland_71", Spot(232.35068, 482.34872, 25));
		AddSpawnPoint( "f_tableland_71.Id1", "f_tableland_71", Spot(296.58154, 738.1159, 25));
		AddSpawnPoint( "f_tableland_71.Id1", "f_tableland_71", Spot(504.29538, 334.1079, 25));
		AddSpawnPoint( "f_tableland_71.Id1", "f_tableland_71", Spot(801.69214, 451.11636, 25));
		AddSpawnPoint( "f_tableland_71.Id1", "f_tableland_71", Spot(1145.8291, 634.0386, 25));
		AddSpawnPoint( "f_tableland_71.Id1", "f_tableland_71", Spot(1289.5499, 680.50714, 25));
		AddSpawnPoint( "f_tableland_71.Id1", "f_tableland_71", Spot(1344.6727, 484.9703, 25));
		AddSpawnPoint( "f_tableland_71.Id1", "f_tableland_71", Spot(1328.186, 82.37843, 25));
		AddSpawnPoint( "f_tableland_71.Id1", "f_tableland_71", Spot(1227.2969, -56.380733, 25));
		AddSpawnPoint( "f_tableland_71.Id1", "f_tableland_71", Spot(1345.2937, -171.73454, 25));
		AddSpawnPoint( "f_tableland_71.Id1", "f_tableland_71", Spot(1427.6339, -5.9960155, 25));
		AddSpawnPoint( "f_tableland_71.Id1", "f_tableland_71", Spot(1076.2872, 459.82898, 25));
		AddSpawnPoint( "f_tableland_71.Id1", "f_tableland_71", Spot(713.2357, -121.38043, 25));
		AddSpawnPoint( "f_tableland_71.Id1", "f_tableland_71", Spot(482.7369, -390.23972, 25));

		// Cronewt_Bow_Blue Spawn Points
		AddSpawnPoint( "f_tableland_71.Id2", "f_tableland_71", Spot(-1469.2451, 5.477024, 25));
		AddSpawnPoint( "f_tableland_71.Id2", "f_tableland_71", Spot(-331.69385, 1044.2815, 25));
		AddSpawnPoint( "f_tableland_71.Id2", "f_tableland_71", Spot(-774.48914, 1228.3356, 25));
		AddSpawnPoint( "f_tableland_71.Id2", "f_tableland_71", Spot(30.364326, 783.7525, 25));
		AddSpawnPoint( "f_tableland_71.Id2", "f_tableland_71", Spot(-442.66083, 661.22485, 25));
		AddSpawnPoint( "f_tableland_71.Id2", "f_tableland_71", Spot(-373.6047, 531.40314, 25));
		AddSpawnPoint( "f_tableland_71.Id2", "f_tableland_71", Spot(-265.52335, 365.56497, 25));
		AddSpawnPoint( "f_tableland_71.Id2", "f_tableland_71", Spot(-501.15042, 871.4398, 25));
		AddSpawnPoint( "f_tableland_71.Id2", "f_tableland_71", Spot(49.732418, 621.892, 25));
		AddSpawnPoint( "f_tableland_71.Id2", "f_tableland_71", Spot(166.11928, 439.44098, 25));
		AddSpawnPoint( "f_tableland_71.Id2", "f_tableland_71", Spot(356.92123, 534.9384, 25));
		AddSpawnPoint( "f_tableland_71.Id2", "f_tableland_71", Spot(418.8459, 858.42346, 25));
		AddSpawnPoint( "f_tableland_71.Id2", "f_tableland_71", Spot(354.8475, 221.52191, 25));
		AddSpawnPoint( "f_tableland_71.Id2", "f_tableland_71", Spot(715.7757, 499.68213, 25));
		AddSpawnPoint( "f_tableland_71.Id2", "f_tableland_71", Spot(663.97235, 300.46964, 25));
		AddSpawnPoint( "f_tableland_71.Id2", "f_tableland_71", Spot(716.88306, 114.90778, 25));
		AddSpawnPoint( "f_tableland_71.Id2", "f_tableland_71", Spot(353.8802, -29.109556, 25));
		AddSpawnPoint( "f_tableland_71.Id2", "f_tableland_71", Spot(320.77737, -328.07407, 25));
		AddSpawnPoint( "f_tableland_71.Id2", "f_tableland_71", Spot(455.0422, -375.6652, 25));
		AddSpawnPoint( "f_tableland_71.Id2", "f_tableland_71", Spot(680.39594, -312.21213, 25));

		// Hohen_Barkle_Blue Spawn Points
		AddSpawnPoint( "f_tableland_71.Id3", "f_tableland_71", Spot(-748.2872, -169.90273, 25));
		AddSpawnPoint( "f_tableland_71.Id3", "f_tableland_71", Spot(-782.3993, 6.6940117, 25));
		AddSpawnPoint( "f_tableland_71.Id3", "f_tableland_71", Spot(-1301.0358, -28.80489, 25));
		AddSpawnPoint( "f_tableland_71.Id3", "f_tableland_71", Spot(-1604.4048, -0.19901657, 25));
		AddSpawnPoint( "f_tableland_71.Id3", "f_tableland_71", Spot(-1479.5134, -82.3134, 25));
		AddSpawnPoint( "f_tableland_71.Id3", "f_tableland_71", Spot(-990.0384, 63.719963, 25));
		AddSpawnPoint( "f_tableland_71.Id3", "f_tableland_71", Spot(-786.89166, 169.58482, 25));
		AddSpawnPoint( "f_tableland_71.Id3", "f_tableland_71", Spot(-651.44196, -138.3997, 25));
		AddSpawnPoint( "f_tableland_71.Id3", "f_tableland_71", Spot(-466.56274, -97.681946, 25));
		AddSpawnPoint( "f_tableland_71.Id3", "f_tableland_71", Spot(-344.5396, 140.74025, 25));
		AddSpawnPoint( "f_tableland_71.Id3", "f_tableland_71", Spot(-516.6238, 157.80696, 25));
		AddSpawnPoint( "f_tableland_71.Id3", "f_tableland_71", Spot(-392.8985, 22.93614, 25));
		AddSpawnPoint( "f_tableland_71.Id3", "f_tableland_71", Spot(-928.06476, -205.2193, 25));
		AddSpawnPoint( "f_tableland_71.Id3", "f_tableland_71", Spot(-979.3079, -644.5786, 25));
		AddSpawnPoint( "f_tableland_71.Id3", "f_tableland_71", Spot(-987.92456, -861.6408, 25));
		AddSpawnPoint( "f_tableland_71.Id3", "f_tableland_71", Spot(-839.0043, -938.41077, 25));
		AddSpawnPoint( "f_tableland_71.Id3", "f_tableland_71", Spot(-810.7621, -705.2188, 25));
		AddSpawnPoint( "f_tableland_71.Id3", "f_tableland_71", Spot(-914.9769, -805.77893, 25));
		AddSpawnPoint( "f_tableland_71.Id3", "f_tableland_71", Spot(-739.3033, -862.8378, 25));
		AddSpawnPoint( "f_tableland_71.Id3", "f_tableland_71", Spot(-877.95953, -444.99493, 25));

		// Tiny_Blue Spawn Points
		AddSpawnPoint( "f_tableland_71.Id4", "f_tableland_71", Spot(-886.64197, -769.5499, 25));
		AddSpawnPoint( "f_tableland_71.Id4", "f_tableland_71", Spot(-920.4261, -941.4387, 25));
		AddSpawnPoint( "f_tableland_71.Id4", "f_tableland_71", Spot(-1287.0673, -94.02114, 25));
		AddSpawnPoint( "f_tableland_71.Id4", "f_tableland_71", Spot(-1316.3807, 94.075294, 25));
		AddSpawnPoint( "f_tableland_71.Id4", "f_tableland_71", Spot(-627.59174, -46.302666, 25));
		AddSpawnPoint( "f_tableland_71.Id4", "f_tableland_71", Spot(-208.59645, 1037.5729, 25));
		AddSpawnPoint( "f_tableland_71.Id4", "f_tableland_71", Spot(-256.5593, -281.58563, 25));
		AddSpawnPoint( "f_tableland_71.Id4", "f_tableland_71", Spot(291.2697, -135.1914, 25));
		AddSpawnPoint( "f_tableland_71.Id4", "f_tableland_71", Spot(664.8153, -307.25467, 25));
		AddSpawnPoint( "f_tableland_71.Id4", "f_tableland_71", Spot(1183.2551, -88.88057, 25));
		AddSpawnPoint( "f_tableland_71.Id4", "f_tableland_71", Spot(1331.5823, -137.91734, 25));
		AddSpawnPoint( "f_tableland_71.Id4", "f_tableland_71", Spot(1343.2506, 113.00804, 25));
		AddSpawnPoint( "f_tableland_71.Id4", "f_tableland_71", Spot(1306.6211, -8.49077, 25));
		AddSpawnPoint( "f_tableland_71.Id4", "f_tableland_71", Spot(1401.311, 217.75792, 25));
		AddSpawnPoint( "f_tableland_71.Id4", "f_tableland_71", Spot(1447.8049, 485.43082, 25));
		AddSpawnPoint( "f_tableland_71.Id4", "f_tableland_71", Spot(1244.664, 490.33362, 25));
		AddSpawnPoint( "f_tableland_71.Id4", "f_tableland_71", Spot(1040.7988, 384.3584, 25));
		AddSpawnPoint( "f_tableland_71.Id4", "f_tableland_71", Spot(1073.5453, 585.2853, 25));
		AddSpawnPoint( "f_tableland_71.Id4", "f_tableland_71", Spot(1355.3246, 766.91125, 25));
		AddSpawnPoint( "f_tableland_71.Id4", "f_tableland_71", Spot(1268.3547, 647.5924, 25));
		AddSpawnPoint( "f_tableland_71.Id4", "f_tableland_71", Spot(851.23706, 412.53058, 25));
		AddSpawnPoint( "f_tableland_71.Id4", "f_tableland_71", Spot(667.336, 502.88928, 25));
		AddSpawnPoint( "f_tableland_71.Id4", "f_tableland_71", Spot(661.0867, 244.93652, 25));
		AddSpawnPoint( "f_tableland_71.Id4", "f_tableland_71", Spot(365.39966, 682.89233, 25));
		AddSpawnPoint( "f_tableland_71.Id4", "f_tableland_71", Spot(531.12286, 425.91983, 25));
		AddSpawnPoint( "f_tableland_71.Id4", "f_tableland_71", Spot(391.1265, 273.95468, 25));
		AddSpawnPoint( "f_tableland_71.Id4", "f_tableland_71", Spot(250.12149, 483.55197, 25));
		AddSpawnPoint( "f_tableland_71.Id4", "f_tableland_71", Spot(257.51215, 746.7217, 25));
		AddSpawnPoint( "f_tableland_71.Id4", "f_tableland_71", Spot(1460.7844, 777.3249, 25));

		// Rootcrystal_03 Spawn Points
		AddSpawnPoint( "f_tableland_71.Id5", "f_tableland_71", Spot(-269.89594, -1156.6276, 40));
		AddSpawnPoint( "f_tableland_71.Id5", "f_tableland_71", Spot(-663.18146, -888.8761, 40));
		AddSpawnPoint( "f_tableland_71.Id5", "f_tableland_71", Spot(-991.2923, -919.6704, 40));
		AddSpawnPoint( "f_tableland_71.Id5", "f_tableland_71", Spot(-1012.9246, -679.64, 40));
		AddSpawnPoint( "f_tableland_71.Id5", "f_tableland_71", Spot(-944.98566, -256.3002, 40));
		AddSpawnPoint( "f_tableland_71.Id5", "f_tableland_71", Spot(-876.1119, 116.89404, 40));
		AddSpawnPoint( "f_tableland_71.Id5", "f_tableland_71", Spot(-407.74136, -116.49785, 40));
		AddSpawnPoint( "f_tableland_71.Id5", "f_tableland_71", Spot(-420.773, 201.24927, 40));
		AddSpawnPoint( "f_tableland_71.Id5", "f_tableland_71", Spot(-285.96326, -440.55994, 40));
		AddSpawnPoint( "f_tableland_71.Id5", "f_tableland_71", Spot(-55.76422, -630.4347, 40));
		AddSpawnPoint( "f_tableland_71.Id5", "f_tableland_71", Spot(-309.91104, 542.82794, 40));
		AddSpawnPoint( "f_tableland_71.Id5", "f_tableland_71", Spot(-475.98328, 884.9742, 40));
		AddSpawnPoint( "f_tableland_71.Id5", "f_tableland_71", Spot(-538.74445, 672.7238, 40));
		AddSpawnPoint( "f_tableland_71.Id5", "f_tableland_71", Spot(-121.88376, 920.17896, 40));
		AddSpawnPoint( "f_tableland_71.Id5", "f_tableland_71", Spot(149.4264, 711.4868, 40));
		AddSpawnPoint( "f_tableland_71.Id5", "f_tableland_71", Spot(221.88779, 464.84378, 40));
		AddSpawnPoint( "f_tableland_71.Id5", "f_tableland_71", Spot(403.6727, 213.91809, 40));
		AddSpawnPoint( "f_tableland_71.Id5", "f_tableland_71", Spot(728.54736, 128.58499, 40));
		AddSpawnPoint( "f_tableland_71.Id5", "f_tableland_71", Spot(555.0109, -49.768578, 40));
		AddSpawnPoint( "f_tableland_71.Id5", "f_tableland_71", Spot(303.98877, -170.769, 40));
		AddSpawnPoint( "f_tableland_71.Id5", "f_tableland_71", Spot(537.4308, -416.8607, 40));
		AddSpawnPoint( "f_tableland_71.Id5", "f_tableland_71", Spot(589.4804, 465.031, 40));
		AddSpawnPoint( "f_tableland_71.Id5", "f_tableland_71", Spot(961.0913, 391.09833, 40));
		AddSpawnPoint( "f_tableland_71.Id5", "f_tableland_71", Spot(1182.5337, 503.79187, 40));
		AddSpawnPoint( "f_tableland_71.Id5", "f_tableland_71", Spot(1382.5448, 692.0085, 40));
		AddSpawnPoint( "f_tableland_71.Id5", "f_tableland_71", Spot(1285.1315, -96.36547, 40));
		AddSpawnPoint( "f_tableland_71.Id5", "f_tableland_71", Spot(1703.2063, 619.3782, 40));
		AddSpawnPoint( "f_tableland_71.Id5", "f_tableland_71", Spot(1802.2192, 460.45328, 40));
		AddSpawnPoint( "f_tableland_71.Id5", "f_tableland_71", Spot(-666.5922, 1117.2737, 40));
		AddSpawnPoint( "f_tableland_71.Id5", "f_tableland_71", Spot(-825.6249, 704.7758, 40));
		AddSpawnPoint( "f_tableland_71.Id5", "f_tableland_71", Spot(-1148.8636, 677.68823, 40));
		AddSpawnPoint( "f_tableland_71.Id5", "f_tableland_71", Spot(-1020.7433, 566.24005, 40));
		AddSpawnPoint( "f_tableland_71.Id5", "f_tableland_71", Spot(-1542.3202, -43.65925, 40));
		AddSpawnPoint( "f_tableland_71.Id5", "f_tableland_71", Spot(-1243.3893, 123.76671, 40));
		AddSpawnPoint( "f_tableland_71.Id5", "f_tableland_71", Spot(-1257.094, -177.44121, 40));

		// Hohen_Ritter_Purple Spawn Points
		AddSpawnPoint( "f_tableland_71.Id6", "f_tableland_71", Spot(-657.42535, 842.9307, 40));
		AddSpawnPoint( "f_tableland_71.Id6", "f_tableland_71", Spot(-370.5785, 763.3096, 40));
		AddSpawnPoint( "f_tableland_71.Id6", "f_tableland_71", Spot(-317.90125, 939.5368, 40));

		// Hohen_Barkle_Blue Spawn Points
		AddSpawnPoint( "f_tableland_71.Id7", "f_tableland_71", Spot(-387.08475, 845.19104, 40));
		AddSpawnPoint( "f_tableland_71.Id7", "f_tableland_71", Spot(-465.39587, 737.3048, 40));

		// Tiny_Blue Spawn Points
		AddSpawnPoint( "f_tableland_71.Id8", "f_tableland_71", Spot(-498.9502, 964.44824, 40));

		// Cronewt_Bow_Blue Spawn Points
		AddSpawnPoint( "f_tableland_71.Id9", "f_tableland_71", Spot(-455.91403, 826.01654, 40));

		// Tiny_Blue Spawn Points
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(1240.4733, -155.02448, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(1248.7267, 43.607323, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(1411.3396, -71.59265, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(1167.8011, 462.8219, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(1371.7971, 456.97406, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(1361.4702, 663.7318, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(1173.1133, 680.18494, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-980.7438, -733.29114, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-1054.299, -982.636, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-986.41504, -1018.5338, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-983.899, -947.76483, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-1043.3036, -865.887, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-1053.8773, -706.7079, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-908.7013, -868.62994, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-814.7281, -864.3508, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-801.1194, -991.03906, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-744.1547, -930.9001, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-774.29755, -792.93555, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-828.654, -755.86115, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-885.57684, -699.0304, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-826.7768, -634.5736, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-920.38055, -623.58966, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-1615.25, 79.383125, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-1543.7612, 16.53669, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-1477.4033, 119.79504, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-1403.3809, 10.335129, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-1409.676, -68.37183, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-1335.9056, -132.53528, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-1265.5184, -178.01576, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-1214.6307, -105.08361, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-1138.4489, -43.913902, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-1303.4952, 40.2022, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-1480.3472, -147.2025, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-1558.3943, -57.360687, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-1669.4594, -13.607139, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-1557.8989, 150.65196, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-1389.3455, 160.79327, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-1078.6691, 22.412111, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-931.14496, 43.7716, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-877.6778, 130.02701, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-859.50287, 40.935528, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-827.76807, -40.021847, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-750.33496, -73.95926, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-800.15045, -133.06552, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-941.5805, -270.26764, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-869.129, -227.34683, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-776.23505, -249.54596, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-688.7156, -218.13779, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-685.2196, -797.9101, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-671.29865, -881.0069, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-180.96086, -552.7359, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-193.51411, -643.0041, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-87.82323, -605.7062, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-20.619987, -667.529, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(54.938946, -635.60004, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(0.5062618, -506.07068, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-12.733539, -750.90594, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-182.28725, -724.2035, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-264.358, -665.18756, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-237.73769, -478.00775, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-282.93237, -421.23184, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-330.65533, -354.4683, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-266.76855, -201.9771, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-308.47757, -499.30847, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-391.94833, -448.22247, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-338.69046, -617.3901, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-371.7672, -542.3425, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-492.46228, -36.523003, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-410.54346, -75.75404, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-465.29163, 31.83923, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-515.73883, 64.11232, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-578.0939, 140.74997, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-556.42755, 224.48228, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-464.8881, 232.2634, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-412.22614, 170.21227, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-402.66492, 90.05346, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-516.5011, 303.03534, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-171.12057, 227.91388, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-239.03702, 438.0893, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-304.92883, 455.2364, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-294.79123, 640.91077, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-346.56708, 691.25305, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-401.09323, 603.1548, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-253.98999, 539.6234, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-546.8791, 731.631, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-579.7638, 811.1263, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-760.4238, 849.6117, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-691.92004, 774.02655, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-630.169, 705.579, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-708.0268, 707.3201, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-829.4545, 1253.8055, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-733.8251, 1185.1519, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-670.37244, 1156.8849, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-690.4291, 1097.6382, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-607.8134, 1101.404, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-564.2134, 1038.2488, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-584.30096, 950.27466, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-405.92746, 922.4038, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(-386.28525, 998.87604, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(316.907, -241.35876, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(395.76648, -269.91095, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(475.18802, -300.3313, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(562.0525, -355.04013, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(588.5982, -431.17572, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(584.74634, -279.0734, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(543.74414, -194.7487, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(414.25006, -177.08853, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(387.00153, -101.52184, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(457.39633, -107.60623, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(331.25626, -162.66756, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(560.39545, -106.2365, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(616.5205, -204.03867, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(696.1674, -245.1611, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(754.6236, -195.53864, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(636.0395, -130.31937, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(716.6333, -58.97298, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(635.0571, -48.92104, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(555.3536, -28.731953, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(467.99585, -22.512, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(491.3862, 58.444847, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(601.898, 23.657032, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(683.1749, 8.089699, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(651.68616, 75.62118, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(568.0649, 115.12276, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(660.7975, 161.88681, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(742.45215, 186.41098, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(580.2626, 203.34456, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(508.46243, 241.14511, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(506.0076, 155.67473, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(595.13617, 363.10034, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(384.86786, 353.23035, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(588.26715, 490.429, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(491.06693, 495.983, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(406.93607, 592.2063, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(299.00732, 581.53687, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(304.2611, 428.92102, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(235.90216, 279.20306, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(319.54355, 295.72046, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(192.0135, 235.93057, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(184.18112, 171.17914, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(1159.4891, -167.17657, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(1286.7439, -221.21414, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(1328.3403, -62.264412, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(1399.4354, 57.21823, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(1411.2347, 144.16081, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(1307.9827, 582.4967, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(1420.672, 595.57086, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(1228.9395, 574.8137, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(1131.6005, 564.7496, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(1122.7181, 403.52405, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(1011.3996, 478.44186, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(982.64655, 390.16455, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(1002.6931, 310.13458, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(914.4366, 457.939, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(912.484, 347.12985, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(1519.8496, 601.0993, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(1278.7568, 757.2936, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(1376.8016, 538.87726, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(1290.9019, 433.62415, 40));
		AddSpawnPoint( "f_tableland_71.Id10", "f_tableland_71", Spot(1259.4387, 345.3533, 40));

		// Cronewt_Bow_Blue Spawn Points
		AddSpawnPoint( "f_tableland_71.Id11", "f_tableland_71", Spot(227.18665, 381.55768, 40));
		AddSpawnPoint( "f_tableland_71.Id11", "f_tableland_71", Spot(452.3298, 402.84344, 40));
		AddSpawnPoint( "f_tableland_71.Id11", "f_tableland_71", Spot(421.19928, 747.795, 40));
		AddSpawnPoint( "f_tableland_71.Id11", "f_tableland_71", Spot(168.07289, 727.9651, 40));

		// Hohen_Ritter_Purple Spawn Points
		AddSpawnPoint( "f_tableland_71.Id12", "f_tableland_71", Spot(406.16333, 698.0334, 40));
		AddSpawnPoint( "f_tableland_71.Id12", "f_tableland_71", Spot(164.10661, 306.70535, 40));
		AddSpawnPoint( "f_tableland_71.Id12", "f_tableland_71", Spot(280.80725, 220.07552, 40));
		AddSpawnPoint( "f_tableland_71.Id12", "f_tableland_71", Spot(588.2072, 278.8196, 40));
		AddSpawnPoint( "f_tableland_71.Id12", "f_tableland_71", Spot(223.89517, 666.00275, 40));
		AddSpawnPoint( "f_tableland_71.Id12", "f_tableland_71", Spot(681.11743, 481.51147, 40));
		AddSpawnPoint( "f_tableland_71.Id12", "f_tableland_71", Spot(351.68015, 506.1176, 40));
		AddSpawnPoint( "f_tableland_71.Id12", "f_tableland_71", Spot(432.21054, 278.4054, 40));
		AddSpawnPoint( "f_tableland_71.Id12", "f_tableland_71", Spot(140.00545, 519.72205, 40));
		AddSpawnPoint( "f_tableland_71.Id12", "f_tableland_71", Spot(603.9525, 638.1184, 40));

	}
}
