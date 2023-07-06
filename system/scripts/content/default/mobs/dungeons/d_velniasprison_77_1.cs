//--- Melia Script -----------------------------------------------------------
// d_velniasprison_77_1
//
//--- Description -----------------------------------------------------------
// Sets up the d_velniasprison_77_1 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class DVelniasprison771MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner(MonsterId.ERD_NightMaiden, 20, TimeSpan.FromMilliseconds(0), "Spawner1.d_velniasprison_77_1");
		AddSpawner(MonsterId.ERD_NightMaiden_Mage, 20, TimeSpan.FromMilliseconds(0), "Spawner2.d_velniasprison_77_1");
		AddSpawner(MonsterId.ERD_NightMaiden_Bow, 20, TimeSpan.FromMilliseconds(0), "Spawner3.d_velniasprison_77_1");
		AddSpawner(MonsterId.ERD_Wizards_Marmotte, 20, TimeSpan.FromMilliseconds(0), "Spawner4.d_velniasprison_77_1");
		AddSpawner(MonsterId.ERD_Charog, 30, TimeSpan.FromMilliseconds(0), "Spawner5.d_velniasprison_77_1");
		AddSpawner(MonsterId.ERD_Charcoal_Walker, 30, TimeSpan.FromMilliseconds(0), "Spawner6.d_velniasprison_77_1");
		AddSpawner(MonsterId.ERD_Harugal, 10, TimeSpan.FromMilliseconds(0), "Spawner7.d_velniasprison_77_1");
		AddSpawner(MonsterId.ERD_Tower_Of_Firepuppet_Black, 20, TimeSpan.FromMilliseconds(0), "Spawner8.d_velniasprison_77_1");
		AddSpawner(MonsterId.ERD_Hallowventor, 20, TimeSpan.FromMilliseconds(0), "Spawner9.d_velniasprison_77_1");
		AddSpawner(MonsterId.ERD_Geppetto, 20, TimeSpan.FromMilliseconds(0), "Spawner10.d_velniasprison_77_1");
		AddSpawner(MonsterId.ERD_Shardstatue, 30, TimeSpan.FromMilliseconds(0), "Spawner11.d_velniasprison_77_1");
		AddSpawner(MonsterId.ERD_GoblinWarrior_Red, 10, TimeSpan.FromMilliseconds(0), "Spawner12.d_velniasprison_77_1");
		AddSpawner(MonsterId.Rootcrystal_05, 25, TimeSpan.FromMilliseconds(25000), "Spawner13.d_velniasprison_77_1");

		// Monster Spawn Points -----------------------------

		// ERD_NightMaiden Spawn Points
		AddSpawnPoint("d_velniasprison_77_1", Spot(-2531.22, -1027.61, 40), "Spawner1.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-2760.71, -1237.96, 40), "Spawner1.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-2660.78, -1347.2, 40), "Spawner1.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-2501.89, -1300.2, 40), "Spawner1.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-2674.21, -1148.01, 40), "Spawner1.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-2584.61, -1192.71, 40), "Spawner1.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-2456.94, -1200.62, 40), "Spawner1.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-2424.65, -1079.38, 40), "Spawner1.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-2729.13, -1037.1, 40), "Spawner1.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-2533.72, -911.46, 40), "Spawner1.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-2905.9, -505.66, 40), "Spawner1.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-2707.55, -456.21, 40), "Spawner1.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-2563.37, -428.61, 40), "Spawner1.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-2471.93, -522.59, 40), "Spawner1.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-2473.45, -631.93, 40), "Spawner1.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-2539.51, -743.44, 40), "Spawner1.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-2490.73, -836.21, 40), "Spawner1.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-2422.9, -748.42, 40), "Spawner1.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-2223.78, -540.6, 40), "Spawner1.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-2297.24, -468.24, 40), "Spawner1.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-2095.37, -474.43, 40), "Spawner1.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-2373.33, -497.32, 40), "Spawner1.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-2119.45, -524.04, 40), "Spawner1.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-2840.72, -468.09, 40), "Spawner1.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-2658.84, -1278.58, 40), "Spawner1.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-2382.63, -1279.71, 40), "Spawner1.d_velniasprison_77_1");

		// ERD_NightMaiden_Mage Spawn Points
		AddSpawnPoint("d_velniasprison_77_1", Spot(-1624.16, -1312.81, 40), "Spawner2.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-1674.09, -1203.47, 40), "Spawner2.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-1639.22, -1056, 40), "Spawner2.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-1580.39, -1186.83, 40), "Spawner2.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-1459.92, -1327.31, 40), "Spawner2.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-1364.18, -1189.44, 40), "Spawner2.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-1358.96, -1263.57, 40), "Spawner2.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-1399.872, -597.78656, 40), "Spawner2.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-1460.62, -1014.41, 40), "Spawner2.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-1405.12, -898.67, 40), "Spawner2.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-1414.81, -781.97, 40), "Spawner2.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-1375.75, -665.23, 40), "Spawner2.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-1499.92, -1058.21, 40), "Spawner2.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-1484.81, -513.7, 40), "Spawner2.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-1275.47, -467.69, 40), "Spawner2.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-1353.52, -546.53, 40), "Spawner2.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-1543.82, -476.03, 40), "Spawner2.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-1722.95, -509.95, 40), "Spawner2.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-1878.54, -436.01, 40), "Spawner2.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-1909.55, -578.84, 40), "Spawner2.d_velniasprison_77_1");

		// ERD_NightMaiden_Bow Spawn Points
		AddSpawnPoint("d_velniasprison_77_1", Spot(-789, -1034.61, 40), "Spawner3.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-768.39844, -869.0088, 40), "Spawner3.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-870.66, -933.62, 40), "Spawner3.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-570.1877, -831.60034, 40), "Spawner3.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-711.27, -792.33, 40), "Spawner3.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-760.2734, -939.5063, 40), "Spawner3.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-669.22705, -976.91394, 40), "Spawner3.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-705.41144, -623.3428, 40), "Spawner3.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-636.984, -866.1062, 40), "Spawner3.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-570.07526, -926.1967, 40), "Spawner3.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-472.41965, -853.5048, 40), "Spawner3.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-689.763, -697.4959, 40), "Spawner3.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-691.3151, -477.21686, 40), "Spawner3.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-849.4054, -503.2316, 40), "Spawner3.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-1422.7338, -486.28372, 40), "Spawner3.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-1232.7693, -460.5166, 40), "Spawner3.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-1234.6959, -507.46335, 40), "Spawner3.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-1033.4493, -521.8861, 40), "Spawner3.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-1076.7386, -463.18695, 40), "Spawner3.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-772.1439, -465.19217, 40), "Spawner3.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-665.94794, -563.734, 40), "Spawner3.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-707.46515, -906.82135, 40), "Spawner3.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-825.23566, -1097.1533, 40), "Spawner3.d_velniasprison_77_1");

		// ERD_Wizards_Marmotte Spawn Points
		AddSpawnPoint("d_velniasprison_77_1", Spot(-279, -509.48, 40), "Spawner4.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-161.21, -472.3, 40), "Spawner4.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-145.43, -544.58, 40), "Spawner4.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-27.04, -431.69, 40), "Spawner4.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-25.3, -531.01, 40), "Spawner4.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(4.92, -632.61, 40), "Spawner4.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-51.8, -714.7, 40), "Spawner4.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(111.44, -471.75, 40), "Spawner4.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(226.56, -447.81, 40), "Spawner4.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(228.81, -502.37, 40), "Spawner4.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(361.66, -459.64, 40), "Spawner4.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(409.7, -547.21, 40), "Spawner4.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(631.17, -429.11, 40), "Spawner4.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(601.55, -492.75, 40), "Spawner4.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(788.38, -476.07, 40), "Spawner4.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(942.37, -425.02, 40), "Spawner4.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(961.31, -485.08, 40), "Spawner4.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(829.93, -493.25, 40), "Spawner4.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(1189.87, -453.3, 40), "Spawner4.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(1078.15, -475.97, 40), "Spawner4.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(1136.04, -540.03, 40), "Spawner4.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(552.5, -477.67, 40), "Spawner4.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(412.2, -625.84, 40), "Spawner4.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(411.57, -718.7, 40), "Spawner4.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(704.12, -494.16, 40), "Spawner4.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(227.02, -896.09, 40), "Spawner4.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(438.29, -852.64, 40), "Spawner4.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(407.81, -968.46, 40), "Spawner4.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(506.63, -1088.71, 40), "Spawner4.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(565.8433, -1021.1326, 40), "Spawner4.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(468.0995, -933.9773, 40), "Spawner4.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(351.37, -873.23, 40), "Spawner4.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(542.57, -837.63, 40), "Spawner4.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(504.36, -863.78, 40), "Spawner4.d_velniasprison_77_1");

		// ERD_Charog Spawn Points
		AddSpawnPoint("d_velniasprison_77_1", Spot(920.53485, 368.5348, 9999), "Spawner5.d_velniasprison_77_1");

		// ERD_Charcoal_Walker Spawn Points
		AddSpawnPoint("d_velniasprison_77_1", Spot(431.47253, -3.9896088, 9999), "Spawner6.d_velniasprison_77_1");

		// ERD_Harugal Spawn Points
		AddSpawnPoint("d_velniasprison_77_1", Spot(1616.5562, -451.3102, 9999), "Spawner7.d_velniasprison_77_1");

		// ERD_Tower_Of_Firepuppet_Black Spawn Points
		AddSpawnPoint("d_velniasprison_77_1", Spot(1652.7, -626.8, 40), "Spawner8.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(969.33, -1075.09, 40), "Spawner8.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(946.03, -1199.6, 40), "Spawner8.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(1144.35, -1235.23, 40), "Spawner8.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(1035.23, -1314.43, 40), "Spawner8.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(874.8, -1101.9, 40), "Spawner8.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(1205.69, -961.7, 40), "Spawner8.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(1081.68, -1109.79, 40), "Spawner8.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(1288.64, -1155.27, 40), "Spawner8.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(1286.63, -1237.46, 40), "Spawner8.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(1186.3, -1125.25, 40), "Spawner8.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(1055.15, -990.31, 40), "Spawner8.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(1085.71, -852.49, 40), "Spawner8.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(1148.02, -767.05, 40), "Spawner8.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(1132.94, -680.79, 40), "Spawner8.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(1161.14, -668.55, 40), "Spawner8.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(1146.82, -561.1, 40), "Spawner8.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(961.85, -1325.55, 40), "Spawner8.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(1045.34, -1406.37, 40), "Spawner8.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(1040.8, -1163.64, 40), "Spawner8.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(1405.33, -527.75, 40), "Spawner8.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(1298.69, -490.61, 40), "Spawner8.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(1609.46, -414.2, 40), "Spawner8.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(1533.93, -452.56, 40), "Spawner8.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(1687.62, -539.88, 40), "Spawner8.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(1642.57, -1157.43, 40), "Spawner8.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(1711.14, -1137.09, 40), "Spawner8.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(1675.55, -1029.23, 40), "Spawner8.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(1713.02, -932.12, 40), "Spawner8.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(1693.76, -754.87, 40), "Spawner8.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(1727.48, -429.2, 40), "Spawner8.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(1444.42, -472.01, 40), "Spawner8.d_velniasprison_77_1");

		// ERD_Hallowventor Spawn Points
		AddSpawnPoint("d_velniasprison_77_1", Spot(-184.19, 24.94, 40), "Spawner9.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-74.66, 166.13, 40), "Spawner9.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(3.86, -47.94, 40), "Spawner9.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-121.13, -163.49, 40), "Spawner9.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(51.35, -213.36, 40), "Spawner9.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(212.68, -78.87, 40), "Spawner9.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(286.95, 33.36, 40), "Spawner9.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-438.61, -7.45, 40), "Spawner9.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-671.3, 11.66, 40), "Spawner9.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-779.2, -49.06, 40), "Spawner9.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-879.01, 145.99, 40), "Spawner9.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-317.67, 71.55, 40), "Spawner9.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-79.7, -31.23, 40), "Spawner9.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(62.96, 217.47, 40), "Spawner9.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(139.18, -2.14, 40), "Spawner9.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(425.76, -5.1, 40), "Spawner9.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(531.67, 102.17, 40), "Spawner9.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(579.17, -9.48, 40), "Spawner9.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(590.19, 179.12, 40), "Spawner9.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(727.3, 2.34, 40), "Spawner9.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(722.73, 84.98, 40), "Spawner9.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-36.57, -142.44, 40), "Spawner9.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-132.86, 79.46, 40), "Spawner9.d_velniasprison_77_1");

		// ERD_Geppetto Spawn Points
		AddSpawnPoint("d_velniasprison_77_1", Spot(729.32, 696.97, 40), "Spawner10.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(681.9, 869.86, 40), "Spawner10.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(700.81, 1079.19, 40), "Spawner10.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(772.5, 862.3, 40), "Spawner10.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(901.45, 894.35, 40), "Spawner10.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(907.43, 806.94, 40), "Spawner10.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(1124.98, 810.32, 40), "Spawner10.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(1224.29, 823.9, 40), "Spawner10.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(1182.93, 687.28, 40), "Spawner10.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(963.44, 679.92, 40), "Spawner10.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(913.28, 583.73, 40), "Spawner10.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(844.86, 273.09, 40), "Spawner10.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(976.66, 202.07, 40), "Spawner10.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(821.32, 127.49, 40), "Spawner10.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(882.89, 43.76, 40), "Spawner10.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(997.4, 95.54, 40), "Spawner10.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(628.86, 217.47, 40), "Spawner10.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(663.37, 25.62, 40), "Spawner10.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-994.75, -13, 40), "Spawner10.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-828.96, -59.73, 40), "Spawner10.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-701.46, 40.71, 40), "Spawner10.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-889.7, 35.27, 40), "Spawner10.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-943.44, 193.51, 40), "Spawner10.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-892.44, 272.38, 40), "Spawner10.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-809.54, 126.09, 40), "Spawner10.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-557.63, 24.42, 40), "Spawner10.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-558.81, -36.62, 40), "Spawner10.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-456.02, 47.47, 40), "Spawner10.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-899.46, 413.78, 40), "Spawner10.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-880.86, 590.57, 40), "Spawner10.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-1163.78, 704.37, 40), "Spawner10.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-1040.17, 825.5, 40), "Spawner10.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-1002.37, 718.16, 40), "Spawner10.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-846.59, 830.91, 40), "Spawner10.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-852.76, 690.05, 40), "Spawner10.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-1044.21, 647.33, 40), "Spawner10.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-745.32, 662.39, 40), "Spawner10.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-1122.8, 822.98, 40), "Spawner10.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-819.09, 926.89, 40), "Spawner10.d_velniasprison_77_1");

		// ERD_Shardstatue Spawn Points
		AddSpawnPoint("d_velniasprison_77_1", Spot(-885.34, 659.28, 9999), "Spawner11.d_velniasprison_77_1");

		// ERD_GoblinWarrior_Red Spawn Points
		AddSpawnPoint("d_velniasprison_77_1", Spot(-930.8, 637.36, 9999), "Spawner12.d_velniasprison_77_1");

		// Rootcrystal_05 Spawn Points
		AddSpawnPoint("d_velniasprison_77_1", Spot(186.72778, -449.8928, 200), "Spawner13.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-383.21, -451.92, 200), "Spawner13.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-138.36917, 36.585014, 200), "Spawner13.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-1583.42, -1118.59, 200), "Spawner13.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-1394.71, -1027.28, 200), "Spawner13.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-1412.41, -670.41, 200), "Spawner13.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-1817.66, -497.5, 200), "Spawner13.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-2264.28, -445.59, 200), "Spawner13.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-2928.42, -515.99, 200), "Spawner13.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-2562.85, -1135.27, 200), "Spawner13.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-2445.74, -787.42, 200), "Spawner13.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-2649.21, -1350.72, 200), "Spawner13.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-2449.03, -1350.48, 200), "Spawner13.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-761.08, -491.14, 200), "Spawner13.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(1088.28, -829.57, 200), "Spawner13.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(1168.14, -502.88, 200), "Spawner13.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(1747.05, -481.35, 200), "Spawner13.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(1650.77, -1272.14, 200), "Spawner13.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(2216.57, -1178.03, 200), "Spawner13.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(2241.44, -598.11, 200), "Spawner13.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(2690.77, -525.81, 200), "Spawner13.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(852.89, 92.07, 200), "Spawner13.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(53.59, -41.62, 200), "Spawner13.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-828.63, 193.69, 200), "Spawner13.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-706.41, 962.55, 200), "Spawner13.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(35.84, 577.17, 200), "Spawner13.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(77.96, 1061.69, 200), "Spawner13.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-633.65, 1445.42, 200), "Spawner13.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(166.43, 1467.97, 200), "Spawner13.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(312.29, 1516.6, 200), "Spawner13.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(777.22, 983.25, 200), "Spawner13.d_velniasprison_77_1");
		AddSpawnPoint("d_velniasprison_77_1", Spot(-1096.12, 722.7, 200), "Spawner13.d_velniasprison_77_1");

	}
}
