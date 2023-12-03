//--- Melia Script -----------------------------------------------------------
// Magic Association Assembly Hall Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'ep14_2_d_castle_3'.
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

		AddPropertyOverrides("ep14_2_d_castle_3", MonsterId.Episode14_2_Bleakferret_Lancer, Properties("MHP", 24375000, "MINPATK", 110000, "MAXPATK", 110000, "MINMATK", 110000, "MAXMATK", 110000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("ep14_2_d_castle_3", MonsterId.Episode14_2_Bleakferret_Scout, Properties("MHP", 24375000, "MINPATK", 110000, "MAXPATK", 110000, "MINMATK", 110000, "MAXMATK", 110000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("ep14_2_d_castle_3", MonsterId.Episode14_2_Bleakferret_Strange, Properties("MHP", 24375000, "MINPATK", 110000, "MAXPATK", 110000, "MINMATK", 110000, "MAXMATK", 110000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("ep14_2_d_castle_3", MonsterId.Boss_TransmutationSpreader_Q1, Properties("MHP", 146250000, "MINPATK", 110000, "MAXPATK", 110000, "MINMATK", 110000, "MAXMATK", 110000, "DEF", 3000000, "MDEF", 3000000));

		// Monster Spawners ---------------------------------

		AddSpawner("ep14_2_d_castle_3.Id1", MonsterId.Episode14_2_Bleakferret_Strange, min: 19, max: 25, respawn: TimeSpan.FromMilliseconds(15000));
		AddSpawner("ep14_2_d_castle_3.Id2", MonsterId.Episode14_2_Bleakferret_Lancer, min: 23, max: 30, respawn: TimeSpan.FromMilliseconds(10000));
		AddSpawner("ep14_2_d_castle_3.Id3", MonsterId.Episode14_2_Bleakferret_Scout, min: 30, max: 40, respawn: TimeSpan.FromMilliseconds(10000));
		AddSpawner("ep14_2_d_castle_3.Id4", MonsterId.Rootcrystal_05, min: 3, max: 4, respawn: TimeSpan.FromMilliseconds(20000));

		// Monster Spawn Points -----------------------------

		// 'Episode14_2_Bleakferret_Strange' GenType 1001 Spawn Points
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(191, -747, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(461, -770, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(645, -408, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(654, -211, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(-88, -838, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(85, -842, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(-463, -788, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(-289, -893, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(-374, -842, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(-583, -200, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(-655, -254, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(-437, 162, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(-292, 277, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(363, 15, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(307, 273, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(-285, -198, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(-236, -134, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(300, -150, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(-243, -455, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(90, 321, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(-59, 1018, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id1", "ep14_2_d_castle_3", Rectangle(47, 1019, 20));

		// 'Episode14_2_Bleakferret_Lancer' GenType 1002 Spawn Points
		AddSpawnPoint("ep14_2_d_castle_3.Id2", "ep14_2_d_castle_3", Rectangle(352, -624, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id2", "ep14_2_d_castle_3", Rectangle(578, -306, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id2", "ep14_2_d_castle_3", Rectangle(318, 143, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id2", "ep14_2_d_castle_3", Rectangle(-309, 151, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id2", "ep14_2_d_castle_3", Rectangle(-476, -208, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id2", "ep14_2_d_castle_3", Rectangle(-1, -902, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id2", "ep14_2_d_castle_3", Rectangle(3, -735, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id2", "ep14_2_d_castle_3", Rectangle(-4, 251, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id2", "ep14_2_d_castle_3", Rectangle(-7, 818, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id2", "ep14_2_d_castle_3", Rectangle(-7, 1257, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id2", "ep14_2_d_castle_3", Rectangle(-5, 1374, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id2", "ep14_2_d_castle_3", Rectangle(-299, -442, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id2", "ep14_2_d_castle_3", Rectangle(-1, -552, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id2", "ep14_2_d_castle_3", Rectangle(228, -396, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id2", "ep14_2_d_castle_3", Rectangle(-621, -395, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id2", "ep14_2_d_castle_3", Rectangle(-318, -750, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id2", "ep14_2_d_castle_3", Rectangle(308, -885, 20));

		// 'Episode14_2_Bleakferret_Scout' GenType 1003 Spawn Points
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-121, -945, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-138, -868, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(137, -916, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(267, -795, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(374, -719, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(261, -659, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(457, -401, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(468, -201, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(560, -425, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(558, -181, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(511, -361, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(508, -257, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(258, -460, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(292, -385, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(264, -192, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(246, -119, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-261, -387, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-80, -602, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(77, -580, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-140, 318, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-103, 259, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(122, 358, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(84, 262, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-63, 18, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(66, 15, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(7, -35, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(238, 53, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(432, 119, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(413, 215, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(208, 150, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-378, -678, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-261, -676, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-224, -772, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-433, -414, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-501, -410, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-435, -348, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-393, 82, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-330, 10, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-220, 213, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-206, 101, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-56, 718, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(25, 718, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-11, 1073, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-72, 1544, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(54, 1544, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(-27, -1056, 20));
		AddSpawnPoint("ep14_2_d_castle_3.Id3", "ep14_2_d_castle_3", Rectangle(16, -1056, 20));

		// 'Rootcrystal_05' GenType 1004 Spawn Points
		AddSpawnPoint("ep14_2_d_castle_3.Id4", "ep14_2_d_castle_3", Rectangle(0, -540, 60));
		AddSpawnPoint("ep14_2_d_castle_3.Id4", "ep14_2_d_castle_3", Rectangle(-20, 42, 60));
		AddSpawnPoint("ep14_2_d_castle_3.Id4", "ep14_2_d_castle_3", Rectangle(-5, 793, 60));
		AddSpawnPoint("ep14_2_d_castle_3.Id4", "ep14_2_d_castle_3", Rectangle(-6, 1445, 60));
	}
}
