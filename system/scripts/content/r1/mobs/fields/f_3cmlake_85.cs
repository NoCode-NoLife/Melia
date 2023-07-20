//--- Melia Script -----------------------------------------------------------
// Barynwell 85 Waters Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_3cmlake_85'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class F3Cmlake85MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_3cmlake_85", MonsterId.Lotuscat, Properties("MHP", 595945, "MINPATK", 8164, "MAXPATK", 9936, "MINMATK", 8164, "MAXMATK", 9936, "DEF", 125381, "MDEF", 125381));
		AddPropertyOverrides("f_3cmlake_85", MonsterId.Pate, Properties("MHP", 596169, "MINPATK", 8167, "MAXPATK", 9940, "MINMATK", 8167, "MAXMATK", 9940, "DEF", 125515, "MDEF", 125515));
		AddPropertyOverrides("f_3cmlake_85", MonsterId.KindronLeader, Properties("MHP", 596578, "MINPATK", 8172, "MAXPATK", 9946, "MINMATK", 8172, "MAXMATK", 9946, "DEF", 125760, "MDEF", 125760));
		AddPropertyOverrides("f_3cmlake_85", MonsterId.Coterie, Properties("MHP", 597107, "MINPATK", 8179, "MAXPATK", 9954, "MINMATK", 8179, "MAXMATK", 9954, "DEF", 126077, "MDEF", 126077));
		AddPropertyOverrides("f_3cmlake_85", MonsterId.Tripy, Properties("MHP", 597735, "MINPATK", 8187, "MAXPATK", 9964, "MINMATK", 8187, "MAXMATK", 9964, "DEF", 126453, "MDEF", 126453));
		AddPropertyOverrides("f_3cmlake_85", MonsterId.Boss_Hydra_Q2, Properties("MHP", 3123888, "MINPATK", 20654, "MAXPATK", 25138, "MINMATK", 20654, "MAXMATK", 25138, "DEF", 319734, "MDEF", 319734));

		// Monster Spawners ---------------------------------

		AddSpawner("f_3cmlake_85.Id1", MonsterId.Lotuscat, 14, 18, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_85.Id2", MonsterId.Pate, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_85.Id3", MonsterId.Pate, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_85.Id4", MonsterId.KindronLeader, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_85.Id5", MonsterId.Coterie, 17, 22, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_85.Id6", MonsterId.Coterie, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_85.Id7", MonsterId.Tripy, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_85.Id8", MonsterId.Tripy, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_85.Id9", MonsterId.Rootcrystal_02, 23, 30, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Lotuscat' GenType 31 Spawn Points
		AddSpawnPoint("f_3cmlake_85.Id1", "f_3cmlake_85", Rectangle(-470, -236, 50));
		AddSpawnPoint("f_3cmlake_85.Id1", "f_3cmlake_85", Rectangle(-406, -71, 50));
		AddSpawnPoint("f_3cmlake_85.Id1", "f_3cmlake_85", Rectangle(-262, 71, 50));
		AddSpawnPoint("f_3cmlake_85.Id1", "f_3cmlake_85", Rectangle(2, -41, 50));
		AddSpawnPoint("f_3cmlake_85.Id1", "f_3cmlake_85", Rectangle(-258, -277, 50));
		AddSpawnPoint("f_3cmlake_85.Id1", "f_3cmlake_85", Rectangle(-19, -238, 50));
		AddSpawnPoint("f_3cmlake_85.Id1", "f_3cmlake_85", Rectangle(-138, 355, 50));
		AddSpawnPoint("f_3cmlake_85.Id1", "f_3cmlake_85", Rectangle(-257, 647, 50));
		AddSpawnPoint("f_3cmlake_85.Id1", "f_3cmlake_85", Rectangle(48, 425, 50));
		AddSpawnPoint("f_3cmlake_85.Id1", "f_3cmlake_85", Rectangle(82, 621, 50));
		AddSpawnPoint("f_3cmlake_85.Id1", "f_3cmlake_85", Rectangle(-392, 1322, 50));
		AddSpawnPoint("f_3cmlake_85.Id1", "f_3cmlake_85", Rectangle(-202, 1148, 50));
		AddSpawnPoint("f_3cmlake_85.Id1", "f_3cmlake_85", Rectangle(-135, 1463, 50));
		AddSpawnPoint("f_3cmlake_85.Id1", "f_3cmlake_85", Rectangle(125, 1255, 50));
		AddSpawnPoint("f_3cmlake_85.Id1", "f_3cmlake_85", Rectangle(523, 1206, 50));
		AddSpawnPoint("f_3cmlake_85.Id1", "f_3cmlake_85", Rectangle(632, 1424, 50));
		AddSpawnPoint("f_3cmlake_85.Id1", "f_3cmlake_85", Rectangle(766, 1241, 50));
		AddSpawnPoint("f_3cmlake_85.Id1", "f_3cmlake_85", Rectangle(-335, 501, 50));

		// 'Pate' GenType 33 Spawn Points
		AddSpawnPoint("f_3cmlake_85.Id2", "f_3cmlake_85", Rectangle(-166, -122, 9999));

		// 'Pate' GenType 34 Spawn Points
		AddSpawnPoint("f_3cmlake_85.Id3", "f_3cmlake_85", Rectangle(-1158, -685, 40));
		AddSpawnPoint("f_3cmlake_85.Id3", "f_3cmlake_85", Rectangle(-1943, -27, 40));
		AddSpawnPoint("f_3cmlake_85.Id3", "f_3cmlake_85", Rectangle(-1278, -92, 40));
		AddSpawnPoint("f_3cmlake_85.Id3", "f_3cmlake_85", Rectangle(-231, -128, 40));
		AddSpawnPoint("f_3cmlake_85.Id3", "f_3cmlake_85", Rectangle(-246, 515, 40));
		AddSpawnPoint("f_3cmlake_85.Id3", "f_3cmlake_85", Rectangle(-197, 1322, 40));
		AddSpawnPoint("f_3cmlake_85.Id3", "f_3cmlake_85", Rectangle(659, 1331, 40));
		AddSpawnPoint("f_3cmlake_85.Id3", "f_3cmlake_85", Rectangle(716, 784, 40));
		AddSpawnPoint("f_3cmlake_85.Id3", "f_3cmlake_85", Rectangle(687, 148, 40));
		AddSpawnPoint("f_3cmlake_85.Id3", "f_3cmlake_85", Rectangle(628, -735, 40));
		AddSpawnPoint("f_3cmlake_85.Id3", "f_3cmlake_85", Rectangle(1365, 65, 40));
		AddSpawnPoint("f_3cmlake_85.Id3", "f_3cmlake_85", Rectangle(1662, -868, 40));
		AddSpawnPoint("f_3cmlake_85.Id3", "f_3cmlake_85", Rectangle(644, -364, 40));
		AddSpawnPoint("f_3cmlake_85.Id3", "f_3cmlake_85", Rectangle(1048, -768, 40));
		AddSpawnPoint("f_3cmlake_85.Id3", "f_3cmlake_85", Rectangle(-664, -134, 40));
		AddSpawnPoint("f_3cmlake_85.Id3", "f_3cmlake_85", Rectangle(270, 1274, 40));
		AddSpawnPoint("f_3cmlake_85.Id3", "f_3cmlake_85", Rectangle(1391, -714, 40));
		AddSpawnPoint("f_3cmlake_85.Id3", "f_3cmlake_85", Rectangle(1042, 71, 40));
		AddSpawnPoint("f_3cmlake_85.Id3", "f_3cmlake_85", Rectangle(-237, 970, 40));
		AddSpawnPoint("f_3cmlake_85.Id3", "f_3cmlake_85", Rectangle(-1289, -376, 40));

		// 'KindronLeader' GenType 36 Spawn Points
		AddSpawnPoint("f_3cmlake_85.Id4", "f_3cmlake_85", Rectangle(615, 897, 100));
		AddSpawnPoint("f_3cmlake_85.Id4", "f_3cmlake_85", Rectangle(757, 713, 100));
		AddSpawnPoint("f_3cmlake_85.Id4", "f_3cmlake_85", Rectangle(750, 44, 100));
		AddSpawnPoint("f_3cmlake_85.Id4", "f_3cmlake_85", Rectangle(676, 370, 100));
		AddSpawnPoint("f_3cmlake_85.Id4", "f_3cmlake_85", Rectangle(1485, -67, 100));
		AddSpawnPoint("f_3cmlake_85.Id4", "f_3cmlake_85", Rectangle(1336, 134, 100));
		AddSpawnPoint("f_3cmlake_85.Id4", "f_3cmlake_85", Rectangle(660, -668, 100));
		AddSpawnPoint("f_3cmlake_85.Id4", "f_3cmlake_85", Rectangle(1720, -838, 100));
		AddSpawnPoint("f_3cmlake_85.Id4", "f_3cmlake_85", Rectangle(1512, -773, 100));
		AddSpawnPoint("f_3cmlake_85.Id4", "f_3cmlake_85", Rectangle(439, 68, 100));
		AddSpawnPoint("f_3cmlake_85.Id4", "f_3cmlake_85", Rectangle(1112, -784, 100));
		AddSpawnPoint("f_3cmlake_85.Id4", "f_3cmlake_85", Rectangle(1038, 53, 100));
		AddSpawnPoint("f_3cmlake_85.Id4", "f_3cmlake_85", Rectangle(633, -331, 100));
		AddSpawnPoint("f_3cmlake_85.Id4", "f_3cmlake_85", Rectangle(1827, -773, 100));

		// 'Coterie' GenType 38 Spawn Points
		AddSpawnPoint("f_3cmlake_85.Id5", "f_3cmlake_85", Rectangle(-1408, -614, 50));
		AddSpawnPoint("f_3cmlake_85.Id5", "f_3cmlake_85", Rectangle(-1238, -874, 50));
		AddSpawnPoint("f_3cmlake_85.Id5", "f_3cmlake_85", Rectangle(-1015, -855, 50));
		AddSpawnPoint("f_3cmlake_85.Id5", "f_3cmlake_85", Rectangle(-1007, -545, 50));
		AddSpawnPoint("f_3cmlake_85.Id5", "f_3cmlake_85", Rectangle(-1270, -525, 50));
		AddSpawnPoint("f_3cmlake_85.Id5", "f_3cmlake_85", Rectangle(-2106, -158, 50));
		AddSpawnPoint("f_3cmlake_85.Id5", "f_3cmlake_85", Rectangle(-1856, -146, 50));
		AddSpawnPoint("f_3cmlake_85.Id5", "f_3cmlake_85", Rectangle(-1788, 89, 50));
		AddSpawnPoint("f_3cmlake_85.Id5", "f_3cmlake_85", Rectangle(-2066, 75, 50));
		AddSpawnPoint("f_3cmlake_85.Id5", "f_3cmlake_85", Rectangle(-1430, -183, 50));
		AddSpawnPoint("f_3cmlake_85.Id5", "f_3cmlake_85", Rectangle(-1351, 38, 50));
		AddSpawnPoint("f_3cmlake_85.Id5", "f_3cmlake_85", Rectangle(-1237, -109, 50));
		AddSpawnPoint("f_3cmlake_85.Id5", "f_3cmlake_85", Rectangle(-846, -115, 50));
		AddSpawnPoint("f_3cmlake_85.Id5", "f_3cmlake_85", Rectangle(-555, -122, 50));
		AddSpawnPoint("f_3cmlake_85.Id5", "f_3cmlake_85", Rectangle(-409, -283, 50));
		AddSpawnPoint("f_3cmlake_85.Id5", "f_3cmlake_85", Rectangle(-90, -296, 50));
		AddSpawnPoint("f_3cmlake_85.Id5", "f_3cmlake_85", Rectangle(114, -127, 50));
		AddSpawnPoint("f_3cmlake_85.Id5", "f_3cmlake_85", Rectangle(-19, 27, 50));
		AddSpawnPoint("f_3cmlake_85.Id5", "f_3cmlake_85", Rectangle(-299, 24, 50));
		AddSpawnPoint("f_3cmlake_85.Id5", "f_3cmlake_85", Rectangle(-214, -144, 50));
		AddSpawnPoint("f_3cmlake_85.Id5", "f_3cmlake_85", Rectangle(-255, 371, 50));
		AddSpawnPoint("f_3cmlake_85.Id5", "f_3cmlake_85", Rectangle(114, 466, 50));
		AddSpawnPoint("f_3cmlake_85.Id5", "f_3cmlake_85", Rectangle(-227, 626, 50));

		// 'Coterie' GenType 39 Spawn Points
		AddSpawnPoint("f_3cmlake_85.Id6", "f_3cmlake_85", Rectangle(-1193, -707, 275));
		AddSpawnPoint("f_3cmlake_85.Id6", "f_3cmlake_85", Rectangle(-231, -156, 275));
		AddSpawnPoint("f_3cmlake_85.Id6", "f_3cmlake_85", Rectangle(-160, 496, 275));
		AddSpawnPoint("f_3cmlake_85.Id6", "f_3cmlake_85", Rectangle(-1937, -18, 275));

		// 'Tripy' GenType 40 Spawn Points
		AddSpawnPoint("f_3cmlake_85.Id7", "f_3cmlake_85", Rectangle(791, -778, 50));
		AddSpawnPoint("f_3cmlake_85.Id7", "f_3cmlake_85", Rectangle(576, -739, 50));
		AddSpawnPoint("f_3cmlake_85.Id7", "f_3cmlake_85", Rectangle(673, -588, 50));
		AddSpawnPoint("f_3cmlake_85.Id7", "f_3cmlake_85", Rectangle(666, -111, 50));
		AddSpawnPoint("f_3cmlake_85.Id7", "f_3cmlake_85", Rectangle(429, 43, 50));
		AddSpawnPoint("f_3cmlake_85.Id7", "f_3cmlake_85", Rectangle(457, 212, 50));
		AddSpawnPoint("f_3cmlake_85.Id7", "f_3cmlake_85", Rectangle(642, 369, 50));
		AddSpawnPoint("f_3cmlake_85.Id7", "f_3cmlake_85", Rectangle(777, 54, 50));
		AddSpawnPoint("f_3cmlake_85.Id7", "f_3cmlake_85", Rectangle(1251, -29, 50));
		AddSpawnPoint("f_3cmlake_85.Id7", "f_3cmlake_85", Rectangle(1481, -94, 50));
		AddSpawnPoint("f_3cmlake_85.Id7", "f_3cmlake_85", Rectangle(1269, 222, 50));
		AddSpawnPoint("f_3cmlake_85.Id7", "f_3cmlake_85", Rectangle(1506, 230, 50));
		AddSpawnPoint("f_3cmlake_85.Id7", "f_3cmlake_85", Rectangle(719, 609, 50));
		AddSpawnPoint("f_3cmlake_85.Id7", "f_3cmlake_85", Rectangle(570, 874, 50));
		AddSpawnPoint("f_3cmlake_85.Id7", "f_3cmlake_85", Rectangle(778, 919, 50));
		AddSpawnPoint("f_3cmlake_85.Id7", "f_3cmlake_85", Rectangle(1508, -758, 50));
		AddSpawnPoint("f_3cmlake_85.Id7", "f_3cmlake_85", Rectangle(1661, -946, 50));
		AddSpawnPoint("f_3cmlake_85.Id7", "f_3cmlake_85", Rectangle(1742, -753, 50));
		AddSpawnPoint("f_3cmlake_85.Id7", "f_3cmlake_85", Rectangle(1154, -770, 50));
		AddSpawnPoint("f_3cmlake_85.Id7", "f_3cmlake_85", Rectangle(1039, 83, 50));

		// 'Tripy' GenType 41 Spawn Points
		AddSpawnPoint("f_3cmlake_85.Id8", "f_3cmlake_85", Rectangle(690, -680, 275));
		AddSpawnPoint("f_3cmlake_85.Id8", "f_3cmlake_85", Rectangle(1608, -834, 275));
		AddSpawnPoint("f_3cmlake_85.Id8", "f_3cmlake_85", Rectangle(690, 91, 275));
		AddSpawnPoint("f_3cmlake_85.Id8", "f_3cmlake_85", Rectangle(687, 844, 275));
		AddSpawnPoint("f_3cmlake_85.Id8", "f_3cmlake_85", Rectangle(1382, 86, 275));
		AddSpawnPoint("f_3cmlake_85.Id8", "f_3cmlake_85", Rectangle(471, 890, 275));

		// 'Rootcrystal_02' GenType 42 Spawn Points
		AddSpawnPoint("f_3cmlake_85.Id9", "f_3cmlake_85", Rectangle(719, -608, 200));
		AddSpawnPoint("f_3cmlake_85.Id9", "f_3cmlake_85", Rectangle(625, -816, 200));
		AddSpawnPoint("f_3cmlake_85.Id9", "f_3cmlake_85", Rectangle(1091, -762, 200));
		AddSpawnPoint("f_3cmlake_85.Id9", "f_3cmlake_85", Rectangle(1424, -684, 200));
		AddSpawnPoint("f_3cmlake_85.Id9", "f_3cmlake_85", Rectangle(1601, -957, 200));
		AddSpawnPoint("f_3cmlake_85.Id9", "f_3cmlake_85", Rectangle(1778, -735, 200));
		AddSpawnPoint("f_3cmlake_85.Id9", "f_3cmlake_85", Rectangle(298, -695, 200));
		AddSpawnPoint("f_3cmlake_85.Id9", "f_3cmlake_85", Rectangle(-293, -588, 200));
		AddSpawnPoint("f_3cmlake_85.Id9", "f_3cmlake_85", Rectangle(-27, -675, 200));
		AddSpawnPoint("f_3cmlake_85.Id9", "f_3cmlake_85", Rectangle(-435, -62, 200));
		AddSpawnPoint("f_3cmlake_85.Id9", "f_3cmlake_85", Rectangle(784, 1221, 200));
		AddSpawnPoint("f_3cmlake_85.Id9", "f_3cmlake_85", Rectangle(-128, -199, 200));
		AddSpawnPoint("f_3cmlake_85.Id9", "f_3cmlake_85", Rectangle(-237, 311, 200));
		AddSpawnPoint("f_3cmlake_85.Id9", "f_3cmlake_85", Rectangle(-352, 621, 200));
		AddSpawnPoint("f_3cmlake_85.Id9", "f_3cmlake_85", Rectangle(91, 523, 200));
		AddSpawnPoint("f_3cmlake_85.Id9", "f_3cmlake_85", Rectangle(-187, 1157, 200));
		AddSpawnPoint("f_3cmlake_85.Id9", "f_3cmlake_85", Rectangle(-311, 1452, 200));
		AddSpawnPoint("f_3cmlake_85.Id9", "f_3cmlake_85", Rectangle(114, 1249, 200));
		AddSpawnPoint("f_3cmlake_85.Id9", "f_3cmlake_85", Rectangle(493, 1399, 200));
		AddSpawnPoint("f_3cmlake_85.Id9", "f_3cmlake_85", Rectangle(-1010, -106, 200));
		AddSpawnPoint("f_3cmlake_85.Id9", "f_3cmlake_85", Rectangle(-1465, -55, 200));
		AddSpawnPoint("f_3cmlake_85.Id9", "f_3cmlake_85", Rectangle(-1281, 183, 200));
		AddSpawnPoint("f_3cmlake_85.Id9", "f_3cmlake_85", Rectangle(-1319, 691, 200));
		AddSpawnPoint("f_3cmlake_85.Id9", "f_3cmlake_85", Rectangle(-1015, 448, 200));
		AddSpawnPoint("f_3cmlake_85.Id9", "f_3cmlake_85", Rectangle(-1313, -512, 200));
		AddSpawnPoint("f_3cmlake_85.Id9", "f_3cmlake_85", Rectangle(-1114, -782, 200));
		AddSpawnPoint("f_3cmlake_85.Id9", "f_3cmlake_85", Rectangle(-1819, -28, 200));
		AddSpawnPoint("f_3cmlake_85.Id9", "f_3cmlake_85", Rectangle(636, -163, 200));
		AddSpawnPoint("f_3cmlake_85.Id9", "f_3cmlake_85", Rectangle(497, 308, 200));
		AddSpawnPoint("f_3cmlake_85.Id9", "f_3cmlake_85", Rectangle(1112, 69, 200));
		AddSpawnPoint("f_3cmlake_85.Id9", "f_3cmlake_85", Rectangle(712, 807, 200));
		AddSpawnPoint("f_3cmlake_85.Id9", "f_3cmlake_85", Rectangle(1487, 44, 200));
	}
}
