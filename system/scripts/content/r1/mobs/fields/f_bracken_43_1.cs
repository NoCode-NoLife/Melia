//--- Melia Script -----------------------------------------------------------
// f_bracken_43_1
//
//--- Description -----------------------------------------------------------
// Sets up the f_bracken_43_1 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FBracken431MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("f_bracken_43_1.Id1", MonsterId.Rakon, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_1.Id2", MonsterId.Rootcrystal_01, 15, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_1.Id3", MonsterId.Toothrikon, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_1.Id4", MonsterId.Horn_Golem, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_1.Id5", MonsterId.Rakon, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_1.Id6", MonsterId.Rakon, 12, TimeSpan.FromMilliseconds(40000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Rakon Spawn Points
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(-201.10962, -1565.874, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(-182.62766, -1419.226, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(-268.03784, -1742.28, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(-425.24585, -1547.6825, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(-1320.5498, -1054.7826, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(-1158.1198, -1395.1332, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(-1068.7684, -1079.1669, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(93.407486, -1351.7948, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(293.95538, -1153.4263, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(-137.3461, -833.40967, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(-119.86803, -237.4283, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(95.62465, -700.88586, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(-287.23425, -51.0357, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(355.93625, 923.48926, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(-792.057, 200.517, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(-1098.6155, 350.86688, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(-1324.4081, 409.73816, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(-1439.3324, -125.22323, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(-1612.8224, -183.59296, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(-2082.1655, -284.15198, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(-1235.473, -209.72525, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(-1276.7964, 532.1956, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(-652.4914, 773.9195, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(-421.93823, 777.60345, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(-261.42715, 795.8934, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(321.87225, 741.07056, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(456.40585, 644.44, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(555.5346, 824.93976, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(685.7234, 764.9966, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(1093.3146, 734.5813, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(912.9551, -12.620995, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(697.62134, 46.559143, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(1051.572, 158.9338, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(927.99115, -670.6167, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(702.22675, -650.85565, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(688.5691, -888.3728, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(942.9141, -831.39746, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(1064.2716, -538.4112, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(-1638.076, -344.7355, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(-1867.7069, -326.23907, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(-1619.6066, 426.3294, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(-1386.2704, 677.1264, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(-278.90192, -242.11124, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(-333.47614, -417.2779, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(-10.908813, -471.33932, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(-138.55508, -409.56824, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(-1067.3983, -1233.52, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(-1109.8132, -851.2137, 40));
		AddSpawnPoint( "f_bracken_43_1.Id1", "f_bracken_43_1", Spot(853.01953, -488.0896, 40));

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "f_bracken_43_1.Id2", "f_bracken_43_1", Spot(976.3353, 51.72992, 40));
		AddSpawnPoint( "f_bracken_43_1.Id2", "f_bracken_43_1", Spot(674.6178, 109.41093, 40));
		AddSpawnPoint( "f_bracken_43_1.Id2", "f_bracken_43_1", Spot(1141.3834, 767.2179, 40));
		AddSpawnPoint( "f_bracken_43_1.Id2", "f_bracken_43_1", Spot(1071.8148, 1284.0928, 40));
		AddSpawnPoint( "f_bracken_43_1.Id2", "f_bracken_43_1", Spot(592.0737, 688.9888, 40));
		AddSpawnPoint( "f_bracken_43_1.Id2", "f_bracken_43_1", Spot(-500.81097, 776.296, 40));
		AddSpawnPoint( "f_bracken_43_1.Id2", "f_bracken_43_1", Spot(-1355.9724, 489.5949, 40));
		AddSpawnPoint( "f_bracken_43_1.Id2", "f_bracken_43_1", Spot(-1454.1464, -257.77573, 40));
		AddSpawnPoint( "f_bracken_43_1.Id2", "f_bracken_43_1", Spot(-1090.8535, -1211.8457, 40));
		AddSpawnPoint( "f_bracken_43_1.Id2", "f_bracken_43_1", Spot(-154.5099, -1577.7433, 40));
		AddSpawnPoint( "f_bracken_43_1.Id2", "f_bracken_43_1", Spot(247.22038, -1201.6904, 40));
		AddSpawnPoint( "f_bracken_43_1.Id2", "f_bracken_43_1", Spot(-138.12505, -819.8081, 40));
		AddSpawnPoint( "f_bracken_43_1.Id2", "f_bracken_43_1", Spot(-168.49716, -452.2237, 40));
		AddSpawnPoint( "f_bracken_43_1.Id2", "f_bracken_43_1", Spot(-356.4398, -95.96916, 40));
		AddSpawnPoint( "f_bracken_43_1.Id2", "f_bracken_43_1", Spot(291.46884, 852.4863, 40));

		// Toothrikon Spawn Points
		AddSpawnPoint( "f_bracken_43_1.Id3", "f_bracken_43_1", Spot(-236.67085, -307.5888, 40));
		AddSpawnPoint( "f_bracken_43_1.Id3", "f_bracken_43_1", Spot(-1126.4773, -1204.7615, 40));
		AddSpawnPoint( "f_bracken_43_1.Id3", "f_bracken_43_1", Spot(-113.31483, -1552.7072, 40));
		AddSpawnPoint( "f_bracken_43_1.Id3", "f_bracken_43_1", Spot(-210.34459, -830.30035, 40));
		AddSpawnPoint( "f_bracken_43_1.Id3", "f_bracken_43_1", Spot(455.60437, -1105.639, 40));
		AddSpawnPoint( "f_bracken_43_1.Id3", "f_bracken_43_1", Spot(644.5506, -667.06616, 40));
		AddSpawnPoint( "f_bracken_43_1.Id3", "f_bracken_43_1", Spot(1175.5468, 756.8555, 40));
		AddSpawnPoint( "f_bracken_43_1.Id3", "f_bracken_43_1", Spot(1121.6218, 1128.8394, 40));
		AddSpawnPoint( "f_bracken_43_1.Id3", "f_bracken_43_1", Spot(-1225.4977, -1302.1694, 40));
		AddSpawnPoint( "f_bracken_43_1.Id3", "f_bracken_43_1", Spot(-403.05017, -1567.2328, 40));
		AddSpawnPoint( "f_bracken_43_1.Id3", "f_bracken_43_1", Spot(1037.3383, -684.83344, 40));
		AddSpawnPoint( "f_bracken_43_1.Id3", "f_bracken_43_1", Spot(908.9933, 1502.844, 40));
		AddSpawnPoint( "f_bracken_43_1.Id3", "f_bracken_43_1", Spot(-19.691362, -712.1917, 40));
		AddSpawnPoint( "f_bracken_43_1.Id3", "f_bracken_43_1", Spot(-320.27097, -440.72473, 40));
		AddSpawnPoint( "f_bracken_43_1.Id3", "f_bracken_43_1", Spot(-350.96802, -39.745514, 40));
		AddSpawnPoint( "f_bracken_43_1.Id3", "f_bracken_43_1", Spot(12.415304, -581.33185, 40));
		AddSpawnPoint( "f_bracken_43_1.Id3", "f_bracken_43_1", Spot(658.6017, -937.3071, 40));
		AddSpawnPoint( "f_bracken_43_1.Id3", "f_bracken_43_1", Spot(911.08746, -491.6918, 40));
		AddSpawnPoint( "f_bracken_43_1.Id3", "f_bracken_43_1", Spot(646.8882, 43.382877, 40));
		AddSpawnPoint( "f_bracken_43_1.Id3", "f_bracken_43_1", Spot(900.9634, 297.34787, 40));
		AddSpawnPoint( "f_bracken_43_1.Id3", "f_bracken_43_1", Spot(928.6691, 61.447433, 40));
		AddSpawnPoint( "f_bracken_43_1.Id3", "f_bracken_43_1", Spot(745.94385, 171.33868, 40));
		AddSpawnPoint( "f_bracken_43_1.Id3", "f_bracken_43_1", Spot(-238.38904, -1484.6989, 40));
		AddSpawnPoint( "f_bracken_43_1.Id3", "f_bracken_43_1", Spot(-255.11124, -1704.7784, 40));
		AddSpawnPoint( "f_bracken_43_1.Id3", "f_bracken_43_1", Spot(-1116.879, -966.3063, 40));
		AddSpawnPoint( "f_bracken_43_1.Id3", "f_bracken_43_1", Spot(-1265.6372, -1074.102, 40));
		AddSpawnPoint( "f_bracken_43_1.Id3", "f_bracken_43_1", Spot(211.08305, -1231.7257, 40));
		AddSpawnPoint( "f_bracken_43_1.Id3", "f_bracken_43_1", Spot(894.91095, 1095.4514, 40));
		AddSpawnPoint( "f_bracken_43_1.Id3", "f_bracken_43_1", Spot(1098.4464, 1422.8912, 40));
		AddSpawnPoint( "f_bracken_43_1.Id3", "f_bracken_43_1", Spot(984.92944, 1314.1084, 40));
		AddSpawnPoint( "f_bracken_43_1.Id3", "f_bracken_43_1", Spot(1021.2712, 734.68866, 40));
		AddSpawnPoint( "f_bracken_43_1.Id3", "f_bracken_43_1", Spot(1100.9308, 928.2888, 40));

		// Horn_Golem Spawn Points
		AddSpawnPoint( "f_bracken_43_1.Id4", "f_bracken_43_1", Spot(-1133.0795, -994.4703, 100));
		AddSpawnPoint( "f_bracken_43_1.Id4", "f_bracken_43_1", Spot(-409.95096, -1577.8158, 100));
		AddSpawnPoint( "f_bracken_43_1.Id4", "f_bracken_43_1", Spot(-26.608042, -840.94507, 100));
		AddSpawnPoint( "f_bracken_43_1.Id4", "f_bracken_43_1", Spot(-297.32047, -191.45364, 100));
		AddSpawnPoint( "f_bracken_43_1.Id4", "f_bracken_43_1", Spot(-1465.9807, -283.80713, 100));
		AddSpawnPoint( "f_bracken_43_1.Id4", "f_bracken_43_1", Spot(-1425.0685, 768.8743, 100));
		AddSpawnPoint( "f_bracken_43_1.Id4", "f_bracken_43_1", Spot(-534.3695, 850.77466, 100));
		AddSpawnPoint( "f_bracken_43_1.Id4", "f_bracken_43_1", Spot(762.07, 175.78539, 100));
		AddSpawnPoint( "f_bracken_43_1.Id4", "f_bracken_43_1", Spot(912.4917, 267.71463, 100));
		AddSpawnPoint( "f_bracken_43_1.Id4", "f_bracken_43_1", Spot(829.2461, -643.10724, 100));
		AddSpawnPoint( "f_bracken_43_1.Id4", "f_bracken_43_1", Spot(700.7716, -970.5183, 100));
		AddSpawnPoint( "f_bracken_43_1.Id4", "f_bracken_43_1", Spot(174.58318, -1288.1376, 100));
		AddSpawnPoint( "f_bracken_43_1.Id4", "f_bracken_43_1", Spot(-96.503555, -1523.8176, 100));
		AddSpawnPoint( "f_bracken_43_1.Id4", "f_bracken_43_1", Spot(-1077.3912, -1249.9329, 100));
		AddSpawnPoint( "f_bracken_43_1.Id4", "f_bracken_43_1", Spot(-1365.8256, 418.5318, 100));

		// Rakon Spawn Points
		AddSpawnPoint( "f_bracken_43_1.Id5", "f_bracken_43_1", Spot(-267.93393, -279.13068, 9999));
		AddSpawnPoint( "f_bracken_43_1.Id6", "f_bracken_43_1", Spot(-253.83742, -1618.7192, 40));
		AddSpawnPoint( "f_bracken_43_1.Id6", "f_bracken_43_1", Spot(-58.884956, -1644.7101, 40));
		AddSpawnPoint( "f_bracken_43_1.Id6", "f_bracken_43_1", Spot(-133.94493, -1471.6865, 40));
		AddSpawnPoint( "f_bracken_43_1.Id6", "f_bracken_43_1", Spot(-399.04153, -1640.6522, 40));
		AddSpawnPoint( "f_bracken_43_1.Id6", "f_bracken_43_1", Spot(-412.08133, -1433.2714, 40));
		AddSpawnPoint( "f_bracken_43_1.Id6", "f_bracken_43_1", Spot(-221.11551, -1767.7068, 40));
		AddSpawnPoint( "f_bracken_43_1.Id6", "f_bracken_43_1", Spot(-1145.9355, -1385.2249, 40));
		AddSpawnPoint( "f_bracken_43_1.Id6", "f_bracken_43_1", Spot(-1178.7212, -978.7819, 40));
		AddSpawnPoint( "f_bracken_43_1.Id6", "f_bracken_43_1", Spot(-932.04956, -1248.1746, 40));
		AddSpawnPoint( "f_bracken_43_1.Id6", "f_bracken_43_1", Spot(-1152.5908, -1186.4645, 40));
		AddSpawnPoint( "f_bracken_43_1.Id6", "f_bracken_43_1", Spot(-1359.7769, -1218.235, 40));
		AddSpawnPoint( "f_bracken_43_1.Id6", "f_bracken_43_1", Spot(-1015.9442, -1082.4384, 40));

	}
}
