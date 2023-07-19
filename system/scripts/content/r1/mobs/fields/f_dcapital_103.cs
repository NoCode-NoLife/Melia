//--- Melia Script -----------------------------------------------------------
// f_dcapital_103
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Taniel I Commemorative Orb' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FDcapital103MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_dcapital_103", MonsterId.Goblin2_Sword_Green, Properties("MHP", 747642, "MINPATK", 10115, "MAXPATK", 12334, "MINMATK", 10115, "MAXMATK", 12334, "DEF", 225179, "MDEF", 225179));
		AddPropertyOverrides("f_dcapital_103", MonsterId.Goblin2_Hammer_Green, Properties("MHP", 747899, "MINPATK", 10118, "MAXPATK", 12338, "MINMATK", 10118, "MAXMATK", 12338, "DEF", 225395, "MDEF", 225395));
		AddPropertyOverrides("f_dcapital_103", MonsterId.Goblin2_Wand1_Green, Properties("MHP", 748368, "MINPATK", 10124, "MAXPATK", 12345, "MINMATK", 10124, "MAXMATK", 12345, "DEF", 225791, "MDEF", 225791));
		AddPropertyOverrides("f_dcapital_103", MonsterId.Goblin2_Wand3_Green, Properties("MHP", 748976, "MINPATK", 10132, "MAXPATK", 12355, "MINMATK", 10132, "MAXMATK", 12355, "DEF", 226303, "MDEF", 226303));

		// Monster Spawners ---------------------------------

		AddSpawner("f_dcapital_103.Id1", MonsterId.Rootcrystal_01, 13, 17, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_dcapital_103.Id2", MonsterId.Goblin2_Sword_Green, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_dcapital_103.Id3", MonsterId.Goblin2_Hammer_Green, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_dcapital_103.Id4", MonsterId.Goblin2_Wand1_Green, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_dcapital_103.Id5", MonsterId.Goblin2_Wand3_Green, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_dcapital_103.Id6", MonsterId.Goblin2_Hammer_Green, 5, 6, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 5 Spawn Points
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(650.2459, -1458.7185, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(509.64935, -1218.9905, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(291.51083, -1204.1484, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(411.30725, -761.8045, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(625.30035, -675.0162, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(482.9369, -246.05096, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(-110.66626, -1288.3196, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(-400.55423, -1228.4658, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(-511.38928, -546.42084, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(-342.80978, -258.96973, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(-17.20773, -492.6292, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(1033.286, -676.4072, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(1414.4767, -608.29974, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(1123.839, 314.09402, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(1184.9052, 676.0218, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(-511.4462, 248.3074, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(-954.7269, 217.87906, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(-1332.4907, 261.26254, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(41.462486, 390.74377, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(306.84036, 546.1785, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(-172.33153, 938.92584, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(-106.1794, 1307.4177, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(272.9189, 925.68506, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(681.1777, 1142.9824, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(1061.1774, 1155.6927, 50));

		// 'Goblin2_Sword_Green' GenType 300 Spawn Points
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(481.53052, -683.325, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(414.6779, -1253.2045, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(-302.84824, -424.87085, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(427.01642, -151.12907, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(1235.5266, 444.6203, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(-1219.023, 442.1408, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(882.7207, 1086.5862, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(1053.1699, 1234.6895, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(777.4564, 1264.2339, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(638.71405, 1111.021, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(-1182.1393, 254.09534, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(-1254.7379, 77.174675, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(-1382.203, 307.14435, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(-933.1593, 201.16563, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(-211.08276, -362.99615, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(-253.0707, -597.4956, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(-539.99146, -482.90714, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(-403.72125, -253.88538, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(-23.018501, -519.7837, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(619.60944, -668.09674, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(497.7107, -566.0591, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(316.97394, -740.6425, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(468.67694, -329.38498, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(314.08917, -125.52525, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(496.45782, -93.31499, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(1208.9243, 238.47041, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(993.32184, 296.89996, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(1438.5688, 473.41544, 45));

		// 'Goblin2_Hammer_Green' GenType 301 Spawn Points
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(347.9127, -1251.3513, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(-306.40897, -1404.0201, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(-143.4074, -1270.268, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(-430.67422, -1235.5409, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(618.2777, -1435.1135, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(394.25958, -1489.4883, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(479.247, -1100.476, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(-406.31396, -587.6923, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(-545.8965, -310.31976, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(-143.58997, -281.1495, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(1016.1105, -675.0879, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(1208.1573, -545.28436, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(1333.0416, -713.4623, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(1455.2792, -533.40375, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(1155.0732, 331.22845, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(1190.4899, 721.54095, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(1412.6125, 383.18594, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(986.72296, 403.4257, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(302.12936, 494.99133, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(99.36224, 319.0689, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(-431.56448, 303.66095, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(-1068.7129, 315.24847, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(-1323.5344, 207.45425, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(-205.23346, 996.6743, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(161.75201, 1066.491, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(93.19721, 850.5405, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(168.78217, 514.3546, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(1189.4373, -773.06616, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(1319.8566, -583.0307, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(488.83856, -1329.1151, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(-285.86798, -1300.0424, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(1321.0286, 221.03484, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(168.29797, 417.93842, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(-41.52694, 940.01886, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(-1070.5747, 169.21127, 40));

		// 'Goblin2_Wand1_Green' GenType 302 Spawn Points
		AddSpawnPoint("f_dcapital_103.Id4", "f_dcapital_103", Rectangle(-125.35504, -430.72208, 40));
		AddSpawnPoint("f_dcapital_103.Id4", "f_dcapital_103", Rectangle(-453.95502, -432.87628, 40));
		AddSpawnPoint("f_dcapital_103.Id4", "f_dcapital_103", Rectangle(-448.03522, -252.74486, 40));
		AddSpawnPoint("f_dcapital_103.Id4", "f_dcapital_103", Rectangle(-470.92606, -665.971, 40));
		AddSpawnPoint("f_dcapital_103.Id4", "f_dcapital_103", Rectangle(1126.516, 222.47643, 40));
		AddSpawnPoint("f_dcapital_103.Id4", "f_dcapital_103", Rectangle(1124.0094, 607.9532, 40));
		AddSpawnPoint("f_dcapital_103.Id4", "f_dcapital_103", Rectangle(1292.0376, 468.10272, 40));
		AddSpawnPoint("f_dcapital_103.Id4", "f_dcapital_103", Rectangle(1388.4949, 231.05966, 40));
		AddSpawnPoint("f_dcapital_103.Id4", "f_dcapital_103", Rectangle(1471.3489, 604.1755, 40));
		AddSpawnPoint("f_dcapital_103.Id4", "f_dcapital_103", Rectangle(972.464, 566.8119, 40));
		AddSpawnPoint("f_dcapital_103.Id4", "f_dcapital_103", Rectangle(-224.90504, -628.48676, 40));
		AddSpawnPoint("f_dcapital_103.Id4", "f_dcapital_103", Rectangle(-572.8696, -629.03625, 40));
		AddSpawnPoint("f_dcapital_103.Id4", "f_dcapital_103", Rectangle(-517.95215, -1216.6012, 40));
		AddSpawnPoint("f_dcapital_103.Id4", "f_dcapital_103", Rectangle(-305.22998, -1232.089, 40));
		AddSpawnPoint("f_dcapital_103.Id4", "f_dcapital_103", Rectangle(-382.907, -1436.0042, 40));
		AddSpawnPoint("f_dcapital_103.Id4", "f_dcapital_103", Rectangle(-151.04459, -1356.9661, 40));

		// 'Goblin2_Wand3_Green' GenType 303 Spawn Points
		AddSpawnPoint("f_dcapital_103.Id5", "f_dcapital_103", Rectangle(1147.4965, 475.37527, 40));
		AddSpawnPoint("f_dcapital_103.Id5", "f_dcapital_103", Rectangle(231.16733, 316.88797, 40));
		AddSpawnPoint("f_dcapital_103.Id5", "f_dcapital_103", Rectangle(-162.91435, 978.8005, 40));
		AddSpawnPoint("f_dcapital_103.Id5", "f_dcapital_103", Rectangle(569.7491, 1048.731, 40));
		AddSpawnPoint("f_dcapital_103.Id5", "f_dcapital_103", Rectangle(885.83453, 1291.521, 40));
		AddSpawnPoint("f_dcapital_103.Id5", "f_dcapital_103", Rectangle(1001.4703, 1105.2385, 40));
		AddSpawnPoint("f_dcapital_103.Id5", "f_dcapital_103", Rectangle(856.49286, 1174.4733, 40));
		AddSpawnPoint("f_dcapital_103.Id5", "f_dcapital_103", Rectangle(776.42957, 995.31964, 40));
		AddSpawnPoint("f_dcapital_103.Id5", "f_dcapital_103", Rectangle(36.734554, 970.3406, 40));
		AddSpawnPoint("f_dcapital_103.Id5", "f_dcapital_103", Rectangle(254.30527, 890.60516, 40));
		AddSpawnPoint("f_dcapital_103.Id5", "f_dcapital_103", Rectangle(-61.768063, 1169.1254, 40));
		AddSpawnPoint("f_dcapital_103.Id5", "f_dcapital_103", Rectangle(-589.1015, 251.19923, 40));
		AddSpawnPoint("f_dcapital_103.Id5", "f_dcapital_103", Rectangle(-417.61356, 193.7566, 40));
		AddSpawnPoint("f_dcapital_103.Id5", "f_dcapital_103", Rectangle(64.356, 449.31998, 40));
		AddSpawnPoint("f_dcapital_103.Id5", "f_dcapital_103", Rectangle(353.51093, 362.48624, 40));
		AddSpawnPoint("f_dcapital_103.Id5", "f_dcapital_103", Rectangle(1502.3625, 405.74902, 40));
		AddSpawnPoint("f_dcapital_103.Id5", "f_dcapital_103", Rectangle(171.78958, 645.27484, 40));

		// 'Goblin2_Hammer_Green' GenType 304 Spawn Points
		AddSpawnPoint("f_dcapital_103.Id6", "f_dcapital_103", Rectangle(-152.95978, 1073.5747, 40));
		AddSpawnPoint("f_dcapital_103.Id6", "f_dcapital_103", Rectangle(-134.4, 844.67, 40));
		AddSpawnPoint("f_dcapital_103.Id6", "f_dcapital_103", Rectangle(173.70795, 860.6555, 40));
		AddSpawnPoint("f_dcapital_103.Id6", "f_dcapital_103", Rectangle(-115.43, 1224.78, 40));
		AddSpawnPoint("f_dcapital_103.Id6", "f_dcapital_103", Rectangle(303.1134, 960.75446, 40));
		AddSpawnPoint("f_dcapital_103.Id6", "f_dcapital_103", Rectangle(169.31, 995.04, 40));
		AddSpawnPoint("f_dcapital_103.Id6", "f_dcapital_103", Rectangle(394.92975, 985.16125, 40));
	}
}
