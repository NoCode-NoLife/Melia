//--- Melia Script -----------------------------------------------------------
// Tevhrin Stalactite Cave Section 1 Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_limestonecave_52_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DLimestonecave521MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_limestonecave_52_1", MonsterId.Rockon, Properties("MHP", 468964, "MINPATK", 6531, "MAXPATK", 7929, "MINMATK", 6531, "MAXMATK", 7929, "DEF", 67778, "MDEF", 67778));
		AddPropertyOverrides("d_limestonecave_52_1", MonsterId.Tala_Sorcerer, Properties("MHP", 470713, "MINPATK", 6554, "MAXPATK", 7957, "MINMATK", 6554, "MAXMATK", 7957, "DEF", 68480, "MDEF", 68480));
		AddPropertyOverrides("d_limestonecave_52_1", MonsterId.Flak_Green, Properties("MHP", 472537, "MINPATK", 6577, "MAXPATK", 7986, "MINMATK", 6577, "MAXMATK", 7986, "DEF", 69212, "MDEF", 69212));
		AddPropertyOverrides("d_limestonecave_52_1", MonsterId.Rockoff, Properties("MHP", 474432, "MINPATK", 6602, "MAXPATK", 8016, "MINMATK", 6602, "MAXMATK", 8016, "DEF", 69972, "MDEF", 69972));

		// Monster Spawners ---------------------------------

		AddSpawner("d_limestonecave_52_1.Id1", MonsterId.Rockon, min: 15, max: 20, tendency: TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_1.Id2", MonsterId.Rockon, min: 12, max: 15, tendency: TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_1.Id3", MonsterId.Rockon, min: 15, max: 20, tendency: TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_1.Id4", MonsterId.Tala_Sorcerer, min: 19, max: 25, tendency: TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_1.Id5", MonsterId.Flak_Green, min: 27, max: 35, tendency: TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_1.Id6", MonsterId.Rootcrystal_04, min: 19, max: 25, respawn: TimeSpan.FromMilliseconds(30000), tendency: TendencyType.Peaceful);
		AddSpawner("d_limestonecave_52_1.Id7", MonsterId.Rockoff, min: 30, max: 40, tendency: TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Rockon' GenType 8 Spawn Points
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(-801, -935, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(-702, -701, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(-1214, -137, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(-1459, 299, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(-730, 441, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(-1335, 1386, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(-1141, 1298, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(-101, 1076, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(-42, 1305, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(451, 156, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(-40, 164, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(696, 168, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(1094, 86, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(1421, -29, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(1277, -210, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(609, 831, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(646, 620, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(1335, 979, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(1284, 1528, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(1542, 1488, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(642, 1380, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(414, 1425, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(-1386, 360, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(561, 743, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(610, 609, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(938, 804, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(1354, 721, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(1502, 746, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(1599, 929, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(1539, 996, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(1484, 828, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(1404, 927, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(1234, 837, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(1433, 1022, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(-857, -999, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(-647, -914, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(-809, -801, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(-930, -943, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(-1078, -1053, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(-705, -791, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(-381, -871, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(-451, -794, 35));

		// 'Rockon' GenType 9 Spawn Points
		AddSpawnPoint("d_limestonecave_52_1.Id2", "d_limestonecave_52_1", Rectangle(-738, 555, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id2", "d_limestonecave_52_1", Rectangle(-1136, 296, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id2", "d_limestonecave_52_1", Rectangle(-1216, -77, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id2", "d_limestonecave_52_1", Rectangle(-948, -85, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id2", "d_limestonecave_52_1", Rectangle(-1057, -862, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id2", "d_limestonecave_52_1", Rectangle(-733, -879, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id2", "d_limestonecave_52_1", Rectangle(31, 206, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id2", "d_limestonecave_52_1", Rectangle(396, 200, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id2", "d_limestonecave_52_1", Rectangle(552, 185, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id2", "d_limestonecave_52_1", Rectangle(-88, 1057, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id2", "d_limestonecave_52_1", Rectangle(-49, 1338, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id2", "d_limestonecave_52_1", Rectangle(1337, 203, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id2", "d_limestonecave_52_1", Rectangle(1278, -306, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id2", "d_limestonecave_52_1", Rectangle(1335, 854, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id2", "d_limestonecave_52_1", Rectangle(1327, 1488, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id2", "d_limestonecave_52_1", Rectangle(580, 1436, 30));

		// 'Rockon' GenType 10 Spawn Points
		AddSpawnPoint("d_limestonecave_52_1.Id3", "d_limestonecave_52_1", Rectangle(532, 1450, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id3", "d_limestonecave_52_1", Rectangle(1424, 1541, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id3", "d_limestonecave_52_1", Rectangle(1311, 940, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id3", "d_limestonecave_52_1", Rectangle(1351, 140, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id3", "d_limestonecave_52_1", Rectangle(611, 176, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id3", "d_limestonecave_52_1", Rectangle(700, 709, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id3", "d_limestonecave_52_1", Rectangle(434, 130, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id3", "d_limestonecave_52_1", Rectangle(92, 158, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id3", "d_limestonecave_52_1", Rectangle(-101, 1123, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id3", "d_limestonecave_52_1", Rectangle(-54, 1364, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id3", "d_limestonecave_52_1", Rectangle(-1135, 1350, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id3", "d_limestonecave_52_1", Rectangle(-1262, 1349, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id3", "d_limestonecave_52_1", Rectangle(-1153, 434, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id3", "d_limestonecave_52_1", Rectangle(-837, 499, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id3", "d_limestonecave_52_1", Rectangle(-1115, -167, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id3", "d_limestonecave_52_1", Rectangle(-1005, -951, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id3", "d_limestonecave_52_1", Rectangle(-623, -836, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id3", "d_limestonecave_52_1", Rectangle(-1036, 461, 35));

		// 'Tala_Sorcerer' GenType 11 Spawn Points
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(-854, -723, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(-861, -865, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(-1124, -244, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(-1324, 291, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(-918, 471, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(-1395, 1292, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(-1075, 1408, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(-84, 1076, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(-69, 1338, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(569, 1529, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(630, 1281, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(1038, 1602, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(1448, 1480, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(1311, 1070, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(672, 680, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(814, 657, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(1488, 926, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(1309, 250, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(1338, 20, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(1296, -260, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(517, -9, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(392, 173, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(96, 79, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(-1025, -106, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(-1147, -30, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(1179, 1559, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(1255, 1422, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(1365, 1616, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(1407, 1337, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(1438, 1432, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(1566, 1567, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(1665, 1425, 30));

		// 'Flak_Green' GenType 12 Spawn Points
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-498, -870, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-960, -1016, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-1262, -74, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-1127, -90, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-1253, 331, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-1235, 230, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-903, 588, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-1052, 1391, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-1243, 1291, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-286, 70, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-173, 121, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(1066, 39, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-330, -43, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-184, 37, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(1285, 13, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(1222, 157, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(1477, -5, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(1309, -231, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-105, 235, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(20, 220, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(68, 140, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(1103, 857, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(659, 1383, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(508, 1536, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-1065, -19, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-320, -228, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-231, 117, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-96, 295, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-34, 276, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-104, 29, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(1381, -100, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(81, 49, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-102, 177, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-200, -147, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-73, 78, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(1505, 135, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-212, -53, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(941, 30, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-202, 190, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-29, 89, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-401, -440, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-8, 163, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(1355, 254, 35));

		// 'Rootcrystal_04' GenType 26 Spawn Points
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(208, -1115, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(-436, -859, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(-789, -870, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(-1023, -1027, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(-845, -687, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(-835, -131, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(-1299, -142, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(-1193, 126, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(-1195, 353, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(-1506, 291, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(-845, 380, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(-734, 616, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(-174, 1249, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(16, 1021, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(75, 1335, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(-233, 1445, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(1234, 1488, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(1485, 1410, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(1641, 1504, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(1410, 1626, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(1395, 1806, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(557, 1611, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(609, 1925, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(-1077, 1276, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(-1383, 1350, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(-430, -242, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(-202, -37, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(45, 142, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(518, 127, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(899, 2, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(1244, 211, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(1414, -199, 15));

		// 'Rockoff' GenType 1001 Spawn Points
		AddSpawnPoint("d_limestonecave_52_1.Id7", "d_limestonecave_52_1", Rectangle(-212, -23, 9999));
	}
}
