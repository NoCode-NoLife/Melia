//--- Melia Script -----------------------------------------------------------
// f_flash_64
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Inner Enceinte District' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FFlash64MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_flash_64", MonsterId.Repusbunny, Properties("MHP", 277296, "MINPATK", 4067, "MAXPATK", 4900, "MINMATK", 4067, "MAXMATK", 4900, "DEF", 17096, "MDEF", 17096));
		AddPropertyOverrides("f_flash_64", MonsterId.Lemuria, Properties("MHP", 278513, "MINPATK", 4083, "MAXPATK", 4919, "MINMATK", 4083, "MAXMATK", 4919, "DEF", 17322, "MDEF", 17322));
		AddPropertyOverrides("f_flash_64", MonsterId.Rubabos, Properties("MHP", 279820, "MINPATK", 4100, "MAXPATK", 4940, "MINMATK", 4100, "MAXMATK", 4940, "DEF", 17564, "MDEF", 17564));
		AddPropertyOverrides("f_flash_64", MonsterId.Saltisdaughter_Bow, Properties("MHP", 281211, "MINPATK", 4117, "MAXPATK", 4962, "MINMATK", 4117, "MAXMATK", 4962, "DEF", 17822, "MDEF", 17822));
		AddPropertyOverrides("f_flash_64", MonsterId.Boss_Gargoyle, Properties("MHP", 1441682, "MINPATK", 5708, "MAXPATK", 6880, "MINMATK", 5708, "MAXMATK", 6880, "DEF", 0, "MDEF", 0));

		// Monster Spawners ---------------------------------

		AddSpawner("f_flash_64.Id1", MonsterId.Repusbunny, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_64.Id2", MonsterId.Lemuria, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_64.Id3", MonsterId.Rubabos, 6, 7, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_64.Id4", MonsterId.Lemuria, 12, 16, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_64.Id5", MonsterId.Repusbunny, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_64.Id6", MonsterId.Lemuria, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_64.Id7", MonsterId.Saltisdaughter_Bow, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_64.Id8", MonsterId.Rootcrystal_01, 12, 15, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("f_flash_64.Id9", MonsterId.Lemuria, 57, 76, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Repusbunny' GenType 2 Spawn Points
		AddSpawnPoint("f_flash_64.Id1", "f_flash_64", Rectangle(2.922346, -403.21832, 9999));

		// 'Lemuria' GenType 3 Spawn Points
		AddSpawnPoint("f_flash_64.Id2", "f_flash_64", Rectangle(-1197.5253, -135.91139, 9999));

		// 'Rubabos' GenType 4 Spawn Points
		AddSpawnPoint("f_flash_64.Id3", "f_flash_64", Rectangle(1413.1438, 730.05304, 30));
		AddSpawnPoint("f_flash_64.Id3", "f_flash_64", Rectangle(1175.2695, 1232.0721, 30));
		AddSpawnPoint("f_flash_64.Id3", "f_flash_64", Rectangle(1384.4603, 606.6499, 30));
		AddSpawnPoint("f_flash_64.Id3", "f_flash_64", Rectangle(980.26105, 535.4708, 30));
		AddSpawnPoint("f_flash_64.Id3", "f_flash_64", Rectangle(1494.132, -155.14226, 30));
		AddSpawnPoint("f_flash_64.Id3", "f_flash_64", Rectangle(1325.4114, 136.491, 30));
		AddSpawnPoint("f_flash_64.Id3", "f_flash_64", Rectangle(1047.1973, 62.87476, 30));

		// 'Lemuria' GenType 5 Spawn Points
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(-1024.0812, -213.94582, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(-1352.6835, -104.41146, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(81.7081, -615.8475, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(-260.31766, -531.64343, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(-41.30572, -776.3549, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(-491.06415, -632.56366, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(-1195.466, -207.91722, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(-1228.6001, 321.58252, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(-143.4604, 1942.5333, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(-177.15794, 1106.6495, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(-165.22282, 1272.2194, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(-537.6564, 354.72372, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(-1068.7043, 561.75806, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(-819.1666, 714.42786, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(-1053.5483, 693.7667, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(-431.9957, 948.6837, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(-559.75586, 806.0722, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(946.59937, 621.74896, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(1016.8873, 393.10745, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(1491.7635, 444.5794, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(1483.8319, 630.0017, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(1191.1903, 1225.1019, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(742.91693, 997.93835, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(1116.224, -83.29331, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(1192.2927, 88.58647, 30));
		AddSpawnPoint("f_flash_64.Id4", "f_flash_64", Rectangle(1549.5038, 21.344051, 30));

		// 'Repusbunny' GenType 6 Spawn Points
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(-1323.2312, -249.53926, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(-325.85956, -560.6925, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(10.911163, -599.27783, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(-59.654114, -1783.6652, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(-1002.4113, -303.221, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(-1260.8906, 248.88449, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(-580.9928, 353.76157, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(-149.98402, 732.32355, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(-199.92453, 532.3829, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(-287.12796, 1597.9806, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(-174.09346, 1754.4689, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(-117.00591, 1637.4586, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(-65.70229, -374.00043, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(326.63297, -1240.3042, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(1363.5802, 50.733124, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(1470.1818, -49.135223, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(1214.2572, -127.15305, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(1022.4584, -23.975578, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(1098.3693, 433.98007, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(926.7431, 691.61487, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(1463.1149, 521.0492, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(-70.69313, 1555.3091, 30));
		AddSpawnPoint("f_flash_64.Id5", "f_flash_64", Rectangle(-39.051033, 1878.3032, 30));

		// 'Lemuria' GenType 18 Spawn Points
		AddSpawnPoint("f_flash_64.Id6", "f_flash_64", Rectangle(1129.5546, 351.57373, 20));
		AddSpawnPoint("f_flash_64.Id6", "f_flash_64", Rectangle(916.92474, 562.54834, 20));
		AddSpawnPoint("f_flash_64.Id6", "f_flash_64", Rectangle(1342.4281, 782.92755, 20));
		AddSpawnPoint("f_flash_64.Id6", "f_flash_64", Rectangle(1560.8351, 689.8415, 20));
		AddSpawnPoint("f_flash_64.Id6", "f_flash_64", Rectangle(1384.7365, 454.7086, 20));
		AddSpawnPoint("f_flash_64.Id6", "f_flash_64", Rectangle(1164.461, 660.6064, 20));

		// 'Saltisdaughter_Bow' GenType 22 Spawn Points
		AddSpawnPoint("f_flash_64.Id7", "f_flash_64", Rectangle(-165.85931, 1070.0682, 35));
		AddSpawnPoint("f_flash_64.Id7", "f_flash_64", Rectangle(-331.73062, 1714.0798, 35));
		AddSpawnPoint("f_flash_64.Id7", "f_flash_64", Rectangle(-4.674095, 1774.2219, 35));
		AddSpawnPoint("f_flash_64.Id7", "f_flash_64", Rectangle(-256.17447, 1894.7747, 35));
		AddSpawnPoint("f_flash_64.Id7", "f_flash_64", Rectangle(32.742096, 1581.0337, 35));
		AddSpawnPoint("f_flash_64.Id7", "f_flash_64", Rectangle(-164.75478, 790.64386, 35));
		AddSpawnPoint("f_flash_64.Id7", "f_flash_64", Rectangle(-375.7107, 646.6669, 35));
		AddSpawnPoint("f_flash_64.Id7", "f_flash_64", Rectangle(-1164.0902, 199.9399, 35));
		AddSpawnPoint("f_flash_64.Id7", "f_flash_64", Rectangle(-766.92816, 358.9884, 35));
		AddSpawnPoint("f_flash_64.Id7", "f_flash_64", Rectangle(-169.84448, 1518.7546, 35));
		AddSpawnPoint("f_flash_64.Id7", "f_flash_64", Rectangle(-389.85767, 907.8574, 35));
		AddSpawnPoint("f_flash_64.Id7", "f_flash_64", Rectangle(-251.10896, 630.49493, 35));
		AddSpawnPoint("f_flash_64.Id7", "f_flash_64", Rectangle(-1421.2437, -132.30406, 35));
		AddSpawnPoint("f_flash_64.Id7", "f_flash_64", Rectangle(-1124.9392, -233.07852, 35));
		AddSpawnPoint("f_flash_64.Id7", "f_flash_64", Rectangle(-1150.2085, -356.33875, 35));

		// 'Rootcrystal_01' GenType 29 Spawn Points
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(-130.48637, -1794.9576, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(-100.48663, -2324.6294, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(-365.8913, -1609.2825, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(50.647453, -1493.5723, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(-254.3784, -575.82086, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(-146.12064, -431.64102, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(3.5336227, -624.091, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(-200.15863, 91.453964, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(338.90234, 477.16855, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(-754.98566, 374.95395, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(-1117.9805, 250.69211, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(-1355.5911, -64.11034, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(-1134.9783, -283.45334, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(-1085.9326, -530.1125, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(-944.4016, 632.76, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(-320.47232, 725.61554, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(-102.45889, 754.0525, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(-115.78514, 1559.5238, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(72.8138, 1683.4578, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(-107.78929, 1925.486, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(-291.37003, 1900.6437, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(-165.5112, 1062.4564, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(1478.2347, -12.402458, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(1146.7697, 17.487457, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(1083.7458, 376.46875, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(1431.1526, 654.1856, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(846.9519, 685.37244, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(1184.3834, 1155.8767, 100));
		AddSpawnPoint("f_flash_64.Id8", "f_flash_64", Rectangle(627.676, 325.7066, 100));

		// 'Lemuria' GenType 38 Spawn Points
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-442.65744, -1663.4047, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-394.22076, -1416.6233, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-131.50145, -1726.4589, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-46.495506, -1426.3657, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(35.817116, -1479.447, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-62.50923, -1641.6918, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-149.18584, -1384.3422, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-88.52362, -1860.3363, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-47.97405, -1947.3274, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-72.842186, -2045.7385, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-256.96768, -1796.2709, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(45.88829, -1599.4175, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-333.80646, -1639.6852, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-187.4259, -1831.1416, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-205.95348, -1696.5107, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-189.02597, -1498.637, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-93.38573, -1528.0867, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-294.99115, -1717.1895, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-328.33392, -1527.994, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-280.04166, -1353.3464, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-192.29657, -1608.3595, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-45.039894, -1730.4165, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(52.988026, -708.9233, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(83.80802, -486.36197, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-16.3741, -511.44678, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-132.94682, -299.64642, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-192.71469, -383.9697, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-360.4666, -652.20154, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-444.29532, -541.2376, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-355.2077, -473.13654, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-273.77844, -385.18512, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-165.39404, -502.5204, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-87.41429, -443.37097, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-238.30962, -667.1801, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-159.44368, -590.272, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-77.73103, -598.5369, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-71.93122, -699.3899, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-1381.675, -202.33118, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-1231.6514, -291.48807, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-1076.5885, -291.23996, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-1052.714, -404.2445, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-965.28064, -353.9015, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-923.3232, -276.8412, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-1293.0127, -181.59824, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-1272.387, -92.59572, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-1128.8767, -88.466286, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-1064.2509, -161.31912, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-1008.5262, 153.92014, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-1114.7162, 296.96213, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-1118.3488, 92.4439, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-1254.741, 149.25642, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-1019.7904, 270.20712, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-967.98737, 616.9267, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-1122.4512, 647.2152, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-938.6697, 690.5464, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-848.78485, 640.80597, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-880.7145, 560.7828, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-366.50818, 745.61176, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-262.6814, 759.1822, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-222.09392, 688.6512, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-102.94337, 678.83856, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(-116.6833, 601.123, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(1295.7604, -6.1495667, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(1441.1116, 87.34317, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(1319.6436, -165.24208, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(1376.8214, -101.93327, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(1189.8523, -28.54551, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(846.3988, 550.4573, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(993.60046, 676.759, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(1280.5099, 737.6773, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(1277.7197, 631.59045, 20));
		AddSpawnPoint("f_flash_64.Id9", "f_flash_64", Rectangle(1553.2421, 555.4919, 20));
	}
}
