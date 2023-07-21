//--- Melia Script -----------------------------------------------------------
// Elgos Monastery Main Building Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_abbey_35_4'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DAbbey354MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_abbey_35_4", MonsterId.Hohen_Mane_Brown, Properties("MHP", 371614, "MINPATK", 5279, "MAXPATK", 6391, "MINMATK", 5279, "MAXMATK", 6391, "DEF", 37135, "MDEF", 37135));
		AddPropertyOverrides("d_abbey_35_4", MonsterId.Hohen_Orben_Green, Properties("MHP", 377974, "MINPATK", 5361, "MAXPATK", 6491, "MINMATK", 5361, "MAXMATK", 6491, "DEF", 38706, "MDEF", 38706));
		AddPropertyOverrides("d_abbey_35_4", MonsterId.Harugal_Brown, Properties("MHP", 384630, "MINPATK", 5447, "MAXPATK", 6596, "MINMATK", 5447, "MAXMATK", 6596, "DEF", 40351, "MDEF", 40351));
		AddPropertyOverrides("d_abbey_35_4", MonsterId.Boss_Glutton_Q1, Properties("MHP", 3269610, "MINPATK", 17438, "MAXPATK", 21124, "MINMATK", 17438, "MAXMATK", 21124, "DEF", 132505, "MDEF", 132505));

		// Monster Spawners ---------------------------------

		AddSpawner("d_abbey_35_4.Id1", MonsterId.Hohen_Mane_Brown, 27, 35, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_35_4.Id2", MonsterId.Hohen_Orben_Green, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_35_4.Id3", MonsterId.Harugal_Brown, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_35_4.Id4", MonsterId.Hohen_Mane_Brown, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_35_4.Id5", MonsterId.Rootcrystal_01, 14, 18, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Hohen_Mane_Brown' GenType 2 Spawn Points
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(-28, -376, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(70, -495, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(175, -442, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(151, -281, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(36, -262, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(-47, -141, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(143, -41, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(462, 189, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(358, -140, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(-88, 219, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(150, 256, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(-64, -435, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(-67, -218, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(454, 55, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(439, 268, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(588, 103, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(647, 202, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(604, -399, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(715, -331, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(804, -506, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(961, -665, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(1019, -606, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(1683, -833, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(1654, -1232, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(1601, -1011, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(1519, -1198, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(1553, -778, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(1670, -995, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(1244, -836, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(1382, -1281, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(1463, -1144, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(1637, -1118, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(1691, -1272, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(1541, -892, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(1739, -915, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(1085, -1165, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(795, -1292, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(848, -1111, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(947, -1294, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(908, -1109, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(773, -1117, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(-68, 32, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(199, 224, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(-4, 348, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(139, 401, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(-30, 548, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(129, 500, 30));

		// 'Hohen_Orben_Green' GenType 3 Spawn Points
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(-1437, 760, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(-1174, 781, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(-1347, -390, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(-1321, -652, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(-489, 641, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(-543, -331, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(70, 588, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(486, 131, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(48, -291, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(54, 1001, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(664, 140, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(593, -317, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(1643, -890, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(1590, -1179, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(807, -459, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(1107, -710, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(1519, -896, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(1699, -1101, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(1413, -1228, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(1668, -1307, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(-338, 190, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(-52, 287, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(274, 110, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(-595, 152, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(283, -61, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(1752, -858, 30));

		// 'Harugal_Brown' GenType 4 Spawn Points
		AddSpawnPoint("d_abbey_35_4.Id3", "d_abbey_35_4", Rectangle(1549, -936, 30));
		AddSpawnPoint("d_abbey_35_4.Id3", "d_abbey_35_4", Rectangle(-504, -358, 30));
		AddSpawnPoint("d_abbey_35_4.Id3", "d_abbey_35_4", Rectangle(-508, 644, 30));
		AddSpawnPoint("d_abbey_35_4.Id3", "d_abbey_35_4", Rectangle(567, 147, 30));
		AddSpawnPoint("d_abbey_35_4.Id3", "d_abbey_35_4", Rectangle(63, -320, 30));
		AddSpawnPoint("d_abbey_35_4.Id3", "d_abbey_35_4", Rectangle(50, 916, 30));
		AddSpawnPoint("d_abbey_35_4.Id3", "d_abbey_35_4", Rectangle(42, 555, 30));
		AddSpawnPoint("d_abbey_35_4.Id3", "d_abbey_35_4", Rectangle(1787, -1277, 30));
		AddSpawnPoint("d_abbey_35_4.Id3", "d_abbey_35_4", Rectangle(1297, -1255, 30));
		AddSpawnPoint("d_abbey_35_4.Id3", "d_abbey_35_4", Rectangle(48, 276, 30));

		// 'Hohen_Mane_Brown' GenType 5 Spawn Points
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(2, 721, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(164, 569, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-68, 621, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(47, 655, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-57, 398, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(108, 348, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(19, 542, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(157, 702, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-419, 214, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-452, 85, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-649, 174, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-496, 424, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-544, 653, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-450, 533, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-524, -23, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-558, -296, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-573, -438, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-419, -354, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-481, -398, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-1369, 619, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-1441, 703, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-1375, 867, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-1213, 845, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-1186, 683, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-1372, -344, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-1473, -471, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-1410, -670, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-1242, -646, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-1188, -500, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-1156, -360, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-1503, -383, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-1146, 142, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-1192, 70, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-1139, 26, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-1079, 131, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-558, 101, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-440, 685, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-56, 153, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-146, 131, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-280, 160, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(201, 101, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(236, 212, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(272, 80, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(30, -27, 30));

		// 'Rootcrystal_01' GenType 13 Spawn Points
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(-1306, 892, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(-1316, 590, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(-1520, 106, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(-1229, 123, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(-1324, -359, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(-1328, -671, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(-501, 611, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(-558, 130, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(-529, -346, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(-208, 131, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(355, 123, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(75, -380, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(62, -125, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(67, 411, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(57, 648, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(68, 1239, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(652, 132, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(289, -1193, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(952, -1247, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(1387, -1256, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(1713, -1248, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(1749, -919, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(1453, -898, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(1554, -855, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(679, -370, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(869, -544, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(1114, -740, 100));
	}
}
