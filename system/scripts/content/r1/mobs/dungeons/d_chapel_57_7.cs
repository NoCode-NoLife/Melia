//--- Melia Script -----------------------------------------------------------
// d_chapel_57_7
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Tenet Church 2F' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DChapel577MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_chapel_57_7", MonsterId.Spector_Gh, Properties("MHP", 24417, "MINPATK", 815, "MAXPATK", 904, "MINMATK", 815, "MAXMATK", 904, "DEF", 75, "MDEF", 75));
		AddPropertyOverrides("d_chapel_57_7", MonsterId.Egnome, Properties("MHP", 24891, "MINPATK", 821, "MAXPATK", 911, "MINMATK", 821, "MAXMATK", 911, "DEF", 76, "MDEF", 76));
		AddPropertyOverrides("d_chapel_57_7", MonsterId.Colitile, Properties("MHP", 25370, "MINPATK", 827, "MAXPATK", 919, "MINMATK", 827, "MAXMATK", 919, "DEF", 76, "MDEF", 76));
		AddPropertyOverrides("d_chapel_57_7", MonsterId.Infroholder_Bow, Properties("MHP", 25856, "MINPATK", 833, "MAXPATK", 926, "MINMATK", 833, "MAXMATK", 926, "DEF", 76, "MDEF", 76));
		AddPropertyOverrides("d_chapel_57_7", MonsterId.Boss_Necrovanter, Properties("MHP", 121728, "MINPATK", 1612, "MAXPATK", 1794, "MINMATK", 1612, "MAXMATK", 1794, "DEF", 147, "MDEF", 147));
		AddPropertyOverrides("d_chapel_57_7", MonsterId.Boss_Gesti, Properties("MHP", 440274, "MINPATK", 2090, "MAXPATK", 2327, "MINMATK", 2090, "MAXMATK", 2327, "DEF", 190, "MDEF", 190));

		// Monster Spawners ---------------------------------

		AddSpawner("d_chapel_57_7.Id1", MonsterId.Rootcrystal_01, 12, 15, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("d_chapel_57_7.Id2", MonsterId.Spector_Gh, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_chapel_57_7.Id3", MonsterId.Egnome, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_chapel_57_7.Id4", MonsterId.Spector_Gh, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_chapel_57_7.Id5", MonsterId.Egnome, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_chapel_57_7.Id6", MonsterId.Colitile, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_chapel_57_7.Id7", MonsterId.Infroholder_Bow, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 21 Spawn Points
		AddSpawnPoint("d_chapel_57_7.Id1", "d_chapel_57_7", Rectangle(-312.7185, -984.02814, 200));
		AddSpawnPoint("d_chapel_57_7.Id1", "d_chapel_57_7", Rectangle(-331.36154, -688.5203, 200));
		AddSpawnPoint("d_chapel_57_7.Id1", "d_chapel_57_7", Rectangle(-17.402885, -794.48395, 200));
		AddSpawnPoint("d_chapel_57_7.Id1", "d_chapel_57_7", Rectangle(-987.7939, -262.22083, 200));
		AddSpawnPoint("d_chapel_57_7.Id1", "d_chapel_57_7", Rectangle(-807.88824, 36.661736, 200));
		AddSpawnPoint("d_chapel_57_7.Id1", "d_chapel_57_7", Rectangle(-425.98438, -113.73592, 200));
		AddSpawnPoint("d_chapel_57_7.Id1", "d_chapel_57_7", Rectangle(66.84832, -118.77759, 200));
		AddSpawnPoint("d_chapel_57_7.Id1", "d_chapel_57_7", Rectangle(461.5652, -122.46444, 200));
		AddSpawnPoint("d_chapel_57_7.Id1", "d_chapel_57_7", Rectangle(831.5559, -190.80408, 200));
		AddSpawnPoint("d_chapel_57_7.Id1", "d_chapel_57_7", Rectangle(957.9137, -64.41771, 200));
		AddSpawnPoint("d_chapel_57_7.Id1", "d_chapel_57_7", Rectangle(1412.5435, -144.9969, 200));
		AddSpawnPoint("d_chapel_57_7.Id1", "d_chapel_57_7", Rectangle(-92.374146, 390.1818, 200));
		AddSpawnPoint("d_chapel_57_7.Id1", "d_chapel_57_7", Rectangle(18.656631, 649.89514, 200));
		AddSpawnPoint("d_chapel_57_7.Id1", "d_chapel_57_7", Rectangle(99.58869, 1181.6218, 200));
		AddSpawnPoint("d_chapel_57_7.Id1", "d_chapel_57_7", Rectangle(-121.56802, 1352.7853, 200));
		AddSpawnPoint("d_chapel_57_7.Id1", "d_chapel_57_7", Rectangle(1644.5834, -2.701645, 200));
		AddSpawnPoint("d_chapel_57_7.Id1", "d_chapel_57_7", Rectangle(-369.4769, -458.8756, 200));

		// 'Spector_Gh' GenType 31 Spawn Points
		AddSpawnPoint("d_chapel_57_7.Id2", "d_chapel_57_7", Rectangle(13.558617, 641.35345, 200));
		AddSpawnPoint("d_chapel_57_7.Id2", "d_chapel_57_7", Rectangle(-35.020004, 314.71228, 200));
		AddSpawnPoint("d_chapel_57_7.Id2", "d_chapel_57_7", Rectangle(689.5465, -112.91242, 200));
		AddSpawnPoint("d_chapel_57_7.Id2", "d_chapel_57_7", Rectangle(976.9662, -114.31064, 200));

		// 'Egnome' GenType 52 Spawn Points
		AddSpawnPoint("d_chapel_57_7.Id3", "d_chapel_57_7", Rectangle(1645.4706, -32.32468, 100));
		AddSpawnPoint("d_chapel_57_7.Id3", "d_chapel_57_7", Rectangle(1617.9683, -231.32451, 100));
		AddSpawnPoint("d_chapel_57_7.Id3", "d_chapel_57_7", Rectangle(1435.481, -266.87866, 100));
		AddSpawnPoint("d_chapel_57_7.Id3", "d_chapel_57_7", Rectangle(1396.905, 13.652201, 100));
		AddSpawnPoint("d_chapel_57_7.Id3", "d_chapel_57_7", Rectangle(1528.5339, 32.775326, 100));
		AddSpawnPoint("d_chapel_57_7.Id3", "d_chapel_57_7", Rectangle(1319.8317, -111.50265, 100));

		// 'Spector_Gh' GenType 53 Spawn Points
		AddSpawnPoint("d_chapel_57_7.Id4", "d_chapel_57_7", Rectangle(804.69116, -225.06488, 80));
		AddSpawnPoint("d_chapel_57_7.Id4", "d_chapel_57_7", Rectangle(1036.9054, -136.44106, 80));
		AddSpawnPoint("d_chapel_57_7.Id4", "d_chapel_57_7", Rectangle(725.8101, -14.945456, 80));
		AddSpawnPoint("d_chapel_57_7.Id4", "d_chapel_57_7", Rectangle(-653.1434, -161.57831, 80));
		AddSpawnPoint("d_chapel_57_7.Id4", "d_chapel_57_7", Rectangle(-466.71957, -61.882465, 80));
		AddSpawnPoint("d_chapel_57_7.Id4", "d_chapel_57_7", Rectangle(-1002.8906, -237.56174, 80));
		AddSpawnPoint("d_chapel_57_7.Id4", "d_chapel_57_7", Rectangle(-1037.8568, 25.33712, 80));
		AddSpawnPoint("d_chapel_57_7.Id4", "d_chapel_57_7", Rectangle(-1161.0284, -80.94681, 80));
		AddSpawnPoint("d_chapel_57_7.Id4", "d_chapel_57_7", Rectangle(-662.815, -62.32448, 80));
		AddSpawnPoint("d_chapel_57_7.Id4", "d_chapel_57_7", Rectangle(834.9654, -121.00164, 80));
		AddSpawnPoint("d_chapel_57_7.Id4", "d_chapel_57_7", Rectangle(903.0916, 54.592842, 80));
		AddSpawnPoint("d_chapel_57_7.Id4", "d_chapel_57_7", Rectangle(1453.5646, 17.871685, 80));
		AddSpawnPoint("d_chapel_57_7.Id4", "d_chapel_57_7", Rectangle(1667.5527, -92.59473, 80));
		AddSpawnPoint("d_chapel_57_7.Id4", "d_chapel_57_7", Rectangle(1413.9121, -233.67856, 80));
		AddSpawnPoint("d_chapel_57_7.Id4", "d_chapel_57_7", Rectangle(1590.0967, -223.7696, 80));
		AddSpawnPoint("d_chapel_57_7.Id4", "d_chapel_57_7", Rectangle(684.0124, -193.87234, 80));

		// 'Egnome' GenType 55 Spawn Points
		AddSpawnPoint("d_chapel_57_7.Id5", "d_chapel_57_7", Rectangle(-1009.5104, 85.80767, 100));
		AddSpawnPoint("d_chapel_57_7.Id5", "d_chapel_57_7", Rectangle(-577.8257, -85.12007, 100));
		AddSpawnPoint("d_chapel_57_7.Id5", "d_chapel_57_7", Rectangle(-1033.0339, -292.46136, 100));
		AddSpawnPoint("d_chapel_57_7.Id5", "d_chapel_57_7", Rectangle(21.154922, 600.95166, 100));
		AddSpawnPoint("d_chapel_57_7.Id5", "d_chapel_57_7", Rectangle(-34.449585, 271.76343, 100));
		AddSpawnPoint("d_chapel_57_7.Id5", "d_chapel_57_7", Rectangle(-59.72933, 1184.4061, 100));
		AddSpawnPoint("d_chapel_57_7.Id5", "d_chapel_57_7", Rectangle(-107.02019, 1477.2241, 100));
		AddSpawnPoint("d_chapel_57_7.Id5", "d_chapel_57_7", Rectangle(141.76361, 1516.4441, 100));
		AddSpawnPoint("d_chapel_57_7.Id5", "d_chapel_57_7", Rectangle(163.049, 1242.3853, 100));
		AddSpawnPoint("d_chapel_57_7.Id5", "d_chapel_57_7", Rectangle(-739.0796, -31.026085, 100));
		AddSpawnPoint("d_chapel_57_7.Id5", "d_chapel_57_7", Rectangle(-796.97784, -177.09946, 100));
		AddSpawnPoint("d_chapel_57_7.Id5", "d_chapel_57_7", Rectangle(-1019.7556, -5.999832, 100));
		AddSpawnPoint("d_chapel_57_7.Id5", "d_chapel_57_7", Rectangle(-1031.0455, -204.24913, 100));
		AddSpawnPoint("d_chapel_57_7.Id5", "d_chapel_57_7", Rectangle(-1077.3646, -113.30778, 100));
		AddSpawnPoint("d_chapel_57_7.Id5", "d_chapel_57_7", Rectangle(-682.8547, -195.58786, 100));
		AddSpawnPoint("d_chapel_57_7.Id5", "d_chapel_57_7", Rectangle(-831.8868, 16.709843, 100));

		// 'Colitile' GenType 56 Spawn Points
		AddSpawnPoint("d_chapel_57_7.Id6", "d_chapel_57_7", Rectangle(-72.174286, 625.67194, 9999));

		// 'Infroholder_Bow' GenType 58 Spawn Points
		AddSpawnPoint("d_chapel_57_7.Id7", "d_chapel_57_7", Rectangle(1388.0756, -219.34142, 40));
		AddSpawnPoint("d_chapel_57_7.Id7", "d_chapel_57_7", Rectangle(1472.3042, 25.19192, 40));
		AddSpawnPoint("d_chapel_57_7.Id7", "d_chapel_57_7", Rectangle(1593.866, -229.85742, 40));
		AddSpawnPoint("d_chapel_57_7.Id7", "d_chapel_57_7", Rectangle(1612.4022, 22.398144, 40));
		AddSpawnPoint("d_chapel_57_7.Id7", "d_chapel_57_7", Rectangle(-1056.1582, -299.54785, 40));
		AddSpawnPoint("d_chapel_57_7.Id7", "d_chapel_57_7", Rectangle(-1095.3032, 49.782677, 40));
		AddSpawnPoint("d_chapel_57_7.Id7", "d_chapel_57_7", Rectangle(-1137.0311, -199.9106, 40));
		AddSpawnPoint("d_chapel_57_7.Id7", "d_chapel_57_7", Rectangle(-141.26083, 1235.1079, 40));
		AddSpawnPoint("d_chapel_57_7.Id7", "d_chapel_57_7", Rectangle(-19.533329, 1069.3156, 40));
		AddSpawnPoint("d_chapel_57_7.Id7", "d_chapel_57_7", Rectangle(107.36743, 1283.6523, 40));
		AddSpawnPoint("d_chapel_57_7.Id7", "d_chapel_57_7", Rectangle(-843.4053, 80.34251, 40));
		AddSpawnPoint("d_chapel_57_7.Id7", "d_chapel_57_7", Rectangle(912.92, -172.67181, 40));
		AddSpawnPoint("d_chapel_57_7.Id7", "d_chapel_57_7", Rectangle(845.3407, 6.137123, 40));
		AddSpawnPoint("d_chapel_57_7.Id7", "d_chapel_57_7", Rectangle(713.59753, -178.59166, 40));
		AddSpawnPoint("d_chapel_57_7.Id7", "d_chapel_57_7", Rectangle(-150.22653, 673.5657, 40));
		AddSpawnPoint("d_chapel_57_7.Id7", "d_chapel_57_7", Rectangle(-4.4503174, 393.0881, 40));
		AddSpawnPoint("d_chapel_57_7.Id7", "d_chapel_57_7", Rectangle(113.86145, 652.7977, 40));
		AddSpawnPoint("d_chapel_57_7.Id7", "d_chapel_57_7", Rectangle(-882.8235, -202.85866, 40));
		AddSpawnPoint("d_chapel_57_7.Id7", "d_chapel_57_7", Rectangle(-965.8997, 76.05083, 40));
		AddSpawnPoint("d_chapel_57_7.Id7", "d_chapel_57_7", Rectangle(1620.3414, -106.8306, 40));
		AddSpawnPoint("d_chapel_57_7.Id7", "d_chapel_57_7", Rectangle(-158.84167, 477.05743, 40));
		AddSpawnPoint("d_chapel_57_7.Id7", "d_chapel_57_7", Rectangle(-851.0355, -75.34651, 40));
		AddSpawnPoint("d_chapel_57_7.Id7", "d_chapel_57_7", Rectangle(-983.6894, -222.50768, 40));
		AddSpawnPoint("d_chapel_57_7.Id7", "d_chapel_57_7", Rectangle(-1117.3322, -98.44747, 40));
		AddSpawnPoint("d_chapel_57_7.Id7", "d_chapel_57_7", Rectangle(-839.17596, -273.9794, 40));
		AddSpawnPoint("d_chapel_57_7.Id7", "d_chapel_57_7", Rectangle(-783.89075, -15.205099, 40));
	}
}
