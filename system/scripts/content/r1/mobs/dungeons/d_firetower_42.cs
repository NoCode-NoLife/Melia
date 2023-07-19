//--- Melia Script -----------------------------------------------------------
// d_firetower_42
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Mage Tower 2F' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DFiretower42MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_firetower_42", MonsterId.Tower_Of_Firepuppet, Properties("MHP", 95434, "MINPATK", 1728, "MAXPATK", 2026, "MINMATK", 1728, "MAXMATK", 2026, "DEF", 1030, "MDEF", 1030));
		AddPropertyOverrides("d_firetower_42", MonsterId.Slime_Elite, Properties("MHP", 96577, "MINPATK", 1743, "MAXPATK", 2044, "MINMATK", 1743, "MAXMATK", 2044, "DEF", 1067, "MDEF", 1067));
		AddPropertyOverrides("d_firetower_42", MonsterId.Blindlem, Properties("MHP", 97762, "MINPATK", 1758, "MAXPATK", 2063, "MINMATK", 1758, "MAXMATK", 2063, "DEF", 1106, "MDEF", 1106));
		AddPropertyOverrides("d_firetower_42", MonsterId.Belegg, Properties("MHP", 98988, "MINPATK", 1774, "MAXPATK", 2082, "MINMATK", 1774, "MAXMATK", 2082, "DEF", 1145, "MDEF", 1145));
		AddPropertyOverrides("d_firetower_42", MonsterId.Chromadog, Properties("MHP", 100252, "MINPATK", 1790, "MAXPATK", 2102, "MINMATK", 1790, "MAXMATK", 2102, "DEF", 1187, "MDEF", 1187));
		AddPropertyOverrides("d_firetower_42", MonsterId.Slime_Elite_Big, Properties("MHP", 101554, "MINPATK", 1807, "MAXPATK", 2123, "MINMATK", 1807, "MAXMATK", 2123, "DEF", 1229, "MDEF", 1229));
		AddPropertyOverrides("d_firetower_42", MonsterId.Boss_Archon_Q2, Properties("MHP", 512403, "MINPATK", 4159, "MAXPATK", 4888, "MINMATK", 4159, "MAXMATK", 4888, "DEF", 2902, "MDEF", 2902));

		// Monster Spawners ---------------------------------

		AddSpawner("d_firetower_42.Id1", MonsterId.Rootcrystal_01, 8, 10, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("d_firetower_42.Id2", MonsterId.Tower_Of_Firepuppet, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_42.Id3", MonsterId.Slime_Elite, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_42.Id4", MonsterId.Blindlem, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_42.Id5", MonsterId.Belegg, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_42.Id6", MonsterId.Chromadog, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_42.Id7", MonsterId.Slime_Elite_Big, 3, 3, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 1 Spawn Points
		AddSpawnPoint("d_firetower_42.Id1", "d_firetower_42", Rectangle(-1233.47, -1565.7408, 100));
		AddSpawnPoint("d_firetower_42.Id1", "d_firetower_42", Rectangle(-1297.3345, -1163.4384, 100));
		AddSpawnPoint("d_firetower_42.Id1", "d_firetower_42", Rectangle(-601.7124, -928.62244, 100));
		AddSpawnPoint("d_firetower_42.Id1", "d_firetower_42", Rectangle(-75.51962, -549.5192, 100));
		AddSpawnPoint("d_firetower_42.Id1", "d_firetower_42", Rectangle(1018.0579, -563.6439, 100));
		AddSpawnPoint("d_firetower_42.Id1", "d_firetower_42", Rectangle(1019.06, -1276.4159, 100));
		AddSpawnPoint("d_firetower_42.Id1", "d_firetower_42", Rectangle(344.8463, 226.629, 100));
		AddSpawnPoint("d_firetower_42.Id1", "d_firetower_42", Rectangle(1000.5682, -32.50673, 100));
		AddSpawnPoint("d_firetower_42.Id1", "d_firetower_42", Rectangle(1877.9807, -1247.6713, 100));
		AddSpawnPoint("d_firetower_42.Id1", "d_firetower_42", Rectangle(2036.519, -97.05841, 100));

		// 'Tower_Of_Firepuppet' GenType 7 Spawn Points
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(-1317.3407, -1290.0428, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(1907.6504, -9.271048, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(-147.98462, -661.03156, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(1889.1278, -1414.1587, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(995.329, 85.54171, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(-1509.8949, -1342.0801, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(-1639.3333, -1163.9647, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(-1341.1572, -1115.9087, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(-343.5158, -710.1771, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(-425.8968, -546.14667, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(-297.71097, -544.27985, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(-236.08319, -430.24316, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(856.60736, 114.36521, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(1004.0348, 261.98605, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(1133.3861, 97.43249, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(1009.6263, -72.45756, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(1841.6116, -219.30786, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(2051.7598, -90.08849, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(1894.0302, -1238.8832, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(1745.7709, -1362.3739, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(2031.6908, -1364.7045, 25));
		AddSpawnPoint("d_firetower_42.Id2", "d_firetower_42", Rectangle(1784.0067, -1523.2876, 25));

		// 'Slime_Elite' GenType 206 Spawn Points
		AddSpawnPoint("d_firetower_42.Id3", "d_firetower_42", Rectangle(303.34415, 29.514408, 35));
		AddSpawnPoint("d_firetower_42.Id3", "d_firetower_42", Rectangle(297.5315, 255.53534, 35));
		AddSpawnPoint("d_firetower_42.Id3", "d_firetower_42", Rectangle(1001.9247, -187.92426, 35));
		AddSpawnPoint("d_firetower_42.Id3", "d_firetower_42", Rectangle(1820.1403, -164.52592, 35));
		AddSpawnPoint("d_firetower_42.Id3", "d_firetower_42", Rectangle(2023.7733, -158.94469, 35));
		AddSpawnPoint("d_firetower_42.Id3", "d_firetower_42", Rectangle(985.78033, -1267.7897, 35));
		AddSpawnPoint("d_firetower_42.Id3", "d_firetower_42", Rectangle(995.1765, -1450.8601, 35));
		AddSpawnPoint("d_firetower_42.Id3", "d_firetower_42", Rectangle(1952.113, -1294.123, 35));
		AddSpawnPoint("d_firetower_42.Id3", "d_firetower_42", Rectangle(1748.7242, -1464.3452, 35));
		AddSpawnPoint("d_firetower_42.Id3", "d_firetower_42", Rectangle(1004.7512, -343.19214, 35));
		AddSpawnPoint("d_firetower_42.Id3", "d_firetower_42", Rectangle(237.19907, -564.3433, 35));
		AddSpawnPoint("d_firetower_42.Id3", "d_firetower_42", Rectangle(-1192.1632, -684.8848, 35));
		AddSpawnPoint("d_firetower_42.Id3", "d_firetower_42", Rectangle(-746.311, -985.01, 35));
		AddSpawnPoint("d_firetower_42.Id3", "d_firetower_42", Rectangle(-503.1838, -833.2771, 35));
		AddSpawnPoint("d_firetower_42.Id3", "d_firetower_42", Rectangle(-1499.5596, -1023.9939, 35));
		AddSpawnPoint("d_firetower_42.Id3", "d_firetower_42", Rectangle(-1563.6483, -1373.9075, 35));
		AddSpawnPoint("d_firetower_42.Id3", "d_firetower_42", Rectangle(-1003.8724, -1379.8083, 35));
		AddSpawnPoint("d_firetower_42.Id3", "d_firetower_42", Rectangle(1902.6228, -433.4902, 35));
		AddSpawnPoint("d_firetower_42.Id3", "d_firetower_42", Rectangle(1910.7083, -627.4663, 35));

		// 'Blindlem' GenType 210 Spawn Points
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(1025.6202, -1356.4578, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(1901.6804, -1407.6364, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(1979.8394, -91.792984, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(-911.2397, -827.32666, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(214.70383, 134.30368, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(265.48093, -51.10402, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(410.0188, 311.71732, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(565.3083, 97.67298, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(1783.4019, -195.85757, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(1842.9833, -45.65327, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(1901.9698, -332.05515, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(1729.7704, -1385.2092, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(1770.1063, -1287.6307, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(1939.6367, -1260.6539, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(2028.7748, -1497.5675, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(1824.5757, -1533.838, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(1070.8043, -1467.4325, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(936.10815, -1501.964, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(855.6918, -1402.0452, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(1034.6163, -1206.0804, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(924.03314, -1254.5933, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(1353.7721, -1373.233, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(1537.6055, -1377.9417, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(-1021.2734, -875.44116, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(-1168.7859, -830.62836, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(-1148.5804, -670.6097, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(-960.2613, -651.8915, 25));
		AddSpawnPoint("d_firetower_42.Id4", "d_firetower_42", Rectangle(-1015.4779, -537.34717, 25));

		// 'Belegg' GenType 211 Spawn Points
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(-375.34863, -448.5401, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(-1001.6938, -542.42615, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(-1491.0902, -1213.8075, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(-1344.2485, -1158.3971, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(-1149.66, -792.2036, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(-257.54813, -706.1676, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(376.1453, -546.2456, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(787.7381, -561.0685, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(-685.49963, -1037.7317, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(849.37915, 124.41502, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(334.36154, -276.03595, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(480.1177, 104.52153, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(-859.8411, -1207.6437, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(-416.77347, -630.5639, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(167.00345, -594.80865, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(460.6744, -518.9339, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(1047.2975, -499.3515, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(1184.0549, -570.39417, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(1011.1339, 21.598434, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(235.69858, 26.11716, 30));
		AddSpawnPoint("d_firetower_42.Id5", "d_firetower_42", Rectangle(-501.5403, -865.5036, 30));

		// 'Chromadog' GenType 220 Spawn Points
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(1890.7637, -276.26657, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(1806.4221, -88.11832, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(2056.3113, -99.81035, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(1920.2054, -1225.1904, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(1745.0889, -1386.6698, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(1042.1647, -1268.5201, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(1034.9764, -1475.8766, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(898.83344, -1327.3418, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(993.0288, -33.873566, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(518.7277, 120.06935, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(-104.32297, -569.91223, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(338.75864, -558.56244, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(1154.0022, -564.26666, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(1002.6016, 215.73451, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(-434.44693, -634.022, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(890.8662, -543.6962, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(903.84247, 128.57948, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(1955.0199, -40.69555, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(1903.1754, -1505.819, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(1941.9113, -1409.4073, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(1167.5089, -1380.0353, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(-285.3943, -500.14584, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(-271.80878, -751.8331, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(158.61298, -553.1037, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(342.28195, -133.91325, 30));
		AddSpawnPoint("d_firetower_42.Id6", "d_firetower_42", Rectangle(254.06375, 25.156986, 30));

		// 'Slime_Elite_Big' GenType 221 Spawn Points
		AddSpawnPoint("d_firetower_42.Id7", "d_firetower_42", Rectangle(973.41595, 81.120926, 9999));
	}
}
