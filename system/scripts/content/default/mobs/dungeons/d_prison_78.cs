//--- Melia Script -----------------------------------------------------------
// d_prison_78
//
//--- Description -----------------------------------------------------------
// Sets up the d_prison_78 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DPrison78MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("d_prison_78", MonsterId.TerraNymph_Brown, Properties("MHP", 407538, "MINPATK", 5741, "MAXPATK", 6958, "MINMATK", 5741, "MAXMATK", 6958, "DEF", 47157, "MDEF", 47157));
		AddPropertyOverrides("d_prison_78", MonsterId.NightMaiden_Mage_Red, Properties("MHP", 409764, "MINPATK", 5770, "MAXPATK", 6994, "MINMATK", 5770, "MAXMATK", 6994, "DEF", 47867, "MDEF", 47867));
		AddPropertyOverrides("d_prison_78", MonsterId.Elet_Blue, Properties("MHP", 412085, "MINPATK", 5800, "MAXPATK", 7030, "MINMATK", 5800, "MAXMATK", 7030, "DEF", 48607, "MDEF", 48607));

		// Monster Spawners --------------------------------

		AddSpawner("d_prison_78.Id1", MonsterId.TerraNymph_Brown, 45, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_prison_78.Id2", MonsterId.NightMaiden_Mage_Red, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_prison_78.Id3", MonsterId.Elet_Blue, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_prison_78.Id4", MonsterId.Rootcrystal_05, 15, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_prison_78.Id5", MonsterId.TerraNymph_Brown, 35, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// TerraNymph_Brown Spawn Points
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(446.53873, -864.47296, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(364.8538, -646.945, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(525.4409, -751.9327, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(626.593, -930.29315, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(763.55396, -681.99066, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(620.715, -636.01044, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(809.3448, -923.0619, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(711.6144, -828.9484, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(761.004, -610.8526, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(575.6823, 1025.7289, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(571.3091, 1481.2487, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(584.35596, 352.70044, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(771.7118, 255.63199, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(529.57043, 323.6729, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(585.20416, 538.3751, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(183.94193, 797.1341, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(479.24963, 812.282, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(597.2934, 1099.4169, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(614.09515, 1335.4291, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(407.11618, 1594.7867, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(502.32715, 1982.5498, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(800.76263, 1885.8645, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(659.0087, 1738.4851, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(876.17804, 1550.0754, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(752.9651, 1467.7483, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(-174.50334, 2048.5732, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(-122.80452, 2240.559, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(-241.68056, 2215.7546, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(125.87511, 1964.0814, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(383.1362, 1885.2338, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(-164.97649, 772.5895, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(-150.01836, 486.06055, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(-367.50885, 884.17816, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(-538.81366, 733.88916, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(-540.40497, 404.2138, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(-725.8859, 225.27477, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(-610.72504, 478.84106, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(-1016.5823, 242.35846, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(-1274.8212, 352.96338, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(-1324.002, 73.015015, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(-1433.112, -200.99336, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(-1302.9847, -208.3953, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(-1199.5498, -577.28125, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(-1295.8392, -544.13184, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(-786.24927, -875.91064, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(-815.40027, -1056.6011, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(-589.31244, -897.1409, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(-1692.6621, -1336.4452, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(-1575.2671, -1102.7975, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(-1791.723, -1248.5972, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(-1263.8785, -1241.5149, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(-854.2545, -1285.4995, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(-224.26169, -971.32416, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(36.22043, -959.9673, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(17.75834, -1120.248, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(66.79683, -1332.1526, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(35.41514, -1473.422, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(-20.212616, -1844.1483, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(-32.885994, -1014.0906, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(133.77498, -991.2431, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(374.90796, -969.39105, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(-58.010067, -1588.4827, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(-67.32919, -1739.8096, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(61.481018, -1796.9469, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(149.23894, -1628.3685, 30));
		AddSpawnPoint( "d_prison_78.Id1", "d_prison_78", Spot(67.189575, -1680.297, 30));

		// NightMaiden_Mage_Red Spawn Points
		AddSpawnPoint( "d_prison_78.Id2", "d_prison_78", Spot(432.26254, -829.1761, 30));
		AddSpawnPoint( "d_prison_78.Id2", "d_prison_78", Spot(608.31616, -913.07294, 30));
		AddSpawnPoint( "d_prison_78.Id2", "d_prison_78", Spot(646.2894, -624.9331, 30));
		AddSpawnPoint( "d_prison_78.Id2", "d_prison_78", Spot(430.87305, -680.94385, 30));
		AddSpawnPoint( "d_prison_78.Id2", "d_prison_78", Spot(735.99243, -802.7093, 30));
		AddSpawnPoint( "d_prison_78.Id2", "d_prison_78", Spot(766.5919, -969.737, 30));
		AddSpawnPoint( "d_prison_78.Id2", "d_prison_78", Spot(829.9214, -725.4625, 30));
		AddSpawnPoint( "d_prison_78.Id2", "d_prison_78", Spot(559.5143, 274.6636, 30));
		AddSpawnPoint( "d_prison_78.Id2", "d_prison_78", Spot(710.8435, 454.94928, 30));
		AddSpawnPoint( "d_prison_78.Id2", "d_prison_78", Spot(509.13043, 410.66922, 30));
		AddSpawnPoint( "d_prison_78.Id2", "d_prison_78", Spot(677.12866, 274.71375, 30));
		AddSpawnPoint( "d_prison_78.Id2", "d_prison_78", Spot(813.41235, 438.32968, 30));
		AddSpawnPoint( "d_prison_78.Id2", "d_prison_78", Spot(-883.75903, -1093.0654, 30));
		AddSpawnPoint( "d_prison_78.Id2", "d_prison_78", Spot(-823.2636, -875.9432, 30));
		AddSpawnPoint( "d_prison_78.Id2", "d_prison_78", Spot(-764.4848, -989.1512, 30));
		AddSpawnPoint( "d_prison_78.Id2", "d_prison_78", Spot(-600.6813, -888.8713, 30));
		AddSpawnPoint( "d_prison_78.Id2", "d_prison_78", Spot(-556.46173, -992.7243, 30));
		AddSpawnPoint( "d_prison_78.Id2", "d_prison_78", Spot(-470.71045, -863.07043, 30));
		AddSpawnPoint( "d_prison_78.Id2", "d_prison_78", Spot(414.5681, -957.6153, 30));
		AddSpawnPoint( "d_prison_78.Id2", "d_prison_78", Spot(86.293755, -1387.4862, 30));
		AddSpawnPoint( "d_prison_78.Id2", "d_prison_78", Spot(-46.218544, -1355.4742, 30));
		AddSpawnPoint( "d_prison_78.Id2", "d_prison_78", Spot(-79.79742, -1454.0425, 30));
		AddSpawnPoint( "d_prison_78.Id2", "d_prison_78", Spot(7.5581894, -1440.9336, 30));
		AddSpawnPoint( "d_prison_78.Id2", "d_prison_78", Spot(28.653778, -1298.821, 30));
		AddSpawnPoint( "d_prison_78.Id2", "d_prison_78", Spot(10.508454, -1673.3059, 30));
		AddSpawnPoint( "d_prison_78.Id2", "d_prison_78", Spot(135.82355, -1657.9774, 30));
		AddSpawnPoint( "d_prison_78.Id2", "d_prison_78", Spot(61.698357, -1855.4242, 30));
		AddSpawnPoint( "d_prison_78.Id2", "d_prison_78", Spot(-51.035866, -1784.201, 30));
		AddSpawnPoint( "d_prison_78.Id2", "d_prison_78", Spot(-72.676575, -1657.5447, 30));
		AddSpawnPoint( "d_prison_78.Id2", "d_prison_78", Spot(-70.401535, -1533.099, 30));

		// Elet_Blue Spawn Points
		AddSpawnPoint( "d_prison_78.Id3", "d_prison_78", Spot(402.8964, 1589.7434, 30));
		AddSpawnPoint( "d_prison_78.Id3", "d_prison_78", Spot(380.22, 1854.8962, 30));
		AddSpawnPoint( "d_prison_78.Id3", "d_prison_78", Spot(714.2623, 1971.7306, 30));
		AddSpawnPoint( "d_prison_78.Id3", "d_prison_78", Spot(604.51886, 1752.8976, 30));
		AddSpawnPoint( "d_prison_78.Id3", "d_prison_78", Spot(650.317, 1565.4883, 30));
		AddSpawnPoint( "d_prison_78.Id3", "d_prison_78", Spot(806.5682, 1505.5409, 30));
		AddSpawnPoint( "d_prison_78.Id3", "d_prison_78", Spot(896.13354, 1792.9215, 30));
		AddSpawnPoint( "d_prison_78.Id3", "d_prison_78", Spot(-186.05069, 2062.6309, 30));
		AddSpawnPoint( "d_prison_78.Id3", "d_prison_78", Spot(-121.20614, 2323.9988, 30));
		AddSpawnPoint( "d_prison_78.Id3", "d_prison_78", Spot(-274.6891, 2231.761, 30));
		AddSpawnPoint( "d_prison_78.Id3", "d_prison_78", Spot(-136.32257, 2168.35, 30));
		AddSpawnPoint( "d_prison_78.Id3", "d_prison_78", Spot(81.531845, 1950.7197, 30));
		AddSpawnPoint( "d_prison_78.Id3", "d_prison_78", Spot(90.98158, 815.12524, 30));
		AddSpawnPoint( "d_prison_78.Id3", "d_prison_78", Spot(437.5857, 848.07355, 30));
		AddSpawnPoint( "d_prison_78.Id3", "d_prison_78", Spot(576.094, 770.457, 30));
		AddSpawnPoint( "d_prison_78.Id3", "d_prison_78", Spot(621.71643, 1134.9337, 30));
		AddSpawnPoint( "d_prison_78.Id3", "d_prison_78", Spot(605.1496, 1360.7949, 30));
		AddSpawnPoint( "d_prison_78.Id3", "d_prison_78", Spot(620.5667, 846.7958, 30));
		AddSpawnPoint( "d_prison_78.Id3", "d_prison_78", Spot(570.23065, 496.63168, 30));
		AddSpawnPoint( "d_prison_78.Id3", "d_prison_78", Spot(507.60757, 327.36832, 30));
		AddSpawnPoint( "d_prison_78.Id3", "d_prison_78", Spot(682.2833, 246.8629, 30));
		AddSpawnPoint( "d_prison_78.Id3", "d_prison_78", Spot(778.9418, 546.9431, 30));
		AddSpawnPoint( "d_prison_78.Id3", "d_prison_78", Spot(798.6555, 341.86212, 30));
		AddSpawnPoint( "d_prison_78.Id3", "d_prison_78", Spot(-697.5342, 266.83612, 30));
		AddSpawnPoint( "d_prison_78.Id3", "d_prison_78", Spot(-637.2754, 395.0652, 30));
		AddSpawnPoint( "d_prison_78.Id3", "d_prison_78", Spot(-598.3897, 286.23856, 30));
		AddSpawnPoint( "d_prison_78.Id3", "d_prison_78", Spot(-550.91187, 655.9357, 30));
		AddSpawnPoint( "d_prison_78.Id3", "d_prison_78", Spot(-486.42697, 851.72736, 30));
		AddSpawnPoint( "d_prison_78.Id3", "d_prison_78", Spot(-211.69395, 864.17676, 30));
		AddSpawnPoint( "d_prison_78.Id3", "d_prison_78", Spot(319.2632, 805.3293, 30));
		AddSpawnPoint( "d_prison_78.Id3", "d_prison_78", Spot(-192.86845, 553.7388, 30));
		AddSpawnPoint( "d_prison_78.Id3", "d_prison_78", Spot(289.36658, 826.94574, 30));

		// Rootcrystal_05 Spawn Points
		AddSpawnPoint( "d_prison_78.Id4", "d_prison_78", Spot(493.23944, -861.73517, 90));
		AddSpawnPoint( "d_prison_78.Id4", "d_prison_78", Spot(693.38495, -669.049, 90));
		AddSpawnPoint( "d_prison_78.Id4", "d_prison_78", Spot(1084.6987, -960.11285, 90));
		AddSpawnPoint( "d_prison_78.Id4", "d_prison_78", Spot(757.9109, 231.16193, 90));
		AddSpawnPoint( "d_prison_78.Id4", "d_prison_78", Spot(572.89886, 268.81723, 90));
		AddSpawnPoint( "d_prison_78.Id4", "d_prison_78", Spot(632.8487, 461.33325, 90));
		AddSpawnPoint( "d_prison_78.Id4", "d_prison_78", Spot(573.79193, 831.3737, 90));
		AddSpawnPoint( "d_prison_78.Id4", "d_prison_78", Spot(69.50025, 816.02826, 90));
		AddSpawnPoint( "d_prison_78.Id4", "d_prison_78", Spot(418.51404, 1566.0771, 90));
		AddSpawnPoint( "d_prison_78.Id4", "d_prison_78", Spot(403.6961, 1864.0348, 90));
		AddSpawnPoint( "d_prison_78.Id4", "d_prison_78", Spot(824.8934, 1684.7483, 90));
		AddSpawnPoint( "d_prison_78.Id4", "d_prison_78", Spot(802.76306, 1870.904, 90));
		AddSpawnPoint( "d_prison_78.Id4", "d_prison_78", Spot(-216.74307, 2034.9371, 90));
		AddSpawnPoint( "d_prison_78.Id4", "d_prison_78", Spot(-955.4511, 2372.8433, 90));
		AddSpawnPoint( "d_prison_78.Id4", "d_prison_78", Spot(-1179.2926, 2363.9307, 90));
		AddSpawnPoint( "d_prison_78.Id4", "d_prison_78", Spot(-225.46356, 584.464, 90));
		AddSpawnPoint( "d_prison_78.Id4", "d_prison_78", Spot(-560.32605, 428.01514, 90));
		AddSpawnPoint( "d_prison_78.Id4", "d_prison_78", Spot(-1009.2625, 237.98364, 90));
		AddSpawnPoint( "d_prison_78.Id4", "d_prison_78", Spot(-1418.324, -189.24971, 90));
		AddSpawnPoint( "d_prison_78.Id4", "d_prison_78", Spot(-1300.2515, -9.691544, 90));
		AddSpawnPoint( "d_prison_78.Id4", "d_prison_78", Spot(-1165.4497, -609.4968, 90));
		AddSpawnPoint( "d_prison_78.Id4", "d_prison_78", Spot(-717.353, -953.74316, 90));
		AddSpawnPoint( "d_prison_78.Id4", "d_prison_78", Spot(-526.8, -849.58295, 90));
		AddSpawnPoint( "d_prison_78.Id4", "d_prison_78", Spot(-1202.0337, -1248.8663, 90));
		AddSpawnPoint( "d_prison_78.Id4", "d_prison_78", Spot(-1543.3561, -1361.1674, 90));
		AddSpawnPoint( "d_prison_78.Id4", "d_prison_78", Spot(-1555.8351, -1114.8883, 90));
		AddSpawnPoint( "d_prison_78.Id4", "d_prison_78", Spot(293.82254, -1361.0592, 90));
		AddSpawnPoint( "d_prison_78.Id4", "d_prison_78", Spot(72.72354, -1408.656, 90));
		AddSpawnPoint( "d_prison_78.Id4", "d_prison_78", Spot(122.51799, -1705.2009, 90));
		AddSpawnPoint( "d_prison_78.Id4", "d_prison_78", Spot(-272.32, 2276.1565, 90));

		// TerraNymph_Brown Spawn Points
		AddSpawnPoint( "d_prison_78.Id5", "d_prison_78", Spot(637.76135, 215.79535, 9999));

	}
}
