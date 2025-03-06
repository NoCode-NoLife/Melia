//--- Melia Script -----------------------------------------------------------
// EP17 Tevhrin Stalactite Cave Section 2 Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'ep17_1_d_limestonecave_52_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Game.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class Ep171DLimestonecave522MobScript : GeneralScript
{
	protected override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("ep17_1_d_limestonecave_52_2", MonsterId.Ep17_1_Tala_Combat, Properties("MHP", 104493856, "MINPATK", 290000, "MAXPATK", 290000, "MINMATK", 290000, "MAXMATK", 290000, "DEF", 13190000, "MDEF", 13190000));
		AddPropertyOverrides("ep17_1_d_limestonecave_52_2", MonsterId.Ep17_1_Flamme_Priest_Green, Properties("MHP", 104493856, "MINPATK", 290000, "MAXPATK", 290000, "MINMATK", 290000, "MAXMATK", 290000, "DEF", 13190000, "MDEF", 13190000));
		AddPropertyOverrides("ep17_1_d_limestonecave_52_2", MonsterId.Ep17_1_Warleader_Tala, Properties("MHP", 104493856, "MINPATK", 290000, "MAXPATK", 290000, "MINMATK", 290000, "MAXMATK", 290000, "DEF", 13190000, "MDEF", 13190000));
		AddPropertyOverrides("ep17_1_d_limestonecave_52_2", MonsterId.Ep17_1_Redania_Scout, Properties("MHP", 104493856, "MINPATK", 290000, "MAXPATK", 290000, "MINMATK", 290000, "MAXMATK", 290000, "DEF", 13190000, "MDEF", 13190000));

		// Monster Spawners ---------------------------------

		AddSpawner("ep17_1_d_limestonecave_52_2.Id1", MonsterId.Ep17_1_Tala_Combat, min: 23, max: 30, tendency: TendencyType.Aggressive);
		AddSpawner("ep17_1_d_limestonecave_52_2.Id2", MonsterId.Ep17_1_Flamme_Priest_Green, min: 12, max: 15, tendency: TendencyType.Aggressive);
		AddSpawner("ep17_1_d_limestonecave_52_2.Id3", MonsterId.Ep17_1_Warleader_Tala, min: 6, max: 8, tendency: TendencyType.Aggressive);
		AddSpawner("ep17_1_d_limestonecave_52_2.Id4", MonsterId.Ep17_1_Redania_Scout, min: 12, max: 15, tendency: TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Ep17_1_Tala_Combat' GenType 20 Spawn Points
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-1200, -1655, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-1300, -1590, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-1159, -1574, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-1256, -1462, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-1321, -1701, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-937, -1091, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-779, -1213, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-670, -1151, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-902, -962, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-752, -1005, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-683, -925, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-1026, -1004, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-1300, -514, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-1524, -295, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-1115, -375, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-1301, -208, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-1411, -327, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-1701, 28, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-1651, 186, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-1627, 323, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-2086, 245, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-1839, 522, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-1158, 355, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-957, 95, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-842, 364, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-1075, 484, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-1007, 183, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-868, 515, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-971, 585, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-424, -8, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-515, 100, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-446, 216, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-308, -6, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-202, 145, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-340, 285, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-431, 433, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(45, 587, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(94, 689, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(68, 779, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-114, 816, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-178, 584, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-222, 672, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-100, 748, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-532, 1365, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-377, 1229, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-580, 1120, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-515, 1458, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-447, 1489, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-253, 1329, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(-483, 1097, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(329, 1319, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(551, 1326, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(565, 1191, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(415, 1116, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(435, 1445, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(343, 1511, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(144, 1216, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(551, 1624, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(142, 1380, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(32, 1269, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(659, 651, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(794, 574, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(786, 474, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(739, 391, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(592, 586, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(715, 549, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(709, -41, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(790, -125, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(907, -199, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(979, -147, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(998, -58, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(945, 56, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(807, 105, 40));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id1", "ep17_1_d_limestonecave_52_2", Rectangle(902, 116, 40));

		// 'Ep17_1_Flamme_Priest_Green' GenType 21 Spawn Points
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id2", "ep17_1_d_limestonecave_52_2", Rectangle(-1087, 351, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id2", "ep17_1_d_limestonecave_52_2", Rectangle(-917, 533, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id2", "ep17_1_d_limestonecave_52_2", Rectangle(-951, 170, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id2", "ep17_1_d_limestonecave_52_2", Rectangle(-456, -14, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id2", "ep17_1_d_limestonecave_52_2", Rectangle(-385, 184, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id2", "ep17_1_d_limestonecave_52_2", Rectangle(-282, 59, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id2", "ep17_1_d_limestonecave_52_2", Rectangle(616, 458, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id2", "ep17_1_d_limestonecave_52_2", Rectangle(706, 717, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id2", "ep17_1_d_limestonecave_52_2", Rectangle(715, 569, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id2", "ep17_1_d_limestonecave_52_2", Rectangle(739, 413, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id2", "ep17_1_d_limestonecave_52_2", Rectangle(637, 342, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id2", "ep17_1_d_limestonecave_52_2", Rectangle(861, 447, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id2", "ep17_1_d_limestonecave_52_2", Rectangle(590, 593, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id2", "ep17_1_d_limestonecave_52_2", Rectangle(775, -207, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id2", "ep17_1_d_limestonecave_52_2", Rectangle(912, -74, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id2", "ep17_1_d_limestonecave_52_2", Rectangle(1043, 29, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id2", "ep17_1_d_limestonecave_52_2", Rectangle(721, 33, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id2", "ep17_1_d_limestonecave_52_2", Rectangle(493, 1277, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id2", "ep17_1_d_limestonecave_52_2", Rectangle(402, 1236, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id2", "ep17_1_d_limestonecave_52_2", Rectangle(643, 1354, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id2", "ep17_1_d_limestonecave_52_2", Rectangle(-110, 633, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id2", "ep17_1_d_limestonecave_52_2", Rectangle(67, 720, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id2", "ep17_1_d_limestonecave_52_2", Rectangle(-1077, 478, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id2", "ep17_1_d_limestonecave_52_2", Rectangle(-931, 328, 30));

		// 'Ep17_1_Warleader_Tala' GenType 22 Spawn Points
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id3", "ep17_1_d_limestonecave_52_2", Rectangle(-958, 303, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id3", "ep17_1_d_limestonecave_52_2", Rectangle(-27, 640, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id3", "ep17_1_d_limestonecave_52_2", Rectangle(-463, 1280, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id3", "ep17_1_d_limestonecave_52_2", Rectangle(-352, 1150, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id3", "ep17_1_d_limestonecave_52_2", Rectangle(-292, 1384, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id3", "ep17_1_d_limestonecave_52_2", Rectangle(293, 1216, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id3", "ep17_1_d_limestonecave_52_2", Rectangle(344, 1393, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id3", "ep17_1_d_limestonecave_52_2", Rectangle(712, 520, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id3", "ep17_1_d_limestonecave_52_2", Rectangle(857, -117, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id3", "ep17_1_d_limestonecave_52_2", Rectangle(914, 83, 30));

		// 'Ep17_1_Redania_Scout' GenType 23 Spawn Points
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id4", "ep17_1_d_limestonecave_52_2", Rectangle(-1267, -1649, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id4", "ep17_1_d_limestonecave_52_2", Rectangle(-1408, -1387, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id4", "ep17_1_d_limestonecave_52_2", Rectangle(-685, -1261, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id4", "ep17_1_d_limestonecave_52_2", Rectangle(-700, -864, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id4", "ep17_1_d_limestonecave_52_2", Rectangle(-1047, -869, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id4", "ep17_1_d_limestonecave_52_2", Rectangle(-1367, -528, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id4", "ep17_1_d_limestonecave_52_2", Rectangle(-1547, -186, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id4", "ep17_1_d_limestonecave_52_2", Rectangle(-1856, 302, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id4", "ep17_1_d_limestonecave_52_2", Rectangle(-1599, 231, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id4", "ep17_1_d_limestonecave_52_2", Rectangle(-1185, 270, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id4", "ep17_1_d_limestonecave_52_2", Rectangle(-905, 222, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id4", "ep17_1_d_limestonecave_52_2", Rectangle(-906, 481, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id4", "ep17_1_d_limestonecave_52_2", Rectangle(-536, 146, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id4", "ep17_1_d_limestonecave_52_2", Rectangle(-335, -28, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id4", "ep17_1_d_limestonecave_52_2", Rectangle(-239, 216, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id4", "ep17_1_d_limestonecave_52_2", Rectangle(-118, 574, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id4", "ep17_1_d_limestonecave_52_2", Rectangle(-34, 835, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id4", "ep17_1_d_limestonecave_52_2", Rectangle(118, 610, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id4", "ep17_1_d_limestonecave_52_2", Rectangle(200, 1176, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id4", "ep17_1_d_limestonecave_52_2", Rectangle(75, 1307, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id4", "ep17_1_d_limestonecave_52_2", Rectangle(315, 1284, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id4", "ep17_1_d_limestonecave_52_2", Rectangle(485, 1213, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id4", "ep17_1_d_limestonecave_52_2", Rectangle(570, 1431, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id4", "ep17_1_d_limestonecave_52_2", Rectangle(734, 648, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id4", "ep17_1_d_limestonecave_52_2", Rectangle(740, 309, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id4", "ep17_1_d_limestonecave_52_2", Rectangle(984, -18, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_2.Id4", "ep17_1_d_limestonecave_52_2", Rectangle(831, -209, 30));
	}
}
