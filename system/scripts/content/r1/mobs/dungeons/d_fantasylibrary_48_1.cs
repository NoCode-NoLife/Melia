//--- Melia Script -----------------------------------------------------------
// d_fantasylibrary_48_1
//
//--- Description -----------------------------------------------------------
// Sets up the d_fantasylibrary_48_1 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DFantasylibrary481MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("d_fantasylibrary_48_1", MonsterId.Page_Mimic, Properties("MHP", 527238, "MINPATK", 7281, "MAXPATK", 8850, "MINMATK", 7281, "MAXMATK", 8850, "DEF", 91407, "MDEF", 91407));
		AddPropertyOverrides("d_fantasylibrary_48_1", MonsterId.Bookmark_Mimic, Properties("MHP", 528664, "MINPATK", 7299, "MAXPATK", 8872, "MINMATK", 7299, "MAXMATK", 8872, "DEF", 92112, "MDEF", 92112));
		AddPropertyOverrides("d_fantasylibrary_48_1", MonsterId.Oscuro, Properties("MHP", 530281, "MINPATK", 7320, "MAXPATK", 8898, "MINMATK", 7320, "MAXMATK", 8898, "DEF", 92912, "MDEF", 92912));
		AddPropertyOverrides("d_fantasylibrary_48_1", MonsterId.Claro, Properties("MHP", 532069, "MINPATK", 7343, "MAXPATK", 8926, "MINMATK", 7343, "MAXMATK", 8926, "DEF", 93796, "MDEF", 93796));

		// Monster Spawners --------------------------------

		AddSpawner("d_fantasylibrary_48_1.Id1", MonsterId.Rootcrystal_03, 30, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("d_fantasylibrary_48_1.Id2", MonsterId.Page_Mimic, 90, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_fantasylibrary_48_1.Id3", MonsterId.Bookmark_Mimic, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_fantasylibrary_48_1.Id4", MonsterId.Oscuro, 18, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_fantasylibrary_48_1.Id5", MonsterId.Claro, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_fantasylibrary_48_1.Id6", MonsterId.Oscuro, 22, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Rootcrystal_03 Spawn Points
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(-1185.7354, -1341.7122, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(-1232.0383, -1128.8507, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(-994.944, -1233.696, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(-1357.9894, -797.1861, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(-1483.0619, -575.7312, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(-1326.8502, -599.14264, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(-694.93945, -1072.9657, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(-688.0221, -760.1523, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(-687.43616, -601.983, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(-465.0639, -732.2627, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(-407.10333, -442.971, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(-485.2558, -349.2635, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(-838.99646, -492.131, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(-1069.0944, -473.25842, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(-1230.8302, -268.51614, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(-1291.2625, -95.42295, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(-1141.0251, -169.7276, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(-976.75275, 305.808, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(-1072.6936, 369.78085, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(-1022.8214, 545.5243, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(-946.767, 461.52054, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(-490.02148, 535.65814, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(-417.02936, 736.139, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(-136.4603, 732.5376, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(135.90709, 751.5229, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(-5.142975, 811.4363, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(-9.553326, 191.68384, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(-55.99802, 394.99948, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(145.15675, 333.13638, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(162.10397, 156.25627, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(921.85284, 168.4544, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(663.26227, 139.33458, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(888.87555, -29.05344, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(783.9178, 137.82306, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(695.6091, -90.726074, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(208.30945, -579.76166, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(101.56966, -407.56076, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(274.76263, -432.69034, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(1365.6548, -476.06714, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(1296.738, -371.39938, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(1466.7831, -409.64703, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(1458.4185, 59.663284, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(1320.8168, 91.268105, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(1332.783, 286.6177, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(1554.4382, 287.49432, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(1528.5155, 144.33379, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(1472.455, 806.0415, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(1291.6812, 908.243, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(1333.9205, 1061.7909, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(1551.6731, 1006.6996, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(1625.4999, 1111.2511, 100));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id1", "d_fantasylibrary_48_1", Spot(1451.1934, 958.7193, 100));

		// Page_Mimic Spawn Points
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-1075.2362, 363.38104, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-947.8259, 366.15768, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-956.2657, 477.74786, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-1136.6213, 498.93353, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-979.7728, 547.8223, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-1104.4531, 194.6977, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-1082.5164, 33.805992, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-1185.2637, 57.581818, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-1328.8308, 34.20107, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-1301.332, -141.15366, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-1221.7118, -47.042877, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-1128.8717, -201.93103, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-1372.5061, -486.84616, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-1315.8011, -609.2256, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-1455.7075, -628.9458, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-1478.11, -849.5564, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-1318.2849, -709.4169, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-1340.6223, -827.39136, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-1244.1653, -1124.9528, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-1243.295, -1281.8993, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-1062.7733, -1164.588, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-1129.6293, -1358.3208, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-995.4898, -1290.8978, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-1194.2483, -890.01886, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-811.54517, -488.92923, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-751.3271, -673.0237, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-606.1176, -542.89557, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-506.0554, -729.286, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-389.0311, -461.00583, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-521.3578, -352.8718, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-718.7545, -1280.7676, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-654.3987, -1199.5681, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-752.0935, -1133.9819, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-732.21484, -1023.837, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-565.0418, -1082.5511, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-1039.461, -490.35284, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(96.87449, -391.4953, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(67.21724, -553.71967, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(169.60126, -676.9924, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(317.08984, -623.21265, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(427.593, -419.8453, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(283.8696, -440.09692, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-588.0002, 760.4977, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-604.2064, 631.8744, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-430.4956, 786.8981, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-538.47064, 534.3905, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-399.13248, 567.31305, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-75.627914, 820.0121, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-100.58029, 728.38007, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-17.672504, 645.91785, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(124.51817, 811.5538, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(98.07447, 710.7767, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(2.5047188, 912.5152, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-67.88667, 127.88143, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(61.399944, 326.19598, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(58.054848, 195.32394, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(90.310074, 48.264442, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(233.06412, 233.32288, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(633.4991, -104.24464, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(785.4177, 51.29717, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(914.8459, 219.6844, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(773.4538, 231.71782, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(619.67596, 40.043663, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(874.9549, -63.399387, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(1317.9971, -421.1735, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(1428.3014, -501.22006, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(1513.7872, -381.61646, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(1396.9694, -153.86053, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(504.3125, -280.82666, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(772.75726, -156.84457, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(1285.803, 248.32414, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(1408.7124, 323.9434, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(1549.8458, 271.9305, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(1536.1995, 88.769035, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(1412.6742, 103.66716, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(1293.0479, -9.074061, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(1445.004, 659.41266, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(1568.9414, 791.5164, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(1370.2522, 811.215, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(1432.9806, 1035.4655, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(1238.4062, 945.0987, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(1649.3812, 1111.3132, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-745.1565, -356.23087, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-641.1188, -262.47025, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(597.0825, 192.14027, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-1433.985, 7.0457973, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(1055.658, 226.86714, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id2", "d_fantasylibrary_48_1", Spot(-390.42145, -620.72174, 40));

		// Bookmark_Mimic Spawn Points
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(-1296.1962, -1164.0667, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(-1314.7463, -1251.1235, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(-1269.1067, -1343.6188, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(-1174.4872, -1299.5862, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(-1178.817, -1172.5463, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(-1112.2991, -1278.4508, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(-979.2118, -1205.3213, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(-1144.3544, -1060.9003, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(-1035.1401, -1085.1127, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(-1212.7006, -1436.288, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(-855.5998, -536.78674, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(-837.1624, -630.085, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(-700.26105, -529.16547, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(-681.5087, -761.06506, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(-596.08923, -635.9631, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(-498.7841, -604.11316, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(-596.54626, -806.80164, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(-511.61722, -463.71454, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(-274.35535, -539.59784, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(-284.35886, -404.19156, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(-661.5409, -1104.8003, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(-768.3559, -1203.2655, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(-621.4262, -1228.258, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(-821.22894, -416.84387, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(-699.0936, -835.9741, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(-145.22057, -472.15024, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(-421.42114, -356.9673, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(1222.9298, 1047.6407, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(1324.147, 1155.2605, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(1247.9421, 803.081, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(1323.207, 985.1919, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(1397.2755, 907.4111, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(1472.3583, 732.7646, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(1611.3375, 645.3884, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(1621.8076, 880.8967, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(1486.6578, 871.9149, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(1505.8684, 967.2694, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(1660.747, 994.42786, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(1508.7065, 1103.991, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id3", "d_fantasylibrary_48_1", Spot(1657.2888, 1185.7212, 40));

		// Oscuro Spawn Points
		AddSpawnPoint( "d_fantasylibrary_48_1.Id4", "d_fantasylibrary_48_1", Spot(-1294.263, -47.33754, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id4", "d_fantasylibrary_48_1", Spot(-1302.7808, -213.77612, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id4", "d_fantasylibrary_48_1", Spot(-1225.8451, -283.2103, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id4", "d_fantasylibrary_48_1", Spot(-1214.0474, -179.00417, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id4", "d_fantasylibrary_48_1", Spot(-1061.4602, -143.45137, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id4", "d_fantasylibrary_48_1", Spot(-1104.0709, -84.39004, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id4", "d_fantasylibrary_48_1", Spot(-1176.8698, -114.90481, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id4", "d_fantasylibrary_48_1", Spot(-1257.9521, 98.22154, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id4", "d_fantasylibrary_48_1", Spot(-1138.8436, 388.0104, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id4", "d_fantasylibrary_48_1", Spot(-1053.9269, 269.75388, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id4", "d_fantasylibrary_48_1", Spot(-1016.2308, 321.24768, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id4", "d_fantasylibrary_48_1", Spot(-928.4165, 297.8427, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id4", "d_fantasylibrary_48_1", Spot(-1018.1418, 432.9991, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id4", "d_fantasylibrary_48_1", Spot(-890.93225, 450.36932, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id4", "d_fantasylibrary_48_1", Spot(-1072.646, 559.39813, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id4", "d_fantasylibrary_48_1", Spot(-1216.2316, 465.75244, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id4", "d_fantasylibrary_48_1", Spot(-898.2905, 536.1613, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id4", "d_fantasylibrary_48_1", Spot(-1042.875, 496.31113, 40));

		// Claro Spawn Points
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(-1494.2338, -512.7812, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(-1423.4053, -546.07574, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(-1515.7147, -683.88306, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(-1473.1852, -751.71564, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(-1403.2792, -688.13354, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(-1263.0643, -780.7483, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(-1253.2198, -493.9862, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(-1305.1473, -432.0887, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(108.30338, -468.4574, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(214.71503, -354.22766, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(172.54976, -596.49335, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(230.2154, -526.80884, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(365.42917, -525.42865, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(363.29663, -332.84372, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(67.228226, -654.6224, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(6.343074, -359.85156, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(562.17377, -34.29315, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(701.659, -1.3965111, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(762.46124, -53.974922, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(879.9763, -157.39958, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(957.2235, -35.819157, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(902.94006, 84.35065, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(709.2328, 142.1952, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(660.4812, 272.0003, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(1324.8339, -516.8073, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(1413.9717, -410.65927, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(1527.0394, -481.9508, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(599.0862, -173.6363, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(840.7003, 163.67146, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(480.5687, 225.6891, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(1248.9827, 356.5301, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(1511.6738, 359.44724, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(1247.9417, 72.938354, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(1244.9646, 172.81624, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(1324.0354, 147.42177, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(1421.0913, 229.07713, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(1399.4938, 9.986507, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(1581.6871, 6.779084, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(1508.8683, 182.81271, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id5", "d_fantasylibrary_48_1", Spot(1604.3977, 139.30017, 40));

		// Oscuro Spawn Points
		AddSpawnPoint( "d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Spot(-508.80075, 706.02106, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Spot(-412.85623, 651.6689, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Spot(-325.63855, 692.6896, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Spot(-600.94415, 497.9986, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Spot(-662.03046, 692.55396, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Spot(-392.10373, 504.1404, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Spot(-517.28656, 607.0341, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Spot(16.116726, 749.0335, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Spot(-87.98966, 658.56836, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Spot(58.717007, 658.9198, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Spot(-110.28278, 866.7561, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Spot(31.31849, 825.5935, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Spot(66.629326, 762.326, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Spot(-290.80777, 758.6355, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Spot(48.419834, 424.5542, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Spot(-153.67537, 238.4031, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Spot(-11.698877, 291.83398, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Spot(-99.16551, 181.25882, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Spot(114.17966, 258.16547, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Spot(-26.807487, 33.798588, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Spot(180.21811, 87.903824, 40));
		AddSpawnPoint( "d_fantasylibrary_48_1.Id6", "d_fantasylibrary_48_1", Spot(94.004166, 152.46884, 40));

	}
}
