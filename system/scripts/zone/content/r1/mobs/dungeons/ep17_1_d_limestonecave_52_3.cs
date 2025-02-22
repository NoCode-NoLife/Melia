//--- Melia Script -----------------------------------------------------------
// EP17 Tevhrin Stalactite Cave Section 3 Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'ep17_1_d_limestonecave_52_3'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Game.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class Ep171DLimestonecave523MobScript : GeneralScript
{
	protected override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("ep17_1_d_limestonecave_52_3", MonsterId.Ep17_1_Flamme_Priest_Green, Properties("MHP", 114493856, "MINPATK", 300000, "MAXPATK", 300000, "MINMATK", 300000, "MAXMATK", 300000, "DEF", 14190000, "MDEF", 14190000));
		AddPropertyOverrides("ep17_1_d_limestonecave_52_3", MonsterId.Ep17_1_Flamme_Mage_Green, Properties("MHP", 114493856, "MINPATK", 300000, "MAXPATK", 300000, "MINMATK", 300000, "MAXMATK", 300000, "DEF", 14190000, "MDEF", 14190000));
		AddPropertyOverrides("ep17_1_d_limestonecave_52_3", MonsterId.Ep17_1_Bavon_Green, Properties("MHP", 114493856, "MINPATK", 300000, "MAXPATK", 300000, "MINMATK", 300000, "MAXMATK", 300000, "DEF", 14190000, "MDEF", 14190000));
		AddPropertyOverrides("ep17_1_d_limestonecave_52_3", MonsterId.Ep17_1_Rubblem_Green, Properties("MHP", 114493856, "MINPATK", 300000, "MAXPATK", 300000, "MINMATK", 300000, "MAXMATK", 300000, "DEF", 14190000, "MDEF", 14190000));
		AddPropertyOverrides("ep17_1_d_limestonecave_52_3", MonsterId.Ep17_1_Rocktanon, Properties("MHP", 114493856, "MINPATK", 300000, "MAXPATK", 300000, "MINMATK", 300000, "MAXMATK", 300000, "DEF", 14190000, "MDEF", 14190000));
		AddPropertyOverrides("ep17_1_d_limestonecave_52_3", MonsterId.Ep17_1_Boss_Stalakan, Properties("MHP", 457326048, "MINPATK", 310000, "MAXPATK", 310000, "MINMATK", 310000, "MAXMATK", 310000, "DEF", 15190000, "MDEF", 15190000));
		AddPropertyOverrides("ep17_1_d_limestonecave_52_3", MonsterId.Ep17_1_Redania_Scout, Properties("MHP", 124493856, "MINPATK", 300000, "MAXPATK", 300000, "MINMATK", 300000, "MAXMATK", 300000, "DEF", 14190000, "MDEF", 14190000));

		// Monster Spawners ---------------------------------

		AddSpawner("ep17_1_d_limestonecave_52_3.Id1", MonsterId.Ep17_1_Flamme_Priest_Green, min: 12, max: 15, tendency: TendencyType.Aggressive);
		AddSpawner("ep17_1_d_limestonecave_52_3.Id2", MonsterId.Ep17_1_Flamme_Mage_Green, min: 15, max: 20, tendency: TendencyType.Aggressive);
		AddSpawner("ep17_1_d_limestonecave_52_3.Id3", MonsterId.Ep17_1_Bavon_Green, min: 23, max: 30, tendency: TendencyType.Aggressive);
		AddSpawner("ep17_1_d_limestonecave_52_3.Id4", MonsterId.Ep17_1_Rubblem_Green, min: 15, max: 20, tendency: TendencyType.Aggressive);
		AddSpawner("ep17_1_d_limestonecave_52_3.Id5", MonsterId.Ep17_1_Bavon_Green, min: 12, max: 15, tendency: TendencyType.Aggressive);
		AddSpawner("ep17_1_d_limestonecave_52_3.Id6", MonsterId.Ep17_1_Flamme_Priest_Green, min: 15, max: 20, tendency: TendencyType.Aggressive);
		AddSpawner("ep17_1_d_limestonecave_52_3.Id7", MonsterId.Ep17_1_Redania_Scout, min: 12, max: 15, tendency: TendencyType.Aggressive);
		AddSpawner("ep17_1_d_limestonecave_52_3.Id8", MonsterId.Ep17_1_Rocktanon, min: 23, max: 30, tendency: TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Ep17_1_Flamme_Priest_Green' GenType 20 Spawn Points
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id1", "ep17_1_d_limestonecave_52_3", Rectangle(-1822, -276, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id1", "ep17_1_d_limestonecave_52_3", Rectangle(-1850, 432, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id1", "ep17_1_d_limestonecave_52_3", Rectangle(-1960, -184, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id1", "ep17_1_d_limestonecave_52_3", Rectangle(-1878, -31, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id1", "ep17_1_d_limestonecave_52_3", Rectangle(-2102, 486, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id1", "ep17_1_d_limestonecave_52_3", Rectangle(-1972, 569, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id1", "ep17_1_d_limestonecave_52_3", Rectangle(-1882, 659, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id1", "ep17_1_d_limestonecave_52_3", Rectangle(-1843, 538, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id1", "ep17_1_d_limestonecave_52_3", Rectangle(-1953, -314, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id1", "ep17_1_d_limestonecave_52_3", Rectangle(-1960, -685, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id1", "ep17_1_d_limestonecave_52_3", Rectangle(-2116, -940, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id1", "ep17_1_d_limestonecave_52_3", Rectangle(-2004, -1031, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id1", "ep17_1_d_limestonecave_52_3", Rectangle(-1862, -913, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id1", "ep17_1_d_limestonecave_52_3", Rectangle(-1837, -773, 30));

		// 'Ep17_1_Flamme_Mage_Green' GenType 21 Spawn Points
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id2", "ep17_1_d_limestonecave_52_3", Rectangle(-1207, -101, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id2", "ep17_1_d_limestonecave_52_3", Rectangle(-1939, -144, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id2", "ep17_1_d_limestonecave_52_3", Rectangle(-1982, 586, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id2", "ep17_1_d_limestonecave_52_3", Rectangle(-1220, 48, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id2", "ep17_1_d_limestonecave_52_3", Rectangle(-1029, 12, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id2", "ep17_1_d_limestonecave_52_3", Rectangle(-1157, -359, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id2", "ep17_1_d_limestonecave_52_3", Rectangle(-748, 187, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id2", "ep17_1_d_limestonecave_52_3", Rectangle(-272, -417, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id2", "ep17_1_d_limestonecave_52_3", Rectangle(-389, -501, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id2", "ep17_1_d_limestonecave_52_3", Rectangle(1141, -528, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id2", "ep17_1_d_limestonecave_52_3", Rectangle(-4, -1438, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id2", "ep17_1_d_limestonecave_52_3", Rectangle(85, -1374, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id2", "ep17_1_d_limestonecave_52_3", Rectangle(337, -562, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id2", "ep17_1_d_limestonecave_52_3", Rectangle(1229, 3, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id2", "ep17_1_d_limestonecave_52_3", Rectangle(1105, 263, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id2", "ep17_1_d_limestonecave_52_3", Rectangle(1294, 551, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id2", "ep17_1_d_limestonecave_52_3", Rectangle(97, 386, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id2", "ep17_1_d_limestonecave_52_3", Rectangle(188, 545, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id2", "ep17_1_d_limestonecave_52_3", Rectangle(-454, 190, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id2", "ep17_1_d_limestonecave_52_3", Rectangle(-508, 431, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id2", "ep17_1_d_limestonecave_52_3", Rectangle(-279, 377, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id2", "ep17_1_d_limestonecave_52_3", Rectangle(-408, 285, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id2", "ep17_1_d_limestonecave_52_3", Rectangle(-2045, -172, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id2", "ep17_1_d_limestonecave_52_3", Rectangle(-1932, 413, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id2", "ep17_1_d_limestonecave_52_3", Rectangle(-481, -358, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id2", "ep17_1_d_limestonecave_52_3", Rectangle(253, -702, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id2", "ep17_1_d_limestonecave_52_3", Rectangle(1259, -315, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id2", "ep17_1_d_limestonecave_52_3", Rectangle(-1060, -196, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id2", "ep17_1_d_limestonecave_52_3", Rectangle(-1126, 238, 30));

		// 'Ep17_1_Bavon_Green' GenType 22 Spawn Points
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id3", "ep17_1_d_limestonecave_52_3", Rectangle(-682, -666, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id3", "ep17_1_d_limestonecave_52_3", Rectangle(-7, -1454, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id3", "ep17_1_d_limestonecave_52_3", Rectangle(15, -1321, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id3", "ep17_1_d_limestonecave_52_3", Rectangle(12, -1437, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id3", "ep17_1_d_limestonecave_52_3", Rectangle(246, -1467, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id3", "ep17_1_d_limestonecave_52_3", Rectangle(286, -1490, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id3", "ep17_1_d_limestonecave_52_3", Rectangle(535, -1322, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id3", "ep17_1_d_limestonecave_52_3", Rectangle(0, -1220, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id3", "ep17_1_d_limestonecave_52_3", Rectangle(470, -867, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id3", "ep17_1_d_limestonecave_52_3", Rectangle(-573, -750, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id3", "ep17_1_d_limestonecave_52_3", Rectangle(-525, -571, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id3", "ep17_1_d_limestonecave_52_3", Rectangle(-465, -659, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id3", "ep17_1_d_limestonecave_52_3", Rectangle(-275, -472, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id3", "ep17_1_d_limestonecave_52_3", Rectangle(-300, -617, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id3", "ep17_1_d_limestonecave_52_3", Rectangle(129, -524, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id3", "ep17_1_d_limestonecave_52_3", Rectangle(177, -691, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id3", "ep17_1_d_limestonecave_52_3", Rectangle(368, -568, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id3", "ep17_1_d_limestonecave_52_3", Rectangle(382, -750, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id3", "ep17_1_d_limestonecave_52_3", Rectangle(546, -678, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id3", "ep17_1_d_limestonecave_52_3", Rectangle(1036, -567, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id3", "ep17_1_d_limestonecave_52_3", Rectangle(1264, -427, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id3", "ep17_1_d_limestonecave_52_3", Rectangle(1190, -603, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id3", "ep17_1_d_limestonecave_52_3", Rectangle(1332, -601, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id3", "ep17_1_d_limestonecave_52_3", Rectangle(1390, -399, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id3", "ep17_1_d_limestonecave_52_3", Rectangle(-1328, -746, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id3", "ep17_1_d_limestonecave_52_3", Rectangle(-1330, -593, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id3", "ep17_1_d_limestonecave_52_3", Rectangle(-1171, -665, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id3", "ep17_1_d_limestonecave_52_3", Rectangle(-1180, -796, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id3", "ep17_1_d_limestonecave_52_3", Rectangle(-1043, -667, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id3", "ep17_1_d_limestonecave_52_3", Rectangle(-1141, -559, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id3", "ep17_1_d_limestonecave_52_3", Rectangle(11, -1125, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id3", "ep17_1_d_limestonecave_52_3", Rectangle(231, -992, 30));

		// 'Ep17_1_Rubblem_Green' GenType 25 Spawn Points
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id4", "ep17_1_d_limestonecave_52_3", Rectangle(-99, -1487, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id4", "ep17_1_d_limestonecave_52_3", Rectangle(3, -1363, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id4", "ep17_1_d_limestonecave_52_3", Rectangle(13, -1490, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id4", "ep17_1_d_limestonecave_52_3", Rectangle(-98, -1378, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id4", "ep17_1_d_limestonecave_52_3", Rectangle(157, -1479, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id4", "ep17_1_d_limestonecave_52_3", Rectangle(81, -1359, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id4", "ep17_1_d_limestonecave_52_3", Rectangle(160, -1407, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id4", "ep17_1_d_limestonecave_52_3", Rectangle(40, -1452, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id4", "ep17_1_d_limestonecave_52_3", Rectangle(90, -1434, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id4", "ep17_1_d_limestonecave_52_3", Rectangle(-178, -1417, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id4", "ep17_1_d_limestonecave_52_3", Rectangle(399, -469, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id4", "ep17_1_d_limestonecave_52_3", Rectangle(998, -598, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id4", "ep17_1_d_limestonecave_52_3", Rectangle(1177, -428, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id4", "ep17_1_d_limestonecave_52_3", Rectangle(1228, -512, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id4", "ep17_1_d_limestonecave_52_3", Rectangle(1234, -648, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id4", "ep17_1_d_limestonecave_52_3", Rectangle(1360, -470, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id4", "ep17_1_d_limestonecave_52_3", Rectangle(1147, 121, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id4", "ep17_1_d_limestonecave_52_3", Rectangle(1200, 290, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id4", "ep17_1_d_limestonecave_52_3", Rectangle(1339, 403, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id4", "ep17_1_d_limestonecave_52_3", Rectangle(1232, 155, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id4", "ep17_1_d_limestonecave_52_3", Rectangle(1353, 165, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id4", "ep17_1_d_limestonecave_52_3", Rectangle(1626, 433, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id4", "ep17_1_d_limestonecave_52_3", Rectangle(162, 215, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id4", "ep17_1_d_limestonecave_52_3", Rectangle(66, 303, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id4", "ep17_1_d_limestonecave_52_3", Rectangle(184, 484, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id4", "ep17_1_d_limestonecave_52_3", Rectangle(2, 395, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id4", "ep17_1_d_limestonecave_52_3", Rectangle(297, 356, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id4", "ep17_1_d_limestonecave_52_3", Rectangle(-542, 146, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id4", "ep17_1_d_limestonecave_52_3", Rectangle(-529, 256, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id4", "ep17_1_d_limestonecave_52_3", Rectangle(-421, 436, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id4", "ep17_1_d_limestonecave_52_3", Rectangle(-340, 264, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id4", "ep17_1_d_limestonecave_52_3", Rectangle(-371, 139, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id4", "ep17_1_d_limestonecave_52_3", Rectangle(-264, 213, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id4", "ep17_1_d_limestonecave_52_3", Rectangle(-215, 335, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id4", "ep17_1_d_limestonecave_52_3", Rectangle(-347, 522, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id4", "ep17_1_d_limestonecave_52_3", Rectangle(1462, 277, 30));

		// 'Ep17_1_Bavon_Green' GenType 26 Spawn Points
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id5", "ep17_1_d_limestonecave_52_3", Rectangle(25, -453, 9999));

		// 'Ep17_1_Flamme_Priest_Green' GenType 27 Spawn Points
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id6", "ep17_1_d_limestonecave_52_3", Rectangle(822, -526, 9999));

		// 'Ep17_1_Redania_Scout' GenType 30 Spawn Points
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id7", "ep17_1_d_limestonecave_52_3", Rectangle(-2331, -870, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id7", "ep17_1_d_limestonecave_52_3", Rectangle(-2028, -1076, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id7", "ep17_1_d_limestonecave_52_3", Rectangle(-1891, -775, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id7", "ep17_1_d_limestonecave_52_3", Rectangle(-2017, -309, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id7", "ep17_1_d_limestonecave_52_3", Rectangle(-1892, -109, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id7", "ep17_1_d_limestonecave_52_3", Rectangle(-1864, 325, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id7", "ep17_1_d_limestonecave_52_3", Rectangle(-1957, 664, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id7", "ep17_1_d_limestonecave_52_3", Rectangle(-1345, -687, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id7", "ep17_1_d_limestonecave_52_3", Rectangle(-1109, -605, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id7", "ep17_1_d_limestonecave_52_3", Rectangle(-574, -821, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id7", "ep17_1_d_limestonecave_52_3", Rectangle(-484, -431, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id7", "ep17_1_d_limestonecave_52_3", Rectangle(-1166, -188, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id7", "ep17_1_d_limestonecave_52_3", Rectangle(-980, 122, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id7", "ep17_1_d_limestonecave_52_3", Rectangle(-694, 215, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id7", "ep17_1_d_limestonecave_52_3", Rectangle(-210, 456, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id7", "ep17_1_d_limestonecave_52_3", Rectangle(130, 285, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id7", "ep17_1_d_limestonecave_52_3", Rectangle(288, 637, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id7", "ep17_1_d_limestonecave_52_3", Rectangle(521, -1438, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id7", "ep17_1_d_limestonecave_52_3", Rectangle(-87, -1432, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id7", "ep17_1_d_limestonecave_52_3", Rectangle(245, -1399, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id7", "ep17_1_d_limestonecave_52_3", Rectangle(418, -937, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id7", "ep17_1_d_limestonecave_52_3", Rectangle(270, -590, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id7", "ep17_1_d_limestonecave_52_3", Rectangle(744, -539, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id7", "ep17_1_d_limestonecave_52_3", Rectangle(1093, -459, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id7", "ep17_1_d_limestonecave_52_3", Rectangle(1291, -513, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id7", "ep17_1_d_limestonecave_52_3", Rectangle(1147, 24, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id7", "ep17_1_d_limestonecave_52_3", Rectangle(1213, 368, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id7", "ep17_1_d_limestonecave_52_3", Rectangle(1560, 273, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id7", "ep17_1_d_limestonecave_52_3", Rectangle(1348, 675, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id7", "ep17_1_d_limestonecave_52_3", Rectangle(1330, 880, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id7", "ep17_1_d_limestonecave_52_3", Rectangle(-128, -400, 30));

		// 'Ep17_1_Rocktanon' GenType 1001 Spawn Points
		AddSpawnPoint("ep17_1_d_limestonecave_52_3.Id8", "ep17_1_d_limestonecave_52_3", Rectangle(758, -563, 9999));
	}
}
