//--- Melia Script -----------------------------------------------------------
// d_underaqueduct
//
//--- Description -----------------------------------------------------------
// Sets up the d_underaqueduct mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DUnderaqueductMobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("d_underaqueduct.Id1", MonsterId.Chesha_Papa, 60, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underaqueduct.Id2", MonsterId.Chesha_Venom, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underaqueduct.Id3", MonsterId.Chesha_Torso, 50, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underaqueduct.Id4", MonsterId.Chesha_Riel, 40, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underaqueduct.Id5", MonsterId.Chesha_Needle, 40, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underaqueduct.Id6", MonsterId.Chesha_Papa, 60, TimeSpan.FromMilliseconds(1000), TendencyType.Aggressive);
		AddSpawner("d_underaqueduct.Id7", MonsterId.Gimmick_Mon_Chesha_Venom, 1, TimeSpan.FromMilliseconds(3000), TendencyType.Aggressive);
		AddSpawner("d_underaqueduct.Id8", MonsterId.Rootcrystal_04, 23, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Chesha_Papa Spawn Points
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1826.8374, 779.5803, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1693.1727, 734.8125, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1719.7115, 628.32367, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1787.5076, 583.3524, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1617.4772, 537.5915, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1800.7314, 1155.2173, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1786.857, 1352.5496, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1713.9935, 1251.189, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1672.8434, 1375.522, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1592.7261, 1246.3434, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1640.009, 1149.2191, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1573.1858, 649.1983, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1814.2118, -267.55038, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1703.8951, -369.39084, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1735.0751, -269.67184, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1524.4092, -418.6329, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1809.9159, -397.33728, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1833.9948, -488.6418, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1718.0847, -26.50821, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1979.3038, 134.00572, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1703.0217, 124.51882, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1338.059, 105.3586, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-855.82745, 118.62968, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1191.6348, 144.02768, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1115.8926, -35.06709, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-995.35516, 133.90868, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1093.2435, -131.88388, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1056.1393, 246.93086, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-673.17126, 126.34292, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-361.5921, 147.17207, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-431.25192, 96.787735, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1701.2231, -515.74084, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1549.1947, -502.45148, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1525.8446, -252.27264, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1573.2183, 756.7534, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1822.8383, 703.3119, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1848.6737, 1253.5776, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1584.7322, 1326.7753, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1546.1842, 1140.146, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1532.4132, 522.173, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1716.8271, 416.05112, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1777.5978, 518.6226, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1815.4589, 141.22153, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1649.399, -258.43814, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1618.9265, -446.46994, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1758.9672, -414.37665, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1853.2361, -328.51025, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1662.0112, -309.96674, 30));
		AddSpawnPoint( "d_underaqueduct.Id1", "d_underaqueduct", Spot(-1577.3462, -339.88025, 30));

		// Chesha_Venom Spawn Points
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(-1695.9958, -25.309282, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(-1694.0502, 63.910408, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(-1719.229, 211.57835, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(-1490.8344, 119.8835, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(-1358.8505, 173.2102, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(-1177.5117, 92.60662, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(-1083.946, 140.5504, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(-923.70337, 106.336, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(-203.60388, 112.60336, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(-788.4599, 141.82256, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(-659.2187, 84.239105, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(-437.0867, 177.31148, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(-486.29352, 76.74697, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(-339.25174, 78.32702, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(-105.39189, 160.34482, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(8.280613, 14.446465, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(243.33096, 90.9323, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(551.3779, 140.71817, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(412.58456, 101.01745, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(664.9337, 58.75259, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(773.6407, 134.94133, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(878.2882, 67.72602, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(941.69116, 157.43437, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(113.18425, 150.96115, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(682.3887, 165.73224, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(6.6931906, -91.721405, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(11.9104, 263.87494, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(-19.951687, 108.60359, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(-1069.4465, -46.59986, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(-1187.9053, 168.74068, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(-1034.367, 224.6381, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(-675.5659, 171.92491, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(-558.86005, 124.75812, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(-290.70132, 160.52501, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(-136.83061, 57.446236, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(-1323.6877, 100.17833, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(-1611.1455, 103.27863, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(291.28305, 165.04996, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(1075.3018, 85.24079, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(1160.2229, 160.59117, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(-1088.2161, 36.831154, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(-1121.0782, -101.74016, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(-1097.6825, 388.116, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(-1258.958, 134.58798, 30));
		AddSpawnPoint( "d_underaqueduct.Id2", "d_underaqueduct", Spot(-1847.0789, 127.22501, 30));

		// Chesha_Torso Spawn Points
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-1064.4653, 652.1723, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-1103.8638, 823.1759, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-1084.1409, 478.31427, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-1007.6812, 736.2113, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-1094.9249, 187.56071, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-1096.2406, -587.9452, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-1046.5216, -175.87195, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-1515.8921, 112.54507, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-1035.2842, -435.42, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-480.50665, 86.76662, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-132.78664, 138.53745, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(136.8636, 98.49064, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-105.60062, 489.59323, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-154.05307, 835.8767, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(135.66608, 696.92285, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(164.25743, 442.7664, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(231.49905, 744.5811, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-85.08519, 726.59216, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-137.76505, 673.1328, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-9.209334, 393.5239, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-1051.5024, 1018.3759, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-1187.8029, 1104.9941, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-890.6867, 1306.5001, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-936.50635, 1221.4762, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-1069.7197, 1125.5652, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-1044.7714, 1260.8329, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-1171.1809, 1253.134, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(96.08481, 497.4485, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-221.82916, -676.4772, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(83.33712, -543.62915, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-114.05815, -582.50836, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-104.27077, -365.76935, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(91.96906, -469.20053, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(129.36409, -370.1218, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(26.952076, -246.42148, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(250.96841, -201.804, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(242.5476, -445.86227, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(193.60738, -685.0945, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-26.80978, 819.4423, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(204.80322, 865.7294, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(104.34835, 809.97205, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-204.78445, 601.4331, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(576.75116, 87.75606, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(915.89417, 90.46093, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-1097.0214, 346.20734, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-1033.8301, 476.93503, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-1073.0671, 632.4912, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(31.864864, 721.935, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(279.06256, 700.2765, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(242.43692, 578.5975, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(69.06597, 404.11533, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-193.90172, 498.15137, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-101.84743, 570.8786, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-204.5824, 709.27985, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(102.98524, 613.90137, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(234.99493, 498.48804, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-66.24615, -692.98346, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(80.99663, -687.32556, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(226.91753, -603.0607, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(246.19875, -346.64795, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-228.03651, -194.80003, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-186.56001, -387.9159, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-239.211, -474.94843, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(31.753786, -381.62885, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(171.89702, -477.2773, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(176.66101, -297.66318, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-195.22423, -276.22598, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(149.72894, -189.51447, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-190.72327, -590.1678, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(157.07167, -616.907, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-106.02811, -479.13834, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-0.72429144, -600.4133, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-89.29871, -267.01385, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-1099.209, -309.39014, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-1028.1973, -251.9543, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-1061.9316, -509.8226, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-1044.3274, -349.811, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-1032.3795, 37.18006, 30));
		AddSpawnPoint( "d_underaqueduct.Id3", "d_underaqueduct", Spot(-1023.5231, -111.0784, 30));

		// Chesha_Riel Spawn Points
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1222.0981, 632.42865, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1490.1449, 529.46094, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1450.8843, 632.91205, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1596.3865, 523.40247, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1309.293, 330.21448, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(993.93115, 375.36972, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(848.74756, 303.24234, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1068.7332, 755.13727, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1067.6533, 945.039, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1257.1254, 1171.1609, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1461.7518, 933.16547, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1377.0934, 1111.0437, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1545.6769, 929.46954, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1267.3064, 942.88916, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1239.581, 1038.1672, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1538.5009, 1070.1915, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1526.712, 1227.345, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1471.9402, 1110.4573, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1354.9557, 1212.4291, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1342.355, 620.59656, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1270.7206, 535.4606, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1006.9037, 564.96765, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1010.7322, 862.2678, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1063.2568, 1135.2277, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(726.0048, 467.01196, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(722.2494, 148.16597, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1045.7981, 160.80035, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1060.6859, 67.549774, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1220.5803, 98.06753, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1292.1405, 172.33223, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(376.76675, 115.87434, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1423.7693, 371.51218, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1470.2498, 447.1837, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1554.327, 595.4927, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1591.8425, 366.06757, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1376.3097, 938.3081, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1455.2316, 1021.1074, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1575.613, 1166.4114, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1573.1266, 992.63837, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1456.7294, 1178.4677, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1136.0533, 1026.6427, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1050.2543, 1033.1299, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1013.1548, 679.3871, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1317.6842, 416.16345, 30));
		AddSpawnPoint( "d_underaqueduct.Id4", "d_underaqueduct", Spot(1324.2528, 77.20356, 30));

		// Chesha_Needle Spawn Points
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(699.1003, -251.67783, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(318.1587, 99.85462, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(483.64026, 174.43347, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(745.91595, 61.111263, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(1002.1744, -247.81873, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(993.4248, -482.99146, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(789.67444, -701.31415, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(694.2554, -589.37646, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(694.76715, -699.04425, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(875.57306, -699.26776, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(1054.4945, -647.1549, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(1213.9813, -639.7274, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(1311.6268, -744.71246, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(1399.5748, -697.47766, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(1263.1351, -541.18176, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(1219.6357, -301.45258, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(1313.0725, -299.70172, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(1386.4729, -126.46066, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(1240.0133, -209.02618, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(693.79596, -326.11877, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(655.0588, -161.42276, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(1058.7855, -96.57182, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(1209.0775, -722.80597, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(1244.922, -111.74569, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(733.6123, 388.0518, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(808.58234, 388.68576, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(889.9007, 383.46716, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(1065.306, 277.57312, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(1043.9341, 486.2635, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(1227.2125, 329.6615, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(1498.543, 310.8288, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(856.9624, -272.83322, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(839.89594, -158.75832, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(830.93085, -547.34875, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(1338.1182, -175.26785, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(1360.8607, -574.37714, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(1042.5977, -380.9275, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(754.7031, -135.68279, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(1033.8937, -898.04364, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(993.94196, -761.7798, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(850.4158, 430.83594, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(1406.125, 570.5563, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(1612.6682, 645.8969, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(1553.6049, 447.12982, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(1058.2888, 386.82214, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(646.8162, 81.99928, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(134.86223, 124.50842, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(940.9251, 114.58902, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(756.0573, 311.00912, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(1223.6223, 436.17368, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(1396.4752, -295.82278, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(1409.6144, -196.16623, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(1300.2242, -670.2551, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(1423.3752, -612.8487, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(795.55396, -618.68396, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(896.5961, -627.4559, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(772.12256, -296.1991, 30));
		AddSpawnPoint( "d_underaqueduct.Id5", "d_underaqueduct", Spot(907.15576, -213.1711, 30));

		// Chesha_Papa Spawn Points
		AddSpawnPoint( "d_underaqueduct.Id6", "d_underaqueduct", Spot(-1134.2347, 130.55475, 1000));
		AddSpawnPoint( "d_underaqueduct.Id6", "d_underaqueduct", Spot(481.84906, 60.33194, 1000));

		// Gimmick_Mon_Chesha_Venom Spawn Points
		AddSpawnPoint( "d_underaqueduct.Id7", "d_underaqueduct", Spot(718.7035, -655.1962, 30));
		AddSpawnPoint( "d_underaqueduct.Id7", "d_underaqueduct", Spot(29.068993, -599.919, 30));
		AddSpawnPoint( "d_underaqueduct.Id7", "d_underaqueduct", Spot(783.4473, -208.26437, 30));
		AddSpawnPoint( "d_underaqueduct.Id7", "d_underaqueduct", Spot(1328.744, -205.01305, 30));
		AddSpawnPoint( "d_underaqueduct.Id7", "d_underaqueduct", Spot(1382.2267, 460.3059, 30));
		AddSpawnPoint( "d_underaqueduct.Id7", "d_underaqueduct", Spot(1335.8591, 1038.099, 30));
		AddSpawnPoint( "d_underaqueduct.Id7", "d_underaqueduct", Spot(803.07434, 403.12256, 30));
		AddSpawnPoint( "d_underaqueduct.Id7", "d_underaqueduct", Spot(170.10275, 592.2168, 30));
		AddSpawnPoint( "d_underaqueduct.Id7", "d_underaqueduct", Spot(-1108.6714, -428.315, 30));
		AddSpawnPoint( "d_underaqueduct.Id7", "d_underaqueduct", Spot(-511.10263, 122.76037, 30));
		AddSpawnPoint( "d_underaqueduct.Id7", "d_underaqueduct", Spot(-1653.5437, -386.8477, 30));
		AddSpawnPoint( "d_underaqueduct.Id7", "d_underaqueduct", Spot(-1680.5938, 683.43475, 30));
		AddSpawnPoint( "d_underaqueduct.Id7", "d_underaqueduct", Spot(-1698.8779, 1296.5061, 30));

		// Rootcrystal_04 Spawn Points
		AddSpawnPoint( "d_underaqueduct.Id8", "d_underaqueduct", Spot(1318.353, -628.2867, 200));
		AddSpawnPoint( "d_underaqueduct.Id8", "d_underaqueduct", Spot(-944.4491, 1256.781, 200));
		AddSpawnPoint( "d_underaqueduct.Id8", "d_underaqueduct", Spot(1295.4332, 533.0116, 200));
		AddSpawnPoint( "d_underaqueduct.Id8", "d_underaqueduct", Spot(1299.7865, 1037.4513, 200));
		AddSpawnPoint( "d_underaqueduct.Id8", "d_underaqueduct", Spot(848.0812, 355.7351, 200));
		AddSpawnPoint( "d_underaqueduct.Id8", "d_underaqueduct", Spot(832.3353, -161.91095, 200));
		AddSpawnPoint( "d_underaqueduct.Id8", "d_underaqueduct", Spot(118.43227, -556.92413, 200));
		AddSpawnPoint( "d_underaqueduct.Id8", "d_underaqueduct", Spot(212.53175, 567.00525, 200));
		AddSpawnPoint( "d_underaqueduct.Id8", "d_underaqueduct", Spot(-1653.0667, -353.23102, 200));
		AddSpawnPoint( "d_underaqueduct.Id8", "d_underaqueduct", Spot(-1627.9178, 662.827, 200));
		AddSpawnPoint( "d_underaqueduct.Id8", "d_underaqueduct", Spot(-1616.5529, 1298.8849, 200));
		AddSpawnPoint( "d_underaqueduct.Id8", "d_underaqueduct", Spot(-1564.81, 91.662895, 200));
		AddSpawnPoint( "d_underaqueduct.Id8", "d_underaqueduct", Spot(-1083.4976, 538.89026, 200));
		AddSpawnPoint( "d_underaqueduct.Id8", "d_underaqueduct", Spot(-521.88354, 81.68652, 200));
		AddSpawnPoint( "d_underaqueduct.Id8", "d_underaqueduct", Spot(16.76575, 176.24312, 200));
		AddSpawnPoint( "d_underaqueduct.Id8", "d_underaqueduct", Spot(700.134, 65.27483, 200));
		AddSpawnPoint( "d_underaqueduct.Id8", "d_underaqueduct", Spot(1190.6334, 153.55826, 200));
		AddSpawnPoint( "d_underaqueduct.Id8", "d_underaqueduct", Spot(1391.402, -148.86513, 200));
		AddSpawnPoint( "d_underaqueduct.Id8", "d_underaqueduct", Spot(714.252, -685.88354, 200));
		AddSpawnPoint( "d_underaqueduct.Id8", "d_underaqueduct", Spot(1019.5081, -398.14035, 200));
		AddSpawnPoint( "d_underaqueduct.Id8", "d_underaqueduct", Spot(-1097.358, -438.6833, 200));
		AddSpawnPoint( "d_underaqueduct.Id8", "d_underaqueduct", Spot(1070.5951, 680.4897, 200));
		AddSpawnPoint( "d_underaqueduct.Id8", "d_underaqueduct", Spot(-1122.5132, -25.522467, 200));
		AddSpawnPoint( "d_underaqueduct.Id8", "d_underaqueduct", Spot(-200.01332, -209.1839, 200));

	}
}
