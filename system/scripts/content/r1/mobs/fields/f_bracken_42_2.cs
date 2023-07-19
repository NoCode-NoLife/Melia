//--- Melia Script -----------------------------------------------------------
// f_bracken_42_2
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Khamadon Forest' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FBracken422MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("f_bracken_42_2.Id1", MonsterId.Rootcrystal_03, 10, 13, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_bracken_42_2.Id2", MonsterId.Duckey_Red, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_bracken_42_2.Id3", MonsterId.Moglan_Blue, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_bracken_42_2.Id4", MonsterId.Beetow_Blue, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_42_2.Id5", MonsterId.Beetow_Blue, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_03' GenType 2 Spawn Points
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(-1573.0035, 129.65483, 50));
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(-1250.2424, 95.754814, 50));
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(-981.1132, -255.0685, 50));
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(-453.0161, -632.27136, 50));
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(212.80057, -891.04346, 50));
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(495.81293, -853.3519, 50));
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(758.1792, -1121.811, 50));
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(1243.4575, -818.8038, 50));
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(1408.8849, -662.0159, 50));
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(-314.21246, 159.36862, 50));
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(495.2359, 222.95158, 50));
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(426.8892, -161.39853, 50));
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(1025.9182, -246.71349, 50));
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(1334.1215, 25.610603, 50));
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(-88.37146, 746.4058, 50));
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(164.527, 861.74115, 50));
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(705.85236, 790.7811, 50));
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(985.58716, 1092.198, 50));
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(1341.1576, 1493.9584, 50));
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(1479.3802, 1242.8739, 50));

		// 'Duckey_Red' GenType 101 Spawn Points
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(248.14198, -21.644905, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(335.89325, -160.05537, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(284.6933, 171.79147, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(434.0153, 10.310027, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(598.5636, -39.977802, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(494.25888, 215.59584, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(970.66907, -170.10365, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(953.608, -282.1728, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(1112.3434, -202.00493, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(1270.058, 26.525726, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(1310.056, -173.14873, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(1244.6604, -199.49995, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(468.0494, 77.048134, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(498.13824, -99.79641, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(1375.7814, -95.66629, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(1494.9523, -35.99508, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(1476.1537, -170.5049, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(1158.5735, -90.43046, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(-563.1732, -784.30457, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(-664.0004, -607.6256, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(-163.31477, -807.33307, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(1553.7129, -732.94635, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(1448.5509, -909.6342, 35));

		// 'Moglan_Blue' GenType 103 Spawn Points
		AddSpawnPoint("f_bracken_42_2.Id3", "f_bracken_42_2", Rectangle(654.6624, 917.0493, 50));
		AddSpawnPoint("f_bracken_42_2.Id3", "f_bracken_42_2", Rectangle(816.6692, 869.30865, 50));
		AddSpawnPoint("f_bracken_42_2.Id3", "f_bracken_42_2", Rectangle(883.8276, 1127.6001, 50));
		AddSpawnPoint("f_bracken_42_2.Id3", "f_bracken_42_2", Rectangle(925.03467, 821.4518, 50));
		AddSpawnPoint("f_bracken_42_2.Id3", "f_bracken_42_2", Rectangle(912.25397, 935.8704, 50));
		AddSpawnPoint("f_bracken_42_2.Id3", "f_bracken_42_2", Rectangle(1093.6849, 1027.1737, 50));
		AddSpawnPoint("f_bracken_42_2.Id3", "f_bracken_42_2", Rectangle(1336.6097, 1417.3257, 50));
		AddSpawnPoint("f_bracken_42_2.Id3", "f_bracken_42_2", Rectangle(1383.5593, 1255.6863, 50));
		AddSpawnPoint("f_bracken_42_2.Id3", "f_bracken_42_2", Rectangle(1655.0428, 1348.332, 50));
		AddSpawnPoint("f_bracken_42_2.Id3", "f_bracken_42_2", Rectangle(1439.9193, 1537.316, 50));
		AddSpawnPoint("f_bracken_42_2.Id3", "f_bracken_42_2", Rectangle(1567.9518, 1671.9521, 50));
		AddSpawnPoint("f_bracken_42_2.Id3", "f_bracken_42_2", Rectangle(1511.8213, 1320.6465, 50));
		AddSpawnPoint("f_bracken_42_2.Id3", "f_bracken_42_2", Rectangle(1561.6694, 1461.3402, 50));
		AddSpawnPoint("f_bracken_42_2.Id3", "f_bracken_42_2", Rectangle(1003.4771, 1037.9354, 50));
		AddSpawnPoint("f_bracken_42_2.Id3", "f_bracken_42_2", Rectangle(1026.3464, 922.0647, 50));
		AddSpawnPoint("f_bracken_42_2.Id3", "f_bracken_42_2", Rectangle(829.6833, 1011.236, 50));

		// 'Beetow_Blue' GenType 104 Spawn Points
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(-488.9465, -848.5402, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(-354.21597, -732.3331, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(-326.9518, -850.4773, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(245.26514, -1050.0217, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(383.2852, -1020.777, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(618.7226, -1043.9087, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(678.0132, -925.1292, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1322.2579, -728.39856, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1378.3351, -974.56494, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1222.153, -903.70966, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(-902.7318, -369.05505, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(-953.6632, -607.2612, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(-190.0548, -797.4713, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1594.798, -864.8814, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1628.2916, -978.4018, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1732.3386, -849.6776, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1751.74, -715.0495, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1634.3987, -721.31805, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1387.9717, -643.3899, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1513.0585, -783.60895, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(755.7065, -988.01, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(732.7097, -1119.201, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(550.846, -1210.9308, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(505.43292, -1112.1659, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(514.0731, -957.3523, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(300.59158, -1129.2168, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(191.6475, -892.7893, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(359.22873, -875.5429, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(303.30823, -750.27374, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(386.19247, -743.2476, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(506.08066, -850.5662, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(-130.3967, -781.702, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(-269.8102, -747.7947, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(-621.36, -847.83276, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(-564.2445, -662.16235, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(-821.0617, -806.04095, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(-692.65265, -648.73126, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(-877.412, -657.28864, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(-799.2665, -491.9299, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(-377.88773, -520.8724, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(-627.7078, -488.19022, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(-425.0463, -655.2627, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(967.65344, -238.40486, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1324.2189, -116.06969, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1184.79, -199.92561, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1042.8522, -306.70636, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1002.4421, -85.30559, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1076.2789, -112.73714, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1257.0687, -12.556347, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(427.57587, -138.45355, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(344.31354, -70.37733, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(277.9319, 5.6871414, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(342.3989, 150.94836, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(560.8062, -30.844097, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(467.093, 29.75897, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(623.79193, 133.08533, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1281.0614, 81.48419, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1426.0807, -167.09746, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1475.965, 29.751415, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(916.4817, 765.3505, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(711.7406, 696.70575, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1098.8749, 1030.205, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1063.3239, 875.9713, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(909.19495, 886.3331, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(620.1944, 852.31, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(757.9346, 807.45074, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(746.4963, 951.4197, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(828.8187, 1085.8594, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(923.103, 1087.9375, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1333.0314, 1189.8239, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1635.24, 1462.0945, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1526.9993, 1220.6362, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1493.4574, 1557.2163, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1444.8118, 1355.8417, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1818.5531, 1405.8987, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1297.9703, 1420.8259, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1622.0239, 1609.6929, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1347.8971, 1579.6858, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1510.7686, 1710.4148, 30));

		// 'Beetow_Blue' GenType 105 Spawn Points
		AddSpawnPoint("f_bracken_42_2.Id5", "f_bracken_42_2", Rectangle(296.38492, 79.274315, 9999));
	}
}
