//--- Melia Script -----------------------------------------------------------
// f_maple_25_2
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Svalphinghas Forest' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FMaple252MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_maple_25_2", MonsterId.Elder_Rode, Properties("MHP", 532069, "MINPATK", 7343, "MAXPATK", 8926, "MINMATK", 7343, "MAXMATK", 8926, "DEF", 93796, "MDEF", 93796));
		AddPropertyOverrides("f_maple_25_2", MonsterId.Roderiot, Properties("MHP", 532069, "MINPATK", 7343, "MAXPATK", 8926, "MINMATK", 7343, "MAXMATK", 8926, "DEF", 93796, "MDEF", 93796));
		AddPropertyOverrides("f_maple_25_2", MonsterId.Rodedoe, Properties("MHP", 534014, "MINPATK", 7368, "MAXPATK", 8957, "MINMATK", 7368, "MAXMATK", 8957, "DEF", 94757, "MDEF", 94757));

		// Monster Spawners ---------------------------------

		AddSpawner("f_maple_25_2.Id1", MonsterId.Elder_Rode, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_25_2.Id2", MonsterId.Roderiot, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_25_2.Id3", MonsterId.Rodedoe, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_25_2.Id4", MonsterId.Elder_Rode, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_25_2.Id5", MonsterId.Roderiot, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_25_2.Id6", MonsterId.Rootcrystal_05, 27, 35, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Elder_Rode' GenType 17 Spawn Points
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-525.14954, 433.55634, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-359.07956, 278.444, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-445.58557, 117.62582, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-674.23517, 241.23074, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-507.48178, 192.20612, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-705.58875, 88.78464, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-612.00867, 4.1872063, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-187.11002, 301.48154, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-285.7949, 465.514, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-501.92255, 311.58847, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-583.91, 105.93497, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-812.7438, 19.357504, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-598.47784, 347.52017, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-273.9904, 183.73056, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-1303.8558, -469.1898, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-1417.81, -259.88, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-1213.8691, -336.57376, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-1208.1, -253.21, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-1106.54, -289.24, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-1096.68, -145.62, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-987.47, -54.35, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-1402.56, -144.34, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-1305.98, -123.7, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-1145.3633, 534.2825, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-893.1638, 523.16455, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-1001.6003, 572.04645, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-945.9302, 764.8969, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-882.6411, 901.2256, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-900.97473, 676.3768, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-1065.651, 649.1017, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-775.9468, 788.56384, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-638.4708, 1084.1288, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-485.66946, 1202.2561, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-474.9756, 1069.766, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-380.43835, 1129.9792, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-427.45114, 1203.7684, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-316.14014, 1265.2133, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-888.77167, 800.8956, 40));

		// 'Roderiot' GenType 18 Spawn Points
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-855.42, -744.47, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-875.1, -609.46, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-733.36, -603.72, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-750.8631, -701.12476, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-558.98, -596.13, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-874.44086, -496.49066, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-699.1272, -461.11395, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-471.33, -486.76, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-462.26, -589.3, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-491.56, -675.57, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-626.23114, -704.33124, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-394.7, -530.03, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-964.22, -672.59, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-1062.65, -640.61, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-1594.8782, -742.5475, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-1532.5496, -693.59753, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-1531.3356, -576.13745, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-1437.1161, -646.3416, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-1316.4954, -620.80286, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-1272.8044, -652.64954, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-1125.074, -656.7092, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-728.964, -817.8555, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-555.417, -509.75934, 40));

		// 'Rodedoe' GenType 19 Spawn Points
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1410.14, -752.61, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1544.77, -611.75, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1553.84, -715.37, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1736.55, -651.32, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1303.13, -553.84, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1215.79, -415.19, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(890.0777, -130.44684, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1019.35, -103.21, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1043.9508, 70.92507, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1225.35, -23.08, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1413.49, -124.65, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1458.02, -221.77, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1701.26, -229.11, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1659.6029, -269.4313, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1714.0562, -293.25024, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1690.28, -494.03, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1307.72, -697.08, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1068.2278, -248.41377, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1111.6335, -374.6622, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1112.8956, 205.12689, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(637.75134, 378.21558, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(379.5187, 497.89236, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(462.4697, 627.3344, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(661.6657, 470.72842, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(719.7576, 631.91425, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(789.00903, 466.8343, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(843.47156, 338.94522, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(859.12976, 466.2273, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1217.7996, 469.65765, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1238.9307, 326.90002, 40));

		// 'Elder_Rode' GenType 20 Spawn Points
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(352.44, -1095.53, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(359.08, -942.41, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(465.57, -773.75, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(504.35, -1006.74, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(480.41, -1123.53, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(827.75, -816.49, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(562.94, -921.8, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(1102.23, -987.89, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(1153.41, -1093, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(1026.2805, -1115.8739, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(1220.87, -1360.54, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(1090.7747, -848.09656, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(1269.22, -1243.21, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(1350.68, -1115.38, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(1356.1, -966.74, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(1229.65, -987.49, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(1487.43, -1270.52, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(521.45, -299.64, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(373.28967, -149.4655, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(566.9, -139.49, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(511.03, -214.84, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(630.61, -236.65, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(492.12, -431.33, 40));

		// 'Roderiot' GenType 21 Spawn Points
		AddSpawnPoint("f_maple_25_2.Id5", "f_maple_25_2", Rectangle(-380.42, 183.77, 9999));

		// 'Rootcrystal_05' GenType 33 Spawn Points
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(1650.66, -233.44, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(1316.37, -72.71, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(1121.91, 120.35, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(1133.85, -314.48, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(1430.31, -635.35, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(1677.05, -646.27, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(1265.93, 502.1, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(1288.38, 872.36, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(773.99, 373.4, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(481.19, 459.03, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(173.24, 601.37, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(1419.06, -1286.93, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(1238.03, -1087.57, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(1013.83, -924.46, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(650.18, -908.43, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(419.69, -1067.22, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(259.51, -798.67, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(-309.85, -476.32, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(-511.38, -624.53, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(-792.86, -617.03, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(-1334.68, -655.92, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(-1700.46, -672.52, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(-1589.4, -401.15, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(-1322.28, -351.07, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(-1167.94, -198.39, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(-844.09, 51.31, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(-621.5, 123.11, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(-393.41, 350.15, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(-962.72, 438.23, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(-1007.52, 698.9, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(-799.11, 853.9, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(-519.76, 1126.68, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(-296.46, 1201.12, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(429.62, -141.51, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(561.09, -435.29, 15));
	}
}
