//--- Melia Script -----------------------------------------------------------
// d_castle_19_1
//
//--- Description -----------------------------------------------------------
// Sets up the d_castle_19_1 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DCastle191MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("d_castle_19_1", MonsterId.Vilktis, Properties("MHP", 765642, "MINPATK", 10346, "MAXPATK", 12618, "MINMATK", 10346, "MAXMATK", 12618, "DEF", 240339, "MDEF", 240339));
		AddPropertyOverrides("d_castle_19_1", MonsterId.Trampled, Properties("MHP", 767254, "MINPATK", 10367, "MAXPATK", 12644, "MINMATK", 10367, "MAXMATK", 12644, "DEF", 241696, "MDEF", 241696));
		AddPropertyOverrides("d_castle_19_1", MonsterId.Tarnaite, Properties("MHP", 768911, "MINPATK", 10388, "MAXPATK", 12670, "MINMATK", 10388, "MAXMATK", 12670, "DEF", 243091, "MDEF", 243091));
		AddPropertyOverrides("d_castle_19_1", MonsterId.Sodininkas, Properties("MHP", 770612, "MINPATK", 10410, "MAXPATK", 12697, "MINMATK", 10410, "MAXMATK", 12697, "DEF", 244524, "MDEF", 244524));
		AddPropertyOverrides("d_castle_19_1", MonsterId.Viskal, Properties("MHP", 772356, "MINPATK", 10433, "MAXPATK", 12725, "MINMATK", 10433, "MAXMATK", 12725, "DEF", 245993, "MDEF", 245993));

		// Monster Spawners --------------------------------

		AddSpawner("d_castle_19_1.Id1", MonsterId.Vilktis, 45, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_castle_19_1.Id2", MonsterId.Trampled, 40, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_castle_19_1.Id3", MonsterId.Tarnaite, 25, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_castle_19_1.Id4", MonsterId.Sodininkas, 35, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_castle_19_1.Id5", MonsterId.Viskal, 15, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_castle_19_1.Id6", MonsterId.Tarnaite, 15, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_castle_19_1.Id7", MonsterId.Rootcrystal_02, 25, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Vilktis Spawn Points
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(-39.44987, -130.48468, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(30.732563, -62.4544, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(-87.69399, 20.138014, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(10.463661, 62.52517, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(72.819565, 122.10072, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(125.51407, 25.780987, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(146.07457, -116.65074, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(112.66314, -213.73547, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(2.8733444, -256.07965, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(-159.35573, -174.88562, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(95.05328, -532.4028, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(211.10887, -532.4266, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(-111.63474, -546.3453, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(-304.35266, -503.29245, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(-431.28867, -514.39624, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(-541.8633, -510.3612, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(476.62927, -528.99347, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(560.5628, -477.90195, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(700.46155, -524.0838, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(-179.85338, -57.1717, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(1058.2, 71.98017, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(1150.2205, 50.061607, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(1010.3213, -59.173786, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(880.5362, -67.69728, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(909.06165, 149.5153, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(517.0893, -16.094341, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(559.9706, 54.72899, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(543.62537, 318.96307, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(510.3796, 389.74518, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(514.8154, 666.1933, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(798.7729, 617.10474, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(924.3629, 675.6898, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(997.183, 485.60477, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(1045.6104, 640.8688, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(1062.3552, 721.4867, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(1030.5278, 584.80096, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(1112.745, 458.63824, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(1171.9716, 501.0307, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(869.0563, -525.24225, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(997.0033, -660.98224, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(1095.6261, -627.5172, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(1002.9446, -566.7284, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(1138.8741, -524.025, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(1132.7662, -405.69528, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(941.82587, -394.31226, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(1021.6964, -463.30728, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(-964.43536, -547.9629, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(-487.8593, -278.75922, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(-880.52057, 736.4612, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(-1172.95, 166.99962, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(-1034.5071, -56.76951, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(-1013.3356, 89.11682, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(-1158.2445, 8.578968, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(-1038.2141, 619.5812, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(-1180.5627, 645.5361, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(-1026.914, 739.9235, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(-906.0533, 628.08203, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(-707.82166, 652.4544, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(-523.16364, 662.06793, 25));
		AddSpawnPoint( "d_castle_19_1.Id1", "d_castle_19_1", Spot(-487.9701, 502.91504, 25));

		// Trampled Spawn Points
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(14.795624, 791.2915, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(-153.40591, 758.4053, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(127.04504, 737.4537, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(282.65778, 829.2872, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(530.45013, 825.1771, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(538.277, 511.7684, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(493.43906, 499.99094, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(481.88135, 260.62857, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(489.36584, 71.87461, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(699.2728, 56.700035, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(788.4207, 95.30288, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(995.426, 147.83286, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(1048.1276, 179.35034, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(991.8158, 32.981976, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(874.12134, 497.10544, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(963.67346, 589.1663, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(862.64215, 750.4942, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(1141.031, 721.0933, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(1121.6404, 592.50964, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(724.7801, 631.68304, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(521.81055, -217.6183, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(520.2395, -386.26678, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(355.3133, -533.41833, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(628.1079, -551.39636, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(760.2383, -524.5886, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(427.63873, 832.33765, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(141.0589, 846.0116, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(119.21986, -572.83234, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(-116.00643, -524.28253, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(-237.03572, -578.5838, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(-447.54175, -512.597, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(-724.47107, -522.6019, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(-41.352135, -359.93094, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(-52.06845, -163.64998, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(102.65419, -84.23024, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(138.24092, 35.67614, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(57.34163, 128.78706, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(940.3377, -456.69946, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(1063.9918, -422.39737, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(1095.3435, -569.49677, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(953.05646, -590.98315, 25));
		AddSpawnPoint( "d_castle_19_1.Id2", "d_castle_19_1", Spot(-565.7823, -525.27954, 25));

		// Tarnaite Spawn Points
		AddSpawnPoint( "d_castle_19_1.Id3", "d_castle_19_1", Spot(-1087.9135, 594.2368, 25));
		AddSpawnPoint( "d_castle_19_1.Id3", "d_castle_19_1", Spot(-898.34546, 601.3002, 25));
		AddSpawnPoint( "d_castle_19_1.Id3", "d_castle_19_1", Spot(-993.4015, 703.0946, 25));
		AddSpawnPoint( "d_castle_19_1.Id3", "d_castle_19_1", Spot(-948.7751, 746.697, 25));
		AddSpawnPoint( "d_castle_19_1.Id3", "d_castle_19_1", Spot(-778.65356, 633.7718, 25));
		AddSpawnPoint( "d_castle_19_1.Id3", "d_castle_19_1", Spot(-583.8585, 638.9138, 25));
		AddSpawnPoint( "d_castle_19_1.Id3", "d_castle_19_1", Spot(-491.94653, 384.38846, 25));
		AddSpawnPoint( "d_castle_19_1.Id3", "d_castle_19_1", Spot(-544.65356, 319.8045, 25));
		AddSpawnPoint( "d_castle_19_1.Id3", "d_castle_19_1", Spot(-1197.1852, 142.59065, 25));
		AddSpawnPoint( "d_castle_19_1.Id3", "d_castle_19_1", Spot(-1113.4309, 190.67953, 25));
		AddSpawnPoint( "d_castle_19_1.Id3", "d_castle_19_1", Spot(-1005.1548, 64.649155, 25));
		AddSpawnPoint( "d_castle_19_1.Id3", "d_castle_19_1", Spot(-860.2931, 98.4487, 25));
		AddSpawnPoint( "d_castle_19_1.Id3", "d_castle_19_1", Spot(-632.6764, 88.51742, 25));
		AddSpawnPoint( "d_castle_19_1.Id3", "d_castle_19_1", Spot(-509.09848, 129.73198, 25));
		AddSpawnPoint( "d_castle_19_1.Id3", "d_castle_19_1", Spot(-501.0123, 193.39703, 25));
		AddSpawnPoint( "d_castle_19_1.Id3", "d_castle_19_1", Spot(-548.7288, 485.88516, 25));
		AddSpawnPoint( "d_castle_19_1.Id3", "d_castle_19_1", Spot(-504.588, 590.19885, 25));
		AddSpawnPoint( "d_castle_19_1.Id3", "d_castle_19_1", Spot(-1136.3224, 751.5167, 25));
		AddSpawnPoint( "d_castle_19_1.Id3", "d_castle_19_1", Spot(-1081.3875, 513.32825, 25));
		AddSpawnPoint( "d_castle_19_1.Id3", "d_castle_19_1", Spot(-878.336, 676.0662, 25));
		AddSpawnPoint( "d_castle_19_1.Id3", "d_castle_19_1", Spot(-1000.87, 616.5942, 25));
		AddSpawnPoint( "d_castle_19_1.Id3", "d_castle_19_1", Spot(-947.33417, 495.20975, 25));
		AddSpawnPoint( "d_castle_19_1.Id3", "d_castle_19_1", Spot(-536.96844, -140.04555, 25));
		AddSpawnPoint( "d_castle_19_1.Id3", "d_castle_19_1", Spot(-570.64716, -351.30203, 25));
		AddSpawnPoint( "d_castle_19_1.Id3", "d_castle_19_1", Spot(-486.73587, -441.23328, 25));
		AddSpawnPoint( "d_castle_19_1.Id3", "d_castle_19_1", Spot(-627.92224, -541.46246, 25));
		AddSpawnPoint( "d_castle_19_1.Id3", "d_castle_19_1", Spot(-422.8438, -570.60455, 25));
		AddSpawnPoint( "d_castle_19_1.Id3", "d_castle_19_1", Spot(-341.21597, -503.28476, 25));
		AddSpawnPoint( "d_castle_19_1.Id3", "d_castle_19_1", Spot(-230.12509, -561.82214, 25));
		AddSpawnPoint( "d_castle_19_1.Id3", "d_castle_19_1", Spot(-172.51956, -493.68234, 25));
		AddSpawnPoint( "d_castle_19_1.Id3", "d_castle_19_1", Spot(3.1124191, -574.2803, 25));
		AddSpawnPoint( "d_castle_19_1.Id3", "d_castle_19_1", Spot(28.926651, -470.85394, 25));
		AddSpawnPoint( "d_castle_19_1.Id3", "d_castle_19_1", Spot(-27.038181, -414.84406, 25));

		// Sodininkas Spawn Points
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-1092.0294, -417.50162, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-1144.3815, -508.5278, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-1107.2009, -613.1379, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-932.03, -621.8033, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-968.284, -533.7366, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-961.97266, -388.66092, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-816.68335, -537.81805, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-655.571, -534.1788, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-521.0252, -564.2872, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-510.06805, -370.18213, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-563.50726, -331.56137, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-504.24506, -181.38649, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-558.6032, -43.64301, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-536.31195, 68.10213, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-646.06757, 50.182007, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-575.9124, 239.33385, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-1016.9063, -575.0216, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-1014.903, -464.4866, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-782.6166, 37.605255, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-1068.35, 50.358135, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-1155.9666, -47.04503, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-1323.3282, -27.015633, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-1139.6093, 60.935776, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-1283.307, 84.61632, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-735.00256, 96.40763, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-253.97292, -549.2128, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-187.5049, -490.8251, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-20.46642, -547.0936, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-14.829361, -363.45874, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-874.7475, -460.3677, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-554.3546, 349.02948, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-537.2745, 566.6158, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-484.00638, 654.1474, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-628.8971, 619.55206, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-728.43176, 674.7999, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-871.90076, 630.00476, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-939.7234, 781.7192, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-1045.4775, 689.74036, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-1140.4958, 615.50635, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-948.59686, 508.60675, 25));
		AddSpawnPoint( "d_castle_19_1.Id4", "d_castle_19_1", Spot(-1111.6776, 808.3529, 25));

		// Viskal Spawn Points
		AddSpawnPoint( "d_castle_19_1.Id5", "d_castle_19_1", Spot(-13.778053, -30.522697, 100));
		AddSpawnPoint( "d_castle_19_1.Id5", "d_castle_19_1", Spot(-990.3074, -528.77185, 100));
		AddSpawnPoint( "d_castle_19_1.Id5", "d_castle_19_1", Spot(-1182.6564, 75.04757, 100));
		AddSpawnPoint( "d_castle_19_1.Id5", "d_castle_19_1", Spot(-540.6411, 72.07695, 100));
		AddSpawnPoint( "d_castle_19_1.Id5", "d_castle_19_1", Spot(-1024.2203, 673.9256, 100));
		AddSpawnPoint( "d_castle_19_1.Id5", "d_castle_19_1", Spot(545.3379, 588.5737, 100));
		AddSpawnPoint( "d_castle_19_1.Id5", "d_castle_19_1", Spot(563.15247, 61.49205, 100));
		AddSpawnPoint( "d_castle_19_1.Id5", "d_castle_19_1", Spot(1052.9474, 44.76241, 100));
		AddSpawnPoint( "d_castle_19_1.Id5", "d_castle_19_1", Spot(1009.5229, 670.0569, 100));
		AddSpawnPoint( "d_castle_19_1.Id5", "d_castle_19_1", Spot(1008.3394, -527.42944, 100));
		AddSpawnPoint( "d_castle_19_1.Id5", "d_castle_19_1", Spot(499.60538, -527.6644, 100));
		AddSpawnPoint( "d_castle_19_1.Id5", "d_castle_19_1", Spot(-5.0401115, -528.4195, 100));
		AddSpawnPoint( "d_castle_19_1.Id5", "d_castle_19_1", Spot(-438.86227, -568.4132, 100));

		// Tarnaite Spawn Points
		AddSpawnPoint( "d_castle_19_1.Id6", "d_castle_19_1", Spot(889.4263, 588.33075, 30));
		AddSpawnPoint( "d_castle_19_1.Id6", "d_castle_19_1", Spot(975.5737, 716.5605, 30));
		AddSpawnPoint( "d_castle_19_1.Id6", "d_castle_19_1", Spot(1042.7722, 579.802, 30));
		AddSpawnPoint( "d_castle_19_1.Id6", "d_castle_19_1", Spot(1074.278, 509.35956, 30));
		AddSpawnPoint( "d_castle_19_1.Id6", "d_castle_19_1", Spot(652.51697, 609.63635, 30));
		AddSpawnPoint( "d_castle_19_1.Id6", "d_castle_19_1", Spot(539.4126, 616.0532, 30));
		AddSpawnPoint( "d_castle_19_1.Id6", "d_castle_19_1", Spot(521.3946, 118.67351, 30));
		AddSpawnPoint( "d_castle_19_1.Id6", "d_castle_19_1", Spot(745.2559, 50.855526, 30));
		AddSpawnPoint( "d_castle_19_1.Id6", "d_castle_19_1", Spot(1118.773, -26.837502, 30));
		AddSpawnPoint( "d_castle_19_1.Id6", "d_castle_19_1", Spot(1114.9502, 147.27701, 30));
		AddSpawnPoint( "d_castle_19_1.Id6", "d_castle_19_1", Spot(909.0735, 1.3405457, 30));
		AddSpawnPoint( "d_castle_19_1.Id6", "d_castle_19_1", Spot(843.3143, 135.08835, 30));
		AddSpawnPoint( "d_castle_19_1.Id6", "d_castle_19_1", Spot(930.3284, -593.93976, 30));
		AddSpawnPoint( "d_castle_19_1.Id6", "d_castle_19_1", Spot(1081.0349, -575.8063, 30));
		AddSpawnPoint( "d_castle_19_1.Id6", "d_castle_19_1", Spot(1105.1323, -435.37436, 30));
		AddSpawnPoint( "d_castle_19_1.Id6", "d_castle_19_1", Spot(901.3174, -437.01996, 30));
		AddSpawnPoint( "d_castle_19_1.Id6", "d_castle_19_1", Spot(732.4597, -535.9237, 30));
		AddSpawnPoint( "d_castle_19_1.Id6", "d_castle_19_1", Spot(482.4948, -552.25446, 30));
		AddSpawnPoint( "d_castle_19_1.Id6", "d_castle_19_1", Spot(201.43904, -497.20807, 30));
		AddSpawnPoint( "d_castle_19_1.Id6", "d_castle_19_1", Spot(508.4069, -292.49374, 30));
		AddSpawnPoint( "d_castle_19_1.Id6", "d_castle_19_1", Spot(522.7965, 35.060074, 30));

		// Rootcrystal_02 Spawn Points
		AddSpawnPoint( "d_castle_19_1.Id7", "d_castle_19_1", Spot(486.584, 842.82794, 200));
		AddSpawnPoint( "d_castle_19_1.Id7", "d_castle_19_1", Spot(523.426, 593.0881, 200));
		AddSpawnPoint( "d_castle_19_1.Id7", "d_castle_19_1", Spot(778.03656, 617.0334, 200));
		AddSpawnPoint( "d_castle_19_1.Id7", "d_castle_19_1", Spot(1046.5846, 494.45837, 200));
		AddSpawnPoint( "d_castle_19_1.Id7", "d_castle_19_1", Spot(1081.3267, 744.6396, 200));
		AddSpawnPoint( "d_castle_19_1.Id7", "d_castle_19_1", Spot(510.26892, 316.17743, 200));
		AddSpawnPoint( "d_castle_19_1.Id7", "d_castle_19_1", Spot(516.30725, 71.41687, 200));
		AddSpawnPoint( "d_castle_19_1.Id7", "d_castle_19_1", Spot(857.43085, 113.58009, 200));
		AddSpawnPoint( "d_castle_19_1.Id7", "d_castle_19_1", Spot(1099.5355, 11.276745, 200));
		AddSpawnPoint( "d_castle_19_1.Id7", "d_castle_19_1", Spot(534.53143, -204.16664, 200));
		AddSpawnPoint( "d_castle_19_1.Id7", "d_castle_19_1", Spot(538.5963, -540.664, 200));
		AddSpawnPoint( "d_castle_19_1.Id7", "d_castle_19_1", Spot(798.31476, -520.50586, 200));
		AddSpawnPoint( "d_castle_19_1.Id7", "d_castle_19_1", Spot(1022.5546, -414.99893, 200));
		AddSpawnPoint( "d_castle_19_1.Id7", "d_castle_19_1", Spot(1088.1951, -627.58014, 200));
		AddSpawnPoint( "d_castle_19_1.Id7", "d_castle_19_1", Spot(319.58057, -529.5444, 200));
		AddSpawnPoint( "d_castle_19_1.Id7", "d_castle_19_1", Spot(-4.222412, -495.42538, 200));
		AddSpawnPoint( "d_castle_19_1.Id7", "d_castle_19_1", Spot(65.86931, -120.82526, 200));
		AddSpawnPoint( "d_castle_19_1.Id7", "d_castle_19_1", Spot(-71.375946, 64.93375, 200));
		AddSpawnPoint( "d_castle_19_1.Id7", "d_castle_19_1", Spot(-285.32132, -534.05145, 200));
		AddSpawnPoint( "d_castle_19_1.Id7", "d_castle_19_1", Spot(-635.9406, -512.67596, 200));
		AddSpawnPoint( "d_castle_19_1.Id7", "d_castle_19_1", Spot(-948.6088, -633.283, 200));
		AddSpawnPoint( "d_castle_19_1.Id7", "d_castle_19_1", Spot(-1086.1569, -438.9989, 200));
		AddSpawnPoint( "d_castle_19_1.Id7", "d_castle_19_1", Spot(-531.66846, -221.17508, 200));
		AddSpawnPoint( "d_castle_19_1.Id7", "d_castle_19_1", Spot(-539.1412, 94.65118, 200));
		AddSpawnPoint( "d_castle_19_1.Id7", "d_castle_19_1", Spot(-1255.3844, 90.99378, 200));
		AddSpawnPoint( "d_castle_19_1.Id7", "d_castle_19_1", Spot(-949.70184, 56.18118, 200));
		AddSpawnPoint( "d_castle_19_1.Id7", "d_castle_19_1", Spot(-503.96487, 592.49585, 200));
		AddSpawnPoint( "d_castle_19_1.Id7", "d_castle_19_1", Spot(-849.1421, 556.7071, 200));
		AddSpawnPoint( "d_castle_19_1.Id7", "d_castle_19_1", Spot(-1080.9094, 715.30316, 200));

	}
}
