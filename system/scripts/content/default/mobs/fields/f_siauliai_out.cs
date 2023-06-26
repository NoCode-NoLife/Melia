//--- Melia Script -----------------------------------------------------------
// f_siauliai_out
//
//--- Description -----------------------------------------------------------
// Sets up the f_siauliai_out mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FSiauliaiOutMobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_siauliai_out", MonsterId.Onion_Red, Properties("MHP", 3702, "MINPATK", 251, "MAXPATK", 270, "MINMATK", 251, "MAXMATK", 270, "DEF", 24, "MDEF", 24));
		AddPropertyOverrides("f_siauliai_out", MonsterId.Jukopus, Properties("MHP", 3383, "MINPATK", 236, "MAXPATK", 255, "MINMATK", 236, "MAXMATK", 255, "DEF", 23, "MDEF", 23));
		AddPropertyOverrides("f_siauliai_out", MonsterId.Goblin_Spear, Properties("MHP", 4035, "MINPATK", 266, "MAXPATK", 287, "MINMATK", 266, "MAXMATK", 287, "DEF", 26, "MDEF", 26));
		AddPropertyOverrides("f_siauliai_out", MonsterId.Onion_Red_Elite, Properties("MHP", 19722, "MINPATK", 507, "MAXPATK", 547, "MINMATK", 507, "MAXMATK", 547, "DEF", 50, "MDEF", 50));

		// Monster Populations
		var OnionRed_1_6 = AddMonsterGenerator(MonsterId.Onion_Red, "f_siauliai_out", 6);
		var Jukopus_2_6 = AddMonsterGenerator(MonsterId.Jukopus, "f_siauliai_out", 6);
		var GoblinSpear_3_15 = AddMonsterGenerator(MonsterId.Goblin_Spear, "f_siauliai_out", 15);
		var Rootcrystal01_4_30 = AddMonsterGenerator(MonsterId.Rootcrystal_01, "f_siauliai_out", 30);
		var GoblinSpear_5_8 = AddMonsterGenerator(MonsterId.Goblin_Spear, "f_siauliai_out", 8);
		var OnionRed_6_15 = AddMonsterGenerator(MonsterId.Onion_Red, "f_siauliai_out", 15);
		var OnionRed_7_18 = AddMonsterGenerator(MonsterId.Onion_Red, "f_siauliai_out", 18);
		var Jukopus_8_15 = AddMonsterGenerator(MonsterId.Jukopus, "f_siauliai_out", 15);
		var OnionRed_9_8 = AddMonsterGenerator(MonsterId.Onion_Red, "f_siauliai_out", 8);
		var Jukopus_10_6 = AddMonsterGenerator(MonsterId.Jukopus, "f_siauliai_out", 6);
		var OnionRedElite_11_2 = AddMonsterGenerator(MonsterId.Onion_Red_Elite, "f_siauliai_out", 2);
		var Jukopus_12_15 = AddMonsterGenerator(MonsterId.Jukopus, "f_siauliai_out", 15);

		// RootCrystal Spawners
		AddSpawnPoint(Rootcrystal01_4_30, TimeSpan.FromMilliseconds(20000), "f_siauliai_out", Spot(1256, -955, 10));
		AddSpawnPoint(Rootcrystal01_4_30, TimeSpan.FromMilliseconds(20000), "f_siauliai_out", Spot(1957, -47, 10));
		AddSpawnPoint(Rootcrystal01_4_30, TimeSpan.FromMilliseconds(20000), "f_siauliai_out", Spot(1767.28, 388.86, 10));
		AddSpawnPoint(Rootcrystal01_4_30, TimeSpan.FromMilliseconds(20000), "f_siauliai_out", Spot(-464, -1451, 10));
		AddSpawnPoint(Rootcrystal01_4_30, TimeSpan.FromMilliseconds(20000), "f_siauliai_out", Spot(-1283, -1639, 10));
		AddSpawnPoint(Rootcrystal01_4_30, TimeSpan.FromMilliseconds(20000), "f_siauliai_out", Spot(-1504, -1178, 10));
		AddSpawnPoint(Rootcrystal01_4_30, TimeSpan.FromMilliseconds(20000), "f_siauliai_out", Spot(-1772, -1685, 10));
		AddSpawnPoint(Rootcrystal01_4_30, TimeSpan.FromMilliseconds(20000), "f_siauliai_out", Spot(-1632.7257, -878.3143, 10));
		AddSpawnPoint(Rootcrystal01_4_30, TimeSpan.FromMilliseconds(20000), "f_siauliai_out", Spot(-1199.0665, -1103.7491, 10));
		AddSpawnPoint(Rootcrystal01_4_30, TimeSpan.FromMilliseconds(20000), "f_siauliai_out", Spot(-2124.5305, -1766.132, 10));
		AddSpawnPoint(Rootcrystal01_4_30, TimeSpan.FromMilliseconds(20000), "f_siauliai_out", Spot(-1756.9492, -1536.5791, 10));
		AddSpawnPoint(Rootcrystal01_4_30, TimeSpan.FromMilliseconds(20000), "f_siauliai_out", Spot(-1119.2812, -1493.9974, 10));
		AddSpawnPoint(Rootcrystal01_4_30, TimeSpan.FromMilliseconds(20000), "f_siauliai_out", Spot(-796.1923, -1660.2905, 10));
		AddSpawnPoint(Rootcrystal01_4_30, TimeSpan.FromMilliseconds(20000), "f_siauliai_out", Spot(-619.8731, -1567.6348, 10));
		AddSpawnPoint(Rootcrystal01_4_30, TimeSpan.FromMilliseconds(20000), "f_siauliai_out", Spot(12.458209, -1429.5051, 10));
		AddSpawnPoint(Rootcrystal01_4_30, TimeSpan.FromMilliseconds(20000), "f_siauliai_out", Spot(264.45697, -1316.947, 10));
		AddSpawnPoint(Rootcrystal01_4_30, TimeSpan.FromMilliseconds(20000), "f_siauliai_out", Spot(533.62396, -1103.0924, 10));
		AddSpawnPoint(Rootcrystal01_4_30, TimeSpan.FromMilliseconds(20000), "f_siauliai_out", Spot(-16.773493, -1044.74, 10));
		AddSpawnPoint(Rootcrystal01_4_30, TimeSpan.FromMilliseconds(20000), "f_siauliai_out", Spot(-80.62352, -387.87054, 10));
		AddSpawnPoint(Rootcrystal01_4_30, TimeSpan.FromMilliseconds(20000), "f_siauliai_out", Spot(-89.68266, -138.74069, 10));
		AddSpawnPoint(Rootcrystal01_4_30, TimeSpan.FromMilliseconds(20000), "f_siauliai_out", Spot(69.51727, -170.16641, 10));
		AddSpawnPoint(Rootcrystal01_4_30, TimeSpan.FromMilliseconds(20000), "f_siauliai_out", Spot(720.75745, -955.018, 10));
		AddSpawnPoint(Rootcrystal01_4_30, TimeSpan.FromMilliseconds(20000), "f_siauliai_out", Spot(1024.0293, -991.2591, 10));
		AddSpawnPoint(Rootcrystal01_4_30, TimeSpan.FromMilliseconds(20000), "f_siauliai_out", Spot(1512.2637, -537.8149, 10));
		AddSpawnPoint(Rootcrystal01_4_30, TimeSpan.FromMilliseconds(20000), "f_siauliai_out", Spot(1290.1056, 199.1855, 10));
		AddSpawnPoint(Rootcrystal01_4_30, TimeSpan.FromMilliseconds(20000), "f_siauliai_out", Spot(450.89838, -1551.0435, 10));
		AddSpawnPoint(Rootcrystal01_4_30, TimeSpan.FromMilliseconds(20000), "f_siauliai_out", Spot(537.7366, -1799.1941, 10));
		AddSpawnPoint(Rootcrystal01_4_30, TimeSpan.FromMilliseconds(20000), "f_siauliai_out", Spot(1677.1814, -61.22932, 10));
		AddSpawnPoint(Rootcrystal01_4_30, TimeSpan.FromMilliseconds(20000), "f_siauliai_out", Spot(1990.8573, 408.2743, 10));
		AddSpawnPoint(Rootcrystal01_4_30, TimeSpan.FromMilliseconds(20000), "f_siauliai_out", Spot(2186.93, 368.88602, 10));
		AddSpawnPoint(Rootcrystal01_4_30, TimeSpan.FromMilliseconds(20000), "f_siauliai_out", Spot(1753.8479, -536.3814, 10));
		AddSpawnPoint(Rootcrystal01_4_30, TimeSpan.FromMilliseconds(20000), "f_siauliai_out", Spot(-1959.7012, -2100.3723, 10));
		AddSpawnPoint(Rootcrystal01_4_30, TimeSpan.FromMilliseconds(20000), "f_siauliai_out", Spot(1367.6566, -144.09558, 10));

		// Monster Spawners
		AddSpawnPoint(OnionRed_1_6, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(-1877, -2146, 30));
		AddSpawnPoint(OnionRed_1_6, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(-1595.92, -1274.41, 30));
		AddSpawnPoint(OnionRed_1_6, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(-1432.1576, -1177.2042, 30));
		AddSpawnPoint(OnionRed_1_6, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(-1366.3898, -997.91205, 30));
		AddSpawnPoint(OnionRed_1_6, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(-1770.45, -1242.53, 30));
		AddSpawnPoint(OnionRed_1_6, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(-2158.895, -1760.5822, 30));
		AddSpawnPoint(OnionRed_1_6, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(-1779.1027, -1801.2806, 30));
		AddSpawnPoint(Jukopus_2_6, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(-1531, -1307, 30));
		AddSpawnPoint(Jukopus_2_6, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(-1241, -1161, 30));
		AddSpawnPoint(Jukopus_2_6, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(-1226, -963, 30));
		AddSpawnPoint(Jukopus_2_6, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(-1504.0563, -960.2478, 30));
		AddSpawnPoint(Jukopus_2_6, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(-1779, -1872, 30));
		AddSpawnPoint(Jukopus_2_6, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(-2002.6105, -1727.9053, 30));
		AddSpawnPoint(Jukopus_2_6, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(-2215.74, -1731.03, 30));
		AddSpawnPoint(Jukopus_2_6, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(-1803, -2039, 30));
		AddSpawnPoint(Jukopus_2_6, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(-1258.7599, -1591.6593, 30));
		AddSpawnPoint(GoblinSpear_3_15, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(1772.1586, 390.9142, 40));
		AddSpawnPoint(GoblinSpear_3_15, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(1465, 110, 40));
		AddSpawnPoint(GoblinSpear_3_15, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(1544, 308, 40));
		AddSpawnPoint(GoblinSpear_3_15, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(1334, 154, 40));
		AddSpawnPoint(GoblinSpear_3_15, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(1411, 390, 40));
		AddSpawnPoint(GoblinSpear_3_15, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(1590, 530, 40));
		AddSpawnPoint(GoblinSpear_3_15, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(1997, 527, 40));
		AddSpawnPoint(GoblinSpear_3_15, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(1840.5435, 206.06389, 40));
		AddSpawnPoint(GoblinSpear_3_15, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(2123, 304, 40));
		AddSpawnPoint(GoblinSpear_3_15, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(106, -51, 40));
		AddSpawnPoint(GoblinSpear_3_15, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(-97.29466, -120.70964, 40));
		AddSpawnPoint(GoblinSpear_3_15, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(16.103516, -146.45471, 40));
		AddSpawnPoint(GoblinSpear_5_8, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(-1889.2446, -1782.208, 350));
		AddSpawnPoint(OnionRed_6_15, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(-1202.45, -1041.35, 9999));
		AddSpawnPoint(OnionRed_7_18, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(-228.02856, -1471.0527, 40));
		AddSpawnPoint(OnionRed_7_18, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(991.3585, -981.5398, 40));
		AddSpawnPoint(OnionRed_7_18, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(1271.9524, -996.46155, 40));
		AddSpawnPoint(OnionRed_7_18, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(1368.9536, -745.9954, 40));
		AddSpawnPoint(OnionRed_7_18, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(1364.0321, -452.88168, 40));
		AddSpawnPoint(OnionRed_7_18, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(763.4485, -888.34796, 40));
		AddSpawnPoint(Jukopus_8_15, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(797.9674, -992.09973, 40));
		AddSpawnPoint(Jukopus_8_15, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(524.0025, -1070.1095, 40));
		AddSpawnPoint(Jukopus_8_15, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(1566.4131, -86.46464, 40));
		AddSpawnPoint(Jukopus_8_15, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(1209.8135, -875.67035, 40));
		AddSpawnPoint(OnionRed_9_8, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(-982.0216, -1586.3763, 40));
		AddSpawnPoint(OnionRed_9_8, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(-621.8622, -1512.5754, 40));
		AddSpawnPoint(OnionRed_9_8, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(-730.20825, -1669.8757, 40));
		AddSpawnPoint(Jukopus_10_6, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(-468.60318, -1511.5411, 40));
		AddSpawnPoint(Jukopus_10_6, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(-777.53784, -1479.7612, 40));
		AddSpawnPoint(Jukopus_10_6, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(-690.56824, -1775.4108, 40));
		AddSpawnPoint(OnionRedElite_11_2, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(1151.96, -937.48, 9999));
		AddSpawnPoint(OnionRedElite_11_2, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(-824.7653, -1566.3862, 9999));
		AddSpawnPoint(Jukopus_12_15, TimeSpan.FromMilliseconds(0), "f_siauliai_out", Spot(-1966.0101, -1791.0936, 600));

	}
}
