//--- Melia Script -----------------------------------------------------------
// f_rokas_36_1
//
//--- Description -----------------------------------------------------------
// Sets up the f_rokas_36_1 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FRokas361MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("f_rokas_36_1.Id1", MonsterId.Rootcrystal_05, 15, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("f_rokas_36_1.Id2", MonsterId.Sec_Chupacabra_Desert, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_36_1.Id3", MonsterId.GlyphRing, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_36_1.Id4", MonsterId.Sec_Sauga, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_36_1.Id5", MonsterId.Sec_Chupacabra_Desert, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_36_1.Id6", MonsterId.Sec_Sauga, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_36_1.Id7", MonsterId.GlyphRing, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Rootcrystal_05 Spawn Points
		AddSpawnPoint( "f_rokas_36_1.Id1", "f_rokas_36_1", Spot(-849.1854, -183.20044, 150));
		AddSpawnPoint( "f_rokas_36_1.Id1", "f_rokas_36_1", Spot(-647.01355, 223.23956, 150));
		AddSpawnPoint( "f_rokas_36_1.Id1", "f_rokas_36_1", Spot(-1189.0554, 142.67075, 150));
		AddSpawnPoint( "f_rokas_36_1.Id1", "f_rokas_36_1", Spot(-629.9579, 578.5119, 150));
		AddSpawnPoint( "f_rokas_36_1.Id1", "f_rokas_36_1", Spot(-306.73785, -406.67743, 150));
		AddSpawnPoint( "f_rokas_36_1.Id1", "f_rokas_36_1", Spot(-45.15439, 842.86145, 150));
		AddSpawnPoint( "f_rokas_36_1.Id1", "f_rokas_36_1", Spot(520.54, 141.71292, 150));
		AddSpawnPoint( "f_rokas_36_1.Id1", "f_rokas_36_1", Spot(801.6979, -175.02312, 150));
		AddSpawnPoint( "f_rokas_36_1.Id1", "f_rokas_36_1", Spot(654.5102, -679.13367, 150));
		AddSpawnPoint( "f_rokas_36_1.Id1", "f_rokas_36_1", Spot(680.9726, 656.37524, 150));
		AddSpawnPoint( "f_rokas_36_1.Id1", "f_rokas_36_1", Spot(798.3833, 1242.0559, 150));
		AddSpawnPoint( "f_rokas_36_1.Id1", "f_rokas_36_1", Spot(1267.3904, 727.8347, 150));
		AddSpawnPoint( "f_rokas_36_1.Id1", "f_rokas_36_1", Spot(1103.7916, 466.21826, 150));
		AddSpawnPoint( "f_rokas_36_1.Id1", "f_rokas_36_1", Spot(1293.1776, 30.254093, 150));
		AddSpawnPoint( "f_rokas_36_1.Id1", "f_rokas_36_1", Spot(1595.0237, 379.23853, 150));

		// Sec_Chupacabra_Desert Spawn Points
		AddSpawnPoint( "f_rokas_36_1.Id2", "f_rokas_36_1", Spot(-40.990433, 517.86566, 9999));

		// GlyphRing Spawn Points
		AddSpawnPoint( "f_rokas_36_1.Id3", "f_rokas_36_1", Spot(1260.9445, -133.1687, 25));
		AddSpawnPoint( "f_rokas_36_1.Id3", "f_rokas_36_1", Spot(1376.5746, -43.150036, 25));
		AddSpawnPoint( "f_rokas_36_1.Id3", "f_rokas_36_1", Spot(1441.9012, -126.71854, 25));
		AddSpawnPoint( "f_rokas_36_1.Id3", "f_rokas_36_1", Spot(1430.7347, -225.06671, 25));
		AddSpawnPoint( "f_rokas_36_1.Id3", "f_rokas_36_1", Spot(1301.2529, -234.47447, 25));
		AddSpawnPoint( "f_rokas_36_1.Id3", "f_rokas_36_1", Spot(1317.3491, -325.80457, 25));
		AddSpawnPoint( "f_rokas_36_1.Id3", "f_rokas_36_1", Spot(1398.8782, -318.48468, 25));
		AddSpawnPoint( "f_rokas_36_1.Id3", "f_rokas_36_1", Spot(482.51404, -115.27011, 25));
		AddSpawnPoint( "f_rokas_36_1.Id3", "f_rokas_36_1", Spot(643.7076, -143.357, 25));
		AddSpawnPoint( "f_rokas_36_1.Id3", "f_rokas_36_1", Spot(739.50824, -82.1302, 25));
		AddSpawnPoint( "f_rokas_36_1.Id3", "f_rokas_36_1", Spot(659.11896, 10.745466, 25));
		AddSpawnPoint( "f_rokas_36_1.Id3", "f_rokas_36_1", Spot(434.2129, 131.06, 25));
		AddSpawnPoint( "f_rokas_36_1.Id3", "f_rokas_36_1", Spot(596.724, 168.49081, 25));
		AddSpawnPoint( "f_rokas_36_1.Id3", "f_rokas_36_1", Spot(748.8214, 88.10883, 25));
		AddSpawnPoint( "f_rokas_36_1.Id3", "f_rokas_36_1", Spot(866.2805, 57.263325, 25));
		AddSpawnPoint( "f_rokas_36_1.Id3", "f_rokas_36_1", Spot(881.62744, -87.9308, 25));
		AddSpawnPoint( "f_rokas_36_1.Id3", "f_rokas_36_1", Spot(832.1597, -189.69742, 25));
		AddSpawnPoint( "f_rokas_36_1.Id3", "f_rokas_36_1", Spot(980.98505, -41.875946, 25));
		AddSpawnPoint( "f_rokas_36_1.Id3", "f_rokas_36_1", Spot(555.5581, -7.360428, 25));
		AddSpawnPoint( "f_rokas_36_1.Id3", "f_rokas_36_1", Spot(520.0818, -616.8432, 25));
		AddSpawnPoint( "f_rokas_36_1.Id3", "f_rokas_36_1", Spot(471.63556, -722.87244, 25));
		AddSpawnPoint( "f_rokas_36_1.Id3", "f_rokas_36_1", Spot(547.11884, -733.1397, 25));
		AddSpawnPoint( "f_rokas_36_1.Id3", "f_rokas_36_1", Spot(574.87537, -775.60443, 25));
		AddSpawnPoint( "f_rokas_36_1.Id3", "f_rokas_36_1", Spot(618.9389, -654.06647, 25));
		AddSpawnPoint( "f_rokas_36_1.Id3", "f_rokas_36_1", Spot(656.883, -757.04364, 25));
		AddSpawnPoint( "f_rokas_36_1.Id3", "f_rokas_36_1", Spot(1341.1381, -193.73618, 25));
		AddSpawnPoint( "f_rokas_36_1.Id3", "f_rokas_36_1", Spot(1132.1471, -48.19717, 25));

		// Sec_Sauga Spawn Points
		AddSpawnPoint( "f_rokas_36_1.Id4", "f_rokas_36_1", Spot(688.7186, 549.81104, 30));
		AddSpawnPoint( "f_rokas_36_1.Id4", "f_rokas_36_1", Spot(885.8255, 682.069, 30));
		AddSpawnPoint( "f_rokas_36_1.Id4", "f_rokas_36_1", Spot(791.4312, 804.5704, 30));
		AddSpawnPoint( "f_rokas_36_1.Id4", "f_rokas_36_1", Spot(889.7787, 934.6917, 30));
		AddSpawnPoint( "f_rokas_36_1.Id4", "f_rokas_36_1", Spot(718.61914, 884.7882, 30));
		AddSpawnPoint( "f_rokas_36_1.Id4", "f_rokas_36_1", Spot(508.99472, 593.6876, 30));
		AddSpawnPoint( "f_rokas_36_1.Id4", "f_rokas_36_1", Spot(1034.1033, 801.3196, 30));
		AddSpawnPoint( "f_rokas_36_1.Id4", "f_rokas_36_1", Spot(761.4172, 1265.5516, 30));
		AddSpawnPoint( "f_rokas_36_1.Id4", "f_rokas_36_1", Spot(882.9234, 1276.0453, 30));
		AddSpawnPoint( "f_rokas_36_1.Id4", "f_rokas_36_1", Spot(807.32825, 1208.224, 30));
		AddSpawnPoint( "f_rokas_36_1.Id4", "f_rokas_36_1", Spot(1086.4518, 490.98947, 30));
		AddSpawnPoint( "f_rokas_36_1.Id4", "f_rokas_36_1", Spot(1337.8536, 368.06055, 30));
		AddSpawnPoint( "f_rokas_36_1.Id4", "f_rokas_36_1", Spot(1476.2645, 384.1469, 30));
		AddSpawnPoint( "f_rokas_36_1.Id4", "f_rokas_36_1", Spot(1379.5415, 224.66745, 30));
		AddSpawnPoint( "f_rokas_36_1.Id4", "f_rokas_36_1", Spot(1299.9099, 213.72916, 30));
		AddSpawnPoint( "f_rokas_36_1.Id4", "f_rokas_36_1", Spot(1369.5597, 319.35623, 30));
		AddSpawnPoint( "f_rokas_36_1.Id4", "f_rokas_36_1", Spot(1370.0524, 747.5912, 30));
		AddSpawnPoint( "f_rokas_36_1.Id4", "f_rokas_36_1", Spot(1487.9849, 858.73773, 30));
		AddSpawnPoint( "f_rokas_36_1.Id4", "f_rokas_36_1", Spot(1481.1127, 707.235, 30));
		AddSpawnPoint( "f_rokas_36_1.Id4", "f_rokas_36_1", Spot(1444.0825, 744.7131, 30));
		AddSpawnPoint( "f_rokas_36_1.Id4", "f_rokas_36_1", Spot(1263.4913, 659.2632, 30));
		AddSpawnPoint( "f_rokas_36_1.Id4", "f_rokas_36_1", Spot(602.2951, 726.57965, 30));
		AddSpawnPoint( "f_rokas_36_1.Id4", "f_rokas_36_1", Spot(748.34125, 747.8207, 30));
		AddSpawnPoint( "f_rokas_36_1.Id4", "f_rokas_36_1", Spot(902.4373, 518.52155, 30));
		AddSpawnPoint( "f_rokas_36_1.Id4", "f_rokas_36_1", Spot(998.0538, 577.2185, 30));
		AddSpawnPoint( "f_rokas_36_1.Id4", "f_rokas_36_1", Spot(910.4078, 826.3415, 30));
		AddSpawnPoint( "f_rokas_36_1.Id4", "f_rokas_36_1", Spot(1313.2644, 182.77438, 30));
		AddSpawnPoint( "f_rokas_36_1.Id4", "f_rokas_36_1", Spot(1223.6638, 396.95264, 30));
		AddSpawnPoint( "f_rokas_36_1.Id4", "f_rokas_36_1", Spot(-162.44012, 611.25867, 30));
		AddSpawnPoint( "f_rokas_36_1.Id4", "f_rokas_36_1", Spot(49.909912, 632.56335, 30));
		AddSpawnPoint( "f_rokas_36_1.Id4", "f_rokas_36_1", Spot(47.917343, 761.0642, 30));
		AddSpawnPoint( "f_rokas_36_1.Id4", "f_rokas_36_1", Spot(-173.72809, 744.3894, 30));
		AddSpawnPoint( "f_rokas_36_1.Id4", "f_rokas_36_1", Spot(106.73759, 395.30173, 30));
		AddSpawnPoint( "f_rokas_36_1.Id4", "f_rokas_36_1", Spot(80.37749, 806.7458, 30));
		AddSpawnPoint( "f_rokas_36_1.Id4", "f_rokas_36_1", Spot(37.68823, 568.825, 30));

		// Sec_Chupacabra_Desert Spawn Points
		AddSpawnPoint( "f_rokas_36_1.Id5", "f_rokas_36_1", Spot(109.00531, 655.0179, 30));
		AddSpawnPoint( "f_rokas_36_1.Id5", "f_rokas_36_1", Spot(134.8319, 795.6725, 30));
		AddSpawnPoint( "f_rokas_36_1.Id5", "f_rokas_36_1", Spot(186.08682, 711.79114, 30));
		AddSpawnPoint( "f_rokas_36_1.Id5", "f_rokas_36_1", Spot(289.45718, 676.9941, 30));
		AddSpawnPoint( "f_rokas_36_1.Id5", "f_rokas_36_1", Spot(196.17453, 401.39047, 30));
		AddSpawnPoint( "f_rokas_36_1.Id5", "f_rokas_36_1", Spot(-93.74869, 761.666, 30));
		AddSpawnPoint( "f_rokas_36_1.Id5", "f_rokas_36_1", Spot(-116.45465, 650.296, 30));
		AddSpawnPoint( "f_rokas_36_1.Id5", "f_rokas_36_1", Spot(-119.35152, 468.3154, 30));
		AddSpawnPoint( "f_rokas_36_1.Id5", "f_rokas_36_1", Spot(13.306381, 916.94696, 30));

		// Sec_Sauga Spawn Points
		AddSpawnPoint( "f_rokas_36_1.Id6", "f_rokas_36_1", Spot(-674.8382, -56.659233, 20));
		AddSpawnPoint( "f_rokas_36_1.Id6", "f_rokas_36_1", Spot(-721.7647, 139.78987, 20));
		AddSpawnPoint( "f_rokas_36_1.Id6", "f_rokas_36_1", Spot(-563.4957, 44.40377, 20));
		AddSpawnPoint( "f_rokas_36_1.Id6", "f_rokas_36_1", Spot(-552.84143, 241.56598, 20));
		AddSpawnPoint( "f_rokas_36_1.Id6", "f_rokas_36_1", Spot(-422.87494, 124.85101, 20));
		AddSpawnPoint( "f_rokas_36_1.Id6", "f_rokas_36_1", Spot(-429.06604, -46.714355, 20));
		AddSpawnPoint( "f_rokas_36_1.Id6", "f_rokas_36_1", Spot(-383.78635, -397.60663, 20));
		AddSpawnPoint( "f_rokas_36_1.Id6", "f_rokas_36_1", Spot(-428.88867, -536.84247, 20));
		AddSpawnPoint( "f_rokas_36_1.Id6", "f_rokas_36_1", Spot(-294.54474, -503.19717, 20));
		AddSpawnPoint( "f_rokas_36_1.Id6", "f_rokas_36_1", Spot(-219.55006, -448.04584, 20));
		AddSpawnPoint( "f_rokas_36_1.Id6", "f_rokas_36_1", Spot(-384.4518, -489.41547, 20));
		AddSpawnPoint( "f_rokas_36_1.Id6", "f_rokas_36_1", Spot(-454.36523, -438.90503, 20));
		AddSpawnPoint( "f_rokas_36_1.Id6", "f_rokas_36_1", Spot(-325.92978, -598.3844, 20));
		AddSpawnPoint( "f_rokas_36_1.Id6", "f_rokas_36_1", Spot(-1093.7491, -487.1377, 20));
		AddSpawnPoint( "f_rokas_36_1.Id6", "f_rokas_36_1", Spot(-967.7573, -538.51215, 20));
		AddSpawnPoint( "f_rokas_36_1.Id6", "f_rokas_36_1", Spot(-895.31915, -412.96405, 20));
		AddSpawnPoint( "f_rokas_36_1.Id6", "f_rokas_36_1", Spot(-980.3678, -355.5686, 20));
		AddSpawnPoint( "f_rokas_36_1.Id6", "f_rokas_36_1", Spot(-1055.2855, -406.40408, 20));

		// GlyphRing Spawn Points
		AddSpawnPoint( "f_rokas_36_1.Id7", "f_rokas_36_1", Spot(-1138.4706, -406.81488, 25));
		AddSpawnPoint( "f_rokas_36_1.Id7", "f_rokas_36_1", Spot(-926.032, -292.06042, 25));
		AddSpawnPoint( "f_rokas_36_1.Id7", "f_rokas_36_1", Spot(-867.1805, -534.91907, 25));
		AddSpawnPoint( "f_rokas_36_1.Id7", "f_rokas_36_1", Spot(-1079.6954, -545.277, 25));
		AddSpawnPoint( "f_rokas_36_1.Id7", "f_rokas_36_1", Spot(-571.63403, 85.34673, 25));
		AddSpawnPoint( "f_rokas_36_1.Id7", "f_rokas_36_1", Spot(-669.28625, 10.1129, 25));
		AddSpawnPoint( "f_rokas_36_1.Id7", "f_rokas_36_1", Spot(-558.34204, -51.098427, 25));
		AddSpawnPoint( "f_rokas_36_1.Id7", "f_rokas_36_1", Spot(-434.951, 34.889, 25));
		AddSpawnPoint( "f_rokas_36_1.Id7", "f_rokas_36_1", Spot(-426.3515, 170.51991, 25));
		AddSpawnPoint( "f_rokas_36_1.Id7", "f_rokas_36_1", Spot(-764.2821, 610.6953, 25));
		AddSpawnPoint( "f_rokas_36_1.Id7", "f_rokas_36_1", Spot(-824.25323, 648.873, 25));
		AddSpawnPoint( "f_rokas_36_1.Id7", "f_rokas_36_1", Spot(-745.80054, 714.6572, 25));
		AddSpawnPoint( "f_rokas_36_1.Id7", "f_rokas_36_1", Spot(-741.00183, 655.8578, 25));
		AddSpawnPoint( "f_rokas_36_1.Id7", "f_rokas_36_1", Spot(-682.2648, 608.4759, 25));
		AddSpawnPoint( "f_rokas_36_1.Id7", "f_rokas_36_1", Spot(-693.31525, 748.3666, 25));
		AddSpawnPoint( "f_rokas_36_1.Id7", "f_rokas_36_1", Spot(-1137.9117, 211.10014, 25));
		AddSpawnPoint( "f_rokas_36_1.Id7", "f_rokas_36_1", Spot(-1081.4015, 149.28851, 25));
		AddSpawnPoint( "f_rokas_36_1.Id7", "f_rokas_36_1", Spot(-1126.0962, 58.628334, 25));
		AddSpawnPoint( "f_rokas_36_1.Id7", "f_rokas_36_1", Spot(-1224.0105, 103.97227, 25));
		AddSpawnPoint( "f_rokas_36_1.Id7", "f_rokas_36_1", Spot(-1200.0508, 188.47452, 25));
		AddSpawnPoint( "f_rokas_36_1.Id7", "f_rokas_36_1", Spot(-1072.4574, 81.863434, 25));

	}
}
