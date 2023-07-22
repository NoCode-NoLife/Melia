//--- Melia Script -----------------------------------------------------------
// Penitence Route Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_pilgrimroad_55'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FPilgrimroad55MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_pilgrimroad_55", MonsterId.Infro_Blud_Red, Properties("MHP", 153552, "MINPATK", 2476, "MAXPATK", 2945, "MINMATK", 2476, "MAXMATK", 2945, "DEF", 3638, "MDEF", 3638));
		AddPropertyOverrides("f_pilgrimroad_55", MonsterId.InfroHoglan_Red, Properties("MHP", 155431, "MINPATK", 2500, "MAXPATK", 2974, "MINMATK", 2500, "MAXMATK", 2974, "DEF", 3747, "MDEF", 3747));
		AddPropertyOverrides("f_pilgrimroad_55", MonsterId.Burialer, Properties("MHP", 157350, "MINPATK", 2525, "MAXPATK", 3005, "MINMATK", 2525, "MAXMATK", 3005, "DEF", 3857, "MDEF", 3857));

		// Monster Spawners ---------------------------------

		AddSpawner("f_pilgrimroad_55.Id1", MonsterId.Infro_Blud_Red, min: 23, max: 30);
		AddSpawner("f_pilgrimroad_55.Id2", MonsterId.InfroHoglan_Red, min: 23, max: 30);
		AddSpawner("f_pilgrimroad_55.Id3", MonsterId.Rootcrystal_03, min: 9, max: 12, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("f_pilgrimroad_55.Id4", MonsterId.Infro_Blud_Red, min: 6, max: 7);
		AddSpawner("f_pilgrimroad_55.Id5", MonsterId.Burialer, min: 6, max: 7);

		// Monster Spawn Points -----------------------------

		// 'Infro_Blud_Red' GenType 4 Spawn Points
		AddSpawnPoint("f_pilgrimroad_55.Id1", "f_pilgrimroad_55", Rectangle(-723, 189, 9999));

		// 'InfroHoglan_Red' GenType 8 Spawn Points
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(1331, -129, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(383, -382, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(975, -709, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(790, -456, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(1059, -660, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(703, -483, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(1291, -307, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(1495, -187, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(472, -403, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(1432, -514, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(1394, -224, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(1450, -68, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(1264, -196, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(1491, -364, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(1323, -387, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(1195, -319, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(1247, -736, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(1134, -731, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(1022, -561, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(942, -522, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(852, -655, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(865, -456, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(750, -683, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(798, -580, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(991, -433, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(1136, -481, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(1189, -638, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(1430, -643, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(1268, -536, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(1089, -388, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(666, -667, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(559, -637, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(563, -556, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(625, -499, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(464, -634, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(472, -510, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(232, -597, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(172, -520, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(355, -624, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(275, -669, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(273, -484, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(129, -297, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(36, -145, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(209, -263, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-13, -62, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(33, -346, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-224, -465, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-236, -147, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-56, -328, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-104, -112, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-120, 14, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-151, -263, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-338, -180, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-423, -285, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-490, -400, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-422, -527, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-338, -528, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-370, -71, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-247, -768, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-165, -769, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-167, -660, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-289, -633, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-18, -625, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(78, -413, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(22, -497, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-154, -549, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-70, -443, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(113, -502, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-286, -400, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-228, -605, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-616, -18, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-749, -82, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-515, 101, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-870, -95, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-919, 6, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-509, 221, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-737, 313, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-982, 88, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-813, 180, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-1038, 205, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-1090, 259, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-1006, 320, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-399, 332, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-715, 468, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-841, 357, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-538, 446, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-626, 363, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-607, 530, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-437, 602, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(-416, 458, 30));
		AddSpawnPoint("f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Rectangle(550, -405, 30));

		// 'Rootcrystal_03' GenType 28 Spawn Points
		AddSpawnPoint("f_pilgrimroad_55.Id3", "f_pilgrimroad_55", Rectangle(1523, -180, 10));
		AddSpawnPoint("f_pilgrimroad_55.Id3", "f_pilgrimroad_55", Rectangle(1357, -514, 10));
		AddSpawnPoint("f_pilgrimroad_55.Id3", "f_pilgrimroad_55", Rectangle(957, -564, 10));
		AddSpawnPoint("f_pilgrimroad_55.Id3", "f_pilgrimroad_55", Rectangle(1094, -696, 10));
		AddSpawnPoint("f_pilgrimroad_55.Id3", "f_pilgrimroad_55", Rectangle(594, -609, 10));
		AddSpawnPoint("f_pilgrimroad_55.Id3", "f_pilgrimroad_55", Rectangle(237, -357, 10));
		AddSpawnPoint("f_pilgrimroad_55.Id3", "f_pilgrimroad_55", Rectangle(-233, -404, 10));
		AddSpawnPoint("f_pilgrimroad_55.Id3", "f_pilgrimroad_55", Rectangle(7, -158, 10));
		AddSpawnPoint("f_pilgrimroad_55.Id3", "f_pilgrimroad_55", Rectangle(-414, 294, 10));
		AddSpawnPoint("f_pilgrimroad_55.Id3", "f_pilgrimroad_55", Rectangle(-727, 110, 10));
		AddSpawnPoint("f_pilgrimroad_55.Id3", "f_pilgrimroad_55", Rectangle(-649, 363, 10));
		AddSpawnPoint("f_pilgrimroad_55.Id3", "f_pilgrimroad_55", Rectangle(-499, 613, 10));

		// 'Infro_Blud_Red' GenType 30 Spawn Points
		AddSpawnPoint("f_pilgrimroad_55.Id4", "f_pilgrimroad_55", Rectangle(-70, -553, 35));
		AddSpawnPoint("f_pilgrimroad_55.Id4", "f_pilgrimroad_55", Rectangle(-288, -275, 35));
		AddSpawnPoint("f_pilgrimroad_55.Id4", "f_pilgrimroad_55", Rectangle(53, -242, 35));
		AddSpawnPoint("f_pilgrimroad_55.Id4", "f_pilgrimroad_55", Rectangle(372, -508, 35));
		AddSpawnPoint("f_pilgrimroad_55.Id4", "f_pilgrimroad_55", Rectangle(-258, -679, 35));
		AddSpawnPoint("f_pilgrimroad_55.Id4", "f_pilgrimroad_55", Rectangle(194, -389, 35));

		// 'Burialer' GenType 43 Spawn Points
		AddSpawnPoint("f_pilgrimroad_55.Id5", "f_pilgrimroad_55", Rectangle(-644, 280, 25));
		AddSpawnPoint("f_pilgrimroad_55.Id5", "f_pilgrimroad_55", Rectangle(-885, 240, 25));
		AddSpawnPoint("f_pilgrimroad_55.Id5", "f_pilgrimroad_55", Rectangle(-255, -20, 25));
		AddSpawnPoint("f_pilgrimroad_55.Id5", "f_pilgrimroad_55", Rectangle(-794, 52, 25));
		AddSpawnPoint("f_pilgrimroad_55.Id5", "f_pilgrimroad_55", Rectangle(-558, 648, 25));
		AddSpawnPoint("f_pilgrimroad_55.Id5", "f_pilgrimroad_55", Rectangle(-392, -389, 25));
		AddSpawnPoint("f_pilgrimroad_55.Id5", "f_pilgrimroad_55", Rectangle(122, -190, 25));
	}
}
