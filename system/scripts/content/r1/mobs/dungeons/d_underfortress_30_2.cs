//--- Melia Script -----------------------------------------------------------
// d_underfortress_30_2
//
//--- Description -----------------------------------------------------------
// Sets up the d_underfortress_30_2 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DUnderfortress302MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("d_underfortress_30_2.Id1", MonsterId.Saltisdaughter_Green, 50, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_30_2.Id2", MonsterId.Colifly_Mage_Black, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_30_2.Id3", MonsterId.Colifly_Bow_Black, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_30_2.Id4", MonsterId.Rootcrystal_05, 14, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Saltisdaughter_Green Spawn Points
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-852.4142, -95.41325, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-843.5294, 47.72502, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-777.3942, -38.463177, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-794.6539, 203.3997, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-880.41565, 355.08514, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-793.9441, 518.16736, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-901.78357, 744.7651, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-1270.9706, 420.90228, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-1388.9409, 313.69354, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-1534.5594, 389.15808, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-1636.1786, 336.969, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-1594.4191, -4.341469, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-1521.764, -93.48804, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-1397.688, 5.487404, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-1306.51, -75.03934, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-1685.3218, 759.17395, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-1559.953, 689.95557, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-1469.9441, 764.1632, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-1341.4115, 691.90515, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-1039.3048, 1360.15, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-1056.7865, 1607.3586, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-867.71515, 1406.9495, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-824.77606, 1325.3562, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-881.61115, 1563.6873, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-361.26273, 1330.0347, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-322.9406, 1544.5634, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-220.19162, 1392.6475, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-162.34053, 1574.9376, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(62.299805, 1378.5544, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-75.783905, 1306.6514, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(386.89786, 1356.8523, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(496.42358, 1581.6924, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(500.40356, 1451.3461, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(626.5744, 1326.1049, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(633.4594, 1557.5889, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(927.215, 886.4251, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(801.4801, 918.4791, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(893.07043, 742.40216, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(947.90344, 420.54575, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(827.8907, 385.60843, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(918.8721, 209.61227, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(955.75775, 99.01229, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(888.33765, -114.56755, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(919.27045, -260.7795, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(1030.7789, -104.56224, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(426.31265, 909.61365, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(426.688, 720.117, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(243.4447, 717.88513, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-67.888626, 705.0657, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-174.41759, 842.59705, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-317.0332, 637.2486, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-170.0623, 637.3645, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-137.24886, 459.66553, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-281.87888, 394.71942, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-271.55945, 220.81226, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-148.37416, 140.99957, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-320.2747, 15.403381, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-415.81485, -92.80847, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-165.73842, -192.11972, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(12.908634, -17.240507, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(254.40378, -18.14122, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(406.48218, -201.06711, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(442.38794, -405.15588, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(415.58774, 46.02562, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(363.99112, 267.47275, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(489.27234, 349.41074, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(409.56628, 528.6689, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-506.10385, -676.5493, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-289.13065, -630.91504, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-214.88983, -689.36053, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-173.88408, -467.6244, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-208.72974, -271.0359, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(77.16646, -696.81976, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(364.34576, -579.7373, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(492.83163, -745.3077, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(630.0404, -567.53284, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(701.67834, -695.33154, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(838.89154, -575.47266, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(901.9032, -700.8101, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(999.953, -570.59454, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(1049.9337, -687.2099, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-848.56757, 889.1501, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id1", "d_underfortress_30_2", Spot(-472.18008, 1418.5988, 30));

		// Colifly_Mage_Black Spawn Points
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(-1659.1615, 726.0543, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(-1434.2676, 803.7779, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(-1490.0765, 690.0572, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(-1373.2303, 660.08374, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(-1315.7305, 776.5387, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(-1626.1128, -66.50771, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(-1580.072, -7.8160477, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(-1433.0715, -76.369064, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(-1394.8682, -4.641838, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(-1268.1418, -58.52292, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(455.05133, 1421.5403, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(574.7403, 1548.0137, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(579.69464, 1415.4668, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(502.4407, 1293.9971, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(697.6698, 1351.1404, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(-116.88953, 1525.1947, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(-294.9713, 1360.2626, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(-238.76677, 1510.8558, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(-436.71533, 1517.1168, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(-353.012, 1342.2344, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(52.41315, 1388.6306, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(-53.057816, 1283.1246, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(-297.95386, 868.4468, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(-363.5049, 632.8022, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(-122.73228, 734.72656, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(-133.25804, 531.2348, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(-237.89766, 321.02237, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(-398.96402, 124.08417, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(-293.19247, -112.29993, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(-233.25922, 72.869064, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(-59.27608, 137.75604, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(-63.6259, -119.83894, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(-207.2766, 457.19223, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(-413.53833, 466.3779, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(-172.03574, -183.74559, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(914.60535, 832.4799, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(829.62573, 905.9674, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(988.3053, 937.0747, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(971.8245, 840.45044, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(908.0645, 455.8265, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(887.0181, 315.01443, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(922.5607, 260.69135, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(977.7302, -32.333702, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(921.1126, -130.1348, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(836.34393, -103.95631, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(841.8594, -235.57478, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(959.25464, -273.9436, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id2", "d_underfortress_30_2", Spot(1004.2171, -94.24356, 30));

		// Colifly_Bow_Black Spawn Points
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(-855.6039, -131.8992, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(-720.3851, -79.03804, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(-889.78467, 12.020721, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(-792.4189, 189.46922, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(-893.5156, 309.36902, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(-769.2819, 505.779, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(-893.5052, 640.55035, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(-841.6335, 863.9245, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(-1295.268, 411.10928, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(-1307.4181, 283.1549, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(-1416.176, 370.774, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(-1503.6182, 313.32156, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(-1548.1149, 397.08023, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(-1658.7312, 347.08902, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(-1702.1316, 421.26248, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(-1733.3562, 305.42764, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(357.77252, -143.57059, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(490.86514, -114.06214, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(362.4072, -41.458004, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(449.25574, 10.514248, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(349.51868, 142.42789, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(443.33627, 185.38504, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(363.78452, 316.9669, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(475.93097, 340.94128, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(365.2149, 490.91217, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(486.43527, 513.5845, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(444.4483, 507.6105, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(416.50848, 637.4184, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(338.23462, 694.9171, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(372.98447, 779.4888, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(420.8736, 891.0945, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(507.1576, 843.4946, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(478.8456, 688.17096, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(-1070.5345, 1346.2458, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(-1106.1759, 1532.6703, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(-990.37805, 1635.8531, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(-942.23785, 1498.6385, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(-805.0001, 1271.4116, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(-748.9459, 1510.5201, 30));
		AddSpawnPoint( "d_underfortress_30_2.Id3", "d_underfortress_30_2", Spot(-609.2138, 1419.1998, 30));

		// Rootcrystal_05 Spawn Points
		AddSpawnPoint( "d_underfortress_30_2.Id4", "d_underfortress_30_2", Spot(464.1523, -88.349594, 10));
		AddSpawnPoint( "d_underfortress_30_2.Id4", "d_underfortress_30_2", Spot(928.16284, -682.12683, 10));
		AddSpawnPoint( "d_underfortress_30_2.Id4", "d_underfortress_30_2", Spot(444.90115, 821.72394, 10));
		AddSpawnPoint( "d_underfortress_30_2.Id4", "d_underfortress_30_2", Spot(-252.21953, -649.2583, 10));
		AddSpawnPoint( "d_underfortress_30_2.Id4", "d_underfortress_30_2", Spot(-1249.6227, -692.98285, 10));
		AddSpawnPoint( "d_underfortress_30_2.Id4", "d_underfortress_30_2", Spot(-144.32831, 139.35674, 10));
		AddSpawnPoint( "d_underfortress_30_2.Id4", "d_underfortress_30_2", Spot(-759.00604, 777.573, 10));
		AddSpawnPoint( "d_underfortress_30_2.Id4", "d_underfortress_30_2", Spot(-824.41223, -88.03334, 10));
		AddSpawnPoint( "d_underfortress_30_2.Id4", "d_underfortress_30_2", Spot(932.99005, -160.37607, 10));
		AddSpawnPoint( "d_underfortress_30_2.Id4", "d_underfortress_30_2", Spot(943.31976, 879.76843, 10));
		AddSpawnPoint( "d_underfortress_30_2.Id4", "d_underfortress_30_2", Spot(612.89307, 1425.9076, 10));
		AddSpawnPoint( "d_underfortress_30_2.Id4", "d_underfortress_30_2", Spot(-253.99368, 1403.9988, 10));
		AddSpawnPoint( "d_underfortress_30_2.Id4", "d_underfortress_30_2", Spot(-1496.106, 379.96878, 10));
		AddSpawnPoint( "d_underfortress_30_2.Id4", "d_underfortress_30_2", Spot(-278.60052, 821.55414, 10));

	}
}
