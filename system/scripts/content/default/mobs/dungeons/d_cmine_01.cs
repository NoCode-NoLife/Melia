//--- Melia Script -----------------------------------------------------------
// d_cmine_01
//
//--- Description -----------------------------------------------------------
// Sets up the d_cmine_01 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DCmine01MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("d_cmine_01", MonsterId.Goblin_Miners, Properties("MHP", 5506, "MINPATK", 333, "MAXPATK", 359, "MINMATK", 333, "MAXMATK", 359, "DEF", 33, "MDEF", 33));
		AddPropertyOverrides("d_cmine_01", MonsterId.Bat, Properties("MHP", 5118, "MINPATK", 315, "MAXPATK", 340, "MINMATK", 315, "MAXMATK", 340, "DEF", 31, "MDEF", 31));
		AddPropertyOverrides("d_cmine_01", MonsterId.StonOrca, Properties("MHP", 6322, "MINPATK", 370, "MAXPATK", 400, "MINMATK", 370, "MAXMATK", 400, "DEF", 37, "MDEF", 37));
		AddPropertyOverrides("d_cmine_01", MonsterId.Whip_Vine_Ra, Properties("MHP", 4744, "MINPATK", 298, "MAXPATK", 322, "MINMATK", 298, "MAXMATK", 322, "DEF", 29, "MDEF", 29));
		AddPropertyOverrides("d_cmine_01", MonsterId.Goblin_Miners_Q1, Properties("MHP", 5908, "MINPATK", 351, "MAXPATK", 379, "MINMATK", 351, "MAXMATK", 379, "DEF", 35, "MDEF", 35));

		// Monster Spawners --------------------------------

		AddSpawner("d_cmine_01.Id1", MonsterId.Rootcrystal_01, 15, TimeSpan.FromMilliseconds(80000), TendencyType.Peaceful);
		AddSpawner("d_cmine_01.Id2", MonsterId.Goblin_Miners, 27, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cmine_01.Id3", MonsterId.Goblin_Miners, 7, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cmine_01.Id4", MonsterId.Bat, 8, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cmine_01.Id5", MonsterId.StonOrca, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cmine_01.Id6", MonsterId.Whip_Vine_Ra, 30, TimeSpan.FromMilliseconds(180000), TendencyType.Aggressive);
		AddSpawner("d_cmine_01.Id7", MonsterId.Whip_Vine_Ra, 30, TimeSpan.FromMilliseconds(180000), TendencyType.Aggressive);
		AddSpawner("d_cmine_01.Id8", MonsterId.Whip_Vine_Ra, 30, TimeSpan.FromMilliseconds(180000), TendencyType.Aggressive);
		AddSpawner("d_cmine_01.Id9", MonsterId.StonOrca, 3, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cmine_01.Id10", MonsterId.Goblin_Miners, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cmine_01.Id11", MonsterId.Bat, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_cmine_01.Id12", MonsterId.Goblin_Miners_Q1, 2, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "d_cmine_01.Id1", "d_cmine_01", Spot(-824, -1378, 10));
		AddSpawnPoint( "d_cmine_01.Id1", "d_cmine_01", Spot(-1121.86, -1317.4, 10));
		AddSpawnPoint( "d_cmine_01.Id1", "d_cmine_01", Spot(-457, -884, 10));
		AddSpawnPoint( "d_cmine_01.Id1", "d_cmine_01", Spot(-362, -370, 10));
		AddSpawnPoint( "d_cmine_01.Id1", "d_cmine_01", Spot(-324.8, -660.38, 10));
		AddSpawnPoint( "d_cmine_01.Id1", "d_cmine_01", Spot(-783.09, -900.37, 10));
		AddSpawnPoint( "d_cmine_01.Id1", "d_cmine_01", Spot(-1137.53, -1505.68, 10));
		AddSpawnPoint( "d_cmine_01.Id1", "d_cmine_01", Spot(-715, -205, 10));
		AddSpawnPoint( "d_cmine_01.Id1", "d_cmine_01", Spot(71, -232, 10));
		AddSpawnPoint( "d_cmine_01.Id1", "d_cmine_01", Spot(319, 167, 10));
		AddSpawnPoint( "d_cmine_01.Id1", "d_cmine_01", Spot(522, -356, 10));
		AddSpawnPoint( "d_cmine_01.Id1", "d_cmine_01", Spot(472, -865, 10));
		AddSpawnPoint( "d_cmine_01.Id1", "d_cmine_01", Spot(1130, -1116, 10));
		AddSpawnPoint( "d_cmine_01.Id1", "d_cmine_01", Spot(1301, -943, 10));
		AddSpawnPoint( "d_cmine_01.Id1", "d_cmine_01", Spot(832, 54, 10));
		AddSpawnPoint( "d_cmine_01.Id1", "d_cmine_01", Spot(1437, 290, 10));
		AddSpawnPoint( "d_cmine_01.Id1", "d_cmine_01", Spot(1354, 499, 10));
		AddSpawnPoint( "d_cmine_01.Id1", "d_cmine_01", Spot(570, 657, 10));
		AddSpawnPoint( "d_cmine_01.Id1", "d_cmine_01", Spot(783, 801, 10));
		AddSpawnPoint( "d_cmine_01.Id1", "d_cmine_01", Spot(331, 1149, 10));
		AddSpawnPoint( "d_cmine_01.Id1", "d_cmine_01", Spot(99, 1158, 10));
		AddSpawnPoint( "d_cmine_01.Id1", "d_cmine_01", Spot(-41.00584, 1090.3312, 10));
		AddSpawnPoint( "d_cmine_01.Id1", "d_cmine_01", Spot(-138, 804, 10));
		AddSpawnPoint( "d_cmine_01.Id1", "d_cmine_01", Spot(-268, 766, 10));
		AddSpawnPoint( "d_cmine_01.Id1", "d_cmine_01", Spot(-726, 550, 10));
		AddSpawnPoint( "d_cmine_01.Id1", "d_cmine_01", Spot(-996, 297, 10));
		AddSpawnPoint( "d_cmine_01.Id1", "d_cmine_01", Spot(-1196, 411, 10));
		AddSpawnPoint( "d_cmine_01.Id1", "d_cmine_01", Spot(-1330, 754, 10));
		AddSpawnPoint( "d_cmine_01.Id1", "d_cmine_01", Spot(-1509, 552, 10));

		// Goblin_Miners Spawn Points
		AddSpawnPoint( "d_cmine_01.Id2", "d_cmine_01", Spot(-123.54, -189.62, 9999));
		AddSpawnPoint( "d_cmine_01.Id3", "d_cmine_01", Spot(-168.78, -156.23, 30));
		AddSpawnPoint( "d_cmine_01.Id3", "d_cmine_01", Spot(1412.7, 390.66, 30));
		AddSpawnPoint( "d_cmine_01.Id3", "d_cmine_01", Spot(615.81, 645.62, 30));
		AddSpawnPoint( "d_cmine_01.Id3", "d_cmine_01", Spot(334.52, 180.35, 30));
		AddSpawnPoint( "d_cmine_01.Id3", "d_cmine_01", Spot(1286.06, -1004.25, 30));
		AddSpawnPoint( "d_cmine_01.Id3", "d_cmine_01", Spot(106.07, 1098.22, 30));
		AddSpawnPoint( "d_cmine_01.Id3", "d_cmine_01", Spot(-1024, 524, 30));
		AddSpawnPoint( "d_cmine_01.Id3", "d_cmine_01", Spot(458, -601, 30));
		AddSpawnPoint( "d_cmine_01.Id3", "d_cmine_01", Spot(-744.52905, -893.3791, 30));

		// Bat Spawn Points
		AddSpawnPoint( "d_cmine_01.Id4", "d_cmine_01", Spot(-1152.2, 382.05, 30));
		AddSpawnPoint( "d_cmine_01.Id4", "d_cmine_01", Spot(-1081.48, 580.54, 30));
		AddSpawnPoint( "d_cmine_01.Id4", "d_cmine_01", Spot(-485.89, -949.08, 30));
		AddSpawnPoint( "d_cmine_01.Id4", "d_cmine_01", Spot(-1007, 220, 30));
		AddSpawnPoint( "d_cmine_01.Id4", "d_cmine_01", Spot(-459.79, -818.09, 30));
		AddSpawnPoint( "d_cmine_01.Id4", "d_cmine_01", Spot(-813.27, -1083.83, 30));

		// StonOrca Spawn Points
		AddSpawnPoint( "d_cmine_01.Id5", "d_cmine_01", Spot(209.66, 1063.9, 500));
		AddSpawnPoint( "d_cmine_01.Id5", "d_cmine_01", Spot(1243.91, 235.44, 500));
		AddSpawnPoint( "d_cmine_01.Id5", "d_cmine_01", Spot(1129.34, -1074.05, 500));

		// Whip_Vine_Ra Spawn Points
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-661, 523, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-659, 543, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-659, 543, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-652, 608, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-664, 595, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-664, 595, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-668, 571, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-680, 519, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-697, 562, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-696, 586, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-681, 622, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-686, 660, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-654, 689, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-640, 722, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-647, 629, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-627, 626, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-629, 644, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-614, 653, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-658, 664, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-673, 645, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-671, 711, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-706, 662, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-709, 622, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-696, 683, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-731, 699, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-711, 644, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-733, 612, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-716, 589, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-689, 539, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-703, 521, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-704, 711, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-724, 528, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-755, 660, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-750, 680, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-747, 632, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-728, 570, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-713, 544, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-735, 551, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-683, 595, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-632, 682, 20));
		AddSpawnPoint( "d_cmine_01.Id6", "d_cmine_01", Spot(-635, 701, 20));
		AddSpawnPoint( "d_cmine_01.Id7", "d_cmine_01", Spot(488, -94, 20));
		AddSpawnPoint( "d_cmine_01.Id7", "d_cmine_01", Spot(494, -42, 20));
		AddSpawnPoint( "d_cmine_01.Id7", "d_cmine_01", Spot(520, -51, 20));
		AddSpawnPoint( "d_cmine_01.Id7", "d_cmine_01", Spot(518, -82, 20));
		AddSpawnPoint( "d_cmine_01.Id7", "d_cmine_01", Spot(519, -87, 20));
		AddSpawnPoint( "d_cmine_01.Id7", "d_cmine_01", Spot(545, -82, 20));
		AddSpawnPoint( "d_cmine_01.Id7", "d_cmine_01", Spot(544, -28, 20));
		AddSpawnPoint( "d_cmine_01.Id7", "d_cmine_01", Spot(533, 14, 20));
		AddSpawnPoint( "d_cmine_01.Id7", "d_cmine_01", Spot(580, 20, 20));
		AddSpawnPoint( "d_cmine_01.Id7", "d_cmine_01", Spot(613.95, -24.77, 20));
		AddSpawnPoint( "d_cmine_01.Id7", "d_cmine_01", Spot(565, -7, 20));
		AddSpawnPoint( "d_cmine_01.Id7", "d_cmine_01", Spot(594, -38, 20));
		AddSpawnPoint( "d_cmine_01.Id7", "d_cmine_01", Spot(587, -70, 20));
		AddSpawnPoint( "d_cmine_01.Id7", "d_cmine_01", Spot(571, -101, 20));
		AddSpawnPoint( "d_cmine_01.Id7", "d_cmine_01", Spot(597, -125, 20));
		AddSpawnPoint( "d_cmine_01.Id7", "d_cmine_01", Spot(608, -145, 20));
		AddSpawnPoint( "d_cmine_01.Id7", "d_cmine_01", Spot(638, -110, 20));
		AddSpawnPoint( "d_cmine_01.Id7", "d_cmine_01", Spot(612, -114, 20));
		AddSpawnPoint( "d_cmine_01.Id7", "d_cmine_01", Spot(593, -109, 20));
		AddSpawnPoint( "d_cmine_01.Id7", "d_cmine_01", Spot(569, -55, 20));
		AddSpawnPoint( "d_cmine_01.Id7", "d_cmine_01", Spot(522, -15, 20));
		AddSpawnPoint( "d_cmine_01.Id7", "d_cmine_01", Spot(568, -115, 20));
		AddSpawnPoint( "d_cmine_01.Id7", "d_cmine_01", Spot(605, -166, 20));
		AddSpawnPoint( "d_cmine_01.Id7", "d_cmine_01", Spot(658, -127, 20));
		AddSpawnPoint( "d_cmine_01.Id7", "d_cmine_01", Spot(492, -66, 20));
		AddSpawnPoint( "d_cmine_01.Id7", "d_cmine_01", Spot(471, -81, 20));
		AddSpawnPoint( "d_cmine_01.Id7", "d_cmine_01", Spot(546, 38, 20));
		AddSpawnPoint( "d_cmine_01.Id7", "d_cmine_01", Spot(596, 35, 20));
		AddSpawnPoint( "d_cmine_01.Id7", "d_cmine_01", Spot(574, 38, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1292, 488, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1300, 502, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1311, 518, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1319, 544, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1325, 565, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1335, 586, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1328, 609, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1315, 631, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1298, 656, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1318, 670, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1339, 644, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1355, 616, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1376, 594, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1348, 606, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1370, 578, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1361, 555, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1350, 535, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1341, 510, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1364, 500, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1416, 535, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1418, 566, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1446, 525, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1430, 500, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1405, 479, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1379, 471, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1353, 472, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1334, 482, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1315, 450, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1268, 466, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1288, 462, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1334, 463, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1371, 451, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1409, 454, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1408, 489, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1446, 464, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1468, 484, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1475, 492, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1434, 466, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1397, 542, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1410, 557, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1328, 525, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1338, 556, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1345, 571, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1325, 627, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1323, 649, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1280, 480, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1443, 482, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1409, 510, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1386, 497, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1343, 493, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1386, 535, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1330, 571, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1324, 555, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1314, 535, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1324, 600, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1325, 639, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1297, 656, 20));
		AddSpawnPoint( "d_cmine_01.Id8", "d_cmine_01", Spot(1304, 674, 20));

		// StonOrca Spawn Points
		AddSpawnPoint( "d_cmine_01.Id9", "d_cmine_01", Spot(266.83, 1246.91, 30));
		AddSpawnPoint( "d_cmine_01.Id9", "d_cmine_01", Spot(453.28, -583.85, 30));

		// Goblin_Miners Spawn Points
		AddSpawnPoint( "d_cmine_01.Id10", "d_cmine_01", Spot(-584.66, -947, 150));

		// Bat Spawn Points
		AddSpawnPoint( "d_cmine_01.Id11", "d_cmine_01", Spot(-25.03, -144.09, 9999));

		// Goblin_Miners_Q1 Spawn Points
		AddSpawnPoint( "d_cmine_01.Id12", "d_cmine_01", Spot(-723.60004, -892.29486, 300));

	}
}
