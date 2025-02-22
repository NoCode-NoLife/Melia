//--- Melia Script -----------------------------------------------------------
// EP17 Tevhrin Stalactite Cave Section 5 Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'ep17_1_d_limestonecave_52_5'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Game.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class Ep171DLimestonecave525MobScript : GeneralScript
{
	protected override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("ep17_1_d_limestonecave_52_5", MonsterId.Ep17_1_Wood_Goblin_Green, Properties("MHP", 134493856, "MINPATK", 315000, "MAXPATK", 315000, "MINMATK", 315000, "MAXMATK", 315000, "DEF", 15090000, "MDEF", 15090000));
		AddPropertyOverrides("ep17_1_d_limestonecave_52_5", MonsterId.Ep17_1_Rockoff_Orange, Properties("MHP", 134493856, "MINPATK", 315000, "MAXPATK", 315000, "MINMATK", 315000, "MAXMATK", 315000, "DEF", 15090000, "MDEF", 15090000));
		AddPropertyOverrides("ep17_1_d_limestonecave_52_5", MonsterId.Ep17_1_Flamil_Green, Properties("MHP", 134493856, "MINPATK", 315000, "MAXPATK", 315000, "MINMATK", 315000, "MAXMATK", 315000, "DEF", 15090000, "MDEF", 15090000));
		AddPropertyOverrides("ep17_1_d_limestonecave_52_5", MonsterId.Ep17_1_Rondo, Properties("MHP", 134493856, "MINPATK", 315000, "MAXPATK", 315000, "MINMATK", 315000, "MAXMATK", 315000, "DEF", 15090000, "MDEF", 15090000));
		AddPropertyOverrides("ep17_1_d_limestonecave_52_5", MonsterId.Ep17_1_Boss_Rambandgad, Properties("MHP", 557326080, "MINPATK", 330000, "MAXPATK", 330000, "MINMATK", 330000, "MAXMATK", 330000, "DEF", 15190000, "MDEF", 15190000));
		AddPropertyOverrides("ep17_1_d_limestonecave_52_5", MonsterId.Ep17_1_Boss_Gesti_Q1, Properties("MHP", 557326080, "MINPATK", 330000, "MAXPATK", 330000, "MINMATK", 330000, "MAXMATK", 330000, "DEF", 15190000, "MDEF", 15190000));
		AddPropertyOverrides("ep17_1_d_limestonecave_52_5", MonsterId.Ep17_1_Redania_Scout, Properties("MHP", 134493856, "MINPATK", 315000, "MAXPATK", 315000, "MINMATK", 315000, "MAXMATK", 315000, "DEF", 15090000, "MDEF", 15090000));

		// Monster Spawners ---------------------------------

		AddSpawner("ep17_1_d_limestonecave_52_5.Id1", MonsterId.Ep17_1_Wood_Goblin_Green, min: 23, max: 30, tendency: TendencyType.Aggressive);
		AddSpawner("ep17_1_d_limestonecave_52_5.Id2", MonsterId.Ep17_1_Rockoff_Orange, min: 27, max: 35, tendency: TendencyType.Aggressive);
		AddSpawner("ep17_1_d_limestonecave_52_5.Id3", MonsterId.Ep17_1_Flamil_Green, min: 23, max: 30, tendency: TendencyType.Aggressive);
		AddSpawner("ep17_1_d_limestonecave_52_5.Id4", MonsterId.Ep17_1_Rondo, min: 15, max: 20, tendency: TendencyType.Aggressive);
		AddSpawner("ep17_1_d_limestonecave_52_5.Id5", MonsterId.Ep17_1_Wood_Goblin_Green, min: 23, max: 30, tendency: TendencyType.Aggressive);
		AddSpawner("ep17_1_d_limestonecave_52_5.Id6", MonsterId.Ep17_1_Redania_Scout, min: 12, max: 15, tendency: TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Ep17_1_Wood_Goblin_Green' GenType 19 Spawn Points
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id1", "ep17_1_d_limestonecave_52_5", Rectangle(-447, -1295, 200));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id1", "ep17_1_d_limestonecave_52_5", Rectangle(-779, -490, 200));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id1", "ep17_1_d_limestonecave_52_5", Rectangle(-1351, -628, 200));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id1", "ep17_1_d_limestonecave_52_5", Rectangle(-833, 79, 200));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id1", "ep17_1_d_limestonecave_52_5", Rectangle(135, 241, 200));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id1", "ep17_1_d_limestonecave_52_5", Rectangle(392, -509, 200));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id1", "ep17_1_d_limestonecave_52_5", Rectangle(855, -1430, 200));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id1", "ep17_1_d_limestonecave_52_5", Rectangle(1079, -573, 200));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id1", "ep17_1_d_limestonecave_52_5", Rectangle(521, 869, 200));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id1", "ep17_1_d_limestonecave_52_5", Rectangle(-177, 907, 200));

		// 'Ep17_1_Rockoff_Orange' GenType 20 Spawn Points
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(500, -761, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(-519, -1167, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(-416, -980, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(-722, -412, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(-1451, -614, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(-812, -95, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(187, 83, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(724, -1196, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(1069, -274, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(930, 253, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(307, 1031, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(-307, 807, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(-1415, -434, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(-1261, -660, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(-1212, -507, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(-764, -516, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(-602, -608, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(-626, -50, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(-749, 58, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(-5, 79, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(-38, 251, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(241, 277, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(-26, -62, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(171, -124, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(-57, 838, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(-149, 719, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(277, 987, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(366, 781, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(812, 430, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(938, 555, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(1072, 479, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(1069, 280, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(1093, -383, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(908, -458, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(1008, -598, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(1134, -620, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(1148, -503, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(241, -724, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(365, -471, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(565, -541, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(-635, -1126, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(-693, -1345, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(-441, -1380, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(880, -1433, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id2", "ep17_1_d_limestonecave_52_5", Rectangle(936, -1249, 30));

		// 'Ep17_1_Flamil_Green' GenType 21 Spawn Points
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(286, -680, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(594, -642, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(12, 282, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(-55, 70, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(-602, 33, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(-1173, -551, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(-613, -635, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(-387, -1135, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(-641, -1158, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(903, -1194, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(995, 517, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(1069, -586, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(351, 813, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(959, -389, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(1111, -313, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(226, 47, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(-242, 85, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(397, -548, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(509, -816, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(735, -1134, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(704, -1316, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(887, -1380, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(-472, -1409, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(-476, -994, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(-752, -1102, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(-836, -1328, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(-844, -461, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(-647, -376, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(-821, -148, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(-887, 46, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(-1295, -451, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(-1471, -562, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(-1586, -124, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(-1489, 79, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(-362, 813, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(-215, 697, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(-128, 890, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(397, 1098, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id3", "ep17_1_d_limestonecave_52_5", Rectangle(226, 966, 30));

		// 'Ep17_1_Rondo' GenType 23 Spawn Points
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id4", "ep17_1_d_limestonecave_52_5", Rectangle(-660, -1267, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id4", "ep17_1_d_limestonecave_52_5", Rectangle(-580, -1092, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id4", "ep17_1_d_limestonecave_52_5", Rectangle(-540, -1351, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id4", "ep17_1_d_limestonecave_52_5", Rectangle(-539, -1473, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id4", "ep17_1_d_limestonecave_52_5", Rectangle(-640, -1498, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id4", "ep17_1_d_limestonecave_52_5", Rectangle(-307, -1387, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id4", "ep17_1_d_limestonecave_52_5", Rectangle(866, 211, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id4", "ep17_1_d_limestonecave_52_5", Rectangle(810, 401, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id4", "ep17_1_d_limestonecave_52_5", Rectangle(1002, 539, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id4", "ep17_1_d_limestonecave_52_5", Rectangle(1093, 370, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id4", "ep17_1_d_limestonecave_52_5", Rectangle(1039, 188, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id4", "ep17_1_d_limestonecave_52_5", Rectangle(854, 529, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id4", "ep17_1_d_limestonecave_52_5", Rectangle(72, 257, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id4", "ep17_1_d_limestonecave_52_5", Rectangle(-78, 101, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id4", "ep17_1_d_limestonecave_52_5", Rectangle(153, -32, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id4", "ep17_1_d_limestonecave_52_5", Rectangle(303, 158, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id4", "ep17_1_d_limestonecave_52_5", Rectangle(315, 847, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id4", "ep17_1_d_limestonecave_52_5", Rectangle(277, 1111, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id4", "ep17_1_d_limestonecave_52_5", Rectangle(417, 1025, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id4", "ep17_1_d_limestonecave_52_5", Rectangle(531, 761, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id4", "ep17_1_d_limestonecave_52_5", Rectangle(198, 964, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id4", "ep17_1_d_limestonecave_52_5", Rectangle(-313, 791, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id4", "ep17_1_d_limestonecave_52_5", Rectangle(-224, 714, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id4", "ep17_1_d_limestonecave_52_5", Rectangle(-82, 901, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id4", "ep17_1_d_limestonecave_52_5", Rectangle(-816, -158, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id4", "ep17_1_d_limestonecave_52_5", Rectangle(-840, 103, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id4", "ep17_1_d_limestonecave_52_5", Rectangle(-673, 85, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id4", "ep17_1_d_limestonecave_52_5", Rectangle(-549, -37, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id4", "ep17_1_d_limestonecave_52_5", Rectangle(-648, -150, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id4", "ep17_1_d_limestonecave_52_5", Rectangle(-877, -5, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id4", "ep17_1_d_limestonecave_52_5", Rectangle(-1602, 4, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id4", "ep17_1_d_limestonecave_52_5", Rectangle(-1626, -140, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id4", "ep17_1_d_limestonecave_52_5", Rectangle(-1405, -38, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id4", "ep17_1_d_limestonecave_52_5", Rectangle(-1384, 122, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id4", "ep17_1_d_limestonecave_52_5", Rectangle(-1325, 195, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id4", "ep17_1_d_limestonecave_52_5", Rectangle(-1225, 255, 30));

		// 'Ep17_1_Wood_Goblin_Green' GenType 24 Spawn Points
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id5", "ep17_1_d_limestonecave_52_5", Rectangle(-584, -1095, 9999));

		// 'Ep17_1_Redania_Scout' GenType 26 Spawn Points
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id6", "ep17_1_d_limestonecave_52_5", Rectangle(-1271, -1352, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id6", "ep17_1_d_limestonecave_52_5", Rectangle(-715, -1366, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id6", "ep17_1_d_limestonecave_52_5", Rectangle(-346, -1343, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id6", "ep17_1_d_limestonecave_52_5", Rectangle(-531, -930, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id6", "ep17_1_d_limestonecave_52_5", Rectangle(305, -755, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id6", "ep17_1_d_limestonecave_52_5", Rectangle(-647, -532, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id6", "ep17_1_d_limestonecave_52_5", Rectangle(-1126, -540, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id6", "ep17_1_d_limestonecave_52_5", Rectangle(-1450, -579, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id6", "ep17_1_d_limestonecave_52_5", Rectangle(-1519, -144, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id6", "ep17_1_d_limestonecave_52_5", Rectangle(-1141, 283, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id6", "ep17_1_d_limestonecave_52_5", Rectangle(-798, 0, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id6", "ep17_1_d_limestonecave_52_5", Rectangle(-590, -156, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id6", "ep17_1_d_limestonecave_52_5", Rectangle(-141, 74, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id6", "ep17_1_d_limestonecave_52_5", Rectangle(159, 371, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id6", "ep17_1_d_limestonecave_52_5", Rectangle(294, -9, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id6", "ep17_1_d_limestonecave_52_5", Rectangle(347, -589, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id6", "ep17_1_d_limestonecave_52_5", Rectangle(425, -847, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id6", "ep17_1_d_limestonecave_52_5", Rectangle(937, -535, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id6", "ep17_1_d_limestonecave_52_5", Rectangle(1095, -162, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id6", "ep17_1_d_limestonecave_52_5", Rectangle(992, 324, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id6", "ep17_1_d_limestonecave_52_5", Rectangle(1126, 542, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id6", "ep17_1_d_limestonecave_52_5", Rectangle(1560, 728, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id6", "ep17_1_d_limestonecave_52_5", Rectangle(1644, 960, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id6", "ep17_1_d_limestonecave_52_5", Rectangle(491, 972, 30));
		AddSpawnPoint("ep17_1_d_limestonecave_52_5.Id6", "ep17_1_d_limestonecave_52_5", Rectangle(-275, 871, 30));
	}
}
