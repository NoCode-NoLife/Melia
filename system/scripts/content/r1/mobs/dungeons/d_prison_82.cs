//--- Melia Script -----------------------------------------------------------
// Investigation Room Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_prison_82'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DPrison82MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_prison_82", MonsterId.Templeslave_Sword_Blue, Properties("MHP", 446280, "MINPATK", 6240, "MAXPATK", 7571, "MINMATK", 6240, "MAXMATK", 7571, "DEF", 59511, "MDEF", 59511));
		AddPropertyOverrides("d_prison_82", MonsterId.Wendigo_Bow_White, Properties("MHP", 449596, "MINPATK", 6282, "MAXPATK", 7623, "MINMATK", 6282, "MAXMATK", 7623, "DEF", 60568, "MDEF", 60568));
		AddPropertyOverrides("d_prison_82", MonsterId.Templeslave_Mage_Blue, Properties("MHP", 452975, "MINPATK", 6326, "MAXPATK", 7677, "MINMATK", 6326, "MAXMATK", 7677, "DEF", 61646, "MDEF", 61646));
		AddPropertyOverrides("d_prison_82", MonsterId.Boss_ChiefGuard, Properties("MHP", 3811090, "MINPATK", 10033, "MAXPATK", 12177, "MINMATK", 10033, "MAXMATK", 12177, "DEF", 197644, "MDEF", 197644));

		// Monster Spawners ---------------------------------

		AddSpawner("d_prison_82.Id1", MonsterId.Templeslave_Sword_Blue, min: 12, max: 15, tendency: TendencyType.Aggressive);
		AddSpawner("d_prison_82.Id2", MonsterId.Wendigo_Bow_White, min: 30, max: 40, tendency: TendencyType.Aggressive);
		AddSpawner("d_prison_82.Id3", MonsterId.Templeslave_Mage_Blue, min: 10, max: 13, tendency: TendencyType.Aggressive);
		AddSpawner("d_prison_82.Id4", MonsterId.Rootcrystal_05, min: 12, max: 15, respawn: TimeSpan.FromMilliseconds(60000), tendency: TendencyType.Peaceful);
		AddSpawner("d_prison_82.Id5", MonsterId.Wendigo_Bow_White, min: 23, max: 30, tendency: TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Templeslave_Sword_Blue' GenType 1 Spawn Points
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(2124, 890, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(2225, 788, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(2282, 943, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(2135, 959, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(2257, 1083, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(1954, 1069, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(2117, 1283, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(2268, 1293, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(1782, 1155, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(1611, 1172, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(1275, 1169, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(1259, 927, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(1256, 717, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(1272, 594, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(774, 1310, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(753, 1013, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(627, 1097, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(867, 1142, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(1046, 1195, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(543, 1292, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(217, 1440, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-206, 1398, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-381, 1117, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-178, 1229, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-201, 745, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-968, 1286, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-1035, 1794, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-880, 2155, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-726, 2114, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-230, 490, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(12, 385, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-189, 276, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-307, -142, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-513, -128, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-87, -192, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-582, -395, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-604, -800, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-416, -542, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-109, -342, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-277, -813, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-578, -1021, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-1431, -271, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-1727, -261, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-1555, -99, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-1536, -432, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-1448, -532, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-719, -1464, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-675, -1791, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-388, -1580, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-349, -1353, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(-362, -1887, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(857, 205, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(1310, 161, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(1105, 238, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(1039, -154, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(757, -666, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(590, -2114, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(801, -1367, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(838, -1460, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(832, -1547, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(918, -1579, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(928, -2136, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(724, -1563, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(856, -1761, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(899, -1849, 25));
		AddSpawnPoint("d_prison_82.Id1", "d_prison_82", Rectangle(928, -2012, 25));

		// 'Wendigo_Bow_White' GenType 2 Spawn Points
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(922, -1474, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(900, -1393, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(771, -1256, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(774, -862, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(938, -109, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(995, 296, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(834, 173, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(1200, 117, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(1321, -171, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(1240, 389, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(1272, 987, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(695, 1167, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(807, 1374, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(543, 1364, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(1392, 1183, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(1786, 1155, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(2129, 1182, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(2114, 914, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(1982, 1012, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(866, -1941, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(937, -1757, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(840, -2087, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(687, -2116, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(478, -2116, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(1098, 62, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-1392, -20, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-598, -138, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-579, -48, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-267, -11, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-229, 616, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-255, 278, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-396, -556, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-595, -622, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-470, -415, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-601, -393, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-88, -502, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-294, -887, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-561, -854, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-305, -1420, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-614, -1623, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-801, -1410, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-430, -1427, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-763, -1781, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-263, -1891, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-268, -2078, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(707, -1394, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(761, -1482, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-359, -158, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-248, 450, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-262, 959, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-192, 1219, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-501, 1275, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-862, 2054, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-658, 2067, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-278, 1301, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(-52, 1274, 25));
		AddSpawnPoint("d_prison_82.Id2", "d_prison_82", Rectangle(372, 1402, 25));

		// 'Templeslave_Mage_Blue' GenType 3 Spawn Points
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-883, 2148, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-1002, 1996, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-330, 1348, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-270, 1023, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-196, 632, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-156, 452, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-126, 258, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-599, -225, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-1456, -97, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-1682, -383, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-1501, -439, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-698, -107, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-217, -505, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-505, -593, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-457, -905, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-188, -810, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-808, -1568, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-733, -1896, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-379, -1704, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-389, -1424, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-781, -1312, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-504, -1474, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-323, -1940, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-453, -245, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-627, -489, 25));
		AddSpawnPoint("d_prison_82.Id3", "d_prison_82", Rectangle(-316, 282, 25));

		// 'Rootcrystal_05' GenType 5 Spawn Points
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(742, -2122, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(919, -1929, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(905, -1761, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(471, -2127, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(912, -1415, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(743, -1292, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(794, -1510, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(708, -1086, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(813, -191, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(1029, -39, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(1051, 145, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(1281, -162, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(1351, 287, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(849, 310, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(1301, 803, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(1281, 1176, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(1702, 1187, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(2073, 949, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(875, 1026, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(876, 1283, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(649, 1305, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(691, 1093, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-95, 1068, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-261, 1162, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-390, 1329, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-64, 1319, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-863, 1255, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-955, 1862, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-730, 1845, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-675, 1992, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-925, 2075, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-754, 2160, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-230, 666, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-520, -186, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-567, -598, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-410, -826, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-117, -585, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-120, -839, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-241, -1387, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-442, -1531, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-294, -1811, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-782, -1378, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-1394, -130, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-1397, -395, 90));
		AddSpawnPoint("d_prison_82.Id4", "d_prison_82", Rectangle(-1518, -511, 90));

		// 'Wendigo_Bow_White' GenType 11 Spawn Points
		AddSpawnPoint("d_prison_82.Id5", "d_prison_82", Rectangle(700, 1182, 9999));
	}
}
