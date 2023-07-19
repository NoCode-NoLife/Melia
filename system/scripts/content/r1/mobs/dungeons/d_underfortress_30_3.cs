//--- Melia Script -----------------------------------------------------------
// d_underfortress_30_3
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Evacuation Residential District' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DUnderfortress303MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("d_underfortress_30_3.Id1", MonsterId.Candlespider_Blue, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_30_3.Id2", MonsterId.Colimen_Brown, 45, 60, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_30_3.Id3", MonsterId.Colimen_Mage_Brown, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_30_3.Id4", MonsterId.Rootcrystal_04, 23, 30, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Candlespider_Blue' GenType 1 Spawn Points
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(266.54105, 210.26808, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(98.03175, -63.77444, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(-340.55524, 222.00467, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(40.91606, 716.0832, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(345.1383, 941.9301, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(-223.19775, 863.029, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(-723.8404, 176.33969, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(-869.6024, -16.106262, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(-913.35455, 590.8886, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(-742.1966, 937.0924, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(-790.0671, 1528.4242, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(-768.1348, 1236.4899, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(83.453094, 1155.7784, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(24.882362, 1723.8995, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(172.97061, 1578.1018, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(28.904316, -132.66675, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(-119.09488, -346.27872, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(217.7464, -271.5193, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(60.68616, -353.99985, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(62.02307, -705.92377, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(-353.44675, -803.2892, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(-1141.843, -860.4186, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(-824.6475, -796.473, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(-772.2585, -970.12933, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(-473.0906, -766.3572, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(402.52792, -780.87115, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(644.9068, -811.1098, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(817.45575, -679.85706, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(773.15356, -819.4182, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(1021.3051, -851.4827, 30));
		AddSpawnPoint("d_underfortress_30_3.Id1", "d_underfortress_30_3", Rectangle(1121.7092, -804.3867, 30));

		// 'Colimen_Brown' GenType 2 Spawn Points
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(1060.2235, 830.71716, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(902.8307, 723.78687, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(1054.6648, 523.9698, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(1145.1538, 395.28503, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(1055.8105, 199.4102, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(915.5478, 136.30571, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(1096.6538, 6.2030563, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(1073.5754, 1351.4822, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(1084.2354, 1624.4458, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(930.41736, 1498.2692, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(1550.6298, 1453.686, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(1790.1401, 1530.8984, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(1856.7318, 1422.141, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(1727.1726, 1411.3896, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(670.01013, 838.9421, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(508.9806, 770.1676, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(276.65698, 654.911, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-16.31554, 695.72156, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(211.29317, 835.34064, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-65.423775, 1008.7872, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(134.25638, 1107.6774, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(69.61432, 1372.8683, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(125.56548, 1738.1633, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-109.52972, 1715.6554, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(139.6992, 1510.3837, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(14.348255, 273.38068, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(7.5827274, 156.21684, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(337.31473, 216.42824, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(186.7725, 267.78058, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-133.20848, 195.63925, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(67.451645, -180.95349, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-56.464584, -317.4892, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(99.11726, -402.4141, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(268.95355, -266.8429, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(54.465073, -25.082048, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(107.01076, -583.29004, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(18.475887, -743.2873, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-822.65076, -889.46906, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-949.3446, -782.9814, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-685.902, -724.5384, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-632.61035, -842.1409, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-338.3061, -746.94275, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(531.5137, -801.80756, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(814.96924, -708.6961, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(908.8327, -828.4673, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(1061.4521, -791.44183, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(1076.9285, -714.35956, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(1182.7769, -924.41614, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-391.1096, 235.85637, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-528.8188, 211.31349, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-742.27234, -90.76224, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-826.4527, 158.7502, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-629.2918, 303.38565, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-936.1322, 286.6358, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-901.53235, 603.64655, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-816.00287, 434.51416, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-758.0955, 852.795, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-694.3371, 1278.0999, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-838.151, 1474.1555, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-737.6707, 1629.4508, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-668.47375, 1428.9904, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-1738.6738, 1442.346, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-1787.138, 1753.4308, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-1584.223, 1615.5338, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-1725.2753, 1570.1458, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-1506.8364, 1426.1086, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-1268.7454, 1480.3229, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-1127.0728, 1443.0537, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(-801.3883, 1658.599, 30));
		AddSpawnPoint("d_underfortress_30_3.Id2", "d_underfortress_30_3", Rectangle(922.6284, 429.8878, 30));

		// 'Colimen_Mage_Brown' GenType 3 Spawn Points
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-741.3374, 424.5121, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-796.9892, 621.0836, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-711.1575, 907.42993, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-731.57965, 1310.3934, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-665.0497, 1584.3043, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-892.8697, 1529.9877, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-1213.6926, 1511.9288, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-1665.3884, 1733.9945, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-1645.5884, 1402.8413, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-1782.9741, 1647.9784, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-793.7311, 196.22044, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-688.61884, -85.50618, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-828.0192, -100.44379, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-563.3172, 81.84134, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-79.574974, 203.02759, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(62.717163, -81.137, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(16.715214, -452.0962, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-122.96936, -359.36987, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(83.338745, -300.35056, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(290.0286, -288.07257, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(207.66954, -431.42365, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(68.01179, -747.10913, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-171.24623, -797.53546, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-409.56882, -752.3088, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-983.276, -881.1235, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-1033.6973, -718.254, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-757.3102, -743.67755, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-768.5056, -935.355, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-532.05865, -747.51154, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-443.86523, 240.4135, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-298.44516, 265.76157, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-876.0038, 1707.4874, 30));
		AddSpawnPoint("d_underfortress_30_3.Id3", "d_underfortress_30_3", Rectangle(-675.07916, 1459.1018, 30));

		// 'Rootcrystal_04' GenType 6 Spawn Points
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(-986.82764, -752.34247, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(-158.07117, -742.12366, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(621.7234, -807.7643, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(1129.4568, -809.4469, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(1465.709, -806.3034, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(34.697617, -320.70242, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(67.42051, 154.21893, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(419.784, 138.05743, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(-542.3258, 258.94333, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(-978.8593, 85.30053, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(-710.40814, 1154.9081, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(-916.29584, 682.0276, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(-589.24506, 1495.6095, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(-898.1686, 1619.7551, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(-1198.7102, 1453.7094, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(12.696278, 720.27466, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(92.55662, 1278.5543, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(424.4908, 853.5001, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(-57.76798, 1716.8912, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(338.55225, 1628.467, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(1213.9854, -37.531326, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(875.5757, 326.06903, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(1000.3244, 735.6917, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(1085.5139, 1244.0093, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(984.4941, 1672.8821, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(1455.8245, 1445.5334, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(2024.0266, 1386.3267, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(364.60895, -305.70764, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(-1648.27, 1739.6526, 10));
		AddSpawnPoint("d_underfortress_30_3.Id4", "d_underfortress_30_3", Rectangle(-1653.8281, 1332.582, 10));
	}
}
