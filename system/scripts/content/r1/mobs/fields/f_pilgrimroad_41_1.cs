//--- Melia Script -----------------------------------------------------------
// Thaumas Trail Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_pilgrimroad_41_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FPilgrimroad411MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_pilgrimroad_41_1", MonsterId.Tiny_Brown, Properties("MHP", 456418, "MINPATK", 6370, "MAXPATK", 7731, "MINMATK", 6370, "MAXMATK", 7731, "DEF", 62744, "MDEF", 62744));
		AddPropertyOverrides("f_pilgrimroad_41_1", MonsterId.Tiny_Bow_Green, Properties("MHP", 456762, "MINPATK", 6374, "MAXPATK", 7736, "MINMATK", 6374, "MAXMATK", 7736, "DEF", 62882, "MDEF", 62882));
		AddPropertyOverrides("f_pilgrimroad_41_1", MonsterId.Wendigo_Magician_Blue, Properties("MHP", 457391, "MINPATK", 6383, "MAXPATK", 7746, "MINMATK", 6383, "MAXMATK", 7746, "DEF", 63134, "MDEF", 63134));

		// Monster Spawners ---------------------------------

		AddSpawner("f_pilgrimroad_41_1.Id1", MonsterId.Rootcrystal_05, min: 12, max: 16, respawn: TimeSpan.FromMilliseconds(5000));
		AddSpawner("f_pilgrimroad_41_1.Id2", MonsterId.Tiny_Brown, min: 23, max: 30);
		AddSpawner("f_pilgrimroad_41_1.Id3", MonsterId.Tiny_Bow_Green, min: 8, max: 10);
		AddSpawner("f_pilgrimroad_41_1.Id4", MonsterId.Wendigo_Magician_Blue, min: 8, max: 10);
		AddSpawner("f_pilgrimroad_41_1.Id5", MonsterId.Tiny_Bow_Green, min: 23, max: 30);
		AddSpawner("f_pilgrimroad_41_1.Id6", MonsterId.Tiny_Brown, min: 3, max: 4);
		AddSpawner("f_pilgrimroad_41_1.Id7", MonsterId.Tiny_Brown, min: 53, max: 70);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_05' GenType 4 Spawn Points
		AddSpawnPoint("f_pilgrimroad_41_1.Id1", "f_pilgrimroad_41_1", Rectangle(-980, -1026, 50));
		AddSpawnPoint("f_pilgrimroad_41_1.Id1", "f_pilgrimroad_41_1", Rectangle(-993, -818, 50));
		AddSpawnPoint("f_pilgrimroad_41_1.Id1", "f_pilgrimroad_41_1", Rectangle(-702, -975, 50));
		AddSpawnPoint("f_pilgrimroad_41_1.Id1", "f_pilgrimroad_41_1", Rectangle(-723, -753, 50));
		AddSpawnPoint("f_pilgrimroad_41_1.Id1", "f_pilgrimroad_41_1", Rectangle(-1231, -297, 50));
		AddSpawnPoint("f_pilgrimroad_41_1.Id1", "f_pilgrimroad_41_1", Rectangle(-82, -909, 50));
		AddSpawnPoint("f_pilgrimroad_41_1.Id1", "f_pilgrimroad_41_1", Rectangle(14, -707, 50));
		AddSpawnPoint("f_pilgrimroad_41_1.Id1", "f_pilgrimroad_41_1", Rectangle(165, -847, 50));
		AddSpawnPoint("f_pilgrimroad_41_1.Id1", "f_pilgrimroad_41_1", Rectangle(-893, 160, 50));
		AddSpawnPoint("f_pilgrimroad_41_1.Id1", "f_pilgrimroad_41_1", Rectangle(-457, -439, 50));
		AddSpawnPoint("f_pilgrimroad_41_1.Id1", "f_pilgrimroad_41_1", Rectangle(-1543, 670, 50));
		AddSpawnPoint("f_pilgrimroad_41_1.Id1", "f_pilgrimroad_41_1", Rectangle(-1436, 823, 50));
		AddSpawnPoint("f_pilgrimroad_41_1.Id1", "f_pilgrimroad_41_1", Rectangle(-764, 404, 50));
		AddSpawnPoint("f_pilgrimroad_41_1.Id1", "f_pilgrimroad_41_1", Rectangle(-571, 909, 50));
		AddSpawnPoint("f_pilgrimroad_41_1.Id1", "f_pilgrimroad_41_1", Rectangle(-320, 957, 50));
		AddSpawnPoint("f_pilgrimroad_41_1.Id1", "f_pilgrimroad_41_1", Rectangle(82, 1004, 50));
		AddSpawnPoint("f_pilgrimroad_41_1.Id1", "f_pilgrimroad_41_1", Rectangle(472, 1028, 50));
		AddSpawnPoint("f_pilgrimroad_41_1.Id1", "f_pilgrimroad_41_1", Rectangle(-60, 258, 50));
		AddSpawnPoint("f_pilgrimroad_41_1.Id1", "f_pilgrimroad_41_1", Rectangle(-113, -138, 50));
		AddSpawnPoint("f_pilgrimroad_41_1.Id1", "f_pilgrimroad_41_1", Rectangle(278, -42, 50));
		AddSpawnPoint("f_pilgrimroad_41_1.Id1", "f_pilgrimroad_41_1", Rectangle(446, 473, 50));
		AddSpawnPoint("f_pilgrimroad_41_1.Id1", "f_pilgrimroad_41_1", Rectangle(916, 920, 50));
		AddSpawnPoint("f_pilgrimroad_41_1.Id1", "f_pilgrimroad_41_1", Rectangle(1020, 652, 50));
		AddSpawnPoint("f_pilgrimroad_41_1.Id1", "f_pilgrimroad_41_1", Rectangle(684, -267, 50));
		AddSpawnPoint("f_pilgrimroad_41_1.Id1", "f_pilgrimroad_41_1", Rectangle(910, -326, 50));
		AddSpawnPoint("f_pilgrimroad_41_1.Id1", "f_pilgrimroad_41_1", Rectangle(1097, 114, 50));
		AddSpawnPoint("f_pilgrimroad_41_1.Id1", "f_pilgrimroad_41_1", Rectangle(1373, 236, 50));
		AddSpawnPoint("f_pilgrimroad_41_1.Id1", "f_pilgrimroad_41_1", Rectangle(1843, 414, 50));

		// 'Tiny_Brown' GenType 100 Spawn Points
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(-128, 19, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(-81, 168, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(144, 305, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(85, 84, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(14, -71, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(159, -202, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(337, 141, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(-368, -356, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(-581, -575, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(-590, -291, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(-792, 140, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(-985, 128, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(-1176, -235, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(-1337, -452, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(-838, -718, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(-944, -911, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(-841, -1100, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(-601, -924, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(-756, -904, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(-164, -1022, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(52, -1044, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(-68, -770, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(136, -666, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(85, -911, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(249, -924, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(458, -706, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(582, -418, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(604, -520, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(735, -164, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(830, -115, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(810, -334, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(1196, 137, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(1197, 309, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(-369, 764, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(1604, 281, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(1850, 513, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(1991, 282, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(1810, 303, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(1081, 486, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(1129, 693, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(820, 680, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(680, 780, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(909, 1022, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(936, 730, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(1064, 904, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(629, 697, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(279, 394, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(-223, 282, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(-661, 733, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(-500, 1030, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(-395, 900, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(-27, 1123, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(106, 886, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(287, 1199, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(219, 841, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(929, 905, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(-932, 348, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(-1350, 587, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(-1597, 578, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(-1600, 908, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(-1366, 741, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(-265, -167, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(-654, 838, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(-153, 920, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(127, 1124, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id2", "f_pilgrimroad_41_1", Rectangle(301, 1024, 25));

		// 'Tiny_Bow_Green' GenType 101 Spawn Points
		AddSpawnPoint("f_pilgrimroad_41_1.Id3", "f_pilgrimroad_41_1", Rectangle(1722, 377, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id3", "f_pilgrimroad_41_1", Rectangle(1960, 433, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id3", "f_pilgrimroad_41_1", Rectangle(1860, 173, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id3", "f_pilgrimroad_41_1", Rectangle(1704, 227, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id3", "f_pilgrimroad_41_1", Rectangle(1188, 49, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id3", "f_pilgrimroad_41_1", Rectangle(1123, 230, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id3", "f_pilgrimroad_41_1", Rectangle(1286, 263, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id3", "f_pilgrimroad_41_1", Rectangle(1327, 87, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id3", "f_pilgrimroad_41_1", Rectangle(1037, 757, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id3", "f_pilgrimroad_41_1", Rectangle(918, 656, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id3", "f_pilgrimroad_41_1", Rectangle(751, 773, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id3", "f_pilgrimroad_41_1", Rectangle(994, 1011, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id3", "f_pilgrimroad_41_1", Rectangle(968, 845, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id3", "f_pilgrimroad_41_1", Rectangle(1151, 911, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id3", "f_pilgrimroad_41_1", Rectangle(491, 550, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id3", "f_pilgrimroad_41_1", Rectangle(347, 531, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id3", "f_pilgrimroad_41_1", Rectangle(561, 318, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id3", "f_pilgrimroad_41_1", Rectangle(619, -1, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id3", "f_pilgrimroad_41_1", Rectangle(625, -339, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id3", "f_pilgrimroad_41_1", Rectangle(772, -233, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id3", "f_pilgrimroad_41_1", Rectangle(1014, -24, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id3", "f_pilgrimroad_41_1", Rectangle(685, -393, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id3", "f_pilgrimroad_41_1", Rectangle(916, -413, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id3", "f_pilgrimroad_41_1", Rectangle(525, -617, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id3", "f_pilgrimroad_41_1", Rectangle(364, -753, 25));

		// 'Wendigo_Magician_Blue' GenType 103 Spawn Points
		AddSpawnPoint("f_pilgrimroad_41_1.Id4", "f_pilgrimroad_41_1", Rectangle(-244, -48, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id4", "f_pilgrimroad_41_1", Rectangle(57, 248, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id4", "f_pilgrimroad_41_1", Rectangle(248, 273, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id4", "f_pilgrimroad_41_1", Rectangle(144, -4, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id4", "f_pilgrimroad_41_1", Rectangle(-172, 157, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id4", "f_pilgrimroad_41_1", Rectangle(-193, -259, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id4", "f_pilgrimroad_41_1", Rectangle(-472, -349, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id4", "f_pilgrimroad_41_1", Rectangle(-612, -693, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id4", "f_pilgrimroad_41_1", Rectangle(-833, -821, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id4", "f_pilgrimroad_41_1", Rectangle(-802, -1005, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id4", "f_pilgrimroad_41_1", Rectangle(-662, -836, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id4", "f_pilgrimroad_41_1", Rectangle(-607, -1046, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id4", "f_pilgrimroad_41_1", Rectangle(-190, -860, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id4", "f_pilgrimroad_41_1", Rectangle(104, -773, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id4", "f_pilgrimroad_41_1", Rectangle(-21, -620, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id4", "f_pilgrimroad_41_1", Rectangle(-184, -768, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id4", "f_pilgrimroad_41_1", Rectangle(248, -770, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id4", "f_pilgrimroad_41_1", Rectangle(4, -932, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id4", "f_pilgrimroad_41_1", Rectangle(-1005, -945, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id4", "f_pilgrimroad_41_1", Rectangle(-1222, -421, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id4", "f_pilgrimroad_41_1", Rectangle(-1048, -604, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id4", "f_pilgrimroad_41_1", Rectangle(-1288, -215, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id4", "f_pilgrimroad_41_1", Rectangle(-944, 42, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id4", "f_pilgrimroad_41_1", Rectangle(-841, 464, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id4", "f_pilgrimroad_41_1", Rectangle(-1012, 317, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id4", "f_pilgrimroad_41_1", Rectangle(-861, 76, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id4", "f_pilgrimroad_41_1", Rectangle(-605, -136, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id4", "f_pilgrimroad_41_1", Rectangle(-1320, 668, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id4", "f_pilgrimroad_41_1", Rectangle(-1483, 578, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id4", "f_pilgrimroad_41_1", Rectangle(-1662, 680, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id4", "f_pilgrimroad_41_1", Rectangle(-1408, 916, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id4", "f_pilgrimroad_41_1", Rectangle(-1510, 753, 25));

		// 'Tiny_Bow_Green' GenType 104 Spawn Points
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(-897, -1001, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(-707, -1053, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(-925, -758, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(-751, -653, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(-862, -564, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(-453, -534, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(-443, -230, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(-692, -179, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(-794, 48, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(-1070, 124, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(-772, 288, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(-1285, -112, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(-1402, -293, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(-1179, -514, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(-825, -910, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(-52, -1016, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(-117, -653, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(71, -589, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(1, -839, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(150, -963, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(445, -608, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(732, -339, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(572, -270, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(725, -507, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(944, -204, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(698, -37, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(850, -211, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(587, -152, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(792, -416, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(-61, -211, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(-267, 108, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(-110, 359, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(3, 81, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(196, -104, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(353, 24, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(232, 104, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(23, 379, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(122, 450, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(367, 397, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(-238, 377, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(-723, 500, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(-669, 997, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(-513, 708, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(-293, 1056, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(-250, 815, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(-23, 1012, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(23, 859, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(200, 1110, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(318, 886, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(188, 964, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(654, 653, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(870, 817, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(1068, 1042, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(1099, 819, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(-933, 222, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(-1385, 649, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(-1623, 780, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(-1531, 947, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id5", "f_pilgrimroad_41_1", Rectangle(-889, -26, 25));

		// 'Tiny_Brown' GenType 105 Spawn Points
		AddSpawnPoint("f_pilgrimroad_41_1.Id6", "f_pilgrimroad_41_1", Rectangle(-739, -1100, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id6", "f_pilgrimroad_41_1", Rectangle(-886, -860, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id6", "f_pilgrimroad_41_1", Rectangle(-697, -869, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id6", "f_pilgrimroad_41_1", Rectangle(-887, -643, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id6", "f_pilgrimroad_41_1", Rectangle(-1284, -404, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id6", "f_pilgrimroad_41_1", Rectangle(-1303, -270, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id6", "f_pilgrimroad_41_1", Rectangle(-1133, -368, 25));

		// 'Tiny_Brown' GenType 106 Spawn Points
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(-80, -973, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(142, -1012, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(-62, -685, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(265, -820, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(366, 927, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(27, 1073, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(-161, 860, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(-253, 278, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(199, 317, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(-945, 291, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(-795, 234, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(1965, 388, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(1935, 501, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(1839, 473, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(1739, 357, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(-83, -260, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(187, -213, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(1966, 328, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(1984, 232, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(1923, 196, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(1814, 196, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(167, 1070, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(-502, 961, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(1691, 280, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(1656, 241, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(23, 298, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(1601, 390, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(-872, 54, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(1712, 474, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(-18, 99, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(-363, 1068, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(-616, 1030, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(795, 969, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(714, 989, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(181, 874, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(1208, 118, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(1252, -17, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(1315, 62, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(1079, 30, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(810, 732, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(1118, 929, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(1089, 652, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(1150, 92, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(947, 819, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(856, 746, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(-592, 794, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(-1506, 617, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(-339, 848, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(123, -104, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(1111, 218, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(-1391, 830, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(1155, 277, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(1111, 348, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(225, 121, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(1352, 152, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(1244, 274, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(-186, -36, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(1412, 218, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(1065, 855, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(1335, 305, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(368, 1090, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(839, -167, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(716, -107, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(609, -220, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(778, -214, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(920, -304, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(621, -96, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(-1252, -382, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(841, -432, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(579, -302, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(32, 39, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(600, -390, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(694, -527, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(644, -503, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(676, -338, 25));
		AddSpawnPoint("f_pilgrimroad_41_1.Id7", "f_pilgrimroad_41_1", Rectangle(-1123, -216, 25));
	}
}
