//--- Melia Script -----------------------------------------------------------
// Baron Allerno Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_siauliai_47_4'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FSiauliai474MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_siauliai_47_4", MonsterId.Haming_Orange, Properties("MHP", 171214, "MINPATK", 2703, "MAXPATK", 3224, "MINMATK", 2703, "MAXMATK", 3224, "DEF", 4709, "MDEF", 4709));
		AddPropertyOverrides("f_siauliai_47_4", MonsterId.Popolion_Orange, Properties("MHP", 171834, "MINPATK", 2711, "MAXPATK", 3233, "MINMATK", 2711, "MAXMATK", 3233, "DEF", 4766, "MDEF", 4766));
		AddPropertyOverrides("f_siauliai_47_4", MonsterId.Spion_Mage, Properties("MHP", 172520, "MINPATK", 2720, "MAXPATK", 3244, "MINMATK", 2720, "MAXMATK", 3244, "DEF", 4828, "MDEF", 4828));

		// Monster Spawners ---------------------------------

		AddSpawner("f_siauliai_47_4.Id1", MonsterId.Haming_Orange, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_47_4.Id2", MonsterId.Popolion_Orange, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_47_4.Id3", MonsterId.Popolion_Orange, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_47_4.Id4", MonsterId.Popolion_Orange, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_47_4.Id5", MonsterId.Rootcrystal_01, 20, 26, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_siauliai_47_4.Id6", MonsterId.Spion_Mage, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Haming_Orange' GenType 4 Spawn Points
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(1570, -303, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(-532, -1445, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(-372, -1329, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(-565, -1260, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(207, -143, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(-599, -1566, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(-520, -1585, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(734, -306, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(-611, -1114, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(-497, -1053, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(-391, -1115, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(-290, -1192, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(-411, -1215, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(408, -463, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(1258, -1001, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(1218, -978, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(1361, -953, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(1244, -789, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(1264, -661, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(1186, -607, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(1140, -788, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(997, -851, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(1063, -664, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(1732, -571, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(1597, -509, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(1537, -130, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(1466, -461, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(337, -292, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(1385, -337, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(439, -154, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(498, 16, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(571, -312, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(1867, -459, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(1790, -511, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(1883, -318, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(719, -169, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(1580, -187, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(1708, -156, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(1709, -386, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(161, -28, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(2566, -1235, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(2524, -855, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(2529, -1108, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(2295, -1177, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(2463, -1224, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(2220, -920, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(2313, -871, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(2462, -946, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(2550, -756, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(2457, -680, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(2410, -787, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(2648, -972, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(2376, -1076, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(2720, -935, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(525, -403, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(190, -245, 40));
		AddSpawnPoint("f_siauliai_47_4.Id1", "f_siauliai_47_4", Rectangle(680, 17, 40));

		// 'Popolion_Orange' GenType 5 Spawn Points
		AddSpawnPoint("f_siauliai_47_4.Id2", "f_siauliai_47_4", Rectangle(330, -347, 25));
		AddSpawnPoint("f_siauliai_47_4.Id2", "f_siauliai_47_4", Rectangle(616, -129, 25));
		AddSpawnPoint("f_siauliai_47_4.Id2", "f_siauliai_47_4", Rectangle(234, -209, 25));
		AddSpawnPoint("f_siauliai_47_4.Id2", "f_siauliai_47_4", Rectangle(-910, -4, 25));
		AddSpawnPoint("f_siauliai_47_4.Id2", "f_siauliai_47_4", Rectangle(-657, -125, 25));
		AddSpawnPoint("f_siauliai_47_4.Id2", "f_siauliai_47_4", Rectangle(-210, 1012, 25));
		AddSpawnPoint("f_siauliai_47_4.Id2", "f_siauliai_47_4", Rectangle(134, 1001, 25));
		AddSpawnPoint("f_siauliai_47_4.Id2", "f_siauliai_47_4", Rectangle(9, 867, 25));
		AddSpawnPoint("f_siauliai_47_4.Id2", "f_siauliai_47_4", Rectangle(-363, 487, 25));
		AddSpawnPoint("f_siauliai_47_4.Id2", "f_siauliai_47_4", Rectangle(1129, 386, 25));
		AddSpawnPoint("f_siauliai_47_4.Id2", "f_siauliai_47_4", Rectangle(620, -347, 25));

		// 'Popolion_Orange' GenType 6 Spawn Points
		AddSpawnPoint("f_siauliai_47_4.Id3", "f_siauliai_47_4", Rectangle(52, 991, 1500));

		// 'Popolion_Orange' GenType 23 Spawn Points
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-519, -1442, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-423, -1139, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-186, -1285, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-629, -1268, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-1117, -102, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-1016, -54, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-932, 123, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-779, 109, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-830, 6, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-672, -236, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-780, -276, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-892, -415, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-958, -343, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-1313, -53, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-1205, 67, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-1030, 173, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-632, 16, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-624, -188, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-835, -122, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-883, -198, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-1004, -138, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-701, 144, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-583, -109, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-1051, -384, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-465, 424, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-420, 364, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-345, 639, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-433, 579, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-589, 550, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-632, 560, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-591, 648, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-522, 752, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-347, 623, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-306, 589, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-189, 561, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-178, 822, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-157, 779, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-118, 809, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-193, 1035, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-182, 1123, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(144, 1110, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(100, 743, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(34, 787, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(220, 1005, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(55, 955, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(-34, 1035, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(26, 1121, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(215, 982, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(244, 43, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(509, 43, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(725, -174, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(601, -61, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(844, -151, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(567, -505, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(458, -557, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(154, -222, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(275, -156, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(337, -69, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(663, -22, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(841, -94, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(652, -209, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(634, -393, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(329, -463, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(402, -337, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(166, -410, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(312, -284, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(494, -264, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(122, 25, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(1052, 414, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(1195, 505, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(1466, 416, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(1256, 251, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(1239, 173, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(1332, 83, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(1486, 226, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(1232, 406, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(1521, 342, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(1208, 580, 40));
		AddSpawnPoint("f_siauliai_47_4.Id4", "f_siauliai_47_4", Rectangle(1425, 284, 40));

		// 'Rootcrystal_01' GenType 24 Spawn Points
		AddSpawnPoint("f_siauliai_47_4.Id5", "f_siauliai_47_4", Rectangle(-558, -1247, 10));
		AddSpawnPoint("f_siauliai_47_4.Id5", "f_siauliai_47_4", Rectangle(203, -1247, 10));
		AddSpawnPoint("f_siauliai_47_4.Id5", "f_siauliai_47_4", Rectangle(638, -1281, 10));
		AddSpawnPoint("f_siauliai_47_4.Id5", "f_siauliai_47_4", Rectangle(1077, -990, 10));
		AddSpawnPoint("f_siauliai_47_4.Id5", "f_siauliai_47_4", Rectangle(1157, -591, 10));
		AddSpawnPoint("f_siauliai_47_4.Id5", "f_siauliai_47_4", Rectangle(1611, -473, 10));
		AddSpawnPoint("f_siauliai_47_4.Id5", "f_siauliai_47_4", Rectangle(2077, -255, 10));
		AddSpawnPoint("f_siauliai_47_4.Id5", "f_siauliai_47_4", Rectangle(2384, -823, 10));
		AddSpawnPoint("f_siauliai_47_4.Id5", "f_siauliai_47_4", Rectangle(1637, -85, 10));
		AddSpawnPoint("f_siauliai_47_4.Id5", "f_siauliai_47_4", Rectangle(1423, 366, 10));
		AddSpawnPoint("f_siauliai_47_4.Id5", "f_siauliai_47_4", Rectangle(1083, 388, 10));
		AddSpawnPoint("f_siauliai_47_4.Id5", "f_siauliai_47_4", Rectangle(615, 53, 10));
		AddSpawnPoint("f_siauliai_47_4.Id5", "f_siauliai_47_4", Rectangle(496, -327, 10));
		AddSpawnPoint("f_siauliai_47_4.Id5", "f_siauliai_47_4", Rectangle(198, -31, 10));
		AddSpawnPoint("f_siauliai_47_4.Id5", "f_siauliai_47_4", Rectangle(179, 964, 10));
		AddSpawnPoint("f_siauliai_47_4.Id5", "f_siauliai_47_4", Rectangle(-90, 966, 10));
		AddSpawnPoint("f_siauliai_47_4.Id5", "f_siauliai_47_4", Rectangle(617, 1386, 10));
		AddSpawnPoint("f_siauliai_47_4.Id5", "f_siauliai_47_4", Rectangle(1298, 1091, 10));
		AddSpawnPoint("f_siauliai_47_4.Id5", "f_siauliai_47_4", Rectangle(1308, 842, 10));
		AddSpawnPoint("f_siauliai_47_4.Id5", "f_siauliai_47_4", Rectangle(-523, 677, 10));
		AddSpawnPoint("f_siauliai_47_4.Id5", "f_siauliai_47_4", Rectangle(-363, 429, 10));
		AddSpawnPoint("f_siauliai_47_4.Id5", "f_siauliai_47_4", Rectangle(-846, 58, 10));
		AddSpawnPoint("f_siauliai_47_4.Id5", "f_siauliai_47_4", Rectangle(-1005, -345, 10));
		AddSpawnPoint("f_siauliai_47_4.Id5", "f_siauliai_47_4", Rectangle(-1062, -853, 10));
		AddSpawnPoint("f_siauliai_47_4.Id5", "f_siauliai_47_4", Rectangle(-1557, 83, 10));
		AddSpawnPoint("f_siauliai_47_4.Id5", "f_siauliai_47_4", Rectangle(-1966, -143, 10));

		// 'Spion_Mage' GenType 25 Spawn Points
		AddSpawnPoint("f_siauliai_47_4.Id6", "f_siauliai_47_4", Rectangle(1429, -310, 40));
		AddSpawnPoint("f_siauliai_47_4.Id6", "f_siauliai_47_4", Rectangle(1863, -227, 40));
		AddSpawnPoint("f_siauliai_47_4.Id6", "f_siauliai_47_4", Rectangle(1715, -448, 40));
		AddSpawnPoint("f_siauliai_47_4.Id6", "f_siauliai_47_4", Rectangle(1029, -606, 40));
		AddSpawnPoint("f_siauliai_47_4.Id6", "f_siauliai_47_4", Rectangle(1225, -880, 40));
		AddSpawnPoint("f_siauliai_47_4.Id6", "f_siauliai_47_4", Rectangle(2454, -772, 40));
		AddSpawnPoint("f_siauliai_47_4.Id6", "f_siauliai_47_4", Rectangle(2638, -960, 40));
		AddSpawnPoint("f_siauliai_47_4.Id6", "f_siauliai_47_4", Rectangle(-491, -1456, 40));
		AddSpawnPoint("f_siauliai_47_4.Id6", "f_siauliai_47_4", Rectangle(-505, -1152, 40));
		AddSpawnPoint("f_siauliai_47_4.Id6", "f_siauliai_47_4", Rectangle(-278, -1301, 40));
		AddSpawnPoint("f_siauliai_47_4.Id6", "f_siauliai_47_4", Rectangle(418, -309, 40));
		AddSpawnPoint("f_siauliai_47_4.Id6", "f_siauliai_47_4", Rectangle(661, -211, 40));
		AddSpawnPoint("f_siauliai_47_4.Id6", "f_siauliai_47_4", Rectangle(230, -114, 40));
	}
}
