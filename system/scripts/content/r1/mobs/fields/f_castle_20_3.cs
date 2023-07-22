//--- Melia Script -----------------------------------------------------------
// Inner Wall District 8 Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_castle_20_3'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FCastle203MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_castle_20_3", MonsterId.Aklasdame, Properties("MHP", 524595, "MINPATK", 7247, "MAXPATK", 8808, "MINMATK", 7247, "MAXMATK", 8808, "DEF", 90100, "MDEF", 90100));
		AddPropertyOverrides("f_castle_20_3", MonsterId.Aklastyke, Properties("MHP", 525104, "MINPATK", 7254, "MAXPATK", 8816, "MINMATK", 7254, "MAXMATK", 8816, "DEF", 90351, "MDEF", 90351));
		AddPropertyOverrides("f_castle_20_3", MonsterId.Aklasbairn, Properties("MHP", 526033, "MINPATK", 7265, "MAXPATK", 8831, "MINMATK", 7265, "MAXMATK", 8831, "DEF", 90811, "MDEF", 90811));

		// Monster Spawners ---------------------------------

		AddSpawner("f_castle_20_3.Id1", MonsterId.Rootcrystal_01, min: 9, max: 12, respawn: TimeSpan.FromMilliseconds(60000), tendency: TendencyType.Peaceful);
		AddSpawner("f_castle_20_3.Id2", MonsterId.Aklasdame, min: 27, max: 35, tendency: TendencyType.Aggressive);
		AddSpawner("f_castle_20_3.Id3", MonsterId.Aklastyke, min: 27, max: 35, tendency: TendencyType.Aggressive);
		AddSpawner("f_castle_20_3.Id4", MonsterId.Aklasbairn, min: 23, max: 30, tendency: TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 30 Spawn Points
		AddSpawnPoint("f_castle_20_3.Id1", "f_castle_20_3", Rectangle(-1541, -529, 100));
		AddSpawnPoint("f_castle_20_3.Id1", "f_castle_20_3", Rectangle(-1197, -1037, 100));
		AddSpawnPoint("f_castle_20_3.Id1", "f_castle_20_3", Rectangle(-1184, -481, 100));
		AddSpawnPoint("f_castle_20_3.Id1", "f_castle_20_3", Rectangle(-1127, -149, 100));
		AddSpawnPoint("f_castle_20_3.Id1", "f_castle_20_3", Rectangle(-686, 283, 100));
		AddSpawnPoint("f_castle_20_3.Id1", "f_castle_20_3", Rectangle(-117, -147, 100));
		AddSpawnPoint("f_castle_20_3.Id1", "f_castle_20_3", Rectangle(407, -669, 100));
		AddSpawnPoint("f_castle_20_3.Id1", "f_castle_20_3", Rectangle(340, -86, 100));
		AddSpawnPoint("f_castle_20_3.Id1", "f_castle_20_3", Rectangle(927, -262, 100));
		AddSpawnPoint("f_castle_20_3.Id1", "f_castle_20_3", Rectangle(250, 391, 100));
		AddSpawnPoint("f_castle_20_3.Id1", "f_castle_20_3", Rectangle(-664, 1082, 100));
		AddSpawnPoint("f_castle_20_3.Id1", "f_castle_20_3", Rectangle(-168, 613, 100));

		// 'Aklasdame' GenType 32 Spawn Points
		AddSpawnPoint("f_castle_20_3.Id2", "f_castle_20_3", Rectangle(-1456, -755, 40));
		AddSpawnPoint("f_castle_20_3.Id2", "f_castle_20_3", Rectangle(-1383, -977, 40));
		AddSpawnPoint("f_castle_20_3.Id2", "f_castle_20_3", Rectangle(-1502, -1015, 40));
		AddSpawnPoint("f_castle_20_3.Id2", "f_castle_20_3", Rectangle(-1196, -1041, 40));
		AddSpawnPoint("f_castle_20_3.Id2", "f_castle_20_3", Rectangle(-1163, -930, 40));
		AddSpawnPoint("f_castle_20_3.Id2", "f_castle_20_3", Rectangle(-1347, -887, 40));
		AddSpawnPoint("f_castle_20_3.Id2", "f_castle_20_3", Rectangle(-1304, -778, 40));
		AddSpawnPoint("f_castle_20_3.Id2", "f_castle_20_3", Rectangle(-1066, -784, 40));
		AddSpawnPoint("f_castle_20_3.Id2", "f_castle_20_3", Rectangle(-1180, -509, 40));
		AddSpawnPoint("f_castle_20_3.Id2", "f_castle_20_3", Rectangle(-1189, -273, 40));
		AddSpawnPoint("f_castle_20_3.Id2", "f_castle_20_3", Rectangle(-1243, -116, 40));
		AddSpawnPoint("f_castle_20_3.Id2", "f_castle_20_3", Rectangle(-1101, -39, 40));
		AddSpawnPoint("f_castle_20_3.Id2", "f_castle_20_3", Rectangle(-1114, -159, 40));
		AddSpawnPoint("f_castle_20_3.Id2", "f_castle_20_3", Rectangle(-939, -85, 40));
		AddSpawnPoint("f_castle_20_3.Id2", "f_castle_20_3", Rectangle(-695, -559, 40));
		AddSpawnPoint("f_castle_20_3.Id2", "f_castle_20_3", Rectangle(-711, -205, 40));
		AddSpawnPoint("f_castle_20_3.Id2", "f_castle_20_3", Rectangle(-783, -21, 40));
		AddSpawnPoint("f_castle_20_3.Id2", "f_castle_20_3", Rectangle(-651, 21, 40));
		AddSpawnPoint("f_castle_20_3.Id2", "f_castle_20_3", Rectangle(-614, -112, 40));
		AddSpawnPoint("f_castle_20_3.Id2", "f_castle_20_3", Rectangle(-716, -632, 40));
		AddSpawnPoint("f_castle_20_3.Id2", "f_castle_20_3", Rectangle(-608, -717, 40));
		AddSpawnPoint("f_castle_20_3.Id2", "f_castle_20_3", Rectangle(-680, -469, 40));
		AddSpawnPoint("f_castle_20_3.Id2", "f_castle_20_3", Rectangle(-717, -310, 40));
		AddSpawnPoint("f_castle_20_3.Id2", "f_castle_20_3", Rectangle(-425, -95, 40));
		AddSpawnPoint("f_castle_20_3.Id2", "f_castle_20_3", Rectangle(-190, -81, 40));
		AddSpawnPoint("f_castle_20_3.Id2", "f_castle_20_3", Rectangle(-83, -111, 40));
		AddSpawnPoint("f_castle_20_3.Id2", "f_castle_20_3", Rectangle(-163, -217, 40));
		AddSpawnPoint("f_castle_20_3.Id2", "f_castle_20_3", Rectangle(-158, -433, 40));
		AddSpawnPoint("f_castle_20_3.Id2", "f_castle_20_3", Rectangle(-113, -577, 40));
		AddSpawnPoint("f_castle_20_3.Id2", "f_castle_20_3", Rectangle(-217, -595, 40));
		AddSpawnPoint("f_castle_20_3.Id2", "f_castle_20_3", Rectangle(-207, -678, 40));
		AddSpawnPoint("f_castle_20_3.Id2", "f_castle_20_3", Rectangle(-110, -706, 40));
		AddSpawnPoint("f_castle_20_3.Id2", "f_castle_20_3", Rectangle(-59, -558, 40));

		// 'Aklastyke' GenType 33 Spawn Points
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(-682, 454, 40));
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(-771, 594, 40));
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(-667, 929, 40));
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(-638, 665, 40));
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(-774, 721, 40));
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(-528, 722, 40));
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(-218, 1004, 40));
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(-266, 1064, 40));
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(-355, 992, 40));
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(-280, 850, 40));
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(-286, 712, 40));
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(-315, 634, 40));
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(-186, 599, 40));
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(-40, 489, 40));
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(126, 586, 40));
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(42, 438, 40));
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(131, 426, 40));
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(343, 292, 40));
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(297, 144, 40));
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(371, 51, 40));
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(416, -45, 40));
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(407, -189, 40));
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(244, -204, 40));
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(258, -29, 40));
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(309, -125, 40));
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(70, 565, 40));
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(60, -94, 40));
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(798, -382, 40));
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(1005, -353, 40));
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(899, -328, 40));
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(818, -230, 40));
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(945, -149, 40));
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(-1490, -1126, 40));
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(-1581, -1133, 40));
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(-1572, -950, 40));
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(-1676, -819, 40));
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(-1625, -630, 40));
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(-1405, -629, 40));
		AddSpawnPoint("f_castle_20_3.Id3", "f_castle_20_3", Rectangle(-1310, -1135, 40));

		// 'Aklasbairn' GenType 34 Spawn Points
		AddSpawnPoint("f_castle_20_3.Id4", "f_castle_20_3", Rectangle(228, -79, 9999));
	}
}
