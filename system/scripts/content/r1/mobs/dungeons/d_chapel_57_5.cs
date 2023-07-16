//--- Melia Script -----------------------------------------------------------
// d_chapel_57_5
//
//--- Description -----------------------------------------------------------
// Sets up the d_chapel_57_5 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DChapel575MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("d_chapel_57_5", MonsterId.Yognome, Properties("MHP", 19651, "MINPATK", 754, "MAXPATK", 828, "MINMATK", 754, "MAXMATK", 828, "DEF", 72, "MDEF", 72));
		AddPropertyOverrides("d_chapel_57_5", MonsterId.Zombiegirl2_Chpel, Properties("MHP", 20048, "MINPATK", 759, "MAXPATK", 834, "MINMATK", 759, "MAXMATK", 834, "DEF", 72, "MDEF", 72));
		AddPropertyOverrides("d_chapel_57_5", MonsterId.Glizardon, Properties("MHP", 20454, "MINPATK", 764, "MAXPATK", 841, "MINMATK", 764, "MAXMATK", 841, "DEF", 72, "MDEF", 72));
		AddPropertyOverrides("d_chapel_57_5", MonsterId.New_Desmodus, Properties("MHP", 20867, "MINPATK", 769, "MAXPATK", 847, "MINMATK", 769, "MAXMATK", 847, "DEF", 73, "MDEF", 73));

		// Monster Spawners --------------------------------

		AddSpawner("d_chapel_57_5.Id1", MonsterId.Rootcrystal_01, 15, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("d_chapel_57_5.Id2", MonsterId.Yognome, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_chapel_57_5.Id3", MonsterId.Zombiegirl2_Chpel, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_chapel_57_5.Id4", MonsterId.Zombiegirl2_Chpel, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_chapel_57_5.Id5", MonsterId.Yognome, 35, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_chapel_57_5.Id6", MonsterId.Glizardon, 3, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_chapel_57_5.Id7", MonsterId.New_Desmodus, 35, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_chapel_57_5.Id8", MonsterId.Glizardon, 3, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "d_chapel_57_5.Id1", "d_chapel_57_5", Spot(-1282.46, 1035.63, 200));
		AddSpawnPoint( "d_chapel_57_5.Id1", "d_chapel_57_5", Spot(-635.26, 976.94, 200));
		AddSpawnPoint( "d_chapel_57_5.Id1", "d_chapel_57_5", Spot(-1465.3, 409.73, 200));
		AddSpawnPoint( "d_chapel_57_5.Id1", "d_chapel_57_5", Spot(-746.83, 392.02, 200));
		AddSpawnPoint( "d_chapel_57_5.Id1", "d_chapel_57_5", Spot(47.84, 1007.29, 200));
		AddSpawnPoint( "d_chapel_57_5.Id1", "d_chapel_57_5", Spot(-90.03, 460.82, 200));
		AddSpawnPoint( "d_chapel_57_5.Id1", "d_chapel_57_5", Spot(381.75, 420.6, 200));
		AddSpawnPoint( "d_chapel_57_5.Id1", "d_chapel_57_5", Spot(1033.08, 443.52, 200));
		AddSpawnPoint( "d_chapel_57_5.Id1", "d_chapel_57_5", Spot(499.31, -30.37, 200));
		AddSpawnPoint( "d_chapel_57_5.Id1", "d_chapel_57_5", Spot(-55.25, -152.01, 200));
		AddSpawnPoint( "d_chapel_57_5.Id1", "d_chapel_57_5", Spot(-828.28, -162.43, 200));
		AddSpawnPoint( "d_chapel_57_5.Id1", "d_chapel_57_5", Spot(-153.03, -708.81, 200));
		AddSpawnPoint( "d_chapel_57_5.Id1", "d_chapel_57_5", Spot(-815.45, -793.41, 200));
		AddSpawnPoint( "d_chapel_57_5.Id1", "d_chapel_57_5", Spot(470.68, -739.05, 200));
		AddSpawnPoint( "d_chapel_57_5.Id1", "d_chapel_57_5", Spot(43.48, -880.49, 200));
		AddSpawnPoint( "d_chapel_57_5.Id1", "d_chapel_57_5", Spot(787.04, -725.65, 200));
		AddSpawnPoint( "d_chapel_57_5.Id1", "d_chapel_57_5", Spot(599.09, 449.87, 200));
		AddSpawnPoint( "d_chapel_57_5.Id1", "d_chapel_57_5", Spot(-441.6, 443.08, 200));
		AddSpawnPoint( "d_chapel_57_5.Id1", "d_chapel_57_5", Spot(-1007.65, 402.2, 200));

		// Yognome Spawn Points
		AddSpawnPoint( "d_chapel_57_5.Id2", "d_chapel_57_5", Spot(-47.44, -111.49, 9999));

		// Zombiegirl2_Chpel Spawn Points
		AddSpawnPoint( "d_chapel_57_5.Id3", "d_chapel_57_5", Spot(-105.33, -169.39, 9999));
		AddSpawnPoint( "d_chapel_57_5.Id4", "d_chapel_57_5", Spot(-181.06, 885.01, 30));
		AddSpawnPoint( "d_chapel_57_5.Id4", "d_chapel_57_5", Spot(-200.39, 997.98, 30));
		AddSpawnPoint( "d_chapel_57_5.Id4", "d_chapel_57_5", Spot(-135.1735, -71.168846, 30));
		AddSpawnPoint( "d_chapel_57_5.Id4", "d_chapel_57_5", Spot(75.09, 924.97, 30));
		AddSpawnPoint( "d_chapel_57_5.Id4", "d_chapel_57_5", Spot(197.38, 1020.78, 30));
		AddSpawnPoint( "d_chapel_57_5.Id4", "d_chapel_57_5", Spot(13.49, 1071.79, 30));
		AddSpawnPoint( "d_chapel_57_5.Id4", "d_chapel_57_5", Spot(56.222893, -97.60869, 30));
		AddSpawnPoint( "d_chapel_57_5.Id4", "d_chapel_57_5", Spot(203.23831, 886.0056, 30));
		AddSpawnPoint( "d_chapel_57_5.Id4", "d_chapel_57_5", Spot(-791.71, -186.91, 30));
		AddSpawnPoint( "d_chapel_57_5.Id4", "d_chapel_57_5", Spot(-1017.08, -173.24, 30));
		AddSpawnPoint( "d_chapel_57_5.Id4", "d_chapel_57_5", Spot(-904.29, -81.57, 30));
		AddSpawnPoint( "d_chapel_57_5.Id4", "d_chapel_57_5", Spot(-719.34, -100.02, 30));
		AddSpawnPoint( "d_chapel_57_5.Id4", "d_chapel_57_5", Spot(-927.33, -244.6, 30));
		AddSpawnPoint( "d_chapel_57_5.Id4", "d_chapel_57_5", Spot(-693, -814.41, 30));
		AddSpawnPoint( "d_chapel_57_5.Id4", "d_chapel_57_5", Spot(-851.5, -899.02, 30));
		AddSpawnPoint( "d_chapel_57_5.Id4", "d_chapel_57_5", Spot(-966.68, -824.7, 30));
		AddSpawnPoint( "d_chapel_57_5.Id4", "d_chapel_57_5", Spot(-832.89, -762.86, 30));
		AddSpawnPoint( "d_chapel_57_5.Id4", "d_chapel_57_5", Spot(-149.01, -791.58, 30));
		AddSpawnPoint( "d_chapel_57_5.Id4", "d_chapel_57_5", Spot(-21.99, -878.47, 30));
		AddSpawnPoint( "d_chapel_57_5.Id4", "d_chapel_57_5", Spot(41.23, -731.1, 30));
		AddSpawnPoint( "d_chapel_57_5.Id4", "d_chapel_57_5", Spot(-80.76, -663.92, 30));
		AddSpawnPoint( "d_chapel_57_5.Id4", "d_chapel_57_5", Spot(-61.34, -205.64, 30));
		AddSpawnPoint( "d_chapel_57_5.Id4", "d_chapel_57_5", Spot(-1475.82, 403.51, 30));
		AddSpawnPoint( "d_chapel_57_5.Id4", "d_chapel_57_5", Spot(-1429.64, 343.99, 30));
		AddSpawnPoint( "d_chapel_57_5.Id4", "d_chapel_57_5", Spot(-1500.11, 613.84, 30));
		AddSpawnPoint( "d_chapel_57_5.Id4", "d_chapel_57_5", Spot(-1399.08, 498.31, 30));
		AddSpawnPoint( "d_chapel_57_5.Id4", "d_chapel_57_5", Spot(1141.93, 430.6, 30));
		AddSpawnPoint( "d_chapel_57_5.Id4", "d_chapel_57_5", Spot(985.02563, 316.82178, 30));
		AddSpawnPoint( "d_chapel_57_5.Id4", "d_chapel_57_5", Spot(972.8042, 488.2937, 30));
		AddSpawnPoint( "d_chapel_57_5.Id4", "d_chapel_57_5", Spot(671.35, 432.51, 30));
		AddSpawnPoint( "d_chapel_57_5.Id4", "d_chapel_57_5", Spot(567.22675, 322.51904, 30));
		AddSpawnPoint( "d_chapel_57_5.Id4", "d_chapel_57_5", Spot(391.70538, 257.2426, 30));
		AddSpawnPoint( "d_chapel_57_5.Id4", "d_chapel_57_5", Spot(133.14786, 304.7138, 30));
		AddSpawnPoint( "d_chapel_57_5.Id4", "d_chapel_57_5", Spot(333.62476, 413.48718, 30));
		AddSpawnPoint( "d_chapel_57_5.Id4", "d_chapel_57_5", Spot(593.42, 558.65, 30));

		// Yognome Spawn Points
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(-615.36, 975.53, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(-974.84, -189.77, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(-780.88, -155.57, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(-840.04, -815.03, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(-40.72, -780.77, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(570.49, -769.85, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(-31.54, -172.77, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(1019.38, 440.15, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(428.71, 385.58, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(-177.12, 542.74, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(-1580.7, 412.15, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(-922.9756, -60.36543, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(-785.8585, -68.70572, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(-858.59674, -291.42755, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(-976.0644, -703.46204, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(-970.15656, -888.1679, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(-757.1212, -918.0802, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(-745.8804, -732.2508, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(-89.66211, -836.50226, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(78.95902, -914.8701, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(75.09753, -651.3932, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(-134.86594, -699.57556, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(-165.00601, -905.0822, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(-122.31181, -223.39618, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(66.931854, -242.21437, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(69.11605, -62.06369, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(-119.56857, -69.68029, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(-255.50233, 376.57736, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(-151.9921, 239.36469, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(-75.51984, 478.29684, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(-90.42897, 371.5734, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(561.2217, 309.2919, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(591.2972, 504.0644, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(971.20557, 315.79822, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(962.1377, 495.61765, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(1131.8981, 507.57947, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(1137.1552, 331.95154, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(-715.7328, 869.04047, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(-693.85944, 1101.3899, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(-546.3081, 1092.7583, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(-543.002, 838.77, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(-1410.9585, 455.1721, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(-1545.7062, 582.0142, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(-1503.0488, 307.95093, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(348.18478, -40.5419, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(355.40427, -194.5473, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(519.8214, -173.0842, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(535.4255, -64.00519, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(180.89139, 266.88702, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(97.66434, 353.00812, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(273.80273, 379.4287, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(401.20993, 572.30286, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(398.85635, 211.08723, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(-143.74585, 892.26483, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(-86.9407, 1063.9006, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(187.96619, 924.639, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(176.80507, 1108.1887, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(58.85208, 939.68, 20));
		AddSpawnPoint( "d_chapel_57_5.Id5", "d_chapel_57_5", Spot(-205.21019, 1040.9565, 20));

		// Glizardon Spawn Points
		AddSpawnPoint( "d_chapel_57_5.Id6", "d_chapel_57_5", Spot(911.0638, 450.6159, 40));
		AddSpawnPoint( "d_chapel_57_5.Id6", "d_chapel_57_5", Spot(543.236, 399.32397, 40));
		AddSpawnPoint( "d_chapel_57_5.Id6", "d_chapel_57_5", Spot(191.62129, 258.72336, 40));

		// New_Desmodus Spawn Points
		AddSpawnPoint( "d_chapel_57_5.Id7", "d_chapel_57_5", Spot(-805.76, -767.78, 9999));
		AddSpawnPoint( "d_chapel_57_5.Id7", "d_chapel_57_5", Spot(-60.67, 417.57, 9999));

		// Glizardon Spawn Points
		AddSpawnPoint( "d_chapel_57_5.Id8", "d_chapel_57_5", Spot(-964.02, -751.63, 100));
		AddSpawnPoint( "d_chapel_57_5.Id8", "d_chapel_57_5", Spot(-844.3752, -898.0903, 100));
		AddSpawnPoint( "d_chapel_57_5.Id8", "d_chapel_57_5", Spot(-724.57, -753.38, 100));

	}
}
