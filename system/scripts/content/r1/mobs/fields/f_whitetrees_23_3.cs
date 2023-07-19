//--- Melia Script -----------------------------------------------------------
// f_whitetrees_23_3
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Syla Forest' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FWhitetrees233MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("f_whitetrees_23_3.Id1", MonsterId.Rootcrystal_03, 9, 12, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_23_3.Id2", MonsterId.Kucarry_Numani, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_23_3.Id3", MonsterId.Kucarry_Numani, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_23_3.Id4", MonsterId.Kucarry_Zabbi, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_23_3.Id5", MonsterId.Kucarry_Zeuni, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_23_3.Id6", MonsterId.Kucarry_Zabbi, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_23_3.Id7", MonsterId.Kucarry_Zeuni, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_03' GenType 4 Spawn Points
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(196.13142, -1029.4987, 50));
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(28.46104, -1348.0936, 50));
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(-524.63763, -1280.9423, 50));
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(-846.5171, -1154.8047, 50));
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(-46.378487, -582.06165, 50));
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(73.7807, -142.78418, 50));
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(429.3715, -284.15967, 50));
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(902.16125, -381.6753, 50));
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(1356.4574, -435.77737, 50));
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(138.05063, 420.70004, 50));
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(731.2187, 436.2469, 50));
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(1159.0131, 543.028, 50));
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(135.31036, 931.1228, 50));
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(383.3418, 1218.853, 50));
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(776.64514, 1273.2572, 50));
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(1159.275, 1166.9015, 50));
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(-426.7928, 312.22287, 50));
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(-857.6212, 444.4471, 50));
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(-424.2021, 1106.5453, 50));
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(-1612.2927, -395.7498, 50));

		// 'Kucarry_Numani' GenType 100 Spawn Points
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-1796.826, -453.94128, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-1638.3613, -331.02347, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-1589.9375, -152.54599, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-1715.7535, -265.41705, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-820.7432, 336.4356, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-662.0974, 399.6564, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-782.1816, 617.75256, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-554.56384, 209.5086, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-690.8422, 222.21307, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-616.34235, 677.88196, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-835.22, 483.46, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-607.87244, 531.70734, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-647.6703, 1065.292, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-755.82385, 1148.8022, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-488.16174, 1340.2025, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-613.38617, 1411.1781, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-458.54382, 1083.8566, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-644.545, 1318.5447, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-562.49646, 1167.015, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-465.11874, 1233.8138, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-342.77676, 1085.555, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-339.08847, 1263.6799, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-537.47406, 344.14966, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-670.92755, 454.65903, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-1691.341, -455.4157, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-1514.6139, -278.65024, 40));

		// 'Kucarry_Numani' GenType 103 Spawn Points
		AddSpawnPoint("f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Rectangle(161.9442, 1222.3948, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Rectangle(411.84262, 1177.1106, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Rectangle(466.0067, 1040.9111, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Rectangle(301.44788, 1122.0316, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Rectangle(336.1753, 969.1505, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Rectangle(153.8587, 1014.3727, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Rectangle(-102.05, 495.38, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Rectangle(-62.07, 612.98, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Rectangle(31.61, 677.54, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Rectangle(85.35, 521.12, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Rectangle(115.09, 407.13, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Rectangle(190.32, 507.53, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Rectangle(706.63, 642.79, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Rectangle(882.84, 767.44, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Rectangle(895.52, 635.38, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Rectangle(804.26, 430.02, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Rectangle(1032.51, 333.78, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Rectangle(1101.01, 528.79, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Rectangle(991.81, 460.48, 40));

		// 'Kucarry_Zabbi' GenType 104 Spawn Points
		AddSpawnPoint("f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Rectangle(1009.28, -430.16, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Rectangle(1068.14, -327.6, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Rectangle(1153.239, -138.34348, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Rectangle(1374.3141, -267.47488, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Rectangle(1127.48, -529.53, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Rectangle(1209.77, -401.4, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Rectangle(1301.7104, -505.02808, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Rectangle(1286.7405, -171.03717, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Rectangle(1210.219, -306.92117, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Rectangle(873.72784, -333.16425, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Rectangle(6.369972, -616.1387, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Rectangle(-162.05318, -388.60687, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Rectangle(107.06354, -105.24268, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Rectangle(192.40573, -272.45374, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Rectangle(-13.117981, -468.0666, 40));

		// 'Kucarry_Zeuni' GenType 105 Spawn Points
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(-732.07, -1319.06, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(-660.58, -1243.03, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(-858.89, -1081.35, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(-810.1348, -997.6036, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(-579.431, -1146.4945, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(-189.83, -1200.67, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(43.07, -1116.58, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(211.39, -1239.96, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(-1.41, -1383.51, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(137.15, -988.3, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(-34.76, -738.63, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(-156.72, -468.39, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(227.28235, -289.34055, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(57.694714, -502.69373, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(352.564, -323.4966, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(-1795.8613, -387.20792, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(-1607.52, -261.97, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(2.5410366, -612.42706, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(-194.5, -360.64, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(223.87099, -427.86508, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(74.31, -88.62, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(-4.14, -179.67, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(861.72, -291.34, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(1186.66, -283.82, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(1046.11, -203.08, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(1227.82, -481.51, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(1337.39, -277.45, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(29.55, -904.45, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(114.18, -1197.57, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(119.79, -1289.48, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(86.65, -399.29, 40));

		// 'Kucarry_Zabbi' GenType 106 Spawn Points
		AddSpawnPoint("f_whitetrees_23_3.Id6", "f_whitetrees_23_3", Rectangle(124.61, -402.37, 9999));

		// 'Kucarry_Zeuni' GenType 107 Spawn Points
		AddSpawnPoint("f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Rectangle(691.02, 1221.38, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Rectangle(803.58, 1348.6, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Rectangle(824.06, 1182.93, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Rectangle(905.32, 1306.22, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Rectangle(944.93, 1176.24, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Rectangle(1131.86, 1301.18, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Rectangle(873.5981, 985.04065, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Rectangle(926.16, 782.68, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Rectangle(802.1872, 718.6672, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Rectangle(715.08527, 483.35724, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Rectangle(888.614, 520.707, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Rectangle(1013.2127, 683.87396, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Rectangle(954.89374, 348.43048, 40));
	}
}
