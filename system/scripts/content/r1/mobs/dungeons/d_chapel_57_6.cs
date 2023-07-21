//--- Melia Script -----------------------------------------------------------
// Tenet Church 1F Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_chapel_57_6'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DChapel576MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_chapel_57_6", MonsterId.Corylus, Properties("MHP", 22147, "MINPATK", 786, "MAXPATK", 868, "MINMATK", 786, "MAXMATK", 868, "DEF", 74, "MDEF", 74));
		AddPropertyOverrides("d_chapel_57_6", MonsterId.Pawndel, Properties("MHP", 22588, "MINPATK", 791, "MAXPATK", 875, "MINMATK", 791, "MAXMATK", 875, "DEF", 74, "MDEF", 74));
		AddPropertyOverrides("d_chapel_57_6", MonsterId.Pawnd, Properties("MHP", 23035, "MINPATK", 797, "MAXPATK", 882, "MINMATK", 797, "MAXMATK", 882, "DEF", 74, "MDEF", 74));
		AddPropertyOverrides("d_chapel_57_6", MonsterId.Galok, Properties("MHP", 23489, "MINPATK", 803, "MAXPATK", 889, "MINMATK", 803, "MAXMATK", 889, "DEF", 75, "MDEF", 75));
		AddPropertyOverrides("d_chapel_57_6", MonsterId.Boss_Mummyghast, Properties("MHP", 110649, "MINPATK", 1553, "MAXPATK", 1721, "MINMATK", 1553, "MAXMATK", 1721, "DEF", 144, "MDEF", 144));

		// Monster Spawners ---------------------------------

		AddSpawner("d_chapel_57_6.Id1", MonsterId.Corylus, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_chapel_57_6.Id2", MonsterId.Pawndel, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_chapel_57_6.Id3", MonsterId.Pawndel, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_chapel_57_6.Id4", MonsterId.Corylus, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_chapel_57_6.Id5", MonsterId.Pawnd, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_chapel_57_6.Id6", MonsterId.Pawnd, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_chapel_57_6.Id7", MonsterId.Rootcrystal_01, 15, 20, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("d_chapel_57_6.Id8", MonsterId.Galok, 3, 3, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_chapel_57_6.Id9", MonsterId.Pawndel, 5, 6, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Corylus' GenType 10 Spawn Points
		AddSpawnPoint("d_chapel_57_6.Id1", "d_chapel_57_6", Rectangle(161, -254, 30));
		AddSpawnPoint("d_chapel_57_6.Id1", "d_chapel_57_6", Rectangle(267, -74, 30));
		AddSpawnPoint("d_chapel_57_6.Id1", "d_chapel_57_6", Rectangle(371, 45, 30));
		AddSpawnPoint("d_chapel_57_6.Id1", "d_chapel_57_6", Rectangle(410, -245, 30));
		AddSpawnPoint("d_chapel_57_6.Id1", "d_chapel_57_6", Rectangle(118, 374, 30));
		AddSpawnPoint("d_chapel_57_6.Id1", "d_chapel_57_6", Rectangle(296, 482, 30));
		AddSpawnPoint("d_chapel_57_6.Id1", "d_chapel_57_6", Rectangle(607, 429, 30));
		AddSpawnPoint("d_chapel_57_6.Id1", "d_chapel_57_6", Rectangle(-412, 566, 30));
		AddSpawnPoint("d_chapel_57_6.Id1", "d_chapel_57_6", Rectangle(127, -106, 30));
		AddSpawnPoint("d_chapel_57_6.Id1", "d_chapel_57_6", Rectangle(125, 78, 30));
		AddSpawnPoint("d_chapel_57_6.Id1", "d_chapel_57_6", Rectangle(305, 279, 30));
		AddSpawnPoint("d_chapel_57_6.Id1", "d_chapel_57_6", Rectangle(-687, 430, 30));
		AddSpawnPoint("d_chapel_57_6.Id1", "d_chapel_57_6", Rectangle(-558, 270, 30));
		AddSpawnPoint("d_chapel_57_6.Id1", "d_chapel_57_6", Rectangle(-346, 393, 30));
		AddSpawnPoint("d_chapel_57_6.Id1", "d_chapel_57_6", Rectangle(-537, 589, 30));

		// 'Pawndel' GenType 13 Spawn Points
		AddSpawnPoint("d_chapel_57_6.Id2", "d_chapel_57_6", Rectangle(-581, 1194, 9999));

		// 'Pawndel' GenType 19 Spawn Points
		AddSpawnPoint("d_chapel_57_6.Id3", "d_chapel_57_6", Rectangle(-585, -286, 20));
		AddSpawnPoint("d_chapel_57_6.Id3", "d_chapel_57_6", Rectangle(-516, -975, 20));
		AddSpawnPoint("d_chapel_57_6.Id3", "d_chapel_57_6", Rectangle(-607, 582, 20));
		AddSpawnPoint("d_chapel_57_6.Id3", "d_chapel_57_6", Rectangle(-571, 1168, 20));
		AddSpawnPoint("d_chapel_57_6.Id3", "d_chapel_57_6", Rectangle(-381, 478, 20));
		AddSpawnPoint("d_chapel_57_6.Id3", "d_chapel_57_6", Rectangle(-522, 1955, 20));
		AddSpawnPoint("d_chapel_57_6.Id3", "d_chapel_57_6", Rectangle(223, 366, 20));
		AddSpawnPoint("d_chapel_57_6.Id3", "d_chapel_57_6", Rectangle(462, 496, 20));
		AddSpawnPoint("d_chapel_57_6.Id3", "d_chapel_57_6", Rectangle(-614, -455, 20));
		AddSpawnPoint("d_chapel_57_6.Id3", "d_chapel_57_6", Rectangle(-432, -409, 20));
		AddSpawnPoint("d_chapel_57_6.Id3", "d_chapel_57_6", Rectangle(160, 433, 20));
		AddSpawnPoint("d_chapel_57_6.Id3", "d_chapel_57_6", Rectangle(359, 577, 20));
		AddSpawnPoint("d_chapel_57_6.Id3", "d_chapel_57_6", Rectangle(-667, 292, 20));
		AddSpawnPoint("d_chapel_57_6.Id3", "d_chapel_57_6", Rectangle(-547, 192, 20));
		AddSpawnPoint("d_chapel_57_6.Id3", "d_chapel_57_6", Rectangle(-382, 309, 20));
		AddSpawnPoint("d_chapel_57_6.Id3", "d_chapel_57_6", Rectangle(-305, 186, 20));
		AddSpawnPoint("d_chapel_57_6.Id3", "d_chapel_57_6", Rectangle(-285, 629, 20));
		AddSpawnPoint("d_chapel_57_6.Id3", "d_chapel_57_6", Rectangle(-659, 706, 20));
		AddSpawnPoint("d_chapel_57_6.Id3", "d_chapel_57_6", Rectangle(-746, 405, 20));
		AddSpawnPoint("d_chapel_57_6.Id3", "d_chapel_57_6", Rectangle(-448, 648, 20));
		AddSpawnPoint("d_chapel_57_6.Id3", "d_chapel_57_6", Rectangle(-456, 1236, 20));
		AddSpawnPoint("d_chapel_57_6.Id3", "d_chapel_57_6", Rectangle(-579, 1384, 20));
		AddSpawnPoint("d_chapel_57_6.Id3", "d_chapel_57_6", Rectangle(-466, 1371, 20));
		AddSpawnPoint("d_chapel_57_6.Id3", "d_chapel_57_6", Rectangle(-637, 1228, 20));
		AddSpawnPoint("d_chapel_57_6.Id3", "d_chapel_57_6", Rectangle(-578, 1849, 20));
		AddSpawnPoint("d_chapel_57_6.Id3", "d_chapel_57_6", Rectangle(-403, 1872, 20));
		AddSpawnPoint("d_chapel_57_6.Id3", "d_chapel_57_6", Rectangle(-490, 2070, 20));
		AddSpawnPoint("d_chapel_57_6.Id3", "d_chapel_57_6", Rectangle(-676, 2061, 20));
		AddSpawnPoint("d_chapel_57_6.Id3", "d_chapel_57_6", Rectangle(-681, 1891, 20));
		AddSpawnPoint("d_chapel_57_6.Id3", "d_chapel_57_6", Rectangle(-365, 1996, 20));
		AddSpawnPoint("d_chapel_57_6.Id3", "d_chapel_57_6", Rectangle(-523, -1283, 20));
		AddSpawnPoint("d_chapel_57_6.Id3", "d_chapel_57_6", Rectangle(-375, -1274, 20));
		AddSpawnPoint("d_chapel_57_6.Id3", "d_chapel_57_6", Rectangle(-369, -999, 20));
		AddSpawnPoint("d_chapel_57_6.Id3", "d_chapel_57_6", Rectangle(-720, -1138, 20));
		AddSpawnPoint("d_chapel_57_6.Id3", "d_chapel_57_6", Rectangle(-325, -1160, 20));
		AddSpawnPoint("d_chapel_57_6.Id3", "d_chapel_57_6", Rectangle(-629, -882, 20));

		// 'Corylus' GenType 20 Spawn Points
		AddSpawnPoint("d_chapel_57_6.Id4", "d_chapel_57_6", Rectangle(-427, 514, 50));
		AddSpawnPoint("d_chapel_57_6.Id4", "d_chapel_57_6", Rectangle(-383, -1064, 50));
		AddSpawnPoint("d_chapel_57_6.Id4", "d_chapel_57_6", Rectangle(-548, 1285, 50));
		AddSpawnPoint("d_chapel_57_6.Id4", "d_chapel_57_6", Rectangle(-658, 609, 50));
		AddSpawnPoint("d_chapel_57_6.Id4", "d_chapel_57_6", Rectangle(-725, 329, 50));
		AddSpawnPoint("d_chapel_57_6.Id4", "d_chapel_57_6", Rectangle(-1108, 450, 50));
		AddSpawnPoint("d_chapel_57_6.Id4", "d_chapel_57_6", Rectangle(-654, -339, 50));
		AddSpawnPoint("d_chapel_57_6.Id4", "d_chapel_57_6", Rectangle(-659, -1073, 50));
		AddSpawnPoint("d_chapel_57_6.Id4", "d_chapel_57_6", Rectangle(-439, 1364, 50));
		AddSpawnPoint("d_chapel_57_6.Id4", "d_chapel_57_6", Rectangle(-559, 867, 50));

		// 'Pawnd' GenType 21 Spawn Points
		AddSpawnPoint("d_chapel_57_6.Id5", "d_chapel_57_6", Rectangle(-375, 636, 9999));

		// 'Pawnd' GenType 22 Spawn Points
		AddSpawnPoint("d_chapel_57_6.Id6", "d_chapel_57_6", Rectangle(-509, 1938, 30));
		AddSpawnPoint("d_chapel_57_6.Id6", "d_chapel_57_6", Rectangle(-513, 1657, 30));
		AddSpawnPoint("d_chapel_57_6.Id6", "d_chapel_57_6", Rectangle(-618, 1250, 30));
		AddSpawnPoint("d_chapel_57_6.Id6", "d_chapel_57_6", Rectangle(-475, 314, 30));
		AddSpawnPoint("d_chapel_57_6.Id6", "d_chapel_57_6", Rectangle(-420, 614, 30));
		AddSpawnPoint("d_chapel_57_6.Id6", "d_chapel_57_6", Rectangle(-718, 242, 30));
		AddSpawnPoint("d_chapel_57_6.Id6", "d_chapel_57_6", Rectangle(-532, -368, 30));
		AddSpawnPoint("d_chapel_57_6.Id6", "d_chapel_57_6", Rectangle(-573, -1163, 30));
		AddSpawnPoint("d_chapel_57_6.Id6", "d_chapel_57_6", Rectangle(-451, -989, 30));
		AddSpawnPoint("d_chapel_57_6.Id6", "d_chapel_57_6", Rectangle(276, 444, 30));
		AddSpawnPoint("d_chapel_57_6.Id6", "d_chapel_57_6", Rectangle(-740, 583, 30));
		AddSpawnPoint("d_chapel_57_6.Id6", "d_chapel_57_6", Rectangle(-427, 1285, 30));
		AddSpawnPoint("d_chapel_57_6.Id6", "d_chapel_57_6", Rectangle(-654, 441, 30));
		AddSpawnPoint("d_chapel_57_6.Id6", "d_chapel_57_6", Rectangle(-278, 479, 30));
		AddSpawnPoint("d_chapel_57_6.Id6", "d_chapel_57_6", Rectangle(216, 303, 30));
		AddSpawnPoint("d_chapel_57_6.Id6", "d_chapel_57_6", Rectangle(273, 570, 30));
		AddSpawnPoint("d_chapel_57_6.Id6", "d_chapel_57_6", Rectangle(-633, -320, 30));
		AddSpawnPoint("d_chapel_57_6.Id6", "d_chapel_57_6", Rectangle(-596, -505, 30));
		AddSpawnPoint("d_chapel_57_6.Id6", "d_chapel_57_6", Rectangle(-613, -1004, 30));
		AddSpawnPoint("d_chapel_57_6.Id6", "d_chapel_57_6", Rectangle(-651, -1255, 30));
		AddSpawnPoint("d_chapel_57_6.Id6", "d_chapel_57_6", Rectangle(-308, -1209, 30));
		AddSpawnPoint("d_chapel_57_6.Id6", "d_chapel_57_6", Rectangle(-306, -972, 30));
		AddSpawnPoint("d_chapel_57_6.Id6", "d_chapel_57_6", Rectangle(-381, 1997, 30));
		AddSpawnPoint("d_chapel_57_6.Id6", "d_chapel_57_6", Rectangle(-654, 1932, 30));
		AddSpawnPoint("d_chapel_57_6.Id6", "d_chapel_57_6", Rectangle(-533, 1329, 30));
		AddSpawnPoint("d_chapel_57_6.Id6", "d_chapel_57_6", Rectangle(-532, 1102, 30));
		AddSpawnPoint("d_chapel_57_6.Id6", "d_chapel_57_6", Rectangle(-531, 653, 30));

		// 'Rootcrystal_01' GenType 24 Spawn Points
		AddSpawnPoint("d_chapel_57_6.Id7", "d_chapel_57_6", Rectangle(850, -174, 200));
		AddSpawnPoint("d_chapel_57_6.Id7", "d_chapel_57_6", Rectangle(288, -194, 200));
		AddSpawnPoint("d_chapel_57_6.Id7", "d_chapel_57_6", Rectangle(320, -39, 200));
		AddSpawnPoint("d_chapel_57_6.Id7", "d_chapel_57_6", Rectangle(286, 465, 200));
		AddSpawnPoint("d_chapel_57_6.Id7", "d_chapel_57_6", Rectangle(1317, 445, 200));
		AddSpawnPoint("d_chapel_57_6.Id7", "d_chapel_57_6", Rectangle(967, 421, 200));
		AddSpawnPoint("d_chapel_57_6.Id7", "d_chapel_57_6", Rectangle(-671, 570, 200));
		AddSpawnPoint("d_chapel_57_6.Id7", "d_chapel_57_6", Rectangle(-366, 278, 200));
		AddSpawnPoint("d_chapel_57_6.Id7", "d_chapel_57_6", Rectangle(-624, 1834, 200));
		AddSpawnPoint("d_chapel_57_6.Id7", "d_chapel_57_6", Rectangle(-525, 1623, 200));
		AddSpawnPoint("d_chapel_57_6.Id7", "d_chapel_57_6", Rectangle(-561, 1287, 200));
		AddSpawnPoint("d_chapel_57_6.Id7", "d_chapel_57_6", Rectangle(-1187, 457, 200));
		AddSpawnPoint("d_chapel_57_6.Id7", "d_chapel_57_6", Rectangle(-1407, 545, 200));
		AddSpawnPoint("d_chapel_57_6.Id7", "d_chapel_57_6", Rectangle(-546, -71, 200));
		AddSpawnPoint("d_chapel_57_6.Id7", "d_chapel_57_6", Rectangle(-533, -397, 200));
		AddSpawnPoint("d_chapel_57_6.Id7", "d_chapel_57_6", Rectangle(-540, -851, 200));
		AddSpawnPoint("d_chapel_57_6.Id7", "d_chapel_57_6", Rectangle(-528, -1256, 200));

		// 'Galok' GenType 27 Spawn Points
		AddSpawnPoint("d_chapel_57_6.Id8", "d_chapel_57_6", Rectangle(55, 423, 9999));

		// 'Pawndel' GenType 28 Spawn Points
		AddSpawnPoint("d_chapel_57_6.Id9", "d_chapel_57_6", Rectangle(-429, 1879, 20));
		AddSpawnPoint("d_chapel_57_6.Id9", "d_chapel_57_6", Rectangle(-623, 1357, 20));
		AddSpawnPoint("d_chapel_57_6.Id9", "d_chapel_57_6", Rectangle(-554, 2143, 20));
		AddSpawnPoint("d_chapel_57_6.Id9", "d_chapel_57_6", Rectangle(-573, 2052, 20));
		AddSpawnPoint("d_chapel_57_6.Id9", "d_chapel_57_6", Rectangle(-667, 1286, 20));
		AddSpawnPoint("d_chapel_57_6.Id9", "d_chapel_57_6", Rectangle(-365, 1989, 20));
		AddSpawnPoint("d_chapel_57_6.Id9", "d_chapel_57_6", Rectangle(-473, 1790, 20));
		AddSpawnPoint("d_chapel_57_6.Id9", "d_chapel_57_6", Rectangle(-693, 1896, 20));
		AddSpawnPoint("d_chapel_57_6.Id9", "d_chapel_57_6", Rectangle(-472, 1324, 20));
	}
}
