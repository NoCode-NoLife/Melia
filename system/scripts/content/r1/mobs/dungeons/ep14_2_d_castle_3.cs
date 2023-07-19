//--- Melia Script -----------------------------------------------------------
// ep14_2_d_castle_3
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Magic Association Assembly Hall' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class Ep142DCastle3MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("ep14_2_d_castle_3", MonsterId.Episode14_2_Bleakferret_Lancer, Properties("MHP", 48750000, "MINPATK", 110000, "MAXPATK", 110000, "MINMATK", 110000, "MAXMATK", 110000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("ep14_2_d_castle_3", MonsterId.Episode14_2_Bleakferret_Scout, Properties("MHP", 48750000, "MINPATK", 110000, "MAXPATK", 110000, "MINMATK", 110000, "MAXMATK", 110000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("ep14_2_d_castle_3", MonsterId.Episode14_2_Bleakferret_Strange, Properties("MHP", 48750000, "MINPATK", 110000, "MAXPATK", 110000, "MINMATK", 110000, "MAXMATK", 110000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("ep14_2_d_castle_3", MonsterId.Boss_TransmutationSpreader_Q1, Properties("MHP", 146250000, "MINPATK", 110000, "MAXPATK", 110000, "MINMATK", 110000, "MAXMATK", 110000, "DEF", 3000000, "MDEF", 3000000));

		// Monster Spawners ---------------------------------

		AddSpawner("ep14_2_d_castle_3.Id1", MonsterId.Episode14_2_Bleakferret_Strange, 19, 25, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("ep14_2_d_castle_3.Id2", MonsterId.Episode14_2_Bleakferret_Lancer, 23, 30, TimeSpan.FromMilliseconds(10000), TendencyType.Peaceful);
		AddSpawner("ep14_2_d_castle_3.Id3", MonsterId.Episode14_2_Bleakferret_Scout, 30, 40, TimeSpan.FromMilliseconds(10000), TendencyType.Peaceful);
		AddSpawner("ep14_2_d_castle_3.Id4", MonsterId.Rootcrystal_05, 3, 4, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Episode14_2_Bleakferret_Strange' GenType 1001 Spawn Points
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(191.28607, -747.67505, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(461.39142, -770.0078, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(645.3933, -408.0452, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(654.502, -211.67255, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(-88.65379, -838.92145, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(85.6475, -842.1991, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(-463.05066, -788.3634, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(-289.81177, -893.0289, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(-374.13742, -842.7897, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(-583.9868, -200.97537, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(-655.6146, -254.3136, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(-437.44727, 162.5008, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(-292.09164, 277.42914, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(363.31815, 15.389431, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(307.31116, 273.32034, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(-285.62323, -198.8446, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(-236.8927, -134.94485, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(300.1256, -150.73659, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(-243.7937, -455.72662, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(90.5738, 321.1657, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(-59.871193, 1018.1099, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(47.231472, 1019.9437, 20));

		// 'Episode14_2_Bleakferret_Lancer' GenType 1002 Spawn Points
		AddSpawnPoint("ep14_2_d_castle_3.Id2", "ep14_2_d_castle_3", Rectangle(352.5692, -624.51227, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id2", "ep14_2_d_castle_3", Rectangle(578.6742, -306.54263, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id2", "ep14_2_d_castle_3", Rectangle(318.27878, 143.65761, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id2", "ep14_2_d_castle_3", Rectangle(-309.1608, 151.37302, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id2", "ep14_2_d_castle_3", Rectangle(-476.58612, -208.26468, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id2", "ep14_2_d_castle_3", Rectangle(-1.7865334, -902.8186, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id2", "ep14_2_d_castle_3", Rectangle(3.8764257, -735.401, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id2", "ep14_2_d_castle_3", Rectangle(-4.940529, 251.33868, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id2", "ep14_2_d_castle_3", Rectangle(-7.0066786, 818.2737, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id2", "ep14_2_d_castle_3", Rectangle(-7.5143433, 1257.0764, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id2", "ep14_2_d_castle_3", Rectangle(-5.5110703, 1374.9915, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id2", "ep14_2_d_castle_3", Rectangle(-299.25415, -442.23123, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id2", "ep14_2_d_castle_3", Rectangle(-1.1241932, -552.0415, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id2", "ep14_2_d_castle_3", Rectangle(228.24965, -396.17905, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id2", "ep14_2_d_castle_3", Rectangle(-621.5014, -395.01907, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id2", "ep14_2_d_castle_3", Rectangle(-318.0961, -750.5872, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id2", "ep14_2_d_castle_3", Rectangle(308.0867, -885.449, 20));

		// 'Episode14_2_Bleakferret_Scout' GenType 1003 Spawn Points
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-121.58868, -945.15717, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-138.6718, -868.8807, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(137.46481, -916.8037, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(267.10394, -795.08826, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(374.08154, -719.08594, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(261.754, -659.58246, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(457.2542, -401.21313, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(468.2886, -201.2482, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(560.5169, -425.19827, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(558.52313, -181.82364, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(511.74274, -361.1722, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(508.79767, -257.6803, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(258.9646, -460.05304, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(292.49078, -385.47742, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(264.99478, -192.42102, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(246.82628, -119.37023, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-261.04233, -387.42664, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-80.09978, -602.3369, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(77.3392, -580.6805, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-140.50198, 318.40134, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-103.37953, 259.57275, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(122.38877, 358.7878, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(84.31776, 262.4849, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-63.759743, 18.930708, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(66.38339, 15.608913, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(7.0457153, -35.711346, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(238.25194, 53.965282, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(432.12036, 119.06873, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(413.81888, 215.35265, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(208.33374, 150.08195, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-378.5246, -678.13257, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-261.5023, -676.2148, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-224.04749, -772.8152, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-433.77264, -414.99725, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-501.645, -410.48868, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-435.08392, -348.45718, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-393.56094, 82.45714, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-330.6902, 10.303337, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-220.21613, 213.20782, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-206.75552, 101.67018, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-56.223495, 718.4056, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(25.91451, 718.5981, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-11.317047, 1073.8433, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-72.77711, 1544.5573, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(54.357033, 1544.8927, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-27.878407, -1056.2858, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(16.910114, -1056.4088, 20));

		// 'Rootcrystal_05' GenType 1004 Spawn Points
		AddSpawnPoint("ep14_2_d_castle_3.Id4", "ep14_2_d_castle_3", Rectangle(-0.7053089, -540.4151, 60));
		AddSpawnPoint("ep14_2_d_castle_3.Id4", "ep14_2_d_castle_3", Rectangle(-20.290714, 42.420418, 60));
		AddSpawnPoint("ep14_2_d_castle_3.Id4", "ep14_2_d_castle_3", Rectangle(-5.539756, 793.40454, 60));
		AddSpawnPoint("ep14_2_d_castle_3.Id4", "ep14_2_d_castle_3", Rectangle(-6.750351, 1445.986, 60));
	}
}
