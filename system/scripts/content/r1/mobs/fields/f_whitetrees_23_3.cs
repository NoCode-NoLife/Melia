//--- Melia Script -----------------------------------------------------------
// f_whitetrees_23_3
//
//--- Description -----------------------------------------------------------
// Sets up the f_whitetrees_23_3 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FWhitetrees233MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("f_whitetrees_23_3.Id1", MonsterId.Rootcrystal_03, 12, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_23_3.Id2", MonsterId.Kucarry_Numani, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_23_3.Id3", MonsterId.Kucarry_Numani, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_23_3.Id4", MonsterId.Kucarry_Zabbi, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_23_3.Id5", MonsterId.Kucarry_Zeuni, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_23_3.Id6", MonsterId.Kucarry_Zabbi, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_23_3.Id7", MonsterId.Kucarry_Zeuni, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Rootcrystal_03 Spawn Points
		AddSpawnPoint( "f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Spot(196.13142, -1029.4987, 50));
		AddSpawnPoint( "f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Spot(28.46104, -1348.0936, 50));
		AddSpawnPoint( "f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Spot(-524.63763, -1280.9423, 50));
		AddSpawnPoint( "f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Spot(-846.5171, -1154.8047, 50));
		AddSpawnPoint( "f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Spot(-46.378487, -582.06165, 50));
		AddSpawnPoint( "f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Spot(73.7807, -142.78418, 50));
		AddSpawnPoint( "f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Spot(429.3715, -284.15967, 50));
		AddSpawnPoint( "f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Spot(902.16125, -381.6753, 50));
		AddSpawnPoint( "f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Spot(1356.4574, -435.77737, 50));
		AddSpawnPoint( "f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Spot(138.05063, 420.70004, 50));
		AddSpawnPoint( "f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Spot(731.2187, 436.2469, 50));
		AddSpawnPoint( "f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Spot(1159.0131, 543.028, 50));
		AddSpawnPoint( "f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Spot(135.31036, 931.1228, 50));
		AddSpawnPoint( "f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Spot(383.3418, 1218.853, 50));
		AddSpawnPoint( "f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Spot(776.64514, 1273.2572, 50));
		AddSpawnPoint( "f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Spot(1159.275, 1166.9015, 50));
		AddSpawnPoint( "f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Spot(-426.7928, 312.22287, 50));
		AddSpawnPoint( "f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Spot(-857.6212, 444.4471, 50));
		AddSpawnPoint( "f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Spot(-424.2021, 1106.5453, 50));
		AddSpawnPoint( "f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Spot(-1612.2927, -395.7498, 50));

		// Kucarry_Numani Spawn Points
		AddSpawnPoint( "f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Spot(-1796.826, -453.94128, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Spot(-1638.3613, -331.02347, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Spot(-1589.9375, -152.54599, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Spot(-1715.7535, -265.41705, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Spot(-820.7432, 336.4356, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Spot(-662.0974, 399.6564, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Spot(-782.1816, 617.75256, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Spot(-554.56384, 209.5086, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Spot(-690.8422, 222.21307, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Spot(-616.34235, 677.88196, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Spot(-835.22, 483.46, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Spot(-607.87244, 531.70734, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Spot(-647.6703, 1065.292, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Spot(-755.82385, 1148.8022, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Spot(-488.16174, 1340.2025, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Spot(-613.38617, 1411.1781, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Spot(-458.54382, 1083.8566, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Spot(-644.545, 1318.5447, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Spot(-562.49646, 1167.015, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Spot(-465.11874, 1233.8138, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Spot(-342.77676, 1085.555, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Spot(-339.08847, 1263.6799, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Spot(-537.47406, 344.14966, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Spot(-670.92755, 454.65903, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Spot(-1691.341, -455.4157, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Spot(-1514.6139, -278.65024, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Spot(161.9442, 1222.3948, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Spot(411.84262, 1177.1106, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Spot(466.0067, 1040.9111, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Spot(301.44788, 1122.0316, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Spot(336.1753, 969.1505, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Spot(153.8587, 1014.3727, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Spot(-102.05, 495.38, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Spot(-62.07, 612.98, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Spot(31.61, 677.54, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Spot(85.35, 521.12, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Spot(115.09, 407.13, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Spot(190.32, 507.53, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Spot(706.63, 642.79, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Spot(882.84, 767.44, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Spot(895.52, 635.38, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Spot(804.26, 430.02, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Spot(1032.51, 333.78, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Spot(1101.01, 528.79, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Spot(991.81, 460.48, 40));

		// Kucarry_Zabbi Spawn Points
		AddSpawnPoint( "f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Spot(1009.28, -430.16, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Spot(1068.14, -327.6, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Spot(1153.239, -138.34348, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Spot(1374.3141, -267.47488, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Spot(1127.48, -529.53, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Spot(1209.77, -401.4, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Spot(1301.7104, -505.02808, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Spot(1286.7405, -171.03717, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Spot(1210.219, -306.92117, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Spot(873.72784, -333.16425, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Spot(6.369972, -616.1387, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Spot(-162.05318, -388.60687, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Spot(107.06354, -105.24268, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Spot(192.40573, -272.45374, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Spot(-13.117981, -468.0666, 40));

		// Kucarry_Zeuni Spawn Points
		AddSpawnPoint( "f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Spot(-732.07, -1319.06, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Spot(-660.58, -1243.03, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Spot(-858.89, -1081.35, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Spot(-810.1348, -997.6036, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Spot(-579.431, -1146.4945, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Spot(-189.83, -1200.67, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Spot(43.07, -1116.58, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Spot(211.39, -1239.96, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Spot(-1.41, -1383.51, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Spot(137.15, -988.3, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Spot(-34.76, -738.63, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Spot(-156.72, -468.39, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Spot(227.28235, -289.34055, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Spot(57.694714, -502.69373, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Spot(352.564, -323.4966, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Spot(-1795.8613, -387.20792, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Spot(-1607.52, -261.97, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Spot(2.5410366, -612.42706, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Spot(-194.5, -360.64, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Spot(223.87099, -427.86508, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Spot(74.31, -88.62, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Spot(-4.14, -179.67, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Spot(861.72, -291.34, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Spot(1186.66, -283.82, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Spot(1046.11, -203.08, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Spot(1227.82, -481.51, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Spot(1337.39, -277.45, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Spot(29.55, -904.45, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Spot(114.18, -1197.57, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Spot(119.79, -1289.48, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Spot(86.65, -399.29, 40));

		// Kucarry_Zabbi Spawn Points
		AddSpawnPoint( "f_whitetrees_23_3.Id6", "f_whitetrees_23_3", Spot(124.61, -402.37, 9999));

		// Kucarry_Zeuni Spawn Points
		AddSpawnPoint( "f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Spot(691.02, 1221.38, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Spot(803.58, 1348.6, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Spot(824.06, 1182.93, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Spot(905.32, 1306.22, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Spot(944.93, 1176.24, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Spot(1131.86, 1301.18, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Spot(873.5981, 985.04065, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Spot(926.16, 782.68, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Spot(802.1872, 718.6672, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Spot(715.08527, 483.35724, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Spot(888.614, 520.707, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Spot(1013.2127, 683.87396, 40));
		AddSpawnPoint( "f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Spot(954.89374, 348.43048, 40));

	}
}
