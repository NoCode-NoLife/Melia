//--- Melia Script -----------------------------------------------------------
// Maven 31 Waters Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_3cmlake_27_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class F3Cmlake272MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_3cmlake_27_2", MonsterId.Velpod, Properties("MHP", 671922, "MINPATK", 9141, "MAXPATK", 11137, "MINMATK", 9141, "MAXMATK", 11137, "DEF", 171064, "MDEF", 171064));
		AddPropertyOverrides("f_3cmlake_27_2", MonsterId.Tooter, Properties("MHP", 672779, "MINPATK", 9152, "MAXPATK", 11151, "MINMATK", 9152, "MAXMATK", 11151, "DEF", 171676, "MDEF", 171676));
		AddPropertyOverrides("f_3cmlake_27_2", MonsterId.Monitor_Lizard, Properties("MHP", 673751, "MINPATK", 9165, "MAXPATK", 11166, "MINMATK", 9165, "MAXMATK", 11166, "DEF", 172371, "MDEF", 172371));
		AddPropertyOverrides("f_3cmlake_27_2", MonsterId.Boss_Moldyhorn_3cmlake_27_2, Properties("MHP", 3522587, "MINPATK", 23130, "MAXPATK", 28181, "MINMATK", 23130, "MAXMATK", 28181, "DEF", 436310, "MDEF", 436310));

		// Monster Spawners ---------------------------------

		AddSpawner("f_3cmlake_27_2.Id1", MonsterId.Velpod, min: 49, max: 65);
		AddSpawner("f_3cmlake_27_2.Id2", MonsterId.Tooter, min: 11, max: 14);
		AddSpawner("f_3cmlake_27_2.Id3", MonsterId.Rootcrystal_02, min: 16, max: 21, respawn: TimeSpan.FromMilliseconds(20000));
		AddSpawner("f_3cmlake_27_2.Id4", MonsterId.Monitor_Lizard, min: 60, max: 80);

		// Monster Spawn Points -----------------------------

		// 'Velpod' GenType 1 Spawn Points
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-1245, -143, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1475, -376, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1665, -334, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1078, -362, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(759, -314, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(949, -437, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(877, -505, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(728, -465, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(823, -572, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1794, -349, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1697, -390, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1735, -296, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1834, -374, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1709, -497, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1660, -576, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1760, -606, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1693, -654, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1949, -529, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1952, -365, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1983, -289, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(2168, -392, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(2064, -494, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(2019, -407, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1804, -704, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(892, -267, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1005, -276, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1500, -441, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1058, -531, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(885, -339, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-1000, 360, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-462, -467, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-724, -231, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-834, -828, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-521, -439, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-1041, 325, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-740, 965, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-627, 464, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-573, 424, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-710, -66, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-350, 441, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-614, 1106, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-723, 1213, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-565, 1214, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-407, 1099, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-593, 956, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-485, 1145, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-626, 276, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-794, 185, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-756, 27, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-642, 110, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-547, 219, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-1504, -192, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-1462, -238, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-1251, -417, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-1315, -431, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-1445, -187, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-746, -463, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-854, -517, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-822, -599, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-768, -555, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-919, -1044, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-653, -1074, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-430, 948, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(-430, 948, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1431, -396, 25));
		AddSpawnPoint("f_3cmlake_27_2.Id1", "f_3cmlake_27_2", Rectangle(1891, -304, 25));

		// 'Tooter' GenType 2 Spawn Points
		AddSpawnPoint("f_3cmlake_27_2.Id2", "f_3cmlake_27_2", Rectangle(-559, 1054, 20));
		AddSpawnPoint("f_3cmlake_27_2.Id2", "f_3cmlake_27_2", Rectangle(-749, -36, 20));
		AddSpawnPoint("f_3cmlake_27_2.Id2", "f_3cmlake_27_2", Rectangle(-1337, -288, 20));
		AddSpawnPoint("f_3cmlake_27_2.Id2", "f_3cmlake_27_2", Rectangle(-838, -576, 20));
		AddSpawnPoint("f_3cmlake_27_2.Id2", "f_3cmlake_27_2", Rectangle(-692, -1165, 20));
		AddSpawnPoint("f_3cmlake_27_2.Id2", "f_3cmlake_27_2", Rectangle(661, -1654, 20));
		AddSpawnPoint("f_3cmlake_27_2.Id2", "f_3cmlake_27_2", Rectangle(519, -1016, 20));
		AddSpawnPoint("f_3cmlake_27_2.Id2", "f_3cmlake_27_2", Rectangle(1736, -337, 20));
		AddSpawnPoint("f_3cmlake_27_2.Id2", "f_3cmlake_27_2", Rectangle(-452, -1823, 20));
		AddSpawnPoint("f_3cmlake_27_2.Id2", "f_3cmlake_27_2", Rectangle(-693, -359, 20));
		AddSpawnPoint("f_3cmlake_27_2.Id2", "f_3cmlake_27_2", Rectangle(-554, 319, 20));
		AddSpawnPoint("f_3cmlake_27_2.Id2", "f_3cmlake_27_2", Rectangle(-877, 279, 20));
		AddSpawnPoint("f_3cmlake_27_2.Id2", "f_3cmlake_27_2", Rectangle(-836, -870, 20));
		AddSpawnPoint("f_3cmlake_27_2.Id2", "f_3cmlake_27_2", Rectangle(2111, -512, 20));

		// 'Rootcrystal_02' GenType 27 Spawn Points
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(1703, -492, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(823, -432, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(649, -978, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(679, -1526, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(47, -1669, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(-438, -1800, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(-784, -643, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(-794, -1068, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(-1265, -245, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(-484, 432, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(-591, 1024, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(138, 396, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(345, -429, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(-33, -452, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(2082, -448, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(-696, 137, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(475, -1625, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(1159, -417, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(270, 51, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(46, -1995, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(297, -958, 200));
		AddSpawnPoint("f_3cmlake_27_2.Id3", "f_3cmlake_27_2", Rectangle(-748, -250, 200));

		// 'Monitor_Lizard' GenType 28 Spawn Points
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(539, -1551, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(441, -1678, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(502, -969, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(498, -893, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(605, -797, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(688, -890, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(757, -1014, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(779, -850, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(606, -1483, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(773, -1522, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(640, -1400, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(565, -1729, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(739, -1569, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(572, -1664, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(753, -1676, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(419, -1635, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(151, -1629, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(62, -1590, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(11, -1619, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-494, -1953, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-463, -1893, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-579, -1792, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-571, -1730, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-384, -1977, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-332, -1948, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-356, -1764, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(690, -1074, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(64, -1118, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(45, -997, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(636, -1091, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-731, -951, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-333, -1825, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(3, -1082, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-450, -1829, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-807, -628, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-895, -499, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-694, -458, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-859, -665, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-684, -273, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-475, -1661, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-417, -1638, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-789, -449, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-1159, -227, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-1436, -343, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-1171, -300, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-1239, -340, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-1141, -98, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-1449, -403, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-1341, -172, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-681, -217, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-769, -1, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-663, 112, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-858, 281, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-649, 340, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-714, 249, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-448, 486, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-555, 502, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-664, 1048, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-433, 1235, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-391, 1134, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-479, 1012, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-642, 1239, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-518, 1142, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-586, 745, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-589, 645, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-581, 944, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(610, -892, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(707, -952, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(373, -986, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(148, -957, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-795, -1148, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-853, -1062, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-802, -961, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-679, -986, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-733, -1044, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-989, -289, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-830, -284, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-630, 5, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-880, -994, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-471, 169, 30));
		AddSpawnPoint("f_3cmlake_27_2.Id4", "f_3cmlake_27_2", Rectangle(-407, 369, 30));
	}
}
