//--- Melia Script -----------------------------------------------------------
// f_siauliai_46_2
//
//--- Description -----------------------------------------------------------
// Sets up the f_siauliai_46_2 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FSiauliai462MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_siauliai_46_2", MonsterId.Zigri_Red, Properties("MHP", 243182, "MINPATK", 3628, "MAXPATK", 4361, "MINMATK", 3628, "MAXMATK", 4361, "DEF", 12297, "MDEF", 12297));
		AddPropertyOverrides("f_siauliai_46_2", MonsterId.Mushroom_Ent_Black, Properties("MHP", 245019, "MINPATK", 3652, "MAXPATK", 4390, "MINMATK", 3652, "MAXMATK", 4390, "DEF", 12542, "MDEF", 12542));
		AddPropertyOverrides("f_siauliai_46_2", MonsterId.Siaumire, Properties("MHP", 246901, "MINPATK", 3676, "MAXPATK", 4419, "MINMATK", 3676, "MAXMATK", 4419, "DEF", 12793, "MDEF", 12793));
		AddPropertyOverrides("f_siauliai_46_2", MonsterId.Big_Siaulamb, Properties("MHP", 248825, "MINPATK", 3701, "MAXPATK", 4450, "MINMATK", 3701, "MAXMATK", 4450, "DEF", 13050, "MDEF", 13050));

		// Monster Spawners --------------------------------

		AddSpawner("f_siauliai_46_2.Id1", MonsterId.Zigri_Red, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_46_2.Id2", MonsterId.Mushroom_Ent_Black, 4, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_46_2.Id3", MonsterId.Siaumire, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_46_2.Id4", MonsterId.Big_Siaulamb, 3, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_46_2.Id5", MonsterId.Rootcrystal_01, 12, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Zigri_Red Spawn Points
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(-751.6692, 4244.647, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(-605.9728, 4308.04, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(-561.19336, 4243.294, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(-407.47983, 4291.79, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(518.9135, 5886.4727, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(645.2099, 5859.8745, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1238.5687, 5983.9014, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1419.0255, 5837.2866, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(955.69214, 5322.9644, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1297.9531, 6678.316, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1066.3169, 6493.574, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(869.83405, 5466.9595, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1101.7257, 5597.021, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(246.66132, 5979.4316, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(869.324, 5898.423, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1144.368, 6070.411, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1176.2506, 6275.486, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1073.5231, 6380.819, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1166.3998, 6731.339, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(2029.8611, 5877.5854, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1750.6233, 5996.001, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1958.7079, 5178.0806, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1875.1555, 5598.308, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1817.4714, 5357.448, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1249.0935, 5202.84, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1553.7692, 5877.2036, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(-678.6917, 4319.3013, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(-859.245, 4190.179, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(-853.99854, 4291.6753, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(-728.2554, 4417.5635, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(-647.0242, 4440.976, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(-547.33185, 4380.4707, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(-478.25226, 4353.7554, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(-440.70572, 4208.36, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(-405.90585, 4404.5566, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(-333.67554, 4273.242, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(-110.64778, 4156.6733, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(-16.833574, 4236.495, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(71.2298, 4225.982, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(109.83623, 4350.6055, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(208.55702, 4268.2104, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(190.57343, 4163.626, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(-75.691895, 4328.616, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(13.702715, 4050.3423, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(192.65164, 4035.965, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(293.73297, 4056.3142, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(419.79715, 4179.4795, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(326.06464, 4354.9854, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(507.91394, 4283.678, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(717.2114, 5284.8154, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(713.34906, 5371.4883, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(784.9967, 5431.109, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(855.3068, 5322.731, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(889.5383, 5163.4326, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1097.993, 5317.81, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1193.018, 5319.27, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1323.8687, 5305.529, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1177.3483, 5418.09, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1033.9238, 5381.773, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1064.9009, 5528.348, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(953.3898, 5883.823, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(802.5302, 5881.6094, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(591.7821, 5838.09, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(456.4964, 5999.159, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(438.32178, 5852.6284, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(253.17784, 5783.906, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(156.21469, 5906.959, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(280.27853, 5860.3623, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(181.3553, 5732.4634, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(357.41806, 5811.0913, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(298.7101, 5707.962, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(417.26935, 5682.3223, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1140.0385, 5938.1562, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1109.0165, 5753.903, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1067.157, 5906.041, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1235.4781, 5815.941, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1222.5695, 5934.855, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1198.0581, 6402.303, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1108.5101, 6556.111, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1168.7795, 6556.689, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1209.5326, 6496.1377, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1320.1653, 6350.767, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1395.089, 6439.2505, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1312.9259, 6494.435, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1180.4688, 6680.6455, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1389.508, 6608.7114, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1672.1155, 5922.9595, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1629.1858, 5907.1343, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1716.1132, 6002.6333, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(2027.1312, 5965.1978, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1898.6028, 5840.6733, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1817.3848, 5784.6226, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1680.6487, 5802.6777, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1781.2559, 5913.162, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1847.1349, 5722.8438, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1907.9022, 5629.945, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(2010.0629, 5773.56, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1962.2976, 5402.938, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1800.4409, 5117.914, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(1845.5787, 5270.8315, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id1", "f_siauliai_46_2", Spot(2009.7426, 5083.2754, 30));

		// Mushroom_Ent_Black Spawn Points
		AddSpawnPoint( "f_siauliai_46_2.Id2", "f_siauliai_46_2", Spot(1398.3147, 5894.964, 1500));

		// Siaumire Spawn Points
		AddSpawnPoint( "f_siauliai_46_2.Id3", "f_siauliai_46_2", Spot(1144.8203, 5345.7754, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id3", "f_siauliai_46_2", Spot(434.36203, 5821.8975, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id3", "f_siauliai_46_2", Spot(627.11945, 5889.9346, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id3", "f_siauliai_46_2", Spot(1413.0006, 5864.292, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id3", "f_siauliai_46_2", Spot(862.43866, 5864.202, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id3", "f_siauliai_46_2", Spot(1184.3779, 6284.118, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id3", "f_siauliai_46_2", Spot(1092.3611, 6461.4893, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id3", "f_siauliai_46_2", Spot(985.84283, 5228.4404, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id3", "f_siauliai_46_2", Spot(1105.1055, 5543.097, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id3", "f_siauliai_46_2", Spot(1131.6207, 6307.2603, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id3", "f_siauliai_46_2", Spot(1110.3722, 6635.1787, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id3", "f_siauliai_46_2", Spot(1986.7163, 5849.436, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id3", "f_siauliai_46_2", Spot(1905.8431, 5522.2056, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id3", "f_siauliai_46_2", Spot(266.7911, 5955.016, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id3", "f_siauliai_46_2", Spot(505.2973, 5960.8706, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id3", "f_siauliai_46_2", Spot(836.26373, 5873.068, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id3", "f_siauliai_46_2", Spot(-812.20874, 4320.0854, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id3", "f_siauliai_46_2", Spot(-671.8794, 4383.164, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id3", "f_siauliai_46_2", Spot(-320.87067, 4265.518, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id3", "f_siauliai_46_2", Spot(-405.47528, 4214.4224, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id3", "f_siauliai_46_2", Spot(-655.5778, 4282.611, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id3", "f_siauliai_46_2", Spot(-108.45137, 4282.9487, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id3", "f_siauliai_46_2", Spot(47.447266, 4142.8516, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id3", "f_siauliai_46_2", Spot(80.39526, 4271.6895, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id3", "f_siauliai_46_2", Spot(343.12674, 4168.3706, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id3", "f_siauliai_46_2", Spot(1848.4951, 5143.662, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id3", "f_siauliai_46_2", Spot(1866.9669, 5284.2793, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id3", "f_siauliai_46_2", Spot(1951.8856, 5375.5425, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id3", "f_siauliai_46_2", Spot(-438.94656, 4216.0215, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id3", "f_siauliai_46_2", Spot(255.87823, 4212.637, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id3", "f_siauliai_46_2", Spot(727.755, 5287.278, 30));
		AddSpawnPoint( "f_siauliai_46_2.Id3", "f_siauliai_46_2", Spot(1297.2603, 5252.683, 30));

		// Big_Siaulamb Spawn Points
		AddSpawnPoint( "f_siauliai_46_2.Id4", "f_siauliai_46_2", Spot(350.55313, 5693.554, 40));
		AddSpawnPoint( "f_siauliai_46_2.Id4", "f_siauliai_46_2", Spot(677.59174, 5868.2393, 40));
		AddSpawnPoint( "f_siauliai_46_2.Id4", "f_siauliai_46_2", Spot(1185.1251, 5978.521, 40));
		AddSpawnPoint( "f_siauliai_46_2.Id4", "f_siauliai_46_2", Spot(1087.1124, 5384.716, 40));
		AddSpawnPoint( "f_siauliai_46_2.Id4", "f_siauliai_46_2", Spot(218.69942, 5812.164, 40));
		AddSpawnPoint( "f_siauliai_46_2.Id4", "f_siauliai_46_2", Spot(1899.9966, 5439.266, 40));

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "f_siauliai_46_2.Id5", "f_siauliai_46_2", Spot(-1862.5541, 3158.429, 200));
		AddSpawnPoint( "f_siauliai_46_2.Id5", "f_siauliai_46_2", Spot(-1358.267, 3735.6526, 200));
		AddSpawnPoint( "f_siauliai_46_2.Id5", "f_siauliai_46_2", Spot(-568.24426, 4333.929, 200));
		AddSpawnPoint( "f_siauliai_46_2.Id5", "f_siauliai_46_2", Spot(-653.1719, 3589.0078, 200));
		AddSpawnPoint( "f_siauliai_46_2.Id5", "f_siauliai_46_2", Spot(145.81227, 4198.5386, 200));
		AddSpawnPoint( "f_siauliai_46_2.Id5", "f_siauliai_46_2", Spot(995.9655, 4292.2314, 200));
		AddSpawnPoint( "f_siauliai_46_2.Id5", "f_siauliai_46_2", Spot(1924.1863, 5237.7314, 200));
		AddSpawnPoint( "f_siauliai_46_2.Id5", "f_siauliai_46_2", Spot(1907.208, 5850.326, 200));
		AddSpawnPoint( "f_siauliai_46_2.Id5", "f_siauliai_46_2", Spot(818.6026, 5296.085, 200));
		AddSpawnPoint( "f_siauliai_46_2.Id5", "f_siauliai_46_2", Spot(1181.5946, 5867.6743, 200));
		AddSpawnPoint( "f_siauliai_46_2.Id5", "f_siauliai_46_2", Spot(366.08087, 5828.842, 200));
		AddSpawnPoint( "f_siauliai_46_2.Id5", "f_siauliai_46_2", Spot(1243.9109, 6517.8315, 200));

	}
}
