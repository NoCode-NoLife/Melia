//--- Melia Script -----------------------------------------------------------
// Tenet Church B1 Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_chapel_57_5'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DChapel575MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_chapel_57_5", MonsterId.Yognome, Properties("MHP", 19651, "MINPATK", 754, "MAXPATK", 828, "MINMATK", 754, "MAXMATK", 828, "DEF", 72, "MDEF", 72));
		AddPropertyOverrides("d_chapel_57_5", MonsterId.Zombiegirl2_Chpel, Properties("MHP", 20048, "MINPATK", 759, "MAXPATK", 834, "MINMATK", 759, "MAXMATK", 834, "DEF", 72, "MDEF", 72));
		AddPropertyOverrides("d_chapel_57_5", MonsterId.Glizardon, Properties("MHP", 20454, "MINPATK", 764, "MAXPATK", 841, "MINMATK", 764, "MAXMATK", 841, "DEF", 72, "MDEF", 72));
		AddPropertyOverrides("d_chapel_57_5", MonsterId.New_Desmodus, Properties("MHP", 20867, "MINPATK", 769, "MAXPATK", 847, "MINMATK", 769, "MAXMATK", 847, "DEF", 73, "MDEF", 73));
		AddPropertyOverrides("d_chapel_57_5", MonsterId.Boss_Unknocker, Properties("MHP", 98343, "MINPATK", 1487, "MAXPATK", 1640, "MINMATK", 1487, "MAXMATK", 1640, "DEF", 140, "MDEF", 140));
		AddPropertyOverrides("d_chapel_57_5", MonsterId.Boss_Strongholder_Q1, Properties("MHP", 100316, "MINPATK", 1498, "MAXPATK", 1653, "MINMATK", 1498, "MAXMATK", 1653, "DEF", 141, "MDEF", 141));

		// Monster Spawners ---------------------------------

		AddSpawner("d_chapel_57_5.Id1", MonsterId.Yognome, min: 15, max: 20, tendency: TendencyType.Aggressive);
		AddSpawner("d_chapel_57_5.Id2", MonsterId.Rootcrystal_01, min: 12, max: 15, respawn: TimeSpan.FromMilliseconds(30000), tendency: TendencyType.Peaceful);
		AddSpawner("d_chapel_57_5.Id3", MonsterId.Zombiegirl2_Chpel, min: 15, max: 20, tendency: TendencyType.Aggressive);
		AddSpawner("d_chapel_57_5.Id4", MonsterId.Zombiegirl2_Chpel, min: 23, max: 30, tendency: TendencyType.Aggressive);
		AddSpawner("d_chapel_57_5.Id5", MonsterId.Yognome, min: 27, max: 35, tendency: TendencyType.Aggressive);
		AddSpawner("d_chapel_57_5.Id6", MonsterId.Glizardon, amount: 3, tendency: TendencyType.Aggressive);
		AddSpawner("d_chapel_57_5.Id7", MonsterId.New_Desmodus, min: 27, max: 35, tendency: TendencyType.Aggressive);
		AddSpawner("d_chapel_57_5.Id8", MonsterId.Glizardon, amount: 3, tendency: TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Yognome' GenType 17 Spawn Points
		AddSpawnPoint("d_chapel_57_5.Id1", "d_chapel_57_5", Rectangle(-47, -111, 9999));

		// 'Rootcrystal_01' GenType 19 Spawn Points
		AddSpawnPoint("d_chapel_57_5.Id2", "d_chapel_57_5", Rectangle(-1282, 1035, 200));
		AddSpawnPoint("d_chapel_57_5.Id2", "d_chapel_57_5", Rectangle(-635, 976, 200));
		AddSpawnPoint("d_chapel_57_5.Id2", "d_chapel_57_5", Rectangle(-1465, 409, 200));
		AddSpawnPoint("d_chapel_57_5.Id2", "d_chapel_57_5", Rectangle(-746, 392, 200));
		AddSpawnPoint("d_chapel_57_5.Id2", "d_chapel_57_5", Rectangle(47, 1007, 200));
		AddSpawnPoint("d_chapel_57_5.Id2", "d_chapel_57_5", Rectangle(-90, 460, 200));
		AddSpawnPoint("d_chapel_57_5.Id2", "d_chapel_57_5", Rectangle(381, 420, 200));
		AddSpawnPoint("d_chapel_57_5.Id2", "d_chapel_57_5", Rectangle(1033, 443, 200));
		AddSpawnPoint("d_chapel_57_5.Id2", "d_chapel_57_5", Rectangle(499, -30, 200));
		AddSpawnPoint("d_chapel_57_5.Id2", "d_chapel_57_5", Rectangle(-55, -152, 200));
		AddSpawnPoint("d_chapel_57_5.Id2", "d_chapel_57_5", Rectangle(-828, -162, 200));
		AddSpawnPoint("d_chapel_57_5.Id2", "d_chapel_57_5", Rectangle(-153, -708, 200));
		AddSpawnPoint("d_chapel_57_5.Id2", "d_chapel_57_5", Rectangle(-815, -793, 200));
		AddSpawnPoint("d_chapel_57_5.Id2", "d_chapel_57_5", Rectangle(470, -739, 200));
		AddSpawnPoint("d_chapel_57_5.Id2", "d_chapel_57_5", Rectangle(43, -880, 200));
		AddSpawnPoint("d_chapel_57_5.Id2", "d_chapel_57_5", Rectangle(787, -725, 200));
		AddSpawnPoint("d_chapel_57_5.Id2", "d_chapel_57_5", Rectangle(599, 449, 200));
		AddSpawnPoint("d_chapel_57_5.Id2", "d_chapel_57_5", Rectangle(-441, 443, 200));
		AddSpawnPoint("d_chapel_57_5.Id2", "d_chapel_57_5", Rectangle(-1007, 402, 200));

		// 'Zombiegirl2_Chpel' GenType 20 Spawn Points
		AddSpawnPoint("d_chapel_57_5.Id3", "d_chapel_57_5", Rectangle(-105, -169, 9999));

		// 'Zombiegirl2_Chpel' GenType 21 Spawn Points
		AddSpawnPoint("d_chapel_57_5.Id4", "d_chapel_57_5", Rectangle(-181, 885, 30));
		AddSpawnPoint("d_chapel_57_5.Id4", "d_chapel_57_5", Rectangle(-200, 997, 30));
		AddSpawnPoint("d_chapel_57_5.Id4", "d_chapel_57_5", Rectangle(-135, -71, 30));
		AddSpawnPoint("d_chapel_57_5.Id4", "d_chapel_57_5", Rectangle(75, 924, 30));
		AddSpawnPoint("d_chapel_57_5.Id4", "d_chapel_57_5", Rectangle(197, 1020, 30));
		AddSpawnPoint("d_chapel_57_5.Id4", "d_chapel_57_5", Rectangle(13, 1071, 30));
		AddSpawnPoint("d_chapel_57_5.Id4", "d_chapel_57_5", Rectangle(56, -97, 30));
		AddSpawnPoint("d_chapel_57_5.Id4", "d_chapel_57_5", Rectangle(203, 886, 30));
		AddSpawnPoint("d_chapel_57_5.Id4", "d_chapel_57_5", Rectangle(-791, -186, 30));
		AddSpawnPoint("d_chapel_57_5.Id4", "d_chapel_57_5", Rectangle(-1017, -173, 30));
		AddSpawnPoint("d_chapel_57_5.Id4", "d_chapel_57_5", Rectangle(-904, -81, 30));
		AddSpawnPoint("d_chapel_57_5.Id4", "d_chapel_57_5", Rectangle(-719, -100, 30));
		AddSpawnPoint("d_chapel_57_5.Id4", "d_chapel_57_5", Rectangle(-927, -244, 30));
		AddSpawnPoint("d_chapel_57_5.Id4", "d_chapel_57_5", Rectangle(-693, -814, 30));
		AddSpawnPoint("d_chapel_57_5.Id4", "d_chapel_57_5", Rectangle(-851, -899, 30));
		AddSpawnPoint("d_chapel_57_5.Id4", "d_chapel_57_5", Rectangle(-966, -824, 30));
		AddSpawnPoint("d_chapel_57_5.Id4", "d_chapel_57_5", Rectangle(-832, -762, 30));
		AddSpawnPoint("d_chapel_57_5.Id4", "d_chapel_57_5", Rectangle(-149, -791, 30));
		AddSpawnPoint("d_chapel_57_5.Id4", "d_chapel_57_5", Rectangle(-21, -878, 30));
		AddSpawnPoint("d_chapel_57_5.Id4", "d_chapel_57_5", Rectangle(41, -731, 30));
		AddSpawnPoint("d_chapel_57_5.Id4", "d_chapel_57_5", Rectangle(-80, -663, 30));
		AddSpawnPoint("d_chapel_57_5.Id4", "d_chapel_57_5", Rectangle(-61, -205, 30));
		AddSpawnPoint("d_chapel_57_5.Id4", "d_chapel_57_5", Rectangle(-1475, 403, 30));
		AddSpawnPoint("d_chapel_57_5.Id4", "d_chapel_57_5", Rectangle(-1429, 343, 30));
		AddSpawnPoint("d_chapel_57_5.Id4", "d_chapel_57_5", Rectangle(-1500, 613, 30));
		AddSpawnPoint("d_chapel_57_5.Id4", "d_chapel_57_5", Rectangle(-1399, 498, 30));
		AddSpawnPoint("d_chapel_57_5.Id4", "d_chapel_57_5", Rectangle(1141, 430, 30));
		AddSpawnPoint("d_chapel_57_5.Id4", "d_chapel_57_5", Rectangle(985, 316, 30));
		AddSpawnPoint("d_chapel_57_5.Id4", "d_chapel_57_5", Rectangle(972, 488, 30));
		AddSpawnPoint("d_chapel_57_5.Id4", "d_chapel_57_5", Rectangle(671, 432, 30));
		AddSpawnPoint("d_chapel_57_5.Id4", "d_chapel_57_5", Rectangle(567, 322, 30));
		AddSpawnPoint("d_chapel_57_5.Id4", "d_chapel_57_5", Rectangle(391, 257, 30));
		AddSpawnPoint("d_chapel_57_5.Id4", "d_chapel_57_5", Rectangle(133, 304, 30));
		AddSpawnPoint("d_chapel_57_5.Id4", "d_chapel_57_5", Rectangle(333, 413, 30));
		AddSpawnPoint("d_chapel_57_5.Id4", "d_chapel_57_5", Rectangle(593, 558, 30));

		// 'Yognome' GenType 22 Spawn Points
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(-615, 975, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(-974, -189, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(-780, -155, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(-840, -815, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(-40, -780, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(570, -769, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(-31, -172, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(1019, 440, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(428, 385, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(-177, 542, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(-1580, 412, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(-922, -60, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(-785, -68, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(-858, -291, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(-976, -703, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(-970, -888, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(-757, -918, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(-745, -732, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(-89, -836, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(78, -914, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(75, -651, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(-134, -699, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(-165, -905, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(-122, -223, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(66, -242, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(69, -62, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(-119, -69, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(-255, 376, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(-151, 239, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(-75, 478, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(-90, 371, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(561, 309, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(591, 504, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(971, 315, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(962, 495, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(1131, 507, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(1137, 331, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(-715, 869, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(-693, 1101, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(-546, 1092, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(-543, 838, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(-1410, 455, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(-1545, 582, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(-1503, 307, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(348, -40, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(355, -194, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(519, -173, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(535, -64, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(180, 266, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(97, 353, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(273, 379, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(401, 572, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(398, 211, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(-143, 892, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(-86, 1063, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(187, 924, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(176, 1108, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(58, 939, 20));
		AddSpawnPoint("d_chapel_57_5.Id5", "d_chapel_57_5", Rectangle(-205, 1040, 20));

		// 'Glizardon' GenType 28 Spawn Points
		AddSpawnPoint("d_chapel_57_5.Id6", "d_chapel_57_5", Rectangle(911, 450, 40));
		AddSpawnPoint("d_chapel_57_5.Id6", "d_chapel_57_5", Rectangle(543, 399, 40));
		AddSpawnPoint("d_chapel_57_5.Id6", "d_chapel_57_5", Rectangle(191, 258, 40));

		// 'New_Desmodus' GenType 30 Spawn Points
		AddSpawnPoint("d_chapel_57_5.Id7", "d_chapel_57_5", Rectangle(-805, -767, 9999));
		AddSpawnPoint("d_chapel_57_5.Id7", "d_chapel_57_5", Rectangle(-60, 417, 9999));

		// 'Glizardon' GenType 32 Spawn Points
		AddSpawnPoint("d_chapel_57_5.Id8", "d_chapel_57_5", Rectangle(-964, -751, 100));
		AddSpawnPoint("d_chapel_57_5.Id8", "d_chapel_57_5", Rectangle(-844, -898, 100));
		AddSpawnPoint("d_chapel_57_5.Id8", "d_chapel_57_5", Rectangle(-724, -753, 100));
	}
}
