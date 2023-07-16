//--- Melia Script -----------------------------------------------------------
// f_bracken_43_4
//
//--- Description -----------------------------------------------------------
// Sets up the f_bracken_43_4 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FBracken434MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("f_bracken_43_4.Id1", MonsterId.Vilkas_Warrior, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_4.Id2", MonsterId.Rootcrystal_03, 15, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_4.Id3", MonsterId.Vilkas_Spearman, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_4.Id4", MonsterId.Vilkas_Fighter, 1, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_4.Id5", MonsterId.Vilkas_Mage, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Vilkas_Warrior Spawn Points
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(1072.946, -780.6985, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(-112.27426, -1248.615, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(765.97705, -1043.9753, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(1148.4938, -464.46884, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(1622.439, -412.05472, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(1804.2537, -322.3872, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(1464.3918, 168.86484, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(1227.6486, 707.45764, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(-537.5454, -900.8629, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(-867.42206, -1106.3702, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(-1410.9054, -1322.0905, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(-1117.3063, -1375.3625, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(-892.4004, -861.45105, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(632.44086, -358.8186, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(414.42834, -310.53442, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(316.7444, -100.66454, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(-736.23206, -189.56786, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(-1190.6134, -433.7678, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(-1189.6653, -102.48129, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(-1415.428, 439.12665, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(-73.00847, -1059.062, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(718.3915, 833.4883, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(286.44247, 906.54144, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(54.77246, -230.0945, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(-203.75673, 215.38268, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(-600.61914, 451.21283, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(449.93665, 762.9739, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(927.0996, 572.505, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(1137.7157, 36.8484, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(1462.6921, -501.9667, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(-627.3641, 662.35144, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(106.22157, -1097.709, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(-410.69952, 634.34094, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(-414.31207, 330.76007, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(-1265.923, 579.37946, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(-1237.2476, 248.79123, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(-1106.8156, 364.50372, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(-1031.0225, 179.10022, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(-1308.1122, -233.103, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(-1180.5038, -605.6592, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(113.33112, -101.88104, 30));
		AddSpawnPoint( "f_bracken_43_4.Id1", "f_bracken_43_4", Spot(267.27805, -246.705, 30));

		// Rootcrystal_03 Spawn Points
		AddSpawnPoint( "f_bracken_43_4.Id2", "f_bracken_43_4", Spot(-1208.1566, -1186.3877, 40));
		AddSpawnPoint( "f_bracken_43_4.Id2", "f_bracken_43_4", Spot(-1227.469, -1489.3658, 40));
		AddSpawnPoint( "f_bracken_43_4.Id2", "f_bracken_43_4", Spot(-582.0881, -940.0318, 40));
		AddSpawnPoint( "f_bracken_43_4.Id2", "f_bracken_43_4", Spot(-427.16595, -285.8527, 40));
		AddSpawnPoint( "f_bracken_43_4.Id2", "f_bracken_43_4", Spot(450.53317, -366.03595, 40));
		AddSpawnPoint( "f_bracken_43_4.Id2", "f_bracken_43_4", Spot(190.93227, -1126.6779, 40));
		AddSpawnPoint( "f_bracken_43_4.Id2", "f_bracken_43_4", Spot(990.7196, -899.09973, 40));
		AddSpawnPoint( "f_bracken_43_4.Id2", "f_bracken_43_4", Spot(1525.9946, -485.36996, 40));
		AddSpawnPoint( "f_bracken_43_4.Id2", "f_bracken_43_4", Spot(1490.7074, 150.5449, 40));
		AddSpawnPoint( "f_bracken_43_4.Id2", "f_bracken_43_4", Spot(1318.8635, 703.17694, 40));
		AddSpawnPoint( "f_bracken_43_4.Id2", "f_bracken_43_4", Spot(475.48093, 831.0627, 40));
		AddSpawnPoint( "f_bracken_43_4.Id2", "f_bracken_43_4", Spot(883.40424, 166.77322, 40));
		AddSpawnPoint( "f_bracken_43_4.Id2", "f_bracken_43_4", Spot(-341.14722, 420.85934, 40));
		AddSpawnPoint( "f_bracken_43_4.Id2", "f_bracken_43_4", Spot(-1241.2268, 382.05298, 40));
		AddSpawnPoint( "f_bracken_43_4.Id2", "f_bracken_43_4", Spot(-1157.5068, -336.6122, 40));

		// Vilkas_Spearman Spawn Points
		AddSpawnPoint( "f_bracken_43_4.Id3", "f_bracken_43_4", Spot(-1000.6765, -1149.5042, 30));
		AddSpawnPoint( "f_bracken_43_4.Id3", "f_bracken_43_4", Spot(-608.9584, -187.88562, 30));
		AddSpawnPoint( "f_bracken_43_4.Id3", "f_bracken_43_4", Spot(-509.121, -112.89604, 30));
		AddSpawnPoint( "f_bracken_43_4.Id3", "f_bracken_43_4", Spot(-568.24316, -359.89798, 30));
		AddSpawnPoint( "f_bracken_43_4.Id3", "f_bracken_43_4", Spot(-568.92865, -510.82166, 30));
		AddSpawnPoint( "f_bracken_43_4.Id3", "f_bracken_43_4", Spot(-837.07776, -202.32175, 30));
		AddSpawnPoint( "f_bracken_43_4.Id3", "f_bracken_43_4", Spot(-577.7716, -621.39844, 30));
		AddSpawnPoint( "f_bracken_43_4.Id3", "f_bracken_43_4", Spot(35.166176, -142.52339, 30));
		AddSpawnPoint( "f_bracken_43_4.Id3", "f_bracken_43_4", Spot(145.2644, -203.94211, 30));
		AddSpawnPoint( "f_bracken_43_4.Id3", "f_bracken_43_4", Spot(-1265.1001, -514.816, 30));
		AddSpawnPoint( "f_bracken_43_4.Id3", "f_bracken_43_4", Spot(-1304.7761, -14.58173, 30));
		AddSpawnPoint( "f_bracken_43_4.Id3", "f_bracken_43_4", Spot(-1098.1222, 205.36949, 30));
		AddSpawnPoint( "f_bracken_43_4.Id3", "f_bracken_43_4", Spot(-989.91595, 321.6145, 30));
		AddSpawnPoint( "f_bracken_43_4.Id3", "f_bracken_43_4", Spot(-1264.8964, 526.2671, 30));
		AddSpawnPoint( "f_bracken_43_4.Id3", "f_bracken_43_4", Spot(-1147.514, 76.45327, 30));
		AddSpawnPoint( "f_bracken_43_4.Id3", "f_bracken_43_4", Spot(-1323.2703, -408.38654, 30));
		AddSpawnPoint( "f_bracken_43_4.Id3", "f_bracken_43_4", Spot(-725.65027, -929.7885, 30));
		AddSpawnPoint( "f_bracken_43_4.Id3", "f_bracken_43_4", Spot(-656.392, -1093.6807, 30));
		AddSpawnPoint( "f_bracken_43_4.Id3", "f_bracken_43_4", Spot(-1329.9834, -1483.1243, 30));
		AddSpawnPoint( "f_bracken_43_4.Id3", "f_bracken_43_4", Spot(-1239.593, -1371.3556, 30));
		AddSpawnPoint( "f_bracken_43_4.Id3", "f_bracken_43_4", Spot(-1493.4153, -1305.433, 30));
		AddSpawnPoint( "f_bracken_43_4.Id3", "f_bracken_43_4", Spot(-1096.3119, -1523.5061, 30));
		AddSpawnPoint( "f_bracken_43_4.Id3", "f_bracken_43_4", Spot(-1084.1195, -1227.169, 30));
		AddSpawnPoint( "f_bracken_43_4.Id3", "f_bracken_43_4", Spot(-432.81998, -1057.7083, 30));
		AddSpawnPoint( "f_bracken_43_4.Id3", "f_bracken_43_4", Spot(-139.81888, -1165.5247, 30));
		AddSpawnPoint( "f_bracken_43_4.Id3", "f_bracken_43_4", Spot(22.112167, -872.0788, 30));
		AddSpawnPoint( "f_bracken_43_4.Id3", "f_bracken_43_4", Spot(-102.87136, -923.97986, 30));
		AddSpawnPoint( "f_bracken_43_4.Id3", "f_bracken_43_4", Spot(168.33208, -950.8736, 30));
		AddSpawnPoint( "f_bracken_43_4.Id3", "f_bracken_43_4", Spot(69.76609, -1198.78, 30));
		AddSpawnPoint( "f_bracken_43_4.Id3", "f_bracken_43_4", Spot(416.24033, -1084.9547, 30));
		AddSpawnPoint( "f_bracken_43_4.Id3", "f_bracken_43_4", Spot(635.99817, -1052.4752, 30));

		// Vilkas_Fighter Spawn Points
		AddSpawnPoint( "f_bracken_43_4.Id4", "f_bracken_43_4", Spot(1018.3646, -628.2521, 9999));

		// Vilkas_Mage Spawn Points
		AddSpawnPoint( "f_bracken_43_4.Id5", "f_bracken_43_4", Spot(-0.18219867, 897.8071, 30));
		AddSpawnPoint( "f_bracken_43_4.Id5", "f_bracken_43_4", Spot(87.20502, 979.2201, 30));
		AddSpawnPoint( "f_bracken_43_4.Id5", "f_bracken_43_4", Spot(393.02637, 744.7945, 30));
		AddSpawnPoint( "f_bracken_43_4.Id5", "f_bracken_43_4", Spot(388.19077, 1055.8776, 30));
		AddSpawnPoint( "f_bracken_43_4.Id5", "f_bracken_43_4", Spot(565.7828, 1010.9886, 30));
		AddSpawnPoint( "f_bracken_43_4.Id5", "f_bracken_43_4", Spot(416.64673, 896.2613, 30));
		AddSpawnPoint( "f_bracken_43_4.Id5", "f_bracken_43_4", Spot(619.25806, 728.69415, 30));
		AddSpawnPoint( "f_bracken_43_4.Id5", "f_bracken_43_4", Spot(588.70135, 609.8996, 30));
		AddSpawnPoint( "f_bracken_43_4.Id5", "f_bracken_43_4", Spot(1025.3832, 641.68414, 30));
		AddSpawnPoint( "f_bracken_43_4.Id5", "f_bracken_43_4", Spot(1150.0305, 849.44275, 30));
		AddSpawnPoint( "f_bracken_43_4.Id5", "f_bracken_43_4", Spot(1238.3514, 600.01025, 30));
		AddSpawnPoint( "f_bracken_43_4.Id5", "f_bracken_43_4", Spot(889.9608, -688.65546, 30));
		AddSpawnPoint( "f_bracken_43_4.Id5", "f_bracken_43_4", Spot(1062.8435, -671.95233, 30));
		AddSpawnPoint( "f_bracken_43_4.Id5", "f_bracken_43_4", Spot(1070.237, -538.67004, 30));
		AddSpawnPoint( "f_bracken_43_4.Id5", "f_bracken_43_4", Spot(1228.46, -595.8197, 30));
		AddSpawnPoint( "f_bracken_43_4.Id5", "f_bracken_43_4", Spot(1355.2848, -455.71213, 30));
		AddSpawnPoint( "f_bracken_43_4.Id5", "f_bracken_43_4", Spot(1644.1226, -530.42456, 30));
		AddSpawnPoint( "f_bracken_43_4.Id5", "f_bracken_43_4", Spot(1668.7786, -297.52625, 30));
		AddSpawnPoint( "f_bracken_43_4.Id5", "f_bracken_43_4", Spot(1799.4396, -397.1333, 30));
		AddSpawnPoint( "f_bracken_43_4.Id5", "f_bracken_43_4", Spot(727.6297, -1119.694, 30));
		AddSpawnPoint( "f_bracken_43_4.Id5", "f_bracken_43_4", Spot(1003.1941, -1172.9817, 30));
		AddSpawnPoint( "f_bracken_43_4.Id5", "f_bracken_43_4", Spot(947.09753, -874.6777, 30));

	}
}
