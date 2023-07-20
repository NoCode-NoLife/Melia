//--- Melia Script -----------------------------------------------------------
// Uskis Arable Land Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_siauliai_46_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FSiauliai462MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_siauliai_46_2", MonsterId.Zigri_Red, Properties("MHP", 243182, "MINPATK", 3628, "MAXPATK", 4361, "MINMATK", 3628, "MAXMATK", 4361, "DEF", 12297, "MDEF", 12297));
		AddPropertyOverrides("f_siauliai_46_2", MonsterId.Mushroom_Ent_Black, Properties("MHP", 245019, "MINPATK", 3652, "MAXPATK", 4390, "MINMATK", 3652, "MAXMATK", 4390, "DEF", 12542, "MDEF", 12542));
		AddPropertyOverrides("f_siauliai_46_2", MonsterId.Siaumire, Properties("MHP", 246901, "MINPATK", 3676, "MAXPATK", 4419, "MINMATK", 3676, "MAXMATK", 4419, "DEF", 12793, "MDEF", 12793));
		AddPropertyOverrides("f_siauliai_46_2", MonsterId.Big_Siaulamb, Properties("MHP", 248825, "MINPATK", 3701, "MAXPATK", 4450, "MINMATK", 3701, "MAXMATK", 4450, "DEF", 13050, "MDEF", 13050));
		AddPropertyOverrides("f_siauliai_46_2", MonsterId.Boss_Taumas, Properties("MHP", 1279042, "MINPATK", 8943, "MAXPATK", 10754, "MINMATK", 8943, "MAXMATK", 10754, "DEF", 31952, "MDEF", 31952));

		// Monster Spawners ---------------------------------

		AddSpawner("f_siauliai_46_2.Id1", MonsterId.Mushroom_Ent_Black, 3, 4, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_46_2.Id2", MonsterId.Zigri_Red, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_46_2.Id3", MonsterId.Siaumire, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_46_2.Id4", MonsterId.Big_Siaulamb, 3, 3, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_46_2.Id5", MonsterId.Rootcrystal_01, 9, 12, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Mushroom_Ent_Black' GenType 5 Spawn Points
		AddSpawnPoint("f_siauliai_46_2.Id1", "f_siauliai_46_2", Rectangle(1398, 5894, 1500));

		// 'Zigri_Red' GenType 20 Spawn Points
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(-751, 4244, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(-605, 4308, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(-561, 4243, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(-407, 4291, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(518, 5886, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(645, 5859, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1238, 5983, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1419, 5837, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(955, 5322, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1297, 6678, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1066, 6493, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(869, 5466, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1101, 5597, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(246, 5979, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(869, 5898, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1144, 6070, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1176, 6275, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1073, 6380, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1166, 6731, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(2029, 5877, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1750, 5996, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1958, 5178, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1875, 5598, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1817, 5357, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1249, 5202, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1553, 5877, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(-678, 4319, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(-859, 4190, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(-853, 4291, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(-728, 4417, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(-647, 4440, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(-547, 4380, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(-478, 4353, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(-440, 4208, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(-405, 4404, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(-333, 4273, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(-110, 4156, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(-16, 4236, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(71, 4225, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(109, 4350, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(208, 4268, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(190, 4163, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(-75, 4328, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(13, 4050, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(192, 4035, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(293, 4056, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(419, 4179, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(326, 4354, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(507, 4283, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(717, 5284, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(713, 5371, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(784, 5431, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(855, 5322, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(889, 5163, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1097, 5317, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1193, 5319, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1323, 5305, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1177, 5418, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1033, 5381, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1064, 5528, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(953, 5883, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(802, 5881, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(591, 5838, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(456, 5999, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(438, 5852, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(253, 5783, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(156, 5906, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(280, 5860, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(181, 5732, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(357, 5811, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(298, 5707, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(417, 5682, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1140, 5938, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1109, 5753, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1067, 5906, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1235, 5815, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1222, 5934, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1198, 6402, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1108, 6556, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1168, 6556, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1209, 6496, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1320, 6350, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1395, 6439, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1312, 6494, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1180, 6680, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1389, 6608, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1672, 5922, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1629, 5907, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1716, 6002, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(2027, 5965, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1898, 5840, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1817, 5784, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1680, 5802, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1781, 5913, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1847, 5722, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1907, 5629, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(2010, 5773, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1962, 5402, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1800, 5117, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(1845, 5270, 30));
		AddSpawnPoint("f_siauliai_46_2.Id2", "f_siauliai_46_2", Rectangle(2009, 5083, 30));

		// 'Siaumire' GenType 21 Spawn Points
		AddSpawnPoint("f_siauliai_46_2.Id3", "f_siauliai_46_2", Rectangle(1144, 5345, 30));
		AddSpawnPoint("f_siauliai_46_2.Id3", "f_siauliai_46_2", Rectangle(434, 5821, 30));
		AddSpawnPoint("f_siauliai_46_2.Id3", "f_siauliai_46_2", Rectangle(627, 5889, 30));
		AddSpawnPoint("f_siauliai_46_2.Id3", "f_siauliai_46_2", Rectangle(1413, 5864, 30));
		AddSpawnPoint("f_siauliai_46_2.Id3", "f_siauliai_46_2", Rectangle(862, 5864, 30));
		AddSpawnPoint("f_siauliai_46_2.Id3", "f_siauliai_46_2", Rectangle(1184, 6284, 30));
		AddSpawnPoint("f_siauliai_46_2.Id3", "f_siauliai_46_2", Rectangle(1092, 6461, 30));
		AddSpawnPoint("f_siauliai_46_2.Id3", "f_siauliai_46_2", Rectangle(985, 5228, 30));
		AddSpawnPoint("f_siauliai_46_2.Id3", "f_siauliai_46_2", Rectangle(1105, 5543, 30));
		AddSpawnPoint("f_siauliai_46_2.Id3", "f_siauliai_46_2", Rectangle(1131, 6307, 30));
		AddSpawnPoint("f_siauliai_46_2.Id3", "f_siauliai_46_2", Rectangle(1110, 6635, 30));
		AddSpawnPoint("f_siauliai_46_2.Id3", "f_siauliai_46_2", Rectangle(1986, 5849, 30));
		AddSpawnPoint("f_siauliai_46_2.Id3", "f_siauliai_46_2", Rectangle(1905, 5522, 30));
		AddSpawnPoint("f_siauliai_46_2.Id3", "f_siauliai_46_2", Rectangle(266, 5955, 30));
		AddSpawnPoint("f_siauliai_46_2.Id3", "f_siauliai_46_2", Rectangle(505, 5960, 30));
		AddSpawnPoint("f_siauliai_46_2.Id3", "f_siauliai_46_2", Rectangle(836, 5873, 30));
		AddSpawnPoint("f_siauliai_46_2.Id3", "f_siauliai_46_2", Rectangle(-812, 4320, 30));
		AddSpawnPoint("f_siauliai_46_2.Id3", "f_siauliai_46_2", Rectangle(-671, 4383, 30));
		AddSpawnPoint("f_siauliai_46_2.Id3", "f_siauliai_46_2", Rectangle(-320, 4265, 30));
		AddSpawnPoint("f_siauliai_46_2.Id3", "f_siauliai_46_2", Rectangle(-405, 4214, 30));
		AddSpawnPoint("f_siauliai_46_2.Id3", "f_siauliai_46_2", Rectangle(-655, 4282, 30));
		AddSpawnPoint("f_siauliai_46_2.Id3", "f_siauliai_46_2", Rectangle(-108, 4282, 30));
		AddSpawnPoint("f_siauliai_46_2.Id3", "f_siauliai_46_2", Rectangle(47, 4142, 30));
		AddSpawnPoint("f_siauliai_46_2.Id3", "f_siauliai_46_2", Rectangle(80, 4271, 30));
		AddSpawnPoint("f_siauliai_46_2.Id3", "f_siauliai_46_2", Rectangle(343, 4168, 30));
		AddSpawnPoint("f_siauliai_46_2.Id3", "f_siauliai_46_2", Rectangle(1848, 5143, 30));
		AddSpawnPoint("f_siauliai_46_2.Id3", "f_siauliai_46_2", Rectangle(1866, 5284, 30));
		AddSpawnPoint("f_siauliai_46_2.Id3", "f_siauliai_46_2", Rectangle(1951, 5375, 30));
		AddSpawnPoint("f_siauliai_46_2.Id3", "f_siauliai_46_2", Rectangle(-438, 4216, 30));
		AddSpawnPoint("f_siauliai_46_2.Id3", "f_siauliai_46_2", Rectangle(255, 4212, 30));
		AddSpawnPoint("f_siauliai_46_2.Id3", "f_siauliai_46_2", Rectangle(727, 5287, 30));
		AddSpawnPoint("f_siauliai_46_2.Id3", "f_siauliai_46_2", Rectangle(1297, 5252, 30));

		// 'Big_Siaulamb' GenType 23 Spawn Points
		AddSpawnPoint("f_siauliai_46_2.Id4", "f_siauliai_46_2", Rectangle(350, 5693, 40));
		AddSpawnPoint("f_siauliai_46_2.Id4", "f_siauliai_46_2", Rectangle(677, 5868, 40));
		AddSpawnPoint("f_siauliai_46_2.Id4", "f_siauliai_46_2", Rectangle(1185, 5978, 40));
		AddSpawnPoint("f_siauliai_46_2.Id4", "f_siauliai_46_2", Rectangle(1087, 5384, 40));
		AddSpawnPoint("f_siauliai_46_2.Id4", "f_siauliai_46_2", Rectangle(218, 5812, 40));
		AddSpawnPoint("f_siauliai_46_2.Id4", "f_siauliai_46_2", Rectangle(1899, 5439, 40));

		// 'Rootcrystal_01' GenType 24 Spawn Points
		AddSpawnPoint("f_siauliai_46_2.Id5", "f_siauliai_46_2", Rectangle(-1862, 3158, 200));
		AddSpawnPoint("f_siauliai_46_2.Id5", "f_siauliai_46_2", Rectangle(-1358, 3735, 200));
		AddSpawnPoint("f_siauliai_46_2.Id5", "f_siauliai_46_2", Rectangle(-568, 4333, 200));
		AddSpawnPoint("f_siauliai_46_2.Id5", "f_siauliai_46_2", Rectangle(-653, 3589, 200));
		AddSpawnPoint("f_siauliai_46_2.Id5", "f_siauliai_46_2", Rectangle(145, 4198, 200));
		AddSpawnPoint("f_siauliai_46_2.Id5", "f_siauliai_46_2", Rectangle(995, 4292, 200));
		AddSpawnPoint("f_siauliai_46_2.Id5", "f_siauliai_46_2", Rectangle(1924, 5237, 200));
		AddSpawnPoint("f_siauliai_46_2.Id5", "f_siauliai_46_2", Rectangle(1907, 5850, 200));
		AddSpawnPoint("f_siauliai_46_2.Id5", "f_siauliai_46_2", Rectangle(818, 5296, 200));
		AddSpawnPoint("f_siauliai_46_2.Id5", "f_siauliai_46_2", Rectangle(1181, 5867, 200));
		AddSpawnPoint("f_siauliai_46_2.Id5", "f_siauliai_46_2", Rectangle(366, 5828, 200));
		AddSpawnPoint("f_siauliai_46_2.Id5", "f_siauliai_46_2", Rectangle(1243, 6517, 200));
	}
}
