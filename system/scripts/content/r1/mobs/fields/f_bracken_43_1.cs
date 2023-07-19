//--- Melia Script -----------------------------------------------------------
// f_bracken_43_1
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Arcus Forest' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FBracken431MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("f_bracken_43_1.Id1", MonsterId.Rakon, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_1.Id2", MonsterId.Rootcrystal_01, 12, 15, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_1.Id3", MonsterId.Toothrikon, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_1.Id4", MonsterId.Horn_Golem, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_1.Id5", MonsterId.Rakon, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_1.Id6", MonsterId.Rakon, 9, 12, TimeSpan.FromMilliseconds(40000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rakon' GenType 27 Spawn Points
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-201.10962, -1565.874, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-182.62766, -1419.226, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-268.03784, -1742.28, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-425.24585, -1547.6825, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-1320.5498, -1054.7826, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-1158.1198, -1395.1332, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-1068.7684, -1079.1669, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(93.407486, -1351.7948, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(293.95538, -1153.4263, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-137.3461, -833.40967, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-119.86803, -237.4283, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(95.62465, -700.88586, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-287.23425, -51.0357, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(355.93625, 923.48926, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-792.057, 200.517, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-1098.6155, 350.86688, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-1324.4081, 409.73816, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-1439.3324, -125.22323, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-1612.8224, -183.59296, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-2082.1655, -284.15198, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-1235.473, -209.72525, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-1276.7964, 532.1956, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-652.4914, 773.9195, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-421.93823, 777.60345, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-261.42715, 795.8934, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(321.87225, 741.07056, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(456.40585, 644.44, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(555.5346, 824.93976, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(685.7234, 764.9966, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(1093.3146, 734.5813, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(912.9551, -12.620995, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(697.62134, 46.559143, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(1051.572, 158.9338, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(927.99115, -670.6167, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(702.22675, -650.85565, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(688.5691, -888.3728, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(942.9141, -831.39746, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(1064.2716, -538.4112, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-1638.076, -344.7355, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-1867.7069, -326.23907, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-1619.6066, 426.3294, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-1386.2704, 677.1264, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-278.90192, -242.11124, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-333.47614, -417.2779, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-10.908813, -471.33932, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-138.55508, -409.56824, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-1067.3983, -1233.52, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-1109.8132, -851.2137, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(853.01953, -488.0896, 40));

		// 'Rootcrystal_01' GenType 28 Spawn Points
		AddSpawnPoint("f_bracken_43_1.Id2", "f_bracken_43_1", Rectangle(976.3353, 51.72992, 40));
		AddSpawnPoint("f_bracken_43_1.Id2", "f_bracken_43_1", Rectangle(674.6178, 109.41093, 40));
		AddSpawnPoint("f_bracken_43_1.Id2", "f_bracken_43_1", Rectangle(1141.3834, 767.2179, 40));
		AddSpawnPoint("f_bracken_43_1.Id2", "f_bracken_43_1", Rectangle(1071.8148, 1284.0928, 40));
		AddSpawnPoint("f_bracken_43_1.Id2", "f_bracken_43_1", Rectangle(592.0737, 688.9888, 40));
		AddSpawnPoint("f_bracken_43_1.Id2", "f_bracken_43_1", Rectangle(-500.81097, 776.296, 40));
		AddSpawnPoint("f_bracken_43_1.Id2", "f_bracken_43_1", Rectangle(-1355.9724, 489.5949, 40));
		AddSpawnPoint("f_bracken_43_1.Id2", "f_bracken_43_1", Rectangle(-1454.1464, -257.77573, 40));
		AddSpawnPoint("f_bracken_43_1.Id2", "f_bracken_43_1", Rectangle(-1090.8535, -1211.8457, 40));
		AddSpawnPoint("f_bracken_43_1.Id2", "f_bracken_43_1", Rectangle(-154.5099, -1577.7433, 40));
		AddSpawnPoint("f_bracken_43_1.Id2", "f_bracken_43_1", Rectangle(247.22038, -1201.6904, 40));
		AddSpawnPoint("f_bracken_43_1.Id2", "f_bracken_43_1", Rectangle(-138.12505, -819.8081, 40));
		AddSpawnPoint("f_bracken_43_1.Id2", "f_bracken_43_1", Rectangle(-168.49716, -452.2237, 40));
		AddSpawnPoint("f_bracken_43_1.Id2", "f_bracken_43_1", Rectangle(-356.4398, -95.96916, 40));
		AddSpawnPoint("f_bracken_43_1.Id2", "f_bracken_43_1", Rectangle(291.46884, 852.4863, 40));

		// 'Toothrikon' GenType 29 Spawn Points
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(-236.67085, -307.5888, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(-1126.4773, -1204.7615, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(-113.31483, -1552.7072, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(-210.34459, -830.30035, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(455.60437, -1105.639, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(644.5506, -667.06616, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(1175.5468, 756.8555, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(1121.6218, 1128.8394, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(-1225.4977, -1302.1694, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(-403.05017, -1567.2328, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(1037.3383, -684.83344, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(908.9933, 1502.844, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(-19.691362, -712.1917, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(-320.27097, -440.72473, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(-350.96802, -39.745514, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(12.415304, -581.33185, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(658.6017, -937.3071, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(911.08746, -491.6918, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(646.8882, 43.382877, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(900.9634, 297.34787, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(928.6691, 61.447433, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(745.94385, 171.33868, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(-238.38904, -1484.6989, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(-255.11124, -1704.7784, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(-1116.879, -966.3063, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(-1265.6372, -1074.102, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(211.08305, -1231.7257, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(894.91095, 1095.4514, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(1098.4464, 1422.8912, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(984.92944, 1314.1084, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(1021.2712, 734.68866, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(1100.9308, 928.2888, 40));

		// 'Horn_Golem' GenType 33 Spawn Points
		AddSpawnPoint("f_bracken_43_1.Id4", "f_bracken_43_1", Rectangle(-1133.0795, -994.4703, 100));
		AddSpawnPoint("f_bracken_43_1.Id4", "f_bracken_43_1", Rectangle(-409.95096, -1577.8158, 100));
		AddSpawnPoint("f_bracken_43_1.Id4", "f_bracken_43_1", Rectangle(-26.608042, -840.94507, 100));
		AddSpawnPoint("f_bracken_43_1.Id4", "f_bracken_43_1", Rectangle(-297.32047, -191.45364, 100));
		AddSpawnPoint("f_bracken_43_1.Id4", "f_bracken_43_1", Rectangle(-1465.9807, -283.80713, 100));
		AddSpawnPoint("f_bracken_43_1.Id4", "f_bracken_43_1", Rectangle(-1425.0685, 768.8743, 100));
		AddSpawnPoint("f_bracken_43_1.Id4", "f_bracken_43_1", Rectangle(-534.3695, 850.77466, 100));
		AddSpawnPoint("f_bracken_43_1.Id4", "f_bracken_43_1", Rectangle(762.07, 175.78539, 100));
		AddSpawnPoint("f_bracken_43_1.Id4", "f_bracken_43_1", Rectangle(912.4917, 267.71463, 100));
		AddSpawnPoint("f_bracken_43_1.Id4", "f_bracken_43_1", Rectangle(829.2461, -643.10724, 100));
		AddSpawnPoint("f_bracken_43_1.Id4", "f_bracken_43_1", Rectangle(700.7716, -970.5183, 100));
		AddSpawnPoint("f_bracken_43_1.Id4", "f_bracken_43_1", Rectangle(174.58318, -1288.1376, 100));
		AddSpawnPoint("f_bracken_43_1.Id4", "f_bracken_43_1", Rectangle(-96.503555, -1523.8176, 100));
		AddSpawnPoint("f_bracken_43_1.Id4", "f_bracken_43_1", Rectangle(-1077.3912, -1249.9329, 100));
		AddSpawnPoint("f_bracken_43_1.Id4", "f_bracken_43_1", Rectangle(-1365.8256, 418.5318, 100));

		// 'Rakon' GenType 34 Spawn Points
		AddSpawnPoint("f_bracken_43_1.Id5", "f_bracken_43_1", Rectangle(-267.93393, -279.13068, 9999));

		// 'Rakon' GenType 35 Spawn Points
		AddSpawnPoint("f_bracken_43_1.Id6", "f_bracken_43_1", Rectangle(-253.83742, -1618.7192, 40));
		AddSpawnPoint("f_bracken_43_1.Id6", "f_bracken_43_1", Rectangle(-58.884956, -1644.7101, 40));
		AddSpawnPoint("f_bracken_43_1.Id6", "f_bracken_43_1", Rectangle(-133.94493, -1471.6865, 40));
		AddSpawnPoint("f_bracken_43_1.Id6", "f_bracken_43_1", Rectangle(-399.04153, -1640.6522, 40));
		AddSpawnPoint("f_bracken_43_1.Id6", "f_bracken_43_1", Rectangle(-412.08133, -1433.2714, 40));
		AddSpawnPoint("f_bracken_43_1.Id6", "f_bracken_43_1", Rectangle(-221.11551, -1767.7068, 40));
		AddSpawnPoint("f_bracken_43_1.Id6", "f_bracken_43_1", Rectangle(-1145.9355, -1385.2249, 40));
		AddSpawnPoint("f_bracken_43_1.Id6", "f_bracken_43_1", Rectangle(-1178.7212, -978.7819, 40));
		AddSpawnPoint("f_bracken_43_1.Id6", "f_bracken_43_1", Rectangle(-932.04956, -1248.1746, 40));
		AddSpawnPoint("f_bracken_43_1.Id6", "f_bracken_43_1", Rectangle(-1152.5908, -1186.4645, 40));
		AddSpawnPoint("f_bracken_43_1.Id6", "f_bracken_43_1", Rectangle(-1359.7769, -1218.235, 40));
		AddSpawnPoint("f_bracken_43_1.Id6", "f_bracken_43_1", Rectangle(-1015.9442, -1082.4384, 40));
	}
}
