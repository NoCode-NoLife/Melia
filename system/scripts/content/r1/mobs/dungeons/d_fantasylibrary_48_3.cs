//--- Melia Script -----------------------------------------------------------
// Valandis Room 2 Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_fantasylibrary_48_3'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DFantasylibrary483MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_fantasylibrary_48_3", MonsterId.Crobasia, Properties("MHP", 543149, "MINPATK", 7485, "MAXPATK", 9101, "MINMATK", 7485, "MAXMATK", 9101, "DEF", 99275, "MDEF", 99275));
		AddPropertyOverrides("d_fantasylibrary_48_3", MonsterId.Rotacion, Properties("MHP", 545736, "MINPATK", 7519, "MAXPATK", 9142, "MINMATK", 7519, "MAXMATK", 9142, "DEF", 100554, "MDEF", 100554));
		AddPropertyOverrides("d_fantasylibrary_48_3", MonsterId.Boogie_Box, Properties("MHP", 548433, "MINPATK", 7553, "MAXPATK", 9185, "MINMATK", 7553, "MAXMATK", 9185, "DEF", 101887, "MDEF", 101887));
		AddPropertyOverrides("d_fantasylibrary_48_3", MonsterId.Gear, Properties("MHP", 551235, "MINPATK", 7589, "MAXPATK", 9229, "MINMATK", 7589, "MAXMATK", 9229, "DEF", 103273, "MDEF", 103273));
		AddPropertyOverrides("d_fantasylibrary_48_3", MonsterId.Boss_Templeshooter_Q2, Properties("MHP", 2826114, "MINPATK", 18304, "MAXPATK", 22260, "MINMATK", 18304, "MAXMATK", 22260, "DEF", 251303, "MDEF", 251303));

		// Monster Spawners ---------------------------------

		AddSpawner("d_fantasylibrary_48_3.Id1", MonsterId.Rootcrystal_03, 12, 15, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_fantasylibrary_48_3.Id2", MonsterId.Crobasia, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_fantasylibrary_48_3.Id3", MonsterId.Rotacion, 34, 45, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_fantasylibrary_48_3.Id4", MonsterId.Boogie_Box, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_fantasylibrary_48_3.Id5", MonsterId.Gear, 45, 60, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_03' GenType 8 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(-674, -626, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(-586, -440, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(-529, -587, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(-200, -432, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(-80, -510, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(89, -414, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(13, -288, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(-180, -213, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(-93, -84, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(-239, -38, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(-217, 110, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(-92, 52, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(-118, 202, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(7, 183, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(50, 21, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(529, 237, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(731, 22, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(692, 164, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(596, 98, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(580, -603, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(561, -339, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(698, -456, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(833, -266, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(288, -498, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(1327, -347, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(1186, -334, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(1004, -465, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(-68, 430, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(-58, 728, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(-79, 1104, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(-190, 1243, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(-62, 1357, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(45, 1224, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(565, 1255, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(679, 1303, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(926, 1312, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(860, 1175, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(707, 1118, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(601, 945, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(838, 978, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(-77, 1599, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(-130, 1852, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(-151, 1989, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(-22, 2067, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(134, 1964, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(43, 1793, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(-494, 2030, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(-932, 1908, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(-1080, 2028, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(-1110, 2205, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(-906, 2366, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(-671, 2170, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(-717, 2036, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(-756, 1936, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(-1218, 1948, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(-1536, 1918, 100));
		AddSpawnPoint("d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Rectangle(-1368, 1750, 100));

		// 'Crobasia' GenType 23 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(-642, -560, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(-546, -581, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(-623, -429, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(-473, -604, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(-234, -437, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(-144, -428, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(-51, -485, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(29, -409, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(6, -288, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(-129, -240, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(-217, -164, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(-25, -145, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(-164, 7, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(-82, 33, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(-116, 123, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(2, 188, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(-50, 261, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(112, 57, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(530, -349, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(516, -483, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(523, -601, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(651, -491, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(595, -413, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(699, -330, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(586, -244, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(724, -480, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(790, -621, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(884, -474, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(1257, -415, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(1401, -297, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(528, 166, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(516, 284, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(617, 303, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(751, 325, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(868, 206, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(-180, 1127, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(-190, 1319, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(84, 1175, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(-160, 238, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Rectangle(-68, 1016, 40));

		// 'Rotacion' GenType 24 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(-1579, 1950, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(-1561, 2009, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(-1474, 1873, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(-1315, 1911, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(-1383, 1996, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(-1065, 2091, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(-950, 2033, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(-1006, 2188, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(-867, 2140, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(-879, 2046, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(-931, 2224, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(-891, 2340, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(-696, 2247, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(-755, 2010, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(-778, 2177, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(-74, 1808, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(14, 1842, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(-94, 1869, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(-96, 1957, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(59, 1913, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(-35, 2004, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(-94, 1257, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(-130, 1187, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(-31, 1181, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(-38, 1343, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(532, 1170, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(580, 1330, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(676, 1241, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(585, 1015, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(666, 958, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(800, 1050, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(737, 1130, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(672, 1169, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(761, 1212, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(876, 1201, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(892, 1077, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(1171, -309, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(1209, -259, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(1259, -350, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(1215, -457, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(1385, -366, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(1341, -265, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(666, 106, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(663, 205, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Rectangle(735, 137, 40));

		// 'Boogie_Box' GenType 25 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(-763, -524, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(-705, -487, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(-719, -426, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(-587, -652, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(-474, -504, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(-525, -404, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(-267, -572, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(218, -283, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(285, -289, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(212, -372, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(237, -462, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(349, -448, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(331, -550, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(450, -515, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(960, -457, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(1093, -446, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(-275, 127, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(-203, 187, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(166, 258, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(237, 288, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(312, 253, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(379, 284, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(-80, 325, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(-36, 497, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(-78, 597, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(-33, 787, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(-66, 942, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(293, 1238, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(376, 1197, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(-88, 1494, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(-336, 1997, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(-325, 2041, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(-553, 2040, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(-470, 2067, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(-564, 2098, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(-1164, 1895, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(-1214, 2027, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(-1307, 1971, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(-1391, 1873, 20));
		AddSpawnPoint("d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Rectangle(-1497, 1760, 20));

		// 'Gear' GenType 26 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(-672, -651, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(-571, -507, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(-520, -662, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(-203, -353, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(-125, -549, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(101, -319, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(-175, -102, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(84, 116, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(-89, 189, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(518, -401, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(603, -557, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(705, -584, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(729, -401, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(621, -333, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(815, -300, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(852, -547, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(1169, -395, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(1344, -417, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(1280, -249, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(749, 45, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(636, 32, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(592, 207, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(709, 267, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(799, 230, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(836, 105, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(555, 1082, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(546, 935, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(534, 1289, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(761, 944, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(888, 976, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(835, 1143, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(828, 1315, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(952, 1293, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(583, 1209, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(27, 1099, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(-76, 1092, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(-198, 1210, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(-120, 1344, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(23, 1255, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(-160, 1812, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(-171, 1954, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(-140, 2041, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(33, 2010, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(124, 1964, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(89, 1766, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(-974, 1950, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(-842, 1907, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(-716, 2092, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(-799, 2265, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(-991, 2291, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(-1088, 2216, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(-941, 2105, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(-1445, 1964, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(-1573, 1840, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(-1426, 69, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(-1335, 158, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(-1465, 203, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(-1354, 299, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(-1474, 338, 40));
		AddSpawnPoint("d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Rectangle(-1299, 395, 40));
	}
}
