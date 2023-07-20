//--- Melia Script -----------------------------------------------------------
// Tevhrin Stalactite Cave Section 3 Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_limestonecave_52_3'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DLimestonecave523MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_limestonecave_52_3", MonsterId.Flamme_Priest_Green, Properties("MHP", 482680, "MINPATK", 6708, "MAXPATK", 8146, "MINMATK", 6708, "MAXMATK", 8146, "DEF", 73282, "MDEF", 73282));
		AddPropertyOverrides("d_limestonecave_52_3", MonsterId.Flamme_Mage_Green, Properties("MHP", 484899, "MINPATK", 6736, "MAXPATK", 8181, "MINMATK", 6736, "MAXMATK", 8181, "DEF", 74172, "MDEF", 74172));
		AddPropertyOverrides("d_limestonecave_52_3", MonsterId.Bavon_Green, Properties("MHP", 487176, "MINPATK", 6766, "MAXPATK", 8217, "MINMATK", 6766, "MAXMATK", 8217, "DEF", 75086, "MDEF", 75086));
		AddPropertyOverrides("d_limestonecave_52_3", MonsterId.Rubblem_Green, Properties("MHP", 489512, "MINPATK", 6796, "MAXPATK", 8254, "MINMATK", 6796, "MAXMATK", 8254, "DEF", 76023, "MDEF", 76023));
		AddPropertyOverrides("d_limestonecave_52_3", MonsterId.Rocktanon, Properties("MHP", 491904, "MINPATK", 6826, "MAXPATK", 8292, "MINMATK", 6826, "MAXMATK", 8292, "DEF", 76983, "MDEF", 76983));
		AddPropertyOverrides("d_limestonecave_52_3", MonsterId.Boss_Stalakan, Properties("MHP", 2521187, "MINPATK", 16459, "MAXPATK", 19993, "MINMATK", 16459, "MAXMATK", 19993, "DEF", 187115, "MDEF", 187115));

		// Monster Spawners ---------------------------------

		AddSpawner("d_limestonecave_52_3.Id1", MonsterId.Flamme_Priest_Green, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_3.Id2", MonsterId.Flamme_Mage_Green, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_3.Id3", MonsterId.Bavon_Green, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_3.Id4", MonsterId.Rubblem_Green, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_3.Id5", MonsterId.Bavon_Green, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_3.Id6", MonsterId.Flamme_Priest_Green, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_3.Id7", MonsterId.Rootcrystal_04, 19, 25, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("d_limestonecave_52_3.Id8", MonsterId.Rocktanon, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Flamme_Priest_Green' GenType 20 Spawn Points
		AddSpawnPoint("d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Rectangle(-1822, -276, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Rectangle(-1850, 432, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Rectangle(-1960, -184, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Rectangle(-1878, -31, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Rectangle(-2102, 486, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Rectangle(-1972, 569, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Rectangle(-1882, 659, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Rectangle(-1843, 538, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Rectangle(-1953, -314, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Rectangle(-1960, -685, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Rectangle(-2116, -940, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Rectangle(-2004, -1031, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Rectangle(-1862, -913, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Rectangle(-1837, -773, 30));

		// 'Flamme_Mage_Green' GenType 21 Spawn Points
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(-1207, -101, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(-1939, -144, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(-1982, 586, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(-1220, 48, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(-1029, 12, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(-1157, -359, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(-748, 187, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(-272, -417, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(-389, -501, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(1141, -528, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(-4, -1438, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(85, -1374, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(337, -562, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(1229, 3, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(1105, 263, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(1294, 551, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(97, 386, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(188, 545, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(-454, 190, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(-508, 431, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(-279, 377, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(-408, 285, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(-2045, -172, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(-1932, 413, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(-481, -358, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(253, -702, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(1259, -315, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(-1060, -196, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(-1126, 238, 30));

		// 'Bavon_Green' GenType 22 Spawn Points
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(-682, -666, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(-7, -1454, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(15, -1321, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(12, -1437, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(246, -1467, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(286, -1490, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(535, -1322, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(0, -1220, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(470, -867, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(-573, -750, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(-525, -571, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(-465, -659, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(-275, -472, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(-300, -617, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(129, -524, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(177, -691, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(368, -568, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(382, -750, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(546, -678, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(1036, -567, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(1264, -427, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(1190, -603, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(1332, -601, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(1390, -399, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(-1328, -746, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(-1330, -593, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(-1171, -665, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(-1180, -796, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(-1043, -667, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(-1141, -559, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(11, -1125, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(231, -992, 30));

		// 'Rubblem_Green' GenType 25 Spawn Points
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(-99, -1487, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(3, -1363, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(13, -1490, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(-98, -1378, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(157, -1479, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(81, -1359, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(160, -1407, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(40, -1452, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(90, -1434, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(-178, -1417, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(399, -469, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(998, -598, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(1177, -428, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(1228, -512, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(1234, -648, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(1360, -470, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(1147, 121, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(1200, 290, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(1339, 403, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(1232, 155, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(1353, 165, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(1626, 433, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(162, 215, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(66, 303, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(184, 484, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(2, 395, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(297, 356, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(-542, 146, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(-529, 256, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(-421, 436, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(-340, 264, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(-371, 139, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(-264, 213, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(-215, 335, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(-347, 522, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(1462, 277, 30));

		// 'Bavon_Green' GenType 26 Spawn Points
		AddSpawnPoint("d_limestonecave_52_3.Id5", "d_limestonecave_52_3", Rectangle(25, -453, 9999));

		// 'Flamme_Priest_Green' GenType 27 Spawn Points
		AddSpawnPoint("d_limestonecave_52_3.Id6", "d_limestonecave_52_3", Rectangle(822, -526, 9999));

		// 'Rootcrystal_04' GenType 30 Spawn Points
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(-2331, -870, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(-2028, -1076, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(-1891, -775, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(-2017, -309, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(-1892, -109, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(-1864, 325, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(-1957, 664, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(-1345, -687, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(-1109, -605, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(-574, -821, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(-484, -431, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(-1166, -188, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(-980, 122, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(-694, 215, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(-210, 456, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(130, 285, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(288, 637, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(521, -1438, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(-87, -1432, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(245, -1399, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(418, -937, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(270, -590, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(744, -539, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(1093, -459, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(1291, -513, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(1147, 24, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(1213, 368, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(1560, 273, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(1348, 675, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(1330, 880, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(-128, -400, 15));

		// 'Rocktanon' GenType 1001 Spawn Points
		AddSpawnPoint("d_limestonecave_52_3.Id8", "d_limestonecave_52_3", Rectangle(758, -563, 9999));
	}
}
