//--- Melia Script -----------------------------------------------------------
// EP17 Letas Stream Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'ep17_2_f_katyn_12'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Game.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class Ep172FKatyn12MobScript : GeneralScript
{
	protected override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("ep17_2_f_katyn_12", MonsterId.Ep17_2_Puragi, Properties("MHP", 161392640, "MINPATK", 335000, "MAXPATK", 335000, "MINMATK", 335000, "MAXMATK", 335000, "DEF", 15090000, "MDEF", 15090000));
		AddPropertyOverrides("ep17_2_f_katyn_12", MonsterId.Ep17_2_Sec_Zombiegirl2_Chpel, Properties("MHP", 161392640, "MINPATK", 335000, "MAXPATK", 335000, "MINMATK", 335000, "MAXMATK", 335000, "DEF", 15090000, "MDEF", 15090000));
		AddPropertyOverrides("ep17_2_f_katyn_12", MonsterId.Ep17_2_Jellyfish_Blue, Properties("MHP", 161392640, "MINPATK", 335000, "MAXPATK", 335000, "MINMATK", 335000, "MAXMATK", 335000, "DEF", 15090000, "MDEF", 15090000));
		AddPropertyOverrides("ep17_2_f_katyn_12", MonsterId.Ep17_2_Zigri, Properties("MHP", 161392640, "MINPATK", 335000, "MAXPATK", 335000, "MINMATK", 335000, "MAXMATK", 335000, "DEF", 15090000, "MDEF", 15090000));
		AddPropertyOverrides("ep17_2_f_katyn_12", MonsterId.Ep17_2_Chupacabra_Green, Properties("MHP", 161392640, "MINPATK", 335000, "MAXPATK", 335000, "MINMATK", 335000, "MAXMATK", 335000, "DEF", 15090000, "MDEF", 15090000));
		AddPropertyOverrides("ep17_2_f_katyn_12", MonsterId.Ep17_2_Operor_Blue, Properties("MHP", 161392640, "MINPATK", 335000, "MAXPATK", 335000, "MINMATK", 335000, "MAXMATK", 335000, "DEF", 15090000, "MDEF", 15090000));
		AddPropertyOverrides("ep17_2_f_katyn_12", MonsterId.Ep17_2_Boss_Spector_Gh, Properties("MHP", 857326080, "MINPATK", 440000, "MAXPATK", 440000, "MINMATK", 440000, "MAXMATK", 440000, "DEF", 20190000, "MDEF", 20190000));

		// Monster Spawners ---------------------------------

		AddSpawner("ep17_2_f_katyn_12.Id1", MonsterId.Rootcrystal_01, min: 15, max: 20, respawn: Seconds(30));
		AddSpawner("ep17_2_f_katyn_12.Id2", MonsterId.Ep17_2_Puragi, min: 27, max: 35);
		AddSpawner("ep17_2_f_katyn_12.Id3", MonsterId.Ep17_2_Sec_Zombiegirl2_Chpel, min: 45, max: 60);
		AddSpawner("ep17_2_f_katyn_12.Id4", MonsterId.Ep17_2_Jellyfish_Blue, min: 60, max: 80);
		AddSpawner("ep17_2_f_katyn_12.Id5", MonsterId.Ep17_2_Zigri, min: 38, max: 50);
		AddSpawner("ep17_2_f_katyn_12.Id6", MonsterId.Ep17_2_Chupacabra_Green, min: 34, max: 45);
		AddSpawner("ep17_2_f_katyn_12.Id7", MonsterId.Ep17_2_Operor_Blue, min: 34, max: 45);
		AddSpawner("ep17_2_f_katyn_12.Id8", MonsterId.Ep17_2_Operor_Blue, min: 15, max: 20);
		AddSpawner("ep17_2_f_katyn_12.Id9", MonsterId.Ep17_2_Zigri, min: 8, max: 10, respawn: Seconds(40));

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 1 Spawn Points
		AddSpawnPoint("ep17_2_f_katyn_12.Id1", "ep17_2_f_katyn_12", Rectangle(1091, -971, 150));
		AddSpawnPoint("ep17_2_f_katyn_12.Id1", "ep17_2_f_katyn_12", Rectangle(1511, -2241, 150));
		AddSpawnPoint("ep17_2_f_katyn_12.Id1", "ep17_2_f_katyn_12", Rectangle(2497, -2163, 150));
		AddSpawnPoint("ep17_2_f_katyn_12.Id1", "ep17_2_f_katyn_12", Rectangle(2987, -1173, 150));
		AddSpawnPoint("ep17_2_f_katyn_12.Id1", "ep17_2_f_katyn_12", Rectangle(1813, -1291, 150));
		AddSpawnPoint("ep17_2_f_katyn_12.Id1", "ep17_2_f_katyn_12", Rectangle(35, -1117, 150));
		AddSpawnPoint("ep17_2_f_katyn_12.Id1", "ep17_2_f_katyn_12", Rectangle(207, -24, 150));
		AddSpawnPoint("ep17_2_f_katyn_12.Id1", "ep17_2_f_katyn_12", Rectangle(-179, 475, 150));
		AddSpawnPoint("ep17_2_f_katyn_12.Id1", "ep17_2_f_katyn_12", Rectangle(328, 1177, 150));
		AddSpawnPoint("ep17_2_f_katyn_12.Id1", "ep17_2_f_katyn_12", Rectangle(1002, 547, 150));
		AddSpawnPoint("ep17_2_f_katyn_12.Id1", "ep17_2_f_katyn_12", Rectangle(1939, 936, 150));
		AddSpawnPoint("ep17_2_f_katyn_12.Id1", "ep17_2_f_katyn_12", Rectangle(1361, 1582, 150));
		AddSpawnPoint("ep17_2_f_katyn_12.Id1", "ep17_2_f_katyn_12", Rectangle(1955, 113, 150));
		AddSpawnPoint("ep17_2_f_katyn_12.Id1", "ep17_2_f_katyn_12", Rectangle(-1125, -463, 150));
		AddSpawnPoint("ep17_2_f_katyn_12.Id1", "ep17_2_f_katyn_12", Rectangle(-1732, -1310, 150));
		AddSpawnPoint("ep17_2_f_katyn_12.Id1", "ep17_2_f_katyn_12", Rectangle(-2102, 661, 150));
		AddSpawnPoint("ep17_2_f_katyn_12.Id1", "ep17_2_f_katyn_12", Rectangle(-2847, 82, 150));
		AddSpawnPoint("ep17_2_f_katyn_12.Id1", "ep17_2_f_katyn_12", Rectangle(-1658, 1829, 150));
		AddSpawnPoint("ep17_2_f_katyn_12.Id1", "ep17_2_f_katyn_12", Rectangle(-1012, 710, 150));
		AddSpawnPoint("ep17_2_f_katyn_12.Id1", "ep17_2_f_katyn_12", Rectangle(-2860, 1516, 150));

		// 'Ep17_2_Puragi' GenType 25 Spawn Points
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(1701, -1321, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(1870, -1101, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(2181, -1015, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(2052, -1219, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(2020, -1714, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(1456, -2313, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(1450, -2199, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(1511, -2417, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(1652, -2327, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(2291, -2046, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(2669, -2170, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(2695, -2077, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(2646, -2418, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(2472, -2152, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(2617, -2287, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(2554, -1196, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(2042, -1016, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(1688, -1156, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(1968, -1764, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(2829, -1212, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(2901, -947, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(3103, -964, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(3153, -1249, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(3036, -1174, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(2992, -850, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(1938, -1480, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(1356, -2363, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(1297, -2210, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(2086, -1872, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(1885, -1306, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(1787, -1917, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(1627, -2098, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(1911, -1549, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(1305, -1167, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(1967, -965, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(2993, -1073, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(3205, -1126, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(2503, -2357, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(2775, -2341, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id2", "ep17_2_f_katyn_12", Rectangle(2346, -1173, 30));

		// 'Ep17_2_Sec_Zombiegirl2_Chpel' GenType 26 Spawn Points
		AddSpawnPoint("ep17_2_f_katyn_12.Id3", "ep17_2_f_katyn_12", Rectangle(1054, 535, 200));
		AddSpawnPoint("ep17_2_f_katyn_12.Id3", "ep17_2_f_katyn_12", Rectangle(1156, 1158, 200));
		AddSpawnPoint("ep17_2_f_katyn_12.Id3", "ep17_2_f_katyn_12", Rectangle(1377, 1603, 200));
		AddSpawnPoint("ep17_2_f_katyn_12.Id3", "ep17_2_f_katyn_12", Rectangle(1823, 1021, 200));
		AddSpawnPoint("ep17_2_f_katyn_12.Id3", "ep17_2_f_katyn_12", Rectangle(1476, 709, 200));
		AddSpawnPoint("ep17_2_f_katyn_12.Id3", "ep17_2_f_katyn_12", Rectangle(2017, 221, 200));
		AddSpawnPoint("ep17_2_f_katyn_12.Id3", "ep17_2_f_katyn_12", Rectangle(2012, 624, 200));
		AddSpawnPoint("ep17_2_f_katyn_12.Id3", "ep17_2_f_katyn_12", Rectangle(1579, 94, 200));
		AddSpawnPoint("ep17_2_f_katyn_12.Id3", "ep17_2_f_katyn_12", Rectangle(917, 90, 200));

		// 'Ep17_2_Jellyfish_Blue' GenType 27 Spawn Points
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(1622, -2171, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(1081, -1005, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(1916, -1475, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(837, 533, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(-2062, -478, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(-1877, -962, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(-1210, -1229, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(-1639, -1322, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(-1175, -215, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(-1078, -665, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(-863, -1131, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(1994, -1086, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(-963, 111, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(251, 1220, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(-1903, -1276, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(-1704, -1173, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(-1796, -1281, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(-1734, -1473, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(-1387, -1274, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(-2004, -673, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(-2778, -30, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(-1171, -439, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(-1274, -499, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(-1234, -278, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(-986, -526, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(-888, -916, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(-690, -1123, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(-973, -1263, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(-1066, -1166, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(-707, -1219, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(-1134, -52, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(-1024, 197, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(-770, 254, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(-2758, 88, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(-1900, -786, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(-2938, -216, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(-3075, 195, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(-3042, 299, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(-3008, 47, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(-2875, 349, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(958, -848, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(1114, -656, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(1714, -1437, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(1776, -1229, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(1948, -1314, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(2237, -1011, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(1401, -2247, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(1600, -2443, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(1859, -1878, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(1106, 228, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(1114, 550, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(623, 440, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(540, 1298, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(-47, 1142, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(249, 901, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(306, 1147, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(196, 1551, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(526, 1111, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(1007, 1192, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id4", "ep17_2_f_katyn_12", Rectangle(997, 884, 40));

		// 'Ep17_2_Zigri' GenType 28 Spawn Points
		AddSpawnPoint("ep17_2_f_katyn_12.Id5", "ep17_2_f_katyn_12", Rectangle(-361, 441, 9999));

		// 'Ep17_2_Chupacabra_Green' GenType 29 Spawn Points
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(-333, 685, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(-118, 326, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(32, 551, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(-35, 131, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(-234, 579, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(-208, 793, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(77, 908, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(38, 1174, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(191, 1384, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(278, 1497, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(386, 1621, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(81, 1583, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(375, 1323, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(390, 1189, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(792, 1172, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(949, 1425, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(941, 1254, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(1291, 1023, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(1042, 1128, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(1275, 1153, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(1137, 913, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(1005, 956, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(951, 767, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(976, 605, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(679, 494, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(911, 491, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(563, 396, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(737, 387, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(407, 505, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(163, 488, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(802, 629, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(854, 885, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(-415, 462, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(-630, 425, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(-770, 225, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(-919, 270, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(-789, 432, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(-575, 680, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(-736, 828, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(-1032, 668, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(-894, 511, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(-946, 788, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(-1163, 797, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(-1359, 992, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(-1497, 1003, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(-559, 848, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(-567, 242, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(-184, 173, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(-340, 286, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(-89, 987, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(5, 309, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(-65, 764, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(271, 1058, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(465, 1047, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(583, 1211, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(212, 1187, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(-685, 577, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(-86, 479, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(-257, 433, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(833, 1326, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(1135, 1350, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id6", "ep17_2_f_katyn_12", Rectangle(1186, 1486, 40));

		// 'Ep17_2_Operor_Blue' GenType 30 Spawn Points
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-2897, -210, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-2773, -79, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-3033, 112, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-3097, 218, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-2875, 364, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-2954, -3, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-2829, 28, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-2963, 219, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-2728, 96, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-2781, 195, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-2724, 434, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-2684, -19, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-2890, 1420, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-2858, 1609, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-3047, 1548, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-2832, 277, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-2472, 512, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-2658, 217, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-2194, 915, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-3128, 129, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-2191, 361, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-2148, 232, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-1930, 321, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-1952, 486, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-2033, 393, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-1915, 754, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-2040, 719, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-1954, 1056, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-1625, 1094, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-1775, 1192, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-1661, 1620, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-1994, 1817, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-1594, 2095, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-1729, 1764, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-1762, 1932, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-1509, 1902, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-1323, 1944, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-1674, 1481, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-1649, 1235, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-1685, 1003, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-1682, 2177, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-1423, 911, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-1224, 910, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-1219, 763, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-1062, 815, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-1058, 575, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-925, 726, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-903, 554, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-824, 448, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-943, 279, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-731, 446, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-664, 674, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-723, 869, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-590, 901, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-865, 799, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-690, 565, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-2201, 811, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-2728, 333, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-2984, 325, 40));
		AddSpawnPoint("ep17_2_f_katyn_12.Id7", "ep17_2_f_katyn_12", Rectangle(-2607, 489, 40));

		// 'Ep17_2_Operor_Blue' GenType 31 Spawn Points
		AddSpawnPoint("ep17_2_f_katyn_12.Id8", "ep17_2_f_katyn_12", Rectangle(2419, -2246, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id8", "ep17_2_f_katyn_12", Rectangle(2531, -2025, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id8", "ep17_2_f_katyn_12", Rectangle(2699, -2374, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id8", "ep17_2_f_katyn_12", Rectangle(2713, -2124, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id8", "ep17_2_f_katyn_12", Rectangle(1798, -1009, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id8", "ep17_2_f_katyn_12", Rectangle(1749, -1237, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id8", "ep17_2_f_katyn_12", Rectangle(2044, -1323, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id8", "ep17_2_f_katyn_12", Rectangle(1973, -1183, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id8", "ep17_2_f_katyn_12", Rectangle(2184, -938, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id8", "ep17_2_f_katyn_12", Rectangle(2955, -1246, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id8", "ep17_2_f_katyn_12", Rectangle(2969, -928, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id8", "ep17_2_f_katyn_12", Rectangle(3074, -864, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id8", "ep17_2_f_katyn_12", Rectangle(2934, -1043, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id8", "ep17_2_f_katyn_12", Rectangle(3184, -1191, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id8", "ep17_2_f_katyn_12", Rectangle(1715, -2089, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id8", "ep17_2_f_katyn_12", Rectangle(1821, -1787, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id8", "ep17_2_f_katyn_12", Rectangle(1892, -1854, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id8", "ep17_2_f_katyn_12", Rectangle(2067, -1782, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id8", "ep17_2_f_katyn_12", Rectangle(2165, -2027, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id8", "ep17_2_f_katyn_12", Rectangle(2302, -1959, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id8", "ep17_2_f_katyn_12", Rectangle(1931, -1525, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id8", "ep17_2_f_katyn_12", Rectangle(1605, -1220, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id8", "ep17_2_f_katyn_12", Rectangle(1465, -1304, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id8", "ep17_2_f_katyn_12", Rectangle(1758, -1369, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id8", "ep17_2_f_katyn_12", Rectangle(1470, -2155, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id8", "ep17_2_f_katyn_12", Rectangle(1652, -2287, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id8", "ep17_2_f_katyn_12", Rectangle(1519, -2556, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id8", "ep17_2_f_katyn_12", Rectangle(1202, -2353, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id8", "ep17_2_f_katyn_12", Rectangle(1249, -2141, 30));
		AddSpawnPoint("ep17_2_f_katyn_12.Id8", "ep17_2_f_katyn_12", Rectangle(2502, -2420, 30));

		// 'Ep17_2_Zigri' GenType 36 Spawn Points
		AddSpawnPoint("ep17_2_f_katyn_12.Id9", "ep17_2_f_katyn_12", Rectangle(-296, 642, 9999));
	}
}
