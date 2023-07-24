//--- Melia Script -----------------------------------------------------------
// Royal Mausoleum Storage Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_underfortress_59_3'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DUnderfortress593MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("d_underfortress_59_3.Id1", MonsterId.Fortress_Rock, amount: 1, tendency: TendencyType.Peaceful);
		AddSpawner("d_underfortress_59_3.Id2", MonsterId.FD_Shredded, min: 15, max: 20, tendency: TendencyType.Aggressive);
		AddSpawner("d_underfortress_59_3.Id3", MonsterId.FD_Deadbornscab, min: 12, max: 15, tendency: TendencyType.Aggressive);
		AddSpawner("d_underfortress_59_3.Id4", MonsterId.FD_Hallowventor, min: 15, max: 20, tendency: TendencyType.Aggressive);
		AddSpawner("d_underfortress_59_3.Id5", MonsterId.Fortress_Rock, amount: 1, tendency: TendencyType.Peaceful);
		AddSpawner("d_underfortress_59_3.Id6", MonsterId.Rootcrystal_03, min: 14, max: 18, respawn: TimeSpan.FromMilliseconds(30000), tendency: TendencyType.Peaceful);
		AddSpawner("d_underfortress_59_3.Id7", MonsterId.FD_Shredded, min: 12, max: 15, tendency: TendencyType.Aggressive);
		AddSpawner("d_underfortress_59_3.Id8", MonsterId.FD_Deadbornscab, min: 12, max: 15, tendency: TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Fortress_Rock' GenType 2 Spawn Points
		AddSpawnPoint("d_underfortress_59_3.Id1", "d_underfortress_59_3", Rectangle(-84, 328, 20));

		// 'FD_Shredded' GenType 16 Spawn Points
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(-1297, -749, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(1064, 989, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(1312, 837, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(1350, 1050, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(1547, 867, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(1469, 712, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(1382, 1218, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(1084, 701, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(1377, 464, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(651, 1048, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(736, 343, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(-184, 955, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(236, -57, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(1503, -675, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(1441, -452, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(1371, 85, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(1596, 121, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(660, 269, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(744, 447, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(1437, 235, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(1506, -77, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(1588, -871, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(1372, -1042, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(1592, -1053, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(692, 426, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(478, -96, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(553, 976, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(489, 835, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(22, 1029, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(-187, 841, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(-401, 1095, 20));

		// 'FD_Deadbornscab' GenType 17 Spawn Points
		AddSpawnPoint("d_underfortress_59_3.Id3", "d_underfortress_59_3", Rectangle(-1297, -645, 40));
		AddSpawnPoint("d_underfortress_59_3.Id3", "d_underfortress_59_3", Rectangle(284, -212, 40));
		AddSpawnPoint("d_underfortress_59_3.Id3", "d_underfortress_59_3", Rectangle(-180, -1039, 40));
		AddSpawnPoint("d_underfortress_59_3.Id3", "d_underfortress_59_3", Rectangle(-391, 189, 40));
		AddSpawnPoint("d_underfortress_59_3.Id3", "d_underfortress_59_3", Rectangle(-557, 1002, 40));
		AddSpawnPoint("d_underfortress_59_3.Id3", "d_underfortress_59_3", Rectangle(-1441, -113, 40));
		AddSpawnPoint("d_underfortress_59_3.Id3", "d_underfortress_59_3", Rectangle(784, 303, 40));
		AddSpawnPoint("d_underfortress_59_3.Id3", "d_underfortress_59_3", Rectangle(-35, -464, 40));
		AddSpawnPoint("d_underfortress_59_3.Id3", "d_underfortress_59_3", Rectangle(-1103, 190, 40));
		AddSpawnPoint("d_underfortress_59_3.Id3", "d_underfortress_59_3", Rectangle(-254, 57, 40));
		AddSpawnPoint("d_underfortress_59_3.Id3", "d_underfortress_59_3", Rectangle(-415, 39, 40));
		AddSpawnPoint("d_underfortress_59_3.Id3", "d_underfortress_59_3", Rectangle(-214, 204, 40));

		// 'FD_Hallowventor' GenType 18 Spawn Points
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(-1340, -684, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(-1107, -615, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(-439, -680, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(85, -405, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(339, -11, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(80, 387, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(-5, 901, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(-428, 862, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(-961, 351, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(-1271, 246, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(-1456, -66, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(505, 916, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(1250, 822, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(212, -282, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(-74, -552, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(-102, -1051, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(-1071, -151, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(-1489, 622, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(-423, 1017, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(691, 1039, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(1021, 570, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(1259, 1038, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(1504, 899, 30));

		// 'Fortress_Rock' GenType 19 Spawn Points
		AddSpawnPoint("d_underfortress_59_3.Id5", "d_underfortress_59_3", Rectangle(-746, 985, 20));

		// 'Rootcrystal_03' GenType 21 Spawn Points
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(-1349, -866, 200));
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(-1020, -650, 200));
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(-215, -610, 200));
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(-6, -1041, 200));
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(1477, -1002, 200));
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(1531, -554, 200));
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(1420, -61, 200));
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(1512, 125, 200));
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(736, -351, 200));
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(63, 305, 200));
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(-332, 25, 200));
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(-134, 970, 200));
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(-1034, -11, 200));
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(-1016, 373, 200));
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(-642, 943, 200));
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(1317, 1037, 200));
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(1534, 964, 200));
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(1536, 752, 200));
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(588, 921, 200));
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(813, 376, 200));

		// 'FD_Shredded' GenType 25 Spawn Points
		AddSpawnPoint("d_underfortress_59_3.Id7", "d_underfortress_59_3", Rectangle(-175, -563, 9999));

		// 'FD_Deadbornscab' GenType 26 Spawn Points
		AddSpawnPoint("d_underfortress_59_3.Id8", "d_underfortress_59_3", Rectangle(-17, -454, 9999));
	}
}
