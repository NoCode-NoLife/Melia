//--- Melia Script -----------------------------------------------------------
// d_firetower_61_2
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Roxona Reconstruction Agency East Building' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DFiretower612MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("d_firetower_61_2.Id1", MonsterId.Velffigy, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_61_2.Id2", MonsterId.Glyquare, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_61_2.Id3", MonsterId.Colifly_Black, 38, 50, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_61_2.Id4", MonsterId.Glyquare, 6, 7, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_61_2.Id5", MonsterId.Altarcrystal_R1, 1, 1, TimeSpan.FromMilliseconds(120000), TendencyType.Peaceful);
		AddSpawner("d_firetower_61_2.Id6", MonsterId.Altarcrystal_R1, 2, 2, TimeSpan.FromMilliseconds(120000), TendencyType.Peaceful);
		AddSpawner("d_firetower_61_2.Id7", MonsterId.Altarcrystal_R1, 2, 2, TimeSpan.FromMilliseconds(180000), TendencyType.Peaceful);
		AddSpawner("d_firetower_61_2.Id8", MonsterId.Altarcrystal_R1, 0, 0, TimeSpan.FromMilliseconds(120000), TendencyType.Peaceful);
		AddSpawner("d_firetower_61_2.Id9", MonsterId.Altarcrystal_R1, 0, 0, TimeSpan.FromMilliseconds(120000), TendencyType.Peaceful);
		AddSpawner("d_firetower_61_2.Id10", MonsterId.Rootcrystal_04, 19, 25, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("d_firetower_61_2.Id11", MonsterId.Colifly_Black, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Velffigy' GenType 1 Spawn Points
		AddSpawnPoint("d_firetower_61_2.Id1", "d_firetower_61_2", Rectangle(-1431.7407, -373.7156, 25));
		AddSpawnPoint("d_firetower_61_2.Id1", "d_firetower_61_2", Rectangle(-1197.2213, -313.84442, 25));
		AddSpawnPoint("d_firetower_61_2.Id1", "d_firetower_61_2", Rectangle(-1091.212, -407.8043, 25));
		AddSpawnPoint("d_firetower_61_2.Id1", "d_firetower_61_2", Rectangle(-1112.5913, -192.30505, 25));
		AddSpawnPoint("d_firetower_61_2.Id1", "d_firetower_61_2", Rectangle(-1115.5388, -945.24146, 25));
		AddSpawnPoint("d_firetower_61_2.Id1", "d_firetower_61_2", Rectangle(-1057.9738, -1090.5011, 25));
		AddSpawnPoint("d_firetower_61_2.Id1", "d_firetower_61_2", Rectangle(-990.09436, -895.50183, 25));
		AddSpawnPoint("d_firetower_61_2.Id1", "d_firetower_61_2", Rectangle(-1021.4375, -338.55508, 25));
		AddSpawnPoint("d_firetower_61_2.Id1", "d_firetower_61_2", Rectangle(-25.553566, -329.86768, 25));
		AddSpawnPoint("d_firetower_61_2.Id1", "d_firetower_61_2", Rectangle(-20.450117, -103.81765, 25));
		AddSpawnPoint("d_firetower_61_2.Id1", "d_firetower_61_2", Rectangle(95.64402, -365.05377, 25));
		AddSpawnPoint("d_firetower_61_2.Id1", "d_firetower_61_2", Rectangle(-1158.6747, -830.21796, 25));
		AddSpawnPoint("d_firetower_61_2.Id1", "d_firetower_61_2", Rectangle(-1171.368, -1055.7109, 25));
		AddSpawnPoint("d_firetower_61_2.Id1", "d_firetower_61_2", Rectangle(-204.05681, -416.8491, 25));

		// 'Glyquare' GenType 5 Spawn Points
		AddSpawnPoint("d_firetower_61_2.Id2", "d_firetower_61_2", Rectangle(-80.08702, -553.59406, 20));
		AddSpawnPoint("d_firetower_61_2.Id2", "d_firetower_61_2", Rectangle(-373.66934, -218.03583, 20));
		AddSpawnPoint("d_firetower_61_2.Id2", "d_firetower_61_2", Rectangle(315.68256, -289.18484, 20));
		AddSpawnPoint("d_firetower_61_2.Id2", "d_firetower_61_2", Rectangle(-95.69986, 310.03525, 20));
		AddSpawnPoint("d_firetower_61_2.Id2", "d_firetower_61_2", Rectangle(-264.2704, -1636.0778, 20));
		AddSpawnPoint("d_firetower_61_2.Id2", "d_firetower_61_2", Rectangle(-1156.2947, -96.71889, 20));
		AddSpawnPoint("d_firetower_61_2.Id2", "d_firetower_61_2", Rectangle(-1298.8236, -380.68005, 20));
		AddSpawnPoint("d_firetower_61_2.Id2", "d_firetower_61_2", Rectangle(-988.7201, -387.66208, 20));
		AddSpawnPoint("d_firetower_61_2.Id2", "d_firetower_61_2", Rectangle(-1830.5225, -789.5636, 20));
		AddSpawnPoint("d_firetower_61_2.Id2", "d_firetower_61_2", Rectangle(-1930.1912, -761.11536, 20));
		AddSpawnPoint("d_firetower_61_2.Id2", "d_firetower_61_2", Rectangle(-1761.5911, -1094.6093, 20));
		AddSpawnPoint("d_firetower_61_2.Id2", "d_firetower_61_2", Rectangle(-877.9078, 414.11636, 20));
		AddSpawnPoint("d_firetower_61_2.Id2", "d_firetower_61_2", Rectangle(-1127.7201, 391.1861, 20));
		AddSpawnPoint("d_firetower_61_2.Id2", "d_firetower_61_2", Rectangle(13.712185, 391.22717, 20));
		AddSpawnPoint("d_firetower_61_2.Id2", "d_firetower_61_2", Rectangle(72.148125, 442.92538, 20));
		AddSpawnPoint("d_firetower_61_2.Id2", "d_firetower_61_2", Rectangle(-111.06657, 420.84894, 20));

		// 'Colifly_Black' GenType 6 Spawn Points
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-263.38623, -1387.753, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(52.117355, -1500.4506, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-168.8102, -1681.4636, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(18.422592, -1726.5286, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(130.38107, -1365.9937, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-68.30894, -1553.6849, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-203.87325, 457.9995, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-89.41062, 622.4146, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(5.5711203, 321.3824, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(148.11084, 535.3407, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-152.46857, -306.94495, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-102.33487, -489.62552, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(135.1023, -198.69759, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(30.338118, 514.7768, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1747.1843, -1138.2147, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1951.2183, -1102.3798, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1877.9552, -1075.7811, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-2021.9552, -1051.832, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1895.769, -930.7605, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1979.1666, -927.482, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1906.2935, -843.2833, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1811.7848, -862.0028, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1822.9647, -967.4885, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1770.7352, -915.24677, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1991.977, -896.6621, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-2052.4832, -977.0575, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1948.5465, -1005.1256, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-2033.226, -1140.1952, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1889.508, -1245.2958, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1828.124, -1366.291, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1919.8715, -1309.456, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1809.6232, -1217.4867, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1757.9197, -1302.1233, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1820.1978, -1285.5302, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1959.4849, -1174.5795, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1870.935, -1154.5785, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1819.0521, -1168.4374, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1957.0787, -1359.0927, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-2018.0183, -1249.8922, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1373.5748, -330.97385, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1344.2911, -302.55054, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1357.8173, -385.0467, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1163.9352, -348.93274, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1132.9614, -316.70972, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1148.9031, -186.98254, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1111.854, -137.34506, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1119.605, -382.03806, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1140.4968, -437.70782, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1032.2008, -390.89343, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-941.0788, -429.35315, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-927.3073, -180.52184, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1004.8576, -142.93648, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1085.8091, -505.22504, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1174.3112, -468.8183, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1187.9215, -429.0553, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1039.7773, -220.85542, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-898.9785, -340.7307, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-944.2581, -270.51953, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1091.7782, -834.8314, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1028.9142, -822.22894, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-942.424, -973.8567, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-902.26117, -1095.3467, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-975.0369, -1149.327, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1018.0846, -1055.1709, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1059.9465, -935.9816, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1119.1234, -880.2278, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1196.979, -968.5065, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1153.2429, -915.54565, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1105.4971, -1015.0311, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1070.5668, -1144.186, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-1003.4755, -947.7973, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-912.56525, -942.6312, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-889.5767, -1013.4971, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-174.4221, -1378.8413, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-82.43217, -1319.6519, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(3.7467384, -1347.3662, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(30.998508, -1432.4005, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-54.388393, -1421.3157, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-216.12723, -1477.8949, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-144.74062, -1500.4299, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-341.55234, -1544.4052, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-224.8298, -1568.0981, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-98.24138, -1730.6023, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-27.526947, -1638.2731, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-32.17354, -1729.298, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(34.712982, -1583.7415, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(78.258995, -1689.2218, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(153.46867, -1617.4987, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(155.93686, -1536.0018, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(124.1667, -1442.1172, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(267.85205, -1534.6411, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(82.70325, -1553.327, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-113.39706, -1430.2542, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-335.91943, -1638.1367, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-47.28769, -762.01227, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-208.74464, -147.71667, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-84.89114, -118.36432, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(51.150227, -109.07436, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(78.4673, -236.64165, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-31.607689, -205.52534, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(24.802315, -219.63876, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-140.65503, -203.2441, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-91.18999, -265.8502, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-248.95451, -213.5064, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-236.18155, -323.9439, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-121.6149, -395.23352, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-40.490532, -417.9446, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-18.3205, -492.81396, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(80.080734, -504.52615, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(118.25024, -436.6506, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(176.30586, -334.33884, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(251.89514, -311.56982, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(37.531296, -360.40158, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(71.50948, -288.18805, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-88.58531, -350.30734, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-216.97975, 382.22516, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-162.35912, 335.02682, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-49.688545, 377.33344, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-238.05539, 537.237, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-183.54124, 607.78235, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-153.49748, 546.7242, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-32.078327, 651.0751, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-57.6185, 565.8256, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(73.49714, 625.61694, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(86.50314, 531.117, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(142.42609, 439.97034, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(72.21219, 375.70886, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-73.85105, 425.62445, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(-97.7568, 471.3947, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(11.030205, 599.45264, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(850.85516, -1018.6384, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(868.10187, -934.74805, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(948.9994, -863.4148, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(999.55646, -813.3364, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1120.1257, -848.38715, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1171.5007, -935.4549, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1048.318, -948.1751, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1122.2921, -1027.2582, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1070.4291, -1094.2755, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(940.3153, -1130.1722, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(822.9505, -1053.4656, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(923.4847, -978.3656, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(934.71796, -926.38763, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1118.6027, -951.7253, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1012.4443, -1085.7911, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(867.24457, -1107.0449, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(929.8285, -1037.7017, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(827.823, -974.0141, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(883.0423, -980.93335, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1028.2488, -864.48987, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(814.34784, -356.39734, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(908.7444, -475.87888, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1065.0903, -504.2027, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1157.3969, -447.01236, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(870.7323, -275.8858, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(912.72363, -178.09882, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1008.5615, -160.12462, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1141.2054, -211.8306, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1165.5387, -304.33667, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1210.5378, -379.78268, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(988.49677, -341.579, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(933.66254, -223.37015, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1061.5696, -208.00891, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1113.0171, -269.79645, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1036.2834, -411.21167, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(864.0459, -420.29788, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(876.8098, -340.93967, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(926.7416, -297.82468, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(983.1606, -276.3331, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(936.84375, -399.20682, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1014.1037, 405.7718, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(983.6931, 465.14618, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1026.5812, 461.27264, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1005.9776, 527.0301, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(1020.7424, 497.60947, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(690.2988, 775.20215, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(604.1277, 942.25836, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(680.92206, 937.6915, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(722.62134, 872.8166, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(776.8606, 729.72797, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(701.11127, 582.45306, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(683.81836, 708.0638, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(608.4566, 778.2559, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(625.43616, 846.51746, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(666.46045, 1003.7403, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(734.62213, 976.4207, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(788.2094, 964.8246, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(821.54224, 884.5974, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(798.5053, 811.3087, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(805.90375, 661.87604, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(597.0882, 560.1102, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(786.1953, 563.30884, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(724.89795, 638.9576, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(849.9329, 723.4696, 30));
		AddSpawnPoint("d_firetower_61_2.Id3", "d_firetower_61_2", Rectangle(622.9079, 650.11816, 30));

		// 'Glyquare' GenType 7 Spawn Points
		AddSpawnPoint("d_firetower_61_2.Id4", "d_firetower_61_2", Rectangle(844.94836, -217.33931, 20));
		AddSpawnPoint("d_firetower_61_2.Id4", "d_firetower_61_2", Rectangle(807.63824, -398.38376, 20));
		AddSpawnPoint("d_firetower_61_2.Id4", "d_firetower_61_2", Rectangle(1096.9713, -388.40448, 20));
		AddSpawnPoint("d_firetower_61_2.Id4", "d_firetower_61_2", Rectangle(1125.8456, -507.1603, 20));
		AddSpawnPoint("d_firetower_61_2.Id4", "d_firetower_61_2", Rectangle(1057.9904, 287.36832, 20));
		AddSpawnPoint("d_firetower_61_2.Id4", "d_firetower_61_2", Rectangle(984.0198, 363.48492, 20));
		AddSpawnPoint("d_firetower_61_2.Id4", "d_firetower_61_2", Rectangle(1022.7634, -1164.3113, 20));
		AddSpawnPoint("d_firetower_61_2.Id4", "d_firetower_61_2", Rectangle(956.7792, -522.06903, 20));

		// 'Altarcrystal_R1' GenType 10 Spawn Points
		AddSpawnPoint("d_firetower_61_2.Id5", "d_firetower_61_2", Rectangle(-1012.631, 664.6173, 300));
		AddSpawnPoint("d_firetower_61_2.Id5", "d_firetower_61_2", Rectangle(-1072.7903, -309.19778, 300));
		AddSpawnPoint("d_firetower_61_2.Id5", "d_firetower_61_2", Rectangle(-1056.6254, -993.47156, 300));
		AddSpawnPoint("d_firetower_61_2.Id5", "d_firetower_61_2", Rectangle(-40.25824, -292.2879, 300));
		AddSpawnPoint("d_firetower_61_2.Id5", "d_firetower_61_2", Rectangle(-57.938942, 507.53284, 300));
		AddSpawnPoint("d_firetower_61_2.Id5", "d_firetower_61_2", Rectangle(737.2407, 843.76746, 300));
		AddSpawnPoint("d_firetower_61_2.Id5", "d_firetower_61_2", Rectangle(1048.8757, -327.2196, 300));
		AddSpawnPoint("d_firetower_61_2.Id5", "d_firetower_61_2", Rectangle(979.13165, -960.30054, 300));
		AddSpawnPoint("d_firetower_61_2.Id5", "d_firetower_61_2", Rectangle(-19.130009, -1491.8821, 300));
		AddSpawnPoint("d_firetower_61_2.Id5", "d_firetower_61_2", Rectangle(-1848.5808, -1009.1371, 300));

		// 'Altarcrystal_R1' GenType 11 Spawn Points
		AddSpawnPoint("d_firetower_61_2.Id6", "d_firetower_61_2", Rectangle(-1005.3524, 569.2304, 300));
		AddSpawnPoint("d_firetower_61_2.Id6", "d_firetower_61_2", Rectangle(-1056.4207, -287.19565, 300));
		AddSpawnPoint("d_firetower_61_2.Id6", "d_firetower_61_2", Rectangle(-1882.2073, -1012.758, 300));
		AddSpawnPoint("d_firetower_61_2.Id6", "d_firetower_61_2", Rectangle(6.759445, -313.87262, 300));
		AddSpawnPoint("d_firetower_61_2.Id6", "d_firetower_61_2", Rectangle(1043.2379, -326.20966, 300));
		AddSpawnPoint("d_firetower_61_2.Id6", "d_firetower_61_2", Rectangle(-4.409672, 460.06082, 300));
		AddSpawnPoint("d_firetower_61_2.Id6", "d_firetower_61_2", Rectangle(-84.133865, -1530.3517, 300));
		AddSpawnPoint("d_firetower_61_2.Id6", "d_firetower_61_2", Rectangle(993.46387, -1007.6141, 300));
		AddSpawnPoint("d_firetower_61_2.Id6", "d_firetower_61_2", Rectangle(735.86475, 770.3753, 300));

		// 'Altarcrystal_R1' GenType 12 Spawn Points
		AddSpawnPoint("d_firetower_61_2.Id7", "d_firetower_61_2", Rectangle(-906.0661, 644.5948, 300));
		AddSpawnPoint("d_firetower_61_2.Id7", "d_firetower_61_2", Rectangle(-1831.4535, -1013.6485, 300));
		AddSpawnPoint("d_firetower_61_2.Id7", "d_firetower_61_2", Rectangle(-1073.9003, -321.4914, 300));
		AddSpawnPoint("d_firetower_61_2.Id7", "d_firetower_61_2", Rectangle(-25.649597, -283.2552, 300));
		AddSpawnPoint("d_firetower_61_2.Id7", "d_firetower_61_2", Rectangle(1052.5945, -319.44174, 300));

		// 'Altarcrystal_R1' GenType 13 Spawn Points
		AddSpawnPoint("d_firetower_61_2.Id8", "d_firetower_61_2", Rectangle(-915.99506, 573.0324, 9999));

		// 'Altarcrystal_R1' GenType 14 Spawn Points
		AddSpawnPoint("d_firetower_61_2.Id9", "d_firetower_61_2", Rectangle(-875.2702, 680.19666, 9999));
		AddSpawnPoint("d_firetower_61_2.Id9", "d_firetower_61_2", Rectangle(-925.9638, 424.66965, 9999));

		// 'Rootcrystal_04' GenType 21 Spawn Points
		AddSpawnPoint("d_firetower_61_2.Id10", "d_firetower_61_2", Rectangle(-1873.3639, -1277.4486, 100));
		AddSpawnPoint("d_firetower_61_2.Id10", "d_firetower_61_2", Rectangle(-1889.3011, -892.6113, 100));
		AddSpawnPoint("d_firetower_61_2.Id10", "d_firetower_61_2", Rectangle(-1826.2543, -795.57007, 100));
		AddSpawnPoint("d_firetower_61_2.Id10", "d_firetower_61_2", Rectangle(-1173.814, -400.23428, 100));
		AddSpawnPoint("d_firetower_61_2.Id10", "d_firetower_61_2", Rectangle(-1074.9613, -210.37291, 100));
		AddSpawnPoint("d_firetower_61_2.Id10", "d_firetower_61_2", Rectangle(-1052.0419, -948.4551, 100));
		AddSpawnPoint("d_firetower_61_2.Id10", "d_firetower_61_2", Rectangle(-197.9282, -262.7729, 100));
		AddSpawnPoint("d_firetower_61_2.Id10", "d_firetower_61_2", Rectangle(76.11663, -293.13577, 100));
		AddSpawnPoint("d_firetower_61_2.Id10", "d_firetower_61_2", Rectangle(-205.86508, -1448.1238, 100));
		AddSpawnPoint("d_firetower_61_2.Id10", "d_firetower_61_2", Rectangle(131.23276, -1497.5342, 100));
		AddSpawnPoint("d_firetower_61_2.Id10", "d_firetower_61_2", Rectangle(934.8721, -1043.5072, 100));
		AddSpawnPoint("d_firetower_61_2.Id10", "d_firetower_61_2", Rectangle(1015.1567, -250.05276, 100));
		AddSpawnPoint("d_firetower_61_2.Id10", "d_firetower_61_2", Rectangle(741.6699, 474.57523, 100));
		AddSpawnPoint("d_firetower_61_2.Id10", "d_firetower_61_2", Rectangle(702.38586, 783.4421, 100));
		AddSpawnPoint("d_firetower_61_2.Id10", "d_firetower_61_2", Rectangle(-144.94037, 435.41196, 100));
		AddSpawnPoint("d_firetower_61_2.Id10", "d_firetower_61_2", Rectangle(-981.8545, 744.6742, 100));
		AddSpawnPoint("d_firetower_61_2.Id10", "d_firetower_61_2", Rectangle(-1099.5612, 540.6172, 100));
		AddSpawnPoint("d_firetower_61_2.Id10", "d_firetower_61_2", Rectangle(-2019.2324, 1533.5815, 100));
		AddSpawnPoint("d_firetower_61_2.Id10", "d_firetower_61_2", Rectangle(-2059, 1090.3284, 100));
		AddSpawnPoint("d_firetower_61_2.Id10", "d_firetower_61_2", Rectangle(1575.6272, -1660.4409, 100));
		AddSpawnPoint("d_firetower_61_2.Id10", "d_firetower_61_2", Rectangle(1795.2548, -1404.2074, 100));

		// 'Colifly_Black' GenType 24 Spawn Points
		AddSpawnPoint("d_firetower_61_2.Id11", "d_firetower_61_2", Rectangle(-1080.283, -276.1409, 9999));
	}
}
