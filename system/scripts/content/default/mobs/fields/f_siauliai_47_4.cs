//--- Melia Script -----------------------------------------------------------
// f_siauliai_47_4
//
//--- Description -----------------------------------------------------------
// Sets up the f_siauliai_47_4 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FSiauliai474MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_siauliai_47_4", MonsterId.Haming_Orange, Properties("MHP", 171214, "MINPATK", 2703, "MAXPATK", 3224, "MINMATK", 2703, "MAXMATK", 3224, "DEF", 4709, "MDEF", 4709));
		AddPropertyOverrides("f_siauliai_47_4", MonsterId.Popolion_Orange, Properties("MHP", 171834, "MINPATK", 2711, "MAXPATK", 3233, "MINMATK", 2711, "MAXMATK", 3233, "DEF", 4766, "MDEF", 4766));
		AddPropertyOverrides("f_siauliai_47_4", MonsterId.Spion_Mage, Properties("MHP", 172520, "MINPATK", 2720, "MAXPATK", 3244, "MINMATK", 2720, "MAXMATK", 3244, "DEF", 4828, "MDEF", 4828));

		// Monster Spawners --------------------------------

		AddSpawner("f_siauliai_47_4.Id1", MonsterId.Haming_Orange, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_47_4.Id2", MonsterId.Popolion_Orange, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_47_4.Id3", MonsterId.Popolion_Orange, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_47_4.Id4", MonsterId.Popolion_Orange, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_47_4.Id5", MonsterId.Rootcrystal_01, 26, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_siauliai_47_4.Id6", MonsterId.Spion_Mage, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Haming_Orange Spawn Points
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(1570.3926, -303.3331, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(-532.9088, -1445.4198, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(-372.2908, -1329.02, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(-565.76373, -1260.0127, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(207.18475, -143.34708, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(-599.1175, -1566.6807, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(-520.6015, -1585.7068, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(734.9324, -306.0163, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(-611.47144, -1114.9847, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(-497.09943, -1053.6317, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(-391.051, -1115.3892, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(-290.60596, -1192.6477, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(-411.41034, -1215.1592, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(408.4283, -463.5718, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(1258.7631, -1001.4999, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(1218.8242, -978.3428, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(1361.4564, -953.8082, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(1244.7394, -789.4346, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(1264.4307, -661.3727, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(1186.924, -607.96094, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(1140.086, -788.5044, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(997.1219, -851.733, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(1063.6427, -664.0695, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(1732.3094, -571.4493, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(1597.9337, -509.81247, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(1537.2603, -130.66461, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(1466.0823, -461.34955, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(337.89398, -292.89935, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(1385.1868, -337.76013, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(439.55075, -154.75328, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(498.12936, 16.168226, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(571.82007, -312.25763, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(1867.1915, -459.48206, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(1790.2081, -511.64117, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(1883.3859, -318.87827, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(719.5049, -169.38501, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(1580.6843, -187.03108, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(1708.5544, -156.79922, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(1709.0836, -386.53384, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(161.65231, -28.693092, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(2566.2754, -1235.3472, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(2524.756, -855.2291, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(2529.058, -1108.0114, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(2295.2185, -1177.784, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(2463.6663, -1224.2489, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(2220.4487, -920.5935, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(2313.2778, -871.7808, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(2462.522, -946.934, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(2550.189, -756.67145, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(2457.0818, -680.5828, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(2410.484, -787.2022, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(2648.5642, -972.9427, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(2376.9292, -1076.7542, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(2720.225, -935.78595, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(525.3012, -403.32736, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(190.5639, -245.84692, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id1", "f_siauliai_47_4", Spot(680.1284, 17.318869, 40));

		// Popolion_Orange Spawn Points
		AddSpawnPoint( "f_siauliai_47_4.Id2", "f_siauliai_47_4", Spot(330.39664, -347.969, 25));
		AddSpawnPoint( "f_siauliai_47_4.Id2", "f_siauliai_47_4", Spot(616.80023, -129.71902, 25));
		AddSpawnPoint( "f_siauliai_47_4.Id2", "f_siauliai_47_4", Spot(234.35995, -209.06343, 25));
		AddSpawnPoint( "f_siauliai_47_4.Id2", "f_siauliai_47_4", Spot(-910.8654, -4.8265, 25));
		AddSpawnPoint( "f_siauliai_47_4.Id2", "f_siauliai_47_4", Spot(-657.52496, -125.99927, 25));
		AddSpawnPoint( "f_siauliai_47_4.Id2", "f_siauliai_47_4", Spot(-210.96652, 1012.5328, 25));
		AddSpawnPoint( "f_siauliai_47_4.Id2", "f_siauliai_47_4", Spot(134.199, 1001.9471, 25));
		AddSpawnPoint( "f_siauliai_47_4.Id2", "f_siauliai_47_4", Spot(9.163158, 867.0294, 25));
		AddSpawnPoint( "f_siauliai_47_4.Id2", "f_siauliai_47_4", Spot(-363.3664, 487.67755, 25));
		AddSpawnPoint( "f_siauliai_47_4.Id2", "f_siauliai_47_4", Spot(1129.4753, 386.48456, 25));
		AddSpawnPoint( "f_siauliai_47_4.Id2", "f_siauliai_47_4", Spot(620.5553, -347.73874, 25));
		AddSpawnPoint( "f_siauliai_47_4.Id3", "f_siauliai_47_4", Spot(52.29598, 991.3111, 1500));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-519.3815, -1442.7583, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-423.71564, -1139.8054, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-186.32924, -1285.6003, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-629.82745, -1268.6534, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-1117.8854, -102.78911, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-1016.9927, -54.066463, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-932.3772, 123.18478, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-779.9428, 109.66411, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-830.6069, 6.091194, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-672.91705, -236.67938, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-780.84106, -276.0631, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-892.8547, -415.6546, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-958.5894, -343.66452, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-1313.4017, -53.990715, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-1205.9396, 67.10507, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-1030.2603, 173.85889, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-632.6351, 16.914303, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-624.9351, -188.21548, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-835.09326, -122.62926, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-883.3303, -198.82416, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-1004.4069, -138.71136, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-701.0026, 144.65321, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-583.876, -109.88494, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-1051.623, -384.9027, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-465.35867, 424.51804, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-420.64117, 364.7627, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-345.9724, 639.57947, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-433.17645, 579.7996, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-589.49316, 550.4946, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-632.7224, 560.115, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-591.6996, 648.6161, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-522.3832, 752.2873, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-347.3978, 623.41876, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-306.0537, 589.03705, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-189.1387, 561.14197, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-178.74966, 822.5458, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-157.594, 779.1502, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-118.42011, 809.61334, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-193.59253, 1035.6307, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-182.3802, 1123.2571, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(144.07956, 1110.1881, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(100.8545, 743.84985, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(34.703377, 787.1655, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(220.01227, 1005.4648, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(55.963867, 955.5568, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(-34.71056, 1035.1647, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(26.787724, 1121.8102, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(215.74464, 982.7682, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(244.39491, 43.466843, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(509.7973, 43.756035, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(725.59467, -174.9207, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(601.013, -61.649975, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(844.83966, -151.9958, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(567.7762, -505.2037, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(458.79025, -557.91583, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(154.67856, -222.54477, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(275.12604, -156.1991, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(337.67358, -69.2876, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(663.09576, -22.852636, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(841.3704, -94.80463, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(652.19696, -209.97305, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(634.2347, -393.58804, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(329.31638, -463.4208, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(402.6316, -337.98697, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(166.24915, -410.82056, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(312.0974, -284.65314, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(494.21356, -264.72922, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(122.85753, 25.822567, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(1052.5542, 414.29672, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(1195.3789, 505.03882, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(1466.5206, 416.60275, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(1256.3513, 251.59424, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(1239.6823, 173.1013, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(1332.3307, 83.12633, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(1486.7635, 226.72218, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(1232.5651, 406.63458, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(1521.6558, 342.86157, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(1208.3517, 580.2277, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id4", "f_siauliai_47_4", Spot(1425.3359, 284.68423, 40));

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "f_siauliai_47_4.Id5", "f_siauliai_47_4", Spot(-558.42786, -1247.656, 10));
		AddSpawnPoint( "f_siauliai_47_4.Id5", "f_siauliai_47_4", Spot(203.78773, -1247.5536, 10));
		AddSpawnPoint( "f_siauliai_47_4.Id5", "f_siauliai_47_4", Spot(638.761, -1281.0414, 10));
		AddSpawnPoint( "f_siauliai_47_4.Id5", "f_siauliai_47_4", Spot(1077.0094, -990.18054, 10));
		AddSpawnPoint( "f_siauliai_47_4.Id5", "f_siauliai_47_4", Spot(1157.1567, -591.5936, 10));
		AddSpawnPoint( "f_siauliai_47_4.Id5", "f_siauliai_47_4", Spot(1611.8226, -473.61996, 10));
		AddSpawnPoint( "f_siauliai_47_4.Id5", "f_siauliai_47_4", Spot(2077.519, -255.14734, 10));
		AddSpawnPoint( "f_siauliai_47_4.Id5", "f_siauliai_47_4", Spot(2384.3032, -823.8707, 10));
		AddSpawnPoint( "f_siauliai_47_4.Id5", "f_siauliai_47_4", Spot(1637.1941, -85.09137, 10));
		AddSpawnPoint( "f_siauliai_47_4.Id5", "f_siauliai_47_4", Spot(1423.8186, 366.69238, 10));
		AddSpawnPoint( "f_siauliai_47_4.Id5", "f_siauliai_47_4", Spot(1083.7543, 388.7324, 10));
		AddSpawnPoint( "f_siauliai_47_4.Id5", "f_siauliai_47_4", Spot(615.5051, 53.953598, 10));
		AddSpawnPoint( "f_siauliai_47_4.Id5", "f_siauliai_47_4", Spot(496.9238, -327.79355, 10));
		AddSpawnPoint( "f_siauliai_47_4.Id5", "f_siauliai_47_4", Spot(198.07883, -31.435524, 10));
		AddSpawnPoint( "f_siauliai_47_4.Id5", "f_siauliai_47_4", Spot(179.73523, 964.5156, 10));
		AddSpawnPoint( "f_siauliai_47_4.Id5", "f_siauliai_47_4", Spot(-90.183136, 966.11957, 10));
		AddSpawnPoint( "f_siauliai_47_4.Id5", "f_siauliai_47_4", Spot(617.4735, 1386.354, 10));
		AddSpawnPoint( "f_siauliai_47_4.Id5", "f_siauliai_47_4", Spot(1298.8354, 1091.5736, 10));
		AddSpawnPoint( "f_siauliai_47_4.Id5", "f_siauliai_47_4", Spot(1308.4832, 842.04083, 10));
		AddSpawnPoint( "f_siauliai_47_4.Id5", "f_siauliai_47_4", Spot(-523.6541, 677.56647, 10));
		AddSpawnPoint( "f_siauliai_47_4.Id5", "f_siauliai_47_4", Spot(-363.65283, 429.16318, 10));
		AddSpawnPoint( "f_siauliai_47_4.Id5", "f_siauliai_47_4", Spot(-846.9283, 58.515083, 10));
		AddSpawnPoint( "f_siauliai_47_4.Id5", "f_siauliai_47_4", Spot(-1005.0508, -345.03622, 10));
		AddSpawnPoint( "f_siauliai_47_4.Id5", "f_siauliai_47_4", Spot(-1062.263, -853.4192, 10));
		AddSpawnPoint( "f_siauliai_47_4.Id5", "f_siauliai_47_4", Spot(-1557.8846, 83.04291, 10));
		AddSpawnPoint( "f_siauliai_47_4.Id5", "f_siauliai_47_4", Spot(-1966.593, -143.761, 10));

		// Spion_Mage Spawn Points
		AddSpawnPoint( "f_siauliai_47_4.Id6", "f_siauliai_47_4", Spot(1429.0386, -310.9054, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id6", "f_siauliai_47_4", Spot(1863.5824, -227.40257, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id6", "f_siauliai_47_4", Spot(1715.3224, -448.7328, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id6", "f_siauliai_47_4", Spot(1029.5599, -606.19464, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id6", "f_siauliai_47_4", Spot(1225.8346, -880.4243, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id6", "f_siauliai_47_4", Spot(2454.3289, -772.398, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id6", "f_siauliai_47_4", Spot(2638.474, -960.3945, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id6", "f_siauliai_47_4", Spot(-491.77722, -1456.931, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id6", "f_siauliai_47_4", Spot(-505.80444, -1152.7832, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id6", "f_siauliai_47_4", Spot(-278.52023, -1301.6073, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id6", "f_siauliai_47_4", Spot(418.06613, -309.35153, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id6", "f_siauliai_47_4", Spot(661.4133, -211.05821, 40));
		AddSpawnPoint( "f_siauliai_47_4.Id6", "f_siauliai_47_4", Spot(230.04587, -114.22401, 40));

	}
}
