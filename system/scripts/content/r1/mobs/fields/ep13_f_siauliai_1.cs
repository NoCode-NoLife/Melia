//--- Melia Script -----------------------------------------------------------
// Lemprasa Pond Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'ep13_f_siauliai_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class Ep13FSiauliai1MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("ep13_f_siauliai_1", MonsterId.Liepsna_Invader, Properties("MHP", 910601, "MINPATK", 12210, "MAXPATK", 14909, "MINMATK", 12210, "MAXMATK", 14909, "DEF", 373977, "MDEF", 373977));
		AddPropertyOverrides("ep13_f_siauliai_1", MonsterId.Liepsna_Destroyer, Properties("MHP", 911557, "MINPATK", 12222, "MAXPATK", 14924, "MINMATK", 12222, "MAXMATK", 14924, "DEF", 375060, "MDEF", 375060));
		AddPropertyOverrides("ep13_f_siauliai_1", MonsterId.Liepsna_Chaser, Properties("MHP", 913304, "MINPATK", 12245, "MAXPATK", 14952, "MINMATK", 12245, "MAXMATK", 14952, "DEF", 377040, "MDEF", 377040));
		AddPropertyOverrides("ep13_f_siauliai_1", MonsterId.Liepsna_Spreader, Properties("MHP", 915566, "MINPATK", 12274, "MAXPATK", 14987, "MINMATK", 12274, "MAXMATK", 14987, "DEF", 379605, "MDEF", 379605));
		AddPropertyOverrides("ep13_f_siauliai_1", MonsterId.Boss_Liepsna_Firebug, Properties("MHP", 5013621, "MINPATK", 33971, "MAXPATK", 41482, "MINMATK", 33971, "MAXMATK", 41482, "DEF", 1056090, "MDEF", 1056090));

		// Monster Spawners ---------------------------------

		AddSpawner("ep13_f_siauliai_1.Id1", MonsterId.Rootcrystal_01, min: 15, max: 20, respawn: TimeSpan.FromMilliseconds(20000));
		AddSpawner("ep13_f_siauliai_1.Id2", MonsterId.Liepsna_Invader, min: 60, max: 80, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id3", MonsterId.Liepsna_Destroyer, min: 30, max: 40, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id4", MonsterId.Liepsna_Chaser, min: 60, max: 80, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id5", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id6", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id7", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id8", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id9", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id10", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id11", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id12", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id13", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id14", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id15", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id16", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id17", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id18", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id19", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id20", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id21", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id22", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id23", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id24", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id25", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id26", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id27", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id28", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id29", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id30", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id31", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id32", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id33", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id34", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id35", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id36", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id37", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id38", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id39", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id40", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id41", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id42", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id43", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id44", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id45", MonsterId.Liepsna_Invader, min: 15, max: 20, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id46", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id47", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_1.Id48", MonsterId.Liepsna_Spreader, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 4 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(329, -300, 100));
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(371, 128, 100));
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(760, 544, 100));
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(722, 1229, 100));
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(250, 1572, 100));
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(-511, 1584, 100));
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(-863, 1551, 100));
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(-669, 1010, 100));
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(-362, 562, 100));
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(-429, 136, 100));
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(-389, -443, 100));
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(-767, -547, 100));
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(-890, -806, 100));
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(-1710, -1188, 100));
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(-1547, -1449, 100));
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(-351, -1623, 100));
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(-13, -1109, 100));
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(71, -1538, 100));
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(1358, 104, 100));
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(1859, 155, 100));

		// 'Liepsna_Invader' GenType 1000 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-1665, -1578, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-1794, -1398, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-1553, -1436, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-1362, -1473, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-1635, -1237, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-1673, -1042, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-822, -726, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-708, -650, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-791, -513, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-726, -435, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-214, -1548, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-7, -1567, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-73, -1842, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(54, -1965, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(124, -1284, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(73, -1003, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(158, -310, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(259, -141, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(878, 993, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(668, 1213, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(756, 1771, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(965, 1748, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(192, 1675, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(391, 1556, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(139, 992, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(188, 1186, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-442, 942, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-251, 839, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-549, 1617, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-470, 1821, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-871, 1678, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-936, 1925, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-703, 1103, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-820, 1424, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-976, 998, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-765, 1030, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(390, 109, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(504, 263, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(1901, 114, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(1515, 114, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(474, -328, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(624, -340, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(861, 1441, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-506, -529, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-249, -860, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-299, -687, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-45, -1044, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-541, 312, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-117, 197, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-420, 95, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(754, -166, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-831, 1563, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-931, 1262, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-598, 1159, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(1778, 95, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(1834, 164, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(758, 1542, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(677, 1123, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(152, 1389, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(216, 1439, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(100, 1226, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(260, 926, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-675, 885, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-1137, -1527, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-1233, -1006, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(66, -860, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(87, -590, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(191, -449, 20));

		// 'Liepsna_Destroyer' GenType 1001 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-1753, -1504, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-1456, -1471, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-1676, -1169, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-737, -730, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-815, -379, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-16, -2037, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(81, -1146, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(212, -235, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(439, 200, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-552, 679, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-344, 891, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-874, 1021, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-774, 1312, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-941, 1791, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-531, 1728, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(182, 1063, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(295, 1602, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(871, 1736, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(757, 1191, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-112, -1567, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(891, -238, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(742, -279, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(510, 1354, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(667, 1533, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-584, 957, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-463, 1138, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(207, -1368, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-947, -784, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(407, -55, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(314, 1334, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-718, 1611, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-1070, 1144, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-115, -1259, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(125, 1447, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-875, -586, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(36, -1741, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(1746, 160, 20));

		// 'Liepsna_Chaser' GenType 1002 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-1775, -1592, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-1681, -1455, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-1431, -1563, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-1443, -1360, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-1786, -1206, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-1577, -1035, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-908, -450, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-719, -337, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-807, -823, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-638, -663, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-64, -1929, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-82, -1658, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-212, -1417, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-19, -1194, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(194, -1118, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(140, -138, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(269, -325, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(303, 240, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(514, 120, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(779, 1087, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(744, 1335, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(829, 1642, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(914, 1866, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(235, 1518, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(350, 1696, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(73, 1071, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(297, 1016, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-514, 586, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-587, 780, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-323, 1024, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-844, 897, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-941, 1123, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-837, 1235, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-734, 1466, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-1079, 1863, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-831, 1800, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-661, 1756, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-443, 1659, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(1833, 263, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(1748, 55, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(1834, 63, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(1631, 87, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(1743, 239, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(1397, 112, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(492, -183, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(620, -233, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(749, -399, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(837, -314, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(669, 344, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(720, 779, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(521, 1482, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(628, 1370, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-406, 1162, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-487, 1034, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-630, 1026, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-574, 882, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-369, -464, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-340, -350, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-419, -192, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-154, -156, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(101, -1552, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(191, -1470, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-488, -1785, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-303, -1638, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-696, -1559, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-1350, -1076, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-1033, -897, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-301, 188, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-307, 386, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-274, 529, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-479, 426, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(367, -118, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(694, 1676, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(231, 1355, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(391, 1352, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-1091, 1065, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-1020, 1207, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-992, 1707, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(796, -554, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(930, -578, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(565, 1285, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-462, 1537, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-46, 1518, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-728, 1188, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-657, 1266, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-934, -614, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-710, -573, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-1515, -1543, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-1600, -1530, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-1728, -1324, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-1546, -1331, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-154, -1121, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-123, -923, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-16, -940, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-404, -1783, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(10, -1954, 20));

		// 'Liepsna_Spreader' GenType 1003 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id5", "ep13_f_siauliai_1", Rectangle(-1877, -1401, 20));

		// 'Liepsna_Spreader' GenType 1004 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id6", "ep13_f_siauliai_1", Rectangle(-1847, -1203, 20));

		// 'Liepsna_Spreader' GenType 1005 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id7", "ep13_f_siauliai_1", Rectangle(-1542, -1637, 20));

		// 'Liepsna_Spreader' GenType 1006 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id8", "ep13_f_siauliai_1", Rectangle(-1526, -1251, 20));

		// 'Liepsna_Spreader' GenType 1007 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id9", "ep13_f_siauliai_1", Rectangle(-1330, -1184, 20));

		// 'Liepsna_Spreader' GenType 1008 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id10", "ep13_f_siauliai_1", Rectangle(-895, -915, 20));

		// 'Liepsna_Spreader' GenType 1009 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id11", "ep13_f_siauliai_1", Rectangle(-998, -631, 20));

		// 'Liepsna_Spreader' GenType 1010 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id12", "ep13_f_siauliai_1", Rectangle(-635, -526, 20));

		// 'Liepsna_Spreader' GenType 1011 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id13", "ep13_f_siauliai_1", Rectangle(-421, -416, 20));

		// 'Liepsna_Spreader' GenType 1012 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id14", "ep13_f_siauliai_1", Rectangle(-231, -960, 20));

		// 'Liepsna_Spreader' GenType 1013 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id15", "ep13_f_siauliai_1", Rectangle(-583, -1734, 20));

		// 'Liepsna_Spreader' GenType 1014 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id16", "ep13_f_siauliai_1", Rectangle(-367, -1534, 20));

		// 'Liepsna_Spreader' GenType 1015 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id17", "ep13_f_siauliai_1", Rectangle(58, -1888, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id17", "ep13_f_siauliai_1", Rectangle(565, 335, 20));

		// 'Liepsna_Spreader' GenType 1016 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id18", "ep13_f_siauliai_1", Rectangle(40, -1414, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id18", "ep13_f_siauliai_1", Rectangle(119, 304, 20));

		// 'Liepsna_Spreader' GenType 1017 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id19", "ep13_f_siauliai_1", Rectangle(-238, -1263, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id19", "ep13_f_siauliai_1", Rectangle(248, 85, 20));

		// 'Liepsna_Spreader' GenType 1018 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id20", "ep13_f_siauliai_1", Rectangle(-495, 144, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id20", "ep13_f_siauliai_1", Rectangle(806, -629, 20));

		// 'Liepsna_Spreader' GenType 1019 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id21", "ep13_f_siauliai_1", Rectangle(91, 19, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id21", "ep13_f_siauliai_1", Rectangle(882, -410, 20));

		// 'Liepsna_Spreader' GenType 1020 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id22", "ep13_f_siauliai_1", Rectangle(71, -158, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id22", "ep13_f_siauliai_1", Rectangle(535, -392, 20));

		// 'Liepsna_Spreader' GenType 1021 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id23", "ep13_f_siauliai_1", Rectangle(298, -469, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id23", "ep13_f_siauliai_1", Rectangle(841, 434, 20));

		// 'Liepsna_Spreader' GenType 1022 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id24", "ep13_f_siauliai_1", Rectangle(730, -494, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id24", "ep13_f_siauliai_1", Rectangle(696, 613, 20));

		// 'Liepsna_Spreader' GenType 1023 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id25", "ep13_f_siauliai_1", Rectangle(941, -506, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id25", "ep13_f_siauliai_1", Rectangle(876, 920, 20));

		// 'Liepsna_Spreader' GenType 1024 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id26", "ep13_f_siauliai_1", Rectangle(902, -658, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id26", "ep13_f_siauliai_1", Rectangle(623, 968, 20));

		// 'Liepsna_Spreader' GenType 1025 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id27", "ep13_f_siauliai_1", Rectangle(538, 1092, 20));

		// 'Liepsna_Spreader' GenType 1026 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id28", "ep13_f_siauliai_1", Rectangle(541, 1669, 20));

		// 'Liepsna_Spreader' GenType 1027 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id29", "ep13_f_siauliai_1", Rectangle(723, 1870, 20));

		// 'Liepsna_Spreader' GenType 1028 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id30", "ep13_f_siauliai_1", Rectangle(960, 1612, 20));

		// 'Liepsna_Spreader' GenType 1029 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id31", "ep13_f_siauliai_1", Rectangle(130, 1643, 20));

		// 'Liepsna_Spreader' GenType 1030 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id32", "ep13_f_siauliai_1", Rectangle(265, 1780, 20));

		// 'Liepsna_Spreader' GenType 1031 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id33", "ep13_f_siauliai_1", Rectangle(50, 1176, 20));

		// 'Liepsna_Spreader' GenType 1032 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id34", "ep13_f_siauliai_1", Rectangle(105, 928, 20));

		// 'Liepsna_Spreader' GenType 1033 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id35", "ep13_f_siauliai_1", Rectangle(335, 1059, 20));

		// 'Liepsna_Spreader' GenType 1034 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id36", "ep13_f_siauliai_1", Rectangle(107, 1342, 20));

		// 'Liepsna_Spreader' GenType 1035 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id37", "ep13_f_siauliai_1", Rectangle(-629, 1348, 20));

		// 'Liepsna_Spreader' GenType 1036 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id38", "ep13_f_siauliai_1", Rectangle(-460, 1308, 20));

		// 'Liepsna_Spreader' GenType 1037 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id39", "ep13_f_siauliai_1", Rectangle(-575, 1464, 20));

		// 'Liepsna_Spreader' GenType 1038 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id40", "ep13_f_siauliai_1", Rectangle(-428, 1401, 20));

		// 'Liepsna_Spreader' GenType 1039 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id41", "ep13_f_siauliai_1", Rectangle(-1032, 949, 20));

		// 'Liepsna_Spreader' GenType 1040 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id42", "ep13_f_siauliai_1", Rectangle(-483, 352, 20));

		// 'Liepsna_Spreader' GenType 1041 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id43", "ep13_f_siauliai_1", Rectangle(-305, 475, 20));

		// 'Liepsna_Spreader' GenType 1042 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id44", "ep13_f_siauliai_1", Rectangle(-615, 635, 20));

		// 'Liepsna_Invader' GenType 1043 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id45", "ep13_f_siauliai_1", Rectangle(-747, 803, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id45", "ep13_f_siauliai_1", Rectangle(-549, 1482, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id45", "ep13_f_siauliai_1", Rectangle(-513, 1248, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id45", "ep13_f_siauliai_1", Rectangle(-161, 1526, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id45", "ep13_f_siauliai_1", Rectangle(-390, 1442, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id45", "ep13_f_siauliai_1", Rectangle(-415, -355, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id45", "ep13_f_siauliai_1", Rectangle(-414, -1728, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id45", "ep13_f_siauliai_1", Rectangle(-923, -1509, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id45", "ep13_f_siauliai_1", Rectangle(-984, -687, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id45", "ep13_f_siauliai_1", Rectangle(-947, -897, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id45", "ep13_f_siauliai_1", Rectangle(-1499, -1225, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id45", "ep13_f_siauliai_1", Rectangle(253, 36, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id45", "ep13_f_siauliai_1", Rectangle(535, -295, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id45", "ep13_f_siauliai_1", Rectangle(848, -525, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id45", "ep13_f_siauliai_1", Rectangle(564, 1194, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id45", "ep13_f_siauliai_1", Rectangle(-425, 199, 20));

		// 'Liepsna_Spreader' GenType 1044 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id46", "ep13_f_siauliai_1", Rectangle(-251, 641, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id46", "ep13_f_siauliai_1", Rectangle(1853, 360, 20));

		// 'Liepsna_Spreader' GenType 1045 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id47", "ep13_f_siauliai_1", Rectangle(-695, 1873, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id47", "ep13_f_siauliai_1", Rectangle(1751, 287, 20));

		// 'Liepsna_Spreader' GenType 1046 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id48", "ep13_f_siauliai_1", Rectangle(-827, 1876, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id48", "ep13_f_siauliai_1", Rectangle(298, -1362, 20));
	}
}
