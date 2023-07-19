//--- Melia Script -----------------------------------------------------------
// d_velniasprison_77_1
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Tatenye Prison' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DVelniasprison771MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("d_velniasprison_77_1.Id1", MonsterId.ERD_NightMaiden, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_77_1.Id2", MonsterId.ERD_NightMaiden_Mage, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_77_1.Id3", MonsterId.ERD_NightMaiden_Bow, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_77_1.Id4", MonsterId.ERD_Wizards_Marmotte, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_77_1.Id5", MonsterId.ERD_Charog, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_77_1.Id6", MonsterId.ERD_Charcoal_Walker, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_77_1.Id7", MonsterId.ERD_Harugal, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_77_1.Id8", MonsterId.ERD_Tower_Of_Firepuppet_Black, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_77_1.Id9", MonsterId.ERD_Hallowventor, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_77_1.Id10", MonsterId.ERD_Geppetto, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_77_1.Id11", MonsterId.ERD_Shardstatue, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_77_1.Id12", MonsterId.ERD_GoblinWarrior_Red, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_77_1.Id13", MonsterId.Rootcrystal_05, 19, 25, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'ERD_NightMaiden' GenType 2 Spawn Points
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2531.22, -1027.61, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2760.71, -1237.96, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2660.78, -1347.2, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2501.89, -1300.2, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2674.21, -1148.01, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2584.61, -1192.71, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2456.94, -1200.62, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2424.65, -1079.38, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2729.13, -1037.1, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2533.72, -911.46, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2905.9, -505.66, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2707.55, -456.21, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2563.37, -428.61, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2471.93, -522.59, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2473.45, -631.93, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2539.51, -743.44, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2490.73, -836.21, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2422.9, -748.42, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2223.78, -540.6, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2297.24, -468.24, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2095.37, -474.43, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2373.33, -497.32, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2119.45, -524.04, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2840.72, -468.09, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2658.84, -1278.58, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id1", "d_velniasprison_77_1", Rectangle(-2382.63, -1279.71, 40));

		// 'ERD_NightMaiden_Mage' GenType 3 Spawn Points
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1624.16, -1312.81, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1674.09, -1203.47, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1639.22, -1056, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1580.39, -1186.83, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1459.92, -1327.31, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1364.18, -1189.44, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1358.96, -1263.57, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1399.872, -597.78656, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1460.62, -1014.41, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1405.12, -898.67, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1414.81, -781.97, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1375.75, -665.23, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1499.92, -1058.21, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1484.81, -513.7, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1275.47, -467.69, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1353.52, -546.53, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1543.82, -476.03, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1722.95, -509.95, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1878.54, -436.01, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id2", "d_velniasprison_77_1", Rectangle(-1909.55, -578.84, 40));

		// 'ERD_NightMaiden_Bow' GenType 4 Spawn Points
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-789, -1034.61, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-768.39844, -869.0088, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-870.66, -933.62, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-570.1877, -831.60034, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-711.27, -792.33, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-760.2734, -939.5063, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-669.22705, -976.91394, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-705.41144, -623.3428, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-636.984, -866.1062, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-570.07526, -926.1967, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-472.41965, -853.5048, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-689.763, -697.4959, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-691.3151, -477.21686, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-849.4054, -503.2316, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-1422.7338, -486.28372, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-1232.7693, -460.5166, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-1234.6959, -507.46335, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-1033.4493, -521.8861, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-1076.7386, -463.18695, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-772.1439, -465.19217, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-665.94794, -563.734, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-707.46515, -906.82135, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id3", "d_velniasprison_77_1", Rectangle(-825.23566, -1097.1533, 40));

		// 'ERD_Wizards_Marmotte' GenType 5 Spawn Points
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(-279, -509.48, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(-161.21, -472.3, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(-145.43, -544.58, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(-27.04, -431.69, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(-25.3, -531.01, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(4.92, -632.61, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(-51.8, -714.7, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(111.44, -471.75, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(226.56, -447.81, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(228.81, -502.37, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(361.66, -459.64, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(409.7, -547.21, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(631.17, -429.11, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(601.55, -492.75, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(788.38, -476.07, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(942.37, -425.02, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(961.31, -485.08, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(829.93, -493.25, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(1189.87, -453.3, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(1078.15, -475.97, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(1136.04, -540.03, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(552.5, -477.67, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(412.2, -625.84, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(411.57, -718.7, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(704.12, -494.16, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(227.02, -896.09, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(438.29, -852.64, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(407.81, -968.46, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(506.63, -1088.71, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(565.8433, -1021.1326, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(468.0995, -933.9773, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(351.37, -873.23, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(542.57, -837.63, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id4", "d_velniasprison_77_1", Rectangle(504.36, -863.78, 40));

		// 'ERD_Charog' GenType 6 Spawn Points
		AddSpawnPoint("d_velniasprison_77_1.Id5", "d_velniasprison_77_1", Rectangle(920.53485, 368.5348, 9999));

		// 'ERD_Charcoal_Walker' GenType 7 Spawn Points
		AddSpawnPoint("d_velniasprison_77_1.Id6", "d_velniasprison_77_1", Rectangle(431.47253, -3.9896088, 9999));

		// 'ERD_Harugal' GenType 8 Spawn Points
		AddSpawnPoint("d_velniasprison_77_1.Id7", "d_velniasprison_77_1", Rectangle(1616.5562, -451.3102, 9999));

		// 'ERD_Tower_Of_Firepuppet_Black' GenType 9 Spawn Points
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1652.7, -626.8, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(969.33, -1075.09, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(946.03, -1199.6, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1144.35, -1235.23, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1035.23, -1314.43, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(874.8, -1101.9, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1205.69, -961.7, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1081.68, -1109.79, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1288.64, -1155.27, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1286.63, -1237.46, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1186.3, -1125.25, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1055.15, -990.31, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1085.71, -852.49, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1148.02, -767.05, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1132.94, -680.79, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1161.14, -668.55, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1146.82, -561.1, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(961.85, -1325.55, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1045.34, -1406.37, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1040.8, -1163.64, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1405.33, -527.75, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1298.69, -490.61, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1609.46, -414.2, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1533.93, -452.56, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1687.62, -539.88, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1642.57, -1157.43, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1711.14, -1137.09, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1675.55, -1029.23, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1713.02, -932.12, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1693.76, -754.87, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1727.48, -429.2, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id8", "d_velniasprison_77_1", Rectangle(1444.42, -472.01, 40));

		// 'ERD_Hallowventor' GenType 10 Spawn Points
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(-184.19, 24.94, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(-74.66, 166.13, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(3.86, -47.94, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(-121.13, -163.49, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(51.35, -213.36, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(212.68, -78.87, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(286.95, 33.36, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(-438.61, -7.45, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(-671.3, 11.66, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(-779.2, -49.06, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(-879.01, 145.99, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(-317.67, 71.55, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(-79.7, -31.23, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(62.96, 217.47, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(139.18, -2.14, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(425.76, -5.1, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(531.67, 102.17, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(579.17, -9.48, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(590.19, 179.12, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(727.3, 2.34, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(722.73, 84.98, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(-36.57, -142.44, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id9", "d_velniasprison_77_1", Rectangle(-132.86, 79.46, 40));

		// 'ERD_Geppetto' GenType 11 Spawn Points
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(729.32, 696.97, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(681.9, 869.86, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(700.81, 1079.19, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(772.5, 862.3, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(901.45, 894.35, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(907.43, 806.94, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(1124.98, 810.32, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(1224.29, 823.9, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(1182.93, 687.28, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(963.44, 679.92, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(913.28, 583.73, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(844.86, 273.09, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(976.66, 202.07, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(821.32, 127.49, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(882.89, 43.76, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(997.4, 95.54, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(628.86, 217.47, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(663.37, 25.62, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-994.75, -13, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-828.96, -59.73, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-701.46, 40.71, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-889.7, 35.27, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-943.44, 193.51, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-892.44, 272.38, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-809.54, 126.09, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-557.63, 24.42, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-558.81, -36.62, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-456.02, 47.47, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-899.46, 413.78, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-880.86, 590.57, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-1163.78, 704.37, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-1040.17, 825.5, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-1002.37, 718.16, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-846.59, 830.91, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-852.76, 690.05, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-1044.21, 647.33, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-745.32, 662.39, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-1122.8, 822.98, 40));
		AddSpawnPoint("d_velniasprison_77_1.Id10", "d_velniasprison_77_1", Rectangle(-819.09, 926.89, 40));

		// 'ERD_Shardstatue' GenType 12 Spawn Points
		AddSpawnPoint("d_velniasprison_77_1.Id11", "d_velniasprison_77_1", Rectangle(-885.34, 659.28, 9999));

		// 'ERD_GoblinWarrior_Red' GenType 13 Spawn Points
		AddSpawnPoint("d_velniasprison_77_1.Id12", "d_velniasprison_77_1", Rectangle(-930.8, 637.36, 9999));

		// 'Rootcrystal_05' GenType 14 Spawn Points
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(186.72778, -449.8928, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(-383.21, -451.92, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(-138.36917, 36.585014, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(-1583.42, -1118.59, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(-1394.71, -1027.28, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(-1412.41, -670.41, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(-1817.66, -497.5, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(-2264.28, -445.59, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(-2928.42, -515.99, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(-2562.85, -1135.27, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(-2445.74, -787.42, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(-2649.21, -1350.72, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(-2449.03, -1350.48, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(-761.08, -491.14, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(1088.28, -829.57, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(1168.14, -502.88, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(1747.05, -481.35, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(1650.77, -1272.14, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(2216.57, -1178.03, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(2241.44, -598.11, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(2690.77, -525.81, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(852.89, 92.07, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(53.59, -41.62, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(-828.63, 193.69, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(-706.41, 962.55, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(35.84, 577.17, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(77.96, 1061.69, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(-633.65, 1445.42, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(166.43, 1467.97, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(312.29, 1516.6, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(777.22, 983.25, 200));
		AddSpawnPoint("d_velniasprison_77_1.Id13", "d_velniasprison_77_1", Rectangle(-1096.12, 722.7, 200));
	}
}
