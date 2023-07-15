//--- Melia Script -----------------------------------------------------------
// d_firetower_69_1
//
//--- Description -----------------------------------------------------------
// Sets up the d_firetower_69_1 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DFiretower691MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("d_firetower_69_1.Id1", MonsterId.Firetower_GateOpen_Q, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_firetower_69_1.Id2", MonsterId.Slime_Red, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_69_1.Id3", MonsterId.Slime_Red, 40, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_69_1.Id4", MonsterId.Arma_Yellow, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_69_1.Id5", MonsterId.Pyran_Yellow, 40, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_69_1.Id6", MonsterId.Wizards_Marmotte_Red, 8, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_69_1.Id7", MonsterId.Wizards_Marmotte_Red, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_69_1.Id8", MonsterId.Pyran_Yellow, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_69_1.Id9", MonsterId.Rootcrystal_05, 15, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Firetower_GateOpen_Q Spawn Points
		AddSpawnPoint( "d_firetower_69_1.Id1", "d_firetower_69_1", Spot(-705.55347, 748.2025, 40));
		AddSpawnPoint( "d_firetower_69_1.Id1", "d_firetower_69_1", Spot(-606.1349, 239.28152, 40));
		AddSpawnPoint( "d_firetower_69_1.Id1", "d_firetower_69_1", Spot(-507.68317, 526.3595, 40));
		AddSpawnPoint( "d_firetower_69_1.Id1", "d_firetower_69_1", Spot(2.7951374, 230.87343, 40));
		AddSpawnPoint( "d_firetower_69_1.Id1", "d_firetower_69_1", Spot(431.479, 692.2086, 40));
		AddSpawnPoint( "d_firetower_69_1.Id1", "d_firetower_69_1", Spot(481.35504, 80.75214, 40));
		AddSpawnPoint( "d_firetower_69_1.Id1", "d_firetower_69_1", Spot(-162.67827, 732.31177, 40));
		AddSpawnPoint( "d_firetower_69_1.Id1", "d_firetower_69_1", Spot(229.84518, 537.95337, 40));
		AddSpawnPoint( "d_firetower_69_1.Id1", "d_firetower_69_1", Spot(-375.20807, 761.5745, 40));
		AddSpawnPoint( "d_firetower_69_1.Id1", "d_firetower_69_1", Spot(108.87775, 742.777, 40));
		AddSpawnPoint( "d_firetower_69_1.Id1", "d_firetower_69_1", Spot(139.53275, 23.79451, 40));
		AddSpawnPoint( "d_firetower_69_1.Id1", "d_firetower_69_1", Spot(460.56552, 417.45358, 40));
		AddSpawnPoint( "d_firetower_69_1.Id1", "d_firetower_69_1", Spot(-35.467937, 439.59232, 40));
		AddSpawnPoint( "d_firetower_69_1.Id1", "d_firetower_69_1", Spot(-395.37503, 310.3585, 40));
		AddSpawnPoint( "d_firetower_69_1.Id1", "d_firetower_69_1", Spot(281.11057, 753.2393, 40));
		AddSpawnPoint( "d_firetower_69_1.Id1", "d_firetower_69_1", Spot(258.9947, 240.36133, 40));

		// Slime_Red Spawn Points
		AddSpawnPoint( "d_firetower_69_1.Id2", "d_firetower_69_1", Spot(1692.6818, 274.61145, 40));
		AddSpawnPoint( "d_firetower_69_1.Id2", "d_firetower_69_1", Spot(1571.2644, 513.88153, 40));
		AddSpawnPoint( "d_firetower_69_1.Id2", "d_firetower_69_1", Spot(1744.225, 646.54254, 40));
		AddSpawnPoint( "d_firetower_69_1.Id2", "d_firetower_69_1", Spot(1902.2583, 501.66547, 40));
		AddSpawnPoint( "d_firetower_69_1.Id2", "d_firetower_69_1", Spot(1528.4347, 167.18626, 40));
		AddSpawnPoint( "d_firetower_69_1.Id2", "d_firetower_69_1", Spot(1869.0383, 219.81424, 40));
		AddSpawnPoint( "d_firetower_69_1.Id2", "d_firetower_69_1", Spot(2225.9797, 250.7357, 40));
		AddSpawnPoint( "d_firetower_69_1.Id2", "d_firetower_69_1", Spot(2377.887, 175.16127, 40));
		AddSpawnPoint( "d_firetower_69_1.Id2", "d_firetower_69_1", Spot(2614.9407, 137.54488, 40));
		AddSpawnPoint( "d_firetower_69_1.Id2", "d_firetower_69_1", Spot(2639.4348, 358.19275, 40));
		AddSpawnPoint( "d_firetower_69_1.Id2", "d_firetower_69_1", Spot(2648.2568, 621.94806, 40));
		AddSpawnPoint( "d_firetower_69_1.Id2", "d_firetower_69_1", Spot(2346.7136, 625.63635, 40));
		AddSpawnPoint( "d_firetower_69_1.Id2", "d_firetower_69_1", Spot(2226.5486, 581.5003, 40));
		AddSpawnPoint( "d_firetower_69_1.Id2", "d_firetower_69_1", Spot(2434.5789, 523.38617, 40));
		AddSpawnPoint( "d_firetower_69_1.Id2", "d_firetower_69_1", Spot(2317.2007, 340.18484, 40));
		AddSpawnPoint( "d_firetower_69_1.Id2", "d_firetower_69_1", Spot(2226.7004, 88.980034, 40));
		AddSpawnPoint( "d_firetower_69_1.Id2", "d_firetower_69_1", Spot(1908.8397, 414.82608, 40));
		AddSpawnPoint( "d_firetower_69_1.Id2", "d_firetower_69_1", Spot(1549.0171, 345.66443, 40));
		AddSpawnPoint( "d_firetower_69_1.Id2", "d_firetower_69_1", Spot(1721.424, 518.33307, 40));
		AddSpawnPoint( "d_firetower_69_1.Id2", "d_firetower_69_1", Spot(1732.7047, 120.41931, 40));
		AddSpawnPoint( "d_firetower_69_1.Id2", "d_firetower_69_1", Spot(2523.3835, 267.05643, 40));
		AddSpawnPoint( "d_firetower_69_1.Id2", "d_firetower_69_1", Spot(2449.5156, 85.695724, 40));
		AddSpawnPoint( "d_firetower_69_1.Id2", "d_firetower_69_1", Spot(2709.0989, 495.2148, 40));
		AddSpawnPoint( "d_firetower_69_1.Id2", "d_firetower_69_1", Spot(2470.7185, 661.47955, 40));
		AddSpawnPoint( "d_firetower_69_1.Id3", "d_firetower_69_1", Spot(-1655.2084, -235.26718, 9999));

		// Arma_Yellow Spawn Points
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(-1950.6621, -362.93896, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(-1818.009, -142.72057, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(-1685.8407, -390.05624, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(-1592.56, -132.15874, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(-1455.4956, -380.8133, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(-1722.6589, -1287.56, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(-1493.2244, -1539.8552, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(-1438.4917, -1769.4135, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(-1168.3033, -1675.863, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(-1293.7202, -1459.0995, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(-1895.4623, -1616.7792, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(-1794.561, -1728.2297, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(-1173.8374, -1792.6117, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(-558.487, -980.97375, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(-548.19806, -689.73566, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(-277.1529, -796.8166, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(-330.5582, -1036.612, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(-496.01324, -884.21545, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(-491.3737, -851.1795, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(-534.99677, -497.9155, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(-406.4869, -206.66913, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(-369.38428, -77.797676, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(-698.2804, -286.62637, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(-534.3272, -377.36554, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(-277.52, -475.36588, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(-768.98987, -756.2988, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(-671.2249, -911.4266, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(-538.60803, -1278.6176, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(-714.3735, -1572.8057, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(174.21803, -954.9827, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(466.69916, -966.9317, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(436.52353, -1069.5513, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(539.00085, -1203.4037, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(265.9105, -1228.215, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(338.0292, -1415.3198, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(616.69635, -1353.5258, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(591.10834, -1503.8075, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(161.13716, -1368.6877, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(-187.31726, -265.77805, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(-595.0273, 394.89313, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(-480.13147, 659.2721, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(-143.21173, 721.60834, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(12.419266, 319.84348, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(179.70401, 298.9496, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(398.78418, 656.7741, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(406.69012, 284.35284, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(85.5468, 550.81464, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(1168.0225, -367.56348, 40));
		AddSpawnPoint( "d_firetower_69_1.Id4", "d_firetower_69_1", Spot(1133.4003, -331.93295, 40));

		// Pyran_Yellow Spawn Points
		AddSpawnPoint( "d_firetower_69_1.Id5", "d_firetower_69_1", Spot(-1585.9828, -336.9056, 9999));

		// Wizards_Marmotte_Red Spawn Points
		AddSpawnPoint( "d_firetower_69_1.Id6", "d_firetower_69_1", Spot(1162.1224, 376.99368, 40));
		AddSpawnPoint( "d_firetower_69_1.Id6", "d_firetower_69_1", Spot(1014.3956, 182.27544, 40));
		AddSpawnPoint( "d_firetower_69_1.Id6", "d_firetower_69_1", Spot(829.7269, 232.61066, 40));
		AddSpawnPoint( "d_firetower_69_1.Id6", "d_firetower_69_1", Spot(780.0636, 431.24783, 40));
		AddSpawnPoint( "d_firetower_69_1.Id6", "d_firetower_69_1", Spot(874.18335, 471.8129, 40));
		AddSpawnPoint( "d_firetower_69_1.Id6", "d_firetower_69_1", Spot(1084.3561, 526.35297, 40));
		AddSpawnPoint( "d_firetower_69_1.Id6", "d_firetower_69_1", Spot(1163.185, 192.6409, 40));
		AddSpawnPoint( "d_firetower_69_1.Id6", "d_firetower_69_1", Spot(740.54254, 323.12518, 40));
		AddSpawnPoint( "d_firetower_69_1.Id6", "d_firetower_69_1", Spot(931.5344, 353.9883, 40));
		AddSpawnPoint( "d_firetower_69_1.Id6", "d_firetower_69_1", Spot(1049.2532, 359.26663, 40));
		AddSpawnPoint( "d_firetower_69_1.Id7", "d_firetower_69_1", Spot(496.9824, -1029.512, 40));
		AddSpawnPoint( "d_firetower_69_1.Id7", "d_firetower_69_1", Spot(244.78363, -924.2163, 40));
		AddSpawnPoint( "d_firetower_69_1.Id7", "d_firetower_69_1", Spot(152.98792, -1065.5372, 40));
		AddSpawnPoint( "d_firetower_69_1.Id7", "d_firetower_69_1", Spot(346.4697, -986.23737, 40));
		AddSpawnPoint( "d_firetower_69_1.Id7", "d_firetower_69_1", Spot(338.16055, -1269.9902, 40));
		AddSpawnPoint( "d_firetower_69_1.Id7", "d_firetower_69_1", Spot(1202.777, -1170.4686, 40));
		AddSpawnPoint( "d_firetower_69_1.Id7", "d_firetower_69_1", Spot(1192.7653, -1344.6158, 40));
		AddSpawnPoint( "d_firetower_69_1.Id7", "d_firetower_69_1", Spot(1255.9904, -1438.8539, 40));
		AddSpawnPoint( "d_firetower_69_1.Id7", "d_firetower_69_1", Spot(1058.5653, -1230.4569, 40));
		AddSpawnPoint( "d_firetower_69_1.Id7", "d_firetower_69_1", Spot(1423.9824, -1295.1766, 40));
		AddSpawnPoint( "d_firetower_69_1.Id7", "d_firetower_69_1", Spot(1395.0082, -1142.3724, 40));
		AddSpawnPoint( "d_firetower_69_1.Id7", "d_firetower_69_1", Spot(915.57196, -675.63654, 40));
		AddSpawnPoint( "d_firetower_69_1.Id7", "d_firetower_69_1", Spot(1104.2527, -702.24646, 40));
		AddSpawnPoint( "d_firetower_69_1.Id7", "d_firetower_69_1", Spot(892.8203, -462.1565, 40));
		AddSpawnPoint( "d_firetower_69_1.Id7", "d_firetower_69_1", Spot(1195.4714, -576.71765, 40));
		AddSpawnPoint( "d_firetower_69_1.Id7", "d_firetower_69_1", Spot(1338.0146, -700.11304, 40));
		AddSpawnPoint( "d_firetower_69_1.Id7", "d_firetower_69_1", Spot(1285.8739, -430.12607, 40));
		AddSpawnPoint( "d_firetower_69_1.Id7", "d_firetower_69_1", Spot(1238.0267, -177.57037, 40));
		AddSpawnPoint( "d_firetower_69_1.Id7", "d_firetower_69_1", Spot(908.11835, -188.71828, 40));
		AddSpawnPoint( "d_firetower_69_1.Id7", "d_firetower_69_1", Spot(1139.656, -425.1372, 40));
		AddSpawnPoint( "d_firetower_69_1.Id7", "d_firetower_69_1", Spot(2098.7747, -435.66052, 40));
		AddSpawnPoint( "d_firetower_69_1.Id7", "d_firetower_69_1", Spot(2182.423, -331.28638, 40));
		AddSpawnPoint( "d_firetower_69_1.Id7", "d_firetower_69_1", Spot(2093.5117, -205.4157, 40));
		AddSpawnPoint( "d_firetower_69_1.Id7", "d_firetower_69_1", Spot(2230.8215, -517.4541, 40));
		AddSpawnPoint( "d_firetower_69_1.Id7", "d_firetower_69_1", Spot(2333.713, -213.02032, 40));
		AddSpawnPoint( "d_firetower_69_1.Id7", "d_firetower_69_1", Spot(2397.2437, -480.95532, 40));
		AddSpawnPoint( "d_firetower_69_1.Id7", "d_firetower_69_1", Spot(2433.2937, -212.07373, 40));
		AddSpawnPoint( "d_firetower_69_1.Id7", "d_firetower_69_1", Spot(2346.5088, -342.04462, 40));
		AddSpawnPoint( "d_firetower_69_1.Id7", "d_firetower_69_1", Spot(509.6576, -1281.535, 40));
		AddSpawnPoint( "d_firetower_69_1.Id7", "d_firetower_69_1", Spot(583.49963, -1153.1912, 40));
		AddSpawnPoint( "d_firetower_69_1.Id7", "d_firetower_69_1", Spot(1041.6006, -453.4824, 40));
		AddSpawnPoint( "d_firetower_69_1.Id7", "d_firetower_69_1", Spot(1121.2391, -222.12244, 40));

		// Pyran_Yellow Spawn Points
		AddSpawnPoint( "d_firetower_69_1.Id8", "d_firetower_69_1", Spot(984.95404, -560.31354, 40));
		AddSpawnPoint( "d_firetower_69_1.Id8", "d_firetower_69_1", Spot(1121.0148, -259.039, 40));
		AddSpawnPoint( "d_firetower_69_1.Id8", "d_firetower_69_1", Spot(1199.6738, -415.26282, 40));
		AddSpawnPoint( "d_firetower_69_1.Id8", "d_firetower_69_1", Spot(1304.7739, -639.54724, 40));
		AddSpawnPoint( "d_firetower_69_1.Id8", "d_firetower_69_1", Spot(1353.3569, -272.05234, 40));
		AddSpawnPoint( "d_firetower_69_1.Id8", "d_firetower_69_1", Spot(978.2568, 168.8382, 40));
		AddSpawnPoint( "d_firetower_69_1.Id8", "d_firetower_69_1", Spot(990.32623, 434.04333, 40));
		AddSpawnPoint( "d_firetower_69_1.Id8", "d_firetower_69_1", Spot(798.1768, 406.2034, 40));
		AddSpawnPoint( "d_firetower_69_1.Id8", "d_firetower_69_1", Spot(433.3788, 402.94888, 40));
		AddSpawnPoint( "d_firetower_69_1.Id8", "d_firetower_69_1", Spot(160.02979, 643.15924, 40));
		AddSpawnPoint( "d_firetower_69_1.Id8", "d_firetower_69_1", Spot(86.44235, 426.12628, 40));
		AddSpawnPoint( "d_firetower_69_1.Id8", "d_firetower_69_1", Spot(-300.43375, 753.90424, 40));
		AddSpawnPoint( "d_firetower_69_1.Id8", "d_firetower_69_1", Spot(-585.54846, 650.05634, 40));
		AddSpawnPoint( "d_firetower_69_1.Id8", "d_firetower_69_1", Spot(-554.3168, 301.67514, 40));
		AddSpawnPoint( "d_firetower_69_1.Id8", "d_firetower_69_1", Spot(-306.11084, 282.88904, 40));
		AddSpawnPoint( "d_firetower_69_1.Id8", "d_firetower_69_1", Spot(-193.03615, -116.6351, 40));
		AddSpawnPoint( "d_firetower_69_1.Id8", "d_firetower_69_1", Spot(312.4519, -184.9383, 40));
		AddSpawnPoint( "d_firetower_69_1.Id8", "d_firetower_69_1", Spot(950.81726, -138.12685, 40));
		AddSpawnPoint( "d_firetower_69_1.Id8", "d_firetower_69_1", Spot(1297.5054, -152.69308, 40));
		AddSpawnPoint( "d_firetower_69_1.Id8", "d_firetower_69_1", Spot(1712.7596, -198.64975, 40));
		AddSpawnPoint( "d_firetower_69_1.Id8", "d_firetower_69_1", Spot(1892.6267, -161.1259, 40));
		AddSpawnPoint( "d_firetower_69_1.Id8", "d_firetower_69_1", Spot(2066.6047, -152.91003, 40));
		AddSpawnPoint( "d_firetower_69_1.Id8", "d_firetower_69_1", Spot(2183.2634, -339.01532, 40));
		AddSpawnPoint( "d_firetower_69_1.Id8", "d_firetower_69_1", Spot(2444.4146, -119.61528, 40));
		AddSpawnPoint( "d_firetower_69_1.Id8", "d_firetower_69_1", Spot(2406.399, -377.20148, 40));
		AddSpawnPoint( "d_firetower_69_1.Id8", "d_firetower_69_1", Spot(2160.0693, -497.61157, 40));
		AddSpawnPoint( "d_firetower_69_1.Id8", "d_firetower_69_1", Spot(2025.3105, -437.42633, 40));
		AddSpawnPoint( "d_firetower_69_1.Id8", "d_firetower_69_1", Spot(2389.2869, -495.39087, 40));

		// Rootcrystal_05 Spawn Points
		AddSpawnPoint( "d_firetower_69_1.Id9", "d_firetower_69_1", Spot(-1802.49, -285.77, 150));
		AddSpawnPoint( "d_firetower_69_1.Id9", "d_firetower_69_1", Spot(-1497.16, -130.96, 150));
		AddSpawnPoint( "d_firetower_69_1.Id9", "d_firetower_69_1", Spot(-1436.02, -436.06, 150));
		AddSpawnPoint( "d_firetower_69_1.Id9", "d_firetower_69_1", Spot(-1705.87, 472.47, 150));
		AddSpawnPoint( "d_firetower_69_1.Id9", "d_firetower_69_1", Spot(-1257.32, 645.1, 150));
		AddSpawnPoint( "d_firetower_69_1.Id9", "d_firetower_69_1", Spot(-1931.6, 898.64, 150));
		AddSpawnPoint( "d_firetower_69_1.Id9", "d_firetower_69_1", Spot(-1916.87, 1235.5, 150));
		AddSpawnPoint( "d_firetower_69_1.Id9", "d_firetower_69_1", Spot(-578.9, 356.98, 150));
		AddSpawnPoint( "d_firetower_69_1.Id9", "d_firetower_69_1", Spot(-245.02, 703.36, 150));
		AddSpawnPoint( "d_firetower_69_1.Id9", "d_firetower_69_1", Spot(295.29, 653.09, 150));
		AddSpawnPoint( "d_firetower_69_1.Id9", "d_firetower_69_1", Spot(455.08, 171.82, 150));
		AddSpawnPoint( "d_firetower_69_1.Id9", "d_firetower_69_1", Spot(67.31, 179.06, 150));
		AddSpawnPoint( "d_firetower_69_1.Id9", "d_firetower_69_1", Spot(896.73, 364.75, 150));
		AddSpawnPoint( "d_firetower_69_1.Id9", "d_firetower_69_1", Spot(1614.08, 236.13, 150));
		AddSpawnPoint( "d_firetower_69_1.Id9", "d_firetower_69_1", Spot(1821.26, 511.09, 150));
		AddSpawnPoint( "d_firetower_69_1.Id9", "d_firetower_69_1", Spot(2343.1, 190.45, 150));
		AddSpawnPoint( "d_firetower_69_1.Id9", "d_firetower_69_1", Spot(2525.37, 566.44, 150));
		AddSpawnPoint( "d_firetower_69_1.Id9", "d_firetower_69_1", Spot(2634.96, 232.36, 150));
		AddSpawnPoint( "d_firetower_69_1.Id9", "d_firetower_69_1", Spot(2437.96, -202.98, 150));
		AddSpawnPoint( "d_firetower_69_1.Id9", "d_firetower_69_1", Spot(2201.32, -444.11, 150));
		AddSpawnPoint( "d_firetower_69_1.Id9", "d_firetower_69_1", Spot(1797.12, -199.99, 150));
		AddSpawnPoint( "d_firetower_69_1.Id9", "d_firetower_69_1", Spot(1242.08, -296.5, 150));
		AddSpawnPoint( "d_firetower_69_1.Id9", "d_firetower_69_1", Spot(1080.46, -590.43, 150));
		AddSpawnPoint( "d_firetower_69_1.Id9", "d_firetower_69_1", Spot(1172.67, -1271.73, 150));
		AddSpawnPoint( "d_firetower_69_1.Id9", "d_firetower_69_1", Spot(1398.75, -1433.88, 150));
		AddSpawnPoint( "d_firetower_69_1.Id9", "d_firetower_69_1", Spot(610.19, -955.14, 150));
		AddSpawnPoint( "d_firetower_69_1.Id9", "d_firetower_69_1", Spot(320.01, -1334.61, 150));
		AddSpawnPoint( "d_firetower_69_1.Id9", "d_firetower_69_1", Spot(-491.69, -286.89, 150));
		AddSpawnPoint( "d_firetower_69_1.Id9", "d_firetower_69_1", Spot(-638.84, -760.29, 150));
		AddSpawnPoint( "d_firetower_69_1.Id9", "d_firetower_69_1", Spot(-216.24, -949.75, 150));
		AddSpawnPoint( "d_firetower_69_1.Id9", "d_firetower_69_1", Spot(-1211.2, -1706.38, 150));
		AddSpawnPoint( "d_firetower_69_1.Id9", "d_firetower_69_1", Spot(-1503.6, -1433.54, 150));
		AddSpawnPoint( "d_firetower_69_1.Id9", "d_firetower_69_1", Spot(-1818.49, -1647.08, 150));

	}
}
