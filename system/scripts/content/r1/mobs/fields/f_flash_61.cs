//--- Melia Script -----------------------------------------------------------
// f_flash_61
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Ruklys Street' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FFlash61MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("f_flash_61.Id1", MonsterId.Denden, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_61.Id2", MonsterId.Moyabu, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_61.Id3", MonsterId.Moyabu, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_61.Id4", MonsterId.Goblin2_Sword, 75, 100, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_61.Id5", MonsterId.Rootcrystal_01, 12, 15, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("f_flash_61.Id6", MonsterId.Denden, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Denden' GenType 4 Spawn Points
		AddSpawnPoint("f_flash_61.Id1", "f_flash_61", Rectangle(680.05054, 506.78558, 9999));

		// 'Moyabu' GenType 14 Spawn Points
		AddSpawnPoint("f_flash_61.Id2", "f_flash_61", Rectangle(707.4568, 562.4198, 9999));

		// 'Moyabu' GenType 15 Spawn Points
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(-26.846394, 144.46481, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(-873.78284, 521.1725, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(80.06322, 33.398285, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(-708.84686, 686.0736, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(-59.192757, 306.36768, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(-167.28596, 231.68616, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(-277.55502, 59.560436, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(-98.75648, 552.779, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(758.4052, 286.21246, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(986.61615, 503.99677, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(997.2119, 65.9746, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(910.6688, 346.27246, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(1163.7727, 373.52597, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(1011.8218, 263.77, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(776.3597, 90.47204, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(728.1092, 520.48004, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(-776.6952, 973.6053, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(-861.39496, 611.2524, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(-626.21423, 530.1691, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(-669.3697, 864.2978, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(-141.18436, 23.62234, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(-180.1683, 373.72693, 30));
		AddSpawnPoint("f_flash_61.Id3", "f_flash_61", Rectangle(232.48085, 92.90758, 30));

		// 'Goblin2_Sword' GenType 28 Spawn Points
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(865.9298, 72.19653, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(740.22504, 498.615, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(922.33954, 1115.7449, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-680.614, 686.14246, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(931.48834, 354.0558, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1110.5015, 419.52866, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-749.1333, 944.73193, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(737.2436, 292.34262, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-866.09875, 527.2362, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(800.48883, 975.72284, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(782.0739, 1295.8496, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1289.4385, 1275.4171, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1111.4706, 1080.0875, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1345.9747, 1078.2888, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1286.3666, 946.06714, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1012.413, 943.867, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1145.7031, 1196.8378, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(732.2515, 1126.0767, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-190.44238, 132.56683, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(65.38869, 94.72899, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-102.28584, 475.61288, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-212.27986, 954.6686, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(200.17114, 992.6059, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-79.42148, 682.5919, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-456.1257, 1187.16, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-550.34796, 1419.5294, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-630.7968, 1215.331, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-552.9607, 1031.775, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-38.97777, 1055.4476, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(340.56055, 1003.4566, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-822.65094, 566.80133, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-908.95264, 556.01746, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-915.97144, 596.8648, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-773.1682, 587.3714, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-780.74786, 517.55035, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-712.1504, 491.60303, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-656.8446, 549.32544, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-609.27203, 606.4729, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-678.46857, 618.672, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-732.82745, 639.7771, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-622.7903, 648.9887, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-618.1715, 731.1089, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-700.13116, 747.437, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-721.22504, 784.28107, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-600.0701, 779.47406, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-680.9476, 936.7219, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-754.6106, 1014.116, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-793.95734, 1025.2123, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-669.7668, 987.9516, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-604.5826, 1014.3192, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-542.70874, 954.54456, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-487.73627, 1003.8425, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-452.59387, 941.07764, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-430.7311, 1052.9734, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-525.2884, 1040.9252, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-502.80148, 1220.4658, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-551.86255, 1326.3043, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-619.5849, 1412.1492, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-642.86255, 1331.9573, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-599.90045, 1348.372, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-631.113, 1270.8528, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-721.8613, 1305.3977, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-729.4286, 1348.1412, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-712.75574, 1476.3281, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-484.748, 1336.691, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-480.79553, 1278.7811, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-413.4607, 1340.3878, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-332.6722, 1344.6205, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-347.47684, 1244.7489, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-386.6553, 1180.6699, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-298.9481, 1291.9895, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-262.43253, 1342.065, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-455.35434, 1235.1401, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-797.3255, 621.53345, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-916.0987, 656.5239, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-213.52612, 67.397964, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-183.52122, -79.26464, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-116.6646, -91.36447, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-56.905884, -88.0134, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1.4067535, -77.99443, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-96.546524, 5.437874, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-131.08873, 87.541115, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-113.76217, 165.94913, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-51.9568, 79.03598, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(2.0712922, 20.686804, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(17.469467, 84.19437, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(122.36372, 76.681175, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(210.66127, 2.267311, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(178.09229, 121.24588, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-59.913414, 216.8052, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-127.60793, 263.25287, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-130.31865, 336.79834, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-75.99682, 364.14996, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(24.214012, 346.50433, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-37.81916, 441.61304, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-120.50537, 409.89362, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-63.150326, 522.604, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-40.48957, 581.0544, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-103.41042, 620.94165, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-167.7453, 631.62305, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-103.83202, 728.1936, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-168.96613, 763.1612, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-149.68231, 566.3682, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-174.35703, 912.76965, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-175.7347, 1009.5587, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-242.12872, 1011.588, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-121.14639, 955.3456, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-25.41101, 925.01184, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(43.103302, 945.5329, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-61.037983, 1012.9687, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-122.47807, 1141.4648, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-105.37404, 1214.1841, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-106.60548, 1286.5656, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-136.0484, 1209.8241, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(-54.402065, 1275.9954, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(135.66048, 957.32336, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(126.5441, 1025.0139, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(59.64334, 1032.6045, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(94.92121, 932.34406, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(184.79478, 1047.2213, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(278.11365, 1036.1959, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(319.97223, 944.5277, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(414.7309, 994.6744, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(429.44226, 1068.6647, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(496.42612, 1029.163, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(804.3379, 1056.5028, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(925.1842, 1024.3229, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(846.28357, 1110.8433, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(772.4639, 1209.426, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(860.14856, 1290.9852, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(930.7605, 1334.7018, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(912.6367, 1166.9255, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1010.5393, 1175.274, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1009.4689, 1097.3472, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1026.4945, 1017.3035, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1096.1201, 975.65375, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1194.3121, 1013.4916, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1323.6012, 999.8144, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1275.0475, 1068.1881, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1311.0299, 1119.8633, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1343.8618, 1177.6555, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1251.3029, 1167.7281, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1362.1481, 1290.216, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1296.999, 1324.1681, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1197.6714, 1303.9689, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1105.5001, 1298.8124, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1086.7733, 1171.2456, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1077.2065, 1097.1094, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1002.1415, 1304.4496, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(834.36914, 1353.3722, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(931.9052, 74.3786, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1024.768, 2.3803797, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1061.7739, 52.075905, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1053.2719, 114.4998, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1055.8772, 165.59512, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(980.18, 120.94438, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(912.00244, 126.07729, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(861.34296, 94.18319, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(784.2728, 158.65697, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(792.13776, 217.12494, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(806.49097, 287.40323, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(771.417, 367.16156, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(700.89246, 385.10355, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(712.09576, 456.83347, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(811.16565, 470.7057, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(764.58386, 576.27295, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(688.751, 579.2506, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(833.5789, 576.8626, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(888.1312, 472.49292, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(830.28485, 370.15793, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(955.1111, 431.5315, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(895.2286, 389.4104, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1043.6772, 456.1964, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1044.2771, 373.43582, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1198.7031, 474.45984, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1219.0614, 410.81677, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1128.7583, 469.72943, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(1013.5507, 411.2771, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(827.21246, 523.7404, 25));
		AddSpawnPoint("f_flash_61.Id4", "f_flash_61", Rectangle(645.35187, 548.5061, 25));

		// 'Rootcrystal_01' GenType 32 Spawn Points
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(-879.0993, -198.8569, 100));
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(-706.40826, -37.386703, 100));
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(-227.24883, 51.003582, 100));
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(39.7983, 41.539093, 100));
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(-86.15958, 343.1754, 100));
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(-83.62241, 610.3693, 100));
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(-910.29974, 591.5304, 100));
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(-696.2348, 559.41364, 100));
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(-670.26825, 799.3536, 100));
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(-608.8063, 996.85004, 100));
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(-452.71533, 1310.7882, 100));
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(-85.24898, 1131.964, 100));
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(-34.52955, 991.5963, 100));
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(363.27853, 974.5624, 100));
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(817.72534, 1040.8306, 100));
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(1209.4456, 1124.1998, 100));
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(850.3391, 463.67865, 100));
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(914.78406, 74.136345, 100));
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(1133.3738, 109.82619, 100));
		AddSpawnPoint("f_flash_61.Id5", "f_flash_61", Rectangle(680.5179, 448.0243, 100));

		// 'Denden' GenType 33 Spawn Points
		AddSpawnPoint("f_flash_61.Id6", "f_flash_61", Rectangle(-571.6257, 1250.7571, 25));
		AddSpawnPoint("f_flash_61.Id6", "f_flash_61", Rectangle(-626.9714, 1466.0093, 25));
		AddSpawnPoint("f_flash_61.Id6", "f_flash_61", Rectangle(-575.34375, 993.9287, 25));
		AddSpawnPoint("f_flash_61.Id6", "f_flash_61", Rectangle(-409.04587, 1263.9386, 25));
		AddSpawnPoint("f_flash_61.Id6", "f_flash_61", Rectangle(-480.12628, 1387.232, 25));
		AddSpawnPoint("f_flash_61.Id6", "f_flash_61", Rectangle(247.1373, 966.5358, 25));
		AddSpawnPoint("f_flash_61.Id6", "f_flash_61", Rectangle(-235.4455, 1301.5746, 25));
		AddSpawnPoint("f_flash_61.Id6", "f_flash_61", Rectangle(-262.052, 906.0138, 25));
		AddSpawnPoint("f_flash_61.Id6", "f_flash_61", Rectangle(43.565956, 828.9807, 25));
		AddSpawnPoint("f_flash_61.Id6", "f_flash_61", Rectangle(-74.94126, 1135.4302, 25));
		AddSpawnPoint("f_flash_61.Id6", "f_flash_61", Rectangle(-148.33098, 720.21796, 25));
		AddSpawnPoint("f_flash_61.Id6", "f_flash_61", Rectangle(-703.1454, 571.58984, 25));
		AddSpawnPoint("f_flash_61.Id6", "f_flash_61", Rectangle(-782.502, 957.14923, 25));
		AddSpawnPoint("f_flash_61.Id6", "f_flash_61", Rectangle(-428.6655, 1077.8809, 25));
		AddSpawnPoint("f_flash_61.Id6", "f_flash_61", Rectangle(-663.01514, 773.2376, 25));
	}
}
