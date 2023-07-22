//--- Melia Script -----------------------------------------------------------
// Tenants' Farm Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_farm_47_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FFarm471MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_farm_47_1", MonsterId.Pino_White, Properties("MHP", 176768, "MINPATK", 2774, "MAXPATK", 3311, "MINMATK", 2774, "MAXMATK", 3311, "DEF", 5216, "MDEF", 5216));
		AddPropertyOverrides("f_farm_47_1", MonsterId.Geppetto_White, Properties("MHP", 177760, "MINPATK", 2787, "MAXPATK", 3327, "MINMATK", 2787, "MAXMATK", 3327, "DEF", 5306, "MDEF", 5306));

		// Monster Spawners ---------------------------------

		AddSpawner("f_farm_47_1.Id1", MonsterId.Pino_White, min: 30, max: 40);
		AddSpawner("f_farm_47_1.Id2", MonsterId.Geppetto_White, min: 30, max: 40);
		AddSpawner("f_farm_47_1.Id3", MonsterId.Pino_White, min: 12, max: 15);
		AddSpawner("f_farm_47_1.Id4", MonsterId.Rootcrystal_01, min: 23, max: 30, respawn: TimeSpan.FromMilliseconds(60000));

		// Monster Spawn Points -----------------------------

		// 'Pino_White' GenType 45 Spawn Points
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-1279, 390, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-524, 933, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-570, 753, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-243, -1261, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-32, -434, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(286, 373, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-1070, 159, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-1196, 513, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(256, 273, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(120, -504, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(35, -421, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-89, -394, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-96, -340, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(157, -428, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(213, -396, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(211, -342, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(178, -274, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(111, -272, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(16, -296, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(13, -363, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(87, -354, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(32, -464, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-230, -172, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-148, -242, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-70, -220, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-293, -117, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-252, -90, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-44, -285, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-332, -119, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-334, -1152, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-397, -1092, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-240, -1138, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-197, -1188, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-172, -1263, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-168, -1123, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-300, -1035, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-262, -1003, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-209, -1014, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-201, -1070, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-110, -1150, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-62, -1155, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-36, -1099, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(548, -1245, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(589, -1207, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(457, -1282, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(360, -1234, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(265, -1145, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(320, -1050, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(422, -979, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(487, -979, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(561, -1020, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(605, -1079, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(535, -1117, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(464, -1129, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(369, -1153, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(337, -994, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(414, -1017, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-980, 226, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-1092, 214, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-1084, 291, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-969, 362, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-938, 308, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-879, 282, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-942, 170, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-818, 246, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-828, 325, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-827, 379, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-1024, 276, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-988, 102, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-895, 136, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-1234, 673, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-1157, 442, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-1290, 605, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-1166, 727, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-1113, 663, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-1105, 557, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-1033, 605, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-996, 523, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-589, 849, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-738, 871, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-699, 960, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-561, 972, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-521, 863, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-541, 666, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-673, 713, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-754, 766, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-641, 930, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-463, 788, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-406, 820, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-459, 688, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-34, 1020, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(163, 976, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(42, 1139, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-45, 1113, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-25, 1192, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(32, 1254, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(167, 1235, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(180, 1084, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(103, 1016, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(329, 1083, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(348, 1142, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(294, 1166, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(145, 1184, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(142, 1316, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(311, 1250, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(259, 1448, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(190, 1402, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(92, 1379, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(627, 233, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(567, 153, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(497, 183, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(373, 185, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(305, 243, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(208, 388, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(457, 331, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(549, 443, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(308, 478, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(376, 489, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(357, 348, 25));

		// 'Geppetto_White' GenType 46 Spawn Points
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(838, 287, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1303, 198, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(702, -100, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1419, -905, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1392, 922, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(-353, -1088, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(-104, -1057, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(358, -1102, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(539, -1072, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(510, -1269, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1232, 312, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1350, -1264, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1470, -1273, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1307, -1139, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1208, -1214, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1157, -1128, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1162, -1020, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1423, -1155, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1539, -1269, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1597, -1144, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1489, -1070, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1379, -1068, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1381, -976, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1268, -1017, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1230, -824, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1202, -925, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1321, -807, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(677, -130, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(688, -62, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(741, -82, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(790, 368, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(998, 374, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1009, 138, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(846, 129, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(924, 184, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1081, 206, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1064, 316, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1054, 484, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(914, 356, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(874, 482, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(946, 502, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1088, 384, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1356, 276, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1273, 177, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1326, 83, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1431, 131, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1548, 195, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1464, 233, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1423, 363, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1298, 408, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1523, 315, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1504, 396, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1367, 463, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1135, 1100, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1426, 1037, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1553, 1015, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1509, 950, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1300, 854, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1179, 927, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1320, 1080, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1240, 1214, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1339, 1220, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1436, 1190, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(255, -114, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(156, -113, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(98, -47, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(-51, 109, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(-159, 200, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(13, 38, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(153, 39, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(397, -74, 25));

		// 'Pino_White' GenType 47 Spawn Points
		AddSpawnPoint("f_farm_47_1.Id3", "f_farm_47_1", Rectangle(315, 471, 9999));

		// 'Rootcrystal_01' GenType 49 Spawn Points
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(-1226, -216, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(-994, -304, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(-1104, -1123, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(-750, -1112, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(-297, -1146, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(-398, -555, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(275, -1104, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(567, -1173, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(-823, -838, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(-568, -227, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(-608, 99, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(-1013, 237, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(-1168, 613, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(-587, 838, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(-153, 686, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(62, 1073, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(208, 1297, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(-258, 230, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(218, 416, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(480, 409, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(3, -316, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(185, -58, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(597, -328, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(832, -646, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(1367, -823, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(1302, -1229, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(1341, 106, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(1481, 424, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(1047, 258, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(1117, 630, 20));
	}
}
