//--- Melia Script -----------------------------------------------------------
// f_huevillage_58_2
//
//--- Description -----------------------------------------------------------
// Sets up the f_huevillage_58_2 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FHuevillage582MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_huevillage_58_2", MonsterId.Ultanun, Properties("MHP", 28724, "MINPATK", 870, "MAXPATK", 972, "MINMATK", 870, "MAXMATK", 972, "DEF", 170, "MDEF", 170));
		AddPropertyOverrides("f_huevillage_58_2", MonsterId.Zibu_Maize, Properties("MHP", 29140, "MINPATK", 876, "MAXPATK", 978, "MINMATK", 876, "MAXMATK", 978, "DEF", 170, "MDEF", 170));
		AddPropertyOverrides("f_huevillage_58_2", MonsterId.Rudas_Loxodon, Properties("MHP", 29583, "MINPATK", 881, "MAXPATK", 985, "MINMATK", 881, "MAXMATK", 985, "DEF", 171, "MDEF", 171));

		// Monster Spawners --------------------------------

		AddSpawner("f_huevillage_58_2.Id1", MonsterId.Ultanun, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_2.Id2", MonsterId.Zibu_Maize, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_2.Id3", MonsterId.Zibu_Maize, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_2.Id4", MonsterId.Ultanun, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_2.Id5", MonsterId.Rootcrystal_01, 11, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_2.Id6", MonsterId.Ultanun, 80, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_2.Id7", MonsterId.Zibu_Maize, 6, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_2.Id8", MonsterId.Rudas_Loxodon, 3, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_2.Id9", MonsterId.Zibu_Maize, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Ultanun Spawn Points
		AddSpawnPoint( "f_huevillage_58_2.Id1", "f_huevillage_58_2", Spot(702.58, 119.57, 9999));

		// Zibu_Maize Spawn Points
		AddSpawnPoint( "f_huevillage_58_2.Id2", "f_huevillage_58_2", Spot(636.91, 19.92, 9999));
		AddSpawnPoint( "f_huevillage_58_2.Id3", "f_huevillage_58_2", Spot(-820.28, -122.1, 35));
		AddSpawnPoint( "f_huevillage_58_2.Id3", "f_huevillage_58_2", Spot(-944.9715, -452.2336, 35));
		AddSpawnPoint( "f_huevillage_58_2.Id3", "f_huevillage_58_2", Spot(-154.12, 13.73, 35));
		AddSpawnPoint( "f_huevillage_58_2.Id3", "f_huevillage_58_2", Spot(-5.76, -139.49, 35));
		AddSpawnPoint( "f_huevillage_58_2.Id3", "f_huevillage_58_2", Spot(-6.31, 185.87, 35));
		AddSpawnPoint( "f_huevillage_58_2.Id3", "f_huevillage_58_2", Spot(-393.54, -81.02, 35));
		AddSpawnPoint( "f_huevillage_58_2.Id3", "f_huevillage_58_2", Spot(-757.847, -340.0202, 35));
		AddSpawnPoint( "f_huevillage_58_2.Id3", "f_huevillage_58_2", Spot(-653.10376, -511.51862, 35));
		AddSpawnPoint( "f_huevillage_58_2.Id3", "f_huevillage_58_2", Spot(-540.4689, -294.37396, 35));

		// Ultanun Spawn Points
		AddSpawnPoint( "f_huevillage_58_2.Id4", "f_huevillage_58_2", Spot(-864.1304, -353.8641, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id4", "f_huevillage_58_2", Spot(343.84872, -855.3425, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id4", "f_huevillage_58_2", Spot(477.53, -1103.58, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id4", "f_huevillage_58_2", Spot(677.81, -770.73, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id4", "f_huevillage_58_2", Spot(565.2133, -939.67505, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id4", "f_huevillage_58_2", Spot(580.91266, -624.41766, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id4", "f_huevillage_58_2", Spot(-688.60126, -169.6638, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id4", "f_huevillage_58_2", Spot(397.65268, -596.8068, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id4", "f_huevillage_58_2", Spot(-339.48297, -78.36729, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id4", "f_huevillage_58_2", Spot(-794.00397, -98.01706, 30));

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "f_huevillage_58_2.Id5", "f_huevillage_58_2", Spot(246.07, -1747.42, 200));
		AddSpawnPoint( "f_huevillage_58_2.Id5", "f_huevillage_58_2", Spot(-348.71, -1390.66, 200));
		AddSpawnPoint( "f_huevillage_58_2.Id5", "f_huevillage_58_2", Spot(-634.37, -1128.92, 200));
		AddSpawnPoint( "f_huevillage_58_2.Id5", "f_huevillage_58_2", Spot(497.29, -603.91, 200));
		AddSpawnPoint( "f_huevillage_58_2.Id5", "f_huevillage_58_2", Spot(-853.86, -557.39, 200));
		AddSpawnPoint( "f_huevillage_58_2.Id5", "f_huevillage_58_2", Spot(-369.84, -111.56, 200));
		AddSpawnPoint( "f_huevillage_58_2.Id5", "f_huevillage_58_2", Spot(-161.48, 1099.89, 200));
		AddSpawnPoint( "f_huevillage_58_2.Id5", "f_huevillage_58_2", Spot(849.66, 754.1, 200));
		AddSpawnPoint( "f_huevillage_58_2.Id5", "f_huevillage_58_2", Spot(705.44, -8.53, 200));
		AddSpawnPoint( "f_huevillage_58_2.Id5", "f_huevillage_58_2", Spot(1575.71, 672.99, 200));
		AddSpawnPoint( "f_huevillage_58_2.Id5", "f_huevillage_58_2", Spot(113.06, 461.73, 200));

		// Ultanun Spawn Points
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-440.17, 253.64, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-77.85, 1188.62, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-219.35301, 1117.558, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-78.63364, 1349.9259, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(60.193993, 1118.2163, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(198.40105, 1266.4766, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-251.17834, 1253.4501, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-284.734, 212.35274, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-557.06104, 246.36078, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(199.53442, 1222.293, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(263.80615, 1226.3212, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(222.61234, 1170.6945, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(241.94635, 1358.957, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(163.7943, 1298.7196, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(111.86048, 1305.4559, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(140.05865, 1202.4437, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(40.933502, 1170.417, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(78.21, 1049.4901, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-10.740891, 1080.1361, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-28.994068, 1014.1852, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-96.2583, 963.0399, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-149.80006, 891.0948, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-176.98332, 938.76514, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-210.92181, 988.50684, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-130.50525, 1050.0354, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-209.7588, 1036.1368, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-134.08112, 1126.8997, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-61.472588, 1085.631, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-38.721035, 1326.019, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-134.0524, 1300.6364, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(63.895573, 976.4286, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(739.8472, 96.08985, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(700.58655, 26.211079, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(624.869, -62.16513, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(594.17004, 53.263718, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(791.5924, -8.39086, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(820.17175, 99.54447, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(640.77057, 109.3913, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(663.15344, 62.83666, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(552.65393, 96.005974, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(583.9943, -39.929447, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(522.1137, -53.693825, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(492.0782, 58.261856, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(721.76855, 246.2806, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(578.7108, 183.25377, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-256.70334, 277.48425, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-444.46765, 416.41904, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-446.8999, 329.95523, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-261.92764, 11.844409, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-338.2639, -11.68693, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-262.33743, -96.23103, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-68.527824, -132.55392, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(16.197796, -67.509636, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-61.99613, -40.38787, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-140.85237, -126.8187, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-159.66974, -50.405712, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-245.9203, -40.715805, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-199.72726, -4.2040825, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-95.871185, 41.0984, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-542.00256, -378.92917, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-599.54626, -416.72128, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-669.99725, -455.40378, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-624.62286, -334.35034, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-696.0633, -562.64825, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-849.0356, -530.43854, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-957.081, -528.1119, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-825.2962, -451.70438, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-777.5632, -394.90155, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-665.1678, -269.71878, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-842.67413, -278.42685, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-978.86865, -388.51678, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-1047.1714, -395.85422, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-997.7176, -283.8636, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-910.29535, -147.61534, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-878.8323, -16.40817, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-934.1925, 54.92448, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-845.10016, 105.85103, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-826.2291, -10.093061, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-822.2193, -350.20584, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-643.8074, -391.79446, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-567.474, -167.11252, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-338.8422, -182.55675, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-382.40903, -111.09395, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(-349.49155, -38.304337, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(936.4228, 237.72006, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(1019.6215, 181.8681, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(884.4164, 242.67874, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(813.34827, 255.70808, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(1012.4512, 267.89282, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(920.25604, 384.99155, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(848.28687, 401.72015, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(788.90753, 448.83002, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(718.0027, 350.98462, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(671.64294, 448.19702, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(738.1092, 467.1236, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(845.26263, 622.71783, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(885.1749, 592.9677, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(751.9535, 632.1188, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(794.73975, 720.8408, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(886.7294, 706.83417, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(566.769, -550.6548, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(621.09467, -623.0345, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(633.99994, -675.37244, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(638.69617, -728.8051, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(642.5443, -813.3256, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(623.1864, -879.9111, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(641.2024, -917.3819, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(540.78937, -995.52136, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(454.19202, -971.331, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(504.32516, -901.6395, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(527.66254, -826.19104, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(558.3279, -760.81464, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(369.42908, -719.22217, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(348.4164, -638.9606, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(329.97278, -588.6695, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(358.93927, -530.84534, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(295.93207, -803.7715, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(352.51266, -789.94824, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(317.89117, -983.7204, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(358.73135, -1007.4926, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(396.2776, -1022.3514, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(842.56146, 739.20953, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(751.2733, 788.9106, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(714.73065, 700.0473, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(807.38214, 657.678, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(753.54407, 529.2911, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id6", "f_huevillage_58_2", Spot(928.5674, 442.27798, 30));

		// Zibu_Maize Spawn Points
		AddSpawnPoint( "f_huevillage_58_2.Id7", "f_huevillage_58_2", Spot(-444.43, 229.16, 100));

		// Rudas_Loxodon Spawn Points
		AddSpawnPoint( "f_huevillage_58_2.Id8", "f_huevillage_58_2", Spot(-57.27, 81.4, 9999));

		// Zibu_Maize Spawn Points
		AddSpawnPoint( "f_huevillage_58_2.Id9", "f_huevillage_58_2", Spot(414.7287, -1103.0859, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id9", "f_huevillage_58_2", Spot(598.7813, -964.75977, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id9", "f_huevillage_58_2", Spot(409.87704, -791.7931, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id9", "f_huevillage_58_2", Spot(250.19398, -639.52924, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id9", "f_huevillage_58_2", Spot(505.44098, -536.4581, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id9", "f_huevillage_58_2", Spot(587.56506, -800.3403, 30));
		AddSpawnPoint( "f_huevillage_58_2.Id9", "f_huevillage_58_2", Spot(286.29477, -944.2749, 30));

	}
}
