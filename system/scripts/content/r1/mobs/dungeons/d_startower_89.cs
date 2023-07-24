//--- Melia Script -----------------------------------------------------------
// Astral Tower 4F Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_startower_89'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DStartower89MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_startower_89", MonsterId.Naste, Properties("MHP", 617472, "MINPATK", 8441, "MAXPATK", 10276, "MINMATK", 8441, "MAXMATK", 10276, "DEF", 138272, "MDEF", 138272));
		AddPropertyOverrides("d_startower_89", MonsterId.Gleamlens, Properties("MHP", 619027, "MINPATK", 8461, "MAXPATK", 10301, "MINMATK", 8461, "MAXMATK", 10301, "DEF", 139204, "MDEF", 139204));
		AddPropertyOverrides("d_startower_89", MonsterId.Wryer, Properties("MHP", 620619, "MINPATK", 8481, "MAXPATK", 10326, "MINMATK", 8481, "MAXMATK", 10326, "DEF", 140157, "MDEF", 140157));
		AddPropertyOverrides("d_startower_89", MonsterId.Rabbler, Properties("MHP", 622245, "MINPATK", 8502, "MAXPATK", 10352, "MINMATK", 8502, "MAXMATK", 10352, "DEF", 141131, "MDEF", 141131));
		AddPropertyOverrides("d_startower_89", MonsterId.Boss_Durahan_Q4, Properties("MHP", 3256791, "MINPATK", 21480, "MAXPATK", 26153, "MINMATK", 21480, "MAXMATK", 26153, "DEF", 358157, "MDEF", 358157));
		AddPropertyOverrides("d_startower_89", MonsterId.Rubabos_Red, Properties("MHP", 625601, "MINPATK", 8546, "MAXPATK", 10405, "MINMATK", 8546, "MAXMATK", 10405, "DEF", 143140, "MDEF", 143140));
		AddPropertyOverrides("d_startower_89", MonsterId.Boss_Werewolf_Q4, Properties("MHP", 3274651, "MINPATK", 21591, "MAXPATK", 26289, "MINMATK", 21591, "MAXMATK", 26289, "DEF", 363320, "MDEF", 363320));
		AddPropertyOverrides("d_startower_89", MonsterId.Worg, Properties("MHP", 629087, "MINPATK", 8590, "MAXPATK", 10460, "MINMATK", 8590, "MAXMATK", 10460, "DEF", 145228, "MDEF", 145228));
		AddPropertyOverrides("d_startower_89", MonsterId.Boss_Mummyghast_Q3, Properties("MHP", 3293187, "MINPATK", 21706, "MAXPATK", 26430, "MINMATK", 21706, "MAXMATK", 26430, "DEF", 368679, "MDEF", 368679));

		// Monster Spawners ---------------------------------

		AddSpawner("d_startower_89.Id1", MonsterId.Naste, min: 12, max: 15);
		AddSpawner("d_startower_89.Id2", MonsterId.Gleamlens, min: 23, max: 30);
		AddSpawner("d_startower_89.Id3", MonsterId.Wryer, min: 21, max: 27);
		AddSpawner("d_startower_89.Id4", MonsterId.Rabbler, min: 36, max: 47);
		AddSpawner("d_startower_89.Id5", MonsterId.Naste, min: 8, max: 10);
		AddSpawner("d_startower_89.Id6", MonsterId.Rootcrystal_02, min: 12, max: 15, respawn: TimeSpan.FromMilliseconds(10000));

		// Monster Spawn Points -----------------------------

		// 'Naste' GenType 27 Spawn Points
		AddSpawnPoint("d_startower_89.Id1", "d_startower_89", Rectangle(1358, -1740, 25));
		AddSpawnPoint("d_startower_89.Id1", "d_startower_89", Rectangle(1531, -1645, 25));
		AddSpawnPoint("d_startower_89.Id1", "d_startower_89", Rectangle(1516, -1424, 25));
		AddSpawnPoint("d_startower_89.Id1", "d_startower_89", Rectangle(1428, -1210, 25));
		AddSpawnPoint("d_startower_89.Id1", "d_startower_89", Rectangle(1297, -1270, 25));
		AddSpawnPoint("d_startower_89.Id1", "d_startower_89", Rectangle(1283, -1038, 25));
		AddSpawnPoint("d_startower_89.Id1", "d_startower_89", Rectangle(1418, -959, 25));
		AddSpawnPoint("d_startower_89.Id1", "d_startower_89", Rectangle(1432, -695, 25));
		AddSpawnPoint("d_startower_89.Id1", "d_startower_89", Rectangle(1187, -842, 25));
		AddSpawnPoint("d_startower_89.Id1", "d_startower_89", Rectangle(1046, -808, 25));
		AddSpawnPoint("d_startower_89.Id1", "d_startower_89", Rectangle(689, -668, 25));
		AddSpawnPoint("d_startower_89.Id1", "d_startower_89", Rectangle(528, -860, 25));
		AddSpawnPoint("d_startower_89.Id1", "d_startower_89", Rectangle(332, -793, 25));
		AddSpawnPoint("d_startower_89.Id1", "d_startower_89", Rectangle(743, -525, 25));
		AddSpawnPoint("d_startower_89.Id1", "d_startower_89", Rectangle(1622, -1798, 25));

		// 'Gleamlens' GenType 28 Spawn Points
		AddSpawnPoint("d_startower_89.Id2", "d_startower_89", Rectangle(731, 461, 25));
		AddSpawnPoint("d_startower_89.Id2", "d_startower_89", Rectangle(981, 861, 25));
		AddSpawnPoint("d_startower_89.Id2", "d_startower_89", Rectangle(765, 955, 25));
		AddSpawnPoint("d_startower_89.Id2", "d_startower_89", Rectangle(816, 646, 25));
		AddSpawnPoint("d_startower_89.Id2", "d_startower_89", Rectangle(727, 1189, 25));
		AddSpawnPoint("d_startower_89.Id2", "d_startower_89", Rectangle(520, 1509, 25));
		AddSpawnPoint("d_startower_89.Id2", "d_startower_89", Rectangle(784, 1416, 25));
		AddSpawnPoint("d_startower_89.Id2", "d_startower_89", Rectangle(963, 1491, 25));
		AddSpawnPoint("d_startower_89.Id2", "d_startower_89", Rectangle(54, 1864, 25));
		AddSpawnPoint("d_startower_89.Id2", "d_startower_89", Rectangle(-104, 1865, 25));
		AddSpawnPoint("d_startower_89.Id2", "d_startower_89", Rectangle(-18, 1701, 25));
		AddSpawnPoint("d_startower_89.Id2", "d_startower_89", Rectangle(-537, 1696, 25));
		AddSpawnPoint("d_startower_89.Id2", "d_startower_89", Rectangle(-406, 1595, 25));
		AddSpawnPoint("d_startower_89.Id2", "d_startower_89", Rectangle(-174, 1339, 25));
		AddSpawnPoint("d_startower_89.Id2", "d_startower_89", Rectangle(-304, 1260, 25));
		AddSpawnPoint("d_startower_89.Id2", "d_startower_89", Rectangle(30, 951, 25));
		AddSpawnPoint("d_startower_89.Id2", "d_startower_89", Rectangle(19, 1244, 25));
		AddSpawnPoint("d_startower_89.Id2", "d_startower_89", Rectangle(-138, 988, 25));
		AddSpawnPoint("d_startower_89.Id2", "d_startower_89", Rectangle(-110, 710, 25));
		AddSpawnPoint("d_startower_89.Id2", "d_startower_89", Rectangle(98, 792, 25));
		AddSpawnPoint("d_startower_89.Id2", "d_startower_89", Rectangle(45, 586, 25));
		AddSpawnPoint("d_startower_89.Id2", "d_startower_89", Rectangle(302, 564, 25));
		AddSpawnPoint("d_startower_89.Id2", "d_startower_89", Rectangle(436, 825, 25));
		AddSpawnPoint("d_startower_89.Id2", "d_startower_89", Rectangle(-173, 838, 25));
		AddSpawnPoint("d_startower_89.Id2", "d_startower_89", Rectangle(627, 15, 25));
		AddSpawnPoint("d_startower_89.Id2", "d_startower_89", Rectangle(700, -89, 25));
		AddSpawnPoint("d_startower_89.Id2", "d_startower_89", Rectangle(661, -216, 25));
		AddSpawnPoint("d_startower_89.Id2", "d_startower_89", Rectangle(913, -179, 25));
		AddSpawnPoint("d_startower_89.Id2", "d_startower_89", Rectangle(818, 47, 25));
		AddSpawnPoint("d_startower_89.Id2", "d_startower_89", Rectangle(622, 1346, 25));

		// 'Wryer' GenType 29 Spawn Points
		AddSpawnPoint("d_startower_89.Id3", "d_startower_89", Rectangle(-490, 1125, 25));
		AddSpawnPoint("d_startower_89.Id3", "d_startower_89", Rectangle(-818, 962, 25));
		AddSpawnPoint("d_startower_89.Id3", "d_startower_89", Rectangle(-662, 852, 25));
		AddSpawnPoint("d_startower_89.Id3", "d_startower_89", Rectangle(-818, 715, 25));
		AddSpawnPoint("d_startower_89.Id3", "d_startower_89", Rectangle(-1068, 739, 25));
		AddSpawnPoint("d_startower_89.Id3", "d_startower_89", Rectangle(-1237, 711, 25));
		AddSpawnPoint("d_startower_89.Id3", "d_startower_89", Rectangle(-1199, 567, 25));
		AddSpawnPoint("d_startower_89.Id3", "d_startower_89", Rectangle(-915, 265, 25));
		AddSpawnPoint("d_startower_89.Id3", "d_startower_89", Rectangle(-927, -2, 25));
		AddSpawnPoint("d_startower_89.Id3", "d_startower_89", Rectangle(-671, -353, 25));
		AddSpawnPoint("d_startower_89.Id3", "d_startower_89", Rectangle(-659, -89, 25));
		AddSpawnPoint("d_startower_89.Id3", "d_startower_89", Rectangle(-445, -393, 25));
		AddSpawnPoint("d_startower_89.Id3", "d_startower_89", Rectangle(-535, -213, 25));
		AddSpawnPoint("d_startower_89.Id3", "d_startower_89", Rectangle(-538, 200, 25));
		AddSpawnPoint("d_startower_89.Id3", "d_startower_89", Rectangle(-372, 425, 25));
		AddSpawnPoint("d_startower_89.Id3", "d_startower_89", Rectangle(-172, 211, 25));
		AddSpawnPoint("d_startower_89.Id3", "d_startower_89", Rectangle(80, 130, 25));
		AddSpawnPoint("d_startower_89.Id3", "d_startower_89", Rectangle(-249, 12, 25));
		AddSpawnPoint("d_startower_89.Id3", "d_startower_89", Rectangle(44, -163, 25));
		AddSpawnPoint("d_startower_89.Id3", "d_startower_89", Rectangle(326, -103, 25));
		AddSpawnPoint("d_startower_89.Id3", "d_startower_89", Rectangle(419, -441, 25));
		AddSpawnPoint("d_startower_89.Id3", "d_startower_89", Rectangle(297, -270, 25));
		AddSpawnPoint("d_startower_89.Id3", "d_startower_89", Rectangle(-231, 1156, 25));
		AddSpawnPoint("d_startower_89.Id3", "d_startower_89", Rectangle(-280, 967, 25));
		AddSpawnPoint("d_startower_89.Id3", "d_startower_89", Rectangle(-179, -166, 25));
		AddSpawnPoint("d_startower_89.Id3", "d_startower_89", Rectangle(112, -49, 25));
		AddSpawnPoint("d_startower_89.Id3", "d_startower_89", Rectangle(-80, 115, 25));

		// 'Rabbler' GenType 30 Spawn Points
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(1368, -1640, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(1531, -1553, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(1563, -1329, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(1295, -1323, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(1369, -938, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(1269, -709, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(905, -865, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(641, -867, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(690, -609, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(765, -124, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(725, 269, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(557, -128, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(691, 131, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(803, 759, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(636, 1527, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(907, 965, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(652, 935, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(336, 683, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(163, 616, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(-41, 628, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(-17, 748, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(-128, 1149, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(123, 1060, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(-125, 1721, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(70, 1755, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(-553, 1619, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(-204, 1491, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(-485, 1224, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(-635, 971, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(-791, 833, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(-645, 746, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(-956, 557, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(-913, 355, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(-713, -154, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(-850, -212, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(-576, 67, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(-420, -167, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(-537, -367, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(321, -383, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(-420, 339, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(452, -524, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(1408, -1469, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(1630, -1172, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(1424, -813, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(781, -820, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(709, -326, 25));
		AddSpawnPoint("d_startower_89.Id4", "d_startower_89", Rectangle(956, -10, 25));

		// 'Naste' GenType 34 Spawn Points
		AddSpawnPoint("d_startower_89.Id5", "d_startower_89", Rectangle(-745, -98, 25));
		AddSpawnPoint("d_startower_89.Id5", "d_startower_89", Rectangle(-529, -120, 25));
		AddSpawnPoint("d_startower_89.Id5", "d_startower_89", Rectangle(-436, -289, 25));
		AddSpawnPoint("d_startower_89.Id5", "d_startower_89", Rectangle(-880, 82, 25));
		AddSpawnPoint("d_startower_89.Id5", "d_startower_89", Rectangle(-861, 205, 25));
		AddSpawnPoint("d_startower_89.Id5", "d_startower_89", Rectangle(-874, 505, 25));
		AddSpawnPoint("d_startower_89.Id5", "d_startower_89", Rectangle(-959, -126, 25));
		AddSpawnPoint("d_startower_89.Id5", "d_startower_89", Rectangle(-579, -336, 25));
		AddSpawnPoint("d_startower_89.Id5", "d_startower_89", Rectangle(-464, 264, 25));
		AddSpawnPoint("d_startower_89.Id5", "d_startower_89", Rectangle(-271, 493, 25));

		// 'Rootcrystal_02' GenType 39 Spawn Points
		AddSpawnPoint("d_startower_89.Id6", "d_startower_89", Rectangle(1453, -1589, 200));
		AddSpawnPoint("d_startower_89.Id6", "d_startower_89", Rectangle(1323, -1009, 200));
		AddSpawnPoint("d_startower_89.Id6", "d_startower_89", Rectangle(717, -858, 200));
		AddSpawnPoint("d_startower_89.Id6", "d_startower_89", Rectangle(727, -95, 200));
		AddSpawnPoint("d_startower_89.Id6", "d_startower_89", Rectangle(776, 904, 200));
		AddSpawnPoint("d_startower_89.Id6", "d_startower_89", Rectangle(757, 1425, 200));
		AddSpawnPoint("d_startower_89.Id6", "d_startower_89", Rectangle(-25, 738, 200));
		AddSpawnPoint("d_startower_89.Id6", "d_startower_89", Rectangle(-294, 1163, 200));
		AddSpawnPoint("d_startower_89.Id6", "d_startower_89", Rectangle(-380, 1716, 200));
		AddSpawnPoint("d_startower_89.Id6", "d_startower_89", Rectangle(47, 1847, 200));
		AddSpawnPoint("d_startower_89.Id6", "d_startower_89", Rectangle(-756, 857, 200));
		AddSpawnPoint("d_startower_89.Id6", "d_startower_89", Rectangle(-1202, 576, 200));
		AddSpawnPoint("d_startower_89.Id6", "d_startower_89", Rectangle(-864, 42, 200));
		AddSpawnPoint("d_startower_89.Id6", "d_startower_89", Rectangle(-486, -359, 200));
		AddSpawnPoint("d_startower_89.Id6", "d_startower_89", Rectangle(407, -474, 200));
	}
}
