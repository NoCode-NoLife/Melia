//--- Melia Script -----------------------------------------------------------
// Svalphinghas Forest Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_maple_25_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FMaple252MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_maple_25_2", MonsterId.Elder_Rode, Properties("MHP", 532069, "MINPATK", 7343, "MAXPATK", 8926, "MINMATK", 7343, "MAXMATK", 8926, "DEF", 93796, "MDEF", 93796));
		AddPropertyOverrides("f_maple_25_2", MonsterId.Roderiot, Properties("MHP", 532069, "MINPATK", 7343, "MAXPATK", 8926, "MINMATK", 7343, "MAXMATK", 8926, "DEF", 93796, "MDEF", 93796));
		AddPropertyOverrides("f_maple_25_2", MonsterId.Rodedoe, Properties("MHP", 534014, "MINPATK", 7368, "MAXPATK", 8957, "MINMATK", 7368, "MAXMATK", 8957, "DEF", 94757, "MDEF", 94757));

		// Monster Spawners ---------------------------------

		AddSpawner("f_maple_25_2.Id1", MonsterId.Elder_Rode, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_25_2.Id2", MonsterId.Roderiot, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_25_2.Id3", MonsterId.Rodedoe, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_25_2.Id4", MonsterId.Elder_Rode, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_25_2.Id5", MonsterId.Roderiot, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_25_2.Id6", MonsterId.Rootcrystal_05, 27, 35, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Elder_Rode' GenType 17 Spawn Points
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-525, 433, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-359, 278, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-445, 117, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-674, 241, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-507, 192, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-705, 88, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-612, 4, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-187, 301, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-285, 465, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-501, 311, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-583, 105, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-812, 19, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-598, 347, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-273, 183, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-1303, -469, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-1417, -259, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-1213, -336, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-1208, -253, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-1106, -289, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-1096, -145, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-987, -54, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-1402, -144, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-1305, -123, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-1145, 534, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-893, 523, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-1001, 572, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-945, 764, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-882, 901, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-900, 676, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-1065, 649, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-775, 788, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-638, 1084, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-485, 1202, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-474, 1069, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-380, 1129, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-427, 1203, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-316, 1265, 40));
		AddSpawnPoint("f_maple_25_2.Id1", "f_maple_25_2", Rectangle(-888, 800, 40));

		// 'Roderiot' GenType 18 Spawn Points
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-855, -744, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-875, -609, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-733, -603, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-750, -701, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-558, -596, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-874, -496, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-699, -461, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-471, -486, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-462, -589, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-491, -675, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-626, -704, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-394, -530, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-964, -672, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-1062, -640, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-1594, -742, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-1532, -693, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-1531, -576, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-1437, -646, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-1316, -620, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-1272, -652, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-1125, -656, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-728, -817, 40));
		AddSpawnPoint("f_maple_25_2.Id2", "f_maple_25_2", Rectangle(-555, -509, 40));

		// 'Rodedoe' GenType 19 Spawn Points
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1410, -752, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1544, -611, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1553, -715, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1736, -651, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1303, -553, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1215, -415, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(890, -130, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1019, -103, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1043, 70, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1225, -23, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1413, -124, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1458, -221, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1701, -229, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1659, -269, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1714, -293, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1690, -494, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1307, -697, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1068, -248, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1111, -374, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1112, 205, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(637, 378, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(379, 497, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(462, 627, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(661, 470, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(719, 631, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(789, 466, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(843, 338, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(859, 466, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1217, 469, 40));
		AddSpawnPoint("f_maple_25_2.Id3", "f_maple_25_2", Rectangle(1238, 326, 40));

		// 'Elder_Rode' GenType 20 Spawn Points
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(352, -1095, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(359, -942, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(465, -773, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(504, -1006, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(480, -1123, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(827, -816, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(562, -921, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(1102, -987, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(1153, -1093, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(1026, -1115, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(1220, -1360, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(1090, -848, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(1269, -1243, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(1350, -1115, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(1356, -966, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(1229, -987, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(1487, -1270, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(521, -299, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(373, -149, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(566, -139, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(511, -214, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(630, -236, 40));
		AddSpawnPoint("f_maple_25_2.Id4", "f_maple_25_2", Rectangle(492, -431, 40));

		// 'Roderiot' GenType 21 Spawn Points
		AddSpawnPoint("f_maple_25_2.Id5", "f_maple_25_2", Rectangle(-380, 183, 9999));

		// 'Rootcrystal_05' GenType 33 Spawn Points
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(1650, -233, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(1316, -72, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(1121, 120, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(1133, -314, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(1430, -635, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(1677, -646, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(1265, 502, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(1288, 872, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(773, 373, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(481, 459, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(173, 601, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(1419, -1286, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(1238, -1087, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(1013, -924, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(650, -908, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(419, -1067, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(259, -798, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(-309, -476, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(-511, -624, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(-792, -617, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(-1334, -655, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(-1700, -672, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(-1589, -401, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(-1322, -351, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(-1167, -198, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(-844, 51, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(-621, 123, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(-393, 350, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(-962, 438, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(-1007, 698, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(-799, 853, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(-519, 1126, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(-296, 1201, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(429, -141, 15));
		AddSpawnPoint("f_maple_25_2.Id6", "f_maple_25_2", Rectangle(561, -435, 15));
	}
}
