//--- Melia Script -----------------------------------------------------------
// 2nd Demon Prison Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_velniasprison_54_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DVelniasprison541MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("d_velniasprison_54_1.Id1", MonsterId.FD_Yognome, min: 27, max: 35, tendency: TendencyType.Aggressive);
		AddSpawner("d_velniasprison_54_1.Id2", MonsterId.FD_Long_Arm, min: 18, max: 23, tendency: TendencyType.Aggressive);
		AddSpawner("d_velniasprison_54_1.Id3", MonsterId.FD_Firent_Yellow, amount: 1, tendency: TendencyType.Aggressive);
		AddSpawner("d_velniasprison_54_1.Id4", MonsterId.Rootcrystal_04, min: 12, max: 15, respawn: TimeSpan.FromMilliseconds(60000), tendency: TendencyType.Peaceful);
		AddSpawner("d_velniasprison_54_1.Id5", MonsterId.FD_Infrogalas_Bow, min: 15, max: 20, tendency: TendencyType.Aggressive);
		AddSpawner("d_velniasprison_54_1.Id6", MonsterId.FD_Yognome, min: 15, max: 20, tendency: TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'FD_Yognome' GenType 20 Spawn Points
		AddSpawnPoint("d_velniasprison_54_1.Id1", "d_velniasprison_54_1", Rectangle(9, -11, 9999));

		// 'FD_Long_Arm' GenType 32 Spawn Points
		AddSpawnPoint("d_velniasprison_54_1.Id2", "d_velniasprison_54_1", Rectangle(-1137, -693, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id2", "d_velniasprison_54_1", Rectangle(-1372, -806, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id2", "d_velniasprison_54_1", Rectangle(-1264, -566, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id2", "d_velniasprison_54_1", Rectangle(-1001, -798, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id2", "d_velniasprison_54_1", Rectangle(-971, -579, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id2", "d_velniasprison_54_1", Rectangle(-133, 709, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id2", "d_velniasprison_54_1", Rectangle(-302, 842, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id2", "d_velniasprison_54_1", Rectangle(463, 828, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id2", "d_velniasprison_54_1", Rectangle(872, 39, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id2", "d_velniasprison_54_1", Rectangle(915, 253, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id2", "d_velniasprison_54_1", Rectangle(1100, -9, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id2", "d_velniasprison_54_1", Rectangle(1239, 231, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id2", "d_velniasprison_54_1", Rectangle(292, 740, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id2", "d_velniasprison_54_1", Rectangle(-396, 685, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id2", "d_velniasprison_54_1", Rectangle(1072, 166, 25));

		// 'FD_Firent_Yellow' GenType 33 Spawn Points
		AddSpawnPoint("d_velniasprison_54_1.Id3", "d_velniasprison_54_1", Rectangle(932, 94, 100));

		// 'Rootcrystal_04' GenType 41 Spawn Points
		AddSpawnPoint("d_velniasprison_54_1.Id4", "d_velniasprison_54_1", Rectangle(-170, 19, 10));
		AddSpawnPoint("d_velniasprison_54_1.Id4", "d_velniasprison_54_1", Rectangle(258, 93, 10));
		AddSpawnPoint("d_velniasprison_54_1.Id4", "d_velniasprison_54_1", Rectangle(-7, 445, 10));
		AddSpawnPoint("d_velniasprison_54_1.Id4", "d_velniasprison_54_1", Rectangle(441, 764, 10));
		AddSpawnPoint("d_velniasprison_54_1.Id4", "d_velniasprison_54_1", Rectangle(-266, 891, 10));
		AddSpawnPoint("d_velniasprison_54_1.Id4", "d_velniasprison_54_1", Rectangle(-986, 828, 10));
		AddSpawnPoint("d_velniasprison_54_1.Id4", "d_velniasprison_54_1", Rectangle(-1059, 234, 10));
		AddSpawnPoint("d_velniasprison_54_1.Id4", "d_velniasprison_54_1", Rectangle(-1395, -45, 10));
		AddSpawnPoint("d_velniasprison_54_1.Id4", "d_velniasprison_54_1", Rectangle(-1297, -784, 10));
		AddSpawnPoint("d_velniasprison_54_1.Id4", "d_velniasprison_54_1", Rectangle(-1004, -588, 10));
		AddSpawnPoint("d_velniasprison_54_1.Id4", "d_velniasprison_54_1", Rectangle(-467, -498, 10));
		AddSpawnPoint("d_velniasprison_54_1.Id4", "d_velniasprison_54_1", Rectangle(833, -501, 10));
		AddSpawnPoint("d_velniasprison_54_1.Id4", "d_velniasprison_54_1", Rectangle(779, 57, 10));
		AddSpawnPoint("d_velniasprison_54_1.Id4", "d_velniasprison_54_1", Rectangle(1267, 156, 10));
		AddSpawnPoint("d_velniasprison_54_1.Id4", "d_velniasprison_54_1", Rectangle(979, 627, 10));

		// 'FD_Infrogalas_Bow' GenType 45 Spawn Points
		AddSpawnPoint("d_velniasprison_54_1.Id5", "d_velniasprison_54_1", Rectangle(182, -87, 35));
		AddSpawnPoint("d_velniasprison_54_1.Id5", "d_velniasprison_54_1", Rectangle(102, 192, 35));
		AddSpawnPoint("d_velniasprison_54_1.Id5", "d_velniasprison_54_1", Rectangle(-224, 234, 35));
		AddSpawnPoint("d_velniasprison_54_1.Id5", "d_velniasprison_54_1", Rectangle(-39, 410, 35));
		AddSpawnPoint("d_velniasprison_54_1.Id5", "d_velniasprison_54_1", Rectangle(-399, 799, 35));
		AddSpawnPoint("d_velniasprison_54_1.Id5", "d_velniasprison_54_1", Rectangle(-192, 835, 35));
		AddSpawnPoint("d_velniasprison_54_1.Id5", "d_velniasprison_54_1", Rectangle(839, -559, 35));
		AddSpawnPoint("d_velniasprison_54_1.Id5", "d_velniasprison_54_1", Rectangle(374, 207, 35));
		AddSpawnPoint("d_velniasprison_54_1.Id5", "d_velniasprison_54_1", Rectangle(-1093, -580, 35));
		AddSpawnPoint("d_velniasprison_54_1.Id5", "d_velniasprison_54_1", Rectangle(-1084, 862, 35));
		AddSpawnPoint("d_velniasprison_54_1.Id5", "d_velniasprison_54_1", Rectangle(-945, 949, 35));
		AddSpawnPoint("d_velniasprison_54_1.Id5", "d_velniasprison_54_1", Rectangle(-1193, -855, 35));
		AddSpawnPoint("d_velniasprison_54_1.Id5", "d_velniasprison_54_1", Rectangle(-1035, 269, 35));
		AddSpawnPoint("d_velniasprison_54_1.Id5", "d_velniasprison_54_1", Rectangle(-55, -397, 35));
		AddSpawnPoint("d_velniasprison_54_1.Id5", "d_velniasprison_54_1", Rectangle(966, 191, 35));
		AddSpawnPoint("d_velniasprison_54_1.Id5", "d_velniasprison_54_1", Rectangle(789, -549, 35));
		AddSpawnPoint("d_velniasprison_54_1.Id5", "d_velniasprison_54_1", Rectangle(950, -10, 35));
		AddSpawnPoint("d_velniasprison_54_1.Id5", "d_velniasprison_54_1", Rectangle(-201, 16, 35));

		// 'FD_Yognome' GenType 50 Spawn Points
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(-591, -547, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(-466, -479, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(-476, -556, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(829, -608, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(817, -530, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(841, -467, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(29, 27, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(-292, 287, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(80, 321, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(379, 183, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(-1365, -177, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(-1396, -101, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(-1241, -69, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(-1326, -671, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(-1086, -820, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(-1151, -613, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(-1012, 901, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(-1114, 953, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(-1183, 822, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(-252, 737, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(-121, 837, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(-371, 905, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(345, 794, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(444, 678, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(341, 698, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(977, 256, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(1158, -52, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(845, 34, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(1022, 104, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(-1180, 202, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(-1017, 190, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(-1111, 307, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(-193, 175, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(-359, -46, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(-159, -49, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(152, -77, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(205, 287, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(205, 86, 25));
	}
}
