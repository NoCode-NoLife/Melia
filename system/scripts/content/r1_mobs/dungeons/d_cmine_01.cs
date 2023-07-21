//--- Melia Script -----------------------------------------------------------
// Crystal Mine 1F Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_cmine_01'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DCmine01MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_cmine_01", MonsterId.Whip_Vine_Ra, Properties("MHP", 4744, "MINPATK", 298, "MAXPATK", 322, "MINMATK", 298, "MAXMATK", 322, "DEF", 29, "MDEF", 29));
		AddPropertyOverrides("d_cmine_01", MonsterId.Bat, Properties("MHP", 5118, "MINPATK", 315, "MAXPATK", 340, "MINMATK", 315, "MAXMATK", 340, "DEF", 31, "MDEF", 31));
		AddPropertyOverrides("d_cmine_01", MonsterId.Goblin_Miners, Properties("MHP", 5506, "MINPATK", 333, "MAXPATK", 359, "MINMATK", 333, "MAXMATK", 359, "DEF", 33, "MDEF", 33));
		AddPropertyOverrides("d_cmine_01", MonsterId.Goblin_Miners_Q1, Properties("MHP", 5908, "MINPATK", 351, "MAXPATK", 379, "MINMATK", 351, "MAXMATK", 379, "DEF", 35, "MDEF", 35));
		AddPropertyOverrides("d_cmine_01", MonsterId.StonOrca, Properties("MHP", 6322, "MINPATK", 370, "MAXPATK", 400, "MINMATK", 370, "MAXMATK", 400, "DEF", 37, "MDEF", 37));
		AddPropertyOverrides("d_cmine_01", MonsterId.Boss_Spector_M, Properties("MHP", 30368, "MINPATK", 701, "MAXPATK", 757, "MINMATK", 701, "MAXMATK", 757, "DEF", 69, "MDEF", 69));
		AddPropertyOverrides("d_cmine_01", MonsterId.Boss_Bearkaras, Properties("MHP", 32346, "MINPATK", 737, "MAXPATK", 796, "MINMATK", 737, "MAXMATK", 796, "DEF", 73, "MDEF", 73));

		// Monster Spawners ---------------------------------

		AddSpawner("d_cmine_01.Id1", MonsterId.Rootcrystal_01, 12, 15, TimeSpan.FromMilliseconds(80000), TendencyType.Peaceful);
		AddSpawner("d_cmine_01.Id2", MonsterId.Goblin_Miners, 21, 27, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cmine_01.Id3", MonsterId.Goblin_Miners, 6, 7, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cmine_01.Id4", MonsterId.Bat, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cmine_01.Id5", MonsterId.StonOrca, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cmine_01.Id6", MonsterId.Whip_Vine_Ra, 23, 30, TimeSpan.FromMilliseconds(180000), TendencyType.Aggressive);
		AddSpawner("d_cmine_01.Id7", MonsterId.Whip_Vine_Ra, 23, 30, TimeSpan.FromMilliseconds(180000), TendencyType.Aggressive);
		AddSpawner("d_cmine_01.Id8", MonsterId.Whip_Vine_Ra, 23, 30, TimeSpan.FromMilliseconds(180000), TendencyType.Aggressive);
		AddSpawner("d_cmine_01.Id9", MonsterId.StonOrca, 3, 3, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cmine_01.Id10", MonsterId.Goblin_Miners, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cmine_01.Id11", MonsterId.Bat, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_cmine_01.Id12", MonsterId.Goblin_Miners_Q1, 2, 2, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 500 Spawn Points
		AddSpawnPoint("d_cmine_01.Id1", "d_cmine_01", Rectangle(-824, -1378, 10));
		AddSpawnPoint("d_cmine_01.Id1", "d_cmine_01", Rectangle(-1121, -1317, 10));
		AddSpawnPoint("d_cmine_01.Id1", "d_cmine_01", Rectangle(-457, -884, 10));
		AddSpawnPoint("d_cmine_01.Id1", "d_cmine_01", Rectangle(-362, -370, 10));
		AddSpawnPoint("d_cmine_01.Id1", "d_cmine_01", Rectangle(-324, -660, 10));
		AddSpawnPoint("d_cmine_01.Id1", "d_cmine_01", Rectangle(-783, -900, 10));
		AddSpawnPoint("d_cmine_01.Id1", "d_cmine_01", Rectangle(-1137, -1505, 10));
		AddSpawnPoint("d_cmine_01.Id1", "d_cmine_01", Rectangle(-715, -205, 10));
		AddSpawnPoint("d_cmine_01.Id1", "d_cmine_01", Rectangle(71, -232, 10));
		AddSpawnPoint("d_cmine_01.Id1", "d_cmine_01", Rectangle(319, 167, 10));
		AddSpawnPoint("d_cmine_01.Id1", "d_cmine_01", Rectangle(522, -356, 10));
		AddSpawnPoint("d_cmine_01.Id1", "d_cmine_01", Rectangle(472, -865, 10));
		AddSpawnPoint("d_cmine_01.Id1", "d_cmine_01", Rectangle(1130, -1116, 10));
		AddSpawnPoint("d_cmine_01.Id1", "d_cmine_01", Rectangle(1301, -943, 10));
		AddSpawnPoint("d_cmine_01.Id1", "d_cmine_01", Rectangle(832, 54, 10));
		AddSpawnPoint("d_cmine_01.Id1", "d_cmine_01", Rectangle(1437, 290, 10));
		AddSpawnPoint("d_cmine_01.Id1", "d_cmine_01", Rectangle(1354, 499, 10));
		AddSpawnPoint("d_cmine_01.Id1", "d_cmine_01", Rectangle(570, 657, 10));
		AddSpawnPoint("d_cmine_01.Id1", "d_cmine_01", Rectangle(783, 801, 10));
		AddSpawnPoint("d_cmine_01.Id1", "d_cmine_01", Rectangle(331, 1149, 10));
		AddSpawnPoint("d_cmine_01.Id1", "d_cmine_01", Rectangle(99, 1158, 10));
		AddSpawnPoint("d_cmine_01.Id1", "d_cmine_01", Rectangle(-41, 1090, 10));
		AddSpawnPoint("d_cmine_01.Id1", "d_cmine_01", Rectangle(-138, 804, 10));
		AddSpawnPoint("d_cmine_01.Id1", "d_cmine_01", Rectangle(-268, 766, 10));
		AddSpawnPoint("d_cmine_01.Id1", "d_cmine_01", Rectangle(-726, 550, 10));
		AddSpawnPoint("d_cmine_01.Id1", "d_cmine_01", Rectangle(-996, 297, 10));
		AddSpawnPoint("d_cmine_01.Id1", "d_cmine_01", Rectangle(-1196, 411, 10));
		AddSpawnPoint("d_cmine_01.Id1", "d_cmine_01", Rectangle(-1330, 754, 10));
		AddSpawnPoint("d_cmine_01.Id1", "d_cmine_01", Rectangle(-1509, 552, 10));

		// 'Goblin_Miners' GenType 501 Spawn Points
		AddSpawnPoint("d_cmine_01.Id2", "d_cmine_01", Rectangle(-123, -189, 9999));

		// 'Goblin_Miners' GenType 505 Spawn Points
		AddSpawnPoint("d_cmine_01.Id3", "d_cmine_01", Rectangle(-168, -156, 30));
		AddSpawnPoint("d_cmine_01.Id3", "d_cmine_01", Rectangle(1412, 390, 30));
		AddSpawnPoint("d_cmine_01.Id3", "d_cmine_01", Rectangle(615, 645, 30));
		AddSpawnPoint("d_cmine_01.Id3", "d_cmine_01", Rectangle(334, 180, 30));
		AddSpawnPoint("d_cmine_01.Id3", "d_cmine_01", Rectangle(1286, -1004, 30));
		AddSpawnPoint("d_cmine_01.Id3", "d_cmine_01", Rectangle(106, 1098, 30));
		AddSpawnPoint("d_cmine_01.Id3", "d_cmine_01", Rectangle(-1024, 524, 30));
		AddSpawnPoint("d_cmine_01.Id3", "d_cmine_01", Rectangle(458, -601, 30));
		AddSpawnPoint("d_cmine_01.Id3", "d_cmine_01", Rectangle(-744, -893, 30));

		// 'Bat' GenType 513 Spawn Points
		AddSpawnPoint("d_cmine_01.Id4", "d_cmine_01", Rectangle(-1152, 382, 30));
		AddSpawnPoint("d_cmine_01.Id4", "d_cmine_01", Rectangle(-1081, 580, 30));
		AddSpawnPoint("d_cmine_01.Id4", "d_cmine_01", Rectangle(-485, -949, 30));
		AddSpawnPoint("d_cmine_01.Id4", "d_cmine_01", Rectangle(-1007, 220, 30));
		AddSpawnPoint("d_cmine_01.Id4", "d_cmine_01", Rectangle(-459, -818, 30));
		AddSpawnPoint("d_cmine_01.Id4", "d_cmine_01", Rectangle(-813, -1083, 30));

		// 'StonOrca' GenType 515 Spawn Points
		AddSpawnPoint("d_cmine_01.Id5", "d_cmine_01", Rectangle(209, 1063, 500));
		AddSpawnPoint("d_cmine_01.Id5", "d_cmine_01", Rectangle(1243, 235, 500));
		AddSpawnPoint("d_cmine_01.Id5", "d_cmine_01", Rectangle(1129, -1074, 500));

		// 'Whip_Vine_Ra' GenType 518 Spawn Points
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-661, 523, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-659, 543, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-659, 543, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-652, 608, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-664, 595, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-664, 595, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-668, 571, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-680, 519, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-697, 562, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-696, 586, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-681, 622, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-686, 660, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-654, 689, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-640, 722, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-647, 629, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-627, 626, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-629, 644, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-614, 653, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-658, 664, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-673, 645, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-671, 711, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-706, 662, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-709, 622, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-696, 683, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-731, 699, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-711, 644, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-733, 612, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-716, 589, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-689, 539, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-703, 521, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-704, 711, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-724, 528, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-755, 660, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-750, 680, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-747, 632, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-728, 570, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-713, 544, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-735, 551, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-683, 595, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-632, 682, 20));
		AddSpawnPoint("d_cmine_01.Id6", "d_cmine_01", Rectangle(-635, 701, 20));

		// 'Whip_Vine_Ra' GenType 519 Spawn Points
		AddSpawnPoint("d_cmine_01.Id7", "d_cmine_01", Rectangle(488, -94, 20));
		AddSpawnPoint("d_cmine_01.Id7", "d_cmine_01", Rectangle(494, -42, 20));
		AddSpawnPoint("d_cmine_01.Id7", "d_cmine_01", Rectangle(520, -51, 20));
		AddSpawnPoint("d_cmine_01.Id7", "d_cmine_01", Rectangle(518, -82, 20));
		AddSpawnPoint("d_cmine_01.Id7", "d_cmine_01", Rectangle(519, -87, 20));
		AddSpawnPoint("d_cmine_01.Id7", "d_cmine_01", Rectangle(545, -82, 20));
		AddSpawnPoint("d_cmine_01.Id7", "d_cmine_01", Rectangle(544, -28, 20));
		AddSpawnPoint("d_cmine_01.Id7", "d_cmine_01", Rectangle(533, 14, 20));
		AddSpawnPoint("d_cmine_01.Id7", "d_cmine_01", Rectangle(580, 20, 20));
		AddSpawnPoint("d_cmine_01.Id7", "d_cmine_01", Rectangle(613, -24, 20));
		AddSpawnPoint("d_cmine_01.Id7", "d_cmine_01", Rectangle(565, -7, 20));
		AddSpawnPoint("d_cmine_01.Id7", "d_cmine_01", Rectangle(594, -38, 20));
		AddSpawnPoint("d_cmine_01.Id7", "d_cmine_01", Rectangle(587, -70, 20));
		AddSpawnPoint("d_cmine_01.Id7", "d_cmine_01", Rectangle(571, -101, 20));
		AddSpawnPoint("d_cmine_01.Id7", "d_cmine_01", Rectangle(597, -125, 20));
		AddSpawnPoint("d_cmine_01.Id7", "d_cmine_01", Rectangle(608, -145, 20));
		AddSpawnPoint("d_cmine_01.Id7", "d_cmine_01", Rectangle(638, -110, 20));
		AddSpawnPoint("d_cmine_01.Id7", "d_cmine_01", Rectangle(612, -114, 20));
		AddSpawnPoint("d_cmine_01.Id7", "d_cmine_01", Rectangle(593, -109, 20));
		AddSpawnPoint("d_cmine_01.Id7", "d_cmine_01", Rectangle(569, -55, 20));
		AddSpawnPoint("d_cmine_01.Id7", "d_cmine_01", Rectangle(522, -15, 20));
		AddSpawnPoint("d_cmine_01.Id7", "d_cmine_01", Rectangle(568, -115, 20));
		AddSpawnPoint("d_cmine_01.Id7", "d_cmine_01", Rectangle(605, -166, 20));
		AddSpawnPoint("d_cmine_01.Id7", "d_cmine_01", Rectangle(658, -127, 20));
		AddSpawnPoint("d_cmine_01.Id7", "d_cmine_01", Rectangle(492, -66, 20));
		AddSpawnPoint("d_cmine_01.Id7", "d_cmine_01", Rectangle(471, -81, 20));
		AddSpawnPoint("d_cmine_01.Id7", "d_cmine_01", Rectangle(546, 38, 20));
		AddSpawnPoint("d_cmine_01.Id7", "d_cmine_01", Rectangle(596, 35, 20));
		AddSpawnPoint("d_cmine_01.Id7", "d_cmine_01", Rectangle(574, 38, 20));

		// 'Whip_Vine_Ra' GenType 520 Spawn Points
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1292, 488, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1300, 502, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1311, 518, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1319, 544, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1325, 565, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1335, 586, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1328, 609, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1315, 631, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1298, 656, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1318, 670, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1339, 644, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1355, 616, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1376, 594, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1348, 606, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1370, 578, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1361, 555, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1350, 535, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1341, 510, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1364, 500, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1416, 535, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1418, 566, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1446, 525, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1430, 500, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1405, 479, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1379, 471, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1353, 472, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1334, 482, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1315, 450, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1268, 466, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1288, 462, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1334, 463, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1371, 451, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1409, 454, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1408, 489, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1446, 464, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1468, 484, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1475, 492, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1434, 466, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1397, 542, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1410, 557, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1328, 525, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1338, 556, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1345, 571, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1325, 627, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1323, 649, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1280, 480, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1443, 482, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1409, 510, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1386, 497, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1343, 493, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1386, 535, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1330, 571, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1324, 555, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1314, 535, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1324, 600, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1325, 639, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1297, 656, 20));
		AddSpawnPoint("d_cmine_01.Id8", "d_cmine_01", Rectangle(1304, 674, 20));

		// 'StonOrca' GenType 531 Spawn Points
		AddSpawnPoint("d_cmine_01.Id9", "d_cmine_01", Rectangle(266, 1246, 30));
		AddSpawnPoint("d_cmine_01.Id9", "d_cmine_01", Rectangle(453, -583, 30));

		// 'Goblin_Miners' GenType 532 Spawn Points
		AddSpawnPoint("d_cmine_01.Id10", "d_cmine_01", Rectangle(-584, -947, 150));

		// 'Bat' GenType 534 Spawn Points
		AddSpawnPoint("d_cmine_01.Id11", "d_cmine_01", Rectangle(-25, -144, 9999));

		// 'Goblin_Miners_Q1' GenType 535 Spawn Points
		AddSpawnPoint("d_cmine_01.Id12", "d_cmine_01", Rectangle(-723, -892, 300));
	}
}
