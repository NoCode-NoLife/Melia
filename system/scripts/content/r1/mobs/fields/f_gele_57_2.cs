//--- Melia Script -----------------------------------------------------------
// f_gele_57_2
//
//--- Description -----------------------------------------------------------
// Sets up the f_gele_57_2 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FGele572MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_gele_57_2", MonsterId.Leafly, Properties("MHP", 13230, "MINPATK", 671, "MAXPATK", 727, "MINMATK", 671, "MAXMATK", 727, "DEF", 67, "MDEF", 67));
		AddPropertyOverrides("f_gele_57_2", MonsterId.Npanto_Hand, Properties("MHP", 13394, "MINPATK", 673, "MAXPATK", 729, "MINMATK", 673, "MAXMATK", 729, "DEF", 67, "MDEF", 67));
		AddPropertyOverrides("f_gele_57_2", MonsterId.Mally, Properties("MHP", 13772, "MINPATK", 678, "MAXPATK", 735, "MINMATK", 678, "MAXMATK", 735, "DEF", 68, "MDEF", 68));
		AddPropertyOverrides("f_gele_57_2", MonsterId.Npanto_Staff, Properties("MHP", 13984, "MINPATK", 681, "MAXPATK", 738, "MINMATK", 681, "MAXMATK", 738, "DEF", 68, "MDEF", 68));
		AddPropertyOverrides("f_gele_57_2", MonsterId.Npanto_Sword, Properties("MHP", 13575, "MINPATK", 676, "MAXPATK", 732, "MINMATK", 676, "MAXMATK", 732, "DEF", 68, "MDEF", 68));
		AddPropertyOverrides("f_gele_57_2", MonsterId.Mon_Goat_Totem_Q, Properties("MHP", 14210, "MINPATK", 684, "MAXPATK", 742, "MINMATK", 684, "MAXMATK", 742, "DEF", 68, "MDEF", 68));
		AddPropertyOverrides("f_gele_57_2", MonsterId.Spion_Bow, Properties("MHP", 14448, "MINPATK", 687, "MAXPATK", 746, "MINMATK", 687, "MAXMATK", 746, "DEF", 68, "MDEF", 68));

		// Monster Spawners --------------------------------

		AddSpawner("f_gele_57_2.Id1", MonsterId.Leafly, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_2.Id2", MonsterId.Npanto_Hand, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_2.Id3", MonsterId.Mally, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_2.Id4", MonsterId.Npanto_Staff, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_2.Id5", MonsterId.Npanto_Sword, 15, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);
		AddSpawner("f_gele_57_2.Id6", MonsterId.Npanto_Hand, 3, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_2.Id7", MonsterId.Rootcrystal_01, 13, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_gele_57_2.Id8", MonsterId.Mon_Goat_Totem_Q, 10, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("f_gele_57_2.Id9", MonsterId.Mally, 7, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);
		AddSpawner("f_gele_57_2.Id10", MonsterId.Spion_Bow, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_2.Id11", MonsterId.Npanto_Sword, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_2.Id12", MonsterId.Spion_Bow, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_2.Id13", MonsterId.Leafly, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Leafly Spawn Points
		AddSpawnPoint( "f_gele_57_2.Id1", "f_gele_57_2", Spot(525.0313, -65.04556, 9999));

		// Npanto_Hand Spawn Points
		AddSpawnPoint( "f_gele_57_2.Id2", "f_gele_57_2", Spot(1389.1454, -588.69653, 9999));

		// Mally Spawn Points
		AddSpawnPoint( "f_gele_57_2.Id3", "f_gele_57_2", Spot(-459.4229, -438.2885, 9999));

		// Npanto_Staff Spawn Points
		AddSpawnPoint( "f_gele_57_2.Id4", "f_gele_57_2", Spot(-913.3362, -462.73004, 20));
		AddSpawnPoint( "f_gele_57_2.Id4", "f_gele_57_2", Spot(-1151.041, -398.46198, 20));
		AddSpawnPoint( "f_gele_57_2.Id4", "f_gele_57_2", Spot(-782.57526, -132.53462, 20));
		AddSpawnPoint( "f_gele_57_2.Id4", "f_gele_57_2", Spot(-530.8388, -373.608, 20));
		AddSpawnPoint( "f_gele_57_2.Id4", "f_gele_57_2", Spot(-1257.4512, 64.12804, 20));
		AddSpawnPoint( "f_gele_57_2.Id4", "f_gele_57_2", Spot(-1118.1089, 524.7284, 20));
		AddSpawnPoint( "f_gele_57_2.Id4", "f_gele_57_2", Spot(-1163.3824, -248.70667, 20));
		AddSpawnPoint( "f_gele_57_2.Id4", "f_gele_57_2", Spot(-1402.4724, 265.86948, 20));
		AddSpawnPoint( "f_gele_57_2.Id4", "f_gele_57_2", Spot(-942.72845, -248.75749, 20));
		AddSpawnPoint( "f_gele_57_2.Id4", "f_gele_57_2", Spot(-725.0145, -249.34601, 20));
		AddSpawnPoint( "f_gele_57_2.Id4", "f_gele_57_2", Spot(-1140.5696, -511.5866, 20));
		AddSpawnPoint( "f_gele_57_2.Id4", "f_gele_57_2", Spot(-1094.4868, -373.79648, 20));
		AddSpawnPoint( "f_gele_57_2.Id4", "f_gele_57_2", Spot(-1116.7815, -247.2665, 20));
		AddSpawnPoint( "f_gele_57_2.Id4", "f_gele_57_2", Spot(-1132.7112, -73.38382, 20));
		AddSpawnPoint( "f_gele_57_2.Id4", "f_gele_57_2", Spot(-1265.9291, 408.43738, 20));
		AddSpawnPoint( "f_gele_57_2.Id4", "f_gele_57_2", Spot(-1255.6958, 450.34357, 20));
		AddSpawnPoint( "f_gele_57_2.Id4", "f_gele_57_2", Spot(-1124.561, 329.80038, 20));
		AddSpawnPoint( "f_gele_57_2.Id4", "f_gele_57_2", Spot(-1148.9388, 197.57196, 20));
		AddSpawnPoint( "f_gele_57_2.Id4", "f_gele_57_2", Spot(-1382.3572, 213.42, 20));
		AddSpawnPoint( "f_gele_57_2.Id4", "f_gele_57_2", Spot(-1406.227, 143.31847, 20));
		AddSpawnPoint( "f_gele_57_2.Id4", "f_gele_57_2", Spot(-846.07336, -155.27873, 20));
		AddSpawnPoint( "f_gele_57_2.Id4", "f_gele_57_2", Spot(-869.96936, -257.5889, 20));
		AddSpawnPoint( "f_gele_57_2.Id4", "f_gele_57_2", Spot(-851.1844, -375.1752, 20));
		AddSpawnPoint( "f_gele_57_2.Id4", "f_gele_57_2", Spot(-756.23267, -48.436676, 20));

		// Npanto_Sword Spawn Points
		AddSpawnPoint( "f_gele_57_2.Id5", "f_gele_57_2", Spot(1343.572, -765.0404, 25));
		AddSpawnPoint( "f_gele_57_2.Id5", "f_gele_57_2", Spot(1342.2557, -580.8307, 25));
		AddSpawnPoint( "f_gele_57_2.Id5", "f_gele_57_2", Spot(1233.3589, -412.4604, 25));
		AddSpawnPoint( "f_gele_57_2.Id5", "f_gele_57_2", Spot(1067.6426, -1070.3228, 25));
		AddSpawnPoint( "f_gele_57_2.Id5", "f_gele_57_2", Spot(725.3839, -350.3717, 25));
		AddSpawnPoint( "f_gele_57_2.Id5", "f_gele_57_2", Spot(811.97797, -208.64403, 25));
		AddSpawnPoint( "f_gele_57_2.Id5", "f_gele_57_2", Spot(905.353, -390.02295, 25));
		AddSpawnPoint( "f_gele_57_2.Id5", "f_gele_57_2", Spot(442.46945, -234.68663, 25));
		AddSpawnPoint( "f_gele_57_2.Id5", "f_gele_57_2", Spot(486.04312, 50.123547, 25));
		AddSpawnPoint( "f_gele_57_2.Id5", "f_gele_57_2", Spot(985.6362, -991.295, 25));
		AddSpawnPoint( "f_gele_57_2.Id5", "f_gele_57_2", Spot(1514.3007, -338.38956, 25));
		AddSpawnPoint( "f_gele_57_2.Id5", "f_gele_57_2", Spot(1411.5908, -469.7792, 25));
		AddSpawnPoint( "f_gele_57_2.Id5", "f_gele_57_2", Spot(1030.5421, -797.3354, 25));
		AddSpawnPoint( "f_gele_57_2.Id5", "f_gele_57_2", Spot(1158.676, -595.62964, 25));

		// Npanto_Hand Spawn Points
		AddSpawnPoint( "f_gele_57_2.Id6", "f_gele_57_2", Spot(441.19202, 314.27454, 40));
		AddSpawnPoint( "f_gele_57_2.Id6", "f_gele_57_2", Spot(560.2828, 622.22064, 40));
		AddSpawnPoint( "f_gele_57_2.Id6", "f_gele_57_2", Spot(1351.5208, -744.5529, 40));
		AddSpawnPoint( "f_gele_57_2.Id6", "f_gele_57_2", Spot(1185.736, -561.3658, 40));
		AddSpawnPoint( "f_gele_57_2.Id6", "f_gele_57_2", Spot(408.21008, -64.54454, 40));

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "f_gele_57_2.Id7", "f_gele_57_2", Spot(-147.0386, -848.69, 10));
		AddSpawnPoint( "f_gele_57_2.Id7", "f_gele_57_2", Spot(172.9802, -573.7448, 10));
		AddSpawnPoint( "f_gele_57_2.Id7", "f_gele_57_2", Spot(-515.5775, -370.29684, 10));
		AddSpawnPoint( "f_gele_57_2.Id7", "f_gele_57_2", Spot(-809.54297, -206.53415, 10));
		AddSpawnPoint( "f_gele_57_2.Id7", "f_gele_57_2", Spot(-1142.2493, -245.53558, 10));
		AddSpawnPoint( "f_gele_57_2.Id7", "f_gele_57_2", Spot(-1163.3341, 12.531452, 10));
		AddSpawnPoint( "f_gele_57_2.Id7", "f_gele_57_2", Spot(-1221.3494, 324.33716, 10));
		AddSpawnPoint( "f_gele_57_2.Id7", "f_gele_57_2", Spot(557.0039, -192.43945, 10));
		AddSpawnPoint( "f_gele_57_2.Id7", "f_gele_57_2", Spot(837.3312, -315.96643, 10));
		AddSpawnPoint( "f_gele_57_2.Id7", "f_gele_57_2", Spot(1251.3704, -503.8387, 10));
		AddSpawnPoint( "f_gele_57_2.Id7", "f_gele_57_2", Spot(1067.7004, -725.1245, 10));
		AddSpawnPoint( "f_gele_57_2.Id7", "f_gele_57_2", Spot(1108.5057, -702.47815, 10));
		AddSpawnPoint( "f_gele_57_2.Id7", "f_gele_57_2", Spot(461.51352, 199.39368, 10));
		AddSpawnPoint( "f_gele_57_2.Id7", "f_gele_57_2", Spot(546.45087, 649.21594, 10));
		AddSpawnPoint( "f_gele_57_2.Id7", "f_gele_57_2", Spot(835.9748, 1074.4878, 10));
		AddSpawnPoint( "f_gele_57_2.Id7", "f_gele_57_2", Spot(943.15717, 1007.0688, 10));
		AddSpawnPoint( "f_gele_57_2.Id7", "f_gele_57_2", Spot(862.14575, 1566.4332, 10));
		AddSpawnPoint( "f_gele_57_2.Id7", "f_gele_57_2", Spot(115.11829, 1261.7963, 10));
		AddSpawnPoint( "f_gele_57_2.Id7", "f_gele_57_2", Spot(-74.73736, 1195.7698, 10));

		// Mon_Goat_Totem_Q Spawn Points
		AddSpawnPoint( "f_gele_57_2.Id8", "f_gele_57_2", Spot(884.6966, -984.4459, 20));
		AddSpawnPoint( "f_gele_57_2.Id8", "f_gele_57_2", Spot(978.30005, -662.4536, 20));
		AddSpawnPoint( "f_gele_57_2.Id8", "f_gele_57_2", Spot(1118.337, -413.6972, 20));
		AddSpawnPoint( "f_gele_57_2.Id8", "f_gele_57_2", Spot(981.0084, -157.7377, 20));
		AddSpawnPoint( "f_gele_57_2.Id8", "f_gele_57_2", Spot(773.605, -196.7343, 20));
		AddSpawnPoint( "f_gele_57_2.Id8", "f_gele_57_2", Spot(1223.6044, -249.40398, 20));
		AddSpawnPoint( "f_gele_57_2.Id8", "f_gele_57_2", Spot(1421.0789, -217.37457, 20));
		AddSpawnPoint( "f_gele_57_2.Id8", "f_gele_57_2", Spot(1450.714, -683.1089, 20));
		AddSpawnPoint( "f_gele_57_2.Id8", "f_gele_57_2", Spot(1247.831, -739.39764, 20));
		AddSpawnPoint( "f_gele_57_2.Id8", "f_gele_57_2", Spot(1573.003, -391.09015, 20));
		AddSpawnPoint( "f_gele_57_2.Id8", "f_gele_57_2", Spot(1508.1526, -516.054, 20));
		AddSpawnPoint( "f_gele_57_2.Id8", "f_gele_57_2", Spot(1229.517, -1142.5574, 20));
		AddSpawnPoint( "f_gele_57_2.Id8", "f_gele_57_2", Spot(979.0994, -808.27484, 20));
		AddSpawnPoint( "f_gele_57_2.Id8", "f_gele_57_2", Spot(834.96857, -400.2716, 20));
		AddSpawnPoint( "f_gele_57_2.Id8", "f_gele_57_2", Spot(1029.3644, -283.50836, 20));

		// Mally Spawn Points
		AddSpawnPoint( "f_gele_57_2.Id9", "f_gele_57_2", Spot(851.6674, -278.2934, 20));
		AddSpawnPoint( "f_gele_57_2.Id9", "f_gele_57_2", Spot(440.57635, 233.21556, 20));
		AddSpawnPoint( "f_gele_57_2.Id9", "f_gele_57_2", Spot(492.18182, -265.5356, 20));
		AddSpawnPoint( "f_gele_57_2.Id9", "f_gele_57_2", Spot(592.52606, 738.71954, 20));
		AddSpawnPoint( "f_gele_57_2.Id9", "f_gele_57_2", Spot(1351.6653, -418.80734, 20));
		AddSpawnPoint( "f_gele_57_2.Id9", "f_gele_57_2", Spot(1030.5764, -790.25104, 20));
		AddSpawnPoint( "f_gele_57_2.Id9", "f_gele_57_2", Spot(1338.8647, -692.9389, 20));
		AddSpawnPoint( "f_gele_57_2.Id9", "f_gele_57_2", Spot(1182.7866, -535.7957, 20));
		AddSpawnPoint( "f_gele_57_2.Id9", "f_gele_57_2", Spot(1554.9517, -286.52408, 20));
		AddSpawnPoint( "f_gele_57_2.Id9", "f_gele_57_2", Spot(768.0489, -101.72971, 20));
		AddSpawnPoint( "f_gele_57_2.Id9", "f_gele_57_2", Spot(690.22656, -313.30627, 20));
		AddSpawnPoint( "f_gele_57_2.Id9", "f_gele_57_2", Spot(431.62448, -13.003897, 20));
		AddSpawnPoint( "f_gele_57_2.Id9", "f_gele_57_2", Spot(519.0563, 533.3781, 20));
		AddSpawnPoint( "f_gele_57_2.Id9", "f_gele_57_2", Spot(818.1015, 1035.2468, 20));
		AddSpawnPoint( "f_gele_57_2.Id9", "f_gele_57_2", Spot(1050.6089, 984.8101, 20));
		AddSpawnPoint( "f_gele_57_2.Id9", "f_gele_57_2", Spot(950.92926, 1150.6903, 20));
		AddSpawnPoint( "f_gele_57_2.Id9", "f_gele_57_2", Spot(906.04504, 905.53455, 20));
		AddSpawnPoint( "f_gele_57_2.Id9", "f_gele_57_2", Spot(834.8305, 1154.8541, 20));

		// Spion_Bow Spawn Points
		AddSpawnPoint( "f_gele_57_2.Id10", "f_gele_57_2", Spot(408.20627, 397.455, 30));
		AddSpawnPoint( "f_gele_57_2.Id10", "f_gele_57_2", Spot(810.9681, 991.43567, 30));
		AddSpawnPoint( "f_gele_57_2.Id10", "f_gele_57_2", Spot(1051.1951, 969.9235, 30));
		AddSpawnPoint( "f_gele_57_2.Id10", "f_gele_57_2", Spot(-1111.9683, -264.9662, 30));
		AddSpawnPoint( "f_gele_57_2.Id10", "f_gele_57_2", Spot(-1316.2117, 250.49026, 30));
		AddSpawnPoint( "f_gele_57_2.Id10", "f_gele_57_2", Spot(-1067.087, 176.0852, 30));
		AddSpawnPoint( "f_gele_57_2.Id10", "f_gele_57_2", Spot(-1120.4666, -63.8506, 30));
		AddSpawnPoint( "f_gele_57_2.Id10", "f_gele_57_2", Spot(-823.0054, -174.28438, 30));
		AddSpawnPoint( "f_gele_57_2.Id10", "f_gele_57_2", Spot(639.9956, 743.70483, 30));
		AddSpawnPoint( "f_gele_57_2.Id10", "f_gele_57_2", Spot(925.13477, 1231.717, 30));
		AddSpawnPoint( "f_gele_57_2.Id10", "f_gele_57_2", Spot(1020.9648, -712.0027, 30));
		AddSpawnPoint( "f_gele_57_2.Id10", "f_gele_57_2", Spot(1302.4172, -426.3817, 30));
		AddSpawnPoint( "f_gele_57_2.Id10", "f_gele_57_2", Spot(1071.7083, -541.1245, 30));
		AddSpawnPoint( "f_gele_57_2.Id10", "f_gele_57_2", Spot(1303.8951, -630.2017, 30));
		AddSpawnPoint( "f_gele_57_2.Id10", "f_gele_57_2", Spot(1498.911, -405.96216, 30));
		AddSpawnPoint( "f_gele_57_2.Id10", "f_gele_57_2", Spot(842.63086, -266.98013, 30));
		AddSpawnPoint( "f_gele_57_2.Id10", "f_gele_57_2", Spot(504.08688, -284.0779, 30));
		AddSpawnPoint( "f_gele_57_2.Id10", "f_gele_57_2", Spot(467.64252, -3.3746784, 30));
		AddSpawnPoint( "f_gele_57_2.Id10", "f_gele_57_2", Spot(791.1446, 1161.9193, 30));
		AddSpawnPoint( "f_gele_57_2.Id10", "f_gele_57_2", Spot(-1164.2822, 479.1277, 30));
		AddSpawnPoint( "f_gele_57_2.Id10", "f_gele_57_2", Spot(-1287.3025, 442.66937, 30));
		AddSpawnPoint( "f_gele_57_2.Id10", "f_gele_57_2", Spot(-1199.787, 38.84188, 30));
		AddSpawnPoint( "f_gele_57_2.Id10", "f_gele_57_2", Spot(-881.77606, -378.43417, 30));
		AddSpawnPoint( "f_gele_57_2.Id10", "f_gele_57_2", Spot(-741.74567, -74.04749, 30));
		AddSpawnPoint( "f_gele_57_2.Id10", "f_gele_57_2", Spot(-710.0828, -254.16522, 30));
		AddSpawnPoint( "f_gele_57_2.Id10", "f_gele_57_2", Spot(-556.7835, -448.134, 30));
		AddSpawnPoint( "f_gele_57_2.Id10", "f_gele_57_2", Spot(-482.13205, -357.90125, 30));
		AddSpawnPoint( "f_gele_57_2.Id10", "f_gele_57_2", Spot(-1237.517, -179.5525, 30));

		// Npanto_Sword Spawn Points
		AddSpawnPoint( "f_gele_57_2.Id11", "f_gele_57_2", Spot(-1109.0492, 131.83371, 30));
		AddSpawnPoint( "f_gele_57_2.Id11", "f_gele_57_2", Spot(-1382.558, 194.37936, 30));
		AddSpawnPoint( "f_gele_57_2.Id11", "f_gele_57_2", Spot(-1098.1191, 383.4974, 30));
		AddSpawnPoint( "f_gele_57_2.Id11", "f_gele_57_2", Spot(-1193.9835, 39.933357, 30));
		AddSpawnPoint( "f_gele_57_2.Id11", "f_gele_57_2", Spot(-1161.305, -200.56483, 30));
		AddSpawnPoint( "f_gele_57_2.Id11", "f_gele_57_2", Spot(-888.0119, -433.9364, 30));
		AddSpawnPoint( "f_gele_57_2.Id11", "f_gele_57_2", Spot(-792.42914, -9.540996, 30));
		AddSpawnPoint( "f_gele_57_2.Id11", "f_gele_57_2", Spot(-902.8834, -148.25914, 30));
		AddSpawnPoint( "f_gele_57_2.Id11", "f_gele_57_2", Spot(-726.18964, -185.874, 30));
		AddSpawnPoint( "f_gele_57_2.Id11", "f_gele_57_2", Spot(-1098.3452, -436.7346, 30));

		// Spion_Bow Spawn Points
		AddSpawnPoint( "f_gele_57_2.Id12", "f_gele_57_2", Spot(927.92737, 1325.4866, 20));
		AddSpawnPoint( "f_gele_57_2.Id12", "f_gele_57_2", Spot(767.0105, 1464.5243, 20));
		AddSpawnPoint( "f_gele_57_2.Id12", "f_gele_57_2", Spot(796.15497, 1645.3759, 20));
		AddSpawnPoint( "f_gele_57_2.Id12", "f_gele_57_2", Spot(907.51874, 1847.0643, 20));
		AddSpawnPoint( "f_gele_57_2.Id12", "f_gele_57_2", Spot(1105.6293, 1754.1534, 20));
		AddSpawnPoint( "f_gele_57_2.Id12", "f_gele_57_2", Spot(1213.2341, 1601.6464, 20));
		AddSpawnPoint( "f_gele_57_2.Id12", "f_gele_57_2", Spot(1213.2341, 1601.6464, 20));
		AddSpawnPoint( "f_gele_57_2.Id12", "f_gele_57_2", Spot(1144.8782, 1401.0637, 20));
		AddSpawnPoint( "f_gele_57_2.Id12", "f_gele_57_2", Spot(1067.3097, 1338.3905, 20));
		AddSpawnPoint( "f_gele_57_2.Id12", "f_gele_57_2", Spot(870.79004, 1412.9438, 20));
		AddSpawnPoint( "f_gele_57_2.Id12", "f_gele_57_2", Spot(792.76685, 1624.9998, 20));
		AddSpawnPoint( "f_gele_57_2.Id12", "f_gele_57_2", Spot(948.0812, 1759.3291, 20));
		AddSpawnPoint( "f_gele_57_2.Id12", "f_gele_57_2", Spot(1048.2079, 1757.2021, 20));
		AddSpawnPoint( "f_gele_57_2.Id12", "f_gele_57_2", Spot(816.2928, 1801.9938, 20));
		AddSpawnPoint( "f_gele_57_2.Id12", "f_gele_57_2", Spot(770.0589, 1522.2928, 20));

		// Leafly Spawn Points
		AddSpawnPoint( "f_gele_57_2.Id13", "f_gele_57_2", Spot(-1412.8832, 77.01633, 20));
		AddSpawnPoint( "f_gele_57_2.Id13", "f_gele_57_2", Spot(-1490.8931, 181.27794, 20));
		AddSpawnPoint( "f_gele_57_2.Id13", "f_gele_57_2", Spot(-1437.7698, 409.58954, 20));
		AddSpawnPoint( "f_gele_57_2.Id13", "f_gele_57_2", Spot(-1160.5208, 541.5807, 20));
		AddSpawnPoint( "f_gele_57_2.Id13", "f_gele_57_2", Spot(-1021.898, 494.24713, 20));
		AddSpawnPoint( "f_gele_57_2.Id13", "f_gele_57_2", Spot(-965.6091, 424.5085, 20));
		AddSpawnPoint( "f_gele_57_2.Id13", "f_gele_57_2", Spot(-998.23706, 264.30124, 20));
		AddSpawnPoint( "f_gele_57_2.Id13", "f_gele_57_2", Spot(-1037.6547, 163.1158, 20));
		AddSpawnPoint( "f_gele_57_2.Id13", "f_gele_57_2", Spot(-1007.7023, 59.855938, 20));
		AddSpawnPoint( "f_gele_57_2.Id13", "f_gele_57_2", Spot(-1184.1941, 39.126507, 20));
		AddSpawnPoint( "f_gele_57_2.Id13", "f_gele_57_2", Spot(-1254.2538, 39.40494, 20));
		AddSpawnPoint( "f_gele_57_2.Id13", "f_gele_57_2", Spot(-1400.6758, 237.42178, 20));
		AddSpawnPoint( "f_gele_57_2.Id13", "f_gele_57_2", Spot(-1342.5286, 482.81253, 20));
		AddSpawnPoint( "f_gele_57_2.Id13", "f_gele_57_2", Spot(-1247.9924, 542.2311, 20));
		AddSpawnPoint( "f_gele_57_2.Id13", "f_gele_57_2", Spot(-1108.09, 316.5091, 20));
		AddSpawnPoint( "f_gele_57_2.Id13", "f_gele_57_2", Spot(-1243.6442, 142.42804, 20));

	}
}
