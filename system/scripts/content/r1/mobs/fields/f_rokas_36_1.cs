//--- Melia Script -----------------------------------------------------------
// Galeed Plateau Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_rokas_36_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FRokas361MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_rokas_36_1.Id1", MonsterId.Rootcrystal_05, min: 12, max: 15, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("f_rokas_36_1.Id2", MonsterId.Sec_Chupacabra_Desert, min: 15, max: 20);
		AddSpawner("f_rokas_36_1.Id3", MonsterId.GlyphRing, min: 23, max: 30);
		AddSpawner("f_rokas_36_1.Id4", MonsterId.Sec_Sauga, min: 23, max: 30);
		AddSpawner("f_rokas_36_1.Id5", MonsterId.Sec_Chupacabra_Desert, min: 15, max: 20);
		AddSpawner("f_rokas_36_1.Id6", MonsterId.Sec_Sauga, min: 12, max: 15);
		AddSpawner("f_rokas_36_1.Id7", MonsterId.GlyphRing, min: 12, max: 15);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_05' GenType 11 Spawn Points
		AddSpawnPoint("f_rokas_36_1.Id1", "f_rokas_36_1", Rectangle(-849, -183, 150));
		AddSpawnPoint("f_rokas_36_1.Id1", "f_rokas_36_1", Rectangle(-647, 223, 150));
		AddSpawnPoint("f_rokas_36_1.Id1", "f_rokas_36_1", Rectangle(-1189, 142, 150));
		AddSpawnPoint("f_rokas_36_1.Id1", "f_rokas_36_1", Rectangle(-629, 578, 150));
		AddSpawnPoint("f_rokas_36_1.Id1", "f_rokas_36_1", Rectangle(-306, -406, 150));
		AddSpawnPoint("f_rokas_36_1.Id1", "f_rokas_36_1", Rectangle(-45, 842, 150));
		AddSpawnPoint("f_rokas_36_1.Id1", "f_rokas_36_1", Rectangle(520, 141, 150));
		AddSpawnPoint("f_rokas_36_1.Id1", "f_rokas_36_1", Rectangle(801, -175, 150));
		AddSpawnPoint("f_rokas_36_1.Id1", "f_rokas_36_1", Rectangle(654, -679, 150));
		AddSpawnPoint("f_rokas_36_1.Id1", "f_rokas_36_1", Rectangle(680, 656, 150));
		AddSpawnPoint("f_rokas_36_1.Id1", "f_rokas_36_1", Rectangle(798, 1242, 150));
		AddSpawnPoint("f_rokas_36_1.Id1", "f_rokas_36_1", Rectangle(1267, 727, 150));
		AddSpawnPoint("f_rokas_36_1.Id1", "f_rokas_36_1", Rectangle(1103, 466, 150));
		AddSpawnPoint("f_rokas_36_1.Id1", "f_rokas_36_1", Rectangle(1293, 30, 150));
		AddSpawnPoint("f_rokas_36_1.Id1", "f_rokas_36_1", Rectangle(1595, 379, 150));

		// 'Sec_Chupacabra_Desert' GenType 36 Spawn Points
		AddSpawnPoint("f_rokas_36_1.Id2", "f_rokas_36_1", Rectangle(-40, 517, 9999));

		// 'GlyphRing' GenType 37 Spawn Points
		AddSpawnPoint("f_rokas_36_1.Id3", "f_rokas_36_1", Rectangle(1260, -133, 25));
		AddSpawnPoint("f_rokas_36_1.Id3", "f_rokas_36_1", Rectangle(1376, -43, 25));
		AddSpawnPoint("f_rokas_36_1.Id3", "f_rokas_36_1", Rectangle(1441, -126, 25));
		AddSpawnPoint("f_rokas_36_1.Id3", "f_rokas_36_1", Rectangle(1430, -225, 25));
		AddSpawnPoint("f_rokas_36_1.Id3", "f_rokas_36_1", Rectangle(1301, -234, 25));
		AddSpawnPoint("f_rokas_36_1.Id3", "f_rokas_36_1", Rectangle(1317, -325, 25));
		AddSpawnPoint("f_rokas_36_1.Id3", "f_rokas_36_1", Rectangle(1398, -318, 25));
		AddSpawnPoint("f_rokas_36_1.Id3", "f_rokas_36_1", Rectangle(482, -115, 25));
		AddSpawnPoint("f_rokas_36_1.Id3", "f_rokas_36_1", Rectangle(643, -143, 25));
		AddSpawnPoint("f_rokas_36_1.Id3", "f_rokas_36_1", Rectangle(739, -82, 25));
		AddSpawnPoint("f_rokas_36_1.Id3", "f_rokas_36_1", Rectangle(659, 10, 25));
		AddSpawnPoint("f_rokas_36_1.Id3", "f_rokas_36_1", Rectangle(434, 131, 25));
		AddSpawnPoint("f_rokas_36_1.Id3", "f_rokas_36_1", Rectangle(596, 168, 25));
		AddSpawnPoint("f_rokas_36_1.Id3", "f_rokas_36_1", Rectangle(748, 88, 25));
		AddSpawnPoint("f_rokas_36_1.Id3", "f_rokas_36_1", Rectangle(866, 57, 25));
		AddSpawnPoint("f_rokas_36_1.Id3", "f_rokas_36_1", Rectangle(881, -87, 25));
		AddSpawnPoint("f_rokas_36_1.Id3", "f_rokas_36_1", Rectangle(832, -189, 25));
		AddSpawnPoint("f_rokas_36_1.Id3", "f_rokas_36_1", Rectangle(980, -41, 25));
		AddSpawnPoint("f_rokas_36_1.Id3", "f_rokas_36_1", Rectangle(555, -7, 25));
		AddSpawnPoint("f_rokas_36_1.Id3", "f_rokas_36_1", Rectangle(520, -616, 25));
		AddSpawnPoint("f_rokas_36_1.Id3", "f_rokas_36_1", Rectangle(471, -722, 25));
		AddSpawnPoint("f_rokas_36_1.Id3", "f_rokas_36_1", Rectangle(547, -733, 25));
		AddSpawnPoint("f_rokas_36_1.Id3", "f_rokas_36_1", Rectangle(574, -775, 25));
		AddSpawnPoint("f_rokas_36_1.Id3", "f_rokas_36_1", Rectangle(618, -654, 25));
		AddSpawnPoint("f_rokas_36_1.Id3", "f_rokas_36_1", Rectangle(656, -757, 25));
		AddSpawnPoint("f_rokas_36_1.Id3", "f_rokas_36_1", Rectangle(1341, -193, 25));
		AddSpawnPoint("f_rokas_36_1.Id3", "f_rokas_36_1", Rectangle(1132, -48, 25));

		// 'Sec_Sauga' GenType 38 Spawn Points
		AddSpawnPoint("f_rokas_36_1.Id4", "f_rokas_36_1", Rectangle(688, 549, 30));
		AddSpawnPoint("f_rokas_36_1.Id4", "f_rokas_36_1", Rectangle(885, 682, 30));
		AddSpawnPoint("f_rokas_36_1.Id4", "f_rokas_36_1", Rectangle(791, 804, 30));
		AddSpawnPoint("f_rokas_36_1.Id4", "f_rokas_36_1", Rectangle(889, 934, 30));
		AddSpawnPoint("f_rokas_36_1.Id4", "f_rokas_36_1", Rectangle(718, 884, 30));
		AddSpawnPoint("f_rokas_36_1.Id4", "f_rokas_36_1", Rectangle(508, 593, 30));
		AddSpawnPoint("f_rokas_36_1.Id4", "f_rokas_36_1", Rectangle(1034, 801, 30));
		AddSpawnPoint("f_rokas_36_1.Id4", "f_rokas_36_1", Rectangle(761, 1265, 30));
		AddSpawnPoint("f_rokas_36_1.Id4", "f_rokas_36_1", Rectangle(882, 1276, 30));
		AddSpawnPoint("f_rokas_36_1.Id4", "f_rokas_36_1", Rectangle(807, 1208, 30));
		AddSpawnPoint("f_rokas_36_1.Id4", "f_rokas_36_1", Rectangle(1086, 490, 30));
		AddSpawnPoint("f_rokas_36_1.Id4", "f_rokas_36_1", Rectangle(1337, 368, 30));
		AddSpawnPoint("f_rokas_36_1.Id4", "f_rokas_36_1", Rectangle(1476, 384, 30));
		AddSpawnPoint("f_rokas_36_1.Id4", "f_rokas_36_1", Rectangle(1379, 224, 30));
		AddSpawnPoint("f_rokas_36_1.Id4", "f_rokas_36_1", Rectangle(1299, 213, 30));
		AddSpawnPoint("f_rokas_36_1.Id4", "f_rokas_36_1", Rectangle(1369, 319, 30));
		AddSpawnPoint("f_rokas_36_1.Id4", "f_rokas_36_1", Rectangle(1370, 747, 30));
		AddSpawnPoint("f_rokas_36_1.Id4", "f_rokas_36_1", Rectangle(1487, 858, 30));
		AddSpawnPoint("f_rokas_36_1.Id4", "f_rokas_36_1", Rectangle(1481, 707, 30));
		AddSpawnPoint("f_rokas_36_1.Id4", "f_rokas_36_1", Rectangle(1444, 744, 30));
		AddSpawnPoint("f_rokas_36_1.Id4", "f_rokas_36_1", Rectangle(1263, 659, 30));
		AddSpawnPoint("f_rokas_36_1.Id4", "f_rokas_36_1", Rectangle(602, 726, 30));
		AddSpawnPoint("f_rokas_36_1.Id4", "f_rokas_36_1", Rectangle(748, 747, 30));
		AddSpawnPoint("f_rokas_36_1.Id4", "f_rokas_36_1", Rectangle(902, 518, 30));
		AddSpawnPoint("f_rokas_36_1.Id4", "f_rokas_36_1", Rectangle(998, 577, 30));
		AddSpawnPoint("f_rokas_36_1.Id4", "f_rokas_36_1", Rectangle(910, 826, 30));
		AddSpawnPoint("f_rokas_36_1.Id4", "f_rokas_36_1", Rectangle(1313, 182, 30));
		AddSpawnPoint("f_rokas_36_1.Id4", "f_rokas_36_1", Rectangle(1223, 396, 30));
		AddSpawnPoint("f_rokas_36_1.Id4", "f_rokas_36_1", Rectangle(-162, 611, 30));
		AddSpawnPoint("f_rokas_36_1.Id4", "f_rokas_36_1", Rectangle(49, 632, 30));
		AddSpawnPoint("f_rokas_36_1.Id4", "f_rokas_36_1", Rectangle(47, 761, 30));
		AddSpawnPoint("f_rokas_36_1.Id4", "f_rokas_36_1", Rectangle(-173, 744, 30));
		AddSpawnPoint("f_rokas_36_1.Id4", "f_rokas_36_1", Rectangle(106, 395, 30));
		AddSpawnPoint("f_rokas_36_1.Id4", "f_rokas_36_1", Rectangle(80, 806, 30));
		AddSpawnPoint("f_rokas_36_1.Id4", "f_rokas_36_1", Rectangle(37, 568, 30));

		// 'Sec_Chupacabra_Desert' GenType 39 Spawn Points
		AddSpawnPoint("f_rokas_36_1.Id5", "f_rokas_36_1", Rectangle(109, 655, 30));
		AddSpawnPoint("f_rokas_36_1.Id5", "f_rokas_36_1", Rectangle(134, 795, 30));
		AddSpawnPoint("f_rokas_36_1.Id5", "f_rokas_36_1", Rectangle(186, 711, 30));
		AddSpawnPoint("f_rokas_36_1.Id5", "f_rokas_36_1", Rectangle(289, 676, 30));
		AddSpawnPoint("f_rokas_36_1.Id5", "f_rokas_36_1", Rectangle(196, 401, 30));
		AddSpawnPoint("f_rokas_36_1.Id5", "f_rokas_36_1", Rectangle(-93, 761, 30));
		AddSpawnPoint("f_rokas_36_1.Id5", "f_rokas_36_1", Rectangle(-116, 650, 30));
		AddSpawnPoint("f_rokas_36_1.Id5", "f_rokas_36_1", Rectangle(-119, 468, 30));
		AddSpawnPoint("f_rokas_36_1.Id5", "f_rokas_36_1", Rectangle(13, 916, 30));

		// 'Sec_Sauga' GenType 40 Spawn Points
		AddSpawnPoint("f_rokas_36_1.Id6", "f_rokas_36_1", Rectangle(-674, -56, 20));
		AddSpawnPoint("f_rokas_36_1.Id6", "f_rokas_36_1", Rectangle(-721, 139, 20));
		AddSpawnPoint("f_rokas_36_1.Id6", "f_rokas_36_1", Rectangle(-563, 44, 20));
		AddSpawnPoint("f_rokas_36_1.Id6", "f_rokas_36_1", Rectangle(-552, 241, 20));
		AddSpawnPoint("f_rokas_36_1.Id6", "f_rokas_36_1", Rectangle(-422, 124, 20));
		AddSpawnPoint("f_rokas_36_1.Id6", "f_rokas_36_1", Rectangle(-429, -46, 20));
		AddSpawnPoint("f_rokas_36_1.Id6", "f_rokas_36_1", Rectangle(-383, -397, 20));
		AddSpawnPoint("f_rokas_36_1.Id6", "f_rokas_36_1", Rectangle(-428, -536, 20));
		AddSpawnPoint("f_rokas_36_1.Id6", "f_rokas_36_1", Rectangle(-294, -503, 20));
		AddSpawnPoint("f_rokas_36_1.Id6", "f_rokas_36_1", Rectangle(-219, -448, 20));
		AddSpawnPoint("f_rokas_36_1.Id6", "f_rokas_36_1", Rectangle(-384, -489, 20));
		AddSpawnPoint("f_rokas_36_1.Id6", "f_rokas_36_1", Rectangle(-454, -438, 20));
		AddSpawnPoint("f_rokas_36_1.Id6", "f_rokas_36_1", Rectangle(-325, -598, 20));
		AddSpawnPoint("f_rokas_36_1.Id6", "f_rokas_36_1", Rectangle(-1093, -487, 20));
		AddSpawnPoint("f_rokas_36_1.Id6", "f_rokas_36_1", Rectangle(-967, -538, 20));
		AddSpawnPoint("f_rokas_36_1.Id6", "f_rokas_36_1", Rectangle(-895, -412, 20));
		AddSpawnPoint("f_rokas_36_1.Id6", "f_rokas_36_1", Rectangle(-980, -355, 20));
		AddSpawnPoint("f_rokas_36_1.Id6", "f_rokas_36_1", Rectangle(-1055, -406, 20));

		// 'GlyphRing' GenType 41 Spawn Points
		AddSpawnPoint("f_rokas_36_1.Id7", "f_rokas_36_1", Rectangle(-1138, -406, 25));
		AddSpawnPoint("f_rokas_36_1.Id7", "f_rokas_36_1", Rectangle(-926, -292, 25));
		AddSpawnPoint("f_rokas_36_1.Id7", "f_rokas_36_1", Rectangle(-867, -534, 25));
		AddSpawnPoint("f_rokas_36_1.Id7", "f_rokas_36_1", Rectangle(-1079, -545, 25));
		AddSpawnPoint("f_rokas_36_1.Id7", "f_rokas_36_1", Rectangle(-571, 85, 25));
		AddSpawnPoint("f_rokas_36_1.Id7", "f_rokas_36_1", Rectangle(-669, 10, 25));
		AddSpawnPoint("f_rokas_36_1.Id7", "f_rokas_36_1", Rectangle(-558, -51, 25));
		AddSpawnPoint("f_rokas_36_1.Id7", "f_rokas_36_1", Rectangle(-434, 34, 25));
		AddSpawnPoint("f_rokas_36_1.Id7", "f_rokas_36_1", Rectangle(-426, 170, 25));
		AddSpawnPoint("f_rokas_36_1.Id7", "f_rokas_36_1", Rectangle(-764, 610, 25));
		AddSpawnPoint("f_rokas_36_1.Id7", "f_rokas_36_1", Rectangle(-824, 648, 25));
		AddSpawnPoint("f_rokas_36_1.Id7", "f_rokas_36_1", Rectangle(-745, 714, 25));
		AddSpawnPoint("f_rokas_36_1.Id7", "f_rokas_36_1", Rectangle(-741, 655, 25));
		AddSpawnPoint("f_rokas_36_1.Id7", "f_rokas_36_1", Rectangle(-682, 608, 25));
		AddSpawnPoint("f_rokas_36_1.Id7", "f_rokas_36_1", Rectangle(-693, 748, 25));
		AddSpawnPoint("f_rokas_36_1.Id7", "f_rokas_36_1", Rectangle(-1137, 211, 25));
		AddSpawnPoint("f_rokas_36_1.Id7", "f_rokas_36_1", Rectangle(-1081, 149, 25));
		AddSpawnPoint("f_rokas_36_1.Id7", "f_rokas_36_1", Rectangle(-1126, 58, 25));
		AddSpawnPoint("f_rokas_36_1.Id7", "f_rokas_36_1", Rectangle(-1224, 103, 25));
		AddSpawnPoint("f_rokas_36_1.Id7", "f_rokas_36_1", Rectangle(-1200, 188, 25));
		AddSpawnPoint("f_rokas_36_1.Id7", "f_rokas_36_1", Rectangle(-1072, 81, 25));
	}
}
