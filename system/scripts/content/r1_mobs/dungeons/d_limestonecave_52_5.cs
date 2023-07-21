//--- Melia Script -----------------------------------------------------------
// Tevhrin Stalactite Cave Section 5 Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_limestonecave_52_5'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DLimestonecave525MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_limestonecave_52_5", MonsterId.Wood_Goblin_Green, Properties("MHP", 510123, "MINPATK", 7061, "MAXPATK", 8579, "MINMATK", 7061, "MAXMATK", 8579, "DEF", 84293, "MDEF", 84293));
		AddPropertyOverrides("d_limestonecave_52_5", MonsterId.Rockoff_Orange, Properties("MHP", 512925, "MINPATK", 7097, "MAXPATK", 8624, "MINMATK", 7097, "MAXMATK", 8624, "DEF", 85417, "MDEF", 85417));
		AddPropertyOverrides("d_limestonecave_52_5", MonsterId.Flamil_Green, Properties("MHP", 515774, "MINPATK", 7134, "MAXPATK", 8669, "MINMATK", 7134, "MAXMATK", 8669, "DEF", 86560, "MDEF", 86560));
		AddPropertyOverrides("d_limestonecave_52_5", MonsterId.Rondo, Properties("MHP", 518669, "MINPATK", 7171, "MAXPATK", 8714, "MINMATK", 7171, "MAXMATK", 8714, "DEF", 87722, "MDEF", 87722));
		AddPropertyOverrides("d_limestonecave_52_5", MonsterId.Boss_Rambandgad, Properties("MHP", 3035767, "MINPATK", 11534, "MAXPATK", 14017, "MINMATK", 11534, "MAXMATK", 14017, "DEF", 277374, "MDEF", 277374));
		AddPropertyOverrides("d_limestonecave_52_5", MonsterId.Boss_Gesti_Q1, Properties("MHP", 4380368, "MINPATK", 14268, "MAXPATK", 17341, "MINMATK", 14268, "MAXMATK", 17341, "DEF", 177384, "MDEF", 177384));

		// Monster Spawners ---------------------------------

		AddSpawner("d_limestonecave_52_5.Id1", MonsterId.Wood_Goblin_Green, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_5.Id2", MonsterId.Rockoff_Orange, 27, 35, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_5.Id3", MonsterId.Flamil_Green, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_5.Id4", MonsterId.Rondo, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_5.Id5", MonsterId.Wood_Goblin_Green, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_5.Id6", MonsterId.Rootcrystal_04, 19, 25, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Wood_Goblin_Green' GenType 19 Spawn Points
		AddSpawnPoint("d_limestonecave_52_5.Id1", "d_limestonecave_52_5", Rectangle(-447, -1295, 200));
		AddSpawnPoint("d_limestonecave_52_5.Id1", "d_limestonecave_52_5", Rectangle(-522, -995, 200));
		AddSpawnPoint("d_limestonecave_52_5.Id1", "d_limestonecave_52_5", Rectangle(-779, -490, 200));
		AddSpawnPoint("d_limestonecave_52_5.Id1", "d_limestonecave_52_5", Rectangle(-1351, -628, 200));
		AddSpawnPoint("d_limestonecave_52_5.Id1", "d_limestonecave_52_5", Rectangle(-833, 79, 200));
		AddSpawnPoint("d_limestonecave_52_5.Id1", "d_limestonecave_52_5", Rectangle(135, 241, 200));
		AddSpawnPoint("d_limestonecave_52_5.Id1", "d_limestonecave_52_5", Rectangle(392, -509, 200));
		AddSpawnPoint("d_limestonecave_52_5.Id1", "d_limestonecave_52_5", Rectangle(855, -1430, 200));
		AddSpawnPoint("d_limestonecave_52_5.Id1", "d_limestonecave_52_5", Rectangle(1079, -573, 200));
		AddSpawnPoint("d_limestonecave_52_5.Id1", "d_limestonecave_52_5", Rectangle(1083, 270, 200));
		AddSpawnPoint("d_limestonecave_52_5.Id1", "d_limestonecave_52_5", Rectangle(521, 869, 200));
		AddSpawnPoint("d_limestonecave_52_5.Id1", "d_limestonecave_52_5", Rectangle(-177, 907, 200));

		// 'Rockoff_Orange' GenType 20 Spawn Points
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(500, -761, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-519, -1167, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-416, -980, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-722, -412, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-1451, -614, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-812, -95, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(187, 83, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(724, -1196, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(1069, -274, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(930, 253, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(307, 1031, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-307, 807, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-1415, -434, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-1261, -660, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-1212, -507, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-764, -516, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-602, -608, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-626, -50, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-749, 58, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-5, 79, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-38, 251, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(241, 277, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-26, -62, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(171, -124, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-57, 838, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-149, 719, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(277, 987, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(366, 781, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(812, 430, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(938, 555, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(1072, 479, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(1069, 280, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(1093, -383, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(908, -458, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(1008, -598, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(1134, -620, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(1148, -503, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(241, -724, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(365, -471, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(565, -541, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-635, -1126, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-693, -1345, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-441, -1380, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(880, -1433, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(936, -1249, 30));

		// 'Flamil_Green' GenType 21 Spawn Points
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(286, -680, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(594, -642, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(12, 282, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-55, 70, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-602, 33, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-1173, -551, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-613, -635, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-387, -1135, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-641, -1158, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(903, -1194, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(995, 517, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(1069, -586, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(351, 813, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(959, -389, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(1111, -313, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(226, 47, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-242, 85, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(397, -548, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(509, -816, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(735, -1134, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(704, -1316, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(887, -1380, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-472, -1409, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-476, -994, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-752, -1102, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-836, -1328, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-844, -461, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-647, -376, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-821, -148, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-887, 46, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-1295, -451, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-1471, -562, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-1586, -124, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-1489, 79, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-362, 813, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-215, 697, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-128, 890, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(397, 1098, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(226, 966, 30));

		// 'Rondo' GenType 23 Spawn Points
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-660, -1267, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-580, -1092, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-540, -1351, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-539, -1473, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-640, -1498, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-307, -1387, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(866, 211, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(810, 401, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(1002, 539, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(1093, 370, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(1039, 188, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(854, 529, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(72, 257, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-78, 101, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(153, -32, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(303, 158, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(315, 847, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(277, 1111, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(417, 1025, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(531, 761, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(198, 964, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-313, 791, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-224, 714, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-82, 901, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-816, -158, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-840, 103, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-673, 85, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-549, -37, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-648, -150, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-877, -5, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-1602, 4, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-1626, -140, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-1405, -38, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-1384, 122, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-1325, 195, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-1225, 255, 30));

		// 'Wood_Goblin_Green' GenType 24 Spawn Points
		AddSpawnPoint("d_limestonecave_52_5.Id5", "d_limestonecave_52_5", Rectangle(-1340, -1324, 9999));

		// 'Rootcrystal_04' GenType 26 Spawn Points
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(-1271, -1352, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(-715, -1366, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(-346, -1343, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(-531, -930, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(305, -755, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(-647, -532, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(-1126, -540, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(-1450, -579, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(-1519, -144, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(-1141, 283, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(-798, 0, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(-590, -156, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(-141, 74, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(159, 371, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(294, -9, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(347, -589, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(425, -847, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(937, -535, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(1095, -162, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(992, 324, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(1126, 542, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(1560, 728, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(1644, 960, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(491, 972, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(-275, 871, 15));
	}
}
